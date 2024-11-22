﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TobeStudiedProblemEN
 表名:gs_TobeStudiedProblem(01120776)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:37
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表gs_TobeStudiedProblem的关键字(ProblemId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ProblemId_gs_TobeStudiedProblem
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strProblemId">表关键字</param>
public K_ProblemId_gs_TobeStudiedProblem(string strProblemId)
{
if (IsValid(strProblemId)) Value = strProblemId;
else
{
Value = null;
}
}
private static bool IsValid(string strProblemId)
{
if (string.IsNullOrEmpty(strProblemId) == true) return false;
if (strProblemId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ProblemId_gs_TobeStudiedProblem]类型的对象</returns>
public static implicit operator K_ProblemId_gs_TobeStudiedProblem(string value)
{
return new K_ProblemId_gs_TobeStudiedProblem(value);
}
}
 /// <summary>
 /// 待研究问题(gs_TobeStudiedProblem)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_TobeStudiedProblemEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_TobeStudiedProblem"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ProblemId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"ProblemId", "ProblemTitle", "ProblemContent", "TopicId", "IsSubmit", "ProblemDate", "UpdDate", "UpdUser", "Year", "Month", "VersionCount", "Participant", "Memo", "IdCurrEduCls"};

protected string mstrProblemId;    //问题Id
protected string mstrProblemTitle;    //问题标题
protected string mstrProblemContent;    //问题内容
protected string mstrTopicId;    //主题Id
protected bool mbolIsSubmit;    //是否提交
protected string mstrProblemDate;    //问题日期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrYear;    //年
protected string mstrMonth;    //月
protected int? mintVersionCount;    //版本统计
protected string mstrParticipant;    //参与者
protected string mstrMemo;    //备注
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_TobeStudiedProblemEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ProblemId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strProblemId">关键字:问题Id</param>
public clsgs_TobeStudiedProblemEN(string strProblemId)
 {
strProblemId = strProblemId.Replace("'", "''");
if (strProblemId.Length > 10)
{
throw new Exception("在表:gs_TobeStudiedProblem中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strProblemId)  ==  true)
{
throw new Exception("在表:gs_TobeStudiedProblem中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strProblemId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrProblemId = strProblemId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ProblemId");
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
if (strAttributeName  ==  congs_TobeStudiedProblem.ProblemId)
{
return mstrProblemId;
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.ProblemTitle)
{
return mstrProblemTitle;
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.ProblemContent)
{
return mstrProblemContent;
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.ProblemDate)
{
return mstrProblemDate;
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.Year)
{
return mstrYear;
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.Month)
{
return mstrMonth;
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.Participant)
{
return mstrParticipant;
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  congs_TobeStudiedProblem.ProblemId)
{
mstrProblemId = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.ProblemId);
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.ProblemTitle)
{
mstrProblemTitle = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.ProblemTitle);
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.ProblemContent)
{
mstrProblemContent = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.ProblemContent);
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.TopicId);
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_TobeStudiedProblem.IsSubmit);
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.ProblemDate)
{
mstrProblemDate = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.ProblemDate);
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.UpdDate);
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.UpdUser);
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.Year)
{
mstrYear = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.Year);
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.Month)
{
mstrMonth = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.Month);
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_TobeStudiedProblem.VersionCount);
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.Participant)
{
mstrParticipant = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.Participant);
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.Memo);
}
else if (strAttributeName  ==  congs_TobeStudiedProblem.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_TobeStudiedProblem.ProblemId  ==  AttributeName[intIndex])
{
return mstrProblemId;
}
else if (congs_TobeStudiedProblem.ProblemTitle  ==  AttributeName[intIndex])
{
return mstrProblemTitle;
}
else if (congs_TobeStudiedProblem.ProblemContent  ==  AttributeName[intIndex])
{
return mstrProblemContent;
}
else if (congs_TobeStudiedProblem.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (congs_TobeStudiedProblem.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (congs_TobeStudiedProblem.ProblemDate  ==  AttributeName[intIndex])
{
return mstrProblemDate;
}
else if (congs_TobeStudiedProblem.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_TobeStudiedProblem.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_TobeStudiedProblem.Year  ==  AttributeName[intIndex])
{
return mstrYear;
}
else if (congs_TobeStudiedProblem.Month  ==  AttributeName[intIndex])
{
return mstrMonth;
}
else if (congs_TobeStudiedProblem.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (congs_TobeStudiedProblem.Participant  ==  AttributeName[intIndex])
{
return mstrParticipant;
}
else if (congs_TobeStudiedProblem.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (congs_TobeStudiedProblem.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (congs_TobeStudiedProblem.ProblemId  ==  AttributeName[intIndex])
{
mstrProblemId = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.ProblemId);
}
else if (congs_TobeStudiedProblem.ProblemTitle  ==  AttributeName[intIndex])
{
mstrProblemTitle = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.ProblemTitle);
}
else if (congs_TobeStudiedProblem.ProblemContent  ==  AttributeName[intIndex])
{
mstrProblemContent = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.ProblemContent);
}
else if (congs_TobeStudiedProblem.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.TopicId);
}
else if (congs_TobeStudiedProblem.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_TobeStudiedProblem.IsSubmit);
}
else if (congs_TobeStudiedProblem.ProblemDate  ==  AttributeName[intIndex])
{
mstrProblemDate = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.ProblemDate);
}
else if (congs_TobeStudiedProblem.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.UpdDate);
}
else if (congs_TobeStudiedProblem.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.UpdUser);
}
else if (congs_TobeStudiedProblem.Year  ==  AttributeName[intIndex])
{
mstrYear = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.Year);
}
else if (congs_TobeStudiedProblem.Month  ==  AttributeName[intIndex])
{
mstrMonth = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.Month);
}
else if (congs_TobeStudiedProblem.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_TobeStudiedProblem.VersionCount);
}
else if (congs_TobeStudiedProblem.Participant  ==  AttributeName[intIndex])
{
mstrParticipant = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.Participant);
}
else if (congs_TobeStudiedProblem.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.Memo);
}
else if (congs_TobeStudiedProblem.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblem.IdCurrEduCls);
}
}
}

