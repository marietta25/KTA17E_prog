using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysResearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //program asks for 5 numbers from the user, and prints out two sorted array of numbers

            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sisesta suvaline arv: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            // sort numbers from smaller to larger
            Array.Sort(arr);

            Console.Write("Arvud väiksemast suuremani: ");
            foreach (int i in arr)
            {
                Console.Write("\t{0}", i);
            }

            var desc = from s in arr
                       orderby s descending
                       select s;

            Console.WriteLine();

            // sort numbers from larger to smaller
            Console.Write("Arvud suuremast väiksemani: ");
            foreach (int c in desc)
            {
                Console.Write("\t{0}", c);
            }


            Console.ReadLine();
        }
    }
}
