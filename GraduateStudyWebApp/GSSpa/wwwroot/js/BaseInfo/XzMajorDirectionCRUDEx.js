(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/BaseInfo/clsvXzMajorDirectionEN.js", "../TS/L0_Entity/BaseInfo/clsXzMajorDirectionEN.js", "../TS/L0_Entity/BaseInfo/clsXzMajorEN.js", "../TS/L3_ForWApi/BaseInfo/clsvXzMajorDirectionWApi.js", "../TS/L3_ForWApi/BaseInfo/clsXzMajorDirectionWApi.js", "../TS/L3_ForWApi/BaseInfo/clsXzMajorWApi.js", "../TS/L3_ForWApiEx/BaseInfo/clsXzMajorExWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsString2.js", "./XzMajorDirectionCRUD.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzMajorDirectionCRUDEx = void 0;
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsvXzMajorDirectionEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsvXzMajorDirectionEN.js");
    const clsXzMajorDirectionEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsXzMajorDirectionEN.js");
    const clsXzMajorEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsXzMajorEN.js");
    const clsvXzMajorDirectionWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsvXzMajorDirectionWApi.js");
    const clsXzMajorDirectionWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsXzMajorDirectionWApi.js");
    const clsXzMajorWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsXzMajorWApi.js");
    const clsXzMajorExWApi_js_1 = require("../TS/L3_ForWApiEx/BaseInfo/clsXzMajorExWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    const XzMajorDirectionCRUD_js_1 = require("./XzMajorDirectionCRUD.js");
    /* WApiXzMajorDirectionCRUD_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class XzMajorDirectionCRUDEx extends XzMajorDirectionCRUD_js_1.XzMajorDirectionCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvXzMajorDirectionBy: string = "majorDirectionId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        /*
      按钮单击,用于调用Js函数中btn_Click
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
     */
        static btn_Click(strCommandName, strKeyId) {
            var objPage = new XzMajorDirectionCRUDEx();
            //var objPage_Edit: XzMajorDirectionCRUDEx = new XzMajorDirectionCRUDEx(objPage);
            switch (strCommandName) {
                case "Query": //查询记录
                    //objPage.btnQuery_Click(this.li);
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    //objPage_Edit.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
                    if (clsString2_js_1.clsString.IsNullOrEmpty(strKeyId) == true) {
                        var strMsg = "请选择需要修改的记录！";
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    objPage.btnUpdateRecord_Click(strKeyId);
                    break;
                case "UpdateRecordInTab": //修改记录InTab
                    objPage.btnUpdateRecordInTab_Click(strKeyId);
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
                case "ExportExcel": //导出Excel
                    //objPage.btnExportExcel_Click();
                    //alert("导出Excel功能还没有开通！");
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    if (clsCommonFunc4Web2_js_1.clsCommonFunc4Web.confirm_del(arrKeyIds.length) == false) {
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordInTab": //删除记录InTab 
                    objPage.btnDelRecordInTab_Click(strKeyId);
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
                    var strMsg = '命令:' + strCommandName + "在函数(XzMajorDirectionCRUDExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
           (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
         */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                if (strUserId != "") {
                    //加载所需缓存
                    //加载页面所需数据源到缓存
                    const arrXzMajor_Cache = await (0, clsXzMajorWApi_js_1.XzMajor_GetObjLstAsync)("1=1");
                    const arrvPaper_Cache = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetObjLstAsync)("1=1");
                    //管理员 判断角色 
                    if (strRoleId == "00620001") {
                        $("#btnDelRecord").show();
                    }
                    else {
                        //学生00620003 教师 
                        $("#btnDelRecord").hide();
                    }
                    $("#hidUserId").val(strUserId);
                    //1、为下拉框设置数据源,绑定列表数据
                    //const ddl_id_XzMajor = await this.BindDdl_id_XzMajor_Catche("ddlid_XzMajor", new clsXzMajorEN);
                    //const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajor_Catche("ddlid_XzMajor_q", new clsXzMajorEN);
                    const ddl_id_XzMajor = await this.BindDdl_id_XzMajor("ddlid_XzMajor");
                    const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajor("ddlid_XzMajor_q");
                    this.hidSortvXzMajorDirectionBy = "updDate Desc";
                    // var strWhereCond = this.CombinevXzMajorDirectionCondition();
                    var objvXzMajorDirection_Cond = this.CombinevXzMajorDirectionConditionobj();
                    this.RecCount = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetRecCountByCond_Cache)(objvXzMajorDirection_Cond); //.then((jsonData) => {
                    //    this.RecCount = jsonData;
                    //});
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vXzMajorDirection();
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
                        arrXzMajorObjLst = arrXzMajorObjLst.sort(clsXzMajorExWApi_js_1.XzMajorEx_SortFun_majorName);
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
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjXzMajorDirectionEN">数据传输的目的类对象</param>
       */
        PutDataToXzMajorDirectionClass(pobjXzMajorDirectionEN) {
            pobjXzMajorDirectionEN.majorDirectionId = this.majorDirectionId; // 研究方向Id
            pobjXzMajorDirectionEN.id_XzMajor = this.id_XzMajor; // 专业流水号
            pobjXzMajorDirectionEN.majorDirectionName = this.majorDirectionName; // 研究方向名
            pobjXzMajorDirectionEN.majorDirectionENName = this.MajorDirectionENName; // 研究方向英文名
            pobjXzMajorDirectionEN.majorDirectionExplain = this.MajorDirectionExplain; // 专业方向说明
            pobjXzMajorDirectionEN.isVisible = this.IsVisible; // 是否显示
            pobjXzMajorDirectionEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjXzMajorDirectionEN.updUser = $("#hidUserId").val(); // 修改人
            pobjXzMajorDirectionEN.memo = this.memo; // 备注
        }
        async btnQuery_Click(strListDiv) {
            var strWhereCond = this.CombinevXzMajorDirectionCondition();
            try {
                const gvResult = await this.BindGv_vXzMajorDirection();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `查询不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的记录对象的列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
      */
        async BindGv_vXzMajorDirection() {
            var strListDiv = this.mstrListDiv;
            // var strWhereCond = this.CombinevXzMajorDirectionCondition();
            var objvXzMajorDirection_Cond = this.CombinevXzMajorDirectionConditionobj();
            var strWhereCond = JSON.stringify(objvXzMajorDirection_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvXzMajorDirectionObjLst = [];
            try {
                //const responseRecCount = await vXzMajorDirection_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    this.RecCount = jsonData;
                //});
                this.RecCount = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetRecCountByCond_Cache)(objvXzMajorDirection_Cond);
                console.log("完成vXzMajorDirection计数!");
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvXzMajorDirectionBy,
                    sortFun: (x, y) => { return 0; }
                };
                arrvXzMajorDirectionObjLst = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetObjLstByPager_Cache)(objPagerPara);
                console.log("完成vXzMajorDirection对象列表!");
                //const responseObjLst = await vXzMajorDirection_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                //    arrvXzMajorDirectionObjLst = <Array<clsvXzMajorDirectionEN>>jsonData;
                //});
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvXzMajorDirectionObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_vXzMajorDirection(strListDiv, arrvXzMajorDirectionObjLst);
                console.log("完成BindGv_vXzMajorDirection!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
       <returns>条件串(strWhereCond)</returns>
     */
        CombinevXzMajorDirectionConditionobj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvXzMajorDirectionCond = new clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                    strWhereCond += ` And ${clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
                    objvXzMajorDirectionCond.SetCondFldValue(clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_id_XzMajor, this.id_XzMajor_q, "=");
                }
                if (this.MajorDirectionName_q != "") {
                    strWhereCond += ` And ${clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionName} like '% ${this.MajorDirectionName_q}%'`;
                    objvXzMajorDirectionCond.SetCondFldValue(clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionName, this.MajorDirectionName_q, "=");
                }
                //if (this.MajorDirectionENName_q != "") {
                //    strWhereCond += ` And ${clsvXzMajorDirectionEN.con_MajorDirectionENName} like '% ${this.MajorDirectionENName_q}%'`;
                //}
                //if (this.IsVisible_q == true) {
                //    strWhereCond += ` And ${clsvXzMajorDirectionEN.con_IsVisible} = '1'`;
                //}
                //else {
                //    strWhereCond += ` And ${clsvXzMajorDirectionEN.con_IsVisible} = '0'`;
                //}
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
                    $("#hidUserId").val(clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
                    //判断角色 
                    //管理员
                    if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId() == "00620001") {
                        $("#btnDelRecord").show();
                    }
                    //else if (objvUserRoleRelation.roleId == "00620002") {
                    //    //教师
                    //    $("#btnDelRecord").hide();
                    //    //可以查看所有；
                    //}
                    else {
                        //学生；
                        $("#btnDelRecord").hide();
                        //学生00620003
                        //只能查看自己的数据
                        strWhereCond += ` And ${clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdUser} = '${$("#hidUserId").val()}'`;
                        objvXzMajorDirectionCond.SetCondFldValue(clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdUser, $("#hidUserId").val(), "=");
                    }
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineXzMajorDirectionCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvXzMajorDirectionCond;
        }
        /* 显示vXzMajorDirection对象的所有属性值
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
       <param name = "divContainer">显示容器</param>
       <param name = "arrXzMajorDirectionObjLst">需要绑定的对象列表</param>
     */
        BindTab_vXzMajorDirection(divContainer, arrvXzMajorDirectionObjLst) {
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
                    FldName: "majorDirectionId",
                    ColHeader: "研究方向Id",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "majorName",
                    ColHeader: "专业名称",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
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
                    ColHeader: "研究方向英文名",
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
                    FldName: "userName",
                    ColHeader: "修改人",
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
                //        btn1.className = "btn btn-outline-info";
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
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvXzMajorDirectionObjLst, arrDataColumn, "majorDirectionId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
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
                                    this.BindGv_vXzMajorDirection();
                                }
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.BindGv_vXzMajorDirection();
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_ReFreshCache)();
                                HideDialog();
                                this.BindGv_vXzMajorDirection();
                            }
                        });
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                        alert(strMsg);
                        break;
                }
                $('#divLoading').hide();
                //去掉提交按钮不可用状态
                $('#btnOKUpd').attr("disabled", false);
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        UpdateRecord(strMajorDirectionId) {
            this.btnOKUpd = "确认修改";
            this.btnCancel = "取消修改";
            this.KeyId = strMajorDirectionId;
            var strUserId = $("#hidUserId").val();
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_GetObjByMajorDirectionIdAsync)(strMajorDirectionId).then((jsonData) => {
                        var objXzMajorDirectionEN = jsonData;
                        // //通过判断数据用户是否是当前登录用户；
                        if (objXzMajorDirectionEN.updUser == strUserId) {
                            ShowDialog('Update');
                            this.GetDataFromXzMajorDirectionClass(objXzMajorDirectionEN);
                            console.log("完成UpdateRecord!");
                            resolve(jsonData);
                        }
                        else {
                            alert("当前数据不是您所添加，不能修改！");
                            return;
                        }
                    });
                }
                catch (e) {
                    console.error(e);
                    var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            try {
                const responseText = (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_GetMaxStrIdAsync)().then((jsonData) => {
                    var returnString = jsonData.toString();
                    if (returnString == "") {
                        var strInfo = `获取表XzMajorDirection的最大关键字为空，不成功，请检查!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        $('#txtMajorDirectionId').val(returnString);
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
            this.DivName = "divAddNewRecordSave";
            var objXzMajorDirectionEN = new clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN();
            this.PutDataToXzMajorDirectionClass(objXzMajorDirectionEN);
            try {
                //const responseText = await XzMajorDirection_IsExistAsync(objXzMajorDirectionEN.majorDirectionId);
                //var bolIsExist: boolean = responseText;
                //if (bolIsExist == true) {
                //    var strMsg: string = `添加记录时，关键字：${objXzMajorDirectionEN.majorDirectionId}已经存在！`;
                //    alert(strMsg);
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
                const responseText2 = await (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_AddNewRecordAsync)(objXzMajorDirectionEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_ReFreshCache)();
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult40').val(strInfo);
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
            }
            return true; //一定要有一个返回值，否则会出错！
        }
    }
    exports.XzMajorDirectionCRUDEx = XzMajorDirectionCRUDEx;
});
