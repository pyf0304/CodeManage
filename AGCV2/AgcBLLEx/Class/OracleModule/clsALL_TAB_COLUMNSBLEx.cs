using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.common;
using com.taishsoft.commexception;
using com.taishsoft.commdbfororacle;

using AGC.Entity;

namespace AGC.BusinessLogicEx
{
	public class clsALL_TAB_COLUMNSBLEx : clsALL_TAB_COLUMNSEN
	{

		public clsALL_TAB_COLUMNSBLEx(): base()
		{
		}

		public clsALL_TAB_COLUMNSBLEx(string strOwnerTable_Name): base(strOwnerTable_Name)
		{
		}

		public clsALL_TAB_COLUMNSBLEx(string strOwnerTable_Name, bool bolIsGetALL_TAB_COLUMNS) : base(strOwnerTable_Name,bolIsGetALL_TAB_COLUMNS)
		{
		}

		public static System.Data.DataTable GetALL_TAB_COLUMNSEx(string strCondition)
		{
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL = "Select concat(Owner, Table_name) As OwnerTable_Name, ALL_TAB_COLUMNS.* from ALL_TAB_COLUMNS where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			return objDT;
		}
		public ArrayList GetALL_TAB_COLUMNSObjListEx(string strCondition)
		{
			ArrayList arrObjList = new ArrayList(); 
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
			strSQL = "Select  concat(Owner, Table_name) As OwnerTable_Name, ALL_TAB_COLUMNS.* from ALL_TAB_COLUMNS where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count == 0)
			{
				objDT = null;
				return arrObjList;
			}
			foreach(DataRow objRow in objDT.Rows)
			{
				clsALL_TAB_COLUMNSEN objALL_TAB_COLUMNS = new clsALL_TAB_COLUMNSEN();
				objALL_TAB_COLUMNS.OwnerTable_Name = objRow["OwnerTable_Name"].ToString().Trim();
				objALL_TAB_COLUMNS.Owner = objRow["Owner"].ToString().Trim();
				objALL_TAB_COLUMNS.Table_Name = objRow["Table_Name"].ToString().Trim();
				objALL_TAB_COLUMNS.Column_Name = objRow["Column_Name"].ToString().Trim();
				objALL_TAB_COLUMNS.Data_Type = objRow["Data_Type"].ToString().Trim();
				objALL_TAB_COLUMNS.Data_Length = Int32.Parse(objRow["Data_Length"].ToString().Trim());
				objALL_TAB_COLUMNS.Data_Precision = clsGeneralTab2.TransNullToInt_S(objRow["Data_Precision"].ToString().Trim());
				objALL_TAB_COLUMNS.Data_Scale = objRow["Data_Scale"].ToString().Trim();
				objALL_TAB_COLUMNS.Nullable = objRow["Nullable"].ToString().Trim();
				objALL_TAB_COLUMNS.Column_Id = Int32.Parse(objRow["Column_Id"].ToString().Trim());
				arrObjList.Add(objALL_TAB_COLUMNS);
			}
			objDT = null;
			return arrObjList;
		}



		///��������ĺ�������

		///���ɰ�ListView�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��ListView�С�
		/// </summary>
		//public static int BindLv_ALL_TAB_COLUMNS(System.Windows.Forms.ListView lvALL_TAB_COLUMNS, string strWhereCond)
		//{
		//	//�������裺(��4��)
		//	//	1����Ͻ�����������
		//	//	2��������������ȡ�ñ�����������DataTable��
		//	//	3������ListView����ͷ��Ϣ
		//	//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
		//	//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

		//	System.Windows.Forms.ListViewItem lviALL_TAB_COLUMNS; 
		//	ArrayList arrALL_TAB_COLUMNSObjList;
		//	//	2��������������ȡ�ñ�����������DataTable��
		//	arrALL_TAB_COLUMNSObjList = clsALL_TAB_COLUMNSBL.GetALL_TAB_COLUMNSObjList(strWhereCond);
		//	//	3������ListView����ͷ��Ϣ
		//	lvALL_TAB_COLUMNS.Items.Clear();//���ԭ������Item
		//	lvALL_TAB_COLUMNS.Columns.Clear();//���ԭ��������ͷ��Ϣ
		//	lvALL_TAB_COLUMNS.Columns.Add("ӵ���߱���", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("ӵ����", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("����", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("����", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("��������", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("���ݳ���", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("���ݾ���", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("Data_Scale", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("�ɿ�", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.Columns.Add("�к�", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvALL_TAB_COLUMNS.View = System.Windows.Forms.View.Details;
		//	//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
		//	foreach (clsALL_TAB_COLUMNSEN objALL_TAB_COLUMNS in arrALL_TAB_COLUMNSObjList)
		//	{
		//		lviALL_TAB_COLUMNS = new System.Windows.Forms.ListViewItem();
		//		lviALL_TAB_COLUMNS.Tag = objALL_TAB_COLUMNS.OwnerTable_Name;
		//		lviALL_TAB_COLUMNS.Text = objALL_TAB_COLUMNS.OwnerTable_Name;
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Owner);
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Table_Name);
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Column_Name);
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Data_Type);
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Data_Length.ToString());
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Data_Precision.ToString());
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Data_Scale);
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Nullable);
		//		lviALL_TAB_COLUMNS.SubItems.Add(objALL_TAB_COLUMNS.Column_Id.ToString());
		//		lvALL_TAB_COLUMNS.Items.Add(lviALL_TAB_COLUMNS);
		//	}
		//	//	4�����ü�¼����״̬��
		//	//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
		//	return arrALL_TAB_COLUMNSObjList.Count;
		//}
	}
}