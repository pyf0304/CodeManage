
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachAppraiseEN
 表名:MicroteachAppraise(01120264)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:16:35
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace ExamLib.Entity
{
 /// <summary>
 /// 表MicroteachAppraise的关键字(IdMicroteachAppraise)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachAppraise_MicroteachAppraise
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdMicroteachAppraise">表关键字</param>
public K_IdMicroteachAppraise_MicroteachAppraise(long lngIdMicroteachAppraise)
{
if (IsValid(lngIdMicroteachAppraise)) Value = lngIdMicroteachAppraise;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdMicroteachAppraise)
{
if (lngIdMicroteachAppraise == 0) return false;
if (lngIdMicroteachAppraise == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMicroteachAppraise_MicroteachAppraise]类型的对象</returns>
public static implicit operator K_IdMicroteachAppraise_MicroteachAppraise(long value)
{
return new K_IdMicroteachAppraise_MicroteachAppraise(value);
}
}
 /// <summary>
 /// 微格案例定性评议(MicroteachAppraise)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsMicroteachAppraiseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "MicroteachAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachAppraise"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"IdMicroteachAppraise", "FuncModuleId", "IdMicroteachCase", "IdAppraiseType", "AppraiseTheme", "AppraiseContent", "AppraiseDate", "AppraiseTime", "IsVisual", "IsElite", "ExcellentOne", "ExcellentTwo", "SuggestOne", "SuggestTwo", "MicroteachAppriseScore", "VideoStopTime", "BrowseCount", "UserId"};

protected long mlngIdMicroteachAppraise;    //评议流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrAppraiseTheme;    //评议主题
protected string mstrAppraiseContent;    //评议内容
protected string mstrAppraiseDate;    //评议日期
protected string mstrAppraiseTime;    //评议时间
protected bool mbolIsVisual;    //隐藏标志
protected bool mbolIsElite;    //精华标志
protected string mstrExcellentOne;    //优点1
protected string mstrExcellentTwo;    //优点2
protected string mstrSuggestOne;    //建议1
protected string mstrSuggestTwo;    //建议2
protected float? mfltMicroteachAppriseScore;    //打分
protected string mstrVideoStopTime;    //公开课案例视频暂停时间
protected int? mintBrowseCount;    //浏览次数
protected string mstrUserId;    //用户ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsMicroteachAppraiseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachAppraise");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdMicroteachAppraise">关键字:评议流水号</param>
public clsMicroteachAppraiseEN(long lngIdMicroteachAppraise)
 {
 if (lngIdMicroteachAppraise  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdMicroteachAppraise = lngIdMicroteachAppraise;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachAppraise");
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
if (strAttributeName  ==  conMicroteachAppraise.IdMicroteachAppraise)
{
return mlngIdMicroteachAppraise;
}
else if (strAttributeName  ==  conMicroteachAppraise.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conMicroteachAppraise.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  conMicroteachAppraise.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  conMicroteachAppraise.AppraiseTheme)
{
return mstrAppraiseTheme;
}
else if (strAttributeName  ==  conMicroteachAppraise.AppraiseContent)
{
return mstrAppraiseContent;
}
else if (strAttributeName  ==  conMicroteachAppraise.AppraiseDate)
{
return mstrAppraiseDate;
}
else if (strAttributeName  ==  conMicroteachAppraise.AppraiseTime)
{
return mstrAppraiseTime;
}
else if (strAttributeName  ==  conMicroteachAppraise.IsVisual)
{
return mbolIsVisual;
}
else if (strAttributeName  ==  conMicroteachAppraise.IsElite)
{
return mbolIsElite;
}
else if (strAttributeName  ==  conMicroteachAppraise.ExcellentOne)
{
return mstrExcellentOne;
}
else if (strAttributeName  ==  conMicroteachAppraise.ExcellentTwo)
{
return mstrExcellentTwo;
}
else if (strAttributeName  ==  conMicroteachAppraise.SuggestOne)
{
return mstrSuggestOne;
}
else if (strAttributeName  ==  conMicroteachAppraise.SuggestTwo)
{
return mstrSuggestTwo;
}
else if (strAttributeName  ==  conMicroteachAppraise.MicroteachAppriseScore)
{
return mfltMicroteachAppriseScore;
}
else if (strAttributeName  ==  conMicroteachAppraise.VideoStopTime)
{
return mstrVideoStopTime;
}
else if (strAttributeName  ==  conMicroteachAppraise.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conMicroteachAppraise.UserId)
{
return mstrUserId;
}
return null;
}
set
{
if (strAttributeName  ==  conMicroteachAppraise.IdMicroteachAppraise)
{
mlngIdMicroteachAppraise = TransNullToInt(value.ToString());
 AddUpdatedFld(conMicroteachAppraise.IdMicroteachAppraise);
}
else if (strAttributeName  ==  conMicroteachAppraise.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.FuncModuleId);
}
else if (strAttributeName  ==  conMicroteachAppraise.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.IdMicroteachCase);
}
else if (strAttributeName  ==  conMicroteachAppraise.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.IdAppraiseType);
}
else if (strAttributeName  ==  conMicroteachAppraise.AppraiseTheme)
{
mstrAppraiseTheme = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.AppraiseTheme);
}
else if (strAttributeName  ==  conMicroteachAppraise.AppraiseContent)
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.AppraiseContent);
}
else if (strAttributeName  ==  conMicroteachAppraise.AppraiseDate)
{
mstrAppraiseDate = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.AppraiseDate);
}
else if (strAttributeName  ==  conMicroteachAppraise.AppraiseTime)
{
mstrAppraiseTime = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.AppraiseTime);
}
else if (strAttributeName  ==  conMicroteachAppraise.IsVisual)
{
mbolIsVisual = TransNullToBool(value.ToString());
 AddUpdatedFld(conMicroteachAppraise.IsVisual);
}
else if (strAttributeName  ==  conMicroteachAppraise.IsElite)
{
mbolIsElite = TransNullToBool(value.ToString());
 AddUpdatedFld(conMicroteachAppraise.IsElite);
}
else if (strAttributeName  ==  conMicroteachAppraise.ExcellentOne)
{
mstrExcellentOne = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.ExcellentOne);
}
else if (strAttributeName  ==  conMicroteachAppraise.ExcellentTwo)
{
mstrExcellentTwo = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.ExcellentTwo);
}
else if (strAttributeName  ==  conMicroteachAppraise.SuggestOne)
{
mstrSuggestOne = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.SuggestOne);
}
else if (strAttributeName  ==  conMicroteachAppraise.SuggestTwo)
{
mstrSuggestTwo = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.SuggestTwo);
}
else if (strAttributeName  ==  conMicroteachAppraise.MicroteachAppriseScore)
{
mfltMicroteachAppriseScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conMicroteachAppraise.MicroteachAppriseScore);
}
else if (strAttributeName  ==  conMicroteachAppraise.VideoStopTime)
{
mstrVideoStopTime = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.VideoStopTime);
}
else if (strAttributeName  ==  conMicroteachAppraise.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conMicroteachAppraise.BrowseCount);
}
else if (strAttributeName  ==  conMicroteachAppraise.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.UserId);
}
}
}
public object this[int intIndex]
{
get
{
if (conMicroteachAppraise.IdMicroteachAppraise  ==  AttributeName[intIndex])
{
return mlngIdMicroteachAppraise;
}
else if (conMicroteachAppraise.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conMicroteachAppraise.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (conMicroteachAppraise.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (conMicroteachAppraise.AppraiseTheme  ==  AttributeName[intIndex])
{
return mstrAppraiseTheme;
}
else if (conMicroteachAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
return mstrAppraiseContent;
}
else if (conMicroteachAppraise.AppraiseDate  ==  AttributeName[intIndex])
{
return mstrAppraiseDate;
}
else if (conMicroteachAppraise.AppraiseTime  ==  AttributeName[intIndex])
{
return mstrAppraiseTime;
}
else if (conMicroteachAppraise.IsVisual  ==  AttributeName[intIndex])
{
return mbolIsVisual;
}
else if (conMicroteachAppraise.IsElite  ==  AttributeName[intIndex])
{
return mbolIsElite;
}
else if (conMicroteachAppraise.ExcellentOne  ==  AttributeName[intIndex])
{
return mstrExcellentOne;
}
else if (conMicroteachAppraise.ExcellentTwo  ==  AttributeName[intIndex])
{
return mstrExcellentTwo;
}
else if (conMicroteachAppraise.SuggestOne  ==  AttributeName[intIndex])
{
return mstrSuggestOne;
}
else if (conMicroteachAppraise.SuggestTwo  ==  AttributeName[intIndex])
{
return mstrSuggestTwo;
}
else if (conMicroteachAppraise.MicroteachAppriseScore  ==  AttributeName[intIndex])
{
return mfltMicroteachAppriseScore;
}
else if (conMicroteachAppraise.VideoStopTime  ==  AttributeName[intIndex])
{
return mstrVideoStopTime;
}
else if (conMicroteachAppraise.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conMicroteachAppraise.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
return null;
}
set
{
if (conMicroteachAppraise.IdMicroteachAppraise  ==  AttributeName[intIndex])
{
mlngIdMicroteachAppraise = TransNullToInt(value.ToString());
 AddUpdatedFld(conMicroteachAppraise.IdMicroteachAppraise);
}
else if (conMicroteachAppraise.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.FuncModuleId);
}
else if (conMicroteachAppraise.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.IdMicroteachCase);
}
else if (conMicroteachAppraise.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.IdAppraiseType);
}
else if (conMicroteachAppraise.AppraiseTheme  ==  AttributeName[intIndex])
{
mstrAppraiseTheme = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.AppraiseTheme);
}
else if (conMicroteachAppraise.AppraiseContent  ==  AttributeName[intIndex])
{
mstrAppraiseContent = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.AppraiseContent);
}
else if (conMicroteachAppraise.AppraiseDate  ==  AttributeName[intIndex])
{
mstrAppraiseDate = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.AppraiseDate);
}
else if (conMicroteachAppraise.AppraiseTime  ==  AttributeName[intIndex])
{
mstrAppraiseTime = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.AppraiseTime);
}
else if (conMicroteachAppraise.IsVisual  ==  AttributeName[intIndex])
{
mbolIsVisual = TransNullToBool(value.ToString());
 AddUpdatedFld(conMicroteachAppraise.IsVisual);
}
else if (conMicroteachAppraise.IsElite  ==  AttributeName[intIndex])
{
mbolIsElite = TransNullToBool(value.ToString());
 AddUpdatedFld(conMicroteachAppraise.IsElite);
}
else if (conMicroteachAppraise.ExcellentOne  ==  AttributeName[intIndex])
{
mstrExcellentOne = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.ExcellentOne);
}
else if (conMicroteachAppraise.ExcellentTwo  ==  AttributeName[intIndex])
{
mstrExcellentTwo = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.ExcellentTwo);
}
else if (conMicroteachAppraise.SuggestOne  ==  AttributeName[intIndex])
{
mstrSuggestOne = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.SuggestOne);
}
else if (conMicroteachAppraise.SuggestTwo  ==  AttributeName[intIndex])
{
mstrSuggestTwo = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.SuggestTwo);
}
else if (conMicroteachAppraise.MicroteachAppriseScore  ==  AttributeName[intIndex])
{
mfltMicroteachAppriseScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conMicroteachAppraise.MicroteachAppriseScore);
}
else if (conMicroteachAppraise.VideoStopTime  ==  AttributeName[intIndex])
{
mstrVideoStopTime = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.VideoStopTime);
}
else if (conMicroteachAppraise.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conMicroteachAppraise.BrowseCount);
}
else if (conMicroteachAppraise.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conMicroteachAppraise.UserId);
}
}
}

