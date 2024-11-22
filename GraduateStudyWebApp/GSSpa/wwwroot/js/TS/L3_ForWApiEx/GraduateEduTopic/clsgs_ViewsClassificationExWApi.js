/**
* 类名:clsgs_ViewsClassificationExWApi
* 表名:gs_ViewsClassification(01120777)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:47:13
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培主题(GraduateEduTopic)
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/GraduateEduTopic/clsgs_ViewsClassificationEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/GraduateEduTopic/clsgs_ViewsClassificationENEx.js", "../../L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js", "../../L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_ViewsClassificationEx_FilterFunByKey = exports.gs_ViewsClassificationEx_FuncMapByFldName = exports.gs_ViewsClassificationEx_SortFunByKey = exports.gs_ViewsClassificationEx_GetObjExLstByPagerAsync = exports.gs_ViewsClassificationEx_GetObjExLstByPager_Cache = exports.gs_ViewsClassificationEx_CopyToEx = exports.gs_ViewsClassificationEx_GetWebApiUrl = exports.gs_ViewsClassificationEx_ConstructorName = exports.gs_ViewsClassificationEx_Controller = void 0;
    /**
    * 各观点分类表(gs_ViewsClassification)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
   * Created by pyf on 2022年11月02日.
   * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsgs_ViewsClassificationWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsgs_ViewsClassificationEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_ViewsClassificationEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clsgs_ViewsClassificationENEx_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_ViewsClassificationENEx.js");
    const clsgs_ViewsClassificationWApi_js_2 = require("../../L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js");
    const clsgs_ViewsClassificationWApi_js_3 = require("../../L3_ForWApi/GraduateEduTopic/clsgs_ViewsClassificationWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    exports.gs_ViewsClassificationEx_Controller = "gs_ViewsClassificationExApi";
    exports.gs_ViewsClassificationEx_ConstructorName = "gs_ViewsClassificationEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function gs_ViewsClassificationEx_GetWebApiUrl(strController, strAction) {
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
    exports.gs_ViewsClassificationEx_GetWebApiUrl = gs_ViewsClassificationEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objgs_ViewsClassificationENS:源对象
    * @returns 目标对象=>clsgs_ViewsClassificationEN:objgs_ViewsClassificationENT
    **/
    function gs_ViewsClassificationEx_CopyToEx(objgs_ViewsClassificationENS) {
        const strThisFuncName = gs_ViewsClassificationEx_CopyToEx.name;
        const objgs_ViewsClassificationENT = new clsgs_ViewsClassificationENEx_js_1.clsgs_ViewsClassificationENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_ViewsClassificationENT, objgs_ViewsClassificationENS);
            return objgs_ViewsClassificationENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.gs_ViewsClassificationEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objgs_ViewsClassificationENT;
        }
    }
    exports.gs_ViewsClassificationEx_CopyToEx = gs_ViewsClassificationEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_ViewsClassificationEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_ViewsClassificationObjLst = await (0, clsgs_ViewsClassificationWApi_js_1.gs_ViewsClassification_GetObjLst_Cache)();
        const arrgs_ViewsClassificationExObjLst = arrgs_ViewsClassificationObjLst.map(gs_ViewsClassificationEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_ViewsClassificationExObjLst) {
                const conFuncMap = await gs_ViewsClassificationEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_ViewsClassificationExObjLst.length == 0)
            return arrgs_ViewsClassificationExObjLst;
        let arrgs_ViewsClassification_Sel = arrgs_ViewsClassificationExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_ViewsClassification_Cond = new clsgs_ViewsClassificationENEx_js_1.clsgs_ViewsClassificationENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_ViewsClassification_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_ViewsClassificationWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_ViewsClassification_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_ViewsClassification_Sel.length == 0)
                return arrgs_ViewsClassification_Sel;
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
                arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.sort(gs_ViewsClassificationEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.slice(intStart, intEnd);
            return arrgs_ViewsClassification_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_ViewsClassificationEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_ViewsClassificationEx_GetObjExLstByPager_Cache = gs_ViewsClassificationEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_ViewsClassificationEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrgs_ViewsClassificationExObjLst = await (0, clsgs_ViewsClassificationWApi_js_2.gs_ViewsClassification_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_ViewsClassificationExObjLst) {
                const conFuncMap = await gs_ViewsClassificationEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_ViewsClassificationExObjLst.length == 0)
            return arrgs_ViewsClassificationExObjLst;
        let arrgs_ViewsClassification_Sel = arrgs_ViewsClassificationExObjLst;
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
                arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.sort(gs_ViewsClassificationEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.slice(intStart, intEnd);
            return arrgs_ViewsClassification_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_ViewsClassificationEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_ViewsClassificationEx_GetObjExLstByPagerAsync = gs_ViewsClassificationEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_ViewsClassificationEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsgs_ViewsClassificationWApi_js_3.gs_ViewsClassification_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsgs_ViewsClassificationWApi_js_3.gs_ViewsClassification_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.gs_ViewsClassificationEx_SortFunByKey = gs_ViewsClassificationEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function gs_ViewsClassificationEx_FuncMapByFldName(strFldName, objgs_ViewsClassificationEx) {
        const strThisFuncName = gs_ViewsClassificationEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsgs_ViewsClassificationEN_js_1.clsgs_ViewsClassificationEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.gs_ViewsClassificationEx_FuncMapByFldName = gs_ViewsClassificationEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_ViewsClassificationEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsgs_ViewsClassificationWApi_js_1.gs_ViewsClassification_FilterFunByKey)(strKey, value);
        }
    }
    exports.gs_ViewsClassificationEx_FilterFunByKey = gs_ViewsClassificationEx_FilterFunByKey;
});