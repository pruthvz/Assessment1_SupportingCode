using System;

namespace Assessment1_SupportingCode
{
    public class Searching
    {
        public  int ArrayLinearSearch(int[] data, int searchItem){
            int N = data.Length;
            for (int i = 0; i < N; i++)
                if (data[i] == searchItem)
                    return i;
            return -1;
        }  

       
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
        
        public int linearSearch(int[] array, int target, int off) 
        {
            for (int i = off; i < array.Length; i++) {
            if (array[i] == target) {
                return i;
            }
        }
        return -1;
}

        
    }
}
