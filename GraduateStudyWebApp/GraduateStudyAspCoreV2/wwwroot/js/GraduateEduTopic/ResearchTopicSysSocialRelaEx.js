(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPublicPage/Public_SysSocialRelations.js", "../GraduateEduTopic/SysSocialRelationsCRUDEx.js", "../PagesBase/GraduateEduTopic/SysSocialRelationsCRUD.js", "../TS/FunClass/clsDropDownList.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTSysSocialRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSocialRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSocialRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "./SysSocialRelations_EditEx_Research.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ResearchTopicSysSocialRelaEx = void 0;
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
    //
    //import * as QQ from "q";
    const Public_SysSocialRelations_js_1 = require("../GraduateEduPublicPage/Public_SysSocialRelations.js");
    const SysSocialRelationsCRUDEx_js_1 = require("../GraduateEduTopic/SysSocialRelationsCRUDEx.js");
    const SysSocialRelationsCRUD_js_1 = require("../PagesBase/GraduateEduTopic/SysSocialRelationsCRUD.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsvRTSysSocialRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTSysSocialRelaEN.js");
    const clsvSysSocialRelationsEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js");
    const clsRTSysSocialRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSocialRelaWApi.js");
    const clsvRTSysSocialRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSocialRelaWApi.js");
    const clsvSysSocialRelationsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const SysSocialRelations_EditEx_Research_js_1 = require("./SysSocialRelations_EditEx_Research.js");
    /* SysSocialRelationsCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class ResearchTopicSysSocialRelaEx extends SysSocialRelationsCRUD_js_1.SysSocialRelationsCRUD {
        constructor() {
            super(...arguments);
            //社会关系
            this.mstrListSysSocialRelaDivPaper = "divRtSysSocialRelaLst";
        }
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvSysSocialRelationsBy: string = "socialId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType, strPara) {
            this.BindGv_vSysSocialRelations();
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "vSysSocialRelations":
                    alert('该类没有绑定该函数：[this.BindGv_vSysSocialRelations_Cache]！');
                    //this.BindGv_vSysSocialRelations_Cache();
                    break;
                default:
                    strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                    console.error(strMsg);
                    alert(strMsg);
                    break;
            }
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            let objPage;
            if (SysSocialRelationsCRUD_js_1.SysSocialRelationsCRUD.objPage_CRUD == null) {
                SysSocialRelationsCRUD_js_1.SysSocialRelationsCRUD.objPage_CRUD = new SysSocialRelationsCRUDEx_js_1.SysSocialRelationsCRUDEx();
                objPage = SysSocialRelationsCRUD_js_1.SysSocialRelationsCRUD.objPage_CRUD;
            }
            else {
                objPage = SysSocialRelationsCRUD_js_1.SysSocialRelationsCRUD.objPage_CRUD;
            }
            const objPage_Edit = new SysSocialRelations_EditEx_Research_js_1.SysSocialRelations_EditEx_Research(objPage);
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
                case "CreateWithMaxId": //添加记录使用最大关键字
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
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
    */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    //建立缓存
                    // 为查询区绑定下拉框
                    const gvBindDdl = await this.BindDdl4QueryRegion();
                    SysSocialRelationsCRUD_js_1.SysSocialRelationsCRUD.sortvSysSocialRelationsBy = "fullName Asc";
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
        //社会关系；
        async liSysSocialRelationsClick() {
            try {
                //主题社会关系
                this.hidSortvRTSysSocialRelaBy = "classificationId Asc,updDate Desc";
                const gvResultPaper = await this.BindGv_vRTSysSocialRela();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取客观依据列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vSysSocialRelations() {
            var strListDiv = this.divName4DataList;
            var strWhereCond = await this.CombinevSysSocialRelationsCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvSysSocialRelationsObjLst = [];
            try {
                this.recCount = await (0, clsvSysSocialRelationsWApi_js_1.vSysSocialRelations_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: SysSocialRelationsCRUD_js_1.SysSocialRelationsCRUD.sortvSysSocialRelationsBy,
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
                //    strhtml += '&nbsp;&nbsp;<button title="引用相关关系" class="layui-btn layui-btn layui-btn-xs" onclick=btnOkRTSysSocialRelaInTab_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '")> <i class="layui-icon" >&#xe642;</i>引用该相关关系</button>';
                //    strhtml += '</li>';
                //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                //}
                //strhtml += '</ul></div>';
                var strHtml = await Public_SysSocialRelations_js_1.Public_SysSocialRelations.BindList_vSysSocialRelations("02", arrvSysSocialRelationsObjLst);
                //拼接；
                $("#divSysSocialRelationsDataLst").html(strHtml);
                if (arrvSysSocialRelationsObjLst.length > 10) {
                    //$("#divPagerSysSocialRela").show();
                    this.objPager.recCount = this.recCount;
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
        async CombinevSysSocialRelationsCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strWhereCond = " 1=1";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.fullName_q != "") {
                    strWhereCond += ` And ${clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_FullName} like '% ${this.fullName_q}%'`;
                }
                //if (this.achievement_q != "") {
                //    strWhereCond += ` And ${clsvSysSocialRelationsEN.con_Achievement} like '% ${this.achievement_q}%'`;
                //}
                if (this.levelId_q != "" && this.levelId_q != "0") {
                    strWhereCond += ` And ${clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_LevelId} = '${this.levelId_q}'`;
                }
                if (clsPublocalStorage_js_1.clsPublocalStorage.eduClsTypeId == "0001") {
                    $("#ddlCurrEduCls_q5").hide();
                    $("#ddlPublicViewPoint").show();
                    if ($("#ddlPublicViewPoint") == "1") {
                        strWhereCond += ` And ${clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_UpdUser} in('${clsPublocalStorage_js_1.clsPublocalStorage.TopicUserList}')`;
                    }
                    else {
                        strWhereCond += ` And ${clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_ShareId} ='03'`;
                    }
                }
                if ($("#ddlCurrEduCls_q5").val() != "" && $("#ddlCurrEduCls_q5").val() != "0") {
                    strWhereCond += " And id_CurrEduCls='" + $("#ddlCurrEduCls_q5").val() + "'";
                }
                else {
                    strWhereCond += " And id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
                }
                //只能查询提交的技能数据
                strWhereCond += ` And ${clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_IsSubmit} = 'true'`;
                //排除获取已存在的关系数据 根据当前用户；
                strWhereCond += ` And socialId not in (select socialId from RTSysSocialRela where topicId = '${strTopicId}' And updUser = '${strUserId}')`;
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
        async BindTab_vSysSocialRelations(divContainer, arrvSysSocialRelationsObjLst) {
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
                    fldName: "fullName",
                    colHeader: "姓名",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "nationality",
                    colHeader: "国籍",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "workUnit",
                    colHeader: "工作单位",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "major",
                    colHeader: "专业",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "achievement",
                    colHeader: "成就",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "detailedDescription",
                    colHeader: "详细说明",
                    text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                    columnType: "Label",
                    orderNum: 1,
                    funcName: () => { }
                },
                {
                    fldName: "levelName",
                    colHeader: "级别名称",
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
                    fldName: "updDate",
                    colHeader: "修改日期",
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
            (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrvSysSocialRelationsObjLst, arrDataColumn, "socialId", this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        //查询技能
        async btnQuerySysSocialRelations_Click() {
            const responseObjList = await this.BindGv_vSysSocialRelations();
        }
        /////////////////////////////////////////////////////社会关系////////////////////////////////////////////////
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
    */
        CombinevRTSysSocialRelaCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //判断主题id
                var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicId} = '${strTopicId}'`;
                }
                var strClassificationId = $("#hidClassificationId").val();
                if (strClassificationId != "") {
                    strWhereCond += ` And ${clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_ClassificationId} = '${strClassificationId}'`;
                }
                var strViewsId = $("#hidViewsId").val();
                if (strViewsId != "") {
                    strWhereCond += ` And ${clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_mId} = ${strViewsId}`;
                }
                //判断角色 
                //管理员
                if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620001") {
                }
                else if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620002") {
                    //教师
                }
                else {
                    //学生； 
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineRTSysSocialRelaCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vRTSysSocialRela() {
            var strListDiv = this.mstrListSysSocialRelaDivPaper;
            var strWhereCond = await this.CombinevRTSysSocialRelaCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvRTSysSocialRelaObjLst = [];
            //var arrvUsersObjLst: Array<clsvUsersSimEN> = [];
            try {
                this.recCount = await (0, clsvRTSysSocialRelaWApi_js_1.vRTSysSocialRela_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvRTSysSocialRelaBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvRTSysSocialRelaWApi_js_1.vRTSysSocialRela_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvRTSysSocialRelaObjLst = jsonData;
                });
                //arrvUsersObjLst = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            try {
                //this.BindTab_vRTSysSocialRela(arrvRTSysSocialRelaObjLst, arrvUsersObjLst);
                var strHtml = await Public_SysSocialRelations_js_1.Public_SysSocialRelations.BindList_vRTSysSocialRela("06", arrvRTSysSocialRelaObjLst);
                //拼接；
                $("#divSysSocialRelaDataLst").html(strHtml);
                if (arrvRTSysSocialRelaObjLst.length > 10) {
                    // $("#divSysSocialRelationsDataLst").show();
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
                console.log("完成BindGv_vRTSysSocialRela!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //public async BindTab_vRTSysSocialRela(arrvRTSysSocialRelaObjLst: Array<clsvRTSysSocialRelaEN>, arrvUsersObjLst: Array<clsvUsersSimEN>) {
        //    var strhtml = "";
        //    var strUserId = clsPublocalStorage.userId;//获取当前登录ID 
        //    strhtml += '<div class="info" id="infoSysSocialRela"><div class="title btn-4">';
        //    strhtml += '<div style="float:left;"><a href="#" title="相关社会关系">相关社会关系</a></div>';
        //    strhtml += '</div><ul class="artlist">';
        //    var v = 0;//给内容加个序号
        //    for (var i = 0; i < arrvRTSysSocialRelaObjLst.length; i++) {
        //        //得到socialId；
        //        var strSocialId = arrvRTSysSocialRelaObjLst[i].socialId;
        //        v++;
        //        strhtml += '<li><span class="rowtit color4">' + v + '.[姓名]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].fullName + '</span>';
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[国籍]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].nationality + '</span>';
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[工作单位]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].workUnit + '</span>';
        //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[专业]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].major + '</span></li>';
        //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[成就]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].achievement + '</span></li>';
        //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[详细说明]：</span><span class="abstract-text">' + arrvRTSysSocialRelaObjLst[i].detailedDescription + '</span></li>';
        //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：';
        //        if (arrvRTSysSocialRelaObjLst[i].okCount != 0) {
        //            strhtml += '点赞数：' + arrvRTSysSocialRelaObjLst[i].okCount + '&nbsp;&nbsp';
        //        }
        //        if (arrvRTSysSocialRelaObjLst[i].appraiseCount != 0) {
        //            //评论
        //            strhtml += '&nbsp;&nbsp;评论数：' + arrvRTSysSocialRelaObjLst[i].appraiseCount;
        //        }
        //        if (arrvRTSysSocialRelaObjLst[i].score != 0) {
        //            //评分
        //            strhtml += '&nbsp;&nbsp;综合评分：' + arrvRTSysSocialRelaObjLst[i].score;
        //        }
        //        if (arrvRTSysSocialRelaObjLst[i].teaScore != 0) {
        //            strhtml += '&nbsp;&nbsp;教师评分：' + arrvRTSysSocialRelaObjLst[i].teaScore;
        //        }
        //        if (arrvRTSysSocialRelaObjLst[i].stuScore != 0) {
        //            strhtml += '&nbsp;&nbsp;学生评分：' + arrvRTSysSocialRelaObjLst[i].stuScore;
        //        }
        //        //引用数
        //        strhtml += '&nbsp;&nbsp;&nbsp;被引用数：' + arrvRTSysSocialRelaObjLst[i].citationCount;
        //        if (arrvRTSysSocialRelaObjLst[i].versionCount != 0) {
        //            strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvRTSysSocialRelaObjLst[i].versionCount;
        //        }
        //        if (arrvRTSysSocialRelaObjLst[i].isSubmit == true) {
        //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
        //        }
        //        else {
        //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
        //        }
        //        strhtml += '</li>';
        //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';
        //        //获取引用人；编辑人、用户名称
        //        //var arrUsers: Array<clsvUsersSimEN> = await Users_GetObjLstAsync("1=1");
        //        var arrvUsers: Array<clsvUsersSimEN> = [];
        //        var UpdUserName;//编辑人
        //        var CacitionUserName;//引用人
        //        //获取技能引用人；
        //        arrvUsers = arrvUsersObjLst.filter(x => x.userId == arrvRTSysSocialRelaObjLst[i].updUser);//技能引用人
        //        for (var j = 0; j < arrvUsers.length; j++) {
        //            CacitionUserName = arrvUsers[j].userName;
        //            break;
        //        }
        //        //获取技能编辑人；
        //        arrvUsers = arrvUsersObjLst.filter(x => x.userId == arrvRTSysSocialRelaObjLst[i].socialUpdUser);//技能编辑人
        //        for (var j = 0; j < arrvUsers.length; j++) {
        //            UpdUserName = arrvUsers[j].userName;
        //            break;
        //        }
        //        if (arrvRTSysSocialRelaObjLst[i].socialUpdUser == arrvRTSysSocialRelaObjLst[i].updUser) {
        //            strhtml += '&nbsp;&nbsp;&nbsp;编辑引用人：' + UpdUserName;
        //        } else {
        //            strhtml += '&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用人：' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName;
        //        }
        //        if (arrvRTSysSocialRelaObjLst[i].socialUpdDate == arrvRTSysSocialRelaObjLst[i].updDate) {
        //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑引用时间：' + arrvRTSysSocialRelaObjLst[i].socialUpdDate;
        //        } else {
        //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用时间：' + arrvRTSysSocialRelaObjLst[i].socialUpdDate + '&nbsp;/&nbsp;' + arrvRTSysSocialRelaObjLst[i].updDate;
        //        }
        //        if (strUserId == arrvRTSysSocialRelaObjLst[i].updUser) {
        //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelRTSysSocialRelaRecordInTab_Click(' + arrvRTSysSocialRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
        //        }
        //        if (arrvRTSysSocialRelaObjLst[i].isSubmit != true) {
        //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnUpdSyssocial_Click("' + arrvRTSysSocialRelaObjLst[i].socialId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
        //        }
        //        //strhtml += '&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除相关引用" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelRTSysSocialRelaRecordInTab_Click(' + arrvRTSysSocialRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除相关引用</button>';
        //        if (arrvRTSysSocialRelaObjLst[i].versionCount > 0 && arrvRTSysSocialRelaObjLst[i].versionCount != null) {
        //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('相关技能历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTSysSocialRelaObjLst[i].socialId + "&Type=09')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
        //        }
        //        strhtml += '</li>';
        //        strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        //    }
        //    strhtml += '</ul></div>';
        //    //拼接；
        //    $("#divSysSocialRelaDataLst").html(strhtml);
        //    if (arrvRTSysSocialRelaObjLst.length > 10) {
        //        // $("#divSysSocialRelationsDataLst").show();
        //        this.objPager.recCount = this.recCount;
        //        this.objPager.pageSize = this.pageSize;
        //        this.objPager.ShowPagerV2(this, this.divName4Pager);
        //    }
        //}
        /* 函数功能:在数据 列表中跳转到某一页
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
    <param name = "intPageIndex">页序号</param>
    */
        //public IndexPageEleven(intPageIndex) {
        //    if (intPageIndex == 0) {
        //        intPageIndex = this.objPager.pageCount;
        //    }
        //    console.log("跳转到" + intPageIndex + "页");
        //    this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        //    this.BindGv_vRTSysSocialRela();
        //}
        /*
    在数据表里删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
    */
        async btnDelRTSysSocialRelaRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                var lngKeyId = Number(strKeyId);
                const responseText = await this.DelRTSysSocialRelaRecord(lngKeyId);
                const responseBindGv = await this.BindGv_vRTSysSocialRela();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
    根据关键字删除记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    */
        async DelRTSysSocialRelaRecord(lngmId) {
            try {
                const responseText = await (0, clsRTSysSocialRelaWApi_js_1.RTSysSocialRela_DelRecordAsync)(lngmId);
                var returnInt = responseText;
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
                console.log("完成DelRecord!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        //添加技能
        async btnAddRTSysSocialRelaInTab_Click() {
            // 为查询区绑定下拉框
            const gvBindDdl = await this.BindDdl4QueryRegion();
            var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
            if (strRoleId == "00620003") {
                const Ddl_CurrEduClsStu_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_CurrEduClsStu("ddlCurrEduCls_q5");
            }
            else {
                const Ddl_CurrEduClsTea_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_CurrEduClsTea("ddlCurrEduCls_q5");
            }
            const responseObjList = await this.BindGv_vSysSocialRelations();
        }
        /*
    * 设置排序字段-相当使用ViewState功能
    */
        set hidSortvRTSysSocialRelaBy(value) {
            $("#hidSortvRTSysSocialRelaBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvRTSysSocialRelaBy() {
            return $("#hidSortvRTSysSocialRelaBy").val();
        }
    }
    exports.ResearchTopicSysSocialRelaEx = ResearchTopicSysSocialRelaEx;
});
