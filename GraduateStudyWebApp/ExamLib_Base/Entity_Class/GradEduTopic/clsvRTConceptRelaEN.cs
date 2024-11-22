
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTConceptRelaEN
 表名:vRTConceptRela(01120607)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:05:28
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
 /// 表vRTConceptRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vRTConceptRela
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
public K_mId_vRTConceptRela(long lngmId)
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
 /// <returns>返回:[K_mId_vRTConceptRela]类型的对象</returns>
public static implicit operator K_mId_vRTConceptRela(long value)
{
return new K_mId_vRTConceptRela(value);
}
}
 /// <summary>
 /// vRTConceptRela(vRTConceptRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvRTConceptRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vRTConceptRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 29;
public static string[] AttributeName = new string[] {"mId", "TopicId", "ConceptId", "UpdDate", "Memo", "TopicName", "TopicContent", "OrderNum", "TopicProposePeople", "ConceptContent", "ConceptName", "AppraiseCount", "CitationCount", "CitationId", "IsSubmit", "Score", "StuScore", "TeaScore", "ConcepDate", "ConcepUserId", "IdCurrEduCls", "PdfContent", "PdfPageNum", "OkCount", "VersionCount", "CreateDate", "ShareId", "UpdUser", "ClassificationId"};

protected long mlngmId;    //mId
protected string mstrTopicId;    //主题Id
protected string mstrConceptId;    //概念Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrTopicName;    //栏目主题
protected string mstrTopicContent;    //主题内容
protected int? mintOrderNum;    //序号
protected string mstrTopicProposePeople;    //主题提出人
protected string mstrConceptContent;    //概念内容
protected string mstrConceptName;    //概念名称
protected int? mintAppraiseCount;    //评论数
protected int? mintCitationCount;    //引用统计
protected string mstrCitationId;    //引用Id
protected bool mbolIsSubmit;    //是否提交
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrConcepDate;    //ConcepDate
protected string mstrConcepUserId;    //ConcepUserId
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected int? mintOkCount;    //点赞统计
protected int? mintVersionCount;    //版本统计
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id
protected string mstrUpdUser;    //修改人
protected string mstrClassificationId;    //分类Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvRTConceptRelaEN()
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
public clsvRTConceptRelaEN(long lngmId)
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
if (strAttributeName  ==  convRTConceptRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convRTConceptRela.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  convRTConceptRela.ConceptId)
{
return mstrConceptId;
}
else if (strAttributeName  ==  convRTConceptRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convRTConceptRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convRTConceptRela.TopicName)
{
return mstrTopicName;
}
else if (strAttributeName  ==  convRTConceptRela.TopicContent)
{
return mstrTopicContent;
}
else if (strAttributeName  ==  convRTConceptRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convRTConceptRela.TopicProposePeople)
{
return mstrTopicProposePeople;
}
else if (strAttributeName  ==  convRTConceptRela.ConceptContent)
{
return mstrConceptContent;
}
else if (strAttributeName  ==  convRTConceptRela.ConceptName)
{
return mstrConceptName;
}
else if (strAttributeName  ==  convRTConceptRela.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convRTConceptRela.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convRTConceptRela.CitationId)
{
return mstrCitationId;
}
else if (strAttributeName  ==  convRTConceptRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convRTConceptRela.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convRTConceptRela.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convRTConceptRela.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convRTConceptRela.ConcepDate)
{
return mstrConcepDate;
}
else if (strAttributeName  ==  convRTConceptRela.ConcepUserId)
{
return mstrConcepUserId;
}
else if (strAttributeName  ==  convRTConceptRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convRTConceptRela.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convRTConceptRela.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convRTConceptRela.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convRTConceptRela.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convRTConceptRela.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convRTConceptRela.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  convRTConceptRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convRTConceptRela.ClassificationId)
{
return mstrClassificationId;
}
return null;
}
set
{
if (strAttributeName  ==  convRTConceptRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTConceptRela.mId);
}
else if (strAttributeName  ==  convRTConceptRela.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTConceptRela.TopicId);
}
else if (strAttributeName  ==  convRTConceptRela.ConceptId)
{
mstrConceptId = value.ToString();
 AddUpdatedFld(convRTConceptRela.ConceptId);
}
else if (strAttributeName  ==  convRTConceptRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTConceptRela.UpdDate);
}
else if (strAttributeName  ==  convRTConceptRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convRTConceptRela.Memo);
}
else if (strAttributeName  ==  convRTConceptRela.TopicName)
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTConceptRela.TopicName);
}
else if (strAttributeName  ==  convRTConceptRela.TopicContent)
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTConceptRela.TopicContent);
}
else if (strAttributeName  ==  convRTConceptRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTConceptRela.OrderNum);
}
else if (strAttributeName  ==  convRTConceptRela.TopicProposePeople)
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convRTConceptRela.TopicProposePeople);
}
else if (strAttributeName  ==  convRTConceptRela.ConceptContent)
{
mstrConceptContent = value.ToString();
 AddUpdatedFld(convRTConceptRela.ConceptContent);
}
else if (strAttributeName  ==  convRTConceptRela.ConceptName)
{
mstrConceptName = value.ToString();
 AddUpdatedFld(convRTConceptRela.ConceptName);
}
else if (strAttributeName  ==  convRTConceptRela.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTConceptRela.AppraiseCount);
}
else if (strAttributeName  ==  convRTConceptRela.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTConceptRela.CitationCount);
}
else if (strAttributeName  ==  convRTConceptRela.CitationId)
{
mstrCitationId = value.ToString();
 AddUpdatedFld(convRTConceptRela.CitationId);
}
else if (strAttributeName  ==  convRTConceptRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTConceptRela.IsSubmit);
}
else if (strAttributeName  ==  convRTConceptRela.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTConceptRela.Score);
}
else if (strAttributeName  ==  convRTConceptRela.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTConceptRela.StuScore);
}
else if (strAttributeName  ==  convRTConceptRela.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTConceptRela.TeaScore);
}
else if (strAttributeName  ==  convRTConceptRela.ConcepDate)
{
mstrConcepDate = value.ToString();
 AddUpdatedFld(convRTConceptRela.ConcepDate);
}
else if (strAttributeName  ==  convRTConceptRela.ConcepUserId)
{
mstrConcepUserId = value.ToString();
 AddUpdatedFld(convRTConceptRela.ConcepUserId);
}
else if (strAttributeName  ==  convRTConceptRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convRTConceptRela.IdCurrEduCls);
}
else if (strAttributeName  ==  convRTConceptRela.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convRTConceptRela.PdfContent);
}
else if (strAttributeName  ==  convRTConceptRela.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTConceptRela.PdfPageNum);
}
else if (strAttributeName  ==  convRTConceptRela.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTConceptRela.OkCount);
}
else if (strAttributeName  ==  convRTConceptRela.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTConceptRela.VersionCount);
}
else if (strAttributeName  ==  convRTConceptRela.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convRTConceptRela.CreateDate);
}
else if (strAttributeName  ==  convRTConceptRela.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convRTConceptRela.ShareId);
}
else if (strAttributeName  ==  convRTConceptRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTConceptRela.UpdUser);
}
else if (strAttributeName  ==  convRTConceptRela.ClassificationId)
{
mstrClassificationId = value.ToString();
 AddUpdatedFld(convRTConceptRela.ClassificationId);
}
}
}
public object this[int intIndex]
{
get
{
if (convRTConceptRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convRTConceptRela.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (convRTConceptRela.ConceptId  ==  AttributeName[intIndex])
{
return mstrConceptId;
}
else if (convRTConceptRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convRTConceptRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convRTConceptRela.TopicName  ==  AttributeName[intIndex])
{
return mstrTopicName;
}
else if (convRTConceptRela.TopicContent  ==  AttributeName[intIndex])
{
return mstrTopicContent;
}
else if (convRTConceptRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convRTConceptRela.TopicProposePeople  ==  AttributeName[intIndex])
{
return mstrTopicProposePeople;
}
else if (convRTConceptRela.ConceptContent  ==  AttributeName[intIndex])
{
return mstrConceptContent;
}
else if (convRTConceptRela.ConceptName  ==  AttributeName[intIndex])
{
return mstrConceptName;
}
else if (convRTConceptRela.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convRTConceptRela.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convRTConceptRela.CitationId  ==  AttributeName[intIndex])
{
return mstrCitationId;
}
else if (convRTConceptRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convRTConceptRela.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convRTConceptRela.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convRTConceptRela.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convRTConceptRela.ConcepDate  ==  AttributeName[intIndex])
{
return mstrConcepDate;
}
else if (convRTConceptRela.ConcepUserId  ==  AttributeName[intIndex])
{
return mstrConcepUserId;
}
else if (convRTConceptRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convRTConceptRela.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convRTConceptRela.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convRTConceptRela.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convRTConceptRela.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convRTConceptRela.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convRTConceptRela.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (convRTConceptRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convRTConceptRela.ClassificationId  ==  AttributeName[intIndex])
{
return mstrClassificationId;
}
return null;
}
set
{
if (convRTConceptRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTConceptRela.mId);
}
else if (convRTConceptRela.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTConceptRela.TopicId);
}
else if (convRTConceptRela.ConceptId  ==  AttributeName[intIndex])
{
mstrConceptId = value.ToString();
 AddUpdatedFld(convRTConceptRela.ConceptId);
}
else if (convRTConceptRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTConceptRela.UpdDate);
}
else if (convRTConceptRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convRTConceptRela.Memo);
}
else if (convRTConceptRela.TopicName  ==  AttributeName[intIndex])
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTConceptRela.TopicName);
}
else if (convRTConceptRela.TopicContent  ==  AttributeName[intIndex])
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTConceptRela.TopicContent);
}
else if (convRTConceptRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTConceptRela.OrderNum);
}
else if (convRTConceptRela.TopicProposePeople  ==  AttributeName[intIndex])
{
mstrTopicProposePeople = value.ToString();
 AddUpdatedFld(convRTConceptRela.TopicProposePeople);
}
else if (convRTConceptRela.ConceptContent  ==  AttributeName[intIndex])
{
mstrConceptContent = value.ToString();
 AddUpdatedFld(convRTConceptRela.ConceptContent);
}
else if (convRTConceptRela.ConceptName  ==  AttributeName[intIndex])
{
mstrConceptName = value.ToString();
 AddUpdatedFld(convRTConceptRela.ConceptName);
}
else if (convRTConceptRela.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTConceptRela.AppraiseCount);
}
else if (convRTConceptRela.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTConceptRela.CitationCount);
}
else if (convRTConceptRela.CitationId  ==  AttributeName[intIndex])
{
mstrCitationId = value.ToString();
 AddUpdatedFld(convRTConceptRela.CitationId);
}
else if (convRTConceptRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTConceptRela.IsSubmit);
}
else if (convRTConceptRela.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTConceptRela.Score);
}
else if (convRTConceptRela.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTConceptRela.StuScore);
}
else if (convRTConceptRela.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTConceptRela.TeaScore);
}
else if (convRTConceptRela.ConcepDate  ==  AttributeName[intIndex])
{
mstrConcepDate = value.ToString();
 AddUpdatedFld(convRTConceptRela.ConcepDate);
}
else if (convRTConceptRela.ConcepUserId  ==  AttributeName[intIndex])
{
mstrConcepUserId = value.ToString();
 AddUpdatedFld(convRTConceptRela.ConcepUserId);
}
else if (convRTConceptRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convRTConceptRela.IdCurrEduCls);
}
else if (convRTConceptRela.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convRTConceptRela.PdfContent);
}
else if (convRTConceptRela.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTConceptRela.PdfPageNum);
}
else if (convRTConceptRela.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTConceptRela.OkCount);
}
else if (convRTConceptRela.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTConceptRela.VersionCount);
}
else if (convRTConceptRela.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convRTConceptRela.CreateDate);
}
else if (convRTConceptRela.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convRTConceptRela.ShareId);
}
else if (convRTConceptRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTConceptRela.UpdUser);
}
else if (convRTConceptRela.ClassificationId  ==  AttributeName[intIndex])
{
mstrClassificationId = value.ToString();
 AddUpdatedFld(convRTConceptRela.ClassificationId);
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
 AddUpdatedFld(convRTConceptRela.mId);
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
 AddUpdatedFld(convRTConceptRela.TopicId);
}
}
/// <summary>
/// 概念Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptId
{
get
{
return mstrConceptId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptId = value;
}
else
{
 mstrConceptId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTConceptRela.ConceptId);
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
 AddUpdatedFld(convRTConceptRela.UpdDate);
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
 AddUpdatedFld(convRTConceptRela.Memo);
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
 AddUpdatedFld(convRTConceptRela.TopicName);
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
 AddUpdatedFld(convRTConceptRela.TopicContent);
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
 AddUpdatedFld(convRTConceptRela.OrderNum);
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
 AddUpdatedFld(convRTConceptRela.TopicProposePeople);
}
}
/// <summary>
/// 概念内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptContent
{
get
{
return mstrConceptContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptContent = value;
}
else
{
 mstrConceptContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTConceptRela.ConceptContent);
}
}
/// <summary>
/// 概念名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptName
{
get
{
return mstrConceptName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptName = value;
}
else
{
 mstrConceptName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTConceptRela.ConceptName);
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
 AddUpdatedFld(convRTConceptRela.AppraiseCount);
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
 AddUpdatedFld(convRTConceptRela.CitationCount);
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
 AddUpdatedFld(convRTConceptRela.CitationId);
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
 AddUpdatedFld(convRTConceptRela.IsSubmit);
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
 AddUpdatedFld(convRTConceptRela.Score);
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
 AddUpdatedFld(convRTConceptRela.StuScore);
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
 AddUpdatedFld(convRTConceptRela.TeaScore);
}
}
/// <summary>
/// ConcepDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConcepDate
{
get
{
return mstrConcepDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConcepDate = value;
}
else
{
 mstrConcepDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTConceptRela.ConcepDate);
}
}
/// <summary>
/// ConcepUserId(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConcepUserId
{
get
{
return mstrConcepUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConcepUserId = value;
}
else
{
 mstrConcepUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTConceptRela.ConcepUserId);
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
 AddUpdatedFld(convRTConceptRela.IdCurrEduCls);
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
 AddUpdatedFld(convRTConceptRela.PdfContent);
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
 AddUpdatedFld(convRTConceptRela.PdfPageNum);
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
 AddUpdatedFld(convRTConceptRela.OkCount);
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
 AddUpdatedFld(convRTConceptRela.VersionCount);
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
 AddUpdatedFld(convRTConceptRela.CreateDate);
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
 AddUpdatedFld(convRTConceptRela.ShareId);
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
 AddUpdatedFld(convRTConceptRela.UpdUser);
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
 AddUpdatedFld(convRTConceptRela.ClassificationId);
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
 /// vRTConceptRela(vRTConceptRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convRTConceptRela
{
public const string _CurrTabName = "vRTConceptRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "TopicId", "ConceptId", "UpdDate", "Memo", "TopicName", "TopicContent", "OrderNum", "TopicProposePeople", "ConceptContent", "ConceptName", "AppraiseCount", "CitationCount", "CitationId", "IsSubmit", "Score", "StuScore", "TeaScore", "ConcepDate", "ConcepUserId", "IdCurrEduCls", "PdfContent", "PdfPageNum", "OkCount", "VersionCount", "CreateDate", "ShareId", "UpdUser", "ClassificationId"};
//以下是属性变量


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
 /// 常量:"ConceptId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptId = "ConceptId";    //概念Id

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
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"TopicProposePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicProposePeople = "TopicProposePeople";    //主题提出人

 /// <summary>
 /// 常量:"ConceptContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptContent = "ConceptContent";    //概念内容

 /// <summary>
 /// 常量:"ConceptName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptName = "ConceptName";    //概念名称

 /// <summary>
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数

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
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

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
 /// 常量:"ConcepDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConcepDate = "ConcepDate";    //ConcepDate

 /// <summary>
 /// 常量:"ConcepUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConcepUserId = "ConcepUserId";    //ConcepUserId

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
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

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
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"ClassificationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassificationId = "ClassificationId";    //分类Id
}

}