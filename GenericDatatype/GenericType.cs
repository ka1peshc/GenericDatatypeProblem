using System;
using System.Collections.Generic;

namespace GenericDatatype
{
    class GenericType<T> where T : IComparable
    {
        public T[] value;
        /// <summary>
        /// Class GenericType Constructor 
        /// </summary>
        /// <param name="value">array</param>
        public GenericType(T[] value)
        {
            this.value = value;
        }
        /// <summary>
        /// Sort array using inbuilt method
        /// </summary>
        /// <param name="value">Array</param>
        /// <returns>Sorted array</returns>
        public T[] Sort(T[] value)
        {
            Array.Sort(value);
            return value;
        }
        /// <summary>
        /// Fetch last element from sorted array
        /// </summary>
        /// <param name="values">Array</param>
        /// <returns>Array last element</returns>
        public T maxValue(params T[] values)
        {
            var sortedValue = Sort(values);
            return sortedValue[^1];
        }
        /// <summary>
        /// Display maximum value in the array
        /// </summary>
        public void PrintMaxValue()
        {
            var max = maxValue(this.value);
            Console.WriteLine("Maximum value is {0}", max);
        }
    }
}
 