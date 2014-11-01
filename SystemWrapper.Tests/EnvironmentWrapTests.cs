using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace SystemWrapper.Tests
{
    using SystemInterface;

    [TestFixture]
    public class EnvironmentWrapTests
    {
        [SetUp]
        public void SetUp()
        {
            this.EnvironmentWrap = new EnvironmentWrap();
        }

        public IEnvironment EnvironmentWrap { get; set; }

        [Test]
        public void Is64BitOperatingSystem_CurrentEnvironment_ReturnsCorrectValue()
        {
            // Arrange
            var expectedValue = Environment.Is64BitOperatingSystem;

            // Act
            var actualValue = this.EnvironmentWrap.Is64BitOperatingSystem;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Is64BitProcess_CurrentEnvironment_ReturnsCorrectValue()
        {
            // Arrange
            var expectedValue = Environment.Is64BitProcess;

            // Act
            var actualValue = this.EnvironmentWrap.Is64BitProcess;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
