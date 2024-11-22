using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Text;
using System.Data;
using com.taishsoft.commdb4odbc;

namespace TestExcel4O2007
{
    public partial class TestExcelExportByOdbc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExcelExportByOdbc_Click(object sender, EventArgs e)
        {
            clsExcelSQL objSQL = new clsExcelSQL(@"E:\pyf\test3.xls");
            string strSheetName1 = objSQL.GetExcelFirstTableName1();
            List<string> strSheetNameLst2 = objSQL.GetExcelTableNameLst2();
            //strSheetName1 = strSheetName1.TrimEnd('$');
            DataTable objDT = objSQL.funGetDataTable("select * from [" + strSheetName1 + "]");
            GridView1.DataSource = objDT;
            GridView1.DataBind();
            Export(objDT, @"E:\pyf\test31.xls", strSheetNameLst2[1]);
        }
        public  void Export(DataTable dt, string filepath, string tablename)
        {
            //excel 2003格式
            string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties=Excel 8.0;";
            //Excel 2007格式
            //string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties=Excel 12.0 Xml;";
            try
            {
                using (OleDbConnection con = new OleDbConnection(connString))
                {
                    con.Open();
                    StringBuilder strSQL = new StringBuilder();
                    strSQL.Append("CREATE TABLE ").Append("[" + tablename + "]");
                    strSQL.Append("(");
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        strSQL.Append("[" + dt.Columns[i].ColumnName + "] text,");
                    }
                    strSQL = strSQL.Remove(strSQL.Length - 1, 1);
                    strSQL.Append(")");

                    OleDbCommand cmd = new OleDbCommand(strSQL.ToString(), con);
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        strSQL = new StringBuilder();
                        StringBuilder strfield = new StringBuilder();
                        StringBuilder strvalue = new StringBuilder();
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            strfield.Append("[" + dt.Columns[j].ColumnName + "]");
                            strvalue.Append("'" + dt.Rows[i][j].ToString() + "'");
                            if (j != dt.Columns.Count - 1)
                            {
                                strfield.Append(",");
                                strvalue.Append(",");
                            }
                            else
                            {
                            }
                        }
                        cmd.CommandText = strSQL.Append(" insert into [" + tablename + "]( ")
                        .Append(strfield.ToString())
                        .Append(") values (").Append(strvalue).Append(")").ToString();
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                Console.WriteLine("OK");
                lblMsg.Text = "OK";
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                Console.WriteLine(ex.Message);
            }
        }

    }
}