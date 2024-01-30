using AreaOutputCalculator.Helpers;
using AreaOutputCalculator.Models;

SolarPanel[] panels = new[]
{
    new SolarPanel(3, 3, 10),
    new SolarPanel(2, 7, 12),
    new SolarPanel(3, 4, 14),
};

var landArea = 81;

var areaCalculatorHelper = new AreaCalculatorHelper();
var outcome = areaCalculatorHelper.MaxOutput(panels, landArea);

Console.Write(outcome);