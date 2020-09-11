using System;
using System.Globalization;

namespace _Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
			
			try
			{
				Console.Write("Entrada: ");
				double entrada = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
				Dolar dolar = new Dolar(entrada);
				Console.WriteLine(dolar);
			}
			catch (Exception e)
			{
				Console.WriteLine($"Erro: {e}");
			}
        }
    }
}
