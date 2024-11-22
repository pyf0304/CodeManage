/**
* 类名:clsvcc_CourseExWApi
* 表名:vcc_Course(01120058)
* 版本:2023.01.07.1(服务器:WIN-SRV103-116)
* 日期:2023/01/08 11:18:55
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:课程学习(CourseLearning)
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/CourseLearning_Share/clsvcc_CourseWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/CourseLearning_Share/clsvcc_CourseEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/CourseLearning_Share/clsvcc_CourseENEx.js", "../../L3_ForWApi/CourseLearning_Share/clsvcc_CourseWApi.js", "../../L3_ForWApi/CourseLearning_Share/clsvcc_CourseWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/CourseLearning_Share/clsvcc_CourseWApi.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vcc_CourseEx_FilterFunByKey = exports.vcc_CourseEx_FuncMapByFldName = exports.vcc_CourseEx_SortFunByKey = exports.vcc_CourseEx_GetObjExLstByPagerAsync = exports.vcc_CourseEx_GetObjExLstByPager_Cache = exports.vcc_CourseEx_CopyToEx = exports.vcc_CourseEx_GetWebApiUrl = exports.vcc_CourseEx_ConstructorName = exports.vcc_CourseEx_Controller = void 0;
    /**
    * v课程(vcc_Course)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
   * Created by pyf on 2023年01月08日.
   * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsvcc_CourseWApi_js_1 = require("../../L3_ForWApi/CourseLearning_Share/clsvcc_CourseWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsvcc_CourseEN_js_1 = require("../../L0_Entity/CourseLearning_Share/clsvcc_CourseEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clsvcc_CourseENEx_js_1 = require("../../L0_Entity/CourseLearning_Share/clsvcc_CourseENEx.js");
    const clsvcc_CourseWApi_js_2 = require("../../L3_ForWApi/CourseLearning_Share/clsvcc_CourseWApi.js");
    const clsvcc_CourseWApi_js_3 = require("../../L3_ForWApi/CourseLearning_Share/clsvcc_CourseWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsvcc_CourseWApi_js_4 = require("../../L3_ForWApi/CourseLearning_Share/clsvcc_CourseWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    exports.vcc_CourseEx_Controller = "vcc_CourseExApi";
    exports.vcc_CourseEx_ConstructorName = "vcc_CourseEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vcc_CourseEx_GetWebApiUrl(strController, strAction) {
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
    exports.vcc_CourseEx_GetWebApiUrl = vcc_CourseEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvcc_CourseENS:源对象
    * @returns 目标对象=>clsvcc_CourseEN:objvcc_CourseENT
    **/
    function vcc_CourseEx_CopyToEx(objvcc_CourseENS) {
        const strThisFuncName = vcc_CourseEx_CopyToEx.name;
        const objvcc_CourseENT = new clsvcc_CourseENEx_js_1.clsvcc_CourseENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvcc_CourseENT, objvcc_CourseENS);
            return objvcc_CourseENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvcc_CourseENT;
        }
    }
    exports.vcc_CourseEx_CopyToEx = vcc_CourseEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vcc_CourseEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvcc_CourseObjLst = await (0, clsvcc_CourseWApi_js_1.vcc_Course_GetObjLst_Cache)();
        const arrvcc_CourseExObjLst = arrvcc_CourseObjLst.map(vcc_CourseEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvcc_CourseExObjLst) {
                const conFuncMap = await vcc_CourseEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvcc_CourseExObjLst.length == 0)
            return arrvcc_CourseExObjLst;
        let arrvcc_Course_Sel = arrvcc_CourseExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvcc_Course_Cond = new clsvcc_CourseENEx_js_1.clsvcc_CourseENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvcc_Course_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvcc_CourseWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_Course_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_Course_Sel = arrvcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvcc_Course_Sel.length == 0)
                return arrvcc_Course_Sel;
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
                arrvcc_Course_Sel = arrvcc_Course_Sel.sort(vcc_CourseEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvcc_Course_Sel = arrvcc_Course_Sel.sort(objPagerPara.sortFun);
            }
            arrvcc_Course_Sel = arrvcc_Course_Sel.slice(intStart, intEnd);
            return arrvcc_Course_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vcc_CourseEx_GetObjExLstByPager_Cache = vcc_CourseEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vcc_CourseEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvcc_CourseObjLst = await (0, clsvcc_CourseWApi_js_2.vcc_Course_GetObjLstAsync)(objPagerPara.whereCond);
        const arrvcc_CourseExObjLst = arrvcc_CourseObjLst.map(vcc_CourseEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvcc_CourseExObjLst) {
                const conFuncMap = await vcc_CourseEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvcc_CourseExObjLst.length == 0)
            return arrvcc_CourseExObjLst;
        let arrvcc_Course_Sel = arrvcc_CourseExObjLst;
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
                arrvcc_Course_Sel = arrvcc_Course_Sel.sort(vcc_CourseEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvcc_Course_Sel = arrvcc_Course_Sel.sort(objPagerPara.sortFun);
            }
            arrvcc_Course_Sel = arrvcc_Course_Sel.slice(intStart, intEnd);
            return arrvcc_Course_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vcc_CourseEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vcc_CourseEx_GetObjExLstByPagerAsync = vcc_CourseEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-01-08
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_CourseEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsvcc_CourseWApi_js_3.vcc_Course_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsvcc_CourseWApi_js_3.vcc_Course_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vcc_CourseEx_SortFunByKey = vcc_CourseEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2023-01-08
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vcc_CourseEx_FuncMapByFldName(strFldName, objvcc_CourseEx) {
        const strThisFuncName = vcc_CourseEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvcc_CourseEN_js_1.clsvcc_CourseEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vcc_CourseEx_FuncMapByFldName = vcc_CourseEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-01-08
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vcc_CourseEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsvcc_CourseWApi_js_4.vcc_Course_FilterFunByKey)(strKey, value);
        }
    }
    exports.vcc_CourseEx_FilterFunByKey = vcc_CourseEx_FilterFunByKey;
});
