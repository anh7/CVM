using CRM.Common;
using CRM.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DataAccess
{
    public class Repository<T> : IRepository<T>
       where T : class
    {
        private CRMContext cvcontext =new CRMContext();
        private DbSet<T> dbSet;
        public Repository() :
            this(new CRMContext())
        {
        }

        public Repository(CRMContext context)
        {
            this.cvcontext = context;
            this.dbSet = context.Set<T>();
        }

        public IList<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public void Create(T t)
        {
            dbSet.Add(t);
        }

        public void Update(T t)
        {
            cvcontext.Entry<T>(t).State = EntityState.Modified;
        }
        public int Save()
        {
            return cvcontext.SaveChanges();
        }
    }
}
