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
            string content = File.ReadAllText(fileName);
            string[] strings;
            strings = content.Split(' ');
            int count = strings.Length;
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
