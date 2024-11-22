/**
* 类名:clsvStudentInfoWApi
* 表名:vStudentInfo(01120132)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:14:07
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:用户管理(UserManage)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/UserManage_Share/clsvStudentInfoEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vStudentInfo_GetObjFromJsonObj = exports.vStudentInfo_CopyObjTo = exports.vStudentInfo_GetCombineCondition = exports.vStudentInfo_GetObjByJSONStr = exports.vStudentInfo_GetObjLstByJSONObjLst = exports.vStudentInfo_GetObjLstByJSONStr = exports.vStudentInfo_GetJSONStrByObj = exports.vStudentInfo_ReFreshThisCache = exports.vStudentInfo_GetWebApiUrl = exports.vStudentInfo_GetRecCountByCond_Cache = exports.vStudentInfo_GetRecCountByCondAsync = exports.vStudentInfo_IsExistAsync = exports.vStudentInfo_IsExist_Cache = exports.vStudentInfo_IsExist = exports.vStudentInfo_IsExistRecordAsync = exports.vStudentInfo_IsExistRecord_Cache = exports.vStudentInfo_GetObjLstByPagerAsync = exports.vStudentInfo_GetObjLstByPager_Cache = exports.vStudentInfo_GetObjLstByRange = exports.vStudentInfo_GetObjLstByRangeAsync = exports.vStudentInfo_GetTopObjLstAsync = exports.vStudentInfo_GetObjLstByid_StudentInfoLst_Cache = exports.vStudentInfo_GetObjLstByid_StudentInfoLstAsync = exports.vStudentInfo_GetSubObjLst_Cache = exports.vStudentInfo_GetObjLst_PureCache = exports.vStudentInfo_GetObjLst_Cache = exports.vStudentInfo_GetObjLst_sessionStorage_PureCache = exports.vStudentInfo_GetObjLst_sessionStorage = exports.vStudentInfo_GetObjLstAsync = exports.vStudentInfo_GetObjLst_localStorage_PureCache = exports.vStudentInfo_GetObjLst_localStorage = exports.vStudentInfo_GetObjLst_ClientCache = exports.vStudentInfo_GetFirstObjAsync = exports.vStudentInfo_GetFirstID = exports.vStudentInfo_GetFirstIDAsync = exports.vStudentInfo_funcKey = exports.vStudentInfo_FilterFunByKey = exports.vStudentInfo_SortFunByKey = exports.vStudentInfo_SortFun_Defa_2Fld = exports.vStudentInfo_SortFun_Defa = exports.vStudentInfo_func = exports.vStudentInfo_GetObjByid_StudentInfo_localStorage = exports.vStudentInfo_GetObjByid_StudentInfo_Cache = exports.vStudentInfo_GetObjByid_StudentInfoAsync = exports.vStudentInfo_ConstructorName = exports.vStudentInfo_Controller = void 0;
    /**
     * v学生(vStudentInfo)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvStudentInfoEN_js_1 = require("../../L0_Entity/UserManage_Share/clsvStudentInfoEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vStudentInfo_Controller = "vStudentInfoApi";
    exports.vStudentInfo_ConstructorName = "vStudentInfo";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_StudentInfo:关键字
    * @returns 对象
    **/
    async function vStudentInfo_GetObjByid_StudentInfoAsync(strid_StudentInfo) {
        const strThisFuncName = "GetObjByid_StudentInfoAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_StudentInfo) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_StudentInfo]不能为空！(In clsvStudentInfoWApi.GetObjByid_StudentInfoAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_StudentInfo.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_StudentInfo]的长度:[{0}]不正确！(clsvStudentInfoWApi.GetObjByid_StudentInfoAsync)", strid_StudentInfo.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_StudentInfo";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vStudentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_StudentInfo": strid_StudentInfo,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvStudentInfo = vStudentInfo_GetObjFromJsonObj(returnObj);
                return objvStudentInfo;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vStudentInfo_GetObjByid_StudentInfoAsync = vStudentInfo_GetObjByid_StudentInfoAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_StudentInfo:所给的关键字
     * @returns 对象
    */
    async function vStudentInfo_GetObjByid_StudentInfo_Cache(strid_StudentInfo, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_StudentInfo_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_StudentInfo) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_StudentInfo]不能为空！(In clsvStudentInfoWApi.GetObjByid_StudentInfo_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_StudentInfo.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_StudentInfo]的长度:[{0}]不正确！(clsvStudentInfoWApi.GetObjByid_StudentInfo_Cache)", strid_StudentInfo.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvStudentInfoObjLst_Cache = await vStudentInfo_GetObjLst_Cache();
        try {
            const arrvStudentInfo_Sel = arrvStudentInfoObjLst_Cache.filter(x => x.id_StudentInfo == strid_StudentInfo);
            let objvStudentInfo;
            if (arrvStudentInfo_Sel.length > 0) {
                objvStudentInfo = arrvStudentInfo_Sel[0];
                return objvStudentInfo;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvStudentInfo_Const = await vStudentInfo_GetObjByid_StudentInfoAsync(strid_StudentInfo);
                    if (objvStudentInfo_Const != null) {
                        vStudentInfo_ReFreshThisCache();
                        return objvStudentInfo_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_StudentInfo, exports.vStudentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vStudentInfo_GetObjByid_StudentInfo_Cache = vStudentInfo_GetObjByid_StudentInfo_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_StudentInfo:所给的关键字
     * @returns 对象
    */
    async function vStudentInfo_GetObjByid_StudentInfo_localStorage(strid_StudentInfo) {
        const strThisFuncName = "GetObjByid_StudentInfo_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_StudentInfo) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_StudentInfo]不能为空！(In clsvStudentInfoWApi.GetObjByid_StudentInfo_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_StudentInfo.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_StudentInfo]的长度:[{0}]不正确！(clsvStudentInfoWApi.GetObjByid_StudentInfo_localStorage)", strid_StudentInfo.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvStudentInfoEN_js_1.clsvStudentInfoEN._CurrTabName, strid_StudentInfo);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvStudentInfo_Cache = JSON.parse(strTempObj);
            return objvStudentInfo_Cache;
        }
        try {
            const objvStudentInfo = await vStudentInfo_GetObjByid_StudentInfoAsync(strid_StudentInfo);
            if (objvStudentInfo != null) {
                localStorage.setItem(strKey, JSON.stringify(objvStudentInfo));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvStudentInfo;
            }
            return objvStudentInfo;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_StudentInfo, exports.vStudentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vStudentInfo_GetObjByid_StudentInfo_localStorage = vStudentInfo_GetObjByid_StudentInfo_localStorage;
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
    async function vStudentInfo_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_StudentInfo) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvStudentInfoEN_js_1.clsvStudentInfoEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvStudentInfoEN_js_1.clsvStudentInfoEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_StudentInfo = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvStudentInfo = await vStudentInfo_GetObjByid_StudentInfo_Cache(strid_StudentInfo);
        if (objvStudentInfo == null)
            return "";
        if (objvStudentInfo.GetFldValue(strOutFldName) == null)
            return "";
        return objvStudentInfo.GetFldValue(strOutFldName).toString();
    }
    exports.vStudentInfo_func = vStudentInfo_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vStudentInfo_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_StudentInfo.localeCompare(b.id_StudentInfo);
    }
    exports.vStudentInfo_SortFun_Defa = vStudentInfo_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vStudentInfo_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.stuID == b.stuID)
            return a.stuName.localeCompare(b.stuName);
        else
            return a.stuID.localeCompare(b.stuID);
    }
    exports.vStudentInfo_SortFun_Defa_2Fld = vStudentInfo_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vStudentInfo_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_StudentInfo:
                    return (a, b) => {
                        return a.id_StudentInfo.localeCompare(b.id_StudentInfo);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuID:
                    return (a, b) => {
                        return a.stuID.localeCompare(b.stuID);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuName:
                    return (a, b) => {
                        return a.stuName.localeCompare(b.stuName);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Politics:
                    return (a, b) => {
                        return a.id_Politics.localeCompare(b.id_Politics);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PoliticsID:
                    return (a, b) => {
                        if (a.politicsID == null)
                            return -1;
                        if (b.politicsID == null)
                            return 1;
                        return a.politicsID.localeCompare(b.politicsID);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PoliticsName:
                    return (a, b) => {
                        return a.politicsName.localeCompare(b.politicsName);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Sex:
                    return (a, b) => {
                        return a.id_Sex.localeCompare(b.id_Sex);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_SexDesc:
                    return (a, b) => {
                        if (a.sexDesc == null)
                            return -1;
                        if (b.sexDesc == null)
                            return 1;
                        return a.sexDesc.localeCompare(b.sexDesc);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Ethnic:
                    return (a, b) => {
                        return a.id_Ethnic.localeCompare(b.id_Ethnic);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EthnicID:
                    return (a, b) => {
                        if (a.ethnicID == null)
                            return -1;
                        if (b.ethnicID == null)
                            return 1;
                        return a.ethnicID.localeCompare(b.ethnicID);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EthnicName:
                    return (a, b) => {
                        if (a.ethnicName == null)
                            return -1;
                        if (b.ethnicName == null)
                            return 1;
                        return a.ethnicName.localeCompare(b.ethnicName);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_UniZone:
                    return (a, b) => {
                        return a.id_UniZone.localeCompare(b.id_UniZone);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UniZoneDesc:
                    return (a, b) => {
                        return a.uniZoneDesc.localeCompare(b.uniZoneDesc);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_StuType:
                    return (a, b) => {
                        if (a.id_StuType == null)
                            return -1;
                        if (b.id_StuType == null)
                            return 1;
                        return a.id_StuType.localeCompare(b.id_StuType);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuTypeID:
                    return (a, b) => {
                        if (a.stuTypeID == null)
                            return -1;
                        if (b.stuTypeID == null)
                            return 1;
                        return a.stuTypeID.localeCompare(b.stuTypeID);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuTypeDesc:
                    return (a, b) => {
                        if (a.stuTypeDesc == null)
                            return -1;
                        if (b.stuTypeDesc == null)
                            return 1;
                        return a.stuTypeDesc.localeCompare(b.stuTypeDesc);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeID:
                    return (a, b) => {
                        if (a.collegeID == null)
                            return -1;
                        if (b.collegeID == null)
                            return 1;
                        return a.collegeID.localeCompare(b.collegeID);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeName:
                    return (a, b) => {
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeIdInGP:
                    return (a, b) => {
                        if (a.collegeIdInGP == null)
                            return -1;
                        if (b.collegeIdInGP == null)
                            return 1;
                        return a.collegeIdInGP.localeCompare(b.collegeIdInGP);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeNameA:
                    return (a, b) => {
                        if (a.collegeNameA == null)
                            return -1;
                        if (b.collegeNameA == null)
                            return 1;
                        return a.collegeNameA.localeCompare(b.collegeNameA);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_XzMajor:
                    return (a, b) => {
                        if (a.id_XzMajor == null)
                            return -1;
                        if (b.id_XzMajor == null)
                            return 1;
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_MajorID:
                    return (a, b) => {
                        if (a.majorID == null)
                            return -1;
                        if (b.majorID == null)
                            return 1;
                        return a.majorID.localeCompare(b.majorID);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsNormal:
                    return (a, b) => {
                        if (a.isNormal == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_GradeBase:
                    return (a, b) => {
                        return a.id_GradeBase.localeCompare(b.id_GradeBase);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_GradeBaseName:
                    return (a, b) => {
                        if (a.gradeBaseName == null)
                            return -1;
                        if (b.gradeBaseName == null)
                            return 1;
                        return a.gradeBaseName.localeCompare(b.gradeBaseName);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_AdminCls:
                    return (a, b) => {
                        return a.id_AdminCls.localeCompare(b.id_AdminCls);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsName:
                    return (a, b) => {
                        if (a.adminClsName == null)
                            return -1;
                        if (b.adminClsName == null)
                            return 1;
                        return a.adminClsName.localeCompare(b.adminClsName);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsId:
                    return (a, b) => {
                        if (a.adminClsId == null)
                            return -1;
                        if (b.adminClsId == null)
                            return 1;
                        return a.adminClsId.localeCompare(b.adminClsId);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_AdminClsType:
                    return (a, b) => {
                        if (a.id_AdminClsType == null)
                            return -1;
                        if (b.id_AdminClsType == null)
                            return 1;
                        return a.id_AdminClsType.localeCompare(b.id_AdminClsType);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsTypeName:
                    return (a, b) => {
                        if (a.adminClsTypeName == null)
                            return -1;
                        if (b.adminClsTypeName == null)
                            return 1;
                        return a.adminClsTypeName.localeCompare(b.adminClsTypeName);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Birthday:
                    return (a, b) => {
                        if (a.birthday == null)
                            return -1;
                        if (b.birthday == null)
                            return 1;
                        return a.birthday.localeCompare(b.birthday);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_NativePlace:
                    return (a, b) => {
                        if (a.nativePlace == null)
                            return -1;
                        if (b.nativePlace == null)
                            return 1;
                        return a.nativePlace.localeCompare(b.nativePlace);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Duty:
                    return (a, b) => {
                        if (a.duty == null)
                            return -1;
                        if (b.duty == null)
                            return 1;
                        return a.duty.localeCompare(b.duty);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IDCardNo:
                    return (a, b) => {
                        if (a.idCardNo == null)
                            return -1;
                        if (b.idCardNo == null)
                            return 1;
                        return a.idCardNo.localeCompare(b.idCardNo);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuCardNo:
                    return (a, b) => {
                        if (a.stuCardNo == null)
                            return -1;
                        if (b.stuCardNo == null)
                            return 1;
                        return a.stuCardNo.localeCompare(b.stuCardNo);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_LiveAddress:
                    return (a, b) => {
                        if (a.liveAddress == null)
                            return -1;
                        if (b.liveAddress == null)
                            return 1;
                        return a.liveAddress.localeCompare(b.liveAddress);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_HomePhone:
                    return (a, b) => {
                        if (a.homePhone == null)
                            return -1;
                        if (b.homePhone == null)
                            return 1;
                        return a.homePhone.localeCompare(b.homePhone);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Id_CardNo:
                    return (a, b) => {
                        if (a.id_CardNo == null)
                            return -1;
                        if (b.id_CardNo == null)
                            return 1;
                        return a.id_CardNo.localeCompare(b.id_CardNo);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CardNo:
                    return (a, b) => {
                        if (a.cardNo == null)
                            return -1;
                        if (b.cardNo == null)
                            return 1;
                        return a.cardNo.localeCompare(b.cardNo);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsAvconClassUser:
                    return (a, b) => {
                        if (a.isAvconClassUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsAvconUser:
                    return (a, b) => {
                        if (a.isAvconUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsGpUser:
                    return (a, b) => {
                        if (a.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsLocalUser:
                    return (a, b) => {
                        if (a.isLocalUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsLeaved:
                    return (a, b) => {
                        if (a.isLeaved == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UserId:
                    return (a, b) => {
                        if (a.userId == null)
                            return -1;
                        if (b.userId == null)
                            return 1;
                        return a.userId.localeCompare(b.userId);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UserID4Avcon:
                    return (a, b) => {
                        if (a.userID4Avcon == null)
                            return -1;
                        if (b.userID4Avcon == null)
                            return 1;
                        return a.userID4Avcon.localeCompare(b.userID4Avcon);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EnrollmentDate:
                    return (a, b) => {
                        if (a.enrollmentDate == null)
                            return -1;
                        if (b.enrollmentDate == null)
                            return 1;
                        return a.enrollmentDate.localeCompare(b.enrollmentDate);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PostCode:
                    return (a, b) => {
                        if (a.postCode == null)
                            return -1;
                        if (b.postCode == null)
                            return 1;
                        return a.postCode.localeCompare(b.postCode);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Email:
                    return (a, b) => {
                        if (a.email == null)
                            return -1;
                        if (b.email == null)
                            return 1;
                        return a.email.localeCompare(b.email);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsMessage:
                    return (a, b) => {
                        if (a.isMessage == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Microblog:
                    return (a, b) => {
                        if (a.microblog == null)
                            return -1;
                        if (b.microblog == null)
                            return 1;
                        return a.microblog.localeCompare(b.microblog);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PhoneNumber:
                    return (a, b) => {
                        if (a.phoneNumber == null)
                            return -1;
                        if (b.phoneNumber == null)
                            return 1;
                        return a.phoneNumber.localeCompare(b.phoneNumber);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_QQ:
                    return (a, b) => {
                        if (a.qQ == null)
                            return -1;
                        if (b.qQ == null)
                            return 1;
                        return a.qQ.localeCompare(b.qQ);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_RegisterPassword:
                    return (a, b) => {
                        if (a.registerPassword == null)
                            return -1;
                        if (b.registerPassword == null)
                            return 1;
                        return a.registerPassword.localeCompare(b.registerPassword);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vStudentInfo]中不存在！(in ${exports.vStudentInfo_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_StudentInfo:
                    return (a, b) => {
                        return b.id_StudentInfo.localeCompare(a.id_StudentInfo);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuID:
                    return (a, b) => {
                        return b.stuID.localeCompare(a.stuID);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuName:
                    return (a, b) => {
                        return b.stuName.localeCompare(a.stuName);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Politics:
                    return (a, b) => {
                        return b.id_Politics.localeCompare(a.id_Politics);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PoliticsID:
                    return (a, b) => {
                        if (b.politicsID == null)
                            return -1;
                        if (a.politicsID == null)
                            return 1;
                        return b.politicsID.localeCompare(a.politicsID);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PoliticsName:
                    return (a, b) => {
                        return b.politicsName.localeCompare(a.politicsName);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Sex:
                    return (a, b) => {
                        return b.id_Sex.localeCompare(a.id_Sex);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_SexDesc:
                    return (a, b) => {
                        if (b.sexDesc == null)
                            return -1;
                        if (a.sexDesc == null)
                            return 1;
                        return b.sexDesc.localeCompare(a.sexDesc);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Ethnic:
                    return (a, b) => {
                        return b.id_Ethnic.localeCompare(a.id_Ethnic);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EthnicID:
                    return (a, b) => {
                        if (b.ethnicID == null)
                            return -1;
                        if (a.ethnicID == null)
                            return 1;
                        return b.ethnicID.localeCompare(a.ethnicID);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EthnicName:
                    return (a, b) => {
                        if (b.ethnicName == null)
                            return -1;
                        if (a.ethnicName == null)
                            return 1;
                        return b.ethnicName.localeCompare(a.ethnicName);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_UniZone:
                    return (a, b) => {
                        return b.id_UniZone.localeCompare(a.id_UniZone);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UniZoneDesc:
                    return (a, b) => {
                        return b.uniZoneDesc.localeCompare(a.uniZoneDesc);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_StuType:
                    return (a, b) => {
                        if (b.id_StuType == null)
                            return -1;
                        if (a.id_StuType == null)
                            return 1;
                        return b.id_StuType.localeCompare(a.id_StuType);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuTypeID:
                    return (a, b) => {
                        if (b.stuTypeID == null)
                            return -1;
                        if (a.stuTypeID == null)
                            return 1;
                        return b.stuTypeID.localeCompare(a.stuTypeID);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuTypeDesc:
                    return (a, b) => {
                        if (b.stuTypeDesc == null)
                            return -1;
                        if (a.stuTypeDesc == null)
                            return 1;
                        return b.stuTypeDesc.localeCompare(a.stuTypeDesc);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeID:
                    return (a, b) => {
                        if (b.collegeID == null)
                            return -1;
                        if (a.collegeID == null)
                            return 1;
                        return b.collegeID.localeCompare(a.collegeID);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeName:
                    return (a, b) => {
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeIdInGP:
                    return (a, b) => {
                        if (b.collegeIdInGP == null)
                            return -1;
                        if (a.collegeIdInGP == null)
                            return 1;
                        return b.collegeIdInGP.localeCompare(a.collegeIdInGP);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeNameA:
                    return (a, b) => {
                        if (b.collegeNameA == null)
                            return -1;
                        if (a.collegeNameA == null)
                            return 1;
                        return b.collegeNameA.localeCompare(a.collegeNameA);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_XzMajor:
                    return (a, b) => {
                        if (b.id_XzMajor == null)
                            return -1;
                        if (a.id_XzMajor == null)
                            return 1;
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_MajorID:
                    return (a, b) => {
                        if (b.majorID == null)
                            return -1;
                        if (a.majorID == null)
                            return 1;
                        return b.majorID.localeCompare(a.majorID);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsNormal:
                    return (a, b) => {
                        if (b.isNormal == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_GradeBase:
                    return (a, b) => {
                        return b.id_GradeBase.localeCompare(a.id_GradeBase);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_GradeBaseName:
                    return (a, b) => {
                        if (b.gradeBaseName == null)
                            return -1;
                        if (a.gradeBaseName == null)
                            return 1;
                        return b.gradeBaseName.localeCompare(a.gradeBaseName);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_AdminCls:
                    return (a, b) => {
                        return b.id_AdminCls.localeCompare(a.id_AdminCls);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsName:
                    return (a, b) => {
                        if (b.adminClsName == null)
                            return -1;
                        if (a.adminClsName == null)
                            return 1;
                        return b.adminClsName.localeCompare(a.adminClsName);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsId:
                    return (a, b) => {
                        if (b.adminClsId == null)
                            return -1;
                        if (a.adminClsId == null)
                            return 1;
                        return b.adminClsId.localeCompare(a.adminClsId);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_AdminClsType:
                    return (a, b) => {
                        if (b.id_AdminClsType == null)
                            return -1;
                        if (a.id_AdminClsType == null)
                            return 1;
                        return b.id_AdminClsType.localeCompare(a.id_AdminClsType);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsTypeName:
                    return (a, b) => {
                        if (b.adminClsTypeName == null)
                            return -1;
                        if (a.adminClsTypeName == null)
                            return 1;
                        return b.adminClsTypeName.localeCompare(a.adminClsTypeName);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Birthday:
                    return (a, b) => {
                        if (b.birthday == null)
                            return -1;
                        if (a.birthday == null)
                            return 1;
                        return b.birthday.localeCompare(a.birthday);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_NativePlace:
                    return (a, b) => {
                        if (b.nativePlace == null)
                            return -1;
                        if (a.nativePlace == null)
                            return 1;
                        return b.nativePlace.localeCompare(a.nativePlace);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Duty:
                    return (a, b) => {
                        if (b.duty == null)
                            return -1;
                        if (a.duty == null)
                            return 1;
                        return b.duty.localeCompare(a.duty);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IDCardNo:
                    return (a, b) => {
                        if (b.idCardNo == null)
                            return -1;
                        if (a.idCardNo == null)
                            return 1;
                        return b.idCardNo.localeCompare(a.idCardNo);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuCardNo:
                    return (a, b) => {
                        if (b.stuCardNo == null)
                            return -1;
                        if (a.stuCardNo == null)
                            return 1;
                        return b.stuCardNo.localeCompare(a.stuCardNo);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_LiveAddress:
                    return (a, b) => {
                        if (b.liveAddress == null)
                            return -1;
                        if (a.liveAddress == null)
                            return 1;
                        return b.liveAddress.localeCompare(a.liveAddress);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_HomePhone:
                    return (a, b) => {
                        if (b.homePhone == null)
                            return -1;
                        if (a.homePhone == null)
                            return 1;
                        return b.homePhone.localeCompare(a.homePhone);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Id_CardNo:
                    return (a, b) => {
                        if (b.id_CardNo == null)
                            return -1;
                        if (a.id_CardNo == null)
                            return 1;
                        return b.id_CardNo.localeCompare(a.id_CardNo);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CardNo:
                    return (a, b) => {
                        if (b.cardNo == null)
                            return -1;
                        if (a.cardNo == null)
                            return 1;
                        return b.cardNo.localeCompare(a.cardNo);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsAvconClassUser:
                    return (a, b) => {
                        if (b.isAvconClassUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsAvconUser:
                    return (a, b) => {
                        if (b.isAvconUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsGpUser:
                    return (a, b) => {
                        if (b.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsLocalUser:
                    return (a, b) => {
                        if (b.isLocalUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsLeaved:
                    return (a, b) => {
                        if (b.isLeaved == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UserId:
                    return (a, b) => {
                        if (b.userId == null)
                            return -1;
                        if (a.userId == null)
                            return 1;
                        return b.userId.localeCompare(a.userId);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UserID4Avcon:
                    return (a, b) => {
                        if (b.userID4Avcon == null)
                            return -1;
                        if (a.userID4Avcon == null)
                            return 1;
                        return b.userID4Avcon.localeCompare(a.userID4Avcon);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EnrollmentDate:
                    return (a, b) => {
                        if (b.enrollmentDate == null)
                            return -1;
                        if (a.enrollmentDate == null)
                            return 1;
                        return b.enrollmentDate.localeCompare(a.enrollmentDate);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PostCode:
                    return (a, b) => {
                        if (b.postCode == null)
                            return -1;
                        if (a.postCode == null)
                            return 1;
                        return b.postCode.localeCompare(a.postCode);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Email:
                    return (a, b) => {
                        if (b.email == null)
                            return -1;
                        if (a.email == null)
                            return 1;
                        return b.email.localeCompare(a.email);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsMessage:
                    return (a, b) => {
                        if (b.isMessage == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Microblog:
                    return (a, b) => {
                        if (b.microblog == null)
                            return -1;
                        if (a.microblog == null)
                            return 1;
                        return b.microblog.localeCompare(a.microblog);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PhoneNumber:
                    return (a, b) => {
                        if (b.phoneNumber == null)
                            return -1;
                        if (a.phoneNumber == null)
                            return 1;
                        return b.phoneNumber.localeCompare(a.phoneNumber);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_QQ:
                    return (a, b) => {
                        if (b.qQ == null)
                            return -1;
                        if (a.qQ == null)
                            return 1;
                        return b.qQ.localeCompare(a.qQ);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_RegisterPassword:
                    return (a, b) => {
                        if (b.registerPassword == null)
                            return -1;
                        if (a.registerPassword == null)
                            return 1;
                        return b.registerPassword.localeCompare(a.registerPassword);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vStudentInfo]中不存在！(in ${exports.vStudentInfo_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vStudentInfo_SortFunByKey = vStudentInfo_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vStudentInfo_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_StudentInfo:
                return (obj) => {
                    return obj.id_StudentInfo === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuID:
                return (obj) => {
                    return obj.stuID === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuName:
                return (obj) => {
                    return obj.stuName === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Politics:
                return (obj) => {
                    return obj.id_Politics === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PoliticsID:
                return (obj) => {
                    return obj.politicsID === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PoliticsName:
                return (obj) => {
                    return obj.politicsName === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Sex:
                return (obj) => {
                    return obj.id_Sex === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_SexDesc:
                return (obj) => {
                    return obj.sexDesc === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Ethnic:
                return (obj) => {
                    return obj.id_Ethnic === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EthnicID:
                return (obj) => {
                    return obj.ethnicID === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EthnicName:
                return (obj) => {
                    return obj.ethnicName === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_UniZone:
                return (obj) => {
                    return obj.id_UniZone === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UniZoneDesc:
                return (obj) => {
                    return obj.uniZoneDesc === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_StuType:
                return (obj) => {
                    return obj.id_StuType === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuTypeID:
                return (obj) => {
                    return obj.stuTypeID === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuTypeDesc:
                return (obj) => {
                    return obj.stuTypeDesc === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeID:
                return (obj) => {
                    return obj.collegeID === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeIdInGP:
                return (obj) => {
                    return obj.collegeIdInGP === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeNameA:
                return (obj) => {
                    return obj.collegeNameA === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_MajorID:
                return (obj) => {
                    return obj.majorID === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsNormal:
                return (obj) => {
                    return obj.isNormal === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_GradeBase:
                return (obj) => {
                    return obj.id_GradeBase === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_GradeBaseName:
                return (obj) => {
                    return obj.gradeBaseName === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_AdminCls:
                return (obj) => {
                    return obj.id_AdminCls === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsName:
                return (obj) => {
                    return obj.adminClsName === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsId:
                return (obj) => {
                    return obj.adminClsId === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_AdminClsType:
                return (obj) => {
                    return obj.id_AdminClsType === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsTypeName:
                return (obj) => {
                    return obj.adminClsTypeName === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Birthday:
                return (obj) => {
                    return obj.birthday === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_NativePlace:
                return (obj) => {
                    return obj.nativePlace === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Duty:
                return (obj) => {
                    return obj.duty === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IDCardNo:
                return (obj) => {
                    return obj.idCardNo === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuCardNo:
                return (obj) => {
                    return obj.stuCardNo === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_LiveAddress:
                return (obj) => {
                    return obj.liveAddress === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_HomePhone:
                return (obj) => {
                    return obj.homePhone === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Id_CardNo:
                return (obj) => {
                    return obj.id_CardNo === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CardNo:
                return (obj) => {
                    return obj.cardNo === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsAvconClassUser:
                return (obj) => {
                    return obj.isAvconClassUser === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsAvconUser:
                return (obj) => {
                    return obj.isAvconUser === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsGpUser:
                return (obj) => {
                    return obj.isGpUser === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsLocalUser:
                return (obj) => {
                    return obj.isLocalUser === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsLeaved:
                return (obj) => {
                    return obj.isLeaved === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UserID4Avcon:
                return (obj) => {
                    return obj.userID4Avcon === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EnrollmentDate:
                return (obj) => {
                    return obj.enrollmentDate === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PostCode:
                return (obj) => {
                    return obj.postCode === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Email:
                return (obj) => {
                    return obj.email === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsMessage:
                return (obj) => {
                    return obj.isMessage === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Microblog:
                return (obj) => {
                    return obj.microblog === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PhoneNumber:
                return (obj) => {
                    return obj.phoneNumber === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_QQ:
                return (obj) => {
                    return obj.qQ === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_RegisterPassword:
                return (obj) => {
                    return obj.registerPassword === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vStudentInfo]中不存在！(in ${exports.vStudentInfo_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vStudentInfo_FilterFunByKey = vStudentInfo_FilterFunByKey;
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
    async function vStudentInfo_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_StudentInfo) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvStudentInfo = await vStudentInfo_GetObjLst_Cache();
        if (arrvStudentInfo == null)
            return [];
        let arrvStudentInfo_Sel = arrvStudentInfo;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvStudentInfo_Sel.length == 0)
            return [];
        return arrvStudentInfo_Sel.map(x => x.id_StudentInfo);
    }
    exports.vStudentInfo_funcKey = vStudentInfo_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vStudentInfo_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vStudentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vStudentInfo_GetFirstIDAsync = vStudentInfo_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vStudentInfo_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vStudentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vStudentInfo_GetFirstID = vStudentInfo_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vStudentInfo_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vStudentInfo_Controller, strAction);
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
                const objvStudentInfo = vStudentInfo_GetObjFromJsonObj(returnObj);
                return objvStudentInfo;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vStudentInfo_GetFirstObjAsync = vStudentInfo_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vStudentInfo_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvStudentInfoEN_js_1.clsvStudentInfoEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvStudentInfoEN_js_1.clsvStudentInfoEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvStudentInfoEN_js_1.clsvStudentInfoEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvStudentInfoExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvStudentInfoObjLst_T = vStudentInfo_GetObjLstByJSONObjLst(arrvStudentInfoExObjLst_Cache);
            return arrvStudentInfoObjLst_T;
        }
        try {
            const arrvStudentInfoExObjLst = await vStudentInfo_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvStudentInfoExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvStudentInfoExObjLst.length);
            console.log(strInfo);
            return arrvStudentInfoExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vStudentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vStudentInfo_GetObjLst_ClientCache = vStudentInfo_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vStudentInfo_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvStudentInfoEN_js_1.clsvStudentInfoEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvStudentInfoEN_js_1.clsvStudentInfoEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvStudentInfoEN_js_1.clsvStudentInfoEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvStudentInfoExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvStudentInfoObjLst_T = vStudentInfo_GetObjLstByJSONObjLst(arrvStudentInfoExObjLst_Cache);
            return arrvStudentInfoObjLst_T;
        }
        try {
            const arrvStudentInfoExObjLst = await vStudentInfo_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvStudentInfoExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvStudentInfoExObjLst.length);
            console.log(strInfo);
            return arrvStudentInfoExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vStudentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vStudentInfo_GetObjLst_localStorage = vStudentInfo_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vStudentInfo_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvStudentInfoEN_js_1.clsvStudentInfoEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvStudentInfoObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvStudentInfoObjLst_Cache;
        }
        else
            return null;
    }
    exports.vStudentInfo_GetObjLst_localStorage_PureCache = vStudentInfo_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vStudentInfo_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vStudentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vStudentInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vStudentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vStudentInfo_GetObjLstAsync = vStudentInfo_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vStudentInfo_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvStudentInfoEN_js_1.clsvStudentInfoEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvStudentInfoEN_js_1.clsvStudentInfoEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvStudentInfoEN_js_1.clsvStudentInfoEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvStudentInfoExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvStudentInfoObjLst_T = vStudentInfo_GetObjLstByJSONObjLst(arrvStudentInfoExObjLst_Cache);
            return arrvStudentInfoObjLst_T;
        }
        try {
            const arrvStudentInfoExObjLst = await vStudentInfo_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvStudentInfoExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvStudentInfoExObjLst.length);
            console.log(strInfo);
            return arrvStudentInfoExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vStudentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vStudentInfo_GetObjLst_sessionStorage = vStudentInfo_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vStudentInfo_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvStudentInfoEN_js_1.clsvStudentInfoEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvStudentInfoObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvStudentInfoObjLst_Cache;
        }
        else
            return null;
    }
    exports.vStudentInfo_GetObjLst_sessionStorage_PureCache = vStudentInfo_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vStudentInfo_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvStudentInfoObjLst_Cache;
        switch (clsvStudentInfoEN_js_1.clsvStudentInfoEN.CacheModeId) {
            case "04": //sessionStorage
                arrvStudentInfoObjLst_Cache = await vStudentInfo_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvStudentInfoObjLst_Cache = await vStudentInfo_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvStudentInfoObjLst_Cache = await vStudentInfo_GetObjLst_ClientCache();
                break;
            default:
                arrvStudentInfoObjLst_Cache = await vStudentInfo_GetObjLst_ClientCache();
                break;
        }
        const arrvStudentInfoObjLst = vStudentInfo_GetObjLstByJSONObjLst(arrvStudentInfoObjLst_Cache);
        return arrvStudentInfoObjLst_Cache;
    }
    exports.vStudentInfo_GetObjLst_Cache = vStudentInfo_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vStudentInfo_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvStudentInfoObjLst_Cache;
        switch (clsvStudentInfoEN_js_1.clsvStudentInfoEN.CacheModeId) {
            case "04": //sessionStorage
                arrvStudentInfoObjLst_Cache = await vStudentInfo_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvStudentInfoObjLst_Cache = await vStudentInfo_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvStudentInfoObjLst_Cache = null;
                break;
            default:
                arrvStudentInfoObjLst_Cache = null;
                break;
        }
        return arrvStudentInfoObjLst_Cache;
    }
    exports.vStudentInfo_GetObjLst_PureCache = vStudentInfo_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_StudentInfo_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vStudentInfo_GetSubObjLst_Cache(objvStudentInfo_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvStudentInfoObjLst_Cache = await vStudentInfo_GetObjLst_Cache();
        let arrvStudentInfo_Sel = arrvStudentInfoObjLst_Cache;
        if (objvStudentInfo_Cond.sf_FldComparisonOp == null || objvStudentInfo_Cond.sf_FldComparisonOp == "")
            return arrvStudentInfo_Sel;
        const dicFldComparisonOp = JSON.parse(objvStudentInfo_Cond.sf_FldComparisonOp);
        //console.log("clsvStudentInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvStudentInfo_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvStudentInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvStudentInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvStudentInfo_Cond), exports.vStudentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vStudentInfo_GetSubObjLst_Cache = vStudentInfo_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_StudentInfo:关键字列表
    * @returns 对象列表
    **/
    async function vStudentInfo_GetObjLstByid_StudentInfoLstAsync(arrid_StudentInfo) {
        const strThisFuncName = "GetObjLstByid_StudentInfoLstAsync";
        const strAction = "GetObjLstByid_StudentInfoLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vStudentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_StudentInfo);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vStudentInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vStudentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vStudentInfo_GetObjLstByid_StudentInfoLstAsync = vStudentInfo_GetObjLstByid_StudentInfoLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_StudentInfoLst:关键字列表
     * @returns 对象列表
    */
    async function vStudentInfo_GetObjLstByid_StudentInfoLst_Cache(arrid_StudentInfoLst) {
        const strThisFuncName = "GetObjLstByid_StudentInfoLst_Cache";
        try {
            const arrvStudentInfoObjLst_Cache = await vStudentInfo_GetObjLst_Cache();
            const arrvStudentInfo_Sel = arrvStudentInfoObjLst_Cache.filter(x => arrid_StudentInfoLst.indexOf(x.id_StudentInfo) > -1);
            return arrvStudentInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_StudentInfoLst.join(","), exports.vStudentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vStudentInfo_GetObjLstByid_StudentInfoLst_Cache = vStudentInfo_GetObjLstByid_StudentInfoLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vStudentInfo_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vStudentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vStudentInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vStudentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vStudentInfo_GetTopObjLstAsync = vStudentInfo_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vStudentInfo_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vStudentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vStudentInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vStudentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vStudentInfo_GetObjLstByRangeAsync = vStudentInfo_GetObjLstByRangeAsync;
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
    async function vStudentInfo_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vStudentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vStudentInfo_GetObjLstByRange = vStudentInfo_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vStudentInfo_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvStudentInfoObjLst_Cache = await vStudentInfo_GetObjLst_Cache();
        if (arrvStudentInfoObjLst_Cache.length == 0)
            return arrvStudentInfoObjLst_Cache;
        let arrvStudentInfo_Sel = arrvStudentInfoObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvStudentInfo_Cond = new clsvStudentInfoEN_js_1.clsvStudentInfoEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvStudentInfo_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvStudentInfoWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvStudentInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvStudentInfo_Sel.length == 0)
                return arrvStudentInfo_Sel;
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
                arrvStudentInfo_Sel = arrvStudentInfo_Sel.sort(vStudentInfo_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvStudentInfo_Sel = arrvStudentInfo_Sel.sort(objPagerPara.sortFun);
            }
            arrvStudentInfo_Sel = arrvStudentInfo_Sel.slice(intStart, intEnd);
            return arrvStudentInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vStudentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vStudentInfo_GetObjLstByPager_Cache = vStudentInfo_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vStudentInfo_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vStudentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vStudentInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vStudentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vStudentInfo_GetObjLstByPagerAsync = vStudentInfo_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_StudentInfo_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vStudentInfo_IsExistRecord_Cache(objvStudentInfo_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvStudentInfoObjLst_Cache = await vStudentInfo_GetObjLst_Cache();
        if (arrvStudentInfoObjLst_Cache == null)
            return false;
        let arrvStudentInfo_Sel = arrvStudentInfoObjLst_Cache;
        if (objvStudentInfo_Cond.sf_FldComparisonOp == null || objvStudentInfo_Cond.sf_FldComparisonOp == "")
            return arrvStudentInfo_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvStudentInfo_Cond.sf_FldComparisonOp);
        //console.log("clsvStudentInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvStudentInfo_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvStudentInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvStudentInfo_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvStudentInfo_Cond), exports.vStudentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vStudentInfo_IsExistRecord_Cache = vStudentInfo_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vStudentInfo_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vStudentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vStudentInfo_IsExistRecordAsync = vStudentInfo_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_StudentInfo:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vStudentInfo_IsExist(strid_StudentInfo, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vStudentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_StudentInfo": strid_StudentInfo,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vStudentInfo_IsExist = vStudentInfo_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_StudentInfo:所给的关键字
     * @returns 对象
    */
    async function vStudentInfo_IsExist_Cache(strid_StudentInfo) {
        const strThisFuncName = "IsExist_Cache";
        const arrvStudentInfoObjLst_Cache = await vStudentInfo_GetObjLst_Cache();
        if (arrvStudentInfoObjLst_Cache == null)
            return false;
        try {
            const arrvStudentInfo_Sel = arrvStudentInfoObjLst_Cache.filter(x => x.id_StudentInfo == strid_StudentInfo);
            if (arrvStudentInfo_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_StudentInfo, exports.vStudentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vStudentInfo_IsExist_Cache = vStudentInfo_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_StudentInfo:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vStudentInfo_IsExistAsync(strid_StudentInfo) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vStudentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_StudentInfo": strid_StudentInfo }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vStudentInfo_IsExistAsync = vStudentInfo_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vStudentInfo_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vStudentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vStudentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vStudentInfo_GetRecCountByCondAsync = vStudentInfo_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvStudentInfo_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vStudentInfo_GetRecCountByCond_Cache(objvStudentInfo_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvStudentInfoObjLst_Cache = await vStudentInfo_GetObjLst_Cache();
        if (arrvStudentInfoObjLst_Cache == null)
            return 0;
        let arrvStudentInfo_Sel = arrvStudentInfoObjLst_Cache;
        if (objvStudentInfo_Cond.sf_FldComparisonOp == null || objvStudentInfo_Cond.sf_FldComparisonOp == "")
            return arrvStudentInfo_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvStudentInfo_Cond.sf_FldComparisonOp);
        //console.log("clsvStudentInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvStudentInfo_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvStudentInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvStudentInfo_Sel = arrvStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvStudentInfo_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvStudentInfo_Cond), exports.vStudentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vStudentInfo_GetRecCountByCond_Cache = vStudentInfo_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vStudentInfo_GetWebApiUrl(strController, strAction) {
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
    exports.vStudentInfo_GetWebApiUrl = vStudentInfo_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vStudentInfo_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvStudentInfoEN_js_1.clsvStudentInfoEN._CurrTabName;
            switch (clsvStudentInfoEN_js_1.clsvStudentInfoEN.CacheModeId) {
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
    exports.vStudentInfo_ReFreshThisCache = vStudentInfo_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vStudentInfo_GetJSONStrByObj(pobjvStudentInfoEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvStudentInfoEN);
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
    exports.vStudentInfo_GetJSONStrByObj = vStudentInfo_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vStudentInfo_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvStudentInfoObjLst = new Array();
        if (strJSON === "") {
            return arrvStudentInfoObjLst;
        }
        try {
            arrvStudentInfoObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvStudentInfoObjLst;
        }
        return arrvStudentInfoObjLst;
    }
    exports.vStudentInfo_GetObjLstByJSONStr = vStudentInfo_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvStudentInfoObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vStudentInfo_GetObjLstByJSONObjLst(arrvStudentInfoObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvStudentInfoObjLst = new Array();
        for (const objInFor of arrvStudentInfoObjLstS) {
            const obj1 = vStudentInfo_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvStudentInfoObjLst.push(obj1);
        }
        return arrvStudentInfoObjLst;
    }
    exports.vStudentInfo_GetObjLstByJSONObjLst = vStudentInfo_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vStudentInfo_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvStudentInfoEN = new clsvStudentInfoEN_js_1.clsvStudentInfoEN();
        if (strJSON === "") {
            return pobjvStudentInfoEN;
        }
        try {
            pobjvStudentInfoEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvStudentInfoEN;
        }
        return pobjvStudentInfoEN;
    }
    exports.vStudentInfo_GetObjByJSONStr = vStudentInfo_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vStudentInfo_GetCombineCondition(objvStudentInfo_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_StudentInfo) == true) {
            const strComparisonOp_id_StudentInfo = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_StudentInfo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_StudentInfo, objvStudentInfo_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuID) == true) {
            const strComparisonOp_StuID = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuID, objvStudentInfo_Cond.stuID, strComparisonOp_StuID);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuName) == true) {
            const strComparisonOp_StuName = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuName, objvStudentInfo_Cond.stuName, strComparisonOp_StuName);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Politics) == true) {
            const strComparisonOp_id_Politics = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Politics];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Politics, objvStudentInfo_Cond.id_Politics, strComparisonOp_id_Politics);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PoliticsID) == true) {
            const strComparisonOp_PoliticsID = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PoliticsID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PoliticsID, objvStudentInfo_Cond.politicsID, strComparisonOp_PoliticsID);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PoliticsName) == true) {
            const strComparisonOp_PoliticsName = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PoliticsName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PoliticsName, objvStudentInfo_Cond.politicsName, strComparisonOp_PoliticsName);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Sex) == true) {
            const strComparisonOp_id_Sex = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Sex];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Sex, objvStudentInfo_Cond.id_Sex, strComparisonOp_id_Sex);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_SexDesc) == true) {
            const strComparisonOp_SexDesc = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_SexDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_SexDesc, objvStudentInfo_Cond.sexDesc, strComparisonOp_SexDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Ethnic) == true) {
            const strComparisonOp_id_Ethnic = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Ethnic];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_Ethnic, objvStudentInfo_Cond.id_Ethnic, strComparisonOp_id_Ethnic);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EthnicID) == true) {
            const strComparisonOp_EthnicID = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EthnicID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EthnicID, objvStudentInfo_Cond.ethnicID, strComparisonOp_EthnicID);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EthnicName) == true) {
            const strComparisonOp_EthnicName = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EthnicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EthnicName, objvStudentInfo_Cond.ethnicName, strComparisonOp_EthnicName);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_UniZone) == true) {
            const strComparisonOp_id_UniZone = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_UniZone];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_UniZone, objvStudentInfo_Cond.id_UniZone, strComparisonOp_id_UniZone);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UniZoneDesc) == true) {
            const strComparisonOp_UniZoneDesc = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UniZoneDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UniZoneDesc, objvStudentInfo_Cond.uniZoneDesc, strComparisonOp_UniZoneDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_StuType) == true) {
            const strComparisonOp_id_StuType = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_StuType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_StuType, objvStudentInfo_Cond.id_StuType, strComparisonOp_id_StuType);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuTypeID) == true) {
            const strComparisonOp_StuTypeID = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuTypeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuTypeID, objvStudentInfo_Cond.stuTypeID, strComparisonOp_StuTypeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuTypeDesc) == true) {
            const strComparisonOp_StuTypeDesc = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuTypeDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuTypeDesc, objvStudentInfo_Cond.stuTypeDesc, strComparisonOp_StuTypeDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_XzCollege, objvStudentInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeID) == true) {
            const strComparisonOp_CollegeID = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeID, objvStudentInfo_Cond.collegeID, strComparisonOp_CollegeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeName, objvStudentInfo_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeIdInGP) == true) {
            const strComparisonOp_CollegeIdInGP = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeIdInGP];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeIdInGP, objvStudentInfo_Cond.collegeIdInGP, strComparisonOp_CollegeIdInGP);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeNameA) == true) {
            const strComparisonOp_CollegeNameA = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeNameA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CollegeNameA, objvStudentInfo_Cond.collegeNameA, strComparisonOp_CollegeNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_XzMajor, objvStudentInfo_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_MajorID) == true) {
            const strComparisonOp_MajorID = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_MajorID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_MajorID, objvStudentInfo_Cond.majorID, strComparisonOp_MajorID);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_MajorName, objvStudentInfo_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsNormal) == true) {
            if (objvStudentInfo_Cond.isNormal == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsNormal);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsNormal);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_GradeBase) == true) {
            const strComparisonOp_id_GradeBase = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_GradeBase];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_GradeBase, objvStudentInfo_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_GradeBaseName) == true) {
            const strComparisonOp_GradeBaseName = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_GradeBaseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_GradeBaseName, objvStudentInfo_Cond.gradeBaseName, strComparisonOp_GradeBaseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_AdminCls) == true) {
            const strComparisonOp_id_AdminCls = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_AdminCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_AdminCls, objvStudentInfo_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsName) == true) {
            const strComparisonOp_AdminClsName = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsName, objvStudentInfo_Cond.adminClsName, strComparisonOp_AdminClsName);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsId) == true) {
            const strComparisonOp_AdminClsId = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsId, objvStudentInfo_Cond.adminClsId, strComparisonOp_AdminClsId);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_AdminClsType) == true) {
            const strComparisonOp_id_AdminClsType = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_AdminClsType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_id_AdminClsType, objvStudentInfo_Cond.id_AdminClsType, strComparisonOp_id_AdminClsType);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsTypeName) == true) {
            const strComparisonOp_AdminClsTypeName = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_AdminClsTypeName, objvStudentInfo_Cond.adminClsTypeName, strComparisonOp_AdminClsTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Birthday) == true) {
            const strComparisonOp_Birthday = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Birthday];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Birthday, objvStudentInfo_Cond.birthday, strComparisonOp_Birthday);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_NativePlace) == true) {
            const strComparisonOp_NativePlace = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_NativePlace];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_NativePlace, objvStudentInfo_Cond.nativePlace, strComparisonOp_NativePlace);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Duty) == true) {
            const strComparisonOp_Duty = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Duty];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Duty, objvStudentInfo_Cond.duty, strComparisonOp_Duty);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IDCardNo) == true) {
            const strComparisonOp_IDCardNo = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IDCardNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IDCardNo, objvStudentInfo_Cond.idCardNo, strComparisonOp_IDCardNo);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuCardNo) == true) {
            const strComparisonOp_StuCardNo = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuCardNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_StuCardNo, objvStudentInfo_Cond.stuCardNo, strComparisonOp_StuCardNo);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_LiveAddress) == true) {
            const strComparisonOp_LiveAddress = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_LiveAddress];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_LiveAddress, objvStudentInfo_Cond.liveAddress, strComparisonOp_LiveAddress);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_HomePhone) == true) {
            const strComparisonOp_HomePhone = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_HomePhone];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_HomePhone, objvStudentInfo_Cond.homePhone, strComparisonOp_HomePhone);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Id_CardNo) == true) {
            const strComparisonOp_Id_CardNo = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Id_CardNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Id_CardNo, objvStudentInfo_Cond.id_CardNo, strComparisonOp_Id_CardNo);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CardNo) == true) {
            const strComparisonOp_CardNo = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CardNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_CardNo, objvStudentInfo_Cond.cardNo, strComparisonOp_CardNo);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsAvconClassUser) == true) {
            if (objvStudentInfo_Cond.isAvconClassUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsAvconClassUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsAvconClassUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsAvconUser) == true) {
            if (objvStudentInfo_Cond.isAvconUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsAvconUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsAvconUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsGpUser) == true) {
            if (objvStudentInfo_Cond.isGpUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsGpUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsGpUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsLocalUser) == true) {
            if (objvStudentInfo_Cond.isLocalUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsLocalUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsLocalUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsLeaved) == true) {
            if (objvStudentInfo_Cond.isLeaved == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsLeaved);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsLeaved);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UserId) == true) {
            const strComparisonOp_UserId = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UserId, objvStudentInfo_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UserID4Avcon) == true) {
            const strComparisonOp_UserID4Avcon = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UserID4Avcon];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UserID4Avcon, objvStudentInfo_Cond.userID4Avcon, strComparisonOp_UserID4Avcon);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EnrollmentDate) == true) {
            const strComparisonOp_EnrollmentDate = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EnrollmentDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_EnrollmentDate, objvStudentInfo_Cond.enrollmentDate, strComparisonOp_EnrollmentDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PostCode) == true) {
            const strComparisonOp_PostCode = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PostCode];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PostCode, objvStudentInfo_Cond.postCode, strComparisonOp_PostCode);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Email) == true) {
            const strComparisonOp_Email = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Email];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Email, objvStudentInfo_Cond.email, strComparisonOp_Email);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsMessage) == true) {
            if (objvStudentInfo_Cond.isMessage == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsMessage);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_IsMessage);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Microblog) == true) {
            const strComparisonOp_Microblog = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Microblog];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Microblog, objvStudentInfo_Cond.microblog, strComparisonOp_Microblog);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PhoneNumber) == true) {
            const strComparisonOp_PhoneNumber = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PhoneNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_PhoneNumber, objvStudentInfo_Cond.phoneNumber, strComparisonOp_PhoneNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_QQ) == true) {
            const strComparisonOp_QQ = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_QQ];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_QQ, objvStudentInfo_Cond.qQ, strComparisonOp_QQ);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_RegisterPassword) == true) {
            const strComparisonOp_RegisterPassword = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_RegisterPassword];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_RegisterPassword, objvStudentInfo_Cond.registerPassword, strComparisonOp_RegisterPassword);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UpdDate, objvStudentInfo_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_UpdUser, objvStudentInfo_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvStudentInfo_Cond.dicFldComparisonOp, clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvStudentInfo_Cond.dicFldComparisonOp[clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvStudentInfoEN_js_1.clsvStudentInfoEN.con_Memo, objvStudentInfo_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.vStudentInfo_GetCombineCondition = vStudentInfo_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvStudentInfoENS:源对象
     * @param objvStudentInfoENT:目标对象
    */
    function vStudentInfo_CopyObjTo(objvStudentInfoENS, objvStudentInfoENT) {
        objvStudentInfoENT.id_StudentInfo = objvStudentInfoENS.id_StudentInfo; //学生流水号
        objvStudentInfoENT.stuID = objvStudentInfoENS.stuID; //学号
        objvStudentInfoENT.stuName = objvStudentInfoENS.stuName; //姓名
        objvStudentInfoENT.id_Politics = objvStudentInfoENS.id_Politics; //政治面貌流水号
        objvStudentInfoENT.politicsID = objvStudentInfoENS.politicsID; //政治面貌ID
        objvStudentInfoENT.politicsName = objvStudentInfoENS.politicsName; //政治面貌
        objvStudentInfoENT.id_Sex = objvStudentInfoENS.id_Sex; //性别流水号
        objvStudentInfoENT.sexDesc = objvStudentInfoENS.sexDesc; //性别名称
        objvStudentInfoENT.id_Ethnic = objvStudentInfoENS.id_Ethnic; //民族流水号
        objvStudentInfoENT.ethnicID = objvStudentInfoENS.ethnicID; //民族ID
        objvStudentInfoENT.ethnicName = objvStudentInfoENS.ethnicName; //民族名称
        objvStudentInfoENT.id_UniZone = objvStudentInfoENS.id_UniZone; //校区流水号
        objvStudentInfoENT.uniZoneDesc = objvStudentInfoENS.uniZoneDesc; //校区名称
        objvStudentInfoENT.id_StuType = objvStudentInfoENS.id_StuType; //学生类别流水号
        objvStudentInfoENT.stuTypeID = objvStudentInfoENS.stuTypeID; //学生类别ID
        objvStudentInfoENT.stuTypeDesc = objvStudentInfoENS.stuTypeDesc; //学生类别名称
        objvStudentInfoENT.id_XzCollege = objvStudentInfoENS.id_XzCollege; //学院流水号
        objvStudentInfoENT.collegeID = objvStudentInfoENS.collegeID; //学院ID
        objvStudentInfoENT.collegeName = objvStudentInfoENS.collegeName; //学院名称
        objvStudentInfoENT.collegeIdInGP = objvStudentInfoENS.collegeIdInGP; //CollegeIdInGP
        objvStudentInfoENT.collegeNameA = objvStudentInfoENS.collegeNameA; //学院名称简写
        objvStudentInfoENT.id_XzMajor = objvStudentInfoENS.id_XzMajor; //专业流水号
        objvStudentInfoENT.majorID = objvStudentInfoENS.majorID; //专业ID
        objvStudentInfoENT.majorName = objvStudentInfoENS.majorName; //专业名称
        objvStudentInfoENT.isNormal = objvStudentInfoENS.isNormal; //IsNormal
        objvStudentInfoENT.id_GradeBase = objvStudentInfoENS.id_GradeBase; //年级流水号
        objvStudentInfoENT.gradeBaseName = objvStudentInfoENS.gradeBaseName; //年级名称
        objvStudentInfoENT.id_AdminCls = objvStudentInfoENS.id_AdminCls; //行政班流水号
        objvStudentInfoENT.adminClsName = objvStudentInfoENS.adminClsName; //行政班名称
        objvStudentInfoENT.adminClsId = objvStudentInfoENS.adminClsId; //行政班代号
        objvStudentInfoENT.id_AdminClsType = objvStudentInfoENS.id_AdminClsType; //行政班级类型流水号
        objvStudentInfoENT.adminClsTypeName = objvStudentInfoENS.adminClsTypeName; //行政班级类型名称
        objvStudentInfoENT.birthday = objvStudentInfoENS.birthday; //出生日期
        objvStudentInfoENT.nativePlace = objvStudentInfoENS.nativePlace; //籍贯
        objvStudentInfoENT.duty = objvStudentInfoENS.duty; //职位
        objvStudentInfoENT.idCardNo = objvStudentInfoENS.idCardNo; //身份证号
        objvStudentInfoENT.stuCardNo = objvStudentInfoENS.stuCardNo; //学生证号
        objvStudentInfoENT.liveAddress = objvStudentInfoENS.liveAddress; //居住地址
        objvStudentInfoENT.homePhone = objvStudentInfoENS.homePhone; //住宅电话
        objvStudentInfoENT.id_CardNo = objvStudentInfoENS.id_CardNo; //内卡号
        objvStudentInfoENT.cardNo = objvStudentInfoENS.cardNo; //卡号
        objvStudentInfoENT.isAvconClassUser = objvStudentInfoENS.isAvconClassUser; //IsAvconClassUser
        objvStudentInfoENT.isAvconUser = objvStudentInfoENS.isAvconUser; //IsAvconUser
        objvStudentInfoENT.isGpUser = objvStudentInfoENS.isGpUser; //是否Gp用户
        objvStudentInfoENT.isLocalUser = objvStudentInfoENS.isLocalUser; //是否本地用户
        objvStudentInfoENT.isLeaved = objvStudentInfoENS.isLeaved; //IsLeaved
        objvStudentInfoENT.userId = objvStudentInfoENS.userId; //用户ID
        objvStudentInfoENT.userID4Avcon = objvStudentInfoENS.userID4Avcon; //UserID4Avcon
        objvStudentInfoENT.enrollmentDate = objvStudentInfoENS.enrollmentDate; //入校日期
        objvStudentInfoENT.postCode = objvStudentInfoENS.postCode; //邮编
        objvStudentInfoENT.email = objvStudentInfoENS.email; //电子邮箱
        objvStudentInfoENT.isMessage = objvStudentInfoENS.isMessage; //IsMessage
        objvStudentInfoENT.microblog = objvStudentInfoENS.microblog; //Microblog
        objvStudentInfoENT.phoneNumber = objvStudentInfoENS.phoneNumber; //PhoneNumber
        objvStudentInfoENT.qQ = objvStudentInfoENS.qQ; //QQ
        objvStudentInfoENT.registerPassword = objvStudentInfoENS.registerPassword; //RegisterPassword
        objvStudentInfoENT.updDate = objvStudentInfoENS.updDate; //修改日期
        objvStudentInfoENT.updUser = objvStudentInfoENS.updUser; //修改人
        objvStudentInfoENT.memo = objvStudentInfoENS.memo; //备注
    }
    exports.vStudentInfo_CopyObjTo = vStudentInfo_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvStudentInfoENS:源对象
     * @param objvStudentInfoENT:目标对象
    */
    function vStudentInfo_GetObjFromJsonObj(objvStudentInfoENS) {
        const objvStudentInfoENT = new clsvStudentInfoEN_js_1.clsvStudentInfoEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvStudentInfoENT, objvStudentInfoENS);
        return objvStudentInfoENT;
    }
    exports.vStudentInfo_GetObjFromJsonObj = vStudentInfo_GetObjFromJsonObj;
});
