
/// <summary>
/// 论文表(Paper)
/// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
/// </summary>
/**
* Created by pyf on 2021年06月11日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
import * as $ from "jquery";
//import * as QQ from "q";
import { clsPaperEN } from "../../L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { clsPaperENEx } from "../../L0_Entity/GraduateEduPaper/clsPaperENEx.js";
import { Paper_CopyObjTo, Paper_FilterFunByKey, Paper_GetObjLstAsync, Paper_GetObjLst_Cache, Paper_SortFunByKey } from "../../L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { GetObjKeys, GetSortExpressInfo, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsCommonFunc4Web } from "../../PubFun/clsCommonFunc4Web2.js";
import { Format, IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsString } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi } from "../../PubFun/clsSysPara4WebApi.js";
import { clsSysPara4WebApi2 } from "../../PubFun/clsSysPara4WebApi2.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";
export const paperEx_Controller = "PaperExApi";
export const paperEx_ConstructorName = "paperEx";

/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function PaperEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objPaperENS:源对象
* @returns 目标对象=>clsPaperEN:objPaperENT
**/
export function PaperEx_CopyToEx(objPaperENS: clsPaperEN): clsPaperENEx {
    const strThisFuncName = PaperEx_CopyToEx.name;
    const objPaperENT = new clsPaperENEx();
    try {
        ObjectAssign(objPaperENT, objPaperENS);
        return objPaperENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, paperEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objPaperENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function PaperEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara): Promise<Array<clsPaperENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrPaperObjLst = await Paper_GetObjLst_Cache();
    const arrPaperExObjLst = arrPaperObjLst.map(PaperEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrPaperExObjLst) {
            const conFuncMap = await PaperEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrPaperExObjLst.length == 0) return arrPaperExObjLst;
    let arrPaper_Sel: Array<clsPaperENEx> = arrPaperExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objPaper_Cond = new clsPaperENEx();
    ObjectAssign(objPaper_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsPaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objPaper_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrPaper_Sel = arrPaper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrPaper_Sel.length == 0) return arrPaper_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrPaper_Sel = arrPaper_Sel.sort(PaperEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrPaper_Sel = arrPaper_Sel.sort(objPagerPara.sortFun);
        }
        arrPaper_Sel = arrPaper_Sel.slice(intStart, intEnd);
        return arrPaper_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, paperEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsPaperENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function PaperEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsPaperENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrPaperExObjLst = await Paper_GetObjLstAsync(objPagerPara.whereCond);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrPaperExObjLst) {
            const conFuncMap = await PaperEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrPaperExObjLst.length == 0) return arrPaperExObjLst;
    let arrPaper_Sel: Array<clsPaperENEx> = arrPaperExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrPaper_Sel = arrPaper_Sel.sort(PaperEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrPaper_Sel = arrPaper_Sel.sort(objPagerPara.sortFun);
        }
        arrPaper_Sel = arrPaper_Sel.slice(intStart, intEnd);
        return arrPaper_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, paperEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsPaperENEx>();
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
export function PaperEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return Paper_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return Paper_SortFunByKey(strKey, AscOrDesc);
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
export function PaperEx_FuncMapByFldName(strFldName: string, objPaperEx: clsPaperENEx) {
    const strThisFuncName = PaperEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsPaperEN.AttributeName;
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
export async function PaperEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return Paper_FilterFunByKey(strKey, value);
    }
}



/// <summary>
/// 绑定基于Web的下拉框
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
/// </summary>
/// <param name = "objDDL">需要绑定当前表的下拉框</param>
export async function PaperEx_BindDdl_PaperIdInDivById_CurrEduCls_Cache(strDivName: string, strDdlName: string, strid_CurrEduCls: string) {

    var objDdl = document.getElementById(strDdlName);
    if (objDdl == null) {
        var strMsg = `下拉框：${strDdlName} 不存在！(In BindDdl_PaperIdInDiv_Cache)`;
        alert(strMsg);
        console.error(strMsg);
        throw (strMsg);
    }
    //为数据源于表的下拉框设置内容
    console.log("开始：BindDdl_PaperIdInDiv_Cache");
    var arrObjLst_Sel: Array<clsPaperEN> = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
    clsCommonFunc4Web.BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsPaperEN.con_PaperId, clsPaperEN.con_PaperTitle, "论文表");
}

