/**
* 类名:clsvMessagePushWApi
* 表名:vMessagePush(01120282)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:36
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:新闻公告(NewsAnnouncement)
* 框架-层名:WA_访问层(TS)(WA_Access)
* 编程语言:TypeScript
* 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
  *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
**/
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/NewsAnnouncement/clsvMessagePushEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vMessagePush_GetObjFromJsonObj = exports.vMessagePush_CopyObjTo = exports.vMessagePush_GetCombineCondition = exports.vMessagePush_GetObjByJSONStr = exports.vMessagePush_GetObjLstByJSONObjLst = exports.vMessagePush_GetObjLstByJSONStr = exports.vMessagePush_GetJSONStrByObj = exports.vMessagePush_ReFreshThisCache = exports.vMessagePush_GetWebApiUrl = exports.vMessagePush_GetRecCountByCond_Cache = exports.vMessagePush_GetRecCountByCondAsync = exports.vMessagePush_IsExistAsync = exports.vMessagePush_IsExist_Cache = exports.vMessagePush_IsExist = exports.vMessagePush_IsExistRecordAsync = exports.vMessagePush_IsExistRecord_Cache = exports.vMessagePush_GetObjLstByPagerAsync = exports.vMessagePush_GetObjLstByPager_Cache = exports.vMessagePush_GetObjLstByRange = exports.vMessagePush_GetObjLstByRangeAsync = exports.vMessagePush_GetTopObjLstAsync = exports.vMessagePush_GetObjLstByMessagePushIdLst_Cache = exports.vMessagePush_GetObjLstByMessagePushIdLstAsync = exports.vMessagePush_GetSubObjLst_Cache = exports.vMessagePush_GetObjLst_PureCache = exports.vMessagePush_GetObjLst_Cache = exports.vMessagePush_GetObjLst_sessionStorage_PureCache = exports.vMessagePush_GetObjLst_sessionStorage = exports.vMessagePush_GetObjLstAsync = exports.vMessagePush_GetObjLst_localStorage_PureCache = exports.vMessagePush_GetObjLst_localStorage = exports.vMessagePush_GetObjLst_ClientCache = exports.vMessagePush_GetFirstObjAsync = exports.vMessagePush_GetFirstID = exports.vMessagePush_GetFirstIDAsync = exports.vMessagePush_FilterFunByKey = exports.vMessagePush_SortFunByKey = exports.vMessagePush_SortFun_Defa_2Fld = exports.vMessagePush_SortFun_Defa = exports.vMessagePush_func = exports.vMessagePush_GetObjByMessagePushId_localStorage = exports.vMessagePush_GetObjByMessagePushId_Cache = exports.vMessagePush_GetObjByMessagePushIdAsync = exports.vMessagePush_ConstructorName = exports.vMessagePush_Controller = void 0;
    /**
     * 消息推送视图(vMessagePush)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvMessagePushEN_js_1 = require("../../L0_Entity/NewsAnnouncement/clsvMessagePushEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vMessagePush_Controller = "vMessagePushApi";
    exports.vMessagePush_ConstructorName = "vMessagePush";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strMessagePushId:关键字
    * @returns 对象
    **/
    async function vMessagePush_GetObjByMessagePushIdAsync(strMessagePushId) {
        const strThisFuncName = "GetObjByMessagePushIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strMessagePushId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strMessagePushId]不能为空！(In GetObjByMessagePushIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strMessagePushId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strMessagePushId]的长度:[{0}]不正确！", strMessagePushId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByMessagePushId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePush_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strMessagePushId": strMessagePushId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMessagePush_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvMessagePush = vMessagePush_GetObjFromJsonObj(returnObj);
                return objvMessagePush;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePush_GetObjByMessagePushIdAsync = vMessagePush_GetObjByMessagePushIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strMessagePushId:所给的关键字
     * @returns 对象
    */
    async function vMessagePush_GetObjByMessagePushId_Cache(strMessagePushId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByMessagePushId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strMessagePushId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strMessagePushId]不能为空！(In GetObjByMessagePushId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strMessagePushId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strMessagePushId]的长度:[{0}]不正确！", strMessagePushId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvMessagePushObjLst_Cache = await vMessagePush_GetObjLst_Cache();
        try {
            const arrvMessagePush_Sel = arrvMessagePushObjLst_Cache.filter(x => x.messagePushId == strMessagePushId);
            let objvMessagePush;
            if (arrvMessagePush_Sel.length > 0) {
                objvMessagePush = arrvMessagePush_Sel[0];
                return objvMessagePush;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvMessagePush = await vMessagePush_GetObjByMessagePushIdAsync(strMessagePushId);
                    if (objvMessagePush != null) {
                        vMessagePush_ReFreshThisCache();
                        return objvMessagePush;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strMessagePushId, exports.vMessagePush_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vMessagePush_GetObjByMessagePushId_Cache = vMessagePush_GetObjByMessagePushId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strMessagePushId:所给的关键字
     * @returns 对象
    */
    async function vMessagePush_GetObjByMessagePushId_localStorage(strMessagePushId) {
        const strThisFuncName = "GetObjByMessagePushId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strMessagePushId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strMessagePushId]不能为空！(In GetObjByMessagePushId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strMessagePushId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strMessagePushId]的长度:[{0}]不正确！", strMessagePushId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvMessagePushEN_js_1.clsvMessagePushEN._CurrTabName, strMessagePushId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvMessagePush_Cache = JSON.parse(strTempObj);
            return objvMessagePush_Cache;
        }
        try {
            const objvMessagePush = await vMessagePush_GetObjByMessagePushIdAsync(strMessagePushId);
            if (objvMessagePush != null) {
                localStorage.setItem(strKey, JSON.stringify(objvMessagePush));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvMessagePush;
            }
            return objvMessagePush;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strMessagePushId, exports.vMessagePush_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vMessagePush_GetObjByMessagePushId_localStorage = vMessagePush_GetObjByMessagePushId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function vMessagePush_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessagePushId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvMessagePushEN_js_1.clsvMessagePushEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvMessagePushEN_js_1.clsvMessagePushEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strMessagePushId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvMessagePush = await vMessagePush_GetObjByMessagePushId_Cache(strMessagePushId);
        if (objvMessagePush == null)
            return "";
        return objvMessagePush.GetFldValue(strOutFldName).toString();
    }
    exports.vMessagePush_func = vMessagePush_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vMessagePush_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.messagePushId.localeCompare(b.messagePushId);
    }
    exports.vMessagePush_SortFun_Defa = vMessagePush_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vMessagePush_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.messagePushNumber == b.messagePushNumber)
            return a.messageTitle.localeCompare(b.messageTitle);
        else
            return a.messagePushNumber.localeCompare(b.messagePushNumber);
    }
    exports.vMessagePush_SortFun_Defa_2Fld = vMessagePush_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vMessagePush_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessagePushId:
                    return (a, b) => {
                        return a.messagePushId.localeCompare(b.messagePushId);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessagePushNumber:
                    return (a, b) => {
                        return a.messagePushNumber.localeCompare(b.messagePushNumber);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTitle:
                    return (a, b) => {
                        return a.messageTitle.localeCompare(b.messageTitle);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageContent:
                    return (a, b) => {
                        return a.messageContent.localeCompare(b.messageContent);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_ReceivePeople:
                    return (a, b) => {
                        return a.receivePeople.localeCompare(b.receivePeople);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTypeId:
                    return (a, b) => {
                        return a.messageTypeId.localeCompare(b.messageTypeId);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTypeName:
                    return (a, b) => {
                        return a.messageTypeName.localeCompare(b.messageTypeName);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_IsAllpush:
                    return (a, b) => {
                        if (a.isAllpush == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_IsReceive:
                    return (a, b) => {
                        if (a.isReceive == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_ClientVersionTypeId:
                    return (a, b) => {
                        return a.clientVersionTypeId.localeCompare(b.clientVersionTypeId);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vMessagePush]中不存在！(in ${exports.vMessagePush_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessagePushId:
                    return (a, b) => {
                        return b.messagePushId.localeCompare(a.messagePushId);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessagePushNumber:
                    return (a, b) => {
                        return b.messagePushNumber.localeCompare(a.messagePushNumber);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTitle:
                    return (a, b) => {
                        return b.messageTitle.localeCompare(a.messageTitle);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageContent:
                    return (a, b) => {
                        return b.messageContent.localeCompare(a.messageContent);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_ReceivePeople:
                    return (a, b) => {
                        return b.receivePeople.localeCompare(a.receivePeople);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTypeId:
                    return (a, b) => {
                        return b.messageTypeId.localeCompare(a.messageTypeId);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTypeName:
                    return (a, b) => {
                        return b.messageTypeName.localeCompare(a.messageTypeName);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_IsAllpush:
                    return (a, b) => {
                        if (b.isAllpush == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_IsReceive:
                    return (a, b) => {
                        if (b.isReceive == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_ClientVersionTypeId:
                    return (a, b) => {
                        return b.clientVersionTypeId.localeCompare(a.clientVersionTypeId);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvMessagePushEN_js_1.clsvMessagePushEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vMessagePush]中不存在！(in ${exports.vMessagePush_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vMessagePush_SortFunByKey = vMessagePush_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vMessagePush_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessagePushId:
                return (obj) => {
                    return obj.messagePushId === value;
                };
            case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessagePushNumber:
                return (obj) => {
                    return obj.messagePushNumber === value;
                };
            case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTitle:
                return (obj) => {
                    return obj.messageTitle === value;
                };
            case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageContent:
                return (obj) => {
                    return obj.messageContent === value;
                };
            case clsvMessagePushEN_js_1.clsvMessagePushEN.con_ReceivePeople:
                return (obj) => {
                    return obj.receivePeople === value;
                };
            case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTypeId:
                return (obj) => {
                    return obj.messageTypeId === value;
                };
            case clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTypeName:
                return (obj) => {
                    return obj.messageTypeName === value;
                };
            case clsvMessagePushEN_js_1.clsvMessagePushEN.con_IsAllpush:
                return (obj) => {
                    return obj.isAllpush === value;
                };
            case clsvMessagePushEN_js_1.clsvMessagePushEN.con_IsReceive:
                return (obj) => {
                    return obj.isReceive === value;
                };
            case clsvMessagePushEN_js_1.clsvMessagePushEN.con_ClientVersionTypeId:
                return (obj) => {
                    return obj.clientVersionTypeId === value;
                };
            case clsvMessagePushEN_js_1.clsvMessagePushEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvMessagePushEN_js_1.clsvMessagePushEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vMessagePush]中不存在！(in ${exports.vMessagePush_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vMessagePush_FilterFunByKey = vMessagePush_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vMessagePush_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePush_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnStr;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePush_GetFirstIDAsync = vMessagePush_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vMessagePush_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePush_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePush_GetFirstID = vMessagePush_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vMessagePush_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePush_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMessagePush_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvMessagePush = vMessagePush_GetObjFromJsonObj(returnObj);
                return objvMessagePush;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePush_GetFirstObjAsync = vMessagePush_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vMessagePush_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvMessagePushEN_js_1.clsvMessagePushEN._CurrTabName;
        clsvMessagePushEN_js_1.clsvMessagePushEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvMessagePushEN_js_1.clsvMessagePushEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvMessagePushEN_js_1.clsvMessagePushEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvMessagePushEN_js_1.clsvMessagePushEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvMessagePushExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvMessagePushObjLst_T = vMessagePush_GetObjLstByJSONObjLst(arrvMessagePushExObjLst_Cache);
            return arrvMessagePushObjLst_T;
        }
        try {
            const arrvMessagePushExObjLst = await vMessagePush_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvMessagePushExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvMessagePushExObjLst.length);
            console.log(strInfo);
            return arrvMessagePushExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vMessagePush_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vMessagePush_GetObjLst_ClientCache = vMessagePush_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vMessagePush_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvMessagePushEN_js_1.clsvMessagePushEN._CurrTabName;
        clsvMessagePushEN_js_1.clsvMessagePushEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvMessagePushEN_js_1.clsvMessagePushEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvMessagePushEN_js_1.clsvMessagePushEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvMessagePushEN_js_1.clsvMessagePushEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvMessagePushExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvMessagePushObjLst_T = vMessagePush_GetObjLstByJSONObjLst(arrvMessagePushExObjLst_Cache);
            return arrvMessagePushObjLst_T;
        }
        try {
            const arrvMessagePushExObjLst = await vMessagePush_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvMessagePushExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvMessagePushExObjLst.length);
            console.log(strInfo);
            return arrvMessagePushExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vMessagePush_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vMessagePush_GetObjLst_localStorage = vMessagePush_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vMessagePush_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvMessagePushEN_js_1.clsvMessagePushEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvMessagePushObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvMessagePushObjLst_Cache;
        }
        else
            return null;
    }
    exports.vMessagePush_GetObjLst_localStorage_PureCache = vMessagePush_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vMessagePush_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePush_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMessagePush_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vMessagePush_GetObjLstByJSONObjLst(returnObjLst);
                return (arrObjLst);
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePush_GetObjLstAsync = vMessagePush_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vMessagePush_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvMessagePushEN_js_1.clsvMessagePushEN._CurrTabName;
        clsvMessagePushEN_js_1.clsvMessagePushEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvMessagePushEN_js_1.clsvMessagePushEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvMessagePushEN_js_1.clsvMessagePushEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvMessagePushEN_js_1.clsvMessagePushEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvMessagePushExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvMessagePushObjLst_T = vMessagePush_GetObjLstByJSONObjLst(arrvMessagePushExObjLst_Cache);
            return arrvMessagePushObjLst_T;
        }
        try {
            const arrvMessagePushExObjLst = await vMessagePush_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvMessagePushExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvMessagePushExObjLst.length);
            console.log(strInfo);
            return arrvMessagePushExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vMessagePush_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vMessagePush_GetObjLst_sessionStorage = vMessagePush_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vMessagePush_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvMessagePushEN_js_1.clsvMessagePushEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvMessagePushObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvMessagePushObjLst_Cache;
        }
        else
            return null;
    }
    exports.vMessagePush_GetObjLst_sessionStorage_PureCache = vMessagePush_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vMessagePush_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvMessagePushObjLst_Cache;
        switch (clsvMessagePushEN_js_1.clsvMessagePushEN.CacheModeId) {
            case "04": //sessionStorage
                arrvMessagePushObjLst_Cache = await vMessagePush_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvMessagePushObjLst_Cache = await vMessagePush_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvMessagePushObjLst_Cache = await vMessagePush_GetObjLst_ClientCache();
                break;
            default:
                arrvMessagePushObjLst_Cache = await vMessagePush_GetObjLst_ClientCache();
                break;
        }
        const arrvMessagePushObjLst = vMessagePush_GetObjLstByJSONObjLst(arrvMessagePushObjLst_Cache);
        return arrvMessagePushObjLst_Cache;
    }
    exports.vMessagePush_GetObjLst_Cache = vMessagePush_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vMessagePush_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvMessagePushObjLst_Cache;
        switch (clsvMessagePushEN_js_1.clsvMessagePushEN.CacheModeId) {
            case "04": //sessionStorage
                arrvMessagePushObjLst_Cache = await vMessagePush_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvMessagePushObjLst_Cache = await vMessagePush_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvMessagePushObjLst_Cache = null;
                break;
            default:
                arrvMessagePushObjLst_Cache = null;
                break;
        }
        return arrvMessagePushObjLst_Cache;
    }
    exports.vMessagePush_GetObjLst_PureCache = vMessagePush_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrMessagePushId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vMessagePush_GetSubObjLst_Cache(objvMessagePush_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvMessagePushObjLst_Cache = await vMessagePush_GetObjLst_Cache();
        let arrvMessagePush_Sel = arrvMessagePushObjLst_Cache;
        if (objvMessagePush_Cond.sf_FldComparisonOp == null || objvMessagePush_Cond.sf_FldComparisonOp == "")
            return arrvMessagePush_Sel;
        const dicFldComparisonOp = JSON.parse(objvMessagePush_Cond.sf_FldComparisonOp);
        //console.log("clsvMessagePushWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvMessagePush_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvMessagePush_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvMessagePush_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvMessagePush_Cond), exports.vMessagePush_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vMessagePush_GetSubObjLst_Cache = vMessagePush_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrMessagePushId:关键字列表
    * @returns 对象列表
    **/
    async function vMessagePush_GetObjLstByMessagePushIdLstAsync(arrMessagePushId) {
        const strThisFuncName = "GetObjLstByMessagePushIdLstAsync";
        const strAction = "GetObjLstByMessagePushIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePush_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrMessagePushId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMessagePush_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vMessagePush_GetObjLstByJSONObjLst(returnObjLst);
                return arrObjLst;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePush_GetObjLstByMessagePushIdLstAsync = vMessagePush_GetObjLstByMessagePushIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrMessagePushIdLst:关键字列表
     * @returns 对象列表
    */
    async function vMessagePush_GetObjLstByMessagePushIdLst_Cache(arrMessagePushIdLst) {
        const strThisFuncName = "GetObjLstByMessagePushIdLst_Cache";
        try {
            const arrvMessagePushObjLst_Cache = await vMessagePush_GetObjLst_Cache();
            const arrvMessagePush_Sel = arrvMessagePushObjLst_Cache.filter(x => arrMessagePushIdLst.indexOf(x.messagePushId) > -1);
            return arrvMessagePush_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrMessagePushIdLst.join(","), exports.vMessagePush_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vMessagePush_GetObjLstByMessagePushIdLst_Cache = vMessagePush_GetObjLstByMessagePushIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vMessagePush_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePush_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMessagePush_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vMessagePush_GetObjLstByJSONObjLst(returnObjLst);
                return (arrObjLst);
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePush_GetTopObjLstAsync = vMessagePush_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vMessagePush_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePush_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMessagePush_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vMessagePush_GetObjLstByJSONObjLst(returnObjLst);
                return arrObjLst;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePush_GetObjLstByRangeAsync = vMessagePush_GetObjLstByRangeAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRange)
     * @param intMinNum:最小记录号
     * @param intMaxNum:最大记录号
     * @param strWhereCond:给定条件
     * @param strOrderBy:排序方式
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取的相应记录对象列表
    */
    async function vMessagePush_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePush_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "intMinNum": intMinNum,
                    "intMaxNum": intMaxNum,
                    "strWhereCond": strWhereCond,
                    "strOrderBy": strOrderBy,
                }
            });
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePush_GetObjLstByRange = vMessagePush_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vMessagePush_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvMessagePushObjLst_Cache = await vMessagePush_GetObjLst_Cache();
        if (arrvMessagePushObjLst_Cache.length == 0)
            return arrvMessagePushObjLst_Cache;
        let arrvMessagePush_Sel = arrvMessagePushObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvMessagePush_Cond = new clsvMessagePushEN_js_1.clsvMessagePushEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvMessagePush_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvMessagePushWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvMessagePush_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvMessagePush_Sel.length == 0)
                return arrvMessagePush_Sel;
            let intStart = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
            if (intStart <= 0)
                intStart = 0;
            const intEnd = intStart + objPagerPara.pageSize;
            if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
                const sstrSplit = objPagerPara.orderBy.split(" ");
                let strSortType = "asc";
                const strSortFld = sstrSplit[0];
                if (sstrSplit.length > 1)
                    strSortType = sstrSplit[1];
                arrvMessagePush_Sel = arrvMessagePush_Sel.sort(vMessagePush_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvMessagePush_Sel = arrvMessagePush_Sel.sort(objPagerPara.sortFun);
            }
            arrvMessagePush_Sel = arrvMessagePush_Sel.slice(intStart, intEnd);
            return arrvMessagePush_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vMessagePush_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vMessagePush_GetObjLstByPager_Cache = vMessagePush_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vMessagePush_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePush_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vMessagePush_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vMessagePush_GetObjLstByJSONObjLst(returnObjLst);
                return arrObjLst;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePush_GetObjLstByPagerAsync = vMessagePush_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrMessagePushId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vMessagePush_IsExistRecord_Cache(objvMessagePush_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvMessagePushObjLst_Cache = await vMessagePush_GetObjLst_Cache();
        if (arrvMessagePushObjLst_Cache == null)
            return false;
        let arrvMessagePush_Sel = arrvMessagePushObjLst_Cache;
        if (objvMessagePush_Cond.sf_FldComparisonOp == null || objvMessagePush_Cond.sf_FldComparisonOp == "")
            return arrvMessagePush_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvMessagePush_Cond.sf_FldComparisonOp);
        //console.log("clsvMessagePushWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvMessagePush_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvMessagePush_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvMessagePush_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvMessagePush_Cond), exports.vMessagePush_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vMessagePush_IsExistRecord_Cache = vMessagePush_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vMessagePush_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePush_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnBool;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePush_IsExistRecordAsync = vMessagePush_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strMessagePushId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vMessagePush_IsExist(strMessagePushId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePush_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "messagePushId": strMessagePushId,
                }
            });
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePush_IsExist = vMessagePush_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strMessagePushId:所给的关键字
     * @returns 对象
    */
    async function vMessagePush_IsExist_Cache(strMessagePushId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvMessagePushObjLst_Cache = await vMessagePush_GetObjLst_Cache();
        if (arrvMessagePushObjLst_Cache == null)
            return false;
        try {
            const arrvMessagePush_Sel = arrvMessagePushObjLst_Cache.filter(x => x.messagePushId == strMessagePushId);
            if (arrvMessagePush_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strMessagePushId, exports.vMessagePush_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vMessagePush_IsExist_Cache = vMessagePush_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strMessagePushId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vMessagePush_IsExistAsync(strMessagePushId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePush_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strMessagePushId": strMessagePushId }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return (data.returnBool);
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePush_IsExistAsync = vMessagePush_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vMessagePush_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vMessagePush_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnInt;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vMessagePush_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vMessagePush_GetRecCountByCondAsync = vMessagePush_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvMessagePush_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vMessagePush_GetRecCountByCond_Cache(objvMessagePush_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvMessagePushObjLst_Cache = await vMessagePush_GetObjLst_Cache();
        if (arrvMessagePushObjLst_Cache == null)
            return 0;
        let arrvMessagePush_Sel = arrvMessagePushObjLst_Cache;
        if (objvMessagePush_Cond.sf_FldComparisonOp == null || objvMessagePush_Cond.sf_FldComparisonOp == "")
            return arrvMessagePush_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvMessagePush_Cond.sf_FldComparisonOp);
        //console.log("clsvMessagePushWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvMessagePush_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvMessagePush_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvMessagePush_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvMessagePush_Cond), exports.vMessagePush_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vMessagePush_GetRecCountByCond_Cache = vMessagePush_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vMessagePush_GetWebApiUrl(strController, strAction) {
        const strThisFuncName = "GetWebApiUrl";
        let strServiceUrl;
        let strCurrIPAddressAndPort = "";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort;
        }
        else {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local;
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx) == true) {
            strServiceUrl = (0, clsString_js_1.Format)("{0}/{1}/{2}", strCurrIPAddressAndPort, strController, strAction);
        }
        else {
            strServiceUrl = (0, clsString_js_1.Format)("{0}/{1}/{2}/{3}", strCurrIPAddressAndPort, clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx, strController, strAction);
        }
        return strServiceUrl;
    }
    exports.vMessagePush_GetWebApiUrl = vMessagePush_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vMessagePush_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvMessagePushEN_js_1.clsvMessagePushEN._CurrTabName;
            switch (clsvMessagePushEN_js_1.clsvMessagePushEN.CacheModeId) {
                case "04": //sessionStorage
                    sessionStorage.removeItem(strKey);
                    break;
                case "03": //localStorage
                    localStorage.removeItem(strKey);
                    break;
                case "02": //ClientCache
                    CacheHelper_js_2.CacheHelper.Remove(strKey);
                    break;
                default:
                    CacheHelper_js_2.CacheHelper.Remove(strKey);
                    break;
            }
            const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
            console.trace(strMsg);
        }
        else {
            const strMsg = (0, clsString_js_1.Format)("刷新缓存已经关闭。");
            console.trace(strMsg);
        }
    }
    exports.vMessagePush_ReFreshThisCache = vMessagePush_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vMessagePush_GetJSONStrByObj(pobjvMessagePushEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvMessagePushEN);
        }
        catch (objException) {
            const strEx = (0, clsCommFunc4Web_js_1.GetExceptionStr)(objException);
            (0, clsCommFunc4Web_js_1.myShowErrorMsg)(strEx);
        }
        if (strJson == undefined)
            return "";
        else
            return strJson;
    }
    exports.vMessagePush_GetJSONStrByObj = vMessagePush_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vMessagePush_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvMessagePushObjLst = new Array();
        if (strJSON === "") {
            return arrvMessagePushObjLst;
        }
        try {
            arrvMessagePushObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvMessagePushObjLst;
        }
        return arrvMessagePushObjLst;
    }
    exports.vMessagePush_GetObjLstByJSONStr = vMessagePush_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvMessagePushObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vMessagePush_GetObjLstByJSONObjLst(arrvMessagePushObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvMessagePushObjLst = new Array();
        for (const objInFor of arrvMessagePushObjLstS) {
            const obj1 = vMessagePush_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvMessagePushObjLst.push(obj1);
        }
        return arrvMessagePushObjLst;
    }
    exports.vMessagePush_GetObjLstByJSONObjLst = vMessagePush_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vMessagePush_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvMessagePushEN = new clsvMessagePushEN_js_1.clsvMessagePushEN();
        if (strJSON === "") {
            return pobjvMessagePushEN;
        }
        try {
            pobjvMessagePushEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvMessagePushEN;
        }
        return pobjvMessagePushEN;
    }
    exports.vMessagePush_GetObjByJSONStr = vMessagePush_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vMessagePush_GetCombineCondition(objvMessagePush_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvMessagePush_Cond.dicFldComparisonOp, clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessagePushId) == true) {
            const strComparisonOp_MessagePushId = objvMessagePush_Cond.dicFldComparisonOp[clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessagePushId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessagePushId, objvMessagePush_Cond.messagePushId, strComparisonOp_MessagePushId);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePush_Cond.dicFldComparisonOp, clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessagePushNumber) == true) {
            const strComparisonOp_MessagePushNumber = objvMessagePush_Cond.dicFldComparisonOp[clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessagePushNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessagePushNumber, objvMessagePush_Cond.messagePushNumber, strComparisonOp_MessagePushNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePush_Cond.dicFldComparisonOp, clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTitle) == true) {
            const strComparisonOp_MessageTitle = objvMessagePush_Cond.dicFldComparisonOp[clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTitle, objvMessagePush_Cond.messageTitle, strComparisonOp_MessageTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePush_Cond.dicFldComparisonOp, clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageContent) == true) {
            const strComparisonOp_MessageContent = objvMessagePush_Cond.dicFldComparisonOp[clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageContent, objvMessagePush_Cond.messageContent, strComparisonOp_MessageContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePush_Cond.dicFldComparisonOp, clsvMessagePushEN_js_1.clsvMessagePushEN.con_ReceivePeople) == true) {
            const strComparisonOp_ReceivePeople = objvMessagePush_Cond.dicFldComparisonOp[clsvMessagePushEN_js_1.clsvMessagePushEN.con_ReceivePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushEN_js_1.clsvMessagePushEN.con_ReceivePeople, objvMessagePush_Cond.receivePeople, strComparisonOp_ReceivePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePush_Cond.dicFldComparisonOp, clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTypeId) == true) {
            const strComparisonOp_MessageTypeId = objvMessagePush_Cond.dicFldComparisonOp[clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTypeId, objvMessagePush_Cond.messageTypeId, strComparisonOp_MessageTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePush_Cond.dicFldComparisonOp, clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTypeName) == true) {
            const strComparisonOp_MessageTypeName = objvMessagePush_Cond.dicFldComparisonOp[clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTypeName, objvMessagePush_Cond.messageTypeName, strComparisonOp_MessageTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePush_Cond.dicFldComparisonOp, clsvMessagePushEN_js_1.clsvMessagePushEN.con_IsAllpush) == true) {
            if (objvMessagePush_Cond.isAllpush == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvMessagePushEN_js_1.clsvMessagePushEN.con_IsAllpush);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvMessagePushEN_js_1.clsvMessagePushEN.con_IsAllpush);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePush_Cond.dicFldComparisonOp, clsvMessagePushEN_js_1.clsvMessagePushEN.con_IsReceive) == true) {
            if (objvMessagePush_Cond.isReceive == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvMessagePushEN_js_1.clsvMessagePushEN.con_IsReceive);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvMessagePushEN_js_1.clsvMessagePushEN.con_IsReceive);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePush_Cond.dicFldComparisonOp, clsvMessagePushEN_js_1.clsvMessagePushEN.con_ClientVersionTypeId) == true) {
            const strComparisonOp_ClientVersionTypeId = objvMessagePush_Cond.dicFldComparisonOp[clsvMessagePushEN_js_1.clsvMessagePushEN.con_ClientVersionTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushEN_js_1.clsvMessagePushEN.con_ClientVersionTypeId, objvMessagePush_Cond.clientVersionTypeId, strComparisonOp_ClientVersionTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePush_Cond.dicFldComparisonOp, clsvMessagePushEN_js_1.clsvMessagePushEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvMessagePush_Cond.dicFldComparisonOp[clsvMessagePushEN_js_1.clsvMessagePushEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushEN_js_1.clsvMessagePushEN.con_UpdDate, objvMessagePush_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvMessagePush_Cond.dicFldComparisonOp, clsvMessagePushEN_js_1.clsvMessagePushEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvMessagePush_Cond.dicFldComparisonOp[clsvMessagePushEN_js_1.clsvMessagePushEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvMessagePushEN_js_1.clsvMessagePushEN.con_Memo, objvMessagePush_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.vMessagePush_GetCombineCondition = vMessagePush_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvMessagePushENS:源对象
     * @param objvMessagePushENT:目标对象
    */
    function vMessagePush_CopyObjTo(objvMessagePushENS, objvMessagePushENT) {
        objvMessagePushENT.messagePushId = objvMessagePushENS.messagePushId; //消息Id
        objvMessagePushENT.messagePushNumber = objvMessagePushENS.messagePushNumber; //消息编号
        objvMessagePushENT.messageTitle = objvMessagePushENS.messageTitle; //消息标题
        objvMessagePushENT.messageContent = objvMessagePushENS.messageContent; //消息内容
        objvMessagePushENT.receivePeople = objvMessagePushENS.receivePeople; //接收人员
        objvMessagePushENT.messageTypeId = objvMessagePushENS.messageTypeId; //消息类型Id
        objvMessagePushENT.messageTypeName = objvMessagePushENS.messageTypeName; //消息类型名称
        objvMessagePushENT.isAllpush = objvMessagePushENS.isAllpush; //是否全体推送
        objvMessagePushENT.isReceive = objvMessagePushENS.isReceive; //是否接收
        objvMessagePushENT.clientVersionTypeId = objvMessagePushENS.clientVersionTypeId; //客户端版本类型Id
        objvMessagePushENT.updDate = objvMessagePushENS.updDate; //修改日期
        objvMessagePushENT.memo = objvMessagePushENS.memo; //备注
    }
    exports.vMessagePush_CopyObjTo = vMessagePush_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvMessagePushENS:源对象
     * @param objvMessagePushENT:目标对象
    */
    function vMessagePush_GetObjFromJsonObj(objvMessagePushENS) {
        const objvMessagePushENT = new clsvMessagePushEN_js_1.clsvMessagePushEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvMessagePushENT, objvMessagePushENS);
        return objvMessagePushENT;
    }
    exports.vMessagePush_GetObjFromJsonObj = vMessagePush_GetObjFromJsonObj;
});
