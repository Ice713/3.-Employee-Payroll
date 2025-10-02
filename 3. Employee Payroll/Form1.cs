using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Employee_Payroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager(textBoxName.Text, Convert.ToDouble(numericUpDownSalary.Text), textBoxDepartment.Text);

            string details = manager.GetDetails();

            MessageBox.Show(details, "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
