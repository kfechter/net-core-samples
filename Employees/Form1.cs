using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Extensions;

namespace Employees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditDialog newEmployeeDialog = new EditDialog();
            if (newEmployeeDialog.ShowDialog() == DialogResult.OK)
            {
                lstEmployees.Items.Add(newEmployeeDialog.StaffMember);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedIndex == -1)
                return;

            int employeeNum = lstEmployees.SelectedIndex;
            EditDialog newEmployeeDialog = new EditDialog();
            newEmployeeDialog.StaffMember = (Employee)lstEmployees.SelectedItem;

            if (newEmployeeDialog.ShowDialog() == DialogResult.OK)
            {
                lstEmployees.Items.RemoveAt(employeeNum);
                lstEmployees.Items.Insert(employeeNum, newEmployeeDialog.StaffMember);
                lstEmployees.SelectedIndex = employeeNum;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedIndex == -1)

                return;


            else if (MessageBox.Show("Really delete Employee " + lstEmployees.SelectedItem, "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lstEmployees.Items.Remove(lstEmployees.SelectedItem);
            }
        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedIndex != -1)
            {
                Employee curentEmployee = (Employee)lstEmployees.SelectedItem;
                txtFirstName.Text = curentEmployee.FirstName;
                txtLastName.Text = curentEmployee.LastName;
                txtJobTitle.Text = curentEmployee.JobTitle;
            }
            else
            {
                txtFirstName.Text = txtLastName.Text = txtJobTitle.Text = "";
            }
        }
    }
}
