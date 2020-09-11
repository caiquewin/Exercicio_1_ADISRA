using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _Exercício_1
{
    class Dolar
    {
        private Double ValorDolar{ get { return 5.36; } }
        public Double Quantidade { get; set; }

        public Dolar(double quantidade)
        {
           Quantidade = quantidade;
        }

        public double TotalSaida()
        {
            return ValorDolar * Quantidade;
        }
        public override string ToString()
        {
            return "Saida: "+TotalSaida().ToString("f2"); 
        }
    }
}
