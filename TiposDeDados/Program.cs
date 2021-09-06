using System;

namespace TiposDeDados
{
    class Program
    {
        enum Notas
        {
            Minimo = 10,
            Media = 20,
            Maxima = 30
        }

        struct Pessoa
        {
            public string nome;
            public int idade; 
            public double altura;
        }
        static void Main(string[] args)
        {
            #region TipoCaracter
            char letra = 'a';
            Console.WriteLine(letra);
            Console.Read();
            #endregion

            #region TipoBoleano
            bool verificar = false;
            verificar = true;
            Console.WriteLine(verificar);
            Console.Read();
            #endregion

            #region TipoString
            string text = "Tipo String @?$123";
            string mensagem = null;
            mensagem = text;

            Console.WriteLine(mensagem);
            Console.Read();
            #endregion

            #region TipoVar
            var valor = 100;
            Console.WriteLine(valor);
            Console.Read();
            #endregion

            #region TipoObjetic
            object obj = 100;
            Console.WriteLine();
            Console.Read();
            #endregion

            #region  TipoConstant
            const double pi = 3.14;
            Console.WriteLine(pi);
            Console.Read();
            #endregion

            #region TipoEnumeração
            Notas notasAlunos = Notas.Media;
            Console.WriteLine(notasAlunos);
            Console.Read();
            #endregion

            #region TipoStruct
            Pessoa p1 = new Pessoa();
            p1.altura = 1.65;
            p1.idade = 35;
            p1.nome = "Gabriel";


            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.altura);
            Console.Read();
            #endregion

        }
    }
}
