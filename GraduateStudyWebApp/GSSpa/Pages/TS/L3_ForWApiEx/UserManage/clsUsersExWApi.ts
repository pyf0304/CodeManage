
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsUsersExWApi
表名:Users(01120034)
生成代码版本:2019.12.06.1
生成日期:2019/12/19 01:38:30
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:用户管理
模块英文名:UserManage
框架-层名:WA_访问层(WA_Access)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

/// <summary>
/// 用户(Users)
/// (AutoGCLib.WA_Access4TypeScript:GeneCode)
/// </summary>
/**
* Created by  on 2019年12月19日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
import * as $ from "jquery";
//import * as QQ from "q";
import { clsUsersEN } from "../../L0_Entity/UserManage/clsUsersEN.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
import { clsUsersENEx } from "../../L0_Entity/UserManage/clsUsersENEx.js";
import { Users_FilterFunByKey, Users_GetObjLstAsync, Users_GetObjLst_Cache, Users_SortFunByKey } from "../../L3_ForWApi/UserManage/clsUsersWApi.js";
import { GetObjKeys, GetSortExpressInfo, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { Format, IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi } from "../../PubFun/clsSysPara4WebApi.js";
export const usersEx_Controller = "UsersExApi";
export const usersEx_ConstructorName = "usersEx";

/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function UsersEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objUsersENS:源对象
* @returns 目标对象=>clsUsersEN:objUsersENT
**/
export function UsersEx_CopyToEx(objUsersENS: clsUsersEN): clsUsersENEx {
    const strThisFuncName = UsersEx_CopyToEx.name;
    const objUsersENT = new clsUsersENEx();
    try {
        ObjectAssign(objUsersENT, objUsersENS);
        return objUsersENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, usersEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objUsersENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function UsersEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara): Promise<Array<clsUsersENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrUsersObjLst = await Users_GetObjLst_Cache();
    const arrUsersExObjLst = arrUsersObjLst.map(UsersEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrUsersExObjLst) {
            const conFuncMap = await UsersEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrUsersExObjLst.length == 0) return arrUsersExObjLst;
    let arrUsers_Sel: Array<clsUsersENEx> = arrUsersExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objUsers_Cond = new clsUsersENEx();
    ObjectAssign(objUsers_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsUsersWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objUsers_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrUsers_Sel = arrUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrUsers_Sel.length == 0) return arrUsers_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrUsers_Sel = arrUsers_Sel.sort(UsersEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrUsers_Sel = arrUsers_Sel.sort(objPagerPara.sortFun);
        }
        arrUsers_Sel = arrUsers_Sel.slice(intStart, intEnd);
        return arrUsers_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, usersEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsUsersENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function UsersEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsUsersENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrUsersExObjLst = await Users_GetObjLstAsync(objPagerPara.whereCond);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrUsersExObjLst) {
            const conFuncMap = await UsersEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrUsersExObjLst.length == 0) return arrUsersExObjLst;
    let arrUsers_Sel: Array<clsUsersENEx> = arrUsersExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrUsers_Sel = arrUsers_Sel.sort(UsersEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrUsers_Sel = arrUsers_Sel.sort(objPagerPara.sortFun);
        }
        arrUsers_Sel = arrUsers_Sel.slice(intStart, intEnd);
        return arrUsers_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, usersEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsUsersENEx>();
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
export function UsersEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return Users_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return Users_SortFunByKey(strKey, AscOrDesc);
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
export function UsersEx_FuncMapByFldName(strFldName: string, objUsersEx: clsUsersENEx) {
    const strThisFuncName = UsersEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsUsersEN.AttributeName;
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
export async function UsersEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return Users_FilterFunByKey(strKey, value);
    }
}


    /// <summary>
    /// 根据关键字获取相应的记录的对象
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    /// </summary>
    /// <param name = "strUserId">关键字</param>
    /// <returns>获取相应对象</returns>
