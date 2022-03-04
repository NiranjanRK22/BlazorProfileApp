using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileApp.Model
{
    public class ProfileDetails
    {
        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }

        [Range(18, 60, ErrorMessage = "Only 18 to 60 years are allowed")]
        public int Age { get; set; }
    }
}
