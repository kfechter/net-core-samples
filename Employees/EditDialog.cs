using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Extensions;

namespace Employees
{
    public partial class EditDialog : Form
    {

        private Employee _employee = null;

        public Employee StaffMember
        {
            get
            {
                if (_employee == null)
                {
                    _employee = new Employee();
                }
                _employee.FirstName = txtFirstName.Text;
                _employee.LastName = txtLastName.Text;
                _employee.JobTitle = txtJobTitle.Text;
                return _employee;

            }
            set
            {
                _employee = value;
                txtFirstName.Text = _employee.FirstName;
                txtLastName.Text = _employee.LastName;
                txtJobTitle.Text = _employee.JobTitle;
            }

        }

        public EditDialog()
        {
            InitializeComponent();
        }
    }
}
