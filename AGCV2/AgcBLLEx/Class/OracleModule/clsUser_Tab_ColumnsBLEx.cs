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
	public class clsUser_Tab_ColumnsBLEx : clsUser_Tab_ColumnsEN
    {
        public clsUser_Tab_ColumnsBLEx(): base()
		{
        }

        public clsUser_Tab_ColumnsBLEx(string strTable_Name_Column_Name): base(strTable_Name_Column_Name)
		{
        }
        public clsUser_Tab_ColumnsBLEx(string server,string strSID,string uid,string pwd):base(server, strSID, uid, pwd)
		{

		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
		public System.Data.DataTable GetUser_Tab_ColumnsEx(string strCondition)
		{
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = null;
			if (this.IsHaveSpecialConnectString)
			{
				objSQL = new clsSpecSQLforOra(this.Server_Tz, this.SID, this.UserID, this.Password_Tz);
			}
			else
			{
				objSQL = new clsSpecSQLforOra();
			}
			strSQL = "Select  concat(Table_Name, Column_name) As Table_Name_Column_Name, User_Tab_Columns.* from User_Tab_Columns where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			
			return objDT;
		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
		public ArrayList GetUser_Tab_ColumnsObjListEx(string strCondition)
		{
			ArrayList arrObjList = new ArrayList(); 
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQLforOra objSQL = null;
			if (this.IsHaveSpecialConnectString)
			{
				objSQL = new clsSpecSQLforOra(this.Server_Tz, this.SID, this.UserID, this.Password_Tz);
			}
			else
			{
				objSQL = new clsSpecSQLforOra();
			}
			strSQL = "Select  concat(Table_Name, Column_name) As Table_Name_Column_Name, User_Tab_Columns.* from User_Tab_Columns where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			if (objDT.Rows.Count == 0)
			{
				objDT = null;
				return arrObjList;
			}
			foreach(DataRow objRow in objDT.Rows)
			{
				clsUser_Tab_ColumnsEN objUser_Tab_Columns = new clsUser_Tab_ColumnsEN();
				objUser_Tab_Columns.Table_Name_Column_Name = objRow["Table_Name_Column_Name"].ToString().Trim();
				objUser_Tab_Columns.Table_Name = objRow["Table_Name"].ToString().Trim();
				objUser_Tab_Columns.Column_Id = Int32.Parse(objRow["Column_Id"].ToString().Trim());
				objUser_Tab_Columns.Column_Name = objRow["Column_Name"].ToString().Trim();
				objUser_Tab_Columns.Data_Length = Int32.Parse(objRow["Data_Length"].ToString().Trim());
				objUser_Tab_Columns.Data_Precision = TransNullToInt(objRow["Data_Precision"].ToString().Trim());
				objUser_Tab_Columns.Data_Scale = objRow["Data_Scale"].ToString().Trim();
				objUser_Tab_Columns.Data_Type = objRow["Data_Type"].ToString().Trim();
				objUser_Tab_Columns.Nullable = objRow["Nullable"].ToString().Trim();
				arrObjList.Add(objUser_Tab_Columns);
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
		//public static int BindLv_User_Tab_Columns(System.Windows.Forms.ListView lvUser_Tab_Columns, string strWhereCond)
		//{
		//	//�������裺(��4��)
		//	//	1����Ͻ�����������
		//	//	2��������������ȡ�ñ�����������DataTable��
		//	//	3������ListView����ͷ��Ϣ
		//	//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
		//	//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

		//	System.Windows.Forms.ListViewItem lviUser_Tab_Columns; 
		//	ArrayList arrUser_Tab_ColumnsObjList;
		//	//	2��������������ȡ�ñ�����������DataTable��
		//	arrUser_Tab_ColumnsObjList = clsUser_Tab_ColumnsBL.GetUser_Tab_ColumnsObjList(strWhereCond);
		//	//	3������ListView����ͷ��Ϣ
		//	lvUser_Tab_Columns.Items.Clear();//���ԭ������Item
		//	lvUser_Tab_Columns.Columns.Clear();//���ԭ��������ͷ��Ϣ
		//	lvUser_Tab_Columns.Columns.Add("��������", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.Columns.Add("����", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.Columns.Add("�к�", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.Columns.Add("����", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.Columns.Add("���ݳ���", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.Columns.Add("���ݾ���", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.Columns.Add("Data_Scale", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.Columns.Add("��������", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.Columns.Add("�ɿ�", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Tab_Columns.View = System.Windows.Forms.View.Details;
		//	//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
		//	foreach (clsUser_Tab_ColumnsEN objUser_Tab_Columns in arrUser_Tab_ColumnsObjList)
		//	{
		//		lviUser_Tab_Columns = new System.Windows.Forms.ListViewItem();
		//		lviUser_Tab_Columns.Tag = objUser_Tab_Columns.Table_Name_Column_Name;
		//		lviUser_Tab_Columns.Text = objUser_Tab_Columns.Table_Name_Column_Name;
		//		lviUser_Tab_Columns.SubItems.Add(objUser_Tab_Columns.Table_Name);
		//		lviUser_Tab_Columns.SubItems.Add(objUser_Tab_Columns.Column_Id.ToString());
		//		lviUser_Tab_Columns.SubItems.Add(objUser_Tab_Columns.Column_Name);
		//		lviUser_Tab_Columns.SubItems.Add(objUser_Tab_Columns.Data_Length.ToString());
		//		lviUser_Tab_Columns.SubItems.Add(objUser_Tab_Columns.Data_Precision.ToString());
		//		lviUser_Tab_Columns.SubItems.Add(objUser_Tab_Columns.Data_Scale);
		//		lviUser_Tab_Columns.SubItems.Add(objUser_Tab_Columns.Data_Type);
		//		lviUser_Tab_Columns.SubItems.Add(objUser_Tab_Columns.Nullable);
		//		lvUser_Tab_Columns.Items.Add(lviUser_Tab_Columns);
		//	}
		//	//	4�����ü�¼����״̬��
		//	//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
		//	return arrUser_Tab_ColumnsObjList.Count;
		//}
	}
}