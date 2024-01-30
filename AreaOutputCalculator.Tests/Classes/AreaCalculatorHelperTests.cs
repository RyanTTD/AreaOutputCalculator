using AreaOutputCalculator.Helpers;
using AreaOutputCalculator.Tests.Builders;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOutputCalculator.Tests.Classes
{
    [TestFixture]
    public class AreaCalculatorHelperTests
    {
        [TestFixture]
        public class MaxOutput
        {
            [Test]
            public void Given_ValidData_Must_ReturnValueGreaterThanZero()
            {
                var areaCalculatorHelperToTest = new AreaCalculatorHelper();

                var solarPanelArea = 100;
                var solarPanelsToInput = new DataBuilder()
                    .BuildWithWorkingData();

                var expectedOutcome = 0;

                var actualOutcome = areaCalculatorHelperToTest.MaxOutput(solarPanelsToInput, solarPanelArea);

                actualOutcome.Should().BeGreaterThan(expectedOutcome);
            }

            [Test]
            public void Given_ValidData_And_NegativeArea_Must_ReturnZero()
            {
                var areaCalculatorHelperToTest = new AreaCalculatorHelper();

                var solarPanelArea = -93;
                var solarPanelsToInput = new DataBuilder()
                    .BuildWithWorkingData();

                var expectedOutcome = 0;

                var actualOutcome = areaCalculatorHelperToTest.MaxOutput(solarPanelsToInput, solarPanelArea);

                actualOutcome.Should().Be(expectedOutcome);
            }

            [Test]
            public void Given_MoreValidData_Must_ReturnValueGreaterThanZero()
            {
                var areaCalculatorHelperToTest = new AreaCalculatorHelper();

                var solarPanelArea = 100;
                var solarPanelsToInput = new DataBuilder()
                    .BuildWithMoreWorkingData();

                var expectedOutcome = 0;

                var actualOutcome = areaCalculatorHelperToTest.MaxOutput(solarPanelsToInput, solarPanelArea);

                actualOutcome.Should().BeGreaterThan(expectedOutcome);
            }

            [Test]
            public void Given_LastValidData_Must_ReturnValueGreaterThanZero()
            {
                var areaCalculatorHelperToTest = new AreaCalculatorHelper();

                var solarPanelArea = 100;
                var solarPanelsToInput = new DataBuilder()
                    .BuildWithLastWorkingData();

                var expectedOutcome = 0;

                var actualOutcome = areaCalculatorHelperToTest.MaxOutput(solarPanelsToInput, solarPanelArea);

                actualOutcome.Should().BeGreaterThan(expectedOutcome);
            }

            [Test]
            public void Given_ValidData_Must_ReturnExactValue()
            {
                var areaCalculatorHelperToTest = new AreaCalculatorHelper();

                var solarPanelArea = 100;
                var solarPanelsToInput = new DataBuilder()
                    .BuildWithWorkingData();

                var expectedOutcome = 2115;

                var actualOutcome = areaCalculatorHelperToTest.MaxOutput(solarPanelsToInput, solarPanelArea);

                actualOutcome.Should().BeGreaterThanOrEqualTo(expectedOutcome);
            }

            [Test]
            public void Given_ValidData_And_LowLandArea_Must_ReturnZero()
            {
                var areaCalculatorHelperToTest = new AreaCalculatorHelper();

                var solarPanelArea = 2;
                var solarPanelsToInput = new DataBuilder()
                    .BuildWithWorkingData();

                var expectedOutcome = 0;

                var actualOutcome = areaCalculatorHelperToTest.MaxOutput(solarPanelsToInput, solarPanelArea);

                actualOutcome.Should().Be(expectedOutcome);
            }

            [Test]
            public void Given_NoData_Must_ReturnZero()
            {
                var areaCalculatorHelperToTest = new AreaCalculatorHelper();

                var solarPanelArea = 100;
                var solarPanelsToInput = new DataBuilder()
                    .BuildWithNoData();

                var expectedOutcome = 0;

                var actualOutcome = areaCalculatorHelperToTest.MaxOutput(solarPanelsToInput, solarPanelArea);

                actualOutcome.Should().Be(expectedOutcome);
            }

            [Test]
            public void Given_LotsOfData_Must_ReturnExactValue()
            {
                var areaCalculatorHelperToTest = new AreaCalculatorHelper();

                var solarPanelArea = 100;
                var solarPanelsToInput = new DataBuilder()
                    .BuildWithLotsOfData();

                var expectedOutcome = 2198;

                var actualOutcome = areaCalculatorHelperToTest.MaxOutput(solarPanelsToInput, solarPanelArea);

                actualOutcome.Should().BeGreaterThanOrEqualTo(expectedOutcome);
            }
        }
    }
}
