using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1_SupportingCode
{
    public class Output
    {
        public void FindEvery10thValueAscending(int[] arr)
        {
            Sorting sortingObject = new Sorting();
            sortingObject.BubbleSort(arr);
            for (int i = 0; i < arr.Length; i += 10)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }

        public void FindEvery10thValueDescending(int[] arr)
        {
            Sorting sortingObject = new Sorting();
            sortingObject.DecendingBubbleSort(arr);
            for (int i = 0; i < arr.Length; i += 10)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
    }
}