/// (AutoGCLib.WA_Access4TypeScript:GeneCode)
/// </summary>
/**
* Created by  on 2019年12月25日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as QQ from "q";
import { Dictionary } from "../../PubFun/tzDictionary.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { clsgs_RTqa_PaperRelaEN } from "../../L0_Entity/GraduateEduTopic/clsgs_RTqa_PaperRelaEN.js";
import axios from "axios";
import { Format } from "../../PubFun/clsString.js";

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
    public static async SynTopicPaperQAAsync(strid_CurrEduCls: string, strTopicId: string, strUpdUser: string): Promise<boolean> {
        const strThisFuncName = "";
        var strAction = "SynTopicPaperQA";
        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strid_CurrEduCls", strid_CurrEduCls);
        mapParam.add("strTopicId", strTopicId);
        mapParam.add("strUpdUser", strUpdUser);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        try {
            const response = await axios.get(strUrl,
                {
                    params: {
                        "strid_CurrEduCls": strid_CurrEduCls,
                        "strTopicId": strTopicId,
                        "strUpdUser": strUpdUser
                    }
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