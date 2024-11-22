
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTSysSkillEN
 表名:vRTSysSkill(01120656)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// 表vRTSysSkill的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vRTSysSkill
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vRTSysSkill(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vRTSysSkill]类型的对象</returns>
public static implicit operator K_mId_vRTSysSkill(long value)
{
return new K_mId_vRTSysSkill(value);
}
}
 /// <summary>
 /// vRTSysSkill(vRTSysSkill)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvRTSysSkillEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vRTSysSkill"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 33;
public static string[] AttributeName = new string[] {"TopicName", "SkillName", "OperationTypeId", "Process", "LevelId", "LevelName", "SkillUpdUser", "SkillUpdDate", "OrderNum", "IdCurrEduCls", "TopicProposePeople", "TopicContent", "IsSubmit", "AppraiseCount", "Score", "StuScore", "TeaScore", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "OperationTypeName", "OkCount", "CitationId", "mId", "TopicId", "SkillId", "UpdDate", "Memo", "UpdUser", "CreateDate", "ShareId", "ClassificationId"};

protected string mstrTopicName;    //栏目主题
protected string mstrSkillName;    //技能名称
protected string mstrOperationTypeId;    //操作类型ID
protected string mstrProcess;    //实施过程
protected string mstrLevelId;    //级别Id
protected string mstrLevelName;    //级别名称
protected string mstrSkillUpdUser;    //SkillUpdUser
protected string mstrSkillUpdDate;    //SkillUpdDate
protected int? mintOrderNum;    //序号
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrTopicProposePeople;    //主题提出人
protected string mstrTopicContent;    //主题内容
protected bool mbolIsSubmit;    //是否提交
protected int? mintAppraiseCount;    //评论数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected int? mintCitationCount;    //引用统计
protected int? mintVersionCount;    //版本统计
protected string mstrOperationTypeName;    //操作类型名
protected int? mintOkCount;    //点赞统计
protected string mstrCitationId;    //引用Id
protected long mlngmId;    //mId
protected string mstrTopicId;    //主题Id
protected string mstrSkillId;    //技能Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrUpdUser;    //修改人
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id
protected string mstrClassificationId;    //分类Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvRTSysSkillEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvRTSysSkillEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convRTSysSkill.TopicName)
{
return mstrTopicName;
}
else if (strAttributeName  ==  convRTSysSkill.SkillName)
{
return mstrSkillName;
}
else if (strAttributeName  ==  convRTSysSkill.OperationTypeId)
{
return mstrOperationTypeId;
}
else if (strAttributeName  ==  convRTSysSkill.Process)
{
return mstrProcess;
}
else if (strAttributeName  ==  convRTSysSkill.LevelId)
{
return mstrLevelId;
}
else if (strAttributeName  ==  convRTSysSkill.LevelName)
{
return mstrLevelName;
}
else if (strAttributeName  ==  convRTSysSkill.SkillUpdUser)
{
return mstrSkillUpdUser;
}
else if (strAttributeName  ==  convRTSysSkill.SkillUpdDate)
{
return mstrSkillUpdDate;
}
else if (strAttributeName  ==  convRTSysSkill.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convRTSysSkill.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convRTSysSkill.TopicProposePeople)
{
return mstrTopicProposePeople;
}
else if (strAttributeName  ==  convRTSysSkill.TopicContent)
{
return mstrTopicContent;
}
else if (strAttributeName  ==  convRTSysSkill.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convRTSysSkill.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convRTSysSkill.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convRTSysSkill.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convRTSysSkill.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convRTSysSkill.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convRTSysSkill.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convRTSysSkill.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convRTSysSkill.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convRTSysSkill.OperationTypeName)
{
return mstrOperationTypeName;
}
else if (strAttributeName  ==  convRTSysSkill.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convRTSysSkill.CitationId)
{
return mstrCitationId;
}
else if (strAttributeName  ==  convRTSysSkill.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convRTSysSkill.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  convRTSysSkill.SkillId)
{
return mstrSkillId;
}
else if (strAttributeName  ==  convRTSysSkill.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convRTSysSkill.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convRTSysSkill.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convRTSysSkill.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convRTSysSkill.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  convRTSysSkill.ClassificationId)
{
return mstrClassificationId;
}
return null;
}
set
{
if (strAttributeName  ==  convRTSysSkill.TopicName)
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTSysSkill.TopicName);
}
else if (strAttributeName  ==  convRTSysSkill.SkillName)
{
mstrSkillName = value.ToString();
 AddUpdatedFld(convRTSysSkill.SkillName);
}
else if (strAttributeName  ==  convRTSysSkill.OperationTypeId)
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(convRTSysSkill.OperationTypeId);
}
else if (strAttributeName  ==  convRTSysSkill.Process)
{
mstrProcess = value.ToString();
 AddUpdatedFld(convRTSysSkill.Process);
}
else if (strAttributeName  ==  convRTSysSkill.LevelId)
{
mstrLevelId = value.ToString();
 AddUpdatedFld(convRTSysSkill.LevelId);
}
else if (strAttributeName  ==  convRTSysSkill.LevelName)
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convRTSysSkill.LevelName);
}
else if (strAttributeName  ==  convRTSysSkill.SkillUpdUser)
{
mstrSkillUpdUser = value.ToString();
 AddUpdatedFld(convRTSysSkill.SkillUpdUser);
}
else if (strAttributeName  ==  convRTSysSkill.SkillUpdDate)
{
mstrSkillUpdDate = value.ToString();
 AddUpdatedFld(convRTSysSkill.SkillUpdDate);
}
else if (strAttributeName  ==  convRTSysSkill.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSkill.OrderNum);
}
else if (strAttributeName  ==  convRTSysSkill.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convRTSysSkill.IdCurrEduCls);
}
else if (strAttributeName  ==  convRTSysSkill.TopicProposePeople)
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convRTSysSkill.TopicProposePeople);
}
else if (strAttributeName  ==  convRTSysSkill.TopicContent)
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTSysSkill.TopicContent);
}
else if (strAttributeName  ==  convRTSysSkill.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTSysSkill.IsSubmit);
}
else if (strAttributeName  ==  convRTSysSkill.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSkill.AppraiseCount);
}
else if (strAttributeName  ==  convRTSysSkill.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTSysSkill.Score);
}
else if (strAttributeName  ==  convRTSysSkill.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTSysSkill.StuScore);
}
else if (strAttributeName  ==  convRTSysSkill.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTSysSkill.TeaScore);
}
else if (strAttributeName  ==  convRTSysSkill.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convRTSysSkill.PdfContent);
}
else if (strAttributeName  ==  convRTSysSkill.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSkill.PdfPageNum);
}
else if (strAttributeName  ==  convRTSysSkill.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSkill.CitationCount);
}
else if (strAttributeName  ==  convRTSysSkill.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSkill.VersionCount);
}
else if (strAttributeName  ==  convRTSysSkill.OperationTypeName)
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(convRTSysSkill.OperationTypeName);
}
else if (strAttributeName  ==  convRTSysSkill.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSkill.OkCount);
}
else if (strAttributeName  ==  convRTSysSkill.CitationId)
{
mstrCitationId = value.ToString();
 AddUpdatedFld(convRTSysSkill.CitationId);
}
else if (strAttributeName  ==  convRTSysSkill.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSkill.mId);
}
else if (strAttributeName  ==  convRTSysSkill.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTSysSkill.TopicId);
}
else if (strAttributeName  ==  convRTSysSkill.SkillId)
{
mstrSkillId = value.ToString();
 AddUpdatedFld(convRTSysSkill.SkillId);
}
else if (strAttributeName  ==  convRTSysSkill.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTSysSkill.UpdDate);
}
else if (strAttributeName  ==  convRTSysSkill.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convRTSysSkill.Memo);
}
else if (strAttributeName  ==  convRTSysSkill.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTSysSkill.UpdUser);
}
else if (strAttributeName  ==  convRTSysSkill.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convRTSysSkill.CreateDate);
}
else if (strAttributeName  ==  convRTSysSkill.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convRTSysSkill.ShareId);
}
else if (strAttributeName  ==  convRTSysSkill.ClassificationId)
{
mstrClassificationId = value.ToString();
 AddUpdatedFld(convRTSysSkill.ClassificationId);
}
}
}
public object this[int intIndex]
{
get
{
if (convRTSysSkill.TopicName  ==  AttributeName[intIndex])
{
return mstrTopicName;
}
else if (convRTSysSkill.SkillName  ==  AttributeName[intIndex])
{
return mstrSkillName;
}
else if (convRTSysSkill.OperationTypeId  ==  AttributeName[intIndex])
{
return mstrOperationTypeId;
}
else if (convRTSysSkill.Process  ==  AttributeName[intIndex])
{
return mstrProcess;
}
else if (convRTSysSkill.LevelId  ==  AttributeName[intIndex])
{
return mstrLevelId;
}
else if (convRTSysSkill.LevelName  ==  AttributeName[intIndex])
{
return mstrLevelName;
}
else if (convRTSysSkill.SkillUpdUser  ==  AttributeName[intIndex])
{
return mstrSkillUpdUser;
}
else if (convRTSysSkill.SkillUpdDate  ==  AttributeName[intIndex])
{
return mstrSkillUpdDate;
}
else if (convRTSysSkill.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convRTSysSkill.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convRTSysSkill.TopicProposePeople  ==  AttributeName[intIndex])
{
return mstrTopicProposePeople;
}
else if (convRTSysSkill.TopicContent  ==  AttributeName[intIndex])
{
return mstrTopicContent;
}
else if (convRTSysSkill.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convRTSysSkill.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convRTSysSkill.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convRTSysSkill.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convRTSysSkill.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convRTSysSkill.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convRTSysSkill.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convRTSysSkill.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convRTSysSkill.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convRTSysSkill.OperationTypeName  ==  AttributeName[intIndex])
{
return mstrOperationTypeName;
}
else if (convRTSysSkill.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convRTSysSkill.CitationId  ==  AttributeName[intIndex])
{
return mstrCitationId;
}
else if (convRTSysSkill.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convRTSysSkill.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (convRTSysSkill.SkillId  ==  AttributeName[intIndex])
{
return mstrSkillId;
}
else if (convRTSysSkill.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convRTSysSkill.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convRTSysSkill.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convRTSysSkill.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convRTSysSkill.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (convRTSysSkill.ClassificationId  ==  AttributeName[intIndex])
{
return mstrClassificationId;
}
return null;
}
set
{
if (convRTSysSkill.TopicName  ==  AttributeName[intIndex])
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTSysSkill.TopicName);
}
else if (convRTSysSkill.SkillName  ==  AttributeName[intIndex])
{
mstrSkillName = value.ToString();
 AddUpdatedFld(convRTSysSkill.SkillName);
}
else if (convRTSysSkill.OperationTypeId  ==  AttributeName[intIndex])
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(convRTSysSkill.OperationTypeId);
}
else if (convRTSysSkill.Process  ==  AttributeName[intIndex])
{
mstrProcess = value.ToString();
 AddUpdatedFld(convRTSysSkill.Process);
}
else if (convRTSysSkill.LevelId  ==  AttributeName[intIndex])
{
mstrLevelId = value.ToString();
 AddUpdatedFld(convRTSysSkill.LevelId);
}
else if (convRTSysSkill.LevelName  ==  AttributeName[intIndex])
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convRTSysSkill.LevelName);
}
else if (convRTSysSkill.SkillUpdUser  ==  AttributeName[intIndex])
{
mstrSkillUpdUser = value.ToString();
 AddUpdatedFld(convRTSysSkill.SkillUpdUser);
}
else if (convRTSysSkill.SkillUpdDate  ==  AttributeName[intIndex])
{
mstrSkillUpdDate = value.ToString();
 AddUpdatedFld(convRTSysSkill.SkillUpdDate);
}
else if (convRTSysSkill.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSkill.OrderNum);
}
else if (convRTSysSkill.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convRTSysSkill.IdCurrEduCls);
}
else if (convRTSysSkill.TopicProposePeople  ==  AttributeName[intIndex])
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convRTSysSkill.TopicProposePeople);
}
else if (convRTSysSkill.TopicContent  ==  AttributeName[intIndex])
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTSysSkill.TopicContent);
}
else if (convRTSysSkill.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTSysSkill.IsSubmit);
}
else if (convRTSysSkill.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSkill.AppraiseCount);
}
else if (convRTSysSkill.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTSysSkill.Score);
}
else if (convRTSysSkill.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTSysSkill.StuScore);
}
else if (convRTSysSkill.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTSysSkill.TeaScore);
}
else if (convRTSysSkill.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convRTSysSkill.PdfContent);
}
else if (convRTSysSkill.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSkill.PdfPageNum);
}
else if (convRTSysSkill.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSkill.CitationCount);
}
else if (convRTSysSkill.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSkill.VersionCount);
}
else if (convRTSysSkill.OperationTypeName  ==  AttributeName[intIndex])
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(convRTSysSkill.OperationTypeName);
}
else if (convRTSysSkill.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSkill.OkCount);
}
else if (convRTSysSkill.CitationId  ==  AttributeName[intIndex])
{
mstrCitationId = value.ToString();
 AddUpdatedFld(convRTSysSkill.CitationId);
}
else if (convRTSysSkill.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSkill.mId);
}
else if (convRTSysSkill.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTSysSkill.TopicId);
}
else if (convRTSysSkill.SkillId  ==  AttributeName[intIndex])
{
mstrSkillId = value.ToString();
 AddUpdatedFld(convRTSysSkill.SkillId);
}
else if (convRTSysSkill.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTSysSkill.UpdDate);
}
else if (convRTSysSkill.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convRTSysSkill.Memo);
}
else if (convRTSysSkill.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTSysSkill.UpdUser);
}
else if (convRTSysSkill.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convRTSysSkill.CreateDate);
}
else if (convRTSysSkill.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convRTSysSkill.ShareId);
}
else if (convRTSysSkill.ClassificationId  ==  AttributeName[intIndex])
{
mstrClassificationId = value.ToString();
 AddUpdatedFld(convRTSysSkill.ClassificationId);
}
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
 AddUpdatedFld(convRTSysSkill.TopicName);
}
}
/// <summary>
/// 技能名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillName
{
get
{
return mstrSkillName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillName = value;
}
else
{
 mstrSkillName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTSysSkill.SkillName);
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
 AddUpdatedFld(convRTSysSkill.OperationTypeId);
}
}
/// <summary>
/// 实施过程(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Process
{
get
{
return mstrProcess;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProcess = value;
}
else
{
 mstrProcess = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTSysSkill.Process);
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
 AddUpdatedFld(convRTSysSkill.LevelId);
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
 AddUpdatedFld(convRTSysSkill.LevelName);
}
}
/// <summary>
/// SkillUpdUser(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillUpdUser
{
get
{
return mstrSkillUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillUpdUser = value;
}
else
{
 mstrSkillUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTSysSkill.SkillUpdUser);
}
}
/// <summary>
/// SkillUpdDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillUpdDate
{
get
{
return mstrSkillUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillUpdDate = value;
}
else
{
 mstrSkillUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTSysSkill.SkillUpdDate);
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
 AddUpdatedFld(convRTSysSkill.OrderNum);
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
 AddUpdatedFld(convRTSysSkill.IdCurrEduCls);
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
 AddUpdatedFld(convRTSysSkill.TopicProposePeople);
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
 AddUpdatedFld(convRTSysSkill.TopicContent);
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
 AddUpdatedFld(convRTSysSkill.IsSubmit);
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
 AddUpdatedFld(convRTSysSkill.AppraiseCount);
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
 AddUpdatedFld(convRTSysSkill.Score);
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
 AddUpdatedFld(convRTSysSkill.StuScore);
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
 AddUpdatedFld(convRTSysSkill.TeaScore);
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
 AddUpdatedFld(convRTSysSkill.PdfContent);
}
}
/// <summary>
/// Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PdfPageNum
{
get
{
return mintPdfPageNum;
}
set
{
 mintPdfPageNum = value;
//记录修改过的字段
 AddUpdatedFld(convRTSysSkill.PdfPageNum);
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
 AddUpdatedFld(convRTSysSkill.CitationCount);
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
 AddUpdatedFld(convRTSysSkill.VersionCount);
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
 AddUpdatedFld(convRTSysSkill.OperationTypeName);
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
 AddUpdatedFld(convRTSysSkill.OkCount);
}
}
/// <summary>
/// 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CitationId
{
get
{
return mstrCitationId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCitationId = value;
}
else
{
 mstrCitationId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTSysSkill.CitationId);
}
}
/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convRTSysSkill.mId);
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
 AddUpdatedFld(convRTSysSkill.TopicId);
}
}
/// <summary>
/// 技能Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillId
{
get
{
return mstrSkillId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillId = value;
}
else
{
 mstrSkillId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTSysSkill.SkillId);
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
 AddUpdatedFld(convRTSysSkill.UpdDate);
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
 AddUpdatedFld(convRTSysSkill.Memo);
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
 AddUpdatedFld(convRTSysSkill.UpdUser);
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
 AddUpdatedFld(convRTSysSkill.CreateDate);
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
 AddUpdatedFld(convRTSysSkill.ShareId);
}
}
/// <summary>
/// 分类Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassificationId
{
get
{
return mstrClassificationId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassificationId = value;
}
else
{
 mstrClassificationId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTSysSkill.ClassificationId);
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
  return mlngmId.ToString();
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
  return mstrLevelId;
 }
 }
}
 /// <summary>
 /// vRTSysSkill(vRTSysSkill)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convRTSysSkill
{
public const string _CurrTabName = "vRTSysSkill"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TopicName", "SkillName", "OperationTypeId", "Process", "LevelId", "LevelName", "SkillUpdUser", "SkillUpdDate", "OrderNum", "IdCurrEduCls", "TopicProposePeople", "TopicContent", "IsSubmit", "AppraiseCount", "Score", "StuScore", "TeaScore", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "OperationTypeName", "OkCount", "CitationId", "mId", "TopicId", "SkillId", "UpdDate", "Memo", "UpdUser", "CreateDate", "ShareId", "ClassificationId"};
//以下是属性变量


 /// <summary>
 /// 常量:"TopicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicName = "TopicName";    //栏目主题

 /// <summary>
 /// 常量:"SkillName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillName = "SkillName";    //技能名称

 /// <summary>
 /// 常量:"OperationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationTypeId = "OperationTypeId";    //操作类型ID

 /// <summary>
 /// 常量:"Process"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Process = "Process";    //实施过程

 /// <summary>
 /// 常量:"LevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelId = "LevelId";    //级别Id

 /// <summary>
 /// 常量:"LevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelName = "LevelName";    //级别名称

 /// <summary>
 /// 常量:"SkillUpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillUpdUser = "SkillUpdUser";    //SkillUpdUser

 /// <summary>
 /// 常量:"SkillUpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillUpdDate = "SkillUpdDate";    //SkillUpdDate

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"TopicProposePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicProposePeople = "TopicProposePeople";    //主题提出人

 /// <summary>
 /// 常量:"TopicContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicContent = "TopicContent";    //主题内容

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
 /// 常量:"PdfContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfContent = "PdfContent";    //Pdf内容

 /// <summary>
 /// 常量:"PdfPageNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNum = "PdfPageNum";    //Pdf页码

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
 /// 常量:"OperationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationTypeName = "OperationTypeName";    //操作类型名

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"CitationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationId = "CitationId";    //引用Id

 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"SkillId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillId = "SkillId";    //技能Id

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
 /// 常量:"ShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareId = "ShareId";    //分享Id

 /// <summary>
 /// 常量:"ClassificationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassificationId = "ClassificationId";    //分类Id
}

}