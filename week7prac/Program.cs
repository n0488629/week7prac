using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7prac
{
    internal class Program
    {
        public static int CountWords(string fileName) 
        {
            // read file to new string
            string content = File.ReadAllText(fileName);
            // make array to hold split file
            string[] strings;
            strings = content.Split(' '); // array = content split by spaces
            int count = strings.Length; // length is equal to number of words
            return count;
        }
        static void Main(string[] args)
        {
            string words = "Hello world i am world";
            string fileName = "filename.txt";

            File.WriteAllText(fileName, words);
            Console.WriteLine("There are " + CountWords(fileName) + "words in the string");
            Console.ReadKey();
        }
    }
}
