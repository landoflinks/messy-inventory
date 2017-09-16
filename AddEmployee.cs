using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            // Submits new employee.
            int employeeNum;
            string first;
            string last;
            string birthday;
            string position;
            string specialty;
            string rowData;
            bool active;

            employeeNum = int.Parse(TxtEmployeeNum.Text);
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
            if (active == false)
            {
                DialogResult msgReply = MessageBox.Show("This employee has not been marked active! Should they be?",
                    "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (msgReply == DialogResult.Yes)
                {
                    ChkActive.Checked = true;
                    active = ChkActive.Checked;
                }
            }

            // Logic to determine which class object to use. Will also need revising.
            if (employeeNum == 0 && position == "" && specialty == "")
            {
                Employee newEmployee = new Employee(first, last, birthday);
            }
            else if (employeeNum == 0 && position == "")
            {
                Employee newEmployee = new Employee(first, last, birthday, specialty);
            }
            else
            {
                Employee newEmployee = new Employee(employeeNum, first, last, birthday, position, specialty);
            }

            rowData = "Employee #: " + Convert.ToString(employeeNum) + ", First Name: " + first +
               ", Last Name: " + last + ", Birthday: " + birthday +
               ", Position: " + position + ", Specialty: " + specialty + ", Active: " + active ;

            // Save employee data to file
            try
            {
                StreamWriter writeFile = new StreamWriter("employees");
                writeFile.WriteLine(rowData);
                writeFile.Close();
            }
            catch
            {
                MessageBox.Show("The employee file could not be accessed.", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Stop);
            };

            Close();
        }
    }
}
