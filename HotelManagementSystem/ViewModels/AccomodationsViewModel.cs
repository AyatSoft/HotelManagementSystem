using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.ViewModels
{
    public class AccomodationsViewModel
    {
        public AccomodationType AccomodationType { get; set; }
        public IEnumerable<AccomodationPackage> AccomodationPackages { get; set; }
        public IEnumerable<Accomodation> Accomodations { get; set; }
        public int? SelectedAccomodationPackageId { get; set; }

    }

    public class CheckAccomdoationAvailabilityViewModel
    {
        public DateTime FromDate { get; set; }
        public int Duration { get; set; }
        public int NoOfAdults { get; set; }
        public int NoOfChildren { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }

    }
}