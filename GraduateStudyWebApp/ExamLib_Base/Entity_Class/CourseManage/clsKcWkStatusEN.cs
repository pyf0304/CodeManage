
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKcWkStatusEN
 表名:KcWkStatus(01120573)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理(CourseManage)
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
 /// 表KcWkStatus的关键字(WeekStatusId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_WeekStatusId_KcWkStatus
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strWeekStatusId">表关键字</param>
public K_WeekStatusId_KcWkStatus(string strWeekStatusId)
{
if (IsValid(strWeekStatusId)) Value = strWeekStatusId;
else
{
Value = null;
}
}
private static bool IsValid(string strWeekStatusId)
{
if (string.IsNullOrEmpty(strWeekStatusId) == true) return false;
if (strWeekStatusId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_WeekStatusId_KcWkStatus]类型的对象</returns>
public static implicit operator K_WeekStatusId_KcWkStatus(string value)
{
return new K_WeekStatusId_KcWkStatus(value);
}
}
 /// <summary>
 /// 课程单双全周状态(KcWkStatus)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsKcWkStatusEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "KcWkStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "WeekStatusId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"WeekStatusId", "WeekStatusDesc", "WeekStatusA", "ImportDate"};

protected string mstrWeekStatusId;    //周状态编号(单,双,全周)
protected string mstrWeekStatusDesc;    //周状态描述
protected string mstrWeekStatusA;    //周状态简称
protected string mstrImportDate;    //导入日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsKcWkStatusEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WeekStatusId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strWeekStatusId">关键字:周状态编号(单,双,全周)</param>
public clsKcWkStatusEN(string strWeekStatusId)
 {
strWeekStatusId = strWeekStatusId.Replace("'", "''");
if (strWeekStatusId.Length > 2)
{
throw new Exception("在表:KcWkStatus中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strWeekStatusId)  ==  true)
{
throw new Exception("在表:KcWkStatus中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWeekStatusId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrWeekStatusId = strWeekStatusId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("WeekStatusId");
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
if (strAttributeName  ==  conKcWkStatus.WeekStatusId)
{
return mstrWeekStatusId;
}
else if (strAttributeName  ==  conKcWkStatus.WeekStatusDesc)
{
return mstrWeekStatusDesc;
}
else if (strAttributeName  ==  conKcWkStatus.WeekStatusA)
{
return mstrWeekStatusA;
}
else if (strAttributeName  ==  conKcWkStatus.ImportDate)
{
return mstrImportDate;
}
return null;
}
set
{
if (strAttributeName  ==  conKcWkStatus.WeekStatusId)
{
mstrWeekStatusId = value.ToString();
 AddUpdatedFld(conKcWkStatus.WeekStatusId);
}
else if (strAttributeName  ==  conKcWkStatus.WeekStatusDesc)
{
mstrWeekStatusDesc = value.ToString();
 AddUpdatedFld(conKcWkStatus.WeekStatusDesc);
}
else if (strAttributeName  ==  conKcWkStatus.WeekStatusA)
{
mstrWeekStatusA = value.ToString();
 AddUpdatedFld(conKcWkStatus.WeekStatusA);
}
else if (strAttributeName  ==  conKcWkStatus.ImportDate)
{
mstrImportDate = value.ToString();
 AddUpdatedFld(conKcWkStatus.ImportDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conKcWkStatus.WeekStatusId  ==  AttributeName[intIndex])
{
return mstrWeekStatusId;
}
else if (conKcWkStatus.WeekStatusDesc  ==  AttributeName[intIndex])
{
return mstrWeekStatusDesc;
}
else if (conKcWkStatus.WeekStatusA  ==  AttributeName[intIndex])
{
return mstrWeekStatusA;
}
else if (conKcWkStatus.ImportDate  ==  AttributeName[intIndex])
{
return mstrImportDate;
}
return null;
}
set
{
if (conKcWkStatus.WeekStatusId  ==  AttributeName[intIndex])
{
mstrWeekStatusId = value.ToString();
 AddUpdatedFld(conKcWkStatus.WeekStatusId);
}
else if (conKcWkStatus.WeekStatusDesc  ==  AttributeName[intIndex])
{
mstrWeekStatusDesc = value.ToString();
 AddUpdatedFld(conKcWkStatus.WeekStatusDesc);
}
else if (conKcWkStatus.WeekStatusA  ==  AttributeName[intIndex])
{
mstrWeekStatusA = value.ToString();
 AddUpdatedFld(conKcWkStatus.WeekStatusA);
}
else if (conKcWkStatus.ImportDate  ==  AttributeName[intIndex])
{
mstrImportDate = value.ToString();
 AddUpdatedFld(conKcWkStatus.ImportDate);
}
}
}

/// <summary>
/// 周状态编号(单,双,全周)(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WeekStatusId
{
get
{
return mstrWeekStatusId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWeekStatusId = value;
}
else
{
 mstrWeekStatusId = value;
}
//记录修改过的字段
 AddUpdatedFld(conKcWkStatus.WeekStatusId);
}
}
/// <summary>
/// 周状态描述(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WeekStatusDesc
{
get
{
return mstrWeekStatusDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWeekStatusDesc = value;
}
else
{
 mstrWeekStatusDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(conKcWkStatus.WeekStatusDesc);
}
}
/// <summary>
/// 周状态简称(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WeekStatusA
{
get
{
return mstrWeekStatusA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWeekStatusA = value;
}
else
{
 mstrWeekStatusA = value;
}
//记录修改过的字段
 AddUpdatedFld(conKcWkStatus.WeekStatusA);
}
}
/// <summary>
/// 导入日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImportDate
{
get
{
return mstrImportDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImportDate = value;
}
else
{
 mstrImportDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conKcWkStatus.ImportDate);
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
  return mstrWeekStatusId;
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
  return mstrWeekStatusDesc;
 }
 }
}
 /// <summary>
 /// 课程单双全周状态(KcWkStatus)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conKcWkStatus
{
public const string _CurrTabName = "KcWkStatus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "WeekStatusId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"WeekStatusId", "WeekStatusDesc", "WeekStatusA", "ImportDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"WeekStatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WeekStatusId = "WeekStatusId";    //周状态编号(单,双,全周)

 /// <summary>
 /// 常量:"WeekStatusDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WeekStatusDesc = "WeekStatusDesc";    //周状态描述

 /// <summary>
 /// 常量:"WeekStatusA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WeekStatusA = "WeekStatusA";    //周状态简称

 /// <summary>
 /// 常量:"ImportDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImportDate = "ImportDate";    //导入日期
}

}