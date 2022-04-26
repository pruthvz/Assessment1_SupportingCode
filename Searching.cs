using System;

namespace Assessment1_SupportingCode
{
    public class Searching
    {
        // basic linear search which goes through all the values in the array.
        public  int ArrayLinearSearch(int[] data, int searchItem){
            int N = data.Length;
            for (int i = 0; i < N; i++)
                if (data[i] == searchItem)
                    return i;
            return -1;
        }  

        // another variation of linear search where it goes through all the values;
        public int search(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        // I used this linear search, because here it keeps count of the variable int off, which counts all the dupes index.
        public int linearSearch(int[] array, int target, int off) 
        {
            for (int i = off; i < array.Length; i++) 
            {
                if (array[i] == target) 
                {
                    return i;
                }
            }
           return -1;
        }

        
    }
}
