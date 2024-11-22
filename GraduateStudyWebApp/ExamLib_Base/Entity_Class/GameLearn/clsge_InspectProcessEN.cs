
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_InspectProcessEN
 表名:ge_InspectProcess(01120910)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:08
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
 /// 表ge_InspectProcess的关键字(InspectId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_InspectId_ge_InspectProcess
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strInspectId">表关键字</param>
public K_InspectId_ge_InspectProcess(string strInspectId)
{
if (IsValid(strInspectId)) Value = strInspectId;
else
{
Value = null;
}
}
private static bool IsValid(string strInspectId)
{
if (string.IsNullOrEmpty(strInspectId) == true) return false;
if (strInspectId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_InspectId_ge_InspectProcess]类型的对象</returns>
public static implicit operator K_InspectId_ge_InspectProcess(string value)
{
return new K_InspectId_ge_InspectProcess(value);
}
}
 /// <summary>
 /// 检查过程表(ge_InspectProcess)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_InspectProcessEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_InspectProcess"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "InspectId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"InspectId", "OperationTypeId", "QuestionId", "CourseId", "ControlId", "ControlTypeId", "CheckMemo", "ControlProp", "AttributeId", "ControlValue", "OrderNum", "UpdUser", "UpdDate", "Memo", "ControlClass", "EventTypeId", "ExaminationTypeId", "FunctionName"};

