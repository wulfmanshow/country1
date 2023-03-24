using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(@"Data Source=DESKTOP-H61STOF ;Initial Catalog=Country; Integrated Security=True");
            var queryResults1 = from c in db.Countrys
                               select new
                               {
                                   ID = c.Id,
                                   Name = c.NameCountry,
                                   Peoples = c.People
                               };

            var queryResults2 = from c in db.Countrys
                                select new
                                {
                                    Name = c.NameCountry, 
                                };
            var queryResults3 =from c in db.Capital
                                orderby c.NameCapital
                                select new
                                {
                                    Name = c.NameCapital,
                                };
            var queryResults4 = from c in db.Countrys
                                join k in db.Cities
                                on c.CitiesId equals k.Id
                                where c.NameCountry == "USA"
                                select new
                                {
                                    k.NameCity
                                };
            var queryResults5 = from c in db.Capital
                               where c.Population >= 5000000
                                select new
                                {
                                    c.NameCapital
                                };
            var queryResults6 = from c in db.Countrys
                                join p in db.PartOfTheWorld
                                on c.IdPartOfTheWorld equals p.Id
                                where p.Part == "Europe"
                                select new
                                {
                                    c.NameCountry
                                };
            var queryResults7 = from c in db.Capital 

                                where c.NameCapital.StartsWith("K")
                                select new
                                {
                                    c.NameCapital
                                };
            var queryResults8 = from c in db.Capital

                                where c.NameCapital.Contains("A") && c.NameCapital.Contains("R")
                                select new
                                {
                                    c.NameCapital
                                };
            var queryResults9 = (from c in db.Countrys

                                orderby c.CountryArea descending
                                select new
                                {
                                    c.NameCountry
                                }).Take(5);
            var queryResults10 = (from c in db.Capital

                                 orderby c.Population descending
                                 select new
                                 {
                                     c.NameCapital
                                 }).Take(5);
            var queryResults11 = (from c in db.Countrys

                                 orderby c.CountryArea descending
                                 select new
                                 {
                                     c.NameCountry
                                 }).Take(1);
            var queryResults12 = (from c in db.Capital

                                  orderby c.Population descending
                                  select new
                                  {
                                      c.NameCapital
                                  }).Take(1);
            var queryResults13 = (from c in db.Countrys
                                  join p in db.PartOfTheWorld
                                  on c.IdPartOfTheWorld equals p.Id
                                  where p.Part == "Europe"
                                  orderby c.CountryArea
                                  select new
                                  {
                                      c.NameCountry
                                  }).Take(1);
            foreach (var result1 in queryResults1)
            {
                Console.WriteLine(result1);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (var result2 in queryResults2.ToList())
            {
                Console.WriteLine(result2);
            }
            Console.WriteLine("------------------------------------------------------------------------------"); 
            foreach (var result3 in queryResults3.ToList())
            {
                Console.WriteLine(result3);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (var result4 in queryResults4.ToList())
            {
                Console.WriteLine(result4);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (var result5 in queryResults5.ToList())
            {
                Console.WriteLine(result5);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (var result6 in queryResults6.ToList())
            {
                Console.WriteLine(result6);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (var result7 in queryResults7.ToList())
            {
                Console.WriteLine(result7);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (var result8 in queryResults8.ToList())
            {
                Console.WriteLine(result8);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (var result8 in queryResults9.ToList())
            {
                Console.WriteLine(result8);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (var result8 in queryResults10.ToList())
            {
                Console.WriteLine(result8);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (var result8 in queryResults11.ToList())
            {
                Console.WriteLine(result8);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (var result8 in queryResults12.ToList())
            {
                Console.WriteLine(result8);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (var result8 in queryResults13.ToList())
            {
                Console.WriteLine(result8);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.ReadLine();       
        }
    }
}
