using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F3_Excercise_1
{
    /// <summary>
    /// 1. Lägg Namn och Lön i två arrayer
    /// 2. Visa arrayernas värden i en ListBox
    /// 3. Bryt ut till Metod
    /// 4. Byt array till List
    /// 5. Byt två List mot en List av en struct (Employee)
    /// 6. Lägg till knapp för att ta bort markerad
    /// 7. Vid markerad, visa mer information i label
    /// </summary>
    public partial class Form1 : Form
    {
        struct Employee
        {
            public string Name;
            public decimal Salary;

            public override string ToString()
            {
                return $"N: {Name}, S: {Salary}";
            }
        }

        private List<Employee> employees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var name = txtName.Text;
                Validate(name, 5);
                var salary = txtSalary.Text;
                Validate(salary, 3);
                var salaryAsDecimal = decimal.Parse(salary);

                var employee = AddEmployee(name, salaryAsDecimal);

                lstEmployees.Items.Add(employee);
            }
            catch (ApplicationException exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void Validate(string name, int minChars)
        {
            if (name.Length < minChars)
                throw new ApplicationException("För få bokstäver");

        }

        private Employee AddEmployee(string name, decimal salaryAsDecimal)
        {
            var employee = new Employee
            {
                Name = name,
                Salary = salaryAsDecimal
            };
            employees.Add(employee);

            return employee;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (var item in lstEmployees.SelectedItems)
            {
                var employee = (Employee)item;
                employees.Remove(employee);
            }

            lstEmployees.Items.Clear();
            foreach (var employee in employees)
            {
                lstEmployees.Items.Add(employee);
            }
            
        }
    }
}
