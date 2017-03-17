using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; }

      //  [Min18YearsIfAMember] this breaks if included , because there are now 2 methods for creating a customer, the api and the form.
      //The form should be modified to use the api and a new custom validation method
        public DateTime? Birthdate { get; set; }
    }
}