using AGC.BusinessLogic;
using AGC.Entity;
using com.taishsoft.commdb;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AGC.BusinessLogicEx
{
    public partial class clsViewTypeCodeTabBLEx : clsViewTypeCodeTabBL
    {
        public const enumViewTypeCodeTab
            JAVA_ADD = enumViewTypeCodeTab.Table_Insert_1,// "0013", //JAVA�������
            JAVA_LIST = enumViewTypeCodeTab.Table_List_14,// "0014", //JAVA�б����
            JAVA_QUERY = enumViewTypeCodeTab.Table_Query_3,//  "0015", //JAVA�����ѯ
            JAVA_UPDATE = enumViewTypeCodeTab.Table_Update_2,// "0016", //JAVA�����޸�
            JAVA_DETAIL = enumViewTypeCodeTab.Table_Detail_17;// "0017"; //JAVA��ϸ��Ϣ����


      
        ///���ɰ�ListView�Ĵ���
        /// <summary>
        /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��ListView�С�
        /// </summary>
        public static int BindLv_ViewTypeCodeTab(System.Windows.Forms.ListView lvViewTypeCodeTab, string strWhereCond)
        {
            //��������:(��4��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3������ListView����ͷ��Ϣ
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

            System.Windows.Forms.ListViewItem lviViewTypeCodeTab;
            List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjList;
            //	2��������������ȡ�ñ�����������DataTable��
            arrViewTypeCodeTabObjList = clsViewTypeCodeTabBL.GetObjLst(strWhereCond);
            //	3������ListView����ͷ��Ϣ
            lvViewTypeCodeTab.Items.Clear();//���ԭ������Item
            lvViewTypeCodeTab.Columns.Clear();//���ԭ��������ͷ��Ϣ
            lvViewTypeCodeTab.Columns.Add("����������", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewTypeCodeTab.Columns.Add("������������", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewTypeCodeTab.Columns.Add("���湦��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewTypeCodeTab.Columns.Add("��������", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewTypeCodeTab.Columns.Add("����˵��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewTypeCodeTab.Columns.Add("Ӧ�ó�������ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewTypeCodeTab.View = System.Windows.Forms.View.Details;
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            foreach (clsViewTypeCodeTabEN objViewTypeCodeTab in arrViewTypeCodeTabObjList)
            {
                lviViewTypeCodeTab = new System.Windows.Forms.ListViewItem();
                lviViewTypeCodeTab.Tag = objViewTypeCodeTab.ViewTypeCode;
                lviViewTypeCodeTab.Text = objViewTypeCodeTab.ViewTypeCode.ToString("00");
                lviViewTypeCodeTab.SubItems.Add(objViewTypeCodeTab.ViewTypeName);
                lviViewTypeCodeTab.SubItems.Add(objViewTypeCodeTab.ViewFunction);
                lviViewTypeCodeTab.SubItems.Add(objViewTypeCodeTab.OptProcess);
                lviViewTypeCodeTab.SubItems.Add(objViewTypeCodeTab.ViewDetail);
                lviViewTypeCodeTab.SubItems.Add(objViewTypeCodeTab.ApplicationTypeId.ToString("00"));
                lvViewTypeCodeTab.Items.Add(lviViewTypeCodeTab);
            }
            //	4�����ü�¼����״̬,
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            return arrViewTypeCodeTabObjList.Count;
        }
        /// <summary>
        /// �����Ľ������ʹ����Ƿ���WinӦ��
        /// </summary>
        /// <param name="thisViewTypeCodeTab">�����Ľ������ʹ���</param>
        /// <returns></returns>
        public static bool IsWinViewTypeCode(enumViewTypeCodeTab thisViewTypeCodeTab)
        {
            clsViewTypeCodeTabEN objViewTypeCodeTabEN = clsViewTypeCodeTabBL.GetObjByViewTypeCode((int)thisViewTypeCodeTab);
            return objViewTypeCodeTabEN.IsWinApp;
        }

        /// <summary>
        /// �󶨻���Web��������-ʹ��Cache
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunctionCache)
        /// </summary>
        /// <param name = "objDDL">��Ҫ�󶨵�ǰ���������</param>
        /// <param name = "strApplicationTypeId">��Ҫ�󶨵�ǰ���������</param>
        public static void BindDdl_ViewTypeCodeByAppIdCache(System.Web.UI.WebControls.DropDownList objDDL, int strApplicationTypeId)
        {
            if (strApplicationTypeId == 0) return;
            //Ϊ����Դ�ڱ����������������
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("��ѡ��...", "0");
            List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst = GetViewTypeCodeTabObjLstByApplicationTypeIdCache(strApplicationTypeId);
            if (arrViewTypeCodeTabObjLst == null)
            {
                return;
                //string strMsg = string.Format("Ӧ��:[{0}]û����Ӧ��ҳ�����ͣ�����ϵ����Ա��", clsApplicationTypeBL.GetNameByApplicationTypeIdCache(strApplicationTypeId));
                //throw new Exception(strMsg);
            }
            IEnumerable<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst_Sel = arrViewTypeCodeTabObjLst.OrderBy(x => x.OrderNum);
            objDDL.DataValueField = conViewTypeCodeTab.ViewTypeCode;
            objDDL.DataTextField = conViewTypeCodeTab.ViewTypeName;
            objDDL.DataSource = arrViewTypeCodeTabObjLst_Sel;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.û�оͷ���null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetRecObjByKeyCache)
        /// </summary>
        /// <param name = "intApplicationTypeId">�����Ĺؼ���</param>
        /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>
        public static List<clsViewTypeCodeTabEN> GetViewTypeCodeTabObjLstByApplicationTypeIdCache(int intApplicationTypeId)
        {
            //��ʼ���б���
            List<clsViewTypeCodeTabEN> arrObjLstCache = clsViewTypeCodeTabBL.GetObjLstCache();

            IEnumerable<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst_Sel1 =
            from objViewTypeCodeTabEN in arrObjLstCache
            where objViewTypeCodeTabEN.ApplicationTypeId == intApplicationTypeId
            select objViewTypeCodeTabEN;
            List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst_Sel = new List<clsViewTypeCodeTabEN>();
            foreach (clsViewTypeCodeTabEN obj in arrViewTypeCodeTabObjLst_Sel1)
            {
                arrViewTypeCodeTabObjLst_Sel.Add(obj);
            }
            if (arrViewTypeCodeTabObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrViewTypeCodeTabObjLst_Sel;
        }

    }
}