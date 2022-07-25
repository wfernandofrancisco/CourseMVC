using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CourseMVC.Models
{
    public class CourseMVCContext : DbContext
    {
        public CourseMVCContext (DbContextOptions<CourseMVCContext> options)
            : base(options)
        {
        }

        public DbSet<CourseMVC.Models.Department> Department { get; set; }
    }
}
