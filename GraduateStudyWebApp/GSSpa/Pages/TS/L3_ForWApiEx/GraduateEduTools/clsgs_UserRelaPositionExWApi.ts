import * as $ from "jquery";
//import * as QQ from "q";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
import { clsSysPara4WebApi2 } from "../../PubFun/clsSysPara4WebApi2.js";
import { ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { gs_UserRelaPosition_FilterFunByKey, gs_UserRelaPosition_GetObjLst_Cache } from "../../L3_ForWApi/GraduateEduTools/clsgs_UserRelaPositionWApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { GetSortExpressInfo } from "../../PubFun/clsCommFunc4Web.js";
import { IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsgs_UserRelaPositionEN } from "../../L0_Entity/GraduateEduTools/clsgs_UserRelaPositionEN.js";
import { GetObjKeys } from "../../PubFun/clsCommFunc4Web.js";
import { clsgs_UserRelaPositionENEx } from "../../L0_Entity/GraduateEduTools/clsgs_UserRelaPositionENEx.js";
import { gs_UserRelaPosition_GetObjLstAsync } from "../../L3_ForWApi/GraduateEduTools/clsgs_UserRelaPositionWApi.js";
import { gs_UserRelaPosition_SortFunByKey } from "../../L3_ForWApi/GraduateEduTools/clsgs_UserRelaPositionWApi.js";
import { Format } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi } from "../../PubFun/clsSysPara4WebApi.js";
export const gs_UserRelaPositionEx_Controller = "gs_UserRelaPositionExApi";
export const gs_UserRelaPositionEx_ConstructorName = "gs_UserRelaPositionEx";


/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function gs_UserRelaPositionEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objgs_UserRelaPositionENS:源对象
* @returns 目标对象=>clsgs_UserRelaPositionEN:objgs_UserRelaPositionENT
**/
export function gs_UserRelaPositionEx_CopyToEx(objgs_UserRelaPositionENS: clsgs_UserRelaPositionEN): clsgs_UserRelaPositionENEx {
    const strThisFuncName = gs_UserRelaPositionEx_CopyToEx.name;
    const objgs_UserRelaPositionENT = new clsgs_UserRelaPositionENEx();
    try {
        ObjectAssign(objgs_UserRelaPositionENT, objgs_UserRelaPositionENS);
        return objgs_UserRelaPositionENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, gs_UserRelaPositionEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objgs_UserRelaPositionENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function gs_UserRelaPositionEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara, strid_CurrEduCls: string): Promise<Array<clsgs_UserRelaPositionENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrgs_UserRelaPositionObjLst = await gs_UserRelaPosition_GetObjLst_Cache(strid_CurrEduCls);
    const arrgs_UserRelaPositionExObjLst = arrgs_UserRelaPositionObjLst.map(gs_UserRelaPositionEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrgs_UserRelaPositionExObjLst) {
            const conFuncMap = await gs_UserRelaPositionEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrgs_UserRelaPositionExObjLst.length == 0) return arrgs_UserRelaPositionExObjLst;
    let arrgs_UserRelaPosition_Sel: Array<clsgs_UserRelaPositionENEx> = arrgs_UserRelaPositionExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objgs_UserRelaPosition_Cond = new clsgs_UserRelaPositionENEx();
    ObjectAssign(objgs_UserRelaPosition_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsgs_UserRelaPositionWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objgs_UserRelaPosition_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrgs_UserRelaPosition_Sel.length == 0) return arrgs_UserRelaPosition_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.sort(gs_UserRelaPositionEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.sort(objPagerPara.sortFun);
        }
        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.slice(intStart, intEnd);
        return arrgs_UserRelaPosition_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_UserRelaPositionEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsgs_UserRelaPositionENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function gs_UserRelaPositionEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_UserRelaPositionENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrgs_UserRelaPositionExObjLst = await gs_UserRelaPosition_GetObjLstAsync(objPagerPara.whereCond);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrgs_UserRelaPositionExObjLst) {
            const conFuncMap = await gs_UserRelaPositionEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrgs_UserRelaPositionExObjLst.length == 0) return arrgs_UserRelaPositionExObjLst;
    let arrgs_UserRelaPosition_Sel: Array<clsgs_UserRelaPositionENEx> = arrgs_UserRelaPositionExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.sort(gs_UserRelaPositionEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.sort(objPagerPara.sortFun);
        }
        arrgs_UserRelaPosition_Sel = arrgs_UserRelaPosition_Sel.slice(intStart, intEnd);
        return arrgs_UserRelaPosition_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_UserRelaPositionEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsgs_UserRelaPositionENEx>();
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
export function gs_UserRelaPositionEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return gs_UserRelaPosition_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return gs_UserRelaPosition_SortFunByKey(strKey, AscOrDesc);
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
export function gs_UserRelaPositionEx_FuncMapByFldName(strFldName: string, objgs_UserRelaPositionEx: clsgs_UserRelaPositionENEx) {
    const strThisFuncName = gs_UserRelaPositionEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsgs_UserRelaPositionEN.AttributeName;
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
export async function gs_UserRelaPositionEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return gs_UserRelaPosition_FilterFunByKey(strKey, value);
    }
}

/// <summary>
/// 调用WebApi来添加记录，数据传递使用JSON串
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
/// </summary>
/// <param name = "objgs_UserRelaEN">需要添加的对象</param>
/// <returns>获取相应的记录的对象</returns>
//public static AddNewRecordAsync(arrgs_UserRelaPosition :Array<clsgs_UserRelaPositionEN>): Promise<boolean> {
export async function gs_UserRelaPositionEx_AddNewRecordAsync(strJSON: string): Promise<boolean> {

    var strMsg = "";
    var strAction = "AddNewRecord";

    //var strJSON = JSON.stringify(arrgs_UserRelaPosition);
    //var strJson = eval(strJSON);

    //var strJson = JSON.parse(strJSON);
    //var varJSON = JSON.stringify(strJson);

    let strUrl = gs_UserRelaPositionEx_GetWebApiUrl(gs_UserRelaPositionEx_Controller, strAction);
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: strUrl,
            method: "POST",
            dataType: "json",
            data: strJSON,
            success: function (data) {
                if (data.ErrorId == 0) {
                    resolve(data.ReturnBool);
                }
                else {
                    console.log(data.ErrorMsg);
                    reject(data.ErrorMsg);
                }
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
};


