using System;
using System.IO;
namespace far_manager
{
    class FarManager
    {
        public int cursor;
        public int size;
        public string path;
        DirectoryInfo df = null;
        FileSystemInfo sf = null;
        public FarManager()
        {
            cursor = 0;
        }
        public FarManager(string path)
        {
            this.path = path; 
            cursor = 0; // располагаем курсор вначале отсчета
            df = new DirectoryInfo(path);
            size = df.GetFileSystemInfos().Length;
        }
        public void UP()
        {
            cursor--;
            if (cursor < 0) cursor = size - 1; // когда курсор уходит за границы вверх, он переходит на последнюю папку или файл
        }  // size-1 так как отсчет начинается с нуля
        public void DOWN()
        {
            cursor++;
            if (cursor == size) cursor = 0; // когда курсор уходит за границы вниз , он возвращается к первоначальному положению курсора 0
        }
        public void COLOUR(FileSystemInfo fs, int index)
        {
            if (cursor == index)
            {
                Console.ForegroundColor = ConsoleColor.Red; // задаем курсору цвет
                sf = fs;
            }
            else if (fs.GetType() == typeof(FileInfo))
            {
                Console.ForegroundColor = ConsoleColor.Green; // цвет файлов
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White; // цвет папок
            }
        }
        public void ENTER()
        {
            df = new DirectoryInfo(path);
            FileSystemInfo[] files = df.GetFileSystemInfos();
            int k = 0;
            foreach (FileSystemInfo fs in files)
            {
                COLOUR(fs, k);
                k++;
                Console.Write(k + ". ");
                Console.WriteLine(fs.Name);
            }
        }
        public void Color() // функция для изменения цвета
        {
            df = new DirectoryInfo(path);
            FileSystemInfo[] fs = df.GetFileSystemInfos();
            size = fs.Length;
        }
        public void FAR()
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            while (consoleKey.Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Color();
                ENTER();
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.UpArrow)
                {
                    UP();
                }
                if (consoleKey.Key == ConsoleKey.DownArrow)
                {
                    DOWN();
                }
                if (consoleKey.Key == ConsoleKey.Enter)
                {
                    if (sf.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        path = sf.FullName;
                    }
                }
                if (consoleKey.Key == ConsoleKey.Backspace)
                {
                    cursor = 0;
                    path = df.Parent.FullName;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Akimgereyev/Desktop/whotag"; // путь до папки
            FarManager farManager = new FarManager(path); // присвоению классу папки path
            farManager.FAR();
        }
    }
}
