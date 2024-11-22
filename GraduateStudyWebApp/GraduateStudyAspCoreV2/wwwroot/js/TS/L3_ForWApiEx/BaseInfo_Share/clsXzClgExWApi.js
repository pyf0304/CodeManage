(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/BaseInfo_Share/clsXzClgEN.js", "../../L0_Entity/BaseInfo_Share/clsXzClgENEx.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/tzDictionary.js", "../../L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js", "../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzClgEx_BindDdl_id_XzCollegeForvUsersSimInDiv_CacheEx = exports.XzClgEx_GetMaxStrIdAsync = exports.XzClgEx_UpdateRecordAsync = exports.XzClgEx_GetMaxStrIdByPrefixAsync = exports.XzClgEx_IsExistRecordAsync = exports.XzClgEx_GetTopObjLstAsync = exports.XzClgEx_GetObjExByid_XzCollegeAsync = exports.XzClgEx_GetObjByid_XzCollegeAsync = exports.XzClgEx_PlusAsync = exports.XzClgEx_GetObjExLstAsync = exports.XzClgEx_FilterFunByKey = exports.XzClgEx_FuncMapByFldName = exports.XzClgEx_SortFunByKey = exports.XzClgEx_GetObjExLstByPagerAsync = exports.XzClgEx_GetObjExLstByPager_Cache = exports.XzClgEx_CopyToEx = exports.XzClgEx_GetWebApiUrl = exports.xzClgEx_ConstructorName = exports.xzClgEx_Controller = void 0;
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsXzClgEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsXzClgEN.js");
    const clsXzClgENEx_js_1 = require("../../L0_Entity/BaseInfo_Share/clsXzClgENEx.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsXzClgWApi_js_1 = require("../../L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js");
    const clsvUsersSimWApi_js_1 = require("../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.xzClgEx_Controller = "XzClgExApi";
    exports.xzClgEx_ConstructorName = "xzClgEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function XzClgEx_GetWebApiUrl(strController, strAction) {
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
    exports.XzClgEx_GetWebApiUrl = XzClgEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objXzClgENS:源对象
    * @returns 目标对象=>clsXzClgEN:objXzClgENT
    **/
    function XzClgEx_CopyToEx(objXzClgENS) {
        const strThisFuncName = XzClgEx_CopyToEx.name;
        const objXzClgENT = new clsXzClgENEx_js_1.clsXzClgENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzClgENT, objXzClgENS);
            return objXzClgENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.xzClgEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objXzClgENT;
        }
    }
    exports.XzClgEx_CopyToEx = XzClgEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function XzClgEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrXzClgObjLst = await (0, clsXzClgWApi_js_1.XzClg_GetObjLst_Cache)();
        const arrXzClgExObjLst = arrXzClgObjLst.map(XzClgEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrXzClgExObjLst) {
                const conFuncMap = await XzClgEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrXzClgExObjLst.length == 0)
            return arrXzClgExObjLst;
        let arrXzClg_Sel = arrXzClgExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objXzClg_Cond = new clsXzClgENEx_js_1.clsXzClgENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzClg_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsXzClgWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzClg_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzClg_Sel = arrXzClg_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzClg_Sel.length == 0)
                return arrXzClg_Sel;
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
                arrXzClg_Sel = arrXzClg_Sel.sort(XzClgEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrXzClg_Sel = arrXzClg_Sel.sort(objPagerPara.sortFun);
            }
            arrXzClg_Sel = arrXzClg_Sel.slice(intStart, intEnd);
            return arrXzClg_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.xzClgEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzClgEx_GetObjExLstByPager_Cache = XzClgEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function XzClgEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrXzClgObjLst = await (0, clsXzClgWApi_js_1.XzClg_GetObjLstAsync)(objPagerPara.whereCond);
        const arrXzClgExObjLst = arrXzClgObjLst.map(XzClgEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrXzClgExObjLst) {
                const conFuncMap = await XzClgEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrXzClgExObjLst.length == 0)
            return arrXzClgExObjLst;
        let arrXzClg_Sel = arrXzClgExObjLst;
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
                arrXzClg_Sel = arrXzClg_Sel.sort(XzClgEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrXzClg_Sel = arrXzClg_Sel.sort(objPagerPara.sortFun);
            }
            arrXzClg_Sel = arrXzClg_Sel.slice(intStart, intEnd);
            return arrXzClg_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.xzClgEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzClgEx_GetObjExLstByPagerAsync = XzClgEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzClgEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsXzClgWApi_js_1.XzClg_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsXzClgWApi_js_1.XzClg_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.XzClgEx_SortFunByKey = XzClgEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function XzClgEx_FuncMapByFldName(strFldName, objXzClgEx) {
        const strThisFuncName = XzClgEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsXzClgEN_js_1.clsXzClgEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.XzClgEx_FuncMapByFldName = XzClgEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function XzClgEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsXzClgWApi_js_1.XzClg_FilterFunByKey)(strKey, value);
        }
    }
    exports.XzClgEx_FilterFunByKey = XzClgEx_FilterFunByKey;
    /// <summary>
    /// 获取扩展对象
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
    /// </summary>
    /// <param name = "strCondition">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function XzClgEx_GetObjExLstAsync(strCondition) {
        var strAction = "GetObjExLst";
        let strUrl = XzClgEx_GetWebApiUrl(exports.xzClgEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strCondition", strCondition);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "Get",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.XzClgEx_GetObjExLstAsync = XzClgEx_GetObjExLstAsync;
    ;
    /// <summary>
    /// 相加
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
    /// </summary>
    /// <param name = "b">b</param>
    /// <param name = "a">a</param>
    /// <returns>获取的相应对象列表</returns>
    async function XzClgEx_PlusAsync(b, a) {
        var strAction = "Plus";
        let strUrl = XzClgEx_GetWebApiUrl(exports.xzClgEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("b", b);
        mapParam.add("a", a);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "Get",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.XzClgEx_PlusAsync = XzClgEx_PlusAsync;
    ;
    /// <summary>
    /// 获取当前关键字的记录对象,用对象的形式表示
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
    /// </summary>
    /// <param name = "strid_XzCollege">strid_XzCollege</param>
    /// <returns>获取的相应对象列表</returns>
    async function XzClgEx_GetObjByid_XzCollegeAsync(strid_XzCollege) {
        var strAction = "GetObjByid_XzCollege";
        let strUrl = XzClgEx_GetWebApiUrl(exports.xzClgEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strid_XzCollege", strid_XzCollege);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "Get",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.XzClgEx_GetObjByid_XzCollegeAsync = XzClgEx_GetObjByid_XzCollegeAsync;
    ;
    /// <summary>
    /// 获取当前关键字的记录对象,用对象的形式表示
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
    /// </summary>
    /// <param name = "strid_XzCollege">strid_XzCollege</param>
    /// <returns>获取的相应对象列表</returns>
    async function XzClgEx_GetObjExByid_XzCollegeAsync(strid_XzCollege) {
        var strAction = "GetObjExByid_XzCollege";
        let strUrl = XzClgEx_GetWebApiUrl(exports.xzClgEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strid_XzCollege", strid_XzCollege);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "Get",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.XzClgEx_GetObjExByid_XzCollegeAsync = XzClgEx_GetObjExByid_XzCollegeAsync;
    ;
    /// <summary>
    /// 获取项部对象列表
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
    /// </summary>
    /// <param name = "objTopPara">顶部对象列表的参数对象</param>
    /// <returns>获取的相应对象列表</returns>
    async function XzClgEx_GetTopObjLstAsync(objTopPara) {
        var strAction = "GetTopObjLst";
        let strUrl = XzClgEx_GetWebApiUrl(exports.xzClgEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("objTopPara", objTopPara);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "Post",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.XzClgEx_GetTopObjLstAsync = XzClgEx_GetTopObjLstAsync;
    ;
    /// <summary>
    /// 根据条件判断是否存在记录
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
    /// </summary>
    /// <param name = "strWhereCond">条件串</param>
    /// <returns>获取的相应对象列表</returns>
    async function XzClgEx_IsExistRecordAsync(strWhereCond) {
        var strAction = "IsExistRecord";
        let strUrl = XzClgEx_GetWebApiUrl(exports.xzClgEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "Get",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.XzClgEx_IsExistRecordAsync = XzClgEx_IsExistRecordAsync;
    ;
    /// <summary>
    /// 根据前缀获取当前表关键字值的最大值,再加1
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
    /// </summary>
    /// <param name = "strPrefix">strPrefix</param>
    /// <returns>获取的相应对象列表</returns>
    async function XzClgEx_GetMaxStrIdByPrefixAsync(strPrefix) {
        var strAction = "GetMaxStrIdByPrefix";
        let strUrl = XzClgEx_GetWebApiUrl(exports.xzClgEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strPrefix", strPrefix);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "Get",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.XzClgEx_GetMaxStrIdByPrefixAsync = XzClgEx_GetMaxStrIdByPrefixAsync;
    ;
    /// <summary>
    /// 修改记录
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
    /// </summary>
    /// <param name = "objXzClgEN">objXzClgEN</param>
    /// <returns>获取的相应对象列表</returns>
    async function XzClgEx_UpdateRecordAsync(objXzClgEN) {
        var strAction = "UpdateRecord";
        let strUrl = XzClgEx_GetWebApiUrl(exports.xzClgEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("objXzClgEN", objXzClgEN);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "Post",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.XzClgEx_UpdateRecordAsync = XzClgEx_UpdateRecordAsync;
    ;
    /// <summary>
    /// 获取当前表关键字值的最大值,再加1
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
    /// </summary>
    /// <returns>获取的相应对象列表</returns>
    async function XzClgEx_GetMaxStrIdAsync() {
        var strAction = "GetMaxStrId";
        let strUrl = XzClgEx_GetWebApiUrl(exports.xzClgEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "Get",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText);
                    reject(e);
                }
            });
        });
    }
    exports.XzClgEx_GetMaxStrIdAsync = XzClgEx_GetMaxStrIdAsync;
    ;
    async function XzClgEx_BindDdl_id_XzCollegeForvUsersSimInDiv_CacheEx(strDivName, strDdlName, strCmPrjId) {
        if ((0, clsString_js_1.IsNullOrEmpty)(strCmPrjId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strstrCmPrjIdPrjId]不能为空！(In BindDdl_id_XzCollege_CacheEx)");
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = `下拉框：${strDdlName} 不存在！(In BindDdl_id_XzCollege_Cache)`;
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrObjLst_Sel = await (0, clsXzClgWApi_js_1.XzClg_GetObjLst_Cache)();
        let arrvUsersSimObjLst = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(strCmPrjId);
        const arrid_XzCollege = arrvUsersSimObjLst.map(x => x.id_XzCollege);
        arrObjLst_Sel = arrObjLst_Sel.filter(x => arrid_XzCollege.indexOf(x.id_XzCollege) > -1);
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsXzClgEN_js_1.clsXzClgEN.con_id_XzCollege, clsXzClgEN_js_1.clsXzClgEN.con_CollegeName, "学院");
    }
    exports.XzClgEx_BindDdl_id_XzCollegeForvUsersSimInDiv_CacheEx = XzClgEx_BindDdl_id_XzCollegeForvUsersSimInDiv_CacheEx;
});
