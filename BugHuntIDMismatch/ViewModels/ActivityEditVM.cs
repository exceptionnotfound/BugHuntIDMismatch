using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BugHuntIDMismatch.ViewModels
{
    public class ActivityEditVM : BaseVM
    {
        
        public long ActivityID { get; set; }

        [DisplayName("Description: ")]
        public string Description { get; set; }

        [DisplayName("Target Date: ")]
        [DataType(DataType.Date)]
        public DateTime TargetDate { get; set; }
    }
}