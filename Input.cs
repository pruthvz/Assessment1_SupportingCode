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

        public int SelectArray()
        {
            while (true){
                try{
                    Console.Write("Select an Array: Share_1 = 1, Share_2 = 2, Share_3 = 3, 0 = Exit :>>");
                    int selection = Convert.ToInt32(Console.ReadLine());
                    while(selection >= 4){
                        Console.WriteLine("Please enter from the selection values above!");
                        selection = Convert.ToInt32(Console.ReadLine());
                    }
                      switch (selection) 
                    {
                    case 1:
                        Console.WriteLine(">> Selected Share_1");
                        break;
                    case 2:
                        Console.WriteLine(">> Selected Share_2");
                        break;
                    case 3:
                        Console.WriteLine(">> Selected Share_3");
                        break;
                    }
                    return selection;
                }
                catch{
                    Console.WriteLine("Please enter from the selection values above!");
                }
            }
        }

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
