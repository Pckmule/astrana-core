using Astrana.Core.Attributes;

namespace Astrana.Core.Data.Tests.Unit
{
    public class PersonalDataAttributeTests
    {
        [Fact]
        public void Attribute_MustOnlyTarget_Properties()
        {
            // Arrange
            var expectedAttributeTargets = new List<AttributeTargets> { AttributeTargets.Property };
            var attribute = new PersonalDataAttribute();
            
            // Act
            var usageAttributes = ((IList<AttributeUsageAttribute>)typeof(PersonalDataAttribute).GetCustomAttributes(typeof(AttributeUsageAttribute), false)).ToList();
            
            // Assert
            Assert.Single(usageAttributes);

            foreach (var expectedTarget in expectedAttributeTargets)
            {
                Assert.Contains(usageAttributes, o => o.ValidOn == expectedTarget);
            }
        }
    }
}