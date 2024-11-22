
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsBigConceptEN
 表名:BigConcept(01120972)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:21
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:大概念教学(BigConceptTeaching)
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
 /// 表BigConcept的关键字(IdBigConcept)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdBigConcept_BigConcept
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdBigConcept">表关键字</param>
public K_IdBigConcept_BigConcept(string strIdBigConcept)
{
if (IsValid(strIdBigConcept)) Value = strIdBigConcept;
else
{
Value = null;
}
}
private static bool IsValid(string strIdBigConcept)
{
if (string.IsNullOrEmpty(strIdBigConcept) == true) return false;
if (strIdBigConcept.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdBigConcept_BigConcept]类型的对象</returns>
public static implicit operator K_IdBigConcept_BigConcept(string value)
{
return new K_IdBigConcept_BigConcept(value);
}
}
 /// <summary>
 /// 大概念(BigConcept)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsBigConceptEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "BigConcept"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdBigConcept"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"IdBigConcept", "BigConceptId", "BigConceptName", "IdGrade", "SchoolTerm", "CourseId", "IsClgCheck", "ClgNote", "ClgCheckerId", "ClgCheckDate", "IsSchCheck", "SchNote", "SchCheckerId", "SchCheckDate", "IdSubmitStatus", "Memo"};

protected string mstrIdBigConcept;    //大概念流水号
protected string mstrBigConceptId;    //大概念编号
protected string mstrBigConceptName;    //大概念名称
protected string mstrIdGrade;    //年级流水号
protected string mstrSchoolTerm;    //学期
protected string mstrCourseId;    //课程Id
protected bool mbolIsClgCheck;    //是否学院审批
protected string mstrClgNote;    //学院审批意见
protected string mstrClgCheckerId;    //学院审批人id
protected string mstrClgCheckDate;    //学院审批日期
protected bool mbolIsSchCheck;    //是否学校审批
protected string mstrSchNote;    //学校审批意见
protected string mstrSchCheckerId;    //学校审批人Id
protected string mstrSchCheckDate;    //学校审批日期
protected string mstrIdSubmitStatus;    //送审状态流水号
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsBigConceptEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdBigConcept");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdBigConcept">关键字:大概念流水号</param>
public clsBigConceptEN(string strIdBigConcept)
 {
strIdBigConcept = strIdBigConcept.Replace("'", "''");
if (strIdBigConcept.Length > 8)
{
throw new Exception("在表:BigConcept中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdBigConcept)  ==  true)
{
throw new Exception("在表:BigConcept中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdBigConcept);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdBigConcept = strIdBigConcept;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdBigConcept");
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
if (strAttributeName  ==  conBigConcept.IdBigConcept)
{
return mstrIdBigConcept;
}
else if (strAttributeName  ==  conBigConcept.BigConceptId)
{
return mstrBigConceptId;
}
else if (strAttributeName  ==  conBigConcept.BigConceptName)
{
return mstrBigConceptName;
}
else if (strAttributeName  ==  conBigConcept.IdGrade)
{
return mstrIdGrade;
}
else if (strAttributeName  ==  conBigConcept.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  conBigConcept.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conBigConcept.IsClgCheck)
{
return mbolIsClgCheck;
}
else if (strAttributeName  ==  conBigConcept.ClgNote)
{
return mstrClgNote;
}
else if (strAttributeName  ==  conBigConcept.ClgCheckerId)
{
return mstrClgCheckerId;
}
else if (strAttributeName  ==  conBigConcept.ClgCheckDate)
{
return mstrClgCheckDate;
}
else if (strAttributeName  ==  conBigConcept.IsSchCheck)
{
return mbolIsSchCheck;
}
else if (strAttributeName  ==  conBigConcept.SchNote)
{
return mstrSchNote;
}
else if (strAttributeName  ==  conBigConcept.SchCheckerId)
{
return mstrSchCheckerId;
}
else if (strAttributeName  ==  conBigConcept.SchCheckDate)
{
return mstrSchCheckDate;
}
else if (strAttributeName  ==  conBigConcept.IdSubmitStatus)
{
return mstrIdSubmitStatus;
}
else if (strAttributeName  ==  conBigConcept.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conBigConcept.IdBigConcept)
{
mstrIdBigConcept = value.ToString();
 AddUpdatedFld(conBigConcept.IdBigConcept);
}
else if (strAttributeName  ==  conBigConcept.BigConceptId)
{
mstrBigConceptId = value.ToString();
 AddUpdatedFld(conBigConcept.BigConceptId);
}
else if (strAttributeName  ==  conBigConcept.BigConceptName)
{
mstrBigConceptName = value.ToString();
 AddUpdatedFld(conBigConcept.BigConceptName);
}
else if (strAttributeName  ==  conBigConcept.IdGrade)
{
mstrIdGrade = value.ToString();
 AddUpdatedFld(conBigConcept.IdGrade);
}
else if (strAttributeName  ==  conBigConcept.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conBigConcept.SchoolTerm);
}
else if (strAttributeName  ==  conBigConcept.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conBigConcept.CourseId);
}
else if (strAttributeName  ==  conBigConcept.IsClgCheck)
{
mbolIsClgCheck = TransNullToBool(value.ToString());
 AddUpdatedFld(conBigConcept.IsClgCheck);
}
else if (strAttributeName  ==  conBigConcept.ClgNote)
{
mstrClgNote = value.ToString();
 AddUpdatedFld(conBigConcept.ClgNote);
}
else if (strAttributeName  ==  conBigConcept.ClgCheckerId)
{
mstrClgCheckerId = value.ToString();
 AddUpdatedFld(conBigConcept.ClgCheckerId);
}
else if (strAttributeName  ==  conBigConcept.ClgCheckDate)
{
mstrClgCheckDate = value.ToString();
 AddUpdatedFld(conBigConcept.ClgCheckDate);
}
else if (strAttributeName  ==  conBigConcept.IsSchCheck)
{
mbolIsSchCheck = TransNullToBool(value.ToString());
 AddUpdatedFld(conBigConcept.IsSchCheck);
}
else if (strAttributeName  ==  conBigConcept.SchNote)
{
mstrSchNote = value.ToString();
 AddUpdatedFld(conBigConcept.SchNote);
}
else if (strAttributeName  ==  conBigConcept.SchCheckerId)
{
mstrSchCheckerId = value.ToString();
 AddUpdatedFld(conBigConcept.SchCheckerId);
}
else if (strAttributeName  ==  conBigConcept.SchCheckDate)
{
mstrSchCheckDate = value.ToString();
 AddUpdatedFld(conBigConcept.SchCheckDate);
}
else if (strAttributeName  ==  conBigConcept.IdSubmitStatus)
{
mstrIdSubmitStatus = value.ToString();
 AddUpdatedFld(conBigConcept.IdSubmitStatus);
}
else if (strAttributeName  ==  conBigConcept.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conBigConcept.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conBigConcept.IdBigConcept  ==  AttributeName[intIndex])
{
return mstrIdBigConcept;
}
else if (conBigConcept.BigConceptId  ==  AttributeName[intIndex])
{
return mstrBigConceptId;
}
else if (conBigConcept.BigConceptName  ==  AttributeName[intIndex])
{
return mstrBigConceptName;
}
else if (conBigConcept.IdGrade  ==  AttributeName[intIndex])
{
return mstrIdGrade;
}
else if (conBigConcept.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (conBigConcept.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conBigConcept.IsClgCheck  ==  AttributeName[intIndex])
{
return mbolIsClgCheck;
}
else if (conBigConcept.ClgNote  ==  AttributeName[intIndex])
{
return mstrClgNote;
}
else if (conBigConcept.ClgCheckerId  ==  AttributeName[intIndex])
{
return mstrClgCheckerId;
}
else if (conBigConcept.ClgCheckDate  ==  AttributeName[intIndex])
{
return mstrClgCheckDate;
}
else if (conBigConcept.IsSchCheck  ==  AttributeName[intIndex])
{
return mbolIsSchCheck;
}
else if (conBigConcept.SchNote  ==  AttributeName[intIndex])
{
return mstrSchNote;
}
else if (conBigConcept.SchCheckerId  ==  AttributeName[intIndex])
{
return mstrSchCheckerId;
}
else if (conBigConcept.SchCheckDate  ==  AttributeName[intIndex])
{
return mstrSchCheckDate;
}
else if (conBigConcept.IdSubmitStatus  ==  AttributeName[intIndex])
{
return mstrIdSubmitStatus;
}
else if (conBigConcept.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conBigConcept.IdBigConcept  ==  AttributeName[intIndex])
{
mstrIdBigConcept = value.ToString();
 AddUpdatedFld(conBigConcept.IdBigConcept);
}
else if (conBigConcept.BigConceptId  ==  AttributeName[intIndex])
{
mstrBigConceptId = value.ToString();
 AddUpdatedFld(conBigConcept.BigConceptId);
}
else if (conBigConcept.BigConceptName  ==  AttributeName[intIndex])
{
mstrBigConceptName = value.ToString();
 AddUpdatedFld(conBigConcept.BigConceptName);
}
else if (conBigConcept.IdGrade  ==  AttributeName[intIndex])
{
mstrIdGrade = value.ToString();
 AddUpdatedFld(conBigConcept.IdGrade);
}
else if (conBigConcept.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conBigConcept.SchoolTerm);
}
else if (conBigConcept.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conBigConcept.CourseId);
}
else if (conBigConcept.IsClgCheck  ==  AttributeName[intIndex])
{
mbolIsClgCheck = TransNullToBool(value.ToString());
 AddUpdatedFld(conBigConcept.IsClgCheck);
}
else if (conBigConcept.ClgNote  ==  AttributeName[intIndex])
{
mstrClgNote = value.ToString();
 AddUpdatedFld(conBigConcept.ClgNote);
}
else if (conBigConcept.ClgCheckerId  ==  AttributeName[intIndex])
{
mstrClgCheckerId = value.ToString();
 AddUpdatedFld(conBigConcept.ClgCheckerId);
}
else if (conBigConcept.ClgCheckDate  ==  AttributeName[intIndex])
{
mstrClgCheckDate = value.ToString();
 AddUpdatedFld(conBigConcept.ClgCheckDate);
}
else if (conBigConcept.IsSchCheck  ==  AttributeName[intIndex])
{
mbolIsSchCheck = TransNullToBool(value.ToString());
 AddUpdatedFld(conBigConcept.IsSchCheck);
}
else if (conBigConcept.SchNote  ==  AttributeName[intIndex])
{
mstrSchNote = value.ToString();
 AddUpdatedFld(conBigConcept.SchNote);
}
else if (conBigConcept.SchCheckerId  ==  AttributeName[intIndex])
{
mstrSchCheckerId = value.ToString();
 AddUpdatedFld(conBigConcept.SchCheckerId);
}
else if (conBigConcept.SchCheckDate  ==  AttributeName[intIndex])
{
mstrSchCheckDate = value.ToString();
 AddUpdatedFld(conBigConcept.SchCheckDate);
}
else if (conBigConcept.IdSubmitStatus  ==  AttributeName[intIndex])
{
mstrIdSubmitStatus = value.ToString();
 AddUpdatedFld(conBigConcept.IdSubmitStatus);
}
else if (conBigConcept.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conBigConcept.Memo);
}
}
}

