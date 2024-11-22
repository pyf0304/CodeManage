
namespace AGC.Webform
{
    using System;
    using System.Data;
    using System.Configuration;
    using System.Collections;
    using System.Web;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.common;
    using com.taishsoft.commdb;
    
    
    using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;
    using AGC.Entity;

    /// <summary>
    ///		wucProjects ��ժҪ˵����
    /// </summary>
    public partial class wucProjects : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��

        }
        /// <summary>
        /// ����ID
        /// </summary>
        public string PrjId
        {
            get
            {
                return txtPrjId.Text.Trim();
            }
            set
            {
                txtPrjId.Text = value.ToString();
            }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public string PrjName
        {
            get
            {
                return txtPrjName.Text.Trim();
            }
            set
            {
                txtPrjName.Text = value.ToString();
            }
        }

        /// <summary>
        /// Java����
        /// </summary>
        public string JavaPackageName
        {
            get
            {
                return txtJavaPackageName.Text.Trim();
            }
            set
            {
                txtJavaPackageName.Text = value.ToString();
            }
        }
        /// <summary>
        /// ISO������
        /// </summary>
        public string IsoPrjName
        {
            get
            {
                return txtIsoPrjName.Text.Trim();
            }
            set
            {
                txtIsoPrjName.Text = value.ToString();
            }
        }
        /// <summary>
        /// �������ݿ�ID
        /// </summary>
        public string PrjDataBaseId
        {
            get
            {
                if (ddlPrjDataBaseId.SelectedValue == "0")
                    return "";
                return ddlPrjDataBaseId.SelectedValue;
            }
            set
            {
                if (ddlPrjDataBaseId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlPrjDataBaseId.SelectedValue = "0";
                    }
                    else
                    {
                        try
                        {
                            ddlPrjDataBaseId.SelectedValue = value;
                            clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN(value);
                            clsPrjDataBaseBL.GetPrjDataBase(ref objPrjDataBaseEN);
                            PrjDataBaseName = objPrjDataBaseEN.DataBaseName;//    ���ݿ���

                            DatabaseOwner = objPrjDataBaseEN.DatabaseOwner;//    ���ݿ�ӵ����
                            DataBasePwd = objPrjDataBaseEN.DataBasePwd;//    ���ݿ���û�����
                            DataBaseTypeId = objPrjDataBaseEN.DataBaseTypeId;//    ���ݿ�����ID
                            DataBaseUserId = objPrjDataBaseEN.DataBaseUserId;//    ���ݿ���û�ID
                            IpAddress = objPrjDataBaseEN.IpAddress;//    ������
                            Sid = objPrjDataBaseEN.Sid;//    Sid
                            TableSpace = objPrjDataBaseEN.TableSpace;//    ��ռ�
                            UseStateId = objPrjDataBaseEN.UseStateId;//    ʹ��״̬Id
                        }
                        catch (Exception objException)
                        {
                            string ss = objException.Message;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// ʹ��״̬ID
        /// </summary>
        public string UseStateId
        {
            get
            {
                if (ddlUseStateId.SelectedValue == "0")
                    return "";
                return ddlUseStateId.SelectedValue;
            }
            set
            {
                if (ddlUseStateId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlUseStateId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlUseStateId.SelectedValue = value;
                    }
                }
            }
        }
        /// <summary>
        /// Ӧ�ó�������ID
        /// </summary>
        public int ApplicationTypeId
        {
            get
            {
                if (ddlApplicationTypeId.SelectedValue == "0")
                    return 0;
                return int.Parse( ddlApplicationTypeId.SelectedValue.ToString());
            }
            set
            {
                if (ddlApplicationTypeId.Items.Count > 0)
                {
                    if (value == 0)
                    {
                        ddlApplicationTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlApplicationTypeId.SelectedValue = value.ToString();
                    }
                }
            }
        }
        /// <summary>
        /// Ӧ�ó�������ID
        /// </summary>
        public string SoftStructureId
        {
            get
            {
                if (ddlSoftStructureId.SelectedValue == "0")
                    return "";
                return ddlSoftStructureId.SelectedValue;
            }
            set
            {
                if (ddlSoftStructureId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlSoftStructureId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlSoftStructureId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// ��/����
        /// </summary>
        public string PrjDomain
        {
            get
            {
                return txtPrjDomain.Text.Trim();
            }
            set
            {
                txtPrjDomain.Text = value.ToString();
            }
        }

        /// <summary>
        /// ���ݿ�����ID
        /// </summary>
        public string DataBaseTypeId
        {
            get
            {
                if (ddlDataBaseTypeId.SelectedValue == "0")
                    return "";
                return ddlDataBaseTypeId.SelectedValue;
            }
            set
            {
                if (ddlDataBaseTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlDataBaseTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlDataBaseTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// ������
        /// </summary>
        public string IpAddress
        {
            get
            {
                return txtIpAddress.Text.Trim();
            }
            set
            {
                txtIpAddress.Text = value.ToString();
            }
        }

        /// <summary>
        /// �����ݿ�
        /// </summary>
        public string PrjDataBaseName
        {
            get
            {
                return txtPrjDataBaseName.Text.Trim();
            }
            set
            {
                txtPrjDataBaseName.Text = value.ToString();
            }
        }

        /// <summary>
        /// ����Ŀ¼
        /// </summary>
        public string VirtualDirectory
        {
            get
            {
                return txtVirtualDirectory.Text.Trim();
            }
            set
            {
                txtVirtualDirectory.Text = value.ToString();
            }
        }
        /// <summary>
        /// �����ݿ�
        /// </summary>
        public string PrjRootDirectory
        {
            get
            {
                return txtPrjRootDirectory.Text.Trim();
            }
            set
            {
                txtPrjRootDirectory.Text = value.ToString();
            }
        }


        /// <summary>
        /// ���ݿ�ӵ����
        /// </summary>
        public string DatabaseOwner
        {
            get
            {
                return txtDatabaseOwner.Text.Trim();
            }
            set
            {
                txtDatabaseOwner.Text = value.ToString();
            }
        }

        /// <summary>
        /// Sid
        /// </summary>
        public string Sid
        {
            get
            {
                return txtSid.Text.Trim();
            }
            set
            {
                txtSid.Text = value.ToString();
            }
        }

        /// <summary>
        /// ��ռ�
        /// </summary>
        public string TableSpace
        {
            get
            {
                return txtTableSpace.Text.Trim();
            }
            set
            {
                txtTableSpace.Text = value.ToString();
            }
        }

        /// <summary>
        /// ���ݿ���û�ID
        /// </summary>
        public string DataBaseUserId
        {
            get
            {
                return txtDataBaseUserId.Text.Trim();
            }
            set
            {
                txtDataBaseUserId.Text = value.ToString();
            }
        }

        /// <summary>
        /// ���ݿ���û�����
        /// </summary>
        public string DataBasePwd
        {
            get
            {
                if (string.IsNullOrEmpty(txtDataBasePwd.Text) == false)
                {
                    return txtDataBasePwd.Text.Trim();
                }
                else if (string.IsNullOrEmpty(hidDataBasePwd.Value) == false)
                {
                    return hidDataBasePwd.Value.Trim();
                }
                else
                {
                    return "";
                }
            }
            set
            {
                txtDataBasePwd.Text = value.ToString();
                hidDataBasePwd.Value = value.ToString();
            }
        }
        /// <summary>
        /// �Ƿ�������ݿ�
        /// </summary>
        public bool IsRelaDataBase
        {
            get
            {
                return chkIsRelaDataBase.Checked;
            }
            set
            {
                chkIsRelaDataBase.Checked = value;
            }
        }

        /// <summary>
        /// �Ƿ�֧��Mvc
        /// </summary>
        public bool IsSupportMvc
        {
            get
            {
                return chkIsSupportMvc.Checked;
            }
            set
            {
                chkIsSupportMvc.Checked = value;
            }
        }

        /// <summary>
        /// ˵��
        /// </summary>
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


        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtPrjId.ReadOnly = bolReadonly;
        }
        public void SetState4SelectDataBase()
        {
            txtPrjDataBaseName.Enabled = false;//    ���ݿ���

            txtDatabaseOwner.Enabled = false;//    ���ݿ�ӵ����
            txtDataBasePwd.Enabled = false;//    ���ݿ���û�����
            ddlDataBaseTypeId.Enabled = false;//    ���ݿ�����ID
            txtDataBaseUserId.Enabled = false;//    ���ݿ���û�ID
            txtIpAddress.Enabled = false;//    ������
            txtSid.Enabled = false;//    Sid
            txtTableSpace.Enabled = false;//    ��ռ�
            txtPrjName.Enabled = false;
            txtPrjDomain.Enabled = false;
            txtMemo.Enabled = false;
            txtPrjRootDirectory.Enabled = false;
            txtVirtualDirectory.Enabled = false;
            ddlSoftStructureId.Enabled = false;
            ddlApplicationTypeId.Enabled = false;
            ddlUseStateId.Enabled = false;
            chkIsRelaDataBase.Enabled = false;
        }

        public void Clear()
        {
            txtPrjId.Text = "";
            txtPrjName.Text = "";
            txtPrjDomain.Text = "";
            ddlDataBaseTypeId.SelectedIndex = 0;
            txtIpAddress.Text = "";
            txtPrjDataBaseName.Text = "";
            txtDatabaseOwner.Text = "";
            txtSid.Text = "";
            txtTableSpace.Text = "";
            txtDataBaseUserId.Text = "";
            txtDataBasePwd.Text = "";
            ddlApplicationTypeId.SelectedIndex = 0;
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
            txtPrjId.Text = "";
            txtPrjName.Text = "";
            txtPrjDomain.Text = "";
            ddlDataBaseTypeId.SelectedIndex = 0;
            txtIpAddress.Text = "";
            txtPrjDataBaseName.Text = "";
            txtDatabaseOwner.Text = "";
            txtSid.Text = "";
            txtTableSpace.Text = "";
            txtDataBaseUserId.Text = "";
            txtDataBasePwd.Text = "";
            
            ddlApplicationTypeId.SelectedIndex = 0;
            txtMemo.Text = "";
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
        
        public System.Data.DataTable GetDataBaseTypeId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select DataBaseTypeId, DataBaseTypeName from DataBaseType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_DataBaseTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetDataBaseTypeId();
            objDDL.DataValueField = "DataBaseTypeId";
            objDDL.DataTextField = "DataBaseTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public System.Data.DataTable GetUserId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select UserId, UserName from Users ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetUserId();
            objDDL.DataValueField = "UserId";
            objDDL.DataTextField = "UserName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetDdl_DataBaseTypeId()
        {
            BindDdl_DataBaseTypeId(ddlDataBaseTypeId);
        }
        public void SetDdl_ApplicationTypeId()
        {
            clsDropDownList.BindDdl_ApplicationTypeId(ddlApplicationTypeId);
        }

        public void SetDdl_PrjDataBaseId()
        {
            clsPrjDataBaseBLEx.BindDdl_PrjDataBaseIdEx(ddlPrjDataBaseId);
        }
        public void SetDdl_PrjDataBaseId(string strPrjId)
        {
            clsPrjDataBaseBLEx.BindDdl_PrjDataBaseIdEx(ddlPrjDataBaseId, strPrjId);
        }

        public void SetDdl_SoftStructureId()
        {
            clsSoftStructureBLEx.BindDdl_SoftStructureId(ddlSoftStructureId);
        }
        public void SetDdl_UseStateId()
        {
            clsUseStateBL.BindDdl_UseStateId(ddlUseStateId);
        }

        protected void ddlPrjDataBaseId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPrjDataBaseId.SelectedIndex > 0)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN(clsPubVar.CurrPrjDataBaseId);
                clsPrjDataBaseBL.GetPrjDataBase(ref objPrjDataBaseEN);
                PrjDataBaseName = objPrjDataBaseEN.DataBaseName;//    ���ݿ���
        
                DatabaseOwner = objPrjDataBaseEN.DatabaseOwner;//    ���ݿ�ӵ����
                DataBasePwd = objPrjDataBaseEN.DataBasePwd;//    ���ݿ���û�����
                DataBaseTypeId = objPrjDataBaseEN.DataBaseTypeId;//    ���ݿ�����ID
                DataBaseUserId = objPrjDataBaseEN.DataBaseUserId;//    ���ݿ���û�ID
                IpAddress = objPrjDataBaseEN.IpAddress;//    ������
                Sid = objPrjDataBaseEN.Sid;//    Sid
                TableSpace = objPrjDataBaseEN.TableSpace;//    ��ռ�
          
                //Memo = objPrjDataBaseEN.Memo;//    ˵��

            }
        }
    }
}