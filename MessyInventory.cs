﻿using System;
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
    public partial class FrmInventory : Form
    {
        public FrmInventory()
        {
            InitializeComponent();
        }

        private void CmdShowInventory_Click(object sender, EventArgs e)
        {
            // Loads data into datagrid.
            MessageBox.Show("This button currently does nothing of use.", "Test Message");
        }

        private void CmbEmployeeList_Click(object sender, EventArgs e)
        {
            // Lists current employees and their positions in a pop-up.
            MessageBox.Show("This button currently lists nothing.", "Another Test Message");
        }

        private void CmdAddEmployee_Click(object sender, EventArgs e)
        {
            // Calls AddEmployee object.
            AddEmployee newEmployee = new AddEmployee();
            newEmployee.Show();
        }

        private void CmdAddGame_Click(object sender, EventArgs e)
        {
            // Calls AddGame object.
            AddGame newGame = new AddGame();
            newGame.Show();
        }
    }
}
