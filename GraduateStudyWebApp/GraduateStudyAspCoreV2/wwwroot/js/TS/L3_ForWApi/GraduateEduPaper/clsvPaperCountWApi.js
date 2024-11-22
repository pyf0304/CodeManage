/**
* 类名:clsvPaperCountWApi
* 表名:vPaperCount(01120595)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/15 23:44:13
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduPaper/clsvPaperCountEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vPaperCount_GetObjFromJsonObj = exports.vPaperCount_CopyObjTo = exports.vPaperCount_GetCombineCondition = exports.vPaperCount_GetObjByJSONStr = exports.vPaperCount_GetObjLstByJSONObjLst = exports.vPaperCount_GetObjLstByJSONStr = exports.vPaperCount_GetJSONStrByObj = exports.vPaperCount_GetWebApiUrl = exports.vPaperCount_GetRecCountByCondAsync = exports.vPaperCount_IsExistAsync = exports.vPaperCount_IsExist = exports.vPaperCount_IsExistRecordAsync = exports.vPaperCount_GetObjLstByPagerAsync = exports.vPaperCount_GetObjLstByRange = exports.vPaperCount_GetObjLstByRangeAsync = exports.vPaperCount_GetTopObjLstAsync = exports.vPaperCount_GetObjLstByPaperIdLstAsync = exports.vPaperCount_GetObjLstAsync = exports.vPaperCount_GetFirstObjAsync = exports.vPaperCount_GetFirstID = exports.vPaperCount_GetFirstIDAsync = exports.vPaperCount_FilterFunByKey = exports.vPaperCount_SortFunByKey = exports.vPaperCount_SortFun_Defa_2Fld = exports.vPaperCount_SortFun_Defa = exports.vPaperCount_GetObjByPaperIdAsync = exports.vPaperCount_ConstructorName = exports.vPaperCount_Controller = void 0;
    /**
     * vPaperCount(vPaperCount)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月15日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvPaperCountEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperCountEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vPaperCount_Controller = "vPaperCountApi";
    exports.vPaperCount_ConstructorName = "vPaperCount";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strPaperId:关键字
    * @returns 对象
    **/
    async function vPaperCount_GetObjByPaperIdAsync(strPaperId) {
        const strThisFuncName = "GetObjByPaperIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strPaperId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strPaperId]不能为空！(In clsvPaperCountWApi.GetObjByPaperIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPaperId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strPaperId]的长度:[{0}]不正确！(clsvPaperCountWApi.GetObjByPaperIdAsync)", strPaperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCount_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strPaperId": strPaperId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvPaperCount = vPaperCount_GetObjFromJsonObj(returnObj);
                return objvPaperCount;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCount_GetObjByPaperIdAsync = vPaperCount_GetObjByPaperIdAsync;
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
    function vPaperCount_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperId.localeCompare(b.paperId);
    }
    exports.vPaperCount_SortFun_Defa = vPaperCount_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperCount_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.appraiseCount == b.appraiseCount)
            return a.attachmentCount - b.attachmentCount;
        else
            return a.appraiseCount - b.appraiseCount;
    }
    exports.vPaperCount_SortFun_Defa_2Fld = vPaperCount_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperCount_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_AttachmentCount:
                    return (a, b) => {
                        return a.attachmentCount - b.attachmentCount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_CollectionCount:
                    return (a, b) => {
                        return a.collectionCount - b.collectionCount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_DownloadCount:
                    return (a, b) => {
                        return a.downloadCount - b.downloadCount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_Pcount:
                    return (a, b) => {
                        return a.pcount - b.pcount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_BrowseNumber:
                    return (a, b) => {
                        return a.browseNumber - b.browseNumber;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperQCount:
                    return (a, b) => {
                        return a.paperQCount - b.paperQCount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_SubVCount:
                    return (a, b) => {
                        return a.subVCount - b.subVCount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_TagsCount:
                    return (a, b) => {
                        return a.tagsCount - b.tagsCount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_TeaQCount:
                    return (a, b) => {
                        return a.teaQCount - b.teaQCount;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperCount]中不存在！(in ${exports.vPaperCount_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_AttachmentCount:
                    return (a, b) => {
                        return b.attachmentCount - a.attachmentCount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_CollectionCount:
                    return (a, b) => {
                        return b.collectionCount - a.collectionCount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_DownloadCount:
                    return (a, b) => {
                        return b.downloadCount - a.downloadCount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_Pcount:
                    return (a, b) => {
                        return b.pcount - a.pcount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_BrowseNumber:
                    return (a, b) => {
                        return b.browseNumber - a.browseNumber;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperQCount:
                    return (a, b) => {
                        return b.paperQCount - a.paperQCount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_SubVCount:
                    return (a, b) => {
                        return b.subVCount - a.subVCount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_TagsCount:
                    return (a, b) => {
                        return b.tagsCount - a.tagsCount;
                    };
                case clsvPaperCountEN_js_1.clsvPaperCountEN.con_TeaQCount:
                    return (a, b) => {
                        return b.teaQCount - a.teaQCount;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperCount]中不存在！(in ${exports.vPaperCount_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vPaperCount_SortFunByKey = vPaperCount_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vPaperCount_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_AttachmentCount:
                return (obj) => {
                    return obj.attachmentCount === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_CollectionCount:
                return (obj) => {
                    return obj.collectionCount === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_DownloadCount:
                return (obj) => {
                    return obj.downloadCount === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_Pcount:
                return (obj) => {
                    return obj.pcount === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_BrowseNumber:
                return (obj) => {
                    return obj.browseNumber === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperQCount:
                return (obj) => {
                    return obj.paperQCount === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_SubVCount:
                return (obj) => {
                    return obj.subVCount === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_TagsCount:
                return (obj) => {
                    return obj.tagsCount === value;
                };
            case clsvPaperCountEN_js_1.clsvPaperCountEN.con_TeaQCount:
                return (obj) => {
                    return obj.teaQCount === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vPaperCount]中不存在！(in ${exports.vPaperCount_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vPaperCount_FilterFunByKey = vPaperCount_FilterFunByKey;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vPaperCount_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCount_GetFirstIDAsync = vPaperCount_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vPaperCount_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCount_GetFirstID = vPaperCount_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vPaperCount_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCount_Controller, strAction);
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
                const objvPaperCount = vPaperCount_GetObjFromJsonObj(returnObj);
                return objvPaperCount;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCount_GetFirstObjAsync = vPaperCount_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vPaperCount_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCount_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCount_GetObjLstAsync = vPaperCount_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperId:关键字列表
    * @returns 对象列表
    **/
    async function vPaperCount_GetObjLstByPaperIdLstAsync(arrPaperId) {
        const strThisFuncName = "GetObjLstByPaperIdLstAsync";
        const strAction = "GetObjLstByPaperIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCount_GetObjLstByPaperIdLstAsync = vPaperCount_GetObjLstByPaperIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vPaperCount_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCount_GetTopObjLstAsync = vPaperCount_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperCount_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCount_GetObjLstByRangeAsync = vPaperCount_GetObjLstByRangeAsync;
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
    async function vPaperCount_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCount_GetObjLstByRange = vPaperCount_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperCount_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCount_GetObjLstByPagerAsync = vPaperCount_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vPaperCount_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCount_IsExistRecordAsync = vPaperCount_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strPaperId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vPaperCount_IsExist(strPaperId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCount_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperId": strPaperId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCount_IsExist = vPaperCount_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strPaperId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vPaperCount_IsExistAsync(strPaperId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCount_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strPaperId": strPaperId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCount_IsExistAsync = vPaperCount_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vPaperCount_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperCount_GetRecCountByCondAsync = vPaperCount_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vPaperCount_GetWebApiUrl(strController, strAction) {
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
    exports.vPaperCount_GetWebApiUrl = vPaperCount_GetWebApiUrl;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperCount_GetJSONStrByObj(pobjvPaperCountEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvPaperCountEN);
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
    exports.vPaperCount_GetJSONStrByObj = vPaperCount_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vPaperCount_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvPaperCountObjLst = new Array();
        if (strJSON === "") {
            return arrvPaperCountObjLst;
        }
        try {
            arrvPaperCountObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvPaperCountObjLst;
        }
        return arrvPaperCountObjLst;
    }
    exports.vPaperCount_GetObjLstByJSONStr = vPaperCount_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvPaperCountObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vPaperCount_GetObjLstByJSONObjLst(arrvPaperCountObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvPaperCountObjLst = new Array();
        for (const objInFor of arrvPaperCountObjLstS) {
            const obj1 = vPaperCount_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvPaperCountObjLst.push(obj1);
        }
        return arrvPaperCountObjLst;
    }
    exports.vPaperCount_GetObjLstByJSONObjLst = vPaperCount_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperCount_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvPaperCountEN = new clsvPaperCountEN_js_1.clsvPaperCountEN();
        if (strJSON === "") {
            return pobjvPaperCountEN;
        }
        try {
            pobjvPaperCountEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvPaperCountEN;
        }
        return pobjvPaperCountEN;
    }
    exports.vPaperCount_GetObjByJSONStr = vPaperCount_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vPaperCount_GetCombineCondition(objvPaperCount_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperId, objvPaperCount_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperCountEN_js_1.clsvPaperCountEN.con_AppraiseCount, objvPaperCount_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_AttachmentCount) == true) {
            const strComparisonOp_AttachmentCount = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_AttachmentCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperCountEN_js_1.clsvPaperCountEN.con_AttachmentCount, objvPaperCount_Cond.attachmentCount, strComparisonOp_AttachmentCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_CollectionCount) == true) {
            const strComparisonOp_CollectionCount = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_CollectionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperCountEN_js_1.clsvPaperCountEN.con_CollectionCount, objvPaperCount_Cond.collectionCount, strComparisonOp_CollectionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_DownloadCount) == true) {
            const strComparisonOp_DownloadCount = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_DownloadCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperCountEN_js_1.clsvPaperCountEN.con_DownloadCount, objvPaperCount_Cond.downloadCount, strComparisonOp_DownloadCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperCountEN_js_1.clsvPaperCountEN.con_OkCount, objvPaperCount_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_Pcount) == true) {
            const strComparisonOp_Pcount = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_Pcount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperCountEN_js_1.clsvPaperCountEN.con_Pcount, objvPaperCount_Cond.pcount, strComparisonOp_Pcount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_Score) == true) {
            const strComparisonOp_Score = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_Score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperCountEN_js_1.clsvPaperCountEN.con_Score, objvPaperCount_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperCountEN_js_1.clsvPaperCountEN.con_StuScore, objvPaperCount_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperCountEN_js_1.clsvPaperCountEN.con_TeaScore, objvPaperCount_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_BrowseNumber) == true) {
            const strComparisonOp_BrowseNumber = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_BrowseNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperCountEN_js_1.clsvPaperCountEN.con_BrowseNumber, objvPaperCount_Cond.browseNumber, strComparisonOp_BrowseNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperCountEN_js_1.clsvPaperCountEN.con_UpdDate, objvPaperCount_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperTitle, objvPaperCount_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperCountEN_js_1.clsvPaperCountEN.con_UpdUser, objvPaperCount_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperQCount) == true) {
            const strComparisonOp_PaperQCount = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperQCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperCountEN_js_1.clsvPaperCountEN.con_PaperQCount, objvPaperCount_Cond.paperQCount, strComparisonOp_PaperQCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_SubVCount) == true) {
            const strComparisonOp_SubVCount = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_SubVCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperCountEN_js_1.clsvPaperCountEN.con_SubVCount, objvPaperCount_Cond.subVCount, strComparisonOp_SubVCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_TagsCount) == true) {
            const strComparisonOp_TagsCount = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_TagsCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperCountEN_js_1.clsvPaperCountEN.con_TagsCount, objvPaperCount_Cond.tagsCount, strComparisonOp_TagsCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperCount_Cond.dicFldComparisonOp, clsvPaperCountEN_js_1.clsvPaperCountEN.con_TeaQCount) == true) {
            const strComparisonOp_TeaQCount = objvPaperCount_Cond.dicFldComparisonOp[clsvPaperCountEN_js_1.clsvPaperCountEN.con_TeaQCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperCountEN_js_1.clsvPaperCountEN.con_TeaQCount, objvPaperCount_Cond.teaQCount, strComparisonOp_TeaQCount);
        }
        return strWhereCond;
    }
    exports.vPaperCount_GetCombineCondition = vPaperCount_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvPaperCountENS:源对象
     * @param objvPaperCountENT:目标对象
    */
    function vPaperCount_CopyObjTo(objvPaperCountENS, objvPaperCountENT) {
        objvPaperCountENT.paperId = objvPaperCountENS.paperId; //论文Id
        objvPaperCountENT.appraiseCount = objvPaperCountENS.appraiseCount; //评论数
        objvPaperCountENT.attachmentCount = objvPaperCountENS.attachmentCount; //附件计数
        objvPaperCountENT.collectionCount = objvPaperCountENS.collectionCount; //收藏数量
        objvPaperCountENT.downloadCount = objvPaperCountENS.downloadCount; //下载数
        objvPaperCountENT.okCount = objvPaperCountENS.okCount; //点赞统计
        objvPaperCountENT.pcount = objvPaperCountENS.pcount; //读写数
        objvPaperCountENT.score = objvPaperCountENS.score; //评分
        objvPaperCountENT.stuScore = objvPaperCountENS.stuScore; //学生平均分
        objvPaperCountENT.teaScore = objvPaperCountENS.teaScore; //教师评分
        objvPaperCountENT.browseNumber = objvPaperCountENS.browseNumber; //浏览量
        objvPaperCountENT.updDate = objvPaperCountENS.updDate; //修改日期
        objvPaperCountENT.paperTitle = objvPaperCountENS.paperTitle; //论文标题
        objvPaperCountENT.updUser = objvPaperCountENS.updUser; //修改人
        objvPaperCountENT.paperQCount = objvPaperCountENS.paperQCount; //论文答疑数
        objvPaperCountENT.subVCount = objvPaperCountENS.subVCount; //论文子观点数
        objvPaperCountENT.tagsCount = objvPaperCountENS.tagsCount; //论文标注数
        objvPaperCountENT.teaQCount = objvPaperCountENS.teaQCount; //教师提问数
    }
    exports.vPaperCount_CopyObjTo = vPaperCount_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvPaperCountENS:源对象
     * @param objvPaperCountENT:目标对象
    */
    function vPaperCount_GetObjFromJsonObj(objvPaperCountENS) {
        const objvPaperCountENT = new clsvPaperCountEN_js_1.clsvPaperCountEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperCountENT, objvPaperCountENS);
        return objvPaperCountENT;
    }
    exports.vPaperCount_GetObjFromJsonObj = vPaperCount_GetObjFromJsonObj;
});
