using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;
using CRM.Models;
using CRM.Model;


namespace CRM.DataAccess
{
    public class CRMContext : DbContext
    {
        public CRMContext()
            : base("CvManagement")
        {
            Database.SetInitializer<CRMContext>(new CRMInitializer());
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<CVInfo> CVInfoes { get; set; }
            }
        

    public class CRMInitializer : CreateDatabaseIfNotExists<CRMContext>
    {
        protected override void Seed(CRMContext context)
        {
            IList<Role> role = new List<Role>();
            role.Add(new Role { Name = "User" });
            role.Add(new Role { Name = "Admin" });

            foreach (var r in role)
            {
                context.Roles.Add(r);
            }
           

            base.Seed(context);
        }
    }
}
