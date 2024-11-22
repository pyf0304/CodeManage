/*
 * 功能：用于分页获取对象列表的参数结构
 * 版本：2019-07-24-01
 * 作者：潘以锋
 * */


import { Dictionary } from "./tzDictionary.js";

export class stuPagerPara {
    
    /// <summary>
    /// 每页记录数
    /// </summary>
    public PageSize: number = 0;
    /// <summary>
    /// 页序号
    /// </summary>
    public PageIndex: number = 0;
       
    /// <summary>
    /// 条件串
    /// </summary>
    public WhereCond: string = "";
    /// <summary>
    /// 排序表达式
    /// </summary>
    public OrderBy: string = "";

    ///// <summary>
    ///// 排除的检查字符串列表
    ///// </summary>
    //public lstExclude: Array<string> = new Array<string>();

    ///// <summary>
    ///// 是否检查SQL攻击
    ///// </summary>
    //public IsCheckSQLAttack: boolean = false;

    public static GetMapParam(objPagerPara: stuPagerPara): Dictionary {
        //List < string > arrLst = new List<string>(objPagerPara.PageSize);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strWhereCond", objPagerPara.WhereCond);
        mapParam.add("strOrderBy", objPagerPara.OrderBy);
        mapParam.add("intPageIndex", objPagerPara.PageIndex.toString());
        mapParam.add("intPageSize", objPagerPara.PageSize.toString());
        //mapParam.add("lstExclude", objPagerPara.lstExclude);
        return mapParam;
        //var mapParam: Dictionary = new Dictionary()
        //{
        //    "strWhereCond" = objPagerPara.WhereCond,
        //        "strOrderBy" = objPagerPara.OrderBy,
        //        "intPageIndex" = objPagerPara.PageIndex.toString(),
        //        ["arrPageSize"] = clsArray.GetSqlInStrByArray(arrLst, false),
        //        ["bolIsCheckSQLAttack"] = objPagerPara.IsCheckSQLAttack.ToString(),
        //    };
        //return dictParam;
    }
}