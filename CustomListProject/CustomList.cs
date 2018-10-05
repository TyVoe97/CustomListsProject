using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomList<T> 
    {
        private int count;
        T [] items = new T[10];
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

        public int Count{get { return count; }}
 
        public void Add(T value)
        {
            
            T[] temp = new T[10];
            for (int i = 0; i < count; i++) 
            {
                temp[i] = items[i];
            }
            temp[count] = value;
            count++;
            items = temp;
        }
    }
  
}
