using System;
using System.Collections.Generic;
using System.Text;
using TextGame.State;

namespace TextGame.Command
{
    class SwitchStateCommand : ICommand
    {
        private StateManager manager;
        private IState state;

        public SwitchStateCommand(IState state, StateManager manager)
        {
            this.state = state;
            this.manager = manager;
        }
        public void Execute()
        {
            manager.SwitchState(state);
        }
    }
}
