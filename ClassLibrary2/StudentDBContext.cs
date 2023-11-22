using Microsoft.EntityFrameworkCore;

namespace ClassLibrary2
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options)
        {

        } 


        public virtual DbSet<Student> Students { set; get; }
    }
}