/**
* 类名:clsvXzMajorDirectionWApi
* 表名:vXzMajorDirection(01120553)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:26
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:基本信息维护(BaseInfo)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/BaseInfo/clsvXzMajorDirectionEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vXzMajorDirection_GetObjFromJsonObj = exports.vXzMajorDirection_CopyObjTo = exports.vXzMajorDirection_GetCombineCondition = exports.vXzMajorDirection_GetObjByJSONStr = exports.vXzMajorDirection_GetObjLstByJSONObjLst = exports.vXzMajorDirection_GetObjLstByJSONStr = exports.vXzMajorDirection_GetJSONStrByObj = exports.vXzMajorDirection_ReFreshThisCache = exports.vXzMajorDirection_GetWebApiUrl = exports.vXzMajorDirection_GetRecCountByCond_Cache = exports.vXzMajorDirection_GetRecCountByCondAsync = exports.vXzMajorDirection_IsExistAsync = exports.vXzMajorDirection_IsExist_Cache = exports.vXzMajorDirection_IsExist = exports.vXzMajorDirection_IsExistRecordAsync = exports.vXzMajorDirection_IsExistRecord_Cache = exports.vXzMajorDirection_GetObjLstByPagerAsync = exports.vXzMajorDirection_GetObjLstByPager_Cache = exports.vXzMajorDirection_GetObjLstByRange = exports.vXzMajorDirection_GetObjLstByRangeAsync = exports.vXzMajorDirection_GetTopObjLstAsync = exports.vXzMajorDirection_GetObjLstByMajorDirectionIdLst_Cache = exports.vXzMajorDirection_GetObjLstByMajorDirectionIdLstAsync = exports.vXzMajorDirection_GetSubObjLst_Cache = exports.vXzMajorDirection_GetObjLst_PureCache = exports.vXzMajorDirection_GetObjLst_Cache = exports.vXzMajorDirection_GetObjLst_sessionStorage_PureCache = exports.vXzMajorDirection_GetObjLst_sessionStorage = exports.vXzMajorDirection_GetObjLstAsync = exports.vXzMajorDirection_GetObjLst_localStorage_PureCache = exports.vXzMajorDirection_GetObjLst_localStorage = exports.vXzMajorDirection_GetObjLst_ClientCache = exports.vXzMajorDirection_GetFirstObjAsync = exports.vXzMajorDirection_GetFirstID = exports.vXzMajorDirection_GetFirstIDAsync = exports.vXzMajorDirection_FilterFunByKey = exports.vXzMajorDirection_SortFunByKey = exports.vXzMajorDirection_SortFun_Defa_2Fld = exports.vXzMajorDirection_SortFun_Defa = exports.vXzMajorDirection_func = exports.vXzMajorDirection_GetObjByMajorDirectionId_localStorage = exports.vXzMajorDirection_GetObjByMajorDirectionId_Cache = exports.vXzMajorDirection_GetObjByMajorDirectionIdAsync = exports.vXzMajorDirection_ConstructorName = exports.vXzMajorDirection_Controller = void 0;
    /**
     * v专业方向(vXzMajorDirection)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvXzMajorDirectionEN_js_1 = require("../../L0_Entity/BaseInfo/clsvXzMajorDirectionEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vXzMajorDirection_Controller = "vXzMajorDirectionApi";
    exports.vXzMajorDirection_ConstructorName = "vXzMajorDirection";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strMajorDirectionId:关键字
    * @returns 对象
    **/
    async function vXzMajorDirection_GetObjByMajorDirectionIdAsync(strMajorDirectionId) {
        const strThisFuncName = "GetObjByMajorDirectionIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strMajorDirectionId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strMajorDirectionId]不能为空！(In GetObjByMajorDirectionIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strMajorDirectionId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strMajorDirectionId]的长度:[{0}]不正确！", strMajorDirectionId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByMajorDirectionId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strMajorDirectionId": strMajorDirectionId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvXzMajorDirection = vXzMajorDirection_GetObjFromJsonObj(returnObj);
                return objvXzMajorDirection;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajorDirection_GetObjByMajorDirectionIdAsync = vXzMajorDirection_GetObjByMajorDirectionIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strMajorDirectionId:所给的关键字
     * @returns 对象
    */
    async function vXzMajorDirection_GetObjByMajorDirectionId_Cache(strMajorDirectionId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByMajorDirectionId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strMajorDirectionId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strMajorDirectionId]不能为空！(In GetObjByMajorDirectionId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strMajorDirectionId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strMajorDirectionId]的长度:[{0}]不正确！", strMajorDirectionId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_Cache();
        try {
            const arrvXzMajorDirection_Sel = arrvXzMajorDirectionObjLst_Cache.filter(x => x.majorDirectionId == strMajorDirectionId);
            let objvXzMajorDirection;
            if (arrvXzMajorDirection_Sel.length > 0) {
                objvXzMajorDirection = arrvXzMajorDirection_Sel[0];
                return objvXzMajorDirection;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvXzMajorDirection = await vXzMajorDirection_GetObjByMajorDirectionIdAsync(strMajorDirectionId);
                    if (objvXzMajorDirection != null) {
                        vXzMajorDirection_ReFreshThisCache();
                        return objvXzMajorDirection;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strMajorDirectionId, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vXzMajorDirection_GetObjByMajorDirectionId_Cache = vXzMajorDirection_GetObjByMajorDirectionId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strMajorDirectionId:所给的关键字
     * @returns 对象
    */
    async function vXzMajorDirection_GetObjByMajorDirectionId_localStorage(strMajorDirectionId) {
        const strThisFuncName = "GetObjByMajorDirectionId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strMajorDirectionId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strMajorDirectionId]不能为空！(In GetObjByMajorDirectionId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strMajorDirectionId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strMajorDirectionId]的长度:[{0}]不正确！", strMajorDirectionId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN._CurrTabName, strMajorDirectionId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvXzMajorDirection_Cache = JSON.parse(strTempObj);
            return objvXzMajorDirection_Cache;
        }
        try {
            const objvXzMajorDirection = await vXzMajorDirection_GetObjByMajorDirectionIdAsync(strMajorDirectionId);
            if (objvXzMajorDirection != null) {
                localStorage.setItem(strKey, JSON.stringify(objvXzMajorDirection));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvXzMajorDirection;
            }
            return objvXzMajorDirection;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strMajorDirectionId, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vXzMajorDirection_GetObjByMajorDirectionId_localStorage = vXzMajorDirection_GetObjByMajorDirectionId_localStorage;
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
    async function vXzMajorDirection_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strMajorDirectionId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvXzMajorDirection = await vXzMajorDirection_GetObjByMajorDirectionId_Cache(strMajorDirectionId);
        if (objvXzMajorDirection == null)
            return "";
        return objvXzMajorDirection.GetFldValue(strOutFldName).toString();
    }
    exports.vXzMajorDirection_func = vXzMajorDirection_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vXzMajorDirection_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.majorDirectionId.localeCompare(b.majorDirectionId);
    }
    exports.vXzMajorDirection_SortFun_Defa = vXzMajorDirection_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vXzMajorDirection_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.id_XzMajor == b.id_XzMajor)
            return a.majorID.localeCompare(b.majorID);
        else
            return a.id_XzMajor.localeCompare(b.id_XzMajor);
    }
    exports.vXzMajorDirection_SortFun_Defa_2Fld = vXzMajorDirection_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vXzMajorDirection_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionId:
                    return (a, b) => {
                        return a.majorDirectionId.localeCompare(b.majorDirectionId);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorID:
                    return (a, b) => {
                        return a.majorID.localeCompare(b.majorID);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionName:
                    return (a, b) => {
                        return a.majorDirectionName.localeCompare(b.majorDirectionName);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionENName:
                    return (a, b) => {
                        return a.majorDirectionENName.localeCompare(b.majorDirectionENName);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionExplain:
                    return (a, b) => {
                        return a.majorDirectionExplain.localeCompare(b.majorDirectionExplain);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_IsVisible:
                    return (a, b) => {
                        if (a.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vXzMajorDirection]中不存在！(in ${exports.vXzMajorDirection_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionId:
                    return (a, b) => {
                        return b.majorDirectionId.localeCompare(a.majorDirectionId);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorID:
                    return (a, b) => {
                        return b.majorID.localeCompare(a.majorID);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionName:
                    return (a, b) => {
                        return b.majorDirectionName.localeCompare(a.majorDirectionName);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionENName:
                    return (a, b) => {
                        return b.majorDirectionENName.localeCompare(a.majorDirectionENName);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionExplain:
                    return (a, b) => {
                        return b.majorDirectionExplain.localeCompare(a.majorDirectionExplain);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_IsVisible:
                    return (a, b) => {
                        if (b.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vXzMajorDirection]中不存在！(in ${exports.vXzMajorDirection_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vXzMajorDirection_SortFunByKey = vXzMajorDirection_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vXzMajorDirection_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionId:
                return (obj) => {
                    return obj.majorDirectionId === value;
                };
            case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorID:
                return (obj) => {
                    return obj.majorID === value;
                };
            case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionName:
                return (obj) => {
                    return obj.majorDirectionName === value;
                };
            case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionENName:
                return (obj) => {
                    return obj.majorDirectionENName === value;
                };
            case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionExplain:
                return (obj) => {
                    return obj.majorDirectionExplain === value;
                };
            case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_IsVisible:
                return (obj) => {
                    return obj.isVisible === value;
                };
            case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vXzMajorDirection]中不存在！(in ${exports.vXzMajorDirection_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vXzMajorDirection_FilterFunByKey = vXzMajorDirection_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vXzMajorDirection_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajorDirection_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajorDirection_GetFirstIDAsync = vXzMajorDirection_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vXzMajorDirection_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajorDirection_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajorDirection_GetFirstID = vXzMajorDirection_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vXzMajorDirection_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvXzMajorDirection = vXzMajorDirection_GetObjFromJsonObj(returnObj);
                return objvXzMajorDirection;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajorDirection_GetFirstObjAsync = vXzMajorDirection_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vXzMajorDirection_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN._CurrTabName;
        clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvXzMajorDirectionExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvXzMajorDirectionObjLst_T = vXzMajorDirection_GetObjLstByJSONObjLst(arrvXzMajorDirectionExObjLst_Cache);
            return arrvXzMajorDirectionObjLst_T;
        }
        try {
            const arrvXzMajorDirectionExObjLst = await vXzMajorDirection_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvXzMajorDirectionExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvXzMajorDirectionExObjLst.length);
            console.log(strInfo);
            return arrvXzMajorDirectionExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vXzMajorDirection_GetObjLst_ClientCache = vXzMajorDirection_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vXzMajorDirection_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN._CurrTabName;
        clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvXzMajorDirectionExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvXzMajorDirectionObjLst_T = vXzMajorDirection_GetObjLstByJSONObjLst(arrvXzMajorDirectionExObjLst_Cache);
            return arrvXzMajorDirectionObjLst_T;
        }
        try {
            const arrvXzMajorDirectionExObjLst = await vXzMajorDirection_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvXzMajorDirectionExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvXzMajorDirectionExObjLst.length);
            console.log(strInfo);
            return arrvXzMajorDirectionExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vXzMajorDirection_GetObjLst_localStorage = vXzMajorDirection_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vXzMajorDirection_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvXzMajorDirectionObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvXzMajorDirectionObjLst_Cache;
        }
        else
            return null;
    }
    exports.vXzMajorDirection_GetObjLst_localStorage_PureCache = vXzMajorDirection_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vXzMajorDirection_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzMajorDirection_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajorDirection_GetObjLstAsync = vXzMajorDirection_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vXzMajorDirection_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN._CurrTabName;
        clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvXzMajorDirectionExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvXzMajorDirectionObjLst_T = vXzMajorDirection_GetObjLstByJSONObjLst(arrvXzMajorDirectionExObjLst_Cache);
            return arrvXzMajorDirectionObjLst_T;
        }
        try {
            const arrvXzMajorDirectionExObjLst = await vXzMajorDirection_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvXzMajorDirectionExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvXzMajorDirectionExObjLst.length);
            console.log(strInfo);
            return arrvXzMajorDirectionExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vXzMajorDirection_GetObjLst_sessionStorage = vXzMajorDirection_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vXzMajorDirection_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvXzMajorDirectionObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvXzMajorDirectionObjLst_Cache;
        }
        else
            return null;
    }
    exports.vXzMajorDirection_GetObjLst_sessionStorage_PureCache = vXzMajorDirection_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vXzMajorDirection_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvXzMajorDirectionObjLst_Cache;
        switch (clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.CacheModeId) {
            case "04": //sessionStorage
                arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_ClientCache();
                break;
            default:
                arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_ClientCache();
                break;
        }
        const arrvXzMajorDirectionObjLst = vXzMajorDirection_GetObjLstByJSONObjLst(arrvXzMajorDirectionObjLst_Cache);
        return arrvXzMajorDirectionObjLst_Cache;
    }
    exports.vXzMajorDirection_GetObjLst_Cache = vXzMajorDirection_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vXzMajorDirection_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvXzMajorDirectionObjLst_Cache;
        switch (clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.CacheModeId) {
            case "04": //sessionStorage
                arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvXzMajorDirectionObjLst_Cache = null;
                break;
            default:
                arrvXzMajorDirectionObjLst_Cache = null;
                break;
        }
        return arrvXzMajorDirectionObjLst_Cache;
    }
    exports.vXzMajorDirection_GetObjLst_PureCache = vXzMajorDirection_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrMajorDirectionId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vXzMajorDirection_GetSubObjLst_Cache(objvXzMajorDirection_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_Cache();
        let arrvXzMajorDirection_Sel = arrvXzMajorDirectionObjLst_Cache;
        if (objvXzMajorDirection_Cond.sf_FldComparisonOp == null || objvXzMajorDirection_Cond.sf_FldComparisonOp == "")
            return arrvXzMajorDirection_Sel;
        const dicFldComparisonOp = JSON.parse(objvXzMajorDirection_Cond.sf_FldComparisonOp);
        //console.log("clsvXzMajorDirectionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvXzMajorDirection_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvXzMajorDirection_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvXzMajorDirection_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvXzMajorDirection_Cond), exports.vXzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vXzMajorDirection_GetSubObjLst_Cache = vXzMajorDirection_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrMajorDirectionId:关键字列表
    * @returns 对象列表
    **/
    async function vXzMajorDirection_GetObjLstByMajorDirectionIdLstAsync(arrMajorDirectionId) {
        const strThisFuncName = "GetObjLstByMajorDirectionIdLstAsync";
        const strAction = "GetObjLstByMajorDirectionIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrMajorDirectionId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzMajorDirection_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajorDirection_GetObjLstByMajorDirectionIdLstAsync = vXzMajorDirection_GetObjLstByMajorDirectionIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrMajorDirectionIdLst:关键字列表
     * @returns 对象列表
    */
    async function vXzMajorDirection_GetObjLstByMajorDirectionIdLst_Cache(arrMajorDirectionIdLst) {
        const strThisFuncName = "GetObjLstByMajorDirectionIdLst_Cache";
        try {
            const arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_Cache();
            const arrvXzMajorDirection_Sel = arrvXzMajorDirectionObjLst_Cache.filter(x => arrMajorDirectionIdLst.indexOf(x.majorDirectionId) > -1);
            return arrvXzMajorDirection_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrMajorDirectionIdLst.join(","), exports.vXzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vXzMajorDirection_GetObjLstByMajorDirectionIdLst_Cache = vXzMajorDirection_GetObjLstByMajorDirectionIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vXzMajorDirection_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzMajorDirection_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajorDirection_GetTopObjLstAsync = vXzMajorDirection_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vXzMajorDirection_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzMajorDirection_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajorDirection_GetObjLstByRangeAsync = vXzMajorDirection_GetObjLstByRangeAsync;
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
    async function vXzMajorDirection_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajorDirection_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajorDirection_GetObjLstByRange = vXzMajorDirection_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vXzMajorDirection_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_Cache();
        if (arrvXzMajorDirectionObjLst_Cache.length == 0)
            return arrvXzMajorDirectionObjLst_Cache;
        let arrvXzMajorDirection_Sel = arrvXzMajorDirectionObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvXzMajorDirection_Cond = new clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvXzMajorDirection_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvXzMajorDirectionWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvXzMajorDirection_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvXzMajorDirection_Sel.length == 0)
                return arrvXzMajorDirection_Sel;
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
                arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.sort(vXzMajorDirection_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.sort(objPagerPara.sortFun);
            }
            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.slice(intStart, intEnd);
            return arrvXzMajorDirection_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vXzMajorDirection_GetObjLstByPager_Cache = vXzMajorDirection_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vXzMajorDirection_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzMajorDirection_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajorDirection_GetObjLstByPagerAsync = vXzMajorDirection_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrMajorDirectionId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vXzMajorDirection_IsExistRecord_Cache(objvXzMajorDirection_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_Cache();
        if (arrvXzMajorDirectionObjLst_Cache == null)
            return false;
        let arrvXzMajorDirection_Sel = arrvXzMajorDirectionObjLst_Cache;
        if (objvXzMajorDirection_Cond.sf_FldComparisonOp == null || objvXzMajorDirection_Cond.sf_FldComparisonOp == "")
            return arrvXzMajorDirection_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvXzMajorDirection_Cond.sf_FldComparisonOp);
        //console.log("clsvXzMajorDirectionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvXzMajorDirection_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvXzMajorDirection_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvXzMajorDirection_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvXzMajorDirection_Cond), exports.vXzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vXzMajorDirection_IsExistRecord_Cache = vXzMajorDirection_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vXzMajorDirection_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajorDirection_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajorDirection_IsExistRecordAsync = vXzMajorDirection_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strMajorDirectionId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vXzMajorDirection_IsExist(strMajorDirectionId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "MajorDirectionId": strMajorDirectionId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajorDirection_IsExist = vXzMajorDirection_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strMajorDirectionId:所给的关键字
     * @returns 对象
    */
    async function vXzMajorDirection_IsExist_Cache(strMajorDirectionId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_Cache();
        if (arrvXzMajorDirectionObjLst_Cache == null)
            return false;
        try {
            const arrvXzMajorDirection_Sel = arrvXzMajorDirectionObjLst_Cache.filter(x => x.majorDirectionId == strMajorDirectionId);
            if (arrvXzMajorDirection_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strMajorDirectionId, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vXzMajorDirection_IsExist_Cache = vXzMajorDirection_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strMajorDirectionId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vXzMajorDirection_IsExistAsync(strMajorDirectionId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajorDirection_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strMajorDirectionId": strMajorDirectionId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajorDirection_IsExistAsync = vXzMajorDirection_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vXzMajorDirection_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajorDirection_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajorDirection_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajorDirection_GetRecCountByCondAsync = vXzMajorDirection_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvXzMajorDirection_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vXzMajorDirection_GetRecCountByCond_Cache(objvXzMajorDirection_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_Cache();
        if (arrvXzMajorDirectionObjLst_Cache == null)
            return 0;
        let arrvXzMajorDirection_Sel = arrvXzMajorDirectionObjLst_Cache;
        if (objvXzMajorDirection_Cond.sf_FldComparisonOp == null || objvXzMajorDirection_Cond.sf_FldComparisonOp == "")
            return arrvXzMajorDirection_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvXzMajorDirection_Cond.sf_FldComparisonOp);
        //console.log("clsvXzMajorDirectionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvXzMajorDirection_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvXzMajorDirection_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvXzMajorDirection_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvXzMajorDirection_Cond), exports.vXzMajorDirection_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vXzMajorDirection_GetRecCountByCond_Cache = vXzMajorDirection_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vXzMajorDirection_GetWebApiUrl(strController, strAction) {
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
    exports.vXzMajorDirection_GetWebApiUrl = vXzMajorDirection_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vXzMajorDirection_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN._CurrTabName;
            switch (clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.CacheModeId) {
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
    exports.vXzMajorDirection_ReFreshThisCache = vXzMajorDirection_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vXzMajorDirection_GetJSONStrByObj(pobjvXzMajorDirectionEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvXzMajorDirectionEN);
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
    exports.vXzMajorDirection_GetJSONStrByObj = vXzMajorDirection_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vXzMajorDirection_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvXzMajorDirectionObjLst = new Array();
        if (strJSON === "") {
            return arrvXzMajorDirectionObjLst;
        }
        try {
            arrvXzMajorDirectionObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvXzMajorDirectionObjLst;
        }
        return arrvXzMajorDirectionObjLst;
    }
    exports.vXzMajorDirection_GetObjLstByJSONStr = vXzMajorDirection_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvXzMajorDirectionObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vXzMajorDirection_GetObjLstByJSONObjLst(arrvXzMajorDirectionObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvXzMajorDirectionObjLst = new Array();
        for (const objInFor of arrvXzMajorDirectionObjLstS) {
            const obj1 = vXzMajorDirection_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvXzMajorDirectionObjLst.push(obj1);
        }
        return arrvXzMajorDirectionObjLst;
    }
    exports.vXzMajorDirection_GetObjLstByJSONObjLst = vXzMajorDirection_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vXzMajorDirection_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvXzMajorDirectionEN = new clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN();
        if (strJSON === "") {
            return pobjvXzMajorDirectionEN;
        }
        try {
            pobjvXzMajorDirectionEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvXzMajorDirectionEN;
        }
        return pobjvXzMajorDirectionEN;
    }
    exports.vXzMajorDirection_GetObjByJSONStr = vXzMajorDirection_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vXzMajorDirection_GetCombineCondition(objvXzMajorDirection_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionId) == true) {
            const strComparisonOp_MajorDirectionId = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionId, objvXzMajorDirection_Cond.majorDirectionId, strComparisonOp_MajorDirectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_id_XzMajor, objvXzMajorDirection_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorID) == true) {
            const strComparisonOp_MajorID = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorID, objvXzMajorDirection_Cond.majorID, strComparisonOp_MajorID);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorName, objvXzMajorDirection_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionName) == true) {
            const strComparisonOp_MajorDirectionName = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionName, objvXzMajorDirection_Cond.majorDirectionName, strComparisonOp_MajorDirectionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionENName) == true) {
            const strComparisonOp_MajorDirectionENName = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionENName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionENName, objvXzMajorDirection_Cond.majorDirectionENName, strComparisonOp_MajorDirectionENName);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionExplain) == true) {
            const strComparisonOp_MajorDirectionExplain = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionExplain];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_MajorDirectionExplain, objvXzMajorDirection_Cond.majorDirectionExplain, strComparisonOp_MajorDirectionExplain);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_IsVisible) == true) {
            if (objvXzMajorDirection_Cond.isVisible == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_IsVisible);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_IsVisible);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdDate, objvXzMajorDirection_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_UpdUser, objvXzMajorDirection_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN.con_Memo, objvXzMajorDirection_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.vXzMajorDirection_GetCombineCondition = vXzMajorDirection_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvXzMajorDirectionENS:源对象
     * @param objvXzMajorDirectionENT:目标对象
    */
    function vXzMajorDirection_CopyObjTo(objvXzMajorDirectionENS, objvXzMajorDirectionENT) {
        objvXzMajorDirectionENT.majorDirectionId = objvXzMajorDirectionENS.majorDirectionId; //研究方向Id
        objvXzMajorDirectionENT.id_XzMajor = objvXzMajorDirectionENS.id_XzMajor; //专业流水号
        objvXzMajorDirectionENT.majorID = objvXzMajorDirectionENS.majorID; //专业ID
        objvXzMajorDirectionENT.majorName = objvXzMajorDirectionENS.majorName; //专业名称
        objvXzMajorDirectionENT.majorDirectionName = objvXzMajorDirectionENS.majorDirectionName; //研究方向名
        objvXzMajorDirectionENT.majorDirectionENName = objvXzMajorDirectionENS.majorDirectionENName; //研究方向英文名
        objvXzMajorDirectionENT.majorDirectionExplain = objvXzMajorDirectionENS.majorDirectionExplain; //专业方向说明
        objvXzMajorDirectionENT.isVisible = objvXzMajorDirectionENS.isVisible; //是否显示
        objvXzMajorDirectionENT.updDate = objvXzMajorDirectionENS.updDate; //修改日期
        objvXzMajorDirectionENT.updUser = objvXzMajorDirectionENS.updUser; //修改人
        objvXzMajorDirectionENT.memo = objvXzMajorDirectionENS.memo; //备注
    }
    exports.vXzMajorDirection_CopyObjTo = vXzMajorDirection_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvXzMajorDirectionENS:源对象
     * @param objvXzMajorDirectionENT:目标对象
    */
    function vXzMajorDirection_GetObjFromJsonObj(objvXzMajorDirectionENS) {
        const objvXzMajorDirectionENT = new clsvXzMajorDirectionEN_js_1.clsvXzMajorDirectionEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvXzMajorDirectionENT, objvXzMajorDirectionENS);
        return objvXzMajorDirectionENT;
    }
    exports.vXzMajorDirection_GetObjFromJsonObj = vXzMajorDirection_GetObjFromJsonObj;
});
