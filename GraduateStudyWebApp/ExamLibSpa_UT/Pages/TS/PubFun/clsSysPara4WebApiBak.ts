/*
 * 功能：用于WebApi的参数定义
 * 版本：2019-07-24-01
 * 作者：潘以锋
 * */

export class clsSysPara4WebApiBak {
    public static bolIsLocalHost: boolean = false;
    //var CurrIPAddressAndPort = "http://Localhost:2408";
    //    public static CurrIPAddressAndPort:string = getHostAddress_web();// "http://Localhost:2408";
    public static CurrIPAddressAndPort: string = "tzar.tpddns.cn:9080";// getHostAddress_web();// "http://Localhost:2408";
    public static CurrIPAddressAndPort_Local: string = "localhost:49540";// getHostAddress_web();// "http://Localhost:2408";

    //public static CurrPrx: string = VirtualRootPath + "/WebApi";
    public static CurrPrx: string = "ExamLibSpa/Api";

    public static CurrIPAddressAndPort_GP: string = "tzar.tpddns.cn:9080";// getHostAddress_web();// "http://Localhost:2408";
    public static CurrIPAddressAndPort_Local_GP: string = "localhost:49540";// getHostAddress_web();// "http://Localhost:2408";

    //public static CurrPrx: string = VirtualRootPath + "/WebApi";
    public static CurrPrx_GP: string = "GP/Api";

    //"http://localhost:2408/ExamLib/WebService/MyTest1Service.asmx";
}