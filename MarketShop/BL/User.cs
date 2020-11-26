using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace MarketShop.BL
{
    class User
    {
        //Add Functions//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void ADDUser(int UserID, string UserName, string UserFullName, string UserPssword, string UserRole, double UserBasedMoney, string UserTel)
        {


            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@UserID", SqlDbType.Int);
            param[0].Value = UserID;

            param[1] = new SqlParameter("@UserName", SqlDbType.VarChar);
            param[1].Value = UserName;


            param[2] = new SqlParameter("@UserFullName", SqlDbType.VarChar);
            param[2].Value = UserFullName;


            param[3] = new SqlParameter("@UserPssword", SqlDbType.VarChar);
            param[3].Value = UserPssword;

            param[4] = new SqlParameter("@UserRole", SqlDbType.VarChar);
            param[4].Value = UserRole;

            param[5] = new SqlParameter("@UserBasedMoney", SqlDbType.Float);
            param[5].Value = UserBasedMoney;

            param[6] = new SqlParameter("@UserTel", SqlDbType.VarChar);
            param[6].Value = UserTel;



            dal.ExecuteComand("ADDUser", param);

            dal.close();

        }
        //End OF Add Functions///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




        //Get Functions/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public DataTable check_con()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.selectData("CheckCon", null);
            dal.close();
            return dt;


        }

        public DataTable GetALLUSers()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.selectData("GetALLUSers", null);
            dal.close();
            return dt;


        }

        public DataTable GetLastUserID()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.selectData("GetLastUserID", null);
            dal.close();
            return dt;


        }


        public DataTable SearchInUsers(string SearchWord)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SearchWord", SqlDbType.VarChar);
            param[0].Value = SearchWord;


            DataTable dt = new DataTable();
            dt = dal.selectData("SearchInUsers", param);
            dal.close();
            return dt;


        }

        public DataTable LogingIn(string UserName, string UserPssword)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar);
            param[0].Value = UserName;

            param[1] = new SqlParameter("@UserPssword", SqlDbType.VarChar);
            param[1].Value = UserPssword;

            DataTable dt = new DataTable();
            dt = dal.selectData("LogingIn", param);
            dal.close();
            return dt;


        }
        //End OF Get Functions///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////






        //Update Functions//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void UpdateUser(int UserID, string UserName, string UserFullName, string UserPssword, string UserRole, double UserBasedMoney, string UserTel)
        {


            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@UserID", SqlDbType.Int);
            param[0].Value = UserID;

            param[1] = new SqlParameter("@UserName", SqlDbType.VarChar);
            param[1].Value = UserName;


            param[2] = new SqlParameter("@UserFullName", SqlDbType.VarChar);
            param[2].Value = UserFullName;


            param[3] = new SqlParameter("@UserPssword", SqlDbType.VarChar);
            param[3].Value = UserPssword;

            param[4] = new SqlParameter("@UserRole", SqlDbType.VarChar);
            param[4].Value = UserRole;

            param[5] = new SqlParameter("@UserBasedMoney", SqlDbType.Float);
            param[5].Value = UserBasedMoney;

            param[6] = new SqlParameter("@UserTel", SqlDbType.VarChar);
            param[6].Value = UserTel;



            dal.ExecuteComand("UpdateUser", param);

            dal.close();
            //End OF Update Functions///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        }
    }
}
