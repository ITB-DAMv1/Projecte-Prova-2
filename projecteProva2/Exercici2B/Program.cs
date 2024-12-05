using System;
using Prova;

namespace Exercici2
{
    public class Program
    {
        public static void Main()
        {
            int[] myArray = { 10, 4, 6, 4, 8, -13, 2, 3 };
            SecondSort.Order(myArray, 0, myArray.Length - 1);
            PrintArray(myArray);
        }

        public static void PrintArray(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i]);
                if (i < myArray.Length -1) Console.Write(", ");
                else Console.WriteLine();
            }
        }
    }
}