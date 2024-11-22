
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvCurrEduClsTeacherExWApi
表名:vCurrEduClsTeacher(01120128)
生成代码版本:2021.06.06.1
生成日期:2021/06/11 17:38:10
生成者:pyf
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:日常运行
模块英文名:DailyRunning
框架-层名:WA_访问扩展层(WA_AccessEx)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
//import * as QQ from "q";
import { clsvCurrEduClsTeacherEN } from "../../L0_Entity/DailyRunning/clsvCurrEduClsTeacherEN.js";
import { clsvCurrEduClsTeacherENEx } from "../../L0_Entity/DailyRunning/clsvCurrEduClsTeacherENEx.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";

import { vCurrEduClsTeacher_FilterFunByKey, vCurrEduClsTeacher_GetObjLstAsync, vCurrEduClsTeacher_GetObjLst_Cache, vCurrEduClsTeacher_SortFunByKey } from "../../L3_ForWApi/DailyRunning/clsvCurrEduClsTeacherWApi.js";
import { GetObjKeys, GetSortExpressInfo, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { Format, IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi } from "../../PubFun/clsSysPara4WebApi.js";
export const vCurrEduClsTeacherEx_Controller = "vCurrEduClsTeacherExApi";
export const vCurrEduClsTeacherEx_ConstructorName = "vCurrEduClsTeacherEx";

/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function vCurrEduClsTeacherEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objvCurrEduClsTeacherENS:源对象
* @returns 目标对象=>clsvCurrEduClsTeacherEN:objvCurrEduClsTeacherENT
**/
export function vCurrEduClsTeacherEx_CopyToEx(objvCurrEduClsTeacherENS: clsvCurrEduClsTeacherEN): clsvCurrEduClsTeacherENEx {
    const strThisFuncName = vCurrEduClsTeacherEx_CopyToEx.name;
    const objvCurrEduClsTeacherENT = new clsvCurrEduClsTeacherENEx();
    try {
        ObjectAssign(objvCurrEduClsTeacherENT, objvCurrEduClsTeacherENS);
        return objvCurrEduClsTeacherENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, vCurrEduClsTeacherEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objvCurrEduClsTeacherENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function vCurrEduClsTeacherEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara, strid_CurrEduCls: string): Promise<Array<clsvCurrEduClsTeacherENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrvCurrEduClsTeacherObjLst = await vCurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
    const arrvCurrEduClsTeacherExObjLst = arrvCurrEduClsTeacherObjLst.map(vCurrEduClsTeacherEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrvCurrEduClsTeacherExObjLst) {
            const conFuncMap = await vCurrEduClsTeacherEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrvCurrEduClsTeacherExObjLst.length == 0) return arrvCurrEduClsTeacherExObjLst;
    let arrvCurrEduClsTeacher_Sel: Array<clsvCurrEduClsTeacherENEx> = arrvCurrEduClsTeacherExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objvCurrEduClsTeacher_Cond = new clsvCurrEduClsTeacherENEx();
    ObjectAssign(objvCurrEduClsTeacher_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsvCurrEduClsTeacherWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objvCurrEduClsTeacher_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrvCurrEduClsTeacher_Sel.length == 0) return arrvCurrEduClsTeacher_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.sort(vCurrEduClsTeacherEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.sort(objPagerPara.sortFun);
        }
        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.slice(intStart, intEnd);
        return arrvCurrEduClsTeacher_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vCurrEduClsTeacherEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsvCurrEduClsTeacherENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function vCurrEduClsTeacherEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvCurrEduClsTeacherENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrvCurrEduClsTeacherExObjLst = await vCurrEduClsTeacher_GetObjLstAsync(objPagerPara.whereCond);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrvCurrEduClsTeacherExObjLst) {
            const conFuncMap = await vCurrEduClsTeacherEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrvCurrEduClsTeacherExObjLst.length == 0) return arrvCurrEduClsTeacherExObjLst;
    let arrvCurrEduClsTeacher_Sel: Array<clsvCurrEduClsTeacherENEx> = arrvCurrEduClsTeacherExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.sort(vCurrEduClsTeacherEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.sort(objPagerPara.sortFun);
        }
        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.slice(intStart, intEnd);
        return arrvCurrEduClsTeacher_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vCurrEduClsTeacherEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsvCurrEduClsTeacherENEx>();
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
export function vCurrEduClsTeacherEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return vCurrEduClsTeacher_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return vCurrEduClsTeacher_SortFunByKey(strKey, AscOrDesc);
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
export function vCurrEduClsTeacherEx_FuncMapByFldName(strFldName: string, objvCurrEduClsTeacherEx: clsvCurrEduClsTeacherENEx) {
    const strThisFuncName = vCurrEduClsTeacherEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsvCurrEduClsTeacherEN.AttributeName;
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
export async function vCurrEduClsTeacherEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return vCurrEduClsTeacher_FilterFunByKey(strKey, value);
    }
}

/**
* 排序函数。根据orderNum字段的值进行比较
* 作者:pyf
* 日期:2021-10-20
* @param a:比较的第1个对象
* @param  b:比较的第1个对象
* @returns 返回两个对象比较的结果
*/
export function vCurrEduClsTeacherEx_SortFun_OrderNum(a: clsvCurrEduClsTeacherEN, b: clsvCurrEduClsTeacherEN): number {
    const strThisFuncName = vCurrEduClsTeacherEx_SortFun_OrderNum.name;
    console.log('strThisFuncName', strThisFuncName);
    if (a.orderNum == null) return 1;
    if (b.orderNum == null) return 1;
    const strA = a.orderNum.toString();
    const strB = b.orderNum.toString();
    const intA = Number(strA);
    const intB = Number(strB);

    let intResult: number = intA - intB;
    return intResult;
}
