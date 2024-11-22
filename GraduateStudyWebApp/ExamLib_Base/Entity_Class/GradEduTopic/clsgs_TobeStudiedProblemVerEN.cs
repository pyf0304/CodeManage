
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TobeStudiedProblemVerEN
 表名:gs_TobeStudiedProblemVer(01120775)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:11:22
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
 /// 表gs_TobeStudiedProblemVer的关键字(ProblemVId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ProblemVId_gs_TobeStudiedProblemVer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngProblemVId">表关键字</param>
public K_ProblemVId_gs_TobeStudiedProblemVer(long lngProblemVId)
{
if (IsValid(lngProblemVId)) Value = lngProblemVId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngProblemVId)
{
if (lngProblemVId == 0) return false;
if (lngProblemVId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ProblemVId_gs_TobeStudiedProblemVer]类型的对象</returns>
public static implicit operator K_ProblemVId_gs_TobeStudiedProblemVer(long value)
{
return new K_ProblemVId_gs_TobeStudiedProblemVer(value);
}
}
 /// <summary>
 /// 待研究问题历史版本表(gs_TobeStudiedProblemVer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_TobeStudiedProblemVerEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_TobeStudiedProblemVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ProblemVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"ProblemVId", "ProblemId", "TopicId", "IsSubmit", "ProblemContent", "ProblemDate", "Participant", "UpdDate", "UpdUser", "Year", "Month", "Memo", "ProblemTitle"};

protected long mlngProblemVId;    //ProblemVId
protected string mstrProblemId;    //问题Id
protected string mstrTopicId;    //主题Id
protected bool mbolIsSubmit;    //是否提交
protected string mstrProblemContent;    //问题内容
protected string mstrProblemDate;    //问题日期
protected string mstrParticipant;    //参与者
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrYear;    //年
protected string mstrMonth;    //月
protected string mstrMemo;    //备注
protected string mstrProblemTitle;    //问题标题

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_TobeStudiedProblemVerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ProblemVId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngProblemVId">关键字:ProblemVId</param>
public clsgs_TobeStudiedProblemVerEN(long lngProblemVId)
 {
 if (lngProblemVId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngProblemVId = lngProblemVId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ProblemVId");
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
if (strAttributeName  ==  congs_TobeStudiedProblemVer.ProblemVId)
{
return mlngProblemVId;
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.ProblemId)
{
return mstrProblemId;
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.ProblemContent)
{
return mstrProblemContent;
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.ProblemDate)
{
return mstrProblemDate;
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.Participant)
{
return mstrParticipant;
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.Year)
{
return mstrYear;
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.Month)
{
return mstrMonth;
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.ProblemTitle)
{
return mstrProblemTitle;
}
return null;
}
set
{
if (strAttributeName  ==  congs_TobeStudiedProblemVer.ProblemVId)
{
mlngProblemVId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_TobeStudiedProblemVer.ProblemVId);
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.ProblemId)
{
mstrProblemId = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.ProblemId);
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.TopicId);
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_TobeStudiedProblemVer.IsSubmit);
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.ProblemContent)
{
mstrProblemContent = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.ProblemContent);
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.ProblemDate)
{
mstrProblemDate = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.ProblemDate);
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.Participant)
{
mstrParticipant = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.Participant);
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.UpdDate);
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.UpdUser);
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.Year)
{
mstrYear = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.Year);
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.Month)
{
mstrMonth = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.Month);
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.Memo);
}
else if (strAttributeName  ==  congs_TobeStudiedProblemVer.ProblemTitle)
{
mstrProblemTitle = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.ProblemTitle);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_TobeStudiedProblemVer.ProblemVId  ==  AttributeName[intIndex])
{
return mlngProblemVId;
}
else if (congs_TobeStudiedProblemVer.ProblemId  ==  AttributeName[intIndex])
{
return mstrProblemId;
}
else if (congs_TobeStudiedProblemVer.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (congs_TobeStudiedProblemVer.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (congs_TobeStudiedProblemVer.ProblemContent  ==  AttributeName[intIndex])
{
return mstrProblemContent;
}
else if (congs_TobeStudiedProblemVer.ProblemDate  ==  AttributeName[intIndex])
{
return mstrProblemDate;
}
else if (congs_TobeStudiedProblemVer.Participant  ==  AttributeName[intIndex])
{
return mstrParticipant;
}
else if (congs_TobeStudiedProblemVer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_TobeStudiedProblemVer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_TobeStudiedProblemVer.Year  ==  AttributeName[intIndex])
{
return mstrYear;
}
else if (congs_TobeStudiedProblemVer.Month  ==  AttributeName[intIndex])
{
return mstrMonth;
}
else if (congs_TobeStudiedProblemVer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (congs_TobeStudiedProblemVer.ProblemTitle  ==  AttributeName[intIndex])
{
return mstrProblemTitle;
}
return null;
}
set
{
if (congs_TobeStudiedProblemVer.ProblemVId  ==  AttributeName[intIndex])
{
mlngProblemVId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_TobeStudiedProblemVer.ProblemVId);
}
else if (congs_TobeStudiedProblemVer.ProblemId  ==  AttributeName[intIndex])
{
mstrProblemId = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.ProblemId);
}
else if (congs_TobeStudiedProblemVer.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.TopicId);
}
else if (congs_TobeStudiedProblemVer.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_TobeStudiedProblemVer.IsSubmit);
}
else if (congs_TobeStudiedProblemVer.ProblemContent  ==  AttributeName[intIndex])
{
mstrProblemContent = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.ProblemContent);
}
else if (congs_TobeStudiedProblemVer.ProblemDate  ==  AttributeName[intIndex])
{
mstrProblemDate = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.ProblemDate);
}
else if (congs_TobeStudiedProblemVer.Participant  ==  AttributeName[intIndex])
{
mstrParticipant = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.Participant);
}
else if (congs_TobeStudiedProblemVer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.UpdDate);
}
else if (congs_TobeStudiedProblemVer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.UpdUser);
}
else if (congs_TobeStudiedProblemVer.Year  ==  AttributeName[intIndex])
{
mstrYear = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.Year);
}
else if (congs_TobeStudiedProblemVer.Month  ==  AttributeName[intIndex])
{
mstrMonth = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.Month);
}
else if (congs_TobeStudiedProblemVer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.Memo);
}
else if (congs_TobeStudiedProblemVer.ProblemTitle  ==  AttributeName[intIndex])
{
mstrProblemTitle = value.ToString();
 AddUpdatedFld(congs_TobeStudiedProblemVer.ProblemTitle);
}
}
}

