namespace ClassLibrary1
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Student> Students { set; get; }
    }
}