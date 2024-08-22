using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskovSubstitution.Core.ApplyLSP
{
    internal class HourlyEmployee : DismissedEmployee
    {
        public decimal HourRate { get; set; }
        public int TotalMonthlyHours { get; set; }
    }
}
