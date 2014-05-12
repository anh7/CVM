using CRM.DataAccess;
using CRM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Business
{
    public class UserBusiness
    {
        private Repository<User> repository = new Repository<User>();

        public IList<User> GetAll()
        {
            return repository.GetAll();
        }

        public User Get(int id)
        {
            return repository.Get(id);
        }

        public bool Create(User user)
        {
            repository.Create(user);
            return repository.Save() > 0;
        }

        public bool Update(User user)
        {
            repository.Update(user);
            return repository.Save() > 0;
        }

        public void Delete(int id)
        {
            //set soft delete
        }
    }
}
