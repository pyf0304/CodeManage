/// <summary>
/// 课程知识点(cc_CourseKnowledges)
/// (AutoGCLib.WA_Access4TypeScript:GeneCode)
/// </summary>
/**
* Created by  on 2019年12月04日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />

//import * as QQ from "q";
import { clscc_CourseKnowledgesEN } from "../../L0_Entity/Knowledges_Share/clscc_CourseKnowledgesEN.js";
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
var ResponseData: tzResponseData;
export class clscc_CourseKnowledgesWApiEx {
    public static mstrController: string = "cc_CourseKnowledgesExApi";
    public objcc_CourseKnowledgesEN: clscc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
    constructor(pobjcc_CourseKnowledgesEN: clscc_CourseKnowledgesEN) {
        this.objcc_CourseKnowledgesEN = pobjcc_CourseKnowledgesEN;
    };


    /// <summary>
    /// 调用WebApi来添加记录，数据传递使用JSON串
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    /// </summary>
    /// <param name = "objcc_CourseKnowledgesEN">需要添加的对象</param>
    /// <returns>获取相应的记录的对象</returns>
    public static AddNewRecordAsyncEx(objcc_CourseKnowledgesEN: clscc_CourseKnowledgesEN): Promise<boolean> {
        var strMsg = "";
        var strAction = "AddNewRecordEx";
        //if (objcc_CourseKnowledgesEN.courseKnowledgeId === null || objcc_CourseKnowledgesEN.courseKnowledgeId === "") {
        //    strMsg = "需要的对象的关键字为空，不能添加!";
        //    throw strMsg;
        //}
        
        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objcc_CourseKnowledgesEN,
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
        if (clsSysPara4WebApi.bolIsLocalHost == false) {
            strServiceUrl = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx3}/${strController}/${strAction}`;
        }
        else {
            strServiceUrl = `${clsSysPara4WebApi.CurrIPAddressAndPort_Local}/${clsSysPara4WebApi.CurrPrx3}/${strController}/${strAction}`;
        }
        return strServiceUrl;
    }
}