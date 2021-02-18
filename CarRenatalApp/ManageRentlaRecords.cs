using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenatalApp
{
    public partial class ManageRentlaRecords : Form
    {
        private readonly CarRentalEntities1 _db;
        public ManageRentlaRecords()
        {
            InitializeComponent();
            _db = new CarRentalEntities1();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord
            {
                MdiParent = this.MdiParent
            };
            addRentalRecord.Show();
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // Get Id of selected row
                var id = (int)gvRecordList.SelectedRows[0].Cells["id"].Value;

                // Query database for record
                var record = _db.CarRentalRecord.FirstOrDefault(q => q.id == id);

                AddEditRentalRecord addEditRentalRecord = new AddEditRentalRecord(record);
                addEditRentalRecord.MdiParent = this.MdiParent;
                addEditRentalRecord.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // Get Id of selected row
                var id = (int)gvRecordList.SelectedRows[0].Cells["id"].Value;

                // Query database for record
                var record = _db.CarRentalRecord.FirstOrDefault(q => q.id == id);

                // delete vehicle from table
                _db.CarRentalRecord.Remove(record);
                _db.SaveChanges();

                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ManageRentlaRecords_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void PopulateGrid()
        {
            var records = _db.CarRentalRecord.Select(q => new
            {
                Customer = q.CustomerName,
                DateOut = q.DateRented,
                DateIn = q.DateReturned,
                Id = q.id,
                q.Cost,
                Car = q.TypesOfCars.Make + " " + q.TypesOfCars.Model
            }).ToList();

            gvRecordList.DataSource = records;
            gvRecordList.Columns["DateIn"].HeaderText = "Date In";
            gvRecordList.Columns["DateOut"].HeaderText = "Date Out";
            // Hide the column for ID. Changed from the hard coded column value to the name,
            // to make it more dinamic
            gvRecordList.Columns["id"].Visible = false;
        }
    }
}
