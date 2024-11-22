(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduTools/gs_TeachingDate_EditEx.js", "../PagesBase/DailyRunning_Share/CurrEduClsCRUD.js", "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsEN.js", "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsENEx.js", "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js", "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/DailyRunning_Share/clsvCurrEduClsExWApi.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsStackTrace.js", "../TS/PubFun/clsString.js", "./CurrEduCls_EditEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CurrEduClsCRUDEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:CurrEduClsCRUDEx
    表名:CurrEduCls(01120123)
    生成代码版本:2020.05.09.1
    生成日期:2020/05/11 16:30:25
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:日常运行
    模块英文名:DailyRunning
    框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //
    //import * as QQ from "q";
    const gs_TeachingDate_EditEx_js_1 = require("../GraduateEduTools/gs_TeachingDate_EditEx.js");
    const CurrEduClsCRUD_js_1 = require("../PagesBase/DailyRunning_Share/CurrEduClsCRUD.js");
    const clsvCurrEduClsEN_js_1 = require("../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsEN.js");
    const clsvCurrEduClsENEx_js_1 = require("../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsENEx.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsCurrEduClsWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js");
    const clsvCurrEduClsWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsWApi.js");
    const clsgs_TeachingDateWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsvCurrEduClsExWApi_js_1 = require("../TS/L3_ForWApiEx/DailyRunning_Share/clsvCurrEduClsExWApi.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsStackTrace_js_1 = require("../TS/PubFun/clsStackTrace.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const CurrEduCls_EditEx_js_1 = require("./CurrEduCls_EditEx.js");
    /* CurrEduClsCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class CurrEduClsCRUDEx extends CurrEduClsCRUD_js_1.CurrEduClsCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvCurrEduClsBy: string = "id_CurrEduCls";
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
                //建立缓存
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                CurrEduClsCRUD_js_1.CurrEduClsCRUD.sortCurrEduClsBy = "currEduClsId Asc";
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
            let objPage;
            if (CurrEduClsCRUD_js_1.CurrEduClsCRUD.objPage_CRUD == null) {
                CurrEduClsCRUD_js_1.CurrEduClsCRUD.objPage_CRUD = new CurrEduClsCRUDEx();
                objPage = CurrEduClsCRUD_js_1.CurrEduClsCRUD.objPage_CRUD;
            }
            else {
                objPage = CurrEduClsCRUD_js_1.CurrEduClsCRUD.objPage_CRUD;
            }
            const objPage_Edit = new CurrEduCls_EditEx_js_1.CurrEduCls_EditEx(objPage);
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            let strMsg = '';
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    ShowDialog('AddWithMaxId');
                    objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    ShowDialog('AddWithMaxId');
                    objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage_Edit.btnAddNewRecord_Click();
                    break;
                case "SetUpDate": //修改记录
                    var strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    if (strKeyId == "") {
                        alert("请选择需要设置的记录！");
                        return;
                    }
                    objPage.btnSetUpDateRecord_Click(strKeyId);
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
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
                    strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
                case "ExportExcel": //导出Excel
                    alert("导出Excel功能还没有开通！");
                    break;
            }
        }
        //概念提交审核
        async mySubmitDate() {
            let objPage;
            if (CurrEduClsCRUD_js_1.CurrEduClsCRUD.objPage_CRUD == null) {
                CurrEduClsCRUD_js_1.CurrEduClsCRUD.objPage_CRUD = new CurrEduClsCRUDEx();
                objPage = CurrEduClsCRUD_js_1.CurrEduClsCRUD.objPage_CRUD;
            }
            else {
                objPage = CurrEduClsCRUD_js_1.CurrEduClsCRUD.objPage_CRUD;
            }
            const objPage_Edit = new CurrEduCls_EditEx_js_1.CurrEduCls_EditEx(objPage);
            const responseText1 = await objPage_Edit.SetUpDate();
        }
        /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
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
                var strWhereCond = " id_CurrEduCls in (" + strKeyList + ")";
                var arrCurrEduClsObjLst = [];
                const responseText1 = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrCurrEduClsObjLst = jsonData;
                    //查询是否有提交的数据
                    arrCurrEduClsObjLst = arrCurrEduClsObjLst.filter(x => x.modifyUserID != strUserId);
                    if (arrCurrEduClsObjLst.length > 0) {
                        alert("包含其他用户添加数据，不能删除！");
                        return "";
                    }
                });
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
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        async CombinevCurrEduClsCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.currEduClsId_q != "") {
                    strWhereCond += ` And ${clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId} like '% ${this.currEduClsId_q}%'`;
                }
                if (this.eduClsName_q != "") {
                    strWhereCond += ` And ${clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName} like '% ${this.eduClsName_q}%'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineCurrEduClsCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyToEx)
        /// </summary>
        /// <param name = "objvCurrEduClsENS">源对象</param>
        /// <returns>目标对象=>clsvCurrEduClsEN:objvCurrEduClsENT</returns>
        CopyToEx(objvCurrEduClsENS) {
            var objvCurrEduClsENT = new clsvCurrEduClsENEx_js_1.clsvCurrEduClsENEx();
            try {
                objvCurrEduClsENT = (0, clsvCurrEduClsExWApi_js_1.vCurrEduClsEx_CopyToEx)(objvCurrEduClsENS);
                return objvCurrEduClsENT;
            }
            catch (e) {
                var strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0011)Copy表对象数据出错,${e}.({0})", clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction());
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
                    var vUsersSim_UserName = await (0, clsvUsersSimWApi_js_1.vUsersSim_func)(clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserId, clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserName, vUsersSim_UserId, clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                    objvCurrEduCls.userName = vUsersSim_UserName;
                }
                ;
                {
                    let arrgs_TeachingDate = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_GetObjLst_Cache)(objvCurrEduCls.id_CurrEduCls);
                    if (arrgs_TeachingDate.length > 0) {
                        let objgs_TeachingDate = arrgs_TeachingDate[0];
                        let strTeachingDate = (0, clsString_js_1.Format)("{0}-{1}", objgs_TeachingDate.startDate, objgs_TeachingDate.endDate);
                        objvCurrEduCls.teachingDate = strTeachingDate;
                    }
                }
                ;
            }
            catch (e) {
                var strMsg = `(errid:WiTsCs0012)函数映射表对象数据出错,${e}.(${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vCurrEduCls() {
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.CombinevCurrEduClsCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvCurrEduClsObjLst = [];
            var arrvCurrEduClsExObjLst = [];
            try {
                this.recCount = await (0, clsvCurrEduClsWApi_js_1.vCurrEduCls_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: CurrEduClsCRUD_js_1.CurrEduClsCRUD.sortCurrEduClsBy,
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
        /* 显示vCurrEduCls对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrCurrEduClsObjLst">需要绑定的对象列表</param>
    */
        async BindTab_vCurrEduCls(divContainer, arrvCurrEduClsObjLst) {
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
                    fldName: "currEduClsId",
                    colHeader: "教学班Id",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "eduClsName",
                    colHeader: "教学班",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "courseCode",
                //    colHeader: "课程代码",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "courseName",
                    colHeader: "课程",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "collegeName",
                    colHeader: "学院",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "schoolYear",
                    colHeader: "学年",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "schoolTerm",
                    colHeader: "学期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "TeachingDate",
                    colHeader: "时间范围",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    sortBy: "userName", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    colHeader: "编辑人",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 21,
                    funcName: () => { }
                },
            ];
            (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrvCurrEduClsObjLst, arrDataColumn, "id_CurrEduCls", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 设置教学班时间范围；
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
    */
        async btnSetUpDateRecord_Click(keyId) {
            var objPage = new CurrEduClsCRUDEx();
            var objPage_Edit = new gs_TeachingDate_EditEx_js_1.gs_TeachingDate_EditEx(objPage);
            var strKeyId = keyId;
            //判断教学班数据是否已经被设置
            var strWhere = " 1 = 1 And id_CurrEduCls = '" + strKeyId + "'";
            const responseText1 = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_GetFirstObjAsync)(strWhere);
            var objgs_TeachingDateEN = responseText1;
            if (objgs_TeachingDateEN != null) {
                //赋值，弹出框
                //存放教学班日期范围表主键
                $("#hidgs_DateId").val(objgs_TeachingDateEN.mId);
                objPage_Edit.btnUpdateRecordInTab_Click(objgs_TeachingDateEN.mId.toString());
            }
            else {
                //添加 需要清空下隐藏数据
                $("#hidgs_DateId").val("");
                objPage_Edit.btnAddNewRecord_Click();
            }
        }
        /*
    * 开始时间
    */
        set startDate(value) {
            $("#txtStartDate").val(value);
        }
        /*
        * 开始时间
       */
        get startDate() {
            return $("#txtStartDate").val();
        }
        /*
    * 结束时间
    */
        set endDate(value) {
            $("#txtEndDate").val(value);
        }
        /*
        * 结束时间
       */
        get endDate() {
            return $("#txtEndDate").val();
        }
    }
    exports.CurrEduClsCRUDEx = CurrEduClsCRUDEx;
});
