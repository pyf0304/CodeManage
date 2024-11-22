using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using com.taishsoft.commexception;
using com.taishsoft.common;
using AGC.Entity;
using System.Collections.Generic;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
	public partial class clsQueryRegionBLEx 
	{
        /// <summary>
        /// ��������Id��ȡ�û������������ر�Id
        /// </summary>
        /// <param name="lngRegionId"></param>
        /// <returns></returns>
        public static List<string> getRelaTabId4Ddl1(string lngRegionId, bool bolIsFstLcase, string strCmPrjId)
        {
            string strCondition = string.Format("{0}={1}",
                conQryRegionFlds.RegionId, lngRegionId);

            List<string> arrTabId = new List<string>();
            List<clsQryRegionFldsENEx> arrObjENExList = clsQryRegionFldsBLEx.GetObjExLstByRegionIdCache4InUse1(lngRegionId, bolIsFstLcase, strCmPrjId);
            
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in arrObjENExList)
            {
                if (objQryRegionFldsEx.CtlTypeId != enumCtlType.DropDownList_06) continue;
                string strTabId = objQryRegionFldsEx.DsTabId;
                if (string.IsNullOrEmpty(strTabId) == true) continue;
                if (arrTabId.Contains(strTabId) == false) arrTabId.Add(strTabId);
            }

            return arrTabId;
        }

  //      public static void InitViewRegion(clsQueryRegionENEx objQueryRegionENEx)
		//{
  //          objQueryRegionENEx.objViewRegionEN = clsViewRegionBL.GetObjByRegionId(objQueryRegionENEx.RegionId);
		//}


		/////���ɰ�ListView�Ĵ���
		///// <summary>
		///// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
		/////			 ����ʾ��ListView�С�
		///// </summary>
		//public static int BindLv_QueryRegion(System.Windows.Forms.ListView lvQueryRegion, string strWhereCond)
		//{
		//	//��������:(��4��)
		//	//	1����Ͻ�����������
		//	//	2��������������ȡ�ñ�����������DataTable��
		//	//	3������ListView����ͷ��Ϣ
		//	//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
		//	//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

		//	System.Windows.Forms.ListViewItem lviQueryRegion;
  //          List<clsQueryRegionEN> arrQueryRegionObjList;
		//	//	2��������������ȡ�ñ�����������DataTable��
		//	arrQueryRegionObjList = clsQueryRegionBL.GetObjLst(strWhereCond);
		//	//	3������ListView����ͷ��Ϣ
		//	lvQueryRegion.Items.Clear();//���ԭ������Item
		//	lvQueryRegion.Columns.Clear();//���ԭ��������ͷ��Ϣ
		//	lvQueryRegion.Columns.Add("����Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvQueryRegion.Columns.Add("����", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvQueryRegion.Columns.Add("�Ƿ�ʹ�ÿؼ�", 100, System.Windows.Forms.HorizontalAlignment.Left);
		//	lvQueryRegion.View = System.Windows.Forms.View.Details;
		//	//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
		//	foreach (clsQueryRegionEN objQueryRegion in arrQueryRegionObjList)
		//	{
		//		lviQueryRegion = new System.Windows.Forms.ListViewItem();
		//		lviQueryRegion.Tag = objQueryRegion.RegionId;
		//		lviQueryRegion.Text = objQueryRegion.RegionId.ToString();
		//		//lviQueryRegion.SubItems.Add(objQueryRegion.ColNum.ToString());
		//		lviQueryRegion.SubItems.Add(objQueryRegion.IsUseCtrl.ToString());
		//		lvQueryRegion.Items.Add(lviQueryRegion);
		//	}
		//	//	4�����ü�¼����״̬,
		//	//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
		//	return arrQueryRegionObjList.Count;
		//}
	
	}
}