import { Dictionary } from "./tzDictionary";

export class stuRoleMenuByRoleIdsPara {
    
    /// <summary>
    /// 工程id
    /// </summary>
    public QxPrjId: string = "";
    /// <summary>
    /// 角色Id列表
    /// </summary>
    
    public  RoleIdLst:Array<string> = []
    /// <summary>
    /// 菜单集Id
    /// </summary>
    public MenuSetId: string = "";
    /// <summary>
    /// 是否是上级菜单
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

    public static GetMapParam(objRoleMenuByRoleIdsPara: stuRoleMenuByRoleIdsPara): Dictionary {
        //List < string > arrLst = new List<string>(objRoleMenuByRoleIdsPara.QxPrjId);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("MenuSetId", objRoleMenuByRoleIdsPara.MenuSetId);
        mapParam.add("IsUpMenuId", objRoleMenuByRoleIdsPara.IsUpMenuId);
        mapParam.add("RoleIdLst", objRoleMenuByRoleIdsPara.RoleIdLst.join(','));
        mapParam.add("QxPrjId", objRoleMenuByRoleIdsPara.QxPrjId);

        return mapParam;
     
    }
}