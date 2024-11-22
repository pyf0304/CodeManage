
using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdbfororacle;
using com.taishsoft.comm_db_obj;
using System.Collections.Generic;
using com.taishsoft.common;

namespace com.taishsoft.commdbfororacle
{
    /// <summary>
    /// ͨ�����ݱ���Ļ���
    /// </summary>
    [Serializable]
    public class clsGeneralTab2
    {
        /// <summary>
        /// ��ǰ�������������صı���
        /// </summary>
        protected string _CurrTabName;    
        
        /// <summary>
        /// ���ڼ�¼���޸����Թ�������Щ���Ա����ù�
        /// </summary>
        private List<string> lstUpdatedFldCol = null;//���ڼ�¼���޸����Թ�������Щ���Ա����ù�

        //protected string _CurrTabName
        //{
        //    get { return mstrCurrTabName; }
        //    set { mstrCurrTabName = value; }
        //}
        /// <summary>
        /// ��ǰ����Ĺؼ���������
        /// </summary>
        protected List<string> lstKeyFldNames;	//��ǰ��Ĺؼ����ֶε�����

        /// <summary>
        /// ��ǰ��(����)�ı�ؼ��ֶ���
        /// </summary>
        public List<string> TabKeyFldNames
        {
            get
            {
                return lstKeyFldNames;
            }
        }

        //�����ǳ�����Ϣ
        /// <summary>
        /// ������Ϣ�����������ʽ��ʾ
        /// </summary>
        protected string[] mstrErrMsg_Tz = { "0:����", "1:Ժϵ��Ϊ��", "2:רҵ���Ϊ��", "3:������ͬ�ı��" };
        
        /// <summary>
        /// ������Ϣ����
        /// </summary>
        protected int mintErrNo = 0;   //0:����,1:�����Ϊ��,2:ѧ��Ϊ��
        /// <summary>
        /// ������ʾ�Ĵ�����Ϣ
        /// </summary>
        protected string mstrDispErrMsg;         
        /// <summary>
        /// ģ����
        /// </summary>
        protected string mstrModuleName;
        //		public static string mstrClassName;
        /// <summary>
        /// �Ƿ��Ѿ��ͷŶ���(������������)
        /// </summary>
        protected bool mblnDisposed = false;     
        /// <summary>
        /// ������Ϣ��
        /// </summary>
        protected const string EXCEPTION_MSG = "����"; //there was an error in the method. please see the Application Log for details.";
        //���������Ա���
        ///�ú���������:

        public clsGeneralTab2()
        {
            SetInit();
        }

        /// <summary>
        /// ���������Щ���Գ�ʼֵ
        /// </summary>
        protected void SetInit()
        {
            _CurrTabName = "Users";    //��ǰ�������������صı���
            lstKeyFldNames = new List<string>(); 		//��ǰ��Ĺؼ����ֶε�����
            lstUpdatedFldCol = new List<string>();
            mstrModuleName = this.GetType().ToString();
            
        }

        /// <summary>
        /// �����
        /// </summary>
        public int ErrNo
        {
            get
            {
                return mintErrNo;
            }
            set
            {
                mintErrNo = value;
            }
        }
        /// <summary>
        /// ������Ϣ
        /// </summary>
        public string DispErrMsg       //������ʾ�Ĵ�����Ϣ
        {
            get
            {
                return mstrDispErrMsg;
            }
            set
            {
                mstrDispErrMsg = value;
            }
        }
        /// <summary>
        /// ��ǰ��(����)�ı���
        /// </summary>
        public string TabName_Curr
        {
            get
            {
                return _CurrTabName;
            }
        }
        

        private string mstrS_Name;//������
        /// <summary>
        /// ������
        /// </summary>
        public string S_Name
        {
            get { return mstrS_Name; }
            set { mstrS_Name = value; }
        }
        private string mstrS_ObjectType;//��������
        /// <summary>
        /// ��������
        /// </summary>
        public string S_ObjectType
        {
            get { return mstrS_ObjectType; }
            set { mstrS_ObjectType = value; }
        }

