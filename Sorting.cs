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
    }   
}