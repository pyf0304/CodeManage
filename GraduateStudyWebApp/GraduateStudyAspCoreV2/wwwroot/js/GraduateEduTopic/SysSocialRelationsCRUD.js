"use strict";
///*-- -- -- -- -- -- -- -- -- -- --
//类名:SysSocialRelationsCRUD
//表名:SysSocialRelations(01120644)
//生成代码版本:2020.05.18.1
//生成日期:2020/05/22 18:59:56
//生成者:
//工程名称:问卷调查
//工程ID:0112
//相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
//PrjDataBaseId:0122
//模块中文名:研究生培养
//模块英文名:GraduateEdu
//框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
//编程语言:TypeScript
//== == == == == == == == == == == ==
//*/
/////// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
/////// <reference path="../../scripts/typings/q/q.d.ts" />
/////// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
////
////import * as QQ from "q";
//import { clsSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js";
//import { clsvSysSocialRelationsEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js";
//import { clsSysSecurityLevelEN } from "../TS/L0_Entity/ParameterTable/clsSysSecurityLevelEN.js";
//import { arrSelectedKeys } from "../TS/PubFun/clsCommonFunc4Web2.js";
//import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
//import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
//import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
//
//import { vSysSocialRelations_GetObjLstAsync, vSysSocialRelations_GetObjLstByPagerAsync, vSysSocialRelations_GetObjLstByPager_Cache, vSysSocialRelations_GetRecCountByCondAsync, vSysSocialRelations_GetRecCountByCond_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js";
//import { SysSecurityLevel_BindDdl_LevelIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js";
//import { SysSocialRelations_AddNewRecordAsync, SysSocialRelations_AddNewRecordWithMaxIdAsync, SysSocialRelations_DelRecordAsync, SysSocialRelations_DelSysSocialRelationssAsync, SysSocialRelations_GetMaxStrIdAsync, SysSocialRelations_GetObjBySocialIdAsync, SysSocialRelations_IsExistAsync, SysSocialRelations_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js";
///*
//* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
//* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
//*/
//declare function ShowDialog(strOpType): void;
///*
//* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
//*/
//declare function HideDialog(): void;
///*
//* 宣布一个已经在其他地方定义存在的变量strUrl_Session_SetString，
//* 用于定义处理Session-设置String函数的地址
//*/
//declare var strUrl_Session_SetString;
//declare var strUrl_Session_GetString;
///*
//* 宣布一个已经在其他地方定义存在的变量strCurrPrjId，
//* 用于定义当前工程Id
//*/
//declare var strCurrPrjId;
//declare var $;
//declare var window;
///* SysSocialRelationsCRUD 的摘要说明。其中Q代表查询,U代表修改
// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
//*/
//export class SysSocialRelationsCRUD extends clsOperateList{
//    public static strid_CurrEduCls_Cache: string = "00000001";
//    public mstrListDiv: string = "divDataLst";
//    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
//    public divName4Edit: string = "divEdit";  //记录是否导入编辑区的变量
//    /*
//    * 每页记录数，在扩展类可以修改
//   */
//    public get pageSize(): number {
//        return 5;
//    }
//    public recCount = 0;
//    /* 函数功能:页面导入,当页面开始运行时所发生的事件
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
//   */
//    public async Page_Load() {
//        // 在此处放置用户代码以初始化页面
//        try {
//            //建立缓存
//            // 为查询区绑定下拉框
//            const gvBindDdl = await this.BindDdl4QueryRegion();
//            this.hidSortvSysSocialRelationsBy = "fullName Asc";
//            if (this.bolIsInitShow == false)  //
//            {
//                this.objPager.InitShow(this.divName4Pager);
//                this.bolIsInitShow = true;  //
//            }
//            //2、显示无条件的表内容在GridView中
//            const gvResult = await this.BindGv_vSysSocialRelations();
//        }
//        catch (e) {
//            var strMsg: string = `页面启动不成功,${e}.`;
//            alert(strMsg);
//        }
//    }
//    /// <summary>
//    /// 在当前界面中，导入编辑区域
//    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
//    /// </summary>
//    /// <returns></returns>
//    public async AddDPV_Edit(divName4Edit) {
//        var strUrl: string = "./SysSocialRelations_Edit/";
//        console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "GET",
//                dataType: "html",
//                data: {},
//                success: function (data) {
//                    console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
//                    $('#' + divName4Edit).html(data);
//                    resolve(true);
//                    //setTimeout(() => { clsEditObj.BindTab(); }, 100);
//                    //clsEditObj.BindTab();
//                },
//                error: (e) => {
//                    console.error(e);
//                    reject(e);
//                }
//            });
//        });
//    };
//    /* 函数功能:页面导入,当页面开始运行时所发生的事件
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
//   */
//    public async Page_Load_Cache() {
//        // 在此处放置用户代码以初始化页面
//        try {
//            // 为查询区绑定下拉框
//            const gvBindDdl = await this.BindDdl4QueryRegion();
//            this.hidSortvSysSocialRelationsBy = "fullName Asc";
//            //2、显示无条件的表内容在GridView中
//            const gvResult = await this.BindGv_vSysSocialRelations_Cache();
//        }
//        catch (e) {
//            var strMsg: string = `页面启动不成功,${e}.`;
//            alert(strMsg);
//        }
//    }
//    /* 根据条件获取相应的对象列表
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
//   */
//    public async btnQuery_Click() {
//        const responseObjLst = await this.BindGv_vSysSocialRelations();
//        //var strWhereCond = await this.CombinevSysSocialRelationsCondition();
//        //try
//        //{
//        //this.recCount = await vSysSocialRelations_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
//        
//        //});
//        //var objPagerPara: stuPagerPara = {
//        //pageIndex: 1,
//        //pageSize: this.pageSize,
//        //whereCond: strWhereCond,
//        //orderBy: this.hidSortvSysSocialRelationsBy
//        //};
//        //const responseObjLst = await vSysSocialRelations_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
//        //var arrvSysSocialRelationsObjLst : Array<clsvSysSocialRelationsEN> = < Array<clsvSysSocialRelationsEN>>jsonData;
//        //this.BindTab_vSysSocialRelations(this.mstrListDiv, arrvSysSocialRelationsObjLst);
//        //});
//        //}
//        //catch(e)
//        //{
//        //console.error('catch(e)=');
//        //console.error(e);
//        //var strMsg: string = `查询不成功,${e}.`;
//        //alert(strMsg);
//        //}
//    }
//    /* 添加新记录
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
//   */
//    public async btnAddNewRecord_Click() {
//        this.opType = "Add";
//        try {
//            if (this.bolIsLoadEditRegion == false)  //
//            {
//                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
//                // 为编辑区绑定下拉框
//                const conBindDdl = await this.BindDdl4EditRegion();
//                ShowDialog('Add');
//                this.bolIsLoadEditRegion = true;  //
//                const responseText = this.AddNewRecord();
//            }
//            else {
//                ShowDialog('Add');
//                const responseText = await this.AddNewRecord();
//            }
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `添加新记录初始化不成功,${e}.`;
//            alert(strMsg);
//        }
//    }
//    /* 函数功能:为编辑区绑定下拉框
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
//   */
//    public async BindDdl4EditRegion() {
//        // 在此处放置用户代码以初始化页面
//        var objSysSecurityLevel_Cond: clsSysSecurityLevelEN = new clsSysSecurityLevelEN();//编辑区域
//        const ddlLevelId = await SysSecurityLevel_BindDdl_LevelIdInDiv_Cache(this.divName4List, "ddlLevelId");//编辑区域
//    }
//    /* 添加新记录
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
//   */
//    public async btnAddNewRecordWithMaxId_Click() {
//        this.opType = "AddWithMaxId";
//        try {
//            if (this.bolIsLoadEditRegion == false)  //
//            {
//                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
//                // 为编辑区绑定下拉框
//                const conBindDdl = await this.BindDdl4EditRegion();
//                ShowDialog('Add');
//                this.bolIsLoadEditRegion = true;  //
//                const responseText = this.AddNewRecordWithMaxId();
//            }
//            else {
//                ShowDialog('Add');
//                const responseText = this.AddNewRecordWithMaxId();
//            }
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `添加新记录初始化不成功,${e}.`;
//            alert(strMsg);
//        }
//    }
//    /* 函数功能:为查询区绑定下拉框
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Js_BindDdl4QueryRegion)
//   */
//    public async BindDdl4QueryRegion() {
//        // 在此处放置用户代码以初始化页面
//        var objSysSecurityLevel_Cond: clsSysSecurityLevelEN = new clsSysSecurityLevelEN();//查询区域
//        const ddlLevelId_q = await SysSecurityLevel_BindDdl_LevelIdInDiv_Cache(this.divName4List, "ddlLevelId_q");//查询区域
//    }
//    /* 在数据表里修改记录
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
//   */
//    public async btnUpdateRecordInTab_Click(strKeyId: string) {
//        this.opType = "Update";
//        if (strKeyId == "") {
//            alert("请选择需要修改的记录！");
//            return;
//        }
//        if (this.bolIsLoadEditRegion == false)  //
//        {
//            const responseBool = await this.AddDPV_Edit(this.divName4Edit);
//            // 为编辑区绑定下拉框
//            const conBindDdl = await this.BindDdl4EditRegion();
//            ShowDialog('Update');
//            this.bolIsLoadEditRegion = true;  //
//            this.UpdateRecord(strKeyId);
//        }
//        else {
//            ShowDialog('Update');
//            this.UpdateRecord(strKeyId);
//        }
//    }
//    /*
//    在数据表里删除记录
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
//   */
//    public async btnDelRecordInTab_Click(strKeyId: string) {
//        try {
//            if (strKeyId == "") {
//                alert("请选择需要删除的记录！");
//                return "";
//            }
//            const responseText = await this.DelRecord(strKeyId);
//            const responseBindGv = await this.BindGv_vSysSocialRelations();
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `删除记录不成功. ${e}.`;
//            alert(strMsg);
//        }
//    }
//    /*
//    在数据表里选择记录
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
//   */
//    public async btnSelectRecordInTab_Click(strKeyId: string) {
//        try {
//            if (strKeyId == "") {
//                alert("请选择需要删除的记录！");
//                return "";
//            }
//            this.SelectRecord(strKeyId);
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `选择记录不成功. ${e}.`;
//            alert(strMsg);
//        }
//    }
//    /*
//    在数据表里详细信息记录
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecordInTab_Click)
//   */
//    public async btnDetailRecordInTab_Click(strKeyId: string) {
//        this.opType = "Detail";
//        try {
//            if (strKeyId == "") {
//                alert("请选择需要详细信息的记录！");
//                return "";
//            }
//            this.DetailRecord(strKeyId);
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `详细信息记录不成功. ${e}.`;
//            alert(strMsg);
//        }
//    }
//    /*
//    根据关键字删除记录
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
//   */
//    public async DelRecord(strSocialId: string) {
//        try {
//            const responseText = await SysSocialRelations_DelRecordAsync(strSocialId);
//            var returnInt: number = responseText;
//            if (returnInt > 0) {
//                var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
//                //显示信息框
//                alert(strInfo);
//            }
//            else {
//                var strInfo: string = `删除记录不成功!`;
//                //显示信息框
//                alert(strInfo);
//            }
//            console.log("完成DelRecord!");
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `删除记录不成功. ${e}.`;
//            alert(strMsg);
//        }
//    }
//    /*
//    根据关键字详细信息记录
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
//     <param name = "sender">参数列表</param>
//   */
//    public async DetailRecord(strSocialId: string) {
//        this.btnOKUpd = "";
//        this.btnCancel = "关闭";
//        try {
//            const responseText = await SysSocialRelations_GetObjBySocialIdAsync(strSocialId);
//            var objSysSocialRelationsEN: clsSysSocialRelationsEN = <clsSysSocialRelationsEN>responseText;
//            this.GetDataFromSysSocialRelationsClass(objSysSocialRelationsEN);
//            console.log("完成DetailRecord!");
//        }
//        catch (e) {
//            console.error(e);
//            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
//            alert(strMsg);
//        }
//    }
//    /*
//    根据关键字选择相应的记录
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
//     <param name = "sender">参数列表</param>
//   */
//    public async SelectRecord(strSocialId: string) {
//        try {
//            const responseText = await SysSocialRelations_GetObjBySocialIdAsync(strSocialId);
//            var objSysSocialRelationsEN: clsSysSocialRelationsEN = <clsSysSocialRelationsEN>responseText;
//            console.log("完成SelectRecord!");
//            Redirect("/Index/Main_vSysSocialRelations");
//        }
//        catch (e) {
//            console.error(e);
//            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
//            alert(strMsg);
//        }
//    }
//    /* 修改记录
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
//   */
//    public async btnUpdateRecord_Click(strKeyId:string) {
//        this.opType = "Update";
//        //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
//        if (strKeyId == "") {
//            alert("请选择需要修改的记录！");
//            return;
//        }
//        if (this.bolIsLoadEditRegion == false)  //
//        {
//            const responseBool = await this.AddDPV_Edit(this.divName4Edit);
//            // 为编辑区绑定下拉框
//            const conBindDdl = await this.BindDdl4EditRegion();
//            ShowDialog('Update');
//            this.bolIsLoadEditRegion = true;  //
//            this.UpdateRecord(strKeyId);
//        }
//        else {
//            ShowDialog('Update');
//            this.UpdateRecord(strKeyId);
//        }
//    }
//    /* 删除记录
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
//   */
//    public async btnDelRecord_Click() {
//        try {
//            var arrKeyIds = GetCheckedKeyIds();
//            if (arrKeyIds.length == 0) {
//                alert("请选择需要删除的记录！");
//                return "";
//            }
//            const responseText = await this.DelMultiRecord(arrKeyIds);
//            const responseBindGv = await this.BindGv_vSysSocialRelations();
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `删除记录不成功. ${e}.`;
//            alert(strMsg);
//        }
//    }
//    /* 根据条件获取相应的对象列表
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
//   */
//    public async btnExportExcel_Click() {
//        var strWhereCond = " 1=1 ";
//        try {
//            const responseText = await vSysSocialRelations_GetObjLstAsync(strWhereCond).then((jsonData) => {
//                var arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN> = <Array<clsvSysSocialRelationsEN>>jsonData;
//                this.BindTab_vSysSocialRelations(this.mstrListDiv, arrvSysSocialRelationsObjLst);
//            });
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `导出Excel不成功,${e}.`;
//            alert(strMsg);
//        }
//    }
//    /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
//     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
//   */
//    public async btnOKUpd_Click() {
//        var strCommandText: string = this.btnOKUpd;
//        try {
//            switch (strCommandText) {
//                case "添加":
//                    const responseText1 = await this.AddNewRecord();
//                    break;
//                case "确认添加":
//                    //这是一个单表的插入的代码,由于逻辑层太简单,
//                    //就把逻辑层合并到控制层,
//                    if (this.opType == "AddWithMaxId") {
//                        const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
//                            var returnBool2: string = <string>jsonData;
//                            if (IsNullOrEmpty(returnBool2) == false) {
//                                HideDialog();
//                                this.BindGv_vSysSocialRelations();
//                            }
//                        });
//                    }
//                    else {
//                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
//                            var returnBool: boolean = jsonData;
//                            if (returnBool == true) {
//                                HideDialog();
//                                this.BindGv_vSysSocialRelations();
//                            }
//                        });
//                    }
//                    break;
//                case "确认修改":
//                    //这是一个单表的修改的代码,由于逻辑层太简单,
//                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
//                        var returnBool: boolean = jsonData;
//                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
//                        strInfo += "(In SysSocialRelationsCRUD.btnOKUpd_Click)";
//                        $('#lblResult51').val(strInfo);
//                        //显示信息框
//                        console.log(strInfo);
//                        alert(strInfo);
//                        if (returnBool == true) {
//                            HideDialog();
//                            this.BindGv_vSysSocialRelations();
//                        }
//                    });
//                    break;
//                default:
//                    var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`
//                    alert(strMsg);
//                    break;
//            }
//        }
//        catch (e) {
//            var strMsg: string = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
//            alert(strMsg);
//        }
//    }
//    /* 把所有的查询控件内容组合成一个条件串
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
//     <returns>条件串(strWhereCond)</returns>
//   */
//    public async CombinevSysSocialRelationsCondition():Promise<string>  {
//        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//        //例如 1 = 1 && userName = '张三'
//        var strWhereCond: string = " 1 = 1 ";
//        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
//        try {
//            if (this.fullName_q != "") {
//                strWhereCond += ` And ${clsvSysSocialRelationsEN.con_FullName} like '% ${this.fullName_q}%'`;
//            }
//            if (this.achievement_q != "") {
//                strWhereCond += ` And ${clsvSysSocialRelationsEN.con_Achievement} like '% ${this.achievement_q}%'`;
//            }
//            if (this.levelId_q != "" && this.levelId_q != "0") {
//                strWhereCond += ` And ${clsvSysSocialRelationsEN.con_LevelId} = '${this.levelId_q}'`;
//            }
//        }
//        catch (objException) {
//            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineSysSocialRelationsCondition)时出错!请联系管理员!${objException}`;
//            throw strMsg;
//        }
//        return strWhereCond;
//    }
//    /* 把所有的查询控件内容组合成一个条件串
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
//     <returns>条件串(strWhereCond)</returns>
//   */
//    public CombinevSysSocialRelationsConditionObj(): clsvSysSocialRelationsEN {
//        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//        //例如 1 = 1 && userName = '张三'
//        var strWhereCond: string = " 1 = 1 ";
//        var objvSysSocialRelations_Cond: clsvSysSocialRelationsEN = new clsvSysSocialRelationsEN();
//        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
//        try {
//            if (this.fullName_q != "") {
//                strWhereCond += ` And ${clsvSysSocialRelationsEN.con_FullName} like '% ${this.fullName_q}%'`;
//                objvSysSocialRelations_Cond.SetCondFldValue(clsvSysSocialRelationsEN.con_FullName, this.fullName_q, "like");
//            }
//            if (this.achievement_q != "") {
//                strWhereCond += ` And ${clsvSysSocialRelationsEN.con_Achievement} like '% ${this.achievement_q}%'`;
//                objvSysSocialRelations_Cond.SetCondFldValue(clsvSysSocialRelationsEN.con_Achievement, this.achievement_q, "like");
//            }
//            if (this.levelId_q != "" && this.levelId_q != "0") {
//                strWhereCond += ` And ${clsvSysSocialRelationsEN.con_LevelId} = '${this.levelId_q}'`;
//                objvSysSocialRelations_Cond.SetCondFldValue(clsvSysSocialRelationsEN.con_LevelId, this.levelId_q, "=");
//            }
//        }
//        catch (objException) {
//            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombineSysSocialRelationsConditionObj)时出错!请联系管理员!${objException}`;
//            throw strMsg;
//        }
//        return objvSysSocialRelations_Cond;
//    }
//    /* 显示vSysSocialRelations对象的所有属性值
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
//     <param name = "divContainer">显示容器</param>
//     <param name = "arrSysSocialRelationsObjLst">需要绑定的对象列表</param>
//   */
//    public async BindTab_vSysSocialRelations(divContainer: string, arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN>) {
//        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
//        if (o == null) {
//            alert(`${divContainer}不存在！`);
//            return;
//        }
//        var arrDataColumn: Array<clsDataColumn> =
//            [
//                {
//                    fldName: "",
//                    colHeader: "",
//                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "CheckBox",
//                    orderNum: 1,
//                    funcName: () => { }
//                },
//                {
//                    fldName: "fullName",
//                    colHeader: "姓名",
//                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Label",
//                    orderNum: 1,
//                    funcName: () => { }
//                },
//                {
//                    fldName: "nationality",
//                    colHeader: "国籍",
//                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Label",
//                    orderNum: 1,
//                    funcName: () => { }
//                },
//                {
//                    fldName: "workUnit",
//                    colHeader: "工作单位",
//                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Label",
//                    orderNum: 1,
//                    funcName: () => { }
//                },
//                {
//                    fldName: "major",
//                    colHeader: "专业",
//                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Label",
//                    orderNum: 1,
//                    funcName: () => { }
//                },
//                {
//                    fldName: "achievement",
//                    colHeader: "成就",
//                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Label",
//                    orderNum: 1,
//                    funcName: () => { }
//                },
//                {
//                    fldName: "detailedDescription",
//                    colHeader: "详细说明",
//                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Label",
//                    orderNum: 1,
//                    funcName: () => { }
//                },
//                {
//                    fldName: "levelName",
//                    colHeader: "级别名称",
//                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Label",
//                    orderNum: 1,
//                    funcName: () => { }
//                },
//                {
//                    fldName: "updUser",
//                    colHeader: "修改人",
//                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Label",
//                    orderNum: 1,
//                    funcName: () => { }
//                },
//                {
//                    fldName: "updDate",
//                    colHeader: "修改日期",
//                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Label",
//                    orderNum: 1,
//                    funcName: () => { }
//                },
//                {
//                    fldName: "isSubmit",
//                    colHeader: "是否提交",
//                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Label",
//                    orderNum: 1,
//                    funcName: () => { }
//                },
//                {
//                    fldName: "",
//                    colHeader: "修改",
//                    text: "修改",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Button",
//                    orderNum: 1,
//                    funcName: (strKeyId: string, strText: string) => {
//                        var btn1: HTMLElement = document.createElement("button");
//                        btn1.innerText = strText;
//                        btn1.className = "btn btn-outline-info btn-sm";
//                        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
//                        return btn1;
//                    }
//                },
//                {
//                    fldName: "",
//                    colHeader: "删除",
//                    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
//                    columnType: "Button",
//                    orderNum: 1,
//                    funcName: (strKeyId: string, strText: string) => {
//                        var btn1: HTMLElement = document.createElement("button");
//                        btn1.innerText = strText;
//                        btn1.className = "btn btn-outline-info btn-sm";
//                        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
//                        return btn1;
//                    }
//                },
//            ];
//        BindTab(o, arrvSysSocialRelationsObjLst, arrDataColumn, "socialId");
//        this.objPager.recCount = this.recCount;
//        this.objPager.pageSize = this.pageSize;
//        this.objPager.ShowPagerV2(this, this.divName4Pager);
//    }
//    /* 函数功能:在数据 列表中跳转到某一页
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
//     <param name = "intPageIndex">页序号</param>
//   */
//    public async IndexPage(intPageIndex) {
//        if (intPageIndex == 0) {
//            intPageIndex = this.objPager.pageCount;
//        }
//        console.log("跳转到" + intPageIndex + "页");
//        this.setCurrPageIndex(intPageIndex, this.divName4Pager);
//        this.BindGv_vSysSocialRelations();
//    }
//    /* 根据条件获取相应的对象列表
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
//   */
//    public async BindGv_vSysSocialRelations() {
//        var strListDiv: string = this.mstrListDiv;
//        var strWhereCond = await this.CombinevSysSocialRelationsCondition();
//        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
//        var arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN> = [];
//        try {
//            this.recCount = await vSysSocialRelations_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
//            });
//            var objPagerPara: stuPagerPara = {
//                pageIndex: intCurrPageIndex,
//                pageSize: this.pageSize,
//                whereCond: strWhereCond,
//                orderBy: this.hidSortvSysSocialRelationsBy,
//                sortFun: (x, y) => { return 0; }
//            };
//            const responseObjLst = await vSysSocialRelations_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
//                arrvSysSocialRelationsObjLst = <Array<clsvSysSocialRelationsEN>>jsonData;
//            });
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `绑定GridView不成功,${e}.`;
//            alert(strMsg);
//        }
//        if (arrvSysSocialRelationsObjLst.length == 0) {
//            var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
//            alert(strMsg);
//            return;
//        }
//        try {
//            this.BindTab_vSysSocialRelations(strListDiv, arrvSysSocialRelationsObjLst);
//            console.log("完成BindGv_vSysSocialRelations!");
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
//            alert(strMsg);
//        }
//    }
//    /* 根据条件获取相应的对象列表
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
//   */
//    public async BindGv_vSysSocialRelations_Cache() {
//        var strListDiv: string = this.mstrListDiv;
//        var objvSysSocialRelations_Cond = this.CombinevSysSocialRelationsConditionObj();
//        objvSysSocialRelations_Cond.SetCondFldValue(clsvSysSocialRelationsEN.con_id_CurrEduCls, SysSocialRelationsCRUD.strid_CurrEduCls_Cache, "=");
//        var strWhereCond = JSON.stringify(objvSysSocialRelations_Cond);
//        var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
//        var arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN> = [];
//        try {
//            this.recCount = await vSysSocialRelations_GetRecCountByCond_Cache(objvSysSocialRelations_Cond, SysSocialRelationsCRUD.strid_CurrEduCls_Cache);
//            var objPagerPara: stuPagerPara = {
//                pageIndex: intCurrPageIndex,
//                pageSize: this.pageSize,
//                whereCond: strWhereCond,
//                orderBy: this.hidSortvSysSocialRelationsBy,
//                sortFun: (x, y) => { return 0; }
//            };
//            var arrvSysSocialRelationsObjLst = await vSysSocialRelations_GetObjLstByPager_Cache(objPagerPara, SysSocialRelationsCRUD.strid_CurrEduCls_Cache);
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `绑定GridView不成功,${e}.`;
//            alert(strMsg);
//        }
//        if (arrvSysSocialRelationsObjLst.length == 0) {
//            var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=SysSocialRelations_${SysSocialRelationsCRUD.strid_CurrEduCls_Cache})`;
//            alert(strMsg);
//            return;
//        }
//        try {
//            this.BindTab_vSysSocialRelations(strListDiv, arrvSysSocialRelationsObjLst);
//            console.log("完成BindGv_vSysSocialRelations!");
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
//            alert(strMsg);
//        }
//    }
//    /* 函数功能:从界面列表中根据某一个字段排序
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
//     <param name = "strSortByFld">排序的字段</param>
//   */
//    public async SortBy(strSortByFld: string) {
//        if (this.hidSortvSysSocialRelationsBy.indexOf(strSortByFld) >= 0) {
//            if (this.hidSortvSysSocialRelationsBy.indexOf("Asc") >= 0) {
//                this.hidSortvSysSocialRelationsBy = `${strSortByFld} Desc`;
//            }
//            else {
//                this.hidSortvSysSocialRelationsBy = `${strSortByFld} Asc`;
//            }
//        }
//        else {
//            this.hidSortvSysSocialRelationsBy = `${strSortByFld} Asc`;
//        }
//        const responseBindGv = await this.BindGv_vSysSocialRelations();
//    }
//    /// <summary>
//    /// 在用户自定义控件中，设置关键字的值，是否只读
//    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
//    /// </summary>
//    /// <param name = "bolReadonly">是否只读</param>
//    public SetKeyReadOnly(bolReadonly: boolean) {
//        $('#txtSocialId').prop['ReadOnly'] = bolReadonly;
//    }
//    /// <summary>
//    /// 清除用户自定义控件中，所有控件的值
//    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
//    /// </summary>	
//    public Clear() {
//    }
//    /* 获取当前表关键字值的最大值,再加1,避免重复
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetMaxStrId)
//   */
//    public async GetMaxStrId(strKeyCtrlName) {
//        this.DivName = "divGetMaxStrId";
//        try {
//            const responseText = await SysSocialRelations_GetMaxStrIdAsync();
//            var returnString: string = responseText.toString();
//            if (returnString == "") {
//                var strInfo: string = `获取表SysSocialRelations的最大关键字为空，不成功，请检查!`;
//                $('#lblResult40').val(strInfo);
//                //显示信息框
//                alert(strInfo);
//                $(strKeyCtrlName).val(returnString);
//            }
//            else {
//                var strInfo: string = `获取表SysSocialRelations的最大关键字为：${returnString}!`;
//                $('#lblResult40').val(strInfo);
//                //显示信息框
//                alert(strInfo);
//                $(strKeyCtrlName).val(returnString);
//            }
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
//            alert(strMsg);
//        }
//    }
//    /* 为插入记录做准备工作
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
//   */
//    public async AddNewRecord() {
//        this.SetKeyReadOnly(false);
//        this.btnOKUpd = "确认添加";
//        this.btnCancel = "取消添加";
//        this.Clear();
//        //wucSysSocialRelationsB1.socialId = clsSysSocialRelationsBL.GetMaxStrId_S();
//        try {
//            const responseText = await SysSocialRelations_GetMaxStrIdAsync();
//            var returnString: string = responseText;
//            if (returnString == "") {
//                var strInfo: string = `获取表SysSocialRelations的最大关键字为空，不成功，请检查!`;
//                //显示信息框
//                alert(strInfo);
//            }
//            else {
//                $('#txtSocialId').val(returnString);
//            }
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
//            alert(strMsg);
//        }
//    }
//    /* 为插入记录做准备工作
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
//   */
//    public AddNewRecordWithMaxId() {
//        this.SetKeyReadOnly(false);
//        this.btnOKUpd = "确认添加";
//        this.btnCancel = "取消添加";
//        this.Clear();
//        //wucSysSocialRelationsB1.socialId = clsSysSocialRelationsBL.GetMaxStrId_S();
//    }
//    /* 函数功能:把界面上的属性数据传到类对象中
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
//     <param name = "pobjSysSocialRelationsEN">数据传输的目的类对象</param>
//   */
//    public PutDataToSysSocialRelationsClass(pobjSysSocialRelationsEN: clsSysSocialRelationsEN) {
//        pobjSysSocialRelationsEN.SetSocialId(this.socialId;// 社会Id
//        pobjSysSocialRelationsEN.SetFullName(this.fullName;// 姓名
//        pobjSysSocialRelationsEN.SetNationality(this.nationality;// 国籍
//        pobjSysSocialRelationsEN.SetLevelId(this.levelId;// 级别Id
//        pobjSysSocialRelationsEN.SetWorkUnit(this.workUnit;// 工作单位
//        pobjSysSocialRelationsEN.SetMajor(this.major;// 专业
//        pobjSysSocialRelationsEN.SetAchievement(this.achievement;// 成就
//        pobjSysSocialRelationsEN.SetDetailedDescription(this.detailedDescription;// 详细说明
//        pobjSysSocialRelationsEN.SetUpdUser(this.updUser;// 修改人
//        pobjSysSocialRelationsEN.SetUpdDate(this.updDate;// 修改日期
//        pobjSysSocialRelationsEN.SetIsSubmit(this.isSubmit;// 是否提交
//        pobjSysSocialRelationsEN.SetMemo(this.memo;// 备注
//    }
//    /* 添加新记录，保存函数
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
//   */
//    public async AddNewRecordSave() {
//        this.DivName = "divAddNewRecordSave";
//        var objSysSocialRelationsEN: clsSysSocialRelationsEN = new clsSysSocialRelationsEN();
//        this.PutDataToSysSocialRelationsClass(objSysSocialRelationsEN);
//        try {
//            const responseText = await SysSocialRelations_IsExistAsync(objSysSocialRelationsEN.socialId);
//            var bolIsExist: boolean = responseText;
//            if (bolIsExist == true) {
//                var strMsg: string = `添加记录时，关键字：${objSysSocialRelationsEN.socialId}已经存在！`;
//                alert(strMsg);
//                return responseText;//一定要有一个返回值，否则会出错！
//            }
//            const responseText2 = await SysSocialRelations_AddNewRecordAsync(objSysSocialRelationsEN);
//            var returnBool: boolean = !!responseText2;
//            if (returnBool == true) {
//                var strInfo: string = `添加记录成功!`;
//                $('#lblResult46').val(strInfo);
//                //显示信息框
//                alert(strInfo);
//            }
//            else {
//                var strInfo: string = `添加记录不成功!`;
//                $('#lblResult46').val(strInfo);
//                //显示信息框
//                alert(strInfo);
//            }
//            return responseText2;//一定要有一个返回值，否则会出错！
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `添加记录不成功,${e}.`;
//            alert(strMsg);
//            return false;//一定要有一个返回值，否则会出错！
//        }
//    }
//    /* 添加新记录，由后台自动获取最大值的关键字。保存函数
//    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
//   */
//    public async AddNewRecordWithMaxIdSave() {
//        
//        var objSysSocialRelationsEN: clsSysSocialRelationsEN = new clsSysSocialRelationsEN();
//        this.PutDataToSysSocialRelationsClass(objSysSocialRelationsEN);
//        try {
//            const responseText2 = await SysSocialRelations_AddNewRecordWithMaxIdAsync(objSysSocialRelationsEN);
//            var returnBool: boolean = !!responseText2;
//            if (returnBool == true) {
//                var strInfo: string = `添加记录成功!`;
//                $('#lblResult47').val(strInfo);
//                //显示信息框
//                alert(strInfo);
//            }
//            else {
//                var strInfo: string = `添加记录不成功!`;
//                $('#lblResult47').val(strInfo);
//                //显示信息框
//                alert(strInfo);
//            }
//            return responseText2;//一定要有一个返回值，否则会出错！
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `添加记录不成功,${e}.`;
//            alert(strMsg);
//            return false;
//        }
//        return true;//一定要有一个返回值，否则会出错！
//    }
//    /* 函数功能:把以该关键字的记录内容显示在界面上,
//          在这里是把值传到表控件中
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
//     <param name = "strSocialId">表记录的关键字,显示该表关键字的内容</param>
//   */
//    public async ShowData(strSocialId: string) {
//        //操作步骤:
//        //1、检查关键字是否为空；
//        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
//        //3、用提供的关键字初始化一个类对象；
//        //4、获取类对象的所有属性；
//        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
//        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
//        var objSysSocialRelationsEN: clsSysSocialRelationsEN = new clsSysSocialRelationsEN();
//        try {
//            const responseText = await SysSocialRelations_IsExistAsync(strSocialId);
//            var returnBool: boolean = responseText;
//            if (returnBool == false) {
//                var strInfo: string = `关键字:[${strSocialId}] 的记录不存在!`;
//                //$('#lblResult1').val(strInfo);
//                //显示信息框
//                alert(strInfo);
//            }
//            else {
//            }
//        }
//        catch (e) {
//            var strMsg: string = `检查相应关键字的记录存在不成功, ${e}.`;
//            alert(strMsg);
//        }
//        try {
//            const responseText = await SysSocialRelations_GetObjBySocialIdAsync(strSocialId);
//            objSysSocialRelationsEN = <clsSysSocialRelationsEN>responseText;
//        }
//        catch (e) {
//            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
//            alert(strMsg);
//        }
//        //3、用提供的关键字初始化一个类对象；
//        this.GetDataFromSysSocialRelationsClass(objSysSocialRelationsEN);
//    }
//    /* 函数功能:把类对象的属性内容显示到界面上
//    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
//     如果在设置数据库时,就应该一级字段在前,二级字段在后
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
//     <param name = "pobjSysSocialRelationsEN">表实体类对象</param>
//   */
//    public GetDataFromSysSocialRelationsClass(pobjSysSocialRelationsEN: clsSysSocialRelationsEN) {
//        this.socialId = pobjSysSocialRelationsEN.socialId;// 社会Id
//        this.fullName = pobjSysSocialRelationsEN.fullName;// 姓名
//        this.nationality = pobjSysSocialRelationsEN.nationality;// 国籍
//        this.levelId = pobjSysSocialRelationsEN.levelId;// 级别Id
//        this.workUnit = pobjSysSocialRelationsEN.workUnit;// 工作单位
//        this.major = pobjSysSocialRelationsEN.major;// 专业
//        this.achievement = pobjSysSocialRelationsEN.achievement;// 成就
//        this.detailedDescription = pobjSysSocialRelationsEN.detailedDescription;// 详细说明
//        this.updUser = pobjSysSocialRelationsEN.updUser;// 修改人
//        this.updDate = pobjSysSocialRelationsEN.updDate;// 修改日期
//        this.isSubmit = pobjSysSocialRelationsEN.isSubmit;// 是否提交
//        this.memo = pobjSysSocialRelationsEN.memo;// 备注
//    }
//    /* 根据关键字获取相应的记录的对象
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
//     <param name = "sender">参数列表</param>
//   */
//    public async UpdateRecord(strSocialId: string) {
//        this.btnOKUpd = "确认修改";
//        this.btnCancel = "取消修改";
//        this.keyId = strSocialId;
//        try {
//            const responseText = await SysSocialRelations_GetObjBySocialIdAsync(strSocialId);
//            var objSysSocialRelationsEN: clsSysSocialRelationsEN = <clsSysSocialRelationsEN>responseText;
//            this.GetDataFromSysSocialRelationsClass(objSysSocialRelationsEN);
//            console.log("完成UpdateRecord!");
//        }
//        catch (e) {
//            console.error(e);
//            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
//            alert(strMsg);
//        }
//    }
//    /* 修改记录
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
//   */
//    public async UpdateRecordSave() {
//        
//        var objSysSocialRelationsEN: clsSysSocialRelationsEN = new clsSysSocialRelationsEN();
//        objSysSocialRelationsEN.SetSocialId(this.keyId;
//        this.PutDataToSysSocialRelationsClass(objSysSocialRelationsEN);
//        objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString;//设置哪些字段被修改(脏字段)
//        if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
//             throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
//        }
//        try {
//            const responseText = await SysSocialRelations_UpdateRecordAsync(objSysSocialRelationsEN);
//            var returnBool: boolean = !!responseText;
//            if (returnBool == true) {
//            }
//            return returnBool;
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `修改记录不成功,${e}.`;
//            alert(strMsg);
//            return false;
//        }
//    }
//    /* 根据关键字列表删除记录
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
//   */
//    public async DelMultiRecord(arrSocialId: Array<string>) {
//        try {
//            const responseText = await SysSocialRelations_DelSysSocialRelationssAsync(arrSocialId);
//            var returnInt: number = responseText;
//            if (returnInt > 0) {
//                var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
//                //显示信息框
//                alert(strInfo);
//            }
//            else {
//                var strInfo: string = `删除记录不成功!`;
//                //显示信息框
//                alert(strInfo);
//            }
//            console.log("完成DelMultiRecord!");
//        }
//        catch (e) {
//            console.error('catch(e)=');
//            console.error(e);
//            var strMsg: string = `删除记录不成功. ${e}.`;
//            alert(strMsg);
//        }
//    }
//    /* 显示{0}对象的所有属性值
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
//     <param name = "divContainer">显示容器</param>
//     <param name = "objSysSocialRelations">需要显示的对象</param>
//   */
//    public ShowSysSocialRelationsObj(divContainer: string, objSysSocialRelations: clsSysSocialRelationsEN) {
//        var o = document.getElementById(divContainer);
//        if (o == null) {
//            alert(`${divContainer}不存在！`);
//            return;
//        }
//        var sstrKeys = GetObjKeys(objSysSocialRelations);
//        var ul: HTMLUListElement = document.createElement("ul");
//        for (let strKey of sstrKeys) {
//            var strValue = objSysSocialRelations[strKey];
//            var li: HTMLLIElement = document.createElement("li");
//            li.innerHTML = `${strKey}:${strValue}`;
//            ul.appendChild(li);
//        }
//        o.appendChild(ul);
//    }
//    /* 函数功能:从界面列表中获取第一个关键字的值
//     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
//     <param name = "pobjSysSocialRelationsEN">表实体类对象</param>
//    <returns>列表的第一个关键字值</returns>
//   */
//    public GetFirstKey(): string {
//        if (arrSelectedKeys.length == 1) {
//            return arrSelectedKeys[0];
//        }
//        else {
//            alert(`请选择一个关键字！目前选择了:${arrSelectedKeys.length}个关键字。`);
//            return "";
//        }
//    }
//    /*
//    演示Session 操作
//      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Demo_Session)
//    */
//    public async Demo_Session() {
//        try {
//            //设置Session
//            var strUserId = "TestUserId";
//            await this.SetSessionAsync("userId", strUserId);
//            //获取Session
//            var strUserId_Value1 = await this.GetSessionAsync("userId");
//            console.log('strUserId_Value1:' + strUserId_Value1);
//            //获取Session方法2：直接读取页面中的hidUserId
//            var strUserId_Value2 = this.hidUserId;
//            console.log('strUserId_Value2:' + strUserId_Value2);
//        }
//        catch (e) {
//            var strMsg: string = `演示Session不成功,${e}.`;
//            alert(strMsg);
//        }
//    }
//    /*
//    设置Session
//      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
//    <param name = "Key">关键字</param>
//    <param name = "Value">值</param>
//    */
//    public SetSessionAsync(Key: string, Value: string): Promise<void> {
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl_Session_SetString,
//                cache: false,
//                async: false,
//                type: 'get',
//                dataType: "json",
//                data: {
//                    Key: Key,
//                    Value: Value
//                },
//                success: function (data) {
//                    var strKey = data.key;
//                    var strValue = data.value;
//                    console.log('strKey, strValue=' + strKey + strValue);
//                }
//            });
//        });
//    }
//    /*
//    获取Session 关键字的值
//      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetSessionAsync)
//    <param name = "Key">关键字</param>
//     <return>值</return>
//    */
//    public GetSessionAsync(Key: string): Promise<string> {
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl_Session_GetString,
//                cache: false,
//                async: false,
//                type: 'get',
//                dataType: "json",
//                data: {
//                    Key: Key,
//                },
//                success: function (data) {
//                    var strKey = data.key;
//                    var strValue = data.value;
//                    console.log('strKey, strValue=' + strKey + strValue);
//                    resolve(data);
//                },
//                error: function (result) {
//                    console.log(result);
//                    console.log(JSON.stringify(result));
//                    if (result.statusText == "error") {
//                        var strInfo = `网络错误！访问网络不成功！`;
//                        reject(strInfo);
//                    }
//                    else {
//                        reject(result.statusText);
//                    }
//                }
//            });
//        });
//    }
//    /*
//    * 成就
//   */
//    public set achievement(value: string) {
//        $("#txtAchievement").val(value);
//    }
//    /*
//    * 成就
//   */
//    public get achievement(): string {
//        return $("#txtAchievement").val();
//    }
//    /*
//    * 成就
//   */
//    public get achievement_q(): string {
//        return $("#txtAchievement_q").val();
//    }
//    /*
//    * 设置取消按钮的标题
//   */
//    public set btnCancel(value: string) {
//        $("#btnCancel").html(value);
//    }
//    /*
//    * 设置确定按钮的标题
//   */
//    public set btnOKUpd(value: string) {
//        $("#btnOKUpd").html(value);
//    }
//    /*
//    * 获取按钮的标题
//   */
//    public get btnOKUpd(): string {
//        return $("#btnOKUpd").html();
//    }
//    /*
//    * 设置当前页序号
//   */
//    public set CurrPageIndex(value: number) {
//        $("#hidCurrPageIndex").val(value);
//    }
//    /*
//    * 获取当前页序号
//   */
//    public get CurrPageIndex(): number {
//        return $("#hidCurrPageIndex").val();
//    }
//    /*
//    * 详细说明
//   */
//    public set detailedDescription(value: string) {
//        $("#txtDetailedDescription").val(value);
//    }
//    /*
//    * 详细说明
//   */
//    public get detailedDescription(): string {
//        return $("#txtDetailedDescription").val();
//    }
//    /*
//    * 添加、修改用的层名
//   */
//    public set DivName(value: string) {
//        $("#hidDivName").val(value);
//    }
//    /*
//    * 姓名
//   */
//    public set fullName(value: string) {
//        $("#txtFullName").val(value);
//    }
//    /*
//    * 姓名
//   */
//    public get fullName(): string {
//        return $("#txtFullName").val();
//    }
//    /*
//    * 姓名
//   */
//    public get fullName_q(): string {
//        return $("#txtFullName_q").val();
//    }
//    /*
//    * 设置排序字段-相当使用ViewState功能
//   */
//    public set hidSortvSysSocialRelationsBy(value: string) {
//        $("#hidSortvSysSocialRelationsBy").val(value);
//    }
//    /*
//    * 设置排序字段
//   */
//    public get hidSortvSysSocialRelationsBy(): string {
//        return $("#hidSortvSysSocialRelationsBy").val();
//    }
//    /*
//    * 用户Id
//   */
//    public get hidUserId(): string {
//        return clsPublocalStorage.userId;
//    }
//    /*
//    * 是否提交
//   */
//    public set isSubmit(value: boolean) {
//        $("#chkIsSubmit").val(value);
//    }
//    /*
//    * 是否提交
//   */
//    public get isSubmit(): boolean {
//        return $("#chkIsSubmit").prop("checked");
//    }
//    /*
//    * 设置关键字的值
//   */
//    public set keyId(value: string) {
//        $("#hidKeyId").val(value);
//    }
//    /*
//    * 设置关键字的值
//   */
//    public get keyId(): string {
//        return $("#hidKeyId").val();
//    }
//    /*
//    * 级别Id
//   */
//    public set levelId(value: string) {
//        $("#ddlLevelId").val(value);
//    }
//    /*
//    * 级别Id
//   */
//    public get levelId(): string {
//        return $("#ddlLevelId").val();
//    }
//    /*
//    * 级别Id
//   */
//    public get levelId_q(): string {
//        return $("#ddlLevelId_q").val();
//    }
//    /*
//    * 专业
//   */
//    public set major(value: string) {
//        $("#txtMajor").val(value);
//    }
//    /*
//    * 专业
//   */
//    public get major(): string {
//        return $("#txtMajor").val();
//    }
//    /*
//    * 备注
//   */
//    public set memo(value: string) {
//        $("#txtMemo").val(value);
//    }
//    /*
//    * 备注
//   */
//    public get memo(): string {
//        return $("#txtMemo").val();
//    }
//    /*
//    * 国籍
//   */
//    public set nationality(value: string) {
//        $("#txtNationality").val(value);
//    }
//    /*
//    * 国籍
//   */
//    public get nationality(): string {
//        return $("#txtNationality").val();
//    }
//    /*
//    * 设置操作类型：Add||Update||Detail
//   */
//    public set opType(value: string) {
//        $("#hidOpType").val(value);
//    }
//    /*
//    * 设置操作类型：Add||Update||Detail
//   */
//    public get opType(): string {
//        return $("#hidOpType").val();
//    }
//    /*
//    * 社会Id
//   */
//    public set socialId(value: string) {
//        $("#txtSocialId").val(value);
//    }
//    /*
//    * 社会Id
//   */
//    public get socialId(): string {
//        return $("#txtSocialId").val();
//    }
//    /*
//    * 修改日期
//   */
//    public set updDate(value: string) {
//        $("#txtUpdDate").val(value);
//    }
//    /*
//    * 修改日期
//   */
//    public get updDate(): string {
//        return $("#txtUpdDate").val();
//    }
//    /*
//    * 修改人
//   */
//    public set updUser(value: string) {
//        $("#txtUpdUser").val(value);
//    }
//    /*
//    * 修改人
//   */
//    public get updUser(): string {
//        return $("#txtUpdUser").val();
//    }
//    /*
//    * 工作单位
//   */
//    public set workUnit(value: string) {
//        $("#txtWorkUnit").val(value);
//    }
//    /*
//    * 工作单位
//   */
//    public get workUnit(): string {
//        return $("#txtWorkUnit").val();
//    }
//}
