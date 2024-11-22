﻿/*
 * 功能：为Web提供下拉框对象类
 * 版本：2019-08-03-01
 * 作者：潘以锋
 * */

/// <summary>
/// 下拉框对象类
/// </summary>
export class clsCboObject {

    /*
    /// <param name="strValue"></param>
    /// <param name="strText"></param>
    */
    constructor(strValue: string, strText: string) {
        this.Value = strValue;
        this.Text = strText;
    }
    /// <summary>
    /// 值
    /// </summary>
    public Value: string = "";
    /// <summary>
    /// 文本
    /// </summary>
    public Text: string = "";
    /// <summary>
    /// 常量:"Text"
    /// </summary>
    public static get con_Text(): string { return "Text"; };    //文本
    /// <summary>
    /// 常量:"Value"
    /// </summary>
    public static get con_Value(): string { return "Value"; }    //值

}
