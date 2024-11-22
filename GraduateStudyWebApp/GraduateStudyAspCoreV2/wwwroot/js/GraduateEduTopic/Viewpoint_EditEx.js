(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/Viewpoint_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsViewpointAttachmentEN.js", "../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js", "../TS/L0_Entity/GraduateEduTopic/clsViewpointVerEN.js", "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointVerWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Viewpoint_EditEx = void 0;
    /**
    * 类名:Viewpoint_EditEx(界面:ViewpointCRUD)
    * 表名:Viewpoint(01120542)
    * 版本:2023.01.04.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/06 22:43:57
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培主题(GraduateEduTopic)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const Viewpoint_Edit_js_1 = require("../PagesBase/GraduateEduTopic/Viewpoint_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsViewpointAttachmentEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsViewpointAttachmentEN.js");
    const clsViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsViewpointEN.js");
    const clsViewpointVerEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsViewpointVerEN.js");
    const clsgs_ShareEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js");
    const clsViewpointAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsViewpointAttachmentWApi.js");
    const clsViewpointVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsViewpointVerWApi.js");
    const clsViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsViewpointWApi.js");
    const clsgs_ShareWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsgs_UserConfigExWApi_js_1 = require("../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* Viewpoint_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class Viewpoint_EditEx extends Viewpoint_Edit_js_1.Viewpoint_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = Viewpoint_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(Viewpoint_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjViewpointEN">数据传输的目的类对象</param>
      */
        PutDataToViewpointVerClass(pobjViewpointVerEN) {
            pobjViewpointVerEN.SetViewpointId(this.viewpointId); // 观点Id
            pobjViewpointVerEN.SetViewpointName(this.viewpointName); // 观点名称
            pobjViewpointVerEN.SetViewpointContent(this.viewpointContent); // 观点内容
            pobjViewpointVerEN.SetViewpointTypeId(this.viewpointTypeId); // 观点类型Id
            pobjViewpointVerEN.SetReason(this.reason); // 理由
            pobjViewpointVerEN.SetSource(this.source); // 来源
            pobjViewpointVerEN.SetCitationId(this.paperId); //引用论文id；
            //判断用户类型，然后添加数据
            var strhidUserTypeId = $("#hidUserTypeId").val();
            if (strhidUserTypeId != "") {
                pobjViewpointVerEN.SetUserTypeId(strhidUserTypeId);
            }
            pobjViewpointVerEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            pobjViewpointVerEN.SetVPProposePeople(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 观点提出人
            pobjViewpointVerEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjViewpointVerEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjViewpointVerEN.SetMemo(this.memo); // 备注
        }
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjViewpointEN">数据传输的目的类对象</param>
      */
        async PutDataToViewpointClass(pobjViewpointEN) {
            pobjViewpointEN.SetViewpointId(this.viewpointId); // 观点Id
            pobjViewpointEN.SetViewpointName(this.viewpointName); // 观点名称
            pobjViewpointEN.SetViewpointContent(this.viewpointContent); // 观点内容
            pobjViewpointEN.SetViewpointTypeId(this.viewpointTypeId); // 观点类型Id
            pobjViewpointEN.SetReason(this.reason); // 理由
            pobjViewpointEN.SetSource(this.source); // 来源
            pobjViewpointEN.SetIsSubmit(false); //是否提交；
            pobjViewpointEN.SetCitationId(this.paperId); //引用论文id；
            //判断用户类型，然后添加数据
            var strhidUserTypeId = $("#hidUserTypeId").val();
            if (strhidUserTypeId != "") {
                pobjViewpointEN.SetUserTypeId(strhidUserTypeId);
            }
            pobjViewpointEN.SetShareId(this.shareId);
            pobjViewpointEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            pobjViewpointEN.SetVPProposePeople(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 观点提出人
            pobjViewpointEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjViewpointEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjViewpointEN.SetMemo(this.memo); // 备注
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
            this.UpdateRecord(strKeyId);
        }
        /* 根据关键字获取相应的记录的对象
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        <param name = "sender">参数列表</param>
      */
        async UpdateRecord(strViewpointId) {
            this.btnSubmit_Viewpoint = "确认修改";
            this.btnCancel_Viewpoint = "取消修改";
            this.keyId = strViewpointId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            try {
                const responseText = (0, clsViewpointWApi_js_1.Viewpoint_GetObjByViewpointIdAsync)(strViewpointId).then((jsonData) => {
                    var objViewpointEN = jsonData;
                    // //通过判断数据用户是否是当前登录用户；
                    if (objViewpointEN.updUser == strUserId) {
                        //判断数据是否提交，提交则不可修改；
                        if (objViewpointEN.isSubmit == false) {
                            ShowDialog('Update');
                            this.GetDataFromViewpointClass(objViewpointEN);
                            console.log("完成UpdateRecord!");
                            //resolve(jsonData);
                        }
                        else {
                            alert("当前数据已提交,不能修改！");
                            return false;
                        }
                    }
                    else {
                        alert("当前数据不是您所添加，不能修改！");
                        return false;
                    }
                });
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true;
        }
        /* 函数功能:把类对象的属性内容显示到界面上
       注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        如果在设置数据库时,就应该一级字段在前,二级字段在后
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        <param name = "pobjViewpointEN">表实体类对象</param>
      */
        GetDataFromViewpointClass(pobjViewpointEN) {
            this.viewpointId = pobjViewpointEN.viewpointId; // 观点Id
            this.viewpointName = pobjViewpointEN.viewpointName; // 观点名称
            this.viewpointContent = pobjViewpointEN.viewpointContent; // 观点内容
            this.viewpointTypeId = pobjViewpointEN.viewpointTypeId; // 观点类型Id
            this.reason = pobjViewpointEN.reason; // 理由
            this.source = pobjViewpointEN.source; // 来源
            this.isSubmit = pobjViewpointEN.isSubmit; //是否提交；
            this.vpProposePeople = pobjViewpointEN.vpProposePeople; // 观点提出人
            this.shareId = pobjViewpointEN.shareId;
            this.paperId = pobjViewpointEN.citationId; //引用Id;
            this.updDate = pobjViewpointEN.updDate; // 修改日期
            this.updUser = pobjViewpointEN.updUser; // 修改人
            this.memo = pobjViewpointEN.memo; // 备注
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
        //提交判断；
        async SubmitRecord(strViewpointId) {
            this.keyId = strViewpointId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsViewpointWApi_js_1.Viewpoint_GetObjByViewpointIdAsync)(strViewpointId).then((jsonData) => {
                        var objViewpointEN = jsonData;
                        //通过session 权限获取权限
                        var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                        var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                        //判断角色 //学生00620003
                        if (strRoleId == "00620003") {
                            // //通过判断数据用户是否是当前登录用户；
                            if (objViewpointEN.updUser == strUserId) {
                                //判断数据是否已审核
                                if (objViewpointEN.isSubmit == false) {
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
                            if (objViewpointEN.isSubmit == false) {
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
            var objViewpointEN = new clsViewpointEN_js_1.clsViewpointEN();
            objViewpointEN.SetViewpointId(this.keyId);
            objViewpointEN.SetIsSubmit(true);
            //this.PutDataToViewpointClass(objViewpointEN);
            objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const returnBool = await (0, clsViewpointWApi_js_1.Viewpoint_UpdateRecordAsync)(objViewpointEN);
                if (returnBool == true) {
                    var strInfo = `提交成功!`;
                    //显示信息框
                    alert(strInfo);
                    HideDialog();
                    //this.BindGv_vViewpoint();
                    this.iShowList.BindGv(clsViewpointEN_js_1.clsViewpointEN._CurrTabName, returnBool.toString());
                }
                else {
                    var strInfo = `提交不成功!`;
                    //显示信息框
                    alert(strInfo);
                    console.log("提交失败");
                }
                $("#btnIsSubmit").attr("disabled", false);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `修改记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true;
        }
        //观点提交审核
        async btnIsSubmit_Click(strKeyId) {
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
            if (strKeyId == "") {
                alert("请选择需要提交的记录！");
                return;
            }
            this.SubmitRecord(strKeyId);
        }
        /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
    */
        async btnAddNewRecord_Click() {
            this.opType = "Add";
            try {
                var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
                const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4Edit, "ddlShareId");
                const responseText = await this.AddNewRecord();
                //获取分享Id
                const responseText1 = await (0, clsgs_UserConfigExWApi_js_1.gs_UserConfigEx_GetNewReturnShareIdEx)("04", clsPublocalStorage_js_1.clsPublocalStorage.userId);
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
        /* 在数据表里修改记录
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
     */
        async btnUpdateRecordInTab_Click(strKeyId) {
            this.opType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
            const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4Edit, "ddlShareId");
            this.UpdateRecord(strKeyId);
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
       具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
     */
        async btnOKUpd_Click() {
            var strCommandText = this.btnSubmit_Viewpoint;
            try {
                //判断session是否失效
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    switch (strCommandText) {
                        case "添加":
                            const responseText1 = await this.AddNewRecord();
                            break;
                        case "确认添加":
                            //这是一个单表的插入的代码,由于逻辑层太简单,
                            //就把逻辑层合并到控制层,
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    //HideDialog();
                                    //this.BindGv_vViewpoint();
                                }
                            });
                            //更新总表3个参数 主键、子表类型、页面操作类型；
                            var strTopicObjectiveId = $('#hidViewpointId').val();
                            const responseText6 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strTopicObjectiveId, "04", "1", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                            var returnBool6 = !!responseText6;
                            if (returnBool6 == true) {
                                console.log("客观数据总表同步成功；");
                            }
                            else {
                                console.log("客观数据总表同步失败；");
                            }
                            //添加记录的同时添加历史版本
                            const responseText3 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.iShowList.BindGv(clsViewpointEN_js_1.clsViewpointEN._CurrTabName, "");
                                    //alert("添加历史版本出问题！");
                                }
                            });
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            const responseText4 = await this.UpdateRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                }
                            });
                            //更新总表3个参数 主键、子表类型、页面操作类型；
                            var strTopicObjectiveId = $('#hidViewpointId').val();
                            const responseText7 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis)(strTopicObjectiveId, "04", "2", clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                            var returnBool7 = !!responseText7;
                            if (returnBool7 == true) {
                                console.log("专家观点数据总表同步成功；");
                            }
                            else {
                                console.log("专家观点数据总表同步失败；");
                            }
                            //修改记录的同时添加历史版本
                            const responseText5 = await this.AddVersionRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.iShowList.BindGv(clsViewpointEN_js_1.clsViewpointEN._CurrTabName, "");
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
                $('#divLoading').hide();
                //去掉提交按钮不可用状态
                $('#btnOKUpd').attr("disabled", false);
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            try {
                const responseText = await (0, clsViewpointWApi_js_1.Viewpoint_GetMaxStrIdAsync)().then((jsonData) => {
                    var returnString = jsonData.toString();
                    if (returnString == "") {
                        var strInfo = `获取表ViewPoint的最大关键字为空，不成功，请检查!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        $('#txtViewpointId').val(returnString);
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
            if ($('#txtViewpointId').val() != "") {
                var objViewpointEN = new clsViewpointEN_js_1.clsViewpointEN();
                //objViewpointEN.SetViewpointId($('#txtViewpointId').val();
                $('#hidViewpointId').val($('#txtViewpointId').val());
                objViewpointEN.SetCreateDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd());
                this.PutDataToViewpointClass(objViewpointEN);
                try {
                    const responseText = await (0, clsViewpointWApi_js_1.Viewpoint_IsExistAsync)(objViewpointEN.viewpointId);
                    var bolIsExist = responseText;
                    if (bolIsExist == true) {
                        var strMsg = `添加记录时，关键字：${objViewpointEN.viewpointId}已经存在！`;
                        alert(strMsg);
                        return responseText; //一定要有一个返回值，否则会出错！
                    }
                    //const responseText2 = await Viewpoint_AddNewRecordWithMaxIdAsync(objViewpointEN);
                    const responseText2 = await (0, clsViewpointWApi_js_1.Viewpoint_AddNewRecordAsync)(objViewpointEN);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        //执行之前需要判断是否有引用 ;有就添加论文、没有就添加附件；
                        //  if ($("#txtPaperId").val() == "") {
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
                        // }
                        //else {
                        //    //1.这里执行添加观点引用论文；
                        //    var objclsViewpointCitationEN: clsViewpointCitationEN = new clsViewpointCitationEN();
                        //    this.PutDataToclsViewpointCitationClass(objclsViewpointCitationEN);
                        //    //引用论文；
                        //    const responseText3 = await ViewpointCitation_AddNewRecordAsync(objclsViewpointCitationEN);
                        //    var returnBool: boolean = !!responseText3;
                        //    if (returnBool == true) {
                        //        //添加成功，则执行附件添加方法；
                        //        //判断是否有返回的附件路径值
                        //        if ($("#hdnFileOne").val() != "") { //第一个附件框判断
                        //            var fileOne = $("#hdnFileOne").val();
                        //            this.AddNewRecordobjPaperSubAttachmentENSave(fileOne, "first");
                        //        }
                        //        else {
                        //            if ($("#hdnFileTwo").val() != "") {
                        //                var fileTwo = $("#hdnFileTwo").val();
                        //                this.AddNewRecordobjPaperSubAttachmentENSave(fileTwo, "two");
                        //            }
                        //            else {
                        //                if ($("#hdnFileThree").val() != "") {
                        //                    var fileThree = $("#hdnFileThree").val();
                        //                    this.AddNewRecordobjPaperSubAttachmentENSave(fileThree, "three");
                        //                }
                        //            }
                        //        }
                        //    }
                        //    else {
                        //    }
                        //}
                        var strInfo = `添加记录成功!`;
                        $('#lblResult40').val(strInfo);
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        var strInfo = `添加记录不成功!`;
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
            }
            else {
                var strInfo = `获取最大关键字为空，不成功!`;
                //显示信息框
                alert(strInfo);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        //添加历史版本
        async AddVersionRecordSave() {
            const strThisFuncName = this.AddVersionRecordSave.name;
            var objViewpointVerEN = new clsViewpointVerEN_js_1.clsViewpointVerEN();
            objViewpointVerEN.SetViewpointId(this.viewpointId);
            this.PutDataToViewpointVerClass(objViewpointVerEN);
            try {
                const responseText2 = await (0, clsViewpointVerWApi_js_1.ViewpointVer_AddNewRecordAsync)(objViewpointVerEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strWhereCond2 = " 1 =1 and viewpointId=" + this.viewpointId;
                    var intVersionCount = await (0, clsViewpointVerWApi_js_1.ViewpointVer_GetRecCountByCondAsync)(strWhereCond2);
                    var objViewpointEN = new clsViewpointEN_js_1.clsViewpointEN();
                    objViewpointEN.SetViewpointId(this.viewpointId);
                    objViewpointEN.SetVersionCount(intVersionCount);
                    objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
                    if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                        throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
                    }
                    const responseText = (0, clsViewpointWApi_js_1.Viewpoint_UpdateRecordAsync)(objViewpointEN).then((jsonData) => {
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
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
            this.viewpointId = "";
            this.viewpointName = "";
            this.viewpointContent = "";
            $('#ddlViewpointTypeId option[0]').attr("selected", true);
            this.reason = "";
            this.source = "";
            this.vpProposePeople = "";
            this.updDate = "";
            this.updUser = "";
            this.memo = "";
            this.paperId = "";
            $("#hdnFileOne").val("");
            $("#hdnFileTwo").val("");
            $("#hdnFileThree").val("");
        }
        ////////////////////////////////////////////////修改时的方法
        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
      */
        async UpdateRecordSave() {
            const strThisFuncName = this.UpdateRecordSave.name;
            var objViewpointEN = new clsViewpointEN_js_1.clsViewpointEN();
            objViewpointEN.SetViewpointId(this.keyId);
            $('#hidViewpointId').val(this.keyId);
            this.PutDataToViewpointClass(objViewpointEN);
            objViewpointEN.sf_UpdFldSetStr = objViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objViewpointEN.viewpointId == "" || objViewpointEN.viewpointId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsViewpointWApi_js_1.Viewpoint_UpdateRecordAsync)(objViewpointEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            ////判断引用的论文ID是否为空
                            //var strPaperId = $("#txtPaperId").val();
                            //if (strPaperId != "") {
                            //    //，如果不为空，根据Id删除引用文件
                            //    var strwhere = "viewpointId ='" + objViewpointEN.viewpointId + "'";
                            //    this.DelRecordViewpointCitationByWhere(strwhere);
                            //}
                            //else {
                            //如果等于空，那么就去判断附件是否为空；
                            //得到相关论文附件地址，判断是否为空 只要有一个不为空都执行附件清除功能；
                            if ($("#hdnFileOne").val() != "" && $("#hdnFileOne").val() != undefined || $("#hdnFileTwo").val() != "" && $("#hdnFileTwo").val() != undefined || $("#hdnFileThree").val() != "" && $("#hdnFileThree").val() != undefined) {
                                //根据Id删除附件
                                var strwhere = "viewpointId ='" + objViewpointEN.viewpointId + "'";
                                this.DelRecordByWhere(strwhere);
                            }
                            //  }
                            var strInfo = `修改记录成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                        }
                        else {
                            var strInfo = `修改记录不成功!`;
                            $('#lblResult44').val(strInfo);
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
                    return false;
                }
            });
        }
        //////////////////////////////////////////////////////////////////////附件添加
        //添加上传论文附件方法
        async AddNewRecordobjPaperSubAttachmentENSave(filePath, strfileNum) {
            var objViewpointAttachmentEN = new clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN();
            this.PutDataToPaperAttachmentClass(objViewpointAttachmentEN, filePath);
            try {
                const responseText2 = await (0, clsViewpointAttachmentWApi_js_1.ViewpointAttachment_AddNewRecordAsync)(objViewpointAttachmentEN);
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
        PutDataToPaperAttachmentClass(pobjViewpointAttachmentEN, filePath) {
            pobjViewpointAttachmentEN.SetViewpointId($("#txtViewpointId").val()); // 观点Id
            var strfilePath = filePath;
            //判断地址不为空则执行截取操作
            if (strfilePath != "") {
                var index = strfilePath.lastIndexOf("\/");
                strfilePath = strfilePath.substring(index + 1, strfilePath.length);
                pobjViewpointAttachmentEN.SetFilePath(filePath);
                pobjViewpointAttachmentEN.SetViewpointAttachmentName(strfilePath);
            }
            pobjViewpointAttachmentEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            if (clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls != "") {
                pobjViewpointAttachmentEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            }
            else {
                pobjViewpointAttachmentEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            }
            //pobjViewpointAttachmentEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls;//教学班
            pobjViewpointAttachmentEN.SetUpdUserId(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
        }
        //删除观点附件
        /*
    根据关键字删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
    */
        DelRecordByWhere(strWhere) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsViewpointAttachmentWApi_js_1.ViewpointAttachment_DelViewpointAttachmentsByCondAsync)(strWhere).then((jsonData) => {
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
    }
    exports.Viewpoint_EditEx = Viewpoint_EditEx;
});
