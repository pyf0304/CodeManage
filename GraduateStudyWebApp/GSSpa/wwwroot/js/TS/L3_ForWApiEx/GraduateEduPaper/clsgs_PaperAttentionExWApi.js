/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_PaperAttentionExWApi
表名:gs_PaperAttention(01120748)
生成代码版本:2020.09.24.1
生成日期:2020/09/28 12:21:57
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
        define(["require", "exports", "../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js", "../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionENEx.js", "../../PubFun/clsSysPara4WebApi2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsgs_PaperAttentionExWApi = void 0;
    //import * as QQ from "q";
    const clsgs_PaperAttentionEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js");
    const clsgs_PaperAttentionENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionENEx.js");
    const clsSysPara4WebApi2_js_1 = require("../../PubFun/clsSysPara4WebApi2.js");
    var ResponseData;
    class clsgs_PaperAttentionExWApi {
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
        /// </summary>
        constructor() {
            this.objgs_PaperAttentionEN = new clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN();
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
        /// 把同一个类的对象,复制到该类的扩展对象
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_CopyToEx)
        /// </summary>
        /// <param name = "objgs_PaperAttentionENS">源对象</param>
        /// <param name = "objgs_PaperAttentionENT">目标对象</param>
        static CopyToEx(objgs_PaperAttentionENS) {
            var objgs_PaperAttentionENT = new clsgs_PaperAttentionENEx_js_1.clsgs_PaperAttentionENEx();
            objgs_PaperAttentionENT.paperAttentionId = objgs_PaperAttentionENS.paperAttentionId; //论文收藏Id
            objgs_PaperAttentionENT.paperId = objgs_PaperAttentionENS.paperId; //论文Id
            objgs_PaperAttentionENT.userId = objgs_PaperAttentionENS.userId; //用户ID
            objgs_PaperAttentionENT.paperGroupId = objgs_PaperAttentionENS.paperGroupId; //组Id
            objgs_PaperAttentionENT.updUser = objgs_PaperAttentionENS.updUser; //修改人
            objgs_PaperAttentionENT.updDate = objgs_PaperAttentionENS.updDate; //修改日期
            objgs_PaperAttentionENT.meno = objgs_PaperAttentionENS.meno; //备注
            objgs_PaperAttentionENT.sf_UpdFldSetStr = objgs_PaperAttentionENS.updFldString; //专门用于记录某字段属性是否修改
            objgs_PaperAttentionENT.sf_FldComparisonOp = objgs_PaperAttentionENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
            return objgs_PaperAttentionENT;
        }
    }
    exports.clsgs_PaperAttentionExWApi = clsgs_PaperAttentionExWApi;
    clsgs_PaperAttentionExWApi.mstrController = "gs_PaperAttentionExApi";
    ;
});
