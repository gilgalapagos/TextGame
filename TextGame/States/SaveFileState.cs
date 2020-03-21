using System;
using System.Collections.Generic;
using System.Text;
using TextGame.Command;

namespace TextGame.State
{
    class SaveFileState : IState
    {
        private IState state;
        private StateManager manager;


        public SaveFileState(IState state, StateManager manager)
        {
            this.state = state;
            this.manager = manager;
        }

        public void Render()
        {
            Console.WriteLine("Choose file name");
            Console.WriteLine("[back]");
        }

        public ICommand GetCommand()
        {
            var input = Console.ReadLine();

            if (input == "back")
            {
                return new SwitchStateCommand(state, manager);
            }

            return new SaveFileCommand(input);
        }
    }
}