protected string mstrInspectId;    //检查Id
protected string mstrOperationTypeId;    //操作类型ID
protected long mlngQuestionId;    //题目Id
protected string mstrCourseId;    //课程Id
protected string mstrControlId;    //控件Id
protected string mstrControlTypeId;    //控件Id
protected string mstrCheckMemo;    //检查描述
protected string mstrControlProp;    //控件属性
protected string mstrAttributeId;    //控件属性Id
protected string mstrControlValue;    //控件值
protected int? mintOrderNum;    //序号
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrControlClass;    //控件样式
protected string mstrEventTypeId;    //事件Id
protected string mstrExaminationTypeId;    //检查类型Id
protected string mstrFunctionName;    //函数名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_InspectProcessEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("InspectId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strInspectId">关键字:检查Id</param>
public clsge_InspectProcessEN(string strInspectId)
 {
strInspectId = strInspectId.Replace("'", "''");
if (strInspectId.Length > 10)
{
throw new Exception("在表:ge_InspectProcess中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strInspectId)  ==  true)
{
throw new Exception("在表:ge_InspectProcess中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strInspectId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrInspectId = strInspectId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("InspectId");
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
if (strAttributeName  ==  conge_InspectProcess.InspectId)
{
return mstrInspectId;
}
else if (strAttributeName  ==  conge_InspectProcess.OperationTypeId)
{
return mstrOperationTypeId;
}
else if (strAttributeName  ==  conge_InspectProcess.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  conge_InspectProcess.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conge_InspectProcess.ControlId)
{
return mstrControlId;
}
else if (strAttributeName  ==  conge_InspectProcess.ControlTypeId)
{
return mstrControlTypeId;
}
else if (strAttributeName  ==  conge_InspectProcess.CheckMemo)
{
return mstrCheckMemo;
}
else if (strAttributeName  ==  conge_InspectProcess.ControlProp)
{
return mstrControlProp;
}
else if (strAttributeName  ==  conge_InspectProcess.AttributeId)
{
return mstrAttributeId;
}
else if (strAttributeName  ==  conge_InspectProcess.ControlValue)
{
return mstrControlValue;
}
else if (strAttributeName  ==  conge_InspectProcess.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conge_InspectProcess.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_InspectProcess.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_InspectProcess.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conge_InspectProcess.ControlClass)
{
return mstrControlClass;
}
else if (strAttributeName  ==  conge_InspectProcess.EventTypeId)
{
return mstrEventTypeId;
}
else if (strAttributeName  ==  conge_InspectProcess.ExaminationTypeId)
{
return mstrExaminationTypeId;
}
else if (strAttributeName  ==  conge_InspectProcess.FunctionName)
{
return mstrFunctionName;
}
return null;
}
set
{
if (strAttributeName  ==  conge_InspectProcess.InspectId)
{
mstrInspectId = value.ToString();
 AddUpdatedFld(conge_InspectProcess.InspectId);
}
else if (strAttributeName  ==  conge_InspectProcess.OperationTypeId)
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(conge_InspectProcess.OperationTypeId);
}
else if (strAttributeName  ==  conge_InspectProcess.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_InspectProcess.QuestionId);
}
else if (strAttributeName  ==  conge_InspectProcess.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_InspectProcess.CourseId);
}
else if (strAttributeName  ==  conge_InspectProcess.ControlId)
{
mstrControlId = value.ToString();
 AddUpdatedFld(conge_InspectProcess.ControlId);
}
else if (strAttributeName  ==  conge_InspectProcess.ControlTypeId)
{
mstrControlTypeId = value.ToString();
 AddUpdatedFld(conge_InspectProcess.ControlTypeId);
}
else if (strAttributeName  ==  conge_InspectProcess.CheckMemo)
{
mstrCheckMemo = value.ToString();
 AddUpdatedFld(conge_InspectProcess.CheckMemo);
}
else if (strAttributeName  ==  conge_InspectProcess.ControlProp)
{
mstrControlProp = value.ToString();
 AddUpdatedFld(conge_InspectProcess.ControlProp);
}
else if (strAttributeName  ==  conge_InspectProcess.AttributeId)
{
mstrAttributeId = value.ToString();
 AddUpdatedFld(conge_InspectProcess.AttributeId);
}
else if (strAttributeName  ==  conge_InspectProcess.ControlValue)
{
mstrControlValue = value.ToString();
 AddUpdatedFld(conge_InspectProcess.ControlValue);
}
else if (strAttributeName  ==  conge_InspectProcess.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_InspectProcess.OrderNum);
}
else if (strAttributeName  ==  conge_InspectProcess.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_InspectProcess.UpdUser);
}
else if (strAttributeName  ==  conge_InspectProcess.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_InspectProcess.UpdDate);
}
else if (strAttributeName  ==  conge_InspectProcess.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_InspectProcess.Memo);
}
else if (strAttributeName  ==  conge_InspectProcess.ControlClass)
{
mstrControlClass = value.ToString();
 AddUpdatedFld(conge_InspectProcess.ControlClass);
}
else if (strAttributeName  ==  conge_InspectProcess.EventTypeId)
{
mstrEventTypeId = value.ToString();
 AddUpdatedFld(conge_InspectProcess.EventTypeId);
}
else if (strAttributeName  ==  conge_InspectProcess.ExaminationTypeId)
{
mstrExaminationTypeId = value.ToString();
 AddUpdatedFld(conge_InspectProcess.ExaminationTypeId);
}
else if (strAttributeName  ==  conge_InspectProcess.FunctionName)
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(conge_InspectProcess.FunctionName);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_InspectProcess.InspectId  ==  AttributeName[intIndex])
{
return mstrInspectId;
}
else if (conge_InspectProcess.OperationTypeId  ==  AttributeName[intIndex])
{
return mstrOperationTypeId;
}
else if (conge_InspectProcess.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (conge_InspectProcess.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conge_InspectProcess.ControlId  ==  AttributeName[intIndex])
{
return mstrControlId;
}
else if (conge_InspectProcess.ControlTypeId  ==  AttributeName[intIndex])
{
return mstrControlTypeId;
}
else if (conge_InspectProcess.CheckMemo  ==  AttributeName[intIndex])
{
return mstrCheckMemo;
}
else if (conge_InspectProcess.ControlProp  ==  AttributeName[intIndex])
{
return mstrControlProp;
}
else if (conge_InspectProcess.AttributeId  ==  AttributeName[intIndex])
{
return mstrAttributeId;
}
else if (conge_InspectProcess.ControlValue  ==  AttributeName[intIndex])
{
return mstrControlValue;
}
else if (conge_InspectProcess.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conge_InspectProcess.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_InspectProcess.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_InspectProcess.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conge_InspectProcess.ControlClass  ==  AttributeName[intIndex])
{
return mstrControlClass;
}
else if (conge_InspectProcess.EventTypeId  ==  AttributeName[intIndex])
{
return mstrEventTypeId;
}
else if (conge_InspectProcess.ExaminationTypeId  ==  AttributeName[intIndex])
{
return mstrExaminationTypeId;
}
else if (conge_InspectProcess.FunctionName  ==  AttributeName[intIndex])
{
return mstrFunctionName;
}
return null;
}
set
{
if (conge_InspectProcess.InspectId  ==  AttributeName[intIndex])
{
mstrInspectId = value.ToString();
 AddUpdatedFld(conge_InspectProcess.InspectId);
}
else if (conge_InspectProcess.OperationTypeId  ==  AttributeName[intIndex])
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(conge_InspectProcess.OperationTypeId);
}
else if (conge_InspectProcess.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_InspectProcess.QuestionId);
}
else if (conge_InspectProcess.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_InspectProcess.CourseId);
}
else if (conge_InspectProcess.ControlId  ==  AttributeName[intIndex])
{
mstrControlId = value.ToString();
 AddUpdatedFld(conge_InspectProcess.ControlId);
}
else if (conge_InspectProcess.ControlTypeId  ==  AttributeName[intIndex])
{
mstrControlTypeId = value.ToString();
 AddUpdatedFld(conge_InspectProcess.ControlTypeId);
}
else if (conge_InspectProcess.CheckMemo  ==  AttributeName[intIndex])
{
mstrCheckMemo = value.ToString();
 AddUpdatedFld(conge_InspectProcess.CheckMemo);
}
else if (conge_InspectProcess.ControlProp  ==  AttributeName[intIndex])
{
mstrControlProp = value.ToString();
 AddUpdatedFld(conge_InspectProcess.ControlProp);
}
else if (conge_InspectProcess.AttributeId  ==  AttributeName[intIndex])
{
mstrAttributeId = value.ToString();
 AddUpdatedFld(conge_InspectProcess.AttributeId);
}
else if (conge_InspectProcess.ControlValue  ==  AttributeName[intIndex])
{
mstrControlValue = value.ToString();
 AddUpdatedFld(conge_InspectProcess.ControlValue);
}
else if (conge_InspectProcess.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conge_InspectProcess.OrderNum);
}
else if (conge_InspectProcess.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_InspectProcess.UpdUser);
}
else if (conge_InspectProcess.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_InspectProcess.UpdDate);
}
else if (conge_InspectProcess.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_InspectProcess.Memo);
}
else if (conge_InspectProcess.ControlClass  ==  AttributeName[intIndex])
{
mstrControlClass = value.ToString();
 AddUpdatedFld(conge_InspectProcess.ControlClass);
}
else if (conge_InspectProcess.EventTypeId  ==  AttributeName[intIndex])
{
mstrEventTypeId = value.ToString();
 AddUpdatedFld(conge_InspectProcess.EventTypeId);
}
else if (conge_InspectProcess.ExaminationTypeId  ==  AttributeName[intIndex])
{
mstrExaminationTypeId = value.ToString();
 AddUpdatedFld(conge_InspectProcess.ExaminationTypeId);
}
else if (conge_InspectProcess.FunctionName  ==  AttributeName[intIndex])
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(conge_InspectProcess.FunctionName);
}
}
}

