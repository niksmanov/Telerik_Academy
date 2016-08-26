using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T>
        where T : IComparable
    {

        private const int defaultCapacity = 16;

        private T[] generic;
        private int count = 0;


        public GenericList(int capacity)
        {
            this.generic = new T[capacity];
        }

        public GenericList()
            : this(defaultCapacity)
        {
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException("Index too big");
                }

                if (index < 0)
                {
                    throw new IndexOutOfRangeException("Index cannot be negative");
                }

                return generic[index];
            }
        }

        private void CheckAndIncreaseCapacity(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index cannot be negative");
            }

            if (index > this.generic.Length - 1)
            {
                T[] newgeneric = new T[this.generic.Length * 2];

                for (int i = 0; i < this.generic.Length; i++)
                {
                    newgeneric[i] = this.generic[i];
                }

                this.generic = newgeneric;
            }

            if (index > count)
            {
                throw new IndexOutOfRangeException(string.Format("Index should be not bigger than {0}!", count));
            }

        }

        public void Add(T element)
        {
            CheckAndIncreaseCapacity(count);

            if (count >= generic.Length)
            {
                throw new IndexOutOfRangeException("Index exceed the list capacity");
            }

            this.generic[count] = element;
            count++;
        }

        public void AddAtPosition(T element, int index)
        {
            CheckAndIncreaseCapacity(index);

            if (index < count)
            {
                for (int i = count; i > index; i--)
                {
                    this.generic[count] = this.generic[count - 1];
                }
            }

            this.generic[index] = element;

            count++;
        }

        public void Remove(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException("Such element does not exist!");
            }

            if (index < 0)
            {
                throw new IndexOutOfRangeException("Cannot have negative index!");
            }

            if (index <= count)
            {
                for (int i = index; i < count - 1; i++)
                {
                    this.generic[index] = this.generic[index + 1];
                }
            }

            count--; 
        }

        public void Clear()
        {
            count = 0;
        }

        public int FindFirst(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (element.Equals(this.generic[i]))
                {
                    return (i);
                }
            }

            return -1;
        }

        public T Min()
        {
            T min = generic[0];
            for (int i = 0; i < count; i++)
            {
                if (min.CompareTo(generic[i]) > 0)
                {
                    min = generic[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = generic[0];
            for (int i = 0; i < count; i++)
            {
                if (max.CompareTo(generic[i]) < 0)
                {
                    max = generic[i];
                }
            }

            return max;
        }

        public override string ToString()
        {
            string result = "";

            if (count == 0)
            {
                return "Empty";
            }

            for (int i = 0; i < count; i++)
            {
                result += "[" + this.generic[i].ToString() + "] ";
            }
            return result;
        }
    }
}