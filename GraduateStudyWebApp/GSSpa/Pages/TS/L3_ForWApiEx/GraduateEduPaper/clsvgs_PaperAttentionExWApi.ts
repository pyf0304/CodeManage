
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvgs_PaperAttentionExWApi
表名:vgs_PaperAttention(01120750)
生成代码版本:2020.09.24.1
生成日期:2020/09/28 12:21:56
生成者:pyf2
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培论文
模块英文名:GraduateEduPaper
框架-层名:WA_访问扩展层(WA_AccessEx)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

/// <summary>
/// vgs_PaperAttention(vgs_PaperAttention)
/// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
/// </summary>
/**
* Created by pyf2 on 2020年09月28日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
import * as $ from "jquery";
//import * as QQ from "q";
import { clsvgs_PaperAttentionEN } from "../../L0_Entity/GraduateEduPaper/clsvgs_PaperAttentionEN.js";
import { clsvgs_PaperAttentionENEx } from "../../L0_Entity/GraduateEduPaper/clsvgs_PaperAttentionENEx.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";

var ResponseData: tzResponseData;
//export class clsvgs_PaperAttentionExWApi {
//    public static mstrController: string = "vgs_PaperAttentionExApi";


import { vgs_PaperAttention_FilterFunByKey, vgs_PaperAttention_GetObjLstAsync, vgs_PaperAttention_GetObjLst_Cache, vgs_PaperAttention_SortFunByKey } from "../../L3_ForWApi/GraduateEduPaper/clsvgs_PaperAttentionWApi.js";
import { GetObjKeys, GetSortExpressInfo, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { Format, IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi } from "../../PubFun/clsSysPara4WebApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
export const vgs_PaperAttentionEx_Controller = "vgs_PaperAttentionExApi";
export const vgs_PaperAttentionEx_ConstructorName = "vgs_PaperAttentionEx";

/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function vgs_PaperAttentionEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objvgs_PaperAttentionENS:源对象
* @returns 目标对象=>clsvgs_PaperAttentionEN:objvgs_PaperAttentionENT
**/
export function vgs_PaperAttentionEx_CopyToEx(objvgs_PaperAttentionENS: clsvgs_PaperAttentionEN): clsvgs_PaperAttentionENEx {
    const strThisFuncName = vgs_PaperAttentionEx_CopyToEx.name;
    const objvgs_PaperAttentionENT = new clsvgs_PaperAttentionENEx();
    try {
        ObjectAssign(objvgs_PaperAttentionENT, objvgs_PaperAttentionENS);
        return objvgs_PaperAttentionENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, vgs_PaperAttentionEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objvgs_PaperAttentionENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function vgs_PaperAttentionEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara, strUserId: string): Promise<Array<clsvgs_PaperAttentionENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrvgs_PaperAttentionObjLst = await vgs_PaperAttention_GetObjLst_Cache(strUserId);
    const arrvgs_PaperAttentionExObjLst = arrvgs_PaperAttentionObjLst.map(vgs_PaperAttentionEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrvgs_PaperAttentionExObjLst) {
            const conFuncMap = await vgs_PaperAttentionEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrvgs_PaperAttentionExObjLst.length == 0) return arrvgs_PaperAttentionExObjLst;
    let arrvgs_PaperAttention_Sel: Array<clsvgs_PaperAttentionENEx> = arrvgs_PaperAttentionExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objvgs_PaperAttention_Cond = new clsvgs_PaperAttentionENEx();
    ObjectAssign(objvgs_PaperAttention_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsvgs_PaperAttentionWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objvgs_PaperAttention_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrvgs_PaperAttention_Sel.length == 0) return arrvgs_PaperAttention_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.sort(vgs_PaperAttentionEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.sort(objPagerPara.sortFun);
        }
        arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.slice(intStart, intEnd);
        return arrvgs_PaperAttention_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vgs_PaperAttentionEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsvgs_PaperAttentionENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function vgs_PaperAttentionEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvgs_PaperAttentionENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrvgs_PaperAttentionExObjLst = await vgs_PaperAttention_GetObjLstAsync(objPagerPara.whereCond);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrvgs_PaperAttentionExObjLst) {
            const conFuncMap = await vgs_PaperAttentionEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrvgs_PaperAttentionExObjLst.length == 0) return arrvgs_PaperAttentionExObjLst;
    let arrvgs_PaperAttention_Sel: Array<clsvgs_PaperAttentionENEx> = arrvgs_PaperAttentionExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.sort(vgs_PaperAttentionEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.sort(objPagerPara.sortFun);
        }
        arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.slice(intStart, intEnd);
        return arrvgs_PaperAttention_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vgs_PaperAttentionEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsvgs_PaperAttentionENEx>();
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
export function vgs_PaperAttentionEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return vgs_PaperAttention_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return vgs_PaperAttention_SortFunByKey(strKey, AscOrDesc);
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
export function vgs_PaperAttentionEx_FuncMapByFldName(strFldName: string, objvgs_PaperAttentionEx: clsvgs_PaperAttentionENEx) {
    const strThisFuncName = vgs_PaperAttentionEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsvgs_PaperAttentionEN.AttributeName;
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
export async function vgs_PaperAttentionEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return vgs_PaperAttention_FilterFunByKey(strKey, value);
    }
}

    /// <summary>
    /// 获取论文中的用户数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
export async function vgs_PaperAttentionEx_GetPaperIdNumObjLstAsync(strWhereCond: string): Promise<Array<clsvgs_PaperAttentionEN>> {
        var strAction = "GetPaperIdNumObjLst";
    let strUrl = vgs_PaperAttentionEx_GetWebApiUrl(vgs_PaperAttentionEx_Controller, strAction);
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
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    };

