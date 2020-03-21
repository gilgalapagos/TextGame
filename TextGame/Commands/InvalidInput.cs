using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame.Command
{
    class InvalidInput : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Invalid input");
            Console.ReadKey();
        }
    }
}
