using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_flights
{
    public partial class frmFlightPassangers : Form
    {
        //DataTable MongoDBResultTable = new DataTable();
        DataTable MySQLResultTable = new DataTable();
        Passanger selectedRowPassanger = new Passanger();

        private void DB_LoadPassengers()
            => dgrdPassengers.DataSource = DatabaseAccess.DB_GetData(MySQLResultTable);

        public frmFlightPassangers()
        {
            InitializeComponent();
            DB_LoadPassengers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Passanger passanger = new Passanger();
            passanger.name = txt_name.Text;
            passanger.age = txt_age.Text;
            if (DatabaseAccess.DB_SaveData(passanger)) DB_LoadPassengers(); //Reload table from database after write
        }

        private void dataGrid_passengers_CellClick(object sender, DataGridViewCellEventArgs e)
            => dataGrid_passengersGetCurrentRow();
        private void dataGrid_passengers_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
            => dataGrid_passengersGetCurrentRow();
        private void dataGrid_passengersGetCurrentRow() 
        {
            try
            {
                selectedRowPassanger = DatabaseAccess.getCorrentRow(dgrdPassengers);
                txtNameUpdate.Text = (string)selectedRowPassanger.name;
                txtAgeUpdate.Text = (string)selectedRowPassanger.age;
            }
            catch (Exception ex) { }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if( DatabaseAccess.DB_DeleteData(selectedRowPassanger) ) DB_LoadPassengers();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Passanger values = new Passanger();
            values.name = txtNameUpdate.Text;
            values.age = txtAgeUpdate.Text;
            if( DatabaseAccess.DB_UpdateData(selectedRowPassanger, values) ) DB_LoadPassengers();
        }

    }
}
