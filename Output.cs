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
        // when an array is passed to this function it will sort the array and it will print every 10th value from the array.
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

        // it will print every 10th value but in decending order..
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

        // similar to the 10th value. I have copied and pasted the function but made it so it displays every 50th value.
        public void FindEvery50thValueAscending(int[] arr)
        {
            Sorting sortingObject = new Sorting();
            sortingObject.Insertionsort(arr);
            for (int i = 0; i < arr.Length; i +=50)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }


        public void OutputFinalResults(int[] arr, int target){
            Searching searchObject = new Searching();
            int result = searchObject.search(arr, target);
            if (result == -1) 
            {
                Console.WriteLine("Element is not present in array");
                // nearest values if the current searched value isn't found!
                Console.WriteLine(">> Nearest search value with its index location..");
                int checkArrayLength = arr.Length;
                if (target > checkArrayLength){
                    Console.WriteLine("Target value is too big!");
                }else{
                    OutputFinalResults(arr,target + 1);
                    OutputFinalResults(arr,target - 1);
                }
            }

            int off = 0;
            while(true)
            {
                off = searchObject.linearSearch(arr, target, off);
                if(off < 0) break;
                Console.WriteLine($"Search Value >> {target} Found at index: " + off);
                off += 1;
            }   
        }
    }
}