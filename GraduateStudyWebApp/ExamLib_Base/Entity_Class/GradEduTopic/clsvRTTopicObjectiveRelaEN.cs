
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTTopicObjectiveRelaEN
 表名:vRTTopicObjectiveRela(01120616)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:05:38
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
 /// 表vRTTopicObjectiveRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vRTTopicObjectiveRela
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
public K_mId_vRTTopicObjectiveRela(long lngmId)
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
 /// <returns>返回:[K_mId_vRTTopicObjectiveRela]类型的对象</returns>
public static implicit operator K_mId_vRTTopicObjectiveRela(long value)
{
return new K_mId_vRTTopicObjectiveRela(value);
}
}
 /// <summary>
 /// vRTTopicObjectiveRela(vRTTopicObjectiveRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvRTTopicObjectiveRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vRTTopicObjectiveRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 29;
public static string[] AttributeName = new string[] {"mId", "TopicId", "TopicObjectiveId", "UpdDate", "UpdUser", "ObjectiveTypeName", "ObjectiveType", "SourceId", "IsSubmit", "ObjectiveName", "ObjectiveContent", "Conclusion", "TopicContent", "TopicName", "AppraiseCount", "CitationCount", "Score", "StuScore", "TeaScore", "ObjDate", "ObjUserId", "IdCurrEduCls", "PdfContent", "PdfPageNum", "OkCount", "VersionCount", "CreateDate", "ShareId", "ClassificationId"};

