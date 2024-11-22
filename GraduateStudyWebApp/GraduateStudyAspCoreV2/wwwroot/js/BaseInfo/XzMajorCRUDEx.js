/*-- -- -- -- -- -- -- -- -- -- --
类名:XzMajorCRUDEx
表名:XzMajor(01120065)
生成代码版本:2020.05.06.1
生成日期:2020/05/07 20:53:31
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:基本信息维护
模块英文名:BaseInfo
框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == ==
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/BaseInfo/XzMajorCRUD.js", "../TS/L0_Entity/BaseInfo_Share/clsvXzMajorEN.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "./XzMajor_EditEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzMajorCRUDEx = void 0;
    const XzMajorCRUD_js_1 = require("../PagesBase/BaseInfo/XzMajorCRUD.js");
    const clsvXzMajorEN_js_1 = require("../TS/L0_Entity/BaseInfo_Share/clsvXzMajorEN.js");
    const clsXzMajorWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const XzMajor_EditEx_js_1 = require("./XzMajor_EditEx.js");
    /* XzMajorCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
   */
    class XzMajorCRUDEx extends XzMajorCRUD_js_1.XzMajorCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvXzMajorBy: string = "id_XzMajor";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType, strPara) {
            this.BindGv_vXzMajor();
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "vXzMajor":
                    alert('该类没有绑定该函数：[this.BindGv_vXzMajor_Cache]！');
                    //this.BindGv_vXzMajor_Cache();
                    break;
                default:
                    strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                    console.error(strMsg);
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
                //建立缓存
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                XzMajorCRUD_js_1.XzMajorCRUD.sortvXzMajorBy = "majorID Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vXzMajor();
                $("#divLoading").hide();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            let objPage;
            if (XzMajorCRUD_js_1.XzMajorCRUD.objPage_CRUD == null) {
                XzMajorCRUD_js_1.XzMajorCRUD.objPage_CRUD = new XzMajorCRUDEx();
                objPage = XzMajorCRUD_js_1.XzMajorCRUD.objPage_CRUD;
            }
            else {
                objPage = XzMajorCRUD_js_1.XzMajorCRUD.objPage_CRUD;
            }
            const objPage_Edit = new XzMajor_EditEx_js_1.XzMajor_EditEx(objPage);
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            let strMsg = '';
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    ShowDialog('AddWithMaxId');
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage_Edit.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    ;
                    if (strKeyId == "") {
                        alert("请选择需要修改的记录！");
                        return;
                    }
                    objPage_Edit.btnUpdateRecord_Click(strKeyId);
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordBySign": //按标志删除记录
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
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
                    strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
                case "ExportExcel": //导出Excel
                    alert("导出Excel功能还没有开通！");
                    break;
            }
        }
        /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
    */
        //public async AddNewRecord() {
        //    //去掉提交按钮不可用状态
        //    $('#btnOKUpd').attr("disabled", false);
        //    this.opType = "AddWithMaxId";
        //  //  this.SetKeyReadOnly(false);
        //    this.btnOKUpd = "确认添加";
        //    this.btnCancel = "取消添加";
        //    this.Clear();
        //    //wucXzMajorB1.id_XzMajor = clsXzMajorBL.GetMaxStrId_S();
        //    try {
        //        const responseText = await XzMajor_GetMaxStrIdAsync();
        //        var returnString: string = responseText;
        //        if (returnString == "") {
        //            var strInfo: string = `获取表XzMajor的最大关键字为空，不成功，请检查!`;
        //            //显示信息框
        //            alert(strInfo);
        //        }
        //        else {
        //            $('#txtid_XzMajor').val(returnString);
        //        }
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        //public AddNewRecordWithMaxId() {
        //    //去掉提交按钮不可用状态
        //    $('#btnOKUpd').attr("disabled", false);
        //    this.opType = "AddWithMaxId";
        // //   this.SetKeyReadOnly(false);
        //    this.btnOKUpd = "确认添加";
        //    this.btnCancel = "取消添加";
        //    this.Clear();
        //    //wucXzMajorB1.id_XzMajor = clsXzMajorBL.GetMaxStrId_S();
        //}
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
    */
        async CombinevXzMajorCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.majorID_q != "") {
                    strWhereCond += ` And ${clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorID} like '% ${this.majorID_q}%'`;
                }
                if (this.majorName_q != "") {
                    strWhereCond += ` And ${clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorName} like '% ${this.majorName_q}%'`;
                }
                if (this.id_XzCollege_q != null && this.id_XzCollege_q != "0") {
                    strWhereCond += ` And ${clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzCollege} = '${this.id_XzCollege_q}'`;
                }
                ////读取session角色 来判断绑定不同数据列表
                ////获取用户角色来判断显示不同的列表数据；
                //var strUserId = clsPublocalStorage.userId;
                //var strRoleId = clsPublocalStorage.roleId;
                ////判断角色 
                ////管理员
                //if (strRoleId == "00620001") {
                //}
                //else if (strRoleId == "00620002") {
                //    //教师
                //    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                //    strWhereCond += ` And ${clsvXzMajorEN.con_ModifyDate} = '${strUserId}'`;
                //    //strWhereCond += " and updUser in (select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage.id_CurrEduCls + "') or updUser = '" + strUserId + "'";
                //}
                //else {
                //    ////学生； 
                //    //strWhereCond += ` And ${clsvXzMajorEN.con_ModifyDate} = '${strUserId}'`;
                //    ////学生00620003
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineXzMajorCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 添加新记录 需要 通过权限判断  管理员登录可以添加学院专业，教师只能添加非学院专业
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
       */
        /* 删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
    */
        async btnDelRecord_Click() {
            try {
                var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                //需要判断当前数据中是否包含已提交数据、如果有则不能删除
                var strKeyList;
                if (arrKeyIds.length == 0)
                    return "";
                strKeyList = "";
                for (var i = 0; i < arrKeyIds.length; i++) {
                    if (i == 0)
                        strKeyList = strKeyList + "'" + arrKeyIds[i].toString() + "'";
                    else
                        strKeyList += "," + "'" + arrKeyIds[i].toString() + "'";
                }
                //
                //获取用户角色来判断显示不同的列表数据；
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strWhereCond = " id_XzMajor in (" + strKeyList + ")";
                var arrXzmajorObjLst = [];
                const responseText1 = await (0, clsXzMajorWApi_js_1.XzMajor_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrXzmajorObjLst = jsonData;
                    //查询是否有提交的数据
                    arrXzmajorObjLst = arrXzmajorObjLst.filter(x => x.modifyUserID != strUserId);
                    if (arrXzmajorObjLst.length > 0) {
                        alert("包含其他用户添加数据，不能删除！");
                        return "";
                    }
                });
                const responseText = await this.DelMultiRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_vXzMajor();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vXzMajor对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrXzMajorObjLst">需要绑定的对象列表</param>
    */
        async BindTab_vXzMajor(divContainer, arrvXzMajorObjLst) {
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
                    fldName: "majorID",
                    colHeader: "专业ID",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorName",
                    colHeader: "专业名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorEnglishName",
                    colHeader: "英文名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "collegeName",
                    colHeader: "学院名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "majorDirection",
                    colHeader: "专业方向",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "modifyDate",
                    colHeader: "修改日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "modifyUserID",
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
                //        btn1.className = "btn btn-outline-info btn-sm";
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
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrvXzMajorObjLst, arrDataColumn, "id_XzMajor", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
    }
    exports.XzMajorCRUDEx = XzMajorCRUDEx;
});
