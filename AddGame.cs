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
            string title;
            string console;
            string developer;
            string publisher;
            string condition;
            float price;

            title = TxtTitle.Text;
            console = TxtConsole.Text;
            developer = TxtDeveloper.Text;
            publisher = TxtPublisher.Text;
            condition = CmbCondition.Text;
            //price = Convert.ToInt32(TxtPrice.Text);

            if (title == "")
            {
                MessageBox.Show("You must enter a title!", "Error", MessageBoxButtons.OK,
                                   MessageBoxIcon.Stop);
                return;
            }
            if (console == "")
            {
                MessageBox.Show("You must enter a game console!", "Error", MessageBoxButtons.OK,
                                   MessageBoxIcon.Stop);
                return;
            }
        }

        private void CmbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
