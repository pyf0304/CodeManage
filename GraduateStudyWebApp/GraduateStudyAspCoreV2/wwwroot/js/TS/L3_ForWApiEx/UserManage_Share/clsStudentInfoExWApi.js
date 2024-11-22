/**
* 类名:clsStudentInfoExWApi
* 表名:StudentInfo(01120131)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/09 04:08:08
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/UserManage_Share/clsStudentInfoEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/UserManage_Share/clsStudentInfoENEx.js", "../../L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../../L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../../PubFun/clsString.js", "../../L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.StudentInfoEx_GetObjByid_StudentInfo_Cache = exports.StudentInfoEx_FilterFunByKey = exports.StudentInfoEx_FuncMapByFldName = exports.StudentInfoEx_SortFunByKey = exports.StudentInfoEx_GetObjExLstByPagerAsync = exports.StudentInfoEx_GetObjExLstByPager_Cache = exports.StudentInfoEx_CopyToEx = exports.StudentInfoEx_GetWebApiUrl = exports.studentInfoEx_ConstructorName = exports.studentInfoEx_Controller = void 0;
    /**
    * 学生(StudentInfo)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
   * Created by pyf on 2022年11月09日.
   * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsStudentInfoWApi_js_1 = require("../../L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsStudentInfoEN_js_1 = require("../../L0_Entity/UserManage_Share/clsStudentInfoEN.js");
    const clsCommFunc4Web_js_3 = require("../../PubFun/clsCommFunc4Web.js");
    const clsStudentInfoENEx_js_1 = require("../../L0_Entity/UserManage_Share/clsStudentInfoENEx.js");
    const clsStudentInfoWApi_js_2 = require("../../L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsStudentInfoWApi_js_3 = require("../../L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsStudentInfoWApi_js_4 = require("../../L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    exports.studentInfoEx_Controller = "StudentInfoExApi";
    exports.studentInfoEx_ConstructorName = "studentInfoEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function StudentInfoEx_GetWebApiUrl(strController, strAction) {
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
    exports.StudentInfoEx_GetWebApiUrl = StudentInfoEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objStudentInfoENS:源对象
    * @returns 目标对象=>clsStudentInfoEN:objStudentInfoENT
    **/
    function StudentInfoEx_CopyToEx(objStudentInfoENS) {
        const strThisFuncName = StudentInfoEx_CopyToEx.name;
        const objStudentInfoENT = new clsStudentInfoENEx_js_1.clsStudentInfoENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objStudentInfoENT, objStudentInfoENS);
            return objStudentInfoENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.studentInfoEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objStudentInfoENT;
        }
    }
    exports.StudentInfoEx_CopyToEx = StudentInfoEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function StudentInfoEx_GetObjExLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrStudentInfoObjLst = await (0, clsStudentInfoWApi_js_1.StudentInfo_GetObjLst_Cache)();
        const arrStudentInfoExObjLst = arrStudentInfoObjLst.map(StudentInfoEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrStudentInfoExObjLst) {
                const conFuncMap = await StudentInfoEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrStudentInfoExObjLst.length == 0)
            return arrStudentInfoExObjLst;
        let arrStudentInfo_Sel = arrStudentInfoExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objStudentInfo_Cond = new clsStudentInfoENEx_js_1.clsStudentInfoENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objStudentInfo_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsStudentInfoWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_3.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objStudentInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrStudentInfo_Sel.length == 0)
                return arrStudentInfo_Sel;
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
                arrStudentInfo_Sel = arrStudentInfo_Sel.sort(StudentInfoEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrStudentInfo_Sel = arrStudentInfo_Sel.sort(objPagerPara.sortFun);
            }
            arrStudentInfo_Sel = arrStudentInfo_Sel.slice(intStart, intEnd);
            return arrStudentInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.studentInfoEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.StudentInfoEx_GetObjExLstByPager_Cache = StudentInfoEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function StudentInfoEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrStudentInfoObjLst = await (0, clsStudentInfoWApi_js_2.StudentInfo_GetObjLstAsync)(objPagerPara.whereCond);
        const arrStudentInfoExObjLst = arrStudentInfoObjLst.map(StudentInfoEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrStudentInfoExObjLst) {
                const conFuncMap = await StudentInfoEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrStudentInfoExObjLst.length == 0)
            return arrStudentInfoExObjLst;
        let arrStudentInfo_Sel = arrStudentInfoExObjLst;
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
                arrStudentInfo_Sel = arrStudentInfo_Sel.sort(StudentInfoEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrStudentInfo_Sel = arrStudentInfo_Sel.sort(objPagerPara.sortFun);
            }
            arrStudentInfo_Sel = arrStudentInfo_Sel.slice(intStart, intEnd);
            return arrStudentInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.studentInfoEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.StudentInfoEx_GetObjExLstByPagerAsync = StudentInfoEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function StudentInfoEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsStudentInfoWApi_js_3.StudentInfo_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsStudentInfoWApi_js_3.StudentInfo_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.StudentInfoEx_SortFunByKey = StudentInfoEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function StudentInfoEx_FuncMapByFldName(strFldName, objStudentInfoEx) {
        const strThisFuncName = StudentInfoEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsStudentInfoEN_js_1.clsStudentInfoEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.StudentInfoEx_FuncMapByFldName = StudentInfoEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function StudentInfoEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsStudentInfoWApi_js_4.StudentInfo_FilterFunByKey)(strKey, value);
        }
    }
    exports.StudentInfoEx_FilterFunByKey = StudentInfoEx_FilterFunByKey;
    /// <summary>
    /// 根据关键字获取相关对象, 从缓存中获取.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
    /// </summary>
    /// <param name = "strid_StudentInfo">所给的关键字</param>
    /// <returns>对象</returns>
    async function StudentInfoEx_GetObjByid_StudentInfo_Cache(strid_StudentInfo) {
        var arrStudentInfoObjLst_Cache = await (0, clsStudentInfoWApi_js_1.StudentInfo_GetObjLst_Cache)();
        var obj = new clsStudentInfoEN_js_1.clsStudentInfoEN();
        try {
            var arrStudentInfo_Sel = arrStudentInfoObjLst_Cache.filter(x => x.stuID == strid_StudentInfo);
            var objStudentInfo;
            if (arrStudentInfo_Sel.length > 0) {
                objStudentInfo = arrStudentInfo_Sel[0];
                return objStudentInfo;
            }
            else {
                return obj;
            }
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据关键字:[${strid_StudentInfo}]获取相应的对象不成功!`;
            console.error(strMsg);
            alert(strMsg);
        }
        return obj;
    }
    exports.StudentInfoEx_GetObjByid_StudentInfo_Cache = StudentInfoEx_GetObjByid_StudentInfo_Cache;
    ;
});
