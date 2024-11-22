﻿
//import $ from "jquery";
import { ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysVoteENEx } from "../../L0_Entity/InteractManage/clsSysVoteENEx.js";
import { SysVote_AddNewRecordAsync, SysVote_GetObjLstAsync, SysVote_GetRecCountByCondAsync, SysVote_IsExistRecordAsync, SysVote_ReFreshCache } from "../../L3_ForWApi/InteractManage/clsSysVoteWApi.js";
import { GetSortExpressInfo } from "../../PubFun/clsCommFunc4Web.js";
import { IsNullOrEmpty } from "../../PubFun/clsString.js";
import { SysVote_SortFunByKey } from "../../L3_ForWApi/InteractManage/clsSysVoteWApi.js";
import { clsSysVoteEN } from "../../L0_Entity/InteractManage/clsSysVoteEN.js";
import { Format } from "../../PubFun/clsString.js";
import { SysVote_FilterFunByKey } from "../../L3_ForWApi/InteractManage/clsSysVoteWApi.js";
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { clsPubFun4Web } from "../../FunClass_Share/clsPubFun4Web.js";
import { clsPaperEN } from "../../L0_Entity/GraduateEduPaper/clsPaperEN.js";
import { Paper_UpdateRecordAsync } from "../../L3_ForWApi/GraduateEduPaper/clsPaperWApi.js";
import { clsPublocalStorage } from "../../PubFun/clsPublocalStorage.js";
export const sysVoteEx_Controller = "SysVoteExApi";
export const sysVoteEx_ConstructorName = "sysVoteEx";

