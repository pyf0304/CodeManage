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


using System.Collections.Generic;
using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;using AGC.BusinessLogicEx;

namespace AGC.Webform
{
    /// <summary>
    /// wfmPrjTabFld_QUDI ��ժҪ˵��������Q�����ѯ��U�����޸�
    /// </summary>
    public partial class wfmPrjTabFld_Disp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {

            string js1 = "";
            js1 += "<script>\r\r\n";
            js1 += "function ld(){\r\r\n";
            js1 += "for(i=0;i<document.getElementsByName('RadioName').length;i++)\r\r\n";
            js1 += "if(document.getElementsByName('RadioName')[i].value==";
            js1 += "document.getElementById('" + rd.ClientID + "').value) \r\r\n";
            js1 += "document.getElementsByName('RadioName')[i].checked=true;\r\r\n";
            js1 += "}\r\r\n";

            js1 += "window.onload=ld\r\r\n";
            js1 += "</" + "script>\r\r\n";
            //			Page.RegisterStartupScript("js",js1);
            ClientScript.RegisterStartupScript(this.GetType(), "js", js1);

            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)	///����������ǳ��α����ã������ǵ�����ť�¼�������
            {

                //1��Ϊ��������������Դ�����б�����

                clsPrjTabBLEx.BindDdl_TabIdExCache(ddlTabIdq, clsPubVar.CurrSelPrjId);

                this.ddlTabIdq.SelectedValue = this.TabId;

                clsDropDownList.BindDdl_PrimaryTypeId(ddlPrimaryTypeIdq);
                BindDdl_IsPrimary(ddlIsPrimaryq);

                //2����ʾ�������ı�������DATAGRID��
                strSortPrjTabFldBy = "SequenceNumber Asc";
                strSortObjFldTabBy = "FldName Asc";
                BindDg_PrjTabFld();
                ///��ʾ��ǰ������
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(TabId);
                lblCurrTabName.Text = "��ǰ����:" + objPrjTabEN.TabName + "(" + objPrjTabEN.TabCnName + ")";


                //3�����ñ�ؼ����ֿؼ���ReadOnly���ԣ�
                //   ʹֻ֮������Ϊ���޸Ĺ����йؼ����ǲ��ܱ��޸ĵġ�
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
        
        /// <summary>
        /// �����еĲ�ѯ�ؼ�������ϳ�һ��������
        /// </summary>
        /// <returns>������(strWhereCond)</returns>
        private string CombinePrjTabFldCondition()
        {
            //ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            //���� 1=1 and UserName = '����'
            string strWhereCond = " 1=1 ";
            //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            if (this.ddlTabIdq.SelectedValue != "" && this.ddlTabIdq.SelectedValue != "0")
            {
                strWhereCond += " and TabId='" + this.ddlTabIdq.SelectedValue + "'";
            }

            if (this.ddlIsPrimaryq.SelectedValue == "��")
            {
                strWhereCond += " and IsPrimary='1'";
            }
            else if (this.ddlIsPrimaryq.SelectedValue == "��")
            {
                strWhereCond += " and IsPrimary='0'";
            }
            if (this.ddlPrimaryTypeIdq.SelectedValue != "" && this.ddlPrimaryTypeIdq.SelectedValue != "0")
            {
                strWhereCond += " and PrimaryTypeId='" + this.ddlPrimaryTypeIdq.SelectedValue + "'";
            }
            return strWhereCond;
        }
        ///���ɰ�DATAGRID�Ĵ���
        /// <summary>
        /// �������ܣ����ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼��
        ///			 ����ʾ��DATAGRID�С�
        /// </summary>
        private void BindDg_PrjTabFld()
        {
            //�������裺(��5��)
            //	1����Ͻ�����������
            //	2��������������ȡ�ñ�����������DataTable��
            //	3���б�DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //	4������DATAGRID������Դ(DataSource)��
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            //	6�����ü�¼����״̬��
            //		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�

            //	1����Ͻ�����������
            string strWhereCond;
            strWhereCond = CombinePrjTabFldCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = clsPrjTabFldBLEx.GetPrjTabFldT1(strWhereCond);
            //	3�����DATAGRID�ĵ�ǰҳ���Ƿ񳬳�DATAGRID��ҳ����Χ
            //		3.1 ���ȼ���ҳ����
            //		3.2 �����ǰҳ����ҳ����Ϊ���һҳ
            int intPages = CalcPages(objDT.Rows.Count, this.dgPrjTabFld1.PageSize);
            if (intPages == 0)
            {
                this.dgPrjTabFld1.CurrentPageIndex = 0;
            }
            else if (this.dgPrjTabFld1.CurrentPageIndex > intPages - 1)
            {
                this.dgPrjTabFld1.CurrentPageIndex = intPages - 1;
            }
            //	4������DATAGRID������Դ(DataSource)��
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortPrjTabFldBy;
            this.dgPrjTabFld1.DataSource = objDV;
            //	5����DATAGRID������DataTable��������ʾ��DATAGRID��
            this.dgPrjTabFld1.DataBind();
            //	6�����ü�¼����״̬��
            this.txtRecCount.Text = objDT.Rows.Count.ToString();
        }

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
            this.dgPrjTabFld1.CurrentPageIndex = 0;
            //�ѱ��¼��������ʾ��DATAGRID��
            BindDg_PrjTabFld();
        }
        /// <summary>
        /// �������ܣ��¼��������ڸ���DATAGRID�ĵ�ǰҳ����ʱ�����ĺ�����
        ///			  ���幦����������ʾ��ҳ(������ҳ����)�����ݡ�
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void dgPrjTabFld_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //�������裺����2����
            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ

