var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduTools/clsSysCommentEN.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsStackTrace.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/tzDictionary.js", "axios", "../../L0_Entity/GraduateEduTools/clsSysCommentENEx.js", "../../L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysCommentEx_ReFreshThisCache = exports.SysCommentEx_ReFreshCache = exports.SysCommentEx_AddOrUpdateSysScoreSummaryAsync = exports.SysCommentEx_UpdateCommentWeekAsync = exports.SysCommentEx_DelRecordAsync = exports.SysCommentEx_GetTotalRevalidationAsync = exports.SysCommentEx_AddNewRecordExAsync = exports.SysCommentEx_FilterFunByKey = exports.SysCommentEx_FuncMapByFldName = exports.SysCommentEx_SortFunByKey = exports.SysCommentEx_GetObjExLstByPagerAsync = exports.SysCommentEx_GetObjExLstByPager_Cache = exports.SysCommentEx_CopyToEx = exports.SysCommentEx_GetWebApiUrl = exports.sysCommentEx_ConstructorName = exports.sysCommentEx_Controller = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:clsSysCommentWApi
    表名:SysComment(01120622)
    生成代码版本:2020.04.08.1
    生成日期:2020/04/16 19:58:06
    生成者:
    生成服务器IP:192.168.1.10
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:研究生培养
    模块英文名:GraduateEdu
    框架-层名:WA_访问层(WA_Access)
    编程语言:TypeScript
    注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
          2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
    == == == == == == == == == == == ==
    */
    //import * as QQ from "q";
    const clsSysCommentEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsSysCommentEN.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsStackTrace_js_1 = require("../../PubFun/clsStackTrace.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const axios_1 = __importDefault(require("axios"));
    const clsSysCommentENEx_js_1 = require("../../L0_Entity/GraduateEduTools/clsSysCommentENEx.js");
    const clsSysCommentWApi_js_1 = require("../../L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.sysCommentEx_Controller = "SysCommentExApi";
    exports.sysCommentEx_ConstructorName = "sysCommentEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function SysCommentEx_GetWebApiUrl(strController, strAction) {
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
    exports.SysCommentEx_GetWebApiUrl = SysCommentEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objSysCommentENS:源对象
    * @returns 目标对象=>clsSysCommentEN:objSysCommentENT
    **/
    function SysCommentEx_CopyToEx(objSysCommentENS) {
        const strThisFuncName = SysCommentEx_CopyToEx.name;
        const objSysCommentENT = new clsSysCommentENEx_js_1.clsSysCommentENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysCommentENT, objSysCommentENS);
            return objSysCommentENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.sysCommentEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objSysCommentENT;
        }
    }
    exports.SysCommentEx_CopyToEx = SysCommentEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function SysCommentEx_GetObjExLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrSysCommentObjLst = await (0, clsSysCommentWApi_js_1.SysComment_GetObjLst_Cache)(strid_CurrEduCls);
        const arrSysCommentExObjLst = arrSysCommentObjLst.map(SysCommentEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrSysCommentExObjLst) {
                const conFuncMap = await SysCommentEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrSysCommentExObjLst.length == 0)
            return arrSysCommentExObjLst;
        let arrSysComment_Sel = arrSysCommentExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objSysComment_Cond = new clsSysCommentENEx_js_1.clsSysCommentENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysComment_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsSysCommentWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysComment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSysComment_Sel.length == 0)
                return arrSysComment_Sel;
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
                arrSysComment_Sel = arrSysComment_Sel.sort(SysCommentEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrSysComment_Sel = arrSysComment_Sel.sort(objPagerPara.sortFun);
            }
            arrSysComment_Sel = arrSysComment_Sel.slice(intStart, intEnd);
            return arrSysComment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sysCommentEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysCommentEx_GetObjExLstByPager_Cache = SysCommentEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function SysCommentEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrSysCommentExObjLst = await (0, clsSysCommentWApi_js_1.SysComment_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrSysCommentExObjLst) {
                const conFuncMap = await SysCommentEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrSysCommentExObjLst.length == 0)
            return arrSysCommentExObjLst;
        let arrSysComment_Sel = arrSysCommentExObjLst;
        try {
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
                arrSysComment_Sel = arrSysComment_Sel.sort(SysCommentEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrSysComment_Sel = arrSysComment_Sel.sort(objPagerPara.sortFun);
            }
            arrSysComment_Sel = arrSysComment_Sel.slice(intStart, intEnd);
            return arrSysComment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sysCommentEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysCommentEx_GetObjExLstByPagerAsync = SysCommentEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysCommentEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsSysCommentWApi_js_1.SysComment_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsSysCommentWApi_js_1.SysComment_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.SysCommentEx_SortFunByKey = SysCommentEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function SysCommentEx_FuncMapByFldName(strFldName, objSysCommentEx) {
        const strThisFuncName = SysCommentEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsSysCommentEN_js_1.clsSysCommentEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.SysCommentEx_FuncMapByFldName = SysCommentEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SysCommentEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsSysCommentWApi_js_1.SysComment_FilterFunByKey)(strKey, value);
        }
    }
    exports.SysCommentEx_FilterFunByKey = SysCommentEx_FilterFunByKey;
    /// <summary>
    /// 调用WebApi来添加记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    /// </summary>
    /// <param name = "objSysCommentEN">需要添加的对象</param>
    /// <returns>获取相应的记录的对象</returns>
    async function SysCommentEx_AddNewRecordExAsync(objSysCommentEN) {
        const strThisFuncName = "";
        var strMsg = "";
        var strAction = "AddNewRecordEx";
        //if (objSysCommentEN.commentId === null || objSysCommentEN.commentId === "") {
        //    strMsg = "需要的对象的关键字为空，不能添加!";
        //    throw strMsg;
        //}
        //var strJSON = JSON.stringify(objSysCommentEN_Sim);
        let strUrl = SysCommentEx_GetWebApiUrl(exports.sysCommentEx_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysCommentEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCommentEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCommentEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCommentEx_AddNewRecordExAsync = SysCommentEx_AddNewRecordExAsync;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>返回的第一条记录的关键字值</returns>
    async function SysCommentEx_GetTotalRevalidationAsync(TeaUserId) {
        const strThisFuncName = "";
        var strAction = "GetStuTotalRevalidation";
        let strUrl = SysCommentEx_GetWebApiUrl(exports.sysCommentEx_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "updUserId": TeaUserId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCommentEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCommentEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCommentEx_GetTotalRevalidationAsync = SysCommentEx_GetTotalRevalidationAsync;
    /// <summary>
    /// 调用WebApi来删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    /// </summary>
    /// <param name = "strCommentId">关键字</param>
    /// <returns>获取删除的结果</returns>
    async function SysCommentEx_DelRecordAsync(strCommentId) {
        const strThisFuncName = "";
        var strAction = "DelRecordEx";
        let strUrl = SysCommentEx_GetWebApiUrl(exports.sysCommentEx_Controller, strAction);
        strUrl = `${strUrl}/${strCommentId}`;
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strCommentId", strCommentId);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strCommentId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCommentEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCommentEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCommentEx_DelRecordAsync = SysCommentEx_DelRecordAsync;
    /// <summary>
    /// 修改评论内的教学班周
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>是否存在记录？</returns>
    async function SysCommentEx_UpdateCommentWeekAsync(strId_CurrEduCls, updUser) {
        const strThisFuncName = "";
        var strAction = "UpdateCommentWeek";
        let strUrl = SysCommentEx_GetWebApiUrl(exports.sysCommentEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strId_CurrEduCls": strId_CurrEduCls,
                    "strUpdUser": updUser
                }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCommentEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCommentEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCommentEx_UpdateCommentWeekAsync = SysCommentEx_UpdateCommentWeekAsync;
    //教师操作 评论、讨论打分 添加 或修改； PageType 判断添加、修改； scoreTypeId 判断是讨论 ，还是评价、updUserId操作人；
    async function SysCommentEx_AddOrUpdateSysScoreSummaryAsync(objSysScoreSummaryEN) {
        const strThisFuncName = "";
        var strMsg = "";
        var strAction = "AddOrUpdateSysScoreSummary";
        //if (objSysCommentEN.commentId === null || objSysCommentEN.commentId === "") {
        //    strMsg = "需要的对象的关键字为空，不能添加!";
        //    throw strMsg;
        //}
        //var strJSON = JSON.stringify(objSysCommentEN_Sim);
        let strUrl = SysCommentEx_GetWebApiUrl(exports.sysCommentEx_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysScoreSummaryEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysCommentEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysCommentEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysCommentEx_AddOrUpdateSysScoreSummaryAsync = SysCommentEx_AddOrUpdateSysScoreSummaryAsync;
    /// <summary>
    /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    /// </summary>
    function SysCommentEx_ReFreshCache() {
        var strMsg = `刷新缓存成功！(${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(3)}->${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(2)}->${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
        console.log(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        var strKey = clsSysCommentEN_js_1.clsSysCommentEN._CurrTabName;
        switch (clsSysCommentEN_js_1.clsSysCommentEN.CacheModeId) {
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
    exports.SysCommentEx_ReFreshCache = SysCommentEx_ReFreshCache;
    /// <summary>
    /// 刷新本类中的缓存.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    /// </summary>
    function SysCommentEx_ReFreshThisCache() {
        var strMsg = "";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            var strKey = clsSysCommentEN_js_1.clsSysCommentEN._CurrTabName;
            switch (clsSysCommentEN_js_1.clsSysCommentEN.CacheModeId) {
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
            strMsg = `刷新缓存成功！(${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(3)}->${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(2)}->${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`,
                console.log(strMsg);
        }
        else {
            strMsg = `刷新缓存已经关闭。(clsSysPara4WebApi.spSetRefreshCacheOn == false)(${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(3)}->${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunctionByLevel(2)}->${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
            console.log(strMsg);
        }
    }
    exports.SysCommentEx_ReFreshThisCache = SysCommentEx_ReFreshThisCache;
});
