var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js", "../../L0_Entity/DailyRunning_Share/clsCurrEduClsTeacherEN.js", "../../L0_Entity/DailyRunning_Share/clsCurrEduClsTeacherENEx.js", "../../L3_ForWApi/DailyRunning_Share/clsCurrEduClsTeacherWApi.js", "../../L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "axios", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CurrEduClsTeacherEx_GetObjListByTeacherId = exports.CurrEduClsTeacherEx_BindDdl_id_CurrEduClsByTeacherIdInDiv_Cache = exports.CurrEduClsTeacherEx_GetTeacherIdLstById_CurrEduCls = exports.CurrEduClsTeacherEx_SetCurrEduClsOrderNum4TeacherId = exports.CurrEduClsTeacherEx_Getid_CurrEduClsListByTeacherId = exports.CurrEduClsTeacherEx_FilterFunByKey = exports.CurrEduClsTeacherEx_FuncMapByFldName = exports.CurrEduClsTeacherEx_SortFunByKey = exports.CurrEduClsTeacherEx_GetObjExLstByPagerAsync = exports.CurrEduClsTeacherEx_GetObjExLstByPager_Cache = exports.CurrEduClsTeacherEx_CopyToEx = exports.CurrEduClsTeacherEx_GetWebApiUrl = exports.currEduClsTeacherEx_ConstructorName = exports.currEduClsTeacherEx_Controller = void 0;
    /// <summary>
    /// 当前教学班教师(CurrEduClsTeacher)
    /// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by pyf on 2021年06月11日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    const clsCurrEduClsEN_js_1 = require("../../L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js");
    //import * as QQ from "q";
    const clsCurrEduClsTeacherEN_js_1 = require("../../L0_Entity/DailyRunning_Share/clsCurrEduClsTeacherEN.js");
    const clsCurrEduClsTeacherENEx_js_1 = require("../../L0_Entity/DailyRunning_Share/clsCurrEduClsTeacherENEx.js");
    const clsCurrEduClsTeacherWApi_js_1 = require("../../L3_ForWApi/DailyRunning_Share/clsCurrEduClsTeacherWApi.js");
    const clsCurrEduClsWApi_js_1 = require("../../L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    var ResponseData;
    const axios_1 = __importDefault(require("axios"));
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsPublocalStorage_js_1 = require("../../PubFun/clsPublocalStorage.js");
    exports.currEduClsTeacherEx_Controller = "CurrEduClsTeacherExApi";
    exports.currEduClsTeacherEx_ConstructorName = "currEduClsTeacherEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function CurrEduClsTeacherEx_GetWebApiUrl(strController, strAction) {
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
    exports.CurrEduClsTeacherEx_GetWebApiUrl = CurrEduClsTeacherEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objCurrEduClsTeacherENS:源对象
    * @returns 目标对象=>clsCurrEduClsTeacherEN:objCurrEduClsTeacherENT
    **/
    function CurrEduClsTeacherEx_CopyToEx(objCurrEduClsTeacherENS) {
        const strThisFuncName = CurrEduClsTeacherEx_CopyToEx.name;
        const objCurrEduClsTeacherENT = new clsCurrEduClsTeacherENEx_js_1.clsCurrEduClsTeacherENEx();
        try {
            (0, clsCommFunc4Web_js_2.ObjectAssign)(objCurrEduClsTeacherENT, objCurrEduClsTeacherENS);
            return objCurrEduClsTeacherENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.currEduClsTeacherEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objCurrEduClsTeacherENT;
        }
    }
    exports.CurrEduClsTeacherEx_CopyToEx = CurrEduClsTeacherEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function CurrEduClsTeacherEx_GetObjExLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrCurrEduClsTeacherObjLst = await (0, clsCurrEduClsTeacherWApi_js_1.CurrEduClsTeacher_GetObjLst_Cache)(strid_CurrEduCls);
        const arrCurrEduClsTeacherExObjLst = arrCurrEduClsTeacherObjLst.map(CurrEduClsTeacherEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrCurrEduClsTeacherExObjLst) {
                const conFuncMap = await CurrEduClsTeacherEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrCurrEduClsTeacherExObjLst.length == 0)
            return arrCurrEduClsTeacherExObjLst;
        let arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacherExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objCurrEduClsTeacher_Cond = new clsCurrEduClsTeacherENEx_js_1.clsCurrEduClsTeacherENEx();
        (0, clsCommFunc4Web_js_2.ObjectAssign)(objCurrEduClsTeacher_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsCurrEduClsTeacherWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_2.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCurrEduClsTeacher_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrCurrEduClsTeacher_Sel.length == 0)
                return arrCurrEduClsTeacher_Sel;
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
                arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.sort(CurrEduClsTeacherEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.sort(objPagerPara.sortFun);
            }
            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.slice(intStart, intEnd);
            return arrCurrEduClsTeacher_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.currEduClsTeacherEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CurrEduClsTeacherEx_GetObjExLstByPager_Cache = CurrEduClsTeacherEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function CurrEduClsTeacherEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrCurrEduClsTeacherObjLst = await (0, clsCurrEduClsTeacherWApi_js_1.CurrEduClsTeacher_GetObjLstAsync)(objPagerPara.whereCond);
        const arrCurrEduClsTeacherExObjLst = arrCurrEduClsTeacherObjLst.map(CurrEduClsTeacherEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrCurrEduClsTeacherExObjLst) {
                const conFuncMap = await CurrEduClsTeacherEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrCurrEduClsTeacherExObjLst.length == 0)
            return arrCurrEduClsTeacherExObjLst;
        let arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacherExObjLst;
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
                arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.sort(CurrEduClsTeacherEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.sort(objPagerPara.sortFun);
            }
            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.slice(intStart, intEnd);
            return arrCurrEduClsTeacher_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.currEduClsTeacherEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CurrEduClsTeacherEx_GetObjExLstByPagerAsync = CurrEduClsTeacherEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CurrEduClsTeacherEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsCurrEduClsTeacherWApi_js_1.CurrEduClsTeacher_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsCurrEduClsTeacherWApi_js_1.CurrEduClsTeacher_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.CurrEduClsTeacherEx_SortFunByKey = CurrEduClsTeacherEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function CurrEduClsTeacherEx_FuncMapByFldName(strFldName, objCurrEduClsTeacherEx) {
        const strThisFuncName = CurrEduClsTeacherEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsCurrEduClsTeacherEN_js_1.clsCurrEduClsTeacherEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.CurrEduClsTeacherEx_FuncMapByFldName = CurrEduClsTeacherEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function CurrEduClsTeacherEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsCurrEduClsTeacherWApi_js_1.CurrEduClsTeacher_FilterFunByKey)(strKey, value);
        }
    }
    exports.CurrEduClsTeacherEx_FilterFunByKey = CurrEduClsTeacherEx_FilterFunByKey;
    //export class clsCurrEduClsTeacherExWApi {
    //    public static mstrController: string = "CurrEduClsTeacherExApi";
    //    public objCurrEduClsTeacherEN: clsCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
    /// <summary>
    /// 构造函数
    /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
    /// </summary>
    //constructor() {
    //};
    /// <summary>
    /// 获取WebApi的地址
    /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    /// </summary>
    /// <returns>返回当前文件中Web服务的地址</returns>
    /**
    * 根据教师Id获取教学班流水号列表
    * (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
    * @param strTeacherId: 工号
    * @returns 获取的相应对象列表
    */
    async function CurrEduClsTeacherEx_Getid_CurrEduClsListByTeacherId(strTeacherId) {
        const strThisFuncName = "Getid_CurrEduClsListByTeacherId";
        var strAction = "Getid_CurrEduClsListByTeacherId";
        let strUrl = CurrEduClsTeacherEx_GetWebApiUrl(exports.currEduClsTeacherEx_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strTeacherId": strTeacherId }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduClsTeacherEx_Controller, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = returnObjLst;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacherEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacherEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacherEx_Getid_CurrEduClsListByTeacherId = CurrEduClsTeacherEx_Getid_CurrEduClsListByTeacherId;
    /**
    * 根据教师Id获取教学班流水号列表
    * (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
    * @param strTeacherId: 工号
    * @returns 获取的相应对象列表
    */
    async function CurrEduClsTeacherEx_SetCurrEduClsOrderNum4TeacherId(arrCurrEduClsObjLst, strTeacherId) {
        const arrCurrEduClsTeacher = await CurrEduClsTeacherEx_GetObjListByTeacherId(strTeacherId);
        for (let objCurrEduCls of arrCurrEduClsObjLst) {
            const objCurrEduClsTeacher = arrCurrEduClsTeacher.find(x => x.id_CurrEduCls == objCurrEduCls.id_CurrEduCls);
            if (objCurrEduClsTeacher == null)
                continue;
            objCurrEduCls.intTag = objCurrEduClsTeacher.orderNum;
        }
    }
    exports.CurrEduClsTeacherEx_SetCurrEduClsOrderNum4TeacherId = CurrEduClsTeacherEx_SetCurrEduClsOrderNum4TeacherId;
    ;
    /**
    * 根据教学班流水号获取教师Id列表
    * (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
    * @param strId_CurrEduCls: 教学班流水号
    * @returns 获取的相应对象列表
    */
    async function CurrEduClsTeacherEx_GetTeacherIdLstById_CurrEduCls(strId_CurrEduCls) {
        const strThisFuncName = "GetTeacherIdLstById_CurrEduCls";
        var strAction = "GetTeacherIdLstById_CurrEduCls";
        let strUrl = CurrEduClsTeacherEx_GetWebApiUrl(exports.currEduClsTeacherEx_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strId_CurrEduCls": strId_CurrEduCls }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduClsTeacherEx_Controller, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = returnObjLst;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacherEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacherEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacherEx_GetTeacherIdLstById_CurrEduCls = CurrEduClsTeacherEx_GetTeacherIdLstById_CurrEduCls;
    /**
    * 绑定基于Web的下拉框
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
    * @param objDDL:需要绑定当前表的下拉框
    */
    async function CurrEduClsTeacherEx_BindDdl_id_CurrEduClsByTeacherIdInDiv_Cache(strDivName, strDdlName, strTeacherId) {
        const strCourseId = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_id_CurrEduClsInDiv_Cache)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_id_CurrEduClsInDiv_Cache");
        const arrObjLst_Sel = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetObjLst_Cache)(strCourseId);
        const arrId_CurrEduClsLst = await CurrEduClsTeacherEx_Getid_CurrEduClsListByTeacherId(strTeacherId);
        const arrObjLst_Sel2 = arrObjLst_Sel.filter(x => arrId_CurrEduClsLst.indexOf(x.id_CurrEduCls) > -1);
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel2, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CurrEduCls, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsName, "教学班");
    }
    exports.CurrEduClsTeacherEx_BindDdl_id_CurrEduClsByTeacherIdInDiv_Cache = CurrEduClsTeacherEx_BindDdl_id_CurrEduClsByTeacherIdInDiv_Cache;
    /**
    * 根据工号获取教学班教师对象列表
    * (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
    * @param strTeacherId: 工号
    * @returns 获取的相应对象列表
    */
    async function CurrEduClsTeacherEx_GetObjListByTeacherId(strTeacherId) {
        const strThisFuncName = "GetObjListByTeacherId";
        var strAction = "GetObjListByTeacherId";
        let strUrl = CurrEduClsTeacherEx_GetWebApiUrl(exports.currEduClsTeacherEx_Controller, strAction);
        //var mapParam: Dictionary = new Dictionary();
        //mapParam.add("strTeacherId", strTeacherId);
        //let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strTeacherId": strTeacherId }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduClsTeacherEx_Controller, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = (0, clsCurrEduClsTeacherWApi_js_1.CurrEduClsTeacher_GetObjLstByJSONObjLst)(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsTeacherEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsTeacherEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsTeacherEx_GetObjListByTeacherId = CurrEduClsTeacherEx_GetObjListByTeacherId;
});
