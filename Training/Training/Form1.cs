using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training
{
    public partial class Form1 : Form
    {
        public Form1ViewModel Form1ViewModel { get; }
        public Form1()
        {
            InitializeComponent();
            Form1ViewModel = new Form1ViewModel();

            bsEmployee.DataSource = Form1ViewModel.LoadEmployees();

            dgvPersons.AutoGenerateColumns = true;
            dgvPersons.DataSource = Form1ViewModel.LoadPersons();
            dgvPersons.DataMember = "Person";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvPersons.DataSource = Form1ViewModel.FilterPersons(textBox1.Text);
        }
    }
}
