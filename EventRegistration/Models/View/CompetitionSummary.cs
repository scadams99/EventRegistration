using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EventRegistration.Models.View
{
    public enum StartTime
    {
        Morning,
        Midday,
        Evening
    }

    public class CompetitionSummary
    {
        [DisplayName("Event Name")]
        public string Name { get; set; }
        
        [DisplayName("Location")]
        [UIHint("City")]
        public string City { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [HiddenInput(DisplayValue = true)]
        public bool Approved { get; set; }

        public StartTime Start { get; set; }
    }
}