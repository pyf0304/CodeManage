/**
* 类名:clsvMessagePushExWApi
* 表名:vMessagePush(01120282)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/05 01:03:08
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:新闻公告(NewsAnnouncement)
* 框架-层名:WA_访问扩展层(TS)(WA_AccessEx)
* 编程语言:TypeScript
* 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
  *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
**/
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/NewsAnnouncement/clsvMessagePushWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/NewsAnnouncement/clsvMessagePushEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/NewsAnnouncement/clsvMessagePushENEx.js", "../../L3_ForWApi/NewsAnnouncement/clsvMessagePushWApi.js", "../../L3_ForWApi/NewsAnnouncement/clsvMessagePushWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/NewsAnnouncement/clsvMessagePushWApi.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vMessagePushEx_FilterFunByKey = exports.vMessagePushEx_FuncMapByFldName = exports.vMessagePushEx_SortFunByKey = exports.vMessagePushEx_GetObjExLstByPagerAsync = exports.vMessagePushEx_GetObjExLstByPager_Cache = exports.vMessagePushEx_CopyToEx = exports.vMessagePushEx_GetWebApiUrl = exports.vMessagePushEx_ConstructorName = exports.vMessagePushEx_Controller = void 0;
    /**
    * 消息推送视图(vMessagePush)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
   * Created by pyf on 2022年11月05日.
   * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsvMessagePushWApi_js_1 = require("../../L3_ForWApi/NewsAnnouncement/clsvMessagePushWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsvMessagePushEN_js_1 = require("../../L0_Entity/NewsAnnouncement/clsvMessagePushEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clsvMessagePushENEx_js_1 = require("../../L0_Entity/NewsAnnouncement/clsvMessagePushENEx.js");
    const clsvMessagePushWApi_js_2 = require("../../L3_ForWApi/NewsAnnouncement/clsvMessagePushWApi.js");
    const clsvMessagePushWApi_js_3 = require("../../L3_ForWApi/NewsAnnouncement/clsvMessagePushWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsvMessagePushWApi_js_4 = require("../../L3_ForWApi/NewsAnnouncement/clsvMessagePushWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    exports.vMessagePushEx_Controller = "vMessagePushExApi";
    exports.vMessagePushEx_ConstructorName = "vMessagePushEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vMessagePushEx_GetWebApiUrl(strController, strAction) {
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
    exports.vMessagePushEx_GetWebApiUrl = vMessagePushEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvMessagePushENS:源对象
    * @returns 目标对象=>clsvMessagePushEN:objvMessagePushENT
    **/
    function vMessagePushEx_CopyToEx(objvMessagePushENS) {
        const strThisFuncName = vMessagePushEx_CopyToEx.name;
        const objvMessagePushENT = new clsvMessagePushENEx_js_1.clsvMessagePushENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvMessagePushENT, objvMessagePushENS);
            return objvMessagePushENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vMessagePushEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvMessagePushENT;
        }
    }
    exports.vMessagePushEx_CopyToEx = vMessagePushEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vMessagePushEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvMessagePushObjLst = await (0, clsvMessagePushWApi_js_1.vMessagePush_GetObjLst_Cache)();
        const arrvMessagePushExObjLst = arrvMessagePushObjLst.map(vMessagePushEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvMessagePushExObjLst) {
                const conFuncMap = await vMessagePushEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvMessagePushExObjLst.length == 0)
            return arrvMessagePushExObjLst;
        let arrvMessagePush_Sel = arrvMessagePushExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvMessagePush_Cond = new clsvMessagePushENEx_js_1.clsvMessagePushENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvMessagePush_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvMessagePushWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvMessagePush_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvMessagePush_Sel = arrvMessagePush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvMessagePush_Sel.length == 0)
                return arrvMessagePush_Sel;
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
                arrvMessagePush_Sel = arrvMessagePush_Sel.sort(vMessagePushEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvMessagePush_Sel = arrvMessagePush_Sel.sort(objPagerPara.sortFun);
            }
            arrvMessagePush_Sel = arrvMessagePush_Sel.slice(intStart, intEnd);
            return arrvMessagePush_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vMessagePushEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vMessagePushEx_GetObjExLstByPager_Cache = vMessagePushEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vMessagePushEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvMessagePushObjLst = await (0, clsvMessagePushWApi_js_2.vMessagePush_GetObjLstAsync)(objPagerPara.whereCond);
        const arrvMessagePushExObjLst = arrvMessagePushObjLst.map(vMessagePushEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvMessagePushExObjLst) {
                const conFuncMap = await vMessagePushEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvMessagePushExObjLst.length == 0)
            return arrvMessagePushExObjLst;
        let arrvMessagePush_Sel = arrvMessagePushExObjLst;
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
                arrvMessagePush_Sel = arrvMessagePush_Sel.sort(vMessagePushEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvMessagePush_Sel = arrvMessagePush_Sel.sort(objPagerPara.sortFun);
            }
            arrvMessagePush_Sel = arrvMessagePush_Sel.slice(intStart, intEnd);
            return arrvMessagePush_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vMessagePushEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vMessagePushEx_GetObjExLstByPagerAsync = vMessagePushEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vMessagePushEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsvMessagePushWApi_js_3.vMessagePush_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsvMessagePushWApi_js_3.vMessagePush_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vMessagePushEx_SortFunByKey = vMessagePushEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vMessagePushEx_FuncMapByFldName(strFldName, objvMessagePushEx) {
        const strThisFuncName = vMessagePushEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvMessagePushEN_js_1.clsvMessagePushEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vMessagePushEx_FuncMapByFldName = vMessagePushEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vMessagePushEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsvMessagePushWApi_js_4.vMessagePush_FilterFunByKey)(strKey, value);
        }
    }
    exports.vMessagePushEx_FilterFunByKey = vMessagePushEx_FilterFunByKey;
});
