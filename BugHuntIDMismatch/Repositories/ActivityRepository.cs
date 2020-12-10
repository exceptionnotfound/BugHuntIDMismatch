using BugHuntIDMismatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugHuntIDMismatch.Repositories
{
    public class ActivityRepository
    {
        public List<Activity> GetForReport(long reportID)
        {
            if (reportID == 11)
            {
                return new List<Activity>()
                {
                    GetActivityOne(),
                    GetActivityTwo(),
                    GetActivityThree()
                };
            }

            else throw new Exception("Report ID was not a valid value!");
        }

        public Activity GetByID(long id)
        {
            switch(id)
            {
                case 1:
                    return GetActivityOne();
                case 2: 
                    return GetActivityTwo();
                case 3:
                    return GetActivityThree();

                default:
                    return GetActivityOne();
            }
        }

        private Activity GetActivityOne()
        {
            return new Activity()
            {
                ID = 1,
                ReportID = 11,
                Description = "Test Activity 1",
                TargetDate = DateTime.Now.AddDays(3)
            };
        }

        private Activity GetActivityTwo()
        {
            return new Activity()
            {
                ID = 2,
                ReportID = 11,
                Description = "Test Activity 2",
                TargetDate = DateTime.Now.AddDays(5)
            };
        }

        private Activity GetActivityThree()
        {
            return new Activity()
            {
                ID = 3,
                ReportID = 11,
                Description = "Test Activity 3",
                TargetDate = DateTime.Now.AddDays(7)
            };
        }
    }
}