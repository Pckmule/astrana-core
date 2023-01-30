using Astrana.Core.Configuration.Constants;
using Astrana.Core.Configuration.Exceptions;
using Astrana.Core.Configuration.Extensions;
using Astrana.Core.Enums;
using Astrana.Core.Tests.Mock;
using Microsoft.Extensions.Configuration;

namespace Astrana.Core.Tests.Unit.Extensions
{
    // ReSharper disable once InconsistentNaming
    public class IConfigurationExtensionsTests
    {
        // Method Name, Behaviour/Outcome, Condition(s)
        [Fact]
        public void GetDatabaseProvider_MustThrowArgumentNullException_WhenConfigurationIsNull()
        {
            // Arrange
            IConfiguration mockConfiguration = null;

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => mockConfiguration.GetDatabaseProvider());
        }

        [Fact]
        public void GetDatabaseProvider_MustThrowApplicationConfigurationException_WhenDatabaseProviderIsNull()
        {
            // Arrange
            var mockConfiguration = MockHelper.MockApplicationConfiguration();

            mockConfiguration[ApplicationConfigurationKeys.DatabaseProvider] = null;

            // Act and Assert
            Assert.Throws<ApplicationConfigurationException>(() => mockConfiguration.GetDatabaseProvider());
        }

        [Fact]
        public void GetDatabaseProvider_MustThrowApplicationConfigurationException_WhenDatabaseProviderIsEmpty()
        {
            // Arrange
            var mockConfiguration = MockHelper.MockApplicationConfiguration();

            mockConfiguration[ApplicationConfigurationKeys.DatabaseProvider] = "";

            // Act and Assert
            Assert.Throws<ApplicationConfigurationException>(() => mockConfiguration.GetDatabaseProvider());
        }

        [Fact]
        public void GetDatabaseProvider_MustThrowApplicationConfigurationException_WhenDatabaseProviderIsWhitespace()
        {
            // Arrange
            var mockConfiguration = MockHelper.MockApplicationConfiguration();

            mockConfiguration[ApplicationConfigurationKeys.DatabaseProvider] = " ";

            // Act and Assert
            Assert.Throws<ApplicationConfigurationException>(() => mockConfiguration.GetDatabaseProvider());
        }

        [Fact]
        public void GetDatabaseProvider_MustThrowArgumentNullException_WhenCalled()
        {
            // Arrange
            const DatabaseProvider expectedDatabaseProvider = DatabaseProvider.MSSqlServer;
            var mockConfiguration = MockHelper.MockApplicationConfiguration();

            // Act
            var databaseProvider = mockConfiguration.GetDatabaseProvider();

            // Assert
            Assert.Equal(expectedDatabaseProvider, databaseProvider);
        }

        [Fact]
        public void GetConnectionStringByDatabaseProvider_MustThrowArgumentNullException_WhenConfigurationIsNull()
        {
            // Arrange
            IConfiguration mockConfiguration = null;

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => mockConfiguration.GetConnectionStringByDatabaseProvider());
        }

        [Fact]
        public void GetConnectionStringByDatabaseProvider_MustThrowApplicationConfigurationException_WhenConnectionStringIsNull()
        {
            // Arrange
            var mockConfiguration = MockHelper.MockApplicationConfiguration();

            mockConfiguration[ApplicationConfigurationKeys.ConnectionStringsMsSqlServer] = null;

            // Act and Assert
            Assert.Throws<ApplicationConfigurationException>(() => mockConfiguration.GetConnectionStringByDatabaseProvider());
        }

        [Fact]
        public void GetConnectionStringByDatabaseProvider_MustThrowApplicationConfigurationException_WhenConnectionStringIsEmpty()
        {
            // Arrange
            var mockConfiguration = MockHelper.MockApplicationConfiguration();

            mockConfiguration[ApplicationConfigurationKeys.ConnectionStringsMsSqlServer] = "";

            // Act and Assert
            Assert.Throws<ApplicationConfigurationException>(() => mockConfiguration.GetConnectionStringByDatabaseProvider());
        }

        [Fact]
        public void GetConnectionStringByDatabaseProvider_MustThrowApplicationConfigurationException_WhenConnectionStringIsWhitespace()
        {
            // Arrange
            var mockConfiguration = MockHelper.MockApplicationConfiguration();

            mockConfiguration[ApplicationConfigurationKeys.ConnectionStringsMsSqlServer] = " ";

            // Act and Assert
            Assert.Throws<ApplicationConfigurationException>(() => mockConfiguration.GetConnectionStringByDatabaseProvider());
        }

        [Fact]
        public void GetConnectionStringByDatabaseProvider_MustThrowArgumentNullException_WhenCalled()
        {
            // Arrange
            const string expectedConnectionString = Mock.Constants.MsSqlConnectionString;

            var mockConfiguration = MockHelper.MockApplicationConfiguration();

            // Act
            var connectionString = mockConfiguration.GetConnectionStringByDatabaseProvider();

            // Assert
            Assert.Equal(expectedConnectionString, connectionString);
        }
    }
}