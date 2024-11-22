
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperSubViewpointEN
 表名:PaperSubViewpoint(01120534)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:36
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
 /// 表PaperSubViewpoint的关键字(SubViewpointId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SubViewpointId_PaperSubViewpoint
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
public K_SubViewpointId_PaperSubViewpoint(long lngSubViewpointId)
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
 /// <returns>返回:[K_SubViewpointId_PaperSubViewpoint]类型的对象</returns>
public static implicit operator K_SubViewpointId_PaperSubViewpoint(long value)
{
return new K_SubViewpointId_PaperSubViewpoint(value);
}
}
 /// <summary>
 /// 子观点表(PaperSubViewpoint)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPaperSubViewpointEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PaperSubViewpoint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SubViewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 43;
public static string[] AttributeName = new string[] {"SubViewpointId", "SubViewpointContent", "PaperRWId", "PaperId", "IdCurrEduCls", "UserId", "SectionId", "SubViewpointTypeId", "gsKnowledgeTypeId", "RWTitle", "ExplainTypeId", "ExplainContent", "IsPublic", "LiteratureSourcesId", "OperationTypeId", "LevelId", "Conclusion", "Nationality", "Achievement", "Major", "WorkUnit", "PageNumber", "OrderNum", "PdfContent", "selectSpanRange", "PaperLineNum", "PaperPageNum", "AppraiseCount", "OkCount", "Score", "StuScore", "TeaScore", "CreateDate", "ShareId", "TopicId", "AttitudesId", "VersionCount", "CitationCount", "CourseId", "IsRecommend", "UpdDate", "UpdUser", "Memo"};

