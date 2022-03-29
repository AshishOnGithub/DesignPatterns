using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.Command.SetTopBox.SetTopCommands
{
    class SetTopBoxOnCommand : ICommand
    {
        SetTopBox _setTopBox;

        public SetTopBoxOnCommand(SetTopBox setTopBox)
        {
            _setTopBox = setTopBox;
        }

        public void Execute()
        {
            _setTopBox.On();
        }
    }
}
