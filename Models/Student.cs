using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class Student
    {
        public long Id { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Boolean Repeater { get; set; }
        [Range(1.0, 10.0)]
        public double Average { get; set; }
    }
}
