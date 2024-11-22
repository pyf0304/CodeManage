
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTViewpointEN
 表名:vRTViewpoint(01120956)
 * 版本:2024.03.11.1(服务器:WIN-SRV103-116)
 日期:2024/03/19 02:42:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 表vRTViewpoint的关键字(TopicId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TopicId_vRTViewpoint
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTopicId">表关键字</param>
public K_TopicId_vRTViewpoint(string strTopicId)
{
if (IsValid(strTopicId)) Value = strTopicId;
else
{
Value = null;
}
}
private static bool IsValid(string strTopicId)
{
if (strTopicId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TopicId_vRTViewpoint]类型的对象</returns>
public static implicit operator K_TopicId_vRTViewpoint(string value)
{
return new K_TopicId_vRTViewpoint(value);
}
}
 /// <summary>
 /// vRTViewpoint(vRTViewpoint)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvRTViewpointEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vRTViewpoint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TopicId,SubViewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 50;
public static string[] AttributeName = new string[] {"TopicId", "SubViewpointId", "TopicName", "VersionCount", "CitationCount", "TopicContent", "TopicProposePeople", "gsKnowledgeTypeName", "LevelName", "OperationTypeName", "SubViewpointContent", "PaperId", "PaperTitle", "IsSubmit", "SectionId", "SectionName", "SubViewpointTypeId", "SubViewpointTypeName", "ExplainTypeId", "ExplainTypeName", "ExplainContent", "IsPublic", "LiteratureSourcesId", "OperationTypeId", "LevelId", "Conclusion", "Nationality", "Achievement", "Major", "WorkUnit", "PageNumber", "PdfContent", "AppraiseCount", "OkCount", "Score", "StuScore", "TeaScore", "CreateDate", "ShareId", "SubViewpointTypeOrderNum", "ProposePeople", "gsKnowledgeTypeId", "ClassificationId", "IdCurrEduCls", "UpdDate", "UpdUser", "Memo", "ViewPointUserId", "ViewPointDate", "IsRecommend"};

protected string mstrTopicId;    //主题Id
protected long? mlngSubViewpointId;    //子观点Id
protected string mstrTopicName;    //栏目主题
protected int? mintVersionCount;    //版本统计
protected int? mintCitationCount;    //引用统计
protected string mstrTopicContent;    //主题内容
protected string mstrTopicProposePeople;    //主题提出人
protected string mstrgsKnowledgeTypeName;    //知识类型名
protected string mstrLevelName;    //级别名称
protected string mstrOperationTypeName;    //操作类型名
protected string mstrSubViewpointContent;    //详情内容
protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected bool mbolIsSubmit;    //是否提交
protected string mstrSectionId;    //节Id
protected string mstrSectionName;    //节名
protected string mstrSubViewpointTypeId;    //类型Id
protected string mstrSubViewpointTypeName;    //类型名称
protected string mstrExplainTypeId;    //说明类型Id
protected string mstrExplainTypeName;    //说明类型名
protected string mstrExplainContent;    //说明内容
protected bool mbolIsPublic;    //是否公开
protected string mstrLiteratureSourcesId;    //文献来源
protected string mstrOperationTypeId;    //操作类型ID
protected string mstrLevelId;    //级别Id
protected string mstrConclusion;    //结论
protected string mstrNationality;    //国籍
protected string mstrAchievement;    //成就
protected string mstrMajor;    //专业
protected string mstrWorkUnit;    //工作单位
protected int? mintPageNumber;    //页码
protected string mstrPdfContent;    //Pdf内容
protected int? mintAppraiseCount;    //评论数
protected int? mintOkCount;    //点赞统计
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id
protected int? mintSubViewpointTypeOrderNum;    //子观点类型序号
protected string mstrProposePeople;    //提出人
protected string mstrgsKnowledgeTypeId;    //知识类型Id
protected long? mlngClassificationId;    //分类Id
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrViewPointUserId;    //观点用户Id
protected string mstrViewPointDate;    //观点日期
protected bool mbolIsRecommend;    //是否推荐

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvRTViewpointEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicId");
 lstKeyFldNames.Add("SubViewpointId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTopicId">关键字:主题Id</param>
public clsvRTViewpointEN(string strTopicId , long lngSubViewpointId)
 {
strTopicId = strTopicId.Replace("'", "''");
if (strTopicId.Length > 8)
{
throw new Exception("在表:vRTViewpoint中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTopicId)  ==  true)
{
throw new Exception("在表:vRTViewpoint中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTopicId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTopicId = strTopicId;
this.mlngSubViewpointId = lngSubViewpointId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicId");
 lstKeyFldNames.Add("SubViewpointId");
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
if (strAttributeName  ==  convRTViewpoint.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  convRTViewpoint.SubViewpointId)
{
return mlngSubViewpointId;
}
else if (strAttributeName  ==  convRTViewpoint.TopicName)
{
return mstrTopicName;
}
else if (strAttributeName  ==  convRTViewpoint.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convRTViewpoint.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convRTViewpoint.TopicContent)
{
return mstrTopicContent;
}
else if (strAttributeName  ==  convRTViewpoint.TopicProposePeople)
{
return mstrTopicProposePeople;
}
else if (strAttributeName  ==  convRTViewpoint.gsKnowledgeTypeName)
{
return mstrgsKnowledgeTypeName;
}
else if (strAttributeName  ==  convRTViewpoint.LevelName)
{
return mstrLevelName;
}
else if (strAttributeName  ==  convRTViewpoint.OperationTypeName)
{
return mstrOperationTypeName;
}
else if (strAttributeName  ==  convRTViewpoint.SubViewpointContent)
{
return mstrSubViewpointContent;
}
else if (strAttributeName  ==  convRTViewpoint.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convRTViewpoint.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convRTViewpoint.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convRTViewpoint.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convRTViewpoint.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convRTViewpoint.SubViewpointTypeId)
{
return mstrSubViewpointTypeId;
}
else if (strAttributeName  ==  convRTViewpoint.SubViewpointTypeName)
{
return mstrSubViewpointTypeName;
}
else if (strAttributeName  ==  convRTViewpoint.ExplainTypeId)
{
return mstrExplainTypeId;
}
else if (strAttributeName  ==  convRTViewpoint.ExplainTypeName)
{
return mstrExplainTypeName;
}
else if (strAttributeName  ==  convRTViewpoint.ExplainContent)
{
return mstrExplainContent;
}
else if (strAttributeName  ==  convRTViewpoint.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convRTViewpoint.LiteratureSourcesId)
{
return mstrLiteratureSourcesId;
}
else if (strAttributeName  ==  convRTViewpoint.OperationTypeId)
{
return mstrOperationTypeId;
}
else if (strAttributeName  ==  convRTViewpoint.LevelId)
{
return mstrLevelId;
}
else if (strAttributeName  ==  convRTViewpoint.Conclusion)
{
return mstrConclusion;
}
else if (strAttributeName  ==  convRTViewpoint.Nationality)
{
return mstrNationality;
}
else if (strAttributeName  ==  convRTViewpoint.Achievement)
{
return mstrAchievement;
}
else if (strAttributeName  ==  convRTViewpoint.Major)
{
return mstrMajor;
}
else if (strAttributeName  ==  convRTViewpoint.WorkUnit)
{
return mstrWorkUnit;
}
else if (strAttributeName  ==  convRTViewpoint.PageNumber)
{
return mintPageNumber;
}
else if (strAttributeName  ==  convRTViewpoint.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convRTViewpoint.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convRTViewpoint.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convRTViewpoint.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convRTViewpoint.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convRTViewpoint.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convRTViewpoint.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convRTViewpoint.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  convRTViewpoint.SubViewpointTypeOrderNum)
{
return mintSubViewpointTypeOrderNum;
}
else if (strAttributeName  ==  convRTViewpoint.ProposePeople)
{
return mstrProposePeople;
}
else if (strAttributeName  ==  convRTViewpoint.gsKnowledgeTypeId)
{
return mstrgsKnowledgeTypeId;
}
else if (strAttributeName  ==  convRTViewpoint.ClassificationId)
{
return mlngClassificationId;
}
else if (strAttributeName  ==  convRTViewpoint.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convRTViewpoint.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convRTViewpoint.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convRTViewpoint.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convRTViewpoint.ViewPointUserId)
{
return mstrViewPointUserId;
}
else if (strAttributeName  ==  convRTViewpoint.ViewPointDate)
{
return mstrViewPointDate;
}
else if (strAttributeName  ==  convRTViewpoint.IsRecommend)
{
return mbolIsRecommend;
}
return null;
}
set
{
if (strAttributeName  ==  convRTViewpoint.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTViewpoint.TopicId);
}
else if (strAttributeName  ==  convRTViewpoint.SubViewpointId)
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpoint.SubViewpointId);
}
else if (strAttributeName  ==  convRTViewpoint.TopicName)
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTViewpoint.TopicName);
}
else if (strAttributeName  ==  convRTViewpoint.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpoint.VersionCount);
}
else if (strAttributeName  ==  convRTViewpoint.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpoint.CitationCount);
}
else if (strAttributeName  ==  convRTViewpoint.TopicContent)
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTViewpoint.TopicContent);
}
else if (strAttributeName  ==  convRTViewpoint.TopicProposePeople)
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convRTViewpoint.TopicProposePeople);
}
else if (strAttributeName  ==  convRTViewpoint.gsKnowledgeTypeName)
{
mstrgsKnowledgeTypeName = value.ToString();
 AddUpdatedFld(convRTViewpoint.gsKnowledgeTypeName);
}
else if (strAttributeName  ==  convRTViewpoint.LevelName)
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convRTViewpoint.LevelName);
}
else if (strAttributeName  ==  convRTViewpoint.OperationTypeName)
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(convRTViewpoint.OperationTypeName);
}
else if (strAttributeName  ==  convRTViewpoint.SubViewpointContent)
{
mstrSubViewpointContent = value.ToString();
 AddUpdatedFld(convRTViewpoint.SubViewpointContent);
}
else if (strAttributeName  ==  convRTViewpoint.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convRTViewpoint.PaperId);
}
else if (strAttributeName  ==  convRTViewpoint.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convRTViewpoint.PaperTitle);
}
else if (strAttributeName  ==  convRTViewpoint.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTViewpoint.IsSubmit);
}
else if (strAttributeName  ==  convRTViewpoint.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convRTViewpoint.SectionId);
}
else if (strAttributeName  ==  convRTViewpoint.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convRTViewpoint.SectionName);
}
else if (strAttributeName  ==  convRTViewpoint.SubViewpointTypeId)
{
mstrSubViewpointTypeId = value.ToString();
 AddUpdatedFld(convRTViewpoint.SubViewpointTypeId);
}
else if (strAttributeName  ==  convRTViewpoint.SubViewpointTypeName)
{
mstrSubViewpointTypeName = value.ToString();
 AddUpdatedFld(convRTViewpoint.SubViewpointTypeName);
}
else if (strAttributeName  ==  convRTViewpoint.ExplainTypeId)
{
mstrExplainTypeId = value.ToString();
 AddUpdatedFld(convRTViewpoint.ExplainTypeId);
}
else if (strAttributeName  ==  convRTViewpoint.ExplainTypeName)
{
mstrExplainTypeName = value.ToString();
 AddUpdatedFld(convRTViewpoint.ExplainTypeName);
}
else if (strAttributeName  ==  convRTViewpoint.ExplainContent)
{
mstrExplainContent = value.ToString();
 AddUpdatedFld(convRTViewpoint.ExplainContent);
}
else if (strAttributeName  ==  convRTViewpoint.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTViewpoint.IsPublic);
}
else if (strAttributeName  ==  convRTViewpoint.LiteratureSourcesId)
{
mstrLiteratureSourcesId = value.ToString();
 AddUpdatedFld(convRTViewpoint.LiteratureSourcesId);
}
else if (strAttributeName  ==  convRTViewpoint.OperationTypeId)
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(convRTViewpoint.OperationTypeId);
}
else if (strAttributeName  ==  convRTViewpoint.LevelId)
{
mstrLevelId = value.ToString();
 AddUpdatedFld(convRTViewpoint.LevelId);
}
else if (strAttributeName  ==  convRTViewpoint.Conclusion)
{
mstrConclusion = value.ToString();
 AddUpdatedFld(convRTViewpoint.Conclusion);
}
else if (strAttributeName  ==  convRTViewpoint.Nationality)
{
mstrNationality = value.ToString();
 AddUpdatedFld(convRTViewpoint.Nationality);
}
else if (strAttributeName  ==  convRTViewpoint.Achievement)
{
mstrAchievement = value.ToString();
 AddUpdatedFld(convRTViewpoint.Achievement);
}
else if (strAttributeName  ==  convRTViewpoint.Major)
{
mstrMajor = value.ToString();
 AddUpdatedFld(convRTViewpoint.Major);
}
else if (strAttributeName  ==  convRTViewpoint.WorkUnit)
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convRTViewpoint.WorkUnit);
}
else if (strAttributeName  ==  convRTViewpoint.PageNumber)
{
mintPageNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpoint.PageNumber);
}
else if (strAttributeName  ==  convRTViewpoint.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convRTViewpoint.PdfContent);
}
else if (strAttributeName  ==  convRTViewpoint.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpoint.AppraiseCount);
}
else if (strAttributeName  ==  convRTViewpoint.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpoint.OkCount);
}
else if (strAttributeName  ==  convRTViewpoint.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTViewpoint.Score);
}
else if (strAttributeName  ==  convRTViewpoint.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTViewpoint.StuScore);
}
else if (strAttributeName  ==  convRTViewpoint.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTViewpoint.TeaScore);
}
else if (strAttributeName  ==  convRTViewpoint.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convRTViewpoint.CreateDate);
}
else if (strAttributeName  ==  convRTViewpoint.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convRTViewpoint.ShareId);
}
else if (strAttributeName  ==  convRTViewpoint.SubViewpointTypeOrderNum)
{
mintSubViewpointTypeOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpoint.SubViewpointTypeOrderNum);
}
else if (strAttributeName  ==  convRTViewpoint.ProposePeople)
{
mstrProposePeople = value.ToString();
 AddUpdatedFld(convRTViewpoint.ProposePeople);
}
else if (strAttributeName  ==  convRTViewpoint.gsKnowledgeTypeId)
{
mstrgsKnowledgeTypeId = value.ToString();
 AddUpdatedFld(convRTViewpoint.gsKnowledgeTypeId);
}
else if (strAttributeName  ==  convRTViewpoint.ClassificationId)
{
mlngClassificationId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpoint.ClassificationId);
}
else if (strAttributeName  ==  convRTViewpoint.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convRTViewpoint.IdCurrEduCls);
}
else if (strAttributeName  ==  convRTViewpoint.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTViewpoint.UpdDate);
}
else if (strAttributeName  ==  convRTViewpoint.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTViewpoint.UpdUser);
}
else if (strAttributeName  ==  convRTViewpoint.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convRTViewpoint.Memo);
}
else if (strAttributeName  ==  convRTViewpoint.ViewPointUserId)
{
mstrViewPointUserId = value.ToString();
 AddUpdatedFld(convRTViewpoint.ViewPointUserId);
}
else if (strAttributeName  ==  convRTViewpoint.ViewPointDate)
{
mstrViewPointDate = value.ToString();
 AddUpdatedFld(convRTViewpoint.ViewPointDate);
}
else if (strAttributeName  ==  convRTViewpoint.IsRecommend)
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTViewpoint.IsRecommend);
}
}
}
public object this[int intIndex]
{
get
{
if (convRTViewpoint.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (convRTViewpoint.SubViewpointId  ==  AttributeName[intIndex])
{
return mlngSubViewpointId;
}
else if (convRTViewpoint.TopicName  ==  AttributeName[intIndex])
{
return mstrTopicName;
}
else if (convRTViewpoint.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convRTViewpoint.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convRTViewpoint.TopicContent  ==  AttributeName[intIndex])
{
return mstrTopicContent;
}
else if (convRTViewpoint.TopicProposePeople  ==  AttributeName[intIndex])
{
return mstrTopicProposePeople;
}
else if (convRTViewpoint.gsKnowledgeTypeName  ==  AttributeName[intIndex])
{
return mstrgsKnowledgeTypeName;
}
else if (convRTViewpoint.LevelName  ==  AttributeName[intIndex])
{
return mstrLevelName;
}
else if (convRTViewpoint.OperationTypeName  ==  AttributeName[intIndex])
{
return mstrOperationTypeName;
}
else if (convRTViewpoint.SubViewpointContent  ==  AttributeName[intIndex])
{
return mstrSubViewpointContent;
}
else if (convRTViewpoint.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convRTViewpoint.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convRTViewpoint.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convRTViewpoint.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convRTViewpoint.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convRTViewpoint.SubViewpointTypeId  ==  AttributeName[intIndex])
{
return mstrSubViewpointTypeId;
}
else if (convRTViewpoint.SubViewpointTypeName  ==  AttributeName[intIndex])
{
return mstrSubViewpointTypeName;
}
else if (convRTViewpoint.ExplainTypeId  ==  AttributeName[intIndex])
{
return mstrExplainTypeId;
}
else if (convRTViewpoint.ExplainTypeName  ==  AttributeName[intIndex])
{
return mstrExplainTypeName;
}
else if (convRTViewpoint.ExplainContent  ==  AttributeName[intIndex])
{
return mstrExplainContent;
}
else if (convRTViewpoint.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convRTViewpoint.LiteratureSourcesId  ==  AttributeName[intIndex])
{
return mstrLiteratureSourcesId;
}
else if (convRTViewpoint.OperationTypeId  ==  AttributeName[intIndex])
{
return mstrOperationTypeId;
}
else if (convRTViewpoint.LevelId  ==  AttributeName[intIndex])
{
return mstrLevelId;
}
else if (convRTViewpoint.Conclusion  ==  AttributeName[intIndex])
{
return mstrConclusion;
}
else if (convRTViewpoint.Nationality  ==  AttributeName[intIndex])
{
return mstrNationality;
}
else if (convRTViewpoint.Achievement  ==  AttributeName[intIndex])
{
return mstrAchievement;
}
else if (convRTViewpoint.Major  ==  AttributeName[intIndex])
{
return mstrMajor;
}
else if (convRTViewpoint.WorkUnit  ==  AttributeName[intIndex])
{
return mstrWorkUnit;
}
else if (convRTViewpoint.PageNumber  ==  AttributeName[intIndex])
{
return mintPageNumber;
}
else if (convRTViewpoint.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convRTViewpoint.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convRTViewpoint.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convRTViewpoint.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convRTViewpoint.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convRTViewpoint.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convRTViewpoint.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convRTViewpoint.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (convRTViewpoint.SubViewpointTypeOrderNum  ==  AttributeName[intIndex])
{
return mintSubViewpointTypeOrderNum;
}
else if (convRTViewpoint.ProposePeople  ==  AttributeName[intIndex])
{
return mstrProposePeople;
}
else if (convRTViewpoint.gsKnowledgeTypeId  ==  AttributeName[intIndex])
{
return mstrgsKnowledgeTypeId;
}
else if (convRTViewpoint.ClassificationId  ==  AttributeName[intIndex])
{
return mlngClassificationId;
}
else if (convRTViewpoint.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convRTViewpoint.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convRTViewpoint.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convRTViewpoint.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convRTViewpoint.ViewPointUserId  ==  AttributeName[intIndex])
{
return mstrViewPointUserId;
}
else if (convRTViewpoint.ViewPointDate  ==  AttributeName[intIndex])
{
return mstrViewPointDate;
}
else if (convRTViewpoint.IsRecommend  ==  AttributeName[intIndex])
{
return mbolIsRecommend;
}
return null;
}
set
{
if (convRTViewpoint.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTViewpoint.TopicId);
}
else if (convRTViewpoint.SubViewpointId  ==  AttributeName[intIndex])
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpoint.SubViewpointId);
}
else if (convRTViewpoint.TopicName  ==  AttributeName[intIndex])
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTViewpoint.TopicName);
}
else if (convRTViewpoint.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpoint.VersionCount);
}
else if (convRTViewpoint.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpoint.CitationCount);
}
else if (convRTViewpoint.TopicContent  ==  AttributeName[intIndex])
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTViewpoint.TopicContent);
}
else if (convRTViewpoint.TopicProposePeople  ==  AttributeName[intIndex])
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convRTViewpoint.TopicProposePeople);
}
else if (convRTViewpoint.gsKnowledgeTypeName  ==  AttributeName[intIndex])
{
mstrgsKnowledgeTypeName = value.ToString();
 AddUpdatedFld(convRTViewpoint.gsKnowledgeTypeName);
}
else if (convRTViewpoint.LevelName  ==  AttributeName[intIndex])
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convRTViewpoint.LevelName);
}
else if (convRTViewpoint.OperationTypeName  ==  AttributeName[intIndex])
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(convRTViewpoint.OperationTypeName);
}
else if (convRTViewpoint.SubViewpointContent  ==  AttributeName[intIndex])
{
mstrSubViewpointContent = value.ToString();
 AddUpdatedFld(convRTViewpoint.SubViewpointContent);
}
else if (convRTViewpoint.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convRTViewpoint.PaperId);
}
else if (convRTViewpoint.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convRTViewpoint.PaperTitle);
}
else if (convRTViewpoint.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTViewpoint.IsSubmit);
}
else if (convRTViewpoint.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convRTViewpoint.SectionId);
}
else if (convRTViewpoint.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convRTViewpoint.SectionName);
}
else if (convRTViewpoint.SubViewpointTypeId  ==  AttributeName[intIndex])
{
mstrSubViewpointTypeId = value.ToString();
 AddUpdatedFld(convRTViewpoint.SubViewpointTypeId);
}
else if (convRTViewpoint.SubViewpointTypeName  ==  AttributeName[intIndex])
{
mstrSubViewpointTypeName = value.ToString();
 AddUpdatedFld(convRTViewpoint.SubViewpointTypeName);
}
else if (convRTViewpoint.ExplainTypeId  ==  AttributeName[intIndex])
{
mstrExplainTypeId = value.ToString();
 AddUpdatedFld(convRTViewpoint.ExplainTypeId);
}
else if (convRTViewpoint.ExplainTypeName  ==  AttributeName[intIndex])
{
mstrExplainTypeName = value.ToString();
 AddUpdatedFld(convRTViewpoint.ExplainTypeName);
}
else if (convRTViewpoint.ExplainContent  ==  AttributeName[intIndex])
{
mstrExplainContent = value.ToString();
 AddUpdatedFld(convRTViewpoint.ExplainContent);
}
else if (convRTViewpoint.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTViewpoint.IsPublic);
}
else if (convRTViewpoint.LiteratureSourcesId  ==  AttributeName[intIndex])
{
mstrLiteratureSourcesId = value.ToString();
 AddUpdatedFld(convRTViewpoint.LiteratureSourcesId);
}
else if (convRTViewpoint.OperationTypeId  ==  AttributeName[intIndex])
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(convRTViewpoint.OperationTypeId);
}
else if (convRTViewpoint.LevelId  ==  AttributeName[intIndex])
{
mstrLevelId = value.ToString();
 AddUpdatedFld(convRTViewpoint.LevelId);
}
else if (convRTViewpoint.Conclusion  ==  AttributeName[intIndex])
{
mstrConclusion = value.ToString();
 AddUpdatedFld(convRTViewpoint.Conclusion);
}
else if (convRTViewpoint.Nationality  ==  AttributeName[intIndex])
{
mstrNationality = value.ToString();
 AddUpdatedFld(convRTViewpoint.Nationality);
}
else if (convRTViewpoint.Achievement  ==  AttributeName[intIndex])
{
mstrAchievement = value.ToString();
 AddUpdatedFld(convRTViewpoint.Achievement);
}
else if (convRTViewpoint.Major  ==  AttributeName[intIndex])
{
mstrMajor = value.ToString();
 AddUpdatedFld(convRTViewpoint.Major);
}
else if (convRTViewpoint.WorkUnit  ==  AttributeName[intIndex])
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convRTViewpoint.WorkUnit);
}
else if (convRTViewpoint.PageNumber  ==  AttributeName[intIndex])
{
mintPageNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpoint.PageNumber);
}
else if (convRTViewpoint.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convRTViewpoint.PdfContent);
}
else if (convRTViewpoint.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpoint.AppraiseCount);
}
else if (convRTViewpoint.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpoint.OkCount);
}
else if (convRTViewpoint.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTViewpoint.Score);
}
else if (convRTViewpoint.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTViewpoint.StuScore);
}
else if (convRTViewpoint.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTViewpoint.TeaScore);
}
else if (convRTViewpoint.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convRTViewpoint.CreateDate);
}
else if (convRTViewpoint.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convRTViewpoint.ShareId);
}
else if (convRTViewpoint.SubViewpointTypeOrderNum  ==  AttributeName[intIndex])
{
mintSubViewpointTypeOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpoint.SubViewpointTypeOrderNum);
}
else if (convRTViewpoint.ProposePeople  ==  AttributeName[intIndex])
{
mstrProposePeople = value.ToString();
 AddUpdatedFld(convRTViewpoint.ProposePeople);
}
else if (convRTViewpoint.gsKnowledgeTypeId  ==  AttributeName[intIndex])
{
mstrgsKnowledgeTypeId = value.ToString();
 AddUpdatedFld(convRTViewpoint.gsKnowledgeTypeId);
}
else if (convRTViewpoint.ClassificationId  ==  AttributeName[intIndex])
{
mlngClassificationId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpoint.ClassificationId);
}
else if (convRTViewpoint.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convRTViewpoint.IdCurrEduCls);
}
else if (convRTViewpoint.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTViewpoint.UpdDate);
}
else if (convRTViewpoint.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTViewpoint.UpdUser);
}
else if (convRTViewpoint.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convRTViewpoint.Memo);
}
else if (convRTViewpoint.ViewPointUserId  ==  AttributeName[intIndex])
{
mstrViewPointUserId = value.ToString();
 AddUpdatedFld(convRTViewpoint.ViewPointUserId);
}
else if (convRTViewpoint.ViewPointDate  ==  AttributeName[intIndex])
{
mstrViewPointDate = value.ToString();
 AddUpdatedFld(convRTViewpoint.ViewPointDate);
}
else if (convRTViewpoint.IsRecommend  ==  AttributeName[intIndex])
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTViewpoint.IsRecommend);
}
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
 AddUpdatedFld(convRTViewpoint.TopicId);
}
}
/// <summary>
/// 子观点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? SubViewpointId
{
get
{
return mlngSubViewpointId;
}
set
{
 mlngSubViewpointId = value;
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.SubViewpointId);
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
 AddUpdatedFld(convRTViewpoint.TopicName);
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
 AddUpdatedFld(convRTViewpoint.VersionCount);
}
}
/// <summary>
/// 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CitationCount
{
get
{
return mintCitationCount;
}
set
{
 mintCitationCount = value;
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.CitationCount);
}
}
/// <summary>
/// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicContent
{
get
{
return mstrTopicContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicContent = value;
}
else
{
 mstrTopicContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.TopicContent);
}
}
/// <summary>
/// 主题提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicProposePeople
{
get
{
return mstrTopicProposePeople;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicProposePeople = value;
}
else
{
 mstrTopicProposePeople = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.TopicProposePeople);
}
}
/// <summary>
/// 知识类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string gsKnowledgeTypeName
{
get
{
return mstrgsKnowledgeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrgsKnowledgeTypeName = value;
}
else
{
 mstrgsKnowledgeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.gsKnowledgeTypeName);
}
}
/// <summary>
/// 级别名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LevelName
{
get
{
return mstrLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLevelName = value;
}
else
{
 mstrLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.LevelName);
}
}
/// <summary>
/// 操作类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OperationTypeName
{
get
{
return mstrOperationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOperationTypeName = value;
}
else
{
 mstrOperationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.OperationTypeName);
}
}
/// <summary>
/// 详情内容(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubViewpointContent
{
get
{
return mstrSubViewpointContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubViewpointContent = value;
}
else
{
 mstrSubViewpointContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.SubViewpointContent);
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
 AddUpdatedFld(convRTViewpoint.PaperId);
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
 AddUpdatedFld(convRTViewpoint.PaperTitle);
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
 AddUpdatedFld(convRTViewpoint.IsSubmit);
}
}
/// <summary>
/// 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionId
{
get
{
return mstrSectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionId = value;
}
else
{
 mstrSectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.SectionId);
}
}
/// <summary>
/// 节名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionName
{
get
{
return mstrSectionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionName = value;
}
else
{
 mstrSectionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.SectionName);
}
}
/// <summary>
/// 类型Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubViewpointTypeId
{
get
{
return mstrSubViewpointTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubViewpointTypeId = value;
}
else
{
 mstrSubViewpointTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.SubViewpointTypeId);
}
}
/// <summary>
/// 类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubViewpointTypeName
{
get
{
return mstrSubViewpointTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubViewpointTypeName = value;
}
else
{
 mstrSubViewpointTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.SubViewpointTypeName);
}
}
/// <summary>
/// 说明类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExplainTypeId
{
get
{
return mstrExplainTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExplainTypeId = value;
}
else
{
 mstrExplainTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.ExplainTypeId);
}
}
/// <summary>
/// 说明类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExplainTypeName
{
get
{
return mstrExplainTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExplainTypeName = value;
}
else
{
 mstrExplainTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.ExplainTypeName);
}
}
/// <summary>
/// 说明内容(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExplainContent
{
get
{
return mstrExplainContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExplainContent = value;
}
else
{
 mstrExplainContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.ExplainContent);
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
 AddUpdatedFld(convRTViewpoint.IsPublic);
}
}
/// <summary>
/// 文献来源(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiteratureSourcesId
{
get
{
return mstrLiteratureSourcesId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiteratureSourcesId = value;
}
else
{
 mstrLiteratureSourcesId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.LiteratureSourcesId);
}
}
/// <summary>
/// 操作类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OperationTypeId
{
get
{
return mstrOperationTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOperationTypeId = value;
}
else
{
 mstrOperationTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.OperationTypeId);
}
}
/// <summary>
/// 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LevelId
{
get
{
return mstrLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLevelId = value;
}
else
{
 mstrLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.LevelId);
}
}
/// <summary>
/// 结论(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Conclusion
{
get
{
return mstrConclusion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConclusion = value;
}
else
{
 mstrConclusion = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.Conclusion);
}
}
/// <summary>
/// 国籍(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Nationality
{
get
{
return mstrNationality;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNationality = value;
}
else
{
 mstrNationality = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.Nationality);
}
}
/// <summary>
/// 成就(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Achievement
{
get
{
return mstrAchievement;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAchievement = value;
}
else
{
 mstrAchievement = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.Achievement);
}
}
/// <summary>
/// 专业(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Major
{
get
{
return mstrMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajor = value;
}
else
{
 mstrMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.Major);
}
}
/// <summary>
/// 工作单位(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WorkUnit
{
get
{
return mstrWorkUnit;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWorkUnit = value;
}
else
{
 mstrWorkUnit = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.WorkUnit);
}
}
/// <summary>
/// 页码(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PageNumber
{
get
{
return mintPageNumber;
}
set
{
 mintPageNumber = value;
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.PageNumber);
}
}
/// <summary>
/// Pdf内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfContent
{
get
{
return mstrPdfContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfContent = value;
}
else
{
 mstrPdfContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.PdfContent);
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
 AddUpdatedFld(convRTViewpoint.AppraiseCount);
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
 AddUpdatedFld(convRTViewpoint.OkCount);
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
 AddUpdatedFld(convRTViewpoint.Score);
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
 AddUpdatedFld(convRTViewpoint.StuScore);
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
 AddUpdatedFld(convRTViewpoint.TeaScore);
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
 AddUpdatedFld(convRTViewpoint.CreateDate);
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
 AddUpdatedFld(convRTViewpoint.ShareId);
}
}
/// <summary>
/// 子观点类型序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SubViewpointTypeOrderNum
{
get
{
return mintSubViewpointTypeOrderNum;
}
set
{
 mintSubViewpointTypeOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.SubViewpointTypeOrderNum);
}
}
/// <summary>
/// 提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProposePeople
{
get
{
return mstrProposePeople;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProposePeople = value;
}
else
{
 mstrProposePeople = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.ProposePeople);
}
}
/// <summary>
/// 知识类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string gsKnowledgeTypeId
{
get
{
return mstrgsKnowledgeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrgsKnowledgeTypeId = value;
}
else
{
 mstrgsKnowledgeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.gsKnowledgeTypeId);
}
}
/// <summary>
/// 分类Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? ClassificationId
{
get
{
return mlngClassificationId;
}
set
{
 mlngClassificationId = value;
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.ClassificationId);
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
 AddUpdatedFld(convRTViewpoint.IdCurrEduCls);
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
 AddUpdatedFld(convRTViewpoint.UpdDate);
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
 AddUpdatedFld(convRTViewpoint.UpdUser);
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
 AddUpdatedFld(convRTViewpoint.Memo);
}
}
/// <summary>
/// 观点用户Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewPointUserId
{
get
{
return mstrViewPointUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewPointUserId = value;
}
else
{
 mstrViewPointUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.ViewPointUserId);
}
}
/// <summary>
/// 观点日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewPointDate
{
get
{
return mstrViewPointDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewPointDate = value;
}
else
{
 mstrViewPointDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.ViewPointDate);
}
}
/// <summary>
/// 是否推荐(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRecommend
{
get
{
return mbolIsRecommend;
}
set
{
 mbolIsRecommend = value;
//记录修改过的字段
 AddUpdatedFld(convRTViewpoint.IsRecommend);
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
  return mstrTopicId;
 }
 }
}
 /// <summary>
 /// vRTViewpoint(vRTViewpoint)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convRTViewpoint
{
public const string _CurrTabName = "vRTViewpoint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TopicId,SubViewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TopicId", "SubViewpointId", "TopicName", "VersionCount", "CitationCount", "TopicContent", "TopicProposePeople", "gsKnowledgeTypeName", "LevelName", "OperationTypeName", "SubViewpointContent", "PaperId", "PaperTitle", "IsSubmit", "SectionId", "SectionName", "SubViewpointTypeId", "SubViewpointTypeName", "ExplainTypeId", "ExplainTypeName", "ExplainContent", "IsPublic", "LiteratureSourcesId", "OperationTypeId", "LevelId", "Conclusion", "Nationality", "Achievement", "Major", "WorkUnit", "PageNumber", "PdfContent", "AppraiseCount", "OkCount", "Score", "StuScore", "TeaScore", "CreateDate", "ShareId", "SubViewpointTypeOrderNum", "ProposePeople", "gsKnowledgeTypeId", "ClassificationId", "IdCurrEduCls", "UpdDate", "UpdUser", "Memo", "ViewPointUserId", "ViewPointDate", "IsRecommend"};
//以下是属性变量


 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"SubViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointId = "SubViewpointId";    //子观点Id

 /// <summary>
 /// 常量:"TopicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicName = "TopicName";    //栏目主题

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"CitationCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationCount = "CitationCount";    //引用统计

 /// <summary>
 /// 常量:"TopicContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicContent = "TopicContent";    //主题内容

 /// <summary>
 /// 常量:"TopicProposePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicProposePeople = "TopicProposePeople";    //主题提出人

 /// <summary>
 /// 常量:"gsKnowledgeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string gsKnowledgeTypeName = "gsKnowledgeTypeName";    //知识类型名

 /// <summary>
 /// 常量:"LevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelName = "LevelName";    //级别名称

 /// <summary>
 /// 常量:"OperationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationTypeName = "OperationTypeName";    //操作类型名

 /// <summary>
 /// 常量:"SubViewpointContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointContent = "SubViewpointContent";    //详情内容

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
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"SectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionId = "SectionId";    //节Id

 /// <summary>
 /// 常量:"SectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionName = "SectionName";    //节名

 /// <summary>
 /// 常量:"SubViewpointTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointTypeId = "SubViewpointTypeId";    //类型Id

 /// <summary>
 /// 常量:"SubViewpointTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointTypeName = "SubViewpointTypeName";    //类型名称

 /// <summary>
 /// 常量:"ExplainTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExplainTypeId = "ExplainTypeId";    //说明类型Id

 /// <summary>
 /// 常量:"ExplainTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExplainTypeName = "ExplainTypeName";    //说明类型名

 /// <summary>
 /// 常量:"ExplainContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExplainContent = "ExplainContent";    //说明内容

 /// <summary>
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

 /// <summary>
 /// 常量:"LiteratureSourcesId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureSourcesId = "LiteratureSourcesId";    //文献来源

 /// <summary>
 /// 常量:"OperationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationTypeId = "OperationTypeId";    //操作类型ID

 /// <summary>
 /// 常量:"LevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelId = "LevelId";    //级别Id

 /// <summary>
 /// 常量:"Conclusion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Conclusion = "Conclusion";    //结论

 /// <summary>
 /// 常量:"Nationality"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Nationality = "Nationality";    //国籍

 /// <summary>
 /// 常量:"Achievement"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Achievement = "Achievement";    //成就

 /// <summary>
 /// 常量:"Major"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Major = "Major";    //专业

 /// <summary>
 /// 常量:"WorkUnit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkUnit = "WorkUnit";    //工作单位

 /// <summary>
 /// 常量:"PageNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageNumber = "PageNumber";    //页码

 /// <summary>
 /// 常量:"PdfContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfContent = "PdfContent";    //Pdf内容

 /// <summary>
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

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
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"ShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareId = "ShareId";    //分享Id

 /// <summary>
 /// 常量:"SubViewpointTypeOrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointTypeOrderNum = "SubViewpointTypeOrderNum";    //子观点类型序号

 /// <summary>
 /// 常量:"ProposePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProposePeople = "ProposePeople";    //提出人

 /// <summary>
 /// 常量:"gsKnowledgeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string gsKnowledgeTypeId = "gsKnowledgeTypeId";    //知识类型Id

 /// <summary>
 /// 常量:"ClassificationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassificationId = "ClassificationId";    //分类Id

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"ViewPointUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewPointUserId = "ViewPointUserId";    //观点用户Id

 /// <summary>
 /// 常量:"ViewPointDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewPointDate = "ViewPointDate";    //观点日期

 /// <summary>
 /// 常量:"IsRecommend"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRecommend = "IsRecommend";    //是否推荐
}

}