/// <summary>
/// 根据教学班获取对象列表，用对象列表表示
/// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
/// </summary>
/// <param name = "strId_CurrEduCls">教学班流水号</param>
/// <returns>获取的相应对象列表</returns>
export async function PaperEx_GetObjLstById_CurrEduCls(strId_CurrEduCls: string): Promise<Array<clsPaperEN>> {
    var strAction = "GetObjLstById_CurrEduCls";
    let strUrl = PaperEx_GetWebApiUrl(paperEx_Controller, strAction);
    var mapParam: Dictionary = new Dictionary();
    mapParam.add("strId_CurrEduCls", strId_CurrEduCls);
    let strData = mapParam.getParamText();// "例如: strIdentityID =01";
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: strUrl,
            method: "Get",
            dataType: "json",
            data: strData,
            success: function (data) {
                if (data.ErrorId == 0) {
                    var returnObjLst = JSON.parse(data.ReturnObjLst);
                    //console.log(returnObjLst);
                    resolve(returnObjLst);
                }
                else {
                    console.error(data.ErrorMsg);
                    reject(data.ErrorMsg);
                }
            },
            error: function (result) {
                console.error(result);
                console.error(JSON.stringify(result));
                if (result.statusText == "error") {
                    var strInfo = `网络错误！访问地址:${strUrl} 不成功！`;
                    reject(strInfo);
                }
                else {
                    reject(result.statusText);
                }
            }
        });
    });
};
/// <summary>
/// 根据关键字获取相关对象, 从缓存中获取.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
/// </summary>
/// <param name = "strPaperId">所给的关键字</param>
/// <returns>对象</returns>
export async function PaperEx_GetObjByPaperIdById_CurrEduCls_Cache(strPaperId: string, strid_CurrEduCls: string) {
    var arrPaperObjLst_Cache: Array<clsPaperEN> = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
    var obj: clsPaperEN = new clsPaperEN();
    try {
        var arrPaper_Sel: Array<clsPaperEN> = arrPaperObjLst_Cache.filter(x => x.paperId == strPaperId);
        var objPaper: clsPaperEN;
        if (arrPaper_Sel.length > 0) {
            objPaper = arrPaper_Sel[0];
            return objPaper;
        }
        else {
            return obj;
        }
    }
    catch (e) {
        var strMsg: string = `错误:[${e}]. \n根据关键字:[${strPaperId}]获取相应的对象不成功!`;
        console.error(strMsg);
        alert(strMsg);
    }
    return obj;
};