protected long mlngmId;    //mId
protected string mstrTopicId;    //主题Id
protected string mstrTopicObjectiveId;    //客观Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrObjectiveTypeName;    //ObjectiveTypeName
protected string mstrObjectiveType;    //客观类型
protected string mstrSourceId;    //来源Id
protected bool mbolIsSubmit;    //是否提交
protected string mstrObjectiveName;    //客观名称
protected string mstrObjectiveContent;    //客观内容
protected string mstrConclusion;    //结论
protected string mstrTopicContent;    //主题内容
protected string mstrTopicName;    //栏目主题
protected int? mintAppraiseCount;    //评论数
protected int? mintCitationCount;    //引用统计
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrObjDate;    //ObjDate
protected string mstrObjUserId;    //ObjUserId
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected int? mintOkCount;    //点赞统计
protected int? mintVersionCount;    //版本统计
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id
protected string mstrClassificationId;    //分类Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvRTTopicObjectiveRelaEN()
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
public clsvRTTopicObjectiveRelaEN(long lngmId)
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
if (strAttributeName  ==  convRTTopicObjectiveRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.TopicId)
{
return mstrTopicId;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.TopicObjectiveId)
{
return mstrTopicObjectiveId;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.ObjectiveTypeName)
{
return mstrObjectiveTypeName;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.ObjectiveType)
{
return mstrObjectiveType;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.SourceId)
{
return mstrSourceId;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.ObjectiveName)
{
return mstrObjectiveName;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.ObjectiveContent)
{
return mstrObjectiveContent;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.Conclusion)
{
return mstrConclusion;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.TopicContent)
{
return mstrTopicContent;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.TopicName)
{
return mstrTopicName;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.ObjDate)
{
return mstrObjDate;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.ObjUserId)
{
return mstrObjUserId;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.ClassificationId)
{
return mstrClassificationId;
}
return null;
}
set
{
if (strAttributeName  ==  convRTTopicObjectiveRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.mId);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.TopicId)
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.TopicId);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.TopicObjectiveId)
{
mstrTopicObjectiveId = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.TopicObjectiveId);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.UpdDate);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.UpdUser);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.ObjectiveTypeName)
{
mstrObjectiveTypeName = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.ObjectiveTypeName);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.ObjectiveType)
{
mstrObjectiveType = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.ObjectiveType);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.SourceId)
{
mstrSourceId = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.SourceId);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.IsSubmit);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.ObjectiveName)
{
mstrObjectiveName = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.ObjectiveName);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.ObjectiveContent)
{
mstrObjectiveContent = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.ObjectiveContent);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.Conclusion)
{
mstrConclusion = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.Conclusion);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.TopicContent)
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.TopicContent);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.TopicName)
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.TopicName);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.AppraiseCount);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.CitationCount);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.Score);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.StuScore);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.TeaScore);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.ObjDate)
{
mstrObjDate = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.ObjDate);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.ObjUserId)
{
mstrObjUserId = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.ObjUserId);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.IdCurrEduCls);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.PdfContent);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.PdfPageNum);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.OkCount);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.VersionCount);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.CreateDate);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.ShareId);
}
else if (strAttributeName  ==  convRTTopicObjectiveRela.ClassificationId)
{
mstrClassificationId = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.ClassificationId);
}
}
}
public object this[int intIndex]
{
get
{
if (convRTTopicObjectiveRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convRTTopicObjectiveRela.TopicId  ==  AttributeName[intIndex])
{
return mstrTopicId;
}
else if (convRTTopicObjectiveRela.TopicObjectiveId  ==  AttributeName[intIndex])
{
return mstrTopicObjectiveId;
}
else if (convRTTopicObjectiveRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convRTTopicObjectiveRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convRTTopicObjectiveRela.ObjectiveTypeName  ==  AttributeName[intIndex])
{
return mstrObjectiveTypeName;
}
else if (convRTTopicObjectiveRela.ObjectiveType  ==  AttributeName[intIndex])
{
return mstrObjectiveType;
}
else if (convRTTopicObjectiveRela.SourceId  ==  AttributeName[intIndex])
{
return mstrSourceId;
}
else if (convRTTopicObjectiveRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convRTTopicObjectiveRela.ObjectiveName  ==  AttributeName[intIndex])
{
return mstrObjectiveName;
}
else if (convRTTopicObjectiveRela.ObjectiveContent  ==  AttributeName[intIndex])
{
return mstrObjectiveContent;
}
else if (convRTTopicObjectiveRela.Conclusion  ==  AttributeName[intIndex])
{
return mstrConclusion;
}
else if (convRTTopicObjectiveRela.TopicContent  ==  AttributeName[intIndex])
{
return mstrTopicContent;
}
else if (convRTTopicObjectiveRela.TopicName  ==  AttributeName[intIndex])
{
return mstrTopicName;
}
else if (convRTTopicObjectiveRela.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convRTTopicObjectiveRela.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convRTTopicObjectiveRela.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convRTTopicObjectiveRela.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convRTTopicObjectiveRela.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convRTTopicObjectiveRela.ObjDate  ==  AttributeName[intIndex])
{
return mstrObjDate;
}
else if (convRTTopicObjectiveRela.ObjUserId  ==  AttributeName[intIndex])
{
return mstrObjUserId;
}
else if (convRTTopicObjectiveRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convRTTopicObjectiveRela.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convRTTopicObjectiveRela.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convRTTopicObjectiveRela.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convRTTopicObjectiveRela.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convRTTopicObjectiveRela.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convRTTopicObjectiveRela.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (convRTTopicObjectiveRela.ClassificationId  ==  AttributeName[intIndex])
{
return mstrClassificationId;
}
return null;
}
set
{
if (convRTTopicObjectiveRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.mId);
}
else if (convRTTopicObjectiveRela.TopicId  ==  AttributeName[intIndex])
{
mstrTopicId = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.TopicId);
}
else if (convRTTopicObjectiveRela.TopicObjectiveId  ==  AttributeName[intIndex])
{
mstrTopicObjectiveId = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.TopicObjectiveId);
}
else if (convRTTopicObjectiveRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.UpdDate);
}
else if (convRTTopicObjectiveRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.UpdUser);
}
else if (convRTTopicObjectiveRela.ObjectiveTypeName  ==  AttributeName[intIndex])
{
mstrObjectiveTypeName = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.ObjectiveTypeName);
}
else if (convRTTopicObjectiveRela.ObjectiveType  ==  AttributeName[intIndex])
{
mstrObjectiveType = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.ObjectiveType);
}
else if (convRTTopicObjectiveRela.SourceId  ==  AttributeName[intIndex])
{
mstrSourceId = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.SourceId);
}
else if (convRTTopicObjectiveRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.IsSubmit);
}
else if (convRTTopicObjectiveRela.ObjectiveName  ==  AttributeName[intIndex])
{
mstrObjectiveName = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.ObjectiveName);
}
else if (convRTTopicObjectiveRela.ObjectiveContent  ==  AttributeName[intIndex])
{
mstrObjectiveContent = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.ObjectiveContent);
}
else if (convRTTopicObjectiveRela.Conclusion  ==  AttributeName[intIndex])
{
mstrConclusion = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.Conclusion);
}
else if (convRTTopicObjectiveRela.TopicContent  ==  AttributeName[intIndex])
{
mstrTopicContent = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.TopicContent);
}
else if (convRTTopicObjectiveRela.TopicName  ==  AttributeName[intIndex])
{
mstrTopicName = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.TopicName);
}
else if (convRTTopicObjectiveRela.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.AppraiseCount);
}
else if (convRTTopicObjectiveRela.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.CitationCount);
}
else if (convRTTopicObjectiveRela.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.Score);
}
else if (convRTTopicObjectiveRela.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.StuScore);
}
else if (convRTTopicObjectiveRela.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.TeaScore);
}
else if (convRTTopicObjectiveRela.ObjDate  ==  AttributeName[intIndex])
{
mstrObjDate = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.ObjDate);
}
else if (convRTTopicObjectiveRela.ObjUserId  ==  AttributeName[intIndex])
{
mstrObjUserId = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.ObjUserId);
}
else if (convRTTopicObjectiveRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.IdCurrEduCls);
}
else if (convRTTopicObjectiveRela.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.PdfContent);
}
else if (convRTTopicObjectiveRela.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.PdfPageNum);
}
else if (convRTTopicObjectiveRela.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.OkCount);
}
else if (convRTTopicObjectiveRela.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convRTTopicObjectiveRela.VersionCount);
}
else if (convRTTopicObjectiveRela.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.CreateDate);
}
else if (convRTTopicObjectiveRela.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.ShareId);
}
else if (convRTTopicObjectiveRela.ClassificationId  ==  AttributeName[intIndex])
{
mstrClassificationId = value.ToString();
 AddUpdatedFld(convRTTopicObjectiveRela.ClassificationId);
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
 AddUpdatedFld(convRTTopicObjectiveRela.mId);
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
 AddUpdatedFld(convRTTopicObjectiveRela.TopicId);
}
}
/// <summary>
/// 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicObjectiveId
{
get
{
return mstrTopicObjectiveId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicObjectiveId = value;
}
else
{
 mstrTopicObjectiveId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTTopicObjectiveRela.TopicObjectiveId);
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
 AddUpdatedFld(convRTTopicObjectiveRela.UpdDate);
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
 AddUpdatedFld(convRTTopicObjectiveRela.UpdUser);
}
}
/// <summary>
/// ObjectiveTypeName(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveTypeName
{
get
{
return mstrObjectiveTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveTypeName = value;
}
else
{
 mstrObjectiveTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTTopicObjectiveRela.ObjectiveTypeName);
}
}
/// <summary>
/// 客观类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveType
{
get
{
return mstrObjectiveType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveType = value;
}
else
{
 mstrObjectiveType = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTTopicObjectiveRela.ObjectiveType);
}
}
/// <summary>
/// 来源Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourceId
{
get
{
return mstrSourceId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourceId = value;
}
else
{
 mstrSourceId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTTopicObjectiveRela.SourceId);
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
 AddUpdatedFld(convRTTopicObjectiveRela.IsSubmit);
}
}
/// <summary>
/// 客观名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveName
{
get
{
return mstrObjectiveName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveName = value;
}
else
{
 mstrObjectiveName = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTTopicObjectiveRela.ObjectiveName);
}
}
/// <summary>
/// 客观内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveContent
{
get
{
return mstrObjectiveContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveContent = value;
}
else
{
 mstrObjectiveContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTTopicObjectiveRela.ObjectiveContent);
}
}
/// <summary>
/// 结论(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
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
 AddUpdatedFld(convRTTopicObjectiveRela.Conclusion);
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
 AddUpdatedFld(convRTTopicObjectiveRela.TopicContent);
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
 AddUpdatedFld(convRTTopicObjectiveRela.TopicName);
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
 AddUpdatedFld(convRTTopicObjectiveRela.AppraiseCount);
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
 AddUpdatedFld(convRTTopicObjectiveRela.CitationCount);
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
 AddUpdatedFld(convRTTopicObjectiveRela.Score);
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
 AddUpdatedFld(convRTTopicObjectiveRela.StuScore);
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
 AddUpdatedFld(convRTTopicObjectiveRela.TeaScore);
}
}
/// <summary>
/// ObjDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjDate
{
get
{
return mstrObjDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjDate = value;
}
else
{
 mstrObjDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTTopicObjectiveRela.ObjDate);
}
}
/// <summary>
/// ObjUserId(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjUserId
{
get
{
return mstrObjUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjUserId = value;
}
else
{
 mstrObjUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convRTTopicObjectiveRela.ObjUserId);
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
 AddUpdatedFld(convRTTopicObjectiveRela.IdCurrEduCls);
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
 AddUpdatedFld(convRTTopicObjectiveRela.PdfContent);
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
 AddUpdatedFld(convRTTopicObjectiveRela.PdfPageNum);
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
 AddUpdatedFld(convRTTopicObjectiveRela.OkCount);
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
 AddUpdatedFld(convRTTopicObjectiveRela.VersionCount);
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
 AddUpdatedFld(convRTTopicObjectiveRela.CreateDate);
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
 AddUpdatedFld(convRTTopicObjectiveRela.ShareId);
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
 AddUpdatedFld(convRTTopicObjectiveRela.ClassificationId);
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
 /// vRTTopicObjectiveRela(vRTTopicObjectiveRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convRTTopicObjectiveRela
{
public const string _CurrTabName = "vRTTopicObjectiveRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "TopicId", "TopicObjectiveId", "UpdDate", "UpdUser", "ObjectiveTypeName", "ObjectiveType", "SourceId", "IsSubmit", "ObjectiveName", "ObjectiveContent", "Conclusion", "TopicContent", "TopicName", "AppraiseCount", "CitationCount", "Score", "StuScore", "TeaScore", "ObjDate", "ObjUserId", "IdCurrEduCls", "PdfContent", "PdfPageNum", "OkCount", "VersionCount", "CreateDate", "ShareId", "ClassificationId"};
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
 /// 常量:"TopicObjectiveId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicObjectiveId = "TopicObjectiveId";    //客观Id

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
 /// 常量:"ObjectiveTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveTypeName = "ObjectiveTypeName";    //ObjectiveTypeName

 /// <summary>
 /// 常量:"ObjectiveType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveType = "ObjectiveType";    //客观类型

 /// <summary>
 /// 常量:"SourceId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceId = "SourceId";    //来源Id

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"ObjectiveName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveName = "ObjectiveName";    //客观名称

 /// <summary>
 /// 常量:"ObjectiveContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveContent = "ObjectiveContent";    //客观内容

 /// <summary>
 /// 常量:"Conclusion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Conclusion = "Conclusion";    //结论

 /// <summary>
 /// 常量:"TopicContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicContent = "TopicContent";    //主题内容

 /// <summary>
 /// 常量:"TopicName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicName = "TopicName";    //栏目主题

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
 /// 常量:"ObjDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjDate = "ObjDate";    //ObjDate

 /// <summary>
 /// 常量:"ObjUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjUserId = "ObjUserId";    //ObjUserId

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
 /// 常量:"ClassificationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassificationId = "ClassificationId";    //分类Id
}

}