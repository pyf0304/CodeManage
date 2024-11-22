
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_PaperReportEN
 表名:vzx_PaperReport(01120832)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:13:52
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
 /// 表vzx_PaperReport的关键字(zxReportId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxReportId_vzx_PaperReport
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxReportId">表关键字</param>
public K_zxReportId_vzx_PaperReport(string strzxReportId)
{
if (IsValid(strzxReportId)) Value = strzxReportId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxReportId)
{
if (string.IsNullOrEmpty(strzxReportId) == true) return false;
if (strzxReportId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxReportId_vzx_PaperReport]类型的对象</returns>
public static implicit operator K_zxReportId_vzx_PaperReport(string value)
{
return new K_zxReportId_vzx_PaperReport(value);
}
}
 /// <summary>
 /// vzx_PaperReport(vzx_PaperReport)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_PaperReportEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_PaperReport"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxReportId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 24;
public static string[] AttributeName = new string[] {"TextTitle", "GroupTextName", "IdCurrEduCls", "zxReportId", "GroupTextId", "UpdDate", "PDFUrl", "TeaScore", "StuScore", "Score", "OkCount", "VersionCount", "UpdUser", "ReportContent", "TextId", "IsSubmit", "ReportUser", "ReportDate", "PPTUrl", "Memo", "Month", "Week", "Year", "AppraiseCount"};

