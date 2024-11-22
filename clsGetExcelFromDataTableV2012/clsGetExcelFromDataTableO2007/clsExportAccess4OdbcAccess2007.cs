using System;
using System.Data.SqlClient;
using System.Reflection;
using System.IO;
using System.Collections;
using System.Text;
using System.Data;

using System.Data.OleDb;
using System.Collections.Generic;

namespace GetAccessFromDataTable
{
    /// <summary>
    /// Class1 ��ժҪ˵����
    /// </summary>
    public partial class clsGetAccessFromDataTable
    {



        /// <summary>
        /// ͨ��Odbc������Access,����Ҫ��װAccess��ͨ��DataTable, ͨ���ֶ��б�
        /// </summary>
        /// <param name="objDT">�ṩ��DataTable</param>
        /// <param name="ColumnsNameInDataTable">����������</param>
        /// <param name="FirstRowChineseNames">��һ�е����ı�������</param>
        /// <param name="SavePathAndName">�����·���ļ���</param>
        /// <returns></returns>
        public static bool GetAccessFromDataTableByArr4OdbcAccess2007(System.Data.DataTable objDT,
            List<string> ColumnsNameInDataTable,
            List<string> FirstRowChineseNames,
            string SavePathAndName)
        {
            string strTableName = "First Sheet";//������sheet
            return GetAccessFromDataTableByArr4OdbcAccess2007(objDT,
           ColumnsNameInDataTable,
           FirstRowChineseNames,
           SavePathAndName, strTableName);

        }


        /// <summary>
        /// ͨ��Odbc������Access,����Ҫ��װAccess��,ͨ��DataTable, ͨ���ֶ��б�
        /// ���Է�
        /// �޸����ڣ�2008-12-31
        /// </summary>
        /// <param name="objDT">�ṩ��DataTable</param>
        /// <param name="ColumnsNameInDataTable">����������</param>
        /// <param name="FirstRowChineseNames">��һ�е����ı�������</param>
        /// <param name="SavePathAndName">�����·���ļ���</param>
        /// <param name="strSheetName">����������</param>
        /// <returns></returns>
        public static bool GetAccessFromDataTableByArr4OdbcAccess2007(System.Data.DataTable objDT,
            List<string> ColumnsNameInDataTable,
             List<string> FirstRowChineseNames,
            string SavePathAndName,
            string strSheetName)
        {
            if (File.Exists(SavePathAndName) == false)
            {
                throw new Exception(string.Format("������ʼ�ļ���{0}�����ڣ��������Ա��ϵ��(errid:access0003)", SavePathAndName));
            }

            if (CheckColumnsNameIsExist(objDT, ColumnsNameInDataTable) == false)
            {
                return false;
            }
            string strTableName = strSheetName;// "First Sheet";//������sheet

            int intRowNum = objDT.Rows.Count;
            if (intRowNum == 0)
            {
                throw new Exception("��Ҫ�����ļ�¼��Ϊ0������Ҫ������(errid:access0001)");
            }
            int intColumnNum = objDT.Columns.Count;
            //2 ͨ��ѭ����д��Access
            StringBuilder strSQL = new StringBuilder();
            //excel 2003��ʽ
            //string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SavePathAndName + ";Extended Properties=Access 8.0;";
            //Access 2007��ʽ
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + SavePathAndName + ";";

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                try
                {
                    con.Open();
                }
                catch (Exception objException)
                {
                    LogErrorS(objException, "clsGetAccessFromDataTable");
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("(errid:BlEx000036)�����ӳ�����(clsGetAccessFromDataTable:GetAccessFromDataTableByArr4OdbcAccess2007)���Ӵ���{0}��������Ϣ��{1}��",
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
                    LogErrorS(objException, "clsGetAccessFromDataTable4OdbcAccess2007");
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("(errid:BlEx000037)����Access������(clsGetAccessFromDataTable:GetAccessFromDataTableByArr4OdbcAccess2007)����SQL��䣺{0}��������Ϣ��{1}��",
                     strSQL.ToString(),
                     objException.Message);
                    throw new Exception(sbMsg.ToString(), objException);
                }
            }
            return true;
        }

    }
}