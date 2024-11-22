(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../BaseInfo/QxUsers_QUDI_TS.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaENEx.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/ParameterTable/clsTopicUserRoleEN.js", "../TS/L0_Entity/UserManage/clsvUsersSimEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsTopicUserRoleWApi.js", "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/DailyRunning/clsCurrEduClsStuExWApi.js", "../TS/L3_ForWApiEx/DailyRunning/clsCurrEduClsTeacherExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTopic/clsvRTUserRelaExWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsStackTrace.js", "../TS/PubFun/clsString2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.UsersLstSel = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:WApiRTUserRela_QUDI_TSEx
    表名:RTUserRela(01120581)
    生成代码版本:2020.02.19.1
    生成日期:2020/02/20 09:46:19
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
    const QxUsers_QUDI_TS_js_1 = require("../BaseInfo/QxUsers_QUDI_TS.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsRTUserRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js");
    const clsvRTUserRelaENEx_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTUserRelaENEx.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsTopicUserRoleEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsTopicUserRoleEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage/clsvUsersSimEN.js");
    const clsRTUserRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsTopicUserRoleWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsTopicUserRoleWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js");
    const clsCurrEduClsStuExWApi_js_1 = require("../TS/L3_ForWApiEx/DailyRunning/clsCurrEduClsStuExWApi.js");
    const clsCurrEduClsTeacherExWApi_js_1 = require("../TS/L3_ForWApiEx/DailyRunning/clsCurrEduClsTeacherExWApi.js");
    const clsvRTUserRelaExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTopic/clsvRTUserRelaExWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsStackTrace_js_1 = require("../TS/PubFun/clsStackTrace.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    /* WApiRTUserRela_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class UsersLstSel extends QxUsers_QUDI_TS_js_1.QxUsers_QUDI_TS {
        constructor(objShowList) {
            super();
            this.mstrListDivUser = "divUserDataLst";
            this.divName4Query = "divQuery_UserSel"; //查询区的层Id
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit_Sel"; //编辑区的Id
            //public static mstrListDiv: string = "divDataLst";
            //public static mstrSortvRTUserRelaBy: string = "mId";
            /*
            * 每页记录数，在扩展类可以修改
           */
            //论文列表
            this.mstrListDivUsers = "divUsersDataLst";
            //主题自研论文关系
            this.mstrListDivRtOriginalUsersRela = "divRtOriginalUsersRelaDataLst";
            //主题引用论文关系
            //public mstrListDivRtUsersRela: string = "divRtUsersRelaDataLst";
            this.mstrListDivRtCitedUsersRela = "divRtCitedUsersRelaDataLst";
            this.iShowList = objShowList;
            UsersLstSel.objPage_Edit = this;
        }
        get pageSize() {
            return 10;
        }
        //添加论文关系
        //public async btnAddUsersRela_Click(strType: string) {
        //    //存放类型区分 论文相关条件；
        //    $("#hidstrType").val(strType);
        //    var objUsersLstSel = new UsersLstSel();
        //    const responseObjList = await objUsersLstSel.Page_Load();
        //}
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
    */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                this.divName4Pager = "divPager_UsersLst";
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
                    //用户
                    this.hidSortvUsersBy = "userName Desc";
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_QxUsers();
                    $("#hidUserId").val(clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
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
        //添加论文关系
        async btnAddUsersRela_ClickBak(strType) {
            //存放类型区分 论文相关条件；
            $("#hidstrType").val(strType);
            const responseObjList = await this.BindGv_QxUsers();
        }
        /*
         显示对话框
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_ShowDialog)
        */
        ShowDialog_Users(strOp) {
            //检查相关控件是否存在
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "div", "divUserList");
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "h4", "myModalLabel");
            if (strOp === "Add") {
                $('#divUserList').html('添加记录');
                //ViewInfo_EditEx.GetMaxStrId('#txtViewId');
            }
            else if (strOp === "Update") {
                $('#divUserList').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_ViewInfo').hide();
                $('#myModalLabel').html('详细信息');
            }
            ShowDialog('#divUserList');
        }
        /*
         隐藏对话框
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        */
        HideDialog_Users() {
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "div", "divUserList");
            HideDialog('#divUserList');
        }
        //添加用户关系
        async btnAddUserRela_ClickBak() {
            var strUserId = $("#hidUserId").val();
            var strTopicId = $("#hidTopicRelaId").val();
            var strWhereCond = ` 1=1 And ${clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_TopicId} = '${strTopicId}' And ${clsRTUserRelaEN_js_1.clsRTUserRelaEN.con_UserId} ='${strUserId}'`;
            //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
            const responseText = await (0, clsRTUserRelaWApi_js_1.RTUserRela_GetFirstObjAsync)(strWhereCond).then((jsonData) => {
                var objRtUsersEN = jsonData;
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId() == "00620001") {
                    ShowDialogFour();
                    const responseObjList = this.BindGv_QxUsers();
                }
                else {
                    if (objRtUsersEN != null) {
                        if (objRtUsersEN.topicUserRoleId == "0003") {
                            //成员
                            var strMsg = `您当前是成员不能添加用户！`;
                            alert(strMsg);
                            return;
                        }
                        else {
                            //指导员0001 //组长0002
                            ShowDialogFour();
                            const responseObjList = this.BindGv_QxUsers();
                        }
                    }
                }
            });
        }
        async btnAddUserRela_Click() {
            this.OpType = "Add";
            try {
                this.divName4Pager = "divPager_UsersLst";
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegion();
                    this.SetEventFunc();
                    this.ShowDialog_Users('');
                    this.bolIsLoadEditRegion = true; //
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    const responseText = await this.BindGv_QxUsers();
                }
                else {
                    this.ShowDialog_Users('');
                    const responseText = await this.BindGv_QxUsers();
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `为主题添加新用户初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:设置事件函数
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
       */
        async SetEventFunc() {
            // 在此处放置用户代码以初始化页面
            try {
                var objDiv0 = document.getElementById('divUserList');
                if (objDiv0 == undefined)
                    return;
                var objDiv = objDiv0;
                var objLst = objDiv.getElementsByTagName("button");
                //console.log("objLst", objLst);
                let arrElement = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetArray(objLst);
                //var btnUpdate4Dg = document.getElementById('btnUpdateRecord');
                var btnQuery = arrElement.find(x => x.id == 'btnQuery');
                if (btnQuery == null)
                    return;
                btnQuery.addEventListener('click', e => { this.btnUserQuery_Click(); });
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:为编辑区绑定下拉框
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
       */
        async BindDdl4EditRegion() {
            //主题用户角色下拉框
            const ddl_TopicUserRole_q = await this.BindDdl_TopicUserRole_q("ddlTopicUserRole_q");
            try {
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleName().indexOf('学生') > -1) {
                    await (0, clsCurrEduClsStuExWApi_js_1.CurrEduClsStuEx_BindDdl_id_CurrEduClsByStuIdInDiv_Cache)("divQuery_UserSel", "ddlid_CurrEduCls", clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId()); //编辑区域
                }
                else {
                    await (0, clsCurrEduClsTeacherExWApi_js_1.CurrEduClsTeacherEx_BindDdl_id_CurrEduClsByTeacherIdInDiv_Cache)("divQuery_UserSel", "ddlid_CurrEduCls", clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId()); //编辑区域
                }
            }
            catch (e) {
                console.error(e);
                alert(e);
            }
        }
        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        /// </summary>
        /// <returns></returns>
        async AddDPV_Edit(divName4Edit) {
            var strUrl = "./UsersLstSel";
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
        //相关论文
        async liUsersClick() {
            try {
                //主题论文
                this.hidSortvRTUserRelaBy = "updDate Desc";
                const gvResultUsers = await this.BindGv_QxUsers();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取主题相关论文列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        async BindDdl_LiteratureTypeId_Cache(ddlLiteratureTypeId, objLiteratureType_Cond) {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlLiteratureTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlLiteratureTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            try {
                var arrObjLst_Sel = await (0, clsLiteratureTypeWApi_js_1.LiteratureType_GetSubObjLst_Cache)(objLiteratureType_Cond);
                arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId]);
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlLiteratureTypeId, arrObjLst_Sel, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
                console.log("完成BindDdl_LiteratureTypeId!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 把一个扩展类的部分属性进行函数转换
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap)
        /// </summary>
        /// <param name = "objzx_ConceptS">源对象</param>
        async FuncMap(objvRTUserRela) {
            try {
                var vUsersSim_UserId = objvRTUserRela.updUser;
                var vUsersSim_UserName = await (0, clsvUsersSimWApi_js_1.vUsersSim_func)(clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserId, clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserName, vUsersSim_UserId);
                objvRTUserRela.userName = vUsersSim_UserName;
            }
            catch (e) {
                var strMsg = `(errid:WiTsCs0012)函数映射表对象数据出错,${e}.(${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyToEx)
        /// </summary>
        /// <param name = "objzx_ConceptENS">源对象</param>
        /// <returns>目标对象=>clszx_ConceptEN:objzx_ConceptENT</returns>
        CopyToEx(objzx_ConceptENS) {
            var objzx_ConceptENT = new clsvRTUserRelaENEx_js_1.clsvRTUserRelaENEx();
            try {
                objzx_ConceptENT = (0, clsvRTUserRelaExWApi_js_1.vRTUserRelaEx_CopyToEx)(objzx_ConceptENS);
                return objzx_ConceptENT;
            }
            catch (e) {
                var strMsg = clsString2_js_1.clsString.Format("(errid:WiTsCs0011)Copy表对象数据出错,${e}.({0})", clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction());
                alert(strMsg);
                return objzx_ConceptENT;
            }
        }
        async btnParticipateQA_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                var lngKeyId = Number(strKeyId);
                const responseText1 = (0, clsRTUserRelaWApi_js_1.RTUserRela_GetObjBymIdAsync)(lngKeyId).then((jsonData) => {
                    var objRTUserRelaEN = jsonData;
                    if (objRTUserRelaEN != null) {
                        var strUserId = objRTUserRelaEN.userId;
                        ParticipateQA_Click(strUserId);
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        //////////////////////////////////////////////////////论文部分//////////////////////////////////////////
        /// <summary>
        /// 为下拉框获取数据,从表:[Users]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_LiteratureTypeId(ddlLiteratureTypeId, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlLiteratureTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlLiteratureTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsLiteratureTypeWApi_js_1.LiteratureType_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrLiteratureTypeObjLst = jsonData;
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlLiteratureTypeId, arrLiteratureTypeObjLst, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
                        console.log("完成BindDdl_LiteratureTypeId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        //确定选择的用户 并添加到关系表中
        static CheckUserRole() {
            ////主题用户角色下拉框
            //const ddl_TopicUserRole_q = await this.BindDdl_TopicUserRole_q("ddlTopicUserRole_q");
            //需要提示选择角色
            if (clsString2_js_1.clsString.IsNullOrEmpty(UsersLstSel.objPage_Edit.TopicUserRole_q) == true) {
                var strInfo = `请选择用户角色!`;
                //显示信息框
                alert(strInfo);
                return false;
            }
            return true;
        }
        static btnReturnClick(strKeyId) {
            if (UsersLstSel.CheckUserRole() == false)
                return;
            UsersLstSel.objPage_Edit.HideDialog_Users();
            console.log('btnReturnClick(strKeyId:string) ', strKeyId);
            UsersLstSel.objPage_Edit.iShowList.BindGv_Cache(clsRTUserRelaEN_js_1.clsRTUserRelaEN._CurrTabName, strKeyId);
        }
        BindTab_vUsersQA(divContainer, arrvUsersObjLst) {
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
                    FldName: "UsersTitle",
                    ColHeader: "论文标题",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "periodical",
                    ColHeader: "期刊",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "author",
                    ColHeader: "作者",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "keyword",
                    ColHeader: "关键字",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "用户",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "添加",
                    Text: "添加", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnUsersQARecordInTab_Click("${strKeyId}");`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2Where(o, arrvUsersObjLst, arrDataColumn, "userId", "TopicUsers");
            //clsCommonFunc4Web.BindTabV2(o, arrvUsersObjLst, arrDataColumn, "userId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        ///////////////////////////////////////////////////用户数据部分
        //查询用户数据
        async btnUserQuery_Click() {
            const responseObjList = await this.BindGv_QxUsers();
        }
        ////查询论列表
        //public async btnUsersQuery_Click() {
        //    const responseObjList = await this.BindGv_QxUsers();
        //}
        //确定选择的论文 并添加到关系表中
        btnUsersRecordInTab_Click(strkeyId) {
            //存放Id
            $("#hidUserId").val(strkeyId);
            //获取论文条件 02代表 小组成员论文数据；
            var strType = $("#hidstrType").val();
            if (strType == "01") {
                //执行添加关系方法
                //this.AddNewRecordSaveUsersRela();//所有论文
            }
            else {
                //小组成员论文；
                //this.AddNewRecordSaveResearchResult();
            }
        }
        /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjRTUserRelaEN">数据传输的目的类对象</param>
    */
        PutDataToRTUserRelaClass(pobjRTUserRelaEN) {
            var strTopicId = $("#hidTopicRelaId").val();
            var strUserId = $("#hidUserId").val();
            var strUserId = $("#hidUserId").val();
            pobjRTUserRelaEN.topicId = strTopicId; // 主题编号
            pobjRTUserRelaEN.userId = strUserId; // 论文Id
            pobjRTUserRelaEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjRTUserRelaEN.updUser = strUserId; // 修改人
            pobjRTUserRelaEN.memo = this.memo; // 备注
        }
        /* 函数功能:在数据 列表中跳转到某一页 论文列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
    <param name = "intPageIndex">页序号</param>
    */
        IndexPageTwo(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.setCurrPageIndex(intPageIndex, this.divName4Pager);
            this.BindGv_QxUsers();
        }
        ///////////////////////论文列表条件
        get ReadUser_q() {
            return $("#ddlUserId_q").val();
        }
        /*
        * 文献类型Id
       */
        get LiteratureTypeId_q() {
            return $("#ddlLiteratureTypeId_q").val();
        }
        /*
    * 设置排序字段-相当使用ViewState功能  主题论文关系
    */
        set hidSortvRTUserRelaBy(value) {
            $("#hidSortvRTUserRelaBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvRTUserRelaBy() {
            return $("#hidSortvRTUserRelaBy").val();
        }
        /*
       * 获取当前页序号  -------论文
      */
        get CurrPageIndexUsers() {
            return $("#hidCurrPageIndexUsers").val();
        }
        /*
        * 设置当前页序号-------论文
       */
        set CurrPageIndexUsers(value) {
            $("#hidCurrPageIndexUsers").val(value);
        }
        /* 根据条件获取相应的记录对象的列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
      */
        async BindGv_QxUsers() {
            var strListDiv = this.mstrListDivUser;
            var strWhereCond = await this.CombineUsersCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvUsersSimObjLst = [];
            try {
                const responseRecCount = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: 10,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvUsersBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvUsersSimObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrQxUsersObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_vUsersSim(strListDiv, arrvUsersSimObjLst);
                console.log("完成BindGv_QxUsers!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示QxUsers对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrQxUsersObjLst">需要绑定的对象列表</param>
       */
        BindTab_vUsersSim(divContainer, arrvUsersSimObjLst) {
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
                    FldName: "userId",
                    ColHeader: "用户ID",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "用户名",
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
                {
                    FldName: "",
                    ColHeader: "确定",
                    Text: "确定", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        //btn1.setAttribute("onclick", `btnUserRecordInTab_Click('${strKeyId}');`);
                        (function (strKeyId1) {
                            btn1.onclick = (function () {
                                UsersLstSel.btnReturnClick(strKeyId1);
                            });
                        })(strKeyId);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2Where(o, arrvUsersSimObjLst, arrDataColumn, "userId", "TopicUser");
            //clsCommonFunc4Web.BindTabV2(o, arrQxUsersObjLst, arrDataColumn, "userId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        <returns>条件串(strWhereCond)</returns>
      */
        async CombineUsersCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strTopicId = $("#hidTopicRelaId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.UserId_q != "") {
                    strWhereCond += ` And ${clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserId} like '% ${this.UserId_q}%'`;
                }
                if (this.UserName_q != "") {
                    strWhereCond += ` And ${clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserName} like '% ${this.UserName_q}%'`;
                }
                if (clsString2_js_1.clsString.IsNullOrEmpty(this.id_CurrEduCls) == false) {
                    const arrStuId = await (0, clsCurrEduClsStuExWApi_js_1.CurrEduClsStuEx_GetStuIDLstById_CurrEduCls)(this.id_CurrEduCls);
                    const arrTeacherId = await (0, clsCurrEduClsTeacherExWApi_js_1.CurrEduClsTeacherEx_GetTeacherIdLstById_CurrEduCls)(this.id_CurrEduCls);
                    const arrUserId = arrStuId.concat(arrTeacherId).map(x => "'" + x + "'");
                    const strUserIdLst = arrUserId.join(',');
                    console.error(arrStuId);
                    console.error(arrTeacherId);
                    console.error(arrUserId);
                    console.error(strUserIdLst);
                    strWhereCond += ` And ${clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserId} in (${strUserIdLst})`;
                }
                strWhereCond += ` And isGSuser = 1`;
                //排除获取已存在的关系数据
                strWhereCond += ` And userId not in (select userId from RTUserRela where topicId = '${strTopicId}')`;
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineQxUsersCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* * 设置排序字段-相当使用ViewState功能
         */
        set hidSortvUsersBy(value) {
            $("#hidSortvUsersBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvUsersBy() {
            return $("#hidSortvUsersBy").val();
        }
        /* 用户列表表头排序；
    */
        /* 函数功能:从界面列表中根据某一个字段排序
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
        <param name = "strSortByFld">排序的字段</param>
      */
        async SortByUser(strSortByFld) {
            if (this.hidSortvUsersBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvUsersBy.indexOf("Asc") >= 0) {
                    this.hidSortvUsersBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvUsersBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvUsersBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_QxUsers();
        }
        /* 函数功能:在数据 列表中跳转到某一页 用户列表
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
    <param name = "intPageIndex">页序号</param>
    */
        IndexPageThree(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.setCurrPageIndex(intPageIndex, this.divName4Pager);
            this.BindGv_QxUsers();
        }
        //主题用户角色
        /// <summary>
        /// 为下拉框获取数据,从表:[OperationType]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        async BindDdl_TopicUserRole_q(ddlTopicUserRole_q) {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlTopicUserRole_q);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlTopicUserRole_q} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsTopicUserRoleWApi_js_1.TopicUserRole_GetObjLst_Cache)().then((jsonData) => {
                        var arrTopicUserRoleObjLst = jsonData;
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlTopicUserRole_q, arrTopicUserRoleObjLst, clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleId, clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleName, "角色");
                        console.log("完成BindDdl_TopicUserRole_q!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /**
        * 表ID (Used In CombineCondition())
        **/
        get id_CurrEduCls() {
            const objDiv = $(`#${this.divName4Query}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Query, "select", "ddlid_CurrEduCls");
            const strId = clsString2_js_1.clsString.Format("select[id ^= 'ddlid_CurrEduCls']");
            const objElem = objDiv.find(strId);
            if (objElem == undefined)
                return "";
            else {
                const strValue = objElem.val();
                if (strValue == undefined)
                    return "";
                else if (strValue == "0")
                    return "";
                else
                    return strValue;
            }
        }
        /**
        * 表ID (Used In CombineCondition())
        **/
        set id_CurrEduCls(value) {
            const objDiv = $(`#${this.divName4Query}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Query, "select", "ddlid_CurrEduCls");
            const strId = clsString2_js_1.clsString.Format("select[id ^= 'ddlid_CurrEduCls']");
            objDiv.find(strId).val(value);
        }
        //主题用户角色
        get TopicUserRole_q() {
            const strRoleId = $("#ddlTopicUserRole_q").val();
            if (strRoleId == "0")
                return "";
            return strRoleId;
        }
        /*
        * 主题用户角色
       */
        set TopicUserRole_q(value) {
            $("#ddlTopicUserRole_q").val(value);
        }
    }
    exports.UsersLstSel = UsersLstSel;
});
