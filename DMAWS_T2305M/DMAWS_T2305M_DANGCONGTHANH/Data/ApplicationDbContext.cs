using DMAWS_T2305M_DANGCONGTHANH.Models;
using Microsoft.EntityFrameworkCore;
namespace DMAWS_T2305M_DANGCONGTHANH.Data;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Project> Projects { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<ProjectEmployee> ProjectEmployees { get; set; }
}