/// <summary>
/// 刷新本类中的缓存.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
/// </summary>
export async function PaperEx_ReFreshThisCacheById_CurrEduCls(strid_CurrEduCls: string) {
    var strMsg: string = "";
    if (clsSysPara4WebApi2.spSetRefreshCacheOn == true) {
        var strKey: string = `${clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
        switch (clsPaperEN.CacheModeId) {
            case "04"://sessionStorage
                sessionStorage.removeItem(strKey);
                break;
            case "03"://localStorage
                localStorage.removeItem(strKey);
                break;
            case "02"://ClientCache
                CacheHelper.Remove(strKey);
                break;
            default:
                CacheHelper.Remove(strKey);
                break;
        }
        strMsg = `刷新缓存成功！`,
            console.trace(strMsg);
    }
    else {
        strMsg = `刷新缓存已经关闭。`;
        console.trace(strMsg);
    }
}


/// <summary>
/// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
/// </summary>
/// <returns>从本地缓存中获取的对象列表</returns>
export async function PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls: string) {
    var arrPaperObjLst_Cache: Array<clsPaperEN>;
    switch (clsPaperEN.CacheModeId) {
        case "04"://sessionStorage
            arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_sessionStorage(strid_CurrEduCls);
            break;
        case "03"://localStorage
            arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_localStorage(strid_CurrEduCls);
            break;
        case "02"://ClientCache
            arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls);
            break;
        default:
            arrPaperObjLst_Cache = await PaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls);
            break;
    }
    return arrPaperObjLst_Cache;
}

/// <summary>
/// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
/// </summary>
/// <returns>从本地缓存中获取的对象列表</returns>
export async function PaperEx_GetObjLstById_CurrEduCls_ClientCache(strid_CurrEduCls: string) {
    //初始化列表缓存
    var strWhereCond: string = "1=1";

    strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
    var strKey: string = `${clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
    if (strKey == "") {
        console.log("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (CacheHelper.Exsits(strKey)) {
        //缓存存在，直接返回
        var arrPaperObjLst_Cache: Array<clsPaperEN> = CacheHelper.Get(strKey);
        return arrPaperObjLst_Cache;
    }
    try {
        const responseText = await PaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
        var arrPaperObjLst: Array<clsPaperEN> = <Array<clsPaperEN>>responseText;
        CacheHelper.Add(strKey, arrPaperObjLst);
        var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperObjLst.length}!`;
        console.log(strInfo);
        return arrPaperObjLst;
    }
    catch (e) {
        var strMsg: string = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
        console.error(strMsg);
        throw (strMsg);
    }
}

/// <summary>
/// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
/// </summary>
/// <returns>从本地缓存中获取的对象列表</returns>
export async function PaperEx_GetObjLstById_CurrEduCls_localStorage(strid_CurrEduCls: string) {
    //初始化列表缓存
    var strWhereCond: string = "1=1";

    strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
    var strKey: string = `${clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
    if (strKey == "") {
        console.log("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (localStorage.hasOwnProperty(strKey)) {
        //缓存存在，直接返回
        var strTempObjLst: string = localStorage.getItem(strKey) as string;
        var arrPaperObjLst_Cache: Array<clsPaperEN> = JSON.parse(strTempObjLst);
        return arrPaperObjLst_Cache;
    }
    try {
        const responseText = await PaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
        var arrPaperObjLst: Array<clsPaperEN> = <Array<clsPaperEN>>responseText;
        localStorage.setItem(strKey, JSON.stringify(arrPaperObjLst));
        var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperObjLst.length}!`;
        console.log(strInfo);
        return arrPaperObjLst;
    }
    catch (e) {
        var strMsg: string = `从本地缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
        console.error(strMsg);
        throw (strMsg);
    }
}
/// <summary>
/// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
/// </summary>
/// <returns>从本地缓存中获取的对象列表</returns>
export async function PaperEx_GetObjLstById_CurrEduCls_sessionStorage(strid_CurrEduCls: string) {
    //初始化列表缓存
    var strWhereCond: string = "1=1";

    strWhereCond = `id_CurrEduCls='${strid_CurrEduCls}'`;
    var strKey: string = `${clsPaperEN._CurrTabName}_${strid_CurrEduCls}`;
    if (strKey == "") {
        console.log("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (sessionStorage.hasOwnProperty(strKey)) {
        //缓存存在，直接返回
        var strTempObjLst: string = sessionStorage.getItem(strKey) as string;
        var arrPaperObjLst_Cache: Array<clsPaperEN> = JSON.parse(strTempObjLst);
        return arrPaperObjLst_Cache;
    }
    try {
        const responseText = await PaperEx_GetObjLstById_CurrEduCls(strid_CurrEduCls);
        var arrPaperObjLst: Array<clsPaperEN> = <Array<clsPaperEN>>responseText;
        sessionStorage.setItem(strKey, JSON.stringify(arrPaperObjLst));
        var strInfo: string = `Key:[${strKey}]的缓存已经建立，对象列表数：${arrPaperObjLst.length}!`;
        console.log(strInfo);
        return arrPaperObjLst;
    }
    catch (e) {
        var strMsg: string = `从缓存中获取所有对象列表出错. \n服务器错误：${e}.`;
        console.error(strMsg);
        throw (strMsg);
    }
}

/// <summary>
/// 根据条件对象, 从缓存的对象列表中获取子集.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
/// </summary>
/// <param name = "objstrSubViewpointId_Cond">条件对象</param>
/// <returns>对象列表子集</returns>
export async function PaperEx_GetSubObjLstById_CurrEduCls_Cache(objPaper_Cond: clsPaperEN, strid_CurrEduCls: string) {
    var arrPaperObjLst_Cache: Array<clsPaperEN> = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
    var arrPaper_Sel: Array<clsPaperEN> = arrPaperObjLst_Cache.filter(x => true);
    if (objPaper_Cond.sf_FldComparisonOp == null || objPaper_Cond.sf_FldComparisonOp == "") return arrPaper_Sel;
    var dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaper_Cond.sf_FldComparisonOp);
    //console.log("clsPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        var sstrKeys = clsCommonFunc4Web.GetObjKeys(objPaper_Cond);
        //console.log(sstrKeys);
        for (let strKey of sstrKeys) {
            if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] != null);
            var strComparisonOp = dicFldComparisonOp[strKey];
            var strValue = objPaper_Cond[strKey];
            var strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                    }
                    break;
                case "number":
                    if (strValue == 0) continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                    }
                    break;
            }
        }
        return arrPaper_Sel;
    }
    catch (e) {
        var strMsg: string = `错误:[${e}]. \n根据条件:[${JSON.stringify(objPaper_Cond)}]缓存对象列表中获取子集对象不成功!`;
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsPaperEN>();
};
/// <summary>
/// 根据条件对象, 从缓存的对象列表中获取记录数.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
/// </summary>
/// <param name = "objPaper_Cond">条件对象</param>
/// <returns>对象列表记录数</returns>
export async function PaperEx_GetRecCountByCondById_CurrEduCls_Cache(objPaper_Cond: clsPaperEN, strid_CurrEduCls: string) {
    var arrPaperObjLst_Cache: Array<clsPaperEN> = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
    var arrPaper_Sel: Array<clsPaperEN> = arrPaperObjLst_Cache.filter(x => true);
    if (objPaper_Cond.sf_FldComparisonOp == null || objPaper_Cond.sf_FldComparisonOp == "") return arrPaper_Sel.length;
    var dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaper_Cond.sf_FldComparisonOp);
    //console.log("clsPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        var sstrKeys = clsCommonFunc4Web.GetObjKeys(objPaper_Cond);
        //console.log(sstrKeys);
        for (let strKey of sstrKeys) {
            if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] != null);
            var strComparisonOp = dicFldComparisonOp[strKey];
            var strValue = objPaper_Cond[strKey];
            var strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                    }
                    break;
                case "number":
                    if (strValue == 0) continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                    }
                    break;
            }
        }
        return arrPaper_Sel.length;
    }
    catch (e) {
        var strMsg: string = `错误:[${e}]. \n根据条件:[${JSON.stringify(objPaper_Cond)}]从缓存对象列表中获取记录数不成功!`;
        console.error(strMsg);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return 0;
};

