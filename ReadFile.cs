using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1_SupportingCode
{
    public class ReadFile
    {
        static readonly string textFile = "Share_1_256.txt";

        // reads text files.
        public int[] readArray(string fileName)
        {
            var path = fileName;
            string[] lines = File.ReadAllLines(path);
            int[] ints = Array.ConvertAll(lines, s => int.Parse(s));
            // Console.WriteLine(String.Join(",", ints));

            return ints;
        }

        // i created a separate function to read larger files.
        public int[] readLargeFile(string fileName)
        {
            var path = fileName;
            string[] lines = File.ReadAllLines(path);
            int[] ints = Array.ConvertAll(lines, s => int.Parse(s));


            return ints;
        }
    
    }
}