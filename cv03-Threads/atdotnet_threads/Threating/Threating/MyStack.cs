using System;
using System.Collections.Generic;
using System.Text;

namespace Threating
{
    class MyStack
    {
        private List<int> data = new List<int>();

        public object lockObject = new object();

        public bool isEmpty {
            get
            {
                lock (lockObject)
                {
                    return this.data.Count == 0;
                }
            } 
        }
        public int Top
        {
            get
            {
                lock (lockObject)
                {
                    return this.data[this.data.Count - 1];
                }
            }
        }

        public void Push(int val)
        {
            lock (lockObject)
            {
                this.data.Add(val);
            }
        }

        public bool PopIfNotEmpty(out int result)
        {
            lock (lockObject)
            {
                if (this.data.Count == 0)
                {
                    result = 0;
                    return false;
                }
                result = this.data[this.data.Count - 1];
                this.data.RemoveAt(this.data.Count - 1);
            }
            return true;
        }

       
    }
}
