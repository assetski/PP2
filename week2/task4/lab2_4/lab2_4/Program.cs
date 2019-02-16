using System.IO;
namespace lab2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\Akimgereyev\Desktop\asset\path1.txt";    //путь до первого документа
            string path2 = @"C:\Users\Akimgereyev\Desktop\asset\path2.txt";    //создание второго документа
            string text = "manchester united";                                 
            StreamWriter sw = new StreamWriter(path1); // инструмент для ввода в первый файл
            sw.Write(text);                            //ввод в первый файл
            sw.Close();                                 
            File.Copy(path1, path2);                    //копирование из первого во второй
            File.Delete(path1);                         //удаление первого файла
        }
    }
}