        ///// <summary>
        ///// ��Ӽ�¼
        ///// </summary>
        ///// <returns></returns>
        //public virtual bool AddNewRecord()
        //{
        //    return true;
        //}
        ///// <summary>
        ///// �޸ļ�¼
        ///// </summary>
        ///// <returns></returns>
        //public virtual bool Update()
        //{
        //    return true;
        //}
        /// <summary>
        /// ��ȡSQL����
        /// </summary>
        /// <returns></returns>
        public static clsSpecSQLforOra GetSpecSQLObj_GeneralTab()
        {
            clsSpecSQLforOra objSQL = null;
            if (clsSpecSQLforOra.bolIsUseConnectStrName == true)
            {
                objSQL = new clsSpecSQLforOra(clsSpecSQLforOra.strConnectStrName, true);
                return objSQL;
            }
            if (string.IsNullOrEmpty(clsSpecSQLforOra.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforOra();
            }
            else
            {
                objSQL = new clsSpecSQLforOra(clsSpecSQLforOra.ConnectString);
            }
            return objSQL;

        }
        ///// <summary>
        ///// ���ܣ��޸Ķ�����¼
        ///// </summary>
        ///// <param name="strCondition"></param>
        ///// <returns></returns>
        //public virtual int UpdateMultiRec(string strCondition)
        //{
        //    return 0;
        //}

        ///// <summary>
        ///// ���ܣ���ȡ��ǰ��ļ�¼��.�ñ��뵱ǰ����ء�
        ///// </summary>
        ///// <returns>��¼����Ϊ����</returns>
        //public int funGetRecCount()
        //{
        //    clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
        //    int intRecCount = objSQL.funGetRecCount(_CurrTabName);
        //    return intRecCount;
        //}

        /// <summary>
        /// ���ܣ���ȡ��ǰ��ļ�¼��.�ñ��뵱ǰ����ء�
        /// </summary>
        /// <param name="strTabName">�������ı���</param>
        /// <returns>��¼����Ϊ����</returns>
        public static int funGetRecCount(string strTabName)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            int intRecCount = objSQL.funGetRecCount(strTabName);
            return intRecCount;
        }


        /// <summary>
        /// ���ܣ���ȡ��ǰ�������������ļ�¼��
        /// </summary>
        /// <param name="strCondtion">�������ļ�¼����</param>
        /// <returns>��¼����Ϊ����</returns>
        public int funGetRecCountByCond(string strCondtion)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            int intRecCount = objSQL.funGetRecCount(_CurrTabName, strCondtion);
            return intRecCount;
        }

