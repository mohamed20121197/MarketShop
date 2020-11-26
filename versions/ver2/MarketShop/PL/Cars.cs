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
    public partial class Cars : Form
    {
        BL.Car car = new BL.Car();


        public void ClearData()
        {
            CarID.Clear();
            CarDetials.Clear();
            CarType.Clear();
            UserID.Clear();

        
        }
        public Cars()
        {
            InitializeComponent();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == false)
            {
                groupBox1.Enabled = true;
               ClearData();
              
                BtnNew.Text = "حفظ";
            }
            else
            {
                groupBox1.Enabled = false;
                car.AddCar(CarID.Text, CarType.Text, Convert.ToInt32(UserID.Text), CarDetials.Text);
                MessageBox.Show("تم حفظ البيانات بنجاح", "تمت الاضافه", MessageBoxButtons.OK);
                dataGridView1.DataSource = car.GetALlCars();

                BtnNew.Text = "جديد";
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == false)
            {
                groupBox1.Enabled = true;
                BtnEdit.Text = "حفظ التعديل";
            }
            else
            {
                groupBox1.Enabled = false;
                car.UpdateCar (CarID.Text, CarType.Text, Convert.ToInt32(UserID.Text), CarDetials.Text);
                MessageBox.Show("تم تحديث البيانات بنجاح", "تم التحديث", MessageBoxButtons.OK);
                dataGridView1.DataSource = car.GetALlCars(); 
                BtnEdit.Text = "تعديل";
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearch.Text != string.Empty)
            {
                dataGridView1.DataSource = car.SearchIncar(TxtSearch.Text);

            }
            else
                dataGridView1.DataSource = car.GetALlCars();
        }
    }
}
