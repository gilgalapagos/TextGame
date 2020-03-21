using System;
using System.Collections.Generic;
using System.Text;
using TextGame.Command;

namespace TextGame.State
{
    interface IState
    {
        void Render();
        ICommand GetCommand();
    }
}
