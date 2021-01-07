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
namespace RRCAGApp
{
    public partial class CarWashForm : Form
    {
        private const decimal PST = 0.08m;
        private const decimal GST = 0.05m;
        CarWashInvoice obj;
        /// <summary>
        /// Initializes an instance of Car Wash form 
        /// </summary>
        public CarWashForm()
        {
            InitializeComponent();
            //Event Handler for cboPackage and cboFragrance
            this.cboPackage.SelectedIndexChanged += new EventHandler(cboPackageFragrance_SelectedIndexChanged);
            this.cboFragrance.SelectedIndexChanged += new EventHandler(cboPackageFragrance_SelectedIndexChanged);

            BindingList<PriceList> package = new BindingList<PriceList>();
            package.Add(new PriceList("Standard", 7.5m));
            package.Add(new PriceList("Deluxe", 15m));
            package.Add(new PriceList("Executive", 35m));
            package.Add(new PriceList("Luxury", 55m));
            BindingSource bindingSoure = new BindingSource();
            bindingSoure.DataSource = package;
            this.cboPackage.DataSource = bindingSoure;
            this.cboPackage.DisplayMember = "Description";
            this.cboPackage.ValueMember = "Price";
            //Default selection -1 = none
            cboPackage.SelectedIndex = -1;


            BindingList<PriceList> fragrances = new BindingList<PriceList>();
            fragrances.Add(new PriceList("Hawaiian Mist", 2.75m));
            fragrances.Add(new PriceList("Baby Powder", 1.5m));
            fragrances.Add(new PriceList("Pine", 0m));
            fragrances.Add(new PriceList("Country Floral", 2.25m));
            fragrances.Add(new PriceList("Pina Colada", 0.75m));
            fragrances.Add(new PriceList("Vanilla", 2m));
            BindingSource bindingSoureTwo = new BindingSource();
            bindingSoureTwo.DataSource = fragrances;
            this.cboFragrance.DataSource = bindingSoureTwo;
            this.cboFragrance.DisplayMember = "Description";
            this.cboFragrance.ValueMember = "Price";
            //Default selection 2 = pine
            cboFragrance.SelectedIndex = 2;

        }

        /// <summary>
        ///  Use to monitor Package,Fragrance combo box, calculate new quote.
        /// </summary>
        private void cboPackageFragrance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFragrance.SelectedIndex != -1 && cboPackage.SelectedIndex != -1)
            {
                display();
                generateInvoiceToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// Use to monitor click event  "Generate Invoice",opens new form 
        /// </summary>
        private void generateInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cboFragrance.SelectedIndex != -1 && cboPackage.SelectedIndex != -1)
            {
                generateInvoiceToolStripMenuItem.Enabled = true;
                Form myForm = new CarWashInvoiceForm(obj);
                myForm.ShowDialog();
                resetForm();
            }
            else
            {
                generateInvoiceToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// Close the Car Wash form
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Display the selections depends on the package chosen.
        /// </summary>
        /// <param name="index"> Index for cboPackage selected</param>
        private void displayList(int index)
        {
            string[] interior = { "Fragrance - "+cboFragrance.Text,
            "Shampoo Carpets","Shampoo Upholstery","Interior Protection Coat"};

            string[] exterior = { "Hand Wash","Hand Wax","Wheel Polish", "Detail Engine Compartment" };

            lstInterior.Items.Clear();
            lstExterior.Items.Clear();

            for (int i = 0; i<= index;i++)
            {
                    lstInterior.Items.Add(interior[i]);
                    lstExterior.Items.Add(exterior[i]);   
            }
        }

        /// <summary>
        /// Display price on the form.
        /// </summary>
        private void display()
        {
            decimal package = ((PriceList)(cboPackage.SelectedItem)).Price;
            decimal fragrance = ((PriceList)(cboFragrance.SelectedItem)).Price;
            obj  = new CarWashInvoice(PST,GST,package,fragrance);

            displayList(cboPackage.SelectedIndex);
            lblDPsubtotal.Text = String.Format("{0:C}", obj.SubTotal);
            lblDPPST.Text = String.Format("{0:0.00}", obj.ProvincialSalesTaxCharged);
            lblDPGST.Text = String.Format("{0:0.00}", obj.GoodsAndServicesTaxCharged);
            lblDPTotal.Text = String.Format("{0:C}", obj.Total);
        }

        /// <summary>
        /// Reset the form to their initial states.
        /// </summary>
        private void resetForm()
        {
            cboPackage.SelectedIndex = -1;
            cboFragrance.SelectedIndex = 2;
            lblDPsubtotal.Text = "";
            lblDPPST.Text = "";
            lblDPGST.Text = "";
            lblDPTotal.Text = "";
            lstInterior.Items.Clear();
            lstExterior.Items.Clear();
            generateInvoiceToolStripMenuItem.Enabled = false;
        }

    }
}
