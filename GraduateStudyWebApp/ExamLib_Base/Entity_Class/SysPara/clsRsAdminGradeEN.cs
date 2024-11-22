
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRsAdminGradeEN
 表名:RsAdminGrade(01120111)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:05
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
 /// 表RsAdminGrade的关键字(IdAdminGrade)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdAdminGrade_RsAdminGrade
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdAdminGrade">表关键字</param>
public K_IdAdminGrade_RsAdminGrade(string strIdAdminGrade)
{
if (IsValid(strIdAdminGrade)) Value = strIdAdminGrade;
else
{
Value = null;
}
}
private static bool IsValid(string strIdAdminGrade)
{
if (string.IsNullOrEmpty(strIdAdminGrade) == true) return false;
if (strIdAdminGrade.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdAdminGrade_RsAdminGrade]类型的对象</returns>
public static implicit operator K_IdAdminGrade_RsAdminGrade(string value)
{
return new K_IdAdminGrade_RsAdminGrade(value);
}
}
 /// <summary>
 /// 职务(RsAdminGrade)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRsAdminGradeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "RsAdminGrade"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdAdminGrade"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"IdAdminGrade", "AdminGradeId", "AdminGradeDesc", "ModifyDate", "ModifyUserId"};

protected string mstrIdAdminGrade;    //行政职务流水号
protected string mstrAdminGradeId;    //行政职务代号
protected string mstrAdminGradeDesc;    //行政职务描述
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsRsAdminGradeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdAdminGrade");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdAdminGrade">关键字:行政职务流水号</param>
public clsRsAdminGradeEN(string strIdAdminGrade)
 {
strIdAdminGrade = strIdAdminGrade.Replace("'", "''");
if (strIdAdminGrade.Length > 4)
{
throw new Exception("在表:RsAdminGrade中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdAdminGrade)  ==  true)
{
throw new Exception("在表:RsAdminGrade中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdAdminGrade);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdAdminGrade = strIdAdminGrade;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdAdminGrade");
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
if (strAttributeName  ==  conRsAdminGrade.IdAdminGrade)
{
return mstrIdAdminGrade;
}
else if (strAttributeName  ==  conRsAdminGrade.AdminGradeId)
{
return mstrAdminGradeId;
}
else if (strAttributeName  ==  conRsAdminGrade.AdminGradeDesc)
{
return mstrAdminGradeDesc;
}
else if (strAttributeName  ==  conRsAdminGrade.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conRsAdminGrade.ModifyUserId)
{
return mstrModifyUserId;
}
return null;
}
set
{
if (strAttributeName  ==  conRsAdminGrade.IdAdminGrade)
{
mstrIdAdminGrade = value.ToString();
 AddUpdatedFld(conRsAdminGrade.IdAdminGrade);
}
else if (strAttributeName  ==  conRsAdminGrade.AdminGradeId)
{
mstrAdminGradeId = value.ToString();
 AddUpdatedFld(conRsAdminGrade.AdminGradeId);
}
else if (strAttributeName  ==  conRsAdminGrade.AdminGradeDesc)
{
mstrAdminGradeDesc = value.ToString();
 AddUpdatedFld(conRsAdminGrade.AdminGradeDesc);
}
else if (strAttributeName  ==  conRsAdminGrade.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conRsAdminGrade.ModifyDate);
}
else if (strAttributeName  ==  conRsAdminGrade.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conRsAdminGrade.ModifyUserId);
}
}
}
public object this[int intIndex]
{
get
{
if (conRsAdminGrade.IdAdminGrade  ==  AttributeName[intIndex])
{
return mstrIdAdminGrade;
}
else if (conRsAdminGrade.AdminGradeId  ==  AttributeName[intIndex])
{
return mstrAdminGradeId;
}
else if (conRsAdminGrade.AdminGradeDesc  ==  AttributeName[intIndex])
{
return mstrAdminGradeDesc;
}
else if (conRsAdminGrade.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conRsAdminGrade.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
return null;
}
set
{
if (conRsAdminGrade.IdAdminGrade  ==  AttributeName[intIndex])
{
mstrIdAdminGrade = value.ToString();
 AddUpdatedFld(conRsAdminGrade.IdAdminGrade);
}
else if (conRsAdminGrade.AdminGradeId  ==  AttributeName[intIndex])
{
mstrAdminGradeId = value.ToString();
 AddUpdatedFld(conRsAdminGrade.AdminGradeId);
}
else if (conRsAdminGrade.AdminGradeDesc  ==  AttributeName[intIndex])
{
mstrAdminGradeDesc = value.ToString();
 AddUpdatedFld(conRsAdminGrade.AdminGradeDesc);
}
else if (conRsAdminGrade.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conRsAdminGrade.ModifyDate);
}
else if (conRsAdminGrade.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conRsAdminGrade.ModifyUserId);
}
}
}

/// <summary>
/// 行政职务流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAdminGrade
{
get
{
return mstrIdAdminGrade;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAdminGrade = value;
}
else
{
 mstrIdAdminGrade = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsAdminGrade.IdAdminGrade);
}
}
/// <summary>
/// 行政职务代号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminGradeId
{
get
{
return mstrAdminGradeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminGradeId = value;
}
else
{
 mstrAdminGradeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsAdminGrade.AdminGradeId);
}
}
/// <summary>
/// 行政职务描述(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminGradeDesc
{
get
{
return mstrAdminGradeDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminGradeDesc = value;
}
else
{
 mstrAdminGradeDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsAdminGrade.AdminGradeDesc);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsAdminGrade.ModifyDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserId
{
get
{
return mstrModifyUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserId = value;
}
else
{
 mstrModifyUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsAdminGrade.ModifyUserId);
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
  return mstrIdAdminGrade;
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
  return mstrAdminGradeDesc;
 }
 }
}
 /// <summary>
 /// 职务(RsAdminGrade)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRsAdminGrade
{
public const string _CurrTabName = "RsAdminGrade"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdAdminGrade"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdAdminGrade", "AdminGradeId", "AdminGradeDesc", "ModifyDate", "ModifyUserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdAdminGrade"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAdminGrade = "IdAdminGrade";    //行政职务流水号

 /// <summary>
 /// 常量:"AdminGradeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminGradeId = "AdminGradeId";    //行政职务代号

 /// <summary>
 /// 常量:"AdminGradeDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminGradeDesc = "AdminGradeDesc";    //行政职务描述

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人
}

}