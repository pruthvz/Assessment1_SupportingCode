using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1_SupportingCode
{
    class Program
    {
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

            share1Arr = readObject.readArray(Share1_fileName);
            Console.WriteLine("\n");
            share2Arr = readObject.readArray(Share2_fileName);
            Console.WriteLine("\n");
            share3Arr = readObject.readArray(Share3_fileName);

            int[] a = share1Arr;
            

            sortingObject.BubbleSort(a);
            sortingObject.DecendingBubbleSort(share1Arr);
            foreach(int n in a){
                Console.WriteLine(n);
            }

            Console.WriteLine(a[10]);



        
        }
    }
}
