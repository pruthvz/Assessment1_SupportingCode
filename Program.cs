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

            share1Arr = readObject.readArray(Share1_fileName);
            Console.WriteLine("\n");
            share2Arr = readObject.readArray(Share2_fileName);
            Console.WriteLine("\n");
            share3Arr = readObject.readArray(Share3_fileName);

            int[] sortShare1 = share1Arr;
            int[] sortShare2 = share2Arr;
            int[] sortShare3 = share3Arr;
            

            // ascending/descending values
            Console.WriteLine("Shares 1");
            outputObject.FindEvery10thValueAscending(sortShare1); 
            outputObject.FindEvery10thValueDescending(sortShare1); 


            // ascending/descending values Share_2_256.txt
            Console.WriteLine("Shares 2");
            outputObject.FindEvery10thValueAscending(sortShare2); 
            outputObject.FindEvery10thValueDescending(sortShare2); 

            // ascending/descending values Share_3_256.txt
            Console.WriteLine("Shares 3");
            outputObject.FindEvery10thValueAscending(sortShare3); 
            outputObject.FindEvery10thValueDescending(sortShare3); 

            // var eleD = sortShare1.Distinct().ToArray(); 
        
            // foreach (var item1 in eleD) 
            // { 
            // 	int count = 0; 
            // 	int index = 0; 
            // 	foreach (var item in sortShare1) 
            // 	{ 
            // 		if (item1 == item) 
            // 		{ 
            // 			count += 1; 
            // 			if (count > 1) 
            // 				Console.WriteLine($"Index pos of repeated element {item1} at index " + index); 
            // 		} 
            // 		index += 1; 
            // 	} 
            // } 

            // searching
            int searchValue;
            searchValue = inputObject.SearchValuesFromArray();
            Console.WriteLine(searchValue);

            // finding search value index in the sorted array. ascending list.
            int index = sortShare1.findIndex(searchValue);
            if (index != -1)
            {
                Console.WriteLine(String.Format("Element {0} is found at index {1}", searchValue, index));
            }
            else{
                Console.WriteLine("Element not found in the given array!");
            }

            
        
        }
    }
}
