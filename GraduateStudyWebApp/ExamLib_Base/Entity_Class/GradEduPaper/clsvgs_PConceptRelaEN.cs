
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PConceptRelaEN
 表名:vgs_PConceptRela(01120668)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:13
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
 /// 表vgs_PConceptRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vgs_PConceptRela
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
public K_mId_vgs_PConceptRela(long lngmId)
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
 /// <returns>返回:[K_mId_vgs_PConceptRela]类型的对象</returns>
public static implicit operator K_mId_vgs_PConceptRela(long value)
{
return new K_mId_vgs_PConceptRela(value);
}
}
 /// <summary>
 /// 论文概念关系视图(vgs_PConceptRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvgs_PConceptRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vgs_PConceptRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 24;
public static string[] AttributeName = new string[] {"mId", "PaperId", "PaperTitle", "PaperTypeId", "SectionId", "SectionName", "ConceptId", "ConceptName", "ConceptContent", "IsSubmit", "TeaScore", "StuScore", "Score", "AppraiseCount", "OkCount", "VersionCount", "CitationCount", "UpdDate", "UpdUser", "Memo", "ConcepUserId", "ConcepDate", "CreateDate", "ShareId"};

protected long mlngmId;    //mId
protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected string mstrPaperTypeId;    //论文类型Id
protected string mstrSectionId;    //节Id
protected string mstrSectionName;    //节名
protected string mstrConceptId;    //概念Id
protected string mstrConceptName;    //概念名称
protected string mstrConceptContent;    //概念内容
protected bool mbolIsSubmit;    //是否提交
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
protected string mstrConcepUserId;    //ConcepUserId
protected string mstrConcepDate;    //ConcepDate
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvgs_PConceptRelaEN()
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
public clsvgs_PConceptRelaEN(long lngmId)
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
if (strAttributeName  ==  convgs_PConceptRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convgs_PConceptRela.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convgs_PConceptRela.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convgs_PConceptRela.PaperTypeId)
{
return mstrPaperTypeId;
}
else if (strAttributeName  ==  convgs_PConceptRela.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convgs_PConceptRela.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convgs_PConceptRela.ConceptId)
{
return mstrConceptId;
}
else if (strAttributeName  ==  convgs_PConceptRela.ConceptName)
{
return mstrConceptName;
}
else if (strAttributeName  ==  convgs_PConceptRela.ConceptContent)
{
return mstrConceptContent;
}
else if (strAttributeName  ==  convgs_PConceptRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convgs_PConceptRela.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convgs_PConceptRela.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convgs_PConceptRela.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convgs_PConceptRela.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convgs_PConceptRela.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convgs_PConceptRela.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convgs_PConceptRela.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convgs_PConceptRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convgs_PConceptRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convgs_PConceptRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convgs_PConceptRela.ConcepUserId)
{
return mstrConcepUserId;
}
else if (strAttributeName  ==  convgs_PConceptRela.ConcepDate)
{
return mstrConcepDate;
}
else if (strAttributeName  ==  convgs_PConceptRela.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convgs_PConceptRela.ShareId)
{
return mstrShareId;
}
return null;
}
set
{
if (strAttributeName  ==  convgs_PConceptRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.mId);
}
else if (strAttributeName  ==  convgs_PConceptRela.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.PaperId);
}
else if (strAttributeName  ==  convgs_PConceptRela.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.PaperTitle);
}
else if (strAttributeName  ==  convgs_PConceptRela.PaperTypeId)
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.PaperTypeId);
}
else if (strAttributeName  ==  convgs_PConceptRela.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.SectionId);
}
else if (strAttributeName  ==  convgs_PConceptRela.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.SectionName);
}
else if (strAttributeName  ==  convgs_PConceptRela.ConceptId)
{
mstrConceptId = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.ConceptId);
}
else if (strAttributeName  ==  convgs_PConceptRela.ConceptName)
{
mstrConceptName = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.ConceptName);
}
else if (strAttributeName  ==  convgs_PConceptRela.ConceptContent)
{
mstrConceptContent = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.ConceptContent);
}
else if (strAttributeName  ==  convgs_PConceptRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.IsSubmit);
}
else if (strAttributeName  ==  convgs_PConceptRela.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.TeaScore);
}
else if (strAttributeName  ==  convgs_PConceptRela.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.StuScore);
}
else if (strAttributeName  ==  convgs_PConceptRela.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.Score);
}
else if (strAttributeName  ==  convgs_PConceptRela.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.AppraiseCount);
}
else if (strAttributeName  ==  convgs_PConceptRela.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.OkCount);
}
else if (strAttributeName  ==  convgs_PConceptRela.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.VersionCount);
}
else if (strAttributeName  ==  convgs_PConceptRela.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.CitationCount);
}
else if (strAttributeName  ==  convgs_PConceptRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.UpdDate);
}
else if (strAttributeName  ==  convgs_PConceptRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.UpdUser);
}
else if (strAttributeName  ==  convgs_PConceptRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.Memo);
}
else if (strAttributeName  ==  convgs_PConceptRela.ConcepUserId)
{
mstrConcepUserId = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.ConcepUserId);
}
else if (strAttributeName  ==  convgs_PConceptRela.ConcepDate)
{
mstrConcepDate = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.ConcepDate);
}
else if (strAttributeName  ==  convgs_PConceptRela.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.CreateDate);
}
else if (strAttributeName  ==  convgs_PConceptRela.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.ShareId);
}
}
}
public object this[int intIndex]
{
get
{
if (convgs_PConceptRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convgs_PConceptRela.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convgs_PConceptRela.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convgs_PConceptRela.PaperTypeId  ==  AttributeName[intIndex])
{
return mstrPaperTypeId;
}
else if (convgs_PConceptRela.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convgs_PConceptRela.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convgs_PConceptRela.ConceptId  ==  AttributeName[intIndex])
{
return mstrConceptId;
}
else if (convgs_PConceptRela.ConceptName  ==  AttributeName[intIndex])
{
return mstrConceptName;
}
else if (convgs_PConceptRela.ConceptContent  ==  AttributeName[intIndex])
{
return mstrConceptContent;
}
else if (convgs_PConceptRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convgs_PConceptRela.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convgs_PConceptRela.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convgs_PConceptRela.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convgs_PConceptRela.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convgs_PConceptRela.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convgs_PConceptRela.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convgs_PConceptRela.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convgs_PConceptRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convgs_PConceptRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convgs_PConceptRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convgs_PConceptRela.ConcepUserId  ==  AttributeName[intIndex])
{
return mstrConcepUserId;
}
else if (convgs_PConceptRela.ConcepDate  ==  AttributeName[intIndex])
{
return mstrConcepDate;
}
else if (convgs_PConceptRela.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convgs_PConceptRela.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
return null;
}
set
{
if (convgs_PConceptRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.mId);
}
else if (convgs_PConceptRela.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.PaperId);
}
else if (convgs_PConceptRela.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.PaperTitle);
}
else if (convgs_PConceptRela.PaperTypeId  ==  AttributeName[intIndex])
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.PaperTypeId);
}
else if (convgs_PConceptRela.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.SectionId);
}
else if (convgs_PConceptRela.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.SectionName);
}
else if (convgs_PConceptRela.ConceptId  ==  AttributeName[intIndex])
{
mstrConceptId = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.ConceptId);
}
else if (convgs_PConceptRela.ConceptName  ==  AttributeName[intIndex])
{
mstrConceptName = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.ConceptName);
}
else if (convgs_PConceptRela.ConceptContent  ==  AttributeName[intIndex])
{
mstrConceptContent = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.ConceptContent);
}
else if (convgs_PConceptRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.IsSubmit);
}
else if (convgs_PConceptRela.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.TeaScore);
}
else if (convgs_PConceptRela.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.StuScore);
}
else if (convgs_PConceptRela.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.Score);
}
else if (convgs_PConceptRela.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.AppraiseCount);
}
else if (convgs_PConceptRela.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.OkCount);
}
else if (convgs_PConceptRela.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.VersionCount);
}
else if (convgs_PConceptRela.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PConceptRela.CitationCount);
}
else if (convgs_PConceptRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.UpdDate);
}
else if (convgs_PConceptRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.UpdUser);
}
else if (convgs_PConceptRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.Memo);
}
else if (convgs_PConceptRela.ConcepUserId  ==  AttributeName[intIndex])
{
mstrConcepUserId = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.ConcepUserId);
}
else if (convgs_PConceptRela.ConcepDate  ==  AttributeName[intIndex])
{
mstrConcepDate = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.ConcepDate);
}
else if (convgs_PConceptRela.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.CreateDate);
}
else if (convgs_PConceptRela.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convgs_PConceptRela.ShareId);
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
 AddUpdatedFld(convgs_PConceptRela.mId);
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
 AddUpdatedFld(convgs_PConceptRela.PaperId);
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
 AddUpdatedFld(convgs_PConceptRela.PaperTitle);
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
 AddUpdatedFld(convgs_PConceptRela.PaperTypeId);
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
 AddUpdatedFld(convgs_PConceptRela.SectionId);
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
 AddUpdatedFld(convgs_PConceptRela.SectionName);
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
 AddUpdatedFld(convgs_PConceptRela.ConceptId);
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
 AddUpdatedFld(convgs_PConceptRela.ConceptName);
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
 AddUpdatedFld(convgs_PConceptRela.ConceptContent);
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
 AddUpdatedFld(convgs_PConceptRela.IsSubmit);
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
 AddUpdatedFld(convgs_PConceptRela.TeaScore);
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
 AddUpdatedFld(convgs_PConceptRela.StuScore);
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
 AddUpdatedFld(convgs_PConceptRela.Score);
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
 AddUpdatedFld(convgs_PConceptRela.AppraiseCount);
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
 AddUpdatedFld(convgs_PConceptRela.OkCount);
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
 AddUpdatedFld(convgs_PConceptRela.VersionCount);
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
 AddUpdatedFld(convgs_PConceptRela.CitationCount);
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
 AddUpdatedFld(convgs_PConceptRela.UpdDate);
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
 AddUpdatedFld(convgs_PConceptRela.UpdUser);
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
 AddUpdatedFld(convgs_PConceptRela.Memo);
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
 AddUpdatedFld(convgs_PConceptRela.ConcepUserId);
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
 AddUpdatedFld(convgs_PConceptRela.ConcepDate);
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
 AddUpdatedFld(convgs_PConceptRela.CreateDate);
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
 AddUpdatedFld(convgs_PConceptRela.ShareId);
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
 /// 论文概念关系视图(vgs_PConceptRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convgs_PConceptRela
{
public const string _CurrTabName = "vgs_PConceptRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "PaperId", "PaperTitle", "PaperTypeId", "SectionId", "SectionName", "ConceptId", "ConceptName", "ConceptContent", "IsSubmit", "TeaScore", "StuScore", "Score", "AppraiseCount", "OkCount", "VersionCount", "CitationCount", "UpdDate", "UpdUser", "Memo", "ConcepUserId", "ConcepDate", "CreateDate", "ShareId"};
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
 /// 常量:"ConceptId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptId = "ConceptId";    //概念Id

 /// <summary>
 /// 常量:"ConceptName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptName = "ConceptName";    //概念名称

 /// <summary>
 /// 常量:"ConceptContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptContent = "ConceptContent";    //概念内容

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

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
 /// 常量:"ConcepUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConcepUserId = "ConcepUserId";    //ConcepUserId

 /// <summary>
 /// 常量:"ConcepDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConcepDate = "ConcepDate";    //ConcepDate

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