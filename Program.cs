using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login form
{
public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        if (username == "admin" && password == "password")
        {
            TuitionForm tuitionForm = new TuitionForm();
            tuitionForm.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Invalid username or password.");
        }
    }
}
