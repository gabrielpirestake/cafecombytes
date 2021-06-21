using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    internal abstract class Commander
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}
