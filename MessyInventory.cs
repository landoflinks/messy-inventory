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
        // The following two lists are temporary until a proper database is established.
        public List<GameData> games = new List<GameData>
        {
            // new GameData{Constructor params}, ...;
        };

        public List<Employee> employees = new List<Employee>
        {
            // new Employee{Constructor params}, ...;
        };

        public frmInventory()
        {
            InitializeComponent();
        }

        private void CmdShowInventory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button currently does nothing of use.", "Test Message");
        }

        private void CmbEmployeeList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button currently lists nothing.", "Another Test Message");
        }

        private void CmdAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee newEmployee = new AddEmployee();
            newEmployee.Show();
        }

        private void CmdAddGame_Click(object sender, EventArgs e)
        {
            AddGame newGame = new AddGame();
            newGame.Show();
        }
    }
}