protected string mstrTextTitle;    //TextTitle
protected string mstrGroupTextName;    //小组名称
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrzxReportId;    //汇报Id
protected string mstrGroupTextId;    //小组Id
protected string mstrUpdDate;    //修改日期
protected string mstrPDFUrl;    //PDFUrl
protected float? mfltTeaScore;    //教师评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltScore;    //评分
protected int? mintOkCount;    //点赞统计
protected int? mintVersionCount;    //版本统计
protected string mstrUpdUser;    //修改人
protected string mstrReportContent;    //汇报内容
protected string mstrTextId;    //课件Id
protected bool mbolIsSubmit;    //是否提交
protected string mstrReportUser;    //汇报用户
protected string mstrReportDate;    //汇报日期
protected string mstrPPTUrl;    //PPTUrl
protected string mstrMemo;    //备注
protected string mstrMonth;    //月
protected int? mintWeek;    //周
protected string mstrYear;    //年
protected int? mintAppraiseCount;    //评论数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_PaperReportEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxReportId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxReportId">关键字:汇报Id</param>
public clsvzx_PaperReportEN(string strzxReportId)
 {
strzxReportId = strzxReportId.Replace("'", "''");
if (strzxReportId.Length > 10)
{
throw new Exception("在表:vzx_PaperReport中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxReportId)  ==  true)
{
throw new Exception("在表:vzx_PaperReport中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxReportId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxReportId = strzxReportId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxReportId");
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
if (strAttributeName  ==  convzx_PaperReport.TextTitle)
{
return mstrTextTitle;
}
else if (strAttributeName  ==  convzx_PaperReport.GroupTextName)
{
return mstrGroupTextName;
}
else if (strAttributeName  ==  convzx_PaperReport.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convzx_PaperReport.zxReportId)
{
return mstrzxReportId;
}
else if (strAttributeName  ==  convzx_PaperReport.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  convzx_PaperReport.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_PaperReport.PDFUrl)
{
return mstrPDFUrl;
}
else if (strAttributeName  ==  convzx_PaperReport.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convzx_PaperReport.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convzx_PaperReport.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convzx_PaperReport.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convzx_PaperReport.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convzx_PaperReport.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_PaperReport.ReportContent)
{
return mstrReportContent;
}
else if (strAttributeName  ==  convzx_PaperReport.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  convzx_PaperReport.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convzx_PaperReport.ReportUser)
{
return mstrReportUser;
}
else if (strAttributeName  ==  convzx_PaperReport.ReportDate)
{
return mstrReportDate;
}
else if (strAttributeName  ==  convzx_PaperReport.PPTUrl)
{
return mstrPPTUrl;
}
else if (strAttributeName  ==  convzx_PaperReport.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_PaperReport.Month)
{
return mstrMonth;
}
else if (strAttributeName  ==  convzx_PaperReport.Week)
{
return mintWeek;
}
else if (strAttributeName  ==  convzx_PaperReport.Year)
{
return mstrYear;
}
else if (strAttributeName  ==  convzx_PaperReport.AppraiseCount)
{
return mintAppraiseCount;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_PaperReport.TextTitle)
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_PaperReport.TextTitle);
}
else if (strAttributeName  ==  convzx_PaperReport.GroupTextName)
{
mstrGroupTextName = value.ToString();
 AddUpdatedFld(convzx_PaperReport.GroupTextName);
}
else if (strAttributeName  ==  convzx_PaperReport.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_PaperReport.IdCurrEduCls);
}
else if (strAttributeName  ==  convzx_PaperReport.zxReportId)
{
mstrzxReportId = value.ToString();
 AddUpdatedFld(convzx_PaperReport.zxReportId);
}
else if (strAttributeName  ==  convzx_PaperReport.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_PaperReport.GroupTextId);
}
else if (strAttributeName  ==  convzx_PaperReport.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_PaperReport.UpdDate);
}
else if (strAttributeName  ==  convzx_PaperReport.PDFUrl)
{
mstrPDFUrl = value.ToString();
 AddUpdatedFld(convzx_PaperReport.PDFUrl);
}
else if (strAttributeName  ==  convzx_PaperReport.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_PaperReport.TeaScore);
}
else if (strAttributeName  ==  convzx_PaperReport.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_PaperReport.StuScore);
}
else if (strAttributeName  ==  convzx_PaperReport.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_PaperReport.Score);
}
else if (strAttributeName  ==  convzx_PaperReport.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperReport.OkCount);
}
else if (strAttributeName  ==  convzx_PaperReport.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperReport.VersionCount);
}
else if (strAttributeName  ==  convzx_PaperReport.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_PaperReport.UpdUser);
}
else if (strAttributeName  ==  convzx_PaperReport.ReportContent)
{
mstrReportContent = value.ToString();
 AddUpdatedFld(convzx_PaperReport.ReportContent);
}
else if (strAttributeName  ==  convzx_PaperReport.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_PaperReport.TextId);
}
else if (strAttributeName  ==  convzx_PaperReport.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_PaperReport.IsSubmit);
}
else if (strAttributeName  ==  convzx_PaperReport.ReportUser)
{
mstrReportUser = value.ToString();
 AddUpdatedFld(convzx_PaperReport.ReportUser);
}
else if (strAttributeName  ==  convzx_PaperReport.ReportDate)
{
mstrReportDate = value.ToString();
 AddUpdatedFld(convzx_PaperReport.ReportDate);
}
else if (strAttributeName  ==  convzx_PaperReport.PPTUrl)
{
mstrPPTUrl = value.ToString();
 AddUpdatedFld(convzx_PaperReport.PPTUrl);
}
else if (strAttributeName  ==  convzx_PaperReport.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_PaperReport.Memo);
}
else if (strAttributeName  ==  convzx_PaperReport.Month)
{
mstrMonth = value.ToString();
 AddUpdatedFld(convzx_PaperReport.Month);
}
else if (strAttributeName  ==  convzx_PaperReport.Week)
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperReport.Week);
}
else if (strAttributeName  ==  convzx_PaperReport.Year)
{
mstrYear = value.ToString();
 AddUpdatedFld(convzx_PaperReport.Year);
}
else if (strAttributeName  ==  convzx_PaperReport.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperReport.AppraiseCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_PaperReport.TextTitle  ==  AttributeName[intIndex])
{
return mstrTextTitle;
}
else if (convzx_PaperReport.GroupTextName  ==  AttributeName[intIndex])
{
return mstrGroupTextName;
}
else if (convzx_PaperReport.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convzx_PaperReport.zxReportId  ==  AttributeName[intIndex])
{
return mstrzxReportId;
}
else if (convzx_PaperReport.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (convzx_PaperReport.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_PaperReport.PDFUrl  ==  AttributeName[intIndex])
{
return mstrPDFUrl;
}
else if (convzx_PaperReport.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convzx_PaperReport.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convzx_PaperReport.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convzx_PaperReport.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convzx_PaperReport.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convzx_PaperReport.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_PaperReport.ReportContent  ==  AttributeName[intIndex])
{
return mstrReportContent;
}
else if (convzx_PaperReport.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (convzx_PaperReport.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convzx_PaperReport.ReportUser  ==  AttributeName[intIndex])
{
return mstrReportUser;
}
else if (convzx_PaperReport.ReportDate  ==  AttributeName[intIndex])
{
return mstrReportDate;
}
else if (convzx_PaperReport.PPTUrl  ==  AttributeName[intIndex])
{
return mstrPPTUrl;
}
else if (convzx_PaperReport.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_PaperReport.Month  ==  AttributeName[intIndex])
{
return mstrMonth;
}
else if (convzx_PaperReport.Week  ==  AttributeName[intIndex])
{
return mintWeek;
}
else if (convzx_PaperReport.Year  ==  AttributeName[intIndex])
{
return mstrYear;
}
else if (convzx_PaperReport.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
return null;
}
set
{
if (convzx_PaperReport.TextTitle  ==  AttributeName[intIndex])
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_PaperReport.TextTitle);
}
else if (convzx_PaperReport.GroupTextName  ==  AttributeName[intIndex])
{
mstrGroupTextName = value.ToString();
 AddUpdatedFld(convzx_PaperReport.GroupTextName);
}
else if (convzx_PaperReport.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_PaperReport.IdCurrEduCls);
}
else if (convzx_PaperReport.zxReportId  ==  AttributeName[intIndex])
{
mstrzxReportId = value.ToString();
 AddUpdatedFld(convzx_PaperReport.zxReportId);
}
else if (convzx_PaperReport.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_PaperReport.GroupTextId);
}
else if (convzx_PaperReport.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_PaperReport.UpdDate);
}
else if (convzx_PaperReport.PDFUrl  ==  AttributeName[intIndex])
{
mstrPDFUrl = value.ToString();
 AddUpdatedFld(convzx_PaperReport.PDFUrl);
}
else if (convzx_PaperReport.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_PaperReport.TeaScore);
}
else if (convzx_PaperReport.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_PaperReport.StuScore);
}
else if (convzx_PaperReport.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_PaperReport.Score);
}
else if (convzx_PaperReport.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperReport.OkCount);
}
else if (convzx_PaperReport.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperReport.VersionCount);
}
else if (convzx_PaperReport.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_PaperReport.UpdUser);
}
else if (convzx_PaperReport.ReportContent  ==  AttributeName[intIndex])
{
mstrReportContent = value.ToString();
 AddUpdatedFld(convzx_PaperReport.ReportContent);
}
else if (convzx_PaperReport.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_PaperReport.TextId);
}
else if (convzx_PaperReport.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_PaperReport.IsSubmit);
}
else if (convzx_PaperReport.ReportUser  ==  AttributeName[intIndex])
{
mstrReportUser = value.ToString();
 AddUpdatedFld(convzx_PaperReport.ReportUser);
}
else if (convzx_PaperReport.ReportDate  ==  AttributeName[intIndex])
{
mstrReportDate = value.ToString();
 AddUpdatedFld(convzx_PaperReport.ReportDate);
}
else if (convzx_PaperReport.PPTUrl  ==  AttributeName[intIndex])
{
mstrPPTUrl = value.ToString();
 AddUpdatedFld(convzx_PaperReport.PPTUrl);
}
else if (convzx_PaperReport.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_PaperReport.Memo);
}
else if (convzx_PaperReport.Month  ==  AttributeName[intIndex])
{
mstrMonth = value.ToString();
 AddUpdatedFld(convzx_PaperReport.Month);
}
else if (convzx_PaperReport.Week  ==  AttributeName[intIndex])
{
mintWeek = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperReport.Week);
}
else if (convzx_PaperReport.Year  ==  AttributeName[intIndex])
{
mstrYear = value.ToString();
 AddUpdatedFld(convzx_PaperReport.Year);
}
else if (convzx_PaperReport.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperReport.AppraiseCount);
}
}
}

