using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskovSubstitution.Core.ApplyLSP
{
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateOnly BirthDate { get; private set; }

        public void SetName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Invalid name.");

            FirstName = firstName;
            LastName = lastName;
        }

        public void SetBirthDate(DateOnly birthDate)
        {
            if (birthDate < new DateOnly(1990, 01, 01))
                throw new ArgumentException("Invalid date.");
            BirthDate = birthDate;
        }
    }
}
