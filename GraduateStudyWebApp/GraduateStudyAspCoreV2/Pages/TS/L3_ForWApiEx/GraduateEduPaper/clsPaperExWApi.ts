
import axios from "axios";
import { clsXzMajorEN } from "../../L0_Entity/BaseInfo_Share/clsXzMajorEN.js";
import { clsPaperEN } from "../../L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsPaperENEx } from "../../L0_Entity/GraduateEduPaper/clsPaperENEx.js";
import { clsvPaperSimEN } from "../../L0_Entity/GraduateEduPaper/clsvPaperSimEN.js";
import { clsgs_PaperTypeEN, enumgs_PaperType } from "../../L0_Entity/ParameterTable/clsgs_PaperTypeEN.js";
import { enumSysVoteType } from "../../L0_Entity/ParameterTable/clsSysVoteTypeEN.js";
import { clsUsersEN } from "../../L0_Entity/UserManage_Share/clsUsersEN.js";
import { clsvUsersSimEN } from "../../L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { gs_PaperAttention_GetObjLst_Cache } from "../../L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js";
import { PaperCollectionLog_GetObjLst_Cache } from "../../L3_ForWApi/GraduateEduPaper/clsPaperCollectionLogWApi.js";
import { Paper_FilterFunByKey, Paper_GetObjLstAsync, Paper_GetObjLstByJSONObjLst, Paper_SortFunByKey } from "../../L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { vPaperSim_GetObjLstAsync } from "../../L3_ForWApi/GraduateEduPaper/clsvPaperSimWApi.js";
import { SysVote_GetObjLst_Cache } from "../../L3_ForWApi/InteractManage/clsSysVoteWApi.js";
import { gs_PaperType_func } from "../../L3_ForWApi/ParameterTable/clsgs_PaperTypeWApi.js";
import { vUsersSim_func } from "../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { GetLabel_Empty } from "../../PubFun/clsCommFunc4Ctrl.js";
import { BindDdl_ObjLst, BindDdl_ObjLstInDiv, BindTab, GetObjKeys, GetSortExpressInfo, ObjectAssign, SortFun } from "../../PubFun/clsCommFunc4Web.js";
import { clsDataColumn } from "../../PubFun/clsDataColumn.js";
import { clsOperateList } from "../../PubFun/clsOperateList.js";
import { clsPublocalStorage } from "../../PubFun/clsPublocalStorage.js";
import { Format, IsNullOrEmpty } from "../../PubFun/clsString.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";
export const paperEx_Controller = "PaperExApi";
export const paperEx_ConstructorName = "paperEx";

/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function PaperEx_GetWebApiUrl(strController: string, strAction: string): string {
    const strThisFuncName = "GetWebApiUrl";
    let strServiceUrl: string;
    let strCurrIPAddressAndPort = "";
    if (clsSysPara4WebApi.bolIsLocalHost == false) {
        strCurrIPAddressAndPort = clsSysPara4WebApi.CurrIPAddressAndPort;
    }
    else {
        strCurrIPAddressAndPort = clsSysPara4WebApi.CurrIPAddressAndPort_Local;
    }
    if (IsNullOrEmpty(clsSysPara4WebApi.CurrPrx) == true) {
        strServiceUrl = Format("{0}/{1}/{2}", strCurrIPAddressAndPort, strController, strAction);
    }
    else {
        strServiceUrl = Format("{0}/{1}/{2}/{3}", strCurrIPAddressAndPort, clsSysPara4WebApi.CurrPrx, strController, strAction);
    }
    return strServiceUrl;
}

/**
* 把同一个类的对象,复制到另一个对象
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
* @param objPaperENS:源对象
* @returns 目标对象=>clsPaperEN:objPaperENT
**/
export function PaperEx_CopyToEx(objPaperENS: clsPaperEN): clsPaperENEx {
    const strThisFuncName = PaperEx_CopyToEx.name;
    const objPaperENT = new clsPaperENEx();
    try {
        ObjectAssign(objPaperENT, objPaperENS);
        return objPaperENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, paperEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objPaperENT;
    }
}

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
export async function PaperEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsPaperENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrPaperObjLst = await Paper_GetObjLstAsync(objPagerPara.whereCond);
    const arrPaperExObjLst = arrPaperObjLst.map(PaperEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrPaperExObjLst) {
            const conFuncMap = await PaperEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrPaperExObjLst.length == 0) return arrPaperExObjLst;
    let arrPaper_Sel: Array<clsPaperENEx> = arrPaperExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
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
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, paperEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsPaperENEx>();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:潘以锋
 * 日期:00-00-00
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function PaperEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            case clsPaperENEx.con_id_CurrEduCls:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                }
            case clsPaperENEx.con_PaperTypeName:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    return a.paperTypeName.localeCompare(b.paperTypeName);
                }
            case clsPaperENEx.con_IsSysVote:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    if (a.isSysVote == true) return 1;
                    else return -1
                }
            case clsPaperENEx.con_IsCollection:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    if (a.isCollection == true) return 1;
                    else return -1
                }
            case clsPaperENEx.con_IsHasAttention:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    if (a.isHasAttention == true) return 1;
                    else return -1
                }
            case clsPaperENEx.con_UpdUserName:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    return a.updUserName.localeCompare(b.updUserName);
                }
            case clsPaperENEx.con_DS_Author:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    return a.ds_Author.localeCompare(b.ds_Author);
                }
            case clsPaperENEx.con_DS_Periodical:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    return a.ds_Periodical.localeCompare(b.ds_Periodical);
                }
            case clsPaperENEx.con_DS_Keyword:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    return a.ds_Keyword.localeCompare(b.ds_Keyword);
                }
            case clsPaperENEx.con_DS_LiteratureSources:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    return a.ds_LiteratureSources.localeCompare(b.ds_LiteratureSources);
                }
            default:
                return Paper_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            case clsPaperENEx.con_id_CurrEduCls:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                }
            case clsPaperENEx.con_PaperTypeName:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    return b.paperTypeName.localeCompare(a.paperTypeName);
                }
            case clsPaperENEx.con_IsSysVote:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    if (b.isSysVote == true) return 1;
                    else return -1
                }
            case clsPaperENEx.con_IsCollection:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    if (b.isCollection == true) return 1;
                    else return -1
                }
            case clsPaperENEx.con_IsHasAttention:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    if (b.isHasAttention == true) return 1;
                    else return -1
                }
            case clsPaperENEx.con_UpdUserName:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    return b.updUserName.localeCompare(a.updUserName);
                }
            case clsPaperENEx.con_DS_Author:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    return b.ds_Author.localeCompare(a.ds_Author);
                }
            case clsPaperENEx.con_DS_Periodical:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    return b.ds_Periodical.localeCompare(a.ds_Periodical);
                }
            case clsPaperENEx.con_DS_Keyword:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    return b.ds_Keyword.localeCompare(a.ds_Keyword);
                }
            case clsPaperENEx.con_DS_LiteratureSources:
                return (a: clsPaperENEx, b: clsPaperENEx) => {
                    return b.ds_LiteratureSources.localeCompare(a.ds_LiteratureSources);
                }
            default:
                return Paper_SortFunByKey(strKey, AscOrDesc);
        }
    }
}


