
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionMenuEN
 表名:FunctionMenu(01120475)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:12
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
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

namespace ExamLib.Entity
{
 /// <summary>
 /// 表FunctionMenu的关键字(FunctionMenuId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FunctionMenuId_FunctionMenu
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFunctionMenuId">表关键字</param>
public K_FunctionMenuId_FunctionMenu(string strFunctionMenuId)
{
if (IsValid(strFunctionMenuId)) Value = strFunctionMenuId;
else
{
Value = null;
}
}
private static bool IsValid(string strFunctionMenuId)
{
if (string.IsNullOrEmpty(strFunctionMenuId) == true) return false;
if (strFunctionMenuId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FunctionMenuId_FunctionMenu]类型的对象</returns>
public static implicit operator K_FunctionMenuId_FunctionMenu(string value)
{
return new K_FunctionMenuId_FunctionMenu(value);
}
}
 /// <summary>
 /// 功能菜单(FunctionMenu)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFunctionMenuEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FunctionMenu"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FunctionMenuId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"FunctionMenuId", "FunctionName", "TitleName", "IsVisible", "DispPageMode", "IsTransUserBySingleSignOn", "IsWithParameter", "HyperLink", "HyperLink4NoUser", "SingleSignOnKey", "SchoolId", "UpdDate", "UpdUserId", "Memo"};

protected string mstrFunctionMenuId;    //功能菜单ID
protected string mstrFunctionName;    //函数名
protected string mstrTitleName;    //功能菜单标题
protected bool mbolIsVisible;    //是否显示
protected string mstrDispPageMode;    //显示页面方式
protected bool mbolIsTransUserBySingleSignOn;    //是否单点登录传用户信息
protected bool mbolIsWithParameter;    //是否带参数
protected string mstrHyperLink;    //超链接
protected string mstrHyperLink4NoUser;    //超链接针对无用户
protected string mstrSingleSignOnKey;    //单点登录关键字
protected string mstrSchoolId;    //学校编号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsFunctionMenuEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FunctionMenuId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strFunctionMenuId">关键字:功能菜单ID</param>
public clsFunctionMenuEN(string strFunctionMenuId)
 {
strFunctionMenuId = strFunctionMenuId.Replace("'", "''");
if (strFunctionMenuId.Length > 4)
{
throw new Exception("在表:FunctionMenu中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFunctionMenuId)  ==  true)
{
throw new Exception("在表:FunctionMenu中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFunctionMenuId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFunctionMenuId = strFunctionMenuId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FunctionMenuId");
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
if (strAttributeName  ==  conFunctionMenu.FunctionMenuId)
{
return mstrFunctionMenuId;
}
else if (strAttributeName  ==  conFunctionMenu.FunctionName)
{
return mstrFunctionName;
}
else if (strAttributeName  ==  conFunctionMenu.TitleName)
{
return mstrTitleName;
}
else if (strAttributeName  ==  conFunctionMenu.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conFunctionMenu.DispPageMode)
{
return mstrDispPageMode;
}
else if (strAttributeName  ==  conFunctionMenu.IsTransUserBySingleSignOn)
{
return mbolIsTransUserBySingleSignOn;
}
else if (strAttributeName  ==  conFunctionMenu.IsWithParameter)
{
return mbolIsWithParameter;
}
else if (strAttributeName  ==  conFunctionMenu.HyperLink)
{
return mstrHyperLink;
}
else if (strAttributeName  ==  conFunctionMenu.HyperLink4NoUser)
{
return mstrHyperLink4NoUser;
}
else if (strAttributeName  ==  conFunctionMenu.SingleSignOnKey)
{
return mstrSingleSignOnKey;
}
else if (strAttributeName  ==  conFunctionMenu.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  conFunctionMenu.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFunctionMenu.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conFunctionMenu.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFunctionMenu.FunctionMenuId)
{
mstrFunctionMenuId = value.ToString();
 AddUpdatedFld(conFunctionMenu.FunctionMenuId);
}
else if (strAttributeName  ==  conFunctionMenu.FunctionName)
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(conFunctionMenu.FunctionName);
}
else if (strAttributeName  ==  conFunctionMenu.TitleName)
{
mstrTitleName = value.ToString();
 AddUpdatedFld(conFunctionMenu.TitleName);
}
else if (strAttributeName  ==  conFunctionMenu.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunctionMenu.IsVisible);
}
else if (strAttributeName  ==  conFunctionMenu.DispPageMode)
{
mstrDispPageMode = value.ToString();
 AddUpdatedFld(conFunctionMenu.DispPageMode);
}
else if (strAttributeName  ==  conFunctionMenu.IsTransUserBySingleSignOn)
{
mbolIsTransUserBySingleSignOn = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunctionMenu.IsTransUserBySingleSignOn);
}
else if (strAttributeName  ==  conFunctionMenu.IsWithParameter)
{
mbolIsWithParameter = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunctionMenu.IsWithParameter);
}
else if (strAttributeName  ==  conFunctionMenu.HyperLink)
{
mstrHyperLink = value.ToString();
 AddUpdatedFld(conFunctionMenu.HyperLink);
}
else if (strAttributeName  ==  conFunctionMenu.HyperLink4NoUser)
{
mstrHyperLink4NoUser = value.ToString();
 AddUpdatedFld(conFunctionMenu.HyperLink4NoUser);
}
else if (strAttributeName  ==  conFunctionMenu.SingleSignOnKey)
{
mstrSingleSignOnKey = value.ToString();
 AddUpdatedFld(conFunctionMenu.SingleSignOnKey);
}
else if (strAttributeName  ==  conFunctionMenu.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(conFunctionMenu.SchoolId);
}
else if (strAttributeName  ==  conFunctionMenu.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunctionMenu.UpdDate);
}
else if (strAttributeName  ==  conFunctionMenu.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conFunctionMenu.UpdUserId);
}
else if (strAttributeName  ==  conFunctionMenu.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionMenu.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFunctionMenu.FunctionMenuId  ==  AttributeName[intIndex])
{
return mstrFunctionMenuId;
}
else if (conFunctionMenu.FunctionName  ==  AttributeName[intIndex])
{
return mstrFunctionName;
}
else if (conFunctionMenu.TitleName  ==  AttributeName[intIndex])
{
return mstrTitleName;
}
else if (conFunctionMenu.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conFunctionMenu.DispPageMode  ==  AttributeName[intIndex])
{
return mstrDispPageMode;
}
else if (conFunctionMenu.IsTransUserBySingleSignOn  ==  AttributeName[intIndex])
{
return mbolIsTransUserBySingleSignOn;
}
else if (conFunctionMenu.IsWithParameter  ==  AttributeName[intIndex])
{
return mbolIsWithParameter;
}
else if (conFunctionMenu.HyperLink  ==  AttributeName[intIndex])
{
return mstrHyperLink;
}
else if (conFunctionMenu.HyperLink4NoUser  ==  AttributeName[intIndex])
{
return mstrHyperLink4NoUser;
}
else if (conFunctionMenu.SingleSignOnKey  ==  AttributeName[intIndex])
{
return mstrSingleSignOnKey;
}
else if (conFunctionMenu.SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (conFunctionMenu.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFunctionMenu.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conFunctionMenu.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFunctionMenu.FunctionMenuId  ==  AttributeName[intIndex])
{
mstrFunctionMenuId = value.ToString();
 AddUpdatedFld(conFunctionMenu.FunctionMenuId);
}
else if (conFunctionMenu.FunctionName  ==  AttributeName[intIndex])
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(conFunctionMenu.FunctionName);
}
else if (conFunctionMenu.TitleName  ==  AttributeName[intIndex])
{
mstrTitleName = value.ToString();
 AddUpdatedFld(conFunctionMenu.TitleName);
}
else if (conFunctionMenu.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunctionMenu.IsVisible);
}
else if (conFunctionMenu.DispPageMode  ==  AttributeName[intIndex])
{
mstrDispPageMode = value.ToString();
 AddUpdatedFld(conFunctionMenu.DispPageMode);
}
else if (conFunctionMenu.IsTransUserBySingleSignOn  ==  AttributeName[intIndex])
{
mbolIsTransUserBySingleSignOn = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunctionMenu.IsTransUserBySingleSignOn);
}
else if (conFunctionMenu.IsWithParameter  ==  AttributeName[intIndex])
{
mbolIsWithParameter = TransNullToBool(value.ToString());
 AddUpdatedFld(conFunctionMenu.IsWithParameter);
}
else if (conFunctionMenu.HyperLink  ==  AttributeName[intIndex])
{
mstrHyperLink = value.ToString();
 AddUpdatedFld(conFunctionMenu.HyperLink);
}
else if (conFunctionMenu.HyperLink4NoUser  ==  AttributeName[intIndex])
{
mstrHyperLink4NoUser = value.ToString();
 AddUpdatedFld(conFunctionMenu.HyperLink4NoUser);
}
else if (conFunctionMenu.SingleSignOnKey  ==  AttributeName[intIndex])
{
mstrSingleSignOnKey = value.ToString();
 AddUpdatedFld(conFunctionMenu.SingleSignOnKey);
}
else if (conFunctionMenu.SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(conFunctionMenu.SchoolId);
}
else if (conFunctionMenu.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFunctionMenu.UpdDate);
}
else if (conFunctionMenu.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conFunctionMenu.UpdUserId);
}
else if (conFunctionMenu.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFunctionMenu.Memo);
}
}
}

