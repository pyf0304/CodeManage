/*-- -- -- -- -- -- -- -- -- -- --
类名:clsJournalSubjectCategoryExWApi
表名:JournalSubjectCategory(01120931)
生成代码版本:2021.06.19.1
生成日期:2021/06/20 00:38:48
生成者:pyf
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培论文
模块英文名:GraduateEduPaper
框架-层名:WA_访问扩展层(WA_AccessEx)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == ==
*/
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryEN.js", "../../L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryENEx.js", "../../PubFun/tzDictionary.js", "../../L3_ForWApi/GraduateEduPaper/clsJournalSubjectCategoryWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js", "axios"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.JournalSubjectCategoryEx_ImportDataFromCsv = exports.JournalSubjectCategoryEx_FilterFunByKey = exports.JournalSubjectCategoryEx_FuncMapByFldName = exports.JournalSubjectCategoryEx_SortFunByKey = exports.JournalSubjectCategoryEx_GetObjExLstByPagerAsync = exports.JournalSubjectCategoryEx_GetObjExLstByPager_Cache = exports.JournalSubjectCategoryEx_CopyToEx = exports.JournalSubjectCategoryEx_GetWebApiUrl = exports.journalSubjectCategoryEx_ConstructorName = exports.journalSubjectCategoryEx_Controller = void 0;
    const clsJournalSubjectCategoryEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryEN.js");
    const clsJournalSubjectCategoryENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryENEx.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsJournalSubjectCategoryWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsJournalSubjectCategoryWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const axios_1 = __importDefault(require("axios"));
    exports.journalSubjectCategoryEx_Controller = "JournalSubjectCategoryExApi";
    exports.journalSubjectCategoryEx_ConstructorName = "journalSubjectCategoryEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function JournalSubjectCategoryEx_GetWebApiUrl(strController, strAction) {
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
    exports.JournalSubjectCategoryEx_GetWebApiUrl = JournalSubjectCategoryEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objJournalSubjectCategoryENS:源对象
    * @returns 目标对象=>clsJournalSubjectCategoryEN:objJournalSubjectCategoryENT
    **/
    function JournalSubjectCategoryEx_CopyToEx(objJournalSubjectCategoryENS) {
        const strThisFuncName = JournalSubjectCategoryEx_CopyToEx.name;
        const objJournalSubjectCategoryENT = new clsJournalSubjectCategoryENEx_js_1.clsJournalSubjectCategoryENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objJournalSubjectCategoryENT, objJournalSubjectCategoryENS);
            return objJournalSubjectCategoryENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.journalSubjectCategoryEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objJournalSubjectCategoryENT;
        }
    }
    exports.JournalSubjectCategoryEx_CopyToEx = JournalSubjectCategoryEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function JournalSubjectCategoryEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrJournalSubjectCategoryObjLst = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_GetObjLst_Cache)();
        const arrJournalSubjectCategoryExObjLst = arrJournalSubjectCategoryObjLst.map(JournalSubjectCategoryEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrJournalSubjectCategoryExObjLst) {
                const conFuncMap = await JournalSubjectCategoryEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrJournalSubjectCategoryExObjLst.length == 0)
            return arrJournalSubjectCategoryExObjLst;
        let arrJournalSubjectCategory_Sel = arrJournalSubjectCategoryExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objJournalSubjectCategory_Cond = new clsJournalSubjectCategoryENEx_js_1.clsJournalSubjectCategoryENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objJournalSubjectCategory_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsJournalSubjectCategoryWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objJournalSubjectCategory_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrJournalSubjectCategory_Sel.length == 0)
                return arrJournalSubjectCategory_Sel;
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
                arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.sort(JournalSubjectCategoryEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.sort(objPagerPara.sortFun);
            }
            arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.slice(intStart, intEnd);
            return arrJournalSubjectCategory_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.journalSubjectCategoryEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.JournalSubjectCategoryEx_GetObjExLstByPager_Cache = JournalSubjectCategoryEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function JournalSubjectCategoryEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrJournalSubjectCategoryObjLst = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_GetObjLstAsync)(objPagerPara.whereCond);
        const arrJournalSubjectCategoryExObjLst = arrJournalSubjectCategoryObjLst.map(JournalSubjectCategoryEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrJournalSubjectCategoryExObjLst) {
                const conFuncMap = await JournalSubjectCategoryEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrJournalSubjectCategoryExObjLst.length == 0)
            return arrJournalSubjectCategoryExObjLst;
        let arrJournalSubjectCategory_Sel = arrJournalSubjectCategoryExObjLst;
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
                arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.sort(JournalSubjectCategoryEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.sort(objPagerPara.sortFun);
            }
            arrJournalSubjectCategory_Sel = arrJournalSubjectCategory_Sel.slice(intStart, intEnd);
            return arrJournalSubjectCategory_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.journalSubjectCategoryEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.JournalSubjectCategoryEx_GetObjExLstByPagerAsync = JournalSubjectCategoryEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function JournalSubjectCategoryEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.JournalSubjectCategoryEx_SortFunByKey = JournalSubjectCategoryEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function JournalSubjectCategoryEx_FuncMapByFldName(strFldName, objJournalSubjectCategoryEx) {
        const strThisFuncName = JournalSubjectCategoryEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.JournalSubjectCategoryEx_FuncMapByFldName = JournalSubjectCategoryEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function JournalSubjectCategoryEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_FilterFunByKey)(strKey, value);
        }
    }
    exports.JournalSubjectCategoryEx_FilterFunByKey = JournalSubjectCategoryEx_FilterFunByKey;
    /// <summary>
    /// 导入Excel数据
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
    /// </summary>
    /// <param name = "strCsv">Csv格式的Excel数据</param>
    /// <param name = "strUserId">用户Id</param>
    /// <returns>获取的相应对象列表</returns>
    async function JournalSubjectCategoryEx_ImportDataFromCsv(strCsv, strUserId) {
        const strThisFuncName = "";
        var strAction = "ImportDataFromCsv";
        let strUrl = JournalSubjectCategoryEx_GetWebApiUrl(exports.journalSubjectCategoryEx_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.journalSubjectCategoryEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.journalSubjectCategoryEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.JournalSubjectCategoryEx_ImportDataFromCsv = JournalSubjectCategoryEx_ImportDataFromCsv;
});
