using Solid.InterfaceSegregation.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregation.Core.ApplyISP.Repositories
{
    internal interface IUpdateRepository<T> where T : Entity
    {
        public void Update(T entity);
    }
}
