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
            Thread.Sleep(600);

            //Começar a contagem do segundo cronómetro
            cron2.Start();

            //Pausar o cronómetro 2
            Thread.Sleep(200);

            //Parar a contagem dos cronómetros
            cron1.Stop();
            cron2.Stop();

            //Obtém o tempo total decorrido, medido pelas instâncias, 
            //em milissegundos.
            long mill1 = cron1.ElapsedMilliseconds;
            long mill2 = cron2.ElapsedMilliseconds;

            //Passar os milissegundos para segundos
            double seg1 = mill1 / 1000.0;
            double seg2 = mill2 / 1000.0;

            //Mostra no ecrã o tempo decorrido em cada cronómetro, 
            //em segundos, com três casas decimais
            Console.WriteLine($"Cronómetro 1:{seg1:f3}|Cronómetro 2:{seg2:f3}");

        }
    }
}
