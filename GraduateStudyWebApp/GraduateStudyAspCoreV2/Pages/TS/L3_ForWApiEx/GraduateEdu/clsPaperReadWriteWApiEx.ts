/*-- -- -- -- -- -- -- -- -- -- --
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
import axios from "axios";
//import * as QQ from "q";
import { clsPaperReadWriteEN } from "../../L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js";
import { Format } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
var ResponseData: tzResponseData;
export class clsPaperReadWriteWApiEx {
    public static mstrController: string = "PaperReadWriteExApi";
    public objPaperReadWriteEN: clsPaperReadWriteEN = new clsPaperReadWriteEN();
    constructor(pobjPaperReadWriteEN: clsPaperReadWriteEN) {
        this.objPaperReadWriteEN = pobjPaperReadWriteEN;
    };


    /// <summary>
    /// 调用WebApi来添加记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    /// </summary>
    /// <param name = "objPaperReadWriteEN">需要添加的对象</param>
    /// <returns>获取相应的记录的对象</returns>
    public static async AddNewRecordAsyncEx(objPaperReadWriteEN: clsPaperReadWriteEN): Promise<boolean> {
        const strThisFuncName = "";
        var strMsg = "";
        var strAction = "AddNewRecordEx";
        //var strJSON = JSON.stringify(objPaperReadWriteEN_Sim);
        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
        try {
            const response = await axios.post(strUrl, objPaperReadWriteEN);
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
    /// 同步核算
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>返回的第一条记录的关键字值</returns>
    public static async SynPaperRWStatisticsAsync(TeaUserId: string): Promise<boolean> {
        const strThisFuncName = "";
        var strAction = "SynPaperRWStatistics";
        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
    
        try {
            const response = await axios.get(strUrl,
                {
                    params: { "updUser": TeaUserId }
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
    /// 根据关键字列表删除记录
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    /// </summary>
    /// <param name = "arrPaperRWId">关键字列表</param>
    /// <returns>实际删除记录的个数</returns>
    public static async DelPaperReadWritesExAsync(arrPaperRWId: Array<string>): Promise<number> {
        const strThisFuncName = "";
        var strAction = "DelPaperReadWritesEx";
        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
        try {
            const response = await axios.post(strUrl, arrPaperRWId);
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