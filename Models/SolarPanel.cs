using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOutputCalculator.Models
{
    internal class SolarPanel
    {
        public SolarPanel(int length, int width, int outputPerUnitArea)
        {
            Length = length;
            Width = width;
            OutputPerUnitArea = outputPerUnitArea;
        }

        public int Length { get; set; }
        public int Width { get; set; }
        public int PanelArea 
        { 
            get
            {
                return Length * Width;
            }
        }
        public int OutputPerUnitArea { get; set; }
        public int TotalUnitOutput 
        { 
            get
            {
                return OutputPerUnitArea * PanelArea;
            }
        }

        public decimal UnitOutputToAreaRatio
        {
            get
            {
                if (PanelArea == 0) return 0;

                return OutputPerUnitArea / PanelArea;
            }
        }
    }
}
