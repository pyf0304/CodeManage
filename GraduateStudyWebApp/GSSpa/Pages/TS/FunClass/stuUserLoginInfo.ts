import { Dictionary } from "../PubFun/tzDictionary.js";
//import { clsvUserRoleRelationEN } from "../L0_Entity/UserManage/clsvUserRoleRelationEN.js";
import { clsvQxUserRoleRelationEN } from "../L0_Entity/UsersRight/clsvQxUserRoleRelationEN.js";

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
    public roleId: string = "";
    /// <summary>
    /// 角色
    /// </summary>
    public roleName: string = "";
    /// <summary>
    /// 用户Id
    /// </summary>
    public userId: string = "";
    /// <summary>
    /// 用户名
    /// </summary>
    public userName: string = "";

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

    /// <summary>
    /// 课程Id
    /// </summary>        
    public courseId: string = "";

    /// <summary>
    /// 论文Id
    /// </summary>        
    public ThesisId: string = "";

    /// <summary>
    /// 专业id
    /// </summary>        
    public id_XzMajor: string = "";
    

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
        mapParam.add("userId", objUserLoginInfo.userId);
        mapParam.add("userName", objUserLoginInfo.userName);
        mapParam.add("roleId", objUserLoginInfo.roleId);
        mapParam.add("roleName", objUserLoginInfo.roleName);
        mapParam.add("CurrSelPrjId", objUserLoginInfo.CurrSelPrjId);
        mapParam.add("CurrSelPrjName", objUserLoginInfo.CurrSelPrjName);

        mapParam.add("courseId", objUserLoginInfo.courseId);

        mapParam.add("ThesisId", objUserLoginInfo.ThesisId);

        mapParam.add("CurrPrjDataBaseId", objUserLoginInfo.CurrPrjDataBaseId);
        mapParam.add("PrjDataBaseName", objUserLoginInfo.PrjDataBaseName);
        mapParam.add("CurrDataBaseTypeId", objUserLoginInfo.CurrDataBaseTypeId);
        mapParam.add("ApplicationTypeId", objUserLoginInfo.ApplicationTypeId);
        mapParam.add("id_XzMajor", objUserLoginInfo.id_XzMajor);
        

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

    public static GetObjByHtmlString2(strvUserRoleRelation: string): clsvQxUserRoleRelationEN {
        var strUserLoginInfo2 = $.parseHTML(strvUserRoleRelation);
        var objvUserRoleRelation: clsvQxUserRoleRelationEN = JSON.parse(strUserLoginInfo2[0].wholeText);
        return objvUserRoleRelation;
    }
}