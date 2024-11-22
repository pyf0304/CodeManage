
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTopicObjectiveEN
 表名:TopicObjective(01120613)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:45
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
 /// 表TopicObjective的关键字(TopicObjectiveId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TopicObjectiveId_TopicObjective
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTopicObjectiveId">表关键字</param>
public K_TopicObjectiveId_TopicObjective(string strTopicObjectiveId)
{
if (IsValid(strTopicObjectiveId)) Value = strTopicObjectiveId;
else
{
Value = null;
}
}
private static bool IsValid(string strTopicObjectiveId)
{
if (string.IsNullOrEmpty(strTopicObjectiveId) == true) return false;
if (strTopicObjectiveId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TopicObjectiveId_TopicObjective]类型的对象</returns>
public static implicit operator K_TopicObjectiveId_TopicObjective(string value)
{
return new K_TopicObjectiveId_TopicObjective(value);
}
}
 /// <summary>
 /// 主题客观表(TopicObjective)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTopicObjectiveEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TopicObjective"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TopicObjectiveId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 22;
public static string[] AttributeName = new string[] {"TopicObjectiveId", "ObjectiveName", "ObjectiveContent", "ObjectiveType", "SourceId", "Conclusion", "IsSubmit", "AppraiseCount", "OkCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "CreateDate", "ShareId", "UpdUser", "UpdDate", "Memo"};

protected string mstrTopicObjectiveId;    //客观Id
protected string mstrObjectiveName;    //客观名称
protected string mstrObjectiveContent;    //客观内容
protected string mstrObjectiveType;    //客观类型
protected string mstrSourceId;    //来源Id
protected string mstrConclusion;    //结论
protected bool mbolIsSubmit;    //是否提交
protected int? mintAppraiseCount;    //评论数
protected int? mintOkCount;    //点赞统计
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected int? mintCitationCount;    //引用统计
protected int? mintVersionCount;    //版本统计
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTopicObjectiveEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicObjectiveId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTopicObjectiveId">关键字:客观Id</param>
public clsTopicObjectiveEN(string strTopicObjectiveId)
 {
strTopicObjectiveId = strTopicObjectiveId.Replace("'", "''");
if (strTopicObjectiveId.Length > 8)
{
throw new Exception("在表:TopicObjective中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTopicObjectiveId)  ==  true)
{
throw new Exception("在表:TopicObjective中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTopicObjectiveId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTopicObjectiveId = strTopicObjectiveId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicObjectiveId");
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
if (strAttributeName  ==  conTopicObjective.TopicObjectiveId)
{
return mstrTopicObjectiveId;
}
else if (strAttributeName  ==  conTopicObjective.ObjectiveName)
{
return mstrObjectiveName;
}
else if (strAttributeName  ==  conTopicObjective.ObjectiveContent)
{
return mstrObjectiveContent;
}
else if (strAttributeName  ==  conTopicObjective.ObjectiveType)
{
return mstrObjectiveType;
}
else if (strAttributeName  ==  conTopicObjective.SourceId)
{
return mstrSourceId;
}
else if (strAttributeName  ==  conTopicObjective.Conclusion)
{
return mstrConclusion;
}
else if (strAttributeName  ==  conTopicObjective.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conTopicObjective.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  conTopicObjective.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  conTopicObjective.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conTopicObjective.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  conTopicObjective.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  conTopicObjective.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conTopicObjective.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  conTopicObjective.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  conTopicObjective.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  conTopicObjective.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  conTopicObjective.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conTopicObjective.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  conTopicObjective.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conTopicObjective.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conTopicObjective.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTopicObjective.TopicObjectiveId)
{
mstrTopicObjectiveId = value.ToString();
 AddUpdatedFld(conTopicObjective.TopicObjectiveId);
}
else if (strAttributeName  ==  conTopicObjective.ObjectiveName)
{
mstrObjectiveName = value.ToString();
 AddUpdatedFld(conTopicObjective.ObjectiveName);
}
else if (strAttributeName  ==  conTopicObjective.ObjectiveContent)
{
mstrObjectiveContent = value.ToString();
 AddUpdatedFld(conTopicObjective.ObjectiveContent);
}
else if (strAttributeName  ==  conTopicObjective.ObjectiveType)
{
mstrObjectiveType = value.ToString();
 AddUpdatedFld(conTopicObjective.ObjectiveType);
}
else if (strAttributeName  ==  conTopicObjective.SourceId)
{
mstrSourceId = value.ToString();
 AddUpdatedFld(conTopicObjective.SourceId);
}
else if (strAttributeName  ==  conTopicObjective.Conclusion)
{
mstrConclusion = value.ToString();
 AddUpdatedFld(conTopicObjective.Conclusion);
}
else if (strAttributeName  ==  conTopicObjective.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conTopicObjective.IsSubmit);
}
else if (strAttributeName  ==  conTopicObjective.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTopicObjective.AppraiseCount);
}
else if (strAttributeName  ==  conTopicObjective.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTopicObjective.OkCount);
}
else if (strAttributeName  ==  conTopicObjective.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conTopicObjective.Score);
}
else if (strAttributeName  ==  conTopicObjective.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conTopicObjective.StuScore);
}
else if (strAttributeName  ==  conTopicObjective.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conTopicObjective.TeaScore);
}
else if (strAttributeName  ==  conTopicObjective.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conTopicObjective.IdCurrEduCls);
}
else if (strAttributeName  ==  conTopicObjective.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conTopicObjective.PdfContent);
}
else if (strAttributeName  ==  conTopicObjective.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conTopicObjective.PdfPageNum);
}
else if (strAttributeName  ==  conTopicObjective.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTopicObjective.CitationCount);
}
else if (strAttributeName  ==  conTopicObjective.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTopicObjective.VersionCount);
}
else if (strAttributeName  ==  conTopicObjective.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conTopicObjective.CreateDate);
}
else if (strAttributeName  ==  conTopicObjective.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(conTopicObjective.ShareId);
}
else if (strAttributeName  ==  conTopicObjective.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conTopicObjective.UpdUser);
}
else if (strAttributeName  ==  conTopicObjective.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTopicObjective.UpdDate);
}
else if (strAttributeName  ==  conTopicObjective.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTopicObjective.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTopicObjective.TopicObjectiveId  ==  AttributeName[intIndex])
{
return mstrTopicObjectiveId;
}
else if (conTopicObjective.ObjectiveName  ==  AttributeName[intIndex])
{
return mstrObjectiveName;
}
else if (conTopicObjective.ObjectiveContent  ==  AttributeName[intIndex])
{
return mstrObjectiveContent;
}
else if (conTopicObjective.ObjectiveType  ==  AttributeName[intIndex])
{
return mstrObjectiveType;
}
else if (conTopicObjective.SourceId  ==  AttributeName[intIndex])
{
return mstrSourceId;
}
else if (conTopicObjective.Conclusion  ==  AttributeName[intIndex])
{
return mstrConclusion;
}
else if (conTopicObjective.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conTopicObjective.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (conTopicObjective.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (conTopicObjective.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conTopicObjective.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (conTopicObjective.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (conTopicObjective.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conTopicObjective.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (conTopicObjective.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (conTopicObjective.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (conTopicObjective.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (conTopicObjective.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conTopicObjective.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (conTopicObjective.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conTopicObjective.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conTopicObjective.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTopicObjective.TopicObjectiveId  ==  AttributeName[intIndex])
{
mstrTopicObjectiveId = value.ToString();
 AddUpdatedFld(conTopicObjective.TopicObjectiveId);
}
else if (conTopicObjective.ObjectiveName  ==  AttributeName[intIndex])
{
mstrObjectiveName = value.ToString();
 AddUpdatedFld(conTopicObjective.ObjectiveName);
}
else if (conTopicObjective.ObjectiveContent  ==  AttributeName[intIndex])
{
mstrObjectiveContent = value.ToString();
 AddUpdatedFld(conTopicObjective.ObjectiveContent);
}
else if (conTopicObjective.ObjectiveType  ==  AttributeName[intIndex])
{
mstrObjectiveType = value.ToString();
 AddUpdatedFld(conTopicObjective.ObjectiveType);
}
else if (conTopicObjective.SourceId  ==  AttributeName[intIndex])
{
mstrSourceId = value.ToString();
 AddUpdatedFld(conTopicObjective.SourceId);
}
else if (conTopicObjective.Conclusion  ==  AttributeName[intIndex])
{
mstrConclusion = value.ToString();
 AddUpdatedFld(conTopicObjective.Conclusion);
}
else if (conTopicObjective.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conTopicObjective.IsSubmit);
}
else if (conTopicObjective.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTopicObjective.AppraiseCount);
}
else if (conTopicObjective.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTopicObjective.OkCount);
}
else if (conTopicObjective.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conTopicObjective.Score);
}
else if (conTopicObjective.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conTopicObjective.StuScore);
}
else if (conTopicObjective.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conTopicObjective.TeaScore);
}
else if (conTopicObjective.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conTopicObjective.IdCurrEduCls);
}
else if (conTopicObjective.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conTopicObjective.PdfContent);
}
else if (conTopicObjective.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conTopicObjective.PdfPageNum);
}
else if (conTopicObjective.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTopicObjective.CitationCount);
}
else if (conTopicObjective.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTopicObjective.VersionCount);
}
else if (conTopicObjective.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conTopicObjective.CreateDate);
}
else if (conTopicObjective.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(conTopicObjective.ShareId);
}
else if (conTopicObjective.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conTopicObjective.UpdUser);
}
else if (conTopicObjective.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTopicObjective.UpdDate);
}
else if (conTopicObjective.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTopicObjective.Memo);
}
}
}