/// <summary>
/// ProblemVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ProblemVId
{
get
{
return mlngProblemVId;
}
set
{
 mlngProblemVId = value;
//记录修改过的字段
 AddUpdatedFld(congs_TobeStudiedProblemVer.ProblemVId);
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
 AddUpdatedFld(congs_TobeStudiedProblemVer.ProblemId);
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
 AddUpdatedFld(congs_TobeStudiedProblemVer.TopicId);
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
 AddUpdatedFld(congs_TobeStudiedProblemVer.IsSubmit);
}
}
/// <summary>
/// 问题内容(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
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
 AddUpdatedFld(congs_TobeStudiedProblemVer.ProblemContent);
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
 AddUpdatedFld(congs_TobeStudiedProblemVer.ProblemDate);
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
 AddUpdatedFld(congs_TobeStudiedProblemVer.Participant);
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
 AddUpdatedFld(congs_TobeStudiedProblemVer.UpdDate);
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
 AddUpdatedFld(congs_TobeStudiedProblemVer.UpdUser);
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
 AddUpdatedFld(congs_TobeStudiedProblemVer.Year);
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
 AddUpdatedFld(congs_TobeStudiedProblemVer.Month);
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
 AddUpdatedFld(congs_TobeStudiedProblemVer.Memo);
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
 AddUpdatedFld(congs_TobeStudiedProblemVer.ProblemTitle);
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
  return mlngProblemVId.ToString();
 }
 }
}
 /// <summary>
 /// 待研究问题历史版本表(gs_TobeStudiedProblemVer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_TobeStudiedProblemVer
{
public const string _CurrTabName = "gs_TobeStudiedProblemVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ProblemVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ProblemVId", "ProblemId", "TopicId", "IsSubmit", "ProblemContent", "ProblemDate", "Participant", "UpdDate", "UpdUser", "Year", "Month", "Memo", "ProblemTitle"};
//以下是属性变量


 /// <summary>
 /// 常量:"ProblemVId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProblemVId = "ProblemVId";    //ProblemVId

 /// <summary>
 /// 常量:"ProblemId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProblemId = "ProblemId";    //问题Id

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
 /// 常量:"ProblemContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProblemContent = "ProblemContent";    //问题内容

 /// <summary>
 /// 常量:"ProblemDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProblemDate = "ProblemDate";    //问题日期

 /// <summary>
 /// 常量:"Participant"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Participant = "Participant";    //参与者

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"ProblemTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProblemTitle = "ProblemTitle";    //问题标题
}

}