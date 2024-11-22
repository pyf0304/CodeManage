///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduPublicPage/Pub_RTViewpointRelaList.js", "../PagesBase/GraduateEduTopic/ViewpointCRUD.js", "../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js", "../TS/L0_Entity/ParameterTable/clsViewpointTypeEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js", "../TS/L3_ForWApi/ParameterTable/clsViewpointTypeWApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ResearchTopicAdd = void 0;
    const Pub_RTViewpointRelaList_js_1 = require("../GraduateEduPublicPage/Pub_RTViewpointRelaList.js");
    const ViewpointCRUD_js_1 = require("../PagesBase/GraduateEduTopic/ViewpointCRUD.js");
    const clsvRTViewpointRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvRTViewpointRelaEN.js");
    const clsViewpointTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsViewpointTypeEN.js");
    const clsRTViewpointRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTViewpointRelaWApi.js");
    const clsvRTViewpointRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTViewpointRelaWApi.js");
    const clsViewpointTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsViewpointTypeWApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* Viewpoint_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class ResearchTopicAdd extends ViewpointCRUD_js_1.ViewpointCRUD {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.recCount = 0;
        }
        //public objPager: clsPager = new clsPager();
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
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                if (strUserId != "") {
                    $("#hidUserId").val(strUserId);
                    //1、为下拉框设置数据源,绑定列表数据
                    //const ddl_ViewpointTypeId = await this.BindDdl_ViewpointTypeId("ddlViewpointTypeId");
                    //const ddl_ViewpointTypeId_q = await this.BindDdl_ViewpointTypeId("ddlViewpointTypeId_q");
                    this.hidSortvViewpointBy = "viewpointName Asc";
                    this.hidSortvRTViewpointRelaBy = "viewpointName Asc";
                    //var strWhereCond = await this.CombinevViewpointCondition();
                    //const responseText = await vViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //});
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中                
                    const objPage_RTViewpointRela = new Pub_RTViewpointRelaList_js_1.Pub_RTViewpointRelaList();
                    await objPage_RTViewpointRela.Page_Load();
                    //await objPage_RTViewpointRela.BindGv_vRTViewpointRela();
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
        async btnQuery_Click() {
            var strWhereCond = await this.CombinevRTViewpointRelaCondition();
            try {
                const objPage_RTViewpointRela = new Pub_RTViewpointRelaList_js_1.Pub_RTViewpointRelaList();
                await objPage_RTViewpointRela.Page_Load();
                //await objPage_RTViewpointRela.BindGv_vRTViewpointRela();
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
                        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(ddlViewpointTypeId, arrViewpointTypeObjLst, clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeId, clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeName, "观点类型");
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
        btnokRecord_Click_pyf() {
            //this.AddNewRecordSave();
        }
        /* 把所有的查询控件内容组合成一个条件串
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
      <returns>条件串(strWhereCond)</returns>
    */
        async CombinevRTViewpointRelaCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId; //得到主题id
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.viewpointName_q != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_ViewpointName} like '% ${this.viewpointName_q}%'`;
                }
                //if (this.viewpointTypeId_q != "" && this.viewpointTypeId_q != "0") {
                //    strWhereCond += ` And ${clsvRTViewpointRelaEN.con_ViewpointTypeId} = '${this.viewpointTypeId_q}'`;
                //}
                if (this.topicName_q != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicName} like '% ${this.topicName_q}%'`;
                }
                //根据主题查询观点关系;
                if (strTopicId != "") {
                    strWhereCond += ` And ${clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN.con_TopicId} = '${strTopicId}'`;
                }
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
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
        /* 删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
    */
        async btnDelRecord_Click() {
            try {
                var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                var bolResult = false;
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
                const arrvRTViewpointRelaObjLst = await (0, clsvRTViewpointRelaWApi_js_1.vRTViewpointRela_GetObjLstAsync)(strWhereCond);
                //循环列表，判断数据是否是当前用户 ，是则可以删除；
                //判断权限、管理员教师可以删除、
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                //管理员 判断角色 
                if (strRoleId == "00620001" || strRoleId == "00620002") {
                    this.DelMultiRecord(arrKeyIds);
                    const objPage_RTViewpointRela = new Pub_RTViewpointRelaList_js_1.Pub_RTViewpointRelaList();
                    await objPage_RTViewpointRela.Page_Load();
                    //await objPage_RTViewpointRela.BindGv_vRTViewpointRela();
                }
                else {
                    //学生00620003
                    var objvRTViewpointRela = new clsvRTViewpointRelaEN_js_1.clsvRTViewpointRelaEN();
                    //循环判断数据用户不是登录用户则提示不可以删除
                    for (objvRTViewpointRela of arrvRTViewpointRelaObjLst) {
                        //如果存在不相同就提示不可删除；
                        if (objvRTViewpointRela.updUser != strUserId) {
                            alert("不能删除别人主题观点关系！");
                            bolResult = true;
                            return;
                        }
                    }
                    this.DelMultiRecord(arrKeyIds);
                    const objPage_RTViewpointRela = new Pub_RTViewpointRelaList_js_1.Pub_RTViewpointRelaList();
                    await objPage_RTViewpointRela.Page_Load();
                    //await objPage_RTViewpointRela.BindGv_vRTViewpointRela();
                }
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
        async DelMultiRecord(arrmId) {
            try {
                const returnInt = await (0, clsRTViewpointRelaWApi_js_1.RTViewpointRela_DelRTViewpointRelasAsync)(arrmId);
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
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
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
            //this.keyId = lngmId.toString();
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
        //       var strWhereCond = await this.CombinevViewpointCondition();
        //       var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
        //       var arrvViewpointObjLst: Array<clsvViewpointEN> = [];
        //       try {
        //           this.recCount = await vViewpoint_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
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
        //   public async CombinevViewpointCondition():Promise<string> {
        //       //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //       var strTopicId = clsPrivateSessionStorage.topicId;
        //       var strViewpointId = $("#hidViewpointId").val();
        //       var strUserId = clsPublocalStorage.userId;
        //       //例如 1 = 1 && userName = '张三'
        //       var strWhereCond: string = " 1 = 1 ";
        //       //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        //       try {
        //           if (this.viewpointName_q != "") {
        //               strWhereCond += ` And ${clsvViewpointEN.con_ViewpointName} like '% ${this.viewpointName_q}%'`;
        //           }
        //           if (this.viewpointTypeId_q != "" && this.viewpointTypeId_q != "0") {
        //               strWhereCond += ` And ${clsvViewpointEN.con_ViewpointTypeId} = '${this.viewpointTypeId_q}'`;
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
        //       var strTopicId = clsPrivateSessionStorage.topicId;
        //       var strViewpointId = $("#hidViewpointId").val();
        //       var strUserId = clsPublocalStorage.userId;
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
        //       var strTopicId = clsPrivateSessionStorage.topicId;
        //       var strViewpointId = $("#hidViewpointId").val();
        //       var strUserId = clsPublocalStorage.userId;
        //       pobjRTViewpointRelaEN.SetTopicId(strTopicId;// 主题编号
        //       pobjRTViewpointRelaEN.SetViewpointId(strViewpointId;// 观点Id
        //       pobjRTViewpointRelaEN.SetProposePeople(strUserId;// 提出人
        //       pobjRTViewpointRelaEN.SetUpdDate(clsPubFun4Web.getNowDate();// 修改日期
        //       pobjRTViewpointRelaEN.SetUpdUser(strUserId;// 修改用户Id// 修改用户Id
        //       //pobjRTViewpointRelaEN.SetMemo(this.memo;// 备注
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
        //    public async BindTab_vViewpoint(divContainer: string, arrvViewpointObjLst: Array<clsvViewpointEN>) {
        //        var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        //        if (o == null) {
        //            alert(`${divContainer}不存在！`);
        //            return;
        //        }
        //        var arrDataColumn: Array<clsDataColumn> =
        //            [
        //                {
        //                    fldName: "",
        //                    colHeader: "",
        //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                    columnType: "CheckBox",
        //                    orderNum: 1,
        //                    funcName: () => { }
        //                },
        //                {
        //                    fldName: "viewpointName",
        //                    colHeader: "观点名称",
        //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                    columnType: "Label",
        //                    orderNum: 1,
        //                    funcName: () => { }
        //                },
        //                {
        //                    fldName: "viewpointContent",
        //                    colHeader: "观点内容",
        //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                    columnType: "Label",
        //                    orderNum: 1,
        //                    funcName: () => { }
        //                },
        //                {
        //                    fldName: "viewpointTypeName",
        //                    colHeader: "观点类型名",
        //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                    columnType: "Label",
        //                    orderNum: 1,
        //                    funcName: () => { }
        //                },
        //                {
        //                    fldName: "reason",
        //                    colHeader: "理由",
        //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                    columnType: "Label",
        //                    orderNum: 1,
        //                    funcName: () => { }
        //                },
        //                {
        //                    fldName: "source",
        //                    colHeader: "来源",
        //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                    columnType: "Label",
        //                    orderNum: 1,
        //                    funcName: () => { }
        //                },
        //                {
        //                    fldName: "vpProposePeople",
        //                    colHeader: "观点提出人",
        //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                    columnType: "Label",
        //                    orderNum: 1,
        //                    funcName: () => { }
        //                },
        //                {
        //                    fldName: "updDate",
        //                    colHeader: "修改日期",
        //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                    columnType: "Label",
        //                    orderNum: 1,
        //                    funcName: () => { }
        //                },
        //                {
        //                    fldName: "updUser",
        //                    colHeader: "修改人",
        //                    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
        //                    columnType: "Label",
        //                    orderNum: 1,
        //                    funcName: () => { }
        //                },
        //            ];
        //        BindTab(o, arrvViewpointObjLst, arrDataColumn, "viewpointId");
        //        this.objPager.recCount = this.recCount;
        //        this.objPager.pageSize = this.pageSize;
        //        this.objPager.ShowPagerV2(this, this.divName4Pager);
        //    }
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
        get viewpointName_q() {
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
        get viewpointTypeId_q() {
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
        get topicName_q() {
            return $("#txtTopicName_q").val();
        }
    }
    exports.ResearchTopicAdd = ResearchTopicAdd;
});
