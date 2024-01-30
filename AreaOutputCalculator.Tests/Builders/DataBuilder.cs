using AreaOutputCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOutputCalculator.Tests.Builders
{
    public class DataBuilder
    {
        public SolarPanel[] BuildWithWorkingData()
        {
            SolarPanel[] panels = new[]
            {
                new SolarPanel(2, 5, 12),
                new SolarPanel(4, 12, 20),
                new SolarPanel(5, 5, 25),
            };

            return panels;
        }

        public SolarPanel[] BuildWithMoreWorkingData()
        {
            SolarPanel[] panels = new[]
            {
                new SolarPanel(3, 2, 8),
                new SolarPanel(6, 10, 20),
                new SolarPanel(9, 5, 15),
            };

            return panels;
        }

        public SolarPanel[] BuildWithLastWorkingData()
        {
            SolarPanel[] panels = new[]
            {
                new SolarPanel(5, 2, 8),
                new SolarPanel(2, 10, 12),
                new SolarPanel(7, 5, 20),
            };

            return panels;
        }

        public SolarPanel[] BuildWithNoData()
        {
            SolarPanel[] panels = new SolarPanel[0];

            return panels;
        }

        public SolarPanel[] BuildWithLotsOfData()
        {
            SolarPanel[] panels = new[]
            {
                new SolarPanel(2, 9, 12),
                new SolarPanel(3, 8, 14),
                new SolarPanel(4, 7, 16),
                new SolarPanel(5, 6, 17),
                new SolarPanel(6, 5, 20),
                new SolarPanel(7, 5, 25),
                new SolarPanel(8, 4, 19),
                new SolarPanel(9, 4, 21)
            };

            return panels;
        }
    }
}
