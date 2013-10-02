using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EventRegistration.Models.Domain.Repository
{
    class EFAdapter : DbContext
    {
        public EFAdapter(string connectionName) : base(connectionName)
        {
            // do nothing
        }
        public DbSet<Competition> Competitions { get; set; }
        // this tells the EF that the registration table should represent the registration model class
        public DbSet<Registration> Registrations { get; set; }
    }
}