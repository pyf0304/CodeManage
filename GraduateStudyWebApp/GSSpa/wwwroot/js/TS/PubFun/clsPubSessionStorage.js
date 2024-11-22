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
    0;
    //import * as QQ from "q";
    var ResponseData;
    class clsPubSessionStorage {
        ////////////////////////////////////////////////////////////教学班Id/////////////////////////////////////////////////////////////
        ////获取教学班Id
        //public static GetSession_id_CurrEduCls(): string {
        //    var strKey: string = "id_CurrEduCls";
        //    var strid_CurrEduCls: string = "";
        //    if (sessionStorage.hasOwnProperty(strKey)) {
        //        //缓存存在，直接返回
        //        strid_CurrEduCls = sessionStorage.getItem(strKey) as string;
        //    }
        //    else {
        //        console.log("缓存id_CurrEduCls为空！");
        //    }
        //    return strid_CurrEduCls;
        //}
        ////设置教学班Id
        //public static SetSession_id_CurrEduCls(strid_CurrEduCls: string) {
        //    try {
        //        //清空本类缓存
        //        var strKey: string = "id_CurrEduCls";
        //        sessionStorage.removeItem(strKey);
        //        //把值存入session
        //        sessionStorage.setItem(strKey, strid_CurrEduCls);
        //    }
        //    catch (e) {
        //        console.error(e);
        //        var strMsg: string = `存入缓存出错,${e}.`;
        //        throw (strMsg);
        //    }
        //}
        //////////////////////////////////////////////////////////用户Id/////////////////////////////////////////////////////////////
        //获取用户ID
        static GetSession_UserId() {
            var strKey = "userId";
            var strUserId = "";
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strUserId = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存userId为空！");
            }
            return strUserId;
        }
        //设置用户Id
        static SetSession_UserId(strUserId) {
            try {
                //清空本类缓存
                var strKey = "userId";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strUserId);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////用户名称/////////////////////////////////////////////////////////////
        //获取用户ID
        static GetSession_UserName() {
            var strKey = "userName";
            var strUserName = "";
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strUserName = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存userName为空！");
            }
            return strUserName;
        }
        //设置用户Id
        static SetSession_UserName(strUserName) {
            try {
                //清空本类缓存
                var strKey = "userName";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strUserName);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////角色Id/////////////////////////////////////////////////////////////
        //获取用户ID
        static GetSession_RoleId() {
            var strKey = "roleId";
            var strRoleId = "";
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strRoleId = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存roleId为空！");
            }
            return strRoleId;
        }
        //设置用户Id
        static SetSession_RoleId(strRoleId) {
            try {
                //清空本类缓存
                var strKey = "roleId";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strRoleId);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////角色名称/////////////////////////////////////////////////////////////
        //获取用户ID
        static GetSession_RoleName() {
            var strKey = "roleName";
            var strRoleName = "";
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strRoleName = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存roleName为空！");
            }
            return strRoleName;
        }
        //设置用户Id
        static SetSession_RoleName(strRoleName) {
            try {
                //清空本类缓存
                var strKey = "roleName";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strRoleName);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////专业ID/////////////////////////////////////////////////////////////
        //专业ID
        static GetSession_id_XzMajor() {
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
        }
        //设置用户Id
        static SetSession_id_XzMajor(strid_XzMajor) {
            try {
                //清空本类缓存
                var strKey = "id_XzMajor";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strid_XzMajor);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////专业/////////////////////////////////////////////////////////////
        //获取用户ID
        static GetSession_majorName() {
            var strKey = "majorName";
            var strmajorName = "";
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strmajorName = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存majorName为空！");
            }
            return strmajorName;
        }
        //设置用户Id
        static SetSession_majorName(strmajorName) {
            try {
                //清空本类缓存
                var strKey = "majorName";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strmajorName);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
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
        //////////////////////////////////////////////////////////用户Id/////////////////////////////////////////////////////////////
        //获取用户ID
        static get userId() {
            var strKey = "userId";
            var strUserId = "";
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strUserId = sessionStorage.getItem(strKey);
            }
            else {
                console.error("缓存userId为空！");
            }
            return strUserId;
        }
        //设置用户Id
        static set userId(strUserId) {
            try {
                //清空本类缓存
                var strKey = "userId";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strUserId);
            }
            catch (e) {
                var strMsg = `存入缓存出错,${e}.`;
                console.error(strMsg);
                throw (strMsg);
            }
        }
    }
    exports.clsPubSessionStorage = clsPubSessionStorage;
    ;
});
