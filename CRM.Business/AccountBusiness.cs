
using CRM.DataAccess;
using CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Business
{
    public class AccountBusiness
    {
        private Repository<Account> repository = new Repository<Account>();

        public IList<Account> GetAll()
        {
            return repository.GetAll().OrderByDescending(a=>a.CreateDate).ToList();
        }

        public Account Get(int id)
        {
            return repository.Get(id);
        }

        public bool Create(Account Account)
        {
            repository.Create(Account);
            return repository.Save() > 0;
        }

        public bool Update(Account Account)
        {
            repository.Update(Account);
            return repository.Save() > 0;
        }

        public void Delete(int id)
        {
            //set soft delete
        }
    }
}
