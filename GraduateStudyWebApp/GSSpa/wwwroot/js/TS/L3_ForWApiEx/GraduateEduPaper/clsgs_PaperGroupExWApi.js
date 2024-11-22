/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_PaperGroupExWApi
表名:gs_PaperGroup(01120749)
生成代码版本:2020.09.24.1
生成日期:2020/09/28 12:21:58
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
        define(["require", "exports", "../../L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js", "../../L0_Entity/GraduateEduPaper/clsgs_PaperGroupENEx.js", "../../PubFun/clsSysPara4WebApi2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsgs_PaperGroupExWApi = void 0;
    //import * as QQ from "q";
    const clsgs_PaperGroupEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js");
    const clsgs_PaperGroupENEx_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperGroupENEx.js");
    const clsSysPara4WebApi2_js_1 = require("../../PubFun/clsSysPara4WebApi2.js");
    var ResponseData;
    class clsgs_PaperGroupExWApi {
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4TypeScript:Gen_4WAEx_Ts_ClassConstructor)
        /// </summary>
        constructor() {
            this.objgs_PaperGroupEN = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
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
        /// <param name = "objgs_PaperGroupENS">源对象</param>
        /// <param name = "objgs_PaperGroupENT">目标对象</param>
        static CopyToEx(objgs_PaperGroupENS) {
            var objgs_PaperGroupENT = new clsgs_PaperGroupENEx_js_1.clsgs_PaperGroupENEx();
            objgs_PaperGroupENT.paperGroupId = objgs_PaperGroupENS.paperGroupId; //组Id
            objgs_PaperGroupENT.paperGroupName = objgs_PaperGroupENS.paperGroupName; //组名
            objgs_PaperGroupENT.updUser = objgs_PaperGroupENS.updUser; //修改人
            objgs_PaperGroupENT.updDate = objgs_PaperGroupENS.updDate; //修改日期
            objgs_PaperGroupENT.meno = objgs_PaperGroupENS.meno; //备注
            objgs_PaperGroupENT.sf_UpdFldSetStr = objgs_PaperGroupENS.updFldString; //专门用于记录某字段属性是否修改
            objgs_PaperGroupENT.sf_FldComparisonOp = objgs_PaperGroupENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符
            return objgs_PaperGroupENT;
        }
    }
    exports.clsgs_PaperGroupExWApi = clsgs_PaperGroupExWApi;
    clsgs_PaperGroupExWApi.mstrController = "gs_PaperGroupExApi";
    ;
});
