
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_ExaminationCriteriaEN
 表名:ge_ExaminationCriteria(01120898)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
 /// 表ge_ExaminationCriteria的关键字(CriteriaId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CriteriaId_ge_ExaminationCriteria
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCriteriaId">表关键字</param>
public K_CriteriaId_ge_ExaminationCriteria(string strCriteriaId)
{
if (IsValid(strCriteriaId)) Value = strCriteriaId;
else
{
Value = null;
}
}
private static bool IsValid(string strCriteriaId)
{
if (string.IsNullOrEmpty(strCriteriaId) == true) return false;
if (strCriteriaId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CriteriaId_ge_ExaminationCriteria]类型的对象</returns>
public static implicit operator K_CriteriaId_ge_ExaminationCriteria(string value)
{
return new K_CriteriaId_ge_ExaminationCriteria(value);
}
}
 /// <summary>
 /// 题目检查标准表(ge_ExaminationCriteria)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_ExaminationCriteriaEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_ExaminationCriteria"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CriteriaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"CriteriaId", "QuestionId", "CourseId", "Describe", "ControlTypeId", "EventTypeId", "ExaminationTypeId", "ControlId", "ControlClass", "ControlValue", "ControlHtml", "UpdDate", "UpdUser", "Memo", "OrderNum"};

