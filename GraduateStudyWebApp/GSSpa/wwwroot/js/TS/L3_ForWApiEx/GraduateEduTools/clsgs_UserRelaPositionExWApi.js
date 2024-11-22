var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    var desc = Object.getOwnPropertyDescriptor(m, k);
    if (!desc || ("get" in desc ? !m.__esModule : desc.writable || desc.configurable)) {
      desc = { enumerable: true, get: function() { return m[k]; } };
    }
    Object.defineProperty(o, k2, desc);
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "jquery", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/GraduateEduTools/clsgs_UserRelaPositionWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/GraduateEduTools/clsgs_UserRelaPositionEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/GraduateEduTools/clsgs_UserRelaPositionENEx.js", "../../L3_ForWApi/GraduateEduTools/clsgs_UserRelaPositionWApi.js", "../../L3_ForWApi/GraduateEduTools/clsgs_UserRelaPositionWApi.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_UserRelaPositionEx_AddNewRecordAsync = exports.gs_UserRelaPositionEx_FilterFunByKey = exports.gs_UserRelaPositionEx_FuncMapByFldName = exports.gs_UserRelaPositionEx_SortFunByKey = exports.gs_UserRelaPositionEx_GetObjExLstByPagerAsync = exports.gs_UserRelaPositionEx_GetObjExLstByPager_Cache = exports.gs_UserRelaPositionEx_CopyToEx = exports.gs_UserRelaPositionEx_GetWebApiUrl = exports.gs_UserRelaPositionEx_ConstructorName = exports.gs_UserRelaPositionEx_Controller = void 0;
    const $ = __importStar(require("jquery"));
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsgs_UserRelaPositionWApi_js_1 = require("../../L3_ForWApi/GraduateEduTools/clsgs_UserRelaPositionWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsgs_UserRelaPositionEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsgs_UserRelaPositionEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clsgs_UserRelaPositionENEx_js_1 = require("../../L0_Entity/GraduateEduTools/clsgs_UserRelaPositionENEx.js");
    const clsgs_UserRelaPositionWApi_js_2 = require("../../L3_ForWApi/GraduateEduTools/clsgs_UserRelaPositionWApi.js");
    const clsgs_UserRelaPositionWApi_js_3 = require("../../L3_ForWApi/GraduateEduTools/clsgs_UserRelaPositionWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    exports.gs_UserRelaPositionEx_Controller = "gs_UserRelaPositionExApi";
    exports.gs_UserRelaPositionEx_ConstructorName = "gs_UserRelaPositionEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function gs_UserRelaPositionEx_GetWebApiUrl(strController, strAction) {
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
    exports.gs_UserRelaPositionEx_GetWebApiUrl = gs_UserRelaPositionEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objgs_UserRelaPositionENS:源对象
    * @returns 目标对象=>clsgs_UserRelaPositionEN:objgs_UserRelaPositionENT
    **/
    function gs_UserRelaPositionEx_CopyToEx(objgs_UserRelaPositionENS) {
        const strThisFuncName = gs_UserRelaPositionEx_CopyToEx.name;
        const objgs_UserRelaPositionENT = new clsgs_UserRelaPositionENEx_js_1.clsgs_UserRelaPositionENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_UserRelaPositionENT, objgs_UserRelaPositionENS);
            return objgs_UserRelaPositionENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.gs_UserRelaPositionEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objgs_UserRelaPositionENT;
        }
    }
    exports.gs_UserRelaPositionEx_CopyToEx = gs_UserRelaPositionEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_UserRelaPositionEx_GetObjExLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_UserRelaPositionObjLst = await (0, clsgs_UserRelaPositionWApi_js_1.gs_UserRelaPosition_GetObjLst_Cache)(strid_CurrEduCls);
        const arrgs_UserRelaPositionExObjLst = arrgs_UserRelaPositionObjLst.map(gs_UserRelaPositionEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_UserRelaPositionExObjLst) {
                const conFuncMap = await gs_UserRelaPositionEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_UserRelaPositionExObjLst.length == 0)
            return arrgs_UserRelaPositionExObjLst;
        let arrgs_UserRelaPosition_Sel = arrgs_UserRelaPositionExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_UserRelaPosition_Cond = new clsgs_UserRelaPositionENEx_js_1.clsgs_UserRelaPositionENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_UserRelaPosition_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_UserRelaPositionWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_UserRelaPosition_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_UserRelaPosition_Sel.length == 0)
                return arrgs_UserRelaPosition_Sel;
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
                arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.sort(gs_UserRelaPositionEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.slice(intStart, intEnd);
            return arrgs_UserRelaPosition_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_UserRelaPositionEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_UserRelaPositionEx_GetObjExLstByPager_Cache = gs_UserRelaPositionEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_UserRelaPositionEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrgs_UserRelaPositionExObjLst = await (0, clsgs_UserRelaPositionWApi_js_2.gs_UserRelaPosition_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_UserRelaPositionExObjLst) {
                const conFuncMap = await gs_UserRelaPositionEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_UserRelaPositionExObjLst.length == 0)
            return arrgs_UserRelaPositionExObjLst;
        let arrgs_UserRelaPosition_Sel = arrgs_UserRelaPositionExObjLst;
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
                arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.sort(gs_UserRelaPositionEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.slice(intStart, intEnd);
            return arrgs_UserRelaPosition_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_UserRelaPositionEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_UserRelaPositionEx_GetObjExLstByPagerAsync = gs_UserRelaPositionEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_UserRelaPositionEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsgs_UserRelaPositionWApi_js_3.gs_UserRelaPosition_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsgs_UserRelaPositionWApi_js_3.gs_UserRelaPosition_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.gs_UserRelaPositionEx_SortFunByKey = gs_UserRelaPositionEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function gs_UserRelaPositionEx_FuncMapByFldName(strFldName, objgs_UserRelaPositionEx) {
        const strThisFuncName = gs_UserRelaPositionEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsgs_UserRelaPositionEN_js_1.clsgs_UserRelaPositionEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.gs_UserRelaPositionEx_FuncMapByFldName = gs_UserRelaPositionEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_UserRelaPositionEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsgs_UserRelaPositionWApi_js_1.gs_UserRelaPosition_FilterFunByKey)(strKey, value);
        }
    }
    exports.gs_UserRelaPositionEx_FilterFunByKey = gs_UserRelaPositionEx_FilterFunByKey;
    /// <summary>
    /// 调用WebApi来添加记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    /// </summary>
    /// <param name = "objgs_UserRelaEN">需要添加的对象</param>
    /// <returns>获取相应的记录的对象</returns>
    //public static AddNewRecordAsync(arrgs_UserRelaPosition :Array<clsgs_UserRelaPositionEN>): Promise<boolean> {
    async function gs_UserRelaPositionEx_AddNewRecordAsync(strJSON) {
        var strMsg = "";
        var strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(arrgs_UserRelaPosition);
        //var strJson = eval(strJSON);
        //var strJson = JSON.parse(strJSON);
        //var varJSON = JSON.stringify(strJson);
        let strUrl = gs_UserRelaPositionEx_GetWebApiUrl(exports.gs_UserRelaPositionEx_Controller, strAction);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: strJSON,
                success: function (data) {
                    if (data.ErrorId == 0) {
                        resolve(data.ReturnBool);
                    }
                    else {
                        console.log(data.ErrorMsg);
                        reject(data.ErrorMsg);
                    }
                },
                error: function (result) {
                    console.log(result);
                    console.log(JSON.stringify(result));
                    if (result.statusText == "error") {
                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
                        reject(strInfo);
                    }
                    else {
                        reject(result.statusText);
                    }
                }
            });
        });
    }
    exports.gs_UserRelaPositionEx_AddNewRecordAsync = gs_UserRelaPositionEx_AddNewRecordAsync;
    ;
});
