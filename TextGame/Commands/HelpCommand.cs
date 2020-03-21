using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame.Command
{
    class HelpCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Idk what to put here");
            Console.ReadKey();
        }
    }
}
