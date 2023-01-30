using Astrana.Core.Configuration.Constants;

namespace Astrana.Core.Configuration.Tests.Unit
{
    public class EncryptionUtilityTests
    {
        [Fact]
        public void EncryptString_MustThrowArgumentException_WhenKeyNameIsNull()
        {
            // Arrange
            string? plainText = null;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => EncryptionUtility.EncryptString(plainText));
        }

        [Fact]
        public void EncryptString_MustReturnValidKey_WhenKeyNameIsProvided()
        {
            // Arrange
            const string plainText = "This is a test.";

            // Act
            var key = EncryptionUtility.EncryptString(plainText);

            // Assert
            Assert.StartsWith(EnvironmentVariableKeys.VariablesBase + "_", key);
            Assert.EndsWith(plainText, key);
        }
    }
}
