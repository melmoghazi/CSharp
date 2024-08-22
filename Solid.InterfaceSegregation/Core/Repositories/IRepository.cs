using Solid.InterfaceSegregation.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregation.Core.Repositories
{
    internal interface IRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> FindAll();
        T GetById(int id);
        public void Update(T entity);
        public void Delete(T entity);
    }
}
