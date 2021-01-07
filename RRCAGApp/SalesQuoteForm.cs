using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jiang.Jianheng.Business;
using RRCAG.Data;
using System.Data.OleDb;
namespace RRCAGApp
{   
    public partial class SalesQuoteForm : Form
    {
        private const decimal TAX_RATE = 0.13m;
        private bool initialStart;
        private bool validTradeInPrice;
        OleDbDataAdapter _dataAdapter;
        DataSet _dataSet;
        BindingSource _bindingSource;

        /// <summary>
        ///Initializes an instance of SalesQuote form. 
        /// </summary>
        public SalesQuoteForm()
        {
            InitializeComponent();
            OleDbConnection oleDbConnection = new OleDbConnection();

            oleDbConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AMDatabase.mdb";

            oleDbConnection.Open();

        
            string SqlQuery = "SELECT * FROM VehicleStock WHERE SoldBy = 0";

            OleDbCommand dbCommand = new OleDbCommand(SqlQuery, oleDbConnection);
            dbCommand.CommandText = SqlQuery;

            _dataAdapter = new OleDbDataAdapter();
            _dataAdapter.SelectCommand = dbCommand;

            _dataSet = new DataSet();

            _dataAdapter.Fill(_dataSet, "VehicleStock");

            _bindingSource = new BindingSource();
          


            OleDbCommandBuilder oleDbCommandBuilder = new OleDbCommandBuilder();

            oleDbCommandBuilder.DataAdapter = _dataAdapter;

            _dataAdapter.UpdateCommand = oleDbCommandBuilder.GetUpdateCommand();
            _dataAdapter.InsertCommand = oleDbCommandBuilder.GetInsertCommand();
            _dataAdapter.DeleteCommand = oleDbCommandBuilder.GetDeleteCommand();
            initialStart = true;
            validTradeInPrice = false;

            //display the text box name with Tax rate 
            this.lblSalesTax.Text = String.Format("Sales Tax({0:N0}%):", TAX_RATE * 100);

            //set accept button to btnCalculate
            this.AcceptButton = btnCalculateQuote;

            //textVehicleSalesPrice.TextChanged += new EventHandler(textVehicleSalesPriceTradeIn_Changed);
            textTradeInValue.TextChanged += new EventHandler(textVehicleSalesPriceTradeIn_Changed);
            
            //eventhandler for checkbox
            chkStereoSystem.CheckedChanged += new EventHandler(CheckBox_Checked);
            chkComputerNavigation.CheckedChanged += new EventHandler(CheckBox_Checked);
            chkLeatherInterior.CheckedChanged += new EventHandler(CheckBox_Checked);
            
            //eventhandler for radio button
            radStandard.CheckedChanged += new EventHandler(raidobtn_Selected);
            radCustomizedDetailing.CheckedChanged += new EventHandler(raidobtn_Selected);
            radPearlized.CheckedChanged += new EventHandler(raidobtn_Selected);
           
            //eventhandler for Rate,Years
            nudRate.ValueChanged += new EventHandler(nudYearAndRate_Changed);
            nudYears.ValueChanged += new EventHandler(nudYearAndRate_Changed);
           
            //eventhandler for calculate,reset button
            btnCalculateQuote.Click += new EventHandler(btnCalculateQuote_Calculate);
            btnReset.Click += new EventHandler(btnReset_Reset);



            _bindingSource.DataSource = _dataSet.Tables["VehicleStock"];
            this.cboVehicle.DataSource = _bindingSource;
            this.cboVehicle.DisplayMember = "StockNumber";
            this.cboVehicle.ValueMember = "BasePrice";
            this.cboVehicle.SelectedIndex = -1;

            //eventhandler for combobox cboVehicle
            cboVehicle.SelectedIndexChanged += new EventHandler(cboVehicle_SelectedIndexChanged);

            if (cboVehicle.Items.Count > 0)
            {
                this.ShowDialog();
            }
            else
            {
               MessageBox.Show("There are no vehicles in stock",
                            "Sales Quote Data",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Close the form when user click "exit"
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Open new vehicle information form
        /// </summary>
        private void vehicleInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new VehicleInformationForm(_bindingSource);
            form.ShowDialog();
        }

        /// <summary>
        /// Use to monitor vehicle sales price,trade in text area change,when changes reset the summary box
        /// </summary>
        private void textVehicleSalesPriceTradeIn_Changed(object sender, EventArgs e)
        {
            this.ResetTextBox();
        }

        /// <summary>
        /// Use to monitor Check box change, calculate new sales quote.
        /// </summary>
        private void CheckBox_Checked(object sender, EventArgs e)
        {
            this.accessoriesCheckBox();
            this.Calculatebtn();
        }

        /// <summary>
        /// Use to monitor standard radio button change, calculate new sales quote.
        /// </summary>
        private void raidobtn_Selected(object sender, EventArgs e)
        {
            this.exteriorRadiobtn();
            this.Calculatebtn();
        }

        /// <summary>
        /// Use to monitor nudYears,Rate, calculate new sales quote.
        /// </summary>
        private void nudYearAndRate_Changed(object sender, EventArgs e)
        {
            this.Calculatebtn();
        }

        /// <summary>
        /// Use to monitor vehicle combo box change, calculate new sales quote.
        /// </summary>
        private void cboVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVehicle.SelectedItem != null)
            {
                vehicleInformationToolStripMenuItem.Enabled = true;
            }
            this.ResetTextBox();
        }

