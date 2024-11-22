/**
* 类名:clsvgs_UserConfigWApi
* 表名:vgs_UserConfig(01120691)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:46:36
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:考试管理(ExamManage)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/ExamManage/clsvgs_UserConfigEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_UserConfig_GetObjFromJsonObj = exports.vgs_UserConfig_CopyObjTo = exports.vgs_UserConfig_GetCombineCondition = exports.vgs_UserConfig_GetObjByJSONStr = exports.vgs_UserConfig_GetObjLstByJSONObjLst = exports.vgs_UserConfig_GetObjLstByJSONStr = exports.vgs_UserConfig_GetJSONStrByObj = exports.vgs_UserConfig_ReFreshThisCache = exports.vgs_UserConfig_GetWebApiUrl = exports.vgs_UserConfig_GetRecCountByCond_Cache = exports.vgs_UserConfig_GetRecCountByCondAsync = exports.vgs_UserConfig_IsExistAsync = exports.vgs_UserConfig_IsExist_Cache = exports.vgs_UserConfig_IsExist = exports.vgs_UserConfig_IsExistRecordAsync = exports.vgs_UserConfig_IsExistRecord_Cache = exports.vgs_UserConfig_GetObjLstByPagerAsync = exports.vgs_UserConfig_GetObjLstByPager_Cache = exports.vgs_UserConfig_GetObjLstByRange = exports.vgs_UserConfig_GetObjLstByRangeAsync = exports.vgs_UserConfig_GetTopObjLstAsync = exports.vgs_UserConfig_GetObjLstByConfigIdLst_Cache = exports.vgs_UserConfig_GetObjLstByConfigIdLstAsync = exports.vgs_UserConfig_GetSubObjLst_Cache = exports.vgs_UserConfig_GetObjLst_PureCache = exports.vgs_UserConfig_GetObjLst_Cache = exports.vgs_UserConfig_GetObjLst_sessionStorage_PureCache = exports.vgs_UserConfig_GetObjLst_sessionStorage = exports.vgs_UserConfig_GetObjLstAsync = exports.vgs_UserConfig_GetObjLst_localStorage_PureCache = exports.vgs_UserConfig_GetObjLst_localStorage = exports.vgs_UserConfig_GetObjLst_ClientCache = exports.vgs_UserConfig_GetFirstObjAsync = exports.vgs_UserConfig_GetFirstID = exports.vgs_UserConfig_GetFirstIDAsync = exports.vgs_UserConfig_funcKey = exports.vgs_UserConfig_FilterFunByKey = exports.vgs_UserConfig_SortFunByKey = exports.vgs_UserConfig_SortFun_Defa_2Fld = exports.vgs_UserConfig_SortFun_Defa = exports.vgs_UserConfig_func = exports.vgs_UserConfig_GetObjByConfigId_localStorage = exports.vgs_UserConfig_GetObjByConfigId_Cache = exports.vgs_UserConfig_GetObjByConfigIdAsync = exports.vgs_UserConfig_ConstructorName = exports.vgs_UserConfig_Controller = void 0;
    /**
     * 用户配置视图(vgs_UserConfig)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvgs_UserConfigEN_js_1 = require("../../L0_Entity/ExamManage/clsvgs_UserConfigEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vgs_UserConfig_Controller = "vgs_UserConfigApi";
    exports.vgs_UserConfig_ConstructorName = "vgs_UserConfig";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngConfigId:关键字
    * @returns 对象
    **/
    async function vgs_UserConfig_GetObjByConfigIdAsync(lngConfigId) {
        const strThisFuncName = "GetObjByConfigIdAsync";
        if (lngConfigId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngConfigId]不能为空！(In clsvgs_UserConfigWApi.GetObjByConfigIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByConfigId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_UserConfig_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngConfigId": lngConfigId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvgs_UserConfig = vgs_UserConfig_GetObjFromJsonObj(returnObj);
                return objvgs_UserConfig;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_UserConfig_GetObjByConfigIdAsync = vgs_UserConfig_GetObjByConfigIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngConfigId:所给的关键字
     * @returns 对象
    */
    async function vgs_UserConfig_GetObjByConfigId_Cache(lngConfigId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByConfigId_Cache";
        if (lngConfigId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngConfigId]不能为空！(In clsvgs_UserConfigWApi.GetObjByConfigId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvgs_UserConfigObjLst_Cache = await vgs_UserConfig_GetObjLst_Cache();
        try {
            const arrvgs_UserConfig_Sel = arrvgs_UserConfigObjLst_Cache.filter(x => x.configId == lngConfigId);
            let objvgs_UserConfig;
            if (arrvgs_UserConfig_Sel.length > 0) {
                objvgs_UserConfig = arrvgs_UserConfig_Sel[0];
                return objvgs_UserConfig;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvgs_UserConfig_Const = await vgs_UserConfig_GetObjByConfigIdAsync(lngConfigId);
                    if (objvgs_UserConfig_Const != null) {
                        vgs_UserConfig_ReFreshThisCache();
                        return objvgs_UserConfig_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngConfigId, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vgs_UserConfig_GetObjByConfigId_Cache = vgs_UserConfig_GetObjByConfigId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngConfigId:所给的关键字
     * @returns 对象
    */
    async function vgs_UserConfig_GetObjByConfigId_localStorage(lngConfigId) {
        const strThisFuncName = "GetObjByConfigId_localStorage";
        if (lngConfigId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngConfigId]不能为空！(In clsvgs_UserConfigWApi.GetObjByConfigId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN._CurrTabName, lngConfigId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvgs_UserConfig_Cache = JSON.parse(strTempObj);
            return objvgs_UserConfig_Cache;
        }
        try {
            const objvgs_UserConfig = await vgs_UserConfig_GetObjByConfigIdAsync(lngConfigId);
            if (objvgs_UserConfig != null) {
                localStorage.setItem(strKey, JSON.stringify(objvgs_UserConfig));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvgs_UserConfig;
            }
            return objvgs_UserConfig;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngConfigId, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vgs_UserConfig_GetObjByConfigId_localStorage = vgs_UserConfig_GetObjByConfigId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function vgs_UserConfig_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngConfigId = Number(strInValue);
        if (lngConfigId == 0) {
            return "";
        }
        const objvgs_UserConfig = await vgs_UserConfig_GetObjByConfigId_Cache(lngConfigId);
        if (objvgs_UserConfig == null)
            return "";
        if (objvgs_UserConfig.GetFldValue(strOutFldName) == null)
            return "";
        return objvgs_UserConfig.GetFldValue(strOutFldName).toString();
    }
    exports.vgs_UserConfig_func = vgs_UserConfig_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_UserConfig_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.configId - b.configId;
    }
    exports.vgs_UserConfig_SortFun_Defa = vgs_UserConfig_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_UserConfig_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.configTypeId == b.configTypeId)
            return a.configTypeName.localeCompare(b.configTypeName);
        else
            return a.configTypeId.localeCompare(b.configTypeId);
    }
    exports.vgs_UserConfig_SortFun_Defa_2Fld = vgs_UserConfig_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_UserConfig_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigId:
                    return (a, b) => {
                        return a.configId - b.configId;
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigTypeId:
                    return (a, b) => {
                        return a.configTypeId.localeCompare(b.configTypeId);
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigTypeName:
                    return (a, b) => {
                        if (a.configTypeName == null)
                            return -1;
                        if (b.configTypeName == null)
                            return 1;
                        return a.configTypeName.localeCompare(b.configTypeName);
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_DataTable:
                    return (a, b) => {
                        if (a.dataTable == null)
                            return -1;
                        if (b.dataTable == null)
                            return 1;
                        return a.dataTable.localeCompare(b.dataTable);
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_DataTableId:
                    return (a, b) => {
                        if (a.dataTableId == null)
                            return -1;
                        if (b.dataTableId == null)
                            return 1;
                        return a.dataTableId.localeCompare(b.dataTableId);
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ShareName:
                    return (a, b) => {
                        if (a.shareName == null)
                            return -1;
                        if (b.shareName == null)
                            return 1;
                        return a.shareName.localeCompare(b.shareName);
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_UserConfig]中不存在！(in ${exports.vgs_UserConfig_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigId:
                    return (a, b) => {
                        return b.configId - a.configId;
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigTypeId:
                    return (a, b) => {
                        return b.configTypeId.localeCompare(a.configTypeId);
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigTypeName:
                    return (a, b) => {
                        if (b.configTypeName == null)
                            return -1;
                        if (a.configTypeName == null)
                            return 1;
                        return b.configTypeName.localeCompare(a.configTypeName);
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_DataTable:
                    return (a, b) => {
                        if (b.dataTable == null)
                            return -1;
                        if (a.dataTable == null)
                            return 1;
                        return b.dataTable.localeCompare(a.dataTable);
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_DataTableId:
                    return (a, b) => {
                        if (b.dataTableId == null)
                            return -1;
                        if (a.dataTableId == null)
                            return 1;
                        return b.dataTableId.localeCompare(a.dataTableId);
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ShareName:
                    return (a, b) => {
                        if (b.shareName == null)
                            return -1;
                        if (a.shareName == null)
                            return 1;
                        return b.shareName.localeCompare(a.shareName);
                    };
                case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_UserConfig]中不存在！(in ${exports.vgs_UserConfig_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vgs_UserConfig_SortFunByKey = vgs_UserConfig_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_UserConfig_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigId:
                return (obj) => {
                    return obj.configId === value;
                };
            case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigTypeId:
                return (obj) => {
                    return obj.configTypeId === value;
                };
            case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigTypeName:
                return (obj) => {
                    return obj.configTypeName === value;
                };
            case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_DataTable:
                return (obj) => {
                    return obj.dataTable === value;
                };
            case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_DataTableId:
                return (obj) => {
                    return obj.dataTableId === value;
                };
            case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ShareName:
                return (obj) => {
                    return obj.shareName === value;
                };
            case clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vgs_UserConfig]中不存在！(in ${exports.vgs_UserConfig_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vgs_UserConfig_FilterFunByKey = vgs_UserConfig_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function vgs_UserConfig_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrvgs_UserConfig = await vgs_UserConfig_GetObjLst_Cache();
        if (arrvgs_UserConfig == null)
            return [];
        let arrvgs_UserConfig_Sel = arrvgs_UserConfig;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvgs_UserConfig_Sel.length == 0)
            return [];
        return arrvgs_UserConfig_Sel.map(x => x.configId);
    }
    exports.vgs_UserConfig_funcKey = vgs_UserConfig_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vgs_UserConfig_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_UserConfig_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_UserConfig_GetFirstIDAsync = vgs_UserConfig_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vgs_UserConfig_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_UserConfig_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_UserConfig_GetFirstID = vgs_UserConfig_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vgs_UserConfig_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_UserConfig_Controller, strAction);
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
                const objvgs_UserConfig = vgs_UserConfig_GetObjFromJsonObj(returnObj);
                return objvgs_UserConfig;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_UserConfig_GetFirstObjAsync = vgs_UserConfig_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_UserConfig_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvgs_UserConfigExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvgs_UserConfigObjLst_T = vgs_UserConfig_GetObjLstByJSONObjLst(arrvgs_UserConfigExObjLst_Cache);
            return arrvgs_UserConfigObjLst_T;
        }
        try {
            const arrvgs_UserConfigExObjLst = await vgs_UserConfig_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvgs_UserConfigExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_UserConfigExObjLst.length);
            console.log(strInfo);
            return arrvgs_UserConfigExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_UserConfig_GetObjLst_ClientCache = vgs_UserConfig_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_UserConfig_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvgs_UserConfigExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvgs_UserConfigObjLst_T = vgs_UserConfig_GetObjLstByJSONObjLst(arrvgs_UserConfigExObjLst_Cache);
            return arrvgs_UserConfigObjLst_T;
        }
        try {
            const arrvgs_UserConfigExObjLst = await vgs_UserConfig_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvgs_UserConfigExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_UserConfigExObjLst.length);
            console.log(strInfo);
            return arrvgs_UserConfigExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_UserConfig_GetObjLst_localStorage = vgs_UserConfig_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_UserConfig_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvgs_UserConfigObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvgs_UserConfigObjLst_Cache;
        }
        else
            return null;
    }
    exports.vgs_UserConfig_GetObjLst_localStorage_PureCache = vgs_UserConfig_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vgs_UserConfig_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_UserConfig_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_UserConfig_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_UserConfig_GetObjLstAsync = vgs_UserConfig_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_UserConfig_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvgs_UserConfigExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvgs_UserConfigObjLst_T = vgs_UserConfig_GetObjLstByJSONObjLst(arrvgs_UserConfigExObjLst_Cache);
            return arrvgs_UserConfigObjLst_T;
        }
        try {
            const arrvgs_UserConfigExObjLst = await vgs_UserConfig_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvgs_UserConfigExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_UserConfigExObjLst.length);
            console.log(strInfo);
            return arrvgs_UserConfigExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_UserConfig_GetObjLst_sessionStorage = vgs_UserConfig_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_UserConfig_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvgs_UserConfigObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvgs_UserConfigObjLst_Cache;
        }
        else
            return null;
    }
    exports.vgs_UserConfig_GetObjLst_sessionStorage_PureCache = vgs_UserConfig_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_UserConfig_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvgs_UserConfigObjLst_Cache;
        switch (clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.CacheModeId) {
            case "04": //sessionStorage
                arrvgs_UserConfigObjLst_Cache = await vgs_UserConfig_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvgs_UserConfigObjLst_Cache = await vgs_UserConfig_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvgs_UserConfigObjLst_Cache = await vgs_UserConfig_GetObjLst_ClientCache();
                break;
            default:
                arrvgs_UserConfigObjLst_Cache = await vgs_UserConfig_GetObjLst_ClientCache();
                break;
        }
        const arrvgs_UserConfigObjLst = vgs_UserConfig_GetObjLstByJSONObjLst(arrvgs_UserConfigObjLst_Cache);
        return arrvgs_UserConfigObjLst_Cache;
    }
    exports.vgs_UserConfig_GetObjLst_Cache = vgs_UserConfig_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_UserConfig_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvgs_UserConfigObjLst_Cache;
        switch (clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.CacheModeId) {
            case "04": //sessionStorage
                arrvgs_UserConfigObjLst_Cache = await vgs_UserConfig_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvgs_UserConfigObjLst_Cache = await vgs_UserConfig_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvgs_UserConfigObjLst_Cache = null;
                break;
            default:
                arrvgs_UserConfigObjLst_Cache = null;
                break;
        }
        return arrvgs_UserConfigObjLst_Cache;
    }
    exports.vgs_UserConfig_GetObjLst_PureCache = vgs_UserConfig_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngConfigId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vgs_UserConfig_GetSubObjLst_Cache(objvgs_UserConfig_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvgs_UserConfigObjLst_Cache = await vgs_UserConfig_GetObjLst_Cache();
        let arrvgs_UserConfig_Sel = arrvgs_UserConfigObjLst_Cache;
        if (objvgs_UserConfig_Cond.sf_FldComparisonOp == null || objvgs_UserConfig_Cond.sf_FldComparisonOp == "")
            return arrvgs_UserConfig_Sel;
        const dicFldComparisonOp = JSON.parse(objvgs_UserConfig_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_UserConfigWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_UserConfig_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_UserConfig_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_UserConfig_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvgs_UserConfig_Cond), exports.vgs_UserConfig_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_UserConfig_GetSubObjLst_Cache = vgs_UserConfig_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrConfigId:关键字列表
    * @returns 对象列表
    **/
    async function vgs_UserConfig_GetObjLstByConfigIdLstAsync(arrConfigId) {
        const strThisFuncName = "GetObjLstByConfigIdLstAsync";
        const strAction = "GetObjLstByConfigIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_UserConfig_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrConfigId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_UserConfig_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_UserConfig_GetObjLstByConfigIdLstAsync = vgs_UserConfig_GetObjLstByConfigIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngConfigIdLst:关键字列表
     * @returns 对象列表
    */
    async function vgs_UserConfig_GetObjLstByConfigIdLst_Cache(arrConfigIdLst) {
        const strThisFuncName = "GetObjLstByConfigIdLst_Cache";
        try {
            const arrvgs_UserConfigObjLst_Cache = await vgs_UserConfig_GetObjLst_Cache();
            const arrvgs_UserConfig_Sel = arrvgs_UserConfigObjLst_Cache.filter(x => arrConfigIdLst.indexOf(x.configId) > -1);
            return arrvgs_UserConfig_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrConfigIdLst.join(","), exports.vgs_UserConfig_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vgs_UserConfig_GetObjLstByConfigIdLst_Cache = vgs_UserConfig_GetObjLstByConfigIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vgs_UserConfig_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_UserConfig_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_UserConfig_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_UserConfig_GetTopObjLstAsync = vgs_UserConfig_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_UserConfig_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_UserConfig_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_UserConfig_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_UserConfig_GetObjLstByRangeAsync = vgs_UserConfig_GetObjLstByRangeAsync;
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
    async function vgs_UserConfig_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_UserConfig_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_UserConfig_GetObjLstByRange = vgs_UserConfig_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vgs_UserConfig_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvgs_UserConfigObjLst_Cache = await vgs_UserConfig_GetObjLst_Cache();
        if (arrvgs_UserConfigObjLst_Cache.length == 0)
            return arrvgs_UserConfigObjLst_Cache;
        let arrvgs_UserConfig_Sel = arrvgs_UserConfigObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvgs_UserConfig_Cond = new clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_UserConfig_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvgs_UserConfigWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_UserConfig_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_UserConfig_Sel.length == 0)
                return arrvgs_UserConfig_Sel;
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
                arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.sort(vgs_UserConfig_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.sort(objPagerPara.sortFun);
            }
            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.slice(intStart, intEnd);
            return arrvgs_UserConfig_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_UserConfig_GetObjLstByPager_Cache = vgs_UserConfig_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_UserConfig_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_UserConfig_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_UserConfig_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_UserConfig_GetObjLstByPagerAsync = vgs_UserConfig_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngConfigId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vgs_UserConfig_IsExistRecord_Cache(objvgs_UserConfig_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvgs_UserConfigObjLst_Cache = await vgs_UserConfig_GetObjLst_Cache();
        if (arrvgs_UserConfigObjLst_Cache == null)
            return false;
        let arrvgs_UserConfig_Sel = arrvgs_UserConfigObjLst_Cache;
        if (objvgs_UserConfig_Cond.sf_FldComparisonOp == null || objvgs_UserConfig_Cond.sf_FldComparisonOp == "")
            return arrvgs_UserConfig_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvgs_UserConfig_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_UserConfigWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_UserConfig_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_UserConfig_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_UserConfig_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvgs_UserConfig_Cond), exports.vgs_UserConfig_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vgs_UserConfig_IsExistRecord_Cache = vgs_UserConfig_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vgs_UserConfig_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_UserConfig_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_UserConfig_IsExistRecordAsync = vgs_UserConfig_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngConfigId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vgs_UserConfig_IsExist(lngConfigId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_UserConfig_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ConfigId": lngConfigId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_UserConfig_IsExist = vgs_UserConfig_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngConfigId:所给的关键字
     * @returns 对象
    */
    async function vgs_UserConfig_IsExist_Cache(lngConfigId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvgs_UserConfigObjLst_Cache = await vgs_UserConfig_GetObjLst_Cache();
        if (arrvgs_UserConfigObjLst_Cache == null)
            return false;
        try {
            const arrvgs_UserConfig_Sel = arrvgs_UserConfigObjLst_Cache.filter(x => x.configId == lngConfigId);
            if (arrvgs_UserConfig_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngConfigId, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vgs_UserConfig_IsExist_Cache = vgs_UserConfig_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngConfigId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vgs_UserConfig_IsExistAsync(lngConfigId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_UserConfig_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngConfigId": lngConfigId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_UserConfig_IsExistAsync = vgs_UserConfig_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vgs_UserConfig_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_UserConfig_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_UserConfig_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_UserConfig_GetRecCountByCondAsync = vgs_UserConfig_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvgs_UserConfig_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vgs_UserConfig_GetRecCountByCond_Cache(objvgs_UserConfig_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvgs_UserConfigObjLst_Cache = await vgs_UserConfig_GetObjLst_Cache();
        if (arrvgs_UserConfigObjLst_Cache == null)
            return 0;
        let arrvgs_UserConfig_Sel = arrvgs_UserConfigObjLst_Cache;
        if (objvgs_UserConfig_Cond.sf_FldComparisonOp == null || objvgs_UserConfig_Cond.sf_FldComparisonOp == "")
            return arrvgs_UserConfig_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvgs_UserConfig_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_UserConfigWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_UserConfig_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_UserConfig_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_UserConfig_Sel = arrvgs_UserConfig_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_UserConfig_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvgs_UserConfig_Cond), exports.vgs_UserConfig_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vgs_UserConfig_GetRecCountByCond_Cache = vgs_UserConfig_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vgs_UserConfig_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_UserConfig_GetWebApiUrl = vgs_UserConfig_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vgs_UserConfig_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN._CurrTabName;
            switch (clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.CacheModeId) {
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
    exports.vgs_UserConfig_ReFreshThisCache = vgs_UserConfig_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_UserConfig_GetJSONStrByObj(pobjvgs_UserConfigEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvgs_UserConfigEN);
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
    exports.vgs_UserConfig_GetJSONStrByObj = vgs_UserConfig_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vgs_UserConfig_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvgs_UserConfigObjLst = new Array();
        if (strJSON === "") {
            return arrvgs_UserConfigObjLst;
        }
        try {
            arrvgs_UserConfigObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvgs_UserConfigObjLst;
        }
        return arrvgs_UserConfigObjLst;
    }
    exports.vgs_UserConfig_GetObjLstByJSONStr = vgs_UserConfig_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvgs_UserConfigObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vgs_UserConfig_GetObjLstByJSONObjLst(arrvgs_UserConfigObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvgs_UserConfigObjLst = new Array();
        for (const objInFor of arrvgs_UserConfigObjLstS) {
            const obj1 = vgs_UserConfig_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvgs_UserConfigObjLst.push(obj1);
        }
        return arrvgs_UserConfigObjLst;
    }
    exports.vgs_UserConfig_GetObjLstByJSONObjLst = vgs_UserConfig_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_UserConfig_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvgs_UserConfigEN = new clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN();
        if (strJSON === "") {
            return pobjvgs_UserConfigEN;
        }
        try {
            pobjvgs_UserConfigEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvgs_UserConfigEN;
        }
        return pobjvgs_UserConfigEN;
    }
    exports.vgs_UserConfig_GetObjByJSONStr = vgs_UserConfig_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vgs_UserConfig_GetCombineCondition(objvgs_UserConfig_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvgs_UserConfig_Cond.dicFldComparisonOp, clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigId) == true) {
            const strComparisonOp_ConfigId = objvgs_UserConfig_Cond.dicFldComparisonOp[clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigId, objvgs_UserConfig_Cond.configId, strComparisonOp_ConfigId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_UserConfig_Cond.dicFldComparisonOp, clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigTypeId) == true) {
            const strComparisonOp_ConfigTypeId = objvgs_UserConfig_Cond.dicFldComparisonOp[clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigTypeId, objvgs_UserConfig_Cond.configTypeId, strComparisonOp_ConfigTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_UserConfig_Cond.dicFldComparisonOp, clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigTypeName) == true) {
            const strComparisonOp_ConfigTypeName = objvgs_UserConfig_Cond.dicFldComparisonOp[clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ConfigTypeName, objvgs_UserConfig_Cond.configTypeName, strComparisonOp_ConfigTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_UserConfig_Cond.dicFldComparisonOp, clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvgs_UserConfig_Cond.dicFldComparisonOp[clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ShareId, objvgs_UserConfig_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_UserConfig_Cond.dicFldComparisonOp, clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_DataTable) == true) {
            const strComparisonOp_DataTable = objvgs_UserConfig_Cond.dicFldComparisonOp[clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_DataTable];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_DataTable, objvgs_UserConfig_Cond.dataTable, strComparisonOp_DataTable);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_UserConfig_Cond.dicFldComparisonOp, clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvgs_UserConfig_Cond.dicFldComparisonOp[clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_UpdUser, objvgs_UserConfig_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_UserConfig_Cond.dicFldComparisonOp, clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_DataTableId) == true) {
            const strComparisonOp_DataTableId = objvgs_UserConfig_Cond.dicFldComparisonOp[clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_DataTableId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_DataTableId, objvgs_UserConfig_Cond.dataTableId, strComparisonOp_DataTableId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_UserConfig_Cond.dicFldComparisonOp, clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvgs_UserConfig_Cond.dicFldComparisonOp[clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_UpdDate, objvgs_UserConfig_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_UserConfig_Cond.dicFldComparisonOp, clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ShareName) == true) {
            const strComparisonOp_ShareName = objvgs_UserConfig_Cond.dicFldComparisonOp[clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ShareName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_ShareName, objvgs_UserConfig_Cond.shareName, strComparisonOp_ShareName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_UserConfig_Cond.dicFldComparisonOp, clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvgs_UserConfig_Cond.dicFldComparisonOp[clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN.con_Memo, objvgs_UserConfig_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.vgs_UserConfig_GetCombineCondition = vgs_UserConfig_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvgs_UserConfigENS:源对象
     * @param objvgs_UserConfigENT:目标对象
    */
    function vgs_UserConfig_CopyObjTo(objvgs_UserConfigENS, objvgs_UserConfigENT) {
        objvgs_UserConfigENT.configId = objvgs_UserConfigENS.configId; //配置Id
        objvgs_UserConfigENT.configTypeId = objvgs_UserConfigENS.configTypeId; //配置类型Id
        objvgs_UserConfigENT.configTypeName = objvgs_UserConfigENS.configTypeName; //配置类型名称
        objvgs_UserConfigENT.shareId = objvgs_UserConfigENS.shareId; //分享Id
        objvgs_UserConfigENT.dataTable = objvgs_UserConfigENS.dataTable; //数据表
        objvgs_UserConfigENT.updUser = objvgs_UserConfigENS.updUser; //修改人
        objvgs_UserConfigENT.dataTableId = objvgs_UserConfigENS.dataTableId; //数据表Id
        objvgs_UserConfigENT.updDate = objvgs_UserConfigENS.updDate; //修改日期
        objvgs_UserConfigENT.shareName = objvgs_UserConfigENS.shareName; //分享名称
        objvgs_UserConfigENT.memo = objvgs_UserConfigENS.memo; //备注
    }
    exports.vgs_UserConfig_CopyObjTo = vgs_UserConfig_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvgs_UserConfigENS:源对象
     * @param objvgs_UserConfigENT:目标对象
    */
    function vgs_UserConfig_GetObjFromJsonObj(objvgs_UserConfigENS) {
        const objvgs_UserConfigENT = new clsvgs_UserConfigEN_js_1.clsvgs_UserConfigEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_UserConfigENT, objvgs_UserConfigENS);
        return objvgs_UserConfigENT;
    }
    exports.vgs_UserConfig_GetObjFromJsonObj = vgs_UserConfig_GetObjFromJsonObj;
});
