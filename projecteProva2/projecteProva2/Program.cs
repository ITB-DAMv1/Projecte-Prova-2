using System;
using Prova;

namespace Exercici2
{
    public class Program
    {
        const string FstMsg = "Introdueix un numero i et dire si es troba a l'array.";
        const string InvalidNum = "El programa necesita un numero enter.";
        const string InsideArray = "El numero {0} es troba a l'array.";
        const string OutsideArray = "El numero {0} no es troba a l'array.";

        public static void Main() 
        {
            int[] myArray = { 10, 4, 6, 4, 8, -13, 2, 3 };
            Console.WriteLine(FstMsg);
            int userNum = GetNumber();
            SecondSort.Order(myArray, 0, myArray.Length - 1);
            if (SearchClass.BinarySearch(myArray, 0, myArray.Length - 1, userNum) == -1) Console.WriteLine(OutsideArray, userNum); 
            else Console.WriteLine(InsideArray, userNum);
        }
        public static int GetNumber()
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine(InvalidNum);
            }
            return n;
        }
    }
}