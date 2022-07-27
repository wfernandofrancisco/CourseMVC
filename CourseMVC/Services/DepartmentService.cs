using CourseMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMVC.Services
{
    public class DepartmentService
    {
        private readonly CourseMVCContext _context;

        public DepartmentService(CourseMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
