using System;
using System.Web.UI.WebControls;
using com.taishsoft.commdb;

namespace AGC.Webform
{
	/// <summary>
	/// clsCommForWebForm ��ժҪ˵����
	/// </summary>
	public class clsCommForWebFormBak
	{
//		public const string strPrjId = "0001";
		public clsCommForWebFormBak()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		public static System.Data.DataTable GetCollege()
		{
			//��ȡѧԺ������Ϣ
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable("select Name, clgId from college");
			return objDT;
		}

		public static System.Data.DataTable GetMajor(string strClgId)
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select Name, MajorId from Major where ClgId='" + strClgId + "'";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}

		public static void BindDdl_College(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ������ѧԺ��������
			ListItem li=new ListItem("��ѡ��...","��ѡ��...");
			System.Data.DataTable objDT = clsCommForWebFormBak.GetCollege();
			objDDL.DataValueField="ClgId";
			objDDL.DataTextField="Name";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}

		public static void BingDdl_Major(System.Web.UI.WebControls.DropDownList objDDL, 
									string strClgId)
		{
			//Ϊ������רҵ��������	
			ListItem li=new ListItem("��ѡ��...","��ѡ��...");
			System.Data.DataTable objDT = clsCommForWebFormBak.GetMajor(strClgId);
			if (objDT.Rows.Count >0 )
			{
				objDDL.DataValueField="MajorId";
				objDDL.DataTextField="Name";
				objDDL.DataSource = objDT;
				objDDL.DataBind();
			}
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}

		

	}
}
