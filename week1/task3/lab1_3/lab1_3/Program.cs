using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string[] arr = n.Split(); // split разбивает строку на элементы массива
            for (int i=0;i<arr.Length;i++) 
            {
                for(int j = 0; j < 2; j++) // дублирование элемента массива
                {
                    Console.Write("{0} ", arr[i]); // {0} - это номер параметра. Вместо {0} при выводе будет использовано значение переменной
                }
            }
            Console.ReadKey();
        }
    }
}
