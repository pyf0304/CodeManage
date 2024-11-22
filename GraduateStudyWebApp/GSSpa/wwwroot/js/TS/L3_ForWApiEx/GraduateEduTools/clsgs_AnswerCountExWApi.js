/*-- -- -- -- -- -- -- -- -- -- --
类名:clsqa_AnswerWApi
表名:qa_Answer(01120641)
生成代码版本:2020.09.24.1
生成日期:2020/10/27 15:11:53
生成者:yy
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:互动管理
模块英文名:InteractManage
框架-层名:WA_访问层(WA_Access)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == ==
*/
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    var desc = Object.getOwnPropertyDescriptor(m, k);
    if (!desc || ("get" in desc ? !m.__esModule : desc.writable || desc.configurable)) {
      desc = { enumerable: true, get: function() { return m[k]; } };
    }
    Object.defineProperty(o, k2, desc);
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "jquery", "../../L0_Entity/GraduateEduTools/clsgs_AnswerCountEN.js", "../../L3_ForWApi/GraduateEduTools/clsgs_AnswerCountWApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsCommonFunc4Web2.js", "../../PubFun/tzDictionary.js", "../../L0_Entity/GraduateEduTools/clsgs_AnswerCountENEx.js", "../../L3_ForWApi/GraduateEduTools/clsgs_AnswerCountWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_AnswerCountEx_GetWeekAnswerCountNumObjLstAsync = exports.gs_AnswerCountEx_GetAnswerCountNumObjLstAsync = exports.gs_AnswerCountEx_GetSubObjLst_Cache = exports.gs_AnswerCountEx_GetObjLst_Cache = exports.gs_AnswerCountEx_GetObjLst_ClientCache = exports.gs_AnswerCountEx_GetAnswerCountByTableAsync = exports.gs_AnswerCountEx_AddNewRecordWithMaxIdAsync = exports.gs_AnswerCountEx_FilterFunByKey = exports.gs_AnswerCountEx_FuncMapByFldName = exports.gs_AnswerCountEx_SortFunByKey = exports.gs_AnswerCountEx_GetObjExLstByPagerAsync = exports.gs_AnswerCountEx_GetObjExLstByPager_Cache = exports.gs_AnswerCountEx_CopyToEx = exports.gs_AnswerCountEx_GetWebApiUrl = exports.gs_AnswerCountEx_ConstructorName = exports.gs_AnswerCountEx_Controller = void 0;
    /// <summary>
    /// 答疑回答(qa_Answer)
    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by yy on 2020年10月27日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    const $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    const clsgs_AnswerCountEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsgs_AnswerCountEN.js");
    const clsgs_AnswerCountWApi_js_1 = require("../../L3_ForWApi/GraduateEduTools/clsgs_AnswerCountWApi.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsCommonFunc4Web2_js_1 = require("../../PubFun/clsCommonFunc4Web2.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsgs_AnswerCountENEx_js_1 = require("../../L0_Entity/GraduateEduTools/clsgs_AnswerCountENEx.js");
    const clsgs_AnswerCountWApi_js_2 = require("../../L3_ForWApi/GraduateEduTools/clsgs_AnswerCountWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    exports.gs_AnswerCountEx_Controller = "gs_AnswerCountExApi";
    exports.gs_AnswerCountEx_ConstructorName = "gs_AnswerCountEx";
    //public static cacheModeId = "02"; //客户端缓存
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function gs_AnswerCountEx_GetWebApiUrl(strController, strAction) {
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
    exports.gs_AnswerCountEx_GetWebApiUrl = gs_AnswerCountEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objgs_AnswerCountENS:源对象
    * @returns 目标对象=>clsgs_AnswerCountEN:objgs_AnswerCountENT
    **/
    function gs_AnswerCountEx_CopyToEx(objgs_AnswerCountENS) {
        const strThisFuncName = gs_AnswerCountEx_CopyToEx.name;
        const objgs_AnswerCountENT = new clsgs_AnswerCountENEx_js_1.clsgs_AnswerCountENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_AnswerCountENT, objgs_AnswerCountENS);
            return objgs_AnswerCountENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.gs_AnswerCountEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objgs_AnswerCountENT;
        }
    }
    exports.gs_AnswerCountEx_CopyToEx = gs_AnswerCountEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_AnswerCountEx_GetObjExLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_AnswerCountObjLst = await (0, clsgs_AnswerCountWApi_js_2.gs_AnswerCount_GetObjLst_Cache)(strid_CurrEduCls);
        const arrgs_AnswerCountExObjLst = arrgs_AnswerCountObjLst.map(gs_AnswerCountEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_AnswerCountExObjLst) {
                const conFuncMap = await gs_AnswerCountEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_AnswerCountExObjLst.length == 0)
            return arrgs_AnswerCountExObjLst;
        let arrgs_AnswerCount_Sel = arrgs_AnswerCountExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_AnswerCount_Cond = new clsgs_AnswerCountENEx_js_1.clsgs_AnswerCountENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_AnswerCount_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_AnswerCountWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_AnswerCount_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_AnswerCount_Sel.length == 0)
                return arrgs_AnswerCount_Sel;
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
                arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.sort(gs_AnswerCountEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.slice(intStart, intEnd);
            return arrgs_AnswerCount_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_AnswerCountEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_AnswerCountEx_GetObjExLstByPager_Cache = gs_AnswerCountEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_AnswerCountEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrgs_AnswerCountExObjLst = await (0, clsgs_AnswerCountWApi_js_2.gs_AnswerCount_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_AnswerCountExObjLst) {
                const conFuncMap = await gs_AnswerCountEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_AnswerCountExObjLst.length == 0)
            return arrgs_AnswerCountExObjLst;
        let arrgs_AnswerCount_Sel = arrgs_AnswerCountExObjLst;
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
                arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.sort(gs_AnswerCountEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.slice(intStart, intEnd);
            return arrgs_AnswerCount_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_AnswerCountEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_AnswerCountEx_GetObjExLstByPagerAsync = gs_AnswerCountEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_AnswerCountEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsgs_AnswerCountWApi_js_2.gs_AnswerCount_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsgs_AnswerCountWApi_js_2.gs_AnswerCount_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.gs_AnswerCountEx_SortFunByKey = gs_AnswerCountEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function gs_AnswerCountEx_FuncMapByFldName(strFldName, objgs_AnswerCountEx) {
        const strThisFuncName = gs_AnswerCountEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.gs_AnswerCountEx_FuncMapByFldName = gs_AnswerCountEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_AnswerCountEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsgs_AnswerCountWApi_js_1.gs_AnswerCount_FilterFunByKey)(strKey, value);
        }
    }
    exports.gs_AnswerCountEx_FilterFunByKey = gs_AnswerCountEx_FilterFunByKey;
    /// <summary>
    /// 调用WebApi来添加记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    /// </summary>
    /// <param name = "objgs_AnswerCountEN">需要添加的对象</param>
    /// <returns>获取相应的记录的对象</returns>
    async function gs_AnswerCountEx_AddNewRecordWithMaxIdAsync(objgs_AnswerCountEN) {
        var strMsg = "";
        var strAction = "AddNewRecordWithMaxId";
        //var strJSON = JSON.stringify(objgs_AnswerCountEN_Sim);
        let strUrl = gs_AnswerCountEx_GetWebApiUrl(exports.gs_AnswerCountEx_Controller, strAction);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objgs_AnswerCountEN,
                success: function (data) {
                    if (data.ErrorId == 0) {
                        resolve(data.ReturnStr);
                    }
                    else {
                        console.log(data.ErrorMsg);
                        reject(data.ErrorMsg);
                    }
                },
                error: function (result) {
                    console.log(result);
                    console.log(JSON.stringify(result));
                    if (result.statusText == "error") {
                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
                        reject(strInfo);
                    }
                    else {
                        reject(result.statusText);
                    }
                }
            });
        });
    }
    exports.gs_AnswerCountEx_AddNewRecordWithMaxIdAsync = gs_AnswerCountEx_AddNewRecordWithMaxIdAsync;
    ;
    async function gs_AnswerCountEx_GetAnswerCountByTableAsync(strId_CurrEduCls, updUser) {
        var strAction = "GetAnswerCountByTable";
        let strUrl = gs_AnswerCountEx_GetWebApiUrl(exports.gs_AnswerCountEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strId_CurrEduCls", strId_CurrEduCls);
        mapParam.add("updUser", updUser);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    if (data.ErrorId == 0) {
                        resolve(data.ReturnBool);
                    }
                    else {
                        console.log(data.ErrorMsg);
                        reject(data.ErrorMsg);
                    }
                },
                error: function (result) {
                    console.log(result);
                    console.log(JSON.stringify(result));
                    if (result.statusText == "error") {
                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
                        reject(strInfo);
                    }
                    else {
                        reject(result.statusText);
                    }
                }
            });
        });
    }
    exports.gs_AnswerCountEx_GetAnswerCountByTableAsync = gs_AnswerCountEx_GetAnswerCountByTableAsync;
    ;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function gs_AnswerCountEx_GetObjLst_ClientCache(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            var arrgs_AnswerCountObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            return arrgs_AnswerCountObjLst_Cache;
        }
        try {
            const responseText = await gs_AnswerCountEx_GetAnswerCountNumObjLstAsync(strWhereCond);
            var arrgs_AnswerCountObjLst = responseText;
            CacheHelper_js_1.CacheHelper.Add(strKey, arrgs_AnswerCountObjLst);
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrgs_AnswerCountObjLst.length}!`;
            console.log(strInfo);
            return arrgs_AnswerCountObjLst;
        }
        catch (e) {
            console.log("GetObjLst_Cache:e");
            console.error(e);
            var strMsg = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            throw (strMsg);
        }
    }
    exports.gs_AnswerCountEx_GetObjLst_ClientCache = gs_AnswerCountEx_GetObjLst_ClientCache;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function gs_AnswerCountEx_GetObjLst_Cache(strid_CurrEduCls) {
        var arrgs_AnswerCountObjLst_Cache;
        switch (clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_AnswerCountObjLst_Cache = await (0, clsgs_AnswerCountWApi_js_1.gs_AnswerCount_GetObjLst_sessionStorage)(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrgs_AnswerCountObjLst_Cache = await (0, clsgs_AnswerCountWApi_js_1.gs_AnswerCount_GetObjLst_localStorage)(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrgs_AnswerCountObjLst_Cache = await (0, clsgs_AnswerCountWApi_js_1.gs_AnswerCount_GetObjLst_ClientCache)(strid_CurrEduCls);
                break;
            default:
                arrgs_AnswerCountObjLst_Cache = await (0, clsgs_AnswerCountWApi_js_1.gs_AnswerCount_GetObjLst_ClientCache)(strid_CurrEduCls);
                break;
        }
        return arrgs_AnswerCountObjLst_Cache;
    }
    exports.gs_AnswerCountEx_GetObjLst_Cache = gs_AnswerCountEx_GetObjLst_Cache;
    /// <summary>
    /// 根据条件对象, 从缓存的对象列表中获取子集.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
    /// </summary>
    /// <param name = "objstrAnswerCountId_Cond">条件对象</param>
    /// <returns>对象列表子集</returns>
    async function gs_AnswerCountEx_GetSubObjLst_Cache(objgs_AnswerCount_Cond, strid_CurrEduCls) {
        var arrgs_AnswerCountObjLst_Cache = await gs_AnswerCountEx_GetObjLst_Cache(strid_CurrEduCls);
        var arrgs_AnswerCount_Sel = arrgs_AnswerCountObjLst_Cache.filter(x => true);
        if (objgs_AnswerCount_Cond.sf_FldComparisonOp == null || objgs_AnswerCount_Cond.sf_FldComparisonOp == "")
            return arrgs_AnswerCount_Sel;
        var dicFldComparisonOp = JSON.parse(objgs_AnswerCount_Cond.sf_FldComparisonOp);
        //console.log("clsgs_AnswerCountWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objgs_AnswerCount_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = objgs_AnswerCount_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            return arrgs_AnswerCount_Sel;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${JSON.stringify(objgs_AnswerCount_Cond)}]缓存对象列表中获取子集对象不成功!`;
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_AnswerCountEx_GetSubObjLst_Cache = gs_AnswerCountEx_GetSubObjLst_Cache;
    ;
    /// <summary>
    /// 获取论文中的用户数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function gs_AnswerCountEx_GetAnswerCountNumObjLstAsync(strWhereCond) {
        var strAction = "GetAnswerCountNumObjLst";
        let strUrl = gs_AnswerCountEx_GetWebApiUrl(exports.gs_AnswerCountEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    if (data.ErrorId == 0) {
                        var returnObjLst = JSON.parse(data.ReturnObjLst);
                        //console.log(returnObjLst);
                        resolve(returnObjLst);
                    }
                    else {
                        console.log(data.ErrorMsg);
                        reject(data.ErrorMsg);
                    }
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.gs_AnswerCountEx_GetAnswerCountNumObjLstAsync = gs_AnswerCountEx_GetAnswerCountNumObjLstAsync;
    ;
    /// <summary>
    /// 获取讨论回答的周数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function gs_AnswerCountEx_GetWeekAnswerCountNumObjLstAsync(strWhereCond) {
        var strAction = "GetWeekAnswerCountNumObjLst";
        let strUrl = gs_AnswerCountEx_GetWebApiUrl(exports.gs_AnswerCountEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    if (data.ErrorId == 0) {
                        var returnObjLst = JSON.parse(data.ReturnObjLst);
                        //console.log(returnObjLst);
                        resolve(returnObjLst);
                    }
                    else {
                        console.log(data.ErrorMsg);
                        reject(data.ErrorMsg);
                    }
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.gs_AnswerCountEx_GetWeekAnswerCountNumObjLstAsync = gs_AnswerCountEx_GetWeekAnswerCountNumObjLstAsync;
    ;
});
