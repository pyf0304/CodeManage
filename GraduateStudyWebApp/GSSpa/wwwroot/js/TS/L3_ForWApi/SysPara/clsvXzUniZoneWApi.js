/**
* 类名:clsvXzUniZoneWApi
* 表名:vXzUniZone(01120332)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:21
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
        define(["require", "exports", "axios", "../../L0_Entity/SysPara/clsvXzUniZoneEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vXzUniZone_GetObjFromJsonObj = exports.vXzUniZone_CopyObjTo = exports.vXzUniZone_GetCombineCondition = exports.vXzUniZone_GetObjByJSONStr = exports.vXzUniZone_GetObjLstByJSONObjLst = exports.vXzUniZone_GetObjLstByJSONStr = exports.vXzUniZone_GetJSONStrByObj = exports.vXzUniZone_GetWebApiUrl = exports.vXzUniZone_GetRecCountByCondAsync = exports.vXzUniZone_IsExistAsync = exports.vXzUniZone_IsExist = exports.vXzUniZone_IsExistRecordAsync = exports.vXzUniZone_GetObjLstByPagerAsync = exports.vXzUniZone_GetObjLstByRange = exports.vXzUniZone_GetObjLstByRangeAsync = exports.vXzUniZone_GetTopObjLstAsync = exports.vXzUniZone_GetObjLstByid_UniZoneLstAsync = exports.vXzUniZone_GetObjLstAsync = exports.vXzUniZone_GetFirstObjAsync = exports.vXzUniZone_GetFirstID = exports.vXzUniZone_GetFirstIDAsync = exports.vXzUniZone_FilterFunByKey = exports.vXzUniZone_SortFunByKey = exports.vXzUniZone_SortFun_Defa_2Fld = exports.vXzUniZone_SortFun_Defa = exports.vXzUniZone_GetObjByid_UniZoneAsync = exports.vXzUniZone_ConstructorName = exports.vXzUniZone_Controller = void 0;
    /**
     * v校区(vXzUniZone)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvXzUniZoneEN_js_1 = require("../../L0_Entity/SysPara/clsvXzUniZoneEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vXzUniZone_Controller = "vXzUniZoneApi";
    exports.vXzUniZone_ConstructorName = "vXzUniZone";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_UniZone:关键字
    * @returns 对象
    **/
    async function vXzUniZone_GetObjByid_UniZoneAsync(strid_UniZone) {
        const strThisFuncName = "GetObjByid_UniZoneAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_UniZone) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_UniZone]不能为空！(In GetObjByid_UniZoneAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_UniZone.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_UniZone]的长度:[{0}]不正确！", strid_UniZone.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_UniZone";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzUniZone_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_UniZone": strid_UniZone,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzUniZone_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvXzUniZone = vXzUniZone_GetObjFromJsonObj(returnObj);
                return objvXzUniZone;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzUniZone_GetObjByid_UniZoneAsync = vXzUniZone_GetObjByid_UniZoneAsync;
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
    function vXzUniZone_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_UniZone.localeCompare(b.id_UniZone);
    }
    exports.vXzUniZone_SortFun_Defa = vXzUniZone_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vXzUniZone_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.uniZoneID == b.uniZoneID)
            return a.uniZoneDesc.localeCompare(b.uniZoneDesc);
        else
            return a.uniZoneID.localeCompare(b.uniZoneID);
    }
    exports.vXzUniZone_SortFun_Defa_2Fld = vXzUniZone_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vXzUniZone_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_UniZone:
                    return (a, b) => {
                        return a.id_UniZone.localeCompare(b.id_UniZone);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneID:
                    return (a, b) => {
                        return a.uniZoneID.localeCompare(b.uniZoneID);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneDesc:
                    return (a, b) => {
                        return a.uniZoneDesc.localeCompare(b.uniZoneDesc);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneDescA:
                    return (a, b) => {
                        return a.uniZoneDescA.localeCompare(b.uniZoneDescA);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_School:
                    return (a, b) => {
                        return a.id_School.localeCompare(b.id_School);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolId:
                    return (a, b) => {
                        return a.schoolId.localeCompare(b.schoolId);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolName:
                    return (a, b) => {
                        return a.schoolName.localeCompare(b.schoolName);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolNameA:
                    return (a, b) => {
                        return a.schoolNameA.localeCompare(b.schoolNameA);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_Uni:
                    return (a, b) => {
                        return a.id_Uni.localeCompare(b.id_Uni);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_ModifyDate:
                    return (a, b) => {
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_ModifyUserID:
                    return (a, b) => {
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vXzUniZone]中不存在！(in ${exports.vXzUniZone_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_UniZone:
                    return (a, b) => {
                        return b.id_UniZone.localeCompare(a.id_UniZone);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneID:
                    return (a, b) => {
                        return b.uniZoneID.localeCompare(a.uniZoneID);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneDesc:
                    return (a, b) => {
                        return b.uniZoneDesc.localeCompare(a.uniZoneDesc);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneDescA:
                    return (a, b) => {
                        return b.uniZoneDescA.localeCompare(a.uniZoneDescA);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_School:
                    return (a, b) => {
                        return b.id_School.localeCompare(a.id_School);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolId:
                    return (a, b) => {
                        return b.schoolId.localeCompare(a.schoolId);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolName:
                    return (a, b) => {
                        return b.schoolName.localeCompare(a.schoolName);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolNameA:
                    return (a, b) => {
                        return b.schoolNameA.localeCompare(a.schoolNameA);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_Uni:
                    return (a, b) => {
                        return b.id_Uni.localeCompare(a.id_Uni);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_ModifyDate:
                    return (a, b) => {
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_ModifyUserID:
                    return (a, b) => {
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vXzUniZone]中不存在！(in ${exports.vXzUniZone_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vXzUniZone_SortFunByKey = vXzUniZone_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vXzUniZone_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_UniZone:
                return (obj) => {
                    return obj.id_UniZone === value;
                };
            case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneID:
                return (obj) => {
                    return obj.uniZoneID === value;
                };
            case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneDesc:
                return (obj) => {
                    return obj.uniZoneDesc === value;
                };
            case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneDescA:
                return (obj) => {
                    return obj.uniZoneDescA === value;
                };
            case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_School:
                return (obj) => {
                    return obj.id_School === value;
                };
            case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolId:
                return (obj) => {
                    return obj.schoolId === value;
                };
            case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolName:
                return (obj) => {
                    return obj.schoolName === value;
                };
            case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolNameA:
                return (obj) => {
                    return obj.schoolNameA === value;
                };
            case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_Uni:
                return (obj) => {
                    return obj.id_Uni === value;
                };
            case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vXzUniZone]中不存在！(in ${exports.vXzUniZone_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vXzUniZone_FilterFunByKey = vXzUniZone_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vXzUniZone_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzUniZone_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzUniZone_GetFirstIDAsync = vXzUniZone_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vXzUniZone_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzUniZone_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzUniZone_GetFirstID = vXzUniZone_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vXzUniZone_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzUniZone_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzUniZone_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvXzUniZone = vXzUniZone_GetObjFromJsonObj(returnObj);
                return objvXzUniZone;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzUniZone_GetFirstObjAsync = vXzUniZone_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vXzUniZone_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzUniZone_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzUniZone_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzUniZone_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzUniZone_GetObjLstAsync = vXzUniZone_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_UniZone:关键字列表
    * @returns 对象列表
    **/
    async function vXzUniZone_GetObjLstByid_UniZoneLstAsync(arrid_UniZone) {
        const strThisFuncName = "GetObjLstByid_UniZoneLstAsync";
        const strAction = "GetObjLstByid_UniZoneLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzUniZone_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_UniZone);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzUniZone_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzUniZone_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzUniZone_GetObjLstByid_UniZoneLstAsync = vXzUniZone_GetObjLstByid_UniZoneLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vXzUniZone_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzUniZone_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzUniZone_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzUniZone_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzUniZone_GetTopObjLstAsync = vXzUniZone_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vXzUniZone_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzUniZone_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzUniZone_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzUniZone_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzUniZone_GetObjLstByRangeAsync = vXzUniZone_GetObjLstByRangeAsync;
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
    async function vXzUniZone_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzUniZone_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzUniZone_GetObjLstByRange = vXzUniZone_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vXzUniZone_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzUniZone_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vXzUniZone_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vXzUniZone_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzUniZone_GetObjLstByPagerAsync = vXzUniZone_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vXzUniZone_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzUniZone_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzUniZone_IsExistRecordAsync = vXzUniZone_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_UniZone:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vXzUniZone_IsExist(strid_UniZone, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzUniZone_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_UniZone": strid_UniZone,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzUniZone_IsExist = vXzUniZone_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_UniZone:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vXzUniZone_IsExistAsync(strid_UniZone) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzUniZone_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_UniZone": strid_UniZone }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzUniZone_IsExistAsync = vXzUniZone_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vXzUniZone_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vXzUniZone_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vXzUniZone_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vXzUniZone_GetRecCountByCondAsync = vXzUniZone_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vXzUniZone_GetWebApiUrl(strController, strAction) {
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
    exports.vXzUniZone_GetWebApiUrl = vXzUniZone_GetWebApiUrl;
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
    function vXzUniZone_GetJSONStrByObj(pobjvXzUniZoneEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvXzUniZoneEN);
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
    exports.vXzUniZone_GetJSONStrByObj = vXzUniZone_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vXzUniZone_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvXzUniZoneObjLst = new Array();
        if (strJSON === "") {
            return arrvXzUniZoneObjLst;
        }
        try {
            arrvXzUniZoneObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvXzUniZoneObjLst;
        }
        return arrvXzUniZoneObjLst;
    }
    exports.vXzUniZone_GetObjLstByJSONStr = vXzUniZone_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvXzUniZoneObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vXzUniZone_GetObjLstByJSONObjLst(arrvXzUniZoneObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvXzUniZoneObjLst = new Array();
        for (const objInFor of arrvXzUniZoneObjLstS) {
            const obj1 = vXzUniZone_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvXzUniZoneObjLst.push(obj1);
        }
        return arrvXzUniZoneObjLst;
    }
    exports.vXzUniZone_GetObjLstByJSONObjLst = vXzUniZone_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vXzUniZone_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvXzUniZoneEN = new clsvXzUniZoneEN_js_1.clsvXzUniZoneEN();
        if (strJSON === "") {
            return pobjvXzUniZoneEN;
        }
        try {
            pobjvXzUniZoneEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvXzUniZoneEN;
        }
        return pobjvXzUniZoneEN;
    }
    exports.vXzUniZone_GetObjByJSONStr = vXzUniZone_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vXzUniZone_GetCombineCondition(objvXzUniZone_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_UniZone) == true) {
            const strComparisonOp_id_UniZone = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_UniZone];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_UniZone, objvXzUniZone_Cond.id_UniZone, strComparisonOp_id_UniZone);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneID) == true) {
            const strComparisonOp_UniZoneID = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneID, objvXzUniZone_Cond.uniZoneID, strComparisonOp_UniZoneID);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneDesc) == true) {
            const strComparisonOp_UniZoneDesc = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneDesc, objvXzUniZone_Cond.uniZoneDesc, strComparisonOp_UniZoneDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneDescA) == true) {
            const strComparisonOp_UniZoneDescA = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneDescA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_UniZoneDescA, objvXzUniZone_Cond.uniZoneDescA, strComparisonOp_UniZoneDescA);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_School) == true) {
            const strComparisonOp_id_School = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_School];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_School, objvXzUniZone_Cond.id_School, strComparisonOp_id_School);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolId) == true) {
            const strComparisonOp_SchoolId = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolId, objvXzUniZone_Cond.schoolId, strComparisonOp_SchoolId);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolName) == true) {
            const strComparisonOp_SchoolName = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolName, objvXzUniZone_Cond.schoolName, strComparisonOp_SchoolName);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolNameA) == true) {
            const strComparisonOp_SchoolNameA = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolNameA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_SchoolNameA, objvXzUniZone_Cond.schoolNameA, strComparisonOp_SchoolNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_Uni) == true) {
            const strComparisonOp_id_Uni = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_Uni];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_id_Uni, objvXzUniZone_Cond.id_Uni, strComparisonOp_id_Uni);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_ModifyDate, objvXzUniZone_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_ModifyUserID, objvXzUniZone_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objvXzUniZone_Cond.dicFldComparisonOp, clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvXzUniZone_Cond.dicFldComparisonOp[clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvXzUniZoneEN_js_1.clsvXzUniZoneEN.con_Memo, objvXzUniZone_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.vXzUniZone_GetCombineCondition = vXzUniZone_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvXzUniZoneENS:源对象
     * @param objvXzUniZoneENT:目标对象
    */
    function vXzUniZone_CopyObjTo(objvXzUniZoneENS, objvXzUniZoneENT) {
        objvXzUniZoneENT.id_UniZone = objvXzUniZoneENS.id_UniZone; //校区流水号
        objvXzUniZoneENT.uniZoneID = objvXzUniZoneENS.uniZoneID; //校区编号
        objvXzUniZoneENT.uniZoneDesc = objvXzUniZoneENS.uniZoneDesc; //校区名称
        objvXzUniZoneENT.uniZoneDescA = objvXzUniZoneENS.uniZoneDescA; //UniZoneDescA
        objvXzUniZoneENT.id_School = objvXzUniZoneENS.id_School; //学校流水号
        objvXzUniZoneENT.schoolId = objvXzUniZoneENS.schoolId; //学校编号
        objvXzUniZoneENT.schoolName = objvXzUniZoneENS.schoolName; //学校名称
        objvXzUniZoneENT.schoolNameA = objvXzUniZoneENS.schoolNameA; //学校简称
        objvXzUniZoneENT.id_Uni = objvXzUniZoneENS.id_Uni; //id_Uni
        objvXzUniZoneENT.modifyDate = objvXzUniZoneENS.modifyDate; //修改日期
        objvXzUniZoneENT.modifyUserID = objvXzUniZoneENS.modifyUserID; //修改人
        objvXzUniZoneENT.memo = objvXzUniZoneENS.memo; //备注
    }
    exports.vXzUniZone_CopyObjTo = vXzUniZone_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvXzUniZoneENS:源对象
     * @param objvXzUniZoneENT:目标对象
    */
    function vXzUniZone_GetObjFromJsonObj(objvXzUniZoneENS) {
        const objvXzUniZoneENT = new clsvXzUniZoneEN_js_1.clsvXzUniZoneEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvXzUniZoneENT, objvXzUniZoneENS);
        return objvXzUniZoneENT;
    }
    exports.vXzUniZone_GetObjFromJsonObj = vXzUniZone_GetObjFromJsonObj;
});
