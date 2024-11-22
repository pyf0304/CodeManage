
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperEN
 表名:Paper(01120535)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表Paper的关键字(PaperId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperId_Paper
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPaperId">表关键字</param>
public K_PaperId_Paper(string strPaperId)
{
if (IsValid(strPaperId)) Value = strPaperId;
else
{
Value = null;
}
}
private static bool IsValid(string strPaperId)
{
if (string.IsNullOrEmpty(strPaperId) == true) return false;
if (strPaperId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperId_Paper]类型的对象</returns>
public static implicit operator K_PaperId_Paper(string value)
{
return new K_PaperId_Paper(value);
}
}
 /// <summary>
 /// 论文表(Paper)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPaperEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Paper"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = "PaperId in (Select PaperId from PaperEduClsRela where IdCurrEduCls='{0}'))"; //前台条件格式串
protected const int mintAttributeCount = 47;
public static string[] AttributeName = new string[] {"PaperId", "PaperTitle", "PaperContent", "Periodical", "Author", "ResearchQuestion", "Keyword", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "IsQuotethesis", "QuoteId", "IsChecked", "Checker", "LiteratureTypeId", "BrowseNumber", "IsSubmit", "AppraiseCount", "AttachmentCount", "CollectionCount", "DownloadCount", "OkCount", "Pcount", "Score", "StuScore", "TeaScore", "PaperTypeId", "PaperStatusId", "VersionCount", "IsPublic", "AskQuestion", "ResearchStatus", "InnovationPoints", "ResearchDesign", "DimensionDataProcess", "ExpectedConclusion", "ShareId", "PaperQCount", "SubVCount", "TagsCount", "TeaQCount", "IdStudyLevel", "IdGrade", "CreateDate", "UpdUser", "UpdDate", "Memo"};

protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected string mstrPaperContent;    //主题内容
protected string mstrPeriodical;    //期刊
protected string mstrAuthor;    //作者
protected string mstrResearchQuestion;    //研究问题
protected string mstrKeyword;    //关键字
protected string mstrLiteratureSources;    //文献来源
protected string mstrLiteratureLink;    //文献链接
protected string mstrUploadfileUrl;    //文件地址
protected bool mbolIsQuotethesis;    //是否引用论文
protected string mstrQuoteId;    //引用Id
protected bool mbolIsChecked;    //是否检查
protected string mstrChecker;    //审核人
protected string mstrLiteratureTypeId;    //文献类型Id
protected int? mintBrowseNumber;    //浏览量
protected bool mbolIsSubmit;    //是否提交
protected int? mintAppraiseCount;    //评论数
protected int? mintAttachmentCount;    //附件计数
protected long? mlngCollectionCount;    //收藏数量
protected int? mintDownloadCount;    //下载数
protected int? mintOkCount;    //点赞统计
protected int? mintPcount;    //读写数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrPaperTypeId;    //论文类型Id
protected string mstrPaperStatusId;    //论文状态Id
protected int? mintVersionCount;    //版本统计
protected bool mbolIsPublic;    //是否公开
protected string mstrAskQuestion;    //问题提出
protected string mstrResearchStatus;    //目前研究的现状
protected string mstrInnovationPoints;    //创新点
protected string mstrResearchDesign;    //研究设计
protected string mstrDimensionDataProcess;    //数据处理的维度
protected string mstrExpectedConclusion;    //预期结论
protected string mstrShareId;    //分享Id
protected int? mintPaperQCount;    //论文答疑数
protected int? mintSubVCount;    //论文子观点数
protected int? mintTagsCount;    //论文标注数
protected int? mintTeaQCount;    //教师提问数
protected string mstrIdStudyLevel;    //学段流水号
protected string mstrIdGrade;    //年级流水号
protected string mstrCreateDate;    //建立日期
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPaperEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPaperId">关键字:论文Id</param>
public clsPaperEN(string strPaperId)
 {
strPaperId = strPaperId.Replace("'", "''");
if (strPaperId.Length > 8)
{
throw new Exception("在表:Paper中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPaperId)  ==  true)
{
throw new Exception("在表:Paper中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPaperId = strPaperId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperId");
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
if (strAttributeName  ==  conPaper.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  conPaper.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  conPaper.PaperContent)
{
return mstrPaperContent;
}
else if (strAttributeName  ==  conPaper.Periodical)
{
return mstrPeriodical;
}
else if (strAttributeName  ==  conPaper.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  conPaper.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  conPaper.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  conPaper.LiteratureSources)
{
return mstrLiteratureSources;
}
else if (strAttributeName  ==  conPaper.LiteratureLink)
{
return mstrLiteratureLink;
}
else if (strAttributeName  ==  conPaper.UploadfileUrl)
{
return mstrUploadfileUrl;
}
else if (strAttributeName  ==  conPaper.IsQuotethesis)
{
return mbolIsQuotethesis;
}
else if (strAttributeName  ==  conPaper.QuoteId)
{
return mstrQuoteId;
}
else if (strAttributeName  ==  conPaper.IsChecked)
{
return mbolIsChecked;
}
else if (strAttributeName  ==  conPaper.Checker)
{
return mstrChecker;
}
else if (strAttributeName  ==  conPaper.LiteratureTypeId)
{
return mstrLiteratureTypeId;
}
else if (strAttributeName  ==  conPaper.BrowseNumber)
{
return mintBrowseNumber;
}
else if (strAttributeName  ==  conPaper.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conPaper.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  conPaper.AttachmentCount)
{
return mintAttachmentCount;
}
else if (strAttributeName  ==  conPaper.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  conPaper.DownloadCount)
{
return mintDownloadCount;
}
else if (strAttributeName  ==  conPaper.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  conPaper.Pcount)
{
return mintPcount;
}
else if (strAttributeName  ==  conPaper.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conPaper.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  conPaper.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  conPaper.PaperTypeId)
{
return mstrPaperTypeId;
}
else if (strAttributeName  ==  conPaper.PaperStatusId)
{
return mstrPaperStatusId;
}
else if (strAttributeName  ==  conPaper.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  conPaper.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  conPaper.AskQuestion)
{
return mstrAskQuestion;
}
else if (strAttributeName  ==  conPaper.ResearchStatus)
{
return mstrResearchStatus;
}
else if (strAttributeName  ==  conPaper.InnovationPoints)
{
return mstrInnovationPoints;
}
else if (strAttributeName  ==  conPaper.ResearchDesign)
{
return mstrResearchDesign;
}
else if (strAttributeName  ==  conPaper.DimensionDataProcess)
{
return mstrDimensionDataProcess;
}
else if (strAttributeName  ==  conPaper.ExpectedConclusion)
{
return mstrExpectedConclusion;
}
else if (strAttributeName  ==  conPaper.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  conPaper.PaperQCount)
{
return mintPaperQCount;
}
else if (strAttributeName  ==  conPaper.SubVCount)
{
return mintSubVCount;
}
else if (strAttributeName  ==  conPaper.TagsCount)
{
return mintTagsCount;
}
else if (strAttributeName  ==  conPaper.TeaQCount)
{
return mintTeaQCount;
}
else if (strAttributeName  ==  conPaper.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conPaper.IdGrade)
{
return mstrIdGrade;
}
else if (strAttributeName  ==  conPaper.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conPaper.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conPaper.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPaper.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPaper.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conPaper.PaperId);
}
else if (strAttributeName  ==  conPaper.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(conPaper.PaperTitle);
}
else if (strAttributeName  ==  conPaper.PaperContent)
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(conPaper.PaperContent);
}
else if (strAttributeName  ==  conPaper.Periodical)
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(conPaper.Periodical);
}
else if (strAttributeName  ==  conPaper.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(conPaper.Author);
}
else if (strAttributeName  ==  conPaper.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(conPaper.ResearchQuestion);
}
else if (strAttributeName  ==  conPaper.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(conPaper.Keyword);
}
else if (strAttributeName  ==  conPaper.LiteratureSources)
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(conPaper.LiteratureSources);
}
else if (strAttributeName  ==  conPaper.LiteratureLink)
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(conPaper.LiteratureLink);
}
else if (strAttributeName  ==  conPaper.UploadfileUrl)
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(conPaper.UploadfileUrl);
}
else if (strAttributeName  ==  conPaper.IsQuotethesis)
{
mbolIsQuotethesis = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaper.IsQuotethesis);
}
else if (strAttributeName  ==  conPaper.QuoteId)
{
mstrQuoteId = value.ToString();
 AddUpdatedFld(conPaper.QuoteId);
}
else if (strAttributeName  ==  conPaper.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaper.IsChecked);
}
else if (strAttributeName  ==  conPaper.Checker)
{
mstrChecker = value.ToString();
 AddUpdatedFld(conPaper.Checker);
}
else if (strAttributeName  ==  conPaper.LiteratureTypeId)
{
mstrLiteratureTypeId = value.ToString();
 AddUpdatedFld(conPaper.LiteratureTypeId);
}
else if (strAttributeName  ==  conPaper.BrowseNumber)
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.BrowseNumber);
}
else if (strAttributeName  ==  conPaper.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaper.IsSubmit);
}
else if (strAttributeName  ==  conPaper.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.AppraiseCount);
}
else if (strAttributeName  ==  conPaper.AttachmentCount)
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.AttachmentCount);
}
else if (strAttributeName  ==  conPaper.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.CollectionCount);
}
else if (strAttributeName  ==  conPaper.DownloadCount)
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.DownloadCount);
}
else if (strAttributeName  ==  conPaper.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.OkCount);
}
else if (strAttributeName  ==  conPaper.Pcount)
{
mintPcount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.Pcount);
}
else if (strAttributeName  ==  conPaper.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPaper.Score);
}
else if (strAttributeName  ==  conPaper.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPaper.StuScore);
}
else if (strAttributeName  ==  conPaper.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPaper.TeaScore);
}
else if (strAttributeName  ==  conPaper.PaperTypeId)
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(conPaper.PaperTypeId);
}
else if (strAttributeName  ==  conPaper.PaperStatusId)
{
mstrPaperStatusId = value.ToString();
 AddUpdatedFld(conPaper.PaperStatusId);
}
else if (strAttributeName  ==  conPaper.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.VersionCount);
}
else if (strAttributeName  ==  conPaper.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaper.IsPublic);
}
else if (strAttributeName  ==  conPaper.AskQuestion)
{
mstrAskQuestion = value.ToString();
 AddUpdatedFld(conPaper.AskQuestion);
}
else if (strAttributeName  ==  conPaper.ResearchStatus)
{
mstrResearchStatus = value.ToString();
 AddUpdatedFld(conPaper.ResearchStatus);
}
else if (strAttributeName  ==  conPaper.InnovationPoints)
{
mstrInnovationPoints = value.ToString();
 AddUpdatedFld(conPaper.InnovationPoints);
}
else if (strAttributeName  ==  conPaper.ResearchDesign)
{
mstrResearchDesign = value.ToString();
 AddUpdatedFld(conPaper.ResearchDesign);
}
else if (strAttributeName  ==  conPaper.DimensionDataProcess)
{
mstrDimensionDataProcess = value.ToString();
 AddUpdatedFld(conPaper.DimensionDataProcess);
}
else if (strAttributeName  ==  conPaper.ExpectedConclusion)
{
mstrExpectedConclusion = value.ToString();
 AddUpdatedFld(conPaper.ExpectedConclusion);
}
else if (strAttributeName  ==  conPaper.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(conPaper.ShareId);
}
else if (strAttributeName  ==  conPaper.PaperQCount)
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.PaperQCount);
}
else if (strAttributeName  ==  conPaper.SubVCount)
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.SubVCount);
}
else if (strAttributeName  ==  conPaper.TagsCount)
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.TagsCount);
}
else if (strAttributeName  ==  conPaper.TeaQCount)
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.TeaQCount);
}
else if (strAttributeName  ==  conPaper.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conPaper.IdStudyLevel);
}
else if (strAttributeName  ==  conPaper.IdGrade)
{
mstrIdGrade = value.ToString();
 AddUpdatedFld(conPaper.IdGrade);
}
else if (strAttributeName  ==  conPaper.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conPaper.CreateDate);
}
else if (strAttributeName  ==  conPaper.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaper.UpdUser);
}
else if (strAttributeName  ==  conPaper.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaper.UpdDate);
}
else if (strAttributeName  ==  conPaper.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaper.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPaper.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (conPaper.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (conPaper.PaperContent  ==  AttributeName[intIndex])
{
return mstrPaperContent;
}
else if (conPaper.Periodical  ==  AttributeName[intIndex])
{
return mstrPeriodical;
}
else if (conPaper.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (conPaper.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (conPaper.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (conPaper.LiteratureSources  ==  AttributeName[intIndex])
{
return mstrLiteratureSources;
}
else if (conPaper.LiteratureLink  ==  AttributeName[intIndex])
{
return mstrLiteratureLink;
}
else if (conPaper.UploadfileUrl  ==  AttributeName[intIndex])
{
return mstrUploadfileUrl;
}
else if (conPaper.IsQuotethesis  ==  AttributeName[intIndex])
{
return mbolIsQuotethesis;
}
else if (conPaper.QuoteId  ==  AttributeName[intIndex])
{
return mstrQuoteId;
}
else if (conPaper.IsChecked  ==  AttributeName[intIndex])
{
return mbolIsChecked;
}
else if (conPaper.Checker  ==  AttributeName[intIndex])
{
return mstrChecker;
}
else if (conPaper.LiteratureTypeId  ==  AttributeName[intIndex])
{
return mstrLiteratureTypeId;
}
else if (conPaper.BrowseNumber  ==  AttributeName[intIndex])
{
return mintBrowseNumber;
}
else if (conPaper.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conPaper.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (conPaper.AttachmentCount  ==  AttributeName[intIndex])
{
return mintAttachmentCount;
}
else if (conPaper.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (conPaper.DownloadCount  ==  AttributeName[intIndex])
{
return mintDownloadCount;
}
else if (conPaper.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (conPaper.Pcount  ==  AttributeName[intIndex])
{
return mintPcount;
}
else if (conPaper.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conPaper.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (conPaper.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (conPaper.PaperTypeId  ==  AttributeName[intIndex])
{
return mstrPaperTypeId;
}
else if (conPaper.PaperStatusId  ==  AttributeName[intIndex])
{
return mstrPaperStatusId;
}
else if (conPaper.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (conPaper.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (conPaper.AskQuestion  ==  AttributeName[intIndex])
{
return mstrAskQuestion;
}
else if (conPaper.ResearchStatus  ==  AttributeName[intIndex])
{
return mstrResearchStatus;
}
else if (conPaper.InnovationPoints  ==  AttributeName[intIndex])
{
return mstrInnovationPoints;
}
else if (conPaper.ResearchDesign  ==  AttributeName[intIndex])
{
return mstrResearchDesign;
}
else if (conPaper.DimensionDataProcess  ==  AttributeName[intIndex])
{
return mstrDimensionDataProcess;
}
else if (conPaper.ExpectedConclusion  ==  AttributeName[intIndex])
{
return mstrExpectedConclusion;
}
else if (conPaper.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (conPaper.PaperQCount  ==  AttributeName[intIndex])
{
return mintPaperQCount;
}
else if (conPaper.SubVCount  ==  AttributeName[intIndex])
{
return mintSubVCount;
}
else if (conPaper.TagsCount  ==  AttributeName[intIndex])
{
return mintTagsCount;
}
else if (conPaper.TeaQCount  ==  AttributeName[intIndex])
{
return mintTeaQCount;
}
else if (conPaper.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conPaper.IdGrade  ==  AttributeName[intIndex])
{
return mstrIdGrade;
}
else if (conPaper.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conPaper.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conPaper.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPaper.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPaper.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conPaper.PaperId);
}
else if (conPaper.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(conPaper.PaperTitle);
}
else if (conPaper.PaperContent  ==  AttributeName[intIndex])
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(conPaper.PaperContent);
}
else if (conPaper.Periodical  ==  AttributeName[intIndex])
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(conPaper.Periodical);
}
else if (conPaper.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(conPaper.Author);
}
else if (conPaper.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(conPaper.ResearchQuestion);
}
else if (conPaper.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(conPaper.Keyword);
}
else if (conPaper.LiteratureSources  ==  AttributeName[intIndex])
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(conPaper.LiteratureSources);
}
else if (conPaper.LiteratureLink  ==  AttributeName[intIndex])
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(conPaper.LiteratureLink);
}
else if (conPaper.UploadfileUrl  ==  AttributeName[intIndex])
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(conPaper.UploadfileUrl);
}
else if (conPaper.IsQuotethesis  ==  AttributeName[intIndex])
{
mbolIsQuotethesis = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaper.IsQuotethesis);
}
else if (conPaper.QuoteId  ==  AttributeName[intIndex])
{
mstrQuoteId = value.ToString();
 AddUpdatedFld(conPaper.QuoteId);
}
else if (conPaper.IsChecked  ==  AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaper.IsChecked);
}
else if (conPaper.Checker  ==  AttributeName[intIndex])
{
mstrChecker = value.ToString();
 AddUpdatedFld(conPaper.Checker);
}
else if (conPaper.LiteratureTypeId  ==  AttributeName[intIndex])
{
mstrLiteratureTypeId = value.ToString();
 AddUpdatedFld(conPaper.LiteratureTypeId);
}
else if (conPaper.BrowseNumber  ==  AttributeName[intIndex])
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.BrowseNumber);
}
else if (conPaper.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaper.IsSubmit);
}
else if (conPaper.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.AppraiseCount);
}
else if (conPaper.AttachmentCount  ==  AttributeName[intIndex])
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.AttachmentCount);
}
else if (conPaper.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.CollectionCount);
}
else if (conPaper.DownloadCount  ==  AttributeName[intIndex])
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.DownloadCount);
}
else if (conPaper.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.OkCount);
}
else if (conPaper.Pcount  ==  AttributeName[intIndex])
{
mintPcount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.Pcount);
}
else if (conPaper.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPaper.Score);
}
else if (conPaper.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPaper.StuScore);
}
else if (conPaper.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPaper.TeaScore);
}
else if (conPaper.PaperTypeId  ==  AttributeName[intIndex])
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(conPaper.PaperTypeId);
}
else if (conPaper.PaperStatusId  ==  AttributeName[intIndex])
{
mstrPaperStatusId = value.ToString();
 AddUpdatedFld(conPaper.PaperStatusId);
}
else if (conPaper.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.VersionCount);
}
else if (conPaper.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaper.IsPublic);
}
else if (conPaper.AskQuestion  ==  AttributeName[intIndex])
{
mstrAskQuestion = value.ToString();
 AddUpdatedFld(conPaper.AskQuestion);
}
else if (conPaper.ResearchStatus  ==  AttributeName[intIndex])
{
mstrResearchStatus = value.ToString();
 AddUpdatedFld(conPaper.ResearchStatus);
}
else if (conPaper.InnovationPoints  ==  AttributeName[intIndex])
{
mstrInnovationPoints = value.ToString();
 AddUpdatedFld(conPaper.InnovationPoints);
}
else if (conPaper.ResearchDesign  ==  AttributeName[intIndex])
{
mstrResearchDesign = value.ToString();
 AddUpdatedFld(conPaper.ResearchDesign);
}
else if (conPaper.DimensionDataProcess  ==  AttributeName[intIndex])
{
mstrDimensionDataProcess = value.ToString();
 AddUpdatedFld(conPaper.DimensionDataProcess);
}
else if (conPaper.ExpectedConclusion  ==  AttributeName[intIndex])
{
mstrExpectedConclusion = value.ToString();
 AddUpdatedFld(conPaper.ExpectedConclusion);
}
else if (conPaper.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(conPaper.ShareId);
}
else if (conPaper.PaperQCount  ==  AttributeName[intIndex])
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.PaperQCount);
}
else if (conPaper.SubVCount  ==  AttributeName[intIndex])
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.SubVCount);
}
else if (conPaper.TagsCount  ==  AttributeName[intIndex])
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.TagsCount);
}
else if (conPaper.TeaQCount  ==  AttributeName[intIndex])
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaper.TeaQCount);
}
else if (conPaper.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conPaper.IdStudyLevel);
}
else if (conPaper.IdGrade  ==  AttributeName[intIndex])
{
mstrIdGrade = value.ToString();
 AddUpdatedFld(conPaper.IdGrade);
}
else if (conPaper.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conPaper.CreateDate);
}
else if (conPaper.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaper.UpdUser);
}
else if (conPaper.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaper.UpdDate);
}
else if (conPaper.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaper.Memo);
}
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
 AddUpdatedFld(conPaper.PaperId);
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
 AddUpdatedFld(conPaper.PaperTitle);
}
}
/// <summary>
/// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperContent
{
get
{
return mstrPaperContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperContent = value;
}
else
{
 mstrPaperContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.PaperContent);
}
}
/// <summary>
/// 期刊(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Periodical
{
get
{
return mstrPeriodical;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPeriodical = value;
}
else
{
 mstrPeriodical = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.Periodical);
}
}
/// <summary>
/// 作者(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Author
{
get
{
return mstrAuthor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAuthor = value;
}
else
{
 mstrAuthor = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.Author);
}
}
/// <summary>
/// 研究问题(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResearchQuestion
{
get
{
return mstrResearchQuestion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResearchQuestion = value;
}
else
{
 mstrResearchQuestion = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.ResearchQuestion);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Keyword
{
get
{
return mstrKeyword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyword = value;
}
else
{
 mstrKeyword = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.Keyword);
}
}
/// <summary>
/// 文献来源(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiteratureSources
{
get
{
return mstrLiteratureSources;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiteratureSources = value;
}
else
{
 mstrLiteratureSources = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.LiteratureSources);
}
}
/// <summary>
/// 文献链接(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiteratureLink
{
get
{
return mstrLiteratureLink;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiteratureLink = value;
}
else
{
 mstrLiteratureLink = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.LiteratureLink);
}
}
/// <summary>
/// 文件地址(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UploadfileUrl
{
get
{
return mstrUploadfileUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUploadfileUrl = value;
}
else
{
 mstrUploadfileUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.UploadfileUrl);
}
}
/// <summary>
/// 是否引用论文(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsQuotethesis
{
get
{
return mbolIsQuotethesis;
}
set
{
 mbolIsQuotethesis = value;
//记录修改过的字段
 AddUpdatedFld(conPaper.IsQuotethesis);
}
}
/// <summary>
/// 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuoteId
{
get
{
return mstrQuoteId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuoteId = value;
}
else
{
 mstrQuoteId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.QuoteId);
}
}
/// <summary>
/// 是否检查(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsChecked
{
get
{
return mbolIsChecked;
}
set
{
 mbolIsChecked = value;
//记录修改过的字段
 AddUpdatedFld(conPaper.IsChecked);
}
}
/// <summary>
/// 审核人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Checker
{
get
{
return mstrChecker;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChecker = value;
}
else
{
 mstrChecker = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.Checker);
}
}
/// <summary>
/// 文献类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiteratureTypeId
{
get
{
return mstrLiteratureTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiteratureTypeId = value;
}
else
{
 mstrLiteratureTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.LiteratureTypeId);
}
}
/// <summary>
/// 浏览量(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseNumber
{
get
{
return mintBrowseNumber;
}
set
{
 mintBrowseNumber = value;
//记录修改过的字段
 AddUpdatedFld(conPaper.BrowseNumber);
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
 AddUpdatedFld(conPaper.IsSubmit);
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
 AddUpdatedFld(conPaper.AppraiseCount);
}
}
/// <summary>
/// 附件计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AttachmentCount
{
get
{
return mintAttachmentCount;
}
set
{
 mintAttachmentCount = value;
//记录修改过的字段
 AddUpdatedFld(conPaper.AttachmentCount);
}
}
/// <summary>
/// 收藏数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? CollectionCount
{
get
{
return mlngCollectionCount;
}
set
{
 mlngCollectionCount = value;
//记录修改过的字段
 AddUpdatedFld(conPaper.CollectionCount);
}
}
/// <summary>
/// 下载数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? DownloadCount
{
get
{
return mintDownloadCount;
}
set
{
 mintDownloadCount = value;
//记录修改过的字段
 AddUpdatedFld(conPaper.DownloadCount);
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
 AddUpdatedFld(conPaper.OkCount);
}
}
/// <summary>
/// 读写数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Pcount
{
get
{
return mintPcount;
}
set
{
 mintPcount = value;
//记录修改过的字段
 AddUpdatedFld(conPaper.Pcount);
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
 AddUpdatedFld(conPaper.Score);
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
 AddUpdatedFld(conPaper.StuScore);
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
 AddUpdatedFld(conPaper.TeaScore);
}
}
/// <summary>
/// 论文类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTypeId
{
get
{
return mstrPaperTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTypeId = value;
}
else
{
 mstrPaperTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.PaperTypeId);
}
}
/// <summary>
/// 论文状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperStatusId
{
get
{
return mstrPaperStatusId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperStatusId = value;
}
else
{
 mstrPaperStatusId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.PaperStatusId);
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
 AddUpdatedFld(conPaper.VersionCount);
}
}
/// <summary>
/// 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPublic
{
get
{
return mbolIsPublic;
}
set
{
 mbolIsPublic = value;
//记录修改过的字段
 AddUpdatedFld(conPaper.IsPublic);
}
}
/// <summary>
/// 问题提出(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AskQuestion
{
get
{
return mstrAskQuestion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAskQuestion = value;
}
else
{
 mstrAskQuestion = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.AskQuestion);
}
}
/// <summary>
/// 目前研究的现状(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResearchStatus
{
get
{
return mstrResearchStatus;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResearchStatus = value;
}
else
{
 mstrResearchStatus = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.ResearchStatus);
}
}
/// <summary>
/// 创新点(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InnovationPoints
{
get
{
return mstrInnovationPoints;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInnovationPoints = value;
}
else
{
 mstrInnovationPoints = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.InnovationPoints);
}
}
/// <summary>
/// 研究设计(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResearchDesign
{
get
{
return mstrResearchDesign;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResearchDesign = value;
}
else
{
 mstrResearchDesign = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.ResearchDesign);
}
}
/// <summary>
/// 数据处理的维度(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DimensionDataProcess
{
get
{
return mstrDimensionDataProcess;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDimensionDataProcess = value;
}
else
{
 mstrDimensionDataProcess = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.DimensionDataProcess);
}
}
/// <summary>
/// 预期结论(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExpectedConclusion
{
get
{
return mstrExpectedConclusion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExpectedConclusion = value;
}
else
{
 mstrExpectedConclusion = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.ExpectedConclusion);
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
 AddUpdatedFld(conPaper.ShareId);
}
}
/// <summary>
/// 论文答疑数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PaperQCount
{
get
{
return mintPaperQCount;
}
set
{
 mintPaperQCount = value;
//记录修改过的字段
 AddUpdatedFld(conPaper.PaperQCount);
}
}
/// <summary>
/// 论文子观点数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SubVCount
{
get
{
return mintSubVCount;
}
set
{
 mintSubVCount = value;
//记录修改过的字段
 AddUpdatedFld(conPaper.SubVCount);
}
}
/// <summary>
/// 论文标注数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TagsCount
{
get
{
return mintTagsCount;
}
set
{
 mintTagsCount = value;
//记录修改过的字段
 AddUpdatedFld(conPaper.TagsCount);
}
}
/// <summary>
/// 教师提问数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TeaQCount
{
get
{
return mintTeaQCount;
}
set
{
 mintTeaQCount = value;
//记录修改过的字段
 AddUpdatedFld(conPaper.TeaQCount);
}
}
/// <summary>
/// 学段流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudyLevel
{
get
{
return mstrIdStudyLevel;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudyLevel = value;
}
else
{
 mstrIdStudyLevel = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.IdStudyLevel);
}
}
/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGrade
{
get
{
return mstrIdGrade;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGrade = value;
}
else
{
 mstrIdGrade = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaper.IdGrade);
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
 AddUpdatedFld(conPaper.CreateDate);
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
 AddUpdatedFld(conPaper.UpdUser);
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
 AddUpdatedFld(conPaper.UpdDate);
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
 AddUpdatedFld(conPaper.Memo);
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
  return mstrPaperId;
 }
 }
}
 /// <summary>
 /// 论文表(Paper)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPaper
{
public const string _CurrTabName = "Paper"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperId", "PaperTitle", "PaperContent", "Periodical", "Author", "ResearchQuestion", "Keyword", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "IsQuotethesis", "QuoteId", "IsChecked", "Checker", "LiteratureTypeId", "BrowseNumber", "IsSubmit", "AppraiseCount", "AttachmentCount", "CollectionCount", "DownloadCount", "OkCount", "Pcount", "Score", "StuScore", "TeaScore", "PaperTypeId", "PaperStatusId", "VersionCount", "IsPublic", "AskQuestion", "ResearchStatus", "InnovationPoints", "ResearchDesign", "DimensionDataProcess", "ExpectedConclusion", "ShareId", "PaperQCount", "SubVCount", "TagsCount", "TeaQCount", "IdStudyLevel", "IdGrade", "CreateDate", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


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
 /// 常量:"PaperContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperContent = "PaperContent";    //主题内容

 /// <summary>
 /// 常量:"Periodical"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Periodical = "Periodical";    //期刊

 /// <summary>
 /// 常量:"Author"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Author = "Author";    //作者

 /// <summary>
 /// 常量:"ResearchQuestion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResearchQuestion = "ResearchQuestion";    //研究问题

 /// <summary>
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

 /// <summary>
 /// 常量:"LiteratureSources"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureSources = "LiteratureSources";    //文献来源

 /// <summary>
 /// 常量:"LiteratureLink"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureLink = "LiteratureLink";    //文献链接

 /// <summary>
 /// 常量:"UploadfileUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UploadfileUrl = "UploadfileUrl";    //文件地址

 /// <summary>
 /// 常量:"IsQuotethesis"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsQuotethesis = "IsQuotethesis";    //是否引用论文

 /// <summary>
 /// 常量:"QuoteId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuoteId = "QuoteId";    //引用Id

 /// <summary>
 /// 常量:"IsChecked"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsChecked = "IsChecked";    //是否检查

 /// <summary>
 /// 常量:"Checker"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Checker = "Checker";    //审核人

 /// <summary>
 /// 常量:"LiteratureTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureTypeId = "LiteratureTypeId";    //文献类型Id

 /// <summary>
 /// 常量:"BrowseNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseNumber = "BrowseNumber";    //浏览量

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
 /// 常量:"AttachmentCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttachmentCount = "AttachmentCount";    //附件计数

 /// <summary>
 /// 常量:"CollectionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollectionCount = "CollectionCount";    //收藏数量

 /// <summary>
 /// 常量:"DownloadCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DownloadCount = "DownloadCount";    //下载数

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"Pcount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Pcount = "Pcount";    //读写数

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
 /// 常量:"PaperTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTypeId = "PaperTypeId";    //论文类型Id

 /// <summary>
 /// 常量:"PaperStatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperStatusId = "PaperStatusId";    //论文状态Id

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

 /// <summary>
 /// 常量:"AskQuestion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AskQuestion = "AskQuestion";    //问题提出

 /// <summary>
 /// 常量:"ResearchStatus"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResearchStatus = "ResearchStatus";    //目前研究的现状

 /// <summary>
 /// 常量:"InnovationPoints"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InnovationPoints = "InnovationPoints";    //创新点

 /// <summary>
 /// 常量:"ResearchDesign"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResearchDesign = "ResearchDesign";    //研究设计

 /// <summary>
 /// 常量:"DimensionDataProcess"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DimensionDataProcess = "DimensionDataProcess";    //数据处理的维度

 /// <summary>
 /// 常量:"ExpectedConclusion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExpectedConclusion = "ExpectedConclusion";    //预期结论

 /// <summary>
 /// 常量:"ShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareId = "ShareId";    //分享Id

 /// <summary>
 /// 常量:"PaperQCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperQCount = "PaperQCount";    //论文答疑数

 /// <summary>
 /// 常量:"SubVCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubVCount = "SubVCount";    //论文子观点数

 /// <summary>
 /// 常量:"TagsCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TagsCount = "TagsCount";    //论文标注数

 /// <summary>
 /// 常量:"TeaQCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaQCount = "TeaQCount";    //教师提问数

 /// <summary>
 /// 常量:"IdStudyLevel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudyLevel = "IdStudyLevel";    //学段流水号

 /// <summary>
 /// 常量:"IdGrade"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGrade = "IdGrade";    //年级流水号

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

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