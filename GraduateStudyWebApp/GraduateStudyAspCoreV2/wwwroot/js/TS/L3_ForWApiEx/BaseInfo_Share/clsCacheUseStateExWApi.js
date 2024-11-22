(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/SystemSet_Share/clsCacheUseStateEN.js", "../../L0_Entity/SystemSet_Share/clsCacheUseStateENEx.js", "../../L0_Entity/SystemSet_Share/clsCacheModeEN.js", "../../L3_ForWApi/SystemSet_Share/clsCacheUseStateWApi.js", "../../L3_ForWApi/SystemSet_Share/clsCacheModeWApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsDateTime.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CacheUseStateEx_SortFunByKey = exports.CacheUseStateEx_FuncMap_CacheModeENName = exports.CacheUseStateEx_FuncMap_CacheModeName = exports.CacheUseStateEx_FuncMapByFldName = exports.CacheUseStateEx_GetObjExLstByPager_Cache = exports.CacheUseStateEx_ClearSessionStorage = exports.CacheUseStateEx_ClearLocalStorage = exports.CacheUseStateEx_Subtotals = exports.CacheUseStateEx_GetCacheUseState = exports.CacheUseStateEx_getBytes = exports.CacheUseStateEx_LogCache4localStorage = exports.CacheUseStateEx_CopyToEx = exports.cacheUseStateEx_ConstructorName = exports.cacheUseStateEx_Controller = void 0;
    const clsCacheUseStateEN_js_1 = require("../../L0_Entity/SystemSet_Share/clsCacheUseStateEN.js");
    const clsCacheUseStateENEx_js_1 = require("../../L0_Entity/SystemSet_Share/clsCacheUseStateENEx.js");
    const clsCacheModeEN_js_1 = require("../../L0_Entity/SystemSet_Share/clsCacheModeEN.js");
    const clsCacheUseStateWApi_js_1 = require("../../L3_ForWApi/SystemSet_Share/clsCacheUseStateWApi.js");
    const clsCacheModeWApi_js_1 = require("../../L3_ForWApi/SystemSet_Share/clsCacheModeWApi.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsDateTime_js_1 = require("../../PubFun/clsDateTime.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.cacheUseStateEx_Controller = "CacheUseStateExApi";
    exports.cacheUseStateEx_ConstructorName = "cacheUseStateEx";
    /// <summary>
    /// 把同一个类的对象,复制到该类的扩展对象
    /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    /// </summary>
    /// <param name = "objCacheUseStateENS">源对象</param>
    /// <param name = "objCacheUseStateENT">目标对象</param>
    function CacheUseStateEx_CopyToEx(objCacheUseStateENS) {
        const objCacheUseStateENT = new clsCacheUseStateENEx_js_1.clsCacheUseStateENEx();
        objCacheUseStateENT.mId = objCacheUseStateENS.mId; //mId
        objCacheUseStateENT.cacheModeId = objCacheUseStateENS.cacheModeId; //缓存方式Id
        objCacheUseStateENT.cacheKey = objCacheUseStateENS.cacheKey; //缓存关键字
        objCacheUseStateENT.cacheSize = objCacheUseStateENS.cacheSize; //缓存大小
        objCacheUseStateENT.userId = objCacheUseStateENS.userId; //缓存大小
        objCacheUseStateENT.memo = objCacheUseStateENS.memo; //说明
        objCacheUseStateENT.sf_UpdFldSetStr = objCacheUseStateENS.updFldString; //专门用于记录某字段属性是否修改
        objCacheUseStateENT.sf_FldComparisonOp = objCacheUseStateENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
        return objCacheUseStateENT;
    }
    exports.CacheUseStateEx_CopyToEx = CacheUseStateEx_CopyToEx;
    function CacheUseStateEx_LogCache4localStorage(strKey, strUserId) {
        //strKey = localStorage.key(i)
        //if (strKey == null) continue;
        // let myCache;
        if ((0, clsString_js_1.IsNullOrEmpty)(strKey) == true)
            return;
        //strCacheKeyLst += Format("{0},", strKey);
        //拿到所有含u-的key
        const objCacheUseState = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
        objCacheUseState.cacheKey = strKey;
        objCacheUseState.userId = strUserId;
        objCacheUseState.useDate = clsDateTime_js_1.clsDateTime.getTodayDateTimeStr(1);
        objCacheUseState.cacheModeId = clsCacheModeEN_js_1.enumCacheMode.localStorage_03;
        const myCache = localStorage.getItem(strKey);
        if (myCache == null) {
            objCacheUseState.cacheSize = 0;
        }
        else {
            objCacheUseState.cacheSize = (0, clsString_js_1.getBytes)(myCache);
        }
    }
    exports.CacheUseStateEx_LogCache4localStorage = CacheUseStateEx_LogCache4localStorage;
    function CacheUseStateEx_getBytes(str) {
        const len = str.length;
        let bytes = len;
        for (let i = 0; i < len; i++) {
            if (str.charCodeAt(i) > 255)
                bytes++;
        }
        return bytes;
    }
    exports.CacheUseStateEx_getBytes = CacheUseStateEx_getBytes;
    async function CacheUseStateEx_GetCacheUseState(strUserId) {
        let strKey;
        let myCache;
        let strCacheKeyLst = "";
        const strCondition = (0, clsString_js_1.Format)("{0}='{1}'", clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId, strUserId);
        const conDelete = await (0, clsCacheUseStateWApi_js_1.CacheUseState_DelCacheUseStatesByCondAsync)(strCondition);
        for (let i = 0; i < localStorage.length; i++) {
            strKey = localStorage.key(i);
            if (strKey == null)
                continue;
            if ((0, clsString_js_1.IsNullOrEmpty)(strKey) == true)
                continue;
            strCacheKeyLst += (0, clsString_js_1.Format)("{0},", strKey);
            //拿到所有含u-的key
            const objCacheUseState = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
            objCacheUseState.cacheKey = strKey;
            objCacheUseState.userId = strUserId;
            objCacheUseState.useDate = clsDateTime_js_1.clsDateTime.getTodayDateTimeStr(1);
            objCacheUseState.cacheModeId = clsCacheModeEN_js_1.enumCacheMode.localStorage_03;
            myCache = localStorage.getItem(strKey);
            if (myCache == null) {
                objCacheUseState.cacheSize = 0;
            }
            else {
                objCacheUseState.cacheSize = (0, clsString_js_1.getBytes)(myCache);
            }
            try {
                await (0, clsCacheUseStateWApi_js_1.CacheUseState_AddNewRecordAsync)(objCacheUseState);
            }
            catch (e) {
                console.error(e);
            }
        }
        for (let i = 0; i < sessionStorage.length; i++) {
            strKey = sessionStorage.key(i);
            if (strKey == null)
                continue;
            if ((0, clsString_js_1.IsNullOrEmpty)(strKey) == true)
                continue;
            strCacheKeyLst += (0, clsString_js_1.Format)("{0},", strKey);
            //拿到所有含u-的key
            const objCacheUseState = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
            objCacheUseState.cacheKey = strKey;
            objCacheUseState.userId = strUserId;
            objCacheUseState.useDate = clsDateTime_js_1.clsDateTime.getTodayDateTimeStr(1);
            objCacheUseState.cacheModeId = clsCacheModeEN_js_1.enumCacheMode.sessionStorage_04;
            myCache = sessionStorage.getItem(strKey);
            if (myCache == null) {
                objCacheUseState.cacheSize = 0;
            }
            else {
                objCacheUseState.cacheSize = (0, clsString_js_1.getBytes)(myCache);
            }
            try {
                await (0, clsCacheUseStateWApi_js_1.CacheUseState_AddNewRecordAsync)(objCacheUseState);
            }
            catch (e) {
                console.error(e);
            }
        }
        for (let i = 0; i < CacheHelper_js_1.CacheHelper.CacheLength(); i++) {
            strKey = CacheHelper_js_1.CacheHelper.Key(i);
            if (strKey == null)
                continue;
            if ((0, clsString_js_1.IsNullOrEmpty)(strKey) == true)
                continue;
            strCacheKeyLst += (0, clsString_js_1.Format)("{0},", strKey);
            //拿到所有含u-的key
            const objCacheUseState = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
            objCacheUseState.cacheKey = strKey;
            objCacheUseState.userId = strUserId;
            objCacheUseState.useDate = clsDateTime_js_1.clsDateTime.getTodayDateTimeStr(1);
            objCacheUseState.cacheModeId = clsCacheModeEN_js_1.enumCacheMode.ClientCache_02;
            myCache = CacheHelper_js_1.CacheHelper.Get(strKey);
            if (myCache == null) {
                objCacheUseState.cacheSize = 0;
            }
            else {
                objCacheUseState.cacheSize = (0, clsString_js_1.getBytes)(myCache);
            }
            try {
                await (0, clsCacheUseStateWApi_js_1.CacheUseState_AddNewRecordAsync)(objCacheUseState);
            }
            catch (e) {
                console.error(e);
            }
        }
        (0, clsCacheUseStateWApi_js_1.CacheUseState_ReFreshCache)(strUserId);
        //alert(strCacheKeyLst);
        console.info('strCacheKeyLst:', strCacheKeyLst);
    }
    exports.CacheUseStateEx_GetCacheUseState = CacheUseStateEx_GetCacheUseState;
    async function CacheUseStateEx_Subtotals(strUserId) {
        const arrCacheUseStateObjLst = await (0, clsCacheUseStateWApi_js_1.CacheUseState_GetObjLst_Cache)(strUserId);
        const arrCacheMode = await (0, clsCacheModeWApi_js_1.CacheMode_GetObjLst_Cache)();
        arrCacheMode.forEach(x => {
            const arr_Sel = arrCacheUseStateObjLst.filter(y => y.cacheModeId == x.cacheModeId);
            let intTotals = 0;
            if (arr_Sel.length > 0) {
                const data = arr_Sel.map(z => z.cacheSize);
                data.forEach(d => intTotals += d);
                //                arr_Sel.reduce((intTotals, item) => intTotals + item.cacheSize, 0);
                intTotals = intTotals / 1024;
                if (x.cacheModeId == clsCacheModeEN_js_1.enumCacheMode.localStorage_03 || x.cacheModeId == clsCacheModeEN_js_1.enumCacheMode.sessionStorage_04) {
                    const fltPercent = (intTotals * 100) / (1024 * 5);
                    x.memo = (0, clsString_js_1.Format)("{0}KB, 占 {1} %", intTotals.toFixed(2), fltPercent.toFixed(2));
                }
                else {
                    x.memo = (0, clsString_js_1.Format)("{0}KB", intTotals.toFixed(2));
                }
            }
            if (intTotals > 0) {
                let txtClientCache;
                let txtlocalStorage;
                let txtsessionStorage;
                switch (x.cacheModeId) {
                    case clsCacheModeEN_js_1.enumCacheMode.ClientCache_02:
                        console.error("ClientCache_02:", x.memo);
                        txtClientCache = document.getElementById('txtClientCache');
                        if (txtClientCache != null) {
                            txtClientCache.value = x.memo;
                        }
                        break;
                    case clsCacheModeEN_js_1.enumCacheMode.localStorage_03:
                        console.error("localStorage_03:", x.memo);
                        txtlocalStorage = document.getElementById('txtlocalStorage');
                        if (txtlocalStorage != null) {
                            txtlocalStorage.value = x.memo;
                        }
                        break;
                    case clsCacheModeEN_js_1.enumCacheMode.sessionStorage_04:
                        console.error("sessionStorage_04:", x.memo);
                        txtsessionStorage = document.getElementById('txtsessionStorage');
                        if (txtsessionStorage != null) {
                            txtsessionStorage.value = x.memo;
                        }
                        break;
                }
            }
        });
    }
    exports.CacheUseStateEx_Subtotals = CacheUseStateEx_Subtotals;
    function CacheUseStateEx_ClearLocalStorage() {
        const arrCacheKeyLst = new Array();
        for (let i = 0; i < localStorage.length; i++) {
            const strKey = localStorage.key(i);
            if (strKey != null) {
                arrCacheKeyLst.push(strKey);
            }
            //拿到所有含u-的key
        }
        //        alert(strCacheKeyLst);
        arrCacheKeyLst.forEach(x => localStorage.removeItem(x));
    }
    exports.CacheUseStateEx_ClearLocalStorage = CacheUseStateEx_ClearLocalStorage;
    function CacheUseStateEx_ClearSessionStorage() {
        const arrCacheKeyLst = new Array();
        for (let i = 0; i < sessionStorage.length; i++) {
            const strKey = sessionStorage.key(i);
            if (strKey != null) {
                arrCacheKeyLst.push(strKey);
            }
            //拿到所有含u-的key
        }
        //        alert(strCacheKeyLst);
        arrCacheKeyLst.forEach(x => sessionStorage.removeItem(x));
    }
    exports.CacheUseStateEx_ClearSessionStorage = CacheUseStateEx_ClearSessionStorage;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function CacheUseStateEx_GetObjExLstByPager_Cache(objPagerPara, strUserId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrCacheUseStateObjLst = await (0, clsCacheUseStateWApi_js_1.CacheUseState_GetObjLst_Cache)(strUserId);
        const arrCacheUseStateExObjLst = arrCacheUseStateObjLst.map(CacheUseStateEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrCacheUseStateExObjLst) {
                const conFuncMap = await CacheUseStateEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrCacheUseStateExObjLst.length == 0)
            return arrCacheUseStateExObjLst;
        let arrCacheUseState_Sel = arrCacheUseStateExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objCacheUseState_Cond = new clsCacheUseStateENEx_js_1.clsCacheUseStateENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objCacheUseState_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsCacheUseStateWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCacheUseState_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrCacheUseState_Sel.length == 0)
                return arrCacheUseState_Sel;
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
                arrCacheUseState_Sel = arrCacheUseState_Sel.sort(CacheUseStateEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrCacheUseState_Sel = arrCacheUseState_Sel.sort(objPagerPara.sortFun);
            }
            arrCacheUseState_Sel = arrCacheUseState_Sel.slice(intStart, intEnd);
            return arrCacheUseState_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.cacheUseStateEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CacheUseStateEx_GetObjExLstByPager_Cache = CacheUseStateEx_GetObjExLstByPager_Cache;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:潘以锋
     * 日期:00-00-00
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function CacheUseStateEx_FuncMapByFldName(strFldName, objCacheUseStateEx) {
        const strThisFuncName = CacheUseStateEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsCacheUseStateEN_js_1.clsCacheUseStateEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            case clsCacheUseStateENEx_js_1.clsCacheUseStateENEx.con_CacheModeName:
                return CacheUseStateEx_FuncMap_CacheModeName(objCacheUseStateEx);
            case clsCacheUseStateENEx_js_1.clsCacheUseStateENEx.con_CacheModeENName:
                return CacheUseStateEx_FuncMap_CacheModeENName(objCacheUseStateEx);
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.CacheUseStateEx_FuncMapByFldName = CacheUseStateEx_FuncMapByFldName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objCacheUseStateS:源对象
    **/
    async function CacheUseStateEx_FuncMap_CacheModeName(objCacheUseState) {
        const strThisFuncName = CacheUseStateEx_FuncMap_CacheModeName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objCacheUseState.cacheModeName) == true) {
                const CacheMode_CacheModeId = objCacheUseState.cacheModeId;
                const CacheMode_CacheModeName = await (0, clsCacheModeWApi_js_1.CacheMode_func)(clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeId, clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeName, CacheMode_CacheModeId);
                objCacheUseState.cacheModeName = CacheMode_CacheModeName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000160)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cacheUseStateEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.CacheUseStateEx_FuncMap_CacheModeName = CacheUseStateEx_FuncMap_CacheModeName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objCacheUseStateS:源对象
    **/
    async function CacheUseStateEx_FuncMap_CacheModeENName(objCacheUseState) {
        const strThisFuncName = CacheUseStateEx_FuncMap_CacheModeENName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objCacheUseState.cacheModeENName) == true) {
                const CacheMode_CacheModeId = objCacheUseState.cacheModeId;
                const CacheMode_CacheModeENName = await (0, clsCacheModeWApi_js_1.CacheMode_func)(clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeId, clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeENName, CacheMode_CacheModeId);
                objCacheUseState.cacheModeENName = CacheMode_CacheModeENName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000161)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cacheUseStateEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.CacheUseStateEx_FuncMap_CacheModeENName = CacheUseStateEx_FuncMap_CacheModeENName;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:潘以锋
     * 日期:00-00-00
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CacheUseStateEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsCacheUseStateENEx_js_1.clsCacheUseStateENEx.con_CacheModeName:
                    return (a, b) => {
                        return a.cacheModeName.localeCompare(b.cacheModeName);
                    };
                case clsCacheUseStateENEx_js_1.clsCacheUseStateENEx.con_CacheModeENName:
                    return (a, b) => {
                        return a.cacheModeENName.localeCompare(b.cacheModeENName);
                    };
                default:
                    return (0, clsCacheUseStateWApi_js_1.CacheUseState_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                case clsCacheUseStateENEx_js_1.clsCacheUseStateENEx.con_CacheModeName:
                    return (a, b) => {
                        return b.cacheModeName.localeCompare(a.cacheModeName);
                    };
                case clsCacheUseStateENEx_js_1.clsCacheUseStateENEx.con_CacheModeENName:
                    return (a, b) => {
                        return b.cacheModeENName.localeCompare(a.cacheModeENName);
                    };
                default:
                    return (0, clsCacheUseStateWApi_js_1.CacheUseState_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.CacheUseStateEx_SortFunByKey = CacheUseStateEx_SortFunByKey;
});
