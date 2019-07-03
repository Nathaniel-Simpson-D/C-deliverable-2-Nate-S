using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Deleverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, what are you in the mood for?");
                    Console.WriteLine("Your options are");
                    Console.WriteLine("Action (press 1)");
                    Console.WriteLine("Chill Times (press 2)");
                    Console.WriteLine("Danger (press 3)");
                    Console.WriteLine("Good Foood (press 4)");


                  int i = Convert.ToInt32(Console.ReadLine());

                    if (i == 1 || i == 2 || i == 3 || i == 4) { Console.WriteLine("Awsome!"); }

           
           

            Console.WriteLine("How many other people are you bringing?");
           
           int partySize = Convert.ToInt32(Console.ReadLine());
            

            string act = "a";
            String tranz = "b";

            if
                            (partySize <= 0) { tranz = "sneakers."; }
            else if
                (partySize >= 1 && i <= 4) { tranz = "a sedan."; }
            else if
               (partySize >= 5 && i <= 10) { tranz = "a Volkswagen bus."; }
            else
            { tranz = "an airplane."; }


            if 
                (i == 1) { act = "Stock Car Racing"; }
            else if
                (i == 2) { act = "Hiking"; }
            else if
               (i == 3) { act = "Skydiving"; }
            else 
               { act = "To Taco Bell"; }

            Console.Write("You should go ");
            Console.Write(act);
            Console.Write(" in ");
            Console.WriteLine(tranz);
            Console.WriteLine("Goodbye, have fun.");

        }
    }
}
