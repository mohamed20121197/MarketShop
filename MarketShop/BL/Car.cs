using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MarketShop.BL
{

    class Car
    {
        //Add Functions//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void AddCar(string  CarID, string CarType, int UserID, string CarDetials)
        {

            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@CarID", SqlDbType.VarChar);
            param[0].Value = CarID;

            param[1] = new SqlParameter("@CarType", SqlDbType.VarChar, 100);
            param[1].Value = CarType;


            param[2] = new SqlParameter("@UserID", SqlDbType.Int);
            param[2].Value = UserID;


            param[3] = new SqlParameter("@CarDetials", SqlDbType.VarChar);
            param[3].Value = CarDetials;


            dal.ExecuteComand("AddCar", param);

            dal.close();

        }
        //End OF Add Functions///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Get Functions/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public DataTable GetALlCars()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();



            dt = dal.selectData("GetALlCars", null);
            return dt;


        }
        public DataTable SearchIncar(string SearchWord)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();


            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SearchWord ", SqlDbType.VarChar);
            param[0].Value = SearchWord;


            dt = dal.selectData("SearchIncar", param);
            return dt;


        }

        

        public DataTable GetCar(int  CarID)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();


            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CarID", SqlDbType.Int);
            param[0].Value = CarID;


            dt = dal.selectData("GetCar", param);
            return dt;


        }
        //End OF Get Functions///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        
        // Update Functions///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void UpdateCar(string CarID, string CarType, int UserID, string CarDetials)
        {

            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@CarID", SqlDbType.VarChar);
            param[0].Value = CarID;

            param[1] = new SqlParameter("@CarType", SqlDbType.VarChar, 100);
            param[1].Value = CarType;


            param[2] = new SqlParameter("@UserID", SqlDbType.Int);
            param[2].Value = UserID;


            param[3] = new SqlParameter("@CarDetials", SqlDbType.VarChar);
            param[3].Value = CarDetials;


            dal.ExecuteComand("UpdateCar", param);

            dal.close();

        }


        //End OF Update Functions///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Delete  Functions/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void DeleteCar(int CarID)
        {

            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CarID", SqlDbType.Int);
            param[0].Value = CarID;

            dal.ExecuteComand("DeleteCar", param);

            dal.close();

        }
        //End OF Delete Functions/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
