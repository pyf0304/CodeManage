///���������صĿؼ����Ʋ����
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using com.taishsoft.util;
using com.taishsoft.common;
using AGC.Entity;
using com.taishsoft.datetime;

using AGC4WApi;

namespace AGC_CSWin
{
    /// <summary>
    ///		frmUserPrjGrant_UI ��ժҪ˵����
    /// </summary>
    public partial class frmUserPrjGrant_UI : System.Windows.Forms.Form
    {
        clsUserPrjGrantEN objUserPrjGrant = null;
        private long mlngmId;		//���ڴ��ݹؼ���ֵ�ı���
        public string OperateType;
        public IBindListView iBindListView = null;
        public frmUserPrjGrant_UI()
        {
            // �õ����� Windows.Forms ���������������ġ�
            InitializeComponent();

            // TODO: �� InitializeComponent ���ú�����κγ�ʼ��

        }
        private void frmUserPrjGrant_UI_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            ///1��Ϊ��������������Դ�����б�����
            this.SetAllComboBox();
            if (OperateType == "Update")
            {
                ShowData(mlngmId);
                btnOKUpd.Text = "ȷ���޸�";
            }
            else
            {
                btnOKUpd.Text = "ȷ�����";
            }

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

        

        public string OptId
        {
            get
            {
                return clsSysParaEN.strUserId;
            }
        }

        public string OptDate
        {
            get
            {
                return clsDateTime.getTodayStr(0);
            }
        }

        public string Memo
        {
            get
            {
                return txtMemo.Text.Trim();
            }
            set
            {
                txtMemo.Text = value.ToString();
            }
        }


