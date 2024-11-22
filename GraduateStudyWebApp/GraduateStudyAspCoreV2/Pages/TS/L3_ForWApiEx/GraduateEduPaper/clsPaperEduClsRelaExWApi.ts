
/**
* 论文教学班关系(PaperEduClsRela)
* (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
* Created by pyf on 2023年01月09日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
**/
//import $ from "jquery";
import { clsCurrEduClsEN } from "../../L0_Entity/DailyRunning_Share/clsCurrEduClsEN.js";
import { clsPaperEduClsRelaEN } from "../../L0_Entity/GraduateEduPaper/clsPaperEduClsRelaEN.js";
import { clsPaperEduClsRelaENEx } from "../../L0_Entity/GraduateEduPaper/clsPaperEduClsRelaENEx.js";
import { CurrEduCls_func, CurrEduCls_funcKey } from "../../L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js";
import { PaperEduClsRela_AddNewRecordAsync, PaperEduClsRela_FilterFunByKey, PaperEduClsRela_GetObjLstAsync, PaperEduClsRela_GetObjLst_Cache, PaperEduClsRela_GetUniCondStr_PaperId_id_CurrEduCls, PaperEduClsRela_IsExistRecordAsync, PaperEduClsRela_ReFreshCache, PaperEduClsRela_SortFunByKey } from "../../L3_ForWApi/GraduateEduPaper/clsPaperEduClsRelaWApi.js";
import { clsPrivateSessionStorage } from "../../PubConfig/clsPrivateSessionStorage.js";
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { BindDdl_ObjLstInDiv, GetObjKeys, GetSortExpressInfo, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsDateTime } from "../../PubFun/clsDateTime.js";
import { clsPublocalStorage } from "../../PubFun/clsPublocalStorage.js";
import { Format, IsNullOrEmpty } from "../../PubFun/clsString.js";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
export const paperEduClsRelaEx_Controller = "PaperEduClsRelaExApi";
export const paperEduClsRelaEx_ConstructorName = "paperEduClsRelaEx";

/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function PaperEduClsRelaEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objPaperEduClsRelaENS:源对象
* @returns 目标对象=>clsPaperEduClsRelaEN:objPaperEduClsRelaENT
**/
export function PaperEduClsRelaEx_CopyToEx(objPaperEduClsRelaENS: clsPaperEduClsRelaEN): clsPaperEduClsRelaENEx {
    const strThisFuncName = PaperEduClsRelaEx_CopyToEx.name;
    const objPaperEduClsRelaENT = new clsPaperEduClsRelaENEx();
    try {
        ObjectAssign(objPaperEduClsRelaENT, objPaperEduClsRelaENS);
        return objPaperEduClsRelaENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, paperEduClsRelaEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objPaperEduClsRelaENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function PaperEduClsRelaEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara, strid_CurrEduCls: string): Promise<Array<clsPaperEduClsRelaENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrPaperEduClsRelaObjLst = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
    const arrPaperEduClsRelaExObjLst = arrPaperEduClsRelaObjLst.map(PaperEduClsRelaEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrPaperEduClsRelaExObjLst) {
            const conFuncMap = await PaperEduClsRelaEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrPaperEduClsRelaExObjLst.length == 0) return arrPaperEduClsRelaExObjLst;
    let arrPaperEduClsRela_Sel: Array<clsPaperEduClsRelaENEx> = arrPaperEduClsRelaExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objPaperEduClsRela_Cond = new clsPaperEduClsRelaENEx();
    ObjectAssign(objPaperEduClsRela_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsPaperEduClsRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objPaperEduClsRela_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrPaperEduClsRela_Sel.length == 0) return arrPaperEduClsRela_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.sort(PaperEduClsRelaEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.sort(objPagerPara.sortFun);
        }
        arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.slice(intStart, intEnd);
        return arrPaperEduClsRela_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, paperEduClsRelaEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsPaperEduClsRelaENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function PaperEduClsRelaEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsPaperEduClsRelaENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrPaperEduClsRelaObjLst = await PaperEduClsRela_GetObjLstAsync(objPagerPara.whereCond);
    const arrPaperEduClsRelaExObjLst = arrPaperEduClsRelaObjLst.map(PaperEduClsRelaEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrPaperEduClsRelaExObjLst) {
            const conFuncMap = await PaperEduClsRelaEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrPaperEduClsRelaExObjLst.length == 0) return arrPaperEduClsRelaExObjLst;
    let arrPaperEduClsRela_Sel: Array<clsPaperEduClsRelaENEx> = arrPaperEduClsRelaExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.sort(PaperEduClsRelaEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.sort(objPagerPara.sortFun);
        }
        arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.slice(intStart, intEnd);
        return arrPaperEduClsRela_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, paperEduClsRelaEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsPaperEduClsRelaENEx>();
}

