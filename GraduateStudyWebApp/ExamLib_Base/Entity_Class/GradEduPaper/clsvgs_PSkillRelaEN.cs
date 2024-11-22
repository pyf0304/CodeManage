
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PSkillRelaEN
 表名:vgs_PSkillRela(01120666)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:16
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
 /// 表vgs_PSkillRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vgs_PSkillRela
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
public K_mId_vgs_PSkillRela(long lngmId)
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
 /// <returns>返回:[K_mId_vgs_PSkillRela]类型的对象</returns>
public static implicit operator K_mId_vgs_PSkillRela(long value)
{
return new K_mId_vgs_PSkillRela(value);
}
}
 /// <summary>
 /// 论文技能关系视图(vgs_PSkillRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvgs_PSkillRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vgs_PSkillRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 28;
public static string[] AttributeName = new string[] {"mId", "PaperId", "PaperTitle", "PaperTypeId", "SectionId", "SectionName", "SkillId", "UpdDate", "UpdUser", "Memo", "SkillName", "OperationTypeId", "OperationTypeName", "LevelName", "LevelId", "Process", "IsSubmit", "OkCount", "Score", "AppraiseCount", "StuScore", "TeaScore", "CitationCount", "VersionCount", "SkillUserId", "SkillDate", "CreateDate", "ShareId"};

