(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/BaseInfo_Share/clsXzMajorEN.js", "../../L0_Entity/BaseInfo_Share/clsXzMajorENEx.js", "../../L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js", "../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzMajorEx_BindDdl_id_XzMajorForvUsersSimInDiv_CacheEx = exports.XzMajorEx_SortFun_majorName = exports.XzMajorEx_FilterFunByKey = exports.XzMajorEx_FuncMapByFldName = exports.XzMajorEx_SortFunByKey = exports.XzMajorEx_GetObjExLstByPagerAsync = exports.XzMajorEx_GetObjExLstByPager_Cache = exports.XzMajorEx_CopyToEx = exports.XzMajorEx_GetWebApiUrl = exports.xzMajorEx_ConstructorName = exports.xzMajorEx_Controller = void 0;
    //import * as QQ from "q";
    const clsXzMajorEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsXzMajorEN.js");
    const clsXzMajorENEx_js_1 = require("../../L0_Entity/BaseInfo_Share/clsXzMajorENEx.js");
    const clsXzMajorWApi_js_1 = require("../../L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsvUsersSimWApi_js_1 = require("../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    exports.xzMajorEx_Controller = "XzMajorExApi";
    exports.xzMajorEx_ConstructorName = "xzMajorEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function XzMajorEx_GetWebApiUrl(strController, strAction) {
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
    exports.XzMajorEx_GetWebApiUrl = XzMajorEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objXzMajorENS:源对象
    * @returns 目标对象=>clsXzMajorEN:objXzMajorENT
    **/
    function XzMajorEx_CopyToEx(objXzMajorENS) {
        const strThisFuncName = XzMajorEx_CopyToEx.name;
        const objXzMajorENT = new clsXzMajorENEx_js_1.clsXzMajorENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzMajorENT, objXzMajorENS);
            return objXzMajorENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.xzMajorEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objXzMajorENT;
        }
    }
    exports.XzMajorEx_CopyToEx = XzMajorEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function XzMajorEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrXzMajorObjLst = await (0, clsXzMajorWApi_js_1.XzMajor_GetObjLst_Cache)();
        const arrXzMajorExObjLst = arrXzMajorObjLst.map(XzMajorEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrXzMajorExObjLst) {
                const conFuncMap = await XzMajorEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrXzMajorExObjLst.length == 0)
            return arrXzMajorExObjLst;
        let arrXzMajor_Sel = arrXzMajorExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objXzMajor_Cond = new clsXzMajorENEx_js_1.clsXzMajorENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzMajor_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsXzMajorWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajor_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzMajor_Sel.length == 0)
                return arrXzMajor_Sel;
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
                arrXzMajor_Sel = arrXzMajor_Sel.sort(XzMajorEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrXzMajor_Sel = arrXzMajor_Sel.sort(objPagerPara.sortFun);
            }
            arrXzMajor_Sel = arrXzMajor_Sel.slice(intStart, intEnd);
            return arrXzMajor_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.xzMajorEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzMajorEx_GetObjExLstByPager_Cache = XzMajorEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function XzMajorEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrXzMajorExObjLst = await (0, clsXzMajorWApi_js_1.XzMajor_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrXzMajorExObjLst) {
                const conFuncMap = await XzMajorEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrXzMajorExObjLst.length == 0)
            return arrXzMajorExObjLst;
        let arrXzMajor_Sel = arrXzMajorExObjLst;
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
                arrXzMajor_Sel = arrXzMajor_Sel.sort(XzMajorEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrXzMajor_Sel = arrXzMajor_Sel.sort(objPagerPara.sortFun);
            }
            arrXzMajor_Sel = arrXzMajor_Sel.slice(intStart, intEnd);
            return arrXzMajor_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.xzMajorEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzMajorEx_GetObjExLstByPagerAsync = XzMajorEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzMajorEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsXzMajorWApi_js_1.XzMajor_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsXzMajorWApi_js_1.XzMajor_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.XzMajorEx_SortFunByKey = XzMajorEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function XzMajorEx_FuncMapByFldName(strFldName, objXzMajorEx) {
        const strThisFuncName = XzMajorEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsXzMajorEN_js_1.clsXzMajorEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.XzMajorEx_FuncMapByFldName = XzMajorEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function XzMajorEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsXzMajorWApi_js_1.XzMajor_FilterFunByKey)(strKey, value);
        }
    }
    exports.XzMajorEx_FilterFunByKey = XzMajorEx_FilterFunByKey;
    function XzMajorEx_SortFun_majorName(a, b) {
        return a.majorName.localeCompare(b.majorName);
    }
    exports.XzMajorEx_SortFun_majorName = XzMajorEx_SortFun_majorName;
    async function XzMajorEx_BindDdl_id_XzMajorForvUsersSimInDiv_CacheEx(strDivName, strDdlName, strCmPrjId) {
        if ((0, clsString_js_1.IsNullOrEmpty)(strCmPrjId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strstrCmPrjIdPrjId]不能为空！(In BindDdl_id_XzMajor_CacheEx)");
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = `下拉框：${strDdlName} 不存在！(In BindDdl_id_XzMajor_Cache)`;
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrObjLst_Sel = await (0, clsXzMajorWApi_js_1.XzMajor_GetObjLst_Cache)();
        let arrvUsersSimObjLst = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(strCmPrjId);
        const arrid_XzMajor = arrvUsersSimObjLst.map(x => x.id_XzMajor);
        arrObjLst_Sel = arrObjLst_Sel.filter(x => arrid_XzMajor.indexOf(x.id_XzMajor) > -1);
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, "专业");
    }
    exports.XzMajorEx_BindDdl_id_XzMajorForvUsersSimInDiv_CacheEx = XzMajorEx_BindDdl_id_XzMajorForvUsersSimInDiv_CacheEx;
});