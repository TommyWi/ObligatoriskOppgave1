using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slektstre4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Velkommen til BlåttBlod, Slektstre over de kongelige");
                Console.WriteLine("Skriv 'Hjelp' for mer informasjon");
                Person[] persons;

                var olav = new Person (8){ FirstName = "Olav", BirthYear = 1903 };
                var sonja = new Person (7){FirstName = "Sonja", BirthYear = 1937 };
                var harald = new Person (6){FirstName = "Harald", BirthYear = 1937 };
                var marius = new Person (5){FirstName = "Marius", LastName = "Borg Høiby", BirthYear = 1997 };
                var metteMarit = new Person(4) {FirstName = "Mette-Marit", BirthYear = 1973 };
                var haakon = new Person (3){ FirstName = "Haakon Magnus", BirthYear = 1973 };
                var ingridAlexandra = new Person(2) { FirstName = "Ingrid Alexandra", BirthYear = 2004 };
                var sverreMagnus = new Person (1){ FirstName = "Sverre Magnus", BirthYear = 2005 };
                
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
                if (line.Contains("Liste"))
                {
                    Person.list(persons);
                }
                else if (line.Contains("Vis"))
                {
                    Person.Show(persons, GetInt());
                }
                else if (line.Contains("Hjelp"))
                {
                    HelpText();
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
            Console.WriteLine("Her er en liste og forklaring på de forskjellige kommandoene:");
            Console.WriteLine("Liste: Viser en liste over alle personer, deres id og navn på kjente foreldre");
            Console.WriteLine("Vis + Id: Viser en enkelt person og deres foreldre om de finnes");
        }
    }
}
