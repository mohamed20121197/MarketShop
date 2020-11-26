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
    public partial class LogIn : Form
    {
        BL.User user = new BL.User();

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "1" && txtPassword.Text == "1")
            {
                Config frm = new Config();

                frm.txt_server_name.Text = MarketShop.Properties.Settings.Default.Server;
                frm.txt_db.Text = MarketShop.Properties.Settings.Default.DataBase;

            
                frm.ShowDialog();


            }
                



            else if (  txtUserName.Text != string.Empty && txtPassword.Text!=string.Empty && user.LogingIn(txtUserName.Text, txtPassword.Text).Rows.Count > 0)
            
                
                {

                    Main frm = new Main();
                    Program.UserName = user.LogingIn(txtUserName.Text, txtPassword.Text).Rows[0][2].ToString();
                    Program.UserRole = user.LogingIn(txtUserName.Text, txtPassword.Text).Rows[0][3].ToString();
                Program.UserId=Convert.ToInt32(user.LogingIn(txtUserName.Text, txtPassword.Text).Rows[0][1].ToString());

                    frm.ShowDialog();
                }

            else

            {
            MessageBox.Show("اسم المستخدم وكلمة المرور غير صحيحه يرجي التأكد من البيانات","خطأ في الوصول كود رقم 1 ",MessageBoxButtons.OK);
            }


            }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
        }
    }

