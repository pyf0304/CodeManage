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
    public class clsSqlSP_ParaEx : clsSqlSP_Para
    {

        public clsSqlSP_ParaEx()
            : base()
        {
        }

        public clsSqlSP_ParaEx(long lngmId)
            : base(lngmId)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lngmId"></param>
        /// <param name="bolIsGetSqlSP_Para"></param>
        public clsSqlSP_ParaEx(long lngmId, bool bolIsGetSqlSP_Para)
            : base(lngmId, bolIsGetSqlSP_Para)
        {
        }

        ///���ɰ�ListView�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��ListView�С�
        /// </summary>
        public static int BindLv_SqlSP_Para(System.Windows.Forms.ListView lvSqlSP_Para, string strWhereCond)
        {
            //	�������裺(��4��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3������ListView����ͷ��Ϣ
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

            System.Windows.Forms.ListViewItem lviSqlSP_Para;
            ArrayList arrSqlSP_ParaObjList;
            //	2��������������ȡ�ñ�����������DataTable��
            arrSqlSP_ParaObjList = new clsSqlSP_Para().GetSqlSP_ParaObjList(strWhereCond);
            //	3������ListView����ͷ��Ϣ
            lvSqlSP_Para.Items.Clear();//���ԭ������Item
            lvSqlSP_Para.Columns.Clear();//���ԭ��������ͷ��Ϣ
            lvSqlSP_Para.Columns.Add("mId", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlSP_Para.Columns.Add("�洢����ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlSP_Para.Columns.Add("������", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlSP_Para.Columns.Add("��������", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlSP_Para.Columns.Add("������������", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlSP_Para.Columns.Add("������������", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlSP_Para.Columns.Add("�Ƿ�ɿ�", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSqlSP_Para.View = System.Windows.Forms.View.Details;
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            foreach (clsSqlSP_Para objSqlSP_Para in arrSqlSP_ParaObjList)
            {
                lviSqlSP_Para = new System.Windows.Forms.ListViewItem();
                lviSqlSP_Para.Tag = objSqlSP_Para.mId;
                lviSqlSP_Para.Text = objSqlSP_Para.mId.ToString();
                lviSqlSP_Para.SubItems.Add(objSqlSP_Para.id_StoreProcedure.ToString());
                lviSqlSP_Para.SubItems.Add(objSqlSP_Para.ParaName);
                lviSqlSP_Para.SubItems.Add(objSqlSP_Para.ParaSize.ToString());
                lviSqlSP_Para.SubItems.Add(objSqlSP_Para.ParaDataType);
                lviSqlSP_Para.SubItems.Add(objSqlSP_Para.ParaDirection);
                lviSqlSP_Para.SubItems.Add(objSqlSP_Para.IsNullable.ToString());
                lvSqlSP_Para.Items.Add(lviSqlSP_Para);
            }
            //	4�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            return arrSqlSP_ParaObjList.Count;
        }
    }
}