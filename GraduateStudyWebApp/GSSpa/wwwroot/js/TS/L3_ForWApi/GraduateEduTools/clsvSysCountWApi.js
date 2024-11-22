/**
* 类名:clsvSysCountWApi
* 表名:vSysCount(01120626)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:59
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTools/clsvSysCountEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vSysCount_GetObjFromJsonObj = exports.vSysCount_CopyObjTo = exports.vSysCount_GetCombineCondition = exports.vSysCount_GetObjByJSONStr = exports.vSysCount_GetObjLstByJSONObjLst = exports.vSysCount_GetObjLstByJSONStr = exports.vSysCount_GetJSONStrByObj = exports.vSysCount_GetWebApiUrl = exports.vSysCount_GetRecCountByCondAsync = exports.vSysCount_IsExistAsync = exports.vSysCount_IsExist = exports.vSysCount_IsExistRecordAsync = exports.vSysCount_GetObjLstByPagerAsync = exports.vSysCount_GetObjLstByRange = exports.vSysCount_GetObjLstByRangeAsync = exports.vSysCount_GetTopObjLstAsync = exports.vSysCount_GetObjLstByCountIdLstAsync = exports.vSysCount_GetObjLstAsync = exports.vSysCount_GetFirstObjAsync = exports.vSysCount_GetFirstID = exports.vSysCount_GetFirstIDAsync = exports.vSysCount_FilterFunByKey = exports.vSysCount_SortFunByKey = exports.vSysCount_SortFun_Defa_2Fld = exports.vSysCount_SortFun_Defa = exports.vSysCount_GetObjByCountIdAsync = exports.vSysCount_ConstructorName = exports.vSysCount_Controller = void 0;
    /**
     * 数据统计视图(vSysCount)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvSysCountEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsvSysCountEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vSysCount_Controller = "vSysCountApi";
    exports.vSysCount_ConstructorName = "vSysCount";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCountId:关键字
    * @returns 对象
    **/
    async function vSysCount_GetObjByCountIdAsync(strCountId) {
        const strThisFuncName = "GetObjByCountIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCountId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCountId]不能为空！(In GetObjByCountIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCountId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCountId]的长度:[{0}]不正确！", strCountId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByCountId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysCount_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvSysCount = vSysCount_GetObjFromJsonObj(returnObj);
                return objvSysCount;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysCount_GetObjByCountIdAsync = vSysCount_GetObjByCountIdAsync;
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
    function vSysCount_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.countId.localeCompare(b.countId);
    }
    exports.vSysCount_SortFun_Defa = vSysCount_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysCount_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.countTypeId == b.countTypeId)
            return a.commentTypeName.localeCompare(b.commentTypeName);
        else
            return a.countTypeId.localeCompare(b.countTypeId);
    }
    exports.vSysCount_SortFun_Defa_2Fld = vSysCount_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysCount_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvSysCountEN_js_1.clsvSysCountEN.con_CountId:
                    return (a, b) => {
                        return a.countId.localeCompare(b.countId);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_CountTypeId:
                    return (a, b) => {
                        return a.countTypeId.localeCompare(b.countTypeId);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTypeName:
                    return (a, b) => {
                        return a.commentTypeName.localeCompare(b.commentTypeName);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTable:
                    return (a, b) => {
                        return a.commentTable.localeCompare(b.commentTable);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTableId:
                    return (a, b) => {
                        return a.commentTableId.localeCompare(b.commentTableId);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_CollectionCount:
                    return (a, b) => {
                        return a.collectionCount - b.collectionCount;
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_DownloadCount:
                    return (a, b) => {
                        return a.downloadCount - b.downloadCount;
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_AttachmentCount:
                    return (a, b) => {
                        return a.attachmentCount - b.attachmentCount;
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_CommentCount:
                    return (a, b) => {
                        return a.commentCount - b.commentCount;
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_TableKey:
                    return (a, b) => {
                        return a.tableKey.localeCompare(b.tableKey);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_ParentId:
                    return (a, b) => {
                        return a.parentId.localeCompare(b.parentId);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_PaperRWCount:
                    return (a, b) => {
                        return a.paperRWCount - b.paperRWCount;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vSysCount]中不存在！(in ${exports.vSysCount_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvSysCountEN_js_1.clsvSysCountEN.con_CountId:
                    return (a, b) => {
                        return b.countId.localeCompare(a.countId);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_CountTypeId:
                    return (a, b) => {
                        return b.countTypeId.localeCompare(a.countTypeId);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTypeName:
                    return (a, b) => {
                        return b.commentTypeName.localeCompare(a.commentTypeName);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTable:
                    return (a, b) => {
                        return b.commentTable.localeCompare(a.commentTable);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTableId:
                    return (a, b) => {
                        return b.commentTableId.localeCompare(a.commentTableId);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_CollectionCount:
                    return (a, b) => {
                        return b.collectionCount - a.collectionCount;
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_DownloadCount:
                    return (a, b) => {
                        return b.downloadCount - a.downloadCount;
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_AttachmentCount:
                    return (a, b) => {
                        return b.attachmentCount - a.attachmentCount;
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_CommentCount:
                    return (a, b) => {
                        return b.commentCount - a.commentCount;
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_TableKey:
                    return (a, b) => {
                        return b.tableKey.localeCompare(a.tableKey);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_ParentId:
                    return (a, b) => {
                        return b.parentId.localeCompare(a.parentId);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvSysCountEN_js_1.clsvSysCountEN.con_PaperRWCount:
                    return (a, b) => {
                        return b.paperRWCount - a.paperRWCount;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vSysCount]中不存在！(in ${exports.vSysCount_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vSysCount_SortFunByKey = vSysCount_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vSysCount_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvSysCountEN_js_1.clsvSysCountEN.con_CountId:
                return (obj) => {
                    return obj.countId === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_CountTypeId:
                return (obj) => {
                    return obj.countTypeId === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTypeName:
                return (obj) => {
                    return obj.commentTypeName === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTable:
                return (obj) => {
                    return obj.commentTable === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTableId:
                return (obj) => {
                    return obj.commentTableId === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_CollectionCount:
                return (obj) => {
                    return obj.collectionCount === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_DownloadCount:
                return (obj) => {
                    return obj.downloadCount === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_AttachmentCount:
                return (obj) => {
                    return obj.attachmentCount === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_CommentCount:
                return (obj) => {
                    return obj.commentCount === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_TableKey:
                return (obj) => {
                    return obj.tableKey === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_ParentId:
                return (obj) => {
                    return obj.parentId === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvSysCountEN_js_1.clsvSysCountEN.con_PaperRWCount:
                return (obj) => {
                    return obj.paperRWCount === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vSysCount]中不存在！(in ${exports.vSysCount_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vSysCount_FilterFunByKey = vSysCount_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vSysCount_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysCount_GetFirstIDAsync = vSysCount_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vSysCount_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysCount_GetFirstID = vSysCount_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vSysCount_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysCount_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvSysCount = vSysCount_GetObjFromJsonObj(returnObj);
                return objvSysCount;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysCount_GetFirstObjAsync = vSysCount_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vSysCount_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysCount_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysCount_GetObjLstAsync = vSysCount_GetObjLstAsync;
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
    async function vSysCount_GetObjLstByCountIdLstAsync(arrCountId) {
        const strThisFuncName = "GetObjLstByCountIdLstAsync";
        const strAction = "GetObjLstByCountIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCountId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysCount_GetObjLstByCountIdLstAsync = vSysCount_GetObjLstByCountIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vSysCount_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysCount_GetTopObjLstAsync = vSysCount_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vSysCount_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysCount_GetObjLstByRangeAsync = vSysCount_GetObjLstByRangeAsync;
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
    async function vSysCount_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysCount_GetObjLstByRange = vSysCount_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vSysCount_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysCount_GetObjLstByPagerAsync = vSysCount_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vSysCount_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysCount_IsExistRecordAsync = vSysCount_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCountId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vSysCount_IsExist(strCountId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysCount_IsExist = vSysCount_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCountId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vSysCount_IsExistAsync(strCountId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysCount_IsExistAsync = vSysCount_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vSysCount_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysCount_GetRecCountByCondAsync = vSysCount_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vSysCount_GetWebApiUrl(strController, strAction) {
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
    exports.vSysCount_GetWebApiUrl = vSysCount_GetWebApiUrl;
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
    function vSysCount_GetJSONStrByObj(pobjvSysCountEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvSysCountEN);
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
    exports.vSysCount_GetJSONStrByObj = vSysCount_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vSysCount_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvSysCountObjLst = new Array();
        if (strJSON === "") {
            return arrvSysCountObjLst;
        }
        try {
            arrvSysCountObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvSysCountObjLst;
        }
        return arrvSysCountObjLst;
    }
    exports.vSysCount_GetObjLstByJSONStr = vSysCount_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvSysCountObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vSysCount_GetObjLstByJSONObjLst(arrvSysCountObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvSysCountObjLst = new Array();
        for (const objInFor of arrvSysCountObjLstS) {
            const obj1 = vSysCount_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvSysCountObjLst.push(obj1);
        }
        return arrvSysCountObjLst;
    }
    exports.vSysCount_GetObjLstByJSONObjLst = vSysCount_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vSysCount_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvSysCountEN = new clsvSysCountEN_js_1.clsvSysCountEN();
        if (strJSON === "") {
            return pobjvSysCountEN;
        }
        try {
            pobjvSysCountEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvSysCountEN;
        }
        return pobjvSysCountEN;
    }
    exports.vSysCount_GetObjByJSONStr = vSysCount_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vSysCount_GetCombineCondition(objvSysCount_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_CountId) == true) {
            const strComparisonOp_CountId = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_CountId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCountEN_js_1.clsvSysCountEN.con_CountId, objvSysCount_Cond.countId, strComparisonOp_CountId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_CountTypeId) == true) {
            const strComparisonOp_CountTypeId = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_CountTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCountEN_js_1.clsvSysCountEN.con_CountTypeId, objvSysCount_Cond.countTypeId, strComparisonOp_CountTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTypeName) == true) {
            const strComparisonOp_CommentTypeName = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTypeName, objvSysCount_Cond.commentTypeName, strComparisonOp_CommentTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTable) == true) {
            const strComparisonOp_CommentTable = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTable];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTable, objvSysCount_Cond.commentTable, strComparisonOp_CommentTable);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysCountEN_js_1.clsvSysCountEN.con_OkCount, objvSysCount_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTableId) == true) {
            const strComparisonOp_CommentTableId = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTableId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCountEN_js_1.clsvSysCountEN.con_CommentTableId, objvSysCount_Cond.commentTableId, strComparisonOp_CommentTableId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_CollectionCount) == true) {
            const strComparisonOp_CollectionCount = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_CollectionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysCountEN_js_1.clsvSysCountEN.con_CollectionCount, objvSysCount_Cond.collectionCount, strComparisonOp_CollectionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_DownloadCount) == true) {
            const strComparisonOp_DownloadCount = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_DownloadCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysCountEN_js_1.clsvSysCountEN.con_DownloadCount, objvSysCount_Cond.downloadCount, strComparisonOp_DownloadCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_AttachmentCount) == true) {
            const strComparisonOp_AttachmentCount = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_AttachmentCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysCountEN_js_1.clsvSysCountEN.con_AttachmentCount, objvSysCount_Cond.attachmentCount, strComparisonOp_AttachmentCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_CommentCount) == true) {
            const strComparisonOp_CommentCount = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_CommentCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysCountEN_js_1.clsvSysCountEN.con_CommentCount, objvSysCount_Cond.commentCount, strComparisonOp_CommentCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_score) == true) {
            const strComparisonOp_score = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysCountEN_js_1.clsvSysCountEN.con_score, objvSysCount_Cond.score, strComparisonOp_score);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysCountEN_js_1.clsvSysCountEN.con_StuScore, objvSysCount_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysCountEN_js_1.clsvSysCountEN.con_TeaScore, objvSysCount_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_TableKey) == true) {
            const strComparisonOp_TableKey = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_TableKey];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCountEN_js_1.clsvSysCountEN.con_TableKey, objvSysCount_Cond.tableKey, strComparisonOp_TableKey);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_ParentId) == true) {
            const strComparisonOp_ParentId = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_ParentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCountEN_js_1.clsvSysCountEN.con_ParentId, objvSysCount_Cond.parentId, strComparisonOp_ParentId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCountEN_js_1.clsvSysCountEN.con_UpdUser, objvSysCount_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCountEN_js_1.clsvSysCountEN.con_UpdDate, objvSysCount_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCountEN_js_1.clsvSysCountEN.con_Memo, objvSysCount_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysCount_Cond.dicFldComparisonOp, clsvSysCountEN_js_1.clsvSysCountEN.con_PaperRWCount) == true) {
            const strComparisonOp_PaperRWCount = objvSysCount_Cond.dicFldComparisonOp[clsvSysCountEN_js_1.clsvSysCountEN.con_PaperRWCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysCountEN_js_1.clsvSysCountEN.con_PaperRWCount, objvSysCount_Cond.paperRWCount, strComparisonOp_PaperRWCount);
        }
        return strWhereCond;
    }
    exports.vSysCount_GetCombineCondition = vSysCount_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvSysCountENS:源对象
     * @param objvSysCountENT:目标对象
    */
    function vSysCount_CopyObjTo(objvSysCountENS, objvSysCountENT) {
        objvSysCountENT.countId = objvSysCountENS.countId; //CountId
        objvSysCountENT.countTypeId = objvSysCountENS.countTypeId; //CountTypeId
        objvSysCountENT.commentTypeName = objvSysCountENS.commentTypeName; //评论类型名
        objvSysCountENT.commentTable = objvSysCountENS.commentTable; //评论表
        objvSysCountENT.okCount = objvSysCountENS.okCount; //点赞统计
        objvSysCountENT.commentTableId = objvSysCountENS.commentTableId; //评论表Id
        objvSysCountENT.collectionCount = objvSysCountENS.collectionCount; //收藏数
        objvSysCountENT.downloadCount = objvSysCountENS.downloadCount; //下载数
        objvSysCountENT.attachmentCount = objvSysCountENS.attachmentCount; //附件计数
        objvSysCountENT.commentCount = objvSysCountENS.commentCount; //评论数
        objvSysCountENT.score = objvSysCountENS.score; //评分
        objvSysCountENT.stuScore = objvSysCountENS.stuScore; //学生平均分
        objvSysCountENT.teaScore = objvSysCountENS.teaScore; //教师评分
        objvSysCountENT.tableKey = objvSysCountENS.tableKey; //表主键
        objvSysCountENT.parentId = objvSysCountENS.parentId; //父Id
        objvSysCountENT.updUser = objvSysCountENS.updUser; //修改人
        objvSysCountENT.updDate = objvSysCountENS.updDate; //修改日期
        objvSysCountENT.memo = objvSysCountENS.memo; //备注
        objvSysCountENT.paperRWCount = objvSysCountENS.paperRWCount; //PaperRWCount
    }
    exports.vSysCount_CopyObjTo = vSysCount_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvSysCountENS:源对象
     * @param objvSysCountENT:目标对象
    */
    function vSysCount_GetObjFromJsonObj(objvSysCountENS) {
        const objvSysCountENT = new clsvSysCountEN_js_1.clsvSysCountEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvSysCountENT, objvSysCountENS);
        return objvSysCountENT;
    }
    exports.vSysCount_GetObjFromJsonObj = vSysCount_GetObjFromJsonObj;
});
