using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ConsoleApp1
{
    public class Person : IComparable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string BirthData { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Language { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Person person)
        {
            return this.Salary - person.Salary;
        }

        public override string ToString()
        {
            return $"{Salary}  {Name} {Surname} {Gender}   ";
        }
    }

    class Program
    {
        //static List<int> GenerationNumber()
        //{
        //    List<int> arr = new List<int>();
        //    Random random = new Random();
        //    for (int i = 0; i < 100; i++)
        //    {
        //        arr.Add(random.Next(0, 100));
        //    }

        //    return arr;
        //}

        //extends methods


        static void Main(string[] args)
        {
            //List<int> numbersOne = new List<int>() { 1, 2, 3, 4, 5,1,2,3 };
            //List<int> numbersTwo = new List<int>() { 2,3,6,7,8,9 };



            ////  var result = numbersOne.Distinct();

            ////var result =  numbersOne.Union(numbersTwo); 
            ////var result = numbersOne.Except(numbersTwo);
            ////var result = numbersOne.Intersect(numbersTwo);
            ////var result = numbersOne.Concat(numbersTwo); 

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}















            //string name = "FArid";
            //Console.WriteLine(name.HasA());
            //Console.WriteLine(name.AppendHello());
            //Console.WriteLine(name.AppendStr("Abdullayev"));



            var json = File.ReadAllText("data.json");
            var list = JsonSerializer.Deserialize<List<Person>>(json);


            // SUM MIN MAX AVERAGE COUNT

            //var count = list.Count();
            //Console.WriteLine(count);

            // var count = list.Min(x => x.Salary);
            // var count = list.Min(x => x.Name.Length);
            //var count = list.Min(x => x.Id);
            //var count = list.Min();


            //var count = list.Max(x=>x.Id);

            //var count = list.Sum(x => x.Salary);
            // var count = list.Average(x => x.Salary);


            //-------------------------------------------------------------
            //where , first (Exception) , last (Exception) 

            // var arr = list.Where(x => x.Salary > 4500);
            //var arr = list.Where(x => x.Salary != 4516);
            //Console.WriteLine(arr.Count());

            //  var item = list.First(x => x.Salary > 4700);
            //  var item = list.Last(x => x.Salary > 4700);

            //var average = list
            //    .Where(x => x.Country == "Russia")
            //    .Where(x => x.Salary > 1000)
            //    .Average(x => x.Salary);

            //Console.WriteLine(average);


            // FirstOrDefault()  LastOrDefault()
            //  var item = list.FirstOrDefault(x => x.Salary > 10000);
            /// // var item = list.LastOrDefault(x => x.Salary > 100);
            // Console.WriteLine(item);


            ///////////////////////////////////////////////////////////////////////////////
            /// All Any Contains
            /// 

            //var item = list.All(x => x.Salary > 600);
            //var item = list.Any(x => x.Salary > 4998);

            //var person = list[10];
            //list.Remove(person); ;
            //var item = list.Contains(person);
            //Console.WriteLine(item);



            //////////////////////////////////////////////////////////////////////////////////
            ///

            //ORDERBY  ORDERBYDESCENDING , THENBY , THENBYDescending

            //   var people = list.Where(x => x.Country == "Russia").OrderBy(x => x.Salary);
            //   var people = list.Where(x => x.Country == "Russia").OrderByDescending(x => x.Name);
            //var people = list.Where(x => x.Country == "Russia").OrderBy(x => x.Name).ThenBy(x=>x.Surname);



            ////////////////////////////////////////////////////////////////////////////////////////////////
            //SKIP TAKE skipwhile takewhile



            //var people = list.Where(x => x.Country == "Russia").OrderBy(x => x.Salary).TakeWhile(x => x.Salary < 2000);
            var people = list.Where(x => x.Country == "Russia").OrderBy(x => x.Salary).SkipWhile(x => x.Salary < 2000);

            Console.WriteLine("------");
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(people.Count());




            //    var people = list.Where(x => x.Country == "Russia").OrderByDescending(x => x.Salary).Take(10);
            // var people = list.Where(x => x.Country == "Russia").OrderByDescending(x => x.Salary).Skip(10).Take(1);


            //int page = 0;
            //while (true)
            //{
            //    var result = list
            //        .Skip(page * 10)
            //        .Take(10);

            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    Console.WriteLine("Press any key to go the next page...\n");
            //    Console.ReadKey();
            //    Console.Clear();
            //    page++;
            //}


            //var arr = list.Where(x => x.Country == "Russia").Select(x=>x.Name);

            //var arr = list
            //    .Where(x => x.Country == "Russia")
            //    .Select(x => new { Surname=x.Surname,Name=x.Name})
            //    .OrderBy(x=>x.Name);

            //var arr = from x in list
            //          where x.Country == "Russia"
            //          orderby x.Name
            //          select new { Surname = x.Surname, Name = x.Name };



            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item.Name + " " + item.Surname);
            //}



        }
    }

    static class Extension
    {
        public static bool HasA(this string str)
        {
            return str.ToLower().Contains('a');
        }
        public static string AppendHello(this string str)
        {
            return str + " Hello";
        }
        public static string AppendStr(this string str, string newStr)
        {
            return str + " " + newStr;
        }
    }
}




//LING (Language Integrated Query)

//List<int> arr = GenerationNumber(); // read DataBase

// List<int> arr = new List<int>() { 1, 2,3,4,5,6,7,6,4,32,534,6,3,6,5,23,43,41,4, 7 };

//var result = arr.First(num => num == 7);
//var result = arr.Last(num => num == 999);

// var result = arr.LastOrDefault(num => num == 999);
// var result = arr.FirstOrDefault(num => num == 7);
// Console.WriteLine(result);


//var json = File.ReadAllText("data.json");
//var list = JsonSerializer.Deserialize<List<Person>>(json);
//Console.WriteLine(list.Count);