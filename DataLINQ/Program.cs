using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLINQ
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 6, 8, 29, 90, 5 };

            // Фильтрация
            //numbers = numbers.Where(n => n > 10).ToList();
            //foreach (var item in numbers)
            //    Console.WriteLine(item);


            //var query = from item in numbers
            //            where item > 5
            //            select item;

            //Console.WriteLine((from item in numbers
            //                   where item > 5
            //                   select item).Count());

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}


            //Func<int, bool> where = (number) => number > 10;
            //numbers = numbers.Where(where).ToList();
            //foreach (var item in numbers)
            //    Console.WriteLine(item);



            // Сортировка по возрастанию (по умолчанию)
            //numbers = numbers.OrderBy(n => n).ToList();
            //foreach (var item in numbers)
            //    Console.WriteLine(item);

            // Сортировка по убыванию
            //numbers = numbers.OrderByDescending(n => n).ToList();
            //foreach (var item in numbers)
            //    Console.WriteLine(item);




            // Миксуем
            //numbers = numbers
            //    .Where(n => n > 5)
            //    .OrderBy(n => n).ToList();
            //foreach (var item in numbers)
            //    Console.WriteLine(item);




            List< Person > people = new List<Person>()
            {
                new Person(){ Name = "Руфина", Age = 500 },
                new Person(){ Name = "Сергей", Age = 2 },
                new Person(){ Name = "Лера", Age = 20 },
                new Person(){ Name = "Даниэль", Age = 20 },
                new Person(){ Name = "Алина", Age = 15 },
                new Person(){ Name = "Соня", Age = 15 }
            };

            // Фильтрация
            //people = people.Where(p => p.Age > 15).ToList();
            //foreach (var item in people)
            //    Console.WriteLine(@$"{item.Name} - {item.Age}");

            // Группировка
            //var group = people.GroupBy(p => p.Age);
            //foreach (var item in group)
            //{
            //    Console.WriteLine(item.Key + " лет:");
            //    foreach (var value in item)
            //    {
            //        Console.WriteLine(value.Name);
            //    }
            //    Console.WriteLine();
            //}


            // Рассмотреть Skip/Take/Sum/Min/Max
        }
    }
}
