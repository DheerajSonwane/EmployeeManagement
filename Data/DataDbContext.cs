using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSalary> EmployeeSalaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeSalary>()
                .Property(e => e.Amount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<EmployeeSalary>()
           .Property(e => e.Id)
           .ValueGeneratedOnAdd();

            modelBuilder.Entity<EmployeeSalary>()
                .HasOne(es => es.Employee)
                .WithMany(e => e.Salaries)
                .HasForeignKey(es => es.EmployeeId);
        }
    }
}
