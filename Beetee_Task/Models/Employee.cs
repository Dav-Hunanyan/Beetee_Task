using System;
using System.ComponentModel.DataAnnotations;

namespace Beetee_Task.Models
{
    public class Employee
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string FirstName { get; set; }
        [StringLength(20, MinimumLength = 3)]

        public string LastName { get; set; }        

        public int ID { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
    }
}
