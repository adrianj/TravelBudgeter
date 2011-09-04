using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TravelBudgeter
{
    public class PlanNode : TreeNode
    {
        public int LocalCostInCents { get; set; }

        private string currency = CurrencyData.DefaultCurrency;
        public string Currency { get { return currency; } set { currency = value; } }

        public PlanNode()
        {
            this.Text = "Unnamed Plan";
        }

        public int GetFinalCostInCents()
        {
            int total = 0;
            if (this.Checked)
            {
                double rate = CurrencyData.GetExchangeRate(currency) / CurrencyData.GetDefaultRate();
                double cost = (double)LocalCostInCents / rate;
                Console.WriteLine("Node: " + this + " rate = " + rate + ", cost: " + (int)cost);

                total += (int)cost;
            }

            foreach (PlanNode node in this.Nodes)
                total += node.GetFinalCostInCents();

            return total;
        }

    }


}