/**
 * 根据扩展字段名去调用相应的映射函数
 * 作者:潘以锋
 * 日期:00-00-00
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
 * @param strFldName:扩展字段名
 * @param  obj{0}Ex:需要转换的对象
 * @returns 针对扩展字段名对转换对象进行函数映射
*/
export function PaperEx_FuncMapByFldName(strFldName: string, objPaperEx: clsPaperENEx) {
    const strThisFuncName = PaperEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsPaperEN.AttributeName;
    if (arrFldName.indexOf(strFldName) > -1) return;
    //针对扩展字段进行映射
    switch (strFldName) {
        case clsPaperENEx.con_PaperTypeName:
            return PaperEx_FuncMap_PaperTypeName(objPaperEx);
        case clsPaperENEx.con_UpdUserName:
            return PaperEx_FuncMap_UpdUserName(objPaperEx);
        case clsPaperENEx.con_IsCollection:
            return PaperEx_FuncMap_IsCollection(objPaperEx);
        case clsPaperENEx.con_IsHasAttention:
            return PaperEx_FuncMap_IsHasAttention(objPaperEx);
        case clsPaperENEx.con_IsSysVote:
            return PaperEx_FuncMap_IsSysVote(objPaperEx);
        case clsPaperENEx.con_DS_Author:
            return PaperEx_FuncMap_DS_Author(objPaperEx);
        case clsPaperENEx.con_DS_Periodical:
            return PaperEx_FuncMap_DS_Periodical(objPaperEx);
        case clsPaperENEx.con_DS_Keyword:
            return PaperEx_FuncMap_DS_Keyword(objPaperEx);
        case clsPaperENEx.con_DS_LiteratureSources:
            return PaperEx_FuncMap_DS_LiteratureSources(objPaperEx);
        default:
            strMsg = Format("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
            console.error(strMsg);
    }
}

/**
 * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function PaperEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return Paper_FilterFunByKey(strKey, value);
    }
}



/// <summary>
/// 绑定基于Web的下拉框
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
/// </summary>
/// <param name = "objDDL">需要绑定当前表的下拉框</param>
export async function PaperEx_BindDdl_PaperIdInDivById_CurrEduCls_Cache(strDivName: string, strDdlName: string, strid_CurrEduCls: string) {

    var objDdl = document.getElementById(strDdlName);
    if (objDdl == null) {
        var strMsg = `下拉框：${strDdlName} 不存在！(In BindDdl_PaperIdInDiv_Cache)`;
        alert(strMsg);
        console.error(strMsg);
        throw (strMsg);
    }
    //为数据源于表的下拉框设置内容
    console.log("开始：BindDdl_PaperIdInDiv_Cache");
    var arrObjLst_Sel: Array<clsPaperEN> = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
    BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsPaperEN.con_PaperId, clsPaperEN.con_PaperTitle, "论文表");
}

/// <summary>
/// 根据教学班获取对象列表，用对象列表表示
/// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
/// </summary>
/// <param name = "strId_CurrEduCls">教学班流水号</param>
/// <returns>获取的相应对象列表</returns>
export async function PaperEx_GetObjLstById_CurrEduCls(strId_CurrEduCls: string): Promise<Array<clsPaperEN>> {
    const strThisFuncName = "GetObjLstById_CurrEduCls";
    var strAction = "GetObjLstById_CurrEduCls";
    let strUrl = PaperEx_GetWebApiUrl(paperEx_Controller, strAction);
  
    try {
        const response = await axios.get(strUrl,
            {
                params: { "strId_CurrEduCls": strId_CurrEduCls }
            });
        const data = response.data;
        if (data.errorId == 0) {
            const returnObjLst = data.returnObjLst;
            if (returnObjLst == null) {
                const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperEx_Controller, strThisFuncName);
                console.error(strNullInfo);
                throw (strNullInfo);
            }
            //console.log(returnObjLst);
            const arrObjLst = Paper_GetObjLstByJSONObjLst(returnObjLst);
            return (arrObjLst);
        }
        else {
            console.error(data.errorMsg);
            throw (data.errorMsg);
        }
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

/// <summary>
/// 根据关键字获取相关对象, 从缓存中获取.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
/// </summary>
/// <param name = "strPaperId">所给的关键字</param>
/// <returns>对象</returns>
export async function PaperEx_GetObjByPaperIdById_CurrEduCls_Cache(strPaperId: string, strid_CurrEduCls: string) {
    var arrPaperObjLst_Cache: Array<clsPaperEN> = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
    var obj: clsPaperEN = new clsPaperEN();
    try {
        var arrPaper_Sel: Array<clsPaperEN> = arrPaperObjLst_Cache.filter(x => x.paperId == strPaperId);
        var objPaper: clsPaperEN;
        if (arrPaper_Sel.length > 0) {
            objPaper = arrPaper_Sel[0];
            return objPaper;
        }
        else {
            return obj;
        }
    }
    catch (e) {
        var strMsg: string = `错误:[${e}]. \n根据关键字:[${strPaperId}]获取相应的对象不成功!`;
        console.error(strMsg);
        alert(strMsg);
    }
    return obj;
};


/// <summary>
/// 刷新本类中的缓存.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
/// </summary>
export async function PaperEx_ReFreshThisCacheById_CurrEduCls(strid_CurrEduCls: string) {
    var strMsg: string = "";
    if (clsSysPara4WebApi.spSetRefreshCacheOn == true) {
        var strKey: string = `${clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
        switch (clsPaperEN.CacheModeId) {
            case "04"://sessionStorage
                sessionStorage.removeItem(strKey);
                break;
            case "03"://localStorage
                localStorage.removeItem(strKey);
                break;
            case "02"://ClientCache
                CacheHelper.Remove(strKey);
                break;
            default:
                CacheHelper.Remove(strKey);
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


/// <summary>
/// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
/// </summary>
/// <returns>从本地缓存中获取的对象列表</returns>
export async function PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls: string) {
    var arrPaperObjLst_Cache: Array<clsPaperEN>;
    switch (clsPaperEN.CacheModeId) {
        case "04"://sessionStorage
            arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_sessionStorage(strid_CurrEduCls);
            break;
        case "03"://localStorage
            arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_localStorage(strid_CurrEduCls);
            break;
        case "02"://ClientCache
            arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls);
            break;
        default:
            arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls);
            break;
    }
    return arrPaperObjLst_Cache;
}

/// <summary>
/// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
/// </summary>
/// <returns>从本地缓存中获取的对象列表</returns>
export async function PaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls: string) {
    //初始化列表缓存
    var strWhereCond: string = "1=1";

    strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
    var strKey: string = `${clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
    if (strKey == "") {
        console.log("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (CacheHelper.Exsits(strKey)) {
        //缓存存在，直接返回
        var arrPaperObjLst_Cache: Array<clsPaperEN> = CacheHelper.Get(strKey);
        return arrPaperObjLst_Cache;
    }
    try {
        const responseText = await PaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
        var arrPaperObjLst: Array<clsPaperEN> = <Array<clsPaperEN>>responseText;
        CacheHelper.Add(strKey, arrPaperObjLst);
        var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperObjLst.length}!`;
        console.log(strInfo);
        return arrPaperObjLst;
    }
    catch (e) {
        var strMsg: string = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
        console.error(strMsg);
        throw (strMsg);
    }
}

/// <summary>
/// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
/// </summary>
/// <returns>从本地缓存中获取的对象列表</returns>
export async function PaperEx_GetObjLstById_CurrEduCls_localStorage(strid_CurrEduCls: string) {
    //初始化列表缓存
    var strWhereCond: string = "1=1";

    strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
    var strKey: string = `${clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
    if (strKey == "") {
        console.log("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (localStorage.hasOwnProperty(strKey)) {
        //缓存存在，直接返回
        var strTempObjLst: string = localStorage.getItem(strKey) as string;
        var arrPaperObjLst_Cache: Array<clsPaperEN> = JSON.parse(strTempObjLst);
        return arrPaperObjLst_Cache;
    }
    try {
        const responseText = await PaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
        var arrPaperObjLst: Array<clsPaperEN> = <Array<clsPaperEN>>responseText;
        localStorage.setItem(strKey, JSON.stringify(arrPaperObjLst));
        var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperObjLst.length}!`;
        console.log(strInfo);
        return arrPaperObjLst;
    }
    catch (e) {
        var strMsg: string = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
        console.error(strMsg);
        throw (strMsg);
    }
}
/// <summary>
/// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
/// </summary>
/// <returns>从本地缓存中获取的对象列表</returns>
export async function PaperEx_GetObjLstById_CurrEduCls_sessionStorage(strid_CurrEduCls: string) {
    //初始化列表缓存
    var strWhereCond: string = "1=1";

    strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
    var strKey: string = `${clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
    if (strKey == "") {
        console.log("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (sessionStorage.hasOwnProperty(strKey)) {
        //缓存存在，直接返回
        var strTempObjLst: string = sessionStorage.getItem(strKey) as string;
        var arrPaperObjLst_Cache: Array<clsPaperEN> = JSON.parse(strTempObjLst);
        return arrPaperObjLst_Cache;
    }
    try {
        const responseText = await PaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
        var arrPaperObjLst: Array<clsPaperEN> = <Array<clsPaperEN>>responseText;
        sessionStorage.setItem(strKey, JSON.stringify(arrPaperObjLst));
        var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperObjLst.length}!`;
        console.log(strInfo);
        return arrPaperObjLst;
    }
    catch (e) {
        var strMsg: string = `从缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
        console.error(strMsg);
        throw (strMsg);
    }
}

/// <summary>
/// 根据条件对象, 从缓存的对象列表中获取子集.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
/// </summary>
/// <param name = "objstrSubViewpointId_Cond">条件对象</param>
/// <returns>对象列表子集</returns>
export async function PaperEx_GetSubObjLstById_CurrEduCls_Cache(objPaper_Cond: clsPaperEN, strid_CurrEduCls: string) {
    var arrPaperObjLst_Cache: Array<clsPaperEN> = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
    var arrPaper_Sel: Array<clsPaperEN> = arrPaperObjLst_Cache.filter(x => true);
    if (objPaper_Cond.sf_FldComparisonOp == null || objPaper_Cond.sf_FldComparisonOp == "") return arrPaper_Sel;
    var dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaper_Cond.sf_FldComparisonOp);
    //console.log("clsPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        var sstrKeys = GetObjKeys(objPaper_Cond);
        //console.log(sstrKeys);
        for (let strKey of sstrKeys) {
            if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] != null);
            var strComparisonOp = dicFldComparisonOp[strKey];
            var strValue = objPaper_Cond[strKey];
            var strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                    }
                    break;
                case "number":
                    if (strValue == 0) continue;
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
        var strMsg: string = `错误:[${e}]. \n根据条件:[${JSON.stringify(objPaper_Cond)}]缓存对象列表中获取子集对象不成功!`;
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsPaperEN>();
};
/// <summary>
/// 根据条件对象, 从缓存的对象列表中获取记录数.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
/// </summary>
/// <param name = "objPaper_Cond">条件对象</param>
/// <returns>对象列表记录数</returns>
export async function PaperEx_GetRecCountByCondById_CurrEduCls_Cache(objPaper_Cond: clsPaperEN, strid_CurrEduCls: string) {
    var arrPaperObjLst_Cache: Array<clsPaperEN> = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
    var arrPaper_Sel: Array<clsPaperEN> = arrPaperObjLst_Cache.filter(x => true);
    if (objPaper_Cond.sf_FldComparisonOp == null || objPaper_Cond.sf_FldComparisonOp == "") return arrPaper_Sel.length;
    var dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaper_Cond.sf_FldComparisonOp);
    //console.log("clsPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        var sstrKeys = GetObjKeys(objPaper_Cond);
        //console.log(sstrKeys);
        for (let strKey of sstrKeys) {
            if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] != null);
            var strComparisonOp = dicFldComparisonOp[strKey];
            var strValue = objPaper_Cond[strKey];
            var strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                    }
                    break;
                case "number":
                    if (strValue == 0) continue;
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
        var strMsg: string = `错误:[${e}]. \n根据条件:[${JSON.stringify(objPaper_Cond)}]从缓存对象列表中获取记录数不成功!`;
        console.error(strMsg);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return 0;
};

/// <summary>
/// 从缓存中获取分页对象列表.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
/// </summary>
/// <param name = "objPagerPara">分页参数结构</param>
/// <returns>对象列表</returns>
export async function PaperEx_GetObjLstByPagerById_CurrEduCls_Cache(objPagerPara: stuPagerPara, strid_CurrEduCls: string) {
    var arrPaperObjLst_Cache: Array<clsPaperEN> = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
    if (arrPaperObjLst_Cache.length == 0) return arrPaperObjLst_Cache;
    var arrPaper_Sel: Array<clsPaperEN> = arrPaperObjLst_Cache.filter(x => true);
    var obj_Cond: clsPaperEN = JSON.parse(objPagerPara.whereCond);
    var dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsPaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        var sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (let strKey of sstrKeys) {
            if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] != null);
            var strComparisonOp = dicFldComparisonOp[strKey];
            var strValue = obj_Cond[strKey];
            var strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                    }
                    break;
                case "number":
                    if (strValue == 0) continue;
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
        if (arrPaper_Sel.length == 0) return arrPaper_Sel;
        var intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        var intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            var sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            var strSortType: string = "asc";
            var strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            //                console.log(arrPaper_Sel);
            let objFirst = arrPaper_Sel[0];//第一个对象
            let strSortValue = objFirst[strSortFld];  //第一个对象排序字段值            
            let strSortFldType = typeof (strSortValue);//排序字段值的数据类型
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
        var strMsg: string = `错误:[${e}]. \n根据条件:[${objPagerPara.whereCond}]获取分页对象列表不成功!(In Paper_GetObjLstByPager_Cache)`;
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsPaperEN>();
};


/**
* 把一个扩展类的部分属性进行函数转换
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
* @param objPaperS:源对象
**/
export async function PaperEx_FuncMap_PaperTypeName(objPaper: clsPaperENEx) {
    const strThisFuncName = PaperEx_FuncMap_PaperTypeName.name;
    try {
        if (IsNullOrEmpty(objPaper.paperTypeName) == true) {
            const gs_PaperType_PaperTypeId = objPaper.paperTypeId;
            const gs_PaperType_PaperTypeName = await gs_PaperType_func(clsgs_PaperTypeEN.con_PaperTypeId, clsgs_PaperTypeEN.con_PaperTypeName, gs_PaperType_PaperTypeId);
            objPaper.paperTypeName = gs_PaperType_PaperTypeName;
        }
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000260)函数映射表对象数据出错,{0}.(in {1}.{2})", e, paperEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
    }
}
/**
* 把一个扩展类的部分属性进行函数转换
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
* @param objPaperS:源对象
**/
export async function PaperEx_FuncMap_UpdUserName(objPaper: clsPaperENEx) {
    const strThisFuncName = PaperEx_FuncMap_UpdUserName.name;
    try {
        if (IsNullOrEmpty(objPaper.updUserName) == true) {
            const vUsersSim_UserId = objPaper.updUser;
            const vUsersSim_UserName = await vUsersSim_func(clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, vUsersSim_UserId, clsSysPara4WebApi.cmPrjId);
            objPaper.updUserName = vUsersSim_UserName;
        }
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000262)函数映射表对象数据出错,{0}.(in {1}.{2})", e, paperEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
    }
}


