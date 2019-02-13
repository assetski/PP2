using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2_3
{
    class Program
    {
        static string Space(int a) // функция для пробелов 
        {
            string s = "      ";
            string p = "";
            for (int i = 0; i < a; i++)
            {
                p += s;
            }
            return p;
        }
        static void info(DirectoryInfo dir, int a) // рекурсия для открытия папок и файлов в виде дерева
        {
            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] dires = dir.GetDirectories();
            foreach (FileInfo file in files) // вывод названия файлов с определенным расстоянием
            {

                Console.Write(Space(a));
                Console.WriteLine(file.Name);
            }
            foreach (DirectoryInfo dire in dires) // вывод названия папок с определенным расстоянием
            {
                Console.Write(Space(a)); // переход к функции Space
                Console.WriteLine(dire.Name);
                info(dire, a + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Akimgereyev\Desktop\галерея iphone");
            info(dir, 0);
            Console.ReadKey();
        }
    }
}
