using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string JobTitle;

        public override string ToString()
        {

            {
                return LastName + ", " + FirstName;
            }

        }
    }
}
