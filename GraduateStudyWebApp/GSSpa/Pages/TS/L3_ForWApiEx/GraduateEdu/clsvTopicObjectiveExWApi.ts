/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvTopicObjectiveWApi
表名:vTopicObjective(01120617)
生成代码版本:2020.04.24.1
生成日期:2020/04/25 09:43:48
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_访问层(WA_Access)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

/// <summary>
/// vTopicObjective(vTopicObjective)
/// (AutoGCLib.WA_Access4TypeScript:GeneCode)
/// </summary>
/**
* Created by  on 2020年04月25日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
import * as $ from "jquery";
//import * as QQ from "q";
import { clsvTopicObjectiveEN } from "../../L0_Entity/GraduateEduTopic/clsvTopicObjectiveEN.js";
import { clsCommonFunc4Web } from "../../PubFun/clsCommonFunc4Web2.js";
//import { clsvTopicObjectiveEN_Sim } from "../../L0_Entity/GraduateEdu/clsvTopicObjectiveEN_Sim.js";
//import { clsvTopicObjectiveBL } from "../../L2_BLL/GraduateEdu/clsvTopicObjectiveBL.js";
import { clsUsersEN } from "../../L0_Entity/UserManage/clsUsersEN.js";
import { clsvUsersSimEN } from "../../L0_Entity/UserManage/clsvUsersSimEN.js";
import { vTopicObjective_FilterFunByKey, vTopicObjective_GetObjLstAsync, vTopicObjective_GetObjLst_Cache } from "../../L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js";
import { vUsersSim_GetObjLst_Cache } from "../../L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { clsPublocalStorage } from "../../PubFun/clsPublocalStorage.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";

import { clsvTopicObjectiveENEx } from "../../L0_Entity/GraduateEduTopic/clsvTopicObjectiveENEx.js";
import { vTopicObjective_SortFunByKey } from "../../L3_ForWApi/GraduateEduTopic/clsvTopicObjectiveWApi.js";
import { GetObjKeys, GetSortExpressInfo, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { Format, IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi } from "../../PubFun/clsSysPara4WebApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
export const vTopicObjectiveEx_Controller = "vTopicObjectiveExApi";
export const vTopicObjectiveEx_ConstructorName = "vTopicObjectiveEx";

//public static cacheModeId = "02"; //客户端缓存


/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function vTopicObjectiveEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objvTopicObjectiveENS:源对象
* @returns 目标对象=>clsvTopicObjectiveEN:objvTopicObjectiveENT
**/
export function vTopicObjectiveEx_CopyToEx(objvTopicObjectiveENS: clsvTopicObjectiveEN): clsvTopicObjectiveENEx {
    const strThisFuncName = vTopicObjectiveEx_CopyToEx.name;
    const objvTopicObjectiveENT = new clsvTopicObjectiveENEx();
    try {
        ObjectAssign(objvTopicObjectiveENT, objvTopicObjectiveENS);
        return objvTopicObjectiveENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, vTopicObjectiveEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objvTopicObjectiveENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function vTopicObjectiveEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara, strid_CurrEduCls: string): Promise<Array<clsvTopicObjectiveENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrvTopicObjectiveObjLst = await vTopicObjective_GetObjLst_Cache(strid_CurrEduCls);
    const arrvTopicObjectiveExObjLst = arrvTopicObjectiveObjLst.map(vTopicObjectiveEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrvTopicObjectiveExObjLst) {
            const conFuncMap = await vTopicObjectiveEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrvTopicObjectiveExObjLst.length == 0) return arrvTopicObjectiveExObjLst;
    let arrvTopicObjective_Sel: Array<clsvTopicObjectiveENEx> = arrvTopicObjectiveExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objvTopicObjective_Cond = new clsvTopicObjectiveENEx();
    ObjectAssign(objvTopicObjective_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsvTopicObjectiveWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objvTopicObjective_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrvTopicObjective_Sel = arrvTopicObjective_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrvTopicObjective_Sel.length == 0) return arrvTopicObjective_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrvTopicObjective_Sel = arrvTopicObjective_Sel.sort(vTopicObjectiveEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrvTopicObjective_Sel = arrvTopicObjective_Sel.sort(objPagerPara.sortFun);
        }
        arrvTopicObjective_Sel = arrvTopicObjective_Sel.slice(intStart, intEnd);
        return arrvTopicObjective_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vTopicObjectiveEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsvTopicObjectiveENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function vTopicObjectiveEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvTopicObjectiveENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrvTopicObjectiveExObjLst = await vTopicObjective_GetObjLstAsync(objPagerPara.whereCond);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrvTopicObjectiveExObjLst) {
            const conFuncMap = await vTopicObjectiveEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrvTopicObjectiveExObjLst.length == 0) return arrvTopicObjectiveExObjLst;
    let arrvTopicObjective_Sel: Array<clsvTopicObjectiveENEx> = arrvTopicObjectiveExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrvTopicObjective_Sel = arrvTopicObjective_Sel.sort(vTopicObjectiveEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrvTopicObjective_Sel = arrvTopicObjective_Sel.sort(objPagerPara.sortFun);
        }
        arrvTopicObjective_Sel = arrvTopicObjective_Sel.slice(intStart, intEnd);
        return arrvTopicObjective_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vTopicObjectiveEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsvTopicObjectiveENEx>();
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
export function vTopicObjectiveEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return vTopicObjective_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return vTopicObjective_SortFunByKey(strKey, AscOrDesc);
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
export function vTopicObjectiveEx_FuncMapByFldName(strFldName: string, objvTopicObjectiveEx: clsvTopicObjectiveENEx) {
    const strThisFuncName = vTopicObjectiveEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsvTopicObjectiveEN.AttributeName;
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
export async function vTopicObjectiveEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return vTopicObjective_FilterFunByKey(strKey, value);
    }
}

