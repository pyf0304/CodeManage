
/**
* 类名:clsvPaperSimProWApi
* 表名:vPaperSimPro(01120944)
* 版本:2023.01.09.1(服务器:WIN-SRV103-116)
* 日期:2023/01/10 11:37:36
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培论文(GraduateEduPaper)
* 框架-层名:WA_访问层(TS)(WA_Access)
* 编程语言:TypeScript
* 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
  *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
**/

/**
 * vPaperSimPro(vPaperSimPro)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年01月10日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";

import { LocalStorage_GetKeyByPrefix } from "../../PubFun/CacheHelper.js";
import { SessionStorage_GetKeyByPrefix } from "../../PubFun/CacheHelper.js";
import { clsvPaperSimProEN } from "../../L0_Entity/GraduateEduPaper/clsvPaperSimProEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

export const vPaperSimPro_Controller = "vPaperSimProApi";
export const vPaperSimPro_ConstructorName = "vPaperSimPro";

/**
* 根据关键字获取相应记录的对象
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
* @param strPaperId:关键字
* @returns 对象
**/
export async function vPaperSimPro_GetObjByPaperIdAsync(strPaperId: string): Promise<clsvPaperSimProEN | null> {
    const strThisFuncName = "GetObjByPaperIdAsync";

    if (IsNullOrEmpty(strPaperId) == true) {
        const strMsg = Format("参数:[strPaperId]不能为空！(In GetObjByPaperIdAsync)");
        console.error(strMsg);
        throw (strMsg);
    }
    if (strPaperId.length != 8) {
        const strMsg = Format("缓存分类变量:[strPaperId]的长度:[{0}]不正确！", strPaperId.length);
        console.error(strMsg);
        throw (strMsg);
    }
    const strAction = "GetObjByPaperId";
    const strUrl = GetWebApiUrl(vPaperSimPro_Controller, strAction);
    try {
        const response = await axios.get(strUrl,
            {
                params: {
                    "strPaperId": strPaperId,
                }
            });
        const data = response.data;
        if (data.errorId == 0) {
            const returnObj = data.returnObj;
            if (returnObj == null) {
                return null;
            }
            //console.log(returnObj);
            const objvPaperSimPro = vPaperSimPro_GetObjFromJsonObj(returnObj);
            return objvPaperSimPro;
        }
        else {
            console.error(data.errorMsg);
            throw (data.errorMsg);
        }
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

/**
 * 根据关键字获取相关对象, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
 * @param strPaperId:所给的关键字
 * @returns 对象
*/
export async function vPaperSimPro_GetObjByPaperId_Cache(strPaperId: string, strid_CurrEduCls: string, bolTryAsyncOnce: boolean = true) {
    const strThisFuncName = "GetObjByPaperId_Cache";

    if (IsNullOrEmpty(strPaperId) == true) {
        const strMsg = Format("参数:[strPaperId]不能为空！(In GetObjByPaperId_Cache)");
        console.error(strMsg);
        throw (strMsg);
    }
    if (strPaperId.length != 8) {
        const strMsg = Format("缓存分类变量:[strPaperId]的长度:[{0}]不正确！", strPaperId.length);
        console.error(strMsg);
        throw (strMsg);
    }
    const arrvPaperSimProObjLst_Cache = await vPaperSimPro_GetObjLst_Cache(strid_CurrEduCls);
    try {
        const arrvPaperSimPro_Sel: Array<clsvPaperSimProEN> = arrvPaperSimProObjLst_Cache.filter(x =>
            x.paperId == strPaperId);
        let objvPaperSimPro: clsvPaperSimProEN;
        if (arrvPaperSimPro_Sel.length > 0) {
            objvPaperSimPro = arrvPaperSimPro_Sel[0];
            return objvPaperSimPro;
        }
        else {
            if (bolTryAsyncOnce == true) {
                const objvPaperSimPro_Const = await vPaperSimPro_GetObjByPaperIdAsync(strPaperId);
                if (objvPaperSimPro_Const != null) {
                    vPaperSimPro_ReFreshThisCache(strid_CurrEduCls);
                    return objvPaperSimPro_Const;
                }
            }
            return null;
        }
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPaperId, vPaperSimPro_ConstructorName, strThisFuncName);
        console.error(strMsg);
    }
    return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strPaperId:所给的关键字
 * @returns 对象
*/
export async function vPaperSimPro_GetObjByPaperId_localStorage(strPaperId: string) {
    const strThisFuncName = "GetObjByPaperId_localStorage";

    if (IsNullOrEmpty(strPaperId) == true) {
        const strMsg = Format("参数:[strPaperId]不能为空！(In GetObjByPaperId_localStorage)");
        console.error(strMsg);
        throw (strMsg);
    }
    if (strPaperId.length != 8) {
        const strMsg = Format("缓存分类变量:[strPaperId]的长度:[{0}]不正确！", strPaperId.length);
        console.error(strMsg);
        throw (strMsg);
    }
    const strKey = Format("{0}_{1}", clsvPaperSimProEN._CurrTabName, strPaperId);
    if (strKey == "") {
        console.error("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
        //缓存存在，直接返回
        const strTempObj = localStorage.getItem(strKey) as string;
        const objvPaperSimPro_Cache: clsvPaperSimProEN = JSON.parse(strTempObj);
        return objvPaperSimPro_Cache;
    }
    try {
        const objvPaperSimPro = await vPaperSimPro_GetObjByPaperIdAsync(strPaperId);
        if (objvPaperSimPro != null) {
            localStorage.setItem(strKey, JSON.stringify(objvPaperSimPro));
            const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
            console.log(strInfo);
            return objvPaperSimPro;
        }
        return objvPaperSimPro;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPaperId, vPaperSimPro_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return;
    }
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strPaperId:所给的关键字
 * @returns 对象
*/
export async function vPaperSimPro_GetNameByPaperId_Cache(strPaperId: string, strid_CurrEduCls: string) {
    const strThisFuncName = "GetNameByPaperId_Cache";

    if (IsNullOrEmpty(strPaperId) == true) {
        const strMsg = Format("参数:[strPaperId]不能为空！(In GetNameByPaperId_Cache)");
        console.error(strMsg);
        throw (strMsg);
    }
    if (strPaperId.length != 8) {
        const strMsg = Format("缓存分类变量:[strPaperId]的长度:[{0}]不正确！", strPaperId.length);
        console.error(strMsg);
        throw (strMsg);
    }
    const arrvPaperSimProObjLst_Cache = await vPaperSimPro_GetObjLst_Cache(strid_CurrEduCls);
    if (arrvPaperSimProObjLst_Cache == null) return "";
    try {
        const arrvPaperSimPro_Sel: Array<clsvPaperSimProEN> = arrvPaperSimProObjLst_Cache.filter(x =>
            x.paperId == strPaperId);
        let objvPaperSimPro: clsvPaperSimProEN;
        if (arrvPaperSimPro_Sel.length > 0) {
            objvPaperSimPro = arrvPaperSimPro_Sel[0];
            return objvPaperSimPro.paperTitle;
        }
        else {
            return "";
        }
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strPaperId);
        console.error(strMsg);
        alert(strMsg);
    }
    return "";
}

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-01-10
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function vPaperSimPro_func(strInFldName: string, strOutFldName: string, strInValue: string
    , strid_CurrEduCls_C: string) {
    //const strThisFuncName = "func";

    if (IsNullOrEmpty(strid_CurrEduCls_C) == true) {
        const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In func)");
        console.error(strMsg);
        throw (strMsg);
    }
    if (strid_CurrEduCls_C.length != 8) {
        const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！", strid_CurrEduCls_C.length);
        console.error(strMsg);
        throw (strMsg);
    }

    if (strInFldName != clsvPaperSimProEN.con_PaperId) {
        const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    if (clsvPaperSimProEN.AttributeName.indexOf(strOutFldName) == -1) {
        const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
            strOutFldName, clsvPaperSimProEN.AttributeName.join(','));
        console.error(strMsg);
        throw new Error(strMsg);
    }
    const strPaperId = strInValue;
    if (IsNullOrEmpty(strInValue) == true) {
        return "";
    }
    const objvPaperSimPro = await vPaperSimPro_GetObjByPaperId_Cache(strPaperId, strid_CurrEduCls_C);
    if (objvPaperSimPro == null) return "";
    return objvPaperSimPro.GetFldValue(strOutFldName).toString();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-01-10
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vPaperSimPro_SortFun_Defa(a: clsvPaperSimProEN, b: clsvPaperSimProEN): number {
    const strThisFuncName = "SortFun_Defa";
    return a.paperId.localeCompare(b.paperId);
}
/**
 * 排序函数。根据表对象中随机两个字段的值进行比较
 * 作者:pyf
 * 日期:2023-01-10
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param  a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vPaperSimPro_SortFun_Defa_2Fld(a: clsvPaperSimProEN, b: clsvPaperSimProEN): number {
    const strThisFuncName = "SortFun_Defa_2Fld";
    if (a.paperTitle == b.paperTitle) return a.paperTitle.localeCompare(b.paperTitle);
    else return a.paperTitle.localeCompare(b.paperTitle);
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-01-10
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vPaperSimPro_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    let strMsg = "";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            case clsvPaperSimProEN.con_PaperId:
                return (a: clsvPaperSimProEN, b: clsvPaperSimProEN) => {
                    return a.paperId.localeCompare(b.paperId);
                }
            case clsvPaperSimProEN.con_PaperTitle:
                return (a: clsvPaperSimProEN, b: clsvPaperSimProEN) => {
                    return a.paperTitle.localeCompare(b.paperTitle);
                }

            case clsvPaperSimProEN.con_PaperContent:
                return (a: clsvPaperSimProEN, b: clsvPaperSimProEN) => {
                    return a.paperContent.localeCompare(b.paperContent);
                }
            case clsvPaperSimProEN.con_Periodical:
                return (a: clsvPaperSimProEN, b: clsvPaperSimProEN) => {
                    return a.periodical.localeCompare(b.periodical);
                }
            case clsvPaperSimProEN.con_Author:
                return (a: clsvPaperSimProEN, b: clsvPaperSimProEN) => {
                    return a.author.localeCompare(b.author);
                }
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vPaperSimPro]中不存在！(in ${vPaperSimPro_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    else {
        switch (strKey) {
            case clsvPaperSimProEN.con_PaperId:
                return (a: clsvPaperSimProEN, b: clsvPaperSimProEN) => {
                    return b.paperId.localeCompare(a.paperId);
                }
            case clsvPaperSimProEN.con_PaperTitle:
                return (a: clsvPaperSimProEN, b: clsvPaperSimProEN) => {
                    return b.paperTitle.localeCompare(a.paperTitle);
                }

            case clsvPaperSimProEN.con_PaperContent:
                return (a: clsvPaperSimProEN, b: clsvPaperSimProEN) => {
                    return b.paperContent.localeCompare(a.paperContent);
                }
            case clsvPaperSimProEN.con_Periodical:
                return (a: clsvPaperSimProEN, b: clsvPaperSimProEN) => {
                    return b.periodical.localeCompare(a.periodical);
                }
            case clsvPaperSimProEN.con_Author:
                return (a: clsvPaperSimProEN, b: clsvPaperSimProEN) => {
                    return b.author.localeCompare(a.author);
                }
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vPaperSimPro]中不存在！(in ${vPaperSimPro_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
}

/**
 * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
 * 作者:pyf
 * 日期:2023-01-10
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function vPaperSimPro_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        case clsvPaperSimProEN.con_PaperId:
            return (obj: clsvPaperSimProEN) => {
                return obj.paperId === value;
            }
        case clsvPaperSimProEN.con_PaperTitle:
            return (obj: clsvPaperSimProEN) => {
                return obj.paperTitle === value;
            }
        case clsvPaperSimProEN.con_PaperContent:
            return (obj: clsvPaperSimProEN) => {
                return obj.paperContent === value;
            }
        case clsvPaperSimProEN.con_Periodical:
            return (obj: clsvPaperSimProEN) => {
                return obj.periodical === value;
            }
        case clsvPaperSimProEN.con_Author:
            return (obj: clsvPaperSimProEN) => {
                return obj.author === value;
            }
        default:
            strMsg = `字段名:[${strKey}]在表对象:[vPaperSimPro]中不存在！(in ${vPaperSimPro_ConstructorName}.${strThisFuncName})`;
            console.error(strMsg);
            break;
    }
}

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-01-10
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
 * @param strInFldName:输入字段名
 * @param strInValue:输入字段值
 * @param strComparisonOp:比较操作符
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个关键字值列表
*/
export async function vPaperSimPro_funcKey(strInFldName: string, strInValue: any, strComparisonOp: string, strid_CurrEduCls_C: string): Promise<Array<string>> {
    //const strThisFuncName = "funcKey";

    if (IsNullOrEmpty(strid_CurrEduCls_C) == true) {
        const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In funcKey)");
        console.error(strMsg);
        throw (strMsg);
    }
    if (strid_CurrEduCls_C.length != 8) {
        const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！", strid_CurrEduCls_C.length);
        console.error(strMsg);
        throw (strMsg);
    }

    if (strInFldName == clsvPaperSimProEN.con_PaperId) {
        const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    if (IsNullOrEmpty(strInValue) == true) {
        return [];
    }
    const arrvPaperSimPro = await vPaperSimPro_GetObjLst_Cache(strid_CurrEduCls_C);
    if (arrvPaperSimPro == null) return [];
    let arrvPaperSimPro_Sel = arrvPaperSimPro;
    const strType = typeof (strInValue);
    switch (strType) {
        case "string":
            switch (strComparisonOp) {
                case enumComparisonOp.Equal_01: // " = "
                    arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                    break;
                case enumComparisonOp.Like_03:
                    arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                    break;
                case enumComparisonOp.In_04:
                    const arrValues = strInValue.split(',');
                    arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                    break;
            }
            break;
        case "boolean":
            if (strInValue == null) return [];
            if (strComparisonOp == enumComparisonOp.Equal_01) {
                arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
            }
            break;
        case "number":
            if (Number(strInValue) == 0) return [];
            switch (strComparisonOp) {
                case enumComparisonOp.Equal_01:
                    arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                    break;
                case enumComparisonOp.NotEqual_02:
                    arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                    break;
                case enumComparisonOp.NotLessThan_05://" >= ":
                    arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                    break;
                case enumComparisonOp.NotGreaterThan_06://" <= ":
                    arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                    break;
                case enumComparisonOp.GreaterThan_07://" > ":
                    arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                    break;
                case enumComparisonOp.LessThan_08://" < ":
                    arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                    break;
            }
            break;
    }
    if (arrvPaperSimPro_Sel.length == 0) return [];
    return arrvPaperSimPro_Sel.map(x => x.paperId);
}

/**
* 根据条件获取满足条件的第一条记录
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
* @param strWhereCond:条件
* @returns 返回的第一条记录的关键字值
**/
export async function vPaperSimPro_GetFirstIDAsync(strWhereCond: string): Promise<string> {
    const strThisFuncName = "GetFirstIDAsync";
    const strAction = "GetFirstID";
    const strUrl = GetWebApiUrl(vPaperSimPro_Controller, strAction);
    try {
        const response = await axios.get(strUrl,
            {
                params: { "strWhereCond": strWhereCond }
            });
        const data = response.data;
        if (data.errorId == 0) {
            return data.returnStr;
        }
        else {
            console.error(data.errorMsg);
            throw (data.errorMsg);
        }
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

/**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
 * @param strWhereCond:条件
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回的第一条记录的关键字值
*/
export async function vPaperSimPro_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) {
    const strThisFuncName = "GetFirstID";
    const strAction = "GetFirstID";
    const strUrl = GetWebApiUrl(vPaperSimPro_Controller, strAction);
    try {
        const response = await axios.get(strUrl,
            {
                params: { "strWhereCond": strWhereCond }
            });
        const data = response.data;
        cb(data);
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

/**
* 根据条件获取满足条件的第一条记录对象
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
* @param strWhereCond:条件
* @returns 第一条记录对象
**/
export async function vPaperSimPro_GetFirstObjAsync(strWhereCond: string): Promise<clsvPaperSimProEN | null> {
    const strThisFuncName = "GetFirstObjAsync";
    const strAction = "GetFirstObj";
    const strUrl = GetWebApiUrl(vPaperSimPro_Controller, strAction);
    try {
        const response = await axios.get(strUrl,
            {
                params: { "strWhereCond": strWhereCond }
            });
        const data = response.data;
        if (data.errorId == 0) {
            const returnObj = data.returnObj;
            if (returnObj == null) {
                return null;
            }
            //console.log(returnObj);
            const objvPaperSimPro = vPaperSimPro_GetObjFromJsonObj(returnObj);
            return objvPaperSimPro;
        }
        else {
            console.error(data.errorMsg);
            throw (data.errorMsg);
        }
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

/**
* 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
* @returns 从本地缓存中获取的对象列表
**/
export async function vPaperSimPro_GetObjLst_ClientCache(strid_CurrEduCls: string) {
    const strThisFuncName = "GetObjLst_ClientCache";
    //初始化列表缓存
    let strWhereCond = "1=1";
    strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
    const strKey = Format("{0}_{1}", clsvPaperSimProEN._CurrTabName, strid_CurrEduCls);
        if (IsNullOrEmpty(clsvPaperSimProEN.CacheAddiCondition) == false) {
        strWhereCond += Format(" and {0}", clsvPaperSimProEN.CacheAddiCondition);
    }
    if (strKey == "") {
        console.error("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (CacheHelper.Exsits(strKey)) {
        //缓存存在，直接返回
        const arrvPaperSimProExObjLst_Cache: Array<clsvPaperSimProEN> = CacheHelper.Get(strKey);
        const arrvPaperSimProObjLst_T = vPaperSimPro_GetObjLstByJSONObjLst(arrvPaperSimProExObjLst_Cache);
        return arrvPaperSimProObjLst_T;
    }
    try {
        const arrvPaperSimProExObjLst = await vPaperSimPro_GetObjLstAsync(strWhereCond);
        CacheHelper.Add(strKey, arrvPaperSimProExObjLst);
        const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSimProExObjLst.length);
        console.log(strInfo);
        return arrvPaperSimProExObjLst;
    }
    catch (e) {
        const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaperSimPro_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw (strMsg);
    }
}

/**
* 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
* @returns 从本地缓存中获取的对象列表
**/
export async function vPaperSimPro_GetObjLst_localStorage(strid_CurrEduCls: string) {
    const strThisFuncName = "GetObjLst_localStorage";
    //初始化列表缓存
    let strWhereCond = "1=1";
    if (IsNullOrEmpty(clsvPaperSimProEN.WhereFormat) == false) {
        strWhereCond = Format(clsvPaperSimProEN.WhereFormat, strid_CurrEduCls);
    }
    else {
        strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
    }
    const strKey = Format("{0}_{1}", clsvPaperSimProEN._CurrTabName, strid_CurrEduCls);
    if (IsNullOrEmpty(clsvPaperSimProEN.CacheAddiCondition) == false) {
        strWhereCond += Format(" and {0}", clsvPaperSimProEN.CacheAddiCondition);
    }
    if (strKey == "") {
        console.error("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
        //缓存存在，直接返回
        const strTempObjLst: string = localStorage.getItem(strKey) as string;
        const arrvPaperSimProExObjLst_Cache: Array<clsvPaperSimProEN> = JSON.parse(strTempObjLst);
        const arrvPaperSimProObjLst_T = vPaperSimPro_GetObjLstByJSONObjLst(arrvPaperSimProExObjLst_Cache);
        return arrvPaperSimProObjLst_T;
    }
    try {
        const arrvPaperSimProExObjLst = await vPaperSimPro_GetObjLstAsync(strWhereCond);
        const strPrefix = Format("{0}_", clsvPaperSimProEN._CurrTabName);
        const arrCacheKeyLst = LocalStorage_GetKeyByPrefix(strPrefix);
        arrCacheKeyLst.forEach(x => localStorage.removeItem(x));
        localStorage.setItem(strKey, JSON.stringify(arrvPaperSimProExObjLst));
        const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSimProExObjLst.length);
        console.log(strInfo);
        return arrvPaperSimProExObjLst;
    }
    catch (e) {
        const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaperSimPro_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw (strMsg);
    }
}

/**
* 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
* @returns 从本地缓存中获取的对象列表
**/
export async function vPaperSimPro_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string) {
    const strThisFuncName = "GetObjLst_localStorage_PureCache";
    //初始化列表缓存
    let strWhereCond = "1=1";
    strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
    const strKey = Format("{0}_{1}", clsvPaperSimProEN._CurrTabName, strid_CurrEduCls);
    if (strKey == "") {
        console.error("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
        //缓存存在，直接返回
        const strTempObjLst: string = localStorage.getItem(strKey) as string;
        const arrvPaperSimProObjLst_Cache: Array<clsvPaperSimProEN> = JSON.parse(strTempObjLst);
        return arrvPaperSimProObjLst_Cache;
    }
    else return null;
}

/**
* 根据条件获取相应的记录对象列表
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
* @param strWhereCond:条件
* @returns 获取的相应对象列表
**/
export async function vPaperSimPro_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvPaperSimProEN>> {
    const strThisFuncName = "GetObjLstAsync";
    const strAction = "GetObjLst";
    const strUrl = GetWebApiUrl(vPaperSimPro_Controller, strAction);
    try {
        const response = await axios.get(strUrl,
            {
                params: { "strWhereCond": strWhereCond }
            });
        const data = response.data;
        if (data.errorId == 0) {
            const returnObjLst = data.returnObjLst;
            if (returnObjLst == null) {
                const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSimPro_ConstructorName, strThisFuncName);
                console.error(strNullInfo);
                throw (strNullInfo);
            }
            //console.log(returnObjLst);
            const arrObjLst = vPaperSimPro_GetObjLstByJSONObjLst(returnObjLst);
            return (arrObjLst);
        }
        else {
            console.error(data.errorMsg);
            throw (data.errorMsg);
        }
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

/**
* 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
* @returns 从本地缓存中获取的对象列表
**/
export async function vPaperSimPro_GetObjLst_sessionStorage(strid_CurrEduCls: string) {
    const strThisFuncName = "GetObjLst_sessionStorage";
    //初始化列表缓存
    let strWhereCond = "1=1";
    strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
    const strKey = Format("{0}_{1}", clsvPaperSimProEN._CurrTabName, strid_CurrEduCls);
    if (IsNullOrEmpty(clsvPaperSimProEN.CacheAddiCondition) == false) {
        strWhereCond += Format(" and {0}", clsvPaperSimProEN.CacheAddiCondition);
    }
    if (strKey == "") {
        console.error("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
        //缓存存在，直接返回
        const strTempObjLst: string = sessionStorage.getItem(strKey) as string;
        const arrvPaperSimProExObjLst_Cache: Array<clsvPaperSimProEN> = JSON.parse(strTempObjLst);
        const arrvPaperSimProObjLst_T = vPaperSimPro_GetObjLstByJSONObjLst(arrvPaperSimProExObjLst_Cache);
        return arrvPaperSimProObjLst_T;
    }
    try {
        const arrvPaperSimProExObjLst = await vPaperSimPro_GetObjLstAsync(strWhereCond);
        const strPrefix = Format("{0}_", clsvPaperSimProEN._CurrTabName);
        const arrCacheKeyLst = SessionStorage_GetKeyByPrefix(strPrefix);
        arrCacheKeyLst.forEach(x => sessionStorage.removeItem(x));
        sessionStorage.setItem(strKey, JSON.stringify(arrvPaperSimProExObjLst));
        const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSimProExObjLst.length);
        console.log(strInfo);
        return arrvPaperSimProExObjLst;
    }
    catch (e) {
        const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaperSimPro_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw (strMsg);
    }
}

/**
* 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
* @returns 从本地缓存中获取的对象列表
**/
export async function vPaperSimPro_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string) {
    const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
    //初始化列表缓存
    let strWhereCond = "1=1";
    strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
    const strKey = Format("{0}_{1}", clsvPaperSimProEN._CurrTabName, strid_CurrEduCls);
    if (strKey == "") {
        console.error("关键字为空！不正确");
        throw new Error("关键字为空！不正确");
    }
    if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
        //缓存存在，直接返回
        const strTempObjLst: string = sessionStorage.getItem(strKey) as string;
        const arrvPaperSimProObjLst_Cache: Array<clsvPaperSimProEN> = JSON.parse(strTempObjLst);
        return arrvPaperSimProObjLst_Cache;
    }
    else return null;
}

/**
* 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
* @returns 从本地缓存中获取的对象列表
**/
export async function vPaperSimPro_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsvPaperSimProEN>> {
    //const strThisFuncName = "GetObjLst_Cache";

    if (IsNullOrEmpty(strid_CurrEduCls) == true) {
        const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！");
        console.error(strMsg);
        throw (strMsg);
    }
    if (strid_CurrEduCls.length != 8) {
        const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
        console.error(strMsg);
        throw (strMsg);
    }
    let arrvPaperSimProObjLst_Cache;
    switch (clsvPaperSimProEN.CacheModeId) {
        case "04"://sessionStorage
            arrvPaperSimProObjLst_Cache = await vPaperSimPro_GetObjLst_sessionStorage(strid_CurrEduCls);
            break;
        case "03"://localStorage
            arrvPaperSimProObjLst_Cache = await vPaperSimPro_GetObjLst_localStorage(strid_CurrEduCls);
            break;
        case "02"://ClientCache
            arrvPaperSimProObjLst_Cache = await vPaperSimPro_GetObjLst_ClientCache(strid_CurrEduCls);
            break;
        default:
            arrvPaperSimProObjLst_Cache = await vPaperSimPro_GetObjLst_ClientCache(strid_CurrEduCls);
            break;
    }
    const arrvPaperSimProObjLst = vPaperSimPro_GetObjLstByJSONObjLst(arrvPaperSimProObjLst_Cache);
    return arrvPaperSimProObjLst_Cache;
}

/**
* 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
* @returns 从本地缓存中获取的对象列表
**/
export async function vPaperSimPro_GetObjLst_PureCache(strid_CurrEduCls: string) {
    //const strThisFuncName = "GetObjLst_PureCache";
    let arrvPaperSimProObjLst_Cache;
    switch (clsvPaperSimProEN.CacheModeId) {
        case "04"://sessionStorage
            arrvPaperSimProObjLst_Cache = await vPaperSimPro_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
            break;
        case "03"://localStorage
            arrvPaperSimProObjLst_Cache = await vPaperSimPro_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
            break;
        case "02"://ClientCache
            arrvPaperSimProObjLst_Cache = null;
            break;
        default:
            arrvPaperSimProObjLst_Cache = null;
            break;
    }
    return arrvPaperSimProObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrPaperId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vPaperSimPro_GetSubObjLst_Cache(objvPaperSimPro_Cond: clsvPaperSimProEN, strid_CurrEduCls: string) {
    const strThisFuncName = "GetSubObjLst_Cache";
    const arrvPaperSimProObjLst_Cache = await vPaperSimPro_GetObjLst_Cache(strid_CurrEduCls);
    let arrvPaperSimPro_Sel: Array<clsvPaperSimProEN> = arrvPaperSimProObjLst_Cache;
    if (objvPaperSimPro_Cond.sf_FldComparisonOp == null || objvPaperSimPro_Cond.sf_FldComparisonOp == "") return arrvPaperSimPro_Sel;
    const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaperSimPro_Cond.sf_FldComparisonOp);
    //console.log("clsvPaperSimProWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(objvPaperSimPro_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objvPaperSimPro_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        return arrvPaperSimPro_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvPaperSimPro_Cond), vPaperSimPro_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsvPaperSimProEN>();
}

/**
* 根据关键字列表获取相关对象列表
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
* @param arrPaperId:关键字列表
* @returns 对象列表
**/
export async function vPaperSimPro_GetObjLstByPaperIdLstAsync(arrPaperId: Array<string>): Promise<Array<clsvPaperSimProEN>> {
    const strThisFuncName = "GetObjLstByPaperIdLstAsync";
    const strAction = "GetObjLstByPaperIdLst";
    const strUrl = GetWebApiUrl(vPaperSimPro_Controller, strAction);
    try {
        const response = await axios.post(strUrl, arrPaperId);
        const data = response.data;
        if (data.errorId == 0) {
            const returnObjLst = data.returnObjLst;
            if (returnObjLst == null) {
                const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSimPro_ConstructorName, strThisFuncName);
                console.error(strNullInfo);
                throw (strNullInfo);
            }
            //console.log(returnObjLst);
            const arrObjLst = vPaperSimPro_GetObjLstByJSONObjLst(returnObjLst);
            return arrObjLst;
        }
        else {
            console.error(data.errorMsg);
            throw (data.errorMsg);
        }
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

/**
 * 根据关键字列表获取相关对象列表, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
 * @param arrstrPaperIdLst:关键字列表
 * @returns 对象列表
*/
export async function vPaperSimPro_GetObjLstByPaperIdLst_Cache(arrPaperIdLst: Array<string>, strid_CurrEduCls: string) {
    const strThisFuncName = "GetObjLstByPaperIdLst_Cache";
    try {
        const arrvPaperSimProObjLst_Cache = await vPaperSimPro_GetObjLst_Cache(strid_CurrEduCls);
        const arrvPaperSimPro_Sel: Array<clsvPaperSimProEN> = arrvPaperSimProObjLst_Cache.filter(x => arrPaperIdLst.indexOf(x.paperId) > -1);
        return arrvPaperSimPro_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperIdLst.join(","), vPaperSimPro_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsvPaperSimProEN>();
}

/**
* 根据顶部条件获取相应的记录对象列表
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
* @param objTopPara:获取顶部对象列表的参数对象
* @returns 获取的相应对象列表
**/
export async function vPaperSimPro_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvPaperSimProEN>> {
    const strThisFuncName = "GetTopObjLstAsync";
    const strAction = "GetTopObjLst";
    const strUrl = GetWebApiUrl(vPaperSimPro_Controller, strAction);
    try {
        const response = await axios.post(strUrl, objTopPara);
        const data = response.data;
        if (data.errorId == 0) {
            const returnObjLst = data.returnObjLst;
            if (returnObjLst == null) {
                const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSimPro_ConstructorName, strThisFuncName);
                console.error(strNullInfo);
                throw (strNullInfo);
            }
            //console.log(returnObjLst);
            const arrObjLst = vPaperSimPro_GetObjLstByJSONObjLst(returnObjLst);
            return (arrObjLst);
        }
        else {
            console.error(data.errorMsg);
            throw (data.errorMsg);
        }
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

/**
* 根据范围条件获取相应的记录对象列表，获取某范围的记录
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
* @param objRangePara:根据范围获取对象列表的参数对象
* @returns 获取的相应记录对象列表
**/
export async function vPaperSimPro_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvPaperSimProEN>> {
    const strThisFuncName = "GetObjLstByRangeAsync";
    const strAction = "GetObjLstByRange";
    const strUrl = GetWebApiUrl(vPaperSimPro_Controller, strAction);
    try {
        const response = await axios.post(strUrl, objRangePara);
        const data = response.data;
        if (data.errorId == 0) {
            const returnObjLst = data.returnObjLst;
            if (returnObjLst == null) {
                const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSimPro_ConstructorName, strThisFuncName);
                console.error(strNullInfo);
                throw (strNullInfo);
            }
            //console.log(returnObjLst);
            const arrObjLst = vPaperSimPro_GetObjLstByJSONObjLst(returnObjLst);
            return arrObjLst;
        }
        else {
            console.error(data.errorMsg);
            throw (data.errorMsg);
        }
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

/**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRange)
 * @param intMinNum:最小记录号
 * @param intMaxNum:最大记录号
 * @param strWhereCond:给定条件
 * @param strOrderBy:排序方式
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 获取的相应记录对象列表
*/
export async function vPaperSimPro_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy: string = "", cb: (json: any) => void, errorCb: (json: any) => void) {
    const strThisFuncName = "GetObjLstByRange";
    const strAction = "GetObjLstByRange";
    const strUrl = GetWebApiUrl(vPaperSimPro_Controller, strAction);
    try {
        const response = await axios.get(strUrl,
            {
                params: {
                    "intMinNum": intMinNum,
                    "intMaxNum": intMaxNum,
                    "strWhereCond": strWhereCond,
                    "strOrderBy": strOrderBy,
                }
            });
        const data = response.data;
        cb(data);
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function vPaperSimPro_GetObjLstByPager_Cache(objPagerPara: stuPagerPara, strid_CurrEduCls: string) {
    const strThisFuncName = "GetObjLstByPager_Cache";
    const arrvPaperSimProObjLst_Cache = await vPaperSimPro_GetObjLst_Cache(strid_CurrEduCls);
    if (arrvPaperSimProObjLst_Cache.length == 0) return arrvPaperSimProObjLst_Cache;
    let arrvPaperSimPro_Sel = arrvPaperSimProObjLst_Cache;
    const obj_Cond = JSON.parse(objPagerPara.whereCond);
    const objvPaperSimPro_Cond = new clsvPaperSimProEN();
    ObjectAssign(objvPaperSimPro_Cond, obj_Cond);
    let dicFldComparisonOp: { [index: string]: string } = {};
    if (obj_Cond.sf_FldComparisonOp != "") {
        dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
    }
    //console.log("clsvPaperSimProWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(obj_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objvPaperSimPro_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.toString().split(',');
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrvPaperSimPro_Sel.length == 0) return arrvPaperSimPro_Sel;
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.sort(vPaperSimPro_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.sort(objPagerPara.sortFun);
        }
        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.slice(intStart, intEnd);
        return arrvPaperSimPro_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vPaperSimPro_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsvPaperSimProEN>();
}

/**
* 根据分页条件获取相应的记录对象列表，只获取一页
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
* @param objPagerPara:分页获取对象列表的参数对象
* @returns 获取的相应记录对象列表
**/
export async function vPaperSimPro_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvPaperSimProEN>> {
    const strThisFuncName = "GetObjLstByPagerAsync";
    const strAction = "GetObjLstByPager";
    const strUrl = GetWebApiUrl(vPaperSimPro_Controller, strAction);
    try {
        const response = await axios.post(strUrl, objPagerPara);
        const data = response.data;
        if (data.errorId == 0) {
            const returnObjLst = data.returnObjLst;
            if (returnObjLst == null) {
                const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSimPro_ConstructorName, strThisFuncName);
                console.error(strNullInfo);
                throw (strNullInfo);
            }
            //console.log(returnObjLst);
            const arrObjLst = vPaperSimPro_GetObjLstByJSONObjLst(returnObjLst);
            return arrObjLst;
        }
        else {
            console.error(data.errorMsg);
            throw (data.errorMsg);
        }
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
 * @param objstrPaperId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vPaperSimPro_IsExistRecord_Cache(objvPaperSimPro_Cond: clsvPaperSimProEN, strid_CurrEduCls: string) {
    const strThisFuncName = "IsExistRecord_Cache";
    const arrvPaperSimProObjLst_Cache = await vPaperSimPro_GetObjLst_Cache(strid_CurrEduCls);
    if (arrvPaperSimProObjLst_Cache == null) return false;
    let arrvPaperSimPro_Sel: Array<clsvPaperSimProEN> = arrvPaperSimProObjLst_Cache;
    if (objvPaperSimPro_Cond.sf_FldComparisonOp == null || objvPaperSimPro_Cond.sf_FldComparisonOp == "") return arrvPaperSimPro_Sel.length > 0 ? true : false;
    const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaperSimPro_Cond.sf_FldComparisonOp);
    //console.log("clsvPaperSimProWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(objvPaperSimPro_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objvPaperSimPro_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        if (arrvPaperSimPro_Sel.length > 0) {
            return true;
        }
        else {
            return false;
        }
    }
    catch (e) {
        const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvPaperSimPro_Cond), vPaperSimPro_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return false;
}

/**
* 根据条件获取是否存在相应的记录？
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
* @param strWhereCond:条件
* @returns 是否存在记录？
**/
export async function vPaperSimPro_IsExistRecordAsync(strWhereCond: string): Promise<boolean> {
    const strThisFuncName = "IsExistRecordAsync";
    const strAction = "IsExistRecord";
    const strUrl = GetWebApiUrl(vPaperSimPro_Controller, strAction);
    try {
        const response = await axios.get(strUrl,
            {
                params: { "strWhereCond": strWhereCond }
            });
        const data = response.data;
        if (data.errorId == 0) {
            return data.returnBool;
        }
        else {
            console.error(data.errorMsg);
            throw (data.errorMsg);
        }
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

/**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
 * @param strPaperId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vPaperSimPro_IsExist(strPaperId: string, cb: (json: any) => void, errorCb: (json: any) => void) {
    const strThisFuncName = "IsExist";
    //检测记录是否存在
    const strAction = "IsExist";
    const strUrl = GetWebApiUrl(vPaperSimPro_Controller, strAction);
    try {
        const response = await axios.get(strUrl,
            {
                params: {
                    "PaperId": strPaperId,
                }
            });
        const data = response.data;
        cb(data);
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

/**
 * 根据关键字判断是否存在记录, 从本地缓存中判断.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
 * @param strPaperId:所给的关键字
 * @returns 对象
*/
export async function vPaperSimPro_IsExist_Cache(strPaperId: string, strid_CurrEduCls: string) {
    const strThisFuncName = "IsExist_Cache";
    const arrvPaperSimProObjLst_Cache = await vPaperSimPro_GetObjLst_Cache(strid_CurrEduCls);
    if (arrvPaperSimProObjLst_Cache == null) return false;
    try {
        const arrvPaperSimPro_Sel: Array<clsvPaperSimProEN> = arrvPaperSimProObjLst_Cache.filter(x => x.paperId == strPaperId);
        if (arrvPaperSimPro_Sel.length > 0) {
            return true;
        }
        else {
            return false;
        }
    }
    catch (e) {
        const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strPaperId, vPaperSimPro_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
    }
    return false;
}

/**
* 根据关键字判断是否存在记录
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
* @param strPaperId:关键字
* @returns 是否存在?存在返回True
**/
export async function vPaperSimPro_IsExistAsync(strPaperId: string): Promise<boolean> {
    const strThisFuncName = "IsExistAsync";
    //检测记录是否存在
    const strAction = "IsExist";
    const strUrl = GetWebApiUrl(vPaperSimPro_Controller, strAction);
    try {
        const response = await axios.get(strUrl,
            {
                params: { "strPaperId": strPaperId }
            });
        const data = response.data;
        if (data.errorId == 0) {
            return (data.returnBool);
        }
        else {
            console.error(data.errorMsg);
            throw (data.errorMsg);
        }
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

/**
* 获取某一条件的记录数
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
* @param strWhereCond:条件
* @returns 获取某一条件的记录数
**/
export async function vPaperSimPro_GetRecCountByCondAsync(strWhereCond: string): Promise<number> {
    const strThisFuncName = "GetRecCountByCondAsync";
    const strAction = "GetRecCountByCond";
    const strUrl = GetWebApiUrl(vPaperSimPro_Controller, strAction);
    try {
        const response = await axios.get(strUrl,
            {
                params: { "strWhereCond": strWhereCond }
            });
        const data = response.data;
        if (data.errorId == 0) {
            return data.returnInt;
        }
        else {
            console.error(data.errorMsg);
            throw (data.errorMsg);
        }
    } catch (error: any) {
        console.error(error);
        if (error.statusText == undefined) {
            throw error;
        }
        if (error.statusText == "error") {
            const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else if (error.statusText == "Not Found") {
            const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSimPro_ConstructorName, strThisFuncName);
            console.error(strInfo);
            throw (strInfo);
        }
        else {
            throw (error.statusText);
        }
    }
}

/**
 * 根据条件对象, 从缓存的对象列表中获取记录数.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
 * @param objvPaperSimPro_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vPaperSimPro_GetRecCountByCond_Cache(objvPaperSimPro_Cond: clsvPaperSimProEN, strid_CurrEduCls: string) {
    const strThisFuncName = "GetRecCountByCond_Cache";
    const arrvPaperSimProObjLst_Cache = await vPaperSimPro_GetObjLst_Cache(strid_CurrEduCls);
    if (arrvPaperSimProObjLst_Cache == null) return 0;
    let arrvPaperSimPro_Sel: Array<clsvPaperSimProEN> = arrvPaperSimProObjLst_Cache;
    if (objvPaperSimPro_Cond.sf_FldComparisonOp == null || objvPaperSimPro_Cond.sf_FldComparisonOp == "") return arrvPaperSimPro_Sel.length;
    const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaperSimPro_Cond.sf_FldComparisonOp);
    //console.log("clsvPaperSimProWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
    //console.log(dicFldComparisonOp);
    try {
        const sstrKeys = GetObjKeys(objvPaperSimPro_Cond);
        //console.log(sstrKeys);
        for (const strKey of sstrKeys) {
            if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
            arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) != null);
            const strComparisonOp = dicFldComparisonOp[strKey];
            const strValue = objvPaperSimPro_Cond.GetFldValue(strKey);
            const strType = typeof (strValue);
            switch (strType) {
                case "string":
                    if (strValue == null) continue;
                    if (strValue == "") continue;
                    if (strComparisonOp == "=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                    }
                    else if (strComparisonOp == "like") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                    }
                    else if (strComparisonOp == "in") {
                        const arrValues = strValue.toString().split(',');
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                    }
                    break;
                case "boolean":
                    if (strValue == null) continue;
                    if (strComparisonOp == "=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    break;
                case "number":
                    if (Number(strValue) == 0) continue;
                    if (strComparisonOp == "=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                    }
                    else if (strComparisonOp == ">=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                    }
                    else if (strComparisonOp == "<=") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    else if (strComparisonOp == ">") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                    }
                    else if (strComparisonOp == "<") {
                        arrvPaperSimPro_Sel = arrvPaperSimPro_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                    }
                    break;
            }
        }
        return arrvPaperSimPro_Sel.length;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvPaperSimPro_Cond), vPaperSimPro_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return 0;
}

/**
 * 获取WebApi的地址
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
*/
export function vPaperSimPro_GetWebApiUrl(strController: string, strAction: string): string {
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
* 刷新本类中的缓存.
* (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
**/
export function vPaperSimPro_ReFreshThisCache(strid_CurrEduCls: string): void {
    const strThisFuncName = "ReFreshThisCache";
    if (clsSysPara4WebApi.spSetRefreshCacheOn == true) {
        const strKey = Format("{0}_{1}", clsvPaperSimProEN._CurrTabName, strid_CurrEduCls);
        switch (clsvPaperSimProEN.CacheModeId) {
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
        const strMsg = Format("刷新缓存成功！");
        console.trace(strMsg);
    }
    else {
        const strMsg = Format("刷新缓存已经关闭。");
        console.trace(strMsg);
    }
}

//(IsNeedGC == false)该表下拉框功能不需要生成;

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-01-10
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vPaperSimPro_GetJSONStrByObj(pobjvPaperSimProEN: clsvPaperSimProEN): string {
    const strThisFuncName = "GetJSONStrByObj";
    let strJson = "";
    try {
        strJson = JSON.stringify(pobjvPaperSimProEN);
    }
    catch (objException) {
        const strEx = GetExceptionStr(objException);
        myShowErrorMsg(strEx);
    }
    if (strJson == undefined) return "";
    else return strJson;
}

/**
 * 把一个JSON串转化为一个对象列表
 * 作者:pyf
 * 日期:2023-01-10
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象列表
*/
export function vPaperSimPro_GetObjLstByJSONStr(strJSON: string): Array<clsvPaperSimProEN> {
    const strThisFuncName = "GetObjLstByJSONStr";
    let arrvPaperSimProObjLst = new Array<clsvPaperSimProEN>();
    if (strJSON === "") {
        return arrvPaperSimProObjLst;
    }
    try {
        arrvPaperSimProObjLst = JSON.parse(strJSON);
    }
    catch (objException) {
        return arrvPaperSimProObjLst;
    }
    return arrvPaperSimProObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-01-10
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvPaperSimProObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vPaperSimPro_GetObjLstByJSONObjLst(arrvPaperSimProObjLstS: Array<clsvPaperSimProEN>): Array<clsvPaperSimProEN> {
    const strThisFuncName = "GetObjLstByJSONObjLst";
    const arrvPaperSimProObjLst = new Array<clsvPaperSimProEN>();
    for (const objInFor of arrvPaperSimProObjLstS) {
        const obj1 = vPaperSimPro_GetObjFromJsonObj(objInFor);
        if (obj1 == null) continue;
        arrvPaperSimProObjLst.push(obj1);
    }
    return arrvPaperSimProObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-01-10
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vPaperSimPro_GetObjByJSONStr(strJSON: string): clsvPaperSimProEN {
    const strThisFuncName = "GetObjByJSONStr";
    let pobjvPaperSimProEN = new clsvPaperSimProEN();
    if (strJSON === "") {
        return pobjvPaperSimProEN;
    }
    try {
        pobjvPaperSimProEN = JSON.parse(strJSON);
    }
    catch (objException) {
        return pobjvPaperSimProEN;
    }
    return pobjvPaperSimProEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vPaperSimPro_GetCombineCondition(objvPaperSimPro_Cond: clsvPaperSimProEN): string {
    const strThisFuncName = "GetCombineCondition";
    //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
    //例如 1 = 1 && UserName = '张三'
    let strWhereCond = " 1 = 1 ";
    //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
    if (Object.prototype.hasOwnProperty.call(objvPaperSimPro_Cond.dicFldComparisonOp, clsvPaperSimProEN.con_PaperId) == true) {
        const strComparisonOp_PaperId: string = objvPaperSimPro_Cond.dicFldComparisonOp[clsvPaperSimProEN.con_PaperId];
        strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimProEN.con_PaperId, objvPaperSimPro_Cond.paperId, strComparisonOp_PaperId);
    }
    if (Object.prototype.hasOwnProperty.call(objvPaperSimPro_Cond.dicFldComparisonOp, clsvPaperSimProEN.con_PaperTitle) == true) {
        const strComparisonOp_PaperTitle: string = objvPaperSimPro_Cond.dicFldComparisonOp[clsvPaperSimProEN.con_PaperTitle];
        strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimProEN.con_PaperTitle, objvPaperSimPro_Cond.paperTitle, strComparisonOp_PaperTitle);
    }
    //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
    if (Object.prototype.hasOwnProperty.call(objvPaperSimPro_Cond.dicFldComparisonOp, clsvPaperSimProEN.con_Periodical) == true) {
        const strComparisonOp_Periodical: string = objvPaperSimPro_Cond.dicFldComparisonOp[clsvPaperSimProEN.con_Periodical];
        strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimProEN.con_Periodical, objvPaperSimPro_Cond.periodical, strComparisonOp_Periodical);
    }
    if (Object.prototype.hasOwnProperty.call(objvPaperSimPro_Cond.dicFldComparisonOp, clsvPaperSimProEN.con_Author) == true) {
        const strComparisonOp_Author: string = objvPaperSimPro_Cond.dicFldComparisonOp[clsvPaperSimProEN.con_Author];
        strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimProEN.con_Author, objvPaperSimPro_Cond.author, strComparisonOp_Author);
    }
    return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvPaperSimProENS:源对象
 * @param objvPaperSimProENT:目标对象
*/
export function vPaperSimPro_CopyObjTo(objvPaperSimProENS: clsvPaperSimProEN, objvPaperSimProENT: clsvPaperSimProEN): void {
    objvPaperSimProENT.paperId = objvPaperSimProENS.paperId; //论文Id
    objvPaperSimProENT.paperTitle = objvPaperSimProENS.paperTitle; //论文标题
    objvPaperSimProENT.paperContent = objvPaperSimProENS.paperContent; //主题内容
    objvPaperSimProENT.periodical = objvPaperSimProENS.periodical; //期刊
    objvPaperSimProENT.author = objvPaperSimProENS.author; //作者
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvPaperSimProENS:源对象
 * @param objvPaperSimProENT:目标对象
*/
export function vPaperSimPro_GetObjFromJsonObj(objvPaperSimProENS: clsvPaperSimProEN): clsvPaperSimProEN {
    const objvPaperSimProENT: clsvPaperSimProEN = new clsvPaperSimProEN();
    ObjectAssign(objvPaperSimProENT, objvPaperSimProENS);
    return objvPaperSimProENT;
}