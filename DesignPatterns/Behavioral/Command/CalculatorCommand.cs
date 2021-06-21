using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    internal class CalculatorCommand : Commander
    {
        private char _operator;
        private int _value;
        private readonly Calculator _calculator;

        public CalculatorCommand(Calculator calculator, char mathOperator, int value)
        {
            _calculator = calculator;
            _operator = mathOperator;
            _value = value;
        }

        public override void Execute()
        {
            _calculator.MathOperator(_operator, _value);
        }

        public override void Undo()
        {
            _calculator.MathOperator(Undo(_operator), _value);
        }

        private static char Undo(char mathOperator)
        {
            return mathOperator switch
            {
                '+' => '-',
                '-' => '+',
                '*' => '/',
                '/' => '*',
                _ => throw new ArgumentException("Operador desconhecido"),
            };
        }
    }
}
