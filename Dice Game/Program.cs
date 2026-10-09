using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Program //Maxym F
    {
        static void Main(string[] args)
        {

            double balance, bet;

            balance = 100; //start of with $100

            Console.WriteLine("How much would you like to bet?");
            Double.TryParse(Console.ReadLine(), out bet);

            Console.WriteLine($"Ok, you bet {bet}... Let's see if Luck's on your side!");


        }
    }
}
