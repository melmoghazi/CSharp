using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Class
{
    /// <summary>
    /// A constructor is a method that is called when an instance of a class is created.
    /// We use constructors to put an object in an early state. 
    /// Constructor Overloading
    /// </summary>
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id):this()
        {
            this.Id = id;
        }
        public Customer(int id, string name):this(id)
        {
            this.Name = name;
        }
    }
}
