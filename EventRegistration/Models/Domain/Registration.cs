using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventRegistration.Models.Domain
{
    public class Registration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HomeCity { get; set; }
        public int Age { get; set; }
        public int CompetitionID { get; set; }
        public virtual Competition Competition { get; set; } // this is like a foreign key to the Competition class.
    }
}