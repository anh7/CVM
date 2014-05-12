using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Common
{
    public interface IRepository<T>
    {
        IList<T> GetAll();
        T Get(int id);
        void Create(T t);
        void Update(T t);
        int Save();
    }
}
