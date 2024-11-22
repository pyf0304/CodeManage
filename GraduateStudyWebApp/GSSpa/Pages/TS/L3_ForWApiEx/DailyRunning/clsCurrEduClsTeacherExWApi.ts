
/// <summary>
/// 当前教学班教师(CurrEduClsTeacher)
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
import { clsCurrEduClsEN } from "../../L0_Entity/DailyRunning/clsCurrEduClsEN.js";
//import * as QQ from "q";
import { clsCurrEduClsTeacherEN } from "../../L0_Entity/DailyRunning/clsCurrEduClsTeacherEN.js";
import { clsCurrEduClsTeacherENEx } from "../../L0_Entity/DailyRunning/clsCurrEduClsTeacherENEx.js";
import { CurrEduClsTeacher_CopyObjTo, CurrEduClsTeacher_FilterFunByKey, CurrEduClsTeacher_GetObjLstAsync, CurrEduClsTeacher_GetObjLst_Cache, CurrEduClsTeacher_SortFunByKey } from "../../L3_ForWApi/DailyRunning/clsCurrEduClsTeacherWApi.js";
import { CurrEduCls_GetObjLst_Cache } from "../../L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js";
import { clsCommonFunc4Web } from "../../PubFun/clsCommonFunc4Web2.js";
import { clsString } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi2 } from "../../PubFun/clsSysPara4WebApi2.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
var ResponseData: tzResponseData;

import { Format, IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi } from "../../PubFun/clsSysPara4WebApi.js";
import { GetObjKeys, GetSortExpressInfo, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
export const currEduClsTeacherEx_Controller = "CurrEduClsTeacherExApi";
export const currEduClsTeacherEx_ConstructorName = "currEduClsTeacherEx";

/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function CurrEduClsTeacherEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objCurrEduClsTeacherENS:源对象
* @returns 目标对象=>clsCurrEduClsTeacherEN:objCurrEduClsTeacherENT
**/
export function CurrEduClsTeacherEx_CopyToEx(objCurrEduClsTeacherENS: clsCurrEduClsTeacherEN): clsCurrEduClsTeacherENEx {
    const strThisFuncName = CurrEduClsTeacherEx_CopyToEx.name;
    const objCurrEduClsTeacherENT = new clsCurrEduClsTeacherENEx();
    try {
        ObjectAssign(objCurrEduClsTeacherENT, objCurrEduClsTeacherENS);
        return objCurrEduClsTeacherENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, currEduClsTeacherEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objCurrEduClsTeacherENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function CurrEduClsTeacherEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara, strid_CurrEduCls: string): Promise<Array<clsCurrEduClsTeacherENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrCurrEduClsTeacherObjLst = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
    const arrCurrEduClsTeacherExObjLst = arrCurrEduClsTeacherObjLst.map(CurrEduClsTeacherEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrCurrEduClsTeacherExObjLst) {
            const conFuncMap = await CurrEduClsTeacherEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrCurrEduClsTeacherExObjLst.length == 0) return arrCurrEduClsTeacherExObjLst;
    let arrCurrEduClsTeacher_Sel: Array<clsCurrEduClsTeacherENEx> = arrCurrEduClsTeacherExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objCurrEduClsTeacher_Cond = new clsCurrEduClsTeacherENEx();
    ObjectAssign(objCurrEduClsTeacher_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsCurrEduClsTeacherWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objCurrEduClsTeacher_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrCurrEduClsTeacher_Sel.length == 0) return arrCurrEduClsTeacher_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.sort(CurrEduClsTeacherEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.sort(objPagerPara.sortFun);
        }
        arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.slice(intStart, intEnd);
        return arrCurrEduClsTeacher_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, currEduClsTeacherEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsCurrEduClsTeacherENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function CurrEduClsTeacherEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsCurrEduClsTeacherENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrCurrEduClsTeacherExObjLst = await CurrEduClsTeacher_GetObjLstAsync(objPagerPara.whereCond);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrCurrEduClsTeacherExObjLst) {
            const conFuncMap = await CurrEduClsTeacherEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrCurrEduClsTeacherExObjLst.length == 0) return arrCurrEduClsTeacherExObjLst;
    let arrCurrEduClsTeacher_Sel: Array<clsCurrEduClsTeacherENEx> = arrCurrEduClsTeacherExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.sort(CurrEduClsTeacherEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.sort(objPagerPara.sortFun);
        }
        arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.slice(intStart, intEnd);
        return arrCurrEduClsTeacher_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, currEduClsTeacherEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsCurrEduClsTeacherENEx>();
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
export function CurrEduClsTeacherEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return CurrEduClsTeacher_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return CurrEduClsTeacher_SortFunByKey(strKey, AscOrDesc);
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
export function CurrEduClsTeacherEx_FuncMapByFldName(strFldName: string, objCurrEduClsTeacherEx: clsCurrEduClsTeacherENEx) {
    const strThisFuncName = CurrEduClsTeacherEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsCurrEduClsTeacherEN.AttributeName;
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
export async function CurrEduClsTeacherEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return CurrEduClsTeacher_FilterFunByKey(strKey, value);
    }
}
//export class clsCurrEduClsTeacherExWApi {
//    public static mstrController: string = "CurrEduClsTeacherExApi";
//    public objCurrEduClsTeacherEN: clsCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();

