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
	public partial class clsInOutTypeBLEx 
	{
		
		

        //public static System.Data.DataTable GetInOutTypeId()
        //{
        //    //��ȡĳѧԺ����רҵ��Ϣ
        //    string strSQL = "select InOutTypeId, InOutTypeName from InOutType ";
        //    clsSpecSQLforSql mySql = new clsSpecSQLforSql();
        //    System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
        //    return objDT;
        //}
        //public static void BindCbo_InOutTypeId(System.Windows.Forms.ComboBox objComboBox)
        //{
        //    //Ϊ����ԴΪ�����������������
        //    System.Data.DataTable objDT = GetInOutTypeId();
        //    clsInOutTypeEN objInOutType;
        //    //��ʼ��һ�������б�
        //    ArrayList InOutTypeList = new ArrayList();
        //    //�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�
        //    objInOutType = new clsInOutTypeEN();
        //    objInOutType.InOutTypeId = "0";
        //    objInOutType.InOutTypeName = "��ѡ��...";
        //    InOutTypeList.Add(objInOutType);
        //    //��DataTable�е���������ӵ������б���
        //    foreach(DataRow objRow in objDT.Rows)
        //    {
        //        objInOutType = new clsInOutTypeEN();
        //        objInOutType.InOutTypeId = objRow["InOutTypeId"].ToString();
        //        objInOutType.InOutTypeName = objRow["InOutTypeName"].ToString();
        //        InOutTypeList.Add(objInOutType);
        //    }
        //    //���������������Դ���Լ�����ֵ���ʾ��
        //    objComboBox.DataSource = InOutTypeList;
        //    objComboBox.ValueMember = "InOutTypeId";
        //    objComboBox.DisplayMember = "InOutTypeName";
        //    objComboBox.SelectedIndex = 0;
        //}

		///��������ĺ��� ����
        //public static void BindDdl_InOutTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        //{
        //    //Ϊ����Դ�ڱ����������������
        //    System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("��ѡ��...","0");
        //    System.Data.DataTable objDT = GetInOutTypeId();
        //    objDDL.DataValueField = "InOutTypeId";
        //    objDDL.DataTextField = "InOutTypeName";
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
		public static int BindLv_InOutType(System.Windows.Forms.ListView lvInOutType, string strWhereCond)
		{
			//��������:(��4��)
			//	1����Ͻ�����������
			//	2��������������ȡ�ñ�����������DataTable��
			//	3������ListView����ͷ��Ϣ
			//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
			//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

			System.Windows.Forms.ListViewItem lviInOutType;
            List<clsInOutTypeEN> arrInOutTypeObjList;
			//	2��������������ȡ�ñ�����������DataTable��
			arrInOutTypeObjList = clsInOutTypeBL.GetObjLst(strWhereCond);
			//	3������ListView����ͷ��Ϣ
			lvInOutType.Items.Clear();//���ԭ������Item
			lvInOutType.Columns.Clear();//���ԭ��������ͷ��Ϣ
			lvInOutType.Columns.Add("INOUT����ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvInOutType.Columns.Add("INOUT��������", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvInOutType.Columns.Add("˵��", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvInOutType.View = System.Windows.Forms.View.Details;
			//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
			foreach (clsInOutTypeEN objInOutType in arrInOutTypeObjList)
			{
				lviInOutType = new System.Windows.Forms.ListViewItem();
				lviInOutType.Tag = objInOutType.InOutTypeId;
				lviInOutType.Text = objInOutType.InOutTypeId;
				lviInOutType.SubItems.Add(objInOutType.InOutTypeName);
				lviInOutType.SubItems.Add(objInOutType.Memo);
				lvInOutType.Items.Add(lviInOutType);
			}
			//	4�����ü�¼����״̬,
			//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
			return arrInOutTypeObjList.Count;
		}
	}
}