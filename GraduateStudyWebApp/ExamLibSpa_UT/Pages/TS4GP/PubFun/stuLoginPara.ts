import { Dictionary } from "./tzDictionary.js";

export class stuLoginPara {
    
    /// <summary>
    /// 每页记录数
    /// </summary>
    public QxPrjId: string = "";
    /// <summary>
    /// 页序号
    /// </summary>
    public EffectiveDate: string = "";
       
    /// <summary>
    /// 条件串
    /// </summary>
    public LoginName: string = "";
    /// <summary>
    /// 排序表达式
    /// </summary>
    public UserPassword: string = "";

    ///// <summary>
    ///// 排除的检查字符串列表
    ///// </summary>
    //public QxPrjId: Array<string> = new Array<string>();

    ///// <summary>
    ///// 是否检查SQL攻击
    ///// </summary>
    //public IsCheckSQLAttack: boolean = false;

    public static GetMapParam(objLoginPara: stuLoginPara): Dictionary {
        //List < string > arrLst = new List<string>(objLoginPara.QxPrjId);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strLoginName", objLoginPara.LoginName);
        mapParam.add("strUserPassword", objLoginPara.UserPassword);
        mapParam.add("intEffectiveDate", objLoginPara.EffectiveDate);
        mapParam.add("intQxPrjId", objLoginPara.QxPrjId);

        return mapParam;
     
    }
}