/**
* 把一个扩展类的部分属性进行函数转换
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
* @param objPaperEduClsRelaS:源对象
**/
export async function PaperEduClsRelaEx_FuncMap_EduClsName(objPaperEduClsRela: clsPaperEduClsRelaENEx) {
    const strThisFuncName = PaperEduClsRelaEx_FuncMap_EduClsName.name;
    try {
        if (IsNullOrEmpty(objPaperEduClsRela.eduClsName) == true) {
            const CurrEduCls_id_CurrEduClass = objPaperEduClsRela.id_CurrEduCls;
            const CurrEduCls_EduClassName = await CurrEduCls_func(clsCurrEduClsEN.con_id_CurrEduCls, clsCurrEduClsEN.con_EduClsName, CurrEduCls_id_CurrEduClass, clsPublocalStorage.courseId);
            objPaperEduClsRela.eduClsName = CurrEduCls_EduClassName;
        }
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000183)函数映射表对象数据出错,{0}.(in {1}.{2})", e, paperEduClsRelaEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
    }
}


/**
* 把一个扩展类的部分属性进行函数转换
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMap)
* @param objPaperEduClsRelaS:源对象
**/
export async function PaperEduClsRelaEx_FuncMap_PaperTitle_Author(objPaperEduClsRela: clsPaperEduClsRelaENEx) {
    const strThisFuncName = PaperEduClsRelaEx_FuncMap_EduClsName.name;
    try {
        if (IsNullOrEmpty(objPaperEduClsRela.paperTitle_Author) == true) {
            objPaperEduClsRela.paperTitle_Author = Format("{0}_{1}", objPaperEduClsRela.paperTitle, objPaperEduClsRela.author);
        }
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000183)函数映射表对象数据出错,{0}.(in {1}.{2})", e, paperEduClsRelaEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
    }
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-01-09
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function PaperEduClsRelaEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            case clsPaperEduClsRelaENEx.con_PaperTitle_Author:
                return (a: clsPaperEduClsRelaENEx, b: clsPaperEduClsRelaENEx) => {
                    return a.paperTitle_Author.localeCompare(b.paperTitle_Author);
                }
            case clsPaperEduClsRelaENEx.con_EduClsName:
                return (a: clsPaperEduClsRelaENEx, b: clsPaperEduClsRelaENEx) => {
                    return a.eduClsName.localeCompare(b.eduClsName);
                }
            default:
                return PaperEduClsRela_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            case clsPaperEduClsRelaENEx.con_PaperTitle_Author:
                return (a: clsPaperEduClsRelaENEx, b: clsPaperEduClsRelaENEx) => {
                    return b.paperTitle_Author.localeCompare(a.paperTitle_Author);
                }
            case clsPaperEduClsRelaENEx.con_EduClsName:
                return (a: clsPaperEduClsRelaENEx, b: clsPaperEduClsRelaENEx) => {
                    return b.eduClsName.localeCompare(a.eduClsName);
                }
            default:
                return PaperEduClsRela_SortFunByKey(strKey, AscOrDesc);
        }
    }
}

/**
 * 根据扩展字段名去调用相应的映射函数
 * 作者:pyf
 * 日期:2023-01-09
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
 * @param strFldName:扩展字段名
 * @param  obj{0}Ex:需要转换的对象
 * @returns 针对扩展字段名对转换对象进行函数映射
*/
export function PaperEduClsRelaEx_FuncMapByFldName(strFldName: string, objPaperEduClsRelaEx: clsPaperEduClsRelaENEx) {
    const strThisFuncName = PaperEduClsRelaEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsPaperEduClsRelaEN.AttributeName;
    if (arrFldName.indexOf(strFldName) > -1) return;
    //针对扩展字段进行映射
    switch (strFldName) {
        case clsPaperEduClsRelaENEx.con_EduClsName:
            return PaperEduClsRelaEx_FuncMap_EduClsName(objPaperEduClsRelaEx);
        case clsPaperEduClsRelaENEx.con_PaperTitle_Author:
            return PaperEduClsRelaEx_FuncMap_PaperTitle_Author(objPaperEduClsRelaEx);

        default:
            strMsg = Format("扩展字段:[{0}]在字段值函数映射中不存在！(in {1})", strFldName, strThisFuncName);
            console.error(strMsg);
    }
}

