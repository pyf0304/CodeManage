
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
using com.taishsoft.commdb;
using CommFunc4WebForm;


using System.Collections.Generic;
using AGC.BusinessLogic;using AGC.FunClass;

using AGC.BusinessLogicEx;
using AGC.Entity;


using com.taishsoft.common;


namespace AGC.Webform
{
	/// <summary>
	/// wfmStrutsAction_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmStrutsAction_QUDI : CommWebPageBase
    {
				
		//生成有关的变量定义代码
		private const string ViewId4Potence="00260203";		//界面编号


		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
			{

				//生成权限有关判断权限的代码
				//根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
				switch (strPotenceLevel)
				{
					case "0":
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
					case "1":
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
					case "2":
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
					case "3":
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
					case "4":
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
					case "9":
						break;
					default:
						clsPubFun4Web.AccessError(this, conCurrPageName);
						break;
				}
				lblViewGroupName.Text =  clsViewGroupBL.GetObjByViewGroupId(ViewGroupId).ViewGroupName;
				//1、为下拉框设置数据源，绑定列表数据
				strSortStrutsActionBy = "ActionId Asc";
				//2、显示无条件的表内容在DATAGRID中
				BindDg_StrutsAction();
				//3、设置表控件中字控件的ReadOnly属性，
				//   使之只读，因为在修改功能中关键字是不能被修改的。
				wucStrutsAction1.SetKeyReadOnly(true);
			}
		}