/// <summary>
/// 问题Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProblemId
{
get
{
return mstrProblemId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProblemId = value;
}
else
{
 mstrProblemId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TobeStudiedProblem.ProblemId);
}
}
/// <summary>
/// 问题标题(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProblemTitle
{
get
{
return mstrProblemTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProblemTitle = value;
}
else
{
 mstrProblemTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TobeStudiedProblem.ProblemTitle);
}
}
/// <summary>
/// 问题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProblemContent
{
get
{
return mstrProblemContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProblemContent = value;
}
else
{
 mstrProblemContent = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TobeStudiedProblem.ProblemContent);
}
}
/// <summary>
/// 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicId
{
get
{
return mstrTopicId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicId = value;
}
else
{
 mstrTopicId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TobeStudiedProblem.TopicId);
}
}
/// <summary>
/// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSubmit
{
get
{
return mbolIsSubmit;
}
set
{
 mbolIsSubmit = value;
//记录修改过的字段
 AddUpdatedFld(congs_TobeStudiedProblem.IsSubmit);
}
}
/// <summary>
/// 问题日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProblemDate
{
get
{
return mstrProblemDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProblemDate = value;
}
else
{
 mstrProblemDate = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TobeStudiedProblem.ProblemDate);
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
 AddUpdatedFld(congs_TobeStudiedProblem.UpdDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TobeStudiedProblem.UpdUser);
}
}
/// <summary>
/// 年(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Year
{
get
{
return mstrYear;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrYear = value;
}
else
{
 mstrYear = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TobeStudiedProblem.Year);
}
}
/// <summary>
/// 月(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Month
{
get
{
return mstrMonth;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMonth = value;
}
else
{
 mstrMonth = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TobeStudiedProblem.Month);
}
}
/// <summary>
/// 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VersionCount
{
get
{
return mintVersionCount;
}
set
{
 mintVersionCount = value;
//记录修改过的字段
 AddUpdatedFld(congs_TobeStudiedProblem.VersionCount);
}
}
/// <summary>
/// 参与者(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Participant
{
get
{
return mstrParticipant;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParticipant = value;
}
else
{
 mstrParticipant = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TobeStudiedProblem.Participant);
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
 AddUpdatedFld(congs_TobeStudiedProblem.Memo);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TobeStudiedProblem.IdCurrEduCls);
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
  return mstrProblemId;
 }
 }
}
 /// <summary>
 /// 待研究问题(gs_TobeStudiedProblem)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_TobeStudiedProblem
{
public const string _CurrTabName = "gs_TobeStudiedProblem"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ProblemId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ProblemId", "ProblemTitle", "ProblemContent", "TopicId", "IsSubmit", "ProblemDate", "UpdDate", "UpdUser", "Year", "Month", "VersionCount", "Participant", "Memo", "IdCurrEduCls"};
//以下是属性变量


 /// <summary>
 /// 常量:"ProblemId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProblemId = "ProblemId";    //问题Id

 /// <summary>
 /// 常量:"ProblemTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProblemTitle = "ProblemTitle";    //问题标题

 /// <summary>
 /// 常量:"ProblemContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProblemContent = "ProblemContent";    //问题内容

 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"ProblemDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProblemDate = "ProblemDate";    //问题日期

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Year"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Year = "Year";    //年

 /// <summary>
 /// 常量:"Month"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Month = "Month";    //月

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"Participant"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Participant = "Participant";    //参与者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号
}

}