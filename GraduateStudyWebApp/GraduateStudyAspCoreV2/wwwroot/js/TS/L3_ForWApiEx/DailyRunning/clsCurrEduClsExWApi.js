(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js", "../../L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js", "../../L0_Entity/DailyRunning_Share/clsCurrEduClsENEx.js", "../../L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CurrEduClsEx_GetCourseIdById_CurrEduCls = exports.CurrEduClsEx_SortFun_IntTag = exports.CurrEduClsEx_SetObjLst_localStorage = exports.CurrEduClsEx_GetObjLst_localStorage = exports.CurrEduClsEx_FilterFunByKey = exports.CurrEduClsEx_FuncMapByFldName = exports.CurrEduClsEx_SortFunByKey = exports.CurrEduClsEx_GetObjExLstByPagerAsync = exports.CurrEduClsEx_GetObjExLstByPager_Cache = exports.CurrEduClsEx_CopyToEx = exports.CurrEduClsEx_GetWebApiUrl = exports.currEduClsEx_ConstructorName = exports.currEduClsEx_Controller = void 0;
    //import * as QQ from "q";
    const clsCurrEduClsEN_js_1 = require("../../L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js");
    const clsCurrEduClsWApi_js_1 = require("../../L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js");
    const clsCurrEduClsENEx_js_1 = require("../../L0_Entity/DailyRunning_Share/clsCurrEduClsENEx.js");
    const clsCurrEduClsWApi_js_2 = require("../../L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsPublocalStorage_js_1 = require("../../PubFun/clsPublocalStorage.js");
    exports.currEduClsEx_Controller = "CurrEduClsExApi";
    exports.currEduClsEx_ConstructorName = "currEduClsEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function CurrEduClsEx_GetWebApiUrl(strController, strAction) {
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
    exports.CurrEduClsEx_GetWebApiUrl = CurrEduClsEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objCurrEduClsENS:源对象
    * @returns 目标对象=>clsCurrEduClsEN:objCurrEduClsENT
    **/
    function CurrEduClsEx_CopyToEx(objCurrEduClsENS) {
        const strThisFuncName = CurrEduClsEx_CopyToEx.name;
        const objCurrEduClsENT = new clsCurrEduClsENEx_js_1.clsCurrEduClsENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objCurrEduClsENT, objCurrEduClsENS);
            return objCurrEduClsENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.currEduClsEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objCurrEduClsENT;
        }
    }
    exports.CurrEduClsEx_CopyToEx = CurrEduClsEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function CurrEduClsEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const strCourseId = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
        const arrCurrEduClsObjLst = await (0, clsCurrEduClsWApi_js_2.CurrEduCls_GetObjLst_Cache)(strCourseId);
        const arrCurrEduClsExObjLst = arrCurrEduClsObjLst.map(CurrEduClsEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrCurrEduClsExObjLst) {
                const conFuncMap = await CurrEduClsEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrCurrEduClsExObjLst.length == 0)
            return arrCurrEduClsExObjLst;
        let arrCurrEduCls_Sel = arrCurrEduClsExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objCurrEduCls_Cond = new clsCurrEduClsENEx_js_1.clsCurrEduClsENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objCurrEduCls_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsCurrEduClsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCurrEduCls_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrCurrEduCls_Sel.length == 0)
                return arrCurrEduCls_Sel;
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
                arrCurrEduCls_Sel = arrCurrEduCls_Sel.sort(CurrEduClsEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrCurrEduCls_Sel = arrCurrEduCls_Sel.sort(objPagerPara.sortFun);
            }
            arrCurrEduCls_Sel = arrCurrEduCls_Sel.slice(intStart, intEnd);
            return arrCurrEduCls_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.currEduClsEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CurrEduClsEx_GetObjExLstByPager_Cache = CurrEduClsEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function CurrEduClsEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrCurrEduClsObjLst = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetObjLstAsync)(objPagerPara.whereCond);
        const arrCurrEduClsExObjLst = arrCurrEduClsObjLst.map(CurrEduClsEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrCurrEduClsExObjLst) {
                const conFuncMap = await CurrEduClsEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrCurrEduClsExObjLst.length == 0)
            return arrCurrEduClsExObjLst;
        let arrCurrEduCls_Sel = arrCurrEduClsExObjLst;
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
                arrCurrEduCls_Sel = arrCurrEduCls_Sel.sort(CurrEduClsEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrCurrEduCls_Sel = arrCurrEduCls_Sel.sort(objPagerPara.sortFun);
            }
            arrCurrEduCls_Sel = arrCurrEduCls_Sel.slice(intStart, intEnd);
            return arrCurrEduCls_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.currEduClsEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CurrEduClsEx_GetObjExLstByPagerAsync = CurrEduClsEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CurrEduClsEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsCurrEduClsWApi_js_2.CurrEduCls_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsCurrEduClsWApi_js_2.CurrEduCls_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.CurrEduClsEx_SortFunByKey = CurrEduClsEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function CurrEduClsEx_FuncMapByFldName(strFldName, objCurrEduClsEx) {
        const strThisFuncName = CurrEduClsEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsCurrEduClsEN_js_1.clsCurrEduClsEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.CurrEduClsEx_FuncMapByFldName = CurrEduClsEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function CurrEduClsEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsCurrEduClsWApi_js_2.CurrEduCls_FilterFunByKey)(strKey, value);
        }
    }
    exports.CurrEduClsEx_FilterFunByKey = CurrEduClsEx_FilterFunByKey;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function CurrEduClsEx_GetObjLst_localStorage() {
        //初始化列表缓存
        var strWhereCond = "1=1";
        var strKey = clsCurrEduClsEN_js_1.clsCurrEduClsEN._CurrTabName;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (localStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            var strTempObjLst = localStorage.getItem(strKey);
            var arrCurrEduClsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrCurrEduClsObjLst_Cache;
        }
        //try {
        //    const responseText = await CurrEduCls_GetObjLstAsync(strWhereCond);
        //    var arrCurrEduClsObjLst: Array<clsCurrEduClsEN> = <Array<clsCurrEduClsEN>>responseText;
        //    localStorage.setItem(strKey, JSON.stringify(arrCurrEduClsObjLst));
        //    var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrCurrEduClsObjLst.length}!`;
        //    console.log(strInfo);
        //    return arrCurrEduClsObjLst;
        //}
        //catch (e) {
        //    console.log("GetObjLst_Cache:e");
        //    console.error(e);
        //    var strMsg: string = `从缓存中获取所有对象列表出错,${e}.`;
        //    throw (strMsg);
        //}
    }
    exports.CurrEduClsEx_GetObjLst_localStorage = CurrEduClsEx_GetObjLst_localStorage;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function CurrEduClsEx_SetObjLst_localStorage(strid_CurrEduCls, strCourseId) {
        //清空本类缓存
        const responseText0 = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_ReFreshThisCache)(strCourseId);
        //初始化列表缓存
        var strWhereCond = "1=1 and id_CurrEduCls='" + strid_CurrEduCls + "'";
        var strKey = clsCurrEduClsEN_js_1.clsCurrEduClsEN._CurrTabName;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        //if (localStorage.hasOwnProperty(strKey)) {
        //    //缓存存在，直接返回
        //    var strTempObjLst: string = localStorage.getItem(strKey) as string;
        //    var arrCurrEduClsObjLst_Cache: Array<clsCurrEduClsEN> = JSON.parse(strTempObjLst);
        //    return arrCurrEduClsObjLst_Cache;
        //}
        try {
            //把当前教学班存入缓存内
            const responseText = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetObjLstAsync)(strWhereCond);
            var arrCurrEduClsObjLst = responseText;
            localStorage.setItem(strKey, JSON.stringify(arrCurrEduClsObjLst));
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrCurrEduClsObjLst.length}!`;
            console.log(strInfo);
            return arrCurrEduClsObjLst;
        }
        catch (e) {
            console.log("GetObjLst_Cache:e");
            console.error(e);
            var strMsg = `从缓存中获取所有对象列表出错,${e}.`;
            throw (strMsg);
        }
    }
    exports.CurrEduClsEx_SetObjLst_localStorage = CurrEduClsEx_SetObjLst_localStorage;
    /**
    * 排序函数。根据关键字字段的值进行比较
    * 作者:pyf
    * 日期:20211017113202
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
    * @param a:比较的第1个对象
    * @param  b:比较的第1个对象
    * @returns 返回两个对象比较的结果
    */
    function CurrEduClsEx_SortFun_IntTag(a, b) {
        const strThisFuncName = CurrEduClsEx_SortFun_IntTag.name;
        console.log('strThisFuncName', strThisFuncName);
        if (a.intTag == null)
            return 1;
        if (b.intTag == null)
            return 1;
        const strA = a.intTag.toString();
        const strB = b.intTag.toString();
        const intA = Number(strA);
        const intB = Number(strB);
        let intResult = intA - intB;
        return intResult;
    }
    exports.CurrEduClsEx_SortFun_IntTag = CurrEduClsEx_SortFun_IntTag;
    async function CurrEduClsEx_GetCourseIdById_CurrEduCls(strId_CurrEduCls) {
        const strThisFuncName = "GetCourseIdById_CurrEduCls";
        const objCurrEduCls = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetObjByid_CurrEduClsAsync)(strId_CurrEduCls);
        if (objCurrEduCls == null)
            return "";
        return objCurrEduCls.courseId;
    }
    exports.CurrEduClsEx_GetCourseIdById_CurrEduCls = CurrEduClsEx_GetCourseIdById_CurrEduCls;
});
