﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ThemesEN
 表名:cc_Themes(01120069)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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

namespace ExamLib.Entity
{
 /// <summary>
 /// 表cc_Themes的关键字(ThemeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ThemeId_cc_Themes
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strThemeId">表关键字</param>
public K_ThemeId_cc_Themes(string strThemeId)
{
if (IsValid(strThemeId)) Value = strThemeId;
else
{
Value = null;
}
}
private static bool IsValid(string strThemeId)
{
if (string.IsNullOrEmpty(strThemeId) == true) return false;
if (strThemeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ThemeId_cc_Themes]类型的对象</returns>
public static implicit operator K_ThemeId_cc_Themes(string value)
{
return new K_ThemeId_cc_Themes(value);
}
}
 /// <summary>
 /// 课程主题(cc_Themes)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_ThemesEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_Themes"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ThemeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"ThemeId", "ThemeName", "ThemeDesc", "PageName", "ExampleImgPath", "OrderNum", "IsUse", "UpdDate", "UpdUserId", "Memo"};

protected string mstrThemeId;    //主题Id
protected string mstrThemeName;    //主题名
protected string mstrThemeDesc;    //主题描述
protected string mstrPageName;    //页面名称
protected string mstrExampleImgPath;    //示例图路径
protected int? mintOrderNum;    //序号
protected bool mbolIsUse;    //是否使用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_ThemesEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ThemeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strThemeId">关键字:主题Id</param>
public clscc_ThemesEN(string strThemeId)
 {
strThemeId = strThemeId.Replace("'", "''");
if (strThemeId.Length > 4)
{
throw new Exception("在表:cc_Themes中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strThemeId)  ==  true)
{
throw new Exception("在表:cc_Themes中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strThemeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrThemeId = strThemeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ThemeId");
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
if (strAttributeName  ==  concc_Themes.ThemeId)
{
return mstrThemeId;
}
else if (strAttributeName  ==  concc_Themes.ThemeName)
{
return mstrThemeName;
}
else if (strAttributeName  ==  concc_Themes.ThemeDesc)
{
return mstrThemeDesc;
}
else if (strAttributeName  ==  concc_Themes.PageName)
{
return mstrPageName;
}
else if (strAttributeName  ==  concc_Themes.ExampleImgPath)
{
return mstrExampleImgPath;
}
else if (strAttributeName  ==  concc_Themes.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  concc_Themes.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  concc_Themes.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_Themes.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_Themes.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_Themes.ThemeId)
{
mstrThemeId = value.ToString();
 AddUpdatedFld(concc_Themes.ThemeId);
}
else if (strAttributeName  ==  concc_Themes.ThemeName)
{
mstrThemeName = value.ToString();
 AddUpdatedFld(concc_Themes.ThemeName);
}
else if (strAttributeName  ==  concc_Themes.ThemeDesc)
{
mstrThemeDesc = value.ToString();
 AddUpdatedFld(concc_Themes.ThemeDesc);
}
else if (strAttributeName  ==  concc_Themes.PageName)
{
mstrPageName = value.ToString();
 AddUpdatedFld(concc_Themes.PageName);
}
else if (strAttributeName  ==  concc_Themes.ExampleImgPath)
{
mstrExampleImgPath = value.ToString();
 AddUpdatedFld(concc_Themes.ExampleImgPath);
}
else if (strAttributeName  ==  concc_Themes.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Themes.OrderNum);
}
else if (strAttributeName  ==  concc_Themes.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Themes.IsUse);
}
else if (strAttributeName  ==  concc_Themes.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_Themes.UpdDate);
}
else if (strAttributeName  ==  concc_Themes.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_Themes.UpdUserId);
}
else if (strAttributeName  ==  concc_Themes.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_Themes.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_Themes.ThemeId  ==  AttributeName[intIndex])
{
return mstrThemeId;
}
else if (concc_Themes.ThemeName  ==  AttributeName[intIndex])
{
return mstrThemeName;
}
else if (concc_Themes.ThemeDesc  ==  AttributeName[intIndex])
{
return mstrThemeDesc;
}
else if (concc_Themes.PageName  ==  AttributeName[intIndex])
{
return mstrPageName;
}
else if (concc_Themes.ExampleImgPath  ==  AttributeName[intIndex])
{
return mstrExampleImgPath;
}
else if (concc_Themes.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (concc_Themes.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (concc_Themes.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_Themes.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_Themes.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_Themes.ThemeId  ==  AttributeName[intIndex])
{
mstrThemeId = value.ToString();
 AddUpdatedFld(concc_Themes.ThemeId);
}
else if (concc_Themes.ThemeName  ==  AttributeName[intIndex])
{
mstrThemeName = value.ToString();
 AddUpdatedFld(concc_Themes.ThemeName);
}
else if (concc_Themes.ThemeDesc  ==  AttributeName[intIndex])
{
mstrThemeDesc = value.ToString();
 AddUpdatedFld(concc_Themes.ThemeDesc);
}
else if (concc_Themes.PageName  ==  AttributeName[intIndex])
{
mstrPageName = value.ToString();
 AddUpdatedFld(concc_Themes.PageName);
}
else if (concc_Themes.ExampleImgPath  ==  AttributeName[intIndex])
{
mstrExampleImgPath = value.ToString();
 AddUpdatedFld(concc_Themes.ExampleImgPath);
}
else if (concc_Themes.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_Themes.OrderNum);
}
else if (concc_Themes.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_Themes.IsUse);
}
else if (concc_Themes.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_Themes.UpdDate);
}
else if (concc_Themes.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_Themes.UpdUserId);
}
else if (concc_Themes.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_Themes.Memo);
}
}
}

