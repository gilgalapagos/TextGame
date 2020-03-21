using System;
using System.Collections.Generic;
using System.Text;
using TextGame.Command;

namespace TextGame.State
{
    class MainMenuState : IState
    {
        private StateManager manager;

        public MainMenuState(StateManager manager)
        {
            this.manager = manager;
        }

        public void Render()
        {
            Console.WriteLine("[1] New Game\n[2] Load File\n[3] Save File\n[4] Help");
        }

        public ICommand GetCommand()
        {
            var input = Program.GetInput();
            if (input == 1)
            {
                return new NewGameCommand();
            }

            if (input == 2)
            {
                return new SwitchStateCommand(new LoadFileState(this, manager), manager);
            }

            if (input == 3)
            {
                return new SwitchStateCommand(new SaveFileState(this, manager), manager);
            }

            if (input == 4)
            {
                return new HelpCommand();
            }

            return new InvalidInput();
        }
    }
}
