using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubReportDashboard.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PIN { get; set; }
        public int Preference { get; set; }
        public Boolean IsAdmin { get; set; }
        public Boolean IsPastUser { get; set; }
    }
}
