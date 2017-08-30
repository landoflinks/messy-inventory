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
            string first;
            string last;
            string birthday;
            string position;
            string specialty;
            bool active;

            employeeNum = Convert.ToInt32(TxtEmployeeNum.Text);
            first = TxtFirstName.Text;
            last = TxtLastName.Text;
            birthday = TxtBirthday.Text;
            position = CmbPosition.Text;
            specialty = TxtSpecialty.Text;
            active = ChkActive.Checked;

            // Checking for required fields.
            if (first == "")
                {
                    MessageBox.Show("You must enter a first name for this employee!", "Error", MessageBoxButtons.OK,
                                       MessageBoxIcon.Stop);
                    return;
                }
            if (last == "")
            {
                MessageBox.Show("You must enter a last name for this employee!", "Error", MessageBoxButtons.OK,
                                   MessageBoxIcon.Stop);
                return;
            }
            if (birthday == "" || birthday == "01/01/17")
            {
                MessageBox.Show("You must enter a date of birth for this employee!", "Error", MessageBoxButtons.OK,
                                   MessageBoxIcon.Stop);
                return;
            }
        }
    }
}
