(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/InteractManage/clscc_ExamPaperStuRelationEN.js", "../../L0_Entity/InteractManage/clscc_ExamPaperStuRelationENEx.js", "../../L3_ForWApi/InteractManage/clscc_ExamPaperStuRelationWApi.js", "../../PubFun/clsString2.js", "../../PubFun/clsSysPara4WebApi2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clscc_ExamPaperStuRelationExWApi = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:clscc_ExamPaperStuRelationExWApi
    表名:cc_ExamPaperStuRelation(01120235)
    生成代码版本:2021.06.19.1
    生成日期:2021/06/19 15:01:19
    生成者:pyf
    生成服务器IP:192.168.1.12
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:互动管理
    模块英文名:InteractManage
    框架-层名:WA_访问扩展层(WA_AccessEx)
    编程语言:TypeScript
    注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
           2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
    == == == == == == == == == == == ==
    */
    //import * as QQ from "q";
    const clscc_ExamPaperStuRelationEN_js_1 = require("../../L0_Entity/InteractManage/clscc_ExamPaperStuRelationEN.js");
    const clscc_ExamPaperStuRelationENEx_js_1 = require("../../L0_Entity/InteractManage/clscc_ExamPaperStuRelationENEx.js");
    const clscc_ExamPaperStuRelationWApi_js_1 = require("../../L3_ForWApi/InteractManage/clscc_ExamPaperStuRelationWApi.js");
    const clsString2_js_1 = require("../../PubFun/clsString2.js");
    const clsSysPara4WebApi2_js_1 = require("../../PubFun/clsSysPara4WebApi2.js");
    var ResponseData;
    class clscc_ExamPaperStuRelationExWApi {
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
        /// </summary>
        constructor() {
            this.objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN_js_1.clscc_ExamPaperStuRelationEN();
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
        /// <param name = "objcc_ExamPaperStuRelationENS">源对象</param>
        /// <returns>目标对象=>clscc_ExamPaperStuRelationEN:objcc_ExamPaperStuRelationENT</returns>
        static CopyToEx(objcc_ExamPaperStuRelationENS) {
            var objcc_ExamPaperStuRelationENT = new clscc_ExamPaperStuRelationENEx_js_1.clscc_ExamPaperStuRelationENEx();
            try {
                (0, clscc_ExamPaperStuRelationWApi_js_1.cc_ExamPaperStuRelation_CopyObjTo)(objcc_ExamPaperStuRelationENS, objcc_ExamPaperStuRelationENT);
                return objcc_ExamPaperStuRelationENT;
            }
            catch (e) {
                var strMsg = clsString2_js_1.clsString.Format("(errid:Watl000066)Copy表对象数据出错,${e}.");
                console.error(strMsg);
                alert(strMsg);
                return objcc_ExamPaperStuRelationENT;
            }
        }
    }
    exports.clscc_ExamPaperStuRelationExWApi = clscc_ExamPaperStuRelationExWApi;
    clscc_ExamPaperStuRelationExWApi.mstrController = "cc_ExamPaperStuRelationExApi";
    ;
});
