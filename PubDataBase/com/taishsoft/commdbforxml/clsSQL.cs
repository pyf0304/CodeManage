//����Ϊͨ�����ݲ㣬Ŀ��Ϊ�������ݿ�Ӧ�ó�����񣬼ȿ�������WEBӦ�ó���
//Ҳ������������Ӧ�ó���
//Ŀǰ�汾��V1.0��
//����ʱ�䣺2004��8��12��
//����޸��ߣ����Է�
//

using System;
using System.Collections;
using System.Data;
using System.Text;
using System.IO;
using System.Xml;
using System.Data.SqlClient;
using com.taishsoft.comm_db_obj;

namespace com.taishsoft.commdbforxml
{
    public class clsSQL
    {
        private static string mstrAppType = "WEBAPP"; //Ӧ�����Ϳ����������֣�"WEBAPP","WINAPP"

        public static string AppType
        {
            get { return clsSQL.mstrAppType; }
            set
            {
                clsSQL.mstrAppType = value;
            }
        }
        private static string mstrWebRoot = "";   //@"\AGC_CSV5\ConnStr\";

        public static string WebRoot
        {
            get { return clsSQL.mstrWebRoot; }
            set
            {
                clsSQL.mstrWebRoot = value;
            }
        }

        //Attributes
        protected bool mblnDisposed = false;     //'�Ƿ��Ѿ��ͷŶ���(������������)
        private string mstrXmlFileNameForCommDb;//���湫�����ݵ�XML�ļ���

        public string XmlFileNameForCommDb
        {
            get { return mstrXmlFileNameForCommDb; }
            set { mstrXmlFileNameForCommDb = value; }
        }
        private DataSet mobjDataSetForCommDb = null;

        public DataSet DataSetForCommDb
        {
            get { return mobjDataSetForCommDb; }
            set { mobjDataSetForCommDb = value; }
        }

        protected string m_sSPConfigXMLFile;
        protected string mstrSPConfigXML;

        protected string mstrModuleName;
        protected const string EXCEPTION_MSG = "SQL��(XML)����";    //there was an error in the method. please see the Application Log for details.";
        //Properties
        #region "Properties"

        public string SPConfigXMLFile
        {
            get
            {
                return this.m_sSPConfigXMLFile;
            }
            set
            {
                if (value != "" && this.m_sSPConfigXMLFile != value)
                    this.m_sSPConfigXMLFile = value;
            }
        }

       
        #endregion


        //Methods
        #region "Methods"
       
