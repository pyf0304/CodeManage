/**
* 类名:clsgs_PConcepRelaExWApi
* 表名:gs_PConcepRela(01120670)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/05 01:04:01
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/GraduateEduPaper/clsgs_PConcepRelaENEx.js", "../../L3_ForWApi/GraduateEduPaper/clsgs_PConcepRelaWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L3_ForWApi/GraduateEduPaper/clsgs_PConcepRelaWApi.js", "../../L0_Entity/GraduateEduPaper/clsgs_PConcepRelaEN.js", "../../PubFun/clsString.js", "../../L3_ForWApi/GraduateEduPaper/clsgs_PConcepRelaWApi.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PConcepRelaEx_FilterFunByKey = exports.gs_PConcepRelaEx_FuncMapByFldName = exports.gs_PConcepRelaEx_SortFunByKey = exports.gs_PConcepRelaEx_GetObjExLstByPagerAsync = exports.gs_PConcepRelaEx_CopyToEx = exports.gs_PConcepRelaEx_GetWebApiUrl = exports.gs_PConcepRelaEx_ConstructorName = exports.gs_PConcepRelaEx_Controller = void 0;
    /**
    * 论文概念关系(gs_PConcepRela)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
   * Created by pyf on 2022年11月05日.
   * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsgs_PConcepRelaENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PConcepRelaENEx.js");
    const clsgs_PConcepRelaWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsgs_PConcepRelaWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsgs_PConcepRelaWApi_js_2 = require("../../L3_ForWApi/GraduateEduPaper/clsgs_PConcepRelaWApi.js");
    const clsgs_PConcepRelaEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PConcepRelaEN.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsgs_PConcepRelaWApi_js_3 = require("../../L3_ForWApi/GraduateEduPaper/clsgs_PConcepRelaWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    exports.gs_PConcepRelaEx_Controller = "gs_PConcepRelaExApi";
    exports.gs_PConcepRelaEx_ConstructorName = "gs_PConcepRelaEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function gs_PConcepRelaEx_GetWebApiUrl(strController, strAction) {
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
    exports.gs_PConcepRelaEx_GetWebApiUrl = gs_PConcepRelaEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objgs_PConcepRelaENS:源对象
    * @returns 目标对象=>clsgs_PConcepRelaEN:objgs_PConcepRelaENT
    **/
    function gs_PConcepRelaEx_CopyToEx(objgs_PConcepRelaENS) {
        const strThisFuncName = gs_PConcepRelaEx_CopyToEx.name;
        const objgs_PConcepRelaENT = new clsgs_PConcepRelaENEx_js_1.clsgs_PConcepRelaENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PConcepRelaENT, objgs_PConcepRelaENS);
            return objgs_PConcepRelaENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.gs_PConcepRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objgs_PConcepRelaENT;
        }
    }
    exports.gs_PConcepRelaEx_CopyToEx = gs_PConcepRelaEx_CopyToEx;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_PConcepRelaEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrgs_PConcepRelaObjLst = await (0, clsgs_PConcepRelaWApi_js_1.gs_PConcepRela_GetObjLstAsync)(objPagerPara.whereCond);
        const arrgs_PConcepRelaExObjLst = arrgs_PConcepRelaObjLst.map(gs_PConcepRelaEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrgs_PConcepRelaExObjLst) {
                const conFuncMap = await gs_PConcepRelaEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrgs_PConcepRelaExObjLst.length == 0)
            return arrgs_PConcepRelaExObjLst;
        let arrgs_PConcepRela_Sel = arrgs_PConcepRelaExObjLst;
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
                arrgs_PConcepRela_Sel = arrgs_PConcepRela_Sel.sort(gs_PConcepRelaEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_PConcepRela_Sel = arrgs_PConcepRela_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_PConcepRela_Sel = arrgs_PConcepRela_Sel.slice(intStart, intEnd);
            return arrgs_PConcepRela_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_PConcepRelaEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_PConcepRelaEx_GetObjExLstByPagerAsync = gs_PConcepRelaEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PConcepRelaEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsgs_PConcepRelaWApi_js_2.gs_PConcepRela_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsgs_PConcepRelaWApi_js_2.gs_PConcepRela_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.gs_PConcepRelaEx_SortFunByKey = gs_PConcepRelaEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function gs_PConcepRelaEx_FuncMapByFldName(strFldName, objgs_PConcepRelaEx) {
        const strThisFuncName = gs_PConcepRelaEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsgs_PConcepRelaEN_js_1.clsgs_PConcepRelaEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.gs_PConcepRelaEx_FuncMapByFldName = gs_PConcepRelaEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_PConcepRelaEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsgs_PConcepRelaWApi_js_3.gs_PConcepRela_FilterFunByKey)(strKey, value);
        }
    }
    exports.gs_PConcepRelaEx_FilterFunByKey = gs_PConcepRelaEx_FilterFunByKey;
});
