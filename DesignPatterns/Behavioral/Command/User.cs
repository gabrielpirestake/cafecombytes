using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class User
    {
        private readonly Calculator _calculator = new();
        private readonly List<Commander> _commands = new();
        private int _total;

        public void Add(char mathOperator, int value)
        {
            Commander command = new CalculatorCommand(_calculator, mathOperator, value);
            command.Execute();

            _commands.Add(command);
            _total++;
        }

        public void TurnBack(int niveis)
        {
            Console.WriteLine("\n---- Retornando {0} níveis ", niveis);

            for (var i = 0; i < niveis; i++)
            {
                if (_total >= _commands.Count - 1) continue;
                var command = _commands[_total++];
                command.Execute();
            }
        }

        public void Undo(int niveis)
        {
            Console.WriteLine("\n---- Desfazendo {0} níveis ", niveis);

            for (var i = 0; i < niveis; i++)
            {
                if (_total <= 0) continue;
                var command = _commands[--_total];
                command.Undo();
            }
        }
    }
}
