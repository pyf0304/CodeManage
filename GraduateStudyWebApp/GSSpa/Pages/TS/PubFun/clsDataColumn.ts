﻿/*
 * 功能:数据列，为绑定数据表定义列信息
 * 版本:2019-07-24-01
 * 作者:潘以锋
 * */
export class clsDataColumn {

    //以下是属性变量

    /// <summary>
    /// 构造函数
    /// (AutoGCLib.EntityLayer4TypeScript:GenClassConstructor1)
    /// </summary>
    constructor() {
      
    }

    public fldName: string = "";    //数据字段名
    public sortBy: any = "";    //排序表达式
    public sortFun: Function = () => { };    //函数
    public getDataSource = "";//WebCache(Web缓存),WebApi(后台获取)
    public colHeader: string = "";    //列头名
    public text: string = "";    //Button Text
    public tdClass: string = "text-left";
    public orderNum: number = 0;    //次序
    public columnType: string = "";    //列类型:Label,TextBox,Button
    public funcName: Function = () => { };    //单击事件名

};