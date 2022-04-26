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

        // select array function with user input.
        public int SelectArray()
        {
            // i added a try and catch to see if the user enters something from the options given.
            while (true){
                try{
                    Console.Write("Select an Array: Share_1 = 1, Share_2 = 2, Share_3 = 3, 0 = Exit :>>");
                    int selection = Convert.ToInt32(Console.ReadLine()); // converted the value to an int and returned it so i can use it in program.cs
                    while(selection >= 4){
                        Console.WriteLine("Please enter from the selection values above!");
                        selection = Convert.ToInt32(Console.ReadLine());
                    }
                      switch (selection) 
                    {
                    // once the selection is chosen it will display the user which array was selected and in program.cs the main functionality takes place. 
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
            // simple input function which gets an integer as a value and returns it. This value is then used in program.cs and passed down to searching class to be searched using linear search.
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
