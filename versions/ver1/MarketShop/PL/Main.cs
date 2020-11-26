using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketShop
{
    public partial class Main : Form
    {
        BL.User user = new BL.User();
        BL.Car car = new BL.Car();
        BL.Expenses expen = new BL.Expenses();


        public Main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PL.Config frm = new PL.Config();

            frm.txt_server_name.Text = Properties.Settings.Default.Server;
             frm.txt_db.Text= Properties.Settings.Default.DataBase ;
      
            frm.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.Users frm = new PL.Users();
            frm.dataGridView1.DataSource = user.GetALLUSers();

            frm.ShowDialog();

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PL.Cars frm = new PL.Cars();
            frm.dataGridView1.DataSource = car.GetALlCars();

            frm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.Expenses frm = new PL.Expenses();

            frm.dataGridView1.DataSource = expen.GetALLExpensesBtweenDates(DateTime.Now.AddDays(-1), DateTime.Now);
            frm.ShowDialog();

        }
    }
}
