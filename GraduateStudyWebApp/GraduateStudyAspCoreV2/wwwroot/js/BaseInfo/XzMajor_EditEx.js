(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/BaseInfo/XzMajor_Edit.js", "../TS/L0_Entity/BaseInfo_Share/clsXzClgEN.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzMajor_EditEx = void 0;
    /**
    * 类名:XzMajor_EditEx(界面:XzMajorCRUD)
    * 表名:XzMajor(01120065)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/07 17:00:47
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:基本信息维护(BaseInfo)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const XzMajor_Edit_js_1 = require("../PagesBase/BaseInfo/XzMajor_Edit.js");
    const clsXzClgEN_js_1 = require("../TS/L0_Entity/BaseInfo_Share/clsXzClgEN.js");
    const clsXzClgWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js");
    const clsXzMajorWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
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
                console.error('catch(e)=');
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
            //var strKeyId = GetFirstCheckedKeyIdInDiv(objPage.divName4List);;
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
