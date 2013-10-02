using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventRegistration.Models.Domain.Repository
{
    public class EFRepository : IRepository
    {
        private EFAdapter adapter = new EFAdapter("EFRepository");

        public IQueryable<Competition> Competitions
        {
            get
            {
                return adapter.Competitions;
            }
        }
        public IQueryable<Registration> Registrations
        {
            get
            {
                return adapter.Registrations;
            }
        }
        public void SaveRegistration(Registration reg)
        {
            if (reg.ID == 0)
            {
                adapter.Registrations.Add(reg);
                adapter.Entry(reg).Reference("Competition").Load();
            }
            adapter.SaveChanges();
        }
        public void SaveCompetition(Competition comp)
        {
            if (comp.ID == 0)
            {
                adapter.Competitions.Add(comp);
                adapter.Entry(comp).Collection("Registrations").Load();
            }
            adapter.SaveChanges();
        }
    }
}