/**
* 把一个扩展类的部分属性进行函数转换
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
* @param objPaperS:源对象
**/
export async function PaperEx_FuncMap_IsCollection(objPaper: clsPaperENEx) {
    const strThisFuncName = PaperEx_FuncMap_UpdUserName.name;
    try {
        const arrPaperCollectionLogObjLst = await PaperCollectionLog_GetObjLst_Cache(clsPublocalStorage.userId);
        const arr = arrPaperCollectionLogObjLst.filter(x => x.paperId == objPaper.paperId);
        objPaper.isCollection = arr.length > 0 ? true : false;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000262)函数映射表对象数据出错,{0}.(in {1}.{2})", e, paperEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
    }
}



/**
* 把一个扩展类的部分属性进行函数转换
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
* @param objPaperS:源对象
**/
export async function PaperEx_FuncMap_IsHasAttention(objPaper: clsPaperENEx) {
    const strThisFuncName = PaperEx_FuncMap_IsHasAttention.name;
    try {
        const arrgs_PaperAttentionObjLst = await gs_PaperAttention_GetObjLst_Cache(clsPublocalStorage.userId);
        const arr = arrgs_PaperAttentionObjLst.filter(x => x.paperId == objPaper.paperId);
        objPaper.isHasAttention = arr.length > 0 ? true : false;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000262)函数映射表对象数据出错,{0}.(in {1}.{2})", e, paperEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
    }
}


