using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.Command.SetTopBox.SetTopCommands
{
    class SetTopBoxOffCommand : ICommand
    {
        SetTopBox _setTopBox;

        public SetTopBoxOffCommand(SetTopBox setTopBox)
        {
            _setTopBox = setTopBox;
        }
        public void Execute()
        {
            _setTopBox.Off();
        }
    }
}
