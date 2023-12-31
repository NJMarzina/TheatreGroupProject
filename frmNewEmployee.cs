﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS3309_TheatreGroupProject
{
    public partial class frmNewEmployee : Form
    {
        String connectionStringEmployees = "provider = Microsoft.ACE.OLEDB.12.0; Data Source = Employees.accdb;";

        OleDbConnection myConnection;
        OleDbCommand myCommand;
        OleDbDataReader myReader;
        OleDbDataAdapter myAdapter;
        DataTable employeeTable;
        public frmNewEmployee()
        {
            InitializeComponent();
        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            emp.addEmployee(tbFullName.Text, tbUsername.Text, tbPassword.Text);

            MessageBox.Show(tbFullName.Text + " your employee account has been successfully added.");

            tbFullName.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
        }
    }
}
