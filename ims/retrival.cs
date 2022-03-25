using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    class retrival
    {
        public void showUsers(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn passGV, DataGridViewColumn phoneGV, DataGridViewColumn emailGV, DataGridViewColumn statusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getUserData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getUserDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                usernameGV.DataPropertyName = dt.Columns["UserName"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception)
            {

            }
        }

        public void showCategory(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV, DataGridViewColumn isActivGV, string data = null)
        {
            try
            {

                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getCategoriesData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getCategoriesDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                isActivGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load Categories Data..", "Error...", "Error");
            }
        }

        public void showList(string proc, ComboBox cb, string displayMember, string valueMember)
        {
            try
            {

                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);

                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;

                cb.DataSource = dt;



            }
            catch (Exception ex)
            {

                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }
        
        public void showProduct(DataGridView gv, DataGridViewColumn prdtIDGV, DataGridViewColumn prdtCatGV, DataGridViewColumn prdtCatIDGV, DataGridViewColumn prdtNameGV, DataGridViewColumn prdtModelNoGV, DataGridViewColumn prdtDateGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getProductData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getProductsDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                prdtIDGV.DataPropertyName = dt.Columns["prdt_ID"].ToString();
                prdtCatGV.DataPropertyName = dt.Columns["Category_Name"].ToString();
                prdtCatIDGV.DataPropertyName = dt.Columns["Category_ID"].ToString();
                prdtNameGV.DataPropertyName = dt.Columns["prdt_Name"].ToString();
                prdtModelNoGV.DataPropertyName = dt.Columns["prdt_ModelNo"].ToString();
                prdtDateGV.DataPropertyName = dt.Columns["prdt_Date"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message, "Error..", "Error");
            }
        }

        public void showSuppliers(DataGridView gv, DataGridViewColumn supIDGV, DataGridViewColumn supNameGV, DataGridViewColumn supComIDGV, DataGridViewColumn supCompNameGV, DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, DataGridViewColumn emailGV, DataGridViewColumn status, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {

                    cmd = new SqlCommand("st_getSupplierData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getSupplierDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                supIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                supNameGV.DataPropertyName = dt.Columns["Supplier_Name"].ToString();
                supComIDGV.DataPropertyName = dt.Columns["Company_ID"].ToString();
                supCompNameGV.DataPropertyName = dt.Columns["Company_Name"].ToString();
                phone1GV.DataPropertyName = dt.Columns["PhoneNo1"].ToString();
                phone2GV.DataPropertyName = dt.Columns["PhoneNo2"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                status.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception)
            {

            }
        }

        public void showCompany(DataGridView gv, DataGridViewColumn compIDGV, DataGridViewColumn compNameGV, DataGridViewColumn compAddGV, DataGridViewColumn compPhone1GV, DataGridViewColumn compPhone2GV, DataGridViewColumn compNtnGV, DataGridViewColumn compStatusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getCompanyData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getCompanyDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                compIDGV.DataPropertyName = dt.Columns["comp_ID"].ToString();
                compNameGV.DataPropertyName = dt.Columns["Company_Name"].ToString();
                compAddGV.DataPropertyName = dt.Columns["Company_Address"].ToString();
                compPhone1GV.DataPropertyName = dt.Columns["Comp_Phone1"].ToString();
                compPhone2GV.DataPropertyName = dt.Columns["Comp_Phone2"].ToString();
                compNtnGV.DataPropertyName = dt.Columns["Comp_NTN"].ToString();
                compStatusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message,"Error...","Error");
            }
        }

        private string[] productData = new string[6];
        public string[]  showProductsWRTModelNo(string ModelNo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByModelNo", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prdt_ModelNo",ModelNo);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productData[0] = dr[0].ToString(); //Product ID
                        productData[1] = dr[1].ToString(); //Product Name
                        productData[2] = dr[2].ToString(); //Product Model No
                        productData[3] = dr[3].ToString(); //Product Selling Price
                        productData[4] = dr[4].ToString(); //Product Discount
                        productData[5] = dr[5].ToString(); //Product Final Price
                    }
                }
                else
                {
                    Array.Clear(productData, 0, productData.Length);
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
            return productData;
        }

        private string[] supList = new string[2];
        public string[] tryList(string CompName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSupplierNameByCompany", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sup_CompName", CompName);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        supList[0] = dr[0].ToString();
                        supList[1] = dr[1].ToString();
                    }
                }
                MainClass.con.Close();


            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
            return supList;
        }

        public static int user_Id
        {
            get;
            private set;
        }

        public static string emp_Name
        {
            get;
            private set;
        }

        private static string user_name = null, pass_word = null;
        private static bool checkLogin;
        public static bool getUserDetails(string username, string password) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while (dr.Read())
                    {
                        user_Id = Convert.ToInt32(dr["ID"].ToString());
                        emp_Name = dr["Name"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["Password"].ToString();
                    }

                }
                else
                {
                    checkLogin = false;
                    if (username != null && password != null)
                    {
                        if (user_name != username && pass_word == password) 
                        {
                            MainClass.showMSG("Invalid Username", "Error...", "Error");
                        }
                        else if (user_name == username && pass_word != password)
                        {
                            MainClass.showMSG("Invalid Password", "Error...", "Error");
                        }
                        else if (user_name != username && pass_word != password)
                        {
                            MainClass.showMSG("Invalid Username and Password", "Error...", "Error");
                        }
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message,"Error...","Error");
            }

            return checkLogin;
             

            
        }

        private object productStockCount = 0;
        public object getProductQty(int proID) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID ", proID);
                MainClass.con.Open();
                productStockCount = cmd.ExecuteScalar();
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
            }
            return productStockCount;
            
        }

        public object getProductQtyWithoutConnection(int proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID ", proID);
                productStockCount = cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message,"Error...", "Error");
            }
            return productStockCount;

        }

        public void showListWithTwoParameters(string proc, ComboBox cb, string displayMember,string valueMember,string param1, object val1,string param2, object val2)
        {
            try
            {

                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);

                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;

                cb.DataSource = dt;



            }
            catch (Exception ex)
            {

                MainClass.showMSG(ex.Message, "Error...", "Error");
            }

        }


        public void showPurchaseInvoiceDetails(Int64 pid,DataGridView gv, DataGridViewColumn mPIDGV, DataGridViewColumn prdtIDGV, DataGridViewColumn prdtName, DataGridViewColumn prdtQty, DataGridViewColumn prdtpup, DataGridViewColumn prdtTotalPrice, string data  = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getPurchaseInvoiceDetails", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getProductsDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@pid",pid);
                DataTable dt = new DataTable();
                da.Fill(dt);
                mPIDGV.DataPropertyName = dt.Columns["mPID"].ToString();
                prdtIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                prdtName.DataPropertyName = dt.Columns["Product Name"].ToString();
                prdtQty.DataPropertyName = dt.Columns["Product Quantity"].ToString();
                prdtpup.DataPropertyName = dt.Columns["Per Unit Price"].ToString();
                prdtTotalPrice.DataPropertyName = dt.Columns["Total Price"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }
       
        bool chkPPExistance;
        public bool checkExistingPriceExistance(int proID) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("check_productPrice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    chkPPExistance = true;

                }
                else
                {
                    chkPPExistance = false;
                }
                MainClass.con.Close();
                
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
            return chkPPExistance;
        }
        
        public void showStockDetails(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn catNameGV, DataGridViewColumn modelNoGV, DataGridViewColumn bpriceGV, DataGridViewColumn spriceGV, DataGridViewColumn stAvailableGV, DataGridViewColumn status, DataGridViewColumn totGV,string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {

                    cmd = new SqlCommand("st_getAllStock", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getSupplierDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product Id"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product Name"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category Name"].ToString();
                modelNoGV.DataPropertyName = dt.Columns["Model No"].ToString();
                bpriceGV.DataPropertyName = dt.Columns["Product B.Price"].ToString();
                spriceGV.DataPropertyName = dt.Columns["Product S.Price"].ToString();
                stAvailableGV.DataPropertyName = dt.Columns["Stock Available"].ToString();
                status.DataPropertyName = dt.Columns["Status"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load Stock Data", "Error...", "Error");
            }
        }

        public void showProductWRTCategory(int catID, DataGridView gv, DataGridViewColumn prdtIDGV, DataGridViewColumn prdtName, DataGridViewColumn prdtPrice, DataGridViewColumn prdtProf, DataGridViewColumn prdtDisc, DataGridViewColumn finalPrice, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getProductWRTCategory", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getProductsDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@catID", catID);
                DataTable dt = new DataTable();
                da.Fill(dt);
                prdtIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                prdtName.DataPropertyName = dt.Columns["Product Name"].ToString();
                prdtPrice.DataPropertyName = dt.Columns["Product Price"].ToString();
                prdtProf.DataPropertyName = dt.Columns["Profit"].ToString();
                prdtDisc.DataPropertyName = dt.Columns["Discount"].ToString();
                finalPrice.DataPropertyName = dt.Columns["Selling Price"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }


        public void showReport(ReportDocument rd,CrystalReportViewer crv,string proc,string param1,object val1) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc,MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath+"\\Reports\\SaleReceipt.rpt");
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();
            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }    
        
        }


        public void showSaleInovice(DataGridView gv, DataGridViewColumn saleIDGV, DataGridViewColumn userNameGV, DataGridViewColumn totalAmountGV, DataGridViewColumn givenAmountGV, DataGridViewColumn amountReturnGV, DataGridViewColumn totalDiscountGV,DateTime date , DataGridViewColumn userIDGV,string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getDailySales", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getProductsDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date",date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                saleIDGV.DataPropertyName = dt.Columns["Sale ID"].ToString();
                userNameGV.DataPropertyName = dt.Columns["User Name"].ToString();
                totalAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                givenAmountGV.DataPropertyName = dt.Columns["Given Amount"].ToString();
                amountReturnGV.DataPropertyName = dt.Columns["Amount Return"].ToString();
                totalDiscountGV.DataPropertyName = dt.Columns["Total Discount"].ToString();
                userIDGV.DataPropertyName = dt.Columns["User ID"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message, "Error..", "Error");
            }
        }

        public void showSalesViaSaleID(Int64 salesID,DataGridView gv, DataGridViewColumn saleIDGV, DataGridViewColumn userNameGV,
            DataGridViewColumn dateGV, DataGridViewColumn modelNoGV, DataGridViewColumn productNameGV, DataGridViewColumn proQtyGV,
            DataGridViewColumn proPriceGV,DataGridViewColumn ppTotalGV, DataGridViewColumn ppDiscountGV, 
            DataGridViewColumn totAmountGV, DataGridViewColumn totDiscountGV,DataGridViewColumn givenAmountGV,
            DataGridViewColumn amountReturnGV, DataGridViewColumn saleType,string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getSaleReceiptWRTSaleID", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getProductsDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@saleID", salesID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                saleIDGV.DataPropertyName = dt.Columns["Sale ID"].ToString();
                userNameGV.DataPropertyName = dt.Columns["User Name"].ToString();
                dateGV.DataPropertyName = dt.Columns["Date"].ToString();
                modelNoGV.DataPropertyName = dt.Columns["Model No"].ToString();
                productNameGV.DataPropertyName = dt.Columns["Product Name"].ToString();
                proQtyGV.DataPropertyName = dt.Columns["Quantity"].ToString(); 
                proPriceGV.DataPropertyName = dt.Columns["Product Price"].ToString();
                ppTotalGV.DataPropertyName = dt.Columns["Per Product Total"].ToString();
                ppDiscountGV.DataPropertyName = dt.Columns["Per Product Discount"].ToString();
                totAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                totDiscountGV.DataPropertyName = dt.Columns["Total Discount"].ToString();
                givenAmountGV.DataPropertyName = dt.Columns["Given Amount"].ToString();
                amountReturnGV.DataPropertyName = dt.Columns["Amount Return"].ToString();
                saleType.DataPropertyName = dt.Columns["Pay Type"].ToString(); 
                gv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message, "Error..", "Error");
            }
        }


    }
}
