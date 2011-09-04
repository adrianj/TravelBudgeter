namespace TravelBudgeter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.travelTree = new System.Windows.Forms.TreeView();
            this.travelTreeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.totalCostLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalAssetsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.balanceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu.SuspendLayout();
            this.travelTreeMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(457, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // travelTree
            // 
            this.travelTree.AllowDrop = true;
            this.travelTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.travelTree.CheckBoxes = true;
            this.travelTree.ContextMenuStrip = this.travelTreeMenu;
            this.travelTree.Location = new System.Drawing.Point(0, 27);
            this.travelTree.Name = "travelTree";
            this.travelTree.ShowNodeToolTips = true;
            this.travelTree.Size = new System.Drawing.Size(457, 205);
            this.travelTree.TabIndex = 1;
            this.travelTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.travelTree_AfterCheck);
            this.travelTree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.travelTree_ItemDrag);
            this.travelTree.DoubleClick += new System.EventHandler(this.travelTree_DoubleClick);
            // 
            // travelTreeMenu
            // 
            this.travelTreeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewItemToolStripMenuItem});
            this.travelTreeMenu.Name = "travelTreeMenu";
            this.travelTreeMenu.Size = new System.Drawing.Size(140, 26);
            // 
            // addNewItemToolStripMenuItem
            // 
            this.addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            this.addNewItemToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.addNewItemToolStripMenuItem.Text = "Add new item";
            this.addNewItemToolStripMenuItem.Click += new System.EventHandler(this.addNewItemToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalCostLabel,
            this.totalAssetsLabel,
            this.balanceLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 234);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(457, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(60, 17);
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // totalAssetsLabel
            // 
            this.totalAssetsLabel.Name = "totalAssetsLabel";
            this.totalAssetsLabel.Size = new System.Drawing.Size(109, 17);
            this.totalAssetsLabel.Text = "toolStripStatusLabel1";
            // 
            // balanceLabel
            // 
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(109, 17);
            this.balanceLabel.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 256);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.travelTree);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Travel Budgeter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.travelTreeMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.TreeView travelTree;
        private System.Windows.Forms.ContextMenuStrip travelTreeMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel totalCostLabel;
        private System.Windows.Forms.ToolStripStatusLabel totalAssetsLabel;
        private System.Windows.Forms.ToolStripStatusLabel balanceLabel;
    }
}

