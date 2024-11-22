
//import * as QQ from "q";
import { clsCurrEduClsEN } from "../../L0_Entity/DailyRunning/clsCurrEduClsEN.js";
import { CurrEduCls_GetObjLstAsync, CurrEduCls_ReFreshThisCache } from "../../L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js";

import { clsCurrEduClsENEx } from "../../L0_Entity/DailyRunning/clsCurrEduClsENEx.js";
import { CurrEduCls_FilterFunByKey, CurrEduCls_GetObjLst_Cache, CurrEduCls_SortFunByKey } from "../../L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js";
import { GetObjKeys, GetSortExpressInfo, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { Format, IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi } from "../../PubFun/clsSysPara4WebApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
export const currEduClsEx_Controller = "CurrEduClsExApi";
export const currEduClsEx_ConstructorName = "currEduClsEx";

/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function CurrEduClsEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objCurrEduClsENS:源对象
* @returns 目标对象=>clsCurrEduClsEN:objCurrEduClsENT
**/
export function CurrEduClsEx_CopyToEx(objCurrEduClsENS: clsCurrEduClsEN): clsCurrEduClsENEx {
    const strThisFuncName = CurrEduClsEx_CopyToEx.name;
    const objCurrEduClsENT = new clsCurrEduClsENEx();
    try {
        ObjectAssign(objCurrEduClsENT, objCurrEduClsENS);
        return objCurrEduClsENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, currEduClsEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objCurrEduClsENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function CurrEduClsEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara): Promise<Array<clsCurrEduClsENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrCurrEduClsObjLst = await CurrEduCls_GetObjLst_Cache();
    const arrCurrEduClsExObjLst = arrCurrEduClsObjLst.map(CurrEduClsEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrCurrEduClsExObjLst) {
            const conFuncMap = await CurrEduClsEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrCurrEduClsExObjLst.length == 0) return arrCurrEduClsExObjLst;
    let arrCurrEduCls_Sel: Array<clsCurrEduClsENEx> = arrCurrEduClsExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objCurrEduCls_Cond = new clsCurrEduClsENEx();
    ObjectAssign(objCurrEduCls_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsCurrEduClsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objCurrEduCls_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrCurrEduCls_Sel = arrCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrCurrEduCls_Sel.length == 0) return arrCurrEduCls_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrCurrEduCls_Sel = arrCurrEduCls_Sel.sort(CurrEduClsEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrCurrEduCls_Sel = arrCurrEduCls_Sel.sort(objPagerPara.sortFun);
        }
        arrCurrEduCls_Sel = arrCurrEduCls_Sel.slice(intStart, intEnd);
        return arrCurrEduCls_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, currEduClsEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsCurrEduClsENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function CurrEduClsEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsCurrEduClsENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrCurrEduClsExObjLst = await CurrEduCls_GetObjLstAsync(objPagerPara.whereCond);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrCurrEduClsExObjLst) {
            const conFuncMap = await CurrEduClsEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrCurrEduClsExObjLst.length == 0) return arrCurrEduClsExObjLst;
    let arrCurrEduCls_Sel: Array<clsCurrEduClsENEx> = arrCurrEduClsExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrCurrEduCls_Sel = arrCurrEduCls_Sel.sort(CurrEduClsEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrCurrEduCls_Sel = arrCurrEduCls_Sel.sort(objPagerPara.sortFun);
        }
        arrCurrEduCls_Sel = arrCurrEduCls_Sel.slice(intStart, intEnd);
        return arrCurrEduCls_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, currEduClsEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsCurrEduClsENEx>();
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
export function CurrEduClsEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return CurrEduCls_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return CurrEduCls_SortFunByKey(strKey, AscOrDesc);
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
export function CurrEduClsEx_FuncMapByFldName(strFldName: string, objCurrEduClsEx: clsCurrEduClsENEx) {
    const strThisFuncName = CurrEduClsEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsCurrEduClsEN.AttributeName;
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
export async function CurrEduClsEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return CurrEduCls_FilterFunByKey(strKey, value);
    }
}


