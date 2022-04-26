using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1_SupportingCode
{
    public class Input
    {
        public int SearchValuesFromArray(){
            // Console.WriteLine("Enter a value in the array >>:");
            // int inputValue = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                try
                {
                    Console.Write("Enter a value in the array :>> ");
                    int inputValue = Convert.ToInt32(Console.ReadLine());

                    return inputValue;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            
            }
        }
    }
}
