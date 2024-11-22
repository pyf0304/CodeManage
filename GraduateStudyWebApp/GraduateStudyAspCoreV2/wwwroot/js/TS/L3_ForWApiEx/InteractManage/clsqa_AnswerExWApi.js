var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/InteractManage/clsqa_AnswerEN.js", "../../L0_Entity/InteractManage/clsqa_AnswerENEx.js", "../../L3_ForWApi/InteractManage/clsqa_AnswerWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js", "axios"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.qa_AnswerEx_DelRecordAsyncEx = exports.qa_AnswerEx_FilterFunByKey = exports.qa_AnswerEx_FuncMapByFldName = exports.qa_AnswerEx_SortFunByKey = exports.qa_AnswerEx_GetObjExLstByPagerAsync = exports.qa_AnswerEx_GetObjExLstByPager_Cache = exports.qa_AnswerEx_CopyToEx = exports.qa_AnswerEx_GetWebApiUrl = exports.qa_AnswerEx_ConstructorName = exports.qa_AnswerEx_Controller = void 0;
    /// <summary>
    /// 答疑回答(qa_Answer)
    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by yy on 2020年10月27日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as QQ from "q";
    const clsqa_AnswerEN_js_1 = require("../../L0_Entity/InteractManage/clsqa_AnswerEN.js");
    const clsqa_AnswerENEx_js_1 = require("../../L0_Entity/InteractManage/clsqa_AnswerENEx.js");
    const clsqa_AnswerWApi_js_1 = require("../../L3_ForWApi/InteractManage/clsqa_AnswerWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const axios_1 = __importDefault(require("axios"));
    exports.qa_AnswerEx_Controller = "qa_AnswerExApi";
    exports.qa_AnswerEx_ConstructorName = "qa_AnswerEx";
    //public static cacheModeId = "05"; //未知
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function qa_AnswerEx_GetWebApiUrl(strController, strAction) {
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
    exports.qa_AnswerEx_GetWebApiUrl = qa_AnswerEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objqa_AnswerENS:源对象
    * @returns 目标对象=>clsqa_AnswerEN:objqa_AnswerENT
    **/
    function qa_AnswerEx_CopyToEx(objqa_AnswerENS) {
        const strThisFuncName = qa_AnswerEx_CopyToEx.name;
        const objqa_AnswerENT = new clsqa_AnswerENEx_js_1.clsqa_AnswerENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objqa_AnswerENT, objqa_AnswerENS);
            return objqa_AnswerENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.qa_AnswerEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objqa_AnswerENT;
        }
    }
    exports.qa_AnswerEx_CopyToEx = qa_AnswerEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function qa_AnswerEx_GetObjExLstByPager_Cache(objPagerPara, strTopicId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrqa_AnswerObjLst = await (0, clsqa_AnswerWApi_js_1.qa_Answer_GetObjLst_Cache)(strTopicId);
        const arrqa_AnswerExObjLst = arrqa_AnswerObjLst.map(qa_AnswerEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrqa_AnswerExObjLst) {
                const conFuncMap = await qa_AnswerEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrqa_AnswerExObjLst.length == 0)
            return arrqa_AnswerExObjLst;
        let arrqa_Answer_Sel = arrqa_AnswerExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objqa_Answer_Cond = new clsqa_AnswerENEx_js_1.clsqa_AnswerENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objqa_Answer_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsqa_AnswerWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objqa_Answer_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrqa_Answer_Sel.length == 0)
                return arrqa_Answer_Sel;
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
                arrqa_Answer_Sel = arrqa_Answer_Sel.sort(qa_AnswerEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrqa_Answer_Sel = arrqa_Answer_Sel.sort(objPagerPara.sortFun);
            }
            arrqa_Answer_Sel = arrqa_Answer_Sel.slice(intStart, intEnd);
            return arrqa_Answer_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.qa_AnswerEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.qa_AnswerEx_GetObjExLstByPager_Cache = qa_AnswerEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function qa_AnswerEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrqa_AnswerExObjLst = await (0, clsqa_AnswerWApi_js_1.qa_Answer_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrqa_AnswerExObjLst) {
                const conFuncMap = await qa_AnswerEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrqa_AnswerExObjLst.length == 0)
            return arrqa_AnswerExObjLst;
        let arrqa_Answer_Sel = arrqa_AnswerExObjLst;
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
                arrqa_Answer_Sel = arrqa_Answer_Sel.sort(qa_AnswerEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrqa_Answer_Sel = arrqa_Answer_Sel.sort(objPagerPara.sortFun);
            }
            arrqa_Answer_Sel = arrqa_Answer_Sel.slice(intStart, intEnd);
            return arrqa_Answer_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.qa_AnswerEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.qa_AnswerEx_GetObjExLstByPagerAsync = qa_AnswerEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function qa_AnswerEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsqa_AnswerWApi_js_1.qa_Answer_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsqa_AnswerWApi_js_1.qa_Answer_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.qa_AnswerEx_SortFunByKey = qa_AnswerEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function qa_AnswerEx_FuncMapByFldName(strFldName, objqa_AnswerEx) {
        const strThisFuncName = qa_AnswerEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsqa_AnswerEN_js_1.clsqa_AnswerEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.qa_AnswerEx_FuncMapByFldName = qa_AnswerEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function qa_AnswerEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsqa_AnswerWApi_js_1.qa_Answer_FilterFunByKey)(strKey, value);
        }
    }
    exports.qa_AnswerEx_FilterFunByKey = qa_AnswerEx_FilterFunByKey;
    /// <summary>
    /// 调用WebApi来删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    /// </summary>
    /// <param name = "strTopicId">关键字</param>
    /// <returns>获取删除的结果</returns>
    async function qa_AnswerEx_DelRecordAsyncEx(strAnswerId) {
        const strThisFuncName = "";
        var strAction = "DelRecordEx";
        let strUrl = qa_AnswerEx_GetWebApiUrl(exports.qa_AnswerEx_Controller, strAction);
        strUrl = `${strUrl}/${strAnswerId}`;
        //var mapParam: Dictionary = new Dictionary();
        //mapParam.add("strAnswerId", strAnswerId);
        //let strData = mapParam.getParamText();// "例如: strIdentityID =01";
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerEx_DelRecordAsyncEx = qa_AnswerEx_DelRecordAsyncEx;
});
