using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2
{
        class Student // создание класса
        {
            public string name; // public доступен из любого места программы
            public string id;
            public int yearofstudy=1;
            public Student(string n, string i)// создание метода, метод - это именованный блок кода, который выполняет некоторые действия
            {
                name = n;
                id = i;
            }
            public void first()
            {
                Console.WriteLine(name + " " + id + " ");
            }
            public void second()
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
                s.first();
                s.second();
                Console.ReadKey();
            }
        }
    }

            
        
    
