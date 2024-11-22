(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPublicPage/Public_SysSkill.js", "../PagesBase/GraduateEduTopic/SysSkillCRUD.js", "../TS/FunClass/clsDropDownList.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsRTSysSkillRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTSysSkillEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSkillRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSkillWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ResearchTopicSysskillEx = void 0;
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
    //
    //import * as QQ from "q";
    const Public_SysSkill_js_1 = require("../GraduateEduPublicPage/Public_SysSkill.js");
    const SysSkillCRUD_js_1 = require("../PagesBase/GraduateEduTopic/SysSkillCRUD.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsRTSysSkillRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTSysSkillRelaEN.js");
    const clsSysSkillEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsSysSkillEN.js");
    const clsvRTSysSkillEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTSysSkillEN.js");
    const clsvSysSkillEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvSysSkillEN.js");
    const clsRTSysSkillRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTSysSkillRelaWApi.js");
    const clsSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsSysSkillWApi.js");
    const clsvRTSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTSysSkillWApi.js");
    const clsvSysSkillWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* SysSkillCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class ResearchTopicSysskillEx extends SysSkillCRUD_js_1.SysSkillCRUD {
        constructor() {
            super(...arguments);
            //public static mstrListDiv: string = "divDataLst";
            //public static mstrSortvSysSkillBy: string = "skillId";
            //技能列表
            this.mstrListDivPaper = "divSysSkillDataLst";
            //技能
            this.mstrListSysskillDivPaper = "divSysskillDataLst";
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType, strPara) {
            this.BindGv_vSysSkill();
        }
        BindGv_Cache(strType, strPara) {
            console.log("strPara", strPara);
            let strMsg = "";
            switch (strType) {
                case "vSysSkill":
                    alert('该类没有绑定该函数：[this.BindGv_vSysSkill_Cache]！');
                    //this.BindGv_vSysSkill_Cache();
                    break;
                default:
                    strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                    console.error(strMsg);
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
                    //建立缓存
                    // 为查询区绑定下拉框
                    const gvBindDdl = await this.BindDdl4QueryRegion();
                    SysSkillCRUD_js_1.SysSkillCRUD.sortvSysSkillBy = "skillName Asc";
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
        //技能；
        async liSysskillClick() {
            try {
                //主题技能关系
                this.hidSortvRTSysSkillBy = "classificationId Asc,updDate Desc";
                const gvResultPaper = await this.BindGv_vRTSysSkill();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取客观依据列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
    */
        async CombinevSysSkillCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1=1";
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.skillName_q != "") {
                    strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_SkillName} like '% ${this.skillName_q}%'`;
                }
                if (this.operationTypeId_q != "" && this.operationTypeId_q != "0") {
                    strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_OperationTypeId} = '${this.operationTypeId_q}'`;
                }
                if (clsPublocalStorage_js_1.clsPublocalStorage.eduClsTypeId == "0001") {
                    $("#ddlCurrEduCls_q4").hide();
                    $("#ddlPublicViewPoint").show();
                    if ($("#ddlPublicViewPoint") == "1") {
                        strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser} in('${clsPublocalStorage_js_1.clsPublocalStorage.TopicUserList}')`;
                    }
                    else {
                        strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_ShareId} ='03'`;
                    }
                }
                else {
                    //用户
                    if (this.updUser_q != "") {
                        strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_UpdUser} like '% ${this.updUser_q}%'`;
                    }
                }
                if ($("#ddlCurrEduCls_q4").val() != "" && $("#ddlCurrEduCls_q4").val() != "0") {
                    strWhereCond += " And id_CurrEduCls='" + $("#ddlCurrEduCls_q4").val() + "'";
                }
                else {
                    strWhereCond += " And id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
                }
                //只能查询提交的技能数据
                strWhereCond += ` And ${clsvSysSkillEN_js_1.clsvSysSkillEN.con_IsSubmit} = 'true'`;
                //排除获取已存在的关系数据 根据当前用户；
                strWhereCond += ` And skillId not in (select skillId from RTSysSkillRela where topicId = '${strTopicId}' And updUser = '${strUserId}')`;
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
            var strWhereCond = await this.CombinevSysSkillCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvSysSkillObjLst = [];
            try {
                this.recCount = await (0, clsvSysSkillWApi_js_1.vSysSkill_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: SysSkillCRUD_js_1.SysSkillCRUD.sortvSysSkillBy,
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
                    this.objPager.recCount = this.recCount;
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
            var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
            if (strRoleId == "00620003") {
                const Ddl_CurrEduClsStu_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_CurrEduClsStu("ddlCurrEduCls_q4");
            }
            else {
                const Ddl_CurrEduClsTea_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_CurrEduClsTea("ddlCurrEduCls_q4");
            }
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
     <param name = "pobjRTSysSkillRelaEN">数据传输的目的类对象</param>
    */
        PutDataToRTSysSkillRelaClass(pobjRTSysSkillRelaEN) {
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strSkillId = $("#hidSkillId").val();
            pobjRTSysSkillRelaEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            pobjRTSysSkillRelaEN.SetTopicId(strTopicId); // 主题编号
            pobjRTSysSkillRelaEN.SetSkillId(strSkillId); // 技能Id
            pobjRTSysSkillRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjRTSysSkillRelaEN.SetUpdUser(strUserId);
            pobjRTSysSkillRelaEN.SetMemo(this.memo); // 备注
            pobjRTSysSkillRelaEN.SetClassificationId("0000000000"); // 分类为000000
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            const strThisFuncName = this.AddNewRecordSave.name;
            this.divName4List = "divAddNewRecordSave";
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strSkillId = $("#hidSkillId").val();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var objRTSysSkillRelaEN = new clsRTSysSkillRelaEN_js_1.clsRTSysSkillRelaEN();
            this.PutDataToRTSysSkillRelaClass(objRTSysSkillRelaEN);
            try {
                //同一用户，同一主题 同一技能 只能添加一次；
                var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And skillId = '" + strSkillId + "' And updUser = '" + strUserId + "'";
                const responseText = await (0, clsRTSysSkillRelaWApi_js_1.RTSysSkillRela_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `同一主题同一个用户不能重复添加同一个技能！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                else {
                    const responseText2 = await (0, clsRTSysSkillRelaWApi_js_1.RTSysSkillRela_AddNewRecordAsync)(objRTSysSkillRelaEN);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        var strInfo = `添加记录成功!`;
                        $('#lblResult46').val(strInfo);
                        //根据ID获取最大数；
                        var strWhereCond2 = " 1 =1 and skillId=" + strSkillId;
                        var intCitationCount = await (0, clsRTSysSkillRelaWApi_js_1.RTSysSkillRela_GetRecCountByCondAsync)(strWhereCond2);
                        var objSysSkillEN = new clsSysSkillEN_js_1.clsSysSkillEN();
                        objSysSkillEN.SetSkillId(strSkillId);
                        objSysSkillEN.SetCitationCount(intCitationCount);
                        objSysSkillEN.sf_UpdFldSetStr = objSysSkillEN.updFldString; //设置哪些字段被修改(脏字段)
                        if (objSysSkillEN.skillId == "" || objSysSkillEN.skillId == undefined) {
                            throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
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
        //--------------------------------=================================================================--技能
        /* 函数功能:在数据 列表中跳转到某一页
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
     <param name = "intPageIndex">页序号</param>
    */
        //public IndexPageTen(intPageIndex) {
        //    if (intPageIndex == 0) {
        //        intPageIndex = this.objPager.pageCount;
        //    }
        //    console.log("跳转到" + intPageIndex + "页");
        //    this.setCurrPageIndex(intPageIndex, this.divName4Pager);
        //    this.BindGv_vRTSysSkill();
        //}
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
     <returns>条件串(strWhereCond)</returns>
    */
        CombinevRTSysSkillCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //判断主题id
                var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_TopicId} = '${strTopicId}'`;
                }
                var strClassificationId = $("#hidClassificationId").val();
                if (strClassificationId != "") {
                    strWhereCond += ` And ${clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_ClassificationId} = '${strClassificationId}'`;
                }
                var strViewsId = $("#hidViewsId").val();
                if (strViewsId != "") {
                    strWhereCond += ` And ${clsvRTSysSkillEN_js_1.clsvRTSysSkillEN.con_mId} = ${strViewsId}`;
                }
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；
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
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineRTSysSkillRelaCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vRTSysSkill() {
            var strListDiv = this.mstrListSysskillDivPaper; //显示div
            var strWhereCond = await this.CombinevRTSysSkillCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrvRTSysSkillObjLst = [];
            //var arrvUsersObjLst: Array<clsvUsersSimEN> = [];
            try {
                this.recCount = await (0, clsvRTSysSkillWApi_js_1.vRTSysSkill_GetRecCountByCondAsync)(strWhereCond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvRTSysSkillBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvRTSysSkillWApi_js_1.vRTSysSkill_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvRTSysSkillObjLst = jsonData;
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
                var strHtml = await Public_SysSkill_js_1.Public_SysSkill.BindList_vRTSysSkill("06", arrvRTSysSkillObjLst);
                //拼接；
                $("#divSysskillDataLst").html(strHtml);
                if (arrvRTSysSkillObjLst.length > 10) {
                    $("#divPagerSysskill").show();
                    this.objPager.recCount = this.recCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
                //this.BindTab_vRTSysSkill(arrvRTSysSkillObjLst, arrvUsersObjLst);
                console.log("完成BindGv_vRTSysSkill!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vRTSysSkill对象的所有属性值
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
     <param name = "divContainer">显示容器</param>
     <param name = "arrRTSysSkillRelaObjLst">需要绑定的对象列表</param>
    */
        //public async BindTab_vRTSysSkill(arrvRTSysSkillObjLst: Array<clsvRTSysSkillEN>, arrvUsersObjLst: Array<clsvUsersSimEN>) {
        //    var strhtml = "";
        //    var strUserId = clsPublocalStorage.userId;
        //    strhtml += '<div class="info" id="infoSysskill"><div class="title btn-4">';
        //    strhtml += '<div style="float:left;"><a href="#" title="相关技能">相关技能</a></div>';
        //    strhtml += '</div><ul class="artlist">';
        //    var v = 0;//给内容加个序号
        //    for (var i = 0; i < arrvRTSysSkillObjLst.length; i++) {
        //       
        //        var strConceptId = arrvRTSysSkillObjLst[i].skillId;
        //        v++;
        //        strhtml += '<li><span class="rowtit color4">' + v + '.[技能名称]：</span><span class="abstract-text">' + arrvRTSysSkillObjLst[i].skillName + '</span></li>';
        //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[实施过程]：</span><span class="abstract-text">' + arrvRTSysSkillObjLst[i].process + '</span></li>';
        //        strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：';
        //        if (arrvRTSysSkillObjLst[i].okCount != 0) {
        //            strhtml += '点赞数：' + arrvRTSysSkillObjLst[i].okCount + '&nbsp;&nbsp';
        //        }
        //        if (arrvRTSysSkillObjLst[i].appraiseCount != 0) {
        //            //评论
        //            strhtml += '&nbsp;&nbsp;评论数：' + arrvRTSysSkillObjLst[i].appraiseCount;
        //        }
        //        if (arrvRTSysSkillObjLst[i].score != 0) {
        //            //评分
        //            strhtml += '&nbsp;&nbsp;综合评分：' + arrvRTSysSkillObjLst[i].score;
        //        }
        //        if (arrvRTSysSkillObjLst[i].teaScore != 0) {
        //            strhtml += '&nbsp;&nbsp;教师评分：' + arrvRTSysSkillObjLst[i].teaScore;
        //        }
        //        if (arrvRTSysSkillObjLst[i].stuScore != 0) {
        //            strhtml += '&nbsp;&nbsp;学生评分：' + arrvRTSysSkillObjLst[i].stuScore;
        //        }
        //        //引用数
        //        strhtml += '&nbsp;&nbsp;&nbsp;被引用数：' + arrvRTSysSkillObjLst[i].citationCount;
        //        if (arrvRTSysSkillObjLst[i].versionCount != 0) {
        //            strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvRTSysSkillObjLst[i].versionCount;
        //        }
        //        if (arrvRTSysSkillObjLst[i].isSubmit == true) {
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
        //        arrvUsers = arrvUsersObjLst.filter(x => x.userId == arrvRTSysSkillObjLst[i].updUser);//技能引用人
        //        for (var j = 0; j < arrvUsers.length; j++) {
        //            CacitionUserName = arrvUsers[j].userName;
        //            break;
        //        }
        //        //获取技能编辑人；
        //        arrvUsers = arrvUsersObjLst.filter(x => x.userId == arrvRTSysSkillObjLst[i].skillUpdUser);//技能编辑人
        //        for (var j = 0; j < arrvUsers.length; j++) {
        //            UpdUserName = arrvUsers[j].userName;
        //            break;
        //        }
        //        if (arrvRTSysSkillObjLst[i].skillUpdUser == arrvRTSysSkillObjLst[i].updUser) {
        //            strhtml += '&nbsp;&nbsp;&nbsp;编辑引用人：' + UpdUserName;
        //        } else {
        //            strhtml += '&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用人：' + UpdUserName + '&nbsp;/&nbsp;' + CacitionUserName;
        //        }
        //        if (arrvRTSysSkillObjLst[i].skillUpdDate == arrvRTSysSkillObjLst[i].updDate) {
        //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑引用时间：' + arrvRTSysSkillObjLst[i].skillUpdDate;
        //        } else {
        //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用时间：' + arrvRTSysSkillObjLst[i].skillUpdDate + '&nbsp;/&nbsp;' + arrvRTSysSkillObjLst[i].updDate;
        //        }
        //        if (strUserId == arrvRTSysSkillObjLst[i].updUser) {
        //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelSysskillRecordInTab_Click(' + arrvRTSysSkillObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
        //        }
        //        if (arrvRTSysSkillObjLst[i].isSubmit != true) {
        //            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnUpdSysskill_Click("' + arrvRTSysSkillObjLst[i].skillId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
        //        }
        //        if (arrvRTSysSkillObjLst[i].versionCount > 0 && arrvRTSysSkillObjLst[i].versionCount != null) {
        //            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('相关技能历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTSysSkillObjLst[i].skillId + "&Type=08')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
        //        }
        //        strhtml += '</li>';
        //        strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        //    }
        //    strhtml += '</ul></div>';
        //    //拼接；
        //    $("#divSysskillDataLst").html(strhtml);
        //    if (arrvRTSysSkillObjLst.length > 10) {
        //        $("#divPagerSysskill").show();
        //        this.objPager.recCount = this.recCount;
        //        this.objPager.pageSize = this.pageSize;
        //        this.objPager.ShowPagerV2(this, this.divName4Pager);
        //    }
        //}
        /*
    在数据表里删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
    */
        async btnDelSysskillRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                var lngKeyId = Number(strKeyId);
                const responseText = await this.DelRTSysSkillRelaRecord(lngKeyId);
                const responseBindGv = await this.BindGv_vRTSysSkill();
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
        async DelRTSysSkillRelaRecord(lngmId) {
            try {
                const responseText = await (0, clsRTSysSkillRelaWApi_js_1.RTSysSkillRela_DelRecordAsync)(lngmId);
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
        /*
    * 设置排序字段-相当使用ViewState功能
    */
        set hidSortvRTSysSkillBy(value) {
            $("#hidSortvRTSysSkillBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvRTSysSkillBy() {
            return $("#hidSortvRTSysSkillBy").val();
        }
        /**
     * 备注 (Used In Clear())
     **/
        set memo(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4List, "txtMemo", value);
        }
        /**
        * 备注 (Used In PutDataToClass())
        **/
        get memo() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4List, "txtMemo");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
    }
    exports.ResearchTopicSysskillEx = ResearchTopicSysskillEx;
});
