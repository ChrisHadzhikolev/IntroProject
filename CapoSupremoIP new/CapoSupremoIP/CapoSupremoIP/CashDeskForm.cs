using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapoSupremoIP
{
    public partial class CashDeskForm : Form
    {
        public CashDeskForm()
        {
            InitializeComponent();
        }

        private void CashDeskForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 mainScreen = new Form1();
            mainScreen.Visible = true;
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            newOrderForm newOrderForm= new newOrderForm();
            newOrderForm.Show();
            this.Visible = false;
        }

        private void btnExistingOrders_Click(object sender, EventArgs e)
        {
            ExistingOrders existingOrders = new ExistingOrders();
            existingOrders.Show();
            this.Visible = false;
        }
    }
}
