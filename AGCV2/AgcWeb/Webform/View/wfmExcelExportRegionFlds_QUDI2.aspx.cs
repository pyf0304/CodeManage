///生成查询，修改，删除，添加记录的控制层代码


using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Agc;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;

using AGC.Entity;
using AGC.FunClass;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.json;
using CommFunc4WebForm;


namespace AGC.Webform
{
    /// <summary>
    /// wfmExcelExportRegionFlds_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmExcelExportRegionFlds_QUDI2 : CommWebPageBase
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

				//1、为下拉框设置数据源，绑定列表数据
				//2、显示无条件的表内容在DATAGRID中
				strSortExcelExportRegionFldsBy = "SeqNum Asc";
                clsViewRegionEN objViewRegionEN = clsViewRegionBL.GetObjByRegionIdCache(seRegionId, clsPubVar.CurrCmPrjId);
                if (objViewRegionEN != null)
                {
                    wucExcelExportRegionFlds1.SetDdl_FldId(objViewRegionEN.TabId);
                    wucExcelExportRegionFlds1.vsTabId = objViewRegionEN.TabId;
                    wucExcelExportRegionFlds1.SetDdl_DataNodeIdByTabId(objViewRegionEN.TabId, objViewRegionEN.PrjId);

                    vsInOutTypeId = objViewRegionEN.InOutTypeId;
                    chkInUse.Checked = objViewRegionEN.InUseInViewId(clsCommonSession.ViewId, clsPubVar.CurrCmPrjId);
                    txtWidth.Text = objViewRegionEN.Width.ToString();
                    //vsViewId = objViewRegionEN.ViewId;
                }
                BindGv_vExcelExportRegionFlds();
							
				

