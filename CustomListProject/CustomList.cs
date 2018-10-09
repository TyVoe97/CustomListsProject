using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomList<T> : IEnumerable<T>
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
        private int count;

        T[] items = new T[4];
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
        public int Count { get { return count; } }
        private int capacity = 4;
        private T[] numbers;

        public void Add(T value)
        {

            T[] temp = new T[capacity * 2];
            for (int i = 0; i < count; i++)
            {
                temp[i] = items[i];
            }
            temp[count] = value;
            count++;
            items = temp;
        }
        public void Remove(T value)
        {
            int tempCount = Count - 1;
            T[] tempArray = new T[tempCount];
            int Location = 0;
            int d = 0;
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(value))
                {
                    Location = i;
                    break;
                }
            }
            if (Location > 0)
            {
                for (int e = 0; e < Count; e++)
                {
                    if (!items[e].Equals(value))
                    {
                        tempArray[d] = items[e];
                        d += 1;
                    }
                }
                items = tempArray;
            }
            count = d;
        }
        string addedString = "";
        public override string ToString()
        {
            for (int i = 0; i < count; i++)
            {
                addedString += items[i].ToString();
            }
            return addedString;
        }
        public static CustomList<T> operator +(CustomList<T> listA, CustomList<T> listB)
        {
            CustomList<T> output = listA;
            foreach (T element in listB)
            {
                output.Add(element);
            }
            return output;
        }

        public static CustomList<T> operator- (CustomList<T> listA, CustomList<T> listB)
        {
            CustomList<T> output = " ";
            for (int i = 0; i < count; i++)
            {
                foreach (T element in listB)
                {
                    output.Add(element);
                }
                return output;
            }


    }
}
