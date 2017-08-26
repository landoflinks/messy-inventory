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
            price = (float)Convert.ToInt32(TxtPrice.Text);

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

            if (developer == "" && publisher == "" && condition == "")
            {
                GameData newGame = new GameData(title, console);
            }
            else if (developer == "" && publisher == "")
            {
                GameData newGame = new GameData(title, console, condition, price);
            }
            else
            {
                GameData newGame = new GameData(title, console, developer, publisher, condition, price);
            }

            MessageBox.Show("Title: " + title + " Console: " + console +
               " Developer: " + developer + " Publisher: " + publisher +
               " Condition: " + condition + " Price: " + Convert.ToString(price), "Test");
        }

        private void CmbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
