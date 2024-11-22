
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperEN
 表名:vPaper(01120549)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表vPaper的关键字(PaperId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperId_vPaper
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
public K_PaperId_vPaper(string strPaperId)
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
 /// <returns>返回:[K_PaperId_vPaper]类型的对象</returns>
public static implicit operator K_PaperId_vPaper(string value)
{
return new K_PaperId_vPaper(value);
}
}
 /// <summary>
 /// v论文表(vPaper)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPaperEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPaper"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 50;
public static string[] AttributeName = new string[] {"PaperId", "PaperTitle", "PaperContent", "Periodical", "Author", "ResearchQuestion", "Keyword", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "IsQuotethesis", "QuoteId", "IsChecked", "Checker", "LiteratureTypeId", "LiteratureTypeName", "BrowseNumber", "IsSubmit", "AppraiseCount", "AttachmentCount", "CollectionCount", "DownloadCount", "OkCount", "Pcount", "Score", "StuScore", "TeaScore", "PaperTypeId", "PaperTypeName", "PaperStatusId", "PaperStatusName", "VersionCount", "IsPublic", "AskQuestion", "ResearchStatus", "InnovationPoints", "ResearchDesign", "DimensionDataProcess", "ExpectedConclusion", "ShareId", "PaperQCount", "SubVCount", "TagsCount", "TeaQCount", "CreateDate", "UpdUser", "UserName", "IdXzCollege", "UpdDate", "Memo"};

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
protected string mstrLiteratureTypeId;    //作文类型Id
protected string mstrLiteratureTypeName;    //作文类型名
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
protected string mstrPaperTypeName;    //论文类型名
protected string mstrPaperStatusId;    //论文状态Id
protected string mstrPaperStatusName;    //论文状态名
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
protected string mstrCreateDate;    //建立日期
protected string mstrUpdUser;    //修改人
protected string mstrUserName;    //用户名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPaperEN()
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
public clsvPaperEN(string strPaperId)
 {
strPaperId = strPaperId.Replace("'", "''");
if (strPaperId.Length > 8)
{
throw new Exception("在表:vPaper中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPaperId)  ==  true)
{
throw new Exception("在表:vPaper中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convPaper.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convPaper.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convPaper.PaperContent)
{
return mstrPaperContent;
}
else if (strAttributeName  ==  convPaper.Periodical)
{
return mstrPeriodical;
}
else if (strAttributeName  ==  convPaper.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convPaper.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  convPaper.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convPaper.LiteratureSources)
{
return mstrLiteratureSources;
}
else if (strAttributeName  ==  convPaper.LiteratureLink)
{
return mstrLiteratureLink;
}
else if (strAttributeName  ==  convPaper.UploadfileUrl)
{
return mstrUploadfileUrl;
}
else if (strAttributeName  ==  convPaper.IsQuotethesis)
{
return mbolIsQuotethesis;
}
else if (strAttributeName  ==  convPaper.QuoteId)
{
return mstrQuoteId;
}
else if (strAttributeName  ==  convPaper.IsChecked)
{
return mbolIsChecked;
}
else if (strAttributeName  ==  convPaper.Checker)
{
return mstrChecker;
}
else if (strAttributeName  ==  convPaper.LiteratureTypeId)
{
return mstrLiteratureTypeId;
}
else if (strAttributeName  ==  convPaper.LiteratureTypeName)
{
return mstrLiteratureTypeName;
}
else if (strAttributeName  ==  convPaper.BrowseNumber)
{
return mintBrowseNumber;
}
else if (strAttributeName  ==  convPaper.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convPaper.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convPaper.AttachmentCount)
{
return mintAttachmentCount;
}
else if (strAttributeName  ==  convPaper.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convPaper.DownloadCount)
{
return mintDownloadCount;
}
else if (strAttributeName  ==  convPaper.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convPaper.Pcount)
{
return mintPcount;
}
else if (strAttributeName  ==  convPaper.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convPaper.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convPaper.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convPaper.PaperTypeId)
{
return mstrPaperTypeId;
}
else if (strAttributeName  ==  convPaper.PaperTypeName)
{
return mstrPaperTypeName;
}
else if (strAttributeName  ==  convPaper.PaperStatusId)
{
return mstrPaperStatusId;
}
else if (strAttributeName  ==  convPaper.PaperStatusName)
{
return mstrPaperStatusName;
}
else if (strAttributeName  ==  convPaper.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convPaper.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convPaper.AskQuestion)
{
return mstrAskQuestion;
}
else if (strAttributeName  ==  convPaper.ResearchStatus)
{
return mstrResearchStatus;
}
else if (strAttributeName  ==  convPaper.InnovationPoints)
{
return mstrInnovationPoints;
}
else if (strAttributeName  ==  convPaper.ResearchDesign)
{
return mstrResearchDesign;
}
else if (strAttributeName  ==  convPaper.DimensionDataProcess)
{
return mstrDimensionDataProcess;
}
else if (strAttributeName  ==  convPaper.ExpectedConclusion)
{
return mstrExpectedConclusion;
}
else if (strAttributeName  ==  convPaper.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  convPaper.PaperQCount)
{
return mintPaperQCount;
}
else if (strAttributeName  ==  convPaper.SubVCount)
{
return mintSubVCount;
}
else if (strAttributeName  ==  convPaper.TagsCount)
{
return mintTagsCount;
}
else if (strAttributeName  ==  convPaper.TeaQCount)
{
return mintTeaQCount;
}
else if (strAttributeName  ==  convPaper.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convPaper.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convPaper.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convPaper.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convPaper.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPaper.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convPaper.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaper.PaperId);
}
else if (strAttributeName  ==  convPaper.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaper.PaperTitle);
}
else if (strAttributeName  ==  convPaper.PaperContent)
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convPaper.PaperContent);
}
else if (strAttributeName  ==  convPaper.Periodical)
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convPaper.Periodical);
}
else if (strAttributeName  ==  convPaper.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convPaper.Author);
}
else if (strAttributeName  ==  convPaper.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convPaper.ResearchQuestion);
}
else if (strAttributeName  ==  convPaper.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPaper.Keyword);
}
else if (strAttributeName  ==  convPaper.LiteratureSources)
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convPaper.LiteratureSources);
}
else if (strAttributeName  ==  convPaper.LiteratureLink)
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convPaper.LiteratureLink);
}
else if (strAttributeName  ==  convPaper.UploadfileUrl)
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convPaper.UploadfileUrl);
}
else if (strAttributeName  ==  convPaper.IsQuotethesis)
{
mbolIsQuotethesis = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaper.IsQuotethesis);
}
else if (strAttributeName  ==  convPaper.QuoteId)
{
mstrQuoteId = value.ToString();
 AddUpdatedFld(convPaper.QuoteId);
}
else if (strAttributeName  ==  convPaper.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaper.IsChecked);
}
else if (strAttributeName  ==  convPaper.Checker)
{
mstrChecker = value.ToString();
 AddUpdatedFld(convPaper.Checker);
}
else if (strAttributeName  ==  convPaper.LiteratureTypeId)
{
mstrLiteratureTypeId = value.ToString();
 AddUpdatedFld(convPaper.LiteratureTypeId);
}
else if (strAttributeName  ==  convPaper.LiteratureTypeName)
{
mstrLiteratureTypeName = value.ToString();
 AddUpdatedFld(convPaper.LiteratureTypeName);
}
else if (strAttributeName  ==  convPaper.BrowseNumber)
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.BrowseNumber);
}
else if (strAttributeName  ==  convPaper.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaper.IsSubmit);
}
else if (strAttributeName  ==  convPaper.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.AppraiseCount);
}
else if (strAttributeName  ==  convPaper.AttachmentCount)
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.AttachmentCount);
}
else if (strAttributeName  ==  convPaper.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.CollectionCount);
}
else if (strAttributeName  ==  convPaper.DownloadCount)
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.DownloadCount);
}
else if (strAttributeName  ==  convPaper.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.OkCount);
}
else if (strAttributeName  ==  convPaper.Pcount)
{
mintPcount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.Pcount);
}
else if (strAttributeName  ==  convPaper.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaper.Score);
}
else if (strAttributeName  ==  convPaper.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaper.StuScore);
}
else if (strAttributeName  ==  convPaper.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaper.TeaScore);
}
else if (strAttributeName  ==  convPaper.PaperTypeId)
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convPaper.PaperTypeId);
}
else if (strAttributeName  ==  convPaper.PaperTypeName)
{
mstrPaperTypeName = value.ToString();
 AddUpdatedFld(convPaper.PaperTypeName);
}
else if (strAttributeName  ==  convPaper.PaperStatusId)
{
mstrPaperStatusId = value.ToString();
 AddUpdatedFld(convPaper.PaperStatusId);
}
else if (strAttributeName  ==  convPaper.PaperStatusName)
{
mstrPaperStatusName = value.ToString();
 AddUpdatedFld(convPaper.PaperStatusName);
}
else if (strAttributeName  ==  convPaper.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.VersionCount);
}
else if (strAttributeName  ==  convPaper.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaper.IsPublic);
}
else if (strAttributeName  ==  convPaper.AskQuestion)
{
mstrAskQuestion = value.ToString();
 AddUpdatedFld(convPaper.AskQuestion);
}
else if (strAttributeName  ==  convPaper.ResearchStatus)
{
mstrResearchStatus = value.ToString();
 AddUpdatedFld(convPaper.ResearchStatus);
}
else if (strAttributeName  ==  convPaper.InnovationPoints)
{
mstrInnovationPoints = value.ToString();
 AddUpdatedFld(convPaper.InnovationPoints);
}
else if (strAttributeName  ==  convPaper.ResearchDesign)
{
mstrResearchDesign = value.ToString();
 AddUpdatedFld(convPaper.ResearchDesign);
}
else if (strAttributeName  ==  convPaper.DimensionDataProcess)
{
mstrDimensionDataProcess = value.ToString();
 AddUpdatedFld(convPaper.DimensionDataProcess);
}
else if (strAttributeName  ==  convPaper.ExpectedConclusion)
{
mstrExpectedConclusion = value.ToString();
 AddUpdatedFld(convPaper.ExpectedConclusion);
}
else if (strAttributeName  ==  convPaper.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convPaper.ShareId);
}
else if (strAttributeName  ==  convPaper.PaperQCount)
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.PaperQCount);
}
else if (strAttributeName  ==  convPaper.SubVCount)
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.SubVCount);
}
else if (strAttributeName  ==  convPaper.TagsCount)
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.TagsCount);
}
else if (strAttributeName  ==  convPaper.TeaQCount)
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.TeaQCount);
}
else if (strAttributeName  ==  convPaper.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convPaper.CreateDate);
}
else if (strAttributeName  ==  convPaper.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaper.UpdUser);
}
else if (strAttributeName  ==  convPaper.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convPaper.UserName);
}
else if (strAttributeName  ==  convPaper.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convPaper.IdXzCollege);
}
else if (strAttributeName  ==  convPaper.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaper.UpdDate);
}
else if (strAttributeName  ==  convPaper.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaper.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convPaper.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convPaper.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convPaper.PaperContent  ==  AttributeName[intIndex])
{
return mstrPaperContent;
}
else if (convPaper.Periodical  ==  AttributeName[intIndex])
{
return mstrPeriodical;
}
else if (convPaper.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convPaper.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (convPaper.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convPaper.LiteratureSources  ==  AttributeName[intIndex])
{
return mstrLiteratureSources;
}
else if (convPaper.LiteratureLink  ==  AttributeName[intIndex])
{
return mstrLiteratureLink;
}
else if (convPaper.UploadfileUrl  ==  AttributeName[intIndex])
{
return mstrUploadfileUrl;
}
else if (convPaper.IsQuotethesis  ==  AttributeName[intIndex])
{
return mbolIsQuotethesis;
}
else if (convPaper.QuoteId  ==  AttributeName[intIndex])
{
return mstrQuoteId;
}
else if (convPaper.IsChecked  ==  AttributeName[intIndex])
{
return mbolIsChecked;
}
else if (convPaper.Checker  ==  AttributeName[intIndex])
{
return mstrChecker;
}
else if (convPaper.LiteratureTypeId  ==  AttributeName[intIndex])
{
return mstrLiteratureTypeId;
}
else if (convPaper.LiteratureTypeName  ==  AttributeName[intIndex])
{
return mstrLiteratureTypeName;
}
else if (convPaper.BrowseNumber  ==  AttributeName[intIndex])
{
return mintBrowseNumber;
}
else if (convPaper.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convPaper.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convPaper.AttachmentCount  ==  AttributeName[intIndex])
{
return mintAttachmentCount;
}
else if (convPaper.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convPaper.DownloadCount  ==  AttributeName[intIndex])
{
return mintDownloadCount;
}
else if (convPaper.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convPaper.Pcount  ==  AttributeName[intIndex])
{
return mintPcount;
}
else if (convPaper.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convPaper.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convPaper.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convPaper.PaperTypeId  ==  AttributeName[intIndex])
{
return mstrPaperTypeId;
}
else if (convPaper.PaperTypeName  ==  AttributeName[intIndex])
{
return mstrPaperTypeName;
}
else if (convPaper.PaperStatusId  ==  AttributeName[intIndex])
{
return mstrPaperStatusId;
}
else if (convPaper.PaperStatusName  ==  AttributeName[intIndex])
{
return mstrPaperStatusName;
}
else if (convPaper.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convPaper.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convPaper.AskQuestion  ==  AttributeName[intIndex])
{
return mstrAskQuestion;
}
else if (convPaper.ResearchStatus  ==  AttributeName[intIndex])
{
return mstrResearchStatus;
}
else if (convPaper.InnovationPoints  ==  AttributeName[intIndex])
{
return mstrInnovationPoints;
}
else if (convPaper.ResearchDesign  ==  AttributeName[intIndex])
{
return mstrResearchDesign;
}
else if (convPaper.DimensionDataProcess  ==  AttributeName[intIndex])
{
return mstrDimensionDataProcess;
}
else if (convPaper.ExpectedConclusion  ==  AttributeName[intIndex])
{
return mstrExpectedConclusion;
}
else if (convPaper.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (convPaper.PaperQCount  ==  AttributeName[intIndex])
{
return mintPaperQCount;
}
else if (convPaper.SubVCount  ==  AttributeName[intIndex])
{
return mintSubVCount;
}
else if (convPaper.TagsCount  ==  AttributeName[intIndex])
{
return mintTagsCount;
}
else if (convPaper.TeaQCount  ==  AttributeName[intIndex])
{
return mintTeaQCount;
}
else if (convPaper.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convPaper.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convPaper.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convPaper.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convPaper.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPaper.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convPaper.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaper.PaperId);
}
else if (convPaper.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaper.PaperTitle);
}
else if (convPaper.PaperContent  ==  AttributeName[intIndex])
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convPaper.PaperContent);
}
else if (convPaper.Periodical  ==  AttributeName[intIndex])
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convPaper.Periodical);
}
else if (convPaper.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convPaper.Author);
}
else if (convPaper.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convPaper.ResearchQuestion);
}
else if (convPaper.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPaper.Keyword);
}
else if (convPaper.LiteratureSources  ==  AttributeName[intIndex])
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convPaper.LiteratureSources);
}
else if (convPaper.LiteratureLink  ==  AttributeName[intIndex])
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convPaper.LiteratureLink);
}
else if (convPaper.UploadfileUrl  ==  AttributeName[intIndex])
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convPaper.UploadfileUrl);
}
else if (convPaper.IsQuotethesis  ==  AttributeName[intIndex])
{
mbolIsQuotethesis = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaper.IsQuotethesis);
}
else if (convPaper.QuoteId  ==  AttributeName[intIndex])
{
mstrQuoteId = value.ToString();
 AddUpdatedFld(convPaper.QuoteId);
}
else if (convPaper.IsChecked  ==  AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaper.IsChecked);
}
else if (convPaper.Checker  ==  AttributeName[intIndex])
{
mstrChecker = value.ToString();
 AddUpdatedFld(convPaper.Checker);
}
else if (convPaper.LiteratureTypeId  ==  AttributeName[intIndex])
{
mstrLiteratureTypeId = value.ToString();
 AddUpdatedFld(convPaper.LiteratureTypeId);
}
else if (convPaper.LiteratureTypeName  ==  AttributeName[intIndex])
{
mstrLiteratureTypeName = value.ToString();
 AddUpdatedFld(convPaper.LiteratureTypeName);
}
else if (convPaper.BrowseNumber  ==  AttributeName[intIndex])
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.BrowseNumber);
}
else if (convPaper.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaper.IsSubmit);
}
else if (convPaper.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.AppraiseCount);
}
else if (convPaper.AttachmentCount  ==  AttributeName[intIndex])
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.AttachmentCount);
}
else if (convPaper.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.CollectionCount);
}
else if (convPaper.DownloadCount  ==  AttributeName[intIndex])
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.DownloadCount);
}
else if (convPaper.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.OkCount);
}
else if (convPaper.Pcount  ==  AttributeName[intIndex])
{
mintPcount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.Pcount);
}
else if (convPaper.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaper.Score);
}
else if (convPaper.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaper.StuScore);
}
else if (convPaper.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaper.TeaScore);
}
else if (convPaper.PaperTypeId  ==  AttributeName[intIndex])
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convPaper.PaperTypeId);
}
else if (convPaper.PaperTypeName  ==  AttributeName[intIndex])
{
mstrPaperTypeName = value.ToString();
 AddUpdatedFld(convPaper.PaperTypeName);
}
else if (convPaper.PaperStatusId  ==  AttributeName[intIndex])
{
mstrPaperStatusId = value.ToString();
 AddUpdatedFld(convPaper.PaperStatusId);
}
else if (convPaper.PaperStatusName  ==  AttributeName[intIndex])
{
mstrPaperStatusName = value.ToString();
 AddUpdatedFld(convPaper.PaperStatusName);
}
else if (convPaper.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.VersionCount);
}
else if (convPaper.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaper.IsPublic);
}
else if (convPaper.AskQuestion  ==  AttributeName[intIndex])
{
mstrAskQuestion = value.ToString();
 AddUpdatedFld(convPaper.AskQuestion);
}
else if (convPaper.ResearchStatus  ==  AttributeName[intIndex])
{
mstrResearchStatus = value.ToString();
 AddUpdatedFld(convPaper.ResearchStatus);
}
else if (convPaper.InnovationPoints  ==  AttributeName[intIndex])
{
mstrInnovationPoints = value.ToString();
 AddUpdatedFld(convPaper.InnovationPoints);
}
else if (convPaper.ResearchDesign  ==  AttributeName[intIndex])
{
mstrResearchDesign = value.ToString();
 AddUpdatedFld(convPaper.ResearchDesign);
}
else if (convPaper.DimensionDataProcess  ==  AttributeName[intIndex])
{
mstrDimensionDataProcess = value.ToString();
 AddUpdatedFld(convPaper.DimensionDataProcess);
}
else if (convPaper.ExpectedConclusion  ==  AttributeName[intIndex])
{
mstrExpectedConclusion = value.ToString();
 AddUpdatedFld(convPaper.ExpectedConclusion);
}
else if (convPaper.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convPaper.ShareId);
}
else if (convPaper.PaperQCount  ==  AttributeName[intIndex])
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.PaperQCount);
}
else if (convPaper.SubVCount  ==  AttributeName[intIndex])
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.SubVCount);
}
else if (convPaper.TagsCount  ==  AttributeName[intIndex])
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.TagsCount);
}
else if (convPaper.TeaQCount  ==  AttributeName[intIndex])
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaper.TeaQCount);
}
else if (convPaper.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convPaper.CreateDate);
}
else if (convPaper.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaper.UpdUser);
}
else if (convPaper.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convPaper.UserName);
}
else if (convPaper.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convPaper.IdXzCollege);
}
else if (convPaper.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaper.UpdDate);
}
else if (convPaper.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaper.Memo);
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
 AddUpdatedFld(convPaper.PaperId);
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
 AddUpdatedFld(convPaper.PaperTitle);
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
 AddUpdatedFld(convPaper.PaperContent);
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
 AddUpdatedFld(convPaper.Periodical);
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
 AddUpdatedFld(convPaper.Author);
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
 AddUpdatedFld(convPaper.ResearchQuestion);
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
 AddUpdatedFld(convPaper.Keyword);
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
 AddUpdatedFld(convPaper.LiteratureSources);
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
 AddUpdatedFld(convPaper.LiteratureLink);
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
 AddUpdatedFld(convPaper.UploadfileUrl);
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
 AddUpdatedFld(convPaper.IsQuotethesis);
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
 AddUpdatedFld(convPaper.QuoteId);
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
 AddUpdatedFld(convPaper.IsChecked);
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
 AddUpdatedFld(convPaper.Checker);
}
}
/// <summary>
/// 作文类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
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
 AddUpdatedFld(convPaper.LiteratureTypeId);
}
}
/// <summary>
/// 作文类型名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiteratureTypeName
{
get
{
return mstrLiteratureTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiteratureTypeName = value;
}
else
{
 mstrLiteratureTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaper.LiteratureTypeName);
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
 AddUpdatedFld(convPaper.BrowseNumber);
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
 AddUpdatedFld(convPaper.IsSubmit);
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
 AddUpdatedFld(convPaper.AppraiseCount);
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
 AddUpdatedFld(convPaper.AttachmentCount);
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
 AddUpdatedFld(convPaper.CollectionCount);
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
 AddUpdatedFld(convPaper.DownloadCount);
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
 AddUpdatedFld(convPaper.OkCount);
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
 AddUpdatedFld(convPaper.Pcount);
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
 AddUpdatedFld(convPaper.Score);
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
 AddUpdatedFld(convPaper.StuScore);
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
 AddUpdatedFld(convPaper.TeaScore);
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
 AddUpdatedFld(convPaper.PaperTypeId);
}
}
/// <summary>
/// 论文类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTypeName
{
get
{
return mstrPaperTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTypeName = value;
}
else
{
 mstrPaperTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaper.PaperTypeName);
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
 AddUpdatedFld(convPaper.PaperStatusId);
}
}
/// <summary>
/// 论文状态名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperStatusName
{
get
{
return mstrPaperStatusName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperStatusName = value;
}
else
{
 mstrPaperStatusName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaper.PaperStatusName);
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
 AddUpdatedFld(convPaper.VersionCount);
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
 AddUpdatedFld(convPaper.IsPublic);
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
 AddUpdatedFld(convPaper.AskQuestion);
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
 AddUpdatedFld(convPaper.ResearchStatus);
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
 AddUpdatedFld(convPaper.InnovationPoints);
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
 AddUpdatedFld(convPaper.ResearchDesign);
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
 AddUpdatedFld(convPaper.DimensionDataProcess);
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
 AddUpdatedFld(convPaper.ExpectedConclusion);
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
 AddUpdatedFld(convPaper.ShareId);
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
 AddUpdatedFld(convPaper.PaperQCount);
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
 AddUpdatedFld(convPaper.SubVCount);
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
 AddUpdatedFld(convPaper.TagsCount);
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
 AddUpdatedFld(convPaper.TeaQCount);
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
 AddUpdatedFld(convPaper.CreateDate);
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
 AddUpdatedFld(convPaper.UpdUser);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaper.UserName);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzCollege
{
get
{
return mstrIdXzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzCollege = value;
}
else
{
 mstrIdXzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaper.IdXzCollege);
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
 AddUpdatedFld(convPaper.UpdDate);
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
 AddUpdatedFld(convPaper.Memo);
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
 /// v论文表(vPaper)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPaper
{
public const string _CurrTabName = "vPaper"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperId", "PaperTitle", "PaperContent", "Periodical", "Author", "ResearchQuestion", "Keyword", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "IsQuotethesis", "QuoteId", "IsChecked", "Checker", "LiteratureTypeId", "LiteratureTypeName", "BrowseNumber", "IsSubmit", "AppraiseCount", "AttachmentCount", "CollectionCount", "DownloadCount", "OkCount", "Pcount", "Score", "StuScore", "TeaScore", "PaperTypeId", "PaperTypeName", "PaperStatusId", "PaperStatusName", "VersionCount", "IsPublic", "AskQuestion", "ResearchStatus", "InnovationPoints", "ResearchDesign", "DimensionDataProcess", "ExpectedConclusion", "ShareId", "PaperQCount", "SubVCount", "TagsCount", "TeaQCount", "CreateDate", "UpdUser", "UserName", "IdXzCollege", "UpdDate", "Memo"};
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
 public const string LiteratureTypeId = "LiteratureTypeId";    //作文类型Id

 /// <summary>
 /// 常量:"LiteratureTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureTypeName = "LiteratureTypeName";    //作文类型名

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
 /// 常量:"PaperTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTypeName = "PaperTypeName";    //论文类型名

 /// <summary>
 /// 常量:"PaperStatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperStatusId = "PaperStatusId";    //论文状态Id

 /// <summary>
 /// 常量:"PaperStatusName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperStatusName = "PaperStatusName";    //论文状态名

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
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

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