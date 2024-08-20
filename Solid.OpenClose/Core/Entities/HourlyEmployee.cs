using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClose.Core.Entities
{
    internal abstract class HourlyEmployee : Employee
    {
        public decimal HourRate { get; set; }
        public int TotalMonthlyHours { get; set; }
    }
}
