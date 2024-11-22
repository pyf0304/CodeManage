(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/ParameterTable/ViewpointType_Edit.js", "../TS/L0_Entity/ParameterTable/clsViewpointTypeEN.js", "../TS/L3_ForWApi/ParameterTable/clsViewpointTypeWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ViewpointType_EditEx = void 0;
    /**
    * 类名:ViewpointType_EditEx(界面:ViewpointTypeCRUD)
    * 表名:ViewpointType(01120544)
    * 版本:2023.01.04.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/06 22:43:16
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培参数(ParameterTable)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const ViewpointType_Edit_js_1 = require("../PagesBase/ParameterTable/ViewpointType_Edit.js");
    const clsViewpointTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsViewpointTypeEN.js");
    const clsViewpointTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsViewpointTypeWApi.js");
    /* ViewpointType_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
   */
    class ViewpointType_EditEx extends ViewpointType_Edit_js_1.ViewpointType_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = ViewpointType_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(ViewpointType_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 添加新记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
      */
        async AddNewRecordSave() {
            //try {
            //    const responseText = ViewpointType_GetMaxStrIdAsync().then((jsonData) => {
            //        var returnString: string = jsonData.toString();
            //        if (returnString == "") {
            //            var strInfo: string = `获取表txtViewpointTypeId的最大关键字为空，不成功，请检查!`;
            //            //显示信息框
            //            alert(strInfo);
            //        }
            //        else {
            //            $('#txtViewpointTypeId').val(returnString); 
            //        }
            //    });
            //}
            //catch (e) {
            //    console.error('catch(e)=');
            //    console.error(e);
            //    var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
            //    alert(strMsg);
            //}
            var objViewpointTypeEN = new clsViewpointTypeEN_js_1.clsViewpointTypeEN();
            this.PutDataToViewpointTypeClass(objViewpointTypeEN);
            try {
                //const responseText = await ViewpointType_IsExistAsync(objViewpointTypeEN.viewpointTypeId);
                //var bolIsExist: boolean = responseText;
                //if (bolIsExist == true) {
                //    var strMsg: string = `添加记录时，关键字：${objViewpointTypeEN.viewpointTypeId}已经存在！`;
                //    alert(strMsg);
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
                const responseText2 = await (0, clsViewpointTypeWApi_js_1.ViewpointType_AddNewRecordAsync)(objViewpointTypeEN);
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
            }
            return true; //一定要有一个返回值，否则会出错！
        }
    }
    exports.ViewpointType_EditEx = ViewpointType_EditEx;
});