/**
* 把一个扩展类的部分属性进行函数转换
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
* @param objPaperS:源对象
**/
export async function PaperEx_FuncMap_IsSysVote(objPaper: clsPaperENEx) {
    const strThisFuncName = PaperEx_FuncMap_IsSysVote.name;
    try {
        const arrSysVoteObjLst = await SysVote_GetObjLst_Cache(clsPublocalStorage.userId);
        const arrSysVoteObjLst_Sel = arrSysVoteObjLst.filter(x=>x.voteTypeId == enumSysVoteType.Paper_01);
        const arr = arrSysVoteObjLst_Sel.filter(x => x.tableKey == objPaper.paperId);
        objPaper.isSysVote = arr.length > 0 ? true : false;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000262)函数映射表对象数据出错,{0}.(in {1}.{2})", e, paperEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
    }
}


export async function PaperEx_BindList_Paper(strTypeId: string, strDivName:string, arrPaperExObjLst: Array<clsPaperENEx>) {

    for (var objInFor of arrPaperExObjLst) {
        await PaperEx_FuncMapByFldName(clsPaperENEx.con_IsSysVote, objInFor);
        await PaperEx_FuncMapByFldName(clsPaperENEx.con_IsCollection, objInFor);
        await PaperEx_FuncMapByFldName(clsPaperENEx.con_IsHasAttention, objInFor);
        await PaperEx_FuncMapByFldName(clsPaperENEx.con_UpdUserName, objInFor);
        await PaperEx_FuncMapByFldName(clsPaperENEx.con_DS_Author, objInFor);
        await PaperEx_FuncMapByFldName(clsPaperENEx.con_DS_Keyword, objInFor);
        await PaperEx_FuncMapByFldName(clsPaperENEx.con_DS_LiteratureSources, objInFor);
        await PaperEx_FuncMapByFldName(clsPaperENEx.con_DS_Periodical, objInFor);

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
    var strWhereCond1 = " 1 =1 and updUser='" + clsPublocalStorage.userId + "' and voteTypeId='01'";
    var strWhereCond2 = " 1 =1 and updUser='" + clsPublocalStorage.userId + "'";

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
                if (objPaperEx.paperTypeId == enumgs_PaperType.OriginalThesis_02) {
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
                if (objPaperEx.paperTypeId == enumgs_PaperType.OriginalThesis_02) {
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
                if (IsNullOrEmpty(objPaperEx.updUserName) == false) {
                    strhtml += '<li class="date">编辑用户：' + objPaperEx.updUserName + '</li><li class="date">发表日期：' + objPaperEx.updDate + '</li></ul>';
                }

                strhtml += '<ul class="opts-btn">';


                //var objAttention = arrgs_PaperAttentionObjLst.find(x => x.paperId == objPaperEx.paperId);

                //if (objAttention == null) {
                if (objPaperEx.isHasAttention == false) {
                    strhtml += '<li><a href="javascript:void(0)" onclick=btn_Click(\'AddAttention\',"' + objPaperEx.paperId + '")><i class="layui-icon layui-icon-face-smile-b" style="font-size: 20px;"></i><b>关注</b></a></li>';

                } else {
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
                } else {
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
                } else {
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
                } else {
                    strhtml += '<li><a id="btnDownLoadFile" href="#" title="暂无下载文件"><i class="layui-icon layui-icon-download-circle" style="font-size: 24px; color: #1E9FFF;"></i><b>无下载文件</b></a></li>';
                }

            }

            strhtml += '</ul></div>';

            strhtml += '</dd></dl></div>';


        }
        const strDivName4Disp = Format("#{0}", strDivName);
        $(strDivName4Disp).html(strhtml);

    }
    catch (e) {
        console.error('catch(e)=');
        console.error(e);
        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        alert(strMsg);
    }
}
/**
 * 显示一个字段的单元信息
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
 * @param objPaperS:源对象
 **/
