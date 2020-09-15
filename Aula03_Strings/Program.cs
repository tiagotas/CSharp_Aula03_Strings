using System;
using System.Runtime.CompilerServices;

namespace Aula03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Programa e Textos";

            String nome;

            //Mudar cor do Fundo
            Console.BackgroundColor = ConsoleColor.DarkRed;            
            Console.Beep(); // Toca um Bipe

            // Cor do texto
            Console.ForegroundColor = ConsoleColor.White;

            //Console.WriteLine("Largura da Janela: " + Console.WindowWidth);
            //Console.WriteLine("Altura da Janela: " + Console.WindowHeight);

            Console.SetWindowSize(40, 20); // Define Altura e Largura

            //Console.WriteLine("Largura da Janela: " + Console.WindowWidth);
            //Console.WriteLine("Altura da Janela: " + Console.WindowHeight);          
           
           
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            int qnt_letras = nome.Length;

            //Console.Clear(); // Limpa a tela
            Console.WriteLine("Seu nome tem " + qnt_letras + " letras.");


            // Covertendo para maiúsculas.
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Bem-vindo " + nome.ToUpper());

            // Convertendo para minúsculas.
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Bem-vindo " + nome.ToLower());

            // Cortando uma string
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            string primeiro_nome = nome.Substring(0, 5);
            // 0 1 2 3 4
            // T i a g o
            
            Console.WriteLine("Bem-vindo " + primeiro_nome);






        }
    }
}
