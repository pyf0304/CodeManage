(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPublicPage/Public_Viewpoint.js", "../TS/FunClass/clsDropDownList.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js", "../TS/L0_Entity/UserManage/clsvUsersSimEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ResearchTopicViewpointEx = void 0;
    const Public_Viewpoint_js_1 = require("../GraduateEduPublicPage/Public_Viewpoint.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsRTViewpointRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTViewpointRelaEN.js");
    const clsViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js");
    const clsvRTViewpointRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js");
    const clsvViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvViewpointEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage/clsvUsersSimEN.js");
    const clsRTViewpointRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js");
    const clsViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js");
    const clsvRTViewpointRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js");
    const clsvViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    /* WApiConcept_QUDI_CacheEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class ResearchTopicViewpointEx extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super(...arguments);
            //观点列表
            this.mstrListDivViewpoint = "divViewpointDataLst";
            //个人观点关系
            this.mstrListDivRtViewPointRela = "divRtViewPointRelaDataLst";
            //专家观点
            this.mstrListDivRtExpertViewPointRela = "divRtExpertViewPointRelaDataLst";
            this.RecCount = 0;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 30;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
    */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
                    //const gvResult = await this.BindGv_Concept_Cache();
                    //主题观点关系
                    this.hidSortvRTViewpointRelaBy = "classificationId Asc,updDate Desc";
                    //观点
                    this.hidSortvViewpointBy = "updDate Desc";
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
        //个人观点
        async liViewpointClick() {
            try {
                const gvResultPaper = await this.BindGv_vRTViewpointRela();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取个人观点列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //专家观点
        async liExpertViewpointClick() {
            try {
                const gvResultPaper = await this.BindGv_vRTExpertViewpointRela();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取专家观点列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //////////////////////////////////////////////////////////////////个人观点部分
        //观点查询按钮
        async btnViewpointQuery_Click() {
            const responseObjList = await this.BindGv_vViewpoint();
        }
        /* 根据条件获取相应的记录对象的列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        async BindGv_vViewpoint() {
            var strListDiv = this.mstrListDivViewpoint;
            var strWhereCond = this.CombinevViewpointCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvViewpointObjLst = [];
            try {
                const responseRecCount = await (0, clsvViewpointWApi_js_1.vViewpoint_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: 30,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvViewpointBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvViewpointWApi_js_1.vViewpoint_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvViewpointObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                //var strPageType = $("#hidUserTypeId").val();//页面参数
                //var strhidUserTypeId = $("#hidUserTypeId").val();
                //var strTitle = "";
                ////判断页面参数
                //if (strPageType == "01") {
                //    strTitle = "个人观点";
                //} else if (strPageType == "02") {
                //    //专家观点
                //    //$("#ListTitle").html("当前论文相关的专家观点");
                //    strTitle = "专家观点";
                //}
                //var strhtml = "";
                ////个人观点
                //strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';
                //strhtml += '<div><a href="#" title="' + strTitle + '">' + strTitle + '</a></div>';
                ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加' + strTitle + '" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加' + strTitle + '</button></div>';
                //strhtml += '</div><ul class="artlist">';
                //var v = 0;//给内容加个序号
                //for (var i = 0; i < arrvViewpointObjLst.length; i++) {
                //    //得到viewpointId；
                //    var strViewpointId = arrvViewpointObjLst[i].viewpointId;
                //    v++;
                //    //strhtml += v + ".观点：" + arrvViewpointObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvViewpointObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvViewpointObjLst[i].viewpointTypeName + ":" + arrvViewpointObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvViewpointObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
                //    strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointName + '</span></li>';
                //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + arrvViewpointObjLst[i].viewpointContent + '</span></li>';
                //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvViewpointObjLst[i].viewpointTypeName + ']：</span><span class="abstract-text">' + arrvViewpointObjLst[i].reason + '</span></li>';
                //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑用户]：</span>' + arrvViewpointObjLst[i].userName;
                //    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[编辑时间]：</span>' + arrvViewpointObjLst[i].updDate;
                //    //引用数
                //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;被引用数:' + arrvViewpointObjLst[i].citationCount;
                //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button title="引用' + strTitle + '" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnOkInTab_Click("' + arrvViewpointObjLst[i].viewpointId + '")> <i class="layui-icon" >&#xe642;</i>引用该' + strTitle + '</button>';
                //    strhtml += '</li>';
                //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                //}
                //strhtml += '</ul></div>';
                var strUserTypeId = $("#hidUserTypeId").val();
                var strHtml = await Public_Viewpoint_js_1.Public_Viewpoint.BindList_vViewpoint("02", strUserTypeId, arrvViewpointObjLst);
                //拼接；
                $("#divViewpointDataLst").html(strHtml);
                if (arrvViewpointObjLst.length > 10) {
                    //$("#divPager1").show();
                    this.objPager.RecCount = this.RecCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
                console.log("完成BindGv_vViewpoint!");
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
        CombinevViewpointCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1=1 ";
            var strTopicId = $('#hidTopicRelaId').val();
            var strViewpointId = $("#hidViewpointId").val();
            var strUserId = $("#hidUserId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if ($("#txtViewpointName_q").val() != "") {
                    strWhereCond += ` And ${clsvViewpointEN_js_1.clsvViewpointEN.con_ViewpointName} like '% ${$("#txtViewpointName_q").val()}%'`;
                }
                if (clsPublocalStorage_js_1.clsPublocalStorage.eduClsTypeId == "0001") {
                    $("#ddlCurrEduCls_q1").hide();
                    $("#ddlPublicViewPoint").show();
                    if ($("#ddlPublicViewPoint") == "1") {
                        strWhereCond += ` And ${clsvViewpointEN_js_1.clsvViewpointEN.con_UpdUser} in('${clsPublocalStorage_js_1.clsPublocalStorage.TopicUserList}')`;
                    }
                    else {
                        strWhereCond += ` And ${clsvViewpointEN_js_1.clsvViewpointEN.con_ShareId} ='03'`;
                    }
                }
                else {
                    //用户
                    if ($("#ddlViewUpdName_q").val() != "" && $("#ddlViewUpdName_q").val() != "0") {
                        strWhereCond += " And updUser = '" + $("#ddlViewUpdName_q").val() + "'";
                    }
                }
                if ($("#ddlCurrEduCls_q1").val() != "" && $("#ddlCurrEduCls_q1").val() != "0") {
                    strWhereCond += " And id_CurrEduCls='" + $("#ddlCurrEduCls_q1").val() + "'";
                }
                else {
                    strWhereCond += " And id_CurrEduCls='" + $("#hidId_CurrEduCls").val() + "'";
                }
                //根据传入的usertypeId 来区分是本人观点还是专家观点
                var strhidUserTypeId = $("#hidUserTypeId").val();
                if (strhidUserTypeId != "") {
                    strWhereCond += ` And ${clsvViewpointEN_js_1.clsvViewpointEN.con_UserTypeId} = '${strhidUserTypeId}'`;
                }
                //只能查询提交的观点数据
                strWhereCond += ` And ${clsvViewpointEN_js_1.clsvViewpointEN.con_IsSubmit} = 'true'`;
                //排除获取已存在的关系数据 根据当前用户；
                strWhereCond += ` And viewpointId not in (select viewpointId from RTViewpointRela where topicId = '${strTopicId}' And updUser = '${strUserId}')`;
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 显示vViewpoint对象的所有属性值
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
       <param name = "divContainer">显示容器</param>
       <param name = "arrViewpointObjLst">需要绑定的对象列表</param>
     */
        BindTab_vViewpoint(divContainer, arrvViewpointObjLst) {
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
                    FldName: "viewpointName",
                    ColHeader: "观点名称",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "viewpointContent",
                    ColHeader: "观点内容",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "viewpointTypeName",
                    ColHeader: "观点类型名",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "编辑日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "编辑人",
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
                        btn1.setAttribute("onclick", `btnOkInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2Where(o, arrvViewpointObjLst, arrDataColumn, "viewpointId", "TopicViewpoint");
            //clsCommonFunc4Web.BindTabV2(o, arrvViewpointObjLst, arrDataColumn, "viewpointId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        async btnAddRela_Click() {
            var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
            if (strRoleId == "00620003") {
                const Ddl_CurrEduClsStu_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_CurrEduClsStu("ddlCurrEduCls_q1");
            }
            else {
                const Ddl_CurrEduClsTea_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_CurrEduClsTea("ddlCurrEduCls_q1");
            }
            var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
            //根据传入的usertypeId 来区分是本人观点还是专家观点
            var strhidUserTypeId = $("#hidUserTypeId").val();
            const Ddl_UserId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_ViewpointUserIdByPara_Cache("ddlViewUpdName_q", objUsers_Cond, strhidUserTypeId);
            const responseObjList = await this.BindGv_vViewpoint();
        }
        //确定选择的观点 并添加到关系表中
        btnOkInTab_Click(strkeyId) {
            //存放Id
            $("#hidViewpointId").val(strkeyId);
            //执行添加关系方法
            this.AddNewRecordSaveViewpointRela();
        }
        /* 添加新记录
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
     */
        async AddNewRecordSaveViewpointRela() {
            var strTopicId = $('#hidTopicRelaId').val();
            var strViewpointId = $("#hidViewpointId").val();
            var strUserId = $("#hidUserId").val();
            var objRTViewpointRelaEN = new clsRTViewpointRelaEN_js_1.clsRTViewpointRelaEN();
            this.PutDataToRTViewpointRelaClass(objRTViewpointRelaEN);
            try {
                //同一用户，同一主题 同一观点 只能添加一次；
                var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "' And updUser = '" + strUserId + "'";
                //var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "'";
                const responseText = await (0, clsRTViewpointRelaWApi_js_1.RTViewpointRela_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `同一主题不能重复添加同一个观点！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsRTViewpointRelaWApi_js_1.RTViewpointRela_AddNewRecordAsync)(objRTViewpointRelaEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加成功!`;
                    $('#lblResult40').val(strInfo);
                    //根据ID获取最大数；
                    var strWhereCond2 = " 1 =1 and viewpointId=" + strViewpointId;
                    var intCitationCount = await (0, clsRTViewpointRelaWApi_js_1.RTViewpointRela_GetRecCountByCondAsync)(strWhereCond2);
                    var objViewpointEN = new clsViewpointEN_js_1.clsViewpointEN();
                    objViewpointEN.viewpointId = strViewpointId;
                    objViewpointEN.citationCount = intCitationCount;
                    objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                        throw "关键字不能为空!";
                    }
                    const responseText = await (0, clsViewpointWApi_js_1.Viewpoint_UpdateRecordAsync)(objViewpointEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            this.BindGv_vRTViewpointRela();
                        }
                        else {
                            var strInfo = `点赞不成功!`;
                            alert(strInfo);
                            console.log("点赞不成功");
                        }
                    });
                    HideDialogTwo();
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加不成功!`;
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
        /* 函数功能:把界面上的属性数据传到类对象中
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
       <param name = "pobjRTViewpointRelaEN">数据传输的目的类对象</param>
     */
        PutDataToRTViewpointRelaClass(pobjRTViewpointRelaEN) {
            var strTopicId = $("#hidTopicRelaId").val();
            var strId_CurrEduCls = $("#hidId_CurrEduCls").val();
            var strViewpointId = $("#hidViewpointId").val();
            var strUserId = $("#hidUserId").val();
            pobjRTViewpointRelaEN.topicId = strTopicId; // 主题编号
            pobjRTViewpointRelaEN.id_CurrEduCls = strId_CurrEduCls;
            pobjRTViewpointRelaEN.viewpointId = strViewpointId; // 观点Id
            pobjRTViewpointRelaEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate(); // 修改日期
            pobjRTViewpointRelaEN.updUser = strUserId; // 修改用户Id// 修改用户Id
            pobjRTViewpointRelaEN.classificationId = "0000000000"; // 分类为000000
            //pobjRTViewpointRelaEN.memo = this.memo;// 备注
        }
        /*
     * 设置排序字段-相当使用ViewState功能
    */
        set hidSortvViewpointBy(value) {
            $("#hidSortvViewpointBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvViewpointBy() {
            return $("#hidSortvViewpointBy").val();
        }
        /* 函数功能:在数据 列表中跳转到某一页 观点列表
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
      <param name = "intPageIndex">页序号</param>
    */
        IndexPageOne(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.setCurrPageIndex(intPageIndex, this.divName4Pager);
            this.BindGv_vViewpoint();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////专家------观点关系
        //添加观点 展示观点列表数据
        async btnAddExperRela_Click() {
            const responseObjList = await this.BindGv_vRTExpertViewpointRela();
        }
        /* 把所有的查询控件内容组合成一个条件串
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
       <returns>条件串(strWhereCond)</returns>
     */
        CombinevRTExpertViewpointRelaCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //判断主题id
                var strTopicId = $("#hidTopicRelaId").val();
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicId} = '${strTopicId}'`;
                }
                var strClassificationId = $("#hidClassificationId").val();
                if (strClassificationId != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ClassificationId} = '${strClassificationId}'`;
                }
                var strViewsId = $("#hidViewsId").val();
                if (strViewsId != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_mId} = ${strViewsId}`;
                }
                //只显示专家观点数据
                strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UserTypeId} ='02'`;
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；
                //判断角色 
                //管理员
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId() == "00620001") {
                    //       $("#btnDelRecord").show();
                }
                else if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId() == "00620002") {
                    //教师
                    //         $("#btnDelRecord").show();
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    //  strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";
                }
                else {
                    //学生； 
                    //         $("#btnDelRecord").show();
                    //   strWhereCond += ` And ${clsvRTViewpointRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineRTViewpointRelaCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的记录对象的列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
      */
        async BindGv_vRTExpertViewpointRela() {
            var strListDiv = this.mstrListDivRtExpertViewPointRela;
            var strWhereCond = this.CombinevRTExpertViewpointRelaCondition();
            var intCurrPageIndex = this.CurrPageIndexViewpoint; //获取当前页
            var arrvRTViewpointRelaObjLst = [];
            try {
                const responseRecCount = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvRTViewpointRelaBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvRTViewpointRelaObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                this.BindList_vRTViewpointRela("02", arrvRTViewpointRelaObjLst);
                //this.BindTab_vRTExpertViewpointRela(strListDiv, arrvRTViewpointRelaObjLst);
                console.log("完成BindGv_vRTViewpointRela!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////主题观点关系
        /* 观点列表表头排序；
     */
        async SortBy(strSortByFld) {
            if (this.hidSortvViewpointBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvViewpointBy.indexOf("Asc") >= 0) {
                    this.hidSortvViewpointBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvViewpointBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvViewpointBy = `${strSortByFld} Asc`;
            }
            const responseText2 = await this.BindGv_vViewpoint();
        }
        /* 把所有的查询控件内容组合成一个条件串
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
       <returns>条件串(strWhereCond)</returns>
     */
        CombinevRTViewpointRelaCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //判断主题id
                var strTopicId = $("#hidTopicRelaId").val();
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicId} = '${strTopicId}'`;
                }
                var strClassificationId = $("#hidClassificationId").val();
                if (strClassificationId != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ClassificationId} = '${strClassificationId}'`;
                }
                //else {
                //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_ClassificationId} = '0000000000'`;
                //}
                var strViewsId = $("#hidViewsId").val();
                if (strViewsId != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_mId} = ${strViewsId}`;
                }
                //只显示个人观点数据
                strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UserTypeId} ='01'`;
                //读取session角色 来判断绑定不同数据列表
                //判断角色 
                //管理员
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId() == "00620001") {
                    //     $("#btnDelRecord").show();
                }
                else if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId() == "00620002") {
                    //教师
                    //    $("#btnDelRecord").show();
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                    //     strWhereCond += "And updUser in ( select stuID from vCurrEduClsStu where id_CurrEduCls in ( select id_CurrEduCls from vCurrEduClsTeacher where teacherID='" + objvUserRoleRelation.userId + "' And isEffective='1') And isEffective='1')";
                }
                else {
                    //学生； 
                    //  $("#btnDelRecord").show();
                    //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_UpdUser} = '${objvUserRoleRelation.userId}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineRTViewpointRelaCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的记录对象的列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
      */
        async BindGv_vRTViewpointRela() {
            var strListDiv = this.mstrListDivRtViewPointRela;
            var strWhereCond = this.CombinevRTViewpointRelaCondition();
            var intCurrPageIndex = this.CurrPageIndexViewpoint; //获取当前页
            var arrvRTViewpointRelaObjLst = [];
            try {
                const responseRecCount = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvRTViewpointRelaBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvRTViewpointRelaObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                this.BindList_vRTViewpointRela("01", arrvRTViewpointRelaObjLst);
                console.log("完成BindGv_vRTViewpointRela!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        async BindList_vRTViewpointRela(strVType, arrvRTViewpointRelaObjLst) {
            //var strPageType = strVType;//页面参数
            //var strUserId = clsPubSessionStorage.GetSession_UserId();
            //var strTitle = "";
            ////判断页面参数
            //if (strPageType == "01") {
            //    strTitle = "个人观点";
            //} else if (strPageType == "02") {
            //    //专家观点
            //    //$("#ListTitle").html("当前论文相关的专家观点");
            //    strTitle = "专家观点";
            //}
            //var strhtml = "";
            ////个人观点
            //strhtml += '<div class="info" id="infoViewpoint"><div class="title btn-3">';
            //strhtml += '<div style="float:left;"><a href="#" title="' + strTitle + '">' + strTitle + '</a></div>';
            ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加' + strTitle + '" class="layui-btn layui-btn-warm layui-btn-xs" onclick = btnAddNewRecord_Click();> <i class="layui-icon" ></i>添加' + strTitle + '</button></div>';
            //strhtml += '</div><ul class="artlist">';
            //var v = 0;//给内容加个序号
            //for (var i = 0; i < arrvRTViewpointRelaObjLst.length; i++) {
            //    //得到viewpointId；
            //    var strViewpointId = arrvRTViewpointRelaObjLst[i].viewpointId;
            //    v++;
            //    var strViewpointContent = arrvRTViewpointRelaObjLst[i].viewpointContent;
            //    var strReason = arrvRTViewpointRelaObjLst[i].reason;
            //    strViewpointContent = strViewpointContent.replace(/\r\n/g, this.strBr);
            //    strViewpointContent = strViewpointContent.replace(/\n/g, this.strBr);
            //    strReason = strReason.replace(/\r\n/g, this.strBr);
            //    strReason = strReason.replace(/\n/g, this.strBr);
            //    //strhtml += v + ".观点：" + arrvViewpointObjLst[i].viewpointName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>" + "&nbsp;内容:" + arrvViewpointObjLst[i].viewpointContent + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;" + arrvViewpointObjLst[i].viewpointTypeName + ":" + arrvViewpointObjLst[i].reason + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%>&nbsp;所属主题：" + arrvViewpointObjLst[i].topicName + "</br><hr size=1 style=color:blue;border-style:dotted;width:100%></br>";
            //    strhtml += '<li><span class="rowtit color3">' + v + '.[观点名称]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst[i].viewpointName + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[观点内容]：</span><span class="abstract-text">' + strViewpointContent + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[' + arrvRTViewpointRelaObjLst[i].viewpointTypeName + ']：</span><span class="abstract-text">' + strReason + '</span></li>';
            //    //strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[依据]：</span><span class="abstract-text">' + arrvRTViewpointRelaObjLst[i].viewpointContent + '</span></li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[统计]：';
            //    if (arrvRTViewpointRelaObjLst[i].okCount != 0) {
            //        strhtml += '点赞数：' + arrvRTViewpointRelaObjLst[i].okCount + '&nbsp;&nbsp';
            //    }
            //    if (arrvRTViewpointRelaObjLst[i].appraiseCount != 0) {
            //        //评论
            //        strhtml += '&nbsp;&nbsp;评论数：' + arrvRTViewpointRelaObjLst[i].appraiseCount;
            //    }
            //    if (arrvRTViewpointRelaObjLst[i].score != 0) {
            //        //评分
            //        strhtml += '&nbsp;&nbsp;综合评分：' + arrvRTViewpointRelaObjLst[i].score;
            //    }
            //    if (arrvRTViewpointRelaObjLst[i].teaScore != 0) {
            //        strhtml += '&nbsp;&nbsp;教师评分：' + arrvRTViewpointRelaObjLst[i].teaScore;
            //    }
            //    if (arrvRTViewpointRelaObjLst[i].stuScore != 0) {
            //        strhtml += '&nbsp;&nbsp;学生评分：' + arrvRTViewpointRelaObjLst[i].stuScore;
            //    }
            //    //引用数
            //    strhtml += '&nbsp;&nbsp;&nbsp;被引用数：' + arrvRTViewpointRelaObjLst[i].citationCount;
            //    if (arrvRTViewpointRelaObjLst[i].versionCount != 0) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;历史版本数：' + arrvRTViewpointRelaObjLst[i].versionCount;
            //    }
            //    if (arrvRTViewpointRelaObjLst[i].isSubmit == true) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color5">已提交</span>';
            //    }
            //    else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit colorRed">未提交</span>';
            //    }
            //    strhtml += '</li>';
            //    strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[操作]：';
            //    if (arrvRTViewpointRelaObjLst[i].viewsUserId == arrvRTViewpointRelaObjLst[i].updUser) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;编辑引用人：' + arrvRTViewpointRelaObjLst[i].ViewsUserName;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用人：' + arrvRTViewpointRelaObjLst[i].ViewsUserName + '&nbsp;/&nbsp;' + arrvRTViewpointRelaObjLst[i].userName;
            //    }
            //    if (arrvRTViewpointRelaObjLst[i].viewsDate == arrvRTViewpointRelaObjLst[i].updDate) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑引用时间：' + arrvRTViewpointRelaObjLst[i].viewsDate;
            //    } else {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;编辑&nbsp;/&nbsp;引用时间：' + arrvRTViewpointRelaObjLst[i].viewsDate + '&nbsp;/&nbsp;' + arrvRTViewpointRelaObjLst[i].updDate;
            //    }
            //    if (strUserId == arrvRTViewpointRelaObjLst[i].updUser) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="移除引用" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelViewPointRelaRecordInTab_Click(' + arrvRTViewpointRelaObjLst[i].mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
            //    }
            //    if (arrvRTViewpointRelaObjLst[i].isSubmit != true) {
            //        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick=btnUpdViewPoint_Click("' + arrvRTViewpointRelaObjLst[i].viewpointId + '") > <i class="layui-icon" >&#xe642;</i>修改</button>';
            //    }
            //    if (arrvRTViewpointRelaObjLst[i].versionCount > 0 && arrvRTViewpointRelaObjLst[i].versionCount != null) {
            //        strhtml += "&nbsp;&nbsp;<button style=\"float:right;\" class=\"layui-btn layui-btn-warm layui-btn-xs\" onclick=\"xadmin.open('" + strTitle + "历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + arrvRTViewpointRelaObjLst[i].viewpointId + "&Type=03')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
            //    }
            //    strhtml += '</li>';
            //    strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
            //}
            //strhtml += '</ul></div>';
            $("#hidPageType").val(strVType);
            var strUserTypeId = strVType;
            var strHtml = "";
            if (arrvRTViewpointRelaObjLst.length > 0) {
                strHtml = await Public_Viewpoint_js_1.Public_Viewpoint.BindList_vRTViewpointRela("06", strUserTypeId, arrvRTViewpointRelaObjLst);
            }
            //拼接；
            if (strVType == "01") {
                $("#divRtViewPointRelaDataLst").html(strHtml);
                if (arrvRTViewpointRelaObjLst.length > 10) {
                    $("#divPagerViewpoint").show();
                    this.objPager.RecCount = this.RecCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
            }
            else if (strVType == "02") {
                $("#divRtExpertViewPointRelaDataLst").html(strHtml);
                if (arrvRTViewpointRelaObjLst.length > 10) {
                    $("#divExpertPagerViewpoint").show();
                    this.objPager.RecCount = this.RecCount;
                    this.objPager.pageSize = this.pageSize;
                    this.objPager.ShowPagerV2(this, this.divName4Pager);
                }
            }
        }
        async btnDelViewPointRelaRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                var lngKeyId = Number(strKeyId);
                var strUserId = $("#hidUserId").val();
                //var strTopicId = $("#hidTopicRelaId").val();
                //var strWhereCond = ` 1=1 And ${clsRTUserRelaEN.con_TopicId} = '${strTopicId}' And ${clsRTUserRelaEN.con_UserId} ='${strUserId}'`;
                //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
                const responseText1 = (0, clsRTViewpointRelaWApi_js_1.RTViewpointRela_GetObjBymIdAsync)(lngKeyId).then((jsonData) => {
                    var objRtViewpointEN = jsonData;
                    if (objRtViewpointEN != null) {
                        if (objRtViewpointEN.updUser == strUserId) {
                            //01 个人
                            if ($("#hidPageType").val() == "01") {
                                const responseText = this.DelViewPointRelaRecord(lngKeyId, "01");
                            }
                            else if ($("#hidPageType").val() == "02") {
                                const responseText = this.DelViewPointRelaRecord(lngKeyId, "02");
                            }
                        }
                        else {
                            //成员
                            var strMsg = `您只能删除自己添加的数据！`;
                            alert(strMsg);
                            return;
                        }
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        //删除专家观点关系数据
        async btnDelExpertViewPointRelaRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                var lngKeyId = Number(strKeyId);
                var strUserId = $("#hidUserId").val();
                //根据当前登录人和主题Id 查询主题用户角色是组长还是成员；
                const responseText1 = (0, clsRTViewpointRelaWApi_js_1.RTViewpointRela_GetObjBymIdAsync)(lngKeyId).then((jsonData) => {
                    var objRtExpertViewpointEN = jsonData;
                    if (objRtExpertViewpointEN != null) {
                        if (objRtExpertViewpointEN.updUser == strUserId) {
                            //01 个人
                            const responseText = this.DelViewPointRelaRecord(lngKeyId, "02");
                            // const responseText2 = await this.BindGv_vRTPaperRela();
                        }
                        else {
                            //成员
                            var strMsg = `您只能删除自己添加的数据！`;
                            alert(strMsg);
                            return;
                        }
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字删除记录  type 01 个人 02专家
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        DelViewPointRelaRecord(lngmId, TypeId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsRTViewpointRelaWApi_js_1.RTViewpointRela_DelRecordAsync)(lngmId).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            //type 01 个人 02专家
                            if (TypeId == "01") {
                                //个人
                                this.BindGv_vRTViewpointRela();
                            }
                            else {
                                //专家
                                this.BindGv_vRTExpertViewpointRela();
                            }
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
        //分页数据
        /* 函数功能:在数据 列表中跳转到某一页 观点列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
     <param name = "intPageIndex">页序号</param>
    */
        IndexPageSix(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.setCurrPageIndex(intPageIndex, this.divName4Pager);
            this.BindGv_vRTViewpointRela();
        }
        /* 观点 个人 专家
       */
        async SortByViewpoint(strSortByFld) {
            if (this.hidSortvViewpointBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvViewpointBy.indexOf("Asc") >= 0) {
                    this.hidSortvViewpointBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvViewpointBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvViewpointBy = `${strSortByFld} Asc`;
            }
            const responseText2 = await this.BindGv_vViewpoint();
        }
        /*主题个人观点关系
       */
        async SortByRTViewpoint(strSortByFld) {
            if (this.hidSortvRTViewpointRelaBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvRTViewpointRelaBy.indexOf("Asc") >= 0) {
                    this.hidSortvRTViewpointRelaBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvRTViewpointRelaBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvRTViewpointRelaBy = `${strSortByFld} Asc`;
            }
            const responseText2 = await this.BindGv_vRTViewpointRela();
        }
        /*主题专家关系
      */
        async SortByRTExpertViewpoint(strSortByFld) {
            if (this.hidSortvRTViewpointRelaBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvRTViewpointRelaBy.indexOf("Asc") >= 0) {
                    this.hidSortvRTViewpointRelaBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvRTViewpointRelaBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvRTViewpointRelaBy = `${strSortByFld} Asc`;
            }
            const responseText2 = await this.BindGv_vRTExpertViewpointRela();
        }
        /*
     * 设置排序字段-相当使用ViewState功能 主题观点关系
    */
        set hidSortvRTViewpointRelaBy(value) {
            $("#hidSortvRTViewpointRelaBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvRTViewpointRelaBy() {
            return $("#hidSortvRTViewpointRelaBy").val();
        }
        /*
       * 获取当前页序号
      */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
       * 获取当前页序号-------观点
      */
        get CurrPageIndexViewpoint() {
            return $("#hidCurrPageIndexViewpoint").val();
        }
        /*
        * 设置当前页序号-------观点
       */
        set CurrPageIndexViewpoint(value) {
            $("#hidCurrPageIndexViewpoint").val(value);
        }
    }
    exports.ResearchTopicViewpointEx = ResearchTopicViewpointEx;
});
