/**
* 类名:clsvcc_CourseKnowledgesExWApi
* 表名:vcc_CourseKnowledges(01120141)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/05 01:02:57
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
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
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/Knowledges_Share/clsvcc_CourseKnowledgesENEx.js", "../../L3_ForWApi/Knowledges_Share/clsvcc_CourseKnowledgesWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L3_ForWApi/Knowledges_Share/clsvcc_CourseKnowledgesWApi.js", "../../L0_Entity/Knowledges_Share/clsvcc_CourseKnowledgesEN.js", "../../PubFun/clsString.js", "../../L3_ForWApi/Knowledges_Share/clsvcc_CourseKnowledgesWApi.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vcc_CourseKnowledgesEx_FilterFunByKey = exports.vcc_CourseKnowledgesEx_FuncMapByFldName = exports.vcc_CourseKnowledgesEx_SortFunByKey = exports.vcc_CourseKnowledgesEx_GetObjExLstByPagerAsync = exports.vcc_CourseKnowledgesEx_CopyToEx = exports.vcc_CourseKnowledgesEx_GetWebApiUrl = exports.vcc_CourseKnowledgesEx_ConstructorName = exports.vcc_CourseKnowledgesEx_Controller = void 0;
    /**
    * v课程知识点(vcc_CourseKnowledges)
    * (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
   * Created by pyf on 2022年11月05日.
   * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    **/
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsvcc_CourseKnowledgesENEx_js_1 = require("../../L0_Entity/Knowledges_Share/clsvcc_CourseKnowledgesENEx.js");
    const clsvcc_CourseKnowledgesWApi_js_1 = require("../../L3_ForWApi/Knowledges_Share/clsvcc_CourseKnowledgesWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsvcc_CourseKnowledgesWApi_js_2 = require("../../L3_ForWApi/Knowledges_Share/clsvcc_CourseKnowledgesWApi.js");
    const clsvcc_CourseKnowledgesEN_js_1 = require("../../L0_Entity/Knowledges_Share/clsvcc_CourseKnowledgesEN.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsvcc_CourseKnowledgesWApi_js_3 = require("../../L3_ForWApi/Knowledges_Share/clsvcc_CourseKnowledgesWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    exports.vcc_CourseKnowledgesEx_Controller = "vcc_CourseKnowledgesExApi";
    exports.vcc_CourseKnowledgesEx_ConstructorName = "vcc_CourseKnowledgesEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function vcc_CourseKnowledgesEx_GetWebApiUrl(strController, strAction) {
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
    exports.vcc_CourseKnowledgesEx_GetWebApiUrl = vcc_CourseKnowledgesEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objvcc_CourseKnowledgesENS:源对象
    * @returns 目标对象=>clsvcc_CourseKnowledgesEN:objvcc_CourseKnowledgesENT
    **/
    function vcc_CourseKnowledgesEx_CopyToEx(objvcc_CourseKnowledgesENS) {
        const strThisFuncName = vcc_CourseKnowledgesEx_CopyToEx.name;
        const objvcc_CourseKnowledgesENT = new clsvcc_CourseKnowledgesENEx_js_1.clsvcc_CourseKnowledgesENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objvcc_CourseKnowledgesENT, objvcc_CourseKnowledgesENS);
            return objvcc_CourseKnowledgesENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.vcc_CourseKnowledgesEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objvcc_CourseKnowledgesENT;
        }
    }
    exports.vcc_CourseKnowledgesEx_CopyToEx = vcc_CourseKnowledgesEx_CopyToEx;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vcc_CourseKnowledgesEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrvcc_CourseKnowledgesObjLst = await (0, clsvcc_CourseKnowledgesWApi_js_1.vcc_CourseKnowledges_GetObjLstAsync)(objPagerPara.whereCond);
        const arrvcc_CourseKnowledgesExObjLst = arrvcc_CourseKnowledgesObjLst.map(vcc_CourseKnowledgesEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrvcc_CourseKnowledgesExObjLst) {
                const conFuncMap = await vcc_CourseKnowledgesEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrvcc_CourseKnowledgesExObjLst.length == 0)
            return arrvcc_CourseKnowledgesExObjLst;
        let arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledgesExObjLst;
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
                arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.sort(vcc_CourseKnowledgesEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.sort(objPagerPara.sortFun);
            }
            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.slice(intStart, intEnd);
            return arrvcc_CourseKnowledges_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vcc_CourseKnowledgesEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vcc_CourseKnowledgesEx_GetObjExLstByPagerAsync = vcc_CourseKnowledgesEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_CourseKnowledgesEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsvcc_CourseKnowledgesWApi_js_2.vcc_CourseKnowledges_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsvcc_CourseKnowledgesWApi_js_2.vcc_CourseKnowledges_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.vcc_CourseKnowledgesEx_SortFunByKey = vcc_CourseKnowledgesEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function vcc_CourseKnowledgesEx_FuncMapByFldName(strFldName, objvcc_CourseKnowledgesEx) {
        const strThisFuncName = vcc_CourseKnowledgesEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.vcc_CourseKnowledgesEx_FuncMapByFldName = vcc_CourseKnowledgesEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vcc_CourseKnowledgesEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsvcc_CourseKnowledgesWApi_js_3.vcc_CourseKnowledges_FilterFunByKey)(strKey, value);
        }
    }
    exports.vcc_CourseKnowledgesEx_FilterFunByKey = vcc_CourseKnowledgesEx_FilterFunByKey;
});
