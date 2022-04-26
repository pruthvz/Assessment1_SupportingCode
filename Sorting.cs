using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1_SupportingCode
{
    public class Sorting
    {
       
       // normal bubble sort
       public void BubbleSort(int[] arr)
       {
              int temp;
              for (int i = 0; i < arr.Length - 1; i++)
              {
                     for (int j = 0; j < arr.Length - 1 - i; j++)
                     {
                            if (arr[j] > arr[j + 1])
                            {
                                   temp = arr[j];
                                   arr[j] = arr[j + 1];
                                   arr[j + 1] = temp;
                            }
                     }
              }
       }

       // bubble sort by descending order. 
       public void DecendingBubbleSort(int[] arr)
       {
              int temp;
              for (int i = 0; i < arr.Length - 1; i++)
              {
                     for (int j = 0; j < arr.Length - 1 - i; j++)
                     {
                            if (arr[j] < arr[j + 1])
                            {
                                   temp = arr[j];
                                   arr[j] = arr[j + 1];
                                   arr[j + 1] = temp;
                            }
                     }
              }
       }

       // insertion sort
       public void Insertionsort(int[] arr)
       {
              int n = arr.Length;
              for (int i = 1; i < n; ++i) 
              {
                     int key = arr[i];
                     int j = i - 1;
              
                     while (j >= 0 && arr[j] > key) 
                     {
                            arr[j + 1] = arr[j];
                            j = j - 1;
                     }
                            arr[j + 1] = key;
              }
       }

       // printing the array in order when insertion sort is complete.
       public void printArray(int[] arr)
       {
              int n = arr.Length;
              for (int i = 0; i < n; ++i)
              Console.Write(arr[i] + " ");
       
              Console.Write("\n");
       }
 
 
    }   
}