/**
 * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
 * 作者:pyf
 * 日期:2023-01-09
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function PaperEduClsRelaEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        case clsPaperEduClsRelaENEx.con_PaperTitle_Author:
            return (obj: clsPaperEduClsRelaENEx) => {
                return obj.paperTitle_Author === value;
            }
        case clsPaperEduClsRelaENEx.con_EduClsName:
            return (obj: clsPaperEduClsRelaENEx) => {
                return obj.eduClsName === value;
            }
        default:
            return PaperEduClsRela_FilterFunByKey(strKey, value);
    }
}

/**
* 把一个扩展类的部分属性进行函数转换
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapKey)
* @param objPaperEduClsRelaS:源对象
**/
export async function PaperEduClsRelaEx_FuncMapKey_EduClsName(objPaperEduClsRela: clsPaperEduClsRelaENEx): Promise<Array<string>> {
    const strThisFuncName = PaperEduClsRelaEx_FuncMapKey_EduClsName.name;
    try {
        if (IsNullOrEmpty(objPaperEduClsRela.eduClsName) == true) return [];
        const CurrEduCls_EduClassName = objPaperEduClsRela.eduClsName;
        const arrid_CurrEduCls = await CurrEduCls_funcKey(clsCurrEduClsEN.con_EduClsName, CurrEduCls_EduClassName, clsPublocalStorage.courseId, enumComparisonOp.Like_03);
        return arrid_CurrEduCls;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000183)函数映射表对象数据出错,{0}.(in {1}.{2})", e, paperEduClsRelaEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        throw (strMsg);
    }
}


/// <summary>
/// 绑定基于Web的下拉框
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
/// </summary>
/// <param name = "objDDL">需要绑定当前表的下拉框</param>
export async function PaperEduClsRelaEx_BindDdl_PaperIdByid_CurrEduClsInDiv_Cache(strDivName: string, strDdlName: string, strid_CurrEduCls: string) {

    var objDdl = document.getElementById(strDdlName);
    if (objDdl == null) {
        var strMsg = `下拉框：${strDdlName} 不存在！(In BindDdl_PaperIdInDiv_Cache)`;
        alert(strMsg);
        console.error(strMsg);
        throw (strMsg);
    }
    //为数据源于表的下拉框设置内容
    console.log("开始：BindDdl_PaperIdInDiv_Cache");
    const arrObjLst = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
    const arrObjExLat = arrObjLst.map(PaperEduClsRelaEx_CopyToEx);
    for (var objInFor of arrObjExLat) {
        PaperEduClsRelaEx_FuncMapByFldName(clsPaperEduClsRelaENEx.con_PaperTitle_Author, objInFor);
    }
    BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjExLat, clsPaperEduClsRelaEN.con_PaperId, clsPaperEduClsRelaENEx.con_PaperTitle_Author, "论文表");
}

/** 设置字段值-Id_CurrEduCls
  * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetFieldValue)
  **/
export async function PaperEduClsRelaEx_SetId_CurrEduCls(arrPaperId: Array<string>, strId_CurrEduCls: string) {
    const strThisFuncName = PaperEduClsRelaEx_SetId_CurrEduCls.name;
    if (strId_CurrEduCls == null || strId_CurrEduCls == "") {
        const strMsg = "请输入表ID(Id_CurrEduCls)!";
        console.error("Error: ", strMsg);
        //console.trace();
        alert(strMsg);
        return "";
    }
    if (arrPaperId.length == 0) {
        const strMsg = "没有选择记录，不能设置字段值!";
        console.error("Error: ", strMsg);
        //console.trace();
        alert(strMsg);
        return "";
    }
    try {

        let intCount = 0;
        for (const strPaperId of arrPaperId) {
            const objPaperEduClsRelaEN = new clsPaperEduClsRelaEN();

            objPaperEduClsRelaEN.Setid_CurrEduCls(strId_CurrEduCls);
            objPaperEduClsRelaEN.SetPaperId(strPaperId);
            objPaperEduClsRelaEN.SetUpdDate(clsDateTime.getTodayDateTimeStr(0));
            objPaperEduClsRelaEN.SetUpdUser(clsPublocalStorage.userId);
            const strCondition = PaperEduClsRela_GetUniCondStr_PaperId_id_CurrEduCls(objPaperEduClsRelaEN);
            try {
                let returnExist = await PaperEduClsRela_IsExistRecordAsync(strCondition);
                if (returnExist == true) continue;

                const returnBool = await PaperEduClsRela_AddNewRecordAsync(objPaperEduClsRelaEN);
                if (returnBool == true) intCount++;
            }
            catch (e) {
                const strMsg = Format("设置当前教学班不成功,{0}.(in {1}.{2})", e, paperEduClsRelaEx_ConstructorName, strThisFuncName);
                console.error(strMsg);
                return;
            }

        }

        //console.log('完成！');
        if (intCount > 0) {

            const strInfo = Format("设置当前教学成功!共设置:[{0}]记录.", intCount);
            alert(strInfo);

            PaperEduClsRela_ReFreshCache(strId_CurrEduCls);

        }
        else {
            const strInfo = Format("设置当前教学不成功!");
            //显示信息框
            alert(strInfo);
        }
    }
    catch (e) {
        const strMsg = Format("设置当前教学不成功,{0}.(in {1}.{2})", e, paperEduClsRelaEx_ConstructorName, strThisFuncName);
        console.error("Error: ", strMsg);
        //console.trace();
        alert(strMsg);
    }
}