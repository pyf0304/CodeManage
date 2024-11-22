(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/DailyRunning/clsvCurrEduClsEN.js", "../../L0_Entity/DailyRunning/clsvCurrEduClsENEx.js", "../../L3_ForWApi/DailyRunning/clsvCurrEduClsWApi.js", "../../L3_ForWApi/DailyRunning/clsvCurrEduClsWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vCurrEduClsEx_FilterFunByKey = exports.vCurrEduClsEx_FuncMapByFldName = exports.vCurrEduClsEx_SortFunByKey = exports.vCurrEduClsEx_GetObjExLstByPagerAsync = exports.vCurrEduClsEx_GetObjExLstByPager_Cache = exports.vCurrEduClsEx_CopyToEx = exports.vCurrEduClsEx_GetWebApiUrl = exports.vCurrEduClsEx_ConstructorName = exports.vCurrEduClsEx_Controller = void 0;
    //import * as QQ from "q";
    const clsvCurrEduClsEN_js_1 = require("../../L0_Entity/DailyRunning/clsvCurrEduClsEN.js");
    const clsvCurrEduClsENEx_js_1 = require("../../L0_Entity/DailyRunning/clsvCurrEduClsENEx.js");
    const clsvCurrEduClsWApi_js_1 = require("../../L3_ForWApi/DailyRunning/clsvCurrEduClsWApi.js");
    //export class clsvCurrEduClsExWApi {
    //    public static mstrController: string = "vCurrEduClsExApi";
    const clsvCurrEduClsWApi_js_2 = require("../../L3_ForWApi/DailyRunning/clsvCurrEduClsWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    exports.vCurrEduClsEx_Controller = "vCurrEduClsExApi";
    exports.vCurrEduClsEx_ConstructorName = "vCurrEduClsEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vCurrEduClsEx_GetWebApiUrl(strController, strAction) {
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
    exports.vCurrEduClsEx_GetWebApiUrl = vCurrEduClsEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvCurrEduClsENS:源对象
    * @returns 目标对象=>clsvCurrEduClsEN:objvCurrEduClsENT
    **/
    function vCurrEduClsEx_CopyToEx(objvCurrEduClsENS) {
        const strThisFuncName = vCurrEduClsEx_CopyToEx.name;
        const objvCurrEduClsENT = new clsvCurrEduClsENEx_js_1.clsvCurrEduClsENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvCurrEduClsENT, objvCurrEduClsENS);
            return objvCurrEduClsENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vCurrEduClsEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvCurrEduClsENT;
        }
    }
    exports.vCurrEduClsEx_CopyToEx = vCurrEduClsEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vCurrEduClsEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvCurrEduClsObjLst = await (0, clsvCurrEduClsWApi_js_2.vCurrEduCls_GetObjLst_Cache)();
        const arrvCurrEduClsExObjLst = arrvCurrEduClsObjLst.map(vCurrEduClsEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvCurrEduClsExObjLst) {
                const conFuncMap = await vCurrEduClsEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvCurrEduClsExObjLst.length == 0)
            return arrvCurrEduClsExObjLst;
        let arrvCurrEduCls_Sel = arrvCurrEduClsExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvCurrEduCls_Cond = new clsvCurrEduClsENEx_js_1.clsvCurrEduClsENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvCurrEduCls_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvCurrEduClsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduCls_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvCurrEduCls_Sel.length == 0)
                return arrvCurrEduCls_Sel;
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
                arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.sort(vCurrEduClsEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.sort(objPagerPara.sortFun);
            }
            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.slice(intStart, intEnd);
            return arrvCurrEduCls_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vCurrEduClsEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vCurrEduClsEx_GetObjExLstByPager_Cache = vCurrEduClsEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vCurrEduClsEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvCurrEduClsObjLst = await (0, clsvCurrEduClsWApi_js_2.vCurrEduCls_GetObjLstAsync)(objPagerPara.whereCond);
        const arrvCurrEduClsExObjLst = arrvCurrEduClsObjLst.map(vCurrEduClsEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvCurrEduClsExObjLst) {
                const conFuncMap = await vCurrEduClsEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvCurrEduClsExObjLst.length == 0)
            return arrvCurrEduClsExObjLst;
        let arrvCurrEduCls_Sel = arrvCurrEduClsExObjLst;
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
                arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.sort(vCurrEduClsEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.sort(objPagerPara.sortFun);
            }
            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.slice(intStart, intEnd);
            return arrvCurrEduCls_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vCurrEduClsEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vCurrEduClsEx_GetObjExLstByPagerAsync = vCurrEduClsEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vCurrEduClsEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvCurrEduClsENEx_js_1.clsvCurrEduClsENEx.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvCurrEduClsENEx_js_1.clsvCurrEduClsENEx.con_TeachingDate:
                    return (a, b) => {
                        return a.teachingDate.localeCompare(b.teachingDate);
                    };
                default:
                    return (0, clsvCurrEduClsWApi_js_2.vCurrEduCls_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                case clsvCurrEduClsENEx_js_1.clsvCurrEduClsENEx.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvCurrEduClsENEx_js_1.clsvCurrEduClsENEx.con_TeachingDate:
                    return (a, b) => {
                        return b.teachingDate.localeCompare(a.teachingDate);
                    };
                default:
                    return (0, clsvCurrEduClsWApi_js_2.vCurrEduCls_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vCurrEduClsEx_SortFunByKey = vCurrEduClsEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vCurrEduClsEx_FuncMapByFldName(strFldName, objvCurrEduClsEx) {
        const strThisFuncName = vCurrEduClsEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vCurrEduClsEx_FuncMapByFldName = vCurrEduClsEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vCurrEduClsEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvCurrEduClsENEx_js_1.clsvCurrEduClsENEx.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvCurrEduClsENEx_js_1.clsvCurrEduClsENEx.con_TeachingDate:
                return (obj) => {
                    return obj.teachingDate === value;
                };
            default:
                return (0, clsvCurrEduClsWApi_js_1.vCurrEduCls_FilterFunByKey)(strKey, value);
        }
    }
    exports.vCurrEduClsEx_FilterFunByKey = vCurrEduClsEx_FilterFunByKey;
});
