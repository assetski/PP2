using System;
using System.IO;
namespace lab2_2
{
    class Program
    {
        static bool Prime(int n)    //функция для нахождения простого числа
        {
            bool t = true;
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return t;
        }
        static void Main(string[] args)
        {
            string path = @"C:\Users\Akimgereyev\Desktop\allnumbers.txt";// путь первого документа
            string path2 = @"C:\Users\Akimgereyev\Desktop\primes.txt"; // путь второго документа
            StreamReader sr = new StreamReader(path); //считывает данные из первого документа
            StreamWriter sw = new StreamWriter(path2); // переносит нужные данные во второй документ
            String[] ss = sr.ReadToEnd().Split(' '); // разделяет string на отдельные элементы массива
            foreach (string s in ss) //пробегается по массиву из первого документа
            {
                int q = int.Parse(s);                            //конвертирует string в integer
                if (Prime(q))                                  //ищет простые числа в первом документа
                {
                    sw.Write(q + " ");                             //переносит простые числа во второй документ 
                }
            }
            sw.Close();                                          //закрывает второй документ
        }
    }
}
