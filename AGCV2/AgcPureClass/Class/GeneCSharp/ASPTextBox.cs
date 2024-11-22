﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ASPTextBox
 表名:ASPTextBox(00050224)
 生成代码版本:2021.11.17.1
 生成日期:2021/11/18 02:09:26
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
 /// ASP文本框(ASPTextBox)
 /// (AutoGCLib.PureClass4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class ASPTextBox : ASPControlEx
{
protected new const int mintAttributeCount = 3;
public new static string[] AttributeName = new string[] {"AspTextBoxId", "AspTextBoxName", "placeholder"};
//以下是属性变量

protected string mstrAspTextBoxId;    //ASP文本框Id
protected string mstrAspTextBoxName;    //ASP文本框名称
protected string mstrplaceholder;    //placeholder


 /// <summary>
 /// 常量:"AspTextBoxId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspTextBoxId = "AspTextBoxId";    //ASP文本框Id

 /// <summary>
 /// 常量:"AspTextBoxName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AspTextBoxName = "AspTextBoxName";    //ASP文本框名称

 /// <summary>
 /// 常量:"placeholder"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_placeholder = "placeholder";    //placeholder

/// <summary>
/// 构造函数
 /// (AutoGCLib.PureClass4CSharp:Gen_PC_ClassConstructor)
/// </summary>
 public ASPTextBox()
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
if (strAttributeName  ==  con_AspTextBoxId)
{
return mstrAspTextBoxId;
}
else if (strAttributeName  ==  con_AspTextBoxName)
{
return mstrAspTextBoxName;
}
else if (strAttributeName  ==  con_placeholder)
{
return mstrplaceholder;
}
return null;
}
set
{
if (strAttributeName  ==  con_AspTextBoxId)
{
mstrAspTextBoxId = value.ToString();
}
else if (strAttributeName  ==  con_AspTextBoxName)
{
mstrAspTextBoxName = value.ToString();
}
else if (strAttributeName  ==  con_placeholder)
{
mstrplaceholder = value.ToString();
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
if (con_AspTextBoxId  ==  AttributeName[intIndex])
{
return mstrAspTextBoxId;
}
else if (con_AspTextBoxName  ==  AttributeName[intIndex])
{
return mstrAspTextBoxName;
}
else if (con_placeholder  ==  AttributeName[intIndex])
{
return mstrplaceholder;
}
return null;
}
set
{
if (con_AspTextBoxId  ==  AttributeName[intIndex])
{
mstrAspTextBoxId = value.ToString();
}
else if (con_AspTextBoxName  ==  AttributeName[intIndex])
{
mstrAspTextBoxName = value.ToString();
}
else if (con_placeholder  ==  AttributeName[intIndex])
{
mstrplaceholder = value.ToString();
}
}
}

/// <summary>
/// ASP文本框Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspTextBoxId
{
get
{
return mstrAspTextBoxId;
}
set
{
if (value  ==  "")
{
 mstrAspTextBoxId = value;
}
else
{
 mstrAspTextBoxId = value;
}
}
}
/// <summary>
/// ASP文本框名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string AspTextBoxName
{
get
{
return mstrAspTextBoxName;
}
set
{
if (value  ==  "")
{
 mstrAspTextBoxName = value;
}
else
{
 mstrAspTextBoxName = value;
}
}
}
/// <summary>
/// placeholder(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString4PureClass)
/// </summary>
  [DataMember]//非常重要
 public string placeholder
{
get
{
return mstrplaceholder;
}
set
{
if (value  ==  "")
{
 mstrplaceholder = value;
}
else
{
 mstrplaceholder = value;
}
}
}
}
}