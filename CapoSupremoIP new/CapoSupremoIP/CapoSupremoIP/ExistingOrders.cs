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
    public partial class ExistingOrders : Form
    {
        public ExistingOrders()
        {
            InitializeComponent();
        }

        private void ExistingOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            CashDeskForm cashDeskMainScreen = new CashDeskForm();
            cashDeskMainScreen.Visible = true;
        }
    }
}
