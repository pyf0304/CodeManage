
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSubViewpointEN
 表名:vPaperSubViewpoint(01120551)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:21:44
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 表vPaperSubViewpoint的关键字(SubViewpointId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SubViewpointId_vPaperSubViewpoint
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngSubViewpointId">表关键字</param>
public K_SubViewpointId_vPaperSubViewpoint(long lngSubViewpointId)
{
if (IsValid(lngSubViewpointId)) Value = lngSubViewpointId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngSubViewpointId)
{
if (lngSubViewpointId == 0) return false;
if (lngSubViewpointId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SubViewpointId_vPaperSubViewpoint]类型的对象</returns>
public static implicit operator K_SubViewpointId_vPaperSubViewpoint(long value)
{
return new K_SubViewpointId_vPaperSubViewpoint(value);
}
}
 /// <summary>
 /// v子观点表(vPaperSubViewpoint)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPaperSubViewpointEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPaperSubViewpoint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SubViewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 54;
public static string[] AttributeName = new string[] {"SubViewpointId", "SubViewpointContent", "PaperRWId", "PaperId", "PaperTitle", "IsSubmit", "IdCurrEduCls", "UserId", "SectionId", "SectionName", "SubViewpointTypeId", "SubViewpointTypeName", "DefaTitle", "gsKnowledgeTypeId", "RWTitle", "ExplainTypeId", "ExplainTypeName", "ExplainContent", "IsPublic", "LiteratureSourcesId", "OperationTypeId", "LevelId", "Conclusion", "Nationality", "Achievement", "Major", "WorkUnit", "PageNumber", "OrderNum", "PdfContent", "selectSpanRange", "PaperLineNum", "PaperPageNum", "AppraiseCount", "OkCount", "Score", "StuScore", "TeaScore", "CreateDate", "ShareId", "AttitudesId", "AttitudesName", "UpdDate", "UpdUser", "Memo", "SectionOrderNum", "SubViewpointTypeOrderNum", "CitationCount", "VersionCount", "IsRecommend", "gsKnowledgeTypeName", "LevelName", "OperationTypeName", "CourseId"};

protected long mlngSubViewpointId;    //子观点Id
protected string mstrSubViewpointContent;    //详情内容
protected string mstrPaperRWId;    //课文阅读
protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected bool mbolIsSubmit;    //是否提交
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrUserId;    //用户ID
protected string mstrSectionId;    //节Id
protected string mstrSectionName;    //节名
protected string mstrSubViewpointTypeId;    //类型Id
protected string mstrSubViewpointTypeName;    //类型名称
protected string mstrDefaTitle;    //默认标题
protected string mstrgsKnowledgeTypeId;    //知识类型Id
protected string mstrRWTitle;    //读写标题
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
protected int? mintOrderNum;    //序号
protected string mstrPdfContent;    //Pdf内容
protected string mstrselectSpanRange;    //选择Span范围
protected int? mintPaperLineNum;    //论文行号
protected int? mintPaperPageNum;    //论文页码
protected int? mintAppraiseCount;    //评论数
protected int? mintOkCount;    //点赞统计
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id
protected string mstrAttitudesId;    //态度Id
protected string mstrAttitudesName;    //名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected int? mintSectionOrderNum;    //SectionOrderNum
protected int? mintSubViewpointTypeOrderNum;    //子观点类型序号
protected int? mintCitationCount;    //引用统计
protected int? mintVersionCount;    //版本统计
protected bool mbolIsRecommend;    //是否推荐
protected string mstrgsKnowledgeTypeName;    //知识类型名
protected string mstrLevelName;    //级别名称
protected string mstrOperationTypeName;    //操作类型名
protected string mstrCourseId;    //课程Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPaperSubViewpointEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SubViewpointId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngSubViewpointId">关键字:子观点Id</param>
public clsvPaperSubViewpointEN(long lngSubViewpointId)
 {
 if (lngSubViewpointId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngSubViewpointId = lngSubViewpointId;
 SetInit();
 mbolIsCheckProperty = false;
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
if (strAttributeName  ==  convPaperSubViewpoint.SubViewpointId)
{
return mlngSubViewpointId;
}
else if (strAttributeName  ==  convPaperSubViewpoint.SubViewpointContent)
{
return mstrSubViewpointContent;
}
else if (strAttributeName  ==  convPaperSubViewpoint.PaperRWId)
{
return mstrPaperRWId;
}
else if (strAttributeName  ==  convPaperSubViewpoint.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convPaperSubViewpoint.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convPaperSubViewpoint.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convPaperSubViewpoint.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convPaperSubViewpoint.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convPaperSubViewpoint.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convPaperSubViewpoint.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convPaperSubViewpoint.SubViewpointTypeId)
{
return mstrSubViewpointTypeId;
}
else if (strAttributeName  ==  convPaperSubViewpoint.SubViewpointTypeName)
{
return mstrSubViewpointTypeName;
}
else if (strAttributeName  ==  convPaperSubViewpoint.DefaTitle)
{
return mstrDefaTitle;
}
else if (strAttributeName  ==  convPaperSubViewpoint.gsKnowledgeTypeId)
{
return mstrgsKnowledgeTypeId;
}
else if (strAttributeName  ==  convPaperSubViewpoint.RWTitle)
{
return mstrRWTitle;
}
else if (strAttributeName  ==  convPaperSubViewpoint.ExplainTypeId)
{
return mstrExplainTypeId;
}
else if (strAttributeName  ==  convPaperSubViewpoint.ExplainTypeName)
{
return mstrExplainTypeName;
}
else if (strAttributeName  ==  convPaperSubViewpoint.ExplainContent)
{
return mstrExplainContent;
}
else if (strAttributeName  ==  convPaperSubViewpoint.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convPaperSubViewpoint.LiteratureSourcesId)
{
return mstrLiteratureSourcesId;
}
else if (strAttributeName  ==  convPaperSubViewpoint.OperationTypeId)
{
return mstrOperationTypeId;
}
else if (strAttributeName  ==  convPaperSubViewpoint.LevelId)
{
return mstrLevelId;
}
else if (strAttributeName  ==  convPaperSubViewpoint.Conclusion)
{
return mstrConclusion;
}
else if (strAttributeName  ==  convPaperSubViewpoint.Nationality)
{
return mstrNationality;
}
else if (strAttributeName  ==  convPaperSubViewpoint.Achievement)
{
return mstrAchievement;
}
else if (strAttributeName  ==  convPaperSubViewpoint.Major)
{
return mstrMajor;
}
else if (strAttributeName  ==  convPaperSubViewpoint.WorkUnit)
{
return mstrWorkUnit;
}
else if (strAttributeName  ==  convPaperSubViewpoint.PageNumber)
{
return mintPageNumber;
}
else if (strAttributeName  ==  convPaperSubViewpoint.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convPaperSubViewpoint.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convPaperSubViewpoint.selectSpanRange)
{
return mstrselectSpanRange;
}
else if (strAttributeName  ==  convPaperSubViewpoint.PaperLineNum)
{
return mintPaperLineNum;
}
else if (strAttributeName  ==  convPaperSubViewpoint.PaperPageNum)
{
return mintPaperPageNum;
}
else if (strAttributeName  ==  convPaperSubViewpoint.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convPaperSubViewpoint.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convPaperSubViewpoint.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convPaperSubViewpoint.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convPaperSubViewpoint.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convPaperSubViewpoint.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convPaperSubViewpoint.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  convPaperSubViewpoint.AttitudesId)
{
return mstrAttitudesId;
}
else if (strAttributeName  ==  convPaperSubViewpoint.AttitudesName)
{
return mstrAttitudesName;
}
else if (strAttributeName  ==  convPaperSubViewpoint.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPaperSubViewpoint.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convPaperSubViewpoint.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPaperSubViewpoint.SectionOrderNum)
{
return mintSectionOrderNum;
}
else if (strAttributeName  ==  convPaperSubViewpoint.SubViewpointTypeOrderNum)
{
return mintSubViewpointTypeOrderNum;
}
else if (strAttributeName  ==  convPaperSubViewpoint.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convPaperSubViewpoint.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convPaperSubViewpoint.IsRecommend)
{
return mbolIsRecommend;
}
else if (strAttributeName  ==  convPaperSubViewpoint.gsKnowledgeTypeName)
{
return mstrgsKnowledgeTypeName;
}
else if (strAttributeName  ==  convPaperSubViewpoint.LevelName)
{
return mstrLevelName;
}
else if (strAttributeName  ==  convPaperSubViewpoint.OperationTypeName)
{
return mstrOperationTypeName;
}
else if (strAttributeName  ==  convPaperSubViewpoint.CourseId)
{
return mstrCourseId;
}
return null;
}
set
{
if (strAttributeName  ==  convPaperSubViewpoint.SubViewpointId)
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.SubViewpointId);
}
else if (strAttributeName  ==  convPaperSubViewpoint.SubViewpointContent)
{
mstrSubViewpointContent = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.SubViewpointContent);
}
else if (strAttributeName  ==  convPaperSubViewpoint.PaperRWId)
{
mstrPaperRWId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.PaperRWId);
}
else if (strAttributeName  ==  convPaperSubViewpoint.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.PaperId);
}
else if (strAttributeName  ==  convPaperSubViewpoint.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.PaperTitle);
}
else if (strAttributeName  ==  convPaperSubViewpoint.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.IsSubmit);
}
else if (strAttributeName  ==  convPaperSubViewpoint.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.IdCurrEduCls);
}
else if (strAttributeName  ==  convPaperSubViewpoint.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.UserId);
}
else if (strAttributeName  ==  convPaperSubViewpoint.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.SectionId);
}
else if (strAttributeName  ==  convPaperSubViewpoint.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.SectionName);
}
else if (strAttributeName  ==  convPaperSubViewpoint.SubViewpointTypeId)
{
mstrSubViewpointTypeId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.SubViewpointTypeId);
}
else if (strAttributeName  ==  convPaperSubViewpoint.SubViewpointTypeName)
{
mstrSubViewpointTypeName = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.SubViewpointTypeName);
}
else if (strAttributeName  ==  convPaperSubViewpoint.DefaTitle)
{
mstrDefaTitle = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.DefaTitle);
}
else if (strAttributeName  ==  convPaperSubViewpoint.gsKnowledgeTypeId)
{
mstrgsKnowledgeTypeId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.gsKnowledgeTypeId);
}
else if (strAttributeName  ==  convPaperSubViewpoint.RWTitle)
{
mstrRWTitle = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.RWTitle);
}
else if (strAttributeName  ==  convPaperSubViewpoint.ExplainTypeId)
{
mstrExplainTypeId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.ExplainTypeId);
}
else if (strAttributeName  ==  convPaperSubViewpoint.ExplainTypeName)
{
mstrExplainTypeName = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.ExplainTypeName);
}
else if (strAttributeName  ==  convPaperSubViewpoint.ExplainContent)
{
mstrExplainContent = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.ExplainContent);
}
else if (strAttributeName  ==  convPaperSubViewpoint.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.IsPublic);
}
else if (strAttributeName  ==  convPaperSubViewpoint.LiteratureSourcesId)
{
mstrLiteratureSourcesId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.LiteratureSourcesId);
}
else if (strAttributeName  ==  convPaperSubViewpoint.OperationTypeId)
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.OperationTypeId);
}
else if (strAttributeName  ==  convPaperSubViewpoint.LevelId)
{
mstrLevelId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.LevelId);
}
else if (strAttributeName  ==  convPaperSubViewpoint.Conclusion)
{
mstrConclusion = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.Conclusion);
}
else if (strAttributeName  ==  convPaperSubViewpoint.Nationality)
{
mstrNationality = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.Nationality);
}
else if (strAttributeName  ==  convPaperSubViewpoint.Achievement)
{
mstrAchievement = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.Achievement);
}
else if (strAttributeName  ==  convPaperSubViewpoint.Major)
{
mstrMajor = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.Major);
}
else if (strAttributeName  ==  convPaperSubViewpoint.WorkUnit)
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.WorkUnit);
}
else if (strAttributeName  ==  convPaperSubViewpoint.PageNumber)
{
mintPageNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.PageNumber);
}
else if (strAttributeName  ==  convPaperSubViewpoint.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.OrderNum);
}
else if (strAttributeName  ==  convPaperSubViewpoint.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.PdfContent);
}
else if (strAttributeName  ==  convPaperSubViewpoint.selectSpanRange)
{
mstrselectSpanRange = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.selectSpanRange);
}
else if (strAttributeName  ==  convPaperSubViewpoint.PaperLineNum)
{
mintPaperLineNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.PaperLineNum);
}
else if (strAttributeName  ==  convPaperSubViewpoint.PaperPageNum)
{
mintPaperPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.PaperPageNum);
}
else if (strAttributeName  ==  convPaperSubViewpoint.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.AppraiseCount);
}
else if (strAttributeName  ==  convPaperSubViewpoint.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.OkCount);
}
else if (strAttributeName  ==  convPaperSubViewpoint.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.Score);
}
else if (strAttributeName  ==  convPaperSubViewpoint.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.StuScore);
}
else if (strAttributeName  ==  convPaperSubViewpoint.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.TeaScore);
}
else if (strAttributeName  ==  convPaperSubViewpoint.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.CreateDate);
}
else if (strAttributeName  ==  convPaperSubViewpoint.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.ShareId);
}
else if (strAttributeName  ==  convPaperSubViewpoint.AttitudesId)
{
mstrAttitudesId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.AttitudesId);
}
else if (strAttributeName  ==  convPaperSubViewpoint.AttitudesName)
{
mstrAttitudesName = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.AttitudesName);
}
else if (strAttributeName  ==  convPaperSubViewpoint.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.UpdDate);
}
else if (strAttributeName  ==  convPaperSubViewpoint.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.UpdUser);
}
else if (strAttributeName  ==  convPaperSubViewpoint.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.Memo);
}
else if (strAttributeName  ==  convPaperSubViewpoint.SectionOrderNum)
{
mintSectionOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.SectionOrderNum);
}
else if (strAttributeName  ==  convPaperSubViewpoint.SubViewpointTypeOrderNum)
{
mintSubViewpointTypeOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.SubViewpointTypeOrderNum);
}
else if (strAttributeName  ==  convPaperSubViewpoint.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.CitationCount);
}
else if (strAttributeName  ==  convPaperSubViewpoint.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.VersionCount);
}
else if (strAttributeName  ==  convPaperSubViewpoint.IsRecommend)
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.IsRecommend);
}
else if (strAttributeName  ==  convPaperSubViewpoint.gsKnowledgeTypeName)
{
mstrgsKnowledgeTypeName = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.gsKnowledgeTypeName);
}
else if (strAttributeName  ==  convPaperSubViewpoint.LevelName)
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.LevelName);
}
else if (strAttributeName  ==  convPaperSubViewpoint.OperationTypeName)
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.OperationTypeName);
}
else if (strAttributeName  ==  convPaperSubViewpoint.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.CourseId);
}
}
}
public object this[int intIndex]
{
get
{
if (convPaperSubViewpoint.SubViewpointId  ==  AttributeName[intIndex])
{
return mlngSubViewpointId;
}
else if (convPaperSubViewpoint.SubViewpointContent  ==  AttributeName[intIndex])
{
return mstrSubViewpointContent;
}
else if (convPaperSubViewpoint.PaperRWId  ==  AttributeName[intIndex])
{
return mstrPaperRWId;
}
else if (convPaperSubViewpoint.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convPaperSubViewpoint.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convPaperSubViewpoint.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convPaperSubViewpoint.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convPaperSubViewpoint.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convPaperSubViewpoint.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convPaperSubViewpoint.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convPaperSubViewpoint.SubViewpointTypeId  ==  AttributeName[intIndex])
{
return mstrSubViewpointTypeId;
}
else if (convPaperSubViewpoint.SubViewpointTypeName  ==  AttributeName[intIndex])
{
return mstrSubViewpointTypeName;
}
else if (convPaperSubViewpoint.DefaTitle  ==  AttributeName[intIndex])
{
return mstrDefaTitle;
}
else if (convPaperSubViewpoint.gsKnowledgeTypeId  ==  AttributeName[intIndex])
{
return mstrgsKnowledgeTypeId;
}
else if (convPaperSubViewpoint.RWTitle  ==  AttributeName[intIndex])
{
return mstrRWTitle;
}
else if (convPaperSubViewpoint.ExplainTypeId  ==  AttributeName[intIndex])
{
return mstrExplainTypeId;
}
else if (convPaperSubViewpoint.ExplainTypeName  ==  AttributeName[intIndex])
{
return mstrExplainTypeName;
}
else if (convPaperSubViewpoint.ExplainContent  ==  AttributeName[intIndex])
{
return mstrExplainContent;
}
else if (convPaperSubViewpoint.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convPaperSubViewpoint.LiteratureSourcesId  ==  AttributeName[intIndex])
{
return mstrLiteratureSourcesId;
}
else if (convPaperSubViewpoint.OperationTypeId  ==  AttributeName[intIndex])
{
return mstrOperationTypeId;
}
else if (convPaperSubViewpoint.LevelId  ==  AttributeName[intIndex])
{
return mstrLevelId;
}
else if (convPaperSubViewpoint.Conclusion  ==  AttributeName[intIndex])
{
return mstrConclusion;
}
else if (convPaperSubViewpoint.Nationality  ==  AttributeName[intIndex])
{
return mstrNationality;
}
else if (convPaperSubViewpoint.Achievement  ==  AttributeName[intIndex])
{
return mstrAchievement;
}
else if (convPaperSubViewpoint.Major  ==  AttributeName[intIndex])
{
return mstrMajor;
}
else if (convPaperSubViewpoint.WorkUnit  ==  AttributeName[intIndex])
{
return mstrWorkUnit;
}
else if (convPaperSubViewpoint.PageNumber  ==  AttributeName[intIndex])
{
return mintPageNumber;
}
else if (convPaperSubViewpoint.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convPaperSubViewpoint.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convPaperSubViewpoint.selectSpanRange  ==  AttributeName[intIndex])
{
return mstrselectSpanRange;
}
else if (convPaperSubViewpoint.PaperLineNum  ==  AttributeName[intIndex])
{
return mintPaperLineNum;
}
else if (convPaperSubViewpoint.PaperPageNum  ==  AttributeName[intIndex])
{
return mintPaperPageNum;
}
else if (convPaperSubViewpoint.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convPaperSubViewpoint.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convPaperSubViewpoint.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convPaperSubViewpoint.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convPaperSubViewpoint.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convPaperSubViewpoint.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convPaperSubViewpoint.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (convPaperSubViewpoint.AttitudesId  ==  AttributeName[intIndex])
{
return mstrAttitudesId;
}
else if (convPaperSubViewpoint.AttitudesName  ==  AttributeName[intIndex])
{
return mstrAttitudesName;
}
else if (convPaperSubViewpoint.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPaperSubViewpoint.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convPaperSubViewpoint.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPaperSubViewpoint.SectionOrderNum  ==  AttributeName[intIndex])
{
return mintSectionOrderNum;
}
else if (convPaperSubViewpoint.SubViewpointTypeOrderNum  ==  AttributeName[intIndex])
{
return mintSubViewpointTypeOrderNum;
}
else if (convPaperSubViewpoint.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convPaperSubViewpoint.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convPaperSubViewpoint.IsRecommend  ==  AttributeName[intIndex])
{
return mbolIsRecommend;
}
else if (convPaperSubViewpoint.gsKnowledgeTypeName  ==  AttributeName[intIndex])
{
return mstrgsKnowledgeTypeName;
}
else if (convPaperSubViewpoint.LevelName  ==  AttributeName[intIndex])
{
return mstrLevelName;
}
else if (convPaperSubViewpoint.OperationTypeName  ==  AttributeName[intIndex])
{
return mstrOperationTypeName;
}
else if (convPaperSubViewpoint.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
return null;
}
set
{
if (convPaperSubViewpoint.SubViewpointId  ==  AttributeName[intIndex])
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.SubViewpointId);
}
else if (convPaperSubViewpoint.SubViewpointContent  ==  AttributeName[intIndex])
{
mstrSubViewpointContent = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.SubViewpointContent);
}
else if (convPaperSubViewpoint.PaperRWId  ==  AttributeName[intIndex])
{
mstrPaperRWId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.PaperRWId);
}
else if (convPaperSubViewpoint.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.PaperId);
}
else if (convPaperSubViewpoint.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.PaperTitle);
}
else if (convPaperSubViewpoint.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.IsSubmit);
}
else if (convPaperSubViewpoint.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.IdCurrEduCls);
}
else if (convPaperSubViewpoint.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.UserId);
}
else if (convPaperSubViewpoint.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.SectionId);
}
else if (convPaperSubViewpoint.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.SectionName);
}
else if (convPaperSubViewpoint.SubViewpointTypeId  ==  AttributeName[intIndex])
{
mstrSubViewpointTypeId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.SubViewpointTypeId);
}
else if (convPaperSubViewpoint.SubViewpointTypeName  ==  AttributeName[intIndex])
{
mstrSubViewpointTypeName = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.SubViewpointTypeName);
}
else if (convPaperSubViewpoint.DefaTitle  ==  AttributeName[intIndex])
{
mstrDefaTitle = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.DefaTitle);
}
else if (convPaperSubViewpoint.gsKnowledgeTypeId  ==  AttributeName[intIndex])
{
mstrgsKnowledgeTypeId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.gsKnowledgeTypeId);
}
else if (convPaperSubViewpoint.RWTitle  ==  AttributeName[intIndex])
{
mstrRWTitle = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.RWTitle);
}
else if (convPaperSubViewpoint.ExplainTypeId  ==  AttributeName[intIndex])
{
mstrExplainTypeId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.ExplainTypeId);
}
else if (convPaperSubViewpoint.ExplainTypeName  ==  AttributeName[intIndex])
{
mstrExplainTypeName = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.ExplainTypeName);
}
else if (convPaperSubViewpoint.ExplainContent  ==  AttributeName[intIndex])
{
mstrExplainContent = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.ExplainContent);
}
else if (convPaperSubViewpoint.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.IsPublic);
}
else if (convPaperSubViewpoint.LiteratureSourcesId  ==  AttributeName[intIndex])
{
mstrLiteratureSourcesId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.LiteratureSourcesId);
}
else if (convPaperSubViewpoint.OperationTypeId  ==  AttributeName[intIndex])
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.OperationTypeId);
}
else if (convPaperSubViewpoint.LevelId  ==  AttributeName[intIndex])
{
mstrLevelId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.LevelId);
}
else if (convPaperSubViewpoint.Conclusion  ==  AttributeName[intIndex])
{
mstrConclusion = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.Conclusion);
}
else if (convPaperSubViewpoint.Nationality  ==  AttributeName[intIndex])
{
mstrNationality = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.Nationality);
}
else if (convPaperSubViewpoint.Achievement  ==  AttributeName[intIndex])
{
mstrAchievement = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.Achievement);
}
else if (convPaperSubViewpoint.Major  ==  AttributeName[intIndex])
{
mstrMajor = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.Major);
}
else if (convPaperSubViewpoint.WorkUnit  ==  AttributeName[intIndex])
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.WorkUnit);
}
else if (convPaperSubViewpoint.PageNumber  ==  AttributeName[intIndex])
{
mintPageNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.PageNumber);
}
else if (convPaperSubViewpoint.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.OrderNum);
}
else if (convPaperSubViewpoint.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.PdfContent);
}
else if (convPaperSubViewpoint.selectSpanRange  ==  AttributeName[intIndex])
{
mstrselectSpanRange = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.selectSpanRange);
}
else if (convPaperSubViewpoint.PaperLineNum  ==  AttributeName[intIndex])
{
mintPaperLineNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.PaperLineNum);
}
else if (convPaperSubViewpoint.PaperPageNum  ==  AttributeName[intIndex])
{
mintPaperPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.PaperPageNum);
}
else if (convPaperSubViewpoint.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.AppraiseCount);
}
else if (convPaperSubViewpoint.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.OkCount);
}
else if (convPaperSubViewpoint.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.Score);
}
else if (convPaperSubViewpoint.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.StuScore);
}
else if (convPaperSubViewpoint.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.TeaScore);
}
else if (convPaperSubViewpoint.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.CreateDate);
}
else if (convPaperSubViewpoint.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.ShareId);
}
else if (convPaperSubViewpoint.AttitudesId  ==  AttributeName[intIndex])
{
mstrAttitudesId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.AttitudesId);
}
else if (convPaperSubViewpoint.AttitudesName  ==  AttributeName[intIndex])
{
mstrAttitudesName = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.AttitudesName);
}
else if (convPaperSubViewpoint.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.UpdDate);
}
else if (convPaperSubViewpoint.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.UpdUser);
}
else if (convPaperSubViewpoint.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.Memo);
}
else if (convPaperSubViewpoint.SectionOrderNum  ==  AttributeName[intIndex])
{
mintSectionOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.SectionOrderNum);
}
else if (convPaperSubViewpoint.SubViewpointTypeOrderNum  ==  AttributeName[intIndex])
{
mintSubViewpointTypeOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.SubViewpointTypeOrderNum);
}
else if (convPaperSubViewpoint.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.CitationCount);
}
else if (convPaperSubViewpoint.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.VersionCount);
}
else if (convPaperSubViewpoint.IsRecommend  ==  AttributeName[intIndex])
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaperSubViewpoint.IsRecommend);
}
else if (convPaperSubViewpoint.gsKnowledgeTypeName  ==  AttributeName[intIndex])
{
mstrgsKnowledgeTypeName = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.gsKnowledgeTypeName);
}
else if (convPaperSubViewpoint.LevelName  ==  AttributeName[intIndex])
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.LevelName);
}
else if (convPaperSubViewpoint.OperationTypeName  ==  AttributeName[intIndex])
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.OperationTypeName);
}
else if (convPaperSubViewpoint.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convPaperSubViewpoint.CourseId);
}
}
}

