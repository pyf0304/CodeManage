import { Dictionary } from "./tzDictionary.js";

export class stuRangePara {
    
    /// <summary>
    /// 记录范围的最小记录号
    /// </summary>
    public MinNum: number = 0;
    /// <summary>
    /// 记录范围的最大记录号
    /// </summary>
    public MaxNum: number = 0;
       
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
    //public MinNum: Array<string> = new Array<string>();

    ///// <summary>
    ///// 是否检查SQL攻击
    ///// </summary>
    //public IsCheckSQLAttack: boolean = false;

    public static GetMapParam(objRangePara: stuRangePara): Dictionary {
        //List < string > arrLst = new List<string>(objRangePara.MinNum);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("strWhereCond", objRangePara.WhereCond);
        mapParam.add("strOrderBy", objRangePara.OrderBy);
        mapParam.add("intMaxNum", objRangePara.MaxNum.toString());
        mapParam.add("intMinNum", objRangePara.MinNum.toString());

        return mapParam;
        //var mapParam: Dictionary = new Dictionary()
        //{
        //    "strWhereCond" = objRangePara.WhereCond,
        //        "strOrderBy" = objRangePara.OrderBy,
        //        "intMaxNum" = objRangePara.MaxNum.toString(),
        //        ["arrMinNum"] = clsArray.GetSqlInStrByArray(arrLst, false),
        //        ["bolIsCheckSQLAttack"] = objRangePara.IsCheckSQLAttack.ToString(),
        //    };
        //return dictParam;
    }
}