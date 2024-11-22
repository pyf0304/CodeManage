
//���������صĿؼ����Ʋ����
namespace CompanyPage.Webform
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
    using AGC.FunClass;


    /// <summary>
    ///		wucNewsB ��ժҪ˵����
    /// </summary>
    public partial class wucNewsB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            DotNetTextBox();

        }
        public void DotNetTextBox()
        {
            txtNewsContent.UploadFolder = "../NewUpload/News/" + clsCommonSession.UserId + "/";
            txtNewsContent.Skin = "skin/xp/";
            //txtnewscontent.menuconfig = "all_3row.config";
            txtNewsContent.MenuConfig = "all.config";
            txtNewsContent.LeftAreaAlign = "left";
            txtNewsContent.Width = 800;
            txtNewsContent.Height = 400;
        }
        /// <summary>
        /// ����
        /// </summary>
        public string NewsTitle
        {
            get
            {
                return txtNewsTitle.Text.Trim();
            }
            set
            {
                txtNewsTitle.Text = value.ToString();
            }
        }

        /// <summary>
        /// ��Ѷ����
        /// </summary>
        public string NewsTypeId
        {
            get
            {
                if (ddlNewsTypeId.SelectedValue == "0")
                    return "";
                return ddlNewsTypeId.SelectedValue;
            }
            set
            {
                if (ddlNewsTypeId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlNewsTypeId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlNewsTypeId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// �Ƿ��ö�
        /// </summary>
        public bool IsTop
        {
            get
            {
                return chkIsTop.Checked;
            }
            set
            {
                chkIsTop.Checked = value;
            }
        }

        /// <summary>
        /// ͼƬ·��
        /// </summary>
        public string ImgPath
        {
            get
            {
                if (ImgUrl.ImageUrl == "" || fupImageUrl.PostedFile.FileName != "")
                {

                    string path = fupImageUrl.PostedFile.FileName;
                    if (path.Length != 0)
                    {
                        //Page.ClientScript.RegisterStartupScript(typeof(wucPhotoNewsB), "a", "<script>alert('��ѡ����Ҫ�ϴ����ļ���')</script>");
                        //return;
                        string c = path.Substring(path.LastIndexOf("\\") + 1);
                        path = "~/Upload/News/" + c;
                        this.fupImageUrl.PostedFile.SaveAs(Server.MapPath("~/Upload//News//") + c);
                        return path;
                    }
                    else
                    {
                        return "";
                    }
                }
                else
                {
                    string path = ImgUrl.ImageUrl;
                    return path;
                }


            }
            set
            {
                ImgUrl.ImageUrl = value.ToString();
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        public string NewsContent
        {
            get
            {
                return txtNewsContent.Text.Trim();
            }
            set
            {
                txtNewsContent.Text = value.ToString();
            }
        }

        /// <summary>
        /// �༭��Ա
        /// </summary>
        public string EditPeople
        {
            get
            {
                return txtEditPeople.Text.Trim();
            }
            set
            {
                txtEditPeople.Text = value.ToString();
            }
        }

        /// <summary>
        /// �༭ʱ��
        /// </summary>
        public string EditTime
        {
            get
            {
                return txtEditTime.Text.Trim();
            }
            set
            {
                txtEditTime.Text = value.ToString();
            }
        }

        /// <summary>
        /// ��Դ
        /// </summary>
        public string Source
        {
            get
            {
                return txtSource.Text.Trim();
            }
            set
            {
                txtSource.Text = value.ToString();
            }
        }

        /// <summary>
        /// �����
        /// </summary>
        public int Views
        {
            get
            {
                return int.Parse(txtViews.Text.Trim());
            }
            set
            {
                txtViews.Text = value.ToString();
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
            txtNewsTitle.Text = "";
            ddlNewsTypeId.SelectedIndex = 0;
            chkIsTop.Checked = false;

            txtNewsContent.Text = "";
            txtEditPeople.Text = "";
            txtEditTime.Text = "";
            txtSource.Text = "";
            txtViews.Text = "0";
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
            txtNewsTitle.Text = "";
            ddlNewsTypeId.SelectedIndex = 0;
            chkIsTop.Checked = false;

            txtNewsContent.Text = "";
            txtEditPeople.Text = "";
            txtEditTime.Text = "";
            txtSource.Text = "";
            txtViews.Text = "0";
            txtMemo.Text = "";
        }
        public System.Data.DataTable GetNewsTypeId()
        {
            //��ȡĳѧԺ����רҵ��Ϣ
            string strSQL = "select NewsTypeId, NewsTypeName from NewsType ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_NewsTypeId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            System.Data.DataTable objDT = GetNewsTypeId();
            objDDL.DataValueField = "NewsTypeId";
            objDDL.DataTextField = "NewsTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetDdl_NewsTypeId()
        {
            BindDdl_NewsTypeId(ddlNewsTypeId);
        }
    }
}