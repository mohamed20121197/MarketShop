using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace MarketShop.BL
{
    class Product
    {



        //Add Functions//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void AddNewProduct(string ProductID, string ProductName, int CurrentQte, string Unit, double LastPriceOfBuy, double PriceOfSell)
        {

            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@ProductID", SqlDbType.VarChar);
            param[0].Value = ProductID;

            param[1] = new SqlParameter("@ProductName", SqlDbType.VarChar, 50);
            param[1].Value = ProductName;


            param[2] = new SqlParameter("@CurrentQte", SqlDbType.Int);
            param[2].Value = CurrentQte;


            param[3] = new SqlParameter("@Unit", SqlDbType.VarChar);
            param[3].Value = Unit;

            param[4] = new SqlParameter("@LastPriceOfBuy", SqlDbType.Float);
            param[4].Value = LastPriceOfBuy;


            param[5] = new SqlParameter("@PriceOfSell", SqlDbType.Float);
            param[5].Value = PriceOfSell;


            dal.ExecuteComand("AddNewProduct", param);

            dal.close();

        }
        //End OF Add Functions///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        // Update Functions///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void UpdateProduct(string ProductID, string ProductName, int CurrentQte, string Unit, double LastPriceOfBuy, double PriceOfSell)
        {

            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@ProductID", SqlDbType.VarChar);
            param[0].Value = ProductID;

            param[1] = new SqlParameter("@ProductName", SqlDbType.VarChar, 50);
            param[1].Value = ProductName;


            param[2] = new SqlParameter("@CurrentQte", SqlDbType.Int);
            param[2].Value = CurrentQte;


            param[3] = new SqlParameter("@Unit", SqlDbType.VarChar);
            param[3].Value = Unit;

            param[4] = new SqlParameter("@LastPriceOfBuy", SqlDbType.Float);
            param[4].Value = LastPriceOfBuy;


            param[5] = new SqlParameter("@PriceOfSell", SqlDbType.Float);
            param[5].Value = PriceOfSell;


            dal.ExecuteComand("UpdateProduct", param);

            dal.close();

        }

        public void UpdateProductWhileBuying(string ProductID, int CurrentQte, double LastPriceOfBuy)
        {

            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@ProductID", SqlDbType.VarChar);
            param[0].Value = ProductID;

         

            param[1] = new SqlParameter("@CurrentQte", SqlDbType.Int);
            param[1].Value = CurrentQte;


            param[2] = new SqlParameter("@LastPriceOfBuy", SqlDbType.Float);
            param[2].Value = LastPriceOfBuy;



            dal.ExecuteComand("UpdateProductWhileBuying", param);

            dal.close();

        }



        public void UpdateProductWhileSelling(string ProductID, int CurrentQte)
        {

            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ProductID", SqlDbType.VarChar);
            param[0].Value = ProductID;



            param[1] = new SqlParameter("@CurrentQte", SqlDbType.Int);
            param[1].Value = CurrentQte;


          



            dal.ExecuteComand("UpdateProductWhileSelling", param);

            dal.close();

        }

        //End OF Update Functions///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





        //Get Functions/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public DataTable GetAllProducts()
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();



            dt = dal.selectData("GetAllProducts", null);
            return dt;


        }
        public DataTable SearchInProducts(string SearchWord)
        {
            DAL.DAL dal = new DAL.DAL();
            dal.open();
            DataTable dt = new DataTable();


            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SearchWord ", SqlDbType.VarChar);
            param[0].Value = SearchWord;


            dt = dal.selectData("SearchInProducts", param);
            return dt;


        }



        //End OF Get Functions///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        







        //Delete  Functions/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public void DeletePro(string ProductID)
        {

            DAL.DAL dal = new DAL.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ProductID", SqlDbType.Int);
            param[0].Value = ProductID;

            dal.ExecuteComand("DeletePro", param);

            dal.close();

        }
        //End OF Delete Functions/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}