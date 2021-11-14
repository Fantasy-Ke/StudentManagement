using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.EFCore
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
