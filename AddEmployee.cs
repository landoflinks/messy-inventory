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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void CmbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmbSubmit_Click(object sender, EventArgs e)
        {
            int employeeNum;
            string firstName;
            string lastName;
            string birthday;
            string position;
            string specialty;
            bool active;

            employeeNum = Convert.ToInt32(TxtEmployeeNum.Text);
            firstName = TxtFirstName.Text;
            lastName = TxtLastName.Text;
            birthday = TxtBirthday.Text;
            position = CmbPosition.Text;
            specialty = TxtSpecialty.Text;
            active = ChkActive.Checked;
        }
    }
}
