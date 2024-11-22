
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTSysSocialRelaEN
 表名:vRTSysSocialRela(01120655)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:21:37
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
 /// 表vRTSysSocialRela的关键字(SubViewpointId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SubViewpointId_vRTSysSocialRela
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
public K_SubViewpointId_vRTSysSocialRela(long lngSubViewpointId)
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
 /// <returns>返回:[K_SubViewpointId_vRTSysSocialRela]类型的对象</returns>
public static implicit operator K_SubViewpointId_vRTSysSocialRela(long value)
{
return new K_SubViewpointId_vRTSysSocialRela(value);
}
}
 /// <summary>
 /// vRTSysSocialRela(vRTSysSocialRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvRTSysSocialRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vRTSysSocialRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SubViewpointId,TopicId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 31;
public static string[] AttributeName = new string[] {"SubViewpointId", "TopicId", "TopicName", "TopicContent", "TopicProposePeople", "OrderNum", "IdCurrEduCls", "FullName", "Nationality", "WorkUnit", "Major", "Achievement", "DetailedDescription", "LevelId", "LevelName", "SocialUpdUser", "SocialUpdDate", "IsSubmit", "OkCount", "UpdDate", "UpdUser", "Memo", "AppraiseCount", "Score", "StuScore", "TeaScore", "CreateDate", "ShareId", "PdfContent", "ClassificationId", "PaperId"};

