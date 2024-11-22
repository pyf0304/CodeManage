(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/ParameterTable/SubViewpointType_Edit.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js", "../TS/L3_ForWApiEx/GraduateEdu/clsSubViewpointTypeWApiEx.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SubViewpointType_EditEx = void 0;
    /**
    * 类名:SubViewpointType_EditEx(界面:SubViewpointTypeCRUD)
    * 表名:SubViewpointType(01120533)
    * 版本:2023.01.04.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/06 22:44:04
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培参数(ParameterTable)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const SubViewpointType_Edit_js_1 = require("../PagesBase/ParameterTable/SubViewpointType_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsSubViewpointTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js");
    const clsSubViewpointTypeWApiEx_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsSubViewpointTypeWApiEx.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* SubViewpointType_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class SubViewpointType_EditEx extends SubViewpointType_Edit_js_1.SubViewpointType_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = SubViewpointType_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(SubViewpointType_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        //添加数据事件
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
      */
        async btnOKUpd_Click() {
            var strCommandText = this.btnSubmit_SubViewpointType;
            try {
                //这是一个单表的插入的代码,由于逻辑层太简单,
                //就把逻辑层合并到控制层,
                const returnBool = await this.AddNewRecordSave();
                if (returnBool == true) {
                    //HideDialog();
                    this.Clear();
                    window.location.href = "#pageOne";
                    //去掉主页动态标签防止缓存问题；
                    $("#SubviewPointType li").not(":first").remove();
                    this.iShowList.BindGv(clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN._CurrTabName, returnBool.toString());
                }
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
            var objSubViewpointTypeEN = new clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN();
            this.PutDataToSubViewpointTypeClass(objSubViewpointTypeEN);
            try {
                //const responseText = await SubViewpointType_IsExistAsync(objSubViewpointTypeEN.subViewpointTypeId);
                //var bolIsExist: boolean = responseText;
                //if (bolIsExist == true) {
                //    var strMsg: string = `添加记录时，关键字：${objSubViewpointTypeEN.subViewpointTypeId}已经存在！`;
                //    alert(strMsg);
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
                //const responseText2 = await SubViewpointType_AddNewRecordAsync(objSubViewpointTypeEN);
                const responseText2 = await clsSubViewpointTypeWApiEx_js_1.clsSubViewpointTypeWApiEx.AddNewRecordAsyncEx(objSubViewpointTypeEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
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
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjSubViewpointTypeEN">数据传输的目的类对象</param>
      */
        async PutDataToSubViewpointTypeClass(pobjSubViewpointTypeEN) {
            //pobjSubViewpointTypeEN.subViewpointTypeId = this.subViewpointTypeId;// 类型Id
            pobjSubViewpointTypeEN.subViewpointTypeName = this.subViewpointTypeName; // 类型名称
            pobjSubViewpointTypeEN.SetOrderNum(1); // this.arrSubViewpointTypeObjLstCount++;// 序号
            pobjSubViewpointTypeEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            pobjSubViewpointTypeEN.SetUpdUserId(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
            pobjSubViewpointTypeEN.SetMemo(this.memo); // 备注
        }
    }
    exports.SubViewpointType_EditEx = SubViewpointType_EditEx;
});