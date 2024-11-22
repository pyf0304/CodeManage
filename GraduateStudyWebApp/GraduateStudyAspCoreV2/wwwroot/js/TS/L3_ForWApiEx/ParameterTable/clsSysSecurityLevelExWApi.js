/**
* 类名:clsSysSecurityLevelExWApi
* 表名:SysSecurityLevel(01120651)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/05 01:04:24
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培参数(ParameterTable)
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/ParameterTable/clsSysSecurityLevelEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/ParameterTable/clsSysSecurityLevelENEx.js", "../../L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js", "../../L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysSecurityLevelEx_FilterFunByKey = exports.SysSecurityLevelEx_FuncMapByFldName = exports.SysSecurityLevelEx_SortFunByKey = exports.SysSecurityLevelEx_GetObjExLstByPagerAsync = exports.SysSecurityLevelEx_GetObjExLstByPager_Cache = exports.SysSecurityLevelEx_CopyToEx = exports.SysSecurityLevelEx_GetWebApiUrl = exports.sysSecurityLevelEx_ConstructorName = exports.sysSecurityLevelEx_Controller = void 0;
    /**
    * 保密级别表(SysSecurityLevel)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
   * Created by pyf on 2022年11月05日.
   * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysSecurityLevelWApi_js_1 = require("../../L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysSecurityLevelEN_js_1 = require("../../L0_Entity/ParameterTable/clsSysSecurityLevelEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysSecurityLevelENEx_js_1 = require("../../L0_Entity/ParameterTable/clsSysSecurityLevelENEx.js");
    const clsSysSecurityLevelWApi_js_2 = require("../../L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js");
    const clsSysSecurityLevelWApi_js_3 = require("../../L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsSysSecurityLevelWApi_js_4 = require("../../L3_ForWApi/ParameterTable/clsSysSecurityLevelWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    exports.sysSecurityLevelEx_Controller = "SysSecurityLevelExApi";
    exports.sysSecurityLevelEx_ConstructorName = "sysSecurityLevelEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function SysSecurityLevelEx_GetWebApiUrl(strController, strAction) {
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
    exports.SysSecurityLevelEx_GetWebApiUrl = SysSecurityLevelEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objSysSecurityLevelENS:源对象
    * @returns 目标对象=>clsSysSecurityLevelEN:objSysSecurityLevelENT
    **/
    function SysSecurityLevelEx_CopyToEx(objSysSecurityLevelENS) {
        const strThisFuncName = SysSecurityLevelEx_CopyToEx.name;
        const objSysSecurityLevelENT = new clsSysSecurityLevelENEx_js_1.clsSysSecurityLevelENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysSecurityLevelENT, objSysSecurityLevelENS);
            return objSysSecurityLevelENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.sysSecurityLevelEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objSysSecurityLevelENT;
        }
    }
    exports.SysSecurityLevelEx_CopyToEx = SysSecurityLevelEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function SysSecurityLevelEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrSysSecurityLevelObjLst = await (0, clsSysSecurityLevelWApi_js_1.SysSecurityLevel_GetObjLst_Cache)();
        const arrSysSecurityLevelExObjLst = arrSysSecurityLevelObjLst.map(SysSecurityLevelEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrSysSecurityLevelExObjLst) {
                const conFuncMap = await SysSecurityLevelEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrSysSecurityLevelExObjLst.length == 0)
            return arrSysSecurityLevelExObjLst;
        let arrSysSecurityLevel_Sel = arrSysSecurityLevelExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objSysSecurityLevel_Cond = new clsSysSecurityLevelENEx_js_1.clsSysSecurityLevelENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysSecurityLevel_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsSysSecurityLevelWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysSecurityLevel_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSysSecurityLevel_Sel.length == 0)
                return arrSysSecurityLevel_Sel;
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
                arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.sort(SysSecurityLevelEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.sort(objPagerPara.sortFun);
            }
            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.slice(intStart, intEnd);
            return arrSysSecurityLevel_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sysSecurityLevelEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysSecurityLevelEx_GetObjExLstByPager_Cache = SysSecurityLevelEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function SysSecurityLevelEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrSysSecurityLevelObjLst = await (0, clsSysSecurityLevelWApi_js_2.SysSecurityLevel_GetObjLstAsync)(objPagerPara.whereCond);
        const arrSysSecurityLevelExObjLst = arrSysSecurityLevelObjLst.map(SysSecurityLevelEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrSysSecurityLevelExObjLst) {
                const conFuncMap = await SysSecurityLevelEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrSysSecurityLevelExObjLst.length == 0)
            return arrSysSecurityLevelExObjLst;
        let arrSysSecurityLevel_Sel = arrSysSecurityLevelExObjLst;
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
                arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.sort(SysSecurityLevelEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.sort(objPagerPara.sortFun);
            }
            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.slice(intStart, intEnd);
            return arrSysSecurityLevel_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sysSecurityLevelEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysSecurityLevelEx_GetObjExLstByPagerAsync = SysSecurityLevelEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysSecurityLevelEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsSysSecurityLevelWApi_js_3.SysSecurityLevel_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsSysSecurityLevelWApi_js_3.SysSecurityLevel_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.SysSecurityLevelEx_SortFunByKey = SysSecurityLevelEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function SysSecurityLevelEx_FuncMapByFldName(strFldName, objSysSecurityLevelEx) {
        const strThisFuncName = SysSecurityLevelEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.SysSecurityLevelEx_FuncMapByFldName = SysSecurityLevelEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SysSecurityLevelEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsSysSecurityLevelWApi_js_4.SysSecurityLevel_FilterFunByKey)(strKey, value);
        }
    }
    exports.SysSecurityLevelEx_FilterFunByKey = SysSecurityLevelEx_FilterFunByKey;
});
