using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using TextGame.Command;

namespace TextGame.State
{
    class LoadFileState : IState
    {
        private IState lastState;
        private StateManager manager;

        public LoadFileState(IState state, StateManager manager)
        {
            lastState = state;
            this.manager = manager;
        }

        public void Render()
        {
            var directoryInfo = new DirectoryInfo("Saves");
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                Console.WriteLine(file.Name);
            }
            Console.WriteLine();
            Console.WriteLine("[back]");
        }

        public ICommand GetCommand()
        {
            var input = Console.ReadLine();
            if (File.Exists($"Saves/{input}"))
            {
                Console.WriteLine($"Loading {input}.");
                Console.ReadKey(false);
                return new LoadFileCommand();
            }

            if (input == "back")
            {
                return new SwitchStateCommand(lastState, manager);
            }
            return new LoadFileCommand();
        }
    }
}
