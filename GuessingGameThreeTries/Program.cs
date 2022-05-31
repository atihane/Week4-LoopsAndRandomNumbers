using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //proramm genereerib juhusliku nr 1-10;
            //kasutaja peab numbri ära arvama;
            //kui kasutaja suutis nr ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega nr ära arvata, siis mängu võidab arvuti;
            //programm genereerib juhuslikku nr vaid üks kord.

            Random rnd = new Random();
            {
                int i = 0;
                while (i < 3)
                {
                    {
                        int cpuNumber = rnd.Next(1, 11);
                        Console.WriteLine("Arva ära number 1 kuni 10:");

                        int userNumber = Convert.ToInt32(Console.ReadLine());
                        if (userNumber == cpuNumber)
                        {
                            Console.WriteLine("Õige! Palju õnne!");
                            break;
                        }
                        else
                        {
                            i++;
                            Console.WriteLine($"Vale number. Palun proovi uuesti. Alles on veel {3 - i} katset.");
                        }
                    }
                }
                Console.WriteLine("Kena päeva!");
            }
        }
    }
}