/// <summary>
/// 获取论文中的用户数量
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
/// </summary>
/// <param name = "strWhereCond">条件</param>
/// <returns>获取的相应对象列表</returns>
export async function vTopicObjectiveEx_GetTopicObjectiveUserObjLstAsync(strWhereCond: string): Promise<Array<clsvTopicObjectiveEN>> {
    var strAction = "GetTopicObjectiveUserObjLst";
    let strUrl = vTopicObjectiveEx_GetWebApiUrl(vTopicObjectiveEx_Controller, strAction);
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


//从客观事实表中得到用户数据
/// <summary>
/// 绑定基于Web的下拉框
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
/// </summary>
export async function vTopicObjectiveEx_BindDdl_UserIdInvTopicObjectiveFact_Cache(strDdlName: string, objUsers_Cond: clsUsersEN) {
    var objDdl = document.getElementById(strDdlName);
    if (objDdl == null) {
        var strMsg = `下拉框：${strDdlName} 不存在！`;
        alert(strMsg);
        throw (strMsg);
    }
    //为数据源于表的下拉框设置内容
    console.log("开始：BindDdl_UserIdInvConcept_Cache");
    var arrvConcept: Array<clsvTopicObjectiveEN> = await vTopicObjective_GetObjLstAsync("1=1");

    //获取客观事实
    var arrvclsvTopicObjectiveEN: Array<clsvTopicObjectiveEN> = new Array<clsvTopicObjectiveEN>();
    arrvclsvTopicObjectiveEN = arrvConcept.filter(x => x.objectiveType == "01");//客观事实；

    var arrObjLst_Sel: Array<clsUsersEN> = arrvclsvTopicObjectiveEN.map(vTopicObjectiveEx_GetUsersByvobjvTopicObjective);
    arrObjLst_Sel = vTopicObjectiveEx_uniq(arrObjLst_Sel);
    console.log(arrObjLst_Sel);
    arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsUsersEN.con_UserName]);
    clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsUsersEN.con_UserId, clsUsersEN.con_UserName, "编辑用户");
}



