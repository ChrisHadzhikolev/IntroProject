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
    public partial class Form1 : Form
    {
        bool kitchen_enabled = false;
        bool cash_desk_enabled = false;

        private kitchenForm kForm;
        private CashDeskForm cdForm;
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            kForm = new kitchenForm();
            kForm.Show();
            this.Visible = false;
        }

        private void btnCashDesk_Click(object sender, EventArgs e)
        {
            cdForm = new CashDeskForm();
            cdForm.Show();
            this.Visible = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