        public void Clear()
        {
            ddlUserId.SelectedIndex = 0;
            ddlPrjId.SelectedIndex = 0;
            ddlRoleId.SelectedIndex = 0;
            txtMemo.Text = "";
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
            txtMemo.Text = "";
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
        /// <summary>
        /// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
        ///������     �������ǰ�ֵ������ؼ���
        /// </summary>
        /// <param name="lngmId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
        private void ShowData(long lngmId)
        {
            ///�������裺
            ///1�����ؼ����Ƿ�Ϊ�գ�
            ///2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            ///3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            ///4����ȡ�������������ԣ�
            ///5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

            ///1�����ؼ����Ƿ�Ϊ�գ�
            if (lngmId == 0) return;		//����ؼ���Ϊ�վͷ����˳�
            ///2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            if (clsUserPrjGrantWApi.IsExist(lngmId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + lngmId + "�Ĳ�����!";
                MessageBox.Show(ss);
                return;
            }
            ///3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            objUserPrjGrant = clsUserPrjGrantWApi.GetObjBymId(lngmId);
            ///5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromUserPrjGrantClass(objUserPrjGrant);
        }
        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        private void GetDataFromUserPrjGrantClass(clsUserPrjGrantEN pobjUserPrjGrant)
        {
            ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
            ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
            this.UserId = pobjUserPrjGrant.UserId;
            this.PrjId = pobjUserPrjGrant.PrjId;
            this.RoleId = pobjUserPrjGrant.RoleId;
            this.Memo = pobjUserPrjGrant.Memo;
        }
        /// <summary>
        /// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
        ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            Button btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "���":
                    btnOKUpd.Text = "ȷ�����";
                    //this.mId = clsCommForWebForm.GetMaxStrId("UserPrjGrant","mId", 8, "");
                    break;
                case "ȷ�����":
                    ///����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
                    ///�Ͱ��߼���ϲ������Ʋ�,
                    AddUserPrjGrantRecordSave();
                    break;
                case "ȷ���޸�":
                    ///����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
                    ///�Ͱ��߼���ϲ������Ʋ�,
                    UpdateUserPrjGrantRecordSave(objUserPrjGrant);
                    break;
            }
        }
        ///���ɴӽ���㵽�߼�������ݴ��亯������
        private void PutDataToUserPrjGrantClass(clsUserPrjGrantEN pobjUserPrjGrant)
        {
            pobjUserPrjGrant.UserId = this.UserId;
            pobjUserPrjGrant.PrjId = this.PrjId;
            pobjUserPrjGrant.RoleId = this.RoleId;
            pobjUserPrjGrant.OptId = this.OptId;
            pobjUserPrjGrant.OptDate = this.OptDate;
            pobjUserPrjGrant.Memo = this.Memo;
        }
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        public long mId_key
        {
            get
            {
                return mlngmId;
            }
            set
            {
                mlngmId = value;
            }
        }
        ///�����¼���̹��̴���for C#
        private void AddUserPrjGrantRecordSave()
        {
            ///�������裺
            ///1�����ؼ����������������Ƿ���ȷ
            ///2��������󲢳�ʼ������
            ///3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
            ///4����ֵ�ӽ���㴫���߼��������ʵ���
            ///5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            ///6��������ʵ�������ݴ��������ݿ���
            ///7��������ļ�¼������ʾ��DATAGRID��
            string strMsg;	//ר�����ڴ�����Ϣ�ı���
            string strResult = " ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
            clsUserPrjGrantEN objUserPrjGrant;
            ///1�����ؼ����������������Ƿ���ȷ
            if (!this.IsValid(ref strResult))
            {
                lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                return;
            }
            if (clsUserPrjGrantExWApi.IsExistSameRec(UserId, PrjId) == false)
            {
                ///2����ʼ����������
                objUserPrjGrant = new clsUserPrjGrantEN();	//��ʼ���¶���
                ///3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
                ///4����ֵ�ӽ���㴫���߼��������ʵ���
                PutDataToUserPrjGrantClass(objUserPrjGrant);		//�ѽ����ֵ����
                ///5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                try
                {
                    clsUserPrjGrantWApi.CheckPropertyNew(objUserPrjGrant);
                    ///6��������ʵ�������ݴ��������ݿ���
                    clsUserPrjGrantWApi.AddNewRecord(objUserPrjGrant);
                }
                catch (Exception objException)
                {
                    strMsg = "��Ӽ�¼���ɹ�!" + objException.Message;
                    MessageBox.Show(strMsg);
                    lblMsg.Text = strMsg;
                    return;
                }
                strMsg = "��Ӽ�¼�ɹ�!";
                MessageBox.Show(strMsg);
                lblMsg.Text = "��Ӽ�¼�ɹ�!";
            }
            else
            {
                ///2����ʼ����������
                objUserPrjGrant = clsUserPrjGrantExWApi.GetUserPrjGrantByCondition(UserId, PrjId);
                objUserPrjGrant.RoleId = RoleId;
                try
                {                  
                    ///6��������ʵ�������ݴ��������ݿ���
                    objUserPrjGrant.Update();
                }
                catch (Exception objException)
                {
                    strMsg = "��Ӽ�¼���ɹ�!" + objException.Message;
                    MessageBox.Show(strMsg);
                    lblMsg.Text = strMsg;
                    return;
                }
                strMsg = "��Ӽ�¼�ɹ�!";
                MessageBox.Show(strMsg);
                lblMsg.Text = "��Ӽ�¼�ɹ�!";

            }
            ///7���ָ�<ȷ�����>���<���>
            btnOKUpd.Text = "���";
            ///8�����ø������к���BINDLISTVIEW()�Ѹ������е�LISTVIEW����������ʾһ�¡�
            iBindListView.BindListView();
        }
        ///�޸Ĵ���׼�����̴��� for C#
        private void UpdateUserPrjGrantRecordSave(clsUserPrjGrantEN objUserPrjGrant)
        {
            ///�������裺
            ///1�����ؼ����������������Ƿ���ȷ
            ///2����ֵ�ӽ���㴫���߼��������ʵ���
            ///3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            ///4��������ʵ�������ݴ��������ݿ���
            ///5�����޸ĺ��������ʾ��DATAGRID��
            string strMsg;	//ר�����ڴ�����Ϣ�ı���
            string strResult = " ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
            ///1�����ؼ����������������Ƿ���ȷ
            if (!this.IsValid(ref strResult))
            {
                lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                return;
            }
            ///2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToUserPrjGrantClass(objUserPrjGrant);		//�ѽ����ֵ����
            ///3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                ///6��������ʵ�������ݴ��������ݿ���
                objUserPrjGrant.Update();
            }
            catch (Exception objException)
            {
                strMsg = "�޸ļ�¼���ɹ�!" + objException.Message;
                MessageBox.Show(strMsg);
                lblMsg.Text = strMsg;
                return;
            }
            strMsg = "�޸ļ�¼�ɹ�!";
            MessageBox.Show(strMsg);
            lblMsg.Text = "�޸ļ�¼�ɹ�!";
            this.Close();
            ///5���ָ�<ȷ���޸�>���<���>
            btnOKUpd.Text = "���";
            ///6�����ø������к���BINDLISTVIEW()�Ѹ������е�LISTVIEW����������ʾһ�¡�
            iBindListView.BindListView();
        }
    }
}