
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsJournalSubjectCategoryExWApi
表名:JournalSubjectCategory(01120931)
生成代码版本:2021.06.19.1
生成日期:2021/06/20 00:38:48
生成者:pyf
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培论文
模块英文名:GraduateEduPaper
框架-层名:WA_访问扩展层(WA_AccessEx)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

/// <summary>
/// 期刊学科门类(JournalSubjectCategory)
/// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
/// </summary>
/**
* Created by pyf on 2021年06月20日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../../scripts/typings/q/q.d.ts" />
///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
import * as $ from "jquery";
//import * as QQ from "q";
import { stuExcelData } from "../../funclass/stuexceldata.js";
import { clsJournalSubjectCategoryEN } from "../../L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryEN.js";
import { clsJournalSubjectCategoryENEx } from "../../L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryENEx.js";
import { JournalSubjectCategory_CopyObjTo } from "../../L3_ForWApi/GraduateEduPaper/clsJournalSubjectCategoryWApi.js";
import { clsString } from "../../PubFun/clsString.js";
import { clsSysPara4WebApi2 } from "../../PubFun/clsSysPara4WebApi2.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
var ResponseData: tzResponseData;
export class clsJournalSubjectCategoryExWApi {
    public static mstrController: string = "JournalSubjectCategoryExApi";
    public objJournalSubjectCategoryEN: clsJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();

    /// <summary>
    /// 构造函数
    /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
    /// </summary>
    constructor() {
    };

    /// <summary>
    /// 获取WebApi的地址
    /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
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

    /// <summary>
    /// 把同一个类的对象,复制到另一个对象
    /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
    /// </summary>
    /// <param name = "objJournalSubjectCategoryENS">源对象</param>
    /// <returns>目标对象=>clsJournalSubjectCategoryEN:objJournalSubjectCategoryENT</returns>
    public static CopyToEx(objJournalSubjectCategoryENS: clsJournalSubjectCategoryEN): clsJournalSubjectCategoryENEx {
        var objJournalSubjectCategoryENT = new clsJournalSubjectCategoryENEx();
        try {
            JournalSubjectCategory_CopyObjTo(objJournalSubjectCategoryENS, objJournalSubjectCategoryENT);
            return objJournalSubjectCategoryENT;
        }
        catch (e) {
            var strMsg: string = clsString.Format("(errid:Watl000066)Copy表对象数据出错,${e}.");
            console.error(strMsg);
            alert(strMsg);
            return objJournalSubjectCategoryENT;
        }
    }

    /// <summary>
    /// 导入Excel数据
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
    /// </summary>
    /// <param name = "strCsv">Csv格式的Excel数据</param>
    /// <param name = "strUserId">用户Id</param>
    /// <returns>获取的相应对象列表</returns>
    public static ImportDataFromCsv(strCsv: string, strUserId: string): Promise<number> {
        var strAction = "ImportDataFromCsv";
        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strCsv", strCsv);
        mapParam.add("strUserId", strUserId);
        var objExcelData: stuExcelData = { Csv: strCsv, userId: strUserId, Id_Grade: "", bolRound: false }

        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "Post",
                dataType: "json",
                data: objExcelData,
                success: function (data) {
                    if (data.ErrorId == 0) {
                        resolve(data.ReturnInt);
                    }
                    else {
                        console.error(data.ErrorMsg);
                        reject(data.ErrorMsg);
                    }
                },
                error: function (result) {
                    console.error(result);
                    console.error(JSON.stringify(result));
                    if (result.statusText == "error") {
                        var strInfo = `网络错误！访问地址:${strUrl} 不成功！`;
                        reject(strInfo);
                    }
                    else {
                        reject(result.statusText);
                    }
                }
            });
        });
    };
};