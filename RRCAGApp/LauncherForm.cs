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
    public partial class LauncherForm : Form
    {
        /// <summary>
        /// Initializes an instance of Launcher form,open in maximized. 
        /// </summary>
        public LauncherForm()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        /// <summary>
        /// Initializes an instance of salesquote form,open in modal window. 
        /// </summary>
        private void salesQuoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            try
            {
                
                Form myForm = new SalesQuoteForm();
               
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Unable to load vehicle data.",
                            "Data Load Error",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Initializes an instance of about form,open in modal window. 
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">Event Args</param>
        private void mnuRootSubAbout_Click(object sender, EventArgs e)
        {
            Form myForm = new AboutBox();
            myForm.ShowDialog();
        }

        /// <summary>
        /// Quit the application 
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">Event Args</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carWashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myForm = new CarWashForm();
            myForm.ShowDialog();
        }

        private void mnuVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                //1
                Form myForm = new VehicelData();
                //2
                myForm.Show();
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Unable to load vehicle data.",
                            "Data Load Error",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
        }
    }
}
