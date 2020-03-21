using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame.Command
{
    class NewGameCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("THIS IS A GAME");
        }
    }
}
