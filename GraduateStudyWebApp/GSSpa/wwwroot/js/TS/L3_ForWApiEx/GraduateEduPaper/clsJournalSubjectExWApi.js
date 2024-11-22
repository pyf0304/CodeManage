/// <reference path="../../funclass/stuexceldata.ts" />
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    var desc = Object.getOwnPropertyDescriptor(m, k);
    if (!desc || ("get" in desc ? !m.__esModule : desc.writable || desc.configurable)) {
      desc = { enumerable: true, get: function() { return m[k]; } };
    }
    Object.defineProperty(o, k2, desc);
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "jquery", "../../L0_Entity/GraduateEduPaper/clsJournalSubjectEN.js", "../../L0_Entity/GraduateEduPaper/clsJournalSubjectENEx.js", "../../L3_ForWApi/GraduateEduPaper/clsJournalSubjectWApi.js", "../../PubFun/clsString2.js", "../../PubFun/clsSysPara4WebApi2.js", "../../PubFun/tzDictionary.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsJournalSubjectExWApi = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:clsJournalSubjectExWApi
    表名:JournalSubject(01120930)
    生成代码版本:2021.06.19.1
    生成日期:2021/06/20 00:38:45
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
    /// 期刊学科(JournalSubject)
    /// (AutoGCLib.WA_AccessEx4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by pyf on 2021年06月20日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    const $ = __importStar(require("jquery"));
    //import * as QQ from "q";
    const clsJournalSubjectEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsJournalSubjectEN.js");
    const clsJournalSubjectENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsJournalSubjectENEx.js");
    const clsJournalSubjectWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsJournalSubjectWApi.js");
    const clsString2_js_1 = require("../../PubFun/clsString2.js");
    const clsSysPara4WebApi2_js_1 = require("../../PubFun/clsSysPara4WebApi2.js");
    const tzDictionary_js_1 = require("../../PubFun/tzDictionary.js");
    //import * as QQ from "q";
    var ResponseData;
    class clsJournalSubjectExWApi {
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
        /// </summary>
        constructor() {
            this.objJournalSubjectEN = new clsJournalSubjectEN_js_1.clsJournalSubjectEN();
        }
        ;
        /// <summary>
        /// 获取WebApi的地址
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
        /// </summary>
        /// <returns>返回当前文件中Web服务的地址</returns>
        static GetWebApiUrl(strController, strAction) {
            var strServiceUrl;
            if (clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.bolIsLocalHost == false) {
                strServiceUrl = `${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrPrx}/${strController}/${strAction}`;
            }
            else {
                strServiceUrl = `${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrIPAddressAndPort_Local}/${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrPrx}/${strController}/${strAction}`;
            }
            return strServiceUrl;
        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
        /// </summary>
        /// <param name = "objJournalSubjectENS">源对象</param>
        /// <returns>目标对象=>clsJournalSubjectEN:objJournalSubjectENT</returns>
        static CopyToEx(objJournalSubjectENS) {
            var objJournalSubjectENT = new clsJournalSubjectENEx_js_1.clsJournalSubjectENEx();
            try {
                (0, clsJournalSubjectWApi_js_1.JournalSubject_CopyObjTo)(objJournalSubjectENS, objJournalSubjectENT);
                return objJournalSubjectENT;
            }
            catch (e) {
                var strMsg = clsString2_js_1.clsString.Format("(errid:Watl000066)Copy表对象数据出错,${e}.");
                console.error(strMsg);
                alert(strMsg);
                return objJournalSubjectENT;
            }
        }
        /// <summary>
        /// 导入Excel数据
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strCsv">Csv格式的Excel数据</param>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>获取的相应对象列表</returns>
        static ImportDataFromCsv(strCsv, strUserId) {
            var strAction = "ImportDataFromCsv";
            let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strCsv", strCsv);
            mapParam.add("strUserId", strUserId);
            var objExcelData = { Csv: strCsv, userId: strUserId, Id_Grade: "", bolRound: false };
            let strData = mapParam.getParamText(); // "例如: strIdentityID =01";
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "Post",
                    dataType: "json",
                    data: objExcelData,
                    //data: {strCsv: strCsv, strUserId: strUserId},
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
                        console.log(result);
                        console.log(JSON.stringify(result));
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
        }
        ;
    }
    exports.clsJournalSubjectExWApi = clsJournalSubjectExWApi;
    clsJournalSubjectExWApi.mstrController = "JournalSubjectExApi";
    ;
});
