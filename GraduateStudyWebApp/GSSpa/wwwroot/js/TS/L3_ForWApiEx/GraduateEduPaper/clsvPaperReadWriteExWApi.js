/**
* 类名:clsvPaperReadWriteExWApi
* 表名:vPaperReadWrite(01120550)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 15:20:43
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培论文(GraduateEduPaper)
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/GraduateEduPaper/clsvPaperReadWriteENEx.js", "../../L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js", "../../L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vPaperReadWriteEx_FilterFunByKey = exports.vPaperReadWriteEx_FuncMapByFldName = exports.vPaperReadWriteEx_SortFunByKey = exports.vPaperReadWriteEx_GetObjExLstByPagerAsync = exports.vPaperReadWriteEx_GetObjExLstByPager_Cache = exports.vPaperReadWriteEx_CopyToEx = exports.vPaperReadWriteEx_GetWebApiUrl = exports.vPaperReadWriteEx_ConstructorName = exports.vPaperReadWriteEx_Controller = void 0;
    /**
    * v论文读写表(vPaperReadWrite)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsvPaperReadWriteWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsvPaperReadWriteEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clsvPaperReadWriteENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperReadWriteENEx.js");
    const clsvPaperReadWriteWApi_js_2 = require("../../L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js");
    const clsvPaperReadWriteWApi_js_3 = require("../../L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsvPaperReadWriteWApi_js_4 = require("../../L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    exports.vPaperReadWriteEx_Controller = "vPaperReadWriteExApi";
    exports.vPaperReadWriteEx_ConstructorName = "vPaperReadWriteEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vPaperReadWriteEx_GetWebApiUrl(strController, strAction) {
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
    exports.vPaperReadWriteEx_GetWebApiUrl = vPaperReadWriteEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvPaperReadWriteENS:源对象
    * @returns 目标对象=>clsvPaperReadWriteEN:objvPaperReadWriteENT
    **/
    function vPaperReadWriteEx_CopyToEx(objvPaperReadWriteENS) {
        const strThisFuncName = vPaperReadWriteEx_CopyToEx.name;
        const objvPaperReadWriteENT = new clsvPaperReadWriteENEx_js_1.clsvPaperReadWriteENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperReadWriteENT, objvPaperReadWriteENS);
            return objvPaperReadWriteENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vPaperReadWriteEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvPaperReadWriteENT;
        }
    }
    exports.vPaperReadWriteEx_CopyToEx = vPaperReadWriteEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vPaperReadWriteEx_GetObjExLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvPaperReadWriteObjLst = await (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_GetObjLst_Cache)(strid_CurrEduCls);
        const arrvPaperReadWriteExObjLst = arrvPaperReadWriteObjLst.map(vPaperReadWriteEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvPaperReadWriteExObjLst) {
                const conFuncMap = await vPaperReadWriteEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvPaperReadWriteExObjLst.length == 0)
            return arrvPaperReadWriteExObjLst;
        let arrvPaperReadWrite_Sel = arrvPaperReadWriteExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvPaperReadWrite_Cond = new clsvPaperReadWriteENEx_js_1.clsvPaperReadWriteENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperReadWrite_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvPaperReadWriteWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperReadWrite_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaperReadWrite_Sel.length == 0)
                return arrvPaperReadWrite_Sel;
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
                arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.sort(vPaperReadWriteEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.slice(intStart, intEnd);
            return arrvPaperReadWrite_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vPaperReadWriteEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperReadWriteEx_GetObjExLstByPager_Cache = vPaperReadWriteEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vPaperReadWriteEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvPaperReadWriteObjLst = await (0, clsvPaperReadWriteWApi_js_2.vPaperReadWrite_GetObjLstAsync)(objPagerPara.whereCond);
        const arrvPaperReadWriteExObjLst = arrvPaperReadWriteObjLst.map(vPaperReadWriteEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvPaperReadWriteExObjLst) {
                const conFuncMap = await vPaperReadWriteEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvPaperReadWriteExObjLst.length == 0)
            return arrvPaperReadWriteExObjLst;
        let arrvPaperReadWrite_Sel = arrvPaperReadWriteExObjLst;
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
                arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.sort(vPaperReadWriteEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.slice(intStart, intEnd);
            return arrvPaperReadWrite_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vPaperReadWriteEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperReadWriteEx_GetObjExLstByPagerAsync = vPaperReadWriteEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperReadWriteEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvPaperReadWriteENEx_js_1.clsvPaperReadWriteENEx.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                default:
                    return (0, clsvPaperReadWriteWApi_js_3.vPaperReadWrite_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                case clsvPaperReadWriteENEx_js_1.clsvPaperReadWriteENEx.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                default:
                    return (0, clsvPaperReadWriteWApi_js_3.vPaperReadWrite_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vPaperReadWriteEx_SortFunByKey = vPaperReadWriteEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vPaperReadWriteEx_FuncMapByFldName(strFldName, objvPaperReadWriteEx) {
        const strThisFuncName = vPaperReadWriteEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vPaperReadWriteEx_FuncMapByFldName = vPaperReadWriteEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vPaperReadWriteEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvPaperReadWriteENEx_js_1.clsvPaperReadWriteENEx.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            default:
                return (0, clsvPaperReadWriteWApi_js_4.vPaperReadWrite_FilterFunByKey)(strKey, value);
        }
    }
    exports.vPaperReadWriteEx_FilterFunByKey = vPaperReadWriteEx_FilterFunByKey;
});