/// <summary>
/// 子观点Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long SubViewpointId
{
get
{
return mlngSubViewpointId;
}
set
{
 mlngSubViewpointId = value;
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpoint.SubViewpointId);
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
 AddUpdatedFld(convPaperSubViewpoint.SubViewpointContent);
}
}
/// <summary>
/// 课文阅读(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperRWId
{
get
{
return mstrPaperRWId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperRWId = value;
}
else
{
 mstrPaperRWId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpoint.PaperRWId);
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
 AddUpdatedFld(convPaperSubViewpoint.PaperId);
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
 AddUpdatedFld(convPaperSubViewpoint.PaperTitle);
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
 AddUpdatedFld(convPaperSubViewpoint.IsSubmit);
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
 AddUpdatedFld(convPaperSubViewpoint.IdCurrEduCls);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpoint.UserId);
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
 AddUpdatedFld(convPaperSubViewpoint.SectionId);
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
 AddUpdatedFld(convPaperSubViewpoint.SectionName);
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
 AddUpdatedFld(convPaperSubViewpoint.SubViewpointTypeId);
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
 AddUpdatedFld(convPaperSubViewpoint.SubViewpointTypeName);
}
}
/// <summary>
/// 默认标题(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaTitle
{
get
{
return mstrDefaTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaTitle = value;
}
else
{
 mstrDefaTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpoint.DefaTitle);
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
 AddUpdatedFld(convPaperSubViewpoint.gsKnowledgeTypeId);
}
}
/// <summary>
/// 读写标题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RWTitle
{
get
{
return mstrRWTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRWTitle = value;
}
else
{
 mstrRWTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpoint.RWTitle);
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
 AddUpdatedFld(convPaperSubViewpoint.ExplainTypeId);
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
 AddUpdatedFld(convPaperSubViewpoint.ExplainTypeName);
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
 AddUpdatedFld(convPaperSubViewpoint.ExplainContent);
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
 AddUpdatedFld(convPaperSubViewpoint.IsPublic);
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
 AddUpdatedFld(convPaperSubViewpoint.LiteratureSourcesId);
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
 AddUpdatedFld(convPaperSubViewpoint.OperationTypeId);
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
 AddUpdatedFld(convPaperSubViewpoint.LevelId);
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
 AddUpdatedFld(convPaperSubViewpoint.Conclusion);
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
 AddUpdatedFld(convPaperSubViewpoint.Nationality);
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
 AddUpdatedFld(convPaperSubViewpoint.Achievement);
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
 AddUpdatedFld(convPaperSubViewpoint.Major);
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
 AddUpdatedFld(convPaperSubViewpoint.WorkUnit);
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
 AddUpdatedFld(convPaperSubViewpoint.PageNumber);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpoint.OrderNum);
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
 AddUpdatedFld(convPaperSubViewpoint.PdfContent);
}
}
/// <summary>
/// 选择Span范围(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string selectSpanRange
{
get
{
return mstrselectSpanRange;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrselectSpanRange = value;
}
else
{
 mstrselectSpanRange = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpoint.selectSpanRange);
}
}
/// <summary>
/// 论文行号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PaperLineNum
{
get
{
return mintPaperLineNum;
}
set
{
 mintPaperLineNum = value;
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpoint.PaperLineNum);
}
}
/// <summary>
/// 论文页码(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PaperPageNum
{
get
{
return mintPaperPageNum;
}
set
{
 mintPaperPageNum = value;
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpoint.PaperPageNum);
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
 AddUpdatedFld(convPaperSubViewpoint.AppraiseCount);
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
 AddUpdatedFld(convPaperSubViewpoint.OkCount);
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
 AddUpdatedFld(convPaperSubViewpoint.Score);
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
 AddUpdatedFld(convPaperSubViewpoint.StuScore);
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
 AddUpdatedFld(convPaperSubViewpoint.TeaScore);
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
 AddUpdatedFld(convPaperSubViewpoint.CreateDate);
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
 AddUpdatedFld(convPaperSubViewpoint.ShareId);
}
}
/// <summary>
/// 态度Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AttitudesId
{
get
{
return mstrAttitudesId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAttitudesId = value;
}
else
{
 mstrAttitudesId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpoint.AttitudesId);
}
}
/// <summary>
/// 名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AttitudesName
{
get
{
return mstrAttitudesName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAttitudesName = value;
}
else
{
 mstrAttitudesName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpoint.AttitudesName);
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
 AddUpdatedFld(convPaperSubViewpoint.UpdDate);
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
 AddUpdatedFld(convPaperSubViewpoint.UpdUser);
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
 AddUpdatedFld(convPaperSubViewpoint.Memo);
}
}
/// <summary>
/// SectionOrderNum(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SectionOrderNum
{
get
{
return mintSectionOrderNum;
}
set
{
 mintSectionOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpoint.SectionOrderNum);
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
 AddUpdatedFld(convPaperSubViewpoint.SubViewpointTypeOrderNum);
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
 AddUpdatedFld(convPaperSubViewpoint.CitationCount);
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
 AddUpdatedFld(convPaperSubViewpoint.VersionCount);
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
 AddUpdatedFld(convPaperSubViewpoint.IsRecommend);
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
 AddUpdatedFld(convPaperSubViewpoint.gsKnowledgeTypeName);
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
 AddUpdatedFld(convPaperSubViewpoint.LevelName);
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
 AddUpdatedFld(convPaperSubViewpoint.OperationTypeName);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperSubViewpoint.CourseId);
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
  return mlngSubViewpointId.ToString();
 }
 }
}
 /// <summary>
 /// v子观点表(vPaperSubViewpoint)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPaperSubViewpoint
{
public const string _CurrTabName = "vPaperSubViewpoint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SubViewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SubViewpointId", "SubViewpointContent", "PaperRWId", "PaperId", "PaperTitle", "IsSubmit", "IdCurrEduCls", "UserId", "SectionId", "SectionName", "SubViewpointTypeId", "SubViewpointTypeName", "DefaTitle", "gsKnowledgeTypeId", "RWTitle", "ExplainTypeId", "ExplainTypeName", "ExplainContent", "IsPublic", "LiteratureSourcesId", "OperationTypeId", "LevelId", "Conclusion", "Nationality", "Achievement", "Major", "WorkUnit", "PageNumber", "OrderNum", "PdfContent", "selectSpanRange", "PaperLineNum", "PaperPageNum", "AppraiseCount", "OkCount", "Score", "StuScore", "TeaScore", "CreateDate", "ShareId", "AttitudesId", "AttitudesName", "UpdDate", "UpdUser", "Memo", "SectionOrderNum", "SubViewpointTypeOrderNum", "CitationCount", "VersionCount", "IsRecommend", "gsKnowledgeTypeName", "LevelName", "OperationTypeName", "CourseId"};
//以下是属性变量


 /// <summary>
 /// 常量:"SubViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointId = "SubViewpointId";    //子观点Id

 /// <summary>
 /// 常量:"SubViewpointContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointContent = "SubViewpointContent";    //详情内容

 /// <summary>
 /// 常量:"PaperRWId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperRWId = "PaperRWId";    //课文阅读

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
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

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
 /// 常量:"DefaTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaTitle = "DefaTitle";    //默认标题

 /// <summary>
 /// 常量:"gsKnowledgeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string gsKnowledgeTypeId = "gsKnowledgeTypeId";    //知识类型Id

 /// <summary>
 /// 常量:"RWTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RWTitle = "RWTitle";    //读写标题

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
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"PdfContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfContent = "PdfContent";    //Pdf内容

 /// <summary>
 /// 常量:"selectSpanRange"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string selectSpanRange = "selectSpanRange";    //选择Span范围

 /// <summary>
 /// 常量:"PaperLineNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperLineNum = "PaperLineNum";    //论文行号

 /// <summary>
 /// 常量:"PaperPageNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperPageNum = "PaperPageNum";    //论文页码

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
 /// 常量:"AttitudesId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttitudesId = "AttitudesId";    //态度Id

 /// <summary>
 /// 常量:"AttitudesName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttitudesName = "AttitudesName";    //名称

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
 /// 常量:"SectionOrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionOrderNum = "SectionOrderNum";    //SectionOrderNum

 /// <summary>
 /// 常量:"SubViewpointTypeOrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointTypeOrderNum = "SubViewpointTypeOrderNum";    //子观点类型序号

 /// <summary>
 /// 常量:"CitationCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationCount = "CitationCount";    //引用统计

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"IsRecommend"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRecommend = "IsRecommend";    //是否推荐

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
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id
}

}