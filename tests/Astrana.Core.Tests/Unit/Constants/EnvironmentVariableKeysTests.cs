using Astrana.Core.Configuration.Constants;

namespace Astrana.Core.Tests.Unit.Constants
{
    public class EnvironmentVariableKeysTests
    {
        [Fact]
        public void BuildKey_MustThrowArgumentException_WhenKeyNameIsNull()
        {
            // Arrange
            string? keyName = null;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => EnvironmentVariableKeys.BuildKey(keyName));
        }

        [Fact]
        public void BuildKey_MustThrowArgumentException_WhenKeyNameIsEmpty()
        {
            // Arrange
            const string keyName = "";

            // Act and Assert
            Assert.Throws<ArgumentException>(() => EnvironmentVariableKeys.BuildKey(keyName));
        }

        [Fact]
        public void BuildKey_MustThrowArgumentException_WhenKeyNameIsWhitespace()
        {
            // Arrange
            const string keyName = " ";

            // Act and Assert
            Assert.Throws<ArgumentException>(() => EnvironmentVariableKeys.BuildKey(keyName));
        }

        [Fact]
        public void BuildKey_MustReturnValidKey_WhenKeyNameIsProvided()
        {
            // Arrange
            const string keyName = "MockKeyName";

            // Act
            var key = EnvironmentVariableKeys.BuildKey(keyName);

            // Assert
            Assert.StartsWith(EnvironmentVariableKeys.VariablesBase + "_", key);
            Assert.EndsWith(keyName, key);
        }
    }
}