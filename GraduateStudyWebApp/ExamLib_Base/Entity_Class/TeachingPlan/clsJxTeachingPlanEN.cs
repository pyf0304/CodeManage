
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsJxTeachingPlanEN
 表名:JxTeachingPlan(01120968)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学执行计划管理(TeachingPlan)
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
 /// 表JxTeachingPlan的关键字(IdTeachingPlan)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdTeachingPlan_JxTeachingPlan
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdTeachingPlan">表关键字</param>
public K_IdTeachingPlan_JxTeachingPlan(string strIdTeachingPlan)
{
if (IsValid(strIdTeachingPlan)) Value = strIdTeachingPlan;
else
{
Value = null;
}
}
private static bool IsValid(string strIdTeachingPlan)
{
if (string.IsNullOrEmpty(strIdTeachingPlan) == true) return false;
if (strIdTeachingPlan.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdTeachingPlan_JxTeachingPlan]类型的对象</returns>
public static implicit operator K_IdTeachingPlan_JxTeachingPlan(string value)
{
return new K_IdTeachingPlan_JxTeachingPlan(value);
}
}
 /// <summary>
 /// 教学计划(JxTeachingPlan)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsJxTeachingPlanEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "JxTeachingPlan"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdTeachingPlan"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"IdTeachingPlan", "TeachingPlanId", "TeachingPlanDesc", "IdGrade", "SchoolTerm", "CourseId", "IsClgCheck", "ClgNote", "ClgCheckerId", "ClgCheckDate", "IsSchCheck", "SchNote", "SchCheckerId", "SchCheckDate", "IdSubmitStatus", "Memo"};

protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrTeachingPlanId;    //教学计划编号
protected string mstrTeachingPlanDesc;    //教学计划名称
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
 public clsJxTeachingPlanEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachingPlan");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdTeachingPlan">关键字:教案流水号</param>
