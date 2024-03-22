using System;
using System.Runtime.CompilerServices;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }
        public float GetHealth() => health; //Devolve o valor de health
        public float GetShield() => shield; //Devolve o valor de shield
        
        public void SetName(string nome)
        {
            if (name != null)
            {
                nome = ""; //String de armazenamento
                
                if (name.Length > 8)
                //Deteta se o nome tem mais do que 8 caracteres e só corre se 
                //tiver mais do que 8 caracteres
                {
                    for (int i = 0; i < 8; i++)
                    //Garante que apenas se lê os primeiros 8 caracteres da string  
                    {
                        nome += name[i]; //Guarda os 8 caracteres em 'nome'
                    }
                    return;
                }
                else
                {
                    GetName();
                }
            }
            else Console.WriteLine("Can't be an empty name!");
            
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
