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
    exports.clsPublocalStorage = void 0;
    class clsPublocalStorage {
        ////获取教学班对象
        //public static async GetCurrEduClsObjLst() {
        //    //初始化列表缓存
        //    var strWhereCond: string = "1=1";
        //    CurrEduCls_InitListCache();
        //    var strKey: string = clsCurrEduClsEN._CurrTabName;
        //    if (strKey == "") {
        //        console.log("关键字为空！不正确");
        //        throw new Error("关键字为空！不正确");
        //    }
        //    if (localStorage.hasOwnProperty(strKey)) {
        //        //缓存存在，直接返回
        //        var strTempObjLst: string = localStorage.getItem(strKey) as string;
        //        var arrCurrEduClsObjLst_Cache: Array<clsCurrEduClsEN> = JSON.parse(strTempObjLst);
        //        return arrCurrEduClsObjLst_Cache;
        //    }
        //}
        //public static async SetCurrEduClsObjLstObjLst(strid_CurrEduCls: string) {
        //    //清空本类缓存
        //    const responseText0 = await CurrEduCls_ReFreshThisCache(strCourseId);
        //    //初始化列表缓存
        //    var strWhereCond: string = "1=1 and id_CurrEduCls='" + strid_CurrEduCls+"'";
        //    CurrEduCls_InitListCache();
        //    var strKey: string = clsCurrEduClsEN._CurrTabName;
        //    if (strKey == "") {
        //        console.log("关键字为空！不正确");
        //        throw new Error("关键字为空！不正确");
        //    }
        //    try {
        //        //把当前教学班存入缓存内
        //        const responseText = await clsCurrEduClsWApi.GetObjLstAsync(strWhereCond);
        //        var arrCurrEduClsObjLst: Array<clsCurrEduClsEN> = <Array<clsCurrEduClsEN>>responseText;
        //        localStorage.setItem(strKey, JSON.stringify(arrCurrEduClsObjLst));
        //        var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrCurrEduClsObjLst.length}!`;
        //        console.log(strInfo);
        //        return arrCurrEduClsObjLst;
        //    }
        //    catch (e) {
        //        console.log("GetObjLst_Cache:e");
        //        console.error(e);
        //        var strMsg: string = `从缓存中获取所有对象列表出错,${e}.`;
        //        throw (strMsg);
        //    }
        //}
        //////////////////////////////////////////////////////////教学班Id/////////////////////////////////////////////////////////////
        //获取教学班Id
        static get id_CurrEduCls() {
            var strKey = "id_CurrEduCls";
            var strid_CurrEduCls = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strid_CurrEduCls = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存id_CurrEduCls为空！");
            }
            return strid_CurrEduCls;
        }
        //设置教学班Id
        static set id_CurrEduCls(strid_CurrEduCls) {
            try {
                //清空本类缓存
                var strKey = "id_CurrEduCls";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strid_CurrEduCls);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////课程Id/////////////////////////////////////////////////////////////
        //获取课程Id
        static get courseId() {
            var strKey = "courseId";
            var strCourseId = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strCourseId = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存courseId为空！");
            }
            return strCourseId;
        }
        //设置课程Id
        static set courseId(strCourseId) {
            try {
                //清空本类缓存
                var strKey = "courseId";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strCourseId);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //获取课程名称
        static get courseName() {
            var strKey = "courseName";
            var strCourseName = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strCourseName = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存strCourseName为空！");
            }
            return strCourseName;
        }
        //设置课程名称
        static set courseName(strCourseName) {
            try {
                //清空本类缓存
                var strKey = "courseName";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strCourseName);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////教学班类型Id/////////////////////////////////////////////////////////////
        //获取教学班Id
        static get eduClsTypeId() {
            var strKey = "eduClsTypeId";
            var strEduClsTypeId = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strEduClsTypeId = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存strEduClsTypeId为空！");
            }
            return strEduClsTypeId;
        }
        //设置教学班Id
        static set eduClsTypeId(strEduClsTypeId) {
            try {
                //清空本类缓存
                var strKey = "eduClsTypeId";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strEduClsTypeId);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////教学班/////////////////////////////////////////////////////////////
        //获取教学班名称
        static get eduClsName() {
            var strKey = "eduClsName";
            var strid_CurrEduCls = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strid_CurrEduCls = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存eduClsName为空！");
            }
            return strid_CurrEduCls;
        }
        //设置教学班名称
        static set eduClsName(strEduClsName) {
            try {
                //清空本类缓存
                var strKey = "eduClsName";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strEduClsName);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////学生流水号/////////////////////////////////////////////////////////////
        //获取学生流水号ID
        static get id_Stu() {
            var strKey = "id_StudentInfo";
            var strUserId = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strUserId = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存userId为空！");
            }
            return strUserId;
        }
        //设置学生流水号Id
        static set id_Stu(strUserId) {
            try {
                //清空本类缓存
                var strKey = "id_StudentInfo";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strUserId);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////主题用户关系列表/////////////////////////////////////////////////////////////
        //获取主题用户关系
        static get TopicUserList() {
            var strKey = "TopicUserList";
            var strTopicUserList = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strTopicUserList = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存strEduClsTypeId为空！");
            }
            return strTopicUserList;
        }
        //设置主题用户关系
        static set TopicUserList(strTopicUserList) {
            try {
                //清空本类缓存
                var strKey = "TopicUserList";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strTopicUserList);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////专业ID/////////////////////////////////////////////////////////////
        //专业ID
        static get id_XzMajor() {
            var strKey = "id_XzMajor";
            var strid_XzMajor = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strid_XzMajor = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存id_XzMajor为空！");
            }
            return strid_XzMajor;
        }
        //设置用户Id
        static set id_XzMajor(strid_XzMajor) {
            try {
                //清空本类缓存
                var strKey = "id_XzMajor";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strid_XzMajor);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////专业/////////////////////////////////////////////////////////////
        //获取用户ID
        static get majorName() {
            var strKey = "majorName";
            var strMajorName = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strMajorName = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存majorName为空！");
            }
            return strMajorName;
        }
        //设置用户Id
        static set majorName(strMajorName) {
            try {
                //清空本类缓存
                var strKey = "majorName";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strMajorName);
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
            const strKey = "userId";
            let strUserId = "";
            if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
                //缓存存在，直接返回
                strUserId = localStorage.getItem(strKey);
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
                const strKey = "userId";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strUserId);
            }
            catch (e) {
                const strMsg = `存入缓存出错,${e}.`;
                console.error(strMsg);
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////角色Id/////////////////////////////////////////////////////////////
        //获取用户ID
        static get roleId() {
            const strKey = "roleId";
            let strRoleId = "";
            if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
                //缓存存在，直接返回
                strRoleId = localStorage.getItem(strKey);
            }
            else {
                console.error("缓存roleId为空！");
            }
            return strRoleId;
        }
        //设置用户Id
        static set roleId(strRoleId) {
            try {
                //清空本类缓存
                const strKey = "roleId";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strRoleId);
            }
            catch (e) {
                const strMsg = `存入缓存出错,${e}.`;
                console.error(strMsg);
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////角色名称/////////////////////////////////////////////////////////////
        //获取用户ID
        static get roleName() {
            const strKey = "roleName";
            let strRoleName = "";
            if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
                //缓存存在，直接返回
                strRoleName = localStorage.getItem(strKey);
            }
            else {
                console.error("缓存roleName为空！");
            }
            return strRoleName;
        }
        //设置用户Id
        static set roleName(strRoleName) {
            try {
                //清空本类缓存
                const strKey = "roleName";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strRoleName);
            }
            catch (e) {
                const strMsg = `存入缓存出错,${e}.`;
                console.error(strMsg);
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////用户名称/////////////////////////////////////////////////////////////
        //获取用户ID
        static get userName() {
            const strKey = "userName";
            let strUserName = "";
            if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
                //缓存存在，直接返回
                strUserName = localStorage.getItem(strKey);
            }
            else {
                console.error("缓存UserName为空！");
            }
            return strUserName;
        }
        //设置用户Id
        static set userName(strUserName) {
            try {
                //清空本类缓存
                const strKey = "userName";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strUserName);
            }
            catch (e) {
                const strMsg = `存入缓存出错,${e}.`;
                console.error(strMsg);
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////专业/////////////////////////////////////////////////////////////
        //获取用户ID
        static get majorDirectionId() {
            var strKey = "majorDirectionId";
            var strMajorDirectionId = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strMajorDirectionId = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存majorDirectionId为空！");
            }
            return strMajorDirectionId;
        }
        //设置用户Id
        static set majorDirectionId(strMajorDirectionId) {
            try {
                //清空本类缓存
                var strKey = "majorDirectionId";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strMajorDirectionId);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////专业/////////////////////////////////////////////////////////////
        //获取用户ID
        static get majorDirectionName() {
            var strKey = "majorDirectionName";
            var strMajorDirectionName = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strMajorDirectionName = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存majorDirectionName为空！");
            }
            return strMajorDirectionName;
        }
        //设置用户Id
        static set majorDirectionName(strMajorDirectionName) {
            try {
                //清空本类缓存
                var strKey = "majorDirectionName";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strMajorDirectionName);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
    }
    exports.clsPublocalStorage = clsPublocalStorage;
    ;
});
