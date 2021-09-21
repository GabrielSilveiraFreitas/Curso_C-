using System;

namespace MetodoParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string txtNumero = "1985";

            int numero = int.Parse(txtNumero);
            byte num1 = byte.Parse("120");
            double num2 = double.Parse("125623,57");
            float num3 = float.Parse("457,75");

            Console.WriteLine(num3);
            
        }
    }
}