/// <summary>
/// 主题Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ThemeId
{
get
{
return mstrThemeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrThemeId = value;
}
else
{
 mstrThemeId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Themes.ThemeId);
}
}
/// <summary>
/// 主题名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ThemeName
{
get
{
return mstrThemeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrThemeName = value;
}
else
{
 mstrThemeName = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Themes.ThemeName);
}
}
/// <summary>
/// 主题描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ThemeDesc
{
get
{
return mstrThemeDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrThemeDesc = value;
}
else
{
 mstrThemeDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Themes.ThemeDesc);
}
}
/// <summary>
/// 页面名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageName
{
get
{
return mstrPageName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageName = value;
}
else
{
 mstrPageName = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Themes.PageName);
}
}
/// <summary>
/// 示例图路径(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExampleImgPath
{
get
{
return mstrExampleImgPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExampleImgPath = value;
}
else
{
 mstrExampleImgPath = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Themes.ExampleImgPath);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(concc_Themes.OrderNum);
}
}
/// <summary>
/// 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUse
{
get
{
return mbolIsUse;
}
set
{
 mbolIsUse = value;
//记录修改过的字段
 AddUpdatedFld(concc_Themes.IsUse);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Themes.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Themes.UpdUserId);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_Themes.Memo);
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
  return mstrThemeId;
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
  return mstrThemeName;
 }
 }
}
 /// <summary>
 /// 课程主题(cc_Themes)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_Themes
{
public const string _CurrTabName = "cc_Themes"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ThemeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ThemeId", "ThemeName", "ThemeDesc", "PageName", "ExampleImgPath", "OrderNum", "IsUse", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ThemeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThemeId = "ThemeId";    //主题Id

 /// <summary>
 /// 常量:"ThemeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThemeName = "ThemeName";    //主题名

 /// <summary>
 /// 常量:"ThemeDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThemeDesc = "ThemeDesc";    //主题描述

 /// <summary>
 /// 常量:"PageName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageName = "PageName";    //页面名称

 /// <summary>
 /// 常量:"ExampleImgPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExampleImgPath = "ExampleImgPath";    //示例图路径

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"IsUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUse = "IsUse";    //是否使用

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}