using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1.Models
{
    [Serializable]
    public class Person
    {
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string Birthday { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public long Phone { get; set; }

    }
}
