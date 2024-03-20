using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar e instanciar os dois cronómetros nesta classe
            Stopwatch cron1 = new Stopwatch();
            Stopwatch cron2 = new Stopwatch();

            //Começar a contagem dos primeiro cronómetro
            cron1.Start();

            //Pausar o mesmo cronómetro
            cron1.Thread.Sleep(600);

        }
    }
}
