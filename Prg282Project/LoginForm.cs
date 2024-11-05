using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prg282Project
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
           
            this.ControlBox = false; // Removes top exit, minimize and maximize
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void AdminLoginForm_Load_1(object sender, EventArgs e)
        {
            FileHandler.CreateLoginTxt();
            this.UserName.Text = ""; // Clear the username field
            this.Password.Text = ""; // Clear the password field
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            
        }

        private void AdminLoginButtom_Click(object sender, EventArgs e)
        {
            string userNameValidate = UserName.Text;
            string passwordValidate = Password.Text;

            FileHandler.ValidateAdmin(userNameValidate, passwordValidate);
        }

    }
}
