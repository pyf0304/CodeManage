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
    0;
    //import * as QQ from "q";
    var ResponseData;
    var clsPubSessionStorage = /** @class */ (function () {
        function clsPubSessionStorage() {
        }
        //////////////////////////////////////////////////////////教学班Id/////////////////////////////////////////////////////////////
        //获取教学班Id
        clsPubSessionStorage.GetSession_id_CurrEduClass = function () {
            var strKey = "id_CurrEduClass";
            var strid_CurrEduClass = "";
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strid_CurrEduClass = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存id_CurrEduClass为空！");
            }
            return strid_CurrEduClass;
        };
        //设置教学班Id
        clsPubSessionStorage.SetSession_id_CurrEduClass = function (strid_CurrEduClass) {
            try {
                //清空本类缓存
                var strKey = "id_CurrEduClass";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strid_CurrEduClass);
            }
            catch (e) {
                console.log(e);
                var strMsg = "\u5B58\u5165\u7F13\u5B58\u51FA\u9519," + e + ".";
                throw (strMsg);
            }
        };
        //////////////////////////////////////////////////////////用户Id/////////////////////////////////////////////////////////////
        //获取用户ID
        clsPubSessionStorage.GetSession_UserId = function () {
            var strKey = "UserId";
            var strUserId = "";
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strUserId = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存UserId为空！");
            }
            return strUserId;
        };
        //设置用户Id
        clsPubSessionStorage.SetSession_UserId = function (strUserId) {
            try {
                //清空本类缓存
                var strKey = "UserId";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strUserId);
            }
            catch (e) {
                console.log(e);
                var strMsg = "\u5B58\u5165\u7F13\u5B58\u51FA\u9519," + e + ".";
                throw (strMsg);
            }
        };
        //////////////////////////////////////////////////////////用户名称/////////////////////////////////////////////////////////////
        //获取用户ID
        clsPubSessionStorage.GetSession_UserName = function () {
            var strKey = "UserName";
            var strUserName = "";
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strUserName = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存UserName为空！");
            }
            return strUserName;
        };
        //设置用户Id
        clsPubSessionStorage.SetSession_UserName = function (strUserName) {
            try {
                //清空本类缓存
                var strKey = "UserName";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strUserName);
            }
            catch (e) {
                console.log(e);
                var strMsg = "\u5B58\u5165\u7F13\u5B58\u51FA\u9519," + e + ".";
                throw (strMsg);
            }
        };
        //////////////////////////////////////////////////////////角色Id/////////////////////////////////////////////////////////////
        //获取用户ID
        clsPubSessionStorage.GetSession_RoleId = function () {
            var strKey = "RoleId";
            var strRoleId = "";
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strRoleId = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存RoleId为空！");
            }
            return strRoleId;
        };
        //设置用户Id
        clsPubSessionStorage.SetSession_RoleId = function (strRoleId) {
            try {
                //清空本类缓存
                var strKey = "RoleId";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strRoleId);
            }
            catch (e) {
                console.log(e);
                var strMsg = "\u5B58\u5165\u7F13\u5B58\u51FA\u9519," + e + ".";
                throw (strMsg);
            }
        };
        //////////////////////////////////////////////////////////角色名称/////////////////////////////////////////////////////////////
        //获取用户ID
        clsPubSessionStorage.GetSession_RoleName = function () {
            var strKey = "RoleName";
            var strRoleName = "";
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strRoleName = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存RoleName为空！");
            }
            return strRoleName;
        };
        //设置用户Id
        clsPubSessionStorage.SetSession_RoleName = function (strRoleName) {
            try {
                //清空本类缓存
                var strKey = "RoleName";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strRoleName);
            }
            catch (e) {
                console.log(e);
                var strMsg = "\u5B58\u5165\u7F13\u5B58\u51FA\u9519," + e + ".";
                throw (strMsg);
            }
        };
        //////////////////////////////////////////////////////////专业ID/////////////////////////////////////////////////////////////
        //专业ID
        clsPubSessionStorage.GetSession_id_XzMajor = function () {
            var strKey = "id_XzMajor";
            var strid_XzMajor = "";
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strid_XzMajor = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存id_XzMajor为空！");
            }
            return strid_XzMajor;
        };
        //设置用户Id
        clsPubSessionStorage.SetSession_id_XzMajor = function (strid_XzMajor) {
            try {
                //清空本类缓存
                var strKey = "id_XzMajor";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strid_XzMajor);
            }
            catch (e) {
                console.log(e);
                var strMsg = "\u5B58\u5165\u7F13\u5B58\u51FA\u9519," + e + ".";
                throw (strMsg);
            }
        };
        //////////////////////////////////////////////////////////专业/////////////////////////////////////////////////////////////
        //获取用户ID
        clsPubSessionStorage.GetSession_MajorName = function () {
            var strKey = "MajorName";
            var strMajorName = "";
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strMajorName = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存MajorName为空！");
            }
            return strMajorName;
        };
        //设置用户Id
        clsPubSessionStorage.SetSession_MajorName = function (strMajorName) {
            try {
                //清空本类缓存
                var strKey = "MajorName";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strMajorName);
            }
            catch (e) {
                console.log(e);
                var strMsg = "\u5B58\u5165\u7F13\u5B58\u51FA\u9519," + e + ".";
                throw (strMsg);
            }
        };
        //////////////////////////////////////////////////////////用户List/////////////////////////////////////////////////////////////
        //获取用户Lst
        clsPubSessionStorage.GetUserLst = function () {
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
        };
        //设置用户Lst
        clsPubSessionStorage.SetUserLst = function (strUserLst) {
            try {
                //清空本类缓存
                var strKey = "UserLst";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strUserLst);
            }
            catch (e) {
                console.log(e);
                var strMsg = "\u5B58\u5165\u7F13\u5B58\u51FA\u9519," + e + ".";
                throw (strMsg);
            }
        };
        return clsPubSessionStorage;
    }());
    exports.clsPubSessionStorage = clsPubSessionStorage;
    ;
});
