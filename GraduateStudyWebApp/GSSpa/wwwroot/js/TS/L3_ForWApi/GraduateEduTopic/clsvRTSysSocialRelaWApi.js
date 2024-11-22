/**
* 类名:clsvRTSysSocialRelaWApi
* 表名:vRTSysSocialRela(01120655)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:54
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvRTSysSocialRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vRTSysSocialRela_GetObjFromJsonObj = exports.vRTSysSocialRela_CopyObjTo = exports.vRTSysSocialRela_GetUniCondStr4Update_mId = exports.vRTSysSocialRela_GetUniCondStr_mId = exports.vRTSysSocialRela_GetCombineCondition = exports.vRTSysSocialRela_GetObjByJSONStr = exports.vRTSysSocialRela_GetObjLstByJSONObjLst = exports.vRTSysSocialRela_GetObjLstByJSONStr = exports.vRTSysSocialRela_GetJSONStrByObj = exports.vRTSysSocialRela__Cache = exports.vRTSysSocialRela_ReFreshThisCache = exports.vRTSysSocialRela_GetWebApiUrl = exports.vRTSysSocialRela_GetRecCountByCond_Cache = exports.vRTSysSocialRela_GetRecCountByCondAsync = exports.vRTSysSocialRela_IsExistAsync = exports.vRTSysSocialRela_IsExist_Cache = exports.vRTSysSocialRela_IsExist = exports.vRTSysSocialRela_IsExistRecordAsync = exports.vRTSysSocialRela_IsExistRecord_Cache = exports.vRTSysSocialRela_GetObjLstByPagerAsync = exports.vRTSysSocialRela_GetObjLstByPager_Cache = exports.vRTSysSocialRela_GetObjLstByRange = exports.vRTSysSocialRela_GetObjLstByRangeAsync = exports.vRTSysSocialRela_GetTopObjLstAsync = exports.vRTSysSocialRela_GetObjLstBymIdLst_Cache = exports.vRTSysSocialRela_GetObjLstBymIdLstAsync = exports.vRTSysSocialRela_GetSubObjLst_Cache = exports.vRTSysSocialRela_GetObjLst_PureCache = exports.vRTSysSocialRela_GetObjLst_Cache = exports.vRTSysSocialRela_GetObjLst_sessionStorage_PureCache = exports.vRTSysSocialRela_GetObjLst_sessionStorage = exports.vRTSysSocialRela_GetObjLstAsync = exports.vRTSysSocialRela_GetObjLst_localStorage_PureCache = exports.vRTSysSocialRela_GetObjLst_localStorage = exports.vRTSysSocialRela_GetObjLst_ClientCache = exports.vRTSysSocialRela_GetFirstObjAsync = exports.vRTSysSocialRela_GetFirstID = exports.vRTSysSocialRela_GetFirstIDAsync = exports.vRTSysSocialRela_FilterFunByKey = exports.vRTSysSocialRela_SortFunByKey = exports.vRTSysSocialRela_SortFun_Defa_2Fld = exports.vRTSysSocialRela_SortFun_Defa = exports.vRTSysSocialRela_func = exports.vRTSysSocialRela_GetNameBymId_Cache = exports.vRTSysSocialRela_GetObjBymId_localStorage = exports.vRTSysSocialRela_GetObjBymId_Cache = exports.vRTSysSocialRela_GetObjBymIdAsync = exports.vRTSysSocialRela_ConstructorName = exports.vRTSysSocialRela_Controller = void 0;
    /**
     * vRTSysSocialRela(vRTSysSocialRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvRTSysSocialRelaEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvRTSysSocialRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vRTSysSocialRela_Controller = "vRTSysSocialRelaApi";
    exports.vRTSysSocialRela_ConstructorName = "vRTSysSocialRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vRTSysSocialRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSocialRela_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvRTSysSocialRela = vRTSysSocialRela_GetObjFromJsonObj(returnObj);
                return objvRTSysSocialRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSocialRela_GetObjBymIdAsync = vRTSysSocialRela_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTSysSocialRela_GetObjBymId_Cache(lngmId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvRTSysSocialRelaObjLst_Cache = await vRTSysSocialRela_GetObjLst_Cache();
        try {
            const arrvRTSysSocialRela_Sel = arrvRTSysSocialRelaObjLst_Cache.filter(x => x.mId == lngmId);
            let objvRTSysSocialRela;
            if (arrvRTSysSocialRela_Sel.length > 0) {
                objvRTSysSocialRela = arrvRTSysSocialRela_Sel[0];
                return objvRTSysSocialRela;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvRTSysSocialRela = await vRTSysSocialRela_GetObjBymIdAsync(lngmId);
                    if (objvRTSysSocialRela != null) {
                        vRTSysSocialRela_ReFreshThisCache();
                        return objvRTSysSocialRela;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vRTSysSocialRela_GetObjBymId_Cache = vRTSysSocialRela_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTSysSocialRela_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvRTSysSocialRela_Cache = JSON.parse(strTempObj);
            return objvRTSysSocialRela_Cache;
        }
        try {
            const objvRTSysSocialRela = await vRTSysSocialRela_GetObjBymIdAsync(lngmId);
            if (objvRTSysSocialRela != null) {
                localStorage.setItem(strKey, JSON.stringify(objvRTSysSocialRela));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvRTSysSocialRela;
            }
            return objvRTSysSocialRela;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vRTSysSocialRela_GetObjBymId_localStorage = vRTSysSocialRela_GetObjBymId_localStorage;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTSysSocialRela_GetNameBymId_Cache(lngmId) {
        const strThisFuncName = "GetNameBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetNameBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvRTSysSocialRelaObjLst_Cache = await vRTSysSocialRela_GetObjLst_Cache();
        if (arrvRTSysSocialRelaObjLst_Cache == null)
            return "";
        try {
            const arrvRTSysSocialRela_Sel = arrvRTSysSocialRelaObjLst_Cache.filter(x => x.mId == lngmId);
            let objvRTSysSocialRela;
            if (arrvRTSysSocialRela_Sel.length > 0) {
                objvRTSysSocialRela = arrvRTSysSocialRela_Sel[0];
                return objvRTSysSocialRela.levelId;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, lngmId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.vRTSysSocialRela_GetNameBymId_Cache = vRTSysSocialRela_GetNameBymId_Cache;
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
    async function vRTSysSocialRela_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objvRTSysSocialRela = await vRTSysSocialRela_GetObjBymId_Cache(lngmId);
        if (objvRTSysSocialRela == null)
            return "";
        return objvRTSysSocialRela.GetFldValue(strOutFldName).toString();
    }
    exports.vRTSysSocialRela_func = vRTSysSocialRela_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTSysSocialRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vRTSysSocialRela_SortFun_Defa = vRTSysSocialRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTSysSocialRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.topicName.localeCompare(b.topicName);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.vRTSysSocialRela_SortFun_Defa_2Fld = vRTSysSocialRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTSysSocialRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicName:
                    return (a, b) => {
                        return a.topicName.localeCompare(b.topicName);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicContent:
                    return (a, b) => {
                        return a.topicContent.localeCompare(b.topicContent);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicProposePeople:
                    return (a, b) => {
                        return a.topicProposePeople.localeCompare(b.topicProposePeople);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialId:
                    return (a, b) => {
                        return a.socialId.localeCompare(b.socialId);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_FullName:
                    return (a, b) => {
                        return a.fullName.localeCompare(b.fullName);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Nationality:
                    return (a, b) => {
                        return a.nationality.localeCompare(b.nationality);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_WorkUnit:
                    return (a, b) => {
                        return a.workUnit.localeCompare(b.workUnit);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Major:
                    return (a, b) => {
                        return a.major.localeCompare(b.major);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Achievement:
                    return (a, b) => {
                        return a.achievement.localeCompare(b.achievement);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_DetailedDescription:
                    return (a, b) => {
                        return a.detailedDescription.localeCompare(b.detailedDescription);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_LevelId:
                    return (a, b) => {
                        return a.levelId.localeCompare(b.levelId);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_LevelName:
                    return (a, b) => {
                        return a.levelName.localeCompare(b.levelName);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialUpdUser:
                    return (a, b) => {
                        return a.socialUpdUser.localeCompare(b.socialUpdUser);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialUpdDate:
                    return (a, b) => {
                        return a.socialUpdDate.localeCompare(b.socialUpdDate);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CitationCount:
                    return (a, b) => {
                        return a.citationCount - b.citationCount;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CreateDate:
                    return (a, b) => {
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_PdfContent:
                    return (a, b) => {
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CitationId:
                    return (a, b) => {
                        return a.citationId.localeCompare(b.citationId);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_ClassificationId:
                    return (a, b) => {
                        return a.classificationId.localeCompare(b.classificationId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vRTSysSocialRela]中不存在！(in ${exports.vRTSysSocialRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicName:
                    return (a, b) => {
                        return b.topicName.localeCompare(a.topicName);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicContent:
                    return (a, b) => {
                        return b.topicContent.localeCompare(a.topicContent);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicProposePeople:
                    return (a, b) => {
                        return b.topicProposePeople.localeCompare(a.topicProposePeople);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialId:
                    return (a, b) => {
                        return b.socialId.localeCompare(a.socialId);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_FullName:
                    return (a, b) => {
                        return b.fullName.localeCompare(a.fullName);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Nationality:
                    return (a, b) => {
                        return b.nationality.localeCompare(a.nationality);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_WorkUnit:
                    return (a, b) => {
                        return b.workUnit.localeCompare(a.workUnit);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Major:
                    return (a, b) => {
                        return b.major.localeCompare(a.major);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Achievement:
                    return (a, b) => {
                        return b.achievement.localeCompare(a.achievement);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_DetailedDescription:
                    return (a, b) => {
                        return b.detailedDescription.localeCompare(a.detailedDescription);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_LevelId:
                    return (a, b) => {
                        return b.levelId.localeCompare(a.levelId);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_LevelName:
                    return (a, b) => {
                        return b.levelName.localeCompare(a.levelName);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialUpdUser:
                    return (a, b) => {
                        return b.socialUpdUser.localeCompare(a.socialUpdUser);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialUpdDate:
                    return (a, b) => {
                        return b.socialUpdDate.localeCompare(a.socialUpdDate);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CitationCount:
                    return (a, b) => {
                        return b.citationCount - a.citationCount;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CreateDate:
                    return (a, b) => {
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_PdfContent:
                    return (a, b) => {
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CitationId:
                    return (a, b) => {
                        return b.citationId.localeCompare(a.citationId);
                    };
                case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_ClassificationId:
                    return (a, b) => {
                        return b.classificationId.localeCompare(a.classificationId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vRTSysSocialRela]中不存在！(in ${exports.vRTSysSocialRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vRTSysSocialRela_SortFunByKey = vRTSysSocialRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vRTSysSocialRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicName:
                return (obj) => {
                    return obj.topicName === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicContent:
                return (obj) => {
                    return obj.topicContent === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicProposePeople:
                return (obj) => {
                    return obj.topicProposePeople === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialId:
                return (obj) => {
                    return obj.socialId === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_FullName:
                return (obj) => {
                    return obj.fullName === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Nationality:
                return (obj) => {
                    return obj.nationality === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_WorkUnit:
                return (obj) => {
                    return obj.workUnit === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Major:
                return (obj) => {
                    return obj.major === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Achievement:
                return (obj) => {
                    return obj.achievement === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_DetailedDescription:
                return (obj) => {
                    return obj.detailedDescription === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_LevelId:
                return (obj) => {
                    return obj.levelId === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_LevelName:
                return (obj) => {
                    return obj.levelName === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialUpdUser:
                return (obj) => {
                    return obj.socialUpdUser === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialUpdDate:
                return (obj) => {
                    return obj.socialUpdDate === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CitationCount:
                return (obj) => {
                    return obj.citationCount === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CitationId:
                return (obj) => {
                    return obj.citationId === value;
                };
            case clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_ClassificationId:
                return (obj) => {
                    return obj.classificationId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vRTSysSocialRela]中不存在！(in ${exports.vRTSysSocialRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vRTSysSocialRela_FilterFunByKey = vRTSysSocialRela_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vRTSysSocialRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSocialRela_GetFirstIDAsync = vRTSysSocialRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vRTSysSocialRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSocialRela_GetFirstID = vRTSysSocialRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vRTSysSocialRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvRTSysSocialRela = vRTSysSocialRela_GetObjFromJsonObj(returnObj);
                return objvRTSysSocialRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSocialRela_GetFirstObjAsync = vRTSysSocialRela_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTSysSocialRela_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN._CurrTabName;
        clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvRTSysSocialRelaExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvRTSysSocialRelaObjLst_T = vRTSysSocialRela_GetObjLstByJSONObjLst(arrvRTSysSocialRelaExObjLst_Cache);
            return arrvRTSysSocialRelaObjLst_T;
        }
        try {
            const arrvRTSysSocialRelaExObjLst = await vRTSysSocialRela_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvRTSysSocialRelaExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTSysSocialRelaExObjLst.length);
            console.log(strInfo);
            return arrvRTSysSocialRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTSysSocialRela_GetObjLst_ClientCache = vRTSysSocialRela_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTSysSocialRela_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN._CurrTabName;
        clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvRTSysSocialRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvRTSysSocialRelaObjLst_T = vRTSysSocialRela_GetObjLstByJSONObjLst(arrvRTSysSocialRelaExObjLst_Cache);
            return arrvRTSysSocialRelaObjLst_T;
        }
        try {
            const arrvRTSysSocialRelaExObjLst = await vRTSysSocialRela_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvRTSysSocialRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTSysSocialRelaExObjLst.length);
            console.log(strInfo);
            return arrvRTSysSocialRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTSysSocialRela_GetObjLst_localStorage = vRTSysSocialRela_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTSysSocialRela_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvRTSysSocialRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvRTSysSocialRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.vRTSysSocialRela_GetObjLst_localStorage_PureCache = vRTSysSocialRela_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vRTSysSocialRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTSysSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSocialRela_GetObjLstAsync = vRTSysSocialRela_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTSysSocialRela_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN._CurrTabName;
        clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvRTSysSocialRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvRTSysSocialRelaObjLst_T = vRTSysSocialRela_GetObjLstByJSONObjLst(arrvRTSysSocialRelaExObjLst_Cache);
            return arrvRTSysSocialRelaObjLst_T;
        }
        try {
            const arrvRTSysSocialRelaExObjLst = await vRTSysSocialRela_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvRTSysSocialRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTSysSocialRelaExObjLst.length);
            console.log(strInfo);
            return arrvRTSysSocialRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTSysSocialRela_GetObjLst_sessionStorage = vRTSysSocialRela_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTSysSocialRela_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvRTSysSocialRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvRTSysSocialRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.vRTSysSocialRela_GetObjLst_sessionStorage_PureCache = vRTSysSocialRela_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTSysSocialRela_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvRTSysSocialRelaObjLst_Cache;
        switch (clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrvRTSysSocialRelaObjLst_Cache = await vRTSysSocialRela_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvRTSysSocialRelaObjLst_Cache = await vRTSysSocialRela_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvRTSysSocialRelaObjLst_Cache = await vRTSysSocialRela_GetObjLst_ClientCache();
                break;
            default:
                arrvRTSysSocialRelaObjLst_Cache = await vRTSysSocialRela_GetObjLst_ClientCache();
                break;
        }
        const arrvRTSysSocialRelaObjLst = vRTSysSocialRela_GetObjLstByJSONObjLst(arrvRTSysSocialRelaObjLst_Cache);
        return arrvRTSysSocialRelaObjLst_Cache;
    }
    exports.vRTSysSocialRela_GetObjLst_Cache = vRTSysSocialRela_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTSysSocialRela_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvRTSysSocialRelaObjLst_Cache;
        switch (clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrvRTSysSocialRelaObjLst_Cache = await vRTSysSocialRela_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvRTSysSocialRelaObjLst_Cache = await vRTSysSocialRela_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvRTSysSocialRelaObjLst_Cache = null;
                break;
            default:
                arrvRTSysSocialRelaObjLst_Cache = null;
                break;
        }
        return arrvRTSysSocialRelaObjLst_Cache;
    }
    exports.vRTSysSocialRela_GetObjLst_PureCache = vRTSysSocialRela_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vRTSysSocialRela_GetSubObjLst_Cache(objvRTSysSocialRela_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvRTSysSocialRelaObjLst_Cache = await vRTSysSocialRela_GetObjLst_Cache();
        let arrvRTSysSocialRela_Sel = arrvRTSysSocialRelaObjLst_Cache;
        if (objvRTSysSocialRela_Cond.sf_FldComparisonOp == null || objvRTSysSocialRela_Cond.sf_FldComparisonOp == "")
            return arrvRTSysSocialRela_Sel;
        const dicFldComparisonOp = JSON.parse(objvRTSysSocialRela_Cond.sf_FldComparisonOp);
        //console.log("clsvRTSysSocialRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTSysSocialRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTSysSocialRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvRTSysSocialRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvRTSysSocialRela_Cond), exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vRTSysSocialRela_GetSubObjLst_Cache = vRTSysSocialRela_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function vRTSysSocialRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTSysSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSocialRela_GetObjLstBymIdLstAsync = vRTSysSocialRela_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function vRTSysSocialRela_GetObjLstBymIdLst_Cache(arrmIdLst) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrvRTSysSocialRelaObjLst_Cache = await vRTSysSocialRela_GetObjLst_Cache();
            const arrvRTSysSocialRela_Sel = arrvRTSysSocialRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrvRTSysSocialRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vRTSysSocialRela_GetObjLstBymIdLst_Cache = vRTSysSocialRela_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vRTSysSocialRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTSysSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSocialRela_GetTopObjLstAsync = vRTSysSocialRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vRTSysSocialRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTSysSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSocialRela_GetObjLstByRangeAsync = vRTSysSocialRela_GetObjLstByRangeAsync;
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
    async function vRTSysSocialRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSocialRela_GetObjLstByRange = vRTSysSocialRela_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vRTSysSocialRela_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvRTSysSocialRelaObjLst_Cache = await vRTSysSocialRela_GetObjLst_Cache();
        if (arrvRTSysSocialRelaObjLst_Cache.length == 0)
            return arrvRTSysSocialRelaObjLst_Cache;
        let arrvRTSysSocialRela_Sel = arrvRTSysSocialRelaObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvRTSysSocialRela_Cond = new clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvRTSysSocialRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvRTSysSocialRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTSysSocialRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvRTSysSocialRela_Sel.length == 0)
                return arrvRTSysSocialRela_Sel;
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
                arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.sort(vRTSysSocialRela_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.sort(objPagerPara.sortFun);
            }
            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.slice(intStart, intEnd);
            return arrvRTSysSocialRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vRTSysSocialRela_GetObjLstByPager_Cache = vRTSysSocialRela_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vRTSysSocialRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSocialRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTSysSocialRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSocialRela_GetObjLstByPagerAsync = vRTSysSocialRela_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vRTSysSocialRela_IsExistRecord_Cache(objvRTSysSocialRela_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvRTSysSocialRelaObjLst_Cache = await vRTSysSocialRela_GetObjLst_Cache();
        if (arrvRTSysSocialRelaObjLst_Cache == null)
            return false;
        let arrvRTSysSocialRela_Sel = arrvRTSysSocialRelaObjLst_Cache;
        if (objvRTSysSocialRela_Cond.sf_FldComparisonOp == null || objvRTSysSocialRela_Cond.sf_FldComparisonOp == "")
            return arrvRTSysSocialRela_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvRTSysSocialRela_Cond.sf_FldComparisonOp);
        //console.log("clsvRTSysSocialRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTSysSocialRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTSysSocialRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvRTSysSocialRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvRTSysSocialRela_Cond), exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vRTSysSocialRela_IsExistRecord_Cache = vRTSysSocialRela_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vRTSysSocialRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSocialRela_IsExistRecordAsync = vRTSysSocialRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vRTSysSocialRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSocialRela_IsExist = vRTSysSocialRela_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTSysSocialRela_IsExist_Cache(lngmId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvRTSysSocialRelaObjLst_Cache = await vRTSysSocialRela_GetObjLst_Cache();
        if (arrvRTSysSocialRelaObjLst_Cache == null)
            return false;
        try {
            const arrvRTSysSocialRela_Sel = arrvRTSysSocialRelaObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrvRTSysSocialRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vRTSysSocialRela_IsExist_Cache = vRTSysSocialRela_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vRTSysSocialRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSocialRela_IsExistAsync = vRTSysSocialRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vRTSysSocialRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTSysSocialRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTSysSocialRela_GetRecCountByCondAsync = vRTSysSocialRela_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvRTSysSocialRela_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vRTSysSocialRela_GetRecCountByCond_Cache(objvRTSysSocialRela_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvRTSysSocialRelaObjLst_Cache = await vRTSysSocialRela_GetObjLst_Cache();
        if (arrvRTSysSocialRelaObjLst_Cache == null)
            return 0;
        let arrvRTSysSocialRela_Sel = arrvRTSysSocialRelaObjLst_Cache;
        if (objvRTSysSocialRela_Cond.sf_FldComparisonOp == null || objvRTSysSocialRela_Cond.sf_FldComparisonOp == "")
            return arrvRTSysSocialRela_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvRTSysSocialRela_Cond.sf_FldComparisonOp);
        //console.log("clsvRTSysSocialRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTSysSocialRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTSysSocialRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTSysSocialRela_Sel = arrvRTSysSocialRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvRTSysSocialRela_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvRTSysSocialRela_Cond), exports.vRTSysSocialRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vRTSysSocialRela_GetRecCountByCond_Cache = vRTSysSocialRela_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vRTSysSocialRela_GetWebApiUrl(strController, strAction) {
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
    exports.vRTSysSocialRela_GetWebApiUrl = vRTSysSocialRela_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vRTSysSocialRela_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN._CurrTabName;
            switch (clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.CacheModeId) {
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
    exports.vRTSysSocialRela_ReFreshThisCache = vRTSysSocialRela_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function vRTSysSocialRela__Cache(strDivName, strDdlName) {
        const strThisFuncName = "_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In )", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：_Cache");
        const arrObjLst_Sel = await vRTSysSocialRela_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv_V)(strDivName, strDdlName, arrObjLst_Sel, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_mId, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_LevelId, "vRTSysSocialRela");
    }
    exports.vRTSysSocialRela__Cache = vRTSysSocialRela__Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vRTSysSocialRela_GetJSONStrByObj(pobjvRTSysSocialRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvRTSysSocialRelaEN);
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
    exports.vRTSysSocialRela_GetJSONStrByObj = vRTSysSocialRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vRTSysSocialRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvRTSysSocialRelaObjLst = new Array();
        if (strJSON === "") {
            return arrvRTSysSocialRelaObjLst;
        }
        try {
            arrvRTSysSocialRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvRTSysSocialRelaObjLst;
        }
        return arrvRTSysSocialRelaObjLst;
    }
    exports.vRTSysSocialRela_GetObjLstByJSONStr = vRTSysSocialRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvRTSysSocialRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vRTSysSocialRela_GetObjLstByJSONObjLst(arrvRTSysSocialRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvRTSysSocialRelaObjLst = new Array();
        for (const objInFor of arrvRTSysSocialRelaObjLstS) {
            const obj1 = vRTSysSocialRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvRTSysSocialRelaObjLst.push(obj1);
        }
        return arrvRTSysSocialRelaObjLst;
    }
    exports.vRTSysSocialRela_GetObjLstByJSONObjLst = vRTSysSocialRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vRTSysSocialRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvRTSysSocialRelaEN = new clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN();
        if (strJSON === "") {
            return pobjvRTSysSocialRelaEN;
        }
        try {
            pobjvRTSysSocialRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvRTSysSocialRelaEN;
        }
        return pobjvRTSysSocialRelaEN;
    }
    exports.vRTSysSocialRela_GetObjByJSONStr = vRTSysSocialRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vRTSysSocialRela_GetCombineCondition(objvRTSysSocialRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_mId, objvRTSysSocialRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicId, objvRTSysSocialRela_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicName) == true) {
            const strComparisonOp_TopicName = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicName, objvRTSysSocialRela_Cond.topicName, strComparisonOp_TopicName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicProposePeople) == true) {
            const strComparisonOp_TopicProposePeople = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicProposePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TopicProposePeople, objvRTSysSocialRela_Cond.topicProposePeople, strComparisonOp_TopicProposePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_OrderNum, objvRTSysSocialRela_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_id_CurrEduCls, objvRTSysSocialRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialId) == true) {
            const strComparisonOp_SocialId = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialId, objvRTSysSocialRela_Cond.socialId, strComparisonOp_SocialId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_FullName) == true) {
            const strComparisonOp_FullName = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_FullName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_FullName, objvRTSysSocialRela_Cond.fullName, strComparisonOp_FullName);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Nationality) == true) {
            const strComparisonOp_Nationality = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Nationality];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Nationality, objvRTSysSocialRela_Cond.nationality, strComparisonOp_Nationality);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_WorkUnit) == true) {
            const strComparisonOp_WorkUnit = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_WorkUnit];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_WorkUnit, objvRTSysSocialRela_Cond.workUnit, strComparisonOp_WorkUnit);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Major) == true) {
            const strComparisonOp_Major = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Major];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Major, objvRTSysSocialRela_Cond.major, strComparisonOp_Major);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Achievement) == true) {
            const strComparisonOp_Achievement = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Achievement];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Achievement, objvRTSysSocialRela_Cond.achievement, strComparisonOp_Achievement);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_LevelId) == true) {
            const strComparisonOp_LevelId = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_LevelId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_LevelId, objvRTSysSocialRela_Cond.levelId, strComparisonOp_LevelId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_LevelName) == true) {
            const strComparisonOp_LevelName = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_LevelName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_LevelName, objvRTSysSocialRela_Cond.levelName, strComparisonOp_LevelName);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialUpdUser) == true) {
            const strComparisonOp_SocialUpdUser = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialUpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialUpdUser, objvRTSysSocialRela_Cond.socialUpdUser, strComparisonOp_SocialUpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialUpdDate) == true) {
            const strComparisonOp_SocialUpdDate = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialUpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_SocialUpdDate, objvRTSysSocialRela_Cond.socialUpdDate, strComparisonOp_SocialUpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_IsSubmit) == true) {
            if (objvRTSysSocialRela_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_OkCount, objvRTSysSocialRela_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CitationCount) == true) {
            const strComparisonOp_CitationCount = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CitationCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CitationCount, objvRTSysSocialRela_Cond.citationCount, strComparisonOp_CitationCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_VersionCount, objvRTSysSocialRela_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_UpdDate, objvRTSysSocialRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_UpdUser, objvRTSysSocialRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_Memo, objvRTSysSocialRela_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_AppraiseCount, objvRTSysSocialRela_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_score) == true) {
            const strComparisonOp_score = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_score, objvRTSysSocialRela_Cond.score, strComparisonOp_score);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_StuScore, objvRTSysSocialRela_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_TeaScore, objvRTSysSocialRela_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CreateDate, objvRTSysSocialRela_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_ShareId, objvRTSysSocialRela_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_PdfContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_PdfContent, objvRTSysSocialRela_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_PdfPageNum, objvRTSysSocialRela_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CitationId) == true) {
            const strComparisonOp_CitationId = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CitationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_CitationId, objvRTSysSocialRela_Cond.citationId, strComparisonOp_CitationId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTSysSocialRela_Cond.dicFldComparisonOp, clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_ClassificationId) == true) {
            const strComparisonOp_ClassificationId = objvRTSysSocialRela_Cond.dicFldComparisonOp[clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_ClassificationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN.con_ClassificationId, objvRTSysSocialRela_Cond.classificationId, strComparisonOp_ClassificationId);
        }
        return strWhereCond;
    }
    exports.vRTSysSocialRela_GetCombineCondition = vRTSysSocialRela_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--vRTSysSocialRela(vRTSysSocialRela),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vRTSysSocialRela_GetUniCondStr_mId(objvRTSysSocialRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objvRTSysSocialRelaEN.mId);
        return strWhereCond;
    }
    exports.vRTSysSocialRela_GetUniCondStr_mId = vRTSysSocialRela_GetUniCondStr_mId;
    /**
    *获取唯一性条件串(Uniqueness)--vRTSysSocialRela(vRTSysSocialRela),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vRTSysSocialRela_GetUniCondStr4Update_mId(objvRTSysSocialRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objvRTSysSocialRelaEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objvRTSysSocialRelaEN.mId);
        return strWhereCond;
    }
    exports.vRTSysSocialRela_GetUniCondStr4Update_mId = vRTSysSocialRela_GetUniCondStr4Update_mId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvRTSysSocialRelaENS:源对象
     * @param objvRTSysSocialRelaENT:目标对象
    */
    function vRTSysSocialRela_CopyObjTo(objvRTSysSocialRelaENS, objvRTSysSocialRelaENT) {
        objvRTSysSocialRelaENT.mId = objvRTSysSocialRelaENS.mId; //mId
        objvRTSysSocialRelaENT.topicId = objvRTSysSocialRelaENS.topicId; //主题Id
        objvRTSysSocialRelaENT.topicName = objvRTSysSocialRelaENS.topicName; //栏目主题
        objvRTSysSocialRelaENT.topicContent = objvRTSysSocialRelaENS.topicContent; //主题内容
        objvRTSysSocialRelaENT.topicProposePeople = objvRTSysSocialRelaENS.topicProposePeople; //主题提出人
        objvRTSysSocialRelaENT.orderNum = objvRTSysSocialRelaENS.orderNum; //序号
        objvRTSysSocialRelaENT.id_CurrEduCls = objvRTSysSocialRelaENS.id_CurrEduCls; //教学班流水号
        objvRTSysSocialRelaENT.socialId = objvRTSysSocialRelaENS.socialId; //社会Id
        objvRTSysSocialRelaENT.fullName = objvRTSysSocialRelaENS.fullName; //姓名
        objvRTSysSocialRelaENT.nationality = objvRTSysSocialRelaENS.nationality; //国籍
        objvRTSysSocialRelaENT.workUnit = objvRTSysSocialRelaENS.workUnit; //工作单位
        objvRTSysSocialRelaENT.major = objvRTSysSocialRelaENS.major; //专业
        objvRTSysSocialRelaENT.achievement = objvRTSysSocialRelaENS.achievement; //成就
        objvRTSysSocialRelaENT.detailedDescription = objvRTSysSocialRelaENS.detailedDescription; //详细说明
        objvRTSysSocialRelaENT.levelId = objvRTSysSocialRelaENS.levelId; //级别Id
        objvRTSysSocialRelaENT.levelName = objvRTSysSocialRelaENS.levelName; //级别名称
        objvRTSysSocialRelaENT.socialUpdUser = objvRTSysSocialRelaENS.socialUpdUser; //SocialUpdUser
        objvRTSysSocialRelaENT.socialUpdDate = objvRTSysSocialRelaENS.socialUpdDate; //SocialUpdDate
        objvRTSysSocialRelaENT.isSubmit = objvRTSysSocialRelaENS.isSubmit; //是否提交
        objvRTSysSocialRelaENT.okCount = objvRTSysSocialRelaENS.okCount; //点赞统计
        objvRTSysSocialRelaENT.citationCount = objvRTSysSocialRelaENS.citationCount; //引用统计
        objvRTSysSocialRelaENT.versionCount = objvRTSysSocialRelaENS.versionCount; //版本统计
        objvRTSysSocialRelaENT.updDate = objvRTSysSocialRelaENS.updDate; //修改日期
        objvRTSysSocialRelaENT.updUser = objvRTSysSocialRelaENS.updUser; //修改人
        objvRTSysSocialRelaENT.memo = objvRTSysSocialRelaENS.memo; //备注
        objvRTSysSocialRelaENT.appraiseCount = objvRTSysSocialRelaENS.appraiseCount; //评论数
        objvRTSysSocialRelaENT.score = objvRTSysSocialRelaENS.score; //评分
        objvRTSysSocialRelaENT.stuScore = objvRTSysSocialRelaENS.stuScore; //学生平均分
        objvRTSysSocialRelaENT.teaScore = objvRTSysSocialRelaENS.teaScore; //教师评分
        objvRTSysSocialRelaENT.createDate = objvRTSysSocialRelaENS.createDate; //建立日期
        objvRTSysSocialRelaENT.shareId = objvRTSysSocialRelaENS.shareId; //分享Id
        objvRTSysSocialRelaENT.pdfContent = objvRTSysSocialRelaENS.pdfContent; //Pdf内容
        objvRTSysSocialRelaENT.pdfPageNum = objvRTSysSocialRelaENS.pdfPageNum; //Pdf页码
        objvRTSysSocialRelaENT.citationId = objvRTSysSocialRelaENS.citationId; //引用Id
        objvRTSysSocialRelaENT.classificationId = objvRTSysSocialRelaENS.classificationId; //分类Id
    }
    exports.vRTSysSocialRela_CopyObjTo = vRTSysSocialRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvRTSysSocialRelaENS:源对象
     * @param objvRTSysSocialRelaENT:目标对象
    */
    function vRTSysSocialRela_GetObjFromJsonObj(objvRTSysSocialRelaENS) {
        const objvRTSysSocialRelaENT = new clsvRTSysSocialRelaEN_js_1.clsvRTSysSocialRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvRTSysSocialRelaENT, objvRTSysSocialRelaENS);
        return objvRTSysSocialRelaENT;
    }
    exports.vRTSysSocialRela_GetObjFromJsonObj = vRTSysSocialRela_GetObjFromJsonObj;
});
