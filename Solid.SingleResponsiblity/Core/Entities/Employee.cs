using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsiblity.Core.Entities
{
    internal class Employee : Person
    {
        public decimal BasicSalary { get; set; }
        public int TaxPersentage { get; set; }
    }
}
