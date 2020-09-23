using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack
{
    class EmptyStackException : Exception
    {
        public EmptyStackException()
        {
        }

        public EmptyStackException(string message) : base(message)
        {
        }

        public EmptyStackException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
