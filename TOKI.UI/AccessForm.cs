using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOKI.UI
{
    public partial class AccessForm : Form
    {
        public AccessForm()
        {
            InitializeComponent();
        }

        private void AccessForm_Load(object sender, EventArgs e)
        {
            Context db = new Context();
            AppUser user = new AppUser();
            if (db.AppUsers.Any(x=>x.UserName== "admin@gmail.com"))
            {

            }
            else
            {
                user.UserName = "admin@gmail.com";
                user.Password = "admin";
                user.FirstName = "Admin";
                user.LastName = "Admin";
                db.AppUsers.Add(user);
                db.SaveChanges();
            }

            txtEmail.Text = "admin";
            txtEmailAddress.Text = "gmail";
            txtPassword.Text = "admin";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email1 = txtEmail.Text;
            string email2 = txtEmailAddress.Text;
            string email = email1 + "@" + email2 + ".com";
            string password = txtPassword.Text;
            Context db = new Context();
            if (db.AppUsers.Any(x => x.UserName == email))
            {
               var user =  db.AppUsers.FirstOrDefault(x=>x.UserName==email);
                if (user.Password==password)
                {
                    Form1 f = new Form1(user);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The password is not valid!");
                }
            }
            else
            {
                MessageBox.Show("The email doesn't exist! Register now!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Context db = new Context();
            AppUser user = new AppUser();
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.UserName = txtMail.Text + "@" + txtEmaill.Text + ".com";


            string password = txtPasswordd.Text.Trim();
            HashSet<char> specialCharacters = new HashSet<char>() { '%', '$', '#', '.', '@', '*', '!', '-' };

            if (password.Any(char.IsLower) && password.Any(char.IsDigit) && (password.Length >= 8) && password.Any(specialCharacters.Contains))
            {
                user.Password = txtPasswordd.Text.Trim();
            }
            else
            {
                MessageBox.Show("The Password is Not Valid! \n Has minimum 8 characters in length.\n At least one lowercase English letter.\n At least one digit. \n At least one special character.");
            }
            db.AppUsers.Add(user);
            db.SaveChanges();
        }
    }
}
