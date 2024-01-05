using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Leia u valor");
            double valor = double.Parse(Console.ReadLine(), CI);

            string intervalo = "0";
            if (valor > 0 && valor <= 25.00) {
                intervalo = "[0,25]";
            }
            else if (valor > 25.00 && valor <= 50.00) {
                intervalo = "(25,50]";
            }
            else if (valor > 50.00 && valor <= 75.00) {
                intervalo = "(50,75]";
            }
            else if (valor > 75.00 && valor <= 100.00) {
                intervalo = "(75,100]";
            }
            else {
                intervalo = "Fora do intervalo";
            }

            Console.WriteLine("Intervalo " + intervalo);
        }
    }
}