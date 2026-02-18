using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // variáveis string
            Console.OutputEncoding = Encoding.UTF8;
            string message = "So much programing skill";
            string heart = "One heart \u2764";
            string newLine = "\nStart \nEnd";
            Console.WriteLine(message);
            Console.WriteLine(heart);
            Console.WriteLine(newLine);
        }
    }
}
