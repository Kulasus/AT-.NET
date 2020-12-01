using System;
using System.Collections.Generic;
using System.Text;

namespace Validators
{
    public class MyIcValidator
    {
        public bool Validate(string txt)
        {
            if (txt.Length != 8)
            {
                throw new InvalidDataException();
            }
            int result = SumNumbers(txt);
            int tmp = result % 11;
            return CheckC(int.Parse(txt[7].ToString()), tmp);
        }
        private bool CheckC(int c, int tmp)
        {
            if(tmp == 0)
            {
                return c == 1;
            }
            if(tmp == 1)
            {
                return c == 0;
            }
            return c == (11 - tmp);
        }
        private int SumNumbers(string txt)
        {
            if(txt.Length < 7)
            {
                throw new InvalidDataException();
            }
            int res = 0;
            for (int i = 0; i < 7; i++)
            {
                if (!int.TryParse(txt[i].ToString(), out int num)) {
                    throw new InvalidDataException();
                }
                int mult = 8 - i;

                res += num * mult;
            }
            return res;
        }
    }

}
