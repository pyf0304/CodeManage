﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsButtonStyleEN
 表名:ButtonStyle(00050054)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 12:06:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
 框架-层名:实体层(CS)(EntityLayer,0001)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace AGC.Entity
{
 /// <summary>
 /// 表ButtonStyle的关键字(ButtonStyleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ButtonStyleId_ButtonStyle
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strButtonStyleId">表关键字</param>
public K_ButtonStyleId_ButtonStyle(string strButtonStyleId)
{
if (IsValid(strButtonStyleId)) Value = strButtonStyleId;
else
{
Value = null;
}
}
private static bool IsValid(string strButtonStyleId)
{
if (string.IsNullOrEmpty(strButtonStyleId) == true) return false;
if (strButtonStyleId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ButtonStyleId_ButtonStyle]类型的对象</returns>
public static implicit operator K_ButtonStyleId_ButtonStyle(string value)
{
return new K_ButtonStyleId_ButtonStyle(value);
}
}
 /// <summary>
 /// 按钮样式(ButtonStyle)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsButtonStyleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ButtonStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ButtonStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"ButtonStyleId", "ButtonStyleName", "CssClass", "Style", "Runat", "FontSize", "FontName", "Width", "Height", "StyleZindex", "StyleLeft", "StylePosition", "StyleTop"};

protected string mstrButtonStyleId;    //按钮样式Id
protected string mstrButtonStyleName;    //按钮样式名
protected string mstrCssClass;    //样式表
protected string mstrStyle;    //类型
protected string mstrRunat;    //运行在
protected string mstrFontSize;    //字号
protected string mstrFontName;    //字体
protected int mintWidth;    //宽
protected int mintHeight;    //高度
protected int mintStyleZindex;    //Style_Zindex
protected int mintStyleLeft;    //Style_Left
protected string mstrStylePosition;    //Style_Position
protected int mintStyleTop;    //Style_Top

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsButtonStyleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ButtonStyleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strButtonStyleId">关键字:按钮样式Id</param>
public clsButtonStyleEN(string strButtonStyleId)
 {
strButtonStyleId = strButtonStyleId.Replace("'", "''");
if (strButtonStyleId.Length > 4)
{
throw new Exception("在表:ButtonStyle中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strButtonStyleId)  ==  true)
{
throw new Exception("在表:ButtonStyle中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strButtonStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrButtonStyleId = strButtonStyleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ButtonStyleId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conButtonStyle.ButtonStyleId)
{
return mstrButtonStyleId;
}
else if (strAttributeName  ==  conButtonStyle.ButtonStyleName)
{
return mstrButtonStyleName;
}
else if (strAttributeName  ==  conButtonStyle.CssClass)
{
return mstrCssClass;
}
else if (strAttributeName  ==  conButtonStyle.Style)
{
return mstrStyle;
}
else if (strAttributeName  ==  conButtonStyle.Runat)
{
return mstrRunat;
}
else if (strAttributeName  ==  conButtonStyle.FontSize)
{
return mstrFontSize;
}
else if (strAttributeName  ==  conButtonStyle.FontName)
{
return mstrFontName;
}
else if (strAttributeName  ==  conButtonStyle.Width)
{
return mintWidth;
}
else if (strAttributeName  ==  conButtonStyle.Height)
{
return mintHeight;
}
else if (strAttributeName  ==  conButtonStyle.StyleZindex)
{
return mintStyleZindex;
}
else if (strAttributeName  ==  conButtonStyle.StyleLeft)
{
return mintStyleLeft;
}
else if (strAttributeName  ==  conButtonStyle.StylePosition)
{
return mstrStylePosition;
}
else if (strAttributeName  ==  conButtonStyle.StyleTop)
{
return mintStyleTop;
}
return null;
}
set
{
if (strAttributeName  ==  conButtonStyle.ButtonStyleId)
{
mstrButtonStyleId = value.ToString();
 AddUpdatedFld(conButtonStyle.ButtonStyleId);
}
else if (strAttributeName  ==  conButtonStyle.ButtonStyleName)
{
mstrButtonStyleName = value.ToString();
 AddUpdatedFld(conButtonStyle.ButtonStyleName);
}
else if (strAttributeName  ==  conButtonStyle.CssClass)
{
mstrCssClass = value.ToString();
 AddUpdatedFld(conButtonStyle.CssClass);
}
else if (strAttributeName  ==  conButtonStyle.Style)
{
mstrStyle = value.ToString();
 AddUpdatedFld(conButtonStyle.Style);
}
else if (strAttributeName  ==  conButtonStyle.Runat)
{
mstrRunat = value.ToString();
 AddUpdatedFld(conButtonStyle.Runat);
}
else if (strAttributeName  ==  conButtonStyle.FontSize)
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conButtonStyle.FontSize);
}
else if (strAttributeName  ==  conButtonStyle.FontName)
{
mstrFontName = value.ToString();
 AddUpdatedFld(conButtonStyle.FontName);
}
else if (strAttributeName  ==  conButtonStyle.Width)
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conButtonStyle.Width);
}
else if (strAttributeName  ==  conButtonStyle.Height)
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conButtonStyle.Height);
}
else if (strAttributeName  ==  conButtonStyle.StyleZindex)
{
mintStyleZindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conButtonStyle.StyleZindex);
}
else if (strAttributeName  ==  conButtonStyle.StyleLeft)
{
mintStyleLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conButtonStyle.StyleLeft);
}
else if (strAttributeName  ==  conButtonStyle.StylePosition)
{
mstrStylePosition = value.ToString();
 AddUpdatedFld(conButtonStyle.StylePosition);
}
else if (strAttributeName  ==  conButtonStyle.StyleTop)
{
mintStyleTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conButtonStyle.StyleTop);
}
}
}
public object this[int intIndex]
{
get
{
if (conButtonStyle.ButtonStyleId  ==  AttributeName[intIndex])
{
return mstrButtonStyleId;
}
else if (conButtonStyle.ButtonStyleName  ==  AttributeName[intIndex])
{
return mstrButtonStyleName;
}
else if (conButtonStyle.CssClass  ==  AttributeName[intIndex])
{
return mstrCssClass;
}
else if (conButtonStyle.Style  ==  AttributeName[intIndex])
{
return mstrStyle;
}
else if (conButtonStyle.Runat  ==  AttributeName[intIndex])
{
return mstrRunat;
}
else if (conButtonStyle.FontSize  ==  AttributeName[intIndex])
{
return mstrFontSize;
}
else if (conButtonStyle.FontName  ==  AttributeName[intIndex])
{
return mstrFontName;
}
else if (conButtonStyle.Width  ==  AttributeName[intIndex])
{
return mintWidth;
}
else if (conButtonStyle.Height  ==  AttributeName[intIndex])
{
return mintHeight;
}
else if (conButtonStyle.StyleZindex  ==  AttributeName[intIndex])
{
return mintStyleZindex;
}
else if (conButtonStyle.StyleLeft  ==  AttributeName[intIndex])
{
return mintStyleLeft;
}
else if (conButtonStyle.StylePosition  ==  AttributeName[intIndex])
{
return mstrStylePosition;
}
else if (conButtonStyle.StyleTop  ==  AttributeName[intIndex])
{
return mintStyleTop;
}
return null;
}
set
{
if (conButtonStyle.ButtonStyleId  ==  AttributeName[intIndex])
{
mstrButtonStyleId = value.ToString();
 AddUpdatedFld(conButtonStyle.ButtonStyleId);
}
else if (conButtonStyle.ButtonStyleName  ==  AttributeName[intIndex])
{
mstrButtonStyleName = value.ToString();
 AddUpdatedFld(conButtonStyle.ButtonStyleName);
}
else if (conButtonStyle.CssClass  ==  AttributeName[intIndex])
{
mstrCssClass = value.ToString();
 AddUpdatedFld(conButtonStyle.CssClass);
}
else if (conButtonStyle.Style  ==  AttributeName[intIndex])
{
mstrStyle = value.ToString();
 AddUpdatedFld(conButtonStyle.Style);
}
else if (conButtonStyle.Runat  ==  AttributeName[intIndex])
{
mstrRunat = value.ToString();
 AddUpdatedFld(conButtonStyle.Runat);
}
else if (conButtonStyle.FontSize  ==  AttributeName[intIndex])
{
mstrFontSize = value.ToString();
 AddUpdatedFld(conButtonStyle.FontSize);
}
else if (conButtonStyle.FontName  ==  AttributeName[intIndex])
{
mstrFontName = value.ToString();
 AddUpdatedFld(conButtonStyle.FontName);
}
else if (conButtonStyle.Width  ==  AttributeName[intIndex])
{
mintWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conButtonStyle.Width);
}
else if (conButtonStyle.Height  ==  AttributeName[intIndex])
{
mintHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conButtonStyle.Height);
}
else if (conButtonStyle.StyleZindex  ==  AttributeName[intIndex])
{
mintStyleZindex = TransNullToInt(value.ToString());
 AddUpdatedFld(conButtonStyle.StyleZindex);
}
else if (conButtonStyle.StyleLeft  ==  AttributeName[intIndex])
{
mintStyleLeft = TransNullToInt(value.ToString());
 AddUpdatedFld(conButtonStyle.StyleLeft);
}
else if (conButtonStyle.StylePosition  ==  AttributeName[intIndex])
{
mstrStylePosition = value.ToString();
 AddUpdatedFld(conButtonStyle.StylePosition);
}
else if (conButtonStyle.StyleTop  ==  AttributeName[intIndex])
{
mintStyleTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conButtonStyle.StyleTop);
}
}
}

