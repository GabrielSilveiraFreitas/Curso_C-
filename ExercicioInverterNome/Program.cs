﻿using System;

namespace ExercicioInverterNome
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3, nome4, aux;

            Console.Write("Digite o nome #1: ");
            nome1 = Console.ReadLine();

            Console.Write("Digite o nome #2: ");
            nome2 = Console.ReadLine();

            Console.Write("Digite o nome #3: ");
            nome3 = Console.ReadLine();

            Console.Write("Digite o nome #4: ");
            nome4 = Console.ReadLine();

            // Mecanismo de inversão dos nomes
            aux = nome1;
            nome1 = nome4;
            nome4 = aux;
            aux = nome2;
            nome2 = nome3;
            nome3 = aux;

            Console.WriteLine();
            Console.WriteLine("Nomes inseridos na sequência invertida");

            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);

            Console.Read();
        }
    }
}
