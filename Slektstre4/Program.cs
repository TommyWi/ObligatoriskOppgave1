using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Slektstre5
{

    class Program
    {
        private static Person[] persons;
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til Slektstreet");
            Console.WriteLine("Skriv Hjelp for mer informasjon");
            while (true)
            {
                var sverreMagnus = new Person(1) { FirstName = "Sverre Magnus", BirthYear = 2005 };
                var ingridAlexandra = new Person(2) { FirstName = "Ingrid Alexandra", BirthYear = 2004 };
                var haakon = new Person(3) { FirstName = "Haakon Magnus", BirthYear = 1973 };
                var metteMarit = new Person(4) { FirstName = "Mette-Marit", BirthYear = 1973 };
                var marius = new Person(5) { FirstName = "Marius", LastName = "Borg Høiby", BirthYear = 1997 };
                var harald = new Person(6) { FirstName = "Harald", BirthYear = 1937 };
                var sonja = new Person(7) { FirstName = "Sonja", BirthYear = 1937 };
                var olav = new Person(8) { FirstName = "Olav", BirthYear = 1903 };

                sverreMagnus.Father = haakon;
                sverreMagnus.Mother = metteMarit;
                ingridAlexandra.Father = haakon;
                ingridAlexandra.Mother = metteMarit;
                marius.Mother = metteMarit;
                haakon.Father = harald;
                haakon.Mother = sonja;
                harald.Father = olav;

                persons = new[]
                {
                    sverreMagnus,
                    ingridAlexandra,
                    haakon,
                    metteMarit,
                    marius,
                    harald,
                    sonja,
                    olav
                };
                var line = Console.ReadLine();
                if (line.Contains("Vis"))
                {
                    ShowPersonAndParentsAndChildren(GetInt());
                }
                else if (line.Contains("Liste"))
                {
                    ShowListOfAllPeople();
                }
                else if (line.Contains("Hjelp"))
                {
                    HelpText();
                }


            }



        }

        private static void ShowListOfAllPeople()
        {
            foreach (var person in persons)
            {
                if (person.Father != null && person.Mother != null)
                {
                    Console.WriteLine();
                    person.Show();
                    Console.WriteLine();
                    Console.WriteLine("Far:");
                    person.Father.Show();
                    Console.WriteLine("Mor: ");
                    person.Mother.Show();
                }

                else if (person.Father != null && person.Mother == null)
                {
                    Console.WriteLine();
                    person.Show();
                    Console.WriteLine();
                    Console.WriteLine("Far: ");
                    person.Father.Show();

                }
                else if (person.Father == null && person.Mother != null)
                {
                    Console.WriteLine();
                    person.Show();
                    Console.WriteLine();
                    Console.WriteLine("Mor: ");
                    person.Mother.Show();
                }
                else
                {
                    person.Show();
                }


            }
        }

        private static void ShowPersonAndParentsAndChildren(int num)
        {
            foreach (var person in persons)
            {
                if (num == person.Id)
                {
                    foreach (var p in persons)
                    {
                        if (p.Father == person || p.Mother == person)
                        {

                            Console.WriteLine("Barn : ");
                            p.Show();

                        }

                    }

                    if (person.Father != null && person.Mother != null)
                    {
                        Console.WriteLine();
                        person.Show();
                        Console.WriteLine();
                        Console.WriteLine("Far:");
                        person.Father.Show();
                        Console.WriteLine("Mor: ");
                        person.Mother.Show();
                    }

                    else if (person.Father != null && person.Mother == null)
                    {
                        Console.WriteLine();
                        person.Show();
                        Console.WriteLine();
                        Console.WriteLine("Far: ");
                        person.Father.Show();

                    }
                    else if (person.Father == null && person.Mother != null)
                    {
                        Console.WriteLine();
                        person.Show();
                        Console.WriteLine();
                        Console.WriteLine("Mor: ");
                        person.Mother.Show();
                    }
                    else
                    {
                        Console.WriteLine();
                        person.Show();
                    }





                }
            }
        }

        private static int GetInt()
        {
            var num = Convert.ToInt32(Console.ReadLine());

            return num;
        }

        private static void HelpText()
        {
            Console.WriteLine("Hjelp -viser denne teksten");
            Console.WriteLine("Vis - og tall du skriver inn viser en person og deres barn og foreldre med id slik at de lett kan søkes opp");
            Console.WriteLine("Liste - viser alle personer med mor og far og id på disse om de har dette");
        }
    }
}
