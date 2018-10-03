using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     public class CustomList<T>
     {
        T[] nums = new T[1];

        public void Add(T thing)
        {
            T[] temporaryArray = new T[nums.Length * 2];
        }

     }
}
