using System;
using System.Runtime.CompilerServices;

namespace MyGame
{

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]); //Nº de inimigos fornecido
            string[] enemies = new string[n]; //Array com capacidade para o número de inimigos
            int enems = 0; 
            
            for(int i = 0; i < enemies.Length; i++)
            {
                ++enems;//Para ir passando o número do inimigo
                Console.Write($"What is the name of enemy {enems}?: ");
                //Assegura que os nomes do inimigos são postos nas posições certas
                enemies[i] = Console.ReadLine(); 
            }

            for (int a = 0; a < enemies.Length; a++)
            {
                Enemy name = new Enemy(enemies[a]); //Cria um novo inimigo

                name.PickupPowerUp(PowerUp.Health, 45);
                name.PickupPowerUp(PowerUp.Shield, 2);
                name.TakeDamage(69);
                name.GetPickedPU();
                
                //Mostrar o nome, health e shield do inimigo
                Console.WriteLine($"{name.GetName()}: {name.GetHealth()}H & {name.GetShield()}S");
                Console.WriteLine($"{name.GetName()}: {name.GetPickedPU()}P.U");
            }
           
        }
    }
}
