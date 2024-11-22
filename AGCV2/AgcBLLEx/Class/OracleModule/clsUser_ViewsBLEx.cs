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
	public class clsUser_ViewsBLEx : clsUser_ViewsEN
	{

		public clsUser_ViewsBLEx(): base()
		{
		}

		public clsUser_ViewsBLEx(string strView_Name): base(strView_Name)
		{
		}

		public clsUser_ViewsBLEx(string strView_Name, bool bolIsGetUser_Views) : base(strView_Name,bolIsGetUser_Views)
		{
		}

		public clsUser_ViewsBLEx(string server,string strSID,string uid,string pwd):base(server, strSID, uid, pwd)
		{

		}
		public System.Data.DataTable GetUser_ViewsEx(string strCondition)
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
			strSQL = "Select * from User_Views where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			return objDT;
		}


		/////���ɰ�ListView�Ĵ���
		///// <summary>
		///// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		/////			 ����ʾ��ListView�С�
		///// </summary>
		//public static int BindLv_User_Views(System.Windows.Forms.ListView lvUser_Views, string strWhereCond)
		//{
		//	//�������裺(��4��)
		//	//	1����Ͻ�����������
		//	//	2��������������ȡ�ñ�����������DataTable��
		//	//	3������ListView����ͷ��Ϣ
		//	//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
		//	//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

		//	System.Windows.Forms.ListViewItem lviUser_Views; 
		//	ArrayList arrUser_ViewsObjList;
		//	//	2��������������ȡ�ñ�����������DataTable��
		//	arrUser_ViewsObjList = clsUser_ViewsBL.GetUser_ViewsObjList(strWhereCond);
		//	//	3������ListView����ͷ��Ϣ
		//	lvUser_Views.Items.Clear();//���ԭ������Item
		//	lvUser_Views.Columns.Clear();//���ԭ��������ͷ��Ϣ
		//	lvUser_Views.Columns.Add("��ͼ��", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Views.Columns.Add("�ı�����", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Views.Columns.Add("�ı�����", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvUser_Views.View = System.Windows.Forms.View.Details;
		//	//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
		//	foreach (clsUser_ViewsEN objUser_Views in arrUser_ViewsObjList)
		//	{
		//		lviUser_Views = new System.Windows.Forms.ListViewItem();
		//		lviUser_Views.Tag = objUser_Views.View_Name;
		//		lviUser_Views.Text = objUser_Views.View_Name;
		//		lviUser_Views.SubItems.Add(objUser_Views.Text);
		//		lviUser_Views.SubItems.Add(objUser_Views.Text_Length.ToString());
		//		lvUser_Views.Items.Add(lviUser_Views);
		//	}
		//	//	4�����ü�¼����״̬��
		//	//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
		//	return arrUser_ViewsObjList.Count;
		//}
	}
}