public clsJxTeachingPlanEN(string strIdTeachingPlan)
 {
strIdTeachingPlan = strIdTeachingPlan.Replace("'", "''");
if (strIdTeachingPlan.Length > 8)
{
throw new Exception("在表:JxTeachingPlan中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdTeachingPlan)  ==  true)
{
throw new Exception("在表:JxTeachingPlan中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachingPlan);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdTeachingPlan = strIdTeachingPlan;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachingPlan");
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
if (strAttributeName  ==  conJxTeachingPlan.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  conJxTeachingPlan.TeachingPlanId)
{
return mstrTeachingPlanId;
}
else if (strAttributeName  ==  conJxTeachingPlan.TeachingPlanDesc)
{
return mstrTeachingPlanDesc;
}
else if (strAttributeName  ==  conJxTeachingPlan.IdGrade)
{
return mstrIdGrade;
}
else if (strAttributeName  ==  conJxTeachingPlan.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  conJxTeachingPlan.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conJxTeachingPlan.IsClgCheck)
{
return mbolIsClgCheck;
}
else if (strAttributeName  ==  conJxTeachingPlan.ClgNote)
{
return mstrClgNote;
}
else if (strAttributeName  ==  conJxTeachingPlan.ClgCheckerId)
{
return mstrClgCheckerId;
}
else if (strAttributeName  ==  conJxTeachingPlan.ClgCheckDate)
{
return mstrClgCheckDate;
}
else if (strAttributeName  ==  conJxTeachingPlan.IsSchCheck)
{
return mbolIsSchCheck;
}
else if (strAttributeName  ==  conJxTeachingPlan.SchNote)
{
return mstrSchNote;
}
else if (strAttributeName  ==  conJxTeachingPlan.SchCheckerId)
{
return mstrSchCheckerId;
}
else if (strAttributeName  ==  conJxTeachingPlan.SchCheckDate)
{
return mstrSchCheckDate;
}
else if (strAttributeName  ==  conJxTeachingPlan.IdSubmitStatus)
{
return mstrIdSubmitStatus;
}
else if (strAttributeName  ==  conJxTeachingPlan.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conJxTeachingPlan.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.IdTeachingPlan);
}
else if (strAttributeName  ==  conJxTeachingPlan.TeachingPlanId)
{
mstrTeachingPlanId = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.TeachingPlanId);
}
else if (strAttributeName  ==  conJxTeachingPlan.TeachingPlanDesc)
{
mstrTeachingPlanDesc = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.TeachingPlanDesc);
}
else if (strAttributeName  ==  conJxTeachingPlan.IdGrade)
{
mstrIdGrade = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.IdGrade);
}
else if (strAttributeName  ==  conJxTeachingPlan.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.SchoolTerm);
}
else if (strAttributeName  ==  conJxTeachingPlan.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.CourseId);
}
else if (strAttributeName  ==  conJxTeachingPlan.IsClgCheck)
{
mbolIsClgCheck = TransNullToBool(value.ToString());
 AddUpdatedFld(conJxTeachingPlan.IsClgCheck);
}
else if (strAttributeName  ==  conJxTeachingPlan.ClgNote)
{
mstrClgNote = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.ClgNote);
}
else if (strAttributeName  ==  conJxTeachingPlan.ClgCheckerId)
{
mstrClgCheckerId = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.ClgCheckerId);
}
else if (strAttributeName  ==  conJxTeachingPlan.ClgCheckDate)
{
mstrClgCheckDate = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.ClgCheckDate);
}
else if (strAttributeName  ==  conJxTeachingPlan.IsSchCheck)
{
mbolIsSchCheck = TransNullToBool(value.ToString());
 AddUpdatedFld(conJxTeachingPlan.IsSchCheck);
}
else if (strAttributeName  ==  conJxTeachingPlan.SchNote)
{
mstrSchNote = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.SchNote);
}
else if (strAttributeName  ==  conJxTeachingPlan.SchCheckerId)
{
mstrSchCheckerId = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.SchCheckerId);
}
else if (strAttributeName  ==  conJxTeachingPlan.SchCheckDate)
{
mstrSchCheckDate = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.SchCheckDate);
}
else if (strAttributeName  ==  conJxTeachingPlan.IdSubmitStatus)
{
mstrIdSubmitStatus = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.IdSubmitStatus);
}
else if (strAttributeName  ==  conJxTeachingPlan.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conJxTeachingPlan.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (conJxTeachingPlan.TeachingPlanId  ==  AttributeName[intIndex])
{
return mstrTeachingPlanId;
}
else if (conJxTeachingPlan.TeachingPlanDesc  ==  AttributeName[intIndex])
{
return mstrTeachingPlanDesc;
}
else if (conJxTeachingPlan.IdGrade  ==  AttributeName[intIndex])
{
return mstrIdGrade;
}
else if (conJxTeachingPlan.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (conJxTeachingPlan.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conJxTeachingPlan.IsClgCheck  ==  AttributeName[intIndex])
{
return mbolIsClgCheck;
}
else if (conJxTeachingPlan.ClgNote  ==  AttributeName[intIndex])
{
return mstrClgNote;
}
else if (conJxTeachingPlan.ClgCheckerId  ==  AttributeName[intIndex])
{
return mstrClgCheckerId;
}
else if (conJxTeachingPlan.ClgCheckDate  ==  AttributeName[intIndex])
{
return mstrClgCheckDate;
}
else if (conJxTeachingPlan.IsSchCheck  ==  AttributeName[intIndex])
{
return mbolIsSchCheck;
}
else if (conJxTeachingPlan.SchNote  ==  AttributeName[intIndex])
{
return mstrSchNote;
}
else if (conJxTeachingPlan.SchCheckerId  ==  AttributeName[intIndex])
{
return mstrSchCheckerId;
}
else if (conJxTeachingPlan.SchCheckDate  ==  AttributeName[intIndex])
{
return mstrSchCheckDate;
}
else if (conJxTeachingPlan.IdSubmitStatus  ==  AttributeName[intIndex])
{
return mstrIdSubmitStatus;
}
else if (conJxTeachingPlan.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conJxTeachingPlan.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.IdTeachingPlan);
}
else if (conJxTeachingPlan.TeachingPlanId  ==  AttributeName[intIndex])
{
mstrTeachingPlanId = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.TeachingPlanId);
}
else if (conJxTeachingPlan.TeachingPlanDesc  ==  AttributeName[intIndex])
{
mstrTeachingPlanDesc = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.TeachingPlanDesc);
}
else if (conJxTeachingPlan.IdGrade  ==  AttributeName[intIndex])
{
mstrIdGrade = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.IdGrade);
}
else if (conJxTeachingPlan.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.SchoolTerm);
}
else if (conJxTeachingPlan.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.CourseId);
}
else if (conJxTeachingPlan.IsClgCheck  ==  AttributeName[intIndex])
{
mbolIsClgCheck = TransNullToBool(value.ToString());
 AddUpdatedFld(conJxTeachingPlan.IsClgCheck);
}
else if (conJxTeachingPlan.ClgNote  ==  AttributeName[intIndex])
{
mstrClgNote = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.ClgNote);
}
else if (conJxTeachingPlan.ClgCheckerId  ==  AttributeName[intIndex])
{
mstrClgCheckerId = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.ClgCheckerId);
}
else if (conJxTeachingPlan.ClgCheckDate  ==  AttributeName[intIndex])
{
mstrClgCheckDate = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.ClgCheckDate);
}
else if (conJxTeachingPlan.IsSchCheck  ==  AttributeName[intIndex])
{
mbolIsSchCheck = TransNullToBool(value.ToString());
 AddUpdatedFld(conJxTeachingPlan.IsSchCheck);
}
else if (conJxTeachingPlan.SchNote  ==  AttributeName[intIndex])
{
mstrSchNote = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.SchNote);
}
else if (conJxTeachingPlan.SchCheckerId  ==  AttributeName[intIndex])
{
mstrSchCheckerId = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.SchCheckerId);
}
else if (conJxTeachingPlan.SchCheckDate  ==  AttributeName[intIndex])
{
mstrSchCheckDate = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.SchCheckDate);
}
else if (conJxTeachingPlan.IdSubmitStatus  ==  AttributeName[intIndex])
{
mstrIdSubmitStatus = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.IdSubmitStatus);
}
else if (conJxTeachingPlan.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conJxTeachingPlan.Memo);
}
}
}

