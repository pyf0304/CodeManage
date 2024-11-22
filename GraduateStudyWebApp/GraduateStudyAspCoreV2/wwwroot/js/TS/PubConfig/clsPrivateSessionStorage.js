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
    exports.clsPrivateSessionStorage = void 0;
    class clsPrivateSessionStorage {
        //////////////////////////////////////////////////////////学生流水号/////////////////////////////////////////////////////////////
        //获取学生流水号ID
        static GetId_Stu() {
            var strKey = "id_StudentInfo";
            var strId_Stu = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strId_Stu = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存Id_Stu为空！");
            }
            return strId_Stu;
        }
        //设置学生流水号Id
        static SetId_Stu(strId_Stu) {
            try {
                //清空本类缓存
                var strKey = "id_StudentInfo";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strId_Stu);
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
        static GetSession_MajorName() {
            var strKey = "majorName";
            var strMajorName = "";
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strMajorName = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存majorName为空！");
            }
            return strMajorName;
        }
        //设置用户Id
        static SetSession_MajorName(strMajorName) {
            try {
                //清空本类缓存
                var strKey = "majorName";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strMajorName);
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
            var strUserLst = "";
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strUserLst = sessionStorage.getItem(strKey);
            }
            else {
                console.log("缓存用户Lst为空！");
            }
            return strUserLst;
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
        //////////////////////////////////////////////////////////主题Id/////////////////////////////////////////////////////////////
        //获取用户ID
        static get topicId() {
            const strKey = "topicId";
            let strTopicId = "";
            if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
                //缓存存在，直接返回
                strTopicId = sessionStorage.getItem(strKey);
            }
            else {
                console.error("缓存topicId为空！");
            }
            return strTopicId;
        }
        //设置用户Id
        static set topicId(strTopicId) {
            try {
                //清空本类缓存
                const strKey = "topicId";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strTopicId);
            }
            catch (e) {
                const strMsg = `存入缓存出错,${e}.`;
                console.error(strMsg);
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////主题Id/////////////////////////////////////////////////////////////
        //获取用户ID
        static get topicName() {
            const strKey = "topicName";
            let strTopicName = "";
            if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
                //缓存存在，直接返回
                strTopicName = sessionStorage.getItem(strKey);
            }
            else {
                console.error("缓存topicName为空！");
            }
            return strTopicName;
        }
        //设置用户Id
        static set topicName(strTopicName) {
            try {
                //清空本类缓存
                const strKey = "topicName";
                sessionStorage.removeItem(strKey);
                //把值存入session
                sessionStorage.setItem(strKey, strTopicName);
            }
            catch (e) {
                const strMsg = `存入缓存出错,${e}.`;
                console.error(strMsg);
                throw (strMsg);
            }
        }
    }
    exports.clsPrivateSessionStorage = clsPrivateSessionStorage;
    ;
});
