using System;
using System.Collections.Generic;

namespace GenericDatatype
{
    class GenericType<T> where T : IComparable
    {
        public T[] value;

        public GenericType(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] value)
        {
            Array.Sort(value);
            return value;
        }
        public T maxValue(params T[] values)
        {
            var sortedValue = Sort(values);
            return sortedValue[^1];
        }
        public void PrintMaxValue()
        {
            var max = maxValue(this.value);
            Console.WriteLine("Maximum value is {0}", max);
        }
    }
}
 