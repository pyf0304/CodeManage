
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKnowledgeLearnDetailEN
 表名:KnowledgeLearnDetail(01120153)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表KnowledgeLearnDetail的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_KnowledgeLearnDetail
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
public K_mId_KnowledgeLearnDetail(long lngmId)
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
 /// <returns>返回:[K_mId_KnowledgeLearnDetail]类型的对象</returns>
public static implicit operator K_mId_KnowledgeLearnDetail(long value)
{
return new K_mId_KnowledgeLearnDetail(value);
}
}
 /// <summary>
 /// 知识点学习情况(KnowledgeLearnDetail)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsKnowledgeLearnDetailEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "KnowledgeLearnDetail"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"mId", "UserId", "LearnDate", "LearnModeId", "CourseKnowledgeId", "IdCase", "IdCaseType", "IsRight", "IsMaster", "MasterDegree", "MarkerId", "MarkTime", "IsAnalysis", "CourseId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrLearnDate;    //学习日期
protected string mstrLearnModeId;    //学习模式Id
protected string mstrCourseKnowledgeId;    //知识点Id
protected string mstrIdCase;    //案例流水号
protected string mstrIdCaseType;    //案例类型流水号
protected bool mbolIsRight;    //是否正确
protected bool mbolIsMaster;    //是否掌握
protected double mdblMasterDegree;    //掌握程度
protected string mstrMarkerId;    //打分者
protected string mstrMarkTime;    //批改时间
protected bool mbolIsAnalysis;    //是否分析
protected string mstrCourseId;    //课程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsKnowledgeLearnDetailEN()
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
public clsKnowledgeLearnDetailEN(long lngmId)
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
if (strAttributeName  ==  conKnowledgeLearnDetail.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.LearnDate)
{
return mstrLearnDate;
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.LearnModeId)
{
return mstrLearnModeId;
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.IdCase)
{
return mstrIdCase;
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.IsRight)
{
return mbolIsRight;
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.IsMaster)
{
return mbolIsMaster;
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.MasterDegree)
{
return mdblMasterDegree;
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.MarkerId)
{
return mstrMarkerId;
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.MarkTime)
{
return mstrMarkTime;
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.IsAnalysis)
{
return mbolIsAnalysis;
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conKnowledgeLearnDetail.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conKnowledgeLearnDetail.mId);
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.UserId);
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.LearnDate)
{
mstrLearnDate = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.LearnDate);
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.LearnModeId)
{
mstrLearnModeId = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.LearnModeId);
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.CourseKnowledgeId);
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.IdCase)
{
mstrIdCase = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.IdCase);
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.IdCaseType);
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.IsRight)
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(conKnowledgeLearnDetail.IsRight);
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.IsMaster)
{
mbolIsMaster = TransNullToBool(value.ToString());
 AddUpdatedFld(conKnowledgeLearnDetail.IsMaster);
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.MasterDegree)
{
mdblMasterDegree = TransNullToDouble(value.ToString());
 AddUpdatedFld(conKnowledgeLearnDetail.MasterDegree);
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.MarkerId)
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.MarkerId);
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.MarkTime)
{
mstrMarkTime = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.MarkTime);
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.IsAnalysis)
{
mbolIsAnalysis = TransNullToBool(value.ToString());
 AddUpdatedFld(conKnowledgeLearnDetail.IsAnalysis);
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.CourseId);
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.UpdDate);
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.UpdUser);
}
else if (strAttributeName  ==  conKnowledgeLearnDetail.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conKnowledgeLearnDetail.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conKnowledgeLearnDetail.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conKnowledgeLearnDetail.LearnDate  ==  AttributeName[intIndex])
{
return mstrLearnDate;
}
else if (conKnowledgeLearnDetail.LearnModeId  ==  AttributeName[intIndex])
{
return mstrLearnModeId;
}
else if (conKnowledgeLearnDetail.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (conKnowledgeLearnDetail.IdCase  ==  AttributeName[intIndex])
{
return mstrIdCase;
}
else if (conKnowledgeLearnDetail.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (conKnowledgeLearnDetail.IsRight  ==  AttributeName[intIndex])
{
return mbolIsRight;
}
else if (conKnowledgeLearnDetail.IsMaster  ==  AttributeName[intIndex])
{
return mbolIsMaster;
}
else if (conKnowledgeLearnDetail.MasterDegree  ==  AttributeName[intIndex])
{
return mdblMasterDegree;
}
else if (conKnowledgeLearnDetail.MarkerId  ==  AttributeName[intIndex])
{
return mstrMarkerId;
}
else if (conKnowledgeLearnDetail.MarkTime  ==  AttributeName[intIndex])
{
return mstrMarkTime;
}
else if (conKnowledgeLearnDetail.IsAnalysis  ==  AttributeName[intIndex])
{
return mbolIsAnalysis;
}
else if (conKnowledgeLearnDetail.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conKnowledgeLearnDetail.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conKnowledgeLearnDetail.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conKnowledgeLearnDetail.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conKnowledgeLearnDetail.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conKnowledgeLearnDetail.mId);
}
else if (conKnowledgeLearnDetail.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.UserId);
}
else if (conKnowledgeLearnDetail.LearnDate  ==  AttributeName[intIndex])
{
mstrLearnDate = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.LearnDate);
}
else if (conKnowledgeLearnDetail.LearnModeId  ==  AttributeName[intIndex])
{
mstrLearnModeId = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.LearnModeId);
}
else if (conKnowledgeLearnDetail.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.CourseKnowledgeId);
}
else if (conKnowledgeLearnDetail.IdCase  ==  AttributeName[intIndex])
{
mstrIdCase = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.IdCase);
}
else if (conKnowledgeLearnDetail.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.IdCaseType);
}
else if (conKnowledgeLearnDetail.IsRight  ==  AttributeName[intIndex])
{
mbolIsRight = TransNullToBool(value.ToString());
 AddUpdatedFld(conKnowledgeLearnDetail.IsRight);
}
else if (conKnowledgeLearnDetail.IsMaster  ==  AttributeName[intIndex])
{
mbolIsMaster = TransNullToBool(value.ToString());
 AddUpdatedFld(conKnowledgeLearnDetail.IsMaster);
}
else if (conKnowledgeLearnDetail.MasterDegree  ==  AttributeName[intIndex])
{
mdblMasterDegree = TransNullToDouble(value.ToString());
 AddUpdatedFld(conKnowledgeLearnDetail.MasterDegree);
}
else if (conKnowledgeLearnDetail.MarkerId  ==  AttributeName[intIndex])
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.MarkerId);
}
else if (conKnowledgeLearnDetail.MarkTime  ==  AttributeName[intIndex])
{
mstrMarkTime = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.MarkTime);
}
else if (conKnowledgeLearnDetail.IsAnalysis  ==  AttributeName[intIndex])
{
mbolIsAnalysis = TransNullToBool(value.ToString());
 AddUpdatedFld(conKnowledgeLearnDetail.IsAnalysis);
}
else if (conKnowledgeLearnDetail.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.CourseId);
}
else if (conKnowledgeLearnDetail.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.UpdDate);
}
else if (conKnowledgeLearnDetail.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.UpdUser);
}
else if (conKnowledgeLearnDetail.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conKnowledgeLearnDetail.Memo);
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
 AddUpdatedFld(conKnowledgeLearnDetail.mId);
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
 AddUpdatedFld(conKnowledgeLearnDetail.UserId);
}
}
/// <summary>
/// 学习日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LearnDate
{
get
{
return mstrLearnDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLearnDate = value;
}
else
{
 mstrLearnDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnDetail.LearnDate);
}
}
/// <summary>
/// 学习模式Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LearnModeId
{
get
{
return mstrLearnModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLearnModeId = value;
}
else
{
 mstrLearnModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnDetail.LearnModeId);
}
}
/// <summary>
/// 知识点Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseKnowledgeId
{
get
{
return mstrCourseKnowledgeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseKnowledgeId = value;
}
else
{
 mstrCourseKnowledgeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnDetail.CourseKnowledgeId);
}
}
/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCase
{
get
{
return mstrIdCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCase = value;
}
else
{
 mstrIdCase = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnDetail.IdCase);
}
}
/// <summary>
/// 案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCaseType
{
get
{
return mstrIdCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCaseType = value;
}
else
{
 mstrIdCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnDetail.IdCaseType);
}
}
/// <summary>
/// 是否正确(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRight
{
get
{
return mbolIsRight;
}
set
{
 mbolIsRight = value;
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnDetail.IsRight);
}
}
/// <summary>
/// 是否掌握(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMaster
{
get
{
return mbolIsMaster;
}
set
{
 mbolIsMaster = value;
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnDetail.IsMaster);
}
}
/// <summary>
/// 掌握程度(说明:;字段类型:numeric;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double MasterDegree
{
get
{
return mdblMasterDegree;
}
set
{
 mdblMasterDegree = value;
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnDetail.MasterDegree);
}
}
/// <summary>
/// 打分者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MarkerId
{
get
{
return mstrMarkerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMarkerId = value;
}
else
{
 mstrMarkerId = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnDetail.MarkerId);
}
}
/// <summary>
/// 批改时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MarkTime
{
get
{
return mstrMarkTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMarkTime = value;
}
else
{
 mstrMarkTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnDetail.MarkTime);
}
}
/// <summary>
/// 是否分析(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAnalysis
{
get
{
return mbolIsAnalysis;
}
set
{
 mbolIsAnalysis = value;
//记录修改过的字段
 AddUpdatedFld(conKnowledgeLearnDetail.IsAnalysis);
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
 AddUpdatedFld(conKnowledgeLearnDetail.CourseId);
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
 AddUpdatedFld(conKnowledgeLearnDetail.UpdDate);
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
 AddUpdatedFld(conKnowledgeLearnDetail.UpdUser);
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
 AddUpdatedFld(conKnowledgeLearnDetail.Memo);
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
 /// 知识点学习情况(KnowledgeLearnDetail)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conKnowledgeLearnDetail
{
public const string _CurrTabName = "KnowledgeLearnDetail"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "LearnDate", "LearnModeId", "CourseKnowledgeId", "IdCase", "IdCaseType", "IsRight", "IsMaster", "MasterDegree", "MarkerId", "MarkTime", "IsAnalysis", "CourseId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"LearnDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LearnDate = "LearnDate";    //学习日期

 /// <summary>
 /// 常量:"LearnModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LearnModeId = "LearnModeId";    //学习模式Id

 /// <summary>
 /// 常量:"CourseKnowledgeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeId = "CourseKnowledgeId";    //知识点Id

 /// <summary>
 /// 常量:"IdCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCase = "IdCase";    //案例流水号

 /// <summary>
 /// 常量:"IdCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseType = "IdCaseType";    //案例类型流水号

 /// <summary>
 /// 常量:"IsRight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRight = "IsRight";    //是否正确

 /// <summary>
 /// 常量:"IsMaster"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMaster = "IsMaster";    //是否掌握

 /// <summary>
 /// 常量:"MasterDegree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MasterDegree = "MasterDegree";    //掌握程度

 /// <summary>
 /// 常量:"MarkerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MarkerId = "MarkerId";    //打分者

 /// <summary>
 /// 常量:"MarkTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MarkTime = "MarkTime";    //批改时间

 /// <summary>
 /// 常量:"IsAnalysis"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAnalysis = "IsAnalysis";    //是否分析

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

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