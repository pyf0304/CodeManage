//----------------------
//���ɴ���汾��6.3.0.0
//�������ڣ�2008/01/27
//�����ߣ����Է�
//ע�⣺��Ҫ���ݵײ㣨PubDataBase.dll���İ汾��4.3.0.0
//========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;

namespace com.taishsoft.sql
{
    public class clsSqlStoreProcedureEx : clsSqlStoreProcedure
    {
        public ArrayList arrSpParamObjList = null;
        public clsSqlStoreProcedureEx()
            : base()
        {
            arrSpParamObjList = new ArrayList();
        }

        public clsSqlStoreProcedureEx(long lngmId)
            : base(lngmId)
        {
            arrSpParamObjList = new ArrayList();
        }

        public clsSqlStoreProcedureEx(long lngmId, bool bolIsGetSqlStoreProcedure)
            : base(lngmId, bolIsGetSqlStoreProcedure)
        {
            arrSpParamObjList = new ArrayList();
        }

        public void AddSpParamObj(clsSqlSP_Para objSqlSp_Para)
        {
            arrSpParamObjList.Add(objSqlSp_Para);
        }

      

        ///���ɰ�ListView�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��ListView�С�
        /// </summary>
        public static int BindLv_SqlStoreProcedure(System.Windows.Forms.ListView lvSqlStoreProcedure, string strWhereCond)
        {
            //	�������裺(��4��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3������ListView����ͷ��Ϣ
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

            System.Windows.Forms.ListViewItem lviSqlStoreProcedure;
            ArrayList arrSqlStoreProcedureObjList;
            //	2��������������ȡ�ñ�����������DataTable��
            arrSqlStoreProcedureObjList = new clsSqlStoreProcedure().GetSqlStoreProcedureObjList(strWhereCond);
            //	3������ListView����ͷ��Ϣ
            lvSqlStoreProcedure.Items.Clear();//���ԭ������Item
            lvSqlStoreProcedure.Columns.Clear();//���ԭ��������ͷ��Ϣ
            lvSqlStoreProcedure.Columns.Add("mId", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlStoreProcedure.Columns.Add("SP_ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlStoreProcedure.Columns.Add("�洢��������", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlStoreProcedure.Columns.Add("uid", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlStoreProcedure.View = System.Windows.Forms.View.Details;
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            foreach (clsSqlStoreProcedure objSqlStoreProcedure in arrSqlStoreProcedureObjList)
            {
                lviSqlStoreProcedure = new System.Windows.Forms.ListViewItem();
                lviSqlStoreProcedure.Tag = objSqlStoreProcedure.mId;
                lviSqlStoreProcedure.Text = objSqlStoreProcedure.mId.ToString();
                lviSqlStoreProcedure.SubItems.Add(objSqlStoreProcedure.SP_ID.ToString());
                lviSqlStoreProcedure.SubItems.Add(objSqlStoreProcedure.SP_Name);
                lviSqlStoreProcedure.SubItems.Add(objSqlStoreProcedure.uid.ToString());
                lvSqlStoreProcedure.Items.Add(lviSqlStoreProcedure);
            }
            //	4�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            return arrSqlStoreProcedureObjList.Count;
        }
    }
}