using System;

namespace MyGame
{

    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        static private int TotalPU; //Variável que conta quantos powerups todos
                                    //os inimigos apanharam durante o jogo
        static Enemy() //Inicializa a variável a 0
        {
            TotalPU = 0;
        }

        public Enemy(string name)
        {
            SetName(name); //Programa usa este método para determinar o nome
            health = 100;
            shield = 70;
        }

        public void PickupPowerUp(PowerUp powerUp, float vl)
        //Método que aceita um dos elementos da enumeração PowerUp e um float
        {
            if (vl <= 100) //Garante que o valor dado não ultrapassa 100
            {
                if (powerUp == PowerUp.Health)
                {
                    health += vl; //Aumenta health o valor dado (vl)
                }
                else if (powerUp == PowerUp.Shield)
                {
                    shield += vl; //Aumenta shield o valor dado (vl)
                }
                TotalPU += 1; //Incrementa o valor da var cada vez que é invocado
            }
            else
            {
                Console.WriteLine("Value can't be more than 100!");
            }
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
        public float GetPickedPU() => TotalPU; //Devolve quantos powerups o inimigo tem 
        public void SetName(string new_nome)
        {
            if (new_nome != null) //Confirma que a string é válida
            {
                name = ""; //String de armazenamento

                if (new_nome.Length > 8)
                //Deteta se o nome tem mais do que 8 caracteres e só corre se 
                //tiver mais do que 8 caracteres
                {
                    for (int i = 0; i < 8; i++)
                    //Garante que apenas se lê os primeiros 8 caracteres da string  
                    {
                        name += new_nome[i]; //Guarda os 8 caracteres em 'name'
                    }
                    return;
                }
                else
                {
                    name = new_nome;
                }
                return;
            }
            else Console.WriteLine("Can't be an empty name!");


        }
    }
}