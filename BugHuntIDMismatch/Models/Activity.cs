using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugHuntIDMismatch.Models
{
    public class Activity
    {
        public long ID { get; set; }
        public long ReportID { get; set; }
        public string Description { get; set; }
        public DateTime TargetDate { get; set; }
    }
}