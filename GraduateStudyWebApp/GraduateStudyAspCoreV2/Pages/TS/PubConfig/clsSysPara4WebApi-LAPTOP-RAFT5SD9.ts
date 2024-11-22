
/*
 * 功能:用于WebApi的参数定义
 * 版本:2019-07-24-01
 * 作者:潘以锋
 * */

import { Format, IsNullOrEmpty } from "../PubFun/clsString.js";

export class clsSysPara4WebApi {
    public static bolIsLocalHost = false;//true,,,false
    //const CurrIPAddressAndPort = "http://Localhost:2408";
    //    public static CurrIPAddressAndPort:string = getHostAddress_web();// "http://Localhost:2408";

    public static CurrIPAddressAndPort = "https://www.sh-tz.com";// getHostAddress_web();// "http://Localhost:2408";
    public static CurrIPAddressAndPortBak = "http://tzar.tpddns.net:9080";// getHostAddress_web();// "http://Localhost:2408";
//    public static CurrIPAddressAndPort_Local: string = "http://localhost:39541";// getHostAddress_web();// "http://Localhost:2408";
    public static CurrPrx = "ExamLibWA";
    public static CurrPrx2: string = "ExamLibApi/Api";
    public static CurrPrx3: string = "ExamLibApi/Api";
    public static CurrIPAddressAndPort_Local = "http://localhost:28523";// getHostAddress_web();// "http://Localhost:2408";
    //public static CurrPrx: string = VirtualRootPath + "/WebApi";
    //public static CurrPrx = "";
    
    public static CurrIPAddressAndPort_GPBak = "http://103.116.76.183:8080";// getHostAddress_web();// "http://Localhost:2408";
//    public static CurrIPAddressAndPort_GP: string = "http://tzar.tpddns.cn:9080";// getHostAddress_web();// "http://Localhost:2408";
    //public static CurrIPAddressAndPort_Local_GP: string = "http://localhost:49540";// getHostAddress_web();// "http://Localhost:2408";
    public static CurrIPAddressAndPort_Local_GPBak = "http://tzar.tpddns.net:9080";// getHostAddress_web();// "http://Localhost:2408";
    public static CurrIPAddressAndPort_Local_GP = "http://103.116.76.183:8080";// getHostAddress_web();// "http://Localhost:2408";
//    public static CurrIPAddressAndPort_GP = "http://103.116.76.183:8080";// getHostAddress_web();// "http://Localhost:2408";
    public static CurrIPAddressAndPort_GP = "https://www.sh-tz.com";// getHostAddress_web();// "http://Localhost:2408";

    //public static CurrPrx: string = VirtualRootPath + "/WebApi";
    public static CurrPrx_GP = "GpWATz";
    
    public static Url_Session_SetString = "";

    public static spSetRefreshCacheOn = true;
    //"http://localhost:2408/ExamLib/WebService/MyTest1Service.asmx";

    //本地图片
    public static CurrPrx_Local: string = "GraduateStudyWebApp";

    public static cmPrjId = "000012";
    /**
  * 获取WebApi的地址
  * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
  * @returns 返回当前文件中Web服务的地址
 */
   
}

 export function GetWebApiUrl(strController: string, strAction: string): string {
    const strThisFuncName = "GetWebApiUrl";

    let strServiceUrl: string;
    let strCurrIPAddressAndPort = "";
    if (clsSysPara4WebApi.bolIsLocalHost == false) {
        strCurrIPAddressAndPort = clsSysPara4WebApi.CurrIPAddressAndPort;
    }
    else {
        strCurrIPAddressAndPort = clsSysPara4WebApi.CurrIPAddressAndPort_Local;
    }
    if (IsNullOrEmpty(clsSysPara4WebApi.CurrPrx) == true) {
        strServiceUrl = Format("{0}/{1}/{2}", strCurrIPAddressAndPort, strController, strAction);
    }
    else {
        strServiceUrl = Format("{0}/{1}/{2}/{3}", strCurrIPAddressAndPort, clsSysPara4WebApi.CurrPrx, strController, strAction);
    }
    return strServiceUrl;
}