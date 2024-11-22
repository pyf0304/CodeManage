///生成查询，修改，删除，添加记录的控制层代码
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
using System.Text;
using com.taishsoft.commdb;
using CommFunc4WebForm;


using AGC.Entity;

using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;

using com.taishsoft.common;

namespace AGC.Webform
{
	/// <summary>
	/// wfmFieldTab_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmFieldTab_Archive : CommWebPageBase
    {
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
			{
                //1、为下拉框设置数据源，绑定列表数据

                clsProjectsBLEx.BindDdl_PrjIdCacheEx(ddlPrjIdq);
                clsDataTypeAbbrBLEx.BindDdl_DataTypeIdCache(ddlFldTypeq);
				BindDdl_IsNull(ddlIsNullq);
				BindDdl_IsPrimaryKey(ddlIsPrimaryKeyq);
                //clsvPrjObjects4DdlBLEx.BindDdl_ObjId(ddlObjIdq, clsPubVar.CurrSelPrjId);

                ddlPrjIdq.SelectedValue = clsPubVar.CurrSelPrjId;
				clsFldStateBL.BindDdl_FldStateIdCache(ddlFldStateIdq);

				ddlFldStateIdq.SelectedValue = "01";

				strSortBy = "FldName Asc";
				//2、显示无条件的表内容在DATAGRID中
				BindDg_FieldTab();
				//3、设置表控件中字控件的ReadOnly属性，
				//   使之只读，因为在修改功能中关键字是不能被修改的。
			
			}
		}

       
		private clsUsersEN objUserBak
		{
			get
			{
				clsUsersEN pobjUser;
				pobjUser = (clsUsersEN)Session["objUser"];
				if (pobjUser==null) 
				{
					pobjUser = null;
                    string strErrMessage = "用户对象为空,可能不用时间超时,Session丢失,需要重新登录!";
                    Session.Add("ErrMessage", strErrMessage);
                    clsPubFun4Web.AccessError(this, conCurrPageName);
                }
				return pobjUser;
			}
			set
			{
				clsUsersEN pobjUser = value;
				Session.Add("objUser", pobjUser);
			}
		}
        //private string PrjId
        //{
        //    get
        //    {
        //        string strPrjId;
        //        strPrjId = (string)Session["P1rjId"];
        //        if (strPrjId==null) 
        //        {
        //            strPrjId = "";
        //            clsCommForWebForm.CheckPrjId(strPrjId, this);
        //        }
        //        return strPrjId;
        //    }
        //    set
        //    {
        //        string strPrjId = value;
        //        Session.Add("PrjId", strPrjId);
        //    }
        //}

		
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 and UserName = '张三'
			string strWhereCond=" 1=1 ";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.ddlPrjIdq.SelectedValue!="" && this.ddlPrjIdq.SelectedValue!="0")
			{
				strWhereCond += " and PrjId='" + this.ddlPrjIdq.SelectedValue+"'";
			}
			if (this.txtFldNameq.Text.Trim()!="")
			{
				strWhereCond += " and FldName like '" + this.txtFldNameq.Text.Trim()+"%'";
			}
			if (this.ddlFldTypeq.SelectedValue!="" && this.ddlFldTypeq.SelectedValue!="0")
			{
                strWhereCond += " and DataTypeId='" + this.ddlFldTypeq.SelectedValue + "'";
			}
			if (this.ddlIsNullq.SelectedValue=="是")
			{
				strWhereCond += " and IsNull='1'";
			}
			else if (this.ddlIsNullq.SelectedValue=="否")
			{
				strWhereCond += " and IsNull='0'";
			}
			if (this.ddlIsPrimaryKeyq.SelectedValue=="是")
			{
				strWhereCond += " and IsPrimaryKey='1'" ;
			}
			else if (this.ddlIsPrimaryKeyq.SelectedValue=="否")
			{
					strWhereCond += " and IsPrimaryKey='0'" ;
			}
			if (this.txtAppliedScopeq.Text.Trim()!="")
			{
				strWhereCond += " and AppliedScope='" + this.txtAppliedScopeq.Text.Trim()+"'";
			}
			if (this.ddlFldStateIdq.SelectedValue!="" && this.ddlFldStateIdq.SelectedValue!="0")
			{
				strWhereCond += " And FldStateId='" + this.ddlFldStateIdq.SelectedValue+"'";
			}

			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_FieldTab()
		{
			//操作步骤：(共5步)
			//	1、组合界面条件串；
			//	2、根据条件串获取该表满足条件的DataTable；
			//	3、判别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//	4、设置DATAGRID的数据源(DataSource)；
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			//	6、设置记录数的状态，
			//		在本界面中是把状态显示在控件txtRecCount中。

			//	1、组合界面条件串；
			string strWhereCond = CombineCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsvFieldTabBL.GetDataTable(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgFieldTab.PageSize);
			if (intPages==0) 
			{
				this.dgFieldTab.CurrentPageIndex = 0;
			}
			else if (this.dgFieldTab.CurrentPageIndex > intPages - 1) 
			{
				this.dgFieldTab.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortBy;
			this.dgFieldTab.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgFieldTab.DataBind();
			//	6、设置记录数的状态，
			this.txtRecCount.Text= objDT.Rows.Count.ToString();
		}

		/// <summary>
		/// 功能：计算DataGrid的页数
		/// </summary>
		/// <param name="intRecCount">总共的记录数</param>
		/// <param name="intPageSize">每页的记录数</param>
		/// <returns>计算出来的页数</returns>
		private int CalcPages(int intRecCount, int intPageSize)
		{
			int intPages;
			intPages = intRecCount / intPageSize;
			if (intRecCount % intPageSize !=0) intPages ++;
			return intPages;
		}
		private string strSortBy
		{
			get
			{
				string sSortBy;
				sSortBy = (string)ViewState["SortBy"];
				if (sSortBy==null) 
				{
					sSortBy = "";
				}
				return sSortBy;
			}
			set
			{
				string sSortBy = value;
				ViewState.Add("SortBy", sSortBy);
			}
		}                   

		/// <summary>
		/// 函数功能：事件函数，当单击<查询>按钮时所发生的事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnQuery_Click(object sender, System.EventArgs e)
		{
			//把DATAGRID的当前页索引设置为0，即第1页。
			//当单击查询时，首先显示的是表记录内容的第一部分内容。
			this.dgFieldTab.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_FieldTab();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgFieldTab_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgFieldTab.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_FieldTab();
		}

		protected void dgFieldTab_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
//				System.Web.UI.WebControls.LinkButton myDeleteButton;
//				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
//			
//				myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Item.ItemIndex+1).ToString() + " 行吗？');");
			}
				int intIndex;
			if (strSortBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgFieldTab.Columns.Count;i++)
				{
					strSortEx = this.dgFieldTab.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
			
		}

		
	
	
		public void BindDdl_IsNull(System.Web.UI.WebControls.DropDownList objDDL)
		{
			ListItem li=new ListItem("请选择...","0");
			objDDL.Items.Add("是");
			objDDL.Items.Add("否");
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
			//为下拉框设置内容的样例，该下拉框的列表项是直接添加的
			///objDDL.Items.Add("男");
			///objDDL.Items.Add("女");
		}
		public void BindDdl_IsPrimaryKey(System.Web.UI.WebControls.DropDownList objDDL)
		{
			ListItem li=new ListItem("请选择...","0");
			objDDL.Items.Add("是");
			objDDL.Items.Add("否");
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
			//为下拉框设置内容的样例，该下拉框的列表项是直接添加的
			///objDDL.Items.Add("男");
			///objDDL.Items.Add("女");
		}

		protected void dgFieldTab_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			System.Web.UI.WebControls.CheckBox chkIsChecked, chkIsArchive;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				int [] iNum= new int[20];
				iNum[0] = 7;
				iNum[1] = 8;
				iNum[2] = 9;
				for (int i = 0; i<3; i++)
				{
					if (e.Item.Cells[iNum[i]].Text == "True")
					{
						e.Item.Cells[iNum[i]].Text = "√";
						e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Green;
					}
					else
					{
						e.Item.Cells[iNum[i]].Text = "×";
						e.Item.Cells[iNum[i]].ForeColor = System.Drawing.Color.Red;
					};
				}
				chkIsChecked = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsChecked");
				string strIsChecked = e.Item.Cells[17].Text;
				chkIsChecked.Checked = bool.Parse(strIsChecked);

				chkIsArchive = (System.Web.UI.WebControls.CheckBox)e.Item.FindControl("chkIsArchive");
				string strIsArchive = e.Item.Cells[19].Text;
				chkIsArchive.Checked = bool.Parse(strIsArchive);

			}
		}
