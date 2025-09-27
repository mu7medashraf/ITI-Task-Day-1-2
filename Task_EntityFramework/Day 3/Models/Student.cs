using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_EF_day3.Models
{
    public class Student
    { 
        public int StudentId { get; set; }      
        public string FullName { get; set; } = null!;
        public int Age { get; set; }
        public string? Email { get; set; }
    }
}

