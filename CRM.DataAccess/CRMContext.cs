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


        public DbSet<Role> Role { get; set; }

        public DbSet<User> User { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Interesting> Interesting { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<User_Interesting> User_Interesting { get; set; }
        public DbSet<EducationLevel> Education_Level { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<User_Education> User_Education { get; set; }

       
            }

    public class CRMInitializer : DropCreateDatabaseIfModelChanges<CRMContext>
    {
        protected override void Seed(CRMContext context)
        {
            IList<Role> role = new List<Role>();
            role.Add(new Role { Name = "User" });
            role.Add(new Role { Name = "Admin" });

            foreach (var r in role)
            {
                context.Role.Add(r);
            }

            IList<Interesting> inter = new List<Interesting>();
            inter.Add(new Interesting{Name="Sport",ImagieInter="sport.jpg" });
            inter.Add(new Interesting { Name = "Movie", ImagieInter = "movie.jpg" });
            foreach(var i in inter)
            {
                context.Interesting.Add(i);
            }
            IList<Province> pro = new List<Province>();
            pro.Add(new Province { Name = "Ha Noi" });
            pro.Add(new Province { Name = "TP.Ho Chi Minh" });
            pro.Add(new Province { Name = "Da Nang" });
            pro.Add(new Province { Name = "Hai Phong" });
            foreach (var p in pro)
            {
                context.Province.Add(p);
            }
            IList<EducationLevel> edulevel = new List<EducationLevel>();
            edulevel.Add(new EducationLevel { Name = "University", Description = "an institution of higher education and research which grants academic degrees in a variety of subjects and provides both undergraduate education and postgraduate education" });
            edulevel.Add(new EducationLevel { Name = "College", Description = "an educational institution or a constituent part of one. Usage of the word college varies in English-speaking nations" });
            edulevel.Add(new EducationLevel { Name = "Hight School", Description = "a school that provides children with part or all of their secondary education. It may come after primary school or middle school and be followed by higher education or vocational training" });
            edulevel.Add(new EducationLevel { Name = "Secondary School", Description = "a school which provides children with part or all of their secondary education, typically between the ages of 11-14" });
            foreach(var s in edulevel)
            {
                context.Education_Level.Add(s);
            }

          

            base.Seed(context);
        }
    }
}