/// <summary>
/// 从缓存中获取分页对象列表.
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
/// </summary>
/// <param name = "objPagerPara">分页参数结构</param>
/// <returns>对象列表</returns>
export async function PaperEx_GetObjLstByPagerById_CurrEduCls_Cache(objPagerPara: stuPagerPara, strid_CurrEduCls: string) {
    var arrPaperObjLst_Cache: Array<clsPaperEN> = await PaperEx_GetObjLstById_CurrEduCls_Cache(strid_CurrEduCls);
    if (arrPaperObjLst_Cache.length == 0) return arrPaperObjLst_Cache;
    var arrPaper_Sel: Array<clsPaperEN> = arrPaperObjLst_Cache.filter(x => true);
    var obj_Cond: clsPaperEN = JSON.parse(objPagerPara.whereCond);
    var dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsPaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        var sstrKeys = clsCommonFunc4Web.GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (let strKey of sstrKeys) {
            if (dicFldComparisonOp.hasOwnProperty(strKey) == false) continue;
            arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] != null);
            var strComparisonOp = dicFldComparisonOp[strKey];
            var strValue = obj_Cond[strKey];
            var strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey].toString().indexOf(strValue) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                    }
                    break;
                case "number":
                    if (strValue == 0) continue;
                    if (strComparisonOp == "=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrPaper_Sel = arrPaper_Sel.filter(x => x[strKey] <= strValue);
                    }
                    break;
            }
        }
        if (arrPaper_Sel.length == 0) return arrPaper_Sel;
        var intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        var intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            var sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            var strSortType: string = "asc";
            var strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            //                console.log(arrPaper_Sel);
            let objFirst = arrPaper_Sel[0];//第一个对象
            let strSortValue = objFirst[strSortFld];  //第一个对象排序字段值            
            let strSortFldType = typeof (strSortValue);//排序字段值的数据类型
            //console.log("排序字段的数据类型: " + strSortFldType);
            switch (strSortFldType) {
                case "string":
                    if (strSortType.toLowerCase() == "asc") {
                        arrPaper_Sel = arrPaper_Sel.sort((x, y) => x[strSortFld].localeCompare(y[strSortFld]));
                    }
                    else {
                        arrPaper_Sel = arrPaper_Sel.sort((x, y) => y[strSortFld].localeCompare(x[strSortFld]));
                    }
                    break;
                case "number":
                case "boolean":
                    if (strSortType.toLowerCase() == "asc") {
                        arrPaper_Sel = arrPaper_Sel.sort((x, y) => x[strSortFld] - y[strSortFld]);
                    }
                    else {
                        arrPaper_Sel = arrPaper_Sel.sort((x, y) => y[strSortFld] - x[strSortFld]);
                    }
                    break;
            }
        }
        else {
            //如果排序字段名[orderBy]为空，就调用排序函数
            arrPaper_Sel = arrPaper_Sel.sort(objPagerPara.sortFun);
        }
        arrPaper_Sel = arrPaper_Sel.slice(intStart, intEnd);
        return arrPaper_Sel;
    }
    catch (e) {
        var strMsg: string = `错误:[${e}]. \n根据条件:[${objPagerPara.whereCond}]获取分页对象列表不成功!(In Paper_GetObjLstByPager_Cache)`;
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsPaperEN>();
};
