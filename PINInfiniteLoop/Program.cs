using System;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada pin koodi;
            //programm võrdleb sisestatud pin koodi arvuga 1234;
            //kui sisestatud pin kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud pin kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti!";
            //katsete arv on piiramatu

            bool loopActive = true; //boolean -> true/false
            int i = 0;

            while(loopActive)
            {
                Console.WriteLine("Sisesta PIN");
                int usenPIN = Convert.ToInt32(Console.ReadLine());

                if(usenPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN. Proovi uuesti.");
                    Console.WriteLine($"Oled vale PIN koodi sisestanud {i} korda.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
