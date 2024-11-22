//import * as QQ from "q";
import axios from "axios";
import { clsgs_TotalDataStatisticsEN } from "../../L0_Entity/GraduateEduTools/clsgs_TotalDataStatisticsEN.js";
import { clsgs_TotalDataStatisticsENEx } from "../../L0_Entity/GraduateEduTools/clsgs_TotalDataStatisticsENEx.js";
import { gs_TotalDataStatistics_FilterFunByKey, gs_TotalDataStatistics_GetObjLstAsync, gs_TotalDataStatistics_GetObjLstByJSONObjLst, gs_TotalDataStatistics_GetObjLst_Cache, gs_TotalDataStatistics_GetObjLst_ClientCache, gs_TotalDataStatistics_GetObjLst_localStorage, gs_TotalDataStatistics_GetObjLst_sessionStorage, gs_TotalDataStatistics_SortFunByKey } from "../../L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { GetObjKeys, GetSortExpressInfo, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { BindTab } from "../../PubFun/clsCommFunc4Web.js";
import { Format, IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
var ResponseData: tzResponseData;
export const gs_TotalDataStatisticsEx_Controller = "gs_TotalDataStatisticsExApi";
export const gs_TotalDataStatisticsEx_ConstructorName = "gs_TotalDataStatisticsEx";

/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function gs_TotalDataStatisticsEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objgs_TotalDataStatisticsENS:源对象
* @returns 目标对象=>clsgs_TotalDataStatisticsEN:objgs_TotalDataStatisticsENT
**/
export function gs_TotalDataStatisticsEx_CopyToEx(objgs_TotalDataStatisticsENS: clsgs_TotalDataStatisticsEN): clsgs_TotalDataStatisticsENEx {
    const strThisFuncName = gs_TotalDataStatisticsEx_CopyToEx.name;
    const objgs_TotalDataStatisticsENT = new clsgs_TotalDataStatisticsENEx();
    try {
        ObjectAssign(objgs_TotalDataStatisticsENT, objgs_TotalDataStatisticsENS);
        return objgs_TotalDataStatisticsENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, gs_TotalDataStatisticsEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objgs_TotalDataStatisticsENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function gs_TotalDataStatisticsEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara, strid_CurrEduCls: string): Promise<Array<clsgs_TotalDataStatisticsENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrgs_TotalDataStatisticsObjLst = await gs_TotalDataStatistics_GetObjLst_Cache(strid_CurrEduCls);
    const arrgs_TotalDataStatisticsExObjLst = arrgs_TotalDataStatisticsObjLst.map(gs_TotalDataStatisticsEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrgs_TotalDataStatisticsExObjLst) {
            const conFuncMap = await gs_TotalDataStatisticsEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrgs_TotalDataStatisticsExObjLst.length == 0) return arrgs_TotalDataStatisticsExObjLst;
    let arrgs_TotalDataStatistics_Sel: Array<clsgs_TotalDataStatisticsENEx> = arrgs_TotalDataStatisticsExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objgs_TotalDataStatistics_Cond = new clsgs_TotalDataStatisticsENEx();
    ObjectAssign(objgs_TotalDataStatistics_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsgs_TotalDataStatisticsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objgs_TotalDataStatistics_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrgs_TotalDataStatistics_Sel.length == 0) return arrgs_TotalDataStatistics_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.sort(gs_TotalDataStatisticsEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.sort(objPagerPara.sortFun);
        }
        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.slice(intStart, intEnd);
        return arrgs_TotalDataStatistics_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_TotalDataStatisticsEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsgs_TotalDataStatisticsENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function gs_TotalDataStatisticsEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_TotalDataStatisticsENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrgs_TotalDataStatisticsExObjLst = await gs_TotalDataStatistics_GetObjLstAsync(objPagerPara.whereCond);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrgs_TotalDataStatisticsExObjLst) {
            const conFuncMap = await gs_TotalDataStatisticsEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrgs_TotalDataStatisticsExObjLst.length == 0) return arrgs_TotalDataStatisticsExObjLst;
    let arrgs_TotalDataStatistics_Sel: Array<clsgs_TotalDataStatisticsENEx> = arrgs_TotalDataStatisticsExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.sort(gs_TotalDataStatisticsEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.sort(objPagerPara.sortFun);
        }
        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.slice(intStart, intEnd);
        return arrgs_TotalDataStatistics_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_TotalDataStatisticsEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsgs_TotalDataStatisticsENEx>();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function gs_TotalDataStatisticsEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return gs_TotalDataStatistics_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return gs_TotalDataStatistics_SortFunByKey(strKey, AscOrDesc);
        }
    }
}

