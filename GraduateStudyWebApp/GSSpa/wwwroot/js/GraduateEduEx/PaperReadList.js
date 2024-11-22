(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/clsDropDownList.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js", "../TS/L0_Entity/UserManage/clsvUsersSimEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsPaperReadWriteWApiEx.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js", "../GraduateEduPaper/PaperReadWrite_QUDI_TS.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteENEx.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperReadWriteWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js", "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsvPaperReadWriteExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/PubFun/clsStackTrace.js", "../TS/PubFun/clsString2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperReadList = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:PaperReadWrite_QUDI_TSEx
    表名:PaperReadWrite(01120547)
    生成代码版本:2019.12.06.1
    生成日期:2019/12/26 15:55:59
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
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsPaperReadWriteEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js");
    const clsvPaperReadWriteEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage/clsvUsersSimEN.js");
    const clsvPaperReadWriteWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js");
    const clsPaperReadWriteWApiEx_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsPaperReadWriteWApiEx.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const PaperReadWrite_QUDI_TS_js_1 = require("../GraduateEduPaper/PaperReadWrite_QUDI_TS.js");
    const clsvPaperReadWriteENEx_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperReadWriteENEx.js");
    const clsPaperReadWriteWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperReadWriteWApi.js");
    const clsvPaperSubViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js");
    const clsvPaperReadWriteExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsvPaperReadWriteExWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsStackTrace_js_1 = require("../TS/PubFun/clsStackTrace.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    /* PaperReadWrite_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class PaperReadList extends PaperReadWrite_QUDI_TS_js_1.PaperReadWrite_QUDI_TS {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvPaperReadWriteBy: string = "paperRWId";
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
                    //加载页面所需数据源到缓存
                    //const arrvPaperReadWrite_Cache = await vPaperReadWrite_GetObjLstAsync("1=1");
                    //1、为下拉框设置数据源,绑定列表数据
                    // const ddl_PaperId = await this.BindDdl_PaperId("ddlPaperId");
                    //const ddl_OperationTypeId_q = await this.BindDdl_OperationTypeId("ddlOperationTypeId_q");
                    // const ddl_OperationTypeId = await this.BindDdl_OperationTypeId("ddlOperationTypeId");
                    //const ddl_UserId_q = await this.BindDdl_UserId("ddlUserId_q");
                    var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
                    objUsers_Cond.SetCondFldValue(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeId, "01", "=");
                    const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaperReadWrite_Cache("ddlUserId_q", objUsers_Cond); //用户查询区域
                    this.hidSortvPaperReadWriteBy = "updDate Desc";
                    //var strWhereCond = this.CombinevPaperReadWriteCondition();
                    //const responseText = await vPaperReadWrite_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //    this.RecCount = jsonData;
                    //});
                    //存放userId
                    $("#hidUserId").val(clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
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
        //public BindDdl_UserId(ddlUserId: string, strWhereCond: string = "operationTypeId='01'") {
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
        //                clsCommonFunc4Web.BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvPaperReadWriteEN.con_UpdUser, clsvPaperReadWriteEN.con_UserName, "编辑用户");
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
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
      */
        async btnQuery_Click(strListDiv) {
            //var strWhereCond = this.CombinevPaperReadWriteCondition();
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
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
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
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevPaperReadWriteCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strReadWriteTypeId = $("#hidReadWriteTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.PaperTitle_q != "") {
                    strWhereCond += ` And ${clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
                }
                if (this.UpdDate_q != "") {
                    strWhereCond += ` And ${clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdDate} like '% ${this.UpdDate_q}%'`;
                }
                //用户
                if (this.ReadUser_q != "" && this.ReadUser_q != "0") {
                    strWhereCond += ` And ${clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdUser} = '${this.ReadUser_q}'`;
                }
                //if (this.ReadUser_q != "") {
                //    strWhereCond += ` And ${clsvPaperReadWriteEN.con_UpdUser} like '% ${this.ReadUser_q}%'`;
                //}
                ////01代表论文阅读；
                //if (strReadWriteTypeId != "") {
                strWhereCond += ` And ${clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeId} = '01'`;
                //}
                //if (this.OperationTypeId_q != "" && this.OperationTypeId_q != "0") {
                //    strWhereCond += ` And ${clsvPaperReadWriteEN.con_OperationTypeId} = '${this.OperationTypeId_q}'`;
                //}
                //if (this.UpdUser_q != "") {
                //    strWhereCond += ` And ${clsvPaperReadWriteEN.con_UpdUser} like '% ${this.UpdUser_q}%'`;
                //}
                //如果是阅读 则需要判断当前用户  01 阅读 03查看；
                if (strReadWriteTypeId == "01") {
                    var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                    var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                    if (strRoleId == "00620001") {
                        $("#btnDelRecord").show();
                        $("#btnCancelSubmit").show();
                        //可以查看所有；管理员
                    }
                    //判断角色 //教师00620003
                    else if (strRoleId == "00620002") {
                        $("#btnDelRecord").show();
                        $("#btnCancelSubmit").show();
                        //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                        strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";
                    }
                    else {
                        $("#btnDelRecord").hide();
                        $("#btnCancelSubmit").hide();
                        $("#ddlUserId_q").hide();
                        //学生
                        //只能查看自己的数据；或公开的数据；
                        //strWhereCond += ` And ${clsvSubViewpointEN.con_UpdUser} = '${strUserId}'`;
                        strWhereCond += ` And updUser = '${strUserId}'`;
                        //$("#hidUserId").val(objvUserRoleRelation.userId);
                    }
                }
                //else {
                //    //是查看那么可以显示所有无需控制；
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperReadWriteCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        CombinevPaperReadWriteConditionobj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strReadWriteTypeId = $("#hidReadWriteTypeId").val();
            var objvPaperReadWrite_Cond = new clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN();
            objvPaperReadWrite_Cond.SetCondFldValue(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_id_CurrEduCls, clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls(), "=");
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.PaperTitle_q != "") {
                    strWhereCond += ` And ${clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
                    objvPaperReadWrite_Cond.SetCondFldValue(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperTitle, this.PaperTitle_q, "like");
                }
                if (this.UpdDate_q != "") {
                    strWhereCond += ` And ${clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdDate} like '% ${this.UpdDate_q}%'`;
                    objvPaperReadWrite_Cond.SetCondFldValue(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdDate, this.UpdDate_q, "like");
                }
                //用户
                if (this.ReadUser_q != "" && this.ReadUser_q != "0") {
                    strWhereCond += ` And ${clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdUser} = '${this.ReadUser_q}'`;
                    objvPaperReadWrite_Cond.SetCondFldValue(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdUser, this.ReadUser_q, "=");
                }
                strWhereCond += ` And ${clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeId} = '01'`;
                objvPaperReadWrite_Cond.SetCondFldValue(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeId, "01", "=");
                if (strReadWriteTypeId == "01") {
                    var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                    var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                    if (strRoleId == "00620001") {
                        $("#btnDelRecord").show();
                        $("#btnCancelSubmit").show();
                        //可以查看所有；管理员
                    }
                    //判断角色 //教师00620003
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
                        //学生
                        //只能查看自己的数据；或公开的数据；
                        //strWhereCond += ` And ${clsvSubViewpointEN.con_UpdUser} = '${strUserId}'`;
                        strWhereCond += ` And updUser = '${strUserId}'`;
                        objvPaperReadWrite_Cond.SetCondFldValue(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdUser, strUserId, "=");
                        //$("#hidUserId").val(objvUserRoleRelation.userId);
                    }
                }
                else {
                    //strWhereCond += ` And updUser = '${objvUserRoleRelation.userId}'`;
                    //objvPaperReadWrite_Cond.SetCondFldValue(clsvPaperReadWriteEN.con_UpdUser, objvUserRoleRelation.userId, "=");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineUsersConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvPaperReadWrite_Cond;
        }
        //跳转到pdf维护子观点页面
        async btnSubviewPointRecord_Click() {
            this.OpType = "Update";
            var strKeyId = $("#hidPaperRWId").val();
            var strReadWriteTypeId = $("#hidReadWriteTypeId").val();
            var objPaperReadWrite;
            //var objPaperAttachment: clsPaperAttachmentEN;
            var strWhereCond1 = " 1=1 and paperRWId ='" + strKeyId + "'";
            try {
                const responseText1 = await (0, clsPaperReadWriteWApi_js_1.PaperReadWrite_GetFirstObjAsync)(strWhereCond1);
                objPaperReadWrite = responseText1;
                //var strWhereCond2 = " 1=1 and paperId ='" + objPaperReadWrite.paperId + "'";
                //const responseText2 = await PaperAttachment_GetFirstObjAsync(strWhereCond2);
                //objPaperAttachment = <clsPaperAttachmentEN>responseText2;
                var strLink = "";
                if (strReadWriteTypeId == "01") {
                    //if (objPaperAttachment != null) {
                    //    var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
                    //    //window.location.href = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=01&paperRWId=" + strKeyId + "&file=" + strfilepath;
                    //    //strLink = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=01&paperRWId=" + strKeyId + "&file=" + strfilepath;
                    //    strLink = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=01&paperId=" + objPaperReadWrite.paperId;
                    //} else {
                    //    //window.location.href = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=01&paperRWId=" + strKeyId;
                    //    //strLink = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=01&paperRWId=" + strKeyId;
                    //    strLink = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=01&paperRWId=" + strKeyId;
                    //}
                    strLink = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=01&paperId=" + objPaperReadWrite.paperId;
                }
                else if (strReadWriteTypeId == "03") {
                    //if (objPaperAttachment != null) {
                    //    var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
                    //    //window.location.href = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=02&paperRWId=" + strKeyId + "&file=" + strfilepath;
                    //    strLink = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=02&paperRWId=" + strKeyId + "&file=" + strfilepath;
                    //} else {
                    //    //window.location.href = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=02&paperRWId=" + strKeyId;
                    //    strLink = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=02&paperRWId=" + strKeyId;
                    //}
                    strLink = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=02&paperId=" + objPaperReadWrite.paperId;
                }
                xadminopen(strLink);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
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
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "paperTitle",
                    ColHeader: "论文标题",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "paperContent",
                //    ColHeader: "主题内容",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
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
                //{
                //    FldName: "researchQuestion",
                //    ColHeader: "研究问题",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "operationTypeName",
                //    ColHeader: "操作类型名",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "userName",
                    ColHeader: "阅读者",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "阅读日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "isSubmit",
                    ColHeader: "是否提交",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "subVCount",
                    ColHeader: "观点数",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "teaCount",
                    ColHeader: "教师分",
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
                //    ColHeader: "子观点",
                //    Text: "子观点",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnSubviewPointRecordInTab_Click("${strKeyId}");`);
                //        return btn1;
                //    }
                //},
                {
                    FldName: "",
                    ColHeader: "pdf子观点",
                    Text: "pdf子观点", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        //btn1.setAttribute("onclick", `btnSubviewPointRecordInTab_Click("${strKeyId}");`);
                        btn1.setAttribute("onclick", `btnSubviewPointRecord_Click("${strKeyId}");`);
                        return btn1;
                    }
                },
                //{
                //    FldName: "",
                //    ColHeader: "详细",
                //    Text: "详细",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info";
                //        btn1.setAttribute("onclick", `btnDetailRecordInTab_Click('${strKeyId}');`);
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
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvPaperReadWriteObjLst, arrDataColumn, "paperRWId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 函数功能:把类对象的属性内容显示到界面上
      注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
       如果在设置数据库时,就应该一级字段在前,二级字段在后
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
       <param name = "pobjPaperReadWriteEN">表实体类对象</param>
     */
        GetDataFromPaperReadWriteClass(pobjPaperReadWriteEN) {
            this.paperRWId = pobjPaperReadWriteEN.paperRWId; // 论文读写Id
            this.readerId = pobjPaperReadWriteEN.readerId; // 阅读者Id
            $("#hidPaperId").val(pobjPaperReadWriteEN.paperId);
            //this.paperId = pobjPaperReadWriteEN.paperId;// 论文Id
            this.researchQuestion = pobjPaperReadWriteEN.researchQuestion; // 研究问题
            this.operationTypeId = pobjPaperReadWriteEN.operationTypeId; // 操作类型ID
            this.updDate = pobjPaperReadWriteEN.updDate; // 修改日期
            this.updUser = pobjPaperReadWriteEN.updUser; // 修改用户Id
            this.memo = pobjPaperReadWriteEN.memo; // 备注
        }
        /* 函数功能:把界面上的属性数据传到类对象中
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
       <param name = "pobjPaperReadWriteEN">数据传输的目的类对象</param>
     */
        PutDataToPaperReadWriteClass(pobjPaperReadWriteEN) {
            pobjPaperReadWriteEN.paperRWId = this.paperRWId; // 论文读写Id
            pobjPaperReadWriteEN.readerId = $("#hidUserId").val(); // 阅读者Id
            pobjPaperReadWriteEN.paperId = $("#hidPaperId").val(); // 论文Id
            pobjPaperReadWriteEN.researchQuestion = this.researchQuestion; // 研究问题
            pobjPaperReadWriteEN.operationTypeId = $("#hidReadWriteTypeId").val(); // 操作类型ID
            // pobjPaperReadWriteEN.operationTypeId = this.operationTypeId;// 操作类型ID
            pobjPaperReadWriteEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjPaperReadWriteEN.updUser = $("#hidUserId").val(); // 修改用户Id// 修改用户Id
            pobjPaperReadWriteEN.memo = this.memo; // 备注
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnOKUpd_Click() {
            var strCommandText = this.btnOKUpd;
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                //刷新缓存
                                (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_ReFreshThisCache)(strid_CurrEducls);
                                HideDialog();
                                this.BindGv_vPaperReadWrite();
                            }
                        });
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                //刷新缓存
                                (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_ReFreshThisCache)(strid_CurrEducls);
                                HideDialog();
                                this.BindGv_vPaperReadWrite();
                            }
                        });
                        //数据更新到总表；
                        var strPaperRWId = $("#hidPaperRWId").val();
                        const responseText5 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strPaperRWId, "01", "2", this.Id_CurrEduCls);
                        var returnBool5 = !!responseText5;
                        if (returnBool5 == true) {
                            console.log("论文读写数据总表同步成功；");
                        }
                        else {
                            console.log("论文读写数据总表同步失败；");
                        }
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                        alert(strMsg);
                        break;
                }
                //取消提交按钮不可用状态
                $("#btnOKUpd").attr("disabled", false);
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 添加新记录
           (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
          */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objPaperReadWriteEN = new clsPaperReadWriteEN_js_1.clsPaperReadWriteEN();
            this.PutDataToPaperReadWriteClass(objPaperReadWriteEN);
            try {
                const responseText = await (0, clsPaperReadWriteWApi_js_1.PaperReadWrite_IsExistAsync)(objPaperReadWriteEN.paperRWId);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objPaperReadWriteEN.paperRWId}已经存在！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await clsPaperReadWriteWApiEx_js_1.clsPaperReadWriteWApiEx.AddNewRecordAsyncEx(objPaperReadWriteEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!同一用户同一论文只能添加一次`;
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
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 根据关键字获取相应的记录的对象
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        <param name = "sender">参数列表</param>
      */
        UpdateRecord(strPaperRWId) {
            this.btnOKUpd = "确认修改";
            this.btnCancel = "取消修改";
            this.KeyId = strPaperRWId;
            var strUserId = $("#hidUserId").val();
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperReadWriteWApi_js_1.PaperReadWrite_GetObjByPaperRWIdAsync)(strPaperRWId).then((jsonData) => {
                        var objPaperReadWriteEN = jsonData;
                        // //通过判断数据用户是否是当前登录用户；
                        if (objPaperReadWriteEN.updUser == strUserId) {
                            ShowDialog('Update');
                            this.GetDataFromPaperReadWriteClass(objPaperReadWriteEN);
                            //存放主键
                            $("#hidPaperRWId").val(strPaperRWId);
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
        /* 删除记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
      */
        async btnDelRecord_Click() {
            try {
                var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                var strKeyList;
                if (arrKeyIds.length == 0)
                    return "";
                strKeyList = "";
                for (var i = 0; i < arrKeyIds.length; i++) {
                    //先删除总表数据更新总表
                    var strPaperId = arrKeyIds[i].toString();
                    const responseText5 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strPaperId, "02", "3", this.Id_CurrEduCls);
                    var returnBool5 = !!responseText5;
                    if (returnBool5 == true) {
                        console.log(strPaperId + "论文读写数据总表删除成功；");
                    }
                    else {
                        console.log(strPaperId + "论文读写数据总表删除失败；");
                    }
                    if (i == 0)
                        strKeyList = strKeyList + "'" + arrKeyIds[i].toString() + "'";
                    else
                        strKeyList += "," + "'" + arrKeyIds[i].toString() + "'";
                }
                //
                var strWhereCond = " paperRWId in (" + strKeyList + ")";
                var intSubVCount = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetRecCountByCondAsync)(strWhereCond);
                if (intSubVCount != 0) {
                    alert("请先删除该论文下子观点！");
                    return "";
                }
                else {
                    const responseText = this.DelMultiRecord(arrKeyIds);
                    //刷新缓存
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
        DelMultiRecord(arrPaperRWId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = clsPaperReadWriteWApiEx_js_1.clsPaperReadWriteWApiEx.DelPaperReadWritesExAsync(arrPaperRWId).then((jsonData) => {
                        var returnInt = jsonData;
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
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `删除记录不成功. ${e}.`;
                    alert(strMsg);
                }
            });
        }
        //论文提交
        async btnSubmit_Click(strKeyId) {
            var strUserId = $("#hidUserId").val();
            //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            try {
                const responseText = (0, clsPaperReadWriteWApi_js_1.PaperReadWrite_GetObjByPaperRWIdAsync)(strKeyId).then((jsonData) => {
                    var objPaperReadWriteEN = jsonData;
                    //通过session 权限获取权限
                    //判断角色 //学生00620003
                    if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId() == "00620003") {
                        // //通过判断数据用户是否是当前登录用户；
                        if (objPaperReadWriteEN.updUser == strUserId) {
                            //判断数据是否已提交
                            if (objPaperReadWriteEN.isSubmit == false) {
                                this.SubmitRecordSave();
                            }
                            else {
                                alert("当前数据已提交！");
                                return;
                            }
                        }
                        else {
                            alert("当前数据不是您所添加，不能修改！");
                            return;
                        }
                    }
                    else {
                        //可以提交
                        //判断数据是否已提交
                        if (objPaperReadWriteEN.isSubmit == false) {
                            this.SubmitRecordSave();
                        }
                        else {
                            alert("当前数据已提交！");
                            return;
                        }
                    }
                });
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*提交论文
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
     */
        async SubmitRecordSave() {
            //this.DivName = "divUpdateRecordSave";
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            var objPaperReadWriteEN = new clsPaperReadWriteEN_js_1.clsPaperReadWriteEN();
            objPaperReadWriteEN.paperRWId = this.KeyId;
            objPaperReadWriteEN.isSubmit = true;
            objPaperReadWriteEN.submitter = $("#hidUserId").val(); //提交人；
            objPaperReadWriteEN.sf_UpdFldSetStr = objPaperReadWriteEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperReadWriteEN.paperRWId == "" || objPaperReadWriteEN.paperRWId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = (0, clsPaperReadWriteWApi_js_1.PaperReadWrite_UpdateRecordAsync)(objPaperReadWriteEN).then((jsonData) => {
                    var returnBool = jsonData;
                    if (returnBool == true) {
                        var strInfo = `论文提交成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        //刷新缓存
                        (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_ReFreshThisCache)(strid_CurrEducls);
                        HideDialog();
                        this.BindGv_vPaperReadWrite();
                    }
                    else {
                        var strInfo = `论文提交不成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        console.log("提交失败");
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `修改记录不成功,${e}.`;
                alert(strMsg);
            }
        }
        //取消论文提交
        async btnCancelSubmit_Click(strKeyId) {
            var strUserId = $("#hidUserId").val();
            //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
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
            //this.DivName = "divUpdateRecordSave";
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            var objPaperReadWriteEN = new clsPaperReadWriteEN_js_1.clsPaperReadWriteEN();
            objPaperReadWriteEN.paperRWId = strKeyId;
            objPaperReadWriteEN.isSubmit = false;
            objPaperReadWriteEN.submitter = $("#hidUserId").val(); //提交人；
            objPaperReadWriteEN.sf_UpdFldSetStr = objPaperReadWriteEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperReadWriteEN.paperRWId == "" || objPaperReadWriteEN.paperRWId == undefined) {
                throw "关键字不能为空!";
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
        /* 函数功能:把界面上的属性数据传到类对象中
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
      <param name = "pobjPaperReadWriteEN">数据传输的目的类对象</param>
    */
        //public PutDataToPaperReadWriteClassSubmit(pobjPaperReadWriteEN: clsPaperReadWriteEN) {
        //    //pobjPaperReadWriteEN.paperRWId = this.paperRWId;// 论文读写Id
        //    pobjPaperReadWriteEN.isSubmit = true;
        //    pobjPaperReadWriteEN.submitter = $("#hidUserId").val();//提交人；
        //}
        /* 根据条件获取相应的记录对象的列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
      */
        async BindGv_vPaperReadWrite() {
            var strListDiv = this.mstrListDiv;
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            //var strWhereCond = this.CombinevPaperReadWriteCondition();
            var objvPaperReadWrite_Cond = this.CombinevPaperReadWriteConditionobj();
            var strWhereCond = JSON.stringify(objvPaperReadWrite_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvPaperReadWriteObjLst = [];
            var arrvPaperReadWriteExObjLst = [];
            try {
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvPaperReadWriteBy,
                    sortFun: (x, y) => { return 0; }
                };
                this.RecCount = await (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetRecCountByCond_Cache)(objvPaperReadWrite_Cond, strid_CurrEducls);
                console.log("完成计数!");
                arrvPaperReadWriteObjLst = await (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetObjLstByPager_Cache)(objPagerPara, strid_CurrEducls);
                console.log("完成对象列表获取!");
                arrvPaperReadWriteExObjLst = arrvPaperReadWriteObjLst.map(this.CopyToEx);
                for (var objInFor of arrvPaperReadWriteExObjLst) {
                    const conFuncMap = await this.FuncMap(objInFor);
                }
                //const responseRecCount = await vPaperReadWrite_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    this.RecCount = jsonData;
                //});
                //const responseObjLst = await vPaperReadWrite_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                //    arrvPaperReadWriteObjLst = <Array<clsvPaperReadWriteEN>>jsonData;
                //});
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                this.BindTab_vPaperReadWrite(strListDiv, arrvPaperReadWriteExObjLst);
                console.log("完成BindGv_vPaperReadWrite!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 把一个扩展类的部分属性进行函数转换
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap)
        /// </summary>
        /// <param name = "objzx_ConceptS">源对象</param>
        async FuncMap(objvPaperReadWrite) {
            try {
                {
                    var vUsersSim_UserId = objvPaperReadWrite.updUser;
                    var vUsersSim_UserName = await (0, clsvUsersSimWApi_js_1.vUsersSim_func)(clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserId, clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserName, vUsersSim_UserId);
                    objvPaperReadWrite.userName = vUsersSim_UserName;
                    var updDate = objvPaperReadWrite.updDate;
                    objvPaperReadWrite.updDate = updDate.substr(2, 14);
                }
                ;
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
            var objzx_ConceptENT = new clsvPaperReadWriteENEx_js_1.clsvPaperReadWriteENEx();
            try {
                objzx_ConceptENT = (0, clsvPaperReadWriteExWApi_js_1.vPaperReadWriteEx_CopyToEx)(objzx_ConceptENS);
                return objzx_ConceptENT;
            }
            catch (e) {
                var strMsg = clsString2_js_1.clsString.Format("(errid:WiTsCs0011)Copy表对象数据出错,${e}.({0})", clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction());
                alert(strMsg);
                return objzx_ConceptENT;
            }
        }
        /*
       * 用户
      */
        //public get ReadUser_q(): string {
        //    return $("#txtReadUser_q").val();
        //}
        get ReadUser_q() {
            return $("#ddlUserId_q").val();
        }
        /*
        * 教学班ID
       */
        set Id_CurrEduCls(value) {
            $("#hidId_CurrEduCls").val(value);
        }
        /*
        * 教学班
       */
        get Id_CurrEduCls() {
            return $("#hidId_CurrEduCls").val();
        }
    }
    exports.PaperReadList = PaperReadList;
});
