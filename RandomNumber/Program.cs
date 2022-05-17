using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kui genereeritud number on 5; program lõpetab oma tööd ja soovib kasutajale "kena päeva";
            //kui genereeritud number on midagi muud, siis programm jätkab oma tööd.

            Random rnd = new Random();

            int i = 0;

            while (i !=5) 
            {
                while (loopActive)
                {
                    Console.WriteLine()"Sisesta PIN:"); //cw+double TAB
                    int userPIN = Convert.ToInt32(Console.ReadLine());

                    if (userPIN == 1234)
                    {
                        Console.WriteLine("Tere tulemast!");
                        loopActive = false;

                    }
                    else
                    {
                        i++;
                        Console.WriteLine("Vale PIN. Proovi uuesti!");
                        Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestanud.");

                    }

                }
                Console.WriteLine("Kena päeva!");

            

            
        }
    }
}
