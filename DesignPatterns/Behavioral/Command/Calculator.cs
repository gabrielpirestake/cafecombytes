using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    internal class Calculator
    {
        private int _currentValue;

        public void MathOperator(char mathOperator, int value)
        {
            switch (mathOperator)
            {
                case '+': _currentValue += value; break;
                case '-': _currentValue -= value; break;
                case '*': _currentValue *= value; break;
                case '/': _currentValue /= value; break;
            }
            Console.WriteLine("(dado {1} {2}) - Valor atual = {0,3}", _currentValue, mathOperator, value);
        }
    }
}
