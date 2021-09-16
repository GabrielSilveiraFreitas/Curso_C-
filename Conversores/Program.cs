using System;

namespace Conversores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Conversao Implicita
            
                byte num1 = 100; // 8 bits, de 0 a 255
                ushort num2; // 16 bits, de 0 a 65.535

                float num3 = 1250.45f;
                double num4 = num3;

                num3 = num1;
                num2 = num1;

                int numero = 'C'; // C -> Converte o caracter para o seu código numerico

                Console.WriteLine(numero);
                Console.ReadKey();
            
            #endregion 

            #region Conversao Explicita

                ushort num1 = 500;
                byte num2 = (byte)num1;

                float num3 = 2500.786f; // Vai receber só o valor inteiro
                int num4 = (int)num3;

                char letra = (char)97; // Vai printar a letra referente ao codigo numerico 97
                 
                Console.WriteLine(letra);
                Console.ReadKey();

            #endregion






        }
    }
}
