/*
 * 功能：数据列，为绑定数据表定义列信息
 * 版本：2019-07-24-01
 * 作者：潘以锋
 * */


export class clsDataColumn {

    //以下是属性变量

    /// <summary>
    /// 构造函数
    /// (AutoGCLib.EntityLayer4TypeScript:GenClassConstructor1)
    /// </summary>
    constructor() {
      
    }
   
    public FldName: string = "";    //考试类型Id
    public ColHeader: string = "";    //考试类型名
    public Text: string = "";    //Button Text
    public TdClass: string = "text-left";
    public SortBy: string = "";    //排序字段
    public OrderNum: number = 0;    //是否删除
    public ColumnType: string = "";    //列类型：Label,TextBox,Button
    public FuncName: Function = () => { };    //备注

};