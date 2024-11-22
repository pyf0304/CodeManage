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
    //import { clsCurrEduClsEN } from "../../L0_Entity/DailyRunning/clsCurrEduClsEN";
    //import * as QQ from "q";
    var ResponseData;
    var clsPublocalStorage = /** @class */ (function () {
        function clsPublocalStorage() {
        }
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
        //public static async SetCurrEduClsObjLstObjLst(strid_CurrEduClass: string) {
        //    //清空本类缓存
        //    const responseText0 = await clsCurrEduClsWApi.ReFreshThisCache();
        //    //初始化列表缓存
        //    var strWhereCond: string = "1=1 and id_CurrEduClass='" + strid_CurrEduClass+"'";
        //    clsCurrEduClsWApi.InitListCache();
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
        //        console.log(e);
        //        var strMsg: string = `从缓存中获取所有对象列表出错,${e}.`;
        //        throw (strMsg);
        //    }
        //}
        //////////////////////////////////////////////////////////教学班Id/////////////////////////////////////////////////////////////
        //获取教学班Id
        clsPublocalStorage.Getid_CurrEduClass = function () {
            var strKey = "id_CurrEduClass";
            var strid_CurrEduClass = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strid_CurrEduClass = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存id_CurrEduClass为空！");
            }
            return strid_CurrEduClass;
        };
        //设置教学班Id
        clsPublocalStorage.Setid_CurrEduClass = function (strid_CurrEduClass) {
            try {
                //清空本类缓存
                var strKey = "id_CurrEduClass";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strid_CurrEduClass);
            }
            catch (e) {
                console.log(e);
                var strMsg = "\u5B58\u5165\u7F13\u5B58\u51FA\u9519," + e + ".";
                throw (strMsg);
            }
        };
        Object.defineProperty(clsPublocalStorage, "EduClassTypeID", {
            //////////////////////////////////////////////////////////教学班类型Id/////////////////////////////////////////////////////////////
            //获取教学班Id
            get: function () {
                var strKey = "EduClassTypeID";
                var strEduClassTypeID = "";
                if (localStorage.hasOwnProperty(strKey)) {
                    //缓存存在，直接返回
                    strEduClassTypeID = localStorage.getItem(strKey);
                }
                else {
                    console.log("缓存strEduClassTypeID为空！");
                }
                return strEduClassTypeID;
            },
            //设置教学班Id
            set: function (strEduClassTypeID) {
                try {
                    //清空本类缓存
                    var strKey = "EduClassTypeID";
                    localStorage.removeItem(strKey);
                    //把值存入session
                    localStorage.setItem(strKey, strEduClassTypeID);
                }
                catch (e) {
                    console.log(e);
                    var strMsg = "\u5B58\u5165\u7F13\u5B58\u51FA\u9519," + e + ".";
                    throw (strMsg);
                }
            },
            enumerable: true,
            configurable: true
        });
        //////////////////////////////////////////////////////////教学班/////////////////////////////////////////////////////////////
        //获取教学班名称
        clsPublocalStorage.GetEduClassName = function () {
            var strKey = "EduClassName";
            var strid_CurrEduClass = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strid_CurrEduClass = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存EduClassName为空！");
            }
            return strid_CurrEduClass;
        };
        //设置教学班名称
        clsPublocalStorage.SetEduClassName = function (strEduClassName) {
            try {
                //清空本类缓存
                var strKey = "EduClassName";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strEduClassName);
            }
            catch (e) {
                console.log(e);
                var strMsg = "\u5B58\u5165\u7F13\u5B58\u51FA\u9519," + e + ".";
                throw (strMsg);
            }
        };
        //////////////////////////////////////////////////////////用户Id/////////////////////////////////////////////////////////////
        //获取用户ID
        clsPublocalStorage.GetUserId = function () {
            var strKey = "UserId";
            var strUserId = "";
            if (localStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                strUserId = localStorage.getItem(strKey);
            }
            else {
                console.log("缓存UserId为空！");
            }
            return strUserId;
        };
        //设置用户Id
        clsPublocalStorage.SetUserId = function (strUserId) {
            try {
                //清空本类缓存
                var strKey = "UserId";
                localStorage.removeItem(strKey);
                //把值存入session
                localStorage.setItem(strKey, strUserId);
            }
            catch (e) {
                console.log(e);
                var strMsg = "\u5B58\u5165\u7F13\u5B58\u51FA\u9519," + e + ".";
                throw (strMsg);
            }
        };
        Object.defineProperty(clsPublocalStorage, "TopicUserList", {
            //////////////////////////////////////////////////////////主题用户关系列表/////////////////////////////////////////////////////////////
            //获取主题用户关系
            get: function () {
                var strKey = "TopicUserList";
                var strTopicUserList = "";
                if (localStorage.hasOwnProperty(strKey)) {
                    //缓存存在，直接返回
                    strTopicUserList = localStorage.getItem(strKey);
                }
                else {
                    console.log("缓存strEduClassTypeID为空！");
                }
                return strTopicUserList;
            },
            //设置主题用户关系
            set: function (strTopicUserList) {
                try {
                    //清空本类缓存
                    var strKey = "TopicUserList";
                    localStorage.removeItem(strKey);
                    //把值存入session
                    localStorage.setItem(strKey, strTopicUserList);
                }
                catch (e) {
                    console.log(e);
                    var strMsg = "\u5B58\u5165\u7F13\u5B58\u51FA\u9519," + e + ".";
                    throw (strMsg);
                }
            },
            enumerable: true,
            configurable: true
        });
        return clsPublocalStorage;
    }());
    exports.clsPublocalStorage = clsPublocalStorage;
    ;
});
