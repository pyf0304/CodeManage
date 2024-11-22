
///----------------------
///���ɴ���汾:2012.01.02.1
///��������:2012/10/08
///������:���Է�
///��������:AGC
///����ID:0005
///ģ��������:�������
///ģ��Ӣ����:RegionManage
///ע��:1����Ҫ���ݵײ�(PubDataBase.dll)�İ汾:2011.05.08.1
///       2����Ҫ����������(TzPubFunction.dll)�İ汾:2011.05.08.1
/// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using AGC.Entity;using CommonTable.Entity;
using System.Collections.Generic;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// ����������Ϣ(FeatureRegion)
    /// </summary>
    public partial class clsFeatureRegionBLEx 
    {

        ///���ɰ�ListView�Ĵ���
        /// <summary>
        /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��ListView�С�
        /// </summary>
        public static int BindLv_FeatureRegion(System.Windows.Forms.ListView lvFeatureRegion, string strWhereCond)
        {
            //��������:(��4��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3������ListView����ͷ��Ϣ
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

            System.Windows.Forms.ListViewItem lviFeatureRegion;
            List<clsFeatureRegionEN> arrFeatureRegionObjList;
            //	2��������������ȡ�ñ�����������DataTable��
            arrFeatureRegionObjList = clsFeatureRegionBL.GetObjLst(strWhereCond);
            //	3������ListView����ͷ��Ϣ
            lvFeatureRegion.Items.Clear();//���ԭ������Item
            lvFeatureRegion.Columns.Clear();//���ԭ��������ͷ��Ϣ
            lvFeatureRegion.Columns.Add("����Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegion.Columns.Add("��ť��ʽId", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegion.Columns.Add("˵��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvFeatureRegion.View = System.Windows.Forms.View.Details;
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            foreach (clsFeatureRegionEN objFeatureRegion in arrFeatureRegionObjList)
            {
                lviFeatureRegion = new System.Windows.Forms.ListViewItem();
                lviFeatureRegion.Tag = objFeatureRegion.RegionId;
                lviFeatureRegion.Text = objFeatureRegion.RegionId.ToString();
                lviFeatureRegion.SubItems.Add(objFeatureRegion.Memo);
                lvFeatureRegion.Items.Add(lviFeatureRegion);
            }
            //	4�����ü�¼����״̬,
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            return arrFeatureRegionObjList.Count;
        }

        public void InitViewRegion(clsFeatureRegionENEx objFeatureRegionENEx)
        {
     
            objFeatureRegionENEx.objViewRegionEN = clsViewRegionBL.GetObjByRegionId(objFeatureRegionENEx.RegionId);
	
        }
    }
}