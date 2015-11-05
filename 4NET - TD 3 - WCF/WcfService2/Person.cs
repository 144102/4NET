using System.Runtime.Serialization;

namespace WcfService2
{
    [DataContract]
    public class Person
    {
        private string firstName;

        [DataMember]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        [DataMember]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private int age;

        [DataMember]
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
    }
}