using System;

namespace GenericDatatype
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] intArr = { 1, 3, 19, 22, 12 };
            GenericType<int> generic = new GenericType<int>(intArr);
            generic.PrintMaxValue();

            string[] stringArr = { "one","sixteen", "three" };
            GenericType<string> generic1 = new GenericType<string>(stringArr);
            generic1.PrintMaxValue();

            double[] doubleArr = { 111.1, 14.2, 557.2 };
            GenericType<Double> genricDouble = new GenericType<double>(doubleArr);
            genricDouble.PrintMaxValue();

        }
    }
}
