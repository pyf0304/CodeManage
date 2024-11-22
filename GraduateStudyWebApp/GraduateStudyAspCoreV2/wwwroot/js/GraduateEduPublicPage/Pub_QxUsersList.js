(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/BaseInfo_Share/QxUsersCRUD.js", "../TS/FunClass/clsDropDownList.js", "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/ParameterTable/clsViewpointTypeEN.js", "../TS/L0_Entity/UserManage_Share/clsvUsersEN.js", "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsViewpointTypeWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersWApi.js", "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "./AddViewpointEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Pub_QxUsersList = void 0;
    const QxUsersCRUD_js_1 = require("../PagesBase/BaseInfo_Share/QxUsersCRUD.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsgs_ShareEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsViewpointTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsViewpointTypeEN.js");
    const clsvUsersEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsResearchTopicWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js");
    const clsgs_ShareWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsViewpointTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsViewpointTypeWApi.js");
    const clsvUsersWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersWApi.js");
    const clsgs_UserConfigExWApi_js_1 = require("../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const AddViewpointEx_js_1 = require("./AddViewpointEx.js");
    /* Viewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Pub_QxUsersList extends QxUsersCRUD_js_1.QxUsersCRUD {
        constructor() {
            //public static mstrListDiv: string = "divDataLst";
            //public static mstrSortvViewpointBy: string = "viewpointId";
            super(...arguments);
            //论文列表
            this.mstrListDivPaper = "divPaperDataLst";
            //主题列表
            this.mstrListdivTopicDataLst = "divTopicDataLst";
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType) {
            this.BindGv_QxUsers();
        }
        BindGv_Cache(strType) {
            switch (strType) {
                case "ge_InspectionResults":
                    alert('该类没有绑定该函数：[this.BindGv_ge_InspectionResults4Func]！');
                    //this.BindGv_ge_InspectionResults4Func();
                    break;
                default:
                    var strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                    console.error(strMsg);
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
            (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
          */
        async Page_Load() {
            const strThisFuncName = this.Page_Load.name;
            // 在此处放置用户代码以初始化页面
            try {
                const objPage_Add = new AddViewpointEx_js_1.AddViewpointEx(this);
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    if (clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls == "") {
                        const objResearchTopic = await (0, clsResearchTopicWApi_js_1.ResearchTopic_GetFirstObjAsync)(" topicId=" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId); //通过主题Id获取教学班ID
                        if (objResearchTopic == null) {
                            const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                            console.error(strMsg);
                            alert(strMsg);
                            return;
                        }
                        //const strThisFuncName = this.Page_Load.name;
                        clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls = objResearchTopic.id_CurrEduCls;
                    }
                    var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
                    const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4List, "ddlShareId");
                    const ddl_ViewpointTypeId = await this.BindDdl_ViewpointTypeId("ddlViewpointTypeId");
                    var userTypeId;
                    var userTypeId = $("#hidUserTypeId").val();
                    if (userTypeId == "01") {
                        userTypeId = "04";
                    }
                    else {
                        userTypeId = "05";
                    }
                    if ($("#hidViewpointId").val() != "") {
                        const UpdateRecord = await objPage_Add.UpdateRecord($("#hidViewpointId").val());
                        //if ($("#hidIsRecommend").val() != "") {
                        //    const RecommendRecord = await this.RecommendRecord($("#hidViewpointId").val());
                        //}
                        $("#divLoading").hide();
                    }
                    else {
                        objPage_Add.AddNewRecord();
                        //获取分享Id
                        const responseText = await (0, clsgs_UserConfigExWApi_js_1.gs_UserConfigEx_GetNewReturnShareIdEx)(userTypeId, clsPublocalStorage_js_1.clsPublocalStorage.userId);
                        var strShareId = responseText;
                        //var returnBool: boolean = !!responseText2;
                        if (strShareId != "") {
                            this.shareId = strShareId;
                        }
                        $("#divLoading").hide();
                    }
                    //1、为下拉框设置数据源,绑定列表数据
                    //const ddl_ViewpointTypeId_q = await this.BindDdl_ViewpointTypeId("ddlViewpointTypeId_q");
                    QxUsersCRUD_js_1.QxUsersCRUD.sortQxUsersBy = "updDate Desc";
                    //论文
                    //PaperCRUD.sortPaperBy = "updDate Desc";
                    //用户下拉框绑定
                    //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
                    var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
                    const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond); //用户查询区域
                    //文献类型；
                    const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
                    //论文
                    this.hidSortvRTPaperRelaBy = "updDate Desc";
                    //var strWhereCond = await this.CombinevViewpointCondition();
                    //const responseText = await vViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //});
                    //2、显示无条件的表内容在GridView中
                    //const gvResult = await this.BindGv_vViewpoint();
                    //获取传参的paperId
                    var strPaperId = $("#hidRequestPaperId").val();
                    if (strPaperId != "") {
                        $('#SelectPaper').hide();
                        //存放Id
                        $("#txtPaperId").val(strPaperId);
                    }
                    else {
                        $('#SelectPaper').show();
                    }
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
        /* 为插入记录做准备工作
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
      */
        /// <summary>
        /// 为下拉框获取数据,从表:[ViewpointType]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_ViewpointTypeId(ddlViewpointTypeId, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlViewpointTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlViewpointTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsViewpointTypeWApi_js_1.ViewpointType_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrViewpointTypeObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlViewpointTypeId, arrViewpointTypeObjLst, clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeId, clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeName, "观点类型");
                        console.log("完成BindDdl_ViewpointTypeId!");
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
                        var arrPaperObjLst = jsonData;
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlLiteratureTypeId, arrPaperObjLst, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
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
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvPaperBy(value) {
            $("#hidSortvPaperBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvPaperBy() {
            return $("#hidSortvPaperBy").val();
        }
        /*
       * 论文标题
      */
        get paperTitle_q() {
            return $("#txtPaperTitle_q").val();
        }
        ///////////////////////论文列表条件
        get readUser_q() {
            return $("#ddlUserId_q").val();
        }
        /*
        * 文献类型Id
       */
        get literatureTypeId_q() {
            return $("#ddlLiteratureTypeId_q").val();
        }
        /*
        * 论文Id
       */
        set paperId(value) {
            $("#txtPaperId").val(value);
        }
        /*
        * 论文
       */
        get paperId() {
            return $("#txtPaperId").val();
        }
        /*
    * 设置排序字段-相当使用ViewState功能  主题论文关系
    */
        set hidSortvRTPaperRelaBy(value) {
            $("#hidSortvRTPaperRelaBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvRTPaperRelaBy() {
            return $("#hidSortvRTPaperRelaBy").val();
        }
        /*
    * 分享
    */
        set shareId(value) {
            $("#ddlShareId").val(value);
        }
        /*
        * 分享
        */
        get shareId() {
            return $("#ddlShareId").val();
        }
        /* 根据条件获取相应的记录对象的列表
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_QxUsers() {
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.CombineQxUsersCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrQxUsersObjLst = [];
            try {
                this.recCount = await (0, clsvUsersWApi_js_1.vUsers_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: QxUsersCRUD_js_1.QxUsersCRUD.sortQxUsersBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvUsersWApi_js_1.vUsers_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrQxUsersObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            if (arrQxUsersObjLst.length == 0) {
                var strMsg = `根据条件获取的对象列表数为空！`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_QxUsers1(strListDiv, arrQxUsersObjLst);
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
        async BindTab_QxUsers1(divContainer, arrQxUsersObjLst) {
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
                    fldName: "userId",
                    colHeader: "用户ID",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "用户名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "cardNo",
                    colHeader: "卡号",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "email",
                    colHeader: "电子邮箱",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "endYearMonth",
                //    colHeader: "结束年月",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "isArchive",
                //    colHeader: "isArchive",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "updDate",
                //    colHeader: "修改日期",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "updUser",
                //    colHeader: "修改人",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "",
                    colHeader: "确定",
                    text: "确定", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnUserRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
            (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrQxUsersObjLst, arrDataColumn, "userId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        <returns>条件串(strWhereCond)</returns>
      */
        async CombineQxUsersCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.userId_q != "") {
                    strWhereCond += ` And ${clsvUsersEN_js_1.clsvUsersEN.con_UserId} like '% ${this.userId_q}%'`;
                }
                if (this.userName_q != "") {
                    strWhereCond += ` And ${clsvUsersEN_js_1.clsvUsersEN.con_UserName} like '% ${this.userName_q}%'`;
                }
                //排除获取已存在的关系数据
                strWhereCond += ` And userId not in (select userId from RTUserRela where topicId = '${strTopicId}')`;
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineQxUsersCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
    }
    exports.Pub_QxUsersList = Pub_QxUsersList;
});
