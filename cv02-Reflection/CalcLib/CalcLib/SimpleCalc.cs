using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CalcLib
{
    class SimpleCalc
    {
        private int x;
        private int y;
        private int result;

        public void SetXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Add()
        {
            this.result = this.x + this.y;
        }

        private void Multiply()
        {
            this.result = this.x * this.y;
        }

        public void ShowResult()
        {
            Console.WriteLine(this.result);
        }
    }
}