/// <summary>
/// 大概念流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdBigConcept
{
get
{
return mstrIdBigConcept;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdBigConcept = value;
}
else
{
 mstrIdBigConcept = value;
}
//记录修改过的字段
 AddUpdatedFld(conBigConcept.IdBigConcept);
}
}
/// <summary>
/// 大概念编号(说明:;字段类型:char;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BigConceptId
{
get
{
return mstrBigConceptId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBigConceptId = value;
}
else
{
 mstrBigConceptId = value;
}
//记录修改过的字段
 AddUpdatedFld(conBigConcept.BigConceptId);
}
}
/// <summary>
/// 大概念名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BigConceptName
{
get
{
return mstrBigConceptName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBigConceptName = value;
}
else
{
 mstrBigConceptName = value;
}
//记录修改过的字段
 AddUpdatedFld(conBigConcept.BigConceptName);
}
}
/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGrade
{
get
{
return mstrIdGrade;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGrade = value;
}
else
{
 mstrIdGrade = value;
}
//记录修改过的字段
 AddUpdatedFld(conBigConcept.IdGrade);
}
}
/// <summary>
/// 学期(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolTerm
{
get
{
return mstrSchoolTerm;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolTerm = value;
}
else
{
 mstrSchoolTerm = value;
}
//记录修改过的字段
 AddUpdatedFld(conBigConcept.SchoolTerm);
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
 AddUpdatedFld(conBigConcept.CourseId);
}
}
/// <summary>
/// 是否学院审批(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsClgCheck
{
get
{
return mbolIsClgCheck;
}
set
{
 mbolIsClgCheck = value;
//记录修改过的字段
 AddUpdatedFld(conBigConcept.IsClgCheck);
}
}
/// <summary>
/// 学院审批意见(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClgNote
{
get
{
return mstrClgNote;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClgNote = value;
}
else
{
 mstrClgNote = value;
}
//记录修改过的字段
 AddUpdatedFld(conBigConcept.ClgNote);
}
}
/// <summary>
/// 学院审批人id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClgCheckerId
{
get
{
return mstrClgCheckerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClgCheckerId = value;
}
else
{
 mstrClgCheckerId = value;
}
//记录修改过的字段
 AddUpdatedFld(conBigConcept.ClgCheckerId);
}
}
/// <summary>
/// 学院审批日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClgCheckDate
{
get
{
return mstrClgCheckDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClgCheckDate = value;
}
else
{
 mstrClgCheckDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conBigConcept.ClgCheckDate);
}
}
/// <summary>
/// 是否学校审批(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSchCheck
{
get
{
return mbolIsSchCheck;
}
set
{
 mbolIsSchCheck = value;
//记录修改过的字段
 AddUpdatedFld(conBigConcept.IsSchCheck);
}
}
/// <summary>
/// 学校审批意见(说明:;字段类型:text;字段长度:16;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchNote
{
get
{
return mstrSchNote;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchNote = value;
}
else
{
 mstrSchNote = value;
}
//记录修改过的字段
 AddUpdatedFld(conBigConcept.SchNote);
}
}
/// <summary>
/// 学校审批人Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchCheckerId
{
get
{
return mstrSchCheckerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchCheckerId = value;
}
else
{
 mstrSchCheckerId = value;
}
//记录修改过的字段
 AddUpdatedFld(conBigConcept.SchCheckerId);
}
}
/// <summary>
/// 学校审批日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchCheckDate
{
get
{
return mstrSchCheckDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchCheckDate = value;
}
else
{
 mstrSchCheckDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conBigConcept.SchCheckDate);
}
}
/// <summary>
/// 送审状态流水号(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSubmitStatus
{
get
{
return mstrIdSubmitStatus;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSubmitStatus = value;
}
else
{
 mstrIdSubmitStatus = value;
}
//记录修改过的字段
 AddUpdatedFld(conBigConcept.IdSubmitStatus);
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
 AddUpdatedFld(conBigConcept.Memo);
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
  return mstrIdBigConcept;
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
  return mstrBigConceptName;
 }
 }
}
 /// <summary>
 /// 大概念(BigConcept)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conBigConcept
{
public const string _CurrTabName = "BigConcept"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdBigConcept"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdBigConcept", "BigConceptId", "BigConceptName", "IdGrade", "SchoolTerm", "CourseId", "IsClgCheck", "ClgNote", "ClgCheckerId", "ClgCheckDate", "IsSchCheck", "SchNote", "SchCheckerId", "SchCheckDate", "IdSubmitStatus", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdBigConcept"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdBigConcept = "IdBigConcept";    //大概念流水号

 /// <summary>
 /// 常量:"BigConceptId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BigConceptId = "BigConceptId";    //大概念编号

 /// <summary>
 /// 常量:"BigConceptName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BigConceptName = "BigConceptName";    //大概念名称

 /// <summary>
 /// 常量:"IdGrade"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGrade = "IdGrade";    //年级流水号

 /// <summary>
 /// 常量:"SchoolTerm"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTerm = "SchoolTerm";    //学期

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"IsClgCheck"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsClgCheck = "IsClgCheck";    //是否学院审批

 /// <summary>
 /// 常量:"ClgNote"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClgNote = "ClgNote";    //学院审批意见

 /// <summary>
 /// 常量:"ClgCheckerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClgCheckerId = "ClgCheckerId";    //学院审批人id

 /// <summary>
 /// 常量:"ClgCheckDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClgCheckDate = "ClgCheckDate";    //学院审批日期

 /// <summary>
 /// 常量:"IsSchCheck"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSchCheck = "IsSchCheck";    //是否学校审批

 /// <summary>
 /// 常量:"SchNote"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchNote = "SchNote";    //学校审批意见

 /// <summary>
 /// 常量:"SchCheckerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchCheckerId = "SchCheckerId";    //学校审批人Id

 /// <summary>
 /// 常量:"SchCheckDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchCheckDate = "SchCheckDate";    //学校审批日期

 /// <summary>
 /// 常量:"IdSubmitStatus"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSubmitStatus = "IdSubmitStatus";    //送审状态流水号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}