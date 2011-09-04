using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelBudgeter
{
    public class AssetsNode : PlanNode
    {
        public static AssetsNode CreateFramework()
        {
            AssetsNode assets = new AssetsNode();
            assets.Text = "Cash Assets";
            return assets;
        }
    }
}
