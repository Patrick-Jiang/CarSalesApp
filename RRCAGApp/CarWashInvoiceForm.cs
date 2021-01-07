using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jiang.Jianheng.Business;

namespace RRCAGApp
{
    public partial class CarWashInvoiceForm : RRCAGApp.InvoiceForm
    {
        /// <summary>
        /// Create Car Wash Invoice
        /// </summary>
        /// <param name="package">selected item from the binding source</param>
        /// <param name="fragrance">selected item from the binding source</param>
        public CarWashInvoiceForm(CarWashInvoice obj)
        {
            InitializeComponent();
            lblInvoiceTitle.Text = "Car Wash Invoice";
            this.Text = "Car Wash Invoice";
            lblDPPackagePrice.Text = String.Format("{0:C}", obj.PackageCost);
            lblDPFragrancePrice.Text = String.Format("{0}", obj.FragranceCost);
            lblDPSubtotal.Text = String.Format("{0:C}", obj.SubTotal);
            lblDPTaxes.Text = String.Format("{0:0.00}", obj.ProvincialSalesTaxCharged+obj.GoodsAndServicesTaxCharged);
            lblDPTotal.Text = String.Format("{0:C}", obj.Total);
        }
    }
}