/// <summary>
/// 功能菜单ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionMenuId
{
get
{
return mstrFunctionMenuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionMenuId = value;
}
else
{
 mstrFunctionMenuId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionMenu.FunctionMenuId);
}
}
/// <summary>
/// 函数名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionName
{
get
{
return mstrFunctionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionName = value;
}
else
{
 mstrFunctionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionMenu.FunctionName);
}
}
/// <summary>
/// 功能菜单标题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TitleName
{
get
{
return mstrTitleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTitleName = value;
}
else
{
 mstrTitleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionMenu.TitleName);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(conFunctionMenu.IsVisible);
}
}
/// <summary>
/// 显示页面方式(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DispPageMode
{
get
{
return mstrDispPageMode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDispPageMode = value;
}
else
{
 mstrDispPageMode = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionMenu.DispPageMode);
}
}
/// <summary>
/// 是否单点登录传用户信息(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTransUserBySingleSignOn
{
get
{
return mbolIsTransUserBySingleSignOn;
}
set
{
 mbolIsTransUserBySingleSignOn = value;
//记录修改过的字段
 AddUpdatedFld(conFunctionMenu.IsTransUserBySingleSignOn);
}
}
/// <summary>
/// 是否带参数(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsWithParameter
{
get
{
return mbolIsWithParameter;
}
set
{
 mbolIsWithParameter = value;
//记录修改过的字段
 AddUpdatedFld(conFunctionMenu.IsWithParameter);
}
}
/// <summary>
/// 超链接(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HyperLink
{
get
{
return mstrHyperLink;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHyperLink = value;
}
else
{
 mstrHyperLink = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionMenu.HyperLink);
}
}
/// <summary>
/// 超链接针对无用户(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HyperLink4NoUser
{
get
{
return mstrHyperLink4NoUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHyperLink4NoUser = value;
}
else
{
 mstrHyperLink4NoUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionMenu.HyperLink4NoUser);
}
}
/// <summary>
/// 单点登录关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SingleSignOnKey
{
get
{
return mstrSingleSignOnKey;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSingleSignOnKey = value;
}
else
{
 mstrSingleSignOnKey = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionMenu.SingleSignOnKey);
}
}
/// <summary>
/// 学校编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolId
{
get
{
return mstrSchoolId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolId = value;
}
else
{
 mstrSchoolId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFunctionMenu.SchoolId);
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
 AddUpdatedFld(conFunctionMenu.UpdDate);
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
 AddUpdatedFld(conFunctionMenu.UpdUserId);
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
 AddUpdatedFld(conFunctionMenu.Memo);
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
  return mstrFunctionMenuId;
 }
 }
}
 /// <summary>
 /// 功能菜单(FunctionMenu)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFunctionMenu
{
public const string _CurrTabName = "FunctionMenu"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FunctionMenuId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FunctionMenuId", "FunctionName", "TitleName", "IsVisible", "DispPageMode", "IsTransUserBySingleSignOn", "IsWithParameter", "HyperLink", "HyperLink4NoUser", "SingleSignOnKey", "SchoolId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FunctionMenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionMenuId = "FunctionMenuId";    //功能菜单ID

 /// <summary>
 /// 常量:"FunctionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionName = "FunctionName";    //函数名

 /// <summary>
 /// 常量:"TitleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TitleName = "TitleName";    //功能菜单标题

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"DispPageMode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DispPageMode = "DispPageMode";    //显示页面方式

 /// <summary>
 /// 常量:"IsTransUserBySingleSignOn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTransUserBySingleSignOn = "IsTransUserBySingleSignOn";    //是否单点登录传用户信息

 /// <summary>
 /// 常量:"IsWithParameter"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsWithParameter = "IsWithParameter";    //是否带参数

 /// <summary>
 /// 常量:"HyperLink"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HyperLink = "HyperLink";    //超链接

 /// <summary>
 /// 常量:"HyperLink4NoUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HyperLink4NoUser = "HyperLink4NoUser";    //超链接针对无用户

 /// <summary>
 /// 常量:"SingleSignOnKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SingleSignOnKey = "SingleSignOnKey";    //单点登录关键字

 /// <summary>
 /// 常量:"SchoolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolId = "SchoolId";    //学校编号

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