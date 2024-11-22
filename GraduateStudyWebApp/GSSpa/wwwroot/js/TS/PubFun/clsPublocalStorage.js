/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCurrEduClsWApi
表名:CurrEduCls(01120123)
生成代码版本:2020.04.24.1
生成日期:2020/04/25 17:22:23
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:日常运行
模块英文名:DailyRunning
框架-层名:WA_访问层(WA_Access)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == ==
*/
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
    //import { clsCurrEduClsEN } from "../../L0_Entity/DailyRunning/clsCurrEduClsEN";
    //import * as QQ from "q";
    var ResponseData;
    class clsPublocalStorage {
        ////获取教学班对象
        //public static async GetCurrEduClsObjLst() {
        //    //初始化列表缓存
        //    var strWhereCond: string = "1=1";
        //    clsCurrEduClsWApi.InitListCache();
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
        //    const responseText0 = await CurrEduCls_ReFreshThisCache();
        //    //初始化列表缓存
        //    var strWhereCond: string = "1=1 and id_CurrEduCls='" + strid_CurrEduCls+"'";
        //    clsCurrEduClsWApi.InitListCache();
        //    var strKey: string = clsCurrEduClsEN._CurrTabName;
        //    if (strKey == "") {
        //        console.log("关键字为空！不正确");
        //        throw new Error("关键字为空！不正确");
        //    }
        //    try {
        //        //把当前教学班存入缓存内
        //        const responseText = await CurrEduCls_GetObjLstAsync(strWhereCond);
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
        static Getid_CurrEduCls() {
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
        static Setid_CurrEduCls(strid_CurrEduCls) {
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
        //////////////////////////////////////////////////////////教学班类型Id/////////////////////////////////////////////////////////////
        //获取教学班Id
        static get eduClsTypeId() {
            var strKey = "eduClsTypeId";
            var streduClsTypeId = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                streduClsTypeId = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存streduClsTypeId为空！");
            }
            return streduClsTypeId;
        }
        //设置教学班Id
        static set eduClsTypeId(streduClsTypeId) {
            try {
                //清空本类缓存
                var strKey = "eduClsTypeId";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, streduClsTypeId);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////教学班/////////////////////////////////////////////////////////////
        //获取教学班名称
        static GeteduClsName() {
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
        static SeteduClsName(streduClsName) {
            try {
                //清空本类缓存
                var strKey = "eduClsName";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, streduClsName);
            }
            catch (e) {
                console.error(e);
                var strMsg = `存入缓存出错,${e}.`;
                throw (strMsg);
            }
        }
        //////////////////////////////////////////////////////////用户Id/////////////////////////////////////////////////////////////
        //获取用户ID
        static GetUserId() {
            var strKey = "userId";
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
        //设置用户Id
        static SetUserId(strUserId) {
            try {
                //清空本类缓存
                var strKey = "userId";
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
                console.log("缓存streduClsTypeId为空！");
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
    }
    exports.clsPublocalStorage = clsPublocalStorage;
    ;
});
