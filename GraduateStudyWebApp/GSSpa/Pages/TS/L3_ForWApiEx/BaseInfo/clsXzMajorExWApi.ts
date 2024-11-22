
//import * as QQ from "q";
import { clsXzMajorEN } from "../../L0_Entity/BaseInfo/clsXzMajorEN.js";
import { clsXzMajorENEx } from "../../L0_Entity/BaseInfo/clsXzMajorENEx.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";

import { XzMajor_FilterFunByKey, XzMajor_GetObjLstAsync, XzMajor_GetObjLst_Cache, XzMajor_SortFunByKey } from "../../L3_ForWApi/BaseInfo/clsXzMajorWApi.js";
import { GetObjKeys, GetSortExpressInfo, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { Format, IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi } from "../../PubFun/clsSysPara4WebApi.js";
export const xzMajorEx_Controller = "XzMajorExApi";
export const xzMajorEx_ConstructorName = "xzMajorEx";

/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function XzMajorEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objXzMajorENS:源对象
* @returns 目标对象=>clsXzMajorEN:objXzMajorENT
**/
export function XzMajorEx_CopyToEx(objXzMajorENS: clsXzMajorEN): clsXzMajorENEx {
    const strThisFuncName = XzMajorEx_CopyToEx.name;
    const objXzMajorENT = new clsXzMajorENEx();
    try {
        ObjectAssign(objXzMajorENT, objXzMajorENS);
        return objXzMajorENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, xzMajorEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objXzMajorENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function XzMajorEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara): Promise<Array<clsXzMajorENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrXzMajorObjLst = await XzMajor_GetObjLst_Cache();
    const arrXzMajorExObjLst = arrXzMajorObjLst.map(XzMajorEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrXzMajorExObjLst) {
            const conFuncMap = await XzMajorEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrXzMajorExObjLst.length == 0) return arrXzMajorExObjLst;
    let arrXzMajor_Sel: Array<clsXzMajorENEx> = arrXzMajorExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objXzMajor_Cond = new clsXzMajorENEx();
    ObjectAssign(objXzMajor_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsXzMajorWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objXzMajor_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrXzMajor_Sel = arrXzMajor_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrXzMajor_Sel = arrXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrXzMajor_Sel.length == 0) return arrXzMajor_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrXzMajor_Sel = arrXzMajor_Sel.sort(XzMajorEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrXzMajor_Sel = arrXzMajor_Sel.sort(objPagerPara.sortFun);
        }
        arrXzMajor_Sel = arrXzMajor_Sel.slice(intStart, intEnd);
        return arrXzMajor_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, xzMajorEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsXzMajorENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function XzMajorEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsXzMajorENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrXzMajorExObjLst = await XzMajor_GetObjLstAsync(objPagerPara.whereCond);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrXzMajorExObjLst) {
            const conFuncMap = await XzMajorEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrXzMajorExObjLst.length == 0) return arrXzMajorExObjLst;
    let arrXzMajor_Sel: Array<clsXzMajorENEx> = arrXzMajorExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrXzMajor_Sel = arrXzMajor_Sel.sort(XzMajorEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrXzMajor_Sel = arrXzMajor_Sel.sort(objPagerPara.sortFun);
        }
        arrXzMajor_Sel = arrXzMajor_Sel.slice(intStart, intEnd);
        return arrXzMajor_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, xzMajorEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsXzMajorENEx>();
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
export function XzMajorEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return XzMajor_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return XzMajor_SortFunByKey(strKey, AscOrDesc);
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
export function XzMajorEx_FuncMapByFldName(strFldName: string, objXzMajorEx: clsXzMajorENEx) {
    const strThisFuncName = XzMajorEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsXzMajorEN.AttributeName;
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
export async function XzMajorEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return XzMajor_FilterFunByKey(strKey, value);
    }
}

export function XzMajorEx_SortFun_majorName(a: clsXzMajorEN, b: clsXzMajorEN): number {
    return a.majorName.localeCompare(b.majorName);
}
