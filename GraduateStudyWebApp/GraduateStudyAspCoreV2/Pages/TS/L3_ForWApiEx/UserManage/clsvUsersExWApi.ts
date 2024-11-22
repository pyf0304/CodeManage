﻿
/**
* 类名:clsvUsersExWApi
* 表名:vUsers(01120027)
* 版本:2023.01.09.1(服务器:WIN-SRV103-116)
* 日期:2023/01/12 01:29:30
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:用户管理(UserManage)
* 框架-层名:WA_访问扩展层(TS)(WA_AccessEx)
* 编程语言:TypeScript
* 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
  *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
**/

/**
* v用户(vUsers)
* (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
* Created by pyf on 2023年01月12日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
**/
//import $ from "jquery";
import { ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { vUsers_GetObjLst_Cache } from "../../L3_ForWApi/UserManage_Share/clsvUsersWApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { GetSortExpressInfo } from "../../PubFun/clsCommFunc4Web.js";
import { IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsvUsersEN } from "../../L0_Entity/UserManage_Share/clsvUsersEN.js";
import { GetObjKeys } from "../../PubFun/clsCommFunc4Web.js";
import { clsvUsersENEx } from "../../L0_Entity/UserManage_Share/clsvUsersENEx.js";
import { vUsers_GetObjLstAsync } from "../../L3_ForWApi/UserManage_Share/clsvUsersWApi.js";
import { vUsers_SortFunByKey } from "../../L3_ForWApi/UserManage_Share/clsvUsersWApi.js";
import { Format } from "../../PubFun/clsString.js";
import { vUsers_FilterFunByKey } from "../../L3_ForWApi/UserManage_Share/clsvUsersWApi.js";
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
export const vUsersEx_Controller = "vUsersExApi";
export const vUsersEx_ConstructorName = "vUsersEx";

/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function vUsersEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objvUsersENS:源对象
* @returns 目标对象=>clsvUsersEN:objvUsersENT
**/
export function vUsersEx_CopyToEx(objvUsersENS: clsvUsersEN): clsvUsersENEx {
    const strThisFuncName = vUsersEx_CopyToEx.name;
    const objvUsersENT = new clsvUsersENEx();
    try {
        ObjectAssign(objvUsersENT, objvUsersENS);
        return objvUsersENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, vUsersEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objvUsersENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function vUsersEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara): Promise<Array<clsvUsersENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrvUsersObjLst = await vUsers_GetObjLst_Cache();
    const arrvUsersExObjLst = arrvUsersObjLst.map(vUsersEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrvUsersExObjLst) {
            const conFuncMap = await vUsersEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrvUsersExObjLst.length == 0) return arrvUsersExObjLst;
    let arrvUsers_Sel: Array<clsvUsersENEx> = arrvUsersExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objvUsers_Cond = new clsvUsersENEx();
    ObjectAssign(objvUsers_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsvUsersWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objvUsers_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "length greater") {
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                    }
                    else if (strComparisonOp == "length not greater") {
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                    }
                    else if (strComparisonOp == "length not less") {
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                    }
                    else if (strComparisonOp == "length less") {
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                    }
                    else if (strComparisonOp == "length equal") {
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length = Number(strValue.toString()));
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrvUsers_Sel.length == 0) return arrvUsers_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrvUsers_Sel = arrvUsers_Sel.sort(vUsersEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrvUsers_Sel = arrvUsers_Sel.sort(objPagerPara.sortFun);
        }
        arrvUsers_Sel = arrvUsers_Sel.slice(intStart, intEnd);
        return arrvUsers_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vUsersEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsvUsersENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function vUsersEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvUsersENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrvUsersObjLst = await vUsers_GetObjLstAsync(objPagerPara.whereCond);
    const arrvUsersExObjLst = arrvUsersObjLst.map(vUsersEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrvUsersExObjLst) {
            const conFuncMap = await vUsersEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrvUsersExObjLst.length == 0) return arrvUsersExObjLst;
    let arrvUsers_Sel: Array<clsvUsersENEx> = arrvUsersExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrvUsers_Sel = arrvUsers_Sel.sort(vUsersEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrvUsers_Sel = arrvUsers_Sel.sort(objPagerPara.sortFun);
        }
        arrvUsers_Sel = arrvUsers_Sel.slice(intStart, intEnd);
        return arrvUsers_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vUsersEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsvUsersENEx>();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-01-12
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vUsersEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return vUsers_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return vUsers_SortFunByKey(strKey, AscOrDesc);
        }
    }
}

/**
 * 根据扩展字段名去调用相应的映射函数
 * 作者:pyf
 * 日期:2023-01-12
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
 * @param strFldName:扩展字段名
 * @param  obj{0}Ex:需要转换的对象
 * @returns 针对扩展字段名对转换对象进行函数映射
*/
export function vUsersEx_FuncMapByFldName(strFldName: string, objvUsersEx: clsvUsersENEx) {
    const strThisFuncName = vUsersEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsvUsersEN.AttributeName;
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
 * 日期:2023-01-12
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function vUsersEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return vUsers_FilterFunByKey(strKey, value);
    }
}
