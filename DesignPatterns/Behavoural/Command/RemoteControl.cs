using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavoural.Command
{
    public class RemoteControl
    {
        List<ICommand> commands;

        public RemoteControl()
        {
            commands = new List<ICommand>();
        }

        public void SetCommand(ICommand command)
        {
            commands.Add(command);
        }

        public void PressButton()
        {
            foreach (ICommand command in commands)
                command.Execute();
        }
    }
}
