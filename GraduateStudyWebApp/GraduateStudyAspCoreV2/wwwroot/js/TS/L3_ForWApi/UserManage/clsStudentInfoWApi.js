/**
* 类名:clsStudentInfoWApi
* 表名:StudentInfo(01120131)
* 版本:2023.02.24.1(服务器:WIN-SRV103-116)
* 日期:2023/02/24 13:39:59
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/UserManage/clsStudentInfoEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.StudentInfo_GetObjFromJsonObj = exports.StudentInfo_CopyObjTo = exports.StudentInfo_GetUniCondStr4Update_StuID = exports.StudentInfo_GetUniCondStr_StuID = exports.StudentInfo_GetCombineCondition = exports.StudentInfo_GetObjByJSONStr = exports.StudentInfo_GetObjLstByJSONObjLst = exports.StudentInfo_GetObjLstByJSONStr = exports.StudentInfo_GetJSONStrByObj = exports.StudentInfo_CheckProperty4Update = exports.StudentInfo_CheckPropertyNew = exports.StudentInfo_ReFreshThisCache = exports.StudentInfo_ReFreshCache = exports.StudentInfo_GetWebApiUrl = exports.StudentInfo_GetMaxStrIdByPrefix = exports.StudentInfo_GetMaxStrIdAsync = exports.StudentInfo_GetRecCountByCond_Cache = exports.StudentInfo_GetRecCountByCondAsync = exports.StudentInfo_IsExistAsync = exports.StudentInfo_IsExist_Cache = exports.StudentInfo_IsExist = exports.StudentInfo_IsExistRecordAsync = exports.StudentInfo_IsExistRecord_Cache = exports.StudentInfo_UpdateWithConditionAsync = exports.StudentInfo_UpdateRecordAsync = exports.StudentInfo_AddNewRecordWithReturnKey = exports.StudentInfo_AddNewRecordWithReturnKeyAsync = exports.StudentInfo_AddNewRecordWithMaxIdAsync = exports.StudentInfo_AddNewRecordAsync = exports.StudentInfo_DelStudentInfosByCondAsync = exports.StudentInfo_DelStudentInfosAsync = exports.StudentInfo_DelRecordAsync = exports.StudentInfo_GetObjLstByPagerAsync = exports.StudentInfo_GetObjLstByPager_Cache = exports.StudentInfo_GetObjLstByRange = exports.StudentInfo_GetObjLstByRangeAsync = exports.StudentInfo_GetTopObjLstAsync = exports.StudentInfo_GetObjLstByid_StudentInfoLst_Cache = exports.StudentInfo_GetObjLstByid_StudentInfoLstAsync = exports.StudentInfo_GetSubObjLst_Cache = exports.StudentInfo_GetObjLst_PureCache = exports.StudentInfo_GetObjLst_Cache = exports.StudentInfo_GetObjLst_sessionStorage_PureCache = exports.StudentInfo_GetObjLst_sessionStorage = exports.StudentInfo_GetObjLstAsync = exports.StudentInfo_GetObjLst_localStorage_PureCache = exports.StudentInfo_GetObjLst_localStorage = exports.StudentInfo_GetObjLst_ClientCache = exports.StudentInfo_GetFirstObjAsync = exports.StudentInfo_GetFirstID = exports.StudentInfo_GetFirstIDAsync = exports.StudentInfo_funcKey = exports.StudentInfo_FilterFunByKey = exports.StudentInfo_SortFunByKey = exports.StudentInfo_SortFun_Defa_2Fld = exports.StudentInfo_SortFun_Defa = exports.StudentInfo_func = exports.StudentInfo_UpdateObjInLst_Cache = exports.StudentInfo_GetObjByid_StudentInfo_localStorage = exports.StudentInfo_GetObjByid_StudentInfo_Cache = exports.StudentInfo_GetObjByid_StudentInfoAsync = exports.studentInfo_ConstructorName = exports.studentInfo_Controller = void 0;
    /**
     * 学生(StudentInfo)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年02月24日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsStudentInfoEN_js_1 = require("../../L0_Entity/UserManage/clsStudentInfoEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.studentInfo_Controller = "StudentInfoApi";
    exports.studentInfo_ConstructorName = "studentInfo";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_StudentInfo:关键字
    * @returns 对象
    **/
    async function StudentInfo_GetObjByid_StudentInfoAsync(strid_StudentInfo) {
        const strThisFuncName = "GetObjByid_StudentInfoAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_StudentInfo) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_StudentInfo]不能为空！(In GetObjByid_StudentInfoAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_StudentInfo.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_StudentInfo]的长度:[{0}]不正确！", strid_StudentInfo.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_StudentInfo";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
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
                const objStudentInfo = StudentInfo_GetObjFromJsonObj(returnObj);
                return objStudentInfo;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_GetObjByid_StudentInfoAsync = StudentInfo_GetObjByid_StudentInfoAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_StudentInfo:所给的关键字
     * @returns 对象
    */
    async function StudentInfo_GetObjByid_StudentInfo_Cache(strid_StudentInfo, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_StudentInfo_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_StudentInfo) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_StudentInfo]不能为空！(In GetObjByid_StudentInfo_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_StudentInfo.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_StudentInfo]的长度:[{0}]不正确！", strid_StudentInfo.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_Cache();
        try {
            const arrStudentInfo_Sel = arrStudentInfoObjLst_Cache.filter(x => x.id_StudentInfo == strid_StudentInfo);
            let objStudentInfo;
            if (arrStudentInfo_Sel.length > 0) {
                objStudentInfo = arrStudentInfo_Sel[0];
                return objStudentInfo;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objStudentInfo_Const = await StudentInfo_GetObjByid_StudentInfoAsync(strid_StudentInfo);
                    if (objStudentInfo_Const != null) {
                        StudentInfo_ReFreshThisCache();
                        return objStudentInfo_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_StudentInfo, exports.studentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.StudentInfo_GetObjByid_StudentInfo_Cache = StudentInfo_GetObjByid_StudentInfo_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_StudentInfo:所给的关键字
     * @returns 对象
    */
    async function StudentInfo_GetObjByid_StudentInfo_localStorage(strid_StudentInfo) {
        const strThisFuncName = "GetObjByid_StudentInfo_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_StudentInfo) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_StudentInfo]不能为空！(In GetObjByid_StudentInfo_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_StudentInfo.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_StudentInfo]的长度:[{0}]不正确！", strid_StudentInfo.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsStudentInfoEN_js_1.clsStudentInfoEN._CurrTabName, strid_StudentInfo);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objStudentInfo_Cache = JSON.parse(strTempObj);
            return objStudentInfo_Cache;
        }
        try {
            const objStudentInfo = await StudentInfo_GetObjByid_StudentInfoAsync(strid_StudentInfo);
            if (objStudentInfo != null) {
                localStorage.setItem(strKey, JSON.stringify(objStudentInfo));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objStudentInfo;
            }
            return objStudentInfo;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_StudentInfo, exports.studentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.StudentInfo_GetObjByid_StudentInfo_localStorage = StudentInfo_GetObjByid_StudentInfo_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objStudentInfo:所给的对象
     * @returns 对象
    */
    async function StudentInfo_UpdateObjInLst_Cache(objStudentInfo) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_Cache();
            const obj = arrStudentInfoObjLst_Cache.find(x => x.stuID == objStudentInfo.stuID);
            if (obj != null) {
                objStudentInfo.id_StudentInfo = obj.id_StudentInfo;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objStudentInfo);
            }
            else {
                arrStudentInfoObjLst_Cache.push(objStudentInfo);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.studentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.StudentInfo_UpdateObjInLst_Cache = StudentInfo_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function StudentInfo_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_StudentInfo) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsStudentInfoEN_js_1.clsStudentInfoEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsStudentInfoEN_js_1.clsStudentInfoEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_StudentInfo = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objStudentInfo = await StudentInfo_GetObjByid_StudentInfo_Cache(strid_StudentInfo);
        if (objStudentInfo == null)
            return "";
        if (objStudentInfo.GetFldValue(strOutFldName) == null)
            return "";
        return objStudentInfo.GetFldValue(strOutFldName).toString();
    }
    exports.StudentInfo_func = StudentInfo_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function StudentInfo_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_StudentInfo.localeCompare(b.id_StudentInfo);
    }
    exports.StudentInfo_SortFun_Defa = StudentInfo_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function StudentInfo_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.stuID == b.stuID)
            return a.stuName.localeCompare(b.stuName);
        else
            return a.stuID.localeCompare(b.stuID);
    }
    exports.StudentInfo_SortFun_Defa_2Fld = StudentInfo_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function StudentInfo_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_StudentInfo:
                    return (a, b) => {
                        return a.id_StudentInfo.localeCompare(b.id_StudentInfo);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuID:
                    return (a, b) => {
                        return a.stuID.localeCompare(b.stuID);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuName:
                    return (a, b) => {
                        return a.stuName.localeCompare(b.stuName);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Politics:
                    return (a, b) => {
                        if (a.id_Politics == null)
                            return -1;
                        if (b.id_Politics == null)
                            return 1;
                        return a.id_Politics.localeCompare(b.id_Politics);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Sex:
                    return (a, b) => {
                        if (a.id_Sex == null)
                            return -1;
                        if (b.id_Sex == null)
                            return 1;
                        return a.id_Sex.localeCompare(b.id_Sex);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Ethnic:
                    return (a, b) => {
                        if (a.id_Ethnic == null)
                            return -1;
                        if (b.id_Ethnic == null)
                            return 1;
                        return a.id_Ethnic.localeCompare(b.id_Ethnic);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_UniZone:
                    return (a, b) => {
                        if (a.id_UniZone == null)
                            return -1;
                        if (b.id_UniZone == null)
                            return 1;
                        return a.id_UniZone.localeCompare(b.id_UniZone);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_StuType:
                    return (a, b) => {
                        if (a.id_StuType == null)
                            return -1;
                        if (b.id_StuType == null)
                            return 1;
                        return a.id_StuType.localeCompare(b.id_StuType);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_XzMajor:
                    return (a, b) => {
                        if (a.id_XzMajor == null)
                            return -1;
                        if (b.id_XzMajor == null)
                            return 1;
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_GradeBase:
                    return (a, b) => {
                        if (a.id_GradeBase == null)
                            return -1;
                        if (b.id_GradeBase == null)
                            return 1;
                        return a.id_GradeBase.localeCompare(b.id_GradeBase);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_AdminCls:
                    return (a, b) => {
                        if (a.id_AdminCls == null)
                            return -1;
                        if (b.id_AdminCls == null)
                            return 1;
                        return a.id_AdminCls.localeCompare(b.id_AdminCls);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Birthday:
                    return (a, b) => {
                        if (a.birthday == null)
                            return -1;
                        if (b.birthday == null)
                            return 1;
                        return a.birthday.localeCompare(b.birthday);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_NativePlace:
                    return (a, b) => {
                        if (a.nativePlace == null)
                            return -1;
                        if (b.nativePlace == null)
                            return 1;
                        return a.nativePlace.localeCompare(b.nativePlace);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Duty:
                    return (a, b) => {
                        if (a.duty == null)
                            return -1;
                        if (b.duty == null)
                            return 1;
                        return a.duty.localeCompare(b.duty);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IDCardNo:
                    return (a, b) => {
                        if (a.idCardNo == null)
                            return -1;
                        if (b.idCardNo == null)
                            return 1;
                        return a.idCardNo.localeCompare(b.idCardNo);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuCardNo:
                    return (a, b) => {
                        if (a.stuCardNo == null)
                            return -1;
                        if (b.stuCardNo == null)
                            return 1;
                        return a.stuCardNo.localeCompare(b.stuCardNo);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_LiveAddress:
                    return (a, b) => {
                        if (a.liveAddress == null)
                            return -1;
                        if (b.liveAddress == null)
                            return 1;
                        return a.liveAddress.localeCompare(b.liveAddress);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_HomePhone:
                    return (a, b) => {
                        if (a.homePhone == null)
                            return -1;
                        if (b.homePhone == null)
                            return 1;
                        return a.homePhone.localeCompare(b.homePhone);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Id_CardNo:
                    return (a, b) => {
                        if (a.id_CardNo == null)
                            return -1;
                        if (b.id_CardNo == null)
                            return 1;
                        return a.id_CardNo.localeCompare(b.id_CardNo);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_CardNo:
                    return (a, b) => {
                        if (a.cardNo == null)
                            return -1;
                        if (b.cardNo == null)
                            return 1;
                        return a.cardNo.localeCompare(b.cardNo);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsAvconClassUser:
                    return (a, b) => {
                        if (a.isAvconClassUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsAvconUser:
                    return (a, b) => {
                        if (a.isAvconUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsGpUser:
                    return (a, b) => {
                        if (a.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsLocalUser:
                    return (a, b) => {
                        if (a.isLocalUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsLeaved:
                    return (a, b) => {
                        if (a.isLeaved == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_UserId:
                    return (a, b) => {
                        if (a.userId == null)
                            return -1;
                        if (b.userId == null)
                            return 1;
                        return a.userId.localeCompare(b.userId);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_UserID4Avcon:
                    return (a, b) => {
                        if (a.userID4Avcon == null)
                            return -1;
                        if (b.userID4Avcon == null)
                            return 1;
                        return a.userID4Avcon.localeCompare(b.userID4Avcon);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_EnrollmentDate:
                    return (a, b) => {
                        if (a.enrollmentDate == null)
                            return -1;
                        if (b.enrollmentDate == null)
                            return 1;
                        return a.enrollmentDate.localeCompare(b.enrollmentDate);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_PostCode:
                    return (a, b) => {
                        if (a.postCode == null)
                            return -1;
                        if (b.postCode == null)
                            return 1;
                        return a.postCode.localeCompare(b.postCode);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Email:
                    return (a, b) => {
                        if (a.email == null)
                            return -1;
                        if (b.email == null)
                            return 1;
                        return a.email.localeCompare(b.email);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsMessage:
                    return (a, b) => {
                        if (a.isMessage == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Microblog:
                    return (a, b) => {
                        if (a.microblog == null)
                            return -1;
                        if (b.microblog == null)
                            return 1;
                        return a.microblog.localeCompare(b.microblog);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_PhoneNumber:
                    return (a, b) => {
                        if (a.phoneNumber == null)
                            return -1;
                        if (b.phoneNumber == null)
                            return 1;
                        return a.phoneNumber.localeCompare(b.phoneNumber);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Headphoto:
                    return (a, b) => {
                        if (a.headphoto == null)
                            return -1;
                        if (b.headphoto == null)
                            return 1;
                        return a.headphoto.localeCompare(b.headphoto);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_QQ:
                    return (a, b) => {
                        if (a.qQ == null)
                            return -1;
                        if (b.qQ == null)
                            return 1;
                        return a.qQ.localeCompare(b.qQ);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_RegisterPassword:
                    return (a, b) => {
                        if (a.registerPassword == null)
                            return -1;
                        if (b.registerPassword == null)
                            return 1;
                        return a.registerPassword.localeCompare(b.registerPassword);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[StudentInfo]中不存在！(in ${exports.studentInfo_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_StudentInfo:
                    return (a, b) => {
                        return b.id_StudentInfo.localeCompare(a.id_StudentInfo);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuID:
                    return (a, b) => {
                        return b.stuID.localeCompare(a.stuID);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuName:
                    return (a, b) => {
                        return b.stuName.localeCompare(a.stuName);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Politics:
                    return (a, b) => {
                        if (b.id_Politics == null)
                            return -1;
                        if (a.id_Politics == null)
                            return 1;
                        return b.id_Politics.localeCompare(a.id_Politics);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Sex:
                    return (a, b) => {
                        if (b.id_Sex == null)
                            return -1;
                        if (a.id_Sex == null)
                            return 1;
                        return b.id_Sex.localeCompare(a.id_Sex);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Ethnic:
                    return (a, b) => {
                        if (b.id_Ethnic == null)
                            return -1;
                        if (a.id_Ethnic == null)
                            return 1;
                        return b.id_Ethnic.localeCompare(a.id_Ethnic);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_UniZone:
                    return (a, b) => {
                        if (b.id_UniZone == null)
                            return -1;
                        if (a.id_UniZone == null)
                            return 1;
                        return b.id_UniZone.localeCompare(a.id_UniZone);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_StuType:
                    return (a, b) => {
                        if (b.id_StuType == null)
                            return -1;
                        if (a.id_StuType == null)
                            return 1;
                        return b.id_StuType.localeCompare(a.id_StuType);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_XzMajor:
                    return (a, b) => {
                        if (b.id_XzMajor == null)
                            return -1;
                        if (a.id_XzMajor == null)
                            return 1;
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_GradeBase:
                    return (a, b) => {
                        if (b.id_GradeBase == null)
                            return -1;
                        if (a.id_GradeBase == null)
                            return 1;
                        return b.id_GradeBase.localeCompare(a.id_GradeBase);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_AdminCls:
                    return (a, b) => {
                        if (b.id_AdminCls == null)
                            return -1;
                        if (a.id_AdminCls == null)
                            return 1;
                        return b.id_AdminCls.localeCompare(a.id_AdminCls);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Birthday:
                    return (a, b) => {
                        if (b.birthday == null)
                            return -1;
                        if (a.birthday == null)
                            return 1;
                        return b.birthday.localeCompare(a.birthday);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_NativePlace:
                    return (a, b) => {
                        if (b.nativePlace == null)
                            return -1;
                        if (a.nativePlace == null)
                            return 1;
                        return b.nativePlace.localeCompare(a.nativePlace);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Duty:
                    return (a, b) => {
                        if (b.duty == null)
                            return -1;
                        if (a.duty == null)
                            return 1;
                        return b.duty.localeCompare(a.duty);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IDCardNo:
                    return (a, b) => {
                        if (b.idCardNo == null)
                            return -1;
                        if (a.idCardNo == null)
                            return 1;
                        return b.idCardNo.localeCompare(a.idCardNo);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuCardNo:
                    return (a, b) => {
                        if (b.stuCardNo == null)
                            return -1;
                        if (a.stuCardNo == null)
                            return 1;
                        return b.stuCardNo.localeCompare(a.stuCardNo);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_LiveAddress:
                    return (a, b) => {
                        if (b.liveAddress == null)
                            return -1;
                        if (a.liveAddress == null)
                            return 1;
                        return b.liveAddress.localeCompare(a.liveAddress);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_HomePhone:
                    return (a, b) => {
                        if (b.homePhone == null)
                            return -1;
                        if (a.homePhone == null)
                            return 1;
                        return b.homePhone.localeCompare(a.homePhone);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Id_CardNo:
                    return (a, b) => {
                        if (b.id_CardNo == null)
                            return -1;
                        if (a.id_CardNo == null)
                            return 1;
                        return b.id_CardNo.localeCompare(a.id_CardNo);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_CardNo:
                    return (a, b) => {
                        if (b.cardNo == null)
                            return -1;
                        if (a.cardNo == null)
                            return 1;
                        return b.cardNo.localeCompare(a.cardNo);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsAvconClassUser:
                    return (a, b) => {
                        if (b.isAvconClassUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsAvconUser:
                    return (a, b) => {
                        if (b.isAvconUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsGpUser:
                    return (a, b) => {
                        if (b.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsLocalUser:
                    return (a, b) => {
                        if (b.isLocalUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsLeaved:
                    return (a, b) => {
                        if (b.isLeaved == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_UserId:
                    return (a, b) => {
                        if (b.userId == null)
                            return -1;
                        if (a.userId == null)
                            return 1;
                        return b.userId.localeCompare(a.userId);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_UserID4Avcon:
                    return (a, b) => {
                        if (b.userID4Avcon == null)
                            return -1;
                        if (a.userID4Avcon == null)
                            return 1;
                        return b.userID4Avcon.localeCompare(a.userID4Avcon);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_EnrollmentDate:
                    return (a, b) => {
                        if (b.enrollmentDate == null)
                            return -1;
                        if (a.enrollmentDate == null)
                            return 1;
                        return b.enrollmentDate.localeCompare(a.enrollmentDate);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_PostCode:
                    return (a, b) => {
                        if (b.postCode == null)
                            return -1;
                        if (a.postCode == null)
                            return 1;
                        return b.postCode.localeCompare(a.postCode);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Email:
                    return (a, b) => {
                        if (b.email == null)
                            return -1;
                        if (a.email == null)
                            return 1;
                        return b.email.localeCompare(a.email);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsMessage:
                    return (a, b) => {
                        if (b.isMessage == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Microblog:
                    return (a, b) => {
                        if (b.microblog == null)
                            return -1;
                        if (a.microblog == null)
                            return 1;
                        return b.microblog.localeCompare(a.microblog);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_PhoneNumber:
                    return (a, b) => {
                        if (b.phoneNumber == null)
                            return -1;
                        if (a.phoneNumber == null)
                            return 1;
                        return b.phoneNumber.localeCompare(a.phoneNumber);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Headphoto:
                    return (a, b) => {
                        if (b.headphoto == null)
                            return -1;
                        if (a.headphoto == null)
                            return 1;
                        return b.headphoto.localeCompare(a.headphoto);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_QQ:
                    return (a, b) => {
                        if (b.qQ == null)
                            return -1;
                        if (a.qQ == null)
                            return 1;
                        return b.qQ.localeCompare(a.qQ);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_RegisterPassword:
                    return (a, b) => {
                        if (b.registerPassword == null)
                            return -1;
                        if (a.registerPassword == null)
                            return 1;
                        return b.registerPassword.localeCompare(a.registerPassword);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[StudentInfo]中不存在！(in ${exports.studentInfo_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.StudentInfo_SortFunByKey = StudentInfo_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function StudentInfo_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_StudentInfo:
                return (obj) => {
                    return obj.id_StudentInfo === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuID:
                return (obj) => {
                    return obj.stuID === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuName:
                return (obj) => {
                    return obj.stuName === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Politics:
                return (obj) => {
                    return obj.id_Politics === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Sex:
                return (obj) => {
                    return obj.id_Sex === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Ethnic:
                return (obj) => {
                    return obj.id_Ethnic === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_UniZone:
                return (obj) => {
                    return obj.id_UniZone === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_StuType:
                return (obj) => {
                    return obj.id_StuType === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_GradeBase:
                return (obj) => {
                    return obj.id_GradeBase === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_AdminCls:
                return (obj) => {
                    return obj.id_AdminCls === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Birthday:
                return (obj) => {
                    return obj.birthday === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_NativePlace:
                return (obj) => {
                    return obj.nativePlace === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Duty:
                return (obj) => {
                    return obj.duty === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IDCardNo:
                return (obj) => {
                    return obj.idCardNo === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuCardNo:
                return (obj) => {
                    return obj.stuCardNo === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_LiveAddress:
                return (obj) => {
                    return obj.liveAddress === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_HomePhone:
                return (obj) => {
                    return obj.homePhone === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Id_CardNo:
                return (obj) => {
                    return obj.id_CardNo === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_CardNo:
                return (obj) => {
                    return obj.cardNo === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsAvconClassUser:
                return (obj) => {
                    return obj.isAvconClassUser === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsAvconUser:
                return (obj) => {
                    return obj.isAvconUser === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsGpUser:
                return (obj) => {
                    return obj.isGpUser === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsLocalUser:
                return (obj) => {
                    return obj.isLocalUser === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsLeaved:
                return (obj) => {
                    return obj.isLeaved === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_UserID4Avcon:
                return (obj) => {
                    return obj.userID4Avcon === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_EnrollmentDate:
                return (obj) => {
                    return obj.enrollmentDate === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_PostCode:
                return (obj) => {
                    return obj.postCode === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Email:
                return (obj) => {
                    return obj.email === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsMessage:
                return (obj) => {
                    return obj.isMessage === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Microblog:
                return (obj) => {
                    return obj.microblog === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_PhoneNumber:
                return (obj) => {
                    return obj.phoneNumber === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Headphoto:
                return (obj) => {
                    return obj.headphoto === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_QQ:
                return (obj) => {
                    return obj.qQ === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_RegisterPassword:
                return (obj) => {
                    return obj.registerPassword === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsStudentInfoEN_js_1.clsStudentInfoEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[StudentInfo]中不存在！(in ${exports.studentInfo_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.StudentInfo_FilterFunByKey = StudentInfo_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function StudentInfo_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_StudentInfo) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrStudentInfo = await StudentInfo_GetObjLst_Cache();
        if (arrStudentInfo == null)
            return [];
        let arrStudentInfo_Sel = arrStudentInfo;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrStudentInfo_Sel.length == 0)
            return [];
        return arrStudentInfo_Sel.map(x => x.id_StudentInfo);
    }
    exports.StudentInfo_funcKey = StudentInfo_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function StudentInfo_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_GetFirstIDAsync = StudentInfo_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function StudentInfo_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_GetFirstID = StudentInfo_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function StudentInfo_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
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
                const objStudentInfo = StudentInfo_GetObjFromJsonObj(returnObj);
                return objStudentInfo;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_GetFirstObjAsync = StudentInfo_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function StudentInfo_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsStudentInfoEN_js_1.clsStudentInfoEN._CurrTabName;
        clsStudentInfoEN_js_1.clsStudentInfoEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsStudentInfoEN_js_1.clsStudentInfoEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsStudentInfoEN_js_1.clsStudentInfoEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsStudentInfoEN_js_1.clsStudentInfoEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrStudentInfoExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrStudentInfoObjLst_T = StudentInfo_GetObjLstByJSONObjLst(arrStudentInfoExObjLst_Cache);
            return arrStudentInfoObjLst_T;
        }
        try {
            const arrStudentInfoExObjLst = await StudentInfo_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrStudentInfoExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrStudentInfoExObjLst.length);
            console.log(strInfo);
            return arrStudentInfoExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.studentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.StudentInfo_GetObjLst_ClientCache = StudentInfo_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function StudentInfo_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsStudentInfoEN_js_1.clsStudentInfoEN._CurrTabName;
        clsStudentInfoEN_js_1.clsStudentInfoEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsStudentInfoEN_js_1.clsStudentInfoEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsStudentInfoEN_js_1.clsStudentInfoEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsStudentInfoEN_js_1.clsStudentInfoEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrStudentInfoExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrStudentInfoObjLst_T = StudentInfo_GetObjLstByJSONObjLst(arrStudentInfoExObjLst_Cache);
            return arrStudentInfoObjLst_T;
        }
        try {
            const arrStudentInfoExObjLst = await StudentInfo_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrStudentInfoExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrStudentInfoExObjLst.length);
            console.log(strInfo);
            return arrStudentInfoExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.studentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.StudentInfo_GetObjLst_localStorage = StudentInfo_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function StudentInfo_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsStudentInfoEN_js_1.clsStudentInfoEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrStudentInfoObjLst_Cache = JSON.parse(strTempObjLst);
            return arrStudentInfoObjLst_Cache;
        }
        else
            return null;
    }
    exports.StudentInfo_GetObjLst_localStorage_PureCache = StudentInfo_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function StudentInfo_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.studentInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = StudentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_GetObjLstAsync = StudentInfo_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function StudentInfo_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsStudentInfoEN_js_1.clsStudentInfoEN._CurrTabName;
        clsStudentInfoEN_js_1.clsStudentInfoEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsStudentInfoEN_js_1.clsStudentInfoEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsStudentInfoEN_js_1.clsStudentInfoEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsStudentInfoEN_js_1.clsStudentInfoEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrStudentInfoExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrStudentInfoObjLst_T = StudentInfo_GetObjLstByJSONObjLst(arrStudentInfoExObjLst_Cache);
            return arrStudentInfoObjLst_T;
        }
        try {
            const arrStudentInfoExObjLst = await StudentInfo_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrStudentInfoExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrStudentInfoExObjLst.length);
            console.log(strInfo);
            return arrStudentInfoExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.studentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.StudentInfo_GetObjLst_sessionStorage = StudentInfo_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function StudentInfo_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsStudentInfoEN_js_1.clsStudentInfoEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrStudentInfoObjLst_Cache = JSON.parse(strTempObjLst);
            return arrStudentInfoObjLst_Cache;
        }
        else
            return null;
    }
    exports.StudentInfo_GetObjLst_sessionStorage_PureCache = StudentInfo_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function StudentInfo_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrStudentInfoObjLst_Cache;
        switch (clsStudentInfoEN_js_1.clsStudentInfoEN.CacheModeId) {
            case "04": //sessionStorage
                arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_ClientCache();
                break;
            default:
                arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_ClientCache();
                break;
        }
        const arrStudentInfoObjLst = StudentInfo_GetObjLstByJSONObjLst(arrStudentInfoObjLst_Cache);
        return arrStudentInfoObjLst_Cache;
    }
    exports.StudentInfo_GetObjLst_Cache = StudentInfo_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function StudentInfo_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrStudentInfoObjLst_Cache;
        switch (clsStudentInfoEN_js_1.clsStudentInfoEN.CacheModeId) {
            case "04": //sessionStorage
                arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrStudentInfoObjLst_Cache = null;
                break;
            default:
                arrStudentInfoObjLst_Cache = null;
                break;
        }
        return arrStudentInfoObjLst_Cache;
    }
    exports.StudentInfo_GetObjLst_PureCache = StudentInfo_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_StudentInfo_Cond:条件对象
     * @returns 对象列表子集
    */
    async function StudentInfo_GetSubObjLst_Cache(objStudentInfo_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_Cache();
        let arrStudentInfo_Sel = arrStudentInfoObjLst_Cache;
        if (objStudentInfo_Cond.sf_FldComparisonOp == null || objStudentInfo_Cond.sf_FldComparisonOp == "")
            return arrStudentInfo_Sel;
        const dicFldComparisonOp = JSON.parse(objStudentInfo_Cond.sf_FldComparisonOp);
        //console.log("clsStudentInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objStudentInfo_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objStudentInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrStudentInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objStudentInfo_Cond), exports.studentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.StudentInfo_GetSubObjLst_Cache = StudentInfo_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_StudentInfo:关键字列表
    * @returns 对象列表
    **/
    async function StudentInfo_GetObjLstByid_StudentInfoLstAsync(arrid_StudentInfo) {
        const strThisFuncName = "GetObjLstByid_StudentInfoLstAsync";
        const strAction = "GetObjLstByid_StudentInfoLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_StudentInfo);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.studentInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = StudentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_GetObjLstByid_StudentInfoLstAsync = StudentInfo_GetObjLstByid_StudentInfoLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_StudentInfoLst:关键字列表
     * @returns 对象列表
    */
    async function StudentInfo_GetObjLstByid_StudentInfoLst_Cache(arrid_StudentInfoLst) {
        const strThisFuncName = "GetObjLstByid_StudentInfoLst_Cache";
        try {
            const arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_Cache();
            const arrStudentInfo_Sel = arrStudentInfoObjLst_Cache.filter(x => arrid_StudentInfoLst.indexOf(x.id_StudentInfo) > -1);
            return arrStudentInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_StudentInfoLst.join(","), exports.studentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.StudentInfo_GetObjLstByid_StudentInfoLst_Cache = StudentInfo_GetObjLstByid_StudentInfoLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function StudentInfo_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.studentInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = StudentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_GetTopObjLstAsync = StudentInfo_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function StudentInfo_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.studentInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = StudentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_GetObjLstByRangeAsync = StudentInfo_GetObjLstByRangeAsync;
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
    async function StudentInfo_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_GetObjLstByRange = StudentInfo_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function StudentInfo_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_Cache();
        if (arrStudentInfoObjLst_Cache.length == 0)
            return arrStudentInfoObjLst_Cache;
        let arrStudentInfo_Sel = arrStudentInfoObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objStudentInfo_Cond = new clsStudentInfoEN_js_1.clsStudentInfoEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objStudentInfo_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsStudentInfoWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objStudentInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrStudentInfo_Sel.length == 0)
                return arrStudentInfo_Sel;
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
                arrStudentInfo_Sel = arrStudentInfo_Sel.sort(StudentInfo_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrStudentInfo_Sel = arrStudentInfo_Sel.sort(objPagerPara.sortFun);
            }
            arrStudentInfo_Sel = arrStudentInfo_Sel.slice(intStart, intEnd);
            return arrStudentInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.studentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.StudentInfo_GetObjLstByPager_Cache = StudentInfo_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function StudentInfo_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.studentInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = StudentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_GetObjLstByPagerAsync = StudentInfo_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strid_StudentInfo:关键字
    * @returns 获取删除的结果
    **/
    async function StudentInfo_DelRecordAsync(strid_StudentInfo) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strid_StudentInfo);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_DelRecordAsync = StudentInfo_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_StudentInfo:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function StudentInfo_DelStudentInfosAsync(arrid_StudentInfo) {
        const strThisFuncName = "DelStudentInfosAsync";
        const strAction = "DelStudentInfos";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_StudentInfo);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_DelStudentInfosAsync = StudentInfo_DelStudentInfosAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function StudentInfo_DelStudentInfosByCondAsync(strWhereCond) {
        const strThisFuncName = "DelStudentInfosByCondAsync";
        const strAction = "DelStudentInfosByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_DelStudentInfosByCondAsync = StudentInfo_DelStudentInfosByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objStudentInfoEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function StudentInfo_AddNewRecordAsync(objStudentInfoEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objStudentInfoEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objStudentInfoEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_AddNewRecordAsync = StudentInfo_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objStudentInfoEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function StudentInfo_AddNewRecordWithMaxIdAsync(objStudentInfoEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objStudentInfoEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_AddNewRecordWithMaxIdAsync = StudentInfo_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objStudentInfoEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function StudentInfo_AddNewRecordWithReturnKeyAsync(objStudentInfoEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objStudentInfoEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_AddNewRecordWithReturnKeyAsync = StudentInfo_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objStudentInfoEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function StudentInfo_AddNewRecordWithReturnKey(objStudentInfoEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objStudentInfoEN.id_StudentInfo === null || objStudentInfoEN.id_StudentInfo === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objStudentInfoEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_AddNewRecordWithReturnKey = StudentInfo_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objStudentInfoEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function StudentInfo_UpdateRecordAsync(objStudentInfoEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objStudentInfoEN.sf_UpdFldSetStr === undefined || objStudentInfoEN.sf_UpdFldSetStr === null || objStudentInfoEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objStudentInfoEN.id_StudentInfo);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objStudentInfoEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_UpdateRecordAsync = StudentInfo_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objStudentInfoEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function StudentInfo_UpdateWithConditionAsync(objStudentInfoEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objStudentInfoEN.sf_UpdFldSetStr === undefined || objStudentInfoEN.sf_UpdFldSetStr === null || objStudentInfoEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objStudentInfoEN.id_StudentInfo);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
        objStudentInfoEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objStudentInfoEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_UpdateWithConditionAsync = StudentInfo_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_StudentInfo_Cond:条件对象
     * @returns 对象列表子集
    */
    async function StudentInfo_IsExistRecord_Cache(objStudentInfo_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_Cache();
        if (arrStudentInfoObjLst_Cache == null)
            return false;
        let arrStudentInfo_Sel = arrStudentInfoObjLst_Cache;
        if (objStudentInfo_Cond.sf_FldComparisonOp == null || objStudentInfo_Cond.sf_FldComparisonOp == "")
            return arrStudentInfo_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objStudentInfo_Cond.sf_FldComparisonOp);
        //console.log("clsStudentInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objStudentInfo_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objStudentInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrStudentInfo_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objStudentInfo_Cond), exports.studentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.StudentInfo_IsExistRecord_Cache = StudentInfo_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function StudentInfo_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_IsExistRecordAsync = StudentInfo_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_StudentInfo:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function StudentInfo_IsExist(strid_StudentInfo, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_IsExist = StudentInfo_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_StudentInfo:所给的关键字
     * @returns 对象
    */
    async function StudentInfo_IsExist_Cache(strid_StudentInfo) {
        const strThisFuncName = "IsExist_Cache";
        const arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_Cache();
        if (arrStudentInfoObjLst_Cache == null)
            return false;
        try {
            const arrStudentInfo_Sel = arrStudentInfoObjLst_Cache.filter(x => x.id_StudentInfo == strid_StudentInfo);
            if (arrStudentInfo_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_StudentInfo, exports.studentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.StudentInfo_IsExist_Cache = StudentInfo_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_StudentInfo:关键字
    * @returns 是否存在?存在返回True
    **/
    async function StudentInfo_IsExistAsync(strid_StudentInfo) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_IsExistAsync = StudentInfo_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function StudentInfo_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_GetRecCountByCondAsync = StudentInfo_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objStudentInfo_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function StudentInfo_GetRecCountByCond_Cache(objStudentInfo_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_Cache();
        if (arrStudentInfoObjLst_Cache == null)
            return 0;
        let arrStudentInfo_Sel = arrStudentInfoObjLst_Cache;
        if (objStudentInfo_Cond.sf_FldComparisonOp == null || objStudentInfo_Cond.sf_FldComparisonOp == "")
            return arrStudentInfo_Sel.length;
        const dicFldComparisonOp = JSON.parse(objStudentInfo_Cond.sf_FldComparisonOp);
        //console.log("clsStudentInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objStudentInfo_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objStudentInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrStudentInfo_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objStudentInfo_Cond), exports.studentInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.StudentInfo_GetRecCountByCond_Cache = StudentInfo_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function StudentInfo_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_GetMaxStrIdAsync = StudentInfo_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function StudentInfo_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.studentInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.studentInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.StudentInfo_GetMaxStrIdByPrefix = StudentInfo_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function StudentInfo_GetWebApiUrl(strController, strAction) {
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
    exports.StudentInfo_GetWebApiUrl = StudentInfo_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function StudentInfo_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsStudentInfoEN_js_1.clsStudentInfoEN._CurrTabName;
        switch (clsStudentInfoEN_js_1.clsStudentInfoEN.CacheModeId) {
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
    exports.StudentInfo_ReFreshCache = StudentInfo_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function StudentInfo_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsStudentInfoEN_js_1.clsStudentInfoEN._CurrTabName;
            switch (clsStudentInfoEN_js_1.clsStudentInfoEN.CacheModeId) {
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
    exports.StudentInfo_ReFreshThisCache = StudentInfo_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function StudentInfo_CheckPropertyNew(pobjStudentInfoEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.stuID) === true) {
            throw new Error("(errid:Watl000058)字段[学号]不能为空(In 学生)!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.stuName) === true) {
            throw new Error("(errid:Watl000058)字段[姓名]不能为空(In 学生)!(clsStudentInfoBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_StudentInfo) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_StudentInfo) > 8) {
            throw new Error("(errid:Watl000059)字段[学生流水号(id_StudentInfo)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_StudentInfo)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.stuID) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.stuID) > 20) {
            throw new Error("(errid:Watl000059)字段[学号(stuID)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.stuID)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.stuName) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.stuName) > 50) {
            throw new Error("(errid:Watl000059)字段[姓名(stuName)]的长度不能超过50(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.stuName)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_Politics) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_Politics) > 4) {
            throw new Error("(errid:Watl000059)字段[政治面貌流水号(id_Politics)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_Politics)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_Sex) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_Sex) > 4) {
            throw new Error("(errid:Watl000059)字段[性别流水号(id_Sex)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_Sex)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_Ethnic) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_Ethnic) > 4) {
            throw new Error("(errid:Watl000059)字段[民族流水号(id_Ethnic)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_Ethnic)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_UniZone) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_UniZone) > 4) {
            throw new Error("(errid:Watl000059)字段[校区流水号(id_UniZone)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_UniZone)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_StuType) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_StuType) > 4) {
            throw new Error("(errid:Watl000059)字段[学生类别流水号(id_StuType)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_StuType)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_XzCollege) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_XzCollege)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_XzMajor) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000059)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_XzMajor)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_GradeBase) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_GradeBase) > 4) {
            throw new Error("(errid:Watl000059)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_GradeBase)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_AdminCls) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_AdminCls) > 8) {
            throw new Error("(errid:Watl000059)字段[行政班流水号(id_AdminCls)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_AdminCls)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.birthday) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.birthday) > 8) {
            throw new Error("(errid:Watl000059)字段[出生日期(birthday)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.birthday)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.nativePlace) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.nativePlace) > 200) {
            throw new Error("(errid:Watl000059)字段[籍贯(nativePlace)]的长度不能超过200(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.nativePlace)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.duty) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.duty) > 30) {
            throw new Error("(errid:Watl000059)字段[职位(duty)]的长度不能超过30(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.duty)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.idCardNo) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.idCardNo) > 20) {
            throw new Error("(errid:Watl000059)字段[身份证号(idCardNo)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.idCardNo)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.stuCardNo) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.stuCardNo) > 20) {
            throw new Error("(errid:Watl000059)字段[学生证号(stuCardNo)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.stuCardNo)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.liveAddress) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.liveAddress) > 200) {
            throw new Error("(errid:Watl000059)字段[居住地址(liveAddress)]的长度不能超过200(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.liveAddress)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.homePhone) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.homePhone) > 20) {
            throw new Error("(errid:Watl000059)字段[住宅电话(homePhone)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.homePhone)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_CardNo) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_CardNo) > 20) {
            throw new Error("(errid:Watl000059)字段[内卡号(id_CardNo)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_CardNo)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.cardNo) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.cardNo) > 18) {
            throw new Error("(errid:Watl000059)字段[卡号(cardNo)]的长度不能超过18(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.cardNo)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.userId) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.userId) > 20) {
            throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.userId)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.userID4Avcon) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.userID4Avcon) > 20) {
            throw new Error("(errid:Watl000059)字段[UserID4Avcon(userID4Avcon)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.userID4Avcon)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.enrollmentDate) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.enrollmentDate) > 8) {
            throw new Error("(errid:Watl000059)字段[入校日期(enrollmentDate)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.enrollmentDate)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.postCode) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.postCode) > 6) {
            throw new Error("(errid:Watl000059)字段[邮编(postCode)]的长度不能超过6(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.postCode)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.email) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.email) > 100) {
            throw new Error("(errid:Watl000059)字段[电子邮箱(email)]的长度不能超过100(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.email)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.microblog) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.microblog) > 200) {
            throw new Error("(errid:Watl000059)字段[Microblog(microblog)]的长度不能超过200(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.microblog)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.phoneNumber) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.phoneNumber) > 15) {
            throw new Error("(errid:Watl000059)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.phoneNumber)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.headphoto) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.headphoto) > 500) {
            throw new Error("(errid:Watl000059)字段[Headphoto(headphoto)]的长度不能超过500(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.headphoto)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.qQ) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.qQ) > 100) {
            throw new Error("(errid:Watl000059)字段[QQ(qQ)]的长度不能超过100(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.qQ)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.registerPassword) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.registerPassword) > 30) {
            throw new Error("(errid:Watl000059)字段[RegisterPassword(registerPassword)]的长度不能超过30(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.registerPassword)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.updDate)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.updUser)(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.memo)(clsStudentInfoBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_StudentInfo) == false && undefined !== pobjStudentInfoEN.id_StudentInfo && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_StudentInfo) === false) {
            throw new Error("(errid:Watl000060)字段[学生流水号(id_StudentInfo)]的值:[$(pobjStudentInfoEN.id_StudentInfo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.stuID) == false && undefined !== pobjStudentInfoEN.stuID && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.stuID) === false) {
            throw new Error("(errid:Watl000060)字段[学号(stuID)]的值:[$(pobjStudentInfoEN.stuID)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.stuName) == false && undefined !== pobjStudentInfoEN.stuName && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.stuName) === false) {
            throw new Error("(errid:Watl000060)字段[姓名(stuName)]的值:[$(pobjStudentInfoEN.stuName)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_Politics) == false && undefined !== pobjStudentInfoEN.id_Politics && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_Politics) === false) {
            throw new Error("(errid:Watl000060)字段[政治面貌流水号(id_Politics)]的值:[$(pobjStudentInfoEN.id_Politics)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_Sex) == false && undefined !== pobjStudentInfoEN.id_Sex && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_Sex) === false) {
            throw new Error("(errid:Watl000060)字段[性别流水号(id_Sex)]的值:[$(pobjStudentInfoEN.id_Sex)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_Ethnic) == false && undefined !== pobjStudentInfoEN.id_Ethnic && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_Ethnic) === false) {
            throw new Error("(errid:Watl000060)字段[民族流水号(id_Ethnic)]的值:[$(pobjStudentInfoEN.id_Ethnic)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_UniZone) == false && undefined !== pobjStudentInfoEN.id_UniZone && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_UniZone) === false) {
            throw new Error("(errid:Watl000060)字段[校区流水号(id_UniZone)]的值:[$(pobjStudentInfoEN.id_UniZone)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_StuType) == false && undefined !== pobjStudentInfoEN.id_StuType && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_StuType) === false) {
            throw new Error("(errid:Watl000060)字段[学生类别流水号(id_StuType)]的值:[$(pobjStudentInfoEN.id_StuType)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_XzCollege) == false && undefined !== pobjStudentInfoEN.id_XzCollege && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjStudentInfoEN.id_XzCollege)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_XzMajor) == false && undefined !== pobjStudentInfoEN.id_XzMajor && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000060)字段[专业流水号(id_XzMajor)]的值:[$(pobjStudentInfoEN.id_XzMajor)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_GradeBase) == false && undefined !== pobjStudentInfoEN.id_GradeBase && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_GradeBase) === false) {
            throw new Error("(errid:Watl000060)字段[年级流水号(id_GradeBase)]的值:[$(pobjStudentInfoEN.id_GradeBase)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_AdminCls) == false && undefined !== pobjStudentInfoEN.id_AdminCls && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_AdminCls) === false) {
            throw new Error("(errid:Watl000060)字段[行政班流水号(id_AdminCls)]的值:[$(pobjStudentInfoEN.id_AdminCls)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.birthday) == false && undefined !== pobjStudentInfoEN.birthday && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.birthday) === false) {
            throw new Error("(errid:Watl000060)字段[出生日期(birthday)]的值:[$(pobjStudentInfoEN.birthday)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.nativePlace) == false && undefined !== pobjStudentInfoEN.nativePlace && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.nativePlace) === false) {
            throw new Error("(errid:Watl000060)字段[籍贯(nativePlace)]的值:[$(pobjStudentInfoEN.nativePlace)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.duty) == false && undefined !== pobjStudentInfoEN.duty && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.duty) === false) {
            throw new Error("(errid:Watl000060)字段[职位(duty)]的值:[$(pobjStudentInfoEN.duty)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.idCardNo) == false && undefined !== pobjStudentInfoEN.idCardNo && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.idCardNo) === false) {
            throw new Error("(errid:Watl000060)字段[身份证号(idCardNo)]的值:[$(pobjStudentInfoEN.idCardNo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.stuCardNo) == false && undefined !== pobjStudentInfoEN.stuCardNo && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.stuCardNo) === false) {
            throw new Error("(errid:Watl000060)字段[学生证号(stuCardNo)]的值:[$(pobjStudentInfoEN.stuCardNo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.liveAddress) == false && undefined !== pobjStudentInfoEN.liveAddress && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.liveAddress) === false) {
            throw new Error("(errid:Watl000060)字段[居住地址(liveAddress)]的值:[$(pobjStudentInfoEN.liveAddress)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.homePhone) == false && undefined !== pobjStudentInfoEN.homePhone && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.homePhone) === false) {
            throw new Error("(errid:Watl000060)字段[住宅电话(homePhone)]的值:[$(pobjStudentInfoEN.homePhone)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_CardNo) == false && undefined !== pobjStudentInfoEN.id_CardNo && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_CardNo) === false) {
            throw new Error("(errid:Watl000060)字段[内卡号(id_CardNo)]的值:[$(pobjStudentInfoEN.id_CardNo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.cardNo) == false && undefined !== pobjStudentInfoEN.cardNo && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.cardNo) === false) {
            throw new Error("(errid:Watl000060)字段[卡号(cardNo)]的值:[$(pobjStudentInfoEN.cardNo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if (null != pobjStudentInfoEN.isAvconClassUser && undefined !== pobjStudentInfoEN.isAvconClassUser && jsString_js_1.tzDataType.isBoolean(pobjStudentInfoEN.isAvconClassUser) === false) {
            throw new Error("(errid:Watl000060)字段[IsAvconClassUser(isAvconClassUser)]的值:[$(pobjStudentInfoEN.isAvconClassUser)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if (null != pobjStudentInfoEN.isAvconUser && undefined !== pobjStudentInfoEN.isAvconUser && jsString_js_1.tzDataType.isBoolean(pobjStudentInfoEN.isAvconUser) === false) {
            throw new Error("(errid:Watl000060)字段[IsAvconUser(isAvconUser)]的值:[$(pobjStudentInfoEN.isAvconUser)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if (null != pobjStudentInfoEN.isGpUser && undefined !== pobjStudentInfoEN.isGpUser && jsString_js_1.tzDataType.isBoolean(pobjStudentInfoEN.isGpUser) === false) {
            throw new Error("(errid:Watl000060)字段[是否Gp用户(isGpUser)]的值:[$(pobjStudentInfoEN.isGpUser)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if (null != pobjStudentInfoEN.isLocalUser && undefined !== pobjStudentInfoEN.isLocalUser && jsString_js_1.tzDataType.isBoolean(pobjStudentInfoEN.isLocalUser) === false) {
            throw new Error("(errid:Watl000060)字段[是否本地用户(isLocalUser)]的值:[$(pobjStudentInfoEN.isLocalUser)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if (null != pobjStudentInfoEN.isLeaved && undefined !== pobjStudentInfoEN.isLeaved && jsString_js_1.tzDataType.isBoolean(pobjStudentInfoEN.isLeaved) === false) {
            throw new Error("(errid:Watl000060)字段[IsLeaved(isLeaved)]的值:[$(pobjStudentInfoEN.isLeaved)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.userId) == false && undefined !== pobjStudentInfoEN.userId && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.userId) === false) {
            throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjStudentInfoEN.userId)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.userID4Avcon) == false && undefined !== pobjStudentInfoEN.userID4Avcon && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.userID4Avcon) === false) {
            throw new Error("(errid:Watl000060)字段[UserID4Avcon(userID4Avcon)]的值:[$(pobjStudentInfoEN.userID4Avcon)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.enrollmentDate) == false && undefined !== pobjStudentInfoEN.enrollmentDate && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.enrollmentDate) === false) {
            throw new Error("(errid:Watl000060)字段[入校日期(enrollmentDate)]的值:[$(pobjStudentInfoEN.enrollmentDate)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.postCode) == false && undefined !== pobjStudentInfoEN.postCode && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.postCode) === false) {
            throw new Error("(errid:Watl000060)字段[邮编(postCode)]的值:[$(pobjStudentInfoEN.postCode)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.email) == false && undefined !== pobjStudentInfoEN.email && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.email) === false) {
            throw new Error("(errid:Watl000060)字段[电子邮箱(email)]的值:[$(pobjStudentInfoEN.email)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if (null != pobjStudentInfoEN.isMessage && undefined !== pobjStudentInfoEN.isMessage && jsString_js_1.tzDataType.isBoolean(pobjStudentInfoEN.isMessage) === false) {
            throw new Error("(errid:Watl000060)字段[IsMessage(isMessage)]的值:[$(pobjStudentInfoEN.isMessage)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.microblog) == false && undefined !== pobjStudentInfoEN.microblog && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.microblog) === false) {
            throw new Error("(errid:Watl000060)字段[Microblog(microblog)]的值:[$(pobjStudentInfoEN.microblog)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.phoneNumber) == false && undefined !== pobjStudentInfoEN.phoneNumber && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.phoneNumber) === false) {
            throw new Error("(errid:Watl000060)字段[PhoneNumber(phoneNumber)]的值:[$(pobjStudentInfoEN.phoneNumber)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.headphoto) == false && undefined !== pobjStudentInfoEN.headphoto && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.headphoto) === false) {
            throw new Error("(errid:Watl000060)字段[Headphoto(headphoto)]的值:[$(pobjStudentInfoEN.headphoto)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.qQ) == false && undefined !== pobjStudentInfoEN.qQ && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.qQ) === false) {
            throw new Error("(errid:Watl000060)字段[QQ(qQ)]的值:[$(pobjStudentInfoEN.qQ)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.registerPassword) == false && undefined !== pobjStudentInfoEN.registerPassword && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.registerPassword) === false) {
            throw new Error("(errid:Watl000060)字段[RegisterPassword(registerPassword)]的值:[$(pobjStudentInfoEN.registerPassword)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.updDate) == false && undefined !== pobjStudentInfoEN.updDate && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjStudentInfoEN.updDate)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.updUser) == false && undefined !== pobjStudentInfoEN.updUser && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjStudentInfoEN.updUser)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.memo) == false && undefined !== pobjStudentInfoEN.memo && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjStudentInfoEN.memo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjStudentInfoEN.SetIsCheckProperty(true);
    }
    exports.StudentInfo_CheckPropertyNew = StudentInfo_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function StudentInfo_CheckProperty4Update(pobjStudentInfoEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_StudentInfo) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_StudentInfo) > 8) {
            throw new Error("(errid:Watl000062)字段[学生流水号(id_StudentInfo)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_StudentInfo)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.stuID) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.stuID) > 20) {
            throw new Error("(errid:Watl000062)字段[学号(stuID)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.stuID)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.stuName) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.stuName) > 50) {
            throw new Error("(errid:Watl000062)字段[姓名(stuName)]的长度不能超过50(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.stuName)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_Politics) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_Politics) > 4) {
            throw new Error("(errid:Watl000062)字段[政治面貌流水号(id_Politics)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_Politics)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_Sex) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_Sex) > 4) {
            throw new Error("(errid:Watl000062)字段[性别流水号(id_Sex)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_Sex)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_Ethnic) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_Ethnic) > 4) {
            throw new Error("(errid:Watl000062)字段[民族流水号(id_Ethnic)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_Ethnic)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_UniZone) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_UniZone) > 4) {
            throw new Error("(errid:Watl000062)字段[校区流水号(id_UniZone)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_UniZone)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_StuType) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_StuType) > 4) {
            throw new Error("(errid:Watl000062)字段[学生类别流水号(id_StuType)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_StuType)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_XzCollege) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_XzCollege)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_XzMajor) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000062)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_XzMajor)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_GradeBase) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_GradeBase) > 4) {
            throw new Error("(errid:Watl000062)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_GradeBase)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_AdminCls) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_AdminCls) > 8) {
            throw new Error("(errid:Watl000062)字段[行政班流水号(id_AdminCls)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_AdminCls)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.birthday) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.birthday) > 8) {
            throw new Error("(errid:Watl000062)字段[出生日期(birthday)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.birthday)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.nativePlace) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.nativePlace) > 200) {
            throw new Error("(errid:Watl000062)字段[籍贯(nativePlace)]的长度不能超过200(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.nativePlace)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.duty) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.duty) > 30) {
            throw new Error("(errid:Watl000062)字段[职位(duty)]的长度不能超过30(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.duty)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.idCardNo) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.idCardNo) > 20) {
            throw new Error("(errid:Watl000062)字段[身份证号(idCardNo)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.idCardNo)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.stuCardNo) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.stuCardNo) > 20) {
            throw new Error("(errid:Watl000062)字段[学生证号(stuCardNo)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.stuCardNo)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.liveAddress) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.liveAddress) > 200) {
            throw new Error("(errid:Watl000062)字段[居住地址(liveAddress)]的长度不能超过200(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.liveAddress)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.homePhone) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.homePhone) > 20) {
            throw new Error("(errid:Watl000062)字段[住宅电话(homePhone)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.homePhone)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_CardNo) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.id_CardNo) > 20) {
            throw new Error("(errid:Watl000062)字段[内卡号(id_CardNo)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_CardNo)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.cardNo) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.cardNo) > 18) {
            throw new Error("(errid:Watl000062)字段[卡号(cardNo)]的长度不能超过18(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.cardNo)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.userId) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.userId) > 20) {
            throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.userId)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.userID4Avcon) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.userID4Avcon) > 20) {
            throw new Error("(errid:Watl000062)字段[UserID4Avcon(userID4Avcon)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.userID4Avcon)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.enrollmentDate) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.enrollmentDate) > 8) {
            throw new Error("(errid:Watl000062)字段[入校日期(enrollmentDate)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.enrollmentDate)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.postCode) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.postCode) > 6) {
            throw new Error("(errid:Watl000062)字段[邮编(postCode)]的长度不能超过6(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.postCode)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.email) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.email) > 100) {
            throw new Error("(errid:Watl000062)字段[电子邮箱(email)]的长度不能超过100(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.email)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.microblog) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.microblog) > 200) {
            throw new Error("(errid:Watl000062)字段[Microblog(microblog)]的长度不能超过200(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.microblog)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.phoneNumber) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.phoneNumber) > 15) {
            throw new Error("(errid:Watl000062)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.phoneNumber)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.headphoto) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.headphoto) > 500) {
            throw new Error("(errid:Watl000062)字段[Headphoto(headphoto)]的长度不能超过500(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.headphoto)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.qQ) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.qQ) > 100) {
            throw new Error("(errid:Watl000062)字段[QQ(qQ)]的长度不能超过100(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.qQ)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.registerPassword) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.registerPassword) > 30) {
            throw new Error("(errid:Watl000062)字段[RegisterPassword(registerPassword)]的长度不能超过30(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.registerPassword)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.updDate)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.updUser)(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjStudentInfoEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.memo)(clsStudentInfoBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_StudentInfo) == false && undefined !== pobjStudentInfoEN.id_StudentInfo && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_StudentInfo) === false) {
            throw new Error("(errid:Watl000063)字段[学生流水号(id_StudentInfo)]的值:[$(pobjStudentInfoEN.id_StudentInfo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.stuID) == false && undefined !== pobjStudentInfoEN.stuID && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.stuID) === false) {
            throw new Error("(errid:Watl000063)字段[学号(stuID)]的值:[$(pobjStudentInfoEN.stuID)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.stuName) == false && undefined !== pobjStudentInfoEN.stuName && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.stuName) === false) {
            throw new Error("(errid:Watl000063)字段[姓名(stuName)]的值:[$(pobjStudentInfoEN.stuName)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_Politics) == false && undefined !== pobjStudentInfoEN.id_Politics && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_Politics) === false) {
            throw new Error("(errid:Watl000063)字段[政治面貌流水号(id_Politics)]的值:[$(pobjStudentInfoEN.id_Politics)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_Sex) == false && undefined !== pobjStudentInfoEN.id_Sex && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_Sex) === false) {
            throw new Error("(errid:Watl000063)字段[性别流水号(id_Sex)]的值:[$(pobjStudentInfoEN.id_Sex)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_Ethnic) == false && undefined !== pobjStudentInfoEN.id_Ethnic && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_Ethnic) === false) {
            throw new Error("(errid:Watl000063)字段[民族流水号(id_Ethnic)]的值:[$(pobjStudentInfoEN.id_Ethnic)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_UniZone) == false && undefined !== pobjStudentInfoEN.id_UniZone && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_UniZone) === false) {
            throw new Error("(errid:Watl000063)字段[校区流水号(id_UniZone)]的值:[$(pobjStudentInfoEN.id_UniZone)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_StuType) == false && undefined !== pobjStudentInfoEN.id_StuType && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_StuType) === false) {
            throw new Error("(errid:Watl000063)字段[学生类别流水号(id_StuType)]的值:[$(pobjStudentInfoEN.id_StuType)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_XzCollege) == false && undefined !== pobjStudentInfoEN.id_XzCollege && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjStudentInfoEN.id_XzCollege)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_XzMajor) == false && undefined !== pobjStudentInfoEN.id_XzMajor && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000063)字段[专业流水号(id_XzMajor)]的值:[$(pobjStudentInfoEN.id_XzMajor)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_GradeBase) == false && undefined !== pobjStudentInfoEN.id_GradeBase && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_GradeBase) === false) {
            throw new Error("(errid:Watl000063)字段[年级流水号(id_GradeBase)]的值:[$(pobjStudentInfoEN.id_GradeBase)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_AdminCls) == false && undefined !== pobjStudentInfoEN.id_AdminCls && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_AdminCls) === false) {
            throw new Error("(errid:Watl000063)字段[行政班流水号(id_AdminCls)]的值:[$(pobjStudentInfoEN.id_AdminCls)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.birthday) == false && undefined !== pobjStudentInfoEN.birthday && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.birthday) === false) {
            throw new Error("(errid:Watl000063)字段[出生日期(birthday)]的值:[$(pobjStudentInfoEN.birthday)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.nativePlace) == false && undefined !== pobjStudentInfoEN.nativePlace && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.nativePlace) === false) {
            throw new Error("(errid:Watl000063)字段[籍贯(nativePlace)]的值:[$(pobjStudentInfoEN.nativePlace)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.duty) == false && undefined !== pobjStudentInfoEN.duty && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.duty) === false) {
            throw new Error("(errid:Watl000063)字段[职位(duty)]的值:[$(pobjStudentInfoEN.duty)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.idCardNo) == false && undefined !== pobjStudentInfoEN.idCardNo && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.idCardNo) === false) {
            throw new Error("(errid:Watl000063)字段[身份证号(idCardNo)]的值:[$(pobjStudentInfoEN.idCardNo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.stuCardNo) == false && undefined !== pobjStudentInfoEN.stuCardNo && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.stuCardNo) === false) {
            throw new Error("(errid:Watl000063)字段[学生证号(stuCardNo)]的值:[$(pobjStudentInfoEN.stuCardNo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.liveAddress) == false && undefined !== pobjStudentInfoEN.liveAddress && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.liveAddress) === false) {
            throw new Error("(errid:Watl000063)字段[居住地址(liveAddress)]的值:[$(pobjStudentInfoEN.liveAddress)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.homePhone) == false && undefined !== pobjStudentInfoEN.homePhone && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.homePhone) === false) {
            throw new Error("(errid:Watl000063)字段[住宅电话(homePhone)]的值:[$(pobjStudentInfoEN.homePhone)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_CardNo) == false && undefined !== pobjStudentInfoEN.id_CardNo && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.id_CardNo) === false) {
            throw new Error("(errid:Watl000063)字段[内卡号(id_CardNo)]的值:[$(pobjStudentInfoEN.id_CardNo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.cardNo) == false && undefined !== pobjStudentInfoEN.cardNo && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.cardNo) === false) {
            throw new Error("(errid:Watl000063)字段[卡号(cardNo)]的值:[$(pobjStudentInfoEN.cardNo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if (null != pobjStudentInfoEN.isAvconClassUser && undefined !== pobjStudentInfoEN.isAvconClassUser && jsString_js_1.tzDataType.isBoolean(pobjStudentInfoEN.isAvconClassUser) === false) {
            throw new Error("(errid:Watl000063)字段[IsAvconClassUser(isAvconClassUser)]的值:[$(pobjStudentInfoEN.isAvconClassUser)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if (null != pobjStudentInfoEN.isAvconUser && undefined !== pobjStudentInfoEN.isAvconUser && jsString_js_1.tzDataType.isBoolean(pobjStudentInfoEN.isAvconUser) === false) {
            throw new Error("(errid:Watl000063)字段[IsAvconUser(isAvconUser)]的值:[$(pobjStudentInfoEN.isAvconUser)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if (null != pobjStudentInfoEN.isGpUser && undefined !== pobjStudentInfoEN.isGpUser && jsString_js_1.tzDataType.isBoolean(pobjStudentInfoEN.isGpUser) === false) {
            throw new Error("(errid:Watl000063)字段[是否Gp用户(isGpUser)]的值:[$(pobjStudentInfoEN.isGpUser)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if (null != pobjStudentInfoEN.isLocalUser && undefined !== pobjStudentInfoEN.isLocalUser && jsString_js_1.tzDataType.isBoolean(pobjStudentInfoEN.isLocalUser) === false) {
            throw new Error("(errid:Watl000063)字段[是否本地用户(isLocalUser)]的值:[$(pobjStudentInfoEN.isLocalUser)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if (null != pobjStudentInfoEN.isLeaved && undefined !== pobjStudentInfoEN.isLeaved && jsString_js_1.tzDataType.isBoolean(pobjStudentInfoEN.isLeaved) === false) {
            throw new Error("(errid:Watl000063)字段[IsLeaved(isLeaved)]的值:[$(pobjStudentInfoEN.isLeaved)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.userId) == false && undefined !== pobjStudentInfoEN.userId && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.userId) === false) {
            throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjStudentInfoEN.userId)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.userID4Avcon) == false && undefined !== pobjStudentInfoEN.userID4Avcon && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.userID4Avcon) === false) {
            throw new Error("(errid:Watl000063)字段[UserID4Avcon(userID4Avcon)]的值:[$(pobjStudentInfoEN.userID4Avcon)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.enrollmentDate) == false && undefined !== pobjStudentInfoEN.enrollmentDate && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.enrollmentDate) === false) {
            throw new Error("(errid:Watl000063)字段[入校日期(enrollmentDate)]的值:[$(pobjStudentInfoEN.enrollmentDate)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.postCode) == false && undefined !== pobjStudentInfoEN.postCode && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.postCode) === false) {
            throw new Error("(errid:Watl000063)字段[邮编(postCode)]的值:[$(pobjStudentInfoEN.postCode)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.email) == false && undefined !== pobjStudentInfoEN.email && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.email) === false) {
            throw new Error("(errid:Watl000063)字段[电子邮箱(email)]的值:[$(pobjStudentInfoEN.email)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if (null != pobjStudentInfoEN.isMessage && undefined !== pobjStudentInfoEN.isMessage && jsString_js_1.tzDataType.isBoolean(pobjStudentInfoEN.isMessage) === false) {
            throw new Error("(errid:Watl000063)字段[IsMessage(isMessage)]的值:[$(pobjStudentInfoEN.isMessage)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.microblog) == false && undefined !== pobjStudentInfoEN.microblog && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.microblog) === false) {
            throw new Error("(errid:Watl000063)字段[Microblog(microblog)]的值:[$(pobjStudentInfoEN.microblog)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.phoneNumber) == false && undefined !== pobjStudentInfoEN.phoneNumber && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.phoneNumber) === false) {
            throw new Error("(errid:Watl000063)字段[PhoneNumber(phoneNumber)]的值:[$(pobjStudentInfoEN.phoneNumber)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.headphoto) == false && undefined !== pobjStudentInfoEN.headphoto && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.headphoto) === false) {
            throw new Error("(errid:Watl000063)字段[Headphoto(headphoto)]的值:[$(pobjStudentInfoEN.headphoto)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.qQ) == false && undefined !== pobjStudentInfoEN.qQ && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.qQ) === false) {
            throw new Error("(errid:Watl000063)字段[QQ(qQ)]的值:[$(pobjStudentInfoEN.qQ)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.registerPassword) == false && undefined !== pobjStudentInfoEN.registerPassword && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.registerPassword) === false) {
            throw new Error("(errid:Watl000063)字段[RegisterPassword(registerPassword)]的值:[$(pobjStudentInfoEN.registerPassword)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.updDate) == false && undefined !== pobjStudentInfoEN.updDate && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjStudentInfoEN.updDate)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.updUser) == false && undefined !== pobjStudentInfoEN.updUser && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjStudentInfoEN.updUser)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.memo) == false && undefined !== pobjStudentInfoEN.memo && jsString_js_1.tzDataType.isString(pobjStudentInfoEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjStudentInfoEN.memo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjStudentInfoEN.id_StudentInfo) === true) {
            throw new Error("(errid:Watl000064)字段[学生流水号]不能为空(In 学生)!(clsStudentInfoBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjStudentInfoEN.SetIsCheckProperty(true);
    }
    exports.StudentInfo_CheckProperty4Update = StudentInfo_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function StudentInfo_GetJSONStrByObj(pobjStudentInfoEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjStudentInfoEN.sf_UpdFldSetStr = pobjStudentInfoEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjStudentInfoEN);
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
    exports.StudentInfo_GetJSONStrByObj = StudentInfo_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function StudentInfo_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrStudentInfoObjLst = new Array();
        if (strJSON === "") {
            return arrStudentInfoObjLst;
        }
        try {
            arrStudentInfoObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrStudentInfoObjLst;
        }
        return arrStudentInfoObjLst;
    }
    exports.StudentInfo_GetObjLstByJSONStr = StudentInfo_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrStudentInfoObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function StudentInfo_GetObjLstByJSONObjLst(arrStudentInfoObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrStudentInfoObjLst = new Array();
        for (const objInFor of arrStudentInfoObjLstS) {
            const obj1 = StudentInfo_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrStudentInfoObjLst.push(obj1);
        }
        return arrStudentInfoObjLst;
    }
    exports.StudentInfo_GetObjLstByJSONObjLst = StudentInfo_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function StudentInfo_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjStudentInfoEN = new clsStudentInfoEN_js_1.clsStudentInfoEN();
        if (strJSON === "") {
            return pobjStudentInfoEN;
        }
        try {
            pobjStudentInfoEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjStudentInfoEN;
        }
        return pobjStudentInfoEN;
    }
    exports.StudentInfo_GetObjByJSONStr = StudentInfo_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function StudentInfo_GetCombineCondition(objStudentInfo_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_StudentInfo) == true) {
            const strComparisonOp_id_StudentInfo = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_StudentInfo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_StudentInfo, objStudentInfo_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuID) == true) {
            const strComparisonOp_StuID = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuID, objStudentInfo_Cond.stuID, strComparisonOp_StuID);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuName) == true) {
            const strComparisonOp_StuName = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuName, objStudentInfo_Cond.stuName, strComparisonOp_StuName);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Politics) == true) {
            const strComparisonOp_id_Politics = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Politics];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Politics, objStudentInfo_Cond.id_Politics, strComparisonOp_id_Politics);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Sex) == true) {
            const strComparisonOp_id_Sex = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Sex];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Sex, objStudentInfo_Cond.id_Sex, strComparisonOp_id_Sex);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Ethnic) == true) {
            const strComparisonOp_id_Ethnic = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Ethnic];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_Ethnic, objStudentInfo_Cond.id_Ethnic, strComparisonOp_id_Ethnic);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_UniZone) == true) {
            const strComparisonOp_id_UniZone = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_UniZone];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_UniZone, objStudentInfo_Cond.id_UniZone, strComparisonOp_id_UniZone);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_StuType) == true) {
            const strComparisonOp_id_StuType = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_StuType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_StuType, objStudentInfo_Cond.id_StuType, strComparisonOp_id_StuType);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_XzCollege, objStudentInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_XzMajor, objStudentInfo_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_GradeBase) == true) {
            const strComparisonOp_id_GradeBase = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_GradeBase];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_GradeBase, objStudentInfo_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_AdminCls) == true) {
            const strComparisonOp_id_AdminCls = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_AdminCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_id_AdminCls, objStudentInfo_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_Birthday) == true) {
            const strComparisonOp_Birthday = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_Birthday];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_Birthday, objStudentInfo_Cond.birthday, strComparisonOp_Birthday);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_NativePlace) == true) {
            const strComparisonOp_NativePlace = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_NativePlace];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_NativePlace, objStudentInfo_Cond.nativePlace, strComparisonOp_NativePlace);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_Duty) == true) {
            const strComparisonOp_Duty = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_Duty];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_Duty, objStudentInfo_Cond.duty, strComparisonOp_Duty);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_IDCardNo) == true) {
            const strComparisonOp_IDCardNo = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_IDCardNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_IDCardNo, objStudentInfo_Cond.idCardNo, strComparisonOp_IDCardNo);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuCardNo) == true) {
            const strComparisonOp_StuCardNo = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuCardNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_StuCardNo, objStudentInfo_Cond.stuCardNo, strComparisonOp_StuCardNo);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_LiveAddress) == true) {
            const strComparisonOp_LiveAddress = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_LiveAddress];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_LiveAddress, objStudentInfo_Cond.liveAddress, strComparisonOp_LiveAddress);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_HomePhone) == true) {
            const strComparisonOp_HomePhone = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_HomePhone];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_HomePhone, objStudentInfo_Cond.homePhone, strComparisonOp_HomePhone);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_Id_CardNo) == true) {
            const strComparisonOp_Id_CardNo = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_Id_CardNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_Id_CardNo, objStudentInfo_Cond.id_CardNo, strComparisonOp_Id_CardNo);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_CardNo) == true) {
            const strComparisonOp_CardNo = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_CardNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_CardNo, objStudentInfo_Cond.cardNo, strComparisonOp_CardNo);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsAvconClassUser) == true) {
            if (objStudentInfo_Cond.isAvconClassUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsAvconClassUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsAvconClassUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsAvconUser) == true) {
            if (objStudentInfo_Cond.isAvconUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsAvconUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsAvconUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsGpUser) == true) {
            if (objStudentInfo_Cond.isGpUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsGpUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsGpUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsLocalUser) == true) {
            if (objStudentInfo_Cond.isLocalUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsLocalUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsLocalUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsLeaved) == true) {
            if (objStudentInfo_Cond.isLeaved == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsLeaved);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsLeaved);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_UserId) == true) {
            const strComparisonOp_UserId = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_UserId, objStudentInfo_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_UserID4Avcon) == true) {
            const strComparisonOp_UserID4Avcon = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_UserID4Avcon];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_UserID4Avcon, objStudentInfo_Cond.userID4Avcon, strComparisonOp_UserID4Avcon);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_EnrollmentDate) == true) {
            const strComparisonOp_EnrollmentDate = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_EnrollmentDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_EnrollmentDate, objStudentInfo_Cond.enrollmentDate, strComparisonOp_EnrollmentDate);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_PostCode) == true) {
            const strComparisonOp_PostCode = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_PostCode];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_PostCode, objStudentInfo_Cond.postCode, strComparisonOp_PostCode);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_Email) == true) {
            const strComparisonOp_Email = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_Email];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_Email, objStudentInfo_Cond.email, strComparisonOp_Email);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsMessage) == true) {
            if (objStudentInfo_Cond.isMessage == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsMessage);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_IsMessage);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_Microblog) == true) {
            const strComparisonOp_Microblog = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_Microblog];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_Microblog, objStudentInfo_Cond.microblog, strComparisonOp_Microblog);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_PhoneNumber) == true) {
            const strComparisonOp_PhoneNumber = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_PhoneNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_PhoneNumber, objStudentInfo_Cond.phoneNumber, strComparisonOp_PhoneNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_Headphoto) == true) {
            const strComparisonOp_Headphoto = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_Headphoto];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_Headphoto, objStudentInfo_Cond.headphoto, strComparisonOp_Headphoto);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_QQ) == true) {
            const strComparisonOp_QQ = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_QQ];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_QQ, objStudentInfo_Cond.qQ, strComparisonOp_QQ);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_RegisterPassword) == true) {
            const strComparisonOp_RegisterPassword = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_RegisterPassword];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_RegisterPassword, objStudentInfo_Cond.registerPassword, strComparisonOp_RegisterPassword);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_UpdDate, objStudentInfo_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_UpdUser, objStudentInfo_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN_js_1.clsStudentInfoEN.con_Memo) == true) {
            const strComparisonOp_Memo = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN_js_1.clsStudentInfoEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsStudentInfoEN_js_1.clsStudentInfoEN.con_Memo, objStudentInfo_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.StudentInfo_GetCombineCondition = StudentInfo_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--StudentInfo(学生),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strStuID: 学号(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function StudentInfo_GetUniCondStr_StuID(objStudentInfoEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and StuID = '{0}'", objStudentInfoEN.stuID);
        return strWhereCond;
    }
    exports.StudentInfo_GetUniCondStr_StuID = StudentInfo_GetUniCondStr_StuID;
    /**
    *获取唯一性条件串(Uniqueness)--StudentInfo(学生),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strStuID: 学号(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function StudentInfo_GetUniCondStr4Update_StuID(objStudentInfoEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and id_StudentInfo <> '{0}'", objStudentInfoEN.id_StudentInfo);
        strWhereCond += (0, clsString_js_1.Format)(" and StuID = '{0}'", objStudentInfoEN.stuID);
        return strWhereCond;
    }
    exports.StudentInfo_GetUniCondStr4Update_StuID = StudentInfo_GetUniCondStr4Update_StuID;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objStudentInfoENS:源对象
     * @param objStudentInfoENT:目标对象
    */
    function StudentInfo_CopyObjTo(objStudentInfoENS, objStudentInfoENT) {
        objStudentInfoENT.id_StudentInfo = objStudentInfoENS.id_StudentInfo; //学生流水号
        objStudentInfoENT.stuID = objStudentInfoENS.stuID; //学号
        objStudentInfoENT.stuName = objStudentInfoENS.stuName; //姓名
        objStudentInfoENT.id_Politics = objStudentInfoENS.id_Politics; //政治面貌流水号
        objStudentInfoENT.id_Sex = objStudentInfoENS.id_Sex; //性别流水号
        objStudentInfoENT.id_Ethnic = objStudentInfoENS.id_Ethnic; //民族流水号
        objStudentInfoENT.id_UniZone = objStudentInfoENS.id_UniZone; //校区流水号
        objStudentInfoENT.id_StuType = objStudentInfoENS.id_StuType; //学生类别流水号
        objStudentInfoENT.id_XzCollege = objStudentInfoENS.id_XzCollege; //学院流水号
        objStudentInfoENT.id_XzMajor = objStudentInfoENS.id_XzMajor; //专业流水号
        objStudentInfoENT.id_GradeBase = objStudentInfoENS.id_GradeBase; //年级流水号
        objStudentInfoENT.id_AdminCls = objStudentInfoENS.id_AdminCls; //行政班流水号
        objStudentInfoENT.birthday = objStudentInfoENS.birthday; //出生日期
        objStudentInfoENT.nativePlace = objStudentInfoENS.nativePlace; //籍贯
        objStudentInfoENT.duty = objStudentInfoENS.duty; //职位
        objStudentInfoENT.idCardNo = objStudentInfoENS.idCardNo; //身份证号
        objStudentInfoENT.stuCardNo = objStudentInfoENS.stuCardNo; //学生证号
        objStudentInfoENT.liveAddress = objStudentInfoENS.liveAddress; //居住地址
        objStudentInfoENT.homePhone = objStudentInfoENS.homePhone; //住宅电话
        objStudentInfoENT.id_CardNo = objStudentInfoENS.id_CardNo; //内卡号
        objStudentInfoENT.cardNo = objStudentInfoENS.cardNo; //卡号
        objStudentInfoENT.isAvconClassUser = objStudentInfoENS.isAvconClassUser; //IsAvconClassUser
        objStudentInfoENT.isAvconUser = objStudentInfoENS.isAvconUser; //IsAvconUser
        objStudentInfoENT.isGpUser = objStudentInfoENS.isGpUser; //是否Gp用户
        objStudentInfoENT.isLocalUser = objStudentInfoENS.isLocalUser; //是否本地用户
        objStudentInfoENT.isLeaved = objStudentInfoENS.isLeaved; //IsLeaved
        objStudentInfoENT.userId = objStudentInfoENS.userId; //用户ID
        objStudentInfoENT.userID4Avcon = objStudentInfoENS.userID4Avcon; //UserID4Avcon
        objStudentInfoENT.enrollmentDate = objStudentInfoENS.enrollmentDate; //入校日期
        objStudentInfoENT.postCode = objStudentInfoENS.postCode; //邮编
        objStudentInfoENT.email = objStudentInfoENS.email; //电子邮箱
        objStudentInfoENT.isMessage = objStudentInfoENS.isMessage; //IsMessage
        objStudentInfoENT.microblog = objStudentInfoENS.microblog; //Microblog
        objStudentInfoENT.phoneNumber = objStudentInfoENS.phoneNumber; //PhoneNumber
        objStudentInfoENT.headphoto = objStudentInfoENS.headphoto; //Headphoto
        objStudentInfoENT.qQ = objStudentInfoENS.qQ; //QQ
        objStudentInfoENT.registerPassword = objStudentInfoENS.registerPassword; //RegisterPassword
        objStudentInfoENT.updDate = objStudentInfoENS.updDate; //修改日期
        objStudentInfoENT.updUser = objStudentInfoENS.updUser; //修改人
        objStudentInfoENT.memo = objStudentInfoENS.memo; //备注
        objStudentInfoENT.sf_UpdFldSetStr = objStudentInfoENS.updFldString; //sf_UpdFldSetStr
    }
    exports.StudentInfo_CopyObjTo = StudentInfo_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objStudentInfoENS:源对象
     * @param objStudentInfoENT:目标对象
    */
    function StudentInfo_GetObjFromJsonObj(objStudentInfoENS) {
        const objStudentInfoENT = new clsStudentInfoEN_js_1.clsStudentInfoEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objStudentInfoENT, objStudentInfoENS);
        return objStudentInfoENT;
    }
    exports.StudentInfo_GetObjFromJsonObj = StudentInfo_GetObjFromJsonObj;
});