        /// <summary>
        /// ���ܣ���ȡ������ļ�¼��.
        /// </summary>
        /// <param name="strTabName">�������ı���</param>
        /// <returns>��¼����Ϊ����</returns>
        public int funGetRecCount(string strTabName)
        {
            //by davidfujian 
            //2004-7-24 Night
            //��ò����ر�
            int intRecCount;
            try
            {
                DataTable objDT = mobjDataSetForCommDb.Tables[strTabName];
                intRecCount = objDT.Rows.Count;//��ü�¼����
                return intRecCount;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                Console.WriteLine(objException.ToString());
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
        }
        /// <summary>
        /// ���ܣ���ȡ�����������������ļ�¼��
        /// </summary>
        /// <param name="strTabName">�������ı���</param>
        /// <param name="strCondtion">�������ļ�¼����</param>
        /// <returns>��¼����Ϊ����</returns>
        public int funGetRecCount(string strTabName, string strCondtion)
        {
            //by davidfujian 
            //2004-7-24 Night
            //��ò����ر�
            int intRecCount;
            StringBuilder strSQL = new StringBuilder();
            try
            {
                DataRow[] objRows = mobjDataSetForCommDb.Tables[strTabName].Select(strCondtion);
                intRecCount = objRows.GetLength(0);//��ü�¼����
                return intRecCount;

            }
            catch (Exception objException)
            {
                LogError(objException, "");
                Console.WriteLine(objException.ToString());
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

        }

        /// <summary>
        /// ���ܣ���ȡ�����������������ļ�¼��
        /// </summary>
        /// <param name="strTabName">�������ı���</param>
        /// <param name="strCondtion">�������ļ�¼����</param>
        /// <returns>��¼����Ϊ����</returns>
        public DataRow[] GetDataRow(string strTabName, string strCondtion)
        {            
            //���DataSet����Դ
            CheckDataSetForCommDb();
            StringBuilder strSQL = new StringBuilder();
            try
            {
                DataRow[] objRows = mobjDataSetForCommDb.Tables[strTabName].Select(strCondtion);
                return objRows;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                Console.WriteLine(objException.ToString());
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

        }
        /// <summary>
        /// ���DataSet����Դ
        /// </summary>
        private void CheckDataSetForCommDb()
        {
            if (mobjDataSetForCommDb == null)
            {
                throw new Exception("DataSet������ԴΪNULL�����飡");
            }
        }
        public clsSQL()
        {
            mstrSPConfigXML = "";
            mstrModuleName = this.GetType().ToString();
        }

        public clsSQL(string strXmlFileName)
        {
            //by ���Է�
            //2007-12-2
            //�Ӳ����л�������ַ���
            mstrXmlFileNameForCommDb = strXmlFileName;
            mstrModuleName = this.GetType().ToString();
            this.mobjDataSetForCommDb = new DataSet();
            this.mobjDataSetForCommDb.ReadXml(strXmlFileName);
        }

        public clsSQL(DataSet objDS)
        {
            //by ���Է�
            //2007-12-2
            //�Ӳ����л�������ַ���
            mstrModuleName = this.GetType().ToString();
            this.mobjDataSetForCommDb = objDS;
        }
        public DataTable GetDataTable(string strTabName)
        {
            //by davidfujian (��˳��)
            //2004-2-28 Night
            //��ò����ر�
           
            try
            {
                DataTable objDT = mobjDataSetForCommDb.Tables[strTabName];
                return objDT;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                Console.WriteLine(objException.ToString());
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
                //				dtTab=new DataTable();
                //				return dtTab;	
            }
            finally
            {
            }
        }

        public bool GetDataTableXml(string strTabName, string strXmlFileName)
        {
            //by davidfujian (��˳��)
            //2004-2-28 Night
            //��ò����ر�
           
            try
            {
                DataTable objDT = mobjDataSetForCommDb.Tables[strTabName];

                objDT.WriteXml(strXmlFileName);
                //m_oConn.CloseB();
                return true;
            }
            catch (Exception objException)
            {
                System.Console.Out.WriteLine("TabName = " + strTabName);
                LogError(objException, strTabName);
                Console.WriteLine(objException.ToString());
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
                //				dtTab=new DataTable();
                //				return dtTab;	
            }
            finally
            {
            }
        }

        /// <summary>
        /// ���ܣ�	��ȡĳ���е�һ������������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strTableName">����</param>
        /// <param name="strFieldName">�ֶ���</param>
        /// <param name="WhereConditionString">������</param>
        /// <returns>��һ���ֶ�ֵ</returns>
        public string GetFirstFldValueOfTable(string strTableName,
            string strFieldName,
            string WhereConditionString)
        {
            //��ò����ر�
            DataTable objDT = null;
            string strKeyValue;
            //																						  '��֯SQL��
            try
            {
                objDT = mobjDataSetForCommDb.Tables[strTableName];
            }
            catch (Exception objException)
            {
                LogError(objException, strTableName);
                Console.WriteLine(objException.ToString());
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
                //				return null;
            }
            
            finally
            {
            }
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return "";
            }
            strKeyValue = objDT.Rows[0][0].ToString();
            objDT = null;
            return strKeyValue;
        }
        public string GetMaxStrId(string strTabName, string strFldName, int intFldLen, string strPrefix)
        {
            int intPrefixLen;

            System.Data.DataRow[] objDataRow = null;
            
            intPrefixLen = strPrefix.Length;
            objDataRow = this.mobjDataSetForCommDb.Tables[strTabName].Select("1=1", strFldName + " Desc");
            if (objDataRow.Length == 0)
            {
                return strPrefix + combineStr("0", intFldLen - 1 - intPrefixLen) + "1";

            }
            string strMaxValue = objDataRow[0][0].ToString();
            if (strMaxValue == "")
            {
                return strPrefix + combineStr("0", intFldLen - 1 - intPrefixLen) + "1";
            }

            int intNextMaxValue, intLen;
            string strNextMaxValue, strTemp;
            if (strPrefix == "")
            {
                intNextMaxValue = int.Parse(strMaxValue) + 1;
                strNextMaxValue = intNextMaxValue.ToString();
                intLen = strNextMaxValue.Length;
                strNextMaxValue = combineStr("0", intFldLen - intLen) + strNextMaxValue;
                return strNextMaxValue;
            }
            else
            {
                strTemp = strMaxValue.Substring(intPrefixLen);
                intNextMaxValue = int.Parse(strTemp) + 1;
                strNextMaxValue = intNextMaxValue.ToString();
                intLen = strNextMaxValue.Length;
                strNextMaxValue = strPrefix + combineStr("0", intFldLen - intLen - intPrefixLen) + strNextMaxValue;
                return strNextMaxValue;
            }
        }


        /// <summary>
        /// ���ܣ�	��ȡĳ���з���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strTableName">����</param>
        /// <param name="strFieldName">�ֶ���</param>
        /// <param name="WhereConditionString">������</param>
        /// <returns>�б�</returns>
        public ArrayList funGetFldDataOfTable(string strTableName,
            string strFieldName,
            string WhereConditionString)
        {
            //��ò����ر�
            DataTable objDT;
            ArrayList arrList = new ArrayList();
            int iRow, iCol;
            string strKeyValue;
            //																						  '��֯SQL��
            if (WhereConditionString != "")
            {
                WhereConditionString = " where " + WhereConditionString;
            }
            try
            {
                 objDT = mobjDataSetForCommDb.Tables[strTableName];
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                Console.WriteLine(objException.ToString());
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
                //				return null;
            }

            finally
            {
            }
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrList;
            }
            for (iRow = 0; iRow <= objDT.Rows.Count - 1; iRow++)
            {
                strKeyValue = "";
                for (iCol = 0; iCol <= objDT.Columns.Count - 1; iCol++)
                {
                    if (iCol == 0)
                    {
                        strKeyValue += objDT.Rows[iRow][iCol].ToString();
                    }
                    else
                    {
                        strKeyValue += "//" + objDT.Rows[iRow][iCol].ToString();
                    }
                }
                arrList.Add(strKeyValue);
            }
            objDT = null;
            return arrList;
        }
    
        public bool IsExistRecord(string strTableName, string strCondition)
        {
            //by davidfujian(���Է�)
            //2004-3-8 11:12
            //����¼�Ƿ����
            try
            {
                DataTable objDT = mobjDataSetForCommDb.Tables[strTableName];

                System.Data.DataRow[] objDataRow;
                objDataRow = objDT.Select(strCondition);
                if (objDataRow.Length > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (Exception objException)
            {
                LogError(objException, "");
                Console.WriteLine(objException.ToString());
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
                //				return false;
            }
            finally
            {
            }
        }

      
        

        /// <summary>
        /// ��װ�ַ�����
        /// </summary>
        /// <param name="mStr">ԭ�����ַ���</param>
        /// <param name="count">���ַ������ظ�����</param>
        /// <returns>��װ�õ��ַ���</returns>
        public static string combineStr(string mStr, int count)
        {
            string strTemp = "";
            for (int i = 0; i < count; i++)
                strTemp += mStr;
            return strTemp;
        }

        #endregion

        //XML Methods
        #region "XML Methods"

   
        protected void ValidateSPName(string SPName)
        {
            //'The name must be between 1 and 128 characters long.
            if (SPName.Length < 1 || SPName.Length > 128)
            {
                throw new Exception("A valid stored procedure name must be provided.");
            }
        }

        protected void LogError(Exception objException, string strAdditionMsg)
        {
            //'Log the error information to the Application Log
            string strLogMsg;
            try
            {
                strLogMsg = "An error occurred in the following module: "
                    + mstrModuleName + "\r\n"
                    + "Source: " + objException.Source + "\r\n"
                    + "Message: " + objException.Message + "\r\n"
                    + "Stack Trace:  " + objException.StackTrace + "\r\n"
                    + "Target Site:  " + objException.TargetSite.ToString() + "\r\n"
                    + strAdditionMsg;
                //'Write error to event log
                System.Diagnostics.EventLog.WriteEntry(mstrModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }

        protected SqlDbType GetSqlDataType(string dbtype)
        {
            switch (dbtype)
            {
                case "BigInt":

                    return SqlDbType.BigInt;

                case "Binary":
                    return SqlDbType.Binary;

                case "Bit":
                    return SqlDbType.Bit;

                case "Char":
                    return SqlDbType.Char;

                case "DateTime":
                    return SqlDbType.DateTime;

                case "Decimal":
                    return SqlDbType.Decimal;

                case "Float":
                    return SqlDbType.Float;

                case "Image":
                    return SqlDbType.Image;

                case "Int":
                    return SqlDbType.Int;

                case "Money":
                    return SqlDbType.Money;

                case "NChar":
                    return SqlDbType.NChar;

                case "NText":
                    return SqlDbType.NText;

                case "NVarChar":
                    return SqlDbType.NVarChar;

                case "Real":
                    return SqlDbType.Real;

                case "SmallDateTime":
                    return SqlDbType.SmallDateTime;

                case "SmallInt":
                    return SqlDbType.SmallInt;

                case "SmallMoney":
                    return SqlDbType.SmallMoney;

                case "Text":
                    return SqlDbType.Text;

                case "Timestamp":
                    return SqlDbType.Timestamp;

                case "TinyInt":
                    return SqlDbType.TinyInt;

                case "UniqueIdentifier":
                    return SqlDbType.UniqueIdentifier;

                case "VarBinary":
                    return SqlDbType.VarBinary;

                case "VarChar":
                    return SqlDbType.VarChar;

                case "Variant":
                    return SqlDbType.Variant;

                default:
                    //Default to Variant if anything else is supplied
                    return SqlDbType.Variant;

            }
        }

        protected ParameterDirection GetParamDirection(string ParamDirection)
        {
            switch (ParamDirection)
            {
                case "spParamInput":
                    return System.Data.ParameterDirection.Input;

                case "spParamOutput":
                    return System.Data.ParameterDirection.Output;

                case "spParamReturnValue":
                    return System.Data.ParameterDirection.ReturnValue;

                case "spParamInputOutput":
                    return System.Data.ParameterDirection.InputOutput;

                default:
                    //Default to Input if anything else is supplied
                    return System.Data.ParameterDirection.Input;
            }
        }
        #endregion
    }    

}

