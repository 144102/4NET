using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class StudentCatalog
    {
        public List<Student> catalog;

        public String GetFullName(int BoosterId)
        {
            var user = catalog.FirstOrDefault(u => u.BoosterId == BoosterId);
            return string.Format("{0}{1}", user.LastName, user.FirstName);
        }
        public List<Student> GetLastThree()
        {
            catalog.Reverse();
            return catalog.Take(3).ToList();
        }
        public Student Search(string text)
        {
            return catalog.Where(s => s.FirstName.Contains(text)
                || s.LastName.Contains(text)).FirstOrDefault();

        }


    }
}
