(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js", "../TS/L0_Entity/BaseInfo/clsXzClgEN.js", "../TS/L0_Entity/CourseLearning/clscc_CourseEN.js", "../TS/L0_Entity/DailyRunning/clsvCurrEduClsEN.js", "../TS/L0_Entity/DailyRunning/clsvCurrEduClsENEx.js", "../TS/L0_Entity/SysPara/clsSchoolTermEN.js", "../TS/L0_Entity/SysPara/clsSchoolYearEN.js", "../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js", "../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsStackTrace.js", "../TS/PubFun/clsString2.js", "../TS/L0_Entity/UserManage/clsvUsersSimEN.js", "../TS/L3_ForWApi/BaseInfo/clsXzClgWApi.js", "../TS/L3_ForWApi/CourseLearning/clscc_CourseTypeWApi.js", "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsWApi.js", "../TS/L3_ForWApi/SysPara/clsSchoolTermWApi.js", "../TS/L3_ForWApi/SysPara/clsSchoolYearWApi.js", "../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js", "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js", "../TS/PubFun/clsOperateList2.js", "../TS/L3_ForWApiEx/DailyRunning/clsvCurrEduClsExWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CurrEduClsList = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:CurrEduClsCRUD
    表名:CurrEduCls(01120123)
    生成代码版本:2020.05.09.1
    生成日期:2020/05/11 16:30:23
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
    const clsCurrEduClsEN_js_1 = require("../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js");
    const clsXzClgEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsXzClgEN.js");
    const clscc_CourseEN_js_1 = require("../TS/L0_Entity/CourseLearning/clscc_CourseEN.js");
    const clsvCurrEduClsEN_js_1 = require("../TS/L0_Entity/DailyRunning/clsvCurrEduClsEN.js");
    const clsvCurrEduClsENEx_js_1 = require("../TS/L0_Entity/DailyRunning/clsvCurrEduClsENEx.js");
    const clsSchoolTermEN_js_1 = require("../TS/L0_Entity/SysPara/clsSchoolTermEN.js");
    const clsSchoolYearEN_js_1 = require("../TS/L0_Entity/SysPara/clsSchoolYearEN.js");
    const clsXzGradeBaseEN_js_1 = require("../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js");
    const clsCurrEduClsWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsStackTrace_js_1 = require("../TS/PubFun/clsStackTrace.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    //import { clszx_TextExWApi } from "../TS/L3_ForWApiEx/ZXCourseware/clszx_TextExWApi.js";
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage/clsvUsersSimEN.js");
    const clsXzClgWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsXzClgWApi.js");
    const clscc_CourseTypeWApi_js_1 = require("../TS/L3_ForWApi/CourseLearning/clscc_CourseTypeWApi.js");
    const clsvCurrEduClsWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsWApi.js");
    const clsSchoolTermWApi_js_1 = require("../TS/L3_ForWApi/SysPara/clsSchoolTermWApi.js");
    const clsSchoolYearWApi_js_1 = require("../TS/L3_ForWApi/SysPara/clsSchoolYearWApi.js");
    const clsXzGradeBaseWApi_js_1 = require("../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsvCurrEduClsExWApi_js_1 = require("../TS/L3_ForWApiEx/DailyRunning/clsvCurrEduClsExWApi.js");
    /* CurrEduClsCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class CurrEduClsList extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //记录是否导入编辑区的变量
            this.RecCount = 0;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        BindGv(strType, strPara) {
            //this.BindGv_vgs_TeachingDate();
            this.BindGv_vCurrEduCls();
        }
        BindGv_Cache(strType, strPara) {
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
        static btn_Click(strCommandName, strKeyId) {
            var objPage = new CurrEduClsList();
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    ShowDialog('AddWithMaxId');
                    objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    ShowDialog('AddWithMaxId');
                    objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage.btnAddNewRecord_Click();
                    break;
                //case "SetUpDate":            //修改记录
                //    var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
                //    if (strKeyId == "") {
                //        alert("请选择需要设置的记录！");
                //        return;
                //    }
                //    objPage.btnSetUpDateRecord_Click();
                //    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
                    if (strKeyId == "") {
                        alert("请选择需要修改的记录！");
                        return;
                    }
                    objPage.btnUpdateRecord_Click(strKeyId);
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
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
                    var strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
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
                //建立缓存
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                this.hidSortvCurrEduClsBy = "currEduClsId Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vCurrEduCls();
                $("#divLoading").hide();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
      <returns>条件串(strWhereCond)</returns>
    */
        CombinevCurrEduClsCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.CurrEduClsId_q != "") {
                    strWhereCond += ` And ${clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId} like '% ${this.CurrEduClsId_q}%'`;
                }
                if (this.eduClsName_q != "") {
                    strWhereCond += ` And ${clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName} like '% ${this.eduClsName_q}%'`;
                }
                //获取当前登陆者的角色；
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                //判断角色
                //管理员
                if (strRoleId == "00620001") {
                }
                else if (strRoleId == "00620002") {
                    strWhereCond += " And id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1')";
                }
                else {
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineCurrEduClsCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vCurrEduCls() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevCurrEduClsCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvCurrEduClsObjLst = [];
            var arrvCurrEduClsExObjLst = [];
            try {
                const responseRecCount = await (0, clsvCurrEduClsWApi_js_1.vCurrEduCls_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvCurrEduClsBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvCurrEduClsWApi_js_1.vCurrEduCls_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvCurrEduClsObjLst = jsonData;
                });
                arrvCurrEduClsExObjLst = arrvCurrEduClsObjLst.map(this.CopyToEx);
                for (var objInFor of arrvCurrEduClsExObjLst) {
                    const conFuncMap = await this.FuncMap(objInFor);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            try {
                this.BindTab_vCurrEduCls(strListDiv, arrvCurrEduClsExObjLst);
                console.log("完成BindGv_vCurrEduCls!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        ///// <summary>
        ///// 把同一个类的对象,复制到另一个对象
        ///// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyToEx)
        ///// </summary>
        ///// <param name = "objvCurrEduClsENS">源对象</param>
        ///// <returns>目标对象=>clsvCurrEduClsEN:objvCurrEduClsENT</returns>
        CopyToEx(objvCurrEduClsENS) {
            var objvCurrEduClsENT = new clsvCurrEduClsENEx_js_1.clsvCurrEduClsENEx();
            try {
                objvCurrEduClsENT = (0, clsvCurrEduClsExWApi_js_1.vCurrEduClsEx_CopyToEx)(objvCurrEduClsENS);
                return objvCurrEduClsENT;
            }
            catch (e) {
                var strMsg = clsString2_js_1.clsString.Format("(errid:WiTsCs0011)Copy表对象数据出错,${e}.({0})", clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction());
                alert(strMsg);
                return objvCurrEduClsENT;
            }
        }
        /// <summary>
        /// 把一个扩展类的部分属性进行函数转换
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap)
        /// </summary>
        /// <param name = "objvCurrEduClsS">源对象</param>
        async FuncMap(objvCurrEduCls) {
            try {
                {
                    var vUsersSim_UserId = objvCurrEduCls.modifyUserID;
                    var vUsersSim_UserName = await (0, clsvUsersSimWApi_js_1.vUsersSim_func)(clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserId, clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserName, vUsersSim_UserId);
                    objvCurrEduCls.userName = vUsersSim_UserName;
                }
                ;
            }
            catch (e) {
                var strMsg = `(errid:WiTsCs0012)函数映射表对象数据出错,${e}.(${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
            }
        }
        /* 显示vCurrEduCls对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrCurrEduClsObjLst">需要绑定的对象列表</param>
    */
        BindTab_vCurrEduCls(divContainer, arrvCurrEduClsObjLst) {
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
                    FldName: "currEduClsId",
                    ColHeader: "教学班Id",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
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
                //{
                //    FldName: "courseCode",
                //    ColHeader: "课程代码",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "courseName",
                    ColHeader: "课程",
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
                    FldName: "schoolYear",
                    ColHeader: "学年",
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
                    FldName: "memo",
                    ColHeader: "时间范围",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    SortBy: "userName",
                    ColHeader: "编辑人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 21,
                    FuncName: () => { }
                },
                //{
                //    FldName: "",
                //    ColHeader: "确定推送",
                //    Text: "确定推送", TdClass: "text-left", SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnPushEduClsTextInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvCurrEduClsObjLst, arrDataColumn, "id_CurrEduCls");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        /// </summary>
        /// <returns></returns>
        async AddDPV_Edit(divName4Edit) {
            var strUrl = "./WA_CurrEduCls_Edit/";
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
        }
        ;
        // /* 函数功能:页面导入,当页面开始运行时所发生的事件
        //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
        //*/
        // public async Page_Load_Cache() {
        //     // 在此处放置用户代码以初始化页面
        //     try {
        //         // 为查询区绑定下拉框
        //         const gvBindDdl = await this.BindDdl4QueryRegion();
        //         this.hidSortvCurrEduClsBy = "currEduClsId Asc";
        //         //2、显示无条件的表内容在GridView中
        //         const gvResult = await this.BindGv_vCurrEduCls_Cache();
        //     }
        //     catch (e) {
        //         var strMsg: string = `页面启动不成功,${e}.`;
        //         alert(strMsg);
        //     }
        // }
        /* 根据条件获取相应的对象列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
       */
        async btnQuery_Click() {
            //var strWhereCond = this.CombinevCurrEduClsCondition();
            //try {
            //    const responseRecCount = await vCurrEduCls_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
            //        this.RecCount = jsonData;
            //    });
            //    var objPagerPara: stuPagerPara = {
            //        pageIndex: 1,
            //        pageSize: this.pageSize,
            //        whereCond: strWhereCond,
            //        orderBy: this.hidSortvCurrEduClsBy
            //    };
            //    const responseObjLst = await vCurrEduCls_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
            //        var arrvCurrEduClsObjLst: Array<clsvCurrEduClsEN> = <Array<clsvCurrEduClsEN>>jsonData;
            //        this.BindTab_vCurrEduCls(this.mstrListDiv, arrvCurrEduClsObjLst);
            //    });
            //}
            //catch (e) {
            //    console.error('catch(e)=');
            //    console.error(e);
            //    var strMsg: string = `查询不成功,${e}.`;
            //    alert(strMsg);
            //}
            const gvResult = await this.BindGv_vCurrEduCls();
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
       */
        async btnAddNewRecord_Click() {
            this.OpType = "Add";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegion();
                    ShowDialog('Add');
                    this.bolIsLoadEditRegion = true; //
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
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:为编辑区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
       */
        async BindDdl4EditRegion() {
            // 在此处放置用户代码以初始化页面
            var objcc_Course_Cond = new clscc_CourseEN_js_1.clscc_CourseEN(); //编辑区域
            var objXzClg_Cond = new clsXzClgEN_js_1.clsXzClgEN(); //编辑区域
            var objXzGradeBase_Cond = new clsXzGradeBaseEN_js_1.clsXzGradeBaseEN(); //编辑区域
            var objSchoolYear_Cond = new clsSchoolYearEN_js_1.clsSchoolYearEN(); //编辑区域
            var objSchoolTerm_Cond = new clsSchoolTermEN_js_1.clsSchoolTermEN(); //编辑区域
            const ddlCourseId = await (0, clscc_CourseTypeWApi_js_1.cc_CourseType_BindDdl_CourseTypeIDInDiv_Cache)(this.divName4List, "ddlCourseId"); //编辑区域
            const ddlid_XzCollege = await (0, clsXzClgWApi_js_1.XzClg_BindDdl_id_XzCollegeInDiv_Cache)(this.divName4List, "ddlid_XzCollege"); //编辑区域
            const ddlid_GradeBase = await (0, clsXzGradeBaseWApi_js_1.XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache)(this.divName4List, "ddlid_GradeBase"); //编辑区域
            const ddlSchoolYear = await (0, clsSchoolYearWApi_js_1.SchoolYear_BindDdl_SchoolYearInDiv_Cache)(this.divName4List, "ddlSchoolYear"); //编辑区域
            const ddlSchoolTerm = await (0, clsSchoolTermWApi_js_1.SchoolTerm_BindDdl_SchoolTermInDiv_Cache)(this.divName4List, "ddlSchoolTerm"); //编辑区域
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
       */
        async btnAddNewRecordWithMaxId_Click() {
            this.OpType = "AddWithMaxId";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegion();
                    ShowDialog('Add');
                    this.bolIsLoadEditRegion = true; //
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
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:为查询区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Js_BindDdl4QueryRegion)
       */
        async BindDdl4QueryRegion() {
            // 在此处放置用户代码以初始化页面
        }
        /* 在数据表里修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
       */
        async btnUpdateRecordInTab_Click(strKeyId) {
            this.OpType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            if (this.bolIsLoadEditRegion == false) //
             {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                ShowDialog('Update');
                this.bolIsLoadEditRegion = true; //
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
        async btnDelRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText = await this.DelRecord(strKeyId);
                const responseBindGv = await this.BindGv_vCurrEduCls();
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
        async DelRecord(strid_CurrEduCls) {
            try {
                const responseText = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_DelRecordAsync)(strid_CurrEduCls);
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
        async DetailRecord(strid_CurrEduCls) {
            this.btnOKUpd = "";
            this.btnCancel = "关闭";
            try {
                const responseText = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetObjByid_CurrEduClsAsync)(strid_CurrEduCls);
                var objCurrEduClsEN = responseText;
                this.GetDataFromCurrEduClsClass(objCurrEduClsEN);
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
        async SelectRecord(strid_CurrEduCls) {
            try {
                const responseText = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetObjByid_CurrEduClsAsync)(strid_CurrEduCls);
                var objCurrEduClsEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vCurrEduCls");
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
        async btnUpdateRecord_Click(strKeyId) {
            this.OpType = "Update";
            //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            if (this.bolIsLoadEditRegion == false) //
             {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                ShowDialog('Update');
                this.bolIsLoadEditRegion = true; //
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
        async btnDelRecord_Click() {
            try {
                var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText = await this.DelMultiRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_vCurrEduCls();
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
        //public async btnExportExcel_Click() {
        //    var strWhereCond = " 1=1 ";
        //    try {
        //        const responseText = await vCurrEduCls_GetObjLstAsync(strWhereCond).then((jsonData) => {
        //            var arrvCurrEduClsObjLst: Array<clsvCurrEduClsEN> = <Array<clsvCurrEduClsEN>>jsonData;
        //            this.BindTab_vCurrEduCls(this.mstrListDiv, arrvCurrEduClsObjLst);
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
                                var returnKeyId = jsonData;
                                if (clsString2_js_1.clsString.IsNullOrEmpty(returnKeyId) == false) {
                                    HideDialog();
                                    this.BindGv_vCurrEduCls();
                                }
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.BindGv_vCurrEduCls();
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In CurrEduClsCRUD.btnOKUpd_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vCurrEduCls();
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
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevCurrEduClsConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvCurrEduCls_Cond = new clsvCurrEduClsEN_js_1.clsvCurrEduClsEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.CurrEduClsId_q != "") {
                    strWhereCond += ` And ${clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId} like '% ${this.CurrEduClsId_q}%'`;
                    objvCurrEduCls_Cond.SetCondFldValue(clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId, this.CurrEduClsId_q, "like");
                }
                if (this.eduClsName_q != "") {
                    strWhereCond += ` And ${clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName} like '% ${this.eduClsName_q}%'`;
                    objvCurrEduCls_Cond.SetCondFldValue(clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName, this.eduClsName_q, "like");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineCurrEduClsConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvCurrEduCls_Cond;
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
            this.BindGv_vCurrEduCls();
        }
        /* 函数功能:从界面列表中根据某一个字段排序
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
         <param name = "strSortByFld">排序的字段</param>
       */
        async SortBy(strSortByFld) {
            if (this.hidSortvCurrEduClsBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvCurrEduClsBy.indexOf("Asc") >= 0) {
                    this.hidSortvCurrEduClsBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvCurrEduClsBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvCurrEduClsBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_vCurrEduCls();
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
        }
        /* 获取当前表关键字值的最大值,再加1,避免重复
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetMaxStrId)
       */
        async GetMaxStrId(strKeyCtrlName) {
            this.DivName = "divGetMaxStrId";
            try {
                const responseText = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetMaxStrIdAsync)();
                var returnString = responseText.toString();
                if (returnString == "") {
                    var strInfo = `获取表CurrEduCls的最大关键字为空，不成功，请检查!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $(strKeyCtrlName).val(returnString);
                }
                else {
                    var strInfo = `获取表CurrEduCls的最大关键字为：${returnString}!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $(strKeyCtrlName).val(returnString);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        async AddNewRecord() {
            //this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucCurrEduClsB1.id_CurrEduCls = clsCurrEduClsBL.GetMaxStrId_S();
            try {
                const responseText = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetMaxStrIdAsync)();
                var returnString = responseText;
                if (returnString == "") {
                    var strInfo = `获取表CurrEduCls的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtid_CurrEduCls').val(returnString);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            //this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucCurrEduClsB1.id_CurrEduCls = clsCurrEduClsBL.GetMaxStrId_S();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjCurrEduClsEN">数据传输的目的类对象</param>
       */
        PutDataToCurrEduClsClass(pobjCurrEduClsEN) {
            pobjCurrEduClsEN.currEduClsId = this.currEduClsId; // 教学班Id
            pobjCurrEduClsEN.eduClsName = this.eduClsName; // 教学班名称
            pobjCurrEduClsEN.courseId = this.courseId; // 课程
            pobjCurrEduClsEN.id_XzCollege = this.id_XzCollege; // 学院
            pobjCurrEduClsEN.id_GradeBase = this.id_GradeBase; // 年级
            pobjCurrEduClsEN.isEffective = this.isEffective; // 是否有效
            pobjCurrEduClsEN.schoolYear = this.schoolYear; // 学年
            pobjCurrEduClsEN.schoolTerm = this.schoolTerm; // 学期
            pobjCurrEduClsEN.memo = this.memo; // 备注
            pobjCurrEduClsEN.modifyUserID = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId().toString(); // 修改人
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objCurrEduClsEN = new clsCurrEduClsEN_js_1.clsCurrEduClsEN();
            this.PutDataToCurrEduClsClass(objCurrEduClsEN);
            try {
                const responseText = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_IsExistAsync)(objCurrEduClsEN.id_CurrEduCls);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objCurrEduClsEN.id_CurrEduCls}已经存在！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_AddNewRecordAsync)(objCurrEduClsEN);
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
            var objCurrEduClsEN = new clsCurrEduClsEN_js_1.clsCurrEduClsEN();
            this.PutDataToCurrEduClsClass(objCurrEduClsEN);
            try {
                const responseText2 = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_AddNewRecordWithMaxIdAsync)(objCurrEduClsEN);
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
         <param name = "strid_CurrEduCls">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(strid_CurrEduCls) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objCurrEduClsEN = new clsCurrEduClsEN_js_1.clsCurrEduClsEN();
            try {
                const responseText = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_IsExistAsync)(strid_CurrEduCls);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${strid_CurrEduCls}] 的记录不存在!`;
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
                const responseText = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetObjByid_CurrEduClsAsync)(strid_CurrEduCls);
                objCurrEduClsEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromCurrEduClsClass(objCurrEduClsEN);
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjCurrEduClsEN">表实体类对象</param>
       */
        GetDataFromCurrEduClsClass(pobjCurrEduClsEN) {
            this.currEduClsId = pobjCurrEduClsEN.currEduClsId; // 教学班Id
            this.eduClsName = pobjCurrEduClsEN.eduClsName; // 教学班名称
            this.courseId = pobjCurrEduClsEN.courseId; // 课程
            this.id_XzCollege = pobjCurrEduClsEN.id_XzCollege; // 学院
            this.id_GradeBase = pobjCurrEduClsEN.id_GradeBase; // 年级
            this.isEffective = pobjCurrEduClsEN.isEffective; // 是否有效
            this.schoolYear = pobjCurrEduClsEN.schoolYear; // 学年
            this.schoolTerm = pobjCurrEduClsEN.schoolTerm; // 学期
            this.memo = pobjCurrEduClsEN.memo; // 备注
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(strid_CurrEduCls) {
            this.btnOKUpd = "确认修改";
            this.btnCancel = "取消修改";
            this.KeyId = strid_CurrEduCls;
            try {
                const responseText = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetObjByid_CurrEduClsAsync)(strid_CurrEduCls);
                var objCurrEduClsEN = responseText;
                this.GetDataFromCurrEduClsClass(objCurrEduClsEN);
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
            var objCurrEduClsEN = new clsCurrEduClsEN_js_1.clsCurrEduClsEN();
            objCurrEduClsEN.id_CurrEduCls = this.KeyId;
            this.PutDataToCurrEduClsClass(objCurrEduClsEN);
            objCurrEduClsEN.sf_UpdFldSetStr = objCurrEduClsEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objCurrEduClsEN.id_CurrEduCls == "" || objCurrEduClsEN.id_CurrEduCls == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_UpdateRecordAsync)(objCurrEduClsEN);
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
        async DelMultiRecord(arrid_CurrEduCls) {
            try {
                const responseText = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_DelCurrEduClssAsync)(arrid_CurrEduCls);
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
         <param name = "objCurrEduCls">需要显示的对象</param>
       */
        ShowCurrEduClsObj(divContainer, objCurrEduCls) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objCurrEduCls);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objCurrEduCls[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjCurrEduClsEN">表实体类对象</param>
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
        //确定推送
        //public async btnPushEduClsTextInTab_Click(strKeyId: string) {
        //    //获取课文Id；
        //    var strTextId = $('#hidTextId').val();
        //    var strId_CurrEduCls = strKeyId;
        //    var strUpdUser = clsPubSessionStorage.GetSession_UserId();
        //    try {
        //        //var arrKeyIds = clsCommonFunc4Web.GetCheckedKeyIds();
        //        if (strKeyId == "") {
        //            alert("请选择需要推送的记录！");
        //            return "";
        //        }
        //        //推送前查询该教学班是否已经有推送记录；
        //        var strWhere = "pushTypeId = '01' And requesTypeId = '03' And tableKey= '" + strTextId + "' And id_CurrEduCls = '" + strId_CurrEduCls + "'";
        //        const responseTextOne = await sys_RequestPush_GetFirstObjAsync(strWhere);
        //        var objsys_RequestPushEN: clssys_RequestPushEN = <clssys_RequestPushEN>responseTextOne;
        //        if (objsys_RequestPushEN != null) {
        //            var strInfo: string = `当前数据已经有推送`;
        //            //显示信息框
        //            alert(strInfo);
        //            return;
        //        }
        //        else {
        //            const responseText = await zx_TextEx_RequestPushDataToEduClsAsync(strTextId, strId_CurrEduCls, strUpdUser);
        //            var bolIs: boolean = responseText;
        //            if (bolIs == true) {
        //                var strMsg: string = `推送成功！`;
        //                alert(strMsg);
        //            }
        //            else {
        //                var strMsg: string = `推送失败！`;
        //                alert(strMsg);
        //            }
        //        }
        //        $("#divLoading").hide();
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `推送记录不成功,${e}.`;
        //        alert(strMsg);
        //        return false;
        //    }
        //}
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
        * 课程Id
       */
        set courseId(value) {
            $("#ddlCourseId").val(value);
        }
        /*
        * 课程Id
       */
        get courseId() {
            return $("#ddlCourseId").val();
        }
        /*
        * 当前教学班Id
       */
        set currEduClsId(value) {
            $("#txtCurrEduClsId").val(value);
        }
        /*
        * 当前教学班Id
       */
        get currEduClsId() {
            return $("#txtCurrEduClsId").val();
        }
        /*
        * 当前教学班Id
       */
        get CurrEduClsId_q() {
            return $("#txtCurrEduClsId_q").val();
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
        * 教学班名称
       */
        set eduClsName(value) {
            $("#txteduClsName").val(value);
        }
        /*
        * 教学班名称
       */
        get eduClsName() {
            return $("#txteduClsName").val();
        }
        /*
        * 教学班名称
       */
        get eduClsName_q() {
            return $("#txteduClsName_q").val();
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvCurrEduClsBy(value) {
            $("#hidSortvCurrEduClsBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvCurrEduClsBy() {
            return $("#hidSortvCurrEduClsBy").val();
        }
        /*
        * 用户Id
       */
        get hidUserId() {
            return $("#hidUserId").val();
        }
        /*
        * 年级流水号
       */
        set id_GradeBase(value) {
            $("#ddlid_GradeBase").val(value);
        }
        /*
        * 年级流水号
       */
        get id_GradeBase() {
            return $("#ddlid_GradeBase").val();
        }
        /*
        * 学院流水号
       */
        set id_XzCollege(value) {
            $("#ddlid_XzCollege").val(value);
        }
        /*
        * 学院流水号
       */
        get id_XzCollege() {
            return $("#ddlid_XzCollege").val();
        }
        /*
        * 是否有效
       */
        set isEffective(value) {
            $("#chkIsEffective").val(value);
        }
        /*
        * 是否有效
       */
        get isEffective() {
            return $("#chkIsEffective").prop("checked");
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
        * 修改人
       */
        get modifyUserID() {
            return $("#txtModifyUserID").val();
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
        * 学期
       */
        set schoolTerm(value) {
            $("#ddlSchoolTerm").val(value);
        }
        /*
        * 学期
       */
        get schoolTerm() {
            return $("#ddlSchoolTerm").val();
        }
        /*
        * 学年
       */
        set schoolYear(value) {
            $("#ddlSchoolYear").val(value);
        }
        /*
        * 学年
       */
        get schoolYear() {
            return $("#ddlSchoolYear").val();
        }
    }
    exports.CurrEduClsList = CurrEduClsList;
});
