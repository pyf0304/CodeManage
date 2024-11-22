import { Dictionary } from "./tzDictionary";

export class stuRoleMenuPara {
    
    /// <summary>
    /// 每页记录数
    /// </summary>
    public QxPrjId: string = "";
    /// <summary>
    /// 页序号
    /// </summary>
    public roleId: string = "";
       
    /// <summary>
    /// 条件串
    /// </summary>
    public MenuSetId: string = "";
    /// <summary>
    /// 排序表达式
    /// </summary>
    public IsUpMenuId: string = "";

    ///// <summary>
    ///// 排除的检查字符串列表
    ///// </summary>
    //public QxPrjId: Array<string> = new Array<string>();

    ///// <summary>
    ///// 是否检查SQL攻击
    ///// </summary>
    //public IsCheckSQLAttack: boolean = false;

    public static GetMapParam(objRoleMenuPara: stuRoleMenuPara): Dictionary {
        //List < string > arrLst = new List<string>(objRoleMenuPara.QxPrjId);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("MenuSetId", objRoleMenuPara.MenuSetId);
        mapParam.add("IsUpMenuId", objRoleMenuPara.IsUpMenuId);
        mapParam.add("roleId", objRoleMenuPara.roleId);
        mapParam.add("QxPrjId", objRoleMenuPara.QxPrjId);

        return mapParam;
     
    };
};
