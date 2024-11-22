﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:SysSkillCRUD
表名:SysSkill(01120646)
生成代码版本:2020.05.18.1
生成日期:2020/05/22 18:59:58
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js";
//import { clsSysSkillBL } from "../TS/L2_BLL/GraduateEdu/clsSysSkillBL.js";
//import { clsvSysSkillBL } from "../TS/L2_BLL/GraduateEdu/clsvSysSkillBL.js";
import { clsvSysSkillEN } from "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js";
import { clsSysOperationTypeEN } from "../TS/L0_Entity/ParameterTable/clsSysOperationTypeEN.js";
import { clsSysSecurityLevelEN } from "../TS/L0_Entity/ParameterTable/clsSysSecurityLevelEN.js";

import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";

import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { vSysSkill_GetObjLstAsync, vSysSkill_GetObjLstByPagerAsync, vSysSkill_GetObjLstByPager_Cache, vSysSkill_GetRecCountByCondAsync, vSysSkill_GetRecCountByCond_Cache } from "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js";
import { SysSkill_AddNewRecordAsync, SysSkill_AddNewRecordWithMaxIdAsync, SysSkill_DelRecordAsync, SysSkill_DelSysSkillsAsync, SysSkill_GetMaxStrIdAsync, SysSkill_GetObjBySkillIdAsync, SysSkill_IsExistAsync, SysSkill_UpdateRecordAsync } from "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js";
import { SysOperationType_BindDdl_OperationTypeIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsSysOperationTypeWApi.js";
import { SysSecurityLevel_BindDdl_LevelIdInDiv_Cache } from "../TS/L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js";
/*
* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，
* strOpType：是操作类型，是三种类型之一：Add, Update, Detail
*/
declare function ShowDialog(strOpType): void;
/*
* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，
*/
declare function HideDialog(): void;
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
/* SysSkillCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class SysSkillCRUD implements clsOperateList{
    public static strid_CurrEduCls_Cache: string = "00000001";
    public mstrListDiv: string = "divDataLst";
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public divName4Edit: string = "divEdit";  //记录是否导入编辑区的变量
    
    /*
    * 每页记录数，在扩展类可以修改
   */
    public get pageSize(): number {
        return 5;
    }
    public RecCount = 0;


    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
   */
    public async Page_Load() {
        // 在此处放置用户代码以初始化页面
        try {
            //建立缓存

            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortvSysSkillBy = "skillName Asc";
            if (this.bolIsInitShow == false)  //
            {
                this.objPager.InitShow(this.divName4Pager);
                this.bolIsInitShow = true;  //
            }
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vSysSkill();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }


    /// <summary>
    /// 在当前界面中，导入编辑区域
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
    /// </summary>
    /// <returns></returns>
    public async AddDPV_Edit(divName4Edit) {
        //var strUrl: string = "./SysSkill_Edit/";
        var strUrl: string = "./SysSkill_Edit/";
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

    /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
   */
    public async Page_Load_Cache() {
        // 在此处放置用户代码以初始化页面
        try {

            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();

            this.hidSortvSysSkillBy = "skillName Asc";
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vSysSkill_Cache();
        }
        catch (e) {
            var strMsg: string = `页面启动不成功,${e}.`;
            alert(strMsg);
        }
    }


    /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
   */
    public async btnQuery_Click() {
        //var strWhereCond = this.CombinevSysSkillCondition();

        const responseObjLst = await this.BindGv_vSysSkill();
        //try
        //{
        //const responseRecCount = await vSysSkill_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //this.RecCount = jsonData;
        //});
        //var objPagerPara: stuPagerPara = {
        //pageIndex: 1,
        //pageSize: this.pageSize,
        //whereCond: strWhereCond,
        //orderBy: this.hidSortvSysSkillBy
        //};
        //const responseObjLst = await vSysSkill_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //var arrvSysSkillObjLst : Array<clsvSysSkillEN> = < Array<clsvSysSkillEN>>jsonData;
        //this.BindTab_vSysSkill(this.mstrListDiv, arrvSysSkillObjLst);
        //});
        //}
        //catch(e)
        //{
        //console.error('catch(e)=');
        //console.error(e);
        //var strMsg: string = `查询不成功,${e}.`;
        //alert(strMsg);
        //}
    }

    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
   */
    public async btnAddNewRecord_Click() {
        this.OpType = "Add";
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

    /* 函数功能:为编辑区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
   */
    public async BindDdl4EditRegion() {
        // 在此处放置用户代码以初始化页面
        var objSysOperationType_Cond: clsSysOperationTypeEN = new clsSysOperationTypeEN();//编辑区域
        var objSysSecurityLevel_Cond: clsSysSecurityLevelEN = new clsSysSecurityLevelEN();//编辑区域
        const ddlOperationTypeId = await SysOperationType_BindDdl_OperationTypeIdInDiv_Cache(this.divName4List, "ddlOperationTypeId");//编辑区域
        const ddlLevelId = await SysSecurityLevel_BindDdl_LevelIdInDiv_Cache(this.divName4List, "ddlLevelId");//编辑区域
    }


    /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
   */
    public async btnAddNewRecordWithMaxId_Click() {
        this.OpType = "AddWithMaxId";
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

    /* 函数功能:为查询区绑定下拉框
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Js_BindDdl4QueryRegion)
   */
    public async BindDdl4QueryRegion() {
        // 在此处放置用户代码以初始化页面
        var objSysOperationType_Cond: clsSysOperationTypeEN = new clsSysOperationTypeEN();//查询区域
        const ddlOperationTypeId_q = await SysOperationType_BindDdl_OperationTypeIdInDiv_Cache(this.divName4List, "ddlOperationTypeId_q");//查询区域
        
    }


    /* 在数据表里修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
   */
    public async btnUpdateRecordInTab_Click(strKeyId: string) {
        this.OpType = "Update";
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
            const responseBindGv = await this.BindGv_vSysSkill();
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
    public async btnSelectRecordInTab_Click(strKeyId: string) {
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
    在数据表里详细信息记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecordInTab_Click)
   */
    public async btnDetailRecordInTab_Click(strKeyId: string) {
        this.OpType = "Detail";
        try {
            if (strKeyId == "") {
                alert("请选择需要详细信息的记录！");
                return "";
            }
            this.DetailRecord(strKeyId);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `详细信息记录不成功. ${e}.`;
            alert(strMsg);
        }
    }

    /* 
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
   */
    public async DelRecord(strSkillId: string) {
        try {
            const responseText = await SysSkill_DelRecordAsync(strSkillId);
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
    根据关键字详细信息记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
     <param name = "sender">参数列表</param>
   */
    public async DetailRecord(strSkillId: string) {
        this.btnOKUpd = "";
        this.btnCancel = "关闭";
        try {
            const responseText = await SysSkill_GetObjBySkillIdAsync(strSkillId);
            var objSysSkillEN: clsSysSkillEN = <clsSysSkillEN>responseText;
            this.GetDataFromSysSkillClass(objSysSkillEN);
            console.log("完成DetailRecord!");
        }
        catch (e) {
            console.error(e);
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
    }

    /* 
    根据关键字选择相应的记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
     <param name = "sender">参数列表</param>
   */
    public async SelectRecord(strSkillId: string) {
        try {
            const responseText = await SysSkill_GetObjBySkillIdAsync(strSkillId);
            var objSysSkillEN: clsSysSkillEN = <clsSysSkillEN>responseText;
            console.log("完成SelectRecord!");
            clsCommonFunc4Web.Redirect("/Index/Main_vSysSkill");
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
        this.OpType = "Update";
        //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
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
            var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要删除的记录！");
                return "";
            }
            const responseText = await this.DelMultiRecord(arrKeyIds);
            const responseBindGv = await this.BindGv_vSysSkill();
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
            const responseText = await vSysSkill_GetObjLstAsync(strWhereCond).then((jsonData) => {
                var arrvSysSkillObjLst: Array<clsvSysSkillEN> = <Array<clsvSysSkillEN>>jsonData;
                this.BindTab_vSysSkill(this.mstrListDiv, arrvSysSkillObjLst);
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
                    if (this.OpType == "AddWithMaxId") {
                        const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                            var returnBool2: boolean = <boolean>jsonData;
                            if (returnBool2 == true) {
                                HideDialog();
                                this.BindGv_vSysSkill();
                            }
                        });
                    }
                    else {
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vSysSkill();
                            }
                        });
                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In SysSkillCRUD.btnOKUpd_Click)";
                        $('#lblResult51').val(strInfo);
                        //显示信息框
                        console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            HideDialog();
                            this.BindGv_vSysSkill();
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
    public CombinevSysSkillCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.SkillName_q != "") {
                strWhereCond += ` And ${clsvSysSkillEN.con_SkillName} like '% ${this.SkillName_q}%'`;
            }
            if (this.OperationTypeId_q != "" && this.OperationTypeId_q != "0") {
                strWhereCond += ` And ${clsvSysSkillEN.con_OperationTypeId} = '${this.OperationTypeId_q}'`;
            }
            if (this.UpdUser_q != "") {
                strWhereCond += ` And ${clsvSysSkillEN.con_UpdUser} like '% ${this.UpdUser_q}%'`;
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineSysSkillCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombinevSysSkillConditionObj(): clsvSysSkillEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objvSysSkill_Cond: clsvSysSkillEN = new clsvSysSkillEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.SkillName_q != "") {
                strWhereCond += ` And ${clsvSysSkillEN.con_SkillName} like '% ${this.SkillName_q}%'`;
                objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN.con_SkillName, this.SkillName_q, "like");
            }
            if (this.OperationTypeId_q != "" && this.OperationTypeId_q != "0") {
                strWhereCond += ` And ${clsvSysSkillEN.con_OperationTypeId} = '${this.OperationTypeId_q}'`;
                objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN.con_OperationTypeId, this.OperationTypeId_q, "=");
            }
            if (this.UpdUser_q != "") {
                strWhereCond += ` And ${clsvSysSkillEN.con_UpdUser} like '% ${this.UpdUser_q}%'`;
                objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN.con_UpdUser, this.UpdUser_q, "like");
            }
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombineSysSkillConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objvSysSkill_Cond;
    }

    /* 显示vSysSkill对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrSysSkillObjLst">需要绑定的对象列表</param>
   */
    public BindTab_vSysSkill(divContainer: string, arrvSysSkillObjLst: Array<clsvSysSkillEN>) {
        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn: Array<clsDataColumn> =
            [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "skillName",
                    ColHeader: "技能名称",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "process",
                    ColHeader: "实施过程",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "levelName",
                    ColHeader: "级别名称",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    ColHeader: "修改人",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "isSubmit",
                    ColHeader: "是否提交",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "okCount",
                    ColHeader: "点赞统计",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "appraiseCount",
                    ColHeader: "评论数",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "score",
                    ColHeader: "评分",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "stuScore",
                    ColHeader: "学生平均分",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "teaScore",
                    ColHeader: "教师评分",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "pdfContent",
                    ColHeader: "Pdf内容",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "pdfPageNum",
                    ColHeader: "Pdf页码",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "citationCount",
                    ColHeader: "引用统计",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "versionCount",
                    ColHeader: "版本统计",
                    Text: "",TdClass: "text-left",SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "修改",
                    Text: "修改",TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    FldName: "",
                    ColHeader: "删除",
                    Text: "删除",TdClass: "text-left",SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId: string, strText: string) => {
                        var btn1: HTMLElement = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
        clsCommonFunc4Web.BindTabV2(o, arrvSysSkillObjLst, arrDataColumn, "skillId");
        this.objPager.RecCount = this.RecCount;
        this.objPager.pageSize = this.pageSize;
        this.objPager.ShowPagerV2(this, this.divName4Pager);
    }

    /* 函数功能:在数据 列表中跳转到某一页
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
     <param name = "intPageIndex">页序号</param>
   */
    public async IndexPage(intPageIndex) {
        if (intPageIndex == 0) {
            intPageIndex = this.objPager.PageCount;
        }
        console.log("跳转到" + intPageIndex + "页");
        this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        this.BindGv_vSysSkill();
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_vSysSkill() {
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.CombinevSysSkillCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvSysSkillObjLst: Array<clsvSysSkillEN> = [];
        try {
            const responseRecCount = await vSysSkill_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvSysSkillBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vSysSkill_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvSysSkillObjLst = <Array<clsvSysSkillEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        if (arrvSysSkillObjLst.length == 0) {
            var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vSysSkill(strListDiv, arrvSysSkillObjLst);
            console.log("完成BindGv_vSysSkill!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
   */
    public async BindGv_vSysSkill_Cache() {
        var strListDiv: string = this.mstrListDiv;
        var objvSysSkill_Cond = this.CombinevSysSkillConditionObj();
        objvSysSkill_Cond.SetCondFldValue(clsvSysSkillEN.con_id_CurrEduCls, SysSkillCRUD.strid_CurrEduCls_Cache, "=");
        var strWhereCond = JSON.stringify(objvSysSkill_Cond);
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvSysSkillObjLst: Array<clsvSysSkillEN> = [];
        try {
            this.RecCount = await vSysSkill_GetRecCountByCond_Cache(objvSysSkill_Cond, SysSkillCRUD.strid_CurrEduCls_Cache);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvSysSkillBy,
                sortFun: (x, y) => { return 0; }
            };
            var arrvSysSkillObjLst = await vSysSkill_GetObjLstByPager_Cache(objPagerPara, SysSkillCRUD.strid_CurrEduCls_Cache);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        if (arrvSysSkillObjLst.length == 0) {
            var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=SysSkill_${SysSkillCRUD.strid_CurrEduCls_Cache})`;
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vSysSkill(strListDiv, arrvSysSkillObjLst);
            console.log("完成BindGv_vSysSkill!");
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }

    /* 函数功能:从界面列表中根据某一个字段排序
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
     <param name = "strSortByFld">排序的字段</param>
   */
    public async SortBy(strSortByFld: string) {
        if (this.hidSortvSysSkillBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvSysSkillBy.indexOf("Asc") >= 0) {
                this.hidSortvSysSkillBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvSysSkillBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvSysSkillBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_vSysSkill();
    }

    /// <summary>
    /// 在用户自定义控件中，设置关键字的值，是否只读
    /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
    /// </summary>
    /// <param name = "bolReadonly">是否只读</param>
    public SetKeyReadOnly(bolReadonly: boolean) {
        $('#txtSkillId').prop['ReadOnly'] = bolReadonly;
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
            const responseText = await SysSkill_GetMaxStrIdAsync();
            var returnString: string = responseText.toString();
            if (returnString == "") {
                var strInfo: string = `获取表SysSkill的最大关键字为空，不成功，请检查!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                $(strKeyCtrlName).val(returnString);
            }
            else {
                var strInfo: string = `获取表SysSkill的最大关键字为：${returnString}!`;
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
        //wucSysSkillB1.skillId = clsSysSkillBL.GetMaxStrId_S();
        try {
            const responseText = await SysSkill_GetMaxStrIdAsync();
            var returnString: string = responseText;
            if (returnString == "") {
                var strInfo: string = `获取表SysSkill的最大关键字为空，不成功，请检查!`;
                //显示信息框
                alert(strInfo);
            }
            else {
                $('#txtSkillId').val(returnString);
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
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
   */
    public AddNewRecordWithMaxId() {
        this.SetKeyReadOnly(false);
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //wucSysSkillB1.skillId = clsSysSkillBL.GetMaxStrId_S();
    }

    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjSysSkillEN">数据传输的目的类对象</param>
   */
    public PutDataToSysSkillClass(pobjSysSkillEN: clsSysSkillEN) {
        pobjSysSkillEN.skillId = this.skillId;// 技能Id
        pobjSysSkillEN.skillName = this.skillName;// 技能名称
        pobjSysSkillEN.operationTypeId = this.operationTypeId;// 操作类型
        pobjSysSkillEN.levelId = this.levelId;// 级别Id
        pobjSysSkillEN.process = this.process;// 实施过程
        pobjSysSkillEN.updUser = this.updUser;// 修改人
        pobjSysSkillEN.updDate = this.updDate;// 修改日期
        pobjSysSkillEN.isSubmit = this.isSubmit;// 是否提交
        pobjSysSkillEN.citationId = this.citationId;// 引用Id
        pobjSysSkillEN.memo = this.memo;// 备注
    }


    /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        var objSysSkillEN: clsSysSkillEN = new clsSysSkillEN();
        this.PutDataToSysSkillClass(objSysSkillEN);
        try {
            const responseText = await SysSkill_IsExistAsync(objSysSkillEN.skillId);
            var bolIsExist: boolean = responseText;
            if (bolIsExist == true) {
                var strMsg: string = `添加记录时，关键字：${objSysSkillEN.skillId}已经存在！`;
                alert(strMsg);
                return responseText;//一定要有一个返回值，否则会出错！
            }
            const responseText2 = await SysSkill_AddNewRecordAsync(objSysSkillEN);
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
        this.DivName = "divAddNewRecordWithMaxIdSave";
        var objSysSkillEN: clsSysSkillEN = new clsSysSkillEN();
        this.PutDataToSysSkillClass(objSysSkillEN);
        try {
            const responseText2 = await SysSkill_AddNewRecordWithMaxIdAsync(objSysSkillEN);
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
     <param name = "strSkillId">表记录的关键字,显示该表关键字的内容</param>
   */
    public async ShowData(strSkillId: string) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objSysSkillEN: clsSysSkillEN = new clsSysSkillEN();
        try {
            const responseText = await SysSkill_IsExistAsync(strSkillId);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${strSkillId}] 的记录不存在!`;
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
            const responseText = await SysSkill_GetObjBySkillIdAsync(strSkillId);
            objSysSkillEN = <clsSysSkillEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromSysSkillClass(objSysSkillEN);
    }

    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjSysSkillEN">表实体类对象</param>
   */
    public GetDataFromSysSkillClass(pobjSysSkillEN: clsSysSkillEN) {
        this.skillId = pobjSysSkillEN.skillId;// 技能Id
        this.skillName = pobjSysSkillEN.skillName;// 技能名称
        this.operationTypeId = pobjSysSkillEN.operationTypeId;// 操作类型
        this.levelId = pobjSysSkillEN.levelId;// 级别Id
        this.process = pobjSysSkillEN.process;// 实施过程
        this.updUser = pobjSysSkillEN.updUser;// 修改人
        this.updDate = pobjSysSkillEN.updDate;// 修改日期
        this.isSubmit = pobjSysSkillEN.isSubmit;// 是否提交
        this.citationId = pobjSysSkillEN.citationId;// 引用Id
        this.memo = pobjSysSkillEN.memo;// 备注
    }

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public async UpdateRecord(strSkillId: string) {
        this.btnOKUpd = "确认修改";
        this.btnCancel = "取消修改";
        this.KeyId = strSkillId;
        try {
            const responseText = await SysSkill_GetObjBySkillIdAsync(strSkillId);
            var objSysSkillEN: clsSysSkillEN = <clsSysSkillEN>responseText;
            this.GetDataFromSysSkillClass(objSysSkillEN);
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
        this.DivName = "divUpdateRecordSave";
        var objSysSkillEN: clsSysSkillEN = new clsSysSkillEN();
        objSysSkillEN.skillId = this.KeyId;
        this.PutDataToSysSkillClass(objSysSkillEN);
        objSysSkillEN.sf_UpdFldSetStr = objSysSkillEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objSysSkillEN.skillId == "" || objSysSkillEN.skillId == undefined) {
            throw "关键字不能为空!";
        }
        try {
            const responseText = await SysSkill_UpdateRecordAsync(objSysSkillEN);
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
    public async DelMultiRecord(arrSkillId: Array<string>) {
        try {
            const responseText = await SysSkill_DelSysSkillsAsync(arrSkillId);
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
     <param name = "objSysSkill">需要显示的对象</param>
   */
    public ShowSysSkillObj(divContainer: string, objSysSkill: clsSysSkillEN) {
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrKeys = clsCommonFunc4Web.GetObjKeys(objSysSkill);
        var ul: HTMLUListElement = document.createElement("ul");
        for (let strKey of sstrKeys) {
            var strValue = objSysSkill[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = `${strKey}:${strValue}`;
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /* 函数功能:从界面列表中获取第一个关键字的值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
     <param name = "pobjSysSkillEN">表实体类对象</param>
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
    public set btnCancel(value: string) {
        $("#btnCancel").html(value);
    }
    /*
    * 设置确定按钮的标题
   */
    public set btnOKUpd(value: string) {
        $("#btnOKUpd").html(value);
    }
    /*
    * 获取按钮的标题
   */
    public get btnOKUpd(): string {
        return $("#btnOKUpd").html();
    }
    /*
    * 引用Id
   */
    public set citationId(value: string) {
        $("#txtCitationId").val(value);
    }
    /*
    * 引用Id
   */
    public get citationId(): string {
        return $("#txtCitationId").val();
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
    public set hidSortvSysSkillBy(value: string) {
        $("#hidSortvSysSkillBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvSysSkillBy(): string {
        return $("#hidSortvSysSkillBy").val();
    }
    /*
    * 用户Id
   */
    public get hidUserId(): string {
        return $("#hidUserId").val();
    }
    /*
    * 是否提交
   */
    public set isSubmit(value: boolean) {
        $("#chkIsSubmit").val(value);
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
    public set KeyId(value: string) {
        $("#hidKeyId").val(value);
    }
    /*
    * 设置关键字的值
   */
    public get KeyId(): string {
        return $("#hidKeyId").val();
    }
    /*
    * 级别Id
   */
    public set levelId(value: string) {
        $("#ddlLevelId").val(value);
    }
    /*
    * 级别Id
   */
    public get levelId(): string {
        return $("#ddlLevelId").val();
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
    * 操作类型ID
   */
    public set operationTypeId(value: string) {
        $("#ddlOperationTypeId").val(value);
    }
    /*
    * 操作类型ID
   */
    public get operationTypeId(): string {
        return $("#ddlOperationTypeId").val();
    }
    /*
    * 操作类型ID
   */
    public get OperationTypeId_q(): string {
        return $("#ddlOperationTypeId_q").val();
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public set OpType(value: string) {
        $("#hidOpType").val(value);
    }
    /*
    * 设置操作类型：Add||Update||Detail
   */
    public get OpType(): string {
        return $("#hidOpType").val();
    }
    /*
    * 实施过程
   */
    public set process(value: string) {
        $("#txtProcess").val(value);
    }
    /*
    * 实施过程
   */
    public get process(): string {
        return $("#txtProcess").val();
    }
    /*
    * 技能Id
   */
    public set skillId(value: string) {
        $("#txtSkillId").val(value);
    }
    /*
    * 技能Id
   */
    public get skillId(): string {
        return $("#txtSkillId").val();
    }
    /*
    * 技能名称
   */
    public set skillName(value: string) {
        $("#txtSkillName").val(value);
    }
    /*
    * 技能名称
   */
    public get skillName(): string {
        return $("#txtSkillName").val();
    }
    /*
    * 技能名称
   */
    public get SkillName_q(): string {
        return $("#txtSkillName_q").val();
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
    /*
    * 修改人
   */
    public get UpdUser_q(): string {
        return $("#txtUpdUser_q").val();
    }
}