/// <summary>
/// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
/// </summary>
/// <returns>从本地缓存中获取的对象列表</returns>
export async function CurrEduClsEx_GetObjLst_localStorage() {

    //初始化列表缓存
    var strWhereCond: string = "1=1";

    var strKey: string = clsCurrEduClsEN._CurrTabName;
    if (strKey == "") {
        console.log("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (localStorage.hasOwnProperty(strKey)) {
        //缓存存在，直接返回
        var strTempObjLst: string = localStorage.getItem(strKey) as string;
        var arrCurrEduClsObjLst_Cache: Array<clsCurrEduClsEN> = JSON.parse(strTempObjLst);
        return arrCurrEduClsObjLst_Cache;
    }
    //try {
    //    const responseText = await CurrEduCls_GetObjLstAsync(strWhereCond);
    //    var arrCurrEduClsObjLst: Array<clsCurrEduClsEN> = <Array<clsCurrEduClsEN>>responseText;
    //    localStorage.setItem(strKey, JSON.stringify(arrCurrEduClsObjLst));
    //    var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrCurrEduClsObjLst.length}!`;
    //    console.log(strInfo);
    //    return arrCurrEduClsObjLst;
    //}
    //catch (e) {
    //    console.log("GetObjLst_Cache:e");
    //    console.error(e);
    //    var strMsg: string = `从缓存中获取所有对象列表出错,${e}.`;
    //    throw (strMsg);
    //}
}

/// <summary>
/// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
/// </summary>
/// <returns>从本地缓存中获取的对象列表</returns>
export async function CurrEduClsEx_SetObjLst_localStorage(strid_CurrEduCls: string) {
    //清空本类缓存
    const responseText0 = await CurrEduCls_ReFreshThisCache();
    //初始化列表缓存
    var strWhereCond: string = "1=1 and id_CurrEduCls='" + strid_CurrEduCls + "'";

    var strKey: string = clsCurrEduClsEN._CurrTabName;
    if (strKey == "") {
        console.log("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    //if (localStorage.hasOwnProperty(strKey)) {
    //    //缓存存在，直接返回
    //    var strTempObjLst: string = localStorage.getItem(strKey) as string;
    //    var arrCurrEduClsObjLst_Cache: Array<clsCurrEduClsEN> = JSON.parse(strTempObjLst);
    //    return arrCurrEduClsObjLst_Cache;
    //}
    try {
        //把当前教学班存入缓存内
        const responseText = await CurrEduCls_GetObjLstAsync(strWhereCond);
        var arrCurrEduClsObjLst: Array<clsCurrEduClsEN> = <Array<clsCurrEduClsEN>>responseText;
        localStorage.setItem(strKey, JSON.stringify(arrCurrEduClsObjLst));
        var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrCurrEduClsObjLst.length}!`;
        console.log(strInfo);
        return arrCurrEduClsObjLst;
    }
    catch (e) {
        console.log("GetObjLst_Cache:e");
        console.error(e);
        var strMsg: string = `从缓存中获取所有对象列表出错,${e}.`;
        throw (strMsg);
    }
}

/**
* 排序函数。根据关键字字段的值进行比较
* 作者:pyf
* 日期:20211017113202
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
* @param a:比较的第1个对象
* @param  b:比较的第1个对象
* @returns 返回两个对象比较的结果
*/
export function CurrEduClsEx_SortFun_IntTag(a: clsCurrEduClsEN, b: clsCurrEduClsEN): number {
    const strThisFuncName = CurrEduClsEx_SortFun_IntTag.name;
    console.log('strThisFuncName', strThisFuncName);
    if (a.intTag == null) return 1;
    if (b.intTag == null) return 1;
    const strA = a.intTag.toString();
    const strB = b.intTag.toString();
    const intA = Number(strA);
    const intB = Number(strB);

    let intResult: number = intA - intB;
    return intResult;
}