export async function PaperEx_FuncMap_DS_Author(objPaper: clsPaperENEx) {
    const strThisFuncName = PaperEx_FuncMap_DS_Author.name;
    try {
        if (IsNullOrEmpty(objPaper.ds_Author) == true) {
            const lblCurr = GetLabel_Empty("col-form-label text-right");
            const lblStyle_Title = GetLabel_Empty("text-secondary font-weight-bold");//;
            lblStyle_Title.innerHTML = "作者";
            const lblStyle_Content = GetLabel_Empty("text-black");//; await css_StyleEx_GetHtmlElementByStyleId(objCss_FldDispUnitStyle.styleId_Content, strContent);
            lblStyle_Content.innerHTML = objPaper.author;
            lblCurr.innerHTML = Format("{0}:{1}", lblStyle_Title.outerHTML, lblStyle_Content.outerHTML);
            objPaper.ds_Author = lblCurr.outerHTML;
        }
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000266)函数映射表对象数据出错,{0}.(in {1}.{2})", e, paperEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
    }
}

/**
* 显示一个字段的单元信息
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
* @param objPaperS:源对象
**/
export async function PaperEx_FuncMap_DS_Periodical(objPaper: clsPaperENEx) {
    const strThisFuncName = PaperEx_FuncMap_DS_Periodical.name;
    try {
        if (IsNullOrEmpty(objPaper.ds_Periodical) == true) {
            const lblCurr = GetLabel_Empty("col-form-label text-right");
            const lblStyle_Title = GetLabel_Empty("text-secondary font-weight-bold");//;
            lblStyle_Title.innerHTML = "期刊";
            const lblStyle_Content = GetLabel_Empty("text-black");//; await css_StyleEx_GetHtmlElementByStyleId(objCss_FldDispUnitStyle.styleId_Content, strContent);
            lblStyle_Content.innerHTML = objPaper.periodical;
            lblCurr.innerHTML = Format("{0}:{1}", lblStyle_Title.outerHTML, lblStyle_Content.outerHTML);
            objPaper.ds_Periodical = lblCurr.outerHTML;
        }
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000267)函数映射表对象数据出错,{0}.(in {1}.{2})", e, paperEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
    }
}
/**
* 显示一个字段的单元信息
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
* @param objPaperS:源对象
**/
export async function PaperEx_FuncMap_DS_LiteratureSources(objPaper: clsPaperENEx) {
    const strThisFuncName = PaperEx_FuncMap_DS_LiteratureSources.name;
    try {
        if (IsNullOrEmpty(objPaper.ds_LiteratureSources) == true) {
            const lblCurr = GetLabel_Empty("col-form-label text-right");
            const lblStyle_Title = GetLabel_Empty("text-secondary font-weight-bold");//;
            lblStyle_Title.innerHTML = "文献来源";
            const lblStyle_Content = GetLabel_Empty("text-black");//; await css_StyleEx_GetHtmlElementByStyleId(objCss_FldDispUnitStyle.styleId_Content, strContent);
            lblStyle_Content.innerHTML = objPaper.literatureSources;
            lblCurr.innerHTML = Format("{0}:{1}", lblStyle_Title.outerHTML, lblStyle_Content.outerHTML);
            objPaper.ds_LiteratureSources = lblCurr.outerHTML;
        }
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000268)函数映射表对象数据出错,{0}.(in {1}.{2})", e, paperEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
    }
}
/**
* 显示一个字段的单元信息
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
* @param objPaperS:源对象
**/
export async function PaperEx_FuncMap_DS_Keyword(objPaper: clsPaperENEx) {
    const strThisFuncName = PaperEx_FuncMap_DS_Keyword.name;
    try {
        if (IsNullOrEmpty(objPaper.ds_Keyword) == true) {
            const lblCurr = GetLabel_Empty("col-form-label text-right");
            const lblStyle_Title = GetLabel_Empty("text-secondary font-weight-bold");//;
            lblStyle_Title.innerHTML = "关键字";
            const lblStyle_Content = GetLabel_Empty("text-black");//; await css_StyleEx_GetHtmlElementByStyleId(objCss_FldDispUnitStyle.styleId_Content, strContent);
            lblStyle_Content.innerHTML = objPaper.keyword;
            lblCurr.innerHTML = Format("{0}:{1}", lblStyle_Title.outerHTML, lblStyle_Content.outerHTML);
            objPaper.ds_Keyword = lblCurr.outerHTML;
        }
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000269)函数映射表对象数据出错,{0}.(in {1}.{2})", e, paperEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
    }
}

   /* 显示vPaper对象的所有属性值
   (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
   <param name = "divContainer">显示容器</param>
   <param name = "arrPaperObjLst">需要绑定的对象列表</param>
 */