/// <summary>
/// 教案流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachingPlan
{
get
{
return mstrIdTeachingPlan;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachingPlan = value;
}
else
{
 mstrIdTeachingPlan = value;
}
//记录修改过的字段
 AddUpdatedFld(conJxTeachingPlan.IdTeachingPlan);
}
}
/// <summary>
/// 教学计划编号(说明:;字段类型:char;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingPlanId
{
get
{
return mstrTeachingPlanId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingPlanId = value;
}
else
{
 mstrTeachingPlanId = value;
}
//记录修改过的字段
 AddUpdatedFld(conJxTeachingPlan.TeachingPlanId);
}
}
/// <summary>
/// 教学计划名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingPlanDesc
{
get
{
return mstrTeachingPlanDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingPlanDesc = value;
}
else
{
 mstrTeachingPlanDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(conJxTeachingPlan.TeachingPlanDesc);
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
 AddUpdatedFld(conJxTeachingPlan.IdGrade);
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
 AddUpdatedFld(conJxTeachingPlan.SchoolTerm);
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
 AddUpdatedFld(conJxTeachingPlan.CourseId);
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
 AddUpdatedFld(conJxTeachingPlan.IsClgCheck);
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
 AddUpdatedFld(conJxTeachingPlan.ClgNote);
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
 AddUpdatedFld(conJxTeachingPlan.ClgCheckerId);
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
 AddUpdatedFld(conJxTeachingPlan.ClgCheckDate);
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
 AddUpdatedFld(conJxTeachingPlan.IsSchCheck);
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
 AddUpdatedFld(conJxTeachingPlan.SchNote);
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
 AddUpdatedFld(conJxTeachingPlan.SchCheckerId);
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
 AddUpdatedFld(conJxTeachingPlan.SchCheckDate);
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
 AddUpdatedFld(conJxTeachingPlan.IdSubmitStatus);
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
 AddUpdatedFld(conJxTeachingPlan.Memo);
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
  return mstrIdTeachingPlan;
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
  return mstrTeachingPlanDesc;
 }
 }
}
 /// <summary>
 /// 教学计划(JxTeachingPlan)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conJxTeachingPlan
{
public const string _CurrTabName = "JxTeachingPlan"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdTeachingPlan"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdTeachingPlan", "TeachingPlanId", "TeachingPlanDesc", "IdGrade", "SchoolTerm", "CourseId", "IsClgCheck", "ClgNote", "ClgCheckerId", "ClgCheckDate", "IsSchCheck", "SchNote", "SchCheckerId", "SchCheckDate", "IdSubmitStatus", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdTeachingPlan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingPlan = "IdTeachingPlan";    //教案流水号

 /// <summary>
 /// 常量:"TeachingPlanId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingPlanId = "TeachingPlanId";    //教学计划编号

 /// <summary>
 /// 常量:"TeachingPlanDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingPlanDesc = "TeachingPlanDesc";    //教学计划名称

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