
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PTopicObjectiveRelaEN
 表名:vgs_PTopicObjectiveRela(01120667)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// 表vgs_PTopicObjectiveRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vgs_PTopicObjectiveRela
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
public K_mId_vgs_PTopicObjectiveRela(long lngmId)
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
 /// <returns>返回:[K_mId_vgs_PTopicObjectiveRela]类型的对象</returns>
public static implicit operator K_mId_vgs_PTopicObjectiveRela(long value)
{
return new K_mId_vgs_PTopicObjectiveRela(value);
}
}
 /// <summary>
 /// 论文客观关系视图(vgs_PTopicObjectiveRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvgs_PTopicObjectiveRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vgs_PTopicObjectiveRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 27;
public static string[] AttributeName = new string[] {"mId", "PaperId", "PaperTitle", "PaperTypeId", "SectionId", "SectionName", "TopicObjectiveId", "ObjectiveName", "ObjectiveContent", "ObjectiveType", "IsSubmit", "ObjectiveTypeName", "TeaScore", "StuScore", "Score", "AppraiseCount", "OkCount", "VersionCount", "CitationCount", "UpdDate", "UpdUser", "Memo", "ObjUserId", "ObjDate", "Conclusion", "CreateDate", "ShareId"};

protected long mlngmId;    //mId
protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected string mstrPaperTypeId;    //论文类型Id
protected string mstrSectionId;    //节Id
protected string mstrSectionName;    //节名
protected string mstrTopicObjectiveId;    //客观Id
protected string mstrObjectiveName;    //客观名称
protected string mstrObjectiveContent;    //客观内容
protected string mstrObjectiveType;    //客观类型
protected bool mbolIsSubmit;    //是否提交
protected string mstrObjectiveTypeName;    //ObjectiveTypeName
protected float? mfltTeaScore;    //教师评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltScore;    //评分
protected int? mintAppraiseCount;    //评论数
protected int? mintOkCount;    //点赞统计
protected int? mintVersionCount;    //版本统计
protected int? mintCitationCount;    //引用统计
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrObjUserId;    //ObjUserId
protected string mstrObjDate;    //ObjDate
protected string mstrConclusion;    //结论
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvgs_PTopicObjectiveRelaEN()
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
public clsvgs_PTopicObjectiveRelaEN(long lngmId)
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
if (strAttributeName  ==  convgs_PTopicObjectiveRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.PaperTypeId)
{
return mstrPaperTypeId;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.TopicObjectiveId)
{
return mstrTopicObjectiveId;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.ObjectiveName)
{
return mstrObjectiveName;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.ObjectiveContent)
{
return mstrObjectiveContent;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.ObjectiveType)
{
return mstrObjectiveType;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.ObjectiveTypeName)
{
return mstrObjectiveTypeName;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.ObjUserId)
{
return mstrObjUserId;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.ObjDate)
{
return mstrObjDate;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.Conclusion)
{
return mstrConclusion;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.ShareId)
{
return mstrShareId;
}
return null;
}
set
{
if (strAttributeName  ==  convgs_PTopicObjectiveRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.mId);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.PaperId);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.PaperTitle);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.PaperTypeId)
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.PaperTypeId);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.SectionId);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.SectionName);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.TopicObjectiveId)
{
mstrTopicObjectiveId = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.TopicObjectiveId);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.ObjectiveName)
{
mstrObjectiveName = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjectiveName);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.ObjectiveContent)
{
mstrObjectiveContent = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjectiveContent);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.ObjectiveType)
{
mstrObjectiveType = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjectiveType);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.IsSubmit);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.ObjectiveTypeName)
{
mstrObjectiveTypeName = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjectiveTypeName);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.TeaScore);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.StuScore);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.Score);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.AppraiseCount);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.OkCount);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.VersionCount);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.CitationCount);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.UpdDate);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.UpdUser);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.Memo);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.ObjUserId)
{
mstrObjUserId = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjUserId);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.ObjDate)
{
mstrObjDate = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjDate);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.Conclusion)
{
mstrConclusion = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.Conclusion);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.CreateDate);
}
else if (strAttributeName  ==  convgs_PTopicObjectiveRela.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.ShareId);
}
}
}
public object this[int intIndex]
{
get
{
if (convgs_PTopicObjectiveRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convgs_PTopicObjectiveRela.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convgs_PTopicObjectiveRela.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convgs_PTopicObjectiveRela.PaperTypeId  ==  AttributeName[intIndex])
{
return mstrPaperTypeId;
}
else if (convgs_PTopicObjectiveRela.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convgs_PTopicObjectiveRela.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convgs_PTopicObjectiveRela.TopicObjectiveId  ==  AttributeName[intIndex])
{
return mstrTopicObjectiveId;
}
else if (convgs_PTopicObjectiveRela.ObjectiveName  ==  AttributeName[intIndex])
{
return mstrObjectiveName;
}
else if (convgs_PTopicObjectiveRela.ObjectiveContent  ==  AttributeName[intIndex])
{
return mstrObjectiveContent;
}
else if (convgs_PTopicObjectiveRela.ObjectiveType  ==  AttributeName[intIndex])
{
return mstrObjectiveType;
}
else if (convgs_PTopicObjectiveRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convgs_PTopicObjectiveRela.ObjectiveTypeName  ==  AttributeName[intIndex])
{
return mstrObjectiveTypeName;
}
else if (convgs_PTopicObjectiveRela.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convgs_PTopicObjectiveRela.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convgs_PTopicObjectiveRela.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convgs_PTopicObjectiveRela.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convgs_PTopicObjectiveRela.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convgs_PTopicObjectiveRela.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convgs_PTopicObjectiveRela.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convgs_PTopicObjectiveRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convgs_PTopicObjectiveRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convgs_PTopicObjectiveRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convgs_PTopicObjectiveRela.ObjUserId  ==  AttributeName[intIndex])
{
return mstrObjUserId;
}
else if (convgs_PTopicObjectiveRela.ObjDate  ==  AttributeName[intIndex])
{
return mstrObjDate;
}
else if (convgs_PTopicObjectiveRela.Conclusion  ==  AttributeName[intIndex])
{
return mstrConclusion;
}
else if (convgs_PTopicObjectiveRela.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convgs_PTopicObjectiveRela.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
return null;
}
set
{
if (convgs_PTopicObjectiveRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.mId);
}
else if (convgs_PTopicObjectiveRela.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.PaperId);
}
else if (convgs_PTopicObjectiveRela.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.PaperTitle);
}
else if (convgs_PTopicObjectiveRela.PaperTypeId  ==  AttributeName[intIndex])
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.PaperTypeId);
}
else if (convgs_PTopicObjectiveRela.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.SectionId);
}
else if (convgs_PTopicObjectiveRela.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.SectionName);
}
else if (convgs_PTopicObjectiveRela.TopicObjectiveId  ==  AttributeName[intIndex])
{
mstrTopicObjectiveId = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.TopicObjectiveId);
}
else if (convgs_PTopicObjectiveRela.ObjectiveName  ==  AttributeName[intIndex])
{
mstrObjectiveName = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjectiveName);
}
else if (convgs_PTopicObjectiveRela.ObjectiveContent  ==  AttributeName[intIndex])
{
mstrObjectiveContent = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjectiveContent);
}
else if (convgs_PTopicObjectiveRela.ObjectiveType  ==  AttributeName[intIndex])
{
mstrObjectiveType = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjectiveType);
}
else if (convgs_PTopicObjectiveRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.IsSubmit);
}
else if (convgs_PTopicObjectiveRela.ObjectiveTypeName  ==  AttributeName[intIndex])
{
mstrObjectiveTypeName = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjectiveTypeName);
}
else if (convgs_PTopicObjectiveRela.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.TeaScore);
}
else if (convgs_PTopicObjectiveRela.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.StuScore);
}
else if (convgs_PTopicObjectiveRela.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.Score);
}
else if (convgs_PTopicObjectiveRela.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.AppraiseCount);
}
else if (convgs_PTopicObjectiveRela.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.OkCount);
}
else if (convgs_PTopicObjectiveRela.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.VersionCount);
}
else if (convgs_PTopicObjectiveRela.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PTopicObjectiveRela.CitationCount);
}
else if (convgs_PTopicObjectiveRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.UpdDate);
}
else if (convgs_PTopicObjectiveRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.UpdUser);
}
else if (convgs_PTopicObjectiveRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.Memo);
}
else if (convgs_PTopicObjectiveRela.ObjUserId  ==  AttributeName[intIndex])
{
mstrObjUserId = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjUserId);
}
else if (convgs_PTopicObjectiveRela.ObjDate  ==  AttributeName[intIndex])
{
mstrObjDate = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjDate);
}
else if (convgs_PTopicObjectiveRela.Conclusion  ==  AttributeName[intIndex])
{
mstrConclusion = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.Conclusion);
}
else if (convgs_PTopicObjectiveRela.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.CreateDate);
}
else if (convgs_PTopicObjectiveRela.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convgs_PTopicObjectiveRela.ShareId);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.mId);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.PaperId);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.PaperTitle);
}
}
/// <summary>
/// 论文类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTypeId
{
get
{
return mstrPaperTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTypeId = value;
}
else
{
 mstrPaperTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PTopicObjectiveRela.PaperTypeId);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.SectionId);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.SectionName);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.TopicObjectiveId);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjectiveName);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjectiveContent);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjectiveType);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.IsSubmit);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjectiveTypeName);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.TeaScore);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.StuScore);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.Score);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.AppraiseCount);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.OkCount);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.VersionCount);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.CitationCount);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.UpdDate);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.UpdUser);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.Memo);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjUserId);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.ObjDate);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.Conclusion);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.CreateDate);
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
 AddUpdatedFld(convgs_PTopicObjectiveRela.ShareId);
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
 /// 论文客观关系视图(vgs_PTopicObjectiveRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convgs_PTopicObjectiveRela
{
public const string _CurrTabName = "vgs_PTopicObjectiveRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "PaperId", "PaperTitle", "PaperTypeId", "SectionId", "SectionName", "TopicObjectiveId", "ObjectiveName", "ObjectiveContent", "ObjectiveType", "IsSubmit", "ObjectiveTypeName", "TeaScore", "StuScore", "Score", "AppraiseCount", "OkCount", "VersionCount", "CitationCount", "UpdDate", "UpdUser", "Memo", "ObjUserId", "ObjDate", "Conclusion", "CreateDate", "ShareId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

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
 /// 常量:"PaperTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTypeId = "PaperTypeId";    //论文类型Id

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
 /// 常量:"TopicObjectiveId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicObjectiveId = "TopicObjectiveId";    //客观Id

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
 /// 常量:"ObjectiveType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveType = "ObjectiveType";    //客观类型

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"ObjectiveTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveTypeName = "ObjectiveTypeName";    //ObjectiveTypeName

 /// <summary>
 /// 常量:"TeaScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaScore = "TeaScore";    //教师评分

 /// <summary>
 /// 常量:"StuScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuScore = "StuScore";    //学生平均分

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
 /// 常量:"CitationCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationCount = "CitationCount";    //引用统计

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
 /// 常量:"ObjUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjUserId = "ObjUserId";    //ObjUserId

 /// <summary>
 /// 常量:"ObjDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjDate = "ObjDate";    //ObjDate

 /// <summary>
 /// 常量:"Conclusion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Conclusion = "Conclusion";    //结论

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
}

}