protected long mlngSubViewpointId;    //子观点Id
protected string mstrSubViewpointContent;    //详情内容
protected string mstrPaperRWId;    //课文阅读
protected string mstrPaperId;    //论文Id
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrUserId;    //用户ID
protected string mstrSectionId;    //节Id
protected string mstrSubViewpointTypeId;    //类型Id
protected string mstrgsKnowledgeTypeId;    //知识类型Id
protected string mstrRWTitle;    //读写标题
protected string mstrExplainTypeId;    //说明类型Id
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
protected string mstrTopicId;    //主题Id
protected string mstrAttitudesId;    //态度Id
protected int? mintVersionCount;    //版本统计
protected int? mintCitationCount;    //引用统计
protected string mstrCourseId;    //课程Id
protected bool mbolIsRecommend;    //是否推荐
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPaperSubViewpointEN()
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
public clsPaperSubViewpointEN(long lngSubViewpointId)
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
if (strAttributeName  ==  conPaperSubViewpoint.SubViewpointId)
{
return mlngSubViewpointId;
}
else if (strAttributeName  ==  conPaperSubViewpoint.SubViewpointContent)
{
return mstrSubViewpointContent;
}
else if (strAttributeName  ==  conPaperSubViewpoint.PaperRWId)
{
return mstrPaperRWId;
}
else if (strAttributeName  ==  conPaperSubViewpoint.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  conPaperSubViewpoint.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conPaperSubViewpoint.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conPaperSubViewpoint.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  conPaperSubViewpoint.SubViewpointTypeId)
{
return mstrSubViewpointTypeId;
}
else if (strAttributeName  ==  conPaperSubViewpoint.gsKnowledgeTypeId)
{
return mstrgsKnowledgeTypeId;
}
else if (strAttributeName  ==  conPaperSubViewpoint.RWTitle)
{
return mstrRWTitle;
}
else if (strAttributeName  ==  conPaperSubViewpoint.ExplainTypeId)
{
return mstrExplainTypeId;
}
else if (strAttributeName  ==  conPaperSubViewpoint.ExplainContent)
{
return mstrExplainContent;
}
else if (strAttributeName  ==  conPaperSubViewpoint.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  conPaperSubViewpoint.LiteratureSourcesId)
{
return mstrLiteratureSourcesId;
}
else if (strAttributeName  ==  conPaperSubViewpoint.OperationTypeId)
{
return mstrOperationTypeId;
}
else if (strAttributeName  ==  conPaperSubViewpoint.LevelId)
{
return mstrLevelId;
}
else if (strAttributeName  ==  conPaperSubViewpoint.Conclusion)
{
return mstrConclusion;
}
else if (strAttributeName  ==  conPaperSubViewpoint.Nationality)
{
return mstrNationality;
}
else if (strAttributeName  ==  conPaperSubViewpoint.Achievement)
{
return mstrAchievement;
}
else if (strAttributeName  ==  conPaperSubViewpoint.Major)
{
return mstrMajor;
}
else if (strAttributeName  ==  conPaperSubViewpoint.WorkUnit)
{
return mstrWorkUnit;
}
else if (strAttributeName  ==  conPaperSubViewpoint.PageNumber)
{
return mintPageNumber;
}
else if (strAttributeName  ==  conPaperSubViewpoint.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conPaperSubViewpoint.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  conPaperSubViewpoint.selectSpanRange)
{
return mstrselectSpanRange;
}
else if (strAttributeName  ==  conPaperSubViewpoint.PaperLineNum)
{
return mintPaperLineNum;
}
else if (strAttributeName  ==  conPaperSubViewpoint.PaperPageNum)
{
return mintPaperPageNum;
}
else if (strAttributeName  ==  conPaperSubViewpoint.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  conPaperSubViewpoint.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  conPaperSubViewpoint.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conPaperSubViewpoint.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  conPaperSubViewpoint.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  conPaperSubViewpoint.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conPaperSubViewpoint.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  conPaperSubViewpoint.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  conPaperSubViewpoint.AttitudesId)
{
return mstrAttitudesId;
}
else if (strAttributeName  ==  conPaperSubViewpoint.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  conPaperSubViewpoint.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  conPaperSubViewpoint.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conPaperSubViewpoint.IsRecommend)
{
return mbolIsRecommend;
}
else if (strAttributeName  ==  conPaperSubViewpoint.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPaperSubViewpoint.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conPaperSubViewpoint.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPaperSubViewpoint.SubViewpointId)
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.SubViewpointId);
}
else if (strAttributeName  ==  conPaperSubViewpoint.SubViewpointContent)
{
mstrSubViewpointContent = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.SubViewpointContent);
}
else if (strAttributeName  ==  conPaperSubViewpoint.PaperRWId)
{
mstrPaperRWId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.PaperRWId);
}
else if (strAttributeName  ==  conPaperSubViewpoint.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.PaperId);
}
else if (strAttributeName  ==  conPaperSubViewpoint.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.IdCurrEduCls);
}
else if (strAttributeName  ==  conPaperSubViewpoint.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.UserId);
}
else if (strAttributeName  ==  conPaperSubViewpoint.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.SectionId);
}
else if (strAttributeName  ==  conPaperSubViewpoint.SubViewpointTypeId)
{
mstrSubViewpointTypeId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.SubViewpointTypeId);
}
else if (strAttributeName  ==  conPaperSubViewpoint.gsKnowledgeTypeId)
{
mstrgsKnowledgeTypeId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.gsKnowledgeTypeId);
}
else if (strAttributeName  ==  conPaperSubViewpoint.RWTitle)
{
mstrRWTitle = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.RWTitle);
}
else if (strAttributeName  ==  conPaperSubViewpoint.ExplainTypeId)
{
mstrExplainTypeId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.ExplainTypeId);
}
else if (strAttributeName  ==  conPaperSubViewpoint.ExplainContent)
{
mstrExplainContent = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.ExplainContent);
}
else if (strAttributeName  ==  conPaperSubViewpoint.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.IsPublic);
}
else if (strAttributeName  ==  conPaperSubViewpoint.LiteratureSourcesId)
{
mstrLiteratureSourcesId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.LiteratureSourcesId);
}
else if (strAttributeName  ==  conPaperSubViewpoint.OperationTypeId)
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.OperationTypeId);
}
else if (strAttributeName  ==  conPaperSubViewpoint.LevelId)
{
mstrLevelId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.LevelId);
}
else if (strAttributeName  ==  conPaperSubViewpoint.Conclusion)
{
mstrConclusion = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.Conclusion);
}
else if (strAttributeName  ==  conPaperSubViewpoint.Nationality)
{
mstrNationality = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.Nationality);
}
else if (strAttributeName  ==  conPaperSubViewpoint.Achievement)
{
mstrAchievement = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.Achievement);
}
else if (strAttributeName  ==  conPaperSubViewpoint.Major)
{
mstrMajor = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.Major);
}
else if (strAttributeName  ==  conPaperSubViewpoint.WorkUnit)
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.WorkUnit);
}
else if (strAttributeName  ==  conPaperSubViewpoint.PageNumber)
{
mintPageNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.PageNumber);
}
else if (strAttributeName  ==  conPaperSubViewpoint.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.OrderNum);
}
else if (strAttributeName  ==  conPaperSubViewpoint.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.PdfContent);
}
else if (strAttributeName  ==  conPaperSubViewpoint.selectSpanRange)
{
mstrselectSpanRange = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.selectSpanRange);
}
else if (strAttributeName  ==  conPaperSubViewpoint.PaperLineNum)
{
mintPaperLineNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.PaperLineNum);
}
else if (strAttributeName  ==  conPaperSubViewpoint.PaperPageNum)
{
mintPaperPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.PaperPageNum);
}
else if (strAttributeName  ==  conPaperSubViewpoint.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.AppraiseCount);
}
else if (strAttributeName  ==  conPaperSubViewpoint.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.OkCount);
}
else if (strAttributeName  ==  conPaperSubViewpoint.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.Score);
}
else if (strAttributeName  ==  conPaperSubViewpoint.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.StuScore);
}
else if (strAttributeName  ==  conPaperSubViewpoint.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.TeaScore);
}
else if (strAttributeName  ==  conPaperSubViewpoint.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.CreateDate);
}
else if (strAttributeName  ==  conPaperSubViewpoint.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.ShareId);
}
else if (strAttributeName  ==  conPaperSubViewpoint.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.TopicId);
}
else if (strAttributeName  ==  conPaperSubViewpoint.AttitudesId)
{
mstrAttitudesId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.AttitudesId);
}
else if (strAttributeName  ==  conPaperSubViewpoint.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.VersionCount);
}
else if (strAttributeName  ==  conPaperSubViewpoint.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.CitationCount);
}
else if (strAttributeName  ==  conPaperSubViewpoint.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.CourseId);
}
else if (strAttributeName  ==  conPaperSubViewpoint.IsRecommend)
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.IsRecommend);
}
else if (strAttributeName  ==  conPaperSubViewpoint.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.UpdDate);
}
else if (strAttributeName  ==  conPaperSubViewpoint.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.UpdUser);
}
else if (strAttributeName  ==  conPaperSubViewpoint.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPaperSubViewpoint.SubViewpointId  ==  AttributeName[intIndex])
{
return mlngSubViewpointId;
}
else if (conPaperSubViewpoint.SubViewpointContent  ==  AttributeName[intIndex])
{
return mstrSubViewpointContent;
}
else if (conPaperSubViewpoint.PaperRWId  ==  AttributeName[intIndex])
{
return mstrPaperRWId;
}
else if (conPaperSubViewpoint.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (conPaperSubViewpoint.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conPaperSubViewpoint.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conPaperSubViewpoint.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (conPaperSubViewpoint.SubViewpointTypeId  ==  AttributeName[intIndex])
{
return mstrSubViewpointTypeId;
}
else if (conPaperSubViewpoint.gsKnowledgeTypeId  ==  AttributeName[intIndex])
{
return mstrgsKnowledgeTypeId;
}
else if (conPaperSubViewpoint.RWTitle  ==  AttributeName[intIndex])
{
return mstrRWTitle;
}
else if (conPaperSubViewpoint.ExplainTypeId  ==  AttributeName[intIndex])
{
return mstrExplainTypeId;
}
else if (conPaperSubViewpoint.ExplainContent  ==  AttributeName[intIndex])
{
return mstrExplainContent;
}
else if (conPaperSubViewpoint.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (conPaperSubViewpoint.LiteratureSourcesId  ==  AttributeName[intIndex])
{
return mstrLiteratureSourcesId;
}
else if (conPaperSubViewpoint.OperationTypeId  ==  AttributeName[intIndex])
{
return mstrOperationTypeId;
}
else if (conPaperSubViewpoint.LevelId  ==  AttributeName[intIndex])
{
return mstrLevelId;
}
else if (conPaperSubViewpoint.Conclusion  ==  AttributeName[intIndex])
{
return mstrConclusion;
}
else if (conPaperSubViewpoint.Nationality  ==  AttributeName[intIndex])
{
return mstrNationality;
}
else if (conPaperSubViewpoint.Achievement  ==  AttributeName[intIndex])
{
return mstrAchievement;
}
else if (conPaperSubViewpoint.Major  ==  AttributeName[intIndex])
{
return mstrMajor;
}
else if (conPaperSubViewpoint.WorkUnit  ==  AttributeName[intIndex])
{
return mstrWorkUnit;
}
else if (conPaperSubViewpoint.PageNumber  ==  AttributeName[intIndex])
{
return mintPageNumber;
}
else if (conPaperSubViewpoint.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conPaperSubViewpoint.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (conPaperSubViewpoint.selectSpanRange  ==  AttributeName[intIndex])
{
return mstrselectSpanRange;
}
else if (conPaperSubViewpoint.PaperLineNum  ==  AttributeName[intIndex])
{
return mintPaperLineNum;
}
else if (conPaperSubViewpoint.PaperPageNum  ==  AttributeName[intIndex])
{
return mintPaperPageNum;
}
else if (conPaperSubViewpoint.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (conPaperSubViewpoint.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (conPaperSubViewpoint.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conPaperSubViewpoint.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (conPaperSubViewpoint.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (conPaperSubViewpoint.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conPaperSubViewpoint.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (conPaperSubViewpoint.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (conPaperSubViewpoint.AttitudesId  ==  AttributeName[intIndex])
{
return mstrAttitudesId;
}
else if (conPaperSubViewpoint.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (conPaperSubViewpoint.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (conPaperSubViewpoint.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conPaperSubViewpoint.IsRecommend  ==  AttributeName[intIndex])
{
return mbolIsRecommend;
}
else if (conPaperSubViewpoint.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPaperSubViewpoint.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conPaperSubViewpoint.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPaperSubViewpoint.SubViewpointId  ==  AttributeName[intIndex])
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.SubViewpointId);
}
else if (conPaperSubViewpoint.SubViewpointContent  ==  AttributeName[intIndex])
{
mstrSubViewpointContent = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.SubViewpointContent);
}
else if (conPaperSubViewpoint.PaperRWId  ==  AttributeName[intIndex])
{
mstrPaperRWId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.PaperRWId);
}
else if (conPaperSubViewpoint.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.PaperId);
}
else if (conPaperSubViewpoint.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.IdCurrEduCls);
}
else if (conPaperSubViewpoint.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.UserId);
}
else if (conPaperSubViewpoint.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.SectionId);
}
else if (conPaperSubViewpoint.SubViewpointTypeId  ==  AttributeName[intIndex])
{
mstrSubViewpointTypeId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.SubViewpointTypeId);
}
else if (conPaperSubViewpoint.gsKnowledgeTypeId  ==  AttributeName[intIndex])
{
mstrgsKnowledgeTypeId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.gsKnowledgeTypeId);
}
else if (conPaperSubViewpoint.RWTitle  ==  AttributeName[intIndex])
{
mstrRWTitle = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.RWTitle);
}
else if (conPaperSubViewpoint.ExplainTypeId  ==  AttributeName[intIndex])
{
mstrExplainTypeId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.ExplainTypeId);
}
else if (conPaperSubViewpoint.ExplainContent  ==  AttributeName[intIndex])
{
mstrExplainContent = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.ExplainContent);
}
else if (conPaperSubViewpoint.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.IsPublic);
}
else if (conPaperSubViewpoint.LiteratureSourcesId  ==  AttributeName[intIndex])
{
mstrLiteratureSourcesId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.LiteratureSourcesId);
}
else if (conPaperSubViewpoint.OperationTypeId  ==  AttributeName[intIndex])
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.OperationTypeId);
}
else if (conPaperSubViewpoint.LevelId  ==  AttributeName[intIndex])
{
mstrLevelId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.LevelId);
}
else if (conPaperSubViewpoint.Conclusion  ==  AttributeName[intIndex])
{
mstrConclusion = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.Conclusion);
}
else if (conPaperSubViewpoint.Nationality  ==  AttributeName[intIndex])
{
mstrNationality = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.Nationality);
}
else if (conPaperSubViewpoint.Achievement  ==  AttributeName[intIndex])
{
mstrAchievement = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.Achievement);
}
else if (conPaperSubViewpoint.Major  ==  AttributeName[intIndex])
{
mstrMajor = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.Major);
}
else if (conPaperSubViewpoint.WorkUnit  ==  AttributeName[intIndex])
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.WorkUnit);
}
else if (conPaperSubViewpoint.PageNumber  ==  AttributeName[intIndex])
{
mintPageNumber = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.PageNumber);
}
else if (conPaperSubViewpoint.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.OrderNum);
}
else if (conPaperSubViewpoint.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.PdfContent);
}
else if (conPaperSubViewpoint.selectSpanRange  ==  AttributeName[intIndex])
{
mstrselectSpanRange = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.selectSpanRange);
}
else if (conPaperSubViewpoint.PaperLineNum  ==  AttributeName[intIndex])
{
mintPaperLineNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.PaperLineNum);
}
else if (conPaperSubViewpoint.PaperPageNum  ==  AttributeName[intIndex])
{
mintPaperPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.PaperPageNum);
}
else if (conPaperSubViewpoint.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.AppraiseCount);
}
else if (conPaperSubViewpoint.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.OkCount);
}
else if (conPaperSubViewpoint.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.Score);
}
else if (conPaperSubViewpoint.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.StuScore);
}
else if (conPaperSubViewpoint.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.TeaScore);
}
else if (conPaperSubViewpoint.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.CreateDate);
}
else if (conPaperSubViewpoint.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.ShareId);
}
else if (conPaperSubViewpoint.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.TopicId);
}
else if (conPaperSubViewpoint.AttitudesId  ==  AttributeName[intIndex])
{
mstrAttitudesId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.AttitudesId);
}
else if (conPaperSubViewpoint.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.VersionCount);
}
else if (conPaperSubViewpoint.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.CitationCount);
}
else if (conPaperSubViewpoint.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.CourseId);
}
else if (conPaperSubViewpoint.IsRecommend  ==  AttributeName[intIndex])
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaperSubViewpoint.IsRecommend);
}
else if (conPaperSubViewpoint.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.UpdDate);
}
else if (conPaperSubViewpoint.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.UpdUser);
}
else if (conPaperSubViewpoint.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperSubViewpoint.Memo);
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
 AddUpdatedFld(conPaperSubViewpoint.SubViewpointId);
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
 AddUpdatedFld(conPaperSubViewpoint.SubViewpointContent);
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
 AddUpdatedFld(conPaperSubViewpoint.PaperRWId);
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
 AddUpdatedFld(conPaperSubViewpoint.PaperId);
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
 AddUpdatedFld(conPaperSubViewpoint.IdCurrEduCls);
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
 AddUpdatedFld(conPaperSubViewpoint.UserId);
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
 AddUpdatedFld(conPaperSubViewpoint.SectionId);
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
 AddUpdatedFld(conPaperSubViewpoint.SubViewpointTypeId);
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
 AddUpdatedFld(conPaperSubViewpoint.gsKnowledgeTypeId);
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
 AddUpdatedFld(conPaperSubViewpoint.RWTitle);
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
 AddUpdatedFld(conPaperSubViewpoint.ExplainTypeId);
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
 AddUpdatedFld(conPaperSubViewpoint.ExplainContent);
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
 AddUpdatedFld(conPaperSubViewpoint.IsPublic);
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
 AddUpdatedFld(conPaperSubViewpoint.LiteratureSourcesId);
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
 AddUpdatedFld(conPaperSubViewpoint.OperationTypeId);
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
 AddUpdatedFld(conPaperSubViewpoint.LevelId);
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
 AddUpdatedFld(conPaperSubViewpoint.Conclusion);
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
 AddUpdatedFld(conPaperSubViewpoint.Nationality);
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
 AddUpdatedFld(conPaperSubViewpoint.Achievement);
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
 AddUpdatedFld(conPaperSubViewpoint.Major);
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
 AddUpdatedFld(conPaperSubViewpoint.WorkUnit);
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
 AddUpdatedFld(conPaperSubViewpoint.PageNumber);
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
 AddUpdatedFld(conPaperSubViewpoint.OrderNum);
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
 AddUpdatedFld(conPaperSubViewpoint.PdfContent);
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
 AddUpdatedFld(conPaperSubViewpoint.selectSpanRange);
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
 AddUpdatedFld(conPaperSubViewpoint.PaperLineNum);
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
 AddUpdatedFld(conPaperSubViewpoint.PaperPageNum);
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
 AddUpdatedFld(conPaperSubViewpoint.AppraiseCount);
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
 AddUpdatedFld(conPaperSubViewpoint.OkCount);
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
 AddUpdatedFld(conPaperSubViewpoint.Score);
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
 AddUpdatedFld(conPaperSubViewpoint.StuScore);
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
 AddUpdatedFld(conPaperSubViewpoint.TeaScore);
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
 AddUpdatedFld(conPaperSubViewpoint.CreateDate);
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
 AddUpdatedFld(conPaperSubViewpoint.ShareId);
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
 AddUpdatedFld(conPaperSubViewpoint.TopicId);
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
 AddUpdatedFld(conPaperSubViewpoint.AttitudesId);
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
 AddUpdatedFld(conPaperSubViewpoint.VersionCount);
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
 AddUpdatedFld(conPaperSubViewpoint.CitationCount);
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
 AddUpdatedFld(conPaperSubViewpoint.CourseId);
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
 AddUpdatedFld(conPaperSubViewpoint.IsRecommend);
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
 AddUpdatedFld(conPaperSubViewpoint.UpdDate);
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
 AddUpdatedFld(conPaperSubViewpoint.UpdUser);
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
 AddUpdatedFld(conPaperSubViewpoint.Memo);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrSubViewpointContent;
 }
 }
}
 /// <summary>
 /// 子观点表(PaperSubViewpoint)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPaperSubViewpoint
{
public const string _CurrTabName = "PaperSubViewpoint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SubViewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SubViewpointId", "SubViewpointContent", "PaperRWId", "PaperId", "IdCurrEduCls", "UserId", "SectionId", "SubViewpointTypeId", "gsKnowledgeTypeId", "RWTitle", "ExplainTypeId", "ExplainContent", "IsPublic", "LiteratureSourcesId", "OperationTypeId", "LevelId", "Conclusion", "Nationality", "Achievement", "Major", "WorkUnit", "PageNumber", "OrderNum", "PdfContent", "selectSpanRange", "PaperLineNum", "PaperPageNum", "AppraiseCount", "OkCount", "Score", "StuScore", "TeaScore", "CreateDate", "ShareId", "TopicId", "AttitudesId", "VersionCount", "CitationCount", "CourseId", "IsRecommend", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"SubViewpointTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointTypeId = "SubViewpointTypeId";    //类型Id

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
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"AttitudesId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttitudesId = "AttitudesId";    //态度Id

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
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"IsRecommend"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRecommend = "IsRecommend";    //是否推荐

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
}

}