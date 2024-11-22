
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTViewpointRelaEN
 表名:vRTViewpointRela(01120541)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:03:28
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
 /// 表vRTViewpointRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vRTViewpointRela
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
public K_mId_vRTViewpointRela(long lngmId)
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
 /// <returns>返回:[K_mId_vRTViewpointRela]类型的对象</returns>
public static implicit operator K_mId_vRTViewpointRela(long value)
{
return new K_mId_vRTViewpointRela(value);
}
}
 /// <summary>
 /// v主题观点关系(vRTViewpointRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvRTViewpointRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vRTViewpointRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 36;
public static string[] AttributeName = new string[] {"mId", "ViewpointName", "ViewpointContent", "ViewpointId", "ProposePeople", "ViewpointTypeId", "ViewpointTypeName", "Reason", "Source", "TopicId", "TopicName", "TopicContent", "TopicProposePeople", "UpdDate", "UpdUser", "Memo", "IsSubmit", "AppraiseCount", "OkCount", "Score", "UserTypeId", "UserTypeName", "CitationCount", "CitationId", "StuScore", "TeaScore", "ViewsDate", "ViewsUserId", "IdCurrEduCls", "PdfContent", "PdfPageNum", "VersionCount", "CreateDate", "ShareId", "IsRecommend", "ClassificationId"};

