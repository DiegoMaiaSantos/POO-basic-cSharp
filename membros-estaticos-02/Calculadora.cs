using System;
using System.Globalization;

namespace Course
{
    class Calculadora
    {
        public double Pi = 3.14;

        public double Circunferencia(double ra)
        {
            return 2.0 * Pi * ra;
        }

        public double Volume(double ra)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(ra, 3.0);
        }

    }
}