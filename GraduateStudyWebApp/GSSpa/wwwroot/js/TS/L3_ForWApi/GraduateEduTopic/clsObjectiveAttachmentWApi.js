/**
* 类名:clsObjectiveAttachmentWApi
* 表名:ObjectiveAttachment(01120614)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:52
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsObjectiveAttachmentEN.js", "../../L3_ForWApi/GraduateEduTopic/clsvObjectiveAttachmentWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ObjectiveAttachment_GetObjFromJsonObj = exports.ObjectiveAttachment_CopyObjTo = exports.ObjectiveAttachment_GetUniCondStr4Update_TopicObjectiveId_ObjectiveAttachmentId = exports.ObjectiveAttachment_GetUniCondStr_TopicObjectiveId_ObjectiveAttachmentId = exports.ObjectiveAttachment_GetCombineCondition = exports.ObjectiveAttachment_GetObjByJSONStr = exports.ObjectiveAttachment_GetObjLstByJSONObjLst = exports.ObjectiveAttachment_GetObjLstByJSONStr = exports.ObjectiveAttachment_GetJSONStrByObj = exports.ObjectiveAttachment_CheckProperty4Update = exports.ObjectiveAttachment_CheckPropertyNew = exports.ObjectiveAttachment_ReFreshThisCache = exports.ObjectiveAttachment_ReFreshCache = exports.ObjectiveAttachment_GetWebApiUrl = exports.ObjectiveAttachment_GetMaxStrIdByPrefix = exports.ObjectiveAttachment_GetRecCountByCond_Cache = exports.ObjectiveAttachment_GetRecCountByCondAsync = exports.ObjectiveAttachment_IsExistAsync = exports.ObjectiveAttachment_IsExist_Cache = exports.ObjectiveAttachment_IsExist = exports.ObjectiveAttachment_IsExistRecordAsync = exports.ObjectiveAttachment_IsExistRecord_Cache = exports.ObjectiveAttachment_UpdateWithConditionAsync = exports.ObjectiveAttachment_UpdateRecordAsync = exports.ObjectiveAttachment_AddNewRecordWithReturnKey = exports.ObjectiveAttachment_AddNewRecordWithReturnKeyAsync = exports.ObjectiveAttachment_AddNewRecordAsync = exports.ObjectiveAttachment_DelObjectiveAttachmentsByCondAsync = exports.ObjectiveAttachment_DelObjectiveAttachmentsAsync = exports.ObjectiveAttachment_DelRecordAsync = exports.ObjectiveAttachment_GetObjLstByPagerAsync = exports.ObjectiveAttachment_GetObjLstByPager_Cache = exports.ObjectiveAttachment_GetObjLstByRange = exports.ObjectiveAttachment_GetObjLstByRangeAsync = exports.ObjectiveAttachment_GetTopObjLstAsync = exports.ObjectiveAttachment_GetObjLstByObjectiveAttachmentIdLst_Cache = exports.ObjectiveAttachment_GetObjLstByObjectiveAttachmentIdLstAsync = exports.ObjectiveAttachment_GetSubObjLst_Cache = exports.ObjectiveAttachment_GetObjLst_PureCache = exports.ObjectiveAttachment_GetObjLst_Cache = exports.ObjectiveAttachment_GetObjLst_sessionStorage_PureCache = exports.ObjectiveAttachment_GetObjLst_sessionStorage = exports.ObjectiveAttachment_GetObjLstAsync = exports.ObjectiveAttachment_GetObjLst_localStorage_PureCache = exports.ObjectiveAttachment_GetObjLst_localStorage = exports.ObjectiveAttachment_GetObjLst_ClientCache = exports.ObjectiveAttachment_GetFirstObjAsync = exports.ObjectiveAttachment_GetFirstID = exports.ObjectiveAttachment_GetFirstIDAsync = exports.ObjectiveAttachment_FilterFunByKey = exports.ObjectiveAttachment_SortFunByKey = exports.ObjectiveAttachment_SortFun_Defa_2Fld = exports.ObjectiveAttachment_SortFun_Defa = exports.ObjectiveAttachment_func = exports.ObjectiveAttachment_UpdateObjInLst_Cache = exports.ObjectiveAttachment_GetObjByObjectiveAttachmentId_localStorage = exports.ObjectiveAttachment_GetObjByObjectiveAttachmentId_Cache = exports.ObjectiveAttachment_GetObjByObjectiveAttachmentIdAsync = exports.objectiveAttachment_ConstructorName = exports.objectiveAttachment_Controller = void 0;
    /**
     * 客观附件表(ObjectiveAttachment)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsObjectiveAttachmentEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsObjectiveAttachmentEN.js");
    const clsvObjectiveAttachmentWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsvObjectiveAttachmentWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.objectiveAttachment_Controller = "ObjectiveAttachmentApi";
    exports.objectiveAttachment_ConstructorName = "objectiveAttachment";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngObjectiveAttachmentId:关键字
    * @returns 对象
    **/
    async function ObjectiveAttachment_GetObjByObjectiveAttachmentIdAsync(lngObjectiveAttachmentId) {
        const strThisFuncName = "GetObjByObjectiveAttachmentIdAsync";
        if (lngObjectiveAttachmentId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngObjectiveAttachmentId]不能为空！(In GetObjByObjectiveAttachmentIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByObjectiveAttachmentId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngObjectiveAttachmentId": lngObjectiveAttachmentId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.objectiveAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objObjectiveAttachment = ObjectiveAttachment_GetObjFromJsonObj(returnObj);
                return objObjectiveAttachment;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_GetObjByObjectiveAttachmentIdAsync = ObjectiveAttachment_GetObjByObjectiveAttachmentIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngObjectiveAttachmentId:所给的关键字
     * @returns 对象
    */
    async function ObjectiveAttachment_GetObjByObjectiveAttachmentId_Cache(lngObjectiveAttachmentId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByObjectiveAttachmentId_Cache";
        if (lngObjectiveAttachmentId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngObjectiveAttachmentId]不能为空！(In GetObjByObjectiveAttachmentId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrObjectiveAttachment_Sel = arrObjectiveAttachmentObjLst_Cache.filter(x => x.objectiveAttachmentId == lngObjectiveAttachmentId);
            let objObjectiveAttachment;
            if (arrObjectiveAttachment_Sel.length > 0) {
                objObjectiveAttachment = arrObjectiveAttachment_Sel[0];
                return objObjectiveAttachment;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objObjectiveAttachment = await ObjectiveAttachment_GetObjByObjectiveAttachmentIdAsync(lngObjectiveAttachmentId);
                    if (objObjectiveAttachment != null) {
                        ObjectiveAttachment_ReFreshThisCache(strid_CurrEduCls);
                        return objObjectiveAttachment;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngObjectiveAttachmentId, exports.objectiveAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.ObjectiveAttachment_GetObjByObjectiveAttachmentId_Cache = ObjectiveAttachment_GetObjByObjectiveAttachmentId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngObjectiveAttachmentId:所给的关键字
     * @returns 对象
    */
    async function ObjectiveAttachment_GetObjByObjectiveAttachmentId_localStorage(lngObjectiveAttachmentId) {
        const strThisFuncName = "GetObjByObjectiveAttachmentId_localStorage";
        if (lngObjectiveAttachmentId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngObjectiveAttachmentId]不能为空！(In GetObjByObjectiveAttachmentId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN._CurrTabName, lngObjectiveAttachmentId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objObjectiveAttachment_Cache = JSON.parse(strTempObj);
            return objObjectiveAttachment_Cache;
        }
        try {
            const objObjectiveAttachment = await ObjectiveAttachment_GetObjByObjectiveAttachmentIdAsync(lngObjectiveAttachmentId);
            if (objObjectiveAttachment != null) {
                localStorage.setItem(strKey, JSON.stringify(objObjectiveAttachment));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objObjectiveAttachment;
            }
            return objObjectiveAttachment;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngObjectiveAttachmentId, exports.objectiveAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.ObjectiveAttachment_GetObjByObjectiveAttachmentId_localStorage = ObjectiveAttachment_GetObjByObjectiveAttachmentId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objObjectiveAttachment:所给的对象
     * @returns 对象
    */
    async function ObjectiveAttachment_UpdateObjInLst_Cache(objObjectiveAttachment, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrObjectiveAttachmentObjLst_Cache.find(x => x.topicObjectiveId == objObjectiveAttachment.topicObjectiveId && x.objectiveAttachmentId == objObjectiveAttachment.objectiveAttachmentId);
            if (obj != null) {
                objObjectiveAttachment.objectiveAttachmentId = obj.objectiveAttachmentId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objObjectiveAttachment);
            }
            else {
                arrObjectiveAttachmentObjLst_Cache.push(objObjectiveAttachment);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.objectiveAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.ObjectiveAttachment_UpdateObjInLst_Cache = ObjectiveAttachment_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function ObjectiveAttachment_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_ObjectiveAttachmentId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngObjectiveAttachmentId = Number(strInValue);
        if (lngObjectiveAttachmentId == 0) {
            return "";
        }
        const objObjectiveAttachment = await ObjectiveAttachment_GetObjByObjectiveAttachmentId_Cache(lngObjectiveAttachmentId, strid_CurrEduCls_C);
        if (objObjectiveAttachment == null)
            return "";
        return objObjectiveAttachment.GetFldValue(strOutFldName).toString();
    }
    exports.ObjectiveAttachment_func = ObjectiveAttachment_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ObjectiveAttachment_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.objectiveAttachmentId - b.objectiveAttachmentId;
    }
    exports.ObjectiveAttachment_SortFun_Defa = ObjectiveAttachment_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ObjectiveAttachment_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicObjectiveId == b.topicObjectiveId)
            return a.objectiveAttachmentName.localeCompare(b.objectiveAttachmentName);
        else
            return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
    }
    exports.ObjectiveAttachment_SortFun_Defa_2Fld = ObjectiveAttachment_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ObjectiveAttachment_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_TopicObjectiveId:
                    return (a, b) => {
                        return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
                    };
                case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_ObjectiveAttachmentId:
                    return (a, b) => {
                        return a.objectiveAttachmentId - b.objectiveAttachmentId;
                    };
                case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_ObjectiveAttachmentName:
                    return (a, b) => {
                        return a.objectiveAttachmentName.localeCompare(b.objectiveAttachmentName);
                    };
                case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_FilePath:
                    return (a, b) => {
                        return a.filePath.localeCompare(b.filePath);
                    };
                case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_UpdUserId:
                    return (a, b) => {
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ObjectiveAttachment]中不存在！(in ${exports.objectiveAttachment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_TopicObjectiveId:
                    return (a, b) => {
                        return b.topicObjectiveId.localeCompare(a.topicObjectiveId);
                    };
                case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_ObjectiveAttachmentId:
                    return (a, b) => {
                        return b.objectiveAttachmentId - a.objectiveAttachmentId;
                    };
                case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_ObjectiveAttachmentName:
                    return (a, b) => {
                        return b.objectiveAttachmentName.localeCompare(a.objectiveAttachmentName);
                    };
                case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_FilePath:
                    return (a, b) => {
                        return b.filePath.localeCompare(a.filePath);
                    };
                case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_UpdUserId:
                    return (a, b) => {
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ObjectiveAttachment]中不存在！(in ${exports.objectiveAttachment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ObjectiveAttachment_SortFunByKey = ObjectiveAttachment_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ObjectiveAttachment_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_TopicObjectiveId:
                return (obj) => {
                    return obj.topicObjectiveId === value;
                };
            case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_ObjectiveAttachmentId:
                return (obj) => {
                    return obj.objectiveAttachmentId === value;
                };
            case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_ObjectiveAttachmentName:
                return (obj) => {
                    return obj.objectiveAttachmentName === value;
                };
            case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_FilePath:
                return (obj) => {
                    return obj.filePath === value;
                };
            case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ObjectiveAttachment]中不存在！(in ${exports.objectiveAttachment_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ObjectiveAttachment_FilterFunByKey = ObjectiveAttachment_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ObjectiveAttachment_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_GetFirstIDAsync = ObjectiveAttachment_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ObjectiveAttachment_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_GetFirstID = ObjectiveAttachment_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ObjectiveAttachment_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.objectiveAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objObjectiveAttachment = ObjectiveAttachment_GetObjFromJsonObj(returnObj);
                return objObjectiveAttachment;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_GetFirstObjAsync = ObjectiveAttachment_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ObjectiveAttachment_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
        clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrObjectiveAttachmentExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrObjectiveAttachmentObjLst_T = ObjectiveAttachment_GetObjLstByJSONObjLst(arrObjectiveAttachmentExObjLst_Cache);
            return arrObjectiveAttachmentObjLst_T;
        }
        try {
            const arrObjectiveAttachmentExObjLst = await ObjectiveAttachment_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrObjectiveAttachmentExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrObjectiveAttachmentExObjLst.length);
            console.log(strInfo);
            return arrObjectiveAttachmentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.objectiveAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ObjectiveAttachment_GetObjLst_ClientCache = ObjectiveAttachment_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ObjectiveAttachment_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
        clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrObjectiveAttachmentExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrObjectiveAttachmentObjLst_T = ObjectiveAttachment_GetObjLstByJSONObjLst(arrObjectiveAttachmentExObjLst_Cache);
            return arrObjectiveAttachmentObjLst_T;
        }
        try {
            const arrObjectiveAttachmentExObjLst = await ObjectiveAttachment_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrObjectiveAttachmentExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrObjectiveAttachmentExObjLst.length);
            console.log(strInfo);
            return arrObjectiveAttachmentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.objectiveAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ObjectiveAttachment_GetObjLst_localStorage = ObjectiveAttachment_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ObjectiveAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrObjectiveAttachmentObjLst_Cache = JSON.parse(strTempObjLst);
            return arrObjectiveAttachmentObjLst_Cache;
        }
        else
            return null;
    }
    exports.ObjectiveAttachment_GetObjLst_localStorage_PureCache = ObjectiveAttachment_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ObjectiveAttachment_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.objectiveAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ObjectiveAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_GetObjLstAsync = ObjectiveAttachment_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ObjectiveAttachment_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
        clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrObjectiveAttachmentExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrObjectiveAttachmentObjLst_T = ObjectiveAttachment_GetObjLstByJSONObjLst(arrObjectiveAttachmentExObjLst_Cache);
            return arrObjectiveAttachmentObjLst_T;
        }
        try {
            const arrObjectiveAttachmentExObjLst = await ObjectiveAttachment_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrObjectiveAttachmentExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrObjectiveAttachmentExObjLst.length);
            console.log(strInfo);
            return arrObjectiveAttachmentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.objectiveAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ObjectiveAttachment_GetObjLst_sessionStorage = ObjectiveAttachment_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ObjectiveAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrObjectiveAttachmentObjLst_Cache = JSON.parse(strTempObjLst);
            return arrObjectiveAttachmentObjLst_Cache;
        }
        else
            return null;
    }
    exports.ObjectiveAttachment_GetObjLst_sessionStorage_PureCache = ObjectiveAttachment_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[id_CurrEduCls]不能为空！");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrObjectiveAttachmentObjLst_Cache;
        switch (clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.CacheModeId) {
            case "04": //sessionStorage
                arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrObjectiveAttachmentObjLst = ObjectiveAttachment_GetObjLstByJSONObjLst(arrObjectiveAttachmentObjLst_Cache);
        return arrObjectiveAttachmentObjLst_Cache;
    }
    exports.ObjectiveAttachment_GetObjLst_Cache = ObjectiveAttachment_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ObjectiveAttachment_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrObjectiveAttachmentObjLst_Cache;
        switch (clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.CacheModeId) {
            case "04": //sessionStorage
                arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrObjectiveAttachmentObjLst_Cache = null;
                break;
            default:
                arrObjectiveAttachmentObjLst_Cache = null;
                break;
        }
        return arrObjectiveAttachmentObjLst_Cache;
    }
    exports.ObjectiveAttachment_GetObjLst_PureCache = ObjectiveAttachment_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngObjectiveAttachmentId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ObjectiveAttachment_GetSubObjLst_Cache(objObjectiveAttachment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
        let arrObjectiveAttachment_Sel = arrObjectiveAttachmentObjLst_Cache;
        if (objObjectiveAttachment_Cond.sf_FldComparisonOp == null || objObjectiveAttachment_Cond.sf_FldComparisonOp == "")
            return arrObjectiveAttachment_Sel;
        const dicFldComparisonOp = JSON.parse(objObjectiveAttachment_Cond.sf_FldComparisonOp);
        //console.log("clsObjectiveAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objObjectiveAttachment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objObjectiveAttachment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrObjectiveAttachment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objObjectiveAttachment_Cond), exports.objectiveAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ObjectiveAttachment_GetSubObjLst_Cache = ObjectiveAttachment_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrObjectiveAttachmentId:关键字列表
    * @returns 对象列表
    **/
    async function ObjectiveAttachment_GetObjLstByObjectiveAttachmentIdLstAsync(arrObjectiveAttachmentId) {
        const strThisFuncName = "GetObjLstByObjectiveAttachmentIdLstAsync";
        const strAction = "GetObjLstByObjectiveAttachmentIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrObjectiveAttachmentId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.objectiveAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ObjectiveAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_GetObjLstByObjectiveAttachmentIdLstAsync = ObjectiveAttachment_GetObjLstByObjectiveAttachmentIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngObjectiveAttachmentIdLst:关键字列表
     * @returns 对象列表
    */
    async function ObjectiveAttachment_GetObjLstByObjectiveAttachmentIdLst_Cache(arrObjectiveAttachmentIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByObjectiveAttachmentIdLst_Cache";
        try {
            const arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
            const arrObjectiveAttachment_Sel = arrObjectiveAttachmentObjLst_Cache.filter(x => arrObjectiveAttachmentIdLst.indexOf(x.objectiveAttachmentId) > -1);
            return arrObjectiveAttachment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrObjectiveAttachmentIdLst.join(","), exports.objectiveAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ObjectiveAttachment_GetObjLstByObjectiveAttachmentIdLst_Cache = ObjectiveAttachment_GetObjLstByObjectiveAttachmentIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ObjectiveAttachment_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.objectiveAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ObjectiveAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_GetTopObjLstAsync = ObjectiveAttachment_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ObjectiveAttachment_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.objectiveAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ObjectiveAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_GetObjLstByRangeAsync = ObjectiveAttachment_GetObjLstByRangeAsync;
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
    async function ObjectiveAttachment_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_GetObjLstByRange = ObjectiveAttachment_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function ObjectiveAttachment_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrObjectiveAttachmentObjLst_Cache.length == 0)
            return arrObjectiveAttachmentObjLst_Cache;
        let arrObjectiveAttachment_Sel = arrObjectiveAttachmentObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objObjectiveAttachment_Cond = new clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objObjectiveAttachment_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsObjectiveAttachmentWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objObjectiveAttachment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrObjectiveAttachment_Sel.length == 0)
                return arrObjectiveAttachment_Sel;
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
                arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.sort(ObjectiveAttachment_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.sort(objPagerPara.sortFun);
            }
            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.slice(intStart, intEnd);
            return arrObjectiveAttachment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.objectiveAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ObjectiveAttachment_GetObjLstByPager_Cache = ObjectiveAttachment_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ObjectiveAttachment_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.objectiveAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ObjectiveAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_GetObjLstByPagerAsync = ObjectiveAttachment_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngObjectiveAttachmentId:关键字
    * @returns 获取删除的结果
    **/
    async function ObjectiveAttachment_DelRecordAsync(lngObjectiveAttachmentId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngObjectiveAttachmentId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngObjectiveAttachmentId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_DelRecordAsync = ObjectiveAttachment_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrObjectiveAttachmentId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ObjectiveAttachment_DelObjectiveAttachmentsAsync(arrObjectiveAttachmentId) {
        const strThisFuncName = "DelObjectiveAttachmentsAsync";
        const strAction = "DelObjectiveAttachments";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrObjectiveAttachmentId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_DelObjectiveAttachmentsAsync = ObjectiveAttachment_DelObjectiveAttachmentsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ObjectiveAttachment_DelObjectiveAttachmentsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelObjectiveAttachmentsByCondAsync";
        const strAction = "DelObjectiveAttachmentsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_DelObjectiveAttachmentsByCondAsync = ObjectiveAttachment_DelObjectiveAttachmentsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objObjectiveAttachmentEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ObjectiveAttachment_AddNewRecordAsync(objObjectiveAttachmentEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objObjectiveAttachmentEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objObjectiveAttachmentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_AddNewRecordAsync = ObjectiveAttachment_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objObjectiveAttachmentEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ObjectiveAttachment_AddNewRecordWithReturnKeyAsync(objObjectiveAttachmentEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objObjectiveAttachmentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_AddNewRecordWithReturnKeyAsync = ObjectiveAttachment_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objObjectiveAttachmentEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ObjectiveAttachment_AddNewRecordWithReturnKey(objObjectiveAttachmentEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objObjectiveAttachmentEN.objectiveAttachmentId === null || objObjectiveAttachmentEN.objectiveAttachmentId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objObjectiveAttachmentEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_AddNewRecordWithReturnKey = ObjectiveAttachment_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objObjectiveAttachmentEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ObjectiveAttachment_UpdateRecordAsync(objObjectiveAttachmentEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objObjectiveAttachmentEN.sf_UpdFldSetStr === undefined || objObjectiveAttachmentEN.sf_UpdFldSetStr === null || objObjectiveAttachmentEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objObjectiveAttachmentEN.objectiveAttachmentId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objObjectiveAttachmentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_UpdateRecordAsync = ObjectiveAttachment_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objObjectiveAttachmentEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ObjectiveAttachment_UpdateWithConditionAsync(objObjectiveAttachmentEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objObjectiveAttachmentEN.sf_UpdFldSetStr === undefined || objObjectiveAttachmentEN.sf_UpdFldSetStr === null || objObjectiveAttachmentEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objObjectiveAttachmentEN.objectiveAttachmentId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
        objObjectiveAttachmentEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objObjectiveAttachmentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_UpdateWithConditionAsync = ObjectiveAttachment_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngObjectiveAttachmentId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ObjectiveAttachment_IsExistRecord_Cache(objObjectiveAttachment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrObjectiveAttachmentObjLst_Cache == null)
            return false;
        let arrObjectiveAttachment_Sel = arrObjectiveAttachmentObjLst_Cache;
        if (objObjectiveAttachment_Cond.sf_FldComparisonOp == null || objObjectiveAttachment_Cond.sf_FldComparisonOp == "")
            return arrObjectiveAttachment_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objObjectiveAttachment_Cond.sf_FldComparisonOp);
        //console.log("clsObjectiveAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objObjectiveAttachment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objObjectiveAttachment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrObjectiveAttachment_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objObjectiveAttachment_Cond), exports.objectiveAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.ObjectiveAttachment_IsExistRecord_Cache = ObjectiveAttachment_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ObjectiveAttachment_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_IsExistRecordAsync = ObjectiveAttachment_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngObjectiveAttachmentId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ObjectiveAttachment_IsExist(lngObjectiveAttachmentId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ObjectiveAttachmentId": lngObjectiveAttachmentId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_IsExist = ObjectiveAttachment_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngObjectiveAttachmentId:所给的关键字
     * @returns 对象
    */
    async function ObjectiveAttachment_IsExist_Cache(lngObjectiveAttachmentId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrObjectiveAttachmentObjLst_Cache == null)
            return false;
        try {
            const arrObjectiveAttachment_Sel = arrObjectiveAttachmentObjLst_Cache.filter(x => x.objectiveAttachmentId == lngObjectiveAttachmentId);
            if (arrObjectiveAttachment_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngObjectiveAttachmentId, exports.objectiveAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.ObjectiveAttachment_IsExist_Cache = ObjectiveAttachment_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngObjectiveAttachmentId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ObjectiveAttachment_IsExistAsync(lngObjectiveAttachmentId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngObjectiveAttachmentId": lngObjectiveAttachmentId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_IsExistAsync = ObjectiveAttachment_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ObjectiveAttachment_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_GetRecCountByCondAsync = ObjectiveAttachment_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objObjectiveAttachment_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function ObjectiveAttachment_GetRecCountByCond_Cache(objObjectiveAttachment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrObjectiveAttachmentObjLst_Cache == null)
            return 0;
        let arrObjectiveAttachment_Sel = arrObjectiveAttachmentObjLst_Cache;
        if (objObjectiveAttachment_Cond.sf_FldComparisonOp == null || objObjectiveAttachment_Cond.sf_FldComparisonOp == "")
            return arrObjectiveAttachment_Sel.length;
        const dicFldComparisonOp = JSON.parse(objObjectiveAttachment_Cond.sf_FldComparisonOp);
        //console.log("clsObjectiveAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objObjectiveAttachment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objObjectiveAttachment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrObjectiveAttachment_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objObjectiveAttachment_Cond), exports.objectiveAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.ObjectiveAttachment_GetRecCountByCond_Cache = ObjectiveAttachment_GetRecCountByCond_Cache;
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
    async function ObjectiveAttachment_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.objectiveAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.objectiveAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ObjectiveAttachment_GetMaxStrIdByPrefix = ObjectiveAttachment_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ObjectiveAttachment_GetWebApiUrl(strController, strAction) {
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
    exports.ObjectiveAttachment_GetWebApiUrl = ObjectiveAttachment_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function ObjectiveAttachment_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsObjectiveAttachmentWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
        switch (clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.CacheModeId) {
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
        (0, clsvObjectiveAttachmentWApi_js_1.vObjectiveAttachment_ReFreshThisCache)(strid_CurrEduCls);
    }
    exports.ObjectiveAttachment_ReFreshCache = ObjectiveAttachment_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function ObjectiveAttachment_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
            switch (clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.CacheModeId) {
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
    exports.ObjectiveAttachment_ReFreshThisCache = ObjectiveAttachment_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ObjectiveAttachment_CheckPropertyNew(pobjObjectiveAttachmentEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.topicObjectiveId) === true) {
            throw new Error("(errid:Watl000058)字段[客观Id]不能为空(In 客观附件表)!(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.filePath) === true) {
            throw new Error("(errid:Watl000058)字段[文件路径]不能为空(In 客观附件表)!(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.topicObjectiveId) == false && (0, clsString_js_1.GetStrLen)(pobjObjectiveAttachmentEN.topicObjectiveId) > 8) {
            throw new Error("(errid:Watl000059)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.topicObjectiveId)(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.objectiveAttachmentName) == false && (0, clsString_js_1.GetStrLen)(pobjObjectiveAttachmentEN.objectiveAttachmentName) > 200) {
            throw new Error("(errid:Watl000059)字段[附件名称(objectiveAttachmentName)]的长度不能超过200(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.objectiveAttachmentName)(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.filePath) == false && (0, clsString_js_1.GetStrLen)(pobjObjectiveAttachmentEN.filePath) > 500) {
            throw new Error("(errid:Watl000059)字段[文件路径(filePath)]的长度不能超过500(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.filePath)(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjObjectiveAttachmentEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.updDate)(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjObjectiveAttachmentEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.updUserId)(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjObjectiveAttachmentEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.memo)(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjObjectiveAttachmentEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.id_CurrEduCls)(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.topicObjectiveId) == false && undefined !== pobjObjectiveAttachmentEN.topicObjectiveId && jsString_js_1.tzDataType.isString(pobjObjectiveAttachmentEN.topicObjectiveId) === false) {
            throw new Error("(errid:Watl000060)字段[客观Id(topicObjectiveId)]的值:[$(pobjObjectiveAttachmentEN.topicObjectiveId)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        if (null != pobjObjectiveAttachmentEN.objectiveAttachmentId && undefined !== pobjObjectiveAttachmentEN.objectiveAttachmentId && jsString_js_1.tzDataType.isNumber(pobjObjectiveAttachmentEN.objectiveAttachmentId) === false) {
            throw new Error("(errid:Watl000060)字段[客观附件Id(objectiveAttachmentId)]的值:[$(pobjObjectiveAttachmentEN.objectiveAttachmentId)], 非法，应该为数值型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.objectiveAttachmentName) == false && undefined !== pobjObjectiveAttachmentEN.objectiveAttachmentName && jsString_js_1.tzDataType.isString(pobjObjectiveAttachmentEN.objectiveAttachmentName) === false) {
            throw new Error("(errid:Watl000060)字段[附件名称(objectiveAttachmentName)]的值:[$(pobjObjectiveAttachmentEN.objectiveAttachmentName)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.filePath) == false && undefined !== pobjObjectiveAttachmentEN.filePath && jsString_js_1.tzDataType.isString(pobjObjectiveAttachmentEN.filePath) === false) {
            throw new Error("(errid:Watl000060)字段[文件路径(filePath)]的值:[$(pobjObjectiveAttachmentEN.filePath)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.updDate) == false && undefined !== pobjObjectiveAttachmentEN.updDate && jsString_js_1.tzDataType.isString(pobjObjectiveAttachmentEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjObjectiveAttachmentEN.updDate)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.updUserId) == false && undefined !== pobjObjectiveAttachmentEN.updUserId && jsString_js_1.tzDataType.isString(pobjObjectiveAttachmentEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjObjectiveAttachmentEN.updUserId)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.memo) == false && undefined !== pobjObjectiveAttachmentEN.memo && jsString_js_1.tzDataType.isString(pobjObjectiveAttachmentEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjObjectiveAttachmentEN.memo)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.id_CurrEduCls) == false && undefined !== pobjObjectiveAttachmentEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjObjectiveAttachmentEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjObjectiveAttachmentEN.id_CurrEduCls)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjObjectiveAttachmentEN.SetIsCheckProperty(true);
    }
    exports.ObjectiveAttachment_CheckPropertyNew = ObjectiveAttachment_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ObjectiveAttachment_CheckProperty4Update(pobjObjectiveAttachmentEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.topicObjectiveId) == false && (0, clsString_js_1.GetStrLen)(pobjObjectiveAttachmentEN.topicObjectiveId) > 8) {
            throw new Error("(errid:Watl000062)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.topicObjectiveId)(clsObjectiveAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.objectiveAttachmentName) == false && (0, clsString_js_1.GetStrLen)(pobjObjectiveAttachmentEN.objectiveAttachmentName) > 200) {
            throw new Error("(errid:Watl000062)字段[附件名称(objectiveAttachmentName)]的长度不能超过200(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.objectiveAttachmentName)(clsObjectiveAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.filePath) == false && (0, clsString_js_1.GetStrLen)(pobjObjectiveAttachmentEN.filePath) > 500) {
            throw new Error("(errid:Watl000062)字段[文件路径(filePath)]的长度不能超过500(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.filePath)(clsObjectiveAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjObjectiveAttachmentEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.updDate)(clsObjectiveAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjObjectiveAttachmentEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.updUserId)(clsObjectiveAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjObjectiveAttachmentEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.memo)(clsObjectiveAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjObjectiveAttachmentEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.id_CurrEduCls)(clsObjectiveAttachmentBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.topicObjectiveId) == false && undefined !== pobjObjectiveAttachmentEN.topicObjectiveId && jsString_js_1.tzDataType.isString(pobjObjectiveAttachmentEN.topicObjectiveId) === false) {
            throw new Error("(errid:Watl000063)字段[客观Id(topicObjectiveId)]的值:[$(pobjObjectiveAttachmentEN.topicObjectiveId)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckProperty4Update)");
        }
        if (null != pobjObjectiveAttachmentEN.objectiveAttachmentId && undefined !== pobjObjectiveAttachmentEN.objectiveAttachmentId && jsString_js_1.tzDataType.isNumber(pobjObjectiveAttachmentEN.objectiveAttachmentId) === false) {
            throw new Error("(errid:Watl000063)字段[客观附件Id(objectiveAttachmentId)]的值:[$(pobjObjectiveAttachmentEN.objectiveAttachmentId)], 非法，应该为数值型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.objectiveAttachmentName) == false && undefined !== pobjObjectiveAttachmentEN.objectiveAttachmentName && jsString_js_1.tzDataType.isString(pobjObjectiveAttachmentEN.objectiveAttachmentName) === false) {
            throw new Error("(errid:Watl000063)字段[附件名称(objectiveAttachmentName)]的值:[$(pobjObjectiveAttachmentEN.objectiveAttachmentName)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.filePath) == false && undefined !== pobjObjectiveAttachmentEN.filePath && jsString_js_1.tzDataType.isString(pobjObjectiveAttachmentEN.filePath) === false) {
            throw new Error("(errid:Watl000063)字段[文件路径(filePath)]的值:[$(pobjObjectiveAttachmentEN.filePath)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.updDate) == false && undefined !== pobjObjectiveAttachmentEN.updDate && jsString_js_1.tzDataType.isString(pobjObjectiveAttachmentEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjObjectiveAttachmentEN.updDate)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.updUserId) == false && undefined !== pobjObjectiveAttachmentEN.updUserId && jsString_js_1.tzDataType.isString(pobjObjectiveAttachmentEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjObjectiveAttachmentEN.updUserId)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.memo) == false && undefined !== pobjObjectiveAttachmentEN.memo && jsString_js_1.tzDataType.isString(pobjObjectiveAttachmentEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjObjectiveAttachmentEN.memo)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjObjectiveAttachmentEN.id_CurrEduCls) == false && undefined !== pobjObjectiveAttachmentEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjObjectiveAttachmentEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjObjectiveAttachmentEN.id_CurrEduCls)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjObjectiveAttachmentEN.objectiveAttachmentId
            || pobjObjectiveAttachmentEN.objectiveAttachmentId != null && pobjObjectiveAttachmentEN.objectiveAttachmentId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[客观附件Id]不能为空(In 客观附件表)!(clsObjectiveAttachmentBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjObjectiveAttachmentEN.SetIsCheckProperty(true);
    }
    exports.ObjectiveAttachment_CheckProperty4Update = ObjectiveAttachment_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ObjectiveAttachment_GetJSONStrByObj(pobjObjectiveAttachmentEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjObjectiveAttachmentEN.sf_UpdFldSetStr = pobjObjectiveAttachmentEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjObjectiveAttachmentEN);
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
    exports.ObjectiveAttachment_GetJSONStrByObj = ObjectiveAttachment_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ObjectiveAttachment_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrObjectiveAttachmentObjLst = new Array();
        if (strJSON === "") {
            return arrObjectiveAttachmentObjLst;
        }
        try {
            arrObjectiveAttachmentObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrObjectiveAttachmentObjLst;
        }
        return arrObjectiveAttachmentObjLst;
    }
    exports.ObjectiveAttachment_GetObjLstByJSONStr = ObjectiveAttachment_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrObjectiveAttachmentObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ObjectiveAttachment_GetObjLstByJSONObjLst(arrObjectiveAttachmentObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrObjectiveAttachmentObjLst = new Array();
        for (const objInFor of arrObjectiveAttachmentObjLstS) {
            const obj1 = ObjectiveAttachment_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrObjectiveAttachmentObjLst.push(obj1);
        }
        return arrObjectiveAttachmentObjLst;
    }
    exports.ObjectiveAttachment_GetObjLstByJSONObjLst = ObjectiveAttachment_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ObjectiveAttachment_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjObjectiveAttachmentEN = new clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN();
        if (strJSON === "") {
            return pobjObjectiveAttachmentEN;
        }
        try {
            pobjObjectiveAttachmentEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjObjectiveAttachmentEN;
        }
        return pobjObjectiveAttachmentEN;
    }
    exports.ObjectiveAttachment_GetObjByJSONStr = ObjectiveAttachment_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ObjectiveAttachment_GetCombineCondition(objObjectiveAttachment_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objObjectiveAttachment_Cond.dicFldComparisonOp, clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_TopicObjectiveId) == true) {
            const strComparisonOp_TopicObjectiveId = objObjectiveAttachment_Cond.dicFldComparisonOp[clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_TopicObjectiveId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_TopicObjectiveId, objObjectiveAttachment_Cond.topicObjectiveId, strComparisonOp_TopicObjectiveId);
        }
        if (Object.prototype.hasOwnProperty.call(objObjectiveAttachment_Cond.dicFldComparisonOp, clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_ObjectiveAttachmentId) == true) {
            const strComparisonOp_ObjectiveAttachmentId = objObjectiveAttachment_Cond.dicFldComparisonOp[clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_ObjectiveAttachmentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_ObjectiveAttachmentId, objObjectiveAttachment_Cond.objectiveAttachmentId, strComparisonOp_ObjectiveAttachmentId);
        }
        if (Object.prototype.hasOwnProperty.call(objObjectiveAttachment_Cond.dicFldComparisonOp, clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_ObjectiveAttachmentName) == true) {
            const strComparisonOp_ObjectiveAttachmentName = objObjectiveAttachment_Cond.dicFldComparisonOp[clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_ObjectiveAttachmentName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_ObjectiveAttachmentName, objObjectiveAttachment_Cond.objectiveAttachmentName, strComparisonOp_ObjectiveAttachmentName);
        }
        if (Object.prototype.hasOwnProperty.call(objObjectiveAttachment_Cond.dicFldComparisonOp, clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_FilePath) == true) {
            const strComparisonOp_FilePath = objObjectiveAttachment_Cond.dicFldComparisonOp[clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_FilePath];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_FilePath, objObjectiveAttachment_Cond.filePath, strComparisonOp_FilePath);
        }
        if (Object.prototype.hasOwnProperty.call(objObjectiveAttachment_Cond.dicFldComparisonOp, clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objObjectiveAttachment_Cond.dicFldComparisonOp[clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_UpdDate, objObjectiveAttachment_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objObjectiveAttachment_Cond.dicFldComparisonOp, clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objObjectiveAttachment_Cond.dicFldComparisonOp[clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_UpdUserId, objObjectiveAttachment_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objObjectiveAttachment_Cond.dicFldComparisonOp, clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_Memo) == true) {
            const strComparisonOp_Memo = objObjectiveAttachment_Cond.dicFldComparisonOp[clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_Memo, objObjectiveAttachment_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objObjectiveAttachment_Cond.dicFldComparisonOp, clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objObjectiveAttachment_Cond.dicFldComparisonOp[clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN.con_id_CurrEduCls, objObjectiveAttachment_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.ObjectiveAttachment_GetCombineCondition = ObjectiveAttachment_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--ObjectiveAttachment(客观附件表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strTopicObjectiveId: 客观Id(要求唯一的字段)
    * @param lngObjectiveAttachmentId: 客观附件Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ObjectiveAttachment_GetUniCondStr_TopicObjectiveId_ObjectiveAttachmentId(objObjectiveAttachmentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and TopicObjectiveId = '{0}'", objObjectiveAttachmentEN.topicObjectiveId);
        strWhereCond += (0, clsString_js_1.Format)(" and ObjectiveAttachmentId = '{0}'", objObjectiveAttachmentEN.objectiveAttachmentId);
        return strWhereCond;
    }
    exports.ObjectiveAttachment_GetUniCondStr_TopicObjectiveId_ObjectiveAttachmentId = ObjectiveAttachment_GetUniCondStr_TopicObjectiveId_ObjectiveAttachmentId;
    /**
    *获取唯一性条件串(Uniqueness)--ObjectiveAttachment(客观附件表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strTopicObjectiveId: 客观Id(要求唯一的字段)
    * @param lngObjectiveAttachmentId: 客观附件Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ObjectiveAttachment_GetUniCondStr4Update_TopicObjectiveId_ObjectiveAttachmentId(objObjectiveAttachmentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ObjectiveAttachmentId <> '{0}'", objObjectiveAttachmentEN.objectiveAttachmentId);
        strWhereCond += (0, clsString_js_1.Format)(" and TopicObjectiveId = '{0}'", objObjectiveAttachmentEN.topicObjectiveId);
        strWhereCond += (0, clsString_js_1.Format)(" and ObjectiveAttachmentId = '{0}'", objObjectiveAttachmentEN.objectiveAttachmentId);
        return strWhereCond;
    }
    exports.ObjectiveAttachment_GetUniCondStr4Update_TopicObjectiveId_ObjectiveAttachmentId = ObjectiveAttachment_GetUniCondStr4Update_TopicObjectiveId_ObjectiveAttachmentId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objObjectiveAttachmentENS:源对象
     * @param objObjectiveAttachmentENT:目标对象
    */
    function ObjectiveAttachment_CopyObjTo(objObjectiveAttachmentENS, objObjectiveAttachmentENT) {
        objObjectiveAttachmentENT.topicObjectiveId = objObjectiveAttachmentENS.topicObjectiveId; //客观Id
        objObjectiveAttachmentENT.objectiveAttachmentId = objObjectiveAttachmentENS.objectiveAttachmentId; //客观附件Id
        objObjectiveAttachmentENT.objectiveAttachmentName = objObjectiveAttachmentENS.objectiveAttachmentName; //附件名称
        objObjectiveAttachmentENT.filePath = objObjectiveAttachmentENS.filePath; //文件路径
        objObjectiveAttachmentENT.updDate = objObjectiveAttachmentENS.updDate; //修改日期
        objObjectiveAttachmentENT.updUserId = objObjectiveAttachmentENS.updUserId; //修改用户Id
        objObjectiveAttachmentENT.memo = objObjectiveAttachmentENS.memo; //备注
        objObjectiveAttachmentENT.id_CurrEduCls = objObjectiveAttachmentENS.id_CurrEduCls; //教学班流水号
        objObjectiveAttachmentENT.sf_UpdFldSetStr = objObjectiveAttachmentENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ObjectiveAttachment_CopyObjTo = ObjectiveAttachment_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objObjectiveAttachmentENS:源对象
     * @param objObjectiveAttachmentENT:目标对象
    */
    function ObjectiveAttachment_GetObjFromJsonObj(objObjectiveAttachmentENS) {
        const objObjectiveAttachmentENT = new clsObjectiveAttachmentEN_js_1.clsObjectiveAttachmentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objObjectiveAttachmentENT, objObjectiveAttachmentENS);
        return objObjectiveAttachmentENT;
    }
    exports.ObjectiveAttachment_GetObjFromJsonObj = ObjectiveAttachment_GetObjFromJsonObj;
});
