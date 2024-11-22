﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_KnowledgesLogicExWApi
表名:gs_KnowledgesLogic(01120872)
生成代码版本:2021.01.26.1
生成日期:2021/01/26 23:47:45
生成者:lyl
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:知识点相关
模块英文名:Knowledges
框架-层名:WA_访问扩展层(WA_AccessEx)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

/// <summary>
/// 知识点逻辑(gs_KnowledgesLogic)
/// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
/// </summary>
/**
* Created by lyl on 2021年01月26日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
import * as $ from "jquery";
//import * as QQ from "q";
import { clsgs_KnowledgesLogicEN } from "../../L0_Entity/Knowledges/clsgs_KnowledgesLogicEN.js";

import { clsgs_KnowledgesLogicENEx } from "../../L0_Entity/Knowledges/clsgs_KnowledgesLogicENEx.js";
import { gs_KnowledgesLogic_FilterFunByKey, gs_KnowledgesLogic_GetObjLstAsync, gs_KnowledgesLogic_GetObjLst_Cache, gs_KnowledgesLogic_SortFunByKey } from "../../L3_ForWApi/Knowledges/clsgs_KnowledgesLogicWApi.js";
import { GetObjKeys, GetSortExpressInfo, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { Format, IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi } from "../../PubFun/clsSysPara4WebApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
export const gs_KnowledgesLogicEx_Controller = "gs_KnowledgesLogicExApi";
export const gs_KnowledgesLogicEx_ConstructorName = "gs_KnowledgesLogicEx";

/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function gs_KnowledgesLogicEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objgs_KnowledgesLogicENS:源对象
* @returns 目标对象=>clsgs_KnowledgesLogicEN:objgs_KnowledgesLogicENT
**/
export function gs_KnowledgesLogicEx_CopyToEx(objgs_KnowledgesLogicENS: clsgs_KnowledgesLogicEN): clsgs_KnowledgesLogicENEx {
    const strThisFuncName = gs_KnowledgesLogicEx_CopyToEx.name;
    const objgs_KnowledgesLogicENT = new clsgs_KnowledgesLogicENEx();
    try {
        ObjectAssign(objgs_KnowledgesLogicENT, objgs_KnowledgesLogicENS);
        return objgs_KnowledgesLogicENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, gs_KnowledgesLogicEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objgs_KnowledgesLogicENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function gs_KnowledgesLogicEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara, strKnowledgeGraphId: string): Promise<Array<clsgs_KnowledgesLogicENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrgs_KnowledgesLogicObjLst = await gs_KnowledgesLogic_GetObjLst_Cache(strKnowledgeGraphId);
    const arrgs_KnowledgesLogicExObjLst = arrgs_KnowledgesLogicObjLst.map(gs_KnowledgesLogicEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrgs_KnowledgesLogicExObjLst) {
            const conFuncMap = await gs_KnowledgesLogicEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrgs_KnowledgesLogicExObjLst.length == 0) return arrgs_KnowledgesLogicExObjLst;
    let arrgs_KnowledgesLogic_Sel: Array<clsgs_KnowledgesLogicENEx> = arrgs_KnowledgesLogicExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objgs_KnowledgesLogic_Cond = new clsgs_KnowledgesLogicENEx();
    ObjectAssign(objgs_KnowledgesLogic_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsgs_KnowledgesLogicWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrgs_KnowledgesLogic_Sel = arrgs_KnowledgesLogic_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objgs_KnowledgesLogic_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrgs_KnowledgesLogic_Sel = arrgs_KnowledgesLogic_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrgs_KnowledgesLogic_Sel = arrgs_KnowledgesLogic_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrgs_KnowledgesLogic_Sel = arrgs_KnowledgesLogic_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrgs_KnowledgesLogic_Sel = arrgs_KnowledgesLogic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrgs_KnowledgesLogic_Sel = arrgs_KnowledgesLogic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrgs_KnowledgesLogic_Sel = arrgs_KnowledgesLogic_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrgs_KnowledgesLogic_Sel = arrgs_KnowledgesLogic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrgs_KnowledgesLogic_Sel = arrgs_KnowledgesLogic_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrgs_KnowledgesLogic_Sel = arrgs_KnowledgesLogic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrgs_KnowledgesLogic_Sel.length == 0) return arrgs_KnowledgesLogic_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrgs_KnowledgesLogic_Sel = arrgs_KnowledgesLogic_Sel.sort(gs_KnowledgesLogicEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrgs_KnowledgesLogic_Sel = arrgs_KnowledgesLogic_Sel.sort(objPagerPara.sortFun);
        }
        arrgs_KnowledgesLogic_Sel = arrgs_KnowledgesLogic_Sel.slice(intStart, intEnd);
        return arrgs_KnowledgesLogic_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_KnowledgesLogicEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsgs_KnowledgesLogicENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function gs_KnowledgesLogicEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_KnowledgesLogicENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrgs_KnowledgesLogicExObjLst = await gs_KnowledgesLogic_GetObjLstAsync(objPagerPara.whereCond);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrgs_KnowledgesLogicExObjLst) {
            const conFuncMap = await gs_KnowledgesLogicEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrgs_KnowledgesLogicExObjLst.length == 0) return arrgs_KnowledgesLogicExObjLst;
    let arrgs_KnowledgesLogic_Sel: Array<clsgs_KnowledgesLogicENEx> = arrgs_KnowledgesLogicExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrgs_KnowledgesLogic_Sel = arrgs_KnowledgesLogic_Sel.sort(gs_KnowledgesLogicEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrgs_KnowledgesLogic_Sel = arrgs_KnowledgesLogic_Sel.sort(objPagerPara.sortFun);
        }
        arrgs_KnowledgesLogic_Sel = arrgs_KnowledgesLogic_Sel.slice(intStart, intEnd);
        return arrgs_KnowledgesLogic_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_KnowledgesLogicEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsgs_KnowledgesLogicENEx>();
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
export function gs_KnowledgesLogicEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return gs_KnowledgesLogic_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return gs_KnowledgesLogic_SortFunByKey(strKey, AscOrDesc);
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
export function gs_KnowledgesLogicEx_FuncMapByFldName(strFldName: string, objgs_KnowledgesLogicEx: clsgs_KnowledgesLogicENEx) {
    const strThisFuncName = gs_KnowledgesLogicEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsgs_KnowledgesLogicEN.AttributeName;
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
export async function gs_KnowledgesLogicEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return gs_KnowledgesLogic_FilterFunByKey(strKey, value);
    }
}

/// <summary>
/// 调用WebApi来添加记录，数据传递使用JSON串
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
/// </summary>
/// <param name = "objgs_UserRelaEN">需要添加的对象</param>
/// <returns>获取相应的记录的对象</returns>
//public static AddNewRecordAsync(arrgs_UserRelaPosition :Array<clsgs_UserRelaPositionEN>): Promise<boolean> {
export async function gs_KnowledgesLogicEx_AddNewRecordAsync(strJSON: string): Promise<boolean> {

    var strMsg = "";
    var strAction = "AddNewRecord";
    let strUrl = gs_KnowledgesLogicEx_GetWebApiUrl(gs_KnowledgesLogicEx_Controller, strAction);
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