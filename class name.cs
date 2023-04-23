using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _class_name_.cs
{
    // Tuition form
    public partial class TuitionForm : Form
    {
        public TuitionForm()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Code to pay tuition

            int numPaid = 10; // Example number of people who paid tuition today

            PaymentListForm paymentListForm = new PaymentListForm(numPaid);
            paymentListForm.Show();
            this.Hide();
        }