using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1.Models
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }

    }
}
