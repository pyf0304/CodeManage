(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/BaseInfo/XzMajorDirection_Edit.js", "../TS/L0_Entity/BaseInfo_Share/clsXzMajorDirectionEN.js", "../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzMajorDirection_EditEx = void 0;
    /**
    * 类名:XzMajorDirection_EditEx(界面:XzMajorDirectionCRUD)
    * 表名:XzMajorDirection(01120552)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/03 14:34:22
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:基本信息维护(BaseInfo)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const XzMajorDirection_Edit_js_1 = require("../PagesBase/BaseInfo/XzMajorDirection_Edit.js");
    const clsXzMajorDirectionEN_js_1 = require("../TS/L0_Entity/BaseInfo_Share/clsXzMajorDirectionEN.js");
    const clsXzMajorDirectionWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* XzMajorDirection_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class XzMajorDirection_EditEx extends XzMajorDirection_Edit_js_1.XzMajorDirection_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = XzMajorDirection_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(XzMajorDirection_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        async btnOKUpd_Click() {
            var strCommandText = this.btnSubmit_XzMajorDirection;
            try {
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
                                    this.iShowList.BindGv_Cache(clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN._CurrTabName, "");
                                }
                            });
                        }
                        else {
                            var returnBool = await this.AddNewRecordSave();
                            if (returnBool == true) {
                                HideDialog();
                                //this.BindGv_vXzMajorDirection();
                                this.iShowList.BindGv_Cache(clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN._CurrTabName, "");
                            }
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        var returnBool = await this.UpdateRecordSave();
                        if (returnBool == true) {
                            (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_ReFreshCache)(clsPublocalStorage_js_1.clsPublocalStorage.id_XzMajor);
                            HideDialog();
                            this.iShowList.BindGv_Cache(clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN._CurrTabName, "");
                        }
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                        alert(strMsg);
                        break;
                }
                $('#divLoading').hide();
                //去掉提交按钮不可用状态
                $('#btnOKUpd').attr("disabled", "false");
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(strMajorDirectionId) {
            this.btnSubmit_XzMajorDirection = "确认修改";
            this.btnCancel_XzMajorDirection = "取消修改";
            this.keyId = strMajorDirectionId;
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_GetObjByMajorDirectionIdAsync)(strMajorDirectionId).then((jsonData) => {
                        var objXzMajorDirectionEN = jsonData;
                        // //通过判断数据用户是否是当前登录用户；
                        if (objXzMajorDirectionEN.updUser == strUserId) {
                            ShowDialog('Update');
                            this.GetDataFromXzMajorDirectionClass(objXzMajorDirectionEN);
                            console.log("完成UpdateRecord!");
                            //resolve(jsonData);
                        }
                        else {
                            alert("当前数据不是您所添加，不能修改！");
                            return;
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
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            try {
                const responseText = (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_GetMaxStrIdAsync)().then((jsonData) => {
                    var returnString = jsonData.toString();
                    if (returnString == "") {
                        var strInfo = `获取表XzMajorDirection的最大关键字为空，不成功，请检查!`;
                        //显示信息框
                        alert(strInfo);
                    }
                    else {
                        $('#txtMajorDirectionId').val(returnString);
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
            var objXzMajorDirectionEN = new clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN();
            this.PutDataToXzMajorDirectionClass(objXzMajorDirectionEN);
            try {
                //const responseText = await XzMajorDirection_IsExistAsync(objXzMajorDirectionEN.majorDirectionId);
                //var bolIsExist: boolean = responseText;
                //if (bolIsExist == true) {
                //    var strMsg: string = `添加记录时，关键字：${objXzMajorDirectionEN.majorDirectionId}已经存在！`;
                //    alert(strMsg);
                //    return responseText;//一定要有一个返回值，否则会出错！
                //}
                const responseText2 = await (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_AddNewRecordAsync)(objXzMajorDirectionEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_ReFreshCache)(clsPublocalStorage_js_1.clsPublocalStorage.id_XzMajor);
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
    exports.XzMajorDirection_EditEx = XzMajorDirection_EditEx;
});
