(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/BaseInfo_Share/XzMajor_Edit.js", "../TS/L0_Entity/BaseInfo_Share/clsvXzMajorEN.js", "../TS/L0_Entity/BaseInfo_Share/clsXzClgEN.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzMajor_EditEx = void 0;
    /**
    * 类名:XzMajor_EditEx(界面:XzMajorCRUD)
    * 表名:XzMajor(01120065)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/08 02:24:03
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:游戏化教育平台(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:基本信息维护(BaseInfo)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const XzMajor_Edit_js_1 = require("../PagesBase/BaseInfo_Share/XzMajor_Edit.js");
    const clsvXzMajorEN_js_1 = require("../TS/L0_Entity/BaseInfo_Share/clsvXzMajorEN.js");
    const clsXzClgEN_js_1 = require("../TS/L0_Entity/BaseInfo_Share/clsXzClgEN.js");
    const clsXzClgWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js");
    const clsXzMajorWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* XzMajor_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
   */
    class XzMajor_EditEx extends XzMajor_Edit_js_1.XzMajor_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = XzMajor_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(XzMajor_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
    */
        async btnOKUpd_Click() {
            var strCommandText = this.btnSubmit_Click.name;
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
                            if (this.opType == "AddWithMaxId") {
                                const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                                    var returnBool2 = jsonData;
                                    if ((0, clsString_js_1.IsNullOrEmpty)(returnBool2) == false) {
                                        HideDialog();
                                        this.iShowList.BindGv(clsvXzMajorEN_js_1.clsvXzMajorEN._CurrTabName, returnBool2);
                                    }
                                });
                            }
                            else {
                                const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                    var returnBool = jsonData;
                                    if (returnBool == true) {
                                        HideDialog();
                                        this.iShowList.BindGv(clsvXzMajorEN_js_1.clsvXzMajorEN._CurrTabName, returnBool.toString());
                                    }
                                });
                            }
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                                strInfo += "(In XzMajorCRUD.btnOKUpd_Click)";
                                $('#lblResult51').val(strInfo);
                                //显示信息框
                                console.log(strInfo);
                                alert(strInfo);
                                if (returnBool == true) {
                                    HideDialog();
                                    this.iShowList.BindGv(clsvXzMajorEN_js_1.clsvXzMajorEN._CurrTabName, returnBool.toString());
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
                $('#btnOKUpd').attr("disabled", "false");
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 添加新记录 需要 通过权限判断  管理员登录可以添加学院专业，教师只能添加非学院专业
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
       */
        async btnAddNewRecord_Click() {
            this.opType = "Add";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    ShowDialog('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecord();
                }
                else {
                    ShowDialog('Add');
                    const responseText = await this.AddNewRecord();
                }
                //读取session角色 来判断绑定不同数据列表
                //获取用户角色来判断显示不同的列表数据；
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                $("#hidUserId").val(strUserId);
                //判断角色 
                //管理员
                if (strRoleId == "00620001") {
                    $("#trvisible").show();
                }
                else if (strRoleId == "00620002") {
                    //教师
                    $("#trvisible").hide();
                    //根据登录人的Id查询教学班关系表得到教学班id 通过id得到学生数据；然后反向查询得到学生数据；
                }
                else {
                }
            }
            catch (e) {
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:把界面上的属性数据传到类对象中
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
     <param name = "pobjXzMajorEN">数据传输的目的类对象</param>
    */
        async PutDataToXzMajorClass(pobjXzMajorEN) {
            //通过角色判断，教师和管理员的区别；
            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
            $("#hidUserId").val(strUserId);
            //判断角色 
            //管理员
            if (strRoleId == "00620001") {
                pobjXzMajorEN.Setid_XzMajorShoolType(this.id_XzMajorShoolType); // 专业类型
                pobjXzMajorEN.Setid_XzCollege(this.id_XzCollege); // 学院 
            }
            else if (strRoleId == "00620002") {
                //教师
                pobjXzMajorEN.Setid_XzMajorShoolType("0001"); // 专业类型 0001代表非学院专业
                pobjXzMajorEN.Setid_XzCollege("0000"); // 学院 0000代表未知
            }
            else {
            }
            pobjXzMajorEN.SetMajorID(this.majorID); // 专业ID
            pobjXzMajorEN.SetMajorName(this.majorName); // 专业名称
            pobjXzMajorEN.SetIsVisible(this.isVisible); // 是否显示
            pobjXzMajorEN.SetMajorEnglishName(this.majorEnglishName); // 英文名
            pobjXzMajorEN.SetMajorExplain(this.majorExplain); // 专业说明
            pobjXzMajorEN.SetMajorDirection(this.majorDirection); // 专业方向
            pobjXzMajorEN.SetMemo(this.memo); // 备注
            pobjXzMajorEN.SetModifyUserID(clsPublocalStorage_js_1.clsPublocalStorage.userId.toString()); // userId;// 修改人
        }
        /* 为插入记录做准备工作
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
    */
        async AddNewRecord() {
            //去掉提交按钮不可用状态
            $('#btnOKUpd').attr("disabled", "false");
            this.opType = "AddWithMaxId";
            //  this.SetKeyReadOnly(false);
            this.btnSubmit_XzMajor = "确认添加";
            this.btnCancel_XzMajor = "取消添加";
            this.Clear();
            //wucXzMajorB1.id_XzMajor = XzMajor_GetMaxStrId_S();
            try {
                const responseText = await (0, clsXzMajorWApi_js_1.XzMajor_GetMaxStrIdAsync)();
                var returnString = responseText;
                if (returnString == "") {
                    var strInfo = `获取表XzMajor的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtid_XzMajor').val(returnString);
                }
            }
            catch (e) {
                console.log('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            //去掉提交按钮不可用状态
            $('#btnOKUpd').attr("disabled", "false");
            this.opType = "AddWithMaxId";
            //   this.SetKeyReadOnly(false);
            this.btnSubmit_XzMajor = "确认添加";
            this.btnCancel_XzMajor = "取消添加";
            this.Clear();
            //wucXzMajorB1.id_XzMajor = XzMajor_GetMaxStrId_S();
        }
        //只有选择了专业类型，才能选择学院；
        async ddlid_XzMajorShoolTypeClick() {
            try {
                //只有选择了专业类型，才能选择学院；
                if (this.id_XzMajorShoolType == "0002") {
                    //学院专业
                    var objXzClg_Cond = new clsXzClgEN_js_1.clsXzClgEN(); //编辑区域
                    const ddlid_XzCollege = await (0, clsXzClgWApi_js_1.XzClg_BindDdl_id_XzCollegeInDiv_Cache)(this.divName4Edit, "ddlid_XzCollege"); //编辑区域
                    //去掉提交按钮不可用状态
                    $('#ddlid_XzCollege').attr("disabled", "false");
                }
                else {
                    //非学院专业；
                    $('#ddlid_XzCollege').attr("disabled", "true");
                }
            }
            catch (e) {
                var strMsg = `获取数据有问题,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
    */
        async btnUpdateRecord_Click(strKeyId) {
            this.opType = "Update";
            //var strKeyId = GetFirstCheckedKeyIdInDiv();
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            //读取session角色 来判断绑定不同数据列表
            //获取用户角色来判断显示不同的列表数据；
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
            //判断角色 
            //管理员
            if (strRoleId == "00620001") {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    ShowDialog('Update');
                    this.bolIsLoadEditRegion = true; //
                    this.UpdateRecord(strKeyId);
                }
                else {
                    ShowDialog('Update');
                    this.UpdateRecord(strKeyId);
                }
            }
            else if (strRoleId == "00620002") {
                //教师
                //修改前需要判断 数据是否是当前用户添加 是则可以修改，否则不可修改；
                const responseText = await (0, clsXzMajorWApi_js_1.XzMajor_GetObjByid_XzMajorAsync)(strKeyId);
                var objXzMajorEN = responseText;
                if (objXzMajorEN.modifyUserID == strUserId) {
                    if (this.bolIsLoadEditRegion == false) //
                     {
                        const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                        // 为编辑区绑定下拉框
                        const conBindDdl = await this.BindDdl4EditRegionInDiv();
                        ShowDialog('Update');
                        this.bolIsLoadEditRegion = true; //
                        this.UpdateRecord(strKeyId);
                    }
                    else {
                        ShowDialog('Update');
                        this.UpdateRecord(strKeyId);
                    }
                }
                else {
                    var strInfo = `当前数据不是您添加，不可修改`;
                    //显示信息框
                    alert(strInfo);
                    return;
                }
            }
        }
    }
    exports.XzMajor_EditEx = XzMajor_EditEx;
});
