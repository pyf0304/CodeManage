
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperReportEN
 表名:gs_PaperReport(01120772)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:00
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
 /// 表gs_PaperReport的关键字(ReportId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ReportId_gs_PaperReport
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strReportId">表关键字</param>
public K_ReportId_gs_PaperReport(string strReportId)
{
if (IsValid(strReportId)) Value = strReportId;
else
{
Value = null;
}
}
private static bool IsValid(string strReportId)
{
if (string.IsNullOrEmpty(strReportId) == true) return false;
if (strReportId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ReportId_gs_PaperReport]类型的对象</returns>
public static implicit operator K_ReportId_gs_PaperReport(string value)
{
return new K_ReportId_gs_PaperReport(value);
}
}
 /// <summary>
 /// 论文汇报表(gs_PaperReport)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_PaperReportEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_PaperReport"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ReportId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 22;
public static string[] AttributeName = new string[] {"ReportId", "TopicId", "PaperId", "ReportContent", "IsSubmit", "ReportUser", "ReportDate", "VersionCount", "OkCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "PDFUrl", "PPTUrl", "Month", "Week", "Year", "IdCurrEduCls", "UpdUser", "UpdDate", "Memo"};

protected string mstrReportId;    //汇报Id
protected string mstrTopicId;    //主题Id
protected string mstrPaperId;    //论文Id
protected string mstrReportContent;    //汇报内容
protected bool mbolIsSubmit;    //是否提交
protected string mstrReportUser;    //汇报用户
protected string mstrReportDate;    //汇报日期
protected int? mintVersionCount;    //版本统计
protected int? mintOkCount;    //点赞统计
protected int? mintAppraiseCount;    //评论数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrPDFUrl;    //PDFUrl
protected string mstrPPTUrl;    //PPTUrl
protected string mstrMonth;    //月
protected int? mintWeek;    //周
protected string mstrYear;    //年
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_PaperReportEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ReportId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strReportId">关键字:汇报Id</param>
public clsgs_PaperReportEN(string strReportId)
 {
strReportId = strReportId.Replace("'", "''");
if (strReportId.Length > 10)
{
throw new Exception("在表:gs_PaperReport中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strReportId)  ==  true)
{
throw new Exception("在表:gs_PaperReport中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strReportId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrReportId = strReportId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ReportId");
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
if (strAttributeName  ==  congs_PaperReport.ReportId)
{
return mstrReportId;
}
else if (strAttributeName  ==  congs_PaperReport.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  congs_PaperReport.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  congs_PaperReport.ReportContent)
{
return mstrReportContent;
}
else if (strAttributeName  ==  congs_PaperReport.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  congs_PaperReport.ReportUser)
{
return mstrReportUser;
}
else if (strAttributeName  ==  congs_PaperReport.ReportDate)
{
return mstrReportDate;
}
else if (strAttributeName  ==  congs_PaperReport.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  congs_PaperReport.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  congs_PaperReport.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  congs_PaperReport.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  congs_PaperReport.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  congs_PaperReport.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  congs_PaperReport.PDFUrl)
{
return mstrPDFUrl;
}
else if (strAttributeName  ==  congs_PaperReport.PPTUrl)
{
return mstrPPTUrl;
}
else if (strAttributeName  ==  congs_PaperReport.Month)
{
return mstrMonth;
}
else if (strAttributeName  ==  congs_PaperReport.Week)
{
return mintWeek;
}
else if (strAttributeName  ==  congs_PaperReport.Year)
{
return mstrYear;
}
else if (strAttributeName  ==  congs_PaperReport.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  congs_PaperReport.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_PaperReport.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_PaperReport.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_PaperReport.ReportId)
{
mstrReportId = value.ToString();
 AddUpdatedFld(congs_PaperReport.ReportId);
}
else if (strAttributeName  ==  congs_PaperReport.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_PaperReport.TopicId);
}
else if (strAttributeName  ==  congs_PaperReport.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(congs_PaperReport.PaperId);
}
else if (strAttributeName  ==  congs_PaperReport.ReportContent)
{
mstrReportContent = value.ToString();
 AddUpdatedFld(congs_PaperReport.ReportContent);
}
else if (strAttributeName  ==  congs_PaperReport.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_PaperReport.IsSubmit);
}
else if (strAttributeName  ==  congs_PaperReport.ReportUser)
{
mstrReportUser = value.ToString();
 AddUpdatedFld(congs_PaperReport.ReportUser);
}
else if (strAttributeName  ==  congs_PaperReport.ReportDate)
{
mstrReportDate = value.ToString();
 AddUpdatedFld(congs_PaperReport.ReportDate);
}
else if (strAttributeName  ==  congs_PaperReport.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_PaperReport.VersionCount);
}
else if (strAttributeName  ==  congs_PaperReport.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_PaperReport.OkCount);
}
else if (strAttributeName  ==  congs_PaperReport.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_PaperReport.AppraiseCount);
}
else if (strAttributeName  ==  congs_PaperReport.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(congs_PaperReport.Score);
}
else if (strAttributeName  ==  congs_PaperReport.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(congs_PaperReport.StuScore);
}
else if (strAttributeName  ==  congs_PaperReport.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(congs_PaperReport.TeaScore);
}
else if (strAttributeName  ==  congs_PaperReport.PDFUrl)
{
mstrPDFUrl = value.ToString();
 AddUpdatedFld(congs_PaperReport.PDFUrl);
}
else if (strAttributeName  ==  congs_PaperReport.PPTUrl)
{
mstrPPTUrl = value.ToString();
 AddUpdatedFld(congs_PaperReport.PPTUrl);
}
else if (strAttributeName  ==  congs_PaperReport.Month)
{
mstrMonth = value.ToString();
 AddUpdatedFld(congs_PaperReport.Month);
}
else if (strAttributeName  ==  congs_PaperReport.Week)
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_PaperReport.Week);
}
else if (strAttributeName  ==  congs_PaperReport.Year)
{
mstrYear = value.ToString();
 AddUpdatedFld(congs_PaperReport.Year);
}
else if (strAttributeName  ==  congs_PaperReport.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_PaperReport.IdCurrEduCls);
}
else if (strAttributeName  ==  congs_PaperReport.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_PaperReport.UpdUser);
}
else if (strAttributeName  ==  congs_PaperReport.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_PaperReport.UpdDate);
}
else if (strAttributeName  ==  congs_PaperReport.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_PaperReport.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_PaperReport.ReportId  ==  AttributeName[intIndex])
{
return mstrReportId;
}
else if (congs_PaperReport.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (congs_PaperReport.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (congs_PaperReport.ReportContent  ==  AttributeName[intIndex])
{
return mstrReportContent;
}
else if (congs_PaperReport.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (congs_PaperReport.ReportUser  ==  AttributeName[intIndex])
{
return mstrReportUser;
}
else if (congs_PaperReport.ReportDate  ==  AttributeName[intIndex])
{
return mstrReportDate;
}
else if (congs_PaperReport.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (congs_PaperReport.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (congs_PaperReport.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (congs_PaperReport.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (congs_PaperReport.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (congs_PaperReport.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (congs_PaperReport.PDFUrl  ==  AttributeName[intIndex])
{
return mstrPDFUrl;
}
else if (congs_PaperReport.PPTUrl  ==  AttributeName[intIndex])
{
return mstrPPTUrl;
}
else if (congs_PaperReport.Month  ==  AttributeName[intIndex])
{
return mstrMonth;
}
else if (congs_PaperReport.Week  ==  AttributeName[intIndex])
{
return mintWeek;
}
else if (congs_PaperReport.Year  ==  AttributeName[intIndex])
{
return mstrYear;
}
else if (congs_PaperReport.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (congs_PaperReport.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_PaperReport.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_PaperReport.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_PaperReport.ReportId  ==  AttributeName[intIndex])
{
mstrReportId = value.ToString();
 AddUpdatedFld(congs_PaperReport.ReportId);
}
else if (congs_PaperReport.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(congs_PaperReport.TopicId);
}
else if (congs_PaperReport.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(congs_PaperReport.PaperId);
}
else if (congs_PaperReport.ReportContent  ==  AttributeName[intIndex])
{
mstrReportContent = value.ToString();
 AddUpdatedFld(congs_PaperReport.ReportContent);
}
else if (congs_PaperReport.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(congs_PaperReport.IsSubmit);
}
else if (congs_PaperReport.ReportUser  ==  AttributeName[intIndex])
{
mstrReportUser = value.ToString();
 AddUpdatedFld(congs_PaperReport.ReportUser);
}
else if (congs_PaperReport.ReportDate  ==  AttributeName[intIndex])
{
mstrReportDate = value.ToString();
 AddUpdatedFld(congs_PaperReport.ReportDate);
}
else if (congs_PaperReport.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_PaperReport.VersionCount);
}
else if (congs_PaperReport.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_PaperReport.OkCount);
}
else if (congs_PaperReport.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_PaperReport.AppraiseCount);
}
else if (congs_PaperReport.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(congs_PaperReport.Score);
}
else if (congs_PaperReport.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(congs_PaperReport.StuScore);
}
else if (congs_PaperReport.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(congs_PaperReport.TeaScore);
}
else if (congs_PaperReport.PDFUrl  ==  AttributeName[intIndex])
{
mstrPDFUrl = value.ToString();
 AddUpdatedFld(congs_PaperReport.PDFUrl);
}
else if (congs_PaperReport.PPTUrl  ==  AttributeName[intIndex])
{
mstrPPTUrl = value.ToString();
 AddUpdatedFld(congs_PaperReport.PPTUrl);
}
else if (congs_PaperReport.Month  ==  AttributeName[intIndex])
{
mstrMonth = value.ToString();
 AddUpdatedFld(congs_PaperReport.Month);
}
else if (congs_PaperReport.Week  ==  AttributeName[intIndex])
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_PaperReport.Week);
}
else if (congs_PaperReport.Year  ==  AttributeName[intIndex])
{
mstrYear = value.ToString();
 AddUpdatedFld(congs_PaperReport.Year);
}
else if (congs_PaperReport.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_PaperReport.IdCurrEduCls);
}
else if (congs_PaperReport.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_PaperReport.UpdUser);
}
else if (congs_PaperReport.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_PaperReport.UpdDate);
}
else if (congs_PaperReport.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_PaperReport.Memo);
}
}
}

