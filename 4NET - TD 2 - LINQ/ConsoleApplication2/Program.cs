using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {


        static void Main(string[] args)
        {
            var studentCatalog = new StudentCatalog
            {
                catalog = new List<Student>()
                {
                    new Student {BoosterId=123456, FirstName="Jean",LastName="Jean" },
                    new Student {BoosterId=654321, FirstName="Pierre", LastName="Curie" },
                    new Student {BoosterId=123571, FirstName="Marie", LastName="Madeleine" },
                    new Student {BoosterId=175321, FirstName="Marco", LastName="Polo" },
                    new Student {BoosterId=123571, FirstName="Albert", LastName="Einstein" }
                }
            };


            //var result = studentCatalog.GetFullName(654321);
            //var result = studentCatalog.GetLastThree();
            var result = studentCatalog.Search("stein");

            Console.ReadLine();
        }






    }
}
