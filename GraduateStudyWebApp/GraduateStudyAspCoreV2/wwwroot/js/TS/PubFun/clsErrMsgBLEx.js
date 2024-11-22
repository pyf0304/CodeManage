(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsErrMsgBLEx = exports.clsErrMsgENEx = exports.conErrType = void 0;
    const clsString_js_1 = require("./clsString.js");
    class conErrType {
        static get con_QryRegion() { return "查询区错误"; } //类Id
        static get con_EditRegion() { return "编辑区错误"; } //类Id
        static get con_DetailRegion() { return "详细区错误"; } //类Id
        static get con_ExcelExportRegion() { return "Excel导出区错误"; } //类Id
        static get con_FeatureRegion() { return "功能区错误"; } //类Id
        static get con_ListRegion() { return "列表区错误"; } //类Id
        static get con_TabField() { return "表字段错误"; } //类Id
        static get con_CmClassId() { return "cmClassId"; } //类Id
    }
    exports.conErrType = conErrType;
    class clsErrMsgENEx {
        constructor(strErrType, intErrNum) {
            this.ErrType = "";
            this.ErrNum = 0;
            this.ErrType = strErrType;
            this.ErrNum = intErrNum;
        }
        toString() {
            if ((0, clsString_js_1.IsNullOrEmpty)(this.ErrType) == true)
                return "";
            if (this.ErrNum == 0)
                return "";
            return this.ErrType + ": " + this.ErrNum.toString();
        }
        static GetObjByErrMsg(strErrMsg) {
            const objErrMsg = new clsErrMsgENEx("", 0);
            var arr = strErrMsg.split(':');
            if (arr.length == 0)
                throw ("错误信息不能为空！");
            if (arr.length >= 1) {
                objErrMsg.ErrType = arr[0];
            }
            if (arr.length >= 2) {
                try {
                    objErrMsg.ErrNum = Number(arr[1]);
                }
                catch (_a) {
                    objErrMsg.ErrNum = 0;
                }
            }
            return objErrMsg;
        }
    }
    exports.clsErrMsgENEx = clsErrMsgENEx;
    class clsErrMsgBLEx {
        static GetErrMsgObjLstByErrMsg(strErrMsgLst) {
            const arrErrMsg = new Array();
            var arrErrMsgLst = strErrMsgLst.split(';');
            if (arrErrMsgLst.length == 0)
                return arrErrMsg;
            for (var strErrMsg in arrErrMsgLst) {
                var objErrMsg = clsErrMsgENEx.GetObjByErrMsg(strErrMsg);
                if (objErrMsg != null)
                    arrErrMsg.push(objErrMsg);
            }
            return arrErrMsg;
        }
        static GetErrMsgByObjLst(arrErrMsg) {
            var arrErrMsgLst = arrErrMsg.map(x => x.toString());
            const strErrMsgLst = arrErrMsgLst.join(";");
            return strErrMsgLst;
        }
        static AddObj(arrErrMsg, objErrMsg_New) {
            if (arrErrMsg.filter(x => x.ErrType == objErrMsg_New.ErrType).length == 0) {
                arrErrMsg.push(objErrMsg_New);
                return true;
            }
            var arrErrMsg_Del = arrErrMsg.filter(x => x.ErrType == objErrMsg_New.ErrType);
            arrErrMsg_Del.push(objErrMsg_New);
            return true;
        }
    }
    exports.clsErrMsgBLEx = clsErrMsgBLEx;
});
