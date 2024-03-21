using System;

namespace RanDice
{
    class Program
    {   
        /// <summary>
        /// O utilizador escolhe o número de dados (n) e a seed (s) que deseja.
        /// Depois, é escolhido um valor entre 1 e 6 para a rodagem de cada dado
        /// e soma-se todos os valores que saírem, que é apresentado no ecrã.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                int n = int.Parse(args[0]); //Número de dados
                int s = int.Parse(args[1]); //Seed

                int soma = 0; //Inicializar a variável da soma dos números

                Random dados = new Random(s); //Seed s definida

                for (int i = 0; i < n; i++) //"Roda" todos os dados
                {
                    //Escolhe um número entre 1 e 6 para cada dado
                    int nums = dados.Next(1,7);
                    soma += nums; //Soma dos valores escolhidos
                    
                }  
                Console.WriteLine($"A soma dos valores que calharam é: {soma}");     
            }
            else
            {
                Console.WriteLine("This program takes 2 arguments!");
            } 
        }
    }
}
