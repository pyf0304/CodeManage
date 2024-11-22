
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_CompositionEN
 表名:vzx_Composition(01120765)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// 表vzx_Composition的关键字(zxPaperId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxPaperId_vzx_Composition
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
public K_zxPaperId_vzx_Composition(string strzxPaperId)
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
 /// <returns>返回:[K_zxPaperId_vzx_Composition]类型的对象</returns>
public static implicit operator K_zxPaperId_vzx_Composition(string value)
{
return new K_zxPaperId_vzx_Composition(value);
}
}
 /// <summary>
 /// vzx_Composition(vzx_Composition)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_CompositionEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_Composition"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxPaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 51;
public static string[] AttributeName = new string[] {"zxPaperId", "LiteratureTypeName", "CurrEduClsId", "EduClsName", "GroupTextId", "TeaQCount", "TagsCount", "SubVCount", "PaperQCount", "zxShareId", "CreateDate", "ExpectedConclusion", "DimensionDataProcess", "InnovationPoints", "ResearchStatus", "IsPublic", "UpdUser", "ResearchDesign", "VersionCount", "AskQuestion", "zxPaperStatusId", "PaperTypeId", "IdCurrEduCls", "TeaScore", "StuScore", "Score", "Pcount", "OkCount", "DownloadCount", "CollectionCount", "AttachmentCount", "AppraiseCount", "IsSubmit", "BrowseNumber", "zxLiteratureTypeId", "Checker", "PaperTitle", "PaperName", "PaperContent", "Periodical", "Author", "ResearchQuestion", "UpdDate", "Memo", "Keyword", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "IsQuotethesis", "QuoteId", "IsChecked"};

