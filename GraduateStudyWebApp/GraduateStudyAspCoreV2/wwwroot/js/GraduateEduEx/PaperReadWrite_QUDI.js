(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPaper/PaperReadWrite_EditEx.js", "../PagesBase/GraduateEduPaper/PaperReadWriteCRUD.js", "../TS/FunClass/clsDropDownList.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js", "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperReadWriteWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsPaperReadWriteWApiEx.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperReadWrite_QUDI = void 0;
    const PaperReadWrite_EditEx_js_1 = require("../GraduateEduPaper/PaperReadWrite_EditEx.js");
    const PaperReadWriteCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperReadWriteCRUD.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPaperReadWriteEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js");
    const clsvPaperReadWriteEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsPaperReadWriteWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperReadWriteWApi.js");
    const clsvPaperReadWriteWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js");
    const clsvPaperSubViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js");
    const clsPaperReadWriteWApiEx_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsPaperReadWriteWApiEx.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* PaperReadWrite_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class PaperReadWrite_QUDI extends PaperReadWriteCRUD_js_1.PaperReadWriteCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvPaperReadWriteBy: string = "paperRWId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType, strPara) {
            this.BindGv_vPaperReadWrite();
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "vPaperReadWrite":
                    alert('该类没有绑定该函数：[this.BindGv_vPaperReadWrite_Cache]！');
                    //this.BindGv_vPaperReadWrite_Cache();
                    break;
                default:
                    strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                    console.error(strMsg);
                    alert(strMsg);
                    break;
            }
        }
        /**
        * 按钮单击,用于调用Js函数中btn_Click
        * (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        **/
        static btn_Click(strCommandName, strKeyId) {
            let objPage;
            if (PaperReadWriteCRUD_js_1.PaperReadWriteCRUD.objPage_CRUD == null) {
                PaperReadWriteCRUD_js_1.PaperReadWriteCRUD.objPage_CRUD = new PaperReadWrite_QUDI();
                objPage = PaperReadWriteCRUD_js_1.PaperReadWriteCRUD.objPage_CRUD;
            }
            else {
                objPage = PaperReadWriteCRUD_js_1.PaperReadWriteCRUD.objPage_CRUD;
            }
            const objPage_Edit = new PaperReadWrite_EditEx_js_1.PaperReadWrite_EditEx(objPage);
            let strMsg = '';
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage_Edit.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                case "UpdateRecordInTab": //修改记录InTab
                    strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                        const strMsg = "请选择需要修改的记录！";
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (strCommandName == "UpdateRecordInTab") {
                        objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                    }
                    else {
                        objPage_Edit.btnUpdateRecord_Click(strKeyId);
                    }
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
                    strMsg = '命令:' + strCommandName + "在函数(PaperReadWriteCRUDExEx.btn_Click)中没有被处理！";
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
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
                    var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
                    objUsers_Cond.SetCondFldValue(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeId, "02", "=");
                    const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaperReadWrite_Cache("ddlUserId_q", objUsers_Cond); //用户查询区域
                    PaperReadWriteCRUD_js_1.PaperReadWriteCRUD.sortvPaperReadWriteBy = "updDate Desc";
                    //var strWhereCond = await this.CombinevPaperReadWriteCondition();
                    //读取session角色 来判断绑定不同数据列表
                    //获取用户角色来判断显示不同的列表数据；
                    //存放userId
                    $("#hidUserId").val(clsPublocalStorage_js_1.clsPublocalStorage.userId);
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vPaperReadWrite();
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
        /* 根据条件获取相应的记录对象的列表
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
     */
        async btnQuery_Click() {
            //var strWhereCond = await this.CombinevPaperReadWriteCondition();
            try {
                $("#divLoading").show();
                const gvResult = await this.BindGv_vPaperReadWrite();
                $("#divLoading").hide();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //统计核算
        async btnSynPaperRWStatistics_Click() {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            try {
                $("#divLoading").show();
                const responseText2 = await clsPaperReadWriteWApiEx_js_1.clsPaperReadWriteWApiEx.SynPaperRWStatisticsAsync(strUserId);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `统计核算成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $("#divLoading").hide();
                }
                else {
                    var strInfo = `统计核算不成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $("#divLoading").hide();
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `统计核算异常,${e}.`;
                alert(strMsg);
                $("#divLoading").hide();
            }
        }
        //public BindDdl_UserId(ddlUserId: string, strWhereCond: string = "operationTypeId='02'") {
        //    //var strWhereCond = " 1 =1 ";
        //    var objDdl = document.getElementById(ddlUserId);
        //    if (objDdl == null) {
        //        var strMsg = `下拉框：${ddlUserId} 不存在！`;
        //        alert(strMsg);
        //        throw (strMsg);
        //    }
        //    return new Promise((resolve, reject) => {
        //        try {
        //            const responseText = clsvPaperReadWriteWApiEx.GetUserNumObjLstAsync(strWhereCond).then((jsonData) => {
        //                var arrUserObjLst: Array<clsvPaperReadWriteEN> = <Array<clsvPaperReadWriteEN>>jsonData;
        //                BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvPaperReadWriteEN.con_UpdUser, clsvPaperReadWriteEN.con_UserName, "编辑用户");
        //                console.log("完成BindDdl_UserId!");
        //                resolve(jsonData);
        //            });
        //        }
        //        catch (e) {
        //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //            alert(strMsg);
        //        }
        //    });
        //}
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        async CombinevPaperReadWriteCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            var strReadWriteTypeId = $("#hidReadWriteTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperTitle_q != "") {
                    strWhereCond += ` And ${clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
                }
                //if (this.updDate_q != "") {
                //    strWhereCond += ` And ${clsvPaperReadWriteEN.con_UpdDate} like '% ${this.updDate_q}%'`;
                //}
                if (this.readUser_q != "" && this.readUser_q != "0") {
                    strWhereCond += ` And ${clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdUser} = '${this.readUser_q}'`;
                }
                //if (this.readUser_q != "") {
                //    strWhereCond += ` And ${clsvPaperReadWriteEN.con_UpdUser} like '% ${this.readUser_q}%'`;
                //}
                //// 02 代表论文写作
                //if (strReadWriteTypeId != "") {
                strWhereCond += ` And ${clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeId} = '02'`;
                //}
                //if (this.operationTypeId_q != "" && this.operationTypeId_q != "0") {
                //    strWhereCond += ` And ${clsvPaperReadWriteEN.con_OperationTypeId} = '${this.operationTypeId_q}'`;
                //}
                //if (this.updUser_q != "") {
                //    strWhereCond += ` And ${clsvPaperReadWriteEN.con_UpdUser} like '% ${this.updUser_q}%'`;
                //}
                //如果是写作 则需要判断当前用户  02 写作 04查看；
                if (strReadWriteTypeId == "02") {
                    var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                    var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                    if (strRoleId == "00620001") {
                        $("#btnDelRecord").show();
                        $("#btnCancelSubmit").show();
                        $("#btnSynPaperRWStatistics").show();
                        //可以查看所有；管理员
                    }
                    //判断角色 //学生00620003
                    else if (strRoleId == "00620002") {
                        $("#btnDelRecord").show();
                        $("#btnCancelSubmit").show();
                        //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                        //strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";
                    }
                    else {
                        $("#btnCancelSubmit").hide();
                        $("#ddlUserId_q").hide();
                        $("#btnDelRecord").show();
                        //只能查看自己的数据；或公开的数据；学生
                        //strWhereCond += ` And ${clsvSubViewpointEN.con_UpdUser} = '${strUserId}'`;
                        strWhereCond += ` And updUser = '${strUserId}'`;
                    }
                }
                //}
                //else {
                //    window.top.location.href = "../Web/Login";
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperReadWriteCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 显示vPaperReadWrite对象的所有属性值
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
       <param name = "divContainer">显示容器</param>
       <param name = "arrPaperReadWriteObjLst">需要绑定的对象列表</param>
     */
        async BindTab_vPaperReadWrite(divContainer, arrvPaperReadWriteObjLst) {
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
                    fldName: "paperTitle",
                    colHeader: "论文标题",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "paperContent",
                //    colHeader: "主题内容",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "periodical",
                    colHeader: "期刊",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "author",
                    colHeader: "作者",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "keyword",
                    colHeader: "关键字",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "researchQuestion",
                //    colHeader: "研究问题",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "operationTypeName",
                //    colHeader: "操作类型名",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "userName",
                    colHeader: "写作者",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "updDate",
                    colHeader: "写作日期",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "isSubmit",
                    colHeader: "是否提交",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "subVCount",
                    colHeader: "观点数",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "teaCount",
                    colHeader: "教师分",
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
                //    colHeader: "子观点",
                //    Text: "子观点",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        //btn1.setAttribute("onclick", `btnSubviewPointRecordInTab_Click("${strKeyId}");`);
                //        btn1.setAttribute("onclick", `btnSubviewPointRecordInTab_Click("${strKeyId}");`);
                //        return btn1;
                //    }
                //},
                {
                    fldName: "",
                    colHeader: "pdf子观点",
                    text: "pdf子观点", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        //btn1.setAttribute("onclick", `btnSubviewPointRecordInTab_Click("${strKeyId}");`);
                        btn1.setAttribute("onclick", `btnSubviewPointRecord_Click("${strKeyId}");`);
                        return btn1;
                    }
                },
                //{
                //    fldName: "",
                //    colHeader: "详细",
                //    Text: "详细",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Button",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnDetailRecordInTab_Click('${strKeyId}');`);
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
            (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrvPaperReadWriteObjLst, arrDataColumn, "paperRWId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 删除记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
      */
        async btnDelRecord_Click() {
            try {
                var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
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
                var strWhereCond = " paperRWId in (" + strKeyList + ")";
                this.recCount = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetRecCountByCondAsync)(strWhereCond);
                if (this.recCount != 0) {
                    alert("请先删除该论文下子观点！");
                    return "";
                }
                else {
                    //刷新缓存
                    const responseText = this.DelMultiRecord(arrKeyIds);
                    (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_ReFreshThisCache)(strid_CurrEducls);
                    const responseText2 = this.BindGv_vPaperReadWrite();
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 根据关键字列表删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
       */
        async DelMultiRecord(arrPaperRWId) {
            try {
                const returnInt = await clsPaperReadWriteWApiEx_js_1.clsPaperReadWriteWApiEx.DelPaperReadWritesExAsync(arrPaperRWId);
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
        //取消论文提交
        async btnCancelSubmit_Click(strKeyId) {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            try {
                this.CancelSubmitRecordSave(strKeyId);
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*取消提交论文
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
     */
        async CancelSubmitRecordSave(strKeyId) {
            const strThisFuncName = this.CancelSubmitRecordSave.name;
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            //
            var objPaperReadWriteEN = new clsPaperReadWriteEN_js_1.clsPaperReadWriteEN();
            objPaperReadWriteEN.SetPaperRWId(strKeyId);
            objPaperReadWriteEN.SetIsSubmit(false);
            objPaperReadWriteEN.SetSubmitter(clsPublocalStorage_js_1.clsPublocalStorage.userId); //提交人；
            objPaperReadWriteEN.sf_UpdFldSetStr = objPaperReadWriteEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperReadWriteEN.paperRWId == "" || objPaperReadWriteEN.paperRWId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = (0, clsPaperReadWriteWApi_js_1.PaperReadWrite_UpdateRecordAsync)(objPaperReadWriteEN).then((jsonData) => {
                    var returnBool = jsonData;
                    if (returnBool == true) {
                        var strInfo = `取消成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        //刷新缓存
                        (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_ReFreshThisCache)(strid_CurrEducls);
                        HideDialog();
                        this.BindGv_vPaperReadWrite();
                    }
                    else {
                        var strInfo = `取消不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("取消失败");
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `取消记录不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的记录对象的列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
      */
        async BindGv_vPaperReadWrite() {
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.CombinevPaperReadWriteCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvPaperReadWriteObjLst = [];
            try {
                this.recCount = await (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: PaperReadWriteCRUD_js_1.PaperReadWriteCRUD.sortvPaperReadWriteBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvPaperReadWriteObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                this.BindTab_vPaperReadWrite(strListDiv, arrvPaperReadWriteObjLst);
                console.log("完成BindGv_vPaperReadWrite!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /*
     * 用户
    */
        //public get readUser_q(): string {
        //    return $("#txtReadUser_q").val();
        //}
        get readUser_q() {
            return $("#ddlUserId_q").val();
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
    }
    exports.PaperReadWrite_QUDI = PaperReadWrite_QUDI;
});
