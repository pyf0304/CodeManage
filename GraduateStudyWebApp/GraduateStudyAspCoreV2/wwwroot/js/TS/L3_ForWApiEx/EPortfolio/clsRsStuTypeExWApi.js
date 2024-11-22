/**
* 类名:clsRsStuTypeExWApi
* 表名:RsStuType(01120162)
* 版本:2023.01.08.1(服务器:WIN-SRV103-116)
* 日期:2023/01/09 02:20:34
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:成长档案(EPortfolio)
* 框架-层名:WA_访问扩展层(TS)(WA_AccessEx)
* 编程语言:TypeScript
* 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
  *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
**/
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/EPortfolio/clsRsStuTypeWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/EPortfolio/clsRsStuTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/EPortfolio/clsRsStuTypeENEx.js", "../../L3_ForWApi/EPortfolio/clsRsStuTypeWApi.js", "../../L3_ForWApi/EPortfolio/clsRsStuTypeWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/EPortfolio/clsRsStuTypeWApi.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.RsStuTypeEx_FilterFunByKey = exports.RsStuTypeEx_FuncMapByFldName = exports.RsStuTypeEx_SortFunByKey = exports.RsStuTypeEx_GetObjExLstByPagerAsync = exports.RsStuTypeEx_GetObjExLstByPager_Cache = exports.RsStuTypeEx_CopyToEx = exports.RsStuTypeEx_GetWebApiUrl = exports.rsStuTypeEx_ConstructorName = exports.rsStuTypeEx_Controller = void 0;
    /**
    * 学生类别(RsStuType)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
   * Created by pyf on 2023年01月09日.
   * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsRsStuTypeWApi_js_1 = require("../../L3_ForWApi/EPortfolio/clsRsStuTypeWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsRsStuTypeEN_js_1 = require("../../L0_Entity/EPortfolio/clsRsStuTypeEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clsRsStuTypeENEx_js_1 = require("../../L0_Entity/EPortfolio/clsRsStuTypeENEx.js");
    const clsRsStuTypeWApi_js_2 = require("../../L3_ForWApi/EPortfolio/clsRsStuTypeWApi.js");
    const clsRsStuTypeWApi_js_3 = require("../../L3_ForWApi/EPortfolio/clsRsStuTypeWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsRsStuTypeWApi_js_4 = require("../../L3_ForWApi/EPortfolio/clsRsStuTypeWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    exports.rsStuTypeEx_Controller = "RsStuTypeExApi";
    exports.rsStuTypeEx_ConstructorName = "rsStuTypeEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function RsStuTypeEx_GetWebApiUrl(strController, strAction) {
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
            strServiceUrl = (0, clsString_js_2.Format)("{0}/{1}/{2}", strCurrIPAddressAndPort, strController, strAction);
        }
        else {
            strServiceUrl = (0, clsString_js_2.Format)("{0}/{1}/{2}/{3}", strCurrIPAddressAndPort, clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx, strController, strAction);
        }
        return strServiceUrl;
    }
    exports.RsStuTypeEx_GetWebApiUrl = RsStuTypeEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objRsStuTypeENS:源对象
    * @returns 目标对象=>clsRsStuTypeEN:objRsStuTypeENT
    **/
    function RsStuTypeEx_CopyToEx(objRsStuTypeENS) {
        const strThisFuncName = RsStuTypeEx_CopyToEx.name;
        const objRsStuTypeENT = new clsRsStuTypeENEx_js_1.clsRsStuTypeENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objRsStuTypeENT, objRsStuTypeENS);
            return objRsStuTypeENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.rsStuTypeEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objRsStuTypeENT;
        }
    }
    exports.RsStuTypeEx_CopyToEx = RsStuTypeEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function RsStuTypeEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrRsStuTypeObjLst = await (0, clsRsStuTypeWApi_js_1.RsStuType_GetObjLst_Cache)();
        const arrRsStuTypeExObjLst = arrRsStuTypeObjLst.map(RsStuTypeEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrRsStuTypeExObjLst) {
                const conFuncMap = await RsStuTypeEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrRsStuTypeExObjLst.length == 0)
            return arrRsStuTypeExObjLst;
        let arrRsStuType_Sel = arrRsStuTypeExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objRsStuType_Cond = new clsRsStuTypeENEx_js_1.clsRsStuTypeENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objRsStuType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsRsStuTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRsStuType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrRsStuType_Sel.length == 0)
                return arrRsStuType_Sel;
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
                arrRsStuType_Sel = arrRsStuType_Sel.sort(RsStuTypeEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrRsStuType_Sel = arrRsStuType_Sel.sort(objPagerPara.sortFun);
            }
            arrRsStuType_Sel = arrRsStuType_Sel.slice(intStart, intEnd);
            return arrRsStuType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.rsStuTypeEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.RsStuTypeEx_GetObjExLstByPager_Cache = RsStuTypeEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function RsStuTypeEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrRsStuTypeObjLst = await (0, clsRsStuTypeWApi_js_2.RsStuType_GetObjLstAsync)(objPagerPara.whereCond);
        const arrRsStuTypeExObjLst = arrRsStuTypeObjLst.map(RsStuTypeEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrRsStuTypeExObjLst) {
                const conFuncMap = await RsStuTypeEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrRsStuTypeExObjLst.length == 0)
            return arrRsStuTypeExObjLst;
        let arrRsStuType_Sel = arrRsStuTypeExObjLst;
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
                arrRsStuType_Sel = arrRsStuType_Sel.sort(RsStuTypeEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrRsStuType_Sel = arrRsStuType_Sel.sort(objPagerPara.sortFun);
            }
            arrRsStuType_Sel = arrRsStuType_Sel.slice(intStart, intEnd);
            return arrRsStuType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.rsStuTypeEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.RsStuTypeEx_GetObjExLstByPagerAsync = RsStuTypeEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-01-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RsStuTypeEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsRsStuTypeWApi_js_3.RsStuType_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsRsStuTypeWApi_js_3.RsStuType_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.RsStuTypeEx_SortFunByKey = RsStuTypeEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2023-01-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function RsStuTypeEx_FuncMapByFldName(strFldName, objRsStuTypeEx) {
        const strThisFuncName = RsStuTypeEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsRsStuTypeEN_js_1.clsRsStuTypeEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.RsStuTypeEx_FuncMapByFldName = RsStuTypeEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-01-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function RsStuTypeEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsRsStuTypeWApi_js_4.RsStuType_FilterFunByKey)(strKey, value);
        }
    }
    exports.RsStuTypeEx_FilterFunByKey = RsStuTypeEx_FilterFunByKey;
});