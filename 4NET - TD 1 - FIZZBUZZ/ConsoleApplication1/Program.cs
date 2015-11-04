using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //On initialise la suite de nombre 
            var numbers = new InputList(new List<int>());
            numbers.MemberAdded += numbers_memberadded;
            PopulateList(numbers, 1, 20);
            


            Console.ReadLine();
        }


        private static void numbers_memberadded(object sender, InputList.MemberAddedEventArgs e)
        {
            var output = "";
            if (e.MemberAdd % 3 == 0)
            {
                output += "fizz";
            }
            if (e.MemberAdd % 5 == 0)
            {
                output += "buzz";
            }
            if (string.IsNullOrEmpty(output))
            {
                output += e.MemberAdd;
            }
            Console.WriteLine(output);
        }



        public static void PopulateList(InputList inputList, int min, int max)
        {
            for (var i = min; i <= max; i++)
            {
                inputList.Add(i);
            }
        }
    }
  



}
