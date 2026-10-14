using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Program //Maxym F
    {
        static void Main(string[] args)
        {

            int betChoice;
            double balance, bet;
            bool done;

            done = false;

            balance = 100; //start of with $100

            Die die1 = new Die();
            Thread.Sleep(100);     
            Die die2 = new Die();

            die1.Color = ConsoleColor.Cyan;
            die2.Color = ConsoleColor.Blue;

            while (!done) 
            {
                
                Console.WriteLine("What Will You Be Betting On? (Input the number)");
                Console.WriteLine("1 - Doubles");
                Console.WriteLine("2 - Not Doubles");
                Console.WriteLine("3 - Even Sum");
                Console.WriteLine("4 - Odd Sum");
                Int32.TryParse(Console.ReadLine(), out betChoice);

                if (betChoice == 1)
                {

                    Console.Clear();
                    Console.WriteLine("Okay! You want doubles, huh?");
                    Console.WriteLine("How much would you like to bet?");
                    Double.TryParse(Console.ReadLine(), out bet);

                    if (bet <= balance)
                    {
                        Console.WriteLine($"Ok, you bet ${bet}... Let's see if Luck's on your side!");

                        

                        die1.RollDie();
                        die2.RollDie();

                        die1.DrawRoll();
                        die2.DrawRoll();

                        if (die1.Roll == die2.Roll)
                        {
                            Console.WriteLine("Nice! You got doubles!");
                            balance = balance + (bet * 2);
                            Console.WriteLine($"You Now Have ${balance}!");

                            Console.WriteLine("Press any key To Return");
                            Console.ReadKey();
                            done = false;
                        }
                        
                        else if (die1.Roll != die2.Roll)
                        {
                            Console.WriteLine("Damn-You didnt get doubles. But hey, keep playin, and you'll win eventually!");
                            balance = balance - bet;
                            Console.WriteLine($"You have ${balance}.");

                            Console.WriteLine("Press any key To Return");
                            Console.ReadKey();
                            done = false;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid Bet. You cannot bet more than your balance.");
                    }

                }

                else if (betChoice == 2)
                {

                }

                else if (betChoice == 3)
                {

                }

                else if (betChoice == 4)
                {
                     
                }

                else 
                {
                    done = false;
                }


            }

            
            


        }
    }
}
