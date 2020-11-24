using System;
using Validators;

namespace IcValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            MyIcValidator validator = new MyIcValidator();
            string txt = Console.ReadLine();
            if (validator.Validate(txt))
            {
                Console.WriteLine("Validní IČ");
            }
            else
            {
                Console.WriteLine("Nevalidní IČ");
            }
        }
    }
}
