/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Configuration;
using Astrana.Core.Configuration.Constants;

namespace Astrana.Core.Tests.Unit
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
