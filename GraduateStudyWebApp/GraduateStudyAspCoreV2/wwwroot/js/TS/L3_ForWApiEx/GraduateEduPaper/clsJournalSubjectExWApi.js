var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduPaper/clsJournalSubjectEN.js", "../../L0_Entity/GraduateEduPaper/clsJournalSubjectENEx.js", "../../PubFun/tzDictionary.js", "../../L3_ForWApi/GraduateEduPaper/clsJournalSubjectWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js", "axios"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.JournalSubjectEx_ImportDataFromCsv = exports.JournalSubjectEx_FilterFunByKey = exports.JournalSubjectEx_FuncMapByFldName = exports.JournalSubjectEx_SortFunByKey = exports.JournalSubjectEx_GetObjExLstByPagerAsync = exports.JournalSubjectEx_GetObjExLstByPager_Cache = exports.JournalSubjectEx_CopyToEx = exports.JournalSubjectEx_GetWebApiUrl = exports.journalSubjectEx_ConstructorName = exports.journalSubjectEx_Controller = void 0;
    //import * as QQ from "q";
    const clsJournalSubjectEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsJournalSubjectEN.js");
    const clsJournalSubjectENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsJournalSubjectENEx.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    //import * as QQ from "q";
    const clsJournalSubjectWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsJournalSubjectWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const axios_1 = __importDefault(require("axios"));
    exports.journalSubjectEx_Controller = "JournalSubjectExApi";
    exports.journalSubjectEx_ConstructorName = "journalSubjectEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function JournalSubjectEx_GetWebApiUrl(strController, strAction) {
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
    exports.JournalSubjectEx_GetWebApiUrl = JournalSubjectEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objJournalSubjectENS:源对象
    * @returns 目标对象=>clsJournalSubjectEN:objJournalSubjectENT
    **/
    function JournalSubjectEx_CopyToEx(objJournalSubjectENS) {
        const strThisFuncName = JournalSubjectEx_CopyToEx.name;
        const objJournalSubjectENT = new clsJournalSubjectENEx_js_1.clsJournalSubjectENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objJournalSubjectENT, objJournalSubjectENS);
            return objJournalSubjectENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.journalSubjectEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objJournalSubjectENT;
        }
    }
    exports.JournalSubjectEx_CopyToEx = JournalSubjectEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function JournalSubjectEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrJournalSubjectObjLst = await (0, clsJournalSubjectWApi_js_1.JournalSubject_GetObjLst_Cache)();
        const arrJournalSubjectExObjLst = arrJournalSubjectObjLst.map(JournalSubjectEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrJournalSubjectExObjLst) {
                const conFuncMap = await JournalSubjectEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrJournalSubjectExObjLst.length == 0)
            return arrJournalSubjectExObjLst;
        let arrJournalSubject_Sel = arrJournalSubjectExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objJournalSubject_Cond = new clsJournalSubjectENEx_js_1.clsJournalSubjectENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objJournalSubject_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsJournalSubjectWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objJournalSubject_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrJournalSubject_Sel = arrJournalSubject_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrJournalSubject_Sel.length == 0)
                return arrJournalSubject_Sel;
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
                arrJournalSubject_Sel = arrJournalSubject_Sel.sort(JournalSubjectEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrJournalSubject_Sel = arrJournalSubject_Sel.sort(objPagerPara.sortFun);
            }
            arrJournalSubject_Sel = arrJournalSubject_Sel.slice(intStart, intEnd);
            return arrJournalSubject_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.journalSubjectEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.JournalSubjectEx_GetObjExLstByPager_Cache = JournalSubjectEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function JournalSubjectEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrJournalSubjectObjLst = await (0, clsJournalSubjectWApi_js_1.JournalSubject_GetObjLstAsync)(objPagerPara.whereCond);
        const arrJournalSubjectExObjLst = arrJournalSubjectObjLst.map(JournalSubjectEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrJournalSubjectExObjLst) {
                const conFuncMap = await JournalSubjectEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrJournalSubjectExObjLst.length == 0)
            return arrJournalSubjectExObjLst;
        let arrJournalSubject_Sel = arrJournalSubjectExObjLst;
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
                arrJournalSubject_Sel = arrJournalSubject_Sel.sort(JournalSubjectEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrJournalSubject_Sel = arrJournalSubject_Sel.sort(objPagerPara.sortFun);
            }
            arrJournalSubject_Sel = arrJournalSubject_Sel.slice(intStart, intEnd);
            return arrJournalSubject_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.journalSubjectEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.JournalSubjectEx_GetObjExLstByPagerAsync = JournalSubjectEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-03
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function JournalSubjectEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsJournalSubjectENEx_js_1.clsJournalSubjectENEx.con_JournalSubjectCategoryName:
                    return (a, b) => {
                        return a.journalSubjectCategoryName.localeCompare(b.journalSubjectCategoryName);
                    };
                default:
                    return (0, clsJournalSubjectWApi_js_1.JournalSubject_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                case clsJournalSubjectENEx_js_1.clsJournalSubjectENEx.con_JournalSubjectCategoryName:
                    return (a, b) => {
                        return b.journalSubjectCategoryName.localeCompare(a.journalSubjectCategoryName);
                    };
                default:
                    return (0, clsJournalSubjectWApi_js_1.JournalSubject_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.JournalSubjectEx_SortFunByKey = JournalSubjectEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-03
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function JournalSubjectEx_FuncMapByFldName(strFldName, objJournalSubjectEx) {
        const strThisFuncName = JournalSubjectEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsJournalSubjectEN_js_1.clsJournalSubjectEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.JournalSubjectEx_FuncMapByFldName = JournalSubjectEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-03
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function JournalSubjectEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsJournalSubjectENEx_js_1.clsJournalSubjectENEx.con_JournalSubjectCategoryName:
                return (obj) => {
                    return obj.journalSubjectCategoryName === value;
                };
            default:
                return (0, clsJournalSubjectWApi_js_1.JournalSubject_FilterFunByKey)(strKey, value);
        }
    }
    exports.JournalSubjectEx_FilterFunByKey = JournalSubjectEx_FilterFunByKey;
    /// <summary>
    /// 导入Excel数据
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
    /// </summary>
    /// <param name = "strCsv">Csv格式的Excel数据</param>
    /// <param name = "strUserId">用户Id</param>
    /// <returns>获取的相应对象列表</returns>
    async function JournalSubjectEx_ImportDataFromCsv(strCsv, strUserId) {
        const strThisFuncName = "";
        var strAction = "ImportDataFromCsv";
        let strUrl = JournalSubjectEx_GetWebApiUrl(exports.journalSubjectEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strCsv", strCsv);
        mapParam.add("strUserId", strUserId);
        var objExcelData = { Csv: strCsv, userId: strUserId, Id_Grade: "", bolRound: false };
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strCsv": strCsv,
                    "strUserId": strUserId
                }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubjectEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubjectEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubjectEx_ImportDataFromCsv = JournalSubjectEx_ImportDataFromCsv;
});