export async function UsersEx_GetObjByUserIdAsync(strUserId: string): Promise<clsUsersEN> {
        var strAction = "GetObjByUserId";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("userId", strUserId);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    };

    /// <summary>
    /// 根据关键字获取相应的记录的对象
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId)
    /// </summary>
    /// <param name = "strUserId">关键字</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取相应对象</returns>
export async function UsersEx_GetObjByUserId(strUserId: string, cb: (json: any) => void, errorCb: (json: any) => void) {
        var strAction = "GetObjByUserId";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("userId", strUserId);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    };

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>返回的第一条记录的关键字值</returns>
export async function UsersEx_GetFirstIDAsync(strWhereCond: string): Promise<string> {
        var strAction = "GetFirstID";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
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
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    }

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>返回的第一条记录的关键字值</returns>
export async function UsersEx_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) {
        var strAction = "GetFirstID";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    }

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象</returns>
export async function UsersEx_GetFirstObjAsync(strWhereCond: string): Promise<clsUsersEN> {
        var strAction = "GetFirstObj";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
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
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    };

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObj)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取的相应对象</returns>
export async function UsersEx_GetFirstObj(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) {
        var strAction = "GetFirstObj";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    };

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
export async function UsersEx_GetObjLstAsync(strWhereCond: string): Promise<Array<clsUsersEN>> {
        var strAction = "GetObjLst";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
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
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    };

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
export async function UsersEx_GetObjLstByUserIdLstAsync(arrUserId: Array<string>): Promise<Array<clsUsersEN>> {
        var strAction = "GetObjLstByUserIdLst";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: { "": arrUserId },
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    };

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取的相应对象列表</returns>
export async function UsersEx_GetObjLst(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) {
        var strAction = "GetObjLst";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    };

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    /// </summary>
    /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
    /// <returns>获取的相应对象列表</returns>
export async function UsersEx_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsUsersEN>> {
        var strAction = "GetTopObjLst";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = stuTopPara.GetMapParam(objTopPara);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objTopPara,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    };

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLst)
    /// </summary>
    /// <param name = "strWhereCond">给定条件</param>
    /// <param name = "intTopSize">顶部记录数</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取的相应对象列表</returns>
export async function UsersEx_GetTopObjLst(strWhereCond: string, intTopSize: number, cb: (json: any) => void, errorCb: (json: any) => void) {
        var strAction = "GetTopObjLst";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        mapParam.add("intTopSize", intTopSize);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    };

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    /// </summary>
    /// <param name = "objRangePara">根据范围获取对象列表的参数对象</param>
    /// <returns>获取的相应记录对象列表</returns>
export async function UsersEx_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsUsersEN>> {
        var strAction = "GetObjLstByRange";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = stuRangePara.GetMapParam(objRangePara);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objRangePara,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    }

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRange)
    /// </summary>
    /// <param name = "intMinNum">最小记录号</param>
    /// <param name = "intMaxNum">最大记录号</param>
    /// <param name = "strWhereCond">给定条件</param>
    /// <param name = "strOrderBy">排序方式</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取的相应记录对象列表</returns>
export async function UsersEx_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy: string = "", cb: (json: any) => void, errorCb: (json: any) => void) {
        var strAction = "GetObjLstByRange";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("intMinNum", intMinNum);
        mapParam.add("intMaxNum", intMaxNum);
        mapParam.add("strWhereCond", strWhereCond);
        mapParam.add("strOrderBy", strOrderBy);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    }

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    /// </summary>
    /// <param name = "objPagerPara">分页获取对象列表的参数对象</param>
    /// <returns>获取的相应记录对象列表</returns>
export async function UsersEx_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsUsersEN>> {
        var strAction = "GetObjLstByPager";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = stuPagerPara.GetMapParam(objPagerPara);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objPagerPara,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    };

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager)
    /// </summary>
    /// <param name = "intPageIndex">页序号</param>
    /// <param name = "intPageSize">每页记录数</param>
    /// <param name = "strWhereCond">给定条件</param>
    /// <param name = "strOrderBy">排序方式</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取的相应记录对象列表</returns>
