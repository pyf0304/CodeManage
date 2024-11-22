(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPublicPage/Public_Concept.js", "../TS/FunClass/clsDropDownList.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js", "../TS/L0_Entity/GraduateEduTopic/clsConceptAttachmentEN.js", "../TS/L0_Entity/GraduateEduTopic/clsConceptCitationEN.js", "../TS/L0_Entity/GraduateEduTopic/clsConceptEN.js", "../TS/L0_Entity/GraduateEduTopic/clsConceptVEN.js", "../TS/L0_Entity/GraduateEduTopic/clsRTConceptRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvConceptEN.js", "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/UserManage/clsvUsersSimEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsConceptAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsConceptCitationWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsConceptVWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsConceptWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTConceptRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js", "./Concept_QUDI_Cache.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Concept_QUDI_CacheEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:WApiConcept_QUDI_CacheEx
    表名:Concept(01120602)
    生成代码版本:2020.03.03.1
    生成日期:2020/03/09 13:58:58
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
    const Public_Concept_js_1 = require("../GraduateEduPublicPage/Public_Concept.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsvPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js");
    const clsConceptAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsConceptAttachmentEN.js");
    const clsConceptCitationEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsConceptCitationEN.js");
    const clsConceptEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsConceptEN.js");
    const clsConceptVEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsConceptVEN.js");
    const clsRTConceptRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTConceptRelaEN.js");
    const clsvConceptEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvConceptEN.js");
    const clsgs_ShareEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage/clsvUsersSimEN.js");
    const clsvPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperWApi.js");
    const clsSysCommentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsConceptAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsConceptAttachmentWApi.js");
    const clsConceptCitationWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsConceptCitationWApi.js");
    const clsConceptVWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsConceptVWApi.js");
    const clsConceptWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsConceptWApi.js");
    const clsRTConceptRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTConceptRelaWApi.js");
    const clsvConceptWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvConceptWApi.js");
    const clsgs_ShareWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsgs_UserConfigExWApi_js_1 = require("../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const Concept_QUDI_Cache_js_1 = require("./Concept_QUDI_Cache.js");
    /* WApiConcept_QUDI_CacheEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Concept_QUDI_CacheEx extends Concept_QUDI_Cache_js_1.Concept_QUDI_Cache {
        constructor() {
            super(...arguments);
            //论文列表
            this.mstrListDivPaper = "divPaperDataLst";
        }
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortConceptBy: string = "conceptId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
     */
        async Page_Load_Cache() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
                    //首次加载默认个人观点
                    var strViewType = "01";
                    $("#hidViewType").val(strViewType);
                    //1、为下拉框设置数据源,绑定列表数据
                    this.hidSortConceptBy = "updDate Desc";
                    //论文
                    this.hidSortvPaperBy = "updDate Desc";
                    //概念用户下拉框绑定
                    var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
                    const ddlConceptUserId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UserIdInvConcept_Cache("ddlConceptUserId_q", objUsers_Cond); //this.BindDdl_UserId("ddlUserId_q");
                    //文献类型；
                    const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId("ddlLiteratureTypeId_q");
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_Concept_Cache();
                    $("#divLoading").hide();
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
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
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlLiteratureTypeId, arrPaperObjLst, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
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
        /* 根据条件获取相应的对象列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
      */
        async btnQuery_Click(strListDiv) {
            //var strWhereCond = this.CombineConceptCondition();
            //var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
            //var arrConceptObjLst: Array<clsvConceptEN> = [];
            try {
                //const responseRecCount = await vConcept_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    this.RecCount = jsonData;
                //});
                //var objPagerPara: stuPagerPara = {
                //    pageIndex: intCurrPageIndex,
                //    pageSize: this.pageSize,
                //    whereCond: strWhereCond,
                //    orderBy: this.hidSortConceptBy
                //};
                //const responseObjLst = await vConcept_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                //    arrConceptObjLst = <Array<clsvConceptEN>>jsonData;
                //});
                //this.BindTab_Concept(this.mstrListDiv, arrConceptObjLst);
                this.BindGv_Concept_Cache();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `查询不成功,${e}.`;
                alert(strMsg);
            }
            // }
        }
        /* 修改记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
      */
        btnUpdateRecord_Click(strKeyId) {
            this.OpType = "Update";
            //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            this.UpdateRecord(strKeyId);
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
                //查询和id相关的关系数据是否存在
                //var strWhere = ` 1=1 And ${clsRTConceptRelaEN.con_ConceptId} = '${strKeyId}'`;
                //const responseObjLst = await RTConceptRela_GetObjLstAsync(strWhere).then((jsonData) => {
                //    var arrRTConceptRelaObjLst = <Array<clsRTConceptRelaEN>>jsonData;
                //    if (arrRTConceptRelaObjLst.length > 0) {
                //        alert("当前数据已被引用,不能删除！");
                //        return;
                //    }
                //    else {
                //        const responseText = this.DelRecord(strKeyId).then((jsonData) => {
                //            vConcept_ReFreshThisCache();
                //            const arrConcept_Cache = Concept_GetObjLstAsync("1=1");
                //        });
                //        const responseBindGv = this.BindGv_Concept_Cache();
                //    }
                //});
                //查询和id相关的关系数据是否存在
                var strWhere1 = ` 1=1 And ${clsRTConceptRelaEN_js_1.clsRTConceptRelaEN.con_ConceptId} = '${strKeyId}'`;
                var RTVCount = 0;
                const responseText1 = await (0, clsRTConceptRelaWApi_js_1.RTConceptRela_GetRecCountByCondAsync)(strWhere1).then((jsonData) => {
                    RTVCount = jsonData;
                });
                //查询和id相关的评论评分是否存在
                var strWhere2 = " 1=1 And tableKey ='" + strKeyId + "' and commentTypeId='05'";
                var commentCount = 0;
                const responseText2 = await (0, clsSysCommentWApi_js_1.SysComment_GetRecCountByCondAsync)(strWhere2).then((jsonData) => {
                    commentCount = jsonData;
                });
                if (RTVCount > 0) {
                    alert("当前数据已被引用,不能删除！");
                    return;
                }
                else if (commentCount > 0) {
                    alert("当前数据已被人评论打分,不能删除！");
                    return;
                }
                else {
                    var strConceptVWhereCond = " conceptId='" + strKeyId + "' order by updDate Asc";
                    var arrConceptVObjLst = [];
                    const responseText1 = await (0, clsConceptVWApi_js_1.ConceptV_GetObjLstAsync)(strConceptVWhereCond).then((jsonData) => {
                        arrConceptVObjLst = jsonData;
                    });
                    var arrSelectedKeys = arrConceptVObjLst.map((x) => {
                        var strId = x.conceptVId.toString();
                        return strId;
                    });
                    //更新总表3个参数 主键、子表类型、页面操作类型；
                    var strSubViewpointId = strKeyId;
                    const responseText7 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strSubViewpointId, "06", "3", this.Id_CurrEduCls);
                    var returnBool7 = !!responseText7;
                    if (returnBool7 == true) {
                        console.log("概念数据总表删除成功；");
                    }
                    else {
                        console.log("概念数据总表删除失败；");
                    }
                    const responseText0 = await this.VDelMultiRecord(arrSelectedKeys);
                    const responseText = await this.DelRecord(strKeyId);
                    (0, clsvConceptWApi_js_1.vConcept_ReFreshThisCache)(clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
                    const arrConcept_Cache = await (0, clsConceptWApi_js_1.Concept_GetObjLstAsync)("1=1");
                    const responseBindGv = await this.BindGv_Concept_Cache();
                    //const responseText2 = this.BindGv_vConcept();
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        VDelMultiRecord(arrConceptVId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsConceptVWApi_js_1.ConceptV_DelConceptVsAsync)(arrConceptVId).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            var strInfo = `删除历史版本成功,共删除${returnInt}条记录!`;
                            ////显示信息框
                            //alert(strInfo);
                            console.log(strInfo);
                        }
                        else {
                            var strInfo = `历史版本删除记录不成功!`;
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
                var strWhereCond = " conceptId in (" + strKeyList + ")";
                var arrConceptObjLst = [];
                const responseText1 = await (0, clsConceptWApi_js_1.Concept_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrConceptObjLst = jsonData;
                    //查询是否有提交的数据
                    arrConceptObjLst = arrConceptObjLst.filter(x => x.isSubmit == true);
                    if (arrConceptObjLst.length > 0) {
                        alert("包含有已提交数据，不能删除！");
                        return "";
                    }
                });
                const responseText = await this.DelMultiRecord(arrKeyIds);
                (0, clsvConceptWApi_js_1.vConcept_ReFreshThisCache)(clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
                //const arrConcept_Cache = await Concept_GetObjLstAsync("1=1");
                const responseBindGv = this.BindGv_Concept_Cache();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        ////专业下拉框绑定
        //public BindDdl_UserId(ddlUserId: string, strWhereCond: string = "1=1") {
        //    //var strWhereCond = " 1 =1 ";
        //    var objDdl = document.getElementById(ddlUserId);
        //    if (objDdl == null) {
        //        var strMsg = `下拉框：${ddlUserId} 不存在！`;
        //        alert(strMsg);
        //        throw (strMsg);
        //    }
        //    return new Promise((resolve, reject) => {
        //        try {
        //            const responseText = vConceptEx_GetConceptUserObjLstAsync(strWhereCond).then((jsonData) => {
        //                var arrUserObjLst: Array<clsvConceptEN> = <Array<clsvConceptEN>>jsonData;
        //                clsCommonFunc4Web.BindDdl_ObjLst(ddlUserId, arrUserObjLst, clsvConceptEN.con_UpdUser, clsvConceptEN.con_UserName, "编辑用户");
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
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
        <returns>条件串(strWhereCond)</returns>
      */
        async CombineConceptCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            // var objConcept_Cond: clsConceptEN = new clsConceptEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.ConceptName_q != "") {
                    strWhereCond += ` And ${clsConceptEN_js_1.clsConceptEN.con_ConceptName} like '% ${this.ConceptName_q}%'`;
                    // objConcept_Cond.SetCondFldValue(clsConceptEN.con_ConceptName, this.ConceptName_q, "like");
                }
                //if (this.UserName_q != "") {
                //    strWhereCond += ` And ${clsvConceptEN.con_UserName} like '% ${this.UserName_q}%'`;
                //}
                if (this.User_q != "" && this.User_q != "0") {
                    strWhereCond += ` And ${clsConceptEN_js_1.clsConceptEN.con_UpdUser} = '${this.User_q}'`;
                }
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsConceptEN_js_1.clsConceptEN.con_UpdDate} > '${this.StartDate_q}'`;
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsConceptEN_js_1.clsConceptEN.con_UpdDate} < '${this.EndDate_q}'`;
                }
                //if (this.IsSubmit_q == true) {
                //    strWhereCond += ` And ${clsConceptEN.con_IsSubmit} = '1'`;
                //    objConcept_Cond.SetCondFldValue(clsConceptEN.con_IsSubmit, true, "=");
                //}
                //else {
                //    strWhereCond += ` And ${clsConceptEN.con_IsSubmit} = '0'`;
                //    objConcept_Cond.SetCondFldValue(clsConceptEN.con_IsSubmit, false, "=");
                //}
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                    $("#btnCancelSubmit").show();
                }
                else if (strRoleId == "00620002") {
                    $("#btnCancelSubmit").show();
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    //strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";
                    //strWhereCond += " and updUser in (select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage.Getid_CurrEduCls() + "')";
                    //$("#btnCancelSubmit").hide();
                }
                else {
                    $("#btnCancelSubmit").hide();
                    //学生； 
                    strWhereCond += ` And ${clsConceptEN_js_1.clsConceptEN.con_UpdUser} = '${strUserId}'`;
                    //学生00620003
                    // strWhereCond += ` And ${clsResearchTopicEN.con_TopicProposePeople} = '${strUserId}'`;
                }
                $("#hidUserId").val(strUserId);
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineConceptConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
        <returns>条件串(strWhereCond)</returns>
      */
        CombineConceptConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objConcept_Cond = new clsvConceptEN_js_1.clsvConceptEN();
            objConcept_Cond.SetCondFldValue(clsvConceptEN_js_1.clsvConceptEN.con_id_CurrEduCls, clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls(), "=");
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.ConceptName_q != "") {
                    strWhereCond += ` And ${clsvConceptEN_js_1.clsvConceptEN.con_ConceptName} like '% ${this.ConceptName_q}%'`;
                    objConcept_Cond.SetCondFldValue(clsvConceptEN_js_1.clsvConceptEN.con_ConceptName, this.ConceptName_q, "like");
                }
                if (this.User_q != "" && this.User_q != "0") {
                    strWhereCond += ` And ${clsvConceptEN_js_1.clsvConceptEN.con_UpdUser} = '${this.User_q}'`;
                    objConcept_Cond.SetCondFldValue(clsvConceptEN_js_1.clsvConceptEN.con_UpdUser, this.User_q, "=");
                }
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsvConceptEN_js_1.clsvConceptEN.con_UpdDate} > '${this.StartDate_q}'`;
                    objConcept_Cond.SetCondFldValue(clsvConceptEN_js_1.clsvConceptEN.con_UpdDate, this.StartDate_q, ">");
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsvConceptEN_js_1.clsvConceptEN.con_UpdDate} < '${this.EndDate_q}'`;
                    objConcept_Cond.SetCondFldValue(clsvConceptEN_js_1.clsvConceptEN.con_UpdDate, this.EndDate_q, "<");
                }
                //if (this.IsSubmit_q == true) {
                //    strWhereCond += ` And ${clsvConceptEN.con_IsSubmit} = '1'`;
                //    objConcept_Cond.SetCondFldValue(clsvConceptEN.con_IsSubmit, true, "=");
                //}
                //else {
                //    strWhereCond += ` And ${clsvConceptEN.con_IsSubmit} = '0'`;
                //    objConcept_Cond.SetCondFldValue(clsvConceptEN.con_IsSubmit, false, "=");
                //}
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                    $("#btnCancelSubmit").show();
                }
                else if (strRoleId == "00620002") {
                    $("#btnCancelSubmit").show();
                    ////根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    ////strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";
                    ////strWhereCond += " and updUser in (select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage.Getid_CurrEduCls() + "')";
                    //strWhereCond += ` And ${clsConceptEN.con_id_CurrEduCls} = '${clsPublocalStorage.Getid_CurrEduCls()}'`;
                    //objConcept_Cond.SetCondFldValue(clsvConceptEN.con_id_CurrEduCls, clsPublocalStorage.Getid_CurrEduCls(), "=");
                    ////var strWhereUserId = "(select stuID from vCurrEduClsStu where id_CurrEduCls = '" + clsPublocalStorage.Getid_CurrEduCls() + "')";
                    ////objConcept_Cond.SetCondFldValue(clsvConceptEN.con_UpdUser, strWhereUserId, "in");
                    ////$("#btnCancelSubmit").hide();
                }
                else {
                    $("#btnCancelSubmit").hide();
                    //学生； 
                    //这里判断--如果类型为01 个人观点、否则是他人观点；
                    var strViewType = $("#hidViewType").val();
                    if (strViewType == "01") {
                        strWhereCond += ` And ${clsConceptEN_js_1.clsConceptEN.con_UpdUser} = '${strUserId}'`;
                        objConcept_Cond.SetCondFldValue(clsvConceptEN_js_1.clsvConceptEN.con_UpdUser, strUserId, "=");
                    }
                    else {
                        //strWhereCond += ` And ${clsConceptEN.con_UpdUser} <> '${strUserId}'`;
                        // objConcept_Cond.SetCondFldValue(clsvConceptEN.con_UpdUser, strUserId, "<>");
                    }
                    //学生00620003
                    // strWhereCond += ` And ${clsResearchTopicEN.con_TopicProposePeople} = '${strUserId}'`;
                }
                $("#hidUserId").val(strUserId);
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineConceptConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objConcept_Cond;
        }
        /* 根据条件获取相应的对象列表
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
    */
        async BindGv_Concept_Cache() {
            var strListDiv = this.mstrListDiv;
            //var strWhereCond = this.CombineConceptCondition();
            var objConcept_Cond = this.CombineConceptConditionObj();
            var strWhereCond = JSON.stringify(objConcept_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrConceptObjLst = [];
            try {
                this.RecCount = await (0, clsvConceptWApi_js_1.vConcept_GetRecCountByCond_Cache)(objConcept_Cond, clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
                //const responseRecCount = await vConcept_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    this.RecCount = jsonData;
                //});
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortConceptBy,
                    sortFun: (x, y) => { return 0; }
                };
                var arrConceptObjLst = await (0, clsvConceptWApi_js_1.vConcept_GetObjLstByPager_Cache)(objPagerPara, clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
                //const responseObjLst = await vConcept_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                //    arrConceptObjLst = <Array<clsvConceptEN>>jsonData;
                //});
                //这里判断--如果类型为01 个人观点、否则是他人观点；
                var strViewType = $("#hidViewType").val();
                if (strViewType != "01") {
                    arrConceptObjLst = arrConceptObjLst.filter(x => x.updUser != clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
                }
                ////换行符
                //var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
                ////动态显示对应的数据
                //var strhtml = "";
                //var strUserId = clsPubSessionStorage.GetSession_UserId();
                //var strRoleId = clsPubSessionStorage.GetSession_RoleId();
                ////个人观点
                //strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';
                ////strhtml += '<div style="float:left;"><a href="#" title="当前论文相关' + strTitle + '">当前论文相关' + strTitle + '</a></div>';
                //strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加概念" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加概念</button></div>';
                //strhtml += '</div><ul class="artlist">';
                //var v = 0;//给内容加个序号
                //for (var i = 0; i < arrConceptObjLst.length; i++) {
                //    //得到conceptId；
                //    var strConceptId = arrConceptObjLst[i].conceptId;
                //    v++;
                //    //对内容进行换行替换
                //    var strConceptContent = arrConceptObjLst[i].conceptContent;
                //    strConceptContent = strConceptContent.replace(/\r\n/g, strBr);
                //    strConceptContent = strConceptContent.replace(/\n/g, strBr);
                //    //strhtml += v + ".观点：" + arrConceptObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrConceptObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrConceptObjLst[i].viewpointTypeName + ":" + arrConceptObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrConceptObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                //    strhtml += '<li><span class="rowtit color3">[概念名称]：</span><span class="abstract-text">' + arrConceptObjLst[i].conceptName + '</span></li>';
                //    strhtml += '<li><span class="rowtit color3">[概念内容]：</span><span class="abstract-text">' + strConceptContent + '</span></li>';
                //    strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:70%;">'
                //    strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrConceptObjLst[i].updDate + '</span>';
                //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + arrConceptObjLst[i].userName + '</span>'
                //    //判断ture 、false
                //    if (arrConceptObjLst[i].isSubmit == true) {
                //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
                //    }
                //    else {
                //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
                //    }
                //    //strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3"> [是否提交]：</span><span class="abstract-text">' + arrConceptObjLst[i].isSubmit + '</span></div>';
                //    if (strUserId == arrConceptObjLst[i].updUser) {
                //        strhtml += '<div style="float:right;width:28%;">&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">[操作]：</span>';
                //        //修改个人观点
                //        strhtml += '&nbsp;&nbsp;<button title="修改概念" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + arrConceptObjLst[i].conceptId + '")> <i class="layui-icon" >&#xe642;</i>修改</button>';
                //        //删除个人观点
                //        strhtml += '&nbsp;&nbsp;<button title="删除概念" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelRecordInTab_Click("' + arrConceptObjLst[i].conceptId + '")> <i class="layui-icon" >&#xe640;</i>删除</button>';
                //        //观点提交
                //        strhtml += '&nbsp;&nbsp;<button title="概念提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsSubmit_Click("' + arrConceptObjLst[i].conceptId + '")> <i class="layui-icon" >&#xe642;</i>概念提交</button>';
                //        //历史版本
                //        if (arrConceptObjLst[i].versionCount > 0 && arrConceptObjLst[i].versionCount != null) {
                //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('相关概念历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrConceptObjLst[i].conceptId + "&Type=05')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                //        }
                //        strhtml += "&nbsp;&nbsp;<button id=\"AddViewRela\" class=\"layui-btn-xs layui-btn layui-btn-normal\" onclick=\" xadmin.open('建立观点关系', '../GraduateEduTools/gs_TotalDataRela?KeyId=" + strConceptId + "&TypeId=06','','',true)\"> <i class=\"layui-icon\" >&#xe642;</i>建立观点关系</button >";
                //    } else {
                //        strhtml += '<div style="float:right;width:28%;">&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：</span>';
                //    }
                //    //读取session角色 来判断绑定不同数据列表
                //    //获取用户角色来判断显示不同的列表数据；
                //    if (strRoleId != "00620003") {
                //        //取消提交
                //        strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrConceptObjLst[i].conceptId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';
                //    }
                //    //else {
                //    //    //学生00620003 教师 需要隐藏
                //    //    //取消提交
                //    //    strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" style="display:none;" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrConceptObjLst[i].conceptId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';
                //    //}
                //    strhtml += '</div></div></li>';
                //    //strhtml += '<li><span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrConceptObjLst[i].updDate + '</span></li>';
                //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + arrConceptObjLst[i].userName + '</span></li>';
                //    //strhtml += '</li>';
                //    strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
                //}
                //strhtml += '</ul></div>';
                var strHtml = await Public_Concept_js_1.Public_Concept.BindList_vConcept("01", arrConceptObjLst);
                var strViewType = $("#hidViewType").val();
                if (strViewType == "01") {
                    //拼接；
                    $("#divDataLst").html(strHtml);
                }
                else {
                    //拼接；
                    $("#divOtherDataLst").html(strHtml);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrConceptObjLst.length == 0) {
            //    var strMsg: string = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=Concept)`;
            //    alert(strMsg);
            //    return;
            //}
            //try {
            //    this.BindTab_Concept(strListDiv, arrConceptObjLst);
            //    console.log("完成BindGv_Concept!");
            //}
            //catch (e) {
            //    console.error('catch(e)=');
            //    console.error(e);
            //    var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            //    alert(strMsg);
            //}
            if (this.RecCount >= 10) {
                $("#divPager1").show();
                this.objPager.RecCount = this.RecCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
            }
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
            var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
            const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4List, "ddlShareId");
            this.UpdateRecord(strKeyId);
        }
        /* 显示Concept对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrConceptObjLst">需要绑定的对象列表</param>
       */
        BindTab_Concept(divContainer, arrConceptObjLst) {
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
                    FldName: "conceptName",
                    ColHeader: "概念名称",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "conceptContent",
                    ColHeader: "概念内容",
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
                    FldName: "updDate",
                    ColHeader: "修改日期",
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
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrConceptObjLst, arrDataColumn, "conceptId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 添加新记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
      */
        async btnAddNewRecord_Click() {
            this.OpType = "Add";
            try {
                var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
                const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4List, "ddlShareId");
                const responseText = await this.AddNewRecord();
                //获取分享Id
                const responseText1 = await (0, clsgs_UserConfigExWApi_js_1.gs_UserConfigEx_GetNewReturnShareIdEx)("06", clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
                var strShareId = responseText1;
                //var returnBool: boolean = !!responseText2;
                if (strShareId != "") {
                    this.shareId = strShareId;
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 为插入记录做准备工作
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
     */
        AddNewRecord() {
            this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //去掉提交按钮不可用状态
            $('#btnOKUpd').attr("disabled", false);
            //wucConceptB1.conceptId = clsConceptBL.GetMaxStrId_S();
        }
        /* 添加新记录，保存函数
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
     */
        async AddNewRecordSave() {
            try {
                const responseText = await (0, clsConceptWApi_js_1.Concept_GetMaxStrIdAsync)().then((jsonData) => {
                    var returnString = jsonData.toString();
                    if (returnString == "") {
                        var strInfo = `获取表ViewPoint的最大关键字为空，不成功，请检查!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        $('#txtConceptId').val(returnString);
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            if ($('#txtConceptId').val() != "") {
                this.DivName = "divAddNewRecordSave";
                var objConceptEN = new clsConceptEN_js_1.clsConceptEN();
                objConceptEN.createDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd();
                var strConceptId = $('#txtConceptId').val();
                $('#hidConceptId').val(strConceptId);
                this.PutDataToConceptClass(objConceptEN);
                try {
                    const responseText = await (0, clsConceptWApi_js_1.Concept_IsExistAsync)(objConceptEN.conceptId);
                    var bolIsExist = responseText;
                    if (bolIsExist == true) {
                        var strMsg = `添加记录时，关键字：${objConceptEN.conceptId}已经存在！`;
                        alert(strMsg);
                        return responseText; //一定要有一个返回值，否则会出错！
                    }
                    const responseText2 = await (0, clsConceptWApi_js_1.Concept_AddNewRecordAsync)(objConceptEN);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        ////添加引用论文之前需要判断是否有引用论文；有则执行论文添加、没有则执行附件；
                        //if ($("#txtPaperId").val() == "") {
                        //添加成功，则执行附件添加方法；
                        //判断是否有返回的附件路径值
                        if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                            var fileOne = $("#hdnFileOne").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                        }
                        else {
                            if ($("#hdnFileTwo").val() != "") {
                                var fileTwo = $("#hdnFileTwo").val();
                                this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                            }
                            else {
                                if ($("#hdnFileThree").val() != "") {
                                    var fileThree = $("#hdnFileThree").val();
                                    this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                                }
                            }
                        }
                        //}
                        //else {
                        //    //1.这里执行添加观点引用论文；
                        //    var objclsConceptCitationEN: clsConceptCitationEN = new clsConceptCitationEN();
                        //    this.PutDataToclsConceptCitationClass(objclsConceptCitationEN);
                        //    //引用论文；
                        //    const responseText3 = await ConceptCitation_AddNewRecordAsync(objclsConceptCitationEN);
                        //    var returnBool: boolean = !!responseText3;
                        //    if (returnBool == true) {
                        //    }
                        //    else {
                        //    }
                        //}
                        this.BindGv_Concept_Cache();
                        // Concept_ReFreshCache();
                        //const arrConcept_Cache = await Concept_GetObjLstAsync("1=1");
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
            }
            else {
                var strInfo = `获取最大关键字为空，不成功!`;
                //显示信息框
                alert(strInfo);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjConceptEN">数据传输的目的类对象</param>
       */
        PutDataToConceptVClass(pobjConceptVEN) {
            var strUserId = $("#hidUserId").val();
            pobjConceptVEN.conceptId = this.conceptId; // 概念Id
            pobjConceptVEN.conceptContent = this.conceptContent; // 概念内容
            pobjConceptVEN.conceptName = this.conceptName; // 概念名称
            pobjConceptVEN.citationId = this.paperId; //引用论文Id；
            pobjConceptVEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjConceptVEN.updUser = strUserId; // 修改用户Id
            pobjConceptVEN.id_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            pobjConceptVEN.memo = this.memo; // 备注
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjConceptEN">数据传输的目的类对象</param>
       */
        PutDataToConceptClass(pobjConceptEN) {
            var strUserId = $("#hidUserId").val();
            pobjConceptEN.conceptId = this.conceptId; // 概念Id
            pobjConceptEN.conceptContent = this.conceptContent; // 概念内容
            pobjConceptEN.conceptName = this.conceptName; // 概念名称
            pobjConceptEN.isSubmit = false; // 是否提交
            pobjConceptEN.citationId = this.paperId; //引用论文Id；
            pobjConceptEN.shareId = this.shareId;
            pobjConceptEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjConceptEN.updUser = strUserId; // 修改用户Id
            pobjConceptEN.id_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            pobjConceptEN.memo = this.memo; // 备注
        }
        /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjRTViewpointRelaEN">数据传输的目的类对象</param>
    */
        PutDataToclsConceptCitationClass(pobjConceptCitationEN) {
            var strPaperId = $("#txtPaperId").val();
            var strConceptId = $("#txtConceptId").val();
            var strUserId = $("#hidUserId").val();
            pobjConceptCitationEN.paperId = strPaperId; // 论文编号
            pobjConceptCitationEN.conceptId = strConceptId; // 概念Id
            pobjConceptCitationEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjConceptCitationEN.updUserId = strUserId; // 修改用户Id// 修改用户Id
            //pobjRTViewpointRelaEN.memo = this.memo;// 备注
        }
        //////////////////////////////////////////////////////////////////////附件添加
        //添加上传论文附件方法
        async AddNewRecordobjPaperSubAttachmentENSave(filePath, strfileNum) {
            var objConceptAttachmentEN = new clsConceptAttachmentEN_js_1.clsConceptAttachmentEN();
            this.PutDataToPaperAttachmentClass(objConceptAttachmentEN, filePath);
            try {
                const responseText2 = await (0, clsConceptAttachmentWApi_js_1.ConceptAttachment_AddNewRecordAsync)(objConceptAttachmentEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //第一个附件
                    if (strfileNum == "first") {
                        //如果第二个附件不等于空，那么执行添加函数；
                        if ($("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined) {
                            var fileTwo = $("#hdnFileTwo").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                        }
                        else {
                            //为空则判断第三个附件值；
                            if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                                var fileThree = $("#hdnFileThree").val();
                                this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                            }
                        }
                    }
                    else if (strfileNum == "two") {
                        //为空则判断第三个附件值；
                        if ($("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                            var fileThree = $("#hdnFileThree").val();
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                        }
                    }
                }
                else {
                    var strInfo = `论文附件添加不成功!`;
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
        //观点附件数据存放
        PutDataToPaperAttachmentClass(pobjConceptAttachmentEN, filePath) {
            pobjConceptAttachmentEN.conceptId = $("#txtConceptId").val(); // 概念Id
            var strfilePath = filePath;
            //判断地址不为空则执行截取操作
            if (strfilePath != "") {
                var index = strfilePath.lastIndexOf("\/");
                strfilePath = strfilePath.substring(index + 1, strfilePath.length);
                pobjConceptAttachmentEN.filePath = filePath;
                pobjConceptAttachmentEN.conceptAttachmentName = strfilePath;
            }
            pobjConceptAttachmentEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjConceptAttachmentEN.id_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls(); //教学班
            pobjConceptAttachmentEN.updUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId(); // 修改用户Id
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////修改时的方法
        /* 修改记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
     */
        UpdateRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objConceptEN = new clsConceptEN_js_1.clsConceptEN();
            objConceptEN.conceptId = this.KeyId;
            $('#hidConceptId').val(this.KeyId);
            this.PutDataToConceptClass(objConceptEN);
            objConceptEN.sf_UpdFldSetStr = objConceptEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objConceptEN.conceptId == "" || objConceptEN.conceptId == undefined) {
                throw "关键字不能为空!";
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsConceptWApi_js_1.Concept_UpdateRecordAsync)(objConceptEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            ////判断引用的论文ID是否为空
                            //var strPaperId = $("#txtPaperId").val();
                            //if (strPaperId != "") {
                            //    //，如果不为空，根据Id删除引用文件
                            //    var strwhere = "conceptId ='" + objConceptEN.conceptId + "'";
                            //    this.DelRecordViewpointCitationByWhere(strwhere);
                            //}
                            //else {
                            //如果等于空，那么就去判断附件是否为空；
                            //得到相关论文附件地址，判断是否为空 只要有一个不为空都执行附件清除功能；
                            if ($("#hdnFileOne").val() != "" && $("#hdnFileOne").val() != undefined || $("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined || $("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                                //根据Id删除附件
                                var strwhere = "conceptId ='" + objConceptEN.conceptId + "'";
                                this.DelRecordByWhere(strwhere);
                            }
                            //}
                            var strInfo = `修改记录成功!`;
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                        }
                        else {
                            var strInfo = `修改记录不成功!`;
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            console.log("完成UpdateRecordSave");
                        }
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `修改记录不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        //添加历史版本
        async AddVersionRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objConceptVEN = new clsConceptVEN_js_1.clsConceptVEN();
            objConceptVEN.conceptId = this.conceptId;
            this.PutDataToConceptVClass(objConceptVEN);
            try {
                const responseText2 = await (0, clsConceptVWApi_js_1.ConceptV_AddNewRecordAsync)(objConceptVEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " 1 =1 and conceptId=" + this.conceptId;
                    var intVersionCount = await (0, clsConceptVWApi_js_1.ConceptV_GetRecCountByCondAsync)(strWhereCond2);
                    var objConceptEN = new clsConceptEN_js_1.clsConceptEN();
                    objConceptEN.conceptId = this.conceptId;
                    objConceptEN.versionCount = intVersionCount;
                    objConceptEN.sf_UpdFldSetStr = objConceptEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objConceptEN.conceptId == "" || objConceptEN.conceptId == undefined) {
                        throw "关键字不能为空!";
                    }
                    const responseText = (0, clsConceptWApi_js_1.Concept_UpdateRecordAsync)(objConceptEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            return true;
                        }
                        else {
                            var strInfo = `添加历史版本数不成功!`;
                            alert(strInfo);
                            console.log("添加历史版本数不成功");
                            return false;
                        }
                    });
                    return true;
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加版本记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true;
        }
        //删除论文引用附件
        DelRecordViewpointCitationByWhere(strWhere) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsConceptCitationWApi_js_1.ConceptCitation_DelConceptCitationsByCondAsync)(strWhere).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                            ////显示信息框
                            //alert(strInfo);
                        }
                        else {
                            var strInfo = `删除记录不成功!`;
                            //显示信息框
                            //alert(strInfo);
                        }
                        //清除后、添加新的论文数据；
                        this.AddNewRecordConceptCitationSave();
                        console.log("完成DelRecord!");
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
        //添加引用论文
        async AddNewRecordConceptCitationSave() {
            //1.这里执行添加观点引用论文；
            var objConceptCitationEN = new clsConceptCitationEN_js_1.clsConceptCitationEN();
            this.PutDataToclsConceptCitationClass(objConceptCitationEN);
            //引用论文；
            const responseText3 = await (0, clsConceptCitationWApi_js_1.ConceptCitation_AddNewRecordAsync)(objConceptCitationEN);
            var returnBool = !!responseText3;
            if (returnBool == true) {
                //在修改时候，不管是否有附件数据被清除； 都需要执行附件添加功能
                //判断是否有返回的附件路径值
                var fileOne = $("#hdnFileOne").val();
                if (fileOne != "" && fileOne != undefined) { //第一个附件框判断
                    this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                }
                else {
                    var fileTwo = $("#hdnFileTwo").val();
                    if (fileTwo != "" && fileTwo != undefined) {
                        this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                    }
                    else {
                        var fileThree = $("#hdnFileThree").val();
                        if (fileThree != "" && fileThree != undefined) {
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                        }
                    }
                }
            }
        }
        //删除观点附件
        /*
    根据关键字删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    */
        DelRecordByWhere(strWhere) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsConceptAttachmentWApi_js_1.ConceptAttachment_DelConceptAttachmentsByCondAsync)(strWhere).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                            ////显示信息框
                            //alert(strInfo);
                        }
                        else {
                            var strInfo = `删除记录不成功!`;
                            //显示信息框
                            //alert(strInfo);
                        }
                        //在修改时候，不管是否有附件数据被清除； 都需要执行附件添加功能
                        //判断是否有返回的附件路径值
                        var fileOne = $("#hdnFileOne").val();
                        if (fileOne != "" && fileOne != undefined) { //第一个附件框判断
                            this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                        }
                        else {
                            var fileTwo = $("#hdnFileTwo").val();
                            if (fileTwo != "" && fileTwo != undefined) {
                                this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                            }
                            else {
                                var fileThree = $("#hdnFileThree").val();
                                if (fileThree != "" && fileThree != undefined) {
                                    this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                                }
                            }
                        }
                        console.log("完成DelRecord!");
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
            this.BindGv_vPaper();
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
        get PaperTitle_q() {
            return $("#txtPaperTitle_q").val();
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
        /* 把所有的查询控件内容组合成一个条件串
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
      <returns>条件串(strWhereCond)</returns>
    */
        CombinevPaperCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strPaperTypeId = $("#hidPaperTypeId").val();
            var strTopicId = $("#hidTopicRelaId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.PaperTitle_q != "") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
                }
                if (this.LiteratureTypeId_q != "" && this.LiteratureTypeId_q != "0") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeId} = '${this.LiteratureTypeId_q}'`;
                }
                //用户
                if (this.ReadUser_q != "" && this.ReadUser_q != "0") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_UpdUser} = '${this.ReadUser_q}'`;
                }
                //只查询提交的论文数据
                strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_IsSubmit} = 'true'`;
                //排除获取已被当前观点引用过的论文数据；
                //strWhereCond += ` And paperId not in (select paperId from RTPaperRela where viewpointId = '${strTopicId}')`;
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的记录对象的列表
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vPaper() {
            var strListDiv = this.mstrListDivPaper;
            var strWhereCond = this.CombinevPaperCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvPaperObjLst = [];
            try {
                const responseRecCount = await (0, clsvPaperWApi_js_1.vPaper_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvPaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvPaperWApi_js_1.vPaper_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvPaperObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                this.BindTab_vPaper(strListDiv, arrvPaperObjLst);
                console.log("完成BindGv_vPaper!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vPaper对象的所有属性值
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
       <param name = "divContainer">显示容器</param>
       <param name = "arrPaperObjLst">需要绑定的对象列表</param>
     */
        BindTab_vPaper(divContainer, arrvPaperObjLst) {
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
                    FldName: "updDate",
                    ColHeader: "提交日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "提交用户",
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
                        btn1.setAttribute("onclick", `btnPaperRecordInTab_Click("${strKeyId}");`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2Where(o, arrvPaperObjLst, arrDataColumn, "paperId", "TopicPaper");
            //clsCommonFunc4Web.BindTabV2(o, arrvPaperObjLst, arrDataColumn, "paperId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        //选择论文弹出列表数据；
        async selectPaper_Click() {
            //论文用户
            var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
            const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId_q", objUsers_Cond); //用户查询区域
            const responseObjList = await this.BindGv_vPaper();
        }
        //查询论文列表
        async btnPaperQuery_Click() {
            const responseObjList = await this.BindGv_vPaper();
        }
        //确定选择的论文 并添加到关系表中
        btnPaperRecordInTab_Click(strkeyId) {
            //存放Id
            $("#hidPaperId").val(strkeyId);
            $("#txtPaperId").val(strkeyId);
            //设置只读属性；
            $("#txtPaperId").attr("disabled", "disabled");
            //关闭列表
            HideDialogThree();
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
       具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
     */
        async btnOKUpd_Click() {
            var strCommandText = this.btnOKUpd;
            try {
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
                    switch (strCommandText) {
                        case "添加":
                            const responseText1 = await this.AddNewRecord();
                            break;
                        case "确认添加":
                            //这是一个单表的插入的代码,由于逻辑层太简单,
                            //就把逻辑层合并到控制层,
                            //if (this.OpType == "AddWithMaxId") {
                            //    const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                            //        var returnBool2: boolean = jsonData;
                            //        if (returnBool2 == true) {
                            //            HideDialog();
                            //            this.BindGv_Concept_Cache();
                            //        }
                            //    });
                            //}
                            //else {
                            //}
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                }
                            });
                            //更新总表3个参数 主键、子表类型、页面操作类型；
                            var strSubViewpointId = $('#hidConceptId').val();
                            const responseText6 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strSubViewpointId, "06", "1", this.Id_CurrEduCls);
                            var returnBool6 = !!responseText6;
                            if (returnBool6 == true) {
                                console.log("论文子观点数据总表同步成功；");
                            }
                            else {
                                console.log("论文子观点数据总表同步失败；");
                            }
                            //修改记录的同时添加历史版本
                            const responseText3 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    (0, clsvConceptWApi_js_1.vConcept_ReFreshThisCache)(clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
                                    HideDialog();
                                    this.BindGv_Concept_Cache();
                                    //alert("添加历史版本出问题！");
                                }
                            });
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            const responseText4 = await this.UpdateRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    //Concept_ReFreshCache();
                                    //const arrConcept_Cache = Concept_GetObjLstAsync("1=1");
                                }
                            });
                            //更新总表3个参数 主键、子表类型、页面操作类型；
                            var strSubViewpointId = $('#hidConceptId').val();
                            const responseText7 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strSubViewpointId, "06", "2", this.Id_CurrEduCls);
                            var returnBool7 = !!responseText7;
                            if (returnBool7 == true) {
                                console.log("论文子观点数据总表同步成功；");
                            }
                            else {
                                console.log("论文子观点数据总表同步失败；");
                            }
                            //修改记录的同时添加历史版本
                            const responseText5 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    (0, clsvConceptWApi_js_1.vConcept_ReFreshThisCache)(clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
                                    this.BindGv_Concept_Cache();
                                    //alert("添加历史版本出问题！");
                                }
                            });
                            break;
                        default:
                            var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                            alert(strMsg);
                            break;
                    }
                }
                else {
                    alert("登录超时，请重新登录");
                    window.top.location.href = "../Web/Login";
                }
                $("#divLoading").hide();
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
        UpdateRecord(strConceptId) {
            this.btnOKUpd = "确认修改";
            this.btnCancel = "取消修改";
            this.KeyId = strConceptId;
            var strUserId = $("#hidUserId").val();
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsConceptWApi_js_1.Concept_GetObjByConceptIdAsync)(strConceptId).then((jsonData) => {
                        var objConceptEN = jsonData;
                        // //通过判断数据用户是否是当前登录用户；
                        if (objConceptEN.updUser == strUserId) {
                            //判断数据是否提交，提交则不可修改；
                            if (objConceptEN.isSubmit == false) {
                                ShowDialog('Update');
                                this.GetDataFromConceptClass(objConceptEN);
                                console.log("完成UpdateRecord!");
                                resolve(jsonData);
                            }
                            else {
                                alert("当前数据已提交,不能修改！");
                                return;
                            }
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
        /* 函数功能:把类对象的属性内容显示到界面上
      注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
       如果在设置数据库时,就应该一级字段在前,二级字段在后
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
       <param name = "pobjConceptEN">表实体类对象</param>
     */
        GetDataFromConceptClass(pobjConceptEN) {
            this.conceptId = pobjConceptEN.conceptId; // 概念Id
            this.conceptContent = pobjConceptEN.conceptContent; // 概念内容
            this.conceptName = pobjConceptEN.conceptName; // 概念名称
            this.isSubmit = pobjConceptEN.isSubmit; // 是否提交
            this.paperId = pobjConceptEN.citationId; //引用论文Id
            this.shareId = pobjConceptEN.shareId;
            this.updDate = pobjConceptEN.updDate; // 修改日期
            this.updUser = pobjConceptEN.updUser; // 修改用户Id
            this.memo = pobjConceptEN.memo; // 备注
        }
        //概念提交审核
        async btnIsSubmit_Click(strKeyId) {
            //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            const responseText1 = await this.SubmitRecord(strKeyId);
            const responseText2 = await this.BindGv_Concept_Cache();
        }
        //提交判断；
        async SubmitRecord(strConceptId) {
            this.KeyId = strConceptId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsConceptWApi_js_1.Concept_GetObjByConceptIdAsync)(strConceptId).then((jsonData) => {
                        var objConceptEN = jsonData;
                        //通过session 权限获取权限
                        var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                        var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                        //判断角色 //学生00620003
                        if (strRoleId == "00620003") {
                            // //通过判断数据用户是否是当前登录用户；
                            if (objConceptEN.updUser == strUserId) {
                                //判断数据是否已审核
                                if (objConceptEN.isSubmit == false) {
                                    const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                                    });
                                }
                                else {
                                    alert("当前数据已提交！");
                                    return;
                                }
                            }
                            else {
                                alert("当前数据不是您所添加，不能提交！");
                                return;
                            }
                        }
                        else {
                            //可以提交
                            //判断数据是否已提交
                            if (objConceptEN.isSubmit == false) {
                                const responseText3 = this.SubmitRecordSave().then((jsonData) => {
                                });
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
            });
        }
        /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
    */
        SubmitRecordSave() {
            //this.DivName = "divUpdateRecordSave";
            var objConceptEN = new clsConceptEN_js_1.clsConceptEN();
            objConceptEN.conceptId = this.KeyId;
            objConceptEN.isSubmit = true;
            // this.PutDataToConceptClass(objConceptEN);
            objConceptEN.sf_UpdFldSetStr = objConceptEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objConceptEN.conceptId == "" || objConceptEN.conceptId == undefined) {
                throw "关键字不能为空!";
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsConceptWApi_js_1.Concept_UpdateRecordAsync)(objConceptEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            var strInfo = `提交成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            HideDialog();
                            (0, clsvConceptWApi_js_1.vConcept_ReFreshThisCache)(clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
                            this.BindGv_Concept_Cache();
                        }
                        else {
                            var strInfo = `提交不成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            console.log("提交失败");
                        }
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `修改记录不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /*
    论文
    */
        async SortByPaper(strSortByFld) {
            if (this.hidSortvPaperBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvPaperBy.indexOf("Asc") >= 0) {
                    this.hidSortvPaperBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvPaperBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvPaperBy = `${strSortByFld} Asc`;
            }
            const responseText2 = await this.BindGv_vPaper();
        }
        //取消提交
        async btnCancelSubmit_Click(strKeyId) {
            var strUserId = $("#hidUserId").val();
            //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
            if (strKeyId == "") {
                alert("请选择需要取消的记录！");
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
        /*取消论文
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
     */
        async CancelSubmitRecordSave(strKeyId) {
            //this.DivName = "divUpdateRecordSave";
            var objConceptEN = new clsConceptEN_js_1.clsConceptEN();
            objConceptEN.conceptId = strKeyId;
            objConceptEN.isSubmit = false;
            //objPaperEN..submitter = $("#hidUserId").val();//提交人；
            objConceptEN.sf_UpdFldSetStr = objConceptEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objConceptEN.conceptId == "" || objConceptEN.conceptId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = (0, clsConceptWApi_js_1.Concept_UpdateRecordAsync)(objConceptEN).then((jsonData) => {
                    var returnBool = jsonData;
                    if (returnBool == true) {
                        var strInfo = `取消成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        (0, clsvConceptWApi_js_1.vConcept_ReFreshThisCache)(clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
                        //HideDialog();
                        this.BindGv_Concept_Cache();
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
        /*
       * 用户名
      */
        get UserName_q() {
            return $("#txtUserName_q").val();
        }
        /*
    * 起始时间
    */
        get StartDate_q() {
            return $("#txtStartDate_q").val();
        }
        /*
        * 起始时间
       */
        set StartDate_q(value) {
            $("#txtStartDate_q").val(value);
        }
        /*
       * 结束时间
      */
        get EndDate_q() {
            return $("#txtEndDate_q").val();
        }
        /*
        * 结束时间
       */
        set EndDate_q(value) {
            $("#txtEndDate_q").val(value);
        }
        get User_q() {
            return $("#ddlConceptUserId_q").val();
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
    exports.Concept_QUDI_CacheEx = Concept_QUDI_CacheEx;
});
