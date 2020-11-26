using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MarketShop.BL
{
    class Expenses
    {
        //Add Functions//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void AddEcpenses(int ExpensesID,string ExpensesDetials,DateTime ExpensesDate ,int UserID, double CostMoney)
        {

            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[]  param = new SqlParameter[5];

            param[0] = new SqlParameter("@ExpensesID", SqlDbType.Int);
            param[0].Value = ExpensesID;

            param[1] = new SqlParameter("@ExpensesDetials", SqlDbType.VarChar,100);
            param[1].Value = ExpensesDetials;

     
            param[2] = new SqlParameter("@ExpensesDate", SqlDbType.DateTime);
            param[2].Value = ExpensesDate;


            param[3] = new SqlParameter("@UserID", SqlDbType.Int);
            param[3].Value = UserID;



            param[4] = new SqlParameter("@CostMoney", SqlDbType.Float);
            param[4].Value = CostMoney;

            dal.ExecuteComand("AddEcpenses", param);
           
            dal.close();
        
        }
        //End OF Add Functions///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Get Functions/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public DataTable GetALLExpensesBtweenDates(DateTime DateFrom,DateTime DateTo)

        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt=new DataTable();


            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@DateFrom", SqlDbType.DateTime);
            param[0].Value = DateFrom;

            param[1] = new SqlParameter("@DateTo", SqlDbType.DateTime);
            param[1].Value = DateTo;
          
            
            
          dt=  dal.selectData("GetALLExpensesBtweenDates", param);
          return dt;

        
        }

        public DataTable GetALLExpensesOfUser(int UserID)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();


            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@UserID", SqlDbType.Int);
            param[0].Value = UserID;



            dt = dal.selectData("GetALLExpensesOfUser", param);
            return dt;


        }

        public DataTable SearchInExpenses(string SearchWord)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();


            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SearchWord", SqlDbType.VarChar);
            param[0].Value = SearchWord;



            dt = dal.selectData("SearchInExpenses", param);
            return dt;


        }
        public DataTable GetLastExpensesID()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.selectData("GetLastExpensesID", null);
            dal.close();
            return dt;


        }
              //End OF Get Functions///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        //Update Functions///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




        public void UpdateEcpenses(int ExpensesID, string ExpensesDetials, DateTime ExpensesDate, int UserID, double CostMoney)
        {

            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@ExpensesID", SqlDbType.Int);
            param[0].Value = ExpensesID;

            param[1] = new SqlParameter("@ExpensesDetials", SqlDbType.VarChar, 100);
            param[1].Value = ExpensesDetials;


            param[2] = new SqlParameter("@ExpensesDate", SqlDbType.DateTime);
            param[2].Value = ExpensesDate;


            param[3] = new SqlParameter("@UserID", SqlDbType.Int);
            param[3].Value = UserID;



            param[4] = new SqlParameter("@CostMoney", SqlDbType.Float);
            param[4].Value = CostMoney;

            dal.ExecuteComand("UpdateEcpenses", param);

            dal.close();

        }

        //End OF Update Functions/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

     
        //Delete  Functions/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void DeleteExpenses(int ExpensesID)
        {

            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ExpensesID", SqlDbType.Int);
            param[0].Value = ExpensesID;

            dal.ExecuteComand("DeleteExpenses", param);

            dal.close();

        }
        //End OF Delete Functions/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    }
}
