using System;

namespace ClubReportDashboard.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public string Test { get; set; }

        public bool Done { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}