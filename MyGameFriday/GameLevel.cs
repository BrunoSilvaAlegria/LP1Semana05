using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameFriday
{
    public class GameLevel
    {
        //Inicilizar as variáveis
        private Difficulty lv;
        private int RoomsNum = 0;
        private int EnemNum = 0;
        private string[] rms;
        public GameLevel(int RoomsNum, Difficulty lv)
        {
            this.RoomsNum = RoomsNum; //Substitui o nº de salas pelo escolhido
            this.lv = lv; //Substitui a dificuldade original pelo escolhido
            rms = new string[RoomsNum];
        }
        public Difficulty GetDifficulty() => lv; //Devolve a dificuldade
        public int GetNumRooms() => RoomsNum; //Devolve o número de salas
        public int GetNumEnemies() => EnemNum; //Devolve o número de inimigos
        public void SetEnemyInRoom(int room, Enemy enemy) 
        {
            //Coloca um inimigo específico na sala escolhida 
            rooms[room] = enemy.GetName();
            EnemNum++;
        }
    }
}
