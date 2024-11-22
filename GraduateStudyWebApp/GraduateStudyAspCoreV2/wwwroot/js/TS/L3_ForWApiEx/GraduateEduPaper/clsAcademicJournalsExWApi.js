/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAcademicJournalsExWApi
表名:AcademicJournals(01120929)
生成代码版本:2021.06.19.1
生成日期:2021/06/20 00:38:43
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
        define(["require", "exports", "../../L0_Entity/GraduateEduPaper/clsAcademicJournalsEN.js", "../../L0_Entity/GraduateEduPaper/clsAcademicJournalsENEx.js", "../../PubFun/tzDictionary.js", "../../L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js", "axios"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.AcademicJournalsEx_ImportDataFromCsv = exports.AcademicJournalsEx_FilterFunByKey = exports.AcademicJournalsEx_FuncMapByFldName = exports.AcademicJournalsEx_SortFunByKey = exports.AcademicJournalsEx_GetObjExLstByPagerAsync = exports.AcademicJournalsEx_GetObjExLstByPager_Cache = exports.AcademicJournalsEx_CopyToEx = exports.AcademicJournalsEx_GetWebApiUrl = exports.academicJournalsEx_ConstructorName = exports.academicJournalsEx_Controller = void 0;
    const clsAcademicJournalsEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsAcademicJournalsEN.js");
    const clsAcademicJournalsENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsAcademicJournalsENEx.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsAcademicJournalsWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const axios_1 = __importDefault(require("axios"));
    exports.academicJournalsEx_Controller = "AcademicJournalsExApi";
    exports.academicJournalsEx_ConstructorName = "academicJournalsEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function AcademicJournalsEx_GetWebApiUrl(strController, strAction) {
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
    exports.AcademicJournalsEx_GetWebApiUrl = AcademicJournalsEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objAcademicJournalsENS:源对象
    * @returns 目标对象=>clsAcademicJournalsEN:objAcademicJournalsENT
    **/
    function AcademicJournalsEx_CopyToEx(objAcademicJournalsENS) {
        const strThisFuncName = AcademicJournalsEx_CopyToEx.name;
        const objAcademicJournalsENT = new clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objAcademicJournalsENT, objAcademicJournalsENS);
            return objAcademicJournalsENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.academicJournalsEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objAcademicJournalsENT;
        }
    }
    exports.AcademicJournalsEx_CopyToEx = AcademicJournalsEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function AcademicJournalsEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrAcademicJournalsObjLst = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_GetObjLst_Cache)();
        const arrAcademicJournalsExObjLst = arrAcademicJournalsObjLst.map(AcademicJournalsEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrAcademicJournalsExObjLst) {
                const conFuncMap = await AcademicJournalsEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrAcademicJournalsExObjLst.length == 0)
            return arrAcademicJournalsExObjLst;
        let arrAcademicJournals_Sel = arrAcademicJournalsExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objAcademicJournals_Cond = new clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objAcademicJournals_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsAcademicJournalsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objAcademicJournals_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrAcademicJournals_Sel = arrAcademicJournals_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrAcademicJournals_Sel.length == 0)
                return arrAcademicJournals_Sel;
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
                arrAcademicJournals_Sel = arrAcademicJournals_Sel.sort(AcademicJournalsEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrAcademicJournals_Sel = arrAcademicJournals_Sel.sort(objPagerPara.sortFun);
            }
            arrAcademicJournals_Sel = arrAcademicJournals_Sel.slice(intStart, intEnd);
            return arrAcademicJournals_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.academicJournalsEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.AcademicJournalsEx_GetObjExLstByPager_Cache = AcademicJournalsEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function AcademicJournalsEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrAcademicJournalsObjLst = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_GetObjLstAsync)(objPagerPara.whereCond);
        const arrAcademicJournalsExObjLst = arrAcademicJournalsObjLst.map(AcademicJournalsEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrAcademicJournalsExObjLst) {
                const conFuncMap = await AcademicJournalsEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrAcademicJournalsExObjLst.length == 0)
            return arrAcademicJournalsExObjLst;
        let arrAcademicJournals_Sel = arrAcademicJournalsExObjLst;
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
                arrAcademicJournals_Sel = arrAcademicJournals_Sel.sort(AcademicJournalsEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrAcademicJournals_Sel = arrAcademicJournals_Sel.sort(objPagerPara.sortFun);
            }
            arrAcademicJournals_Sel = arrAcademicJournals_Sel.slice(intStart, intEnd);
            return arrAcademicJournals_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.academicJournalsEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.AcademicJournalsEx_GetObjExLstByPagerAsync = AcademicJournalsEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-03
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function AcademicJournalsEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx.con_JournalSubjectCategoryName:
                    return (a, b) => {
                        return a.journalSubjectCategoryName.localeCompare(b.journalSubjectCategoryName);
                    };
                case clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx.con_JournalSubjectName:
                    return (a, b) => {
                        return a.journalSubjectName.localeCompare(b.journalSubjectName);
                    };
                case clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx.con_JournalSubjectCode:
                    return (a, b) => {
                        return a.journalSubjectCode.localeCompare(b.journalSubjectCode);
                    };
                default:
                    return (0, clsAcademicJournalsWApi_js_1.AcademicJournals_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                case clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx.con_JournalSubjectCategoryName:
                    return (a, b) => {
                        return b.journalSubjectCategoryName.localeCompare(a.journalSubjectCategoryName);
                    };
                case clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx.con_JournalSubjectName:
                    return (a, b) => {
                        return b.journalSubjectName.localeCompare(a.journalSubjectName);
                    };
                case clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx.con_JournalSubjectCode:
                    return (a, b) => {
                        return b.journalSubjectCode.localeCompare(a.journalSubjectCode);
                    };
                default:
                    return (0, clsAcademicJournalsWApi_js_1.AcademicJournals_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.AcademicJournalsEx_SortFunByKey = AcademicJournalsEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-03
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function AcademicJournalsEx_FuncMapByFldName(strFldName, objAcademicJournalsEx) {
        const strThisFuncName = AcademicJournalsEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.AcademicJournalsEx_FuncMapByFldName = AcademicJournalsEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-03
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function AcademicJournalsEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx.con_JournalSubjectCategoryName:
                return (obj) => {
                    return obj.journalSubjectCategoryName === value;
                };
            case clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx.con_JournalSubjectName:
                return (obj) => {
                    return obj.journalSubjectName === value;
                };
            case clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx.con_JournalSubjectCode:
                return (obj) => {
                    return obj.journalSubjectCode === value;
                };
            default:
                return (0, clsAcademicJournalsWApi_js_1.AcademicJournals_FilterFunByKey)(strKey, value);
        }
    }
    exports.AcademicJournalsEx_FilterFunByKey = AcademicJournalsEx_FilterFunByKey;
    /// <summary>
    /// 导入Excel数据
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
    /// </summary>
    /// <param name = "strCsv">Csv格式的Excel数据</param>
    /// <param name = "strUserId">用户Id</param>
    /// <returns>获取的相应对象列表</returns>
    async function AcademicJournalsEx_ImportDataFromCsv(strCsv, strUserId) {
        const strThisFuncName = "";
        var strAction = "ImportDataFromCsv";
        let strUrl = AcademicJournalsEx_GetWebApiUrl(exports.academicJournalsEx_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.academicJournalsEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.academicJournalsEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.AcademicJournalsEx_ImportDataFromCsv = AcademicJournalsEx_ImportDataFromCsv;
});
