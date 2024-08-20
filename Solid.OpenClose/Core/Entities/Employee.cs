using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClose.Core.Entities
{
    internal abstract class Employee : Person
    {
        public string Email { get; set; }

        /*
         * Open Close Principal
         * The software entities (modules, classes, functions etc.) should be open for extension but closed for modification.
         * => follwing method should be moved to anther class.
         */
        //public abstract decimal GetSalary();
       
    }
}