/**
* 获取WebApi的地址
* (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
* @returns 返回当前文件中Web服务的地址
**/
export function SysVoteEx_GetWebApiUrl(strController: string, strAction: string): string {
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
* @param objSysVoteENS:源对象
* @returns 目标对象=>clsSysVoteEN:objSysVoteENT
**/
export function SysVoteEx_CopyToEx(objSysVoteENS: clsSysVoteEN): clsSysVoteENEx {
    const strThisFuncName = SysVoteEx_CopyToEx.name;
    const objSysVoteENT = new clsSysVoteENEx();
    try {
        ObjectAssign(objSysVoteENT, objSysVoteENS);
        return objSysVoteENT;
    }
    catch (e) {
        const strMsg = Format("(errid:Watl000067)Copy表对象数据出错,{0}.(in {1}.{2})", e, sysVoteEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        alert(strMsg);
        return objSysVoteENT;
    }
}
//该表在前台TypeScript中，不需要使用Cache;

/**
 * 根据分页条件从缓存中获取分页对象列表，只获取一页.
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetObjExLstByPagerAsync)
 * @param objPagerPara:分页参数结构
 * @returns 对象列表
*/
export async function SysVoteEx_GetObjExLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsSysVoteENEx>> {
    const strThisFuncName = "GetObjExLstByPagerAsync";
    const arrSysVoteObjLst = await SysVote_GetObjLstAsync(objPagerPara.whereCond);
    const arrSysVoteExObjLst = arrSysVoteObjLst.map(SysVoteEx_CopyToEx);
    const objSortInfo = GetSortExpressInfo(objPagerPara);
    if (IsNullOrEmpty(objSortInfo.SortFld) == false) {
        for (const objInFor of arrSysVoteExObjLst) {
            const conFuncMap = await SysVoteEx_FuncMapByFldName(objSortInfo.SortFld, objInFor);
        }
    }
    if (arrSysVoteExObjLst.length == 0) return arrSysVoteExObjLst;
    let arrSysVote_Sel: Array<clsSysVoteENEx> = arrSysVoteExObjLst;
    try {
        let intStart: number = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
        if (intStart <= 0) intStart = 0;
        const intEnd = intStart + objPagerPara.pageSize;
        if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
            const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
            let strSortType = "asc";
            const strSortFld = sstrSplit[0];
            if (sstrSplit.length > 1) strSortType = sstrSplit[1];
            arrSysVote_Sel = arrSysVote_Sel.sort(SysVoteEx_SortFunByKey(strSortFld, strSortType));
        }
        else {
            //如果排序字段名[OrderBy]为空，就调用排序函数
            arrSysVote_Sel = arrSysVote_Sel.sort(objPagerPara.sortFun);
        }
        arrSysVote_Sel = arrSysVote_Sel.slice(intStart, intEnd);
        return arrSysVote_Sel;
    }
    catch (e) {
        const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, sysVoteEx_ConstructorName, strThisFuncName);
        console.error(strMsg);
        throw new Error(strMsg);
    }
    return new Array<clsSysVoteENEx>();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2022-11-05
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function SysVoteEx_SortFunByKey(strKey: string, AscOrDesc: string) {
    const strThisFuncName = "SortFunByKey";
    if (AscOrDesc == "Asc" || AscOrDesc == "") {
        switch (strKey) {
            default:
                return SysVote_SortFunByKey(strKey, AscOrDesc);
        }
    }
    else {
        switch (strKey) {
            default:
                return SysVote_SortFunByKey(strKey, AscOrDesc);
        }
    }
}

/**
 * 根据扩展字段名去调用相应的映射函数
 * 作者:pyf
 * 日期:2022-11-05
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FuncMapByFldName)
 * @param strFldName:扩展字段名
 * @param  obj{0}Ex:需要转换的对象
 * @returns 针对扩展字段名对转换对象进行函数映射
*/
export function SysVoteEx_FuncMapByFldName(strFldName: string, objSysVoteEx: clsSysVoteENEx) {
    const strThisFuncName = SysVoteEx_FuncMapByFldName.name;
    let strMsg = "";
    //如果是本表中字段，不需要映射
    const arrFldName = clsSysVoteEN.AttributeName;
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
 * 日期:2022-11-05
 * (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function SysVoteEx_FilterFunByKey(strKey: string, value: any) {
    const strThisFuncName = "FilterFunByKey";
    let strMsg = "";
    switch (strKey) {
        default:
            return SysVote_FilterFunByKey(strKey, value);
    }
}

export async function SysVoteEx_btnAddVote_Click_PaperId(strPaperId: string, strUserId: string, strLikedUserId: string) {
    const strThisFuncName = SysVoteEx_btnAddVote_Click_PaperId.name;
    //this.DivName = "divAddNewRecordSave";
    var objSysVoteEN: clsSysVoteEN = new clsSysVoteEN();

    //this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);

    objSysVoteEN.SetTableKey(strPaperId);
    objSysVoteEN.SetVoteTypeId("01");
    objSysVoteEN.SetUpdDate(clsPubFun4Web.getNowDate());// 修改日期
    objSysVoteEN.SetUpdUser(strUserId);// 修改用户Id
    objSysVoteEN.SetLikedUserId(strUserId);//被点赞用户
    objSysVoteEN.Setid_CurrEduCls(clsPublocalStorage.id_CurrEduCls);

    var strWhereCond = " 1 =1 and updUser='" + strUserId + "' and tableKey=" + strPaperId;
    try {
        const responseText = await SysVote_IsExistRecordAsync(strWhereCond);
        var bolIsExist: boolean = responseText;
        if (bolIsExist == true) {
            var strMsg: string = `您已经点赞过这条论文了，请给其他论文点赞一下吧！`;
            alert(strMsg);
            return responseText;//一定要有一个返回值，否则会出错！
        }

        const returnBool = await SysVote_AddNewRecordAsync(objSysVoteEN);
    
        if (returnBool == true) {
            SysVote_ReFreshCache(clsPublocalStorage.userId);
            var strWhereCond2 = " 1=1 and voteTypeId='01' and tableKey=" + strPaperId;
            var intVoteCount = await SysVote_GetRecCountByCondAsync(strWhereCond2);

            var objPaperEN: clsPaperEN = new clsPaperEN();
            objPaperEN.SetPaperId(strPaperId);
            objPaperEN.SetOkCount(intVoteCount);

            objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString;//设置哪些字段被修改(脏字段)
            if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                 throw Format("关键字不能为空!(in {0}.{1})", sysVoteEx_ConstructorName, strThisFuncName);
            }

            var returnBool1 = await Paper_UpdateRecordAsync(objPaperEN);
            if (returnBool1 == true) {
                //const gvResult = await this.BindGv_Paper();
                return returnBool;
            }
            else {
                var strInfo: string = `点赞不成功!`;
                alert(strInfo);
                console.log("点赞不成功");
                return false;
            }

        }
        else {
            var strInfo: string = `点赞不成功!`;
            $('#lblResult40').val(strInfo);
            //显示信息框
            alert(strInfo);
            //this.DetailRecord();
            //this.BindGv_vPaperSubViewpoint();
        }


        return returnBool;//一定要有一个返回值，否则会出错！
    }
    catch (e) {
        console.error('catch(e)=');
        console.error(e);
        var strMsg: string = `点赞不成功,${e}.`;
        alert(strMsg);
        return false;
    }

    return false;//一定要有一个返回值，否则会出错！
}
