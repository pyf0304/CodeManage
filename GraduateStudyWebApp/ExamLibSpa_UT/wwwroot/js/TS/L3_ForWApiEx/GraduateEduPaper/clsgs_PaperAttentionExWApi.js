/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_PaperAttentionExWApi
表名:gs_PaperAttention(01120748)
生成代码版本:2020.09.24.1
生成日期:2020/09/29 00:00:13
生成者:pyf2
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培论文
模块英文名:GraduateEduPaper
框架-层名:WA_访问扩展层(WA_AccessEx)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == ==
*/
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js", "../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionENEx.js", "../../PubFun/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    //import * as QQ from "q";
    var clsgs_PaperAttentionEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js");
    var clsgs_PaperAttentionENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionENEx.js");
    var clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    var ResponseData;
    var clsgs_PaperAttentionExWApi = /** @class */ (function () {
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
        /// </summary>
        function clsgs_PaperAttentionExWApi() {
            this.objgs_PaperAttentionEN = new clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN();
        }
        ;
        /// <summary>
        /// 获取WebApi的地址
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_GetWebApiUrl)
        /// </summary>
        /// <returns>返回当前文件中Web服务的地址</returns>
        clsgs_PaperAttentionExWApi.GetWebApiUrl = function (strController, strAction) {
            var strServiceUrl;
            if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
                strServiceUrl = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort + "/" + clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx + "/" + strController + "/" + strAction;
            }
            else {
                strServiceUrl = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local + "/" + clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx + "/" + strController + "/" + strAction;
            }
            return strServiceUrl;
        };
        /// <summary>
        /// 把同一个类的对象,复制到该类的扩展对象
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
        /// </summary>
        /// <param name = "objgs_PaperAttentionENS">源对象</param>
        /// <param name = "objgs_PaperAttentionENT">目标对象</param>
        clsgs_PaperAttentionExWApi.CopyToEx = function (objgs_PaperAttentionENS) {
            var objgs_PaperAttentionENT = new clsgs_PaperAttentionENEx_js_1.clsgs_PaperAttentionENEx();
            objgs_PaperAttentionENT.PaperAttentionId = objgs_PaperAttentionENS.PaperAttentionId; //论文收藏Id
            objgs_PaperAttentionENT.PaperId = objgs_PaperAttentionENS.PaperId; //论文Id
            objgs_PaperAttentionENT.UserId = objgs_PaperAttentionENS.UserId; //用户ID
            objgs_PaperAttentionENT.PaperGroupId = objgs_PaperAttentionENS.PaperGroupId; //组Id
            objgs_PaperAttentionENT.UpdUser = objgs_PaperAttentionENS.UpdUser; //修改人
            objgs_PaperAttentionENT.UpdDate = objgs_PaperAttentionENS.UpdDate; //修改日期
            objgs_PaperAttentionENT.Meno = objgs_PaperAttentionENS.Meno; //备注
            objgs_PaperAttentionENT.sf_UpdFldSetStr = objgs_PaperAttentionENS.UpdFldString; //专门用于记录某字段属性是否修改
            objgs_PaperAttentionENT.sf_FldComparisonOp = objgs_PaperAttentionENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
            return objgs_PaperAttentionENT;
        };
        clsgs_PaperAttentionExWApi.mstrController = "gs_PaperAttentionExApi";
        return clsgs_PaperAttentionExWApi;
    }());
    exports.clsgs_PaperAttentionExWApi = clsgs_PaperAttentionExWApi;
    ;
});
