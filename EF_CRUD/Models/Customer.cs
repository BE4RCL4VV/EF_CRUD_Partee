using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CRUD.Models
{
    public partial class Customer
    {
        [Key]
        public int Id { get; set; }
        [StringLength(40, ErrorMessage = "Max First Name size of 40 characters")]
        public string FirstName { get; set; } = null!;
        [StringLength(40, ErrorMessage = "Max Last Name size of 40 characters")]
        public string LastName { get; set; } = null!;
        [StringLength(40, ErrorMessage = "Max City Name size of 40 characters")]
        public string? City { get; set; }
        [StringLength(40, ErrorMessage = "Max Country Name size of 40 characters")]
        public string? Country { get; set; }
        [StringLength(20, ErrorMessage = "Max Phone Number size of 20 characters")]
        public string? Phone { get; set; }
    }
}
