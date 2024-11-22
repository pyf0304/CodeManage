﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPLabel
 表名:ASPLabel(00050222)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:56
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 模块中文名:生成C#代码
 模块英文名:GeneCSharp
 框架-层名:纯粹类(PureClass)
 编程语言:CSharp
 注意:1、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace AGC.PureClass
{
 /// <summary>
 /// ASP标签(ASPLabel)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPLabel : ASPControlEx
{
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"ASPLabelId", "ASPLabelName"};
//以下是属性变量

/// <summary>
/// Asp标签Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPLabelId
{
get
{
return mstrASPLabelId;
}
set
{
if (value  ==  "")
{
 mstrASPLabelId = value;
}
else
{
 mstrASPLabelId = value;
}
}
}
/// <summary>
/// Asp标签名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string ASPLabelName
{
get
{
return mstrASPLabelName;
}
set
{
if (value  ==  "")
{
 mstrASPLabelName = value;
}
else
{
 mstrASPLabelName = value;
}
}
}

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
/// <summary>
/// 类索引器(Indexer)函数,字符串参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_ASPLabelId)
{
return mstrASPLabelId;
}
else if (strAttributeName  ==  con_ASPLabelName)
{
return mstrASPLabelName;
}
return null;
}
set
{
if (strAttributeName  ==  con_ASPLabelId)
{
mstrASPLabelId = value.ToString();
}
else if (strAttributeName  ==  con_ASPLabelName)
{
mstrASPLabelName = value.ToString();
}
}
}
/// <summary>
/// 类索引器(Indexer)函数, 整型(INT)序号参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public object this[int intIndex]
{
get
{
if (con_ASPLabelId  ==  AttributeName[intIndex])
{
return mstrASPLabelId;
}
else if (con_ASPLabelName  ==  AttributeName[intIndex])
{
return mstrASPLabelName;
}
return null;
}
set
{
if (con_ASPLabelId  ==  AttributeName[intIndex])
{
mstrASPLabelId = value.ToString();
}
else if (con_ASPLabelName  ==  AttributeName[intIndex])
{
mstrASPLabelName = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPLabel()
 {
 }


 /// <summary>
 /// 常量:"ASPLabelId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPLabelId = "ASPLabelId";    //Asp标签Id

 /// <summary>
 /// 常量:"ASPLabelName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ASPLabelName = "ASPLabelName";    //Asp标签名

protected string mstrASPLabelId;    //Asp标签Id
protected string mstrASPLabelName;    //Asp标签名
}
}