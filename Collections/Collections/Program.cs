using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList_Method();

            //Listilecalismak();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("book","kitap");
            dictionary.Add("flower", "çiçek");
            dictionary.Add("computer", "bilgisayar");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key+"= "+item.Value);
            }
            
        }

        private static void Listilecalismak()
        {
            List<string> cities = new List<string>();

            //List<Customer> customers = new List<Customer>();
            // customers.Add(new Customer { Id=1,FirstName="Olcay"});
            //customers.Add(new Customer { Id = 2, FirstName = "Keko" });

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id=1,FirstName="Olcay" },
                new Customer { Id = 2, FirstName = "Keko" }
            };


            foreach (var item in customers)
            {
                Console.WriteLine(item.FirstName);
            }
        }

        private static void ArrayList_Method()
        {
            //string[] cities = new string[2] { "Ankara","İzmir"};
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("İzmir");
            foreach (var item in cities)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }


    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

    }
}
