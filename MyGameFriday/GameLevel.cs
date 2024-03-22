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
        private string[] rms;
        public GameLevel(int RoomsNum, Difficulty lv)
        {
            this.RoomsNum = RoomsNum; //Substitui o nº original do room pelo escolhido
            this.lv = lv; //Substitui a dificuldade original pelo escolhido
            rms = new string[RoomsNum];
        }
    }
}
