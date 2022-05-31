using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //proramm genereerib juhusliku nr 1-10;
            //kasutaja peab numbri ära arvama;
            //kui kasutaja suutis nr ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu;
            //programm genereerib juhuslikku nr vaid üks kord.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            while (true)
            {
                Console.WriteLine("Arva ära number 1 kuni 10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Õige! Palju õnne!");
                    break;
                }
                else
                {
                    Console.WriteLine("Arva uuesti!");
                }
            }
        }
    }
}
