
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
import * as $ from "jquery";
//import * as QQ from "q";
import { clsgs_PaperParagraphEN } from "../../L0_Entity/GraduateEduPaper/clsgs_PaperParagraphEN.js";
import { clsgs_PaperParagraphENEx } from "../../L0_Entity/GraduateEduPaper/clsgs_PaperParagraphENEx.js";
import { clsgs_PaperParagraphVEN } from "../../L0_Entity/GraduateEduPaper/clsgs_PaperParagraphVEN.js";
import { gs_PaperParagraph_FilterFunByKey, gs_PaperParagraph_GetObjLstAsync, gs_PaperParagraph_GetObjLst_Cache, gs_PaperParagraph_SortFunByKey } from "../../L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphWApi.js";
import { GetObjKeys, GetSortExpressInfo, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { Format, IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi } from "../../PubFun/clsSysPara4WebApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";
export const gs_PaperParagraphEx_Controller = "gs_PaperParagraphExApi";
export const gs_PaperParagraphEx_ConstructorName = "gs_PaperParagraphEx";

/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function gs_PaperParagraphEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objgs_PaperParagraphENS:源对象
* @returns 目标对象=>clsgs_PaperParagraphEN:objgs_PaperParagraphENT
**/
export function gs_PaperParagraphEx_CopyToEx(objgs_PaperParagraphENS: clsgs_PaperParagraphEN): clsgs_PaperParagraphENEx {
    const strThisFuncName = gs_PaperParagraphEx_CopyToEx.name;
    const objgs_PaperParagraphENT = new clsgs_PaperParagraphENEx();
    try {
        ObjectAssign(objgs_PaperParagraphENT, objgs_PaperParagraphENS);
        return objgs_PaperParagraphENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, gs_PaperParagraphEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objgs_PaperParagraphENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function gs_PaperParagraphEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara): Promise<Array<clsgs_PaperParagraphENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrgs_PaperParagraphObjLst = await gs_PaperParagraph_GetObjLst_Cache();
    const arrgs_PaperParagraphExObjLst = arrgs_PaperParagraphObjLst.map(gs_PaperParagraphEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrgs_PaperParagraphExObjLst) {
            const conFuncMap = await gs_PaperParagraphEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrgs_PaperParagraphExObjLst.length == 0) return arrgs_PaperParagraphExObjLst;
    let arrgs_PaperParagraph_Sel: Array<clsgs_PaperParagraphENEx> = arrgs_PaperParagraphExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objgs_PaperParagraph_Cond = new clsgs_PaperParagraphENEx();
    ObjectAssign(objgs_PaperParagraph_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsgs_PaperParagraphWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objgs_PaperParagraph_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrgs_PaperParagraph_Sel.length == 0) return arrgs_PaperParagraph_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.sort(gs_PaperParagraphEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.sort(objPagerPara.sortFun);
        }
        arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.slice(intStart, intEnd);
        return arrgs_PaperParagraph_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_PaperParagraphEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsgs_PaperParagraphENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function gs_PaperParagraphEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_PaperParagraphENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrgs_PaperParagraphExObjLst = await gs_PaperParagraph_GetObjLstAsync(objPagerPara.whereCond);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrgs_PaperParagraphExObjLst) {
            const conFuncMap = await gs_PaperParagraphEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrgs_PaperParagraphExObjLst.length == 0) return arrgs_PaperParagraphExObjLst;
    let arrgs_PaperParagraph_Sel: Array<clsgs_PaperParagraphENEx> = arrgs_PaperParagraphExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.sort(gs_PaperParagraphEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.sort(objPagerPara.sortFun);
        }
        arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.slice(intStart, intEnd);
        return arrgs_PaperParagraph_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_PaperParagraphEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsgs_PaperParagraphENEx>();
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
export function gs_PaperParagraphEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return gs_PaperParagraph_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return gs_PaperParagraph_SortFunByKey(strKey, AscOrDesc);
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
export function gs_PaperParagraphEx_FuncMapByFldName(strFldName: string, objgs_PaperParagraphEx: clsgs_PaperParagraphENEx) {
    const strThisFuncName = gs_PaperParagraphEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsgs_PaperParagraphEN.AttributeName;
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
export async function gs_PaperParagraphEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return gs_PaperParagraph_FilterFunByKey(strKey, value);
    }
}

/// <summary>
/// 根据条件获取相应的记录对象列表
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
/// </summary>
/// <param name = "strWhereCond">条件</param>
/// <returns>获取的相应对象列表</returns>
export async function gs_PaperParagraphEx_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_PaperParagraphVEN>> {
    var strAction = "GetObjLst";
    let strUrl = gs_PaperParagraphEx_GetWebApiUrl(gs_PaperParagraphEx_Controller, strAction);
    var mapParam: Dictionary = new Dictionary();
    mapParam.add("strWhereCond", strWhereCond);
    let strData = mapParam.getParamText();// "例如: strIdentityID =01";
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                if (data.ErrorId == 0) {
                    var returnObjLst = JSON.parse(data.ReturnObjLst);
                    //console.log(returnObjLst);
                    resolve(returnObjLst);
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
