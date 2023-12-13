using System;

namespace EmployeeNamespace
{
    public class Employee
    {
        private int Id;
        private string firstName, lastName, position, department, email;

        public Employee(int id, string lastN, string firstN, string dept, string pos)
        {
            Id = id;
            firstName = firstN;
            lastName = lastN;
            position = pos;
            department = dept;
        }
        public Employee(int id, string lastN, string firstN, string dept, string pos, string eml)
        {
            Id = id;
            firstName = firstN;
            lastName = lastN;
            position = pos;
            department = dept;
            email = eml;
        }
         public int ID
        {
            get { return (int)Id; }
            set { Id = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
