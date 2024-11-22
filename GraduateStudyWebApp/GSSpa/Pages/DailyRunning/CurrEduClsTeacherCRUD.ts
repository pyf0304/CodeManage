
/*-- -- -- -- -- -- -- -- -- -- --
类名:CurrEduClsTeacherCRUD
表名:CurrEduClsTeacher(01120124)
生成代码版本:2020.05.09.1
生成日期:2020/05/11 16:30:21
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:日常运行
模块英文名:DailyRunning
框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
编程语言:TypeScript
== == == == == == == == == == == == 
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
//import * as QQ from "q";
import { clsCurrEduClsTeacherEN } from "../TS/L0_Entity/DailyRunning/clsCurrEduClsTeacherEN.js";

import { clsTeacherInfoEN } from "../TS/L0_Entity/BaseInfo/clsTeacherInfoEN.js";
import { clsCurrEduClsEN } from "../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js";
import { clsPk2EduClsTeacherTypeEN } from "../TS/L0_Entity/DailyRunning/clsPk2EduClsTeacherTypeEN.js";
import { clsvCurrEduClsTeacherEN } from "../TS/L0_Entity/DailyRunning/clsvCurrEduClsTeacherEN.js";
import { clsSchoolTermEN } from "../TS/L0_Entity/SysPara/clsSchoolTermEN.js";
import { clsSchoolYearEN } from "../TS/L0_Entity/SysPara/clsSchoolYearEN.js";
import { TeacherInfo_BindDdl_id_TeacherInDiv_Cache } from "../TS/L3_ForWApi/BaseInfo/clsTeacherInfoWApi.js";
import { arrSelectedKeys, clsCommonFunc4Web } from "../TS/PubFun/clsCommonFunc4Web2.js";
import { clsDataColumn } from "../TS/PubFun/clsDataColumn.js";
import { clsOperateList } from "../TS/PubFun/clsOperateList.js";
import { clsPager } from "../TS/PubFun/clsPager.js";
import { clsPublocalStorage } from "../TS/PubFun/clsPublocalStorage.js";
import { clsPubSessionStorage } from "../TS/PubFun/clsPubSessionStorage.js";
import { stuPagerPara } from "../TS/PubFun/stuPagerPara.js";
import { SchoolYear_BindDdl_SchoolYearInDiv_Cache } from "../TS/L3_ForWApi/SysPara/clsSchoolYearWApi.js";
import { SchoolTerm_BindDdl_SchoolTermInDiv_Cache } from "../TS/L3_ForWApi/SysPara/clsSchoolTermWApi.js";
import { CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache } from "../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js";
import { vCurrEduClsTeacher_GetObjLstAsync, vCurrEduClsTeacher_GetObjLstByPagerAsync, vCurrEduClsTeacher_GetObjLstByPager_Cache, vCurrEduClsTeacher_GetRecCountByCondAsync, vCurrEduClsTeacher_GetRecCountByCond_Cache } from "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsTeacherWApi.js";
import { CurrEduClsTeacher_AddNewRecordAsync, CurrEduClsTeacher_DelCurrEduClsTeachersAsync, CurrEduClsTeacher_DelRecordAsync, CurrEduClsTeacher_GetObjByid_EduClsTeacherAsync, CurrEduClsTeacher_IsExistAsync, CurrEduClsTeacher_UpdateRecordAsync } from "../TS/L3_ForWApi/DailyRunning/clsCurrEduClsTeacherWApi.js";
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
/* CurrEduClsTeacherCRUD 的摘要说明。其中Q代表查询,U代表修改
 (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
*/
export class CurrEduClsTeacherCRUD implements clsOperateList{
    public mstrListDiv: string = "divDataLst";
    public bolIsLoadEditRegion: boolean = false;  //记录是否导入编辑区的变量
    public divName4Edit: string = "divEdit";  //记录是否导入编辑区的变量
    public objPager: clsPager = new clsPager();
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

