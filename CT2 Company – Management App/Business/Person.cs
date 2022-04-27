using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT2_Company___Management_App.Business
{
    public abstract class Person
    {
        Person() { }
        protected Person(string fullName)
        {
            FullName = fullName;
        }

        public string FullName { get; set; }
    }
}