/// <summary>
/// 构造函数
/// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
/// </summary>
//constructor() {
//};

/// <summary>
/// 获取WebApi的地址
/// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
/// </summary>
/// <returns>返回当前文件中Web服务的地址</returns>


/**
* 根据教师Id获取教学班流水号列表
* (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
* @param strTeacherId: 工号
* @returns 获取的相应对象列表
*/
export async function CurrEduClsTeacherEx_Getid_CurrEduClsListByTeacherId(strTeacherId: string): Promise<Array<string>> {
    var strAction = "Getid_CurrEduClsListByTeacherId";
    let strUrl = CurrEduClsTeacherEx_GetWebApiUrl(currEduClsTeacherEx_Controller, strAction);
    var mapParam: Dictionary = new Dictionary();
    mapParam.add("strTeacherId", strTeacherId);
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


/**
* 根据教师Id获取教学班流水号列表
* (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
* @param strTeacherId: 工号
* @returns 获取的相应对象列表
*/
export async function CurrEduClsTeacherEx_SetCurrEduClsOrderNum4TeacherId(arrCurrEduClsObjLst: Array<clsCurrEduClsEN>, strTeacherId: string,): Promise<void> {
    const arrCurrEduClsTeacher = await CurrEduClsTeacherEx_GetObjListByTeacherId(strTeacherId);
    for (let objCurrEduCls of arrCurrEduClsObjLst) {
        const objCurrEduClsTeacher = arrCurrEduClsTeacher.find(x => x.id_CurrEduCls == objCurrEduCls.id_CurrEduCls);
        if (objCurrEduClsTeacher == null) continue;
        objCurrEduCls.intTag = objCurrEduClsTeacher.orderNum;
    }
};



/**
* 根据教学班流水号获取教师Id列表
* (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
* @param strId_CurrEduCls: 教学班流水号
* @returns 获取的相应对象列表
*/
export async function CurrEduClsTeacherEx_GetTeacherIdLstById_CurrEduCls(strId_CurrEduCls: string): Promise<Array<string>> {
    var strAction = "GetTeacherIdLstById_CurrEduCls";
    let strUrl = CurrEduClsTeacherEx_GetWebApiUrl(currEduClsTeacherEx_Controller, strAction);
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
/**
* 绑定基于Web的下拉框
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
* @param objDDL:需要绑定当前表的下拉框
*/
export async function CurrEduClsTeacherEx_BindDdl_id_CurrEduClsByTeacherIdInDiv_Cache(strDivName: string, strDdlName: string, strTeacherId: string) {

    const objDdl = document.getElementById(strDdlName);
    if (objDdl == null) {
        const strMsg = clsString.Format("下拉框：{0} 不存在！(In BindDdl_id_CurrEduClsInDiv_Cache)", strDdlName);
        alert(strMsg);
        console.error(strMsg);
        throw (strMsg);
    }
    //为数据源于表的下拉框设置内容
    console.log("开始：BindDdl_id_CurrEduClsInDiv_Cache");
    const arrObjLst_Sel: Array<clsCurrEduClsEN> = await CurrEduCls_GetObjLst_Cache();


    const arrId_CurrEduClsLst = await CurrEduClsTeacherEx_Getid_CurrEduClsListByTeacherId(strTeacherId);
    const arrObjLst_Sel2 = arrObjLst_Sel.filter(x => arrId_CurrEduClsLst.indexOf(x.id_CurrEduCls) > -1);

    clsCommonFunc4Web.BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel2, clsCurrEduClsEN.con_id_CurrEduCls, clsCurrEduClsEN.con_EduClsName, "教学班");
}

/**
* 根据工号获取教学班教师对象列表
* (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
* @param strTeacherId: 工号
* @returns 获取的相应对象列表
*/
export async function CurrEduClsTeacherEx_GetObjListByTeacherId(strTeacherId: string): Promise<Array<clsCurrEduClsTeacherEN>> {
    var strAction = "GetObjListByTeacherId";
    let strUrl = CurrEduClsTeacherEx_GetWebApiUrl(currEduClsTeacherEx_Controller, strAction);
    var mapParam: Dictionary = new Dictionary();
    mapParam.add("strTeacherId", strTeacherId);
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
