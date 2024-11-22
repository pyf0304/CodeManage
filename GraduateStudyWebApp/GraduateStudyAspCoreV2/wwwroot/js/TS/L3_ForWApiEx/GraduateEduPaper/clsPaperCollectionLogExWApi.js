(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/GraduateEduPaper/clsPaperCollectionLogENEx.js", "../../L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js", "../../L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js", "../../PubFun/clsString.js", "../../L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js", "../../PubConfig/clsSysPara4WebApi.js", "../../FunClass_Share/clsPubFun4Web.js", "../../L0_Entity/GraduateEduPaper/clsPaperEN.js", "../../L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../../PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperCollectionLogEx_btnAddCollection_Click = exports.PaperCollectionLogEx_FilterFunByKey = exports.PaperCollectionLogEx_FuncMapByFldName = exports.PaperCollectionLogEx_SortFunByKey = exports.PaperCollectionLogEx_GetObjExLstByPagerAsync = exports.PaperCollectionLogEx_CopyToEx = exports.PaperCollectionLogEx_GetWebApiUrl = exports.paperCollectionLogEx_ConstructorName = exports.paperCollectionLogEx_Controller = void 0;
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsPaperCollectionLogENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperCollectionLogENEx.js");
    const clsPaperCollectionLogWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsPaperCollectionLogWApi_js_2 = require("../../L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js");
    const clsPaperCollectionLogEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperCollectionLogEN.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsPaperCollectionLogWApi_js_3 = require("../../L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsPubFun4Web_js_1 = require("../../FunClass_Share/clsPubFun4Web.js");
    const clsPaperEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsPaperWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsPublocalStorage_js_1 = require("../../PubFun/clsPublocalStorage.js");
    exports.paperCollectionLogEx_Controller = "PaperCollectionLogExApi";
    exports.paperCollectionLogEx_ConstructorName = "paperCollectionLogEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function PaperCollectionLogEx_GetWebApiUrl(strController, strAction) {
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
    exports.PaperCollectionLogEx_GetWebApiUrl = PaperCollectionLogEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objPaperCollectionLogENS:源对象
    * @returns 目标对象=>clsPaperCollectionLogEN:objPaperCollectionLogENT
    **/
    function PaperCollectionLogEx_CopyToEx(objPaperCollectionLogENS) {
        const strThisFuncName = PaperCollectionLogEx_CopyToEx.name;
        const objPaperCollectionLogENT = new clsPaperCollectionLogENEx_js_1.clsPaperCollectionLogENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperCollectionLogENT, objPaperCollectionLogENS);
            return objPaperCollectionLogENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.paperCollectionLogEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objPaperCollectionLogENT;
        }
    }
    exports.PaperCollectionLogEx_CopyToEx = PaperCollectionLogEx_CopyToEx;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function PaperCollectionLogEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrPaperCollectionLogObjLst = await (0, clsPaperCollectionLogWApi_js_1.PaperCollectionLog_GetObjLstAsync)(objPagerPara.whereCond);
        const arrPaperCollectionLogExObjLst = arrPaperCollectionLogObjLst.map(PaperCollectionLogEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrPaperCollectionLogExObjLst) {
                const conFuncMap = await PaperCollectionLogEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrPaperCollectionLogExObjLst.length == 0)
            return arrPaperCollectionLogExObjLst;
        let arrPaperCollectionLog_Sel = arrPaperCollectionLogExObjLst;
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
                arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.sort(PaperCollectionLogEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.sort(objPagerPara.sortFun);
            }
            arrPaperCollectionLog_Sel = arrPaperCollectionLog_Sel.slice(intStart, intEnd);
            return arrPaperCollectionLog_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.paperCollectionLogEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperCollectionLogEx_GetObjExLstByPagerAsync = PaperCollectionLogEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperCollectionLogEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsPaperCollectionLogWApi_js_2.PaperCollectionLog_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsPaperCollectionLogWApi_js_2.PaperCollectionLog_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.PaperCollectionLogEx_SortFunByKey = PaperCollectionLogEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function PaperCollectionLogEx_FuncMapByFldName(strFldName, objPaperCollectionLogEx) {
        const strThisFuncName = PaperCollectionLogEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.PaperCollectionLogEx_FuncMapByFldName = PaperCollectionLogEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function PaperCollectionLogEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsPaperCollectionLogWApi_js_3.PaperCollectionLog_FilterFunByKey)(strKey, value);
        }
    }
    exports.PaperCollectionLogEx_FilterFunByKey = PaperCollectionLogEx_FilterFunByKey;
    //添加收藏
    async function PaperCollectionLogEx_btnAddCollection_Click(strPaperId, strUpdUser) {
        const strThisFuncName = PaperCollectionLogEx_btnAddCollection_Click.name;
        var objPaperCollectionLogEN = new clsPaperCollectionLogEN_js_1.clsPaperCollectionLogEN();
        objPaperCollectionLogEN.SetPaperId(strPaperId);
        objPaperCollectionLogEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
        objPaperCollectionLogEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
        var strWhereCond = " updUser='" + objPaperCollectionLogEN.updUser + "' and paperId=" + strPaperId;
        try {
            const bolIsExist = await (0, clsPaperCollectionLogWApi_js_1.PaperCollectionLog_IsExistRecordAsync)(strWhereCond);
            if (bolIsExist == true) {
                var strMsg = `您已经收藏过这条论文了！`;
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            const returnBool = await (0, clsPaperCollectionLogWApi_js_1.PaperCollectionLog_AddNewRecordAsync)(objPaperCollectionLogEN);
            if (returnBool == true) {
                (0, clsPaperCollectionLogWApi_js_1.PaperCollectionLog_ReFreshCache)(strUpdUser);
                var strWhereCond2 = " paperId=" + strPaperId;
                var intCollectionCount = await (0, clsPaperCollectionLogWApi_js_1.PaperCollectionLog_GetRecCountByCondAsync)(strWhereCond2);
                var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
                objPaperEN.SetPaperId(strPaperId);
                objPaperEN.SetCollectionCount(intCollectionCount);
                objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
                if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                    throw (0, clsString_js_2.Format)("关键字不能为空!(in {0}.{1})", exports.paperCollectionLogEx_ConstructorName, strThisFuncName);
                }
                var returnBool2 = await (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN);
                if (returnBool2 == true) {
                    //this.BindGv_Paper00();
                    return true;
                }
                else {
                    var strInfo = `收藏不成功!`;
                    alert(strInfo);
                    console.log("收藏不成功");
                    return false;
                }
            }
            else {
                var strInfo = `收藏不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                //this.BindGv_vPaperSubViewpoint();
                return false;
            }
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg = `收藏不成功,${e}.`;
            alert(strMsg);
            return false;
        }
    }
    exports.PaperCollectionLogEx_btnAddCollection_Click = PaperCollectionLogEx_btnAddCollection_Click;
});
