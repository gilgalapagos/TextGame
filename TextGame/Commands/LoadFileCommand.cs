using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame.Command
{
    class LoadFileCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("LOADING!");
        }
    }
}
