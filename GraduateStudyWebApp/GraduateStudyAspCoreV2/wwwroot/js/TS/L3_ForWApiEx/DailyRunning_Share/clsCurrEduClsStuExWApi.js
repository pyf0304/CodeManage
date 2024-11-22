var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/DailyRunning_Share/clsCurrEduClsStuEN.js", "../../L0_Entity/DailyRunning_Share/clsCurrEduClsStuENEx.js", "../../L3_ForWApi/DailyRunning_Share/clsCurrEduClsStuWApi.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js", "../../L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js", "axios", "../../PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CurrEduClsStuEx_BindDdl_id_CurrEduClsByStuIdInDiv_Cache = exports.CurrEduClsStuEx_GetStuIDLstById_CurrEduCls = exports.CurrEduClsStuEx_Getid_CurrEduClsListByStuId = exports.CurrEduClsStu_BindDdl_id_StuByid_CurrEduClsInDivEx_Cache = exports.CurrEduClsStuEx_FilterFunByKey = exports.CurrEduClsStuEx_FuncMapByFldName = exports.CurrEduClsStuEx_SortFunByKey = exports.CurrEduClsStuEx_GetObjExLstByPagerAsync = exports.CurrEduClsStuEx_GetObjExLstByPager_Cache = exports.CurrEduClsStuEx_CopyToEx = exports.CurrEduClsStuEx_GetWebApiUrl = exports.currEduClsStuEx_ConstructorName = exports.currEduClsStuEx_Controller = void 0;
    const clsCurrEduClsStuEN_js_1 = require("../../L0_Entity/DailyRunning_Share/clsCurrEduClsStuEN.js");
    const clsCurrEduClsStuENEx_js_1 = require("../../L0_Entity/DailyRunning_Share/clsCurrEduClsStuENEx.js");
    const clsCurrEduClsStuWApi_js_1 = require("../../L3_ForWApi/DailyRunning_Share/clsCurrEduClsStuWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsCurrEduClsEN_js_1 = require("../../L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js");
    //import * as QQ from "q";
    const clsCurrEduClsWApi_js_1 = require("../../L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js");
    const axios_1 = __importDefault(require("axios"));
    const clsPublocalStorage_js_1 = require("../../PubFun/clsPublocalStorage.js");
    exports.currEduClsStuEx_Controller = "CurrEduClsStuExApi";
    exports.currEduClsStuEx_ConstructorName = "currEduClsStuEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function CurrEduClsStuEx_GetWebApiUrl(strController, strAction) {
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
    exports.CurrEduClsStuEx_GetWebApiUrl = CurrEduClsStuEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objCurrEduClsStuENS:源对象
    * @returns 目标对象=>clsCurrEduClsStuEN:objCurrEduClsStuENT
    **/
    function CurrEduClsStuEx_CopyToEx(objCurrEduClsStuENS) {
        const strThisFuncName = CurrEduClsStuEx_CopyToEx.name;
        const objCurrEduClsStuENT = new clsCurrEduClsStuENEx_js_1.clsCurrEduClsStuENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objCurrEduClsStuENT, objCurrEduClsStuENS);
            return objCurrEduClsStuENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.currEduClsStuEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objCurrEduClsStuENT;
        }
    }
    exports.CurrEduClsStuEx_CopyToEx = CurrEduClsStuEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function CurrEduClsStuEx_GetObjExLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrCurrEduClsStuObjLst = await (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_GetObjLst_Cache)(strid_CurrEduCls);
        const arrCurrEduClsStuExObjLst = arrCurrEduClsStuObjLst.map(CurrEduClsStuEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrCurrEduClsStuExObjLst) {
                const conFuncMap = await CurrEduClsStuEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrCurrEduClsStuExObjLst.length == 0)
            return arrCurrEduClsStuExObjLst;
        let arrCurrEduClsStu_Sel = arrCurrEduClsStuExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objCurrEduClsStu_Cond = new clsCurrEduClsStuENEx_js_1.clsCurrEduClsStuENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objCurrEduClsStu_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsCurrEduClsStuWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCurrEduClsStu_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrCurrEduClsStu_Sel.length == 0)
                return arrCurrEduClsStu_Sel;
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
                arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.sort(CurrEduClsStuEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.sort(objPagerPara.sortFun);
            }
            arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.slice(intStart, intEnd);
            return arrCurrEduClsStu_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.currEduClsStuEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CurrEduClsStuEx_GetObjExLstByPager_Cache = CurrEduClsStuEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function CurrEduClsStuEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrCurrEduClsStuObjLst = await (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_GetObjLstAsync)(objPagerPara.whereCond);
        const arrCurrEduClsStuExObjLst = arrCurrEduClsStuObjLst.map(CurrEduClsStuEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrCurrEduClsStuExObjLst) {
                const conFuncMap = await CurrEduClsStuEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrCurrEduClsStuExObjLst.length == 0)
            return arrCurrEduClsStuExObjLst;
        let arrCurrEduClsStu_Sel = arrCurrEduClsStuExObjLst;
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
                arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.sort(CurrEduClsStuEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.sort(objPagerPara.sortFun);
            }
            arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.slice(intStart, intEnd);
            return arrCurrEduClsStu_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.currEduClsStuEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CurrEduClsStuEx_GetObjExLstByPagerAsync = CurrEduClsStuEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-12-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CurrEduClsStuEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsCurrEduClsStuENEx_js_1.clsCurrEduClsStuENEx.con_StuName:
                    return (a, b) => {
                        return a.stuName.localeCompare(b.stuName);
                    };
                default:
                    return (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                case clsCurrEduClsStuENEx_js_1.clsCurrEduClsStuENEx.con_StuName:
                    return (a, b) => {
                        return b.stuName.localeCompare(a.stuName);
                    };
                default:
                    return (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.CurrEduClsStuEx_SortFunByKey = CurrEduClsStuEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-12-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function CurrEduClsStuEx_FuncMapByFldName(strFldName, objCurrEduClsStuEx) {
        const strThisFuncName = CurrEduClsStuEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsCurrEduClsStuEN_js_1.clsCurrEduClsStuEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.CurrEduClsStuEx_FuncMapByFldName = CurrEduClsStuEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-12-09
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function CurrEduClsStuEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsCurrEduClsStuENEx_js_1.clsCurrEduClsStuENEx.con_StuName:
                return (obj) => {
                    return obj.stuName === value;
                };
            default:
                return (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_FilterFunByKey)(strKey, value);
        }
    }
    exports.CurrEduClsStuEx_FilterFunByKey = CurrEduClsStuEx_FilterFunByKey;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
     * @param strid_CurrEduCls:教学班流水号
    */
    async function CurrEduClsStu_BindDdl_id_StuByid_CurrEduClsInDivEx_Cache(strDivName, strDdlName, strid_CurrEduCls) {
        const strThisFuncName = "BindDdl_id_StuByid_CurrEduClsInDiv_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In BindDdl_id_StuByid_CurrEduClsInDiv)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_id_StuByid_CurrEduClsInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_id_StuByid_CurrEduClsInDiv_Cache");
        let arrObjLst_Sel = await (0, clsCurrEduClsStuWApi_js_1.CurrEduClsStu_GetObjLst_Cache)(strid_CurrEduCls);
        if (arrObjLst_Sel == null)
            return;
        arrObjLst_Sel = arrObjLst_Sel.filter(x => x.id_CurrEduCls == strid_CurrEduCls);
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsCurrEduClsStuEN_js_1.clsCurrEduClsStuEN.con_id_Stu, clsCurrEduClsStuENEx_js_1.clsCurrEduClsStuENEx.con_StuName, "教学班与学生关系");
    }
    exports.CurrEduClsStu_BindDdl_id_StuByid_CurrEduClsInDivEx_Cache = CurrEduClsStu_BindDdl_id_StuByid_CurrEduClsInDivEx_Cache;
    /**
    * 根据学生Id获取教学班流水号列表
    * (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
    * @param strStuId: 学号
    * @returns 获取的相应对象列表
    */
    async function CurrEduClsStuEx_Getid_CurrEduClsListByStuId(strStuId) {
        const strThisFuncName = "Getid_CurrEduClsListByStuId";
        var strAction = "Getid_CurrEduClsListByStuId";
        let strUrl = CurrEduClsStuEx_GetWebApiUrl(exports.currEduClsStuEx_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strStuId": strStuId }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduClsStuEx_Controller, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = returnObjLst;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsStuEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsStuEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsStuEx_Getid_CurrEduClsListByStuId = CurrEduClsStuEx_Getid_CurrEduClsListByStuId;
    /**
    * 根据教学班流水号获取学生Id列表
    * (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
    * @param strId_CurrEduCls: 教学班流水号
    * @returns 获取的相应对象列表
    */
    async function CurrEduClsStuEx_GetStuIDLstById_CurrEduCls(strId_CurrEduCls) {
        const strThisFuncName = "GetStuIDLstById_CurrEduCls";
        var strAction = "GetStuIDLstById_CurrEduCls";
        let strUrl = CurrEduClsStuEx_GetWebApiUrl(exports.currEduClsStuEx_Controller, strAction);
        //var mapParam: Dictionary = new Dictionary();
        //mapParam.add("strId_CurrEduCls", strId_CurrEduCls);
        //let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strId_CurrEduCls": strId_CurrEduCls }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.currEduClsStuEx_Controller, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = returnObjLst;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.currEduClsStuEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.currEduClsStuEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CurrEduClsStuEx_GetStuIDLstById_CurrEduCls = CurrEduClsStuEx_GetStuIDLstById_CurrEduCls;
    /**
    * 绑定基于Web的下拉框
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
    * @param objDDL:需要绑定当前表的下拉框
    */
    async function CurrEduClsStuEx_BindDdl_id_CurrEduClsByStuIdInDiv_Cache(strDivName, strDdlName, strStuId) {
        const strCourseId = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_id_CurrEduClsInDiv_Cache)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_id_CurrEduClsInDiv_Cache");
        const arrObjLst_Sel = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetObjLst_Cache)(strCourseId);
        const arrId_CurrEduClsLst = await CurrEduClsStuEx_Getid_CurrEduClsListByStuId(strStuId);
        const arrObjLst_Sel2 = arrObjLst_Sel.filter(x => arrId_CurrEduClsLst.indexOf(x.id_CurrEduCls) > -1);
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel2, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CurrEduCls, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsName, "教学班");
    }
    exports.CurrEduClsStuEx_BindDdl_id_CurrEduClsByStuIdInDiv_Cache = CurrEduClsStuEx_BindDdl_id_CurrEduClsByStuIdInDiv_Cache;
});
