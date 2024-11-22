/// (AutoGCLib.WA_Access4TypeScript:GeneCode)
/// </summary>
/**
* Created by  on 2019年12月25日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
import * as $ from "jquery";
//import * as QQ from "q";
import { Dictionary } from "../../PubFun/tzDictionary.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
import { clsSysPara4WebApi2 } from "../../PubFun/clsSysPara4WebApi2.js";
import { clsgs_RTqa_PaperRelaEN } from "../../L0_Entity/GraduateEduTopic/clsgs_RTqa_PaperRelaEN.js";

var ResponseData: tzResponseData;
export class clsgs_RTqa_PaperRelaExWApi {
    public static mstrController: string = "gs_RTqa_PaperRelaExApi";
    public objgs_RTqa_PaperRelaEN: clsgs_RTqa_PaperRelaEN = new clsgs_RTqa_PaperRelaEN();
    constructor(pobjgs_RTqa_PaperRelaEN: clsgs_RTqa_PaperRelaEN) {
        this.objgs_RTqa_PaperRelaEN = pobjgs_RTqa_PaperRelaEN;
    };

    /// <summary>
    /// 同步核算
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    /// </summary>
    /// <param name = "strWhereCond">条件</param>
    /// <returns>返回的第一条记录的关键字值</returns>
    public static SynTopicPaperQAAsync(strid_CurrEduCls: string, strTopicId: string, strUpdUser: string): Promise<boolean> {
        var strAction = "SynTopicPaperQA";
        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strid_CurrEduCls", strid_CurrEduCls);
        mapParam.add("strTopicId", strTopicId);
        mapParam.add("strUpdUser", strUpdUser);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                    //if (data.ErrorId == 0) {
                    //    resolve(data.ReturnStr);
                    //}
                    //else {
                    //    console.log(data.ErrorMsg);
                    //    reject(data.ErrorMsg);
                    //}
                },
                error: function (result) {
                    console.log(result);
                    console.log(JSON.stringify(result));
                    if (result.statusText == "error") {
                        var strInfo = `网络错误！访问地址:${strUrl}不成功！`;
                        reject(strInfo);
                    }
                    else {
                        reject(result.statusText);
                    }
                }
            });
        });
    }

    /// <summary>
    /// 获取WebApi的地址
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
    /// </summary>
    /// <returns>返回当前文件中Web服务的地址</returns>
    public static GetWebApiUrl(strController: string, strAction: string): string {
        var strServiceUrl: string;
        if (clsSysPara4WebApi2.bolIsLocalHost == false) {
            strServiceUrl = `${clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2.CurrPrx}/${strController}/${strAction}`;
        }
        else {
            strServiceUrl = `${clsSysPara4WebApi2.CurrIPAddressAndPort_Local}/${clsSysPara4WebApi2.CurrPrx}/${strController}/${strAction}`;
        }
        return strServiceUrl;
    }
}