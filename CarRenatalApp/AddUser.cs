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
    public partial class AddUser : Form
    {
        private readonly CarRentalEntities1 _db;
        private ManageUsers _manageUsers;
        public AddUser(ManageUsers mangeUsers)
        {
            InitializeComponent();
            _db = new CarRentalEntities1();
            _manageUsers = mangeUsers;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = _db.Roles.ToList();
            cbRoles.DataSource = roles;
            cbRoles.ValueMember = "id";
            cbRoles.DisplayMember = "name";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var username = tbUsername.Text;
                var roleId = (int)cbRoles.SelectedValue;
                var password = Utils.DefaultHashPassword();
                var user = new User
                {
                    username = username,
                    password = password,
                    isActive = true
                };

                _db.Users.Add(user);
                _db.SaveChanges();

                var userid = user.id;

                var userRorle = new UserRole
                {
                    roleid = roleId,
                    userid = userid
                };

                _db.UserRoles.Add(userRorle);
                _db.SaveChanges();

                MessageBox.Show("New user added successfully.");
                _manageUsers.PopulateGrid();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured.");
            }
        }
    }
}