export async function PaperEx_BindTab_Paper(divContainer: string, arrPaperExObjLst: Array<clsPaperENEx>, objOperateList: clsOperateList) {
    const strThisFuncName = PaperEx_BindTab_Paper.name;
    var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
    if (o == null) {
        alert(`${divContainer}不存在！`);
        return;
    }
    var arrDataColumn: Array<clsDataColumn> =
        [
            {
                fldName: "",
                colHeader: "",
                text: "", tdClass: "text-left", sortBy: "", sortFun: SortFun, getDataSource: "",
                columnType: "CheckBox",
                orderNum: 1,
                funcName: () => { }
            },
            {
                fldName: clsPaperENEx.con_PaperTitle,
                colHeader: "论文标题",
                text: "", tdClass: "text-left",
                sortBy: "paperTitle", sortFun: SortFun, getDataSource: "",
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
                fldName: clsPaperENEx.con_Periodical,
                colHeader: "期刊",
                text: "", tdClass: "text-left",
                sortBy: "periodical", sortFun: SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            {
                fldName: clsPaperENEx.con_Author,
                colHeader: "作者",
                text: "", tdClass: "text-left",
                sortBy: "author", sortFun: SortFun, getDataSource: "",
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
                fldName: clsPaperENEx.con_Keyword,
                colHeader: "关键字",
                text: "", tdClass: "text-left",
                sortBy: "keyword", sortFun: SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            {
                fldName: clsPaperENEx.con_LiteratureSources,
                colHeader: "文献来源",
                text: "", tdClass: "text-left",
                sortBy: "literatureSources", sortFun: SortFun, getDataSource: "",
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
                fldName: clsPaperENEx.con_IsSubmit,
                colHeader: "是否提交",
                text: "", tdClass: "text-left",
                sortBy: "isSubmit", sortFun: SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            {
                fldName: clsPaperENEx.con_IsChecked,
                colHeader: "是否审核",
                text: "", tdClass: "text-left",
                sortBy: "isChecked", sortFun: SortFun, getDataSource: "",
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
                fldName: clsPaperENEx.con_UpdDate,
                colHeader: "提交日期",
                text: "", tdClass: "text-left",
                sortBy: "updDate", sortFun: SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            {
                fldName: clsPaperENEx.con_UpdUserName,
                colHeader: "提交用户",
                text: "", tdClass: "text-left",
                sortBy: "userName", sortFun: SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            {
                fldName: clsPaperENEx.con_Pcount,
                colHeader: "读写数",
                text: "", tdClass: "text-left",
                sortBy: "pcount", sortFun: SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            {
                fldName: clsPaperENEx.con_AttachmentCount,
                colHeader: "附件数",
                text: "", tdClass: "text-left",
                sortBy: "attachmentCount", sortFun: SortFun, getDataSource: "",
                columnType: "Label",
                orderNum: 1,
                funcName: () => { }
            },
            {
                fldName: "",
                colHeader: "详情",
                text: "详情", tdClass: "text-left",
                sortBy: "", sortFun: SortFun, getDataSource: "",
                columnType: "Button",
                orderNum: 1,
                funcName: (strKeyId: string, strText: string) => {
                    var btn1: HTMLElement = document.createElement("button");
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
        const strMsg = Format("扩展字段值的映射出错,{0}.(in {1}.{2})", e, paperEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return;
    }
    BindTab(o, arrPaperExObjLst, arrDataColumn, "paperId", objOperateList);
    //this.objPager.recCount = this.recCount;
    //this.objPager.pageSize = this.pageSize;
    //this.objPager.ShowPagerV2(this, this.divName4Pager);
}
 /** 扩展字段值的函数映射
 * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExtendFldFuncMap)
 * @param arrPaperExObjLst:需要映射的对象列表
 * @param arrDataColumn:用于绑定表的数据列信息
 **/
export async function PaperEx_ExtendFldFuncMap(arrPaperExObjLst: Array<clsPaperENEx>, arrDataColumn: Array<clsDataColumn>) {
    const arrFldName = clsPaperEN.AttributeName;
    for (const objDataColumn of arrDataColumn) {
        if (IsNullOrEmpty(objDataColumn.fldName) == true) continue;
        if (arrFldName.indexOf(objDataColumn.fldName) > -1) continue;
        for (const objInFor of arrPaperExObjLst) {
            await PaperEx_FuncMapByFldName(objDataColumn.fldName, objInFor);
        }
    }
}



export async function PaperEx_SynPaperStatisticsAsync(TeaUserId: string): Promise<boolean> {
    const strThisFuncName = "";
    var strAction = "GetTotalRevalidation";
    let strUrl = PaperEx_GetWebApiUrl(paperEx_Controller, strAction);

    try {
        const response = await axios.get(strUrl,
            {
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
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}


/// <summary>
/// 获取论文中的用户数量
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
/// </summary>
/// <param name = "strWhereCond">条件</param>
/// <returns>获取的相应对象列表</returns>
export async function PaperEx_GetUserNumObjLstAsync(strWhereCond: string): Promise<Array<clsPaperEN>> {
    const strThisFuncName = "GetUserNumObjLstAsync";
    var strAction = "GetUserNumObjLst";
    let strUrl = PaperEx_GetWebApiUrl(paperEx_Controller, strAction);
    var mapParam: Dictionary = new Dictionary();
    mapParam.add("strWhereCond", strWhereCond);
    let strData = mapParam.getParamText();// "例如: strIdentityID =01";
    try {
        const response = await axios.get(strUrl,
            {
                params: { "strWhereCond": strWhereCond }
            });
        const data = response.data;
        if (data.errorId == 0) {
            const returnObjLst = data.returnObjLst;
            if (returnObjLst == null) {
                const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperEx_Controller, strThisFuncName);
                console.error(strNullInfo);
                throw (strNullInfo);
            }
            //console.log(returnObjLst);
            const arrObjLst = Paper_GetObjLstByJSONObjLst(returnObjLst);
            return (arrObjLst);
        }
        else {
            console.error(data.errorMsg);
            throw (data.errorMsg);
        }
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}


export async function vPaperEx_SynPaperStatisticsAsync(TeaUserId: string): Promise<boolean> {
    const strThisFuncName = "";
    var strAction = "GetTotalRevalidation";
    let strUrl = PaperEx_GetWebApiUrl(paperEx_Controller, strAction);

    try {
        const response = await axios.get(strUrl,
            {
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
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}










/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// <summary>
/// 绑定基于论文缓存的用户下拉框
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
/// </summary>
/// <param name = "objDDL">需要绑定当前表的下拉框</param>
export async function vPaperEx_BindDdl_UsersInvSimPaper_Cache(strDdlName: string, objUsers_Cond: clsUsersEN) {
    var objDdl = document.getElementById(strDdlName);
    if (objDdl == null) {
        var strMsg = `下拉框：${strDdlName} 不存在！`;
        alert(strMsg);
        throw (strMsg);
    }
    //为数据源于表的下拉框设置内容
    console.log("开始：BindDdl_UserId_Cache");
    var arrvPaperSim: Array<clsvPaperSimEN> = await vPaperSim_GetObjLstAsync("1=1");
    var arrObjLst_Sel: Array<clsUsersEN> = arrvPaperSim.map(vPaperEx_GetUsersBvPaperSim);
    arrObjLst_Sel = vPaperEx_uniq(arrObjLst_Sel);
    console.log(arrObjLst_Sel);
    arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsUsersEN.con_UserName]);
    BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsUsersEN.con_UserId, clsUsersEN.con_UserName, "编辑用户");
}

export function vPaperEx_uniq(arr: Array<clsUsersEN>): Array<clsUsersEN> {
    let arrObjLst_New: Array<clsUsersEN> = new Array<clsUsersEN>();
    for (let x of arr) {
        if (vPaperEx_IsExist(arrObjLst_New, x) == false) {
            arrObjLst_New.push(x);
        }
    }
    return arrObjLst_New;
}

export function vPaperEx_IsExist(arr: Array<clsUsersEN>, key: clsUsersEN) {
    let arr_Sel = arr.filter(x => x.userId == key.userId);
    if (arr_Sel.length > 0) return true;
    return false;
}


export function vPaperEx_GetUsersBvPaperSim(objvPaperSim: clsvPaperSimEN): clsUsersEN {
    var objUsers: clsUsersEN = new clsUsersEN();
    objUsers.userId = objvPaperSim.updUser;
    objUsers.userName = objvPaperSim.userName;
    return objUsers;
}




/// <summary>
/// 绑定基于论文缓存的专业下拉框
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
/// </summary>
/// <param name = "objDDL">需要绑定当前表的下拉框</param>
export async function vPaperEx_BindDdl_XzMajorInvSimPaper_Cache(strDdlName: string, objXzMajor_Cond: clsXzMajorEN) {
    var objDdl = document.getElementById(strDdlName);
    if (objDdl == null) {
        var strMsg = `下拉框：${strDdlName} 不存在！`;
        alert(strMsg);
        throw (strMsg);
    }
    //为数据源于表的下拉框设置内容
    console.log("开始：BindDdl_id_XzMajor_Cache");
    var arrvPaperSim: Array<clsvPaperSimEN> = await vPaperSim_GetObjLstAsync("1=1");
    var arrObjLst_Sel: Array<clsXzMajorEN> = arrvPaperSim.map(vPaperEx_GetXzMajorBvPaperSim);
    arrObjLst_Sel = vPaperEx_XzMajorUniq(arrObjLst_Sel);
    console.log(arrObjLst_Sel);
    arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsXzMajorEN.con_MajorName]);
    BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsXzMajorEN.con_id_XzMajor, clsXzMajorEN.con_MajorName, "专业");
}

export function vPaperEx_XzMajorUniq(arr: Array<clsXzMajorEN>): Array<clsXzMajorEN> {
    let arrObjLst_New: Array<clsXzMajorEN> = new Array<clsXzMajorEN>();
    for (let x of arr) {
        if (vPaperEx_XzMajorIsExist(arrObjLst_New, x) == false) {
            arrObjLst_New.push(x);
        }
    }
    return arrObjLst_New;
}

export function vPaperEx_XzMajorIsExist(arr: Array<clsXzMajorEN>, key: clsXzMajorEN) {
    let arr_Sel = arr.filter(x => x.id_XzMajor == key.id_XzMajor);
    if (arr_Sel.length > 0) return true;
    return false;
}


export function vPaperEx_GetXzMajorBvPaperSim(objvPaperSim: clsvPaperSimEN): clsXzMajorEN {
    var objXzMajor: clsXzMajorEN = new clsXzMajorEN();
    objXzMajor.id_XzMajor = objvPaperSim.id_XzMajor;
    objXzMajor.majorName = objvPaperSim.majorName;
    return objXzMajor;
}



/// <summary>
/// 根据教学班获取对象列表，用对象列表表示
/// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
/// </summary>
/// <param name = "strId_CurrEduCls">教学班流水号</param>
/// <returns>获取的相应对象列表</returns>
export async function vPaperEx_GetObjLstById_CurrEduCls(strId_CurrEduCls: string, strCourseId: string): Promise<Array<clsPaperEN>> {
    const strThisFuncName = "GetObjLstById_CurrEduCls";
    var strAction = "GetObjLstById_CurrEduCls";
    let strUrl = PaperEx_GetWebApiUrl(paperEx_Controller, strAction);

    try {
        const response = await axios.get(strUrl,
            {
                params: {
                    "strId_CurrEduCls": strId_CurrEduCls,
                    "strCourseId": strCourseId
                }
            });
        const data = response.data;
        if (data.errorId == 0) {
            const returnObjLst = data.returnObjLst;
            if (returnObjLst == null) {
                const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperEx_Controller, strThisFuncName);
                console.error(strNullInfo);
                throw (strNullInfo);
            }
            //console.log(returnObjLst);
            const arrObjLst = Paper_GetObjLstByJSONObjLst(returnObjLst);
            return (arrObjLst);
        }
        else {
            console.error(data.errorMsg);
            throw (data.errorMsg);
        }
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

/// <summary>
/// 根据关键字获取相关对象, 从缓存中获取.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
/// </summary>
/// <param name = "strPaperId">所给的关键字</param>
/// <returns>对象</returns>
export async function vPaperEx_GetObjByPaperIdById_CurrEduCls_Cache(strPaperId: string, strid_CurrEduCls: string, strCourseId: string) {
    var arrvPaperObjLst_Cache: Array<clsPaperEN> = await vPaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls, strCourseId);
    var obj: clsPaperEN = new clsPaperEN();
    try {
        var arrvPaper_Sel: Array<clsPaperEN> = arrvPaperObjLst_Cache.filter(x => x.paperId == strPaperId);
        var objvPaper: clsPaperEN;
        if (arrvPaper_Sel.length > 0) {
            objvPaper = arrvPaper_Sel[0];
            return objvPaper;
        }
        else {
            return obj;
        }
    }
    catch (e) {
        var strMsg: string = `错误:[${e}]. \n根据关键字:[${strPaperId}]获取相应的对象不成功!`;
        console.error(strMsg);
        alert(strMsg);
    }
    return obj;
};


/// <summary>
/// 刷新本类中的缓存.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
/// </summary>
export function PaperEx_ReFreshThisCacheById_CurrEduClsBakFromV(strid_CurrEduCls: string) {
    var strMsg: string = "";
    if (clsSysPara4WebApi.spSetRefreshCacheOn == true) {
        var strKey: string = `${clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
        switch (clsPaperEN.CacheModeId) {
            case "04"://sessionStorage
                sessionStorage.removeItem(strKey);
                break;
            case "03"://localStorage
                localStorage.removeItem(strKey);
                break;
            case "02"://ClientCache
                CacheHelper.Remove(strKey);
                break;
            default:
                CacheHelper.Remove(strKey);
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


/// <summary>
/// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
/// </summary>
/// <returns>从本地缓存中获取的对象列表</returns>
export async function vPaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls: string, strCourseId: string) {
    var arrvPaperObjLst_Cache: Array<clsPaperEN>;
    switch (clsPaperEN.CacheModeId) {
        case "04"://sessionStorage
            arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_sessionStorage(strid_CurrEduCls, strCourseId);
            break;
        case "03"://localStorage
            arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_localStorage(strid_CurrEduCls, strCourseId);
            break;
        case "02"://ClientCache
            arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls, strCourseId);
            break;
        default:
            arrvPaperObjLst_Cache = await vPaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls, strCourseId);
            break;
    }
    return arrvPaperObjLst_Cache;
}

/// <summary>
/// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
/// </summary>
/// <returns>从本地缓存中获取的对象列表</returns>
export async function vPaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls: string, strCourseId: string) {
    //初始化列表缓存
    var strWhereCond: string = "1=1";

    strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
    var strKey: string = `${clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
    if (strKey == "") {
        console.log("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (CacheHelper.Exsits(strKey)) {
        //缓存存在，直接返回
        var arrvPaperObjLst_Cache: Array<clsPaperEN> = CacheHelper.Get(strKey);
        return arrvPaperObjLst_Cache;
    }
    try {
        const arrPaperExObjLst = await vPaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls, strCourseId);
        
        CacheHelper.Add(strKey, arrPaperExObjLst);
        var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperExObjLst.length}!`;
        console.log(strInfo);
        return arrPaperExObjLst;
    }
    catch (e) {
        var strMsg: string = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
        console.error(strMsg);
        throw (strMsg);
    }
}

/// <summary>
/// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
/// </summary>
/// <returns>从本地缓存中获取的对象列表</returns>
export async function vPaperEx_GetObjLstById_CurrEduCls_localStorage(strid_CurrEduCls: string, strCourseId: string) {
    //初始化列表缓存
    var strWhereCond: string = "1=1";

    strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
    var strKey: string = `${clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
    if (strKey == "") {
        console.log("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (localStorage.hasOwnProperty(strKey)) {
        //缓存存在，直接返回
        var strTempObjLst: string = localStorage.getItem(strKey) as string;
        var arrvPaperObjLst_Cache: Array<clsPaperEN> = JSON.parse(strTempObjLst);
        return arrvPaperObjLst_Cache;
    }
    try {
        const arrPaperExObjLst = await vPaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls, strCourseId);
     
        localStorage.setItem(strKey, JSON.stringify(arrPaperExObjLst));
        var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperExObjLst.length}!`;
        console.log(strInfo);
        return arrPaperExObjLst;
    }
    catch (e) {
        var strMsg: string = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
        console.error(strMsg);
        throw (strMsg);
    }
}
/// <summary>
/// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
/// </summary>
/// <returns>从本地缓存中获取的对象列表</returns>
export async function vPaperEx_GetObjLstById_CurrEduCls_sessionStorage(strid_CurrEduCls: string, strCourseId: string) {
    //初始化列表缓存
    var strWhereCond: string = "1=1";

    strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
    var strKey: string = `${clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
    if (strKey == "") {
        console.log("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (sessionStorage.hasOwnProperty(strKey)) {
        //缓存存在，直接返回
        var strTempObjLst: string = sessionStorage.getItem(strKey) as string;
        var arrvPaperObjLst_Cache: Array<clsPaperEN> = JSON.parse(strTempObjLst);
        return arrvPaperObjLst_Cache;
    }
    try {
        const arrPaperExObjLst = await vPaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls, strCourseId);

        sessionStorage.setItem(strKey, JSON.stringify(arrPaperExObjLst));
        var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperExObjLst.length}!`;
        console.log(strInfo);
        return arrPaperExObjLst;
    }
    catch (e) {
        var strMsg: string = `从缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
        console.error(strMsg);
        throw (strMsg);
    }
}

/// <summary>
/// 根据条件对象, 从缓存的对象列表中获取子集.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
/// </summary>
/// <param name = "objstrSubViewpointId_Cond">条件对象</param>
/// <returns>对象列表子集</returns>
export async function vPaperEx_GetSubObjLstById_CurrEduCls_Cache(objvPaper_Cond: clsPaperEN, strid_CurrEduCls: string, strCourseId: string) {
    var arrvPaperObjLst_Cache: Array<clsPaperEN> = await vPaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls, strCourseId);
    var arrvPaper_Sel: Array<clsPaperEN> = arrvPaperObjLst_Cache.filter(x => true);
    if (objvPaper_Cond.sf_FldComparisonOp == null || objvPaper_Cond.sf_FldComparisonOp == "") return arrvPaper_Sel;
    var dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaper_Cond.sf_FldComparisonOp);
    //console.log("clsvPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        var sstrKeys = GetObjKeys(objvPaper_Cond);
        //console.log(sstrKeys);
        for (let strKey of sstrKeys) {
            if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] != null);
            var strComparisonOp = dicFldComparisonOp[strKey];
            var strValue = objvPaper_Cond[strKey];
            var strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] == strValue);
                    }
                    break;
                case "number":
                    if (strValue == 0) continue;
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
        var strMsg: string = `错误:[${e}]. \n根据条件:[${JSON.stringify(objvPaper_Cond)}]缓存对象列表中获取子集对象不成功!`;
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsPaperEN>();
};
/// <summary>
/// 根据条件对象, 从缓存的对象列表中获取记录数.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
/// </summary>
/// <param name = "objvPaper_Cond">条件对象</param>
/// <returns>对象列表记录数</returns>
export async function vPaperEx_GetRecCountByCondById_CurrEduCls_Cache(objvPaper_Cond: clsPaperEN, strid_CurrEduCls: string, strCourseId: string) {
    var arrvPaperObjLst_Cache: Array<clsPaperEN> = await vPaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls, strCourseId);
    var arrvPaper_Sel: Array<clsPaperEN> = arrvPaperObjLst_Cache.filter(x => true);
    if (objvPaper_Cond.sf_FldComparisonOp == null || objvPaper_Cond.sf_FldComparisonOp == "") return arrvPaper_Sel.length;
    var dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaper_Cond.sf_FldComparisonOp);
    //console.log("clsvPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        var sstrKeys = GetObjKeys(objvPaper_Cond);
        //console.log(sstrKeys);
        for (let strKey of sstrKeys) {
            if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] != null);
            var strComparisonOp = dicFldComparisonOp[strKey];
            var strValue = objvPaper_Cond[strKey];
            var strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] == strValue);
                    }
                    break;
                case "number":
                    if (strValue == 0) continue;
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
        var strMsg: string = `错误:[${e}]. \n根据条件:[${JSON.stringify(objvPaper_Cond)}]从缓存对象列表中获取记录数不成功!`;
        console.error(strMsg);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return 0;
};

