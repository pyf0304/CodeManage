﻿/// <summary>
/// 子观点类型表(SubViewpointType)
/// (AutoGCLib.WA_Access4TypeScript:GeneCode)
/// </summary>
/**
* Created by  on 2019年12月01日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
import * as $ from "jquery";
//import * as QQ from "q";
import { clsSubViewpointTypeEN } from "../../L0_Entity/ParameterTable/clsSubViewpointTypeEN.js";
import { clsSysPara4WebApi2 } from "../../PubFun/clsSysPara4WebApi2.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
var ResponseData: tzResponseData;
export class clsSubViewpointTypeWApiEx {
    public static mstrController: string = "SubViewpointTypeExApi";
    public objSubViewpointTypeEN: clsSubViewpointTypeEN = new clsSubViewpointTypeEN();
    constructor(pobjSubViewpointTypeEN: clsSubViewpointTypeEN) {
        this.objSubViewpointTypeEN = pobjSubViewpointTypeEN;
    };


    /// <summary>
    /// 调用WebApi来添加记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    /// </summary>
    /// <param name = "objSubViewpointTypeEN">需要添加的对象</param>
    /// <returns>获取相应的记录的对象</returns>
    public static AddNewRecordAsyncEx(objSubViewpointTypeEN: clsSubViewpointTypeEN): Promise<boolean> {
        var strMsg = "";
        var strAction = "AddNewRecordEx";
        //if (objSubViewpointTypeEN.subViewpointTypeId === null || objSubViewpointTypeEN.subViewpointTypeId === "") {
        //    strMsg = "需要的对象的关键字为空，不能添加!";
        //    throw strMsg;
        //}
        //var strJSON = JSON.stringify(objSubViewpointTypeEN_Sim);
        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objSubViewpointTypeEN,
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
    /// 获取WebApi的地址
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
    /// </summary>
    /// <returns>返回当前文件中Web服务的地址</returns>
    public static GetWebApiUrl(strController: string, strAction: string): string {
        var strServiceUrl: string;
        if (clsSysPara4WebApi2.bolIsLocalHost == false) {
            strServiceUrl = `${clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2.CurrPrx3}/${strController}/${strAction}`;
        }
        else {
            strServiceUrl = `${clsSysPara4WebApi2.CurrIPAddressAndPort_Local}/${clsSysPara4WebApi2.CurrPrx3}/${strController}/${strAction}`;
        }
        return strServiceUrl;
    }
}