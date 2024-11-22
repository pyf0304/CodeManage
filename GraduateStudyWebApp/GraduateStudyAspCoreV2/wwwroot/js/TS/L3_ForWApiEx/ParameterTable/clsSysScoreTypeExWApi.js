/**
* 类名:clsSysScoreTypeExWApi
* 表名:SysScoreType(01120631)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/05 01:02:49
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/ParameterTable/clsSysScoreTypeWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/ParameterTable/clsSysScoreTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/ParameterTable/clsSysScoreTypeENEx.js", "../../L3_ForWApi/ParameterTable/clsSysScoreTypeWApi.js", "../../L3_ForWApi/ParameterTable/clsSysScoreTypeWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/ParameterTable/clsSysScoreTypeWApi.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysScoreTypeEx_FilterFunByKey = exports.SysScoreTypeEx_FuncMapByFldName = exports.SysScoreTypeEx_SortFunByKey = exports.SysScoreTypeEx_GetObjExLstByPagerAsync = exports.SysScoreTypeEx_GetObjExLstByPager_Cache = exports.SysScoreTypeEx_CopyToEx = exports.SysScoreTypeEx_GetWebApiUrl = exports.sysScoreTypeEx_ConstructorName = exports.sysScoreTypeEx_Controller = void 0;
    /**
    * 评分类型表(SysScoreType)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
   * Created by pyf on 2022年11月05日.
   * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysScoreTypeWApi_js_1 = require("../../L3_ForWApi/ParameterTable/clsSysScoreTypeWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysScoreTypeEN_js_1 = require("../../L0_Entity/ParameterTable/clsSysScoreTypeEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysScoreTypeENEx_js_1 = require("../../L0_Entity/ParameterTable/clsSysScoreTypeENEx.js");
    const clsSysScoreTypeWApi_js_2 = require("../../L3_ForWApi/ParameterTable/clsSysScoreTypeWApi.js");
    const clsSysScoreTypeWApi_js_3 = require("../../L3_ForWApi/ParameterTable/clsSysScoreTypeWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsSysScoreTypeWApi_js_4 = require("../../L3_ForWApi/ParameterTable/clsSysScoreTypeWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    exports.sysScoreTypeEx_Controller = "SysScoreTypeExApi";
    exports.sysScoreTypeEx_ConstructorName = "sysScoreTypeEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function SysScoreTypeEx_GetWebApiUrl(strController, strAction) {
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
    exports.SysScoreTypeEx_GetWebApiUrl = SysScoreTypeEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objSysScoreTypeENS:源对象
    * @returns 目标对象=>clsSysScoreTypeEN:objSysScoreTypeENT
    **/
    function SysScoreTypeEx_CopyToEx(objSysScoreTypeENS) {
        const strThisFuncName = SysScoreTypeEx_CopyToEx.name;
        const objSysScoreTypeENT = new clsSysScoreTypeENEx_js_1.clsSysScoreTypeENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysScoreTypeENT, objSysScoreTypeENS);
            return objSysScoreTypeENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.sysScoreTypeEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objSysScoreTypeENT;
        }
    }
    exports.SysScoreTypeEx_CopyToEx = SysScoreTypeEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function SysScoreTypeEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrSysScoreTypeObjLst = await (0, clsSysScoreTypeWApi_js_1.SysScoreType_GetObjLst_Cache)();
        const arrSysScoreTypeExObjLst = arrSysScoreTypeObjLst.map(SysScoreTypeEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrSysScoreTypeExObjLst) {
                const conFuncMap = await SysScoreTypeEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrSysScoreTypeExObjLst.length == 0)
            return arrSysScoreTypeExObjLst;
        let arrSysScoreType_Sel = arrSysScoreTypeExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objSysScoreType_Cond = new clsSysScoreTypeENEx_js_1.clsSysScoreTypeENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysScoreType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsSysScoreTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysScoreType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSysScoreType_Sel.length == 0)
                return arrSysScoreType_Sel;
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
                arrSysScoreType_Sel = arrSysScoreType_Sel.sort(SysScoreTypeEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrSysScoreType_Sel = arrSysScoreType_Sel.sort(objPagerPara.sortFun);
            }
            arrSysScoreType_Sel = arrSysScoreType_Sel.slice(intStart, intEnd);
            return arrSysScoreType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sysScoreTypeEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysScoreTypeEx_GetObjExLstByPager_Cache = SysScoreTypeEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function SysScoreTypeEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrSysScoreTypeObjLst = await (0, clsSysScoreTypeWApi_js_2.SysScoreType_GetObjLstAsync)(objPagerPara.whereCond);
        const arrSysScoreTypeExObjLst = arrSysScoreTypeObjLst.map(SysScoreTypeEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrSysScoreTypeExObjLst) {
                const conFuncMap = await SysScoreTypeEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrSysScoreTypeExObjLst.length == 0)
            return arrSysScoreTypeExObjLst;
        let arrSysScoreType_Sel = arrSysScoreTypeExObjLst;
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
                arrSysScoreType_Sel = arrSysScoreType_Sel.sort(SysScoreTypeEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrSysScoreType_Sel = arrSysScoreType_Sel.sort(objPagerPara.sortFun);
            }
            arrSysScoreType_Sel = arrSysScoreType_Sel.slice(intStart, intEnd);
            return arrSysScoreType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sysScoreTypeEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysScoreTypeEx_GetObjExLstByPagerAsync = SysScoreTypeEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysScoreTypeEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsSysScoreTypeWApi_js_3.SysScoreType_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsSysScoreTypeWApi_js_3.SysScoreType_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.SysScoreTypeEx_SortFunByKey = SysScoreTypeEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function SysScoreTypeEx_FuncMapByFldName(strFldName, objSysScoreTypeEx) {
        const strThisFuncName = SysScoreTypeEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.SysScoreTypeEx_FuncMapByFldName = SysScoreTypeEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SysScoreTypeEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsSysScoreTypeWApi_js_4.SysScoreType_FilterFunByKey)(strKey, value);
        }
    }
    exports.SysScoreTypeEx_FilterFunByKey = SysScoreTypeEx_FilterFunByKey;
});
