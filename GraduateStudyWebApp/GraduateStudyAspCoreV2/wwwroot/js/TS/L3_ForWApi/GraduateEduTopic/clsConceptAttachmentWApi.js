/**
* 类名:clsConceptAttachmentWApi
* 表名:ConceptAttachment(01120603)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:51:29
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsConceptAttachmentEN.js", "../../L3_ForWApi/GraduateEduTopic/clsvConceptAttachmentWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ConceptAttachment_GetObjFromJsonObj = exports.ConceptAttachment_CopyObjTo = exports.ConceptAttachment_GetUniCondStr4Update_ConceptAttachmentId_ConceptId = exports.ConceptAttachment_GetUniCondStr_ConceptAttachmentId_ConceptId = exports.ConceptAttachment_GetCombineCondition = exports.ConceptAttachment_GetObjByJSONStr = exports.ConceptAttachment_GetObjLstByJSONObjLst = exports.ConceptAttachment_GetObjLstByJSONStr = exports.ConceptAttachment_GetJSONStrByObj = exports.ConceptAttachment_CheckProperty4Update = exports.ConceptAttachment_CheckPropertyNew = exports.ConceptAttachment_ReFreshThisCache = exports.ConceptAttachment_ReFreshCache = exports.ConceptAttachment_GetWebApiUrl = exports.ConceptAttachment_GetMaxStrIdByPrefix = exports.ConceptAttachment_GetRecCountByCond_Cache = exports.ConceptAttachment_GetRecCountByCondAsync = exports.ConceptAttachment_IsExistAsync = exports.ConceptAttachment_IsExist_Cache = exports.ConceptAttachment_IsExist = exports.ConceptAttachment_IsExistRecordAsync = exports.ConceptAttachment_IsExistRecord_Cache = exports.ConceptAttachment_UpdateWithConditionAsync = exports.ConceptAttachment_UpdateRecordAsync = exports.ConceptAttachment_AddNewRecordWithReturnKey = exports.ConceptAttachment_AddNewRecordWithReturnKeyAsync = exports.ConceptAttachment_AddNewRecordAsync = exports.ConceptAttachment_DelConceptAttachmentsByCondAsync = exports.ConceptAttachment_DelConceptAttachmentsAsync = exports.ConceptAttachment_DelRecordAsync = exports.ConceptAttachment_GetObjLstByPagerAsync = exports.ConceptAttachment_GetObjLstByPager_Cache = exports.ConceptAttachment_GetObjLstByRange = exports.ConceptAttachment_GetObjLstByRangeAsync = exports.ConceptAttachment_GetTopObjLstAsync = exports.ConceptAttachment_GetObjLstByConceptAttachmentIdLst_Cache = exports.ConceptAttachment_GetObjLstByConceptAttachmentIdLstAsync = exports.ConceptAttachment_GetSubObjLst_Cache = exports.ConceptAttachment_GetObjLst_PureCache = exports.ConceptAttachment_GetObjLst_Cache = exports.ConceptAttachment_GetObjLst_sessionStorage_PureCache = exports.ConceptAttachment_GetObjLst_sessionStorage = exports.ConceptAttachment_GetObjLstAsync = exports.ConceptAttachment_GetObjLst_localStorage_PureCache = exports.ConceptAttachment_GetObjLst_localStorage = exports.ConceptAttachment_GetObjLst_ClientCache = exports.ConceptAttachment_GetFirstObjAsync = exports.ConceptAttachment_GetFirstID = exports.ConceptAttachment_GetFirstIDAsync = exports.ConceptAttachment_funcKey = exports.ConceptAttachment_FilterFunByKey = exports.ConceptAttachment_SortFunByKey = exports.ConceptAttachment_SortFun_Defa_2Fld = exports.ConceptAttachment_SortFun_Defa = exports.ConceptAttachment_func = exports.ConceptAttachment_UpdateObjInLst_Cache = exports.ConceptAttachment_GetObjByConceptAttachmentId_localStorage = exports.ConceptAttachment_GetObjByConceptAttachmentId_Cache = exports.ConceptAttachment_GetObjByConceptAttachmentIdAsync = exports.conceptAttachment_ConstructorName = exports.conceptAttachment_Controller = void 0;
    /**
     * 概念附件(ConceptAttachment)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsConceptAttachmentEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsConceptAttachmentEN.js");
    const clsvConceptAttachmentWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsvConceptAttachmentWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.conceptAttachment_Controller = "ConceptAttachmentApi";
    exports.conceptAttachment_ConstructorName = "conceptAttachment";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngConceptAttachmentId:关键字
    * @returns 对象
    **/
    async function ConceptAttachment_GetObjByConceptAttachmentIdAsync(lngConceptAttachmentId) {
        const strThisFuncName = "GetObjByConceptAttachmentIdAsync";
        if (lngConceptAttachmentId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngConceptAttachmentId]不能为空！(In clsConceptAttachmentWApi.GetObjByConceptAttachmentIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByConceptAttachmentId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngConceptAttachmentId": lngConceptAttachmentId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objConceptAttachment = ConceptAttachment_GetObjFromJsonObj(returnObj);
                return objConceptAttachment;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_GetObjByConceptAttachmentIdAsync = ConceptAttachment_GetObjByConceptAttachmentIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngConceptAttachmentId:所给的关键字
     * @returns 对象
    */
    async function ConceptAttachment_GetObjByConceptAttachmentId_Cache(lngConceptAttachmentId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByConceptAttachmentId_Cache";
        if (lngConceptAttachmentId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngConceptAttachmentId]不能为空！(In clsConceptAttachmentWApi.GetObjByConceptAttachmentId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrConceptAttachment_Sel = arrConceptAttachmentObjLst_Cache.filter(x => x.conceptAttachmentId == lngConceptAttachmentId);
            let objConceptAttachment;
            if (arrConceptAttachment_Sel.length > 0) {
                objConceptAttachment = arrConceptAttachment_Sel[0];
                return objConceptAttachment;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objConceptAttachment_Const = await ConceptAttachment_GetObjByConceptAttachmentIdAsync(lngConceptAttachmentId);
                    if (objConceptAttachment_Const != null) {
                        ConceptAttachment_ReFreshThisCache(strid_CurrEduCls);
                        return objConceptAttachment_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngConceptAttachmentId, exports.conceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.ConceptAttachment_GetObjByConceptAttachmentId_Cache = ConceptAttachment_GetObjByConceptAttachmentId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngConceptAttachmentId:所给的关键字
     * @returns 对象
    */
    async function ConceptAttachment_GetObjByConceptAttachmentId_localStorage(lngConceptAttachmentId) {
        const strThisFuncName = "GetObjByConceptAttachmentId_localStorage";
        if (lngConceptAttachmentId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngConceptAttachmentId]不能为空！(In clsConceptAttachmentWApi.GetObjByConceptAttachmentId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN._CurrTabName, lngConceptAttachmentId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objConceptAttachment_Cache = JSON.parse(strTempObj);
            return objConceptAttachment_Cache;
        }
        try {
            const objConceptAttachment = await ConceptAttachment_GetObjByConceptAttachmentIdAsync(lngConceptAttachmentId);
            if (objConceptAttachment != null) {
                localStorage.setItem(strKey, JSON.stringify(objConceptAttachment));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objConceptAttachment;
            }
            return objConceptAttachment;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngConceptAttachmentId, exports.conceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.ConceptAttachment_GetObjByConceptAttachmentId_localStorage = ConceptAttachment_GetObjByConceptAttachmentId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objConceptAttachment:所给的对象
     * @returns 对象
    */
    async function ConceptAttachment_UpdateObjInLst_Cache(objConceptAttachment, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrConceptAttachmentObjLst_Cache.find(x => x.conceptAttachmentId == objConceptAttachment.conceptAttachmentId && x.conceptId == objConceptAttachment.conceptId);
            if (obj != null) {
                objConceptAttachment.conceptAttachmentId = obj.conceptAttachmentId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objConceptAttachment);
            }
            else {
                arrConceptAttachmentObjLst_Cache.push(objConceptAttachment);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.conceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.ConceptAttachment_UpdateObjInLst_Cache = ConceptAttachment_UpdateObjInLst_Cache;
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
    async function ConceptAttachment_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsConceptAttachmentWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsConceptAttachmentWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptAttachmentId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngConceptAttachmentId = Number(strInValue);
        if (lngConceptAttachmentId == 0) {
            return "";
        }
        const objConceptAttachment = await ConceptAttachment_GetObjByConceptAttachmentId_Cache(lngConceptAttachmentId, strid_CurrEduCls_C);
        if (objConceptAttachment == null)
            return "";
        if (objConceptAttachment.GetFldValue(strOutFldName) == null)
            return "";
        return objConceptAttachment.GetFldValue(strOutFldName).toString();
    }
    exports.ConceptAttachment_func = ConceptAttachment_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ConceptAttachment_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.conceptAttachmentId - b.conceptAttachmentId;
    }
    exports.ConceptAttachment_SortFun_Defa = ConceptAttachment_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ConceptAttachment_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.conceptAttachmentName == b.conceptAttachmentName)
            return a.conceptId.localeCompare(b.conceptId);
        else
            return a.conceptAttachmentName.localeCompare(b.conceptAttachmentName);
    }
    exports.ConceptAttachment_SortFun_Defa_2Fld = ConceptAttachment_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ConceptAttachment_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptAttachmentId:
                    return (a, b) => {
                        return a.conceptAttachmentId - b.conceptAttachmentId;
                    };
                case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptAttachmentName:
                    return (a, b) => {
                        if (a.conceptAttachmentName == null)
                            return -1;
                        if (b.conceptAttachmentName == null)
                            return 1;
                        return a.conceptAttachmentName.localeCompare(b.conceptAttachmentName);
                    };
                case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptId:
                    return (a, b) => {
                        return a.conceptId.localeCompare(b.conceptId);
                    };
                case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_FilePath:
                    return (a, b) => {
                        return a.filePath.localeCompare(b.filePath);
                    };
                case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_UpdUserId:
                    return (a, b) => {
                        if (a.updUserId == null)
                            return -1;
                        if (b.updUserId == null)
                            return 1;
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ConceptAttachment]中不存在！(in ${exports.conceptAttachment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptAttachmentId:
                    return (a, b) => {
                        return b.conceptAttachmentId - a.conceptAttachmentId;
                    };
                case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptAttachmentName:
                    return (a, b) => {
                        if (b.conceptAttachmentName == null)
                            return -1;
                        if (a.conceptAttachmentName == null)
                            return 1;
                        return b.conceptAttachmentName.localeCompare(a.conceptAttachmentName);
                    };
                case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptId:
                    return (a, b) => {
                        return b.conceptId.localeCompare(a.conceptId);
                    };
                case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_FilePath:
                    return (a, b) => {
                        return b.filePath.localeCompare(a.filePath);
                    };
                case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_UpdUserId:
                    return (a, b) => {
                        if (b.updUserId == null)
                            return -1;
                        if (a.updUserId == null)
                            return 1;
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ConceptAttachment]中不存在！(in ${exports.conceptAttachment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ConceptAttachment_SortFunByKey = ConceptAttachment_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ConceptAttachment_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptAttachmentId:
                return (obj) => {
                    return obj.conceptAttachmentId === value;
                };
            case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptAttachmentName:
                return (obj) => {
                    return obj.conceptAttachmentName === value;
                };
            case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptId:
                return (obj) => {
                    return obj.conceptId === value;
                };
            case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_FilePath:
                return (obj) => {
                    return obj.filePath === value;
                };
            case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ConceptAttachment]中不存在！(in ${exports.conceptAttachment_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ConceptAttachment_FilterFunByKey = ConceptAttachment_FilterFunByKey;
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
    async function ConceptAttachment_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsConceptAttachmentWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsConceptAttachmentWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptAttachmentId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrConceptAttachment = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrConceptAttachment == null)
            return [];
        let arrConceptAttachment_Sel = arrConceptAttachment;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrConceptAttachment_Sel.length == 0)
            return [];
        return arrConceptAttachment_Sel.map(x => x.conceptAttachmentId);
    }
    exports.ConceptAttachment_funcKey = ConceptAttachment_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ConceptAttachment_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_GetFirstIDAsync = ConceptAttachment_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ConceptAttachment_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_GetFirstID = ConceptAttachment_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ConceptAttachment_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
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
                const objConceptAttachment = ConceptAttachment_GetObjFromJsonObj(returnObj);
                return objConceptAttachment;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_GetFirstObjAsync = ConceptAttachment_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ConceptAttachment_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrConceptAttachmentExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrConceptAttachmentObjLst_T = ConceptAttachment_GetObjLstByJSONObjLst(arrConceptAttachmentExObjLst_Cache);
            return arrConceptAttachmentObjLst_T;
        }
        try {
            const arrConceptAttachmentExObjLst = await ConceptAttachment_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrConceptAttachmentExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrConceptAttachmentExObjLst.length);
            console.log(strInfo);
            return arrConceptAttachmentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.conceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ConceptAttachment_GetObjLst_ClientCache = ConceptAttachment_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ConceptAttachment_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrConceptAttachmentExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrConceptAttachmentObjLst_T = ConceptAttachment_GetObjLstByJSONObjLst(arrConceptAttachmentExObjLst_Cache);
            return arrConceptAttachmentObjLst_T;
        }
        try {
            const arrConceptAttachmentExObjLst = await ConceptAttachment_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrConceptAttachmentExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrConceptAttachmentExObjLst.length);
            console.log(strInfo);
            return arrConceptAttachmentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.conceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ConceptAttachment_GetObjLst_localStorage = ConceptAttachment_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ConceptAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrConceptAttachmentObjLst_Cache = JSON.parse(strTempObjLst);
            return arrConceptAttachmentObjLst_Cache;
        }
        else
            return null;
    }
    exports.ConceptAttachment_GetObjLst_localStorage_PureCache = ConceptAttachment_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ConceptAttachment_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_GetObjLstAsync = ConceptAttachment_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ConceptAttachment_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrConceptAttachmentExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrConceptAttachmentObjLst_T = ConceptAttachment_GetObjLstByJSONObjLst(arrConceptAttachmentExObjLst_Cache);
            return arrConceptAttachmentObjLst_T;
        }
        try {
            const arrConceptAttachmentExObjLst = await ConceptAttachment_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrConceptAttachmentExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrConceptAttachmentExObjLst.length);
            console.log(strInfo);
            return arrConceptAttachmentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.conceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ConceptAttachment_GetObjLst_sessionStorage = ConceptAttachment_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ConceptAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrConceptAttachmentObjLst_Cache = JSON.parse(strTempObjLst);
            return arrConceptAttachmentObjLst_Cache;
        }
        else
            return null;
    }
    exports.ConceptAttachment_GetObjLst_sessionStorage_PureCache = ConceptAttachment_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsConceptAttachmentWApi.ConceptAttachment_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsConceptAttachmentWApi.ConceptAttachment_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrConceptAttachmentObjLst_Cache;
        switch (clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.CacheModeId) {
            case "04": //sessionStorage
                arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrConceptAttachmentObjLst = ConceptAttachment_GetObjLstByJSONObjLst(arrConceptAttachmentObjLst_Cache);
        return arrConceptAttachmentObjLst_Cache;
    }
    exports.ConceptAttachment_GetObjLst_Cache = ConceptAttachment_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ConceptAttachment_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrConceptAttachmentObjLst_Cache;
        switch (clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.CacheModeId) {
            case "04": //sessionStorage
                arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrConceptAttachmentObjLst_Cache = null;
                break;
            default:
                arrConceptAttachmentObjLst_Cache = null;
                break;
        }
        return arrConceptAttachmentObjLst_Cache;
    }
    exports.ConceptAttachment_GetObjLst_PureCache = ConceptAttachment_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngConceptAttachmentId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ConceptAttachment_GetSubObjLst_Cache(objConceptAttachment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
        let arrConceptAttachment_Sel = arrConceptAttachmentObjLst_Cache;
        if (objConceptAttachment_Cond.sf_FldComparisonOp == null || objConceptAttachment_Cond.sf_FldComparisonOp == "")
            return arrConceptAttachment_Sel;
        const dicFldComparisonOp = JSON.parse(objConceptAttachment_Cond.sf_FldComparisonOp);
        //console.log("clsConceptAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objConceptAttachment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objConceptAttachment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrConceptAttachment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objConceptAttachment_Cond), exports.conceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ConceptAttachment_GetSubObjLst_Cache = ConceptAttachment_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrConceptAttachmentId:关键字列表
    * @returns 对象列表
    **/
    async function ConceptAttachment_GetObjLstByConceptAttachmentIdLstAsync(arrConceptAttachmentId) {
        const strThisFuncName = "GetObjLstByConceptAttachmentIdLstAsync";
        const strAction = "GetObjLstByConceptAttachmentIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrConceptAttachmentId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_GetObjLstByConceptAttachmentIdLstAsync = ConceptAttachment_GetObjLstByConceptAttachmentIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngConceptAttachmentIdLst:关键字列表
     * @returns 对象列表
    */
    async function ConceptAttachment_GetObjLstByConceptAttachmentIdLst_Cache(arrConceptAttachmentIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByConceptAttachmentIdLst_Cache";
        try {
            const arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
            const arrConceptAttachment_Sel = arrConceptAttachmentObjLst_Cache.filter(x => arrConceptAttachmentIdLst.indexOf(x.conceptAttachmentId) > -1);
            return arrConceptAttachment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrConceptAttachmentIdLst.join(","), exports.conceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.ConceptAttachment_GetObjLstByConceptAttachmentIdLst_Cache = ConceptAttachment_GetObjLstByConceptAttachmentIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ConceptAttachment_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_GetTopObjLstAsync = ConceptAttachment_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ConceptAttachment_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_GetObjLstByRangeAsync = ConceptAttachment_GetObjLstByRangeAsync;
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
    async function ConceptAttachment_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_GetObjLstByRange = ConceptAttachment_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function ConceptAttachment_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrConceptAttachmentObjLst_Cache.length == 0)
            return arrConceptAttachmentObjLst_Cache;
        let arrConceptAttachment_Sel = arrConceptAttachmentObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objConceptAttachment_Cond = new clsConceptAttachmentEN_js_1.clsConceptAttachmentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objConceptAttachment_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsConceptAttachmentWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objConceptAttachment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrConceptAttachment_Sel.length == 0)
                return arrConceptAttachment_Sel;
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
                arrConceptAttachment_Sel = arrConceptAttachment_Sel.sort(ConceptAttachment_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrConceptAttachment_Sel = arrConceptAttachment_Sel.sort(objPagerPara.sortFun);
            }
            arrConceptAttachment_Sel = arrConceptAttachment_Sel.slice(intStart, intEnd);
            return arrConceptAttachment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.conceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ConceptAttachment_GetObjLstByPager_Cache = ConceptAttachment_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ConceptAttachment_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.conceptAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ConceptAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_GetObjLstByPagerAsync = ConceptAttachment_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngConceptAttachmentId:关键字
    * @returns 获取删除的结果
    **/
    async function ConceptAttachment_DelRecordAsync(lngConceptAttachmentId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngConceptAttachmentId);
        try {
            const response = await axios_1.default.delete(strUrl);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_DelRecordAsync = ConceptAttachment_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrConceptAttachmentId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ConceptAttachment_DelConceptAttachmentsAsync(arrConceptAttachmentId) {
        const strThisFuncName = "DelConceptAttachmentsAsync";
        const strAction = "DelConceptAttachments";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrConceptAttachmentId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_DelConceptAttachmentsAsync = ConceptAttachment_DelConceptAttachmentsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ConceptAttachment_DelConceptAttachmentsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelConceptAttachmentsByCondAsync";
        const strAction = "DelConceptAttachmentsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_DelConceptAttachmentsByCondAsync = ConceptAttachment_DelConceptAttachmentsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objConceptAttachmentEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ConceptAttachment_AddNewRecordAsync(objConceptAttachmentEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objConceptAttachmentEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objConceptAttachmentEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_AddNewRecordAsync = ConceptAttachment_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objConceptAttachmentEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ConceptAttachment_AddNewRecordWithReturnKeyAsync(objConceptAttachmentEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objConceptAttachmentEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_AddNewRecordWithReturnKeyAsync = ConceptAttachment_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objConceptAttachmentEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ConceptAttachment_AddNewRecordWithReturnKey(objConceptAttachmentEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objConceptAttachmentEN.conceptAttachmentId === null || objConceptAttachmentEN.conceptAttachmentId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objConceptAttachmentEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_AddNewRecordWithReturnKey = ConceptAttachment_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objConceptAttachmentEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ConceptAttachment_UpdateRecordAsync(objConceptAttachmentEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objConceptAttachmentEN.sf_UpdFldSetStr === undefined || objConceptAttachmentEN.sf_UpdFldSetStr === null || objConceptAttachmentEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objConceptAttachmentEN.conceptAttachmentId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objConceptAttachmentEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_UpdateRecordAsync = ConceptAttachment_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objConceptAttachmentEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ConceptAttachment_UpdateWithConditionAsync(objConceptAttachmentEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objConceptAttachmentEN.sf_UpdFldSetStr === undefined || objConceptAttachmentEN.sf_UpdFldSetStr === null || objConceptAttachmentEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objConceptAttachmentEN.conceptAttachmentId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
        objConceptAttachmentEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objConceptAttachmentEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_UpdateWithConditionAsync = ConceptAttachment_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngConceptAttachmentId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ConceptAttachment_IsExistRecord_Cache(objConceptAttachment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrConceptAttachmentObjLst_Cache == null)
            return false;
        let arrConceptAttachment_Sel = arrConceptAttachmentObjLst_Cache;
        if (objConceptAttachment_Cond.sf_FldComparisonOp == null || objConceptAttachment_Cond.sf_FldComparisonOp == "")
            return arrConceptAttachment_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objConceptAttachment_Cond.sf_FldComparisonOp);
        //console.log("clsConceptAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objConceptAttachment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objConceptAttachment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrConceptAttachment_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objConceptAttachment_Cond), exports.conceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.ConceptAttachment_IsExistRecord_Cache = ConceptAttachment_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ConceptAttachment_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_IsExistRecordAsync = ConceptAttachment_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngConceptAttachmentId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ConceptAttachment_IsExist(lngConceptAttachmentId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ConceptAttachmentId": lngConceptAttachmentId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_IsExist = ConceptAttachment_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngConceptAttachmentId:所给的关键字
     * @returns 对象
    */
    async function ConceptAttachment_IsExist_Cache(lngConceptAttachmentId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrConceptAttachmentObjLst_Cache == null)
            return false;
        try {
            const arrConceptAttachment_Sel = arrConceptAttachmentObjLst_Cache.filter(x => x.conceptAttachmentId == lngConceptAttachmentId);
            if (arrConceptAttachment_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngConceptAttachmentId, exports.conceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.ConceptAttachment_IsExist_Cache = ConceptAttachment_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngConceptAttachmentId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ConceptAttachment_IsExistAsync(lngConceptAttachmentId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngConceptAttachmentId": lngConceptAttachmentId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_IsExistAsync = ConceptAttachment_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ConceptAttachment_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_GetRecCountByCondAsync = ConceptAttachment_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objConceptAttachment_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function ConceptAttachment_GetRecCountByCond_Cache(objConceptAttachment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrConceptAttachmentObjLst_Cache = await ConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrConceptAttachmentObjLst_Cache == null)
            return 0;
        let arrConceptAttachment_Sel = arrConceptAttachmentObjLst_Cache;
        if (objConceptAttachment_Cond.sf_FldComparisonOp == null || objConceptAttachment_Cond.sf_FldComparisonOp == "")
            return arrConceptAttachment_Sel.length;
        const dicFldComparisonOp = JSON.parse(objConceptAttachment_Cond.sf_FldComparisonOp);
        //console.log("clsConceptAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objConceptAttachment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objConceptAttachment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrConceptAttachment_Sel = arrConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrConceptAttachment_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objConceptAttachment_Cond), exports.conceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.ConceptAttachment_GetRecCountByCond_Cache = ConceptAttachment_GetRecCountByCond_Cache;
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
    async function ConceptAttachment_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.conceptAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.conceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ConceptAttachment_GetMaxStrIdByPrefix = ConceptAttachment_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ConceptAttachment_GetWebApiUrl(strController, strAction) {
        const strThisFuncName = "GetWebApiUrl";
        let strServiceUrl;
        let strCurrIPAddressAndPort = "";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort;
        }
        else {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local;
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx) == true) {
            strServiceUrl = (0, clsString_js_2.Format)("{0}/{1}/{2}", strCurrIPAddressAndPort, strController, strAction);
        }
        else {
            strServiceUrl = (0, clsString_js_2.Format)("{0}/{1}/{2}/{3}", strCurrIPAddressAndPort, clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx, strController, strAction);
        }
        return strServiceUrl;
    }
    exports.ConceptAttachment_GetWebApiUrl = ConceptAttachment_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function ConceptAttachment_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls]不能为空！(In clsConceptAttachmentWApi.clsConceptAttachmentWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsConceptAttachmentWApi.clsConceptAttachmentWApi.ReFreshCache)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
        switch (clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.CacheModeId) {
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
        (0, clsvConceptAttachmentWApi_js_1.vConceptAttachment_ReFreshThisCache)(strid_CurrEduCls);
    }
    exports.ConceptAttachment_ReFreshCache = ConceptAttachment_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function ConceptAttachment_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
            switch (clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.CacheModeId) {
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
            const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
            console.trace(strMsg);
        }
        else {
            const strMsg = (0, clsString_js_2.Format)("刷新缓存已经关闭。");
            console.trace(strMsg);
        }
    }
    exports.ConceptAttachment_ReFreshThisCache = ConceptAttachment_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ConceptAttachment_CheckPropertyNew(pobjConceptAttachmentEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.conceptId) === true) {
            throw new Error("(errid:Watl000058)字段[概念Id]不能为空(In 概念附件)!(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.filePath) === true) {
            throw new Error("(errid:Watl000058)字段[文件路径]不能为空(In 概念附件)!(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.conceptAttachmentName) == false && (0, clsString_js_2.GetStrLen)(pobjConceptAttachmentEN.conceptAttachmentName) > 200) {
            throw new Error("(errid:Watl000059)字段[附件名称(conceptAttachmentName)]的长度不能超过200(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.conceptAttachmentName)(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.conceptId) == false && (0, clsString_js_2.GetStrLen)(pobjConceptAttachmentEN.conceptId) > 8) {
            throw new Error("(errid:Watl000059)字段[概念Id(conceptId)]的长度不能超过8(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.conceptId)(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.filePath) == false && (0, clsString_js_2.GetStrLen)(pobjConceptAttachmentEN.filePath) > 500) {
            throw new Error("(errid:Watl000059)字段[文件路径(filePath)]的长度不能超过500(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.filePath)(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjConceptAttachmentEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.updDate)(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.updUserId) == false && (0, clsString_js_2.GetStrLen)(pobjConceptAttachmentEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.updUserId)(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjConceptAttachmentEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.memo)(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjConceptAttachmentEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.id_CurrEduCls)(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjConceptAttachmentEN.conceptAttachmentId && undefined !== pobjConceptAttachmentEN.conceptAttachmentId && clsString_js_1.tzDataType.isNumber(pobjConceptAttachmentEN.conceptAttachmentId) === false) {
            throw new Error("(errid:Watl000060)字段[概念附件Id(conceptAttachmentId)]的值:[$(pobjConceptAttachmentEN.conceptAttachmentId)], 非法，应该为数值型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.conceptAttachmentName) == false && undefined !== pobjConceptAttachmentEN.conceptAttachmentName && clsString_js_1.tzDataType.isString(pobjConceptAttachmentEN.conceptAttachmentName) === false) {
            throw new Error("(errid:Watl000060)字段[附件名称(conceptAttachmentName)]的值:[$(pobjConceptAttachmentEN.conceptAttachmentName)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.conceptId) == false && undefined !== pobjConceptAttachmentEN.conceptId && clsString_js_1.tzDataType.isString(pobjConceptAttachmentEN.conceptId) === false) {
            throw new Error("(errid:Watl000060)字段[概念Id(conceptId)]的值:[$(pobjConceptAttachmentEN.conceptId)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.filePath) == false && undefined !== pobjConceptAttachmentEN.filePath && clsString_js_1.tzDataType.isString(pobjConceptAttachmentEN.filePath) === false) {
            throw new Error("(errid:Watl000060)字段[文件路径(filePath)]的值:[$(pobjConceptAttachmentEN.filePath)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.updDate) == false && undefined !== pobjConceptAttachmentEN.updDate && clsString_js_1.tzDataType.isString(pobjConceptAttachmentEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjConceptAttachmentEN.updDate)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.updUserId) == false && undefined !== pobjConceptAttachmentEN.updUserId && clsString_js_1.tzDataType.isString(pobjConceptAttachmentEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjConceptAttachmentEN.updUserId)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.memo) == false && undefined !== pobjConceptAttachmentEN.memo && clsString_js_1.tzDataType.isString(pobjConceptAttachmentEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjConceptAttachmentEN.memo)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.id_CurrEduCls) == false && undefined !== pobjConceptAttachmentEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjConceptAttachmentEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjConceptAttachmentEN.id_CurrEduCls)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjConceptAttachmentEN.SetIsCheckProperty(true);
    }
    exports.ConceptAttachment_CheckPropertyNew = ConceptAttachment_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ConceptAttachment_CheckProperty4Update(pobjConceptAttachmentEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.conceptAttachmentName) == false && (0, clsString_js_2.GetStrLen)(pobjConceptAttachmentEN.conceptAttachmentName) > 200) {
            throw new Error("(errid:Watl000062)字段[附件名称(conceptAttachmentName)]的长度不能超过200(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.conceptAttachmentName)(clsConceptAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.conceptId) == false && (0, clsString_js_2.GetStrLen)(pobjConceptAttachmentEN.conceptId) > 8) {
            throw new Error("(errid:Watl000062)字段[概念Id(conceptId)]的长度不能超过8(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.conceptId)(clsConceptAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.filePath) == false && (0, clsString_js_2.GetStrLen)(pobjConceptAttachmentEN.filePath) > 500) {
            throw new Error("(errid:Watl000062)字段[文件路径(filePath)]的长度不能超过500(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.filePath)(clsConceptAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjConceptAttachmentEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.updDate)(clsConceptAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.updUserId) == false && (0, clsString_js_2.GetStrLen)(pobjConceptAttachmentEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.updUserId)(clsConceptAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjConceptAttachmentEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.memo)(clsConceptAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjConceptAttachmentEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 概念附件(ConceptAttachment))!值:$(pobjConceptAttachmentEN.id_CurrEduCls)(clsConceptAttachmentBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjConceptAttachmentEN.conceptAttachmentId && undefined !== pobjConceptAttachmentEN.conceptAttachmentId && clsString_js_1.tzDataType.isNumber(pobjConceptAttachmentEN.conceptAttachmentId) === false) {
            throw new Error("(errid:Watl000063)字段[概念附件Id(conceptAttachmentId)]的值:[$(pobjConceptAttachmentEN.conceptAttachmentId)], 非法，应该为数值型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.conceptAttachmentName) == false && undefined !== pobjConceptAttachmentEN.conceptAttachmentName && clsString_js_1.tzDataType.isString(pobjConceptAttachmentEN.conceptAttachmentName) === false) {
            throw new Error("(errid:Watl000063)字段[附件名称(conceptAttachmentName)]的值:[$(pobjConceptAttachmentEN.conceptAttachmentName)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.conceptId) == false && undefined !== pobjConceptAttachmentEN.conceptId && clsString_js_1.tzDataType.isString(pobjConceptAttachmentEN.conceptId) === false) {
            throw new Error("(errid:Watl000063)字段[概念Id(conceptId)]的值:[$(pobjConceptAttachmentEN.conceptId)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.filePath) == false && undefined !== pobjConceptAttachmentEN.filePath && clsString_js_1.tzDataType.isString(pobjConceptAttachmentEN.filePath) === false) {
            throw new Error("(errid:Watl000063)字段[文件路径(filePath)]的值:[$(pobjConceptAttachmentEN.filePath)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.updDate) == false && undefined !== pobjConceptAttachmentEN.updDate && clsString_js_1.tzDataType.isString(pobjConceptAttachmentEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjConceptAttachmentEN.updDate)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.updUserId) == false && undefined !== pobjConceptAttachmentEN.updUserId && clsString_js_1.tzDataType.isString(pobjConceptAttachmentEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjConceptAttachmentEN.updUserId)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.memo) == false && undefined !== pobjConceptAttachmentEN.memo && clsString_js_1.tzDataType.isString(pobjConceptAttachmentEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjConceptAttachmentEN.memo)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjConceptAttachmentEN.id_CurrEduCls) == false && undefined !== pobjConceptAttachmentEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjConceptAttachmentEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjConceptAttachmentEN.id_CurrEduCls)], 非法，应该为字符型(In 概念附件(ConceptAttachment))!(clsConceptAttachmentBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjConceptAttachmentEN.conceptAttachmentId
            || pobjConceptAttachmentEN.conceptAttachmentId != null && pobjConceptAttachmentEN.conceptAttachmentId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[概念附件Id]不能为空(In 概念附件)!(clsConceptAttachmentBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjConceptAttachmentEN.SetIsCheckProperty(true);
    }
    exports.ConceptAttachment_CheckProperty4Update = ConceptAttachment_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ConceptAttachment_GetJSONStrByObj(pobjConceptAttachmentEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjConceptAttachmentEN.sf_UpdFldSetStr = pobjConceptAttachmentEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjConceptAttachmentEN);
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
    exports.ConceptAttachment_GetJSONStrByObj = ConceptAttachment_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ConceptAttachment_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrConceptAttachmentObjLst = new Array();
        if (strJSON === "") {
            return arrConceptAttachmentObjLst;
        }
        try {
            arrConceptAttachmentObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrConceptAttachmentObjLst;
        }
        return arrConceptAttachmentObjLst;
    }
    exports.ConceptAttachment_GetObjLstByJSONStr = ConceptAttachment_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrConceptAttachmentObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ConceptAttachment_GetObjLstByJSONObjLst(arrConceptAttachmentObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrConceptAttachmentObjLst = new Array();
        for (const objInFor of arrConceptAttachmentObjLstS) {
            const obj1 = ConceptAttachment_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrConceptAttachmentObjLst.push(obj1);
        }
        return arrConceptAttachmentObjLst;
    }
    exports.ConceptAttachment_GetObjLstByJSONObjLst = ConceptAttachment_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ConceptAttachment_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjConceptAttachmentEN = new clsConceptAttachmentEN_js_1.clsConceptAttachmentEN();
        if (strJSON === "") {
            return pobjConceptAttachmentEN;
        }
        try {
            pobjConceptAttachmentEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjConceptAttachmentEN;
        }
        return pobjConceptAttachmentEN;
    }
    exports.ConceptAttachment_GetObjByJSONStr = ConceptAttachment_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ConceptAttachment_GetCombineCondition(objConceptAttachment_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objConceptAttachment_Cond.dicFldComparisonOp, clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptAttachmentId) == true) {
            const strComparisonOp_ConceptAttachmentId = objConceptAttachment_Cond.dicFldComparisonOp[clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptAttachmentId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptAttachmentId, objConceptAttachment_Cond.conceptAttachmentId, strComparisonOp_ConceptAttachmentId);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptAttachment_Cond.dicFldComparisonOp, clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptAttachmentName) == true) {
            const strComparisonOp_ConceptAttachmentName = objConceptAttachment_Cond.dicFldComparisonOp[clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptAttachmentName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptAttachmentName, objConceptAttachment_Cond.conceptAttachmentName, strComparisonOp_ConceptAttachmentName);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptAttachment_Cond.dicFldComparisonOp, clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptId) == true) {
            const strComparisonOp_ConceptId = objConceptAttachment_Cond.dicFldComparisonOp[clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_ConceptId, objConceptAttachment_Cond.conceptId, strComparisonOp_ConceptId);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptAttachment_Cond.dicFldComparisonOp, clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_FilePath) == true) {
            const strComparisonOp_FilePath = objConceptAttachment_Cond.dicFldComparisonOp[clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_FilePath];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_FilePath, objConceptAttachment_Cond.filePath, strComparisonOp_FilePath);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptAttachment_Cond.dicFldComparisonOp, clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objConceptAttachment_Cond.dicFldComparisonOp[clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_UpdDate, objConceptAttachment_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptAttachment_Cond.dicFldComparisonOp, clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objConceptAttachment_Cond.dicFldComparisonOp[clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_UpdUserId, objConceptAttachment_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptAttachment_Cond.dicFldComparisonOp, clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_Memo) == true) {
            const strComparisonOp_Memo = objConceptAttachment_Cond.dicFldComparisonOp[clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_Memo, objConceptAttachment_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objConceptAttachment_Cond.dicFldComparisonOp, clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objConceptAttachment_Cond.dicFldComparisonOp[clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsConceptAttachmentEN_js_1.clsConceptAttachmentEN.con_id_CurrEduCls, objConceptAttachment_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.ConceptAttachment_GetCombineCondition = ConceptAttachment_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--ConceptAttachment(概念附件),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngConceptAttachmentId: 概念附件Id(要求唯一的字段)
    * @param strConceptId: 概念Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ConceptAttachment_GetUniCondStr_ConceptAttachmentId_ConceptId(objConceptAttachmentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ConceptAttachmentId = '{0}'", objConceptAttachmentEN.conceptAttachmentId);
        strWhereCond += (0, clsString_js_2.Format)(" and ConceptId = '{0}'", objConceptAttachmentEN.conceptId);
        return strWhereCond;
    }
    exports.ConceptAttachment_GetUniCondStr_ConceptAttachmentId_ConceptId = ConceptAttachment_GetUniCondStr_ConceptAttachmentId_ConceptId;
    /**
    *获取唯一性条件串(Uniqueness)--ConceptAttachment(概念附件),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngConceptAttachmentId: 概念附件Id(要求唯一的字段)
    * @param strConceptId: 概念Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ConceptAttachment_GetUniCondStr4Update_ConceptAttachmentId_ConceptId(objConceptAttachmentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ConceptAttachmentId <> '{0}'", objConceptAttachmentEN.conceptAttachmentId);
        strWhereCond += (0, clsString_js_2.Format)(" and ConceptAttachmentId = '{0}'", objConceptAttachmentEN.conceptAttachmentId);
        strWhereCond += (0, clsString_js_2.Format)(" and ConceptId = '{0}'", objConceptAttachmentEN.conceptId);
        return strWhereCond;
    }
    exports.ConceptAttachment_GetUniCondStr4Update_ConceptAttachmentId_ConceptId = ConceptAttachment_GetUniCondStr4Update_ConceptAttachmentId_ConceptId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objConceptAttachmentENS:源对象
     * @param objConceptAttachmentENT:目标对象
    */
    function ConceptAttachment_CopyObjTo(objConceptAttachmentENS, objConceptAttachmentENT) {
        objConceptAttachmentENT.conceptAttachmentId = objConceptAttachmentENS.conceptAttachmentId; //概念附件Id
        objConceptAttachmentENT.conceptAttachmentName = objConceptAttachmentENS.conceptAttachmentName; //附件名称
        objConceptAttachmentENT.conceptId = objConceptAttachmentENS.conceptId; //概念Id
        objConceptAttachmentENT.filePath = objConceptAttachmentENS.filePath; //文件路径
        objConceptAttachmentENT.updDate = objConceptAttachmentENS.updDate; //修改日期
        objConceptAttachmentENT.updUserId = objConceptAttachmentENS.updUserId; //修改用户Id
        objConceptAttachmentENT.memo = objConceptAttachmentENS.memo; //备注
        objConceptAttachmentENT.id_CurrEduCls = objConceptAttachmentENS.id_CurrEduCls; //教学班流水号
        objConceptAttachmentENT.sf_UpdFldSetStr = objConceptAttachmentENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ConceptAttachment_CopyObjTo = ConceptAttachment_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objConceptAttachmentENS:源对象
     * @param objConceptAttachmentENT:目标对象
    */
    function ConceptAttachment_GetObjFromJsonObj(objConceptAttachmentENS) {
        const objConceptAttachmentENT = new clsConceptAttachmentEN_js_1.clsConceptAttachmentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objConceptAttachmentENT, objConceptAttachmentENS);
        return objConceptAttachmentENT;
    }
    exports.ConceptAttachment_GetObjFromJsonObj = ConceptAttachment_GetObjFromJsonObj;
});
