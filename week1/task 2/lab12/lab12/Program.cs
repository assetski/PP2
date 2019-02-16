using System;
class Student // создание класса
    {
        public string name; // public доступен из любого места программы
        public string id;
        public int yearofstudy;
        public Student(string n, string i)// создание метода, метод - это именованный блок кода, который выполняет некоторые действия
        {
            name = n;
            id = i;
        }
        public void first()
        {
            Console.WriteLine(name + " " + id + " ");
        }
        public void second(int yearofstudy)
        {

            yearofstudy++;
            Console.WriteLine(yearofstudy);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Akimgereyev", "18BD110359");// использование метода
            int yearofstudy = int.Parse(Console.ReadLine());
            s.first();
            s.second(yearofstudy);
            
          
            Console.ReadKey();
        }
    }





