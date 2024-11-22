/*-- -- -- -- -- -- -- -- -- -- --
类名:clsPaperWApi
表名:Paper(01120547)
生成代码版本:2020.01.02.1
生成日期:2020/01/02 16:12:20
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_访问层(WA_Access)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == ==
*/
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "axios", "../../PubFun/clsString.js", "../../PubConfig/clsSysPara4WebApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsIndexExWApi = void 0;
    /// <summary>
    /// 论文读写表(Paper)
    /// (AutoGCLib.WA_Access4TypeScript:GeneCode)
    /// </summary>
    /**
    * Created by  on 2020年01月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
    */
    ///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as QQ from "q";
    const axios_1 = __importDefault(require("axios"));
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    var ResponseData;
    class clsIndexExWApi {
        /// <summary>
        /// 根据条件获取相应的记录对象列表
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
        /// </summary>
        /// <param name = "strWhereCond">条件</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        static async GetAllCountAsync(strUserId) {
            const strThisFuncName = "GetAllCountAsync";
            var strAction = "GetAllCount";
            let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
            //var mapParam: Dictionary = new Dictionary();
            //mapParam.add("strUserId", strUserId);
            //let strData = mapParam.getParamText();// "例如: strIdentityID =01";
            try {
                const response = await axios_1.default.get(strUrl, {
                    params: { "strUserId": strUserId }
                });
                const data = response.data;
                if (data.errorId == 0) {
                    const returnStr = data.returnStr;
                    if (returnStr == null) {
                        const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", this.mstrController, strThisFuncName);
                        console.error(strNullInfo);
                        throw (strNullInfo);
                    }
                    //console.log(returnObjLst);
                    //const arrObjLst = returnStr;
                    return (returnStr);
                }
                else {
                    console.error(data.errorMsg);
                    throw (data.errorMsg);
                }
            }
            catch (error) {
                console.error(error);
                if (error.statusText == undefined) {
                    throw error;
                }
                if (error.statusText == "error") {
                    const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, this.mstrController, strThisFuncName);
                    console.error(strInfo);
                    throw (strInfo);
                }
                else if (error.statusText == "Not Found") {
                    const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, this.mstrController, strThisFuncName);
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
        static GetWebApiUrl(strController, strAction) {
            var strServiceUrl;
            if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
                strServiceUrl = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
            }
            else {
                strServiceUrl = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
            }
            return strServiceUrl;
        }
    }
    exports.clsIndexExWApi = clsIndexExWApi;
    clsIndexExWApi.mstrController = "IndexExApi";
});
