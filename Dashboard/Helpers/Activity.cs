﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dashboard.Controllers;
using Dashboard.Data;
using Dashboard.Models;

namespace Dashboard.Helpers
{
    public class Activity
    {
        public static int GetLastPage()
        {
            var recordsPerPage = ActivityController.recordsPerPage;
            var count = ActivityController.count;

            var LastPage = (decimal) count / recordsPerPage;
            var LastPageRounded = Math.Ceiling(LastPage);

            return (int) LastPageRounded;
        }

        public static int GetCurrentPage()
        {
            return ActivityController.s_Page + 1;
        }

        public static void AddNew(ActivityModel model)
        {
            using (var db = new ActivityContext())
            {
                db.ActivityRecords.Add(model);
                db.SaveChanges();
            }
        }
    }
}
