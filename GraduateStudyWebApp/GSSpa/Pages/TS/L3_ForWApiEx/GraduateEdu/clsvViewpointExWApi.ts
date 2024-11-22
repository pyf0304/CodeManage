
import * as $ from "jquery";
//import * as QQ from "q";
import { clsvViewpointEN } from "../../L0_Entity/GraduateEduTopic/clsvViewpointEN.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
var ResponseData: tzResponseData;

import { clsvViewpointENEx } from "../../L0_Entity/GraduateEduTopic/clsvViewpointENEx.js";
import { vViewpoint_FilterFunByKey, vViewpoint_GetObjLstAsync, vViewpoint_GetObjLst_Cache, vViewpoint_SortFunByKey } from "../../L3_ForWApi/GraduateEduTopic/clsvViewpointWApi.js";
import { GetObjKeys, GetSortExpressInfo, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { Format, IsNullOrEmpty } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi } from "../../PubFun/clsSysPara4WebApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
export const vViewpointEx_Controller = "vViewpointExApi";
export const vViewpointEx_ConstructorName = "vViewpointEx";

/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function vViewpointEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objvViewpointENS:源对象
* @returns 目标对象=>clsvViewpointEN:objvViewpointENT
**/
export function vViewpointEx_CopyToEx(objvViewpointENS: clsvViewpointEN): clsvViewpointENEx {
    const strThisFuncName = vViewpointEx_CopyToEx.name;
    const objvViewpointENT = new clsvViewpointENEx();
    try {
        ObjectAssign(objvViewpointENT, objvViewpointENS);
        return objvViewpointENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, vViewpointEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objvViewpointENT;
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function vViewpointEx_GetObjExLstByPager_Cache(objPagerPara: stuPagerPara, strid_CurrEduCls: string): Promise<Array<clsvViewpointENEx>> {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrvViewpointObjLst = await vViewpoint_GetObjLst_Cache(strid_CurrEduCls);
    const arrvViewpointExObjLst = arrvViewpointObjLst.map(vViewpointEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrvViewpointExObjLst) {
            const conFuncMap = await vViewpointEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrvViewpointExObjLst.length == 0) return arrvViewpointExObjLst;
    let arrvViewpoint_Sel: Array<clsvViewpointENEx> = arrvViewpointExObjLst;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objvViewpoint_Cond = new clsvViewpointENEx();
    ObjectAssign(objvViewpoint_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsvViewpointWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objvViewpoint_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.split(',');
                        arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrvViewpoint_Sel = arrvViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrvViewpoint_Sel.length == 0) return arrvViewpoint_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrvViewpoint_Sel = arrvViewpoint_Sel.sort(vViewpointEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrvViewpoint_Sel = arrvViewpoint_Sel.sort(objPagerPara.sortFun);
        }
        arrvViewpoint_Sel = arrvViewpoint_Sel.slice(intStart, intEnd);
        return arrvViewpoint_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vViewpointEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsvViewpointENEx>();
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function vViewpointEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvViewpointENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrvViewpointExObjLst = await vViewpoint_GetObjLstAsync(objPagerPara.whereCond);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrvViewpointExObjLst) {
            const conFuncMap = await vViewpointEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrvViewpointExObjLst.length == 0) return arrvViewpointExObjLst;
    let arrvViewpoint_Sel: Array<clsvViewpointENEx> = arrvViewpointExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrvViewpoint_Sel = arrvViewpoint_Sel.sort(vViewpointEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrvViewpoint_Sel = arrvViewpoint_Sel.sort(objPagerPara.sortFun);
        }
        arrvViewpoint_Sel = arrvViewpoint_Sel.slice(intStart, intEnd);
        return arrvViewpoint_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vViewpointEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsvViewpointENEx>();
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
export function vViewpointEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return vViewpoint_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return vViewpoint_SortFunByKey(strKey, AscOrDesc);
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
export function vViewpointEx_FuncMapByFldName(strFldName: string, objvViewpointEx: clsvViewpointENEx) {
    const strThisFuncName = vViewpointEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsvViewpointEN.AttributeName;
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
export async function vViewpointEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return vViewpoint_FilterFunByKey(strKey, value);
    }
}

//public static cacheModeId = "02"; //客户端缓存

///// <summary>
//    /// 获取论文中的用户数量
//    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
//    /// </summary>
//    /// <param name = "strWhereCond">条件</param>
//    /// <returns>获取的相应对象列表</returns>
//    public static GetViewpointUserObjLstAsync(strWhereCond: string): Promise<Array<clsvViewpointEN>> {
//        var strAction = "GetViewpointUserObjLst";
//        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
//        var mapParam: Dictionary = new Dictionary();
//        mapParam.add("strWhereCond", strWhereCond);
//        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
//        return new Promise(function (resolve, reject) {
//            $.ajax({
//                url: strUrl,
//                method: "GET",
//                dataType: "json",
//                data: strData,
//                success: function (data) {
//                    if (data.ErrorId == 0) {
//                        var returnObjLst = JSON.parse(data.ReturnObjLst);
//                        //console.log(returnObjLst);
//                        resolve(returnObjLst);
//                    }
//                    else {
//                        console.log(data.ErrorMsg);
//                        reject(data.ErrorMsg);
//                    }
//                },
//                error: (e) => {
//                    console.error(e);
//                    var strErrMsg = decodeURIComponent(e.responseText)
//                    reject(e);
//                }
//            });
//        });
//    };


    ////从观点表表中得到专家观点用户数据
    ///// <summary>
    ///// 绑定基于Web的下拉框
    ///// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    ///// </summary>
    ///// <param name = "objDDL">需要绑定当前表的下拉框</param>
    //public static async BindDdl_UserIdInvExpertviewpoint_Cache(strDdlName: string, objUsers_Cond: clsUsersEN) {
    //    var objDdl = document.getElementById(strDdlName);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${strDdlName} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    //为数据源于表的下拉框设置内容
    //    console.log("开始：BindDdl_UserIdInvConcept_Cache");
    //    var arrvConcept: Array<clsvViewpointEN> = await vViewpoint_GetObjLstAsync("1=1");

    //    //获取个人观点数据；

    //    var arrvViewpoint: Array<clsvViewpointEN> = new Array<clsvViewpointEN>();
    //    arrvViewpoint = arrvConcept.filter(x => x.userTypeId == "02");//专家观点；


    //    var arrObjLst_Sel: Array<clsUsersEN> = arrvViewpoint.map(vViewpointEx_GetUsersByvViewpoint);
    //    arrObjLst_Sel = clsvViewpointExWApi.uniq(arrObjLst_Sel);
    //    console.log(arrObjLst_Sel);
    //    arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsUsersEN.con_UserName]);
    //    clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsUsersEN.con_UserId, clsUsersEN.con_UserName, "编辑用户");
    //}




    ////从观点表表中得到个人观点用户数据
    ///// <summary>
    ///// 绑定基于Web的下拉框
    ///// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
    ///// </summary>
    ///// <param name = "objDDL">需要绑定当前表的下拉框</param>
    //public static async BindDdl_UserIdInvViewpoint_Cache(strDdlName: string, objUsers_Cond: clsUsersEN) {
    //    var objDdl = document.getElementById(strDdlName);
    //    if (objDdl == null) {
    //        var strMsg = `下拉框：${strDdlName} 不存在！`;
    //        alert(strMsg);
    //        throw (strMsg);
    //    }
    //    //为数据源于表的下拉框设置内容
    //    console.log("开始：BindDdl_UserIdInvConcept_Cache");
    //    var arrvConcept: Array<clsvViewpointEN> = await vViewpoint_GetObjLstAsync("1=1");

    //    //获取个人观点数据；

    //    var arrvViewpoint: Array<clsvViewpointEN> = new Array<clsvViewpointEN>();
    //    arrvViewpoint = arrvConcept.filter(x => x.userTypeId == "01");//个人观点；


    //    var arrObjLst_Sel: Array<clsUsersEN> = arrvViewpoint.map(vViewpointEx_GetUsersByvViewpoint);
    //    arrObjLst_Sel = clsvViewpointExWApi.uniq(arrObjLst_Sel);
    //    console.log(arrObjLst_Sel);
    //    arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsUsersEN.con_UserName]);
    //    clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsUsersEN.con_UserId, clsUsersEN.con_UserName, "编辑用户");
    //}
    //public static uniq(arr: Array<clsUsersEN>): Array<clsUsersEN> {
    //    let arrObjLst_New: Array<clsUsersEN> = new Array<clsUsersEN>();
    //    for (let x of arr) {
    //        if (vViewpointEx_IsExist(arrObjLst_New, x) == false) {
    //            arrObjLst_New.push(x);
    //        }
    //    }
    //    return arrObjLst_New;
    //}

    //public static IsExist(arr: Array<clsUsersEN>, key: clsUsersEN) {
    //    let arr_Sel = arr.filter(x => x.userId == key.userId);
    //    if (arr_Sel.length > 0) return true;
    //    return false;
    //}


    //public static GetUsersByvViewpoint(objvViewpoint: clsvViewpointEN): clsUsersEN {
    //    var objUsers: clsUsersEN = new clsUsersEN();
    //    objUsers.userId = objvViewpoint.updUser;
    //    objUsers.userName = objvViewpoint.userName;
    //    return objUsers;
    //}




    /// <summary>
    /// 获取各个观点中的pdf页码数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
export async function vViewpointEx_GetAllVNumObjLstAsync(strPaperId: string): Promise<Array<clsvViewpointEN>> {
        var strAction = "GetAllVNumObjLst";
    let strUrl = vViewpointEx_GetWebApiUrl(vViewpointEx_Controller, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strPaperId", strPaperId);
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

