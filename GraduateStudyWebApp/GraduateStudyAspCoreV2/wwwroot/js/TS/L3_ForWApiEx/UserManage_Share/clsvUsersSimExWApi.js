/**
* 类名:clsvUsersSimExWApi
* 表名:vUsersSim(01120699)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/12 16:39:01
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/UserManage_Share/clsvUsersSimENEx.js", "../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vUsersSimEx_FilterFunByKey = exports.vUsersSimEx_FuncMapByFldName = exports.vUsersSimEx_SortFunByKey = exports.vUsersSimEx_GetObjExLstByPagerAsync = exports.vUsersSimEx_GetObjExLstByPager_Cache = exports.vUsersSimEx_CopyToEx = exports.vUsersSimEx_GetWebApiUrl = exports.vUsersSimEx_ConstructorName = exports.vUsersSimEx_Controller = void 0;
    /**
    * vUsersSim(vUsersSim)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
   * Created by pyf on 2023年03月12日.
   * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsvUsersSimWApi_js_1 = require("../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsvUsersSimEN_js_1 = require("../../L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clsvUsersSimENEx_js_1 = require("../../L0_Entity/UserManage_Share/clsvUsersSimENEx.js");
    const clsvUsersSimWApi_js_2 = require("../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsvUsersSimWApi_js_3 = require("../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsvUsersSimWApi_js_4 = require("../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    exports.vUsersSimEx_Controller = "vUsersSimExApi";
    exports.vUsersSimEx_ConstructorName = "vUsersSimEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vUsersSimEx_GetWebApiUrl(strController, strAction) {
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
    exports.vUsersSimEx_GetWebApiUrl = vUsersSimEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvUsersSimENS:源对象
    * @returns 目标对象=>clsvUsersSimEN:objvUsersSimENT
    **/
    function vUsersSimEx_CopyToEx(objvUsersSimENS) {
        const strThisFuncName = vUsersSimEx_CopyToEx.name;
        const objvUsersSimENT = new clsvUsersSimENEx_js_1.clsvUsersSimENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvUsersSimENT, objvUsersSimENS);
            return objvUsersSimENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vUsersSimEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvUsersSimENT;
        }
    }
    exports.vUsersSimEx_CopyToEx = vUsersSimEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vUsersSimEx_GetObjExLstByPager_Cache(objPagerPara, strCmPrjId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvUsersSimObjLst = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(strCmPrjId);
        const arrvUsersSimExObjLst = arrvUsersSimObjLst.map(vUsersSimEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvUsersSimExObjLst) {
                const conFuncMap = await vUsersSimEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvUsersSimExObjLst.length == 0)
            return arrvUsersSimExObjLst;
        let arrvUsersSim_Sel = arrvUsersSimExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvUsersSim_Cond = new clsvUsersSimENEx_js_1.clsvUsersSimENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvUsersSim_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvUsersSimWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvUsersSim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvUsersSim_Sel.length == 0)
                return arrvUsersSim_Sel;
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
                arrvUsersSim_Sel = arrvUsersSim_Sel.sort(vUsersSimEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvUsersSim_Sel = arrvUsersSim_Sel.sort(objPagerPara.sortFun);
            }
            arrvUsersSim_Sel = arrvUsersSim_Sel.slice(intStart, intEnd);
            return arrvUsersSim_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vUsersSimEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vUsersSimEx_GetObjExLstByPager_Cache = vUsersSimEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vUsersSimEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvUsersSimObjLst = await (0, clsvUsersSimWApi_js_2.vUsersSim_GetObjLstAsync)(objPagerPara.whereCond);
        const arrvUsersSimExObjLst = arrvUsersSimObjLst.map(vUsersSimEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvUsersSimExObjLst) {
                const conFuncMap = await vUsersSimEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvUsersSimExObjLst.length == 0)
            return arrvUsersSimExObjLst;
        let arrvUsersSim_Sel = arrvUsersSimExObjLst;
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
                arrvUsersSim_Sel = arrvUsersSim_Sel.sort(vUsersSimEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvUsersSim_Sel = arrvUsersSim_Sel.sort(objPagerPara.sortFun);
            }
            arrvUsersSim_Sel = arrvUsersSim_Sel.slice(intStart, intEnd);
            return arrvUsersSim_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vUsersSimEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vUsersSimEx_GetObjExLstByPagerAsync = vUsersSimEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vUsersSimEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvUsersSimENEx_js_1.clsvUsersSimENEx.con_CmPrjId:
                    return (a, b) => {
                        return a.cmPrjId.localeCompare(b.cmPrjId);
                    };
                default:
                    return (0, clsvUsersSimWApi_js_3.vUsersSim_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                case clsvUsersSimENEx_js_1.clsvUsersSimENEx.con_CmPrjId:
                    return (a, b) => {
                        return b.cmPrjId.localeCompare(a.cmPrjId);
                    };
                default:
                    return (0, clsvUsersSimWApi_js_3.vUsersSim_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vUsersSimEx_SortFunByKey = vUsersSimEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vUsersSimEx_FuncMapByFldName(strFldName, objvUsersSimEx) {
        const strThisFuncName = vUsersSimEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvUsersSimEN_js_1.clsvUsersSimEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vUsersSimEx_FuncMapByFldName = vUsersSimEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vUsersSimEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvUsersSimENEx_js_1.clsvUsersSimENEx.con_CmPrjId:
                return (obj) => {
                    return obj.cmPrjId === value;
                };
            default:
                return (0, clsvUsersSimWApi_js_4.vUsersSim_FilterFunByKey)(strKey, value);
        }
    }
    exports.vUsersSimEx_FilterFunByKey = vUsersSimEx_FilterFunByKey;
});
