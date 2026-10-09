using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    public class Die //This Is The One We Made As A Class.
    {

        private int _sides;
        private int _roll;
        string roll1, roll2;
        
        private Random _generator;
        
        private ConsoleColor _color;

        public Die() 
        {
            _generator = new Random();
            _sides = 6;
            _roll = _generator.Next(1, _sides + 1); //Could also put 7 instead of _sides + 1.

        }

        

        //public Die(int sides) 
        //{
        //    _generator = new Random();  //Lets user put as many sides as they want.
        //    _sides = sides;
        //    _roll = _generator.Next(1, _sides + 1);
        //}

        //Accessor Properties:

        public int Roll
        {
            get { return _roll; }
            //set { _roll = value; } // <-- Allows user to change the value of _roll.
        }

        public ConsoleColor Color 
        {
            get { return _color; }
            set { _color = value; }
        }

        



        public override string ToString() 
        {
            return "You Have Rolled A: " + _roll.ToString();
            
        }



        public void RollDie() 
        {
            _roll = _generator.Next(1, _sides + 1);
        }

       

        public void DrawRoll() 
        {
            ConsoleColor currentForecolor = Console.ForegroundColor;
            Console.ForegroundColor = _color;

            Console.WriteLine("-----");
            if (Roll == 1) 
            {
                Console.WriteLine("|   |");
                Console.WriteLine("| o |");
                Console.WriteLine("|   |");
            }
            else if (Roll == 2)
            {
                Console.WriteLine("|o  |");
                Console.WriteLine("|   |");
                Console.WriteLine("|  o|");
            }
            else if (Roll == 3)
            {
                Console.WriteLine("|o  |");
                Console.WriteLine("| o |");
                Console.WriteLine("|  o|");
            }
            else if (Roll == 4)
            {
                Console.WriteLine("|o o|");
                Console.WriteLine("|   |");
                Console.WriteLine("|o o|");
            }
            else if (Roll == 5)
            {
                Console.WriteLine("|o o|");
                Console.WriteLine("| o |");
                Console.WriteLine("|o o|");
            }
            else if (Roll == 6)
            {
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");


            }
            Console.WriteLine("-----");

            Console.ForegroundColor = currentForecolor;

            //Console.ResetColor();



        }







    }
}