/// <summary>
/// 检查Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string InspectId
{
get
{
return mstrInspectId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInspectId = value;
}
else
{
 mstrInspectId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_InspectProcess.InspectId);
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
 AddUpdatedFld(conge_InspectProcess.OperationTypeId);
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
 AddUpdatedFld(conge_InspectProcess.QuestionId);
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
 AddUpdatedFld(conge_InspectProcess.CourseId);
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
 AddUpdatedFld(conge_InspectProcess.ControlId);
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
 AddUpdatedFld(conge_InspectProcess.ControlTypeId);
}
}
/// <summary>
/// 检查描述(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckMemo
{
get
{
return mstrCheckMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckMemo = value;
}
else
{
 mstrCheckMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_InspectProcess.CheckMemo);
}
}
/// <summary>
/// 控件属性(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ControlProp
{
get
{
return mstrControlProp;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrControlProp = value;
}
else
{
 mstrControlProp = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_InspectProcess.ControlProp);
}
}
/// <summary>
/// 控件属性Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AttributeId
{
get
{
return mstrAttributeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAttributeId = value;
}
else
{
 mstrAttributeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_InspectProcess.AttributeId);
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
 AddUpdatedFld(conge_InspectProcess.ControlValue);
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
 AddUpdatedFld(conge_InspectProcess.OrderNum);
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
 AddUpdatedFld(conge_InspectProcess.UpdUser);
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
 AddUpdatedFld(conge_InspectProcess.UpdDate);
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
 AddUpdatedFld(conge_InspectProcess.Memo);
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
 AddUpdatedFld(conge_InspectProcess.ControlClass);
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
 AddUpdatedFld(conge_InspectProcess.EventTypeId);
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
 AddUpdatedFld(conge_InspectProcess.ExaminationTypeId);
}
}
/// <summary>
/// 函数名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionName
{
get
{
return mstrFunctionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionName = value;
}
else
{
 mstrFunctionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_InspectProcess.FunctionName);
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
  return mstrInspectId;
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
  return mstrOperationTypeId;
 }
 }
}
 /// <summary>
 /// 检查过程表(ge_InspectProcess)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_InspectProcess
{
public const string _CurrTabName = "ge_InspectProcess"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "InspectId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"InspectId", "OperationTypeId", "QuestionId", "CourseId", "ControlId", "ControlTypeId", "CheckMemo", "ControlProp", "AttributeId", "ControlValue", "OrderNum", "UpdUser", "UpdDate", "Memo", "ControlClass", "EventTypeId", "ExaminationTypeId", "FunctionName"};
//以下是属性变量


 /// <summary>
 /// 常量:"InspectId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InspectId = "InspectId";    //检查Id

 /// <summary>
 /// 常量:"OperationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationTypeId = "OperationTypeId";    //操作类型ID

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
 /// 常量:"ControlId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlId = "ControlId";    //控件Id

 /// <summary>
 /// 常量:"ControlTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlTypeId = "ControlTypeId";    //控件Id

 /// <summary>
 /// 常量:"CheckMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckMemo = "CheckMemo";    //检查描述

 /// <summary>
 /// 常量:"ControlProp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlProp = "ControlProp";    //控件属性

 /// <summary>
 /// 常量:"AttributeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttributeId = "AttributeId";    //控件属性Id

 /// <summary>
 /// 常量:"ControlValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlValue = "ControlValue";    //控件值

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

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
 /// 常量:"ControlClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ControlClass = "ControlClass";    //控件样式

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
 /// 常量:"FunctionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionName = "FunctionName";    //函数名
}

}