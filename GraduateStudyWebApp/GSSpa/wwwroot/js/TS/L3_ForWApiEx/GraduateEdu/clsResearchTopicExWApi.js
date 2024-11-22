/*-- -- -- -- -- -- -- -- -- -- --
类名:clsResearchTopicWApi
表名:ResearchTopic(01120546)
生成代码版本:2020.02.25.1
生成日期:2020/02/25 10:40:02
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
        define(["require", "exports", "jquery", "../../L0_Entity/GraduateEduTopic/clsResearchTopicEN.js", "../../PubFun/tzDictionary.js", "../../L0_Entity/GraduateEduTopic/clsResearchTopicENEx.js", "../../L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ResearchTopicEx_DelRecordAsyncEx = exports.ResearchTopicEx_FilterFunByKey = exports.ResearchTopicEx_FuncMapByFldName = exports.ResearchTopicEx_SortFunByKey = exports.ResearchTopicEx_GetObjExLstByPagerAsync = exports.ResearchTopicEx_GetObjExLstByPager_Cache = exports.ResearchTopicEx_CopyToEx = exports.ResearchTopicEx_GetWebApiUrl = exports.researchTopicEx_ConstructorName = exports.researchTopicEx_Controller = void 0;
    /// <summary>
    /// 研究主题(ResearchTopic)
    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by  on 2020年02月25日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    const $ = __importStar(require("jquery"));
    const clsResearchTopicEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsResearchTopicEN.js");
    //import { clsResearchTopicEN_Sim } from "../../L0_Entity/GraduateEdu/clsResearchTopicEN_Sim.js";
    //import { clsResearchTopicBL } from "../../L2_BLL/GraduateEdu/clsResearchTopicBL.js";
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsResearchTopicENEx_js_1 = require("../../L0_Entity/GraduateEduTopic/clsResearchTopicENEx.js");
    const clsResearchTopicWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    exports.researchTopicEx_Controller = "ResearchTopicExApi";
    exports.researchTopicEx_ConstructorName = "researchTopicEx";
    //export class clsResearchTopicExWApi {
    //    public static arrResearchTopicObjLst_Cache: Array<clsResearchTopicEN>;
    //    public static mstrController: string = "ResearchTopicExApi";
    //    public objResearchTopicEN: clsResearchTopicEN = new clsResearchTopicEN();
    //    constructor(pobjResearchTopicEN: clsResearchTopicEN) {
    //        this.objResearchTopicEN = pobjResearchTopicEN;
    //    };
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function ResearchTopicEx_GetWebApiUrl(strController, strAction) {
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
    exports.ResearchTopicEx_GetWebApiUrl = ResearchTopicEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objResearchTopicENS:源对象
    * @returns 目标对象=>clsResearchTopicEN:objResearchTopicENT
    **/
    function ResearchTopicEx_CopyToEx(objResearchTopicENS) {
        const strThisFuncName = ResearchTopicEx_CopyToEx.name;
        const objResearchTopicENT = new clsResearchTopicENEx_js_1.clsResearchTopicENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objResearchTopicENT, objResearchTopicENS);
            return objResearchTopicENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.researchTopicEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objResearchTopicENT;
        }
    }
    exports.ResearchTopicEx_CopyToEx = ResearchTopicEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function ResearchTopicEx_GetObjExLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrResearchTopicObjLst = await (0, clsResearchTopicWApi_js_1.ResearchTopic_GetObjLst_Cache)(strid_CurrEduCls);
        const arrResearchTopicExObjLst = arrResearchTopicObjLst.map(ResearchTopicEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrResearchTopicExObjLst) {
                const conFuncMap = await ResearchTopicEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrResearchTopicExObjLst.length == 0)
            return arrResearchTopicExObjLst;
        let arrResearchTopic_Sel = arrResearchTopicExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objResearchTopic_Cond = new clsResearchTopicENEx_js_1.clsResearchTopicENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objResearchTopic_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsResearchTopicWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objResearchTopic_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrResearchTopic_Sel = arrResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrResearchTopic_Sel.length == 0)
                return arrResearchTopic_Sel;
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
                arrResearchTopic_Sel = arrResearchTopic_Sel.sort(ResearchTopicEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrResearchTopic_Sel = arrResearchTopic_Sel.sort(objPagerPara.sortFun);
            }
            arrResearchTopic_Sel = arrResearchTopic_Sel.slice(intStart, intEnd);
            return arrResearchTopic_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.researchTopicEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ResearchTopicEx_GetObjExLstByPager_Cache = ResearchTopicEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function ResearchTopicEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrResearchTopicExObjLst = await (0, clsResearchTopicWApi_js_1.ResearchTopic_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrResearchTopicExObjLst) {
                const conFuncMap = await ResearchTopicEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrResearchTopicExObjLst.length == 0)
            return arrResearchTopicExObjLst;
        let arrResearchTopic_Sel = arrResearchTopicExObjLst;
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
                arrResearchTopic_Sel = arrResearchTopic_Sel.sort(ResearchTopicEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrResearchTopic_Sel = arrResearchTopic_Sel.sort(objPagerPara.sortFun);
            }
            arrResearchTopic_Sel = arrResearchTopic_Sel.slice(intStart, intEnd);
            return arrResearchTopic_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.researchTopicEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ResearchTopicEx_GetObjExLstByPagerAsync = ResearchTopicEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ResearchTopicEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsResearchTopicWApi_js_1.ResearchTopic_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsResearchTopicWApi_js_1.ResearchTopic_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.ResearchTopicEx_SortFunByKey = ResearchTopicEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function ResearchTopicEx_FuncMapByFldName(strFldName, objResearchTopicEx) {
        const strThisFuncName = ResearchTopicEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsResearchTopicEN_js_1.clsResearchTopicEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.ResearchTopicEx_FuncMapByFldName = ResearchTopicEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ResearchTopicEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsResearchTopicWApi_js_1.ResearchTopic_FilterFunByKey)(strKey, value);
        }
    }
    exports.ResearchTopicEx_FilterFunByKey = ResearchTopicEx_FilterFunByKey;
    /// <summary>
    /// 调用WebApi来删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    /// </summary>
    /// <param name = "strTopicId">关键字</param>
    /// <returns>获取删除的结果</returns>
    async function ResearchTopicEx_DelRecordAsyncEx(strTopicId) {
        var strAction = "DelRecordEx";
        let strUrl = ResearchTopicEx_GetWebApiUrl(exports.researchTopicEx_Controller, strAction);
        strUrl = `${strUrl}/${strTopicId}`;
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strTopicId", strTopicId);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "DELETE",
                dataType: "json",
                data: { "": strTopicId },
                success: function (data) {
                    if (data.ErrorId == 0) {
                        resolve(data.ReturnInt);
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
    exports.ResearchTopicEx_DelRecordAsyncEx = ResearchTopicEx_DelRecordAsyncEx;
    ;
});