        /// <summary>
        /// Use to monitor button btnCalculateQuote, calculate new sales quote.
        /// </summary>
        private void btnCalculateQuote_Calculate(object sender, EventArgs e)
        {
            this.validateTradeInInput();
            if (validTradeInPrice)
            {
                if (cboVehicle.SelectedIndex != -1)
                {
                    vehicleInformationToolStripMenuItem.Enabled = true;
                    errors.SetError(cboVehicle, "");
                    this.DisplayData();
                    initialStart = false;
                }
                else
                {
                    errors.SetIconPadding(cboVehicle, 3);
                    errors.SetError(cboVehicle, "A vehicle must be selected.");
                }
            }  
        }
       
        /// <summary>
        /// Reset the form to their initial states.
        /// </summary>
        private void btnReset_Reset(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to reset the form?",
                            "Reset Form",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Warning,
                             MessageBoxDefaultButton.Button2);
            if(result == DialogResult.Yes)
            { 
                this.ResetTextBox();
                initialStart = true;
                nudYears.Value = 1;
                nudRate.Value = 5.00m;
                radStandard.Checked = true;
                radPearlized.Checked = false;
                radCustomizedDetailing.Checked = false;
                validTradeInPrice = true;
                this.cboVehicle.SelectedIndex = -1;
                textTradeInValue.Text = "0";
                errors.SetError(textTradeInValue, "");
                errors.SetError(cboVehicle, "");
                vehicleInformationToolStripMenuItem.Enabled = false;
                foreach (Control item in grpAccessories.Controls)
                {
                    if (item is CheckBox)
                    {
                        ((CheckBox)item).Checked = false;
                    }
                }
            }
        }

        /// <summary>
        /// Display quote number on the form.
        /// </summary>
        private void DisplayData()
        {
            decimal _vehicleSalesPrice =1;
            decimal _tradeInValue = 0;
            Accessories _accessoriesChoose = Accessories.None;
            ExteriorFinish _exteriorFinish = ExteriorFinish.Standard;
            SalesQuote salesQuote = new SalesQuote(_vehicleSalesPrice, _tradeInValue, TAX_RATE, _accessoriesChoose, _exteriorFinish);

            salesQuote.VehicleSalePrice = (decimal)((double)cboVehicle.SelectedValue);
            salesQuote.TradeInAmount = this.validateTradeInInput();
            salesQuote.AccessoriesChosen = this.accessoriesCheckBox();
            salesQuote.ExteriorFinishChosen = this.exteriorRadiobtn();

            lblSalesPrice.Text = String.Format("{0:C}", salesQuote.VehicleSalePrice);
            lblOptionsCost.Text = String.Format("{0:0.00}", salesQuote.AccessoryCost + salesQuote.ExteriorFinishCost);
            lblSubtoalCost.Text = String.Format("{0:c}", salesQuote.SubTotal);
            lblSalesTaxCost.Text = String.Format("{0:0.00}", salesQuote.SalesTax);
            lblTotalCost.Text = String.Format("{0:c}", salesQuote.Total);
            lblTradeIn.Text = String.Format("-{0:0.00}", salesQuote.TradeInAmount);
            lblAmountDue.Text = String.Format("{0:c}", salesQuote.GetAmountDue);
            lblMonthlyPayment.Text = String.Format("{0:c}", Financial.GetPayment(nudRate.Value/100/12, (int)(nudYears.Value) * 12, salesQuote.GetAmountDue));
        }