/// <summary>
/// 按钮样式Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ButtonStyleId
{
get
{
return mstrButtonStyleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrButtonStyleId = value;
}
else
{
 mstrButtonStyleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conButtonStyle.ButtonStyleId);
}
}
/// <summary>
/// 按钮样式名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ButtonStyleName
{
get
{
return mstrButtonStyleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrButtonStyleName = value;
}
else
{
 mstrButtonStyleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conButtonStyle.ButtonStyleName);
}
}
/// <summary>
/// 样式表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CssClass
{
get
{
return mstrCssClass;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCssClass = value;
}
else
{
 mstrCssClass = value;
}
//记录修改过的字段
 AddUpdatedFld(conButtonStyle.CssClass);
}
}
/// <summary>
/// 类型(说明:;字段类型:varchar;字段长度:800;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Style
{
get
{
return mstrStyle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStyle = value;
}
else
{
 mstrStyle = value;
}
//记录修改过的字段
 AddUpdatedFld(conButtonStyle.Style);
}
}
/// <summary>
/// 运行在(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Runat
{
get
{
return mstrRunat;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRunat = value;
}
else
{
 mstrRunat = value;
}
//记录修改过的字段
 AddUpdatedFld(conButtonStyle.Runat);
}
}
/// <summary>
/// 字号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FontSize
{
get
{
return mstrFontSize;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFontSize = value;
}
else
{
 mstrFontSize = value;
}
//记录修改过的字段
 AddUpdatedFld(conButtonStyle.FontSize);
}
}
/// <summary>
/// 字体(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FontName
{
get
{
return mstrFontName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFontName = value;
}
else
{
 mstrFontName = value;
}
//记录修改过的字段
 AddUpdatedFld(conButtonStyle.FontName);
}
}
/// <summary>
/// 宽(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int Width
{
get
{
return mintWidth;
}
set
{
 mintWidth = value;
//记录修改过的字段
 AddUpdatedFld(conButtonStyle.Width);
}
}
/// <summary>
/// 高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int Height
{
get
{
return mintHeight;
}
set
{
 mintHeight = value;
//记录修改过的字段
 AddUpdatedFld(conButtonStyle.Height);
}
}
/// <summary>
/// Style_Zindex(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int StyleZindex
{
get
{
return mintStyleZindex;
}
set
{
 mintStyleZindex = value;
//记录修改过的字段
 AddUpdatedFld(conButtonStyle.StyleZindex);
}
}
/// <summary>
/// Style_Left(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int StyleLeft
{
get
{
return mintStyleLeft;
}
set
{
 mintStyleLeft = value;
//记录修改过的字段
 AddUpdatedFld(conButtonStyle.StyleLeft);
}
}
/// <summary>
/// Style_Position(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StylePosition
{
get
{
return mstrStylePosition;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStylePosition = value;
}
else
{
 mstrStylePosition = value;
}
//记录修改过的字段
 AddUpdatedFld(conButtonStyle.StylePosition);
}
}
/// <summary>
/// Style_Top(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int StyleTop
{
get
{
return mintStyleTop;
}
set
{
 mintStyleTop = value;
//记录修改过的字段
 AddUpdatedFld(conButtonStyle.StyleTop);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrButtonStyleId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrButtonStyleName;
 }
 }
}
 /// <summary>
 /// 按钮样式(ButtonStyle)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conButtonStyle
{
public const string _CurrTabName = "ButtonStyle"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ButtonStyleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ButtonStyleId", "ButtonStyleName", "CssClass", "Style", "Runat", "FontSize", "FontName", "Width", "Height", "StyleZindex", "StyleLeft", "StylePosition", "StyleTop"};
//以下是属性变量


 /// <summary>
 /// 常量:"ButtonStyleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ButtonStyleId = "ButtonStyleId";    //按钮样式Id

 /// <summary>
 /// 常量:"ButtonStyleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ButtonStyleName = "ButtonStyleName";    //按钮样式名

 /// <summary>
 /// 常量:"CssClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CssClass = "CssClass";    //样式表

 /// <summary>
 /// 常量:"Style"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Style = "Style";    //类型

 /// <summary>
 /// 常量:"Runat"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Runat = "Runat";    //运行在

 /// <summary>
 /// 常量:"FontSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FontSize = "FontSize";    //字号

 /// <summary>
 /// 常量:"FontName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FontName = "FontName";    //字体

 /// <summary>
 /// 常量:"Width"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Width = "Width";    //宽

 /// <summary>
 /// 常量:"Height"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Height = "Height";    //高度

 /// <summary>
 /// 常量:"StyleZindex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleZindex = "StyleZindex";    //Style_Zindex

 /// <summary>
 /// 常量:"StyleLeft"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleLeft = "StyleLeft";    //Style_Left

 /// <summary>
 /// 常量:"StylePosition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StylePosition = "StylePosition";    //Style_Position

 /// <summary>
 /// 常量:"StyleTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StyleTop = "StyleTop";    //Style_Top
}

}