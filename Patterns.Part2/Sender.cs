using CliWrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Part2
{
    public class Sender
    {
        CliWrap.Command _command;

        public void SetCommand(CliWrap.Command command)
        {
            this._command = command;
        }

        public void Execute(string url)
        {
            _command.Execute(url);
        }
    }
}
