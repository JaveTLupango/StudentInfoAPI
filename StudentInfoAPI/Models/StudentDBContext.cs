﻿using Microsoft.EntityFrameworkCore;

namespace StudentInfoAPI.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options)
        {
        }

        public DbSet<Student> students { get; set; }
    }
}