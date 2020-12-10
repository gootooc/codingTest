using System;
using System.Linq;

namespace _01_SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
        }

        static void SelectionSort()
        {
            int [] list = {1,2,3,4,5,6,7,};
            list.Select((x) => {return x;});

            
        }

        static void Print()
        {
            Console.WriteLine("Selection Sort!");
            Console.WriteLine("How do i know you");
            Console.WriteLine("Just do it!");
            Console.WriteLine("Stop thinking!");
            Console.WriteLine("Do it Now!");
        }
    }
}
