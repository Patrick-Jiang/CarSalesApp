using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRCAGApp
{
    public partial class InvoiceForm : Form
    {
        /// <summary>
        /// Base Invoice form with address
        /// </summary>
        public InvoiceForm()
        {
            InitializeComponent();
            //Display date in form
            DateTime now = DateTime.Today;
            lblDPDate.Text = String.Format("{0:MM/dd/yyyy}", now);
        }

    }
}
