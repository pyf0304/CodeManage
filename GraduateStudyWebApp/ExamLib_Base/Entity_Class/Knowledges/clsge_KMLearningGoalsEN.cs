
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_KMLearningGoalsEN
 表名:ge_KMLearningGoals(01120960)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:22
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
 /// 表ge_KMLearningGoals的关键字(UserId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserId_ge_KMLearningGoals
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUserId">表关键字</param>
public K_UserId_ge_KMLearningGoals(string strUserId)
{
if (IsValid(strUserId)) Value = strUserId;
else
{
Value = null;
}
}
private static bool IsValid(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return false;
if (strUserId.Length > 18) return false;
if (strUserId.IndexOf(' ') >= 0) return false;
if (strUserId.IndexOf(')') >= 0) return false;
if (strUserId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UserId_ge_KMLearningGoals]类型的对象</returns>
public static implicit operator K_UserId_ge_KMLearningGoals(string value)
{
return new K_UserId_ge_KMLearningGoals(value);
}
}
 /// <summary>
 /// 知识点模块学习目标(ge_KMLearningGoals)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_KMLearningGoalsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_KMLearningGoals"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserId,KnowledgeModuleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"UserId", "KnowledgeModuleId", "MasteryValue", "SelfPerceivedValue", "GoalValue", "CourseId", "UpdDate", "UpdUser", "Memo"};

