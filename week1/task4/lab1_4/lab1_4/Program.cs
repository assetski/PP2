using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "[*]"; // обьявление перемененной
            int a = int.Parse(Console.ReadLine());  //  Ввод размера
            for (int i = 1; i <= a; i++)  //      используем цикл в цикле
            {                               
                for (int j = 1; j <= i; j++)    
                {
                    Console.Write(s);  // выводим возрастающее каждой итерацией startriangle
                }
                Console.WriteLine();   //  переход в следующую строку
            }
            Console.ReadLine();  //  для того чтобы консоль не закрывалась
        }
    }
}
