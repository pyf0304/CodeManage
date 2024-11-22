/**
* 类名:clsSexWApi
* 表名:Sex(01120103)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:07
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
        define(["require", "exports", "axios", "../../L0_Entity/SysPara/clsSexEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Sex_GetObjFromJsonObj = exports.Sex_CopyObjTo = exports.Sex_GetCombineCondition = exports.Sex_GetObjByJSONStr = exports.Sex_GetObjLstByJSONObjLst = exports.Sex_GetObjLstByJSONStr = exports.Sex_GetJSONStrByObj = exports.Sex_CheckProperty4Update = exports.Sex_CheckPropertyNew = exports.Sex_GetWebApiUrl = exports.Sex_GetMaxStrIdByPrefix = exports.Sex_GetRecCountByCondAsync = exports.Sex_IsExistAsync = exports.Sex_IsExist = exports.Sex_IsExistRecordAsync = exports.Sex_UpdateWithConditionAsync = exports.Sex_UpdateRecordAsync = exports.Sex_AddNewRecordWithReturnKey = exports.Sex_AddNewRecordWithReturnKeyAsync = exports.Sex_AddNewRecordWithMaxIdAsync = exports.Sex_AddNewRecordAsync = exports.Sex_DelSexsByCondAsync = exports.Sex_DelSexsAsync = exports.Sex_DelRecordAsync = exports.Sex_GetObjLstByPagerAsync = exports.Sex_GetObjLstByRange = exports.Sex_GetObjLstByRangeAsync = exports.Sex_GetTopObjLstAsync = exports.Sex_GetObjLstByid_SexLstAsync = exports.Sex_GetObjLstAsync = exports.Sex_GetFirstObjAsync = exports.Sex_GetFirstID = exports.Sex_GetFirstIDAsync = exports.Sex_FilterFunByKey = exports.Sex_SortFunByKey = exports.Sex_SortFun_Defa_2Fld = exports.Sex_SortFun_Defa = exports.Sex_GetObjByid_SexAsync = exports.sex_ConstructorName = exports.sex_Controller = void 0;
    /**
     * 性别(Sex)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsSexEN_js_1 = require("../../L0_Entity/SysPara/clsSexEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.sex_Controller = "SexApi";
    exports.sex_ConstructorName = "sex";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_Sex:关键字
    * @returns 对象
    **/
    async function Sex_GetObjByid_SexAsync(strid_Sex) {
        const strThisFuncName = "GetObjByid_SexAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_Sex) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_Sex]不能为空！(In GetObjByid_SexAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_Sex.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_Sex]的长度:[{0}]不正确！", strid_Sex.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_Sex";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_Sex": strid_Sex,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sex_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objSex = Sex_GetObjFromJsonObj(returnObj);
                return objSex;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetObjByid_SexAsync = Sex_GetObjByid_SexAsync;
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
    function Sex_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_Sex.localeCompare(b.id_Sex);
    }
    exports.Sex_SortFun_Defa = Sex_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Sex_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.sexID == b.sexID)
            return a.sexDesc.localeCompare(b.sexDesc);
        else
            return a.sexID.localeCompare(b.sexID);
    }
    exports.Sex_SortFun_Defa_2Fld = Sex_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Sex_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSexEN_js_1.clsSexEN.con_id_Sex:
                    return (a, b) => {
                        return a.id_Sex.localeCompare(b.id_Sex);
                    };
                case clsSexEN_js_1.clsSexEN.con_SexID:
                    return (a, b) => {
                        return a.sexID.localeCompare(b.sexID);
                    };
                case clsSexEN_js_1.clsSexEN.con_SexDesc:
                    return (a, b) => {
                        return a.sexDesc.localeCompare(b.sexDesc);
                    };
                case clsSexEN_js_1.clsSexEN.con_SexDesc_EN:
                    return (a, b) => {
                        return a.sexDesc_EN.localeCompare(b.sexDesc_EN);
                    };
                case clsSexEN_js_1.clsSexEN.con_ModifyDate:
                    return (a, b) => {
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsSexEN_js_1.clsSexEN.con_ModifyUserID:
                    return (a, b) => {
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsSexEN_js_1.clsSexEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[Sex]中不存在！(in ${exports.sex_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSexEN_js_1.clsSexEN.con_id_Sex:
                    return (a, b) => {
                        return b.id_Sex.localeCompare(a.id_Sex);
                    };
                case clsSexEN_js_1.clsSexEN.con_SexID:
                    return (a, b) => {
                        return b.sexID.localeCompare(a.sexID);
                    };
                case clsSexEN_js_1.clsSexEN.con_SexDesc:
                    return (a, b) => {
                        return b.sexDesc.localeCompare(a.sexDesc);
                    };
                case clsSexEN_js_1.clsSexEN.con_SexDesc_EN:
                    return (a, b) => {
                        return b.sexDesc_EN.localeCompare(a.sexDesc_EN);
                    };
                case clsSexEN_js_1.clsSexEN.con_ModifyDate:
                    return (a, b) => {
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsSexEN_js_1.clsSexEN.con_ModifyUserID:
                    return (a, b) => {
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsSexEN_js_1.clsSexEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[Sex]中不存在！(in ${exports.sex_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.Sex_SortFunByKey = Sex_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function Sex_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSexEN_js_1.clsSexEN.con_id_Sex:
                return (obj) => {
                    return obj.id_Sex === value;
                };
            case clsSexEN_js_1.clsSexEN.con_SexID:
                return (obj) => {
                    return obj.sexID === value;
                };
            case clsSexEN_js_1.clsSexEN.con_SexDesc:
                return (obj) => {
                    return obj.sexDesc === value;
                };
            case clsSexEN_js_1.clsSexEN.con_SexDesc_EN:
                return (obj) => {
                    return obj.sexDesc_EN === value;
                };
            case clsSexEN_js_1.clsSexEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsSexEN_js_1.clsSexEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsSexEN_js_1.clsSexEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[Sex]中不存在！(in ${exports.sex_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.Sex_FilterFunByKey = Sex_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function Sex_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetFirstIDAsync = Sex_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function Sex_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetFirstID = Sex_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function Sex_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sex_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objSex = Sex_GetObjFromJsonObj(returnObj);
                return objSex;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetFirstObjAsync = Sex_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function Sex_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sex_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Sex_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetObjLstAsync = Sex_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_Sex:关键字列表
    * @returns 对象列表
    **/
    async function Sex_GetObjLstByid_SexLstAsync(arrid_Sex) {
        const strThisFuncName = "GetObjLstByid_SexLstAsync";
        const strAction = "GetObjLstByid_SexLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_Sex);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sex_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Sex_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetObjLstByid_SexLstAsync = Sex_GetObjLstByid_SexLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function Sex_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sex_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Sex_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetTopObjLstAsync = Sex_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function Sex_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sex_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Sex_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetObjLstByRangeAsync = Sex_GetObjLstByRangeAsync;
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
    async function Sex_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetObjLstByRange = Sex_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function Sex_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sex_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Sex_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetObjLstByPagerAsync = Sex_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strid_Sex:关键字
    * @returns 获取删除的结果
    **/
    async function Sex_DelRecordAsync(strid_Sex) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strid_Sex);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strid_Sex, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_DelRecordAsync = Sex_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_Sex:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function Sex_DelSexsAsync(arrid_Sex) {
        const strThisFuncName = "DelSexsAsync";
        const strAction = "DelSexs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_Sex);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_DelSexsAsync = Sex_DelSexsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function Sex_DelSexsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSexsByCondAsync";
        const strAction = "DelSexsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_DelSexsByCondAsync = Sex_DelSexsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSexEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Sex_AddNewRecordAsync(objSexEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objSexEN.id_Sex === null || objSexEN.id_Sex === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objSexEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSexEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_AddNewRecordAsync = Sex_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objSexEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Sex_AddNewRecordWithMaxIdAsync(objSexEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSexEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_AddNewRecordWithMaxIdAsync = Sex_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSexEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function Sex_AddNewRecordWithReturnKeyAsync(objSexEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSexEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_AddNewRecordWithReturnKeyAsync = Sex_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSexEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function Sex_AddNewRecordWithReturnKey(objSexEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSexEN.id_Sex === null || objSexEN.id_Sex === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSexEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_AddNewRecordWithReturnKey = Sex_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSexEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function Sex_UpdateRecordAsync(objSexEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSexEN.sf_UpdFldSetStr === undefined || objSexEN.sf_UpdFldSetStr === null || objSexEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSexEN.id_Sex);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSexEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_UpdateRecordAsync = Sex_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSexEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function Sex_UpdateWithConditionAsync(objSexEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSexEN.sf_UpdFldSetStr === undefined || objSexEN.sf_UpdFldSetStr === null || objSexEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSexEN.id_Sex);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        objSexEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSexEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_UpdateWithConditionAsync = Sex_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function Sex_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_IsExistRecordAsync = Sex_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_Sex:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function Sex_IsExist(strid_Sex, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_Sex": strid_Sex,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_IsExist = Sex_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_Sex:关键字
    * @returns 是否存在?存在返回True
    **/
    async function Sex_IsExistAsync(strid_Sex) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_Sex": strid_Sex }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_IsExistAsync = Sex_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function Sex_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetRecCountByCondAsync = Sex_GetRecCountByCondAsync;
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
    async function Sex_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sex_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sex_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Sex_GetMaxStrIdByPrefix = Sex_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function Sex_GetWebApiUrl(strController, strAction) {
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
    exports.Sex_GetWebApiUrl = Sex_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function Sex_CheckPropertyNew(pobjSexEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.id_Sex) == false && (0, clsString_js_1.GetStrLen)(pobjSexEN.id_Sex) > 4) {
            throw new Error("(errid:Watl000059)字段[性别流水号(id_Sex)]的长度不能超过4(In 性别(Sex))!值:$(pobjSexEN.id_Sex)(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.sexID) == false && (0, clsString_js_1.GetStrLen)(pobjSexEN.sexID) > 4) {
            throw new Error("(errid:Watl000059)字段[性别ID(sexID)]的长度不能超过4(In 性别(Sex))!值:$(pobjSexEN.sexID)(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.sexDesc) == false && (0, clsString_js_1.GetStrLen)(pobjSexEN.sexDesc) > 10) {
            throw new Error("(errid:Watl000059)字段[性别名称(sexDesc)]的长度不能超过10(In 性别(Sex))!值:$(pobjSexEN.sexDesc)(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.sexDesc_EN) == false && (0, clsString_js_1.GetStrLen)(pobjSexEN.sexDesc_EN) > 10) {
            throw new Error("(errid:Watl000059)字段[SexDesc_EN(sexDesc_EN)]的长度不能超过10(In 性别(Sex))!值:$(pobjSexEN.sexDesc_EN)(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.modifyDate) == false && (0, clsString_js_1.GetStrLen)(pobjSexEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 性别(Sex))!值:$(pobjSexEN.modifyDate)(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.modifyUserID) == false && (0, clsString_js_1.GetStrLen)(pobjSexEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 性别(Sex))!值:$(pobjSexEN.modifyUserID)(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjSexEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 性别(Sex))!值:$(pobjSexEN.memo)(clsSexBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.id_Sex) == false && undefined !== pobjSexEN.id_Sex && jsString_js_1.tzDataType.isString(pobjSexEN.id_Sex) === false) {
            throw new Error("(errid:Watl000060)字段[性别流水号(id_Sex)]的值:[$(pobjSexEN.id_Sex)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.sexID) == false && undefined !== pobjSexEN.sexID && jsString_js_1.tzDataType.isString(pobjSexEN.sexID) === false) {
            throw new Error("(errid:Watl000060)字段[性别ID(sexID)]的值:[$(pobjSexEN.sexID)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.sexDesc) == false && undefined !== pobjSexEN.sexDesc && jsString_js_1.tzDataType.isString(pobjSexEN.sexDesc) === false) {
            throw new Error("(errid:Watl000060)字段[性别名称(sexDesc)]的值:[$(pobjSexEN.sexDesc)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.sexDesc_EN) == false && undefined !== pobjSexEN.sexDesc_EN && jsString_js_1.tzDataType.isString(pobjSexEN.sexDesc_EN) === false) {
            throw new Error("(errid:Watl000060)字段[SexDesc_EN(sexDesc_EN)]的值:[$(pobjSexEN.sexDesc_EN)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.modifyDate) == false && undefined !== pobjSexEN.modifyDate && jsString_js_1.tzDataType.isString(pobjSexEN.modifyDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjSexEN.modifyDate)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.modifyUserID) == false && undefined !== pobjSexEN.modifyUserID && jsString_js_1.tzDataType.isString(pobjSexEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjSexEN.modifyUserID)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.memo) == false && undefined !== pobjSexEN.memo && jsString_js_1.tzDataType.isString(pobjSexEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSexEN.memo)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSexEN.SetIsCheckProperty(true);
    }
    exports.Sex_CheckPropertyNew = Sex_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function Sex_CheckProperty4Update(pobjSexEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.id_Sex) == false && (0, clsString_js_1.GetStrLen)(pobjSexEN.id_Sex) > 4) {
            throw new Error("(errid:Watl000062)字段[性别流水号(id_Sex)]的长度不能超过4(In 性别(Sex))!值:$(pobjSexEN.id_Sex)(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.sexID) == false && (0, clsString_js_1.GetStrLen)(pobjSexEN.sexID) > 4) {
            throw new Error("(errid:Watl000062)字段[性别ID(sexID)]的长度不能超过4(In 性别(Sex))!值:$(pobjSexEN.sexID)(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.sexDesc) == false && (0, clsString_js_1.GetStrLen)(pobjSexEN.sexDesc) > 10) {
            throw new Error("(errid:Watl000062)字段[性别名称(sexDesc)]的长度不能超过10(In 性别(Sex))!值:$(pobjSexEN.sexDesc)(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.sexDesc_EN) == false && (0, clsString_js_1.GetStrLen)(pobjSexEN.sexDesc_EN) > 10) {
            throw new Error("(errid:Watl000062)字段[SexDesc_EN(sexDesc_EN)]的长度不能超过10(In 性别(Sex))!值:$(pobjSexEN.sexDesc_EN)(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.modifyDate) == false && (0, clsString_js_1.GetStrLen)(pobjSexEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 性别(Sex))!值:$(pobjSexEN.modifyDate)(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.modifyUserID) == false && (0, clsString_js_1.GetStrLen)(pobjSexEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 性别(Sex))!值:$(pobjSexEN.modifyUserID)(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjSexEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 性别(Sex))!值:$(pobjSexEN.memo)(clsSexBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.id_Sex) == false && undefined !== pobjSexEN.id_Sex && jsString_js_1.tzDataType.isString(pobjSexEN.id_Sex) === false) {
            throw new Error("(errid:Watl000063)字段[性别流水号(id_Sex)]的值:[$(pobjSexEN.id_Sex)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.sexID) == false && undefined !== pobjSexEN.sexID && jsString_js_1.tzDataType.isString(pobjSexEN.sexID) === false) {
            throw new Error("(errid:Watl000063)字段[性别ID(sexID)]的值:[$(pobjSexEN.sexID)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.sexDesc) == false && undefined !== pobjSexEN.sexDesc && jsString_js_1.tzDataType.isString(pobjSexEN.sexDesc) === false) {
            throw new Error("(errid:Watl000063)字段[性别名称(sexDesc)]的值:[$(pobjSexEN.sexDesc)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.sexDesc_EN) == false && undefined !== pobjSexEN.sexDesc_EN && jsString_js_1.tzDataType.isString(pobjSexEN.sexDesc_EN) === false) {
            throw new Error("(errid:Watl000063)字段[SexDesc_EN(sexDesc_EN)]的值:[$(pobjSexEN.sexDesc_EN)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.modifyDate) == false && undefined !== pobjSexEN.modifyDate && jsString_js_1.tzDataType.isString(pobjSexEN.modifyDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjSexEN.modifyDate)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.modifyUserID) == false && undefined !== pobjSexEN.modifyUserID && jsString_js_1.tzDataType.isString(pobjSexEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjSexEN.modifyUserID)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.memo) == false && undefined !== pobjSexEN.memo && jsString_js_1.tzDataType.isString(pobjSexEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSexEN.memo)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSexEN.id_Sex) === true) {
            throw new Error("(errid:Watl000064)字段[性别流水号]不能为空(In 性别)!(clsSexBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSexEN.SetIsCheckProperty(true);
    }
    exports.Sex_CheckProperty4Update = Sex_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function Sex_GetJSONStrByObj(pobjSexEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSexEN.sf_UpdFldSetStr = pobjSexEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSexEN);
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
    exports.Sex_GetJSONStrByObj = Sex_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function Sex_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSexObjLst = new Array();
        if (strJSON === "") {
            return arrSexObjLst;
        }
        try {
            arrSexObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSexObjLst;
        }
        return arrSexObjLst;
    }
    exports.Sex_GetObjLstByJSONStr = Sex_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSexObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function Sex_GetObjLstByJSONObjLst(arrSexObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSexObjLst = new Array();
        for (const objInFor of arrSexObjLstS) {
            const obj1 = Sex_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSexObjLst.push(obj1);
        }
        return arrSexObjLst;
    }
    exports.Sex_GetObjLstByJSONObjLst = Sex_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function Sex_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSexEN = new clsSexEN_js_1.clsSexEN();
        if (strJSON === "") {
            return pobjSexEN;
        }
        try {
            pobjSexEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSexEN;
        }
        return pobjSexEN;
    }
    exports.Sex_GetObjByJSONStr = Sex_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function Sex_GetCombineCondition(objSex_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN_js_1.clsSexEN.con_id_Sex) == true) {
            const strComparisonOp_id_Sex = objSex_Cond.dicFldComparisonOp[clsSexEN_js_1.clsSexEN.con_id_Sex];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSexEN_js_1.clsSexEN.con_id_Sex, objSex_Cond.id_Sex, strComparisonOp_id_Sex);
        }
        if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN_js_1.clsSexEN.con_SexID) == true) {
            const strComparisonOp_SexID = objSex_Cond.dicFldComparisonOp[clsSexEN_js_1.clsSexEN.con_SexID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSexEN_js_1.clsSexEN.con_SexID, objSex_Cond.sexID, strComparisonOp_SexID);
        }
        if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN_js_1.clsSexEN.con_SexDesc) == true) {
            const strComparisonOp_SexDesc = objSex_Cond.dicFldComparisonOp[clsSexEN_js_1.clsSexEN.con_SexDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSexEN_js_1.clsSexEN.con_SexDesc, objSex_Cond.sexDesc, strComparisonOp_SexDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN_js_1.clsSexEN.con_SexDesc_EN) == true) {
            const strComparisonOp_SexDesc_EN = objSex_Cond.dicFldComparisonOp[clsSexEN_js_1.clsSexEN.con_SexDesc_EN];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSexEN_js_1.clsSexEN.con_SexDesc_EN, objSex_Cond.sexDesc_EN, strComparisonOp_SexDesc_EN);
        }
        if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN_js_1.clsSexEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objSex_Cond.dicFldComparisonOp[clsSexEN_js_1.clsSexEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSexEN_js_1.clsSexEN.con_ModifyDate, objSex_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN_js_1.clsSexEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objSex_Cond.dicFldComparisonOp[clsSexEN_js_1.clsSexEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSexEN_js_1.clsSexEN.con_ModifyUserID, objSex_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN_js_1.clsSexEN.con_Memo) == true) {
            const strComparisonOp_Memo = objSex_Cond.dicFldComparisonOp[clsSexEN_js_1.clsSexEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSexEN_js_1.clsSexEN.con_Memo, objSex_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.Sex_GetCombineCondition = Sex_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSexENS:源对象
     * @param objSexENT:目标对象
    */
    function Sex_CopyObjTo(objSexENS, objSexENT) {
        objSexENT.id_Sex = objSexENS.id_Sex; //性别流水号
        objSexENT.sexID = objSexENS.sexID; //性别ID
        objSexENT.sexDesc = objSexENS.sexDesc; //性别名称
        objSexENT.sexDesc_EN = objSexENS.sexDesc_EN; //SexDesc_EN
        objSexENT.modifyDate = objSexENS.modifyDate; //修改日期
        objSexENT.modifyUserID = objSexENS.modifyUserID; //修改人
        objSexENT.memo = objSexENS.memo; //备注
        objSexENT.sf_UpdFldSetStr = objSexENS.updFldString; //sf_UpdFldSetStr
    }
    exports.Sex_CopyObjTo = Sex_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSexENS:源对象
     * @param objSexENT:目标对象
    */
    function Sex_GetObjFromJsonObj(objSexENS) {
        const objSexENT = new clsSexEN_js_1.clsSexEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSexENT, objSexENS);
        return objSexENT;
    }
    exports.Sex_GetObjFromJsonObj = Sex_GetObjFromJsonObj;
});
