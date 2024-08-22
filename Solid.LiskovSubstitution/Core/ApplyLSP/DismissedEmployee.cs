using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskovSubstitution.Core.ApplyLSP
{
    internal class DismissedEmployee : Employee
    {
        public bool IsDismissed { get; private set; }
        public void Dismiss()
        {
            IsDismissed = true;
        }
    }
}
