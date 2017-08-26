using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messy_inventory
{
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
        }

        private void CmbSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button will submit the data.", "Test");
        }

        private void CmbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
