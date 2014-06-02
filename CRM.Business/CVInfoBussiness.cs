using CRM.DataAccess;
using CRM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Business
{
    public class CVInfoBussiness
    {
        private Repository<CVInfo> repository = new Repository<CVInfo>();
        public IList<CVInfo> GetAll()
        {
            return repository.GetAll();
        }

        public CVInfo Get(int id)
        {
            return repository.Get(id);
        }

        public bool Create(CVInfo cvinfo)
        {
            repository.Create(cvinfo);
            return repository.Save() > 0;
        }

        public bool Update(CVInfo cvinfo)
        {
            repository.Update(cvinfo);
            return repository.Save() > 0;
        }

        public void Delete(int id)
        {
            //set soft delete
        }
    }
}
