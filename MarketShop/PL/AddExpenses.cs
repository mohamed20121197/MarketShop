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
    public partial class AddExpenses : Form
    {
        BL.Expenses expen = new BL.Expenses();

        public AddExpenses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            expen.AddEcpenses(Convert.ToInt32(expen.GetLastExpensesID().Rows[0][0].ToString()), txtDetials.Text, DateTime.Now, Program.UserId, Convert.ToDouble(TxtCost.Text));
            MessageBox.Show("تمت الاضافه بنجاح","تم الحفظ",MessageBoxButtons.OK);
            this.Close();

        }
    }
}
