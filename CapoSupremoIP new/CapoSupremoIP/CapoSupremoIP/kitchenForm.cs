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
    public partial class kitchenForm : Form
    {
        public kitchenForm()
        {
            InitializeComponent();
        }

        private void kitchenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 mainScreen = new Form1();
            mainScreen.Visible = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
