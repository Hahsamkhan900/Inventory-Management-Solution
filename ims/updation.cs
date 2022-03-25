using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ims
{
    class updation
    {
        public void updateUser(int id,string name, string username, string pass, string email, string phone,Int16 status)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_updateUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pass);
                cmd.Parameters.AddWithValue("@phone", email);
                cmd.Parameters.AddWithValue("@email", phone);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(name  + " Updated into the System Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }

        public void updateCategory(int id,string name, Int16 status)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                cmd.Parameters.AddWithValue("@id", id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(name + " Updated into the System Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }


        public void updateProduct(int id, string proName, string proModelNo, string date,int catID)
        {
            
            try
            {

                SqlCommand cmd = new SqlCommand("st_updateProducts", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Parameters.AddWithValue("@prdt_Name", proName);
                cmd.Parameters.AddWithValue("@prdt_ModelNo", proModelNo);
                cmd.Parameters.AddWithValue("@prdt_Date", date);
                cmd.Parameters.AddWithValue("@prdt_id", id);
                cmd.Parameters.AddWithValue("@prdt_catID", catID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(proName + " Updated into the System Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }

        public void updateSupplier(int supid,string supplierName, string phoneNo1, Int16 status, int compID, string phoneNo2 = null,string email = null)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_upateSuppliers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sup_SupplierName", supplierName);
                cmd.Parameters.AddWithValue("@sup_compID", compID);
                cmd.Parameters.AddWithValue("@sup_PhoneNo1", phoneNo1);
                if (phoneNo2 == null)
                {
                    cmd.Parameters.AddWithValue("@sup_PhoneNo2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@sup_PhoneNo2", phoneNo2);
                }
                if (email == null)
                {
                    cmd.Parameters.AddWithValue("@sup_email", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@sup_email", email);
                }
                cmd.Parameters.AddWithValue("@sup_Status", status);
                cmd.Parameters.AddWithValue("@sup_ID", supid);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(supplierName + " Updated into the System Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }

        public void updateCompany(int id, string name, string address, string phone1,   Int16 status, string phone2 = null, string ntn =null)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_updateCompany", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@comp_Name", name);
                cmd.Parameters.AddWithValue("@comp_Address", address);
                cmd.Parameters.AddWithValue("@comp_phoneNo1", phone1);
                if (phone2 == null)
                {
                    cmd.Parameters.AddWithValue("@comp_phoneNo2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@comp_phoneNo2", phone2);
                }
                if (ntn == null)
                {
                    cmd.Parameters.AddWithValue("@comp_Ntn", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@comp_Ntn", ntn);
                }
                cmd.Parameters.AddWithValue("@comp_ID", id);
                cmd.Parameters.AddWithValue("@comp_Status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(name + " Updated into the System Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }
        public void updatetStock(int proID, int qty)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", qty);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }
        public void updatetStockWithoutConnection(int proID, int qty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", qty);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }

        public void updateProductPrice(int proID, float bp,float profitPer=0,float discount=0,float sp=0)
        {
            try
            {
                SqlCommand cmd;
                if (profitPer == 0 && discount == 0 && sp ==0)
                {
                    cmd = new SqlCommand("st_updateProductPrice1", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@proID", proID);
                    cmd.Parameters.AddWithValue("@buyingPrice", bp);
                }
                else
                {
                    cmd = new SqlCommand("st_updateProductPrice", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@proID", proID);
                    cmd.Parameters.AddWithValue("@buyingPrice", bp);
                    cmd.Parameters.AddWithValue("@sellingPrice", sp);
                    cmd.Parameters.AddWithValue("@profitPer", profitPer);
                    cmd.Parameters.AddWithValue("@disount", discount);
                }
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }


    }
}
