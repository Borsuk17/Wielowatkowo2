using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace watkiZad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sredniaArytmetyczna = new int();
            double sredniaGeometryczna = new double();

            Task t1 = Task.Run(() =>
            {
                Console.WriteLine("Start watku T1");
                int liczbarandomowa = new int();
                int sumowanie = new int();

                for (int i = 0; i < 100; i++)
                {
                    Random rand = new Random();
                    liczbarandomowa = rand.Next(100);
                    sumowanie = sumowanie + liczbarandomowa;
                };

                sredniaArytmetyczna = sumowanie / 100;
                Console.WriteLine("Wynik  wątek T1 " + sredniaArytmetyczna +"  Średnia Arytmetyczna");
                Console.WriteLine("Koniec watku T1");

            });

            Task t2 = Task.Run(() =>
            {
                Console.WriteLine("Start watku T2");
                int liczbarandomowa = new int();
                long mnożenie = 1;
                Console.WriteLine("INFO  wątek T2 Liczba " + mnożenie);

                for (int i = 0; i < 10; i++)
                {
                    Random rand = new Random();
                    liczbarandomowa = rand.Next(10);
                    mnożenie = mnożenie * liczbarandomowa;
                    //Console.WriteLine(" wątek 2 Liczba " + mnożenie);
                }
                double pow = 0.1;
                sredniaGeometryczna = Convert.ToInt64(Math.Pow(Convert.ToDouble(mnożenie), pow));
                Console.WriteLine("Wynik  wątek T2 " + sredniaGeometryczna + "  Średnia Geometryczna");
                Console.WriteLine("Koniec watku T2");
            });


            //double a = Math.Pow(2, 7);
            //Console.WriteLine(a);


            Console.WriteLine(" koniec głównego");
            Console.ReadKey();




        }
    }
}
