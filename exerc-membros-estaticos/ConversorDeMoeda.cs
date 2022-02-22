using System;
using System.Globalization;

namespace Course
{
    class ConversoDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double quantidade, double cotacao) 
        {
            double total = quantidade * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}