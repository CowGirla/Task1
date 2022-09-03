using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lessons
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            char a = '(';
            char b = ')';
            Console.WriteLine("Введите данные для конвертации");



            string data = Console.ReadLine();
            data = data.ToLower();
            char[] chars = data.ToCharArray();            
            int lenght = chars.Length;
            char[] chars1 = new char[lenght+1];
            for (int h = 0; h < chars.Length; h++)
            {
                chars1[h] = chars[h];
            }
            bool[] reright = new bool[lenght];
            bool[] reright2 = new bool[lenght];
            char[] result = new char [lenght];

            for (int i = 0; i < chars.Length; i++)
            {
                if (reright[i] == false)
                {
                     for (int J = i + 1; J < chars1.Length; J++)
                     {
                        if (chars[i] == chars1[J])
                        {
                            result[J] = b;
                            result[i] = b;
                            reright[J] = true;
                            reright2[i] = true;

                        }
                        else
                        {
                            if (reright2[i] == false)
                            {
                                result[i] = a;
                            }
                        }
                     }
                }
            }
                
            data = String.Concat<char>(result);

            Console.WriteLine("Результат конвертации: ");
            Console.WriteLine(data);
         
        }
    }
}
