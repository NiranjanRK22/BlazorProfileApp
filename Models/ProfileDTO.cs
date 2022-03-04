using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProfileDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Range(18, 60, ErrorMessage = "Only 18 to 60 years are allowed")]
        public int Age { get; set; }

        public virtual ICollection<ProfileImageDTO> ProfileImages { get; set; }

        public List<string> ImageUrls { get; set; }
    }
}
