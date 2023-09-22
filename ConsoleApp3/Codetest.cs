using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Codetest
    {
        public static string Formatter(string firstName, string lastName)
        {
            string nameFirst = $"{firstName[0].ToString().ToUpper()}" +
                   $"{firstName.ToLower().Substring(1)}";

            string nameLast = $"{lastName[0].ToString().ToUpper()}" +
                     $"{lastName.ToLower().Substring(1)}";

            string nickName = "(" + lastName.ToUpper().Substring(0, 3) + firstName.ToUpper().Substring(0, 3) + ")";

            string newFormatter = "#_"+ nameLast + ", " + nameFirst + nickName;

            return newFormatter;
        }
    }
}
