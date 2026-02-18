using System;
using System.Text; 

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // variáveis inteiras
            byte num1 = 25;
            short num2 = 2026;
            int num3 = 1500000;
            long num4 = 10000000000L;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);

            // variáveis char
            Console.OutputEncoding = Encoding.UTF8;
            char heart = '\u2764';
            char pencil = '\u270F';
            char warning = '\u26A0';
            Console.WriteLine(heart);
            Console.WriteLine(pencil);
            Console.WriteLine(warning);  
        }
    }
}
