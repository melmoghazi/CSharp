using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_EmployeeExample.ConcreteBaseClass
{
    public class BaseEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public virtual int GetMonthlySalary()
        {
            throw new NotImplementedException();
        }
    }
}
