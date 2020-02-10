using System;
using System.Collections.Generic;

namespace GenericCollectionsProject {
    class Program {
        static void Main(string[] args) {

            var ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            Console.WriteLine($"Number of ints is {ints.Count}");
            foreach(var anInt in ints) {
                Console.Write($" {anInt} ");
            }
            ints.Remove(2);
            Console.WriteLine($"Number of ints is {ints.Count}");
            foreach (var anInt in ints) {
                Console.Write($" {anInt} ");
            }
            //a generic collection of names
            var name = new List<string>();
            name.Add("Robbie");
            name.Add("Armon");
            name.Add("Traci");
            name.Add("Danae");
            name.Add("Manish");
            name.Add("Vaughn");
            name.Add("David");
            name.Add("Sarah");
            name.Add("Laura");
            name.Add("Ian");
            name.Add("Parker");
            name.Add("George");
            name.Add("Greg");
                Console.WriteLine($" Number of names is {name.Count}");
            foreach(var nm in name) {
                Console.Write($" {nm} ");

                //generic array of strings
                var customers = new List<Customer>();
                var amazon = new Customer(1, "Amazon", true);
                var pg = new Customer(2, "P&G", true);
                var meijer = new Customer { Id = 3, Name = "Meijer", Active = true };
                var target = new Customer { Id = 4, Name = "Target" };
                var microsoft = new Customer { Id = 5, Name = "Microsoft", Active = false };

                customers.Add(amazon);
                customers.Add(pg);
                var custArray = new Customer[] { meijer, target, microsoft };
                customers.AddRange(custArray);

                Console.WriteLine();
            foreach(var customer in customers) {
                    if (customer.Active == false) {
                        continue;
                    }
                    Console.Write($" {customer.Id}, {customer.Name}, {customer.Active}");



                    Console.WriteLine();
                
                foreach(var Customer in customers) {
                        if (customer.Id == 3) {
                            
                            Console.WriteLine($" {customer.Name}");
                        }
                    }

                }

                var custDictionary = new Dictionary<int, Customer>();
                custDictionary.Add(amazon.Id, amazon);
                custDictionary.Add(target.Id, target);
                custDictionary.Add(meijer.Id, meijer);
                custDictionary.Add(pg.Id, pg);
                custDictionary.Add(microsoft.Id, microsoft);

                var cust2 = custDictionary[3];
                Console.WriteLine($"Customer id 3 is {cust2.Name}");
                //don't need to declare new var - just use the one from above
                cust2 = custDictionary[2];
                Console.WriteLine($"Customer id 2 is {cust2.Name}");
                //OR
                Console.WriteLine($"Customer id 2 is {custDictionary[2].Name}");


                //using cust.Dictionary.Keys
                foreach(var key in custDictionary.Keys) {
                    var customer = custDictionary[key];

                    Console.WriteLine($"{customer.Name}");
                }





            }


            }
        }
}
