import { Dictionary } from "../PubFun/tzDictionary.js";

export class stuUserLoginInfo {

    /// <summary>
    /// 当前选择工程Id
    /// </summary>
    public CurrSelPrjId: string = "";
    /// <summary>
    /// 当前选择工程
    /// </summary>
    public CurrSelPrjName: string = "";
    /// <summary>
    /// 角色Id
    /// </summary>
    public RoleId: string = "";
    /// <summary>
    /// 角色
    /// </summary>
    public RoleName: string = "";
    /// <summary>
    /// 用户Id
    /// </summary>
    public UserId: string = "";
    /// <summary>
    /// 用户名
    /// </summary>
    public UserName: string = "";

    /// <summary>
    /// 数据库Id
    /// </summary>
    public CurrPrjDataBaseId: string = "";

    /// <summary>
    /// 数据库名
    /// </summary>
    public PrjDataBaseName: string = "";

    /// <summary>
    /// 当前数据库类型Id
    /// </summary>
    public CurrDataBaseTypeId: string = "";
    /// <summary>
    /// 应用类型Id
    /// </summary>        
    public ApplicationTypeId: number = 0;

    ///// <summary>
    ///// 排除的检查字符串列表
    ///// </summary>
    //public CurrSelPrjId: Array<string> = new Array<string>();

    ///// <summary>
    ///// 是否检查SQL攻击
    ///// </summary>
    //public IsCheckSQLAttack: boolean = false;

    public static GetMapParam(objUserLoginInfo: stuUserLoginInfo): Dictionary {
        //List < string > arrLst = new List<string>(objUserLoginInfo.CurrSelPrjId);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("UserId", objUserLoginInfo.UserId);
        mapParam.add("UserName", objUserLoginInfo.UserName);
        mapParam.add("RoleId", objUserLoginInfo.RoleId);
        mapParam.add("RoleName", objUserLoginInfo.RoleName);
        mapParam.add("CurrSelPrjId", objUserLoginInfo.CurrSelPrjId);
        mapParam.add("CurrSelPrjName", objUserLoginInfo.CurrSelPrjName);

        mapParam.add("CurrPrjDataBaseId", objUserLoginInfo.CurrPrjDataBaseId);
        mapParam.add("PrjDataBaseName", objUserLoginInfo.PrjDataBaseName);
        mapParam.add("CurrDataBaseTypeId", objUserLoginInfo.CurrDataBaseTypeId);
        mapParam.add("ApplicationTypeId", objUserLoginInfo.ApplicationTypeId);

        return mapParam;

    }
    /*
     *把Html string 转换成对象。先转换成JSON string , 然后再转换成对象 
     */
    public static GetObjByHtmlString(strUserLoginInfo: string): stuUserLoginInfo {
        var strUserLoginInfo2 = $.parseHTML(strUserLoginInfo);
        var objUserLoginInfo: stuUserLoginInfo = JSON.parse(strUserLoginInfo2[0].wholeText);
        return objUserLoginInfo;
    }
}