        /// <summary>
        /// Reset the from and controls back to their initial states
        /// </summary>
        private void ResetTextBox()
        {
            List<Label> resetlbl = new List<Label>();
            resetlbl.Add(lblSalesPrice);
            resetlbl.Add(lblOptionsCost);
            resetlbl.Add(lblSubtoalCost);
            resetlbl.Add(lblSalesTaxCost);
            resetlbl.Add(lblTotalCost);
            resetlbl.Add(lblTradeIn);
            resetlbl.Add(lblMonthlyPayment);
            resetlbl.Add(lblAmountDue);
            foreach (Label item in resetlbl)
            {
                item.Text = "";
            }
            initialStart = true;
        }

        /// <summary>
        /// set the exterior chosen
        /// </summary>
        /// <returns></returns>
        private ExteriorFinish exteriorRadiobtn()
        {
            ExteriorFinish exteriorFinish = ExteriorFinish.Standard;
            if (radStandard.Checked)
            {
                exteriorFinish = ExteriorFinish.Standard;
            }
            else if (radPearlized.Checked)
            {
                exteriorFinish = ExteriorFinish.Pearlized;
            }
            else if (radCustomizedDetailing.Checked)
            {
                exteriorFinish = ExteriorFinish.Custom;
            }
            return exteriorFinish;
        }

        /// <summary>
        /// set the accessor chosen 
        /// </summary>
        private Accessories accessoriesCheckBox()
        {
            Accessories accessoriesChoose = Accessories.None;
            if (chkComputerNavigation.Checked)
            {
                accessoriesChoose = Accessories.ComputerNavigation;
            }
            if (chkLeatherInterior.Checked)
            {
                accessoriesChoose = Accessories.LeatherInterior;
            }
            if (chkStereoSystem.Checked)
            {
                accessoriesChoose = Accessories.StereoSystem;
            }
            if (chkStereoSystem.Checked && chkLeatherInterior.Checked)
            {
                accessoriesChoose = Accessories.StereoAndLeather;
            }
            if (chkStereoSystem.Checked && chkComputerNavigation.Checked)
            {
                accessoriesChoose = Accessories.StereoAndNavigation;
            }
            if (chkLeatherInterior.Checked && chkComputerNavigation.Checked)
            {
                accessoriesChoose = Accessories.LeatherAndNavigation;
            }
            if (chkLeatherInterior.Checked && chkComputerNavigation.Checked && chkStereoSystem.Checked)
            {
                accessoriesChoose = Accessories.All;
            }
            return accessoriesChoose;
        }

        /// <summary>
        /// Calculate the new quote number when form changes
        /// </summary>
        private void Calculatebtn()
        {   
            if (!initialStart)
            {
                this.validateTradeInInput();
                if (validTradeInPrice)
                {
                    if (cboVehicle.SelectedIndex != -1)
                    {
                        vehicleInformationToolStripMenuItem.Enabled = true;
                        errors.SetError(cboVehicle, "");
                        this.DisplayData();
                        initialStart = false;
                    }
                    else
                    {
                        errors.SetIconPadding(cboVehicle, 3);
                        errors.SetError(cboVehicle, "A vehicle must be selected.");
                    }
                }
            }
        }

        /// <summary>
        /// Validation of Trade in Input, error message display beside the input box.
        /// </summary>
        private decimal validateTradeInInput()
        {
            errors.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errors.SetIconPadding(textTradeInValue, 3);
            decimal _tradeInValue = 0;
            if (textTradeInValue.Text == "")
            {
                errors.SetError(textTradeInValue, "Trade-in price is required");
                validTradeInPrice = false;
            }
            else if (Decimal.TryParse(textTradeInValue.Text, out _tradeInValue))
            {
                _tradeInValue = Decimal.Parse(textTradeInValue.Text);
                validTradeInPrice = true;
                errors.SetError(textTradeInValue, "");
            }
            else
            {
                errors.SetError(textTradeInValue, "Trade-in price cannot contain letters or special characters");
                validTradeInPrice = false;
            }
            if (Decimal.TryParse(textTradeInValue.Text, out _tradeInValue) && Decimal.Parse(textTradeInValue.Text) < 0)
            {
                errors.SetError(textTradeInValue, "Trade-in price cannot be less than 0");
                validTradeInPrice = false;
            }
            if (cboVehicle.SelectedIndex != -1)
            {
                errors.SetError(cboVehicle, "");
                if (_tradeInValue > (decimal)((double)cboVehicle.SelectedValue))
                {
                    errors.SetError(textTradeInValue, "Trade-in value cannot exceed the vehicle sale price");
                    validTradeInPrice = false;
                }
            }          
            initialStart = true;
            return _tradeInValue;
        }
    }
}
