///----------------------
///���ɴ���汾��6.3.0.0
///�������ڣ�2008/03/10
///�����ߣ�������
///ע�⣺��Ҫ���ݵײ㣨PubDataBase.dll���İ汾��4.3.0.0
///========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;

namespace EcardDataClass
{
    public class clsperson_q_SEx : clsPERSON_q_S
    {

        public clsperson_q_SEx()
            : base()
        {
        }

        public clsperson_q_SEx(string strACCOUNT)
            : base(strACCOUNT)
        {
        }

        public clsperson_q_SEx(string strACCOUNT, bool bolIsGetperson_q)
            : base(strACCOUNT, bolIsGetperson_q)
        {
        }
        public static DataTable GetPerson_qDataTable(string strCondition)
        {
            string strSQL;
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            DataTable objDT = new DataTable();
            //��ȡ���Ӷ���
            objSQL = clsPERSON_q_S.GetSpecSQLObj();
            strSQL = "Select * from person_q where " + strCondition;
            objDS = objSQL.GetDataSet(strSQL, "person_q");
            objDT = objDS.Tables[0];
            return objDT;
        }
    }
}