protected string mstrCriteriaId;    //标准Id
protected long mlngQuestionId;    //题目Id
protected string mstrCourseId;    //课程Id
protected string mstrDescribe;    //标准描述
protected string mstrControlTypeId;    //控件Id
protected string mstrEventTypeId;    //事件Id
protected string mstrExaminationTypeId;    //检查类型Id
protected string mstrControlId;    //控件Id
protected string mstrControlClass;    //控件样式
protected string mstrControlValue;    //控件值
protected string mstrControlHtml;    //控件html
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected int? mintOrderNum;    //序号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_ExaminationCriteriaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CriteriaId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCriteriaId">关键字:标准Id</param>
public clsge_ExaminationCriteriaEN(string strCriteriaId)
 {
strCriteriaId = strCriteriaId.Replace("'", "''");
if (strCriteriaId.Length > 10)
{
throw new Exception("在表:ge_ExaminationCriteria中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCriteriaId)  ==  true)
{
throw new Exception("在表:ge_ExaminationCriteria中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCriteriaId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCriteriaId = strCriteriaId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CriteriaId");
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
if (strAttributeName  ==  conge_ExaminationCriteria.CriteriaId)
{
return mstrCriteriaId;
}
else if (strAttributeName  ==  conge_ExaminationCriteria.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  conge_ExaminationCriteria.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conge_ExaminationCriteria.Describe)
{
return mstrDescribe;
}
else if (strAttributeName  ==  conge_ExaminationCriteria.ControlTypeId)
{
return mstrControlTypeId;
}
else if (strAttributeName  ==  conge_ExaminationCriteria.EventTypeId)
{
return mstrEventTypeId;
}
else if (strAttributeName  ==  conge_ExaminationCriteria.ExaminationTypeId)
{
return mstrExaminationTypeId;
}
else if (strAttributeName  ==  conge_ExaminationCriteria.ControlId)
{
return mstrControlId;
}
else if (strAttributeName  ==  conge_ExaminationCriteria.ControlClass)
{
return mstrControlClass;
}
else if (strAttributeName  ==  conge_ExaminationCriteria.ControlValue)
{
return mstrControlValue;
}
else if (strAttributeName  ==  conge_ExaminationCriteria.ControlHtml)
{
return mstrControlHtml;
}
else if (strAttributeName  ==  conge_ExaminationCriteria.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_ExaminationCriteria.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_ExaminationCriteria.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conge_ExaminationCriteria.OrderNum)
{
return mintOrderNum;
}
return null;
}
set
{
if (strAttributeName  ==  conge_ExaminationCriteria.CriteriaId)
{
mstrCriteriaId = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.CriteriaId);
}
else if (strAttributeName  ==  conge_ExaminationCriteria.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_ExaminationCriteria.QuestionId);
}
else if (strAttributeName  ==  conge_ExaminationCriteria.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.CourseId);
}
else if (strAttributeName  ==  conge_ExaminationCriteria.Describe)
{
mstrDescribe = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.Describe);
}
else if (strAttributeName  ==  conge_ExaminationCriteria.ControlTypeId)
{
mstrControlTypeId = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.ControlTypeId);
}
else if (strAttributeName  ==  conge_ExaminationCriteria.EventTypeId)
{
mstrEventTypeId = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.EventTypeId);
}
else if (strAttributeName  ==  conge_ExaminationCriteria.ExaminationTypeId)
{
mstrExaminationTypeId = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.ExaminationTypeId);
}
else if (strAttributeName  ==  conge_ExaminationCriteria.ControlId)
{
mstrControlId = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.ControlId);
}
else if (strAttributeName  ==  conge_ExaminationCriteria.ControlClass)
{
mstrControlClass = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.ControlClass);
}
else if (strAttributeName  ==  conge_ExaminationCriteria.ControlValue)
{
mstrControlValue = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.ControlValue);
}
else if (strAttributeName  ==  conge_ExaminationCriteria.ControlHtml)
{
mstrControlHtml = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.ControlHtml);
}
else if (strAttributeName  ==  conge_ExaminationCriteria.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.UpdDate);
}
else if (strAttributeName  ==  conge_ExaminationCriteria.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.UpdUser);
}
else if (strAttributeName  ==  conge_ExaminationCriteria.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.Memo);
}
else if (strAttributeName  ==  conge_ExaminationCriteria.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_ExaminationCriteria.OrderNum);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_ExaminationCriteria.CriteriaId  ==  AttributeName[intIndex])
{
return mstrCriteriaId;
}
else if (conge_ExaminationCriteria.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (conge_ExaminationCriteria.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conge_ExaminationCriteria.Describe  ==  AttributeName[intIndex])
{
return mstrDescribe;
}
else if (conge_ExaminationCriteria.ControlTypeId  ==  AttributeName[intIndex])
{
return mstrControlTypeId;
}
else if (conge_ExaminationCriteria.EventTypeId  ==  AttributeName[intIndex])
{
return mstrEventTypeId;
}
else if (conge_ExaminationCriteria.ExaminationTypeId  ==  AttributeName[intIndex])
{
return mstrExaminationTypeId;
}
else if (conge_ExaminationCriteria.ControlId  ==  AttributeName[intIndex])
{
return mstrControlId;
}
else if (conge_ExaminationCriteria.ControlClass  ==  AttributeName[intIndex])
{
return mstrControlClass;
}
else if (conge_ExaminationCriteria.ControlValue  ==  AttributeName[intIndex])
{
return mstrControlValue;
}
else if (conge_ExaminationCriteria.ControlHtml  ==  AttributeName[intIndex])
{
return mstrControlHtml;
}
else if (conge_ExaminationCriteria.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_ExaminationCriteria.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_ExaminationCriteria.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conge_ExaminationCriteria.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
return null;
}
set
{
if (conge_ExaminationCriteria.CriteriaId  ==  AttributeName[intIndex])
{
mstrCriteriaId = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.CriteriaId);
}
else if (conge_ExaminationCriteria.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_ExaminationCriteria.QuestionId);
}
else if (conge_ExaminationCriteria.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.CourseId);
}
else if (conge_ExaminationCriteria.Describe  ==  AttributeName[intIndex])
{
mstrDescribe = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.Describe);
}
else if (conge_ExaminationCriteria.ControlTypeId  ==  AttributeName[intIndex])
{
mstrControlTypeId = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.ControlTypeId);
}
else if (conge_ExaminationCriteria.EventTypeId  ==  AttributeName[intIndex])
{
mstrEventTypeId = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.EventTypeId);
}
else if (conge_ExaminationCriteria.ExaminationTypeId  ==  AttributeName[intIndex])
{
mstrExaminationTypeId = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.ExaminationTypeId);
}
else if (conge_ExaminationCriteria.ControlId  ==  AttributeName[intIndex])
{
mstrControlId = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.ControlId);
}
else if (conge_ExaminationCriteria.ControlClass  ==  AttributeName[intIndex])
{
mstrControlClass = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.ControlClass);
}
else if (conge_ExaminationCriteria.ControlValue  ==  AttributeName[intIndex])
{
mstrControlValue = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.ControlValue);
}
else if (conge_ExaminationCriteria.ControlHtml  ==  AttributeName[intIndex])
{
mstrControlHtml = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.ControlHtml);
}
else if (conge_ExaminationCriteria.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.UpdDate);
}
else if (conge_ExaminationCriteria.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.UpdUser);
}
else if (conge_ExaminationCriteria.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_ExaminationCriteria.Memo);
}
else if (conge_ExaminationCriteria.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_ExaminationCriteria.OrderNum);
}
}
}

