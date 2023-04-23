using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _calss_name_.cs
{
    // Payment list form
    public partial class PaymentListForm : Form
    {
        public PaymentListForm(int numPaid)
        {
            InitializeComponent();

            for (int i = 1; i <= numPaid; i++)
            {
                listBox1.Items.Add("Person " + i);
            }
        }

        public object listBox1 { get; private set; }
    }