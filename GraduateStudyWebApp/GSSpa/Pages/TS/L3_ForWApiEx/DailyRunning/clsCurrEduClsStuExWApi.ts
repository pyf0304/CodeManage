

/// <summary>
/// 教学班与学生关系(CurrEduClsStu)
/// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
/// </summary>
/**
* Created by pyf on 2021年06月11日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
import $ from "jquery";
import { clsCurrEduClsEN } from "../../L0_Entity/DailyRunning/clsCurrEduClsEN.js";
import { clsCurrEduClsStuEN } from "../../L0_Entity/DailyRunning/clsCurrEduClsStuEN.js";
import { clsCurrEduClsStuENEx } from "../../L0_Entity/DailyRunning/clsCurrEduClsStuENEx.js";
import { CurrEduClsStu_FilterFunByKey, CurrEduClsStu_GetObjLstAsync, CurrEduClsStu_GetObjLst_Cache, CurrEduClsStu_SortFunByKey } from "../../L3_ForWApi/DailyRunning/clsCurrEduClsStuWApi.js";
import { GetObjKeys, GetSortExpressInfo, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { Format, IsNullOrEmpty } from "../../PubFun/clsString.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
//import * as QQ from "q";
import { CurrEduCls_GetObjLst_Cache } from "../../L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js";
import { clsCommonFunc4Web } from "../../PubFun/clsCommonFunc4Web2.js";
import { clsString } from "../../PubFun/clsString.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";

import { clsSysPara4WebApi } from "../../PubFun/clsSysPara4WebApi.js";
export const currEduClsStuEx_Controller = "CurrEduClsStuExApi";
export const currEduClsStuEx_ConstructorName = "currEduClsStuEx";
/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function CurrEduClsStuEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objCurrEduClsStuENS:源对象
* @returns 目标对象=>clsCurrEduClsStuEN:objCurrEduClsStuENT
**/
export function CurrEduClsStuEx_CopyToEx(objCurrEduClsStuENS: clsCurrEduClsStuEN): clsCurrEduClsStuENEx {
    const strThisFuncName = CurrEduClsStuEx_CopyToEx.name;
    const objCurrEduClsStuENT = new clsCurrEduClsStuENEx();
    try {
        ObjectAssign(objCurrEduClsStuENT, objCurrEduClsStuENS);
        return objCurrEduClsStuENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, currEduClsStuEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objCurrEduClsStuENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function CurrEduClsStuEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara, strid_CurrEduCls: string): Promise<Array<clsCurrEduClsStuENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrCurrEduClsStuObjLst = await CurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
    const arrCurrEduClsStuExObjLst = arrCurrEduClsStuObjLst.map(CurrEduClsStuEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrCurrEduClsStuExObjLst) {
            const conFuncMap = await CurrEduClsStuEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrCurrEduClsStuExObjLst.length == 0) return arrCurrEduClsStuExObjLst;
    let arrCurrEduClsStu_Sel: Array<clsCurrEduClsStuENEx> = arrCurrEduClsStuExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objCurrEduClsStu_Cond = new clsCurrEduClsStuENEx();
    ObjectAssign(objCurrEduClsStu_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsCurrEduClsStuWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objCurrEduClsStu_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrCurrEduClsStu_Sel.length == 0) return arrCurrEduClsStu_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.sort(CurrEduClsStuEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.sort(objPagerPara.sortFun);
        }
        arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.slice(intStart, intEnd);
        return arrCurrEduClsStu_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, currEduClsStuEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsCurrEduClsStuENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function CurrEduClsStuEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsCurrEduClsStuENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrCurrEduClsStuExObjLst = await CurrEduClsStu_GetObjLstAsync(objPagerPara.whereCond);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrCurrEduClsStuExObjLst) {
            const conFuncMap = await CurrEduClsStuEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrCurrEduClsStuExObjLst.length == 0) return arrCurrEduClsStuExObjLst;
    let arrCurrEduClsStu_Sel: Array<clsCurrEduClsStuENEx> = arrCurrEduClsStuExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.sort(CurrEduClsStuEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.sort(objPagerPara.sortFun);
        }
        arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.slice(intStart, intEnd);
        return arrCurrEduClsStu_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, currEduClsStuEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsCurrEduClsStuENEx>();
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
export function CurrEduClsStuEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return CurrEduClsStu_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return CurrEduClsStu_SortFunByKey(strKey, AscOrDesc);
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
export function CurrEduClsStuEx_FuncMapByFldName(strFldName: string, objCurrEduClsStuEx: clsCurrEduClsStuENEx) {
    const strThisFuncName = CurrEduClsStuEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsCurrEduClsStuEN.AttributeName;
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
export async function CurrEduClsStuEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return CurrEduClsStu_FilterFunByKey(strKey, value);
    }
}


/**
* 根据学生Id获取教学班流水号列表
* (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
* @param strStuId: 学号
* @returns 获取的相应对象列表
*/
export async function CurrEduClsStuEx_Getid_CurrEduClsListByStuId(strStuId: string): Promise<Array<string>> {
    var strAction = "Getid_CurrEduClsListByStuId";
    let strUrl = CurrEduClsStuEx_GetWebApiUrl(currEduClsStuEx_Controller, strAction);
    var mapParam: Dictionary = new Dictionary();
    mapParam.add("strStuId", strStuId);
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
* 根据教学班流水号获取学生Id列表
* (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
* @param strId_CurrEduCls: 教学班流水号
* @returns 获取的相应对象列表
*/
export async function CurrEduClsStuEx_GetStuIDLstById_CurrEduCls(strId_CurrEduCls: string): Promise<Array<string>> {
    var strAction = "GetStuIDLstById_CurrEduCls";
    let strUrl = CurrEduClsStuEx_GetWebApiUrl(currEduClsStuEx_Controller, strAction);
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
export async function CurrEduClsStuEx_BindDdl_id_CurrEduClsByStuIdInDiv_Cache(strDivName: string, strDdlName: string, strStuId: string) {

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


    const arrId_CurrEduClsLst = await CurrEduClsStuEx_Getid_CurrEduClsListByStuId(strStuId);
    const arrObjLst_Sel2 = arrObjLst_Sel.filter(x => arrId_CurrEduClsLst.indexOf(x.id_CurrEduCls) > -1);

    clsCommonFunc4Web.BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel2, clsCurrEduClsEN.con_id_CurrEduCls, clsCurrEduClsEN.con_EduClsName, "教学班");
}

