(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPubSessionStorage.js", "../GraduateEduPublicPage/Public_SysSocialRelations.js", "../GraduateEduTopic/SysSocialRelationsCRUDEx.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsgs_PSocialRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js", "../TS/L0_Entity/ParameterTable/clsSysSecurityLevelEN.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString2.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PSocialRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js", "../TS/L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PSocialRela = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:SysSocialRelationsCRUDEx
    表名:SysSocialRelations(01120644)
    生成代码版本:2020.05.18.1
    生成日期:2020/05/22 19:00:05
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:研究生培养
    模块英文名:GraduateEdu
    框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    //import { SysSocialRelationsCRUD } from "./SysSocialRelationsCRUD.js";
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const Public_SysSocialRelations_js_1 = require("../GraduateEduPublicPage/Public_SysSocialRelations.js");
    const SysSocialRelationsCRUDEx_js_1 = require("../GraduateEduTopic/SysSocialRelationsCRUDEx.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsgs_OriginalPaperLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js");
    const clsgs_PSocialRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_PSocialRelaEN.js");
    const clsSysSocialRelationsEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js");
    const clsvSysSocialRelationsEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js");
    const clsSysSecurityLevelEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSysSecurityLevelEN.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    const clsgs_OriginalPaperLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js");
    const clsgs_PSocialRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_PSocialRelaWApi.js");
    const clsvSysSocialRelationsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js");
    const clsSysSecurityLevelWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js");
    const clsSysSocialRelationsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js");
    /* SysSocialRelationsCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class gs_PSocialRela extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //记录是否导入编辑区的变量
            this.RecCount = 0;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            var objPage = new SysSocialRelationsCRUDEx_js_1.SysSocialRelationsCRUDEx();
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    ShowDialog('AddWithMaxId');
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    ShowDialog('AddWithMaxId');
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
                    if (strKeyId == "") {
                        alert("请选择需要修改的记录！");
                        return;
                    }
                    objPage.btnUpdateRecord_Click(strKeyId);
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
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
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
                    var strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
                case "ExportExcel": //导出Excel
                    alert("导出Excel功能还没有开通！");
                    break;
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
    */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
                    //建立缓存
                    // 为查询区绑定下拉框
                    const gvBindDdl = await this.BindDdl4QueryRegion();
                    this.hidSortvSysSocialRelationsBy = "fullName Asc";
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vSysSocialRelations();
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
        /* 函数功能:为查询区绑定下拉框
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Js_BindDdl4QueryRegion)
      */
        async BindDdl4QueryRegion() {
            // 在此处放置用户代码以初始化页面
            var objSysSecurityLevel_Cond = new clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN(); //查询区域
            const ddlLevelId_q = await (0, clsSysSecurityLevelWApi_js_1.SysSecurityLevel_BindDdl_LevelIdInDiv_Cache)(this.divName4List, "ddlLevelId_q"); //查询区域
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vSysSocialRelations() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevSysSocialRelationsCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvSysSocialRelationsObjLst = [];
            try {
                const responseRecCount = await (0, clsvSysSocialRelationsWApi_js_1.vSysSocialRelations_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvSysSocialRelationsBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvSysSocialRelationsWApi_js_1.vSysSocialRelations_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvSysSocialRelationsObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvSysSocialRelationsObjLst.length == 0) {
            //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                //this.BindTab_vSysSkill(strListDiv, arrvSysSkillObjLst);
                //var strhtml = "";
                ////个人观点
                //strhtml += '<div class="info" id="infoConcept"><div class="title btn-4">';
                //strhtml += '<div><a href="#" title="当前相关社会关系">当前相关社会关系</a></div>';
                ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加相关概念" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加相关概念</button></div>';
                //strhtml += '</div><ul class="artlist">';
                //var v = 0;//给内容加个序号
                //for (var i = 0; i < arrvSysSocialRelationsObjLst.length; i++) {
                //    //得到socialId；
                //    var strSocialId = arrvSysSocialRelationsObjLst[i].socialId;
                //    v++;
                //    strhtml += '<li><span class="rowtit color4">' + v + '.[姓名]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].fullName + '</span>';
                //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[国籍]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].nationality + '</span>';
                //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[工作单位]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].workUnit + '</span>';
                //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[专业]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].major + '</span></li>';
                //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[成就]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].achievement + '</span></li>';
                //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[详细说明]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].detailedDescription + '</span></li>';
                //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + arrvSysSocialRelationsObjLst[i].updUser;
                //    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvSysSocialRelationsObjLst[i].updDate;
                //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';
                //    //引用数
                //    strhtml += '&nbsp;&nbsp;被引用数:' + arrvSysSocialRelationsObjLst[i].citationCount;
                //    strhtml += '&nbsp;&nbsp;<button title="引用相关关系" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkgs_PSocialRelaInTab_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '")> <i class="layui-icon" >&#xe642;</i>引用该相关关系</button>';
                //    strhtml += '</li>';
                //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                //}
                //strhtml += '</ul></div>';
                var strHtml = await Public_SysSocialRelations_js_1.Public_SysSocialRelations.BindList_vSysSocialRelations("02", arrvSysSocialRelationsObjLst);
                //拼接；
                $("#divSysSocialDataLst").html(strHtml);
                if (arrvSysSocialRelationsObjLst.length > 10) {
                    //$("#divPagerSysSocialRela").show();
                    this.objPager.RecCount = this.RecCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
                console.log("完成BindGv_vSysSocialRelations!");
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
        CombinevSysSocialRelationsCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strPaperId = $('#hidPaperId').val();
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "'";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //只能查询提交的技能数据
                strWhereCond += ` And ${clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_IsSubmit} = 'true'`;
                var strPageType = $("#hidPageType").val();
                if (strPageType == "gs_TDR") {
                    if ($("#txtViewpointName_q").val() != "") {
                        strWhereCond += ` And ${clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_FullName} like '% ${$("#txtViewpointName_q").val()}%'`;
                    }
                    if ($("#txtViewUpdName_q").val() != "") {
                        strWhereCond += ` And ${clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_UpdUser} like '% ${$("#txtViewUpdName_q").val()}%'`;
                    }
                    //strWhereCond += ` And socialId not in (select socialId from RTSysSocialRela where paperId = '${strPaperId}' And updUser = '${strUserId}')`;
                }
                else {
                    if (this.FullName_q != "") {
                        strWhereCond += ` And ${clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_FullName} like '% ${this.FullName_q}%'`;
                    }
                    if (this.LevelId_q != "" && this.LevelId_q != "0") {
                        strWhereCond += ` And ${clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_LevelId} = '${this.LevelId_q}'`;
                    }
                    //排除获取已存在的关系数据 根据当前用户；
                    strWhereCond += ` And socialId not in (select socialId from gs_PSocialRela where paperId = '${strPaperId}' And updUser = '${strUserId}')`;
                }
                //var strUserId = clsPubSessionStorage.GetSession_UserId();
                //var strRoleId = clsPubSessionStorage.GetSession_RoleId();
                //$("#hidUserId").val(strUserId);
                ////判断角色 
                ////管理员
                //if (strRoleId == "00620001") {
                //    $("#btnDelRecord").show();
                //    $("#btnCancelSubmit").show();
                //}
                //else if (strRoleId == "00620002") {
                //    //教师
                //    $("#btnDelRecord").hide();
                //    $("#btnCancelSubmit").show();
                //}
                //else {
                //    //学生 教师；
                //    $("#btnDelRecord").hide();
                //    $("#btnCancelSubmit").hide();
                //    //学生00620003 00620002教师
                //    strWhereCond += ` And ${clsvSysSocialRelationsEN.con_UpdUser} = '${strUserId}'`;
                //    //strWhereCond += ` And ${clsvViewpointEN.con_VPProposePeople} = '${objvUserRoleRelation.userId}'`;
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysSocialRelationsCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 显示vSysSocialRelations对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrSysSocialRelationsObjLst">需要绑定的对象列表</param>
    */
        BindTab_vSysSocialRelations(divContainer, arrvSysSocialRelationsObjLst) {
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
                    FldName: "fullName",
                    ColHeader: "姓名",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "nationality",
                    ColHeader: "国籍",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "workUnit",
                    ColHeader: "工作单位",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "major",
                    ColHeader: "专业",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "achievement",
                    ColHeader: "成就",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "detailedDescription",
                    ColHeader: "详细说明",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "levelName",
                    ColHeader: "级别名称",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    ColHeader: "修改人",
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
                    FldName: "isSubmit",
                    ColHeader: "是否提交",
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
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvSysSocialRelationsObjLst, arrDataColumn, "socialId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjSysSocialRelationsEN">数据传输的目的类对象</param>
    */
        PutDataToSysSocialRelationsClass(pobjSysSocialRelationsEN) {
            pobjSysSocialRelationsEN.socialId = this.socialId; // 社会Id
            pobjSysSocialRelationsEN.fullName = this.fullName; // 姓名
            pobjSysSocialRelationsEN.nationality = this.nationality; // 国籍
            pobjSysSocialRelationsEN.levelId = this.levelId; // 级别Id
            pobjSysSocialRelationsEN.workUnit = this.workUnit; // 工作单位
            pobjSysSocialRelationsEN.major = this.major; // 专业
            pobjSysSocialRelationsEN.achievement = this.achievement; // 成就
            pobjSysSocialRelationsEN.detailedDescription = this.detailedDescription; // 详细说明
            pobjSysSocialRelationsEN.updUser = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId(); // 修改人
            pobjSysSocialRelationsEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjSysSocialRelationsEN.id_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            pobjSysSocialRelationsEN.isSubmit = this.isSubmit; // 是否提交
            pobjSysSocialRelationsEN.memo = this.memo; // 备注
        }
        //概念提交审核
        async btnIsSubmit_Click(strKeyId) {
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            this.SubmitRecord(strKeyId);
        }
        //提交判断；
        async SubmitRecord(strSocialId) {
            this.KeyId = strSocialId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsSysSocialRelationsWApi_js_1.SysSocialRelations_GetObjBySocialIdAsync)(strSocialId).then((jsonData) => {
                        var objSysSocialRelationsEN = jsonData;
                        //通过session 权限获取权限
                        var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                        var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                        //判断角色 //学生00620003
                        if (strRoleId == "00620003") {
                            // //通过判断数据用户是否是当前登录用户；
                            if (objSysSocialRelationsEN.updUser == strUserId) {
                                //判断数据是否已审核
                                if (objSysSocialRelationsEN.isSubmit == false) {
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
                            if (objSysSocialRelationsEN.isSubmit == false) {
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
            var objSysSocialRelationsEN = new clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN();
            objSysSocialRelationsEN.socialId = this.KeyId;
            objSysSocialRelationsEN.isSubmit = true;
            objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
                throw "关键字不能为空!";
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsSysSocialRelationsWApi_js_1.SysSocialRelations_UpdateRecordAsync)(objSysSocialRelationsEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            var strInfo = `提交成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            HideDialog();
                            this.BindGv_vSysSocialRelations(); // BindGv_vSysSkill_Cache();
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
        //取消提交
        async btnCancelSubmit_Click(strKeyId) {
            var strUserId = $("#hidUserId").val();
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
        /*取消
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
     */
        async CancelSubmitRecordSave(strKeyId) {
            //this.DivName = "divUpdateRecordSave";
            var objSysSocialRelationsEN = new clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN();
            objSysSocialRelationsEN.socialId = strKeyId;
            objSysSocialRelationsEN.isSubmit = false;
            objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = (0, clsSysSocialRelationsWApi_js_1.SysSocialRelations_UpdateRecordAsync)(objSysSocialRelationsEN).then((jsonData) => {
                    var returnBool = jsonData;
                    if (returnBool == true) {
                        var strInfo = `取消成功!`;
                        $('#lblResult44').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                        //HideDialog();
                        this.BindGv_vSysSocialRelations();
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
                            if (this.OpType == "AddWithMaxId") {
                                const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                                    var returnBool2 = jsonData;
                                    if (returnBool2 == true) {
                                        HideDialog();
                                        this.BindGv_vSysSocialRelations();
                                    }
                                });
                            }
                            else {
                                const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                    var returnBool = jsonData;
                                    if (returnBool == true) {
                                        HideDialog();
                                        this.BindGv_vSysSocialRelations();
                                    }
                                });
                            }
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                                strInfo += "(In SysSocialRelationsCRUD.btnOKUpd_Click)";
                                $('#lblResult51').val(strInfo);
                                //显示信息框
                                console.log(strInfo);
                                alert(strInfo);
                                if (returnBool == true) {
                                    HideDialog();
                                    this.BindGv_vSysSocialRelations();
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
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
       */
        async AddNewRecordWithMaxIdSave() {
            this.DivName = "divAddNewRecordWithMaxIdSave";
            var objSysSocialRelationsEN = new clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN();
            this.PutDataToSysSocialRelationsClass(objSysSocialRelationsEN);
            try {
                const responseText2 = await (0, clsSysSocialRelationsWApi_js_1.SysSocialRelations_AddNewRecordWithMaxIdAsync)(objSysSocialRelationsEN);
                var SysSocialId = responseText2;
                if (clsString2_js_1.clsString.IsNullOrEmpty(responseText2) == false) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult47').val(strInfo);
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
        /* 修改记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
       */
        async UpdateRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objSysSocialRelationsEN = new clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN();
            objSysSocialRelationsEN.socialId = this.KeyId;
            this.PutDataToSysSocialRelationsClass(objSysSocialRelationsEN);
            objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = await (0, clsSysSocialRelationsWApi_js_1.SysSocialRelations_UpdateRecordAsync)(objSysSocialRelationsEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                }
                return returnBool;
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `修改记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        }
        /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
    */
        async AddNewRecord() {
            this.SetKeyReadOnly(false);
            $('#btnOKUpd').attr("disabled", false);
            this.OpType = "AddWithMaxId";
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucSysSocialRelationsB1.socialId = clsSysSocialRelationsBL.GetMaxStrId_S();
            try {
                const responseText = await (0, clsSysSocialRelationsWApi_js_1.SysSocialRelations_GetMaxStrIdAsync)();
                var returnString = responseText;
                if (returnString == "") {
                    var strInfo = `获取表SysSocialRelations的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtSocialId').val(returnString);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            this.SetKeyReadOnly(false);
            $('#btnOKUpd').attr("disabled", false);
            this.OpType = "AddWithMaxId";
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucSysSocialRelationsB1.socialId = clsSysSocialRelationsBL.GetMaxStrId_S();
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
        }
        //添加技能
        async btnAddgs_PSocialRelaInTab_Click() {
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();
            const responseObjList = await this.BindGv_vSysSocialRelations();
        }
        //确定选择的观点 并添加到关系表中
        btnOkgs_PSocialRelaInTab_Click(strkeyId) {
            //存放Id
            $("#hidSocialId").val(strkeyId);
            //执行添加关系方法
            this.AddNewRecordSave();
        }
        //查询技能
        async btnQuerygs_PSocialRela_Click() {
            const responseObjList = await this.BindGv_vSysSocialRelations();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjgs_PSocialRelaEN">数据传输的目的类对象</param>
    */
        PutDataTogs_PSocialRelaClass(pobjgs_PSocialRelaEN) {
            var strPaperId = $('#hidPaperId').val();
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            var strSocialId = $("#hidSocialId").val();
            pobjgs_PSocialRelaEN.paperId = strPaperId; // 主题编号
            pobjgs_PSocialRelaEN.sectionId = $("#ddlSectionId5").val(); // 论文章节id
            pobjgs_PSocialRelaEN.socialId = strSocialId; // 社会Id
            pobjgs_PSocialRelaEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjgs_PSocialRelaEN.updUser = strUserId; // 修改人
            pobjgs_PSocialRelaEN.memo = this.memo; // 备注
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var strPaperId = $('#hidPaperId').val();
            var strSocialId = $("#hidSocialId").val();
            var strPaperLogTypeId = $('#hidPaperLogTypeId').val(); //流程日志参数
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            var objgs_PSocialRelaEN = new clsgs_PSocialRelaEN_js_1.clsgs_PSocialRelaEN();
            this.PutDataTogs_PSocialRelaClass(objgs_PSocialRelaEN);
            try {
                //同一主题 同一技能 只能添加一次；
                var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And socialId = '" + strSocialId + "'";
                const responseText = await (0, clsgs_PSocialRelaWApi_js_1.gs_PSocialRela_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `同一主题同一个用户不能重复添加同一个关系！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                else {
                    const responseText2 = await (0, clsgs_PSocialRelaWApi_js_1.gs_PSocialRela_AddNewRecordAsync)(objgs_PSocialRelaEN);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        var strInfo = `添加记录成功!`;
                        $('#lblResult46').val(strInfo);
                        //查询 论文、日志类型是否存在；
                        var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And logTypeId = '" + strPaperLogTypeId + "'";
                        const responseText6 = await (0, clsgs_OriginalPaperLogWApi_js_1.gs_OriginalPaperLog_IsExistRecordAsync)(strWhere);
                        var bolIsExist = responseText6;
                        if (bolIsExist == true) {
                            return responseText6; //一定要有一个返回值，否则会出错！
                        }
                        else {
                            //添加论文日志；
                            const responseText7 = await this.Addgs_OriginalPaperLogSave().then((jsonData) => {
                            });
                        }
                        //根据ID获取最大数；
                        var strWhereCond2 = " 1 =1 and socialId=" + strSocialId;
                        var intCitationCount = await (0, clsgs_PSocialRelaWApi_js_1.gs_PSocialRela_GetRecCountByCondAsync)(strWhereCond2);
                        var objSysSocialRelationsEN = new clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN();
                        objSysSocialRelationsEN.socialId = strSocialId;
                        objSysSocialRelationsEN.citationCount = intCitationCount;
                        objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString; //设置哪些字段被修改(脏字段)
                        if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
                            throw "关键字不能为空!";
                        }
                        const responseText = await (0, clsSysSocialRelationsWApi_js_1.SysSocialRelations_UpdateRecordAsync)(objSysSocialRelationsEN).then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                            }
                            else {
                                var strInfo = `操作不成功!`;
                                alert(strInfo);
                                console.log("操作不成功");
                            }
                        });
                        //显示信息框
                        alert(strInfo);
                        HideDialogTen();
                        RefreshWindow();
                    }
                    else {
                        var strInfo = `添加记录不成功!`;
                        $('#lblResult46').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                    }
                }
                return responseText; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
        }
        //添加论文流程日志
        async Addgs_OriginalPaperLogSave() {
            var objgs_OriginalPaperLogEN = new clsgs_OriginalPaperLogEN_js_1.clsgs_OriginalPaperLogEN();
            this.PutDataTogs_OriginalPaperLog(objgs_OriginalPaperLogEN);
            try {
                const responseText2 = await (0, clsgs_OriginalPaperLogWApi_js_1.gs_OriginalPaperLog_AddNewRecordAsync)(objgs_OriginalPaperLogEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    console.log("添加新建论文日志成功");
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加日志记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true;
        }
        async PutDataTogs_OriginalPaperLog(pobjgs_OriginalPaperLogEN) {
            var strPaperId = $("#hidPaperId").val();
            var strPaperLogTypeId = $('#hidPaperLogTypeId').val(); //流程日志参数
            ////通过区分 是小组讨论还是同伴建议
            //var logTypeId = $('#hidCommentTypeId').val();
            pobjgs_OriginalPaperLogEN.paperId = strPaperId;
            pobjgs_OriginalPaperLogEN.logTypeId = strPaperLogTypeId;
            pobjgs_OriginalPaperLogEN.logDescription = "添加子观点";
            //$('#PaperLogTypeId').val("03");
            //switch (strPaperLogTypeId) {
            //    case "01":
            //        pobjgs_OriginalPaperLogEN.logDescription = "添加子观点";
            //        break;
            //    case "02":
            //        pobjgs_OriginalPaperLogEN.logDescription = "同伴建议";
            //        break;
            //    default:
            //        var strMsg = `没有数据处理！`;
            //        alert(strMsg);
            //        break;
            //}
            //pobjgs_OriginalPaperLogEN.logDescription = "新建论文";
            pobjgs_OriginalPaperLogEN.updUser = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            pobjgs_OriginalPaperLogEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate();
        }
        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        SetKeyReadOnly(bolReadonly) {
            $('#txtSocialId').prop['ReadOnly'] = bolReadonly;
        }
        /*
       * 成就
      */
        set achievement(value) {
            $("#txtAchievement").val(value);
        }
        /*
        * 成就
       */
        get achievement() {
            return $("#txtAchievement").val();
        }
        /*
        * 成就
       */
        get Achievement_q() {
            return $("#txtAchievement_q").val();
        }
        /*
        * 设置取消按钮的标题
       */
        set btnCancel(value) {
            $("#btnCancel").html(value);
        }
        /*
        * 设置确定按钮的标题
       */
        set btnOKUpd(value) {
            $("#btnOKUpd").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnOKUpd() {
            return $("#btnOKUpd").html();
        }
        /*
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
        * 获取当前页序号
       */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 详细说明
       */
        set detailedDescription(value) {
            $("#txtDetailedDescription").val(value);
        }
        /*
        * 详细说明
       */
        get detailedDescription() {
            return $("#txtDetailedDescription").val();
        }
        /*
        * 添加、修改用的层名
       */
        set DivName(value) {
            $("#hidDivName").val(value);
        }
        /*
        * 姓名
       */
        set fullName(value) {
            $("#txtFullName").val(value);
        }
        /*
        * 姓名
       */
        get fullName() {
            return $("#txtFullName").val();
        }
        /*
        * 姓名
       */
        get FullName_q() {
            return $("#txtFullName_q").val();
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvSysSocialRelationsBy(value) {
            $("#hidSortvSysSocialRelationsBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvSysSocialRelationsBy() {
            return $("#hidSortvSysSocialRelationsBy").val();
        }
        /*
        * 用户Id
       */
        get hidUserId() {
            return $("#hidUserId").val();
        }
        /*
        * 是否提交
       */
        set isSubmit(value) {
            $("#chkIsSubmit").val(value);
        }
        /*
        * 是否提交
       */
        get isSubmit() {
            return $("#chkIsSubmit").prop("checked");
        }
        /*
        * 设置关键字的值
       */
        set KeyId(value) {
            $("#hidKeyId").val(value);
        }
        /*
        * 设置关键字的值
       */
        get KeyId() {
            return $("#hidKeyId").val();
        }
        /*
        * 级别Id
       */
        set levelId(value) {
            $("#ddlLevelId").val(value);
        }
        /*
        * 级别Id
       */
        get levelId() {
            return $("#ddlLevelId").val();
        }
        /*
        * 级别Id
       */
        get LevelId_q() {
            return $("#ddlLevelId_q").val();
        }
        /*
        * 专业
       */
        set major(value) {
            $("#txtMajor").val(value);
        }
        /*
        * 专业
       */
        get major() {
            return $("#txtMajor").val();
        }
        /*
        * 备注
       */
        set memo(value) {
            $("#txtMemo").val(value);
        }
        /*
        * 备注
       */
        get memo() {
            return $("#txtMemo").val();
        }
        /*
        * 国籍
       */
        set nationality(value) {
            $("#txtNationality").val(value);
        }
        /*
        * 国籍
       */
        get nationality() {
            return $("#txtNationality").val();
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        set OpType(value) {
            $("#hidOpType").val(value);
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        get OpType() {
            return $("#hidOpType").val();
        }
        /*
        * 社会Id
       */
        set socialId(value) {
            $("#txtSocialId").val(value);
        }
        /*
        * 社会Id
       */
        get socialId() {
            return $("#txtSocialId").val();
        }
        /*
        * 修改日期
       */
        set updDate(value) {
            $("#txtUpdDate").val(value);
        }
        /*
        * 修改日期
       */
        get updDate() {
            return $("#txtUpdDate").val();
        }
        /*
        * 修改人
       */
        set updUser(value) {
            $("#txtUpdUser").val(value);
        }
        /*
        * 修改人
       */
        get updUser() {
            return $("#txtUpdUser").val();
        }
        /*
        * 工作单位
       */
        set workUnit(value) {
            $("#txtWorkUnit").val(value);
        }
        /*
        * 工作单位
       */
        get workUnit() {
            return $("#txtWorkUnit").val();
        }
    }
    exports.gs_PSocialRela = gs_PSocialRela;
});
