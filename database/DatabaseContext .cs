using stock_management.database.modles;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_management.database
{
    public class DatabaseContext : DbContext
    {

        private static string dbPath = Path.Join(Directory.GetCurrentDirectory(), "database.sqlite");

        public DatabaseContext() :
           base(new SQLiteConnection()
           {
               ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = dbPath, ForeignKeys = false }.ConnectionString
           }, true)
        {
            Console.WriteLine(dbPath);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Sell> Sells { get; set; }
    }
}