protected string mstrUserId;    //用户ID
protected string mstrKnowledgeModuleId;    //知识点模块Id
protected double? mdblMasteryValue;    //掌握度
protected double? mdblSelfPerceivedValue;    //自我认为值
protected double? mdblGoalValue;    //目标值
protected string mstrCourseId;    //课程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_KMLearningGoalsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserId");
 lstKeyFldNames.Add("KnowledgeModuleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strUserId">关键字:用户ID</param>
public clsge_KMLearningGoalsEN(string strUserId , string strKnowledgeModuleId)
 {
strUserId = strUserId.Replace("'", "''");
if (strUserId.Length > 18)
{
throw new Exception("在表:ge_KMLearningGoals中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("在表:ge_KMLearningGoals中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUserId = strUserId;
this.mstrKnowledgeModuleId = strKnowledgeModuleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("UserId");
 lstKeyFldNames.Add("KnowledgeModuleId");
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
if (strAttributeName  ==  conge_KMLearningGoals.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conge_KMLearningGoals.KnowledgeModuleId)
{
return mstrKnowledgeModuleId;
}
else if (strAttributeName  ==  conge_KMLearningGoals.MasteryValue)
{
return mdblMasteryValue;
}
else if (strAttributeName  ==  conge_KMLearningGoals.SelfPerceivedValue)
{
return mdblSelfPerceivedValue;
}
else if (strAttributeName  ==  conge_KMLearningGoals.GoalValue)
{
return mdblGoalValue;
}
else if (strAttributeName  ==  conge_KMLearningGoals.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conge_KMLearningGoals.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_KMLearningGoals.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_KMLearningGoals.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conge_KMLearningGoals.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conge_KMLearningGoals.UserId);
}
else if (strAttributeName  ==  conge_KMLearningGoals.KnowledgeModuleId)
{
mstrKnowledgeModuleId = value.ToString();
 AddUpdatedFld(conge_KMLearningGoals.KnowledgeModuleId);
}
else if (strAttributeName  ==  conge_KMLearningGoals.MasteryValue)
{
mdblMasteryValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KMLearningGoals.MasteryValue);
}
else if (strAttributeName  ==  conge_KMLearningGoals.SelfPerceivedValue)
{
mdblSelfPerceivedValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KMLearningGoals.SelfPerceivedValue);
}
else if (strAttributeName  ==  conge_KMLearningGoals.GoalValue)
{
mdblGoalValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KMLearningGoals.GoalValue);
}
else if (strAttributeName  ==  conge_KMLearningGoals.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_KMLearningGoals.CourseId);
}
else if (strAttributeName  ==  conge_KMLearningGoals.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_KMLearningGoals.UpdDate);
}
else if (strAttributeName  ==  conge_KMLearningGoals.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_KMLearningGoals.UpdUser);
}
else if (strAttributeName  ==  conge_KMLearningGoals.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_KMLearningGoals.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_KMLearningGoals.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conge_KMLearningGoals.KnowledgeModuleId  ==  AttributeName[intIndex])
{
return mstrKnowledgeModuleId;
}
else if (conge_KMLearningGoals.MasteryValue  ==  AttributeName[intIndex])
{
return mdblMasteryValue;
}
else if (conge_KMLearningGoals.SelfPerceivedValue  ==  AttributeName[intIndex])
{
return mdblSelfPerceivedValue;
}
else if (conge_KMLearningGoals.GoalValue  ==  AttributeName[intIndex])
{
return mdblGoalValue;
}
else if (conge_KMLearningGoals.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conge_KMLearningGoals.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_KMLearningGoals.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_KMLearningGoals.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conge_KMLearningGoals.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conge_KMLearningGoals.UserId);
}
else if (conge_KMLearningGoals.KnowledgeModuleId  ==  AttributeName[intIndex])
{
mstrKnowledgeModuleId = value.ToString();
 AddUpdatedFld(conge_KMLearningGoals.KnowledgeModuleId);
}
else if (conge_KMLearningGoals.MasteryValue  ==  AttributeName[intIndex])
{
mdblMasteryValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KMLearningGoals.MasteryValue);
}
else if (conge_KMLearningGoals.SelfPerceivedValue  ==  AttributeName[intIndex])
{
mdblSelfPerceivedValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KMLearningGoals.SelfPerceivedValue);
}
else if (conge_KMLearningGoals.GoalValue  ==  AttributeName[intIndex])
{
mdblGoalValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KMLearningGoals.GoalValue);
}
else if (conge_KMLearningGoals.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_KMLearningGoals.CourseId);
}
else if (conge_KMLearningGoals.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_KMLearningGoals.UpdDate);
}
else if (conge_KMLearningGoals.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_KMLearningGoals.UpdUser);
}
else if (conge_KMLearningGoals.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_KMLearningGoals.Memo);
}
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
 AddUpdatedFld(conge_KMLearningGoals.UserId);
}
}
/// <summary>
/// 知识点模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeModuleId
{
get
{
return mstrKnowledgeModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeModuleId = value;
}
else
{
 mstrKnowledgeModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_KMLearningGoals.KnowledgeModuleId);
}
}
/// <summary>
/// 掌握度(说明:;字段类型:numeric;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? MasteryValue
{
get
{
return mdblMasteryValue;
}
set
{
 mdblMasteryValue = value;
//记录修改过的字段
 AddUpdatedFld(conge_KMLearningGoals.MasteryValue);
}
}
/// <summary>
/// 自我认为值(说明:;字段类型:numeric;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? SelfPerceivedValue
{
get
{
return mdblSelfPerceivedValue;
}
set
{
 mdblSelfPerceivedValue = value;
//记录修改过的字段
 AddUpdatedFld(conge_KMLearningGoals.SelfPerceivedValue);
}
}
/// <summary>
/// 目标值(说明:;字段类型:numeric;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? GoalValue
{
get
{
return mdblGoalValue;
}
set
{
 mdblGoalValue = value;
//记录修改过的字段
 AddUpdatedFld(conge_KMLearningGoals.GoalValue);
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
 AddUpdatedFld(conge_KMLearningGoals.CourseId);
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
 AddUpdatedFld(conge_KMLearningGoals.UpdDate);
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
 AddUpdatedFld(conge_KMLearningGoals.UpdUser);
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
 AddUpdatedFld(conge_KMLearningGoals.Memo);
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
  return mstrUserId;
 }
 }
}
 /// <summary>
 /// 知识点模块学习目标(ge_KMLearningGoals)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_KMLearningGoals
{
public const string _CurrTabName = "ge_KMLearningGoals"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserId,KnowledgeModuleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserId", "KnowledgeModuleId", "MasteryValue", "SelfPerceivedValue", "GoalValue", "CourseId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"KnowledgeModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeModuleId = "KnowledgeModuleId";    //知识点模块Id

 /// <summary>
 /// 常量:"MasteryValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MasteryValue = "MasteryValue";    //掌握度

 /// <summary>
 /// 常量:"SelfPerceivedValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SelfPerceivedValue = "SelfPerceivedValue";    //自我认为值

 /// <summary>
 /// 常量:"GoalValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GoalValue = "GoalValue";    //目标值

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