/// <summary>
/// 汇报Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReportId
{
get
{
return mstrReportId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReportId = value;
}
else
{
 mstrReportId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperReport.ReportId);
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
 AddUpdatedFld(congs_PaperReport.TopicId);
}
}
/// <summary>
/// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperId
{
get
{
return mstrPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperId = value;
}
else
{
 mstrPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperReport.PaperId);
}
}
/// <summary>
/// 汇报内容(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReportContent
{
get
{
return mstrReportContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReportContent = value;
}
else
{
 mstrReportContent = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperReport.ReportContent);
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
 AddUpdatedFld(congs_PaperReport.IsSubmit);
}
}
/// <summary>
/// 汇报用户(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReportUser
{
get
{
return mstrReportUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReportUser = value;
}
else
{
 mstrReportUser = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperReport.ReportUser);
}
}
/// <summary>
/// 汇报日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReportDate
{
get
{
return mstrReportDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReportDate = value;
}
else
{
 mstrReportDate = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperReport.ReportDate);
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
 AddUpdatedFld(congs_PaperReport.VersionCount);
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
 AddUpdatedFld(congs_PaperReport.OkCount);
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
 AddUpdatedFld(congs_PaperReport.AppraiseCount);
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
 AddUpdatedFld(congs_PaperReport.Score);
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
 AddUpdatedFld(congs_PaperReport.StuScore);
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
 AddUpdatedFld(congs_PaperReport.TeaScore);
}
}
/// <summary>
/// PDFUrl(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PDFUrl
{
get
{
return mstrPDFUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPDFUrl = value;
}
else
{
 mstrPDFUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperReport.PDFUrl);
}
}
/// <summary>
/// PPTUrl(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PPTUrl
{
get
{
return mstrPPTUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPPTUrl = value;
}
else
{
 mstrPPTUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperReport.PPTUrl);
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
 AddUpdatedFld(congs_PaperReport.Month);
}
}
/// <summary>
/// 周(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Week
{
get
{
return mintWeek;
}
set
{
 mintWeek = value;
//记录修改过的字段
 AddUpdatedFld(congs_PaperReport.Week);
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
 AddUpdatedFld(congs_PaperReport.Year);
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
 AddUpdatedFld(congs_PaperReport.IdCurrEduCls);
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
 AddUpdatedFld(congs_PaperReport.UpdUser);
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
 AddUpdatedFld(congs_PaperReport.UpdDate);
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
 AddUpdatedFld(congs_PaperReport.Memo);
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
  return mstrReportId;
 }
 }
}
 /// <summary>
 /// 论文汇报表(gs_PaperReport)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_PaperReport
{
public const string _CurrTabName = "gs_PaperReport"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ReportId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ReportId", "TopicId", "PaperId", "ReportContent", "IsSubmit", "ReportUser", "ReportDate", "VersionCount", "OkCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "PDFUrl", "PPTUrl", "Month", "Week", "Year", "IdCurrEduCls", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ReportId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReportId = "ReportId";    //汇报Id

 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"ReportContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReportContent = "ReportContent";    //汇报内容

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"ReportUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReportUser = "ReportUser";    //汇报用户

 /// <summary>
 /// 常量:"ReportDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReportDate = "ReportDate";    //汇报日期

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数

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
 /// 常量:"PDFUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PDFUrl = "PDFUrl";    //PDFUrl

 /// <summary>
 /// 常量:"PPTUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PPTUrl = "PPTUrl";    //PPTUrl

 /// <summary>
 /// 常量:"Month"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Month = "Month";    //月

 /// <summary>
 /// 常量:"Week"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Week = "Week";    //周

 /// <summary>
 /// 常量:"Year"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Year = "Year";    //年

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

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