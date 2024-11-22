/**
* 类名:clsXzMajorDirectionExWApi
* 表名:XzMajorDirection(01120552)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/12 19:25:58
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:游戏化教育平台(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:基本信息维护(BaseInfo)
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/BaseInfo_Share/clsXzMajorDirectionEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/BaseInfo_Share/clsXzMajorDirectionENEx.js", "../../L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js", "../../L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../../L0_Entity/BaseInfo_Share/clsXzMajorEN.js", "../../L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js", "../../L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/enumComparisonOp.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzMajorDirectionEx_FuncMapKey_MajorName = exports.XzMajorDirectionEx_FilterFunByKey = exports.XzMajorDirectionEx_FuncMapByFldName = exports.XzMajorDirectionEx_SortFunByKey = exports.XzMajorDirectionEx_FuncMap_MajorName = exports.XzMajorDirectionEx_GetObjExLstByPagerAsync = exports.XzMajorDirectionEx_GetObjExLstByPager_Cache = exports.XzMajorDirectionEx_CopyToEx = exports.XzMajorDirectionEx_GetWebApiUrl = exports.xzMajorDirectionEx_ConstructorName = exports.xzMajorDirectionEx_Controller = void 0;
    /**
    * 专业方向(XzMajorDirection)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
    * Created by pyf on 2023年03月12日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsXzMajorDirectionWApi_js_1 = require("../../L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsXzMajorDirectionEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsXzMajorDirectionEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clsXzMajorDirectionENEx_js_1 = require("../../L0_Entity/BaseInfo_Share/clsXzMajorDirectionENEx.js");
    const clsXzMajorDirectionWApi_js_2 = require("../../L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js");
    const clsXzMajorWApi_js_1 = require("../../L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsXzMajorEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsXzMajorEN.js");
    const clsXzMajorDirectionWApi_js_3 = require("../../L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsXzMajorDirectionWApi_js_4 = require("../../L3_ForWApi/BaseInfo_Share/clsXzMajorDirectionWApi.js");
    const clsXzMajorWApi_js_2 = require("../../L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    exports.xzMajorDirectionEx_Controller = "XzMajorDirectionExApi";
    exports.xzMajorDirectionEx_ConstructorName = "xzMajorDirectionEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function XzMajorDirectionEx_GetWebApiUrl(strController, strAction) {
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
    exports.XzMajorDirectionEx_GetWebApiUrl = XzMajorDirectionEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objXzMajorDirectionENS:源对象
    * @returns 目标对象=>clsXzMajorDirectionEN:objXzMajorDirectionENT
    **/
    function XzMajorDirectionEx_CopyToEx(objXzMajorDirectionENS) {
        const strThisFuncName = XzMajorDirectionEx_CopyToEx.name;
        const objXzMajorDirectionENT = new clsXzMajorDirectionENEx_js_1.clsXzMajorDirectionENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzMajorDirectionENT, objXzMajorDirectionENS);
            return objXzMajorDirectionENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.xzMajorDirectionEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objXzMajorDirectionENT;
        }
    }
    exports.XzMajorDirectionEx_CopyToEx = XzMajorDirectionEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function XzMajorDirectionEx_GetObjExLstByPager_Cache(objPagerPara, strid_XzMajor) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrXzMajorDirectionObjLst = await (0, clsXzMajorDirectionWApi_js_1.XzMajorDirection_GetObjLst_Cache)(strid_XzMajor);
        const arrXzMajorDirectionExObjLst = arrXzMajorDirectionObjLst.map(XzMajorDirectionEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrXzMajorDirectionExObjLst) {
                const conFuncMap = await XzMajorDirectionEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrXzMajorDirectionExObjLst.length == 0)
            return arrXzMajorDirectionExObjLst;
        let arrXzMajorDirection_Sel = arrXzMajorDirectionExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objXzMajorDirection_Cond = new clsXzMajorDirectionENEx_js_1.clsXzMajorDirectionENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzMajorDirection_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsXzMajorDirectionWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajorDirection_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzMajorDirection_Sel.length == 0)
                return arrXzMajorDirection_Sel;
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
                arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.sort(XzMajorDirectionEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.sort(objPagerPara.sortFun);
            }
            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.slice(intStart, intEnd);
            return arrXzMajorDirection_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.xzMajorDirectionEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzMajorDirectionEx_GetObjExLstByPager_Cache = XzMajorDirectionEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function XzMajorDirectionEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrXzMajorDirectionObjLst = await (0, clsXzMajorDirectionWApi_js_2.XzMajorDirection_GetObjLstAsync)(objPagerPara.whereCond);
        const arrXzMajorDirectionExObjLst = arrXzMajorDirectionObjLst.map(XzMajorDirectionEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrXzMajorDirectionExObjLst) {
                const conFuncMap = await XzMajorDirectionEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrXzMajorDirectionExObjLst.length == 0)
            return arrXzMajorDirectionExObjLst;
        let arrXzMajorDirection_Sel = arrXzMajorDirectionExObjLst;
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
                arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.sort(XzMajorDirectionEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.sort(objPagerPara.sortFun);
            }
            arrXzMajorDirection_Sel = arrXzMajorDirection_Sel.slice(intStart, intEnd);
            return arrXzMajorDirection_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.xzMajorDirectionEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzMajorDirectionEx_GetObjExLstByPagerAsync = XzMajorDirectionEx_GetObjExLstByPagerAsync;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objXzMajorDirectionS:源对象
    **/
    async function XzMajorDirectionEx_FuncMap_MajorName(objXzMajorDirection) {
        const strThisFuncName = XzMajorDirectionEx_FuncMap_MajorName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objXzMajorDirection.majorName) == true) {
                const XzMajor_id_XzMajor = objXzMajorDirection.id_XzMajor;
                const XzMajor_MajorName = await (0, clsXzMajorWApi_js_1.XzMajor_func)(clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, XzMajor_id_XzMajor);
                objXzMajorDirection.majorName = XzMajor_MajorName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000204)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.xzMajorDirectionEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.XzMajorDirectionEx_FuncMap_MajorName = XzMajorDirectionEx_FuncMap_MajorName;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzMajorDirectionEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsXzMajorDirectionENEx_js_1.clsXzMajorDirectionENEx.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                default:
                    return (0, clsXzMajorDirectionWApi_js_3.XzMajorDirection_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                case clsXzMajorDirectionENEx_js_1.clsXzMajorDirectionENEx.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                default:
                    return (0, clsXzMajorDirectionWApi_js_3.XzMajorDirection_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.XzMajorDirectionEx_SortFunByKey = XzMajorDirectionEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function XzMajorDirectionEx_FuncMapByFldName(strFldName, objXzMajorDirectionEx) {
        const strThisFuncName = XzMajorDirectionEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsXzMajorDirectionEN_js_1.clsXzMajorDirectionEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            case clsXzMajorDirectionENEx_js_1.clsXzMajorDirectionENEx.con_MajorName:
                return XzMajorDirectionEx_FuncMap_MajorName(objXzMajorDirectionEx);
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.XzMajorDirectionEx_FuncMapByFldName = XzMajorDirectionEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function XzMajorDirectionEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsXzMajorDirectionENEx_js_1.clsXzMajorDirectionENEx.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            default:
                return (0, clsXzMajorDirectionWApi_js_4.XzMajorDirection_FilterFunByKey)(strKey, value);
        }
    }
    exports.XzMajorDirectionEx_FilterFunByKey = XzMajorDirectionEx_FilterFunByKey;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapKey)
    * @param objXzMajorDirectionS:源对象
    **/
    async function XzMajorDirectionEx_FuncMapKey_MajorName(objXzMajorDirection) {
        const strThisFuncName = XzMajorDirectionEx_FuncMapKey_MajorName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objXzMajorDirection.majorName) == true)
                return [];
            const XzMajor_MajorName = objXzMajorDirection.majorName;
            const arrid_XzMajor = await (0, clsXzMajorWApi_js_2.XzMajor_funcKey)(clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, XzMajor_MajorName, enumComparisonOp_js_1.enumComparisonOp.Like_03);
            return arrid_XzMajor;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000204)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.xzMajorDirectionEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
    }
    exports.XzMajorDirectionEx_FuncMapKey_MajorName = XzMajorDirectionEx_FuncMapKey_MajorName;
});
