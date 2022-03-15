using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF_CRUD.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        [MaxLength(40, ErrorMessage="First Name must be less than 40 characters")]
        public string FirstName { get; set; } = null!;
        [MaxLength(40, ErrorMessage = "Last Name must be less than 40 characters")]
        public string LastName { get; set; } = null!;
        [MaxLength(40, ErrorMessage = "City Name must be less than 40 characters")]
        public string? City { get; set; }
        [MaxLength(40, ErrorMessage = "Country Name must be less than 40 characters")]
        public string? Country { get; set; }
        [MaxLength(20, ErrorMessage = "Phone Number must be less than 20 characters")]
        public string? Phone { get; set; }
    }
}
