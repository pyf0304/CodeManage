/**
* 类名:clsgs_TeacherTaskWApi
* 表名:gs_TeacherTask(01120686)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:49:47
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsgs_TeacherTaskEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_TeacherTask_GetObjFromJsonObj = exports.gs_TeacherTask_CopyObjTo = exports.gs_TeacherTask_GetUniCondStr4Update_mId = exports.gs_TeacherTask_GetUniCondStr_mId = exports.gs_TeacherTask_GetCombineCondition = exports.gs_TeacherTask_GetObjByJSONStr = exports.gs_TeacherTask_GetObjLstByJSONObjLst = exports.gs_TeacherTask_GetObjLstByJSONStr = exports.gs_TeacherTask_GetJSONStrByObj = exports.gs_TeacherTask_CheckProperty4Update = exports.gs_TeacherTask_CheckPropertyNew = exports.gs_TeacherTask_ReFreshThisCache = exports.gs_TeacherTask_ReFreshCache = exports.gs_TeacherTask_GetWebApiUrl = exports.gs_TeacherTask_GetMaxStrIdByPrefix = exports.gs_TeacherTask_GetRecCountByCond_Cache = exports.gs_TeacherTask_GetRecCountByCondAsync = exports.gs_TeacherTask_IsExistAsync = exports.gs_TeacherTask_IsExist_Cache = exports.gs_TeacherTask_IsExist = exports.gs_TeacherTask_IsExistRecordAsync = exports.gs_TeacherTask_IsExistRecord_Cache = exports.gs_TeacherTask_UpdateWithConditionAsync = exports.gs_TeacherTask_UpdateRecordAsync = exports.gs_TeacherTask_AddNewRecordWithReturnKey = exports.gs_TeacherTask_AddNewRecordWithReturnKeyAsync = exports.gs_TeacherTask_AddNewRecordAsync = exports.gs_TeacherTask_Delgs_TeacherTasksByCondAsync = exports.gs_TeacherTask_Delgs_TeacherTasksAsync = exports.gs_TeacherTask_DelRecordAsync = exports.gs_TeacherTask_GetObjLstByPagerAsync = exports.gs_TeacherTask_GetObjLstByPager_Cache = exports.gs_TeacherTask_GetObjLstByRange = exports.gs_TeacherTask_GetObjLstByRangeAsync = exports.gs_TeacherTask_GetTopObjLstAsync = exports.gs_TeacherTask_GetObjLstBymIdLst_Cache = exports.gs_TeacherTask_GetObjLstBymIdLstAsync = exports.gs_TeacherTask_GetSubObjLst_Cache = exports.gs_TeacherTask_GetObjLst_PureCache = exports.gs_TeacherTask_GetObjLst_Cache = exports.gs_TeacherTask_GetObjLst_sessionStorage_PureCache = exports.gs_TeacherTask_GetObjLst_sessionStorage = exports.gs_TeacherTask_GetObjLstAsync = exports.gs_TeacherTask_GetObjLst_localStorage_PureCache = exports.gs_TeacherTask_GetObjLst_localStorage = exports.gs_TeacherTask_GetObjLst_ClientCache = exports.gs_TeacherTask_GetFirstObjAsync = exports.gs_TeacherTask_GetFirstID = exports.gs_TeacherTask_GetFirstIDAsync = exports.gs_TeacherTask_funcKey = exports.gs_TeacherTask_FilterFunByKey = exports.gs_TeacherTask_SortFunByKey = exports.gs_TeacherTask_SortFun_Defa_2Fld = exports.gs_TeacherTask_SortFun_Defa = exports.gs_TeacherTask_func = exports.gs_TeacherTask_UpdateObjInLst_Cache = exports.gs_TeacherTask_GetObjBymId_localStorage = exports.gs_TeacherTask_GetObjBymId_Cache = exports.gs_TeacherTask_GetObjBymIdAsync = exports.gs_TeacherTask_ConstructorName = exports.gs_TeacherTask_Controller = void 0;
    /**
     * 教师任务(gs_TeacherTask)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_TeacherTaskEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_TeacherTaskEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.gs_TeacherTask_Controller = "gs_TeacherTaskApi";
    exports.gs_TeacherTask_ConstructorName = "gs_TeacherTask";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function gs_TeacherTask_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngmId]不能为空！(In clsgs_TeacherTaskWApi.GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
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
                    return null;
                }
                //console.log(returnObj);
                const objgs_TeacherTask = gs_TeacherTask_GetObjFromJsonObj(returnObj);
                return objgs_TeacherTask;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_GetObjBymIdAsync = gs_TeacherTask_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_TeacherTask_GetObjBymId_Cache(lngmId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngmId]不能为空！(In clsgs_TeacherTaskWApi.GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_Cache();
        try {
            const arrgs_TeacherTask_Sel = arrgs_TeacherTaskObjLst_Cache.filter(x => x.mId == lngmId);
            let objgs_TeacherTask;
            if (arrgs_TeacherTask_Sel.length > 0) {
                objgs_TeacherTask = arrgs_TeacherTask_Sel[0];
                return objgs_TeacherTask;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objgs_TeacherTask_Const = await gs_TeacherTask_GetObjBymIdAsync(lngmId);
                    if (objgs_TeacherTask_Const != null) {
                        gs_TeacherTask_ReFreshThisCache();
                        return objgs_TeacherTask_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_TeacherTask_GetObjBymId_Cache = gs_TeacherTask_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_TeacherTask_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngmId]不能为空！(In clsgs_TeacherTaskWApi.GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_TeacherTask_Cache = JSON.parse(strTempObj);
            return objgs_TeacherTask_Cache;
        }
        try {
            const objgs_TeacherTask = await gs_TeacherTask_GetObjBymIdAsync(lngmId);
            if (objgs_TeacherTask != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_TeacherTask));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_TeacherTask;
            }
            return objgs_TeacherTask;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_TeacherTask_GetObjBymId_localStorage = gs_TeacherTask_GetObjBymId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_TeacherTask:所给的对象
     * @returns 对象
    */
    async function gs_TeacherTask_UpdateObjInLst_Cache(objgs_TeacherTask) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_Cache();
            const obj = arrgs_TeacherTaskObjLst_Cache.find(x => x.mId == objgs_TeacherTask.mId);
            if (obj != null) {
                objgs_TeacherTask.mId = obj.mId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_TeacherTask);
            }
            else {
                arrgs_TeacherTaskObjLst_Cache.push(objgs_TeacherTask);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_TeacherTask_UpdateObjInLst_Cache = gs_TeacherTask_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function gs_TeacherTask_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_mId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objgs_TeacherTask = await gs_TeacherTask_GetObjBymId_Cache(lngmId);
        if (objgs_TeacherTask == null)
            return "";
        if (objgs_TeacherTask.GetFldValue(strOutFldName) == null)
            return "";
        return objgs_TeacherTask.GetFldValue(strOutFldName).toString();
    }
    exports.gs_TeacherTask_func = gs_TeacherTask_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TeacherTask_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.gs_TeacherTask_SortFun_Defa = gs_TeacherTask_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TeacherTask_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.gs_TeacherTask_SortFun_Defa_2Fld = gs_TeacherTask_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TeacherTask_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_TopicId:
                    return (a, b) => {
                        if (a.topicId == null)
                            return -1;
                        if (b.topicId == null)
                            return 1;
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_MissionStatement:
                    return (a, b) => {
                        if (a.missionStatement == null)
                            return -1;
                        if (b.missionStatement == null)
                            return 1;
                        return a.missionStatement.localeCompare(b.missionStatement);
                    };
                case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_MissionRequirement:
                    return (a, b) => {
                        if (a.missionRequirement == null)
                            return -1;
                        if (b.missionRequirement == null)
                            return 1;
                        return a.missionRequirement.localeCompare(b.missionRequirement);
                    };
                case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_TeacherTask]中不存在！(in ${exports.gs_TeacherTask_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_TopicId:
                    return (a, b) => {
                        if (b.topicId == null)
                            return -1;
                        if (a.topicId == null)
                            return 1;
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_MissionStatement:
                    return (a, b) => {
                        if (b.missionStatement == null)
                            return -1;
                        if (a.missionStatement == null)
                            return 1;
                        return b.missionStatement.localeCompare(a.missionStatement);
                    };
                case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_MissionRequirement:
                    return (a, b) => {
                        if (b.missionRequirement == null)
                            return -1;
                        if (a.missionRequirement == null)
                            return 1;
                        return b.missionRequirement.localeCompare(a.missionRequirement);
                    };
                case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_TeacherTask]中不存在！(in ${exports.gs_TeacherTask_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_TeacherTask_SortFunByKey = gs_TeacherTask_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_TeacherTask_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_MissionStatement:
                return (obj) => {
                    return obj.missionStatement === value;
                };
            case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_MissionRequirement:
                return (obj) => {
                    return obj.missionRequirement === value;
                };
            case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_TeacherTask]中不存在！(in ${exports.gs_TeacherTask_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_TeacherTask_FilterFunByKey = gs_TeacherTask_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function gs_TeacherTask_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_mId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrgs_TeacherTask = await gs_TeacherTask_GetObjLst_Cache();
        if (arrgs_TeacherTask == null)
            return [];
        let arrgs_TeacherTask_Sel = arrgs_TeacherTask;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrgs_TeacherTask_Sel.length == 0)
            return [];
        return arrgs_TeacherTask_Sel.map(x => x.mId);
    }
    exports.gs_TeacherTask_funcKey = gs_TeacherTask_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_TeacherTask_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_GetFirstIDAsync = gs_TeacherTask_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_TeacherTask_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_GetFirstID = gs_TeacherTask_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_TeacherTask_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
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
                const objgs_TeacherTask = gs_TeacherTask_GetObjFromJsonObj(returnObj);
                return objgs_TeacherTask;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_GetFirstObjAsync = gs_TeacherTask_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TeacherTask_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_TeacherTaskExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrgs_TeacherTaskObjLst_T = gs_TeacherTask_GetObjLstByJSONObjLst(arrgs_TeacherTaskExObjLst_Cache);
            return arrgs_TeacherTaskObjLst_T;
        }
        try {
            const arrgs_TeacherTaskExObjLst = await gs_TeacherTask_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrgs_TeacherTaskExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TeacherTaskExObjLst.length);
            console.log(strInfo);
            return arrgs_TeacherTaskExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_TeacherTask_GetObjLst_ClientCache = gs_TeacherTask_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TeacherTask_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_TeacherTaskExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_TeacherTaskObjLst_T = gs_TeacherTask_GetObjLstByJSONObjLst(arrgs_TeacherTaskExObjLst_Cache);
            return arrgs_TeacherTaskObjLst_T;
        }
        try {
            const arrgs_TeacherTaskExObjLst = await gs_TeacherTask_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_TeacherTaskExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TeacherTaskExObjLst.length);
            console.log(strInfo);
            return arrgs_TeacherTaskExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_TeacherTask_GetObjLst_localStorage = gs_TeacherTask_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TeacherTask_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_TeacherTaskObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_TeacherTaskObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_TeacherTask_GetObjLst_localStorage_PureCache = gs_TeacherTask_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_TeacherTask_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TeacherTask_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_GetObjLstAsync = gs_TeacherTask_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TeacherTask_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_TeacherTaskExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_TeacherTaskObjLst_T = gs_TeacherTask_GetObjLstByJSONObjLst(arrgs_TeacherTaskExObjLst_Cache);
            return arrgs_TeacherTaskObjLst_T;
        }
        try {
            const arrgs_TeacherTaskExObjLst = await gs_TeacherTask_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_TeacherTaskExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TeacherTaskExObjLst.length);
            console.log(strInfo);
            return arrgs_TeacherTaskExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_TeacherTask_GetObjLst_sessionStorage = gs_TeacherTask_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TeacherTask_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_TeacherTaskObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_TeacherTaskObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_TeacherTask_GetObjLst_sessionStorage_PureCache = gs_TeacherTask_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TeacherTask_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrgs_TeacherTaskObjLst_Cache;
        switch (clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_ClientCache();
                break;
            default:
                arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_ClientCache();
                break;
        }
        const arrgs_TeacherTaskObjLst = gs_TeacherTask_GetObjLstByJSONObjLst(arrgs_TeacherTaskObjLst_Cache);
        return arrgs_TeacherTaskObjLst_Cache;
    }
    exports.gs_TeacherTask_GetObjLst_Cache = gs_TeacherTask_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TeacherTask_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_TeacherTaskObjLst_Cache;
        switch (clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrgs_TeacherTaskObjLst_Cache = null;
                break;
            default:
                arrgs_TeacherTaskObjLst_Cache = null;
                break;
        }
        return arrgs_TeacherTaskObjLst_Cache;
    }
    exports.gs_TeacherTask_GetObjLst_PureCache = gs_TeacherTask_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_TeacherTask_GetSubObjLst_Cache(objgs_TeacherTask_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_Cache();
        let arrgs_TeacherTask_Sel = arrgs_TeacherTaskObjLst_Cache;
        if (objgs_TeacherTask_Cond.sf_FldComparisonOp == null || objgs_TeacherTask_Cond.sf_FldComparisonOp == "")
            return arrgs_TeacherTask_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_TeacherTask_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TeacherTaskWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_TeacherTask_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TeacherTask_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_TeacherTask_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_TeacherTask_Cond), exports.gs_TeacherTask_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TeacherTask_GetSubObjLst_Cache = gs_TeacherTask_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function gs_TeacherTask_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TeacherTask_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_GetObjLstBymIdLstAsync = gs_TeacherTask_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_TeacherTask_GetObjLstBymIdLst_Cache(arrmIdLst) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_Cache();
            const arrgs_TeacherTask_Sel = arrgs_TeacherTaskObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrgs_TeacherTask_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.gs_TeacherTask_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.gs_TeacherTask_GetObjLstBymIdLst_Cache = gs_TeacherTask_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_TeacherTask_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TeacherTask_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_GetTopObjLstAsync = gs_TeacherTask_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_TeacherTask_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TeacherTask_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_GetObjLstByRangeAsync = gs_TeacherTask_GetObjLstByRangeAsync;
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
    async function gs_TeacherTask_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_GetObjLstByRange = gs_TeacherTask_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_TeacherTask_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_Cache();
        if (arrgs_TeacherTaskObjLst_Cache.length == 0)
            return arrgs_TeacherTaskObjLst_Cache;
        let arrgs_TeacherTask_Sel = arrgs_TeacherTaskObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_TeacherTask_Cond = new clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TeacherTask_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_TeacherTaskWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TeacherTask_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_TeacherTask_Sel.length == 0)
                return arrgs_TeacherTask_Sel;
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
                arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.sort(gs_TeacherTask_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.slice(intStart, intEnd);
            return arrgs_TeacherTask_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TeacherTask_GetObjLstByPager_Cache = gs_TeacherTask_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_TeacherTask_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TeacherTask_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_GetObjLstByPagerAsync = gs_TeacherTask_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_TeacherTask_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngmId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_DelRecordAsync = gs_TeacherTask_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_TeacherTask_Delgs_TeacherTasksAsync(arrmId) {
        const strThisFuncName = "Delgs_TeacherTasksAsync";
        const strAction = "Delgs_TeacherTasks";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_Delgs_TeacherTasksAsync = gs_TeacherTask_Delgs_TeacherTasksAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_TeacherTask_Delgs_TeacherTasksByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_TeacherTasksByCondAsync";
        const strAction = "Delgs_TeacherTasksByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_Delgs_TeacherTasksByCondAsync = gs_TeacherTask_Delgs_TeacherTasksByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_TeacherTaskEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_TeacherTask_AddNewRecordAsync(objgs_TeacherTaskEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_TeacherTaskEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TeacherTaskEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_AddNewRecordAsync = gs_TeacherTask_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_TeacherTaskEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_TeacherTask_AddNewRecordWithReturnKeyAsync(objgs_TeacherTaskEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TeacherTaskEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_AddNewRecordWithReturnKeyAsync = gs_TeacherTask_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_TeacherTaskEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_TeacherTask_AddNewRecordWithReturnKey(objgs_TeacherTaskEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_TeacherTaskEN.mId === null || objgs_TeacherTaskEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TeacherTaskEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_AddNewRecordWithReturnKey = gs_TeacherTask_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_TeacherTaskEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_TeacherTask_UpdateRecordAsync(objgs_TeacherTaskEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_TeacherTaskEN.sf_UpdFldSetStr === undefined || objgs_TeacherTaskEN.sf_UpdFldSetStr === null || objgs_TeacherTaskEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TeacherTaskEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TeacherTaskEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_UpdateRecordAsync = gs_TeacherTask_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_TeacherTaskEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_TeacherTask_UpdateWithConditionAsync(objgs_TeacherTaskEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_TeacherTaskEN.sf_UpdFldSetStr === undefined || objgs_TeacherTaskEN.sf_UpdFldSetStr === null || objgs_TeacherTaskEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TeacherTaskEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
        objgs_TeacherTaskEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_TeacherTaskEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_UpdateWithConditionAsync = gs_TeacherTask_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_TeacherTask_IsExistRecord_Cache(objgs_TeacherTask_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_Cache();
        if (arrgs_TeacherTaskObjLst_Cache == null)
            return false;
        let arrgs_TeacherTask_Sel = arrgs_TeacherTaskObjLst_Cache;
        if (objgs_TeacherTask_Cond.sf_FldComparisonOp == null || objgs_TeacherTask_Cond.sf_FldComparisonOp == "")
            return arrgs_TeacherTask_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_TeacherTask_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TeacherTaskWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_TeacherTask_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TeacherTask_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_TeacherTask_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_TeacherTask_Cond), exports.gs_TeacherTask_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_TeacherTask_IsExistRecord_Cache = gs_TeacherTask_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_TeacherTask_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_IsExistRecordAsync = gs_TeacherTask_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_TeacherTask_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_IsExist = gs_TeacherTask_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function gs_TeacherTask_IsExist_Cache(lngmId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_Cache();
        if (arrgs_TeacherTaskObjLst_Cache == null)
            return false;
        try {
            const arrgs_TeacherTask_Sel = arrgs_TeacherTaskObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrgs_TeacherTask_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_TeacherTask_IsExist_Cache = gs_TeacherTask_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_TeacherTask_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_IsExistAsync = gs_TeacherTask_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_TeacherTask_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_GetRecCountByCondAsync = gs_TeacherTask_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_TeacherTask_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_TeacherTask_GetRecCountByCond_Cache(objgs_TeacherTask_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_TeacherTaskObjLst_Cache = await gs_TeacherTask_GetObjLst_Cache();
        if (arrgs_TeacherTaskObjLst_Cache == null)
            return 0;
        let arrgs_TeacherTask_Sel = arrgs_TeacherTaskObjLst_Cache;
        if (objgs_TeacherTask_Cond.sf_FldComparisonOp == null || objgs_TeacherTask_Cond.sf_FldComparisonOp == "")
            return arrgs_TeacherTask_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_TeacherTask_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TeacherTaskWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_TeacherTask_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TeacherTask_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TeacherTask_Sel = arrgs_TeacherTask_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_TeacherTask_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_TeacherTask_Cond), exports.gs_TeacherTask_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_TeacherTask_GetRecCountByCond_Cache = gs_TeacherTask_GetRecCountByCond_Cache;
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
    async function gs_TeacherTask_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TeacherTask_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TeacherTask_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TeacherTask_GetMaxStrIdByPrefix = gs_TeacherTask_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_TeacherTask_GetWebApiUrl(strController, strAction) {
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
    exports.gs_TeacherTask_GetWebApiUrl = gs_TeacherTask_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_TeacherTask_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN._CurrTabName;
        switch (clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.CacheModeId) {
            case "04": //sessionStorage
                sessionStorage.removeItem(strKey);
                break;
            case "03": //localStorage
                localStorage.removeItem(strKey);
                break;
            case "02": //ClientCache
                CacheHelper_js_1.CacheHelper.Remove(strKey);
                break;
            default:
                CacheHelper_js_1.CacheHelper.Remove(strKey);
                break;
        }
    }
    exports.gs_TeacherTask_ReFreshCache = gs_TeacherTask_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_TeacherTask_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN._CurrTabName;
            switch (clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.CacheModeId) {
                case "04": //sessionStorage
                    sessionStorage.removeItem(strKey);
                    break;
                case "03": //localStorage
                    localStorage.removeItem(strKey);
                    break;
                case "02": //ClientCache
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
                    break;
                default:
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
                    break;
            }
            const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
            console.trace(strMsg);
        }
        else {
            const strMsg = (0, clsString_js_2.Format)("刷新缓存已经关闭。");
            console.trace(strMsg);
        }
    }
    exports.gs_TeacherTask_ReFreshThisCache = gs_TeacherTask_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_TeacherTask_CheckPropertyNew(pobjgs_TeacherTaskEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.id_CurrEduCls) === true
            || pobjgs_TeacherTaskEN.id_CurrEduCls.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[教学班流水号]不能为空(In 教师任务)!(clsgs_TeacherTaskBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TeacherTaskEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.topicId)(clsgs_TeacherTaskBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TeacherTaskEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.id_CurrEduCls)(clsgs_TeacherTaskBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.missionStatement) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TeacherTaskEN.missionStatement) > 2000) {
            throw new Error("(errid:Watl000059)字段[任务说明(missionStatement)]的长度不能超过2000(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.missionStatement)(clsgs_TeacherTaskBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.missionRequirement) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TeacherTaskEN.missionRequirement) > 2000) {
            throw new Error("(errid:Watl000059)字段[任务要求(missionRequirement)]的长度不能超过2000(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.missionRequirement)(clsgs_TeacherTaskBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TeacherTaskEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.updDate)(clsgs_TeacherTaskBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TeacherTaskEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.updUser)(clsgs_TeacherTaskBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TeacherTaskEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.memo)(clsgs_TeacherTaskBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_TeacherTaskEN.mId && undefined !== pobjgs_TeacherTaskEN.mId && clsString_js_1.tzDataType.isNumber(pobjgs_TeacherTaskEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_TeacherTaskEN.mId)], 非法，应该为数值型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.topicId) == false && undefined !== pobjgs_TeacherTaskEN.topicId && clsString_js_1.tzDataType.isString(pobjgs_TeacherTaskEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_TeacherTaskEN.topicId)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.id_CurrEduCls) == false && undefined !== pobjgs_TeacherTaskEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjgs_TeacherTaskEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TeacherTaskEN.id_CurrEduCls)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.missionStatement) == false && undefined !== pobjgs_TeacherTaskEN.missionStatement && clsString_js_1.tzDataType.isString(pobjgs_TeacherTaskEN.missionStatement) === false) {
            throw new Error("(errid:Watl000060)字段[任务说明(missionStatement)]的值:[$(pobjgs_TeacherTaskEN.missionStatement)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.missionRequirement) == false && undefined !== pobjgs_TeacherTaskEN.missionRequirement && clsString_js_1.tzDataType.isString(pobjgs_TeacherTaskEN.missionRequirement) === false) {
            throw new Error("(errid:Watl000060)字段[任务要求(missionRequirement)]的值:[$(pobjgs_TeacherTaskEN.missionRequirement)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.updDate) == false && undefined !== pobjgs_TeacherTaskEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_TeacherTaskEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TeacherTaskEN.updDate)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.updUser) == false && undefined !== pobjgs_TeacherTaskEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_TeacherTaskEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TeacherTaskEN.updUser)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.memo) == false && undefined !== pobjgs_TeacherTaskEN.memo && clsString_js_1.tzDataType.isString(pobjgs_TeacherTaskEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TeacherTaskEN.memo)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_TeacherTaskEN.SetIsCheckProperty(true);
    }
    exports.gs_TeacherTask_CheckPropertyNew = gs_TeacherTask_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_TeacherTask_CheckProperty4Update(pobjgs_TeacherTaskEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TeacherTaskEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.topicId)(clsgs_TeacherTaskBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TeacherTaskEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.id_CurrEduCls)(clsgs_TeacherTaskBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.missionStatement) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TeacherTaskEN.missionStatement) > 2000) {
            throw new Error("(errid:Watl000062)字段[任务说明(missionStatement)]的长度不能超过2000(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.missionStatement)(clsgs_TeacherTaskBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.missionRequirement) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TeacherTaskEN.missionRequirement) > 2000) {
            throw new Error("(errid:Watl000062)字段[任务要求(missionRequirement)]的长度不能超过2000(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.missionRequirement)(clsgs_TeacherTaskBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TeacherTaskEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.updDate)(clsgs_TeacherTaskBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TeacherTaskEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.updUser)(clsgs_TeacherTaskBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TeacherTaskEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 教师任务(gs_TeacherTask))!值:$(pobjgs_TeacherTaskEN.memo)(clsgs_TeacherTaskBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_TeacherTaskEN.mId && undefined !== pobjgs_TeacherTaskEN.mId && clsString_js_1.tzDataType.isNumber(pobjgs_TeacherTaskEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_TeacherTaskEN.mId)], 非法，应该为数值型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.topicId) == false && undefined !== pobjgs_TeacherTaskEN.topicId && clsString_js_1.tzDataType.isString(pobjgs_TeacherTaskEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_TeacherTaskEN.topicId)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.id_CurrEduCls) == false && undefined !== pobjgs_TeacherTaskEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjgs_TeacherTaskEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TeacherTaskEN.id_CurrEduCls)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.missionStatement) == false && undefined !== pobjgs_TeacherTaskEN.missionStatement && clsString_js_1.tzDataType.isString(pobjgs_TeacherTaskEN.missionStatement) === false) {
            throw new Error("(errid:Watl000063)字段[任务说明(missionStatement)]的值:[$(pobjgs_TeacherTaskEN.missionStatement)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.missionRequirement) == false && undefined !== pobjgs_TeacherTaskEN.missionRequirement && clsString_js_1.tzDataType.isString(pobjgs_TeacherTaskEN.missionRequirement) === false) {
            throw new Error("(errid:Watl000063)字段[任务要求(missionRequirement)]的值:[$(pobjgs_TeacherTaskEN.missionRequirement)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.updDate) == false && undefined !== pobjgs_TeacherTaskEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_TeacherTaskEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TeacherTaskEN.updDate)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.updUser) == false && undefined !== pobjgs_TeacherTaskEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_TeacherTaskEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TeacherTaskEN.updUser)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TeacherTaskEN.memo) == false && undefined !== pobjgs_TeacherTaskEN.memo && clsString_js_1.tzDataType.isString(pobjgs_TeacherTaskEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TeacherTaskEN.memo)], 非法，应该为字符型(In 教师任务(gs_TeacherTask))!(clsgs_TeacherTaskBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_TeacherTaskEN.mId
            || pobjgs_TeacherTaskEN.mId != null && pobjgs_TeacherTaskEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 教师任务)!(clsgs_TeacherTaskBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_TeacherTaskEN.SetIsCheckProperty(true);
    }
    exports.gs_TeacherTask_CheckProperty4Update = gs_TeacherTask_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_TeacherTask_GetJSONStrByObj(pobjgs_TeacherTaskEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_TeacherTaskEN.sf_UpdFldSetStr = pobjgs_TeacherTaskEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_TeacherTaskEN);
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
    exports.gs_TeacherTask_GetJSONStrByObj = gs_TeacherTask_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_TeacherTask_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_TeacherTaskObjLst = new Array();
        if (strJSON === "") {
            return arrgs_TeacherTaskObjLst;
        }
        try {
            arrgs_TeacherTaskObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_TeacherTaskObjLst;
        }
        return arrgs_TeacherTaskObjLst;
    }
    exports.gs_TeacherTask_GetObjLstByJSONStr = gs_TeacherTask_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_TeacherTaskObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_TeacherTask_GetObjLstByJSONObjLst(arrgs_TeacherTaskObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_TeacherTaskObjLst = new Array();
        for (const objInFor of arrgs_TeacherTaskObjLstS) {
            const obj1 = gs_TeacherTask_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_TeacherTaskObjLst.push(obj1);
        }
        return arrgs_TeacherTaskObjLst;
    }
    exports.gs_TeacherTask_GetObjLstByJSONObjLst = gs_TeacherTask_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_TeacherTask_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_TeacherTaskEN = new clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN();
        if (strJSON === "") {
            return pobjgs_TeacherTaskEN;
        }
        try {
            pobjgs_TeacherTaskEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_TeacherTaskEN;
        }
        return pobjgs_TeacherTaskEN;
    }
    exports.gs_TeacherTask_GetObjByJSONStr = gs_TeacherTask_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_TeacherTask_GetCombineCondition(objgs_TeacherTask_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_TeacherTask_Cond.dicFldComparisonOp, clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_mId) == true) {
            const strComparisonOp_mId = objgs_TeacherTask_Cond.dicFldComparisonOp[clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_mId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_mId, objgs_TeacherTask_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TeacherTask_Cond.dicFldComparisonOp, clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objgs_TeacherTask_Cond.dicFldComparisonOp[clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_TopicId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_TopicId, objgs_TeacherTask_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TeacherTask_Cond.dicFldComparisonOp, clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objgs_TeacherTask_Cond.dicFldComparisonOp[clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_id_CurrEduCls, objgs_TeacherTask_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TeacherTask_Cond.dicFldComparisonOp, clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_MissionStatement) == true) {
            const strComparisonOp_MissionStatement = objgs_TeacherTask_Cond.dicFldComparisonOp[clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_MissionStatement];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_MissionStatement, objgs_TeacherTask_Cond.missionStatement, strComparisonOp_MissionStatement);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TeacherTask_Cond.dicFldComparisonOp, clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_MissionRequirement) == true) {
            const strComparisonOp_MissionRequirement = objgs_TeacherTask_Cond.dicFldComparisonOp[clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_MissionRequirement];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_MissionRequirement, objgs_TeacherTask_Cond.missionRequirement, strComparisonOp_MissionRequirement);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TeacherTask_Cond.dicFldComparisonOp, clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_TeacherTask_Cond.dicFldComparisonOp[clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_UpdDate, objgs_TeacherTask_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TeacherTask_Cond.dicFldComparisonOp, clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_TeacherTask_Cond.dicFldComparisonOp[clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_UpdUser, objgs_TeacherTask_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TeacherTask_Cond.dicFldComparisonOp, clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_TeacherTask_Cond.dicFldComparisonOp[clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN.con_Memo, objgs_TeacherTask_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_TeacherTask_GetCombineCondition = gs_TeacherTask_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_TeacherTask(教师任务),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_TeacherTask_GetUniCondStr_mId(objgs_TeacherTaskEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and mId = '{0}'", objgs_TeacherTaskEN.mId);
        return strWhereCond;
    }
    exports.gs_TeacherTask_GetUniCondStr_mId = gs_TeacherTask_GetUniCondStr_mId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_TeacherTask(教师任务),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_TeacherTask_GetUniCondStr4Update_mId(objgs_TeacherTaskEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and mId <> '{0}'", objgs_TeacherTaskEN.mId);
        strWhereCond += (0, clsString_js_2.Format)(" and mId = '{0}'", objgs_TeacherTaskEN.mId);
        return strWhereCond;
    }
    exports.gs_TeacherTask_GetUniCondStr4Update_mId = gs_TeacherTask_GetUniCondStr4Update_mId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_TeacherTaskENS:源对象
     * @param objgs_TeacherTaskENT:目标对象
    */
    function gs_TeacherTask_CopyObjTo(objgs_TeacherTaskENS, objgs_TeacherTaskENT) {
        objgs_TeacherTaskENT.mId = objgs_TeacherTaskENS.mId; //mId
        objgs_TeacherTaskENT.topicId = objgs_TeacherTaskENS.topicId; //主题Id
        objgs_TeacherTaskENT.id_CurrEduCls = objgs_TeacherTaskENS.id_CurrEduCls; //教学班流水号
        objgs_TeacherTaskENT.missionStatement = objgs_TeacherTaskENS.missionStatement; //任务说明
        objgs_TeacherTaskENT.missionRequirement = objgs_TeacherTaskENS.missionRequirement; //任务要求
        objgs_TeacherTaskENT.updDate = objgs_TeacherTaskENS.updDate; //修改日期
        objgs_TeacherTaskENT.updUser = objgs_TeacherTaskENS.updUser; //修改人
        objgs_TeacherTaskENT.memo = objgs_TeacherTaskENS.memo; //备注
        objgs_TeacherTaskENT.sf_UpdFldSetStr = objgs_TeacherTaskENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_TeacherTask_CopyObjTo = gs_TeacherTask_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_TeacherTaskENS:源对象
     * @param objgs_TeacherTaskENT:目标对象
    */
    function gs_TeacherTask_GetObjFromJsonObj(objgs_TeacherTaskENS) {
        const objgs_TeacherTaskENT = new clsgs_TeacherTaskEN_js_1.clsgs_TeacherTaskEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TeacherTaskENT, objgs_TeacherTaskENS);
        return objgs_TeacherTaskENT;
    }
    exports.gs_TeacherTask_GetObjFromJsonObj = gs_TeacherTask_GetObjFromJsonObj;
});
