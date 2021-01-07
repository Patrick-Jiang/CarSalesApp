using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRCAG.Data;

namespace RRCAGApp
{
    public partial class VehicleInformationForm : Form
    {
        /// <summary>
        /// Create the Vehicle Information 
        /// </summary>
        public VehicleInformationForm(BindingSource bindingsource)
        {
            InitializeComponent();
            Binding Title = new Binding("Text", bindingsource, "");
            Binding StockID = new Binding("Text", bindingsource, "StockNumber");
            Binding Year = new Binding("Text", bindingsource, "ManufacturedYear");
            Binding Manufacturer = new Binding("Text", bindingsource, "Make");
            Binding Model = new Binding("Text", bindingsource, "Model");
            Binding Mileage = new Binding("Text", bindingsource, "Mileage",true);   
            Binding Colour = new Binding("Text", bindingsource, "Colour");
            Binding BasePrice = new Binding("Text", bindingsource, "BasePrice",true);
            
            //formating
            BasePrice.FormatString = "c";
            Mileage.FormatString = "N0";

            //this.DataBindings.Add(Title);
            lblDPStockID.DataBindings.Add(StockID);
            lblDPYear.DataBindings.Add(Year);
            lblDPManufacturer.DataBindings.Add(Manufacturer);
            lblDPModel.DataBindings.Add(Model);
            lblDPMileage.DataBindings.Add(Mileage);
            lblDPColour.DataBindings.Add(Colour);
            lblDPBasePrice.DataBindings.Add(BasePrice);
       
            DataRowView row = (DataRowView)bindingsource.Current;

            if ((bool)row["Automatic"])
            {
                lblDPTransmission.Text = String.Format("{0}", "Automatic");
            }
            else
            lblDPTransmission.Text = String.Format("{0}", "Manual");

            this.Text = String.Format("{0}-{1} {2} {3}",row["StockNumber"],row["ManufacturedYear"],row["Make"],row["Model"]);
        }

        /// <summary>
        /// Close the application
        /// </summary>
        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
