/**
* 类名:clsMajorDirectionPaperRelaExWApi
* 表名:MajorDirectionPaperRela(01120554)
* 版本:2023.02.22.1(服务器:WIN-SRV103-116)
* 日期:2023/02/22 23:30:36
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培论文(GraduateEduPaper)
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaENEx.js", "../../L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js", "../../L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js", "../../PubFun/clsString.js", "../../L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsDateTime.js", "../../PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.MajorDirectionPaperRelaEx_SetMajorDirectionId = exports.MajorDirectionPaperRelaEx_FilterFunByKey = exports.MajorDirectionPaperRelaEx_FuncMapByFldName = exports.MajorDirectionPaperRelaEx_SortFunByKey = exports.MajorDirectionPaperRelaEx_GetObjExLstByPagerAsync = exports.MajorDirectionPaperRelaEx_CopyToEx = exports.MajorDirectionPaperRelaEx_GetWebApiUrl = exports.majorDirectionPaperRelaEx_ConstructorName = exports.majorDirectionPaperRelaEx_Controller = void 0;
    /**
    * 专业方向论文关系(MajorDirectionPaperRela)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
    * Created by pyf on 2023年02月22日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsMajorDirectionPaperRelaENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaENEx.js");
    const clsMajorDirectionPaperRelaWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsMajorDirectionPaperRelaWApi_js_2 = require("../../L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js");
    const clsMajorDirectionPaperRelaEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsMajorDirectionPaperRelaWApi_js_3 = require("../../L3_ForWApi/GraduateEduPaper/clsMajorDirectionPaperRelaWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsDateTime_js_1 = require("../../PubFun/clsDateTime.js");
    const clsPublocalStorage_js_1 = require("../../PubFun/clsPublocalStorage.js");
    exports.majorDirectionPaperRelaEx_Controller = "MajorDirectionPaperRelaExApi";
    exports.majorDirectionPaperRelaEx_ConstructorName = "majorDirectionPaperRelaEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function MajorDirectionPaperRelaEx_GetWebApiUrl(strController, strAction) {
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
    exports.MajorDirectionPaperRelaEx_GetWebApiUrl = MajorDirectionPaperRelaEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objMajorDirectionPaperRelaENS:源对象
    * @returns 目标对象=>clsMajorDirectionPaperRelaEN:objMajorDirectionPaperRelaENT
    **/
    function MajorDirectionPaperRelaEx_CopyToEx(objMajorDirectionPaperRelaENS) {
        const strThisFuncName = MajorDirectionPaperRelaEx_CopyToEx.name;
        const objMajorDirectionPaperRelaENT = new clsMajorDirectionPaperRelaENEx_js_1.clsMajorDirectionPaperRelaENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objMajorDirectionPaperRelaENT, objMajorDirectionPaperRelaENS);
            return objMajorDirectionPaperRelaENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.majorDirectionPaperRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objMajorDirectionPaperRelaENT;
        }
    }
    exports.MajorDirectionPaperRelaEx_CopyToEx = MajorDirectionPaperRelaEx_CopyToEx;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function MajorDirectionPaperRelaEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrMajorDirectionPaperRelaObjLst = await (0, clsMajorDirectionPaperRelaWApi_js_1.MajorDirectionPaperRela_GetObjLstAsync)(objPagerPara.whereCond);
        const arrMajorDirectionPaperRelaExObjLst = arrMajorDirectionPaperRelaObjLst.map(MajorDirectionPaperRelaEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrMajorDirectionPaperRelaExObjLst) {
                const conFuncMap = await MajorDirectionPaperRelaEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrMajorDirectionPaperRelaExObjLst.length == 0)
            return arrMajorDirectionPaperRelaExObjLst;
        let arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRelaExObjLst;
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
                arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.sort(MajorDirectionPaperRelaEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.sort(objPagerPara.sortFun);
            }
            arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.slice(intStart, intEnd);
            return arrMajorDirectionPaperRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.majorDirectionPaperRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.MajorDirectionPaperRelaEx_GetObjExLstByPagerAsync = MajorDirectionPaperRelaEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-22
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function MajorDirectionPaperRelaEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsMajorDirectionPaperRelaWApi_js_2.MajorDirectionPaperRela_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsMajorDirectionPaperRelaWApi_js_2.MajorDirectionPaperRela_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.MajorDirectionPaperRelaEx_SortFunByKey = MajorDirectionPaperRelaEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2023-02-22
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function MajorDirectionPaperRelaEx_FuncMapByFldName(strFldName, objMajorDirectionPaperRelaEx) {
        const strThisFuncName = MajorDirectionPaperRelaEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.MajorDirectionPaperRelaEx_FuncMapByFldName = MajorDirectionPaperRelaEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-02-22
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function MajorDirectionPaperRelaEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsMajorDirectionPaperRelaWApi_js_3.MajorDirectionPaperRela_FilterFunByKey)(strKey, value);
        }
    }
    exports.MajorDirectionPaperRelaEx_FilterFunByKey = MajorDirectionPaperRelaEx_FilterFunByKey;
    /** 设置字段值-MajorDirectionId
      * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetFieldValue)
      **/
    async function MajorDirectionPaperRelaEx_SetMajorDirectionId(arrPaperId, strMajorDirectionId) {
        const strThisFuncName = MajorDirectionPaperRelaEx_SetMajorDirectionId.name;
        if (strMajorDirectionId == null || strMajorDirectionId == "") {
            const strMsg = "请输入专业方向Id(MajorDirectionId)!";
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return "";
        }
        if (arrPaperId.length == 0) {
            const strMsg = "没有选择记录，不能设置字段值!";
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
            return "";
        }
        try {
            let intCount = 0;
            for (const strPaperId of arrPaperId) {
                const objMajorDirectionPaperRelaEN = new clsMajorDirectionPaperRelaEN_js_1.clsMajorDirectionPaperRelaEN();
                objMajorDirectionPaperRelaEN.SetMajorDirectionId(strMajorDirectionId);
                objMajorDirectionPaperRelaEN.SetPaperId(strPaperId);
                objMajorDirectionPaperRelaEN.SetUpdDate(clsDateTime_js_1.clsDateTime.getTodayDateTimeStr(0));
                objMajorDirectionPaperRelaEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId);
                const strCondition = (0, clsMajorDirectionPaperRelaWApi_js_1.MajorDirectionPaperRela_GetUniCondStr_MajorDirectionId_PaperId)(objMajorDirectionPaperRelaEN);
                try {
                    let returnExist = await (0, clsMajorDirectionPaperRelaWApi_js_1.MajorDirectionPaperRela_IsExistRecordAsync)(strCondition);
                    if (returnExist == true)
                        continue;
                    const returnBool = await (0, clsMajorDirectionPaperRelaWApi_js_1.MajorDirectionPaperRela_AddNewRecordAsync)(objMajorDirectionPaperRelaEN);
                    if (returnBool == true)
                        intCount++;
                }
                catch (e) {
                    const strMsg = (0, clsString_js_2.Format)("设置当前专业方向不成功,{0}.(in {1}.{2})", e, exports.majorDirectionPaperRelaEx_ConstructorName, strThisFuncName);
                    console.error(strMsg);
                    return;
                }
            }
            //console.log('完成！');
            if (intCount > 0) {
                const strInfo = (0, clsString_js_2.Format)("设置当前专业方向成功!共设置:[{0}]记录.", intCount);
                alert(strInfo);
                (0, clsMajorDirectionPaperRelaWApi_js_1.MajorDirectionPaperRela_ReFreshCache)(strMajorDirectionId);
            }
            else {
                const strInfo = (0, clsString_js_2.Format)("设置当前专业方向记录数为0!");
                //显示信息框
                alert(strInfo);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("设置当前专业方向不成功,{0}.(in {1}.{2})", e, exports.majorDirectionPaperRelaEx_ConstructorName, strThisFuncName);
            console.error("Error: ", strMsg);
            //console.trace();
            alert(strMsg);
        }
    }
    exports.MajorDirectionPaperRelaEx_SetMajorDirectionId = MajorDirectionPaperRelaEx_SetMajorDirectionId;
});