/// <summary>
/// 从缓存中获取分页对象列表.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
/// </summary>
/// <param name = "objPagerPara">分页参数结构</param>
/// <returns>对象列表</returns>
export async function vPaperEx_GetObjLstByPagerById_CurrEduCls_Cache(objPagerPara: stuPagerPara, strid_CurrEduCls: string, strCourseId: string) {
    var arrvPaperObjLst_Cache: Array<clsPaperEN> = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
    if (arrvPaperObjLst_Cache.length == 0) return arrvPaperObjLst_Cache;
    var arrvPaper_Sel: Array<clsPaperEN> = arrvPaperObjLst_Cache.filter(x => true);
    var obj_Cond: clsPaperEN = JSON.parse(objPagerPara.whereCond);
    var dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsvPaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        var sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (let strKey of sstrKeys) {
            if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
            arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] != null);
            var strComparisonOp = dicFldComparisonOp[strKey];
            var strValue = obj_Cond[strKey];
            var strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrvPaper_Sel = arrvPaper_Sel.filter(x => x[strKey] == strValue);
                    }
                    break;
                case "number":
                    if (strValue == 0) continue;
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
        if (arrvPaper_Sel.length == 0) return arrvPaper_Sel;
        var intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        var intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            var sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            var strSortType: string = "asc";
            var strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            //                console.log(arrvPaper_Sel);
            let objFirst = arrvPaper_Sel[0];//第一个对象
            let strSortValue = objFirst[strSortFld];  //第一个对象排序字段值            
            let strSortFldType = typeof (strSortValue);//排序字段值的数据类型
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
        var strMsg: string = `错误:[${e}]. \n根据条件:[${objPagerPara.whereCond}]获取分页对象列表不成功!(In vPaper_GetObjLstByPager_Cache)`;
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsPaperEN>();
};
