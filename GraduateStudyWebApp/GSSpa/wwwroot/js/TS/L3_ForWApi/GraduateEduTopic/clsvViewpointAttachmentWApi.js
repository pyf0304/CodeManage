/**
* 类名:clsvViewpointAttachmentWApi
* 表名:vViewpointAttachment(01120593)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:46
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培主题(GraduateEduTopic)
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTopic/clsvViewpointAttachmentEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vViewpointAttachment_GetObjFromJsonObj = exports.vViewpointAttachment_CopyObjTo = exports.vViewpointAttachment_GetCombineCondition = exports.vViewpointAttachment_GetObjByJSONStr = exports.vViewpointAttachment_GetObjLstByJSONObjLst = exports.vViewpointAttachment_GetObjLstByJSONStr = exports.vViewpointAttachment_GetJSONStrByObj = exports.vViewpointAttachment_GetWebApiUrl = exports.vViewpointAttachment_GetRecCountByCondAsync = exports.vViewpointAttachment_IsExistAsync = exports.vViewpointAttachment_IsExist = exports.vViewpointAttachment_IsExistRecordAsync = exports.vViewpointAttachment_GetObjLstByPagerAsync = exports.vViewpointAttachment_GetObjLstByRange = exports.vViewpointAttachment_GetObjLstByRangeAsync = exports.vViewpointAttachment_GetTopObjLstAsync = exports.vViewpointAttachment_GetObjLstByViewpointAttachmentIdLstAsync = exports.vViewpointAttachment_GetObjLstAsync = exports.vViewpointAttachment_GetFirstObjAsync = exports.vViewpointAttachment_GetFirstID = exports.vViewpointAttachment_GetFirstIDAsync = exports.vViewpointAttachment_FilterFunByKey = exports.vViewpointAttachment_SortFunByKey = exports.vViewpointAttachment_SortFun_Defa_2Fld = exports.vViewpointAttachment_SortFun_Defa = exports.vViewpointAttachment_GetObjByViewpointAttachmentIdAsync = exports.vViewpointAttachment_ConstructorName = exports.vViewpointAttachment_Controller = void 0;
    /**
     * v观点附件(vViewpointAttachment)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvViewpointAttachmentEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvViewpointAttachmentEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vViewpointAttachment_Controller = "vViewpointAttachmentApi";
    exports.vViewpointAttachment_ConstructorName = "vViewpointAttachment";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngViewpointAttachmentId:关键字
    * @returns 对象
    **/
    async function vViewpointAttachment_GetObjByViewpointAttachmentIdAsync(lngViewpointAttachmentId) {
        const strThisFuncName = "GetObjByViewpointAttachmentIdAsync";
        if (lngViewpointAttachmentId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngViewpointAttachmentId]不能为空！(In GetObjByViewpointAttachmentIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByViewpointAttachmentId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngViewpointAttachmentId": lngViewpointAttachmentId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvViewpointAttachment = vViewpointAttachment_GetObjFromJsonObj(returnObj);
                return objvViewpointAttachment;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAttachment_GetObjByViewpointAttachmentIdAsync = vViewpointAttachment_GetObjByViewpointAttachmentIdAsync;
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
    function vViewpointAttachment_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.viewpointAttachmentId - b.viewpointAttachmentId;
    }
    exports.vViewpointAttachment_SortFun_Defa = vViewpointAttachment_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vViewpointAttachment_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.reason == b.reason)
            return a.viewpointAttachmentName.localeCompare(b.viewpointAttachmentName);
        else
            return a.reason.localeCompare(b.reason);
    }
    exports.vViewpointAttachment_SortFun_Defa_2Fld = vViewpointAttachment_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vViewpointAttachment_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointAttachmentId:
                    return (a, b) => {
                        return a.viewpointAttachmentId - b.viewpointAttachmentId;
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_Reason:
                    return (a, b) => {
                        return a.reason.localeCompare(b.reason);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointAttachmentName:
                    return (a, b) => {
                        return a.viewpointAttachmentName.localeCompare(b.viewpointAttachmentName);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_Source:
                    return (a, b) => {
                        return a.source.localeCompare(b.source);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointId:
                    return (a, b) => {
                        return a.viewpointId.localeCompare(b.viewpointId);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_FilePath:
                    return (a, b) => {
                        return a.filePath.localeCompare(b.filePath);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointContent:
                    return (a, b) => {
                        return a.viewpointContent.localeCompare(b.viewpointContent);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointName:
                    return (a, b) => {
                        return a.viewpointName.localeCompare(b.viewpointName);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointTypeId:
                    return (a, b) => {
                        return a.viewpointTypeId.localeCompare(b.viewpointTypeId);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointTypeName:
                    return (a, b) => {
                        return a.viewpointTypeName.localeCompare(b.viewpointTypeName);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_VPProposePeople:
                    return (a, b) => {
                        return a.vpProposePeople.localeCompare(b.vpProposePeople);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vViewpointAttachment]中不存在！(in ${exports.vViewpointAttachment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointAttachmentId:
                    return (a, b) => {
                        return b.viewpointAttachmentId - a.viewpointAttachmentId;
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_Reason:
                    return (a, b) => {
                        return b.reason.localeCompare(a.reason);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointAttachmentName:
                    return (a, b) => {
                        return b.viewpointAttachmentName.localeCompare(a.viewpointAttachmentName);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_Source:
                    return (a, b) => {
                        return b.source.localeCompare(a.source);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointId:
                    return (a, b) => {
                        return b.viewpointId.localeCompare(a.viewpointId);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_FilePath:
                    return (a, b) => {
                        return b.filePath.localeCompare(a.filePath);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointContent:
                    return (a, b) => {
                        return b.viewpointContent.localeCompare(a.viewpointContent);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointName:
                    return (a, b) => {
                        return b.viewpointName.localeCompare(a.viewpointName);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointTypeId:
                    return (a, b) => {
                        return b.viewpointTypeId.localeCompare(a.viewpointTypeId);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointTypeName:
                    return (a, b) => {
                        return b.viewpointTypeName.localeCompare(a.viewpointTypeName);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_VPProposePeople:
                    return (a, b) => {
                        return b.vpProposePeople.localeCompare(a.vpProposePeople);
                    };
                case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vViewpointAttachment]中不存在！(in ${exports.vViewpointAttachment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vViewpointAttachment_SortFunByKey = vViewpointAttachment_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vViewpointAttachment_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointAttachmentId:
                return (obj) => {
                    return obj.viewpointAttachmentId === value;
                };
            case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_Reason:
                return (obj) => {
                    return obj.reason === value;
                };
            case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointAttachmentName:
                return (obj) => {
                    return obj.viewpointAttachmentName === value;
                };
            case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_Source:
                return (obj) => {
                    return obj.source === value;
                };
            case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointId:
                return (obj) => {
                    return obj.viewpointId === value;
                };
            case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_FilePath:
                return (obj) => {
                    return obj.filePath === value;
                };
            case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointContent:
                return (obj) => {
                    return obj.viewpointContent === value;
                };
            case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointName:
                return (obj) => {
                    return obj.viewpointName === value;
                };
            case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointTypeId:
                return (obj) => {
                    return obj.viewpointTypeId === value;
                };
            case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointTypeName:
                return (obj) => {
                    return obj.viewpointTypeName === value;
                };
            case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_VPProposePeople:
                return (obj) => {
                    return obj.vpProposePeople === value;
                };
            case clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vViewpointAttachment]中不存在！(in ${exports.vViewpointAttachment_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vViewpointAttachment_FilterFunByKey = vViewpointAttachment_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vViewpointAttachment_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAttachment_GetFirstIDAsync = vViewpointAttachment_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vViewpointAttachment_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAttachment_GetFirstID = vViewpointAttachment_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vViewpointAttachment_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvViewpointAttachment = vViewpointAttachment_GetObjFromJsonObj(returnObj);
                return objvViewpointAttachment;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAttachment_GetFirstObjAsync = vViewpointAttachment_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vViewpointAttachment_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vViewpointAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAttachment_GetObjLstAsync = vViewpointAttachment_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrViewpointAttachmentId:关键字列表
    * @returns 对象列表
    **/
    async function vViewpointAttachment_GetObjLstByViewpointAttachmentIdLstAsync(arrViewpointAttachmentId) {
        const strThisFuncName = "GetObjLstByViewpointAttachmentIdLstAsync";
        const strAction = "GetObjLstByViewpointAttachmentIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrViewpointAttachmentId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vViewpointAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAttachment_GetObjLstByViewpointAttachmentIdLstAsync = vViewpointAttachment_GetObjLstByViewpointAttachmentIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vViewpointAttachment_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vViewpointAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAttachment_GetTopObjLstAsync = vViewpointAttachment_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vViewpointAttachment_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vViewpointAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAttachment_GetObjLstByRangeAsync = vViewpointAttachment_GetObjLstByRangeAsync;
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
    async function vViewpointAttachment_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAttachment_GetObjLstByRange = vViewpointAttachment_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vViewpointAttachment_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vViewpointAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAttachment_GetObjLstByPagerAsync = vViewpointAttachment_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vViewpointAttachment_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAttachment_IsExistRecordAsync = vViewpointAttachment_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngViewpointAttachmentId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vViewpointAttachment_IsExist(lngViewpointAttachmentId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ViewpointAttachmentId": lngViewpointAttachmentId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAttachment_IsExist = vViewpointAttachment_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngViewpointAttachmentId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vViewpointAttachment_IsExistAsync(lngViewpointAttachmentId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAttachment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngViewpointAttachmentId": lngViewpointAttachmentId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAttachment_IsExistAsync = vViewpointAttachment_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vViewpointAttachment_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAttachment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAttachment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAttachment_GetRecCountByCondAsync = vViewpointAttachment_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vViewpointAttachment_GetWebApiUrl(strController, strAction) {
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
    exports.vViewpointAttachment_GetWebApiUrl = vViewpointAttachment_GetWebApiUrl;
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
    function vViewpointAttachment_GetJSONStrByObj(pobjvViewpointAttachmentEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvViewpointAttachmentEN);
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
    exports.vViewpointAttachment_GetJSONStrByObj = vViewpointAttachment_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vViewpointAttachment_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvViewpointAttachmentObjLst = new Array();
        if (strJSON === "") {
            return arrvViewpointAttachmentObjLst;
        }
        try {
            arrvViewpointAttachmentObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvViewpointAttachmentObjLst;
        }
        return arrvViewpointAttachmentObjLst;
    }
    exports.vViewpointAttachment_GetObjLstByJSONStr = vViewpointAttachment_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvViewpointAttachmentObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vViewpointAttachment_GetObjLstByJSONObjLst(arrvViewpointAttachmentObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvViewpointAttachmentObjLst = new Array();
        for (const objInFor of arrvViewpointAttachmentObjLstS) {
            const obj1 = vViewpointAttachment_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvViewpointAttachmentObjLst.push(obj1);
        }
        return arrvViewpointAttachmentObjLst;
    }
    exports.vViewpointAttachment_GetObjLstByJSONObjLst = vViewpointAttachment_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vViewpointAttachment_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvViewpointAttachmentEN = new clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN();
        if (strJSON === "") {
            return pobjvViewpointAttachmentEN;
        }
        try {
            pobjvViewpointAttachmentEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvViewpointAttachmentEN;
        }
        return pobjvViewpointAttachmentEN;
    }
    exports.vViewpointAttachment_GetObjByJSONStr = vViewpointAttachment_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vViewpointAttachment_GetCombineCondition(objvViewpointAttachment_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvViewpointAttachment_Cond.dicFldComparisonOp, clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointAttachmentId) == true) {
            const strComparisonOp_ViewpointAttachmentId = objvViewpointAttachment_Cond.dicFldComparisonOp[clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointAttachmentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointAttachmentId, objvViewpointAttachment_Cond.viewpointAttachmentId, strComparisonOp_ViewpointAttachmentId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvViewpointAttachment_Cond.dicFldComparisonOp, clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointAttachmentName) == true) {
            const strComparisonOp_ViewpointAttachmentName = objvViewpointAttachment_Cond.dicFldComparisonOp[clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointAttachmentName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointAttachmentName, objvViewpointAttachment_Cond.viewpointAttachmentName, strComparisonOp_ViewpointAttachmentName);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointAttachment_Cond.dicFldComparisonOp, clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_Source) == true) {
            const strComparisonOp_Source = objvViewpointAttachment_Cond.dicFldComparisonOp[clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_Source];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_Source, objvViewpointAttachment_Cond.source, strComparisonOp_Source);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointAttachment_Cond.dicFldComparisonOp, clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointId) == true) {
            const strComparisonOp_ViewpointId = objvViewpointAttachment_Cond.dicFldComparisonOp[clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointId, objvViewpointAttachment_Cond.viewpointId, strComparisonOp_ViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointAttachment_Cond.dicFldComparisonOp, clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_FilePath) == true) {
            const strComparisonOp_FilePath = objvViewpointAttachment_Cond.dicFldComparisonOp[clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_FilePath];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_FilePath, objvViewpointAttachment_Cond.filePath, strComparisonOp_FilePath);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointAttachment_Cond.dicFldComparisonOp, clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvViewpointAttachment_Cond.dicFldComparisonOp[clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_UpdUser, objvViewpointAttachment_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointAttachment_Cond.dicFldComparisonOp, clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvViewpointAttachment_Cond.dicFldComparisonOp[clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_UpdDate, objvViewpointAttachment_Cond.updDate, strComparisonOp_UpdDate);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvViewpointAttachment_Cond.dicFldComparisonOp, clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointName) == true) {
            const strComparisonOp_ViewpointName = objvViewpointAttachment_Cond.dicFldComparisonOp[clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointName, objvViewpointAttachment_Cond.viewpointName, strComparisonOp_ViewpointName);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointAttachment_Cond.dicFldComparisonOp, clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointTypeId) == true) {
            const strComparisonOp_ViewpointTypeId = objvViewpointAttachment_Cond.dicFldComparisonOp[clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointTypeId, objvViewpointAttachment_Cond.viewpointTypeId, strComparisonOp_ViewpointTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointAttachment_Cond.dicFldComparisonOp, clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointTypeName) == true) {
            const strComparisonOp_ViewpointTypeName = objvViewpointAttachment_Cond.dicFldComparisonOp[clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_ViewpointTypeName, objvViewpointAttachment_Cond.viewpointTypeName, strComparisonOp_ViewpointTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointAttachment_Cond.dicFldComparisonOp, clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_VPProposePeople) == true) {
            const strComparisonOp_VPProposePeople = objvViewpointAttachment_Cond.dicFldComparisonOp[clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_VPProposePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_VPProposePeople, objvViewpointAttachment_Cond.vpProposePeople, strComparisonOp_VPProposePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointAttachment_Cond.dicFldComparisonOp, clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvViewpointAttachment_Cond.dicFldComparisonOp[clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN.con_id_CurrEduCls, objvViewpointAttachment_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.vViewpointAttachment_GetCombineCondition = vViewpointAttachment_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvViewpointAttachmentENS:源对象
     * @param objvViewpointAttachmentENT:目标对象
    */
    function vViewpointAttachment_CopyObjTo(objvViewpointAttachmentENS, objvViewpointAttachmentENT) {
        objvViewpointAttachmentENT.viewpointAttachmentId = objvViewpointAttachmentENS.viewpointAttachmentId; //主键Id
        objvViewpointAttachmentENT.reason = objvViewpointAttachmentENS.reason; //理由
        objvViewpointAttachmentENT.viewpointAttachmentName = objvViewpointAttachmentENS.viewpointAttachmentName; //附件名称
        objvViewpointAttachmentENT.source = objvViewpointAttachmentENS.source; //来源
        objvViewpointAttachmentENT.viewpointId = objvViewpointAttachmentENS.viewpointId; //观点Id
        objvViewpointAttachmentENT.filePath = objvViewpointAttachmentENS.filePath; //文件路径
        objvViewpointAttachmentENT.updUser = objvViewpointAttachmentENS.updUser; //修改人
        objvViewpointAttachmentENT.updDate = objvViewpointAttachmentENS.updDate; //修改日期
        objvViewpointAttachmentENT.viewpointContent = objvViewpointAttachmentENS.viewpointContent; //观点内容
        objvViewpointAttachmentENT.viewpointName = objvViewpointAttachmentENS.viewpointName; //观点名称
        objvViewpointAttachmentENT.viewpointTypeId = objvViewpointAttachmentENS.viewpointTypeId; //观点类型Id
        objvViewpointAttachmentENT.viewpointTypeName = objvViewpointAttachmentENS.viewpointTypeName; //观点类型名
        objvViewpointAttachmentENT.vpProposePeople = objvViewpointAttachmentENS.vpProposePeople; //观点提出人
        objvViewpointAttachmentENT.id_CurrEduCls = objvViewpointAttachmentENS.id_CurrEduCls; //教学班流水号
    }
    exports.vViewpointAttachment_CopyObjTo = vViewpointAttachment_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvViewpointAttachmentENS:源对象
     * @param objvViewpointAttachmentENT:目标对象
    */
    function vViewpointAttachment_GetObjFromJsonObj(objvViewpointAttachmentENS) {
        const objvViewpointAttachmentENT = new clsvViewpointAttachmentEN_js_1.clsvViewpointAttachmentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvViewpointAttachmentENT, objvViewpointAttachmentENS);
        return objvViewpointAttachmentENT;
    }
    exports.vViewpointAttachment_GetObjFromJsonObj = vViewpointAttachment_GetObjFromJsonObj;
});
