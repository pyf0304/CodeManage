///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js", "../TS/L0_Entity/ParameterTable/clsViewpointTypeEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js", "../TS/L3_ForWApi/ParameterTable/clsViewpointTypeWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPager.js", "../TS/PubFun/clsPubSessionStorage.js", "./Viewpoint_QUDI.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ResearchTopicAdd = void 0;
    const clsvRTViewpointRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js");
    const clsViewpointTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsViewpointTypeEN.js");
    const clsRTViewpointRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js");
    const clsvRTViewpointRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js");
    const clsViewpointTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsViewpointTypeWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPager_js_1 = require("../TS/PubFun/clsPager.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const Viewpoint_QUDI_js_1 = require("./Viewpoint_QUDI.js");
    /* Viewpoint_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class ResearchTopicAdd extends Viewpoint_QUDI_js_1.Viewpoint_QUDI {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.objPager = new clsPager_js_1.clsPager();
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
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                if (strUserId != "") {
                    $("#hidUserId").val(strUserId);
                    //1、为下拉框设置数据源,绑定列表数据
                    //const ddl_ViewpointTypeId = await this.BindDdl_ViewpointTypeId("ddlViewpointTypeId");
                    //const ddl_ViewpointTypeId_q = await this.BindDdl_ViewpointTypeId("ddlViewpointTypeId_q");
                    this.hidSortvViewpointBy = "viewpointName Asc";
                    this.hidSortvRTViewpointRelaBy = "viewpointName Asc";
                    //var strWhereCond = this.CombinevViewpointCondition();
                    //const responseText = await vViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //    this.RecCount = jsonData;
                    //});
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vRTViewpointRela();
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
        async btnQuery_Click(strListDiv) {
            var strWhereCond = this.CombinevRTViewpointRelaCondition();
            try {
                const responseRecCount = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: 1,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvRTViewpointRelaBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    var arrvRTViewpointRelaObjLst = jsonData;
                    this.BindTab_vRTViewpointRela(this.mstrListDiv, arrvRTViewpointRelaObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[ViewpointType]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_ViewpointTypeId(ddlViewpointTypeId, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlViewpointTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlViewpointTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsViewpointTypeWApi_js_1.ViewpointType_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrViewpointTypeObjLst = jsonData;
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlViewpointTypeId, arrViewpointTypeObjLst, clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeId, clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeName, "观点类型");
                        console.log("完成BindDdl_ViewpointTypeId!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        btnokRecord_Click() {
            this.AddNewRecordSave();
        }
        /* 把所有的查询控件内容组合成一个条件串
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
      <returns>条件串(strWhereCond)</returns>
    */
        CombinevRTViewpointRelaCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strTopicId = $("#hidTopicRelaId").val(); //得到主题id
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.ViewpointName_q != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointName} like '% ${this.ViewpointName_q}%'`;
                }
                //if (this.ViewpointTypeId_q != "" && this.ViewpointTypeId_q != "0") {
                //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_ViewpointTypeId} = '${this.ViewpointTypeId_q}'`;
                //}
                if (this.TopicName_q != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicName} like '% ${this.TopicName_q}%'`;
                }
                //根据主题查询观点关系;
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicId} = '${strTopicId}'`;
                }
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                    $("#btnDelRecord").show();
                }
                else {
                    //学生； //教师
                    $("#btnDelRecord").show();
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_UpdUser} = '${strUserId}'`;
                    //学生00620003
                    // strWhereCond += ` And ${clsResearchTopicEN.con_TopicProposePeople} = '${strUserId}'`;
                }
                $("#hidUserId").val(strUserId);
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
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevRTViewpointRelaCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
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
            //if (arrvRTViewpointRelaObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_vRTViewpointRela(strListDiv, arrvRTViewpointRelaObjLst);
                console.log("完成BindGv_vRTViewpointRela!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
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
                var bolresult = false;
                var strKeyList;
                if (arrKeyIds.length == 0)
                    return "";
                strKeyList = "";
                for (var i = 0; i < arrKeyIds.length; i++) {
                    if (i == 0)
                        strKeyList = strKeyList + "" + arrKeyIds[i].toString() + "";
                    else
                        strKeyList += "," + "" + arrKeyIds[i].toString() + "";
                }
                // 删除RTViewpointRela本表中与当前对象有关的记录
                var strWhereCond = " mId in (" + strKeyList + ")";
                var arrvRTViewpointRelaObjLst = [];
                const responseObjLst = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvRTViewpointRelaObjLst = jsonData;
                    //循环列表，判断数据是否是当前用户 ，是则可以删除；
                    //判断权限、管理员教师可以删除、
                    var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                    var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                    //管理员 判断角色 
                    if (strRoleId == "00620001" || strRoleId == "00620002") {
                        this.DelMultiRecord(arrKeyIds);
                        this.BindGv_vRTViewpointRela();
                    }
                    else {
                        //学生00620003
                        var objvRTViewpointRela = new clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN();
                        //循环判断数据用户不是登录用户则提示不可以删除
                        for (objvRTViewpointRela of arrvRTViewpointRelaObjLst) {
                            //如果存在不相同就提示不可删除；
                            if (objvRTViewpointRela.updUser != strUserId) {
                                alert("不能删除别人主题观点关系！");
                                bolresult = true;
                                return;
                            }
                        }
                        if (bolresult == true) {
                            return;
                        }
                        else {
                            this.DelMultiRecord(arrKeyIds);
                            this.BindGv_vRTViewpointRela();
                        }
                    }
                });
                //const responseText = await this.DelMultiRecord(arrKeyIds);
                //const responseText2 = await this.BindGv_vRTViewpointRela();
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
        DelMultiRecord(arrmId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsRTViewpointRelaWApi_js_1.RTViewpointRela_DelRTViewpointRelasAsync)(arrmId).then((jsonData) => {
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
        /* 显示vRTViewpointRela对象的所有属性值
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        <param name = "divContainer">显示容器</param>
        <param name = "arrRTViewpointRelaObjLst">需要绑定的对象列表</param>
      */
        BindTab_vRTViewpointRela(divContainer, arrvRTViewpointRelaObjLst) {
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
                //{
                //    FldName: "viewpointContent",
                //    ColHeader: "观点内容",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "viewpointTypeName",
                    ColHeader: "观点类型名",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "reason",
                //    ColHeader: "理由",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "source",
                //    ColHeader: "来源",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "proposePeople",
                //    ColHeader: "提出人",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "topicName",
                    ColHeader: "栏目主题",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "topicContent",
                //    ColHeader: "主题内容",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "topicProposePeople",
                //    ColHeader: "主题提出人",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
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
                    FldName: "",
                    ColHeader: "详情",
                    Text: "详情", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnDetailInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
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
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvRTViewpointRelaObjLst, arrDataColumn, "mId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        btnDetailInTab_Click(strKeyId) {
            if (strKeyId == "") {
                alert("请选择需要查看的记录！");
                return;
            }
            var lngKeyId = Number(strKeyId);
            this.RtViewpointRelaDetailRecord(lngKeyId);
        }
        /* 根据关键字获取相应的记录的对象
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
      <param name = "sender">参数列表</param>
    */
        RtViewpointRelaDetailRecord(lngmId) {
            this.KeyId = lngmId.toString();
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetObjBymIdAsync)(lngmId).then((jsonData) => {
                        var objvRTViewpointRelaEN = jsonData;
                        // //显示当前数据；
                        $("#txtTopicNameDetail").html(objvRTViewpointRelaEN.topicName);
                        $("#txtTopicContentDetail").html(objvRTViewpointRelaEN.topicContent);
                        $("#txtViewpointNameDetail").html(objvRTViewpointRelaEN.viewpointName);
                        $("#txtViewpointTypeNameDetail").html(objvRTViewpointRelaEN.viewpointTypeName);
                        $("#txtViewpointContentDetail").html(objvRTViewpointRelaEN.viewpointContent);
                        $("#txtReasonDetail").html(objvRTViewpointRelaEN.reason);
                        $("#txtSourceDetail").html(objvRTViewpointRelaEN.source);
                    });
                }
                catch (e) {
                    console.error(e);
                    var strMsg = `当前无数据获取失败,${e}.`;
                    alert(strMsg);
                }
            });
        }
        //   /* 根据条件获取相应的记录对象的列表
        //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
        //*/
        //   public async BindGv_vViewpoint() {
        //       var strListDiv: string = this.mstrListDiv;
        //       var strWhereCond = this.CombinevViewpointCondition();
        //       var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
        //       var arrvViewpointObjLst: Array<clsvViewpointEN> = [];
        //       try {
        //           const responseRecCount = await vViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
        //               this.RecCount = jsonData;
        //           });
        //           var objPagerPara: stuPagerPara = {
        //               pageIndex: intCurrPageIndex,
        //               pageSize: this.pageSize,
        //               whereCond: strWhereCond,
        //               orderBy: this.hidSortvViewpointBy
        //           };
        //           const responseObjLst = await vViewpoint_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
        //               arrvViewpointObjLst = <Array<clsvViewpointEN>>jsonData;
        //           });
        //       }
        //       catch (e) {
        //           console.error('catch(e)=');
        //           console.error(e);
        //           var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //           alert(strMsg);
        //       }
        //       if (arrvViewpointObjLst.length == 0) {
        //           var strMsg: string = `当前记录数不存在`;
        //           alert(strMsg);
        //           return;
        //       }
        //       try {
        //           this.BindTab_vViewpoint(strListDiv, arrvViewpointObjLst);
        //           console.log("完成BindGv_vViewpoint!");
        //       }
        //       catch (e) {
        //           console.error('catch(e)=');
        //           console.error(e);
        //           var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //           alert(strMsg);
        //       }
        //   }
        //   /* 把所有的查询控件内容组合成一个条件串
        // (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        //  <returns>条件串(strWhereCond)</returns>
        //*/
        //   public CombinevViewpointCondition(): string {
        //       //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //       var strTopicId = $('#hidTopicRelaId').val();
        //       var strViewpointId = $("#hidViewpointId").val();
        //       var strUserId = $("#hidUserId").val();
        //       //例如 1 = 1 && userName = '张三'
        //       var strWhereCond: string = " 1 = 1 ";
        //       //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        //       try {
        //           if (this.ViewpointName_q != "") {
        //               strWhereCond += ` And ${clsvViewpointEN.con_ViewpointName} like '% ${this.ViewpointName_q}%'`;
        //           }
        //           if (this.ViewpointTypeId_q != "" && this.ViewpointTypeId_q != "0") {
        //               strWhereCond += ` And ${clsvViewpointEN.con_ViewpointTypeId} = '${this.ViewpointTypeId_q}'`;
        //           }
        //           //排除获取已存在的关系数据
        //           strWhereCond += ` And viewpointId not in (select viewpointId from RTViewpointRela where topicId = '${strTopicId}' And updUser = '${strUserId}')`;
        //           //if (this.Reason_q != "") {
        //           //    strWhereCond += ` And ${clsvViewpointEN.con_Reason} like '% ${this.Reason_q}%'`;
        //           //}
        //           //if (this.VPProposePeople_q != "") {
        //           //    strWhereCond += ` And ${clsvViewpointEN.con_VPProposePeople} like '% ${this.VPProposePeople_q}%'`;
        //           //}
        //       }
        //       catch (objException) {
        //           var strMsg: string = `(errid:WiTsCs0002)在组合查询条件(CombineViewpointCondition)时出错!请联系管理员!${objException}`;
        //           throw strMsg;
        //       }
        //       return strWhereCond;
        //   }
        //   /* 添加新记录
        //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
        // */
        //   public async AddNewRecordSave() {
        //       var strTopicId = $('#hidTopicRelaId').val();
        //       var strViewpointId = $("#hidViewpointId").val();
        //       var strUserId = $("#hidUserId").val();
        //       var objRTViewpointRelaEN: clsRTViewpointRelaEN = new clsRTViewpointRelaEN();
        //       this.PutDataToRTViewpointRelaClass(objRTViewpointRelaEN);
        //       try {
        //           //同一用户 同一主题 同一观点 只能添加一次；
        //           var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And viewpointId = '" + strViewpointId + "' And updUser = '" + strUserId+"'";
        //           const responseText = await RTViewpointRela_IsExistRecordAsync(strWhere);
        //           var bolIsExist: boolean = responseText;
        //           if (bolIsExist == true) {
        //               var strMsg: string = `同一主题不能重复添加同一个观点！`;
        //               alert(strMsg);
        //               return responseText;//一定要有一个返回值，否则会出错！
        //           }
        //           const responseText2 = await RTViewpointRela_AddNewRecordAsync(objRTViewpointRelaEN);
        //           var returnBool: boolean = !!responseText2;
        //           if (returnBool == true) {
        //               var strInfo: string = `添加成功!`;
        //               $('#lblResult40').val(strInfo);
        //               //显示信息框
        //               alert(strInfo);
        //               window.location.href = "../GraduateEdu/ResearchTopic_QUDI_TS";
        //           }
        //           else {
        //               var strInfo: string = `添加不成功!`;
        //               $('#lblResult40').val(strInfo);
        //               //显示信息框
        //               alert(strInfo);
        //           }
        //           return responseText2;//一定要有一个返回值，否则会出错！
        //       }
        //       catch (e) {
        //           console.error('catch(e)=');
        //           console.error(e);
        //           var strMsg: string = `添加记录不成功,${e}.`;
        //           alert(strMsg);
        //       }
        //       return true;//一定要有一个返回值，否则会出错！
        //   }
        //   /* 函数功能:把界面上的属性数据传到类对象中
        //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        //  <param name = "pobjRTViewpointRelaEN">数据传输的目的类对象</param>
        //*/
        //   public PutDataToRTViewpointRelaClass(pobjRTViewpointRelaEN: clsRTViewpointRelaEN) {
        //       var strTopicId = $("#hidTopicRelaId").val();
        //       var strViewpointId = $("#hidViewpointId").val();
        //       var strUserId = $("#hidUserId").val();
        //       pobjRTViewpointRelaEN.topicId = strTopicId;// 主题编号
        //       pobjRTViewpointRelaEN.viewpointId = strViewpointId;// 观点Id
        //       pobjRTViewpointRelaEN.proposePeople = strUserId;// 提出人
        //       pobjRTViewpointRelaEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        //       pobjRTViewpointRelaEN.updUser = strUserId;// 修改用户Id// 修改用户Id
        //       //pobjRTViewpointRelaEN.memo = this.memo;// 备注
        //   }
        /*
    * 获取年月日
    */
        getNowDate() {
            const date = new Date();
            let month = date.getMonth() + 1;
            let strDate = date.getDate();
            if (month <= 9) {
                month = "0" + month;
            }
            if (strDate <= 9) {
                strDate = "0" + strDate;
            }
            return date.getFullYear().toString() + "-" + month + "-" + strDate + " " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
        }
        //    /* 显示vViewpoint对象的所有属性值
        //(AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        //<param name = "divContainer">显示容器</param>
        //<param name = "arrViewpointObjLst">需要绑定的对象列表</param>
        //*/
        //    public BindTab_vViewpoint(divContainer: string, arrvViewpointObjLst: Array<clsvViewpointEN>) {
        //        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        //        if (o == null) {
        //            alert(`${divContainer}不存在！`);
        //            return;
        //        }
        //        var arrDataColumn: Array<clsDataColumn> =
        //            [
        //                {
        //                    FldName: "",
        //                    ColHeader: "",
        //                    Text: "",TdClass: "text-left",SortBy: "",
        //                    ColumnType: "CheckBox",
        //                    orderNum: 1,
        //                    FuncName: () => { }
        //                },
        //                {
        //                    FldName: "viewpointName",
        //                    ColHeader: "观点名称",
        //                    Text: "",TdClass: "text-left",SortBy: "",
        //                    ColumnType: "Label",
        //                    orderNum: 1,
        //                    FuncName: () => { }
        //                },
        //                {
        //                    FldName: "viewpointContent",
        //                    ColHeader: "观点内容",
        //                    Text: "",TdClass: "text-left",SortBy: "",
        //                    ColumnType: "Label",
        //                    orderNum: 1,
        //                    FuncName: () => { }
        //                },
        //                {
        //                    FldName: "viewpointTypeName",
        //                    ColHeader: "观点类型名",
        //                    Text: "",TdClass: "text-left",SortBy: "",
        //                    ColumnType: "Label",
        //                    orderNum: 1,
        //                    FuncName: () => { }
        //                },
        //                {
        //                    FldName: "reason",
        //                    ColHeader: "理由",
        //                    Text: "",TdClass: "text-left",SortBy: "",
        //                    ColumnType: "Label",
        //                    orderNum: 1,
        //                    FuncName: () => { }
        //                },
        //                {
        //                    FldName: "source",
        //                    ColHeader: "来源",
        //                    Text: "",TdClass: "text-left",SortBy: "",
        //                    ColumnType: "Label",
        //                    orderNum: 1,
        //                    FuncName: () => { }
        //                },
        //                {
        //                    FldName: "vpProposePeople",
        //                    ColHeader: "观点提出人",
        //                    Text: "",TdClass: "text-left",SortBy: "",
        //                    ColumnType: "Label",
        //                    orderNum: 1,
        //                    FuncName: () => { }
        //                },
        //                {
        //                    FldName: "updDate",
        //                    ColHeader: "修改日期",
        //                    Text: "",TdClass: "text-left",SortBy: "",
        //                    ColumnType: "Label",
        //                    orderNum: 1,
        //                    FuncName: () => { }
        //                },
        //                {
        //                    FldName: "updUser",
        //                    ColHeader: "修改人",
        //                    Text: "",TdClass: "text-left",SortBy: "",
        //                    ColumnType: "Label",
        //                    orderNum: 1,
        //                    FuncName: () => { }
        //                },
        //            ];
        //        clsCommonFunc4Web.BindTabV2(o, arrvViewpointObjLst, arrDataColumn, "viewpointId");
        //        this.objPager.RecCount = this.RecCount;
        //        this.objPager.pageSize = this.pageSize;
        //        this.objPager.ShowPagerV2(this, this.divName4Pager);
        //    }
        /* 函数功能:在数据 列表中跳转到某一页
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
        <param name = "intPageIndex">页序号</param>
      */
        async IndexPage(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.setCurrPageIndex(intPageIndex, this.divName4Pager);
            this.BindGv_vRTViewpointRela();
        }
        /* 函数功能:从界面列表中根据某一个字段排序
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
       <param name = "strSortByFld">排序的字段</param>
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
            const responseText2 = await this.BindGv_vRTViewpointRela();
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
        set hidSortvViewpointBy(value) {
            $("#hidSortvViewpointBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvViewpointBy() {
            return $("#hidSortvViewpointBy").val();
        }
        /*
      * 观点名称
     */
        set viewpointName(value) {
            $("#txtViewpointName").val(value);
        }
        /*
        * 观点名称
       */
        get viewpointName() {
            return $("#txtViewpointName").val();
        }
        /*
        * 观点名称
       */
        get ViewpointName_q() {
            return $("#txtViewpointName_q").val();
        }
        /*
        * 观点类型Id
       */
        set viewpointTypeId(value) {
            $("#ddlViewpointTypeId").val(value);
        }
        /*
        * 观点类型Id
       */
        get viewpointTypeId() {
            return $("#ddlViewpointTypeId").val();
        }
        /*
        * 观点类型Id
       */
        get ViewpointTypeId_q() {
            return $("#ddlViewpointTypeId_q").val();
        }
        /*
      * 设置排序字段-相当使用ViewState功能
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
        * 栏目主题
       */
        get TopicName_q() {
            return $("#txtTopicName_q").val();
        }
    }
    exports.ResearchTopicAdd = ResearchTopicAdd;
});
