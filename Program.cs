using AreaOutputCalculator.Models;

SolarPanel[] panels = new[]
{
    new SolarPanel(3, 3, 10),
    new SolarPanel(2, 7, 12),
    new SolarPanel(3, 4, 14),
};

var landArea = 81;

Console.Write(MaxOutput(panels, landArea));

int MaxOutput(SolarPanel[] panels, int landArea)
{
    var result = 0;
    int tempResult = 0;

    // order the panels to get the "biggest area" first
    panels = panels.OrderByDescending(o => o.PanelArea).ToArray();
    result = GetPanelsTotal(panels, landArea);

    // order the panels to get the "highest OutputPerUnitArea" first
    panels = panels.OrderByDescending(o => o.OutputPerUnitArea).ToArray();
    tempResult = GetPanelsTotal(panels, landArea);
    if (tempResult > result) result = tempResult;

    // order the panels to get the "highest OutputPerUnitArea by area" first
    panels = panels.OrderByDescending(o => (o.TotalUnitOutput)).ToArray();
    tempResult = GetPanelsTotal(panels, landArea);
    if (tempResult > result) result = tempResult;

    // order the panels to get the "highest ratio of OutputPerUnitArea vs area" first
    panels = panels.OrderByDescending(o => o.UnitOutputToAreaRatio).ToArray();
    tempResult = GetPanelsTotal(panels, landArea);
    if (tempResult > result) result = tempResult;

    return result;
}

int GetPanelsTotal(SolarPanel[] panels, int landArea)
{
    var result = 0;

    foreach (var panel in panels)
    {
        while (landArea > panel.PanelArea)
        {
            landArea -= panel.PanelArea;
            result += panel.TotalUnitOutput;
        }
    }

    return result;
}