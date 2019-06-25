using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Slektstre5
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public Person Mother { get; set; }
        public Person Father { get; set; }



        public Person(int id)
        {
            Id = id;
        }

        public void Show()
        {
            Console.WriteLine(Id + " " + FirstName + " " + LastName + " " + BirthYear + " " + DeathYear);
        }


    }
}