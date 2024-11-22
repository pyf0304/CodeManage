/**
* 类名:clsQuestionnaireExWApi
* 表名:Questionnaire(01120001)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/14 18:38:11
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:基本信息(BaseInfo)
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/BaseInfo_Share/clsQuestionnaireWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/BaseInfo_Share/clsQuestionnaireEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/BaseInfo_Share/clsQuestionnaireENEx.js", "../../L3_ForWApi/BaseInfo_Share/clsQuestionnaireWApi.js", "../../L3_ForWApi/SystemSet_Share/clsQuestionTypeWApi.js", "../../L0_Entity/SystemSet_Share/clsQuestionTypeEN.js", "../../L3_ForWApi/SystemSet_Share/clsge_DifficultyLevelWApi.js", "../../L0_Entity/SystemSet_Share/clsge_DifficultyLevelEN.js", "../../L3_ForWApi/CourseManage_Share/clsvcc_Course_SimWApi.js", "../../L0_Entity/CourseManage_Share/clsvcc_Course_SimEN.js", "../../L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../L0_Entity/Knowledges_Share/clscc_CourseChapterEN.js", "../../L3_ForWApi/Knowledges_Share/clsge_LevelModeTypeWApi.js", "../../L0_Entity/Knowledges_Share/clsge_LevelModeTypeEN.js", "../../L3_ForWApi/BaseInfo_Share/clsQuestionnaireWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/BaseInfo_Share/clsQuestionnaireWApi.js", "../../L3_ForWApi/SystemSet_Share/clsQuestionTypeWApi.js", "../../L3_ForWApi/SystemSet_Share/clsge_DifficultyLevelWApi.js", "../../L3_ForWApi/CourseManage_Share/clsvcc_Course_SimWApi.js", "../../L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../L3_ForWApi/Knowledges_Share/clsge_LevelModeTypeWApi.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/enumComparisonOp.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.QuestionnaireEx_FuncMapKey_LevelModeTypeName = exports.QuestionnaireEx_FuncMapKey_ChapterName = exports.QuestionnaireEx_FuncMapKey_CourseName = exports.QuestionnaireEx_FuncMapKey_DifficultyLevelName = exports.QuestionnaireEx_FuncMapKey_QuestionTypeName = exports.QuestionnaireEx_FilterFunByKey = exports.QuestionnaireEx_FuncMapByFldName = exports.QuestionnaireEx_SortFunByKey = exports.QuestionnaireEx_FuncMap_LevelModeTypeName = exports.QuestionnaireEx_FuncMap_ChapterName = exports.QuestionnaireEx_FuncMap_CourseName = exports.QuestionnaireEx_FuncMap_DifficultyLevelName = exports.QuestionnaireEx_FuncMap_QuestionTypeName = exports.QuestionnaireEx_GetObjExLstByPagerAsync = exports.QuestionnaireEx_GetObjExLstByPager_Cache = exports.QuestionnaireEx_CopyToEx = exports.QuestionnaireEx_GetWebApiUrl = exports.questionnaireEx_ConstructorName = exports.questionnaireEx_Controller = void 0;
    /**
    * 题目(Questionnaire)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
    * Created by pyf on 2023年03月14日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsQuestionnaireWApi_js_1 = require("../../L3_ForWApi/BaseInfo_Share/clsQuestionnaireWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsQuestionnaireEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsQuestionnaireEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clsQuestionnaireENEx_js_1 = require("../../L0_Entity/BaseInfo_Share/clsQuestionnaireENEx.js");
    const clsQuestionnaireWApi_js_2 = require("../../L3_ForWApi/BaseInfo_Share/clsQuestionnaireWApi.js");
    const clsQuestionTypeWApi_js_1 = require("../../L3_ForWApi/SystemSet_Share/clsQuestionTypeWApi.js");
    const clsQuestionTypeEN_js_1 = require("../../L0_Entity/SystemSet_Share/clsQuestionTypeEN.js");
    const clsge_DifficultyLevelWApi_js_1 = require("../../L3_ForWApi/SystemSet_Share/clsge_DifficultyLevelWApi.js");
    const clsge_DifficultyLevelEN_js_1 = require("../../L0_Entity/SystemSet_Share/clsge_DifficultyLevelEN.js");
    const clsvcc_Course_SimWApi_js_1 = require("../../L3_ForWApi/CourseManage_Share/clsvcc_Course_SimWApi.js");
    const clsvcc_Course_SimEN_js_1 = require("../../L0_Entity/CourseManage_Share/clsvcc_Course_SimEN.js");
    const clscc_CourseChapterWApi_js_1 = require("../../L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterEN_js_1 = require("../../L0_Entity/Knowledges_Share/clscc_CourseChapterEN.js");
    const clsge_LevelModeTypeWApi_js_1 = require("../../L3_ForWApi/Knowledges_Share/clsge_LevelModeTypeWApi.js");
    const clsge_LevelModeTypeEN_js_1 = require("../../L0_Entity/Knowledges_Share/clsge_LevelModeTypeEN.js");
    const clsQuestionnaireWApi_js_3 = require("../../L3_ForWApi/BaseInfo_Share/clsQuestionnaireWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsQuestionnaireWApi_js_4 = require("../../L3_ForWApi/BaseInfo_Share/clsQuestionnaireWApi.js");
    const clsQuestionTypeWApi_js_2 = require("../../L3_ForWApi/SystemSet_Share/clsQuestionTypeWApi.js");
    const clsge_DifficultyLevelWApi_js_2 = require("../../L3_ForWApi/SystemSet_Share/clsge_DifficultyLevelWApi.js");
    const clsvcc_Course_SimWApi_js_2 = require("../../L3_ForWApi/CourseManage_Share/clsvcc_Course_SimWApi.js");
    const clscc_CourseChapterWApi_js_2 = require("../../L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clsge_LevelModeTypeWApi_js_2 = require("../../L3_ForWApi/Knowledges_Share/clsge_LevelModeTypeWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    exports.questionnaireEx_Controller = "QuestionnaireExApi";
    exports.questionnaireEx_ConstructorName = "questionnaireEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function QuestionnaireEx_GetWebApiUrl(strController, strAction) {
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
    exports.QuestionnaireEx_GetWebApiUrl = QuestionnaireEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objQuestionnaireENS:源对象
    * @returns 目标对象=>clsQuestionnaireEN:objQuestionnaireENT
    **/
    function QuestionnaireEx_CopyToEx(objQuestionnaireENS) {
        const strThisFuncName = QuestionnaireEx_CopyToEx.name;
        const objQuestionnaireENT = new clsQuestionnaireENEx_js_1.clsQuestionnaireENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objQuestionnaireENT, objQuestionnaireENS);
            return objQuestionnaireENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.questionnaireEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objQuestionnaireENT;
        }
    }
    exports.QuestionnaireEx_CopyToEx = QuestionnaireEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function QuestionnaireEx_GetObjExLstByPager_Cache(objPagerPara, strCourseId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrQuestionnaireObjLst = await (0, clsQuestionnaireWApi_js_1.Questionnaire_GetObjLst_Cache)(strCourseId);
        const arrQuestionnaireExObjLst = arrQuestionnaireObjLst.map(QuestionnaireEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrQuestionnaireExObjLst) {
                const conFuncMap = await QuestionnaireEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrQuestionnaireExObjLst.length == 0)
            return arrQuestionnaireExObjLst;
        let arrQuestionnaire_Sel = arrQuestionnaireExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objQuestionnaire_Cond = new clsQuestionnaireENEx_js_1.clsQuestionnaireENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objQuestionnaire_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsQuestionnaireWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQuestionnaire_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrQuestionnaire_Sel.length == 0)
                return arrQuestionnaire_Sel;
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
                arrQuestionnaire_Sel = arrQuestionnaire_Sel.sort(QuestionnaireEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrQuestionnaire_Sel = arrQuestionnaire_Sel.sort(objPagerPara.sortFun);
            }
            arrQuestionnaire_Sel = arrQuestionnaire_Sel.slice(intStart, intEnd);
            return arrQuestionnaire_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.questionnaireEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.QuestionnaireEx_GetObjExLstByPager_Cache = QuestionnaireEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function QuestionnaireEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrQuestionnaireObjLst = await (0, clsQuestionnaireWApi_js_2.Questionnaire_GetObjLstAsync)(objPagerPara.whereCond);
        const arrQuestionnaireExObjLst = arrQuestionnaireObjLst.map(QuestionnaireEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrQuestionnaireExObjLst) {
                const conFuncMap = await QuestionnaireEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrQuestionnaireExObjLst.length == 0)
            return arrQuestionnaireExObjLst;
        let arrQuestionnaire_Sel = arrQuestionnaireExObjLst;
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
                arrQuestionnaire_Sel = arrQuestionnaire_Sel.sort(QuestionnaireEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrQuestionnaire_Sel = arrQuestionnaire_Sel.sort(objPagerPara.sortFun);
            }
            arrQuestionnaire_Sel = arrQuestionnaire_Sel.slice(intStart, intEnd);
            return arrQuestionnaire_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.questionnaireEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.QuestionnaireEx_GetObjExLstByPagerAsync = QuestionnaireEx_GetObjExLstByPagerAsync;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objQuestionnaireS:源对象
    **/
    async function QuestionnaireEx_FuncMap_QuestionTypeName(objQuestionnaire) {
        const strThisFuncName = QuestionnaireEx_FuncMap_QuestionTypeName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objQuestionnaire.questionTypeName) == true) {
                const QuestionType_QuestionTypeId = objQuestionnaire.questionTypeId;
                const QuestionType_QuestionTypeName = await (0, clsQuestionTypeWApi_js_1.QuestionType_func)(clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeId, clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeName, QuestionType_QuestionTypeId);
                objQuestionnaire.questionTypeName = QuestionType_QuestionTypeName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000219)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.questionnaireEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.QuestionnaireEx_FuncMap_QuestionTypeName = QuestionnaireEx_FuncMap_QuestionTypeName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objQuestionnaireS:源对象
    **/
    async function QuestionnaireEx_FuncMap_DifficultyLevelName(objQuestionnaire) {
        const strThisFuncName = QuestionnaireEx_FuncMap_DifficultyLevelName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objQuestionnaire.difficultyLevelName) == true) {
                const ge_DifficultyLevel_DifficultyLevelId = objQuestionnaire.difficultyLevelId;
                const ge_DifficultyLevel_DifficultyLevelName = await (0, clsge_DifficultyLevelWApi_js_1.ge_DifficultyLevel_func)(clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelId, clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelName, ge_DifficultyLevel_DifficultyLevelId);
                objQuestionnaire.difficultyLevelName = ge_DifficultyLevel_DifficultyLevelName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000218)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.questionnaireEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.QuestionnaireEx_FuncMap_DifficultyLevelName = QuestionnaireEx_FuncMap_DifficultyLevelName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objQuestionnaireS:源对象
    **/
    async function QuestionnaireEx_FuncMap_CourseName(objQuestionnaire) {
        const strThisFuncName = QuestionnaireEx_FuncMap_CourseName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objQuestionnaire.courseName) == true) {
                const vcc_Course_Sim_CourseId = objQuestionnaire.courseId;
                const vcc_Course_Sim_CourseName = await (0, clsvcc_Course_SimWApi_js_1.vcc_Course_Sim_func)(clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseId, clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseName, vcc_Course_Sim_CourseId);
                objQuestionnaire.courseName = vcc_Course_Sim_CourseName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000184)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.questionnaireEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.QuestionnaireEx_FuncMap_CourseName = QuestionnaireEx_FuncMap_CourseName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objQuestionnaireS:源对象
    **/
    async function QuestionnaireEx_FuncMap_ChapterName(objQuestionnaire) {
        const strThisFuncName = QuestionnaireEx_FuncMap_ChapterName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objQuestionnaire.chapterName) == true) {
                const cc_CourseChapter_CourseChapterId = objQuestionnaire.courseChapterId;
                const cc_CourseChapter_ChapterName = await (0, clscc_CourseChapterWApi_js_1.cc_CourseChapter_func)(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterId, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName, cc_CourseChapter_CourseChapterId, objQuestionnaire.courseId);
                objQuestionnaire.chapterName = cc_CourseChapter_ChapterName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000221)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.questionnaireEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.QuestionnaireEx_FuncMap_ChapterName = QuestionnaireEx_FuncMap_ChapterName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objQuestionnaireS:源对象
    **/
    async function QuestionnaireEx_FuncMap_LevelModeTypeName(objQuestionnaire) {
        const strThisFuncName = QuestionnaireEx_FuncMap_LevelModeTypeName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objQuestionnaire.levelModeTypeName) == true) {
                const ge_LevelModeType_LevelModeTypeId = objQuestionnaire.levelModeTypeId;
                const ge_LevelModeType_LevelModeTypeName = await (0, clsge_LevelModeTypeWApi_js_1.ge_LevelModeType_func)(clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeId, clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeName, ge_LevelModeType_LevelModeTypeId);
                objQuestionnaire.levelModeTypeName = ge_LevelModeType_LevelModeTypeName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000220)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.questionnaireEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.QuestionnaireEx_FuncMap_LevelModeTypeName = QuestionnaireEx_FuncMap_LevelModeTypeName;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function QuestionnaireEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_LevelModeTypeName:
                    return (a, b) => {
                        return a.levelModeTypeName.localeCompare(b.levelModeTypeName);
                    };
                case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_DifficultyLevelName:
                    return (a, b) => {
                        return a.difficultyLevelName.localeCompare(b.difficultyLevelName);
                    };
                case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_ChapterName:
                    return (a, b) => {
                        return a.chapterName.localeCompare(b.chapterName);
                    };
                case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_CourseName:
                    return (a, b) => {
                        return a.courseName.localeCompare(b.courseName);
                    };
                case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_QuestionTypeName:
                    return (a, b) => {
                        return a.questionTypeName.localeCompare(b.questionTypeName);
                    };
                case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_AnswerContent:
                    return (a, b) => {
                        return a.answerContent.localeCompare(b.answerContent);
                    };
                case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_UpdDate_Sim:
                    return (a, b) => {
                        return a.updDate_Sim.localeCompare(b.updDate_Sim);
                    };
                default:
                    return (0, clsQuestionnaireWApi_js_3.Questionnaire_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_LevelModeTypeName:
                    return (a, b) => {
                        return b.levelModeTypeName.localeCompare(a.levelModeTypeName);
                    };
                case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_DifficultyLevelName:
                    return (a, b) => {
                        return b.difficultyLevelName.localeCompare(a.difficultyLevelName);
                    };
                case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_ChapterName:
                    return (a, b) => {
                        return b.chapterName.localeCompare(a.chapterName);
                    };
                case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_CourseName:
                    return (a, b) => {
                        return b.courseName.localeCompare(a.courseName);
                    };
                case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_QuestionTypeName:
                    return (a, b) => {
                        return b.questionTypeName.localeCompare(a.questionTypeName);
                    };
                case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_AnswerContent:
                    return (a, b) => {
                        return b.answerContent.localeCompare(a.answerContent);
                    };
                case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_UpdDate_Sim:
                    return (a, b) => {
                        return b.updDate_Sim.localeCompare(a.updDate_Sim);
                    };
                default:
                    return (0, clsQuestionnaireWApi_js_3.Questionnaire_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.QuestionnaireEx_SortFunByKey = QuestionnaireEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function QuestionnaireEx_FuncMapByFldName(strFldName, objQuestionnaireEx) {
        const strThisFuncName = QuestionnaireEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsQuestionnaireEN_js_1.clsQuestionnaireEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_LevelModeTypeName:
                return QuestionnaireEx_FuncMap_LevelModeTypeName(objQuestionnaireEx);
            case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_DifficultyLevelName:
                return QuestionnaireEx_FuncMap_DifficultyLevelName(objQuestionnaireEx);
            case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_ChapterName:
                return QuestionnaireEx_FuncMap_ChapterName(objQuestionnaireEx);
            case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_CourseName:
                return QuestionnaireEx_FuncMap_CourseName(objQuestionnaireEx);
            case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_QuestionTypeName:
                return QuestionnaireEx_FuncMap_QuestionTypeName(objQuestionnaireEx);
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.QuestionnaireEx_FuncMapByFldName = QuestionnaireEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function QuestionnaireEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_LevelModeTypeName:
                return (obj) => {
                    return obj.levelModeTypeName === value;
                };
            case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_DifficultyLevelName:
                return (obj) => {
                    return obj.difficultyLevelName === value;
                };
            case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_ChapterName:
                return (obj) => {
                    return obj.chapterName === value;
                };
            case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_CourseName:
                return (obj) => {
                    return obj.courseName === value;
                };
            case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_QuestionTypeName:
                return (obj) => {
                    return obj.questionTypeName === value;
                };
            case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_AnswerContent:
                return (obj) => {
                    return obj.answerContent === value;
                };
            case clsQuestionnaireENEx_js_1.clsQuestionnaireENEx.con_UpdDate_Sim:
                return (obj) => {
                    return obj.updDate_Sim === value;
                };
            default:
                return (0, clsQuestionnaireWApi_js_4.Questionnaire_FilterFunByKey)(strKey, value);
        }
    }
    exports.QuestionnaireEx_FilterFunByKey = QuestionnaireEx_FilterFunByKey;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapKey)
    * @param objQuestionnaireS:源对象
    **/
    async function QuestionnaireEx_FuncMapKey_QuestionTypeName(objQuestionnaire) {
        const strThisFuncName = QuestionnaireEx_FuncMapKey_QuestionTypeName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objQuestionnaire.questionTypeName) == true)
                return [];
            const QuestionType_QuestionTypeName = objQuestionnaire.questionTypeName;
            const arrQuestionTypeId = await (0, clsQuestionTypeWApi_js_2.QuestionType_funcKey)(clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeName, QuestionType_QuestionTypeName, enumComparisonOp_js_1.enumComparisonOp.Like_03);
            return arrQuestionTypeId;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000219)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.questionnaireEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
    }
    exports.QuestionnaireEx_FuncMapKey_QuestionTypeName = QuestionnaireEx_FuncMapKey_QuestionTypeName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapKey)
    * @param objQuestionnaireS:源对象
    **/
    async function QuestionnaireEx_FuncMapKey_DifficultyLevelName(objQuestionnaire) {
        const strThisFuncName = QuestionnaireEx_FuncMapKey_DifficultyLevelName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objQuestionnaire.difficultyLevelName) == true)
                return [];
            const ge_DifficultyLevel_DifficultyLevelName = objQuestionnaire.difficultyLevelName;
            const arrDifficultyLevelId = await (0, clsge_DifficultyLevelWApi_js_2.ge_DifficultyLevel_funcKey)(clsge_DifficultyLevelEN_js_1.clsge_DifficultyLevelEN.con_DifficultyLevelName, ge_DifficultyLevel_DifficultyLevelName, enumComparisonOp_js_1.enumComparisonOp.Like_03);
            return arrDifficultyLevelId;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000218)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.questionnaireEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
    }
    exports.QuestionnaireEx_FuncMapKey_DifficultyLevelName = QuestionnaireEx_FuncMapKey_DifficultyLevelName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapKey)
    * @param objQuestionnaireS:源对象
    **/
    async function QuestionnaireEx_FuncMapKey_CourseName(objQuestionnaire) {
        const strThisFuncName = QuestionnaireEx_FuncMapKey_CourseName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objQuestionnaire.courseName) == true)
                return [];
            const vcc_Course_Sim_CourseName = objQuestionnaire.courseName;
            const arrCourseId = await (0, clsvcc_Course_SimWApi_js_2.vcc_Course_Sim_funcKey)(clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseName, vcc_Course_Sim_CourseName, enumComparisonOp_js_1.enumComparisonOp.Like_03);
            return arrCourseId;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000184)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.questionnaireEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
    }
    exports.QuestionnaireEx_FuncMapKey_CourseName = QuestionnaireEx_FuncMapKey_CourseName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapKey)
    * @param objQuestionnaireS:源对象
    **/
    async function QuestionnaireEx_FuncMapKey_ChapterName(objQuestionnaire) {
        const strThisFuncName = QuestionnaireEx_FuncMapKey_ChapterName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objQuestionnaire.chapterName) == true)
                return [];
            const cc_CourseChapter_ChapterName = objQuestionnaire.chapterName;
            const arrCourseChapterId = await (0, clscc_CourseChapterWApi_js_2.cc_CourseChapter_funcKey)(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName, cc_CourseChapter_ChapterName, objQuestionnaire.courseId, enumComparisonOp_js_1.enumComparisonOp.Like_03);
            return arrCourseChapterId;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000221)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.questionnaireEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
    }
    exports.QuestionnaireEx_FuncMapKey_ChapterName = QuestionnaireEx_FuncMapKey_ChapterName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapKey)
    * @param objQuestionnaireS:源对象
    **/
    async function QuestionnaireEx_FuncMapKey_LevelModeTypeName(objQuestionnaire) {
        const strThisFuncName = QuestionnaireEx_FuncMapKey_LevelModeTypeName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objQuestionnaire.levelModeTypeName) == true)
                return [];
            const ge_LevelModeType_LevelModeTypeName = objQuestionnaire.levelModeTypeName;
            const arrLevelModeTypeId = await (0, clsge_LevelModeTypeWApi_js_2.ge_LevelModeType_funcKey)(clsge_LevelModeTypeEN_js_1.clsge_LevelModeTypeEN.con_LevelModeTypeName, ge_LevelModeType_LevelModeTypeName, enumComparisonOp_js_1.enumComparisonOp.Like_03);
            return arrLevelModeTypeId;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000220)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.questionnaireEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            throw (strMsg);
        }
    }
    exports.QuestionnaireEx_FuncMapKey_LevelModeTypeName = QuestionnaireEx_FuncMapKey_LevelModeTypeName;
});
