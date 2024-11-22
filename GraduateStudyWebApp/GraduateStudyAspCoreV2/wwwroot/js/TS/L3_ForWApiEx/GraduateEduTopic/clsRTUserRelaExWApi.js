var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js", "../../PubFun/tzDictionary.js", "axios", "../../L0_Entity/BaseInfo_Share/clsXzClgEN.js", "../../L0_Entity/BaseInfo_Share/clsXzMajorEN.js", "../../L0_Entity/GraduateEduTopic/clsRTUserRelaENEx.js", "../../L0_Entity/ParameterTable/clsgs_ColorEN.js", "../../L0_Entity/ParameterTable/clsTopicUserRoleEN.js", "../../L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../../L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js", "../../L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../../L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js", "../../L3_ForWApi/ParameterTable/clsgs_ColorWApi.js", "../../L3_ForWApi/ParameterTable/clsTopicUserRoleWApi.js", "../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsPublocalStorage.js", "../../PubFun/clsString.js", "../../PubFun/clsDateTime.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.RTUserRelaEx_AddUserId = exports.RTUserRelaEx_FuncMap_TopicUserRoleName = exports.RTUserRelaEx_FuncMap_MajorName = exports.RTUserRelaEx_FuncMap_UserName = exports.RTUserRelaEx_FuncMap_CollegeName = exports.RTUserRelaEx_FuncMap_ColorCode = exports.RTUserRelaEx_BindTabvRTUserRela = exports.RTUserRelaEx_UpdateTypeTableHtmlAsync = exports.RTUserRelaEx_FilterFunByKey = exports.RTUserRelaEx_FuncMapByFldName = exports.RTUserRelaEx_SortFunByKey = exports.RTUserRelaEx_GetObjExLstByPagerAsync = exports.RTUserRelaEx_GetObjExLstByPager_Cache = exports.RTUserRelaEx_CopyToEx = exports.RTUserRelaEx_GetWebApiUrl = exports.rTUserRelaEx_ConstructorName = exports.rTUserRelaEx_Controller = void 0;
    const clsRTUserRelaEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    const axios_1 = __importDefault(require("axios"));
    const clsXzClgEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsXzClgEN.js");
    const clsXzMajorEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsXzMajorEN.js");
    const clsRTUserRelaENEx_js_1 = require("../../L0_Entity/GraduateEduTopic/clsRTUserRelaENEx.js");
    const clsgs_ColorEN_js_1 = require("../../L0_Entity/ParameterTable/clsgs_ColorEN.js");
    const clsTopicUserRoleEN_js_1 = require("../../L0_Entity/ParameterTable/clsTopicUserRoleEN.js");
    const clsvUsersSimEN_js_1 = require("../../L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsXzClgWApi_js_1 = require("../../L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js");
    const clsXzMajorWApi_js_1 = require("../../L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsRTUserRelaWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js");
    const clsgs_ColorWApi_js_1 = require("../../L3_ForWApi/ParameterTable/clsgs_ColorWApi.js");
    const clsTopicUserRoleWApi_js_1 = require("../../L3_ForWApi/ParameterTable/clsTopicUserRoleWApi.js");
    const clsvUsersSimWApi_js_1 = require("../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsPublocalStorage_js_1 = require("../../PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsDateTime_js_1 = require("../../PubFun/clsDateTime.js");
    exports.rTUserRelaEx_Controller = "RTUserRelaExApi";
    exports.rTUserRelaEx_ConstructorName = "rTUserRelaEx";
    //public static cacheModeId = "05"; //未知
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function RTUserRelaEx_GetWebApiUrl(strController, strAction) {
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
    exports.RTUserRelaEx_GetWebApiUrl = RTUserRelaEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objRTUserRelaENS:源对象
    * @returns 目标对象=>clsRTUserRelaEN:objRTUserRelaENT
    **/
    function RTUserRelaEx_CopyToEx(objRTUserRelaENS) {
        const strThisFuncName = RTUserRelaEx_CopyToEx.name;
        const objRTUserRelaENT = new clsRTUserRelaENEx_js_1.clsRTUserRelaENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objRTUserRelaENT, objRTUserRelaENS);
            return objRTUserRelaENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.rTUserRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objRTUserRelaENT;
        }
    }
    exports.RTUserRelaEx_CopyToEx = RTUserRelaEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function RTUserRelaEx_GetObjExLstByPager_Cache(objPagerPara, strTopicId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrRTUserRelaObjLst = await (0, clsRTUserRelaWApi_js_1.RTUserRela_GetObjLst_Cache)(strTopicId);
        const arrRTUserRelaExObjLst = arrRTUserRelaObjLst.map(RTUserRelaEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrRTUserRelaExObjLst) {
                const conFuncMap = await RTUserRelaEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrRTUserRelaExObjLst.length == 0)
            return arrRTUserRelaExObjLst;
        let arrRTUserRela_Sel = arrRTUserRelaExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objRTUserRela_Cond = new clsRTUserRelaENEx_js_1.clsRTUserRelaENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objRTUserRela_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsRTUserRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRTUserRela_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrRTUserRela_Sel.length == 0)
                return arrRTUserRela_Sel;
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
                arrRTUserRela_Sel = arrRTUserRela_Sel.sort(RTUserRelaEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrRTUserRela_Sel = arrRTUserRela_Sel.sort(objPagerPara.sortFun);
            }
            arrRTUserRela_Sel = arrRTUserRela_Sel.slice(intStart, intEnd);
            return arrRTUserRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.rTUserRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.RTUserRelaEx_GetObjExLstByPager_Cache = RTUserRelaEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function RTUserRelaEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrRTUserRelaObjLst = await (0, clsRTUserRelaWApi_js_1.RTUserRela_GetObjLstAsync)(objPagerPara.whereCond);
        const arrRTUserRelaExObjLst = arrRTUserRelaObjLst.map(RTUserRelaEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrRTUserRelaExObjLst) {
                const conFuncMap = await RTUserRelaEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrRTUserRelaExObjLst.length == 0)
            return arrRTUserRelaExObjLst;
        let arrRTUserRela_Sel = arrRTUserRelaExObjLst;
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
                arrRTUserRela_Sel = arrRTUserRela_Sel.sort(RTUserRelaEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrRTUserRela_Sel = arrRTUserRela_Sel.sort(objPagerPara.sortFun);
            }
            arrRTUserRela_Sel = arrRTUserRela_Sel.slice(intStart, intEnd);
            return arrRTUserRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.rTUserRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.RTUserRelaEx_GetObjExLstByPagerAsync = RTUserRelaEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:潘以锋
     * 日期:00-00-00
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RTUserRelaEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_ColorCode:
                    return (a, b) => {
                        return a.colorCode.localeCompare(b.colorCode);
                    };
                case clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_CollegeName:
                    return (a, b) => {
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                case clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_TopicUserRoleName:
                    return (a, b) => {
                        return a.topicUserRoleName.localeCompare(b.topicUserRoleName);
                    };
                default:
                    return (0, clsRTUserRelaWApi_js_1.RTUserRela_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                case clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_ColorCode:
                    return (a, b) => {
                        return b.colorCode.localeCompare(a.colorCode);
                    };
                case clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_CollegeName:
                    return (a, b) => {
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                case clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_TopicUserRoleName:
                    return (a, b) => {
                        return b.topicUserRoleName.localeCompare(a.topicUserRoleName);
                    };
                default:
                    return (0, clsRTUserRelaWApi_js_1.RTUserRela_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.RTUserRelaEx_SortFunByKey = RTUserRelaEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:潘以锋
     * 日期:00-00-00
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function RTUserRelaEx_FuncMapByFldName(strFldName, objRTUserRelaEx) {
        const strThisFuncName = RTUserRelaEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsRTUserRelaEN_js_1.clsRTUserRelaEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            case clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_ColorCode:
                return RTUserRelaEx_FuncMap_ColorCode(objRTUserRelaEx);
            case clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_CollegeName:
                return RTUserRelaEx_FuncMap_CollegeName(objRTUserRelaEx);
            case clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_UserName:
                return RTUserRelaEx_FuncMap_UserName(objRTUserRelaEx);
            case clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_MajorName:
                return RTUserRelaEx_FuncMap_MajorName(objRTUserRelaEx);
            case clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_TopicUserRoleName:
                return RTUserRelaEx_FuncMap_TopicUserRoleName(objRTUserRelaEx);
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.RTUserRelaEx_FuncMapByFldName = RTUserRelaEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function RTUserRelaEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsRTUserRelaWApi_js_1.RTUserRela_FilterFunByKey)(strKey, value);
        }
    }
    exports.RTUserRelaEx_FilterFunByKey = RTUserRelaEx_FilterFunByKey;
    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>返回的第一条记录的关键字值</returns>
    async function RTUserRelaEx_UpdateTypeTableHtmlAsync(OldCodeColor, NewCodeColor, userId) {
        const strThisFuncName = "";
        var strAction = "UpdateTypeTableHtml";
        let strUrl = RTUserRelaEx_GetWebApiUrl(exports.rTUserRelaEx_Controller, strAction);
        var mapParam = new tzDictionary_js_1.Dictionary();
        let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "OldCodeColor": OldCodeColor,
                    "NewCodeColor": NewCodeColor,
                    "userId": userId
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return (data.returnBool);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rTUserRelaEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rTUserRelaEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RTUserRelaEx_UpdateTypeTableHtmlAsync = RTUserRelaEx_UpdateTypeTableHtmlAsync;
    //绑定主题用户关系列表；
    async function RTUserRelaEx_BindTabvRTUserRela(strDivName, arrvRTUserRelaObjLst) {
        var strhtml = "";
        for (var objInFor of arrvRTUserRelaObjLst) {
            await RTUserRelaEx_FuncMapByFldName(clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_CollegeName, objInFor);
            await RTUserRelaEx_FuncMapByFldName(clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_ColorCode, objInFor);
            await RTUserRelaEx_FuncMapByFldName(clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_MajorName, objInFor);
            await RTUserRelaEx_FuncMapByFldName(clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_TopicUserRoleName, objInFor);
            await RTUserRelaEx_FuncMapByFldName(clsRTUserRelaENEx_js_1.clsRTUserRelaENEx.con_UserName, objInFor);
        }
        var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
        var strRoleId = "";
        strhtml += '<div class="info" id="infoRTUserRela"><div class="title btn-4">';
        strhtml += '</div><ul class="artlist">';
        //获取当前用户在 主题用户关系表中的角色；
        var objUserRela = arrvRTUserRelaObjLst.find(x => x.userId == strUserId);
        if (objUserRela != null) {
            strRoleId = objUserRela.topicUserRoleId;
        }
        var v = 0; //给内容加个序号
        for (var i = 0; i < arrvRTUserRelaObjLst.length; i++) {
            //得到mId；
            const objRTUserRelaEx = arrvRTUserRelaObjLst[i];
            var strmId = objRTUserRelaEx.mId;
            var strUserColor = objRTUserRelaEx.colorCode;
            var strTopicUser = objRTUserRelaEx.userId;
            var strTopicRoleId = objRTUserRelaEx.topicUserRoleId;
            v++;
            strhtml += '<li><span class="rowtit color4">' + v + '.[用户]：</span><span class="abstract-text">' + objRTUserRelaEx.userName + '</span>';
            //学院
            strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[学院]：</span><span class="abstract-text">' + objRTUserRelaEx.collegeName + '</span>';
            strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[专业]：</span><span class="abstract-text">' + objRTUserRelaEx.majorName + '</span></li>';
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[角色]：</span><span class="abstract-text">' + objRTUserRelaEx.topicUserRoleName + '</span></li>';
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color4">[色码]：</span><span class="abstract-text"><label style="background: ' + strUserColor + '">&nbsp;&nbsp;&nbsp;&nbsp;</label></span></li>';
            strhtml += '<li>&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[操作]：';
            ////修改色码
            ////只能修改自己的，所以这里判断一下；
            //if (strTopicUser == strUserId) {
            //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick="btnUpdateUserRelaInTab_Click(' + objRTUserRelaEx.mId + ')" >修改</button>';
            //    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="删除" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelUserRelaInTab_Click(' + objRTUserRelaEx.mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
            //}
            //else {
            if (strRoleId != "0003") {
                //组长或指导员
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick="btnUpdateUserRelaInTab_Click(' + objRTUserRelaEx.mId + ',' + strRoleId + ')" >修改</button>';
                strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="删除" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelUserRelaInTab_Click(' + objRTUserRelaEx.mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
            }
            else {
                //成员 只能修改自己的，所以这里判断一下；
                if (strTopicUser == strUserId) {
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="修改" class="layui-btn layui-btn layui-btn layui-btn-xs" onclick="btnUpdateUserRelaInTab_Click(' + objRTUserRelaEx.mId + ',' + strRoleId + ')" >修改</button>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button style="float:right;" title="删除" class="layui-btn-danger layui-btn layui-btn layui-btn-xs" onclick="btnDelUserRelaInTab_Click(' + objRTUserRelaEx.mId + ')" > <i class="layui-icon" >&#xe640;</i>移除</button>';
                }
            }
            strhtml += '</span></li>';
            strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
        }
        strhtml += '</ul></div>';
        //拼接；
        $(`#${strDivName}`).html(strhtml); //#divRtUserRelaDataLst
    }
    exports.RTUserRelaEx_BindTabvRTUserRela = RTUserRelaEx_BindTabvRTUserRela;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objRTUserRelaS:源对象
    **/
    async function RTUserRelaEx_FuncMap_ColorCode(objRTUserRela) {
        const strThisFuncName = RTUserRelaEx_FuncMap_ColorCode.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objRTUserRela.colorCode) == true) {
                const gs_Color_ColorId = objRTUserRela.colorId;
                const gs_Color_ColorCode = await (0, clsgs_ColorWApi_js_1.gs_Color_func)(clsgs_ColorEN_js_1.clsgs_ColorEN.con_ColorId, clsgs_ColorEN_js_1.clsgs_ColorEN.con_ColorCode, gs_Color_ColorId);
                objRTUserRela.colorCode = gs_Color_ColorCode;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000274)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.rTUserRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.RTUserRelaEx_FuncMap_ColorCode = RTUserRelaEx_FuncMap_ColorCode;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objRTUserRelaS:源对象
    **/
    async function RTUserRelaEx_FuncMap_CollegeName(objRTUserRela) {
        const strThisFuncName = RTUserRelaEx_FuncMap_CollegeName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objRTUserRela.collegeName) == true) {
                const vUsersSim_UserId = objRTUserRela.userId;
                const vUsersSim_id_XzCollege = await (0, clsvUsersSimWApi_js_1.vUsersSim_func)(clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserId, clsvUsersSimEN_js_1.clsvUsersSimEN.con_id_XzCollege, vUsersSim_UserId, clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                const XzClg_id_XzCollege = vUsersSim_id_XzCollege;
                const XzClg_CollegeName = await (0, clsXzClgWApi_js_1.XzClg_func)(clsXzClgEN_js_1.clsXzClgEN.con_id_XzCollege, clsXzClgEN_js_1.clsXzClgEN.con_CollegeName, XzClg_id_XzCollege);
                objRTUserRela.collegeName = XzClg_CollegeName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000214)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.rTUserRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.RTUserRelaEx_FuncMap_CollegeName = RTUserRelaEx_FuncMap_CollegeName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objRTUserRelaS:源对象
    **/
    async function RTUserRelaEx_FuncMap_UserName(objRTUserRela) {
        const strThisFuncName = RTUserRelaEx_FuncMap_UserName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objRTUserRela.userName) == true) {
                const vUsersSim_UserId = objRTUserRela.userId;
                const vUsersSim_UserName = await (0, clsvUsersSimWApi_js_1.vUsersSim_func)(clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserId, clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserName, vUsersSim_UserId, clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                objRTUserRela.userName = vUsersSim_UserName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000166)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.rTUserRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.RTUserRelaEx_FuncMap_UserName = RTUserRelaEx_FuncMap_UserName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objRTUserRelaS:源对象
    **/
    async function RTUserRelaEx_FuncMap_MajorName(objRTUserRela) {
        const strThisFuncName = RTUserRelaEx_FuncMap_MajorName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objRTUserRela.majorName) == true) {
                const vUsersSim_UserId = objRTUserRela.userId;
                const vUsersSim_id_XzMajor = await (0, clsvUsersSimWApi_js_1.vUsersSim_func)(clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserId, clsvUsersSimEN_js_1.clsvUsersSimEN.con_id_XzMajor, vUsersSim_UserId, clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                const XzMajor_id_XzMajor = vUsersSim_id_XzMajor;
                const XzMajor_MajorName = await (0, clsXzMajorWApi_js_1.XzMajor_func)(clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, XzMajor_id_XzMajor);
                objRTUserRela.majorName = XzMajor_MajorName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000204)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.rTUserRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.RTUserRelaEx_FuncMap_MajorName = RTUserRelaEx_FuncMap_MajorName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objRTUserRelaS:源对象
    **/
    async function RTUserRelaEx_FuncMap_TopicUserRoleName(objRTUserRela) {
        const strThisFuncName = RTUserRelaEx_FuncMap_TopicUserRoleName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objRTUserRela.topicUserRoleName) == true) {
                const TopicUserRole_TopicUserRoleId = objRTUserRela.topicUserRoleId;
                const TopicUserRole_TopicUserRoleName = await (0, clsTopicUserRoleWApi_js_1.TopicUserRole_func)(clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleId, clsTopicUserRoleEN_js_1.clsTopicUserRoleEN.con_TopicUserRoleName, TopicUserRole_TopicUserRoleId);
                objRTUserRela.topicUserRoleName = TopicUserRole_TopicUserRoleName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000275)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.rTUserRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.RTUserRelaEx_FuncMap_TopicUserRoleName = RTUserRelaEx_FuncMap_TopicUserRoleName;
    async function RTUserRelaEx_AddUserId(strTopicId, strUserId, strTopicUserRoleId, strId_CurrEduCls) {
        const strThisFuncName = "RTUserRelaEx_AddUserId";
        let strMsg = "";
        const obj = new clsRTUserRelaEN_js_1.clsRTUserRelaEN();
        obj.topicId = strTopicId;
        obj.topicUserRoleId = strTopicUserRoleId;
        obj.id_CurrEduCls = strId_CurrEduCls;
        obj.userId = strUserId;
        obj.updUser = strUserId;
        obj.updDate = clsDateTime_js_1.clsDateTime.getTodayDateTimeStr(0);
        try {
            const bolIsResult = await (0, clsRTUserRelaWApi_js_1.RTUserRela_AddNewRecordAsync)(obj);
            if (bolIsResult == true) {
                (0, clsRTUserRelaWApi_js_1.RTUserRela_ReFreshCache)(strTopicId);
            }
        }
        catch (e) {
            console.error(e);
        }
    }
    exports.RTUserRelaEx_AddUserId = RTUserRelaEx_AddUserId;
});