protected long mlngmId;    //mId
protected string mstrViewpointName;    //观点名称
protected string mstrViewpointContent;    //观点内容
protected string mstrViewpointId;    //观点Id
protected string mstrProposePeople;    //提出人
protected string mstrViewpointTypeId;    //观点类型Id
protected string mstrViewpointTypeName;    //观点类型名
protected string mstrReason;    //理由
protected string mstrSource;    //来源
protected string mstrTopicId;    //主题Id
protected string mstrTopicName;    //栏目主题
protected string mstrTopicContent;    //主题内容
protected string mstrTopicProposePeople;    //主题提出人
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected bool mbolIsSubmit;    //是否提交
protected int? mintAppraiseCount;    //评论数
protected int? mintOkCount;    //点赞统计
protected float? mfltScore;    //评分
protected string mstrUserTypeId;    //用户类型Id
protected string mstrUserTypeName;    //用户类型名称
protected int? mintCitationCount;    //引用统计
protected string mstrCitationId;    //引用Id
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrViewsDate;    //ViewsDate
protected string mstrViewsUserId;    //ViewsUserId
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected int? mintVersionCount;    //版本统计
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id
protected bool mbolIsRecommend;    //是否推荐
protected string mstrClassificationId;    //分类Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvRTViewpointRelaEN()
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
public clsvRTViewpointRelaEN(long lngmId)
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
if (strAttributeName  ==  convRTViewpointRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convRTViewpointRela.ViewpointName)
{
return mstrViewpointName;
}
else if (strAttributeName  ==  convRTViewpointRela.ViewpointContent)
{
return mstrViewpointContent;
}
else if (strAttributeName  ==  convRTViewpointRela.ViewpointId)
{
return mstrViewpointId;
}
else if (strAttributeName  ==  convRTViewpointRela.ProposePeople)
{
return mstrProposePeople;
}
else if (strAttributeName  ==  convRTViewpointRela.ViewpointTypeId)
{
return mstrViewpointTypeId;
}
else if (strAttributeName  ==  convRTViewpointRela.ViewpointTypeName)
{
return mstrViewpointTypeName;
}
else if (strAttributeName  ==  convRTViewpointRela.Reason)
{
return mstrReason;
}
else if (strAttributeName  ==  convRTViewpointRela.Source)
{
return mstrSource;
}
else if (strAttributeName  ==  convRTViewpointRela.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  convRTViewpointRela.TopicName)
{
return mstrTopicName;
}
else if (strAttributeName  ==  convRTViewpointRela.TopicContent)
{
return mstrTopicContent;
}
else if (strAttributeName  ==  convRTViewpointRela.TopicProposePeople)
{
return mstrTopicProposePeople;
}
else if (strAttributeName  ==  convRTViewpointRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convRTViewpointRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convRTViewpointRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convRTViewpointRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convRTViewpointRela.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convRTViewpointRela.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convRTViewpointRela.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convRTViewpointRela.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convRTViewpointRela.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convRTViewpointRela.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convRTViewpointRela.CitationId)
{
return mstrCitationId;
}
else if (strAttributeName  ==  convRTViewpointRela.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convRTViewpointRela.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convRTViewpointRela.ViewsDate)
{
return mstrViewsDate;
}
else if (strAttributeName  ==  convRTViewpointRela.ViewsUserId)
{
return mstrViewsUserId;
}
else if (strAttributeName  ==  convRTViewpointRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convRTViewpointRela.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convRTViewpointRela.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convRTViewpointRela.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convRTViewpointRela.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convRTViewpointRela.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  convRTViewpointRela.IsRecommend)
{
return mbolIsRecommend;
}
else if (strAttributeName  ==  convRTViewpointRela.ClassificationId)
{
return mstrClassificationId;
}
return null;
}
set
{
if (strAttributeName  ==  convRTViewpointRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpointRela.mId);
}
else if (strAttributeName  ==  convRTViewpointRela.ViewpointName)
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ViewpointName);
}
else if (strAttributeName  ==  convRTViewpointRela.ViewpointContent)
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ViewpointContent);
}
else if (strAttributeName  ==  convRTViewpointRela.ViewpointId)
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ViewpointId);
}
else if (strAttributeName  ==  convRTViewpointRela.ProposePeople)
{
mstrProposePeople = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ProposePeople);
}
else if (strAttributeName  ==  convRTViewpointRela.ViewpointTypeId)
{
mstrViewpointTypeId = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ViewpointTypeId);
}
else if (strAttributeName  ==  convRTViewpointRela.ViewpointTypeName)
{
mstrViewpointTypeName = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ViewpointTypeName);
}
else if (strAttributeName  ==  convRTViewpointRela.Reason)
{
mstrReason = value.ToString();
 AddUpdatedFld(convRTViewpointRela.Reason);
}
else if (strAttributeName  ==  convRTViewpointRela.Source)
{
mstrSource = value.ToString();
 AddUpdatedFld(convRTViewpointRela.Source);
}
else if (strAttributeName  ==  convRTViewpointRela.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTViewpointRela.TopicId);
}
else if (strAttributeName  ==  convRTViewpointRela.TopicName)
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTViewpointRela.TopicName);
}
else if (strAttributeName  ==  convRTViewpointRela.TopicContent)
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTViewpointRela.TopicContent);
}
else if (strAttributeName  ==  convRTViewpointRela.TopicProposePeople)
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convRTViewpointRela.TopicProposePeople);
}
else if (strAttributeName  ==  convRTViewpointRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTViewpointRela.UpdDate);
}
else if (strAttributeName  ==  convRTViewpointRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTViewpointRela.UpdUser);
}
else if (strAttributeName  ==  convRTViewpointRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convRTViewpointRela.Memo);
}
else if (strAttributeName  ==  convRTViewpointRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTViewpointRela.IsSubmit);
}
else if (strAttributeName  ==  convRTViewpointRela.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpointRela.AppraiseCount);
}
else if (strAttributeName  ==  convRTViewpointRela.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpointRela.OkCount);
}
else if (strAttributeName  ==  convRTViewpointRela.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTViewpointRela.Score);
}
else if (strAttributeName  ==  convRTViewpointRela.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convRTViewpointRela.UserTypeId);
}
else if (strAttributeName  ==  convRTViewpointRela.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convRTViewpointRela.UserTypeName);
}
else if (strAttributeName  ==  convRTViewpointRela.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpointRela.CitationCount);
}
else if (strAttributeName  ==  convRTViewpointRela.CitationId)
{
mstrCitationId = value.ToString();
 AddUpdatedFld(convRTViewpointRela.CitationId);
}
else if (strAttributeName  ==  convRTViewpointRela.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTViewpointRela.StuScore);
}
else if (strAttributeName  ==  convRTViewpointRela.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTViewpointRela.TeaScore);
}
else if (strAttributeName  ==  convRTViewpointRela.ViewsDate)
{
mstrViewsDate = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ViewsDate);
}
else if (strAttributeName  ==  convRTViewpointRela.ViewsUserId)
{
mstrViewsUserId = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ViewsUserId);
}
else if (strAttributeName  ==  convRTViewpointRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convRTViewpointRela.IdCurrEduCls);
}
else if (strAttributeName  ==  convRTViewpointRela.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convRTViewpointRela.PdfContent);
}
else if (strAttributeName  ==  convRTViewpointRela.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpointRela.PdfPageNum);
}
else if (strAttributeName  ==  convRTViewpointRela.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpointRela.VersionCount);
}
else if (strAttributeName  ==  convRTViewpointRela.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convRTViewpointRela.CreateDate);
}
else if (strAttributeName  ==  convRTViewpointRela.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ShareId);
}
else if (strAttributeName  ==  convRTViewpointRela.IsRecommend)
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTViewpointRela.IsRecommend);
}
else if (strAttributeName  ==  convRTViewpointRela.ClassificationId)
{
mstrClassificationId = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ClassificationId);
}
}
}
public object this[int intIndex]
{
get
{
if (convRTViewpointRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convRTViewpointRela.ViewpointName  ==  AttributeName[intIndex])
{
return mstrViewpointName;
}
else if (convRTViewpointRela.ViewpointContent  ==  AttributeName[intIndex])
{
return mstrViewpointContent;
}
else if (convRTViewpointRela.ViewpointId  ==  AttributeName[intIndex])
{
return mstrViewpointId;
}
else if (convRTViewpointRela.ProposePeople  ==  AttributeName[intIndex])
{
return mstrProposePeople;
}
else if (convRTViewpointRela.ViewpointTypeId  ==  AttributeName[intIndex])
{
return mstrViewpointTypeId;
}
else if (convRTViewpointRela.ViewpointTypeName  ==  AttributeName[intIndex])
{
return mstrViewpointTypeName;
}
else if (convRTViewpointRela.Reason  ==  AttributeName[intIndex])
{
return mstrReason;
}
else if (convRTViewpointRela.Source  ==  AttributeName[intIndex])
{
return mstrSource;
}
else if (convRTViewpointRela.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (convRTViewpointRela.TopicName  ==  AttributeName[intIndex])
{
return mstrTopicName;
}
else if (convRTViewpointRela.TopicContent  ==  AttributeName[intIndex])
{
return mstrTopicContent;
}
else if (convRTViewpointRela.TopicProposePeople  ==  AttributeName[intIndex])
{
return mstrTopicProposePeople;
}
else if (convRTViewpointRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convRTViewpointRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convRTViewpointRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convRTViewpointRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convRTViewpointRela.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convRTViewpointRela.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convRTViewpointRela.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convRTViewpointRela.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convRTViewpointRela.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convRTViewpointRela.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convRTViewpointRela.CitationId  ==  AttributeName[intIndex])
{
return mstrCitationId;
}
else if (convRTViewpointRela.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convRTViewpointRela.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convRTViewpointRela.ViewsDate  ==  AttributeName[intIndex])
{
return mstrViewsDate;
}
else if (convRTViewpointRela.ViewsUserId  ==  AttributeName[intIndex])
{
return mstrViewsUserId;
}
else if (convRTViewpointRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convRTViewpointRela.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convRTViewpointRela.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convRTViewpointRela.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convRTViewpointRela.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convRTViewpointRela.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (convRTViewpointRela.IsRecommend  ==  AttributeName[intIndex])
{
return mbolIsRecommend;
}
else if (convRTViewpointRela.ClassificationId  ==  AttributeName[intIndex])
{
return mstrClassificationId;
}
return null;
}
set
{
if (convRTViewpointRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpointRela.mId);
}
else if (convRTViewpointRela.ViewpointName  ==  AttributeName[intIndex])
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ViewpointName);
}
else if (convRTViewpointRela.ViewpointContent  ==  AttributeName[intIndex])
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ViewpointContent);
}
else if (convRTViewpointRela.ViewpointId  ==  AttributeName[intIndex])
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ViewpointId);
}
else if (convRTViewpointRela.ProposePeople  ==  AttributeName[intIndex])
{
mstrProposePeople = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ProposePeople);
}
else if (convRTViewpointRela.ViewpointTypeId  ==  AttributeName[intIndex])
{
mstrViewpointTypeId = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ViewpointTypeId);
}
else if (convRTViewpointRela.ViewpointTypeName  ==  AttributeName[intIndex])
{
mstrViewpointTypeName = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ViewpointTypeName);
}
else if (convRTViewpointRela.Reason  ==  AttributeName[intIndex])
{
mstrReason = value.ToString();
 AddUpdatedFld(convRTViewpointRela.Reason);
}
else if (convRTViewpointRela.Source  ==  AttributeName[intIndex])
{
mstrSource = value.ToString();
 AddUpdatedFld(convRTViewpointRela.Source);
}
else if (convRTViewpointRela.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTViewpointRela.TopicId);
}
else if (convRTViewpointRela.TopicName  ==  AttributeName[intIndex])
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTViewpointRela.TopicName);
}
else if (convRTViewpointRela.TopicContent  ==  AttributeName[intIndex])
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTViewpointRela.TopicContent);
}
else if (convRTViewpointRela.TopicProposePeople  ==  AttributeName[intIndex])
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convRTViewpointRela.TopicProposePeople);
}
else if (convRTViewpointRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTViewpointRela.UpdDate);
}
else if (convRTViewpointRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTViewpointRela.UpdUser);
}
else if (convRTViewpointRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convRTViewpointRela.Memo);
}
else if (convRTViewpointRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTViewpointRela.IsSubmit);
}
else if (convRTViewpointRela.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpointRela.AppraiseCount);
}
else if (convRTViewpointRela.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpointRela.OkCount);
}
else if (convRTViewpointRela.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTViewpointRela.Score);
}
else if (convRTViewpointRela.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convRTViewpointRela.UserTypeId);
}
else if (convRTViewpointRela.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convRTViewpointRela.UserTypeName);
}
else if (convRTViewpointRela.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpointRela.CitationCount);
}
else if (convRTViewpointRela.CitationId  ==  AttributeName[intIndex])
{
mstrCitationId = value.ToString();
 AddUpdatedFld(convRTViewpointRela.CitationId);
}
else if (convRTViewpointRela.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTViewpointRela.StuScore);
}
else if (convRTViewpointRela.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTViewpointRela.TeaScore);
}
else if (convRTViewpointRela.ViewsDate  ==  AttributeName[intIndex])
{
mstrViewsDate = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ViewsDate);
}
else if (convRTViewpointRela.ViewsUserId  ==  AttributeName[intIndex])
{
mstrViewsUserId = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ViewsUserId);
}
else if (convRTViewpointRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convRTViewpointRela.IdCurrEduCls);
}
else if (convRTViewpointRela.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convRTViewpointRela.PdfContent);
}
else if (convRTViewpointRela.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpointRela.PdfPageNum);
}
else if (convRTViewpointRela.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTViewpointRela.VersionCount);
}
else if (convRTViewpointRela.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convRTViewpointRela.CreateDate);
}
else if (convRTViewpointRela.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ShareId);
}
else if (convRTViewpointRela.IsRecommend  ==  AttributeName[intIndex])
{
mbolIsRecommend = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTViewpointRela.IsRecommend);
}
else if (convRTViewpointRela.ClassificationId  ==  AttributeName[intIndex])
{
mstrClassificationId = value.ToString();
 AddUpdatedFld(convRTViewpointRela.ClassificationId);
}
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
 AddUpdatedFld(convRTViewpointRela.mId);
}
}
/// <summary>
/// 观点名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointName
{
get
{
return mstrViewpointName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointName = value;
}
else
{
 mstrViewpointName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpointRela.ViewpointName);
}
}
/// <summary>
/// 观点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointContent
{
get
{
return mstrViewpointContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointContent = value;
}
else
{
 mstrViewpointContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpointRela.ViewpointContent);
}
}
/// <summary>
/// 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointId
{
get
{
return mstrViewpointId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointId = value;
}
else
{
 mstrViewpointId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpointRela.ViewpointId);
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
 AddUpdatedFld(convRTViewpointRela.ProposePeople);
}
}
/// <summary>
/// 观点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointTypeId
{
get
{
return mstrViewpointTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointTypeId = value;
}
else
{
 mstrViewpointTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpointRela.ViewpointTypeId);
}
}
/// <summary>
/// 观点类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointTypeName
{
get
{
return mstrViewpointTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointTypeName = value;
}
else
{
 mstrViewpointTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpointRela.ViewpointTypeName);
}
}
/// <summary>
/// 理由(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Reason
{
get
{
return mstrReason;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReason = value;
}
else
{
 mstrReason = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpointRela.Reason);
}
}
/// <summary>
/// 来源(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Source
{
get
{
return mstrSource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSource = value;
}
else
{
 mstrSource = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpointRela.Source);
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
 AddUpdatedFld(convRTViewpointRela.TopicId);
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
 AddUpdatedFld(convRTViewpointRela.TopicName);
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
 AddUpdatedFld(convRTViewpointRela.TopicContent);
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
 AddUpdatedFld(convRTViewpointRela.TopicProposePeople);
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
 AddUpdatedFld(convRTViewpointRela.UpdDate);
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
 AddUpdatedFld(convRTViewpointRela.UpdUser);
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
 AddUpdatedFld(convRTViewpointRela.Memo);
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
 AddUpdatedFld(convRTViewpointRela.IsSubmit);
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
 AddUpdatedFld(convRTViewpointRela.AppraiseCount);
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
 AddUpdatedFld(convRTViewpointRela.OkCount);
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
 AddUpdatedFld(convRTViewpointRela.Score);
}
}
/// <summary>
/// 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeId
{
get
{
return mstrUserTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeId = value;
}
else
{
 mstrUserTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpointRela.UserTypeId);
}
}
/// <summary>
/// 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeName
{
get
{
return mstrUserTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeName = value;
}
else
{
 mstrUserTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpointRela.UserTypeName);
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
 AddUpdatedFld(convRTViewpointRela.CitationCount);
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
 AddUpdatedFld(convRTViewpointRela.CitationId);
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
 AddUpdatedFld(convRTViewpointRela.StuScore);
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
 AddUpdatedFld(convRTViewpointRela.TeaScore);
}
}
/// <summary>
/// ViewsDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewsDate
{
get
{
return mstrViewsDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewsDate = value;
}
else
{
 mstrViewsDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpointRela.ViewsDate);
}
}
/// <summary>
/// ViewsUserId(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewsUserId
{
get
{
return mstrViewsUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewsUserId = value;
}
else
{
 mstrViewsUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTViewpointRela.ViewsUserId);
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
 AddUpdatedFld(convRTViewpointRela.IdCurrEduCls);
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
 AddUpdatedFld(convRTViewpointRela.PdfContent);
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
 AddUpdatedFld(convRTViewpointRela.PdfPageNum);
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
 AddUpdatedFld(convRTViewpointRela.VersionCount);
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
 AddUpdatedFld(convRTViewpointRela.CreateDate);
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
 AddUpdatedFld(convRTViewpointRela.ShareId);
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
 AddUpdatedFld(convRTViewpointRela.IsRecommend);
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
 AddUpdatedFld(convRTViewpointRela.ClassificationId);
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
}
 /// <summary>
 /// v主题观点关系(vRTViewpointRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convRTViewpointRela
{
public const string _CurrTabName = "vRTViewpointRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "ViewpointName", "ViewpointContent", "ViewpointId", "ProposePeople", "ViewpointTypeId", "ViewpointTypeName", "Reason", "Source", "TopicId", "TopicName", "TopicContent", "TopicProposePeople", "UpdDate", "UpdUser", "Memo", "IsSubmit", "AppraiseCount", "OkCount", "Score", "UserTypeId", "UserTypeName", "CitationCount", "CitationId", "StuScore", "TeaScore", "ViewsDate", "ViewsUserId", "IdCurrEduCls", "PdfContent", "PdfPageNum", "VersionCount", "CreateDate", "ShareId", "IsRecommend", "ClassificationId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ViewpointName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointName = "ViewpointName";    //观点名称

 /// <summary>
 /// 常量:"ViewpointContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointContent = "ViewpointContent";    //观点内容

 /// <summary>
 /// 常量:"ViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointId = "ViewpointId";    //观点Id

 /// <summary>
 /// 常量:"ProposePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProposePeople = "ProposePeople";    //提出人

 /// <summary>
 /// 常量:"ViewpointTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointTypeId = "ViewpointTypeId";    //观点类型Id

 /// <summary>
 /// 常量:"ViewpointTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointTypeName = "ViewpointTypeName";    //观点类型名

 /// <summary>
 /// 常量:"Reason"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Reason = "Reason";    //理由

 /// <summary>
 /// 常量:"Source"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Source = "Source";    //来源

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
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

 /// <summary>
 /// 常量:"UserTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeName = "UserTypeName";    //用户类型名称

 /// <summary>
 /// 常量:"CitationCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationCount = "CitationCount";    //引用统计

 /// <summary>
 /// 常量:"CitationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationId = "CitationId";    //引用Id

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
 /// 常量:"ViewsDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewsDate = "ViewsDate";    //ViewsDate

 /// <summary>
 /// 常量:"ViewsUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewsUserId = "ViewsUserId";    //ViewsUserId

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

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
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

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
 /// 常量:"IsRecommend"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRecommend = "IsRecommend";    //是否推荐

 /// <summary>
 /// 常量:"ClassificationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassificationId = "ClassificationId";    //分类Id
}

}