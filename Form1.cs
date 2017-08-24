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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void CmdShowInventory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button currently does nothing.", "Test Message");
        }

        private void CmdAddEmployee_Click(object sender, EventArgs e)
        {

        }

        private void CmdAddGame_Click(object sender, EventArgs e)
        {
            AddGame newGame = new AddGame();
            newGame.Show();
        }
    }
}
