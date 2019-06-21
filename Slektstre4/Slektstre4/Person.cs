using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;

namespace Slektstre4
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public Person Father { get; set; }
        public Person Mother { get; set; }

        public Person(int id)
        {
            Id = id;
        }
        

        public static void Show(Person[] persons, int num)
        {
            foreach (var person in persons)
            {
                if (person.Id == num)
                {
                    if (person.Father != null && person.Mother != null)
                    {
                        Console.WriteLine(person.Id + person.FirstName + person.LastName + person.BirthYear + person.DeathYear);
                        Console.WriteLine(person.Father.Id + person.Father.FirstName + person.Father.LastName + person.Father.BirthYear + person.Father.DeathYear);
                        Console.WriteLine(person.Mother.Id + person.Mother.FirstName + person.Mother.LastName + person.Mother.BirthYear + person.Mother.DeathYear);
                    }

                    else if (person.Father != null && person.Mother == null)
                    {
                        Console.WriteLine(person.Id + person.FirstName + person.LastName + person.BirthYear + person.DeathYear);
                        Console.WriteLine(person.Father.Id + person.Father.FirstName + person.Father.LastName + person.Father.BirthYear + person.Father.DeathYear);
                    }
                    else
                    {
                        Console.WriteLine(person.Id + person.FirstName + person.LastName + person.BirthYear + person.DeathYear);
                    }
                }
            }
        }

        public static void list(Person[] persons)
        {

            foreach (var person in persons)
            {
                
                if (person.Father != null && person.Mother != null)
                {
                    Console.WriteLine(person.Id + person.FirstName + person.LastName + person.BirthYear + person.DeathYear + person.Father.FirstName + person.Mother.FirstName);
                }
                else if (person.Father != null && person.Mother == null)
                {
                    Console.WriteLine(person.Id + person.FirstName + person.LastName + person.BirthYear + person.DeathYear + person.Father.FirstName);
                }
                else
                {
                    Console.WriteLine(person.Id + person.FirstName + person.LastName + person.BirthYear + person.DeathYear);
                }





            }
        }
    }

}