/// <summary>
/// 标准Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CriteriaId
{
get
{
return mstrCriteriaId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCriteriaId = value;
}
else
{
 mstrCriteriaId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ExaminationCriteria.CriteriaId);
}
}
/// <summary>
/// 题目Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long QuestionId
{
get
{
return mlngQuestionId;
}
set
{
 mlngQuestionId = value;
//记录修改过的字段
 AddUpdatedFld(conge_ExaminationCriteria.QuestionId);
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
 AddUpdatedFld(conge_ExaminationCriteria.CourseId);
}
}
/// <summary>
/// 标准描述(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Describe
{
get
{
return mstrDescribe;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDescribe = value;
}
else
{
 mstrDescribe = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ExaminationCriteria.Describe);
}
}
/// <summary>
/// 控件Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ControlTypeId
{
get
{
return mstrControlTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrControlTypeId = value;
}
else
{
 mstrControlTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ExaminationCriteria.ControlTypeId);
}
}
/// <summary>
/// 事件Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EventTypeId
{
get
{
return mstrEventTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEventTypeId = value;
}
else
{
 mstrEventTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ExaminationCriteria.EventTypeId);
}
}
/// <summary>
/// 检查类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExaminationTypeId
{
get
{
return mstrExaminationTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExaminationTypeId = value;
}
else
{
 mstrExaminationTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ExaminationCriteria.ExaminationTypeId);
}
}
/// <summary>
/// 控件Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ControlId
{
get
{
return mstrControlId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrControlId = value;
}
else
{
 mstrControlId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ExaminationCriteria.ControlId);
}
}
/// <summary>
/// 控件样式(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ControlClass
{
get
{
return mstrControlClass;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrControlClass = value;
}
else
{
 mstrControlClass = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ExaminationCriteria.ControlClass);
}
}
/// <summary>
/// 控件值(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ControlValue
{
get
{
return mstrControlValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrControlValue = value;
}
else
{
 mstrControlValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ExaminationCriteria.ControlValue);
}
}
/// <summary>
/// 控件html(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ControlHtml
{
get
{
return mstrControlHtml;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrControlHtml = value;
}
else
{
 mstrControlHtml = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_ExaminationCriteria.ControlHtml);
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
 AddUpdatedFld(conge_ExaminationCriteria.UpdDate);
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
 AddUpdatedFld(conge_ExaminationCriteria.UpdUser);
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
 AddUpdatedFld(conge_ExaminationCriteria.Memo);
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
 AddUpdatedFld(conge_ExaminationCriteria.OrderNum);
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
  return mstrCriteriaId;
 }
 }
}
 /// <summary>
 /// 题目检查标准表(ge_ExaminationCriteria)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_ExaminationCriteria
{
public const string _CurrTabName = "ge_ExaminationCriteria"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CriteriaId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CriteriaId", "QuestionId", "CourseId", "Describe", "ControlTypeId", "EventTypeId", "ExaminationTypeId", "ControlId", "ControlClass", "ControlValue", "ControlHtml", "UpdDate", "UpdUser", "Memo", "OrderNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"CriteriaId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CriteriaId = "CriteriaId";    //标准Id

 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"Describe"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Describe = "Describe";    //标准描述

 /// <summary>
 /// 常量:"ControlTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlTypeId = "ControlTypeId";    //控件Id

 /// <summary>
 /// 常量:"EventTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EventTypeId = "EventTypeId";    //事件Id

 /// <summary>
 /// 常量:"ExaminationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExaminationTypeId = "ExaminationTypeId";    //检查类型Id

 /// <summary>
 /// 常量:"ControlId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlId = "ControlId";    //控件Id

 /// <summary>
 /// 常量:"ControlClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlClass = "ControlClass";    //控件样式

 /// <summary>
 /// 常量:"ControlValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlValue = "ControlValue";    //控件值

 /// <summary>
 /// 常量:"ControlHtml"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlHtml = "ControlHtml";    //控件html

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
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号
}

}