protected long mlngSubViewpointId;    //子观点Id
protected string mstrTopicId;    //主题Id
protected string mstrTopicName;    //栏目主题
protected string mstrTopicContent;    //主题内容
protected string mstrTopicProposePeople;    //主题提出人
protected int? mintOrderNum;    //序号
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrFullName;    //姓名
protected string mstrNationality;    //国籍
protected string mstrWorkUnit;    //工作单位
protected string mstrMajor;    //专业
protected string mstrAchievement;    //成就
protected string mstrDetailedDescription;    //详细说明
protected string mstrLevelId;    //级别Id
protected string mstrLevelName;    //级别名称
protected string mstrSocialUpdUser;    //SocialUpdUser
protected string mstrSocialUpdDate;    //SocialUpdDate
protected bool mbolIsSubmit;    //是否提交
protected int? mintOkCount;    //点赞统计
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected int? mintAppraiseCount;    //评论数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id
protected string mstrPdfContent;    //Pdf内容
protected long? mlngClassificationId;    //分类Id
protected string mstrPaperId;    //论文Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvRTSysSocialRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SubViewpointId");
 lstKeyFldNames.Add("TopicId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngSubViewpointId">关键字:子观点Id</param>
public clsvRTSysSocialRelaEN(long lngSubViewpointId , string strTopicId)
 {
 if (lngSubViewpointId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngSubViewpointId = lngSubViewpointId;
this.mstrTopicId = strTopicId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SubViewpointId");
 lstKeyFldNames.Add("TopicId");
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
if (strAttributeName  ==  convRTSysSocialRela.SubViewpointId)
{
return mlngSubViewpointId;
}
else if (strAttributeName  ==  convRTSysSocialRela.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  convRTSysSocialRela.TopicName)
{
return mstrTopicName;
}
else if (strAttributeName  ==  convRTSysSocialRela.TopicContent)
{
return mstrTopicContent;
}
else if (strAttributeName  ==  convRTSysSocialRela.TopicProposePeople)
{
return mstrTopicProposePeople;
}
else if (strAttributeName  ==  convRTSysSocialRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convRTSysSocialRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convRTSysSocialRela.FullName)
{
return mstrFullName;
}
else if (strAttributeName  ==  convRTSysSocialRela.Nationality)
{
return mstrNationality;
}
else if (strAttributeName  ==  convRTSysSocialRela.WorkUnit)
{
return mstrWorkUnit;
}
else if (strAttributeName  ==  convRTSysSocialRela.Major)
{
return mstrMajor;
}
else if (strAttributeName  ==  convRTSysSocialRela.Achievement)
{
return mstrAchievement;
}
else if (strAttributeName  ==  convRTSysSocialRela.DetailedDescription)
{
return mstrDetailedDescription;
}
else if (strAttributeName  ==  convRTSysSocialRela.LevelId)
{
return mstrLevelId;
}
else if (strAttributeName  ==  convRTSysSocialRela.LevelName)
{
return mstrLevelName;
}
else if (strAttributeName  ==  convRTSysSocialRela.SocialUpdUser)
{
return mstrSocialUpdUser;
}
else if (strAttributeName  ==  convRTSysSocialRela.SocialUpdDate)
{
return mstrSocialUpdDate;
}
else if (strAttributeName  ==  convRTSysSocialRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convRTSysSocialRela.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convRTSysSocialRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convRTSysSocialRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convRTSysSocialRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convRTSysSocialRela.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convRTSysSocialRela.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convRTSysSocialRela.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convRTSysSocialRela.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convRTSysSocialRela.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convRTSysSocialRela.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  convRTSysSocialRela.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convRTSysSocialRela.ClassificationId)
{
return mlngClassificationId;
}
else if (strAttributeName  ==  convRTSysSocialRela.PaperId)
{
return mstrPaperId;
}
return null;
}
set
{
if (strAttributeName  ==  convRTSysSocialRela.SubViewpointId)
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.SubViewpointId);
}
else if (strAttributeName  ==  convRTSysSocialRela.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.TopicId);
}
else if (strAttributeName  ==  convRTSysSocialRela.TopicName)
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.TopicName);
}
else if (strAttributeName  ==  convRTSysSocialRela.TopicContent)
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.TopicContent);
}
else if (strAttributeName  ==  convRTSysSocialRela.TopicProposePeople)
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.TopicProposePeople);
}
else if (strAttributeName  ==  convRTSysSocialRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.OrderNum);
}
else if (strAttributeName  ==  convRTSysSocialRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.IdCurrEduCls);
}
else if (strAttributeName  ==  convRTSysSocialRela.FullName)
{
mstrFullName = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.FullName);
}
else if (strAttributeName  ==  convRTSysSocialRela.Nationality)
{
mstrNationality = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.Nationality);
}
else if (strAttributeName  ==  convRTSysSocialRela.WorkUnit)
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.WorkUnit);
}
else if (strAttributeName  ==  convRTSysSocialRela.Major)
{
mstrMajor = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.Major);
}
else if (strAttributeName  ==  convRTSysSocialRela.Achievement)
{
mstrAchievement = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.Achievement);
}
else if (strAttributeName  ==  convRTSysSocialRela.DetailedDescription)
{
mstrDetailedDescription = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.DetailedDescription);
}
else if (strAttributeName  ==  convRTSysSocialRela.LevelId)
{
mstrLevelId = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.LevelId);
}
else if (strAttributeName  ==  convRTSysSocialRela.LevelName)
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.LevelName);
}
else if (strAttributeName  ==  convRTSysSocialRela.SocialUpdUser)
{
mstrSocialUpdUser = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.SocialUpdUser);
}
else if (strAttributeName  ==  convRTSysSocialRela.SocialUpdDate)
{
mstrSocialUpdDate = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.SocialUpdDate);
}
else if (strAttributeName  ==  convRTSysSocialRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.IsSubmit);
}
else if (strAttributeName  ==  convRTSysSocialRela.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.OkCount);
}
else if (strAttributeName  ==  convRTSysSocialRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.UpdDate);
}
else if (strAttributeName  ==  convRTSysSocialRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.UpdUser);
}
else if (strAttributeName  ==  convRTSysSocialRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.Memo);
}
else if (strAttributeName  ==  convRTSysSocialRela.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.AppraiseCount);
}
else if (strAttributeName  ==  convRTSysSocialRela.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.Score);
}
else if (strAttributeName  ==  convRTSysSocialRela.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.StuScore);
}
else if (strAttributeName  ==  convRTSysSocialRela.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.TeaScore);
}
else if (strAttributeName  ==  convRTSysSocialRela.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.CreateDate);
}
else if (strAttributeName  ==  convRTSysSocialRela.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.ShareId);
}
else if (strAttributeName  ==  convRTSysSocialRela.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.PdfContent);
}
else if (strAttributeName  ==  convRTSysSocialRela.ClassificationId)
{
mlngClassificationId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.ClassificationId);
}
else if (strAttributeName  ==  convRTSysSocialRela.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.PaperId);
}
}
}
public object this[int intIndex]
{
get
{
if (convRTSysSocialRela.SubViewpointId  ==  AttributeName[intIndex])
{
return mlngSubViewpointId;
}
else if (convRTSysSocialRela.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (convRTSysSocialRela.TopicName  ==  AttributeName[intIndex])
{
return mstrTopicName;
}
else if (convRTSysSocialRela.TopicContent  ==  AttributeName[intIndex])
{
return mstrTopicContent;
}
else if (convRTSysSocialRela.TopicProposePeople  ==  AttributeName[intIndex])
{
return mstrTopicProposePeople;
}
else if (convRTSysSocialRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convRTSysSocialRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convRTSysSocialRela.FullName  ==  AttributeName[intIndex])
{
return mstrFullName;
}
else if (convRTSysSocialRela.Nationality  ==  AttributeName[intIndex])
{
return mstrNationality;
}
else if (convRTSysSocialRela.WorkUnit  ==  AttributeName[intIndex])
{
return mstrWorkUnit;
}
else if (convRTSysSocialRela.Major  ==  AttributeName[intIndex])
{
return mstrMajor;
}
else if (convRTSysSocialRela.Achievement  ==  AttributeName[intIndex])
{
return mstrAchievement;
}
else if (convRTSysSocialRela.DetailedDescription  ==  AttributeName[intIndex])
{
return mstrDetailedDescription;
}
else if (convRTSysSocialRela.LevelId  ==  AttributeName[intIndex])
{
return mstrLevelId;
}
else if (convRTSysSocialRela.LevelName  ==  AttributeName[intIndex])
{
return mstrLevelName;
}
else if (convRTSysSocialRela.SocialUpdUser  ==  AttributeName[intIndex])
{
return mstrSocialUpdUser;
}
else if (convRTSysSocialRela.SocialUpdDate  ==  AttributeName[intIndex])
{
return mstrSocialUpdDate;
}
else if (convRTSysSocialRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convRTSysSocialRela.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convRTSysSocialRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convRTSysSocialRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convRTSysSocialRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convRTSysSocialRela.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convRTSysSocialRela.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convRTSysSocialRela.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convRTSysSocialRela.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convRTSysSocialRela.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convRTSysSocialRela.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (convRTSysSocialRela.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convRTSysSocialRela.ClassificationId  ==  AttributeName[intIndex])
{
return mlngClassificationId;
}
else if (convRTSysSocialRela.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
return null;
}
set
{
if (convRTSysSocialRela.SubViewpointId  ==  AttributeName[intIndex])
{
mlngSubViewpointId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.SubViewpointId);
}
else if (convRTSysSocialRela.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.TopicId);
}
else if (convRTSysSocialRela.TopicName  ==  AttributeName[intIndex])
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.TopicName);
}
else if (convRTSysSocialRela.TopicContent  ==  AttributeName[intIndex])
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.TopicContent);
}
else if (convRTSysSocialRela.TopicProposePeople  ==  AttributeName[intIndex])
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.TopicProposePeople);
}
else if (convRTSysSocialRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.OrderNum);
}
else if (convRTSysSocialRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.IdCurrEduCls);
}
else if (convRTSysSocialRela.FullName  ==  AttributeName[intIndex])
{
mstrFullName = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.FullName);
}
else if (convRTSysSocialRela.Nationality  ==  AttributeName[intIndex])
{
mstrNationality = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.Nationality);
}
else if (convRTSysSocialRela.WorkUnit  ==  AttributeName[intIndex])
{
mstrWorkUnit = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.WorkUnit);
}
else if (convRTSysSocialRela.Major  ==  AttributeName[intIndex])
{
mstrMajor = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.Major);
}
else if (convRTSysSocialRela.Achievement  ==  AttributeName[intIndex])
{
mstrAchievement = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.Achievement);
}
else if (convRTSysSocialRela.DetailedDescription  ==  AttributeName[intIndex])
{
mstrDetailedDescription = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.DetailedDescription);
}
else if (convRTSysSocialRela.LevelId  ==  AttributeName[intIndex])
{
mstrLevelId = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.LevelId);
}
else if (convRTSysSocialRela.LevelName  ==  AttributeName[intIndex])
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.LevelName);
}
else if (convRTSysSocialRela.SocialUpdUser  ==  AttributeName[intIndex])
{
mstrSocialUpdUser = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.SocialUpdUser);
}
else if (convRTSysSocialRela.SocialUpdDate  ==  AttributeName[intIndex])
{
mstrSocialUpdDate = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.SocialUpdDate);
}
else if (convRTSysSocialRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.IsSubmit);
}
else if (convRTSysSocialRela.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.OkCount);
}
else if (convRTSysSocialRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.UpdDate);
}
else if (convRTSysSocialRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.UpdUser);
}
else if (convRTSysSocialRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.Memo);
}
else if (convRTSysSocialRela.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.AppraiseCount);
}
else if (convRTSysSocialRela.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.Score);
}
else if (convRTSysSocialRela.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.StuScore);
}
else if (convRTSysSocialRela.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.TeaScore);
}
else if (convRTSysSocialRela.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.CreateDate);
}
else if (convRTSysSocialRela.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.ShareId);
}
else if (convRTSysSocialRela.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.PdfContent);
}
else if (convRTSysSocialRela.ClassificationId  ==  AttributeName[intIndex])
{
mlngClassificationId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTSysSocialRela.ClassificationId);
}
else if (convRTSysSocialRela.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convRTSysSocialRela.PaperId);
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
 AddUpdatedFld(convRTSysSocialRela.SubViewpointId);
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
 AddUpdatedFld(convRTSysSocialRela.TopicId);
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
 AddUpdatedFld(convRTSysSocialRela.TopicName);
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
 AddUpdatedFld(convRTSysSocialRela.TopicContent);
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
 AddUpdatedFld(convRTSysSocialRela.TopicProposePeople);
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
 AddUpdatedFld(convRTSysSocialRela.OrderNum);
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
 AddUpdatedFld(convRTSysSocialRela.IdCurrEduCls);
}
}
/// <summary>
/// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FullName
{
get
{
return mstrFullName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFullName = value;
}
else
{
 mstrFullName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTSysSocialRela.FullName);
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
 AddUpdatedFld(convRTSysSocialRela.Nationality);
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
 AddUpdatedFld(convRTSysSocialRela.WorkUnit);
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
 AddUpdatedFld(convRTSysSocialRela.Major);
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
 AddUpdatedFld(convRTSysSocialRela.Achievement);
}
}
/// <summary>
/// 详细说明(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DetailedDescription
{
get
{
return mstrDetailedDescription;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDetailedDescription = value;
}
else
{
 mstrDetailedDescription = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTSysSocialRela.DetailedDescription);
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
 AddUpdatedFld(convRTSysSocialRela.LevelId);
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
 AddUpdatedFld(convRTSysSocialRela.LevelName);
}
}
/// <summary>
/// SocialUpdUser(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SocialUpdUser
{
get
{
return mstrSocialUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSocialUpdUser = value;
}
else
{
 mstrSocialUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTSysSocialRela.SocialUpdUser);
}
}
/// <summary>
/// SocialUpdDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SocialUpdDate
{
get
{
return mstrSocialUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSocialUpdDate = value;
}
else
{
 mstrSocialUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTSysSocialRela.SocialUpdDate);
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
 AddUpdatedFld(convRTSysSocialRela.IsSubmit);
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
 AddUpdatedFld(convRTSysSocialRela.OkCount);
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
 AddUpdatedFld(convRTSysSocialRela.UpdDate);
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
 AddUpdatedFld(convRTSysSocialRela.UpdUser);
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
 AddUpdatedFld(convRTSysSocialRela.Memo);
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
 AddUpdatedFld(convRTSysSocialRela.AppraiseCount);
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
 AddUpdatedFld(convRTSysSocialRela.Score);
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
 AddUpdatedFld(convRTSysSocialRela.StuScore);
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
 AddUpdatedFld(convRTSysSocialRela.TeaScore);
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
 AddUpdatedFld(convRTSysSocialRela.CreateDate);
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
 AddUpdatedFld(convRTSysSocialRela.ShareId);
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
 AddUpdatedFld(convRTSysSocialRela.PdfContent);
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
 AddUpdatedFld(convRTSysSocialRela.ClassificationId);
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
 AddUpdatedFld(convRTSysSocialRela.PaperId);
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
 /// vRTSysSocialRela(vRTSysSocialRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convRTSysSocialRela
{
public const string _CurrTabName = "vRTSysSocialRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SubViewpointId,TopicId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SubViewpointId", "TopicId", "TopicName", "TopicContent", "TopicProposePeople", "OrderNum", "IdCurrEduCls", "FullName", "Nationality", "WorkUnit", "Major", "Achievement", "DetailedDescription", "LevelId", "LevelName", "SocialUpdUser", "SocialUpdDate", "IsSubmit", "OkCount", "UpdDate", "UpdUser", "Memo", "AppraiseCount", "Score", "StuScore", "TeaScore", "CreateDate", "ShareId", "PdfContent", "ClassificationId", "PaperId"};
//以下是属性变量


 /// <summary>
 /// 常量:"SubViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointId = "SubViewpointId";    //子观点Id

 /// <summary>
 /// 常量:"TopicId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicId = "TopicId";    //主题Id

 /// <summary>
 /// 常量:"TopicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicName = "TopicName";    //栏目主题

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
 /// 常量:"FullName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FullName = "FullName";    //姓名

 /// <summary>
 /// 常量:"Nationality"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Nationality = "Nationality";    //国籍

 /// <summary>
 /// 常量:"WorkUnit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WorkUnit = "WorkUnit";    //工作单位

 /// <summary>
 /// 常量:"Major"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Major = "Major";    //专业

 /// <summary>
 /// 常量:"Achievement"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Achievement = "Achievement";    //成就

 /// <summary>
 /// 常量:"DetailedDescription"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DetailedDescription = "DetailedDescription";    //详细说明

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
 /// 常量:"SocialUpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SocialUpdUser = "SocialUpdUser";    //SocialUpdUser

 /// <summary>
 /// 常量:"SocialUpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SocialUpdDate = "SocialUpdDate";    //SocialUpdDate

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

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
 /// 常量:"PdfContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfContent = "PdfContent";    //Pdf内容

 /// <summary>
 /// 常量:"ClassificationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassificationId = "ClassificationId";    //分类Id

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id
}

}