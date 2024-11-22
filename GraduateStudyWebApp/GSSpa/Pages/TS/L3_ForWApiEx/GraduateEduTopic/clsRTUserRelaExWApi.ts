
import * as $ from "jquery";
import { clsRTUserRelaEN } from "../../L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";

import { clsRTUserRelaENEx } from "../../L0_Entity/GraduateEduTopic/clsRTUserRelaENEx.js";
import { RTUserRela_FilterFunByKey, RTUserRela_GetObjLstAsync, RTUserRela_GetObjLst_Cache, RTUserRela_SortFunByKey } from "../../L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js";
import { GetObjKeys, GetSortExpressInfo, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { Format, IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi } from "../../PubFun/clsSysPara4WebApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
export const rTUserRelaEx_Controller = "RTUserRelaExApi";
export const rTUserRelaEx_ConstructorName = "rTUserRelaEx";
 //public static cacheModeId = "05"; //未知
/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function RTUserRelaEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objRTUserRelaENS:源对象
* @returns 目标对象=>clsRTUserRelaEN:objRTUserRelaENT
**/
export function RTUserRelaEx_CopyToEx(objRTUserRelaENS: clsRTUserRelaEN): clsRTUserRelaENEx {
    const strThisFuncName = RTUserRelaEx_CopyToEx.name;
    const objRTUserRelaENT = new clsRTUserRelaENEx();
    try {
        ObjectAssign(objRTUserRelaENT, objRTUserRelaENS);
        return objRTUserRelaENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, rTUserRelaEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objRTUserRelaENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function RTUserRelaEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara, strTopicId: string): Promise<Array<clsRTUserRelaENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrRTUserRelaObjLst = await RTUserRela_GetObjLst_Cache(strTopicId);
    const arrRTUserRelaExObjLst = arrRTUserRelaObjLst.map(RTUserRelaEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrRTUserRelaExObjLst) {
            const conFuncMap = await RTUserRelaEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrRTUserRelaExObjLst.length == 0) return arrRTUserRelaExObjLst;
    let arrRTUserRela_Sel: Array<clsRTUserRelaENEx> = arrRTUserRelaExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objRTUserRela_Cond = new clsRTUserRelaENEx();
    ObjectAssign(objRTUserRela_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsRTUserRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objRTUserRela_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrRTUserRela_Sel = arrRTUserRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrRTUserRela_Sel.length == 0) return arrRTUserRela_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrRTUserRela_Sel = arrRTUserRela_Sel.sort(RTUserRelaEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrRTUserRela_Sel = arrRTUserRela_Sel.sort(objPagerPara.sortFun);
        }
        arrRTUserRela_Sel = arrRTUserRela_Sel.slice(intStart, intEnd);
        return arrRTUserRela_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, rTUserRelaEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsRTUserRelaENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function RTUserRelaEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsRTUserRelaENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrRTUserRelaExObjLst = await RTUserRela_GetObjLstAsync(objPagerPara.whereCond);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrRTUserRelaExObjLst) {
            const conFuncMap = await RTUserRelaEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrRTUserRelaExObjLst.length == 0) return arrRTUserRelaExObjLst;
    let arrRTUserRela_Sel: Array<clsRTUserRelaENEx> = arrRTUserRelaExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrRTUserRela_Sel = arrRTUserRela_Sel.sort(RTUserRelaEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrRTUserRela_Sel = arrRTUserRela_Sel.sort(objPagerPara.sortFun);
        }
        arrRTUserRela_Sel = arrRTUserRela_Sel.slice(intStart, intEnd);
        return arrRTUserRela_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, rTUserRelaEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsRTUserRelaENEx>();
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
export function RTUserRelaEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return RTUserRela_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return RTUserRela_SortFunByKey(strKey, AscOrDesc);
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
export function RTUserRelaEx_FuncMapByFldName(strFldName: string, objRTUserRelaEx: clsRTUserRelaENEx) {
    const strThisFuncName = RTUserRelaEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsRTUserRelaEN.AttributeName;
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
export async function RTUserRelaEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return RTUserRela_FilterFunByKey(strKey, value);
    }
}

   

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>返回的第一条记录的关键字值</returns>
export async function RTUserRelaEx_UpdateTypeTableHtmlAsync(OldCodeColor: string, NewCodeColor: string,userId: string): Promise<boolean> {
        var strAction = "UpdateTypeTableHtml";
    let strUrl = RTUserRelaEx_GetWebApiUrl(rTUserRelaEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("OldCodeColor", OldCodeColor);
        mapParam.add("NewCodeColor", NewCodeColor);
        mapParam.add("userId", userId);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                    //if (data.ErrorId == 0) {
                    //    resolve(data.ReturnStr);
                    //}
                    //else {
                    //    console.log(data.ErrorMsg);
                    //    reject(data.ErrorMsg);
                    //}
                },
                error: function (result) {
                    console.log(result);
                    console.log(JSON.stringify(result));
                    if (result.statusText == "error") {
                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
                        reject(strInfo);
                    }
                    else {
                        reject(result.statusText);
                    }
                }
            });
        });
    }
