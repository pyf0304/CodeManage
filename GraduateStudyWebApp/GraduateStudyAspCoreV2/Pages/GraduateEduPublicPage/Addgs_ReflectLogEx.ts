
/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_TeacherTaskCRUD
表名:gs_TeacherTask(01120686)
生成代码版本:2020.06.27.2
生成日期:2020/07/01 16:14:27
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

import { gs_ReflectLogCRUD } from "../PagesBase/GraduateEduTopic/gs_ReflectLogCRUD.js";
import { gs_TeacherTaskCRUD } from "../PagesBase/GraduateEduTopic/gs_TeacherTaskCRUD.js";
import { clsPubFun4Web } from "../TS/FunClass_Share/clsPubFun4Web.js";
import { clsgs_ReflectLogEN } from "../TS/L0_Entity/GraduateEduTopic/clsgs_ReflectLogEN.js";
import { clsResearchTopicEN } from "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js";
import { gs_ReflectLog_AddNewRecordAsync, gs_ReflectLog_DelRecordAsync, gs_ReflectLog_GetObjBymIdAsync, gs_ReflectLog_GetObjLstAsync, gs_ReflectLog_GetObjLstByPagerAsync, gs_ReflectLog_GetRecCountByCondAsync, gs_ReflectLog_IsExistAsync, gs_ReflectLog_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ReflectLogWApi.js";
import { ResearchTopic_GetFirstObjAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js";
import { clsPrivateSessionStorage } from "../TS/PubConfig/clsPrivateSessionStorage.js";
import { arrSelectedKeys, GetCheckedKeyIds, GetObjKeys, Redirect } from "../TS/PubFun/clsCommFunc4Web.js";
import { clsOperateList, GetCurrPageIndex } from "../TS/PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { Format } from "../TS/PubFun/clsString.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog_gs_TeacherTask(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog_gs_TeacherTask(): void;

declare function CloseWindow(): void;
/*
* 宣布一个已经在其他地方定义存在的变量strUrl_Session_SetString，
* 用于定义处理Session-设置String函数的地址
*/
declare var strUrl_Session_SetString;
declare var strUrl_Session_GetString;
/*
* 宣布一个已经在其他地方定义存在的变量strCurrPrjId，
* 用于定义当前工程Id
*/
declare var strCurrPrjId;
declare var $;
declare var window;
/* gs_TeacherTaskCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class Addgs_ReflectLogEx extends gs_ReflectLogCRUD {
    public mstrListDiv: string = "divDataLst";
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public bolIsLoadDetailRegion: boolean = false;  //记录是否导入详细信息区的变量
    public divName4Edit: string = "divEdit";  //编辑区的Id
    public divName4Detail: string = "divDetail";  //详细信息区的Id
    
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public recCount = 0;


    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
   */
    public async Page_Load() {
        const strThisFuncName = this.Page_Load.name;
        // 在此处放置用户代码以初始化页面
        try {
            //通过主题Id获取教学班ID
            if (clsPublocalStorage.id_CurrEduCls == "") {
                const objResearchTopic = await ResearchTopic_GetFirstObjAsync(" topicId=" + clsPrivateSessionStorage.topicId);
                if (objResearchTopic == null) {
                    const strMsg = Format("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                    //const strThisFuncName = this.ShowData.name;
                }
                clsPublocalStorage.id_CurrEduCls = objResearchTopic.id_CurrEduCls;
            } 

            var strmId = $("#hidKeyId").val();
            if (strmId != "") {


                const conBindDdl = await this.BindDdl4EditRegion();
                const UpdateRecord = await this.UpdateRecord(strmId);
                $("#divLoading").hide();
            }
            else {
                ////2、显示无条件的表内容在GridView中
                //const gvResult = await this.BindGv_vSysSkill();

                this.btnAddNewRecord_Click();

                $("#divLoading").hide();
            }

            //// 为查询区绑定下拉框
            //const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortgs_TeacherTaskBy = "missionStatement Asc";
            ////2、显示无条件的表内容在GridView中
            //const gvResult = await this.BindGv_gs_TeacherTask();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }


    ///// <summary>
    ///// 在当前界面中，导入编辑区域
    ///// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
    ///// </summary>
    ///// <returns></returns>
    //public async AddDPV_Edit(divName4Edit) {
    //    var strUrl: string = "./gs_TeacherTask_Edit/";
    //    console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
    //    return new Promise(function (resolve, reject) {
    //        $.ajax({
    //            url: strUrl,
    //            method: "GET",
    //            dataType: "html",
    //            data: {},
    //            success: function (data) {
    //                console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
    //                $('#' + divName4Edit).html(data);
    //                resolve(true);
    //                //setTimeout(() => { clsEditObj.BindTab(); }, 100);
    //                //clsEditObj.BindTab();
    //            },
    //            error: (e) => {
    //                console.error(e);
    //                reject(e);
    //            }
    //        });
    //    });
    //};

    ///// <summary>
    ///// 在当前界面中，导入编辑区域
    ///// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPVer_Detail)
    ///// </summary>
    ///// <returns></returns>
    //public async AddDPVer_Detail(divName4Detail) {
    //    var strUrl: string = "./gs_TeacherTask_Detail/";
    //    console.log("divName4Detail:(In AddDPVer_Detail)" + divName4Detail);
    //    return new Promise(function (resolve, reject) {
    //        $.ajax({
    //            url: strUrl,
    //            method: "GET",
    //            dataType: "html",
    //            data: {},
    //            success: function (data) {
    //                console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
    //                $('#' + divName4Detail).html(data);
    //                resolve(true);
    //                //setTimeout(() => { clsDetailObj.BindTab(); }, 100);
    //                //clsDetailObj.BindTab();
    //            },
    //            error: (e) => {
    //                console.error(e);
    //                reject(e);
    //            }
    //        });
    //    });
    //};

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
   */
    public async Page_Load_Cache() {
        // 在此处放置用户代码以初始化页面
        try {
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortgs_TeacherTaskBy = "missionStatement Asc";
            //2、显示无条件的表内容在GridView中
            //const gvResult = await this.BindGv_gs_TeacherTask_Cache();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }
    /* 把所有的查询控件内容组合成一个条件串
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
  */
    public async Combinegs_ReflectLogCondition(): Promise<string> {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            //if (this.MissionStatement_q != "") {
            //    strWhereCond += ` And ${clsgs_ReflectLogEN.con_MissionStatement} like '% ${this.MissionStatement_q}%'`;
            //}
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(Combinegs_TeacherTaskCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
   */
    public async btnQuery_Click() {
        var strWhereCond = await this.Combinegs_ReflectLogCondition();
        try {
            this.recCount = await gs_ReflectLog_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: 1,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortgs_TeacherTaskBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await gs_ReflectLog_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                var arrgs_ReflectLogObjLst: Array<clsgs_ReflectLogEN> = <Array<clsgs_ReflectLogEN>>jsonData;
               // this.BindTab_gs_ReflectLog(this.mstrListDiv, arrgs_TeacherTaskObjLst);
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `查询不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
   */
    public async btnAddNewRecord_Click() {
        this.opType = "Add";
        try {
            if (this.bolIsLoadEditRegion == false)  //
            {
                //   const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                //  ShowDialog_gs_TeacherTask('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecord();
            }
            else {
                //   ShowDialog_gs_TeacherTask('Add');
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
                //    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                //  ShowDialog_gs_TeacherTask('Add');
                this.bolIsLoadEditRegion = true;  //
                const responseText = this.AddNewRecordWithMaxId();
            }
            else {
                //      ShowDialog_gs_TeacherTask('Add');
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
    }


    /* 函数功能:为查询区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Js_BindDdl4QueryRegion)
   */
    public async BindDdl4QueryRegion() {
        // 在此处放置用户代码以初始化页面
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
         //   const responseBool = await this.AddDPV_Edit(this.divName4Edit);
            // 为编辑区绑定下拉框
            const conBindDdl = await this.BindDdl4EditRegion();
            ShowDialog_gs_TeacherTask('Update');
            this.bolIsLoadEditRegion = true;  //
            var lngKeyId = Number(strKeyId);
            this.UpdateRecord(lngKeyId);
        }
        else {
            ShowDialog_gs_TeacherTask('Update');
            var lngKeyId = Number(strKeyId);
            this.UpdateRecord(lngKeyId);
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
            var lngKeyId = Number(strKeyId);
            const responseText = await this.DelRecord(lngKeyId);
            const responseBindGv = await this.BindGv_gs_TeacherTask();
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
    //public async btnSelectRecordInTab_Click(strKeyId: string) {
    //    try {
    //        if (strKeyId == "") {
    //            alert("请选择需要删除的记录！");
    //            return "";
    //        }
    //        var lngKeyId = Number(strKeyId);
    //        this.SelectRecord(lngKeyId);
    //    }
    //    catch (e) {
    //        console.error('catch(e)=');
    //        console.error(e);
    //        var strMsg: string = `选择记录不成功. ${e}.`;
    //        alert(strMsg);
    //    }
    //}

    /* 
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
   */
    public async DelRecord(lngmId: number) {
        try {
            const responseText = await gs_ReflectLog_DelRecordAsync(lngmId);
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
    public async SelectRecord(lngmId: number) {
        try {
            const responseText = await gs_ReflectLog_GetObjBymIdAsync(lngmId);
            var objgs_ReflectLogEN: clsgs_ReflectLogEN = <clsgs_ReflectLogEN>responseText;
            console.log("完成SelectRecord!");
            Redirect("/Index/Main_gs_TeacherTask");
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
           // const responseBool = await this.AddDPV_Edit(this.divName4Edit);
            // 为编辑区绑定下拉框
            const conBindDdl = await this.BindDdl4EditRegion();
            ShowDialog_gs_TeacherTask('Update');
            this.bolIsLoadEditRegion = true;  //
            var lngKeyId = Number(strKeyId);
            this.UpdateRecord(lngKeyId);
        }
        else {
            ShowDialog_gs_TeacherTask('Update');
            var lngKeyId = Number(strKeyId);
            this.UpdateRecord(lngKeyId);
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
          //  const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_gs_TeacherTask();
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
    public async btnExportExcel_Click() {
        var strWhereCond = " 1=1 ";
        try {
            const responseText = await gs_ReflectLog_GetObjLstAsync(strWhereCond).then((jsonData) => {
                var arrgs_TeacherTaskObjLst: Array<clsgs_ReflectLogEN> = <Array<clsgs_ReflectLogEN>>jsonData;
              //  this.BindTab_gs_TeacherTask(this.mstrListDiv, arrgs_TeacherTaskObjLst);
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `导出Excel不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
   */
    public async btnSubmit_Click() {
        var strCommandText: string = this.btnSubmit_gs_TeacherTask;
        try {
            if (clsPublocalStorage.userId != "") {

                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
                            //var returnBool2: boolean = jsonData;
                            //if (returnBool2 == true)
                            //{
                            //HideDialog_gs_TeacherTask();
                            //this.BindGv_gs_TeacherTask();
                            //}
                            //});
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool: boolean = jsonData;
                                if (returnBool == true) {
                                    //HideDialog_gs_TeacherTask();
                                    //this.BindGv_gs_TeacherTask();
                                    CloseWindow();
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In gs_TeacherTaskCRUD.btnSubmit_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                //HideDialog_gs_TeacherTask();
                                //this.BindGv_gs_TeacherTask();

                                CloseWindow();
                            }

                        });
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnSubmit_Click())`
                        alert(strMsg);
                        break;
                }

            }
            else {
                alert("登录超时，请重新登录");
                window.top.location.href = "../Web/Login";
            }
            $("#divLoading").hide();

            //去掉提交按钮不可用状态
            $('#btnSubmit_gs_TeacherTask').attr("disabled", false);
        }
        catch (e) {
            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
            alert(strMsg);
        }
    }

   

   // /* 把所有的查询控件内容组合成一个条件串
   // (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
   //  <returns>条件串(strWhereCond)</returns>
   //*/
   // public Combinegs_TeacherTaskConditionObj(): clsgs_ReflectLogEN {
   //     //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
   //     //例如 1 = 1 && userName = '张三'
   //     var strWhereCond: string = " 1 = 1 ";
   //     var objgs_TeacherTask_Cond: clsgs_ReflectLogEN = new clsgs_ReflectLogEN();
   //     //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
   //     try {
   //         if (this.MissionStatement_q != "") {
   //             strWhereCond += ` And ${clsgs_ReflectLogEN.con_MissionStatement} like '% ${this.MissionStatement_q}%'`;
   //             objgs_TeacherTask_Cond.SetCondFldValue(clsgs_ReflectLogEN.con_MissionStatement, this.MissionStatement_q, "like");
   //         }
   //     }
   //     catch (objException) {
   //         var strMsg: string = `(errid:WiTsCs0008)在组合查询条件对象(Combinegs_TeacherTaskConditionObj)时出错!请联系管理员!${objException}`;
   //         throw strMsg;
   //     }
   //     return objgs_TeacherTask_Cond;
   // }

    /* 显示gs_TeacherTask对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrgs_TeacherTaskObjLst">需要绑定的对象列表</param>
   */
    //public async BindTab_gs_TeacherTask(divContainer: string, arrgs_TeacherTaskObjLst: Array<clsgs_ReflectLogEN>) {
    //    var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
    //    if (o == null) {
    //        alert(`${divContainer}不存在！`);
    //        return;
    //    }
    //    var arrDataColumn: Array<clsDataColumn> =
    //        [
    //            {
    //                fldName: "",
    //                colHeader: "",
    //                text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "CheckBox",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "missionStatement",
    //                colHeader: "任务说明",
    //                text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "missionRequirement",
    //                colHeader: "任务要求",
    //                text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "updDate",
    //                colHeader: "修改日期",
    //                text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "updUser",
    //                colHeader: "修改人",
    //                text: "", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Label",
    //                orderNum: 1,
    //                funcName: () => { }
    //            },
    //            {
    //                fldName: "",
    //                colHeader: "修改",
    //                text: "修改", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",

    //                columnType: "Button",
    //                orderNum: 1,
    //                funcName: (strKeyId: string, strText: string) => {
    //                    var btn1: HTMLElement = document.createElement("button");
    //                    btn1.innerText = strText;
    //                    btn1.className = "btn btn-outline-info btn-sm";
    //                    btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
    //                    return btn1;
    //                }
    //            },
    //            {
    //                fldName: "",
    //                colHeader: "删除",
    //                text: "删除", tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
    //                columnType: "Button",
    //                orderNum: 1,
    //                funcName: (strKeyId: string, strText: string) => {
    //                    var btn1: HTMLElement = document.createElement("button");
    //                    btn1.innerText = strText;
    //                    btn1.className = "btn btn-outline-info btn-sm";
    //                    btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
    //                    return btn1;
    //                }
    //            },
    //        ];
    //    BindTab(o, arrgs_TeacherTaskObjLst, arrDataColumn, "mId");
    //    this.objPager.recCount = this.recCount;
    //    this.objPager.pageSize = this.pageSize;
    //    this.objPager.ShowPagerV2(this, this.divName4Pager);
    //}

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
        this.BindGv_gs_TeacherTask();
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_gs_TeacherTask() {
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = await this.Combinegs_ReflectLogCondition();
        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        var arrgs_ReflectLogObjLst: Array<clsgs_ReflectLogEN> = [];
        try {
            this.recCount = await gs_ReflectLog_GetRecCountByCondAsync(strWhereCond);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortgs_TeacherTaskBy,
                sortFun: (x, y) => { return 0; }
            };
            arrgs_ReflectLogObjLst = await gs_ReflectLog_GetObjLstByPagerAsync(objPagerPara);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        if (arrgs_ReflectLogObjLst.length == 0) {
            var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            alert(strMsg);
            return;
        }
        try {
            //this.BindTab_gs_TeacherTask(strListDiv, arrgs_TeacherTaskObjLst);
            console.log("完成BindGv_gs_TeacherTask!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

   // /* 根据条件获取相应的对象列表
   //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
   //*/
   // public async BindGv_gs_TeacherTask_Cache() {
   //     var strListDiv: string = this.mstrListDiv;
   //     var objgs_TeacherTask_Cond = await this.Combinegs_TeacherTaskConditionObj();
   //     var strWhereCond = JSON.stringify(objgs_ReflectLogEN_Sim);
   //     var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
   //     var arrgs_TeacherTaskObjLst: Array<clsgs_ReflectLogEN> = [];
   //     try {
   //         this.recCount = await gs_ReflectLog_GetRecCountByCond_Cache(objgs_TeacherTask_Cond);
   //         var objPagerPara: stuPagerPara = {
   //             pageIndex: intCurrPageIndex,
   //             pageSize: this.pageSize,
   //             whereCond: strWhereCond,
   //             orderBy: this.hidSortgs_TeacherTaskBy
   //         };
   //         var arrgs_TeacherTaskObjLst = await gs_ReflectLog_GetObjLstByPager_Cache(objPagerPara);
   //     }
   //     catch (e) {
   //         console.error('catch(e)=');
   //         console.error(e);
   //         var strMsg: string = `绑定GridView不成功,${e}.`;
   //         alert(strMsg);
   //         return;
   //     }
   //     if (arrgs_TeacherTaskObjLst.length == 0) {
   //         var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=gs_TeacherTask)`;
   //         alert(strMsg);
   //         return;
   //     }
   //     try {
   //         this.BindTab_gs_TeacherTask(strListDiv, arrgs_TeacherTaskObjLst);
   //         console.log("完成BindGv_gs_TeacherTask!");
   //     }
   //     catch (e) {
   //         console.error('catch(e)=');
   //         console.error(e);
   //         var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
   //         alert(strMsg);
   //     }
   // }

    /* 函数功能:从界面列表中根据某一个字段排序
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
     <param name = "strSortByFld">排序的字段</param>
   */
    public async SortBy(strSortByFld: string) {
        if (this.hidSortgs_TeacherTaskBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortgs_TeacherTaskBy.indexOf("Asc") >= 0) {
                this.hidSortgs_TeacherTaskBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortgs_TeacherTaskBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortgs_TeacherTaskBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_gs_TeacherTask();
    }

    /// <summary>
    /// 清除用户自定义控件中，所有控件的值
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
    /// </summary>	
    public Clear() {
    }

   // /* 获取当前表关键字值的最大值,再加1,避免重复
   //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetMaxStrId)
   //*/
   // public async GetMaxStrId(strKeyCtrlName) {
   //     this.DivName = "divGetMaxStrId";
   //     try {
   //         const responseText = await gs_ReflectLog_GetMaxStrIdAsync();
   //         var returnString: string = responseText.toString();
   //         if (returnString == "") {
   //             var strInfo: string = `获取表gs_TeacherTask的最大关键字为空，不成功，请检查!`;
   //             $('#lblResult40').val(strInfo);
   //             //显示信息框
   //             alert(strInfo);
   //             $(strKeyCtrlName).val(returnString);
   //         }
   //         else {
   //             var strInfo: string = `获取表gs_TeacherTask的最大关键字为：${returnString}!`;
   //             $('#lblResult40').val(strInfo);
   //             //显示信息框
   //             alert(strInfo);
   //             $(strKeyCtrlName).val(returnString);
   //         }
   //     }
   //     catch (e) {
   //         console.error('catch(e)=');
   //         console.error(e);
   //         var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
   //         alert(strMsg);
   //     }
   // }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
   */
    public async AddNewRecord() {
        this.btnSubmit_gs_TeacherTask = "确认添加";
        this.btnCancel_gs_TeacherTask = "取消添加";
        this.Clear();
        //wucgs_TeacherTaskB1.mId = clsgs_TeacherTaskBL.GetMaxStrId_S();
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
   */
    public AddNewRecordWithMaxId() {
        this.btnSubmit_gs_TeacherTask = "确认添加";
        this.btnCancel_gs_TeacherTask = "取消添加";
        this.Clear();
        //wucgs_TeacherTaskB1.mId = clsgs_TeacherTaskBL.GetMaxStrId_S();
    }

    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjgs_ReflectLogEN">数据传输的目的类对象</param>
   */
    public PutDataTogs_TeacherTaskClass(pobjgs_ReflectLogEN: clsgs_ReflectLogEN) {
        var strTopicId = clsPrivateSessionStorage.topicId;
        pobjgs_ReflectLogEN.SetTopicId(strTopicId);// 主题编号
        pobjgs_ReflectLogEN.SetReflectLogName(this.reflectLogName);// 名称
        pobjgs_ReflectLogEN.SetReflectLogContent(this.reflectLogContent);// 内容
        pobjgs_ReflectLogEN.SetUpdDate(clsPubFun4Web.getNowDate_ymd());// 修改日期
        pobjgs_ReflectLogEN.SetUpdUser(clsPublocalStorage.userId);// 修改人
        pobjgs_ReflectLogEN.SetMemo(this.memo);// 备注
    }


    /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        var objgs_ReflectLogEN: clsgs_ReflectLogEN = new clsgs_ReflectLogEN();
        this.PutDataTogs_TeacherTaskClass(objgs_ReflectLogEN);
        try {
            const responseText2 = await gs_ReflectLog_AddNewRecordAsync(objgs_ReflectLogEN);
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

    /* 函数功能:把以该关键字的记录内容显示在界面上,
          在这里是把值传到表控件中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
     <param name = "lngmId">表记录的关键字,显示该表关键字的内容</param>
   */
    public async ShowData(lngmId: number) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objgs_ReflectLogEN: clsgs_ReflectLogEN = new clsgs_ReflectLogEN();
        try {
            const responseText = await gs_ReflectLog_IsExistAsync(lngmId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${lngmId}] 的记录不存在!`;
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
            const responseText = await gs_ReflectLog_GetObjBymIdAsync(lngmId);
            objgs_ReflectLogEN = <clsgs_ReflectLogEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromgs_TeacherTaskClass(objgs_ReflectLogEN);
    }

    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjgs_ReflectLogEN">表实体类对象</param>
   */
    public GetDataFromgs_TeacherTaskClass(pobjgs_ReflectLogEN: clsgs_ReflectLogEN) {
        this.topicId = pobjgs_ReflectLogEN.topicId;// 主题编号
        this.reflectLogName = pobjgs_ReflectLogEN.reflectLogName;// 名称
        this.reflectLogContent = pobjgs_ReflectLogEN.reflectLogContent;// 内容
        this.updDate = pobjgs_ReflectLogEN.updDate;// 修改日期
        this.updUser = pobjgs_ReflectLogEN.updUser;// 修改人
        this.memo = pobjgs_ReflectLogEN.memo;// 备注
    }

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public async UpdateRecord(lngmId: number) {
        this.btnSubmit_gs_TeacherTask = "确认修改";
        this.btnCancel_gs_TeacherTask = "取消修改";
        this.keyId = lngmId.toString();
        try {
            const responseText = await gs_ReflectLog_GetObjBymIdAsync(lngmId);
            var objgs_ReflectLogEN: clsgs_ReflectLogEN = <clsgs_ReflectLogEN>responseText;
            this.GetDataFromgs_TeacherTaskClass(objgs_ReflectLogEN);
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

        
        var objgs_ReflectLogEN: clsgs_ReflectLogEN = new clsgs_ReflectLogEN();
        objgs_ReflectLogEN.SetmId(Number(this.keyId));
        this.PutDataTogs_TeacherTaskClass(objgs_ReflectLogEN);
        objgs_ReflectLogEN.sfUpdFldSetStr = objgs_ReflectLogEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objgs_ReflectLogEN.mId == 0 || objgs_ReflectLogEN.mId == undefined) {
             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        }
        try {
            const responseText = await gs_ReflectLog_UpdateRecordAsync(objgs_ReflectLogEN);
            var returnBool: boolean = !!responseText;
            if (returnBool == true) {
                //gs_ReflectLog_ReFreshCache();
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

   // /* 根据关键字列表删除记录
   //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
   //*/
   // public async DelMultiRecord(arrmId: Array<string>) {
   //     try {
   //         const responseText = await gs_ReflectLog_Delgs_TeacherTasksAsync(arrmId);
   //         var returnInt: number = responseText;
   //         if (returnInt > 0) {
   //             var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
   //             //显示信息框
   //             alert(strInfo);
   //         }
   //         else {
   //             var strInfo: string = `删除记录不成功!`;
   //             //显示信息框
   //             alert(strInfo);
   //         }
   //         console.log("完成DelMultiRecord!");
   //     }
   //     catch (e) {
   //         console.error('catch(e)=');
   //         console.error(e);
   //         var strMsg: string = `删除记录不成功. ${e}.`;
   //         alert(strMsg);
   //     }
   // }

    /* 显示{0}对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
     <param name = "divContainer">显示容器</param>
     <param name = "objgs_TeacherTask">需要显示的对象</param>
   */
    public Showgs_TeacherTaskObj(divContainer: string, objgs_TeacherTask: clsgs_ReflectLogEN) {
      
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrKeys = GetObjKeys(objgs_TeacherTask);
        var ul: HTMLUListElement = document.createElement("ul");
        for (let strKey of sstrKeys) {
            var strValue = objgs_TeacherTask[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = `${strKey}:${strValue}`;
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /* 函数功能:从界面列表中获取第一个关键字的值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
     <param name = "pobjgs_ReflectLogEN">表实体类对象</param>
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
    演示Session 操作
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Demo_Session)
    */
    public async Demo_Session() {
        try {
            //设置Session
            var strUserId = "TestUserId";
            await this.SetSessionAsync("userId", strUserId);
            //获取Session
            var strUserId_Value1 = await this.GetSessionAsync("userId");
            console.log('strUserId_Value1:' + strUserId_Value1);
            //获取Session方法2：直接读取页面中的hidUserId
            var strUserId_Value2 = this.hidUserId;
            console.log('strUserId_Value2:' + strUserId_Value2);
        }
        catch (e) {
            var strMsg: string = `演示Session不成功,${e}.`;
            alert(strMsg);
        }
    }

    /*
    设置Session
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
    <param name = "Key">关键字</param>
    <param name = "Value">值</param>
    */
    public SetSessionAsync(Key: string, Value: string): Promise<void> {
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl_Session_SetString,
                cache: false,
                async: false,
                type: 'get',
                dataType: "json",
                data: {
                    Key: Key,
                    Value: Value
                },
                success: function (data) {
                    var strKey = data.key;
                    var strValue = data.value;
                    console.log('strKey, strValue=' + strKey + strValue);
                }
            });
        });
    }

    /*
    获取Session 关键字的值
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetSessionAsync)
    <param name = "Key">关键字</param>
     <return>值</return>
    */
    public GetSessionAsync(Key: string): Promise<string> {
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl_Session_GetString,
                cache: false,
                async: false,
                type: 'get',
                dataType: "json",
                data: {
                    Key: Key,
                },
                success: function (data) {
                    var strKey = data.key;
                    var strValue = data.value;
                    console.log('strKey, strValue=' + strKey + strValue);
                    resolve(data);
                },
                error: function (result) {
                    console.log(result);
                    console.log(JSON.stringify(result));
                    if (result.statusText == "error") {
                        var strInfo = `网络错误！访问网络不成功！`;
                        reject(strInfo);
                    }
                    else {
                        reject(result.statusText);
                    }
                }
            });
        });
    }
    /*
    * 设置取消按钮的标题
   */
    public set btnCancel_gs_TeacherTask(value: string) {
        $("#btnCancel_gs_TeacherTask").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnSubmit_gs_TeacherTask(): string {
        return $("#btnSubmit_gs_TeacherTask").html();
    }
    /*
    * 设置确定按钮的标题
   */
    public set btnSubmit_gs_TeacherTask(value: string) {
        $("#btnSubmit_gs_TeacherTask").html(value);
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
    * 设置排序字段-相当使用ViewState功能
   */
    public set hidSortgs_TeacherTaskBy(value: string) {
        $("#hidSortgs_TeacherTaskBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortgs_TeacherTaskBy(): string {
        return $("#hidSortgs_TeacherTaskBy").val();
    }
    /*
    * 用户Id
   */
    public get hidUserId(): string {
        return clsPublocalStorage.userId;
    }
    /*
    * 当前教学班流水号
   */
    public set id_CurrEduCls(value: string) {
        $("#txtid_CurrEduCls").val(value);
    }
    /*
    * 当前教学班流水号
   */
    public get id_CurrEduCls(): string {
        return $("#txtid_CurrEduCls").val();
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
    * 名称
   */
    public set reflectLogName(value: string) {
        $("#txtReflectLogName").val(value);
    }
    /*
    * 名称
   */
    public get reflectLogName(): string {
        return $("#txtReflectLogName").val();
    }
    /*
    * 内容
   */
    public set reflectLogContent(value: string) {
        $("#txtReflectLogContent").val(value);
    }
    /*
    * 内容
   */
    public get reflectLogContent(): string {
        return $("#txtReflectLogContent").val();
    }
    /*
    * 任务说明
   */
    public get MissionStatement_q(): string {
        return $("#txtMissionStatement_q").val();
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
    * 主题编号
   */
    public set topicId(value: string) {
        $("#txtTopicId").val(value);
    }
    /*
    * 主题编号
   */
    public get topicId(): string {
        return $("#txtTopicId").val();
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
}