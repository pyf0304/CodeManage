(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPaper/Paper_EditEx.js", "../PagesBase/GraduateEduPaper/PaperCRUD.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../TS/L0_Entity/ParameterTable/clsgs_PaperStatusEN.js", "../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js", "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js", "../TS/L3_ForWApi/InteractManage/clsgs_TagsWApi.js", "../TS/L3_ForWApi/InteractManage/clsqa_QuestionsWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_PaperStatusWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsPaperWApiEx.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsMajorDirectionPaperRelaExWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperEduClsRelaExWApi.js", "../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "./Paper_QUDI_AllPaper.js", "./Paper_QUDI_CurrEduCls.js", "./Paper_QUDI_Direction.js", "./Paper_QUDI_Major.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Paper_QUDIEx = void 0;
    const Paper_EditEx_js_1 = require("../GraduateEduPaper/Paper_EditEx.js");
    const PaperCRUD_js_1 = require("../PagesBase/GraduateEduPaper/PaperCRUD.js");
    const clsPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsgs_PaperStatusEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_PaperStatusEN.js");
    const clsgs_PaperTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_PaperTypeEN.js");
    const clsgs_ShareEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsXzMajorDirectionWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js");
    const clsPaperAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperAttachmentWApi.js");
    const clsPaperWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsRTPaperRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTPaperRelaWApi.js");
    const clsgs_TagsWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsgs_TagsWApi.js");
    const clsqa_QuestionsWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsqa_QuestionsWApi.js");
    const clsgs_PaperStatusWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_PaperStatusWApi.js");
    const clsgs_PaperTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js");
    const clsgs_ShareWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsPaperWApiEx_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsPaperWApiEx.js");
    const clsMajorDirectionPaperRelaExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsMajorDirectionPaperRelaExWApi.js");
    const clsPaperEduClsRelaExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperEduClsRelaExWApi.js");
    const clsPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduPaper/clsPaperExWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const Paper_QUDI_AllPaper_js_1 = require("./Paper_QUDI_AllPaper.js");
    const Paper_QUDI_CurrEduCls_js_1 = require("./Paper_QUDI_CurrEduCls.js");
    const Paper_QUDI_Direction_js_1 = require("./Paper_QUDI_Direction.js");
    const Paper_QUDI_Major_js_1 = require("./Paper_QUDI_Major.js");
    /* Paper_QUDIEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class Paper_QUDIEx extends PaperCRUD_js_1.PaperCRUD {
        constructor() {
            super(...arguments);
            //专业方向
            this.mstrListDivMajorDirection = "divMajorDirectionDataLst";
        }
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
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    // 为查询区绑定下拉框
                    //const gvBindDdl = await this.BindDdl4QueryRegion();
                    await (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_BindDdl_MajorDirectionIdByid_XzMajorInDiv_Cache)(this.divName4Function, "ddlMajorDirectionId_SetFldValue", clsPublocalStorage_js_1.clsPublocalStorage.id_XzMajor);
                    (0, clsCommFunc4Ctrl_js_1.SetSpanHtmlByIdInDiv)(this.divName4List, "spnMajorName", clsPublocalStorage_js_1.clsPublocalStorage.majorName);
                    PaperCRUD_js_1.PaperCRUD.sortPaperBy = "updDate Desc";
                    var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                    //判断角色
                    //管理员
                    if (strRoleId == "00620001") {
                        $("#btnDelRecord").show();
                        $("#btnAudit").show();
                        $("#btnSynPaperStatistics").show();
                    }
                    else if (strRoleId == "00620002") {
                        $("#btnDelRecord").hide();
                        $("#btnAudit").show();
                    }
                    else {
                        $("#btnDelRecord").hide();
                        $("#btnAudit").hide();
                        $("#btnCancelSubmit").hide();
                    }
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const objPage = new Paper_QUDI_AllPaper_js_1.Paper_QUDI_AllPaper();
                    await objPage.Page_Load();
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
        //统计核算
        async btnSynPaperStatistics_Click() {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            try {
                $("#divLoading").show();
                const responseText2 = await clsPaperWApiEx_js_1.clsPaperWApiEx.SynPaperStatisticsAsync(strUserId);
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
        async BindDdl4QueryRegion() {
            //绑定编辑文献类型
            const ddl_LiteratureTypeId = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId", new clsLiteratureTypeEN_js_1.clsLiteratureTypeEN);
            //绑定论文类型下拉框
            const ddl_PaperTypeId = await this.BindDdl_gs_PaperType_Cache("ddlPaperTypeId");
            //论文状态
            const ddl_PaperStatusId = await this.BindDdl_gs_PaperStatus_Cache("ddlPaperStatusId");
            //分享
            var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
            await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4List, "ddlShareId");
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
                (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlLiteratureTypeId, arrObjLst_Sel, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
                console.log("完成BindDdl_LiteratureTypeId!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        async BindDdl_gs_PaperType_Cache(ddlgs_PaperTypeId) {
            var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlgs_PaperTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlgs_PaperTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            try {
                var objgs_PaperType_Cond = new clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN();
                var arrObjLst_Sel = await (0, clsgs_PaperTypeWApi_js_1.gs_PaperType_GetSubObjLst_Cache)(objgs_PaperType_Cond);
                (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlgs_PaperTypeId, arrObjLst_Sel, clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN.con_PaperTypeId, clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN.con_PaperTypeName, "论文类型");
                console.log("完成BindDdl_gs_PaperType_Cache!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        async BindDdl_gs_PaperStatus_Cache(ddlgs_PaperStatusId) {
            var strWhereCond = " 1=1 ";
            var objDdl = document.getElementById(ddlgs_PaperStatusId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlgs_PaperStatusId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            try {
                var objgs_PaperStatus_Cond = new clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN();
                var arrObjLst_Sel = await (0, clsgs_PaperStatusWApi_js_1.gs_PaperStatus_GetSubObjLst_Cache)(objgs_PaperStatus_Cond);
                //var arrObjLst_Sel: Array<clsgs_PaperStatusEN> = await gs_PaperStatus_GetObjLstAsync(strWhereCond);
                (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlgs_PaperStatusId, arrObjLst_Sel, clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusId, clsgs_PaperStatusEN_js_1.clsgs_PaperStatusEN.con_PaperStatusName, "论文状态");
                console.log("完成BindDdl_gs_PaperStatus_Cache!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        async CombinevPaperCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            //var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
            var strWhereCond = " 1 = 1 ";
            var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperTitle_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTitle} like '% ${this.paperTitle_q}%'`;
                }
                if (this.updDate_q != "") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_UpdDate} like '% ${this.updDate_q}%'`;
                }
                if (this.literatureTypeId_q != "" && this.literatureTypeId_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId_q}'`;
                }
                //论文类型
                if (this.PaperTypeId_q != "" && this.PaperTypeId_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_PaperTypeId} = '${this.PaperTypeId_q}'`;
                }
                //用户
                if (this.User_q != "" && this.User_q != "0") {
                    strWhereCond += ` And ${clsPaperEN_js_1.clsPaperEN.con_UpdUser} = '${this.User_q}'`;
                }
                //论文维护
                if (strPaperTypeId == "01") {
                    if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                        //判断角色
                        //管理员
                        var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                        var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                        if (strRoleId == "00620001") {
                            //可以查看所有；
                            $("#btnDelRecord").show();
                            $("#btnAudit").show();
                            $("#btnCancelSubmit").show();
                            //strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
                        }
                        else if (strRoleId == "00620002") {
                            $("#btnDelRecord").show();
                            $("#btnAudit").show();
                            $("#btnCancelSubmit").show();
                            //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                            //strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + strUserId + "' And isEffective='1') And isEffective='1')";
                            //strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
                        }
                        else {
                            $("#btnDelRecord").show();
                            $("#btnAudit").hide();
                            $("#btnCancelSubmit").hide();
                            //学生00620003
                            //只能查看自己的数据；或公开的数据；
                            //strWhereCond += ` And ${clsvSubViewpointEN.con_UpdUser} = '${strUserId}'`;
                            strWhereCond += ` And updUser = '${strUserId}'`;
                        }
                    }
                    else {
                        window.top.location.href = "../Web/Login";
                    }
                }
                else {
                    //查看无需做控制；可以看到所有；
                }
                //if (this.IsChecked_q == true) {
                //    strWhereCond += ` And ${clsPaperEN.con_IsChecked} = '1'`;
                //}
                //else {
                //    strWhereCond += ` And ${clsPaperEN.con_IsChecked} = '0'`;
                //}
                //if (this.IsQuotethesis_q == true) {
                //    strWhereCond += ` And ${clsPaperEN.con_IsQuotethesis} = '1'`;
                //}
                //else {
                //    strWhereCond += ` And ${clsPaperEN.con_IsQuotethesis} = '0'`;
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /*
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    */
        async DelRecordByWhere(strWhere) {
            try {
                const returnInt = await (0, clsPaperAttachmentWApi_js_1.PaperAttachment_DelPaperAttachmentsByCondAsync)(strWhere);
                if (returnInt > 0) {
                    //var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
                    ////显示信息框
                    //alert(strInfo);
                    console.log("删除附件成功,共删除" + returnInt + "条记录!");
                }
                else {
                    var strInfo = `删除记录不成功!`;
                    //显示信息框
                    //alert(strInfo);
                }
                console.log("完成DelRecord!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
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
                    //先删除总表数据更新总表
                    var strPaperId = arrKeyIds[i].toString();
                    const responseText5 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strPaperId, "01", "3", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                    var returnBool5 = !!responseText5;
                    if (returnBool5 == true) {
                        console.log("论文数据总表删除成功；");
                    }
                    else {
                        console.log("论文数据总表删除失败；");
                    }
                    if (i == 0)
                        strKeyList = strKeyList + "'" + arrKeyIds[i].toString() + "'";
                    else
                        strKeyList += "," + "'" + arrKeyIds[i].toString() + "'";
                }
                var strWhereCond = " paperId in (" + strKeyList + ")";
                var intqa_QuestionsCount = await (0, clsqa_QuestionsWApi_js_1.qa_Questions_GetRecCountByCondAsync)(strWhereCond);
                if (intqa_QuestionsCount != 0) {
                    alert("请先删除该论文下问题答疑数据！");
                    return "";
                }
                else {
                    var intgs_TagsCount = await (0, clsgs_TagsWApi_js_1.gs_Tags_GetRecCountByCondAsync)(strWhereCond);
                    if (intgs_TagsCount != 0) {
                        alert("请先删除该论文下标注数据！");
                        return "";
                    }
                    else {
                        var intRTPaperCount = await (0, clsRTPaperRelaWApi_js_1.RTPaperRela_GetRecCountByCondAsync)(strWhereCond);
                        if (intRTPaperCount != 0) {
                            alert("请先删除该论文和主题关系数据！");
                            return "";
                        }
                        else {
                            for (var i = 0; i < arrKeyIds.length; i++) {
                                //先删除总表数据更新总表
                                var strPaperId = arrKeyIds[i].toString();
                                const responseText5 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strPaperId, "01", "3", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                                var returnBool5 = !!responseText5;
                                if (returnBool5 == true) {
                                    console.log("论文数据总表删除成功；");
                                }
                                else {
                                    console.log("论文数据总表删除失败；");
                                }
                            }
                            //删除论文附件
                            const responseText1 = await this.DelRecordByWhere(strWhereCond);
                            const responseText2 = await this.DelMultiRecord(arrKeyIds);
                            //刷新缓存
                            (0, clsPaperExWApi_js_1.PaperEx_ReFreshThisCacheById_CurrEduCls)(strid_CurrEducls);
                        }
                    }
                }
                const responseText3 = await this.BindGv_vPaper();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        //论文类型下拉框事件
        ddlPaperTypeChange() {
            //判断下拉框是否有值，且值是否等于
            if (this.paperTypeId != "" && this.paperTypeId != "0") {
                if (this.paperTypeId == "01") {
                    //引用论文
                    $("#ddlPaperStatusId").attr("disabled", true);
                }
                else {
                    //原创论文
                    $("#ddlPaperStatusId").attr("disabled", false);
                }
            }
        }
        //public async GetPaperDataByPaperId() {
        //}
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        async BindGv_vPaper() {
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.CombinevPaperCondition();
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrPaperExObjLst = [];
            try {
                this.recCount = await (0, clsPaperWApi_js_1.Paper_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: PaperCRUD_js_1.PaperCRUD.sortPaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const arrPaperExObjLst = await (0, clsPaperExWApi_js_1.PaperEx_GetObjExLstByPagerAsync)(objPagerPara);
                ////绑定专业论文
                //const gvResultMajor = await this.BindGv_vPaperMajor();
                ////绑定方向论文
                //const gvResultDirection = await this.BindGv_vPaperDirection();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrPaperExObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //console.error(strMsg);
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
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
        async BindTab_vPaper(divContainer, arrPaperExObjLst) {
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
                    text: "", tdClass: "text-left",
                    sortBy: "paperTitle", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "paperTitle",
                //    colHeader: "论文标题",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: (strKeyId: string, strText: string) => {
                //        var a1: HTMLElement = document.createElement("Label");
                //        a1.innerText = strText;
                //        a1.className = "btn btn-outline-info";
                //        a1.setAttribute("onclick", `btnDetailRecordInTab_Click('${strKeyId}');`);
                //        return a1;
                //    }
                //},
                {
                    fldName: "periodical",
                    colHeader: "期刊",
                    text: "", tdClass: "text-left",
                    sortBy: "periodical", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "author",
                    colHeader: "作者",
                    text: "", tdClass: "text-left",
                    sortBy: "author", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
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
                {
                    fldName: "keyword",
                    colHeader: "关键字",
                    text: "", tdClass: "text-left",
                    sortBy: "keyword", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "literatureSources",
                    colHeader: "文献来源",
                    text: "", tdClass: "text-left",
                    sortBy: "literatureSources", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "literatureLink",
                //    colHeader: "文献链接",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "uploadfileUrl",
                //    colHeader: "文件地址",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                //{
                //    fldName: "checker",
                //    colHeader: "审核人",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "isSubmit",
                    colHeader: "是否提交",
                    text: "", tdClass: "text-left",
                    sortBy: "isSubmit", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "isChecked",
                    colHeader: "是否审核",
                    text: "", tdClass: "text-left",
                    sortBy: "isChecked", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                //{
                //    fldName: "isQuotethesis",
                //    colHeader: "是否引用论文",
                //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
                //    columnType: "Label",
                //    orderNum: 1,
                //    funcName: () => { }
                //},
                {
                    fldName: "updDate",
                    colHeader: "提交日期",
                    text: "", tdClass: "text-left",
                    sortBy: "updDate", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "userName",
                    colHeader: "提交用户",
                    text: "", tdClass: "text-left",
                    sortBy: "userName", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "pcount",
                    colHeader: "读写数",
                    text: "", tdClass: "text-left",
                    sortBy: "pcount", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "attachmentCount",
                    colHeader: "附件数",
                    text: "", tdClass: "text-left",
                    sortBy: "attachmentCount", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "详情",
                    text: "详情", tdClass: "text-left",
                    sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDetailRecordInTab_Click("${strKeyId}");`);
                        return btn1;
                    }
                },
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
            (0, clsCommFunc4Web_js_1.BindTab)(o, arrPaperExObjLst, arrDataColumn, "paperId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /*
      * 修改用户Id
     */
        set updUser(value) {
            $("#hidUserId").val(value);
        }
        /*
        * 修改用户Id
       */
        get updUser() {
            return clsPublocalStorage_js_1.clsPublocalStorage.userId;
        }
        /*
        * 主题内容
       */
        // public set paperContent(value: string) {
        //     $("#txtPaperContent").html(value);
        // }
        // /*
        // * 主题内容
        //*/
        // public get paperContent(): string {
        //     var editors = textboxio.get('#txtPaperContent');
        //     var editor = editors[0];
        //     return editor.content.get();
        //     return $("#txtPaperContent").html();
        // }
        //绑定本专业
        async BindGv_vPaperMajor() {
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.CombinevPaperCondition();
            //通过登录的用户得到用户专业
            var strid_XzMajor = clsPublocalStorage_js_1.clsPublocalStorage.id_XzMajor;
            //strWhereCond += ` and paperId in (select paperId from vMajorDirectionPaperRela where id_XzMajor= '${strid_XzMajor}')`;
            strWhereCond += " and  id_XzMajor= '" + strid_XzMajor + "'";
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrPaperExObjLst = [];
            try {
                this.recCount = await (0, clsPaperWApi_js_1.Paper_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: 20,
                    whereCond: strWhereCond,
                    orderBy: PaperCRUD_js_1.PaperCRUD.sortPaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const arrPaperExObjLst = await (0, clsPaperExWApi_js_1.PaperEx_GetObjExLstByPagerAsync)(objPagerPara);
                ////绑定方向论文
                //const gvResultDirection = await this.BindGv_vPaperDirection();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrPaperExObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //console.error(strMsg);
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
                console.log("完成BindGv_vPaperMajor!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //绑定本方向
        async BindGv_vPaperDirection() {
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.CombinevPaperCondition();
            //通过登录的用户得到用户专业
            var strid_XzMajor = clsPublocalStorage_js_1.clsPublocalStorage.id_XzMajor;
            strWhereCond += ` and paperId in (select paperId from vMajorDirectionPaperRela where majorDirectionId in (select majorDirectionId from XzMajorDirection where id_XzMajor= '${strid_XzMajor}'))`;
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrPaperExObjLst = [];
            try {
                this.recCount = await (0, clsPaperWApi_js_1.Paper_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: 20,
                    whereCond: strWhereCond,
                    orderBy: PaperCRUD_js_1.PaperCRUD.sortPaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const arrPaperExObjLst = await (0, clsPaperExWApi_js_1.PaperEx_GetObjExLstByPagerAsync)(objPagerPara);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrPaperExObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //console.error(strMsg);
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_vPaper(strListDiv, arrPaperExObjLst);
                console.log("完成BindGv_vPaperDirection!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //public async btnMajorDirection_Click() {
        //    const responseObjList = await this.BindGv_vXzMajorDirection();
        //}
        //  /* 根据条件获取相应的记录对象的列表
        // (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
        //*/
        //  public async btnQueryMajorDirection_Click() {
        //      var strWhereCond = await this.CombinevXzMajorDirectionCondition();
        //      try {
        //          this.recCount = await vXzMajorDirection_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //          });
        //          var objPagerPara: stuPagerPara = {
        //              pageIndex: 1,
        //              pageSize: this.pageSize,
        //              whereCond: strWhereCond,
        //              orderBy: this.hidSortvXzMajorDirectionBy
        //          };
        //          const responseObjLst = await vXzMajorDirection_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //              var arrvXzMajorDirectionObjLst: Array<clsvXzMajorDirectionEN> = <Array<clsvXzMajorDirectionEN>>jsonData;
        //              this.BindTab_vXzMajorDirection(this.mstrListDivMajorDirection, arrvXzMajorDirectionObjLst);
        //          });
        //      }
        //      catch (e) {
        //          console.error('catch(e)=');
        //          console.error(e);
        //          var strMsg: string = `获取记录列表不成功,${e}.`;
        //          alert(strMsg);
        //      }
        //  }
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        //public async BindGv_vXzMajorDirection() {
        //    var strListDiv: string = this.mstrListDivMajorDirection;
        //    var strWhereCond = await this.CombinevXzMajorDirectionCondition();
        //    var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        //    var arrvXzMajorDirectionObjLst: Array<clsvXzMajorDirectionEN> = [];
        //    try {
        //        this.recCount = await vXzMajorDirection_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //        });
        //        var objPagerPara: stuPagerPara = {
        //            pageIndex: intCurrPageIndex,
        //            pageSize: this.pageSize,
        //            whereCond: strWhereCond,
        //            orderBy: this.hidSortvXzMajorDirectionBy
        //        };
        //        const responseObjLst = await vXzMajorDirection_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //            arrvXzMajorDirectionObjLst = <Array<clsvXzMajorDirectionEN>>jsonData;
        //        });
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //    try {
        //        this.BindTab_vXzMajorDirection(strListDiv, arrvXzMajorDirectionObjLst);
        //        console.log("完成BindGv_vXzMajorDirection!");
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //        alert(strMsg);
        //    }
        //}
        //    /* 把所有的查询控件内容组合成一个条件串
        //(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        // <returns>条件串(strWhereCond)</returns>
        //*/
        //    public CombinevXzMajorDirectionCondition(): string {
        //        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //        //例如 1 = 1 && userName = '张三'
        //        var strPaperId = $("#hidPaperId").val();//论文
        //        var strWhereCond: string = " 1 = 1 ";
        //        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        //        try {
        //            if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
        //                strWhereCond += ` And ${clsvXzMajorDirectionEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
        //            }
        //            if (this.majorDirectionName_q != "") {
        //                strWhereCond += ` And ${clsvXzMajorDirectionEN.con_MajorDirectionName} like '% ${this.majorDirectionName_q}%'`;
        //            }
        //            strWhereCond += ` And  majorDirectionId not in (select majorDirectionId from MajorDirectionPaperRela where  paperId = '${strPaperId}')`;
        //        }
        //        catch (objException) {
        //            var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineXzMajorDirectionCondition)时出错!请联系管理员!${objException}`;
        //            throw strMsg;
        //        }
        //        return strWhereCond;
        //    }
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
                    fldName: "updUser",
                    colHeader: "修改人",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "",
                    colHeader: "确定",
                    text: "确定", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Button",
                    orderNum: 1,
                    funcName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnOkInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
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
        ///* 函数功能:在数据 列表中跳转到某一页
        //   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
        //   <param name = "intPageIndex">页序号</param>
        // */
        //public IndexPageOne(intPageIndex) {
        //    if (intPageIndex == 0) {
        //        intPageIndex = this.objPager.pageCount;
        //    }
        //    console.log("跳转到" + intPageIndex + "页");
        //    this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        //    this.BindGv_vXzMajorDirection();
        //}
        //论文提交
        async btnIsSubmit_Click(strKeyId) {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            try {
                this.IsSubmitRecordSave(strKeyId);
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
        async IsSubmitRecordSave(strKeyId) {
            const strThisFuncName = this.IsSubmitRecordSave.name;
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            //
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            objPaperEN.SetPaperId(strKeyId);
            objPaperEN.SetIsSubmit(true);
            objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN).then((jsonData) => {
                    var returnBool = jsonData;
                    if (returnBool == true) {
                        var strInfo = `提交成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        //刷新缓存
                        (0, clsPaperExWApi_js_1.PaperEx_ReFreshThisCacheById_CurrEduCls)(strid_CurrEducls);
                        HideDialog();
                        this.BindGv_vPaper();
                    }
                    else {
                        var strInfo = `提交不成功!`;
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
                var strMsg = `提交不成功,${e}.`;
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
            var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            objPaperEN.SetPaperId(strKeyId);
            objPaperEN.SetIsSubmit(false);
            objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN).then((jsonData) => {
                    var returnBool = jsonData;
                    if (returnBool == true) {
                        var strInfo = `取消成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        //刷新缓存
                        (0, clsPaperExWApi_js_1.PaperEx_ReFreshThisCacheById_CurrEduCls)(strid_CurrEducls);
                        HideDialog();
                        this.BindGv_vPaper();
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
       * 设置排序字段-相当使用ViewState功能
      */
        set hidSortvXzMajorDirectionBy(value) {
            $("#hidSortvXzMajorDirectionBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvXzMajorDirectionBy() {
            return $("#hidSortvXzMajorDirectionBy").val();
        }
        /*
      * 设置上传文件
      */
        set Uploadfile(value) {
            $("#txtUploadfile").val(value);
        }
        /*
        * 获取上传文件
        */
        get Uploadfile() {
            return $("#txtUploadfile").val();
        }
        /*
     * 论文类型查询
     */
        set PaperTypeId_q(value) {
            $("#ddlPaperTypeId_q").val(value);
        }
        /*
        * 论文类型查询
        */
        get PaperTypeId_q() {
            return $("#ddlPaperTypeId_q").val();
        }
        /*
         * 论文类型
         */
        set paperTypeId(value) {
            $("#ddlPaperTypeId").val(value);
        }
        /*
        * 论文类型
        */
        get paperTypeId() {
            return $("#ddlPaperTypeId").val();
        }
        /*
     * 论文状态
     */
        set paperStatusId(value) {
            $("#ddlPaperStatusId").val(value);
        }
        /*
        * 论文状态
        */
        get paperStatusId() {
            return $("#ddlPaperStatusId").val();
        }
        /*
       * 专业流水号
      */
        get id_XzMajor_q() {
            return $("#ddlid_XzMajor_q").val();
        }
        /*
        * 研究方向名
       */
        get majorDirectionName_q() {
            return $("#txtMajorDirectionName_q").val();
        }
        /*
    * 用户
    */
        //public get readUser_q(): string {
        //    return $("#txtReadUser_q").val();
        //}
        get User_q() {
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
        BindGv(strType, strPara) {
            this.BindGv_vPaper();
            layui_Alert(1, "已关注！");
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "vPaper":
                    //alert('该类没有绑定该函数：[this.BindGv_vPaper_Cache]！');
                    this.BindGv_vPaper();
                    layui_Alert(1, "已关注！");
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
            let objPage = new Paper_QUDIEx();
            //if (PaperCRUD.objPage_CRUD == null) {
            //    PaperCRUD.objPage_CRUD = new Paper_QUDIEx();
            //    objPage = <Paper_QUDIEx>PaperCRUD.objPage_CRUD;
            //}
            //else {
            //    objPage = <Paper_QUDIEx>PaperCRUD.objPage_CRUD;
            //}
            const objPage_Edit = new Paper_EditEx_js_1.Paper_EditEx(objPage);
            let strMsg = '';
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage.divName4DataList);
            switch (strCommandName) {
                case "SetCurrMajorDirection": //查询记录
                    objPage.btnSetCurrMajorDirection_Click();
                    break;
                case "SetCurrEduCls": //查询记录
                    objPage.btnSetCurrEduCls_Click();
                    break;
                //case "SetCurrMajor":    //查询记录
                //    objPage.btnSetCurrMajor_Click();
                //    break;
                case "MajorDirection": //查询记录
                    objPage.liMajorDirection_Click();
                    break;
                case "CurrEduCls": //查询记录
                    objPage.liCurrEduCls_Click();
                    break;
                case "AllPaper": //查询记录
                    objPage.liAllPaper_Click();
                    break;
                case "Major": //查询记录
                    objPage.liMajor_Click();
                    break;
                //case "AddCollection":    //查询记录
                //    objPage.btnAddCollection_Click(strKeyId);
                //    break;
                //case "AddVote":    //查询记录
                //    objPage.btnAddVote_Click(strKeyId);
                //    break;
                //case "AddAttention":    //查询记录
                //    objPage.btnAddAttention_Click(objPage, strKeyId);
                //    break;
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
                    strMsg = '命令:' + strCommandName + "在函数(PaperCRUDExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
        **/
        async btnQuery_Click() {
            const strThisFuncName = this.btnQuery_Click.name;
            this.SetCurrPageIndex(1);
            let objPage_Sub;
            switch (Paper_QUDIEx.CurrTabName) {
                case "AllPaper":
                    objPage_Sub = new Paper_QUDI_AllPaper_js_1.Paper_QUDI_AllPaper();
                    await objPage_Sub.Page_Load();
                    break;
                case "CurrEduCls":
                    objPage_Sub = new Paper_QUDI_CurrEduCls_js_1.Paper_QUDI_CurrEduCls();
                    await objPage_Sub.Page_Load();
                    break;
                case "Major":
                    objPage_Sub = new Paper_QUDI_Major_js_1.Paper_QUDI_Major();
                    await objPage_Sub.Page_Load();
                    break;
                case "Direction":
                    objPage_Sub = new Paper_QUDI_Direction_js_1.Paper_QUDI_Direction();
                    await objPage_Sub.Page_Load();
                    break;
                default:
                    const strMsg = '当前Tab:' + Paper_QUDIEx.CurrTabName + `在函数(${strThisFuncName})中没有被处理！`;
                    alert(strMsg);
                    break;
            }
            //    const responseBindGv = await this.BindGv_vPaper();
        }
        /* 所有论文
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
      */
        async liAllPaper_Click() {
            try {
                Paper_QUDIEx.CurrTabName = "AllPaper";
                const objPage = new Paper_QUDI_AllPaper_js_1.Paper_QUDI_AllPaper();
                await objPage.Page_Load();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 所有论文
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
     */
        async liCurrEduCls_Click() {
            try {
                Paper_QUDIEx.CurrTabName = "CurrEduCls";
                const objPage = new Paper_QUDI_CurrEduCls_js_1.Paper_QUDI_CurrEduCls();
                await objPage.Page_Load();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 本专业
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
      */
        async liMajor_Click() {
            try {
                Paper_QUDIEx.CurrTabName = "Major";
                //绑定专业论文
                const objPage = new Paper_QUDI_Major_js_1.Paper_QUDI_Major();
                objPage.Page_Load();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 本专业方向
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
      */
        async liMajorDirection_Click() {
            try {
                Paper_QUDIEx.CurrTabName = "Direction";
                //绑定方向论文
                const objPage = new Paper_QUDI_Direction_js_1.Paper_QUDI_Direction();
                objPage.Page_Load();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /** 函数功能:从界面列表中根据某一个字段排序
     * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
     * @param objAnchorElement:带有排序字段的Anchors
     **/
        async SortBy(objAnchorElement) {
            const strThisFuncName = this.SortBy.name;
            console.log("objAnchorElement(In SetAllCkechedKeysV2):", objAnchorElement);
            let strSortExpress = "";
            //event = window.event || event;
            if (typeof (objAnchorElement) != "function") {
                const thisEventObj = objAnchorElement;
                strSortExpress = thisEventObj.getAttribute("FldName");
            }
            const { sortFun, ascOrDesc4SortFun, sortBy } = (0, clsOperateList_js_1.GetSortBy)(objAnchorElement, PaperCRUD_js_1.PaperCRUD.ascOrDesc4SortFun, PaperCRUD_js_1.PaperCRUD.sortPaperBy, strSortExpress);
            PaperCRUD_js_1.PaperCRUD.sortPaperBy = sortBy;
            PaperCRUD_js_1.PaperCRUD.ascOrDesc4SortFun = ascOrDesc4SortFun;
            PaperCRUD_js_1.PaperCRUD.sortFun_Static = sortFun;
            await this.btnQuery_Click();
        }
        /* 所有论文
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
     */
        async btnSetCurrEduCls_Click() {
            const strThisFuncName = this.btnSetCurrEduCls_Click.name;
            try {
                var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                let arrKeyIds;
                let objPage_Sub;
                switch (Paper_QUDIEx.CurrTabName) {
                    case "AllPaper":
                        objPage_Sub = new Paper_QUDI_AllPaper_js_1.Paper_QUDI_AllPaper();
                        arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage_Sub.divName4DataList);
                        break;
                    case "CurrEduCls":
                        objPage_Sub = new Paper_QUDI_CurrEduCls_js_1.Paper_QUDI_CurrEduCls();
                        arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage_Sub.divName4DataList);
                        break;
                    case "Major":
                        objPage_Sub = new Paper_QUDI_Major_js_1.Paper_QUDI_Major();
                        arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage_Sub.divName4DataList);
                        break;
                    case "Direction":
                        objPage_Sub = new Paper_QUDI_Direction_js_1.Paper_QUDI_Direction();
                        arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage_Sub.divName4DataList);
                        break;
                    default:
                        const strMsg = '当前Tab:' + Paper_QUDIEx.CurrTabName + `在函数(${strThisFuncName})中没有被处理！`;
                        alert(strMsg);
                        break;
                }
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                await (0, clsPaperEduClsRelaExWApi_js_1.PaperEduClsRelaEx_SetId_CurrEduCls)(arrKeyIds, strid_CurrEducls);
                Paper_QUDIEx.CurrTabName = "CurrEduCls";
                const objPage = new Paper_QUDI_CurrEduCls_js_1.Paper_QUDI_CurrEduCls();
                await objPage.Page_Load();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `设置当前教学班不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 所有论文
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
     */
        async btnSetCurrMajorDirection_Click() {
            const strThisFuncName = this.btnSetCurrEduCls_Click.name;
            try {
                const strMajorDirectionId = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Function, "ddlMajorDirectionId_SetFldValue");
                if (strMajorDirectionId == "") {
                    const strMsg = "请输入研究方向Id(MajorDirectionId)!";
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                let arrKeyIds;
                let objPage_Sub;
                switch (Paper_QUDIEx.CurrTabName) {
                    case "AllPaper":
                        objPage_Sub = new Paper_QUDI_AllPaper_js_1.Paper_QUDI_AllPaper();
                        arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage_Sub.divName4DataList);
                        break;
                    case "CurrEduCls":
                        objPage_Sub = new Paper_QUDI_CurrEduCls_js_1.Paper_QUDI_CurrEduCls();
                        arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage_Sub.divName4DataList);
                        break;
                    case "Major":
                        objPage_Sub = new Paper_QUDI_Major_js_1.Paper_QUDI_Major();
                        arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage_Sub.divName4DataList);
                        break;
                    case "Direction":
                        objPage_Sub = new Paper_QUDI_Direction_js_1.Paper_QUDI_Direction();
                        arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(objPage_Sub.divName4DataList);
                        break;
                    default:
                        const strMsg = '当前Tab:' + Paper_QUDIEx.CurrTabName + `在函数(${strThisFuncName})中没有被处理！`;
                        alert(strMsg);
                        break;
                }
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                await (0, clsMajorDirectionPaperRelaExWApi_js_1.MajorDirectionPaperRelaEx_SetMajorDirectionId)(arrKeyIds, strMajorDirectionId);
                Paper_QUDIEx.CurrTabName = "Direction";
                const objPage = new Paper_QUDI_Direction_js_1.Paper_QUDI_Direction();
                await objPage.Page_Load();
                //const objPage2 = new Paper_QUDI_Major();
                //await objPage2.Page_Load();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `设置当前专业研究方向不成功,${e}.`;
                alert(strMsg);
            }
        }
        /** 函数功能:系统生成的Change事件函数
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript+<>c__DisplayClass13_0:<Gen_WApi_Ts_GeneEventFuncEx>b__1)
    */
        async ddlMajorDirectionId_Tabs_SelectedIndexChanged(ddlMajorDirectionId_Tabs) {
            const strThisFuncName = this.ddlMajorDirectionId_Tabs_SelectedIndexChanged.name;
            const strMajorDirectionId = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4List, "ddlMajorDirectionId_Tabs");
            if ((0, clsString_js_1.IsNullOrEmpty)(strMajorDirectionId) == true)
                return;
            clsPublocalStorage_js_1.clsPublocalStorage.majorDirectionId = strMajorDirectionId;
            const objXzMajorDirection = await (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_GetObjByMajorDirectionId_Cache)(strMajorDirectionId, clsPublocalStorage_js_1.clsPublocalStorage.id_XzMajor);
            if (objXzMajorDirection == null) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            clsPublocalStorage_js_1.clsPublocalStorage.majorDirectionName = objXzMajorDirection.majorDirectionName;
            const strMajorDirectionName = (0, clsString_js_1.Format)("<span class='text-secondary font-weight-bold'>[{0}]</span>方向论文", objXzMajorDirection.majorDirectionName);
            $("#aMajorDirectionName").html(strMajorDirectionName);
            const objPage = new Paper_QUDI_Direction_js_1.Paper_QUDI_Direction();
            await objPage.Page_Load();
        }
    }
    exports.Paper_QUDIEx = Paper_QUDIEx;
    //public static mstrListDiv: string = "divDataLst";
    //public static mstrsortPaperBy: string = "paperId";
    Paper_QUDIEx.CurrTabName = "AllPaper";
});
