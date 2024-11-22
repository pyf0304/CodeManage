using AGC.BusinessLogic;
using AGC.Entity;
using System.Collections.Generic;

namespace AGC.BusinessLogicEx
{
    public partial class clsPrimaryTypeNameBLEx 
	{

		public const string 
			NONE_PRIMARYKEY = "00",
			PRIMARYKEY = "01",
			IDENTITY_PRIMARYKEY = "02";
		


		///���ɰ�ListView�Ĵ���
		/// <summary>
		/// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
		///			 ����ʾ��ListView�С�
		/// </summary>
		public static int BindLv_PrimaryTypeName(System.Windows.Forms.ListView lvPrimaryTypeName, string strWhereCond)
		{
			//��������:(��4��)
			//	1����Ͻ�����������
			//	2��������������ȡ�ñ�����������DataTable��
			//	3������ListView����ͷ��Ϣ
			//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
			//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

			System.Windows.Forms.ListViewItem lviPrimaryTypeName;
            List<clsPrimaryTypeEN> arrPrimaryTypeNameObjList;
			//	2��������������ȡ�ñ�����������DataTable��
			arrPrimaryTypeNameObjList = clsPrimaryTypeBL.GetObjLst(strWhereCond);
			//	3������ListView����ͷ��Ϣ
			lvPrimaryTypeName.Items.Clear();//���ԭ������Item
			lvPrimaryTypeName.Columns.Clear();//���ԭ��������ͷ��Ϣ
			lvPrimaryTypeName.Columns.Add("��������ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvPrimaryTypeName.Columns.Add("����������", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvPrimaryTypeName.Columns.Add("˵��", 100, System.Windows.Forms.HorizontalAlignment.Left);
			lvPrimaryTypeName.View = System.Windows.Forms.View.Details;
			//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
			foreach (clsPrimaryTypeEN objPrimaryType in arrPrimaryTypeNameObjList)
			{
				lviPrimaryTypeName = new System.Windows.Forms.ListViewItem();
				lviPrimaryTypeName.Tag = objPrimaryType.PrimaryTypeId;
				lviPrimaryTypeName.Text = objPrimaryType.PrimaryTypeId;
				lviPrimaryTypeName.SubItems.Add(objPrimaryType.PrimaryTypeName);
				lviPrimaryTypeName.SubItems.Add(objPrimaryType.Memo);
				lvPrimaryTypeName.Items.Add(lviPrimaryTypeName);
			}
			//	4�����ü�¼����״̬,
			//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
			return arrPrimaryTypeNameObjList.Count;
		}
	}
}