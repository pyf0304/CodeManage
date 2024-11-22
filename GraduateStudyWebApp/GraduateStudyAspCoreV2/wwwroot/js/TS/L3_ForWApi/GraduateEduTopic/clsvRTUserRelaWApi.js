/**
* 类名:clsvRTUserRelaWApi
* 表名:vRTUserRela(01120584)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:45:51
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vRTUserRela_GetObjFromJsonObj = exports.vRTUserRela_CopyObjTo = exports.vRTUserRela_GetCombineCondition = exports.vRTUserRela_GetObjByJSONStr = exports.vRTUserRela_GetObjLstByJSONObjLst = exports.vRTUserRela_GetObjLstByJSONStr = exports.vRTUserRela_GetJSONStrByObj = exports.vRTUserRela_ReFreshThisCache = exports.vRTUserRela_GetWebApiUrl = exports.vRTUserRela_GetRecCountByCond_Cache = exports.vRTUserRela_GetRecCountByCondAsync = exports.vRTUserRela_IsExistAsync = exports.vRTUserRela_IsExist_Cache = exports.vRTUserRela_IsExist = exports.vRTUserRela_IsExistRecordAsync = exports.vRTUserRela_IsExistRecord_Cache = exports.vRTUserRela_GetObjLstByPagerAsync = exports.vRTUserRela_GetObjLstByPager_Cache = exports.vRTUserRela_GetObjLstByRange = exports.vRTUserRela_GetObjLstByRangeAsync = exports.vRTUserRela_GetTopObjLstAsync = exports.vRTUserRela_GetObjLstBymIdLst_Cache = exports.vRTUserRela_GetObjLstBymIdLstAsync = exports.vRTUserRela_GetSubObjLst_Cache = exports.vRTUserRela_GetObjLst_PureCache = exports.vRTUserRela_GetObjLst_Cache = exports.vRTUserRela_GetObjLst_sessionStorage_PureCache = exports.vRTUserRela_GetObjLst_sessionStorage = exports.vRTUserRela_GetObjLstAsync = exports.vRTUserRela_GetObjLst_localStorage_PureCache = exports.vRTUserRela_GetObjLst_localStorage = exports.vRTUserRela_GetObjLst_ClientCache = exports.vRTUserRela_GetFirstObjAsync = exports.vRTUserRela_GetFirstID = exports.vRTUserRela_GetFirstIDAsync = exports.vRTUserRela_funcKey = exports.vRTUserRela_FilterFunByKey = exports.vRTUserRela_SortFunByKey = exports.vRTUserRela_SortFun_Defa_2Fld = exports.vRTUserRela_SortFun_Defa = exports.vRTUserRela_func = exports.vRTUserRela_GetObjBymId_localStorage = exports.vRTUserRela_GetObjBymId_Cache = exports.vRTUserRela_GetObjBymIdAsync = exports.vRTUserRela_ConstructorName = exports.vRTUserRela_Controller = void 0;
    /**
     * 主题用户关系视图(vRTUserRela)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvRTUserRelaEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvRTUserRelaEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vRTUserRela_Controller = "vRTUserRelaApi";
    exports.vRTUserRela_ConstructorName = "vRTUserRela";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vRTUserRela_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvRTUserRelaWApi.GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTUserRela_Controller, strAction);
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
                const objvRTUserRela = vRTUserRela_GetObjFromJsonObj(returnObj);
                return objvRTUserRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTUserRela_GetObjBymIdAsync = vRTUserRela_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTUserRela_GetObjBymId_Cache(lngmId, strTopicId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvRTUserRelaWApi.GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvRTUserRelaObjLst_Cache = await vRTUserRela_GetObjLst_Cache(strTopicId);
        try {
            const arrvRTUserRela_Sel = arrvRTUserRelaObjLst_Cache.filter(x => x.mId == lngmId);
            let objvRTUserRela;
            if (arrvRTUserRela_Sel.length > 0) {
                objvRTUserRela = arrvRTUserRela_Sel[0];
                return objvRTUserRela;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvRTUserRela_Const = await vRTUserRela_GetObjBymIdAsync(lngmId);
                    if (objvRTUserRela_Const != null) {
                        vRTUserRela_ReFreshThisCache(strTopicId);
                        return objvRTUserRela_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vRTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vRTUserRela_GetObjBymId_Cache = vRTUserRela_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTUserRela_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In clsvRTUserRelaWApi.GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvRTUserRela_Cache = JSON.parse(strTempObj);
            return objvRTUserRela_Cache;
        }
        try {
            const objvRTUserRela = await vRTUserRela_GetObjBymIdAsync(lngmId);
            if (objvRTUserRela != null) {
                localStorage.setItem(strKey, JSON.stringify(objvRTUserRela));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvRTUserRela;
            }
            return objvRTUserRela;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vRTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vRTUserRela_GetObjBymId_localStorage = vRTUserRela_GetObjBymId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strTopicId:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function vRTUserRela_func(strInFldName, strOutFldName, strInValue, strTopicId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicId_C]不能为空！(In clsvRTUserRelaWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicId_C]的长度:[{0}]不正确！(clsvRTUserRelaWApi.func)", strTopicId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objvRTUserRela = await vRTUserRela_GetObjBymId_Cache(lngmId, strTopicId_C);
        if (objvRTUserRela == null)
            return "";
        if (objvRTUserRela.GetFldValue(strOutFldName) == null)
            return "";
        return objvRTUserRela.GetFldValue(strOutFldName).toString();
    }
    exports.vRTUserRela_func = vRTUserRela_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTUserRela_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vRTUserRela_SortFun_Defa = vRTUserRela_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTUserRela_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.topicId == b.topicId)
            return a.userId.localeCompare(b.userId);
        else
            return a.topicId.localeCompare(b.topicId);
    }
    exports.vRTUserRela_SortFun_Defa_2Fld = vRTUserRela_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vRTUserRela_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicId:
                    return (a, b) => {
                        if (a.topicId == null)
                            return -1;
                        if (b.topicId == null)
                            return 1;
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserId:
                    return (a, b) => {
                        if (a.userId == null)
                            return -1;
                        if (b.userId == null)
                            return 1;
                        return a.userId.localeCompare(b.userId);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdUserName:
                    return (a, b) => {
                        if (a.updUserName == null)
                            return -1;
                        if (b.updUserName == null)
                            return 1;
                        return a.updUserName.localeCompare(b.updUserName);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicName:
                    return (a, b) => {
                        if (a.topicName == null)
                            return -1;
                        if (b.topicName == null)
                            return 1;
                        return a.topicName.localeCompare(b.topicName);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicContent:
                    return (a, b) => {
                        if (a.topicContent == null)
                            return -1;
                        if (b.topicContent == null)
                            return 1;
                        return a.topicContent.localeCompare(b.topicContent);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicProposePeople:
                    return (a, b) => {
                        if (a.topicProposePeople == null)
                            return -1;
                        if (b.topicProposePeople == null)
                            return 1;
                        return a.topicProposePeople.localeCompare(b.topicProposePeople);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserName:
                    return (a, b) => {
                        if (a.userName == null)
                            return -1;
                        if (b.userName == null)
                            return 1;
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_CollegeName:
                    return (a, b) => {
                        if (a.collegeName == null)
                            return -1;
                        if (b.collegeName == null)
                            return 1;
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_XzMajor:
                    return (a, b) => {
                        if (a.id_XzMajor == null)
                            return -1;
                        if (b.id_XzMajor == null)
                            return 1;
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_MajorName:
                    return (a, b) => {
                        if (a.majorName == null)
                            return -1;
                        if (b.majorName == null)
                            return 1;
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicUserRoleId:
                    return (a, b) => {
                        return a.topicUserRoleId.localeCompare(b.topicUserRoleId);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicUserRoleName:
                    return (a, b) => {
                        if (a.topicUserRoleName == null)
                            return -1;
                        if (b.topicUserRoleName == null)
                            return 1;
                        return a.topicUserRoleName.localeCompare(b.topicUserRoleName);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_ColorId:
                    return (a, b) => {
                        if (a.colorId == null)
                            return -1;
                        if (b.colorId == null)
                            return 1;
                        return a.colorId.localeCompare(b.colorId);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_ColorCode:
                    return (a, b) => {
                        if (a.colorCode == null)
                            return -1;
                        if (b.colorCode == null)
                            return 1;
                        return a.colorCode.localeCompare(b.colorCode);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserBgColor:
                    return (a, b) => {
                        if (a.userBgColor == null)
                            return -1;
                        if (b.userBgColor == null)
                            return 1;
                        return a.userBgColor.localeCompare(b.userBgColor);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vRTUserRela]中不存在！(in ${exports.vRTUserRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicId:
                    return (a, b) => {
                        if (b.topicId == null)
                            return -1;
                        if (a.topicId == null)
                            return 1;
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserId:
                    return (a, b) => {
                        if (b.userId == null)
                            return -1;
                        if (a.userId == null)
                            return 1;
                        return b.userId.localeCompare(a.userId);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdUserName:
                    return (a, b) => {
                        if (b.updUserName == null)
                            return -1;
                        if (a.updUserName == null)
                            return 1;
                        return b.updUserName.localeCompare(a.updUserName);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicName:
                    return (a, b) => {
                        if (b.topicName == null)
                            return -1;
                        if (a.topicName == null)
                            return 1;
                        return b.topicName.localeCompare(a.topicName);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicContent:
                    return (a, b) => {
                        if (b.topicContent == null)
                            return -1;
                        if (a.topicContent == null)
                            return 1;
                        return b.topicContent.localeCompare(a.topicContent);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicProposePeople:
                    return (a, b) => {
                        if (b.topicProposePeople == null)
                            return -1;
                        if (a.topicProposePeople == null)
                            return 1;
                        return b.topicProposePeople.localeCompare(a.topicProposePeople);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserName:
                    return (a, b) => {
                        if (b.userName == null)
                            return -1;
                        if (a.userName == null)
                            return 1;
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_CollegeName:
                    return (a, b) => {
                        if (b.collegeName == null)
                            return -1;
                        if (a.collegeName == null)
                            return 1;
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_XzMajor:
                    return (a, b) => {
                        if (b.id_XzMajor == null)
                            return -1;
                        if (a.id_XzMajor == null)
                            return 1;
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_MajorName:
                    return (a, b) => {
                        if (b.majorName == null)
                            return -1;
                        if (a.majorName == null)
                            return 1;
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicUserRoleId:
                    return (a, b) => {
                        return b.topicUserRoleId.localeCompare(a.topicUserRoleId);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicUserRoleName:
                    return (a, b) => {
                        if (b.topicUserRoleName == null)
                            return -1;
                        if (a.topicUserRoleName == null)
                            return 1;
                        return b.topicUserRoleName.localeCompare(a.topicUserRoleName);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_ColorId:
                    return (a, b) => {
                        if (b.colorId == null)
                            return -1;
                        if (a.colorId == null)
                            return 1;
                        return b.colorId.localeCompare(a.colorId);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_ColorCode:
                    return (a, b) => {
                        if (b.colorCode == null)
                            return -1;
                        if (a.colorCode == null)
                            return 1;
                        return b.colorCode.localeCompare(a.colorCode);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserBgColor:
                    return (a, b) => {
                        if (b.userBgColor == null)
                            return -1;
                        if (a.userBgColor == null)
                            return 1;
                        return b.userBgColor.localeCompare(a.userBgColor);
                    };
                case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vRTUserRela]中不存在！(in ${exports.vRTUserRela_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vRTUserRela_SortFunByKey = vRTUserRela_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vRTUserRela_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdUserName:
                return (obj) => {
                    return obj.updUserName === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicName:
                return (obj) => {
                    return obj.topicName === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicContent:
                return (obj) => {
                    return obj.topicContent === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicProposePeople:
                return (obj) => {
                    return obj.topicProposePeople === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicUserRoleId:
                return (obj) => {
                    return obj.topicUserRoleId === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicUserRoleName:
                return (obj) => {
                    return obj.topicUserRoleName === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_ColorId:
                return (obj) => {
                    return obj.colorId === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_ColorCode:
                return (obj) => {
                    return obj.colorCode === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserBgColor:
                return (obj) => {
                    return obj.userBgColor === value;
                };
            case clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vRTUserRela]中不存在！(in ${exports.vRTUserRela_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vRTUserRela_FilterFunByKey = vRTUserRela_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     @param strTopicId:缓存的分类字段
     * @returns 返回一个关键字值列表
    */
    async function vRTUserRela_funcKey(strInFldName, strInValue, strComparisonOp, strTopicId_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicId_C]不能为空！(In clsvRTUserRelaWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicId_C]的长度:[{0}]不正确！(clsvRTUserRelaWApi.funcKey)", strTopicId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrvRTUserRela = await vRTUserRela_GetObjLst_Cache(strTopicId_C);
        if (arrvRTUserRela == null)
            return [];
        let arrvRTUserRela_Sel = arrvRTUserRela;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvRTUserRela_Sel.length == 0)
            return [];
        return arrvRTUserRela_Sel.map(x => x.mId);
    }
    exports.vRTUserRela_funcKey = vRTUserRela_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vRTUserRela_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTUserRela_GetFirstIDAsync = vRTUserRela_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vRTUserRela_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTUserRela_GetFirstID = vRTUserRela_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vRTUserRela_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTUserRela_Controller, strAction);
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
                const objvRTUserRela = vRTUserRela_GetObjFromJsonObj(returnObj);
                return objvRTUserRela;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTUserRela_GetFirstObjAsync = vRTUserRela_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTUserRela_GetObjLst_ClientCache(strTopicId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.WhereFormat, strTopicId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN._CurrTabName, strTopicId);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvRTUserRelaExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvRTUserRelaObjLst_T = vRTUserRela_GetObjLstByJSONObjLst(arrvRTUserRelaExObjLst_Cache);
            return arrvRTUserRelaObjLst_T;
        }
        try {
            const arrvRTUserRelaExObjLst = await vRTUserRela_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvRTUserRelaExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTUserRelaExObjLst.length);
            console.log(strInfo);
            return arrvRTUserRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTUserRela_GetObjLst_ClientCache = vRTUserRela_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTUserRela_GetObjLst_localStorage(strTopicId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.WhereFormat, strTopicId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN._CurrTabName, strTopicId);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvRTUserRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvRTUserRelaObjLst_T = vRTUserRela_GetObjLstByJSONObjLst(arrvRTUserRelaExObjLst_Cache);
            return arrvRTUserRelaObjLst_T;
        }
        try {
            const arrvRTUserRelaExObjLst = await vRTUserRela_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvRTUserRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTUserRelaExObjLst.length);
            console.log(strInfo);
            return arrvRTUserRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTUserRela_GetObjLst_localStorage = vRTUserRela_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTUserRela_GetObjLst_localStorage_PureCache(strTopicId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN._CurrTabName, strTopicId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvRTUserRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvRTUserRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.vRTUserRela_GetObjLst_localStorage_PureCache = vRTUserRela_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vRTUserRela_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTUserRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTUserRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTUserRela_GetObjLstAsync = vRTUserRela_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTUserRela_GetObjLst_sessionStorage(strTopicId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.WhereFormat, strTopicId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN._CurrTabName, strTopicId);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvRTUserRelaExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvRTUserRelaObjLst_T = vRTUserRela_GetObjLstByJSONObjLst(arrvRTUserRelaExObjLst_Cache);
            return arrvRTUserRelaObjLst_T;
        }
        try {
            const arrvRTUserRelaExObjLst = await vRTUserRela_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvRTUserRelaExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTUserRelaExObjLst.length);
            console.log(strInfo);
            return arrvRTUserRelaExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vRTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vRTUserRela_GetObjLst_sessionStorage = vRTUserRela_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTUserRela_GetObjLst_sessionStorage_PureCache(strTopicId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN._CurrTabName, strTopicId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvRTUserRelaObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvRTUserRelaObjLst_Cache;
        }
        else
            return null;
    }
    exports.vRTUserRela_GetObjLst_sessionStorage_PureCache = vRTUserRela_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTUserRela_GetObjLst_Cache(strTopicId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicId) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[TopicId]不能为空！(in clsvRTUserRelaWApi.vRTUserRela_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicId]的长度:[{0}]不正确！(in clsvRTUserRelaWApi.vRTUserRela_GetObjLst_Cache() )", strTopicId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvRTUserRelaObjLst_Cache;
        switch (clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrvRTUserRelaObjLst_Cache = await vRTUserRela_GetObjLst_sessionStorage(strTopicId);
                break;
            case "03": //localStorage
                arrvRTUserRelaObjLst_Cache = await vRTUserRela_GetObjLst_localStorage(strTopicId);
                break;
            case "02": //ClientCache
                arrvRTUserRelaObjLst_Cache = await vRTUserRela_GetObjLst_ClientCache(strTopicId);
                break;
            default:
                arrvRTUserRelaObjLst_Cache = await vRTUserRela_GetObjLst_ClientCache(strTopicId);
                break;
        }
        const arrvRTUserRelaObjLst = vRTUserRela_GetObjLstByJSONObjLst(arrvRTUserRelaObjLst_Cache);
        return arrvRTUserRelaObjLst_Cache;
    }
    exports.vRTUserRela_GetObjLst_Cache = vRTUserRela_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vRTUserRela_GetObjLst_PureCache(strTopicId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvRTUserRelaObjLst_Cache;
        switch (clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.CacheModeId) {
            case "04": //sessionStorage
                arrvRTUserRelaObjLst_Cache = await vRTUserRela_GetObjLst_sessionStorage_PureCache(strTopicId);
                break;
            case "03": //localStorage
                arrvRTUserRelaObjLst_Cache = await vRTUserRela_GetObjLst_localStorage_PureCache(strTopicId);
                break;
            case "02": //ClientCache
                arrvRTUserRelaObjLst_Cache = null;
                break;
            default:
                arrvRTUserRelaObjLst_Cache = null;
                break;
        }
        return arrvRTUserRelaObjLst_Cache;
    }
    exports.vRTUserRela_GetObjLst_PureCache = vRTUserRela_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vRTUserRela_GetSubObjLst_Cache(objvRTUserRela_Cond, strTopicId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvRTUserRelaObjLst_Cache = await vRTUserRela_GetObjLst_Cache(strTopicId);
        let arrvRTUserRela_Sel = arrvRTUserRelaObjLst_Cache;
        if (objvRTUserRela_Cond.sf_FldComparisonOp == null || objvRTUserRela_Cond.sf_FldComparisonOp == "")
            return arrvRTUserRela_Sel;
        const dicFldComparisonOp = JSON.parse(objvRTUserRela_Cond.sf_FldComparisonOp);
        //console.log("clsvRTUserRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTUserRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTUserRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvRTUserRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvRTUserRela_Cond), exports.vRTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vRTUserRela_GetSubObjLst_Cache = vRTUserRela_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function vRTUserRela_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTUserRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTUserRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTUserRela_GetObjLstBymIdLstAsync = vRTUserRela_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function vRTUserRela_GetObjLstBymIdLst_Cache(arrmIdLst, strTopicId) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrvRTUserRelaObjLst_Cache = await vRTUserRela_GetObjLst_Cache(strTopicId);
            const arrvRTUserRela_Sel = arrvRTUserRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrvRTUserRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.vRTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vRTUserRela_GetObjLstBymIdLst_Cache = vRTUserRela_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vRTUserRela_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTUserRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTUserRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTUserRela_GetTopObjLstAsync = vRTUserRela_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vRTUserRela_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTUserRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTUserRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTUserRela_GetObjLstByRangeAsync = vRTUserRela_GetObjLstByRangeAsync;
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
    async function vRTUserRela_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTUserRela_GetObjLstByRange = vRTUserRela_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vRTUserRela_GetObjLstByPager_Cache(objPagerPara, strTopicId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvRTUserRelaObjLst_Cache = await vRTUserRela_GetObjLst_Cache(strTopicId);
        if (arrvRTUserRelaObjLst_Cache.length == 0)
            return arrvRTUserRelaObjLst_Cache;
        let arrvRTUserRela_Sel = arrvRTUserRelaObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvRTUserRela_Cond = new clsvRTUserRelaEN_js_1.clsvRTUserRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvRTUserRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvRTUserRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTUserRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvRTUserRela_Sel.length == 0)
                return arrvRTUserRela_Sel;
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
                arrvRTUserRela_Sel = arrvRTUserRela_Sel.sort(vRTUserRela_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvRTUserRela_Sel = arrvRTUserRela_Sel.sort(objPagerPara.sortFun);
            }
            arrvRTUserRela_Sel = arrvRTUserRela_Sel.slice(intStart, intEnd);
            return arrvRTUserRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vRTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vRTUserRela_GetObjLstByPager_Cache = vRTUserRela_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vRTUserRela_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTUserRela_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vRTUserRela_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vRTUserRela_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTUserRela_GetObjLstByPagerAsync = vRTUserRela_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vRTUserRela_IsExistRecord_Cache(objvRTUserRela_Cond, strTopicId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvRTUserRelaObjLst_Cache = await vRTUserRela_GetObjLst_Cache(strTopicId);
        if (arrvRTUserRelaObjLst_Cache == null)
            return false;
        let arrvRTUserRela_Sel = arrvRTUserRelaObjLst_Cache;
        if (objvRTUserRela_Cond.sf_FldComparisonOp == null || objvRTUserRela_Cond.sf_FldComparisonOp == "")
            return arrvRTUserRela_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvRTUserRela_Cond.sf_FldComparisonOp);
        //console.log("clsvRTUserRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTUserRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTUserRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvRTUserRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvRTUserRela_Cond), exports.vRTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vRTUserRela_IsExistRecord_Cache = vRTUserRela_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vRTUserRela_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTUserRela_IsExistRecordAsync = vRTUserRela_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vRTUserRela_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTUserRela_IsExist = vRTUserRela_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vRTUserRela_IsExist_Cache(lngmId, strTopicId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvRTUserRelaObjLst_Cache = await vRTUserRela_GetObjLst_Cache(strTopicId);
        if (arrvRTUserRelaObjLst_Cache == null)
            return false;
        try {
            const arrvRTUserRela_Sel = arrvRTUserRelaObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrvRTUserRela_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.vRTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vRTUserRela_IsExist_Cache = vRTUserRela_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vRTUserRela_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTUserRela_IsExistAsync = vRTUserRela_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vRTUserRela_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vRTUserRela_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vRTUserRela_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vRTUserRela_GetRecCountByCondAsync = vRTUserRela_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvRTUserRela_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vRTUserRela_GetRecCountByCond_Cache(objvRTUserRela_Cond, strTopicId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvRTUserRelaObjLst_Cache = await vRTUserRela_GetObjLst_Cache(strTopicId);
        if (arrvRTUserRelaObjLst_Cache == null)
            return 0;
        let arrvRTUserRela_Sel = arrvRTUserRelaObjLst_Cache;
        if (objvRTUserRela_Cond.sf_FldComparisonOp == null || objvRTUserRela_Cond.sf_FldComparisonOp == "")
            return arrvRTUserRela_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvRTUserRela_Cond.sf_FldComparisonOp);
        //console.log("clsvRTUserRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvRTUserRela_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvRTUserRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvRTUserRela_Sel = arrvRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvRTUserRela_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvRTUserRela_Cond), exports.vRTUserRela_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vRTUserRela_GetRecCountByCond_Cache = vRTUserRela_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vRTUserRela_GetWebApiUrl(strController, strAction) {
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
    exports.vRTUserRela_GetWebApiUrl = vRTUserRela_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vRTUserRela_ReFreshThisCache(strTopicId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN._CurrTabName, strTopicId);
            switch (clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.CacheModeId) {
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
            const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
            console.trace(strMsg);
        }
        else {
            const strMsg = (0, clsString_js_1.Format)("刷新缓存已经关闭。");
            console.trace(strMsg);
        }
    }
    exports.vRTUserRela_ReFreshThisCache = vRTUserRela_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vRTUserRela_GetJSONStrByObj(pobjvRTUserRelaEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvRTUserRelaEN);
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
    exports.vRTUserRela_GetJSONStrByObj = vRTUserRela_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vRTUserRela_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvRTUserRelaObjLst = new Array();
        if (strJSON === "") {
            return arrvRTUserRelaObjLst;
        }
        try {
            arrvRTUserRelaObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvRTUserRelaObjLst;
        }
        return arrvRTUserRelaObjLst;
    }
    exports.vRTUserRela_GetObjLstByJSONStr = vRTUserRela_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvRTUserRelaObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vRTUserRela_GetObjLstByJSONObjLst(arrvRTUserRelaObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvRTUserRelaObjLst = new Array();
        for (const objInFor of arrvRTUserRelaObjLstS) {
            const obj1 = vRTUserRela_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvRTUserRelaObjLst.push(obj1);
        }
        return arrvRTUserRelaObjLst;
    }
    exports.vRTUserRela_GetObjLstByJSONObjLst = vRTUserRela_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vRTUserRela_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvRTUserRelaEN = new clsvRTUserRelaEN_js_1.clsvRTUserRelaEN();
        if (strJSON === "") {
            return pobjvRTUserRelaEN;
        }
        try {
            pobjvRTUserRelaEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvRTUserRelaEN;
        }
        return pobjvRTUserRelaEN;
    }
    exports.vRTUserRela_GetObjByJSONStr = vRTUserRela_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vRTUserRela_GetCombineCondition(objvRTUserRela_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_mId) == true) {
            const strComparisonOp_mId = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_mId, objvRTUserRela_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicId, objvRTUserRela_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserId) == true) {
            const strComparisonOp_UserId = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserId, objvRTUserRela_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdDate, objvRTUserRela_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdUser, objvRTUserRela_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_Memo, objvRTUserRela_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdUserName) == true) {
            const strComparisonOp_UpdUserName = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdUserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UpdUserName, objvRTUserRela_Cond.updUserName, strComparisonOp_UpdUserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicName) == true) {
            const strComparisonOp_TopicName = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicName, objvRTUserRela_Cond.topicName, strComparisonOp_TopicName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicProposePeople) == true) {
            const strComparisonOp_TopicProposePeople = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicProposePeople];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicProposePeople, objvRTUserRela_Cond.topicProposePeople, strComparisonOp_TopicProposePeople);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserName, objvRTUserRela_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_XzCollege, objvRTUserRela_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_CollegeName, objvRTUserRela_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_XzMajor, objvRTUserRela_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_MajorName, objvRTUserRela_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicUserRoleId) == true) {
            const strComparisonOp_TopicUserRoleId = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicUserRoleId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicUserRoleId, objvRTUserRela_Cond.topicUserRoleId, strComparisonOp_TopicUserRoleId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicUserRoleName) == true) {
            const strComparisonOp_TopicUserRoleName = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicUserRoleName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_TopicUserRoleName, objvRTUserRela_Cond.topicUserRoleName, strComparisonOp_TopicUserRoleName);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_OrderNum, objvRTUserRela_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_ColorId) == true) {
            const strComparisonOp_ColorId = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_ColorId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_ColorId, objvRTUserRela_Cond.colorId, strComparisonOp_ColorId);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_ColorCode) == true) {
            const strComparisonOp_ColorCode = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_ColorCode];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_ColorCode, objvRTUserRela_Cond.colorCode, strComparisonOp_ColorCode);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserBgColor) == true) {
            const strComparisonOp_UserBgColor = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserBgColor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_UserBgColor, objvRTUserRela_Cond.userBgColor, strComparisonOp_UserBgColor);
        }
        if (Object.prototype.hasOwnProperty.call(objvRTUserRela_Cond.dicFldComparisonOp, clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvRTUserRela_Cond.dicFldComparisonOp[clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvRTUserRelaEN_js_1.clsvRTUserRelaEN.con_id_CurrEduCls, objvRTUserRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.vRTUserRela_GetCombineCondition = vRTUserRela_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvRTUserRelaENS:源对象
     * @param objvRTUserRelaENT:目标对象
    */
    function vRTUserRela_CopyObjTo(objvRTUserRelaENS, objvRTUserRelaENT) {
        objvRTUserRelaENT.mId = objvRTUserRelaENS.mId; //mId
        objvRTUserRelaENT.topicId = objvRTUserRelaENS.topicId; //主题Id
        objvRTUserRelaENT.userId = objvRTUserRelaENS.userId; //用户ID
        objvRTUserRelaENT.updDate = objvRTUserRelaENS.updDate; //修改日期
        objvRTUserRelaENT.updUser = objvRTUserRelaENS.updUser; //修改人
        objvRTUserRelaENT.memo = objvRTUserRelaENS.memo; //备注
        objvRTUserRelaENT.updUserName = objvRTUserRelaENS.updUserName; //UpdUserName
        objvRTUserRelaENT.topicName = objvRTUserRelaENS.topicName; //栏目主题
        objvRTUserRelaENT.topicContent = objvRTUserRelaENS.topicContent; //主题内容
        objvRTUserRelaENT.topicProposePeople = objvRTUserRelaENS.topicProposePeople; //主题提出人
        objvRTUserRelaENT.userName = objvRTUserRelaENS.userName; //用户名
        objvRTUserRelaENT.id_XzCollege = objvRTUserRelaENS.id_XzCollege; //学院流水号
        objvRTUserRelaENT.collegeName = objvRTUserRelaENS.collegeName; //学院名称
        objvRTUserRelaENT.id_XzMajor = objvRTUserRelaENS.id_XzMajor; //专业流水号
        objvRTUserRelaENT.majorName = objvRTUserRelaENS.majorName; //专业名称
        objvRTUserRelaENT.topicUserRoleId = objvRTUserRelaENS.topicUserRoleId; //主键Id
        objvRTUserRelaENT.topicUserRoleName = objvRTUserRelaENS.topicUserRoleName; //主题用户角色
        objvRTUserRelaENT.orderNum = objvRTUserRelaENS.orderNum; //序号
        objvRTUserRelaENT.colorId = objvRTUserRelaENS.colorId; //颜色Id
        objvRTUserRelaENT.colorCode = objvRTUserRelaENS.colorCode; //颜色码
        objvRTUserRelaENT.userBgColor = objvRTUserRelaENS.userBgColor; //用户段落背景
        objvRTUserRelaENT.id_CurrEduCls = objvRTUserRelaENS.id_CurrEduCls; //教学班流水号
    }
    exports.vRTUserRela_CopyObjTo = vRTUserRela_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvRTUserRelaENS:源对象
     * @param objvRTUserRelaENT:目标对象
    */
    function vRTUserRela_GetObjFromJsonObj(objvRTUserRelaENS) {
        const objvRTUserRelaENT = new clsvRTUserRelaEN_js_1.clsvRTUserRelaEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvRTUserRelaENT, objvRTUserRelaENS);
        return objvRTUserRelaENT;
    }
    exports.vRTUserRela_GetObjFromJsonObj = vRTUserRela_GetObjFromJsonObj;
});
