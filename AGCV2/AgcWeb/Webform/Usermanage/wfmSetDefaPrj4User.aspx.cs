using System.Data;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
//using SqlSv; 


using AGC.Entity;
using AGC.FunClass;

namespace AGC.Webform
{
    /// <summary>
    /// frmLogin ��ժҪ˵����
    /// </summary>
    public partial class wfmSetDefaPrj4User : System.Web.UI.Page
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)
            {
                lblWelComeMsg.Text = clsCommonSession.objQxUser.UserName + "����ӭ��ʹ�ñ�ϵͳ!";
                ShowInfo();
            }
        }



        private clsUsersEN objUserBak
        {
            get
            {
                clsUsersEN pobjUser;
                pobjUser = (clsUsersEN)Session["objUser"];
                if (pobjUser == null)
                {
                    pobjUser = null;
                }
                return pobjUser;
            }
            set
            {
                clsUsersEN pobjUser = value;
                Session.Add("objUser", pobjUser);
            }
        }

        private void BindRad_Projects()
        {
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3������DATAGRID������Դ(DataSource)��
            //	4����DATAGRID������DataTable��������ʾ��DATAGRID��
            //	5�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = clsUserPrjGrantBLEx.GetUserPrjGrantT1("UserPrjGrant.UserId='" + clsCommonSession.objQxUser.UserId + "'");
            //	3������DATAGRID������Դ(DataSource)��
            this.RadioButtonList1.DataSource = objDT.DefaultView;
            this.RadioButtonList1.DataTextField = "ProjectsPrjName";
            this.RadioButtonList1.DataValueField = "prjId";
            //	4����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.RadioButtonList1.DataBind();
        }

        private void ShowInfo()
        {
            ///	�󶨵�ѡ�б�
            BindRad_Projects();
            //�������裺����3����
            //	1��ͨ����ǰ�û������û�ȱʡֵ���鵱ǰ�û���Ĭ�Ϲ���(00050001)�Ƿ����
            //	2���������ھͲ�<ϵͳȱʡֵ���Ʊ�>�е�ȱʡֵ��
            //	3�������ͻ�ȡ�˵�ǰ�û���Ĭ�Ϲ��̡�

            //	1��ͨ����ǰ�û������û�ȱʡֵ���鵱ǰ�û���Ĭ�Ϲ���(00050001)�Ƿ����
            DataTable DT = clsUserDefaValue_LocalBL.GetDataTable_UserDefaValue_Local("UserId='" + clsCommonSession.objQxUser.UserId + "'");
            if (DT.Rows.Count == 0)
            {
                //				Response.Write("<script>alert('���û������ڣ�')</script>");
                return;
            }
            string DefaValue = DT.Rows[0]["UserDefaValue"].ToString();
            string DefaValNameId = DT.Rows[0]["DefaValNameId"].ToString();

            //	2���������ھͲ�<ϵͳȱʡֵ���Ʊ�>�е�ȱʡֵ��
            if (DefaValue == "")
            {
                DT = clsSysDefaValNameBL.GetDataTable_SysDefaValName("DefaValNameId='" + DefaValNameId + "'");
                if (DT.Rows.Count == 0)
                {
                    Response.Write("<script>alert('ϵͳĬ�����ݲ����ڣ�')</script>");
                }
                DefaValue = DT.Rows[0]["SysDefaValue"].ToString();
            }

            //	3�������ͻ�ȡ�˵�ǰ�û���Ĭ�Ϲ��̡�
            if (clsUserPrjGrantBL.IsExistRecord("UserId = '" + clsCommonSession.objQxUser.UserId + "' and PrjId = '" + DefaValue + "'") == true)
            {
                RadioButtonList1.SelectedValue = DefaValue;
            }
            else
            {
                RadioButtonList1.SelectedIndex = 0;
            }
        }


        protected void btnGO_Click(object sender, System.EventArgs e)
        {
            //Session["P1rjId"]=RadioButtonList1.SelectedValue.ToString();
            Response.Redirect("wfmPrjUserRole_QUDI.aspx");
        }

        protected void btnSetDefaPrj_Click(object sender, System.EventArgs e)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(clsPubVar.CurrPrjDataBaseId);
            string strDefaPrjId;
            strDefaPrjId = RadioButtonList1.SelectedValue.ToString();
            clsUserDefaValue_LocalEN objUserDefaValue = new clsUserDefaValue_LocalEN();
            ///�жϸ��û��Ƿ���ȱʡֵ
            if (clsUserDefaValue_LocalBL.IsExistRecord("UserId = '" + clsCommonSession.objQxUser.UserId + "'") == false)
            {
                objUserDefaValue.UserDefaValue = strDefaPrjId;
                objUserDefaValue.UserId = clsCommonSession.objQxUser.UserId;
                objUserDefaValue.DefaValNameId = "00050001";
                clsUserDefaValue_LocalBL.AddNewRecordBySql2(objUserDefaValue);
            }
            else
            {
                objUserDefaValue.mId = long.Parse(clsUserDefaValue_LocalBL.GetPrimaryKeyID_S("UserId='" + clsCommonSession.objQxUser.UserId + "'")[0].ToString());
                clsUserDefaValue_LocalBL.GetUserDefaValue_Local(ref objUserDefaValue);
                objUserDefaValue.UserDefaValue = strDefaPrjId;
                clsUserDefaValue_LocalBL.UpdateBySql2(objUserDefaValue);
            }
            //PrjId = strDefaPrjId;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(strDefaPrjId);
            new clsCommonSession().PrjDataBaseName = objPrjDataBase.DataBaseName;
            lblMsg.Text = "��ǰ�û�Ĭ�Ϲ����Ѿ�����Ϊ��" + objProject.PrjName;
        }
    }
}
