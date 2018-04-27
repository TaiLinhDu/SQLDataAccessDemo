using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Person
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string EmailAdress { get; set; }
        public string  PhoneNumber{ get; set; }

        public string FullInfo
        {
            get
            {
                //"Tai LInh Du (linh9a0910@gmail.com)"
                return $"{FirstName} {LastName} ({EmailAdress})";
            }
        }



    }




}
