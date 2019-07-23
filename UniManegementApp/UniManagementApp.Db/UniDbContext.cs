using System.Data.Entity;
using UniManagementApp.entities;

namespace UniManagementApp.Db
{
    public class UniDbContext :DbContext
    {
        public UniDbContext() : base("Uni_Management_Connection")
        {
        }

        public DbSet<ApplyFor> ApplyFors { get; set; }
        public DbSet<AdminScale> AdminScales { get; set; }
        public DbSet<Scale> Scales { get; set; }
        public DbSet<ScaleNo> ScaleNos { get; set; }

        public DbSet<Designation> Designations { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Domicile> Domiciles { get; set; }
        public DbSet<Status> Statuses { get; set; }

        public DbSet<Place> Places { get; set; }
    }
}
