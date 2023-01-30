/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Validation.Attributes;
using Astrana.Core.Validation.Enums;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Astrana.Core.Validation
{
    public static class ValidationUtility
    {
        public static EntityValidationResult ValidateDomainModel<TDomainModel>(this TDomainModel instance, object? parentInstance = null) where TDomainModel : class
        {
            var validationResults = new List<EntityValidationResult>();

            validationResults.ValidateObjectProperties(instance);

            return new EntityValidationResult(parentInstance == null ? instance.GetType().Name : $"{parentInstance.GetType().Name}.{instance.GetType().Name}", ValidatedEntityType.DomainModel, validationResults);
        }

        public static EntityValidationResult ValidateDataEntity<TEntity>(this TEntity instance) where TEntity : class
        {
            var validationResults = new List<EntityValidationResult>();

            validationResults.ValidateObjectProperties(instance);
            
            return new EntityValidationResult(instance.GetType().Name, ValidatedEntityType.DataEntity, validationResults);
        }

        public static EntityValidationResult ValidateDto<TDto>(this TDto instance) where TDto : class
        {
            var validationResults = new List<EntityValidationResult>();

            validationResults.ValidateObjectProperties(instance);

            return new EntityValidationResult(instance.GetType().Name, ValidatedEntityType.DataTransferObject, validationResults);
        }

        public static EntityValidationResult ValidateViewModel<TViewModel>(this TViewModel instance) where TViewModel : class
        {
            var validationResults = new List<EntityValidationResult>();

            validationResults.ValidateObjectProperties(instance);

            return new EntityValidationResult(instance.GetType().Name, ValidatedEntityType.ViewModel, validationResults);
        }

        public static void ValidateObjectProperties<TModel>(this List<EntityValidationResult> validationResults, TModel instance) where TModel : class
        {
            if (instance.GetType().IsAbstract)
                return;

            foreach (var property in typeof(TModel).GetMembers().Where(m => m.MemberType == MemberTypes.Property).ToList())
            {
                var propertyInfo = instance.GetType().GetProperty(property.Name);

                if (propertyInfo == null || propertyInfo.Name.ToLower() == "isvalid")
                    continue;

                var propertyValue = instance.GetPropertyValue(property.Name);
                    propertyValue = propertyValue == null ? null : Convert.ChangeType(propertyValue, Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType);

                if (propertyInfo.IsObjectProperty())
                {
                    if(propertyValue == null)
                        continue;

                    var validationResult = propertyValue.ValidateDomainModel(instance);
                    
                    if(!validationResult.IsSuccess)
                        validationResults.Add(validationResult);
                }
                else
                {
                    foreach (var validationAttribute in property.GetCustomAttributes().Where(a => a is ValidationAttribute))
                    {
                        CheckValidationAttribute(validationResults, validationAttribute, propertyValue, property.Name);
                    }
                }
            }
        }

        private static void CheckValidationAttribute(ICollection<EntityValidationResult> validationResults, Attribute validationAttribute, object? propertyValue, string propertyName)
        {
            if(validationAttribute is not RequiredAttribute && propertyValue == null)
                return;

            switch (validationAttribute)
            {
                case MinLengthWhenSetAttribute minLengthAttribute:
                {
                    var length = (propertyValue as string)?.Length ?? 0;

                    if (length < minLengthAttribute.Length)
                        validationResults.Add(new EntityValidationResult(propertyName, ValidatedEntityType.Property, message: $"Length must be no less than {minLengthAttribute.Length}.", outcome: ValidationOutcome.Failed));

                    break;
                }
                case MinLengthAttribute minLengthAttribute:
                {
                    var length = (propertyValue as string)?.Length ?? 0;

                    if (length < minLengthAttribute.Length)
                        validationResults.Add(new EntityValidationResult(propertyName, ValidatedEntityType.Property, message: $"Length must be no less than {minLengthAttribute.Length}.", outcome: ValidationOutcome.Failed));

                    break;
                }
                case MaxLengthWhenSetAttribute maxLengthAttribute:
                {
                    var length = (propertyValue as string)?.Length ?? 0;

                    if (length > maxLengthAttribute.Length)
                        validationResults.Add(new EntityValidationResult(propertyName, ValidatedEntityType.Property, message: $"Length must be no more than {maxLengthAttribute.Length}.", outcome: ValidationOutcome.Failed));

                    break;
                }
                case MaxLengthAttribute maxLengthAttribute:
                {
                    var length = (propertyValue as string)?.Length ?? 0;

                    if (length > maxLengthAttribute.Length)
                        validationResults.Add(new EntityValidationResult(propertyName, ValidatedEntityType.Property, message: $"Length must be no more than {maxLengthAttribute.Length}.", outcome: ValidationOutcome.Failed));

                    break;
                }
                case RangeAttribute rangeValidation:
                {
                    var value = propertyValue as int?;

                    if (!int.TryParse(rangeValidation.Minimum.ToString(), out var minimumRange)) return;
                    if (!int.TryParse(rangeValidation.Maximum.ToString(), out var maximumRange)) return;

                    if (!rangeValidation.IsValid(value))
                        validationResults.Add(new EntityValidationResult(propertyName, ValidatedEntityType.Property, message: "Out of range.", outcome: ValidationOutcome.Failed));

                    if (value < minimumRange)
                        validationResults.Add(new EntityValidationResult(propertyName, ValidatedEntityType.Property, message: "Out of minimum range.", outcome: ValidationOutcome.Failed));

                    if (value > maximumRange)
                        validationResults.Add(new EntityValidationResult(propertyName, ValidatedEntityType.Property, message: "Out of maximum range.", outcome: ValidationOutcome.Failed));

                    break;
                }
                case PhoneAttribute phoneAttribute:
                {
                    var value = propertyValue as string;

                    if (!phoneAttribute.IsValid(value))
                        validationResults.Add(new EntityValidationResult(propertyName, ValidatedEntityType.Property, message: $"Invalid phone number {phoneAttribute.ErrorMessage}", outcome: ValidationOutcome.Failed));

                    break;
                }
                case EmailAddressAttribute emailAddressAttribute:
                {
                    var value = propertyValue as string;

                    if (!emailAddressAttribute.IsValid(value))
                        validationResults.Add(new EntityValidationResult(propertyName, ValidatedEntityType.Property, message: $"Invalid e-mail address. {emailAddressAttribute.ErrorMessage}", outcome: ValidationOutcome.Failed));

                    break;
                }
                case UrlAttribute urlAttribute:
                {
                    var value = propertyValue as string;

                    if (!urlAttribute.IsValid(value))
                        validationResults.Add(new EntityValidationResult(propertyName, ValidatedEntityType.Property, message: $"Invalid URL. {urlAttribute.ErrorMessage}", outcome: ValidationOutcome.Failed));

                    break;
                }
                case SecureWebAddressAttribute secureWebAddressAttribute:
                {
                    var value = propertyValue as string;

                    if (!secureWebAddressAttribute.IsValid(value))
                        validationResults.Add(new EntityValidationResult(propertyName, ValidatedEntityType.Property, message: $"Invalid Web Address. {secureWebAddressAttribute.ErrorMessage}", outcome: ValidationOutcome.Failed));

                    break;
                }
                case FileExtensionsAttribute fileExtensionsAttribute:
                {
                    var value = propertyValue as string;

                    if (!fileExtensionsAttribute.IsValid(value))
                        validationResults.Add(new EntityValidationResult(propertyName, ValidatedEntityType.Property, message: $"Invalid file extension. {fileExtensionsAttribute.ErrorMessage}", outcome: ValidationOutcome.Failed));
                    break;
                }
                case CreditCardAttribute creditCardAttribute:
                {
                    var value = propertyValue as string;

                    if (!creditCardAttribute.IsValid(value))
                        validationResults.Add(new EntityValidationResult(propertyName, ValidatedEntityType.Property, message: $"Invalid credit card number. {creditCardAttribute.ErrorMessage}", outcome: ValidationOutcome.Failed));

                    break;
                }
                case RequiredEnumAttribute requiredEnumAttribute:
                {
                    if (!requiredEnumAttribute.IsValid(propertyValue))
                        validationResults.Add(new EntityValidationResult(propertyName, ValidatedEntityType.Property, message: $"A valid value is required. {requiredEnumAttribute.ErrorMessage}", outcome: ValidationOutcome.Failed));

                    break;
                }
                case RequiredAttribute requiredAttribute:
                {
                    if (!requiredAttribute.IsValid(propertyValue))
                        validationResults.Add(new EntityValidationResult(propertyName, ValidatedEntityType.Property, message: $"A valid value is required. {requiredAttribute.ErrorMessage}", outcome: ValidationOutcome.Failed));

                    break;
                }
            }
        }

        private static bool IsObjectProperty(this PropertyInfo propertyInfo)
        {
            if (propertyInfo.PropertyType.Name.ToLower() == "string")
                return false;

            return propertyInfo.PropertyType.IsClass || propertyInfo.PropertyType.IsInterface;
        }

        private static object? GetPropertyValue<TModel>(this TModel instance, string name) where TModel : class
        {
            return instance.GetType().IsAbstract ? null : instance.GetType().GetProperty(name)?.GetValue(instance, null);
        }
    }
}
