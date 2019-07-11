using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Donny
{
    public partial class Form1 : Form
    {
        Northwind db = new Northwind();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dGVEmployee.DataSource = db.GetAllEmployees();
        }

        private void DGVEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int EmployeeID = Convert.ToInt32(dGVEmployee.CurrentRow.Cells[0].Value.ToString());
            dGVOrder.DataSource = db.GetAllOrders(EmployeeID);
        }
    }
}
