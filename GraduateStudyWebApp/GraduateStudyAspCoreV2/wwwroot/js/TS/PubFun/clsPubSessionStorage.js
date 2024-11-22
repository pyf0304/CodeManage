(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsPubSessionStorage = void 0;
    class clsPubSessionStorage {
        //////////////////////////////////////////////////////////用户List/////////////////////////////////////////////////////////////
        //获取用户Lst
        static GetUserLst() {
            var strKey = "UserLst";
            var strUserId = "";
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strUserId = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存用户Lst为空！");
            }
            return strUserId;
        }
        //设置用户Lst
        static SetUserLst(strUserLst) {
            try {
                //清空本类缓存
                var strKey = "UserLst";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strUserLst);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //获取分页当前页
        static get PaperNum() {
            var strKey = "PaperNum";
            var strPaperNum = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strPaperNum = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存strEduClsTypeID为空！");
            }
            return strPaperNum;
        }
        //设置分页当前页
        static set PaperNum(strPaperNum) {
            try {
                //清空本类缓存
                var strKey = "PaperNum";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strPaperNum);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        static get applicationTypeId() {
            const strKey = "applicationTypeId";
            let strApplicationTypeId = "";
            if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
                //缓存存在，直接返回
                strApplicationTypeId = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存currSelPrjId为空！");
            }
            return strApplicationTypeId;
        }
        //设置教学班Id
        static set applicationTypeId(strApplicationTypeId) {
            try {
                //清空本类缓存
                const strKey = "applicationTypeId";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strApplicationTypeId);
            }
            catch (e) {
                console.error(e);
                const strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        static get applicationTypeName() {
            const strKey = "applicationTypeName";
            let strApplicationTypeName = "";
            if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
                //缓存存在，直接返回
                strApplicationTypeName = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存currSelPrjId为空！");
            }
            return strApplicationTypeName;
        }
        //设置教学班Id
        static set applicationTypeName(strApplicationTypeName) {
            try {
                //清空本类缓存
                const strKey = "applicationTypeName";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strApplicationTypeName);
            }
            catch (e) {
                console.error(e);
                const strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        static get currDataBaseTypeId() {
            const strKey = "currDataBaseTypeId";
            let strCurrDataBaseTypeId = "";
            if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
                //缓存存在，直接返回
                strCurrDataBaseTypeId = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存currSelPrjId为空！");
            }
            return strCurrDataBaseTypeId;
        }
        //设置教学班Id
        static set currDataBaseTypeId(strCurrDataBaseTypeId) {
            try {
                //清空本类缓存
                const strKey = "currDataBaseTypeId";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strCurrDataBaseTypeId);
            }
            catch (e) {
                console.error(e);
                const strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////专业/////////////////////////////////////////////////////////////
        //获取用户ID
        static get majorName() {
            const strKey = "majorName";
            let strMajorName = "";
            if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
                //缓存存在，直接返回
                strMajorName = sessionStorage.getItem(strKey);
            }
            else {
                console.error("缓存majorName为空！");
            }
            return strMajorName;
        }
        //设置用户Id
        static set majorName(strMajorName) {
            try {
                //清空本类缓存
                const strKey = "majorName";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strMajorName);
            }
            catch (e) {
                const strMsg = `存入缓存出错,${e}.`;
                console.error(strMsg);
                throw (strMsg);
            }
        }
    }
    exports.clsPubSessionStorage = clsPubSessionStorage;
    ;
});
