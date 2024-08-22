using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskovSubstitution.Core.ApplyLSP
{
    internal class SalariedEmployee : DismissedEmployee
    {
        public decimal BasicSalary { get; set; }
        public decimal Transportation { get; set; }
        public decimal Housing
        {
            get; set;
        }
    }
}
