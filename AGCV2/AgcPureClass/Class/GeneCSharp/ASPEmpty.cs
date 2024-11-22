﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPEmpty
 表名:ASPEmpty(00050432)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:29
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)
 模块中文名:生成C#代码(GeneCSharp)
 框架-层名:纯粹类(PureClass)
 编程语言:CSharp
 注意:1、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
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
 /// ASP空(ASPEmpty)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPEmpty : ASPControlEx
{
protected new const int mintAttributeCount = 2;
public new static string[] AttributeName = new string[] {"AspEmptyId", "AspEmptyName"};
//以下是属性变量

protected string mstrAspEmptyId;    //ASP空Id
protected string mstrAspEmptyName;    //ASP空名


 /// <summary>
 /// 常量:"AspEmptyId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspEmptyId = "AspEmptyId";    //ASP空Id

 /// <summary>
 /// 常量:"AspEmptyName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspEmptyName = "AspEmptyName";    //ASP空名

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPEmpty()
 {
 }

public new static int AttributeCount
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
public new object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_AspEmptyId)
{
return mstrAspEmptyId;
}
else if (strAttributeName  ==  con_AspEmptyName)
{
return mstrAspEmptyName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspEmptyId)
{
mstrAspEmptyId = value.ToString();
}
else if (strAttributeName  ==  con_AspEmptyName)
{
mstrAspEmptyName = value.ToString();
}
}
}
/// <summary>
/// 类索引器(Indexer)函数, 整型(INT)序号参数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClsIndexer)
/// </summary>
public new object this[int intIndex]
{
get
{
if (con_AspEmptyId  ==  AttributeName[intIndex])
{
return mstrAspEmptyId;
}
else if (con_AspEmptyName  ==  AttributeName[intIndex])
{
return mstrAspEmptyName;
}
return null;
}
set
{
if (con_AspEmptyId  ==  AttributeName[intIndex])
{
mstrAspEmptyId = value.ToString();
}
else if (con_AspEmptyName  ==  AttributeName[intIndex])
{
mstrAspEmptyName = value.ToString();
}
}
}

/// <summary>
/// ASP空Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspEmptyId
{
get
{
return mstrAspEmptyId;
}
set
{
if (value  ==  "")
{
 mstrAspEmptyId = value;
}
else
{
 mstrAspEmptyId = value;
}
}
}
/// <summary>
/// ASP空名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspEmptyName
{
get
{
return mstrAspEmptyName;
}
set
{
if (value  ==  "")
{
 mstrAspEmptyName = value;
}
else
{
 mstrAspEmptyName = value;
}
}
}
}
}