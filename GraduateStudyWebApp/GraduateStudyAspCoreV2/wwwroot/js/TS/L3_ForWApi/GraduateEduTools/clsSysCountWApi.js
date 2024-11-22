/**
* 类名:clsSysCountWApi
* 表名:SysCount(01120625)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/15 23:44:00
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培设置(GraduateEduTools)
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTools/clsSysCountEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysCount_GetObjFromJsonObj = exports.SysCount_CopyObjTo = exports.SysCount_GetUniCondStr4Update_CountTypeId_TableKey = exports.SysCount_GetUniCondStr_CountTypeId_TableKey = exports.SysCount_GetCombineCondition = exports.SysCount_GetObjByJSONStr = exports.SysCount_GetObjLstByJSONObjLst = exports.SysCount_GetObjLstByJSONStr = exports.SysCount_GetJSONStrByObj = exports.SysCount_CheckProperty4Update = exports.SysCount_CheckPropertyNew = exports.SysCount_GetWebApiUrl = exports.SysCount_GetMaxStrIdByPrefix = exports.SysCount_GetMaxStrIdAsync = exports.SysCount_GetRecCountByCondAsync = exports.SysCount_IsExistAsync = exports.SysCount_IsExist = exports.SysCount_IsExistRecordAsync = exports.SysCount_UpdateWithConditionAsync = exports.SysCount_UpdateRecordAsync = exports.SysCount_AddNewRecordWithReturnKey = exports.SysCount_AddNewRecordWithReturnKeyAsync = exports.SysCount_AddNewRecordWithMaxIdAsync = exports.SysCount_AddNewRecordAsync = exports.SysCount_DelSysCountsByCondAsync = exports.SysCount_DelSysCountsAsync = exports.SysCount_DelRecordAsync = exports.SysCount_GetObjLstByPagerAsync = exports.SysCount_GetObjLstByRange = exports.SysCount_GetObjLstByRangeAsync = exports.SysCount_GetTopObjLstAsync = exports.SysCount_GetObjLstByCountIdLstAsync = exports.SysCount_GetObjLstAsync = exports.SysCount_GetFirstObjAsync = exports.SysCount_GetFirstID = exports.SysCount_GetFirstIDAsync = exports.SysCount_FilterFunByKey = exports.SysCount_SortFunByKey = exports.SysCount_SortFun_Defa_2Fld = exports.SysCount_SortFun_Defa = exports.SysCount_GetObjByCountIdAsync = exports.sysCount_ConstructorName = exports.sysCount_Controller = void 0;
    /**
     * 统计数据(SysCount)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月15日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsSysCountEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsSysCountEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.sysCount_Controller = "SysCountApi";
    exports.sysCount_ConstructorName = "sysCount";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCountId:关键字
    * @returns 对象
    **/
    async function SysCount_GetObjByCountIdAsync(strCountId) {
        const strThisFuncName = "GetObjByCountIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCountId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCountId]不能为空！(In clsSysCountWApi.GetObjByCountIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCountId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCountId]的长度:[{0}]不正确！(clsSysCountWApi.GetObjByCountIdAsync)", strCountId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByCountId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strCountId": strCountId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objSysCount = SysCount_GetObjFromJsonObj(returnObj);
                return objSysCount;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_GetObjByCountIdAsync = SysCount_GetObjByCountIdAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysCount_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.countId.localeCompare(b.countId);
    }
    exports.SysCount_SortFun_Defa = SysCount_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysCount_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.countTypeId == b.countTypeId)
            return a.paperRWCount - b.paperRWCount;
        else
            return a.countTypeId.localeCompare(b.countTypeId);
    }
    exports.SysCount_SortFun_Defa_2Fld = SysCount_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysCount_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSysCountEN_js_1.clsSysCountEN.con_CountId:
                    return (a, b) => {
                        return a.countId.localeCompare(b.countId);
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_CountTypeId:
                    return (a, b) => {
                        if (a.countTypeId == null)
                            return -1;
                        if (b.countTypeId == null)
                            return 1;
                        return a.countTypeId.localeCompare(b.countTypeId);
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_PaperRWCount:
                    return (a, b) => {
                        return a.paperRWCount - b.paperRWCount;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_CollectionCount:
                    return (a, b) => {
                        return a.collectionCount - b.collectionCount;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_DownloadCount:
                    return (a, b) => {
                        return a.downloadCount - b.downloadCount;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_AttachmentCount:
                    return (a, b) => {
                        return a.attachmentCount - b.attachmentCount;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_CommentCount:
                    return (a, b) => {
                        return a.commentCount - b.commentCount;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_TableKey:
                    return (a, b) => {
                        if (a.tableKey == null)
                            return -1;
                        if (b.tableKey == null)
                            return 1;
                        return a.tableKey.localeCompare(b.tableKey);
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_ParentId:
                    return (a, b) => {
                        if (a.parentId == null)
                            return -1;
                        if (b.parentId == null)
                            return 1;
                        return a.parentId.localeCompare(b.parentId);
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysCount]中不存在！(in ${exports.sysCount_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSysCountEN_js_1.clsSysCountEN.con_CountId:
                    return (a, b) => {
                        return b.countId.localeCompare(a.countId);
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_CountTypeId:
                    return (a, b) => {
                        if (b.countTypeId == null)
                            return -1;
                        if (a.countTypeId == null)
                            return 1;
                        return b.countTypeId.localeCompare(a.countTypeId);
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_PaperRWCount:
                    return (a, b) => {
                        return b.paperRWCount - a.paperRWCount;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_CollectionCount:
                    return (a, b) => {
                        return b.collectionCount - a.collectionCount;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_DownloadCount:
                    return (a, b) => {
                        return b.downloadCount - a.downloadCount;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_AttachmentCount:
                    return (a, b) => {
                        return b.attachmentCount - a.attachmentCount;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_CommentCount:
                    return (a, b) => {
                        return b.commentCount - a.commentCount;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_TableKey:
                    return (a, b) => {
                        if (b.tableKey == null)
                            return -1;
                        if (a.tableKey == null)
                            return 1;
                        return b.tableKey.localeCompare(a.tableKey);
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_ParentId:
                    return (a, b) => {
                        if (b.parentId == null)
                            return -1;
                        if (a.parentId == null)
                            return 1;
                        return b.parentId.localeCompare(a.parentId);
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsSysCountEN_js_1.clsSysCountEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysCount]中不存在！(in ${exports.sysCount_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.SysCount_SortFunByKey = SysCount_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SysCount_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSysCountEN_js_1.clsSysCountEN.con_CountId:
                return (obj) => {
                    return obj.countId === value;
                };
            case clsSysCountEN_js_1.clsSysCountEN.con_CountTypeId:
                return (obj) => {
                    return obj.countTypeId === value;
                };
            case clsSysCountEN_js_1.clsSysCountEN.con_PaperRWCount:
                return (obj) => {
                    return obj.paperRWCount === value;
                };
            case clsSysCountEN_js_1.clsSysCountEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsSysCountEN_js_1.clsSysCountEN.con_CollectionCount:
                return (obj) => {
                    return obj.collectionCount === value;
                };
            case clsSysCountEN_js_1.clsSysCountEN.con_DownloadCount:
                return (obj) => {
                    return obj.downloadCount === value;
                };
            case clsSysCountEN_js_1.clsSysCountEN.con_AttachmentCount:
                return (obj) => {
                    return obj.attachmentCount === value;
                };
            case clsSysCountEN_js_1.clsSysCountEN.con_CommentCount:
                return (obj) => {
                    return obj.commentCount === value;
                };
            case clsSysCountEN_js_1.clsSysCountEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsSysCountEN_js_1.clsSysCountEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsSysCountEN_js_1.clsSysCountEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsSysCountEN_js_1.clsSysCountEN.con_TableKey:
                return (obj) => {
                    return obj.tableKey === value;
                };
            case clsSysCountEN_js_1.clsSysCountEN.con_ParentId:
                return (obj) => {
                    return obj.parentId === value;
                };
            case clsSysCountEN_js_1.clsSysCountEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsSysCountEN_js_1.clsSysCountEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsSysCountEN_js_1.clsSysCountEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[SysCount]中不存在！(in ${exports.sysCount_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.SysCount_FilterFunByKey = SysCount_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysCount_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_GetFirstIDAsync = SysCount_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function SysCount_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_GetFirstID = SysCount_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function SysCount_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
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
                const objSysCount = SysCount_GetObjFromJsonObj(returnObj);
                return objSysCount;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_GetFirstObjAsync = SysCount_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function SysCount_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_GetObjLstAsync = SysCount_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrCountId:关键字列表
    * @returns 对象列表
    **/
    async function SysCount_GetObjLstByCountIdLstAsync(arrCountId) {
        const strThisFuncName = "GetObjLstByCountIdLstAsync";
        const strAction = "GetObjLstByCountIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCountId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_GetObjLstByCountIdLstAsync = SysCount_GetObjLstByCountIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function SysCount_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_GetTopObjLstAsync = SysCount_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysCount_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_GetObjLstByRangeAsync = SysCount_GetObjLstByRangeAsync;
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
    async function SysCount_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_GetObjLstByRange = SysCount_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysCount_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_GetObjLstByPagerAsync = SysCount_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strCountId:关键字
    * @returns 获取删除的结果
    **/
    async function SysCount_DelRecordAsync(strCountId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strCountId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_DelRecordAsync = SysCount_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrCountId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function SysCount_DelSysCountsAsync(arrCountId) {
        const strThisFuncName = "DelSysCountsAsync";
        const strAction = "DelSysCounts";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCountId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_DelSysCountsAsync = SysCount_DelSysCountsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function SysCount_DelSysCountsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSysCountsByCondAsync";
        const strAction = "DelSysCountsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_DelSysCountsByCondAsync = SysCount_DelSysCountsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSysCountEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysCount_AddNewRecordAsync(objSysCountEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objSysCountEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysCountEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_AddNewRecordAsync = SysCount_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objSysCountEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysCount_AddNewRecordWithMaxIdAsync(objSysCountEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysCountEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_AddNewRecordWithMaxIdAsync = SysCount_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSysCountEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function SysCount_AddNewRecordWithReturnKeyAsync(objSysCountEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysCountEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_AddNewRecordWithReturnKeyAsync = SysCount_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSysCountEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function SysCount_AddNewRecordWithReturnKey(objSysCountEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSysCountEN.countId === null || objSysCountEN.countId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysCountEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_AddNewRecordWithReturnKey = SysCount_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSysCountEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function SysCount_UpdateRecordAsync(objSysCountEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSysCountEN.sf_UpdFldSetStr === undefined || objSysCountEN.sf_UpdFldSetStr === null || objSysCountEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysCountEN.countId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysCountEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_UpdateRecordAsync = SysCount_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSysCountEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysCount_UpdateWithConditionAsync(objSysCountEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSysCountEN.sf_UpdFldSetStr === undefined || objSysCountEN.sf_UpdFldSetStr === null || objSysCountEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysCountEN.countId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
        objSysCountEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSysCountEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_UpdateWithConditionAsync = SysCount_UpdateWithConditionAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function SysCount_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_IsExistRecordAsync = SysCount_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCountId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function SysCount_IsExist(strCountId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "CountId": strCountId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_IsExist = SysCount_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCountId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function SysCount_IsExistAsync(strCountId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strCountId": strCountId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_IsExistAsync = SysCount_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function SysCount_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_GetRecCountByCondAsync = SysCount_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function SysCount_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_GetMaxStrIdAsync = SysCount_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function SysCount_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCount_GetMaxStrIdByPrefix = SysCount_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function SysCount_GetWebApiUrl(strController, strAction) {
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
    exports.SysCount_GetWebApiUrl = SysCount_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysCount_CheckPropertyNew(pobjSysCountEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.countId) == false && (0, clsString_js_2.GetStrLen)(pobjSysCountEN.countId) > 10) {
            throw new Error("(errid:Watl000059)字段[CountId(countId)]的长度不能超过10(In 统计数据(SysCount))!值:$(pobjSysCountEN.countId)(clsSysCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.countTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjSysCountEN.countTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[CountTypeId(countTypeId)]的长度不能超过2(In 统计数据(SysCount))!值:$(pobjSysCountEN.countTypeId)(clsSysCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.tableKey) == false && (0, clsString_js_2.GetStrLen)(pobjSysCountEN.tableKey) > 20) {
            throw new Error("(errid:Watl000059)字段[表主键(tableKey)]的长度不能超过20(In 统计数据(SysCount))!值:$(pobjSysCountEN.tableKey)(clsSysCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.parentId) == false && (0, clsString_js_2.GetStrLen)(pobjSysCountEN.parentId) > 20) {
            throw new Error("(errid:Watl000059)字段[父Id(parentId)]的长度不能超过20(In 统计数据(SysCount))!值:$(pobjSysCountEN.parentId)(clsSysCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjSysCountEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 统计数据(SysCount))!值:$(pobjSysCountEN.updUser)(clsSysCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjSysCountEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 统计数据(SysCount))!值:$(pobjSysCountEN.updDate)(clsSysCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjSysCountEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 统计数据(SysCount))!值:$(pobjSysCountEN.memo)(clsSysCountBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.countId) == false && undefined !== pobjSysCountEN.countId && clsString_js_1.tzDataType.isString(pobjSysCountEN.countId) === false) {
            throw new Error("(errid:Watl000060)字段[CountId(countId)]的值:[$(pobjSysCountEN.countId)], 非法，应该为字符型(In 统计数据(SysCount))!(clsSysCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.countTypeId) == false && undefined !== pobjSysCountEN.countTypeId && clsString_js_1.tzDataType.isString(pobjSysCountEN.countTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[CountTypeId(countTypeId)]的值:[$(pobjSysCountEN.countTypeId)], 非法，应该为字符型(In 统计数据(SysCount))!(clsSysCountBL:CheckPropertyNew)");
        }
        if (null != pobjSysCountEN.paperRWCount && undefined !== pobjSysCountEN.paperRWCount && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.paperRWCount) === false) {
            throw new Error("(errid:Watl000060)字段[PaperRWCount(paperRWCount)]的值:[$(pobjSysCountEN.paperRWCount)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckPropertyNew)");
        }
        if (null != pobjSysCountEN.okCount && undefined !== pobjSysCountEN.okCount && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.okCount) === false) {
            throw new Error("(errid:Watl000060)字段[点赞统计(okCount)]的值:[$(pobjSysCountEN.okCount)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckPropertyNew)");
        }
        if (null != pobjSysCountEN.collectionCount && undefined !== pobjSysCountEN.collectionCount && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.collectionCount) === false) {
            throw new Error("(errid:Watl000060)字段[收藏数量(collectionCount)]的值:[$(pobjSysCountEN.collectionCount)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckPropertyNew)");
        }
        if (null != pobjSysCountEN.downloadCount && undefined !== pobjSysCountEN.downloadCount && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.downloadCount) === false) {
            throw new Error("(errid:Watl000060)字段[下载数(downloadCount)]的值:[$(pobjSysCountEN.downloadCount)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckPropertyNew)");
        }
        if (null != pobjSysCountEN.attachmentCount && undefined !== pobjSysCountEN.attachmentCount && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.attachmentCount) === false) {
            throw new Error("(errid:Watl000060)字段[附件计数(attachmentCount)]的值:[$(pobjSysCountEN.attachmentCount)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckPropertyNew)");
        }
        if (null != pobjSysCountEN.commentCount && undefined !== pobjSysCountEN.commentCount && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.commentCount) === false) {
            throw new Error("(errid:Watl000060)字段[评论数(commentCount)]的值:[$(pobjSysCountEN.commentCount)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckPropertyNew)");
        }
        if (null != pobjSysCountEN.score && undefined !== pobjSysCountEN.score && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.score) === false) {
            throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjSysCountEN.score)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckPropertyNew)");
        }
        if (null != pobjSysCountEN.stuScore && undefined !== pobjSysCountEN.stuScore && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.stuScore) === false) {
            throw new Error("(errid:Watl000060)字段[学生平均分(stuScore)]的值:[$(pobjSysCountEN.stuScore)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckPropertyNew)");
        }
        if (null != pobjSysCountEN.teaScore && undefined !== pobjSysCountEN.teaScore && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.teaScore) === false) {
            throw new Error("(errid:Watl000060)字段[教师评分(teaScore)]的值:[$(pobjSysCountEN.teaScore)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.tableKey) == false && undefined !== pobjSysCountEN.tableKey && clsString_js_1.tzDataType.isString(pobjSysCountEN.tableKey) === false) {
            throw new Error("(errid:Watl000060)字段[表主键(tableKey)]的值:[$(pobjSysCountEN.tableKey)], 非法，应该为字符型(In 统计数据(SysCount))!(clsSysCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.parentId) == false && undefined !== pobjSysCountEN.parentId && clsString_js_1.tzDataType.isString(pobjSysCountEN.parentId) === false) {
            throw new Error("(errid:Watl000060)字段[父Id(parentId)]的值:[$(pobjSysCountEN.parentId)], 非法，应该为字符型(In 统计数据(SysCount))!(clsSysCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.updUser) == false && undefined !== pobjSysCountEN.updUser && clsString_js_1.tzDataType.isString(pobjSysCountEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysCountEN.updUser)], 非法，应该为字符型(In 统计数据(SysCount))!(clsSysCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.updDate) == false && undefined !== pobjSysCountEN.updDate && clsString_js_1.tzDataType.isString(pobjSysCountEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysCountEN.updDate)], 非法，应该为字符型(In 统计数据(SysCount))!(clsSysCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.memo) == false && undefined !== pobjSysCountEN.memo && clsString_js_1.tzDataType.isString(pobjSysCountEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysCountEN.memo)], 非法，应该为字符型(In 统计数据(SysCount))!(clsSysCountBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSysCountEN.SetIsCheckProperty(true);
    }
    exports.SysCount_CheckPropertyNew = SysCount_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysCount_CheckProperty4Update(pobjSysCountEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.countId) == false && (0, clsString_js_2.GetStrLen)(pobjSysCountEN.countId) > 10) {
            throw new Error("(errid:Watl000062)字段[CountId(countId)]的长度不能超过10(In 统计数据(SysCount))!值:$(pobjSysCountEN.countId)(clsSysCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.countTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjSysCountEN.countTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[CountTypeId(countTypeId)]的长度不能超过2(In 统计数据(SysCount))!值:$(pobjSysCountEN.countTypeId)(clsSysCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.tableKey) == false && (0, clsString_js_2.GetStrLen)(pobjSysCountEN.tableKey) > 20) {
            throw new Error("(errid:Watl000062)字段[表主键(tableKey)]的长度不能超过20(In 统计数据(SysCount))!值:$(pobjSysCountEN.tableKey)(clsSysCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.parentId) == false && (0, clsString_js_2.GetStrLen)(pobjSysCountEN.parentId) > 20) {
            throw new Error("(errid:Watl000062)字段[父Id(parentId)]的长度不能超过20(In 统计数据(SysCount))!值:$(pobjSysCountEN.parentId)(clsSysCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjSysCountEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 统计数据(SysCount))!值:$(pobjSysCountEN.updUser)(clsSysCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjSysCountEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 统计数据(SysCount))!值:$(pobjSysCountEN.updDate)(clsSysCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjSysCountEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 统计数据(SysCount))!值:$(pobjSysCountEN.memo)(clsSysCountBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.countId) == false && undefined !== pobjSysCountEN.countId && clsString_js_1.tzDataType.isString(pobjSysCountEN.countId) === false) {
            throw new Error("(errid:Watl000063)字段[CountId(countId)]的值:[$(pobjSysCountEN.countId)], 非法，应该为字符型(In 统计数据(SysCount))!(clsSysCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.countTypeId) == false && undefined !== pobjSysCountEN.countTypeId && clsString_js_1.tzDataType.isString(pobjSysCountEN.countTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[CountTypeId(countTypeId)]的值:[$(pobjSysCountEN.countTypeId)], 非法，应该为字符型(In 统计数据(SysCount))!(clsSysCountBL:CheckProperty4Update)");
        }
        if (null != pobjSysCountEN.paperRWCount && undefined !== pobjSysCountEN.paperRWCount && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.paperRWCount) === false) {
            throw new Error("(errid:Watl000063)字段[PaperRWCount(paperRWCount)]的值:[$(pobjSysCountEN.paperRWCount)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckProperty4Update)");
        }
        if (null != pobjSysCountEN.okCount && undefined !== pobjSysCountEN.okCount && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.okCount) === false) {
            throw new Error("(errid:Watl000063)字段[点赞统计(okCount)]的值:[$(pobjSysCountEN.okCount)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckProperty4Update)");
        }
        if (null != pobjSysCountEN.collectionCount && undefined !== pobjSysCountEN.collectionCount && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.collectionCount) === false) {
            throw new Error("(errid:Watl000063)字段[收藏数量(collectionCount)]的值:[$(pobjSysCountEN.collectionCount)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckProperty4Update)");
        }
        if (null != pobjSysCountEN.downloadCount && undefined !== pobjSysCountEN.downloadCount && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.downloadCount) === false) {
            throw new Error("(errid:Watl000063)字段[下载数(downloadCount)]的值:[$(pobjSysCountEN.downloadCount)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckProperty4Update)");
        }
        if (null != pobjSysCountEN.attachmentCount && undefined !== pobjSysCountEN.attachmentCount && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.attachmentCount) === false) {
            throw new Error("(errid:Watl000063)字段[附件计数(attachmentCount)]的值:[$(pobjSysCountEN.attachmentCount)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckProperty4Update)");
        }
        if (null != pobjSysCountEN.commentCount && undefined !== pobjSysCountEN.commentCount && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.commentCount) === false) {
            throw new Error("(errid:Watl000063)字段[评论数(commentCount)]的值:[$(pobjSysCountEN.commentCount)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckProperty4Update)");
        }
        if (null != pobjSysCountEN.score && undefined !== pobjSysCountEN.score && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.score) === false) {
            throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjSysCountEN.score)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckProperty4Update)");
        }
        if (null != pobjSysCountEN.stuScore && undefined !== pobjSysCountEN.stuScore && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.stuScore) === false) {
            throw new Error("(errid:Watl000063)字段[学生平均分(stuScore)]的值:[$(pobjSysCountEN.stuScore)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckProperty4Update)");
        }
        if (null != pobjSysCountEN.teaScore && undefined !== pobjSysCountEN.teaScore && clsString_js_1.tzDataType.isNumber(pobjSysCountEN.teaScore) === false) {
            throw new Error("(errid:Watl000063)字段[教师评分(teaScore)]的值:[$(pobjSysCountEN.teaScore)], 非法，应该为数值型(In 统计数据(SysCount))!(clsSysCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.tableKey) == false && undefined !== pobjSysCountEN.tableKey && clsString_js_1.tzDataType.isString(pobjSysCountEN.tableKey) === false) {
            throw new Error("(errid:Watl000063)字段[表主键(tableKey)]的值:[$(pobjSysCountEN.tableKey)], 非法，应该为字符型(In 统计数据(SysCount))!(clsSysCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.parentId) == false && undefined !== pobjSysCountEN.parentId && clsString_js_1.tzDataType.isString(pobjSysCountEN.parentId) === false) {
            throw new Error("(errid:Watl000063)字段[父Id(parentId)]的值:[$(pobjSysCountEN.parentId)], 非法，应该为字符型(In 统计数据(SysCount))!(clsSysCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.updUser) == false && undefined !== pobjSysCountEN.updUser && clsString_js_1.tzDataType.isString(pobjSysCountEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysCountEN.updUser)], 非法，应该为字符型(In 统计数据(SysCount))!(clsSysCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.updDate) == false && undefined !== pobjSysCountEN.updDate && clsString_js_1.tzDataType.isString(pobjSysCountEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysCountEN.updDate)], 非法，应该为字符型(In 统计数据(SysCount))!(clsSysCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.memo) == false && undefined !== pobjSysCountEN.memo && clsString_js_1.tzDataType.isString(pobjSysCountEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysCountEN.memo)], 非法，应该为字符型(In 统计数据(SysCount))!(clsSysCountBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCountEN.countId) === true) {
            throw new Error("(errid:Watl000064)字段[CountId]不能为空(In 统计数据)!(clsSysCountBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSysCountEN.SetIsCheckProperty(true);
    }
    exports.SysCount_CheckProperty4Update = SysCount_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysCount_GetJSONStrByObj(pobjSysCountEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSysCountEN.sf_UpdFldSetStr = pobjSysCountEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSysCountEN);
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
    exports.SysCount_GetJSONStrByObj = SysCount_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function SysCount_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSysCountObjLst = new Array();
        if (strJSON === "") {
            return arrSysCountObjLst;
        }
        try {
            arrSysCountObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSysCountObjLst;
        }
        return arrSysCountObjLst;
    }
    exports.SysCount_GetObjLstByJSONStr = SysCount_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSysCountObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function SysCount_GetObjLstByJSONObjLst(arrSysCountObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSysCountObjLst = new Array();
        for (const objInFor of arrSysCountObjLstS) {
            const obj1 = SysCount_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSysCountObjLst.push(obj1);
        }
        return arrSysCountObjLst;
    }
    exports.SysCount_GetObjLstByJSONObjLst = SysCount_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysCount_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSysCountEN = new clsSysCountEN_js_1.clsSysCountEN();
        if (strJSON === "") {
            return pobjSysCountEN;
        }
        try {
            pobjSysCountEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSysCountEN;
        }
        return pobjSysCountEN;
    }
    exports.SysCount_GetObjByJSONStr = SysCount_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function SysCount_GetCombineCondition(objSysCount_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSysCount_Cond.dicFldComparisonOp, clsSysCountEN_js_1.clsSysCountEN.con_CountId) == true) {
            const strComparisonOp_CountId = objSysCount_Cond.dicFldComparisonOp[clsSysCountEN_js_1.clsSysCountEN.con_CountId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCountEN_js_1.clsSysCountEN.con_CountId, objSysCount_Cond.countId, strComparisonOp_CountId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysCount_Cond.dicFldComparisonOp, clsSysCountEN_js_1.clsSysCountEN.con_CountTypeId) == true) {
            const strComparisonOp_CountTypeId = objSysCount_Cond.dicFldComparisonOp[clsSysCountEN_js_1.clsSysCountEN.con_CountTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCountEN_js_1.clsSysCountEN.con_CountTypeId, objSysCount_Cond.countTypeId, strComparisonOp_CountTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysCount_Cond.dicFldComparisonOp, clsSysCountEN_js_1.clsSysCountEN.con_PaperRWCount) == true) {
            const strComparisonOp_PaperRWCount = objSysCount_Cond.dicFldComparisonOp[clsSysCountEN_js_1.clsSysCountEN.con_PaperRWCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysCountEN_js_1.clsSysCountEN.con_PaperRWCount, objSysCount_Cond.paperRWCount, strComparisonOp_PaperRWCount);
        }
        if (Object.prototype.hasOwnProperty.call(objSysCount_Cond.dicFldComparisonOp, clsSysCountEN_js_1.clsSysCountEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objSysCount_Cond.dicFldComparisonOp[clsSysCountEN_js_1.clsSysCountEN.con_OkCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysCountEN_js_1.clsSysCountEN.con_OkCount, objSysCount_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objSysCount_Cond.dicFldComparisonOp, clsSysCountEN_js_1.clsSysCountEN.con_CollectionCount) == true) {
            const strComparisonOp_CollectionCount = objSysCount_Cond.dicFldComparisonOp[clsSysCountEN_js_1.clsSysCountEN.con_CollectionCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysCountEN_js_1.clsSysCountEN.con_CollectionCount, objSysCount_Cond.collectionCount, strComparisonOp_CollectionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objSysCount_Cond.dicFldComparisonOp, clsSysCountEN_js_1.clsSysCountEN.con_DownloadCount) == true) {
            const strComparisonOp_DownloadCount = objSysCount_Cond.dicFldComparisonOp[clsSysCountEN_js_1.clsSysCountEN.con_DownloadCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysCountEN_js_1.clsSysCountEN.con_DownloadCount, objSysCount_Cond.downloadCount, strComparisonOp_DownloadCount);
        }
        if (Object.prototype.hasOwnProperty.call(objSysCount_Cond.dicFldComparisonOp, clsSysCountEN_js_1.clsSysCountEN.con_AttachmentCount) == true) {
            const strComparisonOp_AttachmentCount = objSysCount_Cond.dicFldComparisonOp[clsSysCountEN_js_1.clsSysCountEN.con_AttachmentCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysCountEN_js_1.clsSysCountEN.con_AttachmentCount, objSysCount_Cond.attachmentCount, strComparisonOp_AttachmentCount);
        }
        if (Object.prototype.hasOwnProperty.call(objSysCount_Cond.dicFldComparisonOp, clsSysCountEN_js_1.clsSysCountEN.con_CommentCount) == true) {
            const strComparisonOp_CommentCount = objSysCount_Cond.dicFldComparisonOp[clsSysCountEN_js_1.clsSysCountEN.con_CommentCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysCountEN_js_1.clsSysCountEN.con_CommentCount, objSysCount_Cond.commentCount, strComparisonOp_CommentCount);
        }
        if (Object.prototype.hasOwnProperty.call(objSysCount_Cond.dicFldComparisonOp, clsSysCountEN_js_1.clsSysCountEN.con_Score) == true) {
            const strComparisonOp_Score = objSysCount_Cond.dicFldComparisonOp[clsSysCountEN_js_1.clsSysCountEN.con_Score];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysCountEN_js_1.clsSysCountEN.con_Score, objSysCount_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objSysCount_Cond.dicFldComparisonOp, clsSysCountEN_js_1.clsSysCountEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objSysCount_Cond.dicFldComparisonOp[clsSysCountEN_js_1.clsSysCountEN.con_StuScore];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysCountEN_js_1.clsSysCountEN.con_StuScore, objSysCount_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objSysCount_Cond.dicFldComparisonOp, clsSysCountEN_js_1.clsSysCountEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objSysCount_Cond.dicFldComparisonOp[clsSysCountEN_js_1.clsSysCountEN.con_TeaScore];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysCountEN_js_1.clsSysCountEN.con_TeaScore, objSysCount_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objSysCount_Cond.dicFldComparisonOp, clsSysCountEN_js_1.clsSysCountEN.con_TableKey) == true) {
            const strComparisonOp_TableKey = objSysCount_Cond.dicFldComparisonOp[clsSysCountEN_js_1.clsSysCountEN.con_TableKey];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCountEN_js_1.clsSysCountEN.con_TableKey, objSysCount_Cond.tableKey, strComparisonOp_TableKey);
        }
        if (Object.prototype.hasOwnProperty.call(objSysCount_Cond.dicFldComparisonOp, clsSysCountEN_js_1.clsSysCountEN.con_ParentId) == true) {
            const strComparisonOp_ParentId = objSysCount_Cond.dicFldComparisonOp[clsSysCountEN_js_1.clsSysCountEN.con_ParentId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCountEN_js_1.clsSysCountEN.con_ParentId, objSysCount_Cond.parentId, strComparisonOp_ParentId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysCount_Cond.dicFldComparisonOp, clsSysCountEN_js_1.clsSysCountEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objSysCount_Cond.dicFldComparisonOp[clsSysCountEN_js_1.clsSysCountEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCountEN_js_1.clsSysCountEN.con_UpdUser, objSysCount_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objSysCount_Cond.dicFldComparisonOp, clsSysCountEN_js_1.clsSysCountEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objSysCount_Cond.dicFldComparisonOp[clsSysCountEN_js_1.clsSysCountEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCountEN_js_1.clsSysCountEN.con_UpdDate, objSysCount_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objSysCount_Cond.dicFldComparisonOp, clsSysCountEN_js_1.clsSysCountEN.con_Memo) == true) {
            const strComparisonOp_Memo = objSysCount_Cond.dicFldComparisonOp[clsSysCountEN_js_1.clsSysCountEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCountEN_js_1.clsSysCountEN.con_Memo, objSysCount_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.SysCount_GetCombineCondition = SysCount_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--SysCount(统计数据),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strCountTypeId: CountTypeId(要求唯一的字段)
    * @param strTableKey: 表主键(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SysCount_GetUniCondStr_CountTypeId_TableKey(objSysCountEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and CountTypeId = '{0}'", objSysCountEN.countTypeId);
        strWhereCond += (0, clsString_js_2.Format)(" and TableKey = '{0}'", objSysCountEN.tableKey);
        return strWhereCond;
    }
    exports.SysCount_GetUniCondStr_CountTypeId_TableKey = SysCount_GetUniCondStr_CountTypeId_TableKey;
    /**
    *获取唯一性条件串(Uniqueness)--SysCount(统计数据),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strCountTypeId: CountTypeId(要求唯一的字段)
    * @param strTableKey: 表主键(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SysCount_GetUniCondStr4Update_CountTypeId_TableKey(objSysCountEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and CountId <> '{0}'", objSysCountEN.countId);
        strWhereCond += (0, clsString_js_2.Format)(" and CountTypeId = '{0}'", objSysCountEN.countTypeId);
        strWhereCond += (0, clsString_js_2.Format)(" and TableKey = '{0}'", objSysCountEN.tableKey);
        return strWhereCond;
    }
    exports.SysCount_GetUniCondStr4Update_CountTypeId_TableKey = SysCount_GetUniCondStr4Update_CountTypeId_TableKey;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSysCountENS:源对象
     * @param objSysCountENT:目标对象
    */
    function SysCount_CopyObjTo(objSysCountENS, objSysCountENT) {
        objSysCountENT.countId = objSysCountENS.countId; //CountId
        objSysCountENT.countTypeId = objSysCountENS.countTypeId; //CountTypeId
        objSysCountENT.paperRWCount = objSysCountENS.paperRWCount; //PaperRWCount
        objSysCountENT.okCount = objSysCountENS.okCount; //点赞统计
        objSysCountENT.collectionCount = objSysCountENS.collectionCount; //收藏数量
        objSysCountENT.downloadCount = objSysCountENS.downloadCount; //下载数
        objSysCountENT.attachmentCount = objSysCountENS.attachmentCount; //附件计数
        objSysCountENT.commentCount = objSysCountENS.commentCount; //评论数
        objSysCountENT.score = objSysCountENS.score; //评分
        objSysCountENT.stuScore = objSysCountENS.stuScore; //学生平均分
        objSysCountENT.teaScore = objSysCountENS.teaScore; //教师评分
        objSysCountENT.tableKey = objSysCountENS.tableKey; //表主键
        objSysCountENT.parentId = objSysCountENS.parentId; //父Id
        objSysCountENT.updUser = objSysCountENS.updUser; //修改人
        objSysCountENT.updDate = objSysCountENS.updDate; //修改日期
        objSysCountENT.memo = objSysCountENS.memo; //备注
        objSysCountENT.sf_UpdFldSetStr = objSysCountENS.updFldString; //sf_UpdFldSetStr
    }
    exports.SysCount_CopyObjTo = SysCount_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSysCountENS:源对象
     * @param objSysCountENT:目标对象
    */
    function SysCount_GetObjFromJsonObj(objSysCountENS) {
        const objSysCountENT = new clsSysCountEN_js_1.clsSysCountEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysCountENT, objSysCountENS);
        return objSysCountENT;
    }
    exports.SysCount_GetObjFromJsonObj = SysCount_GetObjFromJsonObj;
});
