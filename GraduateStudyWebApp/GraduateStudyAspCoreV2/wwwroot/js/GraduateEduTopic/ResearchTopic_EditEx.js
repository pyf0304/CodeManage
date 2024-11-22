(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/ResearchTopic_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js", "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js", "../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "./RTUserRela_EditEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ResearchTopic_EditEx = void 0;
    /**
    * 类名:ResearchTopic_EditEx(界面:ResearchTopicCRUD)
    * 表名:ResearchTopic(01120546)
    * 版本:2023.01.04.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/06 22:07:57
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培主题(GraduateEduTopic)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const ResearchTopic_Edit_js_1 = require("../PagesBase/GraduateEduTopic/ResearchTopic_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsResearchTopicEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js");
    const clsgs_ShareEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js");
    const clsPageDispModeEN_js_1 = require("../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js");
    const clsResearchTopicWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js");
    const clsgs_ShareWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsgs_UserConfigExWApi_js_1 = require("../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const RTUserRela_EditEx_js_1 = require("./RTUserRela_EditEx.js");
    /* ResearchTopic_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class ResearchTopic_EditEx extends ResearchTopic_Edit_js_1.ResearchTopic_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = ResearchTopic_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(ResearchTopic_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /** 函数功能:为编辑区绑定下拉框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
        **/
        async BindDdl4EditRegionInDiv() {
            const strThisFuncName = this.BindDdl4EditRegionInDiv.name;
            // 在此处放置用户代码以初始化页面
            await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4Edit, "ddlShareId");
        }
        /** 添加新记录
    * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
    **/
        async btnAddNewRecord_Click() {
            const strThisFuncName = this.btnAddNewRecord_Click.name;
            this.divName4Edit = "divEdit_ResearchTopic";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    this.opType = "Add";
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    this.SetEventFunc();
                    this.bolIsLoadEditRegion = true; //
                    this.btnSubmit_ResearchTopic = "确认添加";
                    this.btnCancel_ResearchTopic = "取消添加";
                    const responseText = this.AddNewRecord();
                    if (ResearchTopic_Edit_js_1.ResearchTopic_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_ResearchTopic('Add');
                    }
                }
                else {
                    this.opType = "Add";
                    this.btnSubmit_ResearchTopic = "确认添加";
                    this.btnCancel_ResearchTopic = "取消添加";
                    const responseText = await this.AddNewRecord();
                    if (ResearchTopic_Edit_js_1.ResearchTopic_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_ResearchTopic('Add');
                    }
                }
                const responseText1 = await (0, clsgs_UserConfigExWApi_js_1.gs_UserConfigEx_GetNewReturnShareIdEx)("12", clsPublocalStorage_js_1.clsPublocalStorage.userId);
                var strShareId = responseText1;
                if (strShareId != "") {
                    this.shareId = strShareId;
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("添加新记录初始化不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /* 添加新记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
      */
        async btnAddNewRecord_ClickBak() {
            this.opType = "Add";
            try {
                var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
                const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4Edit, "ddlShareId");
                const responseText = await this.AddNewRecord();
                //获取分享Id
                const responseText1 = await (0, clsgs_UserConfigExWApi_js_1.gs_UserConfigEx_GetNewReturnShareIdEx)("12", clsPublocalStorage_js_1.clsPublocalStorage.userId);
                var strShareId = responseText1;
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
        /* 添加新记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
    */
        async AddNewRecordSave() {
            //this.DivName = "divAddNewRecordSave";
            //先验证界面数据
            if (this.topicName == "") {
                alert('栏目不能为空!');
                return false;
            }
            else if (this.topicName.length > 100) {
                alert('栏目不能超过100!');
                return false;
            }
            else if (this.topicContent == "") {
                alert('主题内容不能为空!');
                return false;
            }
            else if (this.shareId == "" || this.shareId == "0") {
                alert('分享不能为空!');
                return false;
            }
            var objResearchTopicEN = new clsResearchTopicEN_js_1.clsResearchTopicEN();
            this.PutDataToResearchTopicClass(objResearchTopicEN);
            try {
                var strTopicId = await (0, clsResearchTopicWApi_js_1.ResearchTopic_AddNewRecordWithReturnKeyAsync)(objResearchTopicEN);
                if (strTopicId != "") {
                    //这里默认添加一个用户数据 ，作为主题用户关系的组长；
                    const objPage_Edit = new RTUserRela_EditEx_js_1.RTUserRela_EditEx(this.iShowList);
                    const bolAddRTUserRela = await objPage_Edit.AddNewTopicAndRecordSaveUserRela(strTopicId);
                    if (bolAddRTUserRela == true) {
                        var strInfo = `添加记录成功!`;
                        //显示信息框
                        alert(strInfo);
                        return true;
                    }
                    else {
                        var strInfo = `添加研究主题与用户关系不成功!`;
                        //显示信息框
                        alert(strInfo);
                        return false;
                    }
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    return false;
                }
                return true; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
    */
        async btnOKUpd_Click() {
            var strCommandText = this.btnSubmit_ResearchTopic;
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
                                    HideDialog();
                                    //树形数据源；
                                    //this.GetTopicData();
                                    this.iShowList.BindGv(clsResearchTopicEN_js_1.clsResearchTopicEN._CurrTabName, returnBool.toString());
                                }
                            });
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            const returnBool = await this.UpdateRecordSave();
                            if (returnBool == true) {
                                HideDialog();
                                //树形数据源；
                                //this.GetTopicData();
                                this.iShowList.BindGv(clsResearchTopicEN_js_1.clsResearchTopicEN._CurrTabName, returnBool.toString());
                            }
                            break;
                        default:
                            var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                            alert(strMsg);
                            break;
                    }
                }
                else {
                    alert("登录超时，请重新登录");
                    //window.top.location.href = "../Web/Login";
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
        /** 修改记录
     * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
     **/
        async btnUpdateRecord_Click(strKeyId) {
            const strThisFuncName = this.btnUpdateRecord_Click.name;
            this.divName4Edit = "divEdit_ResearchTopic";
            if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                const strMsg = "修改记录的关键字为空，请检查！";
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    this.opType = "Update";
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    this.SetEventFunc();
                    this.bolIsLoadEditRegion = true; //
                    this.btnSubmit_ResearchTopic = "确认修改";
                    this.btnCancel_ResearchTopic = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (ResearchTopic_Edit_js_1.ResearchTopic_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_ResearchTopic('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_ResearchTopic = "确认修改";
                    this.btnCancel_ResearchTopic = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (ResearchTopic_Edit_js_1.ResearchTopic_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_ResearchTopic('Update');
                    }
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("(errid: WiTsCs0034)在修改记录时出错!请联系管理员!{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /* 修改
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
      */
        async btnUpdateRecord_ClickBak(strKeyId) {
            //判断主题id
            this.divName4Edit = "divEdit_ResearchTopic";
            if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                alert("请选择需要修改的主题！");
                return;
            }
            var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
            const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4Edit, "ddlShareId");
            this.UpdateRecord(strKeyId);
        }
        /* 根据关键字获取相应的记录的对象
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        <param name = "sender">参数列表</param>
      */
        async UpdateRecord(strTopicId) {
            const strThisFuncName = this.UpdateRecord.name;
            this.btnSubmit_ResearchTopic = "确认修改";
            this.btnCancel_ResearchTopic = "取消修改";
            this.keyId = strTopicId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            try {
                const objResearchTopicEN = await (0, clsResearchTopicWApi_js_1.ResearchTopic_GetObjByTopicIdAsync)(strTopicId);
                if (objResearchTopicEN == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                // //通过判断数据用户是否是当前登录用户；
                if (objResearchTopicEN.updUser == strUserId) {
                    ShowDialog('Update');
                    this.GetDataFromResearchTopicClass(objResearchTopicEN);
                    console.log("完成UpdateRecord!");
                    return true;
                }
                else {
                    alert("当前数据不是您所添加，不能修改！");
                    return false;
                }
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        }
        /* 函数功能:把类对象的属性内容显示到界面上
       注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        如果在设置数据库时,就应该一级字段在前,二级字段在后
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        <param name = "pobjResearchTopicEN">表实体类对象</param>
      */
        async GetDataFromResearchTopicClass(pobjResearchTopicEN) {
            this.topicId = pobjResearchTopicEN.topicId; // 主题编号
            this.topicName = pobjResearchTopicEN.topicName; // 栏目主题
            this.topicContent = pobjResearchTopicEN.topicContent; // 主题内容
            //this.topicProposePeople = pobjResearchTopicEN.topicProposePeople;// 主题提出人
            this.shareId = pobjResearchTopicEN.shareId; //
            this.orderNum = pobjResearchTopicEN.orderNum; // 序号
            //this.updDate = pobjResearchTopicEN.updDate;// 修改日期
            //this.updUser = pobjResearchTopicEN.updUser;// 修改人
            this.memo = pobjResearchTopicEN.memo; // 备注
        }
        /* 修改记录
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
    */
        async UpdateRecordSave() {
            const strThisFuncName = this.UpdateRecordSave.name;
            //
            var objResearchTopicEN = new clsResearchTopicEN_js_1.clsResearchTopicEN();
            objResearchTopicEN.SetTopicId(this.keyId);
            this.PutDataToResearchTopicClass(objResearchTopicEN);
            objResearchTopicEN.sf_UpdFldSetStr = objResearchTopicEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objResearchTopicEN.topicId == "" || objResearchTopicEN.topicId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsResearchTopicWApi_js_1.ResearchTopic_UpdateRecordAsync)(objResearchTopicEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
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
        /**
         * 清除用户自定义控件中，所有控件的值
         * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
         **/
        Clear() {
            const strThisFuncName = this.Clear.name;
            this.topicId = "";
            this.topicName = "";
            this.topicContent = "";
            //this.topicProposePeople = "";
            this.orderNum = 0;
            //this.updDate = "";
            //this.updUser = "";
            this.memo = "";
        }
        /**
     * 主题内容 (Used In Clear())
     **/
        set topicContent(value) {
            (0, clsCommFunc4Ctrl_js_1.SetTextAreaValueByIdInDiv)(this.divName4Edit, "txtTopicContent", value);
        }
        /**
        * 主题内容 (Used In PutDataToClass())
        **/
        get topicContent() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetTextAreaValueInDiv)(this.divName4Edit, "txtTopicContent");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
    * 备注 (Used In Clear())
    **/
        set memo(value) {
            (0, clsCommFunc4Ctrl_js_1.SetTextAreaValueByIdInDiv)(this.divName4Edit, "txtMemo", value);
        }
        /**
        * 备注 (Used In PutDataToClass())
        **/
        get memo() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetTextAreaValueInDiv)(this.divName4Edit, "txtMemo");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjResearchTopicEN">数据传输的目的类对象</param>
      */
        async PutDataToResearchTopicClass(pobjResearchTopicEN) {
            pobjResearchTopicEN.SetTopicId(this.topicId); // 主题编号
            pobjResearchTopicEN.SetTopicName(this.topicName); // 栏目主题
            pobjResearchTopicEN.SetTopicContent(this.topicContent); // 主题内容
            pobjResearchTopicEN.SetTopicProposePeople(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 主题提出人
            if (this.orderNum == 0) {
                pobjResearchTopicEN.SetOrderNum(30); // 序号
            }
            else {
                pobjResearchTopicEN.SetOrderNum(this.orderNum); // 序号
            }
            pobjResearchTopicEN.SetShareId(this.shareId);
            pobjResearchTopicEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            pobjResearchTopicEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjResearchTopicEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjResearchTopicEN.SetMemo(this.memo); // 备注
        }
    }
    exports.ResearchTopic_EditEx = ResearchTopic_EditEx;
});
