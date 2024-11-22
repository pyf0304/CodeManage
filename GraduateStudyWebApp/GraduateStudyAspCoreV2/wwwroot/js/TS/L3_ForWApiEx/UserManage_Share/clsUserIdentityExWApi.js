/**
* 类名:clsUserIdentityExWApi
* 表名:UserIdentity(01120177)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/09 04:08:09
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:游戏化教育平台(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:用户管理(UserManage)
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/UserManage_Share/clsUserIdentityEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/UserManage_Share/clsUserIdentityENEx.js", "../../L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js", "../../L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.UserIdentityEx_FilterFunByKey = exports.UserIdentityEx_FuncMapByFldName = exports.UserIdentityEx_SortFunByKey = exports.UserIdentityEx_GetObjExLstByPagerAsync = exports.UserIdentityEx_GetObjExLstByPager_Cache = exports.UserIdentityEx_CopyToEx = exports.UserIdentityEx_GetWebApiUrl = exports.userIdentityEx_ConstructorName = exports.userIdentityEx_Controller = void 0;
    /**
    * 用户身份(UserIdentity)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
   * Created by pyf on 2022年11月09日.
   * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsUserIdentityWApi_js_1 = require("../../L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsUserIdentityEN_js_1 = require("../../L0_Entity/UserManage_Share/clsUserIdentityEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clsUserIdentityENEx_js_1 = require("../../L0_Entity/UserManage_Share/clsUserIdentityENEx.js");
    const clsUserIdentityWApi_js_2 = require("../../L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js");
    const clsUserIdentityWApi_js_3 = require("../../L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsUserIdentityWApi_js_4 = require("../../L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    exports.userIdentityEx_Controller = "UserIdentityExApi";
    exports.userIdentityEx_ConstructorName = "userIdentityEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function UserIdentityEx_GetWebApiUrl(strController, strAction) {
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
    exports.UserIdentityEx_GetWebApiUrl = UserIdentityEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objUserIdentityENS:源对象
    * @returns 目标对象=>clsUserIdentityEN:objUserIdentityENT
    **/
    function UserIdentityEx_CopyToEx(objUserIdentityENS) {
        const strThisFuncName = UserIdentityEx_CopyToEx.name;
        const objUserIdentityENT = new clsUserIdentityENEx_js_1.clsUserIdentityENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objUserIdentityENT, objUserIdentityENS);
            return objUserIdentityENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.userIdentityEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objUserIdentityENT;
        }
    }
    exports.UserIdentityEx_CopyToEx = UserIdentityEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function UserIdentityEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrUserIdentityObjLst = await (0, clsUserIdentityWApi_js_1.UserIdentity_GetObjLst_Cache)();
        const arrUserIdentityExObjLst = arrUserIdentityObjLst.map(UserIdentityEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrUserIdentityExObjLst) {
                const conFuncMap = await UserIdentityEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrUserIdentityExObjLst.length == 0)
            return arrUserIdentityExObjLst;
        let arrUserIdentity_Sel = arrUserIdentityExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objUserIdentity_Cond = new clsUserIdentityENEx_js_1.clsUserIdentityENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objUserIdentity_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsUserIdentityWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objUserIdentity_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrUserIdentity_Sel = arrUserIdentity_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrUserIdentity_Sel.length == 0)
                return arrUserIdentity_Sel;
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
                arrUserIdentity_Sel = arrUserIdentity_Sel.sort(UserIdentityEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrUserIdentity_Sel = arrUserIdentity_Sel.sort(objPagerPara.sortFun);
            }
            arrUserIdentity_Sel = arrUserIdentity_Sel.slice(intStart, intEnd);
            return arrUserIdentity_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.userIdentityEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.UserIdentityEx_GetObjExLstByPager_Cache = UserIdentityEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function UserIdentityEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrUserIdentityObjLst = await (0, clsUserIdentityWApi_js_2.UserIdentity_GetObjLstAsync)(objPagerPara.whereCond);
        const arrUserIdentityExObjLst = arrUserIdentityObjLst.map(UserIdentityEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrUserIdentityExObjLst) {
                const conFuncMap = await UserIdentityEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrUserIdentityExObjLst.length == 0)
            return arrUserIdentityExObjLst;
        let arrUserIdentity_Sel = arrUserIdentityExObjLst;
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
                arrUserIdentity_Sel = arrUserIdentity_Sel.sort(UserIdentityEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrUserIdentity_Sel = arrUserIdentity_Sel.sort(objPagerPara.sortFun);
            }
            arrUserIdentity_Sel = arrUserIdentity_Sel.slice(intStart, intEnd);
            return arrUserIdentity_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.userIdentityEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.UserIdentityEx_GetObjExLstByPagerAsync = UserIdentityEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function UserIdentityEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsUserIdentityWApi_js_3.UserIdentity_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsUserIdentityWApi_js_3.UserIdentity_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.UserIdentityEx_SortFunByKey = UserIdentityEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function UserIdentityEx_FuncMapByFldName(strFldName, objUserIdentityEx) {
        const strThisFuncName = UserIdentityEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsUserIdentityEN_js_1.clsUserIdentityEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.UserIdentityEx_FuncMapByFldName = UserIdentityEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function UserIdentityEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsUserIdentityWApi_js_4.UserIdentity_FilterFunByKey)(strKey, value);
        }
    }
    exports.UserIdentityEx_FilterFunByKey = UserIdentityEx_FilterFunByKey;
});
