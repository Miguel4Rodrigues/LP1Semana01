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

            // variáveis criadas por concatenação
            string concat1 = "Hey" + 1;
            string concat2 = concat1 + 2;
            Console.WriteLine(concat1);
            Console.WriteLine(concat2);
            // variáveis criadas por interpolação
            int camisolaPreco = 10;
            int camisolaQuantidade = 25;
            string inter1 = $"valor de camisola é {camisolaPreco}€";
            string inter2 = $"Disponíveis {camisolaQuantidade} Camisolas no total de {camisolaPreco * camisolaQuantidade}€";
            Console.WriteLine(inter1);
            Console.WriteLine(inter2);

            // formatação de strings
            double xx = 1.23456;
            int ii = 19;

            string xx1 = $"xx = {xx:f2}";
            string xx2 = $"xx = {xx:p1}";
            Console.WriteLine(xx1);
            Console.WriteLine(xx2);

            string ii1 = $"ii = {ii:x}";
            string ii2 = $"ii = {ii:c}";
            Console.WriteLine(ii1);
            Console.WriteLine(ii2);

        }
    }
}
