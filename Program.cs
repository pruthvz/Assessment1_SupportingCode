using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1_SupportingCode
{
    public static class Program
    {
        
        public static int findIndex<T>(this T[] array, T item) 
        {
            return Array.IndexOf(array, item);
        }
        static void Main()
        {

            List<int> numbers = new List<int>();
            string Share1_fileName= "Share_1_256.txt";
            string Share2_fileName = "Share_2_256.txt";
            string Share3_fileName = "Share_3_256.txt";
            int[] share1Arr;
            int[] share2Arr;
            int[] share3Arr;

            ReadFile readObject = new ReadFile();
            Sorting sortingObject = new Sorting();
            Output outputObject = new Output();
            Input inputObject = new Input();
            Searching searchObject = new Searching();

            share1Arr = readObject.readArray(Share1_fileName);
            Console.WriteLine("\n");
            share2Arr = readObject.readArray(Share2_fileName);
            Console.WriteLine("\n");
            share3Arr = readObject.readArray(Share3_fileName);

            // ascending arrays
            int[] sortShare1 = share1Arr;
            int[] sortShare2 = share2Arr;
            int[] sortShare3 = share3Arr;

            // decending arrays
            int[] reverseSortedShare1 = share1Arr;
            int[] reverseSortedShare2 = share2Arr;
            int[] reverseSortedShare3 = share3Arr;
          
            // ascending/descending values
            Console.WriteLine("Shares 1");
            outputObject.FindEvery10thValueAscending(sortShare1); 
            outputObject.FindEvery10thValueDescending(reverseSortedShare1); 

            // ascending/descending values Share_2_256.txt
            Console.WriteLine("Shares 2");
            outputObject.FindEvery10thValueAscending(sortShare2); 
            outputObject.FindEvery10thValueDescending(reverseSortedShare2); 

            // ascending/descending values Share_3_256.txt
            Console.WriteLine("Shares 3");
            outputObject.FindEvery10thValueAscending(sortShare3); 
            outputObject.FindEvery10thValueDescending(reverseSortedShare3); 

            // search value from user input;
            int selection;
            int searchValue;
            selection = inputObject.SelectArray();
            if(selection == 0)
            {
                Console.WriteLine("Terminating...");
            } 
            else
            {
                searchValue = inputObject.SearchValuesFromArray();
                switch (selection) 
                {
                case 1:
                    sortingObject.BubbleSort(sortShare1);
                    outputObject.OutputFinalResults(sortShare1,searchValue);
                    break;
                case 2:
                    sortingObject.BubbleSort(sortShare2);
                    outputObject.OutputFinalResults(sortShare2,searchValue);
                    break;
                case 3:
                    sortingObject.BubbleSort(sortShare3);
                    outputObject.OutputFinalResults(sortShare3,searchValue);
                    break;
                }
            }

 
        }
    }
}
