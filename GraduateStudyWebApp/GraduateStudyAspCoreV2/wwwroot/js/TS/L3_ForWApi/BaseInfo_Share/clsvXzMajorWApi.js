/**
* 类名:clsvXzMajorWApi
* 表名:vXzMajor(01120066)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:13:58
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/BaseInfo_Share/clsvXzMajorEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vXzMajor_GetObjFromJsonObj = exports.vXzMajor_CopyObjTo = exports.vXzMajor_GetCombineCondition = exports.vXzMajor_GetObjByJSONStr = exports.vXzMajor_GetObjLstByJSONObjLst = exports.vXzMajor_GetObjLstByJSONStr = exports.vXzMajor_GetJSONStrByObj = exports.vXzMajor__Cache = exports.vXzMajor_ReFreshThisCache = exports.vXzMajor_GetWebApiUrl = exports.vXzMajor_GetRecCountByCond_Cache = exports.vXzMajor_GetRecCountByCondAsync = exports.vXzMajor_IsExistAsync = exports.vXzMajor_IsExist_Cache = exports.vXzMajor_IsExist = exports.vXzMajor_IsExistRecordAsync = exports.vXzMajor_IsExistRecord_Cache = exports.vXzMajor_GetObjLstByPagerAsync = exports.vXzMajor_GetObjLstByPager_Cache = exports.vXzMajor_GetObjLstByRange = exports.vXzMajor_GetObjLstByRangeAsync = exports.vXzMajor_GetTopObjLstAsync = exports.vXzMajor_GetObjLstByid_XzMajorLst_Cache = exports.vXzMajor_GetObjLstByid_XzMajorLstAsync = exports.vXzMajor_GetSubObjLst_Cache = exports.vXzMajor_GetObjLst_PureCache = exports.vXzMajor_GetObjLst_Cache = exports.vXzMajor_GetObjLst_sessionStorage_PureCache = exports.vXzMajor_GetObjLst_sessionStorage = exports.vXzMajor_GetObjLstAsync = exports.vXzMajor_GetObjLst_localStorage_PureCache = exports.vXzMajor_GetObjLst_localStorage = exports.vXzMajor_GetObjLst_ClientCache = exports.vXzMajor_GetFirstObjAsync = exports.vXzMajor_GetFirstID = exports.vXzMajor_GetFirstIDAsync = exports.vXzMajor_funcKey = exports.vXzMajor_FilterFunByKey = exports.vXzMajor_SortFunByKey = exports.vXzMajor_SortFun_Defa_2Fld = exports.vXzMajor_SortFun_Defa = exports.vXzMajor_func = exports.vXzMajor_GetNameByid_XzMajor_Cache = exports.vXzMajor_GetObjByid_XzMajor_localStorage = exports.vXzMajor_GetObjByid_XzMajor_Cache = exports.vXzMajor_GetObjByid_XzMajorAsync = exports.vXzMajor_ConstructorName = exports.vXzMajor_Controller = void 0;
    /**
     * v专业(vXzMajor)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvXzMajorEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsvXzMajorEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vXzMajor_Controller = "vXzMajorApi";
    exports.vXzMajor_ConstructorName = "vXzMajor";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_XzMajor:关键字
    * @returns 对象
    **/
    async function vXzMajor_GetObjByid_XzMajorAsync(strid_XzMajor) {
        const strThisFuncName = "GetObjByid_XzMajorAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzMajor) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzMajor]不能为空！(In clsvXzMajorWApi.GetObjByid_XzMajorAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzMajor.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！(clsvXzMajorWApi.GetObjByid_XzMajorAsync)", strid_XzMajor.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_XzMajor";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_XzMajor": strid_XzMajor,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvXzMajor = vXzMajor_GetObjFromJsonObj(returnObj);
                return objvXzMajor;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajor_GetObjByid_XzMajorAsync = vXzMajor_GetObjByid_XzMajorAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_XzMajor:所给的关键字
     * @returns 对象
    */
    async function vXzMajor_GetObjByid_XzMajor_Cache(strid_XzMajor, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_XzMajor_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzMajor) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzMajor]不能为空！(In clsvXzMajorWApi.GetObjByid_XzMajor_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzMajor.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！(clsvXzMajorWApi.GetObjByid_XzMajor_Cache)", strid_XzMajor.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_Cache();
        try {
            const arrvXzMajor_Sel = arrvXzMajorObjLst_Cache.filter(x => x.id_XzMajor == strid_XzMajor);
            let objvXzMajor;
            if (arrvXzMajor_Sel.length > 0) {
                objvXzMajor = arrvXzMajor_Sel[0];
                return objvXzMajor;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvXzMajor_Const = await vXzMajor_GetObjByid_XzMajorAsync(strid_XzMajor);
                    if (objvXzMajor_Const != null) {
                        vXzMajor_ReFreshThisCache();
                        return objvXzMajor_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_XzMajor, exports.vXzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vXzMajor_GetObjByid_XzMajor_Cache = vXzMajor_GetObjByid_XzMajor_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_XzMajor:所给的关键字
     * @returns 对象
    */
    async function vXzMajor_GetObjByid_XzMajor_localStorage(strid_XzMajor) {
        const strThisFuncName = "GetObjByid_XzMajor_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzMajor) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzMajor]不能为空！(In clsvXzMajorWApi.GetObjByid_XzMajor_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzMajor.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！(clsvXzMajorWApi.GetObjByid_XzMajor_localStorage)", strid_XzMajor.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvXzMajorEN_js_1.clsvXzMajorEN._CurrTabName, strid_XzMajor);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvXzMajor_Cache = JSON.parse(strTempObj);
            return objvXzMajor_Cache;
        }
        try {
            const objvXzMajor = await vXzMajor_GetObjByid_XzMajorAsync(strid_XzMajor);
            if (objvXzMajor != null) {
                localStorage.setItem(strKey, JSON.stringify(objvXzMajor));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvXzMajor;
            }
            return objvXzMajor;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_XzMajor, exports.vXzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vXzMajor_GetObjByid_XzMajor_localStorage = vXzMajor_GetObjByid_XzMajor_localStorage;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_XzMajor:所给的关键字
     * @returns 对象
    */
    async function vXzMajor_GetNameByid_XzMajor_Cache(strid_XzMajor) {
        const strThisFuncName = "GetNameByid_XzMajor_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_XzMajor) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_XzMajor]不能为空！(In clsvXzMajorWApi.GetNameByid_XzMajor_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_XzMajor.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！(clsvXzMajorWApi.GetNameByid_XzMajor_Cache)", strid_XzMajor.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_Cache();
        if (arrvXzMajorObjLst_Cache == null)
            return "";
        try {
            const arrvXzMajor_Sel = arrvXzMajorObjLst_Cache.filter(x => x.id_XzMajor == strid_XzMajor);
            let objvXzMajor;
            if (arrvXzMajor_Sel.length > 0) {
                objvXzMajor = arrvXzMajor_Sel[0];
                return objvXzMajor.majorName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_XzMajor);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.vXzMajor_GetNameByid_XzMajor_Cache = vXzMajor_GetNameByid_XzMajor_Cache;
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
    async function vXzMajor_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzMajor) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvXzMajorEN_js_1.clsvXzMajorEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvXzMajorEN_js_1.clsvXzMajorEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_XzMajor = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvXzMajor = await vXzMajor_GetObjByid_XzMajor_Cache(strid_XzMajor);
        if (objvXzMajor == null)
            return "";
        if (objvXzMajor.GetFldValue(strOutFldName) == null)
            return "";
        return objvXzMajor.GetFldValue(strOutFldName).toString();
    }
    exports.vXzMajor_func = vXzMajor_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vXzMajor_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_XzMajor.localeCompare(b.id_XzMajor);
    }
    exports.vXzMajor_SortFun_Defa = vXzMajor_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vXzMajor_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.majorID == b.majorID)
            return a.majorName.localeCompare(b.majorName);
        else
            return a.majorID.localeCompare(b.majorID);
    }
    exports.vXzMajor_SortFun_Defa_2Fld = vXzMajor_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vXzMajor_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorID:
                    return (a, b) => {
                        return a.majorID.localeCompare(b.majorID);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorEnglishName:
                    return (a, b) => {
                        if (a.majorEnglishName == null)
                            return -1;
                        if (b.majorEnglishName == null)
                            return 1;
                        return a.majorEnglishName.localeCompare(b.majorEnglishName);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorExplain:
                    return (a, b) => {
                        if (a.majorExplain == null)
                            return -1;
                        if (b.majorExplain == null)
                            return 1;
                        return a.majorExplain.localeCompare(b.majorExplain);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorNationalID:
                    return (a, b) => {
                        if (a.majorNationalID == null)
                            return -1;
                        if (b.majorNationalID == null)
                            return 1;
                        return a.majorNationalID.localeCompare(b.majorNationalID);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeID:
                    return (a, b) => {
                        return a.collegeID.localeCompare(b.collegeID);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeName:
                    return (a, b) => {
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeNameA:
                    return (a, b) => {
                        if (a.collegeNameA == null)
                            return -1;
                        if (b.collegeNameA == null)
                            return 1;
                        return a.collegeNameA.localeCompare(b.collegeNameA);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_MajorType:
                    return (a, b) => {
                        if (a.id_MajorType == null)
                            return -1;
                        if (b.id_MajorType == null)
                            return 1;
                        return a.id_MajorType.localeCompare(b.id_MajorType);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorTypeName:
                    return (a, b) => {
                        return a.majorTypeName.localeCompare(b.majorTypeName);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_DegreeType:
                    return (a, b) => {
                        if (a.id_DegreeType == null)
                            return -1;
                        if (b.id_DegreeType == null)
                            return 1;
                        return a.id_DegreeType.localeCompare(b.id_DegreeType);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_XwTypeDesc:
                    return (a, b) => {
                        return a.xwTypeDesc.localeCompare(b.xwTypeDesc);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsMainMajor:
                    return (a, b) => {
                        if (a.isMainMajor == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorDirection:
                    return (a, b) => {
                        if (a.majorDirection == null)
                            return -1;
                        if (b.majorDirection == null)
                            return 1;
                        return a.majorDirection.localeCompare(b.majorDirection);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsVisible:
                    return (a, b) => {
                        if (a.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsNormal:
                    return (a, b) => {
                        if (a.isNormal == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_ModifyDate:
                    return (a, b) => {
                        if (a.modifyDate == null)
                            return -1;
                        if (b.modifyDate == null)
                            return 1;
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_ModifyUserID:
                    return (a, b) => {
                        if (a.modifyUserID == null)
                            return -1;
                        if (b.modifyUserID == null)
                            return 1;
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsVisible4XzClg:
                    return (a, b) => {
                        if (a.isVisible4XzClg == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_TypeName:
                    return (a, b) => {
                        if (a.typeName == null)
                            return -1;
                        if (b.typeName == null)
                            return 1;
                        return a.typeName.localeCompare(b.typeName);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzMajorShoolType:
                    return (a, b) => {
                        if (a.id_XzMajorShoolType == null)
                            return -1;
                        if (b.id_XzMajorShoolType == null)
                            return 1;
                        return a.id_XzMajorShoolType.localeCompare(b.id_XzMajorShoolType);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vXzMajor]中不存在！(in ${exports.vXzMajor_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorID:
                    return (a, b) => {
                        return b.majorID.localeCompare(a.majorID);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorEnglishName:
                    return (a, b) => {
                        if (b.majorEnglishName == null)
                            return -1;
                        if (a.majorEnglishName == null)
                            return 1;
                        return b.majorEnglishName.localeCompare(a.majorEnglishName);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorExplain:
                    return (a, b) => {
                        if (b.majorExplain == null)
                            return -1;
                        if (a.majorExplain == null)
                            return 1;
                        return b.majorExplain.localeCompare(a.majorExplain);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorNationalID:
                    return (a, b) => {
                        if (b.majorNationalID == null)
                            return -1;
                        if (a.majorNationalID == null)
                            return 1;
                        return b.majorNationalID.localeCompare(a.majorNationalID);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeID:
                    return (a, b) => {
                        return b.collegeID.localeCompare(a.collegeID);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeName:
                    return (a, b) => {
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeNameA:
                    return (a, b) => {
                        if (b.collegeNameA == null)
                            return -1;
                        if (a.collegeNameA == null)
                            return 1;
                        return b.collegeNameA.localeCompare(a.collegeNameA);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_MajorType:
                    return (a, b) => {
                        if (b.id_MajorType == null)
                            return -1;
                        if (a.id_MajorType == null)
                            return 1;
                        return b.id_MajorType.localeCompare(a.id_MajorType);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorTypeName:
                    return (a, b) => {
                        return b.majorTypeName.localeCompare(a.majorTypeName);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_DegreeType:
                    return (a, b) => {
                        if (b.id_DegreeType == null)
                            return -1;
                        if (a.id_DegreeType == null)
                            return 1;
                        return b.id_DegreeType.localeCompare(a.id_DegreeType);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_XwTypeDesc:
                    return (a, b) => {
                        return b.xwTypeDesc.localeCompare(a.xwTypeDesc);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsMainMajor:
                    return (a, b) => {
                        if (b.isMainMajor == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorDirection:
                    return (a, b) => {
                        if (b.majorDirection == null)
                            return -1;
                        if (a.majorDirection == null)
                            return 1;
                        return b.majorDirection.localeCompare(a.majorDirection);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsVisible:
                    return (a, b) => {
                        if (b.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsNormal:
                    return (a, b) => {
                        if (b.isNormal == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_ModifyDate:
                    return (a, b) => {
                        if (b.modifyDate == null)
                            return -1;
                        if (a.modifyDate == null)
                            return 1;
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_ModifyUserID:
                    return (a, b) => {
                        if (b.modifyUserID == null)
                            return -1;
                        if (a.modifyUserID == null)
                            return 1;
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsVisible4XzClg:
                    return (a, b) => {
                        if (b.isVisible4XzClg == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_TypeName:
                    return (a, b) => {
                        if (b.typeName == null)
                            return -1;
                        if (a.typeName == null)
                            return 1;
                        return b.typeName.localeCompare(a.typeName);
                    };
                case clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzMajorShoolType:
                    return (a, b) => {
                        if (b.id_XzMajorShoolType == null)
                            return -1;
                        if (a.id_XzMajorShoolType == null)
                            return 1;
                        return b.id_XzMajorShoolType.localeCompare(a.id_XzMajorShoolType);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vXzMajor]中不存在！(in ${exports.vXzMajor_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vXzMajor_SortFunByKey = vXzMajor_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vXzMajor_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorID:
                return (obj) => {
                    return obj.majorID === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorEnglishName:
                return (obj) => {
                    return obj.majorEnglishName === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorExplain:
                return (obj) => {
                    return obj.majorExplain === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorNationalID:
                return (obj) => {
                    return obj.majorNationalID === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeID:
                return (obj) => {
                    return obj.collegeID === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeNameA:
                return (obj) => {
                    return obj.collegeNameA === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_MajorType:
                return (obj) => {
                    return obj.id_MajorType === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorTypeName:
                return (obj) => {
                    return obj.majorTypeName === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_DegreeType:
                return (obj) => {
                    return obj.id_DegreeType === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_XwTypeDesc:
                return (obj) => {
                    return obj.xwTypeDesc === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsMainMajor:
                return (obj) => {
                    return obj.isMainMajor === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorDirection:
                return (obj) => {
                    return obj.majorDirection === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsVisible:
                return (obj) => {
                    return obj.isVisible === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsNormal:
                return (obj) => {
                    return obj.isNormal === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsVisible4XzClg:
                return (obj) => {
                    return obj.isVisible4XzClg === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_TypeName:
                return (obj) => {
                    return obj.typeName === value;
                };
            case clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzMajorShoolType:
                return (obj) => {
                    return obj.id_XzMajorShoolType === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vXzMajor]中不存在！(in ${exports.vXzMajor_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vXzMajor_FilterFunByKey = vXzMajor_FilterFunByKey;
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
    async function vXzMajor_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzMajor) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvXzMajor = await vXzMajor_GetObjLst_Cache();
        if (arrvXzMajor == null)
            return [];
        let arrvXzMajor_Sel = arrvXzMajor;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvXzMajor_Sel.length == 0)
            return [];
        return arrvXzMajor_Sel.map(x => x.id_XzMajor);
    }
    exports.vXzMajor_funcKey = vXzMajor_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vXzMajor_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajor_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajor_GetFirstIDAsync = vXzMajor_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vXzMajor_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajor_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajor_GetFirstID = vXzMajor_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vXzMajor_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajor_Controller, strAction);
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
                const objvXzMajor = vXzMajor_GetObjFromJsonObj(returnObj);
                return objvXzMajor;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajor_GetFirstObjAsync = vXzMajor_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vXzMajor_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvXzMajorEN_js_1.clsvXzMajorEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvXzMajorEN_js_1.clsvXzMajorEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvXzMajorEN_js_1.clsvXzMajorEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvXzMajorExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvXzMajorObjLst_T = vXzMajor_GetObjLstByJSONObjLst(arrvXzMajorExObjLst_Cache);
            return arrvXzMajorObjLst_T;
        }
        try {
            const arrvXzMajorExObjLst = await vXzMajor_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvXzMajorExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvXzMajorExObjLst.length);
            console.log(strInfo);
            return arrvXzMajorExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vXzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vXzMajor_GetObjLst_ClientCache = vXzMajor_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vXzMajor_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvXzMajorEN_js_1.clsvXzMajorEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvXzMajorEN_js_1.clsvXzMajorEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvXzMajorEN_js_1.clsvXzMajorEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvXzMajorExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvXzMajorObjLst_T = vXzMajor_GetObjLstByJSONObjLst(arrvXzMajorExObjLst_Cache);
            return arrvXzMajorObjLst_T;
        }
        try {
            const arrvXzMajorExObjLst = await vXzMajor_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvXzMajorExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvXzMajorExObjLst.length);
            console.log(strInfo);
            return arrvXzMajorExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vXzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vXzMajor_GetObjLst_localStorage = vXzMajor_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vXzMajor_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvXzMajorEN_js_1.clsvXzMajorEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvXzMajorObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvXzMajorObjLst_Cache;
        }
        else
            return null;
    }
    exports.vXzMajor_GetObjLst_localStorage_PureCache = vXzMajor_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vXzMajor_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzMajor_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajor_GetObjLstAsync = vXzMajor_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vXzMajor_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvXzMajorEN_js_1.clsvXzMajorEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvXzMajorEN_js_1.clsvXzMajorEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvXzMajorEN_js_1.clsvXzMajorEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvXzMajorExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvXzMajorObjLst_T = vXzMajor_GetObjLstByJSONObjLst(arrvXzMajorExObjLst_Cache);
            return arrvXzMajorObjLst_T;
        }
        try {
            const arrvXzMajorExObjLst = await vXzMajor_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvXzMajorExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvXzMajorExObjLst.length);
            console.log(strInfo);
            return arrvXzMajorExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vXzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vXzMajor_GetObjLst_sessionStorage = vXzMajor_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vXzMajor_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvXzMajorEN_js_1.clsvXzMajorEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvXzMajorObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvXzMajorObjLst_Cache;
        }
        else
            return null;
    }
    exports.vXzMajor_GetObjLst_sessionStorage_PureCache = vXzMajor_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vXzMajor_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvXzMajorObjLst_Cache;
        switch (clsvXzMajorEN_js_1.clsvXzMajorEN.CacheModeId) {
            case "04": //sessionStorage
                arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_ClientCache();
                break;
            default:
                arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_ClientCache();
                break;
        }
        const arrvXzMajorObjLst = vXzMajor_GetObjLstByJSONObjLst(arrvXzMajorObjLst_Cache);
        return arrvXzMajorObjLst_Cache;
    }
    exports.vXzMajor_GetObjLst_Cache = vXzMajor_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vXzMajor_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvXzMajorObjLst_Cache;
        switch (clsvXzMajorEN_js_1.clsvXzMajorEN.CacheModeId) {
            case "04": //sessionStorage
                arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvXzMajorObjLst_Cache = null;
                break;
            default:
                arrvXzMajorObjLst_Cache = null;
                break;
        }
        return arrvXzMajorObjLst_Cache;
    }
    exports.vXzMajor_GetObjLst_PureCache = vXzMajor_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_XzMajor_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vXzMajor_GetSubObjLst_Cache(objvXzMajor_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_Cache();
        let arrvXzMajor_Sel = arrvXzMajorObjLst_Cache;
        if (objvXzMajor_Cond.sf_FldComparisonOp == null || objvXzMajor_Cond.sf_FldComparisonOp == "")
            return arrvXzMajor_Sel;
        const dicFldComparisonOp = JSON.parse(objvXzMajor_Cond.sf_FldComparisonOp);
        //console.log("clsvXzMajorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvXzMajor_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvXzMajor_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvXzMajor_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvXzMajor_Cond), exports.vXzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vXzMajor_GetSubObjLst_Cache = vXzMajor_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_XzMajor:关键字列表
    * @returns 对象列表
    **/
    async function vXzMajor_GetObjLstByid_XzMajorLstAsync(arrid_XzMajor) {
        const strThisFuncName = "GetObjLstByid_XzMajorLstAsync";
        const strAction = "GetObjLstByid_XzMajorLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_XzMajor);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzMajor_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajor_GetObjLstByid_XzMajorLstAsync = vXzMajor_GetObjLstByid_XzMajorLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_XzMajorLst:关键字列表
     * @returns 对象列表
    */
    async function vXzMajor_GetObjLstByid_XzMajorLst_Cache(arrid_XzMajorLst) {
        const strThisFuncName = "GetObjLstByid_XzMajorLst_Cache";
        try {
            const arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_Cache();
            const arrvXzMajor_Sel = arrvXzMajorObjLst_Cache.filter(x => arrid_XzMajorLst.indexOf(x.id_XzMajor) > -1);
            return arrvXzMajor_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_XzMajorLst.join(","), exports.vXzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vXzMajor_GetObjLstByid_XzMajorLst_Cache = vXzMajor_GetObjLstByid_XzMajorLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vXzMajor_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzMajor_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajor_GetTopObjLstAsync = vXzMajor_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vXzMajor_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzMajor_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajor_GetObjLstByRangeAsync = vXzMajor_GetObjLstByRangeAsync;
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
    async function vXzMajor_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajor_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajor_GetObjLstByRange = vXzMajor_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vXzMajor_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_Cache();
        if (arrvXzMajorObjLst_Cache.length == 0)
            return arrvXzMajorObjLst_Cache;
        let arrvXzMajor_Sel = arrvXzMajorObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvXzMajor_Cond = new clsvXzMajorEN_js_1.clsvXzMajorEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvXzMajor_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvXzMajorWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvXzMajor_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvXzMajor_Sel.length == 0)
                return arrvXzMajor_Sel;
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
                arrvXzMajor_Sel = arrvXzMajor_Sel.sort(vXzMajor_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvXzMajor_Sel = arrvXzMajor_Sel.sort(objPagerPara.sortFun);
            }
            arrvXzMajor_Sel = arrvXzMajor_Sel.slice(intStart, intEnd);
            return arrvXzMajor_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vXzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vXzMajor_GetObjLstByPager_Cache = vXzMajor_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vXzMajor_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzMajor_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajor_GetObjLstByPagerAsync = vXzMajor_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_XzMajor_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vXzMajor_IsExistRecord_Cache(objvXzMajor_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_Cache();
        if (arrvXzMajorObjLst_Cache == null)
            return false;
        let arrvXzMajor_Sel = arrvXzMajorObjLst_Cache;
        if (objvXzMajor_Cond.sf_FldComparisonOp == null || objvXzMajor_Cond.sf_FldComparisonOp == "")
            return arrvXzMajor_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvXzMajor_Cond.sf_FldComparisonOp);
        //console.log("clsvXzMajorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvXzMajor_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvXzMajor_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvXzMajor_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvXzMajor_Cond), exports.vXzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vXzMajor_IsExistRecord_Cache = vXzMajor_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vXzMajor_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajor_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajor_IsExistRecordAsync = vXzMajor_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_XzMajor:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vXzMajor_IsExist(strid_XzMajor, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_XzMajor": strid_XzMajor,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajor_IsExist = vXzMajor_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_XzMajor:所给的关键字
     * @returns 对象
    */
    async function vXzMajor_IsExist_Cache(strid_XzMajor) {
        const strThisFuncName = "IsExist_Cache";
        const arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_Cache();
        if (arrvXzMajorObjLst_Cache == null)
            return false;
        try {
            const arrvXzMajor_Sel = arrvXzMajorObjLst_Cache.filter(x => x.id_XzMajor == strid_XzMajor);
            if (arrvXzMajor_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_XzMajor, exports.vXzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vXzMajor_IsExist_Cache = vXzMajor_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_XzMajor:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vXzMajor_IsExistAsync(strid_XzMajor) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajor_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_XzMajor": strid_XzMajor }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajor_IsExistAsync = vXzMajor_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vXzMajor_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzMajor_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzMajor_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzMajor_GetRecCountByCondAsync = vXzMajor_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvXzMajor_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vXzMajor_GetRecCountByCond_Cache(objvXzMajor_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_Cache();
        if (arrvXzMajorObjLst_Cache == null)
            return 0;
        let arrvXzMajor_Sel = arrvXzMajorObjLst_Cache;
        if (objvXzMajor_Cond.sf_FldComparisonOp == null || objvXzMajor_Cond.sf_FldComparisonOp == "")
            return arrvXzMajor_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvXzMajor_Cond.sf_FldComparisonOp);
        //console.log("clsvXzMajorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvXzMajor_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvXzMajor_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvXzMajor_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvXzMajor_Cond), exports.vXzMajor_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vXzMajor_GetRecCountByCond_Cache = vXzMajor_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vXzMajor_GetWebApiUrl(strController, strAction) {
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
    exports.vXzMajor_GetWebApiUrl = vXzMajor_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vXzMajor_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvXzMajorEN_js_1.clsvXzMajorEN._CurrTabName;
            switch (clsvXzMajorEN_js_1.clsvXzMajorEN.CacheModeId) {
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
    exports.vXzMajor_ReFreshThisCache = vXzMajor_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function vXzMajor__Cache(strDivName, strDdlName) {
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
        const arrObjLst_Sel = await vXzMajor_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv_V)(strDivName, strDdlName, arrObjLst_Sel, clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzMajor, clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorName, "v专业");
    }
    exports.vXzMajor__Cache = vXzMajor__Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vXzMajor_GetJSONStrByObj(pobjvXzMajorEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvXzMajorEN);
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
    exports.vXzMajor_GetJSONStrByObj = vXzMajor_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vXzMajor_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvXzMajorObjLst = new Array();
        if (strJSON === "") {
            return arrvXzMajorObjLst;
        }
        try {
            arrvXzMajorObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvXzMajorObjLst;
        }
        return arrvXzMajorObjLst;
    }
    exports.vXzMajor_GetObjLstByJSONStr = vXzMajor_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvXzMajorObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vXzMajor_GetObjLstByJSONObjLst(arrvXzMajorObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvXzMajorObjLst = new Array();
        for (const objInFor of arrvXzMajorObjLstS) {
            const obj1 = vXzMajor_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvXzMajorObjLst.push(obj1);
        }
        return arrvXzMajorObjLst;
    }
    exports.vXzMajor_GetObjLstByJSONObjLst = vXzMajor_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vXzMajor_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvXzMajorEN = new clsvXzMajorEN_js_1.clsvXzMajorEN();
        if (strJSON === "") {
            return pobjvXzMajorEN;
        }
        try {
            pobjvXzMajorEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvXzMajorEN;
        }
        return pobjvXzMajorEN;
    }
    exports.vXzMajor_GetObjByJSONStr = vXzMajor_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vXzMajor_GetCombineCondition(objvXzMajor_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzMajor, objvXzMajor_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorID) == true) {
            const strComparisonOp_MajorID = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorID, objvXzMajor_Cond.majorID, strComparisonOp_MajorID);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorName, objvXzMajor_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorEnglishName) == true) {
            const strComparisonOp_MajorEnglishName = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorEnglishName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorEnglishName, objvXzMajor_Cond.majorEnglishName, strComparisonOp_MajorEnglishName);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorExplain) == true) {
            const strComparisonOp_MajorExplain = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorExplain];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorExplain, objvXzMajor_Cond.majorExplain, strComparisonOp_MajorExplain);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorNationalID) == true) {
            const strComparisonOp_MajorNationalID = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorNationalID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorNationalID, objvXzMajor_Cond.majorNationalID, strComparisonOp_MajorNationalID);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzCollege, objvXzMajor_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeID) == true) {
            const strComparisonOp_CollegeID = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeID, objvXzMajor_Cond.collegeID, strComparisonOp_CollegeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeName, objvXzMajor_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeNameA) == true) {
            const strComparisonOp_CollegeNameA = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeNameA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_CollegeNameA, objvXzMajor_Cond.collegeNameA, strComparisonOp_CollegeNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_MajorType) == true) {
            const strComparisonOp_id_MajorType = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_MajorType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_MajorType, objvXzMajor_Cond.id_MajorType, strComparisonOp_id_MajorType);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorTypeName) == true) {
            const strComparisonOp_MajorTypeName = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorTypeName, objvXzMajor_Cond.majorTypeName, strComparisonOp_MajorTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_DegreeType) == true) {
            const strComparisonOp_id_DegreeType = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_DegreeType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_DegreeType, objvXzMajor_Cond.id_DegreeType, strComparisonOp_id_DegreeType);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_XwTypeDesc) == true) {
            const strComparisonOp_XwTypeDesc = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_XwTypeDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_XwTypeDesc, objvXzMajor_Cond.xwTypeDesc, strComparisonOp_XwTypeDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsMainMajor) == true) {
            if (objvXzMajor_Cond.isMainMajor == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsMainMajor);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsMainMajor);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorDirection) == true) {
            const strComparisonOp_MajorDirection = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorDirection];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_MajorDirection, objvXzMajor_Cond.majorDirection, strComparisonOp_MajorDirection);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsVisible) == true) {
            if (objvXzMajor_Cond.isVisible == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsVisible);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsVisible);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsNormal) == true) {
            if (objvXzMajor_Cond.isNormal == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsNormal);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsNormal);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_ModifyDate, objvXzMajor_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_ModifyUserID, objvXzMajor_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_Memo, objvXzMajor_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsVisible4XzClg) == true) {
            if (objvXzMajor_Cond.isVisible4XzClg == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsVisible4XzClg);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_IsVisible4XzClg);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_TypeName) == true) {
            const strComparisonOp_TypeName = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_TypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_TypeName, objvXzMajor_Cond.typeName, strComparisonOp_TypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzMajorShoolType) == true) {
            const strComparisonOp_id_XzMajorShoolType = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzMajorShoolType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzMajorEN_js_1.clsvXzMajorEN.con_id_XzMajorShoolType, objvXzMajor_Cond.id_XzMajorShoolType, strComparisonOp_id_XzMajorShoolType);
        }
        return strWhereCond;
    }
    exports.vXzMajor_GetCombineCondition = vXzMajor_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvXzMajorENS:源对象
     * @param objvXzMajorENT:目标对象
    */
    function vXzMajor_CopyObjTo(objvXzMajorENS, objvXzMajorENT) {
        objvXzMajorENT.id_XzMajor = objvXzMajorENS.id_XzMajor; //专业流水号
        objvXzMajorENT.majorID = objvXzMajorENS.majorID; //专业ID
        objvXzMajorENT.majorName = objvXzMajorENS.majorName; //专业名称
        objvXzMajorENT.majorEnglishName = objvXzMajorENS.majorEnglishName; //专业英文名称
        objvXzMajorENT.majorExplain = objvXzMajorENS.majorExplain; //专业说明
        objvXzMajorENT.majorNationalID = objvXzMajorENS.majorNationalID; //专业国家代码
        objvXzMajorENT.id_XzCollege = objvXzMajorENS.id_XzCollege; //学院流水号
        objvXzMajorENT.collegeID = objvXzMajorENS.collegeID; //学院ID
        objvXzMajorENT.collegeName = objvXzMajorENS.collegeName; //学院名称
        objvXzMajorENT.collegeNameA = objvXzMajorENS.collegeNameA; //学院名称简写
        objvXzMajorENT.id_MajorType = objvXzMajorENS.id_MajorType; //专业类型(文理工)流水号
        objvXzMajorENT.majorTypeName = objvXzMajorENS.majorTypeName; //专业类型名称
        objvXzMajorENT.id_DegreeType = objvXzMajorENS.id_DegreeType; //学位类型流水号
        objvXzMajorENT.xwTypeDesc = objvXzMajorENS.xwTypeDesc; //学位类型名称
        objvXzMajorENT.isMainMajor = objvXzMajorENS.isMainMajor; //是否重要专业
        objvXzMajorENT.majorDirection = objvXzMajorENS.majorDirection; //专业方向
        objvXzMajorENT.isVisible = objvXzMajorENS.isVisible; //是否显示
        objvXzMajorENT.isNormal = objvXzMajorENS.isNormal; //IsNormal
        objvXzMajorENT.modifyDate = objvXzMajorENS.modifyDate; //修改日期
        objvXzMajorENT.modifyUserID = objvXzMajorENS.modifyUserID; //修改人
        objvXzMajorENT.memo = objvXzMajorENS.memo; //备注
        objvXzMajorENT.isVisible4XzClg = objvXzMajorENS.isVisible4XzClg; //IsVisible4XzClg
        objvXzMajorENT.typeName = objvXzMajorENS.typeName; //类型名称
        objvXzMajorENT.id_XzMajorShoolType = objvXzMajorENS.id_XzMajorShoolType; //专业学校类型流水号
    }
    exports.vXzMajor_CopyObjTo = vXzMajor_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvXzMajorENS:源对象
     * @param objvXzMajorENT:目标对象
    */
    function vXzMajor_GetObjFromJsonObj(objvXzMajorENS) {
        const objvXzMajorENT = new clsvXzMajorEN_js_1.clsvXzMajorEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvXzMajorENT, objvXzMajorENS);
        return objvXzMajorENT;
    }
    exports.vXzMajor_GetObjFromJsonObj = vXzMajor_GetObjFromJsonObj;
});
