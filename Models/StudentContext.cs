using Microsoft.EntityFrameworkCore;
using lab1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class StudentDbContext : IdentityDbContext<UserEntity, UserRole, int>
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Student { get; set; } = null!;
    }

