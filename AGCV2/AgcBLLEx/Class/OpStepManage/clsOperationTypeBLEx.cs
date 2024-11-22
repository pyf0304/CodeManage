using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using AGC.Entity;
using AGC.BusinessLogic;
using System.Collections.Generic;

namespace AGC.BusinessLogicEx
{
	public class clsOperationTypeBLEx 
	{
		public const string 
			ADD_RECORD                           =    "0001", //��Ӽ�¼
			UPDATE_RECORD                        =    "0002", //�޸ļ�¼
			DELETE_RECORD		                 =    "0003", //ɾ����¼
			QUERY_RECORD		                 =    "0004", //��ѯ��¼
			LOGIN		                         =    "0005", //��¼
			LOGOUT		                         =    "0006"; //ע��
		
	


		public static System.Data.DataTable GetOpTypeId()
		{
			//��ȡĳѧԺ����רҵ��Ϣ
			string strSQL = "select OpTypeId, OpTypeName from OperationType ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public static void BindCbo_OpTypeId(System.Windows.Forms.ComboBox objComboBox)
		{
			//Ϊ����ԴΪ�����������������
			System.Data.DataTable objDT = GetOpTypeId();
			clsOperationTypeEN objOperationType;
			//��ʼ��һ�������б�
			ArrayList OperationTypeList = new ArrayList();
			//�����0��ڵ�0���в��롰��ѡ��...����Ϊ�˷����û�����WEB��ʽ���ơ�
			objOperationType = new clsOperationTypeEN();
			objOperationType.OpTypeId = "0";
			objOperationType.OpTypeName = "��ѡ��...";
			OperationTypeList.Add(objOperationType);
			//��DataTable�е���������ӵ������б���
			foreach(DataRow objRow in objDT.Rows)
			{
				objOperationType = new clsOperationTypeEN();
				objOperationType.OpTypeId = objRow["OpTypeId"].ToString();
				objOperationType.OpTypeName = objRow["OpTypeName"].ToString();
				OperationTypeList.Add(objOperationType);
			}
			//���������������Դ���Լ�����ֵ���ʾ��
			objComboBox.DataSource = OperationTypeList;
			objComboBox.ValueMember="OpTypeId";
			objComboBox.DisplayMember="OpTypeName";
			objComboBox.SelectedIndex = 0;
		}

		///��������ĺ�������
		public static void BindDdl_OpTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//Ϊ����Դ�ڱ����������������
			System.Web.UI.WebControls.ListItem li=new System.Web.UI.WebControls.ListItem("��ѡ��...","0");
			System.Data.DataTable objDT = GetOpTypeId();
			objDDL.DataValueField="OpTypeId";
			objDDL.DataTextField="OpTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}

		///���ɰ�ListView�Ĵ���
		/// <summary>
		/// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
		///			 ����ʾ��ListView�С�
		/// </summary>
		public static int BindLv_OperationType(System.Windows.Forms.ListView lvOperationType, string strWhereCond)
		{
			//�������裺(��4��)
			//	1����Ͻ�����������
			//	2��������������ȡ�ñ�����������DataTable��
			//	3������ListView����ͷ��Ϣ
			//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
			//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

			System.Windows.Forms.ListViewItem lviOperationType;
            List<clsOperationTypeEN> arrOperationTypeObjList;
			//	2��������������ȡ�ñ�����������DataTable��
			arrOperationTypeObjList = clsOperationTypeBL.GetObjLst(strWhereCond);
			//	3������ListView����ͷ��Ϣ
			lvOperationType.Items.Clear();//���ԭ������Item
			lvOperationType.Columns.Clear();//���ԭ��������ͷ��Ϣ
			lvOperationType.Columns.Add("��������Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvOperationType.Columns.Add("������������", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvOperationType.Columns.Add("˵��", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvOperationType.View = System.Windows.Forms.View.Details;
			//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
			foreach (clsOperationTypeEN objOperationType in arrOperationTypeObjList)
			{
				lviOperationType = new System.Windows.Forms.ListViewItem();
				lviOperationType.Tag = objOperationType.OpTypeId;
				lviOperationType.Text = objOperationType.OpTypeId;
				lviOperationType.SubItems.Add(objOperationType.OpTypeName);
				lviOperationType.SubItems.Add(objOperationType.Memo);
				lvOperationType.Items.Add(lviOperationType);
			}
			//	4�����ü�¼����״̬��
			//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
			return arrOperationTypeObjList.Count;
		}
	}
}