/**
 * 根据扩展字段名去调用相应的映射函数
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
 * @param strFldName:扩展字段名
 * @param  obj{0}Ex:需要转换的对象
 * @returns 针对扩展字段名对转换对象进行函数映射
*/
export function gs_TotalDataStatisticsEx_FuncMapByFldName(strFldName: string, objgs_TotalDataStatisticsEx: clsgs_TotalDataStatisticsENEx) {
    const strThisFuncName = gs_TotalDataStatisticsEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsgs_TotalDataStatisticsEN.AttributeName;
    if (arrFldName.indexOf(strFldName) > -1) return;
    //针对扩展字段进行映射
    switch (strFldName) {
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
export async function gs_TotalDataStatisticsEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return gs_TotalDataStatistics_FilterFunByKey(strKey, value);
    }
}


/// <summary>
/// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
/// </summary>
/// <returns>从本地缓存中获取的对象列表</returns>
export async function gs_TotalDataStatisticsEx_GetObjLst_ClientCache(strid_CurrEduCls: string) {
    //初始化列表缓存
    var strWhereCond: string = "1=1";
    //clsgs_TotalDataStatisticsWApi.InitListCache();
    strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
    var strKey: string = `${clsgs_TotalDataStatisticsEN._CurrTabName}_${strid_CurrEduCls}`;
    if (strKey == "") {
        console.log("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (CacheHelper.Exsits(strKey)) {
        //缓存存在，直接返回
        var arrgs_TotalDataStatisticsObjLst_Cache: Array<clsgs_TotalDataStatisticsEN> = CacheHelper.Get(strKey);
        return arrgs_TotalDataStatisticsObjLst_Cache;
    }
    try {
        const responseText = await gs_TotalDataStatisticsEx_GetObjLstEx(strWhereCond);
        var arrgs_TotalDataStatisticsObjLst: Array<clsgs_TotalDataStatisticsEN> = <Array<clsgs_TotalDataStatisticsEN>>responseText;
        CacheHelper.Add(strKey, arrgs_TotalDataStatisticsObjLst);
        var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrgs_TotalDataStatisticsObjLst.length}!`;
        console.log(strInfo);
        return arrgs_TotalDataStatisticsObjLst;
    }
    catch (e) {
        console.log("GetObjLst_Cache:e");
        console.error(e);
        var strMsg: string = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
        throw (strMsg);
    }
}
/// <summary>
/// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
/// </summary>
/// <returns>从本地缓存中获取的对象列表</returns>
export async function gs_TotalDataStatisticsEx_GetObjLst_Cache(strid_CurrEduCls: string) {
    var arrgs_TotalDataStatisticsObjLst_Cache: Array<clsgs_TotalDataStatisticsEN>;
    switch (clsgs_TotalDataStatisticsEN.CacheModeId) {
        case "04"://sessionStorage
            arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_sessionStorage(strid_CurrEduCls);
            break;
        case "03"://localStorage
            arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_localStorage(strid_CurrEduCls);
            break;
        case "02"://ClientCache
            arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_ClientCache(strid_CurrEduCls);
            break;
        default:
            arrgs_TotalDataStatisticsObjLst_Cache = await gs_TotalDataStatistics_GetObjLst_ClientCache(strid_CurrEduCls);
            break;
    }
    return arrgs_TotalDataStatisticsObjLst_Cache;
}
/// <summary>
/// 根据条件对象, 从缓存的对象列表中获取子集.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
/// </summary>
/// <param name = "objstrTotalDataId_Cond">条件对象</param>
/// <returns>对象列表子集</returns>
export async function gs_TotalDataStatisticsEx_GetSubObjLst_CacheEx(objgs_TotalDataStatistics_Cond: clsgs_TotalDataStatisticsEN, strid_CurrEduCls: string) {
    var arrgs_TotalDataStatisticsObjLst_Cache: Array<clsgs_TotalDataStatisticsEN> = await gs_TotalDataStatisticsEx_GetObjLst_Cache(strid_CurrEduCls);
    var arrgs_TotalDataStatistics_Sel: Array<clsgs_TotalDataStatisticsEN> = arrgs_TotalDataStatisticsObjLst_Cache.filter(x => true);
    if (objgs_TotalDataStatistics_Cond.sf_FldComparisonOp == null || objgs_TotalDataStatistics_Cond.sf_FldComparisonOp == "") return arrgs_TotalDataStatistics_Sel;
    var dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TotalDataStatistics_Cond.sf_FldComparisonOp);
    //console.log("clsgs_TotalDataStatisticsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        var sstrKeys = GetObjKeys(objgs_TotalDataStatistics_Cond);
        //console.log(sstrKeys);
        for (let strKey of sstrKeys) {
            if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
            arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey] != null);
            var strComparisonOp = dicFldComparisonOp[strKey];
            var strValue = objgs_TotalDataStatistics_Cond[strKey];
            var strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey].toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey] == strValue);
                    }
                    break;
                case "number":
                    if (strValue == 0) continue;
                    if (strComparisonOp == "=") {
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey] == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey] >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey] <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey] > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrgs_TotalDataStatistics_Sel = arrgs_TotalDataStatistics_Sel.filter(x => x[strKey] <= strValue);
                    }
                    break;
            }
        }
        return arrgs_TotalDataStatistics_Sel;
    }
    catch (e) {
        var strMsg: string = `错误:[${e}]. \n根据条件:[${JSON.stringify(objgs_TotalDataStatistics_Cond)}]缓存对象列表中获取子集对象不成功!`;
        throw new Error(strMsg);
    }
    return new Array<clsgs_TotalDataStatisticsEN>();
};




/// <summary>
/// 根据条件获取是否存在相应的记录？
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
/// </summary>
/// <param name = "strWhereCond">条件</param>
/// <returns>是否存在记录？</returns>
export async function gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync(strId_CurrEduCls: string, updUser: string): Promise<boolean> {
    const strThisFuncName = "";
    var strAction = "GetTotalStatisticsByTable";
    let strUrl = gs_TotalDataStatisticsEx_GetWebApiUrl(gs_TotalDataStatisticsEx_Controller, strAction);
    var mapParam: Dictionary = new Dictionary();
    mapParam.add("strId_CurrEduCls", strId_CurrEduCls);
    mapParam.add("updUser", updUser);
    let strData = mapParam.getParamText();// "例如: strIdentityID =01";
    try {
        const response = await axios.get(strUrl,
            {
                params: {
                    "strId_CurrEduCls": strId_CurrEduCls,
                    "updUser": updUser }
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
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatisticsEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatisticsEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

//子数据表添加修改删除、总数据表做出相应的添加修改删除、3个参数(主键，字表类型、页面操作类型123；)、string strTablekey, string strTotalDataTypeId, string PageTypeId
export async function gs_TotalDataStatisticsEx_AddAndUpdateAndDeleteTotalStatis(strTablekey: string, strTotalDataTypeId: string, PageTypeId: string, Id_CurrEduCls: string): Promise<boolean> {
    const strThisFuncName = "";
    var strAction = "AddAndUpdateAndDeleteTotalStatis";
    let strUrl = gs_TotalDataStatisticsEx_GetWebApiUrl(gs_TotalDataStatisticsEx_Controller, strAction);

    try {
        const response = await axios.get(strUrl,
            {
                params: {
                    "strTablekey": strTablekey,
                    "strTotalDataTypeId": strTotalDataTypeId,
                    "PageTypeId": PageTypeId,
                    "Id_CurrEduCls": Id_CurrEduCls
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
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatisticsEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatisticsEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}



//获取总表统计 各类型表数据的 教师打分 、学生打分数据；
export async function gs_TotalDataStatisticsEx_GetObjLstEx(strWhereCond: string): Promise<Array<clsgs_TotalDataStatisticsEN>> {
    const strThisFuncName = "GetObjLstEx";
    var strAction = "GetObjLstEx";
    let strUrl = gs_TotalDataStatisticsEx_GetWebApiUrl(gs_TotalDataStatisticsEx_Controller, strAction);
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
                const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TotalDataStatisticsEx_Controller, strThisFuncName);
                console.error(strNullInfo);
                throw (strNullInfo);
            }
            //console.log(returnObjLst);
            const arrObjLst = gs_TotalDataStatistics_GetObjLstByJSONObjLst(returnObjLst);
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
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatisticsEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatisticsEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}



/// <summary>
/// 根据条件获取相应的记录对象列表
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
/// </summary>
/// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
/// <returns>获取的相应记录对象列表</returns>
export async function gs_TotalDataStatisticsEx_GetObjLstByPagerAsyncEx(objPagerPara: stuPagerPara): Promise<Array<clsgs_TotalDataStatisticsEN>> {
    const strThisFuncName = "GetObjLstByPagerAsyncEx";
    var strAction = "GetObjLstByPagerEx";
    let strUrl = gs_TotalDataStatisticsEx_GetWebApiUrl(gs_TotalDataStatisticsEx_Controller, strAction);
    var mapParam: Dictionary = stuPagerPara.GetMapParam(objPagerPara);
    let strData = mapParam.getParamText();// "例如: strIdentityID =01";
    try {
        const response = await axios.post(strUrl, objPagerPara);
        const data = response.data;
        if (data.errorId == 0) {
            const returnObjLst = data.returnObjLst;
            if (returnObjLst == null) {
                const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TotalDataStatisticsEx_Controller, strThisFuncName);
                console.error(strNullInfo);
                throw (strNullInfo);
            }
            //console.log(returnObjLst);
            const arrObjLst = gs_TotalDataStatistics_GetObjLstByJSONObjLst(returnObjLst);
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
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataStatisticsEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataStatisticsEx_Controller, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}