protected long mlngmId;    //mId
protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected string mstrPaperTypeId;    //论文类型Id
protected string mstrSectionId;    //节Id
protected string mstrSectionName;    //节名
protected string mstrSkillId;    //技能Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrSkillName;    //技能名称
protected string mstrOperationTypeId;    //操作类型ID
protected string mstrOperationTypeName;    //操作类型名
protected string mstrLevelName;    //级别名称
protected string mstrLevelId;    //级别Id
protected string mstrProcess;    //实施过程
protected bool mbolIsSubmit;    //是否提交
protected int? mintOkCount;    //点赞统计
protected float? mfltScore;    //评分
protected int? mintAppraiseCount;    //评论数
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected int? mintCitationCount;    //引用统计
protected int? mintVersionCount;    //版本统计
protected string mstrSkillUserId;    //SkillUserId
protected string mstrSkillDate;    //SkillDate
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvgs_PSkillRelaEN()
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
public clsvgs_PSkillRelaEN(long lngmId)
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
if (strAttributeName  ==  convgs_PSkillRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convgs_PSkillRela.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convgs_PSkillRela.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convgs_PSkillRela.PaperTypeId)
{
return mstrPaperTypeId;
}
else if (strAttributeName  ==  convgs_PSkillRela.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convgs_PSkillRela.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convgs_PSkillRela.SkillId)
{
return mstrSkillId;
}
else if (strAttributeName  ==  convgs_PSkillRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convgs_PSkillRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convgs_PSkillRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convgs_PSkillRela.SkillName)
{
return mstrSkillName;
}
else if (strAttributeName  ==  convgs_PSkillRela.OperationTypeId)
{
return mstrOperationTypeId;
}
else if (strAttributeName  ==  convgs_PSkillRela.OperationTypeName)
{
return mstrOperationTypeName;
}
else if (strAttributeName  ==  convgs_PSkillRela.LevelName)
{
return mstrLevelName;
}
else if (strAttributeName  ==  convgs_PSkillRela.LevelId)
{
return mstrLevelId;
}
else if (strAttributeName  ==  convgs_PSkillRela.Process)
{
return mstrProcess;
}
else if (strAttributeName  ==  convgs_PSkillRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convgs_PSkillRela.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convgs_PSkillRela.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convgs_PSkillRela.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convgs_PSkillRela.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convgs_PSkillRela.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convgs_PSkillRela.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convgs_PSkillRela.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convgs_PSkillRela.SkillUserId)
{
return mstrSkillUserId;
}
else if (strAttributeName  ==  convgs_PSkillRela.SkillDate)
{
return mstrSkillDate;
}
else if (strAttributeName  ==  convgs_PSkillRela.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convgs_PSkillRela.ShareId)
{
return mstrShareId;
}
return null;
}
set
{
if (strAttributeName  ==  convgs_PSkillRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.mId);
}
else if (strAttributeName  ==  convgs_PSkillRela.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.PaperId);
}
else if (strAttributeName  ==  convgs_PSkillRela.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.PaperTitle);
}
else if (strAttributeName  ==  convgs_PSkillRela.PaperTypeId)
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.PaperTypeId);
}
else if (strAttributeName  ==  convgs_PSkillRela.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.SectionId);
}
else if (strAttributeName  ==  convgs_PSkillRela.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.SectionName);
}
else if (strAttributeName  ==  convgs_PSkillRela.SkillId)
{
mstrSkillId = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.SkillId);
}
else if (strAttributeName  ==  convgs_PSkillRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.UpdDate);
}
else if (strAttributeName  ==  convgs_PSkillRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.UpdUser);
}
else if (strAttributeName  ==  convgs_PSkillRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.Memo);
}
else if (strAttributeName  ==  convgs_PSkillRela.SkillName)
{
mstrSkillName = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.SkillName);
}
else if (strAttributeName  ==  convgs_PSkillRela.OperationTypeId)
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.OperationTypeId);
}
else if (strAttributeName  ==  convgs_PSkillRela.OperationTypeName)
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.OperationTypeName);
}
else if (strAttributeName  ==  convgs_PSkillRela.LevelName)
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.LevelName);
}
else if (strAttributeName  ==  convgs_PSkillRela.LevelId)
{
mstrLevelId = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.LevelId);
}
else if (strAttributeName  ==  convgs_PSkillRela.Process)
{
mstrProcess = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.Process);
}
else if (strAttributeName  ==  convgs_PSkillRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.IsSubmit);
}
else if (strAttributeName  ==  convgs_PSkillRela.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.OkCount);
}
else if (strAttributeName  ==  convgs_PSkillRela.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.Score);
}
else if (strAttributeName  ==  convgs_PSkillRela.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.AppraiseCount);
}
else if (strAttributeName  ==  convgs_PSkillRela.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.StuScore);
}
else if (strAttributeName  ==  convgs_PSkillRela.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.TeaScore);
}
else if (strAttributeName  ==  convgs_PSkillRela.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.CitationCount);
}
else if (strAttributeName  ==  convgs_PSkillRela.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.VersionCount);
}
else if (strAttributeName  ==  convgs_PSkillRela.SkillUserId)
{
mstrSkillUserId = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.SkillUserId);
}
else if (strAttributeName  ==  convgs_PSkillRela.SkillDate)
{
mstrSkillDate = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.SkillDate);
}
else if (strAttributeName  ==  convgs_PSkillRela.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.CreateDate);
}
else if (strAttributeName  ==  convgs_PSkillRela.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.ShareId);
}
}
}
public object this[int intIndex]
{
get
{
if (convgs_PSkillRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convgs_PSkillRela.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convgs_PSkillRela.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convgs_PSkillRela.PaperTypeId  ==  AttributeName[intIndex])
{
return mstrPaperTypeId;
}
else if (convgs_PSkillRela.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convgs_PSkillRela.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convgs_PSkillRela.SkillId  ==  AttributeName[intIndex])
{
return mstrSkillId;
}
else if (convgs_PSkillRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convgs_PSkillRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convgs_PSkillRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convgs_PSkillRela.SkillName  ==  AttributeName[intIndex])
{
return mstrSkillName;
}
else if (convgs_PSkillRela.OperationTypeId  ==  AttributeName[intIndex])
{
return mstrOperationTypeId;
}
else if (convgs_PSkillRela.OperationTypeName  ==  AttributeName[intIndex])
{
return mstrOperationTypeName;
}
else if (convgs_PSkillRela.LevelName  ==  AttributeName[intIndex])
{
return mstrLevelName;
}
else if (convgs_PSkillRela.LevelId  ==  AttributeName[intIndex])
{
return mstrLevelId;
}
else if (convgs_PSkillRela.Process  ==  AttributeName[intIndex])
{
return mstrProcess;
}
else if (convgs_PSkillRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convgs_PSkillRela.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convgs_PSkillRela.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convgs_PSkillRela.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convgs_PSkillRela.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convgs_PSkillRela.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convgs_PSkillRela.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convgs_PSkillRela.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convgs_PSkillRela.SkillUserId  ==  AttributeName[intIndex])
{
return mstrSkillUserId;
}
else if (convgs_PSkillRela.SkillDate  ==  AttributeName[intIndex])
{
return mstrSkillDate;
}
else if (convgs_PSkillRela.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convgs_PSkillRela.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
return null;
}
set
{
if (convgs_PSkillRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.mId);
}
else if (convgs_PSkillRela.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.PaperId);
}
else if (convgs_PSkillRela.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.PaperTitle);
}
else if (convgs_PSkillRela.PaperTypeId  ==  AttributeName[intIndex])
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.PaperTypeId);
}
else if (convgs_PSkillRela.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.SectionId);
}
else if (convgs_PSkillRela.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.SectionName);
}
else if (convgs_PSkillRela.SkillId  ==  AttributeName[intIndex])
{
mstrSkillId = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.SkillId);
}
else if (convgs_PSkillRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.UpdDate);
}
else if (convgs_PSkillRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.UpdUser);
}
else if (convgs_PSkillRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.Memo);
}
else if (convgs_PSkillRela.SkillName  ==  AttributeName[intIndex])
{
mstrSkillName = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.SkillName);
}
else if (convgs_PSkillRela.OperationTypeId  ==  AttributeName[intIndex])
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.OperationTypeId);
}
else if (convgs_PSkillRela.OperationTypeName  ==  AttributeName[intIndex])
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.OperationTypeName);
}
else if (convgs_PSkillRela.LevelName  ==  AttributeName[intIndex])
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.LevelName);
}
else if (convgs_PSkillRela.LevelId  ==  AttributeName[intIndex])
{
mstrLevelId = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.LevelId);
}
else if (convgs_PSkillRela.Process  ==  AttributeName[intIndex])
{
mstrProcess = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.Process);
}
else if (convgs_PSkillRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.IsSubmit);
}
else if (convgs_PSkillRela.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.OkCount);
}
else if (convgs_PSkillRela.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.Score);
}
else if (convgs_PSkillRela.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.AppraiseCount);
}
else if (convgs_PSkillRela.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.StuScore);
}
else if (convgs_PSkillRela.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.TeaScore);
}
else if (convgs_PSkillRela.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.CitationCount);
}
else if (convgs_PSkillRela.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PSkillRela.VersionCount);
}
else if (convgs_PSkillRela.SkillUserId  ==  AttributeName[intIndex])
{
mstrSkillUserId = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.SkillUserId);
}
else if (convgs_PSkillRela.SkillDate  ==  AttributeName[intIndex])
{
mstrSkillDate = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.SkillDate);
}
else if (convgs_PSkillRela.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.CreateDate);
}
else if (convgs_PSkillRela.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convgs_PSkillRela.ShareId);
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
 AddUpdatedFld(convgs_PSkillRela.mId);
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
 AddUpdatedFld(convgs_PSkillRela.PaperId);
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
 AddUpdatedFld(convgs_PSkillRela.PaperTitle);
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
 AddUpdatedFld(convgs_PSkillRela.PaperTypeId);
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
 AddUpdatedFld(convgs_PSkillRela.SectionId);
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
 AddUpdatedFld(convgs_PSkillRela.SectionName);
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
 AddUpdatedFld(convgs_PSkillRela.SkillId);
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
 AddUpdatedFld(convgs_PSkillRela.UpdDate);
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
 AddUpdatedFld(convgs_PSkillRela.UpdUser);
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
 AddUpdatedFld(convgs_PSkillRela.Memo);
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
 AddUpdatedFld(convgs_PSkillRela.SkillName);
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
 AddUpdatedFld(convgs_PSkillRela.OperationTypeId);
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
 AddUpdatedFld(convgs_PSkillRela.OperationTypeName);
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
 AddUpdatedFld(convgs_PSkillRela.LevelName);
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
 AddUpdatedFld(convgs_PSkillRela.LevelId);
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
 AddUpdatedFld(convgs_PSkillRela.Process);
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
 AddUpdatedFld(convgs_PSkillRela.IsSubmit);
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
 AddUpdatedFld(convgs_PSkillRela.OkCount);
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
 AddUpdatedFld(convgs_PSkillRela.Score);
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
 AddUpdatedFld(convgs_PSkillRela.AppraiseCount);
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
 AddUpdatedFld(convgs_PSkillRela.StuScore);
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
 AddUpdatedFld(convgs_PSkillRela.TeaScore);
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
 AddUpdatedFld(convgs_PSkillRela.CitationCount);
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
 AddUpdatedFld(convgs_PSkillRela.VersionCount);
}
}
/// <summary>
/// SkillUserId(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillUserId
{
get
{
return mstrSkillUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillUserId = value;
}
else
{
 mstrSkillUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PSkillRela.SkillUserId);
}
}
/// <summary>
/// SkillDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillDate
{
get
{
return mstrSkillDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillDate = value;
}
else
{
 mstrSkillDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PSkillRela.SkillDate);
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
 AddUpdatedFld(convgs_PSkillRela.CreateDate);
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
 AddUpdatedFld(convgs_PSkillRela.ShareId);
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
 /// 论文技能关系视图(vgs_PSkillRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convgs_PSkillRela
{
public const string _CurrTabName = "vgs_PSkillRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "PaperId", "PaperTitle", "PaperTypeId", "SectionId", "SectionName", "SkillId", "UpdDate", "UpdUser", "Memo", "SkillName", "OperationTypeId", "OperationTypeName", "LevelName", "LevelId", "Process", "IsSubmit", "OkCount", "Score", "AppraiseCount", "StuScore", "TeaScore", "CitationCount", "VersionCount", "SkillUserId", "SkillDate", "CreateDate", "ShareId"};
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
 /// 常量:"OperationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationTypeName = "OperationTypeName";    //操作类型名

 /// <summary>
 /// 常量:"LevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelName = "LevelName";    //级别名称

 /// <summary>
 /// 常量:"LevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelId = "LevelId";    //级别Id

 /// <summary>
 /// 常量:"Process"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Process = "Process";    //实施过程

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
 /// 常量:"SkillUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillUserId = "SkillUserId";    //SkillUserId

 /// <summary>
 /// 常量:"SkillDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillDate = "SkillDate";    //SkillDate

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