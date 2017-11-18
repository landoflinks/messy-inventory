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

        // Default constructor
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

        // Other possible constructors
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

        // getters and setters
        public int EmployeeNum { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Birthday { get; set; }
        public string Position { get; set; }
        public string Specialty { get; set; }
        public bool Active { get; set; }
    }
}
