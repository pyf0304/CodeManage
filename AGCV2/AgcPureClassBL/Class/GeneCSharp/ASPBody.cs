﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPBody
 表名:ASPBody(00050215)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/18 10:34:46
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
 /// ASP主体(ASPBody)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPBody : ASPControlEx
{
protected const int mintAttributeCount = 2;
public static string[] AttributeName = new string[] {"AspBodyId", "AspBodyName"};
//以下是属性变量

/// <summary>
/// Asp主体Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspBodyId
{
get
{
return mstrAspBodyId;
}
set
{
if (value  ==  "")
{
 mstrAspBodyId = value;
}
else
{
 mstrAspBodyId = value;
}
}
}
/// <summary>
/// Asp主体名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspBodyName
{
get
{
return mstrAspBodyName;
}
set
{
if (value  ==  "")
{
 mstrAspBodyName = value;
}
else
{
 mstrAspBodyName = value;
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
if (strAttributeName  ==  con_AspBodyId)
{
return mstrAspBodyId;
}
else if (strAttributeName  ==  con_AspBodyName)
{
return mstrAspBodyName;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspBodyId)
{
mstrAspBodyId = value.ToString();
}
else if (strAttributeName  ==  con_AspBodyName)
{
mstrAspBodyName = value.ToString();
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
if (con_AspBodyId  ==  AttributeName[intIndex])
{
return mstrAspBodyId;
}
else if (con_AspBodyName  ==  AttributeName[intIndex])
{
return mstrAspBodyName;
}
return null;
}
set
{
if (con_AspBodyId  ==  AttributeName[intIndex])
{
mstrAspBodyId = value.ToString();
}
else if (con_AspBodyName  ==  AttributeName[intIndex])
{
mstrAspBodyName = value.ToString();
}
}
}

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPBody()
 {
 }


 /// <summary>
 /// 常量:"AspBodyId"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspBodyId = "AspBodyId";    //Asp主体Id

 /// <summary>
 /// 常量:"AspBodyName"
 /// (AGC.PureClassEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspBodyName = "AspBodyName";    //Asp主体名称

protected string mstrAspBodyId;    //Asp主体Id
protected string mstrAspBodyName;    //Asp主体名称
}
}