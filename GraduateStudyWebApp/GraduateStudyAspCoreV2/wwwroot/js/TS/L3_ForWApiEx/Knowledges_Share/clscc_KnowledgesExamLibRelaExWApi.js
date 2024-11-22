(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/Knowledges_Share/clscc_KnowledgesExamLibRelaWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/Knowledges_Share/clscc_KnowledgesExamLibRelaEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/Knowledges_Share/clscc_KnowledgesExamLibRelaENEx.js", "../../L3_ForWApi/Knowledges_Share/clscc_KnowledgesExamLibRelaWApi.js", "../../L3_ForWApi/Knowledges_Share/clscc_KnowledgesExamLibRelaWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/Knowledges_Share/clscc_KnowledgesExamLibRelaWApi.js", "../../PubConfig/clsSysPara4WebApi.js", "../../L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../L0_Entity/CourseLearning_Share/clscc_CourseEN.js", "../../L3_ForWApi/Knowledges_Share/clscc_CourseKnowledgesWApi.js", "../../L0_Entity/Knowledges_Share/clscc_CourseKnowledgesEN.js", "../../L3_ForWApi/BaseInfo_Share/clsQuestionnaireWApi.js", "../../L0_Entity/BaseInfo_Share/clsQuestionnaireEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.cc_KnowledgesExamLibRelaEx_FuncMap_QuestionName = exports.cc_KnowledgesExamLibRelaEx_FuncMap_KnowledgeName = exports.cc_KnowledgesExamLibRelaEx_FuncMap_CourseName = exports.cc_KnowledgesExamLibRelaEx_FilterFunByKey = exports.cc_KnowledgesExamLibRelaEx_FuncMapByFldName = exports.cc_KnowledgesExamLibRelaEx_SortFunByKey = exports.cc_KnowledgesExamLibRelaEx_GetObjExLstByPagerAsync = exports.cc_KnowledgesExamLibRelaEx_GetObjExLstByPager_Cache = exports.cc_KnowledgesExamLibRelaEx_CopyToEx = exports.cc_KnowledgesExamLibRelaEx_GetWebApiUrl = exports.cc_KnowledgesExamLibRelaEx_ConstructorName = exports.cc_KnowledgesExamLibRelaEx_Controller = void 0;
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clscc_KnowledgesExamLibRelaWApi_js_1 = require("../../L3_ForWApi/Knowledges_Share/clscc_KnowledgesExamLibRelaWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clscc_KnowledgesExamLibRelaEN_js_1 = require("../../L0_Entity/Knowledges_Share/clscc_KnowledgesExamLibRelaEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clscc_KnowledgesExamLibRelaENEx_js_1 = require("../../L0_Entity/Knowledges_Share/clscc_KnowledgesExamLibRelaENEx.js");
    const clscc_KnowledgesExamLibRelaWApi_js_2 = require("../../L3_ForWApi/Knowledges_Share/clscc_KnowledgesExamLibRelaWApi.js");
    const clscc_KnowledgesExamLibRelaWApi_js_3 = require("../../L3_ForWApi/Knowledges_Share/clscc_KnowledgesExamLibRelaWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clscc_KnowledgesExamLibRelaWApi_js_4 = require("../../L3_ForWApi/Knowledges_Share/clscc_KnowledgesExamLibRelaWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clscc_CourseWApi_js_1 = require("../../L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clscc_CourseEN_js_1 = require("../../L0_Entity/CourseLearning_Share/clscc_CourseEN.js");
    const clscc_CourseKnowledgesWApi_js_1 = require("../../L3_ForWApi/Knowledges_Share/clscc_CourseKnowledgesWApi.js");
    const clscc_CourseKnowledgesEN_js_1 = require("../../L0_Entity/Knowledges_Share/clscc_CourseKnowledgesEN.js");
    const clsQuestionnaireWApi_js_1 = require("../../L3_ForWApi/BaseInfo_Share/clsQuestionnaireWApi.js");
    const clsQuestionnaireEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsQuestionnaireEN.js");
    exports.cc_KnowledgesExamLibRelaEx_Controller = "cc_KnowledgesExamLibRelaExApi";
    exports.cc_KnowledgesExamLibRelaEx_ConstructorName = "cc_KnowledgesExamLibRelaEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function cc_KnowledgesExamLibRelaEx_GetWebApiUrl(strController, strAction) {
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
    exports.cc_KnowledgesExamLibRelaEx_GetWebApiUrl = cc_KnowledgesExamLibRelaEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objcc_KnowledgesExamLibRelaENS:源对象
    * @returns 目标对象=>clscc_KnowledgesExamLibRelaEN:objcc_KnowledgesExamLibRelaENT
    **/
    function cc_KnowledgesExamLibRelaEx_CopyToEx(objcc_KnowledgesExamLibRelaENS) {
        const strThisFuncName = cc_KnowledgesExamLibRelaEx_CopyToEx.name;
        const objcc_KnowledgesExamLibRelaENT = new clscc_KnowledgesExamLibRelaENEx_js_1.clscc_KnowledgesExamLibRelaENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_KnowledgesExamLibRelaENT, objcc_KnowledgesExamLibRelaENS);
            return objcc_KnowledgesExamLibRelaENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_KnowledgesExamLibRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objcc_KnowledgesExamLibRelaENT;
        }
    }
    exports.cc_KnowledgesExamLibRelaEx_CopyToEx = cc_KnowledgesExamLibRelaEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function cc_KnowledgesExamLibRelaEx_GetObjExLstByPager_Cache(objPagerPara, strCourseId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrcc_KnowledgesExamLibRelaObjLst = await (0, clscc_KnowledgesExamLibRelaWApi_js_1.cc_KnowledgesExamLibRela_GetObjLst_Cache)(strCourseId);
        const arrcc_KnowledgesExamLibRelaExObjLst = arrcc_KnowledgesExamLibRelaObjLst.map(cc_KnowledgesExamLibRelaEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrcc_KnowledgesExamLibRelaExObjLst) {
                const conFuncMap = await cc_KnowledgesExamLibRelaEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrcc_KnowledgesExamLibRelaExObjLst.length == 0)
            return arrcc_KnowledgesExamLibRelaExObjLst;
        let arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRelaExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objcc_KnowledgesExamLibRela_Cond = new clscc_KnowledgesExamLibRelaENEx_js_1.clscc_KnowledgesExamLibRelaENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_KnowledgesExamLibRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clscc_KnowledgesExamLibRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_KnowledgesExamLibRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrcc_KnowledgesExamLibRela_Sel.length == 0)
                return arrcc_KnowledgesExamLibRela_Sel;
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
                arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.sort(cc_KnowledgesExamLibRelaEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.sort(objPagerPara.sortFun);
            }
            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.slice(intStart, intEnd);
            return arrcc_KnowledgesExamLibRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.cc_KnowledgesExamLibRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_KnowledgesExamLibRelaEx_GetObjExLstByPager_Cache = cc_KnowledgesExamLibRelaEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function cc_KnowledgesExamLibRelaEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrcc_KnowledgesExamLibRelaObjLst = await (0, clscc_KnowledgesExamLibRelaWApi_js_2.cc_KnowledgesExamLibRela_GetObjLstAsync)(objPagerPara.whereCond);
        const arrcc_KnowledgesExamLibRelaExObjLst = arrcc_KnowledgesExamLibRelaObjLst.map(cc_KnowledgesExamLibRelaEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrcc_KnowledgesExamLibRelaExObjLst) {
                const conFuncMap = await cc_KnowledgesExamLibRelaEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrcc_KnowledgesExamLibRelaExObjLst.length == 0)
            return arrcc_KnowledgesExamLibRelaExObjLst;
        let arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRelaExObjLst;
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
                arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.sort(cc_KnowledgesExamLibRelaEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.sort(objPagerPara.sortFun);
            }
            arrcc_KnowledgesExamLibRela_Sel = arrcc_KnowledgesExamLibRela_Sel.slice(intStart, intEnd);
            return arrcc_KnowledgesExamLibRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.cc_KnowledgesExamLibRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_KnowledgesExamLibRelaEx_GetObjExLstByPagerAsync = cc_KnowledgesExamLibRelaEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_KnowledgesExamLibRelaEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clscc_KnowledgesExamLibRelaWApi_js_3.cc_KnowledgesExamLibRela_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clscc_KnowledgesExamLibRelaWApi_js_3.cc_KnowledgesExamLibRela_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.cc_KnowledgesExamLibRelaEx_SortFunByKey = cc_KnowledgesExamLibRelaEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:潘以锋
     * 日期:00-00-00
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function cc_KnowledgesExamLibRelaEx_FuncMapByFldName(strFldName, objcc_KnowledgesExamLibRelaEx) {
        const strThisFuncName = cc_KnowledgesExamLibRelaEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            case clscc_KnowledgesExamLibRelaENEx_js_1.clscc_KnowledgesExamLibRelaENEx.con_QuestionName:
                return cc_KnowledgesExamLibRelaEx_FuncMap_QuestionName(objcc_KnowledgesExamLibRelaEx);
            case clscc_KnowledgesExamLibRelaENEx_js_1.clscc_KnowledgesExamLibRelaENEx.con_KnowledgeName:
                return cc_KnowledgesExamLibRelaEx_FuncMap_KnowledgeName(objcc_KnowledgesExamLibRelaEx);
            case clscc_KnowledgesExamLibRelaENEx_js_1.clscc_KnowledgesExamLibRelaENEx.con_CourseName:
                return cc_KnowledgesExamLibRelaEx_FuncMap_CourseName(objcc_KnowledgesExamLibRelaEx);
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.cc_KnowledgesExamLibRelaEx_FuncMapByFldName = cc_KnowledgesExamLibRelaEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function cc_KnowledgesExamLibRelaEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clscc_KnowledgesExamLibRelaWApi_js_4.cc_KnowledgesExamLibRela_FilterFunByKey)(strKey, value);
        }
    }
    exports.cc_KnowledgesExamLibRelaEx_FilterFunByKey = cc_KnowledgesExamLibRelaEx_FilterFunByKey;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objcc_KnowledgesExamLibRelaS:源对象
    **/
    async function cc_KnowledgesExamLibRelaEx_FuncMap_CourseName(objcc_KnowledgesExamLibRela) {
        const strThisFuncName = cc_KnowledgesExamLibRelaEx_FuncMap_CourseName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_KnowledgesExamLibRela.courseName) == true) {
                const cc_Course_CourseId = objcc_KnowledgesExamLibRela.courseId;
                const cc_Course_CourseName = await (0, clscc_CourseWApi_js_1.cc_Course_func)(clscc_CourseEN_js_1.clscc_CourseEN.con_CourseId, clscc_CourseEN_js_1.clscc_CourseEN.con_CourseName, cc_Course_CourseId);
                objcc_KnowledgesExamLibRela.courseName = cc_Course_CourseName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000184)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_KnowledgesExamLibRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.cc_KnowledgesExamLibRelaEx_FuncMap_CourseName = cc_KnowledgesExamLibRelaEx_FuncMap_CourseName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objcc_KnowledgesExamLibRelaS:源对象
    **/
    async function cc_KnowledgesExamLibRelaEx_FuncMap_KnowledgeName(objcc_KnowledgesExamLibRela) {
        const strThisFuncName = cc_KnowledgesExamLibRelaEx_FuncMap_KnowledgeName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_KnowledgesExamLibRela.knowledgeName) == true) {
                const cc_CourseKnowledges_CourseKnowledgeId = objcc_KnowledgesExamLibRela.courseKnowledgeId;
                const cc_CourseKnowledges_KnowledgeName = await (0, clscc_CourseKnowledgesWApi_js_1.cc_CourseKnowledges_func)(clscc_CourseKnowledgesEN_js_1.clscc_CourseKnowledgesEN.con_CourseKnowledgeId, clscc_CourseKnowledgesEN_js_1.clscc_CourseKnowledgesEN.con_KnowledgeName, cc_CourseKnowledges_CourseKnowledgeId, objcc_KnowledgesExamLibRela.courseId);
                objcc_KnowledgesExamLibRela.knowledgeName = cc_CourseKnowledges_KnowledgeName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000189)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_KnowledgesExamLibRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.cc_KnowledgesExamLibRelaEx_FuncMap_KnowledgeName = cc_KnowledgesExamLibRelaEx_FuncMap_KnowledgeName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objcc_KnowledgesExamLibRelaS:源对象
    **/
    async function cc_KnowledgesExamLibRelaEx_FuncMap_QuestionName(objcc_KnowledgesExamLibRela) {
        const strThisFuncName = cc_KnowledgesExamLibRelaEx_FuncMap_QuestionName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_KnowledgesExamLibRela.questionName) == true) {
                const Questionnaire_QuestionID = objcc_KnowledgesExamLibRela.questionID;
                const Questionnaire_QuestionName = await (0, clsQuestionnaireWApi_js_1.Questionnaire_func)(clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionID, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionName, Questionnaire_QuestionID, objcc_KnowledgesExamLibRela.courseId);
                objcc_KnowledgesExamLibRela.questionName = Questionnaire_QuestionName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000191)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_KnowledgesExamLibRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.cc_KnowledgesExamLibRelaEx_FuncMap_QuestionName = cc_KnowledgesExamLibRelaEx_FuncMap_QuestionName;
});
