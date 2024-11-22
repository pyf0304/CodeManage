(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/DailyRunning/clsvCurrEduClsTeacherEN.js", "../../L0_Entity/DailyRunning/clsvCurrEduClsTeacherENEx.js", "../../L3_ForWApi/DailyRunning/clsvCurrEduClsTeacherWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vCurrEduClsTeacherEx_SortFun_OrderNum = exports.vCurrEduClsTeacherEx_FilterFunByKey = exports.vCurrEduClsTeacherEx_FuncMapByFldName = exports.vCurrEduClsTeacherEx_SortFunByKey = exports.vCurrEduClsTeacherEx_GetObjExLstByPagerAsync = exports.vCurrEduClsTeacherEx_GetObjExLstByPager_Cache = exports.vCurrEduClsTeacherEx_CopyToEx = exports.vCurrEduClsTeacherEx_GetWebApiUrl = exports.vCurrEduClsTeacherEx_ConstructorName = exports.vCurrEduClsTeacherEx_Controller = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:clsvCurrEduClsTeacherExWApi
    表名:vCurrEduClsTeacher(01120128)
    生成代码版本:2021.06.06.1
    生成日期:2021/06/11 17:38:10
    生成者:pyf
    生成服务器IP:103.116.76.183
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:日常运行
    模块英文名:DailyRunning
    框架-层名:WA_访问扩展层(WA_AccessEx)
    编程语言:TypeScript
    注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
           2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
    == == == == == == == == == == == ==
    */
    //import * as QQ from "q";
    const clsvCurrEduClsTeacherEN_js_1 = require("../../L0_Entity/DailyRunning/clsvCurrEduClsTeacherEN.js");
    const clsvCurrEduClsTeacherENEx_js_1 = require("../../L0_Entity/DailyRunning/clsvCurrEduClsTeacherENEx.js");
    const clsvCurrEduClsTeacherWApi_js_1 = require("../../L3_ForWApi/DailyRunning/clsvCurrEduClsTeacherWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    exports.vCurrEduClsTeacherEx_Controller = "vCurrEduClsTeacherExApi";
    exports.vCurrEduClsTeacherEx_ConstructorName = "vCurrEduClsTeacherEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vCurrEduClsTeacherEx_GetWebApiUrl(strController, strAction) {
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
    exports.vCurrEduClsTeacherEx_GetWebApiUrl = vCurrEduClsTeacherEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvCurrEduClsTeacherENS:源对象
    * @returns 目标对象=>clsvCurrEduClsTeacherEN:objvCurrEduClsTeacherENT
    **/
    function vCurrEduClsTeacherEx_CopyToEx(objvCurrEduClsTeacherENS) {
        const strThisFuncName = vCurrEduClsTeacherEx_CopyToEx.name;
        const objvCurrEduClsTeacherENT = new clsvCurrEduClsTeacherENEx_js_1.clsvCurrEduClsTeacherENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvCurrEduClsTeacherENT, objvCurrEduClsTeacherENS);
            return objvCurrEduClsTeacherENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vCurrEduClsTeacherEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvCurrEduClsTeacherENT;
        }
    }
    exports.vCurrEduClsTeacherEx_CopyToEx = vCurrEduClsTeacherEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vCurrEduClsTeacherEx_GetObjExLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvCurrEduClsTeacherObjLst = await (0, clsvCurrEduClsTeacherWApi_js_1.vCurrEduClsTeacher_GetObjLst_Cache)(strid_CurrEduCls);
        const arrvCurrEduClsTeacherExObjLst = arrvCurrEduClsTeacherObjLst.map(vCurrEduClsTeacherEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvCurrEduClsTeacherExObjLst) {
                const conFuncMap = await vCurrEduClsTeacherEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvCurrEduClsTeacherExObjLst.length == 0)
            return arrvCurrEduClsTeacherExObjLst;
        let arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacherExObjLst;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvCurrEduClsTeacher_Cond = new clsvCurrEduClsTeacherENEx_js_1.clsvCurrEduClsTeacherENEx();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvCurrEduClsTeacher_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvCurrEduClsTeacherWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduClsTeacher_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.split(',');
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvCurrEduClsTeacher_Sel.length == 0)
                return arrvCurrEduClsTeacher_Sel;
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
                arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.sort(vCurrEduClsTeacherEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.sort(objPagerPara.sortFun);
            }
            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.slice(intStart, intEnd);
            return arrvCurrEduClsTeacher_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vCurrEduClsTeacherEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vCurrEduClsTeacherEx_GetObjExLstByPager_Cache = vCurrEduClsTeacherEx_GetObjExLstByPager_Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vCurrEduClsTeacherEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvCurrEduClsTeacherExObjLst = await (0, clsvCurrEduClsTeacherWApi_js_1.vCurrEduClsTeacher_GetObjLstAsync)(objPagerPara.whereCond);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvCurrEduClsTeacherExObjLst) {
                const conFuncMap = await vCurrEduClsTeacherEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvCurrEduClsTeacherExObjLst.length == 0)
            return arrvCurrEduClsTeacherExObjLst;
        let arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacherExObjLst;
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
                arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.sort(vCurrEduClsTeacherEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.sort(objPagerPara.sortFun);
            }
            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.slice(intStart, intEnd);
            return arrvCurrEduClsTeacher_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vCurrEduClsTeacherEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vCurrEduClsTeacherEx_GetObjExLstByPagerAsync = vCurrEduClsTeacherEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vCurrEduClsTeacherEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsvCurrEduClsTeacherWApi_js_1.vCurrEduClsTeacher_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsvCurrEduClsTeacherWApi_js_1.vCurrEduClsTeacher_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vCurrEduClsTeacherEx_SortFunByKey = vCurrEduClsTeacherEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vCurrEduClsTeacherEx_FuncMapByFldName(strFldName, objvCurrEduClsTeacherEx) {
        const strThisFuncName = vCurrEduClsTeacherEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vCurrEduClsTeacherEx_FuncMapByFldName = vCurrEduClsTeacherEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vCurrEduClsTeacherEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsvCurrEduClsTeacherWApi_js_1.vCurrEduClsTeacher_FilterFunByKey)(strKey, value);
        }
    }
    exports.vCurrEduClsTeacherEx_FilterFunByKey = vCurrEduClsTeacherEx_FilterFunByKey;
    /**
    * 排序函数。根据orderNum字段的值进行比较
    * 作者:pyf
    * 日期:2021-10-20
    * @param a:比较的第1个对象
    * @param  b:比较的第1个对象
    * @returns 返回两个对象比较的结果
    */
    function vCurrEduClsTeacherEx_SortFun_OrderNum(a, b) {
        const strThisFuncName = vCurrEduClsTeacherEx_SortFun_OrderNum.name;
        console.log('strThisFuncName', strThisFuncName);
        if (a.orderNum == null)
            return 1;
        if (b.orderNum == null)
            return 1;
        const strA = a.orderNum.toString();
        const strB = b.orderNum.toString();
        const intA = Number(strA);
        const intB = Number(strB);
        let intResult = intA - intB;
        return intResult;
    }
    exports.vCurrEduClsTeacherEx_SortFun_OrderNum = vCurrEduClsTeacherEx_SortFun_OrderNum;
});