/// <summary>
/// TextTitle(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextTitle
{
get
{
return mstrTextTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextTitle = value;
}
else
{
 mstrTextTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_PaperReport.TextTitle);
}
}
/// <summary>
/// 小组名称(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextName
{
get
{
return mstrGroupTextName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextName = value;
}
else
{
 mstrGroupTextName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_PaperReport.GroupTextName);
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
 AddUpdatedFld(convzx_PaperReport.IdCurrEduCls);
}
}
/// <summary>
/// 汇报Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxReportId
{
get
{
return mstrzxReportId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxReportId = value;
}
else
{
 mstrzxReportId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_PaperReport.zxReportId);
}
}
/// <summary>
/// 小组Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextId
{
get
{
return mstrGroupTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextId = value;
}
else
{
 mstrGroupTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_PaperReport.GroupTextId);
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
 AddUpdatedFld(convzx_PaperReport.UpdDate);
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
 AddUpdatedFld(convzx_PaperReport.PDFUrl);
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
 AddUpdatedFld(convzx_PaperReport.TeaScore);
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
 AddUpdatedFld(convzx_PaperReport.StuScore);
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
 AddUpdatedFld(convzx_PaperReport.Score);
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
 AddUpdatedFld(convzx_PaperReport.OkCount);
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
 AddUpdatedFld(convzx_PaperReport.VersionCount);
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
 AddUpdatedFld(convzx_PaperReport.UpdUser);
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
 AddUpdatedFld(convzx_PaperReport.ReportContent);
}
}
/// <summary>
/// 课件Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextId
{
get
{
return mstrTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextId = value;
}
else
{
 mstrTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_PaperReport.TextId);
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
 AddUpdatedFld(convzx_PaperReport.IsSubmit);
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
 AddUpdatedFld(convzx_PaperReport.ReportUser);
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
 AddUpdatedFld(convzx_PaperReport.ReportDate);
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
 AddUpdatedFld(convzx_PaperReport.PPTUrl);
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
 AddUpdatedFld(convzx_PaperReport.Memo);
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
 AddUpdatedFld(convzx_PaperReport.Month);
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
 AddUpdatedFld(convzx_PaperReport.Week);
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
 AddUpdatedFld(convzx_PaperReport.Year);
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
 AddUpdatedFld(convzx_PaperReport.AppraiseCount);
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
  return mstrzxReportId;
 }
 }
}
 /// <summary>
 /// vzx_PaperReport(vzx_PaperReport)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_PaperReport
{
public const string _CurrTabName = "vzx_PaperReport"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxReportId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TextTitle", "GroupTextName", "IdCurrEduCls", "zxReportId", "GroupTextId", "UpdDate", "PDFUrl", "TeaScore", "StuScore", "Score", "OkCount", "VersionCount", "UpdUser", "ReportContent", "TextId", "IsSubmit", "ReportUser", "ReportDate", "PPTUrl", "Memo", "Month", "Week", "Year", "AppraiseCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"TextTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextTitle = "TextTitle";    //TextTitle

 /// <summary>
 /// 常量:"GroupTextName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextName = "GroupTextName";    //小组名称

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"zxReportId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxReportId = "zxReportId";    //汇报Id

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"PDFUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PDFUrl = "PDFUrl";    //PDFUrl

 /// <summary>
 /// 常量:"TeaScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaScore = "TeaScore";    //教师评分

 /// <summary>
 /// 常量:"StuScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuScore = "StuScore";    //学生平均分

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"ReportContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReportContent = "ReportContent";    //汇报内容

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

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
 /// 常量:"PPTUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PPTUrl = "PPTUrl";    //PPTUrl

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数
}

}