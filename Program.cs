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
            // file names stored in a string.
            string Share1_fileName= "Share_1_256.txt";
            string Share2_fileName = "Share_2_256.txt";
            string Share3_fileName = "Share_3_256.txt";
            // large files
            string largeFileName = "Share_1_2048.txt";
            string share2LargeFile = "Share_2_2048.txt";
            string share3LargeFile = "Share_2_2048.txt";
            // when files are read the values will be stored in these varaibles below in array format.
            int[] share1Arr;
            int[] share2Arr;
            int[] share3Arr;
            // storting large values into arr
            int[] largeArrValue;
            int[] share2LargeArrValue;
            int[] share3LargeArrValue;

            // creating instances of an object.
            ReadFile readObject = new ReadFile();
            Sorting sortingObject = new Sorting();
            Output outputObject = new Output();
            Input inputObject = new Input();
            Searching searchObject = new Searching();

            // simply reading the files and storing it into the array variables.
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
          
            // here the output function will display all the 10th value in the decending and ascending array.
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

            // reading large files into the array variables.
            largeArrValue =  readObject.readLargeFile(largeFileName);
            share2LargeArrValue =  readObject.readLargeFile(share2LargeFile);
            share3LargeArrValue =  readObject.readLargeFile(share3LargeFile);
            
            // displaying every 50th value from the array into console.
            Console.WriteLine("Shares_1_2048.txt Every 50th Value");
            outputObject.FindEvery50thValueAscending(largeArrValue);

            Console.WriteLine("Shares_2_2048.txt Every 50th Value");
            outputObject.FindEvery50thValueAscending(share2LargeArrValue);

            Console.WriteLine("Shares_3_2048.txt Every 50th Value");
            outputObject.FindEvery50thValueAscending(share3LargeArrValue);

            // search value from user input; allowing the user to also select for which array they want to search through.
            int selection;
            int searchValue;
            selection = inputObject.SelectArray();
            if(selection == 0) // if they choose 0 the program will end.
            {
                Console.WriteLine("Terminating...");
            } 
            else
            {
                // i used a switch and cases to pass the correct arrays and the correct search value into the function to display the correct values with correct location index.
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
