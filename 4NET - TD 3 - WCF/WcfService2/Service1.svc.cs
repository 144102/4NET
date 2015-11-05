using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public static List<Person> Persons = new List<Person>();


        void IService1.CreatePerson(Person person)
        {
            if (person != null)
            {
                Persons.Add(person);
            }
        }

        Person IService1.GetPerson()
        {
            return Persons.FirstOrDefault();
        }

        List<Person> IService1.GetPersons()
        {
            return Persons;
        }
    }
}
