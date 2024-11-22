var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/UserManage_Share/clsUsersEN.js", "../../L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../../L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js", "../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../../PubFun/clsPublocalStorage.js", "../../PubFun/tzDictionary.js", "../../L0_Entity/GraduateEduTopic/clsvTopicObjectiveENEx.js", "../../L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js", "axios"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vTopicObjectiveEx_GetUsersByvobjvTopicObjective = exports.vTopicObjectiveEx_IsExist = exports.vTopicObjectiveEx_uniq = exports.vTopicObjectiveEx_BindDdl_UserIdInvTopicObjectiveBasis_Cache = exports.vTopicObjectiveEx_BindDdl_UserIdInvTopicObjectiveFact_Cache = exports.vTopicObjectiveEx_GetTopicObjectiveUserObjLstAsync = exports.vTopicObjectiveEx_FilterFunByKey = exports.vTopicObjectiveEx_FuncMapByFldName = exports.vTopicObjectiveEx_SortFunByKey = exports.vTopicObjectiveEx_GetObjExLstByPagerAsync = exports.vTopicObjectiveEx_GetObjExLstByPager_Cache = exports.vTopicObjectiveEx_CopyToEx = exports.vTopicObjectiveEx_GetWebApiUrl = exports.vTopicObjectiveEx_ConstructorName = exports.vTopicObjectiveEx_Controller = void 0;
    const clsvTopicObjectiveEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    //import { clsvTopicObjectiveEN_Sim } from "../../L0_Entity/GraduateEdu/clsvTopicObjectiveEN_Sim.js";
    //import { clsvTopicObjectiveBL } from "../../L2_BLL/GraduateEdu/clsvTopicObjectiveBL.js";
    const clsUsersEN_js_1 = require("../../L0_Entity/UserManage_Share/clsUsersEN.js");
    const clsvUsersSimEN_js_1 = require("../../L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsvTopicObjectiveWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js");
    const clsvUsersSimWApi_js_1 = require("../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsPublocalStorage_js_1 = require("../../PubFun/clsPublocalStorage.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const clsvTopicObjectiveENEx_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvTopicObjectiveENEx.js");
    const clsvTopicObjectiveWApi_js_2 = require("../../L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const axios_1 = __importDefault(require("axios"));
    exports.vTopicObjectiveEx_Controller = "vTopicObjectiveExApi";
    exports.vTopicObjectiveEx_ConstructorName = "vTopicObjectiveEx";
    //public static cacheModeId = "02"; //客户端缓存
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vTopicObjectiveEx_GetWebApiUrl(strController, strAction) {
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
    exports.vTopicObjectiveEx_GetWebApiUrl = vTopicObjectiveEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvTopicObjectiveENS:源对象
    * @returns 目标对象=>clsvTopicObjectiveEN:objvTopicObjectiveENT
    **/
    function vTopicObjectiveEx_CopyToEx(objvTopicObjectiveENS) {
        const strThisFuncName = vTopicObjectiveEx_CopyToEx.name;
        const objvTopicObjectiveENT = new clsvTopicObjectiveENEx_js_1.clsvTopicObjectiveENEx();
        try {
            (0, clsCommFunc4Web_js_2.ObjectAssign)(objvTopicObjectiveENT, objvTopicObjectiveENS);
            return objvTopicObjectiveENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vTopicObjectiveEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvTopicObjectiveENT;
        }
    }
    exports.vTopicObjectiveEx_CopyToEx = vTopicObjectiveEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vTopicObjectiveEx_GetObjExLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvTopicObjectiveObjLst = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetObjLst_Cache)(strid_CurrEduCls);
        const arrvTopicObjectiveExObjLst = arrvTopicObjectiveObjLst.map(vTopicObjectiveEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvTopicObjectiveExObjLst) {
                const conFuncMap = await vTopicObjectiveEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvTopicObjectiveExObjLst.length == 0)
            return arrvTopicObjectiveExObjLst;
        let arrvTopicObjective_Sel = arrvTopicObjectiveExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvTopicObjective_Cond = new clsvTopicObjectiveENEx_js_1.clsvTopicObjectiveENEx();
        (0, clsCommFunc4Web_js_2.ObjectAssign)(objvTopicObjective_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvTopicObjectiveWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_2.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvTopicObjective_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvTopicObjective_Sel.length == 0)
                return arrvTopicObjective_Sel;
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
                arrvTopicObjective_Sel = arrvTopicObjective_Sel.sort(vTopicObjectiveEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvTopicObjective_Sel = arrvTopicObjective_Sel.sort(objPagerPara.sortFun);
            }
            arrvTopicObjective_Sel = arrvTopicObjective_Sel.slice(intStart, intEnd);
            return arrvTopicObjective_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vTopicObjectiveEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vTopicObjectiveEx_GetObjExLstByPager_Cache = vTopicObjectiveEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vTopicObjectiveEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvTopicObjectiveExObjLst = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvTopicObjectiveExObjLst) {
                const conFuncMap = await vTopicObjectiveEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvTopicObjectiveExObjLst.length == 0)
            return arrvTopicObjectiveExObjLst;
        let arrvTopicObjective_Sel = arrvTopicObjectiveExObjLst;
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
                arrvTopicObjective_Sel = arrvTopicObjective_Sel.sort(vTopicObjectiveEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvTopicObjective_Sel = arrvTopicObjective_Sel.sort(objPagerPara.sortFun);
            }
            arrvTopicObjective_Sel = arrvTopicObjective_Sel.slice(intStart, intEnd);
            return arrvTopicObjective_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vTopicObjectiveEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vTopicObjectiveEx_GetObjExLstByPagerAsync = vTopicObjectiveEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vTopicObjectiveEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsvTopicObjectiveWApi_js_2.vTopicObjective_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsvTopicObjectiveWApi_js_2.vTopicObjective_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vTopicObjectiveEx_SortFunByKey = vTopicObjectiveEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vTopicObjectiveEx_FuncMapByFldName(strFldName, objvTopicObjectiveEx) {
        const strThisFuncName = vTopicObjectiveEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvTopicObjectiveEN_js_1.clsvTopicObjectiveEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vTopicObjectiveEx_FuncMapByFldName = vTopicObjectiveEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vTopicObjectiveEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_FilterFunByKey)(strKey, value);
        }
    }
    exports.vTopicObjectiveEx_FilterFunByKey = vTopicObjectiveEx_FilterFunByKey;
    /// <summary>
    /// 获取论文中的用户数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function vTopicObjectiveEx_GetTopicObjectiveUserObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetTopicObjectiveUserObjLstAsync";
        var strAction = "GetTopicObjectiveUserObjLst";
        let strUrl = vTopicObjectiveEx_GetWebApiUrl(exports.vTopicObjectiveEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTopicObjectiveEx_Controller, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetObjLstByJSONObjLst)(returnObjLst);
                return (arrObjLst);
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTopicObjectiveEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTopicObjectiveEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTopicObjectiveEx_GetTopicObjectiveUserObjLstAsync = vTopicObjectiveEx_GetTopicObjectiveUserObjLstAsync;
    //从客观事实表中得到用户数据
    /// <summary>
    /// 绑定基于Web的下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    async function vTopicObjectiveEx_BindDdl_UserIdInvTopicObjectiveFact_Cache(strDdlName, objUsers_Cond) {
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_UserIdInvConcept_Cache");
        var arrvConcept = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetObjLstAsync)("1=1");
        //获取客观事实
        var arrvclsvTopicObjectiveEN = new Array();
        arrvclsvTopicObjectiveEN = arrvConcept.filter(x => x.objectiveType == "01"); //客观事实；
        var arrObjLst_Sel = arrvclsvTopicObjectiveEN.map(vTopicObjectiveEx_GetUsersByvobjvTopicObjective);
        arrObjLst_Sel = vTopicObjectiveEx_uniq(arrObjLst_Sel);
        console.log(arrObjLst_Sel);
        arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsUsersEN_js_1.clsUsersEN.con_UserName]);
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(strDdlName, arrObjLst_Sel, clsUsersEN_js_1.clsUsersEN.con_UserId, clsUsersEN_js_1.clsUsersEN.con_UserName, "编辑用户");
    }
    exports.vTopicObjectiveEx_BindDdl_UserIdInvTopicObjectiveFact_Cache = vTopicObjectiveEx_BindDdl_UserIdInvTopicObjectiveFact_Cache;
    //从客观数据表中得到用户数据
    /// <summary>
    /// 绑定基于Web的下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    async function vTopicObjectiveEx_BindDdl_UserIdInvTopicObjectiveBasis_Cache(strDdlName, objUsers_Cond) {
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        console.log("开始：BindDdl_UserIdInvConcept_Cache");
        var arrvObjList = await (0, clsvTopicObjectiveWApi_js_1.vTopicObjective_GetObjLst_Cache)(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
        //获取客观数据
        var arrvclsvTopicObjectiveEN = new Array();
        arrvclsvTopicObjectiveEN = arrvObjList.filter(x => x.objectiveType == "02"); //客观数据；
        var arrUserId_Set = new Set(arrvclsvTopicObjectiveEN.map(x => x.updUser));
        console.log(arrUserId_Set);
        var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
        var arrUsersList_Sel = arrUsers.filter(x => arrUserId_Set.has(x.userId));
        console.log(arrUsersList_Sel);
        arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserName]);
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst_V)(strDdlName, arrUsersList_Sel, clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserId, clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserName, "编辑用户");
        ////为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_UserIdInvConcept_Cache");
        //var arrvConcept: Array<clsvTopicObjectiveEN> = await vTopicObjective_GetObjLstAsync("1=1");
        ////获取客观数据
        //var arrvclsvTopicObjectiveEN: Array<clsvTopicObjectiveEN> = new Array<clsvTopicObjectiveEN>();
        //arrvclsvTopicObjectiveEN = arrvConcept.filter(x => x.objectiveType == "02");//客观数据；
        //var arrObjLst_Sel: Array<clsUsersEN> = arrvclsvTopicObjectiveEN.map(vTopicObjectiveEx_GetUsersByvobjvTopicObjective);
        //arrObjLst_Sel = clsvTopicObjectiveExWApi.uniq(arrObjLst_Sel);
        //console.log(arrObjLst_Sel);
        //arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsUsersEN.con_UserName]);
        //BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsUsersEN.con_UserId, clsUsersEN.con_UserName, "编辑用户");
    }
    exports.vTopicObjectiveEx_BindDdl_UserIdInvTopicObjectiveBasis_Cache = vTopicObjectiveEx_BindDdl_UserIdInvTopicObjectiveBasis_Cache;
    function vTopicObjectiveEx_uniq(arr) {
        let arrObjLst_New = new Array();
        for (let x of arr) {
            if (vTopicObjectiveEx_IsExist(arrObjLst_New, x) == false) {
                arrObjLst_New.push(x);
            }
        }
        return arrObjLst_New;
    }
    exports.vTopicObjectiveEx_uniq = vTopicObjectiveEx_uniq;
    function vTopicObjectiveEx_IsExist(arr, key) {
        let arr_Sel = arr.filter(x => x.userId == key.userId);
        if (arr_Sel.length > 0)
            return true;
        return false;
    }
    exports.vTopicObjectiveEx_IsExist = vTopicObjectiveEx_IsExist;
    function vTopicObjectiveEx_GetUsersByvobjvTopicObjective(objvTopicObjective) {
        var objUsers = new clsUsersEN_js_1.clsUsersEN();
        objUsers.userId = objvTopicObjective.updUser;
        // objUsers.userName = objvTopicObjective.userName;
        return objUsers;
    }
    exports.vTopicObjectiveEx_GetUsersByvobjvTopicObjective = vTopicObjectiveEx_GetUsersByvobjvTopicObjective;
});
