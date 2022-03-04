using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProfileImageDTO
    {
        public int Id { get; set; }

        public int ProfileId { get; set; }

        public string ProfileImageUrl { get; set; }
    }
}
