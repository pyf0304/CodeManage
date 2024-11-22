using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using com.taishsoft.sql;
namespace AGC.BusinessLogicEx
{
    public class clsColumnsBLEx : clsColumns
    {


        ///���ɰ�ListView�Ĵ���
        /// <summary>
        /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��ListView�С�
        /// </summary>
        public static int BindLv_Columns(System.Windows.Forms.ListView lvColumns, string strWhereCond)
        {
            //��������:(��4��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3������ListView����ͷ��Ϣ
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

            System.Windows.Forms.ListViewItem lviColumns;
            ArrayList arrColumnsObjList;
            //	2��������������ȡ�ñ�����������DataTable��
            arrColumnsObjList = new clsColumns().GetColumnsObjList(strWhereCond);
            //	3������ListView����ͷ��Ϣ
            lvColumns.Items.Clear();//���ԭ������Item
            lvColumns.Columns.Clear();//���ԭ��������ͷ��Ϣ
            lvColumns.Columns.Add("����", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvColumns.Columns.Add("��������", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvColumns.Columns.Add("�ֶγ���", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvColumns.Columns.Add("�Ƿ�ɿ�", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvColumns.View = System.Windows.Forms.View.Details;
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            foreach (clsColumns objColumns in arrColumnsObjList)
            {
                lviColumns = new System.Windows.Forms.ListViewItem();
                lviColumns.Tag = objColumns.Column_Name;
                lviColumns.Text = objColumns.Column_Name;
                lviColumns.SubItems.Add(objColumns.Type_Name);
                lviColumns.SubItems.Add(objColumns.length.ToString());
                lviColumns.SubItems.Add(objColumns.Is_Nullable);
                lvColumns.Items.Add(lviColumns);
            }
            //	4�����ü�¼����״̬,
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            return arrColumnsObjList.Count;
        }
    }
}