export async function UsersEx_GetObjLstByPager(intPageIndex: number, intPageSize: number, strWhereCond: string, strOrderBy: string = "", cb: (json: any) => void, errorCb: (json: any) => void) {
        var strAction = "GetObjLstByPager";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("intPageIndex", intPageIndex);
        mapParam.add("intPageSize", intPageSize);
        mapParam.add("strWhereCond", strWhereCond);
        mapParam.add("strOrderBy", strOrderBy);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    };

    /// <summary>
    /// 调用WebApi来删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    /// </summary>
    /// <param name = "strUserId">关键字</param>
    /// <returns>获取删除的结果</returns>
export async function UsersEx_DelRecordAsync(strUserId: string): Promise<number> {
        var strAction = "DelRecord";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        strUrl = `${strUrl}/${strUserId}`;
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strUserId", strUserId);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "DELETE",
                dataType: "json",
                data: { "": strUserId },
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    };

    /// <summary>
    /// 调用WebApi来删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecord)
    /// </summary>
    /// <param name = "strUserId">关键字</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取删除的结果</returns>
export async function UsersEx_DelRecord(strUserId: string, cb: (json: any) => void, errorCb: (json: any) => void) {
        var strAction = "DelRecord";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        $.ajax({
            url: strUrl,
            method: "DELETE",
            dataType: "json",
            data: { "": strUserId },
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    };

    /// <summary>
    /// 根据关键字列表删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    /// </summary>
    /// <param name = "arrUserId">关键字列表</param>
    /// <returns>实际删除记录的个数</returns>
export async function UsersEx_DelUserssAsync(arrUserId: Array<string>): Promise<number> {
        var strAction = "DelUserss";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: { "": arrUserId },
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    }

    /// <summary>
    /// 根据关键字列表删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecord)
    /// </summary>
    /// <param name = "arrUserId">关键字列表</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>实际删除记录的个数</returns>
export async function UsersEx_DelUserss(arrUserId: Array<string>, cb: (json: any) => void, errorCb: (json: any) => void) {
        var strAction = "DelUserss";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        $.ajax({
            url: strUrl,
            method: "POST",
            dataType: "json",
            data: { "": arrUserId },
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    }

    /// <summary>
    /// 根据条件删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    /// </summary>
    /// <returns>实际删除记录的个数</returns>
export async function UsersEx_DelUserssByCondAsync(strWhereCond: string): Promise<number> {
        var strAction = "DelUserssByCond";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: { "": strWhereCond },
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    }

    /// <summary>
    /// 根据条件删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCond)
    /// </summary>
    /// <returns>实际删除记录的个数</returns>
export async function UsersEx_DelUserssByCond(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) {
        var strAction = "DelUserssByCond";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        $.ajax({
            url: strUrl,
            method: "POST",
            dataType: "json",
            data: { "": strWhereCond },
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    }

    /// <summary>
    /// 调用WebApi来添加记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    /// </summary>
    /// <param name = "objUsersEN">需要添加的对象</param>
    /// <returns>获取相应的记录的对象</returns>
export async function UsersEx_AddNewRecordAsync(objUsersEN: clsUsersEN): Promise<boolean> {
        var strMsg = "";
        var strAction = "AddNewRecord";
        if (objUsersEN.userId === null || objUsersEN.userId === "") {
            strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objUsersEN_Sim);
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objUsersEN,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    };

    /// <summary>
    /// 调用WebApi来添加记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecord)
    /// </summary>
    /// <param name = "objUsersEN">需要添加的对象</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取相应的记录的对象</returns>
export async function UsersEx_AddNewRecord(objUsersEN: clsUsersEN, cb: (json: any) => void, errorCb: (json: any) => void) {
        var strMsg = "";
        var strAction = "AddNewRecord";
        if (objUsersEN.userId === null || objUsersEN.userId === "") {
            strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        
        //var strJSON = JSON.stringify(objUsersEN);
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        $.ajax({
            url: strUrl,
            method: "POST",
            dataType: "json",
            data: objUsersEN,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    };

    /// <summary>
    /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    /// </summary>
    /// <param name = "objUsersEN">需要添加的表对象</param>
    /// <returns>返回新添加记录的关键字</returns>
export async function UsersEx_AddNewRecordWithReturnKeyAsync(objUsersEN: clsUsersEN): Promise<string> {
        var strAction = "AddNewRecordWithReturnKey";
        if (objUsersEN.userId === null || objUsersEN.userId === "") {
            var strMsg = "需要的对象的关键字为空，不能添加!";
            throw new Error(strMsg);
        }
        
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objUsersEN,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    }

    /// <summary>
    /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
    /// </summary>
    /// <param name = "objUsersEN">需要添加的表对象</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>返回新添加记录的关键字</returns>
export async function UsersEx_AddNewRecordWithReturnKey(objUsersEN: clsUsersEN, cb: (json: any) => void, errorCb: (json: any) => void) {
        var strAction = "AddNewRecordWithReturnKey";
        if (objUsersEN.userId === null || objUsersEN.userId === "") {
            var strMsg = "需要的对象的关键字为空，不能添加!";
            throw new Error(strMsg);
        }
        
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        $.ajax({
            url: strUrl,
            method: "POST",
            dataType: "json",
            data: objUsersEN,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    }

    /// <summary>
    /// 调用WebApi来修改记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    /// </summary>
    /// <param name = "objUsersEN">需要添加的对象</param>
    /// <returns>获取修改是否成功？</returns>
export async function UsersEx_UpdateRecordAsync(objUsersEN: clsUsersEN): Promise<boolean> {
        var strMsg = "";
        var strAction = "UpdateRecord";
        if (objUsersEN.sf_UpdFldSetStr === null || objUsersEN.sf_UpdFldSetStr === "") {
            strMsg = `对象(关键字: ${objUsersEN.userId})的【修改字段集】为空，不能修改!`;
            throw strMsg;
        }        
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objUsersEN,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    };

    /// <summary>
    /// 调用WebApi来修改记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecord)
    /// </summary>
    /// <param name = "objUsersEN">需要添加的对象</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取修改是否成功？</returns>
export async function UsersEx_UpdateRecord(objUsersEN: clsUsersEN, cb: (json: any) => void, errorCb: (json: any) => void) {
        var strMsg = "";
        var strAction = "UpdateRecord";
        if (objUsersEN.sf_UpdFldSetStr === null || objUsersEN.sf_UpdFldSetStr === "") {
            strMsg = `对象(关键字: ${objUsersEN.userId})的【修改字段集】为空，不能修改!`;
            throw strMsg;
        }        
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        $.ajax({
            url: strUrl,
            method: "POST",
            dataType: "json",
            data: objUsersEN,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    };

    /// <summary>
    /// 根据条件来修改记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordWithConditionAsync)
    /// </summary>
    /// <param name = "objUsersEN">需要修改的对象</param>
    /// <param name = "strWhereCond">条件串</param>
    /// <returns>返回的第一条记录的关键字值</returns>
export async function UsersEx_UpdateRecordWithConditionAsync(objUsersEN: clsUsersEN, strWhereCond: string): Promise<boolean> {
        var strAction = "UpdateRecordWithCondition";
        if (objUsersEN.sf_UpdFldSetStr === null || objUsersEN.sf_UpdFldSetStr === "") {
            var strMsg = `对象(关键字: ${objUsersEN.userId})的【修改字段集】为空，不能修改!`;
            throw new Error(strMsg);
        }
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    }

    /// <summary>
    /// 根据条件来修改记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordWithCondition)
    /// </summary>
    /// <param name = "objUsersEN">需要修改的对象</param>
    /// <param name = "strWhereCond">条件串</param>
    /// <returns>返回的第一条记录的关键字值</returns>
export async function UsersEx_UpdateRecordWithCondition(objUsersEN: clsUsersEN, strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) {
        var strAction = "UpdateRecordWithCondition";
        if (objUsersEN.sf_UpdFldSetStr === null || objUsersEN.sf_UpdFldSetStr === "") {
            var strMsg = `对象(关键字: ${objUsersEN.userId})的【修改字段集】为空，不能修改!`;
            throw new Error(strMsg);
        }
        
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        $.ajax({
            url: strUrl,
            method: "POST",
            dataType: "json",
            data: {
                objUsersEN: objUsersEN,
                strWhereCond: strWhereCond
            },
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    }

    /// <summary>
    /// 根据条件获取是否存在相应的记录？
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>是否存在记录？</returns>
export async function UsersEx_IsExistRecordAsync(strWhereCond: string): Promise<boolean> {
        var strAction = "IsExistRecord";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
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
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    };

    /// <summary>
    /// 根据条件获取是否存在相应的记录？
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>是否存在记录？</returns>
export async function UsersEx_IsExistRecord(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) {
        var strAction = "IsExistRecord";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    };

    /// <summary>
    /// 根据关键字判断是否存在记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    /// </summary>
    /// <param name = "strUserId">关键字</param>
    /// <returns>是否存在?存在返回True</returns>
export async function UsersEx_IsExistAsync(strUserId: string): Promise<boolean> {
        //检测记录是否存在
        var strAction = "IsExist";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("userId", strUserId);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    }

    /// <summary>
    /// 根据关键字判断是否存在记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
    /// </summary>
    /// <param name = "strUserId">关键字</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>是否存在?存在返回True</returns>
export async function UsersEx_IsExist(strUserId: string, cb: (json: any) => void, errorCb: (json: any) => void) {
        //检测记录是否存在
        var strAction = "IsExist";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("userId", strUserId);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    }

    /// <summary>
    /// 获取某一条件的记录数
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funGetRecCountByCondAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取某一条件的记录数</returns>
export async function UsersEx_GetRecCountByCondAsync(strWhereCond: string): Promise<number> {
        var strAction = "GetRecCountByCond";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
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
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    };

    /// <summary>
    /// 获取某一条件的记录数
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funGetRecCountByCond)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取某一条件的记录数</returns>
export async function UsersEx_GetRecCountByCond(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) {
        var strAction = "GetRecCountByCond";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    };

    /// <summary>
    /// 获取表的最大关键字
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    /// </summary>
    /// <returns>获取表的最大关键字</returns>
export async function UsersEx_GetMaxStrIdAsync(): Promise<string> {
        var strAction = "GetMaxStrId";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    };

    /// <summary>
    /// 获取表的最大关键字
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrId)
    /// </summary>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取表的最大关键字</returns>
export async function UsersEx_GetMaxStrId(cb: (json: any) => void, errorCb: (json: any) => void) {
        var strAction = "GetMaxStrId";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    };

    /// <summary>
    /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefixAsync)
    /// </summary>
    /// <param name = "mapParam">参数列表</param>
    /// <returns>获取当前表关键字值的最大值</returns>
export async function UsersEx_GetMaxStrIdByPrefixAsync(strPrefix: string): Promise<string> {
        var strAction = "GetMaxStrIdByPrefix";
        let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strPrefix", strPrefix);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    console.error(e);
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    };

    /// <summary>
    /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
    /// </summary>
    /// <param name = "mapParam">参数列表</param>
    /// <param name = "cb">CallBack函数，用于显示正确结果数据</param>
    /// <param name = "errorCb">CallBack函数，用于显示错误信息</param>
    /// <returns>获取当前表关键字值的最大值</returns>
export async function UsersEx_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) {
        var strAction = "GetMaxStrIdByPrefix";
    let strUrl = UsersEx_GetWebApiUrl(usersEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strPrefix", strPrefix);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        $.ajax({
            url: strUrl,
            method: "GET",
            dataType: "json",
            data: strData,
            success: function (data) {
                cb(data);
            },
            error: (e) => {
                console.error(e);
                var strErrMsg = decodeURIComponent(e.responseText)
                errorCb(strErrMsg);
            }
        });
    };
