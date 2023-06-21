using Microsoft.EntityFrameworkCore;
using MHWWebAplication.EFModels;

namespace MHWWebAplication.DataContext
{
    public class CoreStudentsContext : DbContext
    {
        public CoreStudentsContext(DbContextOptions<CoreStudentsContext> options) : base(options) { }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }
}