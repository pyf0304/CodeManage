import { Dictionary } from "../PubFun/tzDictionary.js";

export class stuExcelData {

    /// <summary>
    /// 当前选择工程Id
    /// </summary>
    public Csv: string = "";
    /// <summary>
    /// 当前用户
    /// </summary>
    public userId: string = "";
    /// <summary>
    /// 年级流水号
    /// </summary>
    public Id_Grade: string = "";

    /// <summary>
    /// 是否四舍五入
    /// </summary>
    public bolRound: boolean = true;

    public static GetMapParam(objUserLoginInfo: stuExcelData): Dictionary {
        //Array < string > arrLst = new Array<string>(objUserLoginInfo.CurrSelPrjId);
        var mapParam: Dictionary = new Dictionary();
        mapParam.add("userId", objUserLoginInfo.userId);
        mapParam.add("Csv", objUserLoginInfo.Csv);

        return mapParam;

    }
}