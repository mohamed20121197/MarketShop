using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketShop.PL
{
    public partial class Expenses : Form
    {
        BL.Expenses expen = new BL.Expenses();

        public Expenses()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.AddExpenses frm = new AddExpenses();
            frm.txtdate.Text = DateTime.Now.ToString();
            frm.txtUserName.Text = Program.UserName;
            frm.ShowDialog();


        }

        private void Expenses_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            expen.DeleteExpenses(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
            MessageBox.Show("تم الحذف بنجاح", "تم الحذف", MessageBoxButtons.OK);
            dataGridView1.DataSource = expen.GetALLExpensesBtweenDates(dateTimePicker1.Value, dateTimePicker2.Value);

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = expen.GetALLExpensesBtweenDates(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = expen.GetALLExpensesBtweenDates(dateTimePicker1.Value, dateTimePicker2.Value);
        }
    }
}
