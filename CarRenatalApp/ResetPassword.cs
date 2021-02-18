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
    public partial class ResetPassword : Form
    {
        private readonly CarRentalEntities1 _db;
        private User _user;

        public ResetPassword(User user)
        {
            InitializeComponent();
            _db = new CarRentalEntities1();
            _user = user;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var password = tbPassword.Text;
                var confirmPassword = tbConfirmPassword.Text;
                var user = _db.Users.FirstOrDefault(q => q.id == _user.id);

                if (password != confirmPassword)
                {
                    MessageBox.Show("Password do not match. Please try again!");
                }

                user.password = Utils.HashPassword(password);
                _db.SaveChanges();

                MessageBox.Show("Password was resset successfully");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured. Please try again.");
                // throw;
            }
        }
    }
}
