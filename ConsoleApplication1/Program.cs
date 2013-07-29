using System;
using System.Collections.Generic;
using EventEgg.Service;
using EventEgg.Service.Models;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var countryService = new CountryService();


            // Önmer Açıklama yazı

            //var country = new CountryViewModel
            //    {
            //        Name = "Argantine",
            //        CreatedDate = DateTime.Now,
            //        LastModifiedDate = DateTime.Now,
            //        Status = 1
            //    };

            //countryService.Add(country);

            var query = countryService.List();

            foreach (var item in query)
            {
                Console.WriteLine(item.Name);
                foreach (var item2 in item.Cities)
                {
                    Console.WriteLine("- " + item2.Name);
                }
            }
            Console.ReadKey();
        }
    }
}
