(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/BaseInfo/XzMajorDirectionCRUD.js", "../TS/L0_Entity/BaseInfo_Share/clsvXzMajorDirectionEN.js", "../TS/L0_Entity/BaseInfo_Share/clsXzMajorEN.js", "../TS/L3_ForWApi/BaseInfo_Share/clsvXzMajorDirectionWApi.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../TS/L3_ForWApiEx/BaseInfo_Share/clsXzMajorExWApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "./XzMajorDirection_EditEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzMajorDirectionCRUDEx = void 0;
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //
    //import * as QQ from "q";
    const XzMajorDirectionCRUD_js_1 = require("../PagesBase/BaseInfo/XzMajorDirectionCRUD.js");
    const clsvXzMajorDirectionEN_js_1 = require("../TS/L0_Entity/BaseInfo_Share/clsvXzMajorDirectionEN.js");
    const clsXzMajorEN_js_1 = require("../TS/L0_Entity/BaseInfo_Share/clsXzMajorEN.js");
    const clsvXzMajorDirectionWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsvXzMajorDirectionWApi.js");
    const clsXzMajorWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsXzMajorExWApi_js_1 = require("../TS/L3_ForWApiEx/BaseInfo_Share/clsXzMajorExWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const XzMajorDirection_EditEx_js_1 = require("./XzMajorDirection_EditEx.js");
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
        BindGv(strType, strPara) {
            alert('该类没有绑定该函数：[this.BindGv_XzMajorDirection]！' + strType + strPara);
            //this.BindGv_XzMajorDirection();
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "XzMajorDirection":
                    this.BindGv_vXzMajorDirection_Cache();
                    break;
                default:
                    strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                    console.error(strMsg);
                    alert(strMsg);
                    break;
            }
        }
        /*
      按钮单击,用于调用Js函数中btn_Click
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
     */
        static btn_Click(strCommandName, strKeyId) {
            let objPage;
            if (XzMajorDirectionCRUD_js_1.XzMajorDirectionCRUD.objPage_CRUD == null) {
                XzMajorDirectionCRUD_js_1.XzMajorDirectionCRUD.objPage_CRUD = new XzMajorDirectionCRUDEx();
                objPage = XzMajorDirectionCRUD_js_1.XzMajorDirectionCRUD.objPage_CRUD;
            }
            else {
                objPage = XzMajorDirectionCRUD_js_1.XzMajorDirectionCRUD.objPage_CRUD;
            }
            const objPage_Edit = new XzMajorDirection_EditEx_js_1.XzMajorDirection_EditEx(objPage);
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            let strMsg = '';
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
                    var strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    ;
                    if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                        strMsg = "请选择需要修改的记录！";
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    objPage_Edit.btnUpdateRecord_Click(strKeyId);
                    break;
                case "UpdateRecordInTab": //修改记录InTab
                    objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
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
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    if ((0, clsCommFunc4Web_js_1.confirm_del)(arrKeyIds.length) == false) {
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordInTab": //删除记录InTab 
                    objPage.btnDelRecordInTab_Click(strKeyId);
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
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
                    strMsg = '命令:' + strCommandName + "在函数(XzMajorDirectionCRUDExEx.btn_Click)中没有被处理！";
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
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
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
                    XzMajorDirectionCRUD_js_1.XzMajorDirectionCRUD.sortvXzMajorDirectionBy = "updDate Desc";
                    // var strWhereCond = await this.CombinevXzMajorDirectionCondition();
                    var objvXzMajorDirection_Cond = this.CombinevXzMajorDirectionConditionobj();
                    this.recCount = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetRecCountByCond_Cache)(objvXzMajorDirection_Cond); //.then((jsonData) => {
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vXzMajorDirection_Cache();
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
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlid_XzMajor, arrXzMajorObjLst, clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, "专业");
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
        // /* 函数功能:把界面上的属性数据传到类对象中
        //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        //  <param name = "pobjXzMajorDirectionEN">数据传输的目的类对象</param>
        //*/
        // public PutDataToXzMajorDirectionClass(pobjXzMajorDirectionEN: clsXzMajorDirectionEN) {
        //     pobjXzMajorDirectionEN.SetMajorDirectionId(this.majorDirectionId;// 研究方向Id
        //     pobjXzMajorDirectionEN.Setid_XzMajor(this.id_XzMajor;// 专业流水号
        //     pobjXzMajorDirectionEN.majorDirectionName = this.majorDirectionName;// 研究方向名
        //     pobjXzMajorDirectionEN.majorDirectionENName = this.MajorDirectionENName;// 研究方向英文名
        //     pobjXzMajorDirectionEN.majorDirectionExplain = this.MajorDirectionExplain;// 专业方向说明
        //     pobjXzMajorDirectionEN.SetIsVisible(this.isVisible;// 是否显示
        //     pobjXzMajorDirectionEN.SetUpdDate(clsPubFun4Web.getNowDate();// 修改日期
        //     pobjXzMajorDirectionEN.SetUpdUser(clsPublocalStorage.userId;// 修改人
        //     pobjXzMajorDirectionEN.SetMemo(this.memo;// 备注
        // }
        async btnQuery_Click() {
            var strWhereCond = await this.CombinevXzMajorDirectionCondition();
            try {
                const gvResult = await this.BindGv_vXzMajorDirection_Cache();
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
        async BindGv_vXzMajorDirection_Cache() {
            var strListDiv = this.divName4DataList;
            // var strWhereCond = await this.CombinevXzMajorDirectionCondition();
            var objvXzMajorDirection_Cond = this.CombinevXzMajorDirectionConditionobj();
            var strWhereCond = JSON.stringify(objvXzMajorDirection_Cond);
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvXzMajorDirectionObjLst = [];
            try {
                this.recCount = await (0, clsvXzMajorDirectionWApi_js_1.vXzMajorDirection_GetRecCountByCond_Cache)(objvXzMajorDirection_Cond);
                console.log("完成vXzMajorDirection计数!");
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: XzMajorDirectionCRUD_js_1.XzMajorDirectionCRUD.sortvXzMajorDirectionBy,
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
            //console.error(strMsg);
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
                if (this.majorDirectionName_q != "") {
                    strWhereCond += ` And ${clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionName} like '% ${this.majorDirectionName_q}%'`;
                    objvXzMajorDirectionCond.SetCondFldValue(clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionName, this.majorDirectionName_q, "=");
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
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    $("#hidUserId").val(clsPublocalStorage_js_1.clsPublocalStorage.userId);
                    //判断角色 
                    //管理员
                    if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620001") {
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
                        strWhereCond += ` And ${clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdUser} = '${clsPublocalStorage_js_1.clsPublocalStorage.userId}'`;
                        objvXzMajorDirectionCond.SetCondFldValue(clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdUser, clsPublocalStorage_js_1.clsPublocalStorage.userId, "=");
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
        async BindTab_vXzMajorDirection(divContainer, arrvXzMajorDirectionObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    fldName: "",
                    colHeader: "",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorDirectionId",
                    colHeader: "研究方向Id",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorName",
                    colHeader: "专业名称",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorDirectionName",
                    colHeader: "研究方向名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "MajorDirectionENName",
                    colHeader: "研究方向英文名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "修改日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "修改人",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "",
                //    colHeader: "修改",
                //    text: "修改",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    fldName: "",
                //    colHeader: "删除",
                //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrvXzMajorDirectionObjLst, arrDataColumn, "majorDirectionId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
    }
    exports.XzMajorDirectionCRUDEx = XzMajorDirectionCRUDEx;
});
