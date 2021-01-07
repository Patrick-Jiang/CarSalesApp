namespace RRCAGApp
{
    partial class CarWashForm
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.generateInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lblFragrance = new System.Windows.Forms.Label();
            this.cboPackage = new System.Windows.Forms.ComboBox();
            this.cboFragrance = new System.Windows.Forms.ComboBox();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lstExterior = new System.Windows.Forms.ListBox();
            this.lstInterior = new System.Windows.Forms.ListBox();
            this.lblExterior = new System.Windows.Forms.Label();
            this.lblInterior = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDPsubtotal = new System.Windows.Forms.Label();
            this.lblPST = new System.Windows.Forms.Label();
            this.lblDPPST = new System.Windows.Forms.Label();
            this.lblGST = new System.Windows.Forms.Label();
            this.lblDPGST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDPTotal = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(756, 34);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateInvoiceToolStripMenuItem,
            this.toolStripSeparator1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(52, 28);
            this.mnuFile.Text = "&File";
            // 
            // generateInvoiceToolStripMenuItem
            // 
            this.generateInvoiceToolStripMenuItem.Enabled = false;
            this.generateInvoiceToolStripMenuItem.Name = "generateInvoiceToolStripMenuItem";
            this.generateInvoiceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.generateInvoiceToolStripMenuItem.Size = new System.Drawing.Size(358, 30);
            this.generateInvoiceToolStripMenuItem.Text = "&Generate Invoice...";
            this.generateInvoiceToolStripMenuItem.Click += new System.EventHandler(this.generateInvoiceToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(355, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(358, 30);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblPackage
            // 
            this.lblPackage.Location = new System.Drawing.Point(40, 66);
            this.lblPackage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(126, 35);
            this.lblPackage.TabIndex = 2;
            this.lblPackage.Text = "Package:";
            // 
            // lblFragrance
            // 
            this.lblFragrance.Location = new System.Drawing.Point(405, 66);
            this.lblFragrance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFragrance.Name = "lblFragrance";
            this.lblFragrance.Size = new System.Drawing.Size(150, 35);
            this.lblFragrance.TabIndex = 3;
            this.lblFragrance.Text = "Fragrance:";
            // 
            // cboPackage
            // 
            this.cboPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPackage.FormattingEnabled = true;
            this.cboPackage.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Executive",
            "Luxury"});
            this.cboPackage.Location = new System.Drawing.Point(44, 105);
            this.cboPackage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPackage.Name = "cboPackage";
            this.cboPackage.Size = new System.Drawing.Size(301, 26);
            this.cboPackage.TabIndex = 4;
            // 
            // cboFragrance
            // 
            this.cboFragrance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFragrance.FormattingEnabled = true;
            this.cboFragrance.Items.AddRange(new object[] {
            "Hawaiian Mist\t",
            "Baby Powder",
            "Pine",
            "Country Floral",
            "Pina Colada",
            "Vanilla"});
            this.cboFragrance.Location = new System.Drawing.Point(408, 105);
            this.cboFragrance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFragrance.Name = "cboFragrance";
            this.cboFragrance.Size = new System.Drawing.Size(301, 26);
            this.cboFragrance.TabIndex = 5;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lstExterior);
            this.grpSummary.Controls.Add(this.lstInterior);
            this.grpSummary.Controls.Add(this.lblExterior);
            this.grpSummary.Controls.Add(this.lblInterior);
            this.grpSummary.Location = new System.Drawing.Point(24, 161);
            this.grpSummary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSummary.Size = new System.Drawing.Size(705, 274);
            this.grpSummary.TabIndex = 6;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lstExterior
            // 
            this.lstExterior.FormattingEnabled = true;
            this.lstExterior.ItemHeight = 18;
            this.lstExterior.Location = new System.Drawing.Point(384, 79);
            this.lstExterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstExterior.Name = "lstExterior";
            this.lstExterior.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstExterior.Size = new System.Drawing.Size(301, 148);
            this.lstExterior.TabIndex = 3;
            this.lstExterior.TabStop = false;
            // 
            // lstInterior
            // 
            this.lstInterior.FormattingEnabled = true;
            this.lstInterior.ItemHeight = 18;
            this.lstInterior.Location = new System.Drawing.Point(20, 79);
            this.lstInterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstInterior.Name = "lstInterior";
            this.lstInterior.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstInterior.Size = new System.Drawing.Size(298, 148);
            this.lstInterior.TabIndex = 2;
            this.lstInterior.TabStop = false;
            // 
            // lblExterior
            // 
            this.lblExterior.Location = new System.Drawing.Point(381, 46);
            this.lblExterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExterior.Name = "lblExterior";
            this.lblExterior.Size = new System.Drawing.Size(150, 35);
            this.lblExterior.TabIndex = 1;
            this.lblExterior.Text = "Exterior:";
            // 
            // lblInterior
            // 
            this.lblInterior.Location = new System.Drawing.Point(20, 46);
            this.lblInterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterior.Name = "lblInterior";
            this.lblInterior.Size = new System.Drawing.Size(150, 35);
            this.lblInterior.TabIndex = 0;
            this.lblInterior.Text = "Interior:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Location = new System.Drawing.Point(434, 461);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(122, 28);
            this.lblSubtotal.TabIndex = 7;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDPsubtotal
            // 
            this.lblDPsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDPsubtotal.Location = new System.Drawing.Point(564, 453);
            this.lblDPsubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDPsubtotal.Name = "lblDPsubtotal";
            this.lblDPsubtotal.Size = new System.Drawing.Size(164, 34);
            this.lblDPsubtotal.TabIndex = 8;
            this.lblDPsubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPST
            // 
            this.lblPST.Location = new System.Drawing.Point(405, 503);
            this.lblPST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPST.Name = "lblPST";
            this.lblPST.Size = new System.Drawing.Size(150, 35);
            this.lblPST.TabIndex = 9;
            this.lblPST.Text = "PST:";
            this.lblPST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDPPST
            // 
            this.lblDPPST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDPPST.Location = new System.Drawing.Point(564, 503);
            this.lblDPPST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDPPST.Name = "lblDPPST";
            this.lblDPPST.Size = new System.Drawing.Size(164, 34);
            this.lblDPPST.TabIndex = 10;
            this.lblDPPST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGST
            // 
            this.lblGST.Location = new System.Drawing.Point(405, 552);
            this.lblGST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(150, 35);
            this.lblGST.TabIndex = 11;
            this.lblGST.Text = "GST:";
            this.lblGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDPGST
            // 
            this.lblDPGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDPGST.Location = new System.Drawing.Point(564, 552);
            this.lblDPGST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDPGST.Name = "lblDPGST";
            this.lblDPGST.Size = new System.Drawing.Size(164, 34);
            this.lblDPGST.TabIndex = 12;
            this.lblDPGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(405, 604);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(150, 35);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDPTotal
            // 
            this.lblDPTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblDPTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDPTotal.Location = new System.Drawing.Point(564, 601);
            this.lblDPTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDPTotal.Name = "lblDPTotal";
            this.lblDPTotal.Size = new System.Drawing.Size(164, 34);
            this.lblDPTotal.TabIndex = 14;
            this.lblDPTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CarWashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 701);
            this.Controls.Add(this.lblDPTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDPGST);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.lblDPPST);
            this.Controls.Add(this.lblPST);
            this.Controls.Add(this.lblDPsubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.cboFragrance);
            this.Controls.Add(this.cboPackage);
            this.Controls.Add(this.lblFragrance);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CarWashForm";
            this.Text = "Car Wash";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem generateInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblFragrance;
        private System.Windows.Forms.ComboBox cboPackage;
        private System.Windows.Forms.ComboBox cboFragrance;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.ListBox lstExterior;
        private System.Windows.Forms.ListBox lstInterior;
        private System.Windows.Forms.Label lblExterior;
        private System.Windows.Forms.Label lblInterior;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDPsubtotal;
        private System.Windows.Forms.Label lblPST;
        private System.Windows.Forms.Label lblDPPST;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.Label lblDPGST;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDPTotal;
    }
}