using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4
{
    class Program
    {
        struct date
        {
            public int day;
            public int month;
            public int year;
        };
        struct student
        {
            public string id;
            public string name;
            public date dob;
        };
        static void Main(string[] args)
        {
            int n;
            student tg;
            student[] list;
            Console.Write("Enter the number of student: ");
            n = int.Parse(Console.ReadLine());
            list =new student[n];
            Console.WriteLine("Enter student informations:  ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Student " + i);
                Console.Write("Identification Number: ");
                list[i].id = Console.ReadLine();
                Console.Write("Name: ");
                list[i].name = Console.ReadLine();
                Console.WriteLine("Date of Birth: ");
                list[i].dob.day = int.Parse(Console.ReadLine());
                list[i].dob.month = int.Parse(Console.ReadLine());
                list[i].dob.year = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("====================");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Studen infomations " + i);
                Console.WriteLine("Identification Number: " + list[i].id);
                Console.WriteLine("Name: " + list[i].name);
                Console.WriteLine("Date of Birth: {0}/{1}/{2} ", list[i].dob.day, list[i].dob.month, list[i].dob.year);
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if(list[j].dob.year<list[i].dob.year)
                    {
                        tg = list[j];
                        list[j] = list[i];
                        list[i] = tg;
                    }
                }
            }
            Console.WriteLine("====================");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Studen infomations " + i);
                Console.WriteLine("Identification Number: " + list[i].id);
                Console.WriteLine("Name: " + list[i].name);
                Console.WriteLine("Date of Birth: {0}/{1}/{2} ", list[i].dob.day, list[i].dob.month, list[i].dob.year);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
