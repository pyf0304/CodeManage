/**
* 类名:clsvDiscussionSubContentWApi
* 表名:vDiscussionSubContent(01120585)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:10:01
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
        define(["require", "exports", "axios", "../../L0_Entity/GraduateEduTools/clsvDiscussionSubContentEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vDiscussionSubContent_GetObjFromJsonObj = exports.vDiscussionSubContent_CopyObjTo = exports.vDiscussionSubContent_GetUniCondStr4Update_SubContentId = exports.vDiscussionSubContent_GetUniCondStr_SubContentId = exports.vDiscussionSubContent_GetCombineCondition = exports.vDiscussionSubContent_GetObjByJSONStr = exports.vDiscussionSubContent_GetObjLstByJSONObjLst = exports.vDiscussionSubContent_GetObjLstByJSONStr = exports.vDiscussionSubContent_GetJSONStrByObj = exports.vDiscussionSubContent_GetWebApiUrl = exports.vDiscussionSubContent_GetRecCountByCondAsync = exports.vDiscussionSubContent_IsExistAsync = exports.vDiscussionSubContent_IsExist = exports.vDiscussionSubContent_IsExistRecordAsync = exports.vDiscussionSubContent_GetObjLstByPagerAsync = exports.vDiscussionSubContent_GetObjLstByRange = exports.vDiscussionSubContent_GetObjLstByRangeAsync = exports.vDiscussionSubContent_GetTopObjLstAsync = exports.vDiscussionSubContent_GetObjLstBySubContentIdLstAsync = exports.vDiscussionSubContent_GetObjLstAsync = exports.vDiscussionSubContent_GetFirstObjAsync = exports.vDiscussionSubContent_GetFirstID = exports.vDiscussionSubContent_GetFirstIDAsync = exports.vDiscussionSubContent_FilterFunByKey = exports.vDiscussionSubContent_SortFunByKey = exports.vDiscussionSubContent_SortFun_Defa_2Fld = exports.vDiscussionSubContent_SortFun_Defa = exports.vDiscussionSubContent_GetObjBySubContentIdAsync = exports.vDiscussionSubContent_ConstructorName = exports.vDiscussionSubContent_Controller = void 0;
    /**
     * v讨论子内容视图(vDiscussionSubContent)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const clsvDiscussionSubContentEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsvDiscussionSubContentEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vDiscussionSubContent_Controller = "vDiscussionSubContentApi";
    exports.vDiscussionSubContent_ConstructorName = "vDiscussionSubContent";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strSubContentId:关键字
    * @returns 对象
    **/
    async function vDiscussionSubContent_GetObjBySubContentIdAsync(strSubContentId) {
        const strThisFuncName = "GetObjBySubContentIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSubContentId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSubContentId]不能为空！(In GetObjBySubContentIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSubContentId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSubContentId]的长度:[{0}]不正确！", strSubContentId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBySubContentId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strSubContentId": strSubContentId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvDiscussionSubContent = vDiscussionSubContent_GetObjFromJsonObj(returnObj);
                return objvDiscussionSubContent;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionSubContent_GetObjBySubContentIdAsync = vDiscussionSubContent_GetObjBySubContentIdAsync;
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
    function vDiscussionSubContent_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.subContentId.localeCompare(b.subContentId);
    }
    exports.vDiscussionSubContent_SortFun_Defa = vDiscussionSubContent_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vDiscussionSubContent_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.subContent == b.subContent)
            return a.topicsId.localeCompare(b.topicsId);
        else
            return a.subContent.localeCompare(b.subContent);
    }
    exports.vDiscussionSubContent_SortFun_Defa_2Fld = vDiscussionSubContent_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vDiscussionSubContent_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_SubContent:
                    return (a, b) => {
                        return a.subContent.localeCompare(b.subContent);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_TopicsId:
                    return (a, b) => {
                        return a.topicsId.localeCompare(b.topicsId);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_topicsTitle:
                    return (a, b) => {
                        return a.topicsTitle.localeCompare(b.topicsTitle);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_IsTop:
                    return (a, b) => {
                        if (a.isTop == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_CollegeName:
                    return (a, b) => {
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_XzCollege:
                    return (a, b) => {
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_BrowseNumber:
                    return (a, b) => {
                        return a.browseNumber - b.browseNumber;
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_ParentId:
                    return (a, b) => {
                        return a.parentId.localeCompare(b.parentId);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_TopicsContent:
                    return (a, b) => {
                        return a.topicsContent.localeCompare(b.topicsContent);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_vUpdDate:
                    return (a, b) => {
                        return a.vUpdDate.localeCompare(b.vUpdDate);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_vUpdUser:
                    return (a, b) => {
                        return a.vUpdUser.localeCompare(b.vUpdUser);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_SubContentId:
                    return (a, b) => {
                        return a.subContentId.localeCompare(b.subContentId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vDiscussionSubContent]中不存在！(in ${exports.vDiscussionSubContent_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_SubContent:
                    return (a, b) => {
                        return b.subContent.localeCompare(a.subContent);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_TopicsId:
                    return (a, b) => {
                        return b.topicsId.localeCompare(a.topicsId);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_topicsTitle:
                    return (a, b) => {
                        return b.topicsTitle.localeCompare(a.topicsTitle);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_IsTop:
                    return (a, b) => {
                        if (b.isTop == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_CollegeName:
                    return (a, b) => {
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_XzCollege:
                    return (a, b) => {
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_BrowseNumber:
                    return (a, b) => {
                        return b.browseNumber - a.browseNumber;
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_ParentId:
                    return (a, b) => {
                        return b.parentId.localeCompare(a.parentId);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_TopicsContent:
                    return (a, b) => {
                        return b.topicsContent.localeCompare(a.topicsContent);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_vUpdDate:
                    return (a, b) => {
                        return b.vUpdDate.localeCompare(a.vUpdDate);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_vUpdUser:
                    return (a, b) => {
                        return b.vUpdUser.localeCompare(a.vUpdUser);
                    };
                case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_SubContentId:
                    return (a, b) => {
                        return b.subContentId.localeCompare(a.subContentId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vDiscussionSubContent]中不存在！(in ${exports.vDiscussionSubContent_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vDiscussionSubContent_SortFunByKey = vDiscussionSubContent_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vDiscussionSubContent_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_SubContent:
                return (obj) => {
                    return obj.subContent === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_TopicsId:
                return (obj) => {
                    return obj.topicsId === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_topicsTitle:
                return (obj) => {
                    return obj.topicsTitle === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_IsTop:
                return (obj) => {
                    return obj.isTop === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_BrowseNumber:
                return (obj) => {
                    return obj.browseNumber === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_ParentId:
                return (obj) => {
                    return obj.parentId === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_TopicsContent:
                return (obj) => {
                    return obj.topicsContent === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_vUpdDate:
                return (obj) => {
                    return obj.vUpdDate === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_vUpdUser:
                return (obj) => {
                    return obj.vUpdUser === value;
                };
            case clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_SubContentId:
                return (obj) => {
                    return obj.subContentId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vDiscussionSubContent]中不存在！(in ${exports.vDiscussionSubContent_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vDiscussionSubContent_FilterFunByKey = vDiscussionSubContent_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vDiscussionSubContent_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionSubContent_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionSubContent_GetFirstIDAsync = vDiscussionSubContent_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vDiscussionSubContent_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionSubContent_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionSubContent_GetFirstID = vDiscussionSubContent_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vDiscussionSubContent_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvDiscussionSubContent = vDiscussionSubContent_GetObjFromJsonObj(returnObj);
                return objvDiscussionSubContent;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionSubContent_GetFirstObjAsync = vDiscussionSubContent_GetFirstObjAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vDiscussionSubContent_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vDiscussionSubContent_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionSubContent_GetObjLstAsync = vDiscussionSubContent_GetObjLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrSubContentId:关键字列表
    * @returns 对象列表
    **/
    async function vDiscussionSubContent_GetObjLstBySubContentIdLstAsync(arrSubContentId) {
        const strThisFuncName = "GetObjLstBySubContentIdLstAsync";
        const strAction = "GetObjLstBySubContentIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSubContentId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vDiscussionSubContent_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionSubContent_GetObjLstBySubContentIdLstAsync = vDiscussionSubContent_GetObjLstBySubContentIdLstAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vDiscussionSubContent_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vDiscussionSubContent_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionSubContent_GetTopObjLstAsync = vDiscussionSubContent_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vDiscussionSubContent_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vDiscussionSubContent_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionSubContent_GetObjLstByRangeAsync = vDiscussionSubContent_GetObjLstByRangeAsync;
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
    async function vDiscussionSubContent_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionSubContent_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionSubContent_GetObjLstByRange = vDiscussionSubContent_GetObjLstByRange;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vDiscussionSubContent_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vDiscussionSubContent_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionSubContent_GetObjLstByPagerAsync = vDiscussionSubContent_GetObjLstByPagerAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vDiscussionSubContent_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionSubContent_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionSubContent_IsExistRecordAsync = vDiscussionSubContent_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strSubContentId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vDiscussionSubContent_IsExist(strSubContentId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "subContentId": strSubContentId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionSubContent_IsExist = vDiscussionSubContent_IsExist;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strSubContentId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vDiscussionSubContent_IsExistAsync(strSubContentId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionSubContent_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strSubContentId": strSubContentId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionSubContent_IsExistAsync = vDiscussionSubContent_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vDiscussionSubContent_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionSubContent_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionSubContent_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionSubContent_GetRecCountByCondAsync = vDiscussionSubContent_GetRecCountByCondAsync;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vDiscussionSubContent_GetWebApiUrl(strController, strAction) {
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
    exports.vDiscussionSubContent_GetWebApiUrl = vDiscussionSubContent_GetWebApiUrl;
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
    function vDiscussionSubContent_GetJSONStrByObj(pobjvDiscussionSubContentEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvDiscussionSubContentEN);
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
    exports.vDiscussionSubContent_GetJSONStrByObj = vDiscussionSubContent_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vDiscussionSubContent_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvDiscussionSubContentObjLst = new Array();
        if (strJSON === "") {
            return arrvDiscussionSubContentObjLst;
        }
        try {
            arrvDiscussionSubContentObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvDiscussionSubContentObjLst;
        }
        return arrvDiscussionSubContentObjLst;
    }
    exports.vDiscussionSubContent_GetObjLstByJSONStr = vDiscussionSubContent_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvDiscussionSubContentObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vDiscussionSubContent_GetObjLstByJSONObjLst(arrvDiscussionSubContentObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvDiscussionSubContentObjLst = new Array();
        for (const objInFor of arrvDiscussionSubContentObjLstS) {
            const obj1 = vDiscussionSubContent_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvDiscussionSubContentObjLst.push(obj1);
        }
        return arrvDiscussionSubContentObjLst;
    }
    exports.vDiscussionSubContent_GetObjLstByJSONObjLst = vDiscussionSubContent_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vDiscussionSubContent_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvDiscussionSubContentEN = new clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN();
        if (strJSON === "") {
            return pobjvDiscussionSubContentEN;
        }
        try {
            pobjvDiscussionSubContentEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvDiscussionSubContentEN;
        }
        return pobjvDiscussionSubContentEN;
    }
    exports.vDiscussionSubContent_GetObjByJSONStr = vDiscussionSubContent_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vDiscussionSubContent_GetCombineCondition(objvDiscussionSubContent_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_TopicsId) == true) {
            const strComparisonOp_TopicsId = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_TopicsId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_TopicsId, objvDiscussionSubContent_Cond.topicsId, strComparisonOp_TopicsId);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_topicsTitle) == true) {
            const strComparisonOp_topicsTitle = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_topicsTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_topicsTitle, objvDiscussionSubContent_Cond.topicsTitle, strComparisonOp_topicsTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_IsTop) == true) {
            if (objvDiscussionSubContent_Cond.isTop == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_IsTop);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_IsTop);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UpdDate, objvDiscussionSubContent_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UpdUser, objvDiscussionSubContent_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_Memo, objvDiscussionSubContent_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_CollegeName, objvDiscussionSubContent_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_XzCollege, objvDiscussionSubContent_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_XzMajor, objvDiscussionSubContent_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_MajorName, objvDiscussionSubContent_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UserName, objvDiscussionSubContent_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_BrowseNumber) == true) {
            const strComparisonOp_BrowseNumber = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_BrowseNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_BrowseNumber, objvDiscussionSubContent_Cond.browseNumber, strComparisonOp_BrowseNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_id_CurrEduCls, objvDiscussionSubContent_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_ParentId) == true) {
            const strComparisonOp_ParentId = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_ParentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_ParentId, objvDiscussionSubContent_Cond.parentId, strComparisonOp_ParentId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UserId) == true) {
            const strComparisonOp_UserId = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_UserId, objvDiscussionSubContent_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_vUpdDate) == true) {
            const strComparisonOp_vUpdDate = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_vUpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_vUpdDate, objvDiscussionSubContent_Cond.vUpdDate, strComparisonOp_vUpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_vUpdUser) == true) {
            const strComparisonOp_vUpdUser = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_vUpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_vUpdUser, objvDiscussionSubContent_Cond.vUpdUser, strComparisonOp_vUpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionSubContent_Cond.dicFldComparisonOp, clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_SubContentId) == true) {
            const strComparisonOp_SubContentId = objvDiscussionSubContent_Cond.dicFldComparisonOp[clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_SubContentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN.con_SubContentId, objvDiscussionSubContent_Cond.subContentId, strComparisonOp_SubContentId);
        }
        return strWhereCond;
    }
    exports.vDiscussionSubContent_GetCombineCondition = vDiscussionSubContent_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--vDiscussionSubContent(v讨论子内容视图),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strSubContentId: 字内容Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vDiscussionSubContent_GetUniCondStr_SubContentId(objvDiscussionSubContentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and subContentId = '{0}'", objvDiscussionSubContentEN.subContentId);
        return strWhereCond;
    }
    exports.vDiscussionSubContent_GetUniCondStr_SubContentId = vDiscussionSubContent_GetUniCondStr_SubContentId;
    /**
    *获取唯一性条件串(Uniqueness)--vDiscussionSubContent(v讨论子内容视图),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strSubContentId: 字内容Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vDiscussionSubContent_GetUniCondStr4Update_SubContentId(objvDiscussionSubContentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and subContentId <> '{0}'", objvDiscussionSubContentEN.subContentId);
        strWhereCond += (0, clsString_js_1.Format)(" and subContentId = '{0}'", objvDiscussionSubContentEN.subContentId);
        return strWhereCond;
    }
    exports.vDiscussionSubContent_GetUniCondStr4Update_SubContentId = vDiscussionSubContent_GetUniCondStr4Update_SubContentId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvDiscussionSubContentENS:源对象
     * @param objvDiscussionSubContentENT:目标对象
    */
    function vDiscussionSubContent_CopyObjTo(objvDiscussionSubContentENS, objvDiscussionSubContentENT) {
        objvDiscussionSubContentENT.subContent = objvDiscussionSubContentENS.subContent; //子内容
        objvDiscussionSubContentENT.topicsId = objvDiscussionSubContentENS.topicsId; //主题Id
        objvDiscussionSubContentENT.topicsTitle = objvDiscussionSubContentENS.topicsTitle; //主题标题
        objvDiscussionSubContentENT.isTop = objvDiscussionSubContentENS.isTop; //是否置顶
        objvDiscussionSubContentENT.updDate = objvDiscussionSubContentENS.updDate; //修改日期
        objvDiscussionSubContentENT.updUser = objvDiscussionSubContentENS.updUser; //修改人
        objvDiscussionSubContentENT.memo = objvDiscussionSubContentENS.memo; //备注
        objvDiscussionSubContentENT.collegeName = objvDiscussionSubContentENS.collegeName; //学院名称
        objvDiscussionSubContentENT.id_XzCollege = objvDiscussionSubContentENS.id_XzCollege; //学院流水号
        objvDiscussionSubContentENT.id_XzMajor = objvDiscussionSubContentENS.id_XzMajor; //专业流水号
        objvDiscussionSubContentENT.majorName = objvDiscussionSubContentENS.majorName; //专业名称
        objvDiscussionSubContentENT.userName = objvDiscussionSubContentENS.userName; //用户名
        objvDiscussionSubContentENT.browseNumber = objvDiscussionSubContentENS.browseNumber; //浏览量
        objvDiscussionSubContentENT.id_CurrEduCls = objvDiscussionSubContentENS.id_CurrEduCls; //教学班流水号
        objvDiscussionSubContentENT.parentId = objvDiscussionSubContentENS.parentId; //父节点Id
        objvDiscussionSubContentENT.topicsContent = objvDiscussionSubContentENS.topicsContent; //主题内容
        objvDiscussionSubContentENT.userId = objvDiscussionSubContentENS.userId; //用户ID
        objvDiscussionSubContentENT.vUpdDate = objvDiscussionSubContentENS.vUpdDate; //vUpdDate
        objvDiscussionSubContentENT.vUpdUser = objvDiscussionSubContentENS.vUpdUser; //vUpdUser
        objvDiscussionSubContentENT.subContentId = objvDiscussionSubContentENS.subContentId; //字内容Id
    }
    exports.vDiscussionSubContent_CopyObjTo = vDiscussionSubContent_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvDiscussionSubContentENS:源对象
     * @param objvDiscussionSubContentENT:目标对象
    */
    function vDiscussionSubContent_GetObjFromJsonObj(objvDiscussionSubContentENS) {
        const objvDiscussionSubContentENT = new clsvDiscussionSubContentEN_js_1.clsvDiscussionSubContentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvDiscussionSubContentENT, objvDiscussionSubContentENS);
        return objvDiscussionSubContentENT;
    }
    exports.vDiscussionSubContent_GetObjFromJsonObj = vDiscussionSubContent_GetObjFromJsonObj;
});
