using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace contactManagement.Data
{
    public class ContactInfo
    {
        [Key]
        public Guid Id { get; set; }

        [Required (ErrorMessage = "Last name is required")]
        [StringLength(250, ErrorMessage ="Last name cannot be longer than 250 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(250, ErrorMessage = "First name cannot be longer than 250 characters")]
        public string FirstName { get; set; }
        [StringLength(15, ErrorMessage = "Phone number cannot be longer than 250 characters")]
        public string PhoneNumber { get; set; }
        
        public DateTime BirthDate { get; set; }
    }
}
