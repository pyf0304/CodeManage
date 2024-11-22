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
	public partial class clsRegionTypeBLEx 
	{
        //public const string
        //    QUERYREGION = "0001",
        //    FUNCTIONREGION = "0008",
        //    DGREGION = "0002",
        //    EDITREGION = "0003",
        //    LISTVIEWREGION = "0004",
        //    TREEVIEWREGION = "0005",
        //    DETAILREGION = "0006",
        //    EXCELEXPORT_REGION = "0007";

		

		public static System.Data.DataTable GetRegionTypeId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select RegionTypeId, RegionTypeName from RegionType ";
			clsSpecSQLforSql mySql = new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
        //public static void BindCbo_RegionTypeId(System.Windows.Forms.ComboBox objComboBox)
        //{
        //    //Ϊ����ԴΪ�����������������
        //    System.Data.DataTable objDT = GetRegionTypeId();
        //    clsRegionTypeEN objRegionType;
        //    //��ʼ��һ�������б�
        //    ArrayList RegionTypeList = new ArrayList();
        //    //�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�
        //    objRegionType = new clsRegionTypeEN();
        //    objRegionType.RegionTypeId = "0";
        //    objRegionType.RegionTypeName = "��ѡ��...";
        //    RegionTypeList.Add(objRegionType);
        //    //��DataTable�е���������ӵ������б���
        //    foreach(DataRow objRow in objDT.Rows)
        //    {
        //        objRegionType = new clsRegionTypeEN();
        //        objRegionType.RegionTypeId = objRow["RegionTypeId"].ToString();
        //        objRegionType.RegionTypeName = objRow["RegionTypeName"].ToString();
        //        RegionTypeList.Add(objRegionType);
        //    }
        //    //���������������Դ���Լ�����ֵ���ʾ��
        //    objComboBox.DataSource = RegionTypeList;
        //    objComboBox.ValueMember = "RegionTypeId";
        //    objComboBox.DisplayMember = "RegionTypeName";
        //    objComboBox.SelectedIndex = 0;
        //}

		///��������ĺ��� ����
        //public static void BindDdl_RegionTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        //{
        //    //Ϊ����Դ�ڱ����������������
        //    System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("��ѡ��...","0");
        //    System.Data.DataTable objDT = GetRegionTypeId();
        //    objDDL.DataValueField = "RegionTypeId";
        //    objDDL.DataTextField = "RegionTypeName";
        //    objDDL.DataSource = objDT;
        //    objDDL.DataBind();
        //    objDDL.Items.Insert(0, li);
        //    objDDL.SelectedIndex = 0;
        //}

		///���ɰ�ListView�Ĵ���
		/// <summary>
		/// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
		///			 ����ʾ��ListView�С�
		/// </summary>
		public static int BindLv_RegionType(System.Windows.Forms.ListView lvRegionType, string strWhereCond)
		{
			//��������:(��4��)
			//	1����Ͻ�����������
			//	2��������������ȡ�ñ�����������DataTable��
			//	3������ListView����ͷ��Ϣ
			//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
			//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

			System.Windows.Forms.ListViewItem lviRegionType;
            List<clsRegionTypeEN> arrRegionTypeObjList;
			//	2��������������ȡ�ñ�����������DataTable��
			arrRegionTypeObjList = clsRegionTypeBL.GetObjLst(strWhereCond);
			//	3������ListView����ͷ��Ϣ
			lvRegionType.Items.Clear();//���ԭ������Item
			lvRegionType.Columns.Clear();//���ԭ��������ͷ��Ϣ
			lvRegionType.Columns.Add("��������Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvRegionType.Columns.Add("������������", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvRegionType.Columns.Add("˵��", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvRegionType.View = System.Windows.Forms.View.Details;
			//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
			foreach (clsRegionTypeEN objRegionType in arrRegionTypeObjList)
			{
				lviRegionType = new System.Windows.Forms.ListViewItem();
				lviRegionType.Tag = objRegionType.RegionTypeId;
				lviRegionType.Text = objRegionType.RegionTypeId;
				lviRegionType.SubItems.Add(objRegionType.RegionTypeName);
				lviRegionType.SubItems.Add(objRegionType.Memo);
				lvRegionType.Items.Add(lviRegionType);
			}
			//	4�����ü�¼����״̬,
			//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
			return arrRegionTypeObjList.Count;
		}
	}
}