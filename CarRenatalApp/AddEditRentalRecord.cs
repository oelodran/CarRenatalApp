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
    public partial class AddEditRentalRecord : Form
    {
        private bool isEditMode;
        private readonly CarRentalEntities1 _db;
        public AddEditRentalRecord()
        {
            InitializeComponent();
            labTitle.Text = "Add New Rental Record";
            this.Text = "Add New Rental Record";
            isEditMode = false;
            _db = new CarRentalEntities1();
        }

        public AddEditRentalRecord(CarRentalRecord recordToEdit)
        {
            InitializeComponent();
            labTitle.Text = "Edit Rental Record";
            this.Text = "Edit Rental Record";
            if (recordToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new CarRentalEntities1();
                PopulateFields(recordToEdit);
            }
        }

        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            tbCustomerName.Text = recordToEdit.CustomerName;
            dtRented.Value = (DateTime)recordToEdit.DateRented;
            dtReturned.Value = (DateTime)recordToEdit.DateReturned;
            tbCost.Text = recordToEdit.Cost.ToString();
            labRecordId.Text = recordToEdit.id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = tbCustomerName.Text;
                var dateOut = dtRented.Value;
                var dateIn = dtReturned.Value;
                double cost = Convert.ToDouble(tbCost.Text);

                var carType = cbTypeOfCar.Text;
                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter missing data.\n\r";
                }

                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMessage += "Error: Illegal date selection.\n\r";
                }

                if (isValid)
                {
                    // Declare an object of the record to be added
                    var rentalRecord = new CarRentalRecord();

                    if (isEditMode)
                    {
                        // If edit mode, then get ID and retrive the record from the database
                        // and platc the result in the record object
                        var id = int.Parse(labRecordId.Text);
                        rentalRecord = _db.CarRentalRecord.FirstOrDefault(q => q.id == id);
                    }

                    // Populate record object with valuse from the form
                    rentalRecord.CustomerName = customerName;
                    rentalRecord.DateRented = dateOut;
                    rentalRecord.DateReturned = dateIn;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.TypeOfCarId = (int)cbTypeOfCar.SelectedValue;

                    // If not in edit mode, then add record object to the database 
                    if (!isEditMode)
                    {
                        _db.CarRentalRecord.Add(rentalRecord);
                    }

                    // Save changes made to the entity
                    _db.SaveChanges();

                        MessageBox.Show($"Customer Name: {customerName}\n\r" +
                            $"Date Rented: {dateOut}\n\r" +
                            $"Date Returned: {dateIn}\n\r" +
                            $"Cost: {cost}\n\r" +
                            $"Car Type: {carType}\n\r" +
                            $"THANK YOU FORU YOUR BUSINESS.");                    
                
                        Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // SELECT * FROM TypesFoCars
            // var cars = carRentalEntities.TypesOfCars.ToList();
            var cars = _db.TypesOfCars
                .Select(q => new { Id = q.id, Name = q.Make + " " + q.Model })
                .ToList();

            cbTypeOfCar.DisplayMember = "Name";
            cbTypeOfCar.ValueMember = "id";
            cbTypeOfCar.DataSource = cars;
        }
    }
}
