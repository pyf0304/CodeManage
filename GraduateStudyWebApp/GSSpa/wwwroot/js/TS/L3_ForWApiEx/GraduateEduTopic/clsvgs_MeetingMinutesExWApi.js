/**
* 类名:clsvgs_MeetingMinutesExWApi
* 表名:vgs_MeetingMinutes(01120768)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:47:23
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培主题(GraduateEduTopic)
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/GraduateEduTopic/clsvgs_MeetingMinutesEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/GraduateEduTopic/clsvgs_MeetingMinutesENEx.js", "../../L3_ForWApi/GraduateEduTopic/clsvgs_MeetingMinutesWApi.js", "../../L3_ForWApi/GraduateEduTopic/clsvgs_MeetingMinutesWApi.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_MeetingMinutesEx_FilterFunByKey = exports.vgs_MeetingMinutesEx_FuncMapByFldName = exports.vgs_MeetingMinutesEx_SortFunByKey = exports.vgs_MeetingMinutesEx_GetObjExLstByPagerAsync = exports.vgs_MeetingMinutesEx_GetObjExLstByPager_Cache = exports.vgs_MeetingMinutesEx_CopyToEx = exports.vgs_MeetingMinutesEx_GetWebApiUrl = exports.vgs_MeetingMinutesEx_ConstructorName = exports.vgs_MeetingMinutesEx_Controller = void 0;
    /**
    * 会议纪要视图(vgs_MeetingMinutes)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
   * Created by pyf on 2022年11月02日.
   * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsvgs_MeetingMinutesEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvgs_MeetingMinutesEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clsvgs_MeetingMinutesENEx_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvgs_MeetingMinutesENEx.js");
    const clsvgs_MeetingMinutesWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsvgs_MeetingMinutesWApi.js");
    const clsvgs_MeetingMinutesWApi_js_2 = require("../../L3_ForWApi/GraduateEduTopic/clsvgs_MeetingMinutesWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    exports.vgs_MeetingMinutesEx_Controller = "vgs_MeetingMinutesExApi";
    exports.vgs_MeetingMinutesEx_ConstructorName = "vgs_MeetingMinutesEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vgs_MeetingMinutesEx_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_MeetingMinutesEx_GetWebApiUrl = vgs_MeetingMinutesEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvgs_MeetingMinutesENS:源对象
    * @returns 目标对象=>clsvgs_MeetingMinutesEN:objvgs_MeetingMinutesENT
    **/
    function vgs_MeetingMinutesEx_CopyToEx(objvgs_MeetingMinutesENS) {
        const strThisFuncName = vgs_MeetingMinutesEx_CopyToEx.name;
        const objvgs_MeetingMinutesENT = new clsvgs_MeetingMinutesENEx_js_1.clsvgs_MeetingMinutesENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_MeetingMinutesENT, objvgs_MeetingMinutesENS);
            return objvgs_MeetingMinutesENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vgs_MeetingMinutesEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvgs_MeetingMinutesENT;
        }
    }
    exports.vgs_MeetingMinutesEx_CopyToEx = vgs_MeetingMinutesEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vgs_MeetingMinutesEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvgs_MeetingMinutesObjLst = await (0, clsvgs_MeetingMinutesWApi_js_1.vgs_MeetingMinutes_GetObjLst_Cache)();
        const arrvgs_MeetingMinutesExObjLst = arrvgs_MeetingMinutesObjLst.map(vgs_MeetingMinutesEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvgs_MeetingMinutesExObjLst) {
                const conFuncMap = await vgs_MeetingMinutesEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvgs_MeetingMinutesExObjLst.length == 0)
            return arrvgs_MeetingMinutesExObjLst;
        let arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutesExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvgs_MeetingMinutes_Cond = new clsvgs_MeetingMinutesENEx_js_1.clsvgs_MeetingMinutesENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_MeetingMinutes_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvgs_MeetingMinutesWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_MeetingMinutes_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_MeetingMinutes_Sel.length == 0)
                return arrvgs_MeetingMinutes_Sel;
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
                arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.sort(vgs_MeetingMinutesEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.sort(objPagerPara.sortFun);
            }
            arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.slice(intStart, intEnd);
            return arrvgs_MeetingMinutes_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vgs_MeetingMinutesEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_MeetingMinutesEx_GetObjExLstByPager_Cache = vgs_MeetingMinutesEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vgs_MeetingMinutesEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvgs_MeetingMinutesExObjLst = await (0, clsvgs_MeetingMinutesWApi_js_1.vgs_MeetingMinutes_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvgs_MeetingMinutesExObjLst) {
                const conFuncMap = await vgs_MeetingMinutesEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvgs_MeetingMinutesExObjLst.length == 0)
            return arrvgs_MeetingMinutesExObjLst;
        let arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutesExObjLst;
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
                arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.sort(vgs_MeetingMinutesEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.sort(objPagerPara.sortFun);
            }
            arrvgs_MeetingMinutes_Sel = arrvgs_MeetingMinutes_Sel.slice(intStart, intEnd);
            return arrvgs_MeetingMinutes_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vgs_MeetingMinutesEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_MeetingMinutesEx_GetObjExLstByPagerAsync = vgs_MeetingMinutesEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_MeetingMinutesEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsvgs_MeetingMinutesWApi_js_2.vgs_MeetingMinutes_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsvgs_MeetingMinutesWApi_js_2.vgs_MeetingMinutes_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vgs_MeetingMinutesEx_SortFunByKey = vgs_MeetingMinutesEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vgs_MeetingMinutesEx_FuncMapByFldName(strFldName, objvgs_MeetingMinutesEx) {
        const strThisFuncName = vgs_MeetingMinutesEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvgs_MeetingMinutesEN_js_1.clsvgs_MeetingMinutesEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vgs_MeetingMinutesEx_FuncMapByFldName = vgs_MeetingMinutesEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_MeetingMinutesEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsvgs_MeetingMinutesWApi_js_1.vgs_MeetingMinutes_FilterFunByKey)(strKey, value);
        }
    }
    exports.vgs_MeetingMinutesEx_FilterFunByKey = vgs_MeetingMinutesEx_FilterFunByKey;
});
