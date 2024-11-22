/**
* 类名:clscc_CourseExWApi
* 表名:cc_Course(01120056)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/14 00:22:47
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:游戏化教育平台(变量首字母小写)-全部函数集
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/CourseLearning_Share/clscc_CourseEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/CourseLearning_Share/clscc_CourseENEx.js", "../../L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../L3_ForWApi/SystemSet_Share/clsXzSchoolWApi.js", "../../L0_Entity/SystemSet_Share/clsXzSchoolEN.js", "../../L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../../L0_Entity/BaseInfo_Share/clsXzMajorEN.js", "../../L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js", "../../L0_Entity/BaseInfo_Share/clsXzClgEN.js", "../../L3_ForWApi/CourseLearning/clscc_ExcellentTypeWApi.js", "../../L0_Entity/CourseLearning/clscc_ExcellentTypeEN.js", "../../L3_ForWApi/CourseLearning_Share/clscc_CourseTypeWApi.js", "../../L0_Entity/CourseLearning_Share/clscc_CourseTypeEN.js", "../../L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../L3_ForWApi/SystemSet_Share/clsXzSchoolWApi.js", "../../L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../../L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js", "../../L3_ForWApi/CourseLearning/clscc_ExcellentTypeWApi.js", "../../L3_ForWApi/CourseLearning_Share/clscc_CourseTypeWApi.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/enumComparisonOp.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.cc_CourseEx_FuncMapKey_CourseTypeName = exports.cc_CourseEx_FuncMapKey_ExcellentTypeName = exports.cc_CourseEx_FuncMapKey_CollegeName = exports.cc_CourseEx_FuncMapKey_MajorName = exports.cc_CourseEx_FuncMapKey_SchoolName = exports.cc_CourseEx_FilterFunByKey = exports.cc_CourseEx_FuncMapByFldName = exports.cc_CourseEx_SortFunByKey = exports.cc_CourseEx_FuncMap_CourseTypeName = exports.cc_CourseEx_FuncMap_ExcellentTypeName = exports.cc_CourseEx_FuncMap_CollegeName = exports.cc_CourseEx_FuncMap_MajorName = exports.cc_CourseEx_FuncMap_SchoolName = exports.cc_CourseEx_GetObjExLstByPagerAsync = exports.cc_CourseEx_GetObjExLstByPager_Cache = exports.cc_CourseEx_CopyToEx = exports.cc_CourseEx_GetWebApiUrl = exports.cc_CourseEx_ConstructorName = exports.cc_CourseEx_Controller = void 0;
    /**
    * 课程(cc_Course)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
    * Created by pyf on 2023年03月14日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clscc_CourseWApi_js_1 = require("../../L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clscc_CourseEN_js_1 = require("../../L0_Entity/CourseLearning_Share/clscc_CourseEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clscc_CourseENEx_js_1 = require("../../L0_Entity/CourseLearning_Share/clscc_CourseENEx.js");
    const clscc_CourseWApi_js_2 = require("../../L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clsXzSchoolWApi_js_1 = require("../../L3_ForWApi/SystemSet_Share/clsXzSchoolWApi.js");
    const clsXzSchoolEN_js_1 = require("../../L0_Entity/SystemSet_Share/clsXzSchoolEN.js");
    const clsXzMajorWApi_js_1 = require("../../L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsXzMajorEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsXzMajorEN.js");
    const clsXzClgWApi_js_1 = require("../../L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js");
    const clsXzClgEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsXzClgEN.js");
    const clscc_ExcellentTypeWApi_js_1 = require("../../L3_ForWApi/CourseLearning/clscc_ExcellentTypeWApi.js");
    const clscc_ExcellentTypeEN_js_1 = require("../../L0_Entity/CourseLearning/clscc_ExcellentTypeEN.js");
    const clscc_CourseTypeWApi_js_1 = require("../../L3_ForWApi/CourseLearning_Share/clscc_CourseTypeWApi.js");
    const clscc_CourseTypeEN_js_1 = require("../../L0_Entity/CourseLearning_Share/clscc_CourseTypeEN.js");
    const clscc_CourseWApi_js_3 = require("../../L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clscc_CourseWApi_js_4 = require("../../L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clsXzSchoolWApi_js_2 = require("../../L3_ForWApi/SystemSet_Share/clsXzSchoolWApi.js");
    const clsXzMajorWApi_js_2 = require("../../L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsXzClgWApi_js_2 = require("../../L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js");
    const clscc_ExcellentTypeWApi_js_2 = require("../../L3_ForWApi/CourseLearning/clscc_ExcellentTypeWApi.js");
    const clscc_CourseTypeWApi_js_2 = require("../../L3_ForWApi/CourseLearning_Share/clscc_CourseTypeWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    exports.cc_CourseEx_Controller = "cc_CourseExApi";
    exports.cc_CourseEx_ConstructorName = "cc_CourseEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function cc_CourseEx_GetWebApiUrl(strController, strAction) {
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
    exports.cc_CourseEx_GetWebApiUrl = cc_CourseEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objcc_CourseENS:源对象
    * @returns 目标对象=>clscc_CourseEN:objcc_CourseENT
    **/
    function cc_CourseEx_CopyToEx(objcc_CourseENS) {
        const strThisFuncName = cc_CourseEx_CopyToEx.name;
        const objcc_CourseENT = new clscc_CourseENEx_js_1.clscc_CourseENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_CourseENT, objcc_CourseENS);
            return objcc_CourseENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_CourseEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objcc_CourseENT;
        }
    }
    exports.cc_CourseEx_CopyToEx = cc_CourseEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function cc_CourseEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrcc_CourseObjLst = await (0, clscc_CourseWApi_js_1.cc_Course_GetObjLst_Cache)();
        const arrcc_CourseExObjLst = arrcc_CourseObjLst.map(cc_CourseEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrcc_CourseExObjLst) {
                const conFuncMap = await cc_CourseEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrcc_CourseExObjLst.length == 0)
            return arrcc_CourseExObjLst;
        let arrcc_Course_Sel = arrcc_CourseExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objcc_Course_Cond = new clscc_CourseENEx_js_1.clscc_CourseENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_Course_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clscc_CourseWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_Course_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_Course_Sel = arrcc_Course_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrcc_Course_Sel.length == 0)
                return arrcc_Course_Sel;
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
                arrcc_Course_Sel = arrcc_Course_Sel.sort(cc_CourseEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrcc_Course_Sel = arrcc_Course_Sel.sort(objPagerPara.sortFun);
            }
            arrcc_Course_Sel = arrcc_Course_Sel.slice(intStart, intEnd);
            return arrcc_Course_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.cc_CourseEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_CourseEx_GetObjExLstByPager_Cache = cc_CourseEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function cc_CourseEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrcc_CourseObjLst = await (0, clscc_CourseWApi_js_2.cc_Course_GetObjLstAsync)(objPagerPara.whereCond);
        const arrcc_CourseExObjLst = arrcc_CourseObjLst.map(cc_CourseEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrcc_CourseExObjLst) {
                const conFuncMap = await cc_CourseEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrcc_CourseExObjLst.length == 0)
            return arrcc_CourseExObjLst;
        let arrcc_Course_Sel = arrcc_CourseExObjLst;
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
                arrcc_Course_Sel = arrcc_Course_Sel.sort(cc_CourseEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrcc_Course_Sel = arrcc_Course_Sel.sort(objPagerPara.sortFun);
            }
            arrcc_Course_Sel = arrcc_Course_Sel.slice(intStart, intEnd);
            return arrcc_Course_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.cc_CourseEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_CourseEx_GetObjExLstByPagerAsync = cc_CourseEx_GetObjExLstByPagerAsync;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objcc_CourseS:源对象
    **/
    async function cc_CourseEx_FuncMap_SchoolName(objcc_Course) {
        const strThisFuncName = cc_CourseEx_FuncMap_SchoolName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_Course.schoolName) == true) {
                const XzSchool_id_School = objcc_Course.id_School;
                const XzSchool_SchoolName = await (0, clsXzSchoolWApi_js_1.XzSchool_func)(clsXzSchoolEN_js_1.clsXzSchoolEN.con_id_School, clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolName, XzSchool_id_School);
                objcc_Course.schoolName = XzSchool_SchoolName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000222)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_CourseEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.cc_CourseEx_FuncMap_SchoolName = cc_CourseEx_FuncMap_SchoolName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objcc_CourseS:源对象
    **/
    async function cc_CourseEx_FuncMap_MajorName(objcc_Course) {
        const strThisFuncName = cc_CourseEx_FuncMap_MajorName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_Course.majorName) == true) {
                const XzMajor_id_XzMajor = objcc_Course.id_XzMajor;
                const XzMajor_MajorName = await (0, clsXzMajorWApi_js_1.XzMajor_func)(clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, XzMajor_id_XzMajor);
                objcc_Course.majorName = XzMajor_MajorName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000204)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_CourseEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.cc_CourseEx_FuncMap_MajorName = cc_CourseEx_FuncMap_MajorName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objcc_CourseS:源对象
    **/
    async function cc_CourseEx_FuncMap_CollegeName(objcc_Course) {
        const strThisFuncName = cc_CourseEx_FuncMap_CollegeName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_Course.collegeName) == true) {
                const XzClg_id_XzCollege = objcc_Course.id_XzCollege;
                const XzClg_CollegeName = await (0, clsXzClgWApi_js_1.XzClg_func)(clsXzClgEN_js_1.clsXzClgEN.con_id_XzCollege, clsXzClgEN_js_1.clsXzClgEN.con_CollegeName, XzClg_id_XzCollege);
                objcc_Course.collegeName = XzClg_CollegeName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000214)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_CourseEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.cc_CourseEx_FuncMap_CollegeName = cc_CourseEx_FuncMap_CollegeName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objcc_CourseS:源对象
    **/
    async function cc_CourseEx_FuncMap_ExcellentTypeName(objcc_Course) {
        const strThisFuncName = cc_CourseEx_FuncMap_ExcellentTypeName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_Course.excellentTypeName) == true) {
                const cc_ExcellentType_ExcellentTypeId = objcc_Course.excellentTypeId;
                const cc_ExcellentType_ExcellentTypeName = await (0, clscc_ExcellentTypeWApi_js_1.cc_ExcellentType_func)(clscc_ExcellentTypeEN_js_1.clscc_ExcellentTypeEN.con_ExcellentTypeId, clscc_ExcellentTypeEN_js_1.clscc_ExcellentTypeEN.con_ExcellentTypeName, cc_ExcellentType_ExcellentTypeId);
                objcc_Course.excellentTypeName = cc_ExcellentType_ExcellentTypeName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000223)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_CourseEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.cc_CourseEx_FuncMap_ExcellentTypeName = cc_CourseEx_FuncMap_ExcellentTypeName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objcc_CourseS:源对象
    **/
    async function cc_CourseEx_FuncMap_CourseTypeName(objcc_Course) {
        const strThisFuncName = cc_CourseEx_FuncMap_CourseTypeName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_Course.courseTypeName) == true) {
                const cc_CourseType_CourseTypeID = objcc_Course.courseTypeID;
                const cc_CourseType_CourseTypeName = await (0, clscc_CourseTypeWApi_js_1.cc_CourseType_func)(clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeID, clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeName, cc_CourseType_CourseTypeID);
                objcc_Course.courseTypeName = cc_CourseType_CourseTypeName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000224)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_CourseEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.cc_CourseEx_FuncMap_CourseTypeName = cc_CourseEx_FuncMap_CourseTypeName;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_CourseEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clscc_CourseENEx_js_1.clscc_CourseENEx.con_SchoolName:
                    return (a, b) => {
                        return a.schoolName.localeCompare(b.schoolName);
                    };
                case clscc_CourseENEx_js_1.clscc_CourseENEx.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clscc_CourseENEx_js_1.clscc_CourseENEx.con_CollegeName:
                    return (a, b) => {
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clscc_CourseENEx_js_1.clscc_CourseENEx.con_ExcellentTypeName:
                    return (a, b) => {
                        return a.excellentTypeName.localeCompare(b.excellentTypeName);
                    };
                case clscc_CourseENEx_js_1.clscc_CourseENEx.con_CourseTypeName:
                    return (a, b) => {
                        return a.courseTypeName.localeCompare(b.courseTypeName);
                    };
                default:
                    return (0, clscc_CourseWApi_js_3.cc_Course_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                case clscc_CourseENEx_js_1.clscc_CourseENEx.con_SchoolName:
                    return (a, b) => {
                        return b.schoolName.localeCompare(a.schoolName);
                    };
                case clscc_CourseENEx_js_1.clscc_CourseENEx.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clscc_CourseENEx_js_1.clscc_CourseENEx.con_CollegeName:
                    return (a, b) => {
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clscc_CourseENEx_js_1.clscc_CourseENEx.con_ExcellentTypeName:
                    return (a, b) => {
                        return b.excellentTypeName.localeCompare(a.excellentTypeName);
                    };
                case clscc_CourseENEx_js_1.clscc_CourseENEx.con_CourseTypeName:
                    return (a, b) => {
                        return b.courseTypeName.localeCompare(a.courseTypeName);
                    };
                default:
                    return (0, clscc_CourseWApi_js_3.cc_Course_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.cc_CourseEx_SortFunByKey = cc_CourseEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function cc_CourseEx_FuncMapByFldName(strFldName, objcc_CourseEx) {
        const strThisFuncName = cc_CourseEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clscc_CourseEN_js_1.clscc_CourseEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            case clscc_CourseENEx_js_1.clscc_CourseENEx.con_SchoolName:
                return cc_CourseEx_FuncMap_SchoolName(objcc_CourseEx);
            case clscc_CourseENEx_js_1.clscc_CourseENEx.con_MajorName:
                return cc_CourseEx_FuncMap_MajorName(objcc_CourseEx);
            case clscc_CourseENEx_js_1.clscc_CourseENEx.con_CollegeName:
                return cc_CourseEx_FuncMap_CollegeName(objcc_CourseEx);
            case clscc_CourseENEx_js_1.clscc_CourseENEx.con_ExcellentTypeName:
                return cc_CourseEx_FuncMap_ExcellentTypeName(objcc_CourseEx);
            case clscc_CourseENEx_js_1.clscc_CourseENEx.con_CourseTypeName:
                return cc_CourseEx_FuncMap_CourseTypeName(objcc_CourseEx);
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.cc_CourseEx_FuncMapByFldName = cc_CourseEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function cc_CourseEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clscc_CourseENEx_js_1.clscc_CourseENEx.con_SchoolName:
                return (obj) => {
                    return obj.schoolName === value;
                };
            case clscc_CourseENEx_js_1.clscc_CourseENEx.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clscc_CourseENEx_js_1.clscc_CourseENEx.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clscc_CourseENEx_js_1.clscc_CourseENEx.con_ExcellentTypeName:
                return (obj) => {
                    return obj.excellentTypeName === value;
                };
            case clscc_CourseENEx_js_1.clscc_CourseENEx.con_CourseTypeName:
                return (obj) => {
                    return obj.courseTypeName === value;
                };
            default:
                return (0, clscc_CourseWApi_js_4.cc_Course_FilterFunByKey)(strKey, value);
        }
    }
    exports.cc_CourseEx_FilterFunByKey = cc_CourseEx_FilterFunByKey;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapKey)
    * @param objcc_CourseS:源对象
    **/
    async function cc_CourseEx_FuncMapKey_SchoolName(objcc_Course) {
        const strThisFuncName = cc_CourseEx_FuncMapKey_SchoolName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_Course.schoolName) == true)
                return [];
            const XzSchool_SchoolName = objcc_Course.schoolName;
            const arrid_School = await (0, clsXzSchoolWApi_js_2.XzSchool_funcKey)(clsXzSchoolEN_js_1.clsXzSchoolEN.con_SchoolName, XzSchool_SchoolName, enumComparisonOp_js_1.enumComparisonOp.Like_03);
            return arrid_School;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000222)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_CourseEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_CourseEx_FuncMapKey_SchoolName = cc_CourseEx_FuncMapKey_SchoolName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapKey)
    * @param objcc_CourseS:源对象
    **/
    async function cc_CourseEx_FuncMapKey_MajorName(objcc_Course) {
        const strThisFuncName = cc_CourseEx_FuncMapKey_MajorName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_Course.majorName) == true)
                return [];
            const XzMajor_MajorName = objcc_Course.majorName;
            const arrid_XzMajor = await (0, clsXzMajorWApi_js_2.XzMajor_funcKey)(clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, XzMajor_MajorName, enumComparisonOp_js_1.enumComparisonOp.Like_03);
            return arrid_XzMajor;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000204)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_CourseEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_CourseEx_FuncMapKey_MajorName = cc_CourseEx_FuncMapKey_MajorName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapKey)
    * @param objcc_CourseS:源对象
    **/
    async function cc_CourseEx_FuncMapKey_CollegeName(objcc_Course) {
        const strThisFuncName = cc_CourseEx_FuncMapKey_CollegeName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_Course.collegeName) == true)
                return [];
            const XzClg_CollegeName = objcc_Course.collegeName;
            const arrid_XzCollege = await (0, clsXzClgWApi_js_2.XzClg_funcKey)(clsXzClgEN_js_1.clsXzClgEN.con_CollegeName, XzClg_CollegeName, enumComparisonOp_js_1.enumComparisonOp.Like_03);
            return arrid_XzCollege;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000214)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_CourseEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_CourseEx_FuncMapKey_CollegeName = cc_CourseEx_FuncMapKey_CollegeName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapKey)
    * @param objcc_CourseS:源对象
    **/
    async function cc_CourseEx_FuncMapKey_ExcellentTypeName(objcc_Course) {
        const strThisFuncName = cc_CourseEx_FuncMapKey_ExcellentTypeName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_Course.excellentTypeName) == true)
                return [];
            const cc_ExcellentType_ExcellentTypeName = objcc_Course.excellentTypeName;
            const arrExcellentTypeId = await (0, clscc_ExcellentTypeWApi_js_2.cc_ExcellentType_funcKey)(clscc_ExcellentTypeEN_js_1.clscc_ExcellentTypeEN.con_ExcellentTypeName, cc_ExcellentType_ExcellentTypeName, enumComparisonOp_js_1.enumComparisonOp.Like_03);
            return arrExcellentTypeId;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000223)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_CourseEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_CourseEx_FuncMapKey_ExcellentTypeName = cc_CourseEx_FuncMapKey_ExcellentTypeName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapKey)
    * @param objcc_CourseS:源对象
    **/
    async function cc_CourseEx_FuncMapKey_CourseTypeName(objcc_Course) {
        const strThisFuncName = cc_CourseEx_FuncMapKey_CourseTypeName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objcc_Course.courseTypeName) == true)
                return [];
            const cc_CourseType_CourseTypeName = objcc_Course.courseTypeName;
            const arrCourseTypeID = await (0, clscc_CourseTypeWApi_js_2.cc_CourseType_funcKey)(clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeName, cc_CourseType_CourseTypeName, enumComparisonOp_js_1.enumComparisonOp.Like_03);
            return arrCourseTypeID;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000224)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.cc_CourseEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_CourseEx_FuncMapKey_CourseTypeName = cc_CourseEx_FuncMapKey_CourseTypeName;
});
