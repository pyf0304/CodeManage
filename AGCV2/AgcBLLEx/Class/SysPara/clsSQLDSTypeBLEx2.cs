using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using AGC.Entity;
using System.Collections.Generic;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
	public partial class clsSQLDSTypeBLEx 
	{
		public const string 
			SQLTAB                               = "01", //SQL��
			SQLVIEW                              = "02"; //SQL��ͼ

		

		///���ɰ�ListView�Ĵ���
		/// <summary>
		/// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
		///			 ����ʾ��ListView�С�
		/// </summary>
		public static int BindLv_SQLDSType(System.Windows.Forms.ListView lvSQLDSType, string strWhereCond)
		{
			//��������:(��4��)
			//	1����Ͻ�����������
			//	2��������������ȡ�ñ�����������DataTable��
			//	3������ListView����ͷ��Ϣ
			//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
			//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

			System.Windows.Forms.ListViewItem lviSQLDSType;
            List<clsSQLDSTypeEN> arrSQLDSTypeObjList;
			//	2��������������ȡ�ñ�����������DataTable��
			arrSQLDSTypeObjList = clsSQLDSTypeBL.GetObjLst(strWhereCond);
			//	3������ListView����ͷ��Ϣ
			lvSQLDSType.Items.Clear();//���ԭ������Item
			lvSQLDSType.Columns.Clear();//���ԭ��������ͷ��Ϣ
			lvSQLDSType.Columns.Add("�������Դ����", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvSQLDSType.Columns.Add("Sql����Դ��", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvSQLDSType.Columns.Add("˵��", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvSQLDSType.View = System.Windows.Forms.View.Details;
			//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
			foreach (clsSQLDSTypeEN objSQLDSType in arrSQLDSTypeObjList)
			{
				lviSQLDSType = new System.Windows.Forms.ListViewItem();
				lviSQLDSType.Tag = objSQLDSType.SqlDsTypeId;
				lviSQLDSType.Text = objSQLDSType.SqlDsTypeId;
				lviSQLDSType.SubItems.Add(objSQLDSType.SqlDsTypeName);
				lviSQLDSType.SubItems.Add(objSQLDSType.Memo);
				lvSQLDSType.Items.Add(lviSQLDSType);
			}
			//	4�����ü�¼����״̬,
			//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
			return arrSQLDSTypeObjList.Count;
		}
	}
}