using System;
using System.Text;

namespace E01
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char tradeMark = '\u00AE';
            Console.WriteLine(tradeMark);
        }
    }
}
