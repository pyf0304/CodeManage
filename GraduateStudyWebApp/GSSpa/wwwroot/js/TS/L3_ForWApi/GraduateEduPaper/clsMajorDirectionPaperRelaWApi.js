/**
* 类名:clsMajorDirectionPaperRelaWApi
* 表名:MajorDirectionPaperRela(01120554)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:42
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培论文(GraduateEduPaper)
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.MajorDirectionPaperRela_GetObjFromJsonObj = exports.MajorDirectionPaperRela_CopyObjTo = exports.MajorDirectionPaperRela_GetUniCondStr4Update_MajorDirectionId_PaperId = exports.MajorDirectionPaperRela_GetUniCondStr_MajorDirectionId_PaperId = exports.MajorDirectionPaperRela_GetCombineCondition = exports.MajorDirectionPaperRela_GetObjByJSONStr = exports.MajorDirectionPaperRela_GetObjLstByJSONObjLst = exports.MajorDirectionPaperRela_GetObjLstByJSONStr = exports.MajorDirectionPaperRela_GetJSONStrByObj = exports.MajorDirectionPaperRela_CheckProperty4Update = exports.MajorDirectionPaperRela_CheckPropertyNew = exports.MajorDirectionPaperRela_GetWebApiUrl = exports.MajorDirectionPaperRela_GetMaxStrIdByPrefix = exports.MajorDirectionPaperRela_GetRecCountByCondAsync = exports.MajorDirectionPaperRela_IsExistAsync = exports.MajorDirectionPaperRela_IsExist = exports.MajorDirectionPaperRela_IsExistRecordAsync = exports.MajorDirectionPaperRela_UpdateWithConditionAsync = exports.MajorDirectionPaperRela_UpdateRecordAsync = exports.MajorDirectionPaperRela_AddNewRecordWithReturnKey = exports.MajorDirectionPaperRela_AddNewRecordWithReturnKeyAsync = exports.MajorDirectionPaperRela_AddNewRecordAsync = exports.MajorDirectionPaperRela_DelMajorDirectionPaperRelasByCondAsync = exports.MajorDirectionPaperRela_DelMajorDirectionPaperRelasAsync = exports.MajorDirectionPaperRela_DelRecordAsync = exports.MajorDirectionPaperRela_GetObjLstByPagerAsync = exports.MajorDirectionPaperRela_GetObjLstByRange = exports.MajorDirectionPaperRela_GetObjLstByRangeAsync = exports.MajorDirectionPaperRela_GetTopObjLstAsync = exports.MajorDirectionPaperRela_GetObjLstBymIdLstAsync = exports.MajorDirectionPaperRela_GetObjLstAsync = exports.MajorDirectionPaperRela_GetFirstObjAsync = exports.MajorDirectionPaperRela_GetFirstID = exports.MajorDirectionPaperRela_GetFirstIDAsync = exports.MajorDirectionPaperRela_FilterFunByKey = exports.MajorDirectionPaperRela_SortFunByKey = exports.MajorDirectionPaperRela_SortFun_Defa_2Fld = exports.MajorDirectionPaperRela_SortFun_Defa = exports.MajorDirectionPaperRela_GetObjBymIdAsync = exports.majorDirectionPaperRela_ConstructorName = exports.majorDirectionPaperRela_Controller = void 0;
    /**
     * 专业方向论文关系(MajorDirectionPaperRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsMajorDirectionPaperRelaEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.majorDirectionPaperRela_Controller = "MajorDirectionPaperRelaApi";
    exports.majorDirectionPaperRela_ConstructorName = "majorDirectionPaperRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function MajorDirectionPaperRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objMajorDirectionPaperRela = MajorDirectionPaperRela_GetObjFromJsonObj(returnObj);
                return objMajorDirectionPaperRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_GetObjBymIdAsync = MajorDirectionPaperRela_GetObjBymIdAsync;
    //该表在前台TypeScript中，不需要使用Cache;
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
    function MajorDirectionPaperRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.MajorDirectionPaperRela_SortFun_Defa = MajorDirectionPaperRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function MajorDirectionPaperRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.majorDirectionId == b.majorDirectionId)
            return a.paperId.localeCompare(b.paperId);
        else
            return a.majorDirectionId.localeCompare(b.majorDirectionId);
    }
    exports.MajorDirectionPaperRela_SortFun_Defa_2Fld = MajorDirectionPaperRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function MajorDirectionPaperRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_MajorDirectionId:
                    return (a, b) => {
                        return a.majorDirectionId.localeCompare(b.majorDirectionId);
                    };
                case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[MajorDirectionPaperRela]中不存在！(in ${exports.majorDirectionPaperRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_MajorDirectionId:
                    return (a, b) => {
                        return b.majorDirectionId.localeCompare(a.majorDirectionId);
                    };
                case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[MajorDirectionPaperRela]中不存在！(in ${exports.majorDirectionPaperRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.MajorDirectionPaperRela_SortFunByKey = MajorDirectionPaperRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function MajorDirectionPaperRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_MajorDirectionId:
                return (obj) => {
                    return obj.majorDirectionId === value;
                };
            case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[MajorDirectionPaperRela]中不存在！(in ${exports.majorDirectionPaperRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.MajorDirectionPaperRela_FilterFunByKey = MajorDirectionPaperRela_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function MajorDirectionPaperRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_GetFirstIDAsync = MajorDirectionPaperRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function MajorDirectionPaperRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_GetFirstID = MajorDirectionPaperRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function MajorDirectionPaperRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objMajorDirectionPaperRela = MajorDirectionPaperRela_GetObjFromJsonObj(returnObj);
                return objMajorDirectionPaperRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_GetFirstObjAsync = MajorDirectionPaperRela_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function MajorDirectionPaperRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = MajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_GetObjLstAsync = MajorDirectionPaperRela_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function MajorDirectionPaperRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = MajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_GetObjLstBymIdLstAsync = MajorDirectionPaperRela_GetObjLstBymIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function MajorDirectionPaperRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = MajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_GetTopObjLstAsync = MajorDirectionPaperRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function MajorDirectionPaperRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = MajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_GetObjLstByRangeAsync = MajorDirectionPaperRela_GetObjLstByRangeAsync;
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
    async function MajorDirectionPaperRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_GetObjLstByRange = MajorDirectionPaperRela_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function MajorDirectionPaperRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = MajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_GetObjLstByPagerAsync = MajorDirectionPaperRela_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function MajorDirectionPaperRela_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngmId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngmId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_DelRecordAsync = MajorDirectionPaperRela_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function MajorDirectionPaperRela_DelMajorDirectionPaperRelasAsync(arrmId) {
        const strThisFuncName = "DelMajorDirectionPaperRelasAsync";
        const strAction = "DelMajorDirectionPaperRelas";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_DelMajorDirectionPaperRelasAsync = MajorDirectionPaperRela_DelMajorDirectionPaperRelasAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function MajorDirectionPaperRela_DelMajorDirectionPaperRelasByCondAsync(strWhereCond) {
        const strThisFuncName = "DelMajorDirectionPaperRelasByCondAsync";
        const strAction = "DelMajorDirectionPaperRelasByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_DelMajorDirectionPaperRelasByCondAsync = MajorDirectionPaperRela_DelMajorDirectionPaperRelasByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objMajorDirectionPaperRelaEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function MajorDirectionPaperRela_AddNewRecordAsync(objMajorDirectionPaperRelaEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objMajorDirectionPaperRelaEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objMajorDirectionPaperRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_AddNewRecordAsync = MajorDirectionPaperRela_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objMajorDirectionPaperRelaEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function MajorDirectionPaperRela_AddNewRecordWithReturnKeyAsync(objMajorDirectionPaperRelaEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objMajorDirectionPaperRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_AddNewRecordWithReturnKeyAsync = MajorDirectionPaperRela_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objMajorDirectionPaperRelaEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function MajorDirectionPaperRela_AddNewRecordWithReturnKey(objMajorDirectionPaperRelaEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objMajorDirectionPaperRelaEN.mId === null || objMajorDirectionPaperRelaEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objMajorDirectionPaperRelaEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_AddNewRecordWithReturnKey = MajorDirectionPaperRela_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objMajorDirectionPaperRelaEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function MajorDirectionPaperRela_UpdateRecordAsync(objMajorDirectionPaperRelaEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objMajorDirectionPaperRelaEN.sf_UpdFldSetStr === undefined || objMajorDirectionPaperRelaEN.sf_UpdFldSetStr === null || objMajorDirectionPaperRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objMajorDirectionPaperRelaEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objMajorDirectionPaperRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_UpdateRecordAsync = MajorDirectionPaperRela_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objMajorDirectionPaperRelaEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function MajorDirectionPaperRela_UpdateWithConditionAsync(objMajorDirectionPaperRelaEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objMajorDirectionPaperRelaEN.sf_UpdFldSetStr === undefined || objMajorDirectionPaperRelaEN.sf_UpdFldSetStr === null || objMajorDirectionPaperRelaEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objMajorDirectionPaperRelaEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
        objMajorDirectionPaperRelaEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objMajorDirectionPaperRelaEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_UpdateWithConditionAsync = MajorDirectionPaperRela_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function MajorDirectionPaperRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_IsExistRecordAsync = MajorDirectionPaperRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function MajorDirectionPaperRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_IsExist = MajorDirectionPaperRela_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function MajorDirectionPaperRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_IsExistAsync = MajorDirectionPaperRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function MajorDirectionPaperRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_GetRecCountByCondAsync = MajorDirectionPaperRela_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
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
    async function MajorDirectionPaperRela_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.majorDirectionPaperRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.majorDirectionPaperRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.MajorDirectionPaperRela_GetMaxStrIdByPrefix = MajorDirectionPaperRela_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function MajorDirectionPaperRela_GetWebApiUrl(strController, strAction) {
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
    exports.MajorDirectionPaperRela_GetWebApiUrl = MajorDirectionPaperRela_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function MajorDirectionPaperRela_CheckPropertyNew(pobjMajorDirectionPaperRelaEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.updUser) === true) {
            throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 专业方向论文关系)!(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.majorDirectionId) == false && (0, clsString_js_1.GetStrLen)(pobjMajorDirectionPaperRelaEN.majorDirectionId) > 8) {
            throw new Error("(errid:Watl000059)字段[研究方向Id(majorDirectionId)]的长度不能超过8(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.majorDirectionId)(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjMajorDirectionPaperRelaEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.paperId)(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjMajorDirectionPaperRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.updDate)(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjMajorDirectionPaperRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.updUser)(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjMajorDirectionPaperRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.memo)(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjMajorDirectionPaperRelaEN.mId && undefined !== pobjMajorDirectionPaperRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjMajorDirectionPaperRelaEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjMajorDirectionPaperRelaEN.mId)], 非法，应该为数值型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.majorDirectionId) == false && undefined !== pobjMajorDirectionPaperRelaEN.majorDirectionId && jsString_js_1.tzDataType.isString(pobjMajorDirectionPaperRelaEN.majorDirectionId) === false) {
            throw new Error("(errid:Watl000060)字段[研究方向Id(majorDirectionId)]的值:[$(pobjMajorDirectionPaperRelaEN.majorDirectionId)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.paperId) == false && undefined !== pobjMajorDirectionPaperRelaEN.paperId && jsString_js_1.tzDataType.isString(pobjMajorDirectionPaperRelaEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjMajorDirectionPaperRelaEN.paperId)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.updDate) == false && undefined !== pobjMajorDirectionPaperRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjMajorDirectionPaperRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjMajorDirectionPaperRelaEN.updDate)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.updUser) == false && undefined !== pobjMajorDirectionPaperRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjMajorDirectionPaperRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjMajorDirectionPaperRelaEN.updUser)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.memo) == false && undefined !== pobjMajorDirectionPaperRelaEN.memo && jsString_js_1.tzDataType.isString(pobjMajorDirectionPaperRelaEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjMajorDirectionPaperRelaEN.memo)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjMajorDirectionPaperRelaEN.SetIsCheckProperty(true);
    }
    exports.MajorDirectionPaperRela_CheckPropertyNew = MajorDirectionPaperRela_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function MajorDirectionPaperRela_CheckProperty4Update(pobjMajorDirectionPaperRelaEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.majorDirectionId) == false && (0, clsString_js_1.GetStrLen)(pobjMajorDirectionPaperRelaEN.majorDirectionId) > 8) {
            throw new Error("(errid:Watl000062)字段[研究方向Id(majorDirectionId)]的长度不能超过8(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.majorDirectionId)(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjMajorDirectionPaperRelaEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.paperId)(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjMajorDirectionPaperRelaEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.updDate)(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjMajorDirectionPaperRelaEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.updUser)(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjMajorDirectionPaperRelaEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.memo)(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjMajorDirectionPaperRelaEN.mId && undefined !== pobjMajorDirectionPaperRelaEN.mId && jsString_js_1.tzDataType.isNumber(pobjMajorDirectionPaperRelaEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjMajorDirectionPaperRelaEN.mId)], 非法，应该为数值型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.majorDirectionId) == false && undefined !== pobjMajorDirectionPaperRelaEN.majorDirectionId && jsString_js_1.tzDataType.isString(pobjMajorDirectionPaperRelaEN.majorDirectionId) === false) {
            throw new Error("(errid:Watl000063)字段[研究方向Id(majorDirectionId)]的值:[$(pobjMajorDirectionPaperRelaEN.majorDirectionId)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.paperId) == false && undefined !== pobjMajorDirectionPaperRelaEN.paperId && jsString_js_1.tzDataType.isString(pobjMajorDirectionPaperRelaEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjMajorDirectionPaperRelaEN.paperId)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.updDate) == false && undefined !== pobjMajorDirectionPaperRelaEN.updDate && jsString_js_1.tzDataType.isString(pobjMajorDirectionPaperRelaEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjMajorDirectionPaperRelaEN.updDate)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.updUser) == false && undefined !== pobjMajorDirectionPaperRelaEN.updUser && jsString_js_1.tzDataType.isString(pobjMajorDirectionPaperRelaEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjMajorDirectionPaperRelaEN.updUser)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjMajorDirectionPaperRelaEN.memo) == false && undefined !== pobjMajorDirectionPaperRelaEN.memo && jsString_js_1.tzDataType.isString(pobjMajorDirectionPaperRelaEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjMajorDirectionPaperRelaEN.memo)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjMajorDirectionPaperRelaEN.mId
            || pobjMajorDirectionPaperRelaEN.mId != null && pobjMajorDirectionPaperRelaEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 专业方向论文关系)!(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjMajorDirectionPaperRelaEN.SetIsCheckProperty(true);
    }
    exports.MajorDirectionPaperRela_CheckProperty4Update = MajorDirectionPaperRela_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function MajorDirectionPaperRela_GetJSONStrByObj(pobjMajorDirectionPaperRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjMajorDirectionPaperRelaEN.sf_UpdFldSetStr = pobjMajorDirectionPaperRelaEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjMajorDirectionPaperRelaEN);
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
    exports.MajorDirectionPaperRela_GetJSONStrByObj = MajorDirectionPaperRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function MajorDirectionPaperRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrMajorDirectionPaperRelaObjLst = new Array();
        if (strJSON === "") {
            return arrMajorDirectionPaperRelaObjLst;
        }
        try {
            arrMajorDirectionPaperRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrMajorDirectionPaperRelaObjLst;
        }
        return arrMajorDirectionPaperRelaObjLst;
    }
    exports.MajorDirectionPaperRela_GetObjLstByJSONStr = MajorDirectionPaperRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrMajorDirectionPaperRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function MajorDirectionPaperRela_GetObjLstByJSONObjLst(arrMajorDirectionPaperRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrMajorDirectionPaperRelaObjLst = new Array();
        for (const objInFor of arrMajorDirectionPaperRelaObjLstS) {
            const obj1 = MajorDirectionPaperRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrMajorDirectionPaperRelaObjLst.push(obj1);
        }
        return arrMajorDirectionPaperRelaObjLst;
    }
    exports.MajorDirectionPaperRela_GetObjLstByJSONObjLst = MajorDirectionPaperRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function MajorDirectionPaperRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjMajorDirectionPaperRelaEN = new clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN();
        if (strJSON === "") {
            return pobjMajorDirectionPaperRelaEN;
        }
        try {
            pobjMajorDirectionPaperRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjMajorDirectionPaperRelaEN;
        }
        return pobjMajorDirectionPaperRelaEN;
    }
    exports.MajorDirectionPaperRela_GetObjByJSONStr = MajorDirectionPaperRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function MajorDirectionPaperRela_GetCombineCondition(objMajorDirectionPaperRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_mId, objMajorDirectionPaperRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_MajorDirectionId) == true) {
            const strComparisonOp_MajorDirectionId = objMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_MajorDirectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_MajorDirectionId, objMajorDirectionPaperRela_Cond.majorDirectionId, strComparisonOp_MajorDirectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_PaperId, objMajorDirectionPaperRela_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_UpdDate, objMajorDirectionPaperRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_UpdUser, objMajorDirectionPaperRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.con_Memo, objMajorDirectionPaperRela_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.MajorDirectionPaperRela_GetCombineCondition = MajorDirectionPaperRela_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--MajorDirectionPaperRela(专业方向论文关系),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strMajorDirectionId: 研究方向Id(要求唯一的字段)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function MajorDirectionPaperRela_GetUniCondStr_MajorDirectionId_PaperId(objMajorDirectionPaperRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and MajorDirectionId = '{0}'", objMajorDirectionPaperRelaEN.majorDirectionId);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperId = '{0}'", objMajorDirectionPaperRelaEN.paperId);
        return strWhereCond;
    }
    exports.MajorDirectionPaperRela_GetUniCondStr_MajorDirectionId_PaperId = MajorDirectionPaperRela_GetUniCondStr_MajorDirectionId_PaperId;
    /**
    *获取唯一性条件串(Uniqueness)--MajorDirectionPaperRela(专业方向论文关系),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strMajorDirectionId: 研究方向Id(要求唯一的字段)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function MajorDirectionPaperRela_GetUniCondStr4Update_MajorDirectionId_PaperId(objMajorDirectionPaperRelaEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objMajorDirectionPaperRelaEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and MajorDirectionId = '{0}'", objMajorDirectionPaperRelaEN.majorDirectionId);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperId = '{0}'", objMajorDirectionPaperRelaEN.paperId);
        return strWhereCond;
    }
    exports.MajorDirectionPaperRela_GetUniCondStr4Update_MajorDirectionId_PaperId = MajorDirectionPaperRela_GetUniCondStr4Update_MajorDirectionId_PaperId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objMajorDirectionPaperRelaENS:源对象
     * @param objMajorDirectionPaperRelaENT:目标对象
    */
    function MajorDirectionPaperRela_CopyObjTo(objMajorDirectionPaperRelaENS, objMajorDirectionPaperRelaENT) {
        objMajorDirectionPaperRelaENT.mId = objMajorDirectionPaperRelaENS.mId; //mId
        objMajorDirectionPaperRelaENT.majorDirectionId = objMajorDirectionPaperRelaENS.majorDirectionId; //研究方向Id
        objMajorDirectionPaperRelaENT.paperId = objMajorDirectionPaperRelaENS.paperId; //论文Id
        objMajorDirectionPaperRelaENT.updDate = objMajorDirectionPaperRelaENS.updDate; //修改日期
        objMajorDirectionPaperRelaENT.updUser = objMajorDirectionPaperRelaENS.updUser; //修改人
        objMajorDirectionPaperRelaENT.memo = objMajorDirectionPaperRelaENS.memo; //备注
        objMajorDirectionPaperRelaENT.sf_UpdFldSetStr = objMajorDirectionPaperRelaENS.updFldString; //sf_UpdFldSetStr
    }
    exports.MajorDirectionPaperRela_CopyObjTo = MajorDirectionPaperRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objMajorDirectionPaperRelaENS:源对象
     * @param objMajorDirectionPaperRelaENT:目标对象
    */
    function MajorDirectionPaperRela_GetObjFromJsonObj(objMajorDirectionPaperRelaENS) {
        const objMajorDirectionPaperRelaENT = new clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objMajorDirectionPaperRelaENT, objMajorDirectionPaperRelaENS);
        return objMajorDirectionPaperRelaENT;
    }
    exports.MajorDirectionPaperRela_GetObjFromJsonObj = MajorDirectionPaperRela_GetObjFromJsonObj;
});
