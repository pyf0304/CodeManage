/**
* 类名:clsvConceptAttachmentWApi
* 表名:vConceptAttachment(01120606)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:47
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvConceptAttachmentEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vConceptAttachment_GetObjFromJsonObj = exports.vConceptAttachment_CopyObjTo = exports.vConceptAttachment_GetUniCondStr4Update_ConceptAttachmentId_ConceptId = exports.vConceptAttachment_GetUniCondStr_ConceptAttachmentId_ConceptId = exports.vConceptAttachment_GetCombineCondition = exports.vConceptAttachment_GetObjByJSONStr = exports.vConceptAttachment_GetObjLstByJSONObjLst = exports.vConceptAttachment_GetObjLstByJSONStr = exports.vConceptAttachment_GetJSONStrByObj = exports.vConceptAttachment_ReFreshThisCache = exports.vConceptAttachment_GetWebApiUrl = exports.vConceptAttachment_GetRecCountByCond_Cache = exports.vConceptAttachment_GetRecCountByCondAsync = exports.vConceptAttachment_IsExistAsync = exports.vConceptAttachment_IsExist_Cache = exports.vConceptAttachment_IsExist = exports.vConceptAttachment_IsExistRecordAsync = exports.vConceptAttachment_IsExistRecord_Cache = exports.vConceptAttachment_GetObjLstByPagerAsync = exports.vConceptAttachment_GetObjLstByPager_Cache = exports.vConceptAttachment_GetObjLstByRange = exports.vConceptAttachment_GetObjLstByRangeAsync = exports.vConceptAttachment_GetTopObjLstAsync = exports.vConceptAttachment_GetObjLstByConceptAttachmentIdLst_Cache = exports.vConceptAttachment_GetObjLstByConceptAttachmentIdLstAsync = exports.vConceptAttachment_GetSubObjLst_Cache = exports.vConceptAttachment_GetObjLst_PureCache = exports.vConceptAttachment_GetObjLst_Cache = exports.vConceptAttachment_GetObjLst_sessionStorage_PureCache = exports.vConceptAttachment_GetObjLst_sessionStorage = exports.vConceptAttachment_GetObjLstAsync = exports.vConceptAttachment_GetObjLst_localStorage_PureCache = exports.vConceptAttachment_GetObjLst_localStorage = exports.vConceptAttachment_GetObjLst_ClientCache = exports.vConceptAttachment_GetFirstObjAsync = exports.vConceptAttachment_GetFirstID = exports.vConceptAttachment_GetFirstIDAsync = exports.vConceptAttachment_FilterFunByKey = exports.vConceptAttachment_SortFunByKey = exports.vConceptAttachment_SortFun_Defa_2Fld = exports.vConceptAttachment_SortFun_Defa = exports.vConceptAttachment_func = exports.vConceptAttachment_GetObjByConceptAttachmentId_localStorage = exports.vConceptAttachment_GetObjByConceptAttachmentId_Cache = exports.vConceptAttachment_GetObjByConceptAttachmentIdAsync = exports.vConceptAttachment_ConstructorName = exports.vConceptAttachment_Controller = void 0;
    /**
     * vConceptAttachment(vConceptAttachment)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvConceptAttachmentEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvConceptAttachmentEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vConceptAttachment_Controller = "vConceptAttachmentApi";
    exports.vConceptAttachment_ConstructorName = "vConceptAttachment";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngConceptAttachmentId:关键字
    * @returns 对象
    **/
    async function vConceptAttachment_GetObjByConceptAttachmentIdAsync(lngConceptAttachmentId) {
        const strThisFuncName = "GetObjByConceptAttachmentIdAsync";
        if (lngConceptAttachmentId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngConceptAttachmentId]不能为空！(In GetObjByConceptAttachmentIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByConceptAttachmentId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptAttachment_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConceptAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvConceptAttachment = vConceptAttachment_GetObjFromJsonObj(returnObj);
                return objvConceptAttachment;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptAttachment_GetObjByConceptAttachmentIdAsync = vConceptAttachment_GetObjByConceptAttachmentIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngConceptAttachmentId:所给的关键字
     * @returns 对象
    */
    async function vConceptAttachment_GetObjByConceptAttachmentId_Cache(lngConceptAttachmentId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByConceptAttachmentId_Cache";
        if (lngConceptAttachmentId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngConceptAttachmentId]不能为空！(In GetObjByConceptAttachmentId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvConceptAttachmentObjLst_Cache = await vConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvConceptAttachment_Sel = arrvConceptAttachmentObjLst_Cache.filter(x => x.conceptAttachmentId == lngConceptAttachmentId);
            let objvConceptAttachment;
            if (arrvConceptAttachment_Sel.length > 0) {
                objvConceptAttachment = arrvConceptAttachment_Sel[0];
                return objvConceptAttachment;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvConceptAttachment = await vConceptAttachment_GetObjByConceptAttachmentIdAsync(lngConceptAttachmentId);
                    if (objvConceptAttachment != null) {
                        vConceptAttachment_ReFreshThisCache(strid_CurrEduCls);
                        return objvConceptAttachment;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngConceptAttachmentId, exports.vConceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vConceptAttachment_GetObjByConceptAttachmentId_Cache = vConceptAttachment_GetObjByConceptAttachmentId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngConceptAttachmentId:所给的关键字
     * @returns 对象
    */
    async function vConceptAttachment_GetObjByConceptAttachmentId_localStorage(lngConceptAttachmentId) {
        const strThisFuncName = "GetObjByConceptAttachmentId_localStorage";
        if (lngConceptAttachmentId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngConceptAttachmentId]不能为空！(In GetObjByConceptAttachmentId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN._CurrTabName, lngConceptAttachmentId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvConceptAttachment_Cache = JSON.parse(strTempObj);
            return objvConceptAttachment_Cache;
        }
        try {
            const objvConceptAttachment = await vConceptAttachment_GetObjByConceptAttachmentIdAsync(lngConceptAttachmentId);
            if (objvConceptAttachment != null) {
                localStorage.setItem(strKey, JSON.stringify(objvConceptAttachment));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvConceptAttachment;
            }
            return objvConceptAttachment;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngConceptAttachmentId, exports.vConceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vConceptAttachment_GetObjByConceptAttachmentId_localStorage = vConceptAttachment_GetObjByConceptAttachmentId_localStorage;
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
    async function vConceptAttachment_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
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
        if (strInFldName != clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptAttachmentId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngConceptAttachmentId = Number(strInValue);
        if (lngConceptAttachmentId == 0) {
            return "";
        }
        const objvConceptAttachment = await vConceptAttachment_GetObjByConceptAttachmentId_Cache(lngConceptAttachmentId, strid_CurrEduCls_C);
        if (objvConceptAttachment == null)
            return "";
        return objvConceptAttachment.GetFldValue(strOutFldName).toString();
    }
    exports.vConceptAttachment_func = vConceptAttachment_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vConceptAttachment_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.conceptAttachmentId - b.conceptAttachmentId;
    }
    exports.vConceptAttachment_SortFun_Defa = vConceptAttachment_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vConceptAttachment_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.conceptName == b.conceptName)
            return a.conceptContent.localeCompare(b.conceptContent);
        else
            return a.conceptName.localeCompare(b.conceptName);
    }
    exports.vConceptAttachment_SortFun_Defa_2Fld = vConceptAttachment_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vConceptAttachment_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptName:
                    return (a, b) => {
                        return a.conceptName.localeCompare(b.conceptName);
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptAttachmentId:
                    return (a, b) => {
                        return a.conceptAttachmentId - b.conceptAttachmentId;
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptContent:
                    return (a, b) => {
                        return a.conceptContent.localeCompare(b.conceptContent);
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptAttachmentName:
                    return (a, b) => {
                        return a.conceptAttachmentName.localeCompare(b.conceptAttachmentName);
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptId:
                    return (a, b) => {
                        return a.conceptId.localeCompare(b.conceptId);
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_FilePath:
                    return (a, b) => {
                        return a.filePath.localeCompare(b.filePath);
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vConceptAttachment]中不存在！(in ${exports.vConceptAttachment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptName:
                    return (a, b) => {
                        return b.conceptName.localeCompare(a.conceptName);
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptAttachmentId:
                    return (a, b) => {
                        return b.conceptAttachmentId - a.conceptAttachmentId;
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptContent:
                    return (a, b) => {
                        return b.conceptContent.localeCompare(a.conceptContent);
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptAttachmentName:
                    return (a, b) => {
                        return b.conceptAttachmentName.localeCompare(a.conceptAttachmentName);
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptId:
                    return (a, b) => {
                        return b.conceptId.localeCompare(a.conceptId);
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_FilePath:
                    return (a, b) => {
                        return b.filePath.localeCompare(a.filePath);
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vConceptAttachment]中不存在！(in ${exports.vConceptAttachment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vConceptAttachment_SortFunByKey = vConceptAttachment_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vConceptAttachment_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptName:
                return (obj) => {
                    return obj.conceptName === value;
                };
            case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptAttachmentId:
                return (obj) => {
                    return obj.conceptAttachmentId === value;
                };
            case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptContent:
                return (obj) => {
                    return obj.conceptContent === value;
                };
            case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptAttachmentName:
                return (obj) => {
                    return obj.conceptAttachmentName === value;
                };
            case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptId:
                return (obj) => {
                    return obj.conceptId === value;
                };
            case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_FilePath:
                return (obj) => {
                    return obj.filePath === value;
                };
            case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vConceptAttachment]中不存在！(in ${exports.vConceptAttachment_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vConceptAttachment_FilterFunByKey = vConceptAttachment_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vConceptAttachment_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptAttachment_GetFirstIDAsync = vConceptAttachment_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vConceptAttachment_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptAttachment_GetFirstID = vConceptAttachment_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vConceptAttachment_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConceptAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvConceptAttachment = vConceptAttachment_GetObjFromJsonObj(returnObj);
                return objvConceptAttachment;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptAttachment_GetFirstObjAsync = vConceptAttachment_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vConceptAttachment_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
        clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvConceptAttachmentExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvConceptAttachmentObjLst_T = vConceptAttachment_GetObjLstByJSONObjLst(arrvConceptAttachmentExObjLst_Cache);
            return arrvConceptAttachmentObjLst_T;
        }
        try {
            const arrvConceptAttachmentExObjLst = await vConceptAttachment_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvConceptAttachmentExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvConceptAttachmentExObjLst.length);
            console.log(strInfo);
            return arrvConceptAttachmentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vConceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vConceptAttachment_GetObjLst_ClientCache = vConceptAttachment_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vConceptAttachment_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
        clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvConceptAttachmentExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvConceptAttachmentObjLst_T = vConceptAttachment_GetObjLstByJSONObjLst(arrvConceptAttachmentExObjLst_Cache);
            return arrvConceptAttachmentObjLst_T;
        }
        try {
            const arrvConceptAttachmentExObjLst = await vConceptAttachment_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvConceptAttachmentExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvConceptAttachmentExObjLst.length);
            console.log(strInfo);
            return arrvConceptAttachmentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vConceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vConceptAttachment_GetObjLst_localStorage = vConceptAttachment_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vConceptAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvConceptAttachmentObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvConceptAttachmentObjLst_Cache;
        }
        else
            return null;
    }
    exports.vConceptAttachment_GetObjLst_localStorage_PureCache = vConceptAttachment_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vConceptAttachment_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConceptAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vConceptAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptAttachment_GetObjLstAsync = vConceptAttachment_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vConceptAttachment_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
        clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvConceptAttachmentExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvConceptAttachmentObjLst_T = vConceptAttachment_GetObjLstByJSONObjLst(arrvConceptAttachmentExObjLst_Cache);
            return arrvConceptAttachmentObjLst_T;
        }
        try {
            const arrvConceptAttachmentExObjLst = await vConceptAttachment_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvConceptAttachmentExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvConceptAttachmentExObjLst.length);
            console.log(strInfo);
            return arrvConceptAttachmentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vConceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vConceptAttachment_GetObjLst_sessionStorage = vConceptAttachment_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vConceptAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvConceptAttachmentObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvConceptAttachmentObjLst_Cache;
        }
        else
            return null;
    }
    exports.vConceptAttachment_GetObjLst_sessionStorage_PureCache = vConceptAttachment_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vConceptAttachment_GetObjLst_Cache(strid_CurrEduCls) {
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
        let arrvConceptAttachmentObjLst_Cache;
        switch (clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.CacheModeId) {
            case "04": //sessionStorage
                arrvConceptAttachmentObjLst_Cache = await vConceptAttachment_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvConceptAttachmentObjLst_Cache = await vConceptAttachment_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvConceptAttachmentObjLst_Cache = await vConceptAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvConceptAttachmentObjLst_Cache = await vConceptAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvConceptAttachmentObjLst = vConceptAttachment_GetObjLstByJSONObjLst(arrvConceptAttachmentObjLst_Cache);
        return arrvConceptAttachmentObjLst_Cache;
    }
    exports.vConceptAttachment_GetObjLst_Cache = vConceptAttachment_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vConceptAttachment_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvConceptAttachmentObjLst_Cache;
        switch (clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.CacheModeId) {
            case "04": //sessionStorage
                arrvConceptAttachmentObjLst_Cache = await vConceptAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvConceptAttachmentObjLst_Cache = await vConceptAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvConceptAttachmentObjLst_Cache = null;
                break;
            default:
                arrvConceptAttachmentObjLst_Cache = null;
                break;
        }
        return arrvConceptAttachmentObjLst_Cache;
    }
    exports.vConceptAttachment_GetObjLst_PureCache = vConceptAttachment_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngConceptAttachmentId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vConceptAttachment_GetSubObjLst_Cache(objvConceptAttachment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvConceptAttachmentObjLst_Cache = await vConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
        let arrvConceptAttachment_Sel = arrvConceptAttachmentObjLst_Cache;
        if (objvConceptAttachment_Cond.sf_FldComparisonOp == null || objvConceptAttachment_Cond.sf_FldComparisonOp == "")
            return arrvConceptAttachment_Sel;
        const dicFldComparisonOp = JSON.parse(objvConceptAttachment_Cond.sf_FldComparisonOp);
        //console.log("clsvConceptAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvConceptAttachment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvConceptAttachment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvConceptAttachment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvConceptAttachment_Cond), exports.vConceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vConceptAttachment_GetSubObjLst_Cache = vConceptAttachment_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrConceptAttachmentId:关键字列表
    * @returns 对象列表
    **/
    async function vConceptAttachment_GetObjLstByConceptAttachmentIdLstAsync(arrConceptAttachmentId) {
        const strThisFuncName = "GetObjLstByConceptAttachmentIdLstAsync";
        const strAction = "GetObjLstByConceptAttachmentIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrConceptAttachmentId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConceptAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vConceptAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptAttachment_GetObjLstByConceptAttachmentIdLstAsync = vConceptAttachment_GetObjLstByConceptAttachmentIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngConceptAttachmentIdLst:关键字列表
     * @returns 对象列表
    */
    async function vConceptAttachment_GetObjLstByConceptAttachmentIdLst_Cache(arrConceptAttachmentIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByConceptAttachmentIdLst_Cache";
        try {
            const arrvConceptAttachmentObjLst_Cache = await vConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
            const arrvConceptAttachment_Sel = arrvConceptAttachmentObjLst_Cache.filter(x => arrConceptAttachmentIdLst.indexOf(x.conceptAttachmentId) > -1);
            return arrvConceptAttachment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrConceptAttachmentIdLst.join(","), exports.vConceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vConceptAttachment_GetObjLstByConceptAttachmentIdLst_Cache = vConceptAttachment_GetObjLstByConceptAttachmentIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vConceptAttachment_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConceptAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vConceptAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptAttachment_GetTopObjLstAsync = vConceptAttachment_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vConceptAttachment_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConceptAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vConceptAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptAttachment_GetObjLstByRangeAsync = vConceptAttachment_GetObjLstByRangeAsync;
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
    async function vConceptAttachment_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptAttachment_GetObjLstByRange = vConceptAttachment_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vConceptAttachment_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvConceptAttachmentObjLst_Cache = await vConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvConceptAttachmentObjLst_Cache.length == 0)
            return arrvConceptAttachmentObjLst_Cache;
        let arrvConceptAttachment_Sel = arrvConceptAttachmentObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvConceptAttachment_Cond = new clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvConceptAttachment_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvConceptAttachmentWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvConceptAttachment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvConceptAttachment_Sel.length == 0)
                return arrvConceptAttachment_Sel;
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
                arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.sort(vConceptAttachment_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.sort(objPagerPara.sortFun);
            }
            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.slice(intStart, intEnd);
            return arrvConceptAttachment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vConceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vConceptAttachment_GetObjLstByPager_Cache = vConceptAttachment_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vConceptAttachment_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vConceptAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vConceptAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptAttachment_GetObjLstByPagerAsync = vConceptAttachment_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngConceptAttachmentId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vConceptAttachment_IsExistRecord_Cache(objvConceptAttachment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvConceptAttachmentObjLst_Cache = await vConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvConceptAttachmentObjLst_Cache == null)
            return false;
        let arrvConceptAttachment_Sel = arrvConceptAttachmentObjLst_Cache;
        if (objvConceptAttachment_Cond.sf_FldComparisonOp == null || objvConceptAttachment_Cond.sf_FldComparisonOp == "")
            return arrvConceptAttachment_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvConceptAttachment_Cond.sf_FldComparisonOp);
        //console.log("clsvConceptAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvConceptAttachment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvConceptAttachment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvConceptAttachment_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvConceptAttachment_Cond), exports.vConceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vConceptAttachment_IsExistRecord_Cache = vConceptAttachment_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vConceptAttachment_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptAttachment_IsExistRecordAsync = vConceptAttachment_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngConceptAttachmentId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vConceptAttachment_IsExist(lngConceptAttachmentId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptAttachment_IsExist = vConceptAttachment_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngConceptAttachmentId:所给的关键字
     * @returns 对象
    */
    async function vConceptAttachment_IsExist_Cache(lngConceptAttachmentId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvConceptAttachmentObjLst_Cache = await vConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvConceptAttachmentObjLst_Cache == null)
            return false;
        try {
            const arrvConceptAttachment_Sel = arrvConceptAttachmentObjLst_Cache.filter(x => x.conceptAttachmentId == lngConceptAttachmentId);
            if (arrvConceptAttachment_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngConceptAttachmentId, exports.vConceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vConceptAttachment_IsExist_Cache = vConceptAttachment_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngConceptAttachmentId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vConceptAttachment_IsExistAsync(lngConceptAttachmentId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptAttachment_IsExistAsync = vConceptAttachment_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vConceptAttachment_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vConceptAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vConceptAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vConceptAttachment_GetRecCountByCondAsync = vConceptAttachment_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvConceptAttachment_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vConceptAttachment_GetRecCountByCond_Cache(objvConceptAttachment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvConceptAttachmentObjLst_Cache = await vConceptAttachment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvConceptAttachmentObjLst_Cache == null)
            return 0;
        let arrvConceptAttachment_Sel = arrvConceptAttachmentObjLst_Cache;
        if (objvConceptAttachment_Cond.sf_FldComparisonOp == null || objvConceptAttachment_Cond.sf_FldComparisonOp == "")
            return arrvConceptAttachment_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvConceptAttachment_Cond.sf_FldComparisonOp);
        //console.log("clsvConceptAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvConceptAttachment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvConceptAttachment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvConceptAttachment_Sel = arrvConceptAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvConceptAttachment_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvConceptAttachment_Cond), exports.vConceptAttachment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vConceptAttachment_GetRecCountByCond_Cache = vConceptAttachment_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vConceptAttachment_GetWebApiUrl(strController, strAction) {
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
    exports.vConceptAttachment_GetWebApiUrl = vConceptAttachment_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vConceptAttachment_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN._CurrTabName, strid_CurrEduCls);
            switch (clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.CacheModeId) {
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
    exports.vConceptAttachment_ReFreshThisCache = vConceptAttachment_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vConceptAttachment_GetJSONStrByObj(pobjvConceptAttachmentEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvConceptAttachmentEN);
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
    exports.vConceptAttachment_GetJSONStrByObj = vConceptAttachment_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vConceptAttachment_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvConceptAttachmentObjLst = new Array();
        if (strJSON === "") {
            return arrvConceptAttachmentObjLst;
        }
        try {
            arrvConceptAttachmentObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvConceptAttachmentObjLst;
        }
        return arrvConceptAttachmentObjLst;
    }
    exports.vConceptAttachment_GetObjLstByJSONStr = vConceptAttachment_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvConceptAttachmentObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vConceptAttachment_GetObjLstByJSONObjLst(arrvConceptAttachmentObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvConceptAttachmentObjLst = new Array();
        for (const objInFor of arrvConceptAttachmentObjLstS) {
            const obj1 = vConceptAttachment_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvConceptAttachmentObjLst.push(obj1);
        }
        return arrvConceptAttachmentObjLst;
    }
    exports.vConceptAttachment_GetObjLstByJSONObjLst = vConceptAttachment_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vConceptAttachment_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvConceptAttachmentEN = new clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN();
        if (strJSON === "") {
            return pobjvConceptAttachmentEN;
        }
        try {
            pobjvConceptAttachmentEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvConceptAttachmentEN;
        }
        return pobjvConceptAttachmentEN;
    }
    exports.vConceptAttachment_GetObjByJSONStr = vConceptAttachment_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vConceptAttachment_GetCombineCondition(objvConceptAttachment_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvConceptAttachment_Cond.dicFldComparisonOp, clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptName) == true) {
            const strComparisonOp_ConceptName = objvConceptAttachment_Cond.dicFldComparisonOp[clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptName, objvConceptAttachment_Cond.conceptName, strComparisonOp_ConceptName);
        }
        if (Object.prototype.hasOwnProperty.call(objvConceptAttachment_Cond.dicFldComparisonOp, clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptAttachmentId) == true) {
            const strComparisonOp_ConceptAttachmentId = objvConceptAttachment_Cond.dicFldComparisonOp[clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptAttachmentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptAttachmentId, objvConceptAttachment_Cond.conceptAttachmentId, strComparisonOp_ConceptAttachmentId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvConceptAttachment_Cond.dicFldComparisonOp, clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptAttachmentName) == true) {
            const strComparisonOp_ConceptAttachmentName = objvConceptAttachment_Cond.dicFldComparisonOp[clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptAttachmentName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptAttachmentName, objvConceptAttachment_Cond.conceptAttachmentName, strComparisonOp_ConceptAttachmentName);
        }
        if (Object.prototype.hasOwnProperty.call(objvConceptAttachment_Cond.dicFldComparisonOp, clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptId) == true) {
            const strComparisonOp_ConceptId = objvConceptAttachment_Cond.dicFldComparisonOp[clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_ConceptId, objvConceptAttachment_Cond.conceptId, strComparisonOp_ConceptId);
        }
        if (Object.prototype.hasOwnProperty.call(objvConceptAttachment_Cond.dicFldComparisonOp, clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_IsSubmit) == true) {
            if (objvConceptAttachment_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvConceptAttachment_Cond.dicFldComparisonOp, clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_FilePath) == true) {
            const strComparisonOp_FilePath = objvConceptAttachment_Cond.dicFldComparisonOp[clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_FilePath];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_FilePath, objvConceptAttachment_Cond.filePath, strComparisonOp_FilePath);
        }
        if (Object.prototype.hasOwnProperty.call(objvConceptAttachment_Cond.dicFldComparisonOp, clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvConceptAttachment_Cond.dicFldComparisonOp[clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_UpdDate, objvConceptAttachment_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvConceptAttachment_Cond.dicFldComparisonOp, clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvConceptAttachment_Cond.dicFldComparisonOp[clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_Memo, objvConceptAttachment_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvConceptAttachment_Cond.dicFldComparisonOp, clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvConceptAttachment_Cond.dicFldComparisonOp[clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN.con_id_CurrEduCls, objvConceptAttachment_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.vConceptAttachment_GetCombineCondition = vConceptAttachment_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--vConceptAttachment(vConceptAttachment),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngConceptAttachmentId: 概念附件Id(要求唯一的字段)
    * @param strConceptId: 概念Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vConceptAttachment_GetUniCondStr_ConceptAttachmentId_ConceptId(objvConceptAttachmentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ConceptAttachmentId = '{0}'", objvConceptAttachmentEN.conceptAttachmentId);
        strWhereCond += (0, clsString_js_1.Format)(" and ConceptId = '{0}'", objvConceptAttachmentEN.conceptId);
        return strWhereCond;
    }
    exports.vConceptAttachment_GetUniCondStr_ConceptAttachmentId_ConceptId = vConceptAttachment_GetUniCondStr_ConceptAttachmentId_ConceptId;
    /**
    *获取唯一性条件串(Uniqueness)--vConceptAttachment(vConceptAttachment),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngConceptAttachmentId: 概念附件Id(要求唯一的字段)
    * @param strConceptId: 概念Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vConceptAttachment_GetUniCondStr4Update_ConceptAttachmentId_ConceptId(objvConceptAttachmentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ConceptAttachmentId <> '{0}'", objvConceptAttachmentEN.conceptAttachmentId);
        strWhereCond += (0, clsString_js_1.Format)(" and ConceptAttachmentId = '{0}'", objvConceptAttachmentEN.conceptAttachmentId);
        strWhereCond += (0, clsString_js_1.Format)(" and ConceptId = '{0}'", objvConceptAttachmentEN.conceptId);
        return strWhereCond;
    }
    exports.vConceptAttachment_GetUniCondStr4Update_ConceptAttachmentId_ConceptId = vConceptAttachment_GetUniCondStr4Update_ConceptAttachmentId_ConceptId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvConceptAttachmentENS:源对象
     * @param objvConceptAttachmentENT:目标对象
    */
    function vConceptAttachment_CopyObjTo(objvConceptAttachmentENS, objvConceptAttachmentENT) {
        objvConceptAttachmentENT.conceptName = objvConceptAttachmentENS.conceptName; //概念名称
        objvConceptAttachmentENT.conceptAttachmentId = objvConceptAttachmentENS.conceptAttachmentId; //概念附件Id
        objvConceptAttachmentENT.conceptContent = objvConceptAttachmentENS.conceptContent; //概念内容
        objvConceptAttachmentENT.conceptAttachmentName = objvConceptAttachmentENS.conceptAttachmentName; //附件名称
        objvConceptAttachmentENT.conceptId = objvConceptAttachmentENS.conceptId; //概念Id
        objvConceptAttachmentENT.isSubmit = objvConceptAttachmentENS.isSubmit; //是否提交
        objvConceptAttachmentENT.filePath = objvConceptAttachmentENS.filePath; //文件路径
        objvConceptAttachmentENT.updDate = objvConceptAttachmentENS.updDate; //修改日期
        objvConceptAttachmentENT.memo = objvConceptAttachmentENS.memo; //备注
        objvConceptAttachmentENT.id_CurrEduCls = objvConceptAttachmentENS.id_CurrEduCls; //教学班流水号
    }
    exports.vConceptAttachment_CopyObjTo = vConceptAttachment_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvConceptAttachmentENS:源对象
     * @param objvConceptAttachmentENT:目标对象
    */
    function vConceptAttachment_GetObjFromJsonObj(objvConceptAttachmentENS) {
        const objvConceptAttachmentENT = new clsvConceptAttachmentEN_js_1.clsvConceptAttachmentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvConceptAttachmentENT, objvConceptAttachmentENS);
        return objvConceptAttachmentENT;
    }
    exports.vConceptAttachment_GetObjFromJsonObj = vConceptAttachment_GetObjFromJsonObj;
});