		//生成权限等级的属性
		private string  strPotenceLevel
		{
			get
			{
				string sPotenceLevel;
				sPotenceLevel = (string)ViewState["PotenceLevel"];
				if (sPotenceLevel==null) 
				{
					//					sPotenceLevel=new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
					sPotenceLevel = "9";
					ViewState.Add("PotenceLevel", sPotenceLevel);
				}
				return sPotenceLevel;
			}
		}


		
		private string UserId
		{
			get
			{
				string strUserId;
				strUserId = (string)Session["UserId"];
				if (strUserId==null) 
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

		private string ViewGroupId
		{
			get
			{
				string strViewGroupId;
				strViewGroupId = (string)Session["ViewGroupId"];
				if (strViewGroupId==null) 
				{
					strViewGroupId = "";
				}
				return strViewGroupId;
			}
			set
			{
				string strViewGroupId = value;
				Session.Add("ViewGroupId", strViewGroupId);
			}
		}

		private string ActionId
		{
			get
			{
				string strActionId;
				strActionId = (string)Session["ActionId"];
				if (strActionId==null) 
				{
					strActionId = "";
				}
				return strActionId;
			}
			set
			{
				string strActionId = value;
				Session.Add("ActionId", strActionId);
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
		///private clsUsersEN objUserBak
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


		

		
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineStrutsActionCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
			string strWhereCond=" 1=1 ";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtActionName_q.Text.Trim()!="")
			{
				strWhereCond += " And StrutsAction.ActionName like '%" + this.txtActionName_q.Text.Trim()+"%'";
			}
			if (this.txtActionPath_q.Text.Trim()!="")
			{
				strWhereCond += " And StrutsAction.ActionPath like '%" + this.txtActionPath_q.Text.Trim()+"%'";
			}
			if (this.txtActionType_q.Text.Trim()!="")
			{
				strWhereCond += " And StrutsAction.ActionType like '%" + this.txtActionType_q.Text.Trim()+"%'";
			}

			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_StrutsAction()
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
			string strWhereCond = CombineStrutsActionCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsStrutsActionBL.GetDataTable(strWhereCond);
			//	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgStrutsAction.PageSize);
			if (intPages==0) 
			{
				this.dgStrutsAction.CurrentPageIndex = 0;
			}
			else if (this.dgStrutsAction.CurrentPageIndex > intPages - 1) 
			{
				this.dgStrutsAction.CurrentPageIndex = intPages - 1;
			}
			//	4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortStrutsActionBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgStrutsAction.DataSource=objDV;
			//	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgStrutsAction.DataBind();

			
			//当前记录数
			this.lblStrutsActionRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblStrutsActionAllPages.Text = this.dgStrutsAction.PageCount.ToString(); 
			//当前页序数
			this.lblStrutsActionCurrentPage.Text=(this.dgStrutsAction.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtStrutsActionJump2Page.Text=(this.dgStrutsAction.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgStrutsAction.CurrentPageIndex==0) 
			{
				btnStrutsActionPrevPage.Enabled=false; 
			}
			else 
			{ 
				btnStrutsActionPrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgStrutsAction.CurrentPageIndex==this.dgStrutsAction.PageCount-1) 
			{ 
				btnStrutsActionNextPage.Enabled=false; 
			} 
			else 
			{ 
				btnStrutsActionNextPage.Enabled=true; 
			} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			if(objDT.Rows.Count>0) 
			{ 
				this.tabStrutsActionJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabStrutsActionJumpPage.Visible = false; 
			}
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

		/// <summary>
		/// 函数功能：事件函数，当单击<查询>按钮时所发生的事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnQuery_Click(object sender, System.EventArgs e)
		{
			//把DATAGRID的当前页索引设置为0，即第1页。
			//当单击查询时，首先显示的是表记录内容的第一部分内容。
			this.dgStrutsAction.CurrentPageIndex=0;
			//把表记录的内容显示在DATAGRID中
			BindDg_StrutsAction();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgStrutsAction_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgStrutsAction.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_StrutsAction();
		}
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="strActionId">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData(string strActionId)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (strActionId == "") return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsStrutsActionBL.IsExist(strActionId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + strActionId + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsStrutsActionEN objStrutsAction = new clsStrutsActionEN(strActionId);
            //4、获取类对象的所有属性；
            clsStrutsActionBL .GetStrutsAction(ref objStrutsAction);
			Session.Add("objStrutsAction", objStrutsAction);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromStrutsActionClass(objStrutsAction);
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjStrutsAction">表实体类对象</param>
		private void GetDataFromStrutsActionClass(clsStrutsActionEN pobjStrutsAction)
		{
			wucStrutsAction1.ActionId = pobjStrutsAction.ActionId;
			wucStrutsAction1.ActionName = pobjStrutsAction.ActionName;
			wucStrutsAction1.ActionParameter = pobjStrutsAction.ActionParameter;
			wucStrutsAction1.ActionPath = pobjStrutsAction.ActionPath;
			wucStrutsAction1.ActionScope = pobjStrutsAction.ActionScope;
			wucStrutsAction1.ActionType = pobjStrutsAction.ActionType;
			wucStrutsAction1.Memo = pobjStrutsAction.Memo;
		}
		/// <summary>
		/// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
		///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnOKUpd_Click(object sender, System.EventArgs e)
		{
			string strMsg;	//专门用于传递信息的变量
			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			string strCommandText;
			clsStrutsActionEN objStrutsAction;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					wucStrutsAction1.SetKeyReadOnly(false);
					btnOKUpd.Text = "确认添加";
					InitStrutsAction();
                    //					wucStrutsAction1.ActionId = clsStrutsAction.GetMaxStrId("StrutsAction","ActionId", 10, ViewGroupId);
                    break;				
				case "确认添加":
					//这是一个单表的插入的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					//操作步骤：
					//1、检查控件中输入数据类型是否正确
					//2、定义对象并初始化对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					//4、把值从界面层传到逻辑层或数据实体层
					//5、检查传进去的对象属性是否合法
					//6、把数据实体层的数据存贮到数据库中
					//7、把新添的记录内容显示在DATAGRID中
					//1、检查控件中输入数据类型是否正确
					if (!wucStrutsAction1.IsValid(ref strResult))
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、定义对象并初始化对象
					//clsStrutsActionEN objStrutsAction;	//定义对象
					objStrutsAction = new clsStrutsActionEN(wucStrutsAction1.ActionId);	//初始化新对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					if (clsStrutsActionBL.IsExist(wucStrutsAction1.ActionId))	//判断是否有相同的关键字
					{
						strMsg = "关键字字段已有相同的值";
						clsCommonJsFunc.Alert(this, strMsg);
						return;
					}
					//4、把值从界面层传到逻辑层或数据实体层
					PutDataToStrutsActionClass(objStrutsAction);		//把界面的值传到
					//5、检查传进去的对象属性是否合法
                    try
                    {
                        clsStrutsActionBL .CheckPropertyNew(objStrutsAction);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//6、把数据实体层的数据存贮到数据库中
					if (clsStrutsActionBL .AddNewRecordBySql2(objStrutsAction) == false) 
					{
						strMsg = "添加不成功!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "添加记录不成功!";
					}
					else
					{
						strMsg = "添加记录成功!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "添加记录成功!";
					}
					//7、把新添的记录内容显示在DATAGRID中
					BindDg_StrutsAction();
					wucStrutsAction1.Clear();		//清空控件中内容
					///恢复<确认添加>变成<添加>
					btnOKUpd.Text = "添加";
					break;
				case "确认修改":
					//这是一个单表的修改的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					//操作步骤：
					//1、检查控件中输入数据类型是否正确
					//2、把值从界面层传到逻辑层或数据实体层
					//3、检查传进去的对象属性是否合法
					//4、把数据实体层的数据存贮到数据库中
					//5、把修改后的内容显示在DATAGRID中
					//1、检查控件中输入数据类型是否正确
					if (!wucStrutsAction1.IsValid(ref strResult))
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、把值从界面层传到逻辑层或数据实体层
					objStrutsAction = (clsStrutsActionEN) Session["objStrutsAction"];
					PutDataToStrutsActionClass(objStrutsAction);		//把界面的值传到
					//3、检查传进去的对象属性是否合法
                    try
                    {
                        clsStrutsActionBL.CheckPropertyNew(objStrutsAction);
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }
					//4、把数据实体层的数据修改同步到数据库中
					if (clsStrutsActionBL .UpdateBySql2(objStrutsAction) == false) 
					{
						strMsg = "修改记录不成功!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "修改记录不成功!";
					}
					else
					{
						strMsg = "修改记录成功!";
						clsCommonJsFunc.Alert(this, strMsg);
						lblMsg.Text = "修改记录成功!";
					}
					//5、把修改后的内容显示在DATAGRID中
					BindDg_StrutsAction();
					wucStrutsAction1.Clear();//添空控件中的内容
					//恢复<确认修改>变成<添加>
					btnOKUpd.Text = "添加";
					break;
			}
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjStrutsAction">数据传输的目的类对象</param>
		private void PutDataToStrutsActionClass(clsStrutsActionEN pobjStrutsAction)
		{
			pobjStrutsAction.ActionId = wucStrutsAction1.ActionId;
		    pobjStrutsAction.ActionName = wucStrutsAction1.ActionName;
			pobjStrutsAction.ActionParameter = wucStrutsAction1.ActionParameter;
			pobjStrutsAction.ActionPath = wucStrutsAction1.ActionPath;
			pobjStrutsAction.ActionScope = wucStrutsAction1.ActionScope;
			pobjStrutsAction.ActionType = wucStrutsAction1.ActionType;
			pobjStrutsAction.Memo = wucStrutsAction1.Memo;
			pobjStrutsAction.UserId=(string)Session["UserId"];
            pobjStrutsAction.ViewGroupId=(string)Session["ViewGroupId"];
            pobjStrutsAction.PrjId=clsPubVar.CurrSelPrjId;
		}

		protected void dgStrutsAction_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				System.Web.UI.WebControls.LinkButton myDeleteButton;
				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
				myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Item.ItemIndex+1).ToString() + " 行吗？');");
			}
			int intIndex;
			if (strSortStrutsActionBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgStrutsAction.Columns.Count;i++)
				{
					strSortEx = this.dgStrutsAction.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortStrutsActionBy.IndexOf(strSortEx + " ");
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortStrutsActionBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?" 5":" 6");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
		}

		protected void dgStrutsAction_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strActionId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strActionId = e.Item.Cells[1].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsStrutsActionBL.DelRecord(strActionId);
						BindDg_StrutsAction();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//操作步骤：（总共2步）
						//1、显示该关键字记录的内容在界面上；
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；

						//1、显示该关键字记录的内容在界面上；
						ShowData(strActionId);
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；
						clsPubFun.SetButtonEnabled(btnOKUpd, true);
						wucStrutsAction1.SetKeyReadOnly(true);
						btnOKUpd.Text = "确认修改";
						lblMsg.Text = "";
						break;

					default:
						// Do nothing.
						break;
				}
			}
			if (e.Item.ItemType == ListItemType.Header)
			{
				System.Web.UI.WebControls.LinkButton lbSelAll;
				lbSelAll = (LinkButton)e.CommandSource;
				if (lbSelAll.CommandName != "lbSelAll")
				{
					return ;
				}
				if (lbSelAll.Text == "全选")
				{
					Set_DataGridAllChecked(dgStrutsAction, true);
					lbSelAll.Text = "不选";
				}
				else if (lbSelAll.Text == "不选")
				{
					Set_DataGridAllChecked(dgStrutsAction, false);
					lbSelAll.Text = "全选";
				}
			}
		}
		private void Set_DataGridAllChecked(DataGrid objDg, bool IsSelected)
		{
			if(objDg.Items.Count==0 )
			{
				return;
			}
			else
			{
				foreach(DataGridItem di in objDg.Items)
				{
					CheckBox cb=(CheckBox)di.FindControl("chkCheckRec");
					if(cb!=null )
					{
						cb.Checked=IsSelected;
					}
				}
			}
		}
		
		//当前记录数
		protected void btnAddNewRec4Dg_Click(object sender, System.EventArgs e)
		{
			wucStrutsAction1.SetKeyReadOnly(false);
			btnOKUpd.Text = "确认添加";
			InitStrutsAction();
		}
		private void InitStrutsAction()
		{
			wucStrutsAction1.ActionId = clsStrutsActionBL.GetMaxStrIdByPrefix_S(ViewGroupId);
            clsViewGroupENEx objViewGroupEN = (clsViewGroupENEx)clsViewGroupBL.GetObjByViewGroupId(ViewGroupId);
            clsViewGroupBLEx.initViewRelaTabFldSet(objViewGroupEN);
			string strTabName_FstLcase = objViewGroupEN.objINPrjTab.TabName;
			//CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
			strTabName_FstLcase = clsString.FstLcaseS(strTabName_FstLcase);
			wucStrutsAction1.ActionName = objViewGroupEN.PrjDomain + "." + strTabName_FstLcase + "Form";
			wucStrutsAction1.ActionParameter = "method";
			wucStrutsAction1.ActionPath = objViewGroupEN.ActionPath + "/" + strTabName_FstLcase + "Action";
			wucStrutsAction1.ActionScope = "request";
			wucStrutsAction1.ActionType = objViewGroupEN.PrjDomain + "." + strTabName_FstLcase + "Action";

		}
		
		//当前记录数
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1、组合界面条件串；
			string strWhereCond = CombineStrutsActionCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsStrutsActionBL.GetDataTable_StrutsAction(strWhereCond);
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "StrutsAction信息导出.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("ActionId"); arrCnName.Add("ActionId");
			arrColName.Add("ActionName"); arrCnName.Add("Action名称");
			arrColName.Add("ActionParameter"); arrCnName.Add("Action参数");
			arrColName.Add("ActionPath"); arrCnName.Add("Action路径");
			arrColName.Add("ActionScope"); arrCnName.Add("Action范围");
			arrColName.Add("ActionType"); arrCnName.Add("Action类型");
			arrColName.Add("ViewGroupId"); arrCnName.Add("界面组ID");
			strFolderName = Server.MapPath("~") +  "\\TempFiles\\";
			strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }

            //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            DownLoadFile(strDownLoadFileName);
		}
		/// <summary>
		/// 功能：下载文件。从服务器下载文件到客户端浏览器
		/// </summary>
		/// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
		/// <returns></returns>
		private bool DownLoadFile(string strDownLoadFileName)
		{
			System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName); 
			Response.Clear(); 
			Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name)); 
			Response.AddHeader("Content-Length", file.Length.ToString()); 
			Response.ContentType = "application/octet-stream"; 
			Response.WriteFile(file.FullName); 
			Response.End();
			return true;
		}

		
		//当前记录数
		protected void btnDelete4Dg_Click(object sender, System.EventArgs e)
		{
            List<string> arrActionId = clsCommForWebForm.GetAllCheckedItemFromDg2(dgStrutsAction, "chkCheckRec");
			if (arrActionId == null || arrActionId.Count == 0) 
			{
				lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg.Text = "";
			clsStrutsActionBL.DelStrutsActions(arrActionId);
			BindDg_StrutsAction();
		}

		
		//当前记录数
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strActionId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgStrutsAction);
			if (strActionId == null || strActionId.Trim().Length == 0) 
			{
				lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg.Text = "";
			//1、显示该关键字记录的内容在界面上；
			ShowData(strActionId);
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			wucStrutsAction1.SetKeyReadOnly(true);
			btnOKUpd.Text = "确认修改";	
		}

		protected void btnEditForward_Click(object sender, System.EventArgs e)
		{
			string strActionId =clsCommForWebForm.GetFirstCheckedItemFromDg(dgStrutsAction);
			if (strActionId == null || strActionId.Trim().Length == 0) 
			{
				lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg.Text = "";
		    ActionId = strActionId;
			Response.Redirect("wfmActionForward_QUDI.aspx");
		}


		
		public System.Data.DataTable GetViewGroupId()
		{
			//获取某学院所有专业信息
			string strSQL = "select ViewGroupId, ViewGroupName from ViewGroup ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_ViewGroupId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetViewGroupId();
			objDDL.DataValueField="ViewGroupId";
			objDDL.DataTextField="ViewGroupName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		public System.Data.DataTable GetUserId()
		{
			//获取某学院所有专业信息
			string strSQL = "select UserId, UserName from Users ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetUserId();
			objDDL.DataValueField="UserId";
			objDDL.DataTextField="UserName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		protected void dgStrutsAction_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			//判断是否是新的排序字段
			intIndex = strSortStrutsActionBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortStrutsActionBy = e.SortExpression + " Asc";
				BindDg_StrutsAction();
				return ;
			}
			//检查原来是升序
			intIndex = strSortStrutsActionBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortStrutsActionBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortStrutsActionBy = e.SortExpression + " Desc";
			}
			BindDg_StrutsAction();
		}

		private string strSortStrutsActionBy
		{
			get
			{
				string sSortStrutsActionBy;
				sSortStrutsActionBy = (string)ViewState["SortStrutsActionBy"];
				if (sSortStrutsActionBy==null) 
				{
					sSortStrutsActionBy = "";
				}
				return sSortStrutsActionBy;
			}
			set
			{
				string sSortStrutsActionBy = value;
				ViewState.Add("SortStrutsActionBy", sSortStrutsActionBy);
			}
		}

		//生成父对象的SESSION相关属性函数
		protected void btnStrutsActionPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgStrutsAction.CurrentPageIndex -=1; 
			this.BindDg_StrutsAction(); 
		}

		protected void btnStrutsActionNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgStrutsAction.CurrentPageIndex +=1; 
			this.BindDg_StrutsAction(); 
		}

		protected void btnStrutsActionJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtStrutsActionJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtStrutsActionJump2Page.Text)>0 && 
				int.Parse(this.txtStrutsActionJump2Page.Text)-1<this.dgStrutsAction.PageCount) 
			{ 
				this.dgStrutsAction.CurrentPageIndex=int.Parse(this.txtStrutsActionJump2Page.Text)-1; 
			} 
			this.BindDg_StrutsAction();
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
                    clsCommonJsFunc.Alert(this, string.Format("父页面名称：[{0}]在({1})中没有处理！", qsParentPage, clsStackTrace.GetCurrClassFunction()));
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