using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                int n = int.Parse(args[0]); //Número de dados
                int s = int.Parse(args[1]); //Seed

                Random dados = new Random(s); //Seed s definida
                
                for (int i = 0; i < n; i++) //"Roda" todos os dados
                {
                    //Escolhe um número entre 1 e 6 para cada dado
                    int nums = dados.Next(1,7);
                    
                }
                    
            }
            else
            {
                Console.WriteLine("This program takes 2 arguments!");
            }
            
            
        }
    }
}
