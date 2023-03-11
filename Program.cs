using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterDegistirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool durum = true;

            while (durum)
            {
                Console.Write("Bir metin giriniz:");
                string input = Console.ReadLine();

                char[] harf = input.ToCharArray();
                char temp = harf[0];
                harf[0] = harf[harf.Length - 1];
                harf[harf.Length - 1] = temp;
                string output = new string(harf);

                Console.WriteLine(output);

            }
      
            Console.ReadKey();
        }
    }
}
