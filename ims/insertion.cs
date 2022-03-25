using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace ims
{
    class insertion
    {
        public void insertUser(string name, string username, string pass, string email, string phone, Int16 status ) 
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure; 
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@username",username);
                cmd.Parameters.AddWithValue("@pwd",pass);
                cmd.Parameters.AddWithValue("@phone",email);
                cmd.Parameters.AddWithValue("@email",phone);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(name + " Added into the System Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.showMSG(ex.Message,"Error...","Error");
            }
        }

        public void insertCategory(string name, Int16 status)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);         
                cmd.Parameters.AddWithValue("@isActice", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(name + " Added into the System Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }

        public void insertProduct(string proName, string modelNo,DateTime date,int catID)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertProducts", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prdt_Name", proName);
                cmd.Parameters.AddWithValue("@prdt_ModelNo", modelNo);
                cmd.Parameters.AddWithValue("@prdt_Date", date);
                cmd.Parameters.AddWithValue("@prdt_catID", catID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(proName + " Added into the System Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }

        public void insertSupplier(int compID, string supName, string phoneNo1,Int16 status, string email = null, string phoneNo2 = null)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertSuppliers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sup_SupplierName", supName);
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
                cmd.Parameters.AddWithValue("@sup_compID", compID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(supName + " Added into the System Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }

        public void insertComp(string compName, string compAdress, string compPhoneNo1, Int16 status, string ntn = null, string compPhoneNo2 = null)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertCompany", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@comp_Name", compName);
                cmd.Parameters.AddWithValue("@comp_Address", compAdress);
                cmd.Parameters.AddWithValue("@comp_phoneNo1", compPhoneNo1);
                if (compPhoneNo2 == null)
                {
                    cmd.Parameters.AddWithValue("@comp_phoneNo2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@comp_phoneNo2", compPhoneNo2);
                }
                if (ntn == null)
                {
                    cmd.Parameters.AddWithValue("@comp_Ntn", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@comp_Ntn", ntn);
                }
                cmd.Parameters.AddWithValue("@comp_Status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(compName + " Added into the System Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }

        private Int64 purchaseInvoiceID;
        public Int64 insertPurchaseInvoice(DateTime date, int doneBy, int compID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@doneBy", doneBy);
                cmd.Parameters.AddWithValue("@compID", compID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "st_getLastPurchaseId";
                cmd.Parameters.Clear();
                purchaseInvoiceID = Convert.ToInt64(cmd.ExecuteScalar());
                MainClass.con.Close();
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
            return purchaseInvoiceID;
        }

        int pidCount;
        public int insertPurchaseInvoiceDetails(Int64 purID, int proID,int qty, float totalPrice) 
        {

            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoiceDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@purchaseid", purID);
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@proQty", qty);
                cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                MainClass.con.Open();
                pidCount = cmd.ExecuteNonQuery();
                MainClass.con.Close();


            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
            return pidCount;
        }

        public void insertStock( int proID, int qty)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("st_insertStock", MainClass.con);
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

        public void insertDeletedItem(Int64 pid, int proid,int quan, int userId, DateTime date)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertDeletedItemPI", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pi", pid);
                cmd.Parameters.AddWithValue("@usr_id", userId);
                cmd.Parameters.AddWithValue("@pro_id ", proid);
                cmd.Parameters.AddWithValue("@pro_quant", quan);
                cmd.Parameters.AddWithValue("@date", date);
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

        
        public void insertProductPrice(int proID, float bp)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProductPrice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proId", proID);
                cmd.Parameters.AddWithValue("@buyingPrice", bp);
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

        int salCount = 0;
        Int64 salesID;
        retrival r = new retrival();
        updation u = new updation();
        public void insertSales(DataGridView gv,string proIDGV,string sellPrice,string dis,string qtyGV,int doneBy,DateTime dt,float totalAmount,float totalDis,float amountGiven,float amountReturn,string pType)
        {

            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    SqlCommand cmd = new SqlCommand("st_insertSales", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@doneBy", doneBy);
                    cmd.Parameters.AddWithValue("@date", dt);
                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@totalDiscount", totalDis);
                    cmd.Parameters.AddWithValue("@totalGivenAmount", amountGiven);
                    cmd.Parameters.AddWithValue("@amountReturn", amountReturn);
                    if (pType == "Cash")
                    {
                        cmd.Parameters.AddWithValue("@paymentType", 0);
                    }
                    else if (pType == "Debit Card")
                    {
                        cmd.Parameters.AddWithValue("@paymentType", 1);
                    }
                    else if (pType == "Credit Card")
                    {
                        cmd.Parameters.AddWithValue("@paymentType", 2);
                    }
                   
                    MainClass.con.Open();
                    salCount = cmd.ExecuteNonQuery();
                    if (salCount > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("st_getSaleID", MainClass.con);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        salesID = Convert.ToInt64(cmd2.ExecuteScalar());
                        
                        foreach (DataGridViewRow row in gv.Rows)
                        {
                            SqlCommand cmd3 = new SqlCommand("st_insertSaleDetails", MainClass.con);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@salID", salesID);
                            cmd3.Parameters.AddWithValue("@proID", Convert.ToInt64(row.Cells[proIDGV].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@quan", Convert.ToInt32(row.Cells[qtyGV].Value.ToString()));
                            cmd3.Parameters.AddWithValue("sellingPrice", Convert.ToSingle(row.Cells[sellPrice].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@discount", Convert.ToSingle(row.Cells[dis].Value.ToString()));
                            cmd3.ExecuteNonQuery();
                            int stockOfProduct = Convert.ToInt32(r.getProductQtyWithoutConnection(Convert.ToInt32(row.Cells[proIDGV].Value.ToString())));
                            int currentQuanofProduct = Convert.ToInt32(row.Cells[qtyGV].Value.ToString());
                            int finalProductQty = stockOfProduct - currentQuanofProduct;
                            u.updatetStockWithoutConnection(Convert.ToInt32(row.Cells[proIDGV].Value.ToString()),finalProductQty);
                            
                        }
                    }
                    MainClass.con.Close();
                    MainClass.showMSG("Sales Succesfull", "Success...", "Success");
                    sc.Complete();
                }
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
               MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }
    }
}
