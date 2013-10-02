using System.Collections.Generic;
using System.Linq;

namespace EventRegistration.Models.Domain.Repository
{
    public interface IRepository
    {
        IQueryable<Competition> Competitions { get; }

        void SaveCompetition(Competition comp);

        IQueryable<Registration> Registrations { get; }

        void SaveRegistration(Registration reg);
    }
}