/**
* 类名:clsvXzGradeBaseWApi
* 表名:vXzGradeBase(01120130)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:19
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:系统参数(SysPara)
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
        define(["require", "exports", "axios", "../../L0_Entity/SysPara/clsvXzGradeBaseEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vXzGradeBase_GetObjFromJsonObj = exports.vXzGradeBase_CopyObjTo = exports.vXzGradeBase_GetCombineCondition = exports.vXzGradeBase_GetObjByJSONStr = exports.vXzGradeBase_GetObjLstByJSONObjLst = exports.vXzGradeBase_GetObjLstByJSONStr = exports.vXzGradeBase_GetJSONStrByObj = exports.vXzGradeBase_GetWebApiUrl = exports.vXzGradeBase_GetRecCountByCondAsync = exports.vXzGradeBase_IsExistAsync = exports.vXzGradeBase_IsExist = exports.vXzGradeBase_IsExistRecordAsync = exports.vXzGradeBase_GetObjLstByPagerAsync = exports.vXzGradeBase_GetObjLstByRange = exports.vXzGradeBase_GetObjLstByRangeAsync = exports.vXzGradeBase_GetTopObjLstAsync = exports.vXzGradeBase_GetObjLstByid_GradeBaseLstAsync = exports.vXzGradeBase_GetObjLstAsync = exports.vXzGradeBase_GetFirstObjAsync = exports.vXzGradeBase_GetFirstID = exports.vXzGradeBase_GetFirstIDAsync = exports.vXzGradeBase_FilterFunByKey = exports.vXzGradeBase_SortFunByKey = exports.vXzGradeBase_SortFun_Defa_2Fld = exports.vXzGradeBase_SortFun_Defa = exports.vXzGradeBase_GetObjByid_GradeBaseAsync = exports.vXzGradeBase_ConstructorName = exports.vXzGradeBase_Controller = void 0;
    /**
     * v年级(vXzGradeBase)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvXzGradeBaseEN_js_1 = require("../../L0_Entity/SysPara/clsvXzGradeBaseEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vXzGradeBase_Controller = "vXzGradeBaseApi";
    exports.vXzGradeBase_ConstructorName = "vXzGradeBase";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_GradeBase:关键字
    * @returns 对象
    **/
    async function vXzGradeBase_GetObjByid_GradeBaseAsync(strid_GradeBase) {
        const strThisFuncName = "GetObjByid_GradeBaseAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_GradeBase) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_GradeBase]不能为空！(In GetObjByid_GradeBaseAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_GradeBase.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_GradeBase]的长度:[{0}]不正确！", strid_GradeBase.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_GradeBase";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_GradeBase": strid_GradeBase,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzGradeBase_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvXzGradeBase = vXzGradeBase_GetObjFromJsonObj(returnObj);
                return objvXzGradeBase;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzGradeBase_GetObjByid_GradeBaseAsync = vXzGradeBase_GetObjByid_GradeBaseAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vXzGradeBase_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_GradeBase.localeCompare(b.id_GradeBase);
    }
    exports.vXzGradeBase_SortFun_Defa = vXzGradeBase_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vXzGradeBase_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.gradeBaseID == b.gradeBaseID)
            return a.gradeBaseName.localeCompare(b.gradeBaseName);
        else
            return a.gradeBaseID.localeCompare(b.gradeBaseID);
    }
    exports.vXzGradeBase_SortFun_Defa_2Fld = vXzGradeBase_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vXzGradeBase_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_id_GradeBase:
                    return (a, b) => {
                        return a.id_GradeBase.localeCompare(b.id_GradeBase);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseID:
                    return (a, b) => {
                        return a.gradeBaseID.localeCompare(b.gradeBaseID);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseName:
                    return (a, b) => {
                        return a.gradeBaseName.localeCompare(b.gradeBaseName);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseNameA:
                    return (a, b) => {
                        return a.gradeBaseNameA.localeCompare(b.gradeBaseNameA);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SchoolYear:
                    return (a, b) => {
                        return a.schoolYear.localeCompare(b.schoolYear);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SchoolTerm:
                    return (a, b) => {
                        return a.schoolTerm.localeCompare(b.schoolTerm);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_EnterSchoolDate:
                    return (a, b) => {
                        return a.enterSchoolDate.localeCompare(b.enterSchoolDate);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_CurrentTermSeq:
                    return (a, b) => {
                        return a.currentTermSeq - b.currentTermSeq;
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_ExecPlanTermIndex:
                    return (a, b) => {
                        return a.execPlanTermIndex - b.execPlanTermIndex;
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SetEPTermIndexDate:
                    return (a, b) => {
                        return a.setEPTermIndexDate.localeCompare(b.setEPTermIndexDate);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_IsOffed:
                    return (a, b) => {
                        if (a.isOffed == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeIndex:
                    return (a, b) => {
                        return a.gradeIndex - b.gradeIndex;
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_BeginYearMonth:
                    return (a, b) => {
                        return a.beginYearMonth.localeCompare(b.beginYearMonth);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_EndYearMonth:
                    return (a, b) => {
                        return a.endYearMonth.localeCompare(b.endYearMonth);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_AllowUpBaseInfo:
                    return (a, b) => {
                        if (a.allowUpBaseInfo == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_Prefix:
                    return (a, b) => {
                        return a.prefix.localeCompare(b.prefix);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_PointCalcVersionId:
                    return (a, b) => {
                        return a.pointCalcVersionId.localeCompare(b.pointCalcVersionId);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_ModifyUserID:
                    return (a, b) => {
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_ModifyDate:
                    return (a, b) => {
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_id_StudyLevel:
                    return (a, b) => {
                        return a.id_StudyLevel.localeCompare(b.id_StudyLevel);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_StudyLevelName:
                    return (a, b) => {
                        return a.studyLevelName.localeCompare(b.studyLevelName);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_IsVisible:
                    return (a, b) => {
                        if (a.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vXzGradeBase]中不存在！(in ${exports.vXzGradeBase_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_id_GradeBase:
                    return (a, b) => {
                        return b.id_GradeBase.localeCompare(a.id_GradeBase);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseID:
                    return (a, b) => {
                        return b.gradeBaseID.localeCompare(a.gradeBaseID);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseName:
                    return (a, b) => {
                        return b.gradeBaseName.localeCompare(a.gradeBaseName);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseNameA:
                    return (a, b) => {
                        return b.gradeBaseNameA.localeCompare(a.gradeBaseNameA);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SchoolYear:
                    return (a, b) => {
                        return b.schoolYear.localeCompare(a.schoolYear);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SchoolTerm:
                    return (a, b) => {
                        return b.schoolTerm.localeCompare(a.schoolTerm);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_EnterSchoolDate:
                    return (a, b) => {
                        return b.enterSchoolDate.localeCompare(a.enterSchoolDate);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_CurrentTermSeq:
                    return (a, b) => {
                        return b.currentTermSeq - a.currentTermSeq;
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_ExecPlanTermIndex:
                    return (a, b) => {
                        return b.execPlanTermIndex - a.execPlanTermIndex;
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SetEPTermIndexDate:
                    return (a, b) => {
                        return b.setEPTermIndexDate.localeCompare(a.setEPTermIndexDate);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_IsOffed:
                    return (a, b) => {
                        if (b.isOffed == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeIndex:
                    return (a, b) => {
                        return b.gradeIndex - a.gradeIndex;
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_BeginYearMonth:
                    return (a, b) => {
                        return b.beginYearMonth.localeCompare(a.beginYearMonth);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_EndYearMonth:
                    return (a, b) => {
                        return b.endYearMonth.localeCompare(a.endYearMonth);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_AllowUpBaseInfo:
                    return (a, b) => {
                        if (b.allowUpBaseInfo == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_Prefix:
                    return (a, b) => {
                        return b.prefix.localeCompare(a.prefix);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_PointCalcVersionId:
                    return (a, b) => {
                        return b.pointCalcVersionId.localeCompare(a.pointCalcVersionId);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_ModifyUserID:
                    return (a, b) => {
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_ModifyDate:
                    return (a, b) => {
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_id_StudyLevel:
                    return (a, b) => {
                        return b.id_StudyLevel.localeCompare(a.id_StudyLevel);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_StudyLevelName:
                    return (a, b) => {
                        return b.studyLevelName.localeCompare(a.studyLevelName);
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_IsVisible:
                    return (a, b) => {
                        if (b.isVisible == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vXzGradeBase]中不存在！(in ${exports.vXzGradeBase_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vXzGradeBase_SortFunByKey = vXzGradeBase_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vXzGradeBase_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_id_GradeBase:
                return (obj) => {
                    return obj.id_GradeBase === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseID:
                return (obj) => {
                    return obj.gradeBaseID === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseName:
                return (obj) => {
                    return obj.gradeBaseName === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseNameA:
                return (obj) => {
                    return obj.gradeBaseNameA === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SchoolYear:
                return (obj) => {
                    return obj.schoolYear === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SchoolTerm:
                return (obj) => {
                    return obj.schoolTerm === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_EnterSchoolDate:
                return (obj) => {
                    return obj.enterSchoolDate === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_CurrentTermSeq:
                return (obj) => {
                    return obj.currentTermSeq === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_ExecPlanTermIndex:
                return (obj) => {
                    return obj.execPlanTermIndex === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SetEPTermIndexDate:
                return (obj) => {
                    return obj.setEPTermIndexDate === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_IsOffed:
                return (obj) => {
                    return obj.isOffed === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeIndex:
                return (obj) => {
                    return obj.gradeIndex === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_BeginYearMonth:
                return (obj) => {
                    return obj.beginYearMonth === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_EndYearMonth:
                return (obj) => {
                    return obj.endYearMonth === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_AllowUpBaseInfo:
                return (obj) => {
                    return obj.allowUpBaseInfo === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_Prefix:
                return (obj) => {
                    return obj.prefix === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_PointCalcVersionId:
                return (obj) => {
                    return obj.pointCalcVersionId === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_id_StudyLevel:
                return (obj) => {
                    return obj.id_StudyLevel === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_StudyLevelName:
                return (obj) => {
                    return obj.studyLevelName === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_IsVisible:
                return (obj) => {
                    return obj.isVisible === value;
                };
            case clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vXzGradeBase]中不存在！(in ${exports.vXzGradeBase_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vXzGradeBase_FilterFunByKey = vXzGradeBase_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vXzGradeBase_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzGradeBase_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzGradeBase_GetFirstIDAsync = vXzGradeBase_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vXzGradeBase_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzGradeBase_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzGradeBase_GetFirstID = vXzGradeBase_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vXzGradeBase_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzGradeBase_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvXzGradeBase = vXzGradeBase_GetObjFromJsonObj(returnObj);
                return objvXzGradeBase;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzGradeBase_GetFirstObjAsync = vXzGradeBase_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vXzGradeBase_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzGradeBase_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzGradeBase_GetObjLstAsync = vXzGradeBase_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_GradeBase:关键字列表
    * @returns 对象列表
    **/
    async function vXzGradeBase_GetObjLstByid_GradeBaseLstAsync(arrid_GradeBase) {
        const strThisFuncName = "GetObjLstByid_GradeBaseLstAsync";
        const strAction = "GetObjLstByid_GradeBaseLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_GradeBase);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzGradeBase_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzGradeBase_GetObjLstByid_GradeBaseLstAsync = vXzGradeBase_GetObjLstByid_GradeBaseLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vXzGradeBase_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzGradeBase_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzGradeBase_GetTopObjLstAsync = vXzGradeBase_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vXzGradeBase_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzGradeBase_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzGradeBase_GetObjLstByRangeAsync = vXzGradeBase_GetObjLstByRangeAsync;
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
    async function vXzGradeBase_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzGradeBase_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzGradeBase_GetObjLstByRange = vXzGradeBase_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vXzGradeBase_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzGradeBase_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzGradeBase_GetObjLstByPagerAsync = vXzGradeBase_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vXzGradeBase_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzGradeBase_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzGradeBase_IsExistRecordAsync = vXzGradeBase_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_GradeBase:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vXzGradeBase_IsExist(strid_GradeBase, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_GradeBase": strid_GradeBase,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzGradeBase_IsExist = vXzGradeBase_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_GradeBase:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vXzGradeBase_IsExistAsync(strid_GradeBase) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzGradeBase_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_GradeBase": strid_GradeBase }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzGradeBase_IsExistAsync = vXzGradeBase_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vXzGradeBase_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzGradeBase_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzGradeBase_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzGradeBase_GetRecCountByCondAsync = vXzGradeBase_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vXzGradeBase_GetWebApiUrl(strController, strAction) {
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
    exports.vXzGradeBase_GetWebApiUrl = vXzGradeBase_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vXzGradeBase_GetJSONStrByObj(pobjvXzGradeBaseEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvXzGradeBaseEN);
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
    exports.vXzGradeBase_GetJSONStrByObj = vXzGradeBase_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vXzGradeBase_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvXzGradeBaseObjLst = new Array();
        if (strJSON === "") {
            return arrvXzGradeBaseObjLst;
        }
        try {
            arrvXzGradeBaseObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvXzGradeBaseObjLst;
        }
        return arrvXzGradeBaseObjLst;
    }
    exports.vXzGradeBase_GetObjLstByJSONStr = vXzGradeBase_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvXzGradeBaseObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vXzGradeBase_GetObjLstByJSONObjLst(arrvXzGradeBaseObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvXzGradeBaseObjLst = new Array();
        for (const objInFor of arrvXzGradeBaseObjLstS) {
            const obj1 = vXzGradeBase_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvXzGradeBaseObjLst.push(obj1);
        }
        return arrvXzGradeBaseObjLst;
    }
    exports.vXzGradeBase_GetObjLstByJSONObjLst = vXzGradeBase_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vXzGradeBase_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvXzGradeBaseEN = new clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN();
        if (strJSON === "") {
            return pobjvXzGradeBaseEN;
        }
        try {
            pobjvXzGradeBaseEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvXzGradeBaseEN;
        }
        return pobjvXzGradeBaseEN;
    }
    exports.vXzGradeBase_GetObjByJSONStr = vXzGradeBase_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vXzGradeBase_GetCombineCondition(objvXzGradeBase_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_id_GradeBase) == true) {
            const strComparisonOp_id_GradeBase = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_id_GradeBase];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_id_GradeBase, objvXzGradeBase_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseID) == true) {
            const strComparisonOp_GradeBaseID = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseID, objvXzGradeBase_Cond.gradeBaseID, strComparisonOp_GradeBaseID);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseName) == true) {
            const strComparisonOp_GradeBaseName = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseName, objvXzGradeBase_Cond.gradeBaseName, strComparisonOp_GradeBaseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseNameA) == true) {
            const strComparisonOp_GradeBaseNameA = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseNameA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeBaseNameA, objvXzGradeBase_Cond.gradeBaseNameA, strComparisonOp_GradeBaseNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SchoolYear) == true) {
            const strComparisonOp_SchoolYear = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SchoolYear];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SchoolYear, objvXzGradeBase_Cond.schoolYear, strComparisonOp_SchoolYear);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SchoolTerm) == true) {
            const strComparisonOp_SchoolTerm = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SchoolTerm];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SchoolTerm, objvXzGradeBase_Cond.schoolTerm, strComparisonOp_SchoolTerm);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_EnterSchoolDate) == true) {
            const strComparisonOp_EnterSchoolDate = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_EnterSchoolDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_EnterSchoolDate, objvXzGradeBase_Cond.enterSchoolDate, strComparisonOp_EnterSchoolDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_CurrentTermSeq) == true) {
            const strComparisonOp_CurrentTermSeq = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_CurrentTermSeq];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_CurrentTermSeq, objvXzGradeBase_Cond.currentTermSeq, strComparisonOp_CurrentTermSeq);
        }
        //数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SetEPTermIndexDate) == true) {
            const strComparisonOp_SetEPTermIndexDate = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SetEPTermIndexDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_SetEPTermIndexDate, objvXzGradeBase_Cond.setEPTermIndexDate, strComparisonOp_SetEPTermIndexDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_IsOffed) == true) {
            if (objvXzGradeBase_Cond.isOffed == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_IsOffed);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_IsOffed);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeIndex) == true) {
            const strComparisonOp_GradeIndex = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeIndex];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_GradeIndex, objvXzGradeBase_Cond.gradeIndex, strComparisonOp_GradeIndex);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_BeginYearMonth) == true) {
            const strComparisonOp_BeginYearMonth = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_BeginYearMonth];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_BeginYearMonth, objvXzGradeBase_Cond.beginYearMonth, strComparisonOp_BeginYearMonth);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_EndYearMonth) == true) {
            const strComparisonOp_EndYearMonth = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_EndYearMonth];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_EndYearMonth, objvXzGradeBase_Cond.endYearMonth, strComparisonOp_EndYearMonth);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_AllowUpBaseInfo) == true) {
            if (objvXzGradeBase_Cond.allowUpBaseInfo == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_AllowUpBaseInfo);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_AllowUpBaseInfo);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_Prefix) == true) {
            const strComparisonOp_Prefix = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_Prefix];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_Prefix, objvXzGradeBase_Cond.prefix, strComparisonOp_Prefix);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_PointCalcVersionId) == true) {
            const strComparisonOp_PointCalcVersionId = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_PointCalcVersionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_PointCalcVersionId, objvXzGradeBase_Cond.pointCalcVersionId, strComparisonOp_PointCalcVersionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_ModifyUserID, objvXzGradeBase_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_ModifyDate, objvXzGradeBase_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_id_StudyLevel) == true) {
            const strComparisonOp_id_StudyLevel = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_id_StudyLevel];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_id_StudyLevel, objvXzGradeBase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_StudyLevelName) == true) {
            const strComparisonOp_StudyLevelName = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_StudyLevelName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_StudyLevelName, objvXzGradeBase_Cond.studyLevelName, strComparisonOp_StudyLevelName);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_IsVisible) == true) {
            if (objvXzGradeBase_Cond.isVisible == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_IsVisible);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_IsVisible);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN.con_Memo, objvXzGradeBase_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.vXzGradeBase_GetCombineCondition = vXzGradeBase_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvXzGradeBaseENS:源对象
     * @param objvXzGradeBaseENT:目标对象
    */
    function vXzGradeBase_CopyObjTo(objvXzGradeBaseENS, objvXzGradeBaseENT) {
        objvXzGradeBaseENT.id_GradeBase = objvXzGradeBaseENS.id_GradeBase; //年级流水号
        objvXzGradeBaseENT.gradeBaseID = objvXzGradeBaseENS.gradeBaseID; //年级代号
        objvXzGradeBaseENT.gradeBaseName = objvXzGradeBaseENS.gradeBaseName; //年级名称
        objvXzGradeBaseENT.gradeBaseNameA = objvXzGradeBaseENS.gradeBaseNameA; //年级名称缩写
        objvXzGradeBaseENT.schoolYear = objvXzGradeBaseENS.schoolYear; //学年
        objvXzGradeBaseENT.schoolTerm = objvXzGradeBaseENS.schoolTerm; //学期
        objvXzGradeBaseENT.enterSchoolDate = objvXzGradeBaseENS.enterSchoolDate; //进校日期
        objvXzGradeBaseENT.currentTermSeq = objvXzGradeBaseENS.currentTermSeq; //当前学期
        objvXzGradeBaseENT.execPlanTermIndex = objvXzGradeBaseENS.execPlanTermIndex; //生成执行计划学期
        objvXzGradeBaseENT.setEPTermIndexDate = objvXzGradeBaseENS.setEPTermIndexDate; //设定执行计划学期日期
        objvXzGradeBaseENT.isOffed = objvXzGradeBaseENS.isOffed; //是否毕业
        objvXzGradeBaseENT.gradeIndex = objvXzGradeBaseENS.gradeIndex; //年级序号
        objvXzGradeBaseENT.beginYearMonth = objvXzGradeBaseENS.beginYearMonth; //开始年月
        objvXzGradeBaseENT.endYearMonth = objvXzGradeBaseENS.endYearMonth; //结束年月
        objvXzGradeBaseENT.allowUpBaseInfo = objvXzGradeBaseENS.allowUpBaseInfo; //允许修改基本信息
        objvXzGradeBaseENT.prefix = objvXzGradeBaseENS.prefix; //前缀
        objvXzGradeBaseENT.pointCalcVersionId = objvXzGradeBaseENS.pointCalcVersionId; //绩点计算版本Id
        objvXzGradeBaseENT.modifyUserID = objvXzGradeBaseENS.modifyUserID; //修改人
        objvXzGradeBaseENT.modifyDate = objvXzGradeBaseENS.modifyDate; //修改日期
        objvXzGradeBaseENT.id_StudyLevel = objvXzGradeBaseENS.id_StudyLevel; //id_StudyLevel
        objvXzGradeBaseENT.studyLevelName = objvXzGradeBaseENS.studyLevelName; //学段名称
        objvXzGradeBaseENT.isVisible = objvXzGradeBaseENS.isVisible; //是否显示
        objvXzGradeBaseENT.memo = objvXzGradeBaseENS.memo; //备注
    }
    exports.vXzGradeBase_CopyObjTo = vXzGradeBase_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvXzGradeBaseENS:源对象
     * @param objvXzGradeBaseENT:目标对象
    */
    function vXzGradeBase_GetObjFromJsonObj(objvXzGradeBaseENS) {
        const objvXzGradeBaseENT = new clsvXzGradeBaseEN_js_1.clsvXzGradeBaseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvXzGradeBaseENT, objvXzGradeBaseENS);
        return objvXzGradeBaseENT;
    }
    exports.vXzGradeBase_GetObjFromJsonObj = vXzGradeBase_GetObjFromJsonObj;
});
