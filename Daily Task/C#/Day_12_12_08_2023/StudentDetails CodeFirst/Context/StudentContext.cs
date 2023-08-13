using Microsoft.EntityFrameworkCore;
using StudentDetails.Models;

namespace StudentDetails.Context
{
    public class StudentContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
    }
}
