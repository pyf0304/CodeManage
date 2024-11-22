
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TextEN
 表名:zx_Text(01120704)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:53:28
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// 表zx_Text的关键字(TextId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TextId_zx_Text
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTextId">表关键字</param>
public K_TextId_zx_Text(string strTextId)
{
if (IsValid(strTextId)) Value = strTextId;
else
{
Value = null;
}
}
private static bool IsValid(string strTextId)
{
if (string.IsNullOrEmpty(strTextId) == true) return false;
if (strTextId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TextId_zx_Text]类型的对象</returns>
public static implicit operator K_TextId_zx_Text(string value)
{
return new K_TextId_zx_Text(value);
}
}
 /// <summary>
 /// 中学课件表(zx_Text)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_TextEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_Text"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TextId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 40;
public static string[] AttributeName = new string[] {"TextId", "TextTitle", "TextContent", "Edition", "Author", "ResearchQuestion", "UpdDate", "UpdUser", "CreateDate", "Checker", "IdCurrEduCls", "Keyword", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "IsSubmit", "IsChecked", "BrowseNumber", "VCount", "VoteCount", "CollectionCount", "DownloadCount", "AttachmentCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "TextTypeId", "TextStatusId", "VersionCount", "IsPublic", "zxShareId", "SchoolTerm", "GradeId", "Memo", "UnitId", "PaperQCount", "SubVCount", "TagsCount", "TeaQCount"};

protected string mstrTextId;    //课件Id
protected string mstrTextTitle;    //TextTitle
protected string mstrTextContent;    //TextContent
protected string mstrEdition;    //Edition
protected string mstrAuthor;    //作者
protected string mstrResearchQuestion;    //研究问题
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrCreateDate;    //建立日期
protected string mstrChecker;    //审核人
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrKeyword;    //关键字
protected string mstrLiteratureSources;    //文献来源
protected string mstrLiteratureLink;    //文献链接
protected string mstrUploadfileUrl;    //文件地址
protected bool mbolIsSubmit;    //是否提交
protected bool mbolIsChecked;    //是否检查
protected int? mintBrowseNumber;    //浏览量
protected int? mintVCount;    //VCount
protected int? mintVoteCount;    //点赞计数
protected long? mlngCollectionCount;    //收藏数量
protected int? mintDownloadCount;    //下载数
protected int? mintAttachmentCount;    //附件计数
protected int? mintAppraiseCount;    //评论数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrTextTypeId;    //TextTypeId
protected string mstrTextStatusId;    //TextStatusId
protected int? mintVersionCount;    //版本统计
protected bool mbolIsPublic;    //是否公开
protected string mstrzxShareId;    //分享Id
protected string mstrSchoolTerm;    //学期
protected string mstrGradeId;    //年级代号
protected string mstrMemo;    //备注
protected string mstrUnitId;    //UnitId
protected int? mintPaperQCount;    //论文答疑数
protected int? mintSubVCount;    //论文子观点数
protected int? mintTagsCount;    //论文标注数
protected int? mintTeaQCount;    //教师提问数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_TextEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TextId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTextId">关键字:课件Id</param>
public clszx_TextEN(string strTextId)
 {
strTextId = strTextId.Replace("'", "''");
if (strTextId.Length > 8)
{
throw new Exception("在表:zx_Text中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTextId)  ==  true)
{
throw new Exception("在表:zx_Text中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTextId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTextId = strTextId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TextId");
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
if (strAttributeName  ==  conzx_Text.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  conzx_Text.TextTitle)
{
return mstrTextTitle;
}
else if (strAttributeName  ==  conzx_Text.TextContent)
{
return mstrTextContent;
}
else if (strAttributeName  ==  conzx_Text.Edition)
{
return mstrEdition;
}
else if (strAttributeName  ==  conzx_Text.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  conzx_Text.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  conzx_Text.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_Text.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_Text.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conzx_Text.Checker)
{
return mstrChecker;
}
else if (strAttributeName  ==  conzx_Text.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_Text.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  conzx_Text.LiteratureSources)
{
return mstrLiteratureSources;
}
else if (strAttributeName  ==  conzx_Text.LiteratureLink)
{
return mstrLiteratureLink;
}
else if (strAttributeName  ==  conzx_Text.UploadfileUrl)
{
return mstrUploadfileUrl;
}
else if (strAttributeName  ==  conzx_Text.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conzx_Text.IsChecked)
{
return mbolIsChecked;
}
else if (strAttributeName  ==  conzx_Text.BrowseNumber)
{
return mintBrowseNumber;
}
else if (strAttributeName  ==  conzx_Text.VCount)
{
return mintVCount;
}
else if (strAttributeName  ==  conzx_Text.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  conzx_Text.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  conzx_Text.DownloadCount)
{
return mintDownloadCount;
}
else if (strAttributeName  ==  conzx_Text.AttachmentCount)
{
return mintAttachmentCount;
}
else if (strAttributeName  ==  conzx_Text.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  conzx_Text.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conzx_Text.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  conzx_Text.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  conzx_Text.TextTypeId)
{
return mstrTextTypeId;
}
else if (strAttributeName  ==  conzx_Text.TextStatusId)
{
return mstrTextStatusId;
}
else if (strAttributeName  ==  conzx_Text.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  conzx_Text.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  conzx_Text.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  conzx_Text.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  conzx_Text.GradeId)
{
return mstrGradeId;
}
else if (strAttributeName  ==  conzx_Text.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_Text.UnitId)
{
return mstrUnitId;
}
else if (strAttributeName  ==  conzx_Text.PaperQCount)
{
return mintPaperQCount;
}
else if (strAttributeName  ==  conzx_Text.SubVCount)
{
return mintSubVCount;
}
else if (strAttributeName  ==  conzx_Text.TagsCount)
{
return mintTagsCount;
}
else if (strAttributeName  ==  conzx_Text.TeaQCount)
{
return mintTeaQCount;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_Text.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_Text.TextId);
}
else if (strAttributeName  ==  conzx_Text.TextTitle)
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(conzx_Text.TextTitle);
}
else if (strAttributeName  ==  conzx_Text.TextContent)
{
mstrTextContent = value.ToString();
 AddUpdatedFld(conzx_Text.TextContent);
}
else if (strAttributeName  ==  conzx_Text.Edition)
{
mstrEdition = value.ToString();
 AddUpdatedFld(conzx_Text.Edition);
}
else if (strAttributeName  ==  conzx_Text.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(conzx_Text.Author);
}
else if (strAttributeName  ==  conzx_Text.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(conzx_Text.ResearchQuestion);
}
else if (strAttributeName  ==  conzx_Text.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_Text.UpdDate);
}
else if (strAttributeName  ==  conzx_Text.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_Text.UpdUser);
}
else if (strAttributeName  ==  conzx_Text.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conzx_Text.CreateDate);
}
else if (strAttributeName  ==  conzx_Text.Checker)
{
mstrChecker = value.ToString();
 AddUpdatedFld(conzx_Text.Checker);
}
else if (strAttributeName  ==  conzx_Text.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_Text.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_Text.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(conzx_Text.Keyword);
}
else if (strAttributeName  ==  conzx_Text.LiteratureSources)
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(conzx_Text.LiteratureSources);
}
else if (strAttributeName  ==  conzx_Text.LiteratureLink)
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(conzx_Text.LiteratureLink);
}
else if (strAttributeName  ==  conzx_Text.UploadfileUrl)
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(conzx_Text.UploadfileUrl);
}
else if (strAttributeName  ==  conzx_Text.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_Text.IsSubmit);
}
else if (strAttributeName  ==  conzx_Text.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_Text.IsChecked);
}
else if (strAttributeName  ==  conzx_Text.BrowseNumber)
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.BrowseNumber);
}
else if (strAttributeName  ==  conzx_Text.VCount)
{
mintVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.VCount);
}
else if (strAttributeName  ==  conzx_Text.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.VoteCount);
}
else if (strAttributeName  ==  conzx_Text.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.CollectionCount);
}
else if (strAttributeName  ==  conzx_Text.DownloadCount)
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.DownloadCount);
}
else if (strAttributeName  ==  conzx_Text.AttachmentCount)
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.AttachmentCount);
}
else if (strAttributeName  ==  conzx_Text.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.AppraiseCount);
}
else if (strAttributeName  ==  conzx_Text.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Text.Score);
}
else if (strAttributeName  ==  conzx_Text.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Text.StuScore);
}
else if (strAttributeName  ==  conzx_Text.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Text.TeaScore);
}
else if (strAttributeName  ==  conzx_Text.TextTypeId)
{
mstrTextTypeId = value.ToString();
 AddUpdatedFld(conzx_Text.TextTypeId);
}
else if (strAttributeName  ==  conzx_Text.TextStatusId)
{
mstrTextStatusId = value.ToString();
 AddUpdatedFld(conzx_Text.TextStatusId);
}
else if (strAttributeName  ==  conzx_Text.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.VersionCount);
}
else if (strAttributeName  ==  conzx_Text.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_Text.IsPublic);
}
else if (strAttributeName  ==  conzx_Text.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(conzx_Text.zxShareId);
}
else if (strAttributeName  ==  conzx_Text.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conzx_Text.SchoolTerm);
}
else if (strAttributeName  ==  conzx_Text.GradeId)
{
mstrGradeId = value.ToString();
 AddUpdatedFld(conzx_Text.GradeId);
}
else if (strAttributeName  ==  conzx_Text.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_Text.Memo);
}
else if (strAttributeName  ==  conzx_Text.UnitId)
{
mstrUnitId = value.ToString();
 AddUpdatedFld(conzx_Text.UnitId);
}
else if (strAttributeName  ==  conzx_Text.PaperQCount)
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.PaperQCount);
}
else if (strAttributeName  ==  conzx_Text.SubVCount)
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.SubVCount);
}
else if (strAttributeName  ==  conzx_Text.TagsCount)
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.TagsCount);
}
else if (strAttributeName  ==  conzx_Text.TeaQCount)
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.TeaQCount);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_Text.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (conzx_Text.TextTitle  ==  AttributeName[intIndex])
{
return mstrTextTitle;
}
else if (conzx_Text.TextContent  ==  AttributeName[intIndex])
{
return mstrTextContent;
}
else if (conzx_Text.Edition  ==  AttributeName[intIndex])
{
return mstrEdition;
}
else if (conzx_Text.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (conzx_Text.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (conzx_Text.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_Text.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_Text.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conzx_Text.Checker  ==  AttributeName[intIndex])
{
return mstrChecker;
}
else if (conzx_Text.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_Text.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (conzx_Text.LiteratureSources  ==  AttributeName[intIndex])
{
return mstrLiteratureSources;
}
else if (conzx_Text.LiteratureLink  ==  AttributeName[intIndex])
{
return mstrLiteratureLink;
}
else if (conzx_Text.UploadfileUrl  ==  AttributeName[intIndex])
{
return mstrUploadfileUrl;
}
else if (conzx_Text.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conzx_Text.IsChecked  ==  AttributeName[intIndex])
{
return mbolIsChecked;
}
else if (conzx_Text.BrowseNumber  ==  AttributeName[intIndex])
{
return mintBrowseNumber;
}
else if (conzx_Text.VCount  ==  AttributeName[intIndex])
{
return mintVCount;
}
else if (conzx_Text.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (conzx_Text.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (conzx_Text.DownloadCount  ==  AttributeName[intIndex])
{
return mintDownloadCount;
}
else if (conzx_Text.AttachmentCount  ==  AttributeName[intIndex])
{
return mintAttachmentCount;
}
else if (conzx_Text.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (conzx_Text.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conzx_Text.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (conzx_Text.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (conzx_Text.TextTypeId  ==  AttributeName[intIndex])
{
return mstrTextTypeId;
}
else if (conzx_Text.TextStatusId  ==  AttributeName[intIndex])
{
return mstrTextStatusId;
}
else if (conzx_Text.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (conzx_Text.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (conzx_Text.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (conzx_Text.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (conzx_Text.GradeId  ==  AttributeName[intIndex])
{
return mstrGradeId;
}
else if (conzx_Text.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_Text.UnitId  ==  AttributeName[intIndex])
{
return mstrUnitId;
}
else if (conzx_Text.PaperQCount  ==  AttributeName[intIndex])
{
return mintPaperQCount;
}
else if (conzx_Text.SubVCount  ==  AttributeName[intIndex])
{
return mintSubVCount;
}
else if (conzx_Text.TagsCount  ==  AttributeName[intIndex])
{
return mintTagsCount;
}
else if (conzx_Text.TeaQCount  ==  AttributeName[intIndex])
{
return mintTeaQCount;
}
return null;
}
set
{
if (conzx_Text.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_Text.TextId);
}
else if (conzx_Text.TextTitle  ==  AttributeName[intIndex])
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(conzx_Text.TextTitle);
}
else if (conzx_Text.TextContent  ==  AttributeName[intIndex])
{
mstrTextContent = value.ToString();
 AddUpdatedFld(conzx_Text.TextContent);
}
else if (conzx_Text.Edition  ==  AttributeName[intIndex])
{
mstrEdition = value.ToString();
 AddUpdatedFld(conzx_Text.Edition);
}
else if (conzx_Text.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(conzx_Text.Author);
}
else if (conzx_Text.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(conzx_Text.ResearchQuestion);
}
else if (conzx_Text.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_Text.UpdDate);
}
else if (conzx_Text.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_Text.UpdUser);
}
else if (conzx_Text.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conzx_Text.CreateDate);
}
else if (conzx_Text.Checker  ==  AttributeName[intIndex])
{
mstrChecker = value.ToString();
 AddUpdatedFld(conzx_Text.Checker);
}
else if (conzx_Text.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_Text.IdCurrEduCls);
}
else if (conzx_Text.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(conzx_Text.Keyword);
}
else if (conzx_Text.LiteratureSources  ==  AttributeName[intIndex])
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(conzx_Text.LiteratureSources);
}
else if (conzx_Text.LiteratureLink  ==  AttributeName[intIndex])
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(conzx_Text.LiteratureLink);
}
else if (conzx_Text.UploadfileUrl  ==  AttributeName[intIndex])
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(conzx_Text.UploadfileUrl);
}
else if (conzx_Text.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_Text.IsSubmit);
}
else if (conzx_Text.IsChecked  ==  AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_Text.IsChecked);
}
else if (conzx_Text.BrowseNumber  ==  AttributeName[intIndex])
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.BrowseNumber);
}
else if (conzx_Text.VCount  ==  AttributeName[intIndex])
{
mintVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.VCount);
}
else if (conzx_Text.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.VoteCount);
}
else if (conzx_Text.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.CollectionCount);
}
else if (conzx_Text.DownloadCount  ==  AttributeName[intIndex])
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.DownloadCount);
}
else if (conzx_Text.AttachmentCount  ==  AttributeName[intIndex])
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.AttachmentCount);
}
else if (conzx_Text.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.AppraiseCount);
}
else if (conzx_Text.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Text.Score);
}
else if (conzx_Text.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Text.StuScore);
}
else if (conzx_Text.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Text.TeaScore);
}
else if (conzx_Text.TextTypeId  ==  AttributeName[intIndex])
{
mstrTextTypeId = value.ToString();
 AddUpdatedFld(conzx_Text.TextTypeId);
}
else if (conzx_Text.TextStatusId  ==  AttributeName[intIndex])
{
mstrTextStatusId = value.ToString();
 AddUpdatedFld(conzx_Text.TextStatusId);
}
else if (conzx_Text.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.VersionCount);
}
else if (conzx_Text.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_Text.IsPublic);
}
else if (conzx_Text.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(conzx_Text.zxShareId);
}
else if (conzx_Text.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conzx_Text.SchoolTerm);
}
else if (conzx_Text.GradeId  ==  AttributeName[intIndex])
{
mstrGradeId = value.ToString();
 AddUpdatedFld(conzx_Text.GradeId);
}
else if (conzx_Text.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_Text.Memo);
}
else if (conzx_Text.UnitId  ==  AttributeName[intIndex])
{
mstrUnitId = value.ToString();
 AddUpdatedFld(conzx_Text.UnitId);
}
else if (conzx_Text.PaperQCount  ==  AttributeName[intIndex])
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.PaperQCount);
}
else if (conzx_Text.SubVCount  ==  AttributeName[intIndex])
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.SubVCount);
}
else if (conzx_Text.TagsCount  ==  AttributeName[intIndex])
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.TagsCount);
}
else if (conzx_Text.TeaQCount  ==  AttributeName[intIndex])
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Text.TeaQCount);
}
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
 AddUpdatedFld(conzx_Text.TextId);
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
 AddUpdatedFld(conzx_Text.TextTitle);
}
}
/// <summary>
/// TextContent(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextContent
{
get
{
return mstrTextContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextContent = value;
}
else
{
 mstrTextContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Text.TextContent);
}
}
/// <summary>
/// Edition(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Edition
{
get
{
return mstrEdition;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEdition = value;
}
else
{
 mstrEdition = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Text.Edition);
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
 AddUpdatedFld(conzx_Text.Author);
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
 AddUpdatedFld(conzx_Text.ResearchQuestion);
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
 AddUpdatedFld(conzx_Text.UpdDate);
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
 AddUpdatedFld(conzx_Text.UpdUser);
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
 AddUpdatedFld(conzx_Text.CreateDate);
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
 AddUpdatedFld(conzx_Text.Checker);
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
 AddUpdatedFld(conzx_Text.IdCurrEduCls);
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
 AddUpdatedFld(conzx_Text.Keyword);
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
 AddUpdatedFld(conzx_Text.LiteratureSources);
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
 AddUpdatedFld(conzx_Text.LiteratureLink);
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
 AddUpdatedFld(conzx_Text.UploadfileUrl);
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
 AddUpdatedFld(conzx_Text.IsSubmit);
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
 AddUpdatedFld(conzx_Text.IsChecked);
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
 AddUpdatedFld(conzx_Text.BrowseNumber);
}
}
/// <summary>
/// VCount(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VCount
{
get
{
return mintVCount;
}
set
{
 mintVCount = value;
//记录修改过的字段
 AddUpdatedFld(conzx_Text.VCount);
}
}
/// <summary>
/// 点赞计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VoteCount
{
get
{
return mintVoteCount;
}
set
{
 mintVoteCount = value;
//记录修改过的字段
 AddUpdatedFld(conzx_Text.VoteCount);
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
 AddUpdatedFld(conzx_Text.CollectionCount);
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
 AddUpdatedFld(conzx_Text.DownloadCount);
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
 AddUpdatedFld(conzx_Text.AttachmentCount);
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
 AddUpdatedFld(conzx_Text.AppraiseCount);
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
 AddUpdatedFld(conzx_Text.Score);
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
 AddUpdatedFld(conzx_Text.StuScore);
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
 AddUpdatedFld(conzx_Text.TeaScore);
}
}
/// <summary>
/// TextTypeId(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextTypeId
{
get
{
return mstrTextTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextTypeId = value;
}
else
{
 mstrTextTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Text.TextTypeId);
}
}
/// <summary>
/// TextStatusId(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextStatusId
{
get
{
return mstrTextStatusId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextStatusId = value;
}
else
{
 mstrTextStatusId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Text.TextStatusId);
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
 AddUpdatedFld(conzx_Text.VersionCount);
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
 AddUpdatedFld(conzx_Text.IsPublic);
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
 AddUpdatedFld(conzx_Text.zxShareId);
}
}
/// <summary>
/// 学期(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolTerm
{
get
{
return mstrSchoolTerm;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolTerm = value;
}
else
{
 mstrSchoolTerm = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Text.SchoolTerm);
}
}
/// <summary>
/// 年级代号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeId
{
get
{
return mstrGradeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeId = value;
}
else
{
 mstrGradeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Text.GradeId);
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
 AddUpdatedFld(conzx_Text.Memo);
}
}
/// <summary>
/// UnitId(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UnitId
{
get
{
return mstrUnitId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUnitId = value;
}
else
{
 mstrUnitId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Text.UnitId);
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
 AddUpdatedFld(conzx_Text.PaperQCount);
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
 AddUpdatedFld(conzx_Text.SubVCount);
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
 AddUpdatedFld(conzx_Text.TagsCount);
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
 AddUpdatedFld(conzx_Text.TeaQCount);
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
  return mstrTextId;
 }
 }
}
 /// <summary>
 /// 中学课件表(zx_Text)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_Text
{
public const string _CurrTabName = "zx_Text"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TextId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TextId", "TextTitle", "TextContent", "Edition", "Author", "ResearchQuestion", "UpdDate", "UpdUser", "CreateDate", "Checker", "IdCurrEduCls", "Keyword", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "IsSubmit", "IsChecked", "BrowseNumber", "VCount", "VoteCount", "CollectionCount", "DownloadCount", "AttachmentCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "TextTypeId", "TextStatusId", "VersionCount", "IsPublic", "zxShareId", "SchoolTerm", "GradeId", "Memo", "UnitId", "PaperQCount", "SubVCount", "TagsCount", "TeaQCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"TextTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextTitle = "TextTitle";    //TextTitle

 /// <summary>
 /// 常量:"TextContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextContent = "TextContent";    //TextContent

 /// <summary>
 /// 常量:"Edition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Edition = "Edition";    //Edition

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
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"Checker"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Checker = "Checker";    //审核人

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

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
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"IsChecked"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsChecked = "IsChecked";    //是否检查

 /// <summary>
 /// 常量:"BrowseNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseNumber = "BrowseNumber";    //浏览量

 /// <summary>
 /// 常量:"VCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VCount = "VCount";    //VCount

 /// <summary>
 /// 常量:"VoteCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteCount = "VoteCount";    //点赞计数

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
 /// 常量:"TextTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextTypeId = "TextTypeId";    //TextTypeId

 /// <summary>
 /// 常量:"TextStatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextStatusId = "TextStatusId";    //TextStatusId

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
 /// 常量:"zxShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxShareId = "zxShareId";    //分享Id

 /// <summary>
 /// 常量:"SchoolTerm"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTerm = "SchoolTerm";    //学期

 /// <summary>
 /// 常量:"GradeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeId = "GradeId";    //年级代号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"UnitId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UnitId = "UnitId";    //UnitId

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
}

}