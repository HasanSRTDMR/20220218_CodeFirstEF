using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using _20220218_CodeFirstEF.DAL.ORM.Entities;

namespace _20220218_CodeFirstEF.DAL.ORM.Context
{
    /*

        1) NuGet Package Manager ile Entity Framework projeye eklenir.
        2) ORM klasörü altında -> Context ve Entity klasörleri oluşturur.
        3) Entity klasörü altında tablo olacak olan calss'lar yazılır.
        4) Context klasörü altına "ProjectConext" gibi bir isim verilerek context class'ı açılır.
        5) Context class'ı DbContext'ten (System.Data.Entity) miras alır.
        6) Tablo olmasını istediğiniz class'lar "public DbSet<entity> Entities {get;set;} formatında yazılır.
        7) NuGet Console açılarak "enable-migration - EnableAutomaticMigration" yazılır (eğer class'da "false" kısmını "true" yapınız.)
        8) update-database denir.

     */
    public class ProjectContext : DbContext
    {
        //public ProjectContext():base("con")
        //{

        //}
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=ProjectContext;UID=sa;Pwd=Hasan123";
        }
        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        

    }
}
