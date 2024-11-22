(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPublicPage/Public_SysSkill.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js", "../TS/L0_Entity/GraduateEduPaper/clsgs_PSkillRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js", "../TS/L0_Entity/ParameterTable/clsSysOperationTypeEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PSkillRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js", "../TS/L3_ForWApi/ParameterTable/clsSysOperationTypeWApi.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PSysskillRela = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:SysSkillCRUDEx
    表名:SysSkill(01120646)
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
    //import { SysSkillCRUD } from "./SysSkillCRUD.js";
    const Public_SysSkill_js_1 = require("../GraduateEduPublicPage/Public_SysSkill.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsgs_OriginalPaperLogEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_OriginalPaperLogEN.js");
    const clsgs_PSkillRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_PSkillRelaEN.js");
    const clsSysSkillEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js");
    const clsvSysSkillEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js");
    const clsSysOperationTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSysOperationTypeEN.js");
    const clsgs_OriginalPaperLogWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_OriginalPaperLogWApi.js");
    const clsgs_PSkillRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_PSkillRelaWApi.js");
    const clsSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js");
    const clsvSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js");
    const clsSysOperationTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsSysOperationTypeWApi.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    /* SysSkillCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class gs_PSysskillRela extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super(...arguments);
            //public static mstrListDiv: string = "divDataLst";
            //public static mstrSortvSysSkillBy: string = "skillId";
            //技能列表
            this.mstrListDivPaper = "divSysSkillDataLst";
            this.RecCount = 0;
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
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
                    //建立缓存
                    // 为查询区绑定下拉框
                    const gvBindDdl = await this.BindDdl4QueryRegion();
                    this.hidSortvSysSkillBy = "skillName Asc";
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vSysSkill();
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
            var objSysOperationType_Cond = new clsSysOperationTypeEN_js_1.clsSysOperationTypeEN(); //查询区域
            const ddlOperationTypeId_q = await (0, clsSysOperationTypeWApi_js_1.SysOperationType_BindDdl_OperationTypeIdInDiv_Cache)(this.divName4List, "ddlOperationTypeId_q"); //查询区域
        }
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
    */
        CombinevSysSkillCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "'";
            var strPaperId = $('#hidPaperId').val();
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //只能查询提交的技能数据
                strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_IsSubmit} = 'true'`;
                var strPageType = $("#hidPageType").val();
                if (strPageType == "gs_TDR") {
                    if ($("#txtViewpointName_q").val() != "") {
                        strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillName} like '% ${$("#txtViewpointName_q").val()}%'`;
                    }
                    if ($("#txtViewUpdName_q").val() != "") {
                        strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser} like '% ${$("#txtViewUpdName_q").val()}%'`;
                    }
                    //strWhereCond += ` And skillId not in (select skillId from RTSysSkillRela where paperId = '${strPaperId}' And updUser = '${strUserId}')`;
                }
                else {
                    if (this.SkillName_q != "") {
                        strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillName} like '% ${this.SkillName_q}%'`;
                    }
                    if (this.OperationTypeId_q != "" && this.OperationTypeId_q != "0") {
                        strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeId} = '${this.OperationTypeId_q}'`;
                    }
                    if (this.UpdUser_q != "") {
                        strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser} like '% ${this.UpdUser_q}%'`;
                    }
                    //排除获取已存在的关系数据 根据当前用户；
                    strWhereCond += ` And skillId not in (select skillId from gs_PSkillRela where paperId = '${strPaperId}' And updUser = '${strUserId}')`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysSkillCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vSysSkill() {
            var strListDiv = this.mstrListDivPaper;
            var strWhereCond = this.CombinevSysSkillCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvSysSkillObjLst = [];
            try {
                const responseRecCount = await (0, clsvSysSkillWApi_js_1.vSysSkill_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvSysSkillBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvSysSkillWApi_js_1.vSysSkill_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvSysSkillObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvSysSkillObjLst.length == 0) {
            //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                //this.BindTab_vSysSkill(strListDiv, arrvSysSkillObjLst);
                //var strhtml = "";
                ////个人观点
                //strhtml += '<div class="info" id="infoConcept"><div class="title btn-4">';
                //strhtml += '<div><a href="#" title="当前相关技能">当前相关技能</a></div>';
                ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加相关概念" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加相关概念</button></div>';
                //strhtml += '</div><ul class="artlist">';
                //var v = 0;//给内容加个序号
                //for (var i = 0; i < arrvSysSkillObjLst.length; i++) {
                //    //得到SkillIdId；
                //    var strSkillId = arrvSysSkillObjLst[i].skillId;
                //    v++;
                //    strhtml += '<li><span class="rowtit color4">' + v + '.[技能名称]：</span><span class="abstract-text">' + arrvSysSkillObjLst[i].skillName + '</span></li>';
                //    strhtml += '<li><span class="rowtit color4">[实施过程]：</span><span class="abstract-text">' + arrvSysSkillObjLst[i].process + '</span></li>';
                //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + arrvSysSkillObjLst[i].updUser;
                //    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvSysSkillObjLst[i].updDate;
                //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';
                //    //引用数
                //    strhtml += '&nbsp;&nbsp;被引用数:' + arrvSysSkillObjLst[i].citationCount;
                //    strhtml += '&nbsp;&nbsp;<button title="引用相关技能" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkSysskillInTab_Click("' + arrvSysSkillObjLst[i].skillId + '")> <i class="layui-icon" >&#xe642;</i>引用该相关概念</button>';
                //    strhtml += '</li>';
                //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                //}
                //strhtml += '</ul></div>';
                var strHtml = await Public_SysSkill_js_1.Public_SysSkill.BindList_vSysSkill("02", arrvSysSkillObjLst);
                //拼接；
                $("#divSysSkillDataLst").html(strHtml);
                if (arrvSysSkillObjLst.length > 10) {
                    //$("#divPager2").show();
                    this.objPager.RecCount = this.RecCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
                console.log("完成BindGv_vSysSkill!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //添加技能
        async btnAddSysskillInTab_Click() {
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();
            const responseObjList = await this.BindGv_vSysSkill();
        }
        //确定选择的观点 并添加到关系表中
        btnOkSysskillInTab_Click(strkeyId) {
            //存放Id
            $("#hidSkillId").val(strkeyId);
            //执行添加关系方法
            this.AddNewRecordSave();
        }
        //查询技能
        async btnQuerySysskill_Click() {
            const responseObjList = await this.BindGv_vSysSkill();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjgs_PSkillRelaEN">数据传输的目的类对象</param>
    */
        PutDataTogs_PSkillRelaClass(pobjgs_PSkillRelaEN) {
            var strPaperId = $('#hidPaperId').val();
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            var strSkillId = $("#hidSkillId").val();
            pobjgs_PSkillRelaEN.paperId = strPaperId; // 主题编号
            pobjgs_PSkillRelaEN.sectionId = $("#ddlSectionId4").val(); // 论文章节id
            pobjgs_PSkillRelaEN.skillId = strSkillId; // 技能Id
            pobjgs_PSkillRelaEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjgs_PSkillRelaEN.updUser = strUserId;
            pobjgs_PSkillRelaEN.memo = this.memo; // 备注
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var strPaperId = $('#hidPaperId').val();
            var strSkillId = $("#hidSkillId").val();
            var strPaperLogTypeId = $('#hidPaperLogTypeId').val(); //流程日志参数
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            var objgs_PSkillRelaEN = new clsgs_PSkillRelaEN_js_1.clsgs_PSkillRelaEN();
            this.PutDataTogs_PSkillRelaClass(objgs_PSkillRelaEN);
            try {
                //同一主题 同一技能 只能添加一次；
                var strWhere = " 1 = 1 And paperId = '" + strPaperId + "' And skillId = '" + strSkillId + "'";
                const responseText = await (0, clsgs_PSkillRelaWApi_js_1.gs_PSkillRela_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `同一主题同一个用户不能重复添加同一个技能！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                else {
                    const responseText2 = await (0, clsgs_PSkillRelaWApi_js_1.gs_PSkillRela_AddNewRecordAsync)(objgs_PSkillRelaEN);
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
                        var strWhereCond2 = " 1 =1 and skillId=" + strSkillId;
                        var intCitationCount = await (0, clsgs_PSkillRelaWApi_js_1.gs_PSkillRela_GetRecCountByCondAsync)(strWhereCond2);
                        var objSysSkillEN = new clsSysSkillEN_js_1.clsSysSkillEN();
                        objSysSkillEN.skillId = strSkillId;
                        objSysSkillEN.citationCount = intCitationCount;
                        objSysSkillEN.sf_UpdFldSetStr = objSysSkillEN.updFldString; //设置哪些字段被修改(脏字段)
                        if (objSysSkillEN.skillId == "" || objSysSkillEN.skillId == undefined) {
                            throw "关键字不能为空!";
                        }
                        const responseText = await (0, clsSysSkillWApi_js_1.SysSkill_UpdateRecordAsync)(objSysSkillEN).then((jsonData) => {
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
                        HideDialogNine();
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
            //var strPaperLogTypeId = $('#PaperLogTypeId').val();
            //通过区分 是小组讨论还是同伴建议
            var logTypeId = $('#hidCommentTypeId').val();
            pobjgs_OriginalPaperLogEN.paperId = strPaperId;
            pobjgs_OriginalPaperLogEN.logTypeId = strPaperLogTypeId;
            pobjgs_OriginalPaperLogEN.logDescription = "添加子观点";
            // $('#PaperLogTypeId').val("03");
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
        * 引用Id
       */
        set citationId(value) {
            $("#txtCitationId").val(value);
        }
        /*
        * 引用Id
       */
        get citationId() {
            return $("#txtCitationId").val();
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
        * 添加、修改用的层名
       */
        set DivName(value) {
            $("#hidDivName").val(value);
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvSysSkillBy(value) {
            $("#hidSortvSysSkillBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvSysSkillBy() {
            return $("#hidSortvSysSkillBy").val();
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
        * 操作类型ID
       */
        set operationTypeId(value) {
            $("#ddlOperationTypeId").val(value);
        }
        /*
        * 操作类型ID
       */
        get operationTypeId() {
            return $("#ddlOperationTypeId").val();
        }
        /*
        * 操作类型ID
       */
        get OperationTypeId_q() {
            return $("#ddlOperationTypeId_q").val();
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
        * 实施过程
       */
        set process(value) {
            $("#txtProcess").val(value);
        }
        /*
        * 实施过程
       */
        get process() {
            return $("#txtProcess").val();
        }
        /*
        * 技能Id
       */
        set skillId(value) {
            $("#txtSkillId").val(value);
        }
        /*
        * 技能Id
       */
        get skillId() {
            return $("#txtSkillId").val();
        }
        /*
        * 技能名称
       */
        set skillName(value) {
            $("#txtSkillName").val(value);
        }
        /*
        * 技能名称
       */
        get skillName() {
            return $("#txtSkillName").val();
        }
        /*
        * 技能名称
       */
        get SkillName_q() {
            return $("#txtSkillName_q").val();
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
        * 修改人
       */
        get UpdUser_q() {
            return $("#txtUpdUser_q").val();
        }
    }
    exports.gs_PSysskillRela = gs_PSysskillRela;
});
