using System;
using System.Linq;
using System.Reflection;

//Задание 5
/*Реализовать консольную программу на языке C#, которая:
- принимает в параметре командной строки путь к сборке .NET
(EXE- или DLL-файлу);
-загружает указанную сборку в память;
-выводит на экран полные имена всех public -типов данных этой
сборки, упорядоченные по пространству имен (namespace) и по
имени.*/

namespace FifthLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.LoadFrom("D:\\UNIVERSITY\\osisp2\\MPP_lab1.dll");

            var types = assembly.GetTypes().Where(t => t.IsPublic).OrderBy(t => t.Namespace + t.Name);
            foreach (var type in types)
            {
                Console.Out.WriteLine(type.FullName);

            }
        }
    }
}

