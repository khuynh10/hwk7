﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hwk7
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new Initializer());

            //using (var context = new Context())
            //{
            //    var methodQuery = context.People;
            //    foreach (var person in methodQuery)
            //    {

            //        Console.WriteLine("id: {0}, Firstname: {1}, Lastname: {2}",
            //          person.PersonId, person.FirstName, person.LastName);
            //    }
            //    Thread.Sleep(5000);

            //}
            VerifyDatabaseExists();
           // InsertNewCompany();
          //  InsertPerson();
            // UpdateData();
             // DeleteData();
          //  QueryData();
         QueryCompanies();

        }

        private static void VerifyDatabaseExists()
        {
            using (var context = new Context())
            {
                context.Database.CreateIfNotExists();
            }
        }

        private static void InsertPerson()
        {
            using (var context = new Context())
            {
                var person = new Person
                {
                    FirstName = "Kevin",
                    LastName = "Doe"

                };

                context.People.Add(person);

                context.SaveChanges();
            }
        }

        private static void QueryData()
        {
            using (var context = new Context())
            {
                var savedPeople = context.People;
                foreach (var person in savedPeople)
                {
                    Console.WriteLine("id: {0}, Firstname: {1}, Lastname: {2}",
                      person.PersonId, person.FirstName, person.LastName);
                }
            }
            Console.ReadKey();
        }

        private static void QueryCompanies()
        {
            using (var context = new Context())
            {
                foreach (var company in context.Companies)
                {
                    Console.WriteLine("C.id: {0}, Company Name: {1}",
                        company.CompanyId, company.Name);
                }
            }
            Console.ReadKey();
        }
        private static void InsertNewCompany()
        {
            using (var context = new Context())
            {
                var company = new Company()
                {
                    Name = "CSULA",
                };

                context.Companies.Add(company);

                context.SaveChanges();
            }
        }

        private static void UpdateData()
        {
            using (var context = new Context())
            {
                var savedPeople = context.People;
                if (savedPeople.Any())
                {
                    var person = savedPeople.First();
                    person.FirstName = "Johnny";
                    person.LastName = "Benson";
                    context.SaveChanges();
                }
            }
            QueryData();
        }

        private static void DeleteData()
        {
            using (var context = new Context())
            {
                
                    var personId = 2;
                    var person = context.People.Find(personId);
                    if (person != null)
                    {
                        context.People.Remove(person);
                        context.SaveChanges();
                    }
                
            }
            QueryData();
        }
    }
}
