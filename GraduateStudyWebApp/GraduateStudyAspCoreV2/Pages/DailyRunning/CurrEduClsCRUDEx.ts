
/*-- -- -- -- -- -- -- -- -- -- --
类名:CurrEduClsCRUDEx
表名:CurrEduCls(01120123)
生成代码版本:2020.05.09.1
生成日期:2020/05/11 16:30:25
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:日常运行
模块英文名:DailyRunning
框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { gs_TeachingDate_EditEx } from "../GraduateEduTools/gs_TeachingDate_EditEx.js";
import { CurrEduClsCRUD } from "../PagesBase/DailyRunning_Share/CurrEduClsCRUD.js";
import { clsCurrEduClsEN } from "../TS/L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js";
import { clsvCurrEduClsEN } from "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsEN.js";
import { clsvCurrEduClsENEx } from "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsENEx.js";
import { clsgs_TeachingDateEN } from "../TS/L0_Entity/GraduateEduTools/clsgs_TeachingDateEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { CurrEduCls_GetObjLstAsync } from "../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js";
import { vCurrEduCls_GetObjLstByPagerAsync, vCurrEduCls_GetRecCountByCondAsync } from "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsWApi.js";
import { gs_TeachingDate_GetFirstObjAsync, gs_TeachingDate_GetObjLst_Cache } from "../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js";
import { vUsersSim_func } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { vCurrEduClsEx_CopyToEx } from "../TS/L3_ForWApiEx/DailyRunning_Share/clsvCurrEduClsExWApi.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { GetCheckedKeyIdsInDiv, GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { BindTab_V, GetCheckedKeyIds, SortFun } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsStackTrace } from "../TS/PubFun/clsStackTrace.js";
import { Format } from "../TS/PubFun/clsString.js";

import { IShowList } from "../TS/PubFun/IShowList.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { CurrEduCls_EditEx } from "./CurrEduCls_EditEx.js";

declare function ShowDialog(strOpType): void;
declare function HideDialog(): void;

declare function ShowDialogOne(strOpType): void;
declare function HideDialogOne(): void;

declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
declare var strCurrPrjId;
declare var $;
declare var window;
/* CurrEduClsCRUDEx 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
*/
export class CurrEduClsCRUDEx extends CurrEduClsCRUD implements IShowList {
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrSortvCurrEduClsBy: string = "id_CurrEduCls";
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 10;
    }

  
    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
   */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            //建立缓存

            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            CurrEduClsCRUD.sortCurrEduClsBy = "currEduClsId Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vCurrEduCls();
            $("#divLoading").hide();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }
    BindGv(strType: string, strPara: string) {
        //this.BindGv_vgs_TeachingDate();
        this.BindGv_vCurrEduCls();
    }
    BindGv_Cache(strType: string, strPara: string) {
        switch (strType) {
            case "vgs_TeachingDate":
                alert('该类没有绑定该函数：[this.BindGv_vgs_TeachingDate_Cache]！');
                //this.BindGv_vgs_TeachingDate_Cache();
                break;
        }
    }
    /*
   按钮单击,用于调用Js函数中btn_Click
  (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
  */
    public static btn_Click(strCommandName: string, strKeyId: string) {
        let objPage: CurrEduClsCRUDEx;
        if (CurrEduClsCRUD.objPage_CRUD == null) {
            CurrEduClsCRUD.objPage_CRUD = new CurrEduClsCRUDEx();
            objPage = <CurrEduClsCRUDEx>CurrEduClsCRUD.objPage_CRUD;
        }
        else {
            objPage = <CurrEduClsCRUDEx>CurrEduClsCRUD.objPage_CRUD;
        }
        const objPage_Edit: CurrEduCls_EditEx = new CurrEduCls_EditEx(objPage);
        const arrKeyIds = GetCheckedKeyIdsInDiv(objPage.divName4DataList);
        let strMsg = '';
        switch (strCommandName) {
            case "Query":    //查询记录
                objPage.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                ShowDialog('AddWithMaxId');
                objPage_Edit.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                ShowDialog('AddWithMaxId');
                objPage_Edit.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                objPage_Edit.btnAddNewRecord_Click();
                break;
            case "SetUpDate":            //修改记录
                var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);
                if (strKeyId == "") {
                    alert("请选择需要设置的记录！");
                    return;
                }
                objPage.btnSetUpDateRecord_Click(strKeyId);
                break;
            case "UpdateRecord":            //修改记录
            case "Update":            //修改记录
                var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);
                if (strKeyId == "") {
                    alert("请选择需要修改的记录！");
                    return;
                }
                objPage_Edit.btnUpdateRecord_Click(strKeyId);
                break;
           


            case "CopyRecord":            //复制记录
            case "Clone":            //复制记录
                
                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
                
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return;
                }
                objPage.btnDelRecord_Click();
                break;
            case "DelRecordBySign":            //按标志删除记录
            case "DeleteBySign":            //按标志删除记录
                
                if (arrKeyIds.length == 0) {
                    alert("请选择需要按标志删除的记录！");
                    return;
                }
                //objPage.btnDelRecordBySign_Click();
                break;
            case "UnDelRecordBySign":            //按标志恢复删除记录
            case "UnDeleteBySign":            //按标志恢复删除记录
                
                if (arrKeyIds.length == 0) {
                    alert("请选择需要恢复删除的记录！");
                    return;
                }
                //objPage.btnUnDelRecordBySign_Click();
                break;
            case "GoTop":            //置顶记录
                
                if (arrKeyIds.length == 0) {
                    alert("请选择需要置顶的记录！");
                    return;
                }
                //objPage.btnGoTop_Click();
                break;
            case "GoBottum":            //移底记录
                
                if (arrKeyIds.length == 0) {
                    alert("请选择需要移底的记录！");
                    return;
                }
                //objPage.btnGoBottum_Click();
                break;
            case "UpMove":            //上移记录
                
                if (arrKeyIds.length == 0) {
                    alert("请选择需要上移的记录！");
                    return;
                }
                //objPage.btnUpMove_Click();
                break;
            case "DownMove":            //下移记录
                
                if (arrKeyIds.length == 0) {
                    alert("请选择需要下移的记录！");
                    return;
                }
                //objPage.btnDownMove_Click();
                break;
            case "ReOrder":            //重序记录
                //objPage.btnReOrder_Click();
                break;
            default:
                strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
            case "ExportExcel":            //导出Excel
                alert("导出Excel功能还没有开通！");
                break;
        }
    }


  

    //概念提交审核
    public async mySubmitDate() {
        let objPage: CurrEduClsCRUDEx;
        if (CurrEduClsCRUD.objPage_CRUD == null) {
            CurrEduClsCRUD.objPage_CRUD = new CurrEduClsCRUDEx();
            objPage = <CurrEduClsCRUDEx>CurrEduClsCRUD.objPage_CRUD;
        }
        else {
            objPage = <CurrEduClsCRUDEx>CurrEduClsCRUD.objPage_CRUD;
        }
        const objPage_Edit: CurrEduCls_EditEx = new CurrEduCls_EditEx(objPage);
        const responseText1 = await objPage_Edit.SetUpDate();

    }


    /* 修改记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/


    /* 删除记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
*/
    public async btnDelRecord_Click() {
        try {
            var arrKeyIds = GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要删除的记录！");
                return "";
            }
            //需要判断当前数据中是否包含已提交数据、如果有则不能删除
            var strKeyList;
            if (arrKeyIds.length == 0) return "";
            strKeyList = "";
            for (var i = 0; i < arrKeyIds.length; i++) {
                if (i == 0) strKeyList = strKeyList + "'" + arrKeyIds[i].toString() + "'";
                else strKeyList += "," + "'" + arrKeyIds[i].toString() + "'";
            }
            //
            //获取用户角色来判断显示不同的列表数据；
            var strUserId = clsPublocalStorage.userId;
            var strWhereCond = " id_CurrEduCls in (" + strKeyList + ")";
            var arrCurrEduClsObjLst: Array<clsCurrEduClsEN> = [];
            const responseText1 = await CurrEduCls_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrCurrEduClsObjLst = <Array<clsCurrEduClsEN>>jsonData;
                //查询是否有提交的数据
                arrCurrEduClsObjLst = arrCurrEduClsObjLst.filter(x => x.modifyUserID != strUserId);
                if (arrCurrEduClsObjLst.length > 0) {
                    alert("包含其他用户添加数据，不能删除！");
                    return "";
                }
            });


            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_vCurrEduCls();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }




    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    public async CombinevCurrEduClsCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.currEduClsId_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsEN.con_CurrEduClsId} like '% ${this.currEduClsId_q}%'`;
            }
            if (this.eduClsName_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsEN.con_EduClsName} like '% ${this.eduClsName_q}%'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineCurrEduClsCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /// <summary>
    /// 把同一个类的对象,复制到另一个对象
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyToEx)
    /// </summary>
    /// <param name = "objvCurrEduClsENS">源对象</param>
    /// <returns>目标对象=>clsvCurrEduClsEN:objvCurrEduClsENT</returns>
    public CopyToEx(objvCurrEduClsENS: clsvCurrEduClsEN): clsvCurrEduClsENEx {
        var objvCurrEduClsENT = new clsvCurrEduClsENEx();
        try {
            objvCurrEduClsENT = vCurrEduClsEx_CopyToEx(objvCurrEduClsENS);
            return objvCurrEduClsENT;
        }
        catch (e) {
            var strMsg: string = Format("(errid:WiTsCs0011)Copy表对象数据出错,${e}.({0})",
                clsStackTrace.GetCurrClassFunction());
            alert(strMsg);
            return objvCurrEduClsENT;
        }
    }
    /// <summary>
    /// 把一个扩展类的部分属性进行函数转换
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap)
    /// </summary>
    /// <param name = "objvCurrEduClsS">源对象</param>
    public async FuncMap(objvCurrEduCls: clsvCurrEduClsENEx) {
        try {
            {
                var vUsersSim_UserId = objvCurrEduCls.modifyUserID;
                var vUsersSim_UserName = await vUsersSim_func(clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, vUsersSim_UserId, clsSysPara4WebApi.cmPrjId);
                objvCurrEduCls.userName = vUsersSim_UserName;
            };

            {
                let arrgs_TeachingDate = await gs_TeachingDate_GetObjLst_Cache(objvCurrEduCls.id_CurrEduCls);
                if (arrgs_TeachingDate.length > 0) {
                    let objgs_TeachingDate = arrgs_TeachingDate[0];
                    let strTeachingDate = Format("{0}-{1}", objgs_TeachingDate.startDate, objgs_TeachingDate.endDate);
                    objvCurrEduCls.teachingDate = strTeachingDate;
                }
            };


        }
        catch (e) {
            var strMsg: string = `(errid:WiTsCs0012)函数映射表对象数据出错,${e}.(${clsStackTrace.GetCurrClassFunction()})`;
            alert(strMsg);
        }
    }
    /* 根据条件获取相应的对象列表
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
*/
    public async BindGv_vCurrEduCls() {
        var strListDiv: string = this.divName4DataList;
        var strWhereCond = await this.CombinevCurrEduClsCondition();
        const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvCurrEduClsObjLst: Array<clsvCurrEduClsEN> = [];
        var arrvCurrEduClsExObjLst: Array<clsvCurrEduClsENEx> = [];
        try {
            this.recCount = await vCurrEduCls_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: CurrEduClsCRUD.sortCurrEduClsBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vCurrEduCls_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvCurrEduClsObjLst = <Array<clsvCurrEduClsEN>>jsonData;
            });


            arrvCurrEduClsExObjLst = arrvCurrEduClsObjLst.map(this.CopyToEx);
            for (var objInFor of arrvCurrEduClsExObjLst) {
                const conFuncMap = await this.FuncMap(objInFor);
            }

        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }

        try {
            this.BindTab_vCurrEduCls(strListDiv, arrvCurrEduClsExObjLst);
            console.log("完成BindGv_vCurrEduCls!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    /* 显示vCurrEduCls对象的所有属性值
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
 <param name = "divContainer">显示容器</param>
 <param name = "arrCurrEduClsObjLst">需要绑定的对象列表</param>
*/
    public async BindTab_vCurrEduCls(divContainer: string, arrvCurrEduClsObjLst: Array<clsvCurrEduClsENEx>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    fldName: "",
                    colHeader: "",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "currEduClsId",
                    colHeader: "教学班Id",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "eduClsName",
                    colHeader: "教学班",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "courseCode",
                //    colHeader: "课程代码",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "courseName",
                    colHeader: "课程",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "collegeName",
                    colHeader: "学院",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "schoolYear",
                    colHeader: "学年",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "schoolTerm",
                    colHeader: "学期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "TeachingDate",
                    colHeader: "时间范围",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    sortBy: "userName", sortFun: SortFun, getDataSource: "",
                    colHeader: "编辑人",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 21,
                    funcName: () => { }
                },
            ];
        BindTab_V(o, arrvCurrEduClsObjLst, arrDataColumn, "id_CurrEduCls", this);
        this.objPager.recCount = this.recCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }


    /* 设置教学班时间范围；
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
*/
    public async btnSetUpDateRecord_Click(keyId: string) {
        var objPage: CurrEduClsCRUDEx = new CurrEduClsCRUDEx();
        var objPage_Edit: gs_TeachingDate_EditEx = new gs_TeachingDate_EditEx(objPage);
        var strKeyId = keyId;
        //判断教学班数据是否已经被设置
        var strWhere = " 1 = 1 And id_CurrEduCls = '" + strKeyId + "'";
        const responseText1 = await gs_TeachingDate_GetFirstObjAsync(strWhere);
        var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText1;
        if (objgs_TeachingDateEN != null) {
            //赋值，弹出框
            //存放教学班日期范围表主键
            $("#hidgs_DateId").val(objgs_TeachingDateEN.mId);
            objPage_Edit.btnUpdateRecordInTab_Click(objgs_TeachingDateEN.mId.toString());
        }
        else {
            //添加 需要清空下隐藏数据
            $("#hidgs_DateId").val("");
            objPage_Edit.btnAddNewRecord_Click();

        }


      
    }


    /*
* 开始时间
*/
    public set startDate(value: string) {
        $("#txtStartDate").val(value);
    }
    /*
    * 开始时间
   */
    public get startDate(): string {
        return $("#txtStartDate").val();
    }

    /*
* 结束时间
*/
    public set endDate(value: string) {
        $("#txtEndDate").val(value);
    }
    /*
    * 结束时间
   */
    public get endDate(): string {
        return $("#txtEndDate").val();
    }

}