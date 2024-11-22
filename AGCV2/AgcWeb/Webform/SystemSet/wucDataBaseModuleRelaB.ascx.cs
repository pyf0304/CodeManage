

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
    using AGC.Entity;
    using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

    /// <summary>
    ///		wucDataBaseModuleRelaB ��ժҪ˵����
    /// </summary>
    public partial class wucDataBaseModuleRelaB : System.Web.UI.UserControl
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
                if (ddlPrjId.SelectedValue == "0")
                    return "";
                return ddlPrjId.SelectedValue;
            }
            set
            {
                if (ddlPrjId.Items.Count > 0)
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
        }

        /// <summary>
        /// ��Ŀ���ݿ�Id
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
                        ddlPrjDataBaseId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// ����ģ��Id
        /// </summary>
        public string FuncModuleAgcId
        {
            get
            {
                if (ddlFuncModuleId.SelectedValue == "0")
                    return "";
                return ddlFuncModuleId.SelectedValue;
            }
            set
            {
                if (ddlFuncModuleId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlFuncModuleId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlFuncModuleId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// �Ƿ���ʾ
        /// </summary>
        public bool IsVisible
        {
            get
            {
                return chkIsVisible.Checked;
            }
            set
            {
                chkIsVisible.Checked = value;
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


        public void Clear()
        {
            //ddlPrjId.SelectedIndex = 0;
            ddlPrjDataBaseId.SelectedIndex = 0;
            ddlFuncModuleId.SelectedIndex = 0;
            chkIsVisible.Checked = false;
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
            //ddlPrjId.SelectedIndex = 0;
            ddlPrjDataBaseId.SelectedIndex = 0;
            ddlFuncModuleId.SelectedIndex = 0;
            chkIsVisible.Checked = false;
            txtMemo.Text = "";
        }
     
        public System.Data.DataTable GetPrjDataBaseId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select PrjDataBaseId, PrjDataBaseName from PrjDataBase ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_PrjDataBaseId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetPrjDataBaseId();
            objDDL.DataValueField = "PrjDataBaseId";
            objDDL.DataTextField = "PrjDataBaseName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public System.Data.DataTable GetFuncModuleId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select FuncModuleAgcId, FuncModuleName from FuncModule_Agc ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_FuncModuleId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetFuncModuleId();
            objDDL.DataValueField = "FuncModuleAgcId";
            objDDL.DataTextField = "FuncModuleName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetPrjIdEnabled(bool bolIsEnabled)
        {
            ddlPrjId.Enabled = bolIsEnabled;
        }
        public void SetDdl_PrjId()
        {
          clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjId);
        }
        public void SetDdl_PrjDataBaseId(string strPrjId)
        {
            clsPrjDataBaseBLEx.BindDdl_PrjDataBaseIdEx(ddlPrjDataBaseId, strPrjId);
        }
        public void SetDdl_FuncModuleId(string strPrjId)
        {
            clsFuncModule_AgcBLEx.BindDdl_FuncModuleIdExCache(ddlFuncModuleId, strPrjId);
        }

        protected void ddlPrjId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPrjId.SelectedIndex > 0)
            {
                string strPrjId = ddlPrjId.SelectedValue;
                clsFuncModule_AgcBLEx.BindDdl_FuncModuleIdExCache(ddlFuncModuleId, strPrjId);
                clsPrjDataBaseBLEx.BindDdl_PrjDataBaseIdEx(ddlPrjDataBaseId, strPrjId);
            }
        }
    }
}