using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            //program küsib kasutajal sisestada PIN-koodi;
            //programm võrdlem sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //Kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
            //katsete arv on piiramatu.

            bool loopActive = true; //boolean --> true/false
            int i = 0;

            while (loopActive) 
            {
                Console.WriteLine()"Sisesta PIN:"); //cw+double TAB
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
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

            Console.WreiteLine("Kena Päeva");

        }
    }
}
