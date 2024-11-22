var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js", "../../PubFun/tzDictionary.js", "../../L0_Entity/GraduateEduPaper/clsPaperSubViewpointENEx.js", "../../L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js", "axios"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperSubViewpointEx_DelRecordAsyncEx = exports.PaperSubViewpointEx_UpdateRecordAsyncEx = exports.PaperSubViewpointEx_AddNewRecordWithReturnKeyAsyncEx = exports.PaperSubViewpointEx_AddNewRecordAsyncEx = exports.PaperSubViewpointEx_FilterFunByKey = exports.PaperSubViewpointEx_FuncMapByFldName = exports.PaperSubViewpointEx_SortFunByKey = exports.PaperSubViewpointEx_GetObjExLstByPagerAsync = exports.PaperSubViewpointEx_GetObjExLstByPager_Cache = exports.PaperSubViewpointEx_CopyToEx = exports.PaperSubViewpointEx_GetWebApiUrl = exports.paperSubViewpointEx_ConstructorName = exports.paperSubViewpointEx_Controller = void 0;
    /// <summary>
    /// 子观点表(PaperSubViewpoint)
    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by  on 2020年01月15日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as QQ from "q";
    const clsPaperSubViewpointEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsPaperSubViewpointENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperSubViewpointENEx.js");
    const clsPaperSubViewpointWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const axios_1 = __importDefault(require("axios"));
    exports.paperSubViewpointEx_Controller = "PaperSubViewpointExApi";
    exports.paperSubViewpointEx_ConstructorName = "paperSubViewpointEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function PaperSubViewpointEx_GetWebApiUrl(strController, strAction) {
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
    exports.PaperSubViewpointEx_GetWebApiUrl = PaperSubViewpointEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objPaperSubViewpointENS:源对象
    * @returns 目标对象=>clsPaperSubViewpointEN:objPaperSubViewpointENT
    **/
    function PaperSubViewpointEx_CopyToEx(objPaperSubViewpointENS) {
        const strThisFuncName = PaperSubViewpointEx_CopyToEx.name;
        const objPaperSubViewpointENT = new clsPaperSubViewpointENEx_js_1.clsPaperSubViewpointENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperSubViewpointENT, objPaperSubViewpointENS);
            return objPaperSubViewpointENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.paperSubViewpointEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objPaperSubViewpointENT;
        }
    }
    exports.PaperSubViewpointEx_CopyToEx = PaperSubViewpointEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function PaperSubViewpointEx_GetObjExLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrPaperSubViewpointObjLst = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_GetObjLst_Cache)(strid_CurrEduCls);
        const arrPaperSubViewpointExObjLst = arrPaperSubViewpointObjLst.map(PaperSubViewpointEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrPaperSubViewpointExObjLst) {
                const conFuncMap = await PaperSubViewpointEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrPaperSubViewpointExObjLst.length == 0)
            return arrPaperSubViewpointExObjLst;
        let arrPaperSubViewpoint_Sel = arrPaperSubViewpointExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objPaperSubViewpoint_Cond = new clsPaperSubViewpointENEx_js_1.clsPaperSubViewpointENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperSubViewpoint_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsPaperSubViewpointWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperSubViewpoint_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPaperSubViewpoint_Sel.length == 0)
                return arrPaperSubViewpoint_Sel;
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
                arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.sort(PaperSubViewpointEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.sort(objPagerPara.sortFun);
            }
            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.slice(intStart, intEnd);
            return arrPaperSubViewpoint_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.paperSubViewpointEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperSubViewpointEx_GetObjExLstByPager_Cache = PaperSubViewpointEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function PaperSubViewpointEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrPaperSubViewpointExObjLst = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrPaperSubViewpointExObjLst) {
                const conFuncMap = await PaperSubViewpointEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrPaperSubViewpointExObjLst.length == 0)
            return arrPaperSubViewpointExObjLst;
        let arrPaperSubViewpoint_Sel = arrPaperSubViewpointExObjLst;
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
                arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.sort(PaperSubViewpointEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.sort(objPagerPara.sortFun);
            }
            arrPaperSubViewpoint_Sel = arrPaperSubViewpoint_Sel.slice(intStart, intEnd);
            return arrPaperSubViewpoint_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.paperSubViewpointEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperSubViewpointEx_GetObjExLstByPagerAsync = PaperSubViewpointEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperSubViewpointEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.PaperSubViewpointEx_SortFunByKey = PaperSubViewpointEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function PaperSubViewpointEx_FuncMapByFldName(strFldName, objPaperSubViewpointEx) {
        const strThisFuncName = PaperSubViewpointEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.PaperSubViewpointEx_FuncMapByFldName = PaperSubViewpointEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function PaperSubViewpointEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_FilterFunByKey)(strKey, value);
        }
    }
    exports.PaperSubViewpointEx_FilterFunByKey = PaperSubViewpointEx_FilterFunByKey;
    /// <summary>
    /// 调用WebApi来添加记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    /// </summary>
    /// <param name = "objPaperSubViewpointEN">需要添加的对象</param>
    /// <returns>获取相应的记录的对象</returns>
    async function PaperSubViewpointEx_AddNewRecordAsyncEx(objPaperSubViewpointEN) {
        const strThisFuncName = "";
        var strMsg = "";
        var strAction = "AddNewRecordEx";
        console.error("AddNewRecordAsyncEx");
        //var strJSON = JSON.stringify(objPaperSubViewpointEN_Sim);
        let strUrl = PaperSubViewpointEx_GetWebApiUrl(exports.paperSubViewpointEx_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperSubViewpointEN);
            const data = response.data;
            if (data.errorId == 0) {
                return (data.returnBool);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointEx_AddNewRecordAsyncEx = PaperSubViewpointEx_AddNewRecordAsyncEx;
    /// <summary>
    /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    /// </summary>
    /// <param name = "objPaperSubViewpointEN">需要添加的表对象</param>
    /// <returns>返回新添加记录的关键字</returns>
    async function PaperSubViewpointEx_AddNewRecordWithReturnKeyAsyncEx(objPaperSubViewpointEN) {
        const strThisFuncName = "";
        var strAction = "AddNewRecordWithReturnKeyEx";
        console.error("AddNewRecordWithReturnKeyAsyncEx");
        //if (objPaperSubViewpointEN.subViewpointId === null || objPaperSubViewpointEN.subViewpointId === 0)
        //{
        //var strMsg = "需要的对象的关键字为空，不能添加!";
        //throw new Error(strMsg);
        //}
        let strUrl = PaperSubViewpointEx_GetWebApiUrl(exports.paperSubViewpointEx_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperSubViewpointEN);
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnStr;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointEx_AddNewRecordWithReturnKeyAsyncEx = PaperSubViewpointEx_AddNewRecordWithReturnKeyAsyncEx;
    /// <summary>
    /// 调用WebApi来修改记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    /// </summary>
    /// <param name = "objPaperSubViewpointEN">需要添加的对象</param>
    /// <returns>获取修改是否成功？</returns>
    async function PaperSubViewpointEx_UpdateRecordAsyncEx(objPaperSubViewpointEN) {
        const strThisFuncName = "";
        var strMsg = "";
        var strAction = "UpdateRecordEx";
        if (objPaperSubViewpointEN.sf_UpdFldSetStr === null || objPaperSubViewpointEN.sf_UpdFldSetStr === "") {
            strMsg = `对象(关键字: ${objPaperSubViewpointEN.subViewpointId})的【修改字段集】为空，不能修改!`;
            throw strMsg;
        }
        let strUrl = PaperSubViewpointEx_GetWebApiUrl(exports.paperSubViewpointEx_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperSubViewpointEN);
            const data = response.data;
            if (data.errorId == 0) {
                return (data.returnBool);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointEx_UpdateRecordAsyncEx = PaperSubViewpointEx_UpdateRecordAsyncEx;
    /// <summary>
    /// 调用WebApi来删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    /// </summary>
    /// <param name = "lngSubViewpointId">关键字</param>
    /// <returns>获取删除的结果</returns>
    async function PaperSubViewpointEx_DelRecordAsyncEx(strSubViewpointId) {
        const strThisFuncName = "";
        var strAction = "DelRecordEx";
        let strUrl = PaperSubViewpointEx_GetWebApiUrl(exports.paperSubViewpointEx_Controller, strAction);
        strUrl = `${strUrl}/${strSubViewpointId}`;
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strSubViewpointId", strSubViewpointId);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strSubViewpointId);
        try {
            const response = await axios_1.default.delete(strUrl);
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnInt;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperSubViewpointEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperSubViewpointEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperSubViewpointEx_DelRecordAsyncEx = PaperSubViewpointEx_DelRecordAsyncEx;
});
