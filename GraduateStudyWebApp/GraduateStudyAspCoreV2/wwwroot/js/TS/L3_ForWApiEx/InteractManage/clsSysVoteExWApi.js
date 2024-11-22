(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsCommFunc4Web.js", "../../L0_Entity/InteractManage/clsSysVoteENEx.js", "../../L3_ForWApi/InteractManage/clsSysVoteWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsString.js", "../../L3_ForWApi/InteractManage/clsSysVoteWApi.js", "../../L0_Entity/InteractManage/clsSysVoteEN.js", "../../PubFun/clsString.js", "../../L3_ForWApi/InteractManage/clsSysVoteWApi.js", "../../PubConfig/clsSysPara4WebApi.js", "../../FunClass_Share/clsPubFun4Web.js", "../../L0_Entity/GraduateEduPaper/clsPaperEN.js", "../../L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../../PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysVoteEx_btnAddVote_Click_PaperId = exports.SysVoteEx_FilterFunByKey = exports.SysVoteEx_FuncMapByFldName = exports.SysVoteEx_SortFunByKey = exports.SysVoteEx_GetObjExLstByPagerAsync = exports.SysVoteEx_CopyToEx = exports.SysVoteEx_GetWebApiUrl = exports.sysVoteEx_ConstructorName = exports.sysVoteEx_Controller = void 0;
    //import $ from "jquery";
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysVoteENEx_js_1 = require("../../L0_Entity/InteractManage/clsSysVoteENEx.js");
    const clsSysVoteWApi_js_1 = require("../../L3_ForWApi/InteractManage/clsSysVoteWApi.js");
    const clsCommFunc4Web_js_2 = require("../../PubFun/clsCommFunc4Web.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysVoteWApi_js_2 = require("../../L3_ForWApi/InteractManage/clsSysVoteWApi.js");
    const clsSysVoteEN_js_1 = require("../../L0_Entity/InteractManage/clsSysVoteEN.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    const clsSysVoteWApi_js_3 = require("../../L3_ForWApi/InteractManage/clsSysVoteWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsPubFun4Web_js_1 = require("../../FunClass_Share/clsPubFun4Web.js");
    const clsPaperEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsPaperWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsPublocalStorage_js_1 = require("../../PubFun/clsPublocalStorage.js");
    exports.sysVoteEx_Controller = "SysVoteExApi";
    exports.sysVoteEx_ConstructorName = "sysVoteEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function SysVoteEx_GetWebApiUrl(strController, strAction) {
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
    exports.SysVoteEx_GetWebApiUrl = SysVoteEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objSysVoteENS:源对象
    * @returns 目标对象=>clsSysVoteEN:objSysVoteENT
    **/
    function SysVoteEx_CopyToEx(objSysVoteENS) {
        const strThisFuncName = SysVoteEx_CopyToEx.name;
        const objSysVoteENT = new clsSysVoteENEx_js_1.clsSysVoteENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysVoteENT, objSysVoteENS);
            return objSysVoteENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.sysVoteEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objSysVoteENT;
        }
    }
    exports.SysVoteEx_CopyToEx = SysVoteEx_CopyToEx;
    //该表在前台TypeScript中，不需要使用Cache;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function SysVoteEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrSysVoteObjLst = await (0, clsSysVoteWApi_js_1.SysVote_GetObjLstAsync)(objPagerPara.whereCond);
        const arrSysVoteExObjLst = arrSysVoteObjLst.map(SysVoteEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_2.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrSysVoteExObjLst) {
                const conFuncMap = await SysVoteEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrSysVoteExObjLst.length == 0)
            return arrSysVoteExObjLst;
        let arrSysVote_Sel = arrSysVoteExObjLst;
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
                arrSysVote_Sel = arrSysVote_Sel.sort(SysVoteEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrSysVote_Sel = arrSysVote_Sel.sort(objPagerPara.sortFun);
            }
            arrSysVote_Sel = arrSysVote_Sel.slice(intStart, intEnd);
            return arrSysVote_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sysVoteEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysVoteEx_GetObjExLstByPagerAsync = SysVoteEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysVoteEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                default:
                    return (0, clsSysVoteWApi_js_2.SysVote_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                default:
                    return (0, clsSysVoteWApi_js_2.SysVote_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.SysVoteEx_SortFunByKey = SysVoteEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function SysVoteEx_FuncMapByFldName(strFldName, objSysVoteEx) {
        const strThisFuncName = SysVoteEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsSysVoteEN_js_1.clsSysVoteEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            default:
                strMsg = (0, clsString_js_2.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.SysVoteEx_FuncMapByFldName = SysVoteEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-05
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SysVoteEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsSysVoteWApi_js_3.SysVote_FilterFunByKey)(strKey, value);
        }
    }
    exports.SysVoteEx_FilterFunByKey = SysVoteEx_FilterFunByKey;
    async function SysVoteEx_btnAddVote_Click_PaperId(strPaperId, strUserId, strLikedUserId) {
        const strThisFuncName = SysVoteEx_btnAddVote_Click_PaperId.name;
        //this.DivName = "divAddNewRecordSave";
        var objSysVoteEN = new clsSysVoteEN_js_1.clsSysVoteEN();
        //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
        objSysVoteEN.SetTableKey(strPaperId);
        objSysVoteEN.SetVoteTypeId("01");
        objSysVoteEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
        objSysVoteEN.SetUpdUser(strUserId); // 修改用户Id
        objSysVoteEN.SetLikedUserId(strUserId); //被点赞用户
        objSysVoteEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
        var strWhereCond = " 1 =1 and updUser='" + strUserId + "' and tableKey=" + strPaperId;
        try {
            const responseText = await (0, clsSysVoteWApi_js_1.SysVote_IsExistRecordAsync)(strWhereCond);
            var bolIsExist = responseText;
            if (bolIsExist == true) {
                var strMsg = `您已经点赞过这条论文了，请给其他论文点赞一下吧！`;
                alert(strMsg);
                return responseText; //一定要有一个返回值，否则会出错！
            }
            const returnBool = await (0, clsSysVoteWApi_js_1.SysVote_AddNewRecordAsync)(objSysVoteEN);
            if (returnBool == true) {
                (0, clsSysVoteWApi_js_1.SysVote_ReFreshCache)(clsPublocalStorage_js_1.clsPublocalStorage.userId);
                var strWhereCond2 = " 1=1 and voteTypeId='01' and tableKey=" + strPaperId;
                var intVoteCount = await (0, clsSysVoteWApi_js_1.SysVote_GetRecCountByCondAsync)(strWhereCond2);
                var objPaperEN = new clsPaperEN_js_1.clsPaperEN();
                objPaperEN.SetPaperId(strPaperId);
                objPaperEN.SetOkCount(intVoteCount);
                objPaperEN.sf_UpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
                if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                    throw (0, clsString_js_2.Format)("关键字不能为空!(in {0}.{1})", exports.sysVoteEx_ConstructorName, strThisFuncName);
                }
                var returnBool1 = await (0, clsPaperWApi_js_1.Paper_UpdateRecordAsync)(objPaperEN);
                if (returnBool1 == true) {
                    //const gvResult = await this.BindGv_Paper();
                    return returnBool;
                }
                else {
                    var strInfo = `点赞不成功!`;
                    alert(strInfo);
                    console.log("点赞不成功");
                    return false;
                }
            }
            else {
                var strInfo = `点赞不成功!`;
                $('#lblResult40').val(strInfo);
                //显示信息框
                alert(strInfo);
                //this.DetailRecord();
                //this.BindGv_vPaperSubViewpoint();
            }
            return returnBool; //一定要有一个返回值，否则会出错！
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg = `点赞不成功,${e}.`;
            alert(strMsg);
            return false;
        }
        return false; //一定要有一个返回值，否则会出错！
    }
    exports.SysVoteEx_btnAddVote_Click_PaperId = SysVoteEx_btnAddVote_Click_PaperId;
});