/// <summary>
/// 评议流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdMicroteachAppraise
{
get
{
return mlngIdMicroteachAppraise;
}
set
{
 mlngIdMicroteachAppraise = value;
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.IdMicroteachAppraise);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.FuncModuleId);
}
}
/// <summary>
/// 微格教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroteachCase
{
get
{
return mstrIdMicroteachCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroteachCase = value;
}
else
{
 mstrIdMicroteachCase = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.IdMicroteachCase);
}
}
/// <summary>
/// 评议类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAppraiseType
{
get
{
return mstrIdAppraiseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAppraiseType = value;
}
else
{
 mstrIdAppraiseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.IdAppraiseType);
}
}
/// <summary>
/// 评议主题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTheme
{
get
{
return mstrAppraiseTheme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTheme = value;
}
else
{
 mstrAppraiseTheme = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.AppraiseTheme);
}
}
/// <summary>
/// 评议内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseContent
{
get
{
return mstrAppraiseContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseContent = value;
}
else
{
 mstrAppraiseContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.AppraiseContent);
}
}
/// <summary>
/// 评议日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseDate
{
get
{
return mstrAppraiseDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseDate = value;
}
else
{
 mstrAppraiseDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.AppraiseDate);
}
}
/// <summary>
/// 评议时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTime
{
get
{
return mstrAppraiseTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTime = value;
}
else
{
 mstrAppraiseTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.AppraiseTime);
}
}
/// <summary>
/// 隐藏标志(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisual
{
get
{
return mbolIsVisual;
}
set
{
 mbolIsVisual = value;
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.IsVisual);
}
}
/// <summary>
/// 精华标志(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsElite
{
get
{
return mbolIsElite;
}
set
{
 mbolIsElite = value;
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.IsElite);
}
}
/// <summary>
/// 优点1(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExcellentOne
{
get
{
return mstrExcellentOne;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExcellentOne = value;
}
else
{
 mstrExcellentOne = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.ExcellentOne);
}
}
/// <summary>
/// 优点2(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExcellentTwo
{
get
{
return mstrExcellentTwo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExcellentTwo = value;
}
else
{
 mstrExcellentTwo = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.ExcellentTwo);
}
}
/// <summary>
/// 建议1(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SuggestOne
{
get
{
return mstrSuggestOne;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSuggestOne = value;
}
else
{
 mstrSuggestOne = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.SuggestOne);
}
}
/// <summary>
/// 建议2(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SuggestTwo
{
get
{
return mstrSuggestTwo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSuggestTwo = value;
}
else
{
 mstrSuggestTwo = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.SuggestTwo);
}
}
/// <summary>
/// 打分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? MicroteachAppriseScore
{
get
{
return mfltMicroteachAppriseScore;
}
set
{
 mfltMicroteachAppriseScore = value;
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.MicroteachAppriseScore);
}
}
/// <summary>
/// 公开课案例视频暂停时间(说明:;字段类型:varchar;字段长度:48;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoStopTime
{
get
{
return mstrVideoStopTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoStopTime = value;
}
else
{
 mstrVideoStopTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.VideoStopTime);
}
}
/// <summary>
/// 浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseCount
{
get
{
return mintBrowseCount;
}
set
{
 mintBrowseCount = value;
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.BrowseCount);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachAppraise.UserId);
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
  return mlngIdMicroteachAppraise.ToString();
 }
 }
}
 /// <summary>
 /// 微格案例定性评议(MicroteachAppraise)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conMicroteachAppraise
{
public const string _CurrTabName = "MicroteachAppraise"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachAppraise"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachAppraise", "FuncModuleId", "IdMicroteachCase", "IdAppraiseType", "AppraiseTheme", "AppraiseContent", "AppraiseDate", "AppraiseTime", "IsVisual", "IsElite", "ExcellentOne", "ExcellentTwo", "SuggestOne", "SuggestTwo", "MicroteachAppriseScore", "VideoStopTime", "BrowseCount", "UserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroteachAppraise"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachAppraise = "IdMicroteachAppraise";    //评议流水号

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

 /// <summary>
 /// 常量:"IdAppraiseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAppraiseType = "IdAppraiseType";    //评议类型流水号

 /// <summary>
 /// 常量:"AppraiseTheme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTheme = "AppraiseTheme";    //评议主题

 /// <summary>
 /// 常量:"AppraiseContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseContent = "AppraiseContent";    //评议内容

 /// <summary>
 /// 常量:"AppraiseDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseDate = "AppraiseDate";    //评议日期

 /// <summary>
 /// 常量:"AppraiseTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTime = "AppraiseTime";    //评议时间

 /// <summary>
 /// 常量:"IsVisual"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisual = "IsVisual";    //隐藏标志

 /// <summary>
 /// 常量:"IsElite"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsElite = "IsElite";    //精华标志

 /// <summary>
 /// 常量:"ExcellentOne"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellentOne = "ExcellentOne";    //优点1

 /// <summary>
 /// 常量:"ExcellentTwo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExcellentTwo = "ExcellentTwo";    //优点2

 /// <summary>
 /// 常量:"SuggestOne"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SuggestOne = "SuggestOne";    //建议1

 /// <summary>
 /// 常量:"SuggestTwo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SuggestTwo = "SuggestTwo";    //建议2

 /// <summary>
 /// 常量:"MicroteachAppriseScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroteachAppriseScore = "MicroteachAppriseScore";    //打分

 /// <summary>
 /// 常量:"VideoStopTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoStopTime = "VideoStopTime";    //公开课案例视频暂停时间

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID
}

}