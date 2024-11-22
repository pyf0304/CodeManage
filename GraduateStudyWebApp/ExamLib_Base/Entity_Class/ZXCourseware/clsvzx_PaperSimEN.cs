
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_PaperSimEN
 表名:vzx_PaperSim(01120848)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// 表vzx_PaperSim的关键字(TextId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TextId_vzx_PaperSim
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
public K_TextId_vzx_PaperSim(string strTextId)
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
 /// <returns>返回:[K_TextId_vzx_PaperSim]类型的对象</returns>
public static implicit operator K_TextId_vzx_PaperSim(string value)
{
return new K_TextId_vzx_PaperSim(value);
}
}
 /// <summary>
 /// vzx_PaperSim(vzx_PaperSim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_PaperSimEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_PaperSim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TextId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 47;
public static string[] AttributeName = new string[] {"EduClsName", "CollegeName", "MajorName", "IdXzMajor", "IdXzCollege", "IsGSuser", "UserName", "TextId", "TextTitle", "TextContent", "Edition", "Author", "ResearchQuestion", "UpdDate", "TeaQCount", "TagsCount", "SubVCount", "PaperQCount", "Memo", "GradeId", "SchoolTerm", "UnitId", "zxShareId", "IsPublic", "VersionCount", "StuScore", "TeaScore", "Score", "AppraiseCount", "DownloadCount", "CollectionCount", "VoteCount", "VCount", "LiteratureLink", "UploadfileUrl", "IsSubmit", "IsChecked", "BrowseNumber", "AttachmentCount", "UpdUser", "CreateDate", "Checker", "IdCurrEduCls", "Keyword", "LiteratureSources", "TextTypeId", "TextStatusId"};

