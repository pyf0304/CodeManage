
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_ResearchPlanCRUD
表名:gs_ResearchPlan(01120663)
生成代码版本:2020.06.05.2
生成日期:2020/06/10 20:14:21
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研培主题
模块英文名:GraduateEduTopic
框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
import { gs_ResearchPlanCRUD } from "../PagesBase/GraduateEduTopic/gs_ResearchPlanCRUD.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsgs_ResearchPlanEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_ResearchPlanEN.js";
import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { clsvgs_ResearchPlanEN } from "../TS/L0_Entity/GraduateEduTopic/clsvgs_ResearchPlanEN.js";
import { clsgs_TopicTaskStatusEN } from "../TS/L0_Entity/ParameterTable/clsgs_TopicTaskStatusEN.js";
import { clsvUsersSimEN } from "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { gs_ResearchPlan_AddNewRecordAsync, gs_ResearchPlan_AddNewRecordWithMaxIdAsync, gs_ResearchPlan_Delgs_ResearchPlansAsync, gs_ResearchPlan_DelRecordAsync, gs_ResearchPlan_GetMaxStrIdAsync, gs_ResearchPlan_GetObjByPlanIdAsync, gs_ResearchPlan_IsExistAsync, gs_ResearchPlan_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchPlanWApi.js";
import { vgs_ResearchPlan_GetObjLstByPagerAsync, vgs_ResearchPlan_GetRecCountByCondAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js";
import { gs_TopicTaskStatus_BindDdl_StatusIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsgs_TopicTaskStatusWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { clsSysPara4WebApi } from "../TS/PubConfig/clsSysPara4WebApi.js";
import { GetFirstCheckedKeyIdInDiv } from "../TS/PubFun/clsCommFunc4Ctrl.js";
import { arrSelectedKeys, GetCheckedKeyIds, GetFirstCheckedKeyId, GetObjKeys, Redirect } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsOperateList, GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPager } from "../TS/PubFun/clsPager.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { gs_ResearchPlanCRUDEx } from "./gs_ResearchPlanCRUDEx.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog(): void;

declare var $;
declare var window;
/* gs_ResearchPlanCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class ResearchTopicPlanEx extends gs_ResearchPlanCRUD {
    public mstrListDiv: string = "divDataLst";
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public bolIsLoadDetailRegion: boolean = false;  //记录是否导入详细信息区的变量
    public divName4Edit: string = "divEdit";  //编辑区的Id
    public divName4Detail: string = "divDetail";  //详细信息区的Id
    public divName4Pager_ResearchPlan = "divPagerResearchPlan";
    //public objPager: clsPager = new clsPager();
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public recCount = 0;

    //研究计划
    public mstrListDivResearchPlan: string = "divResearchPlanDataLst";

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
   */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            //建立缓存

            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortvgs_ResearchPlanBy = "topicName Asc";
            //this.divName4Pager = "divPagerResearchPlan";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager_ResearchPlan);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vgs_ResearchPlan();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }
    
    /*
 按钮单击,用于调用Js函数中btn_Click
(AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
*/
    public btn_Click(strCommandName: string, strKeyId: string) {
        var objPage: gs_ResearchPlanCRUDEx = new gs_ResearchPlanCRUDEx();
        switch (strCommandName) {
            case "Query":    //查询记录
                //this.btnQuery_Click();
                break;
            case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                this.btnAddNewRecordWithMaxId_Click();
                break;
            case "CreateWithMaxId":    //添加记录使用最大关键字
                this.btnAddNewRecordWithMaxId_Click();
                break;
            case "AddNewRecord":            //添加记录
            case "Create":            //添加记录
                this.btnAddNewRecord_Click();
                break;
            case "UpdateRecord":            //修改记录
            case "Update":            //修改记录
                var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
                if (strKeyId == "") {
                    alert("请选择需要修改的记录！");
                    return;
                }
                this.btnUpdateRecord_Click(strKeyId);
                break;
            case "CopyRecord":            //复制记录
            case "Clone":            //复制记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要复制的记录！");
                    return;
                }
                //objPage.btnCopyRecord_Click();
                break;
            case "DelRecord":            //删除记录
            case "Delete":            //删除记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return;
                }
                this.btnDelRecord_Click();
                break;
            case "DelRecordBySign":            //按标志删除记录
            case "DeleteBySign":            //按标志删除记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要按标志删除的记录！");
                    return;
                }
                //objPage.btnDelRecordBySign_Click();
                break;
            case "UnDelRecordBySign":            //按标志恢复删除记录
            case "UnDeleteBySign":            //按标志恢复删除记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要恢复删除的记录！");
                    return;
                }
                //objPage.btnUnDelRecordBySign_Click();
                break;
            case "GoTop":            //置顶记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要置顶的记录！");
                    return;
                }
                //objPage.btnGoTop_Click();
                break;
            case "GoBottum":            //移底记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要移底的记录！");
                    return;
                }
                //objPage.btnGoBottum_Click();
                break;
            case "UpMove":            //上移记录
                var arrKeyIds = GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要上移的记录！");
                    return;
                }
                //objPage.btnUpMove_Click();
                break;
            case "DownMove":            //下移记录
                var arrKeyIds = GetCheckedKeyIds();
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
                var strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
                alert(strMsg);
                break;
            case "ExportExcel":            //导出Excel
                alert("导出Excel功能还没有开通！");
                break;
        }
    }
    /// <summary>
    /// 在当前界面中，导入编辑区域
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
    /// </summary>
    /// <returns></returns>
    public async AddDPV_Edit(divName4Edit) {
        var strUrl: string = "./gs_ResearchPlan_Edit/";
        console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "html",
                data: {},
                success: function (data) {
                    console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                    $('#' + divName4Edit).html(data);
                    resolve(true);
                    //setTimeout(() => { clsEditObj.BindTab(); }, 100);
                    //clsEditObj.BindTab();
                },
                error: (e) => {
                    console.error(e);
                    reject(e);
                }
            });
        });
    };

    /// <summary>
    /// 在当前界面中，导入编辑区域
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPVer_Detail)
    /// </summary>
    /// <returns></returns>
    public async AddDPVer_Detail(divName4Detail) {
        var strUrl: string = "./gs_ResearchPlan_Detail/";
        console.log("divName4Detail:(In AddDPVer_Detail)" + divName4Detail);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "html",
                data: {},
                success: function (data) {
                    console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                    $('#' + divName4Detail).html(data);
                    resolve(true);
                    //setTimeout(() => { clsDetailObj.BindTab(); }, 100);
                    //clsDetailObj.BindTab();
                },
                error: (e) => {
                    console.error(e);
                    reject(e);
                }
            });
        });
    };

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
   */
    public async Page_Load_Cache() {
        // 在此处放置用户代码以初始化页面
        try {
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortvgs_ResearchPlanBy = "topicName Asc";
            //2、显示无条件的表内容在GridView中
            //const gvResult = await this.BindGv_vgs_ResearchPlan_Cache();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }


    /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
   */
    //public async btnQuery_Click() {
    //    var strWhereCond = await this.Combinevgs_ResearchPlanCondition();
    //    try {
    //        this.recCount = await vgs_ResearchPlan_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
    
    //        });
    //        var objPagerPara: stuPagerPara = {
    //            pageIndex: 1,
    //            pageSize: this.pageSize,
    //            whereCond: strWhereCond,
    //            orderBy: this.hidSortvgs_ResearchPlanBy,
    //            sortFun: (x, y) => { return 0; }
    //        };
    //        const responseObjLst = await vgs_ResearchPlan_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
    //            var arrvgs_ResearchPlanObjLst: Array<clsvgs_ResearchPlanEN> = <Array<clsvgs_ResearchPlanEN>>jsonData;
    //            this.BindTab_vgs_ResearchPlan(this.mstrListDiv, arrvgs_ResearchPlanObjLst);
    //        });
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `查询不成功,${e}.`;
    //        alert(strMsg);
    //    }
    //}

    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
   */
    public async btnAddNewRecord_Click() {
        this.opType = "Add";
        try {
            if (this.bolIsLoadEditRegion == false)  //
            {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                ShowDialog('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecord();
            }
            else {
                ShowDialog('Add');
                const responseText = await this.AddNewRecord();
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
   */
    public async btnAddNewRecordWithMaxId_Click() {
        this.opType = "AddWithMaxId";
        try {
            if (this.bolIsLoadEditRegion == false)  //
            {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                ShowDialog('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecordWithMaxId();
            }
            else {
                ShowDialog('Add');
                const responseText = this.AddNewRecordWithMaxId();
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加新记录初始化不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 函数功能:为编辑区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
   */
    public async BindDdl4EditRegion() {
        // 在此处放置用户代码以初始化页面
        var objgs_TopicTaskStatus_Cond: clsgs_TopicTaskStatusEN = new clsgs_TopicTaskStatusEN();//编辑区域
        var objResearchTopic_Cond: clsResearchTopicEN = new clsResearchTopicEN();//编辑区域
        const ddlStatusId = await gs_TopicTaskStatus_BindDdl_StatusIdInDiv_Cache(this.divName4Edit, "ddlStatusId");//编辑区域
        //定义条件字段
     

    }


    /* 函数功能:为查询区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Js_BindDdl4QueryRegion)
   */
    public async BindDdl4QueryRegion() {
        // 在此处放置用户代码以初始化页面
        var objgs_TopicTaskStatus_Cond: clsgs_TopicTaskStatusEN = new clsgs_TopicTaskStatusEN();//查询区域
        const ddlStatusId_q = await gs_TopicTaskStatus_BindDdl_StatusIdInDiv_Cache(this.divName4Edit, "ddlStatusId_q");//查询区域
    }


    /* 在数据表里修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
   */
    public async btnUpdateRecordInTab_Click(strKeyId: string) {
        this.opType = "Update";
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        if (this.bolIsLoadEditRegion == false)  //
        {
            const responseBool = await this.AddDPV_Edit(this.divName4Edit);
            // 为编辑区绑定下拉框
            const conBindDdl = await this.BindDdl4EditRegion();
            ShowDialog('Update');
            this.bolIsLoadEditRegion = true;  //
            this.UpdateRecord(strKeyId);
        }
        else {
            ShowDialog('Update');
            this.UpdateRecord(strKeyId);
        }
    }

    /* 
    在数据表里删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
   */
    public async btnDelRecordInTab_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            const responseText = await this.DelRecord(strKeyId);
            const responseBindGv = await this.BindGv_vgs_ResearchPlan();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    在数据表里选择记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
   */
    public async btnSelectRecordInTab_Click1(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            this.SelectRecord(strKeyId);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `选择记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
   */
    public async DelRecord(strPlanId: string) {
        try {
            const responseText = await gs_ResearchPlan_DelRecordAsync(strPlanId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `删除记录不成功!`;
                //显示信息框
                alert(strInfo);
            }
            console.log("完成DelRecord!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    根据关键字选择相应的记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
     <param name = "sender">参数列表</param>
   */
    public async SelectRecord(strPlanId: string) {
        try {
            const responseText = await gs_ResearchPlan_GetObjByPlanIdAsync(strPlanId);
            var objgs_ResearchPlanEN: clsgs_ResearchPlanEN = <clsgs_ResearchPlanEN>responseText;
            console.log("完成SelectRecord!");
            Redirect("/Index/Main_vgs_ResearchPlan");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
   */
    public async btnUpdateRecord_Click(strKeyId: string) {
        this.opType = "Update";
        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        if (strKeyId == "") {
            alert("请选择需要修改的记录！");
            return;
        }
        if (this.bolIsLoadEditRegion == false)  //
        {
            const responseBool = await this.AddDPV_Edit(this.divName4Edit);
            // 为编辑区绑定下拉框
            const conBindDdl = await this.BindDdl4EditRegion();
            ShowDialog('Update');
            this.bolIsLoadEditRegion = true;  //
            this.UpdateRecord(strKeyId);
        }
        else {
            ShowDialog('Update');
            this.UpdateRecord(strKeyId);
        }
    }

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
            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_vgs_ResearchPlan();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
   */
    //public async btnExportExcel_Click() {
    //    var strWhereCond = " 1=1 ";
    //    try {
    //        const responseText = await vgs_ResearchPlan_GetObjLstAsync(strWhereCond).then((jsonData) => {
    //            var arrvgs_ResearchPlanObjLst: Array<clsvgs_ResearchPlanEN> = <Array<clsvgs_ResearchPlanEN>>jsonData;
    //            this.BindTab_vgs_ResearchPlan(this.mstrListDiv, arrvgs_ResearchPlanObjLst);
    //        });
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `导出Excel不成功,${e}.`;
    //        alert(strMsg);
    //    }
    //}

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
   */
    public async btnOKUpd_Click() {
        var strCommandText: string = this.btnOKUpd;
        try {
            switch (strCommandText) {
                case "添加":
                    const responseText1 = await this.AddNewRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    if (this.opType == "AddWithMaxId") {
                        const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                            var returnBool2: boolean = <boolean>jsonData;
                            if (returnBool2 == true) {
                                HideDialog();
                                this.BindGv_vgs_ResearchPlan();
                            }
                        });
                    }
                    else {
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vgs_ResearchPlan();
                            }
                        });
                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In gs_ResearchPlanCRUD.btnOKUpd_Click)";
                        $('#lblResult51').val(strInfo);
                        //显示信息框
                        console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            HideDialog();
                            this.BindGv_vgs_ResearchPlan();
                        }
                    });
                    break;
                default:
                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
                    alert(strMsg);
                    break;
            }
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
   */
    //public async Combinevgs_ResearchPlanCondition():Promise<string> {
    //    //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
    //    //例如 1 = 1 && userName = '张三'
    //    var strWhereCond: string = " 1 = 1 ";
    //    //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
    //    try {
    //        if (this.topicName_q != "") {
    //            strWhereCond += ` And ${clsvgs_ResearchPlanEN.con_TopicName} like '% ${this.topicName_q}%'`;
    //        }
    //        if (this.StatusId_q != "" && this.StatusId_q != "0") {
    //            strWhereCond += ` And ${clsvgs_ResearchPlanEN.con_StatusId} = '${this.StatusId_q}'`;
    //        }
    //    }
    //    catch (objException) {
    //        var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combinegs_ResearchPlanCondition)时出错!请联系管理员!${objException}`;
    //        throw strMsg;
    //    }
    //    return strWhereCond;
    //}

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
     <returns>条件串(strWhereCond)</returns>
   */
    public async Combinevgs_ResearchPlanConditionObj(): Promise<clsvgs_ResearchPlanEN> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objvgs_ResearchPlan_Cond: clsvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.topicName_q != "") {
                strWhereCond += ` And ${clsvgs_ResearchPlanEN.con_TopicName} like '% ${this.topicName_q}%'`;
                objvgs_ResearchPlan_Cond.SetCondFldValue(clsvgs_ResearchPlanEN.con_TopicName, this.topicName_q, "like");
            }
            if (this.StatusId_q != "" && this.StatusId_q != "0") {
                strWhereCond += ` And ${clsvgs_ResearchPlanEN.con_StatusId} = '${this.StatusId_q}'`;
                objvgs_ResearchPlan_Cond.SetCondFldValue(clsvgs_ResearchPlanEN.con_StatusId, this.StatusId_q, "=");
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0008)在组合查询条件对象(Combinegs_ResearchPlanConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objvgs_ResearchPlan_Cond;
    }


    /* 函数功能:从界面列表中根据某一个字段排序
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
     <param name = "strSortByFld">排序的字段</param>
   */
    public async SortBy(strSortByFld: string) {
        if (this.hidSortvgs_ResearchPlanBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvgs_ResearchPlanBy.indexOf("Asc") >= 0) {
                this.hidSortvgs_ResearchPlanBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvgs_ResearchPlanBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvgs_ResearchPlanBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_vgs_ResearchPlan();
    }

    /// <summary>
    /// 在用户自定义控件中，设置关键字的值，是否只读
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
    /// </summary>
    /// <param name = "bolReadonly">是否只读</param>
    public SetKeyReadOnly(bolReadonly: boolean) {
        $('#txtPlanId').prop['ReadOnly'] = bolReadonly;
    }

    /// <summary>
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear() {
    }

    /* 获取当前表关键字值的最大值,再加1,避免重复
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetMaxStrId)
   */
    public async GetMaxStrId(strKeyCtrlName) {
        this.DivName = "divGetMaxStrId";
        try {
            const responseText = await gs_ResearchPlan_GetMaxStrIdAsync();
            var returnString: string = responseText.toString();
            if (returnString == "") {
                var strInfo: string = `获取表gs_ResearchPlan的最大关键字为空，不成功，请检查!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                $(strKeyCtrlName).val(returnString);
            }
            else {
                var strInfo: string = `获取表gs_ResearchPlan的最大关键字为：${returnString}!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                $(strKeyCtrlName).val(returnString);
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
   */
    public async AddNewRecord() {
        this.SetKeyReadOnly(false);
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //wucgs_ResearchPlanB1.planId = clsgs_ResearchPlanBL.GetMaxStrId_S();
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
   */
    public AddNewRecordWithMaxId() {
        this.SetKeyReadOnly(false);
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //wucgs_ResearchPlanB1.planId = clsgs_ResearchPlanBL.GetMaxStrId_S();
    }

    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjgs_ResearchPlanEN">数据传输的目的类对象</param>
   */
    public PutDataTogs_ResearchPlanClass(pobjgs_ResearchPlanEN: clsgs_ResearchPlanEN) {
        pobjgs_ResearchPlanEN.SetPlanId(this.planId);// 计划Id
        pobjgs_ResearchPlanEN.SetStatusId(this.statusId);// 状态
        pobjgs_ResearchPlanEN.SetTopicId(this.topicId);// 主题
        var strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
        pobjgs_ResearchPlanEN.Setid_CurrEduCls(strId_CurrEduCls);
        pobjgs_ResearchPlanEN.SetPlanContent(this.planContent);// 计划内容
        pobjgs_ResearchPlanEN.SetResponsibleUser(this.responsibleUser);// 负责人/小组
        pobjgs_ResearchPlanEN.SetStartDate(this.startDate);// 开始日期
        pobjgs_ResearchPlanEN.SetEndDate(this.endDate);// 截止日期
        pobjgs_ResearchPlanEN.SetIsSubmit(this.isSubmit);// 是否提交
        pobjgs_ResearchPlanEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        pobjgs_ResearchPlanEN.SetUpdDate(this.updDate);// 修改日期
        pobjgs_ResearchPlanEN.SetMemo(this.memo);// 备注
    }


    /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        var objgs_ResearchPlanEN: clsgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
        this.PutDataTogs_ResearchPlanClass(objgs_ResearchPlanEN);
        try {
            const responseText = await gs_ResearchPlan_IsExistAsync(objgs_ResearchPlanEN.planId);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `添加记录时，关键字：${objgs_ResearchPlanEN.planId}已经存在！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            const responseText2 = await gs_ResearchPlan_AddNewRecordAsync(objgs_ResearchPlanEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加记录成功!`;
                $('#lblResult46').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult46').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;//一定要有一个返回值，否则会出错！
        }
    }

    /* 添加新记录，由后台自动获取最大值的关键字。保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
   */
    public async AddNewRecordWithMaxIdSave() {
        
        var objgs_ResearchPlanEN: clsgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
        this.PutDataTogs_ResearchPlanClass(objgs_ResearchPlanEN);
        try {
            const responseText2 = await gs_ResearchPlan_AddNewRecordWithMaxIdAsync(objgs_ResearchPlanEN);
            var returnBool: boolean = !!responseText2;
            if (returnBool == true) {
                var strInfo: string = `添加记录成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `添加记录不成功!`;
                $('#lblResult47').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            return responseText2;//一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `添加记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return true;//一定要有一个返回值，否则会出错！
    }

    /* 函数功能:把以该关键字的记录内容显示在界面上,
          在这里是把值传到表控件中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
     <param name = "strPlanId">表记录的关键字,显示该表关键字的内容</param>
   */
    public async ShowData(strPlanId: string) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objgs_ResearchPlanEN: clsgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
        try {
            const responseText = await gs_ResearchPlan_IsExistAsync(strPlanId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${strPlanId}] 的记录不存在!`;
                //$('#lblResult1').val(strInfo);
                //显示信息框
                alert(strInfo);
            }
            else {
            }
        }
        catch (e) {
            var strMsg: string = `检查相应关键字的记录存在不成功, ${e}.`;
            alert(strMsg);
        }
        try {
            const responseText = await gs_ResearchPlan_GetObjByPlanIdAsync(strPlanId);
            objgs_ResearchPlanEN = <clsgs_ResearchPlanEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromgs_ResearchPlanClass(objgs_ResearchPlanEN);
    }

    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjgs_ResearchPlanEN">表实体类对象</param>
   */
    public GetDataFromgs_ResearchPlanClass(pobjgs_ResearchPlanEN: clsgs_ResearchPlanEN) {
        this.planId = pobjgs_ResearchPlanEN.planId;// 计划Id
        this.statusId = pobjgs_ResearchPlanEN.statusId;// 状态
        this.topicId = pobjgs_ResearchPlanEN.topicId;// 主题
        this.planContent = pobjgs_ResearchPlanEN.planContent;// 计划内容
        this.responsibleUser = pobjgs_ResearchPlanEN.responsibleUser;// 负责人/小组
        this.startDate = pobjgs_ResearchPlanEN.startDate;// 开始日期
        this.endDate = pobjgs_ResearchPlanEN.endDate;// 截止日期
        this.isSubmit = pobjgs_ResearchPlanEN.isSubmit;// 是否提交
        this.updUser = pobjgs_ResearchPlanEN.updUser;// 修改人
        this.updDate = pobjgs_ResearchPlanEN.updDate;// 修改日期
        this.memo = pobjgs_ResearchPlanEN.memo;// 备注
    }

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public async UpdateRecord(strPlanId: string) {
        this.btnOKUpd = "确认修改";
        this.btnCancel = "取消修改";
        this.keyId = strPlanId;
        try {
            const responseText = await gs_ResearchPlan_GetObjByPlanIdAsync(strPlanId);
            var objgs_ResearchPlanEN: clsgs_ResearchPlanEN = <clsgs_ResearchPlanEN>responseText;
            this.GetDataFromgs_ResearchPlanClass(objgs_ResearchPlanEN);
            console.log("完成UpdateRecord!");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 修改记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
   */
    public async UpdateRecordSave() {
        const strThisFuncName = this.UpdateRecordSave.name;

        
        var objgs_ResearchPlanEN: clsgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
        objgs_ResearchPlanEN.SetPlanId(this.keyId);
        this.PutDataTogs_ResearchPlanClass(objgs_ResearchPlanEN);
        objgs_ResearchPlanEN.sfUpdFldSetStr = objgs_ResearchPlanEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objgs_ResearchPlanEN.planId == "" || objgs_ResearchPlanEN.planId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        try {
            const responseText = await gs_ResearchPlan_UpdateRecordAsync(objgs_ResearchPlanEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
            }
            return returnBool;
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `修改记录不成功,${e}.`;
            alert(strMsg);
            return false;
        }
    }

    /* 根据关键字列表删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
   */
    public async DelMultiRecord(arrPlanId: Array<string>) {
        try {
            const responseText = await gs_ResearchPlan_Delgs_ResearchPlansAsync(arrPlanId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `删除记录不成功!`;
                //显示信息框
                alert(strInfo);
            }
            console.log("完成DelMultiRecord!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 显示{0}对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
     <param name = "divContainer">显示容器</param>
     <param name = "objgs_ResearchPlan">需要显示的对象</param>
   */
    public Showgs_ResearchPlanObj(divContainer: string, objgs_ResearchPlan: clsgs_ResearchPlanEN) {
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrKeys = GetObjKeys(objgs_ResearchPlan);
        var ul: HTMLUListElement = document.createElement("ul");
        for (let strKey of sstrKeys) {
            var strValue = objgs_ResearchPlan[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = `${strKey}:${strValue}`;
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /* 函数功能:从界面列表中获取第一个关键字的值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
     <param name = "pobjgs_ResearchPlanEN">表实体类对象</param>
    <returns>列表的第一个关键字值</returns>
   */
    public GetFirstKey(): string {
        if (arrSelectedKeys.length == 1) {
            return arrSelectedKeys[0];
        }
        else {
            alert(`请选择一个关键字！目前选择了:${arrSelectedKeys.length}个关键字。`);
            return "";
        }
    }

    /*
    * 设置取消按钮的标题
   */
    public set btnCancel(value: string) {
        $("#btnCancel").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnOKUpd(): string {
        return $("#btnOKUpd").html();
    }
    /*
    * 设置确定按钮的标题
   */
    public set btnOKUpd(value: string) {
        $("#btnOKUpd").html(value);
    }
    /*
    * 设置当前页序号
   */
    public set CurrPageIndex(value: number) {
        $("#hidCurrPageIndex").val(value);
    }
    /*
    * 获取当前页序号
   */
    public get CurrPageIndex(): number {
        return $("#hidCurrPageIndex").val();
    }
    /*
    * 添加、修改用的层名
   */
    public set DivName(value: string) {
        $("#hidDivName").val(value);
    }
    /*
    * 截止日期
   */
    public set endDate(value: string) {
        $("#txtEndDate").val(value);
    }
    /*
    * 截止日期
   */
    public get endDate(): string {
        return $("#txtEndDate").val();
    }
    /*
    * 设置排序字段-相当使用ViewState功能
   */
   // public set hidSortvgs_ResearchPlanBy(value: string) {
   //     $("#hidSortvgs_ResearchPlanBy").val(value);
   // }
   // /*
   // * 设置排序字段
   //*/
   // public get hidSortvgs_ResearchPlanBy(): string {
   //     return $("#hidSortvgs_ResearchPlanBy").val();
   // }
    /*
    * 用户Id
   */
    public get hidUserId(): string {
        return clsPublocalStorage.userId;
    }
    /*
    * 是否提交
   */
    public set isSubmit(value: boolean) {
        $("#chkIsSubmit").attr("checked", value);
    }
    /*
    * 是否提交
   */
    public get isSubmit(): boolean {
        return $("#chkIsSubmit").prop("checked");
    }
    /*
    * 设置关键字的值
   */
    public set keyId(value: string) {
        $("#hidKeyId").val(value);
    }
    /*
    * 设置关键字的值
   */
    public get keyId(): string {
        return $("#hidKeyId").val();
    }
    /*
    * 备注
   */
    public set memo(value: string) {
        $("#txtMemo").val(value);
    }
    /*
    * 备注
   */
    public get memo(): string {
        return $("#txtMemo").val();
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public set opType(value: string) {
        $("#hidOpType").val(value);
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public get opType(): string {
        return $("#hidOpType").val();
    }
    /*
    * 计划内容
   */
    public set planContent(value: string) {
        $("#txtPlanContent").val(value);
    }
    /*
    * 计划内容
   */
    public get planContent(): string {
        return $("#txtPlanContent").val();
    }
    /*
    * 计划Id
   */
    public set planId(value: string) {
        $("#txtPlanId").val(value);
    }
    /*
    * 计划Id
   */
    public get planId(): string {
        return $("#txtPlanId").val();
    }
    /*
    * 负责人/小组
   */
    public set responsibleUser(value: string) {
        $("#txtResponsibleUser").val(value);
    }
    /*
    * 负责人/小组
   */
    public get responsibleUser(): string {
        return $("#txtResponsibleUser").val();
    }
    /*
    * 开始日期
   */
    public set startDate(value: string) {
        $("#txtStartDate").val(value);
    }
    /*
    * 开始日期
   */
    public get startDate(): string {
        return $("#txtStartDate").val();
    }
    /*
    * 状态Id
   */
    public set statusId(value: string) {
        $("#ddlStatusId").val(value);
    }
    /*
    * 状态Id
   */
    public get statusId(): string {
        return $("#ddlStatusId").val();
    }
    /*
    * 状态Id
   */
    public get StatusId_q(): string {
        return $("#ddlStatusId_q").val();
    }
    /*
    * 主题编号
   */
    public set topicId(value: string) {
        $("#ddlTopicId").val(value);
    }
    /*
    * 主题编号
   */
    public get topicId(): string {
        return $("#ddlTopicId").val();
    }
    /*
    * 栏目主题
   */
    public get topicName_q(): string {
        return $("#txtTopicName_q").val();
    }
    /*
    * 修改日期
   */
    public set updDate(value: string) {
        $("#txtUpdDate").val(value);
    }
    /*
    * 修改日期
   */
    public get updDate(): string {
        return $("#txtUpdDate").val();
    }
    /*
    * 修改人
   */
    public set updUser(value: string) {
        $("#txtUpdUser").val(value);
    }
    /*
    * 修改人
   */
    public get updUser(): string {
        return $("#txtUpdUser").val();
    }




    //研究计划
    public async liResearchPlanClick() {
        try {
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager_ResearchPlan);
                this.bolIsInitShow = true;  //
            }
            ////教师布置任务
            //const gvResult = await this.BindGv_gs_TeacherTask();
            //研究计划
            await this.BindGv_vgs_ResearchPlan();
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `获取客观依据列表不成功,${e}.`;
            alert(strMsg);
        }
    }


    /* 函数功能:在数据 列表中跳转到某一页
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
    <param name = "intPageIndex">页序号</param>
  */
    public async IndexPage(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.pageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.SetCurrPageIndex(intPageIndex);


        var strnum = $("#hidTabNum").val();
        //11代表研究计划 否则就是主题；
        if (strnum == "11") {
            this.BindGv_vgs_ResearchPlan();
        }
        //else {
        //    this.BindGv_ResearchTopic();
        //}

    }



    /////////////////////////////////////////////////////////////////////////////研究计划
    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public async Combinevgs_ResearchPlanCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //判断主题id
            var strTopicId = clsPrivateSessionStorage.topicId;
            if (strTopicId != "") {
                strWhereCond += ` And ${clsvgs_ResearchPlanEN.con_TopicId} = '${strTopicId}'`;
            }
            //判断角色 
            //管理员
            if (clsPublocalStorage.roleId == "00620001") {

            }
            else if (clsPublocalStorage.roleId == "00620002") {
                //教师
            }
            else {
                //学生； 
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combinegs_ResearchPlanCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
  */
    public async BindGv_vgs_ResearchPlan() {
        var strListDiv: string = this.mstrListDivResearchPlan;//研究计划
        var strWhereCond = await this.Combinevgs_ResearchPlanCondition();
        //var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager_ResearchPlan);//获取当前页
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrvgs_ResearchPlanObjLst: Array<clsvgs_ResearchPlanEN> = [];
        var arrvUsersObjLst: Array<clsvUsersSimEN> = [];
        try {
            this.recCount = await vgs_ResearchPlan_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvgs_ResearchPlanBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vgs_ResearchPlan_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvgs_ResearchPlanObjLst = <Array<clsvgs_ResearchPlanEN>>jsonData;
            });

            //获取用户缓存数据；
            arrvUsersObjLst = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        try {
            this.BindTab_vgs_ResearchPlan_pyf(arrvgs_ResearchPlanObjLst, arrvUsersObjLst);
            console.log("完成BindGv_vgs_ResearchPlan!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    //页面动态绑定
    public async BindTab_vgs_ResearchPlan_pyf(arrvgs_ResearchPlanObjLst: Array<clsvgs_ResearchPlanEN>, arrvUsersObjLst: Array<clsvUsersSimEN>) {
        var strhtml = "";
        var strUserId = clsPublocalStorage.userId;
        strhtml += '<div class="info" id="infoResearchPlan"><div class="title btn-4">';

        strhtml += '<div style="float:left;"><a href="#" title="研究计划">研究计划</a></div>';
        strhtml += '</div><ul class="artlist">';
        var v = 0;//给内容加个序号
        for (var i = 0; i < arrvgs_ResearchPlanObjLst.length; i++) {
            //得到planId；
            var strPlanId = arrvgs_ResearchPlanObjLst[i].planId;
            v++;
            strhtml += '<li><span class="rowtit color4">' + v + '.[研究状态]：</span><span class="abstract-text">' + arrvgs_ResearchPlanObjLst[i].statusName + '</span></li>';
            //判断计划类型
            if (arrvgs_ResearchPlanObjLst[i].planTypeId == "01") {
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[计划类型]：</span><span class="abstract-text">个人计划</span></li>';
            }
            else {
                strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[计划类型]：</span><span class="abstract-text">小组计划</span></li>';
            }
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[负责人/小组]：</span><span class="abstract-text">' + arrvgs_ResearchPlanObjLst[i].responsibleUser + '</span></li>';

            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[计划内容]：</span><span class="abstract-text">' + arrvgs_ResearchPlanObjLst[i].planContent + '</span></li>';
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[操作]：';

            strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[开始日期]：' + arrvgs_ResearchPlanObjLst[i].startDate + '</span>'
            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[结束日期]：</span>' + arrvgs_ResearchPlanObjLst[i].endDate;
            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[完成日期]：</span>' + arrvgs_ResearchPlanObjLst[i].actualFinishingDate;

            //获取引用人；编辑人、用户名称
            //var arrUsers: Array<clsvUsersSimEN> = await Users_GetObjLstAsync("1=1");
            var arrvUsers: Array<clsvUsersSimEN> = [];
            var UpdUserName;//编辑人

            //获取技能编辑人；
            arrvUsers = arrvUsersObjLst.filter(x => x.userId == arrvgs_ResearchPlanObjLst[i].acceptanceUser);//技能编辑人
            for (var j = 0; j < arrvUsers.length; j++) {
                UpdUserName = arrvUsers[j].userName;
                break;
            }
            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[验收用户]：</span>' + UpdUserName;

            if (arrvgs_ResearchPlanObjLst[i].isSubmit == true) {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
            }
            else {
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
            }

            if (arrvgs_ResearchPlanObjLst[i].isSubmit != true) {

                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="删除" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelResearchPlan_Click(\'' + arrvgs_ResearchPlanObjLst[i].planId + '\')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnUpdateResearchPlan_Click("' + arrvgs_ResearchPlanObjLst[i].planId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="提交" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnSubmitResearchPlan_Click("' + arrvgs_ResearchPlanObjLst[i].planId + '") > <i class="layui-icon" >&#xe642;</i>提交</button>';
            }
            strhtml += '</span></li>';

            strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        }
        strhtml += '</ul></div>';

        //拼接；
        $("#divResearchPlanDataLst").html(strhtml);

        if (arrvgs_ResearchPlanObjLst.length > 10) {
            $("#divPagerResearchPlan").show();
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager_ResearchPlan);
        }

    }


    //研究计划提交
    public async btnSubmitResearchPlan_Click(strKeyId: string) {

        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
        if (strKeyId == "") {
            alert("请选择需要提交的记录！");
            return;
        }
        this.SubmitRecord(strKeyId);

    }
    //提交判断；
    public async SubmitRecord(strPlanId: string) {

        this.keyId = strPlanId;
        return new Promise((resolve, reject) => {
            try {
                const responseText = gs_ResearchPlan_GetObjByPlanIdAsync(strPlanId).then((jsonData) => {
                    var objgs_ResearchPlanEN: clsgs_ResearchPlanEN = <clsgs_ResearchPlanEN>jsonData;

                    //通过session 权限获取权限
                    var strUserId = clsPublocalStorage.userId;
                    var strRoleId = clsPublocalStorage.roleId;
                    //可以提交
                    //判断数据是否已提交
                    if (objgs_ResearchPlanEN.isSubmit == false) {

                        const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                        });
                    }
                    else {
                        alert("当前数据已提交！");
                        return;
                    }

                });
            }
            catch (e) {
                console.error(e);
                var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        });
    }


    /* 修改记录
(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
*/
    public async SubmitRecordSave(): Promise<boolean> {
        const strThisFuncName = this.SubmitRecordSave.name;

        //
        var objgs_ResearchPlanEN: clsgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
        objgs_ResearchPlanEN.SetPlanId(this.keyId);
        objgs_ResearchPlanEN.SetIsSubmit(true);
        objgs_ResearchPlanEN.actualFinishingDate = clsPubFun4Web.getNowDate();
        objgs_ResearchPlanEN.acceptanceUser = clsPublocalStorage.userId;//验收用户
        objgs_ResearchPlanEN.sfUpdFldSetStr = objgs_ResearchPlanEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objgs_ResearchPlanEN.planId == "" || objgs_ResearchPlanEN.planId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        return new Promise((resolve, reject) => {
            try {
                const responseText = gs_ResearchPlan_UpdateRecordAsync(objgs_ResearchPlanEN).then((jsonData) => {
                    var returnBool: boolean = jsonData;
                    if (returnBool == true) {
                        var strInfo: string = `提交成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);

                        // HideDialog();
                        this.BindGv_vgs_ResearchPlan();
                    }
                    else {
                        var strInfo: string = `提交不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("提交失败");
                    }
                    resolve(jsonData);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg: string = `修改记录不成功,${e}.`;
                alert(strMsg);
            }
        });
    }
    /* 删除记录
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
  */
    public async btnDelResearchPlan_Click(strKeyId: string) {
        try {
            if (strKeyId == "") {
                alert("请选择需要删除的记录！");
                return "";
            }
            //得到当前登录的教师角色
            var strRoleId = clsPublocalStorage.roleId;
            if (strRoleId == "00620003") {
                //提示学生不可删除数据；
                var strInfo: string = `您权限不够，不可删除`;
                //显示信息框
                alert(strInfo);
                return;
            }
            else {
                const responseText = await this.DelPlanRecord(strKeyId);
                const responseBindGv = await this.BindGv_vgs_ResearchPlan();
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
   根据关键字删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
  */
    public async DelPlanRecord(strPlanId: string) {
        try {
            const responseText = await gs_ResearchPlan_DelRecordAsync(strPlanId);
            var returnInt: number = responseText;
            if (returnInt > 0) {
                var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                var strInfo: string = `删除记录不成功!`;
                //显示信息框
                alert(strInfo);
            }
            console.log("完成DelRecord!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `删除记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /*
* 设置排序字段-相当使用ViewState功能
*/
    public set hidSortvgs_ResearchPlanBy(value: string) {
        $("#hidSortvgs_ResearchPlanBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvgs_ResearchPlanBy(): string {
        return $("#hidSortvgs_ResearchPlanBy").val();
    }

}