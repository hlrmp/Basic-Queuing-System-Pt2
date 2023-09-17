using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Queuing_System_Pt2
{
    public partial class QueuingForm : Form
    {

        private CashierClass cashier;
        CashierWindowQueueForm cf;


        public QueuingForm()
        {

            InitializeComponent();

            cashier = new CashierClass();
            cf = new CashierWindowQueueForm();
            cf.Show();

        }

        private void btncashier_Click(object sender, EventArgs e)
        {

            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);


        }

    }
}
