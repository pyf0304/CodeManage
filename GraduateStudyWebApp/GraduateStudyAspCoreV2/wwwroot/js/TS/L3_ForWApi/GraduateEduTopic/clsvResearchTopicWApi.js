/**
* 类名:clsvResearchTopicWApi
* 表名:vResearchTopic(01120612)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:44:57
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培主题(GraduateEduTopic)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvResearchTopicEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vResearchTopic_GetObjFromJsonObj = exports.vResearchTopic_CopyObjTo = exports.vResearchTopic_GetCombineCondition = exports.vResearchTopic_GetObjByJSONStr = exports.vResearchTopic_GetObjLstByJSONObjLst = exports.vResearchTopic_GetObjLstByJSONStr = exports.vResearchTopic_GetJSONStrByObj = exports.vResearchTopic_ReFreshThisCache = exports.vResearchTopic_GetWebApiUrl = exports.vResearchTopic_GetRecCountByCond_Cache = exports.vResearchTopic_GetRecCountByCondAsync = exports.vResearchTopic_IsExistAsync = exports.vResearchTopic_IsExist_Cache = exports.vResearchTopic_IsExist = exports.vResearchTopic_IsExistRecordAsync = exports.vResearchTopic_IsExistRecord_Cache = exports.vResearchTopic_GetObjLstByPagerAsync = exports.vResearchTopic_GetObjLstByPager_Cache = exports.vResearchTopic_GetObjLstByRange = exports.vResearchTopic_GetObjLstByRangeAsync = exports.vResearchTopic_GetTopObjLstAsync = exports.vResearchTopic_GetObjLstByTopicIdLst_Cache = exports.vResearchTopic_GetObjLstByTopicIdLstAsync = exports.vResearchTopic_GetSubObjLst_Cache = exports.vResearchTopic_GetObjLst_PureCache = exports.vResearchTopic_GetObjLst_Cache = exports.vResearchTopic_GetObjLst_sessionStorage_PureCache = exports.vResearchTopic_GetObjLst_sessionStorage = exports.vResearchTopic_GetObjLstAsync = exports.vResearchTopic_GetObjLst_localStorage_PureCache = exports.vResearchTopic_GetObjLst_localStorage = exports.vResearchTopic_GetObjLst_ClientCache = exports.vResearchTopic_GetFirstObjAsync = exports.vResearchTopic_GetFirstID = exports.vResearchTopic_GetFirstIDAsync = exports.vResearchTopic_funcKey = exports.vResearchTopic_FilterFunByKey = exports.vResearchTopic_SortFunByKey = exports.vResearchTopic_SortFun_Defa_2Fld = exports.vResearchTopic_SortFun_Defa = exports.vResearchTopic_func = exports.vResearchTopic_GetObjByTopicId_localStorage = exports.vResearchTopic_GetObjByTopicId_Cache = exports.vResearchTopic_GetObjByTopicIdAsync = exports.vResearchTopic_ConstructorName = exports.vResearchTopic_Controller = void 0;
    /**
     * 研究主题视图(vResearchTopic)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvResearchTopicEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvResearchTopicEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vResearchTopic_Controller = "vResearchTopicApi";
    exports.vResearchTopic_ConstructorName = "vResearchTopic";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strTopicId:关键字
    * @returns 对象
    **/
    async function vResearchTopic_GetObjByTopicIdAsync(strTopicId) {
        const strThisFuncName = "GetObjByTopicIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicId]不能为空！(In clsvResearchTopicWApi.GetObjByTopicIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicId]的长度:[{0}]不正确！(clsvResearchTopicWApi.GetObjByTopicIdAsync)", strTopicId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByTopicId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vResearchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strTopicId": strTopicId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvResearchTopic = vResearchTopic_GetObjFromJsonObj(returnObj);
                return objvResearchTopic;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vResearchTopic_GetObjByTopicIdAsync = vResearchTopic_GetObjByTopicIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strTopicId:所给的关键字
     * @returns 对象
    */
    async function vResearchTopic_GetObjByTopicId_Cache(strTopicId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByTopicId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicId]不能为空！(In clsvResearchTopicWApi.GetObjByTopicId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicId]的长度:[{0}]不正确！(clsvResearchTopicWApi.GetObjByTopicId_Cache)", strTopicId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvResearchTopic_Sel = arrvResearchTopicObjLst_Cache.filter(x => x.topicId == strTopicId);
            let objvResearchTopic;
            if (arrvResearchTopic_Sel.length > 0) {
                objvResearchTopic = arrvResearchTopic_Sel[0];
                return objvResearchTopic;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvResearchTopic_Const = await vResearchTopic_GetObjByTopicIdAsync(strTopicId);
                    if (objvResearchTopic_Const != null) {
                        vResearchTopic_ReFreshThisCache(strid_CurrEduCls);
                        return objvResearchTopic_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicId, exports.vResearchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vResearchTopic_GetObjByTopicId_Cache = vResearchTopic_GetObjByTopicId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strTopicId:所给的关键字
     * @returns 对象
    */
    async function vResearchTopic_GetObjByTopicId_localStorage(strTopicId) {
        const strThisFuncName = "GetObjByTopicId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicId]不能为空！(In clsvResearchTopicWApi.GetObjByTopicId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicId]的长度:[{0}]不正确！(clsvResearchTopicWApi.GetObjByTopicId_localStorage)", strTopicId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvResearchTopicEN_js_1.clsvResearchTopicEN._CurrTabName, strTopicId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvResearchTopic_Cache = JSON.parse(strTempObj);
            return objvResearchTopic_Cache;
        }
        try {
            const objvResearchTopic = await vResearchTopic_GetObjByTopicIdAsync(strTopicId);
            if (objvResearchTopic != null) {
                localStorage.setItem(strKey, JSON.stringify(objvResearchTopic));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvResearchTopic;
            }
            return objvResearchTopic;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicId, exports.vResearchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vResearchTopic_GetObjByTopicId_localStorage = vResearchTopic_GetObjByTopicId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function vResearchTopic_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvResearchTopicWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvResearchTopicWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvResearchTopicEN_js_1.clsvResearchTopicEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvResearchTopicEN_js_1.clsvResearchTopicEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strTopicId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvResearchTopic = await vResearchTopic_GetObjByTopicId_Cache(strTopicId, strid_CurrEduCls_C);
        if (objvResearchTopic == null)
            return "";
        if (objvResearchTopic.GetFldValue(strOutFldName) == null)
            return "";
        return objvResearchTopic.GetFldValue(strOutFldName).toString();
    }
    exports.vResearchTopic_func = vResearchTopic_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vResearchTopic_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.topicId.localeCompare(b.topicId);
    }
    exports.vResearchTopic_SortFun_Defa = vResearchTopic_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vResearchTopic_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicName == b.topicName)
            return a.topicContent.localeCompare(b.topicContent);
        else
            return a.topicName.localeCompare(b.topicName);
    }
    exports.vResearchTopic_SortFun_Defa_2Fld = vResearchTopic_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vResearchTopic_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicName:
                    return (a, b) => {
                        if (a.topicName == null)
                            return -1;
                        if (b.topicName == null)
                            return 1;
                        return a.topicName.localeCompare(b.topicName);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicContent:
                    return (a, b) => {
                        if (a.topicContent == null)
                            return -1;
                        if (b.topicContent == null)
                            return 1;
                        return a.topicContent.localeCompare(b.topicContent);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicProposePeople:
                    return (a, b) => {
                        if (a.topicProposePeople == null)
                            return -1;
                        if (b.topicProposePeople == null)
                            return 1;
                        return a.topicProposePeople.localeCompare(b.topicProposePeople);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UserName:
                    return (a, b) => {
                        if (a.userName == null)
                            return -1;
                        if (b.userName == null)
                            return 1;
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vResearchTopic]中不存在！(in ${exports.vResearchTopic_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicName:
                    return (a, b) => {
                        if (b.topicName == null)
                            return -1;
                        if (a.topicName == null)
                            return 1;
                        return b.topicName.localeCompare(a.topicName);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicContent:
                    return (a, b) => {
                        if (b.topicContent == null)
                            return -1;
                        if (a.topicContent == null)
                            return 1;
                        return b.topicContent.localeCompare(a.topicContent);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicProposePeople:
                    return (a, b) => {
                        if (b.topicProposePeople == null)
                            return -1;
                        if (a.topicProposePeople == null)
                            return 1;
                        return b.topicProposePeople.localeCompare(a.topicProposePeople);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UserName:
                    return (a, b) => {
                        if (b.userName == null)
                            return -1;
                        if (a.userName == null)
                            return 1;
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vResearchTopic]中不存在！(in ${exports.vResearchTopic_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vResearchTopic_SortFunByKey = vResearchTopic_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vResearchTopic_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicName:
                return (obj) => {
                    return obj.topicName === value;
                };
            case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicContent:
                return (obj) => {
                    return obj.topicContent === value;
                };
            case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicProposePeople:
                return (obj) => {
                    return obj.topicProposePeople === value;
                };
            case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vResearchTopic]中不存在！(in ${exports.vResearchTopic_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vResearchTopic_FilterFunByKey = vResearchTopic_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个关键字值列表
    */
    async function vResearchTopic_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvResearchTopicWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvResearchTopicWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvResearchTopic = await vResearchTopic_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrvResearchTopic == null)
            return [];
        let arrvResearchTopic_Sel = arrvResearchTopic;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvResearchTopic_Sel.length == 0)
            return [];
        return arrvResearchTopic_Sel.map(x => x.topicId);
    }
    exports.vResearchTopic_funcKey = vResearchTopic_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vResearchTopic_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vResearchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vResearchTopic_GetFirstIDAsync = vResearchTopic_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vResearchTopic_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vResearchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vResearchTopic_GetFirstID = vResearchTopic_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vResearchTopic_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vResearchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvResearchTopic = vResearchTopic_GetObjFromJsonObj(returnObj);
                return objvResearchTopic;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vResearchTopic_GetFirstObjAsync = vResearchTopic_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vResearchTopic_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvResearchTopicEN_js_1.clsvResearchTopicEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvResearchTopicEN_js_1.clsvResearchTopicEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvResearchTopicEN_js_1.clsvResearchTopicEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvResearchTopicEN_js_1.clsvResearchTopicEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvResearchTopicEN_js_1.clsvResearchTopicEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvResearchTopicExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvResearchTopicObjLst_T = vResearchTopic_GetObjLstByJSONObjLst(arrvResearchTopicExObjLst_Cache);
            return arrvResearchTopicObjLst_T;
        }
        try {
            const arrvResearchTopicExObjLst = await vResearchTopic_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvResearchTopicExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvResearchTopicExObjLst.length);
            console.log(strInfo);
            return arrvResearchTopicExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vResearchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vResearchTopic_GetObjLst_ClientCache = vResearchTopic_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vResearchTopic_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvResearchTopicEN_js_1.clsvResearchTopicEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvResearchTopicEN_js_1.clsvResearchTopicEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvResearchTopicEN_js_1.clsvResearchTopicEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvResearchTopicEN_js_1.clsvResearchTopicEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvResearchTopicEN_js_1.clsvResearchTopicEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvResearchTopicExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvResearchTopicObjLst_T = vResearchTopic_GetObjLstByJSONObjLst(arrvResearchTopicExObjLst_Cache);
            return arrvResearchTopicObjLst_T;
        }
        try {
            const arrvResearchTopicExObjLst = await vResearchTopic_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvResearchTopicExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvResearchTopicExObjLst.length);
            console.log(strInfo);
            return arrvResearchTopicExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vResearchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vResearchTopic_GetObjLst_localStorage = vResearchTopic_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vResearchTopic_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvResearchTopicEN_js_1.clsvResearchTopicEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvResearchTopicObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvResearchTopicObjLst_Cache;
        }
        else
            return null;
    }
    exports.vResearchTopic_GetObjLst_localStorage_PureCache = vResearchTopic_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vResearchTopic_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vResearchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vResearchTopic_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vResearchTopic_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vResearchTopic_GetObjLstAsync = vResearchTopic_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vResearchTopic_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvResearchTopicEN_js_1.clsvResearchTopicEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvResearchTopicEN_js_1.clsvResearchTopicEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvResearchTopicEN_js_1.clsvResearchTopicEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvResearchTopicEN_js_1.clsvResearchTopicEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvResearchTopicEN_js_1.clsvResearchTopicEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvResearchTopicExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvResearchTopicObjLst_T = vResearchTopic_GetObjLstByJSONObjLst(arrvResearchTopicExObjLst_Cache);
            return arrvResearchTopicObjLst_T;
        }
        try {
            const arrvResearchTopicExObjLst = await vResearchTopic_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvResearchTopicExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvResearchTopicExObjLst.length);
            console.log(strInfo);
            return arrvResearchTopicExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vResearchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vResearchTopic_GetObjLst_sessionStorage = vResearchTopic_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vResearchTopic_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvResearchTopicEN_js_1.clsvResearchTopicEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvResearchTopicObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvResearchTopicObjLst_Cache;
        }
        else
            return null;
    }
    exports.vResearchTopic_GetObjLst_sessionStorage_PureCache = vResearchTopic_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vResearchTopic_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvResearchTopicWApi.vResearchTopic_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvResearchTopicWApi.vResearchTopic_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvResearchTopicObjLst_Cache;
        switch (clsvResearchTopicEN_js_1.clsvResearchTopicEN.CacheModeId) {
            case "04": //sessionStorage
                arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvResearchTopicObjLst = vResearchTopic_GetObjLstByJSONObjLst(arrvResearchTopicObjLst_Cache);
        return arrvResearchTopicObjLst_Cache;
    }
    exports.vResearchTopic_GetObjLst_Cache = vResearchTopic_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vResearchTopic_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvResearchTopicObjLst_Cache;
        switch (clsvResearchTopicEN_js_1.clsvResearchTopicEN.CacheModeId) {
            case "04": //sessionStorage
                arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvResearchTopicObjLst_Cache = null;
                break;
            default:
                arrvResearchTopicObjLst_Cache = null;
                break;
        }
        return arrvResearchTopicObjLst_Cache;
    }
    exports.vResearchTopic_GetObjLst_PureCache = vResearchTopic_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrTopicId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vResearchTopic_GetSubObjLst_Cache(objvResearchTopic_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
        let arrvResearchTopic_Sel = arrvResearchTopicObjLst_Cache;
        if (objvResearchTopic_Cond.sf_FldComparisonOp == null || objvResearchTopic_Cond.sf_FldComparisonOp == "")
            return arrvResearchTopic_Sel;
        const dicFldComparisonOp = JSON.parse(objvResearchTopic_Cond.sf_FldComparisonOp);
        //console.log("clsvResearchTopicWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvResearchTopic_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvResearchTopic_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvResearchTopic_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvResearchTopic_Cond), exports.vResearchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vResearchTopic_GetSubObjLst_Cache = vResearchTopic_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrTopicId:关键字列表
    * @returns 对象列表
    **/
    async function vResearchTopic_GetObjLstByTopicIdLstAsync(arrTopicId) {
        const strThisFuncName = "GetObjLstByTopicIdLstAsync";
        const strAction = "GetObjLstByTopicIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vResearchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTopicId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vResearchTopic_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vResearchTopic_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vResearchTopic_GetObjLstByTopicIdLstAsync = vResearchTopic_GetObjLstByTopicIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrTopicIdLst:关键字列表
     * @returns 对象列表
    */
    async function vResearchTopic_GetObjLstByTopicIdLst_Cache(arrTopicIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByTopicIdLst_Cache";
        try {
            const arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
            const arrvResearchTopic_Sel = arrvResearchTopicObjLst_Cache.filter(x => arrTopicIdLst.indexOf(x.topicId) > -1);
            return arrvResearchTopic_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTopicIdLst.join(","), exports.vResearchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vResearchTopic_GetObjLstByTopicIdLst_Cache = vResearchTopic_GetObjLstByTopicIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vResearchTopic_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vResearchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vResearchTopic_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vResearchTopic_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vResearchTopic_GetTopObjLstAsync = vResearchTopic_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vResearchTopic_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vResearchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vResearchTopic_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vResearchTopic_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vResearchTopic_GetObjLstByRangeAsync = vResearchTopic_GetObjLstByRangeAsync;
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
    async function vResearchTopic_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vResearchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vResearchTopic_GetObjLstByRange = vResearchTopic_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vResearchTopic_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvResearchTopicObjLst_Cache.length == 0)
            return arrvResearchTopicObjLst_Cache;
        let arrvResearchTopic_Sel = arrvResearchTopicObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvResearchTopic_Cond = new clsvResearchTopicEN_js_1.clsvResearchTopicEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvResearchTopic_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvResearchTopicWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvResearchTopic_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvResearchTopic_Sel.length == 0)
                return arrvResearchTopic_Sel;
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
                arrvResearchTopic_Sel = arrvResearchTopic_Sel.sort(vResearchTopic_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvResearchTopic_Sel = arrvResearchTopic_Sel.sort(objPagerPara.sortFun);
            }
            arrvResearchTopic_Sel = arrvResearchTopic_Sel.slice(intStart, intEnd);
            return arrvResearchTopic_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vResearchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vResearchTopic_GetObjLstByPager_Cache = vResearchTopic_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vResearchTopic_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vResearchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vResearchTopic_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vResearchTopic_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vResearchTopic_GetObjLstByPagerAsync = vResearchTopic_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrTopicId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vResearchTopic_IsExistRecord_Cache(objvResearchTopic_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvResearchTopicObjLst_Cache == null)
            return false;
        let arrvResearchTopic_Sel = arrvResearchTopicObjLst_Cache;
        if (objvResearchTopic_Cond.sf_FldComparisonOp == null || objvResearchTopic_Cond.sf_FldComparisonOp == "")
            return arrvResearchTopic_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvResearchTopic_Cond.sf_FldComparisonOp);
        //console.log("clsvResearchTopicWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvResearchTopic_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvResearchTopic_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvResearchTopic_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvResearchTopic_Cond), exports.vResearchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vResearchTopic_IsExistRecord_Cache = vResearchTopic_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vResearchTopic_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vResearchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vResearchTopic_IsExistRecordAsync = vResearchTopic_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strTopicId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vResearchTopic_IsExist(strTopicId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vResearchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "TopicId": strTopicId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vResearchTopic_IsExist = vResearchTopic_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strTopicId:所给的关键字
     * @returns 对象
    */
    async function vResearchTopic_IsExist_Cache(strTopicId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvResearchTopicObjLst_Cache == null)
            return false;
        try {
            const arrvResearchTopic_Sel = arrvResearchTopicObjLst_Cache.filter(x => x.topicId == strTopicId);
            if (arrvResearchTopic_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTopicId, exports.vResearchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vResearchTopic_IsExist_Cache = vResearchTopic_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strTopicId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vResearchTopic_IsExistAsync(strTopicId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vResearchTopic_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strTopicId": strTopicId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vResearchTopic_IsExistAsync = vResearchTopic_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vResearchTopic_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vResearchTopic_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vResearchTopic_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vResearchTopic_GetRecCountByCondAsync = vResearchTopic_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvResearchTopic_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vResearchTopic_GetRecCountByCond_Cache(objvResearchTopic_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvResearchTopicObjLst_Cache == null)
            return 0;
        let arrvResearchTopic_Sel = arrvResearchTopicObjLst_Cache;
        if (objvResearchTopic_Cond.sf_FldComparisonOp == null || objvResearchTopic_Cond.sf_FldComparisonOp == "")
            return arrvResearchTopic_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvResearchTopic_Cond.sf_FldComparisonOp);
        //console.log("clsvResearchTopicWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvResearchTopic_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvResearchTopic_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvResearchTopic_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvResearchTopic_Cond), exports.vResearchTopic_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vResearchTopic_GetRecCountByCond_Cache = vResearchTopic_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vResearchTopic_GetWebApiUrl(strController, strAction) {
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
    exports.vResearchTopic_GetWebApiUrl = vResearchTopic_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vResearchTopic_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvResearchTopicEN_js_1.clsvResearchTopicEN._CurrTabName, strid_CurrEduCls);
            switch (clsvResearchTopicEN_js_1.clsvResearchTopicEN.CacheModeId) {
                case "04": //sessionStorage
                    sessionStorage.removeItem(strKey);
                    break;
                case "03": //localStorage
                    localStorage.removeItem(strKey);
                    break;
                case "02": //ClientCache
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
                    break;
                default:
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
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
    exports.vResearchTopic_ReFreshThisCache = vResearchTopic_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vResearchTopic_GetJSONStrByObj(pobjvResearchTopicEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvResearchTopicEN);
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
    exports.vResearchTopic_GetJSONStrByObj = vResearchTopic_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vResearchTopic_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvResearchTopicObjLst = new Array();
        if (strJSON === "") {
            return arrvResearchTopicObjLst;
        }
        try {
            arrvResearchTopicObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvResearchTopicObjLst;
        }
        return arrvResearchTopicObjLst;
    }
    exports.vResearchTopic_GetObjLstByJSONStr = vResearchTopic_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvResearchTopicObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vResearchTopic_GetObjLstByJSONObjLst(arrvResearchTopicObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvResearchTopicObjLst = new Array();
        for (const objInFor of arrvResearchTopicObjLstS) {
            const obj1 = vResearchTopic_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvResearchTopicObjLst.push(obj1);
        }
        return arrvResearchTopicObjLst;
    }
    exports.vResearchTopic_GetObjLstByJSONObjLst = vResearchTopic_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vResearchTopic_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvResearchTopicEN = new clsvResearchTopicEN_js_1.clsvResearchTopicEN();
        if (strJSON === "") {
            return pobjvResearchTopicEN;
        }
        try {
            pobjvResearchTopicEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvResearchTopicEN;
        }
        return pobjvResearchTopicEN;
    }
    exports.vResearchTopic_GetObjByJSONStr = vResearchTopic_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vResearchTopic_GetCombineCondition(objvResearchTopic_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicId, objvResearchTopic_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicName) == true) {
            const strComparisonOp_TopicName = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicName, objvResearchTopic_Cond.topicName, strComparisonOp_TopicName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicProposePeople) == true) {
            const strComparisonOp_TopicProposePeople = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicProposePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicProposePeople, objvResearchTopic_Cond.topicProposePeople, strComparisonOp_TopicProposePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_OrderNum, objvResearchTopic_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UpdDate, objvResearchTopic_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UpdUser, objvResearchTopic_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_Memo, objvResearchTopic_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_IsSubmit) == true) {
            if (objvResearchTopic_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UserName, objvResearchTopic_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_id_CurrEduCls, objvResearchTopic_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_ShareId, objvResearchTopic_Cond.shareId, strComparisonOp_ShareId);
        }
        return strWhereCond;
    }
    exports.vResearchTopic_GetCombineCondition = vResearchTopic_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvResearchTopicENS:源对象
     * @param objvResearchTopicENT:目标对象
    */
    function vResearchTopic_CopyObjTo(objvResearchTopicENS, objvResearchTopicENT) {
        objvResearchTopicENT.topicId = objvResearchTopicENS.topicId; //主题Id
        objvResearchTopicENT.topicName = objvResearchTopicENS.topicName; //栏目主题
        objvResearchTopicENT.topicContent = objvResearchTopicENS.topicContent; //主题内容
        objvResearchTopicENT.topicProposePeople = objvResearchTopicENS.topicProposePeople; //主题提出人
        objvResearchTopicENT.orderNum = objvResearchTopicENS.orderNum; //序号
        objvResearchTopicENT.updDate = objvResearchTopicENS.updDate; //修改日期
        objvResearchTopicENT.updUser = objvResearchTopicENS.updUser; //修改人
        objvResearchTopicENT.memo = objvResearchTopicENS.memo; //备注
        objvResearchTopicENT.isSubmit = objvResearchTopicENS.isSubmit; //是否提交
        objvResearchTopicENT.userName = objvResearchTopicENS.userName; //用户名
        objvResearchTopicENT.id_CurrEduCls = objvResearchTopicENS.id_CurrEduCls; //教学班流水号
        objvResearchTopicENT.shareId = objvResearchTopicENS.shareId; //分享Id
    }
    exports.vResearchTopic_CopyObjTo = vResearchTopic_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvResearchTopicENS:源对象
     * @param objvResearchTopicENT:目标对象
    */
    function vResearchTopic_GetObjFromJsonObj(objvResearchTopicENS) {
        const objvResearchTopicENT = new clsvResearchTopicEN_js_1.clsvResearchTopicEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvResearchTopicENT, objvResearchTopicENS);
        return objvResearchTopicENT;
    }
    exports.vResearchTopic_GetObjFromJsonObj = vResearchTopic_GetObjFromJsonObj;
});
