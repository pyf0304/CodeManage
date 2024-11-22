///���ɲ�ѯ���޸ģ�ɾ������Ӽ�¼�Ŀ��Ʋ����
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
//using SqlSv;
using com.taishsoft.commdb;
//using ProjectDesign;
using System.Text;
using CommFunc4WebForm;
using com.taishsoft.common;


using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using System.Collections.Generic;
using AGC.Entity;


using com.taishsoft.datetime;


namespace AGC.Webform
{
    /// <summary>
    /// wfmPrjTabFld_QUDI:���ֶε�ά��
    /// </summary>
    public partial class wfmPrjTabFld_QUDI : CommWebPageBase
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {

           
            //            Page.RegisterStartupScript("js", js1);

            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
            {

                //1��Ϊ��������������Դ�����б�����
                //				wucPrjTabFld1.SetDdl_TabId();
                //				wucPrjTabFld1.SetDdl_FldID();
                wucPrjTabFld1.SetDdl_PrimaryTypeId();
                wucPrjTabFld1.SetDdl_ForeignKeyTabId(clsPubVar.CurrSelPrjId);
                wucPrjTabFld1.SetDdl_FieldTypeId();


                //BindDdl_PrjObjects(ddlPrjObject, clsPubVar.CurrSelPrjId);
                //2����ʾ�������ı�������DATAGRID��
                strSortPrjTabFldBy = "SequenceNumber Asc";
                strSortObjFldTabBy = "FldName Asc";

                BindDg_FldObjTab();
                BindGv_PrjTabFld();
                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
                this.tabEditPrjTabFld.Visible = false;
                this.tabFieldTab.Visible = false;

                btnDelRec.Attributes.Add("onclick", "return confirm('�����Ҫɾ����ѡ��¼��');");
                ///��ʾ��ǰ������
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(TabId);
                lblCurrTabName.Text = objPrjTabEN.TabName + "(" + objPrjTabEN.TabCnName + ")";
            }
        }
        private string BackErrPageLinkStr
        {
            get
            {
                string strBackErrPageLinkStr;
                strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
                if (strBackErrPageLinkStr == null)
                {
                    strBackErrPageLinkStr = "";
                }
                return strBackErrPageLinkStr;
            }
            set
            {
                string strBackErrPageLinkStr = value;
                Session.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
            }
        }
        private string ErrMessage
        {
            get
            {
                string strErrMessage;
                strErrMessage = (string)Session["ErrMessage"];
                if (strErrMessage == null)
                {
                    strErrMessage = "";
                }
                return strErrMessage;
            }
            set
            {
                string strErrMessage = value;
                Session.Add("ErrMessage", strErrMessage);
            }
        }



        //���ɷ������Ӵ���Session����
        protected string BackPageLinkStrFromUpdField
        {
            get
            {
                string strBackPageLinkStrFromUpdField;
                strBackPageLinkStrFromUpdField = (string)Session["BackPageLinkStrFromUpdField"];
                if (strBackPageLinkStrFromUpdField == null)
                {
                    strBackPageLinkStrFromUpdField = "";
                }
                return strBackPageLinkStrFromUpdField;
            }
            set
            {
                string strBackPageLinkStrFromUpdField = value;
                Session.Add("BackPageLinkStrFromUpdField", strBackPageLinkStrFromUpdField);
            }
        }
        private string UserId
        {
            get
            {
                string strUserId;
                strUserId = (string)Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                    clsCommForWebForm.CheckUserId(strUserId, this);
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                Session.Add("UserId", strUserId);
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
      

        private string TabId
        {
            get
            {
                string strTabId;
                strTabId = (string)Session["TabId"];
                if (strTabId == null)
                {
                    strTabId = "";
                }
                return strTabId;
            }
            set
            {
                string strTabId = value;
                Session.Add("TabId", strTabId);
            }
        }
        private string FldId
        {
            get
            {
                string strFldId;
                strFldId = (string)Session["FldId"];
                if (strFldId == null)
                {
                    strFldId = "";
                }
                return strFldId;
            }
            set
            {
                string strFldId = value;
                Session.Add("FldId", strFldId);
            }
        }

        
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        private string CombinePrjTabFldCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 and UserName = '����'
            string strWhereCond = " 1=1 and TabId='" + TabId + "'";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�

            return strWhereCond;
        }
        ///���ɰ�DATAGRID�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��DATAGRID�С�
        /// </summary>
 
        /// <summary>
        /// ���ܣ�����DataGrid��ҳ��
        /// </summary>
        /// <param name="intRecCount">�ܹ��ļ�¼��</param>
        /// <param name="intPageSize">ÿҳ�ļ�¼��</param>
        /// <returns>���������ҳ��</returns>
        private int CalcPages(int intRecCount, int intPageSize)
        {
            int intPages;
            intPages = intRecCount / intPageSize;
            if (intRecCount % intPageSize != 0) intPages++;
            return intPages;
        }

        /// <summary>
        /// �������ܣ��¼�������������<��ѯ>��ťʱ���������¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //��DATAGRID�ĵ�ǰҳ��������Ϊ0������1ҳ��
            //��������ѯʱ��������ʾ���Ǳ��¼���ݵĵ�һ�������ݡ�
            this.dgObjFld4Sel.CurrentPageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindDg_FldObjTab();
        }
       
        /// <summary>
        /// �������ܣ����Ըùؼ��ֵļ�¼������ʾ�ڽ����ϣ�
        ///������     �������ǰ�ֵ������ؼ���
        /// </summary>
        /// <param name="lngMId">���¼�Ĺؼ��֣���ʾ�ñ�ؼ��ֵ�����</param>
        private void ShowData(long lngMId)
        {
            //�������裺
            //1�����ؼ����Ƿ�Ϊ�գ�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            //4����ȡ�������������ԣ�
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���

            //1�����ؼ����Ƿ�Ϊ�գ�
            if (lngMId == 0) return;		//����ؼ���Ϊ�վͷ����˳�
            //2�����ùؼ��ֵļ�¼�Ƿ���ڣ���������ھͷ��ز���ʾ��
            if (clsPrjTabFldBL.IsExist(lngMId) == false)		//���ùؼ��ֵļ�¼�Ƿ����
            {
                string ss = "�ؼ���Ϊ��" + lngMId + "�Ĳ�����!";
                clsCommonJsFunc.Alert(this, ss);
                return;
            }
            //3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
            clsPrjTabFldEN objPrjTabFld = new clsPrjTabFldEN(lngMId);
            //4����ȡ�������������ԣ�
            clsPrjTabFldBL .GetPrjTabFld(ref objPrjTabFld);
            Session.Add("objPrjTabFld", objPrjTabFld);
            //5���Ѹö��������������ʾ�ڽ����ϣ���������ʾ�ڱ�ؼ���
            GetDataFromPrjTabFldClass(objPrjTabFld);
        }
        ///���ɴ��߼�������ݴ��䵽�����ĺ�������
        /// <summary>
        /// �������ܣ�������������������ʾ��������
        ///ע�⣺��������������򣬲�����һ��������������ϵ�ģ�����Ϊһ��������ֵ��Ȼ����Ϊ����������ֵ
        ///      ������������ݿ�ʱ����Ӧ��һ���ֶ���ǰ�������ֶ��ں�
        /// </summary>
        /// <param name="pobjPrjTabFld">��ʵ�������</param>
        private void GetDataFromPrjTabFldClass(clsPrjTabFldEN pobjPrjTabFld)
        {
            wucPrjTabFld1.FldId = pobjPrjTabFld.FldId;
            clsFieldTabEN objFieldTabEN = new clsFieldTabEN(pobjPrjTabFld.FldId);
            clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
            wucPrjTabFld1.FldName = objFieldTabEN.FldName + "(" + objFieldTabEN.Caption + ")";

            wucPrjTabFld1.IsTabUnique = pobjPrjTabFld.IsTabUnique;
            wucPrjTabFld1.IsTabNullable = pobjPrjTabFld.IsTabNullable;
            wucPrjTabFld1.IsParentObj = pobjPrjTabFld.IsParentObj;
            wucPrjTabFld1.PrimaryTypeId = pobjPrjTabFld.PrimaryTypeId;
            wucPrjTabFld1.FldOpTypeId = pobjPrjTabFld.FldOpTypeId;

            wucPrjTabFld1.IsTabForeignKey = pobjPrjTabFld.IsTabForeignKey;
            wucPrjTabFld1.ForeignKeyTabId = pobjPrjTabFld.ForeignKeyTabId;
            wucPrjTabFld1.FieldTypeId = pobjPrjTabFld.FieldTypeId;
            wucPrjTabFld1.MemoInTab = pobjPrjTabFld.MemoInTab;
        }
        /// <summary>
        /// �������ܣ��¼�������������<ȷ���޸�>ʱ�������¼�������
        ///           ���幦��Ϊ�ѽ�������ͬ�����ݿ��У��ѽ������ݱ��浽���ݿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strMsg;	//ר�����ڴ�����Ϣ�ı���
            string strCommandText;
            clsPrjTabFldEN objPrjTabFld;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "���":
                    //					btnOKUpd.Text = "ȷ�����";
                    break;
                case "ȷ�����":
                    //����һ������Ĳ���Ĵ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    //�������裺
                    //1�����ؼ����������������Ƿ���ȷ
                    //2��������󲢳�ʼ������
                    //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
                    //4����ֵ�ӽ���㴫���߼��������ʵ���
                    //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    //6��������ʵ�������ݴ��������ݿ���
                    //7��������ļ�¼������ʾ��DATAGRID��
                    //1�����ؼ����������������Ƿ���ȷ
                    if (!wucPrjTabFld1.IsValid())
                    {
                        //						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2��������󲢳�ʼ������
                    //clsPrjTabFldEN objPrjTabFld;	//�������
                    objPrjTabFld = new clsPrjTabFldEN();	//��ʼ���¶���
                    //3���ж��Ƿ�����ͬ�Ĺؼ���,��������Ǳ�ʶ�����;Ͳ���Ҫ�ж��Ƿ����
                    //4����ֵ�ӽ���㴫���߼��������ʵ���
                    PutDataToPrjTabFldClass(objPrjTabFld);		//�ѽ����ֵ����
                    //5����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    ///
                    try
                    {
                         clsPrjTabFldBL .CheckPropertyNew(objPrjTabFld);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
                    //6��������ʵ�������ݴ��������ݿ���
                    if (clsPrjTabFldBL .AddNewRecordBySql2(objPrjTabFld) == false)
                    {
                        strMsg = "��Ӳ��ɹ�!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        //						lblMsg.Text = "��Ӽ�¼���ɹ�!";
                    }
                    else
                    {
                        strMsg = "��Ӽ�¼�ɹ�!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        //						lblMsg.Text = "��Ӽ�¼�ɹ�!";
                    }
                    //7��������ļ�¼������ʾ��DATAGRID��
                    BindGv_PrjTabFld();
                    wucPrjTabFld1.Clear();		//��տؼ�������
                    ///�ָ�<ȷ�����>���<���>
                    //					btnOKUpd.Text = "���";
                    break;
                case "ȷ���޸�":
                    //����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
                    //�Ͱ��߼���ϲ������Ʋ�,
                    //�������裺
                    //1�����ؼ����������������Ƿ���ȷ
                    //2����ֵ�ӽ���㴫���߼��������ʵ���
                    //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    //4��������ʵ�������ݴ��������ݿ���
                    //5�����޸ĺ��������ʾ��DATAGRID��
                    //1�����ؼ����������������Ƿ���ȷ
                    if (!wucPrjTabFld1.IsValid())
                    {
                        //						lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                        return;
                    }
                    //2����ֵ�ӽ���㴫���߼��������ʵ���
                    objPrjTabFld = (clsPrjTabFldEN)Session["objPrjTabFld"];
                    PutDataToPrjTabFldClass(objPrjTabFld);		//�ѽ����ֵ����
                    //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
                    try
                    {
                         clsPrjTabFldBL .CheckPropertyNew(objPrjTabFld);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }

                    //4��������ʵ���������޸�ͬ�������ݿ���
                    if (clsPrjTabFldBL.UpdateBySql2(objPrjTabFld) == false)
                    {
                        strMsg = "�޸ļ�¼���ɹ�!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        //						lblMsg.Text = "�޸ļ�¼���ɹ�!";
                    }
                    else
                    {
                        strMsg = "�޸ļ�¼�ɹ�!";
                        clsCommonJsFunc.Alert(this, strMsg);
                        //						lblMsg.Text = "�޸ļ�¼�ɹ�!";
                    }
                    //5�����޸ĺ��������ʾ��DATAGRID��
                    BindGv_PrjTabFld();
                    wucPrjTabFld1.Clear();//��տؼ��е�����
                    //�ָ�<ȷ���޸�>���<���>
                    //					btnOKUpd.Text = "���";
                    break;
            }
        }
        
        /// <summary>
        /// �������ܣ��ѽ����ϵ��������ݴ����������
        /// </summary>
        /// <param name="pobjPrjTabFld">���ݴ����Ŀ�������</param>
        private void PutDataToPrjTabFldClass(clsPrjTabFldEN pobjPrjTabFld)
        {
            pobjPrjTabFld.TabId = TabId;
            pobjPrjTabFld.FldId = wucPrjTabFld1.FldId;

            pobjPrjTabFld.IsTabUnique = wucPrjTabFld1.IsTabUnique;

            pobjPrjTabFld.IsTabNullable = wucPrjTabFld1.IsTabNullable;
            pobjPrjTabFld.IsParentObj = wucPrjTabFld1.IsParentObj;
            pobjPrjTabFld.PrimaryTypeId = wucPrjTabFld1.PrimaryTypeId;
            pobjPrjTabFld.FldOpTypeId = wucPrjTabFld1.FldOpTypeId;
            pobjPrjTabFld.IsTabForeignKey = wucPrjTabFld1.IsTabForeignKey;
            pobjPrjTabFld.ForeignKeyTabId = wucPrjTabFld1.ForeignKeyTabId;
            pobjPrjTabFld.FieldTypeId = wucPrjTabFld1.FieldTypeId;
            pobjPrjTabFld.MemoInTab = wucPrjTabFld1.MemoInTab;

        }

        protected void dgPrjTabFld_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            long lngMId;
            string strCommandName;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                strCommandName = ((LinkButton)e.CommandSource).CommandName;
                lngMId = long.Parse(e.Item.Cells[0].Text);
                switch (strCommandName)
                {
                    case "Delete":
                        clsPrjTabFldBLEx.DelRecordEx(lngMId);
                        break;
                    // Add other cases here, if there are multiple ButtonColumns in 
                    // the DataGrid control.
                    case "Update":
                        //�������裺���ܹ�2����
                        //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
                        //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

                        //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
                        ShowData(lngMId);
                        //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
                        //						clsPubFun.SetButtonEnabled(btnOKUpd, true);
                        //						btnOKUpd.Text = "ȷ���޸�";
                        //						lblMsg.Text = "";
                        break;

                    default:
                        // Do nothing.
                        break;
                }
            }
        }
       

        public void BindDdl_IsPrimary(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //Ϊ����Դ�ڱ����������������
            ListItem li = new ListItem("��ѡ��...", "0");
            objDDL.Items.Insert(0, li);
            objDDL.Items.Add("��");
            objDDL.Items.Add("��");
            objDDL.SelectedIndex = 0;
        }


        //private void BindDdl_PrjObjects(DropDownList objDdl, string PrjId)
        //{

        //    ListItem li = new ListItem("��ѡ��...", "0");
        //    DataTable objDt = clsPrjObjectsBLEx.GetPrjObjectsEx(" PrjId='" + PrjId + "'", "ObjName");
        //    objDdl.DataSource = objDt;
        //    objDdl.DataTextField = "ObjName";
        //    objDdl.DataValueField = "ObjId";
        //    objDdl.DataBind();
        //    objDdl.Items.Insert(0, li);
        //    objDdl.SelectedIndex = 0;

        //}

        private void BindDg_FldObjTab()
        {
            ///���ѡ��ǰĬ�Ϲ����е������ֶ�
            ///
            string strObjId = this.ddlPrjObject.SelectedValue;
            string strFldName = this.txtFldName.Text.Trim();

            StringBuilder sb = new StringBuilder();

            sb.Append("Select * ,");
            sb.Append(" DataTypeAbbr.DataTypeName DataTypeName");
            sb.Append(" from FieldTab");
            sb.Append(" left join DataTypeAbbr on (FieldTab.DataTypeId=DataTypeAbbr.DataTypeId)");
            if (strObjId == "0")
            {
                sb.Append(" where PrjId='" + clsPubVar.CurrSelPrjId + "'");
            }
            else
            {
                sb.Append(" where PrjId='" + clsPubVar.CurrSelPrjId + "' and  FldId in (select FldId from FldObjTab where ObjId='" + strObjId + "')");
            }
            if (string.IsNullOrEmpty(strFldName) == false)
            {
                sb.AppendFormat(" and FldName like '{0}%'", strFldName);
            }
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            DataTable objDt = objSQL.GetDataTable(sb.ToString());

            //	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //		3.1 ���ȼ���ҳ����
            //		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
            int intPages = CalcPages(objDt.Rows.Count, dgObjFld4Sel.PageSize);
            if (intPages == 0)
            {
                dgObjFld4Sel.CurrentPageIndex = 0;
            }
            else if (dgObjFld4Sel.CurrentPageIndex > intPages - 1)
            {
                dgObjFld4Sel.CurrentPageIndex = intPages - 1;
            }
            DataView objDV = objDt.DefaultView;
            objDV.Sort = strSortObjFldTabBy;
            dgObjFld4Sel.DataSource = objDV;
            dgObjFld4Sel.DataBind();
            txtRecCount_PrjTabFld.Text = objDt.Rows.Count.ToString();
            chkSelAll_CheckedChanged(new object(), new System.EventArgs());
        }

        private void Add_ObjectFldtoPrjTabFld(ArrayList objArr)
        {
            string strTabId;
            bool bolIsnullable;
            int intTabFldCount;
            if (objArr.Count == 0)
            {
                return;
            }
            else
            {
                strTabId = TabId;
                if (strTabId.Length == 0)
                {
                    lblMsg1.Text = "��ѡ����ʵı���";
                    return;
                }
                clsPrjTabFldEN objPrjTabFld;
                intTabFldCount = clsPrjTabFldBL.GetRecCountByCond("PrjTabFld", "TabId = '" + strTabId + "'");
                foreach (string FldId in objArr)
                {

                    clsFieldTabEN objFieldTabEN = new clsFieldTabEN(FldId);
                    clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
                    bolIsnullable = objFieldTabEN.IsNull;
                    objPrjTabFld = new clsPrjTabFldEN();
                    objPrjTabFld.TabId = this.TabId;
                    objPrjTabFld.PrjId = clsPubVar.CurrSelPrjId;
                    objPrjTabFld.FldId = FldId;

                    objPrjTabFld.IsTabNullable = bolIsnullable;
                    objPrjTabFld.PrimaryTypeId = "00";
                    objPrjTabFld.FldOpTypeId = "0001";

                    objPrjTabFld.FieldTypeId = "01";
                    ///3.1���ж��Ƿ�����ͬ���ֶδ��ڡ�					
                    if (clsPrjTabFldBLEx.IsExistSameFldId(TabId, FldId))	//�ж��Ƿ�����ͬ�Ĺؼ���
                    {
                    }
                    else
                    {
                        objPrjTabFld.SequenceNumber = intTabFldCount + 1;
                        intTabFldCount++;
                        clsPrjTabFldBL .AddNewRecordBySql2(objPrjTabFld);
                    }
                }
            }
        }

        private void Get_ObjectFldArrylist(DataGrid objDg, ArrayList objArr)
        {
            if (objArr == null || objDg.Items.Count == 0)
            {
                return;
            }
            else
            {
                objArr.Clear();
                foreach (DataGridItem di in objDg.Items)
                {
                    CheckBox cb = (CheckBox)di.FindControl("ckb1");
                    if (cb != null && cb.Checked)
                    {
                        objArr.Add(di.Cells[1].Text);
                    }
                }
            }
        }

        private void Set_DataGridAllChecked(DataGrid objDg, CheckBox objCkb)
        {
            if (objCkb == null || objDg.Items.Count == 0)
            {
                return;
            }
            else
            {
                foreach (DataGridItem di in objDg.Items)
                {
                    CheckBox cb = (CheckBox)di.FindControl("ckb1");
                    if (cb != null)
                    {
                        cb.Checked = objCkb.Checked;
                    }
                }

            }
        }


        protected void btnAdd_Click(object sender, System.EventArgs e)
        {
            lblMsgEdit.Text = "";

            DispFieldTab();
        }

        protected void btnSetProperty_Click(object sender, System.EventArgs e)
        {
            //�������裺���ܹ�2����
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�

            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            //clsPubFun.SetButtonEnabled(btnOKUpd, true);
            //btnOKUpd.Text = "ȷ���޸�";

            lblMsgEdit.Text = "";

            string strmId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTabFld);
            if (strmId == null || strmId.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            long lngmId;
            lngmId = long.Parse(strmId);
            DispEditPrjTabFld();
            ShowData(lngmId);
            this.wucPrjTabFld1.SetKeyReadOnly(true);
                //				lblMsg.Text = "";
        }

        protected void btnDelRec_Click(object sender, System.EventArgs e)
        {
            string strmId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTabFld);
            if (strmId == null || strmId.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            long lngmId;
            lngmId = long.Parse(strmId);
            clsPrjTabFldBLEx.DelRecordEx(lngmId);
            BindGv_PrjTabFld();
        }

        protected void btnOKEdit_Click(object sender, System.EventArgs e)
        {

            string strMsg;	//ר�����ڴ�����Ϣ�ı���
            //			string strCommandText;
            clsPrjTabFldEN objPrjTabFld;
            //����һ��������޸ĵĴ��룬�����߼���̫�򵥣�
            //�Ͱ��߼���ϲ������Ʋ�,
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            //4��������ʵ�������ݴ��������ݿ���
            //5�����޸ĺ��������ʾ��DATAGRID��
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucPrjTabFld1.IsValid())
            {
                //				lblMsg.Text = "�ؼ��������������Ͳ���ȷ����!";
                return;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            objPrjTabFld = (clsPrjTabFldEN)Session["objPrjTabFld"];
            PutDataToPrjTabFldClass(objPrjTabFld);		//�ѽ����ֵ����
            //3����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            ///
            try
            {
                 clsPrjTabFldBL .CheckPropertyNew(objPrjTabFld);
            }
            catch (Exception objException)
            {
                strMsg = "����ֶ����Գ���!\r\n" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return;
            }

            //4��������ʵ���������޸�ͬ�������ݿ���
            ///
            try
            {
                if (clsPrjTabFldBL.UpdateBySql2(objPrjTabFld) == false)
                {
                    strMsg = "�޸ļ�¼���ɹ�!";
                    clsCommonJsFunc.Alert(this, strMsg);
                    //				lblMsg.Text = "�޸ļ�¼���ɹ�!";
                }
                else
                {
                    strMsg = "�޸ļ�¼�ɹ�!";
                    clsCommonJsFunc.Alert(this, strMsg);
                    //				lblMsg.Text = "�޸ļ�¼�ɹ�!";
                    this.tabEditPrjTabFld.Visible = false;
                    //�޸�����ֶ�����

                    if (clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTab(objPrjTabFld.TabId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, true, clsCommonSession.UserId) == false)
                    {
                        clsTabCheckStatusEN objPrjTab_CheckEN = clsTabCheckStatusBLEx.GetObjByTabIdCacheEx(objPrjTabFld.TabId, objPrjTabFld.PrjId, clsPubVar.CurrPrjDataBaseId);
                        clsCommonJsFunc.Alert(this, objPrjTab_CheckEN.ErrorMsg);
                        //return;
                    }
                }
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "�޸ļ�¼���ɹ�!\r\n" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //5�����޸ĺ��������ʾ��DATAGRID��
            BindGv_PrjTabFld();
            wucPrjTabFld1.Clear();//��տؼ��е�����
            DispPrjTabFldList();
            //�ָ�<ȷ���޸�>���<���>
            //			btnOKUpd.Text = "���";
        }

        protected void btnOkAdd_Click(object sender, System.EventArgs e)
        {
            //			string strWhereCond;
            //string strFldId;
            //System.Data.DataTable objDT;
            ArrayList objArr = new ArrayList();
            //if (chkSelAll.Checked == true)
            //{
            //    //	1����Ͻ�����������
            //    //	2��������������ȡ�ñ�����������DataTable��
           
            this.Add_ObjectFldtoPrjTabFld(objArr);
            BindGv_PrjTabFld();
            Response.Write("<script>alert('��ѡ�ֶ���ӳɹ�����')</script>");
        }

        protected void dgObjFld4Sel_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.dgObjFld4Sel.CurrentPageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindDg_FldObjTab();
        }

        protected void chkSelAll_CheckedChanged(object sender, System.EventArgs e)
        {
            this.Set_DataGridAllChecked(this.dgObjFld4Sel, this.chkSelAll);
        }

        protected void ddlPrjObject_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            BindDg_FldObjTab();
        }

        protected void dgPrjTabFld_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            //			System.Web.UI.WebControls.CheckBox chkIsPrimary;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];
                iNum[0] = 7;
                iNum[1] = 8;
                iNum[2] = 11;
                iNum[3] = 12;
                iNum[4] = 13;
                for (int i = 0; i < 5; i++)
                {
                    if (e.Item.Cells[iNum[i]].Text == "True")
                    {
                        e.Item.Cells[iNum[i]].Text = "��";
                        e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        e.Item.Cells[iNum[i]].Text = "��";
                        e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Red;
                    };
                }

            }
        }

        protected void lbReturn_Click(object sender, System.EventArgs e)
        {
            Response.Redirect(new clsCommonSession().BackErrPageEditFldLinkStr);
        }

        protected void ibUp_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            
            AdjustSequenceNumber("UP");
        }

        protected void ibDown_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            
            AdjustSequenceNumber("DOWN");
        }
        private bool AdjustSequenceNumber(string strDirect)
        {
            //�������裺
            //1����ȡ��ǰ��ѡ�еĹؼ���Mid��
            //2�����ݹؼ���Mid����ȡ�ֵ����
            //3�������ǰ����Ƿ���ĩ����ţ�
            ///		3.1 �����ĩ����ţ����˳���
            ///		3.2 ������ǣ�������������ƶ������жϵ�ǰ����Ƿ�С�ڡ���ǰ���е��ֶ�����
            ///		    ���������һ����¼����׼���ѵ�ǰ�ֶ������ż�1������һ�ֶε���ż�1��
            ///		    ����������ƶ������жϵ�ǰ����Ƿ񡰴��ڡ�1��
            ///		    �������ʼһ����¼����׼���ѵ�ǰ�ֶ������ż�1������һ�ֶε���ż�1��
            //4����ȡ��(��)һ������ֶεĹؼ���Mid
            //5���ѵ�ǰ�ؼ���Mid����ż�(��)1
            //6������һ����ŵĹؼ���Mid��(��)1
            //7��������ʾDATAGRID
            ///
            int intSequenceNumber;	//��ǰ��¼�����
            int intPrevSeqNum, intNextSeqNum;	//����������¼�����
            long lngMid;		//��ǰ��ѡ��¼�Ĺؼ���MId
            long lngPrevMid = 0;	//��һ����ŵĹؼ���MId
            long lngNextMid = 0;	//��һ����ŵĹؼ���MId
            int intTabRecNum;		//��ǰ�����ֶεļ�¼��
            string strCurrTabId;
            List<string> arrID;
            StringBuilder strCondition = new StringBuilder();
            //1����ȡ��ǰ��ѡ�е��ֶ�ID��
            ///
            string strmId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTabFld);
            if (strmId == null || strmId.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return false;
            }
            lblMsgList.Text = "";
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            lngMid = long.Parse(strmId);
            lblMsg2.Text = "";
            //2�����ݹؼ���Mid����ȡ�ֵ����
            clsPrjTabFldEN objPrjTabEN = clsPrjTabFldBL.GetObjBymId(lngMid);
            intSequenceNumber = objPrjTabEN.SequenceNumber ?? 0;
            intPrevSeqNum = intSequenceNumber - 1;
            intNextSeqNum = intSequenceNumber + 1;
            //3�������ǰ����Ƿ���ĩ����ţ�
            ///		3.1 �����ĩ����ţ����˳���
            strCurrTabId = objPrjTabEN.TabId;		//��ȡ��ǰ��¼��{��ID}
            intTabRecNum = clsPrjTabBL.GetRecCountByCond("TabId = '" + strCurrTabId + "'");	//��ȡ��ǰ{��ID}�ļ�¼��
            if (strDirect == "UP")
            {
                if (intSequenceNumber <= 1)
                {
                    throw new Exception("�Ѿ��ǵ�һ����¼������������!");
                    
                }
            }
            else if (strDirect == "DOWN")
            {
                if (intSequenceNumber >= intTabRecNum)	//�����ǰ��Ŵ��ڱ��¼��
                {
                    throw new Exception("�Ѿ������һ����¼������������!");

                }
            }
            ///		3.2 ������ǣ�������������ƶ������жϵ�ǰ����Ƿ�С�ڡ���ǰ���е��ֶ�����
            ///		    ���������һ����¼����׼���ѵ�ǰ�ֶ������ż�1������һ�ֶε���ż�1��
            ///		    ����������ƶ������жϵ�ǰ����Ƿ񡰴��ڡ�1��
            ///		    �������ʼһ����¼����׼���ѵ�ǰ�ֶ������ż�1������һ�ֶε���ż�1��

            //4����ȡ��(��)һ������ֶεĹؼ���Mid
            if (strDirect == "UP")
            {
                strCondition.AppendFormat("TabId = '{0}' and SequenceNumber = {1}",
                    strCurrTabId, intSequenceNumber - 1);
                arrID = clsPrjTabFldBL.GetPrimaryKeyID_S(strCondition.ToString());
                if (arrID == null)
                {
                    throw new Exception("��ȡ��һ����¼�Ĺؼ��ֳ���!");

                }
                if (arrID.Count <= 0)
                {
                    throw new Exception("��ȡ��һ����¼�Ĺؼ��ֳ���!");
      
                }
                lngPrevMid = long.Parse((string)arrID[0]);
            }
            else if (strDirect == "DOWN")
            {
                strCondition.AppendFormat("TabId = '{0}' and SequenceNumber = {1}",
                    strCurrTabId, intSequenceNumber + 1);
                arrID = clsPrjTabFldBL.GetPrimaryKeyID_S(strCondition.ToString());
                if (arrID == null)
                {
                    throw new Exception("��ȡ��һ����¼�Ĺؼ��ֳ���!");
                    
                }
                if (arrID.Count <= 0)
                {
                    throw new Exception("��ȡ��һ����¼�Ĺؼ��ֳ���!");

                }
                lngNextMid = long.Parse((string)arrID[0]);
            }
            else
            {
                throw new Exception("�����������!");
                
            }
            //5���ѵ�ǰ�ؼ���Mid����ż�(��)1
            //6������һ����ŵĹؼ���Mid��(��)1
            if (strDirect == "UP")
            {
                new clsPrjTabBL().SetFldValue("SequenceNumber", intSequenceNumber - 1, "MId = " + lngMid);
                new clsPrjTabBL().SetFldValue("SequenceNumber", intPrevSeqNum + 1, "MId = " + lngPrevMid);
            }
            else if (strDirect == "DOWN")
            {
                new clsPrjTabBL().SetFldValue("SequenceNumber", intSequenceNumber + 1, "MId = " + lngMid);
                new clsPrjTabBL().SetFldValue("SequenceNumber", intNextSeqNum - 1, "MId = " + lngNextMid);
            }
            //7��������ʾDATAGRID
            BindGv_PrjTabFld();
            clsCommForWebForm.SetCheckedItemForGv(gvPrjTabFld, 0, strmId);
            return true;
        }

        protected void dgPrjTabFld_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortPrjTabFldBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortPrjTabFldBy = e.SortExpression + " Asc";
                BindGv_PrjTabFld();
                return;
            }
            //���ԭ��������
            intIndex = strSortPrjTabFldBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                strSortPrjTabFldBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                strSortPrjTabFldBy = e.SortExpression + " Desc";
            }
            BindGv_PrjTabFld();
        }

        protected void dgObjFld4Sel_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortObjFldTabBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortObjFldTabBy = e.SortExpression + " Asc";
                BindDg_FldObjTab();
                return;
            }
            //���ԭ��������
            intIndex = strSortObjFldTabBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                strSortObjFldTabBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                strSortObjFldTabBy = e.SortExpression + " Desc";
            }
            BindDg_FldObjTab();
        }

        protected void dgObjFld4Sel_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            int intIndex;
            if (strSortObjFldTabBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.dgObjFld4Sel.Columns.Count; i++)
                {
                    strSortEx = this.dgObjFld4Sel.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortObjFldTabBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortObjFldTabBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        protected void dgObjFld4Sel_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                int[] iNum = new int[20];
                iNum[0] = 5;
                //				iNum[1] = 7;
                for (int i = 0; i < 1; i++)
                {
                    if (e.Item.Cells[iNum[i]].Text == "True")
                    {
                        e.Item.Cells[iNum[i]].Text = "��";
                        e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        e.Item.Cells[iNum[i]].Text = "��";
                        e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Red;
                    };
                }

            }
        }

        //protected void btnCopyFldFromRelaObj_Click(object sender, System.EventArgs e)
        //{
        //    //�������裺
        //    //1����ȡ��ǰ��ID����ض���ID��
        //    //2����ȡ��ض���ID���ֶ�ID��DataTable;
        //    //3���Ըñ����ѭ�������ֶ���Ϣ���뵽һ��ArrayList
        //    //4���ڲ�������У�Ҫע���ֶ�ID���ظ������ܲ����ظ�
        //    //			string strWhereCond;
        //    string strFldId;
        //    System.Data.DataTable objDT;
        //    ArrayList objArr = new ArrayList();
        //    string strObjId;

        //    //1����ȡ��ǰ��ID����ض���ID��
        //    strObjId = (clsPrjTabBL.GetObjByTabId(TabId).ObjId);
        //    if (strObjId == null || strObjId.Length == 0)
        //    {
        //        return;
        //    }
        //    //2����ȡ��ض���ID���ֶ�ID��DataTable;
        //    objDT = clsFldObjTabBL.GetDataTable_FldObjTab("ObjId = '" + strObjId + "'");
        //    //3���Ըñ����ѭ�������ֶ���Ϣ���뵽һ��ArrayList
        //    foreach (DataRow objRow in objDT.Rows)
        //    {
        //        strFldId = objRow["FldId"].ToString();
        //        objArr.Add(strFldId);
        //    }
        //    //4���ڲ�������У�Ҫע���ֶ�ID���ظ������ܲ����ظ�
        //    this.Add_ObjectFldtoPrjTabFld(objArr);
        //    BindGv_PrjTabFld();
        //    Response.Write("<script>alert('����ض������ֶ���Ϣ�ɹ�����')</script>");

        //}

        protected void btnSetFldProperty_Click(object sender, System.EventArgs e)
        {
            JumpOtherPages("FieldTab_U");
        }

        protected void lbDispTabFld_Click(object sender, System.EventArgs e)
        {
            DispPrjTabFldList();
        }

        protected void btnExportExcel_Click(object sender, System.EventArgs e)
        {
            //	1����Ͻ�����������
            string strWhereCond = CombinePrjTabFldCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond + " order by SequenceNumber");
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(TabId);
            string strFileName = objPrjTabEN.TabCnName + "(" + objPrjTabEN.TabName + ")�ֶ���Ϣ����.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("TabName"); arrCnName.Add("����");
            arrColName.Add("FldName"); arrCnName.Add("�ֶ���");
            arrColName.Add("Caption"); arrCnName.Add("����");
            arrColName.Add("DataTypeName"); arrCnName.Add("����");
            arrColName.Add("FldLength"); arrCnName.Add("�ֶγ���");
            arrColName.Add("IsTabNullable"); arrCnName.Add("�Ƿ�ɿ�");
            arrColName.Add("MinValue"); arrCnName.Add("��Сֵ");
            arrColName.Add("MaxValue"); arrCnName.Add("���ֵ");
            arrColName.Add("DefaultValue"); arrCnName.Add("ȱʡֵ");
            arrColName.Add("IsOnlyOne"); arrCnName.Add("�Ƿ�Ψһ");
            arrColName.Add("FieldTypeName"); arrCnName.Add("�ֶ�����");

            arrColName.Add("PrimaryTypeName"); arrCnName.Add("��������");
            arrColName.Add("IsParentObj"); arrCnName.Add("�Ƿ񸸶���");
            arrColName.Add("IsTabForeignKey"); arrCnName.Add("�Ƿ�����");
            arrColName.Add("ForeignTabName"); arrCnName.Add("�������");
            arrColName.Add("Memo"); arrCnName.Add("˵��");
            strFolderName = Server.MapPath("~") + "\\TempFiles\\";
            strDownLoadFileName = strFolderName + strFileName;
            GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            DownLoadFile(strDownLoadFileName);

        }
        /// <summary>
        /// ���ܣ������ļ����ӷ����������ļ����ͻ��������
        /// </summary>
        /// <param name="strDownLoadFileName">��Ҫ���ص��ļ��������ļ���Ϊ��Ŀ¼���ļ�ȫ��</param>
        /// <returns></returns>
        private bool DownLoadFile(string strDownLoadFileName)
        {
            //			string path = "D:\\�Ŀ�����������Լ��.doc";		//WORD�ļ�����ֱ������
            ///			string path = "D:\\1000010811.JPG";	//JPG�ļ���������ʾ���һ�����
            System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName);
            Response.Clear();
            //Response.AddHeader("Content-Disposition", "inline; filename=" + HttpUtility.UrlEncode(file.Name)); 
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name));
            Response.AddHeader("Content-Length", file.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(file.FullName);
            Response.End();
            return true;
        }

        protected void lbMoveRecTo_Click(object sender, System.EventArgs e)
        {
            long lngMid;
            int intNewSeqNum = 0;	//׼���Ƶ��������
            List<string> arrList = new List<string>();
            int intSeqNum;
            lblMsg2.Text = "";
            
            //��ȡ��ǰ��¼�����
            string strmId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTabFld);
            if (strmId == null || strmId.Trim().Length == 0)
            {
                lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч�ı��¼!";
                return;
            }
            lblMsgList.Text = "";
            //1����ʾ�ùؼ��ֵ��������û��޸ĸùؼ��ּ�¼��
            lngMid = long.Parse(strmId);
            arrList = clsGeneralTab2.funGetFldValue("PrjTabFld", "SequenceNumber", "Mid = " + lngMid.ToString());
            if (arrList == null)
            {
                lblMsg2.Text = "��Ų�����!";
                return;
            }
            intSeqNum = int.Parse(arrList[0].ToString());
            if (rblSeqNum.SelectedIndex == 0)
            {
                intNewSeqNum = 1;
            }
            else if (rblSeqNum.SelectedIndex == 1)
            {
                intNewSeqNum = -1;
            }
            else if (rblSeqNum.SelectedIndex == 2)
            {
                if (txtRecSeqNum.Text == "")
                {
                    lblMsg2.Text = "�������µ����!";
                    return;
                }
                intNewSeqNum = int.Parse(txtRecSeqNum.Text);
            }
            string strFileFolder = Server.MapPath("~");
            bool bolIsSuccess = (new clsPrjTabFldBLEx().MoveRecSeqTo(TabId, intSeqNum, intNewSeqNum));
            if (bolIsSuccess == true)
            {
                BindGv_PrjTabFld();
                clsCommForWebForm.SetCheckedItemForGv(gvPrjTabFld, 0, strmId);
            }

        }

        protected void lbDispTabFld2_Click(object sender, System.EventArgs e)
        {
            DispPrjTabFldList();
        }

        private string strSortPrjTabFldBy
        {
            get
            {
                string sSortPrjTabFldBy;
                sSortPrjTabFldBy = (string)ViewState["SortPrjTabFldBy"];
                if (sSortPrjTabFldBy == null)
                {
                    sSortPrjTabFldBy = "";
                }
                return sSortPrjTabFldBy;
            }
            set
            {
                string sSortPrjTabFldBy = value;
                ViewState.Add("SortPrjTabFldBy", sSortPrjTabFldBy);
            }
        }
        private string strSortObjFldTabBy
        {
            get
            {
                string sSortBy;
                sSortBy = (string)ViewState["SortObjFldTabBy"];
                if (sSortBy == null)
                {
                    sSortBy = "";
                }
                return sSortBy;
            }
            set
            {
                string sSortBy = value;
                ViewState.Add("SortObjFldTabBy", sSortBy);
            }
        }
        private void DispEditPrjTabFld()
        {
            tabEditPrjTabFld.Visible = true;
            tabPrjTabFld.Visible = false;
            this.tabFieldTab.Visible = false;

        }
        private void DispFieldTab()
        {
            this.tabFieldTab.Visible = true;
            tabEditPrjTabFld.Visible = false;
            tabPrjTabFld.Visible = false;

        }

        private void DispPrjTabFldList()
        {
            tabPrjTabFld.Visible = true;
            tabEditPrjTabFld.Visible = false;
            tabFieldTab.Visible = false;
        }

        //protected void lbSynchWithTab_Click(object sender, System.EventArgs e)
        //{
        //    //�������裺
        //    //1����ȡ��ǰ��ID����ض���ID��
        //    //2����ȡ��ض���ID���ֶ�ID��DataTable;
        //    //3���Ըñ����ѭ�������ֶ���Ϣ���뵽һ��ArrayList
        //    //4���ڲ�������У�Ҫע���ֶ�ID���ظ������ܲ����ظ�
        //    //			string strWhereCond;
        //    string strObjId;
        //    //1����ȡ��ǰ��ID����ض���ID��

        //    strObjId = clsPrjTabBL.GetObjByTabId(TabId).ObjId;
        //    if (strObjId == null || strObjId.Length == 0)
        //    {
        //        return;
        //    }
        //    try
        //    {
        //        if (clsPrjObjectsBLEx.SynchWithTab(strObjId, clsCommonSession.UserId, clsPubVar.CurrSelPrjId) == true)
        //        {
        //            Response.Write("<script>alert('����ض������ֶ���Ϣ�ɹ�����')</script>");
        //        }
        //        else
        //        {
        //            Response.Write("<script>alert('�ö���������ر�ͬ��������������ԣ����߸ö���û����ص��ֶΣ���')</script>");
        //        }
        //        BindGv_PrjTabFld();
        //    }
        //    catch (Exception objException)
        //    {
        //        clsCommonSession.seErrMessage = "ͬ�������ֶ�����ֶβ��ɹ�!\r\n" + objException.Message;
        //        clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
        //        clsPubFun4Web.AccessError(this, conCurrPageName);
        //    }

        //}

        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            clsPrjTabFldBLEx.ReOrder(TabId);
            BindGv_PrjTabFld();
        }

        protected void lbCheckConsistency_Click(object sender, EventArgs e)
        {
            BackPageLinkStrFromUpdField = Page.Request.Url.AbsolutePath;

            Response.Redirect("wfmPrjTab_CheckConsistency.aspx");
        }
        protected void lbGeneLogicCode_Click(object sender, EventArgs e)
        {
            new clsCommonSession().GenCode4TabType = "Logic";
            string c1 = @"<script language='javascript'>window.open('../GenCode/wfmGenCode4TabV6.aspx','aa'); </script>";
            Response.Write(c1);

        }
        protected void lbGeneLogicCodeEx_Click(object sender, EventArgs e)
        {
            new clsCommonSession().GenCode4TabType = "LogicEx";
            string c1 = @"<script language='javascript'>window.open('../GenCode/wfmGenCode4TabV6.aspx','aa'); </script>";
            Response.Write(c1);

        }
        protected void gvPrjTabFld_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int[] iNum = new int[20];
                iNum[0] = 6;
                iNum[1] = 7;
                iNum[2] = 10;
                iNum[3] = 11;
                iNum[4] = 12;
                for (int i = 0; i < 5; i++)
                {
                    if (e.Row.Cells[iNum[i]].Text == "True")
                    {
                        e.Row.Cells[iNum[i]].Text = "��";
                        e.Row.Cells[iNum[i]].ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        e.Row.Cells[iNum[i]].Text = "��";
                        e.Row.Cells[iNum[i]].ForeColor = System.Drawing.Color.Red;
                    };
                }

            }
        }
}

    public partial class wfmPrjTabFld_QUDI : CommWebPageBase
    {

        ///��������ҳ����غ���
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvPrjTabFld.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvPrjTabFld.PageCount)
                {
                    this.gvPrjTabFld.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_PrjTabFld();
            }
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvPrjTabFld_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.gvPrjTabFld.PageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindGv_PrjTabFld();
        }
        protected void gvPrjTabFld_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvPrjTabFld.PageIndex = e.NewPageIndex;
                this.BindGv_PrjTabFld();
            }
        }
        ///����GridView��������¼�����
        protected void gvPrjTabFld_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string strCommandName = e.CommandName;
            switch (strCommandName)
            {
                case "lbSelAll":
                    System.Web.UI.WebControls.LinkButton lbSelAll;
                    lbSelAll = (LinkButton)e.CommandSource;
                    if (lbSelAll.CommandName != "lbSelAll")
                    {
                        return;
                    }
                    if (lbSelAll.Text == "ȫѡ")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvPrjTabFld, true);
                        lbSelAll.Text = "��ѡ";
                    }
                    else if (lbSelAll.Text == "��ѡ")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvPrjTabFld, false);
                        lbSelAll.Text = "ȫѡ";
                    }
                    break;
            }
        }
        ///ɾ����¼���̴���for C#
        protected void gvPrjTabFld_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                System.Web.UI.WebControls.LinkButton myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Row.FindControl("lbDelete");
                if (myDeleteButton != null)
                {
                    myDeleteButton.Attributes.Add("onclick", "return confirm('�����Ҫɾ���� " + (e.Row.RowIndex + 1).ToString() + " ����');");
                }
            }
            int intIndex;
            if (strSortPrjTabFldBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.gvPrjTabFld.Columns.Count; i++)
                {
                    strSortEx = this.gvPrjTabFld.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortPrjTabFldBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortPrjTabFldBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Row.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
                }
            }
        }

        ///
        protected void gvPrjTabFld_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strmId = gvPrjTabFld.DataKeys[e.RowIndex].Value.ToString();
            long lngmId = long.Parse(strmId);
            DeletePrjTabFldRecord(lngmId);
        }
        ///
        protected void gvPrjTabFld_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strmId = gvPrjTabFld.DataKeys[e.RowIndex].Value.ToString();
            long lngmId = long.Parse(strmId);
            UpdatePrjTabFldRecord(lngmId);
        }
        ///���ɰ�GridView�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��GridView�С�
        /// </summary>
        protected void BindGv_PrjTabFld()
        {
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	4������GridView������Դ(DataSource)��
            //	5����GridView������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //	1����Ͻ�����������
            string strWhereCond = CombinePrjTabFldCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "��ȡ���ݱ�(DataTable)���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4������GRIDView������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortPrjTabFldBy;     ///ע����һ�д����п�����Ҫע�͵���Ŀǰ���н����ڵ����Ĳ�ѯ������������
            ///����GridView��ÿҳ�ļ�¼��
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvPrjTabFld.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvPrjTabFld.PageSize = 10;
            }
            this.gvPrjTabFld.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.gvPrjTabFld.DataBind();

            ///����ר������BindGv�е���ҳ��ش���
            GridViewRow pagerRow = gvPrjTabFld.BottomPagerRow;
            if (pagerRow == null)
            {
                return;
            }
            Label lblRecCount = (Label)pagerRow.FindControl("lblRecCount");
            Label lblAllPages = (Label)pagerRow.FindControl("lblAllPages");
            Label lblCurrentPage = (Label)pagerRow.FindControl("lblCurrentPage");
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            Button btnNextPage = (Button)pagerRow.FindControl("btnNextPage");
            Button btnPrevPage = (Button)pagerRow.FindControl("btnPrevPage");
            Button tabJumpPage = (Button)pagerRow.FindControl("tabJumpPage");
            DropDownList ddlPagerRecCount = (DropDownList)pagerRow.FindControl("ddlPagerRecCount");
            if (lblRecCount != null)
            {
                //��ǰ��¼��
                lblRecCount.Text = objDT.Rows.Count.ToString();
                //��ǰҳ��
                lblAllPages.Text = this.gvPrjTabFld.PageCount.ToString();
                //��ǰҳ����
                lblCurrentPage.Text = (this.gvPrjTabFld.PageIndex + 1).ToString();
                //��ǰ����������ҳ����
                txtJump2Page.Text = (this.gvPrjTabFld.PageIndex + 1).ToString();
                //�����ǰҳ����Ϊ0����<ǰһҳ>��ť��Ч
                if (this.gvPrjTabFld.PageIndex == 0)
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage,  false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnPrevPage, true);
                }
                //�����ǰҳ������Ϊ���һҳ����<ǰһҳ>��ť��Ч
                if (this.gvPrjTabFld.PageIndex == this.gvPrjTabFld.PageCount - 1)
                {
                     clsPubFun.SetButtonEnabled(btnNextPage, false);
                }
                else
                {
                    clsPubFun.SetButtonEnabled(btnNextPage, true);
                }
                //���÷�ҳ����ÿҳ��¼�����������ֵ
                if (string.IsNullOrEmpty(PageSize) == false)
                {
                    ddlPagerRecCount.Text = PageSize;
                }
                else
                {
                    PageSize = "10";
                    ddlPagerRecCount.Text = PageSize;
                }
            }
            gvPrjTabFld.BottomPagerRow.Visible = true;
        }

        ///ɾ����¼���̴���for C#
        protected void DeletePrjTabFldRecord(long lngmId)
        {
            try
            {
                clsPrjTabFldBLEx.DelRecordEx(lngmId);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_PrjTabFld();
        }
        ///�����޸ļ�¼׼�����̴��� for C#
        protected void UpdatePrjTabFldRecord(long lngmId)
        {
            //�������裺���ܹ�2����
            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�

            //1����ʾ�ùؼ��ּ�¼�������ڽ����ϣ�
            ShowData(lngmId);
            //2�������ʾ��Ϣ������,ͬʱʹ<ȷ���޸�>��ť���ã�
            clsPubFun.SetButtonEnabled(btnOKEdit, true);
            btnOKEdit.Text = "ȷ���޸�";
            lbDispTabFld2.Text = "ȡ���޸�";
            lblMsgEdit.Text = "";
            //DispEditPrjTabFldRegion();
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdatePrjTabFldRecordSave(clsPrjTabFldEN objPrjTabFld)
        {
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            ///3.2�����Ψһ��
            //4��������ʵ�������ݴ��������ݿ���
            //5�����޸ĺ��������ʾ��DATAGRID��
            string strMsg;	//ר�����ڴ�����Ϣ�ı���
            //string strResult = " ";	//���ڴ����ڼ����������ʱ���ֵ�ı���
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucPrjTabFld1.IsValid())
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToPrjTabFldClass(objPrjTabFld);		//�ѽ����ֵ����
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                 clsPrjTabFldBL .CheckPropertyNew(objPrjTabFld);
                //4��������ʵ�������ݴ��������ݿ���
                clsPrjTabFldBL .UpdateBySql2(objPrjTabFld);
            }
            catch (Exception objException)
            {
                strMsg = "�޸ļ�¼���ɹ�!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsgEdit.Text = strMsg;
                return false;
            }
            strMsg = "�޸ļ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "�޸ļ�¼�ɹ�!";
            //5�����޸ĺ��������ʾ��DATAGRID��
            //BindGv_PrjTabFld();
            //DispPrjTabFldListRegion();
            wucPrjTabFld1.Clear();//��տؼ��е�����
            //�ָ�<ȷ���޸�>���<���>
            btnOKEdit.Text = "���";
            //btnCancelPrjTabFldEdit.Text = "ȡ���༭";
            return true;
        }
        ///�޸Ĵ���׼�����̴��� for C#
        protected bool UpdatePrjTabFldRecordSaveV5(clsPrjTabFldEN objPrjTabFld)
        {
            //�������裺
            //1�����ؼ����������������Ƿ���ȷ
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            //4��������ʵ�������ݴ��������ݿ���
            //5�����޸ĺ��������ʾ��DATAGRID��
            string strMsg;	//ר�����ڴ�����Ϣ�ı���
          
            //1�����ؼ����������������Ƿ���ȷ
            if (!wucPrjTabFld1.IsValid())
            {
                lblMsgEdit.Text = "�ؼ��������������Ͳ���ȷ����!";
                return false;
            }
            //2����ֵ�ӽ���㴫���߼��������ʵ���
            PutDataToPrjTabFldClass(objPrjTabFld);		//�ѽ����ֵ����
            ///3.1����鴫��ȥ�Ķ��������Ƿ�Ϸ�
            try
            {
                clsPrjTabFldBL .CheckPropertyNew(objPrjTabFld);
                //4��������ʵ�������ݴ��������ݿ���
                clsPrjTabFldBL .UpdateBySql2(objPrjTabFld);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = "�޸ļ�¼���ɹ�!" + objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            strMsg = "�޸ļ�¼�ɹ�!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsgEdit.Text = "�޸ļ�¼�ɹ�!";
            //5�����޸ĺ��������ʾ��DATAGRID��
            BindGv_PrjTabFld();
            //DispPrjTabFldListRegion();
            wucPrjTabFld1.Clear();//��տؼ��е�����
            //�ָ�<ȷ���޸�>���<���>
            btnOKEdit.Text = "���";
            //btnCancelPrjTabFldEdit.Text = "ȡ���༭";
            return true;
        }
        ///protected clsUsersEN objUser
        ///{
        ///get
        ///{
        ///clsUsersEN pobjUser;
        ///pobjUser = (clsUsersEN)Session["objUser"];
        ///if (pobjUser==null) 
        ///{
        ///pobjUser = null;
        ///}
        ///return pobjUser;
        ///}
        ///set
        ///{
        ///clsUsersEN pobjUser = value;
        ///Session.Add("objUser", pobjUser);
        ///}
        ///}


        ///����ר������BINDgv�е���ҳ��ش���


        //���ɴ�����Ϣ��Session����
        /// <summary>
        /// ר�����ڼ�¼GridView�е�ÿҳ��¼��
        /// </summary>
        protected string PageSize
        {
            get
            {
                string strPageSize;
                strPageSize = (string)ViewState["PageSize"];
                if (strPageSize == null)
                {
                    strPageSize = "";
                }
                return strPageSize;
            }
            set
            {
                string strPageSize = value;
                ViewState.Add("PageSize", strPageSize);
            }
        }
        ///���ɵĸı�GridView��ÿҳ��¼������������غ���
        protected void ddlPagerRecCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlPagerRecCount = (DropDownList)sender;
            string strPageSize = ddlPagerRecCount.Text;
            if (clsDateTime.IsNumeric(strPageSize) == true)
            {
                int intPageSize = int.Parse(strPageSize);
                if (intPageSize >= 1)
                {
                    PageSize = intPageSize.ToString();
                    BindGv_PrjTabFld();
                }
            }
        }
        protected void gvPrjTabFld_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //�ж��Ƿ����µ������ֶ�
            intIndex = strSortPrjTabFldBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortPrjTabFldBy = e.SortExpression + " Asc";
                BindGv_PrjTabFld();
                return;
            }
            //���ԭ��������
            intIndex = strSortPrjTabFldBy.IndexOf(" Asc");
            if (intIndex == -1)		//���ԭ���������������Ϊ����
            {
                strSortPrjTabFldBy = e.SortExpression + " Asc";
            }
            else			///��������Ϊ����
            {
                strSortPrjTabFldBy = e.SortExpression + " Desc";
            }
            BindGv_PrjTabFld();
        }
        #region ����ҳ����Ϣ�Լ���ת������ҳ��

        public override void InitParentPageInfo()
        {
            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":


                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        public override void ReturnParentPage()
        {
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                    break;
                case "wfmEditTabAndObjectFields.aspx":

                    clsPubFun4Web.JumpToPrjTab_QUDI3(this, strCurrPageName);
                   
                    break;
                case "wfmTabCheckResultB_QUDI.aspx":

                            clsPubFun4Web.JumpToTabCheckResultB_QUDI(this, strCurrPageName);
                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        /// <summary>
        /// ��ת������ҳ��
        /// </summary>
        /// <param name="strPageName"></param>
        public override void JumpOtherPages(string strPageName)
        {
            string strCurrPageName = string.Format("{0}|{1}", conCurrPageName, vsParentPage);

            switch (strPageName)
            {
                case "FieldTab_U":
                    string strMid;
                    long lngMid;        //��ǰ��ѡ��¼�Ĺؼ���MId
                                        //1����ȡ��ǰ��ѡ�е��ֶ�ID��
                    strMid = clsCommForWebForm.GetFirstCheckedItemFromGv(gvPrjTabFld);
                    if (strMid.Trim().Length == 0)
                    {
                        lblMsgList.Text = "û��ѡ���¼����ѡ��һ����Ч���ֶμ�¼!";
                        return;
                    }
                    lngMid = long.Parse(strMid);
                    string strFldId = clsPrjTabFldBL.GetObjBymId(lngMid).FldId;
                    FldId = strFldId;
                    BackPageLinkStrFromUpdField = Page.Request.Url.AbsolutePath;
                    clsPubFun4Web.JumpToFieldTab_U(this, "", strFldId, strCurrPageName);
                    break;

                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("��ҳ�����ƣ�[{0}]��({1})��û�д���", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }
        #endregion ����ҳ����Ϣ

        /// <summary>
        /// ����:��ǰҳ������
        /// </summary>
        public override string conCurrPageName
        {
            get
            {
                return "wfmPrjTab_CheckConsistency.aspx";
            }
        }
    }
}