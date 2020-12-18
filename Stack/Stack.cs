using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T>
    {
        private int[] s;
        public Stack(int size)
        {
            s = new int[size];
        }
        public void Push(T item)
        {
            int i = 0;
            while (s[i] != 0)
            {
                i++;
            }
            if(i+1 >= s.Length)
            {
                Array.Resize(ref s, s.Length * 2);
            }

            s[i] = item;
        }
        public T Pop()
        {
           T t = default(T);
            return t;
        }

        public int Count()
        {
            return 0;
        }
    }
}