//从客观数据表中得到用户数据
/// <summary>
/// 绑定基于Web的下拉框
/// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
/// </summary>
/// <param name = "objDDL">需要绑定当前表的下拉框</param>
export async function vTopicObjectiveEx_BindDdl_UserIdInvTopicObjectiveBasis_Cache(strDdlName: string, objUsers_Cond: clsUsersEN) {
    var objDdl = document.getElementById(strDdlName);
    if (objDdl == null) {
        var strMsg = `下拉框：${strDdlName} 不存在！`;
        alert(strMsg);
        throw (strMsg);
    }
    console.log("开始：BindDdl_UserIdInvConcept_Cache");
    var arrvObjList: Array<clsvTopicObjectiveEN> = await vTopicObjective_GetObjLst_Cache(clsPublocalStorage.Getid_CurrEduCls());

    //获取客观数据
    var arrvclsvTopicObjectiveEN: Array<clsvTopicObjectiveEN> = new Array<clsvTopicObjectiveEN>();
    arrvclsvTopicObjectiveEN = arrvObjList.filter(x => x.objectiveType == "02");//客观数据；

    var arrUserId_Set: Set<string> = new Set(arrvclsvTopicObjectiveEN.map(x => x.updUser));
    console.log(arrUserId_Set);

    var arrUsers = await vUsersSim_GetObjLst_Cache();
    var arrUsersList_Sel: Array<clsvUsersSimEN> = arrUsers.filter(x => arrUserId_Set.has(x.userId));
    console.log(arrUsersList_Sel);
    arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsvUsersSimEN.con_UserName]);
    clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrUsersList_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "编辑用户");
    ////为数据源于表的下拉框设置内容
    //console.log("开始：BindDdl_UserIdInvConcept_Cache");
    //var arrvConcept: Array<clsvTopicObjectiveEN> = await vTopicObjective_GetObjLstAsync("1=1");

    ////获取客观数据
    //var arrvclsvTopicObjectiveEN: Array<clsvTopicObjectiveEN> = new Array<clsvTopicObjectiveEN>();
    //arrvclsvTopicObjectiveEN = arrvConcept.filter(x => x.objectiveType == "02");//客观数据；


    //var arrObjLst_Sel: Array<clsUsersEN> = arrvclsvTopicObjectiveEN.map(vTopicObjectiveEx_GetUsersByvobjvTopicObjective);
    //arrObjLst_Sel = clsvTopicObjectiveExWApi.uniq(arrObjLst_Sel);
    //console.log(arrObjLst_Sel);
    //arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsUsersEN.con_UserName]);
    //clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsUsersEN.con_UserId, clsUsersEN.con_UserName, "编辑用户");
}
export function vTopicObjectiveEx_uniq(arr: Array<clsUsersEN>): Array<clsUsersEN> {
    let arrObjLst_New: Array<clsUsersEN> = new Array<clsUsersEN>();
    for (let x of arr) {
        if (vTopicObjectiveEx_IsExist(arrObjLst_New, x) == false) {
            arrObjLst_New.push(x);
        }
    }
    return arrObjLst_New;
}

export function vTopicObjectiveEx_IsExist(arr: Array<clsUsersEN>, key: clsUsersEN) {
    let arr_Sel = arr.filter(x => x.userId == key.userId);
    if (arr_Sel.length > 0) return true;
    return false;
}


export function vTopicObjectiveEx_GetUsersByvobjvTopicObjective(objvTopicObjective: clsvTopicObjectiveEN): clsUsersEN {
    var objUsers: clsUsersEN = new clsUsersEN();
    objUsers.userId = objvTopicObjective.updUser;
    // objUsers.userName = objvTopicObjective.userName;
    return objUsers;
}

