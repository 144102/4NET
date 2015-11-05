using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.ServiceReference1;
using System.ServiceModel;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            var service1Client = Init();
            if (IsWebServiceAvailable(service1Client))
            {
              
                var expectedInputs = new List<Char>() { '1', '2', '3' };
                do
                {
                    BuildMenu();
                    var input = Console.ReadKey().KeyChar;
                    Console.WriteLine("-- Searching for operation ...");
                    //On vérifie que l'entrée est correcte
                    if (!expectedInputs.Contains(input))
                    {
                        Console.WriteLine("-- Bad Input");
                        continue;
                    }
                    //On appelle la méthode
                    switch (input)
                    {
                        case '1':
                            InvokeCreatePerson(service1Client);
                            break;
                        case '2':
                            InvokeGetPersons(service1Client);
                            break;
                        case '3':
                            InvokeGetPerson(service1Client);
                            break;
                        default:
                            break;
                    }
                } while (true);

            }
        }

        private static void BuildMenu()
        {
            Console.WriteLine("-- Choose an operation to invoke :");
            Console.WriteLine(" 1 - CreatePerson");
            Console.WriteLine(" 2 - GetPersons");
            Console.WriteLine(" 3 - GetPerson");
        }

       

        private static void InvokeGetPersons(Service1Client client)
        {
            var persons = client.GetPersons();
            foreach (var person in persons)
            {
                Console.WriteLine(string.Format("{0} {1}, age: {2}", person.FirstName, person.LastName, person.Age));
            } 
        }

        private static void InvokeGetPerson(Service1Client client)
        {
            var person = client.GetPerson();
            Console.WriteLine(string.Format("{0} {1}, age: {2}", person.FirstName, person.LastName, person.Age));
        }

        private static void InvokeCreatePerson(Service1Client client)
        {
            client.CreatePerson(new Person { FirstName = "Pierre", LastName = "Jean", Age = 44 });
            Console.WriteLine("person added");
        }

        private static Service1Client Init()
        {
            Console.WriteLine("Starting Service1Client ...");
            return new Service1Client();

        }

        private static Boolean IsWebServiceAvailable(Service1Client wsc)
        {
            if (wsc.InnerChannel.State == CommunicationState.Faulted)
            {
                Console.WriteLine(string.Format("Unable to connect to Service1: {0}, please start the WebService and restart the Console Application.", wsc.Endpoint.Address));
                return false;
            }
            else
            {
                Console.WriteLine(string.Format("Succesfully connected to Service1 : {0}",wsc.Endpoint.Address));
                return true;
            }
        }



    }
}