            this.hidSortvCurrEduClsTeacherBy = "eduClsName Asc";
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vCurrEduClsTeacher();
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
        var strUrl: string = "./WA_CurrEduClsTeacher_Edit/";
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

            this.hidSortvCurrEduClsTeacherBy = "eduClsName Asc";
            //2、显示无条件的表内容在GridView中
            const gvResult = await this.BindGv_vCurrEduClsTeacher_Cache();
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
        var strWhereCond = this.CombinevCurrEduClsTeacherCondition();
        try {
            const responseRecCount = await vCurrEduClsTeacher_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: 1,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvCurrEduClsTeacherBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vCurrEduClsTeacher_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                var arrvCurrEduClsTeacherObjLst: Array<clsvCurrEduClsTeacherEN> = <Array<clsvCurrEduClsTeacherEN>>jsonData;
                this.BindTab_vCurrEduClsTeacher(this.mstrListDiv, arrvCurrEduClsTeacherObjLst);
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
        var objCurrEduCls_Cond: clsCurrEduClsEN = new clsCurrEduClsEN();//编辑区域
        var objTeacherInfo_Cond: clsTeacherInfoEN = new clsTeacherInfoEN();//编辑区域
        var objPk2EduClsTeacherType_Cond: clsPk2EduClsTeacherTypeEN = new clsPk2EduClsTeacherTypeEN();//编辑区域
        var objSchoolTerm_Cond: clsSchoolTermEN = new clsSchoolTermEN();//编辑区域
        var objSchoolYear_Cond: clsSchoolYearEN = new clsSchoolYearEN();//编辑区域
        const ddlid_CurrEduCls = await CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache(this.divName4List, "ddlid_CurrEduCls");//编辑区域
        const ddlid_Teacher = await TeacherInfo_BindDdl_id_TeacherInDiv_Cache("", "ddlid_Teacher");//编辑区域
     //   const ddlid_Pk2EduClsTeacherType = await Pk2EduClsTeacherType_BindDdl_id_Pk2EduClsTeacherType_Cache("ddlid_Pk2EduClsTeacherType", objPk2EduClsTeacherType_Cond);//编辑区域
        const ddlSchoolTerm = await SchoolTerm_BindDdl_SchoolTermInDiv_Cache(this.divName4List, "ddlSchoolTerm");//编辑区域
        const ddlSchoolYear = await SchoolYear_BindDdl_SchoolYearInDiv_Cache(this.divName4List, "ddlSchoolYear");//编辑区域
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
        var objSchoolTerm_Cond: clsSchoolTermEN = new clsSchoolTermEN();//查询区域
        var objSchoolYear_Cond: clsSchoolYearEN = new clsSchoolYearEN();//查询区域
        //const ddlSchoolTerm_q = await SchoolTerm_BindDdl_SchoolTerm_Cache("ddlSchoolTerm_q", objSchoolTerm_Cond);//查询区域
        //const ddlSchoolYear_q = await SchoolYear_BindDdl_SchoolYear_Cache("ddlSchoolYear_q", objSchoolYear_Cond);//查询区域
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
            var lngKeyId = Number(strKeyId);
            this.UpdateRecord(lngKeyId);
        }
        else {
            ShowDialog('Update');
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
            const responseBindGv = await this.BindGv_vCurrEduClsTeacher();
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
            var lngKeyId = Number(strKeyId);
            this.SelectRecord(lngKeyId);
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
            var lngKeyId = Number(strKeyId);
            this.DetailRecord(lngKeyId);
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
    public async DelRecord(lngid_EduClsTeacher: number) {
        try {
            const responseText = await CurrEduClsTeacher_DelRecordAsync(lngid_EduClsTeacher);
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
    public async DetailRecord(lngid_EduClsTeacher: number) {
        this.btnOKUpd = "";
        this.btnCancel = "关闭";
        try {
            const responseText = await CurrEduClsTeacher_GetObjByid_EduClsTeacherAsync(lngid_EduClsTeacher);
            var objCurrEduClsTeacherEN: clsCurrEduClsTeacherEN = <clsCurrEduClsTeacherEN>responseText;
            this.GetDataFromCurrEduClsTeacherClass(objCurrEduClsTeacherEN);
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
    public async SelectRecord(lngid_EduClsTeacher: number) {
        try {
            const responseText = await CurrEduClsTeacher_GetObjByid_EduClsTeacherAsync(lngid_EduClsTeacher);
            var objCurrEduClsTeacherEN: clsCurrEduClsTeacherEN = <clsCurrEduClsTeacherEN>responseText;
            console.log("完成SelectRecord!");
            clsCommonFunc4Web.Redirect("/Index/Main_vCurrEduClsTeacher");
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
            var lngKeyId = Number(strKeyId);
            this.UpdateRecord(lngKeyId);
        }
        else {
            ShowDialog('Update');
            var lngKeyId = Number(strKeyId);
            this.UpdateRecord(lngKeyId);
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
            const responseBindGv = await this.BindGv_vCurrEduClsTeacher();
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
            const responseText = await vCurrEduClsTeacher_GetObjLstAsync(strWhereCond).then((jsonData) => {
                var arrvCurrEduClsTeacherObjLst: Array<clsvCurrEduClsTeacherEN> = <Array<clsvCurrEduClsTeacherEN>>jsonData;
                this.BindTab_vCurrEduClsTeacher(this.mstrListDiv, arrvCurrEduClsTeacherObjLst);
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
                        //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
                        //var returnBool2: boolean = jsonData;
                        //if (returnBool2 == true)
                        //{
                        //HideDialog();
                        //this.BindGv_vCurrEduClsTeacher();
                        //}
                        //});
                    }
                    else {
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool: boolean = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vCurrEduClsTeacher();
                            }
                        });
                    }
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                        var returnBool: boolean = jsonData;
                        var strInfo: string = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In CurrEduClsTeacherCRUD.btnOKUpd_Click)";
                        $('#lblResult51').val(strInfo);
                        //显示信息框
                        console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            HideDialog();
                            this.BindGv_vCurrEduClsTeacher();
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
    public CombinevCurrEduClsTeacherCondition(): string {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.CurrEduClsId_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_CurrEduClsId} like '% ${this.CurrEduClsId_q}%'`;
            }
            if (this.eduClsName_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_EduClsName} like '% ${this.eduClsName_q}%'`;
            }
            if (this.TeacherID_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_TeacherID} like '% ${this.TeacherID_q}%'`;
            }
            if (this.TeacherName_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_TeacherName} like '% ${this.TeacherName_q}%'`;
            }
            //if (this.SchoolTerm_q != "" && this.SchoolTerm_q != "0") {
            //    strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_SchoolTerm} = '${this.SchoolTerm_q}'`;
            //}
            //if (this.SchoolYear_q != "" && this.SchoolYear_q != "0") {
            //    strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_SchoolYear} = '${this.SchoolYear_q}'`;
            //}
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineCurrEduClsTeacherCondition)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return strWhereCond;
    }

