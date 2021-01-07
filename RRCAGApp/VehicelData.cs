using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RRCAGApp
{
    /// <summary>
    /// Represents VehicelData Form
    /// </summary>
    public partial class VehicelData : Form
    {
        private OleDbDataAdapter _dataAdapter;
        private DataSet _dataSet;
        private BindingSource _bindingSource;

        /// <summary>
        /// Initializes an instance of VehicelData form. 
        /// </summary>
        public VehicelData()
        {
            InitializeComponent();

            //Construct an instance of a connection object
            OleDbConnection oleDbConnection = new OleDbConnection();

            //Setup the ConnectionString
            oleDbConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AMDatabase.mdb";

            //Open the database file
            oleDbConnection.Open();
          
            //Selection query
            string SqlQuery = "SELECT * FROM VehicleStock";

            //Construct an instance of a command object
            //SqlQuery is the selection 
            //oleDbConnection reference to the connection
            OleDbCommand dbCommand = new OleDbCommand(SqlQuery, oleDbConnection);

            //Create an data adapter object
            _dataAdapter = new OleDbDataAdapter();

            //Set the data adapter object's select command to the command object
            _dataAdapter.SelectCommand = dbCommand;

            //Create an data set object
            _dataSet = new DataSet();

            //Using the data adapter object, fill the data set
            //"VehicleStock" is the table name
            _dataAdapter.Fill(_dataSet, "VehicleStock");


            //Create the binding source object
            _bindingSource = new BindingSource();

            //Create the command builder object
            OleDbCommandBuilder oleDbCommandBuilder = new OleDbCommandBuilder();

            //Set the command builder object's data adapter to _dataAdapter
            oleDbCommandBuilder.DataAdapter = _dataAdapter;

            //Use command builder to get required SQL 
            _dataAdapter.UpdateCommand = oleDbCommandBuilder.GetUpdateCommand();
            _dataAdapter.InsertCommand = oleDbCommandBuilder.GetInsertCommand();
            _dataAdapter.DeleteCommand = oleDbCommandBuilder.GetDeleteCommand();

            //Resolve the primary key conflict when Adding and Deleting new row 
            oleDbCommandBuilder.ConflictOption = ConflictOption.OverwriteChanges;

            //EventHandlers
            _dataAdapter.RowUpdated += new OleDbRowUpdatedEventHandler(dataAdapter_RowUpdated);
            dgvVehicelData.SelectionChanged += new EventHandler(dgvVehicelData_SelectionChanged);
            dgvVehicelData.CellValueChanged += new DataGridViewCellEventHandler(dgvVehicelData_CellValueChanged);
            this.FormClosing += FormClosingEvent;
            mnuClose.Click += closeToolStripMenuItem_Click;
            this.Load += new EventHandler(Form_load);
        }
        /// <summary>
        /// Use to monitor any changes in the Data Grid View cell
        /// </summary>
        private void dgvVehicelData_CellValueChanged(object sender, DataGridViewCellEventArgs  e)
        {
            dgvVehicelData.EndEdit();
            if(!this.Text.Contains("*"))
                this.Text = "* " + this.Text;
            mnuSave.Enabled = true;
        }

        /// <summary>
        /// Load the data to DGV from database when form loaded
        /// </summary>
        private void Form_load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
             table = _dataSet.Tables["VehicleStock"];
         
            _bindingSource.DataSource = table;

            dgvVehicelData.DataSource = _bindingSource;

            dgvVehicelData.Columns["ID"].Visible = false;
        }

        /// <summary>
        /// Monitor the selection change event
        /// </summary>
        private void dgvVehicelData_SelectionChanged(object sender, EventArgs e)
        {
            
            if(dgvVehicelData.SelectedRows.Count > 0 && dgvVehicelData.CurrentRow.Index != dgvVehicelData.NewRowIndex)
                mnuDelete.Enabled = true;
            else
                mnuDelete.Enabled = false;
        }

        /// <summary>
        /// Monitor the form close event
        /// </summary>
        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            if (this.Text != "Vehicle Data")
            {
                DialogResult result = MessageBox.Show("Do you wish to save the changes?",
                                "Save",
                                 MessageBoxButtons.YesNoCancel,
                                 MessageBoxIcon.Warning,
                                 MessageBoxDefaultButton.Button3);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _dataAdapter.Update(_dataSet, "VehicleStock");
                        this.Text = "Vehicle Data";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error occurred while saving the changes.Do you wan to close this window",
                                    "Deletion Error",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Error);
                        if (result == DialogResult.No)
                        {
                            e.Cancel = true;
                        }
                    }
                }
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Monitor the close button clike in the menu strip
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Monitor the delete button clike in the menu strip
        /// </summary>
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to permanently delete stock item?",
                            "Delete Stock Item",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Warning,
                             MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    dgvVehicelData.Rows.Remove(dgvVehicelData.CurrentRow);
                    if (!this.Text.Contains("*"))
                        this.Text = "* " + this.Text;
                    mnuSave.Enabled = true;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("An error occurred while deleting the selected vehicle",
                            "Deletion Error",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }  
        }

        /// <summary>
        /// Monitor the save button clike in the menu strip
        /// </summary>
        private void mnuSave_Click(object sender, EventArgs e)
        {
            dgvVehicelData.EndEdit();
            _bindingSource.EndEdit();
            try
            {
                _dataAdapter.Update(_dataSet, "VehicleStock");
                this.Text = "Vehicle Data";
                mnuSave.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while saving the changes to the vehicle data",
                           "Deletion Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Monitor the row update event
        /// </summary>
        void dataAdapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // When the update is an Insert (new record)
            if (e.StatementType == StatementType.Insert)
            {
                // Creates a new command
                // @@IDENTITY - a database value that returns the last-inserted identity 
                // (autonumber) value from the last statement
                OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", _dataAdapter.SelectCommand.Connection);
                // Assigns the ID value of the new row in the database to the DataColumn "ID" 
                // of the new
                // DataRow in the DataTable
                // ***
                // ExecuteScalar - Executes the command and returns the value of first column 
                // of the first row returned
                // e.Row - reference to the DataRow added to the DataTable
                // e.Row["ID"] - reference to the "ID" DataColumn in the DataRow
                e.Row["ID"] = (int)cmd.ExecuteScalar();
            }
        }

    }
}
