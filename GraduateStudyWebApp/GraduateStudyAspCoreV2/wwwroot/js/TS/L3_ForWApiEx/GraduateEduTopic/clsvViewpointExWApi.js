var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduTopic/clsvViewpointEN.js", "axios", "../../L0_Entity/GraduateEduTopic/clsvViewpointENEx.js", "../../L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vViewpointEx_GetAllVNumObjLstAsync = exports.vViewpointEx_FilterFunByKey = exports.vViewpointEx_FuncMapByFldName = exports.vViewpointEx_SortFunByKey = exports.vViewpointEx_GetObjExLstByPagerAsync = exports.vViewpointEx_GetObjExLstByPager_Cache = exports.vViewpointEx_CopyToEx = exports.vViewpointEx_GetWebApiUrl = exports.vViewpointEx_ConstructorName = exports.vViewpointEx_Controller = void 0;
    const clsvViewpointEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvViewpointEN.js");
    var ResponseData;
    const axios_1 = __importDefault(require("axios"));
    const clsvViewpointENEx_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvViewpointENEx.js");
    const clsvViewpointWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    exports.vViewpointEx_Controller = "vViewpointExApi";
    exports.vViewpointEx_ConstructorName = "vViewpointEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vViewpointEx_GetWebApiUrl(strController, strAction) {
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
    exports.vViewpointEx_GetWebApiUrl = vViewpointEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvViewpointENS:源对象
    * @returns 目标对象=>clsvViewpointEN:objvViewpointENT
    **/
    function vViewpointEx_CopyToEx(objvViewpointENS) {
        const strThisFuncName = vViewpointEx_CopyToEx.name;
        const objvViewpointENT = new clsvViewpointENEx_js_1.clsvViewpointENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvViewpointENT, objvViewpointENS);
            return objvViewpointENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vViewpointEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvViewpointENT;
        }
    }
    exports.vViewpointEx_CopyToEx = vViewpointEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vViewpointEx_GetObjExLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvViewpointObjLst = await (0, clsvViewpointWApi_js_1.vViewpoint_GetObjLst_Cache)(strid_CurrEduCls);
        const arrvViewpointExObjLst = arrvViewpointObjLst.map(vViewpointEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvViewpointExObjLst) {
                const conFuncMap = await vViewpointEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvViewpointExObjLst.length == 0)
            return arrvViewpointExObjLst;
        let arrvViewpoint_Sel = arrvViewpointExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvViewpoint_Cond = new clsvViewpointENEx_js_1.clsvViewpointENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvViewpoint_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvViewpointWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvViewpoint_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvViewpoint_Sel.length == 0)
                return arrvViewpoint_Sel;
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
                arrvViewpoint_Sel = arrvViewpoint_Sel.sort(vViewpointEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvViewpoint_Sel = arrvViewpoint_Sel.sort(objPagerPara.sortFun);
            }
            arrvViewpoint_Sel = arrvViewpoint_Sel.slice(intStart, intEnd);
            return arrvViewpoint_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vViewpointEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vViewpointEx_GetObjExLstByPager_Cache = vViewpointEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vViewpointEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvViewpointExObjLst = await (0, clsvViewpointWApi_js_1.vViewpoint_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvViewpointExObjLst) {
                const conFuncMap = await vViewpointEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvViewpointExObjLst.length == 0)
            return arrvViewpointExObjLst;
        let arrvViewpoint_Sel = arrvViewpointExObjLst;
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
                arrvViewpoint_Sel = arrvViewpoint_Sel.sort(vViewpointEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvViewpoint_Sel = arrvViewpoint_Sel.sort(objPagerPara.sortFun);
            }
            arrvViewpoint_Sel = arrvViewpoint_Sel.slice(intStart, intEnd);
            return arrvViewpoint_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vViewpointEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vViewpointEx_GetObjExLstByPagerAsync = vViewpointEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vViewpointEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsvViewpointWApi_js_1.vViewpoint_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsvViewpointWApi_js_1.vViewpoint_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vViewpointEx_SortFunByKey = vViewpointEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vViewpointEx_FuncMapByFldName(strFldName, objvViewpointEx) {
        const strThisFuncName = vViewpointEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvViewpointEN_js_1.clsvViewpointEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vViewpointEx_FuncMapByFldName = vViewpointEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vViewpointEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsvViewpointWApi_js_1.vViewpoint_FilterFunByKey)(strKey, value);
        }
    }
    exports.vViewpointEx_FilterFunByKey = vViewpointEx_FilterFunByKey;
    async function vViewpointEx_GetAllVNumObjLstAsync(strPaperId) {
        const strThisFuncName = "GetAllVNumObjLstAsync";
        var strAction = "GetAllVNumObjLst";
        let strUrl = vViewpointEx_GetWebApiUrl(exports.vViewpointEx_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strPaperId": strPaperId }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointEx_Controller, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = (0, clsvViewpointWApi_js_1.vViewpoint_GetObjLstByJSONObjLst)(returnObjLst);
                return (arrObjLst);
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointEx_GetAllVNumObjLstAsync = vViewpointEx_GetAllVNumObjLstAsync;
});
