(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/BaseInfo/clsXzMajorDirectionEN.js", "../TS/L0_Entity/BaseInfo/clsXzMajorEN.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvMajorDirectionPaperRelaEN.js", "../TS/L3_ForWApi/BaseInfo/clsXzMajorDirectionWApi.js", "../TS/L3_ForWApi/BaseInfo/clsXzMajorWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvMajorDirectionPaperRelaWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPubSessionStorage.js", "./MajorDirectionPaperRela_QUDI.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.MajorDirectionPaperRela_QUDIEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:MajorDirectionPaperRela_QUDI_TSEx
    表名:MajorDirectionPaperRela(01120554)
    生成代码版本:2019.12.06.1
    生成日期:2019/12/27 10:50:18
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:研究生培养
    模块英文名:GraduateEdu
    框架-层名:WA_界面脚本后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsXzMajorDirectionEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsXzMajorDirectionEN.js");
    const clsXzMajorEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsXzMajorEN.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsvMajorDirectionPaperRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvMajorDirectionPaperRelaEN.js");
    const clsXzMajorDirectionWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsXzMajorDirectionWApi.js");
    const clsXzMajorWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsXzMajorWApi.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsvMajorDirectionPaperRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvMajorDirectionPaperRelaWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const MajorDirectionPaperRela_QUDI_js_1 = require("./MajorDirectionPaperRela_QUDI.js");
    /* MajorDirectionPaperRela_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class MajorDirectionPaperRela_QUDIEx extends MajorDirectionPaperRela_QUDI_js_1.MajorDirectionPaperRela_QUDI {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvMajorDirectionPaperRelaBy: string = "mId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
            (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
          */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
                    var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                    var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                    //管理员 判断角色 
                    if (strRoleId == "00620001") {
                        $("#btnDelRecord").show();
                    }
                    else {
                        //学生00620003 教师 
                        $("#btnDelRecord").show();
                    }
                    $("#hidUserId").val(strUserId);
                    //1、为下拉框设置数据源,绑定列表数据
                    const ddl_MajorDirectionId = await this.BindDdl_MajorDirectionId("ddlMajorDirectionId");
                    const ddl_PaperId = await this.BindDdl_PaperId("ddlPaperId");
                    const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajor("ddlid_XzMajor_q");
                    this.hidSortvMajorDirectionPaperRelaBy = "MajorDirectionENName Asc";
                    var strWhereCond = this.CombinevMajorDirectionPaperRelaCondition();
                    const responseText = await (0, clsvMajorDirectionPaperRelaWApi_js_1.vMajorDirectionPaperRela_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                        this.RecCount = jsonData;
                    });
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vMajorDirectionPaperRela();
                    $("#divLoading").hide();
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[XzMajor]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind4QueryRegion)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_id_XzMajor(ddlid_XzMajor, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlid_XzMajor);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlid_XzMajor} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsXzMajorWApi_js_1.XzMajor_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrXzMajorObjLst = jsonData;
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlid_XzMajor, arrXzMajorObjLst, clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, "专业");
                        console.log("完成BindDdl_id_XzMajor!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[Paper]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_PaperId(ddlPaperId, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlPaperId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlPaperId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperWApi_js_1.Paper_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrPaperObjLst = jsonData;
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlPaperId, arrPaperObjLst, clsPaperEN_js_1.clsPaperEN.con_PaperId, clsPaperEN_js_1.clsPaperEN.con_PaperTitle, "");
                        console.log("完成BindDdl_PaperId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[XzMajorDirection]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_MajorDirectionId(ddlMajorDirectionId, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlMajorDirectionId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlMajorDirectionId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrXzMajorDirectionObjLst = jsonData;
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlMajorDirectionId, arrXzMajorDirectionObjLst, clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionId, clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.con_MajorDirectionName, "专业方向");
                        console.log("完成BindDdl_MajorDirectionId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        CombinevMajorDirectionPaperRelaCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                    strWhereCond += ` And ${clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
                }
                if (this.MajorDirectionName_q != "") {
                    strWhereCond += ` And ${clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_MajorDirectionName} like '% ${this.MajorDirectionName_q}%'`;
                }
                if (this.PaperTitle_q != "") {
                    strWhereCond += ` And ${clsvMajorDirectionPaperRelaEN_js_1.clsvMajorDirectionPaperRelaEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
                }
                //if (this.IsQuotethesis_q == true) {
                //    strWhereCond += ` And ${clsvMajorDirectionPaperRelaEN.con_IsQuotethesis} = '1'`;
                //}
                //else {
                //    strWhereCond += ` And ${clsvMajorDirectionPaperRelaEN.con_IsQuotethesis} = '0'`;
                //}
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                if (strUserId != "") {
                    $("#hidUserId").val(strUserId);
                    //判断角色 管理员
                    if (strRoleId == "00620001") {
                        $("#btnDelRecord").show();
                    }
                    ////判断角色 教师
                    //else if (objvUserRoleRelation.roleId == "00620002") {
                    //    $("#btnDelRecord").hide();
                    //    //可以查看所有；
                    //}
                    else {
                        $("#btnDelRecord").show();
                        //学生00620003
                        //只能查看自己的数据；或公开的数据；
                        strWhereCond += ` And updUser = '${strUserId}'`;
                    }
                }
                else {
                    window.top.location.href = "../Web/Login";
                    //window.location.href = "/GraduateStudyWebApp/WebApp/Login";
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineMajorDirectionPaperRelaCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 显示vMajorDirectionPaperRela对象的所有属性值
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
      <param name = "divContainer">显示容器</param>
      <param name = "arrMajorDirectionPaperRelaObjLst">需要绑定的对象列表</param>
    */
        BindTab_vMajorDirectionPaperRela(divContainer, arrvMajorDirectionPaperRelaObjLst) {
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
                    FldName: "majorDirectionName",
                    ColHeader: "研究方向名",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "MajorDirectionENName",
                    ColHeader: "研究方向英文",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "majorName",
                    ColHeader: "专业",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "IsVisible",
                //    ColHeader: "是否显示",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "paperTitle",
                    ColHeader: "论文标题",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "researchQuestion",
                //    ColHeader: "研究问题",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "keyword",
                //    ColHeader: "关键字",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "literatureSources",
                //    ColHeader: "文献来源",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "literatureLink",
                //    ColHeader: "文献链接",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "uploadfileUrl",
                //    ColHeader: "文件地址",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "isQuotethesis",
                //    ColHeader: "是否引用论文",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "checker",
                //    ColHeader: "审核人",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "isChecked",
                //    ColHeader: "是否检查",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "编辑人",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "",
                //    ColHeader: "修改",
                //    Text: "修改",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
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
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvMajorDirectionPaperRelaObjLst, arrDataColumn, "mId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjMajorDirectionPaperRelaEN">数据传输的目的类对象</param>
       */
        PutDataToMajorDirectionPaperRelaClass(pobjMajorDirectionPaperRelaEN) {
            pobjMajorDirectionPaperRelaEN.majorDirectionId = this.majorDirectionId; // 研究方向Id
            pobjMajorDirectionPaperRelaEN.paperId = this.paperId; // 论文Id
            pobjMajorDirectionPaperRelaEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjMajorDirectionPaperRelaEN.updUser = $("#hidUserId").val(); // 修改人
            pobjMajorDirectionPaperRelaEN.memo = this.memo; // 备注
        }
        /*
    * 获取年月日
    */
        getNowDate() {
            const date = new Date();
            let month = date.getMonth() + 1;
            let strDate = date.getDate();
            if (month <= 9) {
                month = "0" + month;
            }
            if (strDate <= 9) {
                strDate = "0" + strDate;
            }
            return date.getFullYear().toString() + "-" + month + "-" + strDate + " " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
        }
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        async BindGv_vMajorDirectionPaperRela() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevMajorDirectionPaperRelaCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvMajorDirectionPaperRelaObjLst = [];
            try {
                const responseRecCount = await (0, clsvMajorDirectionPaperRelaWApi_js_1.vMajorDirectionPaperRela_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvMajorDirectionPaperRelaBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvMajorDirectionPaperRelaWApi_js_1.vMajorDirectionPaperRela_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvMajorDirectionPaperRelaObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvMajorDirectionPaperRelaObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_vMajorDirectionPaperRela(strListDiv, arrvMajorDirectionPaperRelaObjLst);
                console.log("完成BindGv_vMajorDirectionPaperRela!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
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
                const responseText2 = await this.BindGv_vMajorDirectionPaperRela();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
    }
    exports.MajorDirectionPaperRela_QUDIEx = MajorDirectionPaperRela_QUDIEx;
});
