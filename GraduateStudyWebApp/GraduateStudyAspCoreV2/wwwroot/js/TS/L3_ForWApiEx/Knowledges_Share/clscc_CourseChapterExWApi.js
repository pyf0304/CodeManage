/**
* 类名:clscc_CourseChapterExWApi
* 表名:cc_CourseChapter(01120060)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/12 12:32:38
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:游戏化教育平台(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:知识点相关(Knowledges)
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/Knowledges_Share/clscc_CourseChapterEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/Knowledges_Share/clscc_CourseChapterENEx.js", "../../L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../L0_Entity/CourseLearning_Share/clscc_CourseEN.js", "../../L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../../L0_Entity/BaseInfo_Share/clsXzMajorEN.js", "../../L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/enumComparisonOp.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.cc_CourseChapterEx_BindDdl_CourseChapterIdInDiv_Cache = exports.cc_CourseChapterEx_FuncMapKey_MajorName = exports.cc_CourseChapterEx_FuncMapKey_CourseName = exports.cc_CourseChapterEx_FilterFunByKey = exports.cc_CourseChapterEx_FuncMapByFldName = exports.cc_CourseChapterEx_SortFunByKey = exports.cc_CourseChapterEx_FuncMap_MajorName = exports.cc_CourseChapterEx_FuncMap_CourseName = exports.cc_CourseChapterEx_GetObjExLstByPagerAsync = exports.cc_CourseChapterEx_GetObjExLstByPager_Cache = exports.cc_CourseChapterEx_CopyToEx = exports.cc_CourseChapterEx_GetWebApiUrl = exports.cc_CourseChapterEx_ConstructorName = exports.cc_CourseChapterEx_Controller = void 0;
    /**
    * 课程章节(cc_CourseChapter)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
   * Created by pyf on 2023年03月12日.
   * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clscc_CourseChapterWApi_js_1 = require("../../L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clscc_CourseChapterEN_js_1 = require("../../L0_Entity/Knowledges_Share/clscc_CourseChapterEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clscc_CourseChapterENEx_js_1 = require("../../L0_Entity/Knowledges_Share/clscc_CourseChapterENEx.js");
    const clscc_CourseChapterWApi_js_2 = require("../../L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseWApi_js_1 = require("../../L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clscc_CourseEN_js_1 = require("../../L0_Entity/CourseLearning_Share/clscc_CourseEN.js");
    const clsXzMajorWApi_js_1 = require("../../L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsXzMajorEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsXzMajorEN.js");
    const clscc_CourseChapterWApi_js_3 = require("../../L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clscc_CourseChapterWApi_js_4 = require("../../L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseWApi_js_2 = require("../../L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clsXzMajorWApi_js_2 = require("../../L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    exports.cc_CourseChapterEx_Controller = "cc_CourseChapterExApi";
    exports.cc_CourseChapterEx_ConstructorName = "cc_CourseChapterEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function cc_CourseChapterEx_GetWebApiUrl(strController, strAction) {
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
    exports.cc_CourseChapterEx_GetWebApiUrl = cc_CourseChapterEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objcc_CourseChapterENS:源对象
    * @returns 目标对象=>clscc_CourseChapterEN:objcc_CourseChapterENT
    **/
    function cc_CourseChapterEx_CopyToEx(objcc_CourseChapterENS) {
        const strThisFuncName = cc_CourseChapterEx_CopyToEx.name;
        const objcc_CourseChapterENT = new clscc_CourseChapterENEx_js_1.clscc_CourseChapterENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_CourseChapterENT, objcc_CourseChapterENS);
            return objcc_CourseChapterENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_CourseChapterEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objcc_CourseChapterENT;
        }
    }
    exports.cc_CourseChapterEx_CopyToEx = cc_CourseChapterEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function cc_CourseChapterEx_GetObjExLstByPager_Cache(objPagerPara, strCourseId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrcc_CourseChapterObjLst = await (0, clscc_CourseChapterWApi_js_1.cc_CourseChapter_GetObjLst_Cache)(strCourseId);
        const arrcc_CourseChapterExObjLst = arrcc_CourseChapterObjLst.map(cc_CourseChapterEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrcc_CourseChapterExObjLst) {
                const conFuncMap = await cc_CourseChapterEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrcc_CourseChapterExObjLst.length == 0)
            return arrcc_CourseChapterExObjLst;
        let arrcc_CourseChapter_Sel = arrcc_CourseChapterExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objcc_CourseChapter_Cond = new clscc_CourseChapterENEx_js_1.clscc_CourseChapterENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_CourseChapter_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clscc_CourseChapterWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_CourseChapter_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrcc_CourseChapter_Sel.length == 0)
                return arrcc_CourseChapter_Sel;
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
                arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.sort(cc_CourseChapterEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.sort(objPagerPara.sortFun);
            }
            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.slice(intStart, intEnd);
            return arrcc_CourseChapter_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.cc_CourseChapterEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_CourseChapterEx_GetObjExLstByPager_Cache = cc_CourseChapterEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function cc_CourseChapterEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrcc_CourseChapterObjLst = await (0, clscc_CourseChapterWApi_js_2.cc_CourseChapter_GetObjLstAsync)(objPagerPara.whereCond);
        const arrcc_CourseChapterExObjLst = arrcc_CourseChapterObjLst.map(cc_CourseChapterEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrcc_CourseChapterExObjLst) {
                const conFuncMap = await cc_CourseChapterEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrcc_CourseChapterExObjLst.length == 0)
            return arrcc_CourseChapterExObjLst;
        let arrcc_CourseChapter_Sel = arrcc_CourseChapterExObjLst;
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
                arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.sort(cc_CourseChapterEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.sort(objPagerPara.sortFun);
            }
            arrcc_CourseChapter_Sel = arrcc_CourseChapter_Sel.slice(intStart, intEnd);
            return arrcc_CourseChapter_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.cc_CourseChapterEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_CourseChapterEx_GetObjExLstByPagerAsync = cc_CourseChapterEx_GetObjExLstByPagerAsync;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objcc_CourseChapterS:源对象
    **/
    async function cc_CourseChapterEx_FuncMap_CourseName(objcc_CourseChapter) {
        const strThisFuncName = cc_CourseChapterEx_FuncMap_CourseName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_CourseChapter.courseName) == true) {
                const cc_Course_CourseId = objcc_CourseChapter.courseId;
                const cc_Course_CourseName = await (0, clscc_CourseWApi_js_1.cc_Course_func)(clscc_CourseEN_js_1.clscc_CourseEN.con_CourseId, clscc_CourseEN_js_1.clscc_CourseEN.con_CourseName, cc_Course_CourseId);
                objcc_CourseChapter.courseName = cc_Course_CourseName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000184)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_CourseChapterEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.cc_CourseChapterEx_FuncMap_CourseName = cc_CourseChapterEx_FuncMap_CourseName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objcc_CourseChapterS:源对象
    **/
    async function cc_CourseChapterEx_FuncMap_MajorName(objcc_CourseChapter) {
        const strThisFuncName = cc_CourseChapterEx_FuncMap_MajorName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_CourseChapter.majorName) == true) {
                const cc_Course_CourseId = objcc_CourseChapter.courseId;
                const cc_Course_id_XzMajor = await (0, clscc_CourseWApi_js_1.cc_Course_func)(clscc_CourseEN_js_1.clscc_CourseEN.con_CourseId, clscc_CourseEN_js_1.clscc_CourseEN.con_id_XzMajor, cc_Course_CourseId);
                const XzMajor_id_XzMajor = cc_Course_id_XzMajor;
                const XzMajor_MajorName = await (0, clsXzMajorWApi_js_1.XzMajor_func)(clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, XzMajor_id_XzMajor);
                objcc_CourseChapter.majorName = XzMajor_MajorName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000204)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_CourseChapterEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.cc_CourseChapterEx_FuncMap_MajorName = cc_CourseChapterEx_FuncMap_MajorName;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_CourseChapterEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clscc_CourseChapterENEx_js_1.clscc_CourseChapterENEx.con_QuestionNum:
                    return (a, b) => {
                        return a.questionNum - b.questionNum;
                    };
                case clscc_CourseChapterENEx_js_1.clscc_CourseChapterENEx.con_CourseName:
                    return (a, b) => {
                        return a.courseName.localeCompare(b.courseName);
                    };
                case clscc_CourseChapterENEx_js_1.clscc_CourseChapterENEx.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                default:
                    return (0, clscc_CourseChapterWApi_js_3.cc_CourseChapter_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                case clscc_CourseChapterENEx_js_1.clscc_CourseChapterENEx.con_QuestionNum:
                    return (a, b) => {
                        return b.questionNum - a.questionNum;
                    };
                case clscc_CourseChapterENEx_js_1.clscc_CourseChapterENEx.con_CourseName:
                    return (a, b) => {
                        return b.courseName.localeCompare(a.courseName);
                    };
                case clscc_CourseChapterENEx_js_1.clscc_CourseChapterENEx.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                default:
                    return (0, clscc_CourseChapterWApi_js_3.cc_CourseChapter_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.cc_CourseChapterEx_SortFunByKey = cc_CourseChapterEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function cc_CourseChapterEx_FuncMapByFldName(strFldName, objcc_CourseChapterEx) {
        const strThisFuncName = cc_CourseChapterEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            case clscc_CourseChapterENEx_js_1.clscc_CourseChapterENEx.con_CourseName:
                return cc_CourseChapterEx_FuncMap_CourseName(objcc_CourseChapterEx);
            case clscc_CourseChapterENEx_js_1.clscc_CourseChapterENEx.con_MajorName:
                return cc_CourseChapterEx_FuncMap_MajorName(objcc_CourseChapterEx);
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.cc_CourseChapterEx_FuncMapByFldName = cc_CourseChapterEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-12
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function cc_CourseChapterEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clscc_CourseChapterENEx_js_1.clscc_CourseChapterENEx.con_QuestionNum:
                return (obj) => {
                    return obj.questionNum === value;
                };
            case clscc_CourseChapterENEx_js_1.clscc_CourseChapterENEx.con_CourseName:
                return (obj) => {
                    return obj.courseName === value;
                };
            case clscc_CourseChapterENEx_js_1.clscc_CourseChapterENEx.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            default:
                return (0, clscc_CourseChapterWApi_js_4.cc_CourseChapter_FilterFunByKey)(strKey, value);
        }
    }
    exports.cc_CourseChapterEx_FilterFunByKey = cc_CourseChapterEx_FilterFunByKey;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapKey)
    * @param objcc_CourseChapterS:源对象
    **/
    async function cc_CourseChapterEx_FuncMapKey_CourseName(objcc_CourseChapter) {
        const strThisFuncName = cc_CourseChapterEx_FuncMapKey_CourseName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_CourseChapter.courseName) == true)
                return [];
            const cc_Course_CourseName = objcc_CourseChapter.courseName;
            const arrCourseId = await (0, clscc_CourseWApi_js_2.cc_Course_funcKey)(clscc_CourseEN_js_1.clscc_CourseEN.con_CourseName, cc_Course_CourseName, enumComparisonOp_js_1.enumComparisonOp.Like_03);
            return arrCourseId;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000184)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_CourseChapterEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_CourseChapterEx_FuncMapKey_CourseName = cc_CourseChapterEx_FuncMapKey_CourseName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapKey)
    * @param objcc_CourseChapterS:源对象
    **/
    async function cc_CourseChapterEx_FuncMapKey_MajorName(objcc_CourseChapter) {
        const strThisFuncName = cc_CourseChapterEx_FuncMapKey_MajorName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_CourseChapter.majorName) == true)
                return [];
            const XzMajor_MajorName = objcc_CourseChapter.majorName;
            const arrid_XzMajor = await (0, clsXzMajorWApi_js_2.XzMajor_funcKey)(clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, XzMajor_MajorName, enumComparisonOp_js_1.enumComparisonOp.Like_03);
            const strid_XzMajorLst = arrid_XzMajor;
            const arrCourseId = await (0, clscc_CourseWApi_js_2.cc_Course_funcKey)(clscc_CourseEN_js_1.clscc_CourseEN.con_id_XzMajor, strid_XzMajorLst, enumComparisonOp_js_1.enumComparisonOp.In_04);
            return arrCourseId;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000204)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_CourseChapterEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_CourseChapterEx_FuncMapKey_MajorName = cc_CourseChapterEx_FuncMapKey_MajorName;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
     * @param strCourseId:课程Id
    */
    async function cc_CourseChapterEx_BindDdl_CourseChapterIdInDiv_Cache(strDivName, strDdlName, strCourseId) {
        const strThisFuncName = "BindDdl_CourseChapterIdInDiv_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId]不能为空！(In clscc_CourseChapterWApi.BindDdl_CourseChapterIdInDiv)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clscc_CourseChapterWApi.BindDdl_CourseChapterIdInDiv)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_CourseChapterIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_CourseChapterIdInDiv_Cache");
        let arrObjLst_Sel = await (0, clscc_CourseChapterWApi_js_1.cc_CourseChapter_GetObjLst_Cache)(strCourseId);
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterId, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName, "课程章节");
    }
    exports.cc_CourseChapterEx_BindDdl_CourseChapterIdInDiv_Cache = cc_CourseChapterEx_BindDdl_CourseChapterIdInDiv_Cache;
});
