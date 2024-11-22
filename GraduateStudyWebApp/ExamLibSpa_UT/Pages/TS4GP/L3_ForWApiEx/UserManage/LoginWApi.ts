
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUsersWApi
表名:QxUsers(00140015)
生成代码版本:2019.07.15.2
生成日期:2019/07/18 14:54:37
生成者:
生成服务器IP:101.251.68.133
工程名称:统一平台
工程ID:0014
相关数据库:101.251.68.133,9433GeneralPlatformTz
PrjDataBaseId:0184
模块中文名:用户管理
模块英文名:UserManage
框架-层名:WebApi访问层(WA_Access)
编程语言:TypeScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

/// <summary>
/// 用户(QxUsers)
/// (AutoGCLib.WA_Access4TypeScript:GeneCode)
/// </summary>
/**
* Created by  on 2019年07月18日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
///// <reference path="../../../scripts/typings/jquery/jquery.d.ts" />
import * as $ from "jquery";
//import * as QQ from "q";

import { Dictionary } from "../../PubFun/tzDictionary.js";
import { tzResponseData } from "../../PubFun/tzResponseData.js";
import { clsSysPara4WebApi } from "../../pubfun/clssyspara4webapi.js";
import { stuLoginPara } from "../../PubFun/stuLoginPara.js";

var ReCallFunc = null;
export class LoginWApi {
    public static mstrController: string = "LoginApi";
    public Param;
    public NameSpace = "http://tempuri.org/";
    public MethodName = "";
    public WEB_SERVICE_URL = "";
    public soapAction = "";

    constructor(strMethod: string, mapParam, pReCallFunc) {
        this.Param = new Dictionary();
        ReCallFunc = pReCallFunc;
        this.MethodName = strMethod;
        this.Param = mapParam;
        if (this.Param.length() === 0) {
            this.Param = new Dictionary();
        }
    };



    /// <summary>
    /// 用户登录
    /// </summary>
    /// <param name = "objLoginPara">登录登录</param>
    /// <returns>是否存在?存在返回True</returns>
    public static UserLoginAsync(objLoginPara: stuLoginPara): Promise<boolean> {
        //检测记录是否存在
        var strAction = "UserLogin";
        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
        var mapParam: Dictionary = stuLoginPara.GetMapParam(objLoginPara);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objLoginPara,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    }

    /// <summary>
    /// 用户登录
    /// </summary>
    /// <param name = "objLoginPara">登录登录</param>
    /// <returns>是否存在?存在返回True</returns>
    public static UserLogin2Async(objLoginPara: stuLoginPara): Promise<boolean> {
        //检测记录是否存在
        var strAction = "UserLogin2";
        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
        var mapParam: Dictionary = stuLoginPara.GetMapParam(objLoginPara);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objLoginPara,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    }

    /// <summary>
    /// 用户登录
    /// </summary>
    /// <param name = "objLoginPara">登录登录</param>
    /// <returns>是否存在?存在返回True</returns>
    public static UserLoginByPrjIdAsync(objLoginPara: stuLoginPara): Promise<boolean> {
        //检测记录是否存在
        var strAction = "UserLoginByPrjId";
        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
        var mapParam: Dictionary = stuLoginPara.GetMapParam(objLoginPara);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objLoginPara,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    }

    /// <summary>
    /// 用户登录
    /// </summary>
    /// <param name = "objLoginPara">登录登录</param>
    /// <returns>是否存在?存在返回True</returns>
    public static UserLoginWithEffectiveDateAsync(objLoginPara: stuLoginPara): Promise<boolean> {
        //检测记录是否存在
        var strAction = "UserLogin";
        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
        var mapParam: Dictionary = stuLoginPara.GetMapParam(objLoginPara);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "POST",
                dataType: "json",
                data: objLoginPara,
                success: function (data) {
                    var bolIsSuccess = data;
                    if (bolIsSuccess == "false") {
                        return false;
                    }
                    else if (bolIsSuccess == "true") {
                        return true;
                    }
                    else if (bolIsSuccess == "EffectiveDateError") {
                        var strMsg: string = "";
                        strMsg = `用户登录（UserLoginWithEffectiveDate）有问题,由于您(${objLoginPara.LoginName})的用户有效日期出错,请联系系统管理员！当前日期：${objLoginPara.EffectiveDate}.`;
                        throw (strMsg);
                    }
                    return Boolean(bolIsSuccess);
                    //resolve(data);
                },
                error: (e) => {
                    var strErrMsg = decodeURIComponent(e.responseText)
                    reject(e);
                }
            });
        });
    }





    /// <summary>
    /// 根据关键字获取相应的记录的对象
    /// mapParam样例:strUserId = "01"
    ///调用样例:行1:clsQxUsersWS objQxUsersWS = new clsQxUsersWS(mHandler, "GetJSONObjByUserId", values, null);
    ///调用样例:行2:Thread mThread = new Thread(objQxUsersWS);
    ///调用样例:行3:mThread.start();
    /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    /// </summary>
    /// <param name = "strUserId">关键字</param>
    /// <returns>获取相应对象</returns>
    public static GetUserIdByLoginNameAsync(strLoginName: string): Promise<string> {
        var strAction = "GetUserIdByLoginName";
        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strLoginName", strLoginName);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "json",
                data: strData,
                success: function (data) {
                    resolve(data);
                },
                error: (e) => {
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
            strServiceUrl = `http://${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
        }
        else {
            strServiceUrl = `http://${clsSysPara4WebApi.CurrIPAddressAndPort_Local}/${clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
        }
        return strServiceUrl;
    }
};