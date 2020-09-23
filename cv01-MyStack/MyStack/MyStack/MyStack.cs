using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyStack
{

    public delegate void StackEventHandler();
    public class MyStack<T> : IEnumerable<T>
    {
        private T[] data;
        private int currentIndex = 0;
        public T top {
            get {
                if (currentIndex == 0) {
                    throw new EmptyStackException("Stack is empty!");
                }
                else
                    return data[currentIndex - 1];
            }
        }

        public event StackEventHandler OnPush;
        public event StackEventHandler OnPop;


        public MyStack(int dataSize){
            data = new T[dataSize];
            OnPush += () => Console.WriteLine("Value added.");
            OnPop += () => Console.WriteLine("Value removed.");
        }

        public void Push(T value)
        {
            data[currentIndex] = value;
            currentIndex++;
            OnPush?.Invoke();
        }

        public T Pop() 
        { 
        
            OnPop?.Invoke();
            currentIndex--;
            return data[currentIndex];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < currentIndex; i++)
            {
                yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return data[i];
            }
        }
    }
}
