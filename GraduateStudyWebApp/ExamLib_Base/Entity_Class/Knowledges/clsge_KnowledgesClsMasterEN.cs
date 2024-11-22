
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_KnowledgesClsMasterEN
 表名:ge_KnowledgesClsMaster(01120962)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:12
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
 /// 表ge_KnowledgesClsMaster的关键字(IdCurrEduCls)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCurrEduCls_ge_KnowledgesClsMaster
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCurrEduCls">表关键字</param>
public K_IdCurrEduCls_ge_KnowledgesClsMaster(string strIdCurrEduCls)
{
if (IsValid(strIdCurrEduCls)) Value = strIdCurrEduCls;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true) return false;
if (strIdCurrEduCls.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCurrEduCls_ge_KnowledgesClsMaster]类型的对象</returns>
public static implicit operator K_IdCurrEduCls_ge_KnowledgesClsMaster(string value)
{
return new K_IdCurrEduCls_ge_KnowledgesClsMaster(value);
}
}
 /// <summary>
 /// 知识点教学班掌握度(ge_KnowledgesClsMaster)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_KnowledgesClsMasterEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_KnowledgesClsMaster"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCurrEduCls,CourseKnowledgeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"IdCurrEduCls", "CourseKnowledgeId", "CourseId", "MasterLevelId", "MasteryValue", "GoalValue", "SelfPerceivedValue", "UpdDate", "UpdUser", "Memo"};

protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCourseKnowledgeId;    //知识点Id
protected string mstrCourseId;    //课程Id
protected string mstrMasterLevelId;    //掌握度Id
protected double? mdblMasteryValue;    //掌握度
protected double? mdblGoalValue;    //目标值
protected double? mdblSelfPerceivedValue;    //自我认为值
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_KnowledgesClsMasterEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCurrEduCls");
 lstKeyFldNames.Add("CourseKnowledgeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCurrEduCls">关键字:教学班流水号</param>
public clsge_KnowledgesClsMasterEN(string strIdCurrEduCls , string strCourseKnowledgeId)
 {
strIdCurrEduCls = strIdCurrEduCls.Replace("'", "''");
if (strIdCurrEduCls.Length > 8)
{
throw new Exception("在表:ge_KnowledgesClsMaster中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCurrEduCls)  ==  true)
{
throw new Exception("在表:ge_KnowledgesClsMaster中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCurrEduCls);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCurrEduCls = strIdCurrEduCls;
this.mstrCourseKnowledgeId = strCourseKnowledgeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCurrEduCls");
 lstKeyFldNames.Add("CourseKnowledgeId");
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
if (strAttributeName  ==  conge_KnowledgesClsMaster.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.MasterLevelId)
{
return mstrMasterLevelId;
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.MasteryValue)
{
return mdblMasteryValue;
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.GoalValue)
{
return mdblGoalValue;
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.SelfPerceivedValue)
{
return mdblSelfPerceivedValue;
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conge_KnowledgesClsMaster.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conge_KnowledgesClsMaster.IdCurrEduCls);
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(conge_KnowledgesClsMaster.CourseKnowledgeId);
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_KnowledgesClsMaster.CourseId);
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.MasterLevelId)
{
mstrMasterLevelId = value.ToString();
 AddUpdatedFld(conge_KnowledgesClsMaster.MasterLevelId);
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.MasteryValue)
{
mdblMasteryValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KnowledgesClsMaster.MasteryValue);
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.GoalValue)
{
mdblGoalValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KnowledgesClsMaster.GoalValue);
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.SelfPerceivedValue)
{
mdblSelfPerceivedValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KnowledgesClsMaster.SelfPerceivedValue);
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_KnowledgesClsMaster.UpdDate);
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_KnowledgesClsMaster.UpdUser);
}
else if (strAttributeName  ==  conge_KnowledgesClsMaster.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_KnowledgesClsMaster.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_KnowledgesClsMaster.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conge_KnowledgesClsMaster.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (conge_KnowledgesClsMaster.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conge_KnowledgesClsMaster.MasterLevelId  ==  AttributeName[intIndex])
{
return mstrMasterLevelId;
}
else if (conge_KnowledgesClsMaster.MasteryValue  ==  AttributeName[intIndex])
{
return mdblMasteryValue;
}
else if (conge_KnowledgesClsMaster.GoalValue  ==  AttributeName[intIndex])
{
return mdblGoalValue;
}
else if (conge_KnowledgesClsMaster.SelfPerceivedValue  ==  AttributeName[intIndex])
{
return mdblSelfPerceivedValue;
}
else if (conge_KnowledgesClsMaster.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_KnowledgesClsMaster.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_KnowledgesClsMaster.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conge_KnowledgesClsMaster.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conge_KnowledgesClsMaster.IdCurrEduCls);
}
else if (conge_KnowledgesClsMaster.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(conge_KnowledgesClsMaster.CourseKnowledgeId);
}
else if (conge_KnowledgesClsMaster.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_KnowledgesClsMaster.CourseId);
}
else if (conge_KnowledgesClsMaster.MasterLevelId  ==  AttributeName[intIndex])
{
mstrMasterLevelId = value.ToString();
 AddUpdatedFld(conge_KnowledgesClsMaster.MasterLevelId);
}
else if (conge_KnowledgesClsMaster.MasteryValue  ==  AttributeName[intIndex])
{
mdblMasteryValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KnowledgesClsMaster.MasteryValue);
}
else if (conge_KnowledgesClsMaster.GoalValue  ==  AttributeName[intIndex])
{
mdblGoalValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KnowledgesClsMaster.GoalValue);
}
else if (conge_KnowledgesClsMaster.SelfPerceivedValue  ==  AttributeName[intIndex])
{
mdblSelfPerceivedValue = TransNullToDouble(value.ToString());
 AddUpdatedFld(conge_KnowledgesClsMaster.SelfPerceivedValue);
}
else if (conge_KnowledgesClsMaster.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_KnowledgesClsMaster.UpdDate);
}
else if (conge_KnowledgesClsMaster.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_KnowledgesClsMaster.UpdUser);
}
else if (conge_KnowledgesClsMaster.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_KnowledgesClsMaster.Memo);
}
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
 AddUpdatedFld(conge_KnowledgesClsMaster.IdCurrEduCls);
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
 AddUpdatedFld(conge_KnowledgesClsMaster.CourseKnowledgeId);
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
 AddUpdatedFld(conge_KnowledgesClsMaster.CourseId);
}
}
/// <summary>
/// 掌握度Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MasterLevelId
{
get
{
return mstrMasterLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMasterLevelId = value;
}
else
{
 mstrMasterLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_KnowledgesClsMaster.MasterLevelId);
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
 AddUpdatedFld(conge_KnowledgesClsMaster.MasteryValue);
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
 AddUpdatedFld(conge_KnowledgesClsMaster.GoalValue);
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
 AddUpdatedFld(conge_KnowledgesClsMaster.SelfPerceivedValue);
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
 AddUpdatedFld(conge_KnowledgesClsMaster.UpdDate);
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
 AddUpdatedFld(conge_KnowledgesClsMaster.UpdUser);
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
 AddUpdatedFld(conge_KnowledgesClsMaster.Memo);
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
  return mstrIdCurrEduCls;
 }
 }
}
 /// <summary>
 /// 知识点教学班掌握度(ge_KnowledgesClsMaster)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_KnowledgesClsMaster
{
public const string _CurrTabName = "ge_KnowledgesClsMaster"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCurrEduCls,CourseKnowledgeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCurrEduCls", "CourseKnowledgeId", "CourseId", "MasterLevelId", "MasteryValue", "GoalValue", "SelfPerceivedValue", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"CourseKnowledgeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeId = "CourseKnowledgeId";    //知识点Id

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"MasterLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MasterLevelId = "MasterLevelId";    //掌握度Id

 /// <summary>
 /// 常量:"MasteryValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MasteryValue = "MasteryValue";    //掌握度

 /// <summary>
 /// 常量:"GoalValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GoalValue = "GoalValue";    //目标值

 /// <summary>
 /// 常量:"SelfPerceivedValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SelfPerceivedValue = "SelfPerceivedValue";    //自我认为值

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