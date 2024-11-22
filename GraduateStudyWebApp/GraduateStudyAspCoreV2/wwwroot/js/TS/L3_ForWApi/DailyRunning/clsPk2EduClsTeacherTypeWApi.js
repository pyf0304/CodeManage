/**
* 类名:clsPk2EduClsTeacherTypeWApi
* 表名:Pk2EduClsTeacherType(01120133)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:51:40
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:日常运行(DailyRunning)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/DailyRunning/clsPk2EduClsTeacherTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Pk2EduClsTeacherType_GetObjFromJsonObj = exports.Pk2EduClsTeacherType_CopyObjTo = exports.Pk2EduClsTeacherType_GetCombineCondition = exports.Pk2EduClsTeacherType_GetObjByJSONStr = exports.Pk2EduClsTeacherType_GetObjLstByJSONObjLst = exports.Pk2EduClsTeacherType_GetObjLstByJSONStr = exports.Pk2EduClsTeacherType_GetJSONStrByObj = exports.Pk2EduClsTeacherType_CheckProperty4Update = exports.Pk2EduClsTeacherType_CheckPropertyNew = exports.Pk2EduClsTeacherType_BindDdl_id_Pk2EduClsTeacherTypeInDiv_Cache = exports.Pk2EduClsTeacherType_ReFreshThisCache = exports.Pk2EduClsTeacherType_ReFreshCache = exports.Pk2EduClsTeacherType_GetWebApiUrl = exports.Pk2EduClsTeacherType_GetMaxStrIdByPrefix = exports.Pk2EduClsTeacherType_GetRecCountByCond_Cache = exports.Pk2EduClsTeacherType_GetRecCountByCondAsync = exports.Pk2EduClsTeacherType_IsExistAsync = exports.Pk2EduClsTeacherType_IsExist_Cache = exports.Pk2EduClsTeacherType_IsExist = exports.Pk2EduClsTeacherType_IsExistRecordAsync = exports.Pk2EduClsTeacherType_IsExistRecord_Cache = exports.Pk2EduClsTeacherType_UpdateWithConditionAsync = exports.Pk2EduClsTeacherType_UpdateRecordAsync = exports.Pk2EduClsTeacherType_AddNewRecordWithReturnKey = exports.Pk2EduClsTeacherType_AddNewRecordWithReturnKeyAsync = exports.Pk2EduClsTeacherType_AddNewRecordWithMaxIdAsync = exports.Pk2EduClsTeacherType_AddNewRecordAsync = exports.Pk2EduClsTeacherType_DelPk2EduClsTeacherTypesByCondAsync = exports.Pk2EduClsTeacherType_DelPk2EduClsTeacherTypesAsync = exports.Pk2EduClsTeacherType_DelRecordAsync = exports.Pk2EduClsTeacherType_GetObjLstByPagerAsync = exports.Pk2EduClsTeacherType_GetObjLstByPager_Cache = exports.Pk2EduClsTeacherType_GetObjLstByRange = exports.Pk2EduClsTeacherType_GetObjLstByRangeAsync = exports.Pk2EduClsTeacherType_GetTopObjLstAsync = exports.Pk2EduClsTeacherType_GetObjLstByid_Pk2EduClsTeacherTypeLst_Cache = exports.Pk2EduClsTeacherType_GetObjLstByid_Pk2EduClsTeacherTypeLstAsync = exports.Pk2EduClsTeacherType_GetSubObjLst_Cache = exports.Pk2EduClsTeacherType_GetObjLst_PureCache = exports.Pk2EduClsTeacherType_GetObjLst_Cache = exports.Pk2EduClsTeacherType_GetObjLst_sessionStorage_PureCache = exports.Pk2EduClsTeacherType_GetObjLst_sessionStorage = exports.Pk2EduClsTeacherType_GetObjLstAsync = exports.Pk2EduClsTeacherType_GetObjLst_localStorage_PureCache = exports.Pk2EduClsTeacherType_GetObjLst_localStorage = exports.Pk2EduClsTeacherType_GetObjLst_ClientCache = exports.Pk2EduClsTeacherType_GetFirstObjAsync = exports.Pk2EduClsTeacherType_GetFirstID = exports.Pk2EduClsTeacherType_GetFirstIDAsync = exports.Pk2EduClsTeacherType_funcKey = exports.Pk2EduClsTeacherType_FilterFunByKey = exports.Pk2EduClsTeacherType_SortFunByKey = exports.Pk2EduClsTeacherType_SortFun_Defa_2Fld = exports.Pk2EduClsTeacherType_SortFun_Defa = exports.Pk2EduClsTeacherType_func = exports.Pk2EduClsTeacherType_GetNameByid_Pk2EduClsTeacherType_Cache = exports.Pk2EduClsTeacherType_UpdateObjInLst_Cache = exports.Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherType_localStorage = exports.Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherType_Cache = exports.Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherTypeAsync = exports.pk2EduClsTeacherType_ConstructorName = exports.pk2EduClsTeacherType_Controller = void 0;
    /**
     * 教学班教师角色表2(Pk2EduClsTeacherType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsPk2EduClsTeacherTypeEN_js_1 = require("../../L0_Entity/DailyRunning/clsPk2EduClsTeacherTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.pk2EduClsTeacherType_Controller = "Pk2EduClsTeacherTypeApi";
    exports.pk2EduClsTeacherType_ConstructorName = "pk2EduClsTeacherType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_Pk2EduClsTeacherType:关键字
    * @returns 对象
    **/
    async function Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherTypeAsync(strid_Pk2EduClsTeacherType) {
        const strThisFuncName = "GetObjByid_Pk2EduClsTeacherTypeAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_Pk2EduClsTeacherType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_Pk2EduClsTeacherType]不能为空！(In clsPk2EduClsTeacherTypeWApi.GetObjByid_Pk2EduClsTeacherTypeAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_Pk2EduClsTeacherType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_Pk2EduClsTeacherType]的长度:[{0}]不正确！(clsPk2EduClsTeacherTypeWApi.GetObjByid_Pk2EduClsTeacherTypeAsync)", strid_Pk2EduClsTeacherType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_Pk2EduClsTeacherType";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_Pk2EduClsTeacherType": strid_Pk2EduClsTeacherType,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objPk2EduClsTeacherType = Pk2EduClsTeacherType_GetObjFromJsonObj(returnObj);
                return objPk2EduClsTeacherType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherTypeAsync = Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherTypeAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_Pk2EduClsTeacherType:所给的关键字
     * @returns 对象
    */
    async function Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherType_Cache(strid_Pk2EduClsTeacherType, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_Pk2EduClsTeacherType_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_Pk2EduClsTeacherType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_Pk2EduClsTeacherType]不能为空！(In clsPk2EduClsTeacherTypeWApi.GetObjByid_Pk2EduClsTeacherType_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_Pk2EduClsTeacherType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_Pk2EduClsTeacherType]的长度:[{0}]不正确！(clsPk2EduClsTeacherTypeWApi.GetObjByid_Pk2EduClsTeacherType_Cache)", strid_Pk2EduClsTeacherType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
        try {
            const arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherTypeObjLst_Cache.filter(x => x.id_Pk2EduClsTeacherType == strid_Pk2EduClsTeacherType);
            let objPk2EduClsTeacherType;
            if (arrPk2EduClsTeacherType_Sel.length > 0) {
                objPk2EduClsTeacherType = arrPk2EduClsTeacherType_Sel[0];
                return objPk2EduClsTeacherType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objPk2EduClsTeacherType_Const = await Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherTypeAsync(strid_Pk2EduClsTeacherType);
                    if (objPk2EduClsTeacherType_Const != null) {
                        Pk2EduClsTeacherType_ReFreshThisCache();
                        return objPk2EduClsTeacherType_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_Pk2EduClsTeacherType, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherType_Cache = Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherType_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_Pk2EduClsTeacherType:所给的关键字
     * @returns 对象
    */
    async function Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherType_localStorage(strid_Pk2EduClsTeacherType) {
        const strThisFuncName = "GetObjByid_Pk2EduClsTeacherType_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_Pk2EduClsTeacherType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_Pk2EduClsTeacherType]不能为空！(In clsPk2EduClsTeacherTypeWApi.GetObjByid_Pk2EduClsTeacherType_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_Pk2EduClsTeacherType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_Pk2EduClsTeacherType]的长度:[{0}]不正确！(clsPk2EduClsTeacherTypeWApi.GetObjByid_Pk2EduClsTeacherType_localStorage)", strid_Pk2EduClsTeacherType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN._CurrTabName, strid_Pk2EduClsTeacherType);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objPk2EduClsTeacherType_Cache = JSON.parse(strTempObj);
            return objPk2EduClsTeacherType_Cache;
        }
        try {
            const objPk2EduClsTeacherType = await Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherTypeAsync(strid_Pk2EduClsTeacherType);
            if (objPk2EduClsTeacherType != null) {
                localStorage.setItem(strKey, JSON.stringify(objPk2EduClsTeacherType));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objPk2EduClsTeacherType;
            }
            return objPk2EduClsTeacherType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_Pk2EduClsTeacherType, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherType_localStorage = Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherType_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objPk2EduClsTeacherType:所给的对象
     * @returns 对象
    */
    async function Pk2EduClsTeacherType_UpdateObjInLst_Cache(objPk2EduClsTeacherType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
            const obj = arrPk2EduClsTeacherTypeObjLst_Cache.find(x => x.id_Pk2EduClsTeacherType == objPk2EduClsTeacherType.id_Pk2EduClsTeacherType);
            if (obj != null) {
                objPk2EduClsTeacherType.id_Pk2EduClsTeacherType = obj.id_Pk2EduClsTeacherType;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objPk2EduClsTeacherType);
            }
            else {
                arrPk2EduClsTeacherTypeObjLst_Cache.push(objPk2EduClsTeacherType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.Pk2EduClsTeacherType_UpdateObjInLst_Cache = Pk2EduClsTeacherType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_Pk2EduClsTeacherType:所给的关键字
     * @returns 对象
    */
    async function Pk2EduClsTeacherType_GetNameByid_Pk2EduClsTeacherType_Cache(strid_Pk2EduClsTeacherType) {
        const strThisFuncName = "GetNameByid_Pk2EduClsTeacherType_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_Pk2EduClsTeacherType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_Pk2EduClsTeacherType]不能为空！(In clsPk2EduClsTeacherTypeWApi.GetNameByid_Pk2EduClsTeacherType_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_Pk2EduClsTeacherType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_Pk2EduClsTeacherType]的长度:[{0}]不正确！(clsPk2EduClsTeacherTypeWApi.GetNameByid_Pk2EduClsTeacherType_Cache)", strid_Pk2EduClsTeacherType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
        if (arrPk2EduClsTeacherTypeObjLst_Cache == null)
            return "";
        try {
            const arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherTypeObjLst_Cache.filter(x => x.id_Pk2EduClsTeacherType == strid_Pk2EduClsTeacherType);
            let objPk2EduClsTeacherType;
            if (arrPk2EduClsTeacherType_Sel.length > 0) {
                objPk2EduClsTeacherType = arrPk2EduClsTeacherType_Sel[0];
                return objPk2EduClsTeacherType.eduClsTeacherTypeDesc;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_Pk2EduClsTeacherType);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.Pk2EduClsTeacherType_GetNameByid_Pk2EduClsTeacherType_Cache = Pk2EduClsTeacherType_GetNameByid_Pk2EduClsTeacherType_Cache;
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
    async function Pk2EduClsTeacherType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_Pk2EduClsTeacherType = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objPk2EduClsTeacherType = await Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherType_Cache(strid_Pk2EduClsTeacherType);
        if (objPk2EduClsTeacherType == null)
            return "";
        if (objPk2EduClsTeacherType.GetFldValue(strOutFldName) == null)
            return "";
        return objPk2EduClsTeacherType.GetFldValue(strOutFldName).toString();
    }
    exports.Pk2EduClsTeacherType_func = Pk2EduClsTeacherType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Pk2EduClsTeacherType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_Pk2EduClsTeacherType.localeCompare(b.id_Pk2EduClsTeacherType);
    }
    exports.Pk2EduClsTeacherType_SortFun_Defa = Pk2EduClsTeacherType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Pk2EduClsTeacherType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.eduClsTeacherTypeID == b.eduClsTeacherTypeID)
            return a.eduClsTeacherTypeDesc.localeCompare(b.eduClsTeacherTypeDesc);
        else
            return a.eduClsTeacherTypeID.localeCompare(b.eduClsTeacherTypeID);
    }
    exports.Pk2EduClsTeacherType_SortFun_Defa_2Fld = Pk2EduClsTeacherType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Pk2EduClsTeacherType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType:
                    return (a, b) => {
                        return a.id_Pk2EduClsTeacherType.localeCompare(b.id_Pk2EduClsTeacherType);
                    };
                case clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeID:
                    return (a, b) => {
                        if (a.eduClsTeacherTypeID == null)
                            return -1;
                        if (b.eduClsTeacherTypeID == null)
                            return 1;
                        return a.eduClsTeacherTypeID.localeCompare(b.eduClsTeacherTypeID);
                    };
                case clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeDesc:
                    return (a, b) => {
                        if (a.eduClsTeacherTypeDesc == null)
                            return -1;
                        if (b.eduClsTeacherTypeDesc == null)
                            return 1;
                        return a.eduClsTeacherTypeDesc.localeCompare(b.eduClsTeacherTypeDesc);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[Pk2EduClsTeacherType]中不存在！(in ${exports.pk2EduClsTeacherType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType:
                    return (a, b) => {
                        return b.id_Pk2EduClsTeacherType.localeCompare(a.id_Pk2EduClsTeacherType);
                    };
                case clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeID:
                    return (a, b) => {
                        if (b.eduClsTeacherTypeID == null)
                            return -1;
                        if (a.eduClsTeacherTypeID == null)
                            return 1;
                        return b.eduClsTeacherTypeID.localeCompare(a.eduClsTeacherTypeID);
                    };
                case clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeDesc:
                    return (a, b) => {
                        if (b.eduClsTeacherTypeDesc == null)
                            return -1;
                        if (a.eduClsTeacherTypeDesc == null)
                            return 1;
                        return b.eduClsTeacherTypeDesc.localeCompare(a.eduClsTeacherTypeDesc);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[Pk2EduClsTeacherType]中不存在！(in ${exports.pk2EduClsTeacherType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.Pk2EduClsTeacherType_SortFunByKey = Pk2EduClsTeacherType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function Pk2EduClsTeacherType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType:
                return (obj) => {
                    return obj.id_Pk2EduClsTeacherType === value;
                };
            case clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeID:
                return (obj) => {
                    return obj.eduClsTeacherTypeID === value;
                };
            case clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeDesc:
                return (obj) => {
                    return obj.eduClsTeacherTypeDesc === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[Pk2EduClsTeacherType]中不存在！(in ${exports.pk2EduClsTeacherType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.Pk2EduClsTeacherType_FilterFunByKey = Pk2EduClsTeacherType_FilterFunByKey;
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
    async function Pk2EduClsTeacherType_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrPk2EduClsTeacherType = await Pk2EduClsTeacherType_GetObjLst_Cache();
        if (arrPk2EduClsTeacherType == null)
            return [];
        let arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrPk2EduClsTeacherType_Sel.length == 0)
            return [];
        return arrPk2EduClsTeacherType_Sel.map(x => x.id_Pk2EduClsTeacherType);
    }
    exports.Pk2EduClsTeacherType_funcKey = Pk2EduClsTeacherType_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function Pk2EduClsTeacherType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_GetFirstIDAsync = Pk2EduClsTeacherType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function Pk2EduClsTeacherType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_GetFirstID = Pk2EduClsTeacherType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function Pk2EduClsTeacherType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
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
                const objPk2EduClsTeacherType = Pk2EduClsTeacherType_GetObjFromJsonObj(returnObj);
                return objPk2EduClsTeacherType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_GetFirstObjAsync = Pk2EduClsTeacherType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Pk2EduClsTeacherType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrPk2EduClsTeacherTypeExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrPk2EduClsTeacherTypeObjLst_T = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(arrPk2EduClsTeacherTypeExObjLst_Cache);
            return arrPk2EduClsTeacherTypeObjLst_T;
        }
        try {
            const arrPk2EduClsTeacherTypeExObjLst = await Pk2EduClsTeacherType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrPk2EduClsTeacherTypeExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPk2EduClsTeacherTypeExObjLst.length);
            console.log(strInfo);
            return arrPk2EduClsTeacherTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.Pk2EduClsTeacherType_GetObjLst_ClientCache = Pk2EduClsTeacherType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Pk2EduClsTeacherType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPk2EduClsTeacherTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPk2EduClsTeacherTypeObjLst_T = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(arrPk2EduClsTeacherTypeExObjLst_Cache);
            return arrPk2EduClsTeacherTypeObjLst_T;
        }
        try {
            const arrPk2EduClsTeacherTypeExObjLst = await Pk2EduClsTeacherType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrPk2EduClsTeacherTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPk2EduClsTeacherTypeExObjLst.length);
            console.log(strInfo);
            return arrPk2EduClsTeacherTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.Pk2EduClsTeacherType_GetObjLst_localStorage = Pk2EduClsTeacherType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Pk2EduClsTeacherType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPk2EduClsTeacherTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPk2EduClsTeacherTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.Pk2EduClsTeacherType_GetObjLst_localStorage_PureCache = Pk2EduClsTeacherType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function Pk2EduClsTeacherType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_GetObjLstAsync = Pk2EduClsTeacherType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Pk2EduClsTeacherType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPk2EduClsTeacherTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPk2EduClsTeacherTypeObjLst_T = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(arrPk2EduClsTeacherTypeExObjLst_Cache);
            return arrPk2EduClsTeacherTypeObjLst_T;
        }
        try {
            const arrPk2EduClsTeacherTypeExObjLst = await Pk2EduClsTeacherType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrPk2EduClsTeacherTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPk2EduClsTeacherTypeExObjLst.length);
            console.log(strInfo);
            return arrPk2EduClsTeacherTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.Pk2EduClsTeacherType_GetObjLst_sessionStorage = Pk2EduClsTeacherType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Pk2EduClsTeacherType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPk2EduClsTeacherTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPk2EduClsTeacherTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.Pk2EduClsTeacherType_GetObjLst_sessionStorage_PureCache = Pk2EduClsTeacherType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Pk2EduClsTeacherType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrPk2EduClsTeacherTypeObjLst_Cache;
        switch (clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_ClientCache();
                break;
            default:
                arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_ClientCache();
                break;
        }
        const arrPk2EduClsTeacherTypeObjLst = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(arrPk2EduClsTeacherTypeObjLst_Cache);
        return arrPk2EduClsTeacherTypeObjLst_Cache;
    }
    exports.Pk2EduClsTeacherType_GetObjLst_Cache = Pk2EduClsTeacherType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Pk2EduClsTeacherType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrPk2EduClsTeacherTypeObjLst_Cache;
        switch (clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrPk2EduClsTeacherTypeObjLst_Cache = null;
                break;
            default:
                arrPk2EduClsTeacherTypeObjLst_Cache = null;
                break;
        }
        return arrPk2EduClsTeacherTypeObjLst_Cache;
    }
    exports.Pk2EduClsTeacherType_GetObjLst_PureCache = Pk2EduClsTeacherType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_Pk2EduClsTeacherType_Cond:条件对象
     * @returns 对象列表子集
    */
    async function Pk2EduClsTeacherType_GetSubObjLst_Cache(objPk2EduClsTeacherType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
        let arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherTypeObjLst_Cache;
        if (objPk2EduClsTeacherType_Cond.sf_FldComparisonOp == null || objPk2EduClsTeacherType_Cond.sf_FldComparisonOp == "")
            return arrPk2EduClsTeacherType_Sel;
        const dicFldComparisonOp = JSON.parse(objPk2EduClsTeacherType_Cond.sf_FldComparisonOp);
        //console.log("clsPk2EduClsTeacherTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPk2EduClsTeacherType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPk2EduClsTeacherType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPk2EduClsTeacherType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objPk2EduClsTeacherType_Cond), exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.Pk2EduClsTeacherType_GetSubObjLst_Cache = Pk2EduClsTeacherType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_Pk2EduClsTeacherType:关键字列表
    * @returns 对象列表
    **/
    async function Pk2EduClsTeacherType_GetObjLstByid_Pk2EduClsTeacherTypeLstAsync(arrid_Pk2EduClsTeacherType) {
        const strThisFuncName = "GetObjLstByid_Pk2EduClsTeacherTypeLstAsync";
        const strAction = "GetObjLstByid_Pk2EduClsTeacherTypeLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_Pk2EduClsTeacherType);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_GetObjLstByid_Pk2EduClsTeacherTypeLstAsync = Pk2EduClsTeacherType_GetObjLstByid_Pk2EduClsTeacherTypeLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_Pk2EduClsTeacherTypeLst:关键字列表
     * @returns 对象列表
    */
    async function Pk2EduClsTeacherType_GetObjLstByid_Pk2EduClsTeacherTypeLst_Cache(arrid_Pk2EduClsTeacherTypeLst) {
        const strThisFuncName = "GetObjLstByid_Pk2EduClsTeacherTypeLst_Cache";
        try {
            const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
            const arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherTypeObjLst_Cache.filter(x => arrid_Pk2EduClsTeacherTypeLst.indexOf(x.id_Pk2EduClsTeacherType) > -1);
            return arrPk2EduClsTeacherType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_Pk2EduClsTeacherTypeLst.join(","), exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.Pk2EduClsTeacherType_GetObjLstByid_Pk2EduClsTeacherTypeLst_Cache = Pk2EduClsTeacherType_GetObjLstByid_Pk2EduClsTeacherTypeLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function Pk2EduClsTeacherType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_GetTopObjLstAsync = Pk2EduClsTeacherType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function Pk2EduClsTeacherType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_GetObjLstByRangeAsync = Pk2EduClsTeacherType_GetObjLstByRangeAsync;
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
    async function Pk2EduClsTeacherType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_GetObjLstByRange = Pk2EduClsTeacherType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function Pk2EduClsTeacherType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
        if (arrPk2EduClsTeacherTypeObjLst_Cache.length == 0)
            return arrPk2EduClsTeacherTypeObjLst_Cache;
        let arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objPk2EduClsTeacherType_Cond = new clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPk2EduClsTeacherType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsPk2EduClsTeacherTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPk2EduClsTeacherType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPk2EduClsTeacherType_Sel.length == 0)
                return arrPk2EduClsTeacherType_Sel;
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
                arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.sort(Pk2EduClsTeacherType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.sort(objPagerPara.sortFun);
            }
            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.slice(intStart, intEnd);
            return arrPk2EduClsTeacherType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.Pk2EduClsTeacherType_GetObjLstByPager_Cache = Pk2EduClsTeacherType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function Pk2EduClsTeacherType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_GetObjLstByPagerAsync = Pk2EduClsTeacherType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strid_Pk2EduClsTeacherType:关键字
    * @returns 获取删除的结果
    **/
    async function Pk2EduClsTeacherType_DelRecordAsync(strid_Pk2EduClsTeacherType) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strid_Pk2EduClsTeacherType);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_DelRecordAsync = Pk2EduClsTeacherType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_Pk2EduClsTeacherType:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function Pk2EduClsTeacherType_DelPk2EduClsTeacherTypesAsync(arrid_Pk2EduClsTeacherType) {
        const strThisFuncName = "DelPk2EduClsTeacherTypesAsync";
        const strAction = "DelPk2EduClsTeacherTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_Pk2EduClsTeacherType);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_DelPk2EduClsTeacherTypesAsync = Pk2EduClsTeacherType_DelPk2EduClsTeacherTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function Pk2EduClsTeacherType_DelPk2EduClsTeacherTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelPk2EduClsTeacherTypesByCondAsync";
        const strAction = "DelPk2EduClsTeacherTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_DelPk2EduClsTeacherTypesByCondAsync = Pk2EduClsTeacherType_DelPk2EduClsTeacherTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objPk2EduClsTeacherTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Pk2EduClsTeacherType_AddNewRecordAsync(objPk2EduClsTeacherTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType === null || objPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objPk2EduClsTeacherTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPk2EduClsTeacherTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_AddNewRecordAsync = Pk2EduClsTeacherType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objPk2EduClsTeacherTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Pk2EduClsTeacherType_AddNewRecordWithMaxIdAsync(objPk2EduClsTeacherTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPk2EduClsTeacherTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_AddNewRecordWithMaxIdAsync = Pk2EduClsTeacherType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objPk2EduClsTeacherTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function Pk2EduClsTeacherType_AddNewRecordWithReturnKeyAsync(objPk2EduClsTeacherTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPk2EduClsTeacherTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_AddNewRecordWithReturnKeyAsync = Pk2EduClsTeacherType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objPk2EduClsTeacherTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function Pk2EduClsTeacherType_AddNewRecordWithReturnKey(objPk2EduClsTeacherTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType === null || objPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPk2EduClsTeacherTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_AddNewRecordWithReturnKey = Pk2EduClsTeacherType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objPk2EduClsTeacherTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function Pk2EduClsTeacherType_UpdateRecordAsync(objPk2EduClsTeacherTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objPk2EduClsTeacherTypeEN.sf_UpdFldSetStr === undefined || objPk2EduClsTeacherTypeEN.sf_UpdFldSetStr === null || objPk2EduClsTeacherTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPk2EduClsTeacherTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_UpdateRecordAsync = Pk2EduClsTeacherType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objPk2EduClsTeacherTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function Pk2EduClsTeacherType_UpdateWithConditionAsync(objPk2EduClsTeacherTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objPk2EduClsTeacherTypeEN.sf_UpdFldSetStr === undefined || objPk2EduClsTeacherTypeEN.sf_UpdFldSetStr === null || objPk2EduClsTeacherTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
        objPk2EduClsTeacherTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objPk2EduClsTeacherTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_UpdateWithConditionAsync = Pk2EduClsTeacherType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_Pk2EduClsTeacherType_Cond:条件对象
     * @returns 对象列表子集
    */
    async function Pk2EduClsTeacherType_IsExistRecord_Cache(objPk2EduClsTeacherType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
        if (arrPk2EduClsTeacherTypeObjLst_Cache == null)
            return false;
        let arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherTypeObjLst_Cache;
        if (objPk2EduClsTeacherType_Cond.sf_FldComparisonOp == null || objPk2EduClsTeacherType_Cond.sf_FldComparisonOp == "")
            return arrPk2EduClsTeacherType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objPk2EduClsTeacherType_Cond.sf_FldComparisonOp);
        //console.log("clsPk2EduClsTeacherTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPk2EduClsTeacherType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPk2EduClsTeacherType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPk2EduClsTeacherType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objPk2EduClsTeacherType_Cond), exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.Pk2EduClsTeacherType_IsExistRecord_Cache = Pk2EduClsTeacherType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function Pk2EduClsTeacherType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_IsExistRecordAsync = Pk2EduClsTeacherType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_Pk2EduClsTeacherType:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function Pk2EduClsTeacherType_IsExist(strid_Pk2EduClsTeacherType, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_Pk2EduClsTeacherType": strid_Pk2EduClsTeacherType,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_IsExist = Pk2EduClsTeacherType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_Pk2EduClsTeacherType:所给的关键字
     * @returns 对象
    */
    async function Pk2EduClsTeacherType_IsExist_Cache(strid_Pk2EduClsTeacherType) {
        const strThisFuncName = "IsExist_Cache";
        const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
        if (arrPk2EduClsTeacherTypeObjLst_Cache == null)
            return false;
        try {
            const arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherTypeObjLst_Cache.filter(x => x.id_Pk2EduClsTeacherType == strid_Pk2EduClsTeacherType);
            if (arrPk2EduClsTeacherType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_Pk2EduClsTeacherType, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.Pk2EduClsTeacherType_IsExist_Cache = Pk2EduClsTeacherType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_Pk2EduClsTeacherType:关键字
    * @returns 是否存在?存在返回True
    **/
    async function Pk2EduClsTeacherType_IsExistAsync(strid_Pk2EduClsTeacherType) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_Pk2EduClsTeacherType": strid_Pk2EduClsTeacherType }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_IsExistAsync = Pk2EduClsTeacherType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function Pk2EduClsTeacherType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_GetRecCountByCondAsync = Pk2EduClsTeacherType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objPk2EduClsTeacherType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function Pk2EduClsTeacherType_GetRecCountByCond_Cache(objPk2EduClsTeacherType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
        if (arrPk2EduClsTeacherTypeObjLst_Cache == null)
            return 0;
        let arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherTypeObjLst_Cache;
        if (objPk2EduClsTeacherType_Cond.sf_FldComparisonOp == null || objPk2EduClsTeacherType_Cond.sf_FldComparisonOp == "")
            return arrPk2EduClsTeacherType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objPk2EduClsTeacherType_Cond.sf_FldComparisonOp);
        //console.log("clsPk2EduClsTeacherTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPk2EduClsTeacherType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPk2EduClsTeacherType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPk2EduClsTeacherType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objPk2EduClsTeacherType_Cond), exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.Pk2EduClsTeacherType_GetRecCountByCond_Cache = Pk2EduClsTeacherType_GetRecCountByCond_Cache;
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
    async function Pk2EduClsTeacherType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pk2EduClsTeacherType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pk2EduClsTeacherType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Pk2EduClsTeacherType_GetMaxStrIdByPrefix = Pk2EduClsTeacherType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function Pk2EduClsTeacherType_GetWebApiUrl(strController, strAction) {
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
    exports.Pk2EduClsTeacherType_GetWebApiUrl = Pk2EduClsTeacherType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function Pk2EduClsTeacherType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN._CurrTabName;
        switch (clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.CacheModeId) {
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
    exports.Pk2EduClsTeacherType_ReFreshCache = Pk2EduClsTeacherType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function Pk2EduClsTeacherType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN._CurrTabName;
            switch (clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.CacheModeId) {
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
    exports.Pk2EduClsTeacherType_ReFreshThisCache = Pk2EduClsTeacherType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function Pk2EduClsTeacherType_BindDdl_id_Pk2EduClsTeacherTypeInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_id_Pk2EduClsTeacherTypeInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_id_Pk2EduClsTeacherTypeInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_id_Pk2EduClsTeacherTypeInDiv_Cache");
        const arrObjLst_Sel = await Pk2EduClsTeacherType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType, clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeDesc, "教学班教师角色表2");
    }
    exports.Pk2EduClsTeacherType_BindDdl_id_Pk2EduClsTeacherTypeInDiv_Cache = Pk2EduClsTeacherType_BindDdl_id_Pk2EduClsTeacherTypeInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function Pk2EduClsTeacherType_CheckPropertyNew(pobjPk2EduClsTeacherTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) == false && (0, clsString_js_2.GetStrLen)(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) > 4) {
            throw new Error("(errid:Watl000059)字段[教学班老师角色(主讲,辅导)流水号(id_Pk2EduClsTeacherType)]的长度不能超过4(In 教学班教师角色表2(Pk2EduClsTeacherType))!值:$(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType)(clsPk2EduClsTeacherTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID) == false && (0, clsString_js_2.GetStrLen)(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID) > 4) {
            throw new Error("(errid:Watl000059)字段[教学班教学类型ID(eduClsTeacherTypeID)]的长度不能超过4(In 教学班教师角色表2(Pk2EduClsTeacherType))!值:$(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID)(clsPk2EduClsTeacherTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc) == false && (0, clsString_js_2.GetStrLen)(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc) > 20) {
            throw new Error("(errid:Watl000059)字段[教学班教师类型名(eduClsTeacherTypeDesc)]的长度不能超过20(In 教学班教师角色表2(Pk2EduClsTeacherType))!值:$(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc)(clsPk2EduClsTeacherTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) == false && undefined !== pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType && clsString_js_1.tzDataType.isString(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) === false) {
            throw new Error("(errid:Watl000060)字段[教学班老师角色(主讲,辅导)流水号(id_Pk2EduClsTeacherType)]的值:[$(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType)], 非法，应该为字符型(In 教学班教师角色表2(Pk2EduClsTeacherType))!(clsPk2EduClsTeacherTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID) == false && undefined !== pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID && clsString_js_1.tzDataType.isString(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID) === false) {
            throw new Error("(errid:Watl000060)字段[教学班教学类型ID(eduClsTeacherTypeID)]的值:[$(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID)], 非法，应该为字符型(In 教学班教师角色表2(Pk2EduClsTeacherType))!(clsPk2EduClsTeacherTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc) == false && undefined !== pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc && clsString_js_1.tzDataType.isString(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc) === false) {
            throw new Error("(errid:Watl000060)字段[教学班教师类型名(eduClsTeacherTypeDesc)]的值:[$(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc)], 非法，应该为字符型(In 教学班教师角色表2(Pk2EduClsTeacherType))!(clsPk2EduClsTeacherTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjPk2EduClsTeacherTypeEN.SetIsCheckProperty(true);
    }
    exports.Pk2EduClsTeacherType_CheckPropertyNew = Pk2EduClsTeacherType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function Pk2EduClsTeacherType_CheckProperty4Update(pobjPk2EduClsTeacherTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) == false && (0, clsString_js_2.GetStrLen)(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) > 4) {
            throw new Error("(errid:Watl000062)字段[教学班老师角色(主讲,辅导)流水号(id_Pk2EduClsTeacherType)]的长度不能超过4(In 教学班教师角色表2(Pk2EduClsTeacherType))!值:$(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType)(clsPk2EduClsTeacherTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID) == false && (0, clsString_js_2.GetStrLen)(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID) > 4) {
            throw new Error("(errid:Watl000062)字段[教学班教学类型ID(eduClsTeacherTypeID)]的长度不能超过4(In 教学班教师角色表2(Pk2EduClsTeacherType))!值:$(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID)(clsPk2EduClsTeacherTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc) == false && (0, clsString_js_2.GetStrLen)(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc) > 20) {
            throw new Error("(errid:Watl000062)字段[教学班教师类型名(eduClsTeacherTypeDesc)]的长度不能超过20(In 教学班教师角色表2(Pk2EduClsTeacherType))!值:$(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc)(clsPk2EduClsTeacherTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) == false && undefined !== pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType && clsString_js_1.tzDataType.isString(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) === false) {
            throw new Error("(errid:Watl000063)字段[教学班老师角色(主讲,辅导)流水号(id_Pk2EduClsTeacherType)]的值:[$(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType)], 非法，应该为字符型(In 教学班教师角色表2(Pk2EduClsTeacherType))!(clsPk2EduClsTeacherTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID) == false && undefined !== pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID && clsString_js_1.tzDataType.isString(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID) === false) {
            throw new Error("(errid:Watl000063)字段[教学班教学类型ID(eduClsTeacherTypeID)]的值:[$(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID)], 非法，应该为字符型(In 教学班教师角色表2(Pk2EduClsTeacherType))!(clsPk2EduClsTeacherTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc) == false && undefined !== pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc && clsString_js_1.tzDataType.isString(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc) === false) {
            throw new Error("(errid:Watl000063)字段[教学班教师类型名(eduClsTeacherTypeDesc)]的值:[$(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc)], 非法，应该为字符型(In 教学班教师角色表2(Pk2EduClsTeacherType))!(clsPk2EduClsTeacherTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) === true
            || pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[教学班老师角色(主讲,辅导)流水号]不能为空(In 教学班教师角色表2)!(clsPk2EduClsTeacherTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjPk2EduClsTeacherTypeEN.SetIsCheckProperty(true);
    }
    exports.Pk2EduClsTeacherType_CheckProperty4Update = Pk2EduClsTeacherType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function Pk2EduClsTeacherType_GetJSONStrByObj(pobjPk2EduClsTeacherTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjPk2EduClsTeacherTypeEN.sf_UpdFldSetStr = pobjPk2EduClsTeacherTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjPk2EduClsTeacherTypeEN);
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
    exports.Pk2EduClsTeacherType_GetJSONStrByObj = Pk2EduClsTeacherType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function Pk2EduClsTeacherType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrPk2EduClsTeacherTypeObjLst = new Array();
        if (strJSON === "") {
            return arrPk2EduClsTeacherTypeObjLst;
        }
        try {
            arrPk2EduClsTeacherTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrPk2EduClsTeacherTypeObjLst;
        }
        return arrPk2EduClsTeacherTypeObjLst;
    }
    exports.Pk2EduClsTeacherType_GetObjLstByJSONStr = Pk2EduClsTeacherType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrPk2EduClsTeacherTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function Pk2EduClsTeacherType_GetObjLstByJSONObjLst(arrPk2EduClsTeacherTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrPk2EduClsTeacherTypeObjLst = new Array();
        for (const objInFor of arrPk2EduClsTeacherTypeObjLstS) {
            const obj1 = Pk2EduClsTeacherType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrPk2EduClsTeacherTypeObjLst.push(obj1);
        }
        return arrPk2EduClsTeacherTypeObjLst;
    }
    exports.Pk2EduClsTeacherType_GetObjLstByJSONObjLst = Pk2EduClsTeacherType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function Pk2EduClsTeacherType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjPk2EduClsTeacherTypeEN = new clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN();
        if (strJSON === "") {
            return pobjPk2EduClsTeacherTypeEN;
        }
        try {
            pobjPk2EduClsTeacherTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjPk2EduClsTeacherTypeEN;
        }
        return pobjPk2EduClsTeacherTypeEN;
    }
    exports.Pk2EduClsTeacherType_GetObjByJSONStr = Pk2EduClsTeacherType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function Pk2EduClsTeacherType_GetCombineCondition(objPk2EduClsTeacherType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objPk2EduClsTeacherType_Cond.dicFldComparisonOp, clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType) == true) {
            const strComparisonOp_id_Pk2EduClsTeacherType = objPk2EduClsTeacherType_Cond.dicFldComparisonOp[clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType, objPk2EduClsTeacherType_Cond.id_Pk2EduClsTeacherType, strComparisonOp_id_Pk2EduClsTeacherType);
        }
        if (Object.prototype.hasOwnProperty.call(objPk2EduClsTeacherType_Cond.dicFldComparisonOp, clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeID) == true) {
            const strComparisonOp_EduClsTeacherTypeID = objPk2EduClsTeacherType_Cond.dicFldComparisonOp[clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeID, objPk2EduClsTeacherType_Cond.eduClsTeacherTypeID, strComparisonOp_EduClsTeacherTypeID);
        }
        if (Object.prototype.hasOwnProperty.call(objPk2EduClsTeacherType_Cond.dicFldComparisonOp, clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeDesc) == true) {
            const strComparisonOp_EduClsTeacherTypeDesc = objPk2EduClsTeacherType_Cond.dicFldComparisonOp[clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeDesc];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeDesc, objPk2EduClsTeacherType_Cond.eduClsTeacherTypeDesc, strComparisonOp_EduClsTeacherTypeDesc);
        }
        return strWhereCond;
    }
    exports.Pk2EduClsTeacherType_GetCombineCondition = Pk2EduClsTeacherType_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objPk2EduClsTeacherTypeENS:源对象
     * @param objPk2EduClsTeacherTypeENT:目标对象
    */
    function Pk2EduClsTeacherType_CopyObjTo(objPk2EduClsTeacherTypeENS, objPk2EduClsTeacherTypeENT) {
        objPk2EduClsTeacherTypeENT.id_Pk2EduClsTeacherType = objPk2EduClsTeacherTypeENS.id_Pk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
        objPk2EduClsTeacherTypeENT.eduClsTeacherTypeID = objPk2EduClsTeacherTypeENS.eduClsTeacherTypeID; //教学班教学类型ID
        objPk2EduClsTeacherTypeENT.eduClsTeacherTypeDesc = objPk2EduClsTeacherTypeENS.eduClsTeacherTypeDesc; //教学班教师类型名
        objPk2EduClsTeacherTypeENT.sf_UpdFldSetStr = objPk2EduClsTeacherTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.Pk2EduClsTeacherType_CopyObjTo = Pk2EduClsTeacherType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objPk2EduClsTeacherTypeENS:源对象
     * @param objPk2EduClsTeacherTypeENT:目标对象
    */
    function Pk2EduClsTeacherType_GetObjFromJsonObj(objPk2EduClsTeacherTypeENS) {
        const objPk2EduClsTeacherTypeENT = new clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPk2EduClsTeacherTypeENT, objPk2EduClsTeacherTypeENS);
        return objPk2EduClsTeacherTypeENT;
    }
    exports.Pk2EduClsTeacherType_GetObjFromJsonObj = Pk2EduClsTeacherType_GetObjFromJsonObj;
});
