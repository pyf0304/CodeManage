
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_CompositionEN
 表名:zx_Composition(01120761)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:53:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
 /// 表zx_Composition的关键字(zxPaperId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxPaperId_zx_Composition
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxPaperId">表关键字</param>
public K_zxPaperId_zx_Composition(string strzxPaperId)
{
if (IsValid(strzxPaperId)) Value = strzxPaperId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxPaperId)
{
if (string.IsNullOrEmpty(strzxPaperId) == true) return false;
if (strzxPaperId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxPaperId_zx_Composition]类型的对象</returns>
public static implicit operator K_zxPaperId_zx_Composition(string value)
{
return new K_zxPaperId_zx_Composition(value);
}
}
 /// <summary>
 /// 作文表(zx_Composition)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_CompositionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_Composition"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxPaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 48;
public static string[] AttributeName = new string[] {"zxPaperId", "PaperTitle", "PaperName", "PaperContent", "Periodical", "Author", "ResearchQuestion", "UpdDate", "Memo", "Keyword", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "IsQuotethesis", "QuoteId", "IsChecked", "Checker", "zxLiteratureTypeId", "BrowseNumber", "IsSubmit", "AppraiseCount", "AttachmentCount", "CollectionCount", "DownloadCount", "OkCount", "Pcount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PaperTypeId", "zxPaperStatusId", "VersionCount", "IsPublic", "AskQuestion", "ResearchStatus", "InnovationPoints", "ResearchDesign", "DimensionDataProcess", "ExpectedConclusion", "CreateDate", "zxShareId", "UpdUser", "PaperQCount", "SubVCount", "TagsCount", "TeaQCount", "GroupTextId"};

