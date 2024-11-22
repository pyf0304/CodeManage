

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
    ///		wucExportExcel4UsersB ��ժҪ˵����
    /// </summary>
    public partial class wucExportExcel4UsersB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��

        }
        /// <summary>
        /// ����Excel�û��ֶ���ˮ��
        /// </summary>
        public string IdExportExcel4Users
        {
            get
            {
                if (ddlIdExportExcel4Users.SelectedValue == "0")
                    return "";
                return ddlIdExportExcel4Users.SelectedValue;
            }
            set
            {
                if (ddlIdExportExcel4Users.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlIdExportExcel4Users.SelectedValue = "0";
                    }
                    else
                    {
                        ddlIdExportExcel4Users.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// �ֶ���
        /// </summary>
        public string FieldName
        {
            get
            {
                return txtFieldName.Text.Trim();
            }
            set
            {
                txtFieldName.Text = value.ToString();
            }
        }

        /// <summary>
        /// �ֶ���������
        /// </summary>
        public string FieldCnName
        {
            get
            {
                return txtFieldCnName.Text.Trim();
            }
            set
            {
                txtFieldCnName.Text = value.ToString();
            }
        }

        /// <summary>
        /// �Ƿ񵼳�
        /// </summary>
        public bool IsExport
        {
            get
            {
                return chkIsExport.Checked;
            }
            set
            {
                chkIsExport.Checked = value;
            }
        }

        /// <summary>
        /// ���
        /// </summary>
        public int OrderNum
        {
            get
            {
                return int.Parse(txtOrderNum.Text.Trim());
            }
            set
            {
                txtOrderNum.Text = value.ToString();
            }
        }


        /// <summary>
        /// ��ע
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
            ddlIdExportExcel4Users.SelectedIndex = 0;
            txtFieldName.Text = "";
            txtFieldCnName.Text = "";
            chkIsExport.Checked = false;
            txtOrderNum.Text = "0";
          
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
            ComValid_OrderNum.Validate();
            if (!ComValid_OrderNum.IsValid) return false;
            if (clsString.IsNumeric(txtOrderNum.Text) == false)
            {
                strResult = "��������ȷ������!";
                return false;
            }
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
            ddlIdExportExcel4Users.SelectedIndex = 0;
            txtFieldName.Text = "";
            txtFieldCnName.Text = "";
            chkIsExport.Checked = false;
            txtOrderNum.Text = "0";
        
            txtMemo.Text = "";
        }
        public System.Data.DataTable GetIdExportExcel4Users()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select IdExportExcel4Users, ViewTabName from vExportExcelSet ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_IdExportExcel4Users(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetIdExportExcel4Users();
            objDDL.DataValueField = "IdExportExcel4Users";
            objDDL.DataTextField = "ViewTabName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetDdl_IdExportExcel4Users()
        {
            clsvExportExcelSetBL.BindDdl_IdExportExcel4Users(ddlIdExportExcel4Users);
        }
        public void SetFieldNameEnable(bool bolIsEnable)
        {
            txtFieldName.Enabled = bolIsEnable;
            txtOrderNum.Enabled = bolIsEnable;
            ddlIdExportExcel4Users.Enabled = bolIsEnable;
        }
    }
}