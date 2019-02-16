using System;
using System.IO;
namespace lab2_1
{
    class Program
    {
        public static bool Polyndrom(string p) // функция для нахождения палиндрома
        {
            bool poly = true;
            for (int i = 0; i < p.Length/2;++i ) // создаем цикл от 0 до p.length/2  
            {
                if (p[i]!= p[p.Length - i - 1]) // сравнение элементов, 1 с последним, 2 с препоследним
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Akimgereyev\Desktop\testnik.txt", FileMode.OpenOrCreate, FileAccess.Read);//класс FileStream представляет возможности по считыванию из файла и записи в файл
            // FileMode.OpenOrCreate указывает на то, что операционная система должна открывать файл, если он существует, в противном случае должен быть создан новый файл
            StreamReader sr = new StreamReader(fs); // StreamReader позволяет нам считывать весь текст или отдельные строки из текстового файла
            string s = sr.ReadToEnd();//ReadToEnd() Читает весь текст из файла
            Console.WriteLine(s);
            if (Polyndrom(s))
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
            sr.Close(); 
            fs.Close(); 
            Console.ReadKey(); 
        }
    }
}

