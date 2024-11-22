var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "axios", "../../L0_Entity/BaseInfo_Share/clsXzMajorEN.js", "../../L0_Entity/GraduateEduPaper/clsPaperEN.js", "../../L0_Entity/GraduateEduPaper/clsPaperENEx.js", "../../L0_Entity/ParameterTable/clsgs_PaperTypeEN.js", "../../L0_Entity/ParameterTable/clsSysVoteTypeEN.js", "../../L0_Entity/UserManage_Share/clsUsersEN.js", "../../L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../../L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../../L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js", "../../L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../../L3_ForWApi/GraduateEduPaper/clsvPaperSimWApi.js", "../../L3_ForWApi/InteractManage/clsSysVoteWApi.js", "../../L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js", "../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsCommFunc4Ctrl.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsPublocalStorage.js", "../../PubFun/clsString.js", "../../PubFun/tzDictionary.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vPaperEx_GetObjLstByPagerById_CurrEduCls_Cache = exports.vPaperEx_GetRecCountByCondById_CurrEduCls_Cache = exports.vPaperEx_GetSubObjLstById_CurrEduCls_Cache = exports.vPaperEx_GetObjLstById_CurrEduCls_sessionStorage = exports.vPaperEx_GetObjLstById_CurrEduCls_localStorage = exports.vPaperEx_GetObjLstById_CurrEduCls_ClientCache = exports.vPaperEx_GetObjLstById_CurrEduCls_Cache = exports.PaperEx_ReFreshThisCacheById_CurrEduClsBakFromV = exports.vPaperEx_GetObjByPaperIdById_CurrEduCls_Cache = exports.vPaperEx_GetObjLstById_CurrEduCls = exports.vPaperEx_GetXzMajorBvPaperSim = exports.vPaperEx_XzMajorIsExist = exports.vPaperEx_XzMajorUniq = exports.vPaperEx_BindDdl_XzMajorInvSimPaper_Cache = exports.vPaperEx_GetUsersBvPaperSim = exports.vPaperEx_IsExist = exports.vPaperEx_uniq = exports.vPaperEx_BindDdl_UsersInvSimPaper_Cache = exports.vPaperEx_SynPaperStatisticsAsync = exports.PaperEx_GetUserNumObjLstAsync = exports.PaperEx_SynPaperStatisticsAsync = exports.PaperEx_ExtendFldFuncMap = exports.PaperEx_BindTab_Paper = exports.PaperEx_FuncMap_DS_Keyword = exports.PaperEx_FuncMap_DS_LiteratureSources = exports.PaperEx_FuncMap_DS_Periodical = exports.PaperEx_FuncMap_DS_Author = exports.PaperEx_BindList_Paper = exports.PaperEx_FuncMap_IsSysVote = exports.PaperEx_FuncMap_IsHasAttention = exports.PaperEx_FuncMap_IsCollection = exports.PaperEx_FuncMap_UpdUserName = exports.PaperEx_FuncMap_PaperTypeName = exports.PaperEx_GetObjLstByPagerById_CurrEduCls_Cache = exports.PaperEx_GetRecCountByCondById_CurrEduCls_Cache = exports.PaperEx_GetSubObjLstById_CurrEduCls_Cache = exports.PaperEx_GetObjLstById_CurrEduCls_sessionStorage = exports.PaperEx_GetObjLstById_CurrEduCls_localStorage = exports.PaperEx_GetObjLstById_CurrEduCls_ClientCache = exports.PaperEx_GetObjLstById_CurrEduCls_Cache = exports.PaperEx_ReFreshThisCacheById_CurrEduCls = exports.PaperEx_GetObjByPaperIdById_CurrEduCls_Cache = exports.PaperEx_GetObjLstById_CurrEduCls = exports.PaperEx_BindDdl_PaperIdInDivById_CurrEduCls_Cache = exports.PaperEx_FilterFunByKey = exports.PaperEx_FuncMapByFldName = exports.PaperEx_SortFunByKey = exports.PaperEx_GetObjExLstByPagerAsync = exports.PaperEx_CopyToEx = exports.PaperEx_GetWebApiUrl = exports.paperEx_ConstructorName = exports.paperEx_Controller = void 0;
    const axios_1 = __importDefault(require("axios"));
    const clsXzMajorEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsXzMajorEN.js");
    const clsPaperEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsPaperENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperENEx.js");
    const clsgs_PaperTypeEN_js_1 = require("../../L0_Entity/ParameterTable/clsgs_PaperTypeEN.js");
    const clsSysVoteTypeEN_js_1 = require("../../L0_Entity/ParameterTable/clsSysVoteTypeEN.js");
    const clsUsersEN_js_1 = require("../../L0_Entity/UserManage_Share/clsUsersEN.js");
    const clsvUsersSimEN_js_1 = require("../../L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsgs_PaperAttentionWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsPaperCollectionLogWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js");
    const clsPaperWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsvPaperSimWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsvPaperSimWApi.js");
    const clsSysVoteWApi_js_1 = require("../../L3_ForWApi/InteractManage/clsSysVoteWApi.js");
    const clsgs_PaperTypeWApi_js_1 = require("../../L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js");
    const clsvUsersSimWApi_js_1 = require("../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsCommFunc4Ctrl_js_1 = require("../../PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsPublocalStorage_js_1 = require("../../PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    exports.paperEx_Controller = "PaperExApi";
    exports.paperEx_ConstructorName = "paperEx";
    /**
    * 获取WebApi的地址
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
    * @returns 返回当前文件中Web服务的地址
    **/
    function PaperEx_GetWebApiUrl(strController, strAction) {
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
    exports.PaperEx_GetWebApiUrl = PaperEx_GetWebApiUrl;
    /**
    * 把同一个类的对象,复制到另一个对象
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    * @param objPaperENS:源对象
    * @returns 目标对象=>clsPaperEN:objPaperENT
    **/
    function PaperEx_CopyToEx(objPaperENS) {
        const strThisFuncName = PaperEx_CopyToEx.name;
        const objPaperENT = new clsPaperENEx_js_1.clsPaperENEx();
        try {
            (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperENT, objPaperENS);
            return objPaperENT;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, exports.paperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return objPaperENT;
        }
    }
    exports.PaperEx_CopyToEx = PaperEx_CopyToEx;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    //export async function PaperEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara): Promise<Array<clsPaperENEx>> {
    //    const strThisFuncName = "GetObjLstByPager_Cache";
    //    const arrPaperObjLst = await Paper_GetObjLst_Cache();
    //    const arrPaperExObjLst = arrPaperObjLst.map(PaperEx_CopyToEx);
    //    const objSortInfo = GetSortExpressInfo(objPagerPara);
    //    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
    //        for (const objInFor of arrPaperExObjLst) {
    //            const conFuncMap = await PaperEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
    //        }
    //    }
    //    if (arrPaperExObjLst.length == 0) return arrPaperExObjLst;
    //    let arrPaper_Sel: Array<clsPaperENEx> = arrPaperExObjLst;
    //    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    //    const objPaper_Cond = new clsPaperENEx();
    //    ObjectAssign(objPaper_Cond, obj_Cond);
    //    let dicFldComparisonOp: { [index: string]: string } = {};
    //    if (obj_Cond.sf_FldComparisonOp != "") {
    //        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    //    }
    //    //console.log("clsPaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //    //console.log(dicFldComparisonOp);
    //    try {
    //        const sstrKeys = GetObjKeys(obj_Cond);
    //        //console.log(sstrKeys);
    //        for (const strKey of sstrKeys) {
    //            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
    //            arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
    //            const strComparisonOp = dicFldComparisonOp[strKey];
    //            const strValue = objPaper_Cond.GetFldValue(strKey);
    //            const strType = typeof (strValue);
    //            switch (strType) {
    //                case "string":
    //                    if (strValue == null) continue;
    //                    if (strValue == "") continue;
    //                    if (strComparisonOp == "=") {
    //                        arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
    //                    }
    //                    else if (strComparisonOp == "like") {
    //                        arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
    //                    }
    //                    else if (strComparisonOp == "in") {
    //                        const arrValues = strValue.split(',');
    //                        arrPaper_Sel = arrPaper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
    //                    }
    //                    break;
    //                case "boolean":
    //                    if (strValue == null) continue;
    //                    if (strComparisonOp == "=") {
    //                        arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
    //                    }
    //                    break;
    //                case "number":
    //                    if (Number(strValue) == 0) continue;
    //                    if (strComparisonOp == "=") {
    //                        arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
    //                    }
    //                    else if (strComparisonOp == ">=") {
    //                        arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
    //                    }
    //                    else if (strComparisonOp == "<=") {
    //                        arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
    //                    }
    //                    else if (strComparisonOp == ">") {
    //                        arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
    //                    }
    //                    else if (strComparisonOp == "<") {
    //                        arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
    //                    }
    //                    break;
    //            }
    //        }
    //        if (arrPaper_Sel.length == 0) return arrPaper_Sel;
    //        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
    //        if (intStart <= 0) intStart = 0;
    //        const intEnd = intStart + objPagerPara.pageSize;
    //        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
    //            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
    //            let strSortType = "asc";
    //            const strSortFld = sstrSplit[0];
    //            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
    //            arrPaper_Sel = arrPaper_Sel.sort(PaperEx_SortFunByKey(strSortFld, strSortType));
    //        }
    //        else {
    //            //如果排序字段名[OrderBy]为空，就调用排序函数
    //            arrPaper_Sel = arrPaper_Sel.sort(objPagerPara.sortFun);
    //        }
    //        arrPaper_Sel = arrPaper_Sel.slice(intStart, intEnd);
    //        return arrPaper_Sel;
    //    }
    //    catch (e) {
    //        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, paperEx_ConstructorName, strThisFuncName);
    //        console.error(strMsg);
    //        throw new Error(strMsg);
    //    }
    //    return new Array<clsPaperENEx>();
    //}
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function PaperEx_GetObjExLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjExLstByPagerAsync";
        const arrPaperObjLst = await (0, clsPaperWApi_js_1.Paper_GetObjLstAsync)(objPagerPara.whereCond);
        const arrPaperExObjLst = arrPaperObjLst.map(PaperEx_CopyToEx);
        const objSortInfo = (0, clsCommFunc4Web_js_1.GetSortExpressInfo)(objPagerPara);
        if ((0, clsString_js_1.IsNullOrEmpty)(objSortInfo.SortFld) == false) {
            for (const objInFor of arrPaperExObjLst) {
                const conFuncMap = await PaperEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
            }
        }
        if (arrPaperExObjLst.length == 0)
            return arrPaperExObjLst;
        let arrPaper_Sel = arrPaperExObjLst;
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
                arrPaper_Sel = arrPaper_Sel.sort(PaperEx_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrPaper_Sel = arrPaper_Sel.sort(objPagerPara.sortFun);
            }
            arrPaper_Sel = arrPaper_Sel.slice(intStart, intEnd);
            return arrPaper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.paperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperEx_GetObjExLstByPagerAsync = PaperEx_GetObjExLstByPagerAsync;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:潘以锋
     * 日期:00-00-00
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperEx_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsPaperENEx_js_1.clsPaperENEx.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_PaperTypeName:
                    return (a, b) => {
                        return a.paperTypeName.localeCompare(b.paperTypeName);
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_IsSysVote:
                    return (a, b) => {
                        if (a.isSysVote == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_IsCollection:
                    return (a, b) => {
                        if (a.isCollection == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_IsHasAttention:
                    return (a, b) => {
                        if (a.isHasAttention == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_UpdUserName:
                    return (a, b) => {
                        return a.updUserName.localeCompare(b.updUserName);
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_DS_Author:
                    return (a, b) => {
                        return a.ds_Author.localeCompare(b.ds_Author);
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_DS_Periodical:
                    return (a, b) => {
                        return a.ds_Periodical.localeCompare(b.ds_Periodical);
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_DS_Keyword:
                    return (a, b) => {
                        return a.ds_Keyword.localeCompare(b.ds_Keyword);
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_DS_LiteratureSources:
                    return (a, b) => {
                        return a.ds_LiteratureSources.localeCompare(b.ds_LiteratureSources);
                    };
                default:
                    return (0, clsPaperWApi_js_1.Paper_SortFunByKey)(strKey, AscOrDesc);
            }
        }
        else {
            switch (strKey) {
                case clsPaperENEx_js_1.clsPaperENEx.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_PaperTypeName:
                    return (a, b) => {
                        return b.paperTypeName.localeCompare(a.paperTypeName);
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_IsSysVote:
                    return (a, b) => {
                        if (b.isSysVote == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_IsCollection:
                    return (a, b) => {
                        if (b.isCollection == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_IsHasAttention:
                    return (a, b) => {
                        if (b.isHasAttention == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_UpdUserName:
                    return (a, b) => {
                        return b.updUserName.localeCompare(a.updUserName);
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_DS_Author:
                    return (a, b) => {
                        return b.ds_Author.localeCompare(a.ds_Author);
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_DS_Periodical:
                    return (a, b) => {
                        return b.ds_Periodical.localeCompare(a.ds_Periodical);
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_DS_Keyword:
                    return (a, b) => {
                        return b.ds_Keyword.localeCompare(a.ds_Keyword);
                    };
                case clsPaperENEx_js_1.clsPaperENEx.con_DS_LiteratureSources:
                    return (a, b) => {
                        return b.ds_LiteratureSources.localeCompare(a.ds_LiteratureSources);
                    };
                default:
                    return (0, clsPaperWApi_js_1.Paper_SortFunByKey)(strKey, AscOrDesc);
            }
        }
    }
    exports.PaperEx_SortFunByKey = PaperEx_SortFunByKey;
    /**
     * 根据扩展字段名去调用相应的映射函数
     * 作者:潘以锋
     * 日期:00-00-00
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
     * @param strFldName:扩展字段名
     * @param  obj{0}Ex:需要转换的对象
     * @returns 针对扩展字段名对转换对象进行函数映射
    */
    function PaperEx_FuncMapByFldName(strFldName, objPaperEx) {
        const strThisFuncName = PaperEx_FuncMapByFldName.name;
        let strMsg = "";
        //如果是本表中字段，不需要映射
        const arrFldName = clsPaperEN_js_1.clsPaperEN.AttributeName;
        if (arrFldName.indexOf(strFldName) > -1)
            return;
        //针对扩展字段进行映射
        switch (strFldName) {
            case clsPaperENEx_js_1.clsPaperENEx.con_PaperTypeName:
                return PaperEx_FuncMap_PaperTypeName(objPaperEx);
            case clsPaperENEx_js_1.clsPaperENEx.con_UpdUserName:
                return PaperEx_FuncMap_UpdUserName(objPaperEx);
            case clsPaperENEx_js_1.clsPaperENEx.con_IsCollection:
                return PaperEx_FuncMap_IsCollection(objPaperEx);
            case clsPaperENEx_js_1.clsPaperENEx.con_IsHasAttention:
                return PaperEx_FuncMap_IsHasAttention(objPaperEx);
            case clsPaperENEx_js_1.clsPaperENEx.con_IsSysVote:
                return PaperEx_FuncMap_IsSysVote(objPaperEx);
            case clsPaperENEx_js_1.clsPaperENEx.con_DS_Author:
                return PaperEx_FuncMap_DS_Author(objPaperEx);
            case clsPaperENEx_js_1.clsPaperENEx.con_DS_Periodical:
                return PaperEx_FuncMap_DS_Periodical(objPaperEx);
            case clsPaperENEx_js_1.clsPaperENEx.con_DS_Keyword:
                return PaperEx_FuncMap_DS_Keyword(objPaperEx);
            case clsPaperENEx_js_1.clsPaperENEx.con_DS_LiteratureSources:
                return PaperEx_FuncMap_DS_LiteratureSources(objPaperEx);
            default:
                strMsg = (0, clsString_js_1.Format)("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
                console.error(strMsg);
        }
    }
    exports.PaperEx_FuncMapByFldName = PaperEx_FuncMapByFldName;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function PaperEx_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            default:
                return (0, clsPaperWApi_js_1.Paper_FilterFunByKey)(strKey, value);
        }
    }
    exports.PaperEx_FilterFunByKey = PaperEx_FilterFunByKey;
    /// <summary>
    /// 绑定基于Web的下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    async function PaperEx_BindDdl_PaperIdInDivById_CurrEduCls_Cache(strDivName, strDdlName, strid_CurrEduCls) {
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！(In BindDdl_PaperIdInDiv_Cache)`;
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_PaperIdInDiv_Cache");
        var arrObjLst_Sel = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsPaperEN_js_1.clsPaperEN.con_PaperId, clsPaperEN_js_1.clsPaperEN.con_PaperTitle, "论文表");
    }
    exports.PaperEx_BindDdl_PaperIdInDivById_CurrEduCls_Cache = PaperEx_BindDdl_PaperIdInDivById_CurrEduCls_Cache;
    /// <summary>
    /// 根据教学班获取对象列表，用对象列表表示
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
    /// </summary>
    /// <param name = "strId_CurrEduCls">教学班流水号</param>
    /// <returns>获取的相应对象列表</returns>
    async function PaperEx_GetObjLstById_CurrEduCls(strId_CurrEduCls) {
        const strThisFuncName = "GetObjLstById_CurrEduCls";
        var strAction = "GetObjLstById_CurrEduCls";
        let strUrl = PaperEx_GetWebApiUrl(exports.paperEx_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strId_CurrEduCls": strId_CurrEduCls }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperEx_Controller, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = (0, clsPaperWApi_js_1.Paper_GetObjLstByJSONObjLst)(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEx_GetObjLstById_CurrEduCls = PaperEx_GetObjLstById_CurrEduCls;
    /// <summary>
    /// 根据关键字获取相关对象, 从缓存中获取.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
    /// </summary>
    /// <param name = "strPaperId">所给的关键字</param>
    /// <returns>对象</returns>
    async function PaperEx_GetObjByPaperIdById_CurrEduCls_Cache(strPaperId, strid_CurrEduCls) {
        var arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        var obj = new clsPaperEN_js_1.clsPaperEN();
        try {
            var arrPaper_Sel = arrPaperObjLst_Cache.filter(x => x.paperId == strPaperId);
            var objPaper;
            if (arrPaper_Sel.length > 0) {
                objPaper = arrPaper_Sel[0];
                return objPaper;
            }
            else {
                return obj;
            }
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据关键字:[${strPaperId}]获取相应的对象不成功!`;
            console.error(strMsg);
            alert(strMsg);
        }
        return obj;
    }
    exports.PaperEx_GetObjByPaperIdById_CurrEduCls_Cache = PaperEx_GetObjByPaperIdById_CurrEduCls_Cache;
    ;
    /// <summary>
    /// 刷新本类中的缓存.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    /// </summary>
    async function PaperEx_ReFreshThisCacheById_CurrEduCls(strid_CurrEduCls) {
        var strMsg = "";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            var strKey = `${clsPaperEN_js_1.clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
            switch (clsPaperEN_js_1.clsPaperEN.CacheModeId) {
                case "04": //sessionStorage
                    sessionStorage.removeItem(strKey);
                    break;
                case "03": //localStorage
                    localStorage.removeItem(strKey);
                    break;
                case "02": //ClientCache
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
                    break;
                default:
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
                    break;
            }
            strMsg = `刷新缓存成功！`,
                console.trace(strMsg);
        }
        else {
            strMsg = `刷新缓存已经关闭。`;
            console.trace(strMsg);
        }
    }
    exports.PaperEx_ReFreshThisCacheById_CurrEduCls = PaperEx_ReFreshThisCacheById_CurrEduCls;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls) {
        var arrPaperObjLst_Cache;
        switch (clsPaperEN_js_1.clsPaperEN.CacheModeId) {
            case "04": //sessionStorage
                arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls);
                break;
        }
        return arrPaperObjLst_Cache;
    }
    exports.PaperEx_GetObjLstById_CurrEduCls_Cache = PaperEx_GetObjLstById_CurrEduCls_Cache;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function PaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsPaperEN_js_1.clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            var arrPaperObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            return arrPaperObjLst_Cache;
        }
        try {
            const responseText = await PaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
            var arrPaperObjLst = responseText;
            CacheHelper_js_1.CacheHelper.Add(strKey, arrPaperObjLst);
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperObjLst.length}!`;
            console.log(strInfo);
            return arrPaperObjLst;
        }
        catch (e) {
            var strMsg = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperEx_GetObjLstById_CurrEduCls_ClientCache = PaperEx_GetObjLstById_CurrEduCls_ClientCache;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function PaperEx_GetObjLstById_CurrEduCls_localStorage(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsPaperEN_js_1.clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (localStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            var strTempObjLst = localStorage.getItem(strKey);
            var arrPaperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperObjLst_Cache;
        }
        try {
            const responseText = await PaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
            var arrPaperObjLst = responseText;
            localStorage.setItem(strKey, JSON.stringify(arrPaperObjLst));
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperObjLst.length}!`;
            console.log(strInfo);
            return arrPaperObjLst;
        }
        catch (e) {
            var strMsg = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperEx_GetObjLstById_CurrEduCls_localStorage = PaperEx_GetObjLstById_CurrEduCls_localStorage;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function PaperEx_GetObjLstById_CurrEduCls_sessionStorage(strid_CurrEduCls) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsPaperEN_js_1.clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            var strTempObjLst = sessionStorage.getItem(strKey);
            var arrPaperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperObjLst_Cache;
        }
        try {
            const responseText = await PaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
            var arrPaperObjLst = responseText;
            sessionStorage.setItem(strKey, JSON.stringify(arrPaperObjLst));
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperObjLst.length}!`;
            console.log(strInfo);
            return arrPaperObjLst;
        }
        catch (e) {
            var strMsg = `从缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperEx_GetObjLstById_CurrEduCls_sessionStorage = PaperEx_GetObjLstById_CurrEduCls_sessionStorage;
    /// <summary>
    /// 根据条件对象, 从缓存的对象列表中获取子集.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
    /// </summary>
    /// <param name = "objstrSubViewpointId_Cond">条件对象</param>
    /// <returns>对象列表子集</returns>
    async function PaperEx_GetSubObjLstById_CurrEduCls_Cache(objPaper_Cond, strid_CurrEduCls) {
        var arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        var arrPaper_Sel = arrPaperObjLst_Cache.filter(x => true);
        if (objPaper_Cond.sf_FldComparisonOp == null || objPaper_Cond.sf_FldComparisonOp == "")
            return arrPaper_Sel;
        var dicFldComparisonOp = JSON.parse(objPaper_Cond.sf_FldComparisonOp);
        //console.log("clsPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaper_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = objPaper_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            return arrPaper_Sel;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${JSON.stringify(objPaper_Cond)}]缓存对象列表中获取子集对象不成功!`;
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperEx_GetSubObjLstById_CurrEduCls_Cache = PaperEx_GetSubObjLstById_CurrEduCls_Cache;
    ;
    /// <summary>
    /// 根据条件对象, 从缓存的对象列表中获取记录数.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
    /// </summary>
    /// <param name = "objPaper_Cond">条件对象</param>
    /// <returns>对象列表记录数</returns>
    async function PaperEx_GetRecCountByCondById_CurrEduCls_Cache(objPaper_Cond, strid_CurrEduCls) {
        var arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        var arrPaper_Sel = arrPaperObjLst_Cache.filter(x => true);
        if (objPaper_Cond.sf_FldComparisonOp == null || objPaper_Cond.sf_FldComparisonOp == "")
            return arrPaper_Sel.length;
        var dicFldComparisonOp = JSON.parse(objPaper_Cond.sf_FldComparisonOp);
        //console.log("clsPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaper_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = objPaper_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            return arrPaper_Sel.length;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${JSON.stringify(objPaper_Cond)}]从缓存对象列表中获取记录数不成功!`;
            console.error(strMsg);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.PaperEx_GetRecCountByCondById_CurrEduCls_Cache = PaperEx_GetRecCountByCondById_CurrEduCls_Cache;
    ;
    /// <summary>
    /// 从缓存中获取分页对象列表.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
    /// </summary>
    /// <param name = "objPagerPara">分页参数结构</param>
    /// <returns>对象列表</returns>
    async function PaperEx_GetObjLstByPagerById_CurrEduCls_Cache(objPagerPara, strid_CurrEduCls) {
        var arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        if (arrPaperObjLst_Cache.length == 0)
            return arrPaperObjLst_Cache;
        var arrPaper_Sel = arrPaperObjLst_Cache.filter(x => true);
        var obj_Cond = JSON.parse(objPagerPara.whereCond);
        var dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsPaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = obj_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            if (arrPaper_Sel.length == 0)
                return arrPaper_Sel;
            var intStart = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
            if (intStart <= 0)
                intStart = 0;
            var intEnd = intStart + objPagerPara.pageSize;
            if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
                var sstrSplit = objPagerPara.orderBy.split(" ");
                var strSortType = "asc";
                var strSortFld = sstrSplit[0];
                if (sstrSplit.length > 1)
                    strSortType = sstrSplit[1];
                //                console.log(arrPaper_Sel);
                let objFirst = arrPaper_Sel[0]; //第一个对象
                let strSortValue = objFirst[strSortFld]; //第一个对象排序字段值            
                let strSortFldType = typeof (strSortValue); //排序字段值的数据类型
                //console.log("排序字段的数据类型: " + strSortFldType);
                switch (strSortFldType) {
                    case "string":
                        if (strSortType.toLowerCase() == "asc") {
                            arrPaper_Sel = arrPaper_Sel.sort((x, y) => x[strSortFld].localeCompare(y[strSortFld]));
                        }
                        else {
                            arrPaper_Sel = arrPaper_Sel.sort((x, y) => y[strSortFld].localeCompare(x[strSortFld]));
                        }
                        break;
                    case "number":
                    case "boolean":
                        if (strSortType.toLowerCase() == "asc") {
                            arrPaper_Sel = arrPaper_Sel.sort((x, y) => x[strSortFld] - y[strSortFld]);
                        }
                        else {
                            arrPaper_Sel = arrPaper_Sel.sort((x, y) => y[strSortFld] - x[strSortFld]);
                        }
                        break;
                }
            }
            else {
                //如果排序字段名[orderBy]为空，就调用排序函数
                arrPaper_Sel = arrPaper_Sel.sort(objPagerPara.sortFun);
            }
            arrPaper_Sel = arrPaper_Sel.slice(intStart, intEnd);
            return arrPaper_Sel;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${objPagerPara.whereCond}]获取分页对象列表不成功!(In Paper_GetObjLstByPager_Cache)`;
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperEx_GetObjLstByPagerById_CurrEduCls_Cache = PaperEx_GetObjLstByPagerById_CurrEduCls_Cache;
    ;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objPaperS:源对象
    **/
    async function PaperEx_FuncMap_PaperTypeName(objPaper) {
        const strThisFuncName = PaperEx_FuncMap_PaperTypeName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objPaper.paperTypeName) == true) {
                const gs_PaperType_PaperTypeId = objPaper.paperTypeId;
                const gs_PaperType_PaperTypeName = await (0, clsgs_PaperTypeWApi_js_1.gs_PaperType_func)(clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN.con_PaperTypeId, clsgs_PaperTypeEN_js_1.clsgs_PaperTypeEN.con_PaperTypeName, gs_PaperType_PaperTypeId);
                objPaper.paperTypeName = gs_PaperType_PaperTypeName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000260)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.paperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PaperEx_FuncMap_PaperTypeName = PaperEx_FuncMap_PaperTypeName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objPaperS:源对象
    **/
    async function PaperEx_FuncMap_UpdUserName(objPaper) {
        const strThisFuncName = PaperEx_FuncMap_UpdUserName.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objPaper.updUserName) == true) {
                const vUsersSim_UserId = objPaper.updUser;
                const vUsersSim_UserName = await (0, clsvUsersSimWApi_js_1.vUsersSim_func)(clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserId, clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserName, vUsersSim_UserId, clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                objPaper.updUserName = vUsersSim_UserName;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000262)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.paperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PaperEx_FuncMap_UpdUserName = PaperEx_FuncMap_UpdUserName;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objPaperS:源对象
    **/
    async function PaperEx_FuncMap_IsCollection(objPaper) {
        const strThisFuncName = PaperEx_FuncMap_UpdUserName.name;
        try {
            const arrPaperCollectionLogObjLst = await (0, clsPaperCollectionLogWApi_js_1.PaperCollectionLog_GetObjLst_Cache)(clsPublocalStorage_js_1.clsPublocalStorage.userId);
            const arr = arrPaperCollectionLogObjLst.filter(x => x.paperId == objPaper.paperId);
            objPaper.isCollection = arr.length > 0 ? true : false;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000262)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.paperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PaperEx_FuncMap_IsCollection = PaperEx_FuncMap_IsCollection;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objPaperS:源对象
    **/
    async function PaperEx_FuncMap_IsHasAttention(objPaper) {
        const strThisFuncName = PaperEx_FuncMap_IsHasAttention.name;
        try {
            const arrgs_PaperAttentionObjLst = await (0, clsgs_PaperAttentionWApi_js_1.gs_PaperAttention_GetObjLst_Cache)(clsPublocalStorage_js_1.clsPublocalStorage.userId);
            const arr = arrgs_PaperAttentionObjLst.filter(x => x.paperId == objPaper.paperId);
            objPaper.isHasAttention = arr.length > 0 ? true : false;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000262)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.paperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PaperEx_FuncMap_IsHasAttention = PaperEx_FuncMap_IsHasAttention;
    /**
    * 把一个扩展类的部分属性进行函数转换
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objPaperS:源对象
    **/
    async function PaperEx_FuncMap_IsSysVote(objPaper) {
        const strThisFuncName = PaperEx_FuncMap_IsSysVote.name;
        try {
            const arrSysVoteObjLst = await (0, clsSysVoteWApi_js_1.SysVote_GetObjLst_Cache)(clsPublocalStorage_js_1.clsPublocalStorage.userId);
            const arrSysVoteObjLst_Sel = arrSysVoteObjLst.filter(x => x.voteTypeId == clsSysVoteTypeEN_js_1.enumSysVoteType.Paper_01);
            const arr = arrSysVoteObjLst_Sel.filter(x => x.tableKey == objPaper.paperId);
            objPaper.isSysVote = arr.length > 0 ? true : false;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000262)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.paperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PaperEx_FuncMap_IsSysVote = PaperEx_FuncMap_IsSysVote;
    async function PaperEx_BindList_Paper(strTypeId, strDivName, arrPaperExObjLst) {
        for (var objInFor of arrPaperExObjLst) {
            await PaperEx_FuncMapByFldName(clsPaperENEx_js_1.clsPaperENEx.con_IsSysVote, objInFor);
            await PaperEx_FuncMapByFldName(clsPaperENEx_js_1.clsPaperENEx.con_IsCollection, objInFor);
            await PaperEx_FuncMapByFldName(clsPaperENEx_js_1.clsPaperENEx.con_IsHasAttention, objInFor);
            await PaperEx_FuncMapByFldName(clsPaperENEx_js_1.clsPaperENEx.con_UpdUserName, objInFor);
            await PaperEx_FuncMapByFldName(clsPaperENEx_js_1.clsPaperENEx.con_DS_Author, objInFor);
            await PaperEx_FuncMapByFldName(clsPaperENEx_js_1.clsPaperENEx.con_DS_Keyword, objInFor);
            await PaperEx_FuncMapByFldName(clsPaperENEx_js_1.clsPaperENEx.con_DS_LiteratureSources, objInFor);
            await PaperEx_FuncMapByFldName(clsPaperENEx_js_1.clsPaperENEx.con_DS_Periodical, objInFor);
            objInFor.author = objInFor.author == null ? "[无作者]" : objInFor.author;
            objInFor.literatureSources = objInFor.literatureSources == null ? "[无来源]" : objInFor.literatureSources;
            objInFor.keyword = objInFor.keyword == null ? "[无关键字]" : objInFor.keyword;
            objInFor.periodical = objInFor.periodical == null ? "[无期刊]" : objInFor.periodical;
        }
        //var arrSysVoteObjLst: Array<clsSysVoteEN> = [];
        //var arrPaperCollectionLogObjLst: Array<clsPaperCollectionLogEN> = [];
        //var arrgs_PaperAttentionObjLst: Array<clsgs_PaperAttentionEN> = [];
        //var arrvPaperCountObjLst: Array<clsvPaperCountEN> = [];
        var strhtml = "";
        var strWhereCond1 = " 1 =1 and updUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "' and voteTypeId='01'";
        var strWhereCond2 = " 1 =1 and updUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "'";
        //var strWhereCond3 = " 1 =1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
        //var strWhereCond3 = await this.CombinevPaperCondition();
        try {
            //获取用户缓存数据
            //var arrUsers: Array<clsvUsersSimEN> = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi.cmPrjId);
            //arrSysVoteObjLst = await SysVote_GetObjLstAsync(strWhereCond1);
            //arrPaperCollectionLogObjLst = await PaperCollectionLog_GetObjLstAsync(strWhereCond2);
            //arrvPaperCountObjLst = await vPaperCount_GetObjLstAsync(strWhereCond3);
            //arrgs_PaperAttentionObjLst = await gs_PaperAttention_GetObjLstAsync(strWhereCond2);
            for (var i = 0; i < arrPaperExObjLst.length; i++) {
                const objPaperEx = arrPaperExObjLst[i];
                //var objCount1 = arrvPaperCountObjLst.find(x => x.paperId == objPaperEx.paperId);//使用find必须通过if判断不能为空后才能调用属性
                if (objPaperEx != null) {
                    strhtml += '<div class="main-w1 fl" ><dl class="detail-list dbpage" ><dd>';
                    //strhtml += '<h6><a href="../GraduateEduEx/PaperDetail?paperId=' + objPaperEx.paperId + '">' + objPaperEx.paperTitle + '</a>';
                    //判断引用论文，自研论文
                    if (objPaperEx.paperTypeId == clsgs_PaperTypeEN_js_1.enumgs_PaperType.OriginalThesis_02) {
                        //自研论文
                        strhtml += "<h6><a href=\"#\" onclick=\"xadmin.open('论文查看(原创论文)', '../GraduateEduEx/PaperDetail?paperId=" + objPaperEx.paperId + "')\"><span class='text-info'>" + objPaperEx.paperTitle + "(" + objPaperEx.paperTypeName + ")</a>";
                    }
                    else {
                        strhtml += "<h6><a href=\"#\" onclick=\"xadmin.open('论文查看(引用论文)', '../GraduateEduEx/PaperDetail?paperId=" + objPaperEx.paperId + "')\">" + objPaperEx.paperTitle + "(" + objPaperEx.paperTypeName + ")</a>";
                    }
                    //if (objCount.attachmentCount > 0) {
                    //    strhtml += "<span class=\"btn-2\" style=\"padding-left:50px;\"><a style=\"font-size:15px; color:#f98c51\" href=\"#\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/PdfDetail?paperId=" + objPaperEx.paperId + "')\">pdf查看</a></span>";
                    //}
                    strhtml += '<span class="btn-2" style="padding-left:50px;"><a style="font-size:15px; color:#f98c51" href="#" onclick=PaperSubVer_Click("' + objPaperEx.paperId + '")>pdf论文子观点查看</a></span>';
                    //只有自研论文才有历史版本
                    if (objPaperEx.paperTypeId == clsgs_PaperTypeEN_js_1.enumgs_PaperType.OriginalThesis_02) {
                        if (objPaperEx.versionCount > 0 && objPaperEx.versionCount != null) {
                            strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('自研论文历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + objPaperEx.paperId + "&Type=10')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本</button >";
                        }
                    }
                    strhtml += '</h6>';
                    //                strhtml += '<div class="baseinfo"><span><a href="#">' + objPaperEx.ds_Author + '</a></span><span><a href="#">' + objPaperEx.literatureSources + '</a></span>';
                    strhtml += '<div class="baseinfo">' + objPaperEx.ds_Author + '<span class="ml-2"><a href="#">' + objPaperEx.ds_LiteratureSources + '</a></span>';
                    strhtml += '<span>' + objPaperEx.ds_Periodical + '</span><em>' + objPaperEx.ds_Keyword + '</em>';
                    strhtml += '</div>';
                    strhtml += '<div class="abstract">' + objPaperEx.paperContent + '</div>';
                    strhtml += '<div class="opts"><ul class="opts-count">';
                    strhtml += '<li>评论数:<em>' + objPaperEx.appraiseCount + '</em></li><li>综合评分:<em>' + objPaperEx.score + '</em></li>';
                    if (objPaperEx.teaScore != null) {
                        strhtml += '<li>教师评分:<em>' + objPaperEx.teaScore + '</em></li>';
                    }
                    if (objPaperEx.stuScore != null) {
                        strhtml += '<li>学生评分:<em>' + objPaperEx.stuScore + '</em></li>';
                    }
                    strhtml += '<li>读写数:<em>' + objPaperEx.pcount + '</em></li><li>浏览量:<em>' + objPaperEx.browseNumber + '</em></li>';
                    //strhtml += '<li>:<em>' + objPaperEx.pcount + '</em></li>';
                    //var objUser = arrUsers.find(x => x.userId == objPaperEx.updUser);
                    //if (objUser != null) {
                    if ((0, clsString_js_1.IsNullOrEmpty)(objPaperEx.updUserName) == false) {
                        strhtml += '<li class="date">编辑用户：' + objPaperEx.updUserName + '</li><li class="date">发表日期：' + objPaperEx.updDate + '</li></ul>';
                    }
                    strhtml += '<ul class="opts-btn">';
                    //var objAttention = arrgs_PaperAttentionObjLst.find(x => x.paperId == objPaperEx.paperId);
                    //if (objAttention == null) {
                    if (objPaperEx.isHasAttention == false) {
                        strhtml += '<li><a href="javascript:void(0)" onclick=btn_Click(\'AddAttention\',"' + objPaperEx.paperId + '")><i class="layui-icon layui-icon-face-smile-b" style="font-size: 20px;"></i><b>关注</b></a></li>';
                    }
                    else {
                        strhtml += '<li><a href="javascript:void(0)" onclick=btn_Click(\'AddAttention\',"' + objPaperEx.paperId + '")><i class="layui-icon layui-icon-face-smile-b" style="font-size: 20px; color: #1E9FFF;"></i><b>已关注</b></a></li>';
                    }
                    //var objLike = arrSysVoteObjLst.find(x => x.tableKey == objPaperEx.paperId);
                    //if (objLike == null) {
                    //    strhtml += '<li class="btn-quote">' + objCount.okCount + '<a class="icon-zan" href="javascript:void(0)" onclick=btnAddVote_Click("' + objPaperEx.paperId + '","' + objPaperEx.updUser + '")><i></i>点赞</a></li>';
                    //    //console.log("null!");
                    //} else {
                    //    strhtml += '<li class="btn-quote">' + objCount.okCount + '<a class="icon-zan_" href="javascript:void(0)" onclick=btnAddVote_Click("' + objPaperEx.paperId + '","' + objPaperEx.updUser + '")><i></i>已点赞</a></li>';
                    //    //console.log(objLike.paperId);
                    //}
                    //if (objLike == null) {
                    if (objPaperEx.isSysVote == false) {
                        strhtml += '<li>' + objPaperEx.okCount + '<a href="javascript:void(0)" onclick=btn_Click(\'AddVote\',"' + objPaperEx.paperId + '")><i class="layui-icon layui-icon-praise" style="font-size: 24px; "></i>点赞</a></li>';
                        //console.log("null!");
                    }
                    else {
                        strhtml += '<li>' + objPaperEx.okCount + '<a href="javascript:void(0)" onclick=btn_Click(\'AddVote\',"' + objPaperEx.paperId + '")><i class="layui-icon layui-icon-praise" style="font-size: 24px; color: #1E9FFF;"></i>已点赞</a></li>';
                        //console.log(objLike.paperId);
                    }
                    //var objCollection = arrPaperCollectionLogObjLst.find(x => x.paperId == objPaperEx.paperId);
                    //var objSysVoteObjLst: Array<clsvSysVoteEN> = [];
                    //objSysVoteObjLst = arrvSysVoteObjLst.filter(x => x.updUser == "2020/02/18");
                    //if (objCollection == null) {
                    //    strhtml += '<li class="btn-collect"><a class="icon-collect" href="javascript:void(0)" onclick=btnAddCollection_Click("' + objPaperEx.paperId + '")><i></i><b>收藏</b></a></li>';
                    //    //console.log("null!");
                    //} else {
                    //    strhtml += '<li class="btn-collect"><a class="icon-collect_" href="javascript:void(0)" onclick=btnAddCollection_Click("' + objPaperEx.paperId + '")><i></i><b>已收藏</b></a></li>';
                    //    //console.log(objCollection.paperId);
                    //}
                    //if (objCollection == null) {
                    if (objPaperEx.isCollection == false) {
                        strhtml += '<li><a href="javascript:void(0)" onclick=btn_Click(\'AddCollection\',"' + objPaperEx.paperId + '")><i class="layui-icon layui-icon-rate" style="font-size: 22px; "></i><b>收藏</b></a></li>';
                        //console.log("null!");
                    }
                    else {
                        strhtml += '<li><a href="javascript:void(0)" onclick=btn_Click(\'AddCollection\',"' + objPaperEx.paperId + '")><i class="layui-icon layui-icon-rate-solid" style="font-size: 22px; color: #1E9FFF;"></i><b>已收藏</b></a></li>';
                        //console.log(objCollection.paperId);
                    }
                    //if (objCount.attachmentCount > 0) {
                    //    strhtml += '<li>' + objCount.downloadCount + '<a id="btnDownLoadFile" class="downloadlink icon-notlogged" href="#" onclick=btnDownLoadFile_Click("' + objPaperEx.paperId + '")><i></i><b>点击下载</b></a></li>';
                    //} else {
                    //    strhtml += '<li><a id="btnDownLoadFile" class="downloadlink icon-notlogged_" href="#" title="暂无下载文件"><i></i><b>无下载文件</b></a></li>';
                    //}
                    if (objPaperEx.attachmentCount > 0) {
                        strhtml += '<li>' + objPaperEx.downloadCount + '<a id="btnDownLoadFile"  href="#" onclick=btnDownLoadFile_Click("' + objPaperEx.paperId + '")> <i class="layui-icon layui-icon-download-circle" style="font-size: 24px; "></i><b>点击下载</b></a></li>';
                    }
                    else {
                        strhtml += '<li><a id="btnDownLoadFile" href="#" title="暂无下载文件"><i class="layui-icon layui-icon-download-circle" style="font-size: 24px; color: #1E9FFF;"></i><b>无下载文件</b></a></li>';
                    }
                }
                strhtml += '</ul></div>';
                strhtml += '</dd></dl></div>';
            }
            const strDivName4Disp = (0, clsString_js_1.Format)("#{0}", strDivName);
            $(strDivName4Disp).html(strhtml);
        }
        catch (e) {
            console.error('catch(e)=');
            console.error(e);
            var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
            alert(strMsg);
        }
    }
    exports.PaperEx_BindList_Paper = PaperEx_BindList_Paper;
    /**
     * 显示一个字段的单元信息
     * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
     * @param objPaperS:源对象
     **/
    async function PaperEx_FuncMap_DS_Author(objPaper) {
        const strThisFuncName = PaperEx_FuncMap_DS_Author.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objPaper.ds_Author) == true) {
                const lblCurr = (0, clsCommFunc4Ctrl_js_1.GetLabel_Empty)("col-form-label text-right");
                const lblStyle_Title = (0, clsCommFunc4Ctrl_js_1.GetLabel_Empty)("text-secondary font-weight-bold"); //;
                lblStyle_Title.innerHTML = "作者";
                const lblStyle_Content = (0, clsCommFunc4Ctrl_js_1.GetLabel_Empty)("text-black"); //; await css_StyleEx_GetHtmlElementByStyleId(objCss_FldDispUnitStyle.styleId_Content, strContent);
                lblStyle_Content.innerHTML = objPaper.author;
                lblCurr.innerHTML = (0, clsString_js_1.Format)("{0}:{1}", lblStyle_Title.outerHTML, lblStyle_Content.outerHTML);
                objPaper.ds_Author = lblCurr.outerHTML;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000266)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.paperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PaperEx_FuncMap_DS_Author = PaperEx_FuncMap_DS_Author;
    /**
    * 显示一个字段的单元信息
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objPaperS:源对象
    **/
    async function PaperEx_FuncMap_DS_Periodical(objPaper) {
        const strThisFuncName = PaperEx_FuncMap_DS_Periodical.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objPaper.ds_Periodical) == true) {
                const lblCurr = (0, clsCommFunc4Ctrl_js_1.GetLabel_Empty)("col-form-label text-right");
                const lblStyle_Title = (0, clsCommFunc4Ctrl_js_1.GetLabel_Empty)("text-secondary font-weight-bold"); //;
                lblStyle_Title.innerHTML = "期刊";
                const lblStyle_Content = (0, clsCommFunc4Ctrl_js_1.GetLabel_Empty)("text-black"); //; await css_StyleEx_GetHtmlElementByStyleId(objCss_FldDispUnitStyle.styleId_Content, strContent);
                lblStyle_Content.innerHTML = objPaper.periodical;
                lblCurr.innerHTML = (0, clsString_js_1.Format)("{0}:{1}", lblStyle_Title.outerHTML, lblStyle_Content.outerHTML);
                objPaper.ds_Periodical = lblCurr.outerHTML;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000267)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.paperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PaperEx_FuncMap_DS_Periodical = PaperEx_FuncMap_DS_Periodical;
    /**
    * 显示一个字段的单元信息
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objPaperS:源对象
    **/
    async function PaperEx_FuncMap_DS_LiteratureSources(objPaper) {
        const strThisFuncName = PaperEx_FuncMap_DS_LiteratureSources.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objPaper.ds_LiteratureSources) == true) {
                const lblCurr = (0, clsCommFunc4Ctrl_js_1.GetLabel_Empty)("col-form-label text-right");
                const lblStyle_Title = (0, clsCommFunc4Ctrl_js_1.GetLabel_Empty)("text-secondary font-weight-bold"); //;
                lblStyle_Title.innerHTML = "文献来源";
                const lblStyle_Content = (0, clsCommFunc4Ctrl_js_1.GetLabel_Empty)("text-black"); //; await css_StyleEx_GetHtmlElementByStyleId(objCss_FldDispUnitStyle.styleId_Content, strContent);
                lblStyle_Content.innerHTML = objPaper.literatureSources;
                lblCurr.innerHTML = (0, clsString_js_1.Format)("{0}:{1}", lblStyle_Title.outerHTML, lblStyle_Content.outerHTML);
                objPaper.ds_LiteratureSources = lblCurr.outerHTML;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000268)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.paperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PaperEx_FuncMap_DS_LiteratureSources = PaperEx_FuncMap_DS_LiteratureSources;
    /**
    * 显示一个字段的单元信息
    * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
    * @param objPaperS:源对象
    **/
    async function PaperEx_FuncMap_DS_Keyword(objPaper) {
        const strThisFuncName = PaperEx_FuncMap_DS_Keyword.name;
        try {
            if ((0, clsString_js_1.IsNullOrEmpty)(objPaper.ds_Keyword) == true) {
                const lblCurr = (0, clsCommFunc4Ctrl_js_1.GetLabel_Empty)("col-form-label text-right");
                const lblStyle_Title = (0, clsCommFunc4Ctrl_js_1.GetLabel_Empty)("text-secondary font-weight-bold"); //;
                lblStyle_Title.innerHTML = "关键字";
                const lblStyle_Content = (0, clsCommFunc4Ctrl_js_1.GetLabel_Empty)("text-black"); //; await css_StyleEx_GetHtmlElementByStyleId(objCss_FldDispUnitStyle.styleId_Content, strContent);
                lblStyle_Content.innerHTML = objPaper.keyword;
                lblCurr.innerHTML = (0, clsString_js_1.Format)("{0}:{1}", lblStyle_Title.outerHTML, lblStyle_Content.outerHTML);
                objPaper.ds_Keyword = lblCurr.outerHTML;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("(errid:Watl000269)函数映射表对象数据出错,{0}.(in {1}.{2})", e, exports.paperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PaperEx_FuncMap_DS_Keyword = PaperEx_FuncMap_DS_Keyword;
    /* 显示vPaper对象的所有属性值
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
    <param name = "divContainer">显示容器</param>
    <param name = "arrPaperObjLst">需要绑定的对象列表</param>
  */
    async function PaperEx_BindTab_Paper(divContainer, arrPaperExObjLst, objOperateList) {
        const strThisFuncName = PaperEx_BindTab_Paper.name;
        var o = document.getElementById(divContainer);
        if (o == null) {
            alert(`${divContainer}不存在！`);
            return;
        }
        var arrDataColumn = [
            {
                fldName: "",
                colHeader: "",
                text: "", tdClass: "text-left", sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                columnType: "CheckBox",
                orderNum: 1,
                funcName: () => { }
            },
            {
                fldName: clsPaperENEx_js_1.clsPaperENEx.con_PaperTitle,
                colHeader: "论文标题",
                text: "", tdClass: "text-left",
                sortBy: "paperTitle", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            //{
            //    fldName: "paperTitle",
            //    colHeader: "论文标题",
            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
            //    columnType: "Label",
            //    orderNum: 1,
            //    funcName: (strKeyId: string, strText: string) => {
            //        var a1: HTMLElement = document.createElement("Label");
            //        a1.innerText = strText;
            //        a1.className = "btn btn-outline-info";
            //        a1.setAttribute("onclick", `btnDetailRecordInTab_Click('${strKeyId}');`);
            //        return a1;
            //    }
            //},
            {
                fldName: clsPaperENEx_js_1.clsPaperENEx.con_Periodical,
                colHeader: "期刊",
                text: "", tdClass: "text-left",
                sortBy: "periodical", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            {
                fldName: clsPaperENEx_js_1.clsPaperENEx.con_Author,
                colHeader: "作者",
                text: "", tdClass: "text-left",
                sortBy: "author", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            //{
            //    fldName: "researchQuestion",
            //    colHeader: "研究问题",
            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
            //    columnType: "Label",
            //    orderNum: 1,
            //    funcName: () => { }
            //},
            {
                fldName: clsPaperENEx_js_1.clsPaperENEx.con_Keyword,
                colHeader: "关键字",
                text: "", tdClass: "text-left",
                sortBy: "keyword", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            {
                fldName: clsPaperENEx_js_1.clsPaperENEx.con_LiteratureSources,
                colHeader: "文献来源",
                text: "", tdClass: "text-left",
                sortBy: "literatureSources", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            //{
            //    fldName: "literatureLink",
            //    colHeader: "文献链接",
            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
            //    columnType: "Label",
            //    orderNum: 1,
            //    funcName: () => { }
            //},
            //{
            //    fldName: "uploadfileUrl",
            //    colHeader: "文件地址",
            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
            //    columnType: "Label",
            //    orderNum: 1,
            //    funcName: () => { }
            //},
            //{
            //    fldName: "checker",
            //    colHeader: "审核人",
            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
            //    columnType: "Label",
            //    orderNum: 1,
            //    funcName: () => { }
            //},
            {
                fldName: clsPaperENEx_js_1.clsPaperENEx.con_IsSubmit,
                colHeader: "是否提交",
                text: "", tdClass: "text-left",
                sortBy: "isSubmit", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            {
                fldName: clsPaperENEx_js_1.clsPaperENEx.con_IsChecked,
                colHeader: "是否审核",
                text: "", tdClass: "text-left",
                sortBy: "isChecked", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            //{
            //    fldName: "isQuotethesis",
            //    colHeader: "是否引用论文",
            //    text: "",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
            //    columnType: "Label",
            //    orderNum: 1,
            //    funcName: () => { }
            //},
            {
                fldName: clsPaperENEx_js_1.clsPaperENEx.con_UpdDate,
                colHeader: "提交日期",
                text: "", tdClass: "text-left",
                sortBy: "updDate", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            {
                fldName: clsPaperENEx_js_1.clsPaperENEx.con_UpdUserName,
                colHeader: "提交用户",
                text: "", tdClass: "text-left",
                sortBy: "userName", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            {
                fldName: clsPaperENEx_js_1.clsPaperENEx.con_Pcount,
                colHeader: "读写数",
                text: "", tdClass: "text-left",
                sortBy: "pcount", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            {
                fldName: clsPaperENEx_js_1.clsPaperENEx.con_AttachmentCount,
                colHeader: "附件数",
                text: "", tdClass: "text-left",
                sortBy: "attachmentCount", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            {
                fldName: "",
                colHeader: "详情",
                text: "详情", tdClass: "text-left",
                sortBy: "", sortFun: clsCommFunc4Web_js_1.SortFun, getDataSource: "",
                columnType: "Button",
                orderNum: 1,
                funcName: (strKeyId, strText) => {
                    var btn1 = document.createElement("button");
                    btn1.innerText = strText;
                    btn1.className = "btn btn-outline-info btn-sm";
                    btn1.setAttribute("onclick", `btnDetailRecordInTab_Click("${strKeyId}");`);
                    return btn1;
                }
            },
            //{
            //    fldName: "",
            //    colHeader: "删除",
            //    text: "删除",tdClass: "text-left",sortBy: "", sortFun: SortFun, getDataSource: "",
            //    columnType: "Button",
            //    orderNum: 1,
            //    funcName: (strKeyId: string, strText: string) => {
            //        var btn1: HTMLElement = document.createElement("button");
            //        btn1.innerText = strText;
            //        btn1.className = "btn btn-outline-info";
            //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
            //        return btn1;
            //    }
            //},
        ];
        try {
            await PaperEx_ExtendFldFuncMap(arrPaperExObjLst, arrDataColumn);
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("扩展字段值的映射出错,{0}.(in {1}.{2})", e, exports.paperEx_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
        (0, clsCommFunc4Web_js_1.BindTab)(o, arrPaperExObjLst, arrDataColumn, "paperId", objOperateList);
        //this.objPager.recCount = this.recCount;
        //this.objPager.pageSize = this.pageSize;
        //this.objPager.ShowPagerV2(this, this.divName4Pager);
    }
    exports.PaperEx_BindTab_Paper = PaperEx_BindTab_Paper;
    /** 扩展字段值的函数映射
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExtendFldFuncMap)
    * @param arrPaperExObjLst:需要映射的对象列表
    * @param arrDataColumn:用于绑定表的数据列信息
    **/
    async function PaperEx_ExtendFldFuncMap(arrPaperExObjLst, arrDataColumn) {
        const arrFldName = clsPaperEN_js_1.clsPaperEN.AttributeName;
        for (const objDataColumn of arrDataColumn) {
            if ((0, clsString_js_1.IsNullOrEmpty)(objDataColumn.fldName) == true)
                continue;
            if (arrFldName.indexOf(objDataColumn.fldName) > -1)
                continue;
            for (const objInFor of arrPaperExObjLst) {
                await PaperEx_FuncMapByFldName(objDataColumn.fldName, objInFor);
            }
        }
    }
    exports.PaperEx_ExtendFldFuncMap = PaperEx_ExtendFldFuncMap;
    async function PaperEx_SynPaperStatisticsAsync(TeaUserId) {
        const strThisFuncName = "";
        var strAction = "GetTotalRevalidation";
        let strUrl = PaperEx_GetWebApiUrl(exports.paperEx_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "updUser": TeaUserId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEx_SynPaperStatisticsAsync = PaperEx_SynPaperStatisticsAsync;
    /// <summary>
    /// 获取论文中的用户数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    async function PaperEx_GetUserNumObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetUserNumObjLstAsync";
        var strAction = "GetUserNumObjLst";
        let strUrl = PaperEx_GetWebApiUrl(exports.paperEx_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperEx_Controller, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = (0, clsPaperWApi_js_1.Paper_GetObjLstByJSONObjLst)(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperEx_GetUserNumObjLstAsync = PaperEx_GetUserNumObjLstAsync;
    async function vPaperEx_SynPaperStatisticsAsync(TeaUserId) {
        const strThisFuncName = "";
        var strAction = "GetTotalRevalidation";
        let strUrl = PaperEx_GetWebApiUrl(exports.paperEx_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "updUser": TeaUserId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperEx_SynPaperStatisticsAsync = vPaperEx_SynPaperStatisticsAsync;
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// 绑定基于论文缓存的用户下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    async function vPaperEx_BindDdl_UsersInvSimPaper_Cache(strDdlName, objUsers_Cond) {
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_UserId_Cache");
        var arrvPaperSim = await (0, clsvPaperSimWApi_js_1.vPaperSim_GetObjLstAsync)("1=1");
        var arrObjLst_Sel = arrvPaperSim.map(vPaperEx_GetUsersBvPaperSim);
        arrObjLst_Sel = vPaperEx_uniq(arrObjLst_Sel);
        console.log(arrObjLst_Sel);
        arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsUsersEN_js_1.clsUsersEN.con_UserName]);
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(strDdlName, arrObjLst_Sel, clsUsersEN_js_1.clsUsersEN.con_UserId, clsUsersEN_js_1.clsUsersEN.con_UserName, "编辑用户");
    }
    exports.vPaperEx_BindDdl_UsersInvSimPaper_Cache = vPaperEx_BindDdl_UsersInvSimPaper_Cache;
    function vPaperEx_uniq(arr) {
        let arrObjLst_New = new Array();
        for (let x of arr) {
            if (vPaperEx_IsExist(arrObjLst_New, x) == false) {
                arrObjLst_New.push(x);
            }
        }
        return arrObjLst_New;
    }
    exports.vPaperEx_uniq = vPaperEx_uniq;
    function vPaperEx_IsExist(arr, key) {
        let arr_Sel = arr.filter(x => x.userId == key.userId);
        if (arr_Sel.length > 0)
            return true;
        return false;
    }
    exports.vPaperEx_IsExist = vPaperEx_IsExist;
    function vPaperEx_GetUsersBvPaperSim(objvPaperSim) {
        var objUsers = new clsUsersEN_js_1.clsUsersEN();
        objUsers.userId = objvPaperSim.updUser;
        objUsers.userName = objvPaperSim.userName;
        return objUsers;
    }
    exports.vPaperEx_GetUsersBvPaperSim = vPaperEx_GetUsersBvPaperSim;
    /// <summary>
    /// 绑定基于论文缓存的专业下拉框
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    /// </summary>
    /// <param name = "objDDL">需要绑定当前表的下拉框</param>
    async function vPaperEx_BindDdl_XzMajorInvSimPaper_Cache(strDdlName, objXzMajor_Cond) {
        var objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            var strMsg = `下拉框：${strDdlName} 不存在！`;
            alert(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        console.log("开始：BindDdl_id_XzMajor_Cache");
        var arrvPaperSim = await (0, clsvPaperSimWApi_js_1.vPaperSim_GetObjLstAsync)("1=1");
        var arrObjLst_Sel = arrvPaperSim.map(vPaperEx_GetXzMajorBvPaperSim);
        arrObjLst_Sel = vPaperEx_XzMajorUniq(arrObjLst_Sel);
        console.log(arrObjLst_Sel);
        arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName]);
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLst)(strDdlName, arrObjLst_Sel, clsXzMajorEN_js_1.clsXzMajorEN.con_id_XzMajor, clsXzMajorEN_js_1.clsXzMajorEN.con_MajorName, "专业");
    }
    exports.vPaperEx_BindDdl_XzMajorInvSimPaper_Cache = vPaperEx_BindDdl_XzMajorInvSimPaper_Cache;
    function vPaperEx_XzMajorUniq(arr) {
        let arrObjLst_New = new Array();
        for (let x of arr) {
            if (vPaperEx_XzMajorIsExist(arrObjLst_New, x) == false) {
                arrObjLst_New.push(x);
            }
        }
        return arrObjLst_New;
    }
    exports.vPaperEx_XzMajorUniq = vPaperEx_XzMajorUniq;
    function vPaperEx_XzMajorIsExist(arr, key) {
        let arr_Sel = arr.filter(x => x.id_XzMajor == key.id_XzMajor);
        if (arr_Sel.length > 0)
            return true;
        return false;
    }
    exports.vPaperEx_XzMajorIsExist = vPaperEx_XzMajorIsExist;
    function vPaperEx_GetXzMajorBvPaperSim(objvPaperSim) {
        var objXzMajor = new clsXzMajorEN_js_1.clsXzMajorEN();
        objXzMajor.id_XzMajor = objvPaperSim.id_XzMajor;
        objXzMajor.majorName = objvPaperSim.majorName;
        return objXzMajor;
    }
    exports.vPaperEx_GetXzMajorBvPaperSim = vPaperEx_GetXzMajorBvPaperSim;
    /// <summary>
    /// 根据教学班获取对象列表，用对象列表表示
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
    /// </summary>
    /// <param name = "strId_CurrEduCls">教学班流水号</param>
    /// <returns>获取的相应对象列表</returns>
    async function vPaperEx_GetObjLstById_CurrEduCls(strId_CurrEduCls, strCourseId) {
        const strThisFuncName = "GetObjLstById_CurrEduCls";
        var strAction = "GetObjLstById_CurrEduCls";
        let strUrl = PaperEx_GetWebApiUrl(exports.paperEx_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strId_CurrEduCls": strId_CurrEduCls,
                    "strCourseId": strCourseId
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperEx_Controller, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = (0, clsPaperWApi_js_1.Paper_GetObjLstByJSONObjLst)(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperEx_Controller, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperEx_GetObjLstById_CurrEduCls = vPaperEx_GetObjLstById_CurrEduCls;
    /// <summary>
    /// 根据关键字获取相关对象, 从缓存中获取.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
    /// </summary>
    /// <param name = "strPaperId">所给的关键字</param>
    /// <returns>对象</returns>
    async function vPaperEx_GetObjByPaperIdById_CurrEduCls_Cache(strPaperId, strid_CurrEduCls, strCourseId) {
        var arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls, strCourseId);
        var obj = new clsPaperEN_js_1.clsPaperEN();
        try {
            var arrvPaper_Sel = arrvPaperObjLst_Cache.filter(x => x.paperId == strPaperId);
            var objvPaper;
            if (arrvPaper_Sel.length > 0) {
                objvPaper = arrvPaper_Sel[0];
                return objvPaper;
            }
            else {
                return obj;
            }
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据关键字:[${strPaperId}]获取相应的对象不成功!`;
            console.error(strMsg);
            alert(strMsg);
        }
        return obj;
    }
    exports.vPaperEx_GetObjByPaperIdById_CurrEduCls_Cache = vPaperEx_GetObjByPaperIdById_CurrEduCls_Cache;
    ;
    /// <summary>
    /// 刷新本类中的缓存.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    /// </summary>
    function PaperEx_ReFreshThisCacheById_CurrEduClsBakFromV(strid_CurrEduCls) {
        var strMsg = "";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            var strKey = `${clsPaperEN_js_1.clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
            switch (clsPaperEN_js_1.clsPaperEN.CacheModeId) {
                case "04": //sessionStorage
                    sessionStorage.removeItem(strKey);
                    break;
                case "03": //localStorage
                    localStorage.removeItem(strKey);
                    break;
                case "02": //ClientCache
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
                    break;
                default:
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
                    break;
            }
            strMsg = `刷新缓存成功！`,
                console.trace(strMsg);
        }
        else {
            strMsg = `刷新缓存已经关闭。`;
            console.trace(strMsg);
        }
    }
    exports.PaperEx_ReFreshThisCacheById_CurrEduClsBakFromV = PaperEx_ReFreshThisCacheById_CurrEduClsBakFromV;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vPaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls, strCourseId) {
        var arrvPaperObjLst_Cache;
        switch (clsPaperEN_js_1.clsPaperEN.CacheModeId) {
            case "04": //sessionStorage
                arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_sessionStorage(strid_CurrEduCls, strCourseId);
                break;
            case "03": //localStorage
                arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_localStorage(strid_CurrEduCls, strCourseId);
                break;
            case "02": //ClientCache
                arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls, strCourseId);
                break;
            default:
                arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls, strCourseId);
                break;
        }
        return arrvPaperObjLst_Cache;
    }
    exports.vPaperEx_GetObjLstById_CurrEduCls_Cache = vPaperEx_GetObjLstById_CurrEduCls_Cache;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vPaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls, strCourseId) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsPaperEN_js_1.clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            var arrvPaperObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            return arrvPaperObjLst_Cache;
        }
        try {
            const arrPaperExObjLst = await vPaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls, strCourseId);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrPaperExObjLst);
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperExObjLst.length}!`;
            console.log(strInfo);
            return arrPaperExObjLst;
        }
        catch (e) {
            var strMsg = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperEx_GetObjLstById_CurrEduCls_ClientCache = vPaperEx_GetObjLstById_CurrEduCls_ClientCache;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vPaperEx_GetObjLstById_CurrEduCls_localStorage(strid_CurrEduCls, strCourseId) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsPaperEN_js_1.clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (localStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            var strTempObjLst = localStorage.getItem(strKey);
            var arrvPaperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperObjLst_Cache;
        }
        try {
            const arrPaperExObjLst = await vPaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls, strCourseId);
            localStorage.setItem(strKey, JSON.stringify(arrPaperExObjLst));
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperExObjLst.length}!`;
            console.log(strInfo);
            return arrPaperExObjLst;
        }
        catch (e) {
            var strMsg = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperEx_GetObjLstById_CurrEduCls_localStorage = vPaperEx_GetObjLstById_CurrEduCls_localStorage;
    /// <summary>
    /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    /// </summary>
    /// <returns>从本地缓存中获取的对象列表</returns>
    async function vPaperEx_GetObjLstById_CurrEduCls_sessionStorage(strid_CurrEduCls, strCourseId) {
        //初始化列表缓存
        var strWhereCond = "1=1";
        strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
        var strKey = `${clsPaperEN_js_1.clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
        if (strKey == "") {
            console.log("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (sessionStorage.hasOwnProperty(strKey)) {
            //缓存存在，直接返回
            var strTempObjLst = sessionStorage.getItem(strKey);
            var arrvPaperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperObjLst_Cache;
        }
        try {
            const arrPaperExObjLst = await vPaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls, strCourseId);
            sessionStorage.setItem(strKey, JSON.stringify(arrPaperExObjLst));
            var strInfo = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperExObjLst.length}!`;
            console.log(strInfo);
            return arrPaperExObjLst;
        }
        catch (e) {
            var strMsg = `从缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperEx_GetObjLstById_CurrEduCls_sessionStorage = vPaperEx_GetObjLstById_CurrEduCls_sessionStorage;
    /// <summary>
    /// 根据条件对象, 从缓存的对象列表中获取子集.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
    /// </summary>
    /// <param name = "objstrSubViewpointId_Cond">条件对象</param>
    /// <returns>对象列表子集</returns>
    async function vPaperEx_GetSubObjLstById_CurrEduCls_Cache(objvPaper_Cond, strid_CurrEduCls, strCourseId) {
        var arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls, strCourseId);
        var arrvPaper_Sel = arrvPaperObjLst_Cache.filter(x => true);
        if (objvPaper_Cond.sf_FldComparisonOp == null || objvPaper_Cond.sf_FldComparisonOp == "")
            return arrvPaper_Sel;
        var dicFldComparisonOp = JSON.parse(objvPaper_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaper_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = objvPaper_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            return arrvPaper_Sel;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${JSON.stringify(objvPaper_Cond)}]缓存对象列表中获取子集对象不成功!`;
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperEx_GetSubObjLstById_CurrEduCls_Cache = vPaperEx_GetSubObjLstById_CurrEduCls_Cache;
    ;
    /// <summary>
    /// 根据条件对象, 从缓存的对象列表中获取记录数.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
    /// </summary>
    /// <param name = "objvPaper_Cond">条件对象</param>
    /// <returns>对象列表记录数</returns>
    async function vPaperEx_GetRecCountByCondById_CurrEduCls_Cache(objvPaper_Cond, strid_CurrEduCls, strCourseId) {
        var arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls, strCourseId);
        var arrvPaper_Sel = arrvPaperObjLst_Cache.filter(x => true);
        if (objvPaper_Cond.sf_FldComparisonOp == null || objvPaper_Cond.sf_FldComparisonOp == "")
            return arrvPaper_Sel.length;
        var dicFldComparisonOp = JSON.parse(objvPaper_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaper_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = objvPaper_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            return arrvPaper_Sel.length;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${JSON.stringify(objvPaper_Cond)}]从缓存对象列表中获取记录数不成功!`;
            console.error(strMsg);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vPaperEx_GetRecCountByCondById_CurrEduCls_Cache = vPaperEx_GetRecCountByCondById_CurrEduCls_Cache;
    ;
    /// <summary>
    /// 从缓存中获取分页对象列表.
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
    /// </summary>
    /// <param name = "objPagerPara">分页参数结构</param>
    /// <returns>对象列表</returns>
    async function vPaperEx_GetObjLstByPagerById_CurrEduCls_Cache(objPagerPara, strid_CurrEduCls, strCourseId) {
        var arrvPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
        if (arrvPaperObjLst_Cache.length == 0)
            return arrvPaperObjLst_Cache;
        var arrvPaper_Sel = arrvPaperObjLst_Cache.filter(x => true);
        var obj_Cond = JSON.parse(objPagerPara.whereCond);
        var dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvPaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            var sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (let strKey of sstrKeys) {
                if (dicFldComparisonOp.hasOwnProperty(strKey) == false)
                    continue;
                arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] != null);
                var strComparisonOp = dicFldComparisonOp[strKey];
                var strValue = obj_Cond[strKey];
                var strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        break;
                    case "number":
                        if (strValue == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaper_Sel.length == 0)
                return arrvPaper_Sel;
            var intStart = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
            if (intStart <= 0)
                intStart = 0;
            var intEnd = intStart + objPagerPara.pageSize;
            if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
                var sstrSplit = objPagerPara.orderBy.split(" ");
                var strSortType = "asc";
                var strSortFld = sstrSplit[0];
                if (sstrSplit.length > 1)
                    strSortType = sstrSplit[1];
                //                console.log(arrvPaper_Sel);
                let objFirst = arrvPaper_Sel[0]; //第一个对象
                let strSortValue = objFirst[strSortFld]; //第一个对象排序字段值            
                let strSortFldType = typeof (strSortValue); //排序字段值的数据类型
                //console.log("排序字段的数据类型: " + strSortFldType);
                switch (strSortFldType) {
                    case "string":
                        if (strSortType.toLowerCase() == "asc") {
                            arrvPaper_Sel = arrvPaper_Sel.sort((x, y) => x[strSortFld].localeCompare(y[strSortFld]));
                        }
                        else {
                            arrvPaper_Sel = arrvPaper_Sel.sort((x, y) => y[strSortFld].localeCompare(x[strSortFld]));
                        }
                        break;
                    case "number":
                    case "boolean":
                        if (strSortType.toLowerCase() == "asc") {
                            arrvPaper_Sel = arrvPaper_Sel.sort((x, y) => x[strSortFld] - y[strSortFld]);
                        }
                        else {
                            arrvPaper_Sel = arrvPaper_Sel.sort((x, y) => y[strSortFld] - x[strSortFld]);
                        }
                        break;
                }
            }
            else {
                //如果排序字段名[orderBy]为空，就调用排序函数
                arrvPaper_Sel = arrvPaper_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaper_Sel = arrvPaper_Sel.slice(intStart, intEnd);
            return arrvPaper_Sel;
        }
        catch (e) {
            var strMsg = `错误:[${e}]. \n根据条件:[${objPagerPara.whereCond}]获取分页对象列表不成功!(In vPaper_GetObjLstByPager_Cache)`;
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperEx_GetObjLstByPagerById_CurrEduCls_Cache = vPaperEx_GetObjLstByPagerById_CurrEduCls_Cache;
    ;
});
