using AcousticCalculator.Entities;
using System;

namespace AcousticCalculator
{
    public class Calculator
    {
        // to-do: refactor to interface or abstract class and implement VentAir calculation variant 
        public CalculatedWindow Window { get; set; }
        public Napowiet VentAir { get; set; }
        public PakSzyb Glass { get; set; }

        public Result Calculate()
        {
            var result = new Result();
            int ventAirCorrection = VentAir is null ? 0 : (int)VentAir.DnEW;
            result.Correction = CalculateCorrection(Window) - ventAirCorrection;
            result.Rw = CalculateRw(Glass) - ventAirCorrection;
            result.Ra2 = CalculateRa2(Glass) - ventAirCorrection;
            if (result.Rw == 0)
            {
                result.Info = "Parametry wybranego pakietu (Rw = " + Glass.DzwRwigu.ToString()+ ") nie pozwalają na korzystanie z normy.";
            }
            else
            {
                result.Info = "";
            }
            return result;
        }
        private int CalculateRw(PakSzyb Glass)
        {
            if (Glass == null) throw new Exception("Nie wybrano pakietu!");
            var rw = Glass.DzwRwigu;
            if (rw == 27) return 30;
            if (rw == 28) return 31;
            if (rw == 29) return 32;
            if (rw <= 31) return 33;
            if (rw <= 33) return 34;
            if (rw <= 35) return 35;
            if (rw <= 37) return 36;
            if (rw <= 39) return 37;
            if (rw == 40) return 38;
            else return 0;
        }
        private int CalculateRa2(PakSzyb Glass) 
        {
            if (Glass == null) throw new Exception("Nie wybrano pakietu!");
            var ra2 = Glass.DzwRwigu + Glass.DzwCtr;
            if (ra2 == 24) return 26;
            if (ra2 == 25) return 27;
            if (ra2 == 26) return 28;
            if (ra2 == 27) return 29;
            if (ra2 <= 29) return 30;
            if (ra2 <= 31) return 31;
            if (ra2 <= 33) return 32;
            if (ra2 <= 35) return 33;
            if (ra2 == 46) return 34;
            else return 0;
        }
        private int CalculateCorrection(CalculatedWindow window)
        {
            if (window == null) throw new Exception("Brak wymiarów okna!");
            if (window.Area <= 2.7) return 0;
            if (window.Area <= 3.6) return -1;
            if (window.Area <= 4.6) return -2;
            else return -3;

        }
    }
}
