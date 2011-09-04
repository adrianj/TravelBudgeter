using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TravelBudgeter
{
    public partial class MainForm : Form
    {
        private HolidayNode holidayNode = HolidayNode.CreateFramework();
        private AssetsNode assetsNode = AssetsNode.CreateFramework();

        public int TotalCostInCents { get { return holidayNode.GetFinalCostInCents(); } }
        public int TotalAssetsInCents { get { return assetsNode.GetFinalCostInCents(); } }


        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanNode newNode = new PlanNode();
            AddPlanNodeToTree(travelTree.SelectedNode,newNode,true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddPlanNodeToTree(null, holidayNode, false);
            AddPlanNodeToTree(null, assetsNode, false);
        }

        private void AddPlanNodeToTree(TreeNode parentNode, PlanNode node, bool editFirst)
        {
            if (editFirst)
            {
                DialogResult result = EditNode(node);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    AddNode(parentNode, node);
                }
            }
            else
            {
                PopulateNode(node);
                AddNode(parentNode, node);
            }
        }
        private void AddNode(TreeNode parent, TreeNode node)
        {
            if (parent == null)
                travelTree.Nodes.Add(node);
            else
                parent.Nodes.Add(node);
            DisplayTotalCost();
        }

        private void travelTree_DoubleClick(object sender, EventArgs e)
        {
            EditNode(travelTree.SelectedNode as PlanNode);
        }

        private DialogResult EditNode(PlanNode nodeToEdit)
        {
            DialogResult result = EditPlanDialog.ShowDialog(nodeToEdit);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                PopulateNode(nodeToEdit);
                DisplayTotalCost();
            }
            return result;
        }

        private void PopulateNode(PlanNode data)
        {

        }


        private void DisplayTotalCost()
        {
            double cost = Math.Round((double)TotalCostInCents/100,2,MidpointRounding.AwayFromZero);
            double assets = Math.Round((double)TotalAssetsInCents / 100, 2, MidpointRounding.AwayFromZero);
            double balance = assets - cost;
            totalCostLabel.Text = "Total Cost: " + cost.ToString("F2");
            totalAssetsLabel.Text = "Total Assets: " + assets.ToString("F2");
            balanceLabel.Text = "Balance: " + balance.ToString("F2");
        }


        private void travelTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            DisplayTotalCost();
        }

        #region Drag Drop Behaviour
        private void travelTree_ItemDrag(object sender, ItemDragEventArgs e)
        {

        }
        #endregion

    }
}
