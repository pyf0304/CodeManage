
import { clsSysPara4WebApi } from "../../PubConfig/clsSysPara4WebApi.js";
import { Dictionary } from "../../PubFun/tzDictionary.js";

var ReCallFunc = null;
export class clswxUserInfoExWApi {
    public static mstrController: string = "wxUserInfoExApi";
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
    /// 获取微信信息
    /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCode)
    /// </summary>
    /// <returns>获取的相应对象列表</returns>
    public static GetwxUserInfoAsync(strcode: string): Promise<string> {
        var strAction = "GetwxUserInfo";
        let strUrl = this.GetWebApiUrl(this.mstrController, strAction);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strcode", strcode);
        let strData = mapParam.getParamText();// "例如: strIdentityID =01";
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: strUrl,
                method: "Get",
                dataType: "json",
                data: strData,
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
            strServiceUrl = `${clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
        }
        else {
            strServiceUrl = `${clsSysPara4WebApi.CurrIPAddressAndPort_Local}/${clsSysPara4WebApi.CurrPrx}/${strController}/${strAction}`;
        }
        return strServiceUrl;
    }
};