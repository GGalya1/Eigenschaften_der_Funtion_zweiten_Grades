using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAufgabe1
{
    class QuadratischeFunktion
    {
        //Variablen
        private string Null;

        //Eigenschaften
        private double Argum1 { get; set; }
        private double Argum2 { get; set; }
        private double Argum3 { get; set; }

        //Konstriktor
        public QuadratischeFunktion(double _argum1, double _argum2, double _argum3)
        {
            Argum1 = _argum1;
            Argum2 = _argum2;
            Argum3 = _argum3;
        }

        //Methode
        public string NullstellenBerechen()
        {
            try
            {
                double F = Math.Sqrt(Math.Pow(Argum2,2) - 4 * Argum1 * Argum3);
            }
            catch
            {
                return "Sie haben die Werte falsch eingegeben";
            }

            double D = Math.Sqrt(Math.Pow(Argum2, 2) - 4 * Argum1 * Argum3);

   

            if (D == 0)
            {
                try
                {
                    double X1 = (-Argum2 + D) / (2 * Argum1);
                    double X2 = (-Argum2 - D) / (2 * Argum1);
                    Null += "Die Nullstellen für die X-Achse liegen bei " + X1 + " und " + X2;
                }
                catch
                {
                    Null += "Es gibt keine Schnittpunkte beim X-Achse";
                }
            }
            else
            {
                try
                {
                    double X1 = (-Argum2 + D) / (2 * Argum1);
                    Null += "Die Nullstelle für die X-Achse liegt bei " + X1;
                }
                catch
                {
                    Null += "Es gibt keine Schnittpunkte beim X-Achse";
                }
            }

            Null += "Die Nullstelle für die Y-Achse liegt bei " + Argum3;
            return Null;
        }

        public string GibWerte()
        {
            string werte = Convert.ToString(Argum1) + " " + Convert.ToString(Argum2) + " " + Convert.ToString(Argum3);
            return werte;
        }
    }
}