protected string mstrEduClsName;    //教学班名
protected string mstrCollegeName;    //学院名称
protected string mstrMajorName;    //专业名称
protected string mstrIdXzMajor;    //专业流水号
protected string mstrIdXzCollege;    //学院流水号
protected bool mbolIsGSuser;    //是否GS用户
protected string mstrUserName;    //用户名
protected string mstrTextId;    //课件Id
protected string mstrTextTitle;    //TextTitle
protected string mstrTextContent;    //TextContent
protected string mstrEdition;    //Edition
protected string mstrAuthor;    //作者
protected string mstrResearchQuestion;    //研究问题
protected string mstrUpdDate;    //修改日期
protected int? mintTeaQCount;    //教师提问数
protected int? mintTagsCount;    //论文标注数
protected int? mintSubVCount;    //论文子观点数
protected int? mintPaperQCount;    //论文答疑数
protected string mstrMemo;    //备注
protected string mstrGradeId;    //年级代号
protected string mstrSchoolTerm;    //学期
protected string mstrUnitId;    //UnitId
protected string mstrzxShareId;    //分享Id
protected bool mbolIsPublic;    //是否公开
protected int? mintVersionCount;    //版本统计
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected float? mfltScore;    //评分
protected int? mintAppraiseCount;    //评论数
protected int? mintDownloadCount;    //下载数
protected long? mlngCollectionCount;    //收藏数量
protected int? mintVoteCount;    //点赞计数
protected int? mintVCount;    //VCount
protected string mstrLiteratureLink;    //文献链接
protected string mstrUploadfileUrl;    //文件地址
protected bool mbolIsSubmit;    //是否提交
protected bool mbolIsChecked;    //是否检查
protected int? mintBrowseNumber;    //浏览量
protected int? mintAttachmentCount;    //附件计数
protected string mstrUpdUser;    //修改人
protected string mstrCreateDate;    //建立日期
protected string mstrChecker;    //审核人
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrKeyword;    //关键字
protected string mstrLiteratureSources;    //文献来源
protected string mstrTextTypeId;    //TextTypeId
protected string mstrTextStatusId;    //TextStatusId

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_PaperSimEN()
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
public clsvzx_PaperSimEN(string strTextId)
 {
strTextId = strTextId.Replace("'", "''");
if (strTextId.Length > 8)
{
throw new Exception("在表:vzx_PaperSim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTextId)  ==  true)
{
throw new Exception("在表:vzx_PaperSim中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convzx_PaperSim.EduClsName)
{
return mstrEduClsName;
}
else if (strAttributeName  ==  convzx_PaperSim.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convzx_PaperSim.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convzx_PaperSim.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convzx_PaperSim.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convzx_PaperSim.IsGSuser)
{
return mbolIsGSuser;
}
else if (strAttributeName  ==  convzx_PaperSim.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convzx_PaperSim.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  convzx_PaperSim.TextTitle)
{
return mstrTextTitle;
}
else if (strAttributeName  ==  convzx_PaperSim.TextContent)
{
return mstrTextContent;
}
else if (strAttributeName  ==  convzx_PaperSim.Edition)
{
return mstrEdition;
}
else if (strAttributeName  ==  convzx_PaperSim.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convzx_PaperSim.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  convzx_PaperSim.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_PaperSim.TeaQCount)
{
return mintTeaQCount;
}
else if (strAttributeName  ==  convzx_PaperSim.TagsCount)
{
return mintTagsCount;
}
else if (strAttributeName  ==  convzx_PaperSim.SubVCount)
{
return mintSubVCount;
}
else if (strAttributeName  ==  convzx_PaperSim.PaperQCount)
{
return mintPaperQCount;
}
else if (strAttributeName  ==  convzx_PaperSim.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_PaperSim.GradeId)
{
return mstrGradeId;
}
else if (strAttributeName  ==  convzx_PaperSim.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  convzx_PaperSim.UnitId)
{
return mstrUnitId;
}
else if (strAttributeName  ==  convzx_PaperSim.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  convzx_PaperSim.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convzx_PaperSim.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convzx_PaperSim.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convzx_PaperSim.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convzx_PaperSim.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convzx_PaperSim.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convzx_PaperSim.DownloadCount)
{
return mintDownloadCount;
}
else if (strAttributeName  ==  convzx_PaperSim.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convzx_PaperSim.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  convzx_PaperSim.VCount)
{
return mintVCount;
}
else if (strAttributeName  ==  convzx_PaperSim.LiteratureLink)
{
return mstrLiteratureLink;
}
else if (strAttributeName  ==  convzx_PaperSim.UploadfileUrl)
{
return mstrUploadfileUrl;
}
else if (strAttributeName  ==  convzx_PaperSim.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convzx_PaperSim.IsChecked)
{
return mbolIsChecked;
}
else if (strAttributeName  ==  convzx_PaperSim.BrowseNumber)
{
return mintBrowseNumber;
}
else if (strAttributeName  ==  convzx_PaperSim.AttachmentCount)
{
return mintAttachmentCount;
}
else if (strAttributeName  ==  convzx_PaperSim.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_PaperSim.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convzx_PaperSim.Checker)
{
return mstrChecker;
}
else if (strAttributeName  ==  convzx_PaperSim.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convzx_PaperSim.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convzx_PaperSim.LiteratureSources)
{
return mstrLiteratureSources;
}
else if (strAttributeName  ==  convzx_PaperSim.TextTypeId)
{
return mstrTextTypeId;
}
else if (strAttributeName  ==  convzx_PaperSim.TextStatusId)
{
return mstrTextStatusId;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_PaperSim.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convzx_PaperSim.EduClsName);
}
else if (strAttributeName  ==  convzx_PaperSim.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convzx_PaperSim.CollegeName);
}
else if (strAttributeName  ==  convzx_PaperSim.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convzx_PaperSim.MajorName);
}
else if (strAttributeName  ==  convzx_PaperSim.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convzx_PaperSim.IdXzMajor);
}
else if (strAttributeName  ==  convzx_PaperSim.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convzx_PaperSim.IdXzCollege);
}
else if (strAttributeName  ==  convzx_PaperSim.IsGSuser)
{
mbolIsGSuser = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_PaperSim.IsGSuser);
}
else if (strAttributeName  ==  convzx_PaperSim.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convzx_PaperSim.UserName);
}
else if (strAttributeName  ==  convzx_PaperSim.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_PaperSim.TextId);
}
else if (strAttributeName  ==  convzx_PaperSim.TextTitle)
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_PaperSim.TextTitle);
}
else if (strAttributeName  ==  convzx_PaperSim.TextContent)
{
mstrTextContent = value.ToString();
 AddUpdatedFld(convzx_PaperSim.TextContent);
}
else if (strAttributeName  ==  convzx_PaperSim.Edition)
{
mstrEdition = value.ToString();
 AddUpdatedFld(convzx_PaperSim.Edition);
}
else if (strAttributeName  ==  convzx_PaperSim.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convzx_PaperSim.Author);
}
else if (strAttributeName  ==  convzx_PaperSim.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convzx_PaperSim.ResearchQuestion);
}
else if (strAttributeName  ==  convzx_PaperSim.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_PaperSim.UpdDate);
}
else if (strAttributeName  ==  convzx_PaperSim.TeaQCount)
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.TeaQCount);
}
else if (strAttributeName  ==  convzx_PaperSim.TagsCount)
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.TagsCount);
}
else if (strAttributeName  ==  convzx_PaperSim.SubVCount)
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.SubVCount);
}
else if (strAttributeName  ==  convzx_PaperSim.PaperQCount)
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.PaperQCount);
}
else if (strAttributeName  ==  convzx_PaperSim.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_PaperSim.Memo);
}
else if (strAttributeName  ==  convzx_PaperSim.GradeId)
{
mstrGradeId = value.ToString();
 AddUpdatedFld(convzx_PaperSim.GradeId);
}
else if (strAttributeName  ==  convzx_PaperSim.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convzx_PaperSim.SchoolTerm);
}
else if (strAttributeName  ==  convzx_PaperSim.UnitId)
{
mstrUnitId = value.ToString();
 AddUpdatedFld(convzx_PaperSim.UnitId);
}
else if (strAttributeName  ==  convzx_PaperSim.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_PaperSim.zxShareId);
}
else if (strAttributeName  ==  convzx_PaperSim.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_PaperSim.IsPublic);
}
else if (strAttributeName  ==  convzx_PaperSim.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.VersionCount);
}
else if (strAttributeName  ==  convzx_PaperSim.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_PaperSim.StuScore);
}
else if (strAttributeName  ==  convzx_PaperSim.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_PaperSim.TeaScore);
}
else if (strAttributeName  ==  convzx_PaperSim.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_PaperSim.Score);
}
else if (strAttributeName  ==  convzx_PaperSim.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.AppraiseCount);
}
else if (strAttributeName  ==  convzx_PaperSim.DownloadCount)
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.DownloadCount);
}
else if (strAttributeName  ==  convzx_PaperSim.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.CollectionCount);
}
else if (strAttributeName  ==  convzx_PaperSim.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.VoteCount);
}
else if (strAttributeName  ==  convzx_PaperSim.VCount)
{
mintVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.VCount);
}
else if (strAttributeName  ==  convzx_PaperSim.LiteratureLink)
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convzx_PaperSim.LiteratureLink);
}
else if (strAttributeName  ==  convzx_PaperSim.UploadfileUrl)
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convzx_PaperSim.UploadfileUrl);
}
else if (strAttributeName  ==  convzx_PaperSim.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_PaperSim.IsSubmit);
}
else if (strAttributeName  ==  convzx_PaperSim.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_PaperSim.IsChecked);
}
else if (strAttributeName  ==  convzx_PaperSim.BrowseNumber)
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.BrowseNumber);
}
else if (strAttributeName  ==  convzx_PaperSim.AttachmentCount)
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.AttachmentCount);
}
else if (strAttributeName  ==  convzx_PaperSim.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_PaperSim.UpdUser);
}
else if (strAttributeName  ==  convzx_PaperSim.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_PaperSim.CreateDate);
}
else if (strAttributeName  ==  convzx_PaperSim.Checker)
{
mstrChecker = value.ToString();
 AddUpdatedFld(convzx_PaperSim.Checker);
}
else if (strAttributeName  ==  convzx_PaperSim.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_PaperSim.IdCurrEduCls);
}
else if (strAttributeName  ==  convzx_PaperSim.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convzx_PaperSim.Keyword);
}
else if (strAttributeName  ==  convzx_PaperSim.LiteratureSources)
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convzx_PaperSim.LiteratureSources);
}
else if (strAttributeName  ==  convzx_PaperSim.TextTypeId)
{
mstrTextTypeId = value.ToString();
 AddUpdatedFld(convzx_PaperSim.TextTypeId);
}
else if (strAttributeName  ==  convzx_PaperSim.TextStatusId)
{
mstrTextStatusId = value.ToString();
 AddUpdatedFld(convzx_PaperSim.TextStatusId);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_PaperSim.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
else if (convzx_PaperSim.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convzx_PaperSim.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convzx_PaperSim.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convzx_PaperSim.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convzx_PaperSim.IsGSuser  ==  AttributeName[intIndex])
{
return mbolIsGSuser;
}
else if (convzx_PaperSim.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convzx_PaperSim.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (convzx_PaperSim.TextTitle  ==  AttributeName[intIndex])
{
return mstrTextTitle;
}
else if (convzx_PaperSim.TextContent  ==  AttributeName[intIndex])
{
return mstrTextContent;
}
else if (convzx_PaperSim.Edition  ==  AttributeName[intIndex])
{
return mstrEdition;
}
else if (convzx_PaperSim.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convzx_PaperSim.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (convzx_PaperSim.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_PaperSim.TeaQCount  ==  AttributeName[intIndex])
{
return mintTeaQCount;
}
else if (convzx_PaperSim.TagsCount  ==  AttributeName[intIndex])
{
return mintTagsCount;
}
else if (convzx_PaperSim.SubVCount  ==  AttributeName[intIndex])
{
return mintSubVCount;
}
else if (convzx_PaperSim.PaperQCount  ==  AttributeName[intIndex])
{
return mintPaperQCount;
}
else if (convzx_PaperSim.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_PaperSim.GradeId  ==  AttributeName[intIndex])
{
return mstrGradeId;
}
else if (convzx_PaperSim.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (convzx_PaperSim.UnitId  ==  AttributeName[intIndex])
{
return mstrUnitId;
}
else if (convzx_PaperSim.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (convzx_PaperSim.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convzx_PaperSim.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convzx_PaperSim.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convzx_PaperSim.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convzx_PaperSim.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convzx_PaperSim.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convzx_PaperSim.DownloadCount  ==  AttributeName[intIndex])
{
return mintDownloadCount;
}
else if (convzx_PaperSim.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convzx_PaperSim.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (convzx_PaperSim.VCount  ==  AttributeName[intIndex])
{
return mintVCount;
}
else if (convzx_PaperSim.LiteratureLink  ==  AttributeName[intIndex])
{
return mstrLiteratureLink;
}
else if (convzx_PaperSim.UploadfileUrl  ==  AttributeName[intIndex])
{
return mstrUploadfileUrl;
}
else if (convzx_PaperSim.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convzx_PaperSim.IsChecked  ==  AttributeName[intIndex])
{
return mbolIsChecked;
}
else if (convzx_PaperSim.BrowseNumber  ==  AttributeName[intIndex])
{
return mintBrowseNumber;
}
else if (convzx_PaperSim.AttachmentCount  ==  AttributeName[intIndex])
{
return mintAttachmentCount;
}
else if (convzx_PaperSim.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_PaperSim.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convzx_PaperSim.Checker  ==  AttributeName[intIndex])
{
return mstrChecker;
}
else if (convzx_PaperSim.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convzx_PaperSim.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convzx_PaperSim.LiteratureSources  ==  AttributeName[intIndex])
{
return mstrLiteratureSources;
}
else if (convzx_PaperSim.TextTypeId  ==  AttributeName[intIndex])
{
return mstrTextTypeId;
}
else if (convzx_PaperSim.TextStatusId  ==  AttributeName[intIndex])
{
return mstrTextStatusId;
}
return null;
}
set
{
if (convzx_PaperSim.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convzx_PaperSim.EduClsName);
}
else if (convzx_PaperSim.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convzx_PaperSim.CollegeName);
}
else if (convzx_PaperSim.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convzx_PaperSim.MajorName);
}
else if (convzx_PaperSim.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convzx_PaperSim.IdXzMajor);
}
else if (convzx_PaperSim.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convzx_PaperSim.IdXzCollege);
}
else if (convzx_PaperSim.IsGSuser  ==  AttributeName[intIndex])
{
mbolIsGSuser = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_PaperSim.IsGSuser);
}
else if (convzx_PaperSim.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convzx_PaperSim.UserName);
}
else if (convzx_PaperSim.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_PaperSim.TextId);
}
else if (convzx_PaperSim.TextTitle  ==  AttributeName[intIndex])
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_PaperSim.TextTitle);
}
else if (convzx_PaperSim.TextContent  ==  AttributeName[intIndex])
{
mstrTextContent = value.ToString();
 AddUpdatedFld(convzx_PaperSim.TextContent);
}
else if (convzx_PaperSim.Edition  ==  AttributeName[intIndex])
{
mstrEdition = value.ToString();
 AddUpdatedFld(convzx_PaperSim.Edition);
}
else if (convzx_PaperSim.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convzx_PaperSim.Author);
}
else if (convzx_PaperSim.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convzx_PaperSim.ResearchQuestion);
}
else if (convzx_PaperSim.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_PaperSim.UpdDate);
}
else if (convzx_PaperSim.TeaQCount  ==  AttributeName[intIndex])
{
mintTeaQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.TeaQCount);
}
else if (convzx_PaperSim.TagsCount  ==  AttributeName[intIndex])
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.TagsCount);
}
else if (convzx_PaperSim.SubVCount  ==  AttributeName[intIndex])
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.SubVCount);
}
else if (convzx_PaperSim.PaperQCount  ==  AttributeName[intIndex])
{
mintPaperQCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.PaperQCount);
}
else if (convzx_PaperSim.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_PaperSim.Memo);
}
else if (convzx_PaperSim.GradeId  ==  AttributeName[intIndex])
{
mstrGradeId = value.ToString();
 AddUpdatedFld(convzx_PaperSim.GradeId);
}
else if (convzx_PaperSim.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(convzx_PaperSim.SchoolTerm);
}
else if (convzx_PaperSim.UnitId  ==  AttributeName[intIndex])
{
mstrUnitId = value.ToString();
 AddUpdatedFld(convzx_PaperSim.UnitId);
}
else if (convzx_PaperSim.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_PaperSim.zxShareId);
}
else if (convzx_PaperSim.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_PaperSim.IsPublic);
}
else if (convzx_PaperSim.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.VersionCount);
}
else if (convzx_PaperSim.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_PaperSim.StuScore);
}
else if (convzx_PaperSim.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_PaperSim.TeaScore);
}
else if (convzx_PaperSim.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convzx_PaperSim.Score);
}
else if (convzx_PaperSim.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.AppraiseCount);
}
else if (convzx_PaperSim.DownloadCount  ==  AttributeName[intIndex])
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.DownloadCount);
}
else if (convzx_PaperSim.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.CollectionCount);
}
else if (convzx_PaperSim.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.VoteCount);
}
else if (convzx_PaperSim.VCount  ==  AttributeName[intIndex])
{
mintVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.VCount);
}
else if (convzx_PaperSim.LiteratureLink  ==  AttributeName[intIndex])
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convzx_PaperSim.LiteratureLink);
}
else if (convzx_PaperSim.UploadfileUrl  ==  AttributeName[intIndex])
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convzx_PaperSim.UploadfileUrl);
}
else if (convzx_PaperSim.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_PaperSim.IsSubmit);
}
else if (convzx_PaperSim.IsChecked  ==  AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_PaperSim.IsChecked);
}
else if (convzx_PaperSim.BrowseNumber  ==  AttributeName[intIndex])
{
mintBrowseNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.BrowseNumber);
}
else if (convzx_PaperSim.AttachmentCount  ==  AttributeName[intIndex])
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperSim.AttachmentCount);
}
else if (convzx_PaperSim.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_PaperSim.UpdUser);
}
else if (convzx_PaperSim.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_PaperSim.CreateDate);
}
else if (convzx_PaperSim.Checker  ==  AttributeName[intIndex])
{
mstrChecker = value.ToString();
 AddUpdatedFld(convzx_PaperSim.Checker);
}
else if (convzx_PaperSim.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_PaperSim.IdCurrEduCls);
}
else if (convzx_PaperSim.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convzx_PaperSim.Keyword);
}
else if (convzx_PaperSim.LiteratureSources  ==  AttributeName[intIndex])
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convzx_PaperSim.LiteratureSources);
}
else if (convzx_PaperSim.TextTypeId  ==  AttributeName[intIndex])
{
mstrTextTypeId = value.ToString();
 AddUpdatedFld(convzx_PaperSim.TextTypeId);
}
else if (convzx_PaperSim.TextStatusId  ==  AttributeName[intIndex])
{
mstrTextStatusId = value.ToString();
 AddUpdatedFld(convzx_PaperSim.TextStatusId);
}
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
 AddUpdatedFld(convzx_PaperSim.EduClsName);
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
 AddUpdatedFld(convzx_PaperSim.CollegeName);
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
 AddUpdatedFld(convzx_PaperSim.MajorName);
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
 AddUpdatedFld(convzx_PaperSim.IdXzMajor);
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
 AddUpdatedFld(convzx_PaperSim.IdXzCollege);
}
}
/// <summary>
/// 是否GS用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGSuser
{
get
{
return mbolIsGSuser;
}
set
{
 mbolIsGSuser = value;
//记录修改过的字段
 AddUpdatedFld(convzx_PaperSim.IsGSuser);
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
 AddUpdatedFld(convzx_PaperSim.UserName);
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
 AddUpdatedFld(convzx_PaperSim.TextId);
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
 AddUpdatedFld(convzx_PaperSim.TextTitle);
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
 AddUpdatedFld(convzx_PaperSim.TextContent);
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
 AddUpdatedFld(convzx_PaperSim.Edition);
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
 AddUpdatedFld(convzx_PaperSim.Author);
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
 AddUpdatedFld(convzx_PaperSim.ResearchQuestion);
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
 AddUpdatedFld(convzx_PaperSim.UpdDate);
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
 AddUpdatedFld(convzx_PaperSim.TeaQCount);
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
 AddUpdatedFld(convzx_PaperSim.TagsCount);
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
 AddUpdatedFld(convzx_PaperSim.SubVCount);
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
 AddUpdatedFld(convzx_PaperSim.PaperQCount);
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
 AddUpdatedFld(convzx_PaperSim.Memo);
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
 AddUpdatedFld(convzx_PaperSim.GradeId);
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
 AddUpdatedFld(convzx_PaperSim.SchoolTerm);
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
 AddUpdatedFld(convzx_PaperSim.UnitId);
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
 AddUpdatedFld(convzx_PaperSim.zxShareId);
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
 AddUpdatedFld(convzx_PaperSim.IsPublic);
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
 AddUpdatedFld(convzx_PaperSim.VersionCount);
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
 AddUpdatedFld(convzx_PaperSim.StuScore);
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
 AddUpdatedFld(convzx_PaperSim.TeaScore);
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
 AddUpdatedFld(convzx_PaperSim.Score);
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
 AddUpdatedFld(convzx_PaperSim.AppraiseCount);
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
 AddUpdatedFld(convzx_PaperSim.DownloadCount);
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
 AddUpdatedFld(convzx_PaperSim.CollectionCount);
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
 AddUpdatedFld(convzx_PaperSim.VoteCount);
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
 AddUpdatedFld(convzx_PaperSim.VCount);
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
 AddUpdatedFld(convzx_PaperSim.LiteratureLink);
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
 AddUpdatedFld(convzx_PaperSim.UploadfileUrl);
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
 AddUpdatedFld(convzx_PaperSim.IsSubmit);
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
 AddUpdatedFld(convzx_PaperSim.IsChecked);
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
 AddUpdatedFld(convzx_PaperSim.BrowseNumber);
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
 AddUpdatedFld(convzx_PaperSim.AttachmentCount);
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
 AddUpdatedFld(convzx_PaperSim.UpdUser);
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
 AddUpdatedFld(convzx_PaperSim.CreateDate);
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
 AddUpdatedFld(convzx_PaperSim.Checker);
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
 AddUpdatedFld(convzx_PaperSim.IdCurrEduCls);
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
 AddUpdatedFld(convzx_PaperSim.Keyword);
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
 AddUpdatedFld(convzx_PaperSim.LiteratureSources);
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
 AddUpdatedFld(convzx_PaperSim.TextTypeId);
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
 AddUpdatedFld(convzx_PaperSim.TextStatusId);
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
 /// vzx_PaperSim(vzx_PaperSim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_PaperSim
{
public const string _CurrTabName = "vzx_PaperSim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TextId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"EduClsName", "CollegeName", "MajorName", "IdXzMajor", "IdXzCollege", "IsGSuser", "UserName", "TextId", "TextTitle", "TextContent", "Edition", "Author", "ResearchQuestion", "UpdDate", "TeaQCount", "TagsCount", "SubVCount", "PaperQCount", "Memo", "GradeId", "SchoolTerm", "UnitId", "zxShareId", "IsPublic", "VersionCount", "StuScore", "TeaScore", "Score", "AppraiseCount", "DownloadCount", "CollectionCount", "VoteCount", "VCount", "LiteratureLink", "UploadfileUrl", "IsSubmit", "IsChecked", "BrowseNumber", "AttachmentCount", "UpdUser", "CreateDate", "Checker", "IdCurrEduCls", "Keyword", "LiteratureSources", "TextTypeId", "TextStatusId"};
//以下是属性变量


 /// <summary>
 /// 常量:"EduClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsName = "EduClsName";    //教学班名

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"IsGSuser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGSuser = "IsGSuser";    //是否GS用户

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"GradeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeId = "GradeId";    //年级代号

 /// <summary>
 /// 常量:"SchoolTerm"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTerm = "SchoolTerm";    //学期

 /// <summary>
 /// 常量:"UnitId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UnitId = "UnitId";    //UnitId

 /// <summary>
 /// 常量:"zxShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxShareId = "zxShareId";    //分享Id

 /// <summary>
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

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
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数

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
 /// 常量:"VoteCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteCount = "VoteCount";    //点赞计数

 /// <summary>
 /// 常量:"VCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VCount = "VCount";    //VCount

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
 /// 常量:"AttachmentCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttachmentCount = "AttachmentCount";    //附件计数

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
 /// 常量:"TextTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextTypeId = "TextTypeId";    //TextTypeId

 /// <summary>
 /// 常量:"TextStatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextStatusId = "TextStatusId";    //TextStatusId
}

}