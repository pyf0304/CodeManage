/**
* 类名:clssys_RequestPushExWApi
* 表名:sys_RequestPush(01120726)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/05 01:03:41
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培设置(GraduateEduTools)
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/GraduateEduTools/clssys_RequestPushEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/GraduateEduTools/clssys_RequestPushENEx.js", "../../L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js", "../../L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.sys_RequestPushEx_FilterFunByKey = exports.sys_RequestPushEx_FuncMapByFldName = exports.sys_RequestPushEx_SortFunByKey = exports.sys_RequestPushEx_GetObjExLstByPagerAsync = exports.sys_RequestPushEx_GetObjExLstByPager_Cache = exports.sys_RequestPushEx_CopyToEx = exports.sys_RequestPushEx_GetWebApiUrl = exports.sys_RequestPushEx_ConstructorName = exports.sys_RequestPushEx_Controller = void 0;
    /**
    * 请求推送表(sys_RequestPush)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
   * Created by pyf on 2022年11月05日.
   * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clssys_RequestPushWApi_js_1 = require("../../L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clssys_RequestPushEN_js_1 = require("../../L0_Entity/GraduateEduTools/clssys_RequestPushEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clssys_RequestPushENEx_js_1 = require("../../L0_Entity/GraduateEduTools/clssys_RequestPushENEx.js");
    const clssys_RequestPushWApi_js_2 = require("../../L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js");
    const clssys_RequestPushWApi_js_3 = require("../../L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clssys_RequestPushWApi_js_4 = require("../../L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    exports.sys_RequestPushEx_Controller = "sys_RequestPushExApi";
    exports.sys_RequestPushEx_ConstructorName = "sys_RequestPushEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function sys_RequestPushEx_GetWebApiUrl(strController, strAction) {
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
    exports.sys_RequestPushEx_GetWebApiUrl = sys_RequestPushEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objsys_RequestPushENS:源对象
    * @returns 目标对象=>clssys_RequestPushEN:objsys_RequestPushENT
    **/
    function sys_RequestPushEx_CopyToEx(objsys_RequestPushENS) {
        const strThisFuncName = sys_RequestPushEx_CopyToEx.name;
        const objsys_RequestPushENT = new clssys_RequestPushENEx_js_1.clssys_RequestPushENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objsys_RequestPushENT, objsys_RequestPushENS);
            return objsys_RequestPushENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.sys_RequestPushEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objsys_RequestPushENT;
        }
    }
    exports.sys_RequestPushEx_CopyToEx = sys_RequestPushEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function sys_RequestPushEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrsys_RequestPushObjLst = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_GetObjLst_Cache)();
        const arrsys_RequestPushExObjLst = arrsys_RequestPushObjLst.map(sys_RequestPushEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrsys_RequestPushExObjLst) {
                const conFuncMap = await sys_RequestPushEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrsys_RequestPushExObjLst.length == 0)
            return arrsys_RequestPushExObjLst;
        let arrsys_RequestPush_Sel = arrsys_RequestPushExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objsys_RequestPush_Cond = new clssys_RequestPushENEx_js_1.clssys_RequestPushENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objsys_RequestPush_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clssys_RequestPushWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objsys_RequestPush_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrsys_RequestPush_Sel.length == 0)
                return arrsys_RequestPush_Sel;
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
                arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.sort(sys_RequestPushEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.sort(objPagerPara.sortFun);
            }
            arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.slice(intStart, intEnd);
            return arrsys_RequestPush_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sys_RequestPushEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.sys_RequestPushEx_GetObjExLstByPager_Cache = sys_RequestPushEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function sys_RequestPushEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrsys_RequestPushObjLst = await (0, clssys_RequestPushWApi_js_2.sys_RequestPush_GetObjLstAsync)(objPagerPara.whereCond);
        const arrsys_RequestPushExObjLst = arrsys_RequestPushObjLst.map(sys_RequestPushEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrsys_RequestPushExObjLst) {
                const conFuncMap = await sys_RequestPushEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrsys_RequestPushExObjLst.length == 0)
            return arrsys_RequestPushExObjLst;
        let arrsys_RequestPush_Sel = arrsys_RequestPushExObjLst;
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
                arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.sort(sys_RequestPushEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.sort(objPagerPara.sortFun);
            }
            arrsys_RequestPush_Sel = arrsys_RequestPush_Sel.slice(intStart, intEnd);
            return arrsys_RequestPush_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sys_RequestPushEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.sys_RequestPushEx_GetObjExLstByPagerAsync = sys_RequestPushEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function sys_RequestPushEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clssys_RequestPushENEx_js_1.clssys_RequestPushENEx.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                case clssys_RequestPushENEx_js_1.clssys_RequestPushENEx.con_EduClsName:
                    return (a, b) => {
                        return a.eduClsName.localeCompare(b.eduClsName);
                    };
                default:
                    return (0, clssys_RequestPushWApi_js_3.sys_RequestPush_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                case clssys_RequestPushENEx_js_1.clssys_RequestPushENEx.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                case clssys_RequestPushENEx_js_1.clssys_RequestPushENEx.con_EduClsName:
                    return (a, b) => {
                        return b.eduClsName.localeCompare(a.eduClsName);
                    };
                default:
                    return (0, clssys_RequestPushWApi_js_3.sys_RequestPush_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.sys_RequestPushEx_SortFunByKey = sys_RequestPushEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function sys_RequestPushEx_FuncMapByFldName(strFldName, objsys_RequestPushEx) {
        const strThisFuncName = sys_RequestPushEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clssys_RequestPushEN_js_1.clssys_RequestPushEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.sys_RequestPushEx_FuncMapByFldName = sys_RequestPushEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function sys_RequestPushEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clssys_RequestPushENEx_js_1.clssys_RequestPushENEx.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clssys_RequestPushENEx_js_1.clssys_RequestPushENEx.con_EduClsName:
                return (obj) => {
                    return obj.eduClsName === value;
                };
            default:
                return (0, clssys_RequestPushWApi_js_4.sys_RequestPush_FilterFunByKey)(strKey, value);
        }
    }
    exports.sys_RequestPushEx_FilterFunByKey = sys_RequestPushEx_FilterFunByKey;
});
