using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messy_inventory
{
    public class Employee
    {
        private int employeeNum;
        private string first;
        private string last;
        private string birthday;
        private string position;
        private string specialty;
        private bool active;

        public Employee()
        {
            employeeNum = 0;
            first = "";
            last = "";
            birthday = "";
            position = "Clerk";
            specialty = "";
            active = true;
        }

        public Employee(string firstName, string lastName, string dayOfBirth)
        {
            first = firstName;
            last = lastName;
            birthday = dayOfBirth;
        }

        public Employee(string firstName, string lastName, string dayOfBirth, string expert)
        {
            first = firstName;
            last = lastName;
            birthday = dayOfBirth;
            specialty = expert;
        }

        public Employee(int employeeId, string firstName, string lastName,
            string dayOfBirth, string startPosition, string expert)
        {
            employeeNum = employeeId;
            first = firstName;
            last = lastName;
            birthday = dayOfBirth;
            position = startPosition;
            specialty = expert;
        }
    }
}
