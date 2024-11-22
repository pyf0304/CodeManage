(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/BaseInfo_Share/clsvXzMajorWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/BaseInfo_Share/clsvXzMajorEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/BaseInfo_Share/clsvXzMajorENEx.js", "../../L3_ForWApi/BaseInfo_Share/clsvXzMajorWApi.js", "../../L3_ForWApi/BaseInfo_Share/clsvXzMajorWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/BaseInfo_Share/clsvXzMajorWApi.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vXzMajorEx_FilterFunByKey = exports.vXzMajorEx_FuncMapByFldName = exports.vXzMajorEx_SortFunByKey = exports.vXzMajorEx_GetObjExLstByPagerAsync = exports.vXzMajorEx_GetObjExLstByPager_Cache = exports.vXzMajorEx_CopyToEx = exports.vXzMajorEx_GetWebApiUrl = exports.vXzMajorEx_ConstructorName = exports.vXzMajorEx_Controller = void 0;
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsvXzMajorWApi_js_1 = require("../../L3_ForWApi/BaseInfo_Share/clsvXzMajorWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsvXzMajorEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsvXzMajorEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clsvXzMajorENEx_js_1 = require("../../L0_Entity/BaseInfo_Share/clsvXzMajorENEx.js");
    const clsvXzMajorWApi_js_2 = require("../../L3_ForWApi/BaseInfo_Share/clsvXzMajorWApi.js");
    const clsvXzMajorWApi_js_3 = require("../../L3_ForWApi/BaseInfo_Share/clsvXzMajorWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsvXzMajorWApi_js_4 = require("../../L3_ForWApi/BaseInfo_Share/clsvXzMajorWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    exports.vXzMajorEx_Controller = "vXzMajorExApi";
    exports.vXzMajorEx_ConstructorName = "vXzMajorEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vXzMajorEx_GetWebApiUrl(strController, strAction) {
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
    exports.vXzMajorEx_GetWebApiUrl = vXzMajorEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvXzMajorENS:源对象
    * @returns 目标对象=>clsvXzMajorEN:objvXzMajorENT
    **/
    function vXzMajorEx_CopyToEx(objvXzMajorENS) {
        const strThisFuncName = vXzMajorEx_CopyToEx.name;
        const objvXzMajorENT = new clsvXzMajorENEx_js_1.clsvXzMajorENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvXzMajorENT, objvXzMajorENS);
            return objvXzMajorENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vXzMajorEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvXzMajorENT;
        }
    }
    exports.vXzMajorEx_CopyToEx = vXzMajorEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vXzMajorEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvXzMajorObjLst = await (0, clsvXzMajorWApi_js_1.vXzMajor_GetObjLst_Cache)();
        const arrvXzMajorExObjLst = arrvXzMajorObjLst.map(vXzMajorEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvXzMajorExObjLst) {
                const conFuncMap = await vXzMajorEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvXzMajorExObjLst.length == 0)
            return arrvXzMajorExObjLst;
        let arrvXzMajor_Sel = arrvXzMajorExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvXzMajor_Cond = new clsvXzMajorENEx_js_1.clsvXzMajorENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvXzMajor_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvXzMajorWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvXzMajor_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvXzMajor_Sel.length == 0)
                return arrvXzMajor_Sel;
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
                arrvXzMajor_Sel = arrvXzMajor_Sel.sort(vXzMajorEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvXzMajor_Sel = arrvXzMajor_Sel.sort(objPagerPara.sortFun);
            }
            arrvXzMajor_Sel = arrvXzMajor_Sel.slice(intStart, intEnd);
            return arrvXzMajor_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vXzMajorEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vXzMajorEx_GetObjExLstByPager_Cache = vXzMajorEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vXzMajorEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvXzMajorObjLst = await (0, clsvXzMajorWApi_js_2.vXzMajor_GetObjLstAsync)(objPagerPara.whereCond);
        const arrvXzMajorExObjLst = arrvXzMajorObjLst.map(vXzMajorEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvXzMajorExObjLst) {
                const conFuncMap = await vXzMajorEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvXzMajorExObjLst.length == 0)
            return arrvXzMajorExObjLst;
        let arrvXzMajor_Sel = arrvXzMajorExObjLst;
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
                arrvXzMajor_Sel = arrvXzMajor_Sel.sort(vXzMajorEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvXzMajor_Sel = arrvXzMajor_Sel.sort(objPagerPara.sortFun);
            }
            arrvXzMajor_Sel = arrvXzMajor_Sel.slice(intStart, intEnd);
            return arrvXzMajor_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vXzMajorEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vXzMajorEx_GetObjExLstByPagerAsync = vXzMajorEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vXzMajorEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsvXzMajorWApi_js_3.vXzMajor_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsvXzMajorWApi_js_3.vXzMajor_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vXzMajorEx_SortFunByKey = vXzMajorEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vXzMajorEx_FuncMapByFldName(strFldName, objvXzMajorEx) {
        const strThisFuncName = vXzMajorEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvXzMajorEN_js_1.clsvXzMajorEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vXzMajorEx_FuncMapByFldName = vXzMajorEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vXzMajorEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsvXzMajorWApi_js_4.vXzMajor_FilterFunByKey)(strKey, value);
        }
    }
    exports.vXzMajorEx_FilterFunByKey = vXzMajorEx_FilterFunByKey;
});