protected string mstrzxPaperId;    //论文Id
protected string mstrLiteratureTypeName;    //作文类型名
protected string mstrCurrEduClsId;    //教学班Id
protected string mstrEduClsName;    //教学班名
protected string mstrGroupTextId;    //小组Id
protected int? mintTeaQCount;    //教师提问数
protected int? mintTagsCount;    //论文标注数
protected int? mintSubVCount;    //论文子观点数
protected int? mintPaperQCount;    //论文答疑数
protected string mstrzxShareId;    //分享Id
protected string mstrCreateDate;    //建立日期
protected string mstrExpectedConclusion;    //预期结论
protected string mstrDimensionDataProcess;    //数据处理的维度
protected string mstrInnovationPoints;    //创新点
protected string mstrResearchStatus;    //目前研究的现状
protected bool mbolIsPublic;    //是否公开
protected string mstrUpdUser;    //修改人
protected string mstrResearchDesign;    //研究设计
protected int? mintVersionCount;    //版本统计
protected string mstrAskQuestion;    //问题提出
protected string mstrzxPaperStatusId;    //论文状态Id
protected string mstrPaperTypeId;    //论文类型Id
protected string mstrIdCurrEduCls;    //教学班流水号
protected float? mfltTeaScore;    //教师评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltScore;    //评分
protected int? mintPcount;    //读写数
protected int? mintOkCount;    //点赞统计
protected int? mintDownloadCount;    //下载数
protected long? mlngCollectionCount;    //收藏数量
protected int? mintAttachmentCount;    //附件计数
protected int? mintAppraiseCount;    //评论数
protected bool mbolIsSubmit;    //是否提交
protected int? mintBrowseNumber;    //浏览量
protected string mstrzxLiteratureTypeId;    //作文类型Id
protected string mstrChecker;    //审核人
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

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_CompositionEN()
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
public clsvzx_CompositionEN(string strzxPaperId)
 {
strzxPaperId = strzxPaperId.Replace("'", "''");
if (strzxPaperId.Length > 8)
{
throw new Exception("在表:vzx_Composition中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxPaperId)  ==  true)
{
throw new Exception("在表:vzx_Composition中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convzx_Composition.zxPaperId)
{
return mstrzxPaperId;
}
else if (strAttributeName  ==  convzx_Composition.LiteratureTypeName)
{
return mstrLiteratureTypeName;
}
else if (strAttributeName  ==  convzx_Composition.CurrEduClsId)
{
return mstrCurrEduClsId;
}
else if (strAttributeName  ==  convzx_Composition.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  convzx_Composition.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  convzx_Composition.TeaQCount)
{
return mintTeaQCount;
}
else if (strAttributeName  ==  convzx_Composition.TagsCount)
{
return mintTagsCount;
}
else if (strAttributeName  ==  convzx_Composition.SubVCount)
{
return mintSubVCount;
}
else if (strAttributeName  ==  convzx_Composition.PaperQCount)
{
return mintPaperQCount;
}
else if (strAttributeName  ==  convzx_Composition.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  convzx_Composition.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convzx_Composition.ExpectedConclusion)
{
return mstrExpectedConclusion;
}
else if (strAttributeName  ==  convzx_Composition.DimensionDataProcess)
{
return mstrDimensionDataProcess;
}
else if (strAttributeName  ==  convzx_Composition.InnovationPoints)
{
return mstrInnovationPoints;
}
else if (strAttributeName  ==  convzx_Composition.ResearchStatus)
{
return mstrResearchStatus;
}
else if (strAttributeName  ==  convzx_Composition.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convzx_Composition.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_Composition.ResearchDesign)
{
return mstrResearchDesign;
}
else if (strAttributeName  ==  convzx_Composition.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convzx_Composition.AskQuestion)
{
return mstrAskQuestion;
}
else if (strAttributeName  ==  convzx_Composition.zxPaperStatusId)
{
return mstrzxPaperStatusId;
}
else if (strAttributeName  ==  convzx_Composition.PaperTypeId)
{
return mstrPaperTypeId;
}
else if (strAttributeName  ==  convzx_Composition.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convzx_Composition.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convzx_Composition.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convzx_Composition.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convzx_Composition.Pcount)
{
return mintPcount;
}
else if (strAttributeName  ==  convzx_Composition.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convzx_Composition.DownloadCount)
{
return mintDownloadCount;
}
else if (strAttributeName  ==  convzx_Composition.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convzx_Composition.AttachmentCount)
{
return mintAttachmentCount;
}
else if (strAttributeName  ==  convzx_Composition.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convzx_Composition.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convzx_Composition.BrowseNumber)
{
return mintBrowseNumber;
}
else if (strAttributeName  ==  convzx_Composition.zxLiteratureTypeId)
{
return mstrzxLiteratureTypeId;
}
else if (strAttributeName  ==  convzx_Composition.Checker)
{
return mstrChecker;
}
else if (strAttributeName  ==  convzx_Composition.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convzx_Composition.PaperName)
{
return mstrPaperName;
}
else if (strAttributeName  ==  convzx_Composition.PaperContent)
{
return mstrPaperContent;
}
else if (strAttributeName  ==  convzx_Composition.Periodical)
{
return mstrPeriodical;
}
else if (strAttributeName  ==  convzx_Composition.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convzx_Composition.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  convzx_Composition.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_Composition.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_Composition.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convzx_Composition.LiteratureSources)
{
return mstrLiteratureSources;
}
else if (strAttributeName  ==  convzx_Composition.LiteratureLink)
{
return mstrLiteratureLink;
}
else if (strAttributeName  ==  convzx_Composition.UploadfileUrl)
{
return mstrUploadfileUrl;
}
else if (strAttributeName  ==  convzx_Composition.IsQuotethesis)
{
return mbolIsQuotethesis;
}
else if (strAttributeName  ==  convzx_Composition.QuoteId)
{
return mstrQuoteId;
}
else if (strAttributeName  ==  convzx_Composition.IsChecked)
{
return mbolIsChecked;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_Composition.zxPaperId)
{
mstrzxPaperId = value.ToString();
 AddUpdatedFld(convzx_Composition.zxPaperId);
}
else if (strAttributeName  ==  convzx_Composition.LiteratureTypeName)
{
mstrLiteratureTypeName = value.ToString();
 AddUpdatedFld(convzx_Composition.LiteratureTypeName);
}
else if (strAttributeName  ==  convzx_Composition.CurrEduClsId)
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convzx_Composition.CurrEduClsId);
}
else if (strAttributeName  ==  convzx_Composition.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convzx_Composition.EduClsName);
}
else if (strAttributeName  ==  convzx_Composition.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_Composition.GroupTextId);
}
else if (strAttributeName  ==  convzx_Composition.TeaQCount)
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.TeaQCount);
}
else if (strAttributeName  ==  convzx_Composition.TagsCount)
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.TagsCount);
}
else if (strAttributeName  ==  convzx_Composition.SubVCount)
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.SubVCount);
}
else if (strAttributeName  ==  convzx_Composition.PaperQCount)
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.PaperQCount);
}
else if (strAttributeName  ==  convzx_Composition.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_Composition.zxShareId);
}
else if (strAttributeName  ==  convzx_Composition.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_Composition.CreateDate);
}
else if (strAttributeName  ==  convzx_Composition.ExpectedConclusion)
{
mstrExpectedConclusion = value.ToString();
 AddUpdatedFld(convzx_Composition.ExpectedConclusion);
}
else if (strAttributeName  ==  convzx_Composition.DimensionDataProcess)
{
mstrDimensionDataProcess = value.ToString();
 AddUpdatedFld(convzx_Composition.DimensionDataProcess);
}
else if (strAttributeName  ==  convzx_Composition.InnovationPoints)
{
mstrInnovationPoints = value.ToString();
 AddUpdatedFld(convzx_Composition.InnovationPoints);
}
else if (strAttributeName  ==  convzx_Composition.ResearchStatus)
{
mstrResearchStatus = value.ToString();
 AddUpdatedFld(convzx_Composition.ResearchStatus);
}
else if (strAttributeName  ==  convzx_Composition.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Composition.IsPublic);
}
else if (strAttributeName  ==  convzx_Composition.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_Composition.UpdUser);
}
else if (strAttributeName  ==  convzx_Composition.ResearchDesign)
{
mstrResearchDesign = value.ToString();
 AddUpdatedFld(convzx_Composition.ResearchDesign);
}
else if (strAttributeName  ==  convzx_Composition.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.VersionCount);
}
else if (strAttributeName  ==  convzx_Composition.AskQuestion)
{
mstrAskQuestion = value.ToString();
 AddUpdatedFld(convzx_Composition.AskQuestion);
}
else if (strAttributeName  ==  convzx_Composition.zxPaperStatusId)
{
mstrzxPaperStatusId = value.ToString();
 AddUpdatedFld(convzx_Composition.zxPaperStatusId);
}
else if (strAttributeName  ==  convzx_Composition.PaperTypeId)
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convzx_Composition.PaperTypeId);
}
else if (strAttributeName  ==  convzx_Composition.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_Composition.IdCurrEduCls);
}
else if (strAttributeName  ==  convzx_Composition.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Composition.TeaScore);
}
else if (strAttributeName  ==  convzx_Composition.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Composition.StuScore);
}
else if (strAttributeName  ==  convzx_Composition.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Composition.Score);
}
else if (strAttributeName  ==  convzx_Composition.Pcount)
{
mintPcount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.Pcount);
}
else if (strAttributeName  ==  convzx_Composition.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.OkCount);
}
else if (strAttributeName  ==  convzx_Composition.DownloadCount)
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.DownloadCount);
}
else if (strAttributeName  ==  convzx_Composition.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.CollectionCount);
}
else if (strAttributeName  ==  convzx_Composition.AttachmentCount)
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.AttachmentCount);
}
else if (strAttributeName  ==  convzx_Composition.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.AppraiseCount);
}
else if (strAttributeName  ==  convzx_Composition.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Composition.IsSubmit);
}
else if (strAttributeName  ==  convzx_Composition.BrowseNumber)
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.BrowseNumber);
}
else if (strAttributeName  ==  convzx_Composition.zxLiteratureTypeId)
{
mstrzxLiteratureTypeId = value.ToString();
 AddUpdatedFld(convzx_Composition.zxLiteratureTypeId);
}
else if (strAttributeName  ==  convzx_Composition.Checker)
{
mstrChecker = value.ToString();
 AddUpdatedFld(convzx_Composition.Checker);
}
else if (strAttributeName  ==  convzx_Composition.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convzx_Composition.PaperTitle);
}
else if (strAttributeName  ==  convzx_Composition.PaperName)
{
mstrPaperName = value.ToString();
 AddUpdatedFld(convzx_Composition.PaperName);
}
else if (strAttributeName  ==  convzx_Composition.PaperContent)
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convzx_Composition.PaperContent);
}
else if (strAttributeName  ==  convzx_Composition.Periodical)
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convzx_Composition.Periodical);
}
else if (strAttributeName  ==  convzx_Composition.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convzx_Composition.Author);
}
else if (strAttributeName  ==  convzx_Composition.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convzx_Composition.ResearchQuestion);
}
else if (strAttributeName  ==  convzx_Composition.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_Composition.UpdDate);
}
else if (strAttributeName  ==  convzx_Composition.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_Composition.Memo);
}
else if (strAttributeName  ==  convzx_Composition.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convzx_Composition.Keyword);
}
else if (strAttributeName  ==  convzx_Composition.LiteratureSources)
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convzx_Composition.LiteratureSources);
}
else if (strAttributeName  ==  convzx_Composition.LiteratureLink)
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convzx_Composition.LiteratureLink);
}
else if (strAttributeName  ==  convzx_Composition.UploadfileUrl)
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convzx_Composition.UploadfileUrl);
}
else if (strAttributeName  ==  convzx_Composition.IsQuotethesis)
{
mbolIsQuotethesis = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Composition.IsQuotethesis);
}
else if (strAttributeName  ==  convzx_Composition.QuoteId)
{
mstrQuoteId = value.ToString();
 AddUpdatedFld(convzx_Composition.QuoteId);
}
else if (strAttributeName  ==  convzx_Composition.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Composition.IsChecked);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_Composition.zxPaperId  ==  AttributeName[intIndex])
{
return mstrzxPaperId;
}
else if (convzx_Composition.LiteratureTypeName  ==  AttributeName[intIndex])
{
return mstrLiteratureTypeName;
}
else if (convzx_Composition.CurrEduClsId  ==  AttributeName[intIndex])
{
return mstrCurrEduClsId;
}
else if (convzx_Composition.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (convzx_Composition.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (convzx_Composition.TeaQCount  ==  AttributeName[intIndex])
{
return mintTeaQCount;
}
else if (convzx_Composition.TagsCount  ==  AttributeName[intIndex])
{
return mintTagsCount;
}
else if (convzx_Composition.SubVCount  ==  AttributeName[intIndex])
{
return mintSubVCount;
}
else if (convzx_Composition.PaperQCount  ==  AttributeName[intIndex])
{
return mintPaperQCount;
}
else if (convzx_Composition.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (convzx_Composition.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convzx_Composition.ExpectedConclusion  ==  AttributeName[intIndex])
{
return mstrExpectedConclusion;
}
else if (convzx_Composition.DimensionDataProcess  ==  AttributeName[intIndex])
{
return mstrDimensionDataProcess;
}
else if (convzx_Composition.InnovationPoints  ==  AttributeName[intIndex])
{
return mstrInnovationPoints;
}
else if (convzx_Composition.ResearchStatus  ==  AttributeName[intIndex])
{
return mstrResearchStatus;
}
else if (convzx_Composition.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convzx_Composition.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_Composition.ResearchDesign  ==  AttributeName[intIndex])
{
return mstrResearchDesign;
}
else if (convzx_Composition.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convzx_Composition.AskQuestion  ==  AttributeName[intIndex])
{
return mstrAskQuestion;
}
else if (convzx_Composition.zxPaperStatusId  ==  AttributeName[intIndex])
{
return mstrzxPaperStatusId;
}
else if (convzx_Composition.PaperTypeId  ==  AttributeName[intIndex])
{
return mstrPaperTypeId;
}
else if (convzx_Composition.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convzx_Composition.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convzx_Composition.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convzx_Composition.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convzx_Composition.Pcount  ==  AttributeName[intIndex])
{
return mintPcount;
}
else if (convzx_Composition.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convzx_Composition.DownloadCount  ==  AttributeName[intIndex])
{
return mintDownloadCount;
}
else if (convzx_Composition.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convzx_Composition.AttachmentCount  ==  AttributeName[intIndex])
{
return mintAttachmentCount;
}
else if (convzx_Composition.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convzx_Composition.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convzx_Composition.BrowseNumber  ==  AttributeName[intIndex])
{
return mintBrowseNumber;
}
else if (convzx_Composition.zxLiteratureTypeId  ==  AttributeName[intIndex])
{
return mstrzxLiteratureTypeId;
}
else if (convzx_Composition.Checker  ==  AttributeName[intIndex])
{
return mstrChecker;
}
else if (convzx_Composition.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convzx_Composition.PaperName  ==  AttributeName[intIndex])
{
return mstrPaperName;
}
else if (convzx_Composition.PaperContent  ==  AttributeName[intIndex])
{
return mstrPaperContent;
}
else if (convzx_Composition.Periodical  ==  AttributeName[intIndex])
{
return mstrPeriodical;
}
else if (convzx_Composition.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convzx_Composition.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (convzx_Composition.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_Composition.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_Composition.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convzx_Composition.LiteratureSources  ==  AttributeName[intIndex])
{
return mstrLiteratureSources;
}
else if (convzx_Composition.LiteratureLink  ==  AttributeName[intIndex])
{
return mstrLiteratureLink;
}
else if (convzx_Composition.UploadfileUrl  ==  AttributeName[intIndex])
{
return mstrUploadfileUrl;
}
else if (convzx_Composition.IsQuotethesis  ==  AttributeName[intIndex])
{
return mbolIsQuotethesis;
}
else if (convzx_Composition.QuoteId  ==  AttributeName[intIndex])
{
return mstrQuoteId;
}
else if (convzx_Composition.IsChecked  ==  AttributeName[intIndex])
{
return mbolIsChecked;
}
return null;
}
set
{
if (convzx_Composition.zxPaperId  ==  AttributeName[intIndex])
{
mstrzxPaperId = value.ToString();
 AddUpdatedFld(convzx_Composition.zxPaperId);
}
else if (convzx_Composition.LiteratureTypeName  ==  AttributeName[intIndex])
{
mstrLiteratureTypeName = value.ToString();
 AddUpdatedFld(convzx_Composition.LiteratureTypeName);
}
else if (convzx_Composition.CurrEduClsId  ==  AttributeName[intIndex])
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convzx_Composition.CurrEduClsId);
}
else if (convzx_Composition.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convzx_Composition.EduClsName);
}
else if (convzx_Composition.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_Composition.GroupTextId);
}
else if (convzx_Composition.TeaQCount  ==  AttributeName[intIndex])
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.TeaQCount);
}
else if (convzx_Composition.TagsCount  ==  AttributeName[intIndex])
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.TagsCount);
}
else if (convzx_Composition.SubVCount  ==  AttributeName[intIndex])
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.SubVCount);
}
else if (convzx_Composition.PaperQCount  ==  AttributeName[intIndex])
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.PaperQCount);
}
else if (convzx_Composition.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_Composition.zxShareId);
}
else if (convzx_Composition.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_Composition.CreateDate);
}
else if (convzx_Composition.ExpectedConclusion  ==  AttributeName[intIndex])
{
mstrExpectedConclusion = value.ToString();
 AddUpdatedFld(convzx_Composition.ExpectedConclusion);
}
else if (convzx_Composition.DimensionDataProcess  ==  AttributeName[intIndex])
{
mstrDimensionDataProcess = value.ToString();
 AddUpdatedFld(convzx_Composition.DimensionDataProcess);
}
else if (convzx_Composition.InnovationPoints  ==  AttributeName[intIndex])
{
mstrInnovationPoints = value.ToString();
 AddUpdatedFld(convzx_Composition.InnovationPoints);
}
else if (convzx_Composition.ResearchStatus  ==  AttributeName[intIndex])
{
mstrResearchStatus = value.ToString();
 AddUpdatedFld(convzx_Composition.ResearchStatus);
}
else if (convzx_Composition.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Composition.IsPublic);
}
else if (convzx_Composition.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_Composition.UpdUser);
}
else if (convzx_Composition.ResearchDesign  ==  AttributeName[intIndex])
{
mstrResearchDesign = value.ToString();
 AddUpdatedFld(convzx_Composition.ResearchDesign);
}
else if (convzx_Composition.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.VersionCount);
}
else if (convzx_Composition.AskQuestion  ==  AttributeName[intIndex])
{
mstrAskQuestion = value.ToString();
 AddUpdatedFld(convzx_Composition.AskQuestion);
}
else if (convzx_Composition.zxPaperStatusId  ==  AttributeName[intIndex])
{
mstrzxPaperStatusId = value.ToString();
 AddUpdatedFld(convzx_Composition.zxPaperStatusId);
}
else if (convzx_Composition.PaperTypeId  ==  AttributeName[intIndex])
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convzx_Composition.PaperTypeId);
}
else if (convzx_Composition.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_Composition.IdCurrEduCls);
}
else if (convzx_Composition.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Composition.TeaScore);
}
else if (convzx_Composition.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Composition.StuScore);
}
else if (convzx_Composition.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_Composition.Score);
}
else if (convzx_Composition.Pcount  ==  AttributeName[intIndex])
{
mintPcount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.Pcount);
}
else if (convzx_Composition.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.OkCount);
}
else if (convzx_Composition.DownloadCount  ==  AttributeName[intIndex])
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.DownloadCount);
}
else if (convzx_Composition.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.CollectionCount);
}
else if (convzx_Composition.AttachmentCount  ==  AttributeName[intIndex])
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.AttachmentCount);
}
else if (convzx_Composition.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.AppraiseCount);
}
else if (convzx_Composition.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Composition.IsSubmit);
}
else if (convzx_Composition.BrowseNumber  ==  AttributeName[intIndex])
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Composition.BrowseNumber);
}
else if (convzx_Composition.zxLiteratureTypeId  ==  AttributeName[intIndex])
{
mstrzxLiteratureTypeId = value.ToString();
 AddUpdatedFld(convzx_Composition.zxLiteratureTypeId);
}
else if (convzx_Composition.Checker  ==  AttributeName[intIndex])
{
mstrChecker = value.ToString();
 AddUpdatedFld(convzx_Composition.Checker);
}
else if (convzx_Composition.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convzx_Composition.PaperTitle);
}
else if (convzx_Composition.PaperName  ==  AttributeName[intIndex])
{
mstrPaperName = value.ToString();
 AddUpdatedFld(convzx_Composition.PaperName);
}
else if (convzx_Composition.PaperContent  ==  AttributeName[intIndex])
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convzx_Composition.PaperContent);
}
else if (convzx_Composition.Periodical  ==  AttributeName[intIndex])
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convzx_Composition.Periodical);
}
else if (convzx_Composition.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convzx_Composition.Author);
}
else if (convzx_Composition.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convzx_Composition.ResearchQuestion);
}
else if (convzx_Composition.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_Composition.UpdDate);
}
else if (convzx_Composition.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_Composition.Memo);
}
else if (convzx_Composition.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convzx_Composition.Keyword);
}
else if (convzx_Composition.LiteratureSources  ==  AttributeName[intIndex])
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convzx_Composition.LiteratureSources);
}
else if (convzx_Composition.LiteratureLink  ==  AttributeName[intIndex])
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convzx_Composition.LiteratureLink);
}
else if (convzx_Composition.UploadfileUrl  ==  AttributeName[intIndex])
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convzx_Composition.UploadfileUrl);
}
else if (convzx_Composition.IsQuotethesis  ==  AttributeName[intIndex])
{
mbolIsQuotethesis = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Composition.IsQuotethesis);
}
else if (convzx_Composition.QuoteId  ==  AttributeName[intIndex])
{
mstrQuoteId = value.ToString();
 AddUpdatedFld(convzx_Composition.QuoteId);
}
else if (convzx_Composition.IsChecked  ==  AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_Composition.IsChecked);
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
 AddUpdatedFld(convzx_Composition.zxPaperId);
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
 AddUpdatedFld(convzx_Composition.LiteratureTypeName);
}
}
/// <summary>
/// 教学班Id(说明:;字段类型:varchar;字段长度:15;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CurrEduClsId
{
get
{
return mstrCurrEduClsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCurrEduClsId = value;
}
else
{
 mstrCurrEduClsId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Composition.CurrEduClsId);
}
}
/// <summary>
/// 教学班名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsName
{
get
{
return mstrEduClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsName = value;
}
else
{
 mstrEduClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Composition.EduClsName);
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
 AddUpdatedFld(convzx_Composition.GroupTextId);
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
 AddUpdatedFld(convzx_Composition.TeaQCount);
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
 AddUpdatedFld(convzx_Composition.TagsCount);
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
 AddUpdatedFld(convzx_Composition.SubVCount);
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
 AddUpdatedFld(convzx_Composition.PaperQCount);
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
 AddUpdatedFld(convzx_Composition.zxShareId);
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
 AddUpdatedFld(convzx_Composition.CreateDate);
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
 AddUpdatedFld(convzx_Composition.ExpectedConclusion);
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
 AddUpdatedFld(convzx_Composition.DimensionDataProcess);
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
 AddUpdatedFld(convzx_Composition.InnovationPoints);
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
 AddUpdatedFld(convzx_Composition.ResearchStatus);
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
 AddUpdatedFld(convzx_Composition.IsPublic);
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
 AddUpdatedFld(convzx_Composition.UpdUser);
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
 AddUpdatedFld(convzx_Composition.ResearchDesign);
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
 AddUpdatedFld(convzx_Composition.VersionCount);
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
 AddUpdatedFld(convzx_Composition.AskQuestion);
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
 AddUpdatedFld(convzx_Composition.zxPaperStatusId);
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
 AddUpdatedFld(convzx_Composition.PaperTypeId);
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
 AddUpdatedFld(convzx_Composition.IdCurrEduCls);
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
 AddUpdatedFld(convzx_Composition.TeaScore);
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
 AddUpdatedFld(convzx_Composition.StuScore);
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
 AddUpdatedFld(convzx_Composition.Score);
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
 AddUpdatedFld(convzx_Composition.Pcount);
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
 AddUpdatedFld(convzx_Composition.OkCount);
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
 AddUpdatedFld(convzx_Composition.DownloadCount);
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
 AddUpdatedFld(convzx_Composition.CollectionCount);
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
 AddUpdatedFld(convzx_Composition.AttachmentCount);
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
 AddUpdatedFld(convzx_Composition.AppraiseCount);
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
 AddUpdatedFld(convzx_Composition.IsSubmit);
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
 AddUpdatedFld(convzx_Composition.BrowseNumber);
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
 AddUpdatedFld(convzx_Composition.zxLiteratureTypeId);
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
 AddUpdatedFld(convzx_Composition.Checker);
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
 AddUpdatedFld(convzx_Composition.PaperTitle);
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
 AddUpdatedFld(convzx_Composition.PaperName);
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
 AddUpdatedFld(convzx_Composition.PaperContent);
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
 AddUpdatedFld(convzx_Composition.Periodical);
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
 AddUpdatedFld(convzx_Composition.Author);
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
 AddUpdatedFld(convzx_Composition.ResearchQuestion);
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
 AddUpdatedFld(convzx_Composition.UpdDate);
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
 AddUpdatedFld(convzx_Composition.Memo);
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
 AddUpdatedFld(convzx_Composition.Keyword);
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
 AddUpdatedFld(convzx_Composition.LiteratureSources);
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
 AddUpdatedFld(convzx_Composition.LiteratureLink);
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
 AddUpdatedFld(convzx_Composition.UploadfileUrl);
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
 AddUpdatedFld(convzx_Composition.IsQuotethesis);
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
 AddUpdatedFld(convzx_Composition.QuoteId);
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
 AddUpdatedFld(convzx_Composition.IsChecked);
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
}
 /// <summary>
 /// vzx_Composition(vzx_Composition)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_Composition
{
public const string _CurrTabName = "vzx_Composition"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxPaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxPaperId", "LiteratureTypeName", "CurrEduClsId", "EduClsName", "GroupTextId", "TeaQCount", "TagsCount", "SubVCount", "PaperQCount", "zxShareId", "CreateDate", "ExpectedConclusion", "DimensionDataProcess", "InnovationPoints", "ResearchStatus", "IsPublic", "UpdUser", "ResearchDesign", "VersionCount", "AskQuestion", "zxPaperStatusId", "PaperTypeId", "IdCurrEduCls", "TeaScore", "StuScore", "Score", "Pcount", "OkCount", "DownloadCount", "CollectionCount", "AttachmentCount", "AppraiseCount", "IsSubmit", "BrowseNumber", "zxLiteratureTypeId", "Checker", "PaperTitle", "PaperName", "PaperContent", "Periodical", "Author", "ResearchQuestion", "UpdDate", "Memo", "Keyword", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "IsQuotethesis", "QuoteId", "IsChecked"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxPaperId = "zxPaperId";    //论文Id

 /// <summary>
 /// 常量:"LiteratureTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureTypeName = "LiteratureTypeName";    //作文类型名

 /// <summary>
 /// 常量:"CurrEduClsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrEduClsId = "CurrEduClsId";    //教学班Id

 /// <summary>
 /// 常量:"EduClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsName = "EduClsName";    //教学班名

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

 /// <summary>
 /// 常量:"TeaQCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaQCount = "TeaQCount";    //教师提问数

 /// <summary>
 /// 常量:"TagsCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TagsCount = "TagsCount";    //论文标注数

 /// <summary>
 /// 常量:"SubVCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubVCount = "SubVCount";    //论文子观点数

 /// <summary>
 /// 常量:"PaperQCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperQCount = "PaperQCount";    //论文答疑数

 /// <summary>
 /// 常量:"zxShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxShareId = "zxShareId";    //分享Id

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"ExpectedConclusion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExpectedConclusion = "ExpectedConclusion";    //预期结论

 /// <summary>
 /// 常量:"DimensionDataProcess"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DimensionDataProcess = "DimensionDataProcess";    //数据处理的维度

 /// <summary>
 /// 常量:"InnovationPoints"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InnovationPoints = "InnovationPoints";    //创新点

 /// <summary>
 /// 常量:"ResearchStatus"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResearchStatus = "ResearchStatus";    //目前研究的现状

 /// <summary>
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"ResearchDesign"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResearchDesign = "ResearchDesign";    //研究设计

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"AskQuestion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AskQuestion = "AskQuestion";    //问题提出

 /// <summary>
 /// 常量:"zxPaperStatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxPaperStatusId = "zxPaperStatusId";    //论文状态Id

 /// <summary>
 /// 常量:"PaperTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTypeId = "PaperTypeId";    //论文类型Id

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

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
 /// 常量:"Pcount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Pcount = "Pcount";    //读写数

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"DownloadCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DownloadCount = "DownloadCount";    //下载数

 /// <summary>
 /// 常量:"CollectionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollectionCount = "CollectionCount";    //收藏数量

 /// <summary>
 /// 常量:"AttachmentCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttachmentCount = "AttachmentCount";    //附件计数

 /// <summary>
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"BrowseNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseNumber = "BrowseNumber";    //浏览量

 /// <summary>
 /// 常量:"zxLiteratureTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxLiteratureTypeId = "zxLiteratureTypeId";    //作文类型Id

 /// <summary>
 /// 常量:"Checker"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Checker = "Checker";    //审核人

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
}

}