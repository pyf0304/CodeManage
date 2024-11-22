(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/PubFun/clsCommFunc4Web.js", "../GraduateEduTopic/SysSocialRelationsCRUDEx.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsRTSysSocialRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js", "../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsVerEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js", "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js", "../TS/L0_Entity/ParameterTable/clsSysSecurityLevelEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSocialRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsVerWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../TS/L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js", "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../PagesBase/GraduateEduTopic/SysSocialRelations_Edit.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsString.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubConfig/clsPrivateSessionStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.AddSysSocialRelationsEx = void 0;
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
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const SysSocialRelationsCRUDEx_js_1 = require("../GraduateEduTopic/SysSocialRelationsCRUDEx.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsRTSysSocialRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTSysSocialRelaEN.js");
    const clsSysSocialRelationsEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js");
    const clsSysSocialRelationsVerEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsSysSocialRelationsVerEN.js");
    const clsvSysSocialRelationsEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js");
    const clsgs_ShareEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js");
    const clsSysSecurityLevelEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSysSecurityLevelEN.js");
    const clsResearchTopicWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js");
    const clsRTSysSocialRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSocialRelaWApi.js");
    const clsSysSocialRelationsVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsVerWApi.js");
    const clsSysSocialRelationsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsSysSocialRelationsWApi.js");
    const clsgs_ShareWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsSysSecurityLevelWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js");
    const clsgs_UserConfigExWApi_js_1 = require("../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const SysSocialRelations_Edit_js_1 = require("../PagesBase/GraduateEduTopic/SysSocialRelations_Edit.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    /* SysSocialRelationsCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class AddSysSocialRelationsEx extends SysSocialRelations_Edit_js_1.SysSocialRelations_Edit {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvSysSocialRelationsBy: string = "socialId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
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
                    //objPage.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    if (strKeyId == "") {
                        alert("请选择需要修改的记录！");
                        return;
                    }
                    //objPage.btnUpdateRecord_Click(strKeyId);
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
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
            const strThisFuncName = this.Page_Load.name;
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    //通过主题Id获取教学班ID
                    if (clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls == "") {
                        const objResearchTopic = await (0, clsResearchTopicWApi_js_1.ResearchTopic_GetFirstObjAsync)(" topicId=" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId);
                        if (objResearchTopic == null) {
                            const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                            console.error(strMsg);
                            alert(strMsg);
                            return;
                            //const strThisFuncName = this.Page_Load.name;
                        }
                        clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls = objResearchTopic.id_CurrEduCls;
                    }
                    //建立缓存
                    //this.AddNewRecord();
                    //// 为查询区绑定下拉框
                    var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
                    const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4Edit, "ddlShareId");
                    var strSocialId = $("#hidSocialId").val();
                    if (strSocialId != "") {
                        const conBindDdl = await this.BindDdl4EditRegion();
                        const UpdateRecord = await this.UpdateRecord(strSocialId);
                        $("#divLoading").hide();
                    }
                    else {
                        $("#divLoading").hide();
                        //获取分享Id
                        const responseText = await (0, clsgs_UserConfigExWApi_js_1.gs_UserConfigEx_GetNewReturnShareIdEx)("10", clsPublocalStorage_js_1.clsPublocalStorage.userId);
                        var strShareId = responseText;
                        //var returnBool: boolean = !!responseText2;
                        if (strShareId != "") {
                            this.shareId = strShareId;
                        }
                        this.btnAddNewRecord_Click();
                    }
                    //const gvBindDdl = await this.BindDdl4QueryRegion();
                    //this.hidSortvSysSocialRelationsBy = "fullName Asc";
                    ////2、显示无条件的表内容在GridView中
                    //const gvResult = await this.BindGv_vSysSocialRelations();
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
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
       */
        async btnAddNewRecord_Click() {
            this.opType = "AddWithMaxId";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    //const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegion();
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecord();
                }
                else {
                    const responseText = await this.AddNewRecord();
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
    */
        async btnUpdateRecord_Click(strKeyId) {
            this.opType = "Update";
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            if (this.bolIsLoadEditRegion == false) //
             {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                ShowDialog('Update');
                this.bolIsLoadEditRegion = true; //
                this.UpdateRecord(strKeyId);
            }
            else {
                ShowDialog('Update');
                this.UpdateRecord(strKeyId);
            }
        }
        /* 函数功能:把类对象的属性内容显示到界面上
    注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
     如果在设置数据库时,就应该一级字段在前,二级字段在后
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
     <param name = "pobjSysSocialRelationsEN">表实体类对象</param>
    */
        GetDataFromSysSocialRelationsClass(pobjSysSocialRelationsEN) {
            this.socialId = pobjSysSocialRelationsEN.socialId; // 社会Id
            this.fullName = pobjSysSocialRelationsEN.fullName; // 姓名
            this.nationality = pobjSysSocialRelationsEN.nationality; // 国籍
            this.levelId = pobjSysSocialRelationsEN.levelId; // 级别Id
            this.workUnit = pobjSysSocialRelationsEN.workUnit; // 工作单位
            this.major = pobjSysSocialRelationsEN.major; // 专业
            this.achievement = pobjSysSocialRelationsEN.achievement; // 成就
            this.detailedDescription = pobjSysSocialRelationsEN.detailedDescription; // 详细说明
            this.shareId = pobjSysSocialRelationsEN.shareId;
            //this.updUser = pobjSysSocialRelationsEN.updUser;// 修改人
            //this.updDate = pobjSysSocialRelationsEN.updDate;// 修改日期
            this.isSubmit = pobjSysSocialRelationsEN.isSubmit; // 是否提交
            this.memo = pobjSysSocialRelationsEN.memo; // 备注
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(strSocialId) {
            this.btnSubmit_SysSocialRelations = "确认修改";
            this.btnCancel_SysSocialRelations = "取消修改";
            this.keyId = strSocialId;
            try {
                const responseText = await (0, clsSysSocialRelationsWApi_js_1.SysSocialRelations_GetObjBySocialIdAsync)(strSocialId);
                var objSysSocialRelationsEN = responseText;
                this.GetDataFromSysSocialRelationsClass(objSysSocialRelationsEN);
                console.log("完成UpdateRecord!");
                return true;
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            return true;
        }
        /* 修改记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
       */
        async UpdateRecordSave() {
            const strThisFuncName = this.UpdateRecordSave.name;
            var objSysSocialRelationsEN = new clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN();
            objSysSocialRelationsEN.SetSocialId(this.keyId);
            this.PutDataToSysSocialRelationsClass(objSysSocialRelationsEN);
            objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
        /* 函数功能:为编辑区绑定下拉框
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
        */
        async BindDdl4EditRegion() {
            // 在此处放置用户代码以初始化页面
            var objSysSecurityLevel_Cond = new clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN(); //编辑区域
            const ddlLevelId = await (0, clsSysSecurityLevelWApi_js_1.SysSecurityLevel_BindDdl_LevelIdInDiv_Cache)(this.divName4Edit, "ddlLevelId"); //编辑区域
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        //public async BindGv_vSysSocialRelations() {
        //    var strListDiv: string = this.mstrListDiv;
        //    var strWhereCond = await this.CombinevSysSocialRelationsCondition();
        //    var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        //    var arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN> = [];
        //    try {
        //        this.recCount = await vSysSocialRelations_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //        });
        //        var objPagerPara: stuPagerPara = {
        //            pageIndex: intCurrPageIndex,
        //            pageSize: this.pageSize,
        //            whereCond: strWhereCond,
        //            orderBy: this.hidSortvSysSocialRelationsBy,
        //            sortFun: (x, y) => { return 0; }
        //        };
        //        const responseObjLst = await vSysSocialRelations_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //            arrvSysSocialRelationsObjLst = <Array<clsvSysSocialRelationsEN>>jsonData;
        //        });
        //        //动态显示对应的数据
        //        var strhtml = "";
        //        var strUserId = clsPublocalStorage.userId;
        //        var strRoleId = clsPublocalStorage.roleId;
        //        //社会关系
        //        strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';
        //        strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加社会关系" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加社会关系</button></div>';
        //        strhtml += '</div><ul class="artlist">';
        //        var v = 0;//给内容加个序号
        //        for (var i = 0; i < arrvSysSocialRelationsObjLst.length; i++) {
        //            //得到socialId；
        //            var strSocialId = arrvSysSocialRelationsObjLst[i].socialId;
        //            v++;
        //            //strhtml += v + ".观点：" + arrvTopicObjectiveObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvTopicObjectiveObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvTopicObjectiveObjLst[i].viewpointTypeName + ":" + arrvTopicObjectiveObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvTopicObjectiveObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
        //            strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[姓名]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].fullName + '</span>';
        //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[国籍]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].nationality + '</span>';
        //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[工作单位]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].workUnit + '</span>';
        //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[专业]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].major + '</span></li>';
        //            strhtml += '<li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[成就]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].achievement + '</span></li>';
        //            strhtml += '<li><span class="rowtit color3">[详细说明]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].detailedDescription + '</span></li>';
        //            strhtml += '<li><div style="height:100%;width:100%;"><div style = "float:left;width:69%;">'
        //            strhtml += '<span class="rowtit color3">[编辑日期]：</span><span class="abstract-text">' + arrvSysSocialRelationsObjLst[i].updDate + '</span>';
        //            ////获取用户名称；根据id；
        //            //var arrUsers: Array<clsUsersEN> = await Users_GetObjLstAsync("1=1");
        //            ////获取用户名；
        //            //var strUserName = arrUsers.filter(x => x.userId == arrvSysSocialRelationsObjLst[i].updUser);//
        //            //strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[用户]：</span><span class="abstract-text">' + strUserName + '</span>';
        //            //判断ture 、false
        //            if (arrvSysSocialRelationsObjLst[i].isSubmit == true) {
        //                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span></div>';
        //            }
        //            else {
        //                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">未提交</span></div>';
        //            }
        //            //strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[是否提交]：</span><span class="abstract-text">' + arrvTopicObjectiveObjLst[i].isSubmit + '</span></div>';
        //            if (strUserId == arrvSysSocialRelationsObjLst[i].updUser) {
        //                strhtml += '<div style="float:right;width:30%;">&nbsp;&nbsp;<span class="rowtit colorRed">[操作]：</span>';
        //                //修改技能
        //                strhtml += '&nbsp;&nbsp;<button title="修改社会关系" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdateRecordInTab_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '")> <i class="layui-icon" >&#xe642;</i>修改社会关系</button>';
        //                //删除技能
        //                strhtml += '&nbsp;&nbsp;<button title="删除社会关系" class="layui-btn layui-btn layui-btn-xs" onclick=btnDelRecordInTab_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '")> <i class="layui-icon" >&#xe642;</i>删除社会关系</button>';
        //                //数据提交
        //                strhtml += '&nbsp;&nbsp;<button title="提交数据" class="layui-btn layui-btn layui-btn-xs" onclick=btnIsSubmit_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '")> <i class="layui-icon" >&#xe642;</i>提交数据</button>';
        //                //历史版本
        //                //if (arrvSysSocialRelationsObjLst[i].versionCount > 0 && arrvSysSocialRelationsObjLst[i].versionCount != null) {
        //                //    strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('技能历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvSysSocialRelationsObjLst[i].skillId + "&Type=08')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
        //                //}
        //            } else {
        //                strhtml += '<div style="float:right;width:30%;">&nbsp;&nbsp;<span class="rowtit color5">[操作]：</span>';
        //            }
        //            //读取session角色 来判断绑定不同数据列表
        //            //获取用户角色来判断显示不同的列表数据；
        //            //管理员则不需要隐藏
        //            if (strRoleId != "00620003") {
        //                //取消提交
        //                strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrvSysSocialRelationsObjLst[i].socialId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';
        //            }
        //            //else {
        //            //    //学生00620003 教师 需要隐藏
        //            //    //取消提交
        //            //    strhtml += '&nbsp;&nbsp;<button id="btnCancelSubmit" style="display:none;" title="取消提交" class="layui-btn layui-btn layui-btn-xs" onclick=btnCancelSubmit_Click("' + arrvTopicObjectiveObjLst[i].topicObjectiveId + '")> <i class="layui-icon" >&#xe642;</i>取消提交</button>';
        //            //}
        //            strhtml += '</div></div></li>';
        //            strhtml += '</br></br><div style="border-bottom: 1px solid #eee;"></div></br>';
        //        }
        //        strhtml += '</ul></div>';
        //        //拼接；
        //        $("#divDataLst").html(strhtml);
        //        if (this.recCount >= 10) {
        //            $("#divPager").show();
        //            this.objPager.recCount = this.recCount;
        //            this.objPager.pageSize = this.pageSize;
        //            this.objPager.ShowPagerV2(this, this.divName4Pager);
        //        }
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `绑定GridView不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //    //if (arrvSysSocialRelationsObjLst.length == 0) {
        //    //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
        //    //    alert(strMsg);
        //    //    return;
        //    //}
        //    //try {
        //    //    this.BindTab_vSysSocialRelations(strListDiv, arrvSysSocialRelationsObjLst);
        //    //    console.log("完成BindGv_vSysSocialRelations!");
        //    //}
        //    //catch (e) {
        //    //    console.error('catch(e)=');
        //    //    console.error(e);
        //    //    var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //    //    alert(strMsg);
        //    //}
        //}
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        //public async CombinevSysSocialRelationsCondition():Promise<string>  {
        //    //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //    //例如 1 = 1 && userName = '张三'
        //    var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //    //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        //    try {
        //        if (this.fullName_q != "") {
        //            strWhereCond += ` And ${clsvSysSocialRelationsEN.con_FullName} like '% ${this.fullName_q}%'`;
        //        }
        //        if (this.achievement_q != "") {
        //            strWhereCond += ` And ${clsvSysSocialRelationsEN.con_Achievement} like '% ${this.achievement_q}%'`;
        //        }
        //        if (this.levelId_q != "" && this.levelId_q != "0") {
        //            strWhereCond += ` And ${clsvSysSocialRelationsEN.con_LevelId} = '${this.levelId_q}'`;
        //        }
        //        var strUserId = clsPublocalStorage.userId;
        //        var strRoleId = clsPublocalStorage.roleId;
        //        $("#hidUserId").val(strUserId);
        //        //判断角色 
        //        //管理员
        //        if (strRoleId == "00620001") {
        //            $("#btnDelRecord").show();
        //            $("#btnCancelSubmit").show();
        //        }
        //        else if (strRoleId == "00620002") {
        //            //教师
        //            $("#btnDelRecord").hide();
        //            $("#btnCancelSubmit").show();
        //        }
        //        else {
        //            //学生 教师；
        //            $("#btnDelRecord").hide();
        //            $("#btnCancelSubmit").hide();
        //            //学生00620003 00620002教师
        //            strWhereCond += ` And ${clsvSysSocialRelationsEN.con_UpdUser} = '${strUserId}'`;
        //            //strWhereCond += ` And ${clsvViewpointEN.con_VPProposePeople} = '${objvUserRoleRelation.userId}'`;
        //        }
        //    }
        //    catch (objException) {
        //        var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineSysSocialRelationsCondition)时出错!请联系管理员!${objException}`;
        //        throw strMsg;
        //    }
        //    return strWhereCond;
        //}
        /* 显示vSysSocialRelations对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrSysSocialRelationsObjLst">需要绑定的对象列表</param>
    */
        //public async BindTab_vSysSocialRelations(divContainer: string, arrvSysSocialRelationsObjLst: Array<clsvSysSocialRelationsEN>) {
        //    var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        //    if (o == null) {
        //        alert(`${divContainer}不存在！`);
        //        return;
        //    }
        //    var arrDataColumn: Array<clsDataColumn> =
        //        [
        //            {
        //                fldName: "",
        //                colHeader: "",
        //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "CheckBox",
        //                orderNum: 1,
        //                funcName: () => { }
        //            },
        //            {
        //                fldName: "fullName",
        //                colHeader: "姓名",
        //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "Label",
        //                orderNum: 1,
        //                funcName: () => { }
        //            },
        //            {
        //                fldName: "nationality",
        //                colHeader: "国籍",
        //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "Label",
        //                orderNum: 1,
        //                funcName: () => { }
        //            },
        //            {
        //                fldName: "workUnit",
        //                colHeader: "工作单位",
        //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "Label",
        //                orderNum: 1,
        //                funcName: () => { }
        //            },
        //            {
        //                fldName: "major",
        //                colHeader: "专业",
        //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "Label",
        //                orderNum: 1,
        //                funcName: () => { }
        //            },
        //            {
        //                fldName: "achievement",
        //                colHeader: "成就",
        //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "Label",
        //                orderNum: 1,
        //                funcName: () => { }
        //            },
        //            {
        //                fldName: "detailedDescription",
        //                colHeader: "详细说明",
        //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "Label",
        //                orderNum: 1,
        //                funcName: () => { }
        //            },
        //            {
        //                fldName: "levelName",
        //                colHeader: "级别名称",
        //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "Label",
        //                orderNum: 1,
        //                funcName: () => { }
        //            },
        //            {
        //                fldName: "updUser",
        //                colHeader: "修改人",
        //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "Label",
        //                orderNum: 1,
        //                funcName: () => { }
        //            },
        //            {
        //                fldName: "updDate",
        //                colHeader: "修改日期",
        //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "Label",
        //                orderNum: 1,
        //                funcName: () => { }
        //            },
        //            {
        //                fldName: "isSubmit",
        //                colHeader: "是否提交",
        //                text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                columnType: "Label",
        //                orderNum: 1,
        //                funcName: () => { }
        //            },
        //            //{
        //            //    fldName: "",
        //            //    colHeader: "修改",
        //            //    text: "修改",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //            //    columnType: "Button",
        //            //    orderNum: 1,
        //            //    funcName: (strKeyId: string, strText: string) => {
        //            //        var btn1: HTMLElement = document.createElement("button");
        //            //        btn1.innerText = strText;
        //            //        btn1.className = "btn btn-outline-info btn-sm";
        //            //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
        //            //        return btn1;
        //            //    }
        //            //},
        //            //{
        //            //    fldName: "",
        //            //    colHeader: "删除",
        //            //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //            //    columnType: "Button",
        //            //    orderNum: 1,
        //            //    funcName: (strKeyId: string, strText: string) => {
        //            //        var btn1: HTMLElement = document.createElement("button");
        //            //        btn1.innerText = strText;
        //            //        btn1.className = "btn btn-outline-info btn-sm";
        //            //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
        //            //        return btn1;
        //            //    }
        //            //},
        //        ];
        //    BindTab(o, arrvSysSocialRelationsObjLst, arrDataColumn, "socialId");
        //    this.objPager.recCount = this.recCount;
        //    this.objPager.pageSize = this.pageSize;
        //    this.objPager.ShowPagerV2(this, this.divName4Pager);
        //}
        /* 函数功能:把界面上的属性数据传到类对象中
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
    <param name = "pobjSysSocialRelationsEN">数据传输的目的类对象</param>
    */
        PutDataToSysSocialRelationsVClass(pobjSysSocialRelationsVerEN) {
            var strSocialId = $("#hidSocialId").val();
            pobjSysSocialRelationsVerEN.SetSocialId(strSocialId); // 社会Id
            pobjSysSocialRelationsVerEN.SetFullName(this.fullName); // 姓名
            pobjSysSocialRelationsVerEN.SetNationality(this.nationality); // 国籍
            pobjSysSocialRelationsVerEN.SetLevelId(this.levelId); // 级别Id
            pobjSysSocialRelationsVerEN.SetWorkUnit(this.workUnit); // 工作单位
            pobjSysSocialRelationsVerEN.SetMajor(this.major); // 专业
            pobjSysSocialRelationsVerEN.SetAchievement(this.achievement); // 成就
            pobjSysSocialRelationsVerEN.SetDetailedDescription(this.detailedDescription); // 详细说明
            pobjSysSocialRelationsVerEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjSysSocialRelationsVerEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjSysSocialRelationsVerEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            //pobjSysSocialRelationsVerEN.SetIsSubmit(this.isSubmit;// 是否提交
            pobjSysSocialRelationsVerEN.SetMemo(this.memo); // 备注
        }
        /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjSysSocialRelationsEN">数据传输的目的类对象</param>
    */
        async PutDataToSysSocialRelationsClass(pobjSysSocialRelationsEN) {
            //pobjSysSocialRelationsEN.SetSocialId(this.socialId;// 社会Id
            pobjSysSocialRelationsEN.SetFullName(this.fullName); // 姓名
            pobjSysSocialRelationsEN.SetNationality(this.nationality); // 国籍
            pobjSysSocialRelationsEN.SetLevelId(this.levelId); // 级别Id
            pobjSysSocialRelationsEN.SetWorkUnit(this.workUnit); // 工作单位
            pobjSysSocialRelationsEN.SetMajor(this.major); // 专业
            pobjSysSocialRelationsEN.SetAchievement(this.achievement); // 成就
            pobjSysSocialRelationsEN.SetDetailedDescription(this.detailedDescription); // 详细说明
            pobjSysSocialRelationsEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjSysSocialRelationsEN.SetShareId(this.shareId);
            pobjSysSocialRelationsEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjSysSocialRelationsEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            pobjSysSocialRelationsEN.SetIsSubmit(this.isSubmit); // 是否提交
            pobjSysSocialRelationsEN.SetCitationId($("#hidRequestPaperId").val()); // 引用论文
            pobjSysSocialRelationsEN.SetMemo(this.memo); // 备注
            var strPdfPageNum = $("#hidPdfPageNum").val();
            if (strPdfPageNum != "") {
                pobjSysSocialRelationsEN.SetPdfPageNum(strPdfPageNum);
            }
            else {
                pobjSysSocialRelationsEN.SetPdfPageNum(1);
            }
        }
        //概念提交审核
        async btnIsSubmit_Click(strKeyId) {
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            this.SubmitRecord(strKeyId);
        }
        //提交判断；
        async SubmitRecord(strSocialId) {
            this.keyId = strSocialId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsSysSocialRelationsWApi_js_1.SysSocialRelations_GetObjBySocialIdAsync)(strSocialId).then((jsonData) => {
                        var objSysSocialRelationsEN = jsonData;
                        //通过session 权限获取权限
                        var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                        var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
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
        async SubmitRecordSave() {
            const strThisFuncName = this.SubmitRecordSave.name;
            //
            var objSysSocialRelationsEN = new clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN();
            objSysSocialRelationsEN.SetSocialId(this.keyId);
            objSysSocialRelationsEN.SetIsSubmit(true);
            objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
                            // HideDialog();
                            this.iShowList.BindGv(clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN._CurrTabName, returnBool.toString());
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
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
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
            const strThisFuncName = this.CancelSubmitRecordSave.name;
            //
            var objSysSocialRelationsEN = new clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN();
            objSysSocialRelationsEN.SetSocialId(strKeyId);
            objSysSocialRelationsEN.SetIsSubmit(false);
            objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
                        this.iShowList.BindGv(clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN._CurrTabName, returnBool.toString());
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
            var strCommandText = this.btnSubmit_Click.name;
            try {
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    switch (strCommandText) {
                        case "添加":
                            const responseText1 = await this.AddNewRecord();
                            break;
                        case "确认添加":
                            //这是一个单表的插入的代码,由于逻辑层太简单,
                            //就把逻辑层合并到控制层,
                            if (this.opType == "AddWithMaxId") {
                                const responseText3 = await this.AddNewRecordWithMaxIdSaveRetrunId().then((jsonData) => {
                                    //CloseWindow();
                                    //var returnBool2: boolean = jsonData;
                                    //if (returnBool2 == true) {
                                    //    HideDialog();
                                    //    this.BindGv_vSysSocialRelations();
                                    //}
                                });
                            }
                            else {
                                const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                    var returnBool = jsonData;
                                    if (returnBool == true) {
                                        //HideDialog();
                                        this.iShowList.BindGv(clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN._CurrTabName, returnBool.toString());
                                    }
                                });
                            }
                            //更新总表3个参数 主键、子表类型、页面操作类型；
                            var strSocialId = $("#hidSocialId").val();
                            const responseText8 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strSocialId, "10", "1", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                            var returnBool8 = !!responseText8;
                            if (returnBool8 == true) {
                                console.log("社会关系数据总表同步成功；");
                            }
                            else {
                                console.log("社会关系数据总表同步失败；");
                            }
                            //添加记录的同时添加历史版本
                            const responseText4 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    CloseWindow();
                                    //alert("添加历史版本出问题！");
                                }
                            });
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
                                    //HideDialog();
                                    this.iShowList.BindGv(clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN._CurrTabName, returnBool.toString());
                                }
                            });
                            //更新总表3个参数 主键、子表类型、页面操作类型；
                            var strSocialId = $("#hidSocialId").val();
                            const responseText9 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strSocialId, "10", "2", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                            var returnBool9 = !!responseText9;
                            if (returnBool9 == true) {
                                console.log("社会关系数据总表同步成功；");
                            }
                            else {
                                console.log("社会关系数据总表同步失败；");
                            }
                            //添加记录的同时添加历史版本
                            const responseText5 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    CloseWindow();
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
        //添加历史版本
        async AddVersionRecordSave() {
            const strThisFuncName = this.AddVersionRecordSave.name;
            //
            var strSocialId = $("#hidSocialId").val();
            var objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN_js_1.clsSysSocialRelationsVerEN();
            objSysSocialRelationsVerEN.SetSocialId(strSocialId);
            this.PutDataToSysSocialRelationsVClass(objSysSocialRelationsVerEN);
            try {
                const responseText2 = await (0, clsSysSocialRelationsVerWApi_js_1.SysSocialRelationsVer_AddNewRecordAsync)(objSysSocialRelationsVerEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " 1 =1 and socialId=" + strSocialId;
                    var intVersionCount = await (0, clsSysSocialRelationsVerWApi_js_1.SysSocialRelationsVer_GetRecCountByCondAsync)(strWhereCond2);
                    var objSysSocialRelationsEN = new clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN();
                    objSysSocialRelationsEN.SetSocialId(strSocialId);
                    objSysSocialRelationsEN.SetVersionCount(intVersionCount);
                    objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
                        throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }
                    const responseText = (0, clsSysSocialRelationsWApi_js_1.SysSocialRelations_UpdateRecordAsync)(objSysSocialRelationsEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            return true;
                        }
                        else {
                            var strInfo = `添加历史版本数不成功!`;
                            alert(strInfo);
                            console.log("添加历史版本数不成功");
                            CloseWindow();
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
        /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
    */
        async AddNewRecord() {
            this.SetKeyReadOnly(false);
            $('#btnOKUpd').attr("disabled", false);
            this.opType = "AddWithMaxId";
            this.btnSubmit_SysSocialRelations = "确认添加";
            this.btnCancel_SysSocialRelations = "取消添加";
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
            this.opType = "AddWithMaxId";
            this.btnSubmit_SysSocialRelations = "确认添加";
            this.btnCancel_SysSocialRelations = "取消添加";
            this.Clear();
            //wucSysSocialRelationsB1.socialId = clsSysSocialRelationsBL.GetMaxStrId_S();
        }
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
    */
        async AddNewRecordWithMaxIdSaveRetrunId() {
            var objSysSocialRelationsEN = new clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN();
            objSysSocialRelationsEN.SetCreateDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd());
            this.PutDataToSysSocialRelationsClass(objSysSocialRelationsEN);
            try {
                const responseText = await (0, clsSysSocialRelationsWApi_js_1.SysSocialRelations_AddNewRecordWithReturnKeyAsync)(objSysSocialRelationsEN);
                var strSocialId = responseText;
                if (strSocialId != "") {
                    //var returnBool: boolean = !!responseText2;
                    //if (returnBool == true) {
                    $("#hidSocialId").val(strSocialId);
                    //添加社会-主题 关系
                    const responseText2 = await this.AddNewRecordSaveRtSysSocial();
                    //var strInfo: string = `添加记录成功!`;
                    //$('#lblResult47').val(strInfo);
                    ////显示信息框
                    //alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText; //一定要有一个返回值，否则会出错！
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
        /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjRTSysSocialRelaEN">数据传输的目的类对象</param>
    */
        PutDataToRTSysSocialRelaClass(pobjRTSysSocialRelaEN) {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strSocialId = $("#hidSocialId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            pobjRTSysSocialRelaEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            pobjRTSysSocialRelaEN.SetTopicId(strTopicId); // 主题编号
            pobjRTSysSocialRelaEN.SetSocialId(strSocialId); // 社会Id
            pobjRTSysSocialRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjRTSysSocialRelaEN.SetUpdUser(strUserId); // 修改人
            pobjRTSysSocialRelaEN.SetMemo(this.memo); // 备注
            pobjRTSysSocialRelaEN.SetClassificationId("0000000000"); // 分类为000000
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSaveRtSysSocial() {
            const strThisFuncName = this.AddNewRecordSaveRtSysSocial.name;
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strSocialId = $("#hidSocialId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var objRTSysSocialRelaEN = new clsRTSysSocialRelaEN_js_1.clsRTSysSocialRelaEN();
            this.PutDataToRTSysSocialRelaClass(objRTSysSocialRelaEN);
            try {
                //同一用户，同一主题 同一社会关系 只能添加一次；
                //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And socialId = '" + strSocialId + "' And updUser = '" + strUserId + "'";
                var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And socialId = '" + strSocialId + "' And updUser = '" + strUserId + "'";
                const responseText = await (0, clsRTSysSocialRelaWApi_js_1.RTSysSocialRela_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `同一主题同一个用户不能重复添加同一个社会关系！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                else {
                    const responseText2 = await (0, clsRTSysSocialRelaWApi_js_1.RTSysSocialRela_AddNewRecordAsync)(objRTSysSocialRelaEN);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        var strInfo = `添加记录成功!`;
                        $('#lblResult46').val(strInfo);
                        //根据ID获取最大数；
                        var strWhereCond2 = " 1 =1 and socialId=" + strSocialId;
                        var intCitationCount = await (0, clsSysSocialRelationsWApi_js_1.SysSocialRelations_GetRecCountByCondAsync)(strWhereCond2);
                        var objSysSocialRelationsEN = new clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN();
                        objSysSocialRelationsEN.SetSocialId(strSocialId);
                        objSysSocialRelationsEN.SetCitationCount(intCitationCount);
                        objSysSocialRelationsEN.sf_UpdFldSetStr = objSysSocialRelationsEN.updFldString; //设置哪些字段被修改(脏字段)
                        if (objSysSocialRelationsEN.socialId == "" || objSysSocialRelationsEN.socialId == undefined) {
                            throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
    exports.AddSysSocialRelationsEx = AddSysSocialRelationsEx;
});