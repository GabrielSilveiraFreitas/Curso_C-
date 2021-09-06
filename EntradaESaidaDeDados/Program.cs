using System;

namespace EntradaESaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("gabriel ");
            Console.WriteLine("silveira");
            
            // Vai ler somente o primeiro caracter
            int letra = Console.Read();
            Console.WriteLine(letra);

            // Vai ler a linha toda digitada
            string texto = Console.ReadLine();
            Console.WriteLine(texto);

            Console.Read();     
        }
    }
}
