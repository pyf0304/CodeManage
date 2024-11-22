///���������صĿؼ����Ʋ����
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using com.taishsoft.util;
using CommFunc4Win;
using AGC.Entity;
using System.Collections.Generic;
using AGC4WApi;

namespace AGC_CSWin
{
    /// <summary>
    ///		frmUserPrjGrant_QD_LV ��ժҪ˵����
    /// </summary>
    public partial class frmUserPrjGrant_QD_LV : System.Windows.Forms.Form, IBindListView
    {
        //clsUserPrjGrantEN objUserPrjGrant = null;
        private System.Data.DataTable objDTUserPrjGrant = null;
        private clsListViewSorter objvUserPrjGrantSorter;
        private int intLastSelectedvUserPrjGrantColumIndex;
        public frmUserPrjGrant_QD_LV()
        {
            // �õ����� Windows.Forms ���������������ġ�
            InitializeComponent();

            // TODO: �� InitializeComponent ���ú�����κγ�ʼ��
            objvUserPrjGrantSorter = new clsListViewSorter();
            //ΪListViewItemSorterָ��������
            this.lvvUserPrjGrant.ListViewItemSorter = objvUserPrjGrantSorter;
            objvUserPrjGrantSorter.SortOrder = SortOrder.Ascending;

        }
        private void frmUserPrjGrant_QD_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            ///1��Ϊ��������������Դ�����б�����
            this.SetAllComboBox();
            BindLv_vUserPrjGrant();
            this.JudgebtnDelRec(); //�����ж�ɾ����ť�Ƿ����
            this.JudgebtnUpdate(); //�����ж��޸İ�ť�Ƿ����

        }
        /// <summary>
        /// ������İ󶨺���
        /// </summary>
        private void SetAllComboBox()
        {
            clsUsersWApi.BindCbo_UserId(this.ddlUserId);
            clsProjectsWApi.BindCbo_PrjId(this.ddlPrjId);
            clsUserRolesWApi.BindCbo_RoleId(this.ddlRoleId);
        }
        public string UserId
        {
            get
            {
                if (ddlUserId.SelectedValue.ToString() == "0")
                    return "";
                return ddlUserId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    ddlUserId.SelectedValue = "0";
                }
                else
                {
                    ddlUserId.SelectedValue = value;
                }
            }
        }

        public string PrjId
        {
            get
            {
                if (ddlPrjId.SelectedValue.ToString() == "0")
                    return "";
                return ddlPrjId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    ddlPrjId.SelectedValue = "0";
                }
                else
                {
                    ddlPrjId.SelectedValue = value;
                }
            }
        }

        public string RoleId
        {
            get
            {
                if (ddlRoleId.SelectedValue.ToString() == "0")
                    return "";
                return ddlRoleId.SelectedValue.ToString();
            }
            set
            {
                if (value == "")
                {
                    ddlRoleId.SelectedValue = "0";
                }
                else
                {
                    ddlRoleId.SelectedValue = value;
                }
            }
        }


        public void Clear()
        {
            ddlUserId.SelectedIndex = 0;
            ddlPrjId.SelectedIndex = 0;
            ddlRoleId.SelectedIndex = 0;
        }
        /// <summary>
        /// ���øÿؼ��ڲ���״̬�µ�ȱʡֵ
        /// һ�����
        ///		1����������;�Ĭ��Ϊ0��
        ///		2������Ǹ����Ͳ�Ĭ��Ϊ0.0��
        ///		3������������;�Ĭ��Ϊ��ǰ�����ڣ�
        ///		4�������λ(bit)�;�Ĭ��Ϊfalse;
        ///		��ЩĬ��ֵ���������޸�
        /// </summary>
        public void SetDefaultValue()
        {
            ddlUserId.SelectedIndex = 0;
            ddlPrjId.SelectedIndex = 0;
            ddlRoleId.SelectedIndex = 0;
        }
        /// <summary>
        /// У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ�ġ�
        /// һ�����
        ///		1������У�����ͣ����͡������͡������͵ȣ�
        ///			��Щ�������Զ����ɴ����������
        ///		2��У����ֵ�������ֵ����Сֵ��
        ///			��Щ�������Զ����ɴ����������
        ///		��Щ�������ݿ����޸�
        /// </summary>
        /// <returns></returns>
        public bool IsValid(ref string strResult)
        {
            return true;
        }
        /// <summary>
        /// ���ܣ���ȡ��ǰ�µ��ַ���
        /// �µĸ�ʽ��
        ///    �µ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMM��	����200501
        ///		2��YYYY-MM-DD	����2005-01
        ///		3��YYYY/MM/DD	����2005/01
        /// </summary>
        /// <param name="intFormat">�µĸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ�������µĸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ�µ��ַ���</returns>
        public string getCurrMonth(int intFormat)
        {
            string strCurrMonth;
            string strYear, strMonth;
            int intYear, intMonth;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            strCurrMonth = strYear + strMonth;
            switch (intFormat)
            {
                case 0:
                    strCurrMonth = strYear + strMonth;
                    break;
                case 1:
                    strCurrMonth = strYear + "-" + strMonth;
                    break;
                case 2:
                    strCurrMonth = strYear + "/" + strMonth;
                    break;
            }
            return strCurrMonth;
        }
        /// <summary>
        /// ���ܣ���ȡ��ǰ���ڵ��ַ���
        /// ���ڸ�ʽ��
        ///    ���ڵ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMMDD��	����20050120
        ///		2��YYYY-MM-DD	����2005-01-20
        ///		3��YYYY/MM/DD	����2005/01/20
        /// </summary>
        /// <param name="intFormat">���ڸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ���������ڸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ���ڵ��ַ���</returns>
        public string getTodayStr(int intFormat)
        {
            string strToday;
            string strYear, strMonth, strDay;
            int intYear, intMonth, intDay;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            intDay = System.DateTime.Today.Day;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strToday = strYear + strMonth + strDay;
            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay;
                    break;
            }
            return strToday;
        }
         public void SetCbo_UserId()
        {
            clsUsersWApi.BindCbo_UserId(ddlUserId);
        }
        public void SetCbo_PrjId()
        {
            clsProjectsWApi.BindCbo_PrjId(ddlPrjId);
        }
        public void SetCbo_RoleId()
        {
            clsUserRolesWApi.BindCbo_RoleId(ddlRoleId);
        }
        /// <summary>
        /// �ж��Ƿ�������
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public bool IsDigit(string strValue)
        {
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// �ж��Ƿ��Ǹ�������ֵ
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public bool IsFloat(string strValue)
        {
            int intPointNum = 0;
            char[] arrChar = strValue.ToCharArray();
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == true || arrChar[i] == '.')
                {
                }
                else
                {
                    return false;
                }
                if (arrChar[i] == '.') intPointNum++;
            }
            //����ܹ��м���С���㣬����ж���1��С���㣬�Ͳ���ȷ
            if (intPointNum > 1) return false;
            return true;
        }
        /// <summary>
        /// �ж��Ƿ���������ֵ
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public bool IsNumeric(string strValue)
        {
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }
        ///������ϲ�ѯ�����Ĵ���
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        public string CombineUserPrjGrantCondion()
        {
            ///ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            ///���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 ";
            ///����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.ddlUserId.SelectedValue.ToString() != "" && this.ddlUserId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And UserPrjGrant.UserId='" + this.ddlUserId.SelectedValue + "'";
            }
            if (this.ddlPrjId.SelectedValue.ToString() != "" && this.ddlPrjId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And UserPrjGrant.PrjId='" + this.ddlPrjId.SelectedValue + "'";
            }
            if (this.ddlRoleId.SelectedValue.ToString() != "" && this.ddlRoleId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And UserPrjGrant.RoleId='" + this.ddlRoleId.SelectedValue + "'";
            }
            return strWhereCond;
        }
        ///������ϲ�ѯ�����Ĵ���
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        public string CombineUserPrjGrantCondion(bool bolIsWithTabName)
        {
            ///ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            ///���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 ";
            ///����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (bolIsWithTabName == true)
            {
                if (this.ddlUserId.SelectedValue.ToString() != "" && this.ddlUserId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And UserPrjGrant.UserId='" + this.ddlUserId.SelectedValue + "'";
                }
                if (this.ddlPrjId.SelectedValue.ToString() != "" && this.ddlPrjId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And UserPrjGrant.PrjId='" + this.ddlPrjId.SelectedValue + "'";
                }
                if (this.ddlRoleId.SelectedValue.ToString() != "" && this.ddlRoleId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And UserPrjGrant.RoleId='" + this.ddlRoleId.SelectedValue + "'";
                }
            }
            else
            {
                if (this.ddlUserId.SelectedValue.ToString() != "" && this.ddlUserId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And UserId='" + this.ddlUserId.SelectedValue + "'";
                }
                if (this.ddlPrjId.SelectedValue.ToString() != "" && this.ddlPrjId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And PrjId='" + this.ddlPrjId.SelectedValue + "'";
                }
                if (this.ddlRoleId.SelectedValue.ToString() != "" && this.ddlRoleId.SelectedValue.ToString() != "0")
                {
                    strWhereCond += " And RoleId='" + this.ddlRoleId.SelectedValue + "'";
                }
            }
            return strWhereCond;
        }
        ///������ϲ�ѯ�����Ĵ���
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        public string CombineUserPrjGrantCondion(string strTabName)
        {
            ///ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            ///���� 1=1 && UserName = '����'
            string strWhereCond = " 1=1 ";
            ///����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.ddlUserId.SelectedValue.ToString() != "" && this.ddlUserId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".UserId='" + this.ddlUserId.SelectedValue + "'";
            }
            if (this.ddlPrjId.SelectedValue.ToString() != "" && this.ddlPrjId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".PrjId='" + this.ddlPrjId.SelectedValue + "'";
            }
            if (this.ddlRoleId.SelectedValue.ToString() != "" && this.ddlRoleId.SelectedValue.ToString() != "0")
            {
                strWhereCond += " And " + strTabName + ".RoleId='" + this.ddlRoleId.SelectedValue + "'";
            }
            return strWhereCond;
        }
        /// <summary>
        /// �������ܣ������ж�ɾ����ť�Ƿ���á�
        ///			 �����LISTVIEW��ѡ�м�¼����ʾɾ����ť������Ͳ���ʾ
        /// </summary>
        private void JudgebtnDelRec()
        {
            if (this.lvvUserPrjGrant.SelectedItems.Count >= 1)
            {
                this.btnDelRec.Enabled = true;
            }
            else
            {
                this.btnDelRec.Enabled = false;
            }
        }
        /// <summary>
        /// �������ܣ������ж�ɾ����ť�Ƿ���á�
        ///			 �����LISTVIEW��ѡ�м�¼����ʾɾ����ť������Ͳ���ʾ
        /// </summary>
        private void JudgebtnUpdate()
        {
            if (this.lvvUserPrjGrant.SelectedItems.Count >= 1)
            {
                this.btnUpdate.Enabled = true;
            }
            else
            {
                this.btnUpdate.Enabled = false;
            }
        }
       
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��ListView�С�
        /// </summary>
        private void BindLv_vUserPrjGrant()
        {
            ///	�������裺(��4��)
            ///	1����Ͻ�����������
            ///	2��������������ȡ�ñ�����������DataTable��
            ///	3������ListView����ͷ��Ϣ
            ///	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            ///		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�

            ListViewItem lvivUserPrjGrant;
            List<clsvUserPrjGrantEN> arrvUserPrjGrantObjList;
            ///	1����Ͻ�����������
            string strWhereCond = this.CombineUserPrjGrantCondion(false);	//  CombineUserPrjGrantCondion();
            ///	2��������������ȡ�ñ�����������DataTable��
            arrvUserPrjGrantObjList =  clsvUserPrjGrantWApi.GetObjLst(strWhereCond);
            ///	3������ListView����ͷ��Ϣ
            this.lvvUserPrjGrant.Items.Clear();//���ԭ������Item
            this.lvvUserPrjGrant.Columns.Clear();//���ԭ��������ͷ��Ϣ
            this.lvvUserPrjGrant.Columns.Add("�û���", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("��Ŀ����", 240, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("��ɫ����", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("������", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("������", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("�û�״̬��", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("������Id", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("��������", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.Columns.Add("��ע", 100, HorizontalAlignment.Left);
            this.lvvUserPrjGrant.View = View.Details;
            ///	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��
            foreach (clsvUserPrjGrantEN objvUserPrjGrant in arrvUserPrjGrantObjList)
            {
                lvivUserPrjGrant = new ListViewItem();
                lvivUserPrjGrant.Tag = objvUserPrjGrant.mId;
                lvivUserPrjGrant.Text = objvUserPrjGrant.UserName;
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.PrjName);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.RoleName);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.VisitedNum.ToString());
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.DepartmentName);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.UserStateName);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.OptId);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.OptDate);
                lvivUserPrjGrant.SubItems.Add(objvUserPrjGrant.Memo);
                this.lvvUserPrjGrant.Items.Add(lvivUserPrjGrant);
            }
            ///	4�����ü�¼����״̬��
            ///		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�
            this.lblRecNum.Text = "��¼����" + arrvUserPrjGrantObjList.Count.ToString();
        }
        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            //�ѱ��¼��������ʾ��ListView��
            BindLv_vUserPrjGrant();
        }
        /// <summary>
        /// ��ȡDataGrid�е�ǰ�е�����ֵ
        /// </summary>
        /// <param name="objDataGrid">��������DataGrid</param>
        /// <returns>��ǰ�е�����ֵ</returns>
        private long GetCurrKey(DataGrid objDataGrid)
        {
            int intCurrRow = objDataGrid.CurrentRowIndex;
            string strmId = objDTUserPrjGrant.Rows[intCurrRow]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            return lngmId;
        }
        /// <summary>
        /// ��ȡListView�е�ǰ�е�����ֵ
        /// </summary>
        /// <param name="objListView">��������ListView</param>
        /// <returns>��ǰ�е�����ֵ</returns>
        private long GetCurrKey(ListView objListView)
        {
            ListViewItem lviUserPrjGrant;
            lviUserPrjGrant = objListView.SelectedItems[0];
            string strUserPrjGrantId = lviUserPrjGrant.Tag.ToString();
            long lngmId = long.Parse(strUserPrjGrantId);
            return lngmId;
        }

        /// <summary>
        /// ��ȡListView�е�ǰ�е�����ֵ
        /// </summary>
        /// <param name="objListView">��������ListView</param>
        /// <returns>��ǰ�е�����ֵ</returns>
        private long GetCurrKey(ListViewItem objListViewItem)
        {
            string strUserPrjGrantId = objListViewItem.Tag.ToString();
            long lngmId = long.Parse(strUserPrjGrantId);
            return lngmId;
        }
        private void lvvUserPrjGrant_Click(object sender, System.EventArgs e)
        {
            this.JudgebtnDelRec(); //�����ж�ɾ����ť�Ƿ����
            this.JudgebtnUpdate(); //�����ж��޸İ�ť�Ƿ����
        }
        /// <summary>
        /// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
        ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            UpdateUserPrjGrantRecord();
        }
        /// <summary>
        /// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
        ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmUserPrjGrant_UI frm = new frmUserPrjGrant_UI();
            frm.iBindListView = this;
            frm.OperateType = "Add";
            frm.ShowDialog();
        }
        private void btnDelRec_Click(object sender, System.EventArgs e)
        {
            DeleteUserPrjGrantRecord();
        }
        private void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
        {
            ExportExcel_SelColumns();	//�µĵ���EXCEL��ʽ���û�����ѡ�񵼳��ֶ���
            //ExportExcel();	//ԭ���ķ�ʽ����EXCEL���û�����ѡ�񵼳��ֶ���
        }
        /// <summary>
        /// ����EXCEL�ĺ���
        /// </summary>
        private void ExportExcel()
        {
            ///	1����Ͻ�����������
            string strWhereCond = this.CombineUserPrjGrantCondion(true);
            ///	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;// clsUserPrjGrantWApi.GetDataTable_UserPrjGrantV(strWhereCond);
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            //string strFileName = "UserPrjGrant��Ϣ����.xls";
            //string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("UserId"); arrCnName.Add("�û�ID");
            arrColName.Add("UserName"); arrCnName.Add("�û���");
            arrColName.Add("PrjName"); arrCnName.Add("��Ŀ����");
            arrColName.Add("RoleName"); arrCnName.Add("��ɫ����");
            arrColName.Add("DepartmentName"); arrCnName.Add("������");
            arrColName.Add("UserStateName"); arrCnName.Add("�û�״̬��");
            arrColName.Add("VisitedNum"); arrCnName.Add("������");
            arrColName.Add("OptDate"); arrCnName.Add("��������");
            arrColName.Add("OptId"); arrCnName.Add("������Id");
            arrColName.Add("Memo"); arrCnName.Add("��ע");
            //strFolderName = Application.StartupPath + "\\TempFiles";
            //if (Directory.Exists(strFolderName) == false)
            //{
            //Directory.CreateDirectory(strFolderName);
            //}
            //strDownLoadFileName = strFolderName + "\\" + strFileName;
            System.Windows.Forms.SaveFileDialog objSaveFileDialog = new SaveFileDialog();
            objSaveFileDialog.DefaultExt = "xls";
            objSaveFileDialog.Filter = "Excle�ļ�(*.xls)|*.xls|�����ļ�(*.*)|*.*";
            objSaveFileDialog.ShowDialog();
            strDownLoadFileName = objSaveFileDialog.FileName;
            if (strDownLoadFileName == "")
            {
                return;
            }
            GetExcelFromDataTable.clsGetExcelFromDataTable objExcel = new GetExcelFromDataTable.clsGetExcelFromDataTable();
            objExcel.GetExcelFromDataTableByArrAndArray(objDT, arrColName, arrCnName, strDownLoadFileName);
            MessageBox.Show("����Excel�ɹ�!���ļ�����ڣ�" + strDownLoadFileName);
        }
        /// <summary>
        /// ����EXCEL�ĺ���, ����EXCELʱ����ѡ����
        /// </summary>
        private void ExportExcel_SelColumns()
        {
            ///	1����Ͻ�����������
            string strWhereCond = this.CombineUserPrjGrantCondion(true);
            ///	2�����ñ��������ֶ������Լ����б���
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            arrColName.Add("UserId"); arrCnName.Add("�û�ID");
            arrColName.Add("UserName"); arrCnName.Add("�û���");
            arrColName.Add("PrjName"); arrCnName.Add("��Ŀ����");
            arrColName.Add("RoleName"); arrCnName.Add("��ɫ����");
            arrColName.Add("DepartmentName"); arrCnName.Add("������");
            arrColName.Add("UserStateName"); arrCnName.Add("�û�״̬��");
            arrColName.Add("VisitedNum"); arrCnName.Add("������");
            arrColName.Add("OptDate"); arrCnName.Add("��������");
            arrColName.Add("OptId"); arrCnName.Add("������Id");
            arrColName.Add("Memo"); arrCnName.Add("��ע");
            ArrayList arrExportExcelList = new ArrayList();
            clsExportField objExportField = null;
            int intColNum = arrColName.Count;
            for (int i = 0; i < intColNum; i++)
            {
                objExportField = new clsExportField();
                objExportField.FieldEnglishName = arrColName[i].ToString();
                objExportField.FieldChineseName = arrCnName[i].ToString();
                arrExportExcelList.Add(objExportField);
            }
            /// 3�����ù��õĵ���EXCEL�Ľ��棬ѡ���к��ٵ���
            frmExportExcel frm1 = new frmExportExcel();
            frm1.arrExportExcelList = arrExportExcelList;
            frm1.strTableName = "vUserPrjGrant";
            frm1.strTableChineseName = "vUserPrjGrant";
            frm1.strViewName = "�û���Ŀ��Ȩά��";
            frm1.strWhereCondition = strWhereCond;
            frm1.Show();
        }

        /// <summary>
        /// �������ܣ�LISTVIEW���е����¼�����
        /// </summary>
        private void lvvUserPrjGrant_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            if (e.Column == this.objvUserPrjGrantSorter.SortColumn)
            {

            }
            else
            {
                this.objvUserPrjGrantSorter.SortColumn = e.Column;
            }

            if (this.objvUserPrjGrantSorter.SortOrder == SortOrder.Ascending)
            {
                this.objvUserPrjGrantSorter.SortOrder = SortOrder.Descending;
                if (intLastSelectedvUserPrjGrantColumIndex == e.Column) //���Ƿ��ظ����һ��
                {
                    this.lvvUserPrjGrant.Columns[e.Column].Text = this.lvvUserPrjGrant.Columns[e.Column].Text.Trim('��', '��') + "��";
                    intLastSelectedvUserPrjGrantColumIndex = e.Column;
                }
                else //����������һ���ˣ���ôǰ������һ������ȥ��
                {
                    this.lvvUserPrjGrant.Columns[e.Column].Text = this.lvvUserPrjGrant.Columns[e.Column].Text.Trim('��', '��') + "��";
                    this.lvvUserPrjGrant.Columns[intLastSelectedvUserPrjGrantColumIndex].Text = this.lvvUserPrjGrant.Columns[intLastSelectedvUserPrjGrantColumIndex].Text.Trim('��', '��');
                    intLastSelectedvUserPrjGrantColumIndex = e.Column;
                }
            }
            else if (this.objvUserPrjGrantSorter.SortOrder == SortOrder.Descending) // �� ��
            {
                this.objvUserPrjGrantSorter.SortOrder = SortOrder.Ascending;
                if (intLastSelectedvUserPrjGrantColumIndex == e.Column)
                {
                    this.lvvUserPrjGrant.Columns[e.Column].Text = this.lvvUserPrjGrant.Columns[e.Column].Text.Trim('��', '��') + "��";
                    intLastSelectedvUserPrjGrantColumIndex = e.Column;
                }
                else
                {
                    this.lvvUserPrjGrant.Columns[e.Column].Text = this.lvvUserPrjGrant.Columns[e.Column].Text.Trim('��', '��') + "��";
                    this.lvvUserPrjGrant.Columns[intLastSelectedvUserPrjGrantColumIndex].Text = this.lvvUserPrjGrant.Columns[intLastSelectedvUserPrjGrantColumIndex].Text.Trim('��', '��');
                    intLastSelectedvUserPrjGrantColumIndex = e.Column;
                }
            }
            else
            {
                return;
            }
            this.lvvUserPrjGrant.Sort();
        }

        /// <summary>
        /// ʵ�ֽӿں�����ͨ���Ӵ�����ã���ʵ�ֱ�����(������)��LISTVIEW���°󶨹���
        /// </summary>
        void IBindListView.BindListView()
        {
            BindLv_vUserPrjGrant();
        }
        ///�����޸ļ�¼׼�����̴��� for C#
        private void UpdateUserPrjGrantRecord()
        {
            if (this.lvvUserPrjGrant.SelectedItems.Count != 1)
            {
                DialogResult result;
                result = MessageBox.Show("��ѡ��һ����¼��");
                return;
            }
            frmUserPrjGrant_UI frm = new frmUserPrjGrant_UI();
            string strKeyId = this.lvvUserPrjGrant.SelectedItems[0].Tag.ToString();
            frm.mId_key = long.Parse(strKeyId);
            frm.iBindListView = this;
            frm.OperateType = "Update";
            frm.ShowDialog();
        }
        ///ɾ����¼���̴���for C#
        private void DeleteUserPrjGrantRecord()
        {
            DialogResult result;
            result = MessageBox.Show("�����Ҫɾ���ü�¼��", "ȷ��ɾ��", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in this.lvvUserPrjGrant.SelectedItems)
                {
                    long lngmId = GetCurrKey(lvi);
                    if (clsUserPrjGrantWApi.DelRecord(lngmId) == 0)
                    {
                        MessageBox.Show("ɾ����¼ʧ�ܣ�");
                        BindLv_vUserPrjGrant();
                        return;
                    }
                }
                MessageBox.Show("ɾ����¼�ɹ���");
                BindLv_vUserPrjGrant();
            }
        }
    }
}