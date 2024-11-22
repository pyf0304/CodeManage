
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PaperReportEN
 表名:vgs_PaperReport(01120771)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:52:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表vgs_PaperReport的关键字(ReportId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ReportId_vgs_PaperReport
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
public K_ReportId_vgs_PaperReport(string strReportId)
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
 /// <returns>返回:[K_ReportId_vgs_PaperReport]类型的对象</returns>
public static implicit operator K_ReportId_vgs_PaperReport(string value)
{
return new K_ReportId_vgs_PaperReport(value);
}
}
 /// <summary>
 /// 论文汇报视图(vgs_PaperReport)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvgs_PaperReportEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vgs_PaperReport"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ReportId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 24;
public static string[] AttributeName = new string[] {"Memo", "ReportId", "UpdDate", "TopicName", "TopicId", "PaperId", "PaperTitle", "ReportContent", "IdCurrEduCls", "IsSubmit", "ReportUser", "ReportDate", "UpdUser", "VersionCount", "OkCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "PDFUrl", "PPTUrl", "Month", "Week", "Year"};

protected string mstrMemo;    //备注
protected string mstrReportId;    //汇报Id
protected string mstrUpdDate;    //修改日期
protected string mstrTopicName;    //栏目主题
protected string mstrTopicId;    //主题Id
protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected string mstrReportContent;    //汇报内容
protected string mstrIdCurrEduCls;    //教学班流水号
protected bool mbolIsSubmit;    //是否提交
protected string mstrReportUser;    //汇报用户
protected string mstrReportDate;    //汇报日期
protected string mstrUpdUser;    //修改人
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

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvgs_PaperReportEN()
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
public clsvgs_PaperReportEN(string strReportId)
 {
strReportId = strReportId.Replace("'", "''");
if (strReportId.Length > 10)
{
throw new Exception("在表:vgs_PaperReport中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strReportId)  ==  true)
{
throw new Exception("在表:vgs_PaperReport中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convgs_PaperReport.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convgs_PaperReport.ReportId)
{
return mstrReportId;
}
else if (strAttributeName  ==  convgs_PaperReport.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convgs_PaperReport.TopicName)
{
return mstrTopicName;
}
else if (strAttributeName  ==  convgs_PaperReport.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  convgs_PaperReport.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convgs_PaperReport.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convgs_PaperReport.ReportContent)
{
return mstrReportContent;
}
else if (strAttributeName  ==  convgs_PaperReport.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convgs_PaperReport.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convgs_PaperReport.ReportUser)
{
return mstrReportUser;
}
else if (strAttributeName  ==  convgs_PaperReport.ReportDate)
{
return mstrReportDate;
}
else if (strAttributeName  ==  convgs_PaperReport.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convgs_PaperReport.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convgs_PaperReport.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convgs_PaperReport.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convgs_PaperReport.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convgs_PaperReport.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convgs_PaperReport.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convgs_PaperReport.PDFUrl)
{
return mstrPDFUrl;
}
else if (strAttributeName  ==  convgs_PaperReport.PPTUrl)
{
return mstrPPTUrl;
}
else if (strAttributeName  ==  convgs_PaperReport.Month)
{
return mstrMonth;
}
else if (strAttributeName  ==  convgs_PaperReport.Week)
{
return mintWeek;
}
else if (strAttributeName  ==  convgs_PaperReport.Year)
{
return mstrYear;
}
return null;
}
set
{
if (strAttributeName  ==  convgs_PaperReport.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_PaperReport.Memo);
}
else if (strAttributeName  ==  convgs_PaperReport.ReportId)
{
mstrReportId = value.ToString();
 AddUpdatedFld(convgs_PaperReport.ReportId);
}
else if (strAttributeName  ==  convgs_PaperReport.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PaperReport.UpdDate);
}
else if (strAttributeName  ==  convgs_PaperReport.TopicName)
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convgs_PaperReport.TopicName);
}
else if (strAttributeName  ==  convgs_PaperReport.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convgs_PaperReport.TopicId);
}
else if (strAttributeName  ==  convgs_PaperReport.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PaperReport.PaperId);
}
else if (strAttributeName  ==  convgs_PaperReport.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_PaperReport.PaperTitle);
}
else if (strAttributeName  ==  convgs_PaperReport.ReportContent)
{
mstrReportContent = value.ToString();
 AddUpdatedFld(convgs_PaperReport.ReportContent);
}
else if (strAttributeName  ==  convgs_PaperReport.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convgs_PaperReport.IdCurrEduCls);
}
else if (strAttributeName  ==  convgs_PaperReport.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PaperReport.IsSubmit);
}
else if (strAttributeName  ==  convgs_PaperReport.ReportUser)
{
mstrReportUser = value.ToString();
 AddUpdatedFld(convgs_PaperReport.ReportUser);
}
else if (strAttributeName  ==  convgs_PaperReport.ReportDate)
{
mstrReportDate = value.ToString();
 AddUpdatedFld(convgs_PaperReport.ReportDate);
}
else if (strAttributeName  ==  convgs_PaperReport.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PaperReport.UpdUser);
}
else if (strAttributeName  ==  convgs_PaperReport.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperReport.VersionCount);
}
else if (strAttributeName  ==  convgs_PaperReport.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperReport.OkCount);
}
else if (strAttributeName  ==  convgs_PaperReport.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperReport.AppraiseCount);
}
else if (strAttributeName  ==  convgs_PaperReport.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PaperReport.Score);
}
else if (strAttributeName  ==  convgs_PaperReport.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PaperReport.StuScore);
}
else if (strAttributeName  ==  convgs_PaperReport.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PaperReport.TeaScore);
}
else if (strAttributeName  ==  convgs_PaperReport.PDFUrl)
{
mstrPDFUrl = value.ToString();
 AddUpdatedFld(convgs_PaperReport.PDFUrl);
}
else if (strAttributeName  ==  convgs_PaperReport.PPTUrl)
{
mstrPPTUrl = value.ToString();
 AddUpdatedFld(convgs_PaperReport.PPTUrl);
}
else if (strAttributeName  ==  convgs_PaperReport.Month)
{
mstrMonth = value.ToString();
 AddUpdatedFld(convgs_PaperReport.Month);
}
else if (strAttributeName  ==  convgs_PaperReport.Week)
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperReport.Week);
}
else if (strAttributeName  ==  convgs_PaperReport.Year)
{
mstrYear = value.ToString();
 AddUpdatedFld(convgs_PaperReport.Year);
}
}
}
public object this[int intIndex]
{
get
{
if (convgs_PaperReport.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convgs_PaperReport.ReportId  ==  AttributeName[intIndex])
{
return mstrReportId;
}
else if (convgs_PaperReport.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convgs_PaperReport.TopicName  ==  AttributeName[intIndex])
{
return mstrTopicName;
}
else if (convgs_PaperReport.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (convgs_PaperReport.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convgs_PaperReport.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convgs_PaperReport.ReportContent  ==  AttributeName[intIndex])
{
return mstrReportContent;
}
else if (convgs_PaperReport.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convgs_PaperReport.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convgs_PaperReport.ReportUser  ==  AttributeName[intIndex])
{
return mstrReportUser;
}
else if (convgs_PaperReport.ReportDate  ==  AttributeName[intIndex])
{
return mstrReportDate;
}
else if (convgs_PaperReport.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convgs_PaperReport.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convgs_PaperReport.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convgs_PaperReport.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convgs_PaperReport.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convgs_PaperReport.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convgs_PaperReport.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convgs_PaperReport.PDFUrl  ==  AttributeName[intIndex])
{
return mstrPDFUrl;
}
else if (convgs_PaperReport.PPTUrl  ==  AttributeName[intIndex])
{
return mstrPPTUrl;
}
else if (convgs_PaperReport.Month  ==  AttributeName[intIndex])
{
return mstrMonth;
}
else if (convgs_PaperReport.Week  ==  AttributeName[intIndex])
{
return mintWeek;
}
else if (convgs_PaperReport.Year  ==  AttributeName[intIndex])
{
return mstrYear;
}
return null;
}
set
{
if (convgs_PaperReport.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_PaperReport.Memo);
}
else if (convgs_PaperReport.ReportId  ==  AttributeName[intIndex])
{
mstrReportId = value.ToString();
 AddUpdatedFld(convgs_PaperReport.ReportId);
}
else if (convgs_PaperReport.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PaperReport.UpdDate);
}
else if (convgs_PaperReport.TopicName  ==  AttributeName[intIndex])
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convgs_PaperReport.TopicName);
}
else if (convgs_PaperReport.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convgs_PaperReport.TopicId);
}
else if (convgs_PaperReport.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PaperReport.PaperId);
}
else if (convgs_PaperReport.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_PaperReport.PaperTitle);
}
else if (convgs_PaperReport.ReportContent  ==  AttributeName[intIndex])
{
mstrReportContent = value.ToString();
 AddUpdatedFld(convgs_PaperReport.ReportContent);
}
else if (convgs_PaperReport.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convgs_PaperReport.IdCurrEduCls);
}
else if (convgs_PaperReport.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PaperReport.IsSubmit);
}
else if (convgs_PaperReport.ReportUser  ==  AttributeName[intIndex])
{
mstrReportUser = value.ToString();
 AddUpdatedFld(convgs_PaperReport.ReportUser);
}
else if (convgs_PaperReport.ReportDate  ==  AttributeName[intIndex])
{
mstrReportDate = value.ToString();
 AddUpdatedFld(convgs_PaperReport.ReportDate);
}
else if (convgs_PaperReport.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PaperReport.UpdUser);
}
else if (convgs_PaperReport.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperReport.VersionCount);
}
else if (convgs_PaperReport.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperReport.OkCount);
}
else if (convgs_PaperReport.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperReport.AppraiseCount);
}
else if (convgs_PaperReport.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PaperReport.Score);
}
else if (convgs_PaperReport.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PaperReport.StuScore);
}
else if (convgs_PaperReport.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PaperReport.TeaScore);
}
else if (convgs_PaperReport.PDFUrl  ==  AttributeName[intIndex])
{
mstrPDFUrl = value.ToString();
 AddUpdatedFld(convgs_PaperReport.PDFUrl);
}
else if (convgs_PaperReport.PPTUrl  ==  AttributeName[intIndex])
{
mstrPPTUrl = value.ToString();
 AddUpdatedFld(convgs_PaperReport.PPTUrl);
}
else if (convgs_PaperReport.Month  ==  AttributeName[intIndex])
{
mstrMonth = value.ToString();
 AddUpdatedFld(convgs_PaperReport.Month);
}
else if (convgs_PaperReport.Week  ==  AttributeName[intIndex])
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperReport.Week);
}
else if (convgs_PaperReport.Year  ==  AttributeName[intIndex])
{
mstrYear = value.ToString();
 AddUpdatedFld(convgs_PaperReport.Year);
}
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
 AddUpdatedFld(convgs_PaperReport.Memo);
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
 AddUpdatedFld(convgs_PaperReport.ReportId);
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
 AddUpdatedFld(convgs_PaperReport.UpdDate);
}
}
/// <summary>
/// 栏目主题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicName
{
get
{
return mstrTopicName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicName = value;
}
else
{
 mstrTopicName = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PaperReport.TopicName);
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
 AddUpdatedFld(convgs_PaperReport.TopicId);
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
 AddUpdatedFld(convgs_PaperReport.PaperId);
}
}
/// <summary>
/// 论文标题(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTitle
{
get
{
return mstrPaperTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTitle = value;
}
else
{
 mstrPaperTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PaperReport.PaperTitle);
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
 AddUpdatedFld(convgs_PaperReport.ReportContent);
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
 AddUpdatedFld(convgs_PaperReport.IdCurrEduCls);
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
 AddUpdatedFld(convgs_PaperReport.IsSubmit);
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
 AddUpdatedFld(convgs_PaperReport.ReportUser);
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
 AddUpdatedFld(convgs_PaperReport.ReportDate);
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
 AddUpdatedFld(convgs_PaperReport.UpdUser);
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
 AddUpdatedFld(convgs_PaperReport.VersionCount);
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
 AddUpdatedFld(convgs_PaperReport.OkCount);
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
 AddUpdatedFld(convgs_PaperReport.AppraiseCount);
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
 AddUpdatedFld(convgs_PaperReport.Score);
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
 AddUpdatedFld(convgs_PaperReport.StuScore);
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
 AddUpdatedFld(convgs_PaperReport.TeaScore);
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
 AddUpdatedFld(convgs_PaperReport.PDFUrl);
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
 AddUpdatedFld(convgs_PaperReport.PPTUrl);
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
 AddUpdatedFld(convgs_PaperReport.Month);
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
 AddUpdatedFld(convgs_PaperReport.Week);
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
 AddUpdatedFld(convgs_PaperReport.Year);
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
 /// 论文汇报视图(vgs_PaperReport)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convgs_PaperReport
{
public const string _CurrTabName = "vgs_PaperReport"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ReportId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"Memo", "ReportId", "UpdDate", "TopicName", "TopicId", "PaperId", "PaperTitle", "ReportContent", "IdCurrEduCls", "IsSubmit", "ReportUser", "ReportDate", "UpdUser", "VersionCount", "OkCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "PDFUrl", "PPTUrl", "Month", "Week", "Year"};
//以下是属性变量


 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"ReportId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReportId = "ReportId";    //汇报Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"TopicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicName = "TopicName";    //栏目主题

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
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"ReportContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReportContent = "ReportContent";    //汇报内容

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

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
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

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
}

}