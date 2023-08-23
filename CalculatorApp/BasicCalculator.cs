using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class BasicCalculator
    {
        private int a;
        private int b;

        public BasicCalculator(int A, int B) 
        {
            this.a = A;
            this.b = B;
        }

        public int Addition()
        {
            return a + b;
        }
        public int Subtraction() 
        {
            return a - b;
        }
        public int Multiplication() 
        {
            return a * b;
        }
        public double Division()
        {
            if (b != 0)
                return Convert.ToDouble(a) / b;
            else
                return 0;
        }


    }
}