/// <summary>
/// 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicObjectiveId
{
get
{
return mstrTopicObjectiveId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicObjectiveId = value;
}
else
{
 mstrTopicObjectiveId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicObjective.TopicObjectiveId);
}
}
/// <summary>
/// 客观名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveName
{
get
{
return mstrObjectiveName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveName = value;
}
else
{
 mstrObjectiveName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicObjective.ObjectiveName);
}
}
/// <summary>
/// 客观内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveContent
{
get
{
return mstrObjectiveContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveContent = value;
}
else
{
 mstrObjectiveContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicObjective.ObjectiveContent);
}
}
/// <summary>
/// 客观类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveType
{
get
{
return mstrObjectiveType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveType = value;
}
else
{
 mstrObjectiveType = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicObjective.ObjectiveType);
}
}
/// <summary>
/// 来源Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourceId
{
get
{
return mstrSourceId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourceId = value;
}
else
{
 mstrSourceId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicObjective.SourceId);
}
}
/// <summary>
/// 结论(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Conclusion
{
get
{
return mstrConclusion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConclusion = value;
}
else
{
 mstrConclusion = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicObjective.Conclusion);
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
 AddUpdatedFld(conTopicObjective.IsSubmit);
}
}
/// <summary>
/// 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AppraiseCount
{
get
{
return mintAppraiseCount;
}
set
{
 mintAppraiseCount = value;
//记录修改过的字段
 AddUpdatedFld(conTopicObjective.AppraiseCount);
}
}
/// <summary>
/// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OkCount
{
get
{
return mintOkCount;
}
set
{
 mintOkCount = value;
//记录修改过的字段
 AddUpdatedFld(conTopicObjective.OkCount);
}
}
/// <summary>
/// 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? Score
{
get
{
return mfltScore;
}
set
{
 mfltScore = value;
//记录修改过的字段
 AddUpdatedFld(conTopicObjective.Score);
}
}
/// <summary>
/// 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? StuScore
{
get
{
return mfltStuScore;
}
set
{
 mfltStuScore = value;
//记录修改过的字段
 AddUpdatedFld(conTopicObjective.StuScore);
}
}
/// <summary>
/// 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? TeaScore
{
get
{
return mfltTeaScore;
}
set
{
 mfltTeaScore = value;
//记录修改过的字段
 AddUpdatedFld(conTopicObjective.TeaScore);
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
 AddUpdatedFld(conTopicObjective.IdCurrEduCls);
}
}
/// <summary>
/// Pdf内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfContent
{
get
{
return mstrPdfContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfContent = value;
}
else
{
 mstrPdfContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicObjective.PdfContent);
}
}
/// <summary>
/// Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PdfPageNum
{
get
{
return mintPdfPageNum;
}
set
{
 mintPdfPageNum = value;
//记录修改过的字段
 AddUpdatedFld(conTopicObjective.PdfPageNum);
}
}
/// <summary>
/// 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CitationCount
{
get
{
return mintCitationCount;
}
set
{
 mintCitationCount = value;
//记录修改过的字段
 AddUpdatedFld(conTopicObjective.CitationCount);
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
 AddUpdatedFld(conTopicObjective.VersionCount);
}
}
/// <summary>
/// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateDate
{
get
{
return mstrCreateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateDate = value;
}
else
{
 mstrCreateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicObjective.CreateDate);
}
}
/// <summary>
/// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ShareId
{
get
{
return mstrShareId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrShareId = value;
}
else
{
 mstrShareId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTopicObjective.ShareId);
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
 AddUpdatedFld(conTopicObjective.UpdUser);
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
 AddUpdatedFld(conTopicObjective.UpdDate);
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
 AddUpdatedFld(conTopicObjective.Memo);
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
  return mstrTopicObjectiveId;
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
  return mstrObjectiveName;
 }
 }
}
 /// <summary>
 /// 主题客观表(TopicObjective)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTopicObjective
{
public const string _CurrTabName = "TopicObjective"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TopicObjectiveId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TopicObjectiveId", "ObjectiveName", "ObjectiveContent", "ObjectiveType", "SourceId", "Conclusion", "IsSubmit", "AppraiseCount", "OkCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "CreateDate", "ShareId", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TopicObjectiveId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicObjectiveId = "TopicObjectiveId";    //客观Id

 /// <summary>
 /// 常量:"ObjectiveName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveName = "ObjectiveName";    //客观名称

 /// <summary>
 /// 常量:"ObjectiveContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveContent = "ObjectiveContent";    //客观内容

 /// <summary>
 /// 常量:"ObjectiveType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveType = "ObjectiveType";    //客观类型

 /// <summary>
 /// 常量:"SourceId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceId = "SourceId";    //来源Id

 /// <summary>
 /// 常量:"Conclusion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Conclusion = "Conclusion";    //结论

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"StuScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuScore = "StuScore";    //学生平均分

 /// <summary>
 /// 常量:"TeaScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaScore = "TeaScore";    //教师评分

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"PdfContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfContent = "PdfContent";    //Pdf内容

 /// <summary>
 /// 常量:"PdfPageNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNum = "PdfPageNum";    //Pdf页码

 /// <summary>
 /// 常量:"CitationCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationCount = "CitationCount";    //引用统计

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"ShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareId = "ShareId";    //分享Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}