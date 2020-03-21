using System.IO;
using System.Collections.Generic;
using System;

namespace TextGame
{                             
    class Program
    {
        static void Main(string[] args)
        {
            var start = new StateManager();
            start.Run(new MainMenuState(start));
        }   

        public static int GetInput()
        {
            int input = 0;
            bool validInput = false;
            Console.WriteLine();
            Console.Write("> ");
            while (!validInput)
            {
                validInput = int.TryParse(Console.ReadLine(), out input);
            }
            return input;
        }
    }

    
}
