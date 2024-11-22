
using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AGC.BusinessLogicEx
{
    public partial class clsApplicationTypeBLEx
    {
        public const int
            WINDOWSAPP = 1, //���ť
            DOTNETWEBAPP = 2, //����
            AspMvcAPP = 13, //����
            JAVAWEBAPP = 3, //�����б�
            ANDROIDAPP = 5; //�����б�

        public static List<string> GetProgLangTypeIdLst(int intApplicationTypeId)
        {
            clsApplicationTypeEN objApplicationTypeEN = clsApplicationTypeBL.GetObjByApplicationTypeIdCache(intApplicationTypeId);
            List<string> arrProgLangTypeId = new List<string>();
            if (string.IsNullOrEmpty(objApplicationTypeEN.ProgLangTypeId) == false)
            {
                arrProgLangTypeId.Add(objApplicationTypeEN.ProgLangTypeId);
            }
            if (string.IsNullOrEmpty(objApplicationTypeEN.ProgLangTypeId2) == false)
            {
                arrProgLangTypeId.Add(objApplicationTypeEN.ProgLangTypeId2);
            }
            if (string.IsNullOrEmpty(objApplicationTypeEN.ProgLangTypeId3) == false)
            {
                arrProgLangTypeId.Add(objApplicationTypeEN.ProgLangTypeId3);
            }
            return arrProgLangTypeId;
        }
        /// <summary>
        /// �󶨻���Web��������
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">��Ҫ�󶨵�ǰ���������</param>
        public static void BindDdl_ApplicationTypeIdExCache(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("��ѡ��[Ӧ�ó�������]...", "0");
            //string strCondition = string.Format("{0} = '1' Order By {1},{2}",
            //    conApplicationType.IsVisible,
            //    conApplicationType.VisitedNum,
            //    conApplicationType.OrderNum);
            List<clsApplicationTypeEN> arrObjLst = clsApplicationTypeBL.GetObjLstCache()
                .Where(x=>x.IsVisible == true)
                .OrderBy(x=>x.VisitedNum)
                .ThenBy(x=>x.OrderNum)
                .ToList();

            objDDL.DataValueField = conApplicationType.ApplicationTypeId;
            objDDL.DataTextField = conApplicationType.ApplicationTypeName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// �󶨻���Win��������
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">��Ҫ�󶨵�ǰ���������</param>
        public static void BindCbo_ApplicationTypeIdEx(System.Windows.Forms.ComboBox objComboBox)
        {
            //Ϊ����ԴΪ�����������������
            string strCondition = string.Format("{0} = '1' Order By {1}", conApplicationType.IsVisible, conApplicationType.OrderNum);
            System.Data.DataTable objDT = clsApplicationTypeBL.GetDataTable(strCondition);
            clsApplicationTypeEN objApplicationTypeEN;
            //��ʼ��һ�������б�
            ArrayList ApplicationTypeList = new ArrayList();
            //�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�
            objApplicationTypeEN = new clsApplicationTypeEN();
            objApplicationTypeEN.ApplicationTypeId = 0;
            objApplicationTypeEN.ApplicationTypeName = "��ѡ��...";
            ApplicationTypeList.Add(objApplicationTypeEN);
            //��DataTable�е���������ӵ������б���
            foreach (DataRow objRow in objDT.Rows)
            {
                objApplicationTypeEN = new clsApplicationTypeEN();
                objApplicationTypeEN.ApplicationTypeId = int.Parse(objRow[conApplicationType.ApplicationTypeId].ToString());
                objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString();
                ApplicationTypeList.Add(objApplicationTypeEN);
            }
            //���������������Դ���Լ�����ֵ���ʾ��
            objComboBox.ValueMember = conApplicationType.ApplicationTypeId;
            objComboBox.DisplayMember = conApplicationType.ApplicationTypeName;
            objComboBox.DataSource = ApplicationTypeList;
            objComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// ��ȡ�����ʴ�����AppTypeId
        /// </summary>
        /// <returns></returns>
        public static int GetAppTypeIdByMaxVisitedNum()
        {
            string strCondition = string.Format("{0} = '1' Order By {1},{2}",
    conApplicationType.IsVisible,
    conApplicationType.VisitedNum,
    conApplicationType.OrderNum);
            List<clsApplicationTypeEN> arrObjLst = clsApplicationTypeBL.GetObjLst(strCondition).OrderByDescending(x => x.VisitedNum).ToList();
            return arrObjLst[0].ApplicationTypeId;
        }

        ///���ɰ�ListView�Ĵ���
        /// <summary>
        /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,
        ///			 ����ʾ��ListView�С�
        /// </summary>
        public static int BindLv_ApplicationType(System.Windows.Forms.ListView lvApplicationType, string strWhereCond)
        {
            //��������:(��4��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3������ListView����ͷ��Ϣ
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

            System.Windows.Forms.ListViewItem lviApplicationType;
            List<clsApplicationTypeEN> arrApplicationTypeObjList;
            //	2��������������ȡ�ñ�����������DataTable��
            arrApplicationTypeObjList = clsApplicationTypeBL.GetObjLst(strWhereCond);
            //	3������ListView����ͷ��Ϣ
            lvApplicationType.Items.Clear();//���ԭ������Item
            lvApplicationType.Columns.Clear();//���ԭ��������ͷ��Ϣ
            lvApplicationType.Columns.Add("Ӧ�ó�������ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvApplicationType.Columns.Add("Ӧ�ó�����������", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvApplicationType.Columns.Add("˵��", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvApplicationType.View = System.Windows.Forms.View.Details;
            //	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjList)
            {
                lviApplicationType = new System.Windows.Forms.ListViewItem();
                lviApplicationType.Tag = objApplicationType.ApplicationTypeId;
                lviApplicationType.Text = objApplicationType.ApplicationTypeId.ToString("00");
                lviApplicationType.SubItems.Add(objApplicationType.ApplicationTypeName);
                lviApplicationType.SubItems.Add(objApplicationType.Memo);
                lvApplicationType.Items.Add(lviApplicationType);
            }
            //	4�����ü�¼����״̬,
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            return arrApplicationTypeObjList.Count;
        }

        public static bool GoTop(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsApplicationTypeDAEx().GoTop(arrKeyId);
                bolResult = new clsApplicationTypeDAEx().ReOrder();

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("�ö�����!\r\n" + objException.Message);
            }
        }

        public static bool GoBottom(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsApplicationTypeDAEx().GoBottom(arrKeyId);
                bolResult = new clsApplicationTypeDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("�õ׳���!\r\n" + objException.Message);
            }
        }

        public static bool AdjustSequenceNumber(string strDirect, int intApplicationTypeId)
        {
            try
            {
                bool bolResult = new clsApplicationTypeDAEx().AdjustSequenceNumber(strDirect, intApplicationTypeId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("������¼�������!\r\n" + objException.Message);
            }
        }
        public static bool ReOrder()
        {
            try
            {
                bool bolResult = new clsApplicationTypeDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("���µ������м�¼�������!\r\n" + objException.Message);
            }

        }

        /// <summary>
        /// �������ʴ���
        /// </summary>
        /// <param name="intApplicationTypeId"></param>
        public static void IncreaseVisitedNum(int intApplicationTypeId)
        {
            clsApplicationTypeEN obj = clsApplicationTypeBL.GetObjByApplicationTypeId(intApplicationTypeId);
            obj.VisitedNum++;
            obj.Update();
        }
    }
}