				//3、设置表控件中字控件的ReadOnly属性，
				//   使之只读，因为在修改功能中关键字是不能被修改的。
			}
            ShowCodeTypeButton();
            try
            {
                wucExcelExportRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, 5, chkInUse.Checked);
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000119)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
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
		private string SimpleFName  //单纯的文件名，不带目录名
		{
			get
			{
				string strSimpleFName;
				strSimpleFName = (string)ViewState["SimpleFName"];
				if (strSimpleFName==null) 
				{
					strSimpleFName = "";
				}
				return strSimpleFName;
			}
			set
			{
				string strSimpleFName = value;
				ViewState.Add("SimpleFName", strSimpleFName);
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


		


		//生成错误信息的Session属性
		private string ErrMessage
		{
			get
			{
				string strErrMessage;
				strErrMessage = (string)Session["ErrMessage"];
				if (strErrMessage==null) 
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
		private string BackErrPageLinkStr
		{
			get
			{
				string strBackErrPageLinkStr;
				strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
				if (strBackErrPageLinkStr==null) 
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


		//生成返回链接串的Session属性
		private string BackViewRegionLinkStr
		{
			get
			{
				string strBackViewRegionLinkStr;
				strBackViewRegionLinkStr = (string)Session["BackViewRegionLinkStr"];
				if (strBackViewRegionLinkStr==null) 
				{
					strBackViewRegionLinkStr = "";
				}
				return strBackViewRegionLinkStr;
			}
			set
			{
				string strBackViewRegionLinkStr = value;
				Session.Add("BackViewRegionLinkStr", strBackViewRegionLinkStr);
			}
		}
        private string seRegionId
		{
			get
			{
				string lngRegionId;
				if (Session["RegionId"]==null) 
				{
					lngRegionId = "";
				}
				else
				{
					string strRegionId = Session["RegionId"].ToString();
					lngRegionId = strRegionId;
				}
				return lngRegionId;
			}
			set
			{
				string lngRegionId = value;
				Session.Add("RegionId", lngRegionId);
			}
		}	

		
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombinevExcelExportRegionFldsCondition()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 and RegionId = " + seRegionId;
            if (chkOnlyShowFldInUse.Checked == true)
            {
                strWhereCond += string.Format(" And {0}='1'", conExcelExportRegionFlds.InUse);
            }
            return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindGv_vExcelExportRegionFldsBak()
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
			string strWhereCond = CombinevExcelExportRegionFldsCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvExcelExportRegionFldsBL.GetDataTable(strWhereCond + " order by SeqNum" );

            if (vsInOutTypeId == "02")//视图
            {
                clsExcelExportRegionFldsBLEx.AddColumn_SourceTabName(ref objDT);
            }
            else
            {
                objDT.Columns.Add("SourceTabName");
            }
            
            //	3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//		3.1 首先计算页数；
			//		3.2 如果当前页大于页数就为最后一页
			//int intPages = CalcPages(objDT.Rows.Count, this.dgExcelExportRegionFlds.PageSize);
			//if (intPages==0) 
			//{
			//	this.dgExcelExportRegionFlds.CurrentPageIndex = 0;
			//}
			//else if (this.dgExcelExportRegionFlds.CurrentPageIndex > intPages - 1) 
			//{
			//	this.dgExcelExportRegionFlds.CurrentPageIndex = intPages - 1;
			//}
			////	4、设置DATAGRID的数据源(DataSource)；
			//DataView objDV = objDT.DefaultView;
			//objDV.Sort = strSortExcelExportRegionFldsBy;
			//this.dgExcelExportRegionFlds.DataSource=objDV;
			////	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			//this.dgExcelExportRegionFlds.DataBind();

			
			////当前记录数
			//this.lblExcelExportRegionFldsRecCount.Text = objDT.Rows.Count.ToString(); 
			////当前页数
			//this.lblExcelExportRegionFldsAllPages.Text = this.dgExcelExportRegionFlds.PageCount.ToString(); 
			////当前页序数
			//this.lblExcelExportRegionFldsCurrentPage.Text=(this.dgExcelExportRegionFlds.CurrentPageIndex+1).ToString();
			////当前即将跳到的页序数
			//this.txtExcelExportRegionFldsJump2Page.Text=(this.dgExcelExportRegionFlds.CurrentPageIndex+1).ToString();
			////如果当前页序数为0，则<前一页>按钮无效
			//if(this.dgExcelExportRegionFlds.CurrentPageIndex==0) 
			//{
			//	btnExcelExportRegionFldsPrevPage.Enabled=false; 
			//}
			//else 
			//{ 
			//	btnExcelExportRegionFldsPrevPage.Enabled=true; 
			//} 
			////如果当前页序数已为最后一页，则<前一页>按钮无效
			//if(this.dgExcelExportRegionFlds.CurrentPageIndex==this.dgExcelExportRegionFlds.PageCount-1) 
			//{ 
			//	btnExcelExportRegionFldsNextPage.Enabled=false; 
			//} 
			//else 
			//{ 
			//	btnExcelExportRegionFldsNextPage.Enabled=true; 
			//} 
			////7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			//if(objDT.Rows.Count>0) 
			//{ 
			//	this.tabExcelExportRegionFldsJumpPage.Visible = true; 
			//} 
			//else 
			//{ 
			//	this.tabExcelExportRegionFldsJumpPage.Visible = false; 
			//}
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
            wucvExcelExportRegionFlds4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vExcelExportRegionFlds();
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="lngmId">表记录的关键字，显示该表关键字的内容</param>
        private void ShowData(long lngmId)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；

			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (lngmId == 0) return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsExcelExportRegionFldsBL.IsExist(lngmId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + lngmId + "的不存在!";
				clsCommonJsFunc.Alert(this, ss);
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsExcelExportRegionFldsEN objExcelExportRegionFlds = new clsExcelExportRegionFldsEN(lngmId);
            //4、获取类对象的所有属性；
            clsExcelExportRegionFldsBL .GetExcelExportRegionFlds(ref objExcelExportRegionFlds);
			Session.Add("objExcelExportRegionFlds", objExcelExportRegionFlds);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromExcelExportRegionFldsClass(objExcelExportRegionFlds);
			//DispEditExcelExportRegionFldsRegion();
		}

        //private void ShowData(string strCtrlId)
        //{
        //    //操作步骤：
        //    //1、检查关键字是否为空；
        //    //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
        //    //3、用提供的关键字初始化一个类对象；
        //    //4、获取类对象的所有属性；
        //    //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

        //    //1、检查关键字是否为空；
        //    //if (lngmId == 0) return;        //如果关键字为空就返回退出
        //    //2、检查该关键字的记录是否存在，如果不存在就返回不显示；

        //    //if (clsExcelExportRegionFldsBL.IsExist(lngmId) == false)       //检查该关键字的记录是否存在
        //    //{
        //    //    string ss = "关键字为：" + lngmId + "的不存在!";
        //    //    clsCommonJsFunc.Alert(this, ss);
        //    //    return;
        //    //}
        //    //3、用提供的关键字初始化一个类对象；
        //    string strFldName = clsCtlTypeBLEx.GetFldNameByCtrlId(strCtrlId);
        //    if (string.IsNullOrEmpty(strFldName) == true)
        //    {
        //        string strMsg = string.Format("根据[控件Id:{0}]获取字段名(FldName)不成功！", strCtrlId);
        //        clsCommonJsFunc.Alert(this, strMsg);
        //        return;
        //    }

        //    string strCondition = new clsvExcelExportRegionFldsEN()
        //        .SetFldName(strFldName, "=")
        //        .SetRegionId(seRegionId, "=")
        //        .GetCombineCondition();
        //    long lngMid = clsvExcelExportRegionFldsBL.GetFirstID_S(strCondition);
        //    if (lngMid == 0)
        //    {
        //        string strMsg = string.Format("根据条件[{0}]获取关键字不成功！", strCondition);
        //        clsCommonJsFunc.Alert(this, strMsg);
        //        return;
        //    }
        //    clsExcelExportRegionFldsEN objExcelExportRegionFlds = new clsExcelExportRegionFldsEN(lngMid);
        //    //4、获取类对象的所有属性；
        //    clsExcelExportRegionFldsBL.GetExcelExportRegionFlds(ref objExcelExportRegionFlds);
        //    Session.Add("objExcelExportRegionFlds", objExcelExportRegionFlds);
        //    //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
        //    GetDataFromExcelExportRegionFldsClass(objExcelExportRegionFlds);

        //}


        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjExcelExportRegionFlds">表实体类对象</param>
        private void GetDataFromExcelExportRegionFldsClass(clsExcelExportRegionFldsEN pobjExcelExportRegionFlds)
		{
            wucExcelExportRegionFlds1.FldId = pobjExcelExportRegionFlds.FldId;
            try
            {
                var objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(pobjExcelExportRegionFlds.RegionId, clsPubVar.CurrSelPrjId);
                wucExcelExportRegionFlds1.vsCmPrjId = objViewRegion.PrjId;
                //wucExcelExportRegionFlds1.DataNodeId = pobjExcelExportRegionFlds.OutDataNodeId;
            }
            catch (Exception objException)
			{
				clsPubVar.objLog.WriteDebugLog(objException.Message);
				//string ss = "";
			}
            //wucExcelExportRegionFlds1.DataPropertyName = pobjExcelExportRegionFlds.DataPropertyName;
            //wucDetailRegionFlds1.SortExpression = objvDetailRegionFlds.SortExpression;

            wucExcelExportRegionFlds1.Memo = pobjExcelExportRegionFlds.Memo;
			wucExcelExportRegionFlds1.SeqNum = pobjExcelExportRegionFlds.SeqNum;
			wucExcelExportRegionFlds1.ColCaption = pobjExcelExportRegionFlds.ColCaption;
			
   //         clsvExcelExportRegionFldsEN objvExcelExportRegionFlds = clsvExcelExportRegionFldsBL.GetFirstObj_S("RegionId = '" + seRegionId + "' and TabFldId = " + pobjExcelExportRegionFlds.TabFldId);
			//wucExcelExportRegionFlds1.FldName = objvExcelExportRegionFlds.FldName;

		}
		/// <summary>
		/// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
		///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnOKUpd_Click(object sender, System.EventArgs e)
		{
			string strCommandText;
			clsExcelExportRegionFldsEN objExcelExportRegionFlds;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					AddExcelExportRegionFldsRecord();
					break;				
				case "确认添加":
					//这是一个单表的插入的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					AddExcelExportRegionFldsRecordSave();
					break;
				case "确认修改":
					//这是一个单表的修改的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					objExcelExportRegionFlds = (clsExcelExportRegionFldsEN) Session["objExcelExportRegionFlds"];
					UpdateExcelExportRegionFldsRecordSave(objExcelExportRegionFlds);
					break;
			}
		}
		
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjExcelExportRegionFlds">数据传输的目的类对象</param>
		private void PutDataToExcelExportRegionFldsClass(clsExcelExportRegionFldsEN pobjExcelExportRegionFlds)
		{
			pobjExcelExportRegionFlds.Memo = wucExcelExportRegionFlds1.Memo;
			pobjExcelExportRegionFlds.SeqNum = wucExcelExportRegionFlds1.SeqNum;
			pobjExcelExportRegionFlds.ColCaption = wucExcelExportRegionFlds1.ColCaption;
			pobjExcelExportRegionFlds.FldId = wucExcelExportRegionFlds1.FldId;
            //pobjExcelExportRegionFlds.OutDataNodeId = wucExcelExportRegionFlds1.DataNodeId;

            //if (string.IsNullOrEmpty(pobjExcelExportRegionFlds.OutDataNodeId) == false)
            //{
            //    pobjExcelExportRegionFlds.IsUseFunc = true;
            //}
            //else
            //{
            //    pobjExcelExportRegionFlds.IsUseFunc = false;
            //}
            //pobjExcelExportRegionFlds.DataPropertyName = wucExcelExportRegionFlds1.DataPropertyName;
            pobjExcelExportRegionFlds.RegionId = seRegionId;
            pobjExcelExportRegionFlds.PrjId = clsPubVar.CurrSelPrjId;
            pobjExcelExportRegionFlds.InUse = true;
            pobjExcelExportRegionFlds.UpdUser = clsCommonSession.UserId;
            pobjExcelExportRegionFlds.UpdDate = clsDateTime.getTodayDateTimeStr(1);


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
			DispPrjTabFldsInfo();
			
		}

		
		//当前记录数
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//	1、组合界面条件串；
			string strWhereCond = CombinevExcelExportRegionFldsCondition();
			//	2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = null;
			List<string> arrCnName = new List<string>();
			List<string> arrColName = new List<string>();
			string strFileName = "ExcelExportRegionFlds信息导出.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add("mId"); arrCnName.Add("mId");
			arrColName.Add("TabName"); arrCnName.Add("表名");
			arrColName.Add("FldName"); arrCnName.Add("字段名");
            arrColName.Add("DataTypeId"); arrCnName.Add("字段类型");
			arrColName.Add("FldLength"); arrCnName.Add("字段长度");
			arrColName.Add("Caption"); arrCnName.Add("标题");
			arrColName.Add("IsNull"); arrCnName.Add("是否可空");
			arrColName.Add("IsTabPrimary"); arrCnName.Add("是否作为表中主键");
			arrColName.Add("SequenceNumber"); arrCnName.Add("顺序号");
			arrColName.Add("IsParentObj"); arrCnName.Add("是否父对象");
			arrColName.Add("PrimaryTypeName"); arrCnName.Add("主键类型名");
			arrColName.Add("DataTypeName"); arrCnName.Add("DataTypeName");
			arrColName.Add("RegionId"); arrCnName.Add("区域Id");
			arrColName.Add("IsTabNullable"); arrCnName.Add("是否表中可空");
			arrColName.Add("SeqNum"); arrCnName.Add("列序号");
			arrColName.Add("ColCaption"); arrCnName.Add("列标题");
			arrColName.Add("TabFldId"); arrCnName.Add("表字段ID");
			strFolderName = Server.MapPath("~") +  "\\TempFiles\\";
			strDownLoadFileName = strFolderName + strFileName;
            try
            {
                objDT = clsvExcelExportRegionFldsBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                clsCommonSession.seErrMessage = objException.Message;
                clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                clsPubFun4Web.AccessError(this, conCurrPageName);
            }
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
            List<long> lstMId = wucvExcelExportRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            foreach (long lngmId in lstMId)
            {
                clsExcelExportRegionFldsBL.DelRecord(lngmId);
            }
            clsExcelExportRegionFldsBLEx.ReOrder(seRegionId);
            //clsViewRegionBLEx.SetFldCount(seRegionId);
            //clsViewRegionBLEx.SetFldCountInUse(seRegionId);

            BindGv_vExcelExportRegionFlds();
		}

		
		//当前记录数
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
            if (string.IsNullOrEmpty(hidCtrlId.Value) == false)
            {
                lblMsg1.Text = "";
                //1、显示该关键字记录的内容在界面上；

                ShowData(hidCtrlId.Value);
                //2、清空提示信息的内容,同时使<确定修改>按钮可用；
                clsPubFun.SetButtonEnabled(btnOKUpd, true);
                btnOKUpd.Text = "确认修改";
                return;
            }

            long lngmId = wucvExcelExportRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";
			//1、显示该关键字记录的内容在界面上；
		
			ShowData(lngmId);
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "确认修改";	
		}
		

		///生成的插入记录准备过程代码for C#
		private void AddExcelExportRegionFldsRecord()
		{
			btnOKUpd.Text = "确认添加";
            wucExcelExportRegionFlds1.SeqNum = 1;
        }
		///插入记录存盘过程代码for C#
		private void AddExcelExportRegionFldsRecordSave()
		{
			//操作步骤：
			//1、检查控件中输入数据类型是否正确
			//2、定义对象并初始化对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			//4、把值从界面层传到逻辑层或数据实体层
			//5、检查传进去的对象属性是否合法
			//6、把数据实体层的数据存贮到数据库中
			//7、把新添的记录内容显示在DATAGRID中
			string strMsg;	//专门用于传递信息的变量
			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			clsExcelExportRegionFldsEN objExcelExportRegionFlds;
			//1、检查控件中输入数据类型是否正确
			if (!wucExcelExportRegionFlds1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、定义对象并初始化对象
			//clsExcelExportRegionFldsEN objExcelExportRegionFlds;	//定义对象
			objExcelExportRegionFlds = new clsExcelExportRegionFldsEN();	//初始化新对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			//4、把值从界面层传到逻辑层或数据实体层
			PutDataToExcelExportRegionFldsClass(objExcelExportRegionFlds);		//把界面的值传到
			//5、检查传进去的对象属性是否合法
			try
			{
                clsExcelExportRegionFldsBL.CheckPropertyNew(objExcelExportRegionFlds);
                //6、把数据实体层的数据存贮到数据库中
                clsExcelExportRegionFldsBL .AddNewRecordBySql2(objExcelExportRegionFlds);
			}
			catch(Exception objException)
			{
				strMsg = "添加记录不成功!" + objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg.Text = strMsg;
				return;
			}
			strMsg = "添加记录成功!";
			clsCommonJsFunc.Alert(this, strMsg);
			lblMsg.Text = "添加记录成功!";
			//7、把新添的记录内容显示在DATAGRID中
			BindGv_vExcelExportRegionFlds();
			wucExcelExportRegionFlds1.Clear();		//清空控件中内容
			///恢复<确认添加>变成<添加>
			btnOKUpd.Text = "添加";
		}
		///插入记录存盘过程代码for C#
		private void AddExcelExportRegionFldsRecordSaveV5()
		{
			//操作步骤：
			//1、检查控件中输入数据类型是否正确
			//2、定义对象并初始化对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			//4、把值从界面层传到逻辑层或数据实体层
			//5、检查传进去的对象属性是否合法
			//6、把数据实体层的数据存贮到数据库中
			//7、把新添的记录内容显示在DATAGRID中
			string strMsg;	//专门用于传递信息的变量
			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			clsExcelExportRegionFldsEN objExcelExportRegionFlds;
			//1、检查控件中输入数据类型是否正确
			if (!wucExcelExportRegionFlds1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、定义对象并初始化对象
			//clsExcelExportRegionFldsEN objExcelExportRegionFlds;	//定义对象
			objExcelExportRegionFlds = new clsExcelExportRegionFldsEN();	//初始化新对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			//4、把值从界面层传到逻辑层或数据实体层
			PutDataToExcelExportRegionFldsClass(objExcelExportRegionFlds);		//把界面的值传到
			//5、检查传进去的对象属性是否合法
			try
			{
                clsExcelExportRegionFldsBL.CheckPropertyNew(objExcelExportRegionFlds);
                //6、把数据实体层的数据存贮到数据库中
                clsExcelExportRegionFldsBL .AddNewRecordBySql2(objExcelExportRegionFlds);
			}
			catch(Exception objException)
			{
				clsCommonSession.seErrMessage = "添加记录不成功!" + objException.Message;
				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			strMsg = "添加记录成功!";
			clsCommonJsFunc.Alert(this, strMsg);
			lblMsg.Text = "添加记录成功!";
			//7、把新添的记录内容显示在DATAGRID中
			BindGv_vExcelExportRegionFlds();
			wucExcelExportRegionFlds1.Clear();		//清空控件中内容
			///恢复<确认添加>变成<添加>
			btnOKUpd.Text = "添加";
		}
		///生成修改记录准备过程代码 for C#
		private void UpdateExcelExportRegionFldsRecord(long lngmId)
		{
			//操作步骤：（总共2步）
			//1、显示该关键字记录的内容在界面上；
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；

			//1、显示该关键字记录的内容在界面上；
			ShowData(lngmId);
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；
			clsPubFun.SetButtonEnabled(btnOKUpd, true);
			btnOKUpd.Text = "确认修改";
			lblMsg.Text = "";
		}
		///修改存盘准备过程代码 for C#
		private void UpdateExcelExportRegionFldsRecordSave(clsExcelExportRegionFldsEN objExcelExportRegionFlds)
		{
			//操作步骤：
			//1、检查控件中输入数据类型是否正确
			//2、把值从界面层传到逻辑层或数据实体层
			//3、检查传进去的对象属性是否合法
			//4、把数据实体层的数据存贮到数据库中
			//5、把修改后的内容显示在DATAGRID中
			string strMsg;	//专门用于传递信息的变量
			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			//1、检查控件中输入数据类型是否正确
			if (!wucExcelExportRegionFlds1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、把值从界面层传到逻辑层或数据实体层
			PutDataToExcelExportRegionFldsClass(objExcelExportRegionFlds);		//把界面的值传到
			//3、检查传进去的对象属性是否合法
			try
			{
                clsExcelExportRegionFldsBL.CheckPropertyNew(objExcelExportRegionFlds);
                //6、把数据实体层的数据存贮到数据库中
                clsExcelExportRegionFldsBL .UpdateBySql2(objExcelExportRegionFlds);
			}
			catch(Exception objException)
			{
				strMsg = "修改记录不成功!" + objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg.Text = strMsg;
				return ; 
			}
			strMsg = "修改记录成功!";
			clsCommonJsFunc.Alert(this, strMsg);
			lblMsg.Text = "修改记录成功!";
			//5、把修改后的内容显示在DATAGRID中
			BindGv_vExcelExportRegionFlds();
			wucExcelExportRegionFlds1.Clear();//添空控件中的内容
			//恢复<确认修改>变成<添加>
			btnOKUpd.Text = "添加";
			DispExcelExportRegionFldsInfo();
		}
		///修改存盘准备过程代码 for C#
		private void UpdateExcelExportRegionFldsRecordSaveV5(clsExcelExportRegionFldsEN objExcelExportRegionFlds)
		{
			//操作步骤：
			//1、检查控件中输入数据类型是否正确
			//2、把值从界面层传到逻辑层或数据实体层
			//3、检查传进去的对象属性是否合法
			//4、把数据实体层的数据存贮到数据库中
			//5、把修改后的内容显示在DATAGRID中
			string strMsg;	//专门用于传递信息的变量
			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			//1、检查控件中输入数据类型是否正确
			if (!wucExcelExportRegionFlds1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、把值从界面层传到逻辑层或数据实体层
			PutDataToExcelExportRegionFldsClass(objExcelExportRegionFlds);		//把界面的值传到
			//3、检查传进去的对象属性是否合法
			try
			{
                clsExcelExportRegionFldsBL.CheckPropertyNew(objExcelExportRegionFlds);
                //6、把数据实体层的数据存贮到数据库中
                clsExcelExportRegionFldsBL .UpdateBySql2(objExcelExportRegionFlds);
			}
			catch(Exception objException)
			{
				clsCommonSession.seErrMessage = "修改记录不成功!" + objException.Message;
				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			strMsg = "修改记录成功!";
			clsCommonJsFunc.Alert(this, strMsg);
			lblMsg.Text = "修改记录成功!";
			//5、把修改后的内容显示在DATAGRID中
			BindGv_vExcelExportRegionFlds();
			wucExcelExportRegionFlds1.Clear();//添空控件中的内容
			//恢复<确认修改>变成<添加>
			btnOKUpd.Text = "添加";
		}
		///删除记录过程代码for C#
		private void DeleteExcelExportRegionFldsRecord(long lngmId)
		{
			clsExcelExportRegionFldsBL.DelRecord(lngmId);
			BindGv_vExcelExportRegionFlds();
		}

		protected void btnCopyFldFromRelaTab_Click(object sender, System.EventArgs e)
		{
			//操作步骤：
			//1、获取当前区域ID的相关主表ID；
			//2、获取相关主表ID的字段ID的对象列表;
			//2、检查控件中输入数据类型是否正确
			//2、定义对象并初始化对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			//4、把值从界面层传到逻辑层或数据实体层
			//5、检查传进去的对象属性是否合法
			//6、把数据实体层的数据存贮到数据库中
			//7、把新添的记录内容显示在DATAGRID中
			
			try
			{
                clsExcelExportRegionFldsBLEx.ImportRelaFlds(seRegionId, clsPubVar.CurrCmPrjId, UserId);
                //clsViewRegionBLEx.SetFldCount(seRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(seRegionId);

            }
            catch (Exception objException)
			{
				clsCommonSession.seErrMessage = "导入区域字段列表不成功!" + objException.Message;
				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;
				clsPubFun4Web.AccessError(this, conCurrPageName);
			}

			BindGv_vExcelExportRegionFlds();
			///恢复<确认添加>变成<添加>
			//		lbDispFldList_Click(new object(), new System.EventArgs());
			Response.Write("<script>alert('与界面相关的主表字段信息复制成功！！')</script>");

		}

		protected void btnGoBack_Click(object sender, System.EventArgs e)
		{
			if (BackViewRegionLinkStr !="")
			{
				Response.Redirect(BackViewRegionLinkStr);
			}
		}
		private void DispExcelExportRegionFldsInfo()
		{
			tabExcelExportRegionFldsDataGrid.Visible = true;
			
			
			
			//tabCode.Visible = true;
		}
		private void DispPrjTabFldsInfo()
		{
			
			//tabEditExcelExportRegionFldsRegion.Visible = false;
			tabExcelExportRegionFldsDataGrid.Visible = false;
			
			//tabCode.Visible = false;
		}
		private void DispEditExcelExportRegionFldsRegionBak()
		{
			tabExcelExportRegionFldsDataGrid.Visible = false;
			
			
			
			//tabCode.Visible = false;
		}

	
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		
		
		protected void btnUpMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            long lngmId = wucvExcelExportRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

			try
			{
				clsExcelExportRegionFldsBLEx.AdjustSequenceNumber("UP", lngmId);
			}
			
			catch(Exception objException)
			{
				strMsg = objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg1.Text = strMsg;
				//				clsCommonSession.seErrMessage = objException.Message;
				//				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
				//				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			BindGv_vExcelExportRegionFlds();
            wucvExcelExportRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

		}

		protected void btnDownMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
            long lngmId = wucvExcelExportRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

	
			try
			{
				
				clsExcelExportRegionFldsBLEx.AdjustSequenceNumber("DOWN", lngmId);
			}
			
			catch(Exception objException)
			{
				strMsg = objException.Message;
				clsCommonJsFunc.Alert(this, strMsg);
				lblMsg1.Text = strMsg;
				//				clsCommonSession.seErrMessage = objException.Message;
				//				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
				//				clsPubFun4Web.AccessError(this, conCurrPageName);
			}
			BindGv_vExcelExportRegionFlds();
            wucvExcelExportRegionFlds4Gv1.SetCheckedItemForGv(lngmId);


        }
        protected void btnGoFirstLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvExcelExportRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";

            try
            {
                clsExcelExportRegionFldsBLEx.AdjustSequenceNumber("FIRST", lngmId);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vExcelExportRegionFlds();
            wucvExcelExportRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnGoLastLine_Click(object sender, EventArgs e)
        {
            string strMsg;
            long lngmId = wucvExcelExportRegionFlds4Gv1.GetFirstCheckedKeyFromGv();
            if (lngmId == 0) return;
            lblMsg1.Text = "";
    
            try
            {
                clsExcelExportRegionFldsBLEx.AdjustSequenceNumber("LAST", lngmId);
            }

            catch (Exception objException)
            {
                strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
                //				clsCommonSession.seErrMessage = objException.Message;
                //				clsCommonSession.seBackErrPageLinkStr  = Page.Request.Url.AbsolutePath;	//"../GenCode/wfmGenViewCode_WebV5.aspx";
                //				clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            BindGv_vExcelExportRegionFlds();
            wucvExcelExportRegionFlds4Gv1.SetCheckedItemForGv(lngmId);

        }

        protected void btnReOrder_Click(object sender, System.EventArgs e)
		{
            clsExcelExportRegionFldsBLEx.ReOrder(seRegionId);
			BindGv_vExcelExportRegionFlds();
		}

		protected void LinkButton1_Click(object sender, System.EventArgs e)
		{
			DispExcelExportRegionFldsInfo();
		}

		protected void lbDispTabList_Click(object sender, System.EventArgs e)
		{
			DispExcelExportRegionFldsInfo();
		}

		private string strSortExcelExportRegionFldsBy
		{
			get
			{
				string sstrSortExcelExportRegionFldsBy;
				sstrSortExcelExportRegionFldsBy = (string)ViewState["strSortExcelExportRegionFldsBy"];
				if (sstrSortExcelExportRegionFldsBy==null) 
				{
					sstrSortExcelExportRegionFldsBy = "";
				}
				return sstrSortExcelExportRegionFldsBy;
			}
			set
			{
				string sstrSortExcelExportRegionFldsBy = value;
				ViewState.Add("strSortExcelExportRegionFldsBy", sstrSortExcelExportRegionFldsBy);
			}
		}
        protected void lbDownLoadFile_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Sql数据类型Id， 参数：01：表；02:视图；
        /// </summary>
        public string vsInOutTypeId
        {
            get
            {
                string strInOutTypeId;
                strInOutTypeId = (string)ViewState["InOutTypeId"];
                if (strInOutTypeId == null)
                {
                    strInOutTypeId = "";
                }
                return strInOutTypeId;
            }
            set
            {
                string strInOutTypeId = value;
                ViewState.Add("InOutTypeId", strInOutTypeId);
            }
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


        protected void btnSetInUse_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvExcelExportRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsExcelExportRegionFldsBLEx.SetInUse(lstMId, clsCommonSession.UserId);
                clsExcelExportRegionFldsBLEx.ReOrder(seRegionId);
                //clsViewRegionBLEx.SetFldCount(seRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(seRegionId);

                BindGv_vExcelExportRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
        }

        protected void btnSetNotInUse_Click(object sender, EventArgs e)
        {
            List<long> lstMId = wucvExcelExportRegionFlds4Gv1.GetAllCheckedKeysFromGv();
            if (lstMId == null) return;
            lblMsg1.Text = "";
            try
            {
                clsExcelExportRegionFldsBLEx.SetNotInUse(lstMId, clsCommonSession.UserId);
                clsExcelExportRegionFldsBLEx.ReOrder(seRegionId);
                //clsViewRegionBLEx.SetFldCount(seRegionId);
                //clsViewRegionBLEx.SetFldCountInUse(seRegionId);

                BindGv_vExcelExportRegionFlds();
            }
            catch (Exception objException)
            {
                string strMsg = objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg1.Text = strMsg;
            }
        }

        protected void chkOnlyShowFldInUse_CheckedChanged(object sender, EventArgs e)
        {
            BindGv_vExcelExportRegionFlds();
        }
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvExcelExportRegionFlds4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            long lngmId = long.Parse(e.KeyId);
            DeleteExcelExportRegionFldsRecord(lngmId);
        }
        

        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvExcelExportRegionFlds4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            long lngmId = long.Parse(e.KeyId);
            UpdateExcelExportRegionFldsRecord(lngmId);
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vExcelExportRegionFlds()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombinevExcelExportRegionFldsCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvExcelExportRegionFlds4Gv1.SetSortBy_Prev(string.Format("{0} desc", convExcelExportRegionFlds.InUse));
                wucvExcelExportRegionFlds4Gv1.SetSortBy(string.Format("{0}", convExcelExportRegionFlds.SeqNum));

                wucvExcelExportRegionFlds4Gv1.BindGv_ExcelExportRegionFlds(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                //wucvExcelExportRegionFlds4Gv1.SetGvVisibility(convExcelExportRegionFlds.Caption, false);
                wucvExcelExportRegionFlds4Gv1.SetGvVisibility(convExcelExportRegionFlds.ColCaption, false);
                wucvExcelExportRegionFlds4Gv1.SetGvVisibility(convExcelExportRegionFlds.UpdDate, false);
                wucvExcelExportRegionFlds4Gv1.SetGvVisibility("修改", false);
                wucvExcelExportRegionFlds4Gv1.SetGvVisibility("删除", false);

                //wucvExcelExportRegionFlds4Gv1.SetGvVisibility(convExcelExportRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                wucExcelExportRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, 5, chkInUse.Checked);
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000119)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
        public void ShowCode(string strCode)
        {
            StringBuilder sbJs = new StringBuilder();
            //sbJs.Append("<script type=\"text/javascript\">");
            sbJs.AppendFormat("<textarea style=\"width: 100%; height: 720px; \">", strCode);
            sbJs.AppendFormat("{0}", strCode);
            sbJs.AppendFormat("</textarea>", strCode);
            //sbJs.Append("</script>");
            //litCode.Text = sbJs.ToString();
        }

        private void ShowCodeTypeButton()
        {
            pnlCodeTypeLst.Controls.Clear();
            //clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);
            int intAppTypeId = clsCommonSession.ApplicationTypeId;

            clsViewInfoEN objViewInfo = clsViewInfoBL.GetObjByViewIdCache(clsCommonSession.ViewId, clsPubVar.CurrSelPrjId);


            List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                            clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionSet_0004,
                            "",
                            enumRegionType.ExcelExportRegion_0007)
                            .OrderBy(x => x.OrderNum).ToList();

            //添加与表-功能相关的函数

            int intCount4 = arrvFunction4GeneCodeObjLst.Count();

            clsvApplicationTypeEN objvApplicationTypeEN = clsvApplicationTypeBL.GetObjByApplicationTypeIdCache(intAppTypeId);
            string strCharEncodingId = objvApplicationTypeEN.CharEncodingId;
            //cboCharEncodingId.SelectedValue = strCharEncodingId;
            //string strCondition = string.Format("{0}={1} order by {2}",
            //    clsAppCodeTypeRelaEN.con_ApplicationTypeId, intAppTypeId, clsAppCodeTypeRelaEN.con_OrderNum);
            List<clsvAppCodeTypeRelaENEx> arrObjLst = clsvAppCodeTypeRelaBLEx.GetObjExLstByApplicationTypeIdExCache(intAppTypeId)
                .OrderBy(x => x.GroupName).ThenBy(x => x.OrderNum)
                .ToList();

            int intCount = 0;
            //string strGroupName = "";
            IEnumerable<clsvAppCodeTypeRelaENEx> arrObjLst_V2 = arrObjLst.Where(x => x.DependsOn == "View");
            //if (vsvViewRegion != null)
            //{
            //    arrObjLst_V2 = arrObjLst_V2.Where(x => x.RegionTypeId == vsvViewRegion.RegionTypeId).OrderBy(x => x.OrderNum);
            //}
            List<string> arrGroupName = arrObjLst_V2.Select(x => x.GroupName).Distinct().ToList();
            bool bolIsFirst = true;
            Label objLabel = null;
            foreach (string strGroupName in arrGroupName)
            {
                IEnumerable<clsvAppCodeTypeRelaENEx> arrObjLst_Sel =
                    arrObjLst_V2.Where(x => x.GroupName == strGroupName);
                List<string> arrCodeTypeId = arrObjLst_Sel.Select(x => x.CodeTypeId).ToList();
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sel1 =
                   arrvFunction4GeneCodeObjLst.Where(x => arrCodeTypeId.Contains(x.FuncCodeTypeId));

                if (arrvFunction4GeneCodeObjLst_Sel1.Count() == 0)
                {
                    continue;
                }
                if (string.IsNullOrEmpty(strGroupName) == false)
                {
                    if (bolIsFirst == false)
                    {
                        Label objLabel_Br = new Label();
                        objLabel_Br.Text = string.Format("<br/>", strGroupName);
                        //objLabel.AutoSize = true;
                        pnlCodeTypeLst.Controls.Add(objLabel_Br);
                    }
                    else
                    {
                        bolIsFirst = false;
                    }
                    objLabel = new Label();
                    objLabel.Text = string.Format("{0}: ", strGroupName);
                    //objLabel.AutoSize = true;
                    objLabel.ID = string.Format("lbl{0}", strGroupName);
                    //string strToolTip = string.Format("生成：[{0}({1})({2})]的代码。", objInFor.CodeTypeName, objInFor.CodeTypeId, objInFor.ProgLangTypeId4CodeType);
                    //toolTip1.SetToolTip(objLabel, strToolTip);                    
                    objLabel.CssClass = "text-secondary font-weight-bold";
                    objLabel.Attributes["Style"] = "margin-right:10px;margin-top:35px;left:0px;min-width:150px;";
                    pnlCodeTypeLst.Controls.Add(objLabel);
                }
                foreach (clsvAppCodeTypeRelaENEx objInFor in arrObjLst_V2)
                {
                    if (objInFor.GroupName != strGroupName) continue;
                    List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sel =
                        arrvFunction4GeneCodeObjLst.Where(x => x.FuncCodeTypeId == objInFor.CodeTypeId).ToList();

                    foreach (clsvFunction4GeneCodeEN objvFunction4GeneCode in arrvFunction4GeneCodeObjLst_Sel)
                    {
                        HtmlInputButton objHtmlInputButton = new HtmlInputButton();
                        objHtmlInputButton.ID = string.Format("btn{0}_{1}", objInFor.CodeTypeId, objvFunction4GeneCode.FuncId4GC);

                        objHtmlInputButton.Name = string.Format("btn{0}_{1}", objInFor.CodeTypeId, objvFunction4GeneCode.FuncId4GC);
                        objHtmlInputButton.Attributes["class"] = "btn btn-outline-primary btn-sm";
                        objHtmlInputButton.Value = string.Format("{0}-{1}({2})",
                            objInFor.CodeTypeName, objvFunction4GeneCode.FuncCHName4Code,
                            objInFor.ProgLangTypeName);

                        objHtmlInputButton.Attributes.Add("onclick", string.Format("GeneCode4Func('{0}','{1}','{2}','{3}')",
                            objInFor.CodeTypeId, clsCommonSession.ViewId, objvFunction4GeneCode.FuncId4GC, intAppTypeId));

                        //objButton.Attributes["Style"] = "margin-right:10px;margin-top:5px;left:0px;";

                        //objButton.Command += new CommandEventHandler(this.btnCodeType_Click);
                        pnlCodeTypeLst.Controls.Add(objHtmlInputButton);
                        intCount++;
                    }
                }

            }
            if (intCount == 0)
            {
                string strMsg = string.Format("应用:{0}({1})没有用于[View]相应的代码类型.(In {2})",
                    objvApplicationTypeEN.ApplicationTypeName, objvApplicationTypeEN.ApplicationTypeId, clsStackTrace.GetCurrClassFunction());
                //clsCommonJsFunc.Alert(this, strMsg);
                clsSysParaEN_Local.objErrorLog.WriteDebugLog(strMsg);
                return;
            }
        }

        [WebMethod]
        public static string GeneCode4Func(string strCodeTypeId, string strTabId, string strFuncId, string strViewId, string strCmPrjId , int intApplicationTypeId)
        {

            if (strCodeTypeId.StartsWith("C"))
            {
                strCodeTypeId = strCodeTypeId.Substring(1);
            }
            //clsPubVar.CurrSelPrjId = "0116";
            //clsPubVar.CurrPrjDataBaseId = "0111";

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            //clsPubConst.ClassName cnClassName = clsPubConst.GetClassNameByString(objCodeType.CodeTypeENName);
            ////clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(strProgLangTypeId);
            //clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(clsProgLangTypeBL.GetNameByProgLangTypeIdCache(objCodeType.ProgLangTypeId));
            try
            {
                //   string strCharEncodingId = clsPubFun.GetCharEncodingIdByPrjUser(clsPubVar.CurrSelPrjId, clsCommonSession.UserId);

                //string strViewId = "";
                string strRe_ClsName = "";

                string strRe_FileNameWithModuleName = "";

				//string strCodeText1 = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId4GC, clsPubConst.DataBaseType.MsSql, strTabId,
				//    strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, intApplicationTypeId, clsCommonSession.UserId, ref strRe_ClsName,
				//    ref strRe_FileNameWithModuleName);
				//string str
				var Re_objFunction4Code = new clsFunction4CodeEN();
				string strCodeText = AutoGC.GeneCode4Func(strCodeTypeId, strFuncId, clsPubConst.DataBaseType.MsSql, strTabId,
               strViewId, strCmPrjId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId, clsCommonSession.UserId, ref strRe_ClsName,
               ref strRe_FileNameWithModuleName, ref Re_objFunction4Code);

                //txtFileName4GenCode.Text = strRe_ClsName;
                //ShowCode(strCodeText);
                clsGCType objGCType = new clsGCType();
                objGCType.Code = strCodeText;
                objGCType.ClsName = strRe_ClsName;
                objGCType.FileName = strRe_FileNameWithModuleName;
                return clsJSON.GetJsonFromObj(objGCType);
                //                return strCodeText;
            }
            catch (Exception objException)
            {
                //lblMsg.Text = objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
                return objException.Message;
                //clsCommonJsFunc.Alert(this, objException.Message);
            }
            //return strCodeText;
        }


        protected void chkInUse_CheckedChanged(object sender, EventArgs e)
        {

            bool bolInUse = chkInUse.Checked;
            clsViewRegionRelaEN obj = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionIdCache(clsCommonSession.ViewId, seRegionId, clsPubVar.CurrCmPrjId, clsPubVar.CurrSelPrjId);
            obj.SetInUse(bolInUse)
                .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(clsCommonSession.UserId)
                .Update();
            try
            {
                wucExcelExportRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId, 5, chkInUse.Checked);
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
        private void ShowData(string strCtrlId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            //if (lngmId == 0) return;        //如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；

            //if (clsExcelExportRegionFldsBL.IsExist(lngmId) == false)       //检查该关键字的记录是否存在
            //{
            //    string ss = "关键字为：" + lngmId + "的不存在!";
            //    clsCommonJsFunc.Alert(this, ss);
            //    return;
            //}
            //3、用提供的关键字初始化一个类对象；
            string strFldName = clsCtlTypeBLEx.GetFldNameByCtrlId(strCtrlId);
            if (string.IsNullOrEmpty(strFldName) == true)
            {
                string strMsg = string.Format("根据[控件Id:{0}]获取字段名(FldName)不成功！", strCtrlId);
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

            string strCondition = new clsvExcelExportRegionFldsEN()
                .SetFldName(strFldName, "=")
                .SetRegionId(seRegionId, "=")
                .GetCombineCondition();
            long lngMid = clsvExcelExportRegionFldsBL.GetFirstID_S(strCondition);
            if (lngMid == 0)
            {
                string strMsg = string.Format("根据条件[{0}]获取关键字不成功！", strCondition);
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            clsExcelExportRegionFldsEN objExcelExportRegionFlds = new clsExcelExportRegionFldsEN(lngMid);
            //4、获取类对象的所有属性；
            clsExcelExportRegionFldsBL.GetExcelExportRegionFlds(ref objExcelExportRegionFlds);
            Session.Add("objExcelExportRegionFlds", objExcelExportRegionFlds);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromExcelExportRegionFldsClass(objExcelExportRegionFlds);

        }
        protected void btnSetColNum_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtColNum.Text) == true)
            //{
            //    clsCommonJsFunc.Alert(this, "请输入列数！");
            //    txtColNum.Focus();
            //}
            //int intColNum = int.Parse(txtColNum.Text);

            if (string.IsNullOrEmpty(txtWidth.Text) == false)
            {
                try
                {
                    int intWidth = int.Parse(txtWidth.Text);
                    clsViewRegionEN objViewRegion = clsViewRegionBL.GetObjByRegionId(seRegionId);
                    if (string.IsNullOrEmpty(txtWidth.Text) == false)
                    {
                        objViewRegion.SetWidth(intWidth)
                                 .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(clsCommonSession.UserId)
                .Update();
						if (string.IsNullOrEmpty(vsViewId) == false)
						{
							clsViewInfoBLEx.SetViewUpdDate(vsViewId, clsPubVar.CurrSelPrjId, clsCommonSession.UserId);
						}
                    }
                }
                catch (Exception objException)
				{
					clsPubVar.objLog.WriteDebugLog(objException.Message);

				}
            }
            //clsEditRegionEN obj = clsEditRegionBL.GetObjByRegionId(seRegionId);
            //obj.SetColNum(intColNum)
            //    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
            //    .SetUpdUser(clsCommonSession.UserId)
            //    .Update();
            try
            {
                wucExcelExportRegion4Preview1.ShowControl4Regoin(seRegionId, clsPubVar.CurrSelPrjId,5, chkInUse.Checked);
                //	3、设置Gv控件的某些列不可见；

                //wucvFeatureRegionFlds4Gv1.SetGvVisibility(convFeatureRegionFlds.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000219)可视化显示功能区出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
        }
        protected string vsViewId
        {
            get
            {
                string sViewId;
                sViewId = (string)ViewState["ViewId"];
                if (sViewId == null)
                {
                    sViewId = "";
                }
                return sViewId;
            }
            set
            {
                string sViewId = value;
                ViewState.Add("ViewId", sViewId);
            }
        }
    }
}