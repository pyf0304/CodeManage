﻿/*-- -- -- -- -- -- -- -- -- -- --
类名:clsPaperReadWriteWApi
表名:PaperReadWrite(01120547)
生成代码版本:2020.01.02.1
生成日期:2020/01/02 16:12:20
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
/// 论文读写表(PaperReadWrite)
/// (AutoGCLib.WA_Access4TypeScript:GeneCode)
/// </summary>
/**
* Created by  on 2020年01月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />

//import * as QQ from "q";
import { clsPaperReadWriteEN } from "../../L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js";

import { Dictionary } from "../../PubFun/tzDictionary.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { clsvPaperReadWriteEN } from "../../L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js";
import { Format } from "../../PubFun/clsString.js";
import { vPaperReadWrite_GetObjLstByJSONObjLst } from "../../L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js";
import axios from "axios";
var ResponseData: tzResponseData;
export class clsvPaperReadWriteWApiEx {
    public static mstrController: string = "vPaperReadWriteExApi";
    public objPaperReadWriteEN: clsPaperReadWriteEN = new clsPaperReadWriteEN();
    constructor(pobjPaperReadWriteEN: clsPaperReadWriteEN) {
        this.objPaperReadWriteEN = pobjPaperReadWriteEN;
    };

    /// <summary>
    /// 获取论文读写中的用户数量
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>获取的相应对象列表</returns>
    public static async GetUserNumObjLstAsync(strWhereCond: string): Promise<Array<clsvPaperReadWriteEN>> {
        const strThisFuncName = "GetUserNumObjLstAsync";
        var strAction = "GetUserNumObjLst";
        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strWhereCond", strWhereCond);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        try {
            const response = await axios.get(strUrl,
                {
                    params: { "strWhereCond": strWhereCond }
                });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", this.mstrController, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperReadWrite_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, this.mstrController, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, this.mstrController, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }


   
    /// <summary>
    /// 获取WebApi的地址
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
    /// </summary>
    /// <returns>返回当前文件中Web服务的地址</returns>
    public static GetWebApiUrl(strController: string, strAction: string): string {
        var strServiceUrl: string;
        if (clsSysPara4WebApi.bolIsLocalHost == false) {
            strServiceUrl = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
        }
        else {
            strServiceUrl = `${clsSysPara4WebApi.CurrIPAddressAndPort_Local}/${clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
        }
        return strServiceUrl;
    }
}