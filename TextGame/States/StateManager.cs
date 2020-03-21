using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame.State
{
    class StateManager
    {
        private IState state;
        public void SwitchState(IState state)
        {
            this.state = state;
        }

        public void Run(IState initialState)
        {
            state = initialState;

            while (true)
            {
                state.Render();
                var command = state.GetCommand();
                command.Execute();
            }
        }
    }
}
