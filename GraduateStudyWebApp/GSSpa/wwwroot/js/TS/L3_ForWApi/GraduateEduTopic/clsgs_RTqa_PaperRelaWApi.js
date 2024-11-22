/**
* 类名:clsgs_RTqa_PaperRelaWApi
* 表名:gs_RTqa_PaperRela(01120696)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:47:03
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsgs_RTqa_PaperRelaEN.js", "../../L3_ForWApi/GraduateEduTopic/clsvgs_RTqa_PaperRelaWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_RTqa_PaperRela_GetObjFromJsonObj = exports.gs_RTqa_PaperRela_CopyObjTo = exports.gs_RTqa_PaperRela_GetUniCondStr4Update_mId = exports.gs_RTqa_PaperRela_GetUniCondStr_mId = exports.gs_RTqa_PaperRela_GetCombineCondition = exports.gs_RTqa_PaperRela_GetObjByJSONStr = exports.gs_RTqa_PaperRela_GetObjLstByJSONObjLst = exports.gs_RTqa_PaperRela_GetObjLstByJSONStr = exports.gs_RTqa_PaperRela_GetJSONStrByObj = exports.gs_RTqa_PaperRela_CheckProperty4Update = exports.gs_RTqa_PaperRela_CheckPropertyNew = exports.gs_RTqa_PaperRela_ReFreshThisCache = exports.gs_RTqa_PaperRela_ReFreshCache = exports.gs_RTqa_PaperRela_GetWebApiUrl = exports.gs_RTqa_PaperRela_GetMaxStrIdByPrefix = exports.gs_RTqa_PaperRela_GetRecCountByCond_Cache = exports.gs_RTqa_PaperRela_GetRecCountByCondAsync = exports.gs_RTqa_PaperRela_IsExistAsync = exports.gs_RTqa_PaperRela_IsExist_Cache = exports.gs_RTqa_PaperRela_IsExist = exports.gs_RTqa_PaperRela_IsExistRecordAsync = exports.gs_RTqa_PaperRela_IsExistRecord_Cache = exports.gs_RTqa_PaperRela_UpdateWithConditionAsync = exports.gs_RTqa_PaperRela_UpdateRecordAsync = exports.gs_RTqa_PaperRela_AddNewRecordWithReturnKey = exports.gs_RTqa_PaperRela_AddNewRecordWithReturnKeyAsync = exports.gs_RTqa_PaperRela_AddNewRecordAsync = exports.gs_RTqa_PaperRela_Delgs_RTqa_PaperRelasByCondAsync = exports.gs_RTqa_PaperRela_Delgs_RTqa_PaperRelasAsync = exports.gs_RTqa_PaperRela_DelRecordAsync = exports.gs_RTqa_PaperRela_GetObjLstByPagerAsync = exports.gs_RTqa_PaperRela_GetObjLstByPager_Cache = exports.gs_RTqa_PaperRela_GetObjLstByRange = exports.gs_RTqa_PaperRela_GetObjLstByRangeAsync = exports.gs_RTqa_PaperRela_GetTopObjLstAsync = exports.gs_RTqa_PaperRela_GetObjLstBymIdLst_Cache = exports.gs_RTqa_PaperRela_GetObjLstBymIdLstAsync = exports.gs_RTqa_PaperRela_GetSubObjLst_Cache = exports.gs_RTqa_PaperRela_GetObjLst_PureCache = exports.gs_RTqa_PaperRela_GetObjLst_Cache = exports.gs_RTqa_PaperRela_GetObjLst_sessionStorage_PureCache = exports.gs_RTqa_PaperRela_GetObjLst_sessionStorage = exports.gs_RTqa_PaperRela_GetObjLstAsync = exports.gs_RTqa_PaperRela_GetObjLst_localStorage_PureCache = exports.gs_RTqa_PaperRela_GetObjLst_localStorage = exports.gs_RTqa_PaperRela_GetObjLst_ClientCache = exports.gs_RTqa_PaperRela_GetFirstObjAsync = exports.gs_RTqa_PaperRela_GetFirstID = exports.gs_RTqa_PaperRela_GetFirstIDAsync = exports.gs_RTqa_PaperRela_FilterFunByKey = exports.gs_RTqa_PaperRela_SortFunByKey = exports.gs_RTqa_PaperRela_SortFun_Defa_2Fld = exports.gs_RTqa_PaperRela_SortFun_Defa = exports.gs_RTqa_PaperRela_func = exports.gs_RTqa_PaperRela_UpdateObjInLst_Cache = exports.gs_RTqa_PaperRela_GetObjBymId_localStorage = exports.gs_RTqa_PaperRela_GetObjBymId_Cache = exports.gs_RTqa_PaperRela_GetObjBymIdAsync = exports.gs_RTqa_PaperRela_ConstructorName = exports.gs_RTqa_PaperRela_Controller = void 0;
    /**
     * 答疑关系表(gs_RTqa_PaperRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_RTqa_PaperRelaEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_RTqa_PaperRelaEN.js");
    const clsvgs_RTqa_PaperRelaWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsvgs_RTqa_PaperRelaWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_RTqa_PaperRela_Controller = "gs_RTqa_PaperRelaApi";
    exports.gs_RTqa_PaperRela_ConstructorName = "gs_RTqa_PaperRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function gs_RTqa_PaperRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngmId": lngmId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_RTqa_PaperRela = gs_RTqa_PaperRela_GetObjFromJsonObj(returnObj);
                return objgs_RTqa_PaperRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_GetObjBymIdAsync = gs_RTqa_PaperRela_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_RTqa_PaperRela_GetObjBymId_Cache(lngmId, strTopicId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
        try {
            const arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRelaObjLst_Cache.filter(x => x.mId == lngmId);
            let objgs_RTqa_PaperRela;
            if (arrgs_RTqa_PaperRela_Sel.length > 0) {
                objgs_RTqa_PaperRela = arrgs_RTqa_PaperRela_Sel[0];
                return objgs_RTqa_PaperRela;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objgs_RTqa_PaperRela = await gs_RTqa_PaperRela_GetObjBymIdAsync(lngmId);
                    if (objgs_RTqa_PaperRela != null) {
                        gs_RTqa_PaperRela_ReFreshThisCache(strTopicId);
                        return objgs_RTqa_PaperRela;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_RTqa_PaperRela_GetObjBymId_Cache = gs_RTqa_PaperRela_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_RTqa_PaperRela_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_RTqa_PaperRela_Cache = JSON.parse(strTempObj);
            return objgs_RTqa_PaperRela_Cache;
        }
        try {
            const objgs_RTqa_PaperRela = await gs_RTqa_PaperRela_GetObjBymIdAsync(lngmId);
            if (objgs_RTqa_PaperRela != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_RTqa_PaperRela));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_RTqa_PaperRela;
            }
            return objgs_RTqa_PaperRela;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_RTqa_PaperRela_GetObjBymId_localStorage = gs_RTqa_PaperRela_GetObjBymId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_RTqa_PaperRela:所给的对象
     * @returns 对象
    */
    async function gs_RTqa_PaperRela_UpdateObjInLst_Cache(objgs_RTqa_PaperRela, strTopicId) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
            const obj = arrgs_RTqa_PaperRelaObjLst_Cache.find(x => x.mId == objgs_RTqa_PaperRela.mId);
            if (obj != null) {
                objgs_RTqa_PaperRela.mId = obj.mId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_RTqa_PaperRela);
            }
            else {
                arrgs_RTqa_PaperRelaObjLst_Cache.push(objgs_RTqa_PaperRela);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_RTqa_PaperRela_UpdateObjInLst_Cache = gs_RTqa_PaperRela_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strTopicId:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function gs_RTqa_PaperRela_func(strInFldName, strOutFldName, strInValue, strTopicId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicId_C]不能为空！(In func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicId_C]的长度:[{0}]不正确！", strTopicId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objgs_RTqa_PaperRela = await gs_RTqa_PaperRela_GetObjBymId_Cache(lngmId, strTopicId_C);
        if (objgs_RTqa_PaperRela == null)
            return "";
        return objgs_RTqa_PaperRela.GetFldValue(strOutFldName).toString();
    }
    exports.gs_RTqa_PaperRela_func = gs_RTqa_PaperRela_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_RTqa_PaperRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.gs_RTqa_PaperRela_SortFun_Defa = gs_RTqa_PaperRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_RTqa_PaperRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.qa_PaperId.localeCompare(b.qa_PaperId);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.gs_RTqa_PaperRela_SortFun_Defa_2Fld = gs_RTqa_PaperRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_RTqa_PaperRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_qa_PaperId:
                    return (a, b) => {
                        return a.qa_PaperId.localeCompare(b.qa_PaperId);
                    };
                case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_RTqa_PaperRela]中不存在！(in ${exports.gs_RTqa_PaperRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_qa_PaperId:
                    return (a, b) => {
                        return b.qa_PaperId.localeCompare(a.qa_PaperId);
                    };
                case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_RTqa_PaperRela]中不存在！(in ${exports.gs_RTqa_PaperRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_RTqa_PaperRela_SortFunByKey = gs_RTqa_PaperRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_RTqa_PaperRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_qa_PaperId:
                return (obj) => {
                    return obj.qa_PaperId === value;
                };
            case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_RTqa_PaperRela]中不存在！(in ${exports.gs_RTqa_PaperRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_RTqa_PaperRela_FilterFunByKey = gs_RTqa_PaperRela_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_RTqa_PaperRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_GetFirstIDAsync = gs_RTqa_PaperRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_RTqa_PaperRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_GetFirstID = gs_RTqa_PaperRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_RTqa_PaperRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_RTqa_PaperRela = gs_RTqa_PaperRela_GetObjFromJsonObj(returnObj);
                return objgs_RTqa_PaperRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_GetFirstObjAsync = gs_RTqa_PaperRela_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_RTqa_PaperRela_GetObjLst_ClientCache(strTopicId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
        clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_RTqa_PaperRelaExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrgs_RTqa_PaperRelaObjLst_T = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrgs_RTqa_PaperRelaExObjLst_Cache);
            return arrgs_RTqa_PaperRelaObjLst_T;
        }
        try {
            const arrgs_RTqa_PaperRelaExObjLst = await gs_RTqa_PaperRela_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrgs_RTqa_PaperRelaExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_RTqa_PaperRelaExObjLst.length);
            console.log(strInfo);
            return arrgs_RTqa_PaperRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_RTqa_PaperRela_GetObjLst_ClientCache = gs_RTqa_PaperRela_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_RTqa_PaperRela_GetObjLst_localStorage(strTopicId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
        clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_RTqa_PaperRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_RTqa_PaperRelaObjLst_T = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrgs_RTqa_PaperRelaExObjLst_Cache);
            return arrgs_RTqa_PaperRelaObjLst_T;
        }
        try {
            const arrgs_RTqa_PaperRelaExObjLst = await gs_RTqa_PaperRela_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_RTqa_PaperRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_RTqa_PaperRelaExObjLst.length);
            console.log(strInfo);
            return arrgs_RTqa_PaperRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_RTqa_PaperRela_GetObjLst_localStorage = gs_RTqa_PaperRela_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_RTqa_PaperRela_GetObjLst_localStorage_PureCache(strTopicId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_RTqa_PaperRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_RTqa_PaperRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_RTqa_PaperRela_GetObjLst_localStorage_PureCache = gs_RTqa_PaperRela_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_RTqa_PaperRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_GetObjLstAsync = gs_RTqa_PaperRela_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_RTqa_PaperRela_GetObjLst_sessionStorage(strTopicId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
        clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_RTqa_PaperRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_RTqa_PaperRelaObjLst_T = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrgs_RTqa_PaperRelaExObjLst_Cache);
            return arrgs_RTqa_PaperRelaObjLst_T;
        }
        try {
            const arrgs_RTqa_PaperRelaExObjLst = await gs_RTqa_PaperRela_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_RTqa_PaperRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_RTqa_PaperRelaExObjLst.length);
            console.log(strInfo);
            return arrgs_RTqa_PaperRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_RTqa_PaperRela_GetObjLst_sessionStorage = gs_RTqa_PaperRela_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_RTqa_PaperRela_GetObjLst_sessionStorage_PureCache(strTopicId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_RTqa_PaperRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_RTqa_PaperRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_RTqa_PaperRela_GetObjLst_sessionStorage_PureCache = gs_RTqa_PaperRela_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicId) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[TopicId]不能为空！");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicId]的长度:[{0}]不正确！", strTopicId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrgs_RTqa_PaperRelaObjLst_Cache;
        switch (clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_sessionStorage(strTopicId);
                break;
            case "03": //localStorage
                arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_localStorage(strTopicId);
                break;
            case "02": //ClientCache
                arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_ClientCache(strTopicId);
                break;
            default:
                arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_ClientCache(strTopicId);
                break;
        }
        const arrgs_RTqa_PaperRelaObjLst = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrgs_RTqa_PaperRelaObjLst_Cache);
        return arrgs_RTqa_PaperRelaObjLst_Cache;
    }
    exports.gs_RTqa_PaperRela_GetObjLst_Cache = gs_RTqa_PaperRela_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_RTqa_PaperRela_GetObjLst_PureCache(strTopicId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_RTqa_PaperRelaObjLst_Cache;
        switch (clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_sessionStorage_PureCache(strTopicId);
                break;
            case "03": //localStorage
                arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_localStorage_PureCache(strTopicId);
                break;
            case "02": //ClientCache
                arrgs_RTqa_PaperRelaObjLst_Cache = null;
                break;
            default:
                arrgs_RTqa_PaperRelaObjLst_Cache = null;
                break;
        }
        return arrgs_RTqa_PaperRelaObjLst_Cache;
    }
    exports.gs_RTqa_PaperRela_GetObjLst_PureCache = gs_RTqa_PaperRela_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_RTqa_PaperRela_GetSubObjLst_Cache(objgs_RTqa_PaperRela_Cond, strTopicId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
        let arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRelaObjLst_Cache;
        if (objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == null || objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == "")
            return arrgs_RTqa_PaperRela_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp);
        //console.log("clsgs_RTqa_PaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_RTqa_PaperRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_RTqa_PaperRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_RTqa_PaperRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_RTqa_PaperRela_Cond), exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_RTqa_PaperRela_GetSubObjLst_Cache = gs_RTqa_PaperRela_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function gs_RTqa_PaperRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_GetObjLstBymIdLstAsync = gs_RTqa_PaperRela_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_RTqa_PaperRela_GetObjLstBymIdLst_Cache(arrmIdLst, strTopicId) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
            const arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrgs_RTqa_PaperRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_RTqa_PaperRela_GetObjLstBymIdLst_Cache = gs_RTqa_PaperRela_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_RTqa_PaperRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_GetTopObjLstAsync = gs_RTqa_PaperRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_RTqa_PaperRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_GetObjLstByRangeAsync = gs_RTqa_PaperRela_GetObjLstByRangeAsync;
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
    async function gs_RTqa_PaperRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_GetObjLstByRange = gs_RTqa_PaperRela_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_RTqa_PaperRela_GetObjLstByPager_Cache(objPagerPara, strTopicId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
        if (arrgs_RTqa_PaperRelaObjLst_Cache.length == 0)
            return arrgs_RTqa_PaperRelaObjLst_Cache;
        let arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRelaObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_RTqa_PaperRela_Cond = new clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_RTqa_PaperRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_RTqa_PaperRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_RTqa_PaperRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_RTqa_PaperRela_Sel.length == 0)
                return arrgs_RTqa_PaperRela_Sel;
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
                arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.sort(gs_RTqa_PaperRela_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.slice(intStart, intEnd);
            return arrgs_RTqa_PaperRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_RTqa_PaperRela_GetObjLstByPager_Cache = gs_RTqa_PaperRela_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_RTqa_PaperRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_GetObjLstByPagerAsync = gs_RTqa_PaperRela_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_RTqa_PaperRela_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngmId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngmId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_DelRecordAsync = gs_RTqa_PaperRela_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_RTqa_PaperRela_Delgs_RTqa_PaperRelasAsync(arrmId) {
        const strThisFuncName = "Delgs_RTqa_PaperRelasAsync";
        const strAction = "Delgs_RTqa_PaperRelas";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnInt;
            }
            else {
                console.error(data.errorMsg);
                throw data.errorMsg;
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_Delgs_RTqa_PaperRelasAsync = gs_RTqa_PaperRela_Delgs_RTqa_PaperRelasAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_RTqa_PaperRela_Delgs_RTqa_PaperRelasByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_RTqa_PaperRelasByCondAsync";
        const strAction = "Delgs_RTqa_PaperRelasByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_Delgs_RTqa_PaperRelasByCondAsync = gs_RTqa_PaperRela_Delgs_RTqa_PaperRelasByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_RTqa_PaperRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_RTqa_PaperRela_AddNewRecordAsync(objgs_RTqa_PaperRelaEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_RTqa_PaperRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_RTqa_PaperRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_AddNewRecordAsync = gs_RTqa_PaperRela_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_RTqa_PaperRelaEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_RTqa_PaperRela_AddNewRecordWithReturnKeyAsync(objgs_RTqa_PaperRelaEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_RTqa_PaperRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_AddNewRecordWithReturnKeyAsync = gs_RTqa_PaperRela_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_RTqa_PaperRelaEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_RTqa_PaperRela_AddNewRecordWithReturnKey(objgs_RTqa_PaperRelaEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_RTqa_PaperRelaEN.mId === null || objgs_RTqa_PaperRelaEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_RTqa_PaperRelaEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_AddNewRecordWithReturnKey = gs_RTqa_PaperRela_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_RTqa_PaperRelaEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_RTqa_PaperRela_UpdateRecordAsync(objgs_RTqa_PaperRelaEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_RTqa_PaperRelaEN.sf_UpdFldSetStr === undefined || objgs_RTqa_PaperRelaEN.sf_UpdFldSetStr === null || objgs_RTqa_PaperRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_RTqa_PaperRelaEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_RTqa_PaperRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_UpdateRecordAsync = gs_RTqa_PaperRela_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_RTqa_PaperRelaEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_RTqa_PaperRela_UpdateWithConditionAsync(objgs_RTqa_PaperRelaEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_RTqa_PaperRelaEN.sf_UpdFldSetStr === undefined || objgs_RTqa_PaperRelaEN.sf_UpdFldSetStr === null || objgs_RTqa_PaperRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_RTqa_PaperRelaEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        objgs_RTqa_PaperRelaEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_RTqa_PaperRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_UpdateWithConditionAsync = gs_RTqa_PaperRela_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_RTqa_PaperRela_IsExistRecord_Cache(objgs_RTqa_PaperRela_Cond, strTopicId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
        if (arrgs_RTqa_PaperRelaObjLst_Cache == null)
            return false;
        let arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRelaObjLst_Cache;
        if (objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == null || objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == "")
            return arrgs_RTqa_PaperRela_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp);
        //console.log("clsgs_RTqa_PaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_RTqa_PaperRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_RTqa_PaperRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_RTqa_PaperRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_RTqa_PaperRela_Cond), exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_RTqa_PaperRela_IsExistRecord_Cache = gs_RTqa_PaperRela_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_RTqa_PaperRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_IsExistRecordAsync = gs_RTqa_PaperRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_RTqa_PaperRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "mId": lngmId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_IsExist = gs_RTqa_PaperRela_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_RTqa_PaperRela_IsExist_Cache(lngmId, strTopicId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
        if (arrgs_RTqa_PaperRelaObjLst_Cache == null)
            return false;
        try {
            const arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRelaObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrgs_RTqa_PaperRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_RTqa_PaperRela_IsExist_Cache = gs_RTqa_PaperRela_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_RTqa_PaperRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngmId": lngmId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_IsExistAsync = gs_RTqa_PaperRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_RTqa_PaperRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_GetRecCountByCondAsync = gs_RTqa_PaperRela_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_RTqa_PaperRela_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_RTqa_PaperRela_GetRecCountByCond_Cache(objgs_RTqa_PaperRela_Cond, strTopicId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
        if (arrgs_RTqa_PaperRelaObjLst_Cache == null)
            return 0;
        let arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRelaObjLst_Cache;
        if (objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == null || objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == "")
            return arrgs_RTqa_PaperRela_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp);
        //console.log("clsgs_RTqa_PaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_RTqa_PaperRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_RTqa_PaperRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_RTqa_PaperRela_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_RTqa_PaperRela_Cond), exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_RTqa_PaperRela_GetRecCountByCond_Cache = gs_RTqa_PaperRela_GetRecCountByCond_Cache;
    /*该表的关键字类型不是字符型自增，不需要生成获取最大关键字函数！*/
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_RTqa_PaperRela_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RTqa_PaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strPrefix": strPrefix }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RTqa_PaperRela_GetMaxStrIdByPrefix = gs_RTqa_PaperRela_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_RTqa_PaperRela_GetWebApiUrl(strController, strAction) {
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
    exports.gs_RTqa_PaperRela_GetWebApiUrl = gs_RTqa_PaperRela_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_RTqa_PaperRela_ReFreshCache(strTopicId) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicId]不能为空！(In clsgs_RTqa_PaperRelaWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicId]的长度:[{0}]不正确！", strTopicId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
        switch (clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.CacheModeId) {
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
        (0, clsvgs_RTqa_PaperRelaWApi_js_1.vgs_RTqa_PaperRela_ReFreshThisCache)(strTopicId);
    }
    exports.gs_RTqa_PaperRela_ReFreshCache = gs_RTqa_PaperRela_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_RTqa_PaperRela_ReFreshThisCache(strTopicId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
            switch (clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.CacheModeId) {
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
    exports.gs_RTqa_PaperRela_ReFreshThisCache = gs_RTqa_PaperRela_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_RTqa_PaperRela_CheckPropertyNew(pobjgs_RTqa_PaperRelaEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.topicId) === true
            || pobjgs_RTqa_PaperRelaEN.topicId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[主题Id]不能为空(In 答疑关系表)!(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.qa_PaperId) === true) {
            throw new Error("(errid:Watl000058)字段[论文答疑Id]不能为空(In 答疑关系表)!(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_RTqa_PaperRelaEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.topicId)(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.qa_PaperId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_RTqa_PaperRelaEN.qa_PaperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文答疑Id(qa_PaperId)]的长度不能超过8(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.qa_PaperId)(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_RTqa_PaperRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.updDate)(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_RTqa_PaperRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.updUser)(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_RTqa_PaperRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.memo)(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_RTqa_PaperRelaEN.mId && undefined !== pobjgs_RTqa_PaperRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjgs_RTqa_PaperRelaEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_RTqa_PaperRelaEN.mId)], 非法，应该为数值型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.topicId) == false && undefined !== pobjgs_RTqa_PaperRelaEN.topicId && jsString_js_1.tzDataType.isString(pobjgs_RTqa_PaperRelaEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_RTqa_PaperRelaEN.topicId)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.qa_PaperId) == false && undefined !== pobjgs_RTqa_PaperRelaEN.qa_PaperId && jsString_js_1.tzDataType.isString(pobjgs_RTqa_PaperRelaEN.qa_PaperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文答疑Id(qa_PaperId)]的值:[$(pobjgs_RTqa_PaperRelaEN.qa_PaperId)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.updDate) == false && undefined !== pobjgs_RTqa_PaperRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_RTqa_PaperRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_RTqa_PaperRelaEN.updDate)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.updUser) == false && undefined !== pobjgs_RTqa_PaperRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_RTqa_PaperRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_RTqa_PaperRelaEN.updUser)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.memo) == false && undefined !== pobjgs_RTqa_PaperRelaEN.memo && jsString_js_1.tzDataType.isString(pobjgs_RTqa_PaperRelaEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_RTqa_PaperRelaEN.memo)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_RTqa_PaperRelaEN.SetIsCheckProperty(true);
    }
    exports.gs_RTqa_PaperRela_CheckPropertyNew = gs_RTqa_PaperRela_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_RTqa_PaperRela_CheckProperty4Update(pobjgs_RTqa_PaperRelaEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.topicId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_RTqa_PaperRelaEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.topicId)(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.qa_PaperId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_RTqa_PaperRelaEN.qa_PaperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文答疑Id(qa_PaperId)]的长度不能超过8(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.qa_PaperId)(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_RTqa_PaperRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.updDate)(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_RTqa_PaperRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.updUser)(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_RTqa_PaperRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.memo)(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_RTqa_PaperRelaEN.mId && undefined !== pobjgs_RTqa_PaperRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjgs_RTqa_PaperRelaEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_RTqa_PaperRelaEN.mId)], 非法，应该为数值型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.topicId) == false && undefined !== pobjgs_RTqa_PaperRelaEN.topicId && jsString_js_1.tzDataType.isString(pobjgs_RTqa_PaperRelaEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_RTqa_PaperRelaEN.topicId)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.qa_PaperId) == false && undefined !== pobjgs_RTqa_PaperRelaEN.qa_PaperId && jsString_js_1.tzDataType.isString(pobjgs_RTqa_PaperRelaEN.qa_PaperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文答疑Id(qa_PaperId)]的值:[$(pobjgs_RTqa_PaperRelaEN.qa_PaperId)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.updDate) == false && undefined !== pobjgs_RTqa_PaperRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_RTqa_PaperRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_RTqa_PaperRelaEN.updDate)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.updUser) == false && undefined !== pobjgs_RTqa_PaperRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_RTqa_PaperRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_RTqa_PaperRelaEN.updUser)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_RTqa_PaperRelaEN.memo) == false && undefined !== pobjgs_RTqa_PaperRelaEN.memo && jsString_js_1.tzDataType.isString(pobjgs_RTqa_PaperRelaEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_RTqa_PaperRelaEN.memo)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_RTqa_PaperRelaEN.mId
            || pobjgs_RTqa_PaperRelaEN.mId != null && pobjgs_RTqa_PaperRelaEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 答疑关系表)!(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_RTqa_PaperRelaEN.SetIsCheckProperty(true);
    }
    exports.gs_RTqa_PaperRela_CheckProperty4Update = gs_RTqa_PaperRela_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_RTqa_PaperRela_GetJSONStrByObj(pobjgs_RTqa_PaperRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_RTqa_PaperRelaEN.sf_UpdFldSetStr = pobjgs_RTqa_PaperRelaEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_RTqa_PaperRelaEN);
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
    exports.gs_RTqa_PaperRela_GetJSONStrByObj = gs_RTqa_PaperRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_RTqa_PaperRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_RTqa_PaperRelaObjLst = new Array();
        if (strJSON === "") {
            return arrgs_RTqa_PaperRelaObjLst;
        }
        try {
            arrgs_RTqa_PaperRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_RTqa_PaperRelaObjLst;
        }
        return arrgs_RTqa_PaperRelaObjLst;
    }
    exports.gs_RTqa_PaperRela_GetObjLstByJSONStr = gs_RTqa_PaperRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_RTqa_PaperRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrgs_RTqa_PaperRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_RTqa_PaperRelaObjLst = new Array();
        for (const objInFor of arrgs_RTqa_PaperRelaObjLstS) {
            const obj1 = gs_RTqa_PaperRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_RTqa_PaperRelaObjLst.push(obj1);
        }
        return arrgs_RTqa_PaperRelaObjLst;
    }
    exports.gs_RTqa_PaperRela_GetObjLstByJSONObjLst = gs_RTqa_PaperRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_RTqa_PaperRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_RTqa_PaperRelaEN = new clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN();
        if (strJSON === "") {
            return pobjgs_RTqa_PaperRelaEN;
        }
        try {
            pobjgs_RTqa_PaperRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_RTqa_PaperRelaEN;
        }
        return pobjgs_RTqa_PaperRelaEN;
    }
    exports.gs_RTqa_PaperRela_GetObjByJSONStr = gs_RTqa_PaperRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_RTqa_PaperRela_GetCombineCondition(objgs_RTqa_PaperRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_mId, objgs_RTqa_PaperRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_TopicId, objgs_RTqa_PaperRela_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_qa_PaperId) == true) {
            const strComparisonOp_qa_PaperId = objgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_qa_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_qa_PaperId, objgs_RTqa_PaperRela_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_UpdDate, objgs_RTqa_PaperRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_UpdUser, objgs_RTqa_PaperRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN.con_Memo, objgs_RTqa_PaperRela_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_RTqa_PaperRela_GetCombineCondition = gs_RTqa_PaperRela_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_RTqa_PaperRela(答疑关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_RTqa_PaperRela_GetUniCondStr_mId(objgs_RTqa_PaperRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objgs_RTqa_PaperRelaEN.mId);
        return strWhereCond;
    }
    exports.gs_RTqa_PaperRela_GetUniCondStr_mId = gs_RTqa_PaperRela_GetUniCondStr_mId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_RTqa_PaperRela(答疑关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_RTqa_PaperRela_GetUniCondStr4Update_mId(objgs_RTqa_PaperRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objgs_RTqa_PaperRelaEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objgs_RTqa_PaperRelaEN.mId);
        return strWhereCond;
    }
    exports.gs_RTqa_PaperRela_GetUniCondStr4Update_mId = gs_RTqa_PaperRela_GetUniCondStr4Update_mId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_RTqa_PaperRelaENS:源对象
     * @param objgs_RTqa_PaperRelaENT:目标对象
    */
    function gs_RTqa_PaperRela_CopyObjTo(objgs_RTqa_PaperRelaENS, objgs_RTqa_PaperRelaENT) {
        objgs_RTqa_PaperRelaENT.mId = objgs_RTqa_PaperRelaENS.mId; //mId
        objgs_RTqa_PaperRelaENT.topicId = objgs_RTqa_PaperRelaENS.topicId; //主题Id
        objgs_RTqa_PaperRelaENT.qa_PaperId = objgs_RTqa_PaperRelaENS.qa_PaperId; //论文答疑Id
        objgs_RTqa_PaperRelaENT.updDate = objgs_RTqa_PaperRelaENS.updDate; //修改日期
        objgs_RTqa_PaperRelaENT.updUser = objgs_RTqa_PaperRelaENS.updUser; //修改人
        objgs_RTqa_PaperRelaENT.memo = objgs_RTqa_PaperRelaENS.memo; //备注
        objgs_RTqa_PaperRelaENT.sf_UpdFldSetStr = objgs_RTqa_PaperRelaENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_RTqa_PaperRela_CopyObjTo = gs_RTqa_PaperRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_RTqa_PaperRelaENS:源对象
     * @param objgs_RTqa_PaperRelaENT:目标对象
    */
    function gs_RTqa_PaperRela_GetObjFromJsonObj(objgs_RTqa_PaperRelaENS) {
        const objgs_RTqa_PaperRelaENT = new clsgs_RTqa_PaperRelaEN_js_1.clsgs_RTqa_PaperRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_RTqa_PaperRelaENT, objgs_RTqa_PaperRelaENS);
        return objgs_RTqa_PaperRelaENT;
    }
    exports.gs_RTqa_PaperRela_GetObjFromJsonObj = gs_RTqa_PaperRela_GetObjFromJsonObj;
});
