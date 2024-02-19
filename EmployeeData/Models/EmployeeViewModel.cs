using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeData.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName(" Last Name")]
        public string LastName { get; set; }

        [DisplayName(" Date Of Birth")]

        public DateTime DateOfBirth { get; set; }

        [DisplayName(" E-mail")]
        public string Email { get; set; }

        [DisplayName(" Salary")]
        public double Salary { get; set; }

        [DisplayName(" Name")]

        public string FullName
        {
            get { return FirstName + " " + LastName; }   
        }


    }
}
