using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Transactions;
namespace GrouponJobsMVC.Models
{
    //public class JobsContext : DbContext
    //{
    //    public DbSet<City> City { get; set; }
    //    public DbSet<Address> Address { get; set; }
    //    public DbSet<Recruiter> Recruiter { get; set; }
    //    public DbSet<Category> Category { get; set; }
    //    public DbSet<Requisition> Requisition { get; set; }
    //    public DbSet<Disposition> Disposition { get; set; }
    //    public DbSet<MaritalStatus> MaritalStatus { get; set; }
    //    public DbSet<Rating> Rating { get; set; }
    //    public DbSet<Candidate> Candidate { get; set; }
    //    public DbSet<Company> Comapny { get; set; }
    //    public DbSet<Courses> Courses { get; set; }
    //    public DbSet<Language> Language { get; set; }
    //}

    //public class DropCreateDatabaseTables : IDatabaseInitializer<JobsContext>
    //{

    //    public void InitializeDatabase(JobsContext context)
    //    {
    //        bool dbExists;
    //        using (new TransactionScope(TransactionScopeOption.Suppress))
    //        {
    //            dbExists = context.Database.Exists();
    //        }
    //        if (dbExists)
    //        {
    //            // remove all tables
    //            context.Database.ExecuteSqlCommand(
    //               "EXEC sp_MSforeachtable @command1 = \"DROP TABLE ?\"");

    //            // create all tables
    //            var dbCreationScript = ((IObjectContextAdapter)
    //                   context).ObjectContext.CreateDatabaseScript();
    //            context.Database.ExecuteSqlCommand(dbCreationScript);

    //            Seed(context);
    //            context.SaveChanges();
    //        }
    //        else
    //        {
    //            throw new ApplicationException("No database instance");
    //        }
    //    }

    //    private void Seed(JobsContext context)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}