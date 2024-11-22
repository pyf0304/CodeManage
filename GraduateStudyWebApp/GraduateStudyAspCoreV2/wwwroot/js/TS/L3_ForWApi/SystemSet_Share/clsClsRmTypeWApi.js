/**
* 类名:clsClsRmTypeWApi
* 表名:ClsRmType(01120576)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/14 18:26:51
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:系统设置(SystemSet)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/SystemSet_Share/clsClsRmTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ClsRmType_GetObjFromJsonObj = exports.ClsRmType_CopyObjTo = exports.ClsRmType_GetCombineCondition = exports.ClsRmType_GetObjByJSONStr = exports.ClsRmType_GetObjLstByJSONObjLst = exports.ClsRmType_GetObjLstByJSONStr = exports.ClsRmType_GetJSONStrByObj = exports.ClsRmType_CheckProperty4Update = exports.ClsRmType_CheckPropertyNew = exports.ClsRmType_BindDdl_id_ClassRoomTypeInDiv_Cache = exports.ClsRmType_ReFreshThisCache = exports.ClsRmType_ReFreshCache = exports.ClsRmType_GetWebApiUrl = exports.ClsRmType_GetMaxStrIdByPrefix = exports.ClsRmType_GetRecCountByCond_Cache = exports.ClsRmType_GetRecCountByCondAsync = exports.ClsRmType_IsExistAsync = exports.ClsRmType_IsExist_Cache = exports.ClsRmType_IsExist = exports.ClsRmType_IsExistRecordAsync = exports.ClsRmType_IsExistRecord_Cache = exports.ClsRmType_UpdateWithConditionAsync = exports.ClsRmType_UpdateRecordAsync = exports.ClsRmType_AddNewRecordWithReturnKey = exports.ClsRmType_AddNewRecordWithReturnKeyAsync = exports.ClsRmType_AddNewRecordWithMaxIdAsync = exports.ClsRmType_AddNewRecordAsync = exports.ClsRmType_DelClsRmTypesByCondAsync = exports.ClsRmType_DelClsRmTypesAsync = exports.ClsRmType_DelRecordAsync = exports.ClsRmType_GetObjLstByPagerAsync = exports.ClsRmType_GetObjLstByPager_Cache = exports.ClsRmType_GetObjLstByRange = exports.ClsRmType_GetObjLstByRangeAsync = exports.ClsRmType_GetTopObjLstAsync = exports.ClsRmType_GetObjLstByid_ClassRoomTypeLst_Cache = exports.ClsRmType_GetObjLstByid_ClassRoomTypeLstAsync = exports.ClsRmType_GetSubObjLst_Cache = exports.ClsRmType_GetObjLst_PureCache = exports.ClsRmType_GetObjLst_Cache = exports.ClsRmType_GetObjLst_sessionStorage_PureCache = exports.ClsRmType_GetObjLst_sessionStorage = exports.ClsRmType_GetObjLstAsync = exports.ClsRmType_GetObjLst_localStorage_PureCache = exports.ClsRmType_GetObjLst_localStorage = exports.ClsRmType_GetObjLst_ClientCache = exports.ClsRmType_GetFirstObjAsync = exports.ClsRmType_GetFirstID = exports.ClsRmType_GetFirstIDAsync = exports.ClsRmType_funcKey = exports.ClsRmType_FilterFunByKey = exports.ClsRmType_SortFunByKey = exports.ClsRmType_SortFun_Defa_2Fld = exports.ClsRmType_SortFun_Defa = exports.ClsRmType_func = exports.ClsRmType_GetNameByid_ClassRoomType_Cache = exports.ClsRmType_UpdateObjInLst_Cache = exports.ClsRmType_GetObjByid_ClassRoomType_localStorage = exports.ClsRmType_GetObjByid_ClassRoomType_Cache = exports.ClsRmType_GetObjByid_ClassRoomTypeAsync = exports.clsRmType_ConstructorName = exports.clsRmType_Controller = void 0;
    /**
     * 教室类型(ClsRmType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月14日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsClsRmTypeEN_js_1 = require("../../L0_Entity/SystemSet_Share/clsClsRmTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.clsRmType_Controller = "ClsRmTypeApi";
    exports.clsRmType_ConstructorName = "clsRmType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_ClassRoomType:关键字
    * @returns 对象
    **/
    async function ClsRmType_GetObjByid_ClassRoomTypeAsync(strid_ClassRoomType) {
        const strThisFuncName = "GetObjByid_ClassRoomTypeAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_ClassRoomType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_ClassRoomType]不能为空！(In clsClsRmTypeWApi.GetObjByid_ClassRoomTypeAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_ClassRoomType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_ClassRoomType]的长度:[{0}]不正确！(clsClsRmTypeWApi.GetObjByid_ClassRoomTypeAsync)", strid_ClassRoomType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_ClassRoomType";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_ClassRoomType": strid_ClassRoomType,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objClsRmType = ClsRmType_GetObjFromJsonObj(returnObj);
                return objClsRmType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_GetObjByid_ClassRoomTypeAsync = ClsRmType_GetObjByid_ClassRoomTypeAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_ClassRoomType:所给的关键字
     * @returns 对象
    */
    async function ClsRmType_GetObjByid_ClassRoomType_Cache(strid_ClassRoomType, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_ClassRoomType_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_ClassRoomType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_ClassRoomType]不能为空！(In clsClsRmTypeWApi.GetObjByid_ClassRoomType_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_ClassRoomType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_ClassRoomType]的长度:[{0}]不正确！(clsClsRmTypeWApi.GetObjByid_ClassRoomType_Cache)", strid_ClassRoomType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrClsRmTypeObjLst_Cache = await ClsRmType_GetObjLst_Cache();
        try {
            const arrClsRmType_Sel = arrClsRmTypeObjLst_Cache.filter(x => x.id_ClassRoomType == strid_ClassRoomType);
            let objClsRmType;
            if (arrClsRmType_Sel.length > 0) {
                objClsRmType = arrClsRmType_Sel[0];
                return objClsRmType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objClsRmType_Const = await ClsRmType_GetObjByid_ClassRoomTypeAsync(strid_ClassRoomType);
                    if (objClsRmType_Const != null) {
                        ClsRmType_ReFreshThisCache();
                        return objClsRmType_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_ClassRoomType, exports.clsRmType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.ClsRmType_GetObjByid_ClassRoomType_Cache = ClsRmType_GetObjByid_ClassRoomType_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_ClassRoomType:所给的关键字
     * @returns 对象
    */
    async function ClsRmType_GetObjByid_ClassRoomType_localStorage(strid_ClassRoomType) {
        const strThisFuncName = "GetObjByid_ClassRoomType_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_ClassRoomType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_ClassRoomType]不能为空！(In clsClsRmTypeWApi.GetObjByid_ClassRoomType_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_ClassRoomType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_ClassRoomType]的长度:[{0}]不正确！(clsClsRmTypeWApi.GetObjByid_ClassRoomType_localStorage)", strid_ClassRoomType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsClsRmTypeEN_js_1.clsClsRmTypeEN._CurrTabName, strid_ClassRoomType);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objClsRmType_Cache = JSON.parse(strTempObj);
            return objClsRmType_Cache;
        }
        try {
            const objClsRmType = await ClsRmType_GetObjByid_ClassRoomTypeAsync(strid_ClassRoomType);
            if (objClsRmType != null) {
                localStorage.setItem(strKey, JSON.stringify(objClsRmType));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objClsRmType;
            }
            return objClsRmType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_ClassRoomType, exports.clsRmType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.ClsRmType_GetObjByid_ClassRoomType_localStorage = ClsRmType_GetObjByid_ClassRoomType_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objClsRmType:所给的对象
     * @returns 对象
    */
    async function ClsRmType_UpdateObjInLst_Cache(objClsRmType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrClsRmTypeObjLst_Cache = await ClsRmType_GetObjLst_Cache();
            const obj = arrClsRmTypeObjLst_Cache.find(x => x.id_ClassRoomType == objClsRmType.id_ClassRoomType);
            if (obj != null) {
                objClsRmType.id_ClassRoomType = obj.id_ClassRoomType;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objClsRmType);
            }
            else {
                arrClsRmTypeObjLst_Cache.push(objClsRmType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.clsRmType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.ClsRmType_UpdateObjInLst_Cache = ClsRmType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_ClassRoomType:所给的关键字
     * @returns 对象
    */
    async function ClsRmType_GetNameByid_ClassRoomType_Cache(strid_ClassRoomType) {
        const strThisFuncName = "GetNameByid_ClassRoomType_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_ClassRoomType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_ClassRoomType]不能为空！(In clsClsRmTypeWApi.GetNameByid_ClassRoomType_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_ClassRoomType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_ClassRoomType]的长度:[{0}]不正确！(clsClsRmTypeWApi.GetNameByid_ClassRoomType_Cache)", strid_ClassRoomType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrClsRmTypeObjLst_Cache = await ClsRmType_GetObjLst_Cache();
        if (arrClsRmTypeObjLst_Cache == null)
            return "";
        try {
            const arrClsRmType_Sel = arrClsRmTypeObjLst_Cache.filter(x => x.id_ClassRoomType == strid_ClassRoomType);
            let objClsRmType;
            if (arrClsRmType_Sel.length > 0) {
                objClsRmType = arrClsRmType_Sel[0];
                return objClsRmType.classRoomTypeDesc;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_ClassRoomType);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.ClsRmType_GetNameByid_ClassRoomType_Cache = ClsRmType_GetNameByid_ClassRoomType_Cache;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function ClsRmType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_id_ClassRoomType) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsClsRmTypeEN_js_1.clsClsRmTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsClsRmTypeEN_js_1.clsClsRmTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_ClassRoomType = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objClsRmType = await ClsRmType_GetObjByid_ClassRoomType_Cache(strid_ClassRoomType);
        if (objClsRmType == null)
            return "";
        if (objClsRmType.GetFldValue(strOutFldName) == null)
            return "";
        return objClsRmType.GetFldValue(strOutFldName).toString();
    }
    exports.ClsRmType_func = ClsRmType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ClsRmType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_ClassRoomType.localeCompare(b.id_ClassRoomType);
    }
    exports.ClsRmType_SortFun_Defa = ClsRmType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ClsRmType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.classRoomTypeID == b.classRoomTypeID)
            return a.classRoomTypeDesc.localeCompare(b.classRoomTypeDesc);
        else
            return a.classRoomTypeID.localeCompare(b.classRoomTypeID);
    }
    exports.ClsRmType_SortFun_Defa_2Fld = ClsRmType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ClsRmType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_id_ClassRoomType:
                    return (a, b) => {
                        return a.id_ClassRoomType.localeCompare(b.id_ClassRoomType);
                    };
                case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeID:
                    return (a, b) => {
                        if (a.classRoomTypeID == null)
                            return -1;
                        if (b.classRoomTypeID == null)
                            return 1;
                        return a.classRoomTypeID.localeCompare(b.classRoomTypeID);
                    };
                case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeDesc:
                    return (a, b) => {
                        if (a.classRoomTypeDesc == null)
                            return -1;
                        if (b.classRoomTypeDesc == null)
                            return 1;
                        return a.classRoomTypeDesc.localeCompare(b.classRoomTypeDesc);
                    };
                case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeDescA:
                    return (a, b) => {
                        if (a.classRoomTypeDescA == null)
                            return -1;
                        if (b.classRoomTypeDescA == null)
                            return 1;
                        return a.classRoomTypeDescA.localeCompare(b.classRoomTypeDescA);
                    };
                case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ModifyUserID:
                    return (a, b) => {
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ModifyDate:
                    return (a, b) => {
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ClsRmType]中不存在！(in ${exports.clsRmType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_id_ClassRoomType:
                    return (a, b) => {
                        return b.id_ClassRoomType.localeCompare(a.id_ClassRoomType);
                    };
                case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeID:
                    return (a, b) => {
                        if (b.classRoomTypeID == null)
                            return -1;
                        if (a.classRoomTypeID == null)
                            return 1;
                        return b.classRoomTypeID.localeCompare(a.classRoomTypeID);
                    };
                case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeDesc:
                    return (a, b) => {
                        if (b.classRoomTypeDesc == null)
                            return -1;
                        if (a.classRoomTypeDesc == null)
                            return 1;
                        return b.classRoomTypeDesc.localeCompare(a.classRoomTypeDesc);
                    };
                case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeDescA:
                    return (a, b) => {
                        if (b.classRoomTypeDescA == null)
                            return -1;
                        if (a.classRoomTypeDescA == null)
                            return 1;
                        return b.classRoomTypeDescA.localeCompare(a.classRoomTypeDescA);
                    };
                case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ModifyUserID:
                    return (a, b) => {
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ModifyDate:
                    return (a, b) => {
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ClsRmType]中不存在！(in ${exports.clsRmType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ClsRmType_SortFunByKey = ClsRmType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ClsRmType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_id_ClassRoomType:
                return (obj) => {
                    return obj.id_ClassRoomType === value;
                };
            case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeID:
                return (obj) => {
                    return obj.classRoomTypeID === value;
                };
            case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeDesc:
                return (obj) => {
                    return obj.classRoomTypeDesc === value;
                };
            case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeDescA:
                return (obj) => {
                    return obj.classRoomTypeDescA === value;
                };
            case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ClsRmType]中不存在！(in ${exports.clsRmType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ClsRmType_FilterFunByKey = ClsRmType_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function ClsRmType_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_id_ClassRoomType) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrClsRmType = await ClsRmType_GetObjLst_Cache();
        if (arrClsRmType == null)
            return [];
        let arrClsRmType_Sel = arrClsRmType;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrClsRmType_Sel = arrClsRmType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrClsRmType_Sel.length == 0)
            return [];
        return arrClsRmType_Sel.map(x => x.id_ClassRoomType);
    }
    exports.ClsRmType_funcKey = ClsRmType_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ClsRmType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_GetFirstIDAsync = ClsRmType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ClsRmType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_GetFirstID = ClsRmType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ClsRmType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
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
                const objClsRmType = ClsRmType_GetObjFromJsonObj(returnObj);
                return objClsRmType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_GetFirstObjAsync = ClsRmType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ClsRmType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsClsRmTypeEN_js_1.clsClsRmTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsClsRmTypeEN_js_1.clsClsRmTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsClsRmTypeEN_js_1.clsClsRmTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrClsRmTypeExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrClsRmTypeObjLst_T = ClsRmType_GetObjLstByJSONObjLst(arrClsRmTypeExObjLst_Cache);
            return arrClsRmTypeObjLst_T;
        }
        try {
            const arrClsRmTypeExObjLst = await ClsRmType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrClsRmTypeExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrClsRmTypeExObjLst.length);
            console.log(strInfo);
            return arrClsRmTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.clsRmType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ClsRmType_GetObjLst_ClientCache = ClsRmType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ClsRmType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsClsRmTypeEN_js_1.clsClsRmTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsClsRmTypeEN_js_1.clsClsRmTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsClsRmTypeEN_js_1.clsClsRmTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrClsRmTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrClsRmTypeObjLst_T = ClsRmType_GetObjLstByJSONObjLst(arrClsRmTypeExObjLst_Cache);
            return arrClsRmTypeObjLst_T;
        }
        try {
            const arrClsRmTypeExObjLst = await ClsRmType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrClsRmTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrClsRmTypeExObjLst.length);
            console.log(strInfo);
            return arrClsRmTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.clsRmType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ClsRmType_GetObjLst_localStorage = ClsRmType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ClsRmType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsClsRmTypeEN_js_1.clsClsRmTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrClsRmTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrClsRmTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.ClsRmType_GetObjLst_localStorage_PureCache = ClsRmType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ClsRmType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.clsRmType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ClsRmType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_GetObjLstAsync = ClsRmType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ClsRmType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsClsRmTypeEN_js_1.clsClsRmTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsClsRmTypeEN_js_1.clsClsRmTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsClsRmTypeEN_js_1.clsClsRmTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrClsRmTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrClsRmTypeObjLst_T = ClsRmType_GetObjLstByJSONObjLst(arrClsRmTypeExObjLst_Cache);
            return arrClsRmTypeObjLst_T;
        }
        try {
            const arrClsRmTypeExObjLst = await ClsRmType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrClsRmTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrClsRmTypeExObjLst.length);
            console.log(strInfo);
            return arrClsRmTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.clsRmType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ClsRmType_GetObjLst_sessionStorage = ClsRmType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ClsRmType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsClsRmTypeEN_js_1.clsClsRmTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrClsRmTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrClsRmTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.ClsRmType_GetObjLst_sessionStorage_PureCache = ClsRmType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ClsRmType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrClsRmTypeObjLst_Cache;
        switch (clsClsRmTypeEN_js_1.clsClsRmTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrClsRmTypeObjLst_Cache = await ClsRmType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrClsRmTypeObjLst_Cache = await ClsRmType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrClsRmTypeObjLst_Cache = await ClsRmType_GetObjLst_ClientCache();
                break;
            default:
                arrClsRmTypeObjLst_Cache = await ClsRmType_GetObjLst_ClientCache();
                break;
        }
        const arrClsRmTypeObjLst = ClsRmType_GetObjLstByJSONObjLst(arrClsRmTypeObjLst_Cache);
        return arrClsRmTypeObjLst_Cache;
    }
    exports.ClsRmType_GetObjLst_Cache = ClsRmType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ClsRmType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrClsRmTypeObjLst_Cache;
        switch (clsClsRmTypeEN_js_1.clsClsRmTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrClsRmTypeObjLst_Cache = await ClsRmType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrClsRmTypeObjLst_Cache = await ClsRmType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrClsRmTypeObjLst_Cache = null;
                break;
            default:
                arrClsRmTypeObjLst_Cache = null;
                break;
        }
        return arrClsRmTypeObjLst_Cache;
    }
    exports.ClsRmType_GetObjLst_PureCache = ClsRmType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_ClassRoomType_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ClsRmType_GetSubObjLst_Cache(objClsRmType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrClsRmTypeObjLst_Cache = await ClsRmType_GetObjLst_Cache();
        let arrClsRmType_Sel = arrClsRmTypeObjLst_Cache;
        if (objClsRmType_Cond.sf_FldComparisonOp == null || objClsRmType_Cond.sf_FldComparisonOp == "")
            return arrClsRmType_Sel;
        const dicFldComparisonOp = JSON.parse(objClsRmType_Cond.sf_FldComparisonOp);
        //console.log("clsClsRmTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objClsRmType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objClsRmType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrClsRmType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objClsRmType_Cond), exports.clsRmType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ClsRmType_GetSubObjLst_Cache = ClsRmType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_ClassRoomType:关键字列表
    * @returns 对象列表
    **/
    async function ClsRmType_GetObjLstByid_ClassRoomTypeLstAsync(arrid_ClassRoomType) {
        const strThisFuncName = "GetObjLstByid_ClassRoomTypeLstAsync";
        const strAction = "GetObjLstByid_ClassRoomTypeLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_ClassRoomType);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.clsRmType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ClsRmType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_GetObjLstByid_ClassRoomTypeLstAsync = ClsRmType_GetObjLstByid_ClassRoomTypeLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_ClassRoomTypeLst:关键字列表
     * @returns 对象列表
    */
    async function ClsRmType_GetObjLstByid_ClassRoomTypeLst_Cache(arrid_ClassRoomTypeLst) {
        const strThisFuncName = "GetObjLstByid_ClassRoomTypeLst_Cache";
        try {
            const arrClsRmTypeObjLst_Cache = await ClsRmType_GetObjLst_Cache();
            const arrClsRmType_Sel = arrClsRmTypeObjLst_Cache.filter(x => arrid_ClassRoomTypeLst.indexOf(x.id_ClassRoomType) > -1);
            return arrClsRmType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_ClassRoomTypeLst.join(","), exports.clsRmType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.ClsRmType_GetObjLstByid_ClassRoomTypeLst_Cache = ClsRmType_GetObjLstByid_ClassRoomTypeLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ClsRmType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.clsRmType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ClsRmType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_GetTopObjLstAsync = ClsRmType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ClsRmType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.clsRmType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ClsRmType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_GetObjLstByRangeAsync = ClsRmType_GetObjLstByRangeAsync;
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
    async function ClsRmType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_GetObjLstByRange = ClsRmType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function ClsRmType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrClsRmTypeObjLst_Cache = await ClsRmType_GetObjLst_Cache();
        if (arrClsRmTypeObjLst_Cache.length == 0)
            return arrClsRmTypeObjLst_Cache;
        let arrClsRmType_Sel = arrClsRmTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objClsRmType_Cond = new clsClsRmTypeEN_js_1.clsClsRmTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objClsRmType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsClsRmTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objClsRmType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrClsRmType_Sel.length == 0)
                return arrClsRmType_Sel;
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
                arrClsRmType_Sel = arrClsRmType_Sel.sort(ClsRmType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrClsRmType_Sel = arrClsRmType_Sel.sort(objPagerPara.sortFun);
            }
            arrClsRmType_Sel = arrClsRmType_Sel.slice(intStart, intEnd);
            return arrClsRmType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.clsRmType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ClsRmType_GetObjLstByPager_Cache = ClsRmType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ClsRmType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.clsRmType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ClsRmType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_GetObjLstByPagerAsync = ClsRmType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strid_ClassRoomType:关键字
    * @returns 获取删除的结果
    **/
    async function ClsRmType_DelRecordAsync(strid_ClassRoomType) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strid_ClassRoomType);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_DelRecordAsync = ClsRmType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_ClassRoomType:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ClsRmType_DelClsRmTypesAsync(arrid_ClassRoomType) {
        const strThisFuncName = "DelClsRmTypesAsync";
        const strAction = "DelClsRmTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_ClassRoomType);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_DelClsRmTypesAsync = ClsRmType_DelClsRmTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ClsRmType_DelClsRmTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelClsRmTypesByCondAsync";
        const strAction = "DelClsRmTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_DelClsRmTypesByCondAsync = ClsRmType_DelClsRmTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objClsRmTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ClsRmType_AddNewRecordAsync(objClsRmTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objClsRmTypeEN.id_ClassRoomType === null || objClsRmTypeEN.id_ClassRoomType === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objClsRmTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objClsRmTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_AddNewRecordAsync = ClsRmType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objClsRmTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ClsRmType_AddNewRecordWithMaxIdAsync(objClsRmTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objClsRmTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_AddNewRecordWithMaxIdAsync = ClsRmType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objClsRmTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ClsRmType_AddNewRecordWithReturnKeyAsync(objClsRmTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objClsRmTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_AddNewRecordWithReturnKeyAsync = ClsRmType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objClsRmTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ClsRmType_AddNewRecordWithReturnKey(objClsRmTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objClsRmTypeEN.id_ClassRoomType === null || objClsRmTypeEN.id_ClassRoomType === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objClsRmTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_AddNewRecordWithReturnKey = ClsRmType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objClsRmTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ClsRmType_UpdateRecordAsync(objClsRmTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objClsRmTypeEN.sf_UpdFldSetStr === undefined || objClsRmTypeEN.sf_UpdFldSetStr === null || objClsRmTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objClsRmTypeEN.id_ClassRoomType);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objClsRmTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_UpdateRecordAsync = ClsRmType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objClsRmTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ClsRmType_UpdateWithConditionAsync(objClsRmTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objClsRmTypeEN.sf_UpdFldSetStr === undefined || objClsRmTypeEN.sf_UpdFldSetStr === null || objClsRmTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objClsRmTypeEN.id_ClassRoomType);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
        objClsRmTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objClsRmTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_UpdateWithConditionAsync = ClsRmType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_ClassRoomType_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ClsRmType_IsExistRecord_Cache(objClsRmType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrClsRmTypeObjLst_Cache = await ClsRmType_GetObjLst_Cache();
        if (arrClsRmTypeObjLst_Cache == null)
            return false;
        let arrClsRmType_Sel = arrClsRmTypeObjLst_Cache;
        if (objClsRmType_Cond.sf_FldComparisonOp == null || objClsRmType_Cond.sf_FldComparisonOp == "")
            return arrClsRmType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objClsRmType_Cond.sf_FldComparisonOp);
        //console.log("clsClsRmTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objClsRmType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objClsRmType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrClsRmType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objClsRmType_Cond), exports.clsRmType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.ClsRmType_IsExistRecord_Cache = ClsRmType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ClsRmType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_IsExistRecordAsync = ClsRmType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_ClassRoomType:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ClsRmType_IsExist(strid_ClassRoomType, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_ClassRoomType": strid_ClassRoomType,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_IsExist = ClsRmType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_ClassRoomType:所给的关键字
     * @returns 对象
    */
    async function ClsRmType_IsExist_Cache(strid_ClassRoomType) {
        const strThisFuncName = "IsExist_Cache";
        const arrClsRmTypeObjLst_Cache = await ClsRmType_GetObjLst_Cache();
        if (arrClsRmTypeObjLst_Cache == null)
            return false;
        try {
            const arrClsRmType_Sel = arrClsRmTypeObjLst_Cache.filter(x => x.id_ClassRoomType == strid_ClassRoomType);
            if (arrClsRmType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_ClassRoomType, exports.clsRmType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.ClsRmType_IsExist_Cache = ClsRmType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_ClassRoomType:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ClsRmType_IsExistAsync(strid_ClassRoomType) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_ClassRoomType": strid_ClassRoomType }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_IsExistAsync = ClsRmType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ClsRmType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_GetRecCountByCondAsync = ClsRmType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objClsRmType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function ClsRmType_GetRecCountByCond_Cache(objClsRmType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrClsRmTypeObjLst_Cache = await ClsRmType_GetObjLst_Cache();
        if (arrClsRmTypeObjLst_Cache == null)
            return 0;
        let arrClsRmType_Sel = arrClsRmTypeObjLst_Cache;
        if (objClsRmType_Cond.sf_FldComparisonOp == null || objClsRmType_Cond.sf_FldComparisonOp == "")
            return arrClsRmType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objClsRmType_Cond.sf_FldComparisonOp);
        //console.log("clsClsRmTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objClsRmType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objClsRmType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrClsRmType_Sel = arrClsRmType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrClsRmType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objClsRmType_Cond), exports.clsRmType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.ClsRmType_GetRecCountByCond_Cache = ClsRmType_GetRecCountByCond_Cache;
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
    async function ClsRmType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.clsRmType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.clsRmType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ClsRmType_GetMaxStrIdByPrefix = ClsRmType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ClsRmType_GetWebApiUrl(strController, strAction) {
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
    exports.ClsRmType_GetWebApiUrl = ClsRmType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function ClsRmType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsClsRmTypeEN_js_1.clsClsRmTypeEN._CurrTabName;
        switch (clsClsRmTypeEN_js_1.clsClsRmTypeEN.CacheModeId) {
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
    }
    exports.ClsRmType_ReFreshCache = ClsRmType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function ClsRmType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsClsRmTypeEN_js_1.clsClsRmTypeEN._CurrTabName;
            switch (clsClsRmTypeEN_js_1.clsClsRmTypeEN.CacheModeId) {
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
    exports.ClsRmType_ReFreshThisCache = ClsRmType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function ClsRmType_BindDdl_id_ClassRoomTypeInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_id_ClassRoomTypeInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_id_ClassRoomTypeInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_id_ClassRoomTypeInDiv_Cache");
        const arrObjLst_Sel = await ClsRmType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_id_ClassRoomType, clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeDesc, "教室类型");
    }
    exports.ClsRmType_BindDdl_id_ClassRoomTypeInDiv_Cache = ClsRmType_BindDdl_id_ClassRoomTypeInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ClsRmType_CheckPropertyNew(pobjClsRmTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.modifyUserID) === true) {
            throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 教室类型)!(clsClsRmTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.modifyDate) === true) {
            throw new Error("(errid:Watl000058)字段[修改日期]不能为空(In 教室类型)!(clsClsRmTypeBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.id_ClassRoomType) == false && (0, clsString_js_2.GetStrLen)(pobjClsRmTypeEN.id_ClassRoomType) > 4) {
            throw new Error("(errid:Watl000059)字段[教室类型流水号(id_ClassRoomType)]的长度不能超过4(In 教室类型(ClsRmType))!值:$(pobjClsRmTypeEN.id_ClassRoomType)(clsClsRmTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.classRoomTypeID) == false && (0, clsString_js_2.GetStrLen)(pobjClsRmTypeEN.classRoomTypeID) > 4) {
            throw new Error("(errid:Watl000059)字段[教室类型代号(classRoomTypeID)]的长度不能超过4(In 教室类型(ClsRmType))!值:$(pobjClsRmTypeEN.classRoomTypeID)(clsClsRmTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.classRoomTypeDesc) == false && (0, clsString_js_2.GetStrLen)(pobjClsRmTypeEN.classRoomTypeDesc) > 100) {
            throw new Error("(errid:Watl000059)字段[教室类型描述(classRoomTypeDesc)]的长度不能超过100(In 教室类型(ClsRmType))!值:$(pobjClsRmTypeEN.classRoomTypeDesc)(clsClsRmTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.classRoomTypeDescA) == false && (0, clsString_js_2.GetStrLen)(pobjClsRmTypeEN.classRoomTypeDescA) > 100) {
            throw new Error("(errid:Watl000059)字段[教室类型简称(classRoomTypeDescA)]的长度不能超过100(In 教室类型(ClsRmType))!值:$(pobjClsRmTypeEN.classRoomTypeDescA)(clsClsRmTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.modifyUserID) == false && (0, clsString_js_2.GetStrLen)(pobjClsRmTypeEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 教室类型(ClsRmType))!值:$(pobjClsRmTypeEN.modifyUserID)(clsClsRmTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.modifyDate) == false && (0, clsString_js_2.GetStrLen)(pobjClsRmTypeEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 教室类型(ClsRmType))!值:$(pobjClsRmTypeEN.modifyDate)(clsClsRmTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjClsRmTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 教室类型(ClsRmType))!值:$(pobjClsRmTypeEN.memo)(clsClsRmTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.id_ClassRoomType) == false && undefined !== pobjClsRmTypeEN.id_ClassRoomType && clsString_js_1.tzDataType.isString(pobjClsRmTypeEN.id_ClassRoomType) === false) {
            throw new Error("(errid:Watl000060)字段[教室类型流水号(id_ClassRoomType)]的值:[$(pobjClsRmTypeEN.id_ClassRoomType)], 非法，应该为字符型(In 教室类型(ClsRmType))!(clsClsRmTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.classRoomTypeID) == false && undefined !== pobjClsRmTypeEN.classRoomTypeID && clsString_js_1.tzDataType.isString(pobjClsRmTypeEN.classRoomTypeID) === false) {
            throw new Error("(errid:Watl000060)字段[教室类型代号(classRoomTypeID)]的值:[$(pobjClsRmTypeEN.classRoomTypeID)], 非法，应该为字符型(In 教室类型(ClsRmType))!(clsClsRmTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.classRoomTypeDesc) == false && undefined !== pobjClsRmTypeEN.classRoomTypeDesc && clsString_js_1.tzDataType.isString(pobjClsRmTypeEN.classRoomTypeDesc) === false) {
            throw new Error("(errid:Watl000060)字段[教室类型描述(classRoomTypeDesc)]的值:[$(pobjClsRmTypeEN.classRoomTypeDesc)], 非法，应该为字符型(In 教室类型(ClsRmType))!(clsClsRmTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.classRoomTypeDescA) == false && undefined !== pobjClsRmTypeEN.classRoomTypeDescA && clsString_js_1.tzDataType.isString(pobjClsRmTypeEN.classRoomTypeDescA) === false) {
            throw new Error("(errid:Watl000060)字段[教室类型简称(classRoomTypeDescA)]的值:[$(pobjClsRmTypeEN.classRoomTypeDescA)], 非法，应该为字符型(In 教室类型(ClsRmType))!(clsClsRmTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.modifyUserID) == false && undefined !== pobjClsRmTypeEN.modifyUserID && clsString_js_1.tzDataType.isString(pobjClsRmTypeEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjClsRmTypeEN.modifyUserID)], 非法，应该为字符型(In 教室类型(ClsRmType))!(clsClsRmTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.modifyDate) == false && undefined !== pobjClsRmTypeEN.modifyDate && clsString_js_1.tzDataType.isString(pobjClsRmTypeEN.modifyDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjClsRmTypeEN.modifyDate)], 非法，应该为字符型(In 教室类型(ClsRmType))!(clsClsRmTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.memo) == false && undefined !== pobjClsRmTypeEN.memo && clsString_js_1.tzDataType.isString(pobjClsRmTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjClsRmTypeEN.memo)], 非法，应该为字符型(In 教室类型(ClsRmType))!(clsClsRmTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjClsRmTypeEN.SetIsCheckProperty(true);
    }
    exports.ClsRmType_CheckPropertyNew = ClsRmType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ClsRmType_CheckProperty4Update(pobjClsRmTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.id_ClassRoomType) == false && (0, clsString_js_2.GetStrLen)(pobjClsRmTypeEN.id_ClassRoomType) > 4) {
            throw new Error("(errid:Watl000062)字段[教室类型流水号(id_ClassRoomType)]的长度不能超过4(In 教室类型(ClsRmType))!值:$(pobjClsRmTypeEN.id_ClassRoomType)(clsClsRmTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.classRoomTypeID) == false && (0, clsString_js_2.GetStrLen)(pobjClsRmTypeEN.classRoomTypeID) > 4) {
            throw new Error("(errid:Watl000062)字段[教室类型代号(classRoomTypeID)]的长度不能超过4(In 教室类型(ClsRmType))!值:$(pobjClsRmTypeEN.classRoomTypeID)(clsClsRmTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.classRoomTypeDesc) == false && (0, clsString_js_2.GetStrLen)(pobjClsRmTypeEN.classRoomTypeDesc) > 100) {
            throw new Error("(errid:Watl000062)字段[教室类型描述(classRoomTypeDesc)]的长度不能超过100(In 教室类型(ClsRmType))!值:$(pobjClsRmTypeEN.classRoomTypeDesc)(clsClsRmTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.classRoomTypeDescA) == false && (0, clsString_js_2.GetStrLen)(pobjClsRmTypeEN.classRoomTypeDescA) > 100) {
            throw new Error("(errid:Watl000062)字段[教室类型简称(classRoomTypeDescA)]的长度不能超过100(In 教室类型(ClsRmType))!值:$(pobjClsRmTypeEN.classRoomTypeDescA)(clsClsRmTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.modifyUserID) == false && (0, clsString_js_2.GetStrLen)(pobjClsRmTypeEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 教室类型(ClsRmType))!值:$(pobjClsRmTypeEN.modifyUserID)(clsClsRmTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.modifyDate) == false && (0, clsString_js_2.GetStrLen)(pobjClsRmTypeEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 教室类型(ClsRmType))!值:$(pobjClsRmTypeEN.modifyDate)(clsClsRmTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjClsRmTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 教室类型(ClsRmType))!值:$(pobjClsRmTypeEN.memo)(clsClsRmTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.id_ClassRoomType) == false && undefined !== pobjClsRmTypeEN.id_ClassRoomType && clsString_js_1.tzDataType.isString(pobjClsRmTypeEN.id_ClassRoomType) === false) {
            throw new Error("(errid:Watl000063)字段[教室类型流水号(id_ClassRoomType)]的值:[$(pobjClsRmTypeEN.id_ClassRoomType)], 非法，应该为字符型(In 教室类型(ClsRmType))!(clsClsRmTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.classRoomTypeID) == false && undefined !== pobjClsRmTypeEN.classRoomTypeID && clsString_js_1.tzDataType.isString(pobjClsRmTypeEN.classRoomTypeID) === false) {
            throw new Error("(errid:Watl000063)字段[教室类型代号(classRoomTypeID)]的值:[$(pobjClsRmTypeEN.classRoomTypeID)], 非法，应该为字符型(In 教室类型(ClsRmType))!(clsClsRmTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.classRoomTypeDesc) == false && undefined !== pobjClsRmTypeEN.classRoomTypeDesc && clsString_js_1.tzDataType.isString(pobjClsRmTypeEN.classRoomTypeDesc) === false) {
            throw new Error("(errid:Watl000063)字段[教室类型描述(classRoomTypeDesc)]的值:[$(pobjClsRmTypeEN.classRoomTypeDesc)], 非法，应该为字符型(In 教室类型(ClsRmType))!(clsClsRmTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.classRoomTypeDescA) == false && undefined !== pobjClsRmTypeEN.classRoomTypeDescA && clsString_js_1.tzDataType.isString(pobjClsRmTypeEN.classRoomTypeDescA) === false) {
            throw new Error("(errid:Watl000063)字段[教室类型简称(classRoomTypeDescA)]的值:[$(pobjClsRmTypeEN.classRoomTypeDescA)], 非法，应该为字符型(In 教室类型(ClsRmType))!(clsClsRmTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.modifyUserID) == false && undefined !== pobjClsRmTypeEN.modifyUserID && clsString_js_1.tzDataType.isString(pobjClsRmTypeEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjClsRmTypeEN.modifyUserID)], 非法，应该为字符型(In 教室类型(ClsRmType))!(clsClsRmTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.modifyDate) == false && undefined !== pobjClsRmTypeEN.modifyDate && clsString_js_1.tzDataType.isString(pobjClsRmTypeEN.modifyDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjClsRmTypeEN.modifyDate)], 非法，应该为字符型(In 教室类型(ClsRmType))!(clsClsRmTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.memo) == false && undefined !== pobjClsRmTypeEN.memo && clsString_js_1.tzDataType.isString(pobjClsRmTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjClsRmTypeEN.memo)], 非法，应该为字符型(In 教室类型(ClsRmType))!(clsClsRmTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjClsRmTypeEN.id_ClassRoomType) === true
            || pobjClsRmTypeEN.id_ClassRoomType.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[教室类型流水号]不能为空(In 教室类型)!(clsClsRmTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjClsRmTypeEN.SetIsCheckProperty(true);
    }
    exports.ClsRmType_CheckProperty4Update = ClsRmType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ClsRmType_GetJSONStrByObj(pobjClsRmTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjClsRmTypeEN.sf_UpdFldSetStr = pobjClsRmTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjClsRmTypeEN);
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
    exports.ClsRmType_GetJSONStrByObj = ClsRmType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ClsRmType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrClsRmTypeObjLst = new Array();
        if (strJSON === "") {
            return arrClsRmTypeObjLst;
        }
        try {
            arrClsRmTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrClsRmTypeObjLst;
        }
        return arrClsRmTypeObjLst;
    }
    exports.ClsRmType_GetObjLstByJSONStr = ClsRmType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrClsRmTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ClsRmType_GetObjLstByJSONObjLst(arrClsRmTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrClsRmTypeObjLst = new Array();
        for (const objInFor of arrClsRmTypeObjLstS) {
            const obj1 = ClsRmType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrClsRmTypeObjLst.push(obj1);
        }
        return arrClsRmTypeObjLst;
    }
    exports.ClsRmType_GetObjLstByJSONObjLst = ClsRmType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ClsRmType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjClsRmTypeEN = new clsClsRmTypeEN_js_1.clsClsRmTypeEN();
        if (strJSON === "") {
            return pobjClsRmTypeEN;
        }
        try {
            pobjClsRmTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjClsRmTypeEN;
        }
        return pobjClsRmTypeEN;
    }
    exports.ClsRmType_GetObjByJSONStr = ClsRmType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ClsRmType_GetCombineCondition(objClsRmType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objClsRmType_Cond.dicFldComparisonOp, clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_id_ClassRoomType) == true) {
            const strComparisonOp_id_ClassRoomType = objClsRmType_Cond.dicFldComparisonOp[clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_id_ClassRoomType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_id_ClassRoomType, objClsRmType_Cond.id_ClassRoomType, strComparisonOp_id_ClassRoomType);
        }
        if (Object.prototype.hasOwnProperty.call(objClsRmType_Cond.dicFldComparisonOp, clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeID) == true) {
            const strComparisonOp_ClassRoomTypeID = objClsRmType_Cond.dicFldComparisonOp[clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeID, objClsRmType_Cond.classRoomTypeID, strComparisonOp_ClassRoomTypeID);
        }
        if (Object.prototype.hasOwnProperty.call(objClsRmType_Cond.dicFldComparisonOp, clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeDesc) == true) {
            const strComparisonOp_ClassRoomTypeDesc = objClsRmType_Cond.dicFldComparisonOp[clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeDesc];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeDesc, objClsRmType_Cond.classRoomTypeDesc, strComparisonOp_ClassRoomTypeDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objClsRmType_Cond.dicFldComparisonOp, clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeDescA) == true) {
            const strComparisonOp_ClassRoomTypeDescA = objClsRmType_Cond.dicFldComparisonOp[clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeDescA];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ClassRoomTypeDescA, objClsRmType_Cond.classRoomTypeDescA, strComparisonOp_ClassRoomTypeDescA);
        }
        if (Object.prototype.hasOwnProperty.call(objClsRmType_Cond.dicFldComparisonOp, clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objClsRmType_Cond.dicFldComparisonOp[clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ModifyUserID, objClsRmType_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objClsRmType_Cond.dicFldComparisonOp, clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objClsRmType_Cond.dicFldComparisonOp[clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_ModifyDate, objClsRmType_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objClsRmType_Cond.dicFldComparisonOp, clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objClsRmType_Cond.dicFldComparisonOp[clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsClsRmTypeEN_js_1.clsClsRmTypeEN.con_Memo, objClsRmType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.ClsRmType_GetCombineCondition = ClsRmType_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objClsRmTypeENS:源对象
     * @param objClsRmTypeENT:目标对象
    */
    function ClsRmType_CopyObjTo(objClsRmTypeENS, objClsRmTypeENT) {
        objClsRmTypeENT.id_ClassRoomType = objClsRmTypeENS.id_ClassRoomType; //教室类型流水号
        objClsRmTypeENT.classRoomTypeID = objClsRmTypeENS.classRoomTypeID; //教室类型代号
        objClsRmTypeENT.classRoomTypeDesc = objClsRmTypeENS.classRoomTypeDesc; //教室类型描述
        objClsRmTypeENT.classRoomTypeDescA = objClsRmTypeENS.classRoomTypeDescA; //教室类型简称
        objClsRmTypeENT.modifyUserID = objClsRmTypeENS.modifyUserID; //修改人
        objClsRmTypeENT.modifyDate = objClsRmTypeENS.modifyDate; //修改日期
        objClsRmTypeENT.memo = objClsRmTypeENS.memo; //备注
        objClsRmTypeENT.sf_UpdFldSetStr = objClsRmTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ClsRmType_CopyObjTo = ClsRmType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objClsRmTypeENS:源对象
     * @param objClsRmTypeENT:目标对象
    */
    function ClsRmType_GetObjFromJsonObj(objClsRmTypeENS) {
        const objClsRmTypeENT = new clsClsRmTypeEN_js_1.clsClsRmTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objClsRmTypeENT, objClsRmTypeENS);
        return objClsRmTypeENT;
    }
    exports.ClsRmType_GetObjFromJsonObj = ClsRmType_GetObjFromJsonObj;
});