        /// <summary>
        /// ���ܣ���ȡ�����������������ļ�¼��
        /// </summary>
        /// <param name="strTabName">�������ı���</param>
        /// <param name="strCondtion">�������ļ�¼����</param>
        /// <returns>��¼����Ϊ����</returns>
        public static int funGetRecCountByCond(string strTabName, string strCondtion)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            int intRecCount = objSQL.funGetRecCount(strTabName, strCondtion);
            return intRecCount;
        }


        /// <summary>
        /// ���ܣ����õ�ǰ���еķ���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="strValue">ֵ</param>
        /// <param name="strCondition">������</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public int funSetFldValue(string strFldName, string strValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            int intRecCount = objSQL.funSetFldDataOfTable(_CurrTabName, strFldName, strValue, strCondition);
            return intRecCount;
        }


        /// <summary>
        /// ���ܣ����õ�ǰ���еķ���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="fltValue">ֵ</param>
        /// <param name="strCondition">������</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public int funSetFldValue(string strFldName, float fltValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            int intRecCount = objSQL.funSetFldDataOfTable(_CurrTabName, strFldName, fltValue, strCondition);
            return intRecCount;
        }

        /// <summary>
        /// ���ܣ����õ�ǰ���еķ���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="intValue">ֵ</param>
        /// <param name="strCondition">������</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public int funSetFldValue(string strFldName, int intValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            int intRecCount = objSQL.funSetFldDataOfTable(_CurrTabName, strFldName, intValue, strCondition);
            return intRecCount;
        }

        /// <summary>
        /// ���ܣ����ø������еķ���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="strValue">ֵ</param>
        /// <param name="strCondition">������</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static int funSetFldValue(string strTabName, string strFldName, string strValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            int intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, strValue, strCondition);
            return intRecCount;
        }

        /// <summary>
        /// ���ܣ����ø������еķ���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="intValue">ֵ</param>
        /// <param name="strCondition">������</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static int funSetFldValue(string strTabName, string strFldName, int intValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            int intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, intValue, strCondition);
            return intRecCount;
        }

        /// <summary>
        /// ���ܣ����ø������еķ���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="fltValue">ֵ</param>
        /// <param name="strCondition">������</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static int funSetFldValue(string strTabName, string strFldName, float fltValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            int intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, fltValue, strCondition);
            return intRecCount;
        }


        /// <summary>
        /// ���ܣ���ȡ��ǰ���еķ���������ĳ�ֶε�ֵ�����б���
        /// </summary>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="strCondition">������</param>
        /// <returns>��ȡ���ֶ�ֵ�б�</returns>
        public List<string> funGetFldValue(string strFldName, string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            List<string> arrList = objSQL.funGetFldDataOfTable(_CurrTabName, strFldName, strCondition);
            return arrList;
        }

        /// <summary>
        /// ���ܣ���ȡ��ǰ���еķ���������ĳ�ֶε�ֵ�����б���
        /// </summary>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="strCondition">������</param>
        /// <returns>��ȡ���ֶ�ֵ�б�</returns>
        public List<string> funGetFldValueNoDistinct(string strFldName, string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            List<string> arrList = objSQL.funGetFldDataOfTableNoDistinct(_CurrTabName, strFldName, strCondition);
            return arrList;
        }

        /// <summary>
        /// ���ܣ���ȡ�������еķ���������ĳ�ֶε�ֵ�����б���
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="strCondition">������</param>
        /// <returns>��ȡ���ֶ�ֵ�б�</returns>
        public static List<string> funGetFldValue(string strTabName, string strFldName, string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            List<string> arrList = objSQL.funGetFldDataOfTable(strTabName, strFldName, strCondition);
            return arrList;
        }

        /// <summary>
        /// ���ܣ���ȡ�������еķ���������ĳ�ֶε�ֵ�����б���
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="strCondition">������</param>
        /// <returns>��ȡ���ֶ�ֵ�б�</returns>
        public static List<string> funGetFldValueNoDistinct(string strTabName, string strFldName, string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            List<string> arrList = objSQL.funGetFldDataOfTableNoDistinct(strTabName, strFldName, strCondition);
            return arrList;
        }

        /// <summary>
        /// ���ܣ���ȡ�������еķ���������ĳ�ֶε�ֵ�����б���
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="strCondition">������</param>
        /// <param name="objSqlConnect">SqlConnect</param>
        /// <param name="objSqlTransaction">OracleTransaction</param>
        /// <returns>��ȡ���ֶ�ֵ�б�</returns>
        public static List<string> funGetFldValue(string strTabName, string strFldName, string strCondition, OracleConnection objSqlConnect, OracleTransaction objSqlTransaction)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            List<string> arrList = objSQL.funGetFldDataOfTable(strTabName, strFldName, strCondition);
            return arrList;
        }
        ///// <summary>
        ///// ɾ����¼
        ///// </summary>
        ///// <returns></returns>
        //public virtual bool DelRecord()
        //{
        //    return true;
        //}

        //ͬʱɾ��������¼
        ///// <summary>
        ///// ��Ҫ��������д
        ///// </summary>
        ///// <param name="lstKey"></param>
        ///// <returns></returns>
        //		public static bool DelUsers(ArrayList lstKey)
        //		{
        //			clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
        //			string strSQL;
        //			string strKeyList;
        //			if (lstKey.Count ==0) return true;
        //			strKeyList = "";
        //			for (int i=0; i<lstKey.Count; i++)
        //			{
        //				if (i==0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
        //				else strKeyList += ","  + "'" + lstKey[i].ToString() + "'";
        //			}
        //			strSQL = "";
        //			//ɾ��Users�������뵱ǰ�����йصļ�¼
        //			strSQL = strSQL + "Delete from " + currTabname + " where " + KeyFldName + " in (" + strKeyList + ")";
        //			return objSQL.ExecSql(strSQL);
        //		}

        /// <summary>
        /// ���ܣ�ɾ��������¼����������ɾ��
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strCondition">��Ҫɾ���ļ�¼����</param>
        /// <returns>����ɾ���ļ�¼0��</returns>
        public static int DelMultiRec(string strTabName, string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            string strSQL;
            if (strCondition == "")
            {
                return 0;	//��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
            }
            else
            {
                strSQL = "Delete from " + strTabName + " where " + strCondition;
            }
            int intRecoCount = objSQL.ExecSql2(strSQL);
            return intRecoCount;
        }


        ///// <summary>
        ///// ����������д
        ///// </summary>
        ///// <returns></returns>
        //		public bool GetUsers()
        //		{
        //			string strSQL ;
        //			System.Data.DataTable objDT ; 
        //			clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
        //			strSQL = "Select * from Users where UserId=" + "'"+ mstrUserId+"'";
        //			objDT = objSQL.GetDataTable(strSQL);
        //			if (objDT.Rows.Count == 0)
        //			{
        //				objDT = null;
        //				return false;
        //			}
        //			mstrUserId=objDT.Rows[0]["UserId"].ToString().Trim();;
        //			mstrUserName=objDT.Rows[0]["UserName"].ToString().Trim();;
        //			mstrRoleId=objDT.Rows[0]["RoleId"].ToString().Trim();;
        //			mstrDepartmentId=objDT.Rows[0]["DepartmentId"].ToString().Trim();;
        //			objDT = null;
        //			return true;
        //		}
        //
        //		public static System.Data.DataTable GetUsers(string strCondition)
        //		{
        //			string strSQL; 
        //			System.Data.DataTable objDT; 
        //			clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
        //			strSQL = "Select * from Users where " + strCondition;
        //			objDT = objSQL.GetDataTable(strSQL);
        //			return objDT;
        //		}
        //

        /// <summary>
        /// ���ܣ���ȡĳһ�����Ĺؼ����б�
        ///		  �����ؼ����Ƕ���������ؼ���֮����"//"����
        /// </summary>
        /// <param name="strCondtion">������</param>
        /// <returns>�ؼ����б�</returns>
        public List<string> GetPrimaryKeyID(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            List<string> arrList = new List<string>();
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            int iRow, iCol;
            string strKeyValue;
            string strKeyFldNames = clsArray.GetSqlInStrByArray(lstKeyFldNames, false);
            strSQL = "Select " + strKeyFldNames + " from " + _CurrTabName + " where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                //				LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                //				objDT = null;
            }
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
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

        /// <summary>
        /// ����SQL����ȡ���ݱ�(DataTable)
        /// </summary>
        /// <param name="strSql">�ṩ��SQL���</param>
        /// <returns>���ص����ݱ�(DataTable)</returns>
        public static System.Data.DataTable GetDataTable(string strSql)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            objDT = objSQL.GetDataTable(strSql);
            return objDT;
        }

        /// <summary>
        /// ��ȡDataSet
        /// </summary>
        /// <param name="strSql">����Select ��SQL��䡣</param>
        /// <param name="strTableName">DataSet�еı�����</param>
        /// <returns>���ص�DataSet</returns>
        public DataSet GetDataSet(string strSql, string strTableName)
        {
            System.Data.DataSet objDS;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            objDS = objSQL.GetDataSet(strSql, strTableName);
            return objDS;
        }

         /// <summary>
        /// ��ȡDataSet
        /// </summary>
        /// <param name="objTable_SqlCommandText">����-SQL������</param>
        /// <returns>����DataSet</returns>
        public DataSet GetDataSet(clsTable_SqlCommandText objTable_SqlCommandText)
        {
            System.Data.DataSet objDS;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            objDS = objSQL.GetDataSet(objTable_SqlCommandText);
            return objDS;
        }
                /// <summary>
        /// ��ȡ�����������-SQL�������DataSet
        /// </summary>
        /// <param name="arrTable_SqlCommandTextList">����-SQL�������б�</param>
        /// <returns>����DataSet</returns>
        public DataSet GetDataSet(ArrayList arrTable_SqlCommandTextList)
        {
            System.Data.DataSet objDS;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            objDS = objSQL.GetDataSet(arrTable_SqlCommandTextList);
            return objDS;
        }
        
        /// <summary>
        /// ��ȡ��XML��ʽ��ʾ��DataSet
        /// </summary>
        /// <param name="arrTable_SqlCommandTextList">����-SQL�������б�</param>
        /// <param name="strXmlFileName">Xml�ļ���</param>
        /// <returns>����DataSet����XML��ʽ��ʾ</returns>
        public bool GetDataSetXml(ArrayList arrTable_SqlCommandTextList, string strXmlFileName)
        {
            bool bolResult;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            bolResult = objSQL.GetDataSetXml(arrTable_SqlCommandTextList, strXmlFileName);
            return bolResult;
        }
         /// <summary>
        /// ��ȡDataSet,��XML��ʽ����ʾ
        /// </summary>
        /// <param name="objTable_SqlCommandText">����-SQL������</param>
        /// <param name="strXmlFileName">���ɵ�XML�ļ���</param>
        /// <returns>��������XML�ļ��Ƿ�ɹ�</returns>
        public bool GetDataSetXml(clsTable_SqlCommandText objTable_SqlCommandText, string strXmlFileName)
        {
            bool bolResult;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            bolResult = objSQL.GetDataSetXml(objTable_SqlCommandText, strXmlFileName);
            return bolResult;
 
        }
        ///// <summary>
        ///// �ж��Ƿ���ڼ�¼
        ///// </summary>
        ///// <returns></returns>
        //public virtual bool IsExist()
        //{
        //    return true;
        //}


        /// <summary>
        /// ���ܣ��ж��Ƿ����ĳһ�����ļ�¼
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strCondition">������</param>
        /// <returns>������ھͷ���TRUE�����򷵻�FALSE</returns>
        public static bool IsExistCondRec(string strTabName, string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            if (objSQL.IsExistRecord(strTabName, strCondition))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ���ܣ��ж��Ƿ����ĳһ�����ļ�¼
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strCondition">������</param>
        /// <param name="objSqlConnect">SqlConnect</param>
        /// <param name="objSqlTransaction">OracleTransaction</param>
        /// <returns>������ھͷ���TRUE�����򷵻�FALSE</returns>
        public static bool IsExistCondRec(string strTabName, string strCondition, OracleConnection objSqlConnect, OracleTransaction objSqlTransaction)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            if (objSQL.IsExistRecord(strTabName, strCondition, objSqlConnect, objSqlTransaction))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// ���ܣ��ж��Ƿ����ĳһ�����ļ�¼
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>������ھͷ���TRUE�����򷵻�FALSE</returns>
        public bool IsExistCondRec(string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            if (objSQL.IsExistRecord(_CurrTabName, strCondition))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //public virtual bool CheckProperty(ref string strResult)
        //{
        //    strResult = "����չ����û�����¶��庯��<CheckProperty>,�����ʹ��CheckPropertyNew,�������¶���<CheckProperty>.�������Ա��ϵ!";
        //    return false;
        //}
        ///// <summary>
        ///// ��ȡ���������Ĺؼ���ID�б�
        ///// </summary>
        ///// <param name="strCondtion"></param>
        ///// <returns></returns>
        //public virtual ArrayList GetID(string strCondtion)
        //{
        //    return null;
        //}
        
        /// <summary>
        /// ��ȡ��ǰ������ݱ�(DataTable)
        /// </summary>
        /// <param name="strCondtion">������</param>
        /// <returns>���ص����ݱ�(DataTable)</returns>
        public DataTable GetTable(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            strSQL = "Select * from " + _CurrTabName + " where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
            return objDT;
        }
        /// <summary>
        /// ��ȡ��ǰ������ݱ�(DataTable)
        /// </summary>
        /// <param name="strCondtion">������</param>
        /// <returns>���ص����ݱ�(DataTable)</returns>
        public DataTable GetTable(string strCondtion, string strOrderBy)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            strSQL =string .Format( "Select * from {0} where {1} order by {2}", _CurrTabName , strCondtion, strOrderBy);
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
            return objDT;
        }       

        /// <summary>
        /// ����SQL����ȡ���ݱ�(DataTable)
        /// </summary>
        /// <param name="strSQL">SQL���</param>
        /// <returns>���ص����ݱ�(DataTable)</returns>
        public DataTable GetTableBySQL(string strSQL)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
            return objDT;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ�ַ���,���ΪNULL�ͷ��ؿմ�
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص��ַ���</returns>
        protected string TransNullToStr(Object obj)
        {
            if (obj == null) return "";
            if (obj.ToString() == "")
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ�ַ���,���ΪNULL�ͷ��ؿմ�
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص��ַ���</returns>
        public static string TransNullToStr_S(Object obj)
        {
            if (obj == null) return "";
            if (obj.ToString() == "")
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ����,���ΪNULL�ͷ���0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�����ֵ</returns>
        protected int TransNullToInt(Object obj)
        {
            int i = 0;
            if (obj == null) return 0;
            if (obj.ToString() == "") return 0;

            Int32.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ����,���ΪNULL�ͷ���0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�����ֵ</returns>
        public static int TransNullToInt_S(Object obj)
        {

            int i = 0;
            if (obj == null) return 0;
            if (obj.ToString() == "") return 0;
            Int32.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĶ�����ֵ</returns>
        protected short TransNullToShort(Object obj)
        {
            short i = 0;
            if (obj == null) return 0;
            short.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĶ�����ֵ</returns>
        public static short TransNullToShort_S(Object obj)
        {
            short i = 0;
            if (obj == null) return 0;
            short.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���#1/1/1900#(��С������)
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�������ֵ</returns>
        protected DateTime TransNullToDate(Object obj)
        {
            DateTime objDT = System.DateTime.Parse("#1/1/1900#");
            System.DateTime.TryParse(obj.ToString(), out objDT);
            return objDT;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���#1/1/1900#(��С������)
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�������ֵ</returns>
        public static DateTime TransNullToDate_S(Object obj)
        {
            DateTime objDT = System.DateTime.Parse("#1/1/1900#");
            if (obj == null) return objDT;
            System.DateTime.TryParse(obj.ToString(), out objDT);
            return objDT;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���0.0f
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĸ�����ֵ</returns>
        protected float TransNullToFloat(Object obj)
        {
            float f1 = 0.0f;
            if (obj == null) return f1;
            if (obj.ToString() == "") return f1;
            float.TryParse(obj.ToString(), out f1);
            return f1;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ���0.0f
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĸ�����ֵ</returns>
        public static float TransNullToFloat_S(Object obj)
        {
            float f1 = 0.0f;
            if (obj == null) return f1;
            if (obj.ToString() == "") return f1;
            float.TryParse(obj.ToString(), out f1);
            return f1;
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ˫��������,���ΪNULL�ͷ���0.0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�˫��������ֵ</returns>
        protected double TransNullToDouble(Object obj)
        {
            double d1 = 0.0;
            if (obj == null) return d1;
            if (obj.ToString() == "") return d1;
            double.TryParse(obj.ToString(), out d1);
            return d1;
        }

        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ˫��������,���ΪNULL�ͷ���0.0
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���ص�˫��������ֵ</returns>
        public static double TransNullToDouble_S(Object obj)
        {
            double d1 = 0.0;
            if (obj == null) return d1;
            if (obj.ToString() == "") return d1;
            double.TryParse(obj.ToString(), out d1);
            return d1;
        }

        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ��ؼ�(false)
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĲ�����ֵ</returns>
        protected bool TransNullToBool(Object obj)
        {
            if (obj == null) return false;
            if (obj.ToString() == "")
            {
                return false;
            }
            else
            {
                string strFirstByte = obj.ToString().Substring(0, 1);
                strFirstByte = strFirstByte.ToLower();
                if (strFirstByte == "y" || strFirstByte == "t" || strFirstByte == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// �ѿ���Ϊnull�Ķ���ת��Ϊ������,���ΪNULL�ͷ��ؼ�(false)
        /// </summary>
        /// <param name="obj">�����Ķ���</param>
        /// <returns>���صĲ�����ֵ</returns>
        public static bool TransNullToBool_S(Object obj)
        {
            if (obj == null) return false;
            if (obj.ToString() == "")
            {
                return false;
            }
            else
            {
                string strFirstByte = obj.ToString().Substring(0, 1);
                strFirstByte = strFirstByte.ToLower();
                if (strFirstByte == "y" || strFirstByte == "t" || strFirstByte == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// ��ȡ�ַ����ĳ���,������Ϊ2���ֽ�,Ӣ����Ϊ1���ֽ�
        /// </summary>
        /// <param name="strTemp">�������ַ���</param>
        /// <returns>�����ַ����ĳ���</returns>
        public int getStrLen(string strTemp)
        {
            int len;
            byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
            len = sarr.Length;//will output as 3+3*2=9
            return len;
        }
        /// <summary>
        /// �ͷŶ�����ռ�õ��ڴ�
        /// </summary>
        public void Dispose()
        {
            if (mblnDisposed == false)
            {
                try
                {
                    //Free up the database connection resource by 
                    //calling its Dispose method
                    //mobjConnection.Dispose()
                }
                finally
                {
                    //Because this Dispose method has done the necessary cleanup,
                    //prevent the Finalize method from being called.
                    GC.SuppressFinalize(this);

                    //Let our class know that Dispose() has been called
                    mblnDisposed = true;
                }
            }
        }
        /// <summary>
        /// ��¼��־,�Ѹ������쳣�����¼����־��.
        /// </summary>
        /// <param name="objException">�������쳣����</param>
        protected void LogError(Exception objException)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {
                strLogMsg = "An error occurred in the following module: "
                    + mstrModuleName + "Source: " + objException.Source

                    + "Message: " + objException.Message
                    + "Stack Trace:  " + objException.StackTrace

                    + "Target Site:  " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(mstrModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }
        //��̬�Ĵ��������־�ĺ���

        /// <summary>
        /// ���������־�ĺ���
        /// </summary>
        /// <param name="objException">�쳣����</param>
        /// <param name="strModuleName">ģ������</param>
        public static void LogErrorS(Exception objException, string strModuleName)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {
                strLogMsg = "An error occurred in the following module: "
                    + strModuleName + "Source: " + objException.Source

                    + "Message: " + objException.Message
                    + "Stack Trace:  " + objException.StackTrace

                    + "Target Site:  " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }
        ///// <summary>
        ///// ���������־�ĺ���
        ///// </summary>
        ///// <param name="objException">�쳣����</param>
        ///// <param name="strModuleName">ģ������</param>
        ///// 





        /// <summary>
        /// ���������־�ĺ���
        /// </summary>
        /// <param name="strModuleName">ģ������</param>
        /// <param name="strSource">��Դ</param>
        /// <param name="strMessage">������Ϣ</param>
        /// <param name="strStackTrace">������Ϣ</param>
        /// <param name="strTargetSite">Ŀ��վ��</param>
        public static void LogErrorS2( string strModuleName, string strSource, string strMessage, string strStackTrace, string strTargetSite)
        {
            //Log the error information to the Application Log
            StringBuilder sbLogMsg = new StringBuilder();
            try
            {
                sbLogMsg.Append( "һ���������!\r\n");
                sbLogMsg.AppendFormat("ģ������{0}.\r\n", strModuleName);
                sbLogMsg.AppendFormat("��Դ��{0}.\r\n", strSource);
                sbLogMsg.AppendFormat("������Ϣ��{0}.\r\n", strMessage);
                sbLogMsg.AppendFormat("������Ϣ��{0}.\r\n", strStackTrace);
                sbLogMsg.AppendFormat("վ�㣺{0}.\r\n", strTargetSite);

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, sbLogMsg.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }

        //��̬�Ĵ��������־�ĺ���

        /// <summary>
        /// ����Ӧ�õ���־����¼��Ӧ�ã�Application������־�С�
        /// </summary>
        /// <param name="strMsg">��Ϣ</param>
        /// <param name="strModuleName">ģ������</param>
        public static void LogApplicationS(string strMsg, string strModuleName)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {
                strLogMsg = "An Log occurred in the following module: "
                    + strModuleName  + "Message: " + strMsg;

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Information);
            }
            catch
            {
            }
        }
        /// <summary>
        /// ���ܣ���ȡ��ǰ���ڵ��ַ���
        /// ���ڸ�ʽ��
        ///    ���ڵ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMMDD��	����20050120
        ///		2��YYYY-MM-DD	����2005-01-20
        ///		3��YYYY/MM/DD	����2005/01/20
        /// </summary>
        /// <param name="intFormat">���ڸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ���������ڸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ���ڵ��ַ���</returns>
        public static string getTodayStr_S(int intFormat)
        {
            string strToday;
            string strYear, strMonth, strDay, strWeek;
            int intYear, intMonth, intDay;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            intDay = System.DateTime.Today.Day;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strToday = strYear + strMonth + strDay;
            strWeek = TransWeekFromEngToChs(System.DateTime.Today.DayOfWeek.ToString());

            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay;
                    break;
                case 3:
                    strToday = strYear + "��" + strMonth + "��" + strDay + "��";
                    break;
                case 4:
                    strToday = strYear + "��" + strMonth + "��" + strDay + "�� " + strWeek;
                    break;

            }
            return strToday;
        }
        /// <summary>
        /// ���ܣ���ȡ��ǰ�µ��ַ���
        /// �µĸ�ʽ��
        ///    �µ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMM��	����200501
        ///		2��YYYY-MM-DD	����2005-01
        ///		3��YYYY/MM/DD	����2005/01
        /// </summary>
        /// <param name="intFormat">�µĸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ�������µĸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ�µ��ַ���</returns>
        public static string GetCurrMonth_S(int intFormat)
        {
            string strCurrMonth;
            string strYear, strMonth;
            int intYear, intMonth;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            strCurrMonth = strYear + strMonth;
            switch (intFormat)
            {
                case 0:
                    strCurrMonth = strYear + strMonth;
                    break;
                case 1:
                    strCurrMonth = strYear + "-" + strMonth;
                    break;
                case 2:
                    strCurrMonth = strYear + "/" + strMonth;
                    break;
            }
            return strCurrMonth;
        }
        /// <summary>
        /// ��Ӣ�ĵ�����ת��Ϊ���ĵ�����
        /// </summary>
        /// <param name="strEngWeek">Ӣ���ܵ�����</param>
        /// <returns>�ܵ���������</returns>
        private static string TransWeekFromEngToChs(string strEngWeek)
        {
            if (strEngWeek == "Friday") return "������";
            else if (strEngWeek == "Monday") return "����һ";
            else if (strEngWeek == "Saturday") return "������";
            else if (strEngWeek == "Sunday") return "������";
            else if (strEngWeek == "Thursday") return "������";
            else if (strEngWeek == "Tuesday") return "���ڶ�";
            else if (strEngWeek == "Wednesday") return "������";
            else return "�������ݷǷ�!";
        }
        /// <summary>
        /// ��ȡ������ĸ����ֶε����ֵ(�ַ���)
        /// </summary>
        /// <param name="strTabName">������</param>
        /// <param name="strFldName">�����ֶ�</param>
        /// <param name="intFldLen">�ֶγ���</param>
        /// <param name="strPrefix">ǰ׺</param>
        /// <returns>���ص��ַ������ֵ</returns>
        public static string GetMaxStrId(string strTabName, string strFldName, int intFldLen, string strPrefix)
        {
            clsSpecSQLforOra mySql = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            string strMaxValue = mySql.GetMaxStrId(strTabName, strFldName, intFldLen, strPrefix);
            return strMaxValue;
        }
        /// <summary>
        /// ��ȡ������ĸ����ֶε����ֵ(�ַ���)
        /// </summary>
        /// <param name="strTabName">������</param>
        /// <param name="strFldName">�����ֶ�</param>
        /// <param name="intFldLen">�ֶγ���</param>
        /// <param name="strPrefix">ǰ׺</param>
        /// <param name="intAdditionValue">���ӵ�ֵ,���ڻ�ȡ�����ֵ�������ټ��ϸ���ֵ</param>
        /// <returns>���ص����ֵ�ַ���</returns>
        public static string GetMaxStrId(string strTabName, string strFldName, int intFldLen, string strPrefix, int intAdditionValue)
        {
            clsSpecSQLforOra mySql = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            string strMaxValue = mySql.GetMaxStrId(strTabName, strFldName, intFldLen, strPrefix, intAdditionValue);
            return strMaxValue;
        }

        /// <summary>
        /// �ж��Ƿ��Ǹ�������ֵ
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsFloat(string strValue)
        {
            int intPointNum = 0;
            //���ڴ����������
            if (strValue.Substring(0, 1) == "-") strValue = strValue.Substring(1);
            if (strValue.Substring(0, 1) == "+") strValue = strValue.Substring(1);

            char[] arrChar = strValue.ToCharArray();
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == true || arrChar[i] == '.')
                {
                }
                else
                {
                    return false;
                }
                if (arrChar[i] == '.') intPointNum++;
            }
            //����ܹ��м���С���㣬����ж���1��С���㣬�Ͳ���ȷ
            if (intPointNum > 1) return false;
            return true;
        }

        /// <summary>
        /// �ж��Ƿ���������ֵ
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsNumeric(string strValue)
        {
            int intLen = strValue.Length;
            if (intLen == 0) return false;
            //���ڴ����������
            if (strValue.Substring(0, 1) == "-") strValue = strValue.Substring(1);
            if (strValue.Substring(0, 1) == "+") strValue = strValue.Substring(1);
            intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// �ж��Ƿ���������ֵ
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsShortNumeric(string strValue)
        {
            int intLen = strValue.Length;
            int i;
            for (i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            if (i > 4)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// ����Ѿ��޸ĵ��ֶ�
        /// </summary>
        /// <param name="strFldName">�ֶ���</param>
        protected void AddUpdatedFld(string strFldName)
        {
            if (lstUpdatedFldCol.Contains(strFldName) == false)
            {
                lstUpdatedFldCol.Add(strFldName);
            }
        }

        /// <summary>
        /// ����ֶ��Ƿ��޸Ĺ���
        /// </summary>
        /// <param name="strFldName">�ֶ���</param>
        /// <returns>���� true:�޸Ĺ���false:δ�޸�</returns>
        public bool IsUpdated(string strFldName)
        {
            if (lstUpdatedFldCol.Contains(strFldName) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// ����޸�״̬,����մ洢���ֶ���Ϣ��lstUpdatedFldCol����.
        /// </summary>
        public void ClearUpdateState()
        {
            lstUpdatedFldCol.Clear();
        }

    }
}
