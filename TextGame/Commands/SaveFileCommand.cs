using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TextGame.Command
{
    class SaveFileCommand : ICommand
    {
        private string input;
        public SaveFileCommand(string input)
        {
            this.input = input;
        }

        public void Execute()
        {
            if (!Directory.Exists("Saves"))
            {
                Directory.CreateDirectory("Saves");
            }
            File.Create($"Saves/{input}");
        }
    }
}
