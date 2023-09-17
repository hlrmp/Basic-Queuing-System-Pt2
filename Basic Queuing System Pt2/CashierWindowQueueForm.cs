using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Basic_Queuing_System_Pt2
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick_1);
            timer.Start();
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {

            DisplayCashierQueue(CashierClass.CashierQueue);
            //  listCashierQueue.Refresh();
        }
        Serving ser = new Serving();
        private object messageboxbuttons;

        private void btnnext_Click(object sender, EventArgs e)
        {
            try
            {
                ser.Show();

                if (CashierClass.CashierQueue.Count != 0)
                {

                    ser.lblserve.Text = CashierClass.CashierQueue.Peek();

                    CashierClass.CashierQueue.Dequeue();
                }
                else
                {
                    MessageBox.Show(" The list is empty  ", " FINISH ", MessageBoxButtons.OK);

                }


            }
            catch (Exception)
            {
                MessageBox.Show(" ERROR ", " ERROR ", MessageBoxButtons.OK);
              
            }

        }

    }
}
