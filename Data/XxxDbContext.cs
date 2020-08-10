using Microsoft.EntityFrameworkCore;
using ODataDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataDemo.Data
{
    public class XxxDbContext : DbContext
    {
        public XxxDbContext(DbContextOptions<XxxDbContext> options)
            : base(options)
        {
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<PatientForms> PatientForms { get; set; }

        public DbSet<File> Files { get; set; }
        public DbSet<FileStatus> FileStatus { get; set; }
        public DbSet<FileFileStatus> FileFileStatus { get; set; }
    }
}
