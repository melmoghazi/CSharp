using Solid.InterfaceSegregation.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregation.Core.ApplyISP.Repositories
{
    internal interface IRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> FindAll();
        T GetById(int id);
    }
}
