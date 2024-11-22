(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/BaseInfo_Share/clsTeacherInfoEN.js", "../TS/L3_ForWApi/BaseInfo_Share/clsTeacherInfoWApi.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/FunClass_Share/clsPubVar4Web.js", "../TS/L0_Entity/DailyRunning_Share/clsCurrEduClsTeacherEN.js", "../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsTeacherWApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../PagesBase/BaseInfo_Share/TeacherInfoCRUD.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.TeacherList = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:spaTeacherInfoCRUD
    表名:TeacherInfo(01120093)
    生成代码版本:2020.08.20.1
    生成日期:2020/08/28 00:07:07
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:101.251.68.133,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:基本信息维护
    模块英文名:BaseInfo
    框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsTeacherInfoEN_js_1 = require("../TS/L0_Entity/BaseInfo_Share/clsTeacherInfoEN.js");
    const clsTeacherInfoWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsTeacherInfoWApi.js");
    //import { clsTeacherInfoWApi } from "../TS/L3_ForWApi/BaseInfo_Share/clsTeacherInfoWApi.js";
    //import { clsTeacherInfoBL } from "../TS/L3_ForWApi/BaseInfo_Share/clsTeacherInfoWApi.js";
    //import { clsTeacherInfoEN } from "../TS/L0_Entity/BaseInfo_Share/clsTeacherInfoEN.js";
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPubVar4Web_js_1 = require("../TS/FunClass_Share/clsPubVar4Web.js");
    const clsCurrEduClsTeacherEN_js_1 = require("../TS/L0_Entity/DailyRunning_Share/clsCurrEduClsTeacherEN.js");
    const clsCurrEduClsTeacherWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsTeacherWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const TeacherInfoCRUD_js_1 = require("../PagesBase/BaseInfo_Share/TeacherInfoCRUD.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* spaTeacherInfoCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class TeacherList extends TeacherInfoCRUD_js_1.TeacherInfoCRUD {
        constructor() {
            //public static divName4List: string = "divDataLst";
            //public static mstrSortTeacherInfoBy: string = "id_Teacher";
            super(...arguments);
            this.divName4List = "divDataLst"; //列表区数据列表层id
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.bolIsLoadDetailRegion = false; //记录是否导入详细信息区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.divName4Detail = "divDetail"; //详细信息区的Id
            this.recCount = 0;
        }
        BindGv(strType) {
            this.BindGv_TeacherInfo();
        }
        BindGv_Cache(strType) {
            switch (strType) {
                case "TeacherInfo":
                    alert('该类没有绑定该函数：[this.BindGv_TeacherInfo_Cache]！');
                    //this.BindGv_TeacherInfo_Cache();
                    break;
            }
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        /*
       按钮单击,用于调用Js函数中btn_Click
      (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
      */
        static btn_Click(strCommandName, strKeyId) {
            var objPage = new TeacherList();
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    var arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    var arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordInTab": //删除记录InTab 
                    objPage.btnDelRecordInTab_Click(strKeyId);
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    var arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    var arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    var arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    var arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    var arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    var arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要下移的记录！");
                        return;
                    }
                    //objPage.btnDownMove_Click();
                    break;
                case "ReOrder": //重序记录
                    //objPage.btnReOrder_Click();
                    break;
                default:
                    var strMsg = '命令:' + strCommandName + "在函数(TeacherListEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
                case "ExportExcel": //导出Excel
                    alert("导出Excel功能还没有开通！");
                    break;
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                this.hidSortTeacherInfoBy = "TeacherName Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_TeacherInfo();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
       */
        async Page_Load_Cache() {
            // 在此处放置用户代码以初始化页面
            try {
                this.hidSortTeacherInfoBy = "TeacherName Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_TeacherInfo();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
       */
        async btnQuery_Click() {
            const responseBindGv = await this.BindGv_TeacherInfo();
        }
        /* 函数功能:为查询区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
       */
        async BindDdl4QueryRegion() {
            // 在此处放置用户代码以初始化页面
        }
        /*
         添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnCopyRecord_Click)
        */
        async btnCopyRecord_Click() {
            try {
                var arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(this.divName4DataList);
                if (arrKeyIds.length == 0) {
                    alert("请选择需要克隆的记录！");
                    return "";
                }
                const responseText = await this.CopyRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_TeacherInfo();
            }
            catch (e) {
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `复制记录不成功,${e}.`;
                alert(strMsg);
            }
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
                const responseBindGv = await this.BindGv_TeacherInfo();
            }
            catch (e) {
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        在数据表里选择记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
       */
        async btnSelectRecordInTab_Click(strid_Teacher) {
            try {
                if (strid_Teacher == "") {
                    alert("请选择需要删除的记录！");
                    return;
                }
                this.SelectRecord(strid_Teacher);
            }
            catch (e) {
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `选择记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        async DelRecord(strid_Teacher) {
            try {
                const responseText = await (0, clsTeacherInfoWApi_js_1.TeacherInfo_DelRecordAsync)(strid_Teacher);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //TeacherInfo_ReFreshCache();
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
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字选择相应的记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
         <param name = "sender">参数列表</param>
       */
        async SelectRecord(strid_Teacher) {
            try {
                const responseText = await (0, clsTeacherInfoWApi_js_1.TeacherInfo_GetObjByid_TeacherAsync)(strid_Teacher);
                var objTeacherInfoEN = responseText;
                console.log("完成SelectRecord!");
                (0, clsCommFunc4Web_js_1.Redirect)("/Index/Main_TeacherInfo");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /* 删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
       */
        async btnDelRecord_Click() {
            try {
                var arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(this.divName4DataList);
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText = await this.DelMultiRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_TeacherInfo();
            }
            catch (e) {
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        // /* 根据条件获取相应的对象列表
        //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
        //*/
        // public async btnExportExcel_Click() {
        //     var strWhereCond = " 1=1 ";
        //     try {
        //         const responseText = await TeacherInfo_GetObjLstAsync(strWhereCond).then((jsonData) => {
        //             var arrTeacherInfoObjLst: Array<clsTeacherInfoEN> = <Array<clsTeacherInfoEN>>jsonData;
        //             this.BindTab_TeacherInfo(this.divName4List, arrTeacherInfoObjLst);
        //         });
        //     }
        //     catch (e) {
        //         console.log('catch(e)=');
        //         console.error(e);
        //         var strMsg: string = `导出Excel不成功,${e}.`;
        //         alert(strMsg);
        //     }
        // }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        CombineTeacherInfoCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0009)在组合查询条件(CombineTeacherInfoCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        CombineTeacherInfoConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objTeacherInfo_Cond = new clsTeacherInfoEN_js_1.clsTeacherInfoEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0010)在组合查询条件对象(CombineTeacherInfoConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objTeacherInfo_Cond;
        }
        /* 显示TeacherInfo对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrTeacherInfoObjLst">需要绑定的对象列表</param>
       */
        async BindTab_TeacherInfo(divContainer, arrTeacherInfoObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    fldName: "",
                    sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    colHeader: "",
                    text: "",
                    tdClass: "text-left",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "TeacherID",
                    sortBy: "TeacherID", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    colHeader: "教师Id",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: () => { }
                },
                {
                    fldName: "TeacherName",
                    sortBy: "TeacherName", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    colHeader: "教师姓名",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "确定",
                    text: "确定", tdClass: "text-left", sortBy: "", getDataSource: "", sortFun: clsPubVar4Web_js_1.clsPubVar4Web.sortFun,
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnCurrEduClsInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                //{
                //    fldName: "",
                //    sortBy: "", getDataSource: "", sortFun: clsPubVar4Web.sortFun,
                //    colHeader: "修改",
                //    text: "修改",
                //    tdClass: "text-left",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btn_Click('UpdateRecordInTab', '${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    fldName: "",
                //    sortBy: "", getDataSource: "", sortFun: clsPubVar4Web.sortFun,
                //    colHeader: "删除",
                //    text: "删除",
                //    tdClass: "text-left",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btn_Click('DelRecordInTab', '${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            await (0, clsCommFunc4Web_js_1.BindTab)(o, arrTeacherInfoObjLst, arrDataColumn, "id_Teacher", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        //确定选择 并添加到关系表中
        async btnCurrEduClsInTab_Click(strkeyId) {
            const response = await this.AddNewRecordSaveCurrEduClsTeacher(strkeyId);
        }
        /* 添加新记录，保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
        async AddNewRecordSaveCurrEduClsTeacher(strid_Teacher) {
            // this.DivName = "divAddNewRecordSave";
            var strCurrEduClsId = $('#hidCurrEduClsId').val();
            var strId_Teacher = strid_Teacher;
            var objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN();
            const responseText = await this.PutDataToCurrEduClsTeacher(objCurrEduClsTeacherEN, strid_Teacher);
            try {
                //同一用户，同一主题 同一观点 只能添加一次；
                var strWhere = " 1 = 1 And id_CurrEduCls = '" + strCurrEduClsId + "' And Id_Teacher = '" + strId_Teacher + "'";
                //var strWhere = " 1 = 1 And TopicId = '" + strTopicId + "' And ViewpointId = '" + strViewpointId + "'";
                const responseText = await (0, clsCurrEduClsTeacherWApi_js_1.CurrEduClsTeacher_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `您已经加入过该教学班了！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsCurrEduClsTeacherWApi_js_1.CurrEduClsTeacher_AddNewRecordAsync)(objCurrEduClsTeacherEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    //关闭列表
                    CloseWindow();
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
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjCurrEduClsTeacherEN">数据传输的目的类对象</param>
    */
        async PutDataToCurrEduClsTeacher(pobjCurrEduClsTeacherEN, strid_Teacher) {
            var strCurrEduClsId = $('#hidCurrEduClsId').val();
            pobjCurrEduClsTeacherEN.id_CurrEduCls = strCurrEduClsId; // 教学班
            //获取用户，通过用户Id 查询学生表数据得到学生流水号；
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strid_TeacherInfo = "";
            var strSchoolTeam = "";
            var strSchoolYear = "";
            //var strWhereCond = `1=1 And ${clsTeacherInfoEN.con_StuID} = '${strUserId}'`;
            //const responseText = await TeacherInfo_GetFirstObjAsync(strWhereCond).then((jsonData) => {
            //    var objTeacherInfoEN: clsTeacherInfoEN = <clsTeacherInfoEN>jsonData;
            //    if (objTeacherInfoEN != null) {
            //        strid_TeacherInfo = objTeacherInfoEN.id_TeacherInfo;
            //    }
            //})
            pobjCurrEduClsTeacherEN.id_Teacher = strid_Teacher; // 老
            //pobjCurrEduClsTeacherEN.schoolTerm = this.schoolTerm;// 学期
            //pobjCurrEduClsTeacherEN.schoolYear = this.schoolYear;// 学年
            pobjCurrEduClsTeacherEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd(); // 
            pobjCurrEduClsTeacherEN.updUser = strUserId; //
            // pobjCurrEduClsTeacherEN.memo = this.memo;// 备注
        }
        /* 函数功能:在数据 列表中跳转到某一页
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
         <param name = "intPageIndex">页序号</param>
       */
        //public async IndexPage(intPageIndex) {
        //    if (intPageIndex == 0) {
        //        intPageIndex = this.objPager.PageCount;
        //    }
        //    console.log("跳转到" + intPageIndex + "页");
        //    this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        //    const responseBindGv = await this.BindGv_TeacherInfo();
        //}
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_TeacherInfo() {
            if (this.hidSortTeacherInfoBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortTeacherInfoBy)为空，请检查！(In BindGv_TeacherInfo)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.CombineTeacherInfoCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrTeacherInfoObjLst = [];
            try {
                const responseRecCount = await (0, clsTeacherInfoWApi_js_1.TeacherInfo_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.recCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortTeacherInfoBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsTeacherInfoWApi_js_1.TeacherInfo_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrTeacherInfoObjLst = jsonData;
                });
            }
            catch (e) {
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
            try {
                this.BindTab_TeacherInfo(strListDiv, arrTeacherInfoObjLst);
                console.log("完成BindGv_TeacherInfo!");
            }
            catch (e) {
                console.log('catch(e)=');
                console.error(e);
                //console.trace();
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
       */
        async BindGv_TeacherInfo_Cache() {
            if (this.hidSortTeacherInfoBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortTeacherInfoBy)为空，请检查！(In BindGv_TeacherInfo_Cache)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.divName4DataList;
            var objTeacherInfo_Cond = await this.CombineTeacherInfoConditionObj();
            var strWhereCond = JSON.stringify(objTeacherInfo_Cond);
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrTeacherInfoObjLst = [];
            try {
                this.recCount = await (0, clsTeacherInfoWApi_js_1.TeacherInfo_GetRecCountByCond_Cache)(objTeacherInfo_Cond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortTeacherInfoBy,
                    sortFun: (x, y) => { return 0; }
                };
                var arrTeacherInfoObjLst = await (0, clsTeacherInfoWApi_js_1.TeacherInfo_GetObjLstByPager_Cache)(objPagerPara);
            }
            catch (e) {
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
                return;
            }
            if (arrTeacherInfoObjLst.length == 0) {
                var strKey = `${clsTeacherInfoEN_js_1.clsTeacherInfoEN._CurrTabName}`;
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_TeacherInfo(strListDiv, arrTeacherInfoObjLst);
                console.log("完成BindGv_TeacherInfo!");
            }
            catch (e) {
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:从界面列表中根据某一个字段排序
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
         <param name = "strSortByFld">排序的字段</param>
       */
        async sortBy(strSortByFld) {
            if (this.hidSortTeacherInfoBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortTeacherInfoBy.indexOf("Asc") >= 0) {
                    this.hidSortTeacherInfoBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortTeacherInfoBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortTeacherInfoBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_TeacherInfo();
        }
        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        SetKeyReadOnly(bolReadonly) {
            $('#txtid_Teacher').prop['ReadOnly'] = bolReadonly;
        }
        /* 复制记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
       */
        async CopyRecord(arrid_Teacher) {
            try {
                const responseText = await (0, clsTeacherInfoWApi_js_1.TeacherInfo_GetObjLstByid_TeacherLstAsync)(arrid_Teacher);
                console.log('responseText=');
                console.log(responseText);
                var intCount = 0;
                var arrTeacherInfoObjLst = responseText;
                for (let objInFor of arrTeacherInfoObjLst) {
                    const responseText2 = await (0, clsTeacherInfoWApi_js_1.TeacherInfo_AddNewRecordAsync)(objInFor);
                    console.log('responseText2=');
                    console.log(responseText2);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        var strInfo = `克隆记录成功!`;
                        intCount++;
                    }
                    else {
                        var strInfo = `克隆记录不成功!`;
                        //显示信息框
                        alert(strInfo);
                    }
                }
                var strInfo = `共克隆了${intCount}条记录!`;
                alert(strInfo);
                console.log('完成！');
            }
            catch (e) {
                var strMsg = `复制记录不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /* 根据关键字列表删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
       */
        async DelMultiRecord(arrid_Teacher) {
            try {
                const responseText = await (0, clsTeacherInfoWApi_js_1.TeacherInfo_DelTeacherInfosAsync)(arrid_Teacher);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //TeacherInfo_ReFreshCache();
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
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 显示{0}对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
         <param name = "divContainer">显示容器</param>
         <param name = "objTeacherInfo">需要显示的对象</param>
       */
        ShowTeacherInfoObj(divContainer, objTeacherInfo) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objTeacherInfo);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objTeacherInfo[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjTeacherInfoEN">表实体类对象</param>
        <returns>列表的第一个关键字值</returns>
       */
        //public GetFirstKey(): string {
        //    if (arrSelectedKeys.length == 1) {
        //        return arrSelectedKeys[0];
        //    }
        //    else {
        //        alert(`请选择一个关键字！目前选择了:${arrSelectedKeys.length}个关键字。`);
        //        return "";
        //    }
        //}
        /*
        设置Session
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
        <param name = "Key">关键字</param>
        <param name = "Value">值</param>
        */
        SetSessionAsync(Key, value) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl_Session_SetString,
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key,
                        value: value
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
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
        * 获取当前页序号(Used In BindGv_)
       */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortTeacherInfoBy(value) {
            $("#hidSortTeacherInfoBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortTeacherInfoBy() {
            return $("#hidSortTeacherInfoBy").val();
        }
    }
    exports.TeacherList = TeacherList;
});
