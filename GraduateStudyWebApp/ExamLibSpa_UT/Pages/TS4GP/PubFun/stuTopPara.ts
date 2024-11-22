﻿import { Dictionary } from "./tzDictionary.js";

export class stuTopPara {

    /// <summary>
    /// 顶部记录数
    /// </summary>    
    public TopSize: number = 0;

    /// <summary>
    /// 条件串
    /// </summary>
    public WhereCond: string = "";
    /// <summary>
    /// 排序表达式
    /// </summary>
    public OrderBy: string = "";

    /// <summary>
    /// 排除的检查字符串列表
    /// </summary>
    public Exclude: string = "";

    /// <summary>
    /// 是否检查SQL攻击
    /// </summary>
    public IsCheckSQLAttack: string = "false";

    public static GetMapParam(objTopPara: stuTopPara): Dictionary {
        //List < string > arrLst = new List<string>(objTopPara.Exclude);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strWhereCond", objTopPara.WhereCond);
        mapParam.add("strOrderBy", objTopPara.OrderBy);
        mapParam.add("intTopSize", objTopPara.TopSize.toString());
        mapParam.add("arrExclude", objTopPara.Exclude);
        mapParam.add("bolIsCheckSQLAttack", objTopPara.IsCheckSQLAttack.toString());
        return mapParam;
        //var mapParam: Dictionary = new Dictionary()
        //{
        //    "strWhereCond" = objTopPara.WhereCond,
        //        "strOrderBy" = objTopPara.OrderBy,
        //        "intTopSize" = objTopPara.TopSize.toString(),
        //        ["arrExclude"] = clsArray.GetSqlInStrByArray(arrLst, false),
        //        ["bolIsCheckSQLAttack"] = objTopPara.IsCheckSQLAttack.ToString(),
        //    };
        //return dictParam;
    }



}