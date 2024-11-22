/**
* 类名:clsViewpointAttachmentWApi
* 表名:ViewpointAttachment(01120591)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:54
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsViewpointAttachmentEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ViewpointAttachment_GetObjFromJsonObj = exports.ViewpointAttachment_CopyObjTo = exports.ViewpointAttachment_GetUniCondStr4Update_ViewpointAttachmentId_ViewpointAttachmentName = exports.ViewpointAttachment_GetUniCondStr_ViewpointAttachmentId_ViewpointAttachmentName = exports.ViewpointAttachment_GetCombineCondition = exports.ViewpointAttachment_GetObjByJSONStr = exports.ViewpointAttachment_GetObjLstByJSONObjLst = exports.ViewpointAttachment_GetObjLstByJSONStr = exports.ViewpointAttachment_GetJSONStrByObj = exports.ViewpointAttachment_CheckProperty4Update = exports.ViewpointAttachment_CheckPropertyNew = exports.ViewpointAttachment_ReFreshThisCache = exports.ViewpointAttachment_ReFreshCache = exports.ViewpointAttachment_GetWebApiUrl = exports.ViewpointAttachment_GetMaxStrIdByPrefix = exports.ViewpointAttachment_GetRecCountByCond_Cache = exports.ViewpointAttachment_GetRecCountByCondAsync = exports.ViewpointAttachment_IsExistAsync = exports.ViewpointAttachment_IsExist_Cache = exports.ViewpointAttachment_IsExist = exports.ViewpointAttachment_IsExistRecordAsync = exports.ViewpointAttachment_IsExistRecord_Cache = exports.ViewpointAttachment_UpdateWithConditionAsync = exports.ViewpointAttachment_UpdateRecordAsync = exports.ViewpointAttachment_AddNewRecordWithReturnKey = exports.ViewpointAttachment_AddNewRecordWithReturnKeyAsync = exports.ViewpointAttachment_AddNewRecordAsync = exports.ViewpointAttachment_DelViewpointAttachmentsByCondAsync = exports.ViewpointAttachment_DelViewpointAttachmentsAsync = exports.ViewpointAttachment_DelRecordAsync = exports.ViewpointAttachment_GetObjLstByPagerAsync = exports.ViewpointAttachment_GetObjLstByPager_Cache = exports.ViewpointAttachment_GetObjLstByRange = exports.ViewpointAttachment_GetObjLstByRangeAsync = exports.ViewpointAttachment_GetTopObjLstAsync = exports.ViewpointAttachment_GetObjLstByViewpointAttachmentIdLst_Cache = exports.ViewpointAttachment_GetObjLstByViewpointAttachmentIdLstAsync = exports.ViewpointAttachment_GetSubObjLst_Cache = exports.ViewpointAttachment_GetObjLst_PureCache = exports.ViewpointAttachment_GetObjLst_Cache = exports.ViewpointAttachment_GetObjLst_sessionStorage_PureCache = exports.ViewpointAttachment_GetObjLst_sessionStorage = exports.ViewpointAttachment_GetObjLstAsync = exports.ViewpointAttachment_GetObjLst_localStorage_PureCache = exports.ViewpointAttachment_GetObjLst_localStorage = exports.ViewpointAttachment_GetObjLst_ClientCache = exports.ViewpointAttachment_GetFirstObjAsync = exports.ViewpointAttachment_GetFirstID = exports.ViewpointAttachment_GetFirstIDAsync = exports.ViewpointAttachment_FilterFunByKey = exports.ViewpointAttachment_SortFunByKey = exports.ViewpointAttachment_SortFun_Defa_2Fld = exports.ViewpointAttachment_SortFun_Defa = exports.ViewpointAttachment_func = exports.ViewpointAttachment_UpdateObjInLst_Cache = exports.ViewpointAttachment_GetObjByViewpointAttachmentId_localStorage = exports.ViewpointAttachment_GetObjByViewpointAttachmentId_Cache = exports.ViewpointAttachment_GetObjByViewpointAttachmentIdAsync = exports.viewpointAttachment_ConstructorName = exports.viewpointAttachment_Controller = void 0;
    /**
     * 观点附件表(ViewpointAttachment)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsViewpointAttachmentEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsViewpointAttachmentEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.viewpointAttachment_Controller = "ViewpointAttachmentApi";
    exports.viewpointAttachment_ConstructorName = "viewpointAttachment";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngViewpointAttachmentId:关键字
    * @returns 对象
    **/
    async function ViewpointAttachment_GetObjByViewpointAttachmentIdAsync(lngViewpointAttachmentId) {
        const strThisFuncName = "GetObjByViewpointAttachmentIdAsync";
        if (lngViewpointAttachmentId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngViewpointAttachmentId]不能为空！(In GetObjByViewpointAttachmentIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByViewpointAttachmentId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngViewpointAttachmentId": lngViewpointAttachmentId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objViewpointAttachment = ViewpointAttachment_GetObjFromJsonObj(returnObj);
                return objViewpointAttachment;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_GetObjByViewpointAttachmentIdAsync = ViewpointAttachment_GetObjByViewpointAttachmentIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngViewpointAttachmentId:所给的关键字
     * @returns 对象
    */
    async function ViewpointAttachment_GetObjByViewpointAttachmentId_Cache(lngViewpointAttachmentId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByViewpointAttachmentId_Cache";
        if (lngViewpointAttachmentId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngViewpointAttachmentId]不能为空！(In GetObjByViewpointAttachmentId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrViewpointAttachment_Sel = arrViewpointAttachmentObjLst_Cache.filter(x => x.viewpointAttachmentId == lngViewpointAttachmentId);
            let objViewpointAttachment;
            if (arrViewpointAttachment_Sel.length > 0) {
                objViewpointAttachment = arrViewpointAttachment_Sel[0];
                return objViewpointAttachment;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objViewpointAttachment = await ViewpointAttachment_GetObjByViewpointAttachmentIdAsync(lngViewpointAttachmentId);
                    if (objViewpointAttachment != null) {
                        ViewpointAttachment_ReFreshThisCache(strid_CurrEduCls);
                        return objViewpointAttachment;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngViewpointAttachmentId, exports.viewpointAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.ViewpointAttachment_GetObjByViewpointAttachmentId_Cache = ViewpointAttachment_GetObjByViewpointAttachmentId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngViewpointAttachmentId:所给的关键字
     * @returns 对象
    */
    async function ViewpointAttachment_GetObjByViewpointAttachmentId_localStorage(lngViewpointAttachmentId) {
        const strThisFuncName = "GetObjByViewpointAttachmentId_localStorage";
        if (lngViewpointAttachmentId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngViewpointAttachmentId]不能为空！(In GetObjByViewpointAttachmentId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN._CurrTabName, lngViewpointAttachmentId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objViewpointAttachment_Cache = JSON.parse(strTempObj);
            return objViewpointAttachment_Cache;
        }
        try {
            const objViewpointAttachment = await ViewpointAttachment_GetObjByViewpointAttachmentIdAsync(lngViewpointAttachmentId);
            if (objViewpointAttachment != null) {
                localStorage.setItem(strKey, JSON.stringify(objViewpointAttachment));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objViewpointAttachment;
            }
            return objViewpointAttachment;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngViewpointAttachmentId, exports.viewpointAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.ViewpointAttachment_GetObjByViewpointAttachmentId_localStorage = ViewpointAttachment_GetObjByViewpointAttachmentId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objViewpointAttachment:所给的对象
     * @returns 对象
    */
    async function ViewpointAttachment_UpdateObjInLst_Cache(objViewpointAttachment, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrViewpointAttachmentObjLst_Cache.find(x => x.viewpointAttachmentId == objViewpointAttachment.viewpointAttachmentId && x.viewpointAttachmentName == objViewpointAttachment.viewpointAttachmentName);
            if (obj != null) {
                objViewpointAttachment.viewpointAttachmentId = obj.viewpointAttachmentId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objViewpointAttachment);
            }
            else {
                arrViewpointAttachmentObjLst_Cache.push(objViewpointAttachment);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.viewpointAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.ViewpointAttachment_UpdateObjInLst_Cache = ViewpointAttachment_UpdateObjInLst_Cache;
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
    async function ViewpointAttachment_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
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
        if (strInFldName != clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointAttachmentId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngViewpointAttachmentId = Number(strInValue);
        if (lngViewpointAttachmentId == 0) {
            return "";
        }
        const objViewpointAttachment = await ViewpointAttachment_GetObjByViewpointAttachmentId_Cache(lngViewpointAttachmentId, strid_CurrEduCls_C);
        if (objViewpointAttachment == null)
            return "";
        return objViewpointAttachment.GetFldValue(strOutFldName).toString();
    }
    exports.ViewpointAttachment_func = ViewpointAttachment_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ViewpointAttachment_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.viewpointAttachmentId - b.viewpointAttachmentId;
    }
    exports.ViewpointAttachment_SortFun_Defa = ViewpointAttachment_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ViewpointAttachment_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.viewpointAttachmentName == b.viewpointAttachmentName)
            return a.viewpointId.localeCompare(b.viewpointId);
        else
            return a.viewpointAttachmentName.localeCompare(b.viewpointAttachmentName);
    }
    exports.ViewpointAttachment_SortFun_Defa_2Fld = ViewpointAttachment_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ViewpointAttachment_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointAttachmentId:
                    return (a, b) => {
                        return a.viewpointAttachmentId - b.viewpointAttachmentId;
                    };
                case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointAttachmentName:
                    return (a, b) => {
                        return a.viewpointAttachmentName.localeCompare(b.viewpointAttachmentName);
                    };
                case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointId:
                    return (a, b) => {
                        return a.viewpointId.localeCompare(b.viewpointId);
                    };
                case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_FilePath:
                    return (a, b) => {
                        return a.filePath.localeCompare(b.filePath);
                    };
                case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_UpdUserId:
                    return (a, b) => {
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ViewpointAttachment]中不存在！(in ${exports.viewpointAttachment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointAttachmentId:
                    return (a, b) => {
                        return b.viewpointAttachmentId - a.viewpointAttachmentId;
                    };
                case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointAttachmentName:
                    return (a, b) => {
                        return b.viewpointAttachmentName.localeCompare(a.viewpointAttachmentName);
                    };
                case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointId:
                    return (a, b) => {
                        return b.viewpointId.localeCompare(a.viewpointId);
                    };
                case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_FilePath:
                    return (a, b) => {
                        return b.filePath.localeCompare(a.filePath);
                    };
                case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_UpdUserId:
                    return (a, b) => {
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ViewpointAttachment]中不存在！(in ${exports.viewpointAttachment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ViewpointAttachment_SortFunByKey = ViewpointAttachment_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ViewpointAttachment_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointAttachmentId:
                return (obj) => {
                    return obj.viewpointAttachmentId === value;
                };
            case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointAttachmentName:
                return (obj) => {
                    return obj.viewpointAttachmentName === value;
                };
            case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointId:
                return (obj) => {
                    return obj.viewpointId === value;
                };
            case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_FilePath:
                return (obj) => {
                    return obj.filePath === value;
                };
            case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ViewpointAttachment]中不存在！(in ${exports.viewpointAttachment_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ViewpointAttachment_FilterFunByKey = ViewpointAttachment_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ViewpointAttachment_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_GetFirstIDAsync = ViewpointAttachment_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ViewpointAttachment_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_GetFirstID = ViewpointAttachment_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ViewpointAttachment_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objViewpointAttachment = ViewpointAttachment_GetObjFromJsonObj(returnObj);
                return objViewpointAttachment;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_GetFirstObjAsync = ViewpointAttachment_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointAttachment_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN._CurrTabName, strid_CurrEduCls);
        clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrViewpointAttachmentExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrViewpointAttachmentObjLst_T = ViewpointAttachment_GetObjLstByJSONObjLst(arrViewpointAttachmentExObjLst_Cache);
            return arrViewpointAttachmentObjLst_T;
        }
        try {
            const arrViewpointAttachmentExObjLst = await ViewpointAttachment_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrViewpointAttachmentExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointAttachmentExObjLst.length);
            console.log(strInfo);
            return arrViewpointAttachmentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.viewpointAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ViewpointAttachment_GetObjLst_ClientCache = ViewpointAttachment_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointAttachment_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN._CurrTabName, strid_CurrEduCls);
        clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrViewpointAttachmentExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrViewpointAttachmentObjLst_T = ViewpointAttachment_GetObjLstByJSONObjLst(arrViewpointAttachmentExObjLst_Cache);
            return arrViewpointAttachmentObjLst_T;
        }
        try {
            const arrViewpointAttachmentExObjLst = await ViewpointAttachment_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrViewpointAttachmentExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointAttachmentExObjLst.length);
            console.log(strInfo);
            return arrViewpointAttachmentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.viewpointAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ViewpointAttachment_GetObjLst_localStorage = ViewpointAttachment_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrViewpointAttachmentObjLst_Cache = JSON.parse(strTempObjLst);
            return arrViewpointAttachmentObjLst_Cache;
        }
        else
            return null;
    }
    exports.ViewpointAttachment_GetObjLst_localStorage_PureCache = ViewpointAttachment_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ViewpointAttachment_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_GetObjLstAsync = ViewpointAttachment_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointAttachment_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN._CurrTabName, strid_CurrEduCls);
        clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrViewpointAttachmentExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrViewpointAttachmentObjLst_T = ViewpointAttachment_GetObjLstByJSONObjLst(arrViewpointAttachmentExObjLst_Cache);
            return arrViewpointAttachmentObjLst_T;
        }
        try {
            const arrViewpointAttachmentExObjLst = await ViewpointAttachment_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrViewpointAttachmentExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointAttachmentExObjLst.length);
            console.log(strInfo);
            return arrViewpointAttachmentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.viewpointAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ViewpointAttachment_GetObjLst_sessionStorage = ViewpointAttachment_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrViewpointAttachmentObjLst_Cache = JSON.parse(strTempObjLst);
            return arrViewpointAttachmentObjLst_Cache;
        }
        else
            return null;
    }
    exports.ViewpointAttachment_GetObjLst_sessionStorage_PureCache = ViewpointAttachment_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls) {
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
        let arrViewpointAttachmentObjLst_Cache;
        switch (clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.CacheModeId) {
            case "04": //sessionStorage
                arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrViewpointAttachmentObjLst = ViewpointAttachment_GetObjLstByJSONObjLst(arrViewpointAttachmentObjLst_Cache);
        return arrViewpointAttachmentObjLst_Cache;
    }
    exports.ViewpointAttachment_GetObjLst_Cache = ViewpointAttachment_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointAttachment_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrViewpointAttachmentObjLst_Cache;
        switch (clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.CacheModeId) {
            case "04": //sessionStorage
                arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrViewpointAttachmentObjLst_Cache = null;
                break;
            default:
                arrViewpointAttachmentObjLst_Cache = null;
                break;
        }
        return arrViewpointAttachmentObjLst_Cache;
    }
    exports.ViewpointAttachment_GetObjLst_PureCache = ViewpointAttachment_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngViewpointAttachmentId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ViewpointAttachment_GetSubObjLst_Cache(objViewpointAttachment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls);
        let arrViewpointAttachment_Sel = arrViewpointAttachmentObjLst_Cache;
        if (objViewpointAttachment_Cond.sf_FldComparisonOp == null || objViewpointAttachment_Cond.sf_FldComparisonOp == "")
            return arrViewpointAttachment_Sel;
        const dicFldComparisonOp = JSON.parse(objViewpointAttachment_Cond.sf_FldComparisonOp);
        //console.log("clsViewpointAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objViewpointAttachment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpointAttachment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrViewpointAttachment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objViewpointAttachment_Cond), exports.viewpointAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ViewpointAttachment_GetSubObjLst_Cache = ViewpointAttachment_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrViewpointAttachmentId:关键字列表
    * @returns 对象列表
    **/
    async function ViewpointAttachment_GetObjLstByViewpointAttachmentIdLstAsync(arrViewpointAttachmentId) {
        const strThisFuncName = "GetObjLstByViewpointAttachmentIdLstAsync";
        const strAction = "GetObjLstByViewpointAttachmentIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrViewpointAttachmentId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_GetObjLstByViewpointAttachmentIdLstAsync = ViewpointAttachment_GetObjLstByViewpointAttachmentIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngViewpointAttachmentIdLst:关键字列表
     * @returns 对象列表
    */
    async function ViewpointAttachment_GetObjLstByViewpointAttachmentIdLst_Cache(arrViewpointAttachmentIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByViewpointAttachmentIdLst_Cache";
        try {
            const arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls);
            const arrViewpointAttachment_Sel = arrViewpointAttachmentObjLst_Cache.filter(x => arrViewpointAttachmentIdLst.indexOf(x.viewpointAttachmentId) > -1);
            return arrViewpointAttachment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrViewpointAttachmentIdLst.join(","), exports.viewpointAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ViewpointAttachment_GetObjLstByViewpointAttachmentIdLst_Cache = ViewpointAttachment_GetObjLstByViewpointAttachmentIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ViewpointAttachment_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_GetTopObjLstAsync = ViewpointAttachment_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ViewpointAttachment_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_GetObjLstByRangeAsync = ViewpointAttachment_GetObjLstByRangeAsync;
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
    async function ViewpointAttachment_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_GetObjLstByRange = ViewpointAttachment_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function ViewpointAttachment_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrViewpointAttachmentObjLst_Cache.length == 0)
            return arrViewpointAttachmentObjLst_Cache;
        let arrViewpointAttachment_Sel = arrViewpointAttachmentObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objViewpointAttachment_Cond = new clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objViewpointAttachment_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsViewpointAttachmentWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpointAttachment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrViewpointAttachment_Sel.length == 0)
                return arrViewpointAttachment_Sel;
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
                arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.sort(ViewpointAttachment_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.sort(objPagerPara.sortFun);
            }
            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.slice(intStart, intEnd);
            return arrViewpointAttachment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.viewpointAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ViewpointAttachment_GetObjLstByPager_Cache = ViewpointAttachment_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ViewpointAttachment_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_GetObjLstByPagerAsync = ViewpointAttachment_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngViewpointAttachmentId:关键字
    * @returns 获取删除的结果
    **/
    async function ViewpointAttachment_DelRecordAsync(lngViewpointAttachmentId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngViewpointAttachmentId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngViewpointAttachmentId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_DelRecordAsync = ViewpointAttachment_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrViewpointAttachmentId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ViewpointAttachment_DelViewpointAttachmentsAsync(arrViewpointAttachmentId) {
        const strThisFuncName = "DelViewpointAttachmentsAsync";
        const strAction = "DelViewpointAttachments";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrViewpointAttachmentId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_DelViewpointAttachmentsAsync = ViewpointAttachment_DelViewpointAttachmentsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ViewpointAttachment_DelViewpointAttachmentsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelViewpointAttachmentsByCondAsync";
        const strAction = "DelViewpointAttachmentsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_DelViewpointAttachmentsByCondAsync = ViewpointAttachment_DelViewpointAttachmentsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objViewpointAttachmentEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ViewpointAttachment_AddNewRecordAsync(objViewpointAttachmentEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objViewpointAttachmentEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointAttachmentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_AddNewRecordAsync = ViewpointAttachment_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objViewpointAttachmentEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ViewpointAttachment_AddNewRecordWithReturnKeyAsync(objViewpointAttachmentEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointAttachmentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_AddNewRecordWithReturnKeyAsync = ViewpointAttachment_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objViewpointAttachmentEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ViewpointAttachment_AddNewRecordWithReturnKey(objViewpointAttachmentEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objViewpointAttachmentEN.viewpointAttachmentId === null || objViewpointAttachmentEN.viewpointAttachmentId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointAttachmentEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_AddNewRecordWithReturnKey = ViewpointAttachment_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objViewpointAttachmentEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ViewpointAttachment_UpdateRecordAsync(objViewpointAttachmentEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objViewpointAttachmentEN.sf_UpdFldSetStr === undefined || objViewpointAttachmentEN.sf_UpdFldSetStr === null || objViewpointAttachmentEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointAttachmentEN.viewpointAttachmentId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointAttachmentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_UpdateRecordAsync = ViewpointAttachment_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objViewpointAttachmentEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ViewpointAttachment_UpdateWithConditionAsync(objViewpointAttachmentEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objViewpointAttachmentEN.sf_UpdFldSetStr === undefined || objViewpointAttachmentEN.sf_UpdFldSetStr === null || objViewpointAttachmentEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointAttachmentEN.viewpointAttachmentId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
        objViewpointAttachmentEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objViewpointAttachmentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_UpdateWithConditionAsync = ViewpointAttachment_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngViewpointAttachmentId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ViewpointAttachment_IsExistRecord_Cache(objViewpointAttachment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrViewpointAttachmentObjLst_Cache == null)
            return false;
        let arrViewpointAttachment_Sel = arrViewpointAttachmentObjLst_Cache;
        if (objViewpointAttachment_Cond.sf_FldComparisonOp == null || objViewpointAttachment_Cond.sf_FldComparisonOp == "")
            return arrViewpointAttachment_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objViewpointAttachment_Cond.sf_FldComparisonOp);
        //console.log("clsViewpointAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objViewpointAttachment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpointAttachment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrViewpointAttachment_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objViewpointAttachment_Cond), exports.viewpointAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.ViewpointAttachment_IsExistRecord_Cache = ViewpointAttachment_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ViewpointAttachment_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_IsExistRecordAsync = ViewpointAttachment_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngViewpointAttachmentId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ViewpointAttachment_IsExist(lngViewpointAttachmentId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ViewpointAttachmentId": lngViewpointAttachmentId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_IsExist = ViewpointAttachment_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngViewpointAttachmentId:所给的关键字
     * @returns 对象
    */
    async function ViewpointAttachment_IsExist_Cache(lngViewpointAttachmentId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrViewpointAttachmentObjLst_Cache == null)
            return false;
        try {
            const arrViewpointAttachment_Sel = arrViewpointAttachmentObjLst_Cache.filter(x => x.viewpointAttachmentId == lngViewpointAttachmentId);
            if (arrViewpointAttachment_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngViewpointAttachmentId, exports.viewpointAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.ViewpointAttachment_IsExist_Cache = ViewpointAttachment_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngViewpointAttachmentId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ViewpointAttachment_IsExistAsync(lngViewpointAttachmentId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngViewpointAttachmentId": lngViewpointAttachmentId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_IsExistAsync = ViewpointAttachment_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ViewpointAttachment_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_GetRecCountByCondAsync = ViewpointAttachment_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objViewpointAttachment_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function ViewpointAttachment_GetRecCountByCond_Cache(objViewpointAttachment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrViewpointAttachmentObjLst_Cache == null)
            return 0;
        let arrViewpointAttachment_Sel = arrViewpointAttachmentObjLst_Cache;
        if (objViewpointAttachment_Cond.sf_FldComparisonOp == null || objViewpointAttachment_Cond.sf_FldComparisonOp == "")
            return arrViewpointAttachment_Sel.length;
        const dicFldComparisonOp = JSON.parse(objViewpointAttachment_Cond.sf_FldComparisonOp);
        //console.log("clsViewpointAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objViewpointAttachment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpointAttachment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrViewpointAttachment_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objViewpointAttachment_Cond), exports.viewpointAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.ViewpointAttachment_GetRecCountByCond_Cache = ViewpointAttachment_GetRecCountByCond_Cache;
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
    async function ViewpointAttachment_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointAttachment_GetMaxStrIdByPrefix = ViewpointAttachment_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ViewpointAttachment_GetWebApiUrl(strController, strAction) {
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
    exports.ViewpointAttachment_GetWebApiUrl = ViewpointAttachment_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function ViewpointAttachment_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsViewpointAttachmentWApi.ReFreshCache)");
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
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN._CurrTabName, strid_CurrEduCls);
        switch (clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.CacheModeId) {
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
    }
    exports.ViewpointAttachment_ReFreshCache = ViewpointAttachment_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function ViewpointAttachment_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN._CurrTabName, strid_CurrEduCls);
            switch (clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.CacheModeId) {
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
    exports.ViewpointAttachment_ReFreshThisCache = ViewpointAttachment_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ViewpointAttachment_CheckPropertyNew(pobjViewpointAttachmentEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.filePath) === true) {
            throw new Error("(errid:Watl000058)字段[文件路径]不能为空(In 观点附件表)!(clsViewpointAttachmentBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.viewpointAttachmentName) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointAttachmentEN.viewpointAttachmentName) > 200) {
            throw new Error("(errid:Watl000059)字段[附件名称(viewpointAttachmentName)]的长度不能超过200(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.viewpointAttachmentName)(clsViewpointAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.viewpointId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointAttachmentEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000059)字段[观点Id(viewpointId)]的长度不能超过8(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.viewpointId)(clsViewpointAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.filePath) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointAttachmentEN.filePath) > 500) {
            throw new Error("(errid:Watl000059)字段[文件路径(filePath)]的长度不能超过500(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.filePath)(clsViewpointAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointAttachmentEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.updUserId)(clsViewpointAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointAttachmentEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.updDate)(clsViewpointAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointAttachmentEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.memo)(clsViewpointAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointAttachmentEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.id_CurrEduCls)(clsViewpointAttachmentBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjViewpointAttachmentEN.viewpointAttachmentId && undefined !== pobjViewpointAttachmentEN.viewpointAttachmentId && jsString_js_1.tzDataType.isNumber(pobjViewpointAttachmentEN.viewpointAttachmentId) === false) {
            throw new Error("(errid:Watl000060)字段[主键Id(viewpointAttachmentId)]的值:[$(pobjViewpointAttachmentEN.viewpointAttachmentId)], 非法，应该为数值型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.viewpointAttachmentName) == false && undefined !== pobjViewpointAttachmentEN.viewpointAttachmentName && jsString_js_1.tzDataType.isString(pobjViewpointAttachmentEN.viewpointAttachmentName) === false) {
            throw new Error("(errid:Watl000060)字段[附件名称(viewpointAttachmentName)]的值:[$(pobjViewpointAttachmentEN.viewpointAttachmentName)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.viewpointId) == false && undefined !== pobjViewpointAttachmentEN.viewpointId && jsString_js_1.tzDataType.isString(pobjViewpointAttachmentEN.viewpointId) === false) {
            throw new Error("(errid:Watl000060)字段[观点Id(viewpointId)]的值:[$(pobjViewpointAttachmentEN.viewpointId)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.filePath) == false && undefined !== pobjViewpointAttachmentEN.filePath && jsString_js_1.tzDataType.isString(pobjViewpointAttachmentEN.filePath) === false) {
            throw new Error("(errid:Watl000060)字段[文件路径(filePath)]的值:[$(pobjViewpointAttachmentEN.filePath)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.updUserId) == false && undefined !== pobjViewpointAttachmentEN.updUserId && jsString_js_1.tzDataType.isString(pobjViewpointAttachmentEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjViewpointAttachmentEN.updUserId)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.updDate) == false && undefined !== pobjViewpointAttachmentEN.updDate && jsString_js_1.tzDataType.isString(pobjViewpointAttachmentEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjViewpointAttachmentEN.updDate)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.memo) == false && undefined !== pobjViewpointAttachmentEN.memo && jsString_js_1.tzDataType.isString(pobjViewpointAttachmentEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjViewpointAttachmentEN.memo)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.id_CurrEduCls) == false && undefined !== pobjViewpointAttachmentEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjViewpointAttachmentEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjViewpointAttachmentEN.id_CurrEduCls)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjViewpointAttachmentEN.SetIsCheckProperty(true);
    }
    exports.ViewpointAttachment_CheckPropertyNew = ViewpointAttachment_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ViewpointAttachment_CheckProperty4Update(pobjViewpointAttachmentEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.viewpointAttachmentName) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointAttachmentEN.viewpointAttachmentName) > 200) {
            throw new Error("(errid:Watl000062)字段[附件名称(viewpointAttachmentName)]的长度不能超过200(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.viewpointAttachmentName)(clsViewpointAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.viewpointId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointAttachmentEN.viewpointId) > 8) {
            throw new Error("(errid:Watl000062)字段[观点Id(viewpointId)]的长度不能超过8(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.viewpointId)(clsViewpointAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.filePath) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointAttachmentEN.filePath) > 500) {
            throw new Error("(errid:Watl000062)字段[文件路径(filePath)]的长度不能超过500(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.filePath)(clsViewpointAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointAttachmentEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.updUserId)(clsViewpointAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointAttachmentEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.updDate)(clsViewpointAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointAttachmentEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.memo)(clsViewpointAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjViewpointAttachmentEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.id_CurrEduCls)(clsViewpointAttachmentBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjViewpointAttachmentEN.viewpointAttachmentId && undefined !== pobjViewpointAttachmentEN.viewpointAttachmentId && jsString_js_1.tzDataType.isNumber(pobjViewpointAttachmentEN.viewpointAttachmentId) === false) {
            throw new Error("(errid:Watl000063)字段[主键Id(viewpointAttachmentId)]的值:[$(pobjViewpointAttachmentEN.viewpointAttachmentId)], 非法，应该为数值型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.viewpointAttachmentName) == false && undefined !== pobjViewpointAttachmentEN.viewpointAttachmentName && jsString_js_1.tzDataType.isString(pobjViewpointAttachmentEN.viewpointAttachmentName) === false) {
            throw new Error("(errid:Watl000063)字段[附件名称(viewpointAttachmentName)]的值:[$(pobjViewpointAttachmentEN.viewpointAttachmentName)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.viewpointId) == false && undefined !== pobjViewpointAttachmentEN.viewpointId && jsString_js_1.tzDataType.isString(pobjViewpointAttachmentEN.viewpointId) === false) {
            throw new Error("(errid:Watl000063)字段[观点Id(viewpointId)]的值:[$(pobjViewpointAttachmentEN.viewpointId)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.filePath) == false && undefined !== pobjViewpointAttachmentEN.filePath && jsString_js_1.tzDataType.isString(pobjViewpointAttachmentEN.filePath) === false) {
            throw new Error("(errid:Watl000063)字段[文件路径(filePath)]的值:[$(pobjViewpointAttachmentEN.filePath)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.updUserId) == false && undefined !== pobjViewpointAttachmentEN.updUserId && jsString_js_1.tzDataType.isString(pobjViewpointAttachmentEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjViewpointAttachmentEN.updUserId)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.updDate) == false && undefined !== pobjViewpointAttachmentEN.updDate && jsString_js_1.tzDataType.isString(pobjViewpointAttachmentEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjViewpointAttachmentEN.updDate)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.memo) == false && undefined !== pobjViewpointAttachmentEN.memo && jsString_js_1.tzDataType.isString(pobjViewpointAttachmentEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjViewpointAttachmentEN.memo)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjViewpointAttachmentEN.id_CurrEduCls) == false && undefined !== pobjViewpointAttachmentEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjViewpointAttachmentEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjViewpointAttachmentEN.id_CurrEduCls)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjViewpointAttachmentEN.viewpointAttachmentId
            || pobjViewpointAttachmentEN.viewpointAttachmentId != null && pobjViewpointAttachmentEN.viewpointAttachmentId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[主键Id]不能为空(In 观点附件表)!(clsViewpointAttachmentBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjViewpointAttachmentEN.SetIsCheckProperty(true);
    }
    exports.ViewpointAttachment_CheckProperty4Update = ViewpointAttachment_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ViewpointAttachment_GetJSONStrByObj(pobjViewpointAttachmentEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjViewpointAttachmentEN.sf_UpdFldSetStr = pobjViewpointAttachmentEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjViewpointAttachmentEN);
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
    exports.ViewpointAttachment_GetJSONStrByObj = ViewpointAttachment_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ViewpointAttachment_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrViewpointAttachmentObjLst = new Array();
        if (strJSON === "") {
            return arrViewpointAttachmentObjLst;
        }
        try {
            arrViewpointAttachmentObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrViewpointAttachmentObjLst;
        }
        return arrViewpointAttachmentObjLst;
    }
    exports.ViewpointAttachment_GetObjLstByJSONStr = ViewpointAttachment_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrViewpointAttachmentObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ViewpointAttachment_GetObjLstByJSONObjLst(arrViewpointAttachmentObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrViewpointAttachmentObjLst = new Array();
        for (const objInFor of arrViewpointAttachmentObjLstS) {
            const obj1 = ViewpointAttachment_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrViewpointAttachmentObjLst.push(obj1);
        }
        return arrViewpointAttachmentObjLst;
    }
    exports.ViewpointAttachment_GetObjLstByJSONObjLst = ViewpointAttachment_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ViewpointAttachment_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjViewpointAttachmentEN = new clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN();
        if (strJSON === "") {
            return pobjViewpointAttachmentEN;
        }
        try {
            pobjViewpointAttachmentEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjViewpointAttachmentEN;
        }
        return pobjViewpointAttachmentEN;
    }
    exports.ViewpointAttachment_GetObjByJSONStr = ViewpointAttachment_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ViewpointAttachment_GetCombineCondition(objViewpointAttachment_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objViewpointAttachment_Cond.dicFldComparisonOp, clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointAttachmentId) == true) {
            const strComparisonOp_ViewpointAttachmentId = objViewpointAttachment_Cond.dicFldComparisonOp[clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointAttachmentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointAttachmentId, objViewpointAttachment_Cond.viewpointAttachmentId, strComparisonOp_ViewpointAttachmentId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointAttachment_Cond.dicFldComparisonOp, clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointAttachmentName) == true) {
            const strComparisonOp_ViewpointAttachmentName = objViewpointAttachment_Cond.dicFldComparisonOp[clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointAttachmentName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointAttachmentName, objViewpointAttachment_Cond.viewpointAttachmentName, strComparisonOp_ViewpointAttachmentName);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointAttachment_Cond.dicFldComparisonOp, clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointId) == true) {
            const strComparisonOp_ViewpointId = objViewpointAttachment_Cond.dicFldComparisonOp[clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_ViewpointId, objViewpointAttachment_Cond.viewpointId, strComparisonOp_ViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointAttachment_Cond.dicFldComparisonOp, clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_FilePath) == true) {
            const strComparisonOp_FilePath = objViewpointAttachment_Cond.dicFldComparisonOp[clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_FilePath];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_FilePath, objViewpointAttachment_Cond.filePath, strComparisonOp_FilePath);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointAttachment_Cond.dicFldComparisonOp, clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objViewpointAttachment_Cond.dicFldComparisonOp[clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_UpdUserId, objViewpointAttachment_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointAttachment_Cond.dicFldComparisonOp, clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objViewpointAttachment_Cond.dicFldComparisonOp[clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_UpdDate, objViewpointAttachment_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointAttachment_Cond.dicFldComparisonOp, clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_Memo) == true) {
            const strComparisonOp_Memo = objViewpointAttachment_Cond.dicFldComparisonOp[clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_Memo, objViewpointAttachment_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointAttachment_Cond.dicFldComparisonOp, clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objViewpointAttachment_Cond.dicFldComparisonOp[clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN.con_id_CurrEduCls, objViewpointAttachment_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.ViewpointAttachment_GetCombineCondition = ViewpointAttachment_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--ViewpointAttachment(观点附件表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngViewpointAttachmentId: 主键Id(要求唯一的字段)
    * @param strViewpointAttachmentName: 附件名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ViewpointAttachment_GetUniCondStr_ViewpointAttachmentId_ViewpointAttachmentName(objViewpointAttachmentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointAttachmentId = '{0}'", objViewpointAttachmentEN.viewpointAttachmentId);
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointAttachmentName = '{0}'", objViewpointAttachmentEN.viewpointAttachmentName);
        return strWhereCond;
    }
    exports.ViewpointAttachment_GetUniCondStr_ViewpointAttachmentId_ViewpointAttachmentName = ViewpointAttachment_GetUniCondStr_ViewpointAttachmentId_ViewpointAttachmentName;
    /**
    *获取唯一性条件串(Uniqueness)--ViewpointAttachment(观点附件表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngViewpointAttachmentId: 主键Id(要求唯一的字段)
    * @param strViewpointAttachmentName: 附件名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ViewpointAttachment_GetUniCondStr4Update_ViewpointAttachmentId_ViewpointAttachmentName(objViewpointAttachmentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointAttachmentId <> '{0}'", objViewpointAttachmentEN.viewpointAttachmentId);
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointAttachmentId = '{0}'", objViewpointAttachmentEN.viewpointAttachmentId);
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointAttachmentName = '{0}'", objViewpointAttachmentEN.viewpointAttachmentName);
        return strWhereCond;
    }
    exports.ViewpointAttachment_GetUniCondStr4Update_ViewpointAttachmentId_ViewpointAttachmentName = ViewpointAttachment_GetUniCondStr4Update_ViewpointAttachmentId_ViewpointAttachmentName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objViewpointAttachmentENS:源对象
     * @param objViewpointAttachmentENT:目标对象
    */
    function ViewpointAttachment_CopyObjTo(objViewpointAttachmentENS, objViewpointAttachmentENT) {
        objViewpointAttachmentENT.viewpointAttachmentId = objViewpointAttachmentENS.viewpointAttachmentId; //主键Id
        objViewpointAttachmentENT.viewpointAttachmentName = objViewpointAttachmentENS.viewpointAttachmentName; //附件名称
        objViewpointAttachmentENT.viewpointId = objViewpointAttachmentENS.viewpointId; //观点Id
        objViewpointAttachmentENT.filePath = objViewpointAttachmentENS.filePath; //文件路径
        objViewpointAttachmentENT.updUserId = objViewpointAttachmentENS.updUserId; //修改用户Id
        objViewpointAttachmentENT.updDate = objViewpointAttachmentENS.updDate; //修改日期
        objViewpointAttachmentENT.memo = objViewpointAttachmentENS.memo; //备注
        objViewpointAttachmentENT.id_CurrEduCls = objViewpointAttachmentENS.id_CurrEduCls; //教学班流水号
        objViewpointAttachmentENT.sf_UpdFldSetStr = objViewpointAttachmentENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ViewpointAttachment_CopyObjTo = ViewpointAttachment_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objViewpointAttachmentENS:源对象
     * @param objViewpointAttachmentENT:目标对象
    */
    function ViewpointAttachment_GetObjFromJsonObj(objViewpointAttachmentENS) {
        const objViewpointAttachmentENT = new clsViewpointAttachmentEN_js_1.clsViewpointAttachmentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objViewpointAttachmentENT, objViewpointAttachmentENS);
        return objViewpointAttachmentENT;
    }
    exports.ViewpointAttachment_GetObjFromJsonObj = ViewpointAttachment_GetObjFromJsonObj;
});
