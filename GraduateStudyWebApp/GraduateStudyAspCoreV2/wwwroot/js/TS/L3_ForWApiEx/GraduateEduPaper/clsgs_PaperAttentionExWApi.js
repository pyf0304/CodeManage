/**
* 类名:clsgs_PaperAttentionExWApi
* 表名:gs_PaperAttention(01120748)
* 版本:2023.02.18.1(服务器:WIN-SRV103-116)
* 日期:2023/02/18 14:54:25
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培论文(GraduateEduPaper)
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionENEx.js", "../../L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../../L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperAttentionEx_FilterFunByKey = exports.gs_PaperAttentionEx_FuncMapByFldName = exports.gs_PaperAttentionEx_SortFunByKey = exports.gs_PaperAttentionEx_GetObjExLstByPagerAsync = exports.gs_PaperAttentionEx_GetObjExLstByPager_Cache = exports.gs_PaperAttentionEx_CopyToEx = exports.gs_PaperAttentionEx_GetWebApiUrl = exports.gs_PaperAttentionEx_ConstructorName = exports.gs_PaperAttentionEx_Controller = void 0;
    /**
    * 论文关注(gs_PaperAttention)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
    * Created by pyf on 2023年02月18日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsgs_PaperAttentionWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsgs_PaperAttentionEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clsgs_PaperAttentionENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionENEx.js");
    const clsgs_PaperAttentionWApi_js_2 = require("../../L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsgs_PaperAttentionWApi_js_3 = require("../../L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsgs_PaperAttentionWApi_js_4 = require("../../L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    exports.gs_PaperAttentionEx_Controller = "gs_PaperAttentionExApi";
    exports.gs_PaperAttentionEx_ConstructorName = "gs_PaperAttentionEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function gs_PaperAttentionEx_GetWebApiUrl(strController, strAction) {
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
    exports.gs_PaperAttentionEx_GetWebApiUrl = gs_PaperAttentionEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objgs_PaperAttentionENS:源对象
    * @returns 目标对象=>clsgs_PaperAttentionEN:objgs_PaperAttentionENT
    **/
    function gs_PaperAttentionEx_CopyToEx(objgs_PaperAttentionENS) {
        const strThisFuncName = gs_PaperAttentionEx_CopyToEx.name;
        const objgs_PaperAttentionENT = new clsgs_PaperAttentionENEx_js_1.clsgs_PaperAttentionENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PaperAttentionENT, objgs_PaperAttentionENS);
            return objgs_PaperAttentionENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.gs_PaperAttentionEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objgs_PaperAttentionENT;
        }
    }
    exports.gs_PaperAttentionEx_CopyToEx = gs_PaperAttentionEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_PaperAttentionEx_GetObjExLstByPager_Cache(objPagerPara, strUserId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_PaperAttentionObjLst = await (0, clsgs_PaperAttentionWApi_js_1.gs_PaperAttention_GetObjLst_Cache)(strUserId);
        const arrgs_PaperAttentionExObjLst = arrgs_PaperAttentionObjLst.map(gs_PaperAttentionEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_PaperAttentionExObjLst) {
                const conFuncMap = await gs_PaperAttentionEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_PaperAttentionExObjLst.length == 0)
            return arrgs_PaperAttentionExObjLst;
        let arrgs_PaperAttention_Sel = arrgs_PaperAttentionExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_PaperAttention_Cond = new clsgs_PaperAttentionENEx_js_1.clsgs_PaperAttentionENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PaperAttention_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_PaperAttentionWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperAttention_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_PaperAttention_Sel.length == 0)
                return arrgs_PaperAttention_Sel;
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
                arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.sort(gs_PaperAttentionEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.slice(intStart, intEnd);
            return arrgs_PaperAttention_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_PaperAttentionEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_PaperAttentionEx_GetObjExLstByPager_Cache = gs_PaperAttentionEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_PaperAttentionEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrgs_PaperAttentionObjLst = await (0, clsgs_PaperAttentionWApi_js_2.gs_PaperAttention_GetObjLstAsync)(objPagerPara.whereCond);
        const arrgs_PaperAttentionExObjLst = arrgs_PaperAttentionObjLst.map(gs_PaperAttentionEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_PaperAttentionExObjLst) {
                const conFuncMap = await gs_PaperAttentionEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_PaperAttentionExObjLst.length == 0)
            return arrgs_PaperAttentionExObjLst;
        let arrgs_PaperAttention_Sel = arrgs_PaperAttentionExObjLst;
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
                arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.sort(gs_PaperAttentionEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.slice(intStart, intEnd);
            return arrgs_PaperAttention_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_PaperAttentionEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_PaperAttentionEx_GetObjExLstByPagerAsync = gs_PaperAttentionEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-18
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperAttentionEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsgs_PaperAttentionWApi_js_3.gs_PaperAttention_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsgs_PaperAttentionWApi_js_3.gs_PaperAttention_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.gs_PaperAttentionEx_SortFunByKey = gs_PaperAttentionEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2023-02-18
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function gs_PaperAttentionEx_FuncMapByFldName(strFldName, objgs_PaperAttentionEx) {
        const strThisFuncName = gs_PaperAttentionEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.gs_PaperAttentionEx_FuncMapByFldName = gs_PaperAttentionEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-02-18
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_PaperAttentionEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsgs_PaperAttentionWApi_js_4.gs_PaperAttention_FilterFunByKey)(strKey, value);
        }
    }
    exports.gs_PaperAttentionEx_FilterFunByKey = gs_PaperAttentionEx_FilterFunByKey;
});
