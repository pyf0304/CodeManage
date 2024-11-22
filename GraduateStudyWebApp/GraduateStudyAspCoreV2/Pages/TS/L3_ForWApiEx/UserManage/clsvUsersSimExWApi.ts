
/**
* 类名:clsvUsersSimExWApi
* 表名:vUsersSim(01120699)
* 版本:2023.02.24.1(服务器:WIN-SRV103-116)
* 日期:2023/02/25 20:53:33
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
* vUsersSim(vUsersSim)
* (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
* Created by pyf on 2023年02月25日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
**/
//import $ from "jquery";
import { ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { vUsersSim_GetObjByUserIdAsync, vUsersSim_GetObjLst_Cache, vUsersSim_ReFreshThisCache } from "../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { GetSortExpressInfo } from "../../PubFun/clsCommFunc4Web.js";
import { IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsvUsersSimEN } from "../../L0_Entity/UserManage_Share/clsvUsersSimEN.js";
import { GetObjKeys } from "../../PubFun/clsCommFunc4Web.js";
import { clsvUsersSimENEx } from "../../L0_Entity/UserManage_Share/clsvUsersSimENEx.js";
import { vUsersSim_GetObjLstAsync } from "../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { vUsersSim_SortFunByKey } from "../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { Format } from "../../PubFun/clsString.js";
import { vUsersSim_FilterFunByKey } from "../../L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js";
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { CmPrjIdUserIdRelaEx_AddUserId } from "./clsCmPrjIdUserIdRelaExWApi.js";
export const vUsersSimEx_Controller = "vUsersSimExApi";
export const vUsersSimEx_ConstructorName = "vUsersSimEx";

/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function vUsersSimEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objvUsersSimENS:源对象
* @returns 目标对象=>clsvUsersSimEN:objvUsersSimENT
**/
export function vUsersSimEx_CopyToEx(objvUsersSimENS: clsvUsersSimEN): clsvUsersSimENEx {
    const strThisFuncName = vUsersSimEx_CopyToEx.name;
    const objvUsersSimENT = new clsvUsersSimENEx();
    try {
        ObjectAssign(objvUsersSimENT, objvUsersSimENS);
        return objvUsersSimENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, vUsersSimEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objvUsersSimENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function vUsersSimEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara, strCmPrjId: string): Promise<Array<clsvUsersSimENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrvUsersSimObjLst = await vUsersSim_GetObjLst_Cache(strCmPrjId);
    const arrvUsersSimExObjLst = arrvUsersSimObjLst.map(vUsersSimEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrvUsersSimExObjLst) {
            const conFuncMap = await vUsersSimEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrvUsersSimExObjLst.length == 0) return arrvUsersSimExObjLst;
    let arrvUsersSim_Sel: Array<clsvUsersSimENEx> = arrvUsersSimExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objvUsersSim_Cond = new clsvUsersSimENEx();
    ObjectAssign(objvUsersSim_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsvUsersSimWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objvUsersSim_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "length greater") {
                        arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                    }
                    else if (strComparisonOp == "length not greater") {
                        arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                    }
                    else if (strComparisonOp == "length not less") {
                        arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                    }
                    else if (strComparisonOp == "length less") {
                        arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                    }
                    else if (strComparisonOp == "length equal") {
                        arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrvUsersSim_Sel.length == 0) return arrvUsersSim_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrvUsersSim_Sel = arrvUsersSim_Sel.sort(vUsersSimEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrvUsersSim_Sel = arrvUsersSim_Sel.sort(objPagerPara.sortFun);
        }
        arrvUsersSim_Sel = arrvUsersSim_Sel.slice(intStart, intEnd);
        return arrvUsersSim_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vUsersSimEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsvUsersSimENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function vUsersSimEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvUsersSimENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrvUsersSimObjLst = await vUsersSim_GetObjLstAsync(objPagerPara.whereCond);
    const arrvUsersSimExObjLst = arrvUsersSimObjLst.map(vUsersSimEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrvUsersSimExObjLst) {
            const conFuncMap = await vUsersSimEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrvUsersSimExObjLst.length == 0) return arrvUsersSimExObjLst;
    let arrvUsersSim_Sel: Array<clsvUsersSimENEx> = arrvUsersSimExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrvUsersSim_Sel = arrvUsersSim_Sel.sort(vUsersSimEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrvUsersSim_Sel = arrvUsersSim_Sel.sort(objPagerPara.sortFun);
        }
        arrvUsersSim_Sel = arrvUsersSim_Sel.slice(intStart, intEnd);
        return arrvUsersSim_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vUsersSimEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsvUsersSimENEx>();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-02-25
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vUsersSimEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            case clsvUsersSimENEx.con_CmPrjId:
                return (a: clsvUsersSimENEx, b: clsvUsersSimENEx) => {
                    return a.cmPrjId.localeCompare(b.cmPrjId);
                }
            default:
                return vUsersSim_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            case clsvUsersSimENEx.con_CmPrjId:
                return (a: clsvUsersSimENEx, b: clsvUsersSimENEx) => {
                    return b.cmPrjId.localeCompare(a.cmPrjId);
                }
            default:
                return vUsersSim_SortFunByKey(strKey, AscOrDesc);
        }
    }
}

