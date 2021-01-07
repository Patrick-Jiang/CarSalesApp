namespace RRCAGApp
{
    partial class SalesQuoteForm
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
            this.lblVehiclesSalesPrice = new System.Windows.Forms.Label();
            this.lblTradeInVale = new System.Windows.Forms.Label();
            this.textTradeInValue = new System.Windows.Forms.TextBox();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.chkComputerNavigation = new System.Windows.Forms.CheckBox();
            this.chkLeatherInterior = new System.Windows.Forms.CheckBox();
            this.chkStereoSystem = new System.Windows.Forms.CheckBox();
            this.grpExteriorFinish = new System.Windows.Forms.GroupBox();
            this.radCustomizedDetailing = new System.Windows.Forms.RadioButton();
            this.radPearlized = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblAmountDuelable = new System.Windows.Forms.Label();
            this.lblTradeIn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSalesTaxCost = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtoalCost = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblOptionsCost = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblSalesPrice = new System.Windows.Forms.Label();
            this.lblVehicleSalesPrice = new System.Windows.Forms.Label();
            this.grpFinance = new System.Windows.Forms.GroupBox();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.nudRate = new System.Windows.Forms.NumericUpDown();
            this.nudYears = new System.Windows.Forms.NumericUpDown();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblAnnualInterestRate = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.btnCalculateQuote = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboVehicle = new System.Windows.Forms.ComboBox();
            this.errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAccessories.SuspendLayout();
            this.grpExteriorFinish.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.grpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYears)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVehiclesSalesPrice
            // 
            this.lblVehiclesSalesPrice.AutoSize = true;
            this.lblVehiclesSalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiclesSalesPrice.Location = new System.Drawing.Point(101, 41);
            this.lblVehiclesSalesPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiclesSalesPrice.Name = "lblVehiclesSalesPrice";
            this.lblVehiclesSalesPrice.Size = new System.Drawing.Size(58, 17);
            this.lblVehiclesSalesPrice.TabIndex = 0;
            this.lblVehiclesSalesPrice.Text = "Vehicle:";
            this.lblVehiclesSalesPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTradeInVale
            // 
            this.lblTradeInVale.AutoSize = true;
            this.lblTradeInVale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTradeInVale.Location = new System.Drawing.Point(56, 71);
            this.lblTradeInVale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTradeInVale.Name = "lblTradeInVale";
            this.lblTradeInVale.Size = new System.Drawing.Size(106, 17);
            this.lblTradeInVale.TabIndex = 1;
            this.lblTradeInVale.Text = "Trade-in Value:";
            // 
            // textTradeInValue
            // 
            this.textTradeInValue.HideSelection = false;
            this.textTradeInValue.Location = new System.Drawing.Point(179, 65);
            this.textTradeInValue.Margin = new System.Windows.Forms.Padding(4);
            this.textTradeInValue.Name = "textTradeInValue";
            this.textTradeInValue.Size = new System.Drawing.Size(163, 23);
            this.textTradeInValue.TabIndex = 1;
            this.textTradeInValue.Text = "0";
            this.textTradeInValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.chkComputerNavigation);
            this.grpAccessories.Controls.Add(this.chkLeatherInterior);
            this.grpAccessories.Controls.Add(this.chkStereoSystem);
            this.grpAccessories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccessories.Location = new System.Drawing.Point(31, 111);
            this.grpAccessories.Margin = new System.Windows.Forms.Padding(4);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Padding = new System.Windows.Forms.Padding(4);
            this.grpAccessories.Size = new System.Drawing.Size(311, 150);
            this.grpAccessories.TabIndex = 2;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // chkComputerNavigation
            // 
            this.chkComputerNavigation.AutoSize = true;
            this.chkComputerNavigation.Location = new System.Drawing.Point(28, 108);
            this.chkComputerNavigation.Margin = new System.Windows.Forms.Padding(4);
            this.chkComputerNavigation.Name = "chkComputerNavigation";
            this.chkComputerNavigation.Size = new System.Drawing.Size(159, 21);
            this.chkComputerNavigation.TabIndex = 2;
            this.chkComputerNavigation.Text = "Computer Navigation";
            this.chkComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // chkLeatherInterior
            // 
            this.chkLeatherInterior.AutoSize = true;
            this.chkLeatherInterior.Location = new System.Drawing.Point(28, 74);
            this.chkLeatherInterior.Margin = new System.Windows.Forms.Padding(4);
            this.chkLeatherInterior.Name = "chkLeatherInterior";
            this.chkLeatherInterior.Size = new System.Drawing.Size(124, 21);
            this.chkLeatherInterior.TabIndex = 1;
            this.chkLeatherInterior.Text = "Leather Interior";
            this.chkLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // chkStereoSystem
            // 
            this.chkStereoSystem.AutoSize = true;
            this.chkStereoSystem.Location = new System.Drawing.Point(28, 40);
            this.chkStereoSystem.Margin = new System.Windows.Forms.Padding(4);
            this.chkStereoSystem.Name = "chkStereoSystem";
            this.chkStereoSystem.Size = new System.Drawing.Size(119, 21);
            this.chkStereoSystem.TabIndex = 0;
            this.chkStereoSystem.Text = "Stereo System";
            this.chkStereoSystem.UseVisualStyleBackColor = true;
            // 
            // grpExteriorFinish
            // 
            this.grpExteriorFinish.Controls.Add(this.radCustomizedDetailing);
            this.grpExteriorFinish.Controls.Add(this.radPearlized);
            this.grpExteriorFinish.Controls.Add(this.radStandard);
            this.grpExteriorFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExteriorFinish.Location = new System.Drawing.Point(31, 284);
            this.grpExteriorFinish.Margin = new System.Windows.Forms.Padding(4);
            this.grpExteriorFinish.Name = "grpExteriorFinish";
            this.grpExteriorFinish.Padding = new System.Windows.Forms.Padding(4);
            this.grpExteriorFinish.Size = new System.Drawing.Size(311, 167);
            this.grpExteriorFinish.TabIndex = 3;
            this.grpExteriorFinish.TabStop = false;
            this.grpExteriorFinish.Text = "Exterior Finish";
            // 
            // radCustomizedDetailing
            // 
            this.radCustomizedDetailing.AutoSize = true;
            this.radCustomizedDetailing.Location = new System.Drawing.Point(28, 111);
            this.radCustomizedDetailing.Margin = new System.Windows.Forms.Padding(4);
            this.radCustomizedDetailing.Name = "radCustomizedDetailing";
            this.radCustomizedDetailing.Size = new System.Drawing.Size(158, 21);
            this.radCustomizedDetailing.TabIndex = 2;
            this.radCustomizedDetailing.TabStop = true;
            this.radCustomizedDetailing.Text = "Customized Detailing";
            this.radCustomizedDetailing.UseVisualStyleBackColor = true;
            // 
            // radPearlized
            // 
            this.radPearlized.AutoSize = true;
            this.radPearlized.Location = new System.Drawing.Point(27, 79);
            this.radPearlized.Margin = new System.Windows.Forms.Padding(4);
            this.radPearlized.Name = "radPearlized";
            this.radPearlized.Size = new System.Drawing.Size(85, 21);
            this.radPearlized.TabIndex = 1;
            this.radPearlized.TabStop = true;
            this.radPearlized.Text = "Pearlized";
            this.radPearlized.UseVisualStyleBackColor = true;
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Checked = true;
            this.radStandard.Location = new System.Drawing.Point(28, 47);
            this.radStandard.Margin = new System.Windows.Forms.Padding(4);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(84, 21);
            this.radStandard.TabIndex = 0;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(39, 472);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 34);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblAmountDue);
            this.grpSummary.Controls.Add(this.lblAmountDuelable);
            this.grpSummary.Controls.Add(this.lblTradeIn);
            this.grpSummary.Controls.Add(this.label4);
            this.grpSummary.Controls.Add(this.lblTotalCost);
            this.grpSummary.Controls.Add(this.label3);
            this.grpSummary.Controls.Add(this.lblSalesTaxCost);
            this.grpSummary.Controls.Add(this.lblSalesTax);
            this.grpSummary.Controls.Add(this.lblSubtoalCost);
            this.grpSummary.Controls.Add(this.lblSubtotal);
            this.grpSummary.Controls.Add(this.lblOptionsCost);
            this.grpSummary.Controls.Add(this.lblOptions);
            this.grpSummary.Controls.Add(this.lblSalesPrice);
            this.grpSummary.Controls.Add(this.lblVehicleSalesPrice);
            this.grpSummary.Location = new System.Drawing.Point(389, 32);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(402, 284);
            this.grpSummary.TabIndex = 8;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmountDue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAmountDue.Location = new System.Drawing.Point(177, 252);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(174, 23);
            this.lblAmountDue.TabIndex = 13;
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountDuelable
            // 
            this.lblAmountDuelable.AutoSize = true;
            this.lblAmountDuelable.Location = new System.Drawing.Point(80, 253);
            this.lblAmountDuelable.Name = "lblAmountDuelable";
            this.lblAmountDuelable.Size = new System.Drawing.Size(90, 17);
            this.lblAmountDuelable.TabIndex = 12;
            this.lblAmountDuelable.Text = "Amount Due:";
            // 
            // lblTradeIn
            // 
            this.lblTradeIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTradeIn.Location = new System.Drawing.Point(177, 213);
            this.lblTradeIn.Name = "lblTradeIn";
            this.lblTradeIn.Size = new System.Drawing.Size(174, 23);
            this.lblTradeIn.TabIndex = 11;
            this.lblTradeIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Trade-in:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCost.Location = new System.Drawing.Point(176, 174);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(174, 23);
            this.lblTotalCost.TabIndex = 9;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total:";
            // 
            // lblSalesTaxCost
            // 
            this.lblSalesTaxCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesTaxCost.Location = new System.Drawing.Point(176, 135);
            this.lblSalesTaxCost.Name = "lblSalesTaxCost";
            this.lblSalesTaxCost.Size = new System.Drawing.Size(174, 23);
            this.lblSalesTaxCost.TabIndex = 7;
            this.lblSalesTaxCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(58, 136);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(112, 17);
            this.lblSalesTax.TabIndex = 6;
            this.lblSalesTax.Text = "Sales Tax(13%):";
            // 
            // lblSubtoalCost
            // 
            this.lblSubtoalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtoalCost.Location = new System.Drawing.Point(176, 96);
            this.lblSubtoalCost.Name = "lblSubtoalCost";
            this.lblSubtoalCost.Size = new System.Drawing.Size(174, 23);
            this.lblSubtoalCost.TabIndex = 5;
            this.lblSubtoalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(106, 97);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(64, 17);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblOptionsCost
            // 
            this.lblOptionsCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOptionsCost.Location = new System.Drawing.Point(176, 57);
            this.lblOptionsCost.Name = "lblOptionsCost";
            this.lblOptionsCost.Size = new System.Drawing.Size(174, 23);
            this.lblOptionsCost.TabIndex = 3;
            this.lblOptionsCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(109, 58);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(61, 17);
            this.lblOptions.TabIndex = 2;
            this.lblOptions.Text = "Options:";
            // 
            // lblSalesPrice
            // 
            this.lblSalesPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesPrice.Location = new System.Drawing.Point(176, 18);
            this.lblSalesPrice.Name = "lblSalesPrice";
            this.lblSalesPrice.Size = new System.Drawing.Size(174, 23);
            this.lblSalesPrice.TabIndex = 1;
            this.lblSalesPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVehicleSalesPrice
            // 
            this.lblVehicleSalesPrice.AutoSize = true;
            this.lblVehicleSalesPrice.Location = new System.Drawing.Point(34, 19);
            this.lblVehicleSalesPrice.Name = "lblVehicleSalesPrice";
            this.lblVehicleSalesPrice.Size = new System.Drawing.Size(136, 17);
            this.lblVehicleSalesPrice.TabIndex = 0;
            this.lblVehicleSalesPrice.Text = "Vehicle\'s Sale Price:";
            // 
            // grpFinance
            // 
            this.grpFinance.Controls.Add(this.lblMonthlyPayment);
            this.grpFinance.Controls.Add(this.nudRate);
            this.grpFinance.Controls.Add(this.nudYears);
            this.grpFinance.Controls.Add(this.lblPayment);
            this.grpFinance.Controls.Add(this.lblAnnualInterestRate);
            this.grpFinance.Controls.Add(this.lblYears);
            this.grpFinance.Location = new System.Drawing.Point(393, 325);
            this.grpFinance.Name = "grpFinance";
            this.grpFinance.Size = new System.Drawing.Size(398, 126);
            this.grpFinance.TabIndex = 4;
            this.grpFinance.TabStop = false;
            this.grpFinance.Text = "Finance";
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthlyPayment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(279, 73);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(113, 23);
            this.lblMonthlyPayment.TabIndex = 5;
            this.lblMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudRate
            // 
            this.nudRate.DecimalPlaces = 2;
            this.nudRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudRate.Location = new System.Drawing.Point(161, 73);
            this.nudRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudRate.Name = "nudRate";
            this.nudRate.Size = new System.Drawing.Size(86, 23);
            this.nudRate.TabIndex = 1;
            this.nudRate.Value = new decimal(new int[] {
            500,
            0,
            0,
            131072});
            // 
            // nudYears
            // 
            this.nudYears.Location = new System.Drawing.Point(24, 73);
            this.nudYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudYears.Name = "nudYears";
            this.nudYears.Size = new System.Drawing.Size(87, 23);
            this.nudYears.TabIndex = 0;
            this.nudYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(276, 53);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(116, 17);
            this.lblPayment.TabIndex = 2;
            this.lblPayment.Text = "Monthly Payment";
            // 
            // lblAnnualInterestRate
            // 
            this.lblAnnualInterestRate.AutoSize = true;
            this.lblAnnualInterestRate.Location = new System.Drawing.Point(158, 36);
            this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
            this.lblAnnualInterestRate.Size = new System.Drawing.Size(89, 34);
            this.lblAnnualInterestRate.TabIndex = 1;
            this.lblAnnualInterestRate.Text = "Annual \r\nInterest Rate";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(21, 53);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(90, 17);
            this.lblYears.TabIndex = 0;
            this.lblYears.Text = "No. Of Years";
            // 
            // btnCalculateQuote
            // 
            this.btnCalculateQuote.Location = new System.Drawing.Point(607, 472);
            this.btnCalculateQuote.Name = "btnCalculateQuote";
            this.btnCalculateQuote.Size = new System.Drawing.Size(184, 34);
            this.btnCalculateQuote.TabIndex = 5;
            this.btnCalculateQuote.Text = "Calculate Quote";
            this.btnCalculateQuote.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleInformationToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // vehicleInformationToolStripMenuItem
            // 
            this.vehicleInformationToolStripMenuItem.Enabled = false;
            this.vehicleInformationToolStripMenuItem.Name = "vehicleInformationToolStripMenuItem";
            this.vehicleInformationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.vehicleInformationToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.vehicleInformationToolStripMenuItem.Text = "Vehicle &Information…";
            this.vehicleInformationToolStripMenuItem.Click += new System.EventHandler(this.vehicleInformationToolStripMenuItem_Click);
            // 
            // cboVehicle
            // 
            this.cboVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicle.FormattingEnabled = true;
            this.cboVehicle.Location = new System.Drawing.Point(179, 34);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(163, 24);
            this.cboVehicle.TabIndex = 10;
            // 
            // errors
            // 
            this.errors.ContainerControl = this;
            // 
            // SalesQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 527);
            this.Controls.Add(this.cboVehicle);
            this.Controls.Add(this.btnCalculateQuote);
            this.Controls.Add(this.grpFinance);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpExteriorFinish);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.textTradeInValue);
            this.Controls.Add(this.lblTradeInVale);
            this.Controls.Add(this.lblVehiclesSalesPrice);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SalesQuoteForm";
            this.Text = "Vehicle Sales Quote";
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpExteriorFinish.ResumeLayout(false);
            this.grpExteriorFinish.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpFinance.ResumeLayout(false);
            this.grpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYears)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehiclesSalesPrice;
        private System.Windows.Forms.Label lblTradeInVale;
        private System.Windows.Forms.TextBox textTradeInValue;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.CheckBox chkComputerNavigation;
        private System.Windows.Forms.CheckBox chkLeatherInterior;
        private System.Windows.Forms.CheckBox chkStereoSystem;
        private System.Windows.Forms.GroupBox grpExteriorFinish;
        private System.Windows.Forms.RadioButton radCustomizedDetailing;
        private System.Windows.Forms.RadioButton radPearlized;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblSalesPrice;
        private System.Windows.Forms.Label lblVehicleSalesPrice;
        private System.Windows.Forms.Label lblOptionsCost;
        private System.Windows.Forms.Label lblSubtoalCost;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblAmountDuelable;
        private System.Windows.Forms.Label lblTradeIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSalesTaxCost;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.GroupBox grpFinance;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblAnnualInterestRate;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.NumericUpDown nudYears;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.NumericUpDown nudRate;
        private System.Windows.Forms.Button btnCalculateQuote;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleInformationToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboVehicle;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errors;
    }
}

