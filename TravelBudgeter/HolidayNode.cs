using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelBudgeter
{
    public class HolidayNode : PlanNode
    {
        public static HolidayNode CreateFramework()
        {
            HolidayNode holiday = new HolidayNode();
            holiday.Text = "Holiday";
            return holiday;
        }
    }
}
