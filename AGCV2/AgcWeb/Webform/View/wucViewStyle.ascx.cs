

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
    using com.taishsoft.datetime;
    using com.taishsoft.commdb;
    using AGC.Entity;
    using AGC.BusinessLogic;using AGC.FunClass;
    using BusinessLogicEx;
    /// <summary>
    ///		wucViewStyleB ��ժҪ˵����
    /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucViewStyleB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��

        }
        /// <summary>
        /// ����ID
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string ViewId
        {
            get
            {
                return txtViewId.Text.Trim();
            }
            set
            {
                txtViewId.Text = value.ToString();
            }
        }

        /// <summary>
        /// ��������Id
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string TitleStyleId
        {
            get
            {
                if (ddlTitleStyleId.SelectedValue == "0")
                    return "";
                return ddlTitleStyleId.SelectedValue;
            }
            set
            {
                if (ddlTitleStyleId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlTitleStyleId.SelectedValue = "0";
                    }
                    else
                    {
                        try
                        {
                            ddlTitleStyleId.SelectedValue = value;
                        }
                        catch(Exception objException)
                        {
                            string strSS = objException.Message;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// DGģʽID
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string DgStyleId
        {
            get
            {
                if (ddlDgStyleId.SelectedValue == "0")
                    return "";
                return ddlDgStyleId.SelectedValue;
            }
            set
            {
                if (ddlDgStyleId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlDgStyleId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlDgStyleId.SelectedValue = value;
                    }
                }
            }
        }


        /// <summary>
        /// ���û��Զ���ؼ��У����ùؼ��ֵ�ֵ���Ƿ�ֻ��
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <param name="bolReadonly">�Ƿ�ֻ��</param>
        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtViewId.ReadOnly = bolReadonly;
        }
        /// <summary>
        /// ����û��Զ���ؼ��У����пؼ���ֵ
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>	
        public void Clear()
        {
            txtViewId.Text = "";
            ddlTitleStyleId.SelectedIndex = 0;
            ddlDgStyleId.SelectedIndex = 0;
        }
        /// <summary>
        /// У���Զ���ؼ������ӿؼ���������ֵ�Ƿ��ǺϷ���ȷ�ġ�
        /// һ�����:
        ///		1������У������:���͡������͡������͵�,
        ///			��Щ�������Զ����ɴ����������
        ///		2��У����ֵ,�����ֵ����Сֵ��
        ///			��Щ�������Զ����ɴ����������
        ///		��Щ�������ݿ����޸�
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <returns></returns>
        public bool IsValid(ref string strResult)
        {
            return true;
        }
        /// <summary>
        /// ���øÿؼ��ڲ���״̬�µ�ȱʡֵ
        /// һ�����:
        ///		1����������;�Ĭ��Ϊ0��
        ///		2������Ǹ����Ͳ�Ĭ��Ϊ0.0��
        ///		3������������;�Ĭ��Ϊ��ǰ�����ڣ�
        ///		4�������λ(bit)�;�Ĭ��Ϊfalse;
        ///		��ЩĬ��ֵ���������޸�
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDefaultValue()
        {
            txtViewId.Text = "";
            ddlTitleStyleId.SelectedIndex = 0;
            ddlDgStyleId.SelectedIndex = 0;
        }
        /// <summary>
        /// Ϊ�������ȡ����,�ӱ�[TitleStyle]�л�ȡ
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <returns>��ȡ�����ֶΡ������ֶ����е����м�¼��¼��DataTable</returns>
        public System.Data.DataTable GetTitleStyleId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select TitleStyleId, TitleStyleName from TitleStyle ";
            clsSpecSQLforSql mySql = clsViewStyleBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// �󶨻���Web��������
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <param name="objDDL">��Ҫ�󶨵�ǰ���������</param>
        public void BindDdl_TitleStyleId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetTitleStyleId();
            objDDL.DataValueField = conTitleStyle.TitleStyleId;
            objDDL.DataTextField = conTitleStyle.TitleStyleName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// Ϊ�������ȡ����,�ӱ�[DataGridStyle]�л�ȡ
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <returns>��ȡ�����ֶΡ������ֶ����е����м�¼��¼��DataTable</returns>
        public System.Data.DataTable GetDgStyleId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select DgStyleId, DgStyleName from DataGridStyle ";
            clsSpecSQLforSql mySql = clsViewStyleBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// �󶨻���Web��������
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <param name="objDDL">��Ҫ�󶨵�ǰ���������</param>
        public void BindDdl_DgStyleId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetDgStyleId();
            objDDL.DataValueField = conDataGridStyle.DgStyleId;
            objDDL.DataTextField = conDataGridStyle.DgStyleName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// ���ð�����������ֶΣ�[TitleStyleId]
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDdl_TitleStyleId(string strPrjId)
        {
            clsTitleStyleBLEx.BindDdl_TitleStyleId(ddlTitleStyleId, strPrjId);
        }
        /// <summary>
        /// ���ð�����������ֶΣ�[DgStyleId]
        /// (AGC.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDdl_DgStyleId()
        {
            clsDataGridStyleBL.BindDdl_DgStyleId(ddlDgStyleId);
        }
    }
}