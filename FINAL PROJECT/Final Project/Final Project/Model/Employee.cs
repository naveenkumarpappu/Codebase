using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Please Enter First Name" )]
        public string FirstName { get; set;}
        public String LastName { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
    }
}