    /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
     <returns>条件串(strWhereCond)</returns>
   */
    public CombinevCurrEduClsTeacherConditionObj(): clsvCurrEduClsTeacherEN {
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && userName = '张三'
        var strWhereCond: string = " 1 = 1 ";
        var objvCurrEduClsTeacher_Cond: clsvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN();
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        try {
            if (this.CurrEduClsId_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_CurrEduClsId} like '% ${this.CurrEduClsId_q}%'`;
                objvCurrEduClsTeacher_Cond.SetCondFldValue(clsvCurrEduClsTeacherEN.con_CurrEduClsId, this.CurrEduClsId_q, "like");
            }
            if (this.eduClsName_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_EduClsName} like '% ${this.eduClsName_q}%'`;
                objvCurrEduClsTeacher_Cond.SetCondFldValue(clsvCurrEduClsTeacherEN.con_EduClsName, this.eduClsName_q, "like");
            }
            if (this.TeacherID_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_TeacherID} like '% ${this.TeacherID_q}%'`;
                objvCurrEduClsTeacher_Cond.SetCondFldValue(clsvCurrEduClsTeacherEN.con_TeacherID, this.TeacherID_q, "like");
            }
            if (this.TeacherName_q != "") {
                strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_TeacherName} like '% ${this.TeacherName_q}%'`;
                objvCurrEduClsTeacher_Cond.SetCondFldValue(clsvCurrEduClsTeacherEN.con_TeacherName, this.TeacherName_q, "like");
            }
            //if (this.SchoolTerm_q != "" && this.SchoolTerm_q != "0") {
            //    strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_SchoolTerm} = '${this.SchoolTerm_q}'`;
            //    objvCurrEduClsTeacher_Cond.SetCondFldValue(clsvCurrEduClsTeacherEN.con_SchoolTerm, this.SchoolTerm_q, "=");
            //}
            //if (this.SchoolYear_q != "" && this.SchoolYear_q != "0") {
            //    strWhereCond += ` And ${clsvCurrEduClsTeacherEN.con_SchoolYear} = '${this.SchoolYear_q}'`;
            //    objvCurrEduClsTeacher_Cond.SetCondFldValue(clsvCurrEduClsTeacherEN.con_SchoolYear, this.SchoolYear_q, "=");
            //}
        }
        catch (objException) {
            var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombineCurrEduClsTeacherConditionObj)时出错!请联系管理员!${objException}`;
            throw strMsg;
        }
        return objvCurrEduClsTeacher_Cond;
    }

    /* 显示vCurrEduClsTeacher对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrCurrEduClsTeacherObjLst">需要绑定的对象列表</param>
   */
    public BindTab_vCurrEduClsTeacher(divContainer: string, arrvCurrEduClsTeacherObjLst: Array<clsvCurrEduClsTeacherEN>) {
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
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "eduClsName",
                    ColHeader: "教学班",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "courseName",
                    ColHeader: "课程",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "teacherName",
                    ColHeader: "教师",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "collegeName",
                    ColHeader: "学院",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "schoolTerm",
                    ColHeader: "学期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "schoolYear",
                    ColHeader: "学年",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "编辑日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    ColHeader: "编辑人",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "修改",
                    Text: "修改", TdClass: "text-left", SortBy: "",
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
                    Text: "删除", TdClass: "text-left", SortBy: "",
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
        clsCommonFunc4Web.BindTabV2(o, arrvCurrEduClsTeacherObjLst, arrDataColumn, "id_EduClsTeacher");
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
        this.BindGv_vCurrEduClsTeacher();
    }

    /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
   */
    public async BindGv_vCurrEduClsTeacher() {
        var strListDiv: string = this.mstrListDiv;
        var strWhereCond = this.CombinevCurrEduClsTeacherCondition();
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvCurrEduClsTeacherObjLst: Array<clsvCurrEduClsTeacherEN> = [];
        try {
            const responseRecCount = await vCurrEduClsTeacher_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                this.RecCount = jsonData;
            });
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvCurrEduClsTeacherBy,
                sortFun: (x, y) => { return 0; }
            };
            const responseObjLst = await vCurrEduClsTeacher_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                arrvCurrEduClsTeacherObjLst = <Array<clsvCurrEduClsTeacherEN>>jsonData;
            });
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        if (arrvCurrEduClsTeacherObjLst.length == 0) {
            var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vCurrEduClsTeacher(strListDiv, arrvCurrEduClsTeacherObjLst);
            console.log("完成BindGv_vCurrEduClsTeacher!");
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
    public async BindGv_vCurrEduClsTeacher_Cache() {
        var strListDiv: string = this.mstrListDiv;
        var objvCurrEduClsTeacher_Cond = this.CombinevCurrEduClsTeacherConditionObj();
        var strWhereCond = JSON.stringify(objvCurrEduClsTeacher_Cond);
        var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        var arrvCurrEduClsTeacherObjLst: Array<clsvCurrEduClsTeacherEN> = [];
        try {
            var strid_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
            this.RecCount = await vCurrEduClsTeacher_GetRecCountByCond_Cache(objvCurrEduClsTeacher_Cond, strid_CurrEduCls);
            var objPagerPara: stuPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortvCurrEduClsTeacherBy,
                sortFun: (x, y) => { return 0; }
            };
            var arrvCurrEduClsTeacherObjLst = await vCurrEduClsTeacher_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg: string = `绑定GridView不成功,${e}.`;
            alert(strMsg);
        }
        if (arrvCurrEduClsTeacherObjLst.length == 0) {
            var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=CurrEduClsTeacher)`;
            alert(strMsg);
            return;
        }
        try {
            this.BindTab_vCurrEduClsTeacher(strListDiv, arrvCurrEduClsTeacherObjLst);
            console.log("完成BindGv_vCurrEduClsTeacher!");
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
        if (this.hidSortvCurrEduClsTeacherBy.indexOf(strSortByFld) >= 0) {
            if (this.hidSortvCurrEduClsTeacherBy.indexOf("Asc") >= 0) {
                this.hidSortvCurrEduClsTeacherBy = `${strSortByFld} Desc`;
            }
            else {
                this.hidSortvCurrEduClsTeacherBy = `${strSortByFld} Asc`;
            }
        }
        else {
            this.hidSortvCurrEduClsTeacherBy = `${strSortByFld} Asc`;
        }
        const responseBindGv = await this.BindGv_vCurrEduClsTeacher();
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
   //         const responseText = await CurrEduClsTeacher_GetMaxStrIdAsync();
   //         var returnString: string = responseText.toString();
   //         if (returnString == "") {
   //             var strInfo: string = `获取表CurrEduClsTeacher的最大关键字为空，不成功，请检查!`;
   //             $('#lblResult40').val(strInfo);
   //             //显示信息框
   //             alert(strInfo);
   //             $(strKeyCtrlName).val(returnString);
   //         }
   //         else {
   //             var strInfo: string = `获取表CurrEduClsTeacher的最大关键字为：${returnString}!`;
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
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //wucCurrEduClsTeacherB1.id_EduClsTeacher = clsCurrEduClsTeacherBL.GetMaxStrId_S();
    }

    /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
   */
    public AddNewRecordWithMaxId() {
        this.btnOKUpd = "确认添加";
        this.btnCancel = "取消添加";
        this.Clear();
        //wucCurrEduClsTeacherB1.id_EduClsTeacher = clsCurrEduClsTeacherBL.GetMaxStrId_S();
    }

    /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjCurrEduClsTeacherEN">数据传输的目的类对象</param>
   */
    public PutDataToCurrEduClsTeacherClass(pobjCurrEduClsTeacherEN: clsCurrEduClsTeacherEN) {
        pobjCurrEduClsTeacherEN.id_CurrEduCls = this.id_CurrEduCls;// 教学班
        pobjCurrEduClsTeacherEN.id_Teacher = this.id_Teacher;// 教师
        pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType = this.id_Pk2EduClsTeacherType;// 老师角色
        pobjCurrEduClsTeacherEN.schoolTerm = this.schoolTerm;// 学期
        pobjCurrEduClsTeacherEN.schoolYear = this.schoolYear;// 学年
        pobjCurrEduClsTeacherEN.memo = this.memo;// 备注
        pobjCurrEduClsTeacherEN.updUser = clsPubSessionStorage.GetSession_UserId().toString();// 修改人
    }


    /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
   */
    public async AddNewRecordSave() {
        this.DivName = "divAddNewRecordSave";
        var objCurrEduClsTeacherEN: clsCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
        this.PutDataToCurrEduClsTeacherClass(objCurrEduClsTeacherEN);
        try {
            const responseText2 = await CurrEduClsTeacher_AddNewRecordAsync(objCurrEduClsTeacherEN);
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
            return false;
        }
        return true;//一定要有一个返回值，否则会出错！
    }

    /* 函数功能:把以该关键字的记录内容显示在界面上,
          在这里是把值传到表控件中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
     <param name = "lngid_EduClsTeacher">表记录的关键字,显示该表关键字的内容</param>
   */
    public async ShowData(lngid_EduClsTeacher: number) {
        //操作步骤:
        //1、检查关键字是否为空；
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        //3、用提供的关键字初始化一个类对象；
        //4、获取类对象的所有属性；
        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
        var objCurrEduClsTeacherEN: clsCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
        try {
            const responseText = await CurrEduClsTeacher_IsExistAsync(lngid_EduClsTeacher);
            var returnBool: boolean = responseText;
            if (returnBool == false) {
                var strInfo: string = `关键字:[${lngid_EduClsTeacher}] 的记录不存在!`;
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
            const responseText = await CurrEduClsTeacher_GetObjByid_EduClsTeacherAsync(lngid_EduClsTeacher);
            objCurrEduClsTeacherEN = <clsCurrEduClsTeacherEN>responseText;
        }
        catch (e) {
            var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
            alert(strMsg);
        }
        //3、用提供的关键字初始化一个类对象；
        this.GetDataFromCurrEduClsTeacherClass(objCurrEduClsTeacherEN);
    }

    /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjCurrEduClsTeacherEN">表实体类对象</param>
   */
    public GetDataFromCurrEduClsTeacherClass(pobjCurrEduClsTeacherEN: clsCurrEduClsTeacherEN) {
        this.id_CurrEduCls = pobjCurrEduClsTeacherEN.id_CurrEduCls;// 教学班
        this.id_Teacher = pobjCurrEduClsTeacherEN.id_Teacher;// 教师
        this.id_Pk2EduClsTeacherType = pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType;// 老师角色
        this.schoolTerm = pobjCurrEduClsTeacherEN.schoolTerm;// 学期
        this.schoolYear = pobjCurrEduClsTeacherEN.schoolYear;// 学年
        this.memo = pobjCurrEduClsTeacherEN.memo;// 备注
    }

    /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
   */
    public async UpdateRecord(lngid_EduClsTeacher: number) {
        this.btnOKUpd = "确认修改";
        this.btnCancel = "取消修改";
        this.KeyId = lngid_EduClsTeacher.toString();
        try {
            const responseText = await CurrEduClsTeacher_GetObjByid_EduClsTeacherAsync(lngid_EduClsTeacher);
            var objCurrEduClsTeacherEN: clsCurrEduClsTeacherEN = <clsCurrEduClsTeacherEN>responseText;
            this.GetDataFromCurrEduClsTeacherClass(objCurrEduClsTeacherEN);
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
        var objCurrEduClsTeacherEN: clsCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
        objCurrEduClsTeacherEN.id_EduClsTeacher = Number(this.KeyId);
        this.PutDataToCurrEduClsTeacherClass(objCurrEduClsTeacherEN);
        objCurrEduClsTeacherEN.sf_UpdFldSetStr = objCurrEduClsTeacherEN.updFldString;//设置哪些字段被修改(脏字段)
        if (objCurrEduClsTeacherEN.id_EduClsTeacher == 0 || objCurrEduClsTeacherEN.id_EduClsTeacher == undefined) {
            throw "关键字不能为空!";
        }
        try {
            const responseText = await CurrEduClsTeacher_UpdateRecordAsync(objCurrEduClsTeacherEN);
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
        return true;
    }

    /* 根据关键字列表删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
   */
    public async DelMultiRecord(arrid_EduClsTeacher: Array<string>) {
        try {
            const responseText = await CurrEduClsTeacher_DelCurrEduClsTeachersAsync(arrid_EduClsTeacher);
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
     <param name = "objCurrEduClsTeacher">需要显示的对象</param>
   */
    public ShowCurrEduClsTeacherObj(divContainer: string, objCurrEduClsTeacher: clsCurrEduClsTeacherEN) {
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var sstrKeys = clsCommonFunc4Web.GetObjKeys(objCurrEduClsTeacher);
        var ul: HTMLUListElement = document.createElement("ul");
        for (let strKey of sstrKeys) {
            var strValue = objCurrEduClsTeacher[strKey];
            var li: HTMLLIElement = document.createElement("li");
            li.innerHTML = `${strKey}:${strValue}`;
            ul.appendChild(li);
        }
        o.appendChild(ul);
    }

    /* 函数功能:从界面列表中获取第一个关键字的值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
     <param name = "pobjCurrEduClsTeacherEN">表实体类对象</param>
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
    * 当前教学班Id
   */
    public get CurrEduClsId_q(): string {
        return $("#txtCurrEduClsId_q").val();
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
    * 教学班名称
   */
    public get eduClsName_q(): string {
        return $("#txteduClsName_q").val();
    }
    /*
    * 设置排序字段-相当使用ViewState功能
   */
    public set hidSortvCurrEduClsTeacherBy(value: string) {
        $("#hidSortvCurrEduClsTeacherBy").val(value);
    }
    /*
    * 设置排序字段
   */
    public get hidSortvCurrEduClsTeacherBy(): string {
        return $("#hidSortvCurrEduClsTeacherBy").val();
    }
    /*
    * 用户Id
   */
    public get hidUserId(): string {
        return $("#hidUserId").val();
    }
    /*
    * 当前教学班流水号
   */
    public set id_CurrEduCls(value: string) {
        $("#ddlid_CurrEduCls").val(value);
    }
    /*
    * 当前教学班流水号
   */
    public get id_CurrEduCls(): string {
        return $("#ddlid_CurrEduCls").val();
    }
    /*
    * 教学班老师角色(主讲,辅导)流水号
   */
    public set id_Pk2EduClsTeacherType(value: string) {
        $("#ddlid_Pk2EduClsTeacherType").val(value);
    }
    /*
    * 教学班老师角色(主讲,辅导)流水号
   */
    public get id_Pk2EduClsTeacherType(): string {
        return $("#ddlid_Pk2EduClsTeacherType").val();
    }
    /*
    * 教师流水号
   */
    public set id_Teacher(value: string) {
        $("#ddlid_Teacher").val(value);
    }
    /*
    * 教师流水号
   */
    public get id_Teacher(): string {
        return $("#ddlid_Teacher").val();
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
    * 学期
   */
    public set schoolTerm(value: string) {
        $("#ddlSchoolTerm").val(value);
    }
    /*
    * 学期
   */
    public get schoolTerm(): string {
        return $("#ddlSchoolTerm").val();
    }
   // /*
   // * 学期
   //*/
   // public get SchoolTerm_q(): string {
   //     return $("#ddlSchoolTerm_q").val();
   // }
    /*
    * 学年
   */
    public set schoolYear(value: string) {
        $("#ddlSchoolYear").val(value);
    }
    /*
    * 学年
   */
    public get schoolYear(): string {
        return $("#ddlSchoolYear").val();
    }
   // /*
   // * 学年
   //*/
   // public get SchoolYear_q(): string {
   //     return $("#ddlSchoolYear_q").val();
   // }
    /*
    * 教师工号
   */
    public get TeacherID_q(): string {
        return $("#txtTeacherID_q").val();
    }
    /*
    * 教师姓名
   */
    public get TeacherName_q(): string {
        return $("#txtTeacherName_q").val();
    }
    /*
    * 修改人
   */
    public get updUser(): string {
        return $("#txtUpdUser").val();
    }
}