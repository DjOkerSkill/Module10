using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    internal class MiniCalculator : ISum
    {
        ILogger logger = new Logger();
        
        public int Sum(int number1, int number2)
        {
            logger.Event("Калькулятор начал свою работу");

            return number1 + number2;

        }
    }
}
