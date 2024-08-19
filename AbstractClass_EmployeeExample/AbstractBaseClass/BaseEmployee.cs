using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AbstractClass_EmployeeExample.AbstractBaseClass
{
    public abstract class BaseEmployee
    {
        //this constructor will be called before the derived class constructor.
        protected BaseEmployee()
        {
            // Execute code that is relevant for every child class. This prevents the duplicate code.
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract int GetMonthlySalary();

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

    }
}