/// <summary>
/// 导入Excel文件的字段
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
		protected void lbImportExcelFld_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("wfmImportFldInfoFromExcel.aspx");
		}


		protected void lbImportSQLFld_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("wfmImportFldInfoFromSQL.aspx");
		
		}

		protected void dgFieldTab_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortBy = e.SortExpression + " Asc";
				BindDg_FieldTab();
				return ;
			}
			//检查原来是升序
			intIndex = strSortBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortBy = e.SortExpression + " Desc";
			}
			BindDg_FieldTab();

		}

		protected void lbSetArchive_Click(object sender, System.EventArgs e)
		{
			//操作步骤：
			//1、对DG进行循环
			//2、针对每一行中的<是否排序><是否查询>等字段的编辑结果进行存盘
			//3、在循环中初始化一个clsFieldTabEN对象，利用关键字MID
			//4、赋值；
			//5、存盘
			///
			System.Web.UI.WebControls.CheckBox chkIsChecked;
			System.Web.UI.WebControls.CheckBox chkIsArchive;
			string strFldId;
			bool bolIsChecked, bolIsArchive;
			clsFieldTabEN objFieldTabEN;
			int intDgNum, intIndex;
			DataGridItem item;
			//1、对DG进行循环
			intDgNum = dgFieldTab.Items.Count;

			for (intIndex = 0; intIndex <intDgNum; intIndex++)
			{
				item = dgFieldTab.Items[intIndex];
				strFldId = item.Cells[1].Text;
				//2、针对每一行中的<是否排序><是否查询>等字段的编辑结果进行存盘
				//3、在循环中初始化一个clsFieldTabEN对象，利用关键字MID
                objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldId);

				//4、赋值；
				
				chkIsChecked = (System.Web.UI.WebControls.CheckBox)item.FindControl("chkIsChecked");
				bolIsChecked= chkIsChecked.Checked ;

				chkIsArchive = (System.Web.UI.WebControls.CheckBox)item.FindControl("chkIsArchive");
				bolIsArchive = chkIsArchive.Checked;

				objFieldTabEN.IsChecked = bolIsChecked;
				objFieldTabEN.IsArchive = bolIsArchive;
				//5、存盘
                if (objFieldTabEN.UpdateRecordEx() == false)
				{
					return ;
				}
			}
			BindDg_FieldTab();
		}
        #region 处理父页面信息以及跳转到其他页面

        public override void InitParentPageInfo()
        {
            switch (qsParentPage)
            {
                case "wfmPrjTab_QUDI3.aspx":


                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, 
                        clsStackTrace.GetCurrClassFunction()));
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
                    
                    
                    //{
                    
                    //}
                    break;
                case "wfmTabCheckResultB_QUDI.aspx":
                    clsPubFun4Web.JumpToTabCheckResultB_QUDI(this, strCurrPageName);
                    break;
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }

        }
        /// <summary>
        /// 跳转到其他页面
        /// </summary>
        /// <param name="strPageName"></param>
        public override void JumpOtherPages(string strPageName)
        {
            switch (strPageName)
            {
                case "":
                    break;
                default:
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
                    break;
            }
        }
        #endregion 处理父页面信息

        /// <summary>
        /// 常量:当前页面名称
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