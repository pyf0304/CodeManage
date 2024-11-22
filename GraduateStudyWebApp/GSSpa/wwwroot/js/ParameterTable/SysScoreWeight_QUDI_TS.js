(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduTools/clsSysScoreWeightEN.js", "../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js", "../TS/L0_Entity/GraduateEduTools/clsvSysScoreWeightEN.js", "../TS/L0_Entity/ParameterTable/clsSysScoreTypeEN.js", "../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsString2.js", "../TS/L3_ForWApi/ParameterTable/clsSysScoreTypeWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreWeightWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsSysScoreWeightWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysScoreWeight_QUDI_TS = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:SysScoreWeight_QUDI_TS
    表名:SysScoreWeight(01120629)
    生成代码版本:2020.04.17.1
    生成日期:2020/04/22 17:09:06
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:研究生培养
    模块英文名:GraduateEdu
    框架-层名:WA_界面脚本后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsSysScoreWeightEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsSysScoreWeightEN.js");
    const clsCurrEduClsEN_js_1 = require("../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js");
    const clsvSysScoreWeightEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsvSysScoreWeightEN.js");
    const clsSysScoreTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSysScoreTypeEN.js");
    const clsCurrEduClsWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    const clsSysScoreTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsSysScoreTypeWApi.js");
    const clsvSysScoreWeightWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreWeightWApi.js");
    const clsSysScoreWeightWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsSysScoreWeightWApi.js");
    /* SysScoreWeight_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class SysScoreWeight_QUDI_TS extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.RecCount = 0;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                //建立缓存
                const arrCurrEduCls_Cache = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetObjLstAsync)("1=1"); //查询区域
                const arrSysScoreType_Cache = await (0, clsSysScoreTypeWApi_js_1.SysScoreType_GetObjLstAsync)("1=1"); //编辑区域
                //const arrvSysScoreWeight_Cache = await vSysScoreWeight_GetObjLstAsync("1=1");
                var objCurrEduCls_Cond = new clsCurrEduClsEN_js_1.clsCurrEduClsEN(); //查询区域
                var objSysScoreType_Cond = new clsSysScoreTypeEN_js_1.clsSysScoreTypeEN(); //编辑区域
                const ddlid_CurrEduCls_q = (0, clsCurrEduClsWApi_js_1.CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache)(this.divName4List, "ddlid_CurrEduCls_q"); //查询区域
                const ddlScoreTypeId = (0, clsSysScoreTypeWApi_js_1.SysScoreType_BindDdl_ScoreTypeIdInDiv_Cache)(this.divName4List, "ddlScoreTypeId"); //编辑区域
                const ddlid_CurrEduCls = (0, clsCurrEduClsWApi_js_1.CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache)(this.divName4List, "ddlid_CurrEduCls"); //编辑区域
                this.hidSortvSysScoreWeightBy = "scoreWeightId Asc";
                var strWhereCond = this.CombinevSysScoreWeightCondition();
                const responseText = await (0, clsvSysScoreWeightWApi_js_1.vSysScoreWeight_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vSysScoreWeight();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
       */
        async Page_Load_Cache() {
            // 在此处放置用户代码以初始化页面
            try {
                const arrCurrEduCls_Cache = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetObjLstAsync)("1=1"); //查询区域
                const arrSysScoreType_Cache = await (0, clsSysScoreTypeWApi_js_1.SysScoreType_GetObjLstAsync)("1=1"); //编辑区域
                const arrvSysScoreWeight_Cache = await (0, clsvSysScoreWeightWApi_js_1.vSysScoreWeight_GetObjLstAsync)("1=1");
                var objCurrEduCls_Cond = new clsCurrEduClsEN_js_1.clsCurrEduClsEN(); //查询区域
                var objSysScoreType_Cond = new clsSysScoreTypeEN_js_1.clsSysScoreTypeEN(); //编辑区域
                const ddlid_CurrEduCls_q = (0, clsCurrEduClsWApi_js_1.CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache)(this.divName4List, "ddlid_CurrEduCls_q"); //查询区域
                const ddlScoreTypeId = await (0, clsSysScoreTypeWApi_js_1.SysScoreType_BindDdl_ScoreTypeIdInDiv_Cache)(this.divName4List, "ddlScoreTypeId"); //编辑区域
                const ddlid_CurrEduCls = (0, clsCurrEduClsWApi_js_1.CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache)(this.divName4List, "ddlid_CurrEduCls"); //编辑区域
                this.hidSortvSysScoreWeightBy = "scoreWeightValue Asc";
                var objvSysScoreWeight_Cond = this.CombinevSysScoreWeightConditionObj();
                this.RecCount = await (0, clsvSysScoreWeightWApi_js_1.vSysScoreWeight_GetRecCountByCond_Cache)(objvSysScoreWeight_Cond);
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vSysScoreWeight_Cache();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
       */
        async btnQuery_Click(strListDiv) {
            var strWhereCond = this.CombinevSysScoreWeightCondition();
            try {
                const responseRecCount = await (0, clsvSysScoreWeightWApi_js_1.vSysScoreWeight_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: 1,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvSysScoreWeightBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvSysScoreWeightWApi_js_1.vSysScoreWeight_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    var arrvSysScoreWeightObjLst = jsonData;
                    this.BindTab_vSysScoreWeight(this.mstrListDiv, arrvSysScoreWeightObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `查询不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
       */
        async btnAddNewRecord_Click() {
            this.OpType = "Add";
            try {
                const responseText = await this.AddNewRecord();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 在数据表里修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
       */
        btnUpdateRecordInTab_Click(strKeyId) {
            this.OpType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            this.UpdateRecord(strKeyId);
        }
        /*
        在数据表里删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
       */
        async btnDelRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText = await this.DelRecord(strKeyId);
                const responseBindGv = await this.BindGv_vSysScoreWeight();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        在数据表里选择记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
       */
        async btnSelectRecordInTab_Click(strKeyId) {
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
                var strMsg = `选择记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        在数据表里详细信息记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecordInTab_Click)
       */
        async btnDetailRecordInTab_Click(strKeyId) {
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
                var strMsg = `详细信息记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        async DelRecord(strScoreWeightId) {
            try {
                const responseText = await (0, clsSysScoreWeightWApi_js_1.SysScoreWeight_DelRecordAsync)(strScoreWeightId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `删除记录不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelRecord!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字详细信息记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
         <param name = "sender">参数列表</param>
       */
        async DetailRecord(strScoreWeightId) {
            this.btnOKUpd = "";
            this.btnCancel = "关闭";
            try {
                const responseText = await (0, clsSysScoreWeightWApi_js_1.SysScoreWeight_GetObjByScoreWeightIdAsync)(strScoreWeightId);
                var objSysScoreWeightEN = responseText;
                this.GetDataFromSysScoreWeightClass(objSysScoreWeightEN);
                console.log("完成DetailRecord!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字选择相应的记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
         <param name = "sender">参数列表</param>
       */
        async SelectRecord(strScoreWeightId) {
            try {
                const responseText = await (0, clsSysScoreWeightWApi_js_1.SysScoreWeight_GetObjByScoreWeightIdAsync)(strScoreWeightId);
                var objSysScoreWeightEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vSysScoreWeight");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
       */
        btnUpdateRecord_Click(strKeyId) {
            this.OpType = "Update";
            //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            this.UpdateRecord(strKeyId);
        }
        /* 删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
       */
        async btnDelRecord_Click() {
            try {
                var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText = await this.DelMultiRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_vSysScoreWeight();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
       */
        async btnExportExcel_Click() {
            var strWhereCond = " 1=1 ";
            try {
                const responseText = await (0, clsvSysScoreWeightWApi_js_1.vSysScoreWeight_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    var arrvSysScoreWeightObjLst = jsonData;
                    this.BindTab_vSysScoreWeight(this.mstrListDiv, arrvSysScoreWeightObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `导出Excel不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnOKUpd_Click() {
            var strCommandText = this.btnOKUpd;
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
                                var returnBool2 = jsonData;
                                if (clsString2_js_1.clsString.IsNullOrEmpty(returnBool2) == false) {
                                    HideDialog();
                                    this.BindGv_vSysScoreWeight();
                                }
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.BindGv_vSysScoreWeight();
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In SysScoreWeight_QUDI_TS.btnOKUpd_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vSysScoreWeight();
                            }
                        });
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                        alert(strMsg);
                        break;
                }
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevSysScoreWeightCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.IsPublic_q == true) {
                //    strWhereCond += ` And ${clsvSysScoreWeightEN.con_IsPublic} = '1'`;
                //}
                //else {
                //    strWhereCond += ` And ${clsvSysScoreWeightEN.con_IsPublic} = '0'`;
                //}
                if (this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0") {
                    strWhereCond += ` And ${clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_id_CurrEduCls} = '${this.id_CurrEduCls_q}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysScoreWeightCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevSysScoreWeightConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvSysScoreWeight_Cond = new clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.IsPublic_q == true) {
                    strWhereCond += ` And ${clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_IsPublic} = '1'`;
                    objvSysScoreWeight_Cond.SetCondFldValue(clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_IsPublic, true, "=");
                }
                else {
                    strWhereCond += ` And ${clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_IsPublic} = '0'`;
                    objvSysScoreWeight_Cond.SetCondFldValue(clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_IsPublic, false, "=");
                }
                if (this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0") {
                    strWhereCond += ` And ${clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_id_CurrEduCls} = '${this.id_CurrEduCls_q}'`;
                    objvSysScoreWeight_Cond.SetCondFldValue(clsvSysScoreWeightEN_js_1.clsvSysScoreWeightEN.con_id_CurrEduCls, this.id_CurrEduCls_q, "=");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineSysScoreWeightConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvSysScoreWeight_Cond;
        }
        /* 显示vSysScoreWeight对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrSysScoreWeightObjLst">需要绑定的对象列表</param>
       */
        BindTab_vSysScoreWeight(divContainer, arrvSysScoreWeightObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "scoreWeightValue",
                    ColHeader: "权重分值",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "ScoreTypeName",
                    ColHeader: "成绩类型名称",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "eduClsName",
                    ColHeader: "教学班名称",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "isPublic",
                    ColHeader: "是否公开",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    ColHeader: "修改人",
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
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                //{
                //    FldName: "",
                //    ColHeader: "删除",
                //    Text: "删除",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvSysScoreWeightObjLst, arrDataColumn, "scoreWeightId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 函数功能:在数据 列表中跳转到某一页
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
         <param name = "intPageIndex">页序号</param>
       */
        async IndexPage(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.setCurrPageIndex(intPageIndex, this.divName4Pager);
            this.BindGv_vSysScoreWeight();
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vSysScoreWeight() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevSysScoreWeightCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvSysScoreWeightObjLst = [];
            try {
                const responseRecCount = await (0, clsvSysScoreWeightWApi_js_1.vSysScoreWeight_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvSysScoreWeightBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvSysScoreWeightWApi_js_1.vSysScoreWeight_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvSysScoreWeightObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvSysScoreWeightObjLst.length == 0) {
                var strMsg = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vSysScoreWeight(strListDiv, arrvSysScoreWeightObjLst);
                console.log("完成BindGv_vSysScoreWeight!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
       */
        async BindGv_vSysScoreWeight_Cache() {
            var strListDiv = this.mstrListDiv;
            var objvSysScoreWeight_Cond = this.CombinevSysScoreWeightConditionObj();
            var strWhereCond = JSON.stringify(objvSysScoreWeight_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvSysScoreWeightObjLst = [];
            try {
                const arrvSysScoreWeight_Cache = await (0, clsvSysScoreWeightWApi_js_1.vSysScoreWeight_GetObjLstAsync)("1=1");
                this.RecCount = await (0, clsvSysScoreWeightWApi_js_1.vSysScoreWeight_GetRecCountByCond_Cache)(objvSysScoreWeight_Cond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvSysScoreWeightBy,
                    sortFun: (x, y) => { return 0; }
                };
                var arrvSysScoreWeightObjLst = await (0, clsvSysScoreWeightWApi_js_1.vSysScoreWeight_GetObjLstByPager_Cache)(objPagerPara);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvSysScoreWeightObjLst.length == 0) {
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=SysScoreWeight)`;
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vSysScoreWeight(strListDiv, arrvSysScoreWeightObjLst);
                console.log("完成BindGv_vSysScoreWeight!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:从界面列表中根据某一个字段排序
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
         <param name = "strSortByFld">排序的字段</param>
       */
        async SortBy(strSortByFld) {
            if (this.hidSortvSysScoreWeightBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvSysScoreWeightBy.indexOf("Asc") >= 0) {
                    this.hidSortvSysScoreWeightBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvSysScoreWeightBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvSysScoreWeightBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_vSysScoreWeight();
        }
        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        SetKeyReadOnly(bolReadonly) {
            $('#txtScoreWeightId').prop['ReadOnly'] = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
            this.scoreWeightId = "";
            $('#ddlScoreTypeId option[0]').attr("selected", true);
            this.scoreWeightValue = "";
            $('#ddlid_CurrEduCls option[0]').attr("selected", true);
            this.isPublic = false;
            this.memo = "";
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        async AddNewRecord() {
            this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucSysScoreWeightB1.scoreWeightId = clsSysScoreWeightBL.GetMaxStrId_S();
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucSysScoreWeightB1.scoreWeightId = clsSysScoreWeightBL.GetMaxStrId_S();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjSysScoreWeightEN">数据传输的目的类对象</param>
       */
        PutDataToSysScoreWeightClass(pobjSysScoreWeightEN) {
            pobjSysScoreWeightEN.scoreWeightId = this.scoreWeightId; // 分数权重Id
            pobjSysScoreWeightEN.scoreTypeId = this.scoreTypeId; // 成绩类型代号
            pobjSysScoreWeightEN.scoreWeightValue = this.scoreWeightValue; // scoreWeightValue
            pobjSysScoreWeightEN.id_CurrEduCls = this.id_CurrEduCls; // 当前教学班流水号
            pobjSysScoreWeightEN.isPublic = this.isPublic; // 是否公开
            pobjSysScoreWeightEN.memo = this.memo; // 备注
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objSysScoreWeightEN = new clsSysScoreWeightEN_js_1.clsSysScoreWeightEN();
            this.PutDataToSysScoreWeightClass(objSysScoreWeightEN);
            try {
                const responseText = await (0, clsSysScoreWeightWApi_js_1.SysScoreWeight_IsExistAsync)(objSysScoreWeightEN.scoreWeightId);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objSysScoreWeightEN.scoreWeightId}已经存在！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsSysScoreWeightWApi_js_1.SysScoreWeight_AddNewRecordAsync)(objSysScoreWeightEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
       */
        async AddNewRecordWithMaxIdSave() {
            this.DivName = "divAddNewRecordWithMaxIdSave";
            var objSysScoreWeightEN = new clsSysScoreWeightEN_js_1.clsSysScoreWeightEN();
            this.PutDataToSysScoreWeightClass(objSysScoreWeightEN);
            try {
                const responseText2 = await (0, clsSysScoreWeightWApi_js_1.SysScoreWeight_AddNewRecordWithMaxIdAsync)(objSysScoreWeightEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把以该关键字的记录内容显示在界面上,
              在这里是把值传到表控件中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
         <param name = "strScoreWeightId">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(strScoreWeightId) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objSysScoreWeightEN = new clsSysScoreWeightEN_js_1.clsSysScoreWeightEN();
            try {
                const responseText = await (0, clsSysScoreWeightWApi_js_1.SysScoreWeight_IsExistAsync)(strScoreWeightId);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${strScoreWeightId}] 的记录不存在!`;
                    //$('#lblResult1').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                }
            }
            catch (e) {
                var strMsg = `检查相应关键字的记录存在不成功, ${e}.`;
                alert(strMsg);
            }
            try {
                const responseText = await (0, clsSysScoreWeightWApi_js_1.SysScoreWeight_GetObjByScoreWeightIdAsync)(strScoreWeightId);
                objSysScoreWeightEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromSysScoreWeightClass(objSysScoreWeightEN);
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjSysScoreWeightEN">表实体类对象</param>
       */
        GetDataFromSysScoreWeightClass(pobjSysScoreWeightEN) {
            this.scoreWeightId = pobjSysScoreWeightEN.scoreWeightId; // 分数权重Id
            this.scoreTypeId = pobjSysScoreWeightEN.scoreTypeId; // 成绩类型代号
            this.scoreWeightValue = pobjSysScoreWeightEN.scoreWeightValue; // scoreWeightValue
            this.id_CurrEduCls = pobjSysScoreWeightEN.id_CurrEduCls; // 当前教学班流水号
            this.isPublic = pobjSysScoreWeightEN.isPublic; // 是否公开
            this.memo = pobjSysScoreWeightEN.memo; // 备注
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(strScoreWeightId) {
            this.btnOKUpd = "确认修改";
            this.btnCancel = "取消修改";
            this.KeyId = strScoreWeightId;
            try {
                const responseText = await (0, clsSysScoreWeightWApi_js_1.SysScoreWeight_GetObjByScoreWeightIdAsync)(strScoreWeightId);
                var objSysScoreWeightEN = responseText;
                this.GetDataFromSysScoreWeightClass(objSysScoreWeightEN);
                console.log("完成UpdateRecord!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
       */
        async UpdateRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objSysScoreWeightEN = new clsSysScoreWeightEN_js_1.clsSysScoreWeightEN();
            objSysScoreWeightEN.scoreWeightId = this.KeyId;
            this.PutDataToSysScoreWeightClass(objSysScoreWeightEN);
            objSysScoreWeightEN.sf_UpdFldSetStr = objSysScoreWeightEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objSysScoreWeightEN.scoreWeightId == "" || objSysScoreWeightEN.scoreWeightId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = await (0, clsSysScoreWeightWApi_js_1.SysScoreWeight_UpdateRecordAsync)(objSysScoreWeightEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                }
                return returnBool;
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `修改记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true;
        }
        /* 根据关键字列表删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
       */
        async DelMultiRecord(arrScoreWeightId) {
            try {
                const responseText = await (0, clsSysScoreWeightWApi_js_1.SysScoreWeight_DelSysScoreWeightsAsync)(arrScoreWeightId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `删除记录不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelMultiRecord!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 显示{0}对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
         <param name = "divContainer">显示容器</param>
         <param name = "objSysScoreWeight">需要显示的对象</param>
       */
        ShowSysScoreWeightObj(divContainer, objSysScoreWeight) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objSysScoreWeight);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objSysScoreWeight[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjSysScoreWeightEN">表实体类对象</param>
        <returns>列表的第一个关键字值</returns>
       */
        GetFirstKey() {
            if (clsCommonFunc4Web2_js_1.arrSelectedKeys.length == 1) {
                return clsCommonFunc4Web2_js_1.arrSelectedKeys[0];
            }
            else {
                alert(`请选择一个关键字！目前选择了:${clsCommonFunc4Web2_js_1.arrSelectedKeys.length}个关键字。`);
                return "";
            }
        }
        /*
        演示Session 操作
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Demo_Session)
        */
        async Demo_Session() {
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
                var strMsg = `演示Session不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        设置Session
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
        <param name = "Key">关键字</param>
        <param name = "Value">值</param>
        */
        SetSessionAsync(Key, Value) {
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
        GetSessionAsync(Key) {
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
        set btnCancel(value) {
            $("#btnCancel").html(value);
        }
        /*
        * 设置确定按钮的标题
       */
        set btnOKUpd(value) {
            $("#btnOKUpd").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnOKUpd() {
            return $("#btnOKUpd").html();
        }
        /*
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
        * 获取当前页序号
       */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 添加、修改用的层名
       */
        set DivName(value) {
            $("#hidDivName").val(value);
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvSysScoreWeightBy(value) {
            $("#hidSortvSysScoreWeightBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvSysScoreWeightBy() {
            return $("#hidSortvSysScoreWeightBy").val();
        }
        /*
        * 用户Id
       */
        get hidUserId() {
            return $("#hidUserId").val();
        }
        /*
        * 当前教学班流水号
       */
        set id_CurrEduCls(value) {
            $("#ddlid_CurrEduCls").val(value);
        }
        /*
        * 当前教学班流水号
       */
        get id_CurrEduCls() {
            return $("#ddlid_CurrEduCls").val();
        }
        /*
        * 当前教学班流水号
       */
        get id_CurrEduCls_q() {
            return $("#ddlid_CurrEduCls_q").val();
        }
        /*
        * 是否公开
       */
        set isPublic(value) {
            $("#chkIsPublic").val(value);
        }
        /*
        * 是否公开
       */
        get isPublic() {
            return $("#chkIsPublic").prop("checked");
        }
        /*
        * 是否公开
       */
        get IsPublic_q() {
            return $("#chkIsPublic_q").prop("checked");
        }
        /*
        * 设置关键字的值
       */
        set KeyId(value) {
            $("#hidKeyId").val(value);
        }
        /*
        * 设置关键字的值
       */
        get KeyId() {
            return $("#hidKeyId").val();
        }
        /*
        * 备注
       */
        set memo(value) {
            $("#txtMemo").val(value);
        }
        /*
        * 备注
       */
        get memo() {
            return $("#txtMemo").val();
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        set OpType(value) {
            $("#hidOpType").val(value);
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        get OpType() {
            return $("#hidOpType").val();
        }
        /*
        * 分数类型Id
       */
        set scoreTypeId(value) {
            $("#ddlScoreTypeId").val(value);
        }
        /*
        * 分数类型Id
       */
        get scoreTypeId() {
            return $("#ddlScoreTypeId").val();
        }
        /*
        * 分数权重Id
       */
        set scoreWeightId(value) {
            $("#txtScoreWeightId").val(value);
        }
        /*
        * 分数权重Id
       */
        get scoreWeightId() {
            return $("#txtScoreWeightId").val();
        }
        /*
        * 分数权重值
       */
        set scoreWeightValue(value) {
            $("#txtScoreWeightValue").val(value);
        }
        /*
        * 分数权重值
       */
        get scoreWeightValue() {
            return $("#txtScoreWeightValue").val();
        }
    }
    exports.SysScoreWeight_QUDI_TS = SysScoreWeight_QUDI_TS;
});
