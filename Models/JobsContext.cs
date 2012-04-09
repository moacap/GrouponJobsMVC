using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace GrouponJobsMVC.Models
{
    public class JobsContext : DbContext
    {
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Recruiter> Recruiter { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Requisition> Requisition { get; set; }
        public DbSet<Disposition> Disposition { get; set; }
        public DbSet<MaritalStatus> MaritalStatus { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<Company> Comapny { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Disability> Disability { get; set; }
        public DbSet<Workflow> Workflow { get; set; }
        public DbSet<Resume> Resume { get; set; }
        public DbSet<Language> Language { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }



    }

}