            //1�����õ�ǰҳ��ҳ�����������µ�����ҳ����������ǰҳ����
            this.dgPrjTabFld1.CurrentPageIndex = e.NewPageIndex;
            //2�����°�DATAGRID��ʹ֮���ݸ��£��仯���µ�ҳ
            BindDg_PrjTabFld();
        }

        protected void dgPrjTabFld_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                System.Web.UI.WebControls.LinkButton myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
            }
            int intIndex;
            if (strSortPrjTabFldBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//����ؼ��Ƿ�Ϊҳü��
            {
                string strSortEx;
                for (int i = 0; i < this.dgPrjTabFld1.Columns.Count; i++)
                {
                    strSortEx = this.dgPrjTabFld1.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortPrjTabFldBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0)  //��ͼ״̬��������ʽ�Ƿ�Ϊ���е��ֶΣ�
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//�������壬��"webdings"��5�������ǣ�6�������ǣ�
                        intIndex = strSortPrjTabFldBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? " 5" : " 6");//�Ƿ�Ϊ���򣬶���Ϊstring�ͣ�
                        e.Item.Cells[i].Controls.Add(lblSort);//��������ĵ�i����Ԫ��������һ�ؼ���
                        break;
                    }
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

        protected void btnDelRec_Click(object sender, System.EventArgs e)
        {
            string mid = (string)rd.Value;
            if (mid.Trim().Length == 0)
            {
                Response.Write("<script>alert('����ѡ��һ����¼��')</script>");
            }
            else
            {
                clsPrjTabFldBLEx.DelRecordEx(long.Parse(mid));
                rd.Value = "";
                BindDg_PrjTabFld();
            }
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
                iNum[2] = 10;
                iNum[3] = 11;
                for (int i = 0; i < 4; i++)
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
            Response.Redirect("wfmPrjTab_Disp.aspx");
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
            string strMid;
            long lngMid;		//��ǰ��ѡ��¼�Ĺؼ���MId
            long lngPrevMid = 0;	//��һ����ŵĹؼ���MId
            long lngNextMid = 0;	//��һ����ŵĹؼ���MId
            int intTabRecNum;		//��ǰ�����ֶεļ�¼��
            string strCurrTabId;
            List<string> arrID;
            StringBuilder strCondition = new StringBuilder();
            //1����ȡ��ǰ��ѡ�е��ֶ�ID��
            strMid = (string)rd.Value;
            if (strMid.Trim().Length == 0)
            {
                lblMsg2.Text = "û��ѡ���¼����ѡ��һ����Ч���ֶμ�¼!";
                return false;
            }
            lblMsg2.Text = "";
            //2�����ݹؼ���Mid����ȡ�ֵ����
            lngMid = long.Parse(strMid);
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
             new   clsPrjTabBL().SetFldValue("SequenceNumber", intSequenceNumber - 1, "MId = " + lngMid);
                new clsPrjTabBL().SetFldValue("SequenceNumber", intPrevSeqNum + 1, "MId = " + lngPrevMid);
            }
            else if (strDirect == "DOWN")
            {
                new clsPrjTabBL().SetFldValue("SequenceNumber", intSequenceNumber + 1, "MId = " + lngMid);
                new clsPrjTabBL().SetFldValue("SequenceNumber", intNextSeqNum - 1, "MId = " + lngNextMid);
            }
            //7��������ʾDATAGRID
            BindDg_PrjTabFld();
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
                BindDg_PrjTabFld();
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
            BindDg_PrjTabFld();
        }

        protected void btnExportExcel_Click(object sender, System.EventArgs e)
        {
            //	1����Ͻ�����������
            string strWhereCond = CombinePrjTabFldCondition();
            //	2��������������ȡ�ñ�����������DataTable��
            System.Data.DataTable objDT = clsvPrjTabFldBL.GetDataTable(strWhereCond);
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
            arrColName.Add("PrimaryTypeName"); arrCnName.Add("��������");
            arrColName.Add("FieldTypeName"); arrCnName.Add("�ֶ�����");
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
                string sSortObjFldTabBy;
                sSortObjFldTabBy = (string)ViewState["SortObjFldTabBy"];
                if (sSortObjFldTabBy == null)
                {
                    sSortObjFldTabBy = "";
                }
                return sSortObjFldTabBy;
            }
            set
            {
                string sSortObjFldTabBy = value;
                ViewState.Add("SortObjFldTabBy", sSortObjFldTabBy);
            }
        }

    }
}