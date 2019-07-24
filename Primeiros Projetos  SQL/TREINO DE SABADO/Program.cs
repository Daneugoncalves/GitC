using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino_de_sabado
{
    class Program
    {
        static void Main(string[] args)

        {
            // Tutorial interativo de C# Olá, Mundo – introdução ao C#

            #region Variáveis / lenghth 
            /*
            Console.WriteLine("Olá mundo"); //Escreve no console.

            string MyFriend = "Taff"; // Declarando uma váriavel e atribuindo-a um valor.

            Console.WriteLine("Olá "+MyFriend); // Chamando a variavel na tela. Atribuindo uma mensagem antes da variavel.
            Console.WriteLine($"Olá{MyFriend}"); // chamando a variavel no meio da frase da forma "correta".

            string PrimeiroNome = "Daniel";                      //declarando as váriaveis do nome e atribuido valores
            string SegundoNome = "Gonçalves";                    //declarando as váriaveis do nome e atribuido valores
            string nomeCompleto = PrimeiroNome + SegundoNome;    //declarando as váriaveis do nome e atribuido valores

            //imprimindo uma mensagem utilizando das minhas variaveis. (concatenar cadeias de caracteres)
            Console.WriteLine($"Meu primeiro nome é {PrimeiroNome} e meu segundo nome é {SegundoNome} enta meu nome completo seria {nomeCompleto}");

            Console.WriteLine($"O nome {PrimeiroNome} tem {PrimeiroNome.Length} letras "); // Length é uma propriedade de uma cadeia de caracteres e retorna o número de caracteres na cadeia.
            Console.WriteLine($"O sobrenome {SegundoNome} tem {SegundoNome.Length} letras");

            // (Métodos) == Um método é um bloco de código que implementa alguma ação. Ele tem um nome, portanto você pode acessá-lo.
            */
            #endregion

            #region USANDO O TrimStart e TrimEnd (corta espaços)

            // métodos para remover espaços à esquerda e à direita

            /*
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");
           
            string trimmedGreeting = greeting.TrimStart(); // esquerda
            Console.WriteLine($"[{trimmedGreeting}]");
           
            trimmedGreeting = greeting.TrimEnd();    //direita
            Console.WriteLine($"[{trimmedGreeting}]");
           
            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]"); // corta todos espacos
            */


            #endregion

            #region .REPLACE (SUBSTITUIÇÃO DE CARACTERES) // ToUpper ToLower
            // string digaOI = "Hello Word";
            // 
            // Console.WriteLine(digaOI);
            // 
            // digaOI = digaOI.Replace("Hello", "3"); //A primeira cadeia de caracteres é o texto a ser pesquisado.
            //                                        //A segunda cadeia de caracteres é o texto para substituição.
            // 
            // Console.WriteLine(digaOI); // aki resulta em 3 word pois o Hello fui substituido com o replace.
            //
            // Console.WriteLine(digaOI.ToUpper()); // TUDO EM MAIUSCULO
            // Console.WriteLine(digaOI.ToLower()); // TUDO MINUSCULO



            #endregion

            #region MÉTODO CONTAINS / StartsWith / EndsWith -  PARA PESQUISA 
            // string Musica = "You say goodbye, and I say hello";

            // Console.WriteLine(Musica.StartsWith("You"));    // TRUE POIS COMEÇA COM You
            // Console.WriteLine(Musica.Contains("say"));      // TRUE POIS ENCONTRA
            // Console.WriteLine(Musica.Contains("papapapa")); // false POIS NAO ENCONTRA
            // Console.WriteLine(Musica.EndsWith("hello"));    // RETORNA TRUE POIS TERMINA COM hello

            // O método Contains retorna um valor booliano que indica se a
            // cadeia de caracteres que você estava procurando foi encontrada.
            // Um booliano armazena um valor true ou false

            #endregion

            //Manipular números de ponto flutuante e integrais em C#



            // - para subtração
            // *para multiplicação
            // / para divisão


            int a = 10;                 //DECALRA VARIAVEIS E DA VALOR A ELAS
            int b = 15;                 //DECALRA VARIAVEIS E DA VALOR A ELAS
            int c = a + b;              //DECALRA VARIAVEIS E DA VALOR A ELAS EXEMPLO DE SOMA DE VARIAVEIS

            Console.WriteLine(c);      // LENDO VARIAVEL C  (A+B = 25)


            Console.ReadKey(); // espera uma tecla para continuar...

        }
    }
}
