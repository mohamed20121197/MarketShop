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
    public partial class Products : Form
    {
        BL.Product pro = new BL.Product();

        public Products()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (this.Height == 750)
            {
                
                    this.Height=837;
                    BtnEdit.Text = "حفظ التعديل";
                    TxtProID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    TxtName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    TxtQte.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    TxtUnit.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    TxtPriceBuy.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    txtPriceSell.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            }
            else
            {
                pro.UpdateProduct(TxtProID.Text, TxtName.Text, Convert.ToInt32(TxtQte.Text), TxtUnit.Text, Convert.ToDouble(TxtPriceBuy.Text), Convert.ToDouble(txtPriceSell.Text));
                MessageBox.Show("تم تحديث البيانات بنجاح","تحديث",MessageBoxButtons.OK);
                dataGridView1.DataSource = pro.GetAllProducts();

                this.Height = 750;
                BtnEdit.Text = "تعديل";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearch.Text != string.Empty)
            {
                dataGridView1.DataSource = pro.SearchInProducts(TxtSearch.Text);

            }
            else
                dataGridView1.DataSource = pro.GetAllProducts();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            pro.DeletePro(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            MessageBox.Show("تم حذف المنتج بنجاح","حذف",MessageBoxButtons.OK);
            dataGridView1.DataSource = pro.GetAllProducts();
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            TxtSearch.Clear();

        }
    }
}