/**
 * 根据扩展字段名去调用相应的映射函数
 * 作者:pyf
 * 日期:2023-02-25
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
 * @param strFldName:扩展字段名
 * @param  obj{0}Ex:需要转换的对象
 * @returns 针对扩展字段名对转换对象进行函数映射
*/
export function vUsersSimEx_FuncMapByFldName(strFldName: string, objvUsersSimEx: clsvUsersSimENEx) {
    const strThisFuncName = vUsersSimEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsvUsersSimEN.AttributeName;
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
 * 日期:2023-02-25
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function vUsersSimEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        case clsvUsersSimENEx.con_CmPrjId:
            return (obj: clsvUsersSimENEx) => {
                return obj.cmPrjId === value;
            }
        default:
            return vUsersSim_FilterFunByKey(strKey, value);
    }
}

/**
* 映射函数。根据表映射把输入字段值，映射成输出字段值
* 作者:pyf
* 日期:2023-02-25
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
* @param strInFldName:输入字段名
* @param strOutFldName:输出字段名
* @param strInValue:输入字段值
@param strCmPrjId:缓存的分类字段
* @returns 返回一个输出字段值
*/
export async function vUsersSimEx_func(strInFldName: string, strOutFldName: string, strInValue: string) {
    //const strThisFuncName = "func";

    //if (IsNullOrEmpty(strCmPrjId_C) == true) {
    //    const strMsg = Format("参数:[strCmPrjId_C]不能为空！(In func)");
    //    console.error(strMsg);
    //    throw (strMsg);
    //}
    //if (strCmPrjId_C.length != 6) {
    //    const strMsg = Format("缓存分类变量:[strCmPrjId_C]的长度:[{0}]不正确！", strCmPrjId_C.length);
    //    console.error(strMsg);
    //    throw (strMsg);
    //}

    if (strInFldName != clsvUsersSimEN.con_UserId) {
        const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    if (clsvUsersSimEN.AttributeName.indexOf(strOutFldName) == -1) {
        const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
            strOutFldName, clsvUsersSimEN.AttributeName.join(','));
        console.error(strMsg);
        throw new Error(strMsg);
    }
    const strUserId = strInValue;
    if (IsNullOrEmpty(strInValue) == true) {

        return "";
    }
    const objvUsersSim = await vUsersSimEx_GetObjByUserId_Cache(strUserId);
    if (objvUsersSim == null) {
        await CmPrjIdUserIdRelaEx_AddUserId(strUserId);
        return "";
    }
    if (objvUsersSim.GetFldValue(strOutFldName) == null) return "";
    return objvUsersSim.GetFldValue(strOutFldName).toString();
}

/**
 * 根据关键字获取相关对象, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
 * @param strUserId:所给的关键字
 * @returns 对象
*/
export async function vUsersSimEx_GetObjByUserId_Cache(strUserId: string,  bolTryAsyncOnce: boolean = true) {
    const strThisFuncName = "GetObjByUserId_Cache";

    if (IsNullOrEmpty(strUserId) == true) {
        const strMsg = Format("参数:[strUserId]不能为空！(In GetObjByUserId_Cache)");
        console.error(strMsg);
        throw (strMsg);
    }
    const arrvUsersSimObjLst_Cache = await vUsersSim_GetObjLst_Cache(clsSysPara4WebApi. cmPrjId);
    try {
        const arrvUsersSim_Sel: Array<clsvUsersSimEN> = arrvUsersSimObjLst_Cache.filter(x =>
            x.userId == strUserId);
        let objvUsersSim: clsvUsersSimEN;
        if (arrvUsersSim_Sel.length > 0) {
            objvUsersSim = arrvUsersSim_Sel[0];
            return objvUsersSim;
        }
        else {
            if (bolTryAsyncOnce == true) {
                const objvUsersSim_Const = await vUsersSim_GetObjByUserIdAsync(strUserId);
                if (objvUsersSim_Const != null) {
                    await   CmPrjIdUserIdRelaEx_AddUserId(strUserId);
                    vUsersSim_ReFreshThisCache(clsSysPara4WebApi.cmPrjId);
                    return objvUsersSim_Const;
                }
            }
            return null;
        }
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, vUsersSimEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
    }
    return null;
}
