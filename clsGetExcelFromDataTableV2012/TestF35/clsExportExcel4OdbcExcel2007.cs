using System;
using System.Data.SqlClient;
using System.Reflection;
using System.IO;
using System.Collections;
using System.Text;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Collections.Generic;

namespace GetExcelFromDataTable
{
    /// <summary>
    /// Class1 ��ժҪ˵����
    /// </summary>
    public partial class clsGetExcelFromDataTable
    {


      
        /// <summary>
        /// ͨ��Odbc������Excel,����Ҫ��װExcel��ͨ��DataTable, ͨ���ֶ��б�
        /// </summary>
        /// <param name="objDT">�ṩ��DataTable</param>
        /// <param name="ColumnsNameInDataTable">����������</param>
        /// <param name="FirstRowChineseNames">��һ�е����ı�������</param>
        /// <param name="SavePathAndName">�����·���ļ���</param>
        /// <returns></returns>
        public static bool GetExcelFromDataTableByArr4OdbcExcel2007(System.Data.DataTable objDT,
            List<string> ColumnsNameInDataTable,
            List<string> FirstRowChineseNames,
            string SavePathAndName)
        {
            string strTableName = "First Sheet";//������sheet
            return GetExcelFromDataTableByArr4OdbcExcel2007(objDT,
           ColumnsNameInDataTable,
           FirstRowChineseNames,
           SavePathAndName, strTableName);

        }


        /// <summary>
        /// ͨ��Odbc������Excel,����Ҫ��װExcel��,ͨ��DataTable, ͨ���ֶ��б�
        /// ���Է�
        /// �޸����ڣ�2008-12-31
        /// </summary>
        /// <param name="objDT">�ṩ��DataTable</param>
        /// <param name="ColumnsNameInDataTable">����������</param>
        /// <param name="FirstRowChineseNames">��һ�е����ı�������</param>
        /// <param name="SavePathAndName">�����·���ļ���</param>
        /// <param name="strSheetName">����������</param>
        /// <returns></returns>
        public static bool GetExcelFromDataTableByArr4OdbcExcel2007(System.Data.DataTable objDT,
            List<string> ColumnsNameInDataTable,
             List<string> FirstRowChineseNames,
            string SavePathAndName,
            string strSheetName)
        {
            if (File.Exists(SavePathAndName) == false)
            {
                throw new Exception(string.Format("������ʼ�ļ���{0}�����ڣ��������Ա��ϵ��", SavePathAndName));
            }

            if (CheckColumnsNameIsExist(objDT, ColumnsNameInDataTable) == false)
            {
                return false;
            }
            string strTableName = strSheetName;// "First Sheet";//������sheet

            int intRowNum = objDT.Rows.Count;
            if (intRowNum == 0)
            {
                throw new Exception("��Ҫ�����ļ�¼��Ϊ0������Ҫ������");
            }
            int intColumnNum = objDT.Columns.Count;
            //2 ͨ��ѭ����д��Excel
            StringBuilder strSQL = new StringBuilder();
            //excel 2003��ʽ
            //string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SavePathAndName + ";Extended Properties=Excel 8.0;";
            //Excel 2007��ʽ
//            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + SavePathAndName + ";Extended Properties=Excel 12.0 Xml;";
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + SavePathAndName + ";Extended Properties='Excel 12.0; HDR=YES; IMEX=1'";

            //            @"Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + excelFile + @";Extended Properties='Excel 12.0; HDR=YES; IMEX=1'"; //�����ӿ��Բ���.xls��.xlsx�ļ���//��ע�� "HDR=yes;"��˵Excel�ļ��ĵ�һ�����������������ݣ�"HDR=No;"������ǰ����෴��  "IMEX=1 "������е��������Ͳ�һ�£�ʹ��"IMEX=1"�ɱ����������ͳ�ͻ��

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                try
                {
                    con.Open();
                }
                catch (Exception objException)
                {
                    LogErrorS(objException, "clsGetExcelFromDataTable4Odbc");
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("(errid:BlEx000032)�����ӳ���(clsGetExcelFromDataTable:GetExcelFromDataTableByArr4Odbc)���Ӵ���{0}��������Ϣ��{1}��",
                        connString,
                        objException.Message);

                    throw new Exception(sbMsg.ToString(), objException);
                }
                try
                {
                    strSQL.Append("CREATE TABLE ").Append("[" + strTableName + "]");
                    strSQL.Append("(");
                    for (int i = 0; i < FirstRowChineseNames.Count; i++)
                    {
                        string strColName = ColumnsNameInDataTable[i].ToString();
                        if (objDT.Columns[strColName].DataType == System.Type.GetType("System.String"))
                        {
                            strSQL.Append("[" + FirstRowChineseNames[i] + "] text,");
                        }
                        else
                        {
                            strSQL.Append("[" + FirstRowChineseNames[i] + "] Int,");
                        }
                    }
                    strSQL = strSQL.Remove(strSQL.Length - 1, 1);
                    strSQL.Append(")");

                    OleDbCommand cmd = new OleDbCommand(strSQL.ToString(), con);
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < objDT.Rows.Count; i++)
                    {
                        strSQL = new StringBuilder();
                        StringBuilder strfield = new StringBuilder();
                        StringBuilder strvalue = new StringBuilder();
                        for (int j = 0; j < ColumnsNameInDataTable.Count; j++)
                        {
                            string strColName = ColumnsNameInDataTable[j].ToString();
                            string strColValue = objDT.Rows[i][strColName].ToString();
                            strColValue = strColValue.Replace("'", "''"); //ת��ֵ���еĵ�Ʋ"'",ʹ֮��Ϊ˫Ʋ"''"

                            strfield.Append("[" + FirstRowChineseNames[j] + "]");
                            if (objDT.Columns[strColName].DataType == System.Type.GetType("System.String"))
                            {
                                strvalue.Append("'" + strColValue + "'");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(strColValue) == true)
                                {
                                    strColValue = "-1";
                                }
                                strvalue.Append(strColValue);
                            }
                            if (j != ColumnsNameInDataTable.Count - 1)
                            {
                                strfield.Append(",");
                                strvalue.Append(",");
                            }
                            else
                            {
                            }
                        }
                        cmd.CommandText = strSQL.Append(" insert into [" + strTableName + "]( ")
                        .Append(strfield.ToString())
                        .Append(") values (").Append(strvalue).Append(")").ToString();
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();

                }
                catch (Exception objException)
                {
                    LogErrorS(objException, "clsGetExcelFromDataTable4OdbcExcel2007");
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("SQL��䣺{0}��������Ϣ��{1}��", strSQL.ToString(), objException.Message);
                    sbMsg.AppendFormat("(errid:BlEx000033)����Excel����(clsGetExcelFromDataTable:GetExcelFromDataTableByArr4Odbc)����SQL��䣺{0}��������Ϣ��{1}��",
                      strSQL.ToString(),
                      objException.Message);
                    throw new Exception(sbMsg.ToString(), objException);
                }
            }
            return true;
        }

    }
}
