
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSimEN
 表名:vPaperSim(01120597)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:25
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
 /// 表vPaperSim的关键字(PaperId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperId_vPaperSim
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
public K_PaperId_vPaperSim(string strPaperId)
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
 /// <returns>返回:[K_PaperId_vPaperSim]类型的对象</returns>
public static implicit operator K_PaperId_vPaperSim(string value)
{
return new K_PaperId_vPaperSim(value);
}
}
 /// <summary>
 /// 论文简化视图(vPaperSim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPaperSimEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPaperSim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 39;
public static string[] AttributeName = new string[] {"PaperId", "PaperTitle", "PaperContent", "Periodical", "Author", "ResearchQuestion", "UpdDate", "UserName", "IdXzCollege", "CollegeName", "IdXzMajor", "MajorName", "Keyword", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "IsQuotethesis", "QuoteId", "Checker", "IsChecked", "LiteratureTypeId", "BrowseNumber", "LiteratureTypeName", "IsSubmit", "AppraiseCount", "AttachmentCount", "CollectionCount", "DownloadCount", "Memo", "OkCount", "Pcount", "Score", "StuScore", "TeaScore", "PaperQCount", "SubVCount", "TagsCount", "TeaQCount", "UpdUser"};

protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected string mstrPaperContent;    //主题内容
protected string mstrPeriodical;    //期刊
protected string mstrAuthor;    //作者
protected string mstrResearchQuestion;    //研究问题
protected string mstrUpdDate;    //修改日期
protected string mstrUserName;    //用户名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeName;    //学院名称
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrKeyword;    //关键字
protected string mstrLiteratureSources;    //文献来源
protected string mstrLiteratureLink;    //文献链接
protected string mstrUploadfileUrl;    //文件地址
protected bool mbolIsQuotethesis;    //是否引用论文
protected string mstrQuoteId;    //引用Id
protected string mstrChecker;    //审核人
protected bool mbolIsChecked;    //是否检查
protected string mstrLiteratureTypeId;    //作文类型Id
protected int? mintBrowseNumber;    //浏览量
protected string mstrLiteratureTypeName;    //作文类型名
protected bool mbolIsSubmit;    //是否提交
protected int? mintAppraiseCount;    //评论数
protected int? mintAttachmentCount;    //附件计数
protected long? mlngCollectionCount;    //收藏数量
protected int? mintDownloadCount;    //下载数
protected string mstrMemo;    //备注
protected int? mintOkCount;    //点赞统计
protected int? mintPcount;    //读写数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected int? mintPaperQCount;    //论文答疑数
protected int? mintSubVCount;    //论文子观点数
protected int? mintTagsCount;    //论文标注数
protected int? mintTeaQCount;    //教师提问数
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPaperSimEN()
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
public clsvPaperSimEN(string strPaperId)
 {
strPaperId = strPaperId.Replace("'", "''");
if (strPaperId.Length > 8)
{
throw new Exception("在表:vPaperSim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPaperId)  ==  true)
{
throw new Exception("在表:vPaperSim中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convPaperSim.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convPaperSim.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convPaperSim.PaperContent)
{
return mstrPaperContent;
}
else if (strAttributeName  ==  convPaperSim.Periodical)
{
return mstrPeriodical;
}
else if (strAttributeName  ==  convPaperSim.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convPaperSim.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  convPaperSim.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPaperSim.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convPaperSim.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convPaperSim.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convPaperSim.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convPaperSim.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convPaperSim.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convPaperSim.LiteratureSources)
{
return mstrLiteratureSources;
}
else if (strAttributeName  ==  convPaperSim.LiteratureLink)
{
return mstrLiteratureLink;
}
else if (strAttributeName  ==  convPaperSim.UploadfileUrl)
{
return mstrUploadfileUrl;
}
else if (strAttributeName  ==  convPaperSim.IsQuotethesis)
{
return mbolIsQuotethesis;
}
else if (strAttributeName  ==  convPaperSim.QuoteId)
{
return mstrQuoteId;
}
else if (strAttributeName  ==  convPaperSim.Checker)
{
return mstrChecker;
}
else if (strAttributeName  ==  convPaperSim.IsChecked)
{
return mbolIsChecked;
}
else if (strAttributeName  ==  convPaperSim.LiteratureTypeId)
{
return mstrLiteratureTypeId;
}
else if (strAttributeName  ==  convPaperSim.BrowseNumber)
{
return mintBrowseNumber;
}
else if (strAttributeName  ==  convPaperSim.LiteratureTypeName)
{
return mstrLiteratureTypeName;
}
else if (strAttributeName  ==  convPaperSim.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convPaperSim.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convPaperSim.AttachmentCount)
{
return mintAttachmentCount;
}
else if (strAttributeName  ==  convPaperSim.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convPaperSim.DownloadCount)
{
return mintDownloadCount;
}
else if (strAttributeName  ==  convPaperSim.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPaperSim.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convPaperSim.Pcount)
{
return mintPcount;
}
else if (strAttributeName  ==  convPaperSim.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convPaperSim.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convPaperSim.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convPaperSim.PaperQCount)
{
return mintPaperQCount;
}
else if (strAttributeName  ==  convPaperSim.SubVCount)
{
return mintSubVCount;
}
else if (strAttributeName  ==  convPaperSim.TagsCount)
{
return mintTagsCount;
}
else if (strAttributeName  ==  convPaperSim.TeaQCount)
{
return mintTeaQCount;
}
else if (strAttributeName  ==  convPaperSim.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  convPaperSim.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperSim.PaperId);
}
else if (strAttributeName  ==  convPaperSim.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperSim.PaperTitle);
}
else if (strAttributeName  ==  convPaperSim.PaperContent)
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convPaperSim.PaperContent);
}
else if (strAttributeName  ==  convPaperSim.Periodical)
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convPaperSim.Periodical);
}
else if (strAttributeName  ==  convPaperSim.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convPaperSim.Author);
}
else if (strAttributeName  ==  convPaperSim.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convPaperSim.ResearchQuestion);
}
else if (strAttributeName  ==  convPaperSim.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperSim.UpdDate);
}
else if (strAttributeName  ==  convPaperSim.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convPaperSim.UserName);
}
else if (strAttributeName  ==  convPaperSim.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convPaperSim.IdXzCollege);
}
else if (strAttributeName  ==  convPaperSim.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convPaperSim.CollegeName);
}
else if (strAttributeName  ==  convPaperSim.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convPaperSim.IdXzMajor);
}
else if (strAttributeName  ==  convPaperSim.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convPaperSim.MajorName);
}
else if (strAttributeName  ==  convPaperSim.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPaperSim.Keyword);
}
else if (strAttributeName  ==  convPaperSim.LiteratureSources)
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convPaperSim.LiteratureSources);
}
else if (strAttributeName  ==  convPaperSim.LiteratureLink)
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convPaperSim.LiteratureLink);
}
else if (strAttributeName  ==  convPaperSim.UploadfileUrl)
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convPaperSim.UploadfileUrl);
}
else if (strAttributeName  ==  convPaperSim.IsQuotethesis)
{
mbolIsQuotethesis = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaperSim.IsQuotethesis);
}
else if (strAttributeName  ==  convPaperSim.QuoteId)
{
mstrQuoteId = value.ToString();
 AddUpdatedFld(convPaperSim.QuoteId);
}
else if (strAttributeName  ==  convPaperSim.Checker)
{
mstrChecker = value.ToString();
 AddUpdatedFld(convPaperSim.Checker);
}
else if (strAttributeName  ==  convPaperSim.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaperSim.IsChecked);
}
else if (strAttributeName  ==  convPaperSim.LiteratureTypeId)
{
mstrLiteratureTypeId = value.ToString();
 AddUpdatedFld(convPaperSim.LiteratureTypeId);
}
else if (strAttributeName  ==  convPaperSim.BrowseNumber)
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.BrowseNumber);
}
else if (strAttributeName  ==  convPaperSim.LiteratureTypeName)
{
mstrLiteratureTypeName = value.ToString();
 AddUpdatedFld(convPaperSim.LiteratureTypeName);
}
else if (strAttributeName  ==  convPaperSim.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaperSim.IsSubmit);
}
else if (strAttributeName  ==  convPaperSim.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.AppraiseCount);
}
else if (strAttributeName  ==  convPaperSim.AttachmentCount)
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.AttachmentCount);
}
else if (strAttributeName  ==  convPaperSim.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.CollectionCount);
}
else if (strAttributeName  ==  convPaperSim.DownloadCount)
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.DownloadCount);
}
else if (strAttributeName  ==  convPaperSim.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaperSim.Memo);
}
else if (strAttributeName  ==  convPaperSim.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.OkCount);
}
else if (strAttributeName  ==  convPaperSim.Pcount)
{
mintPcount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.Pcount);
}
else if (strAttributeName  ==  convPaperSim.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperSim.Score);
}
else if (strAttributeName  ==  convPaperSim.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperSim.StuScore);
}
else if (strAttributeName  ==  convPaperSim.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperSim.TeaScore);
}
else if (strAttributeName  ==  convPaperSim.PaperQCount)
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.PaperQCount);
}
else if (strAttributeName  ==  convPaperSim.SubVCount)
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.SubVCount);
}
else if (strAttributeName  ==  convPaperSim.TagsCount)
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.TagsCount);
}
else if (strAttributeName  ==  convPaperSim.TeaQCount)
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.TeaQCount);
}
else if (strAttributeName  ==  convPaperSim.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperSim.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (convPaperSim.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convPaperSim.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convPaperSim.PaperContent  ==  AttributeName[intIndex])
{
return mstrPaperContent;
}
else if (convPaperSim.Periodical  ==  AttributeName[intIndex])
{
return mstrPeriodical;
}
else if (convPaperSim.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convPaperSim.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (convPaperSim.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPaperSim.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convPaperSim.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convPaperSim.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convPaperSim.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convPaperSim.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convPaperSim.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convPaperSim.LiteratureSources  ==  AttributeName[intIndex])
{
return mstrLiteratureSources;
}
else if (convPaperSim.LiteratureLink  ==  AttributeName[intIndex])
{
return mstrLiteratureLink;
}
else if (convPaperSim.UploadfileUrl  ==  AttributeName[intIndex])
{
return mstrUploadfileUrl;
}
else if (convPaperSim.IsQuotethesis  ==  AttributeName[intIndex])
{
return mbolIsQuotethesis;
}
else if (convPaperSim.QuoteId  ==  AttributeName[intIndex])
{
return mstrQuoteId;
}
else if (convPaperSim.Checker  ==  AttributeName[intIndex])
{
return mstrChecker;
}
else if (convPaperSim.IsChecked  ==  AttributeName[intIndex])
{
return mbolIsChecked;
}
else if (convPaperSim.LiteratureTypeId  ==  AttributeName[intIndex])
{
return mstrLiteratureTypeId;
}
else if (convPaperSim.BrowseNumber  ==  AttributeName[intIndex])
{
return mintBrowseNumber;
}
else if (convPaperSim.LiteratureTypeName  ==  AttributeName[intIndex])
{
return mstrLiteratureTypeName;
}
else if (convPaperSim.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convPaperSim.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convPaperSim.AttachmentCount  ==  AttributeName[intIndex])
{
return mintAttachmentCount;
}
else if (convPaperSim.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convPaperSim.DownloadCount  ==  AttributeName[intIndex])
{
return mintDownloadCount;
}
else if (convPaperSim.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPaperSim.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convPaperSim.Pcount  ==  AttributeName[intIndex])
{
return mintPcount;
}
else if (convPaperSim.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convPaperSim.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convPaperSim.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convPaperSim.PaperQCount  ==  AttributeName[intIndex])
{
return mintPaperQCount;
}
else if (convPaperSim.SubVCount  ==  AttributeName[intIndex])
{
return mintSubVCount;
}
else if (convPaperSim.TagsCount  ==  AttributeName[intIndex])
{
return mintTagsCount;
}
else if (convPaperSim.TeaQCount  ==  AttributeName[intIndex])
{
return mintTeaQCount;
}
else if (convPaperSim.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (convPaperSim.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperSim.PaperId);
}
else if (convPaperSim.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperSim.PaperTitle);
}
else if (convPaperSim.PaperContent  ==  AttributeName[intIndex])
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convPaperSim.PaperContent);
}
else if (convPaperSim.Periodical  ==  AttributeName[intIndex])
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convPaperSim.Periodical);
}
else if (convPaperSim.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convPaperSim.Author);
}
else if (convPaperSim.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convPaperSim.ResearchQuestion);
}
else if (convPaperSim.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperSim.UpdDate);
}
else if (convPaperSim.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convPaperSim.UserName);
}
else if (convPaperSim.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convPaperSim.IdXzCollege);
}
else if (convPaperSim.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convPaperSim.CollegeName);
}
else if (convPaperSim.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convPaperSim.IdXzMajor);
}
else if (convPaperSim.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convPaperSim.MajorName);
}
else if (convPaperSim.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPaperSim.Keyword);
}
else if (convPaperSim.LiteratureSources  ==  AttributeName[intIndex])
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convPaperSim.LiteratureSources);
}
else if (convPaperSim.LiteratureLink  ==  AttributeName[intIndex])
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convPaperSim.LiteratureLink);
}
else if (convPaperSim.UploadfileUrl  ==  AttributeName[intIndex])
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convPaperSim.UploadfileUrl);
}
else if (convPaperSim.IsQuotethesis  ==  AttributeName[intIndex])
{
mbolIsQuotethesis = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaperSim.IsQuotethesis);
}
else if (convPaperSim.QuoteId  ==  AttributeName[intIndex])
{
mstrQuoteId = value.ToString();
 AddUpdatedFld(convPaperSim.QuoteId);
}
else if (convPaperSim.Checker  ==  AttributeName[intIndex])
{
mstrChecker = value.ToString();
 AddUpdatedFld(convPaperSim.Checker);
}
else if (convPaperSim.IsChecked  ==  AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaperSim.IsChecked);
}
else if (convPaperSim.LiteratureTypeId  ==  AttributeName[intIndex])
{
mstrLiteratureTypeId = value.ToString();
 AddUpdatedFld(convPaperSim.LiteratureTypeId);
}
else if (convPaperSim.BrowseNumber  ==  AttributeName[intIndex])
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.BrowseNumber);
}
else if (convPaperSim.LiteratureTypeName  ==  AttributeName[intIndex])
{
mstrLiteratureTypeName = value.ToString();
 AddUpdatedFld(convPaperSim.LiteratureTypeName);
}
else if (convPaperSim.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaperSim.IsSubmit);
}
else if (convPaperSim.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.AppraiseCount);
}
else if (convPaperSim.AttachmentCount  ==  AttributeName[intIndex])
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.AttachmentCount);
}
else if (convPaperSim.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.CollectionCount);
}
else if (convPaperSim.DownloadCount  ==  AttributeName[intIndex])
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.DownloadCount);
}
else if (convPaperSim.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaperSim.Memo);
}
else if (convPaperSim.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.OkCount);
}
else if (convPaperSim.Pcount  ==  AttributeName[intIndex])
{
mintPcount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.Pcount);
}
else if (convPaperSim.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperSim.Score);
}
else if (convPaperSim.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperSim.StuScore);
}
else if (convPaperSim.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperSim.TeaScore);
}
else if (convPaperSim.PaperQCount  ==  AttributeName[intIndex])
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.PaperQCount);
}
else if (convPaperSim.SubVCount  ==  AttributeName[intIndex])
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.SubVCount);
}
else if (convPaperSim.TagsCount  ==  AttributeName[intIndex])
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.TagsCount);
}
else if (convPaperSim.TeaQCount  ==  AttributeName[intIndex])
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSim.TeaQCount);
}
else if (convPaperSim.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperSim.UpdUser);
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
 AddUpdatedFld(convPaperSim.PaperId);
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
 AddUpdatedFld(convPaperSim.PaperTitle);
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
 AddUpdatedFld(convPaperSim.PaperContent);
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
 AddUpdatedFld(convPaperSim.Periodical);
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
 AddUpdatedFld(convPaperSim.Author);
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
 AddUpdatedFld(convPaperSim.ResearchQuestion);
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
 AddUpdatedFld(convPaperSim.UpdDate);
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
 AddUpdatedFld(convPaperSim.UserName);
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
 AddUpdatedFld(convPaperSim.IdXzCollege);
}
}
/// <summary>
/// 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName
{
get
{
return mstrCollegeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName = value;
}
else
{
 mstrCollegeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSim.CollegeName);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajor
{
get
{
return mstrIdXzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajor = value;
}
else
{
 mstrIdXzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSim.IdXzMajor);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSim.MajorName);
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
 AddUpdatedFld(convPaperSim.Keyword);
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
 AddUpdatedFld(convPaperSim.LiteratureSources);
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
 AddUpdatedFld(convPaperSim.LiteratureLink);
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
 AddUpdatedFld(convPaperSim.UploadfileUrl);
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
 AddUpdatedFld(convPaperSim.IsQuotethesis);
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
 AddUpdatedFld(convPaperSim.QuoteId);
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
 AddUpdatedFld(convPaperSim.Checker);
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
 AddUpdatedFld(convPaperSim.IsChecked);
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
 AddUpdatedFld(convPaperSim.LiteratureTypeId);
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
 AddUpdatedFld(convPaperSim.BrowseNumber);
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
 AddUpdatedFld(convPaperSim.LiteratureTypeName);
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
 AddUpdatedFld(convPaperSim.IsSubmit);
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
 AddUpdatedFld(convPaperSim.AppraiseCount);
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
 AddUpdatedFld(convPaperSim.AttachmentCount);
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
 AddUpdatedFld(convPaperSim.CollectionCount);
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
 AddUpdatedFld(convPaperSim.DownloadCount);
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
 AddUpdatedFld(convPaperSim.Memo);
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
 AddUpdatedFld(convPaperSim.OkCount);
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
 AddUpdatedFld(convPaperSim.Pcount);
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
 AddUpdatedFld(convPaperSim.Score);
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
 AddUpdatedFld(convPaperSim.StuScore);
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
 AddUpdatedFld(convPaperSim.TeaScore);
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
 AddUpdatedFld(convPaperSim.PaperQCount);
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
 AddUpdatedFld(convPaperSim.SubVCount);
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
 AddUpdatedFld(convPaperSim.TagsCount);
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
 AddUpdatedFld(convPaperSim.TeaQCount);
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
 AddUpdatedFld(convPaperSim.UpdUser);
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
 /// 论文简化视图(vPaperSim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPaperSim
{
public const string _CurrTabName = "vPaperSim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperId", "PaperTitle", "PaperContent", "Periodical", "Author", "ResearchQuestion", "UpdDate", "UserName", "IdXzCollege", "CollegeName", "IdXzMajor", "MajorName", "Keyword", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "IsQuotethesis", "QuoteId", "Checker", "IsChecked", "LiteratureTypeId", "BrowseNumber", "LiteratureTypeName", "IsSubmit", "AppraiseCount", "AttachmentCount", "CollectionCount", "DownloadCount", "Memo", "OkCount", "Pcount", "Score", "StuScore", "TeaScore", "PaperQCount", "SubVCount", "TagsCount", "TeaQCount", "UpdUser"};
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
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

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
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

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
 /// 常量:"Checker"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Checker = "Checker";    //审核人

 /// <summary>
 /// 常量:"IsChecked"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsChecked = "IsChecked";    //是否检查

 /// <summary>
 /// 常量:"LiteratureTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureTypeId = "LiteratureTypeId";    //作文类型Id

 /// <summary>
 /// 常量:"BrowseNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseNumber = "BrowseNumber";    //浏览量

 /// <summary>
 /// 常量:"LiteratureTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureTypeName = "LiteratureTypeName";    //作文类型名

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人
}

}