protected string mstrzxPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected string mstrPaperName;    //主题名称
protected string mstrPaperContent;    //主题内容
protected string mstrPeriodical;    //期刊
protected string mstrAuthor;    //作者
protected string mstrResearchQuestion;    //研究问题
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrKeyword;    //关键字
protected string mstrLiteratureSources;    //文献来源
protected string mstrLiteratureLink;    //文献链接
protected string mstrUploadfileUrl;    //文件地址
protected bool mbolIsQuotethesis;    //是否引用论文
protected string mstrQuoteId;    //引用Id
protected bool mbolIsChecked;    //是否检查
protected string mstrChecker;    //审核人
protected string mstrzxLiteratureTypeId;    //作文类型Id
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
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPaperTypeId;    //论文类型Id
protected string mstrzxPaperStatusId;    //论文状态Id
protected int? mintVersionCount;    //版本统计
protected bool mbolIsPublic;    //是否公开
protected string mstrAskQuestion;    //问题提出
protected string mstrResearchStatus;    //目前研究的现状
protected string mstrInnovationPoints;    //创新点
protected string mstrResearchDesign;    //研究设计
protected string mstrDimensionDataProcess;    //数据处理的维度
protected string mstrExpectedConclusion;    //预期结论
protected string mstrCreateDate;    //建立日期
protected string mstrzxShareId;    //分享Id
protected string mstrUpdUser;    //修改人
protected int? mintPaperQCount;    //论文答疑数
protected int? mintSubVCount;    //论文子观点数
protected int? mintTagsCount;    //论文标注数
protected int? mintTeaQCount;    //教师提问数
protected string mstrGroupTextId;    //小组Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_CompositionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxPaperId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxPaperId">关键字:论文Id</param>
public clszx_CompositionEN(string strzxPaperId)
 {
strzxPaperId = strzxPaperId.Replace("'", "''");
if (strzxPaperId.Length > 8)
{
throw new Exception("在表:zx_Composition中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxPaperId)  ==  true)
{
throw new Exception("在表:zx_Composition中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxPaperId = strzxPaperId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxPaperId");
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
if (strAttributeName  ==  conzx_Composition.zxPaperId)
{
return mstrzxPaperId;
}
else if (strAttributeName  ==  conzx_Composition.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  conzx_Composition.PaperName)
{
return mstrPaperName;
}
else if (strAttributeName  ==  conzx_Composition.PaperContent)
{
return mstrPaperContent;
}
else if (strAttributeName  ==  conzx_Composition.Periodical)
{
return mstrPeriodical;
}
else if (strAttributeName  ==  conzx_Composition.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  conzx_Composition.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  conzx_Composition.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_Composition.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_Composition.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  conzx_Composition.LiteratureSources)
{
return mstrLiteratureSources;
}
else if (strAttributeName  ==  conzx_Composition.LiteratureLink)
{
return mstrLiteratureLink;
}
else if (strAttributeName  ==  conzx_Composition.UploadfileUrl)
{
return mstrUploadfileUrl;
}
else if (strAttributeName  ==  conzx_Composition.IsQuotethesis)
{
return mbolIsQuotethesis;
}
else if (strAttributeName  ==  conzx_Composition.QuoteId)
{
return mstrQuoteId;
}
else if (strAttributeName  ==  conzx_Composition.IsChecked)
{
return mbolIsChecked;
}
else if (strAttributeName  ==  conzx_Composition.Checker)
{
return mstrChecker;
}
else if (strAttributeName  ==  conzx_Composition.zxLiteratureTypeId)
{
return mstrzxLiteratureTypeId;
}
else if (strAttributeName  ==  conzx_Composition.BrowseNumber)
{
return mintBrowseNumber;
}
else if (strAttributeName  ==  conzx_Composition.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conzx_Composition.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  conzx_Composition.AttachmentCount)
{
return mintAttachmentCount;
}
else if (strAttributeName  ==  conzx_Composition.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  conzx_Composition.DownloadCount)
{
return mintDownloadCount;
}
else if (strAttributeName  ==  conzx_Composition.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  conzx_Composition.Pcount)
{
return mintPcount;
}
else if (strAttributeName  ==  conzx_Composition.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conzx_Composition.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  conzx_Composition.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  conzx_Composition.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_Composition.PaperTypeId)
{
return mstrPaperTypeId;
}
else if (strAttributeName  ==  conzx_Composition.zxPaperStatusId)
{
return mstrzxPaperStatusId;
}
else if (strAttributeName  ==  conzx_Composition.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  conzx_Composition.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  conzx_Composition.AskQuestion)
{
return mstrAskQuestion;
}
else if (strAttributeName  ==  conzx_Composition.ResearchStatus)
{
return mstrResearchStatus;
}
else if (strAttributeName  ==  conzx_Composition.InnovationPoints)
{
return mstrInnovationPoints;
}
else if (strAttributeName  ==  conzx_Composition.ResearchDesign)
{
return mstrResearchDesign;
}
else if (strAttributeName  ==  conzx_Composition.DimensionDataProcess)
{
return mstrDimensionDataProcess;
}
else if (strAttributeName  ==  conzx_Composition.ExpectedConclusion)
{
return mstrExpectedConclusion;
}
else if (strAttributeName  ==  conzx_Composition.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conzx_Composition.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  conzx_Composition.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_Composition.PaperQCount)
{
return mintPaperQCount;
}
else if (strAttributeName  ==  conzx_Composition.SubVCount)
{
return mintSubVCount;
}
else if (strAttributeName  ==  conzx_Composition.TagsCount)
{
return mintTagsCount;
}
else if (strAttributeName  ==  conzx_Composition.TeaQCount)
{
return mintTeaQCount;
}
else if (strAttributeName  ==  conzx_Composition.GroupTextId)
{
return mstrGroupTextId;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_Composition.zxPaperId)
{
mstrzxPaperId = value.ToString();
 AddUpdatedFld(conzx_Composition.zxPaperId);
}
else if (strAttributeName  ==  conzx_Composition.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(conzx_Composition.PaperTitle);
}
else if (strAttributeName  ==  conzx_Composition.PaperName)
{
mstrPaperName = value.ToString();
 AddUpdatedFld(conzx_Composition.PaperName);
}
else if (strAttributeName  ==  conzx_Composition.PaperContent)
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(conzx_Composition.PaperContent);
}
else if (strAttributeName  ==  conzx_Composition.Periodical)
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(conzx_Composition.Periodical);
}
else if (strAttributeName  ==  conzx_Composition.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(conzx_Composition.Author);
}
else if (strAttributeName  ==  conzx_Composition.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(conzx_Composition.ResearchQuestion);
}
else if (strAttributeName  ==  conzx_Composition.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_Composition.UpdDate);
}
else if (strAttributeName  ==  conzx_Composition.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_Composition.Memo);
}
else if (strAttributeName  ==  conzx_Composition.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(conzx_Composition.Keyword);
}
else if (strAttributeName  ==  conzx_Composition.LiteratureSources)
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(conzx_Composition.LiteratureSources);
}
else if (strAttributeName  ==  conzx_Composition.LiteratureLink)
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(conzx_Composition.LiteratureLink);
}
else if (strAttributeName  ==  conzx_Composition.UploadfileUrl)
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(conzx_Composition.UploadfileUrl);
}
else if (strAttributeName  ==  conzx_Composition.IsQuotethesis)
{
mbolIsQuotethesis = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_Composition.IsQuotethesis);
}
else if (strAttributeName  ==  conzx_Composition.QuoteId)
{
mstrQuoteId = value.ToString();
 AddUpdatedFld(conzx_Composition.QuoteId);
}
else if (strAttributeName  ==  conzx_Composition.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_Composition.IsChecked);
}
else if (strAttributeName  ==  conzx_Composition.Checker)
{
mstrChecker = value.ToString();
 AddUpdatedFld(conzx_Composition.Checker);
}
else if (strAttributeName  ==  conzx_Composition.zxLiteratureTypeId)
{
mstrzxLiteratureTypeId = value.ToString();
 AddUpdatedFld(conzx_Composition.zxLiteratureTypeId);
}
else if (strAttributeName  ==  conzx_Composition.BrowseNumber)
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.BrowseNumber);
}
else if (strAttributeName  ==  conzx_Composition.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_Composition.IsSubmit);
}
else if (strAttributeName  ==  conzx_Composition.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.AppraiseCount);
}
else if (strAttributeName  ==  conzx_Composition.AttachmentCount)
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.AttachmentCount);
}
else if (strAttributeName  ==  conzx_Composition.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.CollectionCount);
}
else if (strAttributeName  ==  conzx_Composition.DownloadCount)
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.DownloadCount);
}
else if (strAttributeName  ==  conzx_Composition.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.OkCount);
}
else if (strAttributeName  ==  conzx_Composition.Pcount)
{
mintPcount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.Pcount);
}
else if (strAttributeName  ==  conzx_Composition.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Composition.Score);
}
else if (strAttributeName  ==  conzx_Composition.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Composition.StuScore);
}
else if (strAttributeName  ==  conzx_Composition.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Composition.TeaScore);
}
else if (strAttributeName  ==  conzx_Composition.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_Composition.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_Composition.PaperTypeId)
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(conzx_Composition.PaperTypeId);
}
else if (strAttributeName  ==  conzx_Composition.zxPaperStatusId)
{
mstrzxPaperStatusId = value.ToString();
 AddUpdatedFld(conzx_Composition.zxPaperStatusId);
}
else if (strAttributeName  ==  conzx_Composition.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.VersionCount);
}
else if (strAttributeName  ==  conzx_Composition.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_Composition.IsPublic);
}
else if (strAttributeName  ==  conzx_Composition.AskQuestion)
{
mstrAskQuestion = value.ToString();
 AddUpdatedFld(conzx_Composition.AskQuestion);
}
else if (strAttributeName  ==  conzx_Composition.ResearchStatus)
{
mstrResearchStatus = value.ToString();
 AddUpdatedFld(conzx_Composition.ResearchStatus);
}
else if (strAttributeName  ==  conzx_Composition.InnovationPoints)
{
mstrInnovationPoints = value.ToString();
 AddUpdatedFld(conzx_Composition.InnovationPoints);
}
else if (strAttributeName  ==  conzx_Composition.ResearchDesign)
{
mstrResearchDesign = value.ToString();
 AddUpdatedFld(conzx_Composition.ResearchDesign);
}
else if (strAttributeName  ==  conzx_Composition.DimensionDataProcess)
{
mstrDimensionDataProcess = value.ToString();
 AddUpdatedFld(conzx_Composition.DimensionDataProcess);
}
else if (strAttributeName  ==  conzx_Composition.ExpectedConclusion)
{
mstrExpectedConclusion = value.ToString();
 AddUpdatedFld(conzx_Composition.ExpectedConclusion);
}
else if (strAttributeName  ==  conzx_Composition.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conzx_Composition.CreateDate);
}
else if (strAttributeName  ==  conzx_Composition.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(conzx_Composition.zxShareId);
}
else if (strAttributeName  ==  conzx_Composition.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_Composition.UpdUser);
}
else if (strAttributeName  ==  conzx_Composition.PaperQCount)
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.PaperQCount);
}
else if (strAttributeName  ==  conzx_Composition.SubVCount)
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.SubVCount);
}
else if (strAttributeName  ==  conzx_Composition.TagsCount)
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.TagsCount);
}
else if (strAttributeName  ==  conzx_Composition.TeaQCount)
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.TeaQCount);
}
else if (strAttributeName  ==  conzx_Composition.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_Composition.GroupTextId);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_Composition.zxPaperId  ==  AttributeName[intIndex])
{
return mstrzxPaperId;
}
else if (conzx_Composition.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (conzx_Composition.PaperName  ==  AttributeName[intIndex])
{
return mstrPaperName;
}
else if (conzx_Composition.PaperContent  ==  AttributeName[intIndex])
{
return mstrPaperContent;
}
else if (conzx_Composition.Periodical  ==  AttributeName[intIndex])
{
return mstrPeriodical;
}
else if (conzx_Composition.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (conzx_Composition.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (conzx_Composition.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_Composition.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_Composition.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (conzx_Composition.LiteratureSources  ==  AttributeName[intIndex])
{
return mstrLiteratureSources;
}
else if (conzx_Composition.LiteratureLink  ==  AttributeName[intIndex])
{
return mstrLiteratureLink;
}
else if (conzx_Composition.UploadfileUrl  ==  AttributeName[intIndex])
{
return mstrUploadfileUrl;
}
else if (conzx_Composition.IsQuotethesis  ==  AttributeName[intIndex])
{
return mbolIsQuotethesis;
}
else if (conzx_Composition.QuoteId  ==  AttributeName[intIndex])
{
return mstrQuoteId;
}
else if (conzx_Composition.IsChecked  ==  AttributeName[intIndex])
{
return mbolIsChecked;
}
else if (conzx_Composition.Checker  ==  AttributeName[intIndex])
{
return mstrChecker;
}
else if (conzx_Composition.zxLiteratureTypeId  ==  AttributeName[intIndex])
{
return mstrzxLiteratureTypeId;
}
else if (conzx_Composition.BrowseNumber  ==  AttributeName[intIndex])
{
return mintBrowseNumber;
}
else if (conzx_Composition.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conzx_Composition.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (conzx_Composition.AttachmentCount  ==  AttributeName[intIndex])
{
return mintAttachmentCount;
}
else if (conzx_Composition.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (conzx_Composition.DownloadCount  ==  AttributeName[intIndex])
{
return mintDownloadCount;
}
else if (conzx_Composition.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (conzx_Composition.Pcount  ==  AttributeName[intIndex])
{
return mintPcount;
}
else if (conzx_Composition.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conzx_Composition.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (conzx_Composition.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (conzx_Composition.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_Composition.PaperTypeId  ==  AttributeName[intIndex])
{
return mstrPaperTypeId;
}
else if (conzx_Composition.zxPaperStatusId  ==  AttributeName[intIndex])
{
return mstrzxPaperStatusId;
}
else if (conzx_Composition.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (conzx_Composition.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (conzx_Composition.AskQuestion  ==  AttributeName[intIndex])
{
return mstrAskQuestion;
}
else if (conzx_Composition.ResearchStatus  ==  AttributeName[intIndex])
{
return mstrResearchStatus;
}
else if (conzx_Composition.InnovationPoints  ==  AttributeName[intIndex])
{
return mstrInnovationPoints;
}
else if (conzx_Composition.ResearchDesign  ==  AttributeName[intIndex])
{
return mstrResearchDesign;
}
else if (conzx_Composition.DimensionDataProcess  ==  AttributeName[intIndex])
{
return mstrDimensionDataProcess;
}
else if (conzx_Composition.ExpectedConclusion  ==  AttributeName[intIndex])
{
return mstrExpectedConclusion;
}
else if (conzx_Composition.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conzx_Composition.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (conzx_Composition.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_Composition.PaperQCount  ==  AttributeName[intIndex])
{
return mintPaperQCount;
}
else if (conzx_Composition.SubVCount  ==  AttributeName[intIndex])
{
return mintSubVCount;
}
else if (conzx_Composition.TagsCount  ==  AttributeName[intIndex])
{
return mintTagsCount;
}
else if (conzx_Composition.TeaQCount  ==  AttributeName[intIndex])
{
return mintTeaQCount;
}
else if (conzx_Composition.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
return null;
}
set
{
if (conzx_Composition.zxPaperId  ==  AttributeName[intIndex])
{
mstrzxPaperId = value.ToString();
 AddUpdatedFld(conzx_Composition.zxPaperId);
}
else if (conzx_Composition.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(conzx_Composition.PaperTitle);
}
else if (conzx_Composition.PaperName  ==  AttributeName[intIndex])
{
mstrPaperName = value.ToString();
 AddUpdatedFld(conzx_Composition.PaperName);
}
else if (conzx_Composition.PaperContent  ==  AttributeName[intIndex])
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(conzx_Composition.PaperContent);
}
else if (conzx_Composition.Periodical  ==  AttributeName[intIndex])
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(conzx_Composition.Periodical);
}
else if (conzx_Composition.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(conzx_Composition.Author);
}
else if (conzx_Composition.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(conzx_Composition.ResearchQuestion);
}
else if (conzx_Composition.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_Composition.UpdDate);
}
else if (conzx_Composition.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_Composition.Memo);
}
else if (conzx_Composition.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(conzx_Composition.Keyword);
}
else if (conzx_Composition.LiteratureSources  ==  AttributeName[intIndex])
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(conzx_Composition.LiteratureSources);
}
else if (conzx_Composition.LiteratureLink  ==  AttributeName[intIndex])
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(conzx_Composition.LiteratureLink);
}
else if (conzx_Composition.UploadfileUrl  ==  AttributeName[intIndex])
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(conzx_Composition.UploadfileUrl);
}
else if (conzx_Composition.IsQuotethesis  ==  AttributeName[intIndex])
{
mbolIsQuotethesis = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_Composition.IsQuotethesis);
}
else if (conzx_Composition.QuoteId  ==  AttributeName[intIndex])
{
mstrQuoteId = value.ToString();
 AddUpdatedFld(conzx_Composition.QuoteId);
}
else if (conzx_Composition.IsChecked  ==  AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_Composition.IsChecked);
}
else if (conzx_Composition.Checker  ==  AttributeName[intIndex])
{
mstrChecker = value.ToString();
 AddUpdatedFld(conzx_Composition.Checker);
}
else if (conzx_Composition.zxLiteratureTypeId  ==  AttributeName[intIndex])
{
mstrzxLiteratureTypeId = value.ToString();
 AddUpdatedFld(conzx_Composition.zxLiteratureTypeId);
}
else if (conzx_Composition.BrowseNumber  ==  AttributeName[intIndex])
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.BrowseNumber);
}
else if (conzx_Composition.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_Composition.IsSubmit);
}
else if (conzx_Composition.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.AppraiseCount);
}
else if (conzx_Composition.AttachmentCount  ==  AttributeName[intIndex])
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.AttachmentCount);
}
else if (conzx_Composition.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.CollectionCount);
}
else if (conzx_Composition.DownloadCount  ==  AttributeName[intIndex])
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.DownloadCount);
}
else if (conzx_Composition.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.OkCount);
}
else if (conzx_Composition.Pcount  ==  AttributeName[intIndex])
{
mintPcount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.Pcount);
}
else if (conzx_Composition.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Composition.Score);
}
else if (conzx_Composition.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Composition.StuScore);
}
else if (conzx_Composition.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Composition.TeaScore);
}
else if (conzx_Composition.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_Composition.IdCurrEduCls);
}
else if (conzx_Composition.PaperTypeId  ==  AttributeName[intIndex])
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(conzx_Composition.PaperTypeId);
}
else if (conzx_Composition.zxPaperStatusId  ==  AttributeName[intIndex])
{
mstrzxPaperStatusId = value.ToString();
 AddUpdatedFld(conzx_Composition.zxPaperStatusId);
}
else if (conzx_Composition.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.VersionCount);
}
else if (conzx_Composition.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_Composition.IsPublic);
}
else if (conzx_Composition.AskQuestion  ==  AttributeName[intIndex])
{
mstrAskQuestion = value.ToString();
 AddUpdatedFld(conzx_Composition.AskQuestion);
}
else if (conzx_Composition.ResearchStatus  ==  AttributeName[intIndex])
{
mstrResearchStatus = value.ToString();
 AddUpdatedFld(conzx_Composition.ResearchStatus);
}
else if (conzx_Composition.InnovationPoints  ==  AttributeName[intIndex])
{
mstrInnovationPoints = value.ToString();
 AddUpdatedFld(conzx_Composition.InnovationPoints);
}
else if (conzx_Composition.ResearchDesign  ==  AttributeName[intIndex])
{
mstrResearchDesign = value.ToString();
 AddUpdatedFld(conzx_Composition.ResearchDesign);
}
else if (conzx_Composition.DimensionDataProcess  ==  AttributeName[intIndex])
{
mstrDimensionDataProcess = value.ToString();
 AddUpdatedFld(conzx_Composition.DimensionDataProcess);
}
else if (conzx_Composition.ExpectedConclusion  ==  AttributeName[intIndex])
{
mstrExpectedConclusion = value.ToString();
 AddUpdatedFld(conzx_Composition.ExpectedConclusion);
}
else if (conzx_Composition.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conzx_Composition.CreateDate);
}
else if (conzx_Composition.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(conzx_Composition.zxShareId);
}
else if (conzx_Composition.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_Composition.UpdUser);
}
else if (conzx_Composition.PaperQCount  ==  AttributeName[intIndex])
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.PaperQCount);
}
else if (conzx_Composition.SubVCount  ==  AttributeName[intIndex])
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.SubVCount);
}
else if (conzx_Composition.TagsCount  ==  AttributeName[intIndex])
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.TagsCount);
}
else if (conzx_Composition.TeaQCount  ==  AttributeName[intIndex])
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Composition.TeaQCount);
}
else if (conzx_Composition.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_Composition.GroupTextId);
}
}
}

/// <summary>
/// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxPaperId
{
get
{
return mstrzxPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxPaperId = value;
}
else
{
 mstrzxPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Composition.zxPaperId);
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
 AddUpdatedFld(conzx_Composition.PaperTitle);
}
}
/// <summary>
/// 主题名称(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperName
{
get
{
return mstrPaperName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperName = value;
}
else
{
 mstrPaperName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Composition.PaperName);
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
 AddUpdatedFld(conzx_Composition.PaperContent);
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
 AddUpdatedFld(conzx_Composition.Periodical);
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
 AddUpdatedFld(conzx_Composition.Author);
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
 AddUpdatedFld(conzx_Composition.ResearchQuestion);
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
 AddUpdatedFld(conzx_Composition.UpdDate);
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
 AddUpdatedFld(conzx_Composition.Memo);
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
 AddUpdatedFld(conzx_Composition.Keyword);
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
 AddUpdatedFld(conzx_Composition.LiteratureSources);
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
 AddUpdatedFld(conzx_Composition.LiteratureLink);
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
 AddUpdatedFld(conzx_Composition.UploadfileUrl);
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
 AddUpdatedFld(conzx_Composition.IsQuotethesis);
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
 AddUpdatedFld(conzx_Composition.QuoteId);
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
 AddUpdatedFld(conzx_Composition.IsChecked);
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
 AddUpdatedFld(conzx_Composition.Checker);
}
}
/// <summary>
/// 作文类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxLiteratureTypeId
{
get
{
return mstrzxLiteratureTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxLiteratureTypeId = value;
}
else
{
 mstrzxLiteratureTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Composition.zxLiteratureTypeId);
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
 AddUpdatedFld(conzx_Composition.BrowseNumber);
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
 AddUpdatedFld(conzx_Composition.IsSubmit);
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
 AddUpdatedFld(conzx_Composition.AppraiseCount);
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
 AddUpdatedFld(conzx_Composition.AttachmentCount);
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
 AddUpdatedFld(conzx_Composition.CollectionCount);
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
 AddUpdatedFld(conzx_Composition.DownloadCount);
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
 AddUpdatedFld(conzx_Composition.OkCount);
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
 AddUpdatedFld(conzx_Composition.Pcount);
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
 AddUpdatedFld(conzx_Composition.Score);
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
 AddUpdatedFld(conzx_Composition.StuScore);
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
 AddUpdatedFld(conzx_Composition.TeaScore);
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
 AddUpdatedFld(conzx_Composition.IdCurrEduCls);
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
 AddUpdatedFld(conzx_Composition.PaperTypeId);
}
}
/// <summary>
/// 论文状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxPaperStatusId
{
get
{
return mstrzxPaperStatusId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxPaperStatusId = value;
}
else
{
 mstrzxPaperStatusId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Composition.zxPaperStatusId);
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
 AddUpdatedFld(conzx_Composition.VersionCount);
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
 AddUpdatedFld(conzx_Composition.IsPublic);
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
 AddUpdatedFld(conzx_Composition.AskQuestion);
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
 AddUpdatedFld(conzx_Composition.ResearchStatus);
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
 AddUpdatedFld(conzx_Composition.InnovationPoints);
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
 AddUpdatedFld(conzx_Composition.ResearchDesign);
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
 AddUpdatedFld(conzx_Composition.DimensionDataProcess);
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
 AddUpdatedFld(conzx_Composition.ExpectedConclusion);
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
 AddUpdatedFld(conzx_Composition.CreateDate);
}
}
/// <summary>
/// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxShareId
{
get
{
return mstrzxShareId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxShareId = value;
}
else
{
 mstrzxShareId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Composition.zxShareId);
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
 AddUpdatedFld(conzx_Composition.UpdUser);
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
 AddUpdatedFld(conzx_Composition.PaperQCount);
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
 AddUpdatedFld(conzx_Composition.SubVCount);
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
 AddUpdatedFld(conzx_Composition.TagsCount);
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
 AddUpdatedFld(conzx_Composition.TeaQCount);
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
 AddUpdatedFld(conzx_Composition.GroupTextId);
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
  return mstrzxPaperId;
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
  return mstrPaperName;
 }
 }
}
 /// <summary>
 /// 作文表(zx_Composition)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_Composition
{
public const string _CurrTabName = "zx_Composition"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxPaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxPaperId", "PaperTitle", "PaperName", "PaperContent", "Periodical", "Author", "ResearchQuestion", "UpdDate", "Memo", "Keyword", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "IsQuotethesis", "QuoteId", "IsChecked", "Checker", "zxLiteratureTypeId", "BrowseNumber", "IsSubmit", "AppraiseCount", "AttachmentCount", "CollectionCount", "DownloadCount", "OkCount", "Pcount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PaperTypeId", "zxPaperStatusId", "VersionCount", "IsPublic", "AskQuestion", "ResearchStatus", "InnovationPoints", "ResearchDesign", "DimensionDataProcess", "ExpectedConclusion", "CreateDate", "zxShareId", "UpdUser", "PaperQCount", "SubVCount", "TagsCount", "TeaQCount", "GroupTextId"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxPaperId = "zxPaperId";    //论文Id

 /// <summary>
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"PaperName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperName = "PaperName";    //主题名称

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
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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
 /// 常量:"zxLiteratureTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxLiteratureTypeId = "zxLiteratureTypeId";    //作文类型Id

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
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"PaperTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTypeId = "PaperTypeId";    //论文类型Id

 /// <summary>
 /// 常量:"zxPaperStatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxPaperStatusId = "zxPaperStatusId";    //论文状态Id

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
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"zxShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxShareId = "zxShareId";    //分享Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

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
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id
}

}