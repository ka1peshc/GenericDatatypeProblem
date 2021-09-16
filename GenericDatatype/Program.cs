using System;

namespace GenericDatatype
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter three number");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float num3 = float.Parse(Console.ReadLine());
            GenericType gt = new GenericType();
            float maxNumber = gt.FindMax(num1, num2, num3);
            Console.WriteLine("Max number is {0}", maxNumber);
            
            GenericType gt = new GenericType();
            string maxString = gt.FindMax("Eleven","thirtyThree","fourtyFour");
            Console.WriteLine("Max string is {0}", maxString);
            */
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
