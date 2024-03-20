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

            //Começar a contagem do primeiro cronómetro
            cron1.Start();

            //Pausar o cronómetro 1
            cron1.Thread.Sleep(600);

            //Começar a contagem do segundo cronómetro
            cron2.Start();

            //Pausar o cronómetro 2
            cron2.Thread.Sleep(200);

            //Parar a contagem dos cronómetros
            cron1.Stop();
            cron2.Stop();

        }
    }
}
