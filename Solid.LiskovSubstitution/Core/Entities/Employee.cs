using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskovSubstitution.Core.Entities
{
    internal class Employee : Person
    {
        public string Email { get; set; }
        public bool IsDismissed { get; private set; }
        public void Dismiss()
        {
            IsDismissed = true;
        }
    }
}
