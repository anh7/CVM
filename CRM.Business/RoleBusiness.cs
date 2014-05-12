using CRM.DataAccess;
using CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Business
{
    public class RoleBusiness 
    {
         public Repository<Role> repository = new Repository<Role>();
        public IList<Role> GetAll()
        {
            return repository.GetAll();
        }
        public Role GetId(int id)
        {
            return repository.Get(id);
        }
        public bool Create(Role Role)
        {
            repository.Create(Role);
            return repository.Save() > 0;
        }
        public bool Update(Role Role)
        {
            repository.Update(Role);
            return repository.Save() > 0;
        }

    }
}
