using System;
using System.Collections.Generic;
using System.Fakes;
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

        public EnvironmentWrap EnvironmentWrap { get; set; }

        [Test]
        [UseShimsContext]
        public void Is64BitOperatingSystem_EnvironmentIs64BitOperatingSystemIsFalse_ReturnsFalse()
        {
            // Arrange
            ShimEnvironment.Is64BitOperatingSystemGet = () => false;

            // Act
            var actualValue = EnvironmentWrap.Is64BitOperatingSystem;

            // Assert
            Assert.IsFalse(actualValue, "EnvironmentWrap.Is64BitOperatingSystem must return false when Environment.Is64BitOperatingSystem returns false.");
        }

        [Test]
        [UseShimsContext]
        public void Is64BitOperatingSystem_EnvironmentIs64BitOperatingSystemIsTrue_ReturnsTrue()
        {
            // Arrange
            ShimEnvironment.Is64BitOperatingSystemGet = () => true;

            // Act
            var actualValue = EnvironmentWrap.Is64BitOperatingSystem;

            // Assert
            Assert.IsTrue(actualValue, "EnvironmentWrap.Is64BitOperatingSystem must return true when Environment.Is64BitOperatingSystem returns true.");
        }

        [Test]
        [UseShimsContext]
        public void Is64BitProcess_EnvironmentIs64BitProcessIsFalse_ReturnsFalse()
        {
            // Arrange
            ShimEnvironment.Is64BitProcessGet = () => false;

            // Act
            var actualValue = EnvironmentWrap.Is64BitProcess;

            // Assert
            Assert.IsFalse(actualValue, "EnvironmentWrap.Is64BitProcess must return false when Environment.Is64BitProcess returns false.");
        }

        [Test]
        [UseShimsContext]
        public void Is64BitProcess_EnvironmentIs64BitProcessIsFalseTrue_ReturnsTrue()
        {
            // Arrange
            ShimEnvironment.Is64BitProcessGet = () => true;

            // Act
            var actualValue = EnvironmentWrap.Is64BitProcess;

            // Assert
            Assert.IsTrue(actualValue, "EnvironmentWrap.Is64BitProcess must return true when Environment.Is64BitProcess returns true.");
        }
    }
}
