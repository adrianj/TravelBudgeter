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
    public partial class EditPlanDialog : Form
    {

        public EditPlanDialog()
        {
            InitializeComponent();
            currencyCombo.Items.AddRange(CurrencyData.GetCurrencyList());
        }

        public static DialogResult ShowDialog(PlanNode nodeToEdit)
        {
            EditPlanDialog dlg = new EditPlanDialog();
            dlg.UpdateFormFromNode(nodeToEdit);
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
                dlg.UpdateNodeFromForm(nodeToEdit);
            return result;
        }

        private void UpdateFormFromNode(PlanNode nodeToEdit)
        {
            this.nameBox.Text = nodeToEdit.Text;
            if (currencyCombo.Items.Contains(nodeToEdit.Currency))
                currencyCombo.SelectedItem = nodeToEdit.Currency;
            else
                currencyCombo.SelectedItem = CurrencyData.DefaultCurrency;
            descriptionBox.Text = nodeToEdit.ToolTipText;
            decimal cost = nodeToEdit.LocalCostInCents;
            localCostBox.Value = cost / 100;
        }

        private void UpdateNodeFromForm(PlanNode nodeToEdit)
        {
            nodeToEdit.Text = this.nameBox.Text;
            nodeToEdit.Currency = (string)currencyCombo.SelectedItem;
            nodeToEdit.ToolTipText = descriptionBox.Text;
            nodeToEdit.LocalCostInCents = (int)(localCostBox.Value * 100);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

    }
}
