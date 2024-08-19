using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAsynchronous
{
    internal class DemoChatGPTExtension
    {
        public string CheckPassenger(int age)
        {
            if (age > 2)
            {
                return "Adult";
            }
            else
            {
                return "Infant";
            }
        }

        public bool VoterEligibility(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
