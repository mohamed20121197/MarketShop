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
    public partial class Users : Form
    {
        public void ClearData()
        {
        UserID.Clear();
            TxtUserName.Clear();
            TxtUserPass.Clear();
            TxtFullName.Clear();
            TxtTel.Clear();
            TxtBaseMoney.Clear();
            ComboRole.Text=" ";
        }
        BL.User user = new BL.User();

        public Users()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == false)
            {
                groupBox1.Enabled = true;
                ClearData();
                UserID.Text=user.GetLastUserID().Rows[0][0].ToString();

                 BtnNew.Text = "حفظ";
                 BtnEdit.Enabled = false;

            }
            else
            {
                groupBox1.Enabled = false;
                user.ADDUser(Convert.ToInt32(UserID.Text), TxtUserName.Text, TxtFullName.Text, TxtUserPass.Text, ComboRole.Text, Convert.ToDouble(TxtBaseMoney.Text), TxtTel.Text);
                MessageBox.Show("تم حفظ البيانات بنجاح", "تمت الاضافه", MessageBoxButtons.OK);
                dataGridView1.DataSource = user.GetALLUSers();

                BtnNew.Text = "جديد";
                BtnEdit.Enabled = true;
            }
        }


        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearch.Text != string.Empty)
            {
                dataGridView1.DataSource = user.SearchInUsers(TxtSearch.Text);

            }
            else
                dataGridView1.DataSource = user.GetALLUSers();

        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            TxtSearch.Clear();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != string.Empty)
            {
                UserID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TxtUserName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                TxtUserPass.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                TxtFullName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                TxtTel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                TxtBaseMoney.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                ComboRole.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == false)
            {
                groupBox1.Enabled = true;
                BtnEdit.Text = "حفظ التعديل";
                BtnNew.Enabled = false;

            }
            else
            {
                groupBox1.Enabled = false;
                user.UpdateUser(Convert.ToInt32(UserID.Text), TxtUserName.Text, TxtFullName.Text, TxtUserPass.Text, ComboRole.Text, Convert.ToDouble(TxtBaseMoney.Text), TxtTel.Text);
                MessageBox.Show("تم تحديث البيانات بنجاح", "تم التحديث", MessageBoxButtons.OK);
                dataGridView1.DataSource = user.GetALLUSers();
                BtnEdit.Text = "تعديل";
                BtnNew.